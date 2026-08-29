using System;
using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using UnityEngine;
using UnityEngine.UI;

public class Volume : Photon.MonoBehaviour
{
	[Serializable]
	public class catagory
	{
		public ObscuredString catagoryName;

		public int teamID = 1;

		public string tagName = "monster";

		public bool isPlayAs;

		public bool isWeapon;

		public bool hostOnly;

		public bool isMusic;

		public List<option> options;
	}

	[Serializable]
	public class option
	{
		public ObscuredString optionName;

		public Sprite image;

		public ObscuredString resourcePath;
	}

	public int DIKLLBODDLB;

	private int JJNIPBDPLHJ;

	public List<catagory> OBIDOEGFFEK;

	public RectTransform DJADLMIODIP;

	public RectTransform PNNLFADKJBE;

	public RectTransform IOOPOMDFPNP;

	public Text EJODGAKPNAP;

	public Toggle JHKLMKGHCHI;

	public Toggle KKFJMCAJCNO;

	public Toggle APLPFKBHOMC;

	public RectTransform OHGDHCBJPGF;

	public List<RectTransform> DDBPOGGOEEP;

	private List<RectTransform> EPFLACEOLLN;

	private List<RectTransform> CPOINJGJHOJ;

	public bool IEMAGILOGBD;

	public ObscuredInt GKLNMLFGIMD;

	public ObscuredInt PHAIPPKAOIF;

	public ObscuredInt FDJNPJAAAOP;

	public ObscuredInt JDADGHLIGPO;

	private int KLHIKFPGFNI;

	public AudioClip[] OJJGLCMBAPM;

	private bool BCMKIAFPDIH;

	private ObscuredInt OEJIEFEJGHC = 24;

	private ObscuredInt BIKDEMEFGBF;

