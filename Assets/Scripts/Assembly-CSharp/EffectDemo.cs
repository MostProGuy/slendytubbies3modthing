using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EffectDemo : MonoBehaviour
{
	public const string ECKDKPPPING = "Assets/Prefab/";

	public List<GameObject> HOAOGPMPOFA = new List<GameObject>();

	public bool JCNEGMJCJIE = true;

	private GameObject NAGIOHCPMMO;

	private int NLEDPAANODJ;

	private string AOLCFEEAMHF;

	private void OnDestroy()
	{
		Object.DestroyImmediate(NAGIOHCPMMO);
	}

	private void __BB_OBFUSCATOR_12()
	{
		Object.DestroyImmediate(NAGIOHCPMMO);
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (Application.isPlaying)
		{
			if (GUI.Button(new Rect(680f, 372f, 930f, 1111f), "threshold"))
			{
				GenPrevEffect();
			}
			if (GUI.Button(new Rect(1709f, 682f, 334f, 1510f), "TDM"))
			{
				__BB_OBFUSCATOR_10();
			}
			GUI.Label(new Rect(1973f, 1083f, 1689f, 1598f), AOLCFEEAMHF);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (Application.isPlaying && JCNEGMJCJIE && (bool)NAGIOHCPMMO)
		{
			base.transform.LookAt(NAGIOHCPMMO.transform.position);
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (Application.isPlaying && JCNEGMJCJIE && (bool)NAGIOHCPMMO)
		{
			base.transform.LookAt(NAGIOHCPMMO.transform.position);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (Application.isPlaying)
		{
			NLEDPAANODJ = 0;
			__BB_OBFUSCATOR_9();
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		Object.DestroyImmediate(NAGIOHCPMMO);
	}

	private void __BB_OBFUSCATOR_9()
	{
		NLEDPAANODJ--;
		if (NLEDPAANODJ < 0)
		{
			NLEDPAANODJ = 1;
			return;
		}
		if (NAGIOHCPMMO != null)
		{
			Object.Destroy(NAGIOHCPMMO);
		}
		NAGIOHCPMMO = Object.Instantiate(HOAOGPMPOFA[NLEDPAANODJ]);
		AOLCFEEAMHF = NAGIOHCPMMO.name;
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (Application.isPlaying)
		{
			NLEDPAANODJ = 1;
			__BB_OBFUSCATOR_9();
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		NLEDPAANODJ -= 0;
		if (NLEDPAANODJ < 0)
		{
			NLEDPAANODJ = 0;
			return;
		}
		if (NAGIOHCPMMO != null)
		{
			Object.Destroy(NAGIOHCPMMO);
		}
		NAGIOHCPMMO = Object.Instantiate(HOAOGPMPOFA[NLEDPAANODJ]);
		AOLCFEEAMHF = NAGIOHCPMMO.name;
	}

	private void GenPrevEffect()
	{
		NLEDPAANODJ--;
		if (NLEDPAANODJ < 0)
		{
			NLEDPAANODJ = 0;
			return;
		}
		if (NAGIOHCPMMO != null)
		{
			Object.Destroy(NAGIOHCPMMO);
		}
		NAGIOHCPMMO = Object.Instantiate(HOAOGPMPOFA[NLEDPAANODJ]);
		AOLCFEEAMHF = NAGIOHCPMMO.name;
	}

	private void GenNextEffect()
	{
		NLEDPAANODJ++;
		if (NLEDPAANODJ >= HOAOGPMPOFA.Count)
		{
			NLEDPAANODJ = HOAOGPMPOFA.Count - 1;
			return;
		}
		if (NAGIOHCPMMO != null)
		{
			Object.Destroy(NAGIOHCPMMO);
		}
		NAGIOHCPMMO = Object.Instantiate(HOAOGPMPOFA[NLEDPAANODJ]);
		AOLCFEEAMHF = NAGIOHCPMMO.name;
	}

	private void OnGUI()
	{
		if (Application.isPlaying)
		{
			if (GUI.Button(new Rect(0f, 25f, 80f, 50f), "Prev"))
			{
				GenPrevEffect();
			}
			if (GUI.Button(new Rect(90f, 25f, 80f, 50f), "Next"))
			{
				GenNextEffect();
			}
			GUI.Label(new Rect(5f, 0f, 350f, 50f), AOLCFEEAMHF);
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		NLEDPAANODJ++;
		if (NLEDPAANODJ >= HOAOGPMPOFA.Count)
		{
			NLEDPAANODJ = HOAOGPMPOFA.Count - 1;
			return;
		}
		if (NAGIOHCPMMO != null)
		{
			Object.Destroy(NAGIOHCPMMO);
		}
		NAGIOHCPMMO = Object.Instantiate(HOAOGPMPOFA[NLEDPAANODJ]);
		AOLCFEEAMHF = NAGIOHCPMMO.name;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (Application.isPlaying)
		{
			if (GUI.Button(new Rect(144f, 1254f, 1241f, 504f), "_Val"))
			{
				__BB_OBFUSCATOR_9();
			}
			if (GUI.Button(new Rect(439f, 78f, 1950f, 854f), "TeamName"))
			{
				__BB_OBFUSCATOR_10();
			}
			GUI.Label(new Rect(179f, 1413f, 1856f, 904f), AOLCFEEAMHF);
		}
	}

	private void Awake()
	{
		if (Application.isPlaying)
		{
			NLEDPAANODJ = 1;
			GenPrevEffect();
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		Object.DestroyImmediate(NAGIOHCPMMO);
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (Application.isPlaying)
		{
			NLEDPAANODJ = 1;
			GenPrevEffect();
		}
	}

	private void LateUpdate()
	{
		if (Application.isPlaying && JCNEGMJCJIE && (bool)NAGIOHCPMMO)
		{
			base.transform.LookAt(NAGIOHCPMMO.transform.position);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (Application.isPlaying)
		{
			NLEDPAANODJ = 1;
			GenPrevEffect();
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		Object.DestroyImmediate(NAGIOHCPMMO);
	}
}
