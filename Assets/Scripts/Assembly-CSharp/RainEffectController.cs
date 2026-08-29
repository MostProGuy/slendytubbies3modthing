using UnityEngine;

public class RainEffectController : MonoBehaviour
{
	public RainEffect GIGJGPBOHAB;

	public RainEffect ENMJEDOGEON;

	public ShowerEffect JONOELPEFNK;

	public AudioSource HMAEEAHBCGF;

	public Texture2D BJJDBFLNJJO;

	public Texture2D CGAPJKAPDBP;

	private float GHFJHMKCIJG;

	private float GFKPMPCJGAN;

	private float CPDMMHLDOIP;

	private float HBNCMDBEHFN;

	private float NGBMGPPFKLG;

	private float EOEHKBBOBNA;

	private int PIDPDJDHGMN;

	private void __BB_OBFUSCATOR_23()
	{
		Rect clientRect = new Rect(591f, 1154f, 1958f, 1661f);
		clientRect = GUI.Window(0, clientRect, __BB_OBFUSCATOR_8, "PlayerName");
	}

	private void __BB_OBFUSCATOR_65()
	{
		Rect clientRect = new Rect(968f, 1586f, 1356f, 684f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_14, "Team2Score");
	}

	private void __BB_OBFUSCATOR_92()
	{
		int pIDPDJDHGMN = PIDPDJDHGMN;
		switch (pIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1217f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1012f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1683f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1050f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1506f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1018f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 317f, Time.deltaTime * 1931f);
			ENMJEDOGEON.enabled = false;
			return;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 1036f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 818f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 133f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 356f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 366f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1775f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 962f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 825f, Time.deltaTime * 1583f);
			ENMJEDOGEON.enabled = false;
			return;
		}
		if (pIDPDJDHGMN == 1)
		{
			JONOELPEFNK.IPFIDJNEEOO = 679f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1705f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 582f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 642f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1925f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1649f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1914f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1168f, Time.deltaTime * 1048f);
			ENMJEDOGEON.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		Rect clientRect = new Rect(1786f, 1133f, 1941f, 995f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_89, "SBX");
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (Input.GetKeyDown((KeyCode)84))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)76))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)6))
		{
			PIDPDJDHGMN = 0;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 617f))
		{
			__BB_OBFUSCATOR_15();
		}
		else
		{
			OutSide();
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		Rect clientRect = new Rect(543f, 1209f, 1902f, 26f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_89, "CameraFilterPack/Drawing_Manga5");
	}

	private void __BB_OBFUSCATOR_72()
	{
		GHFJHMKCIJG = 345f;
		GFKPMPCJGAN = 193f;
		CPDMMHLDOIP = 62f;
		HBNCMDBEHFN = 603f;
		NGBMGPPFKLG = 1527f;
		EOEHKBBOBNA = 798f;
	}

	private void __BB_OBFUSCATOR_13()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1855f, Time.deltaTime * 637f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1209f, Time.deltaTime * 26f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1826f, Time.deltaTime * 1670f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_81()
	{
		if (Input.GetKeyDown(KeyCode.Underscore))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)(-11)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.I))
		{
			PIDPDJDHGMN = 4;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1578f))
		{
			__BB_OBFUSCATOR_42();
		}
		else
		{
			__BB_OBFUSCATOR_97();
		}
	}

	private void __BB_OBFUSCATOR_14(int ANFLNMCPNFK)
	{
		GUILayout.Label("_Distortion", new GUILayoutOption[1]);
		GUILayout.Label("_TimeX");
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(1604f);
		if (GUILayout.Button("OnJump", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 5;
		}
		GUI.DragWindow(new Rect(1212f, 188f, 1433f, 755f));
	}

	private void Awake()
	{
		GHFJHMKCIJG = 0f;
		GFKPMPCJGAN = 0.6f;
		CPDMMHLDOIP = 0.7f;
		HBNCMDBEHFN = 0.6f;
		NGBMGPPFKLG = 1.4f;
		EOEHKBBOBNA = 0.5f;
	}

	private void __BB_OBFUSCATOR_59(int ANFLNMCPNFK)
	{
		GUILayout.Label("Diffuse", new GUILayoutOption[1]);
		GUILayout.Label("<size=", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Height(1643f);
		if (GUILayout.Button("_Value2", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 5;
		}
		GUI.DragWindow(new Rect(1279f, 1646f, 1271f, 1326f));
	}

	private void __BB_OBFUSCATOR_58()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 381f, Time.deltaTime * 1631f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 484f, Time.deltaTime * 1855f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1084f, Time.deltaTime * 1273f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (Input.GetKeyDown((KeyCode)(-126)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)78))
		{
			PIDPDJDHGMN = 6;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 165f))
		{
			__BB_OBFUSCATOR_58();
		}
		else
		{
			__BB_OBFUSCATOR_55();
		}
	}

	private void __BB_OBFUSCATOR_85(int ANFLNMCPNFK)
	{
		GUILayout.Label("\n", new GUILayoutOption[1]);
		GUILayout.Label("team2");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Height(848f);
		if (GUILayout.Button("OnJump", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 8;
		}
		GUI.DragWindow(new Rect(1988f, 1125f, 1021f, 1481f));
	}

	private void __BB_OBFUSCATOR_31(int ANFLNMCPNFK)
	{
		GUILayout.Label("_TimeX");
		GUILayout.Label("Try Again");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Height(1456f);
		if (GUILayout.Button("SwearFilter", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 4;
		}
		GUI.DragWindow(new Rect(954f, 1417f, 631f, 1475f));
	}

	private void __BB_OBFUSCATOR_104()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1898f, Time.deltaTime * 1386f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 301f, Time.deltaTime * 644f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1023f, Time.deltaTime * 845f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (Input.GetKeyDown((KeyCode)(-83)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Pause))
		{
			PIDPDJDHGMN = 7;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1878f))
		{
			InHome();
		}
		else
		{
			OutSide();
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			PIDPDJDHGMN = 2;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 10f))
		{
			InHome();
		}
		else
		{
			OutSide();
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1051f, Time.deltaTime * 494f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 90f, Time.deltaTime * 1138f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 300f, Time.deltaTime * 1049f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_70(int ANFLNMCPNFK)
	{
		GUILayout.Label("\", \"\" {\n\t\tVersion: 102\n\t\tShadingModel: \"lambert\"\n\t\tMultiLayer: 0\n\t\tProperties60:  {\n\t\t\tProperty: \"ShadingModel\", \"KString\", \"\", \"Lambert\"\n\t\t\tProperty: \"MultiLayer\", \"bool\", \"\",0\n\t\t\tProperty: \"EmissiveColor\", \"ColorRGB\", \"\",0.8000,0.8000,0.8000\n\t\t\tProperty: \"EmissiveFactor\", \"double\", \"\",0.0000\n\t\t\tProperty: \"AmbientColor\", \"ColorRGB\", \"\",", new GUILayoutOption[1]);
		GUILayout.Label("_ScreenResolution");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Height(219f);
		if (GUILayout.Button("HelpMenu", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 7;
		}
		GUI.DragWindow(new Rect(1439f, 463f, 615f, 1050f));
	}

	private void __BB_OBFUSCATOR_63()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 184f, Time.deltaTime * 1710f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1250f, Time.deltaTime * 1930f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 256f, Time.deltaTime * 755f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_76()
	{
		GHFJHMKCIJG = 67f;
		GFKPMPCJGAN = 1611f;
		CPDMMHLDOIP = 486f;
		HBNCMDBEHFN = 58f;
		NGBMGPPFKLG = 270f;
		EOEHKBBOBNA = 1597f;
	}

	private void __BB_OBFUSCATOR_77()
	{
		Rect clientRect = new Rect(1099f, 782f, 283f, 1187f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_8, "_Value6");
	}

	private void __BB_OBFUSCATOR_53(int ANFLNMCPNFK)
	{
		GUILayout.Label("\n");
		GUILayout.Label("_ScreenResolution");
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(709f);
		if (GUILayout.Button("Hidden/Aubergine/NightVision", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 3;
		}
		GUI.DragWindow(new Rect(1544f, 913f, 122f, 252f));
	}

	private void __BB_OBFUSCATOR_78()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1937f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1981f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1065f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1011f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 113f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 274f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1700f, Time.deltaTime * 137f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 637f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1087f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1386f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 318f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 280f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1116f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1661f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1467f, Time.deltaTime * 874f);
			ENMJEDOGEON.enabled = false;
			break;
		case 5:
			JONOELPEFNK.IPFIDJNEEOO = 178f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 394f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 751f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1333f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 253f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1201f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 159f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 813f, Time.deltaTime * 1969f);
			ENMJEDOGEON.enabled = false;
			break;
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		int pIDPDJDHGMN = PIDPDJDHGMN;
		if (pIDPDJDHGMN != 0)
		{
			switch (pIDPDJDHGMN)
			{
			case 0:
				JONOELPEFNK.IPFIDJNEEOO = 1853f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 163f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 233f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1442f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 846f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1081f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1435f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 772f, Time.deltaTime * 658f);
				ENMJEDOGEON.enabled = true;
				break;
			case 5:
				JONOELPEFNK.IPFIDJNEEOO = 449f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1803f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 715f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 68f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 738f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1547f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1138f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 140f, Time.deltaTime * 1879f);
				ENMJEDOGEON.enabled = false;
				break;
			}
		}
		else
		{
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 93f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 857f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1970f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 890f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1903f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1692f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 908f, Time.deltaTime * 48f);
			ENMJEDOGEON.enabled = false;
		}
	}

	private void OutSide()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 0.8f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1.2f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1.1f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1.6f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 0.8f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1.5f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 0.3f, Time.deltaTime * 4f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 0.01f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 0.6f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 0.98f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1.1f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1.6f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 0.8f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1.5f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 0.7f, Time.deltaTime * 4f);
			ENMJEDOGEON.enabled = true;
			break;
		case 2:
			JONOELPEFNK.IPFIDJNEEOO = 0.05f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 0.5f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 0.6f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 5f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 5f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1.8f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 2.5f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1f, Time.deltaTime * 4f);
			ENMJEDOGEON.enabled = true;
			break;
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1814f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1030f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1656f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1958f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1610f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1203f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 267f, Time.deltaTime * 388f);
			ENMJEDOGEON.enabled = false;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 1674f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1833f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1245f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1600f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 134f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 389f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 967f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1066f, Time.deltaTime * 1383f);
			ENMJEDOGEON.enabled = false;
			break;
		case 7:
			JONOELPEFNK.IPFIDJNEEOO = 1986f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 482f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1769f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 562f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1021f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 187f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1173f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 845f, Time.deltaTime * 1973f);
			ENMJEDOGEON.enabled = true;
			break;
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (Input.GetKeyDown((KeyCode)124))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)29))
		{
			PIDPDJDHGMN = 3;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 920f))
		{
			__BB_OBFUSCATOR_17();
		}
		else
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 296f, Time.deltaTime * 1718f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 604f, Time.deltaTime * 704f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1758f, Time.deltaTime * 824f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_64(int ANFLNMCPNFK)
	{
		GUILayout.Label("_Value3", new GUILayoutOption[1]);
		GUILayout.Label("Blending (", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(205f);
		if (GUILayout.Button("Label", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 0;
		}
		GUI.DragWindow(new Rect(1045f, 731f, 511f, 700f));
	}

	private void __BB_OBFUSCATOR_15()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 714f, Time.deltaTime * 298f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 997f, Time.deltaTime * 1899f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1341f, Time.deltaTime * 1151f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_87()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-54)))
		{
			PIDPDJDHGMN = 5;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 17f))
		{
			__BB_OBFUSCATOR_38();
		}
		else
		{
			__BB_OBFUSCATOR_94();
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			PIDPDJDHGMN = 7;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 339f))
		{
			InHome();
		}
		else
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_56(int ANFLNMCPNFK)
	{
		GUILayout.Label("|", new GUILayoutOption[1]);
		GUILayout.Label("Link_DeformAcuracy", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(540f);
		if (GUILayout.Button("_TimeX", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 2;
		}
		GUI.DragWindow(new Rect(1100f, 1296f, 1097f, 791f));
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (Input.GetKeyDown((KeyCode)(-106)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Comma))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-127)))
		{
			PIDPDJDHGMN = 5;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1578f))
		{
			__BB_OBFUSCATOR_15();
		}
		else
		{
			__BB_OBFUSCATOR_94();
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1300f, Time.deltaTime * 1366f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1486f, Time.deltaTime * 1700f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1689f, Time.deltaTime * 529f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_40(int ANFLNMCPNFK)
	{
		GUILayout.Label("Horizontal");
		GUILayout.Label("_Screen", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(562f);
		if (GUILayout.Button("_TimeX", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 8;
		}
		GUI.DragWindow(new Rect(1798f, 1460f, 627f, 341f));
	}

	private void __BB_OBFUSCATOR_43(int ANFLNMCPNFK)
	{
		GUILayout.Label("_Distortion");
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Height(482f);
		if (GUILayout.Button("MapName", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 8;
		}
		GUI.DragWindow(new Rect(580f, 1568f, 1725f, 644f));
	}

	private void DoMyWindow(int ANFLNMCPNFK)
	{
		GUILayout.Label("<size=15>Press 1, 2, 3 Key to change strength of rain</size>");
		GUILayout.Label("<size=15>Or change by this button below</size>");
		if (GUILayout.Button("Change rain strength", GUILayout.Height(30f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 3;
		}
		GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
	}

	private void __BB_OBFUSCATOR_35()
	{
		GHFJHMKCIJG = 197f;
		GFKPMPCJGAN = 1609f;
		CPDMMHLDOIP = 861f;
		HBNCMDBEHFN = 963f;
		NGBMGPPFKLG = 1021f;
		EOEHKBBOBNA = 885f;
	}

	private void __BB_OBFUSCATOR_20(int ANFLNMCPNFK)
	{
		GUILayout.Label("Kills");
		GUILayout.Label("_Green_B");
		if (GUILayout.Button("Newborn_Bot", GUILayout.Height(563f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 1;
		}
		GUI.DragWindow(new Rect(913f, 1710f, 754f, 1417f));
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (Input.GetKeyDown((KeyCode)(-65)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)(-93)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 91f))
		{
			__BB_OBFUSCATOR_11();
		}
		else
		{
			__BB_OBFUSCATOR_82();
		}
	}

	private void __BB_OBFUSCATOR_100()
	{
		Rect clientRect = new Rect(1030f, 1652f, 288f, 1804f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_51, "{0}{1}{2}={3}");
	}

	private void __BB_OBFUSCATOR_71()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 980f, Time.deltaTime * 364f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1484f, Time.deltaTime * 375f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 876f, Time.deltaTime * 1355f);
		ENMJEDOGEON.enabled = true;
	}

	private void InHome()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 0f, Time.deltaTime * 10f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 0f, Time.deltaTime * 5f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 0.2f, Time.deltaTime * 2f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (Input.GetKeyDown(KeyCode.H))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-70)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)125))
		{
			PIDPDJDHGMN = 6;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 406f))
		{
			__BB_OBFUSCATOR_58();
		}
		else
		{
			__BB_OBFUSCATOR_78();
		}
	}

	private void __BB_OBFUSCATOR_29(int ANFLNMCPNFK)
	{
		GUILayout.Label("HeadURL", new GUILayoutOption[1]);
		GUILayout.Label("Jump", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Height(1849f);
		if (GUILayout.Button("_Value4", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 3;
		}
		GUI.DragWindow(new Rect(1102f, 655f, 1443f, 331f));
	}

	private void __BB_OBFUSCATOR_6(int ANFLNMCPNFK)
	{
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label(",", new GUILayoutOption[1]);
		if (GUILayout.Button("|", GUILayout.Height(1490f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 6;
		}
		GUI.DragWindow(new Rect(1506f, 1634f, 536f, 956f));
	}

	private void __BB_OBFUSCATOR_88()
	{
		Rect clientRect = new Rect(1030f, 774f, 349f, 857f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_20, "Full Ammo    ");
	}

	private void __BB_OBFUSCATOR_89(int ANFLNMCPNFK)
	{
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("_Value2");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Height(942f);
		if (GUILayout.Button("_TimeX", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 8;
		}
		GUI.DragWindow(new Rect(879f, 1029f, 713f, 390f));
	}

	private void __BB_OBFUSCATOR_48()
	{
		GHFJHMKCIJG = 985f;
		GFKPMPCJGAN = 1183f;
		CPDMMHLDOIP = 598f;
		HBNCMDBEHFN = 1162f;
		NGBMGPPFKLG = 585f;
		EOEHKBBOBNA = 315f;
	}

	private void __BB_OBFUSCATOR_10()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 930f, Time.deltaTime * 1815f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1856f, Time.deltaTime * 1053f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1181f, Time.deltaTime * 722f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_75()
	{
		GHFJHMKCIJG = 406f;
		GFKPMPCJGAN = 1567f;
		CPDMMHLDOIP = 1778f;
		HBNCMDBEHFN = 936f;
		NGBMGPPFKLG = 1402f;
		EOEHKBBOBNA = 1831f;
	}

	private void __BB_OBFUSCATOR_42()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1532f, Time.deltaTime * 865f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 866f, Time.deltaTime * 1710f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1339f, Time.deltaTime * 863f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_5(int ANFLNMCPNFK)
	{
		GUILayout.Label(",");
		GUILayout.Label("_ScreenResolution");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Height(766f);
		if (GUILayout.Button("Label", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 8;
		}
		GUI.DragWindow(new Rect(1876f, 769f, 1569f, 1348f));
	}

	private void __BB_OBFUSCATOR_90()
	{
		Rect clientRect = new Rect(1582f, 1846f, 1087f, 1640f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_29, "_Value");
	}

	private void __BB_OBFUSCATOR_57(int ANFLNMCPNFK)
	{
		GUILayout.Label("CameraFilterPack/Vision_Drost");
		GUILayout.Label("_TimeX");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Height(160f);
		if (GUILayout.Button("offsets", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 1;
		}
		GUI.DragWindow(new Rect(1752f, 1452f, 865f, 1428f));
	}

	private void __BB_OBFUSCATOR_54()
	{
		Rect clientRect = new Rect(1893f, 1510f, 1626f, 77f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_18, "Deformer");
	}

	private void __BB_OBFUSCATOR_93(int ANFLNMCPNFK)
	{
		GUILayout.Label("</size>");
		GUILayout.Label("_SpawnHeuristic", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(961f);
		if (GUILayout.Button("g", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 0;
		}
		GUI.DragWindow(new Rect(1924f, 100f, 1701f, 860f));
	}

	private void __BB_OBFUSCATOR_84()
	{
		Rect clientRect = new Rect(164f, 920f, 185f, 624f);
		clientRect = GUI.Window(0, clientRect, __BB_OBFUSCATOR_89, "_V");
	}

	private void __BB_OBFUSCATOR_21()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 219f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 398f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1396f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1524f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1164f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 797f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 129f, Time.deltaTime * 290f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 581f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 914f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1316f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1788f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1280f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 124f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1948f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 696f, Time.deltaTime * 1782f);
			ENMJEDOGEON.enabled = true;
			break;
		case 5:
			JONOELPEFNK.IPFIDJNEEOO = 643f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1686f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1735f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 632f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1850f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1536f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1314f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1175f, Time.deltaTime * 1473f);
			ENMJEDOGEON.enabled = false;
			break;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 639f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 818f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 68f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1167f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1237f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 852f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1320f, Time.deltaTime * 878f);
			ENMJEDOGEON.enabled = false;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 1118f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 584f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 661f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 511f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 569f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 86f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1397f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1355f, Time.deltaTime * 1135f);
			ENMJEDOGEON.enabled = false;
			break;
		case 4:
			JONOELPEFNK.IPFIDJNEEOO = 33f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1418f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1778f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 730f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1401f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 357f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1080f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1272f, Time.deltaTime * 1984f);
			ENMJEDOGEON.enabled = false;
			break;
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (Input.GetKeyDown((KeyCode)(-87)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)(-67)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			PIDPDJDHGMN = 5;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1019f))
		{
			__BB_OBFUSCATOR_10();
		}
		else
		{
			__BB_OBFUSCATOR_55();
		}
	}

	private void __BB_OBFUSCATOR_18(int ANFLNMCPNFK)
	{
		GUILayout.Label("_TimeX", new GUILayoutOption[1]);
		GUILayout.Label("Private");
		if (GUILayout.Button("PublishMessage parameters must be non-null and not empty.", GUILayout.Height(371f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 5;
		}
		GUI.DragWindow(new Rect(1426f, 587f, 1658f, 1805f));
	}

	private void __BB_OBFUSCATOR_30()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1183f, Time.deltaTime * 28f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 347f, Time.deltaTime * 544f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 260f, Time.deltaTime * 657f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_97()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1667f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1858f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 773f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1913f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1162f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1828f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1550f, Time.deltaTime * 1832f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 299f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1331f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 933f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1524f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 952f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1405f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1724f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 353f, Time.deltaTime * 627f);
			ENMJEDOGEON.enabled = false;
			break;
		case 6:
			JONOELPEFNK.IPFIDJNEEOO = 627f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1500f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1198f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1163f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1558f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 201f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 955f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1521f, Time.deltaTime * 32f);
			ENMJEDOGEON.enabled = true;
			break;
		}
	}

	private void __BB_OBFUSCATOR_96(int ANFLNMCPNFK)
	{
		GUILayout.Label("__Room");
		GUILayout.Label("PlayerName");
		if (GUILayout.Button("TenkokuModule", GUILayout.Height(813f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 2;
		}
		GUI.DragWindow(new Rect(791f, 1027f, 553f, 959f));
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (Input.GetKeyDown((KeyCode)(-88)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)24))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)126))
		{
			PIDPDJDHGMN = 7;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 321f))
		{
			__BB_OBFUSCATOR_13();
		}
		else
		{
			OutSide();
		}
	}

	private void __BB_OBFUSCATOR_102()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1711f, Time.deltaTime * 203f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 473f, Time.deltaTime * 360f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 555f, Time.deltaTime * 650f);
		ENMJEDOGEON.enabled = true;
	}

	private void __BB_OBFUSCATOR_19(int ANFLNMCPNFK)
	{
		GUILayout.Label("Shockwave-Default");
		GUILayout.Label("TeamTag");
		if (GUILayout.Button(",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n", GUILayout.Height(775f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 0;
		}
		GUI.DragWindow(new Rect(186f, 1802f, 716f, 303f));
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)(-110)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)18))
		{
			PIDPDJDHGMN = 0;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 527f))
		{
			__BB_OBFUSCATOR_63();
		}
		else
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		GHFJHMKCIJG = 353f;
		GFKPMPCJGAN = 1025f;
		CPDMMHLDOIP = 1921f;
		HBNCMDBEHFN = 953f;
		NGBMGPPFKLG = 1943f;
		EOEHKBBOBNA = 1804f;
	}

	private void __BB_OBFUSCATOR_98(int ANFLNMCPNFK)
	{
		GUILayout.Label("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		GUILayout.Label("INF", new GUILayoutOption[1]);
		if (GUILayout.Button("Kills", GUILayout.Height(498f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 4;
		}
		GUI.DragWindow(new Rect(1902f, 644f, 50f, 1699f));
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (Input.GetKeyDown((KeyCode)(-49)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)125))
		{
			PIDPDJDHGMN = 0;
		}
		if (Input.GetKeyDown((KeyCode)(-44)))
		{
			PIDPDJDHGMN = 0;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1987f))
		{
			__BB_OBFUSCATOR_30();
		}
		else
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		GIGJGPBOHAB.KHJJDIADALD = Mathf.Lerp(GIGJGPBOHAB.KHJJDIADALD, 1059f, Time.deltaTime * 960f);
		JONOELPEFNK.IPFIDJNEEOO = Mathf.Lerp(JONOELPEFNK.IPFIDJNEEOO, 1246f, Time.deltaTime * 1777f);
		HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1350f, Time.deltaTime * 1511f);
		ENMJEDOGEON.enabled = false;
	}

	private void __BB_OBFUSCATOR_51(int ANFLNMCPNFK)
	{
		GUILayout.Label("</size>");
		GUILayout.Label("ObjectType");
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(1917f);
		if (GUILayout.Button("{0:0}:{1:00}", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 7;
		}
		GUI.DragWindow(new Rect(116f, 1521f, 469f, 436f));
	}

	private void __BB_OBFUSCATOR_94()
	{
		int pIDPDJDHGMN = PIDPDJDHGMN;
		if (pIDPDJDHGMN != 0)
		{
			switch (pIDPDJDHGMN)
			{
			case 0:
				JONOELPEFNK.IPFIDJNEEOO = 1507f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 304f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 380f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 565f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1851f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 105f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 357f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 866f, Time.deltaTime * 926f);
				ENMJEDOGEON.enabled = false;
				break;
			case 5:
				JONOELPEFNK.IPFIDJNEEOO = 98f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1832f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1836f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 935f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 269f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 687f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 5f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1478f, Time.deltaTime * 161f);
				ENMJEDOGEON.enabled = false;
				break;
			}
		}
		else
		{
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1513f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 949f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 42f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1871f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1569f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1814f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 737f, Time.deltaTime * 1344f);
			ENMJEDOGEON.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		Rect clientRect = new Rect(1534f, 1175f, 20f, 1476f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_4, "CameraFilterPack/FX_Spot");
	}

	private void __BB_OBFUSCATOR_67()
	{
		Rect clientRect = new Rect(453f, 141f, 988f, 1333f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_20, "You");
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (Input.GetKeyDown((KeyCode)(-1)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-36)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-87)))
		{
			PIDPDJDHGMN = 8;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1261f))
		{
			__BB_OBFUSCATOR_104();
		}
		else
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_4(int ANFLNMCPNFK)
	{
		GUILayout.Label(" ");
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
		if (GUILayout.Button("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: ", GUILayout.Height(1121f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 1;
		}
		GUI.DragWindow(new Rect(1455f, 393f, 55f, 1764f));
	}

	private void __BB_OBFUSCATOR_50(int ANFLNMCPNFK)
	{
		GUILayout.Label("Subscribe can't be called for empty or null channels-list.", new GUILayoutOption[1]);
		GUILayout.Label("Ping", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(1634f);
		if (GUILayout.Button("_NeighbourMaxTex", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 1;
		}
		GUI.DragWindow(new Rect(1270f, 1987f, 1360f, 955f));
	}

	private void __BB_OBFUSCATOR_73()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1633f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 526f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1219f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 578f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 817f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1788f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1969f, Time.deltaTime * 1873f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 1882f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 530f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1472f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 626f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1368f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 42f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 83f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1402f, Time.deltaTime * 60f);
			ENMJEDOGEON.enabled = false;
			break;
		case 8:
			JONOELPEFNK.IPFIDJNEEOO = 461f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 935f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 762f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 726f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1515f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1466f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 256f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1064f, Time.deltaTime * 609f);
			ENMJEDOGEON.enabled = false;
			break;
		}
	}

	private void __BB_OBFUSCATOR_101(int ANFLNMCPNFK)
	{
		GUILayout.Label("CameraFilterPack/FX_Drunk2");
		GUILayout.Label("CameraFilterPack/Blend2Camera_Exclusion");
		if (GUILayout.Button("_Value2", GUILayout.Height(1644f)))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 7;
		}
		GUI.DragWindow(new Rect(1457f, 345f, 1645f, 350f));
	}

	private void __BB_OBFUSCATOR_99()
	{
		switch (PIDPDJDHGMN)
		{
		case 0:
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1772f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1443f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 986f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 28f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1111f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1553f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1904f, Time.deltaTime * 253f);
			ENMJEDOGEON.enabled = true;
			break;
		case 1:
			JONOELPEFNK.IPFIDJNEEOO = 530f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1186f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 678f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1200f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 474f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 1115f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 943f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1868f, Time.deltaTime * 813f);
			ENMJEDOGEON.enabled = false;
			break;
		case 7:
			JONOELPEFNK.IPFIDJNEEOO = 1945f;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1075f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1552f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1645f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1985f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 430f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1030f;
			GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1373f, Time.deltaTime * 526f);
			ENMJEDOGEON.enabled = true;
			break;
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		Rect clientRect = new Rect(1176f, 1336f, 1102f, 1500f);
		clientRect = GUI.Window(1, clientRect, __BB_OBFUSCATOR_85, "_Value4");
	}

	private void __BB_OBFUSCATOR_37()
	{
		Rect clientRect = new Rect(565f, 1737f, 110f, 204f);
		clientRect = GUI.Window(0, clientRect, __BB_OBFUSCATOR_49, "CameraFilterPack/TV_BrokenGlass");
	}

	private void __BB_OBFUSCATOR_34()
	{
		GHFJHMKCIJG = 1969f;
		GFKPMPCJGAN = 1342f;
		CPDMMHLDOIP = 301f;
		HBNCMDBEHFN = 1973f;
		NGBMGPPFKLG = 1229f;
		EOEHKBBOBNA = 659f;
	}

	private void __BB_OBFUSCATOR_83()
	{
		Rect clientRect = new Rect(387f, 1850f, 738f, 1743f);
		clientRect = GUI.Window(0, clientRect, __BB_OBFUSCATOR_85, "State2");
	}

	private void __BB_OBFUSCATOR_8(int ANFLNMCPNFK)
	{
		GUILayout.Label("Mesh consolidation done", new GUILayoutOption[1]);
		GUILayout.Label("CameraFilterPack/TV_WideScreenHV");
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Height(1844f);
		if (GUILayout.Button("Melee", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 0) % 3;
		}
		GUI.DragWindow(new Rect(930f, 867f, 187f, 1714f));
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (Input.GetKeyDown((KeyCode)(-2)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)(-120)))
		{
			PIDPDJDHGMN = 1;
		}
		if (Input.GetKeyDown((KeyCode)83))
		{
			PIDPDJDHGMN = 0;
		}
		if (Physics.Raycast(base.transform.position, Vector3.up, 1256f))
		{
			__BB_OBFUSCATOR_15();
		}
		else
		{
			__BB_OBFUSCATOR_94();
		}
	}

	private void OnGUI()
	{
		Rect clientRect = new Rect(40f, 50f, 320f, 120f);
		clientRect = GUI.Window(0, clientRect, DoMyWindow, "Rain Effect v1.2");
	}

	private void __BB_OBFUSCATOR_16()
	{
		int pIDPDJDHGMN = PIDPDJDHGMN;
		if (pIDPDJDHGMN != 0)
		{
			switch (pIDPDJDHGMN)
			{
			case 0:
				JONOELPEFNK.IPFIDJNEEOO = 971f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 325f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 52f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 948f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 500f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 924f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1895f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1274f, Time.deltaTime * 331f);
				ENMJEDOGEON.enabled = false;
				break;
			case 6:
				JONOELPEFNK.IPFIDJNEEOO = 94f;
				GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1267f;
				GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1455f;
				GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1942f;
				GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 34f;
				GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 565f;
				GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 1161f;
				GIGJGPBOHAB.CPNKHGPBCBH = CGAPJKAPDBP;
				HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 77f, Time.deltaTime * 1703f);
				ENMJEDOGEON.enabled = false;
				break;
			}
		}
		else
		{
			JONOELPEFNK.IPFIDJNEEOO = GHFJHMKCIJG;
			GIGJGPBOHAB.KHJJDIADALD = GFKPMPCJGAN * 1507f;
			GIGJGPBOHAB.GDLONHCPAKF = CPDMMHLDOIP * 1024f;
			GIGJGPBOHAB.LOIMGLOPEPM = HBNCMDBEHFN / 1725f;
			GIGJGPBOHAB.CMGLILNFIHB = NGBMGPPFKLG / 1012f;
			GIGJGPBOHAB.AMOAFABIKNH = EOEHKBBOBNA * 18f;
			GIGJGPBOHAB.PJEGDGJOPAI = EOEHKBBOBNA * 812f;
			GIGJGPBOHAB.CPNKHGPBCBH = BJJDBFLNJJO;
			HMAEEAHBCGF.volume = Mathf.Lerp(HMAEEAHBCGF.volume, 1855f, Time.deltaTime * 1267f);
			ENMJEDOGEON.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_49(int ANFLNMCPNFK)
	{
		GUILayout.Label("_Value", new GUILayoutOption[1]);
		GUILayout.Label("CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]);
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Height(1404f);
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_PinLight", array))
		{
			PIDPDJDHGMN = (PIDPDJDHGMN + 1) % 4;
		}
		GUI.DragWindow(new Rect(909f, 1782f, 378f, 1029f));
	}
}
