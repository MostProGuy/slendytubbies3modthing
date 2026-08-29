using System;
using System.Collections;
using System.Collections.Generic;
using Photon;
using UnityEngine;
using UnityEngine.AI;

public class BossBot : Photon.MonoBehaviour
{
	[Serializable]
	public class skill
	{
		public string specialAnimation = "Idle";

		public float specialDelay;

		public float specialWaitDivide = 2f;

		public Transform projectile;

		public Transform projectilePosition;

		public bool projectilePositionLookAt;

		public float specialDistance = 20f;
	}

	public int ONKOIENLLFC;

	[HideInInspector]
	public string HKEPPNAHBOG;

	public string[] EAKDACOPPLJ;

	public int CEEGNIEBCGJ = 1;

	public float GFPDIKNCIKH = 2500f;

	public float HLPBCOGDPCF = 2500f;

	public Transform LJLBGNFIOPI;

	public MecanimControl OLGIHBEIGND;

	public string BDICHBPAKFJ;

	public int NAOGNHFIKJI;

	public Transform NHDPIMJDMMN;

	public float CAODOOBMGFN = 2f;

	private GameObject MCDJLOECKJI;

	private RoomMultiplayerMenu OGKPPJHGFHD;

	private NavMeshAgent LAMGCFPPKDJ;

	private bool KJBHNCFBOOI;

	public float DBJLMBHEMDG = 3.5f;

	public float PKMGBJGABJK = 3.5f;

	public float OMFNNEEPNGN = 7.5f;

	public bool AAINDCKBOPH;

	public string CICFKJNBDED = "Attack";

	private string IOJKGIIGCKJ = "Attack";

	public string CMCAILIEJLA = "Walk";

	public Transform ACGPKNCKBJE;

	public int JKEDBHDNPBO;

	public List<skill> MLDOHNIDBJK;

	private int HEAKJAPBDGE = 1;

	private float FGBOJFAFMDF;

	public bool CGOIJCJGOCK;

	private Vector3 DOBLAMKENII;

	private float NGCPLDKIJHH;

	public Texture2D DMEIDCPJFON;

	private bool KLKIPHOAEFE;

	private float GNPGGMIFCOD;

	public bool ECGHGHDDEPC;

	private GameObject[] AKKAFLANFMH;

	private bool INBLGLLAJEI;

	private bool HMLKGFKHBLL;

	public float MKOGACCGCPG = 2.5f;

	public float LNBAOJFOGDF = 20f;

	private bool MGHICKHNDNE;

