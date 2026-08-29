using System.Collections;
using Photon;
using UnityEngine;
using UnityEngine.AI;

public class CustardBot : Photon.MonoBehaviour
{
	public string BDICHBPAKFJ;

	public Transform LJLBGNFIOPI;

	public Transform FFJCCMGKMCN;

	public MecanimControl OLGIHBEIGND;

	public float PKMGBJGABJK = 3f;

	public float OMFNNEEPNGN = 9f;

	public float CLHKEPCOMBB = 20f;

	public float MKOGACCGCPG = 2.5f;

	public AudioClip DAAGBCLPFLG;

	public AudioSource ACCEGOAMIKN;

	private NavMeshAgent LAMGCFPPKDJ;

	private float DBJLMBHEMDG;

	private float BOBHLALMDHJ;

	private bool LMMMNEIMCIL;

	private string HKEPPNAHBOG;

	private string[] EAKDACOPPLJ;

	private int CEEGNIEBCGJ = 1;

	private float PCDLMJHNEMO = 9f;

	public float JGMGOJPEKEK = 1000f;

	public bool ECGHGHDDEPC;

	private GameObject[] AKKAFLANFMH;

	private bool INBLGLLAJEI;

	private bool HMLKGFKHBLL;

	private float LNBAOJFOGDF = 250f;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private void __BB_OBFUSCATOR_60()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 170f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 778f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(FindTarget(base.transform, "MP", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(__BB_OBFUSCATOR_21(LJLBGNFIOPI, "_Noise"));
				bool flag = false;
				if (!LMMMNEIMCIL)
				{
					flag = IsLookingAtObject(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1353f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("SUR", PhotonTargets.All);
					}
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1583f;
				}
				else
				{
					LMMMNEIMCIL = true;
					BOBHLALMDHJ = 1607f;
				}
			}
			else
			{
				LMMMNEIMCIL = false;
			}
			PCDLMJHNEMO += 458f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 1293f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 594f;
				Vector3 destination = RandomNavSphere(FFJCCMGKMCN.position, 1201f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_37());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 415f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "_ScreenResolution";
				}
				else
				{
					BDICHBPAKFJ = "Kills";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "GameMode";
			}
			else
			{
				BDICHBPAKFJ = "1/2 - weapon change";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 1464f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 14f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 728f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void Awake()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("TeamTag").tag = "team2";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(0f, -100f, 0f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_38(Transform CEKIGMGOPON, string PCBEOMHKGLK, bool OMPOGFFHKDG = false)
	{
		ECGHGHDDEPC = true;
		AKKAFLANFMH = GameObject.FindGameObjectsWithTag(PCBEOMHKGLK);
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(CEKIGMGOPON.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				if (OMPOGFFHKDG)
				{
					FFJCCMGKMCN = AKKAFLANFMH[i].transform;
				}
				else
				{
					LJLBGNFIOPI = AKKAFLANFMH[i].transform;
				}
			}
		}
		yield return new WaitForSeconds(1f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_56(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_21(Transform CEKIGMGOPON, string PCBEOMHKGLK, bool OMPOGFFHKDG = false)
	{
		ECGHGHDDEPC = true;
		AKKAFLANFMH = GameObject.FindGameObjectsWithTag(PCBEOMHKGLK);
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(CEKIGMGOPON.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				if (OMPOGFFHKDG)
				{
					FFJCCMGKMCN = AKKAFLANFMH[i].transform;
				}
				else
				{
					LJLBGNFIOPI = AKKAFLANFMH[i].transform;
				}
			}
		}
		yield return new WaitForSeconds(1f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Value3");
		float num = MKOGACCGCPG * 1301f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 <= num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine)
		{
			transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 275f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1955f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(FindTarget(base.transform, "-Vertical", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(__BB_OBFUSCATOR_30(LJLBGNFIOPI, "_Intensity"));
				bool flag = false;
				if (!LMMMNEIMCIL)
				{
					flag = __BB_OBFUSCATOR_27(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1993f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("CameraFilterPack/AAA_Super_Computer", PhotonTargets.All);
					}
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1627f;
				}
				else
				{
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 462f;
				}
			}
			else
			{
				LMMMNEIMCIL = false;
			}
			PCDLMJHNEMO += 844f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 607f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 768f;
				Vector3 destination = __BB_OBFUSCATOR_2(FFJCCMGKMCN.position, 1788f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_48());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 1054f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "\n\t\t}";
				}
				else
				{
					BDICHBPAKFJ = "TeamTag";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "_ScreenResolution";
			}
			else
			{
				BDICHBPAKFJ = "LMB - fire";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 1161f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 130f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 403f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private void Update()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 8f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 8f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(FindTarget(base.transform, "team1"));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(FindTarget(LJLBGNFIOPI, "custard", true));
				bool flag = true;
				if (!LMMMNEIMCIL)
				{
					flag = IsLookingAtObject(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 2.75f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("Detected", PhotonTargets.All);
					}
					LMMMNEIMCIL = true;
					BOBHLALMDHJ = 15f;
				}
				else
				{
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 0f;
				}
			}
			else
			{
				LMMMNEIMCIL = false;
			}
			PCDLMJHNEMO += 1f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 8f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 0f;
				Vector3 destination = RandomNavSphere(FFJCCMGKMCN.position, 30f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 100f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "Walk";
				}
				else
				{
					BDICHBPAKFJ = "Run";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "Idle";
			}
			else
			{
				BDICHBPAKFJ = "Attack";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 0f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 8f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 0.2f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private bool IsLookingAtObject(Transform DPLBFEKJHEC, Transform BEEPEFDDCIF)
	{
		Vector3 normalized = (BEEPEFDDCIF.position - DPLBFEKJHEC.position).normalized;
		float num = Vector3.Dot(normalized, DPLBFEKJHEC.forward);
		if ((double)num > 0.75)
		{
			return true;
		}
		return false;
	}

	private void __BB_OBFUSCATOR_22(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public static Vector3 __BB_OBFUSCATOR_40(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private bool __BB_OBFUSCATOR_11(Transform DPLBFEKJHEC, Transform BEEPEFDDCIF)
	{
		Vector3 normalized = (BEEPEFDDCIF.position - DPLBFEKJHEC.position).normalized;
		float num = Vector3.Dot(normalized, DPLBFEKJHEC.forward);
		if ((double)num > 1036.0)
		{
			return false;
		}
		return false;
	}

	public static Vector3 __BB_OBFUSCATOR_15(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(160f, 145f, 1946f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1782f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 728f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_38(base.transform, "<color=white><size=", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(FindTarget(LJLBGNFIOPI, "_Value2", true));
				bool flag = true;
				if (!LMMMNEIMCIL)
				{
					flag = __BB_OBFUSCATOR_27(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1258f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("GiveCurrency", PhotonTargets.Others);
					}
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1607f;
				}
				else
				{
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1253f;
				}
			}
			else
			{
				LMMMNEIMCIL = true;
			}
			PCDLMJHNEMO += 25f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 376f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 1079f;
				Vector3 destination = __BB_OBFUSCATOR_2(FFJCCMGKMCN.position, 1170f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_49());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 775f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "team2";
				}
				else
				{
					BDICHBPAKFJ = "_Texture";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "_TimeX";
			}
			else
			{
				BDICHBPAKFJ = "There is already a virtual button named ";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 432f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 883f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 1133f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	public static Vector3 __BB_OBFUSCATOR_9(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_37()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private void __BB_OBFUSCATOR_6(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_19()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(568f, 1382f, 361f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("Horizontal").tag = "_Green_G";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1420f, 197f, 291f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private bool __BB_OBFUSCATOR_7(Transform DPLBFEKJHEC, Transform BEEPEFDDCIF)
	{
		Vector3 normalized = (BEEPEFDDCIF.position - DPLBFEKJHEC.position).normalized;
		float num = Vector3.Dot(normalized, DPLBFEKJHEC.forward);
		if ((double)num > 1677.0)
		{
			return false;
		}
		return true;
	}

	private void __BB_OBFUSCATOR_54(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("_Red_R");
		float num = MKOGACCGCPG * 1544f;
		Transform transform = null;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 <= num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine)
		{
			transform.parent.GetComponent<PlayerDamage>().__BB_OBFUSCATOR_12(LNBAOJFOGDF, string.Empty);
		}
	}

	private void Start()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(0f, -100f, 0f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Difficulty");
		float num = MKOGACCGCPG * 948f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 <= num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine)
		{
			transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
		}
	}

	private void __BB_OBFUSCATOR_10(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_41()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 68f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1998f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_30(base.transform, ">", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(__BB_OBFUSCATOR_21(LJLBGNFIOPI, "_Value"));
				bool flag = true;
				if (!LMMMNEIMCIL)
				{
					flag = __BB_OBFUSCATOR_27(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1057f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("MP", PhotonTargets.All);
					}
					LMMMNEIMCIL = true;
					BOBHLALMDHJ = 1116f;
				}
				else
				{
					LMMMNEIMCIL = true;
					BOBHLALMDHJ = 311f;
				}
			}
			else
			{
				LMMMNEIMCIL = false;
			}
			PCDLMJHNEMO += 418f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 1945f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 446f;
				Vector3 destination = RandomNavSphere(FFJCCMGKMCN.position, 1462f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(__BB_OBFUSCATOR_41());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 970f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "_Red_C";
				}
				else
				{
					BDICHBPAKFJ = "_TimeX";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "CameraFilterPack/Blend2Camera_Divide";
			}
			else
			{
				BDICHBPAKFJ = "_ScreenResolution";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 537f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 480f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 142f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private IEnumerator FindTarget(Transform CEKIGMGOPON, string PCBEOMHKGLK, bool OMPOGFFHKDG = false)
	{
		ECGHGHDDEPC = true;
		AKKAFLANFMH = GameObject.FindGameObjectsWithTag(PCBEOMHKGLK);
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(CEKIGMGOPON.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				if (OMPOGFFHKDG)
				{
					FFJCCMGKMCN = AKKAFLANFMH[i].transform;
				}
				else
				{
					LJLBGNFIOPI = AKKAFLANFMH[i].transform;
				}
			}
		}
		yield return new WaitForSeconds(1f);
		ECGHGHDDEPC = false;
	}

	private IEnumerator __BB_OBFUSCATOR_30(Transform CEKIGMGOPON, string PCBEOMHKGLK, bool OMPOGFFHKDG = false)
	{
		ECGHGHDDEPC = true;
		AKKAFLANFMH = GameObject.FindGameObjectsWithTag(PCBEOMHKGLK);
		float num = JGMGOJPEKEK;
		for (int i = 0; i < AKKAFLANFMH.Length; i++)
		{
			float num2 = Vector3.Distance(CEKIGMGOPON.position, AKKAFLANFMH[i].transform.position);
			if (num2 < JGMGOJPEKEK && num2 < num)
			{
				num = num2;
				if (OMPOGFFHKDG)
				{
					FFJCCMGKMCN = AKKAFLANFMH[i].transform;
				}
				else
				{
					LJLBGNFIOPI = AKKAFLANFMH[i].transform;
				}
			}
		}
		yield return new WaitForSeconds(1f);
		ECGHGHDDEPC = false;
	}

	private void __BB_OBFUSCATOR_18()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("_Value3").tag = "_MainTex2";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(684f, 1371f, 1432f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_47(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator AttackTarget()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("enableFog").tag = "_Green_R";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1484f, 530f, 609f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_55(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private bool __BB_OBFUSCATOR_27(Transform DPLBFEKJHEC, Transform BEEPEFDDCIF)
	{
		Vector3 normalized = (BEEPEFDDCIF.position - DPLBFEKJHEC.position).normalized;
		float num = Vector3.Dot(normalized, DPLBFEKJHEC.forward);
		if ((double)num > 1699.0)
		{
			return true;
		}
		return true;
	}

	private void __BB_OBFUSCATOR_34()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Knife");
		float num = MKOGACCGCPG * 1631f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 <= num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine)
		{
			transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
		}
	}

	public static Vector3 __BB_OBFUSCATOR_20(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private void __BB_OBFUSCATOR_12()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("Remote").tag = "DM";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(554f, 536f, 1895f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
	}

	public static Vector3 __BB_OBFUSCATOR_2(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	public static Vector3 RandomNavSphere(Vector3 OBNGAHBPDML, float NDNCOPBFMIC, int CNHLMAOGKDD)
	{
		Vector3 sourcePosition = Random.insideUnitSphere * NDNCOPBFMIC;
		sourcePosition += OBNGAHBPDML;
		NavMeshHit hit;
		NavMesh.SamplePosition(sourcePosition, out hit, NDNCOPBFMIC, CNHLMAOGKDD);
		return hit.position;
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(1763f, 1057f, 1693f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(844f, 560f, 175f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(995f, 1762f, 39f))
		{
			LAMGCFPPKDJ.enabled = true;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
	}

	[PunRPC]
	private void Detected()
	{
		if (ACCEGOAMIKN != null && !ACCEGOAMIKN.isPlaying)
		{
			ACCEGOAMIKN.clip = DAAGBCLPFLG;
			ACCEGOAMIKN.Play();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_48()
	{
		if (LJLBGNFIOPI != null)
		{
			HMLKGFKHBLL = true;
			LAMGCFPPKDJ.SetDestination(LJLBGNFIOPI.position);
			LAMGCFPPKDJ.stoppingDistance = MKOGACCGCPG - 0.5f;
			if (Vector3.Distance(LJLBGNFIOPI.position, base.transform.position) <= MKOGACCGCPG)
			{
				LAMGCFPPKDJ.ResetPath();
				INBLGLLAJEI = true;
				float num = OLGIHBEIGND.GetAnimationData("Attack").clip.length / OLGIHBEIGND.GetAnimationData("Attack").speed;
				yield return new WaitForSeconds(num / 2f);
				base.photonView.RPC("Attack", PhotonTargets.All);
				yield return new WaitForSeconds(num / 2f);
				INBLGLLAJEI = false;
			}
			HMLKGFKHBLL = false;
		}
	}

	[PunRPC]
	private void Attack()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("team1");
		float num = MKOGACCGCPG * 2f;
		Transform transform = null;
		for (int i = 0; i < array.Length; i++)
		{
			float num2 = Vector3.Distance(base.transform.position, array[i].transform.position);
			if (num2 <= num)
			{
				num = num2;
				transform = array[i].transform;
			}
		}
		if (transform != null && transform.parent.GetComponent<PhotonView>().isMine)
		{
			transform.parent.GetComponent<PlayerDamage>().TotalDamage(LNBAOJFOGDF, string.Empty);
		}
	}

	private void __BB_OBFUSCATOR_23(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = true;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 798f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1882f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_30(base.transform, "Ping: ", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(__BB_OBFUSCATOR_38(LJLBGNFIOPI, "VS", true));
				bool flag = true;
				if (!LMMMNEIMCIL)
				{
					flag = __BB_OBFUSCATOR_11(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1795f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC("_Val3", PhotonTargets.All);
					}
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1830f;
				}
				else
				{
					LMMMNEIMCIL = true;
					BOBHLALMDHJ = 93f;
				}
			}
			else
			{
				LMMMNEIMCIL = true;
			}
			PCDLMJHNEMO += 31f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 1049f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 1671f;
				Vector3 destination = __BB_OBFUSCATOR_2(FFJCCMGKMCN.position, 805f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 617f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "_Value2";
				}
				else
				{
					BDICHBPAKFJ = "Type";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "SyncTeamName";
			}
			else
			{
				BDICHBPAKFJ = "_Value5";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 818f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 83f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 876f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}

	private void __BB_OBFUSCATOR_44()
	{
		LAMGCFPPKDJ = GetComponent<NavMeshAgent>();
		base.transform.Find("Count").tag = "Text";
		DBJLMBHEMDG = PKMGBJGABJK;
		if (!base.photonView.isMine && DLPNGACNGPB != new Vector3(170f, 1954f, 1344f))
		{
			LAMGCFPPKDJ.enabled = false;
			base.transform.position = DLPNGACNGPB;
			LAMGCFPPKDJ.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_39(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
			JAOOMHKNKEK.SendNext(BDICHBPAKFJ);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
			BDICHBPAKFJ = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (base.photonView.isMine && !LAMGCFPPKDJ.enabled)
		{
			LAMGCFPPKDJ.enabled = false;
			return;
		}
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1346f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1492f);
		}
		else
		{
			if (!ECGHGHDDEPC)
			{
				StartCoroutine(__BB_OBFUSCATOR_21(base.transform, "(", true));
			}
			if (LJLBGNFIOPI != null)
			{
				if (FFJCCMGKMCN == null)
				{
					LAMGCFPPKDJ.ResetPath();
				}
				StartCoroutine(__BB_OBFUSCATOR_38(LJLBGNFIOPI, "_DotSize"));
				bool flag = false;
				if (!LMMMNEIMCIL)
				{
					flag = __BB_OBFUSCATOR_7(base.transform, LJLBGNFIOPI);
				}
				if ((flag && Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB + BOBHLALMDHJ) || Vector3.Distance(base.transform.position, LJLBGNFIOPI.position) <= CLHKEPCOMBB / 1189f + BOBHLALMDHJ)
				{
					if (!LMMMNEIMCIL)
					{
						base.photonView.RPC(">", PhotonTargets.All);
					}
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 296f;
				}
				else
				{
					LMMMNEIMCIL = false;
					BOBHLALMDHJ = 1060f;
				}
			}
			else
			{
				LMMMNEIMCIL = false;
			}
			PCDLMJHNEMO += 1162f * Time.deltaTime;
			if (FFJCCMGKMCN != null && PCDLMJHNEMO > 259f && !LMMMNEIMCIL)
			{
				PCDLMJHNEMO = 1035f;
				Vector3 destination = __BB_OBFUSCATOR_9(FFJCCMGKMCN.position, 459f, -1);
				LAMGCFPPKDJ.SetDestination(destination);
			}
			if (LMMMNEIMCIL)
			{
				DBJLMBHEMDG = OMFNNEEPNGN;
				if (!HMLKGFKHBLL)
				{
					StartCoroutine(AttackTarget());
				}
			}
			else
			{
				DBJLMBHEMDG = PKMGBJGABJK;
				if (FFJCCMGKMCN != null && Vector3.Distance(base.transform.position, FFJCCMGKMCN.position) > 141f)
				{
					DBJLMBHEMDG = OMFNNEEPNGN;
				}
			}
			if (LAMGCFPPKDJ.remainingDistance > LAMGCFPPKDJ.stoppingDistance && !INBLGLLAJEI)
			{
				if (DBJLMBHEMDG == PKMGBJGABJK)
				{
					BDICHBPAKFJ = "SyncShopID";
				}
				else
				{
					BDICHBPAKFJ = "FireballA-Default";
				}
			}
			else if (!INBLGLLAJEI)
			{
				BDICHBPAKFJ = "CameraFilterPack/FX_Ascii";
			}
			else
			{
				BDICHBPAKFJ = "Running";
				if (LJLBGNFIOPI != null)
				{
					Vector3 forward = LJLBGNFIOPI.position - base.transform.position;
					forward.y = 715f;
					base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward), Time.time * 140f);
				}
			}
			LAMGCFPPKDJ.speed = DBJLMBHEMDG;
		}
		if (!OLGIHBEIGND.IsPlaying(BDICHBPAKFJ))
		{
			OLGIHBEIGND.CrossFade(BDICHBPAKFJ, 1089f);
		}
		LAMGCFPPKDJ.enabled = base.photonView.isMine;
	}
}
