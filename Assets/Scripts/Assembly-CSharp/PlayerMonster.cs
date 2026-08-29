using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using InControl.mod;
using Photon;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMonster : Photon.MonoBehaviour
{
	public FPSinput BFLHGFGBLME;

	public MecanimControl OLGIHBEIGND;

	public string GNCBKAICBJG;

	public int NAOGNHFIKJI;

	public List<GameObject> BKJEDLAOICL;

	public List<UnityEngine.MonoBehaviour> LOAOJLFEPAA;

	public List<GameObject> GNNPFLKCEIM;

	public List<UnityEngine.MonoBehaviour> PGEJOODOAIG;

	private RoomMultiplayerMenu OGKPPJHGFHD;

	private bool OHEOLDDNBII;

	public float HLPBCOGDPCF = 100f;

	public Transform NHDPIMJDMMN;

	private Color IGMLNEAFDBI;

	private AmbientMode PEEIDPEHHFC;

	private float ELFKBPLMMKA;

	private bool JCKKGEEICJP;

	public bool JPOBPFDOFFK;

	public bool AADCJKDLCIE;

	public bool EPKPFHJALLB;

	public Color IDLJPOLHOKB;

	private Color KICOGLMNKPK;

	public AudioClip KLHJNOELIKH;

	public AudioClip OIBNNIBIKFO;

	public AudioSource BHNLONPEMDJ;

	private GameObject MCDJLOECKJI;

	public Camera DJNOPPMIIHI;

	private float DBJLMBHEMDG = 6f;

	private float DECCPDBHKAF = 8f;

	private float FFFGHHCKMHG = 20f;

	private bool NIDFKEHLMLM;

	private Coroutine HJFFDIPMOFP;

	public int KGHCGCIMLCM = 1000;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private Quaternion DNLGDABCGDN = Quaternion.identity;

	private Vector3 GODGDKBCHFF = Vector3.zero;

	public float MDPMBHBBNMF;

	private string MNHJPLLIMIM = string.Empty;

	private void __BB_OBFUSCATOR_39()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	public void __BB_OBFUSCATOR_32(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[1].ToString());
		string text = JNGFBHEOHHE[1].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[5];
		array[0] = num;
		array[0] = PhotonNetwork.player;
		obj.RPC("_Value3", PhotonTargets.All, array);
	}

	private int __BB_OBFUSCATOR_81(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_89()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_18()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_82());
	}

	private IEnumerator __BB_OBFUSCATOR_43()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	public void __BB_OBFUSCATOR_70(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[1].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[1];
		array[1] = num;
		array[1] = PhotonNetwork.player;
		obj.RPC("CameraFilterPack/AAA_Super_Computer", PhotonTargets.Others, array);
	}

	private void __BB_OBFUSCATOR_20()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1140f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("\n\t\tLayer: 1 {\n\t\t\tVersion: 100\n\t\t\tLayerElement:  {\n\t\t\t\ttype: \"LayerElementUV\"\n\t\t\t\tTypedIndex: 1\n\t\t\t}\n\t\t}"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_73()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_60());
	}

	private int __BB_OBFUSCATOR_75(string BOAIGNKFAOM)
	{
		int result = 1;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i += 0)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	[PunRPC]
	private void Attack()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(isAttacking());
	}

	private void __BB_OBFUSCATOR_0(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_52(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[1].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[1] = num;
		array[1] = PhotonNetwork.player;
		obj.RPC("_Red_C", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_101()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_82());
	}

	private IEnumerator __BB_OBFUSCATOR_2()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private IEnumerator __BB_OBFUSCATOR_47()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_93(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private int __BB_OBFUSCATOR_7(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void Update()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = false;
			}
			else
			{
				component.CLFJBIPJCAL = true;
				if (cInput.GetButtonDown("Fire") && !OHEOLDDNBII)
				{
					base.photonView.RPC("Attack", PhotonTargets.All);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 5f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 0f)
				{
					GNCBKAICBJG = "Walk";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 0f)
				{
					GNCBKAICBJG = "Run";
				}
			}
			else if (HLPBCOGDPCF > 0f)
			{
				GNCBKAICBJG = "Idle";
			}
			else
			{
				GNCBKAICBJG = "Dead";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.GetAnimationData("Jump") != null && HLPBCOGDPCF > 0f)
			{
				GNCBKAICBJG = "Jump";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = GetAnimationID(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 8f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 8f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 8f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 0.1f);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_71(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void __BB_OBFUSCATOR_96()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(662f, base.transform.localEulerAngles.y, 1669f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = true;
			}
			else
			{
				component.CLFJBIPJCAL = false;
				if (cInput.GetButtonDown("</size>") && !OHEOLDDNBII)
				{
					base.photonView.RPC("_Green_B", PhotonTargets.Others, new object[1]);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 812f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 941f)
				{
					GNCBKAICBJG = "_Value3";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 880f)
				{
					GNCBKAICBJG = "_ExposureAdjustment";
				}
			}
			else if (HLPBCOGDPCF > 178f)
			{
				GNCBKAICBJG = "_Blue_C";
			}
			else
			{
				GNCBKAICBJG = "_Value4";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("_TimeX") != null && HLPBCOGDPCF > 1266f)
			{
				GNCBKAICBJG = "Floor";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_24(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 895f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 4f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 1313f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 1438f);
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(996f, base.transform.localEulerAngles.y, 660f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = false;
			}
			else
			{
				component.CLFJBIPJCAL = false;
				if (cInput.GetButtonDown("BodyURL") && !OHEOLDDNBII)
				{
					base.photonView.RPC("Sandbox", PhotonTargets.All);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 832f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 993f)
				{
					GNCBKAICBJG = "CameraFilterPack/FX_DigitalMatrix";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 856f)
				{
					GNCBKAICBJG = "_ScreenResolution";
				}
			}
			else if (HLPBCOGDPCF > 1472f)
			{
				GNCBKAICBJG = "_TimeX";
			}
			else
			{
				GNCBKAICBJG = "\n";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("_Offsets") != null && HLPBCOGDPCF > 596f)
			{
				GNCBKAICBJG = "DoDamage";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_95(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1722f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 864f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 54f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 1495f);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_41()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(192f, base.transform.localEulerAngles.y, 1226f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = true;
			}
			else
			{
				component.CLFJBIPJCAL = true;
				if (cInput.GetButtonDown("red") && !OHEOLDDNBII)
				{
					base.photonView.RPC("_ScreenResolution", PhotonTargets.All, new object[1]);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 233f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 1938f)
				{
					GNCBKAICBJG = "Team2Score";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 1303f)
				{
					GNCBKAICBJG = "Result";
				}
			}
			else if (HLPBCOGDPCF > 1601f)
			{
				GNCBKAICBJG = "team1";
			}
			else
			{
				GNCBKAICBJG = "_Light";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("Crouch") != null && HLPBCOGDPCF > 442f)
			{
				GNCBKAICBJG = "Objects:  {\n";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_9(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 42f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 497f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 1562f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 813f);
		}
	}

	public void __BB_OBFUSCATOR_34(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[0].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[5];
		array[1] = num;
		array[1] = PhotonNetwork.player;
		obj.RPC("monster", PhotonTargets.All, array);
	}

	private IEnumerator __BB_OBFUSCATOR_102(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	private int GetAnimationID(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_64(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1017f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
		}
		else
		{
			if (OLGIHBEIGND.GetAnimationData("ERROR") != null)
			{
				OLGIHBEIGND.CrossFade("Untagged", 591f);
			}
			GNCBKAICBJG = "Player Name";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 7f);
			for (int j = 1; j < base.transform.childCount; j++)
			{
				base.transform.GetChild(j).gameObject.SetActive(false);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("team2", base.photonView.owner.NickName, SendMessageOptions.DontRequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["CameraFilterPack/Vision_Blood"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Concrete", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["_SpotSize"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["RemoveFriends called while not connected to front end server."];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_TimeX", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["_MainTex"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["\"Model\""];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Toast", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3, null, true);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["Metal"];
			num3 += 0;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("vignetteIntensity", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(__BB_OBFUSCATOR_71(150f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = true;
			}
		}
		HLPBCOGDPCF = 1952f;
		OHEOLDDNBII = true;
		GetComponent<CapsuleCollider>().enabled = false;
	}

	private IEnumerator __BB_OBFUSCATOR_48()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private void Awake()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				Object.Destroy(BKJEDLAOICL[i].gameObject);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
			BFLHGFGBLME = GetComponent<FPSinput>();
			IGMLNEAFDBI = RenderSettings.ambientSkyColor;
			KICOGLMNKPK = RenderSettings.fogColor;
			PEEIDPEHHFC = RenderSettings.ambientMode;
			ELFKBPLMMKA = RenderSettings.fogDensity;
			JCKKGEEICJP = RenderSettings.fog;
			RenderSettings.ambientMode = AmbientMode.Flat;
			if (!AADCJKDLCIE)
			{
				RenderSettings.ambientSkyColor = new Color(0.8f, 0.8f, 0.8f, 0.8f);
			}
			RenderSettings.fogDensity = ELFKBPLMMKA / 1.5f;
			if (JPOBPFDOFFK)
			{
				RenderSettings.fog = false;
			}
			if (EPKPFHJALLB)
			{
				RenderSettings.fogColor = IDLJPOLHOKB;
			}
			if (DJNOPPMIIHI == null)
			{
				DJNOPPMIIHI = Camera.main;
			}
		}
		OGKPPJHGFHD = GameObject.FindWithTag("Network").GetComponent<RoomMultiplayerMenu>();
		MCDJLOECKJI = GameObject.FindWithTag("Network");
	}

	private void __BB_OBFUSCATOR_36()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1264f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton(","))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private IEnumerator __BB_OBFUSCATOR_12(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	public void ApplyDamage(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[1].ToString();
		base.photonView.RPC("DoDamage", PhotonTargets.All, num, PhotonNetwork.player);
	}

	private IEnumerator __BB_OBFUSCATOR_82()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private void __BB_OBFUSCATOR_58(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_33(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[0].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[6];
		array[1] = num;
		array[1] = PhotonNetwork.player;
		obj.RPC("_TimeX", PhotonTargets.All, array);
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				Object.Destroy(BKJEDLAOICL[i].gameObject);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
			BFLHGFGBLME = GetComponent<FPSinput>();
			IGMLNEAFDBI = RenderSettings.ambientSkyColor;
			KICOGLMNKPK = RenderSettings.fogColor;
			PEEIDPEHHFC = RenderSettings.ambientMode;
			ELFKBPLMMKA = RenderSettings.fogDensity;
			JCKKGEEICJP = RenderSettings.fog;
			RenderSettings.ambientMode = (AmbientMode)2;
			if (!AADCJKDLCIE)
			{
				RenderSettings.ambientSkyColor = new Color(1804f, 144f, 164f, 331f);
			}
			RenderSettings.fogDensity = ELFKBPLMMKA / 697f;
			if (JPOBPFDOFFK)
			{
				RenderSettings.fog = false;
			}
			if (EPKPFHJALLB)
			{
				RenderSettings.fogColor = IDLJPOLHOKB;
			}
			if (DJNOPPMIIHI == null)
			{
				DJNOPPMIIHI = Camera.main;
			}
		}
		OGKPPJHGFHD = GameObject.FindWithTag("Deformer").GetComponent<RoomMultiplayerMenu>();
		MCDJLOECKJI = GameObject.FindWithTag("Prev");
	}

	private IEnumerator __BB_OBFUSCATOR_80(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	private void __BB_OBFUSCATOR_105()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_82());
	}

	private IEnumerator DestroyPlayer(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_15()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private void __BB_OBFUSCATOR_10()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_15());
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(1756f, base.transform.localEulerAngles.y, 1653f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = true;
			}
			else
			{
				component.CLFJBIPJCAL = true;
				if (cInput.GetButtonDown("selectWeapon") && !OHEOLDDNBII)
				{
					base.photonView.RPC("CameraFilterPack/TV_WideScreenHV", PhotonTargets.All, new object[1]);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 1091f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 906f)
				{
					GNCBKAICBJG = "_Value2";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 24f)
				{
					GNCBKAICBJG = "Fire";
				}
			}
			else if (HLPBCOGDPCF > 251f)
			{
				GNCBKAICBJG = "_ScreenResolution";
			}
			else
			{
				GNCBKAICBJG = "Mouse Y";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("LegsURL") != null && HLPBCOGDPCF > 272f)
			{
				GNCBKAICBJG = "_Value4";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_50(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 895f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 199f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 915f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 263f);
		}
	}

	private void __BB_OBFUSCATOR_63(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1366f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 1; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
		}
		else
		{
			if (OLGIHBEIGND.__BB_OBFUSCATOR_19("CreationTime: \"{0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}:{0:fff}\"\n") != null)
			{
				OLGIHBEIGND.CrossFade("Mouse Y", 1722f);
			}
			GNCBKAICBJG = "_Value2";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 1007f);
			for (int j = 0; j < base.transform.childCount; j += 0)
			{
				base.transform.GetChild(j).gameObject.SetActive(true);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("{0},{1},{2}", base.photonView.owner.NickName, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["\"Model\""];
				num += 0;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Network", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["CameraFilterPack/Blend2Camera_Multiply"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["team1"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_TimeX", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["_Speed"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["_Value"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add(" ", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3, null, true);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["e"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("\n\t\t}", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(__BB_OBFUSCATOR_80(1339f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = false;
			}
		}
		HLPBCOGDPCF = 1649f;
		OHEOLDDNBII = false;
		GetComponent<CapsuleCollider>().enabled = true;
	}

	private void __BB_OBFUSCATOR_42(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_62(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[0].ToString();
		base.photonView.RPC(" </color></size>", PhotonTargets.Others, num, PhotonNetwork.player, null, null, null, null);
	}

	private void __BB_OBFUSCATOR_74()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 376f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("RefTime"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private IEnumerator Start()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	public void __BB_OBFUSCATOR_79(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[1].ToString();
		base.photonView.RPC("SBX", PhotonTargets.All, num, PhotonNetwork.player);
	}

	public void __BB_OBFUSCATOR_28(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[0].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[4];
		array[1] = num;
		array[1] = PhotonNetwork.player;
		obj.RPC("\"OO\", \"Texture::", PhotonTargets.Others, array);
	}

	public void __BB_OBFUSCATOR_69(object[] JNGFBHEOHHE)
	{
		float num = float.Parse(JNGFBHEOHHE[0].ToString());
		string text = JNGFBHEOHHE[0].ToString();
		PhotonView obj = base.photonView;
		object[] array = new object[5];
		array[1] = num;
		array[0] = PhotonNetwork.player;
		obj.RPC("SendChatMessage", PhotonTargets.Others, array);
	}

	private void OnDisable()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_60()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private int __BB_OBFUSCATOR_9(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(27f, base.transform.localEulerAngles.y, 1510f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = true;
			}
			else
			{
				component.CLFJBIPJCAL = false;
				if (cInput.GetButtonDown("WeaponManager") && !OHEOLDDNBII)
				{
					base.photonView.RPC(", 3: ", PhotonTargets.All);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 1399f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 1849f)
				{
					GNCBKAICBJG = "_FgOverlap";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 1705f)
				{
					GNCBKAICBJG = "_ReflectionTex";
				}
			}
			else if (HLPBCOGDPCF > 1684f)
			{
				GNCBKAICBJG = "\\Google";
			}
			else
			{
				GNCBKAICBJG = "_Value";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19(">") != null && HLPBCOGDPCF > 149f)
			{
				GNCBKAICBJG = "_ScreenResolution";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_24(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1666f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1325f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 20f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 1153f);
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(419f, base.transform.localEulerAngles.y, 1047f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = false;
			}
			else
			{
				component.CLFJBIPJCAL = true;
				if (cInput.GetButtonDown("_Distortion") && !OHEOLDDNBII)
				{
					base.photonView.RPC("n6", PhotonTargets.Others, new object[1]);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 1420f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 1960f)
				{
					GNCBKAICBJG = "_TimeX";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 390f)
				{
					GNCBKAICBJG = "_Value4";
				}
			}
			else if (HLPBCOGDPCF > 989f)
			{
				GNCBKAICBJG = "PlayerType'";
			}
			else
			{
				GNCBKAICBJG = "_Bullet_8";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.GetAnimationData("_Size") != null && HLPBCOGDPCF > 1348f)
			{
				GNCBKAICBJG = "holeUpdate";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = GetAnimationID(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 968f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 665f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 1746f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 289f);
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private int __BB_OBFUSCATOR_8(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i += 0)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(881f, base.transform.localEulerAngles.y, 210f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = true;
			}
			else
			{
				component.CLFJBIPJCAL = false;
				if (cInput.GetButtonDown("INF") && !OHEOLDDNBII)
				{
					base.photonView.RPC("MP", PhotonTargets.Others);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 453f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 549f)
				{
					GNCBKAICBJG = "Idle";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 568f)
				{
					GNCBKAICBJG = "_Value2";
				}
			}
			else if (HLPBCOGDPCF > 1281f)
			{
				GNCBKAICBJG = "CameraFilterPack/Blend2Camera_Overlay";
			}
			else
			{
				GNCBKAICBJG = "HatID";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("/") != null && HLPBCOGDPCF > 407f)
			{
				GNCBKAICBJG = "HatID";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_75(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 263f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 472f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 758f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 867f);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1967f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("Crouch"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_103(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1995f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
		}
		else
		{
			if (OLGIHBEIGND.__BB_OBFUSCATOR_19("_TimeX") != null)
			{
				OLGIHBEIGND.CrossFade("-Times Played: ", 1987f);
			}
			GNCBKAICBJG = "SecondaryCausticsProjector";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 316f);
			for (int j = 1; j < base.transform.childCount; j += 0)
			{
				base.transform.GetChild(j).gameObject.SetActive(true);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("_Value", base.photonView.owner.NickName, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["<"];
				num += 0;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("</size></color>", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["_NormalTex"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["MP"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Slow Mo: ", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["_ScreenResolution"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["HeatDistort"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("</size>", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["/"];
			num3 += 0;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Value5", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4, null, true);
			StartCoroutine(__BB_OBFUSCATOR_71(1011f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = false;
			}
		}
		HLPBCOGDPCF = 1362f;
		OHEOLDDNBII = true;
		GetComponent<CapsuleCollider>().enabled = true;
	}

	private void __BB_OBFUSCATOR_55(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 564f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
		}
		else
		{
			if (OLGIHBEIGND.__BB_OBFUSCATOR_19("networkAddMessage") != null)
			{
				OLGIHBEIGND.CrossFade("Language", 1862f);
			}
			GNCBKAICBJG = "</size>";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 510f);
			for (int j = 1; j < base.transform.childCount; j++)
			{
				base.transform.GetChild(j).gameObject.SetActive(false);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("_MainTex2", base.photonView.owner.NickName, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["\\Microsoft\\WordPad\\Wor96BA.tmp"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("_Axis", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["_Distortion"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["State1"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("RemoveFriends called while not connected to front end server.", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["*"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["pointBuffer"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("player", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["RangedAttack"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Value", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(439f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = true;
			}
		}
		HLPBCOGDPCF = 1346f;
		OHEOLDDNBII = true;
		GetComponent<CapsuleCollider>().enabled = true;
	}

	private void __BB_OBFUSCATOR_94()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1584f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("_TimeX"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_85()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_60());
	}

	private int __BB_OBFUSCATOR_95(string BOAIGNKFAOM)
	{
		int result = 1;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private IEnumerator isAttacking()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private void __BB_OBFUSCATOR_40(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_27(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1207f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
		}
		else
		{
			if (OLGIHBEIGND.GetAnimationData("RespawnPlayer2") != null)
			{
				OLGIHBEIGND.CrossFade("_ScreenResolution", 990f);
			}
			GNCBKAICBJG = "CameraFilterPack/FX_Hexagon_Black";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 290f);
			for (int j = 0; j < base.transform.childCount; j += 0)
			{
				base.transform.GetChild(j).gameObject.SetActive(false);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("MP", base.photonView.owner.NickName, SendMessageOptions.DontRequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["Idle"];
				num += 0;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Jump", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["_TapHigh"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["SupplyCrate"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_Value", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2, null, true);
				}
				if ((string)PhotonNetwork.player.customProperties["_Blur"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["_TimeX"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("\"Pose\"", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["Player"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Death", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4, null, true);
			StartCoroutine(__BB_OBFUSCATOR_80(1239f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = true;
			}
		}
		HLPBCOGDPCF = 757f;
		OHEOLDDNBII = false;
		GetComponent<CapsuleCollider>().enabled = false;
	}

	private void __BB_OBFUSCATOR_68(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_100()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private void __BB_OBFUSCATOR_19()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1782f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("_Transparency"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private IEnumerator __BB_OBFUSCATOR_16()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void NewMovement()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 8f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("Jump"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_98()
	{
		NIDFKEHLMLM = false;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_100());
	}

	private int __BB_OBFUSCATOR_50(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_30()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private IEnumerator __BB_OBFUSCATOR_17()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private IEnumerator __BB_OBFUSCATOR_14()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_106()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 529f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("Flashlight"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(OLGIHBEIGND.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			DNLGDABCGDN = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				Object.Destroy(BKJEDLAOICL[i].gameObject);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
			BFLHGFGBLME = GetComponent<FPSinput>();
			IGMLNEAFDBI = RenderSettings.ambientSkyColor;
			KICOGLMNKPK = RenderSettings.fogColor;
			PEEIDPEHHFC = RenderSettings.ambientMode;
			ELFKBPLMMKA = RenderSettings.fogDensity;
			JCKKGEEICJP = RenderSettings.fog;
			RenderSettings.ambientMode = AmbientMode.Skybox;
			if (!AADCJKDLCIE)
			{
				RenderSettings.ambientSkyColor = new Color(739f, 1877f, 135f, 1212f);
			}
			RenderSettings.fogDensity = ELFKBPLMMKA / 200f;
			if (JPOBPFDOFFK)
			{
				RenderSettings.fog = false;
			}
			if (EPKPFHJALLB)
			{
				RenderSettings.fogColor = IDLJPOLHOKB;
			}
			if (DJNOPPMIIHI == null)
			{
				DJNOPPMIIHI = Camera.main;
			}
		}
		OGKPPJHGFHD = GameObject.FindWithTag("survivors win").GetComponent<RoomMultiplayerMenu>();
		MCDJLOECKJI = GameObject.FindWithTag("1");
	}

	private int __BB_OBFUSCATOR_24(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 1; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_87()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_51()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1857f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("CO-OP"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_38(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1609f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 1; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
		}
		else
		{
			if (OLGIHBEIGND.GetAnimationData("Walk") != null)
			{
				OLGIHBEIGND.CrossFade("_Value2", 1129f);
			}
			GNCBKAICBJG = "_FrustumCornersWS";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 891f);
			for (int j = 1; j < base.transform.childCount; j++)
			{
				base.transform.GetChild(j).gameObject.SetActive(true);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("name", base.photonView.owner.NickName, SendMessageOptions.RequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["Hole"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("CameraFilterPack/Drawing_Lines", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["CameraFilterPack/Blend2Camera_PinLight"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["_Bullet_9"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_Value", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2, null, true);
				}
				if ((string)PhotonNetwork.player.customProperties["_SpawnHeuristic"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["CameraFilterPack/Colors_Threshold"];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3, null, true);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["_TimeX"];
			num3 += 0;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_TimeX", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(1794f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = false;
			}
		}
		HLPBCOGDPCF = 1089f;
		OHEOLDDNBII = true;
		GetComponent<CapsuleCollider>().enabled = false;
	}

	[PunRPC]
	private void DoDamage(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 0f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
		}
		else
		{
			if (OLGIHBEIGND.GetAnimationData("Dead") != null)
			{
				OLGIHBEIGND.CrossFade("Dead", 0.1f);
			}
			GNCBKAICBJG = "Dead";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 5f);
			for (int j = 0; j < base.transform.childCount; j++)
			{
				base.transform.GetChild(j).gameObject.SetActive(false);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("AddKillNotification", base.photonView.owner.NickName, SendMessageOptions.DontRequireReceiver);
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
			int num3 = (int)PhotonNetwork.player.customProperties["Deaths"];
			num3++;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Deaths", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4);
			StartCoroutine(DestroyPlayer(5f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = true;
			}
		}
		HLPBCOGDPCF = 0f;
		OHEOLDDNBII = true;
		GetComponent<CapsuleCollider>().enabled = false;
	}

	private IEnumerator __BB_OBFUSCATOR_61()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_104()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 897f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("_Refraction"))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private IEnumerator __BB_OBFUSCATOR_6()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}

	private void __BB_OBFUSCATOR_78(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (!(HLPBCOGDPCF <= 1579f))
		{
			return;
		}
		if (base.photonView.isMine && HJFFDIPMOFP != null)
		{
			StopCoroutine(HJFFDIPMOFP);
			HJFFDIPMOFP = null;
		}
		if (NHDPIMJDMMN != null)
		{
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			for (int i = 1; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
		}
		else
		{
			if (OLGIHBEIGND.GetAnimationData(" cannot be used as a 3D LUT.") != null)
			{
				OLGIHBEIGND.CrossFade("_ScreenResolution", 1140f);
			}
			GNCBKAICBJG = "TeamName";
			OLGIHBEIGND.transform.parent = null;
			Object.Destroy(OLGIHBEIGND.gameObject, 1641f);
			for (int j = 0; j < base.transform.childCount; j += 0)
			{
				base.transform.GetChild(j).gameObject.SetActive(true);
			}
		}
		if (!base.photonView.isMine)
		{
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
				MCDJLOECKJI.SendMessage("Right Stick Up", base.photonView.owner.NickName, SendMessageOptions.DontRequireReceiver);
				int num = (int)PhotonNetwork.player.customProperties["_TimeX"];
				num++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("_ScreenResolution", num);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet, null, true);
				int num2 = 1;
				if ((string)PhotonNetwork.player.customProperties["Picked ammo for | "] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties[" This is not possible to be called for standalone input. Please check your platform and code where this is called"];
					num2 += 0;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_Offsets", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["_TimeX"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					num2 = (int)PhotonNetwork.room.customProperties["joined "];
					num2++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("_Value3", num2);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
		}
		else
		{
			int num3 = (int)PhotonNetwork.player.customProperties["_TimeX"];
			num3 += 0;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("<size=25>", num3);
			ExitGames.Client.Photon.Hashtable propertiesToSet4 = hashtable;
			PhotonNetwork.player.SetCustomProperties(propertiesToSet4, null, true);
			StartCoroutine(__BB_OBFUSCATOR_102(863f));
			if (PhotonNetwork.player == HKOIJFEMIMB)
			{
			}
			if (DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>() != null)
			{
				DJNOPPMIIHI.GetComponent<CameraFilterPack_Color_RGB>().enabled = false;
			}
		}
		HLPBCOGDPCF = 640f;
		OHEOLDDNBII = false;
		GetComponent<CapsuleCollider>().enabled = false;
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (base.photonView.isMine)
		{
			FPScontroller component = GetComponent<FPScontroller>();
			component.ADDGNCLMHPK = DJNOPPMIIHI.gameObject;
			component.MOEAJIJBBKI = !OHEOLDDNBII;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = DJNOPPMIIHI.transform.rotation;
			base.transform.localEulerAngles = new Vector3(1028f, base.transform.localEulerAngles.y, 1716f);
			if (NIDFKEHLMLM)
			{
				component.CLFJBIPJCAL = false;
			}
			else
			{
				component.CLFJBIPJCAL = false;
				if (cInput.GetButtonDown(",") && !OHEOLDDNBII)
				{
					base.photonView.RPC("FireballB", PhotonTargets.Others);
				}
			}
			if (component.MPBEELGNNCF)
			{
				if (component.PAJCDFMHJLA != Vector3.zero)
				{
					Quaternion b = Quaternion.LookRotation(GetComponent<FPSinput>().INBMDEIBLKA);
					OLGIHBEIGND.transform.localRotation = Quaternion.Lerp(OLGIHBEIGND.transform.localRotation, b, 996f * Time.deltaTime);
				}
				if (HLPBCOGDPCF > 503f)
				{
					GNCBKAICBJG = "SBX";
				}
				if (component.KKBOHCFDNGD && HLPBCOGDPCF > 700f)
				{
					GNCBKAICBJG = "team2";
				}
			}
			else if (HLPBCOGDPCF > 546f)
			{
				GNCBKAICBJG = "_Value";
			}
			else
			{
				GNCBKAICBJG = "Idle";
			}
			if (component.KMHHLHFAAPH.jumping && OLGIHBEIGND.__BB_OBFUSCATOR_19("MP") != null && HLPBCOGDPCF > 1035f)
			{
				GNCBKAICBJG = "Join";
			}
			if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_50(GNCBKAICBJG);
			}
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1844f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1311f);
			OLGIHBEIGND.transform.rotation = Quaternion.Lerp(OLGIHBEIGND.transform.rotation, DNLGDABCGDN, Time.deltaTime * 1530f);
		}
		GNCBKAICBJG = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (OLGIHBEIGND.GetCurrentClipName() != GNCBKAICBJG && !NIDFKEHLMLM && !OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade(GNCBKAICBJG, 602f);
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if (Application.isPlaying && base.photonView.isMine)
		{
			RenderSettings.ambientSkyColor = IGMLNEAFDBI;
			RenderSettings.ambientMode = PEEIDPEHHFC;
			RenderSettings.fogDensity = ELFKBPLMMKA;
			RenderSettings.fog = JCKKGEEICJP;
			RenderSettings.fogColor = KICOGLMNKPK;
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		CharacterController component = GetComponent<CharacterController>();
		Vector3 vector = GetComponent<FPSinput>().INBMDEIBLKA;
		FPScontroller component2 = GetComponent<FPScontroller>();
		DBJLMBHEMDG = component2.LNECOJBDOOE.WalkSpeed;
		DECCPDBHKAF = 1874f * component2.KMHHLHFAAPH.baseHeight;
		if (component2.BJJNBHJBMLG && component2.CLFJBIPJCAL)
		{
			DBJLMBHEMDG = component2.LNECOJBDOOE.RunSpeed;
		}
		if (component.isGrounded)
		{
			vector = base.transform.TransformDirection(vector);
			vector *= DBJLMBHEMDG;
			if (Input.GetButton("Room "))
			{
				vector.y = DECCPDBHKAF;
			}
		}
		vector.y -= FFFGHHCKMHG * Time.deltaTime;
		component.Move(vector * Time.deltaTime);
	}

	private IEnumerator __BB_OBFUSCATOR_59()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private IEnumerator __BB_OBFUSCATOR_57(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
		if (OGKPPJHGFHD.MCMCKJIGBJN != "SBX")
		{
			OGKPPJHGFHD.SpawnPlayer(OGKPPJHGFHD.NICGOGPHBPD.teamName);
		}
		else
		{
			OGKPPJHGFHD.SendMessage("RespawnPlayer2");
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_100());
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				Object.Destroy(BKJEDLAOICL[i].gameObject);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
			BFLHGFGBLME = GetComponent<FPSinput>();
			IGMLNEAFDBI = RenderSettings.ambientSkyColor;
			KICOGLMNKPK = RenderSettings.fogColor;
			PEEIDPEHHFC = RenderSettings.ambientMode;
			ELFKBPLMMKA = RenderSettings.fogDensity;
			JCKKGEEICJP = RenderSettings.fog;
			RenderSettings.ambientMode = AmbientMode.Custom;
			if (!AADCJKDLCIE)
			{
				RenderSettings.ambientSkyColor = new Color(1721f, 467f, 1694f, 606f);
			}
			RenderSettings.fogDensity = ELFKBPLMMKA / 21f;
			if (JPOBPFDOFFK)
			{
				RenderSettings.fog = false;
			}
			if (EPKPFHJALLB)
			{
				RenderSettings.fogColor = IDLJPOLHOKB;
			}
			if (DJNOPPMIIHI == null)
			{
				DJNOPPMIIHI = Camera.main;
			}
		}
		OGKPPJHGFHD = GameObject.FindWithTag("OnFall").GetComponent<RoomMultiplayerMenu>();
		MCDJLOECKJI = GameObject.FindWithTag("Null");
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				Object.Destroy(BKJEDLAOICL[i].gameObject);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
			BFLHGFGBLME = GetComponent<FPSinput>();
			IGMLNEAFDBI = RenderSettings.ambientSkyColor;
			KICOGLMNKPK = RenderSettings.fogColor;
			PEEIDPEHHFC = RenderSettings.ambientMode;
			ELFKBPLMMKA = RenderSettings.fogDensity;
			JCKKGEEICJP = RenderSettings.fog;
			RenderSettings.ambientMode = AmbientMode.Custom;
			if (!AADCJKDLCIE)
			{
				RenderSettings.ambientSkyColor = new Color(26f, 873f, 348f, 187f);
			}
			RenderSettings.fogDensity = ELFKBPLMMKA / 724f;
			if (JPOBPFDOFFK)
			{
				RenderSettings.fog = true;
			}
			if (EPKPFHJALLB)
			{
				RenderSettings.fogColor = IDLJPOLHOKB;
			}
			if (DJNOPPMIIHI == null)
			{
				DJNOPPMIIHI = Camera.main;
			}
		}
		OGKPPJHGFHD = GameObject.FindWithTag("_Value").GetComponent<RoomMultiplayerMenu>();
		MCDJLOECKJI = GameObject.FindWithTag("_TimeX");
	}

	private void __BB_OBFUSCATOR_65()
	{
		NIDFKEHLMLM = false;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_48());
	}

	private void __BB_OBFUSCATOR_44()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_82());
	}

	private void __BB_OBFUSCATOR_25()
	{
		NIDFKEHLMLM = true;
		HJFFDIPMOFP = StartCoroutine(__BB_OBFUSCATOR_60());
	}

	private IEnumerator __BB_OBFUSCATOR_53()
	{
		NIDFKEHLMLM = true;
		if (HLPBCOGDPCF > 0f)
		{
			OLGIHBEIGND.CrossFade("Walk", 0.1f);
			OLGIHBEIGND.CrossFade("Attack", 0.1f);
		}
		if (KLHJNOELIKH != null && !BHNLONPEMDJ.isPlaying)
		{
			BHNLONPEMDJ.clip = KLHJNOELIKH;
			BHNLONPEMDJ.Play();
		}
		float num = OLGIHBEIGND.GetAnimationData("Attack").length / OLGIHBEIGND.GetAnimationData("Attack").speed;
		yield return new WaitForSeconds(num / 2f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			if (!(Vector3.Distance(base.transform.position, array[i].transform.position) < 2.75f))
			{
				continue;
			}
			if (base.photonView.isMine && !OHEOLDDNBII)
			{
				if (array[i].transform.parent.GetComponent<PlayerDamage>() != null)
				{
					array[i].transform.parent.GetComponent<PlayerDamage>().TotalDamage(KGHCGCIMLCM, string.Empty);
				}
				int num2 = (int)PhotonNetwork.player.customProperties["Kills"];
				num2++;
				ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
				hashtable.Add("Kills", num2);
				ExitGames.Client.Photon.Hashtable propertiesToSet = hashtable;
				PhotonNetwork.player.SetCustomProperties(propertiesToSet);
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.LEPLDNNHJPF.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team1Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team1Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet2 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet2);
				}
				if ((string)PhotonNetwork.player.customProperties["TeamName"] == OGKPPJHGFHD.NICGOGPHBPD.teamName)
				{
					int num3 = (int)PhotonNetwork.room.customProperties["Team2Score"];
					num3++;
					hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Team2Score", num3);
					ExitGames.Client.Photon.Hashtable propertiesToSet3 = hashtable;
					PhotonNetwork.room.SetCustomProperties(propertiesToSet3);
				}
			}
			if (OIBNNIBIKFO != null)
			{
				BHNLONPEMDJ.clip = OIBNNIBIKFO;
				BHNLONPEMDJ.Play();
			}
		}
		yield return new WaitForSeconds(num / 4f);
		NIDFKEHLMLM = false;
	}

	private IEnumerator __BB_OBFUSCATOR_99()
	{
		yield return new WaitForEndOfFrame();
		OLGIHBEIGND.Play("Attack");
	}
}
