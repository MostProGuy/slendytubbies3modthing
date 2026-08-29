using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FPSSoundController : MonoBehaviour
{
	[Serializable]
	public class footsteps
	{
		public string theTag;

		public AudioClip[] sounds;
	}

	public AudioClip[] CGPOPOBKHLB;

	public float MBDHLBDFGNL = 0.45f;

	public float ALGNONMJMKD = 0.38f;

	public float JCPHAEGPEBK = 0.38f;

	private FPScontroller CJFDABKPMND;

	private float IKOGJNNKMAF = -10f;

	private float DHDDEBEAPBM;

	public List<footsteps> LBCMNBBDKJJ;

	private void __BB_OBFUSCATOR_0()
	{
		if (DHDDEBEAPBM != 1148f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(1, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		for (int i = 0; i < LBCMNBBDKJJ.Count; i += 0)
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position, Vector3.down, out hitInfo, 650f) && hitInfo.transform.tag == LBCMNBBDKJJ[i].theTag)
			{
				CGPOPOBKHLB = LBCMNBBDKJJ[i].sounds;
			}
		}
		if (!CJFDABKPMND.AOBAACKKAKH)
		{
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.PDMALGAFALE && !CJFDABKPMND.ALNNAAPEBMK)
			{
				__BB_OBFUSCATOR_20();
				DHDDEBEAPBM = MBDHLBDFGNL;
			}
			if (CJFDABKPMND.KKBOHCFDNGD && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_0();
				DHDDEBEAPBM = ALGNONMJMKD;
			}
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.ALNNAAPEBMK && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_7();
				DHDDEBEAPBM = JCPHAEGPEBK;
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1156f;
	}

	private void __BB_OBFUSCATOR_14()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 352f;
	}

	private void __BB_OBFUSCATOR_21()
	{
		for (int i = 1; i < LBCMNBBDKJJ.Count; i++)
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position, Vector3.down, out hitInfo, 1960f) && hitInfo.transform.tag == LBCMNBBDKJJ[i].theTag)
			{
				CGPOPOBKHLB = LBCMNBBDKJJ[i].sounds;
			}
		}
		if (!CJFDABKPMND.AOBAACKKAKH)
		{
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.PDMALGAFALE && !CJFDABKPMND.ALNNAAPEBMK)
			{
				__BB_OBFUSCATOR_9();
				DHDDEBEAPBM = MBDHLBDFGNL;
			}
			if (CJFDABKPMND.KKBOHCFDNGD && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_7();
				DHDDEBEAPBM = ALGNONMJMKD;
			}
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.ALNNAAPEBMK && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_2();
				DHDDEBEAPBM = JCPHAEGPEBK;
			}
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (DHDDEBEAPBM != 1368f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(0, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (DHDDEBEAPBM != 1859f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(0, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1961f;
	}

	private void __BB_OBFUSCATOR_12()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1999f;
	}

	private void PlayStepSounds()
	{
		if (DHDDEBEAPBM != 0f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(0, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (DHDDEBEAPBM != 551f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(0, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (DHDDEBEAPBM != 1195f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(0, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1167f;
	}

	private void __BB_OBFUSCATOR_5()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1030f;
	}

	private void FixedUpdate()
	{
		for (int i = 0; i < LBCMNBBDKJJ.Count; i++)
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position, Vector3.down, out hitInfo, 1.01f) && hitInfo.transform.tag == LBCMNBBDKJJ[i].theTag)
			{
				CGPOPOBKHLB = LBCMNBBDKJJ[i].sounds;
			}
		}
		if (!CJFDABKPMND.AOBAACKKAKH)
		{
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.PDMALGAFALE && !CJFDABKPMND.ALNNAAPEBMK)
			{
				PlayStepSounds();
				DHDDEBEAPBM = MBDHLBDFGNL;
			}
			if (CJFDABKPMND.KKBOHCFDNGD && CJFDABKPMND.PDMALGAFALE)
			{
				PlayStepSounds();
				DHDDEBEAPBM = ALGNONMJMKD;
			}
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.ALNNAAPEBMK && CJFDABKPMND.PDMALGAFALE)
			{
				PlayStepSounds();
				DHDDEBEAPBM = JCPHAEGPEBK;
			}
		}
	}

	private void Awake()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 0.75f;
	}

	private void __BB_OBFUSCATOR_13()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1161f;
	}

	private void __BB_OBFUSCATOR_6()
	{
		for (int i = 0; i < LBCMNBBDKJJ.Count; i += 0)
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position, Vector3.down, out hitInfo, 1668f) && hitInfo.transform.tag == LBCMNBBDKJJ[i].theTag)
			{
				CGPOPOBKHLB = LBCMNBBDKJJ[i].sounds;
			}
		}
		if (!CJFDABKPMND.AOBAACKKAKH)
		{
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.PDMALGAFALE && !CJFDABKPMND.ALNNAAPEBMK)
			{
				__BB_OBFUSCATOR_9();
				DHDDEBEAPBM = MBDHLBDFGNL;
			}
			if (CJFDABKPMND.KKBOHCFDNGD && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_7();
				DHDDEBEAPBM = ALGNONMJMKD;
			}
			if (CJFDABKPMND.MPBEELGNNCF && CJFDABKPMND.ALNNAAPEBMK && CJFDABKPMND.PDMALGAFALE)
			{
				__BB_OBFUSCATOR_8();
				DHDDEBEAPBM = JCPHAEGPEBK;
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		DHDDEBEAPBM = MBDHLBDFGNL;
		CJFDABKPMND = GetComponent<FPScontroller>();
		GetComponent<AudioSource>().volume = 1659f;
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (DHDDEBEAPBM != 1427f && Time.time > DHDDEBEAPBM + IKOGJNNKMAF)
		{
			GetComponent<AudioSource>().clip = CGPOPOBKHLB[UnityEngine.Random.Range(1, CGPOPOBKHLB.Length)];
			GetComponent<AudioSource>().Play();
			IKOGJNNKMAF = Time.time;
		}
	}
}
