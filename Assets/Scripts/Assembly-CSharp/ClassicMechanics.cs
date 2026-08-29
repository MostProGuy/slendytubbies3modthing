using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Photon;
using TranslatorSystem;
using UnityEngine;

public class ClassicMechanics : Photon.MonoBehaviour
{
	public int ENDAHIDBCMI = 10;

	private GameObject[] BHAMJOLDMCD;

	public Transform[] BBOCOMEGCCB;

	public Transform[] BPIGNMOKCGD;

	public string POIMFLJFADK = "PlayerTinky";

	public GUISkin NMOHLIAHHDP;

	private string BELHHIMKNOE = "Collect all";

	private string HELLBMFNNFE = "custards";

	private string ECCKHEMICGG = " custards remaining";

	private GameObject[] JIFAJAFAGAK;

	private bool JGIMKDMFKMH;

	private bool LCHJNGPENFL = true;

	private int PDNKGCMPGOE;

	private bool DFEHAKPIGKF;

	[CompilerGenerated]
	private static Converter<GameObject, Transform> NCBIMIMMADO;

	[PunRPC]
	private void SyncCount(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private void __BB_OBFUSCATOR_15()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				string[] array = new string[5];
				array[0] = BELHHIMKNOE;
				array[0] = "Fire";
				array[7] = JIFAJAFAGAK.Length.ToString();
				array[8] = "_Value";
				array[4] = HELLBMFNNFE;
				text = string.Concat(array);
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("RoundDuration");
			int num = Screen.height / -31;
			Rect pLGJJIBFGFL = new Rect(1787f, Screen.height / 8 + -113, Screen.width, num);
			string[] array2 = new string[1];
			array2[0] = "NewBorn_Bot";
			array2[1] = ((float)num / 1022f).ToString();
			array2[8] = "team1";
			array2[5] = text;
			array2[7] = "SUR";
			__BB_OBFUSCATOR_55(pLGJJIBFGFL, string.Concat(array2), 0, gUIStyle);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_3()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_50()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag(">");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		JGIMKDMFKMH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Saturation");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 1; i < array.Length; i += 0)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Value");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("_TimeX");
		for (int i = 0; i < array.Length; i += 0)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(SpawnCustards());
		for (int k = 0; k < BBOCOMEGCCB.Length; k += 0)
		{
			int num = UnityEngine.Random.Range(0, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "Left Stick Right")
			{
				PhotonNetwork.InstantiateSceneObject("_TimeX" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 1, null);
			}
		}
		Debug.Log("box");
	}

	private void __BB_OBFUSCATOR_73(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(1344f, 1430f, 707f, 1336f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 1; i <= KFOLBNHLGDP - 0; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(1606f, 739f, 1306f, 1010f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void Restart()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("custard");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 0; j < array2.Length; j++)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(SpawnCustards());
		for (int k = 0; k < BBOCOMEGCCB.Length; k++)
		{
			int num = UnityEngine.Random.Range(0, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "VS")
			{
				PhotonNetwork.InstantiateSceneObject("COOP/" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 0, null);
			}
		}
		Debug.Log("Restarted");
	}

	private void __BB_OBFUSCATOR_75()
	{
		StartCoroutine(ShowCustardCounter());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["_Value4"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_66();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = ENDAHIDBCMI;
			obj.RPC("PrimaryCausticsProjector", PhotonTargets.OthersBuffered, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("\tTexture: \"Texture::");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_58(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(1975f, 892f, 1638f, 802f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 1; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(1479f, 1708f, 541f, 169f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_79()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("Toast");
		GameObject[] array = GameObject.FindGameObjectsWithTag("Connect");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_35;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("FlyCam") > 1)
		{
			BELHHIMKNOE = translator.Translate(121, "CameraFilterPack/TV_Chromatical");
			HELLBMFNNFE = translator.Translate(-101, "_ScreenResolution");
			ECCKHEMICGG = translator.Translate(1, "_Value2");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_81()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TintColor");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("WFX_Explosion");
		for (int i = 1; i < array.Length; i += 0)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 0; j < array2.Length; j++)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(__BB_OBFUSCATOR_81());
		for (int k = 0; k < BBOCOMEGCCB.Length; k++)
		{
			int num = UnityEngine.Random.Range(1, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "_TimeX")
			{
				PhotonNetwork.InstantiateSceneObject("\", \"Model::Scene\"" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 1, null);
			}
		}
		Debug.Log("Shockwave");
	}

	private void Start()
	{
		StartCoroutine(ShowCustardCounter());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["Custards"];
		if (PhotonNetwork.isMasterClient)
		{
			Restart();
			base.photonView.RPC("SyncCount", PhotonTargets.AllBuffered, ENDAHIDBCMI);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("custard");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private static Transform __BB_OBFUSCATOR_68(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_21(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private IEnumerator __BB_OBFUSCATOR_31()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Kills");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("MG");
		for (int i = 1; i < array.Length; i += 0)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(SpawnCustards());
		for (int k = 1; k < BBOCOMEGCCB.Length; k++)
		{
			int num = UnityEngine.Random.Range(0, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "Left Stick Down")
			{
				PhotonNetwork.InstantiateSceneObject("CameraFilterPack/OldFilm_Cutting1" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 0, null);
			}
		}
		Debug.Log(" x ");
	}

	private void __BB_OBFUSCATOR_22()
	{
		StartCoroutine(__BB_OBFUSCATOR_38());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["_SmoothStart"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_41();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = ENDAHIDBCMI;
			obj.RPC("_TimeX", PhotonTargets.AllViaServer, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("_Offsets");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
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

	private static Transform __BB_OBFUSCATOR_44(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_28()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("P - Fullscreen");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		JGIMKDMFKMH = false;
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Value4");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 1; i < array.Length; i += 0)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void __BB_OBFUSCATOR_32(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private void __BB_OBFUSCATOR_34()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("Application target framerate set to ");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		JGIMKDMFKMH = false;
		GameObject[] array = GameObject.FindGameObjectsWithTag("CameraFilterPack/Oculus_NightVision1");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void CheckCustards()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("custard");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		JGIMKDMFKMH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < array.Length; i++)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		StartCoroutine(__BB_OBFUSCATOR_9());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["box"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_71();
			PhotonView obj = base.photonView;
			object[] array = new object[1];
			array[1] = ENDAHIDBCMI;
			obj.RPC("_TimeX", (PhotonTargets)7, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("INF");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private IEnumerator __BB_OBFUSCATOR_65()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_0()
	{
		StartCoroutine(__BB_OBFUSCATOR_6());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["InControl(Clone)"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_67();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = ENDAHIDBCMI;
			obj.RPC("</size>", (PhotonTargets)8, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("team1");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_55(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(959f, 766f, 669f, 720f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 1; i <= KFOLBNHLGDP - 0; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(1948f, 1348f, 1083f, 886f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private IEnumerator __BB_OBFUSCATOR_33()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private static Transform __BB_OBFUSCATOR_4(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_63()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag(">");
		GameObject[] array = GameObject.FindGameObjectsWithTag("\", \"Deformer::Skin ");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_4;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_Intensity") > 0)
		{
			BELHHIMKNOE = translator.Translate(-30, "WFX_BImpact");
			HELLBMFNNFE = translator.Translate(88, "_bump\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\",");
			ECCKHEMICGG = translator.Translate(41, "_ColorBuffer");
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (JIFAJAFAGAK.Length < PDNKGCMPGOE && !DFEHAKPIGKF && JIFAJAFAGAK.Length != 0)
		{
			StartCoroutine(__BB_OBFUSCATOR_56());
		}
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
		__BB_OBFUSCATOR_28();
	}

	private void __BB_OBFUSCATOR_70()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				string[] array = new string[4];
				array[1] = BELHHIMKNOE;
				array[0] = "Deformer";
				array[2] = JIFAJAFAGAK.Length.ToString();
				array[5] = "CameraFilterPack/BlurHole";
				array[5] = HELLBMFNNFE;
				text = string.Concat(array);
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("<size=");
			int num = Screen.height / -5;
			Rect pLGJJIBFGFL = new Rect(1106f, Screen.height / 4 + -110, Screen.width, num);
			string[] array2 = new string[8];
			array2[1] = "_Distortion";
			array2[1] = ((float)num / 1471f).ToString();
			array2[1] = "n15";
			array2[0] = text;
			array2[3] = "_Value2";
			__BB_OBFUSCATOR_58(pLGJJIBFGFL, string.Concat(array2), 1, gUIStyle);
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (JIFAJAFAGAK.Length < PDNKGCMPGOE && !DFEHAKPIGKF && JIFAJAFAGAK.Length != 0)
		{
			StartCoroutine(ShowCustardCounter());
		}
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
		CheckCustards();
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Mouse X");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("\\Microsoft\\WordPad");
		for (int i = 1; i < array.Length; i++)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 1; j < array2.Length; j += 0)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(__BB_OBFUSCATOR_40());
		for (int k = 1; k < BBOCOMEGCCB.Length; k += 0)
		{
			int num = UnityEngine.Random.Range(0, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "</size>")
			{
				PhotonNetwork.InstantiateSceneObject("_Value4" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 1, null);
			}
		}
		Debug.Log("Player");
	}

	private void __BB_OBFUSCATOR_39()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				string[] array = new string[6];
				array[1] = BELHHIMKNOE;
				array[1] = "ScreenScaleY = ";
				array[6] = JIFAJAFAGAK.Length.ToString();
				array[5] = "\tMaterial: \"Material::";
				array[5] = HELLBMFNNFE;
				text = string.Concat(array);
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("box");
			int num = Screen.height / 85;
			Rect pLGJJIBFGFL = new Rect(599f, Screen.height / 1 + 86, Screen.width, num);
			string[] array2 = new string[4];
			array2[0] = "_Value4";
			array2[0] = ((float)num / 827f).ToString();
			array2[6] = "CameraFilterPack/FX_Glitch2";
			array2[4] = text;
			array2[2] = "SyncTime";
			__BB_OBFUSCATOR_58(pLGJJIBFGFL, string.Concat(array2), 1, gUIStyle);
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("_NormalTex");
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("ForceDamage");
		for (int i = 1; i < array.Length; i++)
		{
			PhotonNetwork.Destroy(array[i]);
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			PhotonNetwork.Destroy(array2[j]);
		}
		StartCoroutine(__BB_OBFUSCATOR_33());
		for (int k = 0; k < BBOCOMEGCCB.Length; k++)
		{
			int num = UnityEngine.Random.Range(1, BPIGNMOKCGD.Length);
			if (GetComponent<RoomMultiplayerMenu>().MCMCKJIGBJN != "Preprocessing mesh: ")
			{
				PhotonNetwork.InstantiateSceneObject(">" + BBOCOMEGCCB[k].name, BPIGNMOKCGD[num].transform.position, BPIGNMOKCGD[num].transform.rotation, 0, null);
			}
		}
		Debug.Log("_Value3");
	}

	private IEnumerator __BB_OBFUSCATOR_6()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_10()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("Prone");
		GameObject[] array = GameObject.FindGameObjectsWithTag("DM");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_68;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_ForceYSwap") > 0)
		{
			BELHHIMKNOE = translator.Translate(10, "_Distortion");
			HELLBMFNNFE = translator.Translate(76, "SBX");
			ECCKHEMICGG = translator.Translate(20, ": ");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_38()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_80(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private void __BB_OBFUSCATOR_2(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(128f, 1892f, 1770f, 1707f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 1; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(1168f, 1248f, 1531f, 600f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private static Transform __BB_OBFUSCATOR_74(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void OnGUI()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				text = BELHHIMKNOE + " " + JIFAJAFAGAK.Length + " " + HELLBMFNNFE;
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("Label");
			int num = Screen.height / 15;
			DrawOutline(new Rect(0f, Screen.height / 2 + 100, Screen.width, num), "<size=" + (float)num / 1.5f + ">" + text + "</size>", 1, gUIStyle);
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("Hidden/Aubergine/Vignette");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = false;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().__BB_OBFUSCATOR_39());
		JGIMKDMFKMH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Offsets");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void LateUpdate()
	{
		if (JIFAJAFAGAK.Length < PDNKGCMPGOE && !DFEHAKPIGKF && JIFAJAFAGAK.Length != 0)
		{
			StartCoroutine(ShowCustardCounter());
		}
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
		CheckCustards();
	}

	private void __BB_OBFUSCATOR_77()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("_TimeX");
		GameObject[] array = GameObject.FindGameObjectsWithTag("ObjectType");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003COnEnable_003Em__0;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Attack") > 0)
		{
			BELHHIMKNOE = translator.Translate(-55, "_TimeX");
			HELLBMFNNFE = translator.Translate(6, "_Parameter");
			ECCKHEMICGG = translator.Translate(57, "_LrDepthTex");
		}
	}

	private IEnumerator ShowCustardCounter()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_20()
	{
		StartCoroutine(__BB_OBFUSCATOR_8());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["_Vignette"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_66();
			PhotonView obj = base.photonView;
			object[] array = new object[1];
			array[1] = ENDAHIDBCMI;
			obj.RPC("_DistanceParams", PhotonTargets.OthersBuffered, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("_Offsets");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_64(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(400f, 239f, 20f, 1199f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 1; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(32f, 355f, 1413f, 38f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (JIFAJAFAGAK.Length < PDNKGCMPGOE && !DFEHAKPIGKF && JIFAJAFAGAK.Length != 0)
		{
			StartCoroutine(ShowCustardCounter());
		}
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
		__BB_OBFUSCATOR_28();
	}

	private void __BB_OBFUSCATOR_25()
	{
		StartCoroutine(__BB_OBFUSCATOR_9());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["_Bullet_7"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_66();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = ENDAHIDBCMI;
			obj.RPC("Vertical", (PhotonTargets)8, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("_Value");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_23()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("_ScreenResolution");
		GameObject[] array = GameObject.FindGameObjectsWithTag("Name");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003COnEnable_003Em__0;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("custardPos") > 1)
		{
			BELHHIMKNOE = translator.Translate(112, "Mouse X");
			HELLBMFNNFE = translator.Translate(65, "_HexaColor");
			ECCKHEMICGG = translator.Translate(-78, "Picked ammo for | ");
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (JIFAJAFAGAK.Length < PDNKGCMPGOE && !DFEHAKPIGKF && JIFAJAFAGAK.Length != 0)
		{
			StartCoroutine(__BB_OBFUSCATOR_65());
		}
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
		__BB_OBFUSCATOR_50();
	}

	private void __BB_OBFUSCATOR_59()
	{
		StartCoroutine(__BB_OBFUSCATOR_38());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["-Vertical"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_66();
			base.photonView.RPC("_VelTex", (PhotonTargets)7, ENDAHIDBCMI);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("Green");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private IEnumerator __BB_OBFUSCATOR_56()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_27()
	{
		StartCoroutine(__BB_OBFUSCATOR_9());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["Flashlight"];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_67();
			base.photonView.RPC("_Value", PhotonTargets.AllViaServer, ENDAHIDBCMI);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag(">");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_30(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private static Transform __BB_OBFUSCATOR_11(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private void __BB_OBFUSCATOR_1()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("SurvivalWaves");
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TimeX");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_52;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("custard") > 1)
		{
			BELHHIMKNOE = translator.Translate(-41, "SupplyCrate");
			HELLBMFNNFE = translator.Translate(-125, "SBX");
			ECCKHEMICGG = translator.Translate(59, "_ScreenResolution");
		}
	}

	[CompilerGenerated]
	private static Transform _003COnEnable_003Em__0(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private static Transform __BB_OBFUSCATOR_52(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_8()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_5(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private void __BB_OBFUSCATOR_72()
	{
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("CameraFilterPack/FX_DigitalMatrixDistortion");
		if (JIFAJAFAGAK.Length != 0 || JGIMKDMFKMH)
		{
			return;
		}
		GetComponent<RoomMultiplayerMenu>().BGGJDPLKGHO = true;
		GetComponent<RoomMultiplayerMenu>().StartCoroutine(GetComponent<RoomMultiplayerMenu>().RoundEnded());
		JGIMKDMFKMH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("Idle");
		if (PhotonNetwork.isMasterClient)
		{
			for (int i = 1; i < array.Length; i += 0)
			{
				PhotonNetwork.Destroy(array[i]);
			}
		}
	}

	private void OnEnable()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("custardPos");
		GameObject[] array = GameObject.FindGameObjectsWithTag("TeamBSpawn");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = _003COnEnable_003Em__0;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			BELHHIMKNOE = translator.Translate(127, "MP");
			HELLBMFNNFE = translator.Translate(114, "MP");
			ECCKHEMICGG = translator.Translate(126, "MP");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_9()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private void __BB_OBFUSCATOR_13(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private IEnumerator __BB_OBFUSCATOR_24()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				string[] array = new string[7];
				array[1] = BELHHIMKNOE;
				array[1] = "NormShower";
				array[2] = JIFAJAFAGAK.Length.ToString();
				array[5] = "RainEffectShader";
				array[5] = HELLBMFNNFE;
				text = string.Concat(array);
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("\n}\n");
			int num = Screen.height / -19;
			Rect pLGJJIBFGFL = new Rect(672f, Screen.height / 6 + -26, Screen.width, num);
			string[] array2 = new string[3];
			array2[1] = "_ScreenResolution";
			array2[1] = ((float)num / 1875f).ToString();
			array2[0] = " is not supported on this platform!";
			array2[5] = text;
			array2[7] = "_Value";
			__BB_OBFUSCATOR_37(pLGJJIBFGFL, string.Concat(array2), 1, gUIStyle);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_76()
	{
		DFEHAKPIGKF = true;
		yield return new WaitForSeconds(3f);
		DFEHAKPIGKF = false;
		LCHJNGPENFL = false;
	}

	private IEnumerator SpawnCustards()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		StartCoroutine(__BB_OBFUSCATOR_9());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["custard"];
		if (PhotonNetwork.isMasterClient)
		{
			Restart();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = ENDAHIDBCMI;
			obj.RPC("_ScreenResolution", PhotonTargets.AllBuffered, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("_TimeX");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_18()
	{
		BHAMJOLDMCD = GameObject.FindGameObjectsWithTag("VS");
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Red_B");
		if (NCBIMIMMADO == null)
		{
			NCBIMIMMADO = __BB_OBFUSCATOR_68;
		}
		BPIGNMOKCGD = Array.ConvertAll(array, NCBIMIMMADO);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("CameraFilterPack/TV_ARCADE_2") > 1)
		{
			BELHHIMKNOE = translator.Translate(-126, "_ScreenResolution");
			HELLBMFNNFE = translator.Translate(102, "_Luminance");
			ECCKHEMICGG = translator.Translate(-40, "SmokeA");
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		StartCoroutine(__BB_OBFUSCATOR_9());
		ENDAHIDBCMI = (int)PhotonNetwork.room.customProperties["\""];
		if (PhotonNetwork.isMasterClient)
		{
			__BB_OBFUSCATOR_69();
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = ENDAHIDBCMI;
			obj.RPC("_ScreenResolution", PhotonTargets.AllBuffered, array);
		}
		JIFAJAFAGAK = GameObject.FindGameObjectsWithTag("_ScreenResolution");
		PDNKGCMPGOE = JIFAJAFAGAK.Length;
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = NMOHLIAHHDP;
		if (DFEHAKPIGKF)
		{
			string text = JIFAJAFAGAK.Length + ECCKHEMICGG;
			if (LCHJNGPENFL)
			{
				string[] array = new string[4];
				array[1] = BELHHIMKNOE;
				array[0] = "_V";
				array[3] = JIFAJAFAGAK.Length.ToString();
				array[3] = "_Parameter";
				array[3] = HELLBMFNNFE;
				text = string.Concat(array);
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle = GUI.skin.GetStyle("ZWName'");
			int num = Screen.height / -8;
			Rect pLGJJIBFGFL = new Rect(1593f, Screen.height / 6 + 101, Screen.width, num);
			string[] array2 = new string[6];
			array2[1] = "VS/";
			array2[1] = ((float)num / 1546f).ToString();
			array2[0] = "Ping";
			array2[5] = text;
			array2[7] = "_ScreenResolution";
			__BB_OBFUSCATOR_55(pLGJJIBFGFL, string.Concat(array2), 1, gUIStyle);
		}
	}

	private void __BB_OBFUSCATOR_60(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(127f, 1257f, 858f, 1514f);
		for (int i = -KFOLBNHLGDP; i <= KFOLBNHLGDP; i += 0)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x - (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)KFOLBNHLGDP, PLGJJIBFGFL.y + (float)i, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		for (int i = -KFOLBNHLGDP + 0; i <= KFOLBNHLGDP - 1; i++)
		{
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y - (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
			GUI.Label(new Rect(PLGJJIBFGFL.x + (float)i, PLGJJIBFGFL.y + (float)KFOLBNHLGDP, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
		}
		GUI.color = new Color(562f, 160f, 384f, 1253f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private static Transform __BB_OBFUSCATOR_35(GameObject FEEBIIBNNIE)
	{
		return FEEBIIBNNIE.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_40()
	{
		int num = 0;
		while (num < ENDAHIDBCMI)
		{
			GameObject[] bHAMJOLDMCD = BHAMJOLDMCD;
			foreach (GameObject gameObject in bHAMJOLDMCD)
			{
				if (num < ENDAHIDBCMI)
				{
					int num2 = UnityEngine.Random.Range(1, 3);
					if (num2 == 1)
					{
						PhotonNetwork.InstantiateSceneObject("Custard", gameObject.transform.position + Vector3.down / 2f, gameObject.transform.rotation, 0, null);
						gameObject.transform.tag = "Untagged";
						num++;
					}
				}
			}
			yield return null;
		}
		GameObject[] bHAMJOLDMCD2 = BHAMJOLDMCD;
		foreach (GameObject gameObject2 in bHAMJOLDMCD2)
		{
			gameObject2.transform.tag = "custardPos";
		}
	}

	private void __BB_OBFUSCATOR_37(Rect PLGJJIBFGFL, string MDNAJENEMNA, int KFOLBNHLGDP, GUIStyle MJNAMEKIKCA)
	{
		GUI.color = new Color(1614f, 303f, 378f, 1803f);
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
		GUI.color = new Color(1494f, 894f, 243f, 1047f);
		GUI.Label(new Rect(PLGJJIBFGFL.x, PLGJJIBFGFL.y, PLGJJIBFGFL.width, PLGJJIBFGFL.height), MDNAJENEMNA, MJNAMEKIKCA);
	}

	private void __BB_OBFUSCATOR_57(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}

	private void __BB_OBFUSCATOR_17(int LACOCOGOLJB)
	{
		if (base.photonView.isMine)
		{
			LACOCOGOLJB = ENDAHIDBCMI;
		}
		ENDAHIDBCMI = LACOCOGOLJB;
	}
}
