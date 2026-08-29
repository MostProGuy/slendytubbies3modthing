using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Photon;
using TranslatorSystem;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class RoomMultiplayerMenu : Photon.MonoBehaviour
{
	[Serializable]
	public class AllTeams
	{
		[HideInInspector]
		public string teamName;

		public Transform[] spawnPoints;
	}

	public Transform MJCELHFPMIO;

	public GUISkin NMOHLIAHHDP;

	public GameObject DIGNDDCKDMD;

	public Texture2D KEMCOJPJLBH;

	public GameObject AKADHELLBAD;

	public Texture2D EFOOEDHBALP;

	public bool BINGCKFFDAG;

	public AllTeams LEPLDNNHJPF;

	public AllTeams NICGOGPHBPD;

	[HideInInspector]
	public Color GFICDIOAGKG = Color.cyan;

	[HideInInspector]
	public Color BHJBBMOHLOA = Color.yellow;

	[HideInInspector]
	public bool NNLHIHKPLPI;

	private GameObject LNNNNIMMEKM;

	private bool AMNDKIKDFJG;

	private Resolution[] IJOEABKACKD;

	private string[] LLKFGGGDFHH;

	private int PJBOAKKJBBA = 3;

	private Vector2 FLHOPCJDOOP;

	private Vector2 NHMIFIFKKMK;

	private Vector2 MMBPIPDEIIF;

	public GameObject CBIFAIJOMKC;

	public bool LJGPLNGGJFJ;

	public bool disableFogHeight;

	private int OIECJHKOMMB;

	private float ECKCMCNLLAE;

	private float BMAJKINOJDH = 5f;

	private float FHAKPMBNKPO;

	private List<PhotonPlayer> JELAKNPPBNJ = new List<PhotonPlayer>();

	private List<PhotonPlayer> NMNMAOPACLB = new List<PhotonPlayer>();

	private List<Transform> HFNFBLAOGBK = new List<Transform>();

	private int NLJGDMJDPOI;

	private float IBENPLEEKCF;

	private float EMFFJKMBOCI;

	[HideInInspector]
	public string MCMCKJIGBJN;

	public bool BGGJDPLKGHO;

	private int MKDBHGCKFFB;

	private int HCILBOJAFBM;

	private string LGNGMEDLEDC = string.Empty;

	private string NMBLKILBGEE;

	private bool LEGJBPADDLP = true;

	public ObscuredString[] GPPEJCFIHFE;

	public ObscuredString[] KGPEFHHPFHL;

	public ObscuredString[] PAMKBIEEBJF;

	public ObscuredString[] AFNGLPAEAMK;

	public ObscuredString[] DCKJFGMJLNA;

	private string ALFCKFOBFNK = "Restarting";

	private bool GMPDMDIBNIA;

	private bool DDEKFMEOIMP;

	private float FLILCEACBEB;

	private float NGJIHPNEADO;

	public bool JAFLIDKMIAJ;

	public bool NLIONFPDGID;

	private string LLKFPBAABNA = " wins";

	private string MLLBJHEMJHH = "Time is up";

	private string DICPGAJACNP = "All custards have been found...";

	private string BJKBPLHAGBN = "All players have been killed...";

	private string OLDCIHOMHKC = "Your team survived";

	private string NCABKGFODDD = "All players have been infected...";

	private string GOICOMEAEEJ = "survivors win";

	private string IAHFDMKMCHO = "Waiting for more players...";

	private string KDGKFHKIGIN = "You Are Infected ";

	private string OIHFFOHJOKI = "Fight Off Infected To win";

	private string HKKLFNJLKKJ = "Resume";

	private string PHMMHLNDGOL = "Quit";

	private string KGDIIJANLEJ = "Paused";

	private string HEODPGGMMBJ = "Kills";

	private string JDDMENCDIFB = "Deaths";

	private string NLMMCFAJEGP = "Loading";

	private bool EKJDPEJOOCN;

	private float ALBNNCJGMHN;

	private string NFJFMOAGEIL = " is in the lead";

	private bool EHBONAIACOB;

	private string MKIMIEFMMNF = "Flashlight";

	private string EDAPMHEFPMM = "Camera";

	private bool AKEDGMFGOKI;

	public bool BNNOMCKIGLL;

	[CompilerGenerated]
	private static Converter<GameObject, Transform> NCBIMIMMADO;

	[CompilerGenerated]
	private static Converter<GameObject, Transform> ENPJJJBJGNE;

	[CompilerGenerated]
	private static Comparison<PhotonPlayer> HHCJILIGHNK;

	[CompilerGenerated]
	private static Comparison<PhotonPlayer> IGMBDDCFGFG;

	private void Update()
	{
		if (!ObscuredPrefs.HasKey("ZWName'") && !PhotonNetwork.playerName.ToLower().Contains("player"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (ObscuredPrefs.HasKey("ZWName'") && PhotonNetwork.playerName != ObscuredPrefs.GetString("ZWName'"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (GameObject.FindWithTag("Menu") != null || NNLHIHKPLPI)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			NNLHIHKPLPI = !NNLHIHKPLPI;
		}
		if (NNLHIHKPLPI)
		{
			if (LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(true);
			}
		}
		else
		{
			if (!LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(true);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(false);
			}
		}
		if (Time.time - BMAJKINOJDH > FHAKPMBNKPO)
		{
			FHAKPMBNKPO = Time.time - Time.deltaTime;
		}
		while (FHAKPMBNKPO < Time.time)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Ping", PhotonNetwork.GetPing());
			ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet);
			FHAKPMBNKPO += BMAJKINOJDH;
		}
		if (LJGPLNGGJFJ && Camera.main != null && Camera.main.GetComponent<GlobalFog>() == null)
		{
			Camera.main.gameObject.AddComponent<GlobalFog>();
			Camera.main.GetComponent<GlobalFog>().fogShader = Shader.Find("Hidden/GlobalFog");
			Camera.main.GetComponent<GlobalFog>().heightFog = !disableFogHeight;
		}
		string @string = ObscuredPrefs.GetString("PlayerType'");
		if (JELAKNPPBNJ == null || (!(@string == "8") && !(@string != "3") && !(@string == "6")))
		{
			return;
		}
		string text = string.Empty;
		for (int i = 0; i < JELAKNPPBNJ.Count; i++)
		{
			if (JELAKNPPBNJ[i] != PhotonNetwork.player)
			{
				text = text + JELAKNPPBNJ[i].NickName + "\n";
			}
		}
		ObscuredPrefs.SetString("PlayerNames", text);
	}

	public void __BB_OBFUSCATOR_9(string HKEPPNAHBOG)
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		if (HKEPPNAHBOG == string.Empty)
		{
			HKEPPNAHBOG = LEPLDNNHJPF.teamName;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("_TimeX", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
		if (HKEPPNAHBOG == LEPLDNNHJPF.teamName)
		{
			if (MCMCKJIGBJN == "mm)")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_NoisePerChannel")
			{
				ObscuredPrefs.SetInt("Make sure to set the collision layers to the layers the camera should collide with!", 107);
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_TimeX")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_Value3")
			{
				int num = UnityEngine.Random.Range(1, HFNFBLAOGBK.Count);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[num].position, HFNFBLAOGBK[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "Wave ")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "Dead")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
				ALBNNCJGMHN = 5f;
			}
			if (MCMCKJIGBJN == "SyncWeaponsRPC")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		else
		{
			if (MCMCKJIGBJN == "Metal")
			{
				int num = UnityEngine.Random.Range(0, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("_ScreenResolution" + GetComponent<ClassicMechanics>().POIMFLJFADK, NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "Type")
			{
				int num = UnityEngine.Random.Range(1, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("Loading complete", NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		AKADHELLBAD.SetActive(false);
	}

	private void __BB_OBFUSCATOR_3(int ANFLNMCPNFK)
	{
		GUI.FocusWindow(ANFLNMCPNFK);
		GUILayout.Space(1815f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.color = Color.white;
		GUILayout.Space(1717f);
		GUILayout.BeginVertical();
		GUI.enabled = true;
		if ((bool)CBIFAIJOMKC && GUILayout.Button(HKKLFNJLKKJ))
		{
			NNLHIHKPLPI = false;
		}
		if (GUILayout.Button(PHMMHLNDGOL))
		{
			__BB_OBFUSCATOR_5();
		}
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.Space(1637f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		if (AMNDKIKDFJG)
		{
			GUI.color = new Color(1670f, 1771f, 1104f, 474f);
		}
		else
		{
			GUI.color = Color.white;
		}
		AMNDKIKDFJG = false;
		if (!AMNDKIKDFJG)
		{
			GUI.color = new Color(1635f, 1376f, 1580f, 1781f);
		}
		else
		{
			GUI.color = Color.white;
		}
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item in JELAKNPPBNJ)
		{
			if (item.CustomProperties["_TimeX"] == null)
			{
				return;
			}
		}
		GUILayout.Space(614f);
		GUI.color = Color.white;
		MMBPIPDEIIF = GUILayout.BeginScrollView(MMBPIPDEIIF, GUILayout.Width(285f), GUILayout.Height(232f));
		GUI.color = new Color(707f, 1791f, 310f, 1484f);
		if (MCMCKJIGBJN == "PrimaryCausticsProjector")
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUI.color = GFICDIOAGKG;
			GUILayout.Label("\t}\n");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item2 in JELAKNPPBNJ)
			{
				if ((string)item2.customProperties["_Value4"] == LEPLDNNHJPF.teamName)
				{
					if (PhotonNetwork.player.name == item2.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("CameraFilterPack/Edge_Edge_filter");
					string text = item2.name;
					GUILayoutOption[] array = new GUILayoutOption[1];
					array[1] = GUILayout.Width(650f);
					GUILayout.Label(text, array);
					string text2 = HEODPGGMMBJ + "_Bullet_4" + (int)item2.customProperties["ZWName'"];
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(899f);
					GUILayout.Label(text2, array2);
					string text3 = JDDMENCDIFB + "CameraFilterPack/FX_Grid" + (int)item2.customProperties["NextFrame"];
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1762f);
					GUILayout.Label(text3, array3);
					GUILayout.FlexibleSpace();
					if (item2.customProperties["_Value"] != null)
					{
						GUILayout.Label("_SmoothEnd" + (int)item2.customProperties["CameraFilterPack/Gradients_NeonGradient"]);
					}
					GUILayout.EndHorizontal();
				}
			}
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label("_Distortion", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item3 in JELAKNPPBNJ)
			{
				if ((string)item3.customProperties["\"Deformer::Skin "] == NICGOGPHBPD.teamName)
				{
					if (PhotonNetwork.player.name == item3.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("Indexes", new GUILayoutOption[1]);
					GUILayout.Label(item3.name, GUILayout.Width(78f));
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(1664f);
					GUILayout.Label("TeamName", array4);
					string text4 = JDDMENCDIFB + "CameraFilterPack/Drawing_EnhancedComics" + (int)item3.customProperties["\tModel: \"Model::"];
					GUILayoutOption[] array5 = new GUILayoutOption[1];
					array5[1] = GUILayout.Width(416f);
					GUILayout.Label(text4, array5);
					GUILayout.FlexibleSpace();
					if (item3.customProperties["INF"] != null)
					{
						GUILayout.Label("\\xAu4YW5QzfD2KQjV" + (int)item3.customProperties["red"]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		else
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUI.color = Color.cyan;
			GUILayout.Label("_MainTex", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item4 in JELAKNPPBNJ)
			{
				if ((string)item4.customProperties["HeadURL"] != "_ScreenResolution")
				{
					if (PhotonNetwork.player.name == item4.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("HostQuit");
					string text5 = item4.name;
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[1] = GUILayout.Width(1498f);
					GUILayout.Label(text5, array6);
					if (MCMCKJIGBJN != "\n")
					{
						string text6 = HEODPGGMMBJ + "_PositionY" + (int)item4.customProperties["\r\n|\r|\n"];
						GUILayoutOption[] array7 = new GUILayoutOption[0];
						array7[0] = GUILayout.Width(138f);
						GUILayout.Label(text6, array7);
					}
					GUILayout.Label(JDDMENCDIFB + "_TimeX" + (int)item4.customProperties["CameraFilterPack/Blur_Noise"], GUILayout.Width(1986f));
					GUILayout.FlexibleSpace();
					if (item4.customProperties["FlyCam"] != null)
					{
						GUILayout.Label("Glow" + (int)item4.customProperties["_TimeX"]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUI.color = Color.grey;
		GUILayout.Label("Can't set TransportProtocol. Disconnect first! ", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item5 in JELAKNPPBNJ)
		{
			if ((string)item5.customProperties["Aim"] == "\n\t\t}\n\t\tMultiLayer: 0\n\t\tCulling: \"CullingOff\"\n\t\tTypeFlags: \"Skeleton\"\n\t}\n")
			{
				if (PhotonNetwork.player.name == item5.name)
				{
					GUI.color = Color.green;
				}
				else
				{
					GUI.color = Color.white;
				}
				GUILayout.BeginHorizontal("_Value", new GUILayoutOption[1]);
				GUILayout.Label(item5.name);
				GUILayout.FlexibleSpace();
				if (item5.customProperties["Mirror "] != null)
				{
					GUILayout.Label("Team1Score" + (int)item5.customProperties["MP"], new GUILayoutOption[1]);
				}
				GUILayout.EndHorizontal();
			}
		}
		GUILayout.EndScrollView();
	}

	private void Start()
	{
		if (PhotonNetwork.isMasterClient && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.room.IsOpen = true;
			PhotonNetwork.room.IsVisible = !ObscuredPrefs.GetBool("Private");
		}
		if (MCMCKJIGBJN == "SBX" && PhotonNetwork.isMasterClient)
		{
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("Sandbox", base.transform.position, base.transform.rotation, 0, null);
		}
	}

	[CompilerGenerated]
	private static Transform _003CAwake_003Em__1(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_20()
	{
		GUILayout.BeginVertical();
		GUI.color = Color.white;
		GUILayout.Label("_Value");
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[8];
		array[0] = GUILayout.Width(246f);
		array[0] = GUILayout.Height(1737f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1122f, 678f, 235f, 652f);
			}
			else
			{
				GUI.color = new Color(255f, 485f, 120f, 177f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i]))
			{
				QualitySettings.SetQualityLevel(i, true);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_22()
	{
		BGGJDPLKGHO = false;
		NLIONFPDGID = false;
		StartCoroutine(__BB_OBFUSCATOR_39());
	}

	private IEnumerator __BB_OBFUSCATOR_52()
	{
		LEGJBPADDLP = true;
		yield return new WaitForSeconds(0.3f);
		LEGJBPADDLP = false;
	}

	public void __BB_OBFUSCATOR_42(string HKEPPNAHBOG)
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		if (HKEPPNAHBOG == string.Empty)
		{
			HKEPPNAHBOG = LEPLDNNHJPF.teamName;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("_Level", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		if (HKEPPNAHBOG == LEPLDNNHJPF.teamName)
		{
			if (MCMCKJIGBJN == "TeamTag")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "name")
			{
				ObscuredPrefs.SetInt("_Blue_B", 130);
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_Specular")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "*")
			{
				int num = UnityEngine.Random.Range(1, HFNFBLAOGBK.Count);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[num].position, HFNFBLAOGBK[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_TimeX")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_Offsets")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
				ALBNNCJGMHN = 1027f;
			}
			if (MCMCKJIGBJN == "_CenterX")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		else
		{
			if (MCMCKJIGBJN == "Detonator/Textures/Smoke")
			{
				int num = UnityEngine.Random.Range(1, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("_Transparency" + GetComponent<ClassicMechanics>().POIMFLJFADK, NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "\\s3key.txt")
			{
				int num = UnityEngine.Random.Range(0, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("_Value5", NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		AKADHELLBAD.SetActive(true);
	}

	private void __BB_OBFUSCATOR_33()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(322f, 1168f, 1040f, 1949f);
		if (NNLHIHKPLPI)
		{
			GUI.color = new Color(1968f, 1309f, 1711f, 1543f);
			GUI.Window(0, new Rect(Screen.width / 1 - 37, Screen.height / 2 - -187, 505f, 1586f), __BB_OBFUSCATOR_50, KGDIIJANLEJ);
			GUILayout.Space(1927f);
			string @string = ObscuredPrefs.GetString("_ScreenResolution");
			if (JELAKNPPBNJ != null)
			{
				for (int i = 1; i < JELAKNPPBNJ.Count; i++)
				{
					PhotonPlayer photonPlayer = JELAKNPPBNJ[i];
					if (!PhotonNetwork.isMasterClient)
					{
						switch (@string)
						{
						case "CameraFilterPack/TV_Rgb":
						case ", position = ":
						case "team1":
							break;
						default:
							continue;
						}
					}
					if (photonPlayer == PhotonNetwork.player)
					{
						if (GUI.Button(new Rect(457f, 47 + 60 * i, 1608f, 1909f), "_TimeX" + photonPlayer.NickName + "_CurTex"))
						{
							base.photonView.RPC("\\Microsoft\\WordPad\\Wor96BA.tmp", photonPlayer, new object[1]);
						}
					}
					else if (GUI.Button(new Rect(865f, -22 + 41 * i, 1874f, 1171f), "," + photonPlayer.NickName + "offsets"))
					{
						base.photonView.RPC("RespawnPlayer2", photonPlayer);
					}
				}
			}
		}
		float num = Mathf.CeilToInt(EMFFJKMBOCI);
		int num2 = Mathf.FloorToInt(num % 550f);
		int num3 = Mathf.FloorToInt(num / 1770f % 685f);
		string text = string.Format("_ColorLevel", num3, num2);
		if (MCMCKJIGBJN != "n15" && MCMCKJIGBJN != "Join")
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle(": ");
			int num4 = Screen.height / 125;
			gUIStyle.alignment = TextAnchor.UpperRight;
			if (DDEKFMEOIMP)
			{
				text = IAHFDMKMCHO;
			}
			Rect pLGJJIBFGFL = new Rect(1344f, 716f, Screen.width, num4);
			string[] array = new string[5];
			array[1] = "_Value4";
			array[0] = ((float)num4 / 1491f).ToString();
			array[8] = "Fire";
			array[3] = text;
			array[1] = "Login";
			DrawOutline(pLGJJIBFGFL, string.Concat(array), 0, gUIStyle);
		}
		if (MCMCKJIGBJN == "[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ")
		{
			GUILayout.BeginArea(new Rect(Screen.width / 0 - 99, 1419f, 1761f, 1654f));
			GUIStyle style = "MapName";
			GUILayoutOption[] array2 = new GUILayoutOption[1];
			array2[0] = GUILayout.Width(528f);
			array2[0] = GUILayout.Height(1374f);
			GUILayout.BeginHorizontal(style, array2);
			GUI.color = GFICDIOAGKG;
			GUILayout.Label(LEPLDNNHJPF.teamName + "_Value");
			GUILayout.Space(1007f);
			GUI.color = Color.white;
			GUILayout.Label(MKDBHGCKFFB.ToString());
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(Screen.width - Screen.width / 6 - -114, 61f, 1204f, 1120f));
			GUILayout.BeginHorizontal("Can't authenticate on front end server. Authentication Values are not set", GUILayout.Width(1502f), GUILayout.Height(100f), null, null, null, null, null);
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label(NICGOGPHBPD.teamName + "_Intensity", new GUILayoutOption[1]);
			GUILayout.Space(208f);
			GUI.color = Color.white;
			GUILayout.Label(HCILBOJAFBM.ToString());
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}
		if (MCMCKJIGBJN == "_Overlay" && !BGGJDPLKGHO && NMBLKILBGEE.Length > 6)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle2 = new GUIStyle();
			gUIStyle2 = GUI.skin.GetStyle("\\Microsoft\\WordPad\\Wor96BA.tmp");
			int num5 = Screen.height / 2;
			Rect pLGJJIBFGFL2 = new Rect(1311f, 106 + num5, Screen.width, num5);
			string[] array3 = new string[2];
			array3[0] = "_ScreenResolution";
			array3[0] = ((float)num5 / 349f).ToString();
			array3[5] = "Creator: \"EJM Software FBX Exporter\"";
			array3[0] = NMBLKILBGEE;
			array3[7] = NFJFMOAGEIL;
			array3[4] = "5";
			DrawOutline(pLGJJIBFGFL2, string.Concat(array3), 1, gUIStyle2);
		}
		if (MCMCKJIGBJN == "_ScreenResolution" && !BGGJDPLKGHO && !DDEKFMEOIMP && NMBLKILBGEE.Length > 4)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle3 = new GUIStyle();
			gUIStyle3 = GUI.skin.GetStyle("Camera");
			int num6 = Screen.height / -68;
			Rect pLGJJIBFGFL3 = new Rect(1237f, -85 + num6, Screen.width, num6);
			string[] array4 = new string[6];
			array4[0] = "_Alpha";
			array4[0] = ((float)num6 / 449f).ToString();
			array4[8] = "_SpotSize";
			array4[8] = NMBLKILBGEE;
			array4[7] = NFJFMOAGEIL;
			array4[8] = "_Value";
			DrawOutline(pLGJJIBFGFL3, string.Concat(array4), 0, gUIStyle3);
		}
		if (MCMCKJIGBJN == "Ping: ")
		{
			GUIStyle gUIStyle4 = new GUIStyle();
			gUIStyle4 = GUI.skin.GetStyle("Horizontal");
			gUIStyle4.alignment = TextAnchor.MiddleRight;
			DrawOutline(new Rect(Screen.width - 75, Screen.height - 91, 127f, 1449f), "_BorderSize" + ObscuredPrefs.GetInt("DoDamage") + "<size=25>", 0, gUIStyle4);
			GUI.DrawTexture(new Rect(Screen.width - 192, Screen.height - -111, 613f, 348f), EFOOEDHBALP);
		}
		if (MCMCKJIGBJN == "</size>" && (string)PhotonNetwork.player.customProperties[">"] == NICGOGPHBPD.teamName)
		{
			GUIStyle gUIStyle5 = new GUIStyle();
			gUIStyle5 = GUI.skin.GetStyle("_TimeX");
			int num7 = Screen.height / 121;
			gUIStyle5.alignment = TextAnchor.UpperLeft;
			Rect position = new Rect(1684f, Screen.height - num7, Screen.width, num7);
			string[] array5 = new string[0];
			array5[0] = "RespawnPlayers";
			array5[0] = ((float)num7 / 1756f).ToString();
			array5[4] = "Knife";
			array5[3] = KDGKFHKIGIN;
			array5[0] = "Horizontal";
			GUI.Label(position, string.Concat(array5), gUIStyle5);
			GUI.color = Color.white;
		}
		if (ALBNNCJGMHN < 1372f && MCMCKJIGBJN == "_NoiseAmount" && (string)PhotonNetwork.player.customProperties["_TimeX"] == LEPLDNNHJPF.teamName)
		{
			GUIStyle gUIStyle6 = new GUIStyle();
			gUIStyle6 = GUI.skin.GetStyle("CameraFilterPack/Gradients_Desert");
			int num8 = Screen.height / 97;
			gUIStyle6.alignment = TextAnchor.LowerRight;
			Rect position2 = new Rect(1998f, Screen.height - num8 - 3, Screen.width, num8);
			string[] array6 = new string[7];
			array6[1] = "Particles/Alpha Blended";
			array6[0] = ((float)num8 / 1319f).ToString();
			array6[4] = "*";
			array6[8] = OIHFFOHJOKI;
			array6[5] = "INF";
			GUI.Label(position2, string.Concat(array6), gUIStyle6);
			ALBNNCJGMHN += 520f * Time.deltaTime;
		}
		GUI.color = Color.white;
		if (BGGJDPLKGHO)
		{
			GUIStyle gUIStyle7 = new GUIStyle();
			gUIStyle7 = GUI.skin.GetStyle("Restarted");
			gUIStyle7.alignment = TextAnchor.UpperRight;
			int num9 = Screen.height / 20;
			Rect pLGJJIBFGFL4 = new Rect(179f, Screen.height / 1, Screen.width, num9);
			string[] array7 = new string[7];
			array7[0] = "_Value4";
			array7[1] = ((float)num9 / 1952f).ToString();
			array7[1] = "MP";
			array7[6] = LGNGMEDLEDC;
			array7[1] = "_ScreenResolution";
			DrawOutline(pLGJJIBFGFL4, string.Concat(array7), 1, gUIStyle7);
			if (MCMCKJIGBJN == "\n\t\t}")
			{
				Rect pLGJJIBFGFL5 = new Rect(819f, Screen.height / 7 - num9, Screen.width, num9);
				string[] array8 = new string[2];
				array8[1] = "_Value2";
				array8[1] = ((float)num9 / 1427f).ToString();
				array8[5] = "Ping: ";
				array8[3] = ALFCKFOBFNK;
				array8[1] = "Sandbox";
				DrawOutline(pLGJJIBFGFL5, string.Concat(array8), 1, gUIStyle7);
			}
		}
		FadeScreen();
	}

	private void __BB_OBFUSCATOR_58()
	{
		UnityEngine.MonoBehaviour.print("&");
		NNLHIHKPLPI = false;
		AKADHELLBAD.SetActive(false);
		StartCoroutine(LoadMap("_Red_B"));
	}

	private static int __BB_OBFUSCATOR_34(PhotonPlayer ILLBDLKGDHL, PhotonPlayer KJMNNCFPILK)
	{
		if (KJMNNCFPILK.customProperties["|"] != null && ILLBDLKGDHL.customProperties["VS"] != null)
		{
			return (int)KJMNNCFPILK.customProperties["Ping"] - (int)ILLBDLKGDHL.customProperties["Next"];
		}
		return 1;
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "_Value" || MCMCKJIGBJN == "<size=15>Press 1, 2, 3 Key to change strength of rain</size>")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			foreach (PhotonPlayer item in playerList)
			{
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = __BB_OBFUSCATOR_34;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[1].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == "CameraFilterPack_VHS2")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["Team1Score"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = __BB_OBFUSCATOR_57;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 0)
				{
					NMBLKILBGEE = NMNMAOPACLB[1].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 764f * Time.deltaTime;
					if (FLILCEACBEB > 1265f)
					{
						base.photonView.RPC("Password", PhotonNetwork.player);
						FLILCEACBEB = 452f;
					}
				}
				else
				{
					FLILCEACBEB = 1599f;
				}
			}
		}
		if (MCMCKJIGBJN != "Deaths" && MCMCKJIGBJN != "SUR" && !LEGJBPADDLP)
		{
			float num = 918f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 925f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 62f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 866f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(__BB_OBFUSCATOR_39());
					NNLHIHKPLPI = true;
					BGGJDPLKGHO = true;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["_TimeX"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties[": "];
		}
		if (MCMCKJIGBJN == "Team2Score" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "Shop")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			__BB_OBFUSCATOR_9(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "Tenkoku DynamicSky" || MCMCKJIGBJN == "  ")
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				DDEKFMEOIMP = false;
				GMPDMDIBNIA = true;
			}
			else
			{
				DDEKFMEOIMP = false;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "\t}\n")
				{
					__BB_OBFUSCATOR_14();
				}
				GMPDMDIBNIA = true;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == " x ")
			{
				__BB_OBFUSCATOR_42(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "colorC" || EDAPMHEFPMM != "offsets")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == "images/default_avatar.png") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 729f * Time.deltaTime;
			if (NGJIHPNEADO > 1374f)
			{
				checkInfectionWin();
			}
		}
		else
		{
			NGJIHPNEADO = 1587f;
		}
	}

	private void InfectRandomPlayer()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			int num = 1;
			if (playerList.Length > 6)
			{
				num = 2;
			}
			if (playerList.Length > 9)
			{
				num = 3;
			}
			if (playerList.Length > 11)
			{
				num = 4;
			}
			for (int i = 0; i < num; i++)
			{
				int num2 = UnityEngine.Random.Range(0, playerList.Length);
				base.photonView.RPC("Infect", playerList[num2]);
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
	}

	[PunRPC]
	private void InfectedWin()
	{
		BGGJDPLKGHO = true;
		NLIONFPDGID = true;
		StartCoroutine(RoundEnded());
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "SyncTeamName" || MCMCKJIGBJN == "CustomSkin")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i++)
			{
				PhotonPlayer item = playerList[i];
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = __BB_OBFUSCATOR_48;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[0].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == "Survival")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["HatList"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = __BB_OBFUSCATOR_48;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 1)
				{
					NMBLKILBGEE = NMNMAOPACLB[0].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 449f * Time.deltaTime;
					if (FLILCEACBEB > 1433f)
					{
						base.photonView.RPC("offsets", PhotonNetwork.player);
						FLILCEACBEB = 21f;
					}
				}
				else
				{
					FLILCEACBEB = 1148f;
				}
			}
		}
		if (MCMCKJIGBJN != "Horizontal" && MCMCKJIGBJN != "_Alpha" && !LEGJBPADDLP)
		{
			float num = 1247f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 1047f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 1630f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 1474f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(RoundEnded());
					NNLHIHKPLPI = true;
					BGGJDPLKGHO = false;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["_Value3"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties["</size> <color=red>/</color> "];
		}
		if (MCMCKJIGBJN == "_Value" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "_DepthFade")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			SpawnPlayer(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "Language" || MCMCKJIGBJN == "RefTime")
		{
			if (PhotonNetwork.playerList.Length < 5)
			{
				DDEKFMEOIMP = true;
				GMPDMDIBNIA = false;
			}
			else
			{
				DDEKFMEOIMP = false;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "</size>")
				{
					InfectRandomPlayer();
				}
				GMPDMDIBNIA = false;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == "\n\t\tLayer: 1 {\n\t\t\tVersion: 100\n\t\t\tLayerElement:  {\n\t\t\t\ttype: \"LayerElementUV\"\n\t\t\t\tTypedIndex: 1\n\t\t\t}\n\t\t}")
			{
				__BB_OBFUSCATOR_9(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "ns.exitgames.com" || EDAPMHEFPMM != "DM")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == "Say: ") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 1116f * Time.deltaTime;
			if (NGJIHPNEADO > 1710f)
			{
				checkInfectionWin();
			}
		}
		else
		{
			NGJIHPNEADO = 1650f;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		GMPDMDIBNIA = false;
		if (ObscuredPrefs.GetBool("-Current Clip Name: "))
		{
			ObscuredString[] array = new ObscuredString[0];
			array[0] = "_Value4";
			KGPEFHHPFHL = array;
		}
		else
		{
			ObscuredString[] array2 = new ObscuredString[1];
			array2[1] = "Player";
			KGPEFHHPFHL = array2;
		}
		if (MCMCKJIGBJN == "SELF")
		{
			GMPDMDIBNIA = false;
			GPPEJCFIHFE = PAMKBIEEBJF;
			SpawnPlayer(LEPLDNNHJPF.teamName);
			GUI.enabled = true;
			GetComponent<SurvivalMechanics>().enabled = true;
			NNLHIHKPLPI = true;
		}
		if (MCMCKJIGBJN == "_Value2")
		{
			GMPDMDIBNIA = true;
			GPPEJCFIHFE = KGPEFHHPFHL;
			__BB_OBFUSCATOR_9(LEPLDNNHJPF.teamName);
			GUI.enabled = false;
			GetComponent<ClassicMechanics>().enabled = true;
			NNLHIHKPLPI = true;
		}
		if (MCMCKJIGBJN == "TeamName")
		{
			GPPEJCFIHFE = KGPEFHHPFHL;
			if (PhotonNetwork.isMasterClient)
			{
				__BB_OBFUSCATOR_42(LEPLDNNHJPF.teamName);
			}
			else
			{
				__BB_OBFUSCATOR_17(LEPLDNNHJPF.teamName);
			}
			GUI.enabled = false;
			GetComponent<ClassicMechanics>().enabled = true;
			NNLHIHKPLPI = false;
		}
		if (MCMCKJIGBJN == "CameraFilterPack/FX_Spot")
		{
			GPPEJCFIHFE = AFNGLPAEAMK;
			if (EKJDPEJOOCN)
			{
				__BB_OBFUSCATOR_9(NICGOGPHBPD.teamName);
			}
			else
			{
				SpawnPlayer(LEPLDNNHJPF.teamName);
			}
			GUI.enabled = true;
			NNLHIHKPLPI = true;
		}
		if (MCMCKJIGBJN == "password")
		{
			GPPEJCFIHFE = DCKJFGMJLNA;
			__BB_OBFUSCATOR_9(LEPLDNNHJPF.teamName);
		}
		if (MCMCKJIGBJN == "Space - jump")
		{
			GMPDMDIBNIA = true;
			GPPEJCFIHFE = PAMKBIEEBJF;
			__BB_OBFUSCATOR_42(LEPLDNNHJPF.teamName);
			GUI.enabled = true;
			NNLHIHKPLPI = true;
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (!ObscuredPrefs.HasKey("spawn") && !PhotonNetwork.playerName.ToLower().Contains("CameraFilterPack/TV_CompressionFX"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (ObscuredPrefs.HasKey("_Value") && PhotonNetwork.playerName != ObscuredPrefs.GetString("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls."))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (GameObject.FindWithTag("_Quality") != null || NNLHIHKPLPI)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}
		if (Input.GetKeyDown((KeyCode)(-128)))
		{
			NNLHIHKPLPI = NNLHIHKPLPI;
		}
		if (NNLHIHKPLPI)
		{
			if (LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(true);
			}
		}
		else
		{
			if (!LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(true);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(false);
			}
		}
		if (Time.time - BMAJKINOJDH > FHAKPMBNKPO)
		{
			FHAKPMBNKPO = Time.time - Time.deltaTime;
		}
		while (FHAKPMBNKPO < Time.time)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("<size=", PhotonNetwork.GetPing());
			ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet);
			FHAKPMBNKPO += BMAJKINOJDH;
		}
		if (LJGPLNGGJFJ && Camera.main != null && Camera.main.GetComponent<GlobalFog>() == null)
		{
			Camera.main.gameObject.AddComponent<GlobalFog>();
			Camera.main.GetComponent<GlobalFog>().fogShader = Shader.Find("_ProjInfo");
			Camera.main.GetComponent<GlobalFog>().heightFog = disableFogHeight;
		}
		string @string = ObscuredPrefs.GetString("_SunPosition");
		if (JELAKNPPBNJ == null || (!(@string == "_TimeX") && !(@string != "Player") && !(@string == "_TapHigh")))
		{
			return;
		}
		string text = string.Empty;
		for (int i = 1; i < JELAKNPPBNJ.Count; i++)
		{
			if (JELAKNPPBNJ[i] != PhotonNetwork.player)
			{
				text = text + JELAKNPPBNJ[i].NickName + "_Value2";
			}
		}
		ObscuredPrefs.SetString("Ping: ", text);
	}

	private void __BB_OBFUSCATOR_32()
	{
		BGGJDPLKGHO = false;
		NLIONFPDGID = false;
		StartCoroutine(__BB_OBFUSCATOR_39());
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (PhotonNetwork.isMasterClient && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.room.IsOpen = true;
			PhotonNetwork.room.IsVisible = !ObscuredPrefs.GetBool("_Value2");
		}
		if (MCMCKJIGBJN == "\\Microsoft\\WordPad\\Wor96BA.tmp" && PhotonNetwork.isMasterClient)
		{
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("offsets", base.transform.position, base.transform.rotation, 1, null);
		}
	}

	private IEnumerator LoadMap(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		if (!BNNOMCKIGLL)
		{
			BNNOMCKIGLL = true;
			yield return new WaitForSeconds(1f);
			Application.backgroundLoadingPriority = ThreadPriority.High;
			yield return Application.LoadLevelAsync(LIHOALDCAHE);
			Debug.Log("Loading complete");
		}
		else
		{
			yield return new WaitForSeconds(1f);
		}
	}

	public IEnumerator RoundEnded()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = false;
		}
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["GameMode"];
		if (MCMCKJIGBJN == "TDM")
		{
			if (MKDBHGCKFFB == HCILBOJAFBM)
			{
				LGNGMEDLEDC = "Draw... Restarting";
			}
			if (MKDBHGCKFFB > HCILBOJAFBM)
			{
				LGNGMEDLEDC = LEPLDNNHJPF.teamName + LLKFPBAABNA;
			}
			if (MKDBHGCKFFB < HCILBOJAFBM)
			{
				LGNGMEDLEDC = NICGOGPHBPD.teamName + LLKFPBAABNA;
			}
		}
		if (MCMCKJIGBJN == "DM")
		{
			LGNGMEDLEDC = NMBLKILBGEE + LLKFPBAABNA;
		}
		if (MCMCKJIGBJN == "SUR")
		{
			if (!JAFLIDKMIAJ)
			{
				LGNGMEDLEDC = BJKBPLHAGBN;
			}
			else
			{
				LGNGMEDLEDC = OLDCIHOMHKC;
				if (PhotonNetwork.isMasterClient)
				{
					PhotonNetwork.room.open = false;
					PhotonNetwork.room.visible = false;
				}
				yield return new WaitForSeconds(10f);
				PhotonNetwork.LeaveRoom();
			}
		}
		if (MCMCKJIGBJN == "COOP" || MCMCKJIGBJN == "VS")
		{
			if (BGGJDPLKGHO)
			{
				if ((bool)GameObject.FindWithTag("custard"))
				{
					LGNGMEDLEDC = MLLBJHEMJHH;
					if (MCMCKJIGBJN == "VS")
					{
						LGNGMEDLEDC = MLLBJHEMJHH + ", " + PhotonNetwork.masterClient.NickName + LLKFPBAABNA;
					}
				}
				else
				{
					LGNGMEDLEDC = DICPGAJACNP;
				}
			}
			yield return new WaitForSeconds(5f);
			PhotonNetwork.LeaveRoom();
		}
		if (MCMCKJIGBJN == "INF")
		{
			EKJDPEJOOCN = false;
			if (NLIONFPDGID)
			{
				LGNGMEDLEDC = NCABKGFODDD;
			}
			else
			{
				LGNGMEDLEDC = MLLBJHEMJHH + ", " + NMBLKILBGEE + LLKFPBAABNA;
			}
		}
		yield return new WaitForSeconds(5f);
		NLIONFPDGID = false;
		StartCoroutine(Restart());
	}

	private void Awake()
	{
		if (!PhotonNetwork.connected)
		{
			Application.LoadLevel("MainMenu");
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("TeamASpawn");
		AllTeams lEPLDNNHJPF = LEPLDNNHJPF;
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003CAwake_003Em__0;
		}
		lEPLDNNHJPF.spawnPoints = Array.ConvertAll(array, NCBIMIMMADO);
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("TeamBSpawn");
		AllTeams nICGOGPHBPD = NICGOGPHBPD;
		if (ENPJJJBJGNE == null)
		{
			ENPJJJBJGNE = _003CAwake_003Em__1;
		}
		nICGOGPHBPD.spawnPoints = Array.ConvertAll(array2, ENPJJJBJGNE);
		PhotonNetwork.isMessageQueueRunning = true;
		IJOEABKACKD = Screen.resolutions;
		PJBOAKKJBBA = (IJOEABKACKD.Length - 1) / 2;
		LLKFGGGDFHH = QualitySettings.names;
		AMNDKIKDFJG = true;
		GameObject enableHelper = GameObject.FindWithTag("EnableHelper");
		LNNNNIMMEKM = ((enableHelper != null) ? enableHelper.gameObject : null);
		LEPLDNNHJPF.teamName = "Team A";
		NICGOGPHBPD.teamName = "Team B";
		GFICDIOAGKG = Color.cyan;
		BHJBBMOHLOA = Color.red;
		if (PhotonNetwork.room.customProperties["RoundDuration"] != null)
		{
			NLJGDMJDPOI = (int)PhotonNetwork.room.customProperties["RoundDuration"];
		}
		if (PhotonNetwork.room.customProperties["GameMode"] != null)
		{
			MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["GameMode"];
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("TeamName", "Spectators");
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("Kills", 0);
		ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet2);
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("Deaths", 0);
		ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet3);
		if (PhotonNetwork.isMasterClient)
		{
			IBENPLEEKCF = (float)PhotonNetwork.time;
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("RefTime", IBENPLEEKCF);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet4);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team1Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet5 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet5);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet6 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet6);
		}
		else
		{
			IBENPLEEKCF = (float)PhotonNetwork.room.customProperties["RefTime"];
		}
		HFNFBLAOGBK.Clear();
		Transform[] spawnPoints = LEPLDNNHJPF.spawnPoints;
		foreach (Transform item in spawnPoints)
		{
			HFNFBLAOGBK.Add(item);
		}
		Transform[] spawnPoints2 = NICGOGPHBPD.spawnPoints;
		foreach (Transform item2 in spawnPoints2)
		{
			HFNFBLAOGBK.Add(item2);
		}
		StartCoroutine(WaitBeforeCheck());
		if (MCMCKJIGBJN == "SUR")
		{
			StartGame();
		}
		if (MCMCKJIGBJN == "COOP")
		{
			StartGame();
		}
		if (MCMCKJIGBJN == "VS")
		{
			StartGame();
		}
		if (MCMCKJIGBJN == "INF")
		{
			GMPDMDIBNIA = true;
			StartGame();
		}
		if (MCMCKJIGBJN == "DM")
		{
			StartGame();
		}
		if (MCMCKJIGBJN == "SBX")
		{
			StartGame();
		}
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			LLKFPBAABNA = translator.Translate(93, "MP");
			MLLBJHEMJHH = translator.Translate(102, "MP");
			DICPGAJACNP = translator.Translate(101, "MP");
			BJKBPLHAGBN = translator.Translate(99, "MP");
			OLDCIHOMHKC = translator.Translate(100, "MP");
			NCABKGFODDD = translator.Translate(107, "MP");
			GOICOMEAEEJ = translator.Translate(103, "MP");
			IAHFDMKMCHO = translator.Translate(104, "MP");
			KDGKFHKIGIN = translator.Translate(105, "MP");
			OIHFFOHJOKI = translator.Translate(87, "MP");
			HKKLFNJLKKJ = translator.Translate(138, "MP");
			PHMMHLNDGOL = translator.Translate(137, "MP");
			KGDIIJANLEJ = translator.Translate(136, "MP");
			HEODPGGMMBJ = translator.Translate(90, "MP");
			JDDMENCDIFB = translator.Translate(91, "MP");
			NLMMCFAJEGP = translator.Translate(110, "MP");
			NFJFMOAGEIL = translator.Translate(96, "MP");
			ALFCKFOBFNK = translator.Translate(97, "MP");
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		GUI.color = Color.white;
		GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(714f);
		array[1] = GUILayout.Height(1785f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical();
		for (int i = 1; i < LLKFGGGDFHH.Length; i += 0)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1371f, 1723f, 801f, 605f);
			}
			else
			{
				GUI.color = new Color(581f, 202f, 1084f, 1336f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Team2Score");
		Transform transform = array[UnityEngine.Random.Range(1, array.Length)].transform;
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, transform.position, transform.rotation, 1);
	}

	private void OnLeftRoom()
	{
		NNLHIHKPLPI = false;
		AKADHELLBAD.SetActive(true);
		StartCoroutine(LoadMap("MainMenu"));
	}

	public void __BB_OBFUSCATOR_17(string HKEPPNAHBOG)
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		if (HKEPPNAHBOG == string.Empty)
		{
			HKEPPNAHBOG = LEPLDNNHJPF.teamName;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("_UnderwaterMode", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		if (HKEPPNAHBOG == LEPLDNNHJPF.teamName)
		{
			if (MCMCKJIGBJN == "_MainTex2")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "CameraFilterPack/Blend2Camera_Luminosity")
			{
				ObscuredPrefs.SetInt(">", 154);
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "Mouse Y")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "TeamTag")
			{
				int num = UnityEngine.Random.Range(1, HFNFBLAOGBK.Count);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[num].position, HFNFBLAOGBK[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "RespawnAfter")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "_ScreenResolution")
			{
				int num = UnityEngine.Random.Range(1, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
				ALBNNCJGMHN = 953f;
			}
			if (MCMCKJIGBJN == "_Parameter")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		else
		{
			if (MCMCKJIGBJN == "_TimeX")
			{
				int num = UnityEngine.Random.Range(1, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("INF" + GetComponent<ClassicMechanics>().POIMFLJFADK, NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "Mouse Y")
			{
				int num = UnityEngine.Random.Range(1, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("BodyURL", NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 1);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		AKADHELLBAD.SetActive(true);
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "Menu" || MCMCKJIGBJN == "\"OO\", \"Texture::")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			foreach (PhotonPlayer item in playerList)
			{
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = __BB_OBFUSCATOR_48;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[0].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == "Respawn in")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["mouse y"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = __BB_OBFUSCATOR_34;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 0)
				{
					NMBLKILBGEE = NMNMAOPACLB[0].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 617f * Time.deltaTime;
					if (FLILCEACBEB > 1040f)
					{
						base.photonView.RPC("_ScreenResolution", PhotonNetwork.player);
						FLILCEACBEB = 1984f;
					}
				}
				else
				{
					FLILCEACBEB = 1369f;
				}
			}
		}
		if (MCMCKJIGBJN != "RoundDuration" && MCMCKJIGBJN != "_Value" && !LEGJBPADDLP)
		{
			float num = 1520f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 1088f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 735f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 739f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(__BB_OBFUSCATOR_39());
					NNLHIHKPLPI = true;
					BGGJDPLKGHO = false;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["_Value"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties["<size="];
		}
		if (MCMCKJIGBJN == "_TimeX" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "CameraFilterPack/Edge_Neon")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			__BB_OBFUSCATOR_42(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "_Value2" || MCMCKJIGBJN == "team2")
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				DDEKFMEOIMP = false;
				GMPDMDIBNIA = false;
			}
			else
			{
				DDEKFMEOIMP = true;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "CameraFilterPack_OldFilm1")
				{
					__BB_OBFUSCATOR_14();
				}
				GMPDMDIBNIA = true;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == "_Value2")
			{
				__BB_OBFUSCATOR_17(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "_Value4" || EDAPMHEFPMM != " custards remaining")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == "CameraFilterPack/Blend2Camera_LinearDodge") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 905f * Time.deltaTime;
			if (NGJIHPNEADO > 1949f)
			{
				checkInfectionWin();
			}
		}
		else
		{
			NGJIHPNEADO = 778f;
		}
	}

	public IEnumerator __BB_OBFUSCATOR_39()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = false;
		}
		MCMCKJIGBJN = (string)PhotonNetwork.room.customProperties["GameMode"];
		if (MCMCKJIGBJN == "TDM")
		{
			if (MKDBHGCKFFB == HCILBOJAFBM)
			{
				LGNGMEDLEDC = "Draw... Restarting";
			}
			if (MKDBHGCKFFB > HCILBOJAFBM)
			{
				LGNGMEDLEDC = LEPLDNNHJPF.teamName + LLKFPBAABNA;
			}
			if (MKDBHGCKFFB < HCILBOJAFBM)
			{
				LGNGMEDLEDC = NICGOGPHBPD.teamName + LLKFPBAABNA;
			}
		}
		if (MCMCKJIGBJN == "DM")
		{
			LGNGMEDLEDC = NMBLKILBGEE + LLKFPBAABNA;
		}
		if (MCMCKJIGBJN == "SUR")
		{
			if (!JAFLIDKMIAJ)
			{
				LGNGMEDLEDC = BJKBPLHAGBN;
			}
			else
			{
				LGNGMEDLEDC = OLDCIHOMHKC;
				if (PhotonNetwork.isMasterClient)
				{
					PhotonNetwork.room.open = false;
					PhotonNetwork.room.visible = false;
				}
				yield return new WaitForSeconds(10f);
				PhotonNetwork.LeaveRoom();
			}
		}
		if (MCMCKJIGBJN == "COOP" || MCMCKJIGBJN == "VS")
		{
			if (BGGJDPLKGHO)
			{
				if ((bool)GameObject.FindWithTag("custard"))
				{
					LGNGMEDLEDC = MLLBJHEMJHH;
					if (MCMCKJIGBJN == "VS")
					{
						LGNGMEDLEDC = MLLBJHEMJHH + ", " + PhotonNetwork.masterClient.NickName + LLKFPBAABNA;
					}
				}
				else
				{
					LGNGMEDLEDC = DICPGAJACNP;
				}
			}
			yield return new WaitForSeconds(5f);
			PhotonNetwork.LeaveRoom();
		}
		if (MCMCKJIGBJN == "INF")
		{
			EKJDPEJOOCN = false;
			if (NLIONFPDGID)
			{
				LGNGMEDLEDC = NCABKGFODDD;
			}
			else
			{
				LGNGMEDLEDC = MLLBJHEMJHH + ", " + NMBLKILBGEE + LLKFPBAABNA;
			}
		}
		yield return new WaitForSeconds(5f);
		NLIONFPDGID = false;
		StartCoroutine(Restart());
	}

	private void LeaveRoom()
	{
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		NNLHIHKPLPI = true;
		AKADHELLBAD.SetActive(false);
		StartCoroutine(LoadMap("Menu"));
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Threshhold");
		Transform transform = array[UnityEngine.Random.Range(1, array.Length)].transform;
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, transform.position, transform.rotation, 0);
	}

	private static Transform __BB_OBFUSCATOR_8(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Building unique vertex data");
		Transform transform = array[UnityEngine.Random.Range(0, array.Length)].transform;
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, transform.position, transform.rotation, 1);
	}

	private void OnMasterClientSwitched(PhotonPlayer OFFHLHPPOFO)
	{
		ObscuredPrefs.SetBool("HostQuit", true);
		if (PhotonNetwork.isMasterClient && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.room.IsOpen = false;
			PhotonNetwork.room.IsVisible = false;
		}
		PhotonNetwork.LeaveRoom();
		PhotonNetwork.Disconnect();
	}

	private static Transform __BB_OBFUSCATOR_30(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void SwapTeams(string HKEPPNAHBOG)
	{
		Screen.lockCursor = true;
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("TeamName", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		CBIFAIJOMKC.SendMessage("SwapTeams");
	}

	private static int __BB_OBFUSCATOR_57(PhotonPlayer ILLBDLKGDHL, PhotonPlayer KJMNNCFPILK)
	{
		if (KJMNNCFPILK.customProperties["_MainTex"] != null && ILLBDLKGDHL.customProperties["8"] != null)
		{
			return (int)KJMNNCFPILK.customProperties["_Blue_B"] - (int)ILLBDLKGDHL.customProperties["Version"];
		}
		return 1;
	}

	private void OnGUI()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1f, 1f, 1f, 0.7f);
		if (NNLHIHKPLPI)
		{
			GUI.color = new Color(1f, 1f, 1f, 0.7f);
			GUI.Window(0, new Rect(Screen.width / 2 - 250, Screen.height / 2 - 210, 500f, 500f), MainMenu, KGDIIJANLEJ);
			GUILayout.Space(10f);
			string @string = ObscuredPrefs.GetString("PlayerType'");
			if (JELAKNPPBNJ != null)
			{
				for (int i = 0; i < JELAKNPPBNJ.Count; i++)
				{
					PhotonPlayer photonPlayer = JELAKNPPBNJ[i];
					if (!PhotonNetwork.isMasterClient)
					{
						switch (@string)
						{
						case "8":
						case "3":
						case "6":
							break;
						default:
							continue;
						}
					}
					if (photonPlayer == PhotonNetwork.player)
					{
						if (GUI.Button(new Rect(10f, 10 + 30 * i, 140f, 30f), "<size=16><color=cyan>[YOU]</color> " + photonPlayer.NickName + "</size>"))
						{
							base.photonView.RPC("KickPlayer", photonPlayer);
						}
					}
					else if (GUI.Button(new Rect(10f, 10 + 30 * i, 140f, 30f), "<size=16><color=red>[KICK]</color> " + photonPlayer.NickName + "</size>"))
					{
						base.photonView.RPC("KickPlayer", photonPlayer);
					}
				}
			}
		}
		float num = Mathf.CeilToInt(EMFFJKMBOCI);
		int num2 = Mathf.FloorToInt(num % 60f);
		int num3 = Mathf.FloorToInt(num / 60f % 60f);
		string text = string.Format("{0:00}:{1:00}", num3, num2);
		if (MCMCKJIGBJN != "SUR" && MCMCKJIGBJN != "SBX")
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("Label");
			int num4 = Screen.height / 20;
			gUIStyle.alignment = TextAnchor.MiddleCenter;
			if (DDEKFMEOIMP)
			{
				text = IAHFDMKMCHO;
			}
			DrawOutline(new Rect(0f, 45f, Screen.width, num4), "<size=" + (float)num4 / 1.5f + ">" + text + "</size>", 1, gUIStyle);
		}
		if (MCMCKJIGBJN == "TDM")
		{
			GUILayout.BeginArea(new Rect(Screen.width / 3 - 100, 45f, 200f, 30f));
			GUILayout.BeginHorizontal("box", GUILayout.Width(200f), GUILayout.Height(30f));
			GUI.color = GFICDIOAGKG;
			GUILayout.Label(LEPLDNNHJPF.teamName + ":");
			GUILayout.Space(5f);
			GUI.color = Color.white;
			GUILayout.Label(MKDBHGCKFFB.ToString());
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(Screen.width - Screen.width / 3 - 100, 45f, 200f, 30f));
			GUILayout.BeginHorizontal("box", GUILayout.Width(200f), GUILayout.Height(30f));
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label(NICGOGPHBPD.teamName + ":");
			GUILayout.Space(5f);
			GUI.color = Color.white;
			GUILayout.Label(HCILBOJAFBM.ToString());
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}
		if (MCMCKJIGBJN == "DM" && !BGGJDPLKGHO && NMBLKILBGEE.Length > 2)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle2 = new GUIStyle();
			gUIStyle2 = GUI.skin.GetStyle("Label");
			int num5 = Screen.height / 20;
			DrawOutline(new Rect(0f, 45 + num5, Screen.width, num5), "<size=" + (float)num5 / 1.75f + ">" + NMBLKILBGEE + NFJFMOAGEIL + "</size>", 1, gUIStyle2);
		}
		if (MCMCKJIGBJN == "INF" && !BGGJDPLKGHO && !DDEKFMEOIMP && NMBLKILBGEE.Length > 2)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle3 = new GUIStyle();
			gUIStyle3 = GUI.skin.GetStyle("Label");
			int num6 = Screen.height / 20;
			DrawOutline(new Rect(0f, 45 + num6, Screen.width, num6), "<size=" + (float)num6 / 1.75f + ">" + NMBLKILBGEE + NFJFMOAGEIL + "</size>", 1, gUIStyle3);
		}
		if (MCMCKJIGBJN == "SUR")
		{
			GUIStyle gUIStyle4 = new GUIStyle();
			gUIStyle4 = GUI.skin.GetStyle("Label");
			gUIStyle4.alignment = TextAnchor.MiddleLeft;
			DrawOutline(new Rect(Screen.width - 80, Screen.height - 58, 70f, 48f), "<size=20>" + ObscuredPrefs.GetInt("Toast") + "</size>", 1, gUIStyle4);
			GUI.DrawTexture(new Rect(Screen.width - 128, Screen.height - 58, 48f, 48f), EFOOEDHBALP);
		}
		if (MCMCKJIGBJN == "INF" && (string)PhotonNetwork.player.customProperties["TeamName"] == NICGOGPHBPD.teamName)
		{
			GUIStyle gUIStyle5 = new GUIStyle();
			gUIStyle5 = GUI.skin.GetStyle("Label");
			int num7 = Screen.height / 20;
			gUIStyle5.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(0f, Screen.height - num7, Screen.width, num7), "<size=" + (float)num7 / 1.5f + "><color=red>" + KDGKFHKIGIN + " </color></size>", gUIStyle5);
			GUI.color = Color.white;
		}
		if (ALBNNCJGMHN < 15f && MCMCKJIGBJN == "INF" && (string)PhotonNetwork.player.customProperties["TeamName"] == LEPLDNNHJPF.teamName)
		{
			GUIStyle gUIStyle6 = new GUIStyle();
			gUIStyle6 = GUI.skin.GetStyle("Label");
			int num8 = Screen.height / 20;
			gUIStyle6.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(0f, Screen.height - num8 - 2, Screen.width, num8), "<size=" + (float)num8 / 1.75f + "><color=white>" + OIHFFOHJOKI + " </color></size>", gUIStyle6);
			ALBNNCJGMHN += 1f * Time.deltaTime;
		}
		GUI.color = Color.white;
		if (BGGJDPLKGHO)
		{
			GUIStyle gUIStyle7 = new GUIStyle();
			gUIStyle7 = GUI.skin.GetStyle("Label");
			gUIStyle7.alignment = TextAnchor.MiddleCenter;
			int num9 = Screen.height / 20;
			DrawOutline(new Rect(0f, Screen.height / 2, Screen.width, num9), "<size=" + (float)num9 / 1.5f + ">" + LGNGMEDLEDC + "</size>", 1, gUIStyle7);
			if (MCMCKJIGBJN == "INF")
			{
				DrawOutline(new Rect(0f, Screen.height / 2 - num9, Screen.width, num9), "<size=" + (float)num9 / 1.25f + ">" + ALFCKFOBFNK + "</size>", 1, gUIStyle7);
			}
		}
		FadeScreen();
	}

	private void __BB_OBFUSCATOR_35()
	{
		__BB_OBFUSCATOR_17(NICGOGPHBPD.teamName);
		EKJDPEJOOCN = true;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
	}

	[PunRPC]
	private void KickPlayer()
	{
		string @string = ObscuredPrefs.GetString("PlayerType'");
		if (@string != "8" && @string != "3" && @string != "6")
		{
			PhotonNetwork.Disconnect();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_0(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		OIECJHKOMMB = 1;
		if (!BNNOMCKIGLL)
		{
			BNNOMCKIGLL = true;
			yield return new WaitForSeconds(1f);
			Application.backgroundLoadingPriority = ThreadPriority.High;
			yield return Application.LoadLevelAsync(LIHOALDCAHE);
			Debug.Log("Loading complete");
		}
		else
		{
			yield return new WaitForSeconds(1f);
		}
	}

	private void MainMenu(int ANFLNMCPNFK)
	{
		GUI.FocusWindow(ANFLNMCPNFK);
		GUILayout.Space(10f);
		GUILayout.BeginHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(15f);
		GUILayout.BeginVertical();
		GUI.enabled = true;
		if ((bool)CBIFAIJOMKC && GUILayout.Button(HKKLFNJLKKJ))
		{
			NNLHIHKPLPI = false;
		}
		if (GUILayout.Button(PHMMHLNDGOL))
		{
			LeaveRoom();
		}
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.Space(10f);
		GUILayout.BeginHorizontal();
		if (AMNDKIKDFJG)
		{
			GUI.color = new Color(0f, 20f, 0f, 0.6f);
		}
		else
		{
			GUI.color = Color.white;
		}
		AMNDKIKDFJG = true;
		if (!AMNDKIKDFJG)
		{
			GUI.color = new Color(0f, 20f, 0f, 0.6f);
		}
		else
		{
			GUI.color = Color.white;
		}
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item in JELAKNPPBNJ)
		{
			if (item.CustomProperties["TeamName"] == null)
			{
				return;
			}
		}
		GUILayout.Space(5f);
		GUI.color = Color.white;
		MMBPIPDEIIF = GUILayout.BeginScrollView(MMBPIPDEIIF, GUILayout.Width(480f), GUILayout.Height(250f));
		GUI.color = new Color(1f, 1f, 1f, 0.8f);
		if (MCMCKJIGBJN == "INF")
		{
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = GFICDIOAGKG;
			GUILayout.Label("Survivors");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item2 in JELAKNPPBNJ)
			{
				if ((string)item2.customProperties["TeamName"] == LEPLDNNHJPF.teamName)
				{
					if (PhotonNetwork.player.name == item2.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("box");
					GUILayout.Label(item2.name, GUILayout.Width(150f));
					GUILayout.Label(HEODPGGMMBJ + ": " + (int)item2.customProperties["Kills"], GUILayout.Width(115f));
					GUILayout.Label(JDDMENCDIFB + ": " + (int)item2.customProperties["Deaths"], GUILayout.Width(115f));
					GUILayout.FlexibleSpace();
					if (item2.customProperties["Ping"] != null)
					{
						GUILayout.Label("Ping: " + (int)item2.customProperties["Ping"]);
					}
					GUILayout.EndHorizontal();
				}
			}
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label("Infected");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item3 in JELAKNPPBNJ)
			{
				if ((string)item3.customProperties["TeamName"] == NICGOGPHBPD.teamName)
				{
					if (PhotonNetwork.player.name == item3.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("box");
					GUILayout.Label(item3.name, GUILayout.Width(150f));
					GUILayout.Label(" ", GUILayout.Width(115f));
					GUILayout.Label(JDDMENCDIFB + ": " + (int)item3.customProperties["Deaths"], GUILayout.Width(115f));
					GUILayout.FlexibleSpace();
					if (item3.customProperties["Ping"] != null)
					{
						GUILayout.Label("Ping: " + (int)item3.customProperties["Ping"]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		else
		{
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = Color.cyan;
			GUILayout.Label("All Players");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item4 in JELAKNPPBNJ)
			{
				if ((string)item4.customProperties["TeamName"] != "Spectators")
				{
					if (PhotonNetwork.player.name == item4.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("box");
					GUILayout.Label(item4.name, GUILayout.Width(150f));
					if (MCMCKJIGBJN != "SUR")
					{
						GUILayout.Label(HEODPGGMMBJ + ": " + (int)item4.customProperties["Kills"], GUILayout.Width(115f));
					}
					GUILayout.Label(JDDMENCDIFB + ": " + (int)item4.customProperties["Deaths"], GUILayout.Width(115f));
					GUILayout.FlexibleSpace();
					if (item4.customProperties["Ping"] != null)
					{
						GUILayout.Label("Ping: " + (int)item4.customProperties["Ping"]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUI.color = Color.grey;
		GUILayout.Label("- Spectators -");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item5 in JELAKNPPBNJ)
		{
			if ((string)item5.customProperties["TeamName"] == "Spectators")
			{
				if (PhotonNetwork.player.name == item5.name)
				{
					GUI.color = Color.green;
				}
				else
				{
					GUI.color = Color.white;
				}
				GUILayout.BeginHorizontal("box");
				GUILayout.Label(item5.name);
				GUILayout.FlexibleSpace();
				if (item5.customProperties["Ping"] != null)
				{
					GUILayout.Label("Ping: " + (int)item5.customProperties["Ping"]);
				}
				GUILayout.EndHorizontal();
			}
		}
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (NMNMAOPACLB.Count == 0)
		{
			BGGJDPLKGHO = true;
			NLIONFPDGID = true;
			base.photonView.RPC("selectWeapon", PhotonTargets.Others);
		}
		else
		{
			NLIONFPDGID = false;
			NGJIHPNEADO = 373f;
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		SpawnPlayer(NICGOGPHBPD.teamName);
		EKJDPEJOOCN = false;
	}

	[CompilerGenerated]
	private static Transform _003CAwake_003Em__0(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void StartGame()
	{
		GMPDMDIBNIA = true;
		if (ObscuredPrefs.GetBool("UseFlashlight"))
		{
			KGPEFHHPFHL = new ObscuredString[1] { "Flashlight" };
		}
		else
		{
			KGPEFHHPFHL = new ObscuredString[1] { "Camera" };
		}
		if (MCMCKJIGBJN == "SUR")
		{
			GMPDMDIBNIA = true;
			GPPEJCFIHFE = PAMKBIEEBJF;
			SpawnPlayer(LEPLDNNHJPF.teamName);
			GUI.enabled = false;
			GetComponent<SurvivalMechanics>().enabled = true;
			NNLHIHKPLPI = false;
		}
		if (MCMCKJIGBJN == "COOP")
		{
			GMPDMDIBNIA = true;
			GPPEJCFIHFE = KGPEFHHPFHL;
			SpawnPlayer(LEPLDNNHJPF.teamName);
			GUI.enabled = false;
			GetComponent<ClassicMechanics>().enabled = true;
			NNLHIHKPLPI = false;
		}
		if (MCMCKJIGBJN == "VS")
		{
			GPPEJCFIHFE = KGPEFHHPFHL;
			if (PhotonNetwork.isMasterClient)
			{
				SpawnPlayer(LEPLDNNHJPF.teamName);
			}
			else
			{
				SpawnPlayer(LEPLDNNHJPF.teamName);
			}
			GUI.enabled = false;
			GetComponent<ClassicMechanics>().enabled = true;
			NNLHIHKPLPI = false;
		}
		if (MCMCKJIGBJN == "INF")
		{
			GPPEJCFIHFE = AFNGLPAEAMK;
			if (EKJDPEJOOCN)
			{
				SpawnPlayer(NICGOGPHBPD.teamName);
			}
			else
			{
				SpawnPlayer(LEPLDNNHJPF.teamName);
			}
			GUI.enabled = false;
			NNLHIHKPLPI = false;
		}
		if (MCMCKJIGBJN == "DM")
		{
			GPPEJCFIHFE = DCKJFGMJLNA;
			SpawnPlayer(LEPLDNNHJPF.teamName);
		}
		if (MCMCKJIGBJN == "SBX")
		{
			GMPDMDIBNIA = true;
			GPPEJCFIHFE = PAMKBIEEBJF;
			SpawnPlayer(LEPLDNNHJPF.teamName);
			GUI.enabled = false;
			NNLHIHKPLPI = false;
		}
	}

	private void FadeScreen()
	{
		if (OIECJHKOMMB == 1)
		{
			ECKCMCNLLAE += (float)(OIECJHKOMMB * 15) * Time.deltaTime;
			ECKCMCNLLAE = Mathf.Clamp01(ECKCMCNLLAE);
			GUI.color = new Color(1f, 1f, 1f, ECKCMCNLLAE);
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), KEMCOJPJLBH);
			GUI.color = Color.white;
			GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 15, 150f, 30f), NLMMCFAJEGP);
		}
	}

	private void RespawnPlayer2()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("TeamASpawn");
		Transform transform = array[UnityEngine.Random.Range(0, array.Length)].transform;
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, transform.position, transform.rotation, 0);
	}

	[PunRPC]
	private void Infect()
	{
		SpawnPlayer(NICGOGPHBPD.teamName);
		EKJDPEJOOCN = true;
	}

	private IEnumerator WaitBeforeCheck()
	{
		LEGJBPADDLP = true;
		yield return new WaitForSeconds(0.3f);
		LEGJBPADDLP = false;
	}

	private void __BB_OBFUSCATOR_26()
	{
		GUILayout.BeginVertical();
		GUILayout.Label("|");
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[1] = GUILayout.Width(807f);
		array[1] = GUILayout.Height(315f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical();
		for (int i = 0; i < IJOEABKACKD.Length; i += 0)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(1875f, 949f, 135f, 1239f);
			}
			else
			{
				GUI.color = new Color(1303f, 1253f, 264f, 1139f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "Mouse X" + IJOEABKACKD[i].height))
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
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_47()
	{
		BGGJDPLKGHO = true;
		NLIONFPDGID = true;
		StartCoroutine(__BB_OBFUSCATOR_39());
	}

	private void OnDisconnectedFromPhoton()
	{
		UnityEngine.MonoBehaviour.print("Disconnected from Photon");
		NNLHIHKPLPI = false;
		AKADHELLBAD.SetActive(true);
		StartCoroutine(LoadMap("MainMenu"));
	}

	private void __BB_OBFUSCATOR_60()
	{
		NNLHIHKPLPI = true;
		AKADHELLBAD.SetActive(false);
		StartCoroutine(__BB_OBFUSCATOR_0("><color=grey>"));
	}

	private void FixedUpdate()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "DM" || MCMCKJIGBJN == "INF")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			foreach (PhotonPlayer item in playerList)
			{
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = SortPlayers;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[0].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == "INF")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["TeamName"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = SortPlayers;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 0)
				{
					NMBLKILBGEE = NMNMAOPACLB[0].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 1f * Time.deltaTime;
					if (FLILCEACBEB > 5f)
					{
						base.photonView.RPC("Infect", PhotonNetwork.player);
						FLILCEACBEB = 0f;
					}
				}
				else
				{
					FLILCEACBEB = 0f;
				}
			}
		}
		if (MCMCKJIGBJN != "SUR" && MCMCKJIGBJN != "SBX" && !LEGJBPADDLP)
		{
			float num = 0f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 0f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 0f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 0f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(RoundEnded());
					NNLHIHKPLPI = false;
					BGGJDPLKGHO = true;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["Team1Score"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties["Team2Score"];
		}
		if (MCMCKJIGBJN == "VS" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "monster")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			SpawnPlayer(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "VS" || MCMCKJIGBJN == "INF")
		{
			if (PhotonNetwork.playerList.Length < 2)
			{
				DDEKFMEOIMP = true;
				GMPDMDIBNIA = false;
			}
			else
			{
				DDEKFMEOIMP = false;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "INF")
				{
					InfectRandomPlayer();
				}
				GMPDMDIBNIA = true;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == "Player")
			{
				SpawnPlayer(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "Flashlight" || EDAPMHEFPMM != "Camera")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == "INF") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 1f * Time.deltaTime;
			if (NGJIHPNEADO > 3f)
			{
				checkInfectionWin();
			}
		}
		else
		{
			NGJIHPNEADO = 0f;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_55()
	{
		LEGJBPADDLP = true;
		yield return new WaitForSeconds(0.3f);
		LEGJBPADDLP = false;
	}

	private IEnumerator __BB_OBFUSCATOR_1()
	{
		ExitGames.Client.Photon.Hashtable propertiesToSet = new ExitGames.Client.Photon.Hashtable { { "Kills", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		ExitGames.Client.Photon.Hashtable propertiesToSet2 = new ExitGames.Client.Photon.Hashtable { { "Deaths", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet2);
		if (PhotonNetwork.isMasterClient)
		{
			IBENPLEEKCF = (float)PhotonNetwork.time;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("RefTime", IBENPLEEKCF);
			ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team1Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet4);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet5 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet5);
		}
		else
		{
			while (IBENPLEEKCF == (float)PhotonNetwork.room.customProperties["RefTime"])
			{
				yield return null;
			}
			IBENPLEEKCF = (float)PhotonNetwork.room.customProperties["RefTime"];
		}
		if ((bool)CBIFAIJOMKC)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		yield return new WaitForSeconds(0.2f);
		if (MCMCKJIGBJN == "INF")
		{
			SpawnPlayer(LEPLDNNHJPF.teamName);
			InfectRandomPlayer();
		}
		else if ((string)PhotonNetwork.player.customProperties["TeamName"] != "Spectators")
		{
			SpawnPlayer((string)PhotonNetwork.player.customProperties["TeamName"]);
		}
		if (MCMCKJIGBJN == "SUR")
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
		BGGJDPLKGHO = false;
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = true;
		}
	}

	private IEnumerator Restart()
	{
		ExitGames.Client.Photon.Hashtable propertiesToSet = new ExitGames.Client.Photon.Hashtable { { "Kills", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		ExitGames.Client.Photon.Hashtable propertiesToSet2 = new ExitGames.Client.Photon.Hashtable { { "Deaths", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet2);
		if (PhotonNetwork.isMasterClient)
		{
			IBENPLEEKCF = (float)PhotonNetwork.time;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("RefTime", IBENPLEEKCF);
			ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team1Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet4);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet5 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet5);
		}
		else
		{
			while (IBENPLEEKCF == (float)PhotonNetwork.room.customProperties["RefTime"])
			{
				yield return null;
			}
			IBENPLEEKCF = (float)PhotonNetwork.room.customProperties["RefTime"];
		}
		if ((bool)CBIFAIJOMKC)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		yield return new WaitForSeconds(0.2f);
		if (MCMCKJIGBJN == "INF")
		{
			SpawnPlayer(LEPLDNNHJPF.teamName);
			InfectRandomPlayer();
		}
		else if ((string)PhotonNetwork.player.customProperties["TeamName"] != "Spectators")
		{
			SpawnPlayer((string)PhotonNetwork.player.customProperties["TeamName"]);
		}
		if (MCMCKJIGBJN == "SUR")
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
		BGGJDPLKGHO = false;
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = true;
		}
	}

	private static int __BB_OBFUSCATOR_48(PhotonPlayer ILLBDLKGDHL, PhotonPlayer KJMNNCFPILK)
	{
		if (KJMNNCFPILK.customProperties["State2"] != null && ILLBDLKGDHL.customProperties["_ScreenResolution"] != null)
		{
			return (int)KJMNNCFPILK.customProperties["_Value2"] - (int)ILLBDLKGDHL.customProperties["_TimeX"];
		}
		return 0;
	}

	private static int SortPlayers(PhotonPlayer ILLBDLKGDHL, PhotonPlayer KJMNNCFPILK)
	{
		if (KJMNNCFPILK.customProperties["Kills"] != null && ILLBDLKGDHL.customProperties["Kills"] != null)
		{
			return (int)KJMNNCFPILK.customProperties["Kills"] - (int)ILLBDLKGDHL.customProperties["Kills"];
		}
		return 0;
	}

	private void __BB_OBFUSCATOR_49(string HKEPPNAHBOG)
	{
		Screen.lockCursor = false;
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
		CBIFAIJOMKC.SendMessage("_ScreenResolution");
	}

	private static Transform __BB_OBFUSCATOR_44(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_53(int ANFLNMCPNFK)
	{
		GUI.FocusWindow(ANFLNMCPNFK);
		GUILayout.Space(721f);
		GUILayout.BeginHorizontal();
		GUI.color = Color.white;
		GUILayout.Space(763f);
		GUILayout.BeginVertical();
		GUI.enabled = false;
		if ((bool)CBIFAIJOMKC && GUILayout.Button(HKKLFNJLKKJ))
		{
			NNLHIHKPLPI = false;
		}
		if (GUILayout.Button(PHMMHLNDGOL))
		{
			__BB_OBFUSCATOR_29();
		}
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.Space(1628f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		if (AMNDKIKDFJG)
		{
			GUI.color = new Color(615f, 989f, 1472f, 1753f);
		}
		else
		{
			GUI.color = Color.white;
		}
		AMNDKIKDFJG = false;
		if (!AMNDKIKDFJG)
		{
			GUI.color = new Color(1012f, 941f, 1396f, 1893f);
		}
		else
		{
			GUI.color = Color.white;
		}
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item in JELAKNPPBNJ)
		{
			if (item.CustomProperties["_TimeX"] == null)
			{
				return;
			}
		}
		GUILayout.Space(333f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1874f);
		array[0] = GUILayout.Height(1428f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array);
		GUI.color = new Color(702f, 1210f, 857f, 803f);
		if (MCMCKJIGBJN == "CameraFilterPack_VHS1")
		{
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = GFICDIOAGKG;
			GUILayout.Label("Team B");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item2 in JELAKNPPBNJ)
			{
				if ((string)item2.customProperties[" wins"] == LEPLDNNHJPF.teamName)
				{
					if (PhotonNetwork.player.name == item2.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("\"");
					GUILayout.Label(item2.name, GUILayout.Width(501f));
					GUILayout.Label(HEODPGGMMBJ + "team1" + (int)item2.customProperties["_Value3"], GUILayout.Width(1759f));
					string text = JDDMENCDIFB + "_UnderwaterMode" + (int)item2.customProperties["_FadeFX"];
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[1] = GUILayout.Width(400f);
					GUILayout.Label(text, array2);
					GUILayout.FlexibleSpace();
					if (item2.customProperties["Count"] != null)
					{
						GUILayout.Label("_Value" + (int)item2.customProperties["Vertical"]);
					}
					GUILayout.EndHorizontal();
				}
			}
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label("_AdaptionSpeed", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item3 in JELAKNPPBNJ)
			{
				if ((string)item3.customProperties["CameraFilterPack/Atmosphere_Snow_8bits"] == NICGOGPHBPD.teamName)
				{
					if (PhotonNetwork.player.name == item3.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("Infected", new GUILayoutOption[1]);
					GUILayout.Label(item3.name, GUILayout.Width(1961f));
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(1470f);
					GUILayout.Label(" min", array3);
					string text2 = JDDMENCDIFB + "_Value" + (int)item3.customProperties["Mouse X"];
					GUILayoutOption[] array4 = new GUILayoutOption[0];
					array4[0] = GUILayout.Width(366f);
					GUILayout.Label(text2, array4);
					GUILayout.FlexibleSpace();
					if (item3.customProperties["Dead"] != null)
					{
						GUILayout.Label("State2" + (int)item3.customProperties["1"]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		else
		{
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = Color.cyan;
			GUILayout.Label("Player Left.", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item4 in JELAKNPPBNJ)
			{
				if ((string)item4.customProperties["_Distortion"] != "_Scale")
				{
					if (PhotonNetwork.player.name == item4.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("_TimeX");
					string text3 = item4.name;
					GUILayoutOption[] array5 = new GUILayoutOption[1];
					array5[1] = GUILayout.Width(1658f);
					GUILayout.Label(text3, array5);
					if (MCMCKJIGBJN != "_Value2")
					{
						string text4 = HEODPGGMMBJ + " simplified mesh" + (int)item4.customProperties["_Red_B"];
						GUILayoutOption[] array6 = new GUILayoutOption[0];
						array6[0] = GUILayout.Width(153f);
						GUILayout.Label(text4, array6);
					}
					string text5 = JDDMENCDIFB + ">" + (int)item4.customProperties["Horizontal"];
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[0] = GUILayout.Width(739f);
					GUILayout.Label(text5, array7);
					GUILayout.FlexibleSpace();
					if (item4.customProperties["Mouse"] != null)
					{
						GUILayout.Label("CameraFilterPack/Blend2Camera_Exclusion" + (int)item4.customProperties["OffScreenIndicator Canvas field requieres a Canvas GameObject"], new GUILayoutOption[1]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		GUI.color = Color.grey;
		GUILayout.Label("Kills", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item5 in JELAKNPPBNJ)
		{
			if ((string)item5.customProperties["_Value3"] == "SyncWeaponsRPC")
			{
				if (PhotonNetwork.player.name == item5.name)
				{
					GUI.color = Color.green;
				}
				else
				{
					GUI.color = Color.white;
				}
				GUILayout.BeginHorizontal("Difficulty");
				GUILayout.Label(item5.name, new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (item5.customProperties["_ScreenResolution"] != null)
				{
					GUILayout.Label("GameOver" + (int)item5.customProperties["b"], new GUILayoutOption[1]);
				}
				GUILayout.EndHorizontal();
			}
		}
		GUILayout.EndScrollView();
	}

	private void __BB_OBFUSCATOR_50(int ANFLNMCPNFK)
	{
		GUI.FocusWindow(ANFLNMCPNFK);
		GUILayout.Space(1184f);
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUI.color = Color.white;
		GUILayout.Space(1444f);
		GUILayout.BeginVertical();
		GUI.enabled = false;
		if ((bool)CBIFAIJOMKC && GUILayout.Button(HKKLFNJLKKJ))
		{
			NNLHIHKPLPI = false;
		}
		if (GUILayout.Button(PHMMHLNDGOL, new GUILayoutOption[1]))
		{
			LeaveRoom();
		}
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.Space(605f);
		GUILayout.BeginHorizontal();
		if (AMNDKIKDFJG)
		{
			GUI.color = new Color(1838f, 24f, 95f, 1818f);
		}
		else
		{
			GUI.color = Color.white;
		}
		AMNDKIKDFJG = false;
		if (!AMNDKIKDFJG)
		{
			GUI.color = new Color(1401f, 165f, 993f, 1873f);
		}
		else
		{
			GUI.color = Color.white;
		}
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item in JELAKNPPBNJ)
		{
			if (item.CustomProperties["TenkokuModule"] == null)
			{
				return;
			}
		}
		GUILayout.Space(1499f);
		GUI.color = Color.white;
		Vector2 mMBPIPDEIIF = MMBPIPDEIIF;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(766f);
		array[1] = GUILayout.Height(1356f);
		MMBPIPDEIIF = GUILayout.BeginScrollView(mMBPIPDEIIF, array);
		GUI.color = new Color(632f, 1859f, 1041f, 1007f);
		if (MCMCKJIGBJN == "Reload_1_3")
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUI.color = GFICDIOAGKG;
			GUILayout.Label("_AlphaHexa", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item2 in JELAKNPPBNJ)
			{
				if ((string)item2.customProperties["_Green_G"] == LEPLDNNHJPF.teamName)
				{
					if (PhotonNetwork.player.name == item2.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal(",", new GUILayoutOption[1]);
					GUILayout.Label(item2.name, GUILayout.Width(1692f));
					string text = HEODPGGMMBJ + "_Red_C" + (int)item2.customProperties["_SunColor"];
					GUILayoutOption[] array2 = new GUILayoutOption[0];
					array2[0] = GUILayout.Width(1794f);
					GUILayout.Label(text, array2);
					string text2 = JDDMENCDIFB + "_ScreenResolution" + (int)item2.customProperties["_Value"];
					GUILayoutOption[] array3 = new GUILayoutOption[0];
					array3[0] = GUILayout.Width(915f);
					GUILayout.Label(text2, array3);
					GUILayout.FlexibleSpace();
					if (item2.customProperties["CameraFilterPack/TV_Video3D"] != null)
					{
						GUILayout.Label("*" + (int)item2.customProperties["_Value2"], new GUILayoutOption[1]);
					}
					GUILayout.EndHorizontal();
				}
			}
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label("\", \"Cluster\"", new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item3 in JELAKNPPBNJ)
			{
				if ((string)item3.customProperties["CameraFilterPack/Distortion_Water_Drop"] == NICGOGPHBPD.teamName)
				{
					if (PhotonNetwork.player.name == item3.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("_Angle");
					string text3 = item3.name;
					GUILayoutOption[] array4 = new GUILayoutOption[1];
					array4[1] = GUILayout.Width(921f);
					GUILayout.Label(text3, array4);
					GUILayoutOption[] array5 = new GUILayoutOption[0];
					array5[1] = GUILayout.Width(1816f);
					GUILayout.Label("COOP", array5);
					string text4 = JDDMENCDIFB + "0" + (int)item3.customProperties["ZWName'"];
					GUILayoutOption[] array6 = new GUILayoutOption[0];
					array6[0] = GUILayout.Width(1203f);
					GUILayout.Label(text4, array6);
					GUILayout.FlexibleSpace();
					if (item3.customProperties["FireballA-Default"] != null)
					{
						GUILayout.Label("SUR" + (int)item3.customProperties["WFX_MF FPS"], new GUILayoutOption[1]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		else
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.FlexibleSpace();
			GUI.color = Color.cyan;
			GUILayout.Label("\t\t}\n");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			foreach (PhotonPlayer item4 in JELAKNPPBNJ)
			{
				if ((string)item4.customProperties["LegsURL"] != "PrimaryCausticsProjector")
				{
					if (PhotonNetwork.player.name == item4.name)
					{
						GUI.color = Color.green;
					}
					else
					{
						GUI.color = Color.white;
					}
					GUILayout.BeginHorizontal("_ScreenResolution", new GUILayoutOption[1]);
					string text5 = item4.name;
					GUILayoutOption[] array7 = new GUILayoutOption[0];
					array7[1] = GUILayout.Width(1903f);
					GUILayout.Label(text5, array7);
					if (MCMCKJIGBJN != "CameraFilterPack/OldFilm_Cutting2")
					{
						string text6 = HEODPGGMMBJ + "Newborn_Bot" + (int)item4.customProperties["_CenterY"];
						GUILayoutOption[] array8 = new GUILayoutOption[0];
						array8[1] = GUILayout.Width(1711f);
						GUILayout.Label(text6, array8);
					}
					string text7 = JDDMENCDIFB + "\n" + (int)item4.customProperties["_Value3"];
					GUILayoutOption[] array9 = new GUILayoutOption[0];
					array9[1] = GUILayout.Width(1130f);
					GUILayout.Label(text7, array9);
					GUILayout.FlexibleSpace();
					if (item4.customProperties["Server TYPE: "] != null)
					{
						GUILayout.Label(">" + (int)item4.customProperties["\\Microsoft\\WordPad\\Wor96BA.tmp"], new GUILayoutOption[1]);
					}
					GUILayout.EndHorizontal();
				}
			}
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		GUI.color = Color.grey;
		GUILayout.Label("\\Google");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		foreach (PhotonPlayer item5 in JELAKNPPBNJ)
		{
			if ((string)item5.customProperties["_BumpMap"] == "_TimeX")
			{
				if (PhotonNetwork.player.name == item5.name)
				{
					GUI.color = Color.green;
				}
				else
				{
					GUI.color = Color.white;
				}
				GUILayout.BeginHorizontal("Computing edge collapse cost");
				GUILayout.Label(item5.name, new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (item5.customProperties["_BlurRadius4"] != null)
				{
					GUILayout.Label("Flashlight" + (int)item5.customProperties["[BOT] Boss"]);
				}
				GUILayout.EndHorizontal();
			}
		}
		GUILayout.EndScrollView();
	}

	private static Transform __BB_OBFUSCATOR_7(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void QualityWindow()
	{
		GUILayout.BeginVertical();
		GUI.color = Color.white;
		GUILayout.Label("Quality");
		NHMIFIFKKMK = GUILayout.BeginScrollView(NHMIFIFKKMK, GUILayout.Width(140f), GUILayout.Height(100f));
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
		GUILayout.EndVertical();
	}

	private IEnumerator __BB_OBFUSCATOR_45()
	{
		ExitGames.Client.Photon.Hashtable propertiesToSet = new ExitGames.Client.Photon.Hashtable { { "Kills", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		ExitGames.Client.Photon.Hashtable propertiesToSet2 = new ExitGames.Client.Photon.Hashtable { { "Deaths", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet2);
		if (PhotonNetwork.isMasterClient)
		{
			IBENPLEEKCF = (float)PhotonNetwork.time;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("RefTime", IBENPLEEKCF);
			ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team1Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet4);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet5 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet5);
		}
		else
		{
			while (IBENPLEEKCF == (float)PhotonNetwork.room.customProperties["RefTime"])
			{
				yield return null;
			}
			IBENPLEEKCF = (float)PhotonNetwork.room.customProperties["RefTime"];
		}
		if ((bool)CBIFAIJOMKC)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		yield return new WaitForSeconds(0.2f);
		if (MCMCKJIGBJN == "INF")
		{
			SpawnPlayer(LEPLDNNHJPF.teamName);
			InfectRandomPlayer();
		}
		else if ((string)PhotonNetwork.player.customProperties["TeamName"] != "Spectators")
		{
			SpawnPlayer((string)PhotonNetwork.player.customProperties["TeamName"]);
		}
		if (MCMCKJIGBJN == "SUR")
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
		BGGJDPLKGHO = false;
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = true;
		}
	}

	public void SpawnPlayer(string HKEPPNAHBOG)
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		if (HKEPPNAHBOG == string.Empty)
		{
			HKEPPNAHBOG = LEPLDNNHJPF.teamName;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("TeamName", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		if (HKEPPNAHBOG == LEPLDNNHJPF.teamName)
		{
			if (MCMCKJIGBJN == "TDM")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "SUR")
			{
				ObscuredPrefs.SetInt("Toast", 200);
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "COOP")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "DM")
			{
				int num = UnityEngine.Random.Range(0, HFNFBLAOGBK.Count);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[num].position, HFNFBLAOGBK[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "VS")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "INF")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
				ALBNNCJGMHN = 0f;
			}
			if (MCMCKJIGBJN == "SBX")
			{
				int num = UnityEngine.Random.Range(0, LEPLDNNHJPF.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, LEPLDNNHJPF.spawnPoints[num].position, LEPLDNNHJPF.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		else
		{
			if (MCMCKJIGBJN == "VS")
			{
				int num = UnityEngine.Random.Range(0, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("VS/" + GetComponent<ClassicMechanics>().POIMFLJFADK, NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
			if (MCMCKJIGBJN == "INF")
			{
				int num = UnityEngine.Random.Range(0, NICGOGPHBPD.spawnPoints.Length);
				CBIFAIJOMKC = PhotonNetwork.Instantiate("INF/PlayerNewborn", NICGOGPHBPD.spawnPoints[num].position + Vector3.up, NICGOGPHBPD.spawnPoints[num].rotation, 0);
				CBIFAIJOMKC.name = PhotonNetwork.player.name;
			}
		}
		AKADHELLBAD.SetActive(false);
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = NMOHLIAHHDP;
		GUI.color = new Color(1506f, 764f, 703f, 496f);
		if (NNLHIHKPLPI)
		{
			GUI.color = new Color(968f, 315f, 1479f, 928f);
			GUI.Window(1, new Rect(Screen.width / 2 - 17, Screen.height / 4 - -147, 1977f, 1101f), __BB_OBFUSCATOR_3, KGDIIJANLEJ);
			GUILayout.Space(1319f);
			string @string = ObscuredPrefs.GetString("MP");
			if (JELAKNPPBNJ != null)
			{
				for (int i = 1; i < JELAKNPPBNJ.Count; i++)
				{
					PhotonPlayer photonPlayer = JELAKNPPBNJ[i];
					if (!PhotonNetwork.isMasterClient)
					{
						switch (@string)
						{
						case "CameraFilterPack/Blend2Camera_Divide":
						case "_Value":
						case "CameraFilterPack/Blend2Camera_Darken":
							break;
						default:
							continue;
						}
					}
					if (photonPlayer == PhotonNetwork.player)
					{
						if (GUI.Button(new Rect(1286f, -18 + -113 * i, 498f, 887f), "GameMode" + photonPlayer.NickName + "/"))
						{
							base.photonView.RPC("_MainTex2", photonPlayer, new object[1]);
						}
					}
					else if (GUI.Button(new Rect(1283f, 103 + -24 * i, 597f, 599f), "_Thickness" + photonPlayer.NickName + "Camera"))
					{
						base.photonView.RPC("_BlueAmplifier", photonPlayer, new object[1]);
					}
				}
			}
		}
		float num = Mathf.CeilToInt(EMFFJKMBOCI);
		int num2 = Mathf.FloorToInt(num % 1521f);
		int num3 = Mathf.FloorToInt(num / 232f % 1600f);
		string text = string.Format("_BlurArea", num3, num2);
		if (MCMCKJIGBJN != "," && MCMCKJIGBJN != "_Value2")
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("3");
			int num4 = Screen.height / 53;
			gUIStyle.alignment = TextAnchor.MiddleCenter;
			if (DDEKFMEOIMP)
			{
				text = IAHFDMKMCHO;
			}
			Rect pLGJJIBFGFL = new Rect(742f, 809f, Screen.width, num4);
			string[] array = new string[4];
			array[0] = "AutoRotate Weapon";
			array[1] = ((float)num4 / 1699f).ToString();
			array[8] = "team2";
			array[8] = text;
			array[4] = "3";
			DrawOutline(pLGJJIBFGFL, string.Concat(array), 1, gUIStyle);
		}
		if (MCMCKJIGBJN == "http://zeoworks.com/home/member.php?action=register")
		{
			GUILayout.BeginArea(new Rect(Screen.width / 3 - -7, 855f, 1507f, 289f));
			GUIStyle style = "_TimeX";
			GUILayoutOption[] array2 = new GUILayoutOption[4];
			array2[0] = GUILayout.Width(1778f);
			array2[0] = GUILayout.Height(1497f);
			GUILayout.BeginHorizontal(style, array2);
			GUI.color = GFICDIOAGKG;
			GUILayout.Label(LEPLDNNHJPF.teamName + "OnRenderImage in Helper called ...", new GUILayoutOption[1]);
			GUILayout.Space(392f);
			GUI.color = Color.white;
			GUILayout.Label(MKDBHGCKFFB.ToString(), new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(Screen.width - Screen.width / 2 - -26, 940f, 1156f, 1393f));
			GUIStyle style2 = "Left Stick Down";
			GUILayoutOption[] array3 = new GUILayoutOption[8];
			array3[0] = GUILayout.Width(349f);
			array3[0] = GUILayout.Height(1649f);
			GUILayout.BeginHorizontal(style2, array3);
			GUI.color = BHJBBMOHLOA;
			GUILayout.Label(NICGOGPHBPD.teamName + "_NormalOffsetScale");
			GUILayout.Space(604f);
			GUI.color = Color.white;
			GUILayout.Label(HCILBOJAFBM.ToString());
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}
		if (MCMCKJIGBJN == "_ScreenResolution" && !BGGJDPLKGHO && NMBLKILBGEE.Length > 2)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle2 = new GUIStyle();
			gUIStyle2 = GUI.skin.GetStyle("_Distortion");
			int num5 = Screen.height / 93;
			Rect pLGJJIBFGFL2 = new Rect(102f, -127 + num5, Screen.width, num5);
			string[] array4 = new string[1];
			array4[1] = "<size=";
			array4[0] = ((float)num5 / 176f).ToString();
			array4[8] = "Mouse Y";
			array4[6] = NMBLKILBGEE;
			array4[7] = NFJFMOAGEIL;
			array4[6] = "<size=";
			DrawOutline(pLGJJIBFGFL2, string.Concat(array4), 1, gUIStyle2);
		}
		if (MCMCKJIGBJN == "Mesh consolidation done" && !BGGJDPLKGHO && !DDEKFMEOIMP && NMBLKILBGEE.Length > 2)
		{
			GUI.color = Color.white;
			GUIStyle gUIStyle3 = new GUIStyle();
			gUIStyle3 = GUI.skin.GetStyle("_TimeX");
			int num6 = Screen.height / -84;
			Rect pLGJJIBFGFL3 = new Rect(816f, -3 + num6, Screen.width, num6);
			string[] array5 = new string[4];
			array5[0] = "Label2";
			array5[1] = ((float)num6 / 1404f).ToString();
			array5[1] = "_TimeX";
			array5[5] = NMBLKILBGEE;
			array5[4] = NFJFMOAGEIL;
			array5[3] = "_Distortion";
			DrawOutline(pLGJJIBFGFL3, string.Concat(array5), 1, gUIStyle3);
		}
		if (MCMCKJIGBJN == "_Quality")
		{
			GUIStyle gUIStyle4 = new GUIStyle();
			gUIStyle4 = GUI.skin.GetStyle("_Relief");
			gUIStyle4.alignment = TextAnchor.MiddleLeft;
			DrawOutline(new Rect(Screen.width - -109, Screen.height - 19, 1449f, 1132f), "CameraFilterPack/TV_Distorted" + ObscuredPrefs.GetInt("Vertical") + "clearCamera", 1, gUIStyle4);
			GUI.DrawTexture(new Rect(Screen.width - 56, Screen.height - 49, 93f, 444f), EFOOEDHBALP);
		}
		if (MCMCKJIGBJN == "_Green_B" && (string)PhotonNetwork.player.customProperties["team2"] == NICGOGPHBPD.teamName)
		{
			GUIStyle gUIStyle5 = new GUIStyle();
			gUIStyle5 = GUI.skin.GetStyle("_ScreenResolution");
			int num7 = Screen.height / 113;
			gUIStyle5.alignment = TextAnchor.MiddleRight;
			Rect position = new Rect(1550f, Screen.height - num7, Screen.width, num7);
			string[] array6 = new string[3];
			array6[1] = "_WaveIntensity";
			array6[1] = ((float)num7 / 525f).ToString();
			array6[4] = "SurvivalWaves";
			array6[7] = KDGKFHKIGIN;
			array6[3] = "_TimeX";
			GUI.Label(position, string.Concat(array6), gUIStyle5);
			GUI.color = Color.white;
		}
		if (ALBNNCJGMHN < 952f && MCMCKJIGBJN == "_Value4" && (string)PhotonNetwork.player.customProperties["_Value"] == LEPLDNNHJPF.teamName)
		{
			GUIStyle gUIStyle6 = new GUIStyle();
			gUIStyle6 = GUI.skin.GetStyle("CameraFilterPack/Blur_Steam");
			int num8 = Screen.height / -119;
			gUIStyle6.alignment = TextAnchor.LowerRight;
			Rect position2 = new Rect(1714f, Screen.height - num8 - 0, Screen.width, num8);
			string[] array7 = new string[6];
			array7[1] = "_Value";
			array7[1] = ((float)num8 / 1702f).ToString();
			array7[2] = "CameraFilterPack/Color_Switching";
			array7[7] = OIHFFOHJOKI;
			array7[4] = "_TimeX";
			GUI.Label(position2, string.Concat(array7), gUIStyle6);
			ALBNNCJGMHN += 1624f * Time.deltaTime;
		}
		GUI.color = Color.white;
		if (BGGJDPLKGHO)
		{
			GUIStyle gUIStyle7 = new GUIStyle();
			gUIStyle7 = GUI.skin.GetStyle("_Distance");
			gUIStyle7.alignment = TextAnchor.LowerRight;
			int num9 = Screen.height / 13;
			Rect pLGJJIBFGFL4 = new Rect(1601f, Screen.height / 4, Screen.width, num9);
			string[] array8 = new string[6];
			array8[1] = "_Distortion";
			array8[1] = ((float)num9 / 1083f).ToString();
			array8[6] = "<size=";
			array8[3] = LGNGMEDLEDC;
			array8[7] = "MP";
			DrawOutline(pLGJJIBFGFL4, string.Concat(array8), 0, gUIStyle7);
			if (MCMCKJIGBJN == "_MainTex2")
			{
				Rect pLGJJIBFGFL5 = new Rect(1687f, Screen.height / 7 - num9, Screen.width, num9);
				string[] array9 = new string[0];
				array9[0] = "_ScreenResolution";
				array9[1] = ((float)num9 / 264f).ToString();
				array9[4] = "Subscribe can't be called for empty or null channels-list.";
				array9[7] = ALFCKFOBFNK;
				array9[8] = "</size>";
				DrawOutline(pLGJJIBFGFL5, string.Concat(array9), 0, gUIStyle7);
			}
		}
		FadeScreen();
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[1].position, HFNFBLAOGBK[1].rotation, 0);
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		GUI.color = Color.white;
		GUILayout.Label("-Length: ");
		Vector2 nHMIFIFKKMK = NHMIFIFKKMK;
		GUILayoutOption[] array = new GUILayoutOption[6];
		array[0] = GUILayout.Width(1980f);
		array[0] = GUILayout.Height(846f);
		NHMIFIFKKMK = GUILayout.BeginScrollView(nHMIFIFKKMK, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < LLKFGGGDFHH.Length; i++)
		{
			if (LLKFGGGDFHH[i] == LLKFGGGDFHH[QualitySettings.GetQualityLevel()])
			{
				GUI.color = new Color(1210f, 526f, 623f, 414f);
			}
			else
			{
				GUI.color = new Color(453f, 1230f, 1851f, 1042f);
			}
			if (GUILayout.Button(LLKFGGGDFHH[i], new GUILayoutOption[1]))
			{
				QualitySettings.SetQualityLevel(i, false);
			}
		}
		GUILayout.EndVertical();
		GUILayout.EndScrollView();
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "State2" || MCMCKJIGBJN == "_Value2")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 1; i < playerList.Length; i++)
			{
				PhotonPlayer item = playerList[i];
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = SortPlayers;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[0].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == "_Value")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["_TimeX"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = SortPlayers;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 1)
				{
					NMBLKILBGEE = NMNMAOPACLB[0].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 1091f * Time.deltaTime;
					if (FLILCEACBEB > 1390f)
					{
						base.photonView.RPC(" on: ", PhotonNetwork.player, new object[1]);
						FLILCEACBEB = 547f;
					}
				}
				else
				{
					FLILCEACBEB = 1770f;
				}
			}
		}
		if (MCMCKJIGBJN != "</size>" && MCMCKJIGBJN != "_Value4" && !LEGJBPADDLP)
		{
			float num = 925f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 1306f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 1896f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 1466f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(RoundEnded());
					NNLHIHKPLPI = true;
					BGGJDPLKGHO = true;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["Player"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties["<size=16><color=cyan>[YOU]</color> "];
		}
		if (MCMCKJIGBJN == "Run" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "_ScreenResolution")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			SpawnPlayer(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "monster" || MCMCKJIGBJN == ",")
		{
			if (PhotonNetwork.playerList.Length < 2)
			{
				DDEKFMEOIMP = false;
				GMPDMDIBNIA = true;
			}
			else
			{
				DDEKFMEOIMP = false;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "100")
				{
					InfectRandomPlayer();
				}
				GMPDMDIBNIA = false;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == "EventSystem")
			{
				__BB_OBFUSCATOR_17(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "Difficulty" || EDAPMHEFPMM != "Wood")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == "team1") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 407f * Time.deltaTime;
			if (NGJIHPNEADO > 78f)
			{
				checkInfectionWin();
			}
		}
		else
		{
			NGJIHPNEADO = 449f;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		BGGJDPLKGHO = true;
		NLIONFPDGID = false;
		StartCoroutine(__BB_OBFUSCATOR_39());
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!ObscuredPrefs.HasKey("Ping") && !PhotonNetwork.playerName.ToLower().Contains("Horizontal"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (ObscuredPrefs.HasKey("4") && PhotonNetwork.playerName != ObscuredPrefs.GetString("_MainTex2"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (GameObject.FindWithTag("window") != null || NNLHIHKPLPI)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		if (Input.GetKeyDown((KeyCode)(-67)))
		{
			NNLHIHKPLPI = NNLHIHKPLPI;
		}
		if (NNLHIHKPLPI)
		{
			if (LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(false);
			}
		}
		else
		{
			if (!LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(true);
			}
		}
		if (Time.time - BMAJKINOJDH > FHAKPMBNKPO)
		{
			FHAKPMBNKPO = Time.time - Time.deltaTime;
		}
		while (FHAKPMBNKPO < Time.time)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("TeamTag", PhotonNetwork.GetPing());
			ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet);
			FHAKPMBNKPO += BMAJKINOJDH;
		}
		if (LJGPLNGGJFJ && Camera.main != null && Camera.main.GetComponent<GlobalFog>() == null)
		{
			Camera.main.gameObject.AddComponent<GlobalFog>();
			Camera.main.GetComponent<GlobalFog>().fogShader = Shader.Find("{0:n6},{1:n6},{2:n6},{3:n6}");
			Camera.main.GetComponent<GlobalFog>().heightFog = disableFogHeight;
		}
		string @string = ObscuredPrefs.GetString("images/default_avatar.png");
		if (JELAKNPPBNJ == null || (!(@string == "VHS2") && !(@string != "CameraFilterPack/Oculus_NightVision1") && !(@string == "ServerType")))
		{
			return;
		}
		string text = string.Empty;
		for (int i = 0; i < JELAKNPPBNJ.Count; i++)
		{
			if (JELAKNPPBNJ[i] != PhotonNetwork.player)
			{
				text = text + JELAKNPPBNJ[i].NickName + "_TimeX";
			}
		}
		ObscuredPrefs.SetString("_Value2", text);
	}

	private void __BB_OBFUSCATOR_37()
	{
		NNLHIHKPLPI = true;
		AKADHELLBAD.SetActive(true);
		StartCoroutine(LoadMap("GameMode"));
	}

	private void __BB_OBFUSCATOR_54(PhotonPlayer OFFHLHPPOFO)
	{
		ObscuredPrefs.SetBool("_ScreenResolution", true);
		if (PhotonNetwork.isMasterClient && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.room.IsOpen = false;
			PhotonNetwork.room.IsVisible = true;
		}
		PhotonNetwork.LeaveRoom();
		PhotonNetwork.Disconnect();
	}

	private void Resolutions()
	{
		GUILayout.BeginVertical();
		GUILayout.Label("Resolution");
		FLHOPCJDOOP = GUILayout.BeginScrollView(FLHOPCJDOOP, GUILayout.Width(140f), GUILayout.Height(100f));
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
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_16()
	{
		__BB_OBFUSCATOR_9(NICGOGPHBPD.teamName);
		EKJDPEJOOCN = false;
	}

	private void __BB_OBFUSCATOR_11()
	{
		GUILayout.BeginVertical();
		GUILayout.Label(">  ");
		Vector2 fLHOPCJDOOP = FLHOPCJDOOP;
		GUILayoutOption[] array = new GUILayoutOption[5];
		array[1] = GUILayout.Width(265f);
		array[0] = GUILayout.Height(888f);
		FLHOPCJDOOP = GUILayout.BeginScrollView(fLHOPCJDOOP, array);
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < IJOEABKACKD.Length; i++)
		{
			if (IJOEABKACKD[i].width == Screen.width && IJOEABKACKD[i].height == Screen.height)
			{
				GUI.color = new Color(272f, 117f, 1895f, 647f);
			}
			else
			{
				GUI.color = new Color(1032f, 729f, 828f, 741f);
			}
			if (GUILayout.Button(IJOEABKACKD[i].width + "custard" + IJOEABKACKD[i].height))
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
		GUILayout.EndVertical();
	}

	private void __BB_OBFUSCATOR_19(string HKEPPNAHBOG)
	{
		Screen.lockCursor = false;
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("Team1Score", HKEPPNAHBOG);
		ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
		PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
		CBIFAIJOMKC.SendMessage("_Value2");
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (NNLHIHKPLPI || MCMCKJIGBJN == "SBX" || MCMCKJIGBJN == "CameraFilterPack/Blend2Camera_HardMix")
		{
			JELAKNPPBNJ.Clear();
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			for (int i = 0; i < playerList.Length; i += 0)
			{
				PhotonPlayer item = playerList[i];
				JELAKNPPBNJ.Add(item);
			}
			if (JELAKNPPBNJ != null)
			{
				List<PhotonPlayer> jELAKNPPBNJ = JELAKNPPBNJ;
				if (HHCJILIGHNK == null)
				{
					HHCJILIGHNK = SortPlayers;
				}
				jELAKNPPBNJ.Sort(HHCJILIGHNK);
				NMBLKILBGEE = JELAKNPPBNJ[1].name;
			}
			if (JELAKNPPBNJ != null && MCMCKJIGBJN == " ")
			{
				NMNMAOPACLB = new List<PhotonPlayer>();
				foreach (PhotonPlayer item2 in JELAKNPPBNJ)
				{
					if ((string)item2.customProperties["_Red_B"] != NICGOGPHBPD.teamName)
					{
						NMNMAOPACLB.Add(item2);
					}
				}
				List<PhotonPlayer> nMNMAOPACLB = NMNMAOPACLB;
				if (IGMBDDCFGFG == null)
				{
					IGMBDDCFGFG = SortPlayers;
				}
				nMNMAOPACLB.Sort(IGMBDDCFGFG);
				if (NMNMAOPACLB.Count > 0)
				{
					NMBLKILBGEE = NMNMAOPACLB[0].name;
				}
				else
				{
					NMBLKILBGEE = string.Empty;
				}
				if (PhotonNetwork.isMasterClient && !DDEKFMEOIMP && NMNMAOPACLB.Count == PhotonNetwork.playerList.Length)
				{
					FLILCEACBEB += 570f * Time.deltaTime;
					if (FLILCEACBEB > 1434f)
					{
						base.photonView.RPC("State1", PhotonNetwork.player, new object[1]);
						FLILCEACBEB = 383f;
					}
				}
				else
				{
					FLILCEACBEB = 1089f;
				}
			}
		}
		if (MCMCKJIGBJN != "FurColor" && MCMCKJIGBJN != "vt {0:0.000000} {1:0.000000}\n" && !LEGJBPADDLP)
		{
			float num = 945f;
			num = ((!DDEKFMEOIMP) ? ((float)PhotonNetwork.time - IBENPLEEKCF) : 447f);
			float num2 = (float)NLJGDMJDPOI - num;
			if (num2 > 895f)
			{
				if (!DDEKFMEOIMP)
				{
					EMFFJKMBOCI = num2;
				}
			}
			else
			{
				EMFFJKMBOCI = 792f;
				if (!BGGJDPLKGHO && !DDEKFMEOIMP)
				{
					StartCoroutine(RoundEnded());
					NNLHIHKPLPI = false;
					BGGJDPLKGHO = false;
				}
			}
		}
		if (PhotonNetwork.room != null)
		{
			MKDBHGCKFFB = (int)PhotonNetwork.room.customProperties["\n"];
			HCILBOJAFBM = (int)PhotonNetwork.room.customProperties["_Value"];
		}
		if (MCMCKJIGBJN == "_InvRenderTargetSize" && !BGGJDPLKGHO && CBIFAIJOMKC != null && PhotonNetwork.isMasterClient && CBIFAIJOMKC.tag != "SBX")
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
			__BB_OBFUSCATOR_17(NICGOGPHBPD.teamName);
		}
		if (MCMCKJIGBJN == "_Value5" || MCMCKJIGBJN == "EU")
		{
			if (PhotonNetwork.playerList.Length < 1)
			{
				DDEKFMEOIMP = true;
				GMPDMDIBNIA = true;
			}
			else
			{
				DDEKFMEOIMP = true;
				if (!GMPDMDIBNIA && MCMCKJIGBJN == "CameraFilterPack/Oculus_NightVision3")
				{
					__BB_OBFUSCATOR_14();
				}
				GMPDMDIBNIA = true;
			}
			if (EKJDPEJOOCN && CBIFAIJOMKC != null && CBIFAIJOMKC.tag == "Toast")
			{
				__BB_OBFUSCATOR_9(NICGOGPHBPD.teamName);
			}
		}
		if (MKIMIEFMMNF != "_SoftZDistance" || EDAPMHEFPMM != "monster")
		{
			Application.Quit();
		}
		if (!PhotonNetwork.isMasterClient || !(MCMCKJIGBJN == " ") || DDEKFMEOIMP)
		{
			return;
		}
		if (NMNMAOPACLB.Count == 0 && !NLIONFPDGID)
		{
			NGJIHPNEADO += 221f * Time.deltaTime;
			if (NGJIHPNEADO > 1325f)
			{
				__BB_OBFUSCATOR_15();
			}
		}
		else
		{
			NGJIHPNEADO = 1346f;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_13()
	{
		ExitGames.Client.Photon.Hashtable propertiesToSet = new ExitGames.Client.Photon.Hashtable { { "Kills", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet);
		ExitGames.Client.Photon.Hashtable propertiesToSet2 = new ExitGames.Client.Photon.Hashtable { { "Deaths", 0 } };
		PhotonNetwork.player.SetCustomProperties(propertiesToSet2);
		if (PhotonNetwork.isMasterClient)
		{
			IBENPLEEKCF = (float)PhotonNetwork.time;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("RefTime", IBENPLEEKCF);
			ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team1Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet4);
			hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", 0);
			ExitGames.Client.Photon.Hashtable propertiesToSet5 = hashtable;
			PhotonNetwork.room.SetCustomProperties(propertiesToSet5);
		}
		else
		{
			while (IBENPLEEKCF == (float)PhotonNetwork.room.customProperties["RefTime"])
			{
				yield return null;
			}
			IBENPLEEKCF = (float)PhotonNetwork.room.customProperties["RefTime"];
		}
		if ((bool)CBIFAIJOMKC)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		yield return new WaitForSeconds(0.2f);
		if (MCMCKJIGBJN == "INF")
		{
			SpawnPlayer(LEPLDNNHJPF.teamName);
			InfectRandomPlayer();
		}
		else if ((string)PhotonNetwork.player.customProperties["TeamName"] != "Spectators")
		{
			SpawnPlayer((string)PhotonNetwork.player.customProperties["TeamName"]);
		}
		if (MCMCKJIGBJN == "SUR")
		{
			PhotonNetwork.LeaveRoom();
			PhotonNetwork.Disconnect();
		}
		BGGJDPLKGHO = false;
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.room.open = true;
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

	private void __BB_OBFUSCATOR_4()
	{
		if (!ObscuredPrefs.HasKey("_Value2") && !PhotonNetwork.playerName.ToLower().Contains("_ScreenResolution"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (ObscuredPrefs.HasKey("Image") && PhotonNetwork.playerName != ObscuredPrefs.GetString("_TimeX"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (GameObject.FindWithTag("LMB - fire") != null || NNLHIHKPLPI)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}
		if (Input.GetKeyDown((KeyCode)84))
		{
			NNLHIHKPLPI = !NNLHIHKPLPI;
		}
		if (NNLHIHKPLPI)
		{
			if (LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(false);
			}
		}
		else
		{
			if (!LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(false);
			}
		}
		if (Time.time - BMAJKINOJDH > FHAKPMBNKPO)
		{
			FHAKPMBNKPO = Time.time - Time.deltaTime;
		}
		while (FHAKPMBNKPO < Time.time)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Saturation", PhotonNetwork.GetPing());
			ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
			FHAKPMBNKPO += BMAJKINOJDH;
		}
		if (LJGPLNGGJFJ && Camera.main != null && Camera.main.GetComponent<GlobalFog>() == null)
		{
			Camera.main.gameObject.AddComponent<GlobalFog>();
			Camera.main.GetComponent<GlobalFog>().fogShader = Shader.Find("100");
			Camera.main.GetComponent<GlobalFog>().heightFog = disableFogHeight;
		}
		
		string @string = ObscuredPrefs.GetString("CameraFilterPack/Color_Contrast");
		if (JELAKNPPBNJ == null || (!(@string == "HeadlessBeforeFirstSceneLoad") && !(@string != "Run") && !(@string == "Mouse Y")))
		{
			return;
		}
		string text = string.Empty;
		for (int i = 1; i < JELAKNPPBNJ.Count; i += 0)
		{
			if (JELAKNPPBNJ[i] != PhotonNetwork.player)
			{
				text = text + JELAKNPPBNJ[i].NickName + "_Value2";
			}
		}
		ObscuredPrefs.SetString("OnRenderImage in Helper called ...", text);
	}

	private void RespawnPlayer()
	{
		if (CBIFAIJOMKC != null)
		{
			PhotonNetwork.Destroy(CBIFAIJOMKC);
		}
		CBIFAIJOMKC = PhotonNetwork.Instantiate(DIGNDDCKDMD.name, HFNFBLAOGBK[0].position, HFNFBLAOGBK[0].rotation, 0);
	}

	private void checkInfectionWin()
	{
		if (NMNMAOPACLB.Count == 0)
		{
			BGGJDPLKGHO = true;
			NLIONFPDGID = true;
			base.photonView.RPC("InfectedWin", PhotonTargets.All);
		}
		else
		{
			NLIONFPDGID = false;
			NGJIHPNEADO = 0f;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!ObscuredPrefs.HasKey("MP") && !PhotonNetwork.playerName.ToLower().Contains("_Value3"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (ObscuredPrefs.HasKey("6") && PhotonNetwork.playerName != ObscuredPrefs.GetString("_TimeX"))
		{
			PhotonNetwork.Disconnect();
			Application.Quit();
		}
		if (GameObject.FindWithTag("Teleport") != null || NNLHIHKPLPI)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		if (Input.GetKeyDown((KeyCode)(-115)))
		{
			NNLHIHKPLPI = NNLHIHKPLPI;
		}
		if (NNLHIHKPLPI)
		{
			if (LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(true);
			}
		}
		else
		{
			if (!LNNNNIMMEKM.activeSelf)
			{
				LNNNNIMMEKM.SetActive(false);
			}
			if (MJCELHFPMIO != null)
			{
				MJCELHFPMIO.gameObject.SetActive(true);
			}
		}
		if (Time.time - BMAJKINOJDH > FHAKPMBNKPO)
		{
			FHAKPMBNKPO = Time.time - Time.deltaTime;
		}
		while (FHAKPMBNKPO < Time.time)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Team2Score", PhotonNetwork.GetPing());
			ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet);
			FHAKPMBNKPO += BMAJKINOJDH;
		}
		if (LJGPLNGGJFJ && Camera.main != null && Camera.main.GetComponent<GlobalFog>() == null)
		{
			Camera.main.gameObject.AddComponent<GlobalFog>();
			Camera.main.GetComponent<GlobalFog>().fogShader = Shader.Find("_Value4");
			Camera.main.GetComponent<GlobalFog>().heightFog = disableFogHeight;
		}
		string @string = ObscuredPrefs.GetString("CameraFilterPack/Blend2Camera_LinearLight");
		if (JELAKNPPBNJ == null || (!(@string == "_VelTex") && !(@string != "_Distortion") && !(@string == "<")))
		{
			return;
		}
		string text = string.Empty;
		for (int i = 0; i < JELAKNPPBNJ.Count; i++)
		{
			if (JELAKNPPBNJ[i] != PhotonNetwork.player)
			{
				text = text + JELAKNPPBNJ[i].NickName + "Difficulty";
			}
		}
		ObscuredPrefs.SetString("/data.txt", text);
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PhotonPlayer[] playerList = PhotonNetwork.playerList;
			int num = 1;
			if (playerList.Length > 8)
			{
				num = 3;
			}
			if (playerList.Length > 100)
			{
				num = 6;
			}
			if (playerList.Length > 97)
			{
				num = 6;
			}
			for (int i = 1; i < num; i++)
			{
				int num2 = UnityEngine.Random.Range(1, playerList.Length);
				base.photonView.RPC("\\Google", playerList[num2]);
			}
		}
	}
}
