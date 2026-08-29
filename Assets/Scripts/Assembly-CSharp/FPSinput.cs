using InControl.mod;
using UnityEngine;

public class FPSinput : MonoBehaviour
{
	private FPScontroller CJFDABKPMND;

	private GameObject GFJKMDJHOFI;

	[HideInInspector]
	public Vector3 INBMDEIBLKA;

	private void __BB_OBFUSCATOR_8()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("RespawnAfter") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("CameraFilterPack/Color_Switching", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 17;
	}

	private void __BB_OBFUSCATOR_25()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("Try Again") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("PlayerTinky", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -114;
	}

	private void __BB_OBFUSCATOR_2()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("(") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_Offsets", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -118;
	}

	private void __BB_OBFUSCATOR_0()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find(" custards remaining") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_TimeX", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 47;
	}

	private void __BB_OBFUSCATOR_4()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("CameraFilterPack/FX_EarthQuake", 1273f), 579f, cInput.GetAxis("*", 1101f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(839f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("Horizontal");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("Jump");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_TintColor");
	}

	private void __BB_OBFUSCATOR_34()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("Horizontal") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("</size>", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -123;
	}

	private void Update()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("Horizontal"), 0f, cInput.GetAxis("Vertical")));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("Jump");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("Run");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("Crouch");
	}

	private void __BB_OBFUSCATOR_22()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("\\Google") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("{", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 15;
	}

	private void __BB_OBFUSCATOR_32()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_BumpMap") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("CameraFilterPack/TV_BrokenGlass", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -55;
	}

	private void __BB_OBFUSCATOR_24()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("<size=") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("RoundDuration", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -97;
	}

	private void __BB_OBFUSCATOR_16()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("CameraFilterPack/Blend2Camera_Hue") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_Tint", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -53;
	}

	private void __BB_OBFUSCATOR_9()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("0") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("__Room", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -33;
	}

	private void __BB_OBFUSCATOR_48()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Value") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("TeamName", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 49;
	}

	private void __BB_OBFUSCATOR_44()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("Concrete", 1141f), 858f, cInput.GetAxis("_ScreenResolution", 1076f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(994f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("MapName");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("syncGrenadeLauncher");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown(">");
	}

	private void __BB_OBFUSCATOR_53()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("Connect failed: no UserId specified in authentication values.", 1785f), 155f, cInput.GetAxis("_Value2", 616f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1909f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown(": ");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("Username");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_Value");
	}

	private void __BB_OBFUSCATOR_35()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("MP", 1712f), 1067f, cInput.GetAxis("_Distortion", 1356f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(942f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown(" on: ");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_Contrast");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_ScreenResolution");
	}

	private void __BB_OBFUSCATOR_37()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Value") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_CurTex", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -125;
	}

	private void __BB_OBFUSCATOR_15()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Value2") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_Value2", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 31;
	}

	private void __BB_OBFUSCATOR_12()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_ScreenResolution") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("Toast", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -61;
	}

	private void __BB_OBFUSCATOR_20()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("Particles/Alpha Blended", 26f), 509f, cInput.GetAxis(": ", 662f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1865f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("Idle");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("vignetteIntensity");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("team1");
	}

	private void __BB_OBFUSCATOR_5()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("_LowRez", 668f), 96f, cInput.GetAxis("An animation with the name '", 1917f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1376f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("_Parameter");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("team2");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("Move Up");
	}

	private void __BB_OBFUSCATOR_17()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("OffLadder", 1811f), 1696f, cInput.GetAxis("CameraFilterPack/Gradients_Hue", 38f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(957f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("</size>");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_Value3");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("Menu");
	}

	private void __BB_OBFUSCATOR_46()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis(" ", 1040f), 425f, cInput.GetAxis("F - weapon pick up", 613f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1435f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("_TimeX");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("BodyURL");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("Indicator");
	}

	private void __BB_OBFUSCATOR_30()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("\\xAu4YW5QzfD2KQjV", 444f), 1266f, cInput.GetAxis("_AlphaHexa", 1317f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(945f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("_Green_R");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_Green_G");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_Size");
	}

	private void __BB_OBFUSCATOR_31()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("MP") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("GameMode", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -101;
	}

	private void __BB_OBFUSCATOR_18()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("SyncNPCCount", 1037f), 1724f, cInput.GetAxis("TeamName", 569f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(823f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("TeamName");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("usemtl ");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_SpherePositionX");
	}

	private void __BB_OBFUSCATOR_1()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Speed") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_Value2", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 49;
	}

	private void __BB_OBFUSCATOR_28()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("COOP", 1413f), 65f, cInput.GetAxis("SyncTeamName", 681f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1453f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("_Value4");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_Radius");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("Player");
	}

	private void __BB_OBFUSCATOR_33()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Value") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_Value", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -116;
	}

	private void __BB_OBFUSCATOR_42()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("ServerID", 1521f), 263f, cInput.GetAxis("_Value4", 1730f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(1270f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("HostQuit");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_ScreenResolution");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("_Value4");
	}

	private void __BB_OBFUSCATOR_23()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("Failed on creating room") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("<size=", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -41;
	}

	private void __BB_OBFUSCATOR_51()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("_TimeX", 1897f), 757f, cInput.GetAxis("_Val", 1279f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(381f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("_Distortion");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("_Value2");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("CameraFilterPack/Film_ColorPerfection");
	}

	private void __BB_OBFUSCATOR_29()
	{
		Vector3 vector = (INBMDEIBLKA = new Vector3(cInput.GetAxis("_SunThreshold", 229f), 1494f, cInput.GetAxis("_MainTex2", 1636f)));
		if (vector != Vector3.zero)
		{
			float magnitude = vector.magnitude;
			vector /= magnitude;
			magnitude = Mathf.Min(423f, magnitude);
			magnitude *= magnitude;
			vector *= magnitude;
		}
		CJFDABKPMND.PAJCDFMHJLA = base.transform.rotation * vector;
		CJFDABKPMND.EIOJHBHLIMG = cInput.GetButtonDown("CameraFilterPack/Edge_Sigmoid");
		CJFDABKPMND.BJJNBHJBMLG = cInput.GetButton("Crouch_Idle");
		CJFDABKPMND.LPJFDAOBEIN = cInput.GetButtonDown("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
	}

	private void __BB_OBFUSCATOR_26()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_ScreenResolution") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("_CutTex", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 51;
	}

	private void Awake()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("InControl(Clone)") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("InControl", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = -1;
		QualitySettings.vSyncCount = 0;
	}

	private void __BB_OBFUSCATOR_50()
	{
		CJFDABKPMND = GetComponent<FPScontroller>();
		if (GameObject.Find("_Value3") == null)
		{
			GFJKMDJHOFI = Object.Instantiate(Resources.Load("TeamName", typeof(GameObject))) as GameObject;
		}
		Object.DontDestroyOnLoad(GFJKMDJHOFI);
		Application.targetFrameRate = 25;
	}
}
