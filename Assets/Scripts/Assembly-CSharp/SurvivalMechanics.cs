using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using TranslatorSystem;
using UnityEngine;

public class SurvivalMechanics : Photon.MonoBehaviour
{
	[Serializable]
	public class waveInfo
	{
		public int totalCount = 5;

		public string defaultNPC = "Newborn_Bot";

		public specialNPC[] NPC;

		public AudioClip music;
	}

	[Serializable]
	public class specialNPC
	{
		public string npcName;

		public int spawnChance;

		public int maxSpawn;

		public bool isBoss;

		[HideInInspector]
		public bool bossHasSpawned;
	}

	public int PAGEHOLHMHC;

	public List<waveInfo> MDKJKFCOJGE;

	public waveInfo COHAANEIGIM;

	private int OEJIEFEJGHC = 15;

	private bool LGBBPEIHEPF;

	public ShopSystem BGEFGFBOJKF;

	private GameObject[] HHDECLNABAC;

	private int PDIKIHDGCMC;

	public GUISkin NMOHLIAHHDP;

	public bool LIBIJNOONHG;

	public Transform[] FCMIHIHPEFO;

	private GameObject DNPNMLPNOFE;

	public int LJGHEKKGNHK;

	public Texture2D PMKMNCGKPKG;

	public bool GDPAFHGOECB;

	private AudioSource PFNMEFHNPKA;

	private float DNKALNAFOHF;

	private string LAKMEIFLGJD = "Wave ";

	private string EEGGDFDPFCF = "Time until next wave";

	private string PMHLEBDGPIF = "Complete";

	private ObscuredInt FHMBDHIHNBB;

	private bool OJJEPMGNFHP;

	public Texture2D NMGNFCHGIIE;

	private bool DLOFIAHGCNN;

	private int JKEAGMLGENI = -1;

	private int BIGAGKNBJJO = 45;

	[CompilerGenerated]
	private static Converter<GameObject, Transform> NCBIMIMMADO;

