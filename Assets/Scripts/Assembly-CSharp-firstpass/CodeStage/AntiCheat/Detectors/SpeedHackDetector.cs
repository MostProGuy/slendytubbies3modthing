using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_speed_hack_detector.html")]
	public class SpeedHackDetector : ACTkDetectorBase
	{
		internal const string ComponentName = "Speed Hack Detector";

		internal const string LogPrefix = "[ACTk] Speed Hack Detector: ";

		private const long TicksPerSecond = 10000000L;

		private const int Threshold = 5000000;

		private const float ThresholdFloat = 0.5f;

		private static int instancesInScene;

		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval = 1f;

		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives = 3;

		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown = 30;

		private byte currentFalsePositives;

		private int currentCooldownShots;

		private long ticksOnStart;

		private long vulnerableTicksOnStart;

		private long previousTicks;

		private long previousIntervalTicks;

		private float vulnerableTimeOnStart;

		public static SpeedHackDetector Instance { get; private set; }

		private static SpeedHackDetector GetOrCreateInstance
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
				Instance = ACTkDetectorBase.detectorsContainer.AddComponent<SpeedHackDetector>();
				return Instance;
			}
		}

		private SpeedHackDetector()
		{
		}

		public static SpeedHackDetector AddToSceneOrGetExisting()
		{
			return GetOrCreateInstance;
		}

		public static void StartDetection()
		{
			if (Instance != null)
			{
				Instance.StartDetectionInternal(null, Instance.interval, Instance.maxFalsePositives, Instance.coolDown);
			}
			else
			{
				Debug.LogError("[ACTk] Speed Hack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
		}

		public static void StartDetection(Action callback)
		{
			StartDetection(callback, GetOrCreateInstance.interval);
		}

		public static void StartDetection(Action callback, float interval)
		{
			StartDetection(callback, interval, GetOrCreateInstance.maxFalsePositives);
		}

		public static void StartDetection(Action callback, float interval, byte maxFalsePositives)
		{
			StartDetection(callback, interval, maxFalsePositives, GetOrCreateInstance.coolDown);
		}

		public static void StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown)
		{
			GetOrCreateInstance.StartDetectionInternal(callback, interval, maxFalsePositives, coolDown);
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

		private void Awake()
		{
			instancesInScene++;
			if (Init(Instance, "Speed Hack Detector"))
			{
				Instance = this;
			}
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
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

		private void OnApplicationPause(bool pause)
		{
			if (!pause)
			{
				ResetStartTicks();
			}
		}

		private void Update()
		{
			if (!isRunning)
			{
				return;
			}
			long reliableTicks = GetReliableTicks();
			long num = reliableTicks - previousTicks;
			if (num < 0 || num > 10000000)
			{
				ResetStartTicks();
				return;
			}
			previousTicks = reliableTicks;
			long num2 = (long)(interval * 10000000f);
			if (reliableTicks - previousIntervalTicks < num2)
			{
				return;
			}
			long num3 = reliableTicks - ticksOnStart;
			long num4 = (long)Environment.TickCount * 10000L;
			long num5 = num4 - vulnerableTicksOnStart;
			bool flag = Math.Abs(num5 - num3) > 5000000;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num6 = realtimeSinceStartup - vulnerableTimeOnStart;
			bool flag2 = Math.Abs((float)num3 / 10000000f - num6) > 0.5f;
			if (flag || flag2)
			{
				currentFalsePositives++;
				if (currentFalsePositives > maxFalsePositives)
				{
					OnCheatingDetected();
				}
				else
				{
					currentCooldownShots = 0;
					ResetStartTicks();
				}
			}
			else if (currentFalsePositives > 0 && coolDown > 0)
			{
				currentCooldownShots++;
				if (currentCooldownShots >= coolDown)
				{
					currentFalsePositives = 0;
				}
			}
			previousIntervalTicks = reliableTicks;
		}

		private void StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
			if (isRunning)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (callback != null && detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (callback == null && !detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			base.CheatDetected += callback;
			interval = checkInterval;
			maxFalsePositives = falsePositives;
			coolDown = shotsTillCooldown;
			ResetStartTicks();
			currentFalsePositives = 0;
			currentCooldownShots = 0;
			started = true;
			isRunning = true;
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(null, interval, maxFalsePositives, coolDown);
		}

		protected override void DisposeInternal()
		{
			base.DisposeInternal();
			if (Instance == this)
			{
				Instance = null;
			}
		}

		private void ResetStartTicks()
		{
			ticksOnStart = GetReliableTicks();
			vulnerableTicksOnStart = (long)Environment.TickCount * 10000L;
			previousTicks = ticksOnStart;
			previousIntervalTicks = ticksOnStart;
			vulnerableTimeOnStart = Time.realtimeSinceStartup;
		}

		private long GetReliableTicks()
		{
			long num = 0L;
			if (num == 0)
			{
				num = DateTime.UtcNow.Ticks;
			}
			return num;
		}
	}
}
