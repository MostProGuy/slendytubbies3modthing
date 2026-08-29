using System;
using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

public class ConnectMenu : Photon.MonoBehaviour
{
	[Serializable]
	public class AllMaps
	{
		public string mapName;

		public Texture2D mapPreview;
	}

	public GUISkin KIMBOADOOCP;

	public Texture KEMCOJPJLBH;

	public Texture KNAJLMJOOIL;

	public Texture GBGNIKDNEFL;

	public int NLJGDMJDPOI = 600;

	public bool NDDNNKNICAL;

	private List<int> LMBIPAGNEAE = new List<int>();

	public List<AllMaps> CEIDNDICFDB;

	private string KKFCFHDFJGH;

	private string DLHMCKDJIHG;

	private int OCAFLKCDPNI;

	private int PABHMLILIPH;

	private string MCMCKJIGBJN;

	private Vector2 FLHOPCJDOOP;

	private Vector2 DLBFBOBDKHD;

	private float ECKCMCNLLAE;

	private int OIECJHKOMMB;

	private RoomInfo[] LHLDKHPGPDN;

	private bool MHFIANECAMO;

	private bool ANPMFJFACHA;

	private float OLGFEPOIBEK = 1600f;

	private float AMDAOFLHLGM = 1000f;

	private Vector3 GKKILAKNPAB = Vector3.zero;

