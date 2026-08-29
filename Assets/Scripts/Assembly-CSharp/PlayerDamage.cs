using System;
using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : Photon.MonoBehaviour
{
	[Serializable]
	public class HitBoxes
	{
		public Collider box;

		public float damage;

		public HitBoxes(Collider MINDBGMPHCM, float MGMPEMABGIB)
		{
			box = MINDBGMPHCM;
			damage = MGMPEMABGIB;
		}
	}

	public GUISkin KIMBOADOOCP;

	public float CNNOMBEAPIH = 100f;

	public GameObject NHDPIMJDMMN;

	public Texture2D LNELIMFLEEB;

	public Texture2D OFKEGGGEELK;

	public Transform MIOJDLBFKKK;

	public List<HitBoxes> FHPCHEPEFFL = new List<HitBoxes>();

	[HideInInspector]
	public ObscuredFloat HLPBCOGDPCF;

	private Quaternion KGLACHBFGJK;

	private Quaternion MEHHMEOKNOM;

	private float ECKCMCNLLAE;

	private float CAKHHFLMPAE;

	[HideInInspector]
	public bool OPGALEOOEII;

	public bool OHEOLDDNBII;

	private RoomMultiplayerMenu OGKPPJHGFHD;

	private GameObject MCDJLOECKJI;

	public RectTransform IDOKOFJLMGD;

	private int HEAKJAPBDGE = 1;

	[PunRPC]
	private void DoDamage(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if ((float)HLPBCOGDPCF > 0f && base.photonView.isMine)
		{
			StopAllCoroutines();
			StartCoroutine(doCameraShake());
		}
		CAKHHFLMPAE = 2f;
		HLPBCOGDPCF = (float)HLPBCOGDPCF - LNBAOJFOGDF * (float)HEAKJAPBDGE;
		if (!((float)HLPBCOGDPCF < 0f))
		{
			return;
		}
		for (int i = 0; i < base.transform.childCount; i++)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		MIOJDLBFKKK.gameObject.SetActive(true);
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("AddKillNotification", base.gameObject.name, SendMessageOptions.DontRequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["Kills"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				int num2 = 0;
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.up, base.transform.rotation);
			gameObject.SendMessage("RespawnAfter");
			int num3 = (int)PhotonNetwork.player.customProperties["Deaths"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Deaths", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(0.2f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("PlayerFellDown", PhotonNetwork.player.name, SendMessageOptions.DontRequireReceiver);
			}
		}
		HLPBCOGDPCF = 0f;
		OHEOLDDNBII = true;
	}

	private void __BB_OBFUSCATOR_21()
	{
		ECKCMCNLLAE = Mathf.Lerp(ECKCMCNLLAE, 1284f, Time.deltaTime * 1368f);
		CAKHHFLMPAE = Mathf.Lerp(CAKHHFLMPAE, 309f, Time.deltaTime * 845f);
		if ((bool)Camera.main)
		{
			Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, KGLACHBFGJK, Time.deltaTime * 770f);
		}
		if (base.photonView.isMine)
		{
			if ((float)HLPBCOGDPCF > CNNOMBEAPIH)
			{
				HLPBCOGDPCF = 759f;
			}
			if ((float)HLPBCOGDPCF > 695f)
			{
				Application.Quit();
			}
		}
	}

	private IEnumerator DestroyPlayer(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private void OnGUI()
	{
		if (base.photonView.isMine)
		{
			GUI.skin = KIMBOADOOCP;
			GUI.color = new Color(1f, 1f, 1f, 0.9f);
			GUI.depth = 10;
			GUI.color = new Color(1f, 1f, 1f, CAKHHFLMPAE);
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), LNELIMFLEEB, ScaleMode.StretchToFill);
			GUI.color = new Color(1f, 1f, 1f, 0.9f);
			float num = (float)HLPBCOGDPCF / CNNOMBEAPIH;
			IDOKOFJLMGD.localScale = new Vector3(num, 1f, 1f);
			IDOKOFJLMGD.GetComponent<Image>().color = new Color(1f, num, num, 0.5f);
			IDOKOFJLMGD.parent.Find("Percent").GetComponent<Text>().text = (int)(float)HLPBCOGDPCF + string.Empty;
		}
		else
		{
			GUI.color = new Color(1f, 1f, 1f, ECKCMCNLLAE);
			GUI.DrawTexture(new Rect(Screen.width / 2 - 13, Screen.height / 2 - 13, 26f, 26f), OFKEGGGEELK, ScaleMode.StretchToFill);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_7(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private IEnumerator doCameraShake()
	{
		KGLACHBFGJK = Quaternion.Euler(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10), 0f);
		yield return new WaitForSeconds(0.1f);
		KGLACHBFGJK = MEHHMEOKNOM;
	}

	private void __BB_OBFUSCATOR_11()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position, base.transform.rotation);
		if (base.photonView.isMine)
		{
			gameObject.SendMessage("Custards");
			StartCoroutine(DestroyPlayer(61f));
		}
		else
		{
			gameObject.SendMessage("-Normalized Time: ");
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		ECKCMCNLLAE = Mathf.Lerp(ECKCMCNLLAE, 591f, Time.deltaTime * 1545f);
		CAKHHFLMPAE = Mathf.Lerp(CAKHHFLMPAE, 1503f, Time.deltaTime * 807f);
		if ((bool)Camera.main)
		{
			Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, KGLACHBFGJK, Time.deltaTime * 98f);
		}
		if (base.photonView.isMine)
		{
			if ((float)HLPBCOGDPCF > CNNOMBEAPIH)
			{
				HLPBCOGDPCF = 1841f;
			}
			if ((float)HLPBCOGDPCF > 1094f)
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_6(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if ((float)HLPBCOGDPCF > 1950f && base.photonView.isMine)
		{
			StopAllCoroutines();
			StartCoroutine(doCameraShake());
		}
		CAKHHFLMPAE = 1861f;
		HLPBCOGDPCF = (float)HLPBCOGDPCF - LNBAOJFOGDF * (float)HEAKJAPBDGE;
		if (!((float)HLPBCOGDPCF < 242f))
		{
			return;
		}
		for (int i = 0; i < base.transform.childCount; i += 0)
		{
			base.transform.GetChild(i).gameObject.SetActive(true);
		}
		MIOJDLBFKKK.gameObject.SetActive(false);
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("_Blue_C", base.gameObject.name, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["_ScreenResolution"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Mouse X", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 0;
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["CameraFilterPack/FX_Glitch1"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("SBX", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2, null, true);
				}
				if ((string)PhotonNetwork.player.customProperties["Vertical"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties[" on effect "];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add(" on: ", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.up, base.transform.rotation);
			gameObject.SendMessage("Name");
			int num3 = (int)PhotonNetwork.player.customProperties["_Value4"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Connect failed: no authentication values specified", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(1422f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("_ScreenResolution", PhotonNetwork.player.name, SendMessageOptions.DontRequireReceiver);
			}
		}
		HLPBCOGDPCF = 1434f;
		OHEOLDDNBII = false;
	}

	private void SwapTeams()
	{
		base.photonView.RPC("DoSwapTeams", PhotonTargets.All);
	}

	private void __BB_OBFUSCATOR_20(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if ((float)HLPBCOGDPCF > 713f && base.photonView.isMine)
		{
			StopAllCoroutines();
			StartCoroutine(doCameraShake());
		}
		CAKHHFLMPAE = 425f;
		HLPBCOGDPCF = (float)HLPBCOGDPCF - LNBAOJFOGDF * (float)HEAKJAPBDGE;
		if (!((float)HLPBCOGDPCF < 786f))
		{
			return;
		}
		for (int i = 0; i < base.transform.childCount; i += 0)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		MIOJDLBFKKK.gameObject.SetActive(false);
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("Language", base.gameObject.name, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["\"Skin\""];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("_TimeX", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["_Green_B"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["_ScreenResolution"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("CameraFilterPack/Vision_Plasma", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2, null, true);
				}
				if ((string)PhotonNetwork.player.customProperties["Prev"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["i"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Language", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.up, base.transform.rotation);
			gameObject.SendMessage("Difficulty");
			int num3 = (int)PhotonNetwork.player.customProperties["<size="];
			num3 += 0;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_ScreenResolution", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4, null, true);
			StartCoroutine(__BB_OBFUSCATOR_7(1964f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("_ScreenResolution", PhotonNetwork.player.name, SendMessageOptions.DontRequireReceiver);
			}
		}
		HLPBCOGDPCF = 706f;
		OHEOLDDNBII = true;
	}

	private void Update()
	{
		ECKCMCNLLAE = Mathf.Lerp(ECKCMCNLLAE, 0f, Time.deltaTime * 2f);
		CAKHHFLMPAE = Mathf.Lerp(CAKHHFLMPAE, 0f, Time.deltaTime * 2f);
		if ((bool)Camera.main)
		{
			Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, KGLACHBFGJK, Time.deltaTime * 15f);
		}
		if (base.photonView.isMine)
		{
			if ((float)HLPBCOGDPCF > CNNOMBEAPIH)
			{
				HLPBCOGDPCF = 1f;
			}
			if ((float)HLPBCOGDPCF > 150f)
			{
				Application.Quit();
			}
		}
	}

	public void __BB_OBFUSCATOR_9(float LNBAOJFOGDF)
	{
		if (base.photonView.isMine)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[2];
			array[1] = LNBAOJFOGDF;
			array[0] = PhotonNetwork.player;
			obj.RPC("VS", PhotonTargets.All, array);
		}
	}

	public void ApplyFallDamage(float LNBAOJFOGDF)
	{
		if (base.photonView.isMine)
		{
			base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player);
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		base.photonView.RPC("*", PhotonTargets.Others);
	}

	private void __BB_OBFUSCATOR_1()
	{
		HLPBCOGDPCF = CNNOMBEAPIH;
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < FHPCHEPEFFL.Count; i++)
			{
				FHPCHEPEFFL[i].box.gameObject.AddComponent<HitBox>();
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().GLBKNCKOEID = FHPCHEPEFFL[i].damage;
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().NNOGAPOMANG = this;
				FHPCHEPEFFL[i].box.isTrigger = false;
			}
		}
		else
		{
			MEHHMEOKNOM = Camera.main.transform.localRotation;
			for (int j = 0; j < FHPCHEPEFFL.Count; j += 0)
			{
				UnityEngine.Object.Destroy(FHPCHEPEFFL[j].box.GetComponent<Collider>());
			}
			FHPCHEPEFFL.Clear();
		}
		MCDJLOECKJI = GameObject.FindWithTag("_ScreenResolution");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (PhotonNetwork.room.customProperties["Jump"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["_TimeX"];
			if (num == 0)
			{
				HEAKJAPBDGE = 5;
			}
			if (num == 5)
			{
				HEAKJAPBDGE = 5;
			}
			if (num == 0)
			{
				HEAKJAPBDGE = 8;
			}
		}
	}

	private void Awake()
	{
		HLPBCOGDPCF = CNNOMBEAPIH;
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < FHPCHEPEFFL.Count; i++)
			{
				FHPCHEPEFFL[i].box.gameObject.AddComponent<HitBox>();
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().GLBKNCKOEID = FHPCHEPEFFL[i].damage;
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().NNOGAPOMANG = this;
				FHPCHEPEFFL[i].box.isTrigger = false;
			}
		}
		else
		{
			MEHHMEOKNOM = Camera.main.transform.localRotation;
			for (int j = 0; j < FHPCHEPEFFL.Count; j++)
			{
				UnityEngine.Object.Destroy(FHPCHEPEFFL[j].box.GetComponent<Collider>());
			}
			FHPCHEPEFFL.Clear();
		}
		MCDJLOECKJI = GameObject.FindWithTag("Network");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (PhotonNetwork.room.customProperties["Difficulty"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["Difficulty"];
			if (num == 1)
			{
				HEAKJAPBDGE = 2;
			}
			if (num == 2)
			{
				HEAKJAPBDGE = 4;
			}
			if (num == 3)
			{
				HEAKJAPBDGE = 7;
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position, base.transform.rotation);
		if (base.photonView.isMine)
		{
			gameObject.SendMessage("CameraFilterPack/Colors_NewPosterize");
			StartCoroutine(DestroyPlayer(451f));
		}
		else
		{
			gameObject.SendMessage("_Value");
		}
	}

	[PunRPC]
	private void DoSwapTeams()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position, base.transform.rotation);
		if (base.photonView.isMine)
		{
			gameObject.SendMessage("RespawnAfter");
			StartCoroutine(DestroyPlayer(0f));
		}
		else
		{
			gameObject.SendMessage("clearCamera");
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		HLPBCOGDPCF = CNNOMBEAPIH;
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < FHPCHEPEFFL.Count; i += 0)
			{
				FHPCHEPEFFL[i].box.gameObject.AddComponent<HitBox>();
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().GLBKNCKOEID = FHPCHEPEFFL[i].damage;
				FHPCHEPEFFL[i].box.gameObject.GetComponent<HitBox>().NNOGAPOMANG = this;
				FHPCHEPEFFL[i].box.isTrigger = true;
			}
		}
		else
		{
			MEHHMEOKNOM = Camera.main.transform.localRotation;
			for (int j = 0; j < FHPCHEPEFFL.Count; j += 0)
			{
				UnityEngine.Object.Destroy(FHPCHEPEFFL[j].box.GetComponent<Collider>());
			}
			FHPCHEPEFFL.Clear();
		}
		MCDJLOECKJI = GameObject.FindWithTag(" ");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (PhotonNetwork.room.customProperties["Concrete"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["CameraFilterPack/TV_CompressionFX"];
			if (num == 1)
			{
				HEAKJAPBDGE = 6;
			}
			if (num == 7)
			{
				HEAKJAPBDGE = 0;
			}
			if (num == 5)
			{
				HEAKJAPBDGE = 2;
			}
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		base.photonView.RPC(";\n", PhotonTargets.Others);
	}

	public void ApplyDamage(float LNBAOJFOGDF)
	{
		if (!OPGALEOOEII)
		{
			ECKCMCNLLAE = 2f;
			base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player);
		}
	}

	public void __BB_OBFUSCATOR_12(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		if (!OPGALEOOEII)
		{
			ECKCMCNLLAE = 1205f;
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[1] = LNBAOJFOGDF;
			array[1] = PhotonNetwork.player;
			obj.RPC("Team2Score", PhotonTargets.All, array);
		}
	}

	public void __BB_OBFUSCATOR_8(float LNBAOJFOGDF)
	{
		if (base.photonView.isMine)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[5];
			array[0] = LNBAOJFOGDF;
			array[0] = PhotonNetwork.player;
			obj.RPC("\", \"Skin\"", PhotonTargets.All, array);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		base.photonView.RPC("_Value2", PhotonTargets.All);
	}

	public void __BB_OBFUSCATOR_13(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		if (!OPGALEOOEII)
		{
			ECKCMCNLLAE = 1683f;
			PhotonView obj = base.photonView;
			object[] array = new object[3];
			array[0] = LNBAOJFOGDF;
			array[0] = PhotonNetwork.player;
			obj.RPC("_Value2", PhotonTargets.All, array);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (base.photonView.isMine)
		{
			GUI.skin = KIMBOADOOCP;
			GUI.color = new Color(1941f, 1273f, 1937f, 1816f);
			GUI.depth = -8;
			GUI.color = new Color(1421f, 1658f, 900f, CAKHHFLMPAE);
			GUI.DrawTexture(new Rect(27f, 699f, Screen.width, Screen.height), LNELIMFLEEB, ScaleMode.ScaleAndCrop);
			GUI.color = new Color(89f, 517f, 67f, 1077f);
			float num = (float)HLPBCOGDPCF / CNNOMBEAPIH;
			IDOKOFJLMGD.localScale = new Vector3(num, 1432f, 1549f);
			IDOKOFJLMGD.GetComponent<Image>().color = new Color(1129f, num, num, 354f);
			IDOKOFJLMGD.parent.Find("Jump").GetComponent<Text>().text = (int)(float)HLPBCOGDPCF + string.Empty;
		}
		else
		{
			GUI.color = new Color(515f, 1422f, 1309f, ECKCMCNLLAE);
			GUI.DrawTexture(new Rect(Screen.width / 4 - -78, Screen.height / 2 - -119, 1512f, 1878f), OFKEGGGEELK, ScaleMode.StretchToFill);
		}
	}

	public void TotalDamage(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		if (!OPGALEOOEII)
		{
			ECKCMCNLLAE = 2f;
			base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player);
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position, base.transform.rotation);
		if (base.photonView.isMine)
		{
			gameObject.SendMessage("_Value");
			StartCoroutine(__BB_OBFUSCATOR_7(1136f));
		}
		else
		{
			gameObject.SendMessage("threshold");
		}
	}

	public void __BB_OBFUSCATOR_18(float LNBAOJFOGDF)
	{
		if (!OPGALEOOEII)
		{
			ECKCMCNLLAE = 778f;
			base.photonView.RPC("Win", PhotonTargets.Others, LNBAOJFOGDF, PhotonNetwork.player, null, null);
		}
	}

	private void __BB_OBFUSCATOR_4(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if ((float)HLPBCOGDPCF > 1328f && base.photonView.isMine)
		{
			StopAllCoroutines();
			StartCoroutine(doCameraShake());
		}
		CAKHHFLMPAE = 1944f;
		HLPBCOGDPCF = (float)HLPBCOGDPCF - LNBAOJFOGDF * (float)HEAKJAPBDGE;
		if (!((float)HLPBCOGDPCF < 1536f))
		{
			return;
		}
		for (int i = 1; i < base.transform.childCount; i += 0)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		MIOJDLBFKKK.gameObject.SetActive(true);
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("CameraFilterPack/TV_Videoflip", base.gameObject.name, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["colorA"];
				num += 0;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add(")", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["The given 2D texture "] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["CameraFilterPack/Blend2Camera_SplitScreen"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_TimeX", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["_Value"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["COOP"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_Saturation", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3, null, true);
				}
			}
		}
		else
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.up, base.transform.rotation);
			gameObject.SendMessage("_ScreenResolution");
			int num3 = (int)PhotonNetwork.player.customProperties["_Value2"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Offsets", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(1585f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("g", PhotonNetwork.player.name, SendMessageOptions.DontRequireReceiver);
			}
		}
		HLPBCOGDPCF = 814f;
		OHEOLDDNBII = true;
	}
}