	private void __BB_OBFUSCATOR_62(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(1082f, 1709f, 1839f, 295f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 0; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(619f, 945f, 489f, 1054f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_8()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 1)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("_ScreenResolution");
			gUIStyle.name = "An animation with the name '";
			gUIStyle.alignment = TextAnchor.LowerLeft;
			Rect pLGJJIBFGFL = new Rect(122f, 1901f, Screen.width, 405f);
			string[] array = new string[8];
			array[0] = "_ProjInfo";
			array[0] = LAKMEIFLGJD;
			array[7] = string.Empty;
			array[8] = (PAGEHOLHMHC + 0).ToString();
			array[6] = "_Value3";
			__BB_OBFUSCATOR_62(pLGJJIBFGFL, string.Concat(array), 1, gUIStyle);
			Rect position = new Rect(545f, 1592f, Screen.width, 1107f);
			string[] array2 = new string[5];
			array2[0] = "ZWName'";
			array2[0] = LAKMEIFLGJD;
			array2[4] = string.Empty;
			array2[5] = (PAGEHOLHMHC + 1).ToString();
			array2[1] = "Particles/Additive";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleLeft;
			GUI.DrawTexture(new Rect(Screen.width / 3 - -82, 983f, 1523f, 1965f), NMGNFCHGIIE);
			__BB_OBFUSCATOR_31(new Rect(Screen.width / 5, 1601f, 1907f, 1743f), "window" + PDIKIHDGCMC + "\\Google", 0, gUIStyle);
			gUIStyle.alignment = TextAnchor.LowerRight;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "monster";
			}
			GUI.Label(new Rect(875f, 1283f, 1652f, 1749f), "monster" + PMHLEBDGPIF + "Connect");
			Rect position2 = new Rect(1073f, 1836f, 38f, 1653f);
			string[] array3 = new string[8];
			array3[1] = "\t\t\tMatrix: ";
			array3[1] = EEGGDFDPFCF;
			array3[6] = "Glow-Default";
			array3[1] = text;
			array3[2] = "_Value2";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 9f < 1893f)) ? 1801f : (vector.z * 161f));
			if (vector.z > 1966f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(1224f, 259f, 722f, 1696f);
				GUI.Label(new Rect(vector.x - 1389f, (float)Screen.height - vector.y - 45f - num, 33f, 1462f), "_Value2" + (int)num2 + "_PositionY");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 815f, (float)Screen.height - vector.y - 1902f - num, 1725f, 1528f), "_Value4" + (int)num2 + "Rigidbody dragger");
				GUI.DrawTexture(new Rect(vector.x - 418f, (float)Screen.height - vector.y - 216f - num + 153f, 974f, 1629f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("ForceDamage") as GameObject);
		BGEFGFBOJKF = gameObject.GetComponent<ShopSystem>();
		gameObject.transform.position = Vector3.zero;
		if (LIBIJNOONHG)
		{
			DNPNMLPNOFE = UnityEngine.Object.Instantiate(Resources.Load("_BlurDirectionPacked") as GameObject);
			DNPNMLPNOFE.transform.position = new Vector3(684f, 1965f, 1939f);
		}
		if (!LIBIJNOONHG)
		{
			for (int i = 1; i < FCMIHIHPEFO.Length; i++)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(Resources.Load(" ☠☠☠") as GameObject);
				gameObject2.name = "CameraFilterPack/Blend2Camera_DarkerColor";
				gameObject2.transform.parent = FCMIHIHPEFO[i];
				gameObject2.transform.localPosition = new Vector3(1420f, 1620f, 1830f);
				gameObject2.transform.localEulerAngles = Vector3.zero;
			}
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("__Room") > 1)
		{
			LAKMEIFLGJD = translator.Translate(-105, "TDM");
			PMHLEBDGPIF = translator.Translate(58, "_BumpMap");
			EEGGDFDPFCF = translator.Translate(46, "Detonator");
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (PDIKIHDGCMC > 0)
		{
			PDIKIHDGCMC -= 0;
		}
		else
		{
			PDIKIHDGCMC = 0;
		}
		if (PhotonNetwork.isMasterClient)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = PDIKIHDGCMC;
			obj.RPC("CameraFilterPack/Colors_Adjust_PreFilters", PhotonTargets.Others, array);
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_9(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	public void Restart()
	{
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < HHDECLNABAC.Length; i++)
			{
				PhotonNetwork.Destroy(HHDECLNABAC[i].transform.parent.gameObject);
			}
		}
		PAGEHOLHMHC = 0;
		JKEAGMLGENI = -1;
		DLOFIAHGCNN = false;
	}

	private void __BB_OBFUSCATOR_10()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("Rotation (");
			gUIStyle.name = "\n";
			gUIStyle.alignment = TextAnchor.MiddleCenter;
			Rect pLGJJIBFGFL = new Rect(1280f, 1429f, Screen.width, 1254f);
			string[] array = new string[6];
			array[0] = "_Value2";
			array[0] = LAKMEIFLGJD;
			array[0] = string.Empty;
			array[8] = (PAGEHOLHMHC + 0).ToString();
			array[8] = "Connect";
			__BB_OBFUSCATOR_62(pLGJJIBFGFL, string.Concat(array), 1, gUIStyle);
			Rect position = new Rect(92f, 972f, Screen.width, 35f);
			string[] array2 = new string[0];
			array2[0] = "_ScreenResolution";
			array2[0] = LAKMEIFLGJD;
			array2[5] = string.Empty;
			array2[6] = (PAGEHOLHMHC + 1).ToString();
			array2[8] = "_Blue_G";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.LowerCenter;
			GUI.DrawTexture(new Rect(Screen.width / 5 - -119, 1631f, 854f, 572f), NMGNFCHGIIE);
			DrawOutline(new Rect(Screen.width / 7, 1978f, 1854f, 992f), ". Disconnecting." + PDIKIHDGCMC + "colorA", 0, gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleCenter;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "_Intensity";
			}
			GUI.Label(new Rect(1076f, 1302f, 413f, 1238f), "_TimeX" + PMHLEBDGPIF + "Floor");
			Rect position2 = new Rect(1508f, 1169f, 738f, 275f);
			string[] array3 = new string[6];
			array3[0] = "_Threshhold";
			array3[0] = EEGGDFDPFCF;
			array3[1] = "&";
			array3[6] = text;
			array3[6] = "_CenterY";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 1220f < 618f)) ? 1010f : (vector.z * 1769f));
			if (vector.z > 1826f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(969f, 620f, 1119f, 314f);
				GUI.Label(new Rect(vector.x - 1897f, (float)Screen.height - vector.y - 1488f - num, 527f, 953f), " " + (int)num2 + "Language");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 1286f, (float)Screen.height - vector.y - 1280f - num, 1518f, 946f), " " + (int)num2 + "Network");
				GUI.DrawTexture(new Rect(vector.x - 174f, (float)Screen.height - vector.y - 1798f - num + 1677f, 410f, 235f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}

	private void __BB_OBFUSCATOR_30()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("died") as GameObject);
		BGEFGFBOJKF = gameObject.GetComponent<ShopSystem>();
		gameObject.transform.position = Vector3.zero;
		if (LIBIJNOONHG)
		{
			DNPNMLPNOFE = UnityEngine.Object.Instantiate(Resources.Load("_RedAmplifier") as GameObject);
			DNPNMLPNOFE.transform.position = new Vector3(608f, 1549f, 1871f);
		}
		if (!LIBIJNOONHG)
		{
			for (int i = 1; i < FCMIHIHPEFO.Length; i += 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(Resources.Load("_TimeX") as GameObject);
				gameObject2.name = "INF";
				gameObject2.transform.parent = FCMIHIHPEFO[i];
				gameObject2.transform.localPosition = new Vector3(163f, 1048f, 879f);
				gameObject2.transform.localEulerAngles = Vector3.zero;
			}
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_TimeX") > 0)
		{
			LAKMEIFLGJD = translator.Translate(-86, "_bump\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\",");
			PMHLEBDGPIF = translator.Translate(98, "_Value3");
			EEGGDFDPFCF = translator.Translate(26, "MP");
		}
	}

	private void __BB_OBFUSCATOR_63(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void OnGUI()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("Label");
			gUIStyle.name = "Label2";
			gUIStyle.alignment = TextAnchor.MiddleCenter;
			DrawOutline(new Rect(0f, 10f, Screen.width, 30f), "<size=25>" + LAKMEIFLGJD + string.Empty + (PAGEHOLHMHC + 1) + "</size>", 1, gUIStyle);
			GUI.Label(new Rect(0f, 10f, Screen.width, 30f), "<size=25><color=#b50000>" + LAKMEIFLGJD + string.Empty + (PAGEHOLHMHC + 1) + "</color></size>", gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleLeft;
			GUI.DrawTexture(new Rect(Screen.width / 2 - 35, 32f, 30f, 30f), NMGNFCHGIIE);
			DrawOutline(new Rect(Screen.width / 2, 35f, 90f, 30f), "<size=25>" + PDIKIHDGCMC + "</size>", 1, gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleCenter;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "-";
			}
			GUI.Label(new Rect(25f, 0f, 90f, 60f), "<size=15><color=red>" + PMHLEBDGPIF + "</color></size>");
			GUI.Label(new Rect(25f, 35f, 90f, 60f), "<size=15>" + EEGGDFDPFCF + ";\n" + text + "</size>");
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 3f < 50f)) ? 50f : (vector.z * 3f));
			if (vector.z > 0f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(0f, 0f, 0f, 0.5f);
				GUI.Label(new Rect(vector.x - 101f, (float)Screen.height - vector.y - 4f - num, 200f, 30f), "(" + (int)num2 + "mm)");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 100f, (float)Screen.height - vector.y - 5f - num, 200f, 30f), "(" + (int)num2 + "mm)");
				GUI.DrawTexture(new Rect(vector.x - 13f, (float)Screen.height - vector.y - 5f - num + 30f, 26f, 23f), PMKMNCGKPKG);
			}
		}
	}

	[PunRPC]
	private void RespawnPlayers()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().SpawnPlayer(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 1)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle(" (Listening)");
			gUIStyle.name = "_Relief";
			gUIStyle.alignment = TextAnchor.MiddleLeft;
			Rect pLGJJIBFGFL = new Rect(115f, 605f, Screen.width, 699f);
			string[] array = new string[7];
			array[0] = "_SmoothEnd";
			array[0] = LAKMEIFLGJD;
			array[6] = string.Empty;
			array[6] = (PAGEHOLHMHC + 1).ToString();
			array[3] = "_TimeX";
			__BB_OBFUSCATOR_62(pLGJJIBFGFL, string.Concat(array), 0, gUIStyle);
			Rect position = new Rect(1507f, 1610f, Screen.width, 1462f);
			string[] array2 = new string[6];
			array2[0] = "</color></size>";
			array2[0] = LAKMEIFLGJD;
			array2[4] = string.Empty;
			array2[0] = (PAGEHOLHMHC + 1).ToString();
			array2[7] = "MP";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.LowerCenter;
			GUI.DrawTexture(new Rect(Screen.width / 0 - 97, 1984f, 386f, 276f), NMGNFCHGIIE);
			__BB_OBFUSCATOR_62(new Rect(Screen.width / 0, 753f, 965f, 97f), "Shockwave-Default" + PDIKIHDGCMC + "\"GlobalSettings\"", 1, gUIStyle);
			gUIStyle.alignment = TextAnchor.UpperCenter;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "Join Room";
			}
			GUI.Label(new Rect(84f, 1784f, 305f, 1295f), "o " + PMHLEBDGPIF + "GlobalSettings");
			Rect position2 = new Rect(547f, 1487f, 994f, 205f);
			string[] array3 = new string[1];
			array3[1] = "Active players: ";
			array3[1] = EEGGDFDPFCF;
			array3[2] = "Attack";
			array3[8] = text;
			array3[7] = "ZWName'";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 1715f < 901f)) ? 990f : (vector.z * 386f));
			if (vector.z > 612f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(1070f, 934f, 199f, 1117f);
				GUI.Label(new Rect(vector.x - 1871f, (float)Screen.height - vector.y - 1977f - num, 915f, 1958f), " minutes" + (int)num2 + "Idle");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 103f, (float)Screen.height - vector.y - 1616f - num, 867f, 553f), "VS" + (int)num2 + "Indicator ID not valid. Check Off Screen Indicator Indicators list.");
				GUI.DrawTexture(new Rect(vector.x - 1732f, (float)Screen.height - vector.y - 413f - num + 301f, 269f, 1484f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_79(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	private void __BB_OBFUSCATOR_77()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("_TimeX");
			gUIStyle.name = "[0-9]";
			gUIStyle.alignment = TextAnchor.MiddleRight;
			Rect pLGJJIBFGFL = new Rect(395f, 543f, Screen.width, 1245f);
			string[] array = new string[0];
			array[1] = "Player ";
			array[1] = LAKMEIFLGJD;
			array[7] = string.Empty;
			array[7] = (PAGEHOLHMHC + 0).ToString();
			array[5] = "MP";
			__BB_OBFUSCATOR_31(pLGJJIBFGFL, string.Concat(array), 0, gUIStyle);
			Rect position = new Rect(165f, 806f, Screen.width, 1654f);
			string[] array2 = new string[6];
			array2[0] = "ServerType";
			array2[1] = LAKMEIFLGJD;
			array2[1] = string.Empty;
			array2[0] = (PAGEHOLHMHC + 1).ToString();
			array2[3] = "Custards";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleLeft;
			GUI.DrawTexture(new Rect(Screen.width / 5 - -114, 1598f, 629f, 1979f), NMGNFCHGIIE);
			DrawOutline(new Rect(Screen.width / 6, 440f, 1825f, 555f), "<color=red><b>▼</b></color>" + PDIKIHDGCMC + "Connect", 0, gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleLeft;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "_ScreenResolution";
			}
			GUI.Label(new Rect(1932f, 363f, 1140f, 1465f), "selColor" + PMHLEBDGPIF + "_Bullet_3");
			Rect position2 = new Rect(838f, 177f, 196f, 123f);
			string[] array3 = new string[6];
			array3[1] = "CameraFilterPack/Gradients_Tech";
			array3[1] = EEGGDFDPFCF;
			array3[5] = "INF";
			array3[0] = text;
			array3[6] = "OffScreenIndicator Canvas field requieres a Canvas GameObject";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 470f < 1875f)) ? 846f : (vector.z * 189f));
			if (vector.z > 1316f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(556f, 812f, 286f, 1434f);
				GUI.Label(new Rect(vector.x - 274f, (float)Screen.height - vector.y - 120f - num, 816f, 1361f), "_Sensitivity" + (int)num2 + "RMB - aim");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 42f, (float)Screen.height - vector.y - 371f - num, 1531f, 118f), "RemoveFriends can't be called for empty or null list." + (int)num2 + "_MainTex");
				GUI.DrawTexture(new Rect(vector.x - 615f, (float)Screen.height - vector.y - 1784f - num + 458f, 1128f, 754f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("_Value");
			gUIStyle.name = "_Value2";
			gUIStyle.alignment = TextAnchor.LowerCenter;
			Rect pLGJJIBFGFL = new Rect(1578f, 1238f, Screen.width, 236f);
			string[] array = new string[3];
			array[1] = "_Specular";
			array[1] = LAKMEIFLGJD;
			array[4] = string.Empty;
			array[8] = (PAGEHOLHMHC + 1).ToString();
			array[7] = "_Distortion";
			__BB_OBFUSCATOR_31(pLGJJIBFGFL, string.Concat(array), 1, gUIStyle);
			Rect position = new Rect(973f, 521f, Screen.width, 1190f);
			string[] array2 = new string[8];
			array2[0] = "_Blue_R";
			array2[1] = LAKMEIFLGJD;
			array2[7] = string.Empty;
			array2[6] = (PAGEHOLHMHC + 0).ToString();
			array2[6] = "Deaths";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleRight;
			GUI.DrawTexture(new Rect(Screen.width / 0 - -87, 1965f, 863f, 1517f), NMGNFCHGIIE);
			__BB_OBFUSCATOR_39(new Rect(Screen.width / 4, 786f, 616f, 1711f), "_TimeX" + PDIKIHDGCMC + "SecondaryCausticsProjector", 1, gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleLeft;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "<";
			}
			GUI.Label(new Rect(212f, 317f, 993f, 452f), "CameraFilterPack/Distortion_Water_Drop" + PMHLEBDGPIF + "team2");
			Rect position2 = new Rect(352f, 80f, 1388f, 841f);
			string[] array3 = new string[1];
			array3[0] = "_ScreenResolution";
			array3[1] = EEGGDFDPFCF;
			array3[0] = "_Red_B";
			array3[2] = text;
			array3[7] = "Player";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 828f < 1996f)) ? 128f : (vector.z * 1886f));
			if (vector.z > 568f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(1622f, 1367f, 1390f, 1299f);
				GUI.Label(new Rect(vector.x - 570f, (float)Screen.height - vector.y - 1302f - num, 837f, 1894f), "Mouse X" + (int)num2 + "|");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 629f, (float)Screen.height - vector.y - 1064f - num, 1094f, 1506f), ">" + (int)num2 + "_Value");
				GUI.DrawTexture(new Rect(vector.x - 752f, (float)Screen.height - vector.y - 601f - num + 1295f, 1136f, 867f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_39(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(1014f, 89f, 1773f, 1251f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 1; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(234f, 626f, 681f, 1548f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_54(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	private IEnumerator __BB_OBFUSCATOR_40()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (PDIKIHDGCMC > 0)
		{
			PDIKIHDGCMC -= 0;
		}
		else
		{
			PDIKIHDGCMC = 1;
		}
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("</size>", PhotonTargets.Others, PDIKIHDGCMC);
		}
	}

	private void __BB_OBFUSCATOR_49(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	private void __BB_OBFUSCATOR_70(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	private void __BB_OBFUSCATOR_12(int IMHOIKDBODM)
	{
		if (base.photonView.isMine)
		{
			IMHOIKDBODM = PAGEHOLHMHC;
		}
		PAGEHOLHMHC = IMHOIKDBODM;
		JKEAGMLGENI = IMHOIKDBODM;
	}

	[PunRPC]
	private void SyncNPCCount(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void __BB_OBFUSCATOR_26(int IMHOIKDBODM)
	{
		if (base.photonView.isMine)
		{
			IMHOIKDBODM = PAGEHOLHMHC;
		}
		PAGEHOLHMHC = IMHOIKDBODM;
		JKEAGMLGENI = IMHOIKDBODM;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (PDIKIHDGCMC > 1)
		{
			PDIKIHDGCMC -= 0;
		}
		else
		{
			PDIKIHDGCMC = 0;
		}
		if (PhotonNetwork.isMasterClient)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = PDIKIHDGCMC;
			obj.RPC("Left Stick Up", PhotonTargets.Others, array);
		}
	}

	private void FixedUpdate()
	{
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		if (PhotonNetwork.isMasterClient)
		{
			if (JKEAGMLGENI != PAGEHOLHMHC)
			{
				StartCoroutine(WaveStatus());
				JKEAGMLGENI = PAGEHOLHMHC;
				base.photonView.RPC("SyncWave", PhotonTargets.All, PAGEHOLHMHC);
			}
			GameObject[] array = GameObject.FindGameObjectsWithTag("team1");
			if (array.Length < 1 && !DLOFIAHGCNN)
			{
				base.photonView.RPC("GameOver", PhotonTargets.All);
				DLOFIAHGCNN = true;
			}
		}
		if (LIBIJNOONHG)
		{
			if (PDIKIHDGCMC < 1)
			{
				DNPNMLPNOFE.transform.position = Vector3.Lerp(DNPNMLPNOFE.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up * 2.5f, 0.75f * Time.smoothDeltaTime);
				Quaternion b = Quaternion.LookRotation(FCMIHIHPEFO[LJGHEKKGNHK].position - DNPNMLPNOFE.transform.position);
				if (Vector3.Distance(DNPNMLPNOFE.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position) > 10f)
				{
					DNPNMLPNOFE.transform.rotation = Quaternion.Slerp(DNPNMLPNOFE.transform.rotation, b, 1f * Time.deltaTime);
					BGEFGFBOJKF.AFOICCPPEEO = false;
				}
				else
				{
					if (BGEFGFBOJKF.PEILLCCBAHC != null)
					{
						if (Vector3.Distance(FCMIHIHPEFO[LJGHEKKGNHK].position, BGEFGFBOJKF.PEILLCCBAHC.transform.position) < 7f)
						{
							BGEFGFBOJKF.AFOICCPPEEO = true;
						}
						else
						{
							BGEFGFBOJKF.AFOICCPPEEO = false;
						}
					}
					DNPNMLPNOFE.GetComponent<Collider>().enabled = true;
				}
				DNPNMLPNOFE.transform.localEulerAngles = new Vector3(0f, DNPNMLPNOFE.transform.localEulerAngles.y, 0f);
			}
			else
			{
				DNPNMLPNOFE.transform.position = Vector3.Lerp(DNPNMLPNOFE.transform.position, new Vector3(DNPNMLPNOFE.transform.position.x, 250f, DNPNMLPNOFE.transform.position.z), 0.05f * Time.smoothDeltaTime);
				DNPNMLPNOFE.GetComponent<Collider>().enabled = false;
				BGEFGFBOJKF.AFOICCPPEEO = false;
			}
		}
		else if (PDIKIHDGCMC < 1)
		{
			if (BGEFGFBOJKF.PEILLCCBAHC != null)
			{
				if (Vector3.Distance(FCMIHIHPEFO[LJGHEKKGNHK].position, BGEFGFBOJKF.PEILLCCBAHC.transform.position) < 4f)
				{
					BGEFGFBOJKF.AFOICCPPEEO = true;
				}
				else
				{
					BGEFGFBOJKF.AFOICCPPEEO = false;
				}
			}
			Animation component = FCMIHIHPEFO[LJGHEKKGNHK].transform.Find("SupplyCrate").GetComponent<Animation>();
			component.Play("open");
		}
		else
		{
			BGEFGFBOJKF.AFOICCPPEEO = false;
			for (int i = 0; i < FCMIHIHPEFO.Length; i++)
			{
				Animation component2 = FCMIHIHPEFO[i].transform.Find("SupplyCrate").GetComponent<Animation>();
				component2.Play("close");
			}
		}
		if (PFNMEFHNPKA.clip != MDKJKFCOJGE[PAGEHOLHMHC].music && PDIKIHDGCMC > 0 && !OJJEPMGNFHP)
		{
			if (PAGEHOLHMHC >= MDKJKFCOJGE.Count - 1)
			{
				StartCoroutine(SwitchClip(MDKJKFCOJGE[PAGEHOLHMHC].music, 0.5f));
			}
			else
			{
				StartCoroutine(SwitchClip(MDKJKFCOJGE[PAGEHOLHMHC].music, 0.2f));
			}
		}
		if (PFNMEFHNPKA.clip != MDKJKFCOJGE[0].music && PDIKIHDGCMC <= 0 && !OJJEPMGNFHP)
		{
			StartCoroutine(SwitchClip(MDKJKFCOJGE[0].music, DNKALNAFOHF));
		}
		FHMBDHIHNBB = OEJIEFEJGHC + PhotonNetwork.playerList.Length / 2;
	}

	private static Transform __BB_OBFUSCATOR_66(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_22(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	private void __BB_OBFUSCATOR_25(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	private void __BB_OBFUSCATOR_56()
	{
		SurvivalMechanics survivalMechanics = Resources.Load("_Value", typeof(SurvivalMechanics)) as SurvivalMechanics;
		MDKJKFCOJGE = new List<waveInfo>();
		for (int i = 1; i < survivalMechanics.MDKJKFCOJGE.Count; i += 0)
		{
			MDKJKFCOJGE.Add(survivalMechanics.MDKJKFCOJGE[i]);
		}
		MDKJKFCOJGE.Add(COHAANEIGIM);
		ObscuredPrefs.SetBool("_ColorR", false);
		PFNMEFHNPKA = GetComponent<AudioSource>();
		MDKJKFCOJGE[0].music = PFNMEFHNPKA.clip;
		DNKALNAFOHF = PFNMEFHNPKA.volume;
		if (GDPAFHGOECB)
		{
			OEJIEFEJGHC = -55;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("\\s3key.txt");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003CAwake_003Em__0;
		}
		FCMIHIHPEFO = Array.ConvertAll(array, NCBIMIMMADO);
		FHMBDHIHNBB = OEJIEFEJGHC;
	}

	private void Awake()
	{
		SurvivalMechanics survivalMechanics = Resources.Load("SurvivalWaves", typeof(SurvivalMechanics)) as SurvivalMechanics;
		MDKJKFCOJGE = new List<waveInfo>();
		for (int i = 0; i < survivalMechanics.MDKJKFCOJGE.Count; i++)
		{
			MDKJKFCOJGE.Add(survivalMechanics.MDKJKFCOJGE[i]);
		}
		MDKJKFCOJGE.Add(COHAANEIGIM);
		ObscuredPrefs.SetBool("Shop", false);
		PFNMEFHNPKA = GetComponent<AudioSource>();
		MDKJKFCOJGE[0].music = PFNMEFHNPKA.clip;
		DNKALNAFOHF = PFNMEFHNPKA.volume;
		if (GDPAFHGOECB)
		{
			OEJIEFEJGHC = 20;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("ShopPoint");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003CAwake_003Em__0;
		}
		FCMIHIHPEFO = Array.ConvertAll(array, NCBIMIMMADO);
		FHMBDHIHNBB = OEJIEFEJGHC;
	}

	private void __BB_OBFUSCATOR_60(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void __BB_OBFUSCATOR_16()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 0;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_17(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_15()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	private static Transform __BB_OBFUSCATOR_34(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (PDIKIHDGCMC > 0)
		{
			PDIKIHDGCMC--;
		}
		else
		{
			PDIKIHDGCMC = 1;
		}
		if (PhotonNetwork.isMasterClient)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = PDIKIHDGCMC;
			obj.RPC(": ", PhotonTargets.All, array);
		}
	}

	public void SyncAllNow(PhotonPlayer PALBCNDPILP)
	{
		base.photonView.RPC("SyncWave", PALBCNDPILP, PAGEHOLHMHC);
		base.photonView.RPC("SyncNPCCount", PALBCNDPILP, PDIKIHDGCMC);
		base.photonView.RPC("SyncShopID", PALBCNDPILP, LJGHEKKGNHK);
	}

	private IEnumerator WaveStatus()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	public void __BB_OBFUSCATOR_9()
	{
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < HHDECLNABAC.Length; i += 0)
			{
				PhotonNetwork.Destroy(HHDECLNABAC[i].transform.parent.gameObject);
			}
		}
		PAGEHOLHMHC = 0;
		JKEAGMLGENI = -1;
		DLOFIAHGCNN = false;
	}

	[CompilerGenerated]
	private static Transform _003CAwake_003Em__0(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	public void __BB_OBFUSCATOR_67()
	{
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 1; i < HHDECLNABAC.Length; i += 0)
			{
				PhotonNetwork.Destroy(HHDECLNABAC[i].transform.parent.gameObject);
			}
		}
		PAGEHOLHMHC = 1;
		JKEAGMLGENI = -1;
		DLOFIAHGCNN = false;
	}

	private void NPCDeath()
	{
		if (PDIKIHDGCMC > 0)
		{
			PDIKIHDGCMC--;
		}
		else
		{
			PDIKIHDGCMC = 0;
		}
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
	}

	private void OnEnable()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Shop") as GameObject);
		BGEFGFBOJKF = gameObject.GetComponent<ShopSystem>();
		gameObject.transform.position = Vector3.zero;
		if (LIBIJNOONHG)
		{
			DNPNMLPNOFE = UnityEngine.Object.Instantiate(Resources.Load("SupplyHelicopter") as GameObject);
			DNPNMLPNOFE.transform.position = new Vector3(0f, 250f, 0f);
		}
		if (!LIBIJNOONHG)
		{
			for (int i = 0; i < FCMIHIHPEFO.Length; i++)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(Resources.Load("SupplyCrate") as GameObject);
				gameObject2.name = "SupplyCrate";
				gameObject2.transform.parent = FCMIHIHPEFO[i];
				gameObject2.transform.localPosition = new Vector3(0f, -0.5f, 0f);
				gameObject2.transform.localEulerAngles = Vector3.zero;
			}
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			LAKMEIFLGJD = translator.Translate(115, "MP");
			PMHLEBDGPIF = translator.Translate(118, "MP");
			EEGGDFDPFCF = translator.Translate(63, "MP");
		}
	}

	private static Transform __BB_OBFUSCATOR_23(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_21(AudioClip HNPMLCHJFJI, float NHCLOPKIICI)
	{
		OJJEPMGNFHP = true;
		while (PFNMEFHNPKA.volume != 0f)
		{
			PFNMEFHNPKA.volume -= 1f * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.clip = HNPMLCHJFJI;
		PFNMEFHNPKA.Play();
		while (PFNMEFHNPKA.volume < NHCLOPKIICI)
		{
			PFNMEFHNPKA.volume += NHCLOPKIICI * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.volume = NHCLOPKIICI;
		OJJEPMGNFHP = false;
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_17(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_9(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_31(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(168f, 1158f, 431f, 1056f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 0; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(808f, 1759f, 1285f, 1613f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	[PunRPC]
	private void SyncWave(int IMHOIKDBODM)
	{
		if (base.photonView.isMine)
		{
			IMHOIKDBODM = PAGEHOLHMHC;
		}
		PAGEHOLHMHC = IMHOIKDBODM;
		JKEAGMLGENI = IMHOIKDBODM;
	}

	private IEnumerator __BB_OBFUSCATOR_46()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	private void __BB_OBFUSCATOR_3(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_9(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_9(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_65(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	public void __BB_OBFUSCATOR_47()
	{
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < HHDECLNABAC.Length; i++)
			{
				PhotonNetwork.Destroy(HHDECLNABAC[i].transform.parent.gameObject);
			}
		}
		PAGEHOLHMHC = 1;
		JKEAGMLGENI = -1;
		DLOFIAHGCNN = true;
	}

	private void __BB_OBFUSCATOR_2()
	{
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	[PunRPC]
	private void GameOver()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 0;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}

	private IEnumerator __BB_OBFUSCATOR_78()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_58()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_17(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 0;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	private void __BB_OBFUSCATOR_28()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Loading complete") as GameObject);
		BGEFGFBOJKF = gameObject.GetComponent<ShopSystem>();
		gameObject.transform.position = Vector3.zero;
		if (LIBIJNOONHG)
		{
			DNPNMLPNOFE = UnityEngine.Object.Instantiate(Resources.Load("VS") as GameObject);
			DNPNMLPNOFE.transform.position = new Vector3(124f, 1793f, 1345f);
		}
		if (!LIBIJNOONHG)
		{
			for (int i = 0; i < FCMIHIHPEFO.Length; i += 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(Resources.Load("Deaths") as GameObject);
				gameObject2.name = "OnFall";
				gameObject2.transform.parent = FCMIHIHPEFO[i];
				gameObject2.transform.localPosition = new Vector3(1036f, 987f, 1719f);
				gameObject2.transform.localEulerAngles = Vector3.zero;
			}
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_RgbDepthTex") > 1)
		{
			LAKMEIFLGJD = translator.Translate(-6, "SBX");
			PMHLEBDGPIF = translator.Translate(75, "\\Google");
			EEGGDFDPFCF = translator.Translate(-5, " ");
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	private void __BB_OBFUSCATOR_6()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 1;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_42(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private IEnumerator SwitchClip(AudioClip HNPMLCHJFJI, float NHCLOPKIICI)
	{
		OJJEPMGNFHP = true;
		while (PFNMEFHNPKA.volume != 0f)
		{
			PFNMEFHNPKA.volume -= 1f * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.clip = HNPMLCHJFJI;
		PFNMEFHNPKA.Play();
		while (PFNMEFHNPKA.volume < NHCLOPKIICI)
		{
			PFNMEFHNPKA.volume += NHCLOPKIICI * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.volume = NHCLOPKIICI;
		OJJEPMGNFHP = false;
	}

	private void __BB_OBFUSCATOR_76(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private IEnumerator __BB_OBFUSCATOR_52(AudioClip HNPMLCHJFJI, float NHCLOPKIICI)
	{
		OJJEPMGNFHP = true;
		while (PFNMEFHNPKA.volume != 0f)
		{
			PFNMEFHNPKA.volume -= 1f * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.clip = HNPMLCHJFJI;
		PFNMEFHNPKA.Play();
		while (PFNMEFHNPKA.volume < NHCLOPKIICI)
		{
			PFNMEFHNPKA.volume += NHCLOPKIICI * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.volume = NHCLOPKIICI;
		OJJEPMGNFHP = false;
	}

	private static Transform __BB_OBFUSCATOR_11(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (PDIKIHDGCMC > 1)
		{
			PDIKIHDGCMC -= 0;
		}
		else
		{
			PDIKIHDGCMC = 0;
		}
		if (PhotonNetwork.isMasterClient)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = PDIKIHDGCMC;
			obj.RPC("_Distortion", PhotonTargets.Others, array);
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("Wood") as GameObject);
		BGEFGFBOJKF = gameObject.GetComponent<ShopSystem>();
		gameObject.transform.position = Vector3.zero;
		if (LIBIJNOONHG)
		{
			DNPNMLPNOFE = UnityEngine.Object.Instantiate(Resources.Load("Ping") as GameObject);
			DNPNMLPNOFE.transform.position = new Vector3(758f, 592f, 557f);
		}
		if (!LIBIJNOONHG)
		{
			for (int i = 1; i < FCMIHIHPEFO.Length; i += 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(Resources.Load("_Value4") as GameObject);
				gameObject2.name = ">";
				gameObject2.transform.parent = FCMIHIHPEFO[i];
				gameObject2.transform.localPosition = new Vector3(1217f, 1425f, 1730f);
				gameObject2.transform.localEulerAngles = Vector3.zero;
			}
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("team2") > 0)
		{
			LAKMEIFLGJD = translator.Translate(-52, "We connected to Photon Cloud");
			PMHLEBDGPIF = translator.Translate(-70, "NextFrame");
			EEGGDFDPFCF = translator.Translate(36, "_Vignette_Alpha");
		}
	}

	private void __BB_OBFUSCATOR_7(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void __BB_OBFUSCATOR_64(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().SpawnPlayer(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		SurvivalMechanics survivalMechanics = Resources.Load("_ClutTex", typeof(SurvivalMechanics)) as SurvivalMechanics;
		MDKJKFCOJGE = new List<waveInfo>();
		for (int i = 1; i < survivalMechanics.MDKJKFCOJGE.Count; i += 0)
		{
			MDKJKFCOJGE.Add(survivalMechanics.MDKJKFCOJGE[i]);
		}
		MDKJKFCOJGE.Add(COHAANEIGIM);
		ObscuredPrefs.SetBool("_WaveIntensity", true);
		PFNMEFHNPKA = GetComponent<AudioSource>();
		MDKJKFCOJGE[0].music = PFNMEFHNPKA.clip;
		DNKALNAFOHF = PFNMEFHNPKA.volume;
		if (GDPAFHGOECB)
		{
			OEJIEFEJGHC = 127;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("CameraFilterPack_AAA_Blood1");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_23;
		}
		FCMIHIHPEFO = Array.ConvertAll(array, NCBIMIMMADO);
		FHMBDHIHNBB = OEJIEFEJGHC;
	}

	private void __BB_OBFUSCATOR_74(int PMOENJDGDOP)
	{
		if (base.photonView.isMine)
		{
			PMOENJDGDOP = PDIKIHDGCMC;
		}
		PDIKIHDGCMC = PMOENJDGDOP;
	}

	private void __BB_OBFUSCATOR_32(int IMHOIKDBODM)
	{
		if (base.photonView.isMine)
		{
			IMHOIKDBODM = PAGEHOLHMHC;
		}
		PAGEHOLHMHC = IMHOIKDBODM;
		JKEAGMLGENI = IMHOIKDBODM;
	}

	private IEnumerator __BB_OBFUSCATOR_71(AudioClip HNPMLCHJFJI, float NHCLOPKIICI)
	{
		OJJEPMGNFHP = true;
		while (PFNMEFHNPKA.volume != 0f)
		{
			PFNMEFHNPKA.volume -= 1f * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.clip = HNPMLCHJFJI;
		PFNMEFHNPKA.Play();
		while (PFNMEFHNPKA.volume < NHCLOPKIICI)
		{
			PFNMEFHNPKA.volume += NHCLOPKIICI * Time.deltaTime;
			yield return null;
		}
		PFNMEFHNPKA.volume = NHCLOPKIICI;
		OJJEPMGNFHP = false;
	}

	[PunRPC]
	private void SyncTime(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	[PunRPC]
	private void Win()
	{
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}

	private void __BB_OBFUSCATOR_35()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 1;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (GetComponent<RoomMultiplayerMenu>().CBIFAIJOMKC == null)
		{
			GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_17(GetComponent<RoomMultiplayerMenu>().LEPLDNNHJPF.teamName);
		}
	}

	private void DrawOutline(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(0f, 0f, 0f, 1f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 1; i <= KFOLBNHLGDP - 1; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(1f, 1f, 1f, 1f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_37()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.backgroundColor = Color.red;
		if (PDIKIHDGCMC > 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle(", attributes = ");
			gUIStyle.name = "Checker";
			gUIStyle.alignment = TextAnchor.UpperCenter;
			Rect pLGJJIBFGFL = new Rect(182f, 1476f, Screen.width, 1231f);
			string[] array = new string[5];
			array[1] = "team1";
			array[0] = LAKMEIFLGJD;
			array[7] = string.Empty;
			array[3] = (PAGEHOLHMHC + 1).ToString();
			array[8] = "  ";
			__BB_OBFUSCATOR_31(pLGJJIBFGFL, string.Concat(array), 0, gUIStyle);
			Rect position = new Rect(593f, 518f, Screen.width, 1975f);
			string[] array2 = new string[2];
			array2[1] = "Indexes";
			array2[1] = LAKMEIFLGJD;
			array2[1] = string.Empty;
			array2[0] = (PAGEHOLHMHC + 1).ToString();
			array2[0] = "RefTime";
			GUI.Label(position, string.Concat(array2), gUIStyle);
			gUIStyle.alignment = TextAnchor.MiddleRight;
			GUI.DrawTexture(new Rect(Screen.width / 0 - -77, 578f, 1127f, 963f), NMGNFCHGIIE);
			__BB_OBFUSCATOR_62(new Rect(Screen.width / 6, 966f, 1526f, 314f), "_Offsets" + PDIKIHDGCMC + "BodyURL", 0, gUIStyle);
			gUIStyle.alignment = TextAnchor.LowerCenter;
		}
		else
		{
			string text = BIGAGKNBJJO.ToString();
			if (BIGAGKNBJJO == 0)
			{
				text = "Show wireframe";
			}
			GUI.Label(new Rect(636f, 1695f, 943f, 1376f), "controller3" + PMHLEBDGPIF + "ServerID");
			Rect position2 = new Rect(936f, 570f, 450f, 1966f);
			string[] array3 = new string[1];
			array3[0] = "3";
			array3[0] = EEGGDFDPFCF;
			array3[5] = "_TimeX";
			array3[2] = text;
			array3[7] = "FireballB";
			GUI.Label(position2, string.Concat(array3));
		}
		if (BGEFGFBOJKF.PEILLCCBAHC != null && (bool)Camera.main)
		{
			Vector3 vector = Camera.main.WorldToScreenPoint(FCMIHIHPEFO[LJGHEKKGNHK].position + Vector3.up);
			float num = ((!(vector.z * 83f < 1403f)) ? 125f : (vector.z * 1749f));
			if (vector.z > 1058f)
			{
				float num2 = Vector3.Distance(BGEFGFBOJKF.PEILLCCBAHC.transform.position, FCMIHIHPEFO[LJGHEKKGNHK].position);
				GUI.color = new Color(1176f, 114f, 1993f, 1541f);
				GUI.Label(new Rect(vector.x - 1102f, (float)Screen.height - vector.y - 502f - num, 1038f, 44f), "MP" + (int)num2 + "Target no longer exists: ");
				GUI.color = Color.white;
				GUI.Label(new Rect(vector.x - 643f, (float)Screen.height - vector.y - 148f - num, 797f, 1511f), "Result" + (int)num2 + "CameraFilterPack/Drawing_Halftone");
				GUI.DrawTexture(new Rect(vector.x - 766f, (float)Screen.height - vector.y - 403f - num + 1542f, 494f, 1723f), PMKMNCGKPKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (PDIKIHDGCMC > 1)
		{
			PDIKIHDGCMC--;
		}
		else
		{
			PDIKIHDGCMC = 0;
		}
		if (PhotonNetwork.isMasterClient)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = PDIKIHDGCMC;
			obj.RPC("(", PhotonTargets.Others, array);
		}
	}

	private static Transform __BB_OBFUSCATOR_61(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		LJGHEKKGNHK = UnityEngine.Random.Range(0, FCMIHIHPEFO.Length);
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncShopID", PhotonTargets.All, LJGHEKKGNHK);
		}
		float num = PhotonNetwork.playerList.Length;
		int num2 = MDKJKFCOJGE[PAGEHOLHMHC].totalCount;
		if (num > 1f && num2 > 4)
		{
			num2 = (int)((float)MDKJKFCOJGE[PAGEHOLHMHC].totalCount * (1f + num / 3f));
		}
		if (num2 > 250)
		{
			num2 = 250;
		}
		PDIKIHDGCMC += num2;
		if (PhotonNetwork.isMasterClient)
		{
			base.photonView.RPC("SyncNPCCount", PhotonTargets.All, PDIKIHDGCMC);
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (PDIKIHDGCMC > 0)
		{
			for (int i = 0; i < PDIKIHDGCMC; i++)
			{
				while (GameObject.FindGameObjectsWithTag("team2").Length >= (int)FHMBDHIHNBB)
				{
					yield return null;
				}
				if (PhotonNetwork.isMasterClient && HHDECLNABAC.Length < PDIKIHDGCMC)
				{
					Transform transform = GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints[UnityEngine.Random.Range(0, GetComponent<RoomMultiplayerMenu>().NICGOGPHBPD.spawnPoints.Length)];
					string text = MDKJKFCOJGE[PAGEHOLHMHC].defaultNPC;
					for (int j = 0; j < MDKJKFCOJGE[PAGEHOLHMHC].NPC.Length; j++)
					{
						if (MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned && PDIKIHDGCMC <= (int)FHMBDHIHNBB)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
							MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].bossHasSpawned = true;
						}
						else if (UnityEngine.Random.Range(0, MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].spawnChance) == 0 && !MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].isBoss)
						{
							text = MDKJKFCOJGE[PAGEHOLHMHC].NPC[j].npcName;
						}
					}
					yield return new WaitForSeconds(0.1f);
					PhotonNetwork.InstantiateSceneObject("SUR/" + text, transform.position, transform.rotation, 0, null);
				}
				HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
			}
			yield return new WaitForEndOfFrame();
		}
		HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		while (HHDECLNABAC.Length > 0)
		{
			yield return new WaitForSeconds(1f);
			HHDECLNABAC = GameObject.FindGameObjectsWithTag("team2");
		}
		yield return new WaitForSeconds(1f);
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			BIGAGKNBJJO = 45;
			if (PhotonNetwork.isMasterClient && PAGEHOLHMHC < MDKJKFCOJGE.Count)
			{
				base.photonView.RPC("RespawnPlayers", PhotonTargets.All);
				LGBBPEIHEPF = true;
				while (BIGAGKNBJJO > 0)
				{
					BIGAGKNBJJO--;
					base.photonView.RPC("SyncTime", PhotonTargets.All, BIGAGKNBJJO);
					yield return new WaitForSeconds(1f);
				}
				LGBBPEIHEPF = false;
			}
			while (LGBBPEIHEPF)
			{
				yield return new WaitForEndOfFrame();
			}
		}
		if (PAGEHOLHMHC < MDKJKFCOJGE.Count - 1)
		{
			PAGEHOLHMHC++;
		}
		else
		{
			base.photonView.RPC("Win", PhotonTargets.All);
		}
	}

	[PunRPC]
	private void SyncShopID(int DCAPPFOOIBM)
	{
		if (base.photonView.isMine)
		{
			DCAPPFOOIBM = LJGHEKKGNHK;
		}
		LJGHEKKGNHK = DCAPPFOOIBM;
	}

	private void __BB_OBFUSCATOR_20()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 0;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	private void __BB_OBFUSCATOR_57()
	{
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
	}

	private void __BB_OBFUSCATOR_13(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	private void __BB_OBFUSCATOR_73(int DPEGBOCJGHK)
	{
		if (base.photonView.isMine)
		{
			DPEGBOCJGHK = BIGAGKNBJJO;
		}
		BIGAGKNBJJO = DPEGBOCJGHK;
	}

	private void __BB_OBFUSCATOR_5()
	{
		SurvivalMechanics survivalMechanics = Resources.Load("_Value4", typeof(SurvivalMechanics)) as SurvivalMechanics;
		MDKJKFCOJGE = new List<waveInfo>();
		for (int i = 1; i < survivalMechanics.MDKJKFCOJGE.Count; i++)
		{
			MDKJKFCOJGE.Add(survivalMechanics.MDKJKFCOJGE[i]);
		}
		MDKJKFCOJGE.Add(COHAANEIGIM);
		ObscuredPrefs.SetBool("Vertex count: ", true);
		PFNMEFHNPKA = GetComponent<AudioSource>();
		MDKJKFCOJGE[0].music = PFNMEFHNPKA.clip;
		DNKALNAFOHF = PFNMEFHNPKA.volume;
		if (GDPAFHGOECB)
		{
			OEJIEFEJGHC = 36;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("player");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_11;
		}
		FCMIHIHPEFO = Array.ConvertAll(array, NCBIMIMMADO);
		FHMBDHIHNBB = OEJIEFEJGHC;
	}

	private void __BB_OBFUSCATOR_48()
	{
		StopAllCoroutines();
		PDIKIHDGCMC = 0;
		GetComponent<RoomMultiplayerMenu>().JAFLIDKMIAJ = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
	}
}
