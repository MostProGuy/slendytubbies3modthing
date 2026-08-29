using UnityEngine;

[AddComponentMenu("Detonator/Smoke")]
[RequireComponent(typeof(Detonator))]
public class DetonatorSmoke : DetonatorComponent
{
	private const float KBGFHOJODBF = 1f;

	private const float BNCCIDBIPBF = 8f;

	private Color LNKOBAPEIIM = new Color(0.5f, 0.5f, 0.5f, 0.5f);

	private const float FOOMKNGMOMN = 0.1300004f;

	private float CLOHJBJHJIN;

	private GameObject EEJNOCGFEAI;

	private DetonatorBurstEmitter EMDAMLDNFCK;

	public Material NLCJNPAMOEH;

	private GameObject HODOCPIKIBI;

	private DetonatorBurstEmitter IPGJLEEHBCO;

	public Material KDNNLMHFKOJ;

	public bool DNDCBMPPAPP = true;

	public bool HOMCEMGJDEN = true;

	public void __BB_OBFUSCATOR_40()
	{
		HODOCPIKIBI = new GameObject("n15");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 1611f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_77()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1014f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 600f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 349f;
		IPGJLEEHBCO.FGMDPKFFANG = 816f;
		IPGJLEEHBCO.HPKOOPBINIH = 592f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1574f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1211f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(752f, 305f, 531f, 1810f);
		Color color2 = new Color(1764f, 5f, 1305f, 117f);
		Color color3 = new Color(997f, 41f, 420f, 1699f);
		Color color4 = new Color(1431f, 1030f, 1468f, 1751f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[3] = color4;
	}

	public virtual void __BB_OBFUSCATOR_102()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_85();
			__BB_OBFUSCATOR_0();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_23()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_83();
			__BB_OBFUSCATOR_33();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_104()
	{
		__BB_OBFUSCATOR_4(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = 327f;
		LCLHCEHHBNM = 1453f;
		BHDOLBHLDGC = 1832f;
		DHMOAEAKEBD = 1449f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(1410f, 14f, 1872f);
	}

	public override void Init()
	{
		FillMaterials(false);
		BuildSmokeA();
		BuildSmokeB();
	}

	public void __BB_OBFUSCATOR_11()
	{
		EEJNOCGFEAI = new GameObject("AddFriends max list size exceeded: ");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 658f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_6()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1593f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 441f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1510f;
		IPGJLEEHBCO.FGMDPKFFANG = 1037f;
		IPGJLEEHBCO.HPKOOPBINIH = 1715f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1283f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1540f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1691f, 414f, 1583f, 515f);
		Color color2 = new Color(623f, 1797f, 1353f, 1665f);
		Color color3 = new Color(219f, 1953f, 1248f, 1190f);
		Color color4 = new Color(1286f, 1644f, 1602f, 1880f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color4;
	}

	public void __BB_OBFUSCATOR_41()
	{
		EEJNOCGFEAI = new GameObject("_TintColor");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 605f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_49()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_107();
			__BB_OBFUSCATOR_76();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_60()
	{
		HODOCPIKIBI = new GameObject("_Value");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 773f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_116()
	{
		__BB_OBFUSCATOR_29(false);
		__BB_OBFUSCATOR_19();
		__BB_OBFUSCATOR_74();
	}

	public virtual void __BB_OBFUSCATOR_27()
	{
		__BB_OBFUSCATOR_4(true);
		__BB_OBFUSCATOR_117();
		__BB_OBFUSCATOR_10();
	}

	public void __BB_OBFUSCATOR_19()
	{
		EEJNOCGFEAI = new GameObject("PrimaryCausticsProjector");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 195f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_90()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_24();
			__BB_OBFUSCATOR_51();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_75()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 268f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 652f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 469f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 258f;
		EMDAMLDNFCK.HPKOOPBINIH = 576f;
		EMDAMLDNFCK.EKKCIFKDCNC = 419f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1799f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(888f, 1237f, 311f, 235f);
		Color color2 = new Color(354f, 483f, 1120f, 23f);
		Color color3 = new Color(1185f, 110f, 397f, 950f);
		Color color4 = new Color(172f, 325f, 609f, 1924f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[7] = color4;
	}

	public virtual void __BB_OBFUSCATOR_42()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_46();
			UpdateSmokeB();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_68()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 632f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 634f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 1556f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 595f;
		EMDAMLDNFCK.HPKOOPBINIH = 1874f;
		EMDAMLDNFCK.EKKCIFKDCNC = 407f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1567f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(138f, 809f, 1326f, 1867f);
		Color color2 = new Color(1619f, 1678f, 1955f, 1270f);
		Color color3 = new Color(1818f, 267f, 1993f, 1133f);
		Color color4 = new Color(240f, 1606f, 1662f, 1245f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[7] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[3] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_15()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 756f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1207f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 114f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1148f;
		EMDAMLDNFCK.HPKOOPBINIH = 597f;
		EMDAMLDNFCK.EKKCIFKDCNC = 625f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1118f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1317f, 872f, 43f, 903f);
		Color color2 = new Color(1073f, 63f, 1143f, 1254f);
		Color color3 = new Color(1038f, 1282f, 1063f, 1752f);
		Color color4 = new Color(1290f, 1186f, 1799f, 447f);
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[8] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color4;
	}

	public virtual void __BB_OBFUSCATOR_38()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_86();
			__BB_OBFUSCATOR_77();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_64()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_107();
			__BB_OBFUSCATOR_6();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_45()
	{
		HODOCPIKIBI = new GameObject("SyncWeaponsRPC");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 726f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_31()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1575f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1742f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 625f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1358f;
		EMDAMLDNFCK.HPKOOPBINIH = 774f;
		EMDAMLDNFCK.EKKCIFKDCNC = 1360f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 850f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1811f, 1763f, 1304f, 305f);
		Color color2 = new Color(1072f, 155f, 808f, 761f);
		Color color3 = new Color(681f, 1956f, 72f, 742f);
		Color color4 = new Color(531f, 21f, 1056f, 327f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[5] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[8] = color4;
	}

	public void __BB_OBFUSCATOR_8()
	{
		HODOCPIKIBI = new GameObject("LegsURL");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 205f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_88()
	{
		HODOCPIKIBI = new GameObject("_TimeX");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 939f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_32()
	{
		HODOCPIKIBI = new GameObject("CustomSkin");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 1693f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_62()
	{
		HODOCPIKIBI = new GameObject("Fire1");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 1988f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_24()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 232f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1760f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 1908f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1119f;
		EMDAMLDNFCK.HPKOOPBINIH = 1214f;
		EMDAMLDNFCK.EKKCIFKDCNC = 894f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1796f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(731f, 1860f, 474f, 850f);
		Color color2 = new Color(1067f, 86f, 1329f, 220f);
		Color color3 = new Color(1726f, 1059f, 724f, 8f);
		Color color4 = new Color(1945f, 133f, 0f, 1061f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[3] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_67()
	{
		HODOCPIKIBI = new GameObject("CameraFilterPack/FX_EarthQuake");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 523f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_0()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1980f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 753f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 22f;
		IPGJLEEHBCO.FGMDPKFFANG = 1086f;
		IPGJLEEHBCO.HPKOOPBINIH = 1796f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1846f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 381f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(13f, 1222f, 1850f, 240f);
		Color color2 = new Color(1455f, 1014f, 341f, 1075f);
		Color color3 = new Color(1146f, 1975f, 1638f, 984f);
		Color color4 = new Color(1905f, 1866f, 1241f, 1156f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[5] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color4;
	}

	public void __BB_OBFUSCATOR_4(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void __BB_OBFUSCATOR_74()
	{
		HODOCPIKIBI = new GameObject("RespawnPlayer2");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 1669f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_35()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1886f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 807f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 346f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1590f;
		EMDAMLDNFCK.HPKOOPBINIH = 818f;
		EMDAMLDNFCK.EKKCIFKDCNC = 1016f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 245f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(421f, 218f, 1162f, 1039f);
		Color color2 = new Color(811f, 32f, 1294f, 646f);
		Color color3 = new Color(1131f, 1652f, 1624f, 1796f);
		Color color4 = new Color(1140f, 602f, 673f, 1777f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[8] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color4;
	}

	public void __BB_OBFUSCATOR_80(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void __BB_OBFUSCATOR_70()
	{
		EEJNOCGFEAI = new GameObject("_Value3");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 382f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_114()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1721f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 867f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 512f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1405f;
		EMDAMLDNFCK.HPKOOPBINIH = 284f;
		EMDAMLDNFCK.EKKCIFKDCNC = 907f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1437f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(801f, 1001f, 588f, 836f);
		Color color2 = new Color(661f, 1768f, 524f, 858f);
		Color color3 = new Color(1000f, 1461f, 1775f, 1722f);
		Color color4 = new Color(1796f, 1266f, 986f, 769f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[8] = color4;
	}

	public void __BB_OBFUSCATOR_98()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1473f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 745f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1667f;
		IPGJLEEHBCO.FGMDPKFFANG = 497f;
		IPGJLEEHBCO.HPKOOPBINIH = 1150f;
		IPGJLEEHBCO.EKKCIFKDCNC = 923f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1225f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(855f, 805f, 965f, 312f);
		Color color2 = new Color(1514f, 600f, 893f, 1142f);
		Color color3 = new Color(1783f, 1806f, 790f, 164f);
		Color color4 = new Color(1899f, 1744f, 859f, 684f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[3] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color4;
	}

	public virtual void __BB_OBFUSCATOR_44()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_15();
			__BB_OBFUSCATOR_51();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_105()
	{
		EEJNOCGFEAI = new GameObject("_ChromaticAberration");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 47f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_36()
	{
		__BB_OBFUSCATOR_7(true);
		__BB_OBFUSCATOR_41();
		__BB_OBFUSCATOR_62();
	}

	public virtual void __BB_OBFUSCATOR_21()
	{
		__BB_OBFUSCATOR_91(false);
		__BB_OBFUSCATOR_3();
		__BB_OBFUSCATOR_10();
	}

	public override void Explode()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateSmokeA();
			UpdateSmokeB();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_113()
	{
		HODOCPIKIBI = new GameObject("_MainTex");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 1830f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_115(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void __BB_OBFUSCATOR_5()
	{
		HODOCPIKIBI = new GameObject("_diff\", \"\" {\n\t\tType: \"TextureVideoClip\"\n\t\tVersion: 202\n\t\tTextureName: \"Texture::");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 985f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_95()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1367f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1776f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 1110f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1433f;
		EMDAMLDNFCK.HPKOOPBINIH = 310f;
		EMDAMLDNFCK.EKKCIFKDCNC = 48f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1642f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1849f, 1972f, 562f, 1821f);
		Color color2 = new Color(1121f, 1926f, 1392f, 1424f);
		Color color3 = new Color(245f, 570f, 138f, 551f);
		Color color4 = new Color(1192f, 1615f, 1984f, 1415f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[5] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[2] = color4;
	}

	public void __BB_OBFUSCATOR_108()
	{
		HODOCPIKIBI = new GameObject("PublishMessage parameters must be non-null and not empty.");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 185f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_51()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1634f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 893f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1425f;
		IPGJLEEHBCO.FGMDPKFFANG = 1146f;
		IPGJLEEHBCO.HPKOOPBINIH = 619f;
		IPGJLEEHBCO.EKKCIFKDCNC = 553f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1864f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(129f, 1830f, 329f, 1382f);
		Color color2 = new Color(744f, 389f, 1952f, 991f);
		Color color3 = new Color(1888f, 338f, 855f, 683f);
		Color color4 = new Color(1616f, 1638f, 1693f, 1150f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color4;
	}

	public void __BB_OBFUSCATOR_96()
	{
		EEJNOCGFEAI = new GameObject("_ScreenResolution");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1683f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_110()
	{
		__BB_OBFUSCATOR_115(true);
		__BB_OBFUSCATOR_41();
		__BB_OBFUSCATOR_99();
	}

	public void __BB_OBFUSCATOR_39()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 939f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 137f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 741f;
		IPGJLEEHBCO.FGMDPKFFANG = 1291f;
		IPGJLEEHBCO.HPKOOPBINIH = 1627f;
		IPGJLEEHBCO.EKKCIFKDCNC = 129f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1972f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(878f, 1587f, 1221f, 1171f);
		Color color2 = new Color(1463f, 326f, 1891f, 708f);
		Color color3 = new Color(1467f, 1959f, 1374f, 432f);
		Color color4 = new Color(1238f, 921f, 1981f, 1814f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color4;
	}

	public void FillMaterials(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void BuildSmokeB()
	{
		HODOCPIKIBI = new GameObject("SmokeB");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 0.095f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_112()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 974f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 698f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 848f;
		IPGJLEEHBCO.FGMDPKFFANG = 1936f;
		IPGJLEEHBCO.HPKOOPBINIH = 974f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1791f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1790f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1415f, 1234f, 919f, 1908f);
		Color color2 = new Color(547f, 1948f, 563f, 1958f);
		Color color3 = new Color(324f, 87f, 1025f, 1284f);
		Color color4 = new Color(1005f, 234f, 1036f, 1119f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[6] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color4;
	}

	public void __BB_OBFUSCATOR_43()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1315f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 376f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1980f;
		IPGJLEEHBCO.FGMDPKFFANG = 1623f;
		IPGJLEEHBCO.HPKOOPBINIH = 825f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1177f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1593f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(61f, 97f, 801f, 1226f);
		Color color2 = new Color(259f, 1944f, 192f, 1193f);
		Color color3 = new Color(342f, 552f, 1107f, 1979f);
		Color color4 = new Color(1810f, 1916f, 709f, 1725f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color4;
	}

	public void __BB_OBFUSCATOR_10()
	{
		HODOCPIKIBI = new GameObject("CameraFilterPack/Distortion_Noise");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 966f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_76()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 18f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1999f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1316f;
		IPGJLEEHBCO.FGMDPKFFANG = 293f;
		IPGJLEEHBCO.HPKOOPBINIH = 1715f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1628f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1305f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(0f, 493f, 1728f, 111f);
		Color color2 = new Color(10f, 1313f, 1116f, 68f);
		Color color3 = new Color(1806f, 761f, 1686f, 1937f);
		Color color4 = new Color(578f, 1407f, 1845f, 1358f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[5] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_83()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1464f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 166f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 295f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 767f;
		EMDAMLDNFCK.HPKOOPBINIH = 980f;
		EMDAMLDNFCK.EKKCIFKDCNC = 1034f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1386f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1508f, 24f, 1294f, 844f);
		Color color2 = new Color(2f, 1363f, 1097f, 175f);
		Color color3 = new Color(1371f, 1238f, 1727f, 1755f);
		Color color4 = new Color(1606f, 1727f, 101f, 578f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[2] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color4;
	}

	public void __BB_OBFUSCATOR_53()
	{
		EEJNOCGFEAI = new GameObject("\"");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 673f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_13()
	{
		__BB_OBFUSCATOR_29(true);
		__BB_OBFUSCATOR_70();
		__BB_OBFUSCATOR_52();
	}

	public virtual void __BB_OBFUSCATOR_56()
	{
		__BB_OBFUSCATOR_115(false);
		__BB_OBFUSCATOR_63();
		BuildSmokeB();
	}

	public virtual void __BB_OBFUSCATOR_97()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_78();
			__BB_OBFUSCATOR_57();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_69()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			UpdateSmokeA();
			__BB_OBFUSCATOR_51();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		__BB_OBFUSCATOR_91(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = 689f;
		LCLHCEHHBNM = 1908f;
		BHDOLBHLDGC = 604f;
		DHMOAEAKEBD = 1143f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(1031f, 677f, 910f);
	}

	public void __BB_OBFUSCATOR_47()
	{
		EEJNOCGFEAI = new GameObject("TeamName");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 220f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void BuildSmokeA()
	{
		EEJNOCGFEAI = new GameObject("SmokeA");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 0.095f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_50()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_46();
			__BB_OBFUSCATOR_82();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_33()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1288f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 749f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1245f;
		IPGJLEEHBCO.FGMDPKFFANG = 1164f;
		IPGJLEEHBCO.HPKOOPBINIH = 851f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1897f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1434f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(728f, 1300f, 1586f, 1296f);
		Color color2 = new Color(185f, 674f, 519f, 1285f);
		Color color3 = new Color(281f, 528f, 1812f, 32f);
		Color color4 = new Color(1836f, 297f, 1601f, 1622f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[4] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color4;
	}

	public void Reset()
	{
		FillMaterials(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = 1f;
		LCLHCEHHBNM = 8f;
		BHDOLBHLDGC = 0f;
		DHMOAEAKEBD = 0f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(3f, 3f, 3f);
	}

	public void UpdateSmokeB()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * -1f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 0.5f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 0f;
		IPGJLEEHBCO.FGMDPKFFANG = 2f;
		IPGJLEEHBCO.HPKOOPBINIH = 25f;
		IPGJLEEHBCO.EKKCIFKDCNC = 3f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 10f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
		Color color2 = new Color(0.2f, 0.2f, 0.2f, 0.7f);
		Color color3 = new Color(0.2f, 0.2f, 0.2f, 0.4f);
		Color color4 = new Color(0.2f, 0.2f, 0.2f, 0f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[3] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_91(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void UpdateSmokeA()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * -1.5f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 0.5f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 0f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 4f;
		EMDAMLDNFCK.HPKOOPBINIH = 25f;
		EMDAMLDNFCK.EKKCIFKDCNC = 3f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 10f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
		Color color2 = new Color(0.2f, 0.2f, 0.2f, 0.7f);
		Color color3 = new Color(0.2f, 0.2f, 0.2f, 0.4f);
		Color color4 = new Color(0.2f, 0.2f, 0.2f, 0f);
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[2] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[3] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_89()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 740f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1654f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1174f;
		IPGJLEEHBCO.FGMDPKFFANG = 720f;
		IPGJLEEHBCO.HPKOOPBINIH = 132f;
		IPGJLEEHBCO.EKKCIFKDCNC = 712f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1149f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1306f, 1837f, 771f, 679f);
		Color color2 = new Color(1139f, 585f, 926f, 1759f);
		Color color3 = new Color(1674f, 111f, 482f, 1102f);
		Color color4 = new Color(989f, 1385f, 1761f, 1222f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[6] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[4] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_30()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 450f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 462f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1485f;
		IPGJLEEHBCO.FGMDPKFFANG = 421f;
		IPGJLEEHBCO.HPKOOPBINIH = 1369f;
		IPGJLEEHBCO.EKKCIFKDCNC = 214f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 213f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1720f, 1050f, 1350f, 1879f);
		Color color2 = new Color(224f, 859f, 1090f, 576f);
		Color color3 = new Color(1001f, 773f, 837f, 858f);
		Color color4 = new Color(1848f, 735f, 1376f, 325f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color4;
	}

	public void __BB_OBFUSCATOR_1()
	{
		EEJNOCGFEAI = new GameObject("_TimeX");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1274f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_65()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_35();
			__BB_OBFUSCATOR_77();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_57()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1377f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 540f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1458f;
		IPGJLEEHBCO.FGMDPKFFANG = 654f;
		IPGJLEEHBCO.HPKOOPBINIH = 424f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1596f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 942f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(127f, 115f, 1762f, 1283f);
		Color color2 = new Color(1330f, 684f, 803f, 1190f);
		Color color3 = new Color(248f, 1784f, 202f, 1328f);
		Color color4 = new Color(222f, 243f, 178f, 1126f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[5] = color4;
	}

	public void __BB_OBFUSCATOR_52()
	{
		HODOCPIKIBI = new GameObject("FlyCam");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 383f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_94()
	{
		EEJNOCGFEAI = new GameObject("WFX_Explosion");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1664f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_79()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1692f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1646f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 215f;
		IPGJLEEHBCO.FGMDPKFFANG = 2f;
		IPGJLEEHBCO.HPKOOPBINIH = 601f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1483f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 668f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1063f, 31f, 643f, 1774f);
		Color color2 = new Color(1775f, 1363f, 1031f, 684f);
		Color color3 = new Color(241f, 776f, 553f, 404f);
		Color color4 = new Color(1393f, 1511f, 1694f, 1813f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[5] = color4;
	}

	public void __BB_OBFUSCATOR_84()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1877f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 786f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1659f;
		IPGJLEEHBCO.FGMDPKFFANG = 466f;
		IPGJLEEHBCO.HPKOOPBINIH = 403f;
		IPGJLEEHBCO.EKKCIFKDCNC = 656f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 708f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(473f, 944f, 113f, 1032f);
		Color color2 = new Color(512f, 1426f, 1438f, 1723f);
		Color color3 = new Color(1434f, 1708f, 120f, 1332f);
		Color color4 = new Color(191f, 827f, 258f, 1587f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[3] = color4;
	}

	public void __BB_OBFUSCATOR_99()
	{
		HODOCPIKIBI = new GameObject("SyncWeaponsRPC");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 57f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_103()
	{
		__BB_OBFUSCATOR_80(false);
		__BB_OBFUSCATOR_20();
		__BB_OBFUSCATOR_74();
	}

	public virtual void __BB_OBFUSCATOR_55()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_24();
			__BB_OBFUSCATOR_76();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_81()
	{
		__BB_OBFUSCATOR_115(false);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = 1847f;
		LCLHCEHHBNM = 244f;
		BHDOLBHLDGC = 1672f;
		DHMOAEAKEBD = 1097f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(864f, 1637f, 1637f);
	}

	public void __BB_OBFUSCATOR_28()
	{
		HODOCPIKIBI = new GameObject("_ScreenResolution");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = true;
		IPGJLEEHBCO.NMPKCAOOHIJ = 760f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_3()
	{
		EEJNOCGFEAI = new GameObject("_Speed");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1565f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_16()
	{
		__BB_OBFUSCATOR_80(true);
		GMAIEMJKMJD = true;
		EEDMLOPHDJA = 970f;
		LCLHCEHHBNM = 663f;
		BHDOLBHLDGC = 1069f;
		DHMOAEAKEBD = 248f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(1770f, 300f, 1490f);
	}

	public void __BB_OBFUSCATOR_46()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1924f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 642f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 562f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1226f;
		EMDAMLDNFCK.HPKOOPBINIH = 1028f;
		EMDAMLDNFCK.EKKCIFKDCNC = 269f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1776f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1225f, 1138f, 386f, 1023f);
		Color color2 = new Color(478f, 703f, 1992f, 813f);
		Color color3 = new Color(516f, 1556f, 1553f, 132f);
		Color color4 = new Color(480f, 1293f, 399f, 1606f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[7] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[2] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[5] = color4;
	}

	public void __BB_OBFUSCATOR_71()
	{
		FillMaterials(false);
		GMAIEMJKMJD = false;
		EEDMLOPHDJA = 1225f;
		LCLHCEHHBNM = 1263f;
		BHDOLBHLDGC = 17f;
		DHMOAEAKEBD = 408f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		PACAMLAINIK = new Vector3(1465f, 1946f, 1985f);
	}

	public void __BB_OBFUSCATOR_82()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 1269f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 532f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 486f;
		IPGJLEEHBCO.FGMDPKFFANG = 449f;
		IPGJLEEHBCO.HPKOOPBINIH = 1650f;
		IPGJLEEHBCO.EKKCIFKDCNC = 1269f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1030f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = true;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(328f, 1263f, 351f, 196f);
		Color color2 = new Color(1980f, 364f, 1726f, 464f);
		Color color3 = new Color(725f, 1679f, 1591f, 1512f);
		Color color4 = new Color(1753f, 1004f, 244f, 1432f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[5] = color4;
	}

	public void __BB_OBFUSCATOR_66()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 932f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1927f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 735f;
		IPGJLEEHBCO.FGMDPKFFANG = 936f;
		IPGJLEEHBCO.HPKOOPBINIH = 1916f;
		IPGJLEEHBCO.EKKCIFKDCNC = 348f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 899f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1232f, 130f, 1777f, 802f);
		Color color2 = new Color(1803f, 700f, 278f, 1634f);
		Color color3 = new Color(1208f, 1033f, 1273f, 523f);
		Color color4 = new Color(472f, 1169f, 110f, 93f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[7] = color4;
	}

	public void __BB_OBFUSCATOR_54()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 90f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1529f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 1963f;
		IPGJLEEHBCO.FGMDPKFFANG = 1704f;
		IPGJLEEHBCO.HPKOOPBINIH = 77f;
		IPGJLEEHBCO.EKKCIFKDCNC = 77f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 591f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1088f, 3f, 1242f, 245f);
		Color color2 = new Color(420f, 1749f, 613f, 890f);
		Color color3 = new Color(776f, 181f, 1603f, 1690f);
		Color color4 = new Color(314f, 594f, 1553f, 1115f);
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[3] = color4;
	}

	public void __BB_OBFUSCATOR_106()
	{
		HODOCPIKIBI = new GameObject("CameraFilterPack/Vision_Drost");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 20f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_72()
	{
		HODOCPIKIBI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		HODOCPIKIBI.transform.LookAt(Camera.main.transform);
		HODOCPIKIBI.transform.localPosition = -(Vector3.forward * 193f);
		IPGJLEEHBCO.IOFNOJHNJAJ = IOFNOJHNJAJ;
		IPGJLEEHBCO.LCLHCEHHBNM = LCLHCEHHBNM * 1093f;
		IPGJLEEHBCO.HEKGFKJHMFJ = 882f;
		IPGJLEEHBCO.FGMDPKFFANG = 1696f;
		IPGJLEEHBCO.HPKOOPBINIH = 364f;
		IPGJLEEHBCO.EKKCIFKDCNC = 735f;
		IPGJLEEHBCO.PACAMLAINIK = PACAMLAINIK;
		IPGJLEEHBCO.MFAPGCJPFFH = 1764f;
		IPGJLEEHBCO.EEDMLOPHDJA = EEDMLOPHDJA;
		IPGJLEEHBCO.AIELAFCIBBM = false;
		IPGJLEEHBCO.BHDOLBHLDGC = BHDOLBHLDGC;
		IPGJLEEHBCO.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(798f, 1921f, 92f, 1988f);
		Color color2 = new Color(1485f, 226f, 339f, 1804f);
		Color color3 = new Color(1135f, 1414f, 983f, 1706f);
		Color color4 = new Color(76f, 1084f, 662f, 272f);
		IPGJLEEHBCO.CJFAMIBMHGK[0] = color;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[1] = color2;
		IPGJLEEHBCO.CJFAMIBMHGK[2] = color3;
		IPGJLEEHBCO.CJFAMIBMHGK[8] = color4;
	}

	public void __BB_OBFUSCATOR_20()
	{
		EEJNOCGFEAI = new GameObject("_TimeX");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 105f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_17()
	{
		__BB_OBFUSCATOR_4(true);
		__BB_OBFUSCATOR_117();
		__BB_OBFUSCATOR_28();
	}

	public void __BB_OBFUSCATOR_86()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1057f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1656f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 107f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1034f;
		EMDAMLDNFCK.HPKOOPBINIH = 1632f;
		EMDAMLDNFCK.EKKCIFKDCNC = 38f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 1555f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1561f, 470f, 555f, 310f);
		Color color2 = new Color(941f, 220f, 1673f, 667f);
		Color color3 = new Color(1155f, 1209f, 715f, 441f);
		Color color4 = new Color(1353f, 260f, 659f, 120f);
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[7] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[7] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_109()
	{
		EEJNOCGFEAI = new GameObject("_ScreenResolution");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1836f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_78()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 56f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 731f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 527f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1481f;
		EMDAMLDNFCK.HPKOOPBINIH = 1109f;
		EMDAMLDNFCK.EKKCIFKDCNC = 1229f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 468f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(598f, 247f, 1438f, 1069f);
		Color color2 = new Color(563f, 1306f, 611f, 726f);
		Color color3 = new Color(153f, 430f, 1012f, 547f);
		Color color4 = new Color(1098f, 1275f, 513f, 1652f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[5] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[3] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public void __BB_OBFUSCATOR_59(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void __BB_OBFUSCATOR_73()
	{
		EEJNOCGFEAI = new GameObject("CameraFilterPack/Blend2Camera_Divide");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1757f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_63()
	{
		EEJNOCGFEAI = new GameObject("_Value3");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 1900f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_12()
	{
		EEJNOCGFEAI = new GameObject("Difficulty");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 372f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_29(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public void __BB_OBFUSCATOR_85()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1030f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1555f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 197f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1204f;
		EMDAMLDNFCK.HPKOOPBINIH = 1556f;
		EMDAMLDNFCK.EKKCIFKDCNC = 172f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 160f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(1712f, 1094f, 67f, 1899f);
		Color color2 = new Color(1602f, 947f, 1747f, 728f);
		Color color3 = new Color(553f, 122f, 696f, 1289f);
		Color color4 = new Color(1002f, 1629f, 825f, 951f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color4;
	}

	public void __BB_OBFUSCATOR_22()
	{
		HODOCPIKIBI = new GameObject("offsets");
		IPGJLEEHBCO = HODOCPIKIBI.AddComponent<DetonatorBurstEmitter>();
		HODOCPIKIBI.transform.parent = base.transform;
		HODOCPIKIBI.transform.localPosition = BJGOJGBLDMN;
		HODOCPIKIBI.transform.localRotation = Quaternion.identity;
		IPGJLEEHBCO.MFOLDHOAMNN = KDNNLMHFKOJ;
		IPGJLEEHBCO.HBNEHNACADK = false;
		IPGJLEEHBCO.NMPKCAOOHIJ = 913f;
		IPGJLEEHBCO.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		IPGJLEEHBCO.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_93(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public virtual void __BB_OBFUSCATOR_34()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_78();
			__BB_OBFUSCATOR_82();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_7(bool PHDOMKDEDMO)
	{
		if (!NLCJNPAMOEH || PHDOMKDEDMO)
		{
			NLCJNPAMOEH = MyDetonator().NLCJNPAMOEH;
		}
		if (!KDNNLMHFKOJ || PHDOMKDEDMO)
		{
			KDNNLMHFKOJ = MyDetonator().KDNNLMHFKOJ;
		}
	}

	public virtual void __BB_OBFUSCATOR_9()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_111();
			__BB_OBFUSCATOR_33();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_92()
	{
		__BB_OBFUSCATOR_115(true);
		__BB_OBFUSCATOR_53();
		__BB_OBFUSCATOR_5();
	}

	public void __BB_OBFUSCATOR_87()
	{
		EEJNOCGFEAI = new GameObject("INF");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = true;
		EMDAMLDNFCK.NMPKCAOOHIJ = 52f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public void __BB_OBFUSCATOR_117()
	{
		EEJNOCGFEAI = new GameObject("_Distortion");
		EMDAMLDNFCK = EEJNOCGFEAI.AddComponent<DetonatorBurstEmitter>();
		EEJNOCGFEAI.transform.parent = base.transform;
		EEJNOCGFEAI.transform.localPosition = BJGOJGBLDMN;
		EEJNOCGFEAI.transform.localRotation = Quaternion.identity;
		EMDAMLDNFCK.MFOLDHOAMNN = NLCJNPAMOEH;
		EMDAMLDNFCK.HBNEHNACADK = false;
		EMDAMLDNFCK.NMPKCAOOHIJ = 400f;
		EMDAMLDNFCK.MJHAPHHGGHI = MyDetonator().MJHAPHHGGHI;
		EMDAMLDNFCK.NJGDFDGPNLN = MyDetonator().NJGDFDGPNLN;
	}

	public virtual void __BB_OBFUSCATOR_101()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL) && GMAIEMJKMJD)
		{
			__BB_OBFUSCATOR_46();
			__BB_OBFUSCATOR_84();
			if (DNDCBMPPAPP)
			{
				EMDAMLDNFCK.Explode();
			}
			if (HOMCEMGJDEN)
			{
				IPGJLEEHBCO.Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_111()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1210f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1445f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 1421f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1426f;
		EMDAMLDNFCK.HPKOOPBINIH = 848f;
		EMDAMLDNFCK.EKKCIFKDCNC = 615f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 311f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(898f, 1817f, 1398f, 1708f);
		Color color2 = new Color(241f, 1702f, 1763f, 1601f);
		Color color3 = new Color(1058f, 957f, 1757f, 294f);
		Color color4 = new Color(1127f, 461f, 1404f, 821f);
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[5] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color4;
	}

	public virtual void __BB_OBFUSCATOR_61()
	{
		__BB_OBFUSCATOR_91(true);
		__BB_OBFUSCATOR_117();
		__BB_OBFUSCATOR_60();
	}

	public void __BB_OBFUSCATOR_107()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 900f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1367f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 329f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 731f;
		EMDAMLDNFCK.HPKOOPBINIH = 157f;
		EMDAMLDNFCK.EKKCIFKDCNC = 544f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 830f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = false;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(936f, 901f, 309f, 637f);
		Color color2 = new Color(414f, 1723f, 1529f, 472f);
		Color color3 = new Color(1201f, 1823f, 1589f, 1638f);
		Color color4 = new Color(948f, 1465f, 866f, 1936f);
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[6] = color4;
	}

	public void __BB_OBFUSCATOR_58()
	{
		EEJNOCGFEAI.transform.localPosition = Vector3.Scale(BJGOJGBLDMN, new Vector3(EEDMLOPHDJA, EEDMLOPHDJA, EEDMLOPHDJA));
		EEJNOCGFEAI.transform.LookAt(Camera.main.transform);
		EEJNOCGFEAI.transform.localPosition = -(Vector3.forward * 1486f);
		EMDAMLDNFCK.IOFNOJHNJAJ = IOFNOJHNJAJ;
		EMDAMLDNFCK.LCLHCEHHBNM = LCLHCEHHBNM * 1154f;
		EMDAMLDNFCK.HEKGFKJHMFJ = 1162f;
		EMDAMLDNFCK.PJKHHCHLFIF = PJKHHCHLFIF;
		EMDAMLDNFCK.FGMDPKFFANG = 1628f;
		EMDAMLDNFCK.HPKOOPBINIH = 1877f;
		EMDAMLDNFCK.EKKCIFKDCNC = 1758f;
		EMDAMLDNFCK.PACAMLAINIK = PACAMLAINIK;
		EMDAMLDNFCK.MFAPGCJPFFH = 733f;
		EMDAMLDNFCK.EEDMLOPHDJA = EEDMLOPHDJA;
		EMDAMLDNFCK.AIELAFCIBBM = true;
		EMDAMLDNFCK.BHDOLBHLDGC = BHDOLBHLDGC;
		EMDAMLDNFCK.DHMOAEAKEBD = DHMOAEAKEBD;
		Color color = new Color(205f, 1291f, 1247f, 1035f);
		Color color2 = new Color(762f, 880f, 1781f, 611f);
		Color color3 = new Color(873f, 205f, 570f, 468f);
		Color color4 = new Color(664f, 1927f, 1740f, 574f);
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color;
		EMDAMLDNFCK.CJFAMIBMHGK[1] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[0] = color2;
		EMDAMLDNFCK.CJFAMIBMHGK[4] = color3;
		EMDAMLDNFCK.CJFAMIBMHGK[2] = color4;
	}
}
