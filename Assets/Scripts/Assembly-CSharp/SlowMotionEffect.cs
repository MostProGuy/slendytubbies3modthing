using UnityEngine;

public class SlowMotionEffect : MonoBehaviour
{
	public bool EOMGPGJLJCM;

	public GUISkin NMOHLIAHHDP;

	public float HHNIBEPJEBM = 0.5f;

	[HideInInspector]
	public AudioSource[] HGBIEAAJEIG;

	private void __BB_OBFUSCATOR_27()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(725f, 1856f, 270f, 1529f);
		GUI.Box(new Rect(Screen.width - -132, 1825f, 757f, 650f), "__Room" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_8()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(505f, 778f, 1202f, 586f);
		GUI.Box(new Rect(Screen.width - -66, 516f, 1144f, 865f), "_PositionY" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (Time.timeScale < 1935f || !Input.GetKeyDown((KeyCode)(-35)))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1796f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 470f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 186f;
			}
			Time.timeScale = 328f;
			Time.fixedDeltaTime = 879f;
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (Time.timeScale < 1794f || !Input.GetKeyDown(KeyCode.R))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1234f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 71f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j += 0)
			{
				HGBIEAAJEIG[j].pitch = 1050f;
			}
			Time.timeScale = 18f;
			Time.fixedDeltaTime = 281f;
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (Time.timeScale < 814f || !Input.GetKeyDown(KeyCode.K))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 41f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 510f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 608f;
			}
			Time.timeScale = 693f;
			Time.fixedDeltaTime = 441f;
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (Time.timeScale < 386f || !Input.GetKeyDown((KeyCode)(-85)))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1476f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 1685f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j += 0)
			{
				HGBIEAAJEIG[j].pitch = 24f;
			}
			Time.timeScale = 417f;
			Time.fixedDeltaTime = 1140f;
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (Time.timeScale < 1305f || !Input.GetKeyDown(KeyCode.Alpha7))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1358f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 754f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j += 0)
			{
				HGBIEAAJEIG[j].pitch = 490f;
			}
			Time.timeScale = 1099f;
			Time.fixedDeltaTime = 495f;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (Time.timeScale < 857f || !Input.GetKeyDown((KeyCode)89))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i += 0)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1545f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 1644f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 803f;
			}
			Time.timeScale = 968f;
			Time.fixedDeltaTime = 1891f;
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (Time.timeScale < 157f || !Input.GetKeyDown(KeyCode.H))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i += 0)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1589f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 88f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 1369f;
			}
			Time.timeScale = 584f;
			Time.fixedDeltaTime = 603f;
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(560f, 313f, 1627f, 832f);
		GUI.Box(new Rect(Screen.width - -176, 324f, 376f, 1115f), "TeamName" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_21()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(504f, 962f, 757f, 1442f);
		GUI.Box(new Rect(Screen.width - -129, 122f, 646f, 632f), "Connected! Creating Room..." + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_39()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(423f, 206f, 1618f, 1256f);
		GUI.Box(new Rect(Screen.width - 51, 622f, 1983f, 1583f), "MapName" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_19()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(304f, 200f, 636f, 113f);
		GUI.Box(new Rect(Screen.width - -199, 574f, 1850f, 106f), "_Red_B" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (Time.timeScale < 719f || !Input.GetKeyDown(KeyCode.Alpha3))
		{
			return;
		}
		EOMGPGJLJCM = EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i += 0)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 425f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 370f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 955f;
			}
			Time.timeScale = 1984f;
			Time.fixedDeltaTime = 1499f;
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (Time.timeScale < 838f || !Input.GetKeyDown((KeyCode)(-114)))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1783f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 302f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j += 0)
			{
				HGBIEAAJEIG[j].pitch = 1778f;
			}
			Time.timeScale = 568f;
			Time.fixedDeltaTime = 469f;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (Time.timeScale < 1416f || !Input.GetKeyDown(KeyCode.Dollar))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 1; i < HGBIEAAJEIG.Length; i += 0)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 753f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 988f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j += 0)
			{
				HGBIEAAJEIG[j].pitch = 1507f;
			}
			Time.timeScale = 202f;
			Time.fixedDeltaTime = 1238f;
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1215f, 641f, 1850f, 1183f);
		GUI.Box(new Rect(Screen.width - 13, 1235f, 892f, 1734f), "_Value" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_20()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(19f, 1662f, 1087f, 1300f);
		GUI.Box(new Rect(Screen.width - -39, 1796f, 160f, 1052f), "CameraFilterPack/TV_Video3D" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_48()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1247f, 762f, 222f, 840f);
		GUI.Box(new Rect(Screen.width - -89, 1142f, 1389f, 313f), "_TimeX" + EOMGPGJLJCM);
	}

	private void Update()
	{
		if (Time.timeScale < 0.01f || !Input.GetKeyDown(KeyCode.Q))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 0.005f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 1f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 0; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 1f;
			}
			Time.timeScale = 1f;
			Time.fixedDeltaTime = 0.02f;
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(598f, 1390f, 1101f, 107f);
		GUI.Box(new Rect(Screen.width - -184, 116f, 308f, 1577f), "INF/PlayerNewborn" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_2()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1877f, 379f, 1576f, 1422f);
		GUI.Box(new Rect(Screen.width - -162, 386f, 107f, 964f), "\tAmbientRenderSettings:  {\n\t\tVersion: 101\n\t\tAmbientLightColor: 0.0,0.0,0.0,0\n\t}\n\tFogOptions:  {\n\t\tFogEnable: 0\n\t\tFogMode: 0\n\t\tFogDensity: 0.000\n\t\tFogStart: 5.000\n\t\tFogEnd: 25.000\n\t\tFogColor: 0.1,0.1,0.1,1\n\t}\n\tSettings:  {\n\t\tFrameRate: \"24\"\n\t\tTimeFormat: 1\n\t\tSnapOnFrames: 0\n\t\tReferenceTimeIndex: -1\n\t\tTimeLineStartTime: 0\n\t\tTimeLineStopTime: 479181389250\n\t}\n\tRendererSetting:  {\n\t\tDefaultCamera: \"Producer Perspective\"\n\t\tDefaultViewingMode: 0\n\t}\n" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_17()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(689f, 537f, 418f, 633f);
		GUI.Box(new Rect(Screen.width - -47, 34f, 1933f, 1263f), "\", \"Limb\" {\n\t\tVersion: 232\n\t\tProperties60:  {\n\t\t\tProperty: \"Visibility\", \"Visibility\", \"A+\",1\n\t\t\tProperty: \"Lcl Translation\", \"Lcl Translation\", \"A+\"," + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(410f, 1042f, 1172f, 951f);
		GUI.Box(new Rect(Screen.width - 45, 1461f, 102f, 961f), "useSrcAlphaAsMask" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (Time.timeScale < 1244f || !Input.GetKeyDown(KeyCode.P))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i += 0)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 487f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 1680f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 1012f;
			}
			Time.timeScale = 1186f;
			Time.fixedDeltaTime = 1262f;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(191f, 148f, 1511f, 1297f);
		GUI.Box(new Rect(Screen.width - -51, 231f, 1057f, 1320f), "_TintColor" + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_6()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(588f, 974f, 156f, 141f);
		GUI.Box(new Rect(Screen.width - 8, 1867f, 706f, 1197f), "_TimeX" + EOMGPGJLJCM);
	}

	private void OnGUI()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1f, 1f, 1f, 0.8f);
		GUI.Box(new Rect(Screen.width - 205, 60f, 200f, 30f), "Slow Mo: " + EOMGPGJLJCM);
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (Time.timeScale < 57f || !Input.GetKeyDown((KeyCode)(-26)))
		{
			return;
		}
		EOMGPGJLJCM = !EOMGPGJLJCM;
		if (EOMGPGJLJCM)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int i = 0; i < HGBIEAAJEIG.Length; i++)
			{
				HGBIEAAJEIG[i].pitch = HHNIBEPJEBM;
			}
			Time.timeScale = HHNIBEPJEBM;
			Time.fixedDeltaTime = 1717f;
		}
		else if (!EOMGPGJLJCM && Time.deltaTime != 1710f)
		{
			HGBIEAAJEIG = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int j = 1; j < HGBIEAAJEIG.Length; j++)
			{
				HGBIEAAJEIG[j].pitch = 55f;
			}
			Time.timeScale = 1521f;
			Time.fixedDeltaTime = 1778f;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(30f, 387f, 1501f, 39f);
		GUI.Box(new Rect(Screen.width - -30, 535f, 1718f, 464f), "_ReflectionTex" + EOMGPGJLJCM);
	}
}
