using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNetworkController : Photon.MonoBehaviour
{
	[Serializable]
	public class AnimationSpeed
	{
		public float walkSpeed = 1f;

		public float runSpeed = 1f;

		public float crouchSpeed = 1f;

		public float proneSpeed = 1f;
	}

	[HideInInspector]
	public string DLHMCKDJIHG;

	public int GJJLCBEIBPC;

	public Transform PBFIJAMKCAB;

	private CharacterController ADEGJKKLALB;

	private RoomMultiplayerMenu OGKPPJHGFHD;

	private GameObject GIGFDDPGOCD;

	public Transform ACAPPBHAMDM;

	public Transform GKJJKGNHGNA;

	public Transform IPLCHGDDMLE;

	public CharacterAnimation JIJOCINMFGJ;

	public AnimationSpeed KBPBLAEOAEJ;

	private List<string> ABGCNFOKIBJ = new List<string>();

	private string HJBKMNAKLGJ;

	public string KAJHFJAPIAK;

	private string COECCGILNCN;

	public string ADJPPMOHAMP = string.Empty;

	public string NNKBAKKCDKJ = string.Empty;

	public int BHOCLIGHAPI;

	public int GAOCLKPGOPC;

	private string HOFAPCGBGON = string.Empty;

	public DrawPlayerName CMIIFKLBIIJ;

	public PlayerDamage NNOGAPOMANG;

	public HeadLookController GCBMNEBPFCC;

	public bool HJLDMGLJKGF;

	public Transform NAAGAMLOOJL;

	public List<GameObject> BKJEDLAOICL;

	public List<UnityEngine.MonoBehaviour> LOAOJLFEPAA;

	public List<GameObject> GNNPFLKCEIM;

	public List<UnityEngine.MonoBehaviour> PGEJOODOAIG;

	public float IHBMGGNMDED;

	[HideInInspector]
	public bool JPHJMFDHAGK;

	public Text KOJGDLALBBB;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private Vector3 GODGDKBCHFF = Vector3.zero;

	public float MDPMBHBBNMF;

	private string MNHJPLLIMIM = string.Empty;

	private string GHCCHNBDGEE = string.Empty;

	private int __BB_OBFUSCATOR_31(string BOAIGNKFAOM)
	{
		MecanimControl component = NAAGAMLOOJL.GetComponent<MecanimControl>();
		int result = 1;
		if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
		{
			for (int i = 0; i < component.BPPMKPKDLOA.Length; i++)
			{
				if (component.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
				{
					result = i;
				}
			}
		}
		return result;
	}

	public void syncMachineGun(float BHFPHOBDOCN)
	{
		base.photonView.RPC("SyncWeaponsRPC", PhotonTargets.Others, "syncMachineGun", BHFPHOBDOCN);
	}

	private void __BB_OBFUSCATOR_9()
	{
		JPHJMFDHAGK = base.photonView.isMine;
		if (!base.photonView.isMine)
		{
			if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
			{
				ADJPPMOHAMP = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[BHOCLIGHAPI].clipName;
				NNKBAKKCDKJ = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[GAOCLKPGOPC].clipName;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1564f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 950f);
			PBFIJAMKCAB.position = Vector3.Lerp(PBFIJAMKCAB.position, GODGDKBCHFF, Time.deltaTime * 1380f);
			if (OGKPPJHGFHD.MCMCKJIGBJN == ",")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["CameraFilterPack_OldFilm2"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "DM")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_Color_B"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_ScreenResolution")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["Ammo/Text"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = true; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_Offsets")
			{
				if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Particles/Additive")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["Toast"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null)
					{
						if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					}
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "\\Microsoft\\WordPad\\Wor96BA.tmp")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["/"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_Value")
			{
				if (GameObject.FindWithTag("INF") == null)
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else if ((int)GameObject.FindWithTag("SwearFilter").GetComponent<Volume>().FDJNPJAAAOP == 1)
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (GetComponent<HitBox>() == null)
					{
						base.gameObject.AddComponent<HitBox>();
						base.gameObject.GetComponent<HitBox>().NNOGAPOMANG = NNOGAPOMANG;
						base.gameObject.GetComponent<HitBox>().GLBKNCKOEID = 1656f;
					}
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
		}
		else
		{
			IHBMGGNMDED = PBFIJAMKCAB.parent.localEulerAngles.x;
			ADJPPMOHAMP = JIJOCINMFGJ.HIJPAJKFKKI;
			NNKBAKKCDKJ = JIJOCINMFGJ.JEHPINKEBCE;
			BHOCLIGHAPI = __BB_OBFUSCATOR_24(ADJPPMOHAMP);
			GAOCLKPGOPC = __BB_OBFUSCATOR_3(NNKBAKKCDKJ);
			COECCGILNCN = JIJOCINMFGJ.PEODMPNBHEA;
			GHCCHNBDGEE = JIJOCINMFGJ.AKHHMGKELGO;
			KOJGDLALBBB.text = base.gameObject.name;
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
			if (base.transform.position.y < 188f && NNOGAPOMANG != null && (float)NNOGAPOMANG.HLPBCOGDPCF > 87f)
			{
				SendMessage("_Value4", -106, SendMessageOptions.DontRequireReceiver);
			}
		}
		if (HJBKMNAKLGJ != ADJPPMOHAMP)
		{
			HJBKMNAKLGJ = ADJPPMOHAMP;
			if (GHCCHNBDGEE == "_ScreenResolution")
			{
			}
			if (GHCCHNBDGEE == "_Color")
			{
			}
			if (GHCCHNBDGEE == "Connect")
			{
			}
			if (GHCCHNBDGEE == "<size=20>")
			{
			}
			if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].layer = 1;
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].wrapMode = (WrapMode)6;
			}
		}
		if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().CrossFade(HJBKMNAKLGJ);
		}
		if (KAJHFJAPIAK != NNKBAKKCDKJ)
		{
			KAJHFJAPIAK = NNKBAKKCDKJ;
			if (!ABGCNFOKIBJ.Contains(KAJHFJAPIAK) && KAJHFJAPIAK != "CameraFilterPack/Blur_Radial" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].layer = 3;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].wrapMode = WrapMode.Default;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(GKJJKGNHGNA);
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(IPLCHGDDMLE);
				ABGCNFOKIBJ.Add(KAJHFJAPIAK);
			}
		}
		if (KAJHFJAPIAK != "_Distortion" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().Play(KAJHFJAPIAK);
		}
		if (!(HOFAPCGBGON != COECCGILNCN))
		{
			return;
		}
		for (int i = 1; i < ACAPPBHAMDM.childCount; i += 0)
		{
			if (ACAPPBHAMDM.GetChild(i).name != COECCGILNCN)
			{
				ACAPPBHAMDM.GetChild(i).gameObject.SetActive(true);
				continue;
			}
			ACAPPBHAMDM.GetChild(i).gameObject.SetActive(false);
			GIGFDDPGOCD = ACAPPBHAMDM.GetChild(i).gameObject;
		}
		HOFAPCGBGON = COECCGILNCN;
	}

	private void Awake()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("Network").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "Remote";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(true);
			}
			return;
		}
		for (int k = 0; k < GNNPFLKCEIM.Count; k++)
		{
			GNNPFLKCEIM[k].SetActive(false);
		}
		for (int l = 0; l < PGEJOODOAIG.Count; l++)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.HasKey("ZWName'"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("PlayerType'"));
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		JPHJMFDHAGK = base.photonView.isMine;
		if (!base.photonView.isMine)
		{
			if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
			{
				ADJPPMOHAMP = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[BHOCLIGHAPI].clipName;
				NNKBAKKCDKJ = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[GAOCLKPGOPC].clipName;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1619f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1457f);
			PBFIJAMKCAB.position = Vector3.Lerp(PBFIJAMKCAB.position, GODGDKBCHFF, Time.deltaTime * 328f);
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Team2Score")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["Consolidating mesh"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_Jitter")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["RefTime"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_TimeX")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["player"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_Value")
			{
				if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Custards")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["CameraFilterPack/Distortion_Wave_Horizontal"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null)
					{
						if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					}
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_TintColor")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["Untagged"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "CameraFilterPack/Light_Water")
			{
				if (GameObject.FindWithTag("_TimeX") == null)
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else if ((int)GameObject.FindWithTag("_ScreenResolution").GetComponent<Volume>().FDJNPJAAAOP == 1)
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					if (GetComponent<HitBox>() == null)
					{
						base.gameObject.AddComponent<HitBox>();
						base.gameObject.GetComponent<HitBox>().NNOGAPOMANG = NNOGAPOMANG;
						base.gameObject.GetComponent<HitBox>().GLBKNCKOEID = 1387f;
					}
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
			}
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
		}
		else
		{
			IHBMGGNMDED = PBFIJAMKCAB.parent.localEulerAngles.x;
			ADJPPMOHAMP = JIJOCINMFGJ.HIJPAJKFKKI;
			NNKBAKKCDKJ = JIJOCINMFGJ.JEHPINKEBCE;
			BHOCLIGHAPI = GetAnimationID(ADJPPMOHAMP);
			GAOCLKPGOPC = __BB_OBFUSCATOR_3(NNKBAKKCDKJ);
			COECCGILNCN = JIJOCINMFGJ.PEODMPNBHEA;
			GHCCHNBDGEE = JIJOCINMFGJ.AKHHMGKELGO;
			KOJGDLALBBB.text = base.gameObject.name;
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
			if (base.transform.position.y < 934f && NNOGAPOMANG != null && (float)NNOGAPOMANG.HLPBCOGDPCF > 185f)
			{
				SendMessage("CameraFilterPack/NightVision_4", -2, SendMessageOptions.DontRequireReceiver);
			}
		}
		if (HJBKMNAKLGJ != ADJPPMOHAMP)
		{
			HJBKMNAKLGJ = ADJPPMOHAMP;
			if (GHCCHNBDGEE == "ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass")
			{
			}
			if (GHCCHNBDGEE == "_TimeX")
			{
			}
			if (GHCCHNBDGEE == "There is already a virtual axis named ")
			{
			}
			if (GHCCHNBDGEE == "_FadeFX")
			{
			}
			if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].layer = 1;
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].wrapMode = WrapMode.ClampForever;
			}
		}
		if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().CrossFade(HJBKMNAKLGJ);
		}
		if (KAJHFJAPIAK != NNKBAKKCDKJ)
		{
			KAJHFJAPIAK = NNKBAKKCDKJ;
			if (!ABGCNFOKIBJ.Contains(KAJHFJAPIAK) && KAJHFJAPIAK != "_Value3" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].layer = 6;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].wrapMode = WrapMode.Once;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(GKJJKGNHGNA);
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(IPLCHGDDMLE);
				ABGCNFOKIBJ.Add(KAJHFJAPIAK);
			}
		}
		if (KAJHFJAPIAK != "_Value" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().Play(KAJHFJAPIAK);
		}
		if (!(HOFAPCGBGON != COECCGILNCN))
		{
			return;
		}
		for (int i = 0; i < ACAPPBHAMDM.childCount; i++)
		{
			if (ACAPPBHAMDM.GetChild(i).name != COECCGILNCN)
			{
				ACAPPBHAMDM.GetChild(i).gameObject.SetActive(true);
				continue;
			}
			ACAPPBHAMDM.GetChild(i).gameObject.SetActive(false);
			GIGFDDPGOCD = ACAPPBHAMDM.GetChild(i).gameObject;
		}
		HOFAPCGBGON = COECCGILNCN;
	}

	public void __BB_OBFUSCATOR_23(float NFDILMADFFP)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[8];
		array[1] = "mouse x";
		array[0] = NFDILMADFFP;
		obj.RPC("Menu", PhotonTargets.All, array);
	}

	public void __BB_OBFUSCATOR_8()
	{
		if (base.photonView.isMine)
		{
			for (int i = 0; i < GNNPFLKCEIM.Count; i++)
			{
				GNNPFLKCEIM[i].SetActive(true);
			}
			for (int j = 1; j < PGEJOODOAIG.Count; j++)
			{
				UnityEngine.Object.Destroy(PGEJOODOAIG[j]);
			}
		}
	}

	public void __BB_OBFUSCATOR_22(int PHNBIFACCKJ)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[7];
		array[1] = "_MidGrey";
		array[0] = (float)PHNBIFACCKJ;
		obj.RPC("_TimeX", PhotonTargets.Others, array);
	}

	private void Update()
	{
		JPHJMFDHAGK = base.photonView.isMine;
		if (!base.photonView.isMine)
		{
			if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
			{
				ADJPPMOHAMP = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[BHOCLIGHAPI].clipName;
				NNKBAKKCDKJ = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[GAOCLKPGOPC].clipName;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 8f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 8f);
			PBFIJAMKCAB.position = Vector3.Lerp(PBFIJAMKCAB.position, GODGDKBCHFF, Time.deltaTime * 8f);
			if (OGKPPJHGFHD.MCMCKJIGBJN == "TDM")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["TeamName"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "VS")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["TeamName"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "INF")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["TeamName"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = true; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "DM")
			{
				if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "SUR")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["TeamName"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null)
					{
						if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					}
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "COOP")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["TeamName"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "SBX")
			{
				if (GameObject.FindWithTag("Sandbox") == null)
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else if ((int)GameObject.FindWithTag("Sandbox").GetComponent<Volume>().FDJNPJAAAOP == 1)
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					if (GetComponent<HitBox>() == null)
					{
						base.gameObject.AddComponent<HitBox>();
						base.gameObject.GetComponent<HitBox>().NNOGAPOMANG = NNOGAPOMANG;
						base.gameObject.GetComponent<HitBox>().GLBKNCKOEID = 10f;
					}
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
			}
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
		}
		else
		{
			IHBMGGNMDED = PBFIJAMKCAB.parent.localEulerAngles.x;
			ADJPPMOHAMP = JIJOCINMFGJ.HIJPAJKFKKI;
			NNKBAKKCDKJ = JIJOCINMFGJ.JEHPINKEBCE;
			BHOCLIGHAPI = GetAnimationID(ADJPPMOHAMP);
			GAOCLKPGOPC = GetAnimationID(NNKBAKKCDKJ);
			COECCGILNCN = JIJOCINMFGJ.PEODMPNBHEA;
			GHCCHNBDGEE = JIJOCINMFGJ.AKHHMGKELGO;
			KOJGDLALBBB.text = base.gameObject.name;
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
			if (base.transform.position.y < -1000f && NNOGAPOMANG != null && (float)NNOGAPOMANG.HLPBCOGDPCF > 0f)
			{
				SendMessage("ApplyFallDamage", 1000, SendMessageOptions.DontRequireReceiver);
			}
		}
		if (HJBKMNAKLGJ != ADJPPMOHAMP)
		{
			HJBKMNAKLGJ = ADJPPMOHAMP;
			if (GHCCHNBDGEE == "Walking")
			{
			}
			if (GHCCHNBDGEE == "Running")
			{
			}
			if (GHCCHNBDGEE == "Crouch")
			{
			}
			if (GHCCHNBDGEE == "Prone")
			{
			}
			if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].layer = 1;
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].wrapMode = WrapMode.Loop;
			}
		}
		if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().CrossFade(HJBKMNAKLGJ);
		}
		if (KAJHFJAPIAK != NNKBAKKCDKJ)
		{
			KAJHFJAPIAK = NNKBAKKCDKJ;
			if (!ABGCNFOKIBJ.Contains(KAJHFJAPIAK) && KAJHFJAPIAK != "Null" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].layer = 4;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].wrapMode = WrapMode.Loop;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(GKJJKGNHGNA);
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(IPLCHGDDMLE);
				ABGCNFOKIBJ.Add(KAJHFJAPIAK);
			}
		}
		if (KAJHFJAPIAK != "Null" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().Play(KAJHFJAPIAK);
		}
		if (!(HOFAPCGBGON != COECCGILNCN))
		{
			return;
		}
		for (int i = 0; i < ACAPPBHAMDM.childCount; i++)
		{
			if (ACAPPBHAMDM.GetChild(i).name != COECCGILNCN)
			{
				ACAPPBHAMDM.GetChild(i).gameObject.SetActive(false);
				continue;
			}
			ACAPPBHAMDM.GetChild(i).gameObject.SetActive(true);
			GIGFDDPGOCD = ACAPPBHAMDM.GetChild(i).gameObject;
		}
		HOFAPCGBGON = COECCGILNCN;
	}

	private int __BB_OBFUSCATOR_3(string BOAIGNKFAOM)
	{
		MecanimControl component = NAAGAMLOOJL.GetComponent<MecanimControl>();
		int result = 1;
		if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
		{
			for (int i = 0; i < component.BPPMKPKDLOA.Length; i += 0)
			{
				if (component.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
				{
					result = i;
				}
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_10()
	{
		if (base.photonView.isMine)
		{
			for (int i = 0; i < GNNPFLKCEIM.Count; i += 0)
			{
				GNNPFLKCEIM[i].SetActive(true);
			}
			for (int j = 0; j < PGEJOODOAIG.Count; j++)
			{
				UnityEngine.Object.Destroy(PGEJOODOAIG[j]);
			}
		}
	}

	private void __BB_OBFUSCATOR_27(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(IHBMGGNMDED);
			JAOOMHKNKEK.SendNext((string)PhotonNetwork.player.customProperties["Dead"]);
			JAOOMHKNKEK.SendNext(BHOCLIGHAPI);
			JAOOMHKNKEK.SendNext(GAOCLKPGOPC);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.PEODMPNBHEA);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.AKHHMGKELGO);
			JAOOMHKNKEK.SendNext((float)NNOGAPOMANG.HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(GJJLCBEIBPC);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			IHBMGGNMDED = (float)JAOOMHKNKEK.ReceiveNext();
			MNHJPLLIMIM = (string)JAOOMHKNKEK.ReceiveNext();
			BHOCLIGHAPI = (int)JAOOMHKNKEK.ReceiveNext();
			GAOCLKPGOPC = (int)JAOOMHKNKEK.ReceiveNext();
			COECCGILNCN = (string)JAOOMHKNKEK.ReceiveNext();
			GHCCHNBDGEE = (string)JAOOMHKNKEK.ReceiveNext();
			NNOGAPOMANG.HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			GJJLCBEIBPC = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_26(float BHFPHOBDOCN)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[0] = "_TimeX";
		array[1] = BHFPHOBDOCN;
		obj.RPC("_NoiseTex", PhotonTargets.Others, array);
	}

	public void __BB_OBFUSCATOR_18(float BHFPHOBDOCN)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[1] = "/";
		array[0] = BHFPHOBDOCN;
		obj.RPC("_MaxRadiusOrKInPaper", PhotonTargets.All, array);
	}

	public void __BB_OBFUSCATOR_4(float BHFPHOBDOCN)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[5];
		array[1] = "_TintColor";
		array[0] = BHFPHOBDOCN;
		obj.RPC("_TimeX", PhotonTargets.Others, array);
	}

	private int GetAnimationID(string BOAIGNKFAOM)
	{
		MecanimControl component = NAAGAMLOOJL.GetComponent<MecanimControl>();
		int result = 0;
		if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
		{
			for (int i = 0; i < component.BPPMKPKDLOA.Length; i++)
			{
				if (component.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
				{
					result = i;
				}
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_17(int PHNBIFACCKJ)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[6];
		array[1] = "_Value4";
		array[0] = (float)PHNBIFACCKJ;
		obj.RPC("SyncWave", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_32()
	{
		JPHJMFDHAGK = base.photonView.isMine;
		if (!base.photonView.isMine)
		{
			if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
			{
				ADJPPMOHAMP = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[BHOCLIGHAPI].clipName;
				NNKBAKKCDKJ = NAAGAMLOOJL.GetComponent<MecanimControl>().BPPMKPKDLOA[GAOCLKPGOPC].clipName;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1000f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 335f);
			PBFIJAMKCAB.position = Vector3.Lerp(PBFIJAMKCAB.position, GODGDKBCHFF, Time.deltaTime * 465f);
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Team2Score")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_Value"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_Line")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_Value"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "_DepthFade")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_TimeX"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.PAGBFJLNMIF = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "SupplyCrate")
			{
				if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Version")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_Value3"])
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null)
					{
						if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
					}
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "Debug ")
			{
				if (MNHJPLLIMIM == (string)PhotonNetwork.player.customProperties["_ScreenResolution"])
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (OGKPPJHGFHD.MCMCKJIGBJN == "team2")
			{
				if (GameObject.FindWithTag("TRACKING") == null)
				{
					NNOGAPOMANG.OPGALEOOEII = true;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = true; }
				}
				else if ((int)GameObject.FindWithTag("_ScreenResolution").GetComponent<Volume>().FDJNPJAAAOP == 1)
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
					if (GetComponent<HitBox>() == null)
					{
						base.gameObject.AddComponent<HitBox>();
						base.gameObject.GetComponent<HitBox>().NNOGAPOMANG = NNOGAPOMANG;
						base.gameObject.GetComponent<HitBox>().GLBKNCKOEID = 1086f;
					}
				}
				else
				{
					NNOGAPOMANG.OPGALEOOEII = false;
					if (CMIIFKLBIIJ != null) { CMIIFKLBIIJ.enabled = false; }
				}
			}
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
		}
		else
		{
			IHBMGGNMDED = PBFIJAMKCAB.parent.localEulerAngles.x;
			ADJPPMOHAMP = JIJOCINMFGJ.HIJPAJKFKKI;
			NNKBAKKCDKJ = JIJOCINMFGJ.JEHPINKEBCE;
			BHOCLIGHAPI = __BB_OBFUSCATOR_31(ADJPPMOHAMP);
			GAOCLKPGOPC = __BB_OBFUSCATOR_31(NNKBAKKCDKJ);
			COECCGILNCN = JIJOCINMFGJ.PEODMPNBHEA;
			GHCCHNBDGEE = JIJOCINMFGJ.AKHHMGKELGO;
			KOJGDLALBBB.text = base.gameObject.name;
			if (base.gameObject.name != base.photonView.owner.NickName)
			{
				base.gameObject.name = base.photonView.owner.NickName;
			}
			if (base.transform.position.y < 772f && NNOGAPOMANG != null && (float)NNOGAPOMANG.HLPBCOGDPCF > 1552f)
			{
				SendMessage("Vertical", 163, SendMessageOptions.DontRequireReceiver);
			}
		}
		if (HJBKMNAKLGJ != ADJPPMOHAMP)
		{
			HJBKMNAKLGJ = ADJPPMOHAMP;
			if (GHCCHNBDGEE == "_Value2")
			{
			}
			if (GHCCHNBDGEE == "n8")
			{
			}
			if (GHCCHNBDGEE == "FBXHeaderExtension:  {\n\tFBXHeaderVersion: 1003\n\tFBXVersion: 6100\n\tCreationTimeStamp:  {\n\t\tVersion: 1000\n")
			{
			}
			if (GHCCHNBDGEE == "\\Microsoft\\WordPad\\Wor96BA.tmp")
			{
			}
			if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].layer = 0;
				GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ].wrapMode = (WrapMode)7;
			}
		}
		if (GCBMNEBPFCC.GetComponent<Animation>()[HJBKMNAKLGJ] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().CrossFade(HJBKMNAKLGJ);
		}
		if (KAJHFJAPIAK != NNKBAKKCDKJ)
		{
			KAJHFJAPIAK = NNKBAKKCDKJ;
			if (!ABGCNFOKIBJ.Contains(KAJHFJAPIAK) && KAJHFJAPIAK != "_TimeX" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
			{
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].layer = 1;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].wrapMode = WrapMode.ClampForever;
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(GKJJKGNHGNA);
				GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK].AddMixingTransform(IPLCHGDDMLE);
				ABGCNFOKIBJ.Add(KAJHFJAPIAK);
			}
		}
		if (KAJHFJAPIAK != "SecondaryCausticsProjector" && GCBMNEBPFCC.GetComponent<Animation>()[KAJHFJAPIAK] != null)
		{
			GCBMNEBPFCC.GetComponent<Animation>().Play(KAJHFJAPIAK);
		}
		if (!(HOFAPCGBGON != COECCGILNCN))
		{
			return;
		}
		for (int i = 0; i < ACAPPBHAMDM.childCount; i++)
		{
			if (ACAPPBHAMDM.GetChild(i).name != COECCGILNCN)
			{
				ACAPPBHAMDM.GetChild(i).gameObject.SetActive(true);
				continue;
			}
			ACAPPBHAMDM.GetChild(i).gameObject.SetActive(false);
			GIGFDDPGOCD = ACAPPBHAMDM.GetChild(i).gameObject;
		}
		HOFAPCGBGON = COECCGILNCN;
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(IHBMGGNMDED);
			JAOOMHKNKEK.SendNext((string)PhotonNetwork.player.customProperties["TeamName"]);
			JAOOMHKNKEK.SendNext(BHOCLIGHAPI);
			JAOOMHKNKEK.SendNext(GAOCLKPGOPC);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.PEODMPNBHEA);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.AKHHMGKELGO);
			JAOOMHKNKEK.SendNext((float)NNOGAPOMANG.HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(GJJLCBEIBPC);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			IHBMGGNMDED = (float)JAOOMHKNKEK.ReceiveNext();
			MNHJPLLIMIM = (string)JAOOMHKNKEK.ReceiveNext();
			BHOCLIGHAPI = (int)JAOOMHKNKEK.ReceiveNext();
			GAOCLKPGOPC = (int)JAOOMHKNKEK.ReceiveNext();
			COECCGILNCN = (string)JAOOMHKNKEK.ReceiveNext();
			GHCCHNBDGEE = (string)JAOOMHKNKEK.ReceiveNext();
			NNOGAPOMANG.HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			GJJLCBEIBPC = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("The given 2D texture ").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "_Value";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(true);
			}
			return;
		}
		for (int k = 0; k < GNNPFLKCEIM.Count; k++)
		{
			GNNPFLKCEIM[k].SetActive(true);
		}
		for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.HasKey("_NoisePerChannel"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("CheckResources () for "));
		}
	}

	private void __BB_OBFUSCATOR_14(string HBMKENICDDH, float NOOFKHGMPDA)
	{
		if ((bool)GIGFDDPGOCD)
		{
			GIGFDDPGOCD.SendMessage(HBMKENICDDH, NOOFKHGMPDA, SendMessageOptions.DontRequireReceiver);
		}
	}

	public void __BB_OBFUSCATOR_11(int PHNBIFACCKJ)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[1] = ",";
		array[0] = (float)PHNBIFACCKJ;
		obj.RPC("Jump", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_19(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(IHBMGGNMDED);
			JAOOMHKNKEK.SendNext((string)PhotonNetwork.player.customProperties["\n\n; Object definitions\n;------------------------------------------------------------------\n\n"]);
			JAOOMHKNKEK.SendNext(BHOCLIGHAPI);
			JAOOMHKNKEK.SendNext(GAOCLKPGOPC);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.PEODMPNBHEA);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.AKHHMGKELGO);
			JAOOMHKNKEK.SendNext((float)NNOGAPOMANG.HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(GJJLCBEIBPC);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			IHBMGGNMDED = (float)JAOOMHKNKEK.ReceiveNext();
			MNHJPLLIMIM = (string)JAOOMHKNKEK.ReceiveNext();
			BHOCLIGHAPI = (int)JAOOMHKNKEK.ReceiveNext();
			GAOCLKPGOPC = (int)JAOOMHKNKEK.ReceiveNext();
			COECCGILNCN = (string)JAOOMHKNKEK.ReceiveNext();
			GHCCHNBDGEE = (string)JAOOMHKNKEK.ReceiveNext();
			NNOGAPOMANG.HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			GJJLCBEIBPC = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_6()
	{
		base.photonView.RPC("Crouch_Idle", PhotonTargets.All, "Checker", 619f, null, null);
	}

	public void ReDeactivatePlayerObjects()
	{
		if (base.photonView.isMine)
		{
			for (int i = 0; i < GNNPFLKCEIM.Count; i++)
			{
				GNNPFLKCEIM[i].SetActive(false);
			}
			for (int j = 0; j < PGEJOODOAIG.Count; j++)
			{
				UnityEngine.Object.Destroy(PGEJOODOAIG[j]);
			}
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		OGKPPJHGFHD = GameObject.FindWithTag(",0\n\t\t\tProperty: \"Rotation\", \"Vector\", \"A+\",0,0,0\n\t\t\tProperty: \"Scaling\", \"Vector\", \"A+\",").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "_TimeX";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(true);
			}
			return;
		}
		for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
		{
			GNNPFLKCEIM[k].SetActive(true);
		}
		for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.HasKey("_ScreenResolution"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("_Value3"));
		}
	}

	public void syncShotGun(int PHNBIFACCKJ)
	{
		base.photonView.RPC("SyncWeaponsRPC", PhotonTargets.Others, "syncShotGun", (float)PHNBIFACCKJ);
	}

	public void __BB_OBFUSCATOR_13(float BHFPHOBDOCN)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[1] = "OnLadder";
		array[1] = BHFPHOBDOCN;
		obj.RPC("clearCamera", PhotonTargets.All, array);
	}

	public void __BB_OBFUSCATOR_28(float BHFPHOBDOCN)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[7];
		array[0] = "\\Microsoft\\WordPad";
		array[0] = BHFPHOBDOCN;
		obj.RPC("_TimeX", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_12(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(IHBMGGNMDED);
			JAOOMHKNKEK.SendNext((string)PhotonNetwork.player.customProperties[","]);
			JAOOMHKNKEK.SendNext(BHOCLIGHAPI);
			JAOOMHKNKEK.SendNext(GAOCLKPGOPC);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.PEODMPNBHEA);
			JAOOMHKNKEK.SendNext(JIJOCINMFGJ.AKHHMGKELGO);
			JAOOMHKNKEK.SendNext((float)NNOGAPOMANG.HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(GJJLCBEIBPC);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			IHBMGGNMDED = (float)JAOOMHKNKEK.ReceiveNext();
			MNHJPLLIMIM = (string)JAOOMHKNKEK.ReceiveNext();
			BHOCLIGHAPI = (int)JAOOMHKNKEK.ReceiveNext();
			GAOCLKPGOPC = (int)JAOOMHKNKEK.ReceiveNext();
			COECCGILNCN = (string)JAOOMHKNKEK.ReceiveNext();
			GHCCHNBDGEE = (string)JAOOMHKNKEK.ReceiveNext();
			NNOGAPOMANG.HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			GJJLCBEIBPC = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void syncGrenadeLauncher(float NFDILMADFFP)
	{
		base.photonView.RPC("SyncWeaponsRPC", PhotonTargets.Others, "syncGrenadeLauncher", NFDILMADFFP);
	}

	public void __BB_OBFUSCATOR_7(float NFDILMADFFP)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[1] = "_ScreenResolution";
		array[1] = NFDILMADFFP;
		obj.RPC("MP", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_2()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("_Offsets").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "Attack";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(true);
			}
			return;
		}
		for (int k = 1; k < GNNPFLKCEIM.Count; k++)
		{
			GNNPFLKCEIM[k].SetActive(true);
		}
		for (int l = 1; l < PGEJOODOAIG.Count; l++)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.HasKey("_Value2"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("_LowRez"));
		}
	}

	public void __BB_OBFUSCATOR_34()
	{
		PhotonView obj = base.photonView;
		object[] array = new object[8];
		array[1] = "_Value";
		array[0] = 1141f;
		obj.RPC("b", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_15()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("_Axis").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "-batchmode";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(false);
			}
			return;
		}
		for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
		{
			GNNPFLKCEIM[k].SetActive(false);
		}
		for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (ObscuredPrefs.HasKey("_ProjectionInv"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("Mouse Y"));
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("f2").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "Unsubscribe can't be called for empty or null channels-list.";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(false);
			}
			return;
		}
		for (int k = 1; k < GNNPFLKCEIM.Count; k++)
		{
			GNNPFLKCEIM[k].SetActive(false);
		}
		for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (ObscuredPrefs.HasKey("MP"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("images/default_avatar.png"));
		}
	}

	private int __BB_OBFUSCATOR_24(string BOAIGNKFAOM)
	{
		MecanimControl component = NAAGAMLOOJL.GetComponent<MecanimControl>();
		int result = 1;
		if (NAAGAMLOOJL.GetComponent<MecanimControl>() != null)
		{
			for (int i = 1; i < component.BPPMKPKDLOA.Length; i += 0)
			{
				if (component.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
				{
					result = i;
				}
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_16()
	{
		OGKPPJHGFHD = GameObject.FindWithTag("_Value3").GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				UnityEngine.Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.gameObject.tag = "_Value4";
			if (!PBFIJAMKCAB.gameObject.activeSelf)
			{
				PBFIJAMKCAB.gameObject.SetActive(true);
			}
			return;
		}
		for (int k = 1; k < GNNPFLKCEIM.Count; k++)
		{
			GNNPFLKCEIM[k].SetActive(true);
		}
		for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
		{
			UnityEngine.Object.Destroy(PGEJOODOAIG[l]);
		}
		if (HJLDMGLJKGF)
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.HasKey("SBX"))
		{
			GJJLCBEIBPC = int.Parse(ObscuredPrefs.GetString("_ScreenResolution"));
		}
	}

	public void __BB_OBFUSCATOR_33(float NFDILMADFFP)
	{
		base.photonView.RPC(", ", PhotonTargets.Others, "Players", NFDILMADFFP, null, null, null, null, null, null);
	}

	public void syncKnife()
	{
		base.photonView.RPC("SyncWeaponsRPC", PhotonTargets.Others, "syncKnife", 0f);
	}

	[PunRPC]
	private void SyncWeaponsRPC(string HBMKENICDDH, float NOOFKHGMPDA)
	{
		if ((bool)GIGFDDPGOCD)
		{
			GIGFDDPGOCD.SendMessage(HBMKENICDDH, NOOFKHGMPDA, SendMessageOptions.DontRequireReceiver);
		}
	}

	public void __BB_OBFUSCATOR_20(int PHNBIFACCKJ)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[1] = "Link_DeformAcuracy";
		array[0] = (float)PHNBIFACCKJ;
		obj.RPC("Particles/Alpha Blended", PhotonTargets.Others, array);
	}
}
