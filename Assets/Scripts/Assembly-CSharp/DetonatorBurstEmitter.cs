using UnityEngine;

public class DetonatorBurstEmitter : DetonatorComponent
{
	private ParticleEmitter DFLBOKHKNIC;

	private ParticleRenderer ACGDBIJGDFD;

	private ParticleAnimator NCJFNJMCDIE;

	private float FOOMKNGMOMN = 0.1300004f;

	private float KBGFHOJODBF = 1f;

	private Color LNKOBAPEIIM = Color.white;

	public float IFPIFLFJJGC = 1f;

	public float MFAPGCJPFFH = 1f;

	public float PMDFNMAAOIP = 2f;

	public bool INKDNPJMNEB;

	public bool CDFEDBKMHNK = true;

	public float EKKCIFKDCNC;

	public float HPKOOPBINIH = 1f;

	public float FGMDPKFFANG = 1f;

	public float NMPKCAOOHIJ = 20f;

	public bool HBNEHNACADK = true;

	public float HEKGFKJHMFJ;

	public bool MJHAPHHGGHI = true;

	public float NJGDFDGPNLN;

	public float KMALMFPFAIP = 20f;

	public bool LFJCINCGOKF = true;

	public ParticleRenderMode CJHNCFAGLIG;

	public bool AIELAFCIBBM;

	public Color[] CJFAMIBMHGK = new Color[5];

	private bool CEGBKJGOLBO;

	private float PFGJDPDJOML;

	public Material MFOLDHOAMNN;

	private float GGDJGFEIMOM;

	private float DBJLMBHEMDG = 3f;

	private float IOBDMKHJKGG = 0.1f;

	private static float CMGAKBKGIPL = 0.01f;

	private float HNLHLJIMHEB;

	private Vector3 OKKKGLNAGEP;

	private Vector3 BBIIOIKLEOO;

	private Vector3 IHJFIILBODA;

	private float OBCEEKIFJKH;

	private float MOLKGDCDEMO;

	private float CLOHJBJHJIN;

	private float ONGHMMBINEI;

	private float MPPJKAAHKFN;

	private float LGOMPPHFGIM;

	private float AAMIIHKCKBI;

	private float CGENIDCFIKL;

