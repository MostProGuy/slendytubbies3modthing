using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Photon;
using TranslatorSystem;
using UnityEngine;

public class LobbyMenu : Photon.MonoBehaviour
{
	[Serializable]
	public class AllMaps
	{
		public ObscuredString mapName;

		public Sprite mapPreview;

		public int size;
	}

	[Serializable]
	public class AllModes
	{
		public string modeName;

		public string modeID;

		public ObscuredString players;
	}

	[Serializable]
	public class AllSizes
	{
		public string sizeName;

		public string[] playerCount;
	}

	public GUISkin NMOHLIAHHDP;

	public List<AllModes> GGNPFHJNLNH;

	public List<AllModes> HCNEKALECDP;

	public List<AllMaps> CEIDNDICFDB;

	public List<AllMaps> IBOMABMKHGO;

	public List<AllSizes> KHDMIOLINEB;

	public int PABHMLILIPH;

	public int OEMFPBFHCAN;

	public ObscuredInt KNLBHCIPLGB = 10;

	public ObscuredInt DJJAALCLLNC = 10;

	public string NOKEBHKODBG;

	public bool GGNMMMIKBIF;

	private bool HBKNIAMBIPN;

	public SpriteRenderer EPGJECDEGCD;

	public MainMenu FMMMCGELLII;

	public bool NDDNNKNICAL;

	public GameObject DJOLBLGMMJJ;

	private RoomInfo[] LHLDKHPGPDN;

	public GameObject[] NMFPHHLHAEI;

	public string[] FIAGBEJMOBO;

	private int NMABHEEPLNH = 1;

	private bool ANPMFJFACHA;

	private string LIDPADGALHD = "Back";

	private string HOMAKKMOAKH = "Connecting";

	private string KKPHGGAPEKH = "Lobby";

	private string PLEGLFJFBDE = "Room Name";

	private string AOFGBEIDLFI = "Players";

	private string HPCMJNPADCB = "Game Mode";

	private string PFPOLDMMJLP = "Map Name";

	private string NCLLLEBNPIH = "Player Name";

	private string NDPCJPPIMEI = "Join";

	private string OLFLKBGGMOI = "Host Game";

	private string DIEAPJDAHMA = "Game Settings";

	private string HBKGIBKICAC = "Map Size";

	private string JJNEGBCFIKO = "Recommended Players";

	private string DPIFGAOOFBI = "Mute Guests";

	private string BMIABMEBIJK = "Start Game";

	private string MAGGPAFNGKO = "Timer";

	private string HNNBKCMOCCL = " minutes";

	private string MKBHKPPOHLP = "Custard Amount";

	private string HKAPJDFHBKM = " Private";

	private Vector2 IHNECEGCJFF = Vector2.zero;

	private bool DPGFMJIIEIN;

	private int ENJBIHHJNAP = 1;

	private Vector2 GIKHPNELGDI = Vector2.zero;

	private bool BOOMONKHGOF;

	[CompilerGenerated]
	private static Func<AllMaps, ObscuredString> NCBIMIMMADO;

	private void __BB_OBFUSCATOR_8()
	{
		UnityEngine.MonoBehaviour.print("SecondaryCausticsProjector");
		ANPMFJFACHA = true;
	}

	private void OnDisconnectedFromPhoton()
	{
		UnityEngine.MonoBehaviour.print("We disconencted from Photon Cloud");
		if (!FMMMCGELLII.GPOIIAABDMC.activeSelf && !NDDNNKNICAL)
		{
			FMMMCGELLII.ShowLobby();
		}
		DJOLBLGMMJJ.SetActive(true);
	}

	private void __BB_OBFUSCATOR_9()
	{
		UnityEngine.MonoBehaviour.print("MP");
		DJOLBLGMMJJ.SetActive(true);
	}