	private bool OHEOLDDNBII;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_61(int HIJAMAKOEHA)
	{
		AAINDCKBOPH = true;
		MGHICKHNDNE = true;
		BDICHBPAKFJ = MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation;
		OLGIHBEIGND.Play(MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation);
		AnimationData animationData = OLGIHBEIGND.GetAnimationData(MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation);
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(animationData.length / animationData.speed / MLDOHNIDBJK[HIJAMAKOEHA].specialWaitDivide);
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("team1") : GameObject.FindGameObjectsWithTag("team2"));
		float num = 1000f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null)
		{
			base.transform.LookAt(transform.position);
			if (MLDOHNIDBJK[HIJAMAKOEHA].projectilePositionLookAt)
			{
				MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.LookAt(transform.position);
			}
			else
			{
				base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
			}
			Transform transform2 = UnityEngine.Object.Instantiate(MLDOHNIDBJK[HIJAMAKOEHA].projectile, MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.position, MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.rotation);
			transform2.SendMessage("SyncTeamName", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.DontRequireReceiver);
			MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.localEulerAngles = new Vector3(0f, 0f, 0f);
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
		}
		float num3 = 1f - 1f / MLDOHNIDBJK[HIJAMAKOEHA].specialWaitDivide;
		yield return new WaitForSeconds(animationData.length / animationData.speed * num3);
		BDICHBPAKFJ = "Idle";
		if (!OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade("Idle", 0.2f);
		}
		MGHICKHNDNE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_21()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	[PunRPC]
	private void DoDamage(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 0f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 0f)
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
			OLGIHBEIGND.gameObject.SetActive(true);
			OLGIHBEIGND.CrossFade("Death", 0.2f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 10f);
			if (base.photonView.isMine)
			{
				StartCoroutine(DestroyPlayer(0.2f));
			}
			HLPBCOGDPCF = 0f;
			OHEOLDDNBII = true;
			GameObject.Find("__Room").SendMessage("NPCDeath", SendMessageOptions.DontRequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_63()
	{
		HMLKGFKHBLL = true;
		if (LJLBGNFIOPI != null)
		{
			if (LAMGCFPPKDJ.enabled)
			{
				LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			}
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 1f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !AAINDCKBOPH)
			{
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				AnimationData animationData = OLGIHBEIGND.GetAnimationData("Attack");
				yield return new WaitForEndOfFrame();
				yield return new WaitForSeconds(animationData.length / animationData.speed / CAODOOBMGFN);
				base.photonView.RPC("Attack", PhotonTargets.All);
				float num = 1f - 1f / CAODOOBMGFN;
				yield return new WaitForSeconds(animationData.length / animationData.speed * num);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				if (UnityEngine.Random.Range(0, 5) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("Teleport", PhotonTargets.All, RandomNavSphere(base.transform.position, 35f, -1));
				}
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				BDICHBPAKFJ = "Run";
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				Quaternion rotation = MLDOHNIDBJK[JKEDBHDNPBO].projectilePosition.rotation;
				base.transform.LookAt(LJLBGNFIOPI.position);
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				if (!OHEOLDDNBII)
				{
					BDICHBPAKFJ = "Idle";
				}
				yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 1f));
				MGHICKHNDNE = true;
				base.photonView.RPC("SpecialAttack", PhotonTargets.All, JKEDBHDNPBO);
				while (MGHICKHNDNE)
				{
					yield return null;
				}
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
				FGBOJFAFMDF = 0f;
				ONKOIENLLFC = 0;
				AAINDCKBOPH = false;
				base.transform.rotation = rotation;
			}
		}
		HMLKGFKHBLL = false;
	}

	private IEnumerator FindTarget()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	public void ForceDamage(float LNBAOJFOGDF)
	{
		base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF * (float)HEAKJAPBDGE, PhotonNetwork.player, string.Empty);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1528f, 12f, 846f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 1366f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 1700f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 1) / 1638f;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_43(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	public static Vector3 __BB_OBFUSCATOR_30(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	public void __BB_OBFUSCATOR_56(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[0] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[0] = PhotonNetwork.player;
		array[0] = string.Empty;
		obj.RPC("_Value", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_35());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_12()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private void __BB_OBFUSCATOR_14(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 1003f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 230f)
		{
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
			OLGIHBEIGND.gameObject.SetActive(true);
			OLGIHBEIGND.CrossFade("mouse y", 1762f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 1207f);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_23(1121f));
			}
			HLPBCOGDPCF = 47f;
			OHEOLDDNBII = true;
			GameObject.Find("_Value").SendMessage("_Value3", SendMessageOptions.DontRequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_12());
		}
	}

	private int __BB_OBFUSCATOR_16(string BOAIGNKFAOM)
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

	public void TotalDamage(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player, OHJBLLKDFHO);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_46()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
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

	private IEnumerator __BB_OBFUSCATOR_65()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_47(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 742f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 1310f)
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
			OLGIHBEIGND.gameObject.SetActive(false);
			OLGIHBEIGND.CrossFade("Quality", 279f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 1053f);
			if (base.photonView.isMine)
			{
				StartCoroutine(DestroyPlayer(1679f));
			}
			HLPBCOGDPCF = 961f;
			OHEOLDDNBII = false;
			GameObject.Find("CameraFilterPack/Colors_DarkColor").SendMessage("_VelTex", SendMessageOptions.RequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_32());
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("tintColor").tag = ": ";
		}
		else
		{
			base.transform.Find("\\Google").tag = "_Value3";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 485f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 672f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_65());
			}
			FGBOJFAFMDF += 1250f * Time.deltaTime;
			if (FGBOJFAFMDF > 198f && !AAINDCKBOPH && !KJBHNCFBOOI)
			{
				int num = UnityEngine.Random.Range(1, 7);
				if (num < 0)
				{
					ONKOIENLLFC = num;
				}
				if (base.photonView.isMine)
				{
					JKEDBHDNPBO = UnityEngine.Random.Range(1, MLDOHNIDBJK.Count);
				}
				if (UnityEngine.Random.Range(1, 1) == 0 && LJLBGNFIOPI != null)
				{
					PhotonView obj = base.photonView;
					object[] array = new object[0];
					array[1] = __BB_OBFUSCATOR_30(base.transform.position, 1464f, -1);
					obj.RPC("_TintColor", PhotonTargets.Others, array);
				}
				FGBOJFAFMDF = 134f;
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_27());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 240f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 416f)
				{
					LAMGCFPPKDJ.speed = 1428f;
				}
			}
			if (INBLGLLAJEI || AAINDCKBOPH)
			{
				if (!AAINDCKBOPH)
				{
					BDICHBPAKFJ = CICFKJNBDED;
				}
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else if (!AAINDCKBOPH)
			{
				BDICHBPAKFJ = "_BlurArea";
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_48(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ) && !OHEOLDDNBII && !MGHICKHNDNE)
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 1251f);
		}
		if (OHEOLDDNBII && OLGIHBEIGND.GetCurrentClipName() != "_NumberOfWaves")
		{
			OLGIHBEIGND.CrossFade("Jump", 1096f);
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "MP";
			DBJLMBHEMDG = PKMGBJGABJK;
			AAINDCKBOPH = true;
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "_SpherePositionY";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		if (ONKOIENLLFC == 3 || ONKOIENLLFC == 3)
		{
			CMCAILIEJLA = "offsets";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = false;
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	public static Vector3 __BB_OBFUSCATOR_13(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	public void __BB_OBFUSCATOR_10(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[0] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[1] = PhotonNetwork.player;
		array[7] = string.Empty;
		obj.RPC("Prone", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_32());
		}
	}

	private int __BB_OBFUSCATOR_52(string BOAIGNKFAOM)
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

	private IEnumerator __BB_OBFUSCATOR_24()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private int __BB_OBFUSCATOR_48(string BOAIGNKFAOM)
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

	private IEnumerator __BB_OBFUSCATOR_18()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private IEnumerator __BB_OBFUSCATOR_29()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("_Value").tag = "_CutTex";
		}
		else
		{
			base.transform.Find("Idle").tag = "_ScreenResolution";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 722f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 865f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_64());
			}
			FGBOJFAFMDF += 1309f * Time.deltaTime;
			if (FGBOJFAFMDF > 1957f && !AAINDCKBOPH && !KJBHNCFBOOI)
			{
				int num = UnityEngine.Random.Range(0, 6);
				if (num < 0)
				{
					ONKOIENLLFC = num;
				}
				if (base.photonView.isMine)
				{
					JKEDBHDNPBO = UnityEngine.Random.Range(0, MLDOHNIDBJK.Count);
				}
				if (UnityEngine.Random.Range(0, 5) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("i", PhotonTargets.Others, RandomNavSphere(base.transform.position, 1192f, -1));
				}
				FGBOJFAFMDF = 1660f;
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 1569f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 812f)
				{
					LAMGCFPPKDJ.speed = 1722f;
				}
			}
			if (INBLGLLAJEI || AAINDCKBOPH)
			{
				if (!AAINDCKBOPH)
				{
					BDICHBPAKFJ = CICFKJNBDED;
				}
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else if (!AAINDCKBOPH)
			{
				BDICHBPAKFJ = "8";
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_31(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ) && !OHEOLDDNBII && !MGHICKHNDNE)
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 141f);
		}
		if (OHEOLDDNBII && OLGIHBEIGND.GetCurrentClipName() != "Buy")
		{
			OLGIHBEIGND.CrossFade("0", 339f);
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "MapName";
			DBJLMBHEMDG = PKMGBJGABJK;
			AAINDCKBOPH = false;
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "CameraFilterPack/Distortion_BigFace";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		if (ONKOIENLLFC == 5 || ONKOIENLLFC == 2)
		{
			CMCAILIEJLA = "_Green_G";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_20(int CLDLINNFAGA)
	{
		if (!base.photonView.isMine)
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		else
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		StartCoroutine(SpecialAttackSequence(CLDLINNFAGA));
	}

	private void __BB_OBFUSCATOR_15(Vector3 PHMGAIIINKJ)
	{
		ACGPKNCKBJE.gameObject.SetActive(false);
		Transform transform = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform.gameObject.SetActive(true);
		UnityEngine.Object.Destroy(transform.gameObject, 1098f);
		base.transform.position = PHMGAIIINKJ;
		Transform transform2 = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform2.gameObject.SetActive(true);
		UnityEngine.Object.Destroy(transform2.gameObject, 67f);
	}

	public void __BB_OBFUSCATOR_55(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[8];
		array[1] = LNBAOJFOGDF;
		array[1] = PhotonNetwork.player;
		array[0] = OHJBLLKDFHO;
		obj.RPC(">", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	private IEnumerator SpecialAttackSequence(int HIJAMAKOEHA)
	{
		AAINDCKBOPH = true;
		MGHICKHNDNE = true;
		BDICHBPAKFJ = MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation;
		OLGIHBEIGND.Play(MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation);
		AnimationData animationData = OLGIHBEIGND.GetAnimationData(MLDOHNIDBJK[HIJAMAKOEHA].specialAnimation);
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(animationData.length / animationData.speed / MLDOHNIDBJK[HIJAMAKOEHA].specialWaitDivide);
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("team1") : GameObject.FindGameObjectsWithTag("team2"));
		float num = 1000f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null)
		{
			base.transform.LookAt(transform.position);
			if (MLDOHNIDBJK[HIJAMAKOEHA].projectilePositionLookAt)
			{
				MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.LookAt(transform.position);
			}
			else
			{
				base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
			}
			Transform transform2 = UnityEngine.Object.Instantiate(MLDOHNIDBJK[HIJAMAKOEHA].projectile, MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.position, MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.rotation);
			transform2.SendMessage("SyncTeamName", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.DontRequireReceiver);
			MLDOHNIDBJK[HIJAMAKOEHA].projectilePosition.localEulerAngles = new Vector3(0f, 0f, 0f);
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
		}
		float num3 = 1f - 1f / MLDOHNIDBJK[HIJAMAKOEHA].specialWaitDivide;
		yield return new WaitForSeconds(animationData.length / animationData.speed * num3);
		BDICHBPAKFJ = "Idle";
		if (!OHEOLDDNBII)
		{
			OLGIHBEIGND.CrossFade("Idle", 0.2f);
		}
		MGHICKHNDNE = false;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("HeadlessBeforeSceneLoad").tag = "_BumpMap";
		}
		else
		{
			base.transform.Find("_ScreenResolution").tag = "_MinVelocity";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1700f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 806f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_29());
			}
			FGBOJFAFMDF += 1729f * Time.deltaTime;
			if (FGBOJFAFMDF > 622f && !AAINDCKBOPH && !KJBHNCFBOOI)
			{
				int num = UnityEngine.Random.Range(1, 0);
				if (num < 3)
				{
					ONKOIENLLFC = num;
				}
				if (base.photonView.isMine)
				{
					JKEDBHDNPBO = UnityEngine.Random.Range(0, MLDOHNIDBJK.Count);
				}
				if (UnityEngine.Random.Range(0, 7) == 0 && LJLBGNFIOPI != null)
				{
					PhotonView obj = base.photonView;
					object[] array = new object[0];
					array[1] = __BB_OBFUSCATOR_13(base.transform.position, 73f, -1);
					obj.RPC("open", PhotonTargets.Others, array);
				}
				FGBOJFAFMDF = 13f;
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 942f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 1754f)
				{
					LAMGCFPPKDJ.speed = 1333f;
				}
			}
			if (INBLGLLAJEI || AAINDCKBOPH)
			{
				if (!AAINDCKBOPH)
				{
					BDICHBPAKFJ = CICFKJNBDED;
				}
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else if (!AAINDCKBOPH)
			{
				BDICHBPAKFJ = "_Value";
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_17(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ) && !OHEOLDDNBII && !MGHICKHNDNE)
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 459f);
		}
		if (OHEOLDDNBII && OLGIHBEIGND.GetCurrentClipName() != "PlayerType'")
		{
			OLGIHBEIGND.CrossFade("_Value2", 1785f);
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "_ColorBuffer";
			DBJLMBHEMDG = PKMGBJGABJK;
			AAINDCKBOPH = false;
		}
		if (ONKOIENLLFC == 1)
		{
			CMCAILIEJLA = "networkAddMessage";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = false;
		}
		if (ONKOIENLLFC == 7 || ONKOIENLLFC == 3)
		{
			CMCAILIEJLA = "_Darkness";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private IEnumerator __BB_OBFUSCATOR_64()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		HMLKGFKHBLL = true;
		if (LJLBGNFIOPI != null)
		{
			if (LAMGCFPPKDJ.enabled)
			{
				LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			}
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 1f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !AAINDCKBOPH)
			{
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				AnimationData animationData = OLGIHBEIGND.GetAnimationData("Attack");
				yield return new WaitForEndOfFrame();
				yield return new WaitForSeconds(animationData.length / animationData.speed / CAODOOBMGFN);
				base.photonView.RPC("Attack", PhotonTargets.All);
				float num = 1f - 1f / CAODOOBMGFN;
				yield return new WaitForSeconds(animationData.length / animationData.speed * num);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				if (UnityEngine.Random.Range(0, 5) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("Teleport", PhotonTargets.All, RandomNavSphere(base.transform.position, 35f, -1));
				}
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				BDICHBPAKFJ = "Run";
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				Quaternion rotation = MLDOHNIDBJK[JKEDBHDNPBO].projectilePosition.rotation;
				base.transform.LookAt(LJLBGNFIOPI.position);
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				if (!OHEOLDDNBII)
				{
					BDICHBPAKFJ = "Idle";
				}
				yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 1f));
				MGHICKHNDNE = true;
				base.photonView.RPC("SpecialAttack", PhotonTargets.All, JKEDBHDNPBO);
				while (MGHICKHNDNE)
				{
					yield return null;
				}
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
				FGBOJFAFMDF = 0f;
				ONKOIENLLFC = 0;
				AAINDCKBOPH = false;
				base.transform.rotation = rotation;
			}
		}
		HMLKGFKHBLL = false;
	}

	[PunRPC]
	private void Attack()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("team1") : GameObject.FindGameObjectsWithTag("team2"));
		float num = MKOGACCGCPG * 1.5f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine && !OHEOLDDNBII)
		{
			if (transform.parent.GetComponent<PlayerDamage>() != null)
			{
				transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
			}
			else
			{
				transform.SendMessageUpwards("ForceDamage", LNBAOJFOGDF, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_32()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private void Update()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("TeamTag").tag = "team1";
		}
		else
		{
			base.transform.Find("TeamTag").tag = "team2";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 8f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 8f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(FindTarget());
			}
			FGBOJFAFMDF += 1f * Time.deltaTime;
			if (FGBOJFAFMDF > 6f && !AAINDCKBOPH && !KJBHNCFBOOI)
			{
				int num = UnityEngine.Random.Range(0, 4);
				if (num < 4)
				{
					ONKOIENLLFC = num;
				}
				if (base.photonView.isMine)
				{
					JKEDBHDNPBO = UnityEngine.Random.Range(0, MLDOHNIDBJK.Count);
				}
				if (UnityEngine.Random.Range(0, 3) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("Teleport", PhotonTargets.All, RandomNavSphere(base.transform.position, 35f, -1));
				}
				FGBOJFAFMDF = 0f;
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 6f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 60f)
				{
					LAMGCFPPKDJ.speed = 50f;
				}
			}
			if (INBLGLLAJEI || AAINDCKBOPH)
			{
				if (!AAINDCKBOPH)
				{
					BDICHBPAKFJ = CICFKJNBDED;
				}
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else if (!AAINDCKBOPH)
			{
				BDICHBPAKFJ = "Idle";
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = GetAnimationID(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ) && !OHEOLDDNBII && !MGHICKHNDNE)
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 0.2f);
		}
		if (OHEOLDDNBII && OLGIHBEIGND.GetCurrentClipName() != "Death")
		{
			OLGIHBEIGND.CrossFade("Death", 0.2f);
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "Walk";
			DBJLMBHEMDG = PKMGBJGABJK;
			AAINDCKBOPH = false;
		}
		if (ONKOIENLLFC == 1)
		{
			CMCAILIEJLA = "Run";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = false;
		}
		if (ONKOIENLLFC == 2 || ONKOIENLLFC == 3)
		{
			CMCAILIEJLA = "Run";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_49()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1889f, 213f, 1336f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 332f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 1042f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 0) / 1808f;
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("Horizontal").tag = "CameraFilterPack/Edge_Golden";
			}
			else
			{
				base.transform.Find("Resume").tag = "_TimeX";
			}
			base.gameObject.name = "MP";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("SendPrivateMessage called while not connected to front end server.");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(938f, 1004f, 889f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
		if (PhotonNetwork.room.customProperties["Picked ammo for | "] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["_Speed"];
			if (num == 0)
			{
				HEAKJAPBDGE = 4;
			}
			if (num == 0)
			{
				HEAKJAPBDGE = 6;
			}
			if (num == 3)
			{
				HEAKJAPBDGE = 6;
			}
		}
	}

	[PunRPC]
	private void SpecialAttack(int CLDLINNFAGA)
	{
		if (!base.photonView.isMine)
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		else
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		StartCoroutine(SpecialAttackSequence(CLDLINNFAGA));
	}

	public void __BB_OBFUSCATOR_45(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[4];
		array[1] = LNBAOJFOGDF;
		array[1] = PhotonNetwork.player;
		array[8] = OHJBLLKDFHO;
		obj.RPC("Change rain strength", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_35());
		}
	}

	private void __BB_OBFUSCATOR_6(int CLDLINNFAGA)
	{
		if (!base.photonView.isMine)
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		else
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		StartCoroutine(SpecialAttackSequence(CLDLINNFAGA));
	}

	private IEnumerator __BB_OBFUSCATOR_58()
	{
		HMLKGFKHBLL = true;
		if (LJLBGNFIOPI != null)
		{
			if (LAMGCFPPKDJ.enabled)
			{
				LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			}
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 1f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !AAINDCKBOPH)
			{
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				AnimationData animationData = OLGIHBEIGND.GetAnimationData("Attack");
				yield return new WaitForEndOfFrame();
				yield return new WaitForSeconds(animationData.length / animationData.speed / CAODOOBMGFN);
				base.photonView.RPC("Attack", PhotonTargets.All);
				float num = 1f - 1f / CAODOOBMGFN;
				yield return new WaitForSeconds(animationData.length / animationData.speed * num);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				if (UnityEngine.Random.Range(0, 5) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("Teleport", PhotonTargets.All, RandomNavSphere(base.transform.position, 35f, -1));
				}
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				BDICHBPAKFJ = "Run";
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				Quaternion rotation = MLDOHNIDBJK[JKEDBHDNPBO].projectilePosition.rotation;
				base.transform.LookAt(LJLBGNFIOPI.position);
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				if (!OHEOLDDNBII)
				{
					BDICHBPAKFJ = "Idle";
				}
				yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 1f));
				MGHICKHNDNE = true;
				base.photonView.RPC("SpecialAttack", PhotonTargets.All, JKEDBHDNPBO);
				while (MGHICKHNDNE)
				{
					yield return null;
				}
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
				FGBOJFAFMDF = 0f;
				ONKOIENLLFC = 0;
				AAINDCKBOPH = false;
				base.transform.rotation = rotation;
			}
		}
		HMLKGFKHBLL = false;
	}

	private IEnumerator AttackTarget()
	{
		HMLKGFKHBLL = true;
		if (LJLBGNFIOPI != null)
		{
			if (LAMGCFPPKDJ.enabled)
			{
				LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			}
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 1f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !AAINDCKBOPH)
			{
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				AnimationData animationData = OLGIHBEIGND.GetAnimationData("Attack");
				yield return new WaitForEndOfFrame();
				yield return new WaitForSeconds(animationData.length / animationData.speed / CAODOOBMGFN);
				base.photonView.RPC("Attack", PhotonTargets.All);
				float num = 1f - 1f / CAODOOBMGFN;
				yield return new WaitForSeconds(animationData.length / animationData.speed * num);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				if (UnityEngine.Random.Range(0, 5) == 0 && LJLBGNFIOPI != null)
				{
					base.photonView.RPC("Teleport", PhotonTargets.All, RandomNavSphere(base.transform.position, 35f, -1));
				}
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				BDICHBPAKFJ = "Run";
			}
			if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MLDOHNIDBJK[JKEDBHDNPBO].specialDistance && AAINDCKBOPH)
			{
				Quaternion rotation = MLDOHNIDBJK[JKEDBHDNPBO].projectilePosition.rotation;
				base.transform.LookAt(LJLBGNFIOPI.position);
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				if (!OHEOLDDNBII)
				{
					BDICHBPAKFJ = "Idle";
				}
				yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 1f));
				MGHICKHNDNE = true;
				base.photonView.RPC("SpecialAttack", PhotonTargets.All, JKEDBHDNPBO);
				while (MGHICKHNDNE)
				{
					yield return null;
				}
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
				FGBOJFAFMDF = 0f;
				ONKOIENLLFC = 0;
				AAINDCKBOPH = false;
				base.transform.rotation = rotation;
			}
		}
		HMLKGFKHBLL = false;
	}

	private IEnumerator ShowHPBar()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	public void __BB_OBFUSCATOR_34(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[2];
		array[1] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[1] = PhotonNetwork.player;
		array[0] = string.Empty;
		obj.RPC("Dirt", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("\"") : GameObject.FindGameObjectsWithTag("_AdaptionSpeed"));
		float num = MKOGACCGCPG * 1706f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i += 0)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine && !OHEOLDDNBII)
		{
			if (transform.parent.GetComponent<PlayerDamage>() != null)
			{
				transform.parent.GetComponent<PlayerDamage>().__BB_OBFUSCATOR_12(LNBAOJFOGDF, string.Empty);
			}
			else
			{
				transform.SendMessageUpwards("Particles/Additive", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void __BB_OBFUSCATOR_25(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 827f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 1331f)
		{
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
			OLGIHBEIGND.gameObject.SetActive(true);
			OLGIHBEIGND.CrossFade("_Value", 326f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 9f);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_43(1734f));
			}
			HLPBCOGDPCF = 1635f;
			OHEOLDDNBII = false;
			GameObject.Find("_Value2").SendMessage("_Value", SendMessageOptions.RequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_69());
		}
	}

	public static Vector3 __BB_OBFUSCATOR_0(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private void __BB_OBFUSCATOR_22()
	{
		Camera camera = null;
		if (Camera.main != null)
		{
			camera = Camera.main;
		}
		if (GameObject.FindGameObjectWithTag("*") != null)
		{
			camera = GameObject.FindGameObjectWithTag("_TimeX").GetComponent<Camera>();
		}
		if (KLKIPHOAEFE)
		{
			GNPGGMIFCOD = 1358f;
			if ((bool)camera)
			{
				Vector3 vector = camera.WorldToScreenPoint(base.transform.position);
				if (vector.z > 1299f)
				{
					float num = HLPBCOGDPCF / GFPDIKNCIKH * 438f;
					GUI.Box(new Rect(vector.x - 1067f, (float)Screen.height - vector.y + 623f - GNPGGMIFCOD, 1684f, 1900f), string.Empty);
					if (CEEGNIEBCGJ == 0)
					{
						GUI.color = Color.cyan;
					}
					else
					{
						GUI.color = Color.red;
					}
					GUI.DrawTexture(new Rect(vector.x - 730f, (float)Screen.height - vector.y + 1828f - GNPGGMIFCOD, num / 5f, 559f), DMEIDCPJFON, ScaleMode.StretchToFill);
				}
			}
		}
		GUI.depth = 0;
		GNPGGMIFCOD = 1945f;
		GUI.color = new Color(483f, 408f, 180f, 591f);
		if ((bool)camera)
		{
			Vector3 vector2 = camera.WorldToScreenPoint(base.transform.position + Vector3.up * 1388f);
			GNPGGMIFCOD = 1004f;
			GUIStyle style = GUI.skin.GetStyle("Particles/Additive");
			style.alignment = TextAnchor.MiddleRight;
			style.font = null;
			float num2 = Screen.height / 0;
			string text = "Main Menu";
			if (CEEGNIEBCGJ == 0)
			{
				text = "colorC";
			}
			if (vector2.z > 1628f && Vector3.Distance(camera.transform.position, base.transform.position) > 1755f)
			{
				GUI.Label(new Rect(vector2.x - 1793f, (float)Screen.height - vector2.y - 1082f - GNPGGMIFCOD, 937f, 1261f), "_ScreenResolution" + text + "_Value2", style);
			}
		}
	}

	private void OnGUI()
	{
		Camera camera = null;
		if (Camera.main != null)
		{
			camera = Camera.main;
		}
		if (GameObject.FindGameObjectWithTag("FlyCam") != null)
		{
			camera = GameObject.FindGameObjectWithTag("FlyCam").GetComponent<Camera>();
		}
		if (KLKIPHOAEFE)
		{
			GNPGGMIFCOD = 0f;
			if ((bool)camera)
			{
				Vector3 vector = camera.WorldToScreenPoint(base.transform.position);
				if (vector.z > 0f)
				{
					float num = HLPBCOGDPCF / GFPDIKNCIKH * 100f;
					GUI.Box(new Rect(vector.x - 25f, (float)Screen.height - vector.y + 25f - GNPGGMIFCOD, 50f, 5f), string.Empty);
					if (CEEGNIEBCGJ == 0)
					{
						GUI.color = Color.cyan;
					}
					else
					{
						GUI.color = Color.red;
					}
					GUI.DrawTexture(new Rect(vector.x - 25f, (float)Screen.height - vector.y + 25f - GNPGGMIFCOD, num / 2f, 5f), DMEIDCPJFON, ScaleMode.StretchToFill);
				}
			}
		}
		GUI.depth = 2;
		GNPGGMIFCOD = 0f;
		GUI.color = new Color(0.1f, 0.9f, 0.5f, 1f);
		if ((bool)camera)
		{
			Vector3 vector2 = camera.WorldToScreenPoint(base.transform.position + Vector3.up * 2f);
			GNPGGMIFCOD = 0f;
			GUIStyle style = GUI.skin.GetStyle("Label");
			style.alignment = TextAnchor.MiddleCenter;
			style.font = null;
			float num2 = Screen.height / 8;
			string text = "red";
			if (CEEGNIEBCGJ == 0)
			{
				text = "cyan";
			}
			if (vector2.z > 0f && Vector3.Distance(camera.transform.position, base.transform.position) > 35f)
			{
				GUI.Label(new Rect(vector2.x - 100f, (float)Screen.height - vector2.y - 5f - GNPGGMIFCOD, 200f, 30f), "<color=" + text + "><b>▼</b></color>", style);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_23(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private void __BB_OBFUSCATOR_38()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1538f, 1619f, 525f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 269f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 1035f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 0) / 1414f;
			}
		}
	}

	private IEnumerator DestroyPlayer(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("INF").tag = "SBX";
		}
		else
		{
			base.transform.Find("Map Name").tag = "Player";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1691f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 377f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(FindTarget());
			}
			FGBOJFAFMDF += 448f * Time.deltaTime;
			if (FGBOJFAFMDF > 1048f && !AAINDCKBOPH && !KJBHNCFBOOI)
			{
				int num = UnityEngine.Random.Range(1, 2);
				if (num < 3)
				{
					ONKOIENLLFC = num;
				}
				if (base.photonView.isMine)
				{
					JKEDBHDNPBO = UnityEngine.Random.Range(0, MLDOHNIDBJK.Count);
				}
				if (UnityEngine.Random.Range(1, 0) == 0 && LJLBGNFIOPI != null)
				{
					PhotonView obj = base.photonView;
					object[] array = new object[1];
					array[1] = RandomNavSphere(base.transform.position, 550f, -1);
					obj.RPC("ArmsURL", PhotonTargets.Others, array);
				}
				FGBOJFAFMDF = 1125f;
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 1053f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 62f)
				{
					LAMGCFPPKDJ.speed = 1022f;
				}
			}
			if (INBLGLLAJEI || AAINDCKBOPH)
			{
				if (!AAINDCKBOPH)
				{
					BDICHBPAKFJ = CICFKJNBDED;
				}
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else if (!AAINDCKBOPH)
			{
				BDICHBPAKFJ = "\\xAu4YW5QzfD2KQjV";
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_7(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ) && !OHEOLDDNBII && !MGHICKHNDNE)
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 1671f);
		}
		if (OHEOLDDNBII && OLGIHBEIGND.GetCurrentClipName() != "_ScreenResolution")
		{
			OLGIHBEIGND.CrossFade("_Value2", 1971f);
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "_Value3";
			DBJLMBHEMDG = PKMGBJGABJK;
			AAINDCKBOPH = true;
		}
		if (ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "_TimeX";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = true;
		}
		if (ONKOIENLLFC == 5 || ONKOIENLLFC == 0)
		{
			CMCAILIEJLA = "Try Again";
			DBJLMBHEMDG = OMFNNEEPNGN;
			AAINDCKBOPH = false;
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private int __BB_OBFUSCATOR_59(string BOAIGNKFAOM)
	{
		int result = 1;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i += 0)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_53()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1323f, 323f, 349f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 1114f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 1640f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 1) / 1021f;
			}
		}
	}

	private void __BB_OBFUSCATOR_42(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 589f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 885f)
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
			OLGIHBEIGND.gameObject.SetActive(false);
			OLGIHBEIGND.CrossFade("__MirrorReflection", 1961f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 1015f);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_43(262f));
			}
			HLPBCOGDPCF = 98f;
			OHEOLDDNBII = true;
			GameObject.Find("Knife").SendMessage(" Custards)", SendMessageOptions.DontRequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	public static Vector3 RandomNavSphere(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	public void __BB_OBFUSCATOR_54(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[2];
		array[1] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[4] = OHJBLLKDFHO;
		obj.RPC("Connecting to frontend ", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_12());
		}
	}

	private void Start()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("TeamTag").tag = "team1";
			}
			else
			{
				base.transform.Find("TeamTag").tag = "team2";
			}
			base.gameObject.name = "[BOT] Boss";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("Network");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(0f, -100f, 0f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
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

	[PunRPC]
	private void Teleport(Vector3 PHMGAIIINKJ)
	{
		ACGPKNCKBJE.gameObject.SetActive(false);
		Transform transform = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform.gameObject.SetActive(true);
		UnityEngine.Object.Destroy(transform.gameObject, 5f);
		base.transform.position = PHMGAIIINKJ;
		Transform transform2 = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform2.gameObject.SetActive(true);
		UnityEngine.Object.Destroy(transform2.gameObject, 5f);
	}

	private int __BB_OBFUSCATOR_17(string BOAIGNKFAOM)
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

	private void __BB_OBFUSCATOR_44(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(GFPDIKNCIKH);
			JAOOMHKNKEK.SendNext(HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(ONKOIENLLFC);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			GFPDIKNCIKH = (float)JAOOMHKNKEK.ReceiveNext();
			HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			ONKOIENLLFC = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_5()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_4(Vector3 PHMGAIIINKJ)
	{
		ACGPKNCKBJE.gameObject.SetActive(true);
		Transform transform = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform.gameObject.SetActive(false);
		UnityEngine.Object.Destroy(transform.gameObject, 1492f);
		base.transform.position = PHMGAIIINKJ;
		Transform transform2 = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform2.gameObject.SetActive(false);
		UnityEngine.Object.Destroy(transform2.gameObject, 65f);
	}

	private void __BB_OBFUSCATOR_50(int CLDLINNFAGA)
	{
		if (!base.photonView.isMine)
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		else
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		StartCoroutine(SpecialAttackSequence(CLDLINNFAGA));
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("_Green_G").tag = "_CutTex";
			}
			else
			{
				base.transform.Find("_Value2").tag = "_FgOverlap";
			}
			base.gameObject.name = "selectWeapon";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("Hue/Knob");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1450f, 1016f, 305f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
		if (PhotonNetwork.room.customProperties["custard"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["HeadURL"];
			if (num == 0)
			{
				HEAKJAPBDGE = 0;
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

	private int __BB_OBFUSCATOR_7(string BOAIGNKFAOM)
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

	public static Vector3 __BB_OBFUSCATOR_67(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private IEnumerator __BB_OBFUSCATOR_39(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private IEnumerator __BB_OBFUSCATOR_57()
	{
		ECGHGHDDEPC = true;
		if (CEEGNIEBCGJ == 0)
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team2");
		}
		else
		{
			AKKAFLANFMH = GameObject.FindGameObjectsWithTag("team1");
		}
		float num = 10000f;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_26(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 1685f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 698f)
		{
			for (int i = 1; i < base.transform.childCount; i++)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
			OLGIHBEIGND.gameObject.SetActive(true);
			OLGIHBEIGND.CrossFade("Language", 193f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 861f);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_43(1705f));
			}
			HLPBCOGDPCF = 621f;
			OHEOLDDNBII = true;
			GameObject.Find("MP").SendMessage("_Blue_C", SendMessageOptions.RequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_35());
		}
	}

	private int __BB_OBFUSCATOR_31(string BOAIGNKFAOM)
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

	private void Awake()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(0f, -100f, 0f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 1.25f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 2f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 1) / 1.25f;
			}
		}
	}

	private void __BB_OBFUSCATOR_11(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 319f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 648f)
		{
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
			OLGIHBEIGND.gameObject.SetActive(false);
			OLGIHBEIGND.CrossFade(" <>__TranspIdent0 = ", 1437f);
			OLGIHBEIGND.transform.parent = null;
			UnityEngine.Object.Destroy(OLGIHBEIGND.gameObject, 280f);
			if (base.photonView.isMine)
			{
				StartCoroutine(DestroyPlayer(924f));
			}
			HLPBCOGDPCF = 105f;
			OHEOLDDNBII = false;
			GameObject.Find("SoftBody").SendMessage("Difficulty", SendMessageOptions.DontRequireReceiver);
		}
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_32());
		}
	}

	public void __BB_OBFUSCATOR_41(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[1];
		array[0] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[5] = OHJBLLKDFHO;
		obj.RPC("DoDamage", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_69());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_69()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private int __BB_OBFUSCATOR_60(string BOAIGNKFAOM)
	{
		int result = 1;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i++)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_62(int CLDLINNFAGA)
	{
		if (!base.photonView.isMine)
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		else
		{
			JKEDBHDNPBO = CLDLINNFAGA;
		}
		StartCoroutine(SpecialAttackSequence(CLDLINNFAGA));
	}

	public void __BB_OBFUSCATOR_33(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[4];
		array[0] = LNBAOJFOGDF;
		array[1] = PhotonNetwork.player;
		array[1] = OHJBLLKDFHO;
		obj.RPC("_BlurDistance", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	private void __BB_OBFUSCATOR_8(Vector3 PHMGAIIINKJ)
	{
		ACGPKNCKBJE.gameObject.SetActive(true);
		Transform transform = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform.gameObject.SetActive(true);
		UnityEngine.Object.Destroy(transform.gameObject, 173f);
		base.transform.position = PHMGAIIINKJ;
		Transform transform2 = UnityEngine.Object.Instantiate(ACGPKNCKBJE, ACGPKNCKBJE.position, ACGPKNCKBJE.rotation);
		transform2.gameObject.SetActive(false);
		UnityEngine.Object.Destroy(transform2.gameObject, 1387f);
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(GFPDIKNCIKH);
			JAOOMHKNKEK.SendNext(HLPBCOGDPCF);
			JAOOMHKNKEK.SendNext(ONKOIENLLFC);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			GFPDIKNCIKH = (float)JAOOMHKNKEK.ReceiveNext();
			HLPBCOGDPCF = (float)JAOOMHKNKEK.ReceiveNext();
			ONKOIENLLFC = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		IOJKGIIGCKJ = CICFKJNBDED;
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(449f, 1505f, 1685f))
		{
			base.transform.position = DLPNGACNGPB;
		}
		if (base.photonView.isMine)
		{
			if (PhotonNetwork.offlineMode)
			{
				GFPDIKNCIKH *= (float)PhotonNetwork.playerList.Length / 143f;
				GFPDIKNCIKH = (int)(GFPDIKNCIKH * 396f);
			}
			else
			{
				GFPDIKNCIKH *= (float)(PhotonNetwork.playerList.Length + 1) / 1478f;
			}
		}
	}
}