	public virtual void __BB_OBFUSCATOR_84()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1425f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[7];
				colorAnimation[8] = CJFAMIBMHGK[2];
				colorAnimation[1] = CJFAMIBMHGK[2];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1401f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 280f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1146f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 473f);
				colorAnimation[3] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 215f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1201f)
			{
				MOLKGDCDEMO = 282f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(87f, 1624f, 1116f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1354f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1468f, 1536f);
					CGENIDCFIKL = Random.Range(1752f, 1621f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1978f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1117f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_18(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_56(num);
			float sizeGrow = (num3 / num2 - 120f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1649f)
			{
				Explode();
			}
		}
	}

	private void Update()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = SizeFunction(num - CMGAKBKGIPL);
			float num3 = SizeFunction(num);
			float sizeGrow = (num3 / num2 - 1f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 0f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_77()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = (HideFlags)126;
		ACGDBIJGDFD.hideFlags = (HideFlags)99;
		NCJFNJMCDIE.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = true;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	private float __BB_OBFUSCATOR_18(float COGBKJMIKCI)
	{
		float num = 1788f - 1088f / (1585f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1738f - IOBDMKHJKGG) * num;
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_51(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_30(num);
			float sizeGrow = (num3 / num2 - 578f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1488f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_30(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_40(num);
			float sizeGrow = (num3 / num2 - 739f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 809f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_9(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_9(num);
			float sizeGrow = (num3 / num2 - 1683f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1541f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_53()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		ACGDBIJGDFD.hideFlags = (HideFlags)81;
		NCJFNJMCDIE.hideFlags = (HideFlags)(-79);
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = true;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_52(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_52(num);
			float sizeGrow = (num3 / num2 - 1073f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 994f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_26()
	{
		MonoBehaviour.print("6");
	}

	public void __BB_OBFUSCATOR_13()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public void __BB_OBFUSCATOR_80()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		ACGDBIJGDFD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		NCJFNJMCDIE.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = false;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public void __BB_OBFUSCATOR_29()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = (HideFlags)(-113);
		ACGDBIJGDFD.hideFlags = (HideFlags)(-68);
		NCJFNJMCDIE.hideFlags = (HideFlags)103;
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = false;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_85()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 460f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[6] = CJFAMIBMHGK[8];
				colorAnimation[4] = CJFAMIBMHGK[6];
				colorAnimation[3] = CJFAMIBMHGK[2];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1746f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1431f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 479f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1440f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1108f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1686f)
			{
				MOLKGDCDEMO = 1627f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(580f, 1357f, 29f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 647f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1427f, 134f);
					CGENIDCFIKL = Random.Range(579f, 758f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 772f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1308f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public override void Init()
	{
		MonoBehaviour.print("UNUSED");
	}

	public virtual void __BB_OBFUSCATOR_97()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1822f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[6];
				colorAnimation[2] = CJFAMIBMHGK[2];
				colorAnimation[6] = CJFAMIBMHGK[1];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1906f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1569f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1020f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 379f);
				colorAnimation[4] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 933f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1439f)
			{
				MOLKGDCDEMO = 101f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1792f, 943f, 258f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1812f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(306f, 1817f);
					CGENIDCFIKL = Random.Range(1275f, 847f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1777f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 414f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_58()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 243f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[8] = CJFAMIBMHGK[7];
				colorAnimation[5] = CJFAMIBMHGK[4];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1205f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1093f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 753f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 481f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1140f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 879f)
			{
				MOLKGDCDEMO = 921f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1605f, 807f, 1455f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1090f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(780f, 1605f);
					CGENIDCFIKL = Random.Range(984f, 703f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1057f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1708f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_96()
	{
		MonoBehaviour.print("mm)");
	}

	public virtual void __BB_OBFUSCATOR_60()
	{
		MonoBehaviour.print("team2");
	}

	public void __BB_OBFUSCATOR_46()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private void __BB_OBFUSCATOR_87()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_40(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_56(num);
			float sizeGrow = (num3 / num2 - 1149f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1708f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_62()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1409f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[4];
				colorAnimation[6] = CJFAMIBMHGK[7];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1132f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1298f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 925f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1174f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 163f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1437f)
			{
				MOLKGDCDEMO = 682f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1510f, 1287f, 811f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1017f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(3f, 1676f);
					CGENIDCFIKL = Random.Range(1735f, 1614f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1272f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 576f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_52(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_9(num);
			float sizeGrow = (num3 / num2 - 1661f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1302f)
			{
				Explode();
			}
		}
	}

	private float __BB_OBFUSCATOR_42(float COGBKJMIKCI)
	{
		float num = 990f - 424f / (679f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1472f - IOBDMKHJKGG) * num;
	}

	public void __BB_OBFUSCATOR_95()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_42(num - CMGAKBKGIPL);
			float num3 = SizeFunction(num);
			float sizeGrow = (num3 / num2 - 126f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1702f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = SizeFunction(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_51(num);
			float sizeGrow = (num3 / num2 - 1496f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 291f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_20(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_52(num);
			float sizeGrow = (num3 / num2 - 1736f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1492f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_23()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 527f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[4] = CJFAMIBMHGK[1];
				colorAnimation[8] = CJFAMIBMHGK[8];
				colorAnimation[2] = CJFAMIBMHGK[1];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1460f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 923f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 567f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1523f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 65f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 185f)
			{
				MOLKGDCDEMO = 1627f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1222f, 1236f, 1028f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 202f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1991f, 1449f);
					CGENIDCFIKL = Random.Range(1436f, 1315f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 225f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 523f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_19()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public virtual void __BB_OBFUSCATOR_73()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1394f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[2] = CJFAMIBMHGK[7];
				colorAnimation[2] = CJFAMIBMHGK[4];
				colorAnimation[7] = CJFAMIBMHGK[0];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 28f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 292f);
				colorAnimation[5] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1051f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1253f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 915f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 781f)
			{
				MOLKGDCDEMO = 50f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1020f, 697f, 1234f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1105f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(530f, 1942f);
					CGENIDCFIKL = Random.Range(175f, 1985f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 164f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 628f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_20(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_9(num);
			float sizeGrow = (num3 / num2 - 1056f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 815f)
			{
				Explode();
			}
		}
	}

	private float __BB_OBFUSCATOR_0(float COGBKJMIKCI)
	{
		float num = 1631f - 242f / (767f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (659f - IOBDMKHJKGG) * num;
	}

	public void __BB_OBFUSCATOR_50()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = (HideFlags)80;
		ACGDBIJGDFD.hideFlags = (HideFlags)110;
		NCJFNJMCDIE.hideFlags = (HideFlags)64;
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = false;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_45()
	{
		MonoBehaviour.print("_Radius");
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_52(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_17(num);
			float sizeGrow = (num3 / num2 - 1985f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 352f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_74()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private float __BB_OBFUSCATOR_9(float COGBKJMIKCI)
	{
		float num = 186f - 1264f / (244f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1082f - IOBDMKHJKGG) * num;
	}

	public void __BB_OBFUSCATOR_83()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		ACGDBIJGDFD.hideFlags = (HideFlags)73;
		NCJFNJMCDIE.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = true;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_76()
	{
		MonoBehaviour.print("Concrete");
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_51(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_56(num);
			float sizeGrow = (num3 / num2 - 1953f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1476f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_57()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 879f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[4];
				colorAnimation[6] = CJFAMIBMHGK[5];
				colorAnimation[1] = CJFAMIBMHGK[0];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 808f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 956f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 677f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1221f);
				colorAnimation[5] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 475f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1285f)
			{
				MOLKGDCDEMO = 1971f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(600f, 958f, 1843f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 641f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(847f, 927f);
					CGENIDCFIKL = Random.Range(437f, 1663f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 614f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1508f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private float __BB_OBFUSCATOR_20(float COGBKJMIKCI)
	{
		float num = 25f - 1723f / (412f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (715f - IOBDMKHJKGG) * num;
	}

	public virtual void __BB_OBFUSCATOR_12()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1095f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[4] = CJFAMIBMHGK[1];
				colorAnimation[0] = CJFAMIBMHGK[7];
				colorAnimation[2] = CJFAMIBMHGK[1];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 233f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1865f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1231f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 392f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1925f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1898f)
			{
				MOLKGDCDEMO = 936f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(210f, 1811f, 1120f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1220f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1747f, 608f);
					CGENIDCFIKL = Random.Range(628f, 1901f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 4f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 287f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private float __BB_OBFUSCATOR_56(float COGBKJMIKCI)
	{
		float num = 1923f - 1033f / (927f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1266f - IOBDMKHJKGG) * num;
	}

	public void __BB_OBFUSCATOR_49()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_52(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_56(num);
			float sizeGrow = (num3 / num2 - 1344f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1368f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_81()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = (HideFlags)(-105);
		ACGDBIJGDFD.hideFlags = (HideFlags)87;
		NCJFNJMCDIE.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = true;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	private float __BB_OBFUSCATOR_51(float COGBKJMIKCI)
	{
		float num = 1216f - 1222f / (186f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (520f - IOBDMKHJKGG) * num;
	}

	private float __BB_OBFUSCATOR_52(float COGBKJMIKCI)
	{
		float num = 220f - 1485f / (860f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1291f - IOBDMKHJKGG) * num;
	}

	public void __BB_OBFUSCATOR_3()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public virtual void __BB_OBFUSCATOR_4()
	{
		MonoBehaviour.print("_Value");
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_40(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_42(num);
			float sizeGrow = (num3 / num2 - 424f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 468f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_61()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 946f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[4] = CJFAMIBMHGK[4];
				colorAnimation[7] = CJFAMIBMHGK[0];
				colorAnimation[2] = CJFAMIBMHGK[1];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1050f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1340f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1774f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1149f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 737f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1949f)
			{
				MOLKGDCDEMO = 1075f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(741f, 1424f, 1106f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1669f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1392f, 241f);
					CGENIDCFIKL = Random.Range(666f, 1740f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 244f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1906f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_79()
	{
		MonoBehaviour.print("_Threshhold");
	}

	public virtual void __BB_OBFUSCATOR_6()
	{
		MonoBehaviour.print("_Bullet_3");
	}

	public virtual void __BB_OBFUSCATOR_82()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 761f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[5] = CJFAMIBMHGK[7];
				colorAnimation[0] = CJFAMIBMHGK[7];
				colorAnimation[8] = CJFAMIBMHGK[7];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1803f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 234f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 938f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1152f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1085f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 944f)
			{
				MOLKGDCDEMO = 973f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(766f, 639f, 69f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 198f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(654f, 567f);
					CGENIDCFIKL = Random.Range(817f, 772f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 656f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 92f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_78()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		ACGDBIJGDFD.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NCJFNJMCDIE.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = true;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public void __BB_OBFUSCATOR_91()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public virtual void __BB_OBFUSCATOR_8()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1380f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[5] = CJFAMIBMHGK[8];
				colorAnimation[6] = CJFAMIBMHGK[6];
				colorAnimation[7] = CJFAMIBMHGK[3];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 151f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1870f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 614f);
				colorAnimation[5] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 480f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1152f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1484f)
			{
				MOLKGDCDEMO = 1918f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(494f, 268f, 1370f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 496f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1585f, 632f);
					CGENIDCFIKL = Random.Range(345f, 1286f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 765f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 908f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_9(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_52(num);
			float sizeGrow = (num3 / num2 - 860f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1259f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_1()
	{
		MonoBehaviour.print(" for incoming message event not found.");
	}

	public void __BB_OBFUSCATOR_72()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private float SizeFunction(float COGBKJMIKCI)
	{
		float num = 1f - 1f / (1f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (1f - IOBDMKHJKGG) * num;
	}

	private float __BB_OBFUSCATOR_40(float COGBKJMIKCI)
	{
		float num = 1403f - 739f / (1409f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (512f - IOBDMKHJKGG) * num;
	}

	public virtual void __BB_OBFUSCATOR_31()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 972f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[0] = CJFAMIBMHGK[7];
				colorAnimation[4] = CJFAMIBMHGK[4];
				colorAnimation[6] = CJFAMIBMHGK[2];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 597f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1310f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1028f);
				colorAnimation[3] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 62f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 384f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 615f)
			{
				MOLKGDCDEMO = 1705f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1049f, 138f, 1104f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1763f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(558f, 1812f);
					CGENIDCFIKL = Random.Range(631f, 1019f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 445f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 167f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 245f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[2] = CJFAMIBMHGK[6];
				colorAnimation[7] = CJFAMIBMHGK[1];
				colorAnimation[7] = CJFAMIBMHGK[4];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1649f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 2f);
				colorAnimation[4] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 654f);
				colorAnimation[8] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 170f);
				colorAnimation[3] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 225f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 225f)
			{
				MOLKGDCDEMO = 1441f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(1779f, 216f, 1884f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1111f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(918f, 250f);
					CGENIDCFIKL = Random.Range(786f, 94f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 407f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 171f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private float __BB_OBFUSCATOR_17(float COGBKJMIKCI)
	{
		float num = 1306f - 181f / (1362f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (361f - IOBDMKHJKGG) * num;
	}

	public virtual void __BB_OBFUSCATOR_41()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 620f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[2] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[4];
				colorAnimation[4] = CJFAMIBMHGK[3];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1954f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 780f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1471f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 931f);
				colorAnimation[7] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1071f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 954f)
			{
				MOLKGDCDEMO = 911f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(2f, 594f, 1861f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 689f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1988f, 554f);
					CGENIDCFIKL = Random.Range(1059f, 792f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1107f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1781f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = SizeFunction(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_17(num);
			float sizeGrow = (num3 / num2 - 1810f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 660f)
			{
				Explode();
			}
		}
	}

	public override void Explode()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 0f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[2] = CJFAMIBMHGK[2];
				colorAnimation[3] = CJFAMIBMHGK[3];
				colorAnimation[4] = CJFAMIBMHGK[4];
			}
			else
			{
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 0.7f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1f);
				colorAnimation[2] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 0.5f);
				colorAnimation[3] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 0.3f);
				colorAnimation[4] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 0f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 1f)
			{
				MOLKGDCDEMO = 1f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(0f, 0f, 0f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 2f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(-1f, 1f);
					CGENIDCFIKL = Random.Range(-1f, 1f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 0f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 0f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private float __BB_OBFUSCATOR_30(float COGBKJMIKCI)
	{
		float num = 25f - 40f / (964f + COGBKJMIKCI * DBJLMBHEMDG);
		return IOBDMKHJKGG + (585f - IOBDMKHJKGG) * num;
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
		MonoBehaviour.print("Flashlight");
	}

	public virtual void __BB_OBFUSCATOR_38()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 389f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[1] = CJFAMIBMHGK[1];
				colorAnimation[5] = CJFAMIBMHGK[7];
				colorAnimation[7] = CJFAMIBMHGK[3];
				colorAnimation[4] = CJFAMIBMHGK[3];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1251f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 265f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 664f);
				colorAnimation[4] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1026f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1495f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 256f)
			{
				MOLKGDCDEMO = 1965f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(293f, 72f, 1481f);
			}
			for (int i = 1; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1678f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(814f, 1724f);
					CGENIDCFIKL = Random.Range(1999f, 1336f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 263f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 766f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_92()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public void __BB_OBFUSCATOR_14()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public void Reset()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (HBNEHNACADK)
		{
			float num = Time.time - GGDJGFEIMOM;
			float num2 = __BB_OBFUSCATOR_9(num - CMGAKBKGIPL);
			float num3 = __BB_OBFUSCATOR_52(num);
			float sizeGrow = (num3 / num2 - 1857f) / CMGAKBKGIPL;
			NCJFNJMCDIE.sizeGrow = sizeGrow;
		}
		else
		{
			NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		}
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1874f)
			{
				Explode();
			}
		}
	}

	public void Awake()
	{
		DFLBOKHKNIC = base.gameObject.AddComponent<EllipsoidParticleEmitter>();
		ACGDBIJGDFD = base.gameObject.AddComponent<ParticleRenderer>();
		NCJFNJMCDIE = base.gameObject.AddComponent<ParticleAnimator>();
		DFLBOKHKNIC.hideFlags = HideFlags.HideAndDontSave;
		ACGDBIJGDFD.hideFlags = HideFlags.HideAndDontSave;
		NCJFNJMCDIE.hideFlags = HideFlags.HideAndDontSave;
		NCJFNJMCDIE.damping = FOOMKNGMOMN;
		DFLBOKHKNIC.emit = false;
		ACGDBIJGDFD.maxParticleSize = PMDFNMAAOIP;
		ACGDBIJGDFD.material = MFOLDHOAMNN;
		ACGDBIJGDFD.material.color = Color.white;
		NCJFNJMCDIE.sizeGrow = NMPKCAOOHIJ;
		if (INKDNPJMNEB)
		{
			Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_69()
	{
		MonoBehaviour.print("_Value");
	}

	public virtual void __BB_OBFUSCATOR_11()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1222f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[1] = CJFAMIBMHGK[0];
				colorAnimation[0] = CJFAMIBMHGK[0];
				colorAnimation[1] = CJFAMIBMHGK[6];
				colorAnimation[2] = CJFAMIBMHGK[8];
				colorAnimation[6] = CJFAMIBMHGK[7];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 900f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1653f);
				colorAnimation[3] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1034f);
				colorAnimation[5] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 335f);
				colorAnimation[4] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1737f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 188f)
			{
				MOLKGDCDEMO = 192f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(899f, 901f, 1840f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i++)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1591f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(284f, 1872f);
					CGENIDCFIKL = Random.Range(848f, 1403f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1709f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 688f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_47()
	{
		EEDMLOPHDJA = KBGFHOJODBF;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFPIFLFJJGC = FOOMKNGMOMN;
	}

	public virtual void __BB_OBFUSCATOR_21()
	{
		if (!GMAIEMJKMJD)
		{
			return;
		}
		DFLBOKHKNIC.useWorldSpace = MJHAPHHGGHI;
		CLOHJBJHJIN = PJKHHCHLFIF * LCLHCEHHBNM;
		ONGHMMBINEI = PJKHHCHLFIF * HEKGFKJHMFJ;
		MPPJKAAHKFN = EEDMLOPHDJA * MFAPGCJPFFH;
		ACGDBIJGDFD.particleRenderMode = CJHNCFAGLIG;
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 448f)
		{
			Color[] colorAnimation = NCJFNJMCDIE.colorAnimation;
			if (AIELAFCIBBM)
			{
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[0] = CJFAMIBMHGK[1];
				colorAnimation[4] = CJFAMIBMHGK[3];
				colorAnimation[5] = CJFAMIBMHGK[0];
				colorAnimation[5] = CJFAMIBMHGK[3];
			}
			else
			{
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 26f);
				colorAnimation[0] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1211f);
				colorAnimation[5] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 372f);
				colorAnimation[6] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 505f);
				colorAnimation[1] = new Color(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b, IOFNOJHNJAJ.a * 1647f);
			}
			NCJFNJMCDIE.colorAnimation = colorAnimation;
			ACGDBIJGDFD.material = MFOLDHOAMNN;
			NCJFNJMCDIE.force = ICPDBNNPACO;
			MOLKGDCDEMO = FGMDPKFFANG * NCGMMIBMBEL;
			if (MOLKGDCDEMO < 227f)
			{
				MOLKGDCDEMO = 640f;
			}
			if (DFLBOKHKNIC.useWorldSpace)
			{
				IHJFIILBODA = base.gameObject.transform.position;
			}
			else
			{
				IHJFIILBODA = new Vector3(915f, 1842f, 1216f);
			}
			for (int i = 0; (float)i <= MOLKGDCDEMO; i += 0)
			{
				OKKKGLNAGEP = Vector3.Scale(Random.insideUnitSphere, new Vector3(MPPJKAAHKFN, MPPJKAAHKFN, MPPJKAAHKFN));
				OKKKGLNAGEP = IHJFIILBODA + OKKKGLNAGEP;
				BBIIOIKLEOO = Vector3.Scale(Random.insideUnitSphere, new Vector3(PACAMLAINIK.x, PACAMLAINIK.y, PACAMLAINIK.z));
				BBIIOIKLEOO.y += 1414f * (Mathf.Abs(BBIIOIKLEOO.y) * NJGDFDGPNLN);
				if (LFJCINCGOKF)
				{
					AAMIIHKCKBI = Random.Range(1299f, 368f);
					CGENIDCFIKL = Random.Range(1873f, 906f) * KMALMFPFAIP;
				}
				else
				{
					AAMIIHKCKBI = 1460f;
					CGENIDCFIKL = KMALMFPFAIP;
				}
				BBIIOIKLEOO = Vector3.Scale(BBIIOIKLEOO, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
				HNLHLJIMHEB = EEDMLOPHDJA * (HPKOOPBINIH + Random.value * EKKCIFKDCNC);
				OBCEEKIFJKH = CLOHJBJHJIN + Random.value * ONGHMMBINEI;
				DFLBOKHKNIC.Emit(OKKKGLNAGEP, BBIIOIKLEOO, HNLHLJIMHEB, OBCEEKIFJKH, IOFNOJHNJAJ, AAMIIHKCKBI, CGENIDCFIKL);
			}
			GGDJGFEIMOM = Time.time;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 223f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}
}