	private void MainLobbyMenu()
	{
		int num = Screen.height / 17;
		int num2 = Screen.width / 27;
		GUI.skin = NMOHLIAHHDP;
		GUI.Box(new Rect(num2, num, Screen.width - num2 * 2, Screen.height - num * 3), "<size=" + (float)num / 1.5f + ">" + KKPHGGAPEKH + " </size><size=" + (float)num / 2f + "> <color=white>(" + ObscuredPrefs.GetString("ServerName") + ")</color></size>");
		GUI.Label(new Rect(num2 * 2, (float)Screen.height - (float)num * 3.5f, num2 * 4, num), "<size=" + (float)num2 / 1.75f + ">  " + PLEGLFJFBDE + "</size>", NMOHLIAHHDP.customStyles[0]);
		NOKEBHKODBG = GUI.TextField(new Rect(num2 * 6, (float)Screen.height - (float)num * 3.5f, Screen.width - num2 * 12, num), NOKEBHKODBG, 20);
		if (NOKEBHKODBG.Contains("<"))
		{
			NOKEBHKODBG = NOKEBHKODBG.Replace("<", " ");
		}
		if (GUI.Button(new Rect((float)Screen.width - (float)num2 * 5.5f, (float)Screen.height - (float)num * 3.5f, num2 * 3, num - 1), "<size=" + (float)num / 1.75f + ">" + NDPCJPPIMEI + "</size>"))
		{
			PhotonNetwork.JoinRoom(NOKEBHKODBG);
			ANPMFJFACHA = true;
		}
		GUI.color = Color.grey;
		GUI.Label(new Rect(num * 2, num * 2, num2 * 5, num), "<size=" + (float)num2 / 2f + ">  " + PLEGLFJFBDE + "</size>", NMOHLIAHHDP.customStyles[0]);
		GUI.Label(new Rect(num2 * 7, num * 2, num2 * 5, num), "<size=" + (float)num2 / 2f + ">" + HPCMJNPADCB + "</size>", NMOHLIAHHDP.customStyles[0]);
		GUI.Label(new Rect(num2 * 12, num * 2, num2 * 5, num), "<size=" + (float)num2 / 2f + ">" + AOFGBEIDLFI + "</size>", NMOHLIAHHDP.customStyles[0]);
		GUI.Label(new Rect(num2 * 17, num * 2, num2 * 5, num), "<size=" + (float)num2 / 2f + ">" + PFPOLDMMJLP + "</size>", NMOHLIAHHDP.customStyles[0]);
		GUI.color = Color.white;
		IHNECEGCJFF = GUI.BeginScrollView(new Rect(num2 * 2, num * 3, Screen.width - num2 * 4, Screen.height - num * 7), IHNECEGCJFF, new Rect(0f, 0f, Screen.width - num2 * 5, num * LHLDKHPGPDN.Length));
		if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 0)
		{
			for (int i = 0; i < LHLDKHPGPDN.Length; i++)
			{
				GUI.Label(new Rect(0f, num * 0 + num * i, num2 * 5, num), "<size=" + (float)num2 / 1.75f + "> " + LHLDKHPGPDN[i].name + "</size>", NMOHLIAHHDP.customStyles[0]);
				string text = (string)LHLDKHPGPDN[i].customProperties["GameMode"];
				if (text == "COOP")
				{
					text = GGNPFHJNLNH[0].modeName;
				}
				if (text == "VS")
				{
					text = GGNPFHJNLNH[1].modeName;
				}
				if (text == "SUR")
				{
					string text2 = " ";
					if (LHLDKHPGPDN[i].customProperties["Difficulty"] != null)
					{
						int num3 = (int)LHLDKHPGPDN[i].customProperties["Difficulty"];
						if (num3 == 1)
						{
							text2 = " ☠";
						}
						if (num3 == 2)
						{
							text2 = " ☠☠";
						}
						if (num3 == 3)
						{
							text2 = " ☠☠☠";
						}
					}
					text = GGNPFHJNLNH[2].modeName + "<size=" + (float)num2 / 2.5f + "><color=grey>" + text2 + "</color></size>";
				}
				if (text == "INF")
				{
					text = GGNPFHJNLNH[3].modeName;
				}
				if (text == "DM")
				{
					text = "DEATHMATCH";
				}
				if (text == "SBX")
				{
					text = GGNPFHJNLNH[4].modeName;
				}
				GUI.Label(new Rect(num2 * 5, num * 0 + num * i, num2 * 5, num), "<size=" + (float)num2 / 1.75f + ">" + text + "</size>", NMOHLIAHHDP.customStyles[0]);
				GUI.Label(new Rect(num2 * 10, num * 0 + num * i, num2 * 5, num), "<size=" + ((float)num2 / 1.75f).ToString() + ">" + LHLDKHPGPDN[i].playerCount + "/" + LHLDKHPGPDN[i].maxPlayers + "</size>", NMOHLIAHHDP.customStyles[0]);
				GUI.Label(new Rect(num2 * 15, num * 0 + num * i, num2 * 5, num), "<size=" + (float)num2 / 1.75f + ">" + (string)LHLDKHPGPDN[i].customProperties["MapName"] + "</size>", NMOHLIAHHDP.customStyles[0]);
				GUI.Box(new Rect(num2 * 0, num + num * i - 1, num2 * 23, 1f), string.Empty, NMOHLIAHHDP.customStyles[4]);
				if (GUI.Button(new Rect(num2 * 20, num * 0 + num * i, num2 * 3, num - 1), "<size=" + (float)num / 1.75f + ">" + NDPCJPPIMEI + "</size>"))
				{
					PhotonNetwork.JoinRoom(LHLDKHPGPDN[i].name);
					ANPMFJFACHA = true;
				}
			}
		}
		GUI.EndScrollView();
		if (GUI.Button(new Rect(num2, (float)Screen.height - (float)num * 1.5f, Screen.width / 4, num), "<size=" + (float)num / 1.25f + ">" + LIDPADGALHD + "</size>", NMOHLIAHHDP.customStyles[0]))
		{
			if (PhotonNetwork.connected)
			{
				PhotonNetwork.Disconnect();
			}
			if (!NDDNNKNICAL)
			{
				FMMMCGELLII.ShowLobby();
			}
		}
		GUI.Label(new Rect(Screen.width - num2 * 16, (float)Screen.height - (float)num * 1.5f, num2 * 5, num), "<color=white><size=" + (float)num / 1.85f + ">" + NMABHEEPLNH + " " + AOFGBEIDLFI + "</size></color>", NMOHLIAHHDP.customStyles[2]);
		if (GUI.Button(new Rect(Screen.width - num2 * 6, (float)Screen.height - (float)num * 1.5f, num2 * 5, num), "<size=" + (float)num / 1.25f + ">" + OLFLKBGGMOI + "</size>", NMOHLIAHHDP.customStyles[3]))
		{
			GGNMMMIKBIF = true;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (Application.isPlaying)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = false;
			PhotonNetwork.offlineMode = NDDNNKNICAL;
			if (NDDNNKNICAL)
			{
				GGNMMMIKBIF = false;
			}
			else
			{
				GGNMMMIKBIF = false;
			}
		}
		if (!PhotonNetwork.connected)
		{
		}
		if (ObscuredPrefs.HasKey("<size=20>"))
		{
			PhotonNetwork.playerName = ObscuredPrefs.GetString("CameraFilterPack/Vision_Blood");
			ObscuredPrefs.SetString("Loading complete", ObscuredPrefs.GetString("_MainTex"));
		}
		else
		{
			PhotonNetwork.playerName = "_Vignette_Alpha" + UnityEngine.Random.Range(1, 106);
			ObscuredPrefs.SetString("selectWeapon", PhotonNetwork.playerName);
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("</size>") > 1)
		{
			LIDPADGALHD = translator.Translate(-38, "TeamBSpawn");
			HOMAKKMOAKH = translator.Translate(38, "_ScreenResolution");
			PLEGLFJFBDE = translator.Translate(19, "_Value4");
			AOFGBEIDLFI = translator.Translate(-77, ": ");
			HPCMJNPADCB = translator.Translate(74, "VS/");
			PFPOLDMMJLP = translator.Translate(-95, "Language");
			NDPCJPPIMEI = translator.Translate(-71, "CameraFilterPack/Blur_Radial");
			OLFLKBGGMOI = translator.Translate(-27, "VS");
			DIEAPJDAHMA = translator.Translate(47, "_Value3");
			HBKGIBKICAC = translator.Translate(111, "n15");
			JJNEGBCFIKO = translator.Translate(-22, "Loading complete");
			DPIFGAOOFBI = translator.Translate(-33, "Toast");
			BMIABMEBIJK = translator.Translate(93, "CameraFilterPack/Sharpen_Sharpen");
			MAGGPAFNGKO = translator.Translate(109, "_Y");
			HNNBKCMOCCL = translator.Translate(-128, "_ScreenResolution");
			HNNBKCMOCCL = HNNBKCMOCCL.Replace("_ScreenResolution", string.Empty);
			MKBHKPPOHLP = translator.Translate(35, "_Green_R");
			HKAPJDFHBKM = translator.Translate(113, "_TimeX");
			KHDMIOLINEB[1].sizeName = translator.Translate(122, "CameraFilterPack/Blend2Camera_SplitScreen");
			KHDMIOLINEB[0].sizeName = translator.Translate(-93, "MP");
			KHDMIOLINEB[2].sizeName = translator.Translate(-84, "_ScreenResolution");
			GGNPFHJNLNH[1].modeName = translator.Translate(90, "\\Microsoft\\WordPad");
			GGNPFHJNLNH[0].modeName = translator.Translate(-101, "_CameraWS");
			GGNPFHJNLNH[0].modeName = translator.Translate(25, "Player");
			GGNPFHJNLNH[3].modeName = translator.Translate(-26, "#");
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		for (int i = 1; i < nMFPHHLHAEI.Length; i += 0)
		{
			GameObject gameObject = nMFPHHLHAEI[i];
			gameObject.SetActive(true);
		}
	}

