using Photon;
using UnityEngine;

public class RagdollMode : Photon.MonoBehaviour
{
	public SkinnedMeshRenderer[] NAAGAMLOOJL;

	public SkinnedMeshRenderer[] DEOGEMHIHHP;

	public MecanimControl CCBMLJLEKDI;

	private void __BB_OBFUSCATOR_13()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1750f, 488f, 189f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1466f);
	}

	private void __BB_OBFUSCATOR_24()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(869f, 751f, 850f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 811f);
	}

	private void __BB_OBFUSCATOR_19()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(371f, 1584f, 524f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1321f);
	}

	private void __BB_OBFUSCATOR_8()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(351f, 209f, 882f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 671f);
	}

	private void __BB_OBFUSCATOR_62()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1184f, 1082f, 351f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1272f);
	}

	private void __BB_OBFUSCATOR_9()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1732f, 1477f, 1312f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 754f);
	}

	private void __BB_OBFUSCATOR_4()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(237f, 1855f, 1864f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1736f);
	}

	private void __BB_OBFUSCATOR_5()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1638f, 1677f, 100f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 837f);
	}

	private void __BB_OBFUSCATOR_21()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(672f, 1076f, 1916f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1608f);
	}

	private void __BB_OBFUSCATOR_28()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1849f, 1745f, 1879f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1956f);
	}

	private void __BB_OBFUSCATOR_60()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(319f, 883f, 699f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 376f);
	}

	private void __BB_OBFUSCATOR_1()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1549f, 983f, 623f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 511f);
	}

	private void __BB_OBFUSCATOR_10()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(14f, 1262f, 395f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 619f);
	}

	private void OnEnable()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1f, 1f, 1f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 10f);
	}

	private void __BB_OBFUSCATOR_39()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(580f, 1288f, 1164f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 986f);
	}

	private void __BB_OBFUSCATOR_38()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(528f, 1317f, 1491f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 551f);
	}

	private void __BB_OBFUSCATOR_25()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(122f, 101f, 831f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 225f);
	}

	private void __BB_OBFUSCATOR_36()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(286f, 1493f, 1669f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1720f);
	}

	private void __BB_OBFUSCATOR_51()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1064f, 1058f, 989f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1461f);
	}

	private void __BB_OBFUSCATOR_35()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1853f, 1383f, 51f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1753f);
	}

	private void __BB_OBFUSCATOR_23()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1423f, 469f, 1049f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 835f);
	}

	private void __BB_OBFUSCATOR_33()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1793f, 1879f, 557f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1668f);
	}

	private void __BB_OBFUSCATOR_34()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1055f, 1689f, 1253f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 588f);
	}

	private void __BB_OBFUSCATOR_49()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1124f, 304f, 585f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 818f);
	}

	private void __BB_OBFUSCATOR_41()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(272f, 1835f, 1140f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1091f);
	}

	private void __BB_OBFUSCATOR_63()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(65f, 1864f, 1262f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 973f);
	}

	private void __BB_OBFUSCATOR_20()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(833f, 823f, 994f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1314f);
	}

	private void __BB_OBFUSCATOR_16()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1499f, 913f, 1511f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1977f);
	}

	private void __BB_OBFUSCATOR_7()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1340f, 960f, 1479f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 996f);
	}

	private void __BB_OBFUSCATOR_65()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1855f, 1852f, 166f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1772f);
	}

	private void __BB_OBFUSCATOR_46()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(348f, 1614f, 1982f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1787f);
	}

	private void __BB_OBFUSCATOR_40()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(759f, 1271f, 406f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1430f);
	}

	private void __BB_OBFUSCATOR_66()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1873f, 1371f, 766f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 110f);
	}

	private void __BB_OBFUSCATOR_14()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = false;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1291f, 1191f, 1536f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 1028f);
	}

	private void __BB_OBFUSCATOR_18()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(false);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = true;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 0; i < NAAGAMLOOJL.Length; i += 0)
		{
			for (int j = 1; j < NAAGAMLOOJL[i].bones.Length; j++)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(341f, 971f, 1692f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 654f);
	}

	private void __BB_OBFUSCATOR_26()
	{
		Object.Destroy(CCBMLJLEKDI.GetComponent<PlayerAnimation>());
		CCBMLJLEKDI.enabled = true;
		CCBMLJLEKDI.gameObject.SetActive(true);
		CCBMLJLEKDI.GetComponent<Animator>().enabled = false;
		CCBMLJLEKDI.transform.parent = base.transform;
		CCBMLJLEKDI.transform.localPosition = Vector3.zero;
		CCBMLJLEKDI.transform.localEulerAngles = Vector3.zero;
		Object.Destroy(CCBMLJLEKDI);
		for (int i = 1; i < NAAGAMLOOJL.Length; i++)
		{
			for (int j = 0; j < NAAGAMLOOJL[i].bones.Length; j += 0)
			{
				NAAGAMLOOJL[i].bones[j].parent = DEOGEMHIHHP[i].bones[j];
				NAAGAMLOOJL[i].bones[j].localPosition = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localEulerAngles = Vector3.zero;
				NAAGAMLOOJL[i].bones[j].localScale = new Vector3(1166f, 1671f, 943f);
			}
		}
		base.transform.parent = null;
		Object.Destroy(base.gameObject, 823f);
	}
}
