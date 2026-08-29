using System.Collections;
using Photon;
using UnityEngine;
using UnityEngine.AI;

public class Bot : Photon.MonoBehaviour
{
	public string HKEPPNAHBOG;

	public string[] EAKDACOPPLJ;

	public int CEEGNIEBCGJ = 1;

	public float GFPDIKNCIKH = 100f;

	[HideInInspector]
	public float HLPBCOGDPCF = 100f;

	public Transform LJLBGNFIOPI;

	public MecanimControl OLGIHBEIGND;

	public string BDICHBPAKFJ;

	public Transform NHDPIMJDMMN;

	public float CAODOOBMGFN = 2f;

	private GameObject MCDJLOECKJI;

	private RoomMultiplayerMenu OGKPPJHGFHD;

	private NavMeshAgent LAMGCFPPKDJ;

	private bool KJBHNCFBOOI;

	public float DBJLMBHEMDG = 3.5f;

	public bool MLKOIGJBGOD;

	public Transform OLMLANGKNML;

	public Transform KNJMPECEBCI;

	public string CICFKJNBDED = "Attack";

	public string CMCAILIEJLA = "Walk";

	public int NAOGNHFIKJI;

	private int HEAKJAPBDGE = 1;

	public bool CGOIJCJGOCK;

	private Vector3 DOBLAMKENII;

	private float NGCPLDKIJHH;

	public Texture2D DMEIDCPJFON;

	private bool KLKIPHOAEFE;

	public float JGMGOJPEKEK = 1000f;

	public bool ECGHGHDDEPC;

	private GameObject[] AKKAFLANFMH;

	private bool INBLGLLAJEI;

	private bool HMLKGFKHBLL;

	public float MKOGACCGCPG = 2.5f;

	public float LNBAOJFOGDF = 20f;