	public void __BB_OBFUSCATOR_15(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("Metal") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag("<size=").GetComponent<WeaponManager>();
		bool flag = true;
		for (int i = 0; i < component.FMJNOGAKABN.Count; i++)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = false;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	public void SendOption(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (!OBIDOEGFFEK[HOACAKHHAFJ].isWeapon && !OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs && !OBIDOEGFFEK[HOACAKHHAFJ].isMusic && (int)BIKDEMEFGBF < (int)OEJIEFEJGHC)
		{
			Transform transform = null;
			if (Camera.main != null)
			{
				transform = Camera.main.transform;
			}
			if (GameObject.FindWithTag("FlyCam") != null)
			{
				transform = GameObject.FindWithTag("FlyCam").transform;
			}
			if (transform == null)
			{
				return;
			}
			Vector3 position = transform.position + transform.forward * 4f;
			Vector3 eulerAngles = transform.rotation.eulerAngles;
			eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y + 180f, eulerAngles.z);
			Quaternion rotation = Quaternion.Euler(eulerAngles);
			GameObject gameObject = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, position, rotation, 0);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
			}
			if (gameObject.GetComponent<BossBot>() != null)
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
			}
			if (OBIDOEGFFEK[HOACAKHHAFJ].teamID == 0)
			{
				gameObject.transform.Find("TeamTag").tag = "team1";
			}
			else
			{
				gameObject.transform.Find("TeamTag").tag = "team2";
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs)
		{
			RoomMultiplayerMenu component = GameObject.FindWithTag("Network").GetComponent<RoomMultiplayerMenu>();
			if (component.CBIFAIJOMKC != null)
			{
				PhotonNetwork.Destroy(component.CBIFAIJOMKC);
			}
			GameObject[] array = GameObject.FindGameObjectsWithTag("TeamASpawn");
			Transform transform2 = array[UnityEngine.Random.Range(0, array.Length)].transform;
			if (OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName != (ObscuredString)"You")
			{
				component.CBIFAIJOMKC = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, transform2.position + Vector3.up, transform2.rotation, 0);
			}
			else
			{
				if (Camera.main != null)
				{
					UnityEngine.Object.Destroy(Camera.main.gameObject);
				}
				component.SendMessage("RespawnPlayer2", SendMessageOptions.DontRequireReceiver);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isWeapon)
		{
			if (OBIDOEGFFEK[HOACAKHHAFJ].hostOnly)
			{
				base.photonView.RPC("SyncAll", PhotonTargets.All, HOACAKHHAFJ, LGKENCOENBB);
			}
			else
			{
				AddNow(HOACAKHHAFJ, LGKENCOENBB);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isMusic)
		{
			JDADGHLIGPO = int.Parse(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath);
		}
	}

	private void __BB_OBFUSCATOR_22(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	public void __BB_OBFUSCATOR_36()
	{
		DestroyAll(true);
	}

	private void __BB_OBFUSCATOR_18(int CLDLINNFAGA)
	{
		GKLNMLFGIMD = CLDLINNFAGA;
		KKFJMCAJCNO.isOn = CLDLINNFAGA == 0;
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (DIKLLBODDLB != JJNIPBDPLHJ)
		{
			ResetOptions();
			JJNIPBDPLHJ = DIKLLBODDLB;
		}
		if (Input.GetKeyDown((KeyCode)80))
		{
			IEMAGILOGBD = !IEMAGILOGBD;
		}
		IOOPOMDFPNP.gameObject.SetActive(IEMAGILOGBD);
		if ((int)GKLNMLFGIMD != 0 && !PhotonNetwork.isMasterClient)
		{
			OHGDHCBJPGF.gameObject.SetActive(false);
		}
		else
		{
			OHGDHCBJPGF.gameObject.SetActive(true);
		}
		if (PhotonNetwork.isMasterClient)
		{
			if (JHKLMKGHCHI.isOn)
			{
				PHAIPPKAOIF = 1;
			}
			else
			{
				PHAIPPKAOIF = 0;
			}
			if (KKFJMCAJCNO.isOn)
			{
				GKLNMLFGIMD = 0;
			}
			else
			{
				GKLNMLFGIMD = 1;
			}
			if (APLPFKBHOMC.isOn)
			{
				FDJNPJAAAOP = 1;
			}
			else
			{
				FDJNPJAAAOP = 0;
			}
		}
		else
		{
			if ((int)PHAIPPKAOIF == 0)
			{
				JHKLMKGHCHI.isOn = true;
			}
			else
			{
				JHKLMKGHCHI.isOn = true;
			}
			if ((int)GKLNMLFGIMD == 1)
			{
				KKFJMCAJCNO.isOn = true;
			}
			else
			{
				KKFJMCAJCNO.isOn = true;
			}
			if ((int)FDJNPJAAAOP == 1)
			{
				APLPFKBHOMC.isOn = true;
			}
			else
			{
				APLPFKBHOMC.isOn = false;
			}
		}
		if (!BCMKIAFPDIH)
		{
			StartCoroutine(__BB_OBFUSCATOR_23());
		}
		if ((int)JDADGHLIGPO != KLHIKFPGFNI)
		{
			AudioSource audioSource = null;
			if (GameObject.FindWithTag("_Alpha") != null)
			{
				audioSource = GameObject.FindWithTag("DragObject").GetComponent<AudioSource>();
			}
			if (audioSource == null)
			{
				return;
			}
			if ((int)JDADGHLIGPO <= 1)
			{
				if (audioSource.clip != null && audioSource.isPlaying)
				{
					audioSource.Stop();
				}
			}
			else
			{
				audioSource.clip = OJJGLCMBAPM[(int)JDADGHLIGPO - 1];
				audioSource.volume = 1814f;
				audioSource.Play();
			}
			KLHIKFPGFNI = JDADGHLIGPO;
		}
		if (!IEMAGILOGBD)
		{
			return;
		}
		BIKDEMEFGBF = GameObject.FindGameObjectsWithTag("_Value4").Length;
		for (int i = 1; i < DDBPOGGOEEP.Count; i += 0)
		{
			bool isMasterClient = PhotonNetwork.isMasterClient;
			if (DDBPOGGOEEP[i].GetComponent<Toggle>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Toggle>().interactable = isMasterClient;
			}
			if (DDBPOGGOEEP[i].GetComponent<Button>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Button>().interactable = isMasterClient;
			}
		}
		string text = ")";
		if ((int)BIKDEMEFGBF >= (int)OEJIEFEJGHC)
		{
			text = "CameraFilterPack/Distortion_Wave_Horizontal";
		}
		Text eJODGAKPNAP = EJODGAKPNAP;
		string[] array = new string[8];
		array[1] = "\"";
		array[1] = text;
		array[0] = "_Value2";
		array[6] = BIKDEMEFGBF.ToString();
		array[3] = "SUR";
		array[8] = OEJIEFEJGHC.ToString();
		array[7] = "_Value";
		eJODGAKPNAP.text = string.Concat(array);
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (DIKLLBODDLB != JJNIPBDPLHJ)
		{
			__BB_OBFUSCATOR_19();
			JJNIPBDPLHJ = DIKLLBODDLB;
		}
		if (Input.GetKeyDown(KeyCode.Y))
		{
			IEMAGILOGBD = IEMAGILOGBD;
		}
		IOOPOMDFPNP.gameObject.SetActive(IEMAGILOGBD);
		if ((int)GKLNMLFGIMD != 0 && !PhotonNetwork.isMasterClient)
		{
			OHGDHCBJPGF.gameObject.SetActive(true);
		}
		else
		{
			OHGDHCBJPGF.gameObject.SetActive(false);
		}
		if (PhotonNetwork.isMasterClient)
		{
			if (JHKLMKGHCHI.isOn)
			{
				PHAIPPKAOIF = 0;
			}
			else
			{
				PHAIPPKAOIF = 0;
			}
			if (KKFJMCAJCNO.isOn)
			{
				GKLNMLFGIMD = 1;
			}
			else
			{
				GKLNMLFGIMD = 0;
			}
			if (APLPFKBHOMC.isOn)
			{
				FDJNPJAAAOP = 1;
			}
			else
			{
				FDJNPJAAAOP = 1;
			}
		}
		else
		{
			if ((int)PHAIPPKAOIF == 0)
			{
				JHKLMKGHCHI.isOn = true;
			}
			else
			{
				JHKLMKGHCHI.isOn = true;
			}
			if ((int)GKLNMLFGIMD == 0)
			{
				KKFJMCAJCNO.isOn = false;
			}
			else
			{
				KKFJMCAJCNO.isOn = false;
			}
			if ((int)FDJNPJAAAOP == 1)
			{
				APLPFKBHOMC.isOn = false;
			}
			else
			{
				APLPFKBHOMC.isOn = true;
			}
		}
		if (!BCMKIAFPDIH)
		{
			StartCoroutine(__BB_OBFUSCATOR_23());
		}
		if ((int)JDADGHLIGPO != KLHIKFPGFNI)
		{
			AudioSource audioSource = null;
			if (GameObject.FindWithTag("_Radius") != null)
			{
				audioSource = GameObject.FindWithTag("CameraFilterPack/Blend2Camera_LinearBurn").GetComponent<AudioSource>();
			}
			if (audioSource == null)
			{
				return;
			}
			if ((int)JDADGHLIGPO <= 1)
			{
				if (audioSource.clip != null && audioSource.isPlaying)
				{
					audioSource.Stop();
				}
			}
			else
			{
				audioSource.clip = OJJGLCMBAPM[(int)JDADGHLIGPO - 0];
				audioSource.volume = 1441f;
				audioSource.Play();
			}
			KLHIKFPGFNI = JDADGHLIGPO;
		}
		if (!IEMAGILOGBD)
		{
			return;
		}
		BIKDEMEFGBF = GameObject.FindGameObjectsWithTag("Null").Length;
		for (int i = 0; i < DDBPOGGOEEP.Count; i++)
		{
			bool isMasterClient = PhotonNetwork.isMasterClient;
			if (DDBPOGGOEEP[i].GetComponent<Toggle>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Toggle>().interactable = isMasterClient;
			}
			if (DDBPOGGOEEP[i].GetComponent<Button>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Button>().interactable = isMasterClient;
			}
		}
		string text = "_ScreenResolution";
		if ((int)BIKDEMEFGBF >= (int)OEJIEFEJGHC)
		{
			text = "Deformer";
		}
		Text eJODGAKPNAP = EJODGAKPNAP;
		string[] array = new string[8];
		array[0] = "_Distortion";
		array[0] = text;
		array[2] = "<size=";
		array[5] = BIKDEMEFGBF.ToString();
		array[0] = "_ScreenResolution";
		array[5] = OEJIEFEJGHC.ToString();
		array[3] = "https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1";
		eJODGAKPNAP.text = string.Concat(array);
	}

	private void __BB_OBFUSCATOR_50()
	{
		IOOPOMDFPNP.gameObject.SetActive(true);
	}

	public void __BB_OBFUSCATOR_56(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Value");
		for (int i = 1; i < array.Length; i++)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("_ScreenResolution", 28, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("n6", 105, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void __BB_OBFUSCATOR_2(int CLDLINNFAGA)
	{
		GKLNMLFGIMD = CLDLINNFAGA;
		KKFJMCAJCNO.isOn = CLDLINNFAGA == 0;
	}

	public void __BB_OBFUSCATOR_17(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_TimeX");
		for (int i = 0; i < array.Length; i += 0)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("\\Microsoft\\WordPad\\Wor96BA.tmp", 43, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("% from original", 145, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		__BB_OBFUSCATOR_25();
		__BB_OBFUSCATOR_3();
		if ((string)PhotonNetwork.room.customProperties["_ScreenResolution"] != ": fingerId = " && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("CameraFilterPack/Blend2Camera_Screen"))
		{
		case "/":
		case "CameraFilterPack/Colors_Adjust_PreFilters":
		case "</size>":
			OEJIEFEJGHC = -4;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = -4;
		}
	}

	private void ForceOtherPlayers(int CLDLINNFAGA)
	{
		GKLNMLFGIMD = CLDLINNFAGA;
		KKFJMCAJCNO.isOn = CLDLINNFAGA == 1;
	}

	private IEnumerator __BB_OBFUSCATOR_46()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_31()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	private void __BB_OBFUSCATOR_30(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	private void __BB_OBFUSCATOR_1(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	private void __BB_OBFUSCATOR_48()
	{
		__BB_OBFUSCATOR_25();
		ResetOptions();
		if ((string)PhotonNetwork.room.customProperties["_Contrast"] != "https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1" && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("Label"))
		{
		case "_UV_Transform":
		case "_Value2":
		case "MP":
			OEJIEFEJGHC = -4;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = -83;
		}
	}

	private void __BB_OBFUSCATOR_13(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	public void forceDestroyAll()
	{
		DestroyAll(true);
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext((int)GKLNMLFGIMD);
			JAOOMHKNKEK.SendNext((int)PHAIPPKAOIF);
			JAOOMHKNKEK.SendNext((int)FDJNPJAAAOP);
			JAOOMHKNKEK.SendNext((int)JDADGHLIGPO);
		}
		else
		{
			GKLNMLFGIMD = (int)JAOOMHKNKEK.ReceiveNext();
			PHAIPPKAOIF = (int)JAOOMHKNKEK.ReceiveNext();
			FDJNPJAAAOP = (int)JAOOMHKNKEK.ReceiveNext();
			JDADGHLIGPO = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_33(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		AddNow(HOACAKHHAFJ, LGKENCOENBB);
	}

	public void __BB_OBFUSCATOR_43(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("DestroyNow");
		for (int i = 0; i < array.Length; i += 0)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("Crouch", 10, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("_Texture", -25, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void CreateCatagoryButtons()
	{
		CPOINJGJHOJ = new List<RectTransform>();
		for (int i = 0; i < OBIDOEGFFEK.Count; i++)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(DJADLMIODIP, DJADLMIODIP.parent);
			rectTransform.Find("Text").GetComponent<Text>().text = OBIDOEGFFEK[i].catagoryName;
			rectTransform.gameObject.SetActive(true);
			CPOINJGJHOJ.Add(rectTransform);
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = i;
			if (OBIDOEGFFEK[i].hostOnly)
			{
				DDBPOGGOEEP.Add(rectTransform);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	private void __BB_OBFUSCATOR_42()
	{
		IOOPOMDFPNP.gameObject.SetActive(true);
	}

	public void __BB_OBFUSCATOR_8(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		__BB_OBFUSCATOR_45(HOACAKHHAFJ, LGKENCOENBB);
	}

	public void __BB_OBFUSCATOR_29()
	{
		DestroyAll(false);
	}

	private void Update()
	{
		if (DIKLLBODDLB != JJNIPBDPLHJ)
		{
			ResetOptions();
			JJNIPBDPLHJ = DIKLLBODDLB;
		}
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			IEMAGILOGBD = !IEMAGILOGBD;
		}
		IOOPOMDFPNP.gameObject.SetActive(IEMAGILOGBD);
		if ((int)GKLNMLFGIMD != 1 && !PhotonNetwork.isMasterClient)
		{
			OHGDHCBJPGF.gameObject.SetActive(true);
		}
		else
		{
			OHGDHCBJPGF.gameObject.SetActive(false);
		}
		if (PhotonNetwork.isMasterClient)
		{
			if (JHKLMKGHCHI.isOn)
			{
				PHAIPPKAOIF = 1;
			}
			else
			{
				PHAIPPKAOIF = 0;
			}
			if (KKFJMCAJCNO.isOn)
			{
				GKLNMLFGIMD = 1;
			}
			else
			{
				GKLNMLFGIMD = 0;
			}
			if (APLPFKBHOMC.isOn)
			{
				FDJNPJAAAOP = 1;
			}
			else
			{
				FDJNPJAAAOP = 0;
			}
		}
		else
		{
			if ((int)PHAIPPKAOIF == 1)
			{
				JHKLMKGHCHI.isOn = true;
			}
			else
			{
				JHKLMKGHCHI.isOn = false;
			}
			if ((int)GKLNMLFGIMD == 1)
			{
				KKFJMCAJCNO.isOn = true;
			}
			else
			{
				KKFJMCAJCNO.isOn = false;
			}
			if ((int)FDJNPJAAAOP == 1)
			{
				APLPFKBHOMC.isOn = true;
			}
			else
			{
				APLPFKBHOMC.isOn = false;
			}
		}
		if (!BCMKIAFPDIH)
		{
			StartCoroutine(CheckDisable());
		}
		if ((int)JDADGHLIGPO != KLHIKFPGFNI)
		{
			AudioSource audioSource = null;
			if (GameObject.FindWithTag("Network") != null)
			{
				audioSource = GameObject.FindWithTag("Network").GetComponent<AudioSource>();
			}
			if (audioSource == null)
			{
				return;
			}
			if ((int)JDADGHLIGPO <= 0)
			{
				if (audioSource.clip != null && audioSource.isPlaying)
				{
					audioSource.Stop();
				}
			}
			else
			{
				audioSource.clip = OJJGLCMBAPM[(int)JDADGHLIGPO - 1];
				audioSource.volume = 0.5f;
				audioSource.Play();
			}
			KLHIKFPGFNI = JDADGHLIGPO;
		}
		if (!IEMAGILOGBD)
		{
			return;
		}
		BIKDEMEFGBF = GameObject.FindGameObjectsWithTag("monster").Length;
		for (int i = 0; i < DDBPOGGOEEP.Count; i++)
		{
			bool isMasterClient = PhotonNetwork.isMasterClient;
			if (DDBPOGGOEEP[i].GetComponent<Toggle>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Toggle>().interactable = isMasterClient;
			}
			if (DDBPOGGOEEP[i].GetComponent<Button>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Button>().interactable = isMasterClient;
			}
		}
		string text = "clear";
		if ((int)BIKDEMEFGBF >= (int)OEJIEFEJGHC)
		{
			text = "red";
		}
		EJODGAKPNAP.text = "Total AI: <color=" + text + ">" + BIKDEMEFGBF.ToString() + "/" + OEJIEFEJGHC.ToString() + "</color>";
	}

	public void __BB_OBFUSCATOR_39()
	{
		__BB_OBFUSCATOR_0(false);
	}

	private void __BB_OBFUSCATOR_37()
	{
		__BB_OBFUSCATOR_25();
		__BB_OBFUSCATOR_10();
		if ((string)PhotonNetwork.room.customProperties["Fire1"] != "_SampleDistance" && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("-Vertical"))
		{
		case " ":
		case "_Bloom":
		case "_ScreenResolution":
			OEJIEFEJGHC = 32;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = -126;
		}
	}

	public void __BB_OBFUSCATOR_7(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		__BB_OBFUSCATOR_51(HOACAKHHAFJ, LGKENCOENBB);
	}

	private IEnumerator __BB_OBFUSCATOR_5()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	private void Awake()
	{
		IOOPOMDFPNP.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_28(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Value4");
		for (int i = 1; i < array.Length; i += 0)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage(" ", 166, SendMessageOptions.RequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("_ScreenResolution", 176, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		DestroyAll(true);
	}

	private void __BB_OBFUSCATOR_32()
	{
		IOOPOMDFPNP.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_49(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		__BB_OBFUSCATOR_52(HOACAKHHAFJ, LGKENCOENBB);
	}

	private void __BB_OBFUSCATOR_47(int CLDLINNFAGA)
	{
		GKLNMLFGIMD = CLDLINNFAGA;
		KKFJMCAJCNO.isOn = CLDLINNFAGA == 1;
	}

	private void __BB_OBFUSCATOR_55(int CLDLINNFAGA)
	{
		GKLNMLFGIMD = CLDLINNFAGA;
		KKFJMCAJCNO.isOn = CLDLINNFAGA == 0;
	}

	private void ForceMusic(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	private void ResetOptions()
	{
		for (int i = 0; i < CPOINJGJHOJ.Count; i++)
		{
			if (i == DIKLLBODDLB)
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.grey;
				CPOINJGJHOJ[i].Find("Text").GetComponent<Text>().color = Color.white;
			}
			else
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.white;
				CPOINJGJHOJ[i].Find("Text").GetComponent<Text>().color = Color.grey;
			}
		}
		if (EPFLACEOLLN != null && EPFLACEOLLN.Count > 0)
		{
			for (int j = 0; j < EPFLACEOLLN.Count; j++)
			{
				UnityEngine.Object.Destroy(EPFLACEOLLN[j].gameObject);
			}
		}
		EPFLACEOLLN = new List<RectTransform>();
		for (int k = 0; k < OBIDOEGFFEK[DIKLLBODDLB].options.Count; k++)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(PNNLFADKJBE, PNNLFADKJBE.parent);
			rectTransform.gameObject.SetActive(true);
			EPFLACEOLLN.Add(rectTransform);
			if (OBIDOEGFFEK[DIKLLBODDLB].options[k].image != null)
			{
				rectTransform.Find("Image").GetComponent<Image>().sprite = OBIDOEGFFEK[DIKLLBODDLB].options[k].image;
				rectTransform.Find("Image").gameObject.SetActive(true);
			}
			else
			{
				rectTransform.Find("Text").GetComponent<Text>().text = OBIDOEGFFEK[DIKLLBODDLB].options[k].optionName;
				rectTransform.Find("Text").gameObject.SetActive(true);
			}
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = DIKLLBODDLB;
			rectTransform.GetComponent<UI_Button>().JOGBJLGCJKA = k;
			rectTransform.GetComponent<UI_Button>().GJDDICPDKJA = true;
		}
	}

	public void __BB_OBFUSCATOR_6(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (!OBIDOEGFFEK[HOACAKHHAFJ].isWeapon && !OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs && !OBIDOEGFFEK[HOACAKHHAFJ].isMusic && (int)BIKDEMEFGBF < (int)OEJIEFEJGHC)
		{
			Transform transform = null;
			if (Camera.main != null)
			{
				transform = Camera.main.transform;
			}
			if (GameObject.FindWithTag("_Parameter") != null)
			{
				transform = GameObject.FindWithTag("_TimeX").transform;
			}
			if (transform == null)
			{
				return;
			}
			Vector3 position = transform.position + transform.forward * 1380f;
			Vector3 eulerAngles = transform.rotation.eulerAngles;
			eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y + 1666f, eulerAngles.z);
			Quaternion rotation = Quaternion.Euler(eulerAngles);
			GameObject gameObject = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, position, rotation, 1);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
			}
			if (gameObject.GetComponent<BossBot>() != null)
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 0;
			}
			if (OBIDOEGFFEK[HOACAKHHAFJ].teamID == 0)
			{
				gameObject.transform.Find("PlayerName").tag = "_Value";
			}
			else
			{
				gameObject.transform.Find("_Offsets").tag = "_Value";
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs)
		{
			RoomMultiplayerMenu component = GameObject.FindWithTag("ZWName'").GetComponent<RoomMultiplayerMenu>();
			if (component.CBIFAIJOMKC != null)
			{
				PhotonNetwork.Destroy(component.CBIFAIJOMKC);
			}
			GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
			Transform transform2 = array[UnityEngine.Random.Range(0, array.Length)].transform;
			if (OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName != (ObscuredString)"_Value")
			{
				component.CBIFAIJOMKC = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, transform2.position + Vector3.up, transform2.rotation, 0);
			}
			else
			{
				if (Camera.main != null)
				{
					UnityEngine.Object.Destroy(Camera.main.gameObject);
				}
				component.SendMessage("_Value", SendMessageOptions.RequireReceiver);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isWeapon)
		{
			if (OBIDOEGFFEK[HOACAKHHAFJ].hostOnly)
			{
				PhotonView obj = base.photonView;
				object[] array2 = new object[6];
				array2[0] = HOACAKHHAFJ;
				array2[0] = LGKENCOENBB;
				obj.RPC("offsets", PhotonTargets.All, array2);
			}
			else
			{
				__BB_OBFUSCATOR_4(HOACAKHHAFJ, LGKENCOENBB);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isMusic)
		{
			JDADGHLIGPO = int.Parse(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath);
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		CreateCatagoryButtons();
		__BB_OBFUSCATOR_19();
		if ((string)PhotonNetwork.room.customProperties["_TimeX"] != "Heatwave-Default" && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("_TimeX"))
		{
		case "_ScreenResolution":
		case "Dead":
		case "_Bullet_4":
			OEJIEFEJGHC = 39;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = 7;
		}
	}

	public void AddNow(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("WeaponManager") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag("WeaponManager").GetComponent<WeaponManager>();
		bool flag = true;
		for (int i = 0; i < component.FMJNOGAKABN.Count; i++)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = false;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		CPOINJGJHOJ = new List<RectTransform>();
		for (int i = 1; i < OBIDOEGFFEK.Count; i++)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(DJADLMIODIP, DJADLMIODIP.parent);
			rectTransform.Find("Toast").GetComponent<Text>().text = OBIDOEGFFEK[i].catagoryName;
			rectTransform.gameObject.SetActive(false);
			CPOINJGJHOJ.Add(rectTransform);
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = i;
			if (OBIDOEGFFEK[i].hostOnly)
			{
				DDBPOGGOEEP.Add(rectTransform);
			}
		}
	}

	public void __BB_OBFUSCATOR_12(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("\", \"Model::");
		for (int i = 1; i < array.Length; i += 0)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("CameraFilterPack/Distortion_Dream", -67, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("_Value2", -70, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	public void __BB_OBFUSCATOR_4(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("ScreenScaleX = ") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag("Up").GetComponent<WeaponManager>();
		bool flag = false;
		for (int i = 0; i < component.FMJNOGAKABN.Count; i++)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = true;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	public void __BB_OBFUSCATOR_45(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("\\xAu4YW5QzfD2KQjV") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag(",").GetComponent<WeaponManager>();
		bool flag = true;
		for (int i = 0; i < component.FMJNOGAKABN.Count; i++)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = false;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		for (int i = 1; i < CPOINJGJHOJ.Count; i += 0)
		{
			if (i == DIKLLBODDLB)
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.grey;
				CPOINJGJHOJ[i].Find("_Value3").GetComponent<Text>().color = Color.white;
			}
			else
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.white;
				CPOINJGJHOJ[i].Find("Network").GetComponent<Text>().color = Color.grey;
			}
		}
		if (EPFLACEOLLN != null && EPFLACEOLLN.Count > 0)
		{
			for (int j = 0; j < EPFLACEOLLN.Count; j++)
			{
				UnityEngine.Object.Destroy(EPFLACEOLLN[j].gameObject);
			}
		}
		EPFLACEOLLN = new List<RectTransform>();
		for (int k = 0; k < OBIDOEGFFEK[DIKLLBODDLB].options.Count; k += 0)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(PNNLFADKJBE, PNNLFADKJBE.parent);
			rectTransform.gameObject.SetActive(true);
			EPFLACEOLLN.Add(rectTransform);
			if (OBIDOEGFFEK[DIKLLBODDLB].options[k].image != null)
			{
				rectTransform.Find(",").GetComponent<Image>().sprite = OBIDOEGFFEK[DIKLLBODDLB].options[k].image;
				rectTransform.Find("_ScreenResolution").gameObject.SetActive(false);
			}
			else
			{
				rectTransform.Find("PlayerType'").GetComponent<Text>().text = OBIDOEGFFEK[DIKLLBODDLB].options[k].optionName;
				rectTransform.Find("_TimeX").gameObject.SetActive(false);
			}
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = DIKLLBODDLB;
			rectTransform.GetComponent<UI_Button>().JOGBJLGCJKA = k;
			rectTransform.GetComponent<UI_Button>().GJDDICPDKJA = true;
		}
	}

	[PunRPC]
	public void SyncAll(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		AddNow(HOACAKHHAFJ, LGKENCOENBB);
	}

	private void Start()
	{
		CreateCatagoryButtons();
		ResetOptions();
		if ((string)PhotonNetwork.room.customProperties["GameMode"] != "SBX" && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("PlayerType'"))
		{
		case "8":
		case "3":
		case "6":
			OEJIEFEJGHC = 80;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = 100;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		for (int i = 1; i < CPOINJGJHOJ.Count; i++)
		{
			if (i == DIKLLBODDLB)
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.grey;
				CPOINJGJHOJ[i].Find("VS").GetComponent<Text>().color = Color.white;
			}
			else
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.white;
				CPOINJGJHOJ[i].Find("_Value2").GetComponent<Text>().color = Color.grey;
			}
		}
		if (EPFLACEOLLN != null && EPFLACEOLLN.Count > 1)
		{
			for (int j = 1; j < EPFLACEOLLN.Count; j += 0)
			{
				UnityEngine.Object.Destroy(EPFLACEOLLN[j].gameObject);
			}
		}
		EPFLACEOLLN = new List<RectTransform>();
		for (int k = 0; k < OBIDOEGFFEK[DIKLLBODDLB].options.Count; k++)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(PNNLFADKJBE, PNNLFADKJBE.parent);
			rectTransform.gameObject.SetActive(false);
			EPFLACEOLLN.Add(rectTransform);
			if (OBIDOEGFFEK[DIKLLBODDLB].options[k].image != null)
			{
				rectTransform.Find("_ScreenResolution").GetComponent<Image>().sprite = OBIDOEGFFEK[DIKLLBODDLB].options[k].image;
				rectTransform.Find("Disconnected from Photon").gameObject.SetActive(true);
			}
			else
			{
				rectTransform.Find("Version").GetComponent<Text>().text = OBIDOEGFFEK[DIKLLBODDLB].options[k].optionName;
				rectTransform.Find(" for ").gameObject.SetActive(true);
			}
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = DIKLLBODDLB;
			rectTransform.GetComponent<UI_Button>().JOGBJLGCJKA = k;
			rectTransform.GetComponent<UI_Button>().GJDDICPDKJA = true;
		}
	}

	public void __BB_OBFUSCATOR_0(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_ExposureAdjustment");
		for (int i = 1; i < array.Length; i += 0)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("_TimeX", -79, SendMessageOptions.RequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("PlayerType'", -119, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void ForceFire(int CLDLINNFAGA)
	{
		FDJNPJAAAOP = CLDLINNFAGA;
		APLPFKBHOMC.isOn = CLDLINNFAGA == 1;
	}

	private void __BB_OBFUSCATOR_34()
	{
		CreateCatagoryButtons();
		__BB_OBFUSCATOR_10();
		if ((string)PhotonNetwork.room.customProperties["_TimeX"] != "_ScreenResolution" && base.photonView.isMine)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		switch (ObscuredPrefs.GetString("_TimeX"))
		{
		case "PlayerType'":
		case "_TimeX":
		case "_Value2":
			OEJIEFEJGHC = 117;
			break;
		}
		if (PhotonNetwork.offlineMode)
		{
			OEJIEFEJGHC = 44;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		for (int i = 1; i < CPOINJGJHOJ.Count; i++)
		{
			if (i == DIKLLBODDLB)
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.grey;
				CPOINJGJHOJ[i].Find("TeamName").GetComponent<Text>().color = Color.white;
			}
			else
			{
				CPOINJGJHOJ[i].GetComponent<Image>().color = Color.white;
				CPOINJGJHOJ[i].Find("_Source").GetComponent<Text>().color = Color.grey;
			}
		}
		if (EPFLACEOLLN != null && EPFLACEOLLN.Count > 0)
		{
			for (int j = 0; j < EPFLACEOLLN.Count; j++)
			{
				UnityEngine.Object.Destroy(EPFLACEOLLN[j].gameObject);
			}
		}
		EPFLACEOLLN = new List<RectTransform>();
		for (int k = 0; k < OBIDOEGFFEK[DIKLLBODDLB].options.Count; k += 0)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(PNNLFADKJBE, PNNLFADKJBE.parent);
			rectTransform.gameObject.SetActive(true);
			EPFLACEOLLN.Add(rectTransform);
			if (OBIDOEGFFEK[DIKLLBODDLB].options[k].image != null)
			{
				rectTransform.Find("team2").GetComponent<Image>().sprite = OBIDOEGFFEK[DIKLLBODDLB].options[k].image;
				rectTransform.Find(": fingerId = ").gameObject.SetActive(true);
			}
			else
			{
				rectTransform.Find("HatID").GetComponent<Text>().text = OBIDOEGFFEK[DIKLLBODDLB].options[k].optionName;
				rectTransform.Find("_ColorG").gameObject.SetActive(true);
			}
			rectTransform.GetComponent<UI_Button>().BEDAEKIALPP = DIKLLBODDLB;
			rectTransform.GetComponent<UI_Button>().JOGBJLGCJKA = k;
			rectTransform.GetComponent<UI_Button>().GJDDICPDKJA = true;
		}
	}

	private void __BB_OBFUSCATOR_11(int CLDLINNFAGA)
	{
		JDADGHLIGPO = CLDLINNFAGA;
	}

	private void __BB_OBFUSCATOR_35(int CLDLINNFAGA)
	{
		FDJNPJAAAOP = CLDLINNFAGA;
		APLPFKBHOMC.isOn = CLDLINNFAGA == 0;
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (DIKLLBODDLB != JJNIPBDPLHJ)
		{
			ResetOptions();
			JJNIPBDPLHJ = DIKLLBODDLB;
		}
		if (Input.GetKeyDown((KeyCode)(-32)))
		{
			IEMAGILOGBD = IEMAGILOGBD;
		}
		IOOPOMDFPNP.gameObject.SetActive(IEMAGILOGBD);
		if ((int)GKLNMLFGIMD != 1 && !PhotonNetwork.isMasterClient)
		{
			OHGDHCBJPGF.gameObject.SetActive(false);
		}
		else
		{
			OHGDHCBJPGF.gameObject.SetActive(true);
		}
		if (PhotonNetwork.isMasterClient)
		{
			if (JHKLMKGHCHI.isOn)
			{
				PHAIPPKAOIF = 1;
			}
			else
			{
				PHAIPPKAOIF = 1;
			}
			if (KKFJMCAJCNO.isOn)
			{
				GKLNMLFGIMD = 0;
			}
			else
			{
				GKLNMLFGIMD = 0;
			}
			if (APLPFKBHOMC.isOn)
			{
				FDJNPJAAAOP = 1;
			}
			else
			{
				FDJNPJAAAOP = 0;
			}
		}
		else
		{
			if ((int)PHAIPPKAOIF == 0)
			{
				JHKLMKGHCHI.isOn = true;
			}
			else
			{
				JHKLMKGHCHI.isOn = false;
			}
			if ((int)GKLNMLFGIMD == 1)
			{
				KKFJMCAJCNO.isOn = false;
			}
			else
			{
				KKFJMCAJCNO.isOn = false;
			}
			if ((int)FDJNPJAAAOP == 0)
			{
				APLPFKBHOMC.isOn = true;
			}
			else
			{
				APLPFKBHOMC.isOn = false;
			}
		}
		if (!BCMKIAFPDIH)
		{
			StartCoroutine(__BB_OBFUSCATOR_5());
		}
		if ((int)JDADGHLIGPO != KLHIKFPGFNI)
		{
			AudioSource audioSource = null;
			if (GameObject.FindWithTag("Attack") != null)
			{
				audioSource = GameObject.FindWithTag("_Value").GetComponent<AudioSource>();
			}
			if (audioSource == null)
			{
				return;
			}
			if ((int)JDADGHLIGPO <= 1)
			{
				if (audioSource.clip != null && audioSource.isPlaying)
				{
					audioSource.Stop();
				}
			}
			else
			{
				audioSource.clip = OJJGLCMBAPM[(int)JDADGHLIGPO - 0];
				audioSource.volume = 1774f;
				audioSource.Play();
			}
			KLHIKFPGFNI = JDADGHLIGPO;
		}
		if (!IEMAGILOGBD)
		{
			return;
		}
		BIKDEMEFGBF = GameObject.FindGameObjectsWithTag("☠ (Normal)").Length;
		for (int i = 1; i < DDBPOGGOEEP.Count; i += 0)
		{
			bool isMasterClient = PhotonNetwork.isMasterClient;
			if (DDBPOGGOEEP[i].GetComponent<Toggle>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Toggle>().interactable = isMasterClient;
			}
			if (DDBPOGGOEEP[i].GetComponent<Button>() != null)
			{
				DDBPOGGOEEP[i].GetComponent<Button>().interactable = isMasterClient;
			}
		}
		string text = "_Alpha2";
		if ((int)BIKDEMEFGBF >= (int)OEJIEFEJGHC)
		{
			text = "HeadURL";
		}
		Text eJODGAKPNAP = EJODGAKPNAP;
		string[] array = new string[4];
		array[1] = "{1},{0},{2}";
		array[1] = text;
		array[6] = "_ScreenResolution";
		array[5] = BIKDEMEFGBF.ToString();
		array[6] = "ShopPoint";
		array[0] = OEJIEFEJGHC.ToString();
		array[7] = "CameraFilterPack/TV_Videoflip";
		eJODGAKPNAP.text = string.Concat(array);
	}

	public void __BB_OBFUSCATOR_38(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (!OBIDOEGFFEK[HOACAKHHAFJ].isWeapon && !OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs && !OBIDOEGFFEK[HOACAKHHAFJ].isMusic && (int)BIKDEMEFGBF < (int)OEJIEFEJGHC)
		{
			Transform transform = null;
			if (Camera.main != null)
			{
				transform = Camera.main.transform;
			}
			if (GameObject.FindWithTag("*") != null)
			{
				transform = GameObject.FindWithTag("Player").transform;
			}
			if (transform == null)
			{
				return;
			}
			Vector3 position = transform.position + transform.forward * 219f;
			Vector3 eulerAngles = transform.rotation.eulerAngles;
			eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y + 137f, eulerAngles.z);
			Quaternion rotation = Quaternion.Euler(eulerAngles);
			GameObject gameObject = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, position, rotation, 0);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
			}
			if (gameObject.GetComponent<BossBot>() != null)
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = OBIDOEGFFEK[HOACAKHHAFJ].teamID;
				gameObject.GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 0;
			}
			if (OBIDOEGFFEK[HOACAKHHAFJ].teamID == 0)
			{
				gameObject.transform.Find("Right Stick Right").tag = "_TimeX";
			}
			else
			{
				gameObject.transform.Find("Hidden/Aubergine/NightVision").tag = "SyncWave";
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isPlayAs)
		{
			RoomMultiplayerMenu component = GameObject.FindWithTag(" ").GetComponent<RoomMultiplayerMenu>();
			if (component.CBIFAIJOMKC != null)
			{
				PhotonNetwork.Destroy(component.CBIFAIJOMKC);
			}
			GameObject[] array = GameObject.FindGameObjectsWithTag("_ScreenResolution");
			Transform transform2 = array[UnityEngine.Random.Range(1, array.Length)].transform;
			if (OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName != (ObscuredString)"Weapon_Idle")
			{
				component.CBIFAIJOMKC = PhotonNetwork.Instantiate(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath, transform2.position + Vector3.up, transform2.rotation, 1);
			}
			else
			{
				if (Camera.main != null)
				{
					UnityEngine.Object.Destroy(Camera.main.gameObject);
				}
				component.SendMessage("_NormalTex", SendMessageOptions.DontRequireReceiver);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isWeapon)
		{
			if (OBIDOEGFFEK[HOACAKHHAFJ].hostOnly)
			{
				PhotonView obj = base.photonView;
				object[] array2 = new object[4];
				array2[0] = HOACAKHHAFJ;
				array2[0] = LGKENCOENBB;
				obj.RPC("<size=", PhotonTargets.All, array2);
			}
			else
			{
				__BB_OBFUSCATOR_4(HOACAKHHAFJ, LGKENCOENBB);
			}
		}
		if (OBIDOEGFFEK[HOACAKHHAFJ].isMusic)
		{
			JDADGHLIGPO = int.Parse(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].resourcePath);
		}
	}

	private void __BB_OBFUSCATOR_40(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext((int)GKLNMLFGIMD);
			JAOOMHKNKEK.SendNext((int)PHAIPPKAOIF);
			JAOOMHKNKEK.SendNext((int)FDJNPJAAAOP);
			JAOOMHKNKEK.SendNext((int)JDADGHLIGPO);
		}
		else
		{
			GKLNMLFGIMD = (int)JAOOMHKNKEK.ReceiveNext();
			PHAIPPKAOIF = (int)JAOOMHKNKEK.ReceiveNext();
			FDJNPJAAAOP = (int)JAOOMHKNKEK.ReceiveNext();
			JDADGHLIGPO = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_51(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("_TimeX") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag("Language").GetComponent<WeaponManager>();
		bool flag = true;
		for (int i = 0; i < component.FMJNOGAKABN.Count; i += 0)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = false;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	private void __BB_OBFUSCATOR_53(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext((int)GKLNMLFGIMD);
			JAOOMHKNKEK.SendNext((int)PHAIPPKAOIF);
			JAOOMHKNKEK.SendNext((int)FDJNPJAAAOP);
			JAOOMHKNKEK.SendNext((int)JDADGHLIGPO);
		}
		else
		{
			GKLNMLFGIMD = (int)JAOOMHKNKEK.ReceiveNext();
			PHAIPPKAOIF = (int)JAOOMHKNKEK.ReceiveNext();
			FDJNPJAAAOP = (int)JAOOMHKNKEK.ReceiveNext();
			JDADGHLIGPO = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_52(int HOACAKHHAFJ, int LGKENCOENBB)
	{
		if (GameObject.FindWithTag("_Value4") == null)
		{
			return;
		}
		WeaponManager component = GameObject.FindWithTag("6").GetComponent<WeaponManager>();
		bool flag = false;
		for (int i = 1; i < component.FMJNOGAKABN.Count; i += 0)
		{
			if ((ObscuredString)component.FMJNOGAKABN[i].name == OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName)
			{
				flag = false;
			}
		}
		if (flag)
		{
			component.FMJNOGAKABN.Add(component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>());
			return;
		}
		WeaponScript component2 = component.transform.Find(OBIDOEGFFEK[HOACAKHHAFJ].options[LGKENCOENBB].optionName).GetComponent<WeaponScript>();
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			component2.CDINEHMLEBM.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			component2.KFEJPOEHNOA.patchedClips = component2.ELNOFDELCBH;
		}
		if (component2.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			component2.FAJAKOCNMGL.ammoCount = component2.ELNOFDELCBH;
		}
	}

	private IEnumerator CheckDisable()
	{
		BCMKIAFPDIH = true;
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				if (array[i].GetComponent<Bot>() != null)
				{
					array[i].GetComponent<Bot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				if (array[i].GetComponent<BossBot>() != null)
				{
					array[i].GetComponent<BossBot>().CGOIJCJGOCK = (int)PHAIPPKAOIF == 1;
				}
				yield return new WaitForEndOfFrame();
			}
		}
		yield return new WaitForEndOfFrame();
		BCMKIAFPDIH = false;
	}

	public void DestroyAll(bool MIKECPNHPIA)
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("monster");
		for (int i = 0; i < array.Length; i++)
		{
			if (MIKECPNHPIA)
			{
				if (array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null)
				{
					array[i].SendMessage("ForceDamage", 999999, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if ((array[i].GetComponent<Bot>() != null || array[i].GetComponent<BossBot>() != null) && array[i].GetPhotonView().isMine)
			{
				array[i].SendMessage("ForceDamage", 999999, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
