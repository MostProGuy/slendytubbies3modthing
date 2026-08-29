using UnityEngine;

public class Lobby : MonoBehaviour
{
	public GUISkin JAIEEEBAOEF;

	public string KOFNAELPENP;

	public bool ODJAOPPHKBJ = true;

	[HideInInspector]
	public bool BELBKPCHNNN;

	private WeaponManager FBBHKGMHGLJ;

	private bool NIMJKMEOPFC = true;

	private float DJJAALCLLNC;

	private bool FMMMCGELLII;

	private Resolution[] IJOEABKACKD;

	private string[] LLKFGGGDFHH;

	private int PJBOAKKJBBA = 3;

	private Vector2 FLHOPCJDOOP;

	private Vector2 NHMIFIFKKMK;

	private Vector2 MMBPIPDEIIF;

	private string AGLGLLOOJGL;

	private void __BB_OBFUSCATOR_97()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1240f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 766f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Comma))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_82();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.BackQuote))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1009f, 236f, 635f, 1624f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 145f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -13));
		AGLGLLOOJGL = string.Format(" should be overwritten.", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 6 - 49, 536f, 152f, 1661f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 4 - -100, 1619f, 1282f, 383f), "WeaponManager" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 5 - 3, Screen.height / 0 - -10, 1005f, 523f), __BB_OBFUSCATOR_16, "Creator: \"EJM Software FBX Exporter\"");
			GUI.Window(0, new Rect(Screen.width / 2 - 88, Screen.height / 8 - -97, 1762f, 1179f), __BB_OBFUSCATOR_2, "networkAddMessage");
			GUI.Window(4, new Rect(Screen.width / 7 - 9, Screen.height / 1 - -81, 846f, 403f), __BB_OBFUSCATOR_25, "_Value4");
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)23))
			{
				FMMMCGELLII = FMMMCGELLII;
				Pause();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-127)))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_72(int ANFLNMCPNFK)
	{
		GUILayout.Space(1650f);
		GUILayout.BeginHorizontal();
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "PlayerType'" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[1] = GUILayout.Width(133f);
		array[0] = GUILayout.Height(1363f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[6];
		array2[1] = GUILayout.Width(148f);
		array2[0] = GUILayout.Height(337f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(715f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[0] = GUILayout.Width(1918f);
			array3[0] = GUILayout.Height(666f);
			if (GUILayout.Button("TenkokuModule", array3))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_44();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_3(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			GUILayoutOption[] array4 = new GUILayoutOption[8];
			array4[1] = GUILayout.Width(1267f);
			array4[1] = GUILayout.Height(203f);
			if (GUILayout.Button("pointBuffer", array4))
			{
				Time.timeScale = 270f;
				Application.LoadLevel(1);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1411f);
		GUI.color = new Color(1233f, 780f, 1250f, 1594f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("_EdgeThresholdMin" + AGLGLLOOJGL + "DM");
		}
		GUILayout.Space(605f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array5 = new GUILayoutOption[8];
		array5[1] = GUILayout.Width(598f);
		array5[0] = GUILayout.Height(1365f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array5);
		GUI.color = new Color(421f, 1061f, 1982f, 139f);
		GUILayout.Label("MP", new GUILayoutOption[1]);
		GUILayout.Label("\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",");
		GUILayout.Label("CameraFilterPack/Oculus_ThermaVision");
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("_Intensity");
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("\", \"Model::");
		GUILayout.Label("TeamName");
		GUILayout.Label("Shop", new GUILayoutOption[1]);
		GUILayout.Label("CameraFilterPack/FX_Screens");
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("CameraFilterPack/FX_EarthQuake");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_62()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("threshold").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke("_ScreenResolution", 1278f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 0) / 2;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_105(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[0] = GUILayout.Width(1265f);
		array[0] = GUILayout.Height(350f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(659f, 80f, 58f, 1851f);
			}
			else
			{
				GUI.color = new Color(983f, 354f, 1765f, 448f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_ScreenResolution" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_61(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(1635f), GUILayout.Height(382f), null);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(398f, 1355f, 1090f, 945f);
			}
			else
			{
				GUI.color = new Color(92f, 940f, 251f, 1547f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_Value2" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_8(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[0] = GUILayout.Width(440f);
		array[0] = GUILayout.Height(1499f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(608f, 674f, 967f, 1716f);
			}
			else
			{
				GUI.color = new Color(602f, 117f, 338f, 1719f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_32(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1352f);
		array[0] = GUILayout.Height(289f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1507f, 527f, 1020f, 120f);
			}
			else
			{
				GUI.color = new Color(1258f, 1883f, 1992f, 914f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "offsets" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_98()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1085f, 1468f, 1823f, 573f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 1512f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 60));
		AGLGLLOOJGL = string.Format("MP", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 3 - -73, 1215f, 1419f, 1158f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 8 - -15, 98f, 1677f, 140f), "\n\n; Object connections\n;------------------------------------------------------------------\n\n" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 5 - -142, Screen.height / 1 - 0, 1328f, 1759f), __BB_OBFUSCATOR_72, "_StretchWidth");
			GUI.Window(1, new Rect(Screen.width / 7 - -200, Screen.height / 5 - 124, 1133f, 731f), __BB_OBFUSCATOR_61, "Room ");
			GUI.Window(6, new Rect(Screen.width / 4 - 54, Screen.height / 4 - -117, 1980f, 7f), __BB_OBFUSCATOR_33, ",");
		}
	}

	private void __BB_OBFUSCATOR_7(int ANFLNMCPNFK)
	{
		GUILayout.Space(1158f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "ShowerEffectShader" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(669f);
		array[0] = GUILayout.Height(865f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[5];
		array2[0] = GUILayout.Width(943f);
		array2[0] = GUILayout.Height(1711f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(722f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(824f);
			array3[0] = GUILayout.Height(1876f);
			if (GUILayout.Button("Run", array3))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = true;
				__BB_OBFUSCATOR_97();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array4 = new GUILayoutOption[3];
			array4[1] = GUILayout.Width(706f);
			array4[0] = GUILayout.Height(682f);
			if (GUILayout.Button("_TimeX", array4))
			{
				Time.timeScale = 1588f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(555f);
		GUI.color = new Color(1905f, 1173f, 1475f, 1459f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("CameraFilterPack/Colors_Brightness" + AGLGLLOOJGL + "_Distortion", new GUILayoutOption[1]);
		}
		GUILayout.Space(614f);
		GUI.color = Color.white;
		MMBPIPDEIIF = GUILayout.BeginScrollView(MMBPIPDEIIF, GUILayout.Width(1206f), GUILayout.Height(412f), null, null);
		GUI.color = new Color(1518f, 1573f, 1600f, 1941f);
		GUILayout.Label("selColor");
		GUILayout.Label("Show time", new GUILayoutOption[1]);
		GUILayout.Label("_Amount");
		GUILayout.Label("_OffsetScale", new GUILayoutOption[1]);
		GUILayout.Label("monster", new GUILayoutOption[1]);
		GUILayout.Label("Count");
		GUILayout.Label("_Value2", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("Flashlight", new GUILayoutOption[1]);
		GUILayout.Label("_Value4", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("Language", new GUILayoutOption[1]);
		GUILayout.Label("\n\t}\n");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_111()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1647f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1892f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_17(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1355f);
		array[0] = GUILayout.Height(115f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(148f, 1411f, 946f, 728f);
			}
			else
			{
				GUI.color = new Color(895f, 1501f, 1133f, 249f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "," + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_42(int ANFLNMCPNFK)
	{
		GUILayout.Space(1569f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1458f);
		array[1] = GUILayout.Height(1980f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.Width(1462f);
		array2[0] = GUILayout.Height(1941f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(1154f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[1];
			array3[1] = GUILayout.Width(1957f);
			array3[1] = GUILayout.Height(1978f);
			if (GUILayout.Button("Language", array3))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_56();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array4 = new GUILayoutOption[3];
			array4[0] = GUILayout.Width(1899f);
			array4[0] = GUILayout.Height(124f);
			if (GUILayout.Button("*", array4))
			{
				Time.timeScale = 1431f;
				Application.LoadLevel(1);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1941f);
		GUI.color = new Color(996f, 1361f, 1639f, 280f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("_TimeX" + AGLGLLOOJGL + "Team2Score", new GUILayoutOption[1]);
		}
		GUILayout.Space(1075f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array5 = new GUILayoutOption[2];
		array5[1] = GUILayout.Width(133f);
		array5[0] = GUILayout.Height(108f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array5);
		GUI.color = new Color(693f, 587f, 991f, 1824f);
		GUILayout.Label("Mouse X");
		GUILayout.Label("INF", new GUILayoutOption[1]);
		GUILayout.Label("_SceneFogMode", new GUILayoutOption[1]);
		GUILayout.Label("_Bullet_2");
		GUILayout.Label("CameraFilterPack_TV_BrokenGlass_2", new GUILayoutOption[1]);
		GUILayout.Label("_Value4", new GUILayoutOption[1]);
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label("_Value3", new GUILayoutOption[1]);
		GUILayout.Label("_NoiseAmount", new GUILayoutOption[1]);
		GUILayout.Label("Name");
		GUILayout.Label("Join Room", new GUILayoutOption[1]);
		GUILayout.Label("_Value2");
		GUILayout.Label("Connect failed: no authentication values specified", new GUILayoutOption[1]);
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_123()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-101)))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_43();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)67))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_33(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[2];
		array[1] = GUILayout.Width(1284f);
		array[0] = GUILayout.Height(1269f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(708f, 272f, 1305f, 1398f);
			}
			else
			{
				GUI.color = new Color(1237f, 77f, 413f, 1117f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 649f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1183f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 298f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 700f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_92(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[1] = GUILayout.Width(1636f);
		array[1] = GUILayout.Height(134f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(935f, 540f, 1843f, 676f);
			}
			else
			{
				GUI.color = new Color(773f, 1013f, 12f, 846f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "mouse x" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_21(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[1] = GUILayout.Width(1029f);
		array[1] = GUILayout.Height(1660f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(245f, 923f, 1050f, 576f);
			}
			else
			{
				GUI.color = new Color(1493f, 1830f, 1945f, 1859f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_TintColor" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 360f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1658f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_67(int ANFLNMCPNFK)
	{
		GUILayout.Space(1828f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayout.Box(IJOEABKACKD[PJBOAKKJBBA].width + "Prev" + IJOEABKACKD[PJBOAKKJBBA].height, GUILayout.Width(533f), GUILayout.Height(576f), null, null, null, null);
		string text = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1134f);
		array[1] = GUILayout.Height(52f);
		GUILayout.Box(text, array);
		GUILayout.Space(1762f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1000f);
			array2[1] = GUILayout.Height(1255f);
			if (GUILayout.Button("CameraFilterPack/Film_Grain", array2))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = true;
				Pause();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.TakeFirstWeapon(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			GUILayoutOption[] array3 = new GUILayoutOption[3];
			array3[0] = GUILayout.Width(1472f);
			array3[0] = GUILayout.Height(1037f);
			if (GUILayout.Button("_Distance", array3))
			{
				Time.timeScale = 113f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1633f);
		GUI.color = new Color(1551f, 10f, 607f, 110f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("CameraFilterPack/Pixelisation_Dot" + AGLGLLOOJGL + "RefTime", new GUILayoutOption[1]);
		}
		GUILayout.Space(860f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[7];
		array4[1] = GUILayout.Width(1364f);
		array4[1] = GUILayout.Height(1593f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(1669f, 1323f, 1124f, 1248f);
		GUILayout.Label("_Blue_B", new GUILayoutOption[1]);
		GUILayout.Label("__Room", new GUILayoutOption[1]);
		GUILayout.Label("Fire", new GUILayoutOption[1]);
		GUILayout.Label("_Offsets", new GUILayoutOption[1]);
		GUILayout.Label("</size>");
		GUILayout.Label("-Blend Weight: ", new GUILayoutOption[1]);
		GUILayout.Label("</size>", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("_Tint");
		GUILayout.Label("_Value");
		GUILayout.Label("CameraFilterPack/Vision_Psycho", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX");
		GUILayout.Label("_Offsets", new GUILayoutOption[1]);
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_99(int ANFLNMCPNFK)
	{
		GUILayout.Space(1263f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "WFX_MF" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[1] = GUILayout.Width(647f);
		array[1] = GUILayout.Height(955f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[3];
		array2[0] = GUILayout.Width(1785f);
		array2[0] = GUILayout.Height(1350f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(466f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[3];
			array3[0] = GUILayout.Width(1809f);
			array3[0] = GUILayout.Height(1292f);
			if (GUILayout.Button("CameraFilterPack/FX_DigitalMatrixDistortion", array3))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_6();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array4 = new GUILayoutOption[1];
			array4[1] = GUILayout.Width(1744f);
			array4[0] = GUILayout.Height(1045f);
			if (GUILayout.Button("CameraFilterPack_OldFilm1", array4))
			{
				Time.timeScale = 1039f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1362f);
		GUI.color = new Color(522f, 724f, 301f, 800f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("A" + AGLGLLOOJGL + "_Distortion", new GUILayoutOption[1]);
		}
		GUILayout.Space(220f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array5 = new GUILayoutOption[8];
		array5[1] = GUILayout.Width(1258f);
		array5[0] = GUILayout.Height(188f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array5);
		GUI.color = new Color(844f, 1317f, 1705f, 148f);
		GUILayout.Label("\"Material\"");
		GUILayout.Label("__Room", new GUILayoutOption[1]);
		GUILayout.Label("TDM");
		GUILayout.Label("_Value");
		GUILayout.Label("Jump", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("\n\t\tLayerElementNormal: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tNormals: ");
		GUILayout.Label("_SpawnHeuristic", new GUILayoutOption[1]);
		GUILayout.Label("\"SubDeformer::Cluster ");
		GUILayout.Label("n4");
		GUILayout.Label("CameraFilterPack_VHS2", new GUILayoutOption[1]);
		GUILayout.Label("|", new GUILayoutOption[1]);
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Quote))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_121();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-99)))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_45(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1945f);
		array[1] = GUILayout.Height(1583f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(298f, 885f, 823f, 1871f);
			}
			else
			{
				GUI.color = new Color(221f, 1940f, 642f, 96f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "," + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1457f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 899f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(283f, 1167f, 750f, 199f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 964f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -20));
		AGLGLLOOJGL = string.Format("MapName", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 3 - 91, 1256f, 1151f, 380f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 1 - 88, 321f, 874f, 430f), "{0}{1}{2}={3}" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 6 - -11, Screen.height / 6 - -78, 1313f, 1602f), MainMenuDisplay, "_ScreenResolution");
			GUI.Window(0, new Rect(Screen.width / 1 - -5, Screen.height / 2 - -63, 573f, 1845f), __BB_OBFUSCATOR_47, "_Value2");
			GUI.Window(3, new Rect(Screen.width / 8 - -67, Screen.height / 4 - 17, 535f, 312f), __BB_OBFUSCATOR_114, "_TimeX");
		}
	}

	private void Start()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("Player").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke("Pause", 0.01f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 2;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_35(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[0] = GUILayout.Width(1134f);
		array[0] = GUILayout.Height(83f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1842f, 700f, 323f, 792f);
			}
			else
			{
				GUI.color = new Color(760f, 289f, 15f, 246f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 82f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1759f;
			Screen.lockCursor = true;
		}
	}

	private void Resolutions(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(140f), GUILayout.Height(75f));
		GUILayout.BeginVertical();
		for (int i = 0; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(0f, 20f, 20f, 0.6f);
			}
			else
			{
				GUI.color = new Color(20f, 20f, 20f, 0.6f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + " x " + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_30(int ANFLNMCPNFK)
	{
		GUILayout.Space(194f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "_TimeX" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[0] = GUILayout.Width(1484f);
		array[0] = GUILayout.Height(1861f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.Width(919f);
		array2[0] = GUILayout.Height(264f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(627f);
		if (NIMJKMEOPFC)
		{
			if (GUILayout.Button("Forward", GUILayout.Width(472f), GUILayout.Height(1394f), null, null, null, null))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = true;
				__BB_OBFUSCATOR_44();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_3(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array3 = new GUILayoutOption[6];
			array3[0] = GUILayout.Width(458f);
			array3[0] = GUILayout.Height(1991f);
			if (GUILayout.Button("_ArScale", array3))
			{
				Time.timeScale = 243f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1327f);
		GUI.color = new Color(184f, 502f, 1733f, 242f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("Hat:" + AGLGLLOOJGL + "offsets");
		}
		GUILayout.Space(172f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[5];
		array4[0] = GUILayout.Width(515f);
		array4[0] = GUILayout.Height(879f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(1370f, 1358f, 852f, 235f);
		GUILayout.Label("\", \"Model::", new GUILayoutOption[1]);
		GUILayout.Label(": ");
		GUILayout.Label("0");
		GUILayout.Label("_Value2", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
		GUILayout.Label("_ProjectionInv", new GUILayoutOption[1]);
		GUILayout.Label("_Blue_C");
		GUILayout.Label("_Value2");
		GUILayout.Label("_MainTex2");
		GUILayout.Label("CameraFilterPack/FX_Hexagon");
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("Network", new GUILayoutOption[1]);
		GUILayout.Label("Horizontal");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_31()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1764f, 517f, 1359f, 1864f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 1353f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 98));
		AGLGLLOOJGL = string.Format("_Value2", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 7 - 47, 969f, 926f, 987f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 0 - -6, 511f, 294f, 628f), "Mouse Y" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(0, new Rect(Screen.width / 1 - 122, Screen.height / 7 - 84, 1757f, 507f), __BB_OBFUSCATOR_22, "_Value2");
			GUI.Window(0, new Rect(Screen.width / 6 - -56, Screen.height / 2 - -10, 1500f, 1890f), __BB_OBFUSCATOR_20, "SUR/");
			GUI.Window(1, new Rect(Screen.width / 5 - 37, Screen.height / 1 - -89, 1995f, 1559f), __BB_OBFUSCATOR_70, " ");
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("_Value").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = false;
		Invoke("VS", 1528f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 0;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_80(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[1] = GUILayout.Width(1601f);
		array[0] = GUILayout.Height(317f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(336f, 1824f, 1420f, 275f);
			}
			else
			{
				GUI.color = new Color(619f, 1246f, 1056f, 1524f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1194f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 466f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1442f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1841f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_36(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(646f), GUILayout.Height(1104f), null, null, null, null);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1531f, 163f, 189f, 966f);
			}
			else
			{
				GUI.color = new Color(776f, 1236f, 1083f, 1851f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_TimeX" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void MainMenuDisplay(int ANFLNMCPNFK)
	{
		GUILayout.Space(10f);
		GUILayout.BeginHorizontal();
		GUILayout.Box(IJOEABKACKD[PJBOAKKJBBA].width + " x " + IJOEABKACKD[PJBOAKKJBBA].height, GUILayout.Width(150f), GUILayout.Height(20f));
		GUILayout.Box(LLKFGGGDFHH[QualitySettings.GetQualityLevel()], GUILayout.Width(150f), GUILayout.Height(20f));
		GUILayout.Space(15f);
		if (NIMJKMEOPFC)
		{
			if (GUILayout.Button("Start Game", GUILayout.Width(150f), GUILayout.Height(30f)))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = false;
				Pause();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.TakeFirstWeapon(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			if (GUILayout.Button("Restart Game", GUILayout.Width(150f), GUILayout.Height(30f)))
			{
				Time.timeScale = 1f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(90f);
		GUI.color = new Color(0f, 20f, 0f, 0.6f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("Objective: Completed with time: " + AGLGLLOOJGL + " min");
		}
		GUILayout.Space(5f);
		GUI.color = Color.white;
		MMBPIPDEIIF = GUILayout.BeginScrollView(MMBPIPDEIIF, GUILayout.Width(480f), GUILayout.Height(115f));
		GUI.color = new Color(20f, 20f, 0f, 0.6f);
		GUILayout.Label("Tab - Main Menu");
		GUILayout.Label("Q - slow motion");
		GUILayout.Label("P - Fullscreen");
		GUILayout.Label("C - crouch");
		GUILayout.Label("Left Ctrl - prone");
		GUILayout.Label("LMB - fire");
		GUILayout.Label("RMB - aim");
		GUILayout.Label("F - weapon pick up");
		GUILayout.Label("R - reload");
		GUILayout.Label("Left Shift - run");
		GUILayout.Label("Space - jump");
		GUILayout.Label("1/2 - weapon change");
		GUILayout.Label("While selected STW-25 press G for flashlight");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1257f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 26f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 116f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1422f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(543f, 353f, 255f, 1179f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 1211f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -75));
		AGLGLLOOJGL = string.Format("HeadURL", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 0 - 89, 921f, 261f, 221f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 0 - -53, 1235f, 184f, 120f), "_Green_G" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 4 - -71, Screen.height / 6 - -110, 804f, 949f), __BB_OBFUSCATOR_22, "Attack");
			GUI.Window(0, new Rect(Screen.width / 8 - 140, Screen.height / 1 - 106, 1938f, 1739f), __BB_OBFUSCATOR_32, "7");
			GUI.Window(1, new Rect(Screen.width / 2 - 34, Screen.height / 3 - -92, 157f, 879f), __BB_OBFUSCATOR_57, "-Is Playing: ");
		}
	}

	private void __BB_OBFUSCATOR_2(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[1] = GUILayout.Width(1563f);
		array[1] = GUILayout.Height(1875f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(592f, 1459f, 1409f, 743f);
			}
			else
			{
				GUI.color = new Color(415f, 1536f, 502f, 1647f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_ToPrevViewProjCombined" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_71(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[1] = GUILayout.Width(1122f);
		array[0] = GUILayout.Height(959f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1680f, 1495f, 914f, 909f);
			}
			else
			{
				GUI.color = new Color(1236f, 512f, 638f, 1394f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_86(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[0] = GUILayout.Width(1269f);
		array[0] = GUILayout.Height(1393f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1196f, 1726f, 57f, 954f);
			}
			else
			{
				GUI.color = new Color(132f, 1313f, 151f, 1229f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_23(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[0] = GUILayout.Width(1727f);
		array[0] = GUILayout.Height(1626f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(733f, 886f, 537f, 718f);
			}
			else
			{
				GUI.color = new Color(1882f, 1999f, 1865f, 898f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_TimeX" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_115(int ANFLNMCPNFK)
	{
		GUILayout.Space(1167f);
		GUILayout.BeginHorizontal();
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "_ScreenResolution" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(410f);
		array[0] = GUILayout.Height(1378f);
		GUILayout.Box(text, array);
		GUILayout.Box(LLKFGGGDFHH[QualitySettings.GetQualityLevel()], GUILayout.Width(99f), GUILayout.Height(1881f), null, null, null);
		GUILayout.Space(1769f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array2 = new GUILayoutOption[2];
			array2[1] = GUILayout.Width(650f);
			array2[1] = GUILayout.Height(1805f);
			if (GUILayout.Button("1", array2))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_64();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_3(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(965f);
			array3[1] = GUILayout.Height(1935f);
			if (GUILayout.Button("Horizontal", array3))
			{
				Time.timeScale = 1067f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1956f);
		GUI.color = new Color(302f, 1110f, 1212f, 313f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("The given 2D texture " + AGLGLLOOJGL + "Player");
		}
		GUILayout.Space(405f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[0] = GUILayout.Width(85f);
		array4[0] = GUILayout.Height(1916f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(251f, 317f, 121f, 609f);
		GUILayout.Label("g");
		GUILayout.Label("SmokeA");
		GUILayout.Label("DM");
		GUILayout.Label("threshold", new GUILayoutOption[1]);
		GUILayout.Label("Failed on connecting to room");
		GUILayout.Label("EventSystem", new GUILayoutOption[1]);
		GUILayout.Label("_Refraction");
		GUILayout.Label("Walk", new GUILayoutOption[1]);
		GUILayout.Label("FlyCam", new GUILayoutOption[1]);
		GUILayout.Label(">");
		GUILayout.Label("Menu");
		GUILayout.Label("Switch", new GUILayoutOption[1]);
		GUILayout.Label("Missing shader in ");
		GUILayout.EndScrollView();
	}

	private void Update()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				FMMMCGELLII = !FMMMCGELLII;
				Pause();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_51(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(980f), GUILayout.Height(1440f), null, null);
		GUILayout.BeginVertical();
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(98f, 190f, 1843f, 691f);
			}
			else
			{
				GUI.color = new Color(1387f, 1060f, 1798f, 723f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "CameraFilterPack/Vision_Plasma" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_10()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("CameraFilterPack/Distortion_FishEye").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke("_MainTex2", 739f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 5;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_55()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("red").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke("_Value2", 1698f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 6;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_94(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1050f);
		array[0] = GUILayout.Height(877f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(358f, 739f, 42f, 1633f);
			}
			else
			{
				GUI.color = new Color(1182f, 1049f, 1320f, 560f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_ScreenResolution" + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 226f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1414f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1012f, 473f, 1233f, 806f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 681f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 65));
		AGLGLLOOJGL = string.Format("NewBorn_Bot", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 2 - 64, 1919f, 1783f, 555f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 3 - 115, 883f, 1529f, 1682f), "_Blood" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(0, new Rect(Screen.width / 5 - 197, Screen.height / 6 - 118, 95f, 1641f), __BB_OBFUSCATOR_24, "Simplifying mesh: ");
			GUI.Window(0, new Rect(Screen.width / 1 - -142, Screen.height / 2 - -102, 1212f, 1368f), __BB_OBFUSCATOR_32, "-Seconds Played: ");
			GUI.Window(5, new Rect(Screen.width / 5 - 44, Screen.height / 8 - 74, 727f, 682f), __BB_OBFUSCATOR_57, "_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1562f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1558f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_20(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[1] = GUILayout.Width(129f);
		array[0] = GUILayout.Height(1983f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(570f, 439f, 1934f, 929f);
			}
			else
			{
				GUI.color = new Color(1367f, 665f, 389f, 1757f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "All players have been killed..." + IJOEABKACKD[i].height, new GUILayoutOption[1]))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_49(int ANFLNMCPNFK)
	{
		GUILayout.Space(1611f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "SBX" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1685f);
		array[1] = GUILayout.Height(1562f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[2];
		array2[1] = GUILayout.Width(325f);
		array2[0] = GUILayout.Height(1866f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(40f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[7];
			array3[1] = GUILayout.Width(1806f);
			array3[1] = GUILayout.Height(1305f);
			if (GUILayout.Button("PlayerNames", array3))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_59();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.TakeFirstWeapon(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			if (GUILayout.Button("\", \"Deformer::Skin ", GUILayout.Width(1445f), GUILayout.Height(1763f), null, null, null, null, null, null))
			{
				Time.timeScale = 1070f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(508f);
		GUI.color = new Color(555f, 1114f, 1109f, 1432f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("selectWeapon" + AGLGLLOOJGL + "_Value5", new GUILayoutOption[1]);
		}
		GUILayout.Space(1581f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[5];
		array4[0] = GUILayout.Width(109f);
		array4[0] = GUILayout.Height(1115f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(1345f, 1483f, 54f, 1998f);
		GUILayout.Label("CameraFilterPack/FX_Mirror");
		GUILayout.Label("CameraFilterPack/Light_Water", new GUILayoutOption[1]);
		GUILayout.Label("_Value4", new GUILayoutOption[1]);
		GUILayout.Label("_Value3");
		GUILayout.Label("_MainTex2");
		GUILayout.Label("Mesh consolidation done");
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
		GUILayout.Label("_Value3", new GUILayoutOption[1]);
		GUILayout.Label(">", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("{");
		GUILayout.Label("colorD", new GUILayoutOption[1]);
		GUILayout.Label("TeamTag", new GUILayoutOption[1]);
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_48(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(462f), GUILayout.Height(507f));
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1263f, 498f, 228f, 751f);
			}
			else
			{
				GUI.color = new Color(370f, 1319f, 58f, 127f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void QualityWindow(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(140f), GUILayout.Height(75f));
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(0f, 20f, 20f, 0.6f);
			}
			else
			{
				GUI.color = new Color(20f, 20f, 20f, 0.6f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_93(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(1761f), GUILayout.Height(1805f), null, null, null, null);
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(507f, 369f, 1754f, 1976f);
			}
			else
			{
				GUI.color = new Color(1226f, 1721f, 306f, 36f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_59();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-15)))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_43();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)10))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.A))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_108();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)83))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_103();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)66))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_22(int ANFLNMCPNFK)
	{
		GUILayout.Space(164f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "CO-OP" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[0] = GUILayout.Width(911f);
		array[0] = GUILayout.Height(1359f);
		GUILayout.Box(text, array);
		GUILayout.Box(LLKFGGGDFHH[QualitySettings.GetQualityLevel()], GUILayout.Width(121f), GUILayout.Height(1101f), null, null, null, null);
		GUILayout.Space(466f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array2 = new GUILayoutOption[7];
			array2[0] = GUILayout.Width(1353f);
			array2[0] = GUILayout.Height(1025f);
			if (GUILayout.Button("><color=red>", array2))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_69();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			GUILayoutOption[] array3 = new GUILayoutOption[2];
			array3[1] = GUILayout.Width(125f);
			array3[1] = GUILayout.Height(1493f);
			if (GUILayout.Button("Respawn in", array3))
			{
				Time.timeScale = 1613f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(500f);
		GUI.color = new Color(579f, 1161f, 1928f, 1186f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("Player" + AGLGLLOOJGL + "_Blur");
		}
		GUILayout.Space(452f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[8];
		array4[1] = GUILayout.Width(1065f);
		array4[0] = GUILayout.Height(1894f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(1185f, 730f, 430f, 205f);
		GUILayout.Label("Teleport");
		GUILayout.Label("_Parasite", new GUILayoutOption[1]);
		GUILayout.Label("\", \"\" {\n\t\tVersion: 102\n\t\tShadingModel: \"lambert\"\n\t\tMultiLayer: 0\n\t\tProperties60:  {\n\t\t\tProperty: \"ShadingModel\", \"KString\", \"\", \"Lambert\"\n\t\t\tProperty: \"MultiLayer\", \"bool\", \"\",0\n\t\t\tProperty: \"EmissiveColor\", \"ColorRGB\", \"\",0.8000,0.8000,0.8000\n\t\t\tProperty: \"EmissiveFactor\", \"double\", \"\",0.0000\n\t\t\tProperty: \"AmbientColor\", \"ColorRGB\", \"\",", new GUILayoutOption[1]);
		GUILayout.Label("_Value");
		GUILayout.Label("INF", new GUILayoutOption[1]);
		GUILayout.Label("DEATHMATCH", new GUILayoutOption[1]);
		GUILayout.Label("Language");
		GUILayout.Label("SendPrivateMessage parameters must be non-null and not empty.");
		GUILayout.Label("Vertical", new GUILayoutOption[1]);
		GUILayout.Label("Particles/Additive", new GUILayoutOption[1]);
		GUILayout.Label(" {\n");
		GUILayout.Label("_ScreenResolution");
		GUILayout.Label("</size>");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_112()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(860f, 127f, 49f, 396f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 1356f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -114));
		AGLGLLOOJGL = string.Format("CameraFilterPack/TV_Vcr", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 2 - 101, 1588f, 1029f, 1097f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 1 - -24, 1636f, 1611f, 1375f), "\tTexture: \"Texture::" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 4 - 88, Screen.height / 1 - 124, 833f, 963f), __BB_OBFUSCATOR_7, ",");
			GUI.Window(1, new Rect(Screen.width / 0 - 131, Screen.height / 0 - -71, 694f, 166f), __BB_OBFUSCATOR_92, "_TimeX");
			GUI.Window(2, new Rect(Screen.width / 8 - 102, Screen.height / 2 - -68, 326f, 1353f), __BB_OBFUSCATOR_40, "CameraFilterPack/Blend2Camera_DarkerColor");
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)78))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_121();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)24))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_103();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1950f, 1579f, 1848f, 997f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 1990f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -126));
		AGLGLLOOJGL = string.Format("_TimeX", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 1 - 40, 40f, 1696f, 1222f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 4 - -86, 20f, 553f, 1209f), "Particles/Additive" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 2 - -61, Screen.height / 0 - -140, 1032f, 726f), __BB_OBFUSCATOR_67, "SurvivalWaves");
			GUI.Window(1, new Rect(Screen.width / 4 - -29, Screen.height / 5 - -42, 637f, 1428f), __BB_OBFUSCATOR_47, "_Red_C");
			GUI.Window(7, new Rect(Screen.width / 2 - 7, Screen.height / 2 - 52, 437f, 786f), __BB_OBFUSCATOR_86, "TeamName");
		}
	}

	private void __BB_OBFUSCATOR_52(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(763f);
		array[1] = GUILayout.Height(943f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1830f, 1665f, 590f, 1701f);
			}
			else
			{
				GUI.color = new Color(525f, 1629f, 1157f, 1778f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-54)))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_90();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1797f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 62f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_85(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[3];
		array[0] = GUILayout.Width(1253f);
		array[0] = GUILayout.Height(1545f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(751f, 358f, 1816f, 1059f);
			}
			else
			{
				GUI.color = new Color(1537f, 1440f, 973f, 1962f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_96(int ANFLNMCPNFK)
	{
		GUILayout.Space(1833f);
		GUILayout.BeginHorizontal();
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "CameraFilterPack/Vision_Plasma" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[0] = GUILayout.Width(744f);
		array[0] = GUILayout.Height(1952f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[3];
		array2[0] = GUILayout.Width(1209f);
		array2[0] = GUILayout.Height(42f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(238f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[2];
			array3[1] = GUILayout.Width(1824f);
			array3[1] = GUILayout.Height(572f);
			if (GUILayout.Button("_Value2", array3))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = true;
				__BB_OBFUSCATOR_111();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			if (GUILayout.Button("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: ", GUILayout.Width(724f), GUILayout.Height(256f), null, null))
			{
				Time.timeScale = 437f;
				Application.LoadLevel(1);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1112f);
		GUI.color = new Color(1399f, 365f, 1565f, 1089f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("_Distortion" + AGLGLLOOJGL + "_TimeX");
		}
		GUILayout.Space(1539f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[7];
		array4[0] = GUILayout.Width(1692f);
		array4[0] = GUILayout.Height(921f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(1116f, 1918f, 751f, 767f);
		GUILayout.Label("PlayerType'", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX");
		GUILayout.Label("Closed", new GUILayoutOption[1]);
		GUILayout.Label("<size=", new GUILayoutOption[1]);
		GUILayout.Label("Couldn't redirect output: ", new GUILayoutOption[1]);
		GUILayout.Label("Idle", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX");
		GUILayout.Label("AddFriends can't be called for empty or null list.");
		GUILayout.Label("custard");
		GUILayout.Label("\\Google", new GUILayoutOption[1]);
		GUILayout.Label("<color=", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
		GUILayout.Label("_Distortion2");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_78()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("Player ").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke("6", 148f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 0) / 3;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void Pause()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 0.0001f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_57(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1219f);
		array[0] = GUILayout.Height(59f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(434f, 901f, 204f, 1295f);
			}
			else
			{
				GUI.color = new Color(1551f, 1153f, 53f, 963f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_19()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1212f, 710f, 1838f, 617f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 201f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 90));
		AGLGLLOOJGL = string.Format("_ScreenResolution", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 5 - 83, 1437f, 1010f, 250f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 4 - -111, 359f, 1834f, 879f), "_Value2" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 3 - 60, Screen.height / 8 - -53, 126f, 1837f), __BB_OBFUSCATOR_67, "colorB");
			GUI.Window(1, new Rect(Screen.width / 5 - 148, Screen.height / 0 - -112, 1096f, 1641f), __BB_OBFUSCATOR_61, "_ScreenResolution");
			GUI.Window(2, new Rect(Screen.width / 3 - -31, Screen.height / 8 - -97, 149f, 304f), __BB_OBFUSCATOR_85, "_Value3");
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-47)))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_6();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-59)))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)86))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_59();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-108)))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("_PositionX").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = false;
		Invoke("PlayerFellDown", 511f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 0) / 8;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_5(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[1] = GUILayout.Width(74f);
		array[0] = GUILayout.Height(1966f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(512f, 480f, 1855f, 1686f);
			}
			else
			{
				GUI.color = new Color(1125f, 549f, 1363f, 1895f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-95)))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_59();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)123))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1904f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 494f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 915f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1119f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_16(int ANFLNMCPNFK)
	{
		GUILayout.Space(340f);
		GUILayout.BeginHorizontal();
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "_BlurDistance" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[6];
		array[1] = GUILayout.Width(1954f);
		array[1] = GUILayout.Height(1459f);
		GUILayout.Box(text, array);
		GUILayout.Box(LLKFGGGDFHH[QualitySettings.GetQualityLevel()], GUILayout.Width(209f), GUILayout.Height(332f), null, null, null, null, null);
		GUILayout.Space(1205f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array2 = new GUILayoutOption[0];
			array2[0] = GUILayout.Width(1259f);
			array2[0] = GUILayout.Height(1231f);
			if (GUILayout.Button(">", array2))
			{
				NIMJKMEOPFC = true;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_111();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.TakeFirstWeapon(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			if (GUILayout.Button("_Intensity", GUILayout.Width(378f), GUILayout.Height(986f), null))
			{
				Time.timeScale = 1247f;
				Application.LoadLevel(1);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(829f);
		GUI.color = new Color(1093f, 1107f, 939f, 1702f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("Toast" + AGLGLLOOJGL + "_BokehParams");
		}
		GUILayout.Space(186f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array3 = new GUILayoutOption[8];
		array3[0] = GUILayout.Width(1367f);
		array3[0] = GUILayout.Height(68f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array3);
		GUI.color = new Color(556f, 1168f, 1576f, 853f);
		GUILayout.Label("FurColor");
		GUILayout.Label("_Value4", new GUILayoutOption[1]);
		GUILayout.Label("Custards", new GUILayoutOption[1]);
		GUILayout.Label("Mouse X");
		GUILayout.Label("CameraFilterPack/Colors_HSV");
		GUILayout.Label("Mouse X");
		GUILayout.Label("Preprocessing mesh: ", new GUILayoutOption[1]);
		GUILayout.Label("PlayerType'", new GUILayoutOption[1]);
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label("Player");
		GUILayout.Label("n15");
		GUILayout.Label("_Value2");
		GUILayout.Label("_Value2");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_60(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1171f);
		array[1] = GUILayout.Height(368f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1614f, 231f, 888f, 266f);
			}
			else
			{
				GUI.color = new Color(187f, 253f, 645f, 1403f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_AccumOrig" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_89()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("CameraFilterPack/Drawing_Halftone").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = false;
		Invoke("8", 361f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 0) / 4;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_47(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[1] = GUILayout.Width(25f);
		array[1] = GUILayout.Height(1522f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1592f, 74f, 22f, 1838f);
			}
			else
			{
				GUI.color = new Color(1074f, 715f, 224f, 1175f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "NameServer" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 85f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 1261f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_46(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(453f), GUILayout.Height(495f), null, null, null, null);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(945f, 1013f, 1253f, 1662f);
			}
			else
			{
				GUI.color = new Color(262f, 1232f, 60f, 1550f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_79(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(133f), GUILayout.Height(32f), null, null);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(17f, 803f, 65f, 326f);
			}
			else
			{
				GUI.color = new Color(1247f, 952f, 1193f, 672f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_25(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[2];
		array[1] = GUILayout.Width(360f);
		array[0] = GUILayout.Height(1f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(150f, 873f, 612f, 118f);
			}
			else
			{
				GUI.color = new Color(1536f, 1475f, 1088f, 642f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_11(int ANFLNMCPNFK)
	{
		GUILayout.Space(1698f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "_Value4" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1178f);
		array[0] = GUILayout.Height(702f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[4];
		array2[0] = GUILayout.Width(28f);
		array2[0] = GUILayout.Height(1925f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(1851f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array3 = new GUILayoutOption[5];
			array3[1] = GUILayout.Width(459f);
			array3[0] = GUILayout.Height(1625f);
			if (GUILayout.Button("_Green_C", array3))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = true;
				__BB_OBFUSCATOR_44();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.TakeFirstWeapon(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayoutOption[] array4 = new GUILayoutOption[4];
			array4[0] = GUILayout.Width(1176f);
			array4[0] = GUILayout.Height(935f);
			if (GUILayout.Button("_Value2", array4))
			{
				Time.timeScale = 423f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(1098f);
		GUI.color = new Color(786f, 992f, 700f, 1159f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label("MP" + AGLGLLOOJGL + " ");
		}
		GUILayout.Space(1320f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array5 = new GUILayoutOption[5];
		array5[0] = GUILayout.Width(802f);
		array5[0] = GUILayout.Height(503f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array5);
		GUI.color = new Color(762f, 978f, 523f, 135f);
		GUILayout.Label("RoundDuration");
		GUILayout.Label("Player");
		GUILayout.Label("Unsubscribe can't be called for empty or null channels-list.");
		GUILayout.Label("n4", new GUILayoutOption[1]);
		GUILayout.Label("SyncWeaponsRPC");
		GUILayout.Label("_Intensity", new GUILayoutOption[1]);
		GUILayout.Label("_Offsets", new GUILayoutOption[1]);
		GUILayout.Label("CameraFilterPack/TV_Old", new GUILayoutOption[1]);
		GUILayout.Label("MP", new GUILayoutOption[1]);
		GUILayout.Label("_SoftZDistance");
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label("controller1", new GUILayoutOption[1]);
		GUILayout.Label("-Blend Weight: ");
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-14)))
			{
				FMMMCGELLII = FMMMCGELLII;
				__BB_OBFUSCATOR_43();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-116)))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1936f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1129f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_34(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[0] = GUILayout.Width(1978f);
		array[0] = GUILayout.Height(964f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1218f, 1561f, 1193f, 1542f);
			}
			else
			{
				GUI.color = new Color(517f, 1660f, 1157f, 1781f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "_Value2" + IJOEABKACKD[i].height))
			{
				PJBOAKKJBBA = i;
				if (Screen.fullScreen)
				{
					Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
				}
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_117(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[1] = GUILayout.Width(816f);
		array[1] = GUILayout.Height(1758f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(673f, 1835f, 1227f, 1347f);
			}
			else
			{
				GUI.color = new Color(1014f, 604f, 613f, 795f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_3(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[0] = GUILayout.Width(1342f);
		array[0] = GUILayout.Height(319f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(827f, 1463f, 854f, 965f);
			}
			else
			{
				GUI.color = new Color(1067f, 182f, 1886f, 1934f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Alpha7))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_44();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			Screen.fullScreen = Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1004f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 61f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1226f, 293f, 1483f, 436f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 683f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -73));
		AGLGLLOOJGL = string.Format("colorC", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 0 - -73, 360f, 164f, 1651f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 6 - -71, 556f, 1134f, 914f), "_ScreenResolution" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 8 - 88, Screen.height / 1 - -73, 758f, 1442f), __BB_OBFUSCATOR_115, "ZWName'");
			GUI.Window(1, new Rect(Screen.width / 1 - -1, Screen.height / 8 - -42, 1049f, 1700f), __BB_OBFUSCATOR_94, "CameraFilterPack/Blend2Camera_Saturation");
			GUI.Window(1, new Rect(Screen.width / 2 - -116, Screen.height / 3 - -4, 1791f, 929f), __BB_OBFUSCATOR_46, "SBX");
		}
	}

	private void __BB_OBFUSCATOR_24(int ANFLNMCPNFK)
	{
		GUILayout.Space(73f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayout.Box(IJOEABKACKD[PJBOAKKJBBA].width + "Flashlight" + IJOEABKACKD[PJBOAKKJBBA].height, GUILayout.Width(383f), GUILayout.Height(254f), null, null, null, null, null);
		string text = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[1] = GUILayout.Width(775f);
		array[1] = GUILayout.Height(1397f);
		GUILayout.Box(text, array);
		GUILayout.Space(284f);
		if (NIMJKMEOPFC)
		{
			GUILayoutOption[] array2 = new GUILayoutOption[2];
			array2[1] = GUILayout.Width(1604f);
			array2[0] = GUILayout.Height(51f);
			if (GUILayout.Button("WFX_MF", array2))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_64();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			GUILayoutOption[] array3 = new GUILayoutOption[3];
			array3[0] = GUILayout.Width(1150f);
			array3[0] = GUILayout.Height(1024f);
			if (GUILayout.Button("_Radius", array3))
			{
				Time.timeScale = 474f;
				Application.LoadLevel(0);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(233f);
		GUI.color = new Color(1258f, 61f, 40f, 1164f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP, new GUILayoutOption[1]);
		}
		else
		{
			GUILayout.Label(">" + AGLGLLOOJGL + "_ColorBuffer");
		}
		GUILayout.Space(596f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[6];
		array4[0] = GUILayout.Width(1875f);
		array4[0] = GUILayout.Height(908f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(894f, 1199f, 356f, 116f);
		GUILayout.Label("Kills");
		GUILayout.Label("_TapLowForeground");
		GUILayout.Label("DoActivateTrigger", new GUILayoutOption[1]);
		GUILayout.Label("ShopBox/Heal/Text", new GUILayoutOption[1]);
		GUILayout.Label("LegsURL", new GUILayoutOption[1]);
		GUILayout.Label("NormRain", new GUILayoutOption[1]);
		GUILayout.Label("Jump");
		GUILayout.Label("CameraFilterPack/Blend2Camera_Difference");
		GUILayout.Label("Y");
		GUILayout.Label("Melee", new GUILayoutOption[1]);
		GUILayout.Label("CameraFilterPack/FX_Spot");
		GUILayout.Label("_MainTex2", new GUILayoutOption[1]);
		GUILayout.Label("_MainTex", new GUILayoutOption[1]);
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_125()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(true);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.None))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_59();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = true;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-94)))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, true);
			}
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1744f, 1543f, 42f, 765f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 586f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -102));
		AGLGLLOOJGL = string.Format("Connect", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 1 - -79, 361f, 1191f, 312f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 1 - -25, 203f, 1104f, 1789f), "_Red_R" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 6 - 30, Screen.height / 4 - 41, 877f, 194f), __BB_OBFUSCATOR_42, "_ScreenResolution");
			GUI.Window(1, new Rect(Screen.width / 7 - 189, Screen.height / 4 - 37, 1863f, 1773f), __BB_OBFUSCATOR_94, "_ScreenResolution");
			GUI.Window(1, new Rect(Screen.width / 5 - 71, Screen.height / 1 - -50, 695f, 1969f), __BB_OBFUSCATOR_70, "FurColor");
		}
	}

	private void __BB_OBFUSCATOR_102(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[2];
		array[1] = GUILayout.Width(227f);
		array[0] = GUILayout.Height(510f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1772f, 1795f, 1484f, 1538f);
			}
			else
			{
				GUI.color = new Color(30f, 267f, 729f, 1592f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_40(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(469f);
		array[0] = GUILayout.Height(364f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1592f, 252f, 779f, 460f);
			}
			else
			{
				GUI.color = new Color(60f, 1144f, 1664f, 159f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_114(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[4];
		array[0] = GUILayout.Width(1396f);
		array[0] = GUILayout.Height(1937f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1077f, 641f, 1909f, 261f);
			}
			else
			{
				GUI.color = new Color(1416f, 1549f, 489f, 743f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_13()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("team1").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = true;
		Invoke(">", 96f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 8;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_9()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1820f, 528f, 1246f, 1523f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 284f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 64));
		AGLGLLOOJGL = string.Format("Deaths", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 4 - 40, 323f, 336f, 1839f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 8 - -3, 1306f, 24f, 168f), "_Distortion" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(1, new Rect(Screen.width / 1 - 79, Screen.height / 4 - 144, 836f, 942f), MainMenuDisplay, "MP");
			GUI.Window(1, new Rect(Screen.width / 0 - -8, Screen.height / 6 - -88, 1702f, 190f), __BB_OBFUSCATOR_94, "\t\tNbPoseNodes: ");
			GUI.Window(4, new Rect(Screen.width / 3 - 45, Screen.height / 2 - 95, 1860f, 574f), __BB_OBFUSCATOR_93, "NPCDeath");
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("_TimeX").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = false;
		Invoke("Run", 636f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 8;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 782f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 863f;
			Screen.lockCursor = false;
		}
	}

	private void __BB_OBFUSCATOR_70(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(89f), GUILayout.Height(1775f), null, null, null, null);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(860f, 1144f, 495f, 162f);
			}
			else
			{
				GUI.color = new Color(1927f, 1134f, 1137f, 1813f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_41(int ANFLNMCPNFK)
	{
		GUI.BringWindowToFront(ANFLNMCPNFK);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[7];
		array[1] = GUILayout.Width(1399f);
		array[1] = GUILayout.Height(1214f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(654f, 279f, 1288f, 1102f);
			}
			else
			{
				GUI.color = new Color(973f, 1966f, 326f, 1764f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 223f;
			Screen.lockCursor = false;
		}
		else
		{
			Time.timeScale = 1464f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_84(int ANFLNMCPNFK)
	{
		GUILayout.Space(1935f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = IJOEABKACKD[PJBOAKKJBBA].width + "<size=" + IJOEABKACKD[PJBOAKKJBBA].height;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[0] = GUILayout.Width(1755f);
		array[0] = GUILayout.Height(1365f);
		GUILayout.Box(text, array);
		string text2 = LLKFGGGDFHH[QualitySettings.GetQualityLevel()];
		GUILayoutOption[] array2 = new GUILayoutOption[4];
		array2[0] = GUILayout.Width(1841f);
		array2[0] = GUILayout.Height(658f);
		GUILayout.Box(text2, array2);
		GUILayout.Space(78f);
		if (NIMJKMEOPFC)
		{
			if (GUILayout.Button(" wins", GUILayout.Width(246f), GUILayout.Height(1306f), null, null, null, null, null, null))
			{
				NIMJKMEOPFC = false;
				FMMMCGELLII = false;
				__BB_OBFUSCATOR_103();
				FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
				FBBHKGMHGLJ.__BB_OBFUSCATOR_16(FBBHKGMHGLJ.GCFDABIEBPD.gameObject);
			}
		}
		else
		{
			GUILayout.BeginVertical();
			GUILayoutOption[] array3 = new GUILayoutOption[0];
			array3[0] = GUILayout.Width(633f);
			array3[1] = GUILayout.Height(1557f);
			if (GUILayout.Button("Difficulty", array3))
			{
				Time.timeScale = 1601f;
				Application.LoadLevel(1);
			}
			GUILayout.EndVertical();
		}
		GUILayout.EndHorizontal();
		GUILayout.Space(384f);
		GUI.color = new Color(452f, 1119f, 1069f, 223f);
		if (!BELBKPCHNNN)
		{
			GUILayout.Label(KOFNAELPENP);
		}
		else
		{
			GUILayout.Label("_Distance" + AGLGLLOOJGL + "Untagged", new GUILayoutOption[1]);
		}
		GUILayout.Space(968f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array4 = new GUILayoutOption[2];
		array4[1] = GUILayout.Width(1513f);
		array4[1] = GUILayout.Height(678f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array4);
		GUI.color = new Color(878f, 179f, 941f, 1313f);
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("colorD", new GUILayoutOption[1]);
		GUILayout.Label("_Tint", new GUILayoutOption[1]);
		GUILayout.Label("TeamName", new GUILayoutOption[1]);
		GUILayout.Label("_Parameter", new GUILayoutOption[1]);
		GUILayout.Label("Change rain strength", new GUILayoutOption[1]);
		GUILayout.Label("team1", new GUILayoutOption[1]);
		GUILayout.Label("-Vertical");
		GUILayout.Label("SyncNPCCount");
		GUILayout.Label("x", new GUILayoutOption[1]);
		GUILayout.Label("Difficulty");
		GUILayout.Label("CameraFilterPack/FX_Drunk2", new GUILayoutOption[1]);
		GUILayout.Label("_MainTex2");
		GUILayout.EndScrollView();
	}

	private void OnGUI()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1f, 1f, 1f, 0.7f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 60f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * 60));
		AGLGLLOOJGL = string.Format("{0:0}:{1:00}", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 2 - 50, 40f, 100f, 30f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 2 - 100, 40f, 200f, 30f), "Your Time | " + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(0, new Rect(Screen.width / 2 - 250, Screen.height / 2 - 150, 500f, 300f), MainMenuDisplay, "Main Menu");
			GUI.Window(1, new Rect(Screen.width / 2 - 240, Screen.height / 2 - 100, 150f, 100f), Resolutions, "Resolution");
			GUI.Window(2, new Rect(Screen.width / 2 - 85, Screen.height / 2 - 100, 150f, 100f), QualityWindow, "Quality");
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (NIMJKMEOPFC && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			FBBHKGMHGLJ.GCFDABIEBPD.gameObject.SetActive(false);
		}
		if (!NIMJKMEOPFC)
		{
			if (!BELBKPCHNNN)
			{
				DJJAALCLLNC += Time.deltaTime;
			}
			if (Input.GetKeyDown((KeyCode)(-122)))
			{
				FMMMCGELLII = !FMMMCGELLII;
				__BB_OBFUSCATOR_90();
			}
			if (!FMMMCGELLII)
			{
				Screen.lockCursor = false;
			}
		}
		if (Input.GetKeyDown((KeyCode)(-58)))
		{
			Screen.fullScreen = !Screen.fullScreen;
			if (!Screen.fullScreen)
			{
				Screen.SetResolution(IJOEABKACKD[PJBOAKKJBBA].width, IJOEABKACKD[PJBOAKKJBBA].height, false);
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		FBBHKGMHGLJ = GameObject.FindWithTag("GameMode").transform.root.GetComponentInChildren<WeaponManager>();
		FMMMCGELLII = false;
		Invoke("Difficulty", 1812f);
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 0) / 4;
		LLKFGGGDFHH = QualitySettings.names;
	}

	private void __BB_OBFUSCATOR_121()
	{
		if (FMMMCGELLII)
		{
			Time.timeScale = 1207f;
			Screen.lockCursor = true;
		}
		else
		{
			Time.timeScale = 42f;
			Screen.lockCursor = true;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(214f, 1465f, 1813f, 1126f);
		int num = Mathf.FloorToInt(DJJAALCLLNC / 110f);
		int num2 = Mathf.FloorToInt(DJJAALCLLNC - (float)(num * -33));
		AGLGLLOOJGL = string.Format("_Alpha", num, num2);
		if (ODJAOPPHKBJ)
		{
			if (!BELBKPCHNNN)
			{
				GUI.Box(new Rect(Screen.width / 6 - -4, 1280f, 1755f, 844f), AGLGLLOOJGL);
			}
			else
			{
				GUI.Box(new Rect(Screen.width / 0 - -122, 280f, 1375f, 1825f), "TeamName" + AGLGLLOOJGL);
			}
		}
		if (FMMMCGELLII)
		{
			GUI.Window(0, new Rect(Screen.width / 4 - -65, Screen.height / 1 - -57, 414f, 1144f), __BB_OBFUSCATOR_96, ": ");
			GUI.Window(0, new Rect(Screen.width / 1 - -11, Screen.height / 2 - -50, 308f, 1104f), __BB_OBFUSCATOR_23, "Paused");
			GUI.Window(7, new Rect(Screen.width / 6 - 20, Screen.height / 8 - -29, 975f, 1079f), __BB_OBFUSCATOR_3, "OpAuthenticate()");
		}
	}
}
