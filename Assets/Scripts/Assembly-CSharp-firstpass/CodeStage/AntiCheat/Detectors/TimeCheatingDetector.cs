using System;
using System.Collections;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
	public class TimeCheatingDetector : ACTkDetectorBase
	{
		public delegate void OnlineTimeCallback(OnlineTimeResult result);

		public delegate void TimeCheatingDetectorEventHandler(CheckResult checkResult, ErrorKind errorKind);

		public struct OnlineTimeResult
		{
			public bool success;

			public string error;

			public long errorResponseCode;

			public double onlineSecondsUtc;

			internal void SetTime(double secondsUtc)
			{
				success = true;
				error = null;
				errorResponseCode = -1L;
				onlineSecondsUtc = secondsUtc;
			}

			internal void SetError(string errorText, long responseCode = -1L)
			{
				success = false;
				error = errorText;
				errorResponseCode = responseCode;
				onlineSecondsUtc = -1.0;
			}

			public override string ToString()
			{
				if (success)
				{
					return "onlineSecondsUtc: " + onlineSecondsUtc;
				}
				return "Error response code: " + errorResponseCode + "\nError: " + error;
			}
		}

		public enum CheckResult
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}

		public enum ErrorKind
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}

		public enum RequestMethod
		{
			Head = 0,
			Get = 1
		}

		internal const string ComponentName = "Time Cheating Detector";

		private const string LogPrefix = "[ACTk] Time Cheating Detector: ";

		private const int DefaultTimeoutSeconds = 10;

		private static readonly WaitForEndOfFrame cachedEndOfFrame = new WaitForEndOfFrame();

		private static int instancesInScene;

		private static bool gettingOnlineTime;

		[Header("Request settings")]
		[Tooltip("Absolute URL which will return correct datetime in response headers (you may use popular web servers like google.com, microsoft.com etc.).")]
		[SerializeField]
		private string requestUrl = "https://google.com";

		[Tooltip("Method to use for url request. Use Head method if possible and fall back to get if server does not reply or block head requests.")]
		public RequestMethod requestMethod;

		[Tooltip("Online time request timeout in seconds.")]
		public int timeoutSeconds = 10;

		[Header("Settings in minutes")]
		[Tooltip("Time (in minutes) between detector checks.")]
		[Range(0f, 60f)]
		public float interval = 5f;

		[Tooltip("Maximum allowed difference between subsequent measurements, in minutes.")]
		[FormerlySerializedAs("threshold")]
		[Range(10f, 180f)]
		public int realCheatThreshold = 65;

		[Tooltip("Maximum allowed difference between local and online time, in minutes.")]
		[Range(1f, 180f)]
		public int wrongTimeThreshold = 65;

		private readonly string onlineOfflineDifferencePrefsKey = ObscuredString.EncryptDecrypt("onlineOfflineSecondsDifference", "TeslaOnMars");

		private Uri cachedUri;

		private TimeCheatingDetectorEventHandler cheatChecked;

		private float timeElapsed;

		private bool updateAfterPause;

		private double lastOnlineSecondsUtc;

		[NonSerialized]
		[Obsolete("Use wrongTimeThreshold instead.", true)]
		public int threshold = 65;

		[NonSerialized]
		[Obsolete("Use requestUrl instead", true)]
		public string timeServer = "google.com";

		public string RequestUrl
		{
			get
			{
				return requestUrl;
			}
			set
			{
				if (!(requestUrl == value) && Application.isPlaying)
				{
					requestUrl = value;
					cachedUri = UrlToUri(requestUrl);
				}
			}
		}

		public ErrorKind LastError { get; private set; }

		public CheckResult LastResult { get; private set; }

		public bool IsCheckingForCheat { get; private set; }

		public static TimeCheatingDetector Instance { get; private set; }

		private static TimeCheatingDetector GetOrCreateInstance
		{
			get
			{
				if (Instance != null)
				{
					return Instance;
				}
				if (ACTkDetectorBase.detectorsContainer == null)
				{
					ACTkDetectorBase.detectorsContainer = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				Instance = ACTkDetectorBase.detectorsContainer.AddComponent<TimeCheatingDetector>();
				return Instance;
			}
		}

		public event TimeCheatingDetectorEventHandler CheatChecked;

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action<ErrorKind> Error;

		[Obsolete("Please use CheatChecked event instead", true)]
		public event Action CheckPassed;

		private void Awake()
		{
			instancesInScene++;
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
			if (Init(Instance, "Time Cheating Detector"))
			{
				Instance = this;
			}
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			SceneManager.sceneLoaded -= OnLevelWasLoadedNew;
			instancesInScene--;
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			if (instancesInScene < 2)
			{
				if (!keepAlive)
				{
					DisposeInternal();
				}
			}
			else if (!keepAlive && Instance != this)
			{
				DisposeInternal();
			}
		}

		private void OnApplicationPause(bool pauseStatus)
		{
			if (started)
			{
				if (pauseStatus)
				{
					PauseDetector();
				}
				else
				{
					ResumeDetector();
				}
			}
		}

		private void Update()
		{
			if (!started || !isRunning || !(interval > 0f))
			{
				return;
			}
			if (updateAfterPause)
			{
				updateAfterPause = false;
				return;
			}
			timeElapsed += Time.unscaledDeltaTime;
			if (timeElapsed >= interval * 60f)
			{
				timeElapsed = 0f;
				StartCoroutine(CheckForCheat());
			}
		}

		public static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			return GetOrCreateInstance;
		}

		public static void StartDetection(TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			if (cheatCheckedEventHandler == null)
			{
				if (Instance != null)
				{
					Instance.StartDetectionInternal(Instance.interval);
				}
				else
				{
					StartDetection(GetOrCreateInstance.interval);
				}
			}
			else
			{
				StartDetection(GetOrCreateInstance.interval, cheatCheckedEventHandler);
			}
		}

		public static void StartDetection(float interval, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			GetOrCreateInstance.StartDetectionInternal(interval, cheatCheckedEventHandler);
		}

		public static void StopDetection()
		{
			if (Instance != null)
			{
				Instance.StopDetectionInternal();
			}
		}

		public static void Dispose()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		public static IEnumerator GetOnlineTimeCoroutine(string url, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			Uri uri = UrlToUri(url);
			yield return GetOnlineTimeCoroutine(uri, callback, method);
		}

		public static IEnumerator GetOnlineTimeCoroutine(Uri uri, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			if (gettingOnlineTime)
			{
				yield return cachedEndOfFrame;
			}
			gettingOnlineTime = true;
			OnlineTimeResult result = default(OnlineTimeResult);
			using (UnityWebRequest wr = GetWebRequest(uri, method))
			{
				yield return wr.Send();
				FillRequestResult(wr, ref result);
			}
			if (callback != null)
			{
				callback(result);
			}
			gettingOnlineTime = false;
		}

		private static UnityWebRequest GetWebRequest(Uri uri, RequestMethod method)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri.AbsoluteUri, (method != 0) ? "GET" : "HEAD");
			unityWebRequest.useHttpContinue = false;
			unityWebRequest.timeout = ((!Instance) ? 10 : Instance.timeoutSeconds);
			return unityWebRequest;
		}

		private static void FillRequestResult(UnityWebRequest request, ref OnlineTimeResult result)
		{
			if (!string.IsNullOrEmpty(request.error))
			{
				result.SetError(request.error, request.responseCode);
			}
			else
			{
				string responseHeader = request.GetResponseHeader("Date");
				if (!string.IsNullOrEmpty(responseHeader))
				{
					DateTime date;
					if (TryGetDate(responseHeader, out date))
					{
						double time = (double)date.ToUniversalTime().Ticks / 10000000.0;
						result.SetTime(time);
					}
					else
					{
						result.SetError("Couldn't parse 'Date' response header value\n " + responseHeader, request.responseCode);
					}
				}
				else
				{
					result.SetError("Couldn't find 'Date' response header value!", request.responseCode);
				}
			}
			if (!result.success)
			{
				Debug.Log("[ACTk] Time Cheating Detector: Online Time Retrieve error:\n" + result);
			}
		}

		private static Uri UrlToUri(string url)
		{
			Uri result;
			if (!Uri.TryCreate(url, UriKind.Absolute, out result))
			{
				Debug.LogError("[ACTk] Time Cheating Detector: Could not create URI from URL: " + url);
			}
			return result;
		}

		private static bool TryGetDate(string source, out DateTime date)
		{
			try
			{
				char[] array = source.ToCharArray(5, 20);
				int num = array[0] & 0xF;
				int num2 = array[1] & 0xF;
				int day = num * 10 + num2;
				int num3 = array[4];
				int num4 = array[5];
				int month;
				switch (num3 + num4)
				{
				case 207:
					month = 1;
					break;
				case 199:
					month = 2;
					break;
				case 211:
					month = 3;
					break;
				case 226:
					month = 4;
					break;
				case 218:
					month = 5;
					break;
				case 227:
					month = 6;
					break;
				case 225:
					month = 7;
					break;
				case 220:
					month = 8;
					break;
				case 213:
					month = 9;
					break;
				case 215:
					month = 10;
					break;
				case 229:
					month = 11;
					break;
				case 200:
					month = 12;
					break;
				default:
					month = 1;
					break;
				}
				int num5 = array[7] & 0xF;
				int num6 = array[8] & 0xF;
				int num7 = array[9] & 0xF;
				int num8 = array[10] & 0xF;
				int year = num5 * 1000 + num6 * 100 + num7 * 10 + num8;
				int num9 = array[12] & 0xF;
				int num10 = array[13] & 0xF;
				int hour = num9 * 10 + num10;
				int num11 = array[15] & 0xF;
				int num12 = array[16] & 0xF;
				int minute = num11 * 10 + num12;
				int num13 = array[18] & 0xF;
				int num14 = array[19] & 0xF;
				int second = num13 * 10 + num14;
				date = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
				return true;
			}
			catch (Exception ex)
			{
				Debug.LogError("[ACTk] Time Cheating Detector: Error while parsing date: " + ex);
				date = default(DateTime);
				return false;
			}
		}

		public bool ForceCheck()
		{
			if (!started || !isRunning)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: Detector should be started to use ForceCheck().");
				LastError = ErrorKind.NotStarted;
				LastResult = CheckResult.Error;
				return false;
			}
			if (IsCheckingForCheat)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: Can't force cheating check since another check is already in progress.");
				LastError = ErrorKind.AlreadyCheckingForCheat;
				LastResult = CheckResult.Error;
				return false;
			}
			timeElapsed = 0f;
			StartCoroutine(CheckForCheat());
			return true;
		}

		public IEnumerator ForceCheckEnumerator()
		{
			if (!started || !isRunning)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: Detector should be started to use ForceCheckEnumerator().");
				LastError = ErrorKind.NotStarted;
				LastResult = CheckResult.Error;
				yield break;
			}
			if (IsCheckingForCheat)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: Can't force cheating check since another check is already in progress.");
				LastError = ErrorKind.AlreadyCheckingForCheat;
				LastResult = CheckResult.Error;
				yield break;
			}
			timeElapsed = 0f;
			yield return CheckForCheat();
			while (IsCheckingForCheat)
			{
				yield return cachedEndOfFrame;
			}
		}

		private void StartDetectionInternal(float checkInterval, TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
		{
			if (isRunning)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (cheatCheckedEventHandler != null && detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Time Cheating Detector: has properly configured Detection Event in the inspector, but still get started with TimeCheatingDetectorCallback callback. Both TimeCheatingDetectorCallback and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			timeElapsed = 0f;
			cheatChecked = cheatCheckedEventHandler;
			interval = checkInterval;
			started = true;
			isRunning = true;
		}

		protected override bool Init(ACTkDetectorBase instance, string detectorName)
		{
			if (cachedUri == null)
			{
				cachedUri = UrlToUri(requestUrl);
			}
			return base.Init(instance, detectorName);
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(interval);
		}

		protected override bool DetectorHasCallbacks()
		{
			return base.DetectorHasCallbacks() || this.CheatChecked != null || cheatChecked != null;
		}

		protected override void PauseDetector()
		{
			base.PauseDetector();
			updateAfterPause = true;
		}

		protected override void StopDetectionInternal()
		{
			base.StopDetectionInternal();
			cheatChecked = null;
			this.CheatChecked = null;
		}

		protected override void DisposeInternal()
		{
			if (Instance == this)
			{
				Instance = null;
			}
			base.DisposeInternal();
		}

		private IEnumerator CheckForCheat()
		{
			if (!isRunning || IsCheckingForCheat)
			{
				yield break;
			}
			IsCheckingForCheat = true;
			LastError = ErrorKind.NoError;
			LastResult = CheckResult.Unknown;
			if (cachedUri == null)
			{
				LastError = ErrorKind.IncorrectUri;
				LastResult = CheckResult.Error;
			}
			else
			{
				yield return GetOnlineTimeCoroutine(cachedUri, OnOnlineTimeReceived, requestMethod);
			}
			if (!started || !isRunning)
			{
				LastError = ErrorKind.Unknown;
			}
			if (lastOnlineSecondsUtc <= 0.0 && LastError == ErrorKind.NoError)
			{
				LastError = ErrorKind.Unknown;
			}
			if (LastError != 0)
			{
				LastResult = CheckResult.Error;
				ReportCheckResult();
				IsCheckingForCheat = false;
				yield break;
			}
			double offlineSecondsUtc = GetLocalSecondsUtc();
			int offlineOnlineDifference = (int)Math.Abs(lastOnlineSecondsUtc - offlineSecondsUtc);
			LastResult = CheckResult.CheckPassed;
			if (offlineOnlineDifference > wrongTimeThreshold * 60)
			{
				LastResult = CheckResult.WrongTimeDetected;
			}
			int lastOfflineOnlineDifference2 = PlayerPrefs.GetInt(onlineOfflineDifferencePrefsKey, 0);
			if (lastOfflineOnlineDifference2 != 0)
			{
				lastOfflineOnlineDifference2 ^= 0x7FFFFFFF;
				int num = Math.Abs(offlineOnlineDifference - lastOfflineOnlineDifference2);
				if (realCheatThreshold < 10)
				{
					Debug.LogWarning("[ACTk] Time Cheating Detector: Please consider increasing realCheatThreshold to reduce false positives chance!");
				}
				if (num > realCheatThreshold * 60)
				{
					LastResult = CheckResult.CheatDetected;
				}
			}
			PlayerPrefs.SetInt(onlineOfflineDifferencePrefsKey, offlineOnlineDifference ^ 0x7FFFFFFF);
			IsCheckingForCheat = false;
			ReportCheckResult();
		}

		private void ReportCheckResult()
		{
			if (cheatChecked != null)
			{
				cheatChecked(LastResult, LastError);
			}
			if (this.CheatChecked != null)
			{
				this.CheatChecked(LastResult, LastError);
			}
			switch (LastResult)
			{
			case CheckResult.CheatDetected:
				OnCheatingDetected();
				break;
			case CheckResult.Unknown:
			case CheckResult.CheckPassed:
			case CheckResult.WrongTimeDetected:
			case CheckResult.Error:
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		private void OnOnlineTimeReceived(OnlineTimeResult result)
		{
			if (result.success)
			{
				lastOnlineSecondsUtc = result.onlineSecondsUtc;
				return;
			}
			lastOnlineSecondsUtc = -1.0;
			LastError = ErrorKind.OnlineTimeError;
		}

		private double GetLocalSecondsUtc()
		{
			return (double)DateTime.UtcNow.Ticks / 10000000.0;
		}

		[Obsolete("Please use GetOnlineTimeCoroutine or GetOnlineTimeTask instead", true)]
		public static double GetOnlineTime(string server)
		{
			return -1.0;
		}

		[Obsolete("Please use Instance.Error event instead.", true)]
		public static void SetErrorCallback(Action<ErrorKind> errorCallback)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, int interval)
		{
		}

		[Obsolete("Please use StartDetection(int, ...) instead.", true)]
		public static void StartDetection(Action detectionCallback, Action<ErrorKind> errorCallback, int interval)
		{
		}

		[Obsolete("Please use other overloads of this method instead", true)]
		public static void StartDetection(float interval, Action detectionCallback, Action<ErrorKind> errorCallback, Action checkPassedCallback)
		{
		}
	}
}