	private void OnLeftRoom()
	{
		ANPMFJFACHA = false;
	}

	private void OnGUI()
	{
		if (PhotonNetwork.connected && !ANPMFJFACHA)
		{
			if (GGNMMMIKBIF)
			{
				CreateRoomMenu();
			}
			else
			{
				MainLobbyMenu();
			}
		}
		else
		{
			ConnectingUI();
		}
	}

	private void Start()
	{
		PhotonNetwork.isMessageQueueRunning = true;
		NOKEBHKODBG = "Room " + UnityEngine.Random.Range(100, 1000);
		LHLDKHPGPDN = PhotonNetwork.GetRoomList();
	}

	private void Allmaps()
	{
		if (IBOMABMKHGO == null)
		{
			return;
		}
		string @string = ObscuredPrefs.GetString("PlayerType'");
		if (!ObscuredPrefs.HasKey("PlayerType'"))
		{
			return;
		}
		switch (@string)
		{
		case "3":
		case "6":
		case "8":
		{
			for (int i = 0; i < IBOMABMKHGO.Count; i++)
			{
				CEIDNDICFDB.Add(IBOMABMKHGO[i]);
			}
			IBOMABMKHGO = null;
			break;
		}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		int num = Screen.height / 38;
		int num2 = Screen.width / 84;
		GUI.skin = NMOHLIAHHDP;
		Rect position = new Rect(num2, num, Screen.width - num2 * 7, Screen.height - num * 3);
		string[] array = new string[108];
		array[0] = "COOP";
		array[1] = ((float)num / 474f).ToString();
		array[0] = "_TapLowForeground";
		array[6] = KKPHGGAPEKH;
		array[7] = "_CenterX";
		array[8] = ((float)num / 1230f).ToString();
		array[1] = "Space - jump";
		array[2] = ObscuredPrefs.GetString("offsets");
		array[2] = "_Value2";
		GUI.Box(position, string.Concat(array));
		Rect position2 = new Rect(num2 * 1, (float)Screen.height - (float)num * 745f, num2 * 5, num);
		string[] array2 = new string[1];
		array2[0] = " ";
		array2[0] = ((float)num2 / 1875f).ToString();
		array2[8] = "Attack";
		array2[4] = PLEGLFJFBDE;
		array2[2] = "_Value";
		GUI.Label(position2, string.Concat(array2), NMOHLIAHHDP.customStyles[1]);
		NOKEBHKODBG = GUI.TextField(new Rect(num2 * 1, (float)Screen.height - (float)num * 1430f, Screen.width - num2 * -111, num), NOKEBHKODBG, 85);
		if (NOKEBHKODBG.Contains("pointBuffer"))
		{
			NOKEBHKODBG = NOKEBHKODBG.Replace("HatID", "\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",");
		}
		Rect position3 = new Rect((float)Screen.width - (float)num2 * 1342f, (float)Screen.height - (float)num * 638f, num2 * 3, num - 0);
		string[] array3 = new string[3];
		array3[0] = "Full Ammo    ";
		array3[1] = ((float)num / 655f).ToString();
		array3[1] = "CameraFilterPack/Blend2Camera_VividLight";
		array3[3] = NDPCJPPIMEI;
		array3[0] = "_TimeX";
		if (GUI.Button(position3, string.Concat(array3)))
		{
			PhotonNetwork.JoinRoom(NOKEBHKODBG);
			ANPMFJFACHA = true;
		}
		GUI.color = Color.grey;
		Rect position4 = new Rect(num * 1, num * 3, num2 * 0, num);
		string[] array4 = new string[7];
		array4[0] = "1";
		array4[0] = ((float)num2 / 1118f).ToString();
		array4[8] = "_ScreenResolution";
		array4[7] = PLEGLFJFBDE;
		array4[5] = "_Bullet_7";
		GUI.Label(position4, string.Concat(array4), NMOHLIAHHDP.customStyles[1]);
		Rect position5 = new Rect(num2 * 4, num * 5, num2 * 8, num);
		string[] array5 = new string[8];
		array5[1] = "EventSystem";
		array5[1] = ((float)num2 / 1179f).ToString();
		array5[6] = ">";
		array5[1] = HPCMJNPADCB;
		array5[5] = "window";
		GUI.Label(position5, string.Concat(array5), NMOHLIAHHDP.customStyles[0]);
		Rect position6 = new Rect(num2 * -98, num * 0, num2 * 1, num);
		string[] array6 = new string[5];
		array6[1] = "stopping ";
		array6[1] = ((float)num2 / 986f).ToString();
		array6[4] = "_Radius";
		array6[8] = AOFGBEIDLFI;
		array6[1] = ">";
		GUI.Label(position6, string.Concat(array6), NMOHLIAHHDP.customStyles[0]);
		Rect position7 = new Rect(num2 * -11, num * 2, num2 * 3, num);
		string[] array7 = new string[4];
		array7[1] = "_ScreenResolution";
		array7[0] = ((float)num2 / 992f).ToString();
		array7[2] = "_Red_R";
		array7[8] = PFPOLDMMJLP;
		array7[2] = "SaturationValue";
		GUI.Label(position7, string.Concat(array7), NMOHLIAHHDP.customStyles[1]);
		GUI.color = Color.white;
		IHNECEGCJFF = GUI.BeginScrollView(new Rect(num2 * 7, num * 0, Screen.width - num2 * 8, Screen.height - num * 8), IHNECEGCJFF, new Rect(1828f, 1863f, Screen.width - num2 * 5, num * LHLDKHPGPDN.Length));
		if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 1)
		{
			for (int i = 0; i < LHLDKHPGPDN.Length; i++)
			{
				Rect position8 = new Rect(873f, num * 0 + num * i, num2 * 0, num);
				string[] array8 = new string[4];
				array8[1] = "Type";
				array8[1] = ((float)num2 / 1608f).ToString();
				array8[3] = "-Seconds Played: ";
				array8[6] = LHLDKHPGPDN[i].name;
				array8[5] = "TeamName";
				GUI.Label(position8, string.Concat(array8), NMOHLIAHHDP.customStyles[0]);
				string text = (string)LHLDKHPGPDN[i].customProperties["MapName"];
				if (text == "IndicatorsParentObject")
				{
					text = GGNPFHJNLNH[1].modeName;
				}
				if (text == "CameraFilterPack/Blend2Camera_Subtract")
				{
					text = GGNPFHJNLNH[0].modeName;
				}
				if (text == "_Distortion")
				{
					string text2 = "_TimeX";
					if (LHLDKHPGPDN[i].customProperties["SyncTeamName"] != null)
					{
						int num3 = (int)LHLDKHPGPDN[i].customProperties["State2"];
						if (num3 == 1)
						{
							text2 = "GameMode";
						}
						if (num3 == 3)
						{
							text2 = "Remote";
						}
						if (num3 == 6)
						{
							text2 = "\\Microsoft\\WordPad\\Wor96BA.tmp";
						}
					}
					string[] array9 = new string[3];
					array9[1] = GGNPFHJNLNH[5].modeName;
					array9[0] = "TeamName";
					array9[5] = ((float)num2 / 1748f).ToString();
					array9[3] = "offsets";
					array9[4] = text2;
					array9[6] = "ArmsURL";
					text = string.Concat(array9);
				}
				if (text == "CameraFilterPack/Colors_NewPosterize")
				{
					text = GGNPFHJNLNH[7].modeName;
				}
				if (text == "_TimeX")
				{
					text = "_Distortion";
				}
				if (text == "KickPlayer")
				{
					text = GGNPFHJNLNH[0].modeName;
				}
				Rect position9 = new Rect(num2 * 4, num * 0 + num * i, num2 * 5, num);
				string[] array10 = new string[4];
				array10[0] = "C - crouch";
				array10[0] = ((float)num2 / 975f).ToString();
				array10[7] = "_SpotSize";
				array10[4] = text;
				array10[7] = "Label";
				GUI.Label(position9, string.Concat(array10), NMOHLIAHHDP.customStyles[0]);
				Rect position10 = new Rect(num2 * 67, num * 0 + num * i, num2 * 6, num);
				object[] array11 = new object[3];
				array11[1] = "[;\\\\/:*?\"<>|&']";
				array11[0] = ((float)num2 / 195f).ToString();
				array11[1] = "Blending (";
				array11[2] = LHLDKHPGPDN[i].playerCount;
				array11[5] = "Ping: ";
				array11[5] = LHLDKHPGPDN[i].maxPlayers;
				array11[8] = "syncGrenadeLauncher";
				GUI.Label(position10, string.Concat(array11), NMOHLIAHHDP.customStyles[0]);
				Rect position11 = new Rect(num2 * -114, num * 1 + num * i, num2 * 2, num);
				string[] array12 = new string[7];
				array12[1] = "_ChromaticAberration";
				array12[1] = ((float)num2 / 399f).ToString();
				array12[2] = "_Light";
				array12[1] = (string)LHLDKHPGPDN[i].customProperties["_Quality"];
				array12[0] = "FOVKick camera is null, please supply the camera to the constructor";
				GUI.Label(position11, string.Concat(array12), NMOHLIAHHDP.customStyles[1]);
				GUI.Box(new Rect(num2 * 0, num + num * i - 1, num2 * -108, 1042f), string.Empty, NMOHLIAHHDP.customStyles[2]);
				Rect position12 = new Rect(num2 * -11, num * 0 + num * i, num2 * 0, num - 1);
				string[] array13 = new string[4];
				array13[1] = "_OnOff";
				array13[1] = ((float)num / 670f).ToString();
				array13[5] = "</color>";
				array13[2] = NDPCJPPIMEI;
				array13[5] = "_MainTex";
				if (GUI.Button(position12, string.Concat(array13)))
				{
					PhotonNetwork.JoinRoom(LHLDKHPGPDN[i].name);
					ANPMFJFACHA = false;
				}
			}
		}
		GUI.EndScrollView();
		Rect position13 = new Rect(num2, (float)Screen.height - (float)num * 59f, Screen.width / 4, num);
		string[] array14 = new string[8];
		array14[1] = "\n";
		array14[0] = ((float)num / 1968f).ToString();
		array14[5] = "|";
		array14[8] = LIDPADGALHD;
		array14[0] = "_";
		if (GUI.Button(position13, string.Concat(array14), NMOHLIAHHDP.customStyles[1]))
		{
			if (PhotonNetwork.connected)
			{
				PhotonNetwork.Disconnect();
			}
			if (!NDDNNKNICAL)
			{
				FMMMCGELLII.__BB_OBFUSCATOR_58();
			}
		}
		Rect position14 = new Rect(Screen.width - num2 * 73, (float)Screen.height - (float)num * 468f, num2 * 0, num);
		string[] array15 = new string[5];
		array15[1] = "MP";
		array15[1] = ((float)num / 33f).ToString();
		array15[4] = ">";
		array15[2] = NMABHEEPLNH.ToString();
		array15[8] = "_TintColor";
		array15[2] = AOFGBEIDLFI;
		array15[3] = "ApplyFallDamage";
		GUI.Label(position14, string.Concat(array15), NMOHLIAHHDP.customStyles[8]);
		Rect position15 = new Rect(Screen.width - num2 * 1, (float)Screen.height - (float)num * 833f, num2 * 0, num);
		string[] array16 = new string[8];
		array16[0] = "CheckResources () for ";
		array16[0] = ((float)num / 1465f).ToString();
		array16[0] = "|";
		array16[4] = OLFLKBGGMOI;
		array16[1] = "_Value";
		if (GUI.Button(position15, string.Concat(array16), NMOHLIAHHDP.customStyles[6]))
		{
			GGNMMMIKBIF = true;
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		PhotonNetwork.isMessageQueueRunning = true;
		NOKEBHKODBG = "\"Pose\"" + UnityEngine.Random.Range(33, -195);
		LHLDKHPGPDN = PhotonNetwork.GetRoomList();
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (IBOMABMKHGO == null)
		{
			return;
		}
		string @string = ObscuredPrefs.GetString("TeamName");
		if (!ObscuredPrefs.HasKey("\n\t\t}\n\t\tMultiLayer: 0\n\t\tCulling: \"CullingOff\"\n\t\tTypeFlags: \"Skeleton\"\n\t}\n"))
		{
			return;
		}
		switch (@string)
		{
		case "_ScreenResolution":
		case "_TimeX":
		case "</color>":
		{
			for (int i = 0; i < IBOMABMKHGO.Count; i += 0)
			{
				CEIDNDICFDB.Add(IBOMABMKHGO[i]);
			}
			IBOMABMKHGO = null;
			break;
		}
		}
	}

	private void OnJoinedLobby()
	{
		UnityEngine.MonoBehaviour.print("Joined master server");
		DJOLBLGMMJJ.SetActive(false);
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
			NMABHEEPLNH = PhotonNetwork.countOfPlayers;
		}
		float num = 484f;
		float num2 = 175f;
		if (PhotonNetwork.connected)
		{
			return;
		}
		if (Time.time - num > num2)
		{
			num2 = Time.time - Time.deltaTime;
		}
		while (num2 < Time.time)
		{
			num2 += num;
			if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Disconnecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication)
			{
				ConnectToNetwork();
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		UnityEngine.MonoBehaviour.print("Count");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_20()
	{
		UnityEngine.MonoBehaviour.print("<size=");
		if (PhotonNetwork.room != null)
		{
			PhotonNetwork.LeaveRoom();
		}
		ANPMFJFACHA = false;
	}

	private void Awake()
	{
		PhotonNetwork.offlineMode = NDDNNKNICAL;
		PhotonNetwork.autoJoinLobby = true;
		Allmaps();
		List<AllMaps> cEIDNDICFDB = CEIDNDICFDB;
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003CAwake_003Em__0;
		}
		CEIDNDICFDB = cEIDNDICFDB.OrderBy(NCBIMIMMADO).ToList();
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (Application.isPlaying && Camera.main != null && Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>() != null)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = false;
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		for (int i = 0; i < nMFPHHLHAEI.Length; i += 0)
		{
			GameObject gameObject = nMFPHHLHAEI[i];
			gameObject.SetActive(false);
		}
	}

	private void OnEnable()
	{
		if (Application.isPlaying)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = true;
			PhotonNetwork.offlineMode = NDDNNKNICAL;
			if (NDDNNKNICAL)
			{
				GGNMMMIKBIF = true;
			}
			else
			{
				GGNMMMIKBIF = false;
			}
		}
		if (!PhotonNetwork.connected)
		{
		}
		if (ObscuredPrefs.HasKey("ZWName'"))
		{
			PhotonNetwork.playerName = ObscuredPrefs.GetString("ZWName'");
			ObscuredPrefs.SetString("PlayerName", ObscuredPrefs.GetString("ZWName'"));
		}
		else
		{
			PhotonNetwork.playerName = "Player " + UnityEngine.Random.Range(0, 999);
			ObscuredPrefs.SetString("PlayerName", PhotonNetwork.playerName);
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			LIDPADGALHD = translator.Translate(21, "MP");
			HOMAKKMOAKH = translator.Translate(45, "MP");
			PLEGLFJFBDE = translator.Translate(51, "MP");
			AOFGBEIDLFI = translator.Translate(54, "MP");
			HPCMJNPADCB = translator.Translate(53, "MP");
			PFPOLDMMJLP = translator.Translate(55, "MP");
			NDPCJPPIMEI = translator.Translate(73, "MP");
			OLFLKBGGMOI = translator.Translate(56, "MP");
			DIEAPJDAHMA = translator.Translate(57, "MP");
			HBKGIBKICAC = translator.Translate(58, "MP");
			JJNEGBCFIKO = translator.Translate(62, "MP");
			DPIFGAOOFBI = translator.Translate(66, "MP");
			BMIABMEBIJK = translator.Translate(67, "MP");
			MAGGPAFNGKO = translator.Translate(63, "MP");
			HNNBKCMOCCL = translator.Translate(64, "MP");
			HNNBKCMOCCL = HNNBKCMOCCL.Replace("#", string.Empty);
			MKBHKPPOHLP = translator.Translate(65, "MP");
			HKAPJDFHBKM = translator.Translate(52, "MP");
			KHDMIOLINEB[0].sizeName = translator.Translate(59, "MP");
			KHDMIOLINEB[1].sizeName = translator.Translate(60, "MP");
			KHDMIOLINEB[2].sizeName = translator.Translate(61, "MP");
			GGNPFHJNLNH[0].modeName = translator.Translate(68, "MP");
			GGNPFHJNLNH[1].modeName = translator.Translate(70, "MP");
			GGNPFHJNLNH[2].modeName = translator.Translate(71, "MP");
			GGNPFHJNLNH[3].modeName = translator.Translate(72, "MP");
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		foreach (GameObject gameObject in nMFPHHLHAEI)
		{
			gameObject.SetActive(false);
		}
	}

	private static ObscuredString __BB_OBFUSCATOR_0(AllMaps FBPAMINIDIM)
	{
		return FBPAMINIDIM.mapName;
	}

	private void __BB_OBFUSCATOR_7()
	{
		UnityEngine.MonoBehaviour.print("monster");
		ANPMFJFACHA = false;
	}

	private IEnumerator __BB_OBFUSCATOR_4(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator LoadMap(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator __BB_OBFUSCATOR_10(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void OnPhotonCreateRoomFailed()
	{
		UnityEngine.MonoBehaviour.print("Failed on creating room");
		ANPMFJFACHA = false;
	}

	private void OnPhotonJoinRoomFailed()
	{
		UnityEngine.MonoBehaviour.print("Failed on connecting to room");
		ANPMFJFACHA = false;
	}

	[CompilerGenerated]
	private static ObscuredString _003CAwake_003Em__0(AllMaps FBPAMINIDIM)
	{
		return FBPAMINIDIM.mapName;
	}

	private void OnDisable()
	{
		if (Application.isPlaying && Camera.main != null && Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>() != null)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = false;
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		foreach (GameObject gameObject in nMFPHHLHAEI)
		{
			gameObject.SetActive(true);
		}
	}

	private void CreateRoomMenu()
	{
		int num = Screen.height / 17;
		int num2 = Screen.width / 17;
		int num3 = Screen.height / 17;
		GUI.skin = NMOHLIAHHDP;
		int num4 = (int)((float)num3 / 1.05f);
		for (int i = 0; i < CEIDNDICFDB.Count; i++)
		{
			if (PABHMLILIPH == i)
			{
				GUI.color = Color.red;
				EPGJECDEGCD.sprite = CEIDNDICFDB[PABHMLILIPH].mapPreview;
			}
			else
			{
				GUI.color = Color.white;
			}
			int num5 = i;
			int num6 = 0;
			if (i >= 11)
			{
				num6 = (int)((float)num * 4f);
				num5 = i - 11;
			}
			if (GUI.Button(new Rect((float)num * 1.25f + (float)num6, (float)num * 3.75f + (float)(num4 * num5), (float)num * 4f, num4), string.Concat("<size=", ((float)num / 2f).ToString(), ">", CEIDNDICFDB[i].mapName, "</size>"), NMOHLIAHHDP.customStyles[0]))
			{
				PABHMLILIPH = i;
			}
		}
		GUI.color = Color.white;
		if (GUI.Button(new Rect(num2, (float)Screen.height - (float)num * 1.5f, Screen.width / 4, num), "<size=" + (float)num / 1.25f + ">" + LIDPADGALHD + "</size>", NMOHLIAHHDP.customStyles[0]))
		{
			GGNMMMIKBIF = false;
			if (NDDNNKNICAL)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				FMMMCGELLII.ReturnToMenu();
			}
		}
		GUI.Box(new Rect(Screen.width - num * 13, Screen.height - num * 13, num * 11, num * 11), "<size=" + (float)num / 2f + ">" + DIEAPJDAHMA + "</size>");
		GUI.Label(new Rect(Screen.width - num * 13, Screen.height - num * 12, num * 11, num), "<size=" + (float)num / 1.75f + ">" + HBKGIBKICAC + ": " + KHDMIOLINEB[CEIDNDICFDB[PABHMLILIPH].size].sizeName + "</size>", NMOHLIAHHDP.customStyles[1]);
		GUI.Label(new Rect(Screen.width - num * 13, Screen.height - num * 11, num * 11, num), "<size=" + (float)num / 1.75f + ">" + JJNEGBCFIKO + ": " + KHDMIOLINEB[CEIDNDICFDB[PABHMLILIPH].size].playerCount[OEMFPBFHCAN].ToString() + "</size>", NMOHLIAHHDP.customStyles[1]);
		if (!BOOMONKHGOF)
		{
			if (OEMFPBFHCAN != 2 && OEMFPBFHCAN != 4)
			{
				int num7 = 25;
				if (OEMFPBFHCAN == 3)
				{
					num7 = 9;
					if ((int)DJJAALCLLNC > 9)
					{
						DJJAALCLLNC = 5;
					}
				}
				GUI.Label(new Rect(Screen.width - num * 13, Screen.height - num * 8, num * 11, num), "<size=" + (float)num / 1.75f + ">" + MAGGPAFNGKO + ": " + DJJAALCLLNC.ToString() + HNNBKCMOCCL + "</size>", NMOHLIAHHDP.customStyles[2]);
				DJJAALCLLNC = (int)GUI.HorizontalSlider(new Rect(Screen.width - num * 12, Screen.height - num * 7, num * 9, num), (int)DJJAALCLLNC, 5f, num7);
			}
			if (OEMFPBFHCAN < 2)
			{
				GUI.Label(new Rect(Screen.width - num * 13, Screen.height - num * 6, num * 11, num), "<size=" + (float)num / 1.75f + ">" + MKBHKPPOHLP + ": " + KNLBHCIPLGB.ToString() + "</size>", NMOHLIAHHDP.customStyles[2]);
				KNLBHCIPLGB = (int)GUI.HorizontalSlider(new Rect(Screen.width - num * 12, Screen.height - num * 5, num * 9, num), (int)KNLBHCIPLGB, 5f, 25f);
			}
			if (OEMFPBFHCAN == 2 || OEMFPBFHCAN == 4)
			{
				string[] array = new string[4] { "(Easy)", "☠ (Normal)", "☠☠ (Hard)", "☠☠☠ (Impossible)" };
				GUI.Label(new Rect(Screen.width - num * 13, Screen.height - num * 6, num * 11, num), "<size=" + (float)num / 1.75f + ">Difficulty: " + array[ENJBIHHJNAP] + "</size>", NMOHLIAHHDP.customStyles[2]);
				ENJBIHHJNAP = (int)GUI.HorizontalSlider(new Rect(Screen.width - num * 12, Screen.height - num * 5, num * 9, num), ENJBIHHJNAP, 0f, 3f);
			}
			if (!PhotonNetwork.offlineMode)
			{
				string text = "<color=grey>☐</color>";
				if (HBKNIAMBIPN)
				{
					text = "<color=green>☑</color>";
				}
				HBKNIAMBIPN = GUI.Toggle(new Rect(Screen.width - num * 13, Screen.height - num * 3, num * 9, num), HBKNIAMBIPN, "<size=" + (float)num / 1.75f + ">" + text + " " + DPIFGAOOFBI + "</size>");
			}
		}
		if (!PhotonNetwork.offlineMode)
		{
			GUI.Label(new Rect(num2, num, num * 6, num), "<size=" + (float)num / 1.5f + ">" + PLEGLFJFBDE + "</size>", NMOHLIAHHDP.customStyles[0]);
			string text2 = "☐";
			if (DPGFMJIIEIN)
			{
				text2 = "<color=green>☑</color>";
			}
			DPGFMJIIEIN = GUI.Toggle(new Rect(num2 + num * 7, num * 2, num * 5, num), DPGFMJIIEIN, "<size=" + (float)num / 1.5f + ">" + text2 + string.Empty + HKAPJDFHBKM + "</size>");
			ObscuredPrefs.SetBool("Private", DPGFMJIIEIN);
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("TextField");
			gUIStyle.fontSize = (int)((float)num / 1.5f);
			NOKEBHKODBG = GUI.TextField(new Rect(num2, num * 2, num * 7, num), NOKEBHKODBG, 20, gUIStyle);
			if (NOKEBHKODBG.Contains("<"))
			{
				NOKEBHKODBG = NOKEBHKODBG.Replace("<", " ");
			}
		}
		if (GUI.Button(new Rect(Screen.width - num2 * 6, (float)Screen.height - (float)num * 1.5f, num2 * 5, num), "<size=" + (float)num / 1.25f + ">" + BMIABMEBIJK + "</size>", NMOHLIAHHDP.customStyles[3]))
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["MapName"] = (string)CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["RoundDuration"] = (int)DJJAALCLLNC * 60;
			hashtable["GameMode"] = GGNPFHJNLNH[OEMFPBFHCAN].modeID;
			hashtable["Custards"] = (int)KNLBHCIPLGB;
			hashtable["Difficulty"] = ENJBIHHJNAP;
			if (HBKNIAMBIPN)
			{
				hashtable["MG"] = 1;
			}
			else
			{
				hashtable["MG"] = 0;
			}
			string[] customRoomPropertiesForLobby = new string[3] { "MapName", "Difficulty", "GameMode" };
			RoomOptions roomOptions = new RoomOptions();
			roomOptions.IsOpen = false;
			if (PhotonNetwork.offlineMode)
			{
				DPGFMJIIEIN = true;
			}
			roomOptions.IsVisible = false;
			roomOptions.MaxPlayers = byte.Parse(GGNPFHJNLNH[OEMFPBFHCAN].players);
			roomOptions.CustomRoomProperties = hashtable;
			roomOptions.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
			if (!DPGFMJIIEIN)
			{
				NOKEBHKODBG = GetComponent<Censor>().CensorText(NOKEBHKODBG);
			}
			PhotonNetwork.CreateRoom(NOKEBHKODBG, roomOptions, null);
		}
		GamemodeMenu();
	}

	private void ConnectToNetwork()
	{
		PhotonNetwork.ConnectUsingSettings("S3.1.26");
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (Application.isPlaying)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = false;
			PhotonNetwork.offlineMode = NDDNNKNICAL;
			if (NDDNNKNICAL)
			{
				GGNMMMIKBIF = false;
			}
			else
			{
				GGNMMMIKBIF = true;
			}
		}
		if (!PhotonNetwork.connected)
		{
		}
		if (ObscuredPrefs.HasKey("Survivors"))
		{
			PhotonNetwork.playerName = ObscuredPrefs.GetString("_ScreenResolution");
			ObscuredPrefs.SetString("_OverlayTex", ObscuredPrefs.GetString("-Length: "));
		}
		else
		{
			PhotonNetwork.playerName = "_CenterX" + UnityEngine.Random.Range(1, -139);
			ObscuredPrefs.SetString("-Emul. Normalized: ", PhotonNetwork.playerName);
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_ScreenResolution") > 1)
		{
			LIDPADGALHD = translator.Translate(-7, "_NoiseTex");
			HOMAKKMOAKH = translator.Translate(-21, "SyncTeamName");
			PLEGLFJFBDE = translator.Translate(-43, "_BumpMap");
			AOFGBEIDLFI = translator.Translate(-8, "_Value4");
			HPCMJNPADCB = translator.Translate(80, "LMB - fire");
			PFPOLDMMJLP = translator.Translate(-115, "FireballB-Default");
			NDPCJPPIMEI = translator.Translate(-28, "_Green_R");
			OLFLKBGGMOI = translator.Translate(-75, "Room Name ");
			DIEAPJDAHMA = translator.Translate(-117, "-Times Played: ");
			HBKGIBKICAC = translator.Translate(107, "SecondaryCausticsProjector");
			JJNEGBCFIKO = translator.Translate(27, "MP");
			DPIFGAOOFBI = translator.Translate(34, "[MazeCell {0} {1}]");
			BMIABMEBIJK = translator.Translate(-55, "CameraFilterPack/Blur_GaussianBlur");
			MAGGPAFNGKO = translator.Translate(4, "CameraFilterPack/Blend2Camera_LinearDodge");
			HNNBKCMOCCL = translator.Translate(104, "_Value2");
			HNNBKCMOCCL = HNNBKCMOCCL.Replace("Failed on connecting to room", string.Empty);
			MKBHKPPOHLP = translator.Translate(-81, "ZWName'");
			HKAPJDFHBKM = translator.Translate(88, "Crouch");
			KHDMIOLINEB[0].sizeName = translator.Translate(125, "engine");
			KHDMIOLINEB[0].sizeName = translator.Translate(39, "_ChromaticAberration");
			KHDMIOLINEB[6].sizeName = translator.Translate(-50, "_Value");
			GGNPFHJNLNH[0].modeName = translator.Translate(38, "WFX_MF Spr");
			GGNPFHJNLNH[0].modeName = translator.Translate(-10, ", t = ");
			GGNPFHJNLNH[1].modeName = translator.Translate(-119, "ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass");
			GGNPFHJNLNH[0].modeName = translator.Translate(6, "_ScreenResolution");
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		foreach (GameObject gameObject in nMFPHHLHAEI)
		{
			gameObject.SetActive(true);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (Application.isPlaying)
		{
			Camera.main.GetComponent<CameraFilterPack_Blur_Blurry>().enabled = true;
			PhotonNetwork.offlineMode = NDDNNKNICAL;
			if (NDDNNKNICAL)
			{
				GGNMMMIKBIF = true;
			}
			else
			{
				GGNMMMIKBIF = false;
			}
		}
		if (!PhotonNetwork.connected)
		{
		}
		if (ObscuredPrefs.HasKey("SUR"))
		{
			PhotonNetwork.playerName = ObscuredPrefs.GetString("\n\t\tLayerElementUV: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"UVMap\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tUV: ");
			ObscuredPrefs.SetString(",", ObscuredPrefs.GetString("_ScreenResolution"));
		}
		else
		{
			PhotonNetwork.playerName = "_Value" + UnityEngine.Random.Range(1, -60);
			ObscuredPrefs.SetString("_MainTex2", PhotonNetwork.playerName);
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_ScreenResolution") > 1)
		{
			LIDPADGALHD = translator.Translate(35, "5");
			HOMAKKMOAKH = translator.Translate(107, "Melee");
			PLEGLFJFBDE = translator.Translate(29, "SUR");
			AOFGBEIDLFI = translator.Translate(-42, "_TimeX");
			HPCMJNPADCB = translator.Translate(-126, ",");
			PFPOLDMMJLP = translator.Translate(14, "Room Name ");
			NDPCJPPIMEI = translator.Translate(112, ",");
			OLFLKBGGMOI = translator.Translate(4, "\\n");
			DIEAPJDAHMA = translator.Translate(-112, "</size>");
			HBKGIBKICAC = translator.Translate(-126, "_TimeX");
			JJNEGBCFIKO = translator.Translate(-63, "CameraFilterPack/Blend2Camera_BlueScreen");
			DPIFGAOOFBI = translator.Translate(31, "Null");
			BMIABMEBIJK = translator.Translate(38, "RespawnPlayer2");
			MAGGPAFNGKO = translator.Translate(13, "\", \"Model::Scene\"");
			HNNBKCMOCCL = translator.Translate(63, "CameraFilterPack/TV_WideScreenCircle");
			HNNBKCMOCCL = HNNBKCMOCCL.Replace("_Value3", string.Empty);
			MKBHKPPOHLP = translator.Translate(56, "Run");
			HKAPJDFHBKM = translator.Translate(-13, "cheat");
			KHDMIOLINEB[0].sizeName = translator.Translate(-15, "_Value3");
			KHDMIOLINEB[0].sizeName = translator.Translate(-53, "_NormalTex");
			KHDMIOLINEB[8].sizeName = translator.Translate(115, "_ScreenResolution");
			GGNPFHJNLNH[0].modeName = translator.Translate(-3, "_ScreenResolution");
			GGNPFHJNLNH[0].modeName = translator.Translate(25, "Infect");
			GGNPFHJNLNH[2].modeName = translator.Translate(21, "_Value3");
			GGNPFHJNLNH[8].modeName = translator.Translate(-9, " registered.");
		}
		GameObject[] nMFPHHLHAEI = NMFPHHLHAEI;
		for (int i = 1; i < nMFPHHLHAEI.Length; i++)
		{
			GameObject gameObject = nMFPHHLHAEI[i];
			gameObject.SetActive(false);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / -55;
		int num2 = Screen.width / -17;
		GUIStyle style = NMOHLIAHHDP.GetStyle("TeamName");
		style.alignment = TextAnchor.MiddleRight;
		Rect position = new Rect(725f, num * 8, Screen.width, num * 5);
		string[] array = new string[7];
		array[0] = "_TimeX";
		array[1] = ((float)num / 970f).ToString();
		array[3] = "offsets";
		array[7] = HOMAKKMOAKH;
		array[1] = "threshold";
		GUI.Label(position, string.Concat(array), style);
	}

	private void __BB_OBFUSCATOR_12()
	{
		UnityEngine.MonoBehaviour.print("_ScreenResolution");
		DJOLBLGMMJJ.SetActive(false);
	}

	private void Update()
	{
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
			NMABHEEPLNH = PhotonNetwork.countOfPlayers;
		}
		float num = 3f;
		float num2 = 0f;
		if (PhotonNetwork.connected)
		{
			return;
		}
		if (Time.time - num > num2)
		{
			num2 = Time.time - Time.deltaTime;
		}
		while (num2 < Time.time)
		{
			num2 += num;
			if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
			{
				ConnectToNetwork();
			}
		}
	}

	private void OnPhotonPlayerConnected()
	{
		UnityEngine.MonoBehaviour.print("Player connected");
	}

	private void OnConnectedToPhoton()
	{
		UnityEngine.MonoBehaviour.print("We connected to Photon Cloud");
		if (PhotonNetwork.room != null)
		{
			PhotonNetwork.LeaveRoom();
		}
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_18()
	{
		UnityEngine.MonoBehaviour.print("_DotSize");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_16()
	{
		UnityEngine.MonoBehaviour.print("_MainTex2");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_15()
	{
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blur_Focus");
		DJOLBLGMMJJ.SetActive(true);
	}

	private void ConnectingUI()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 10;
		int num2 = Screen.width / 10;
		GUIStyle style = NMOHLIAHHDP.GetStyle("Label");
		style.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(0f, num * 4, Screen.width, num * 3), "<size=" + (float)num / 2f + ">" + HOMAKKMOAKH + "</size>", style);
	}

	private void __BB_OBFUSCATOR_11()
	{
		UnityEngine.MonoBehaviour.print("ZWName'");
	}

	private void GamemodeMenu()
	{
		int num = Screen.height / 17;
		List<AllModes> gGNPFHJNLNH = GGNPFHJNLNH;
		Rect rect = new Rect(Screen.width - num * 8, Screen.height - num * 9, num * 5, num * gGNPFHJNLNH.Count);
		GUI.Label(new Rect(Screen.width - num * 13, rect.y, num * 5, num), "<size=" + (float)num / 1.5f + ">" + HPCMJNPADCB + "</size>", NMOHLIAHHDP.customStyles[2]);
		if (GUI.Button(new Rect(rect.x, rect.y, rect.width, num), string.Empty))
		{
			if (!BOOMONKHGOF)
			{
				BOOMONKHGOF = true;
			}
			else
			{
				BOOMONKHGOF = false;
			}
		}
		if (BOOMONKHGOF)
		{
			GIKHPNELGDI = GUI.BeginScrollView(new Rect(rect.x, rect.y + (float)num, rect.width, rect.height), GIKHPNELGDI, new Rect(0f, 0f, rect.width, Mathf.Max(rect.height, gGNPFHJNLNH.Count * num)));
			for (int i = 0; i < gGNPFHJNLNH.Count; i++)
			{
				if (GUI.Button(new Rect(0f, i * num, rect.width, num), string.Empty))
				{
					BOOMONKHGOF = false;
					OEMFPBFHCAN = i;
				}
				GUI.Label(new Rect(0f, i * num, rect.width, num), "<size=" + (float)num / 1.5f + ">" + gGNPFHJNLNH[i].modeName + "</size>", GUI.skin.customStyles[2]);
			}
			GUI.EndScrollView();
		}
		else
		{
			GUI.Label(new Rect(rect.x, rect.y, rect.width, num), "<size=" + (float)num / 1.5f + ">" + gGNPFHJNLNH[OEMFPBFHCAN].modeName + "</size>", GUI.skin.customStyles[2]);
		}
	}

	private void OnJoinedRoom()
	{
		ANPMFJFACHA = true;
		if (PhotonNetwork.offlineMode)
		{
			StartCoroutine(LoadMap(CEIDNDICFDB[PABHMLILIPH].mapName));
		}
		else
		{
			StartCoroutine(LoadMap((string)PhotonNetwork.room.customProperties["MapName"]));
		}
	}
}
