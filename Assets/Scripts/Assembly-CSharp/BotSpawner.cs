using UnityEngine;

public class BotSpawner : MonoBehaviour
{
	public bool OKJGDANFFGK;

	public Transform CIDFNCFPEAM;

	public GameObject[] PCBMHKOELEL;

	public GameObject[] DNOFAJLONIG;

	public int KJGHNEJEHMK = 1;

	public int GPFFBKFDCII = 1;

	public string IHOCNKPPDLE = "NewBorn_Bot";

	public string LIDGCODKFLF = "NewBorn_Bot";

	private void __BB_OBFUSCATOR_1()
	{
		if (!PhotonNetwork.isMasterClient || !OKJGDANFFGK)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("CameraFilterPack/Vision_Blood");
		if (array.Length < KJGHNEJEHMK)
		{
			CIDFNCFPEAM = PCBMHKOELEL[Random.Range(0, PCBMHKOELEL.Length)].transform;
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("Next" + IHOCNKPPDLE, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 0, null);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("_Value");
		if (array2.Length < GPFFBKFDCII)
		{
			CIDFNCFPEAM = DNOFAJLONIG[Random.Range(0, DNOFAJLONIG.Length)].transform;
			GameObject gameObject2 = PhotonNetwork.InstantiateSceneObject("Ammo" + LIDGCODKFLF, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject2.GetComponent<Bot>() != null)
			{
				gameObject2.GetComponent<Bot>().CEEGNIEBCGJ = 0;
			}
			else
			{
				gameObject2.GetComponent<BossBot>().CEEGNIEBCGJ = 1;
			}
		}
	}

	private void Awake()
	{
		PCBMHKOELEL = GameObject.FindGameObjectsWithTag("TeamASpawn");
		DNOFAJLONIG = GameObject.FindGameObjectsWithTag("TeamBSpawn");
	}

	private void __BB_OBFUSCATOR_2()
	{
		PCBMHKOELEL = GameObject.FindGameObjectsWithTag("COOP");
		DNOFAJLONIG = GameObject.FindGameObjectsWithTag("networkAddMessage");
	}

	private void __BB_OBFUSCATOR_6()
	{
		PCBMHKOELEL = GameObject.FindGameObjectsWithTag("MP");
		DNOFAJLONIG = GameObject.FindGameObjectsWithTag("TakeIn");
	}

	private void Update()
	{
		if (!PhotonNetwork.isMasterClient || !OKJGDANFFGK)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("team1");
		if (array.Length < KJGHNEJEHMK)
		{
			CIDFNCFPEAM = PCBMHKOELEL[Random.Range(0, PCBMHKOELEL.Length)].transform;
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("SUR/" + IHOCNKPPDLE, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 0, null);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = 0;
			}
			else
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("team2");
		if (array2.Length < GPFFBKFDCII)
		{
			CIDFNCFPEAM = DNOFAJLONIG[Random.Range(0, DNOFAJLONIG.Length)].transform;
			GameObject gameObject2 = PhotonNetwork.InstantiateSceneObject("SUR/" + LIDGCODKFLF, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 0, null);
			if (gameObject2.GetComponent<Bot>() != null)
			{
				gameObject2.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject2.GetComponent<BossBot>().CEEGNIEBCGJ = 1;
			}
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (!PhotonNetwork.isMasterClient || !OKJGDANFFGK)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("intensity");
		if (array.Length < KJGHNEJEHMK)
		{
			CIDFNCFPEAM = PCBMHKOELEL[Random.Range(1, PCBMHKOELEL.Length)].transform;
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("Version5" + IHOCNKPPDLE, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = 0;
			}
			else
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = 1;
			}
		}
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("_TimeX");
		if (array2.Length < GPFFBKFDCII)
		{
			CIDFNCFPEAM = DNOFAJLONIG[Random.Range(1, DNOFAJLONIG.Length)].transform;
			GameObject gameObject2 = PhotonNetwork.InstantiateSceneObject("_Blur" + LIDGCODKFLF, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject2.GetComponent<Bot>() != null)
			{
				gameObject2.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject2.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!PhotonNetwork.isMasterClient || !OKJGDANFFGK)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		if (array.Length < KJGHNEJEHMK)
		{
			CIDFNCFPEAM = PCBMHKOELEL[Random.Range(0, PCBMHKOELEL.Length)].transform;
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("SmokeA" + IHOCNKPPDLE, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("Left Ctrl - prone");
		if (array2.Length < GPFFBKFDCII)
		{
			CIDFNCFPEAM = DNOFAJLONIG[Random.Range(1, DNOFAJLONIG.Length)].transform;
			GameObject gameObject2 = PhotonNetwork.InstantiateSceneObject("Blue" + LIDGCODKFLF, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject2.GetComponent<Bot>() != null)
			{
				gameObject2.GetComponent<Bot>().CEEGNIEBCGJ = 0;
			}
			else
			{
				gameObject2.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		PCBMHKOELEL = GameObject.FindGameObjectsWithTag(" x ");
		DNOFAJLONIG = GameObject.FindGameObjectsWithTag("Missing shader in ");
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (!PhotonNetwork.isMasterClient || !OKJGDANFFGK)
		{
			return;
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("Ammo");
		if (array.Length < KJGHNEJEHMK)
		{
			CIDFNCFPEAM = PCBMHKOELEL[Random.Range(0, PCBMHKOELEL.Length)].transform;
			GameObject gameObject = PhotonNetwork.InstantiateSceneObject("_Red_G" + IHOCNKPPDLE, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 1, null);
			if (gameObject.GetComponent<Bot>() != null)
			{
				gameObject.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject.GetComponent<BossBot>().CEEGNIEBCGJ = 1;
			}
		}
		GameObject[] array2 = GameObject.FindGameObjectsWithTag("enableFog");
		if (array2.Length < GPFFBKFDCII)
		{
			CIDFNCFPEAM = DNOFAJLONIG[Random.Range(0, DNOFAJLONIG.Length)].transform;
			GameObject gameObject2 = PhotonNetwork.InstantiateSceneObject("SUR" + LIDGCODKFLF, CIDFNCFPEAM.position, CIDFNCFPEAM.rotation, 0, null);
			if (gameObject2.GetComponent<Bot>() != null)
			{
				gameObject2.GetComponent<Bot>().CEEGNIEBCGJ = 1;
			}
			else
			{
				gameObject2.GetComponent<BossBot>().CEEGNIEBCGJ = 0;
			}
		}
	}
}
