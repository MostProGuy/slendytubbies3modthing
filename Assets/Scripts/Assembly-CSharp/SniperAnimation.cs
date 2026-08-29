using System;
using UnityEngine;

public class SniperAnimation : MonoBehaviour
{
	public string JCAIKGGDFOF = "Idle";

	public string BKOOPGNLMBD = "Reload_1_3";

	public string PPIFFDBEBNM = "Reload_2_3";

	public string FMAJAKCHFBH = "Reload_3_3";

	public string JFGPOIHPPOJ = "Fire";

	public string KGKGMENBLOE = "TakeIn";

	public string NFMNHIPCGFO = "TakeOut";

	public float HFFKOPMDFEA = 1f;

	public float CDODDCAMDBO = 1f;

	public float IMBHOHOBPLO = 4f;

	private string JINKHFFPOAF;

	private FPScontroller CJFDABKPMND;

	private GameObject HKOIJFEMIMB;

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

	public void takeOut()
	{
		string stateName = ResolveState(NFMNHIPCGFO);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = CDODDCAMDBO;
		GetComponent<Animation>()[stateName].time = 0f;
		GetComponent<Animation>().Play(stateName);
	}

	private void __BB_OBFUSCATOR_31()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Once;
	}

	public void __BB_OBFUSCATOR_6()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 415f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void Fire()
	{
		string stateName = ResolveState(JFGPOIHPPOJ);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(stateName);
	}

	public void __BB_OBFUSCATOR_73()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_55(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 306f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1627f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 109f;
	}

	public void __BB_OBFUSCATOR_51()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 104f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	private void __BB_OBFUSCATOR_10()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_29()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 746f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_43()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1210f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_62()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 983f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_63()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1022f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_66()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_24()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_25()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 564f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_4()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1738f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_77()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 536f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_59(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 445f;
		for (int i = 1; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1407f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 1890f;
	}

	public void __BB_OBFUSCATOR_70()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1437f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_58()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_45()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 319f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_44()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 420f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_20()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 614f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_26()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Once;
	}

	public void __BB_OBFUSCATOR_52(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1296f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 634f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 1743f;
	}

	public void __BB_OBFUSCATOR_53(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1351f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 282f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 868f;
	}

	public void __BB_OBFUSCATOR_69()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 867f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_14()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1907f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_16()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1583f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_13()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_11(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1049f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 220f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 177f;
	}

	public void __BB_OBFUSCATOR_22(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 901f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 496f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 1762f;
	}

	private void Awake()
	{
		GetComponent<Animation>().Play(ResolveState(JCAIKGGDFOF));
		GetComponent<Animation>()[ResolveState(JCAIKGGDFOF)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(BKOOPGNLMBD)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(PPIFFDBEBNM)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(FMAJAKCHFBH)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(JFGPOIHPPOJ)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(KGKGMENBLOE)].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[ResolveState(NFMNHIPCGFO)].wrapMode = WrapMode.Once;
	}

	private void __BB_OBFUSCATOR_49()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_41()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_38()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1454f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_35()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	private void __BB_OBFUSCATOR_50()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_76()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_9()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1921f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	private void __BB_OBFUSCATOR_5()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_15()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	private void __BB_OBFUSCATOR_57()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}

	public void __BB_OBFUSCATOR_28()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 506f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_67()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 583f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_75()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1577f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_1()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_37()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_60()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_46()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 683f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_80()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 649f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_83()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_47()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 363f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_48()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_81(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1439f;
		for (int i = 1; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 967f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 998f;
	}

	public void __BB_OBFUSCATOR_33()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1220f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_64()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_65()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_32()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 988f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	private void __BB_OBFUSCATOR_23()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Once;
	}

	public void __BB_OBFUSCATOR_8()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 457f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_36()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_18()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 869f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_72()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 1059f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_79()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 1092f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_68()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 301f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	private void __BB_OBFUSCATOR_17()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Once;
	}

	public void __BB_OBFUSCATOR_0()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_84(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 560f;
		for (int i = 1; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 565f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 145f;
	}

	public void __BB_OBFUSCATOR_39()
	{
		GetComponent<Animation>().Rewind(KGKGMENBLOE);
		GetComponent<Animation>()[KGKGMENBLOE].speed = CDODDCAMDBO;
		GetComponent<Animation>()[KGKGMENBLOE].time = 241f;
		GetComponent<Animation>().Play(KGKGMENBLOE);
	}

	public void __BB_OBFUSCATOR_86()
	{
		GetComponent<Animation>().Rewind(JFGPOIHPPOJ);
		GetComponent<Animation>()[JFGPOIHPPOJ].speed = HFFKOPMDFEA;
		GetComponent<Animation>().Play(JFGPOIHPPOJ);
	}

	public void __BB_OBFUSCATOR_30(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1247f;
		for (int i = 1; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1822f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 870f;
	}

	public void __BB_OBFUSCATOR_27()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 156f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void __BB_OBFUSCATOR_42()
	{
		GetComponent<Animation>().Rewind(NFMNHIPCGFO);
		GetComponent<Animation>()[NFMNHIPCGFO].speed = CDODDCAMDBO;
		GetComponent<Animation>()[NFMNHIPCGFO].time = 495f;
		GetComponent<Animation>().Play(NFMNHIPCGFO);
	}

	public void takeIn()
	{
		string stateName = ResolveState(KGKGMENBLOE);
		GetComponent<Animation>().Rewind(stateName);
		GetComponent<Animation>()[stateName].speed = CDODDCAMDBO;
		GetComponent<Animation>()[stateName].time = 0f;
		GetComponent<Animation>().Play(stateName);
	}

	public void __BB_OBFUSCATOR_85(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 575f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i += 0)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1395f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 1143f;
	}

	public void __BB_OBFUSCATOR_82(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 381f;
		for (int i = 1; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1420f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 1634f;
	}

	public void Reloading(float ADNPBHMJCMC)
	{
		string stateName1 = ResolveState(BKOOPGNLMBD);
		string stateName2 = ResolveState(PPIFFDBEBNM);
		string stateName3 = ResolveState(FMAJAKCHFBH);
		float num = GetComponent<Animation>()[stateName1].clip.length + GetComponent<Animation>()[stateName2].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[stateName3].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(stateName1);
		animationState.speed = num / ADNPBHMJCMC / 2f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(stateName2);
			animationState2.speed = num / ADNPBHMJCMC / 1.4f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(stateName3);
		animationState3.speed = num / ADNPBHMJCMC / 2f;
	}

	public void __BB_OBFUSCATOR_74(float ADNPBHMJCMC)
	{
		float num = GetComponent<Animation>()[BKOOPGNLMBD].clip.length + GetComponent<Animation>()[PPIFFDBEBNM].clip.length * IMBHOHOBPLO + GetComponent<Animation>()[FMAJAKCHFBH].clip.length;
		AnimationState animationState = GetComponent<Animation>().CrossFadeQueued(BKOOPGNLMBD);
		animationState.speed = num / ADNPBHMJCMC / 1032f;
		for (int i = 0; (float)i < IMBHOHOBPLO; i++)
		{
			AnimationState animationState2 = GetComponent<Animation>().CrossFadeQueued(PPIFFDBEBNM);
			animationState2.speed = num / ADNPBHMJCMC / 1375f;
		}
		AnimationState animationState3 = GetComponent<Animation>().CrossFadeQueued(FMAJAKCHFBH);
		animationState3.speed = num / ADNPBHMJCMC / 976f;
	}

	private void __BB_OBFUSCATOR_12()
	{
		GetComponent<Animation>().Play(JCAIKGGDFOF);
		GetComponent<Animation>()[JCAIKGGDFOF].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[BKOOPGNLMBD].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[PPIFFDBEBNM].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[FMAJAKCHFBH].wrapMode = WrapMode.Once;
		GetComponent<Animation>()[JFGPOIHPPOJ].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[KGKGMENBLOE].wrapMode = WrapMode.Default;
		GetComponent<Animation>()[NFMNHIPCGFO].wrapMode = WrapMode.Default;
	}
}
