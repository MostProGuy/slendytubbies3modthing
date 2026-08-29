using System;
using System.Collections;
using UnityEngine;

public class WeaponAnimation : MonoBehaviour
{
	public string JCAIKGGDFOF = "Idle";

	public string HHCAJDEFJKO = "Reload";

	public string JFGPOIHPPOJ = "Fire";

	public string KGKGMENBLOE = "TakeIn";

	public string NFMNHIPCGFO = "TakeOut";

	public float HFFKOPMDFEA = 1f;

	public float CDODDCAMDBO = 1f;

	public bool AKBJEFBLMDC;

	public Vector3 IOKNPAEKPAE;

	public Vector3 MAODMCIKKHB;

	public bool CKHKIEIBCIO;

	private Vector3 GHGJIHEPIOJ;

	private string JINKHFFPOAF;

	private FPScontroller CJFDABKPMND;

	private GameObject HKOIJFEMIMB;

	private bool JGCMBEGPNGI;

	private bool NLODIDDFHCK;

	private string ResolveState(string name)
	{
		Animation animation = GetComponent<Animation>();
		if (string.IsNullOrEmpty(name) || animation.GetClip(name) != null)
		{
			return name;
		}
		foreach (AnimationState animationState in animation)
		{
			if (animationState != null && (string.Equals(animationState.name, name, StringComparison.OrdinalIgnoreCase) || animationState.name.StartsWith(name, StringComparison.OrdinalIgnoreCase)))
			{
				return animationState.name;
			}
		}
		return name;
	}

	public void __BB_OBFUSCATOR_26(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_48());
	}

	private void __BB_OBFUSCATOR_56()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_11()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 201f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_59(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(resetPos());
	}

	private IEnumerator resetPos()
	{
		string stateName = ResolveState(HHCAJDEFJKO);
		while (GetComponent<Animation>().IsPlaying(stateName))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(ResolveState(JCAIKGGDFOF));
	}

	private void Update()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 5f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 5f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 5f * Time.deltaTime);
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_33()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 769f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private IEnumerator __BB_OBFUSCATOR_14()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	public void __BB_OBFUSCATOR_32()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_43()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1823f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1329f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 1308f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 573f * Time.deltaTime);
			}
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_47(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_19());
	}

	public void __BB_OBFUSCATOR_62()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1537f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1402f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 570f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 1915f * Time.deltaTime);
			}
		}
	}

	public void __BB_OBFUSCATOR_8()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1152f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void Fire()
	{
		string stateName = ResolveState(JFGPOIHPPOJ);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(stateName);
	}

	public void __BB_OBFUSCATOR_25()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_36(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_44());
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1675f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 318f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 1197f * Time.deltaTime);
			}
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 829f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 1773f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 1165f * Time.deltaTime);
			}
		}
	}

	public void __BB_OBFUSCATOR_21()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 635f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void Awake()
	{
		GetComponent<Animation>().Play(ResolveState(JCAIKGGDFOF));
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_60()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_3()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Default;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_31(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_64());
	}

	private IEnumerator __BB_OBFUSCATOR_44()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	public void __BB_OBFUSCATOR_63()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 393f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void takeIn()
	{
		NLODIDDFHCK = false;
		string stateName = ResolveState(KGKGMENBLOE);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = CDODDCAMDBO;
		GetComponent<Animation>()[stateName].time = 0f;
		GetComponent<Animation>().Play(stateName);
	}

	private IEnumerator __BB_OBFUSCATOR_64()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	public void __BB_OBFUSCATOR_68()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1648f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_35()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Default;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_58(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_15());
	}

	public void __BB_OBFUSCATOR_38()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1020f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_28()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_4()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1980f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_50()
	{
		NLODIDDFHCK = true;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 256f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_5()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1136f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_55(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_48());
	}

	private IEnumerator __BB_OBFUSCATOR_15()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	public void __BB_OBFUSCATOR_49()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1136f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void Reloading(float ADNPBHMJCMC)
	{
		string stateName = ResolveState(HHCAJDEFJKO);
		GetComponent<Animation>().Stop(stateName);
		GetComponent<Animation>()[stateName].speed = GetComponent<Animation>()[stateName].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>().Play(stateName);
		StartCoroutine(resetPos());
	}

	public void takeOut()
	{
		NLODIDDFHCK = true;
		string stateName = ResolveState(NFMNHIPCGFO);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = CDODDCAMDBO;
		GetComponent<Animation>()[stateName].time = 0f;
		GetComponent<Animation>().Play(stateName);
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 978f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 654f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 691f * Time.deltaTime);
			}
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1550f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 1231f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 687f * Time.deltaTime);
			}
		}
	}

	public void __BB_OBFUSCATOR_61()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_0()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	private void __BB_OBFUSCATOR_52()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_1()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1903f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 452f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 397f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 256f * Time.deltaTime);
			}
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_12()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 950f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	private void __BB_OBFUSCATOR_53()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_23(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_48());
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1427f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 1882f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 457f * Time.deltaTime);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_19()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	public void __BB_OBFUSCATOR_17()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 98f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_67()
	{
		NLODIDDFHCK = false;
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1683f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_39()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1028f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 787f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 768f * Time.deltaTime);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_48()
	{
		while (GetComponent<Animation>().IsPlaying(HHCAJDEFJKO))
		{
			JGCMBEGPNGI = true;
			yield return null;
		}
		JGCMBEGPNGI = false;
		GetComponent<Animation>().Play(JCAIKGGDFOF);
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (AKBJEFBLMDC)
		{
			if (JGCMBEGPNGI)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, IOKNPAEKPAE, 1579f * Time.deltaTime);
			}
			else if (CKHKIEIBCIO && NLODIDDFHCK)
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ + MAODMCIKKHB, 42f * Time.deltaTime);
			}
			else
			{
				base.transform.localPosition = Vector3.Slerp(base.transform.localPosition, GHGJIHEPIOJ, 1402f * Time.deltaTime);
			}
		}
	}

	public void __BB_OBFUSCATOR_30(float ADNPBHMJCMC)
	{
		GetComponent<Animation>().Stop(HHCAJDEFJKO);
		GetComponent<Animation>()[HHCAJDEFJKO].speed = GetComponent<Animation>()[HHCAJDEFJKO].clip.length / ADNPBHMJCMC;
		GetComponent<Animation>().Rewind(HHCAJDEFJKO);
		GetComponent<Animation>().Play(HHCAJDEFJKO);
		StartCoroutine(__BB_OBFUSCATOR_64());
	}

	private void __BB_OBFUSCATOR_20()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_54()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Once;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_42()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>().wrapMode = WrapMode.Default;
		GHGJIHEPIOJ = base.transform.localPosition;
	}

	public void __BB_OBFUSCATOR_13()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}
}
