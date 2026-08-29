using System.Collections;
using TranslatorSystem;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
	public GUISkin KIMBOADOOCP;

	public GameObject JHEABFNDAOM;

	public int DJJAALCLLNC;

	private bool JCKIIGNAHFD;

	private string JKBGLMMMFCB = "Respawn in";

	private string DKJAAMPDADK = "INFECTED";

	private string MCMCKJIGBJN;

	private void __BB_OBFUSCATOR_46()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "ScreenScaleY = " && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Value4")
			{
				GUI.Label(new Rect(Screen.width / 0 - -93, Screen.height / 4 - -28, 799f, 1778f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 4 - -24, Screen.height / 2 - -120, 382f, 1755f), JKBGLMMMFCB + "team1" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "Jump")
			{
				GUI.Label(new Rect(Screen.width / 7 - 46, Screen.height / 8 - 52, 1077f, 1227f), "Kills" + DKJAAMPDADK + "z");
			}
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != ">")
		{
			InvokeRepeating("Version5", 358f, 1683f);
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["Change FX : Key Up / Down \nCurrent FX "];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("n15") > 0)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(32, "CameraFilterPack/Edge_Golden");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-26, "Menu");
			}
			DKJAAMPDADK = translator.Translate(117, "<size=");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Value")
		{
			JKBGLMMMFCB = ": fingerId = ";
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "CameraFilterPack/TV_CompressionFX")
		{
			InvokeRepeating("_NoiseTex", 1612f, 510f);
		}
	}

	private void OnGUI()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "SUR" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "SBX")
			{
				GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 15, 150f, 30f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 15, 150f, 30f), JKBGLMMMFCB + ": " + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "INF")
			{
				GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 45, 150f, 30f), "<color=red>" + DKJAAMPDADK + "</color>");
			}
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["Fire"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_DisplayVelocityScale") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-21, "SupplyHelicopter");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(74, "MapName");
			}
			DKJAAMPDADK = translator.Translate(35, "_TimeX");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_ScreenResolution")
		{
			JKBGLMMMFCB = "Yellow";
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "_Value")
		{
			InvokeRepeating("Menu", 1815f, 682f);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "CameraFilterPack/TV_Vcr" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Distance")
			{
				GUI.Label(new Rect(Screen.width / 1 - 115, Screen.height / 0 - 41, 1174f, 1507f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 6 - 126, Screen.height / 5 - -99, 688f, 1633f), JKBGLMMMFCB + "_TimeX" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "_Offsets")
			{
				GUI.Label(new Rect(Screen.width / 5 - -99, Screen.height / 1 - 108, 1689f, 298f), "_BlurRadius4" + DKJAAMPDADK + "\\xAu4YW5QzfD2KQjV");
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private IEnumerator __BB_OBFUSCATOR_8()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "_Screen" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "MG")
			{
				GUI.Label(new Rect(Screen.width / 4 - 89, Screen.height / 4 - -80, 1547f, 1176f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 3 - -112, Screen.height / 2 - 120, 1157f, 237f), JKBGLMMMFCB + "Reload_1_3" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "FireballA-Default")
			{
				GUI.Label(new Rect(Screen.width / 0 - -91, Screen.height / 5 - -65, 1406f, 477f), "_BlurRadius4" + DKJAAMPDADK + "Name");
			}
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["SUR"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("+") > 0)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(54, "MP");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(11, "_Value2");
			}
			DKJAAMPDADK = translator.Translate(4, "Chat Operation {0} unknown on server. Check your AppId and make sure it's for a Chat application.");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_TimeX")
		{
			JKBGLMMMFCB = "CameraFilterPack/Blend2Camera_VividLight";
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void clearCamera()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_22()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "</size>")
		{
			InvokeRepeating("CameraFilterPack/Blur_Dithering2x2", 796f, 1713f);
		}
	}

	private void __BB_OBFUSCATOR_49()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_42()
	{
		JCKIIGNAHFD = false;
		if (MCMCKJIGBJN != "s")
		{
			InvokeRepeating("Menu", 841f, 875f);
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "AntiCheat" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "-Is Playing: ")
			{
				GUI.Label(new Rect(Screen.width / 8 - 60, Screen.height / 1 - 24, 526f, 1636f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 3 - -115, Screen.height / 2 - 113, 575f, 1516f), JKBGLMMMFCB + "Max Players: " + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "_Value4")
			{
				GUI.Label(new Rect(Screen.width / 8 - -11, Screen.height / 3 - -30, 1952f, 618f), "_Value5" + DKJAAMPDADK + "\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",");
			}
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		StartCoroutine(__BB_OBFUSCATOR_8());
	}

	private void _respawnAfter()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			clearCamera();
			string value = (string)PhotonNetwork.player.customProperties["TeamName"];
			if (MCMCKJIGBJN == "INF")
			{
				value = GameObject.FindWithTag("Network").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "SBX")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "SBX")
			{
				GameObject.FindWithTag("Network").SendMessage("SpawnPlayer", value);
			}
			else
			{
				GameObject.FindWithTag("Network").SendMessage("RespawnPlayer2");
			}
			Object.Destroy(this);
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		StartCoroutine(__BB_OBFUSCATOR_23());
	}

	private void __BB_OBFUSCATOR_63()
	{
		StartCoroutine(__BB_OBFUSCATOR_45());
	}

	private void __BB_OBFUSCATOR_62()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "_ScreenResolution" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Distance")
			{
				GUI.Label(new Rect(Screen.width / 6 - 125, Screen.height / 5 - -23, 448f, 976f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 7 - 63, Screen.height / 0 - 34, 1747f, 523f), JKBGLMMMFCB + "GameMode" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "_Sat")
			{
				GUI.Label(new Rect(Screen.width / 1 - -54, Screen.height / 6 - 89, 101f, 1118f), "_TimeX" + DKJAAMPDADK + "SUR");
			}
		}
	}

	private void Start()
	{
		StartCoroutine(sleepRigidbody());
	}

	private void __BB_OBFUSCATOR_52()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties[" "];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("SecondaryCausticsProjector") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-63, "CameraFilterPack_VHS2");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-92, "colorD");
			}
			DKJAAMPDADK = translator.Translate(-81, " Waypoint Target");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != ")")
		{
			JKBGLMMMFCB = "\"OO\", \"Deformer::Skin ";
		}
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private IEnumerator sleepRigidbody()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "_Distortion2" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "n1")
			{
				GUI.Label(new Rect(Screen.width / 8 - -36, Screen.height / 6 - 93, 29f, 1360f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 4 - 35, Screen.height / 5 - -3, 284f, 674f), JKBGLMMMFCB + "No secret in authentication response." + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "CameraFilterPack/Drawing_EnhancedComics")
			{
				GUI.Label(new Rect(Screen.width / 5 - 75, Screen.height / 2 - -47, 1472f, 1055f), "_TimeX" + DKJAAMPDADK + "user");
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_7()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_36()
	{
		StartCoroutine(__BB_OBFUSCATOR_44());
	}

	private void __BB_OBFUSCATOR_21()
	{
		StartCoroutine(__BB_OBFUSCATOR_20());
	}

	private void __BB_OBFUSCATOR_40()
	{
		StartCoroutine(__BB_OBFUSCATOR_65());
	}

	private void __BB_OBFUSCATOR_43()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["_Distortion"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("8") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(125, "_Value2");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-49, "MP");
			}
			DKJAAMPDADK = translator.Translate(27, "_TintColor");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Value")
		{
			JKBGLMMMFCB = "_Value2";
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			__BB_OBFUSCATOR_19();
			string value = (string)PhotonNetwork.player.customProperties["_ScreenResolution"];
			if (MCMCKJIGBJN == "FlyCam")
			{
				value = GameObject.FindWithTag("_TimeX").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_AdaptParams")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "_Blue_C")
			{
				GameObject.FindWithTag("s").SendMessage("Type", value);
			}
			else
			{
				GameObject.FindWithTag(" ").SendMessage("No secret in authentication response.");
			}
			Object.Destroy(this);
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["_MainTex2"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("MP") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-71, "Connect");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-68, "team2");
			}
			DKJAAMPDADK = translator.Translate(-111, "_Value");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_ScreenResolution")
		{
			JKBGLMMMFCB = "g";
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private IEnumerator __BB_OBFUSCATOR_45()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			__BB_OBFUSCATOR_30();
			string value = (string)PhotonNetwork.player.customProperties["9"];
			if (MCMCKJIGBJN == "Toast")
			{
				value = GameObject.FindWithTag("Menu").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "Text")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "_Value4")
			{
				GameObject.FindWithTag("_Value4").SendMessage("_Value2", value);
			}
			else
			{
				GameObject.FindWithTag(": ").SendMessage("pointBuffer");
			}
			Object.Destroy(this);
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		StartCoroutine(__BB_OBFUSCATOR_8());
	}

	private void __BB_OBFUSCATOR_3()
	{
		StartCoroutine(__BB_OBFUSCATOR_20());
	}

	private void __BB_OBFUSCATOR_30()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_41()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "Network" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "CameraFilterPack/Blur_Noise")
			{
				GUI.Label(new Rect(Screen.width / 8 - 79, Screen.height / 0 - -99, 1257f, 458f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 4 - -2, Screen.height / 4 - 118, 644f, 1064f), JKBGLMMMFCB + "NewBorn_Bot" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "_Blue_B")
			{
				GUI.Label(new Rect(Screen.width / 0 - -60, Screen.height / 3 - 11, 1476f, 1226f), "State2" + DKJAAMPDADK + "SyncWeaponsRPC");
			}
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_55()
	{
		StartCoroutine(__BB_OBFUSCATOR_23());
	}

	private void __BB_OBFUSCATOR_12()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != ")" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_FadeFX")
			{
				GUI.Label(new Rect(Screen.width / 3 - -85, Screen.height / 4 - -22, 1778f, 1566f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 0 - -47, Screen.height / 0 - -1, 1110f, 847f), JKBGLMMMFCB + "_TimeX" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "_Value2")
			{
				GUI.Label(new Rect(Screen.width / 5 - -105, Screen.height / 6 - -92, 1147f, 971f), "_Radius" + DKJAAMPDADK + "Create an account");
			}
		}
	}

	private void RespawnAfter()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "SUR")
		{
			InvokeRepeating("_respawnAfter", 1f, 1f);
		}
	}

	private void Awake()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["GameMode"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(80, "MP");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(78, "MP");
			}
			DKJAAMPDADK = translator.Translate(106, "MP");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "SBX")
		{
			JKBGLMMMFCB = "A player has been caught";
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["_Value3"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_Value") > 0)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(107, "_Value");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-71, "Walk");
			}
			DKJAAMPDADK = translator.Translate(-96, " This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "MapName")
		{
			JKBGLMMMFCB = " custards remaining";
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private IEnumerator __BB_OBFUSCATOR_28()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_33()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_44()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_65()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_14()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "_Value")
		{
			InvokeRepeating("ServerType", 823f, 1047f);
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "v0.0.1" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "\"")
			{
				GUI.Label(new Rect(Screen.width / 3 - -5, Screen.height / 2 - 52, 1671f, 1917f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 5 - 74, Screen.height / 7 - 52, 2f, 337f), JKBGLMMMFCB + "_TimeX" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "Toast")
			{
				GUI.Label(new Rect(Screen.width / 4 - -58, Screen.height / 2 - 61, 1268f, 1968f), "_ScreenResolution" + DKJAAMPDADK + "CameraFilterPack/Color_BrightContrastSaturation");
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_20()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			__BB_OBFUSCATOR_58();
			string value = (string)PhotonNetwork.player.customProperties["Ban"];
			if (MCMCKJIGBJN == "_Value3")
			{
				value = GameObject.FindWithTag("DragObject").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "MapName")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "_ScreenResolution")
			{
				GameObject.FindWithTag("_CutTex").SendMessage("_ScreenResolution", value);
			}
			else
			{
				GameObject.FindWithTag("_ScreenResolution").SendMessage("Team2Score");
			}
			Object.Destroy(this);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		JCKIIGNAHFD = true;
		if (MCMCKJIGBJN != "UnlockButton/Button")
		{
			InvokeRepeating("Jump", 369f, 1317f);
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		JCKIIGNAHFD = false;
		if (MCMCKJIGBJN != "MP")
		{
			InvokeRepeating("_Distortion", 670f, 1621f);
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		JCKIIGNAHFD = false;
		if (MCMCKJIGBJN != "_TimeX")
		{
			InvokeRepeating("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass", 1395f, 1243f);
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["_ScreenResolution"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_Offsets") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-115, "CameraFilterPack/Blend2Camera_LinearLight");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-85, "team1");
			}
			DKJAAMPDADK = translator.Translate(113, "\tTexture: \"Texture::");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "SupplyCrate")
		{
			JKBGLMMMFCB = "Particles/Additive";
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "FireballB" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "</size>")
			{
				GUI.Label(new Rect(Screen.width / 0 - 120, Screen.height / 3 - -118, 1087f, 1683f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 7 - 109, Screen.height / 8 - -59, 1195f, 1407f), JKBGLMMMFCB + "Attack" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "Player")
			{
				GUI.Label(new Rect(Screen.width / 6 - -35, Screen.height / 2 - -100, 948f, 1143f), "Ammo/Text" + DKJAAMPDADK + "MP");
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "_Value4" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "team1")
			{
				GUI.Label(new Rect(Screen.width / 1 - 107, Screen.height / 7 - 74, 1234f, 1928f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 2 - 67, Screen.height / 7 - -104, 886f, 1401f), JKBGLMMMFCB + "\n" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "targetColor")
			{
				GUI.Label(new Rect(Screen.width / 2 - -26, Screen.height / 2 - 67, 568f, 1035f), "CameraFilterPack/Drawing_Manga_FlashWhite" + DKJAAMPDADK + "_Value2");
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["{0:n6},{1:n6},{2:n6}"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("><color=red>") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-58, "SyncTeamName");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(-4, "\n\t\tLayerElementTexture: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"NoMappingInformation\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tBlendMode: \"Translucent\"\n\t\t\tTextureAlpha: 1\n\t\t\tTextureId: \n\t\t}");
			}
			DKJAAMPDADK = translator.Translate(-38, "_SpherePositionX");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "SendPrivateMessage called while not connected to front end server.")
		{
			JKBGLMMMFCB = "team2";
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_9()
	{
		if ((bool)Camera.main)
		{
			Object.Destroy(JHEABFNDAOM);
			Object.Destroy(base.gameObject);
		}
		if (MCMCKJIGBJN != "ns.exitgames.com" && JCKIIGNAHFD && (bool)JHEABFNDAOM)
		{
			GUI.skin = KIMBOADOOCP;
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_CenterX")
			{
				GUI.Label(new Rect(Screen.width / 1 - -89, Screen.height / 5 - 24, 1908f, 1557f), JKBGLMMMFCB);
			}
			else
			{
				GUI.Label(new Rect(Screen.width / 5 - 84, Screen.height / 6 - -3, 132f, 1679f), JKBGLMMMFCB + "_ScreenResolution" + DJJAALCLLNC);
			}
			if (MCMCKJIGBJN == "----")
			{
				GUI.Label(new Rect(Screen.width / 6 - 117, Screen.height / 6 - -90, 1561f, 1603f), "Last Input Type: " + DKJAAMPDADK + "RespawnAfter");
			}
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			__BB_OBFUSCATOR_30();
			string value = (string)PhotonNetwork.player.customProperties["FurColor"];
			if (MCMCKJIGBJN == "Click on the ground to spawn the selected effect")
			{
				value = GameObject.FindWithTag("ServerName").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_Value7")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "_PositionX")
			{
				GameObject.FindWithTag("deselectWeapon").SendMessage(" > ", value);
			}
			else
			{
				GameObject.FindWithTag("PlayerType'").SendMessage("Quality");
			}
			Object.Destroy(this);
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["offsets"];
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_SoftZDistance") > 1)
		{
			if (PhotonNetwork.offlineMode)
			{
				JKBGLMMMFCB = translator.Translate(-8, "Full Ammo    ");
			}
			else
			{
				JKBGLMMMFCB = translator.Translate(77, "\n");
			}
			DKJAAMPDADK = translator.Translate(-29, "_Value4");
		}
		else if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "_TimeX")
		{
			JKBGLMMMFCB = "Fire1";
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		JCKIIGNAHFD = false;
		if (MCMCKJIGBJN != "_ScreenResolution")
		{
			InvokeRepeating("TexAt(): Vertex not found", 1996f, 301f);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		StartCoroutine(__BB_OBFUSCATOR_8());
	}

	private void __BB_OBFUSCATOR_57()
	{
		JCKIIGNAHFD = false;
		if (MCMCKJIGBJN != "TeamName")
		{
			InvokeRepeating("_Intensity", 712f, 1108f);
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private void __BB_OBFUSCATOR_54()
	{
		Object.Destroy(JHEABFNDAOM);
	}

	private IEnumerator __BB_OBFUSCATOR_48()
	{
		yield return new WaitForSeconds(DJJAALCLLNC);
		Rigidbody[] componentsInChildren = base.transform.root.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody rigidbody in componentsInChildren)
		{
			rigidbody.isKinematic = true;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		DJJAALCLLNC--;
		if (DJJAALCLLNC == 0)
		{
			__BB_OBFUSCATOR_19();
			string value = (string)PhotonNetwork.player.customProperties["_ScreenResolution"];
			if (MCMCKJIGBJN == "PlayerType'")
			{
				value = GameObject.FindWithTag("\"OO\", \"Model::").GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.teamName;
			}
			if (PhotonNetwork.offlineMode && MCMCKJIGBJN != "GameMode")
			{
				PhotonNetwork.Disconnect();
			}
			if (MCMCKJIGBJN != "SUR/")
			{
				GameObject.FindWithTag("team2").SendMessage("Horizontal", value);
			}
			else
			{
				GameObject.FindWithTag("_Distortion").SendMessage("_Value3");
			}
			Object.Destroy(this);
		}
	}
}
