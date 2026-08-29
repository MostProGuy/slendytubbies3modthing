using UnityEngine;

[AddComponentMenu("Detonator/Glow")]
[RequireComponent(typeof(Detonator))]
public class DetonatorGlow : DetonatorComponent
{
	private float KBGFHOJODBF = 1f;

	private float BNCCIDBIPBF = 3f;

	private Vector3 KNEAEEDKCGD = new Vector3(0f, 0f, 0f);

	private Color LNKOBAPEIIM = Color.black;

	private float CLOHJBJHJIN;

	private GameObject AIEKFKBMNFI;

	private DetonatorBurstEmitter DEMNLFCDBJC;

	public Material NENOJAIPONP;

	public void __BB_OBFUSCATOR_2()
	{
		__BB_OBFUSCATOR_115(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1289f;
		DHMOAEAKEBD = 867f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	private void __BB_OBFUSCATOR_67()
	{
	}

	public virtual void __BB_OBFUSCATOR_124()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_57();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_53()
	{
		__BB_OBFUSCATOR_86(false);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1923f;
		DHMOAEAKEBD = 1050f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public void __BB_OBFUSCATOR_105()
	{
		AIEKFKBMNFI = new GameObject("MP");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_88()
	{
		AIEKFKBMNFI = new GameObject("_MainTex");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	private void __BB_OBFUSCATOR_34()
	{
	}

	public void __BB_OBFUSCATOR_57()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 904f;
		DEMNLFCDBJC.HPKOOPBINIH = 1546f;
		DEMNLFCDBJC.EKKCIFKDCNC = 340f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1572f, 347f, 567f);
		DEMNLFCDBJC.MFAPGCJPFFH = 316f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1560f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1486f, 1842f, 144f, 1535f), 1752f);
		color.a = 1955f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(592f, 194f, 1026f, 1550f), 545f);
		color2.a = 33f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(260f, 638f, 247f, 150f), 804f);
		color3.a = 1223f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(520f, 799f, 1397f, 1288f), 1210f);
		color4.a = 1380f;
		Color color5 = new Color(1052f, 917f, 1626f, 1213f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color5;
	}

	public override void Explode()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateGlow();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_45()
	{
		AIEKFKBMNFI = new GameObject("PublishMessage parameters must be non-null and not empty.");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public virtual void __BB_OBFUSCATOR_106()
	{
		__BB_OBFUSCATOR_116(false);
		__BB_OBFUSCATOR_131();
	}

	public void __BB_OBFUSCATOR_138(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_43()
	{
		FillMaterials(true);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1124f;
		DHMOAEAKEBD = 500f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	private void __BB_OBFUSCATOR_70()
	{
	}

	public virtual void __BB_OBFUSCATOR_127()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_121();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_90()
	{
		FillMaterials(true);
		__BB_OBFUSCATOR_23();
	}

	public void __BB_OBFUSCATOR_136()
	{
		AIEKFKBMNFI = new GameObject(",");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_55()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 708f;
		DEMNLFCDBJC.HPKOOPBINIH = 824f;
		DEMNLFCDBJC.EKKCIFKDCNC = 422f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(103f, 336f, 1027f);
		DEMNLFCDBJC.MFAPGCJPFFH = 694f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1272f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(23f, 1524f, 494f, 1423f), 1946f);
		color.a = 1133f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(480f, 1391f, 1117f, 412f), 1242f);
		color2.a = 1362f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1178f, 163f, 1874f, 1452f), 1485f);
		color3.a = 202f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1128f, 441f, 1696f, 1233f), 1943f);
		color4.a = 974f;
		Color color5 = new Color(127f, 1279f, 728f, 1097f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color5;
	}

	private void __BB_OBFUSCATOR_79()
	{
	}

	public virtual void __BB_OBFUSCATOR_46()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_41();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_113()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 641f;
		DEMNLFCDBJC.HPKOOPBINIH = 1060f;
		DEMNLFCDBJC.EKKCIFKDCNC = 25f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1690f, 895f, 600f);
		DEMNLFCDBJC.MFAPGCJPFFH = 868f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 565f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1175f, 1404f, 1057f, 476f), 940f);
		color.a = 502f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(239f, 396f, 651f, 1074f), 1436f);
		color2.a = 165f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1985f, 1125f, 814f, 1867f), 874f);
		color3.a = 547f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1498f, 325f, 7f, 552f), 1761f);
		color4.a = 1464f;
		Color color5 = new Color(1730f, 399f, 142f, 378f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[7] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color5;
	}

	public void __BB_OBFUSCATOR_75(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
	}

	public void __BB_OBFUSCATOR_135()
	{
		AIEKFKBMNFI = new GameObject("_VignetteTex");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_24()
	{
		__BB_OBFUSCATOR_5(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1152f;
		DHMOAEAKEBD = 629f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public void __BB_OBFUSCATOR_107()
	{
		AIEKFKBMNFI = new GameObject("colorC");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public virtual void __BB_OBFUSCATOR_51()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_6();
			DEMNLFCDBJC.Explode();
		}
	}

	public void BuildGlow()
	{
		AIEKFKBMNFI = new GameObject("Glow");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_104()
	{
		__BB_OBFUSCATOR_115(true);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 438f;
		DHMOAEAKEBD = 54f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_103()
	{
		__BB_OBFUSCATOR_71(true);
		__BB_OBFUSCATOR_105();
	}

	public void __BB_OBFUSCATOR_47()
	{
		AIEKFKBMNFI = new GameObject("Mouse Y");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_27()
	{
		__BB_OBFUSCATOR_75(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1788f;
		DHMOAEAKEBD = 1236f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_63()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_19();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_11()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_41();
			DEMNLFCDBJC.Explode();
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
	}

	public void __BB_OBFUSCATOR_33()
	{
		AIEKFKBMNFI = new GameObject("_ColorB");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_17()
	{
		__BB_OBFUSCATOR_54(false);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1692f;
		DHMOAEAKEBD = 1644f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_42()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_80();
			DEMNLFCDBJC.Explode();
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
	}

	public virtual void __BB_OBFUSCATOR_29()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_125();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_4()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_99();
			DEMNLFCDBJC.Explode();
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
	}

	public void __BB_OBFUSCATOR_94()
	{
		AIEKFKBMNFI = new GameObject("COOP");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	private void Update()
	{
	}

	private void __BB_OBFUSCATOR_91()
	{
	}

	public virtual void __BB_OBFUSCATOR_12()
	{
		__BB_OBFUSCATOR_116(false);
		__BB_OBFUSCATOR_131();
	}

	public void Reset()
	{
		FillMaterials(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 0f;
		DHMOAEAKEBD = 0f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_83()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_57();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_134()
	{
		__BB_OBFUSCATOR_75(false);
		__BB_OBFUSCATOR_120();
	}

	public void __BB_OBFUSCATOR_20()
	{
		AIEKFKBMNFI = new GameObject("Connected! Creating Room...");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public virtual void __BB_OBFUSCATOR_130()
	{
		__BB_OBFUSCATOR_54(false);
		__BB_OBFUSCATOR_59();
	}

	public void __BB_OBFUSCATOR_59()
	{
		AIEKFKBMNFI = new GameObject("Resume");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_81()
	{
		__BB_OBFUSCATOR_75(false);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 277f;
		DHMOAEAKEBD = 803f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	private void __BB_OBFUSCATOR_82()
	{
	}

	public void __BB_OBFUSCATOR_41()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1263f;
		DEMNLFCDBJC.HPKOOPBINIH = 214f;
		DEMNLFCDBJC.EKKCIFKDCNC = 727f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1125f, 40f, 917f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1128f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 326f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(904f, 317f, 1391f, 989f), 1950f);
		color.a = 42f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(414f, 835f, 1236f, 573f), 527f);
		color2.a = 730f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(861f, 566f, 567f, 54f), 249f);
		color3.a = 294f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1196f, 892f, 833f, 431f), 41f);
		color4.a = 839f;
		Color color5 = new Color(1345f, 1159f, 744f, 824f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color5;
	}

	public void __BB_OBFUSCATOR_120()
	{
		AIEKFKBMNFI = new GameObject("_NormalTex");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_1()
	{
		AIEKFKBMNFI = new GameObject("DM");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	private void __BB_OBFUSCATOR_114()
	{
	}

	public void __BB_OBFUSCATOR_23()
	{
		AIEKFKBMNFI = new GameObject("networkAddMessage");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_74()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 407f;
		DEMNLFCDBJC.HPKOOPBINIH = 1955f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1006f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1445f, 1954f, 1904f);
		DEMNLFCDBJC.MFAPGCJPFFH = 870f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 203f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(920f, 283f, 204f, 1247f), 1908f);
		color.a = 1631f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(935f, 231f, 1289f, 1305f), 1125f);
		color2.a = 1887f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1095f, 1536f, 462f, 1329f), 1831f);
		color3.a = 400f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1103f, 1903f, 283f, 1331f), 1993f);
		color4.a = 822f;
		Color color5 = new Color(742f, 1118f, 718f, 1076f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[7] = color5;
	}

	public void __BB_OBFUSCATOR_72(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_137()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1590f;
		DEMNLFCDBJC.HPKOOPBINIH = 1456f;
		DEMNLFCDBJC.EKKCIFKDCNC = 722f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(51f, 888f, 1106f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1026f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 220f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1283f, 1973f, 351f, 1486f), 282f);
		color.a = 1285f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(669f, 1638f, 1284f, 755f), 245f);
		color2.a = 516f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(3f, 1891f, 1072f, 1745f), 457f);
		color3.a = 1670f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(827f, 1220f, 69f, 531f), 1481f);
		color4.a = 282f;
		Color color5 = new Color(1467f, 1954f, 184f, 372f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[5] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[6] = color5;
	}

	public void __BB_OBFUSCATOR_16()
	{
		__BB_OBFUSCATOR_77(true);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1130f;
		DHMOAEAKEBD = 18f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public void __BB_OBFUSCATOR_112(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public virtual void __BB_OBFUSCATOR_44()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateGlow();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_128()
	{
		__BB_OBFUSCATOR_86(true);
		__BB_OBFUSCATOR_35();
	}

	public void __BB_OBFUSCATOR_58()
	{
		AIEKFKBMNFI = new GameObject("You");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_56()
	{
		AIEKFKBMNFI = new GameObject("CameraFilterPack/Colors_HSV");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public virtual void __BB_OBFUSCATOR_123()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_19();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_115(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public virtual void __BB_OBFUSCATOR_97()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateGlow();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_66()
	{
		__BB_OBFUSCATOR_30(false);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 372f;
		DHMOAEAKEBD = 0f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	private void __BB_OBFUSCATOR_69()
	{
	}

	public void __BB_OBFUSCATOR_64()
	{
		__BB_OBFUSCATOR_138(false);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 417f;
		DHMOAEAKEBD = 761f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public void __BB_OBFUSCATOR_65()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1099f;
		DEMNLFCDBJC.HPKOOPBINIH = 1585f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1212f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1887f, 727f, 878f);
		DEMNLFCDBJC.MFAPGCJPFFH = 914f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 363f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1713f, 1968f, 606f, 288f), 567f);
		color.a = 1226f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(146f, 1554f, 855f, 1960f), 1715f);
		color2.a = 841f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(264f, 723f, 1536f, 1291f), 229f);
		color3.a = 246f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1187f, 1215f, 1176f, 1405f), 417f);
		color4.a = 1629f;
		Color color5 = new Color(1109f, 774f, 512f, 430f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color5;
	}

	public void __BB_OBFUSCATOR_71(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void FillMaterials(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
	}

	public virtual void __BB_OBFUSCATOR_101()
	{
		__BB_OBFUSCATOR_138(true);
		__BB_OBFUSCATOR_131();
	}

	public void __BB_OBFUSCATOR_54(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
	}

	private void __BB_OBFUSCATOR_89()
	{
	}

	public void __BB_OBFUSCATOR_119()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1311f;
		DEMNLFCDBJC.HPKOOPBINIH = 173f;
		DEMNLFCDBJC.EKKCIFKDCNC = 724f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(395f, 376f, 1895f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1232f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 673f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1393f, 1815f, 1420f, 769f), 648f);
		color.a = 1748f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(300f, 1057f, 1515f, 1607f), 1524f);
		color2.a = 15f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(902f, 1153f, 629f, 29f), 906f);
		color3.a = 1804f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1200f, 854f, 1102f, 1316f), 474f);
		color4.a = 135f;
		Color color5 = new Color(768f, 1666f, 1919f, 1436f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color5;
	}

	public virtual void __BB_OBFUSCATOR_32()
	{
		__BB_OBFUSCATOR_72(true);
		__BB_OBFUSCATOR_49();
	}

	public void __BB_OBFUSCATOR_37()
	{
		AIEKFKBMNFI = new GameObject("_TimeX");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_61()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1343f;
		DEMNLFCDBJC.HPKOOPBINIH = 1096f;
		DEMNLFCDBJC.EKKCIFKDCNC = 407f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1195f, 595f, 753f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1469f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 475f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(438f, 1375f, 296f, 370f), 1149f);
		color.a = 2f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(777f, 1871f, 889f, 88f), 730f);
		color2.a = 808f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1385f, 1708f, 770f, 860f), 372f);
		color3.a = 1745f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1856f, 1527f, 940f, 538f), 759f);
		color4.a = 1770f;
		Color color5 = new Color(749f, 1839f, 879f, 1035f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[7] = color5;
	}

	public void __BB_OBFUSCATOR_6()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 780f;
		DEMNLFCDBJC.HPKOOPBINIH = 719f;
		DEMNLFCDBJC.EKKCIFKDCNC = 932f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1831f, 841f, 472f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1621f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1594f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(296f, 47f, 160f, 1107f), 547f);
		color.a = 1518f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(245f, 1870f, 968f, 405f), 1150f);
		color2.a = 1668f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1226f, 1060f, 1251f, 945f), 1873f);
		color3.a = 566f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(281f, 1028f, 1592f, 1723f), 1668f);
		color4.a = 1396f;
		Color color5 = new Color(1184f, 1422f, 955f, 884f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[7] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[5] = color5;
	}

	public void __BB_OBFUSCATOR_100()
	{
		__BB_OBFUSCATOR_75(true);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 934f;
		DHMOAEAKEBD = 1777f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_126()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_65();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_49()
	{
		AIEKFKBMNFI = new GameObject("SupplyHelicopter");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_131()
	{
		AIEKFKBMNFI = new GameObject("colorD");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = false;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public virtual void __BB_OBFUSCATOR_118()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_80();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_76()
	{
		__BB_OBFUSCATOR_78(false);
		__BB_OBFUSCATOR_1();
	}

	public void __BB_OBFUSCATOR_77(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_86(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public virtual void __BB_OBFUSCATOR_96()
	{
		__BB_OBFUSCATOR_86(false);
		BuildGlow();
	}

	public virtual void __BB_OBFUSCATOR_60()
	{
		__BB_OBFUSCATOR_30(true);
		BuildGlow();
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_125();
			DEMNLFCDBJC.Explode();
		}
	}

	public virtual void __BB_OBFUSCATOR_87()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_119();
			DEMNLFCDBJC.Explode();
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
	}

	public void __BB_OBFUSCATOR_13()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 312f;
		DEMNLFCDBJC.HPKOOPBINIH = 214f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1478f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(640f, 426f, 1487f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1615f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1806f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1266f, 536f, 1715f, 1088f), 1332f);
		color.a = 1691f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(257f, 75f, 507f, 1617f), 1456f);
		color2.a = 422f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1592f, 550f, 1560f, 904f), 634f);
		color3.a = 1128f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(263f, 598f, 1817f, 721f), 357f);
		color4.a = 972f;
		Color color5 = new Color(1793f, 211f, 492f, 1771f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color5;
	}

	public virtual void __BB_OBFUSCATOR_132()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_61();
			DEMNLFCDBJC.Explode();
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
	}

	public void __BB_OBFUSCATOR_92()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1354f;
		DEMNLFCDBJC.HPKOOPBINIH = 1342f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1038f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1779f, 1829f, 87f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1384f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1061f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(717f, 1653f, 179f, 1359f), 906f);
		color.a = 1358f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(166f, 1372f, 667f, 1660f), 163f);
		color2.a = 592f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(876f, 1030f, 386f, 850f), 1449f);
		color3.a = 996f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(344f, 704f, 379f, 1673f), 1973f);
		color4.a = 518f;
		Color color5 = new Color(1717f, 516f, 40f, 1872f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[6] = color5;
	}

	public virtual void __BB_OBFUSCATOR_73()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_92();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_48()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1374f;
		DEMNLFCDBJC.HPKOOPBINIH = 1239f;
		DEMNLFCDBJC.EKKCIFKDCNC = 174f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(429f, 465f, 204f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1261f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1855f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1748f, 1682f, 1098f, 557f), 341f);
		color.a = 126f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(825f, 844f, 1709f, 1262f), 270f);
		color2.a = 1026f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(255f, 1752f, 1504f, 1985f), 1067f);
		color3.a = 457f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1058f, 1513f, 509f, 1923f), 18f);
		color4.a = 873f;
		Color color5 = new Color(1348f, 1170f, 1166f, 250f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color5;
	}

	public void __BB_OBFUSCATOR_85()
	{
		AIEKFKBMNFI = new GameObject("TeamName");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = true;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_35()
	{
		AIEKFKBMNFI = new GameObject("n15");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void __BB_OBFUSCATOR_30(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_133()
	{
		__BB_OBFUSCATOR_117(true);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1683f;
		DHMOAEAKEBD = 1307f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public void __BB_OBFUSCATOR_116(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_52()
	{
		AIEKFKBMNFI = new GameObject("\n\t\t}\n\t\tMultiLayer: 0\n\t\tCulling: \"CullingOff\"\n\t\tTypeFlags: \"Skeleton\"\n\t}\n");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	public void UpdateGlow()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1f;
		DEMNLFCDBJC.HPKOOPBINIH = 65f;
		DEMNLFCDBJC.EKKCIFKDCNC = 0f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(0f, 0f, 0f);
		DEMNLFCDBJC.MFAPGCJPFFH = 0f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 0f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(0.5f, 0.1f, 0.1f, 1f), 0.5f);
		color.a = 0.9f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(0.6f, 0.3f, 0.3f, 1f), 0.5f);
		color2.a = 0.8f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(0.7f, 0.3f, 0.3f, 1f), 0.5f);
		color3.a = 0.5f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(0.4f, 0.3f, 0.4f, 1f), 0.5f);
		color4.a = 0.2f;
		Color color5 = new Color(0.1f, 0.1f, 0.4f, 0f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color5;
	}

	public void __BB_OBFUSCATOR_121()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 72f;
		DEMNLFCDBJC.HPKOOPBINIH = 1012f;
		DEMNLFCDBJC.EKKCIFKDCNC = 896f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1327f, 1273f, 940f);
		DEMNLFCDBJC.MFAPGCJPFFH = 876f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 187f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1575f, 1354f, 906f, 652f), 857f);
		color.a = 813f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(1069f, 217f, 1978f, 1924f), 1250f);
		color2.a = 1479f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1211f, 1707f, 808f, 162f), 1481f);
		color3.a = 1339f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(205f, 42f, 741f, 577f), 1798f);
		color4.a = 256f;
		Color color5 = new Color(1591f, 127f, 678f, 1525f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color5;
	}

	public void __BB_OBFUSCATOR_95(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_99()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1999f;
		DEMNLFCDBJC.HPKOOPBINIH = 1061f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1647f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(509f, 1881f, 438f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1696f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1216f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(1872f, 777f, 1490f, 113f), 1707f);
		color.a = 1134f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(293f, 1112f, 1676f, 385f), 491f);
		color2.a = 1720f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1863f, 804f, 339f, 1382f), 483f);
		color3.a = 209f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1760f, 1357f, 1580f, 435f), 169f);
		color4.a = 220f;
		Color color5 = new Color(1231f, 1560f, 1125f, 819f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color5;
	}

	public void __BB_OBFUSCATOR_78(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public virtual void __BB_OBFUSCATOR_109()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateGlow();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_9()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 83f;
		DEMNLFCDBJC.HPKOOPBINIH = 639f;
		DEMNLFCDBJC.EKKCIFKDCNC = 813f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(953f, 866f, 1419f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1568f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 584f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(812f, 1339f, 420f, 1266f), 147f);
		color.a = 654f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(1286f, 1213f, 859f, 433f), 195f);
		color2.a = 1289f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(990f, 1480f, 1470f, 1115f), 1992f);
		color3.a = 1868f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(804f, 503f, 1555f, 172f), 981f);
		color4.a = 976f;
		Color color5 = new Color(91f, 1294f, 707f, 996f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[6] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[5] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color5;
	}

	public void __BB_OBFUSCATOR_84()
	{
		AIEKFKBMNFI = new GameObject("Indexes");
		DEMNLFCDBJC = AIEKFKBMNFI.AddComponent<DetonatorBurstEmitter>();
		AIEKFKBMNFI.transform.parent = base.transform;
		AIEKFKBMNFI.transform.localPosition = BJGOJGBLDMN;
		DEMNLFCDBJC.MFOLDHOAMNN = NENOJAIPONP;
		DEMNLFCDBJC.HBNEHNACADK = false;
		DEMNLFCDBJC.AIELAFCIBBM = true;
		DEMNLFCDBJC.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
	}

	private void __BB_OBFUSCATOR_68()
	{
	}

	public virtual void __BB_OBFUSCATOR_3()
	{
		__BB_OBFUSCATOR_138(false);
		__BB_OBFUSCATOR_20();
	}

	public void __BB_OBFUSCATOR_117(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
	}

	private void __BB_OBFUSCATOR_102()
	{
	}

	public void __BB_OBFUSCATOR_125()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1722f;
		DEMNLFCDBJC.HPKOOPBINIH = 1653f;
		DEMNLFCDBJC.EKKCIFKDCNC = 40f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(209f, 1816f, 337f);
		DEMNLFCDBJC.MFAPGCJPFFH = 313f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 130f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(985f, 61f, 1149f, 1681f), 59f);
		color.a = 1353f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(1553f, 351f, 1102f, 1369f), 15f);
		color2.a = 1517f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(675f, 443f, 1167f, 1482f), 1585f);
		color3.a = 178f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1496f, 632f, 1741f, 184f), 1808f);
		color4.a = 815f;
		Color color5 = new Color(1000f, 1182f, 1395f, 746f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[7] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color5;
	}

	private void __BB_OBFUSCATOR_39()
	{
	}

	public override void Init()
	{
		FillMaterials(false);
		BuildGlow();
	}

	public void __BB_OBFUSCATOR_0()
	{
		__BB_OBFUSCATOR_30(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 1509f;
		DHMOAEAKEBD = 875f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	public virtual void __BB_OBFUSCATOR_111()
	{
		__BB_OBFUSCATOR_138(true);
		__BB_OBFUSCATOR_105();
	}

	public virtual void __BB_OBFUSCATOR_50()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_113();
			DEMNLFCDBJC.Explode();
		}
	}

	public void __BB_OBFUSCATOR_80()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1628f;
		DEMNLFCDBJC.HPKOOPBINIH = 103f;
		DEMNLFCDBJC.EKKCIFKDCNC = 1250f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(1425f, 1052f, 477f);
		DEMNLFCDBJC.MFAPGCJPFFH = 211f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1853f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(71f, 1949f, 726f, 1810f), 613f);
		color.a = 1371f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(1821f, 965f, 422f, 239f), 355f);
		color2.a = 109f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1349f, 238f, 1236f, 863f), 1025f);
		color3.a = 1662f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1402f, 923f, 323f, 898f), 138f);
		color4.a = 1425f;
		Color color5 = new Color(1183f, 967f, 1221f, 1805f);
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[8] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[2] = color5;
	}

	public void __BB_OBFUSCATOR_21()
	{
		__BB_OBFUSCATOR_78(false);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = KBGFHOJODBF;
		LCLHCEHHBNM = BNCCIDBIPBF;
		BHDOLBHLDGC = 393f;
		DHMOAEAKEBD = 1424f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = KNEAEEDKCGD;
	}

	private void __BB_OBFUSCATOR_14()
	{
	}

	public void __BB_OBFUSCATOR_5(bool PHDOMKDEDMO)
	{
		if (!NENOJAIPONP || PHDOMKDEDMO)
		{
			NENOJAIPONP = MyDetonator().NENOJAIPONP;
		}
	}

	public void __BB_OBFUSCATOR_19()
	{
		AIEKFKBMNFI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		DEMNLFCDBJC.IOFNOJHNJAJ = IOFNOJHNJAJ;
		DEMNLFCDBJC.LCLHCEHHBNM = LCLHCEHHBNM;
		DEMNLFCDBJC.PJKHHCHLFIF = PJKHHCHLFIF;
		DEMNLFCDBJC.FGMDPKFFANG = 1091f;
		DEMNLFCDBJC.HPKOOPBINIH = 1274f;
		DEMNLFCDBJC.EKKCIFKDCNC = 226f;
		DEMNLFCDBJC.PACAMLAINIK = new Vector3(848f, 1285f, 1021f);
		DEMNLFCDBJC.MFAPGCJPFFH = 1709f;
		DEMNLFCDBJC.NMPKCAOOHIJ = 1009f;
		DEMNLFCDBJC.EEDMLOPHDJA = EEDMLOPHDJA;
		DEMNLFCDBJC.BHDOLBHLDGC = BHDOLBHLDGC;
		DEMNLFCDBJC.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = Color.Lerp(IOFNOJHNJAJ, new Color(176f, 1383f, 1759f, 642f), 1606f);
		color.a = 1504f;
		Color color2 = Color.Lerp(IOFNOJHNJAJ, new Color(1949f, 1720f, 50f, 1064f), 1538f);
		color2.a = 1552f;
		Color color3 = Color.Lerp(IOFNOJHNJAJ, new Color(1611f, 1936f, 866f, 73f), 946f);
		color3.a = 1342f;
		Color color4 = Color.Lerp(IOFNOJHNJAJ, new Color(1741f, 1239f, 243f, 208f), 1972f);
		color4.a = 778f;
		Color color5 = new Color(1060f, 747f, 208f, 859f);
		DEMNLFCDBJC.CJFAMIBMHGK[1] = color;
		DEMNLFCDBJC.CJFAMIBMHGK[0] = color2;
		DEMNLFCDBJC.CJFAMIBMHGK[5] = color3;
		DEMNLFCDBJC.CJFAMIBMHGK[4] = color4;
		DEMNLFCDBJC.CJFAMIBMHGK[3] = color5;
	}
}
