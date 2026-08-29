using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using Windows;

public static class Headless
{
	public static readonly string GGPJHAENGMB = "1.2";

	private static bool GFCLLBKNNPE;

	private static bool PFDOCOPALNP;

	private static bool MBLHLILOGKA;

	private static bool GDNEENOCMMM;

	private static HeadlessRuntime NCMGLEBBHGM;

	private static string BNANJMCMIOG = string.Empty;

	[CompilerGenerated]
	private static Application.LogCallback HHCJILIGHNK;

	public static string GetProfileName()
	{
		if (!IsHeadless())
		{
			return null;
		}
		InitializeHeadless();
		return BNANJMCMIOG;
	}

	public static bool IsHeadless()
	{
		if (PFDOCOPALNP)
		{
			return GFCLLBKNNPE;
		}
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (Array.IndexOf(commandLineArgs, "-batchmode") >= 0)
		{
			GFCLLBKNNPE = true;
		}
		else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null)
		{
			GFCLLBKNNPE = true;
		}
		PFDOCOPALNP = true;
		return GFCLLBKNNPE;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
		if (IsHeadless())
		{
			InitializeHeadless();
			EFJOCMFBIEG.InvokeCallbacks("HeadlessBeforeSceneLoad");
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void OnAfterSceneLoadRuntimeMethod()
	{
		if (!IsHeadless())
		{
			return;
		}
		if (NCMGLEBBHGM.valueCamera)
		{
			GameObject gameObject = GameObject.Find("HeadlessBehaviour");
			if (gameObject == null)
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("HeadlessBehaviour"));
			}
			HeadlessBehaviour headlessBehaviour = gameObject.GetComponent<HeadlessBehaviour>();
			if (headlessBehaviour == null)
			{
				headlessBehaviour = gameObject.AddComponent<HeadlessBehaviour>();
			}
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(headlessBehaviour.GetComponent<HeadlessBehaviour>().NullifyCamera));
		}
		EFJOCMFBIEG.InvokeCallbacks("HeadlessAfterSceneLoad");
	}

	private static void InitializeHeadless()
	{
		if (MBLHLILOGKA)
		{
			return;
		}
		NCMGLEBBHGM = Resources.Load("HeadlessRuntime") as HeadlessRuntime;
		if (NCMGLEBBHGM != null)
		{
			BNANJMCMIOG = NCMGLEBBHGM.profileName;
			if (NCMGLEBBHGM.valueConsole)
			{
				BLADHOELLNP bLADHOELLNP = new BLADHOELLNP();
				bLADHOELLNP.Initialize();
				bLADHOELLNP.SetTitle(Application.productName);
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = HandleLog;
				}
				Application.logMessageReceived += HHCJILIGHNK;
			}
			if (NCMGLEBBHGM.valueLimitFramerate)
			{
				Application.targetFrameRate = NCMGLEBBHGM.valueFramerate;
				Debug.Log("Application target framerate set to " + NCMGLEBBHGM.valueFramerate);
			}
		}
		MBLHLILOGKA = true;
		EFJOCMFBIEG.InvokeCallbacks("HeadlessBeforeFirstSceneLoad");
	}

	private static void HandleLog(string GPDNCLKPPPA, string GJHCFAHGOBP, LogType FMHGAEIMMNH)
	{
		Console.WriteLine(GPDNCLKPPPA);
		if (GJHCFAHGOBP.Length > 1)
		{
			Console.WriteLine("in: " + GJHCFAHGOBP);
		}
	}

	public static bool IsBuildingHeadless()
	{
		if (GDNEENOCMMM)
		{
			return true;
		}
		return false;
	}

	public static void SetBuildingHeadless(bool LNDAKDHHOCJ, string FOFGPMEEJPJ)
	{
		GDNEENOCMMM = LNDAKDHHOCJ;
		BNANJMCMIOG = FOFGPMEEJPJ;
	}
}