	private bool OHEOLDDNBII;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private void __BB_OBFUSCATOR_61()
	{
		if (!KLKIPHOAEFE)
		{
			return;
		}
		float num = 760f;
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(base.transform.position);
		if (vector.z > 946f)
		{
			float num2 = HLPBCOGDPCF / GFPDIKNCIKH * 1383f;
			GUI.Box(new Rect(vector.x - 414f, (float)Screen.height - vector.y + 566f - num, 1088f, 1259f), string.Empty);
			if (CEEGNIEBCGJ == 0)
			{
				GUI.color = Color.cyan;
			}
			else
			{
				GUI.color = Color.red;
			}
			GUI.DrawTexture(new Rect(vector.x - 772f, (float)Screen.height - vector.y + 1965f - num, num2 / 261f, 1718f), DMEIDCPJFON, ScaleMode.StretchToFill);
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag(",") : GameObject.FindGameObjectsWithTag("_TimeX"));
		float num = MKOGACCGCPG * 1536f;
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
				transform.SendMessageUpwards("_TimeX", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private int __BB_OBFUSCATOR_46(string BOAIGNKFAOM)
	{
		int result = 0;
		for (int i = 0; i < OLGIHBEIGND.BPPMKPKDLOA.Length; i += 0)
		{
			if (OLGIHBEIGND.BPPMKPKDLOA[i].clipName == BOAIGNKFAOM)
			{
				result = i;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_11()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1116f, 1581f, 666f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(63f, 28f, 1144f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("-Length: ").tag = "_MainTex2";
			}
			else
			{
				base.transform.Find("_TimeX").tag = "Right Stick Right";
			}
			base.gameObject.name = "Kills";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("Run");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1060f, 955f, 87f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
		if (PhotonNetwork.room.customProperties["_NoiseTex"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["_AccumOrig"];
			if (num == 0)
			{
				HEAKJAPBDGE = 1;
			}
			if (num == 5)
			{
				HEAKJAPBDGE = 1;
			}
			if (num == 6)
			{
				HEAKJAPBDGE = 8;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_21(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private IEnumerator __BB_OBFUSCATOR_64(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private void __BB_OBFUSCATOR_26()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("Timer") : GameObject.FindGameObjectsWithTag("CameraFilterPack/EyesVision_2"));
		float num = MKOGACCGCPG * 1838f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i += 0)
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
				transform.SendMessageUpwards("CameraFilterPack/Blend2Camera_LinearBurn", LNBAOJFOGDF, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		if (!(LJLBGNFIOPI != null))
		{
			yield break;
		}
		HMLKGFKHBLL = true;
		if (LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
		}
		LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
		if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !MLKOIGJBGOD)
		{
			LAMGCFPPKDJ.ResetPath();
			KJBHNCFBOOI = true;
			INBLGLLAJEI = true;
			yield return new WaitForSeconds(Random.Range(0.1f, 1f));
			base.photonView.RPC("Attack", PhotonTargets.All);
			yield return new WaitForSeconds(CAODOOBMGFN);
			INBLGLLAJEI = false;
			KJBHNCFBOOI = false;
		}
		if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && MLKOIGJBGOD)
		{
			Quaternion rotation = KNJMPECEBCI.rotation;
			base.transform.LookAt(LJLBGNFIOPI.position);
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up, base.transform.forward, out hitInfo, MKOGACCGCPG) && (hitInfo.transform.gameObject.layer == 11 || CEEGNIEBCGJ == 0 || (CEEGNIEBCGJ == 1 && hitInfo.transform.parent != null && hitInfo.transform.parent.Find("TeamTag") != null && hitInfo.transform.parent.Find("TeamTag").tag == "team1")))
			{
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				yield return new WaitForSeconds(Random.Range(0.1f, 1f));
				base.photonView.RPC("RangedAttack", PhotonTargets.All);
				yield return new WaitForSeconds(CAODOOBMGFN);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
			}
			base.transform.rotation = rotation;
		}
		HMLKGFKHBLL = false;
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("_ScreenResolution").tag = "PrimaryCausticsProjector";
			}
			else
			{
				base.transform.Find("LegsURL").tag = "_ScreenResolution";
			}
			base.gameObject.name = "Label";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("CameraFilterPack/FX_Drunk");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1647f, 1078f, 1617f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
		if (PhotonNetwork.room.customProperties["AddFriends can't be called for empty or null list."] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["_Distortion"];
			if (num == 0)
			{
				HEAKJAPBDGE = 3;
			}
			if (num == 8)
			{
				HEAKJAPBDGE = 1;
			}
			if (num == 4)
			{
				HEAKJAPBDGE = 2;
			}
		}
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
			if (INBLGLLAJEI)
			{
				BDICHBPAKFJ = CICFKJNBDED;
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else
			{
				BDICHBPAKFJ = "Idle";
			}
			if (base.transform.position == DOBLAMKENII)
			{
				NGCPLDKIJHH += 1f * Time.deltaTime;
				if (NGCPLDKIJHH > 30f && !OHEOLDDNBII)
				{
					TotalDamage(3000f, string.Empty);
				}
			}
			else
			{
				DOBLAMKENII = base.transform.position;
				NGCPLDKIJHH = 0f;
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = GetAnimationID(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 0.2f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_40()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1164f, 1904f, 748f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("_Value4") : GameObject.FindGameObjectsWithTag("_TimeX"));
		float num = MKOGACCGCPG * 1830f;
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
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("_Value", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.DontRequireReceiver);
			base.transform.localEulerAngles = new Vector3(903f, base.transform.localEulerAngles.y, 686f);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_45(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private void __BB_OBFUSCATOR_51(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 403f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 1119f)
		{
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				base.transform.GetChild(i).gameObject.SetActive(false);
			}
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_0(741f));
			}
			HLPBCOGDPCF = 1849f;
			OHEOLDDNBII = true;
			GameObject.Find("OffScreenIndicator Canvas field requieres a Canvas GameObject").SendMessage("|", SendMessageOptions.RequireReceiver);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_24()
	{
		if (!(LJLBGNFIOPI != null))
		{
			yield break;
		}
		HMLKGFKHBLL = true;
		if (LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
		}
		LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
		if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !MLKOIGJBGOD)
		{
			LAMGCFPPKDJ.ResetPath();
			KJBHNCFBOOI = true;
			INBLGLLAJEI = true;
			yield return new WaitForSeconds(Random.Range(0.1f, 1f));
			base.photonView.RPC("Attack", PhotonTargets.All);
			yield return new WaitForSeconds(CAODOOBMGFN);
			INBLGLLAJEI = false;
			KJBHNCFBOOI = false;
		}
		if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && MLKOIGJBGOD)
		{
			Quaternion rotation = KNJMPECEBCI.rotation;
			base.transform.LookAt(LJLBGNFIOPI.position);
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up, base.transform.forward, out hitInfo, MKOGACCGCPG) && (hitInfo.transform.gameObject.layer == 11 || CEEGNIEBCGJ == 0 || (CEEGNIEBCGJ == 1 && hitInfo.transform.parent != null && hitInfo.transform.parent.Find("TeamTag") != null && hitInfo.transform.parent.Find("TeamTag").tag == "team1")))
			{
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				yield return new WaitForSeconds(Random.Range(0.1f, 1f));
				base.photonView.RPC("RangedAttack", PhotonTargets.All);
				yield return new WaitForSeconds(CAODOOBMGFN);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
			}
			base.transform.rotation = rotation;
		}
		HMLKGFKHBLL = false;
	}

	private void __BB_OBFUSCATOR_5()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("Indicator ID not valid. Check Off Screen Indicator Indicators list.") : GameObject.FindGameObjectsWithTag("_BlurSize"));
		float num = MKOGACCGCPG * 1150f;
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
				transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
			}
			else
			{
				transform.SendMessageUpwards("_Value", LNBAOJFOGDF, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private int __BB_OBFUSCATOR_7(string BOAIGNKFAOM)
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

	private IEnumerator __BB_OBFUSCATOR_73()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
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

	private void __BB_OBFUSCATOR_18()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(355f, 934f, 3f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	public void __BB_OBFUSCATOR_56(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[0] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[1] = PhotonNetwork.player;
		array[7] = string.Empty;
		obj.RPC("ZWName'", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("_Green_C").tag = "ns.exitgames.com";
			}
			else
			{
				base.transform.Find("OnLadder").tag = "__Room";
			}
			base.gameObject.name = "VS";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("INF");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1767f, 1846f, 1765f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
		if (PhotonNetwork.room.customProperties["Vertical"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["_Blood"];
			if (num == 0)
			{
				HEAKJAPBDGE = 3;
			}
			if (num == 7)
			{
				HEAKJAPBDGE = 7;
			}
			if (num == 4)
			{
				HEAKJAPBDGE = 4;
			}
		}
	}

	private int __BB_OBFUSCATOR_71(string BOAIGNKFAOM)
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

	private IEnumerator __BB_OBFUSCATOR_2()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_63()
	{
		if (!(LJLBGNFIOPI != null))
		{
			yield break;
		}
		HMLKGFKHBLL = true;
		if (LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
		}
		LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
		if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !MLKOIGJBGOD)
		{
			LAMGCFPPKDJ.ResetPath();
			KJBHNCFBOOI = true;
			INBLGLLAJEI = true;
			yield return new WaitForSeconds(Random.Range(0.1f, 1f));
			base.photonView.RPC("Attack", PhotonTargets.All);
			yield return new WaitForSeconds(CAODOOBMGFN);
			INBLGLLAJEI = false;
			KJBHNCFBOOI = false;
		}
		if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && MLKOIGJBGOD)
		{
			Quaternion rotation = KNJMPECEBCI.rotation;
			base.transform.LookAt(LJLBGNFIOPI.position);
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up, base.transform.forward, out hitInfo, MKOGACCGCPG) && (hitInfo.transform.gameObject.layer == 11 || CEEGNIEBCGJ == 0 || (CEEGNIEBCGJ == 1 && hitInfo.transform.parent != null && hitInfo.transform.parent.Find("TeamTag") != null && hitInfo.transform.parent.Find("TeamTag").tag == "team1")))
			{
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				yield return new WaitForSeconds(Random.Range(0.1f, 1f));
				base.photonView.RPC("RangedAttack", PhotonTargets.All);
				yield return new WaitForSeconds(CAODOOBMGFN);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
			}
			base.transform.rotation = rotation;
		}
		HMLKGFKHBLL = false;
	}

	private IEnumerator __BB_OBFUSCATOR_52()
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_22()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(553f, 1351f, 275f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("_ScreenResolution").tag = "_Dist";
		}
		else
		{
			base.transform.Find("ZWName'").tag = "_Value4";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1413f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1161f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_42());
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_66());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 1074f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 1003f)
				{
					LAMGCFPPKDJ.speed = 578f;
				}
			}
			if (INBLGLLAJEI)
			{
				BDICHBPAKFJ = CICFKJNBDED;
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else
			{
				BDICHBPAKFJ = "_ScreenResolution";
			}
			if (base.transform.position == DOBLAMKENII)
			{
				NGCPLDKIJHH += 483f * Time.deltaTime;
				if (NGCPLDKIJHH > 835f && !OHEOLDDNBII)
				{
					__BB_OBFUSCATOR_47(1961f, string.Empty);
				}
			}
			else
			{
				DOBLAMKENII = base.transform.position;
				NGCPLDKIJHH = 921f;
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_46(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 100f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_38(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_41()
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_16()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("VS") : GameObject.FindGameObjectsWithTag("Name"));
		float num = MKOGACCGCPG * 1160f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i += 0)
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
				transform.parent.GetComponent<PlayerDamage>().__BB_OBFUSCATOR_13(LNBAOJFOGDF, string.Empty);
			}
			else
			{
				transform.SendMessageUpwards("_NoiseAmount", LNBAOJFOGDF, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_6()
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	public void __BB_OBFUSCATOR_37(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[2];
		array[1] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[8] = string.Empty;
		obj.RPC("ServerID", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_73());
		}
	}

	private IEnumerator ShowHPBar()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	public void ForceDamage(float LNBAOJFOGDF)
	{
		base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF * (float)HEAKJAPBDGE, PhotonNetwork.player, string.Empty);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	public void __BB_OBFUSCATOR_67(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[6];
		array[1] = LNBAOJFOGDF;
		array[1] = PhotonNetwork.player;
		array[8] = string.Empty;
		obj.RPC("_TimeX", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_2());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private IEnumerator AttackTarget()
	{
		if (!(LJLBGNFIOPI != null))
		{
			yield break;
		}
		HMLKGFKHBLL = true;
		if (LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
		}
		LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
		if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !MLKOIGJBGOD)
		{
			LAMGCFPPKDJ.ResetPath();
			KJBHNCFBOOI = true;
			INBLGLLAJEI = true;
			yield return new WaitForSeconds(Random.Range(0.1f, 1f));
			base.photonView.RPC("Attack", PhotonTargets.All);
			yield return new WaitForSeconds(CAODOOBMGFN);
			INBLGLLAJEI = false;
			KJBHNCFBOOI = false;
		}
		if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && MLKOIGJBGOD)
		{
			Quaternion rotation = KNJMPECEBCI.rotation;
			base.transform.LookAt(LJLBGNFIOPI.position);
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up, base.transform.forward, out hitInfo, MKOGACCGCPG) && (hitInfo.transform.gameObject.layer == 11 || CEEGNIEBCGJ == 0 || (CEEGNIEBCGJ == 1 && hitInfo.transform.parent != null && hitInfo.transform.parent.Find("TeamTag") != null && hitInfo.transform.parent.Find("TeamTag").tag == "team1")))
			{
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				yield return new WaitForSeconds(Random.Range(0.1f, 1f));
				base.photonView.RPC("RangedAttack", PhotonTargets.All);
				yield return new WaitForSeconds(CAODOOBMGFN);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
			}
			base.transform.rotation = rotation;
		}
		HMLKGFKHBLL = false;
	}

	public void __BB_OBFUSCATOR_13(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[1] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[1] = PhotonNetwork.player;
		array[6] = string.Empty;
		obj.RPC("5", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_50());
		}
	}

	public void __BB_OBFUSCATOR_14(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[5];
		array[1] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[1] = PhotonNetwork.player;
		array[7] = string.Empty;
		obj.RPC("_Value2", PhotonTargets.All, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_50());
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("_Value").tag = "_BgFade";
		}
		else
		{
			base.transform.Find("\t\t\tMatrix: ").tag = "_Blue_B";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 105f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 416f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_41());
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_49());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 1132f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 152f)
				{
					LAMGCFPPKDJ.speed = 1664f;
				}
			}
			if (INBLGLLAJEI)
			{
				BDICHBPAKFJ = CICFKJNBDED;
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else
			{
				BDICHBPAKFJ = "Custards";
			}
			if (base.transform.position == DOBLAMKENII)
			{
				NGCPLDKIJHH += 1767f * Time.deltaTime;
				if (NGCPLDKIJHH > 1479f && !OHEOLDDNBII)
				{
					__BB_OBFUSCATOR_47(1168f, string.Empty);
				}
			}
			else
			{
				DOBLAMKENII = base.transform.position;
				NGCPLDKIJHH = 1739f;
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = __BB_OBFUSCATOR_46(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 1778f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (!KLKIPHOAEFE)
		{
			return;
		}
		float num = 936f;
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(base.transform.position);
		if (vector.z > 565f)
		{
			float num2 = HLPBCOGDPCF / GFPDIKNCIKH * 1701f;
			GUI.Box(new Rect(vector.x - 1661f, (float)Screen.height - vector.y + 147f - num, 1078f, 582f), string.Empty);
			if (CEEGNIEBCGJ == 0)
			{
				GUI.color = Color.cyan;
			}
			else
			{
				GUI.color = Color.red;
			}
			GUI.DrawTexture(new Rect(vector.x - 24f, (float)Screen.height - vector.y + 319f - num, num2 / 1366f, 225f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
		}
	}

	public void __BB_OBFUSCATOR_10(float LNBAOJFOGDF)
	{
		base.photonView.RPC("VHS2", PhotonTargets.All, LNBAOJFOGDF * (float)HEAKJAPBDGE, PhotonNetwork.player, string.Empty, null);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_68());
		}
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
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			if (base.photonView.isMine)
			{
				StartCoroutine(DestroyPlayer(0.2f));
			}
			HLPBCOGDPCF = 0f;
			OHEOLDDNBII = true;
			GameObject.Find("__Room").SendMessage("NPCDeath", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void Awake()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(0f, -100f, 0f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_36(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1351f, 989f, 878f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("-Vertical") : GameObject.FindGameObjectsWithTag("_TimeX"));
		float num = MKOGACCGCPG * 9f;
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
				transform.parent.GetComponent<PlayerDamage>().__BB_OBFUSCATOR_13(LNBAOJFOGDF, string.Empty);
			}
			else
			{
				transform.SendMessageUpwards("Map Name", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	public void __BB_OBFUSCATOR_25(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[7];
		array[0] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[4] = string.Empty;
		obj.RPC("_Vignette", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_23());
		}
	}

	private IEnumerator DestroyPlayer(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	private IEnumerator __BB_OBFUSCATOR_50()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private void __BB_OBFUSCATOR_32(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("_MainTex").tag = "Vertical";
			}
			else
			{
				base.transform.Find("State1").tag = "_TimeX";
			}
			base.gameObject.name = "_Intensity";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("_Value2");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1428f, 1440f, 372f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
		if (PhotonNetwork.room.customProperties["Wood"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["Pause Camera"];
			if (num == 1)
			{
				HEAKJAPBDGE = 2;
			}
			if (num == 2)
			{
				HEAKJAPBDGE = 0;
			}
			if (num == 0)
			{
				HEAKJAPBDGE = 5;
			}
		}
	}

	private void OnGUI()
	{
		if (!KLKIPHOAEFE)
		{
			return;
		}
		float num = 0f;
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(base.transform.position);
		if (vector.z > 0f)
		{
			float num2 = HLPBCOGDPCF / GFPDIKNCIKH * 100f;
			GUI.Box(new Rect(vector.x - 25f, (float)Screen.height - vector.y + 25f - num, 50f, 5f), string.Empty);
			if (CEEGNIEBCGJ == 0)
			{
				GUI.color = Color.cyan;
			}
			else
			{
				GUI.color = Color.red;
			}
			GUI.DrawTexture(new Rect(vector.x - 25f, (float)Screen.height - vector.y + 25f - num, num2 / 2f, 5f), DMEIDCPJFON, ScaleMode.StretchToFill);
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("Purchase/Text") : GameObject.FindGameObjectsWithTag("Horizontal"));
		float num = MKOGACCGCPG * 1414f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i++)
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
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("PrimaryCausticsProjector", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.RequireReceiver);
			base.transform.localEulerAngles = new Vector3(1822f, base.transform.localEulerAngles.y, 1240f);
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("_Value4") : GameObject.FindGameObjectsWithTag("</size>"));
		float num = MKOGACCGCPG * 246f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i++)
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
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("_TimeX", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.RequireReceiver);
			base.transform.localEulerAngles = new Vector3(408f, base.transform.localEulerAngles.y, 1147f);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("7") : GameObject.FindGameObjectsWithTag("CameraFilterPack/Blend2Camera_Lighten"));
		float num = MKOGACCGCPG * 185f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i += 0)
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
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("_MainTex", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.RequireReceiver);
			base.transform.localEulerAngles = new Vector3(1769f, base.transform.localEulerAngles.y, 1188f);
		}
	}

	public void TotalDamage(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player, OHJBLLKDFHO);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("8").tag = "MP";
			}
			else
			{
				base.transform.Find("SyncShopID").tag = "Difficulty";
			}
			base.gameObject.name = "_Distortion";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("CameraFilterPack/Blend2Camera_ColorDodge");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(569f, 321f, 36f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
		if (PhotonNetwork.room.customProperties["1"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties["CustomSkin"];
			if (num == 1)
			{
				HEAKJAPBDGE = 6;
			}
			if (num == 8)
			{
				HEAKJAPBDGE = 0;
			}
			if (num == 8)
			{
				HEAKJAPBDGE = 5;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_70(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
	}

	public void __BB_OBFUSCATOR_47(float LNBAOJFOGDF, string OHJBLLKDFHO)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[0];
		array[0] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[2] = OHJBLLKDFHO;
		obj.RPC("_ScreenResolution", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_42()
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private IEnumerator __BB_OBFUSCATOR_68()
	{
		KLKIPHOAEFE = true;
		yield return new WaitForSeconds(3f);
		KLKIPHOAEFE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_66()
	{
		if (!(LJLBGNFIOPI != null))
		{
			yield break;
		}
		HMLKGFKHBLL = true;
		if (LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
		}
		LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
		if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && !MLKOIGJBGOD)
		{
			LAMGCFPPKDJ.ResetPath();
			KJBHNCFBOOI = true;
			INBLGLLAJEI = true;
			yield return new WaitForSeconds(Random.Range(0.1f, 1f));
			base.photonView.RPC("Attack", PhotonTargets.All);
			yield return new WaitForSeconds(CAODOOBMGFN);
			INBLGLLAJEI = false;
			KJBHNCFBOOI = false;
		}
		if (LJLBGNFIOPI != null && Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) < MKOGACCGCPG && MLKOIGJBGOD)
		{
			Quaternion rotation = KNJMPECEBCI.rotation;
			base.transform.LookAt(LJLBGNFIOPI.position);
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up, base.transform.forward, out hitInfo, MKOGACCGCPG) && (hitInfo.transform.gameObject.layer == 11 || CEEGNIEBCGJ == 0 || (CEEGNIEBCGJ == 1 && hitInfo.transform.parent != null && hitInfo.transform.parent.Find("TeamTag") != null && hitInfo.transform.parent.Find("TeamTag").tag == "team1")))
			{
				base.transform.rotation = rotation;
				LAMGCFPPKDJ.ResetPath();
				KJBHNCFBOOI = true;
				INBLGLLAJEI = true;
				yield return new WaitForSeconds(Random.Range(0.1f, 1f));
				base.photonView.RPC("RangedAttack", PhotonTargets.All);
				yield return new WaitForSeconds(CAODOOBMGFN);
				INBLGLLAJEI = false;
				KJBHNCFBOOI = false;
				rotation = base.transform.rotation;
			}
			base.transform.rotation = rotation;
		}
		HMLKGFKHBLL = false;
	}

	public void __BB_OBFUSCATOR_12(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[3];
		array[0] = LNBAOJFOGDF;
		array[0] = PhotonNetwork.player;
		array[6] = string.Empty;
		obj.RPC("_Vignette_Alpha", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_68());
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
		if (CEEGNIEBCGJ == 0)
		{
			base.transform.Find("_Value4").tag = "controller3";
		}
		else
		{
			base.transform.Find("_Value3").tag = "\"OO\", \"Model::";
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1533f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1504f);
		}
		else
		{
			if (CGOIJCJGOCK)
			{
				return;
			}
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_9());
			}
			if (LJLBGNFIOPI != null)
			{
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_49());
				}
				if (KJBHNCFBOOI)
				{
					Vector3 position = LJLBGNFIOPI.position;
					position.y = base.transform.position.y;
					Quaternion b = Quaternion.LookRotation(position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, 1912f * Time.deltaTime);
				}
				LAMGCFPPKDJ.speed = DBJLMBHEMDG;
				if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) > 674f)
				{
					LAMGCFPPKDJ.speed = 1336f;
				}
			}
			if (INBLGLLAJEI)
			{
				BDICHBPAKFJ = CICFKJNBDED;
			}
			else if (LAMGCFPPKDJ.velocity != Vector3.zero)
			{
				BDICHBPAKFJ = CMCAILIEJLA;
			}
			else
			{
				BDICHBPAKFJ = ", ";
			}
			if (base.transform.position == DOBLAMKENII)
			{
				NGCPLDKIJHH += 1848f * Time.deltaTime;
				if (NGCPLDKIJHH > 1670f && !OHEOLDDNBII)
				{
					TotalDamage(666f, string.Empty);
				}
			}
			else
			{
				DOBLAMKENII = base.transform.position;
				NGCPLDKIJHH = 1304f;
			}
			if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
			{
				NAOGNHFIKJI = GetAnimationID(BDICHBPAKFJ);
			}
		}
		BDICHBPAKFJ = OLGIHBEIGND.BPPMKPKDLOA[NAOGNHFIKJI].clipName;
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 375f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_34(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void TotalDamage2(float LNBAOJFOGDF)
	{
		base.photonView.RPC("DoDamage", PhotonTargets.All, LNBAOJFOGDF, PhotonNetwork.player, string.Empty);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(ShowHPBar());
		}
	}

	private void __BB_OBFUSCATOR_20(float LNBAOJFOGDF, PhotonPlayer HKOIJFEMIMB, string OHJBLLKDFHO)
	{
		if (OHEOLDDNBII)
		{
			return;
		}
		if (OHJBLLKDFHO == string.Empty)
		{
			OHJBLLKDFHO = PhotonNetwork.player.name;
		}
		if (!(HLPBCOGDPCF > 1073f) || base.photonView.isMine)
		{
		}
		HLPBCOGDPCF -= LNBAOJFOGDF;
		if (HLPBCOGDPCF < 1082f)
		{
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				base.transform.GetChild(i).gameObject.SetActive(true);
			}
			Transform transform = Object.Instantiate(NHDPIMJDMMN, base.transform.position + Vector3.down, base.transform.rotation);
			if (base.photonView.isMine)
			{
				StartCoroutine(__BB_OBFUSCATOR_64(392f));
			}
			HLPBCOGDPCF = 677f;
			OHEOLDDNBII = true;
			GameObject.Find("_Value2").SendMessage("Target no longer exists: ", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (base.photonView.isMine)
		{
			HKEPPNAHBOG = EAKDACOPPLJ[CEEGNIEBCGJ];
			if (CEEGNIEBCGJ == 0)
			{
				base.transform.Find("(Clone)").tag = "DM";
			}
			else
			{
				base.transform.Find("_Value2").tag = "PlayerName";
			}
			base.gameObject.name = "Right Stick Right";
		}
		HLPBCOGDPCF = GFPDIKNCIKH;
		MCDJLOECKJI = GameObject.FindWithTag("Flashlight");
		OGKPPJHGFHD = MCDJLOECKJI.GetComponent<RoomMultiplayerMenu>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(776f, 1863f, 1250f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
		if (PhotonNetwork.room.customProperties["TeamName"] != null)
		{
			int num = (int)PhotonNetwork.room.customProperties[" custards remaining"];
			if (num == 1)
			{
				HEAKJAPBDGE = 8;
			}
			if (num == 4)
			{
				HEAKJAPBDGE = 1;
			}
			if (num == 8)
			{
				HEAKJAPBDGE = 4;
			}
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("_Value3") : GameObject.FindGameObjectsWithTag("_ScreenResolution"));
		float num = MKOGACCGCPG * 518f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i++)
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
				transform.SendMessageUpwards("SyncNPCCount", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_9()
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
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				LJLBGNFIOPI = AKKAFLANFMH[i].transform;
			}
		}
		yield return new WaitForSeconds(5f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_62()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("CameraFilterPack/TV_ARCADE_2") : GameObject.FindGameObjectsWithTag("in: "));
		float num = MKOGACCGCPG * 1503f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i++)
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
				transform.SendMessageUpwards("Move Right2", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("\n") : GameObject.FindGameObjectsWithTag("Unsubscribe called while not connected to front end server."));
		float num = MKOGACCGCPG * 1820f;
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
				transform.SendMessageUpwards("Checker", LNBAOJFOGDF, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_0(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
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

	private void __BB_OBFUSCATOR_54(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(NAOGNHFIKJI);
			JAOOMHKNKEK.SendNext(CEEGNIEBCGJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			NAOGNHFIKJI = (int)JAOOMHKNKEK.ReceiveNext();
			CEEGNIEBCGJ = (int)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_15(float LNBAOJFOGDF)
	{
		PhotonView obj = base.photonView;
		object[] array = new object[7];
		array[0] = LNBAOJFOGDF * (float)HEAKJAPBDGE;
		array[0] = PhotonNetwork.player;
		array[0] = string.Empty;
		obj.RPC("l", PhotonTargets.Others, array);
		if (!KLKIPHOAEFE)
		{
			StartCoroutine(__BB_OBFUSCATOR_73());
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(510f, 144f, 919f))
		{
			base.transform.position = DLPNGACNGPB;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_31(float GDIIDIKGFCH)
	{
		yield return new WaitForSeconds(GDIIDIKGFCH);
		PhotonNetwork.Destroy(base.gameObject);
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
			base.gameObject.name = "[BOT] Newborn";
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

	private void __BB_OBFUSCATOR_53()
	{
		GameObject[] array = ((CEEGNIEBCGJ != 0) ? GameObject.FindGameObjectsWithTag("ZWName'") : GameObject.FindGameObjectsWithTag("_Value3"));
		float num = MKOGACCGCPG * 1061f;
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
		if (transform != null)
		{
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("VS", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.RequireReceiver);
			base.transform.localEulerAngles = new Vector3(1216f, base.transform.localEulerAngles.y, 1285f);
		}
	}

	[PunRPC]
	private void RangedAttack()
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
		if (transform != null)
		{
			base.transform.LookAt(transform.position - transform.up);
			Transform transform2 = Object.Instantiate(OLMLANGKNML, KNJMPECEBCI.position, KNJMPECEBCI.rotation);
			transform2.SendMessageUpwards("SyncTeamName", EAKDACOPPLJ[CEEGNIEBCGJ], SendMessageOptions.DontRequireReceiver);
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
		}
	}
}