	private void __BB_OBFUSCATOR_64()
	{
		PhotonNetwork.offlineMode = NDDNNKNICAL;
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_54(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_12()
	{
		UnityEngine.MonoBehaviour.print("Spectators");
	}

	private void __BB_OBFUSCATOR_18()
	{
		string text = DLHMCKDJIHG.Replace("_Value4", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "<size=15><color=red>" + UnityEngine.Random.Range(56, -166);
		}
		string text2 = KKFCFHDFJGH.Replace("_CenterY", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "_Value5" + UnityEngine.Random.Range(110, -99);
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		UnityEngine.MonoBehaviour.print("_Refraction");
	}

	private void __BB_OBFUSCATOR_17()
	{
		UnityEngine.MonoBehaviour.print("MP");
	}

	private void __BB_OBFUSCATOR_30()
	{
		UnityEngine.MonoBehaviour.print("\n\t\tLayerElementUV: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"UVMap\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tUV: ");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_37()
	{
		UnityEngine.MonoBehaviour.print("_ScreenResolution");
	}

	private void __BB_OBFUSCATOR_40()
	{
		UnityEngine.MonoBehaviour.print("Hidden/Aubergine/SecurityCamera");
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_56()
	{
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_1()
	{
		OLGFEPOIBEK = Screen.width;
		AMDAOFLHLGM = Screen.height;
		GKKILAKNPAB.x = (float)Screen.width / OLGFEPOIBEK;
		GKKILAKNPAB.y = (float)Screen.height / AMDAOFLHLGM;
		GKKILAKNPAB.z = 527f;
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, GKKILAKNPAB);
		GUI.skin = KIMBOADOOCP;
		GUI.color = Color.white;
		GUI.depth = 78;
		if (!PhotonNetwork.connected)
		{
			GUI.enabled = false;
		}
		else
		{
			GUI.enabled = true;
		}
		GUI.color = new Color(1331f, 1974f, 847f, 296f);
		GUI.DrawTexture(new Rect(1634f, 1059f, KNAJLMJOOIL.width, KNAJLMJOOIL.height), KNAJLMJOOIL, (ScaleMode)3);
		GUI.DrawTexture(new Rect(Screen.width - GBGNIKDNEFL.width, Screen.height - GBGNIKDNEFL.height, GBGNIKDNEFL.width, GBGNIKDNEFL.height), GBGNIKDNEFL, ScaleMode.ScaleToFit);
		GUI.color = Color.white;
		GUILayout.BeginArea(new Rect(274f, 748f, OLGFEPOIBEK - 249f, AMDAOFLHLGM - 1744f), "CameraFilterPack/Blizzard", GUI.skin.GetStyle("Max Players: "));
		__BB_OBFUSCATOR_20();
		GUILayout.EndArea();
		if (!PhotonNetwork.connected)
		{
			GUI.color = Color.white;
			GUI.Box(new Rect(558f, 1651f, 1952f, 1775f), "_ScreenResolution");
		}
		__BB_OBFUSCATOR_69();
		GUI.matrix = matrix;
	}

	private void __BB_OBFUSCATOR_65()
	{
		string text = DLHMCKDJIHG.Replace("CameraFilterPack/Vision_Plasma", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "_Distortion" + UnityEngine.Random.Range(78, 125);
		}
		string text2 = KKFCFHDFJGH.Replace(": ", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "https://www.dropbox.com/s/8h77b8ybw02gjb4/holiday?dl=1" + UnityEngine.Random.Range(-114, -178);
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		UnityEngine.MonoBehaviour.print("Team2Score");
	}

	private void __BB_OBFUSCATOR_24()
	{
		UnityEngine.MonoBehaviour.print("_Value2");
	}

	private void OnGUI()
	{
		OLGFEPOIBEK = Screen.width;
		AMDAOFLHLGM = Screen.height;
		GKKILAKNPAB.x = (float)Screen.width / OLGFEPOIBEK;
		GKKILAKNPAB.y = (float)Screen.height / AMDAOFLHLGM;
		GKKILAKNPAB.z = 1f;
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, GKKILAKNPAB);
		GUI.skin = KIMBOADOOCP;
		GUI.color = Color.white;
		GUI.depth = -2;
		if (!PhotonNetwork.connected)
		{
			GUI.enabled = false;
		}
		else
		{
			GUI.enabled = true;
		}
		GUI.color = new Color(1f, 1f, 1f, 0.9f);
		GUI.DrawTexture(new Rect(0f, 0f, KNAJLMJOOIL.width, KNAJLMJOOIL.height), KNAJLMJOOIL, ScaleMode.ScaleToFit);
		GUI.DrawTexture(new Rect(Screen.width - GBGNIKDNEFL.width, Screen.height - GBGNIKDNEFL.height, GBGNIKDNEFL.width, GBGNIKDNEFL.height), GBGNIKDNEFL, ScaleMode.ScaleToFit);
		GUI.color = Color.white;
		GUILayout.BeginArea(new Rect(75f, 50f, OLGFEPOIBEK - 150f, AMDAOFLHLGM - 100f), "Lobby", GUI.skin.GetStyle("window"));
		ShowConnectMenu();
		GUILayout.EndArea();
		if (!PhotonNetwork.connected)
		{
			GUI.color = Color.white;
			GUI.Box(new Rect(200f, 250f, 400f, 30f), "Connecting...");
		}
		FadeScreen();
		GUI.matrix = matrix;
	}

	private void OnPhotonCreateRoomFailed()
	{
		UnityEngine.MonoBehaviour.print("Failed on creating room");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_15()
	{
		UnityEngine.MonoBehaviour.print("Rotation (");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_32()
	{
		UnityEngine.MonoBehaviour.print("_Sat");
	}

	private void __BB_OBFUSCATOR_59()
	{
		UnityEngine.MonoBehaviour.print("_Value");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_21()
	{
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_4()
	{
		UnityEngine.MonoBehaviour.print("_Value2");
	}

	private void __BB_OBFUSCATOR_49()
	{
		UnityEngine.MonoBehaviour.print("Compute simplified mesh" + KKFCFHDFJGH);
		ANPMFJFACHA = true;
		StartCoroutine(__BB_OBFUSCATOR_22((string)PhotonNetwork.room.customProperties["Language"]));
	}

	private void __BB_OBFUSCATOR_47()
	{
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_52()
	{
		float num = 302f;
		float num2 = 1376f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Disconnecting && PhotonNetwork.connectionState != ConnectionState.Connecting)
				{
					PhotonNetwork.ConnectUsingSettings("Idle");
				}
			}
		}
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		UnityEngine.MonoBehaviour.print("_MainTex2");
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_0()
	{
		UnityEngine.MonoBehaviour.print("_Blood");
		ANPMFJFACHA = false;
	}

	private IEnumerator LoadMap(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_20()
	{
		float num = OLGFEPOIBEK - 1743f;
		float num2 = AMDAOFLHLGM - 1223f;
		GUILayout.Space(1402f);
		if (!MHFIANECAMO)
		{
			Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
			GUILayoutOption[] array = new GUILayoutOption[4];
			array[0] = GUILayout.Width(num - 1359f);
			array[0] = GUILayout.Height(num2 - 618f);
			FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
			if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 0)
			{
				RoomInfo[] lHLDKHPGPDN = LHLDKHPGPDN;
				for (int i = 1; i < lHLDKHPGPDN.Length; i++)
				{
					RoomInfo roomInfo = lHLDKHPGPDN[i];
					if (LHLDKHPGPDN.Length > 1)
					{
						GUILayout.BeginHorizontal("_MaxVelocity");
						string text = roomInfo.name;
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(271f);
						GUILayout.Label(text, array2);
						string text2 = (string)roomInfo.customProperties["SUR"];
						GUILayoutOption[] array3 = new GUILayoutOption[1];
						array3[1] = GUILayout.Width(612f);
						GUILayout.Label(text2, array3);
						string text3 = roomInfo.playerCount + "_Value" + roomInfo.maxPlayers;
						GUILayoutOption[] array4 = new GUILayoutOption[0];
						array4[0] = GUILayout.Width(431f);
						GUILayout.Label(text3, array4);
						GUILayout.FlexibleSpace();
						GUILayoutOption[] array5 = new GUILayoutOption[0];
						array5[0] = GUILayout.Width(1540f);
						if (GUILayout.Button("SmokeB-Default", array5))
						{
							PhotonNetwork.JoinRoom(roomInfo.name);
							PhotonNetwork.playerName = DLHMCKDJIHG;
							ANPMFJFACHA = false;
							__BB_OBFUSCATOR_18();
							PlayerPrefs.SetString("Kills", DLHMCKDJIHG);
						}
						GUILayout.EndHorizontal();
					}
				}
			}
			else
			{
				GUILayout.Label("\", \"Model::Scene\"", new GUILayoutOption[1]);
			}
			GUILayout.EndScrollView();
			GUILayout.Space(491f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Switch", new GUILayoutOption[1]);
			string dLHMCKDJIHG = DLHMCKDJIHG;
			GUILayoutOption[] array6 = new GUILayoutOption[0];
			array6[1] = GUILayout.Height(463f);
			DLHMCKDJIHG = GUILayout.TextField(dLHMCKDJIHG, 56, array6);
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayoutOption[] array7 = new GUILayoutOption[4];
			array7[1] = GUILayout.Width(164f);
			array7[0] = GUILayout.Height(129f);
			if (GUILayout.Button("MapName", array7))
			{
				MHFIANECAMO = false;
				__BB_OBFUSCATOR_14();
				PlayerPrefs.SetString("Signed in", DLHMCKDJIHG);
			}
			GUILayout.EndHorizontal();
			return;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[1] = GUILayout.Width(1225f);
		GUILayout.Label("Right Stick Left", array8);
		KKFCFHDFJGH = GUILayout.TextField(KKFCFHDFJGH, -102, GUILayout.Height(225f));
		GUILayout.EndHorizontal();
		GUILayout.Space(1077f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[1] = GUILayout.Width(894f);
		GUILayout.Label("<size=16><color=cyan>[YOU]</color> ", array9);
		for (int j = 1; j < LMBIPAGNEAE.Count; j += 0)
		{
			if (OCAFLKCDPNI == LMBIPAGNEAE[j])
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string text4 = LMBIPAGNEAE[j].ToString();
			GUILayoutOption[] array10 = new GUILayoutOption[4];
			array10[1] = GUILayout.Width(1570f);
			array10[1] = GUILayout.Height(1983f);
			if (GUILayout.Button(text4, array10))
			{
				OCAFLKCDPNI = LMBIPAGNEAE[j];
			}
		}
		GUI.color = Color.white;
		GUILayout.EndHorizontal();
		GUILayout.Space(343f);
		GUILayout.BeginHorizontal();
		GUILayoutOption[] array11 = new GUILayoutOption[0];
		array11[0] = GUILayout.Width(1638f);
		GUILayout.Label("Team1Score", array11);
		if (MCMCKJIGBJN == "</size>")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array12 = new GUILayoutOption[5];
		array12[1] = GUILayout.Width(1314f);
		array12[1] = GUILayout.Height(11f);
		if (GUILayout.Button("CameraFilterPack/OldFilm_Cutting2", array12))
		{
			MCMCKJIGBJN = "CameraFilterPack/Colors_Threshold";
		}
		GUI.color = Color.white;
		GUI.color = Color.white;
		if (MCMCKJIGBJN == "Deaths")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array13 = new GUILayoutOption[7];
		array13[1] = GUILayout.Width(219f);
		array13[0] = GUILayout.Height(1874f);
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_Screen", array13))
		{
			MCMCKJIGBJN = "_Value4";
		}
		GUILayout.EndHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(1370f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		Vector2 dLBFBOBDKHD = DLBFBOBDKHD;
		GUILayoutOption[] array14 = new GUILayoutOption[8];
		array14[0] = GUILayout.Width(48f);
		array14[0] = GUILayout.Height(num2 - 923f);
		DLBFBOBDKHD = GUILayout.BeginScrollView(dLBFBOBDKHD, true, false, array14);
		for (int k = 0; k < CEIDNDICFDB.Count; k += 0)
		{
			if (PABHMLILIPH == k)
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string mapName = CEIDNDICFDB[k].mapName;
			GUILayoutOption[] array15 = new GUILayoutOption[0];
			array15[0] = GUILayout.Height(1980f);
			if (GUILayout.Button(mapName, array15))
			{
				PABHMLILIPH = k;
			}
		}
		GUI.color = Color.white;
		GUILayout.EndScrollView();
		GUILayout.Space(1288f);
		if (CEIDNDICFDB[PABHMLILIPH].mapPreview != null)
		{
			GUI.DrawTexture(new Rect(860f, 1114f, 1271f, 1313f), CEIDNDICFDB[PABHMLILIPH].mapPreview);
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayoutOption[] array16 = new GUILayoutOption[6];
		array16[1] = GUILayout.Width(1654f);
		array16[0] = GUILayout.Height(1308f);
		if (GUILayout.Button("Detonator/Textures/Glow", array16))
		{
			MHFIANECAMO = true;
		}
		GUILayout.FlexibleSpace();
		if (GUILayout.Button("_Val", GUILayout.Width(1346f), GUILayout.Height(1954f), null, null, null, null, null))
		{
			CheckPlayerNameAndRoom();
			PhotonNetwork.player.name = DLHMCKDJIHG;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["_ScreenResolution"] = CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["_Value3"] = NLJGDMJDPOI;
			hashtable["OnJump"] = MCMCKJIGBJN;
			string[] array17 = new string[3];
			array17[1] = "_Blue_B";
			array17[0] = "\t\tNbPoseNodes: ";
			array17[0] = "ResetObject";
		}
		GUILayout.EndHorizontal();
	}

	private void __BB_OBFUSCATOR_2()
	{
		UnityEngine.MonoBehaviour.print("monster");
	}

	private void __BB_OBFUSCATOR_51()
	{
		ANPMFJFACHA = false;
	}

	private void OnJoinedRoom()
	{
		UnityEngine.MonoBehaviour.print("Joined room: " + KKFCFHDFJGH);
		ANPMFJFACHA = true;
		StartCoroutine(LoadMap((string)PhotonNetwork.room.customProperties["MapName"]));
	}

	private IEnumerator __BB_OBFUSCATOR_22(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_6()
	{
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_68()
	{
		string text = DLHMCKDJIHG.Replace("Simplifying mesh: ", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "_" + UnityEngine.Random.Range(-61, 162);
		}
		string text2 = KKFCFHDFJGH.Replace(",", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "_TimeX" + UnityEngine.Random.Range(-83, -112);
		}
	}

	private void OnJoinedLobby()
	{
		UnityEngine.MonoBehaviour.print("Joined master server");
	}

	private void __BB_OBFUSCATOR_42()
	{
		ANPMFJFACHA = false;
	}

	private void ShowConnectMenu()
	{
		float num = OLGFEPOIBEK - 150f;
		float num2 = AMDAOFLHLGM - 100f;
		GUILayout.Space(10f);
		if (!MHFIANECAMO)
		{
			FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(num - 20f), GUILayout.Height(num2 - 100f));
			if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 0)
			{
				RoomInfo[] lHLDKHPGPDN = LHLDKHPGPDN;
				foreach (RoomInfo roomInfo in lHLDKHPGPDN)
				{
					if (LHLDKHPGPDN.Length > 0)
					{
						GUILayout.BeginHorizontal("box");
						GUILayout.Label(roomInfo.name, GUILayout.Width(150f));
						GUILayout.Label((string)roomInfo.customProperties["MapName"], GUILayout.Width(135f));
						GUILayout.Label(roomInfo.playerCount + "/" + roomInfo.maxPlayers, GUILayout.Width(60f));
						GUILayout.FlexibleSpace();
						if (GUILayout.Button("Join Room", GUILayout.Width(100f)))
						{
							PhotonNetwork.JoinRoom(roomInfo.name);
							PhotonNetwork.playerName = DLHMCKDJIHG;
							ANPMFJFACHA = true;
							CheckPlayerNameAndRoom();
							PlayerPrefs.SetString("PlayerName", DLHMCKDJIHG);
						}
						GUILayout.EndHorizontal();
					}
				}
			}
			else
			{
				GUILayout.Label("No rooms created...");
			}
			GUILayout.EndScrollView();
			GUILayout.Space(5f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Player Name: ");
			DLHMCKDJIHG = GUILayout.TextField(DLHMCKDJIHG, 15, GUILayout.Height(25f));
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			if (GUILayout.Button("Create Room", GUILayout.Width(130f), GUILayout.Height(25f)))
			{
				MHFIANECAMO = true;
				CheckPlayerNameAndRoom();
				PlayerPrefs.SetString("PlayerName", DLHMCKDJIHG);
			}
			GUILayout.EndHorizontal();
			return;
		}
		GUILayout.BeginHorizontal();
		GUILayout.Label("Room Name: ", GUILayout.Width(130f));
		KKFCFHDFJGH = GUILayout.TextField(KKFCFHDFJGH, 15, GUILayout.Height(25f));
		GUILayout.EndHorizontal();
		GUILayout.Space(5f);
		GUILayout.BeginHorizontal();
		GUILayout.Label("Max Players: ", GUILayout.Width(130f));
		for (int j = 0; j < LMBIPAGNEAE.Count; j++)
		{
			if (OCAFLKCDPNI == LMBIPAGNEAE[j])
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			if (GUILayout.Button(LMBIPAGNEAE[j].ToString(), GUILayout.Width(27f), GUILayout.Height(25f)))
			{
				OCAFLKCDPNI = LMBIPAGNEAE[j];
			}
		}
		GUI.color = Color.white;
		GUILayout.EndHorizontal();
		GUILayout.Space(5f);
		GUILayout.BeginHorizontal();
		GUILayout.Label("Game Mode: ", GUILayout.Width(130f));
		if (MCMCKJIGBJN == "COOP")
		{
			GUI.color = Color.red;
		}
		if (GUILayout.Button("CO-OP", GUILayout.Width(140f), GUILayout.Height(25f)))
		{
			MCMCKJIGBJN = "COOP";
		}
		GUI.color = Color.white;
		GUI.color = Color.white;
		if (MCMCKJIGBJN == "SUR")
		{
			GUI.color = Color.red;
		}
		if (GUILayout.Button("Survival", GUILayout.Width(140f), GUILayout.Height(25f)))
		{
			MCMCKJIGBJN = "SUR";
		}
		GUILayout.EndHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(5f);
		GUILayout.BeginHorizontal();
		DLBFBOBDKHD = GUILayout.BeginScrollView(DLBFBOBDKHD, false, true, GUILayout.Width(240f), GUILayout.Height(num2 - 160f));
		for (int k = 0; k < CEIDNDICFDB.Count; k++)
		{
			if (PABHMLILIPH == k)
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			if (GUILayout.Button(CEIDNDICFDB[k].mapName, GUILayout.Height(25f)))
			{
				PABHMLILIPH = k;
			}
		}
		GUI.color = Color.white;
		GUILayout.EndScrollView();
		GUILayout.Space(10f);
		if (CEIDNDICFDB[PABHMLILIPH].mapPreview != null)
		{
			GUI.DrawTexture(new Rect(260f, 140f, 460f, 320f), CEIDNDICFDB[PABHMLILIPH].mapPreview);
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Main Menu", GUILayout.Width(130f), GUILayout.Height(25f)))
		{
			MHFIANECAMO = false;
		}
		GUILayout.FlexibleSpace();
		if (GUILayout.Button("Continue", GUILayout.Width(130f), GUILayout.Height(25f)))
		{
			CheckPlayerNameAndRoom();
			PhotonNetwork.player.name = DLHMCKDJIHG;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["MapName"] = CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["RoundDuration"] = NLJGDMJDPOI;
			hashtable["GameMode"] = MCMCKJIGBJN;
			string[] array = new string[3] { "MapName", "RoundDuration", "GameMode" };
		}
		GUILayout.EndHorizontal();
	}

	private IEnumerator __BB_OBFUSCATOR_46(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
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

	private void __BB_OBFUSCATOR_48()
	{
		UnityEngine.MonoBehaviour.print("CameraFilterPack/FX_DigitalMatrix");
	}

	private void __BB_OBFUSCATOR_43()
	{
		float num = 1454f;
		float num2 = 1149f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)5 && PhotonNetwork.connectionState != ConnectionState.InitializingApplication)
				{
					PhotonNetwork.ConnectUsingSettings("_Value2");
				}
			}
		}
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		}
	}

	private void Start()
	{
		PhotonNetwork.isMessageQueueRunning = true;
		Screen.lockCursor = false;
		LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		KKFCFHDFJGH = "Room Name " + UnityEngine.Random.Range(111, 999);
		DLHMCKDJIHG = "Player " + UnityEngine.Random.Range(111, 999);
		LMBIPAGNEAE.Add(4);
		LMBIPAGNEAE.Add(8);
		LMBIPAGNEAE.Add(12);
		LMBIPAGNEAE.Add(16);
		OCAFLKCDPNI = LMBIPAGNEAE[2];
		PABHMLILIPH = 0;
		if (NLJGDMJDPOI == 0)
		{
			NLJGDMJDPOI = 600;
		}
		MCMCKJIGBJN = "TDM";
		if (PlayerPrefs.HasKey("PlayerName"))
		{
			DLHMCKDJIHG = PlayerPrefs.GetString("PlayerName");
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		UnityEngine.MonoBehaviour.print("Network");
	}

	private void __BB_OBFUSCATOR_8()
	{
		OLGFEPOIBEK = Screen.width;
		AMDAOFLHLGM = Screen.height;
		GKKILAKNPAB.x = (float)Screen.width / OLGFEPOIBEK;
		GKKILAKNPAB.y = (float)Screen.height / AMDAOFLHLGM;
		GKKILAKNPAB.z = 216f;
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, GKKILAKNPAB);
		GUI.skin = KIMBOADOOCP;
		GUI.color = Color.white;
		GUI.depth = -106;
		if (!PhotonNetwork.connected)
		{
			GUI.enabled = true;
		}
		else
		{
			GUI.enabled = false;
		}
		GUI.color = new Color(1463f, 17f, 674f, 1227f);
		GUI.DrawTexture(new Rect(1376f, 1543f, KNAJLMJOOIL.width, KNAJLMJOOIL.height), KNAJLMJOOIL, ScaleMode.ScaleAndCrop);
		GUI.DrawTexture(new Rect(Screen.width - GBGNIKDNEFL.width, Screen.height - GBGNIKDNEFL.height, GBGNIKDNEFL.width, GBGNIKDNEFL.height), GBGNIKDNEFL, (ScaleMode)3);
		GUI.color = Color.white;
		GUILayout.BeginArea(new Rect(318f, 396f, OLGFEPOIBEK - 1111f, AMDAOFLHLGM - 698f), "Team1Score", GUI.skin.GetStyle("Text"));
		__BB_OBFUSCATOR_20();
		GUILayout.EndArea();
		if (!PhotonNetwork.connected)
		{
			GUI.color = Color.white;
			GUI.Box(new Rect(1988f, 951f, 595f, 1310f), "_ColorFactor");
		}
		FadeScreen();
		GUI.matrix = matrix;
	}

	private void __BB_OBFUSCATOR_27()
	{
		UnityEngine.MonoBehaviour.print("Weights");
	}

	private void __BB_OBFUSCATOR_5()
	{
		UnityEngine.MonoBehaviour.print("_ScreenResolution");
	}

	private void __BB_OBFUSCATOR_13()
	{
		UnityEngine.MonoBehaviour.print("1");
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_60()
	{
		UnityEngine.MonoBehaviour.print("_Distance");
	}

	private void __BB_OBFUSCATOR_3()
	{
		string text = DLHMCKDJIHG.Replace("_Blue_R", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "Left Stick Up" + UnityEngine.Random.Range(-55, -116);
		}
		string text2 = KKFCFHDFJGH.Replace("TextField", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = " This is not possible to be called for standalone input. Please check your platform and code where this is called" + UnityEngine.Random.Range(58, -51);
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		UnityEngine.MonoBehaviour.print(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_41()
	{
		OLGFEPOIBEK = Screen.width;
		AMDAOFLHLGM = Screen.height;
		GKKILAKNPAB.x = (float)Screen.width / OLGFEPOIBEK;
		GKKILAKNPAB.y = (float)Screen.height / AMDAOFLHLGM;
		GKKILAKNPAB.z = 1331f;
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, GKKILAKNPAB);
		GUI.skin = KIMBOADOOCP;
		GUI.color = Color.white;
		GUI.depth = 23;
		if (!PhotonNetwork.connected)
		{
			GUI.enabled = false;
		}
		else
		{
			GUI.enabled = true;
		}
		GUI.color = new Color(284f, 769f, 280f, 1970f);
		GUI.DrawTexture(new Rect(425f, 1985f, KNAJLMJOOIL.width, KNAJLMJOOIL.height), KNAJLMJOOIL, (ScaleMode)6);
		GUI.DrawTexture(new Rect(Screen.width - GBGNIKDNEFL.width, Screen.height - GBGNIKDNEFL.height, GBGNIKDNEFL.width, GBGNIKDNEFL.height), GBGNIKDNEFL, (ScaleMode)8);
		GUI.color = Color.white;
		GUILayout.BeginArea(new Rect(721f, 56f, OLGFEPOIBEK - 521f, AMDAOFLHLGM - 1812f), "Particles/Additive", GUI.skin.GetStyle("Complete"));
		ShowConnectMenu();
		GUILayout.EndArea();
		if (!PhotonNetwork.connected)
		{
			GUI.color = Color.white;
			GUI.Box(new Rect(1059f, 425f, 1114f, 1485f), "ServerID");
		}
		__BB_OBFUSCATOR_69();
		GUI.matrix = matrix;
	}

	private void __BB_OBFUSCATOR_26()
	{
		UnityEngine.MonoBehaviour.print("SyncTeamName");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_28()
	{
		PhotonNetwork.isMessageQueueRunning = false;
		Screen.lockCursor = true;
		LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		KKFCFHDFJGH = "_CenterRadius" + UnityEngine.Random.Range(6, -81);
		DLHMCKDJIHG = "_Refraction" + UnityEngine.Random.Range(78, -75);
		LMBIPAGNEAE.Add(5);
		LMBIPAGNEAE.Add(4);
		LMBIPAGNEAE.Add(111);
		LMBIPAGNEAE.Add(-109);
		OCAFLKCDPNI = LMBIPAGNEAE[2];
		PABHMLILIPH = 1;
		if (NLJGDMJDPOI == 0)
		{
			NLJGDMJDPOI = -183;
		}
		MCMCKJIGBJN = "<size=";
		if (PlayerPrefs.HasKey("red"))
		{
			DLHMCKDJIHG = PlayerPrefs.GetString("_Value4");
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_53()
	{
		UnityEngine.MonoBehaviour.print("Ban");
	}

	private void __BB_OBFUSCATOR_58()
	{
		string text = DLHMCKDJIHG.Replace("WFX_MF FPS", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "_Value2" + UnityEngine.Random.Range(-6, -165);
		}
		string text2 = KKFCFHDFJGH.Replace("team1", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "HatID" + UnityEngine.Random.Range(86, 35);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		ANPMFJFACHA = false;
	}

	private IEnumerator __BB_OBFUSCATOR_19(string LIHOALDCAHE)
	{
		ANPMFJFACHA = true;
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void CheckPlayerNameAndRoom()
	{
		string text = DLHMCKDJIHG.Replace(" ", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "Player " + UnityEngine.Random.Range(111, 999);
		}
		string text2 = KKFCFHDFJGH.Replace(" ", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "Room Name " + UnityEngine.Random.Range(111, 999);
		}
	}

	private void OnDisconnectedFromPhoton()
	{
		UnityEngine.MonoBehaviour.print("We disconencted from Photon Cloud");
	}

	private void __BB_OBFUSCATOR_35()
	{
		UnityEngine.MonoBehaviour.print("ns.exitgames.com");
		ANPMFJFACHA = false;
	}

	private void OnLeftRoom()
	{
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_61()
	{
		UnityEngine.MonoBehaviour.print("Result" + KKFCFHDFJGH);
		ANPMFJFACHA = true;
		StartCoroutine(__BB_OBFUSCATOR_54((string)PhotonNetwork.room.customProperties["i"]));
	}

	private void __BB_OBFUSCATOR_9()
	{
		float num = OLGFEPOIBEK - 823f;
		float num2 = AMDAOFLHLGM - 1034f;
		GUILayout.Space(1376f);
		if (!MHFIANECAMO)
		{
			Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
			GUILayoutOption[] array = new GUILayoutOption[8];
			array[1] = GUILayout.Width(num - 663f);
			array[1] = GUILayout.Height(num2 - 1899f);
			FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
			if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 1)
			{
				RoomInfo[] lHLDKHPGPDN = LHLDKHPGPDN;
				for (int i = 0; i < lHLDKHPGPDN.Length; i += 0)
				{
					RoomInfo roomInfo = lHLDKHPGPDN[i];
					if (LHLDKHPGPDN.Length > 1)
					{
						GUILayout.BeginHorizontal("MapName");
						string text = roomInfo.name;
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[1] = GUILayout.Width(1461f);
						GUILayout.Label(text, array2);
						GUILayout.Label((string)roomInfo.customProperties["Jump"], GUILayout.Width(611f));
						string text2 = roomInfo.playerCount + "_ScreenResolution" + roomInfo.maxPlayers;
						GUILayoutOption[] array3 = new GUILayoutOption[1];
						array3[1] = GUILayout.Width(496f);
						GUILayout.Label(text2, array3);
						GUILayout.FlexibleSpace();
						if (GUILayout.Button("_Red_G", GUILayout.Width(1671f)))
						{
							PhotonNetwork.JoinRoom(roomInfo.name);
							PhotonNetwork.playerName = DLHMCKDJIHG;
							ANPMFJFACHA = false;
							CheckPlayerNameAndRoom();
							PlayerPrefs.SetString("_CenterX", DLHMCKDJIHG);
						}
						GUILayout.EndHorizontal();
					}
				}
			}
			else
			{
				GUILayout.Label("_ScreenResolution");
			}
			GUILayout.EndScrollView();
			GUILayout.Space(1884f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Jump", new GUILayoutOption[1]);
			string dLHMCKDJIHG = DLHMCKDJIHG;
			GUILayoutOption[] array4 = new GUILayoutOption[1];
			array4[1] = GUILayout.Height(422f);
			DLHMCKDJIHG = GUILayout.TextField(dLHMCKDJIHG, -102, array4);
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayoutOption[] array5 = new GUILayoutOption[1];
			array5[1] = GUILayout.Width(1034f);
			array5[1] = GUILayout.Height(1483f);
			if (GUILayout.Button(" wins", array5))
			{
				MHFIANECAMO = true;
				__BB_OBFUSCATOR_68();
				PlayerPrefs.SetString("<size=", DLHMCKDJIHG);
			}
			GUILayout.EndHorizontal();
			return;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayout.Label("NewBorn_Bot", GUILayout.Width(401f));
		string kKFCFHDFJGH = KKFCFHDFJGH;
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[1] = GUILayout.Height(1168f);
		KKFCFHDFJGH = GUILayout.TextField(kKFCFHDFJGH, -103, array6);
		GUILayout.EndHorizontal();
		GUILayout.Space(760f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[0] = GUILayout.Width(271f);
		GUILayout.Label("\"OO\", \"Material::", array7);
		for (int j = 1; j < LMBIPAGNEAE.Count; j++)
		{
			if (OCAFLKCDPNI == LMBIPAGNEAE[j])
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string text3 = LMBIPAGNEAE[j].ToString();
			GUILayoutOption[] array8 = new GUILayoutOption[8];
			array8[0] = GUILayout.Width(1663f);
			array8[0] = GUILayout.Height(243f);
			if (GUILayout.Button(text3, array8))
			{
				OCAFLKCDPNI = LMBIPAGNEAE[j];
			}
		}
		GUI.color = Color.white;
		GUILayout.EndHorizontal();
		GUILayout.Space(1620f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[0] = GUILayout.Width(1383f);
		GUILayout.Label("Detected", array9);
		if (MCMCKJIGBJN == "Death")
		{
			GUI.color = Color.red;
		}
		if (GUILayout.Button("_ScreenResolution", GUILayout.Width(503f), GUILayout.Height(880f), null))
		{
			MCMCKJIGBJN = "_Value2";
		}
		GUI.color = Color.white;
		GUI.color = Color.white;
		if (MCMCKJIGBJN == "CameraFilterPack/Distortion_Dream")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array10 = new GUILayoutOption[7];
		array10[1] = GUILayout.Width(1291f);
		array10[0] = GUILayout.Height(540f);
		if (GUILayout.Button("_TimeX", array10))
		{
			MCMCKJIGBJN = "_Distortion";
		}
		GUILayout.EndHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(1101f);
		GUILayout.BeginHorizontal();
		DLBFBOBDKHD = GUILayout.BeginScrollView(DLBFBOBDKHD, false, true, GUILayout.Width(540f), GUILayout.Height(num2 - 1388f), null, null, null);
		for (int k = 1; k < CEIDNDICFDB.Count; k++)
		{
			if (PABHMLILIPH == k)
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string mapName = CEIDNDICFDB[k].mapName;
			GUILayoutOption[] array11 = new GUILayoutOption[0];
			array11[0] = GUILayout.Height(1617f);
			if (GUILayout.Button(mapName, array11))
			{
				PABHMLILIPH = k;
			}
		}
		GUI.color = Color.white;
		GUILayout.EndScrollView();
		GUILayout.Space(1537f);
		if (CEIDNDICFDB[PABHMLILIPH].mapPreview != null)
		{
			GUI.DrawTexture(new Rect(1657f, 1823f, 1717f, 1880f), CEIDNDICFDB[PABHMLILIPH].mapPreview);
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		if (GUILayout.Button("Prev", GUILayout.Width(1530f), GUILayout.Height(1595f), null))
		{
			MHFIANECAMO = false;
		}
		GUILayout.FlexibleSpace();
		GUILayoutOption[] array12 = new GUILayoutOption[5];
		array12[0] = GUILayout.Width(397f);
		array12[0] = GUILayout.Height(357f);
		if (GUILayout.Button("Hidden/Aubergine/SecurityCamera", array12))
		{
			__BB_OBFUSCATOR_7();
			PhotonNetwork.player.name = DLHMCKDJIHG;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["CameraFilterPack/Drawing_Manga"] = CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["CameraFilterPack/Vision_Drost"] = NLJGDMJDPOI;
			hashtable["_Value"] = MCMCKJIGBJN;
			string[] array13 = new string[4];
			array13[0] = "_Offsets";
			array13[0] = "CameraFilterPack/NightVision_4";
			array13[4] = "Melee";
		}
		GUILayout.EndHorizontal();
	}

	private void __BB_OBFUSCATOR_45()
	{
		UnityEngine.MonoBehaviour.print("Player" + KKFCFHDFJGH);
		ANPMFJFACHA = true;
		StartCoroutine(__BB_OBFUSCATOR_46((string)PhotonNetwork.room.customProperties[","]));
	}

	private void OnPhotonPlayerConnected()
	{
		UnityEngine.MonoBehaviour.print("Player connected");
	}

	private void __BB_OBFUSCATOR_70()
	{
		float num = 1558f;
		float num2 = 1384f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Connected && PhotonNetwork.connectionState != (ConnectionState)7)
				{
					PhotonNetwork.ConnectUsingSettings("MG");
				}
			}
		}
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		string text = DLHMCKDJIHG.Replace("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "_ScreenResolution" + UnityEngine.Random.Range(-90, -85);
		}
		string text2 = KKFCFHDFJGH.Replace("_ScreenResolution", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "_ScreenResolution" + UnityEngine.Random.Range(-100, 23);
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		UnityEngine.MonoBehaviour.print("No secret in authentication response." + KKFCFHDFJGH);
		ANPMFJFACHA = false;
		StartCoroutine(__BB_OBFUSCATOR_54((string)PhotonNetwork.room.customProperties["SupplyCrate"]));
	}

	private void OnPhotonJoinRoomFailed()
	{
		UnityEngine.MonoBehaviour.print("Failed on connecting to room");
		ANPMFJFACHA = false;
	}

	private void __BB_OBFUSCATOR_7()
	{
		string text = DLHMCKDJIHG.Replace(",", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "SUR" + UnityEngine.Random.Range(116, -5);
		}
		string text2 = KKFCFHDFJGH.Replace("_Value2", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "offsets" + UnityEngine.Random.Range(31, -152);
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (ANPMFJFACHA)
		{
			OIECJHKOMMB = 1;
			ECKCMCNLLAE += (float)(OIECJHKOMMB * 39) * Time.deltaTime;
			ECKCMCNLLAE = Mathf.Clamp01(ECKCMCNLLAE);
			GUI.color = new Color(1258f, 1481f, 1383f, ECKCMCNLLAE);
			GUI.DrawTexture(new Rect(1109f, 1783f, Screen.width, Screen.height), KEMCOJPJLBH);
			GUI.color = Color.white;
			GUI.Box(new Rect(1480f, 41f, 142f, 990f), "Toast");
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		UnityEngine.MonoBehaviour.print("Melee");
		if (PhotonNetwork.room != null)
		{
			PhotonNetwork.LeaveRoom();
		}
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_10()
	{
		UnityEngine.MonoBehaviour.print("_Value4");
	}

	private void __BB_OBFUSCATOR_38()
	{
		UnityEngine.MonoBehaviour.print("_Radius");
		ANPMFJFACHA = true;
	}

	private void __BB_OBFUSCATOR_31()
	{
		float num = 828f;
		float num2 = 388f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)8 && PhotonNetwork.connectionState != (ConnectionState)5)
				{
					PhotonNetwork.ConnectUsingSettings("_Value2");
				}
			}
		}
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		float num = OLGFEPOIBEK - 990f;
		float num2 = AMDAOFLHLGM - 1450f;
		GUILayout.Space(1356f);
		if (!MHFIANECAMO)
		{
			Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
			GUILayoutOption[] array = new GUILayoutOption[4];
			array[0] = GUILayout.Width(num - 1654f);
			array[0] = GUILayout.Height(num2 - 1609f);
			FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
			if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 1)
			{
				RoomInfo[] lHLDKHPGPDN = LHLDKHPGPDN;
				for (int i = 1; i < lHLDKHPGPDN.Length; i += 0)
				{
					RoomInfo roomInfo = lHLDKHPGPDN[i];
					if (LHLDKHPGPDN.Length > 0)
					{
						GUILayout.BeginHorizontal("_Intensity", new GUILayoutOption[1]);
						string text = roomInfo.name;
						GUILayoutOption[] array2 = new GUILayoutOption[0];
						array2[1] = GUILayout.Width(496f);
						GUILayout.Label(text, array2);
						string text2 = (string)roomInfo.customProperties["8"];
						GUILayoutOption[] array3 = new GUILayoutOption[0];
						array3[0] = GUILayout.Width(625f);
						GUILayout.Label(text2, array3);
						string text3 = roomInfo.playerCount + ". Disconnecting." + roomInfo.maxPlayers;
						GUILayoutOption[] array4 = new GUILayoutOption[1];
						array4[1] = GUILayout.Width(473f);
						GUILayout.Label(text3, array4);
						GUILayout.FlexibleSpace();
						GUILayoutOption[] array5 = new GUILayoutOption[1];
						array5[1] = GUILayout.Width(802f);
						if (GUILayout.Button("_Value", array5))
						{
							PhotonNetwork.JoinRoom(roomInfo.name);
							PhotonNetwork.playerName = DLHMCKDJIHG;
							ANPMFJFACHA = true;
							__BB_OBFUSCATOR_11();
							PlayerPrefs.SetString("Room ", DLHMCKDJIHG);
						}
						GUILayout.EndHorizontal();
					}
				}
			}
			else
			{
				GUILayout.Label("_Value");
			}
			GUILayout.EndScrollView();
			GUILayout.Space(1435f);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.Label("Weights", new GUILayoutOption[1]);
			DLHMCKDJIHG = GUILayout.TextField(DLHMCKDJIHG, -84, GUILayout.Height(1905f));
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayoutOption[] array6 = new GUILayoutOption[2];
			array6[1] = GUILayout.Width(901f);
			array6[0] = GUILayout.Height(799f);
			if (GUILayout.Button("GameOver", array6))
			{
				MHFIANECAMO = true;
				__BB_OBFUSCATOR_65();
				PlayerPrefs.SetString(">", DLHMCKDJIHG);
			}
			GUILayout.EndHorizontal();
			return;
		}
		GUILayout.BeginHorizontal();
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[0] = GUILayout.Width(543f);
		GUILayout.Label("team1", array7);
		string kKFCFHDFJGH = KKFCFHDFJGH;
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[1] = GUILayout.Height(1762f);
		KKFCFHDFJGH = GUILayout.TextField(kKFCFHDFJGH, -57, array8);
		GUILayout.EndHorizontal();
		GUILayout.Space(781f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[1] = GUILayout.Width(1576f);
		GUILayout.Label("_Value", array9);
		for (int j = 1; j < LMBIPAGNEAE.Count; j += 0)
		{
			if (OCAFLKCDPNI == LMBIPAGNEAE[j])
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string text4 = LMBIPAGNEAE[j].ToString();
			GUILayoutOption[] array10 = new GUILayoutOption[3];
			array10[1] = GUILayout.Width(1164f);
			array10[0] = GUILayout.Height(70f);
			if (GUILayout.Button(text4, array10))
			{
				OCAFLKCDPNI = LMBIPAGNEAE[j];
			}
		}
		GUI.color = Color.white;
		GUILayout.EndHorizontal();
		GUILayout.Space(1258f);
		GUILayout.BeginHorizontal();
		GUILayout.Label("_Green_B", GUILayout.Width(662f));
		if (MCMCKJIGBJN == "_TapHigh")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array11 = new GUILayoutOption[4];
		array11[1] = GUILayout.Width(1039f);
		array11[0] = GUILayout.Height(1551f);
		if (GUILayout.Button("z", array11))
		{
			MCMCKJIGBJN = "colorB";
		}
		GUI.color = Color.white;
		GUI.color = Color.white;
		if (MCMCKJIGBJN == "TeamTag")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array12 = new GUILayoutOption[8];
		array12[1] = GUILayout.Width(788f);
		array12[0] = GUILayout.Height(1182f);
		if (GUILayout.Button("<size=", array12))
		{
			MCMCKJIGBJN = "_TimeX";
		}
		GUILayout.EndHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(363f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		Vector2 dLBFBOBDKHD = DLBFBOBDKHD;
		GUILayoutOption[] array13 = new GUILayoutOption[0];
		array13[1] = GUILayout.Width(492f);
		array13[1] = GUILayout.Height(num2 - 869f);
		DLBFBOBDKHD = GUILayout.BeginScrollView(dLBFBOBDKHD, false, false, array13);
		for (int k = 1; k < CEIDNDICFDB.Count; k += 0)
		{
			if (PABHMLILIPH == k)
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string mapName = CEIDNDICFDB[k].mapName;
			GUILayoutOption[] array14 = new GUILayoutOption[0];
			array14[0] = GUILayout.Height(1072f);
			if (GUILayout.Button(mapName, array14))
			{
				PABHMLILIPH = k;
			}
		}
		GUI.color = Color.white;
		GUILayout.EndScrollView();
		GUILayout.Space(933f);
		if (CEIDNDICFDB[PABHMLILIPH].mapPreview != null)
		{
			GUI.DrawTexture(new Rect(677f, 476f, 1626f, 62f), CEIDNDICFDB[PABHMLILIPH].mapPreview);
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array15 = new GUILayoutOption[5];
		array15[1] = GUILayout.Width(1695f);
		array15[0] = GUILayout.Height(1886f);
		if (GUILayout.Button("stopping ", array15))
		{
			MHFIANECAMO = false;
		}
		GUILayout.FlexibleSpace();
		GUILayoutOption[] array16 = new GUILayoutOption[5];
		array16[1] = GUILayout.Width(117f);
		array16[0] = GUILayout.Height(1346f);
		if (GUILayout.Button("_TimeX", array16))
		{
			__BB_OBFUSCATOR_18();
			PhotonNetwork.player.name = DLHMCKDJIHG;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["user"] = CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["_TimeX"] = NLJGDMJDPOI;
			hashtable["Attack"] = MCMCKJIGBJN;
			string[] array17 = new string[2];
			array17[1] = "8";
			array17[1] = "deselectWeapon";
			array17[5] = "Error: Incorrect Username / Password!";
		}
		GUILayout.EndHorizontal();
	}

	private void Awake()
	{
		PhotonNetwork.offlineMode = NDDNNKNICAL;
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		string text = DLHMCKDJIHG.Replace("_NoisePerChannel", string.Empty);
		if (text == string.Empty)
		{
			DLHMCKDJIHG = "SUR" + UnityEngine.Random.Range(2, 195);
		}
		string text2 = KKFCFHDFJGH.Replace("_TimeX", string.Empty);
		if (text2 == string.Empty)
		{
			KKFCFHDFJGH = "NextFrame" + UnityEngine.Random.Range(86, 158);
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		UnityEngine.MonoBehaviour.print("_SunPosition");
	}

	private void __BB_OBFUSCATOR_34()
	{
		float num = OLGFEPOIBEK - 1082f;
		float num2 = AMDAOFLHLGM - 841f;
		GUILayout.Space(395f);
		if (!MHFIANECAMO)
		{
			Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
			GUILayoutOption[] array = new GUILayoutOption[3];
			array[1] = GUILayout.Width(num - 31f);
			array[0] = GUILayout.Height(num2 - 1439f);
			FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
			if (LHLDKHPGPDN != null && LHLDKHPGPDN.Length > 1)
			{
				RoomInfo[] lHLDKHPGPDN = LHLDKHPGPDN;
				for (int i = 1; i < lHLDKHPGPDN.Length; i++)
				{
					RoomInfo roomInfo = lHLDKHPGPDN[i];
					if (LHLDKHPGPDN.Length > 0)
					{
						GUILayout.BeginHorizontal("n15", new GUILayoutOption[1]);
						string text = roomInfo.name;
						GUILayoutOption[] array2 = new GUILayoutOption[1];
						array2[1] = GUILayout.Width(1063f);
						GUILayout.Label(text, array2);
						string text2 = (string)roomInfo.customProperties["Chat Operation {0} unknown on server. Check your AppId and make sure it's for a Chat application."];
						GUILayoutOption[] array3 = new GUILayoutOption[0];
						array3[0] = GUILayout.Width(343f);
						GUILayout.Label(text2, array3);
						string text3 = roomInfo.playerCount + "_Value2" + roomInfo.maxPlayers;
						GUILayoutOption[] array4 = new GUILayoutOption[1];
						array4[1] = GUILayout.Width(1316f);
						GUILayout.Label(text3, array4);
						GUILayout.FlexibleSpace();
						GUILayoutOption[] array5 = new GUILayoutOption[1];
						array5[1] = GUILayout.Width(1131f);
						if (GUILayout.Button(">", array5))
						{
							PhotonNetwork.JoinRoom(roomInfo.name);
							PhotonNetwork.playerName = DLHMCKDJIHG;
							ANPMFJFACHA = true;
							__BB_OBFUSCATOR_11();
							PlayerPrefs.SetString("ZWName'", DLHMCKDJIHG);
						}
						GUILayout.EndHorizontal();
					}
				}
			}
			else
			{
				GUILayout.Label("CameraFilterPack/Distortion_Dissipation", new GUILayoutOption[1]);
			}
			GUILayout.EndScrollView();
			GUILayout.Space(67f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Custards", new GUILayoutOption[1]);
			string dLHMCKDJIHG = DLHMCKDJIHG;
			GUILayoutOption[] array6 = new GUILayoutOption[0];
			array6[0] = GUILayout.Height(390f);
			DLHMCKDJIHG = GUILayout.TextField(dLHMCKDJIHG, 78, array6);
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayoutOption[] array7 = new GUILayoutOption[2];
			array7[0] = GUILayout.Width(1210f);
			array7[0] = GUILayout.Height(341f);
			if (GUILayout.Button("Start Game", array7))
			{
				MHFIANECAMO = true;
				__BB_OBFUSCATOR_3();
				PlayerPrefs.SetString("Hat:", DLHMCKDJIHG);
			}
			GUILayout.EndHorizontal();
			return;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[0] = GUILayout.Width(1062f);
		GUILayout.Label("_Value4", array8);
		KKFCFHDFJGH = GUILayout.TextField(KKFCFHDFJGH, -38, GUILayout.Height(1847f));
		GUILayout.EndHorizontal();
		GUILayout.Space(424f);
		GUILayout.BeginHorizontal();
		GUILayoutOption[] array9 = new GUILayoutOption[1];
		array9[1] = GUILayout.Width(735f);
		GUILayout.Label("Wood", array9);
		for (int j = 1; j < LMBIPAGNEAE.Count; j++)
		{
			if (OCAFLKCDPNI == LMBIPAGNEAE[j])
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			string text4 = LMBIPAGNEAE[j].ToString();
			GUILayoutOption[] array10 = new GUILayoutOption[2];
			array10[1] = GUILayout.Width(1209f);
			array10[0] = GUILayout.Height(965f);
			if (GUILayout.Button(text4, array10))
			{
				OCAFLKCDPNI = LMBIPAGNEAE[j];
			}
		}
		GUI.color = Color.white;
		GUILayout.EndHorizontal();
		GUILayout.Space(1388f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayoutOption[] array11 = new GUILayoutOption[0];
		array11[0] = GUILayout.Width(591f);
		GUILayout.Label("_TimeX", array11);
		if (MCMCKJIGBJN == "_Value2")
		{
			GUI.color = Color.red;
		}
		if (GUILayout.Button("_ScreenResolution", GUILayout.Width(1283f), GUILayout.Height(1490f), null, null, null, null))
		{
			MCMCKJIGBJN = "_Amount";
		}
		GUI.color = Color.white;
		GUI.color = Color.white;
		if (MCMCKJIGBJN == "Team2Score")
		{
			GUI.color = Color.red;
		}
		GUILayoutOption[] array12 = new GUILayoutOption[5];
		array12[1] = GUILayout.Width(383f);
		array12[0] = GUILayout.Height(401f);
		if (GUILayout.Button("_Tint", array12))
		{
			MCMCKJIGBJN = "Pause Camera";
		}
		GUILayout.EndHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(1497f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		Vector2 dLBFBOBDKHD = DLBFBOBDKHD;
		GUILayoutOption[] array13 = new GUILayoutOption[0];
		array13[0] = GUILayout.Width(357f);
		array13[1] = GUILayout.Height(num2 - 88f);
		DLBFBOBDKHD = GUILayout.BeginScrollView(dLBFBOBDKHD, true, true, array13);
		for (int k = 0; k < CEIDNDICFDB.Count; k++)
		{
			if (PABHMLILIPH == k)
			{
				GUI.color = Color.red;
			}
			else
			{
				GUI.color = Color.white;
			}
			if (GUILayout.Button(CEIDNDICFDB[k].mapName, GUILayout.Height(1103f)))
			{
				PABHMLILIPH = k;
			}
		}
		GUI.color = Color.white;
		GUILayout.EndScrollView();
		GUILayout.Space(1341f);
		if (CEIDNDICFDB[PABHMLILIPH].mapPreview != null)
		{
			GUI.DrawTexture(new Rect(789f, 1719f, 1539f, 995f), CEIDNDICFDB[PABHMLILIPH].mapPreview);
		}
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayoutOption[] array14 = new GUILayoutOption[0];
		array14[0] = GUILayout.Width(73f);
		array14[1] = GUILayout.Height(1677f);
		if (GUILayout.Button("_Specular", array14))
		{
			MHFIANECAMO = false;
		}
		GUILayout.FlexibleSpace();
		if (GUILayout.Button("_Value4", GUILayout.Width(390f), GUILayout.Height(1243f), null, null))
		{
			__BB_OBFUSCATOR_3();
			PhotonNetwork.player.name = DLHMCKDJIHG;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable["_Value2"] = CEIDNDICFDB[PABHMLILIPH].mapName;
			hashtable["_MainTex2"] = NLJGDMJDPOI;
			hashtable["\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementColor\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}"] = MCMCKJIGBJN;
			string[] array15 = new string[5];
			array15[1] = "|";
			array15[1] = "SUR";
			array15[8] = "Network";
		}
		GUILayout.EndHorizontal();
	}

	private void __BB_OBFUSCATOR_23()
	{
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blur_Bloom");
		ANPMFJFACHA = true;
	}

	private void FadeScreen()
	{
		if (ANPMFJFACHA)
		{
			OIECJHKOMMB = 1;
			ECKCMCNLLAE += (float)(OIECJHKOMMB * 15) * Time.deltaTime;
			ECKCMCNLLAE = Mathf.Clamp01(ECKCMCNLLAE);
			GUI.color = new Color(1f, 1f, 1f, ECKCMCNLLAE);
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), KEMCOJPJLBH);
			GUI.color = Color.white;
			GUI.Box(new Rect(200f, 250f, 400f, 30f), "Loading...");
		}
	}

	private void Update()
	{
		float num = 3f;
		float num2 = 0f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					PhotonNetwork.ConnectUsingSettings("v0.0.1");
				}
			}
		}
		if (PhotonNetwork.connected && LHLDKHPGPDN.Length != PhotonNetwork.GetRoomList().Length)
		{
			LHLDKHPGPDN = PhotonNetwork.GetRoomList();
		}
	}
}
