using UnityEngine;

[AddComponentMenu("Detonator/Detonator")]
public class Detonator : MonoBehaviour
{
	private static float KBGFHOJODBF = 30f;

	private static Color LNKOBAPEIIM = new Color(1f, 0.423f, 0f, 0.5f);

	private static float BNCCIDBIPBF = 3f;

	public float EEDMLOPHDJA = 10f;

	public Color IOFNOJHNJAJ = LNKOBAPEIIM;

	public bool LIPKHINMGCG = true;

	public float LCLHCEHHBNM = BNCCIDBIPBF;

	public float NCGMMIBMBEL = 1f;

	public float NJGDFDGPNLN;

	public float KKPABCIFCLM = 7f;

	public bool MJHAPHHGGHI = true;

	public Vector3 INBMDEIBLKA = Vector3.zero;

	public Material DHGANMBLNNK;

	public Material FMNGJEGCFIE;

	public Material NLCJNPAMOEH;

	public Material KDNNLMHFKOJ;

	public Material LPBFFNKMPBF;

	public Material OOBJJKOBLHO;

	public Material NENOJAIPONP;

	public Material JFCAMPLCDPL;

	private Component[] FNLMFDIEJMN;

	private DetonatorFireball EEOEFCPMNGE;

	private DetonatorSparks KBLDLECJNGB;

	private DetonatorShockwave OPEBENDACBH;

	private DetonatorSmoke IPANIAGAHCA;

	private DetonatorGlow AIEKFKBMNFI;

	private DetonatorLight KCJFKFEINIH;

	private DetonatorForce GBIDGDLCOPH;

	private DetonatorHeatwave JINNABLHEML;

	public bool ACBCLONBCBL = true;

	public bool LNCPJNEMDBM = true;

	public bool MPMHEGDLDGE = true;

	public bool IPLFCIAEGGK = true;

	public bool OLOACLAJGPC = true;

	public bool FBGJPMBFBHK = true;

	public bool LEPHINODGJM = true;

	public bool PKAMPGKIDCH;

	private float OPADOPLLMNE = 1000f;

	private bool PNKNNGNGCGA = true;

	private Component[] FFNIHPCKHOK;

	public static Material IKLIKFCFCNH;

	public static Material BIBAEIKBJJF;

	public static Material LCDLJABOOBN;

	public static Material AMIIMFLDGPL;

	public static Material BPLPBIHMPEP;

	public static Material PDOKKCJABHI;

	public static Material BFHMAIPECAJ;

	public static Material DFGGEEPCGJO;

	public static Material __BB_OBFUSCATOR_20()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("monster"));
		BFHMAIPECAJ.name = "_Value4";
		Texture2D mainTexture = Resources.Load(" ") as Texture2D;
		BFHMAIPECAJ.SetColor("syncShotGun", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public static Material __BB_OBFUSCATOR_54()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("_TimeX"));
		AMIIMFLDGPL.name = "_TimeX";
		Texture2D mainTexture = Resources.Load("_FgOverlap") as Texture2D;
		AMIIMFLDGPL.SetColor("_Value", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(101f, 248f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(110f, 1803f);
		return AMIIMFLDGPL;
	}

	public static Material DefaultSparksMaterial()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("Particles/Additive"));
		PDOKKCJABHI.name = "Sparks-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/GlowDot") as Texture2D;
		PDOKKCJABHI.SetColor("_TintColor", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	private void UpdateComponents()
	{
		if (PNKNNGNGCGA)
		{
			Component[] fNLMFDIEJMN = FNLMFDIEJMN;
			for (int i = 0; i < fNLMFDIEJMN.Length; i++)
			{
				DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
				detonatorComponent.Init();
				detonatorComponent.SetStartValues();
			}
			PNKNNGNGCGA = false;
		}
		if (PNKNNGNGCGA)
		{
			return;
		}
		Component[] fNLMFDIEJMN2 = FNLMFDIEJMN;
		for (int j = 0; j < fNLMFDIEJMN2.Length; j++)
		{
			DetonatorComponent detonatorComponent2 = (DetonatorComponent)fNLMFDIEJMN2[j];
			if (detonatorComponent2.KPMHIHPFGMB)
			{
				detonatorComponent2.EEDMLOPHDJA = detonatorComponent2.IOAKGDAKKEE * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.PJKHHCHLFIF = LCLHCEHHBNM / BNCCIDBIPBF;
				detonatorComponent2.NCGMMIBMBEL = detonatorComponent2.CLLMMGIJIBC * NCGMMIBMBEL;
				detonatorComponent2.ICPDBNNPACO = detonatorComponent2.IIHAGBLLJBA * (EEDMLOPHDJA / KBGFHOJODBF) + INBMDEIBLKA * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.PACAMLAINIK = detonatorComponent2.OHNEBJKDAOD * (EEDMLOPHDJA / KBGFHOJODBF) + INBMDEIBLKA * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.IOFNOJHNJAJ = Color.Lerp(detonatorComponent2.EOEMJCCFMEE, IOFNOJHNJAJ, IOFNOJHNJAJ.a);
			}
		}
	}

	public static Material __BB_OBFUSCATOR_7()
	{
		if (SystemInfo.supportsImageEffects)
		{
			if (DFGGEEPCGJO != null)
			{
				return DFGGEEPCGJO;
			}
			DFGGEEPCGJO = new Material(Shader.Find("Missing shader in "));
			DFGGEEPCGJO.name = "Attack";
			Texture2D value = Resources.Load("MP") as Texture2D;
			DFGGEEPCGJO.SetTexture(">", value);
			return DFGGEEPCGJO;
		}
		return null;
	}

	private void __BB_OBFUSCATOR_34()
	{
		__BB_OBFUSCATOR_32();
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 1; i < fNLMFDIEJMN.Length; i++)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			if (detonatorComponent is DetonatorFireball)
			{
				EEOEFCPMNGE = detonatorComponent as DetonatorFireball;
			}
			if (detonatorComponent is DetonatorSparks)
			{
				KBLDLECJNGB = detonatorComponent as DetonatorSparks;
			}
			if (detonatorComponent is DetonatorShockwave)
			{
				OPEBENDACBH = detonatorComponent as DetonatorShockwave;
			}
			if (detonatorComponent is DetonatorSmoke)
			{
				IPANIAGAHCA = detonatorComponent as DetonatorSmoke;
			}
			if (detonatorComponent is DetonatorGlow)
			{
				AIEKFKBMNFI = detonatorComponent as DetonatorGlow;
			}
			if (detonatorComponent is DetonatorLight)
			{
				KCJFKFEINIH = detonatorComponent as DetonatorLight;
			}
			if (detonatorComponent is DetonatorForce)
			{
				GBIDGDLCOPH = detonatorComponent as DetonatorForce;
			}
			if (detonatorComponent is DetonatorHeatwave)
			{
				JINNABLHEML = detonatorComponent as DetonatorHeatwave;
			}
		}
		if (!EEOEFCPMNGE && ACBCLONBCBL)
		{
			EEOEFCPMNGE = base.gameObject.AddComponent<DetonatorFireball>();
			EEOEFCPMNGE.__BB_OBFUSCATOR_9();
		}
		if (!IPANIAGAHCA && IPLFCIAEGGK)
		{
			IPANIAGAHCA = base.gameObject.AddComponent<DetonatorSmoke>();
			IPANIAGAHCA.__BB_OBFUSCATOR_14();
		}
		if (!KBLDLECJNGB && LNCPJNEMDBM)
		{
			KBLDLECJNGB = base.gameObject.AddComponent<DetonatorSparks>();
			KBLDLECJNGB.__BB_OBFUSCATOR_23();
		}
		if (!OPEBENDACBH && MPMHEGDLDGE)
		{
			OPEBENDACBH = base.gameObject.AddComponent<DetonatorShockwave>();
			OPEBENDACBH.__BB_OBFUSCATOR_119();
		}
		if (!AIEKFKBMNFI && OLOACLAJGPC)
		{
			AIEKFKBMNFI = base.gameObject.AddComponent<DetonatorGlow>();
			AIEKFKBMNFI.__BB_OBFUSCATOR_100();
		}
		if (!KCJFKFEINIH && FBGJPMBFBHK)
		{
			KCJFKFEINIH = base.gameObject.AddComponent<DetonatorLight>();
			KCJFKFEINIH.__BB_OBFUSCATOR_29();
		}
		if (!GBIDGDLCOPH && LEPHINODGJM)
		{
			GBIDGDLCOPH = base.gameObject.AddComponent<DetonatorForce>();
			GBIDGDLCOPH.__BB_OBFUSCATOR_49();
		}
		if (!JINNABLHEML && PKAMPGKIDCH && SystemInfo.supportsImageEffects)
		{
			JINNABLHEML = base.gameObject.AddComponent<DetonatorHeatwave>();
			JINNABLHEML.__BB_OBFUSCATOR_20();
		}
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
	}

	public static Material __BB_OBFUSCATOR_15()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find("Remote"));
		BPLPBIHMPEP.name = "_ScreenResolution";
		Texture2D mainTexture = Resources.Load("Right Stick Up") as Texture2D;
		BPLPBIHMPEP.SetColor("_Value5", new Color(1513f, 1593f, 746f, 571f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (KKPABCIFCLM > 566f && OPADOPLLMNE + KKPABCIFCLM <= Time.time)
		{
			Object.Destroy(base.gameObject);
		}
	}

	public static Material __BB_OBFUSCATOR_42()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("Run"));
		AMIIMFLDGPL.name = "Particles/Additive";
		Texture2D mainTexture = Resources.Load("Full Ammo    ") as Texture2D;
		AMIIMFLDGPL.SetColor("PlayerType'", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(131f, 114f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(1325f, 11f);
		return AMIIMFLDGPL;
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (LIPKHINMGCG)
		{
			UpdateComponents();
			__BB_OBFUSCATOR_43();
		}
	}

	public static Material __BB_OBFUSCATOR_51()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("Detonator/Textures/Smoke"));
		PDOKKCJABHI.name = "Connecting...";
		Texture2D mainTexture = Resources.Load("_Value2") as Texture2D;
		PDOKKCJABHI.SetColor("_ScreenResolution", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	public static Material __BB_OBFUSCATOR_5()
	{
		if (SystemInfo.supportsImageEffects)
		{
			if (DFGGEEPCGJO != null)
			{
				return DFGGEEPCGJO;
			}
			DFGGEEPCGJO = new Material(Shader.Find("Y"));
			DFGGEEPCGJO.name = "_diff\", \"\" {\n\t\tType: \"TextureVideoClip\"\n\t\tVersion: 202\n\t\tTextureName: \"Texture::";
			Texture2D value = Resources.Load("_Value5") as Texture2D;
			DFGGEEPCGJO.SetTexture("_Value2", value);
			return DFGGEEPCGJO;
		}
		return null;
	}

	public static Material DefaultSmokeAMaterial()
	{
		if (LCDLJABOOBN != null)
		{
			return LCDLJABOOBN;
		}
		LCDLJABOOBN = new Material(Shader.Find("Particles/Alpha Blended"));
		LCDLJABOOBN.name = "SmokeA-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Smoke") as Texture2D;
		LCDLJABOOBN.SetColor("_TintColor", Color.white);
		LCDLJABOOBN.mainTexture = mainTexture;
		LCDLJABOOBN.mainTextureScale = new Vector2(0.5f, 1f);
		return LCDLJABOOBN;
	}

	public static Material __BB_OBFUSCATOR_3()
	{
		if (SystemInfo.supportsImageEffects)
		{
			if (DFGGEEPCGJO != null)
			{
				return DFGGEEPCGJO;
			}
			DFGGEEPCGJO = new Material(Shader.Find("_ForegroundBlurExtrude"));
			DFGGEEPCGJO.name = "_Value4";
			Texture2D value = Resources.Load("_Skybox") as Texture2D;
			DFGGEEPCGJO.SetTexture("</size>", value);
			return DFGGEEPCGJO;
		}
		return null;
	}

	public static Material __BB_OBFUSCATOR_16()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find(":"));
		BPLPBIHMPEP.name = "_Refraction";
		Texture2D mainTexture = Resources.Load("\\xAu4YW5QzfD2KQjV") as Texture2D;
		BPLPBIHMPEP.SetColor("DoDamage", new Color(974f, 1270f, 934f, 536f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	public static Material __BB_OBFUSCATOR_13()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("Run"));
		BFHMAIPECAJ.name = ">";
		Texture2D mainTexture = Resources.Load("</color></size>") as Texture2D;
		BFHMAIPECAJ.SetColor("FOVKick Increase curve is null, please define the curve for the field of view kicks", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public void __BB_OBFUSCATOR_8()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 1; i < fNLMFDIEJMN.Length; i += 0)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			__BB_OBFUSCATOR_57();
			detonatorComponent.Explode();
		}
	}

	public static Material DefaultHeatwaveMaterial()
	{
		if (SystemInfo.supportsImageEffects)
		{
			if (DFGGEEPCGJO != null)
			{
				return DFGGEEPCGJO;
			}
			DFGGEEPCGJO = new Material(Shader.Find("HeatDistort"));
			DFGGEEPCGJO.name = "Heatwave-Default";
			Texture2D value = Resources.Load("Detonator/Textures/Heatwave") as Texture2D;
			DFGGEEPCGJO.SetTexture("_BumpMap", value);
			return DFGGEEPCGJO;
		}
		return null;
	}

	public static Material __BB_OBFUSCATOR_36()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("CameraFilterPack/TV_Noise"));
		BFHMAIPECAJ.name = "<size=";
		Texture2D mainTexture = Resources.Load("CameraFilterPack/Colors_Adjust_FullColors") as Texture2D;
		BFHMAIPECAJ.SetColor("_ScreenResolution", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public void __BB_OBFUSCATOR_31()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i++)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			UpdateComponents();
			detonatorComponent.Explode();
		}
	}

	public static Material __BB_OBFUSCATOR_46()
	{
		if (LCDLJABOOBN != null)
		{
			return LCDLJABOOBN;
		}
		LCDLJABOOBN = new Material(Shader.Find(","));
		LCDLJABOOBN.name = "_Value3";
		Texture2D mainTexture = Resources.Load(" (ID:") as Texture2D;
		LCDLJABOOBN.SetColor("\t}\n", Color.white);
		LCDLJABOOBN.mainTexture = mainTexture;
		LCDLJABOOBN.mainTextureScale = new Vector2(1512f, 719f);
		return LCDLJABOOBN;
	}

	public static Material __BB_OBFUSCATOR_23()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("CameraFilterPack/Blend2Camera_Exclusion"));
		BFHMAIPECAJ.name = "f2";
		Texture2D mainTexture = Resources.Load("TeamName") as Texture2D;
		BFHMAIPECAJ.SetColor("> ", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public void __BB_OBFUSCATOR_17()
	{
		EEDMLOPHDJA = 239f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		LCLHCEHHBNM = BNCCIDBIPBF;
		__BB_OBFUSCATOR_45();
	}

	public static Material __BB_OBFUSCATOR_0()
	{
		if (LCDLJABOOBN != null)
		{
			return LCDLJABOOBN;
		}
		LCDLJABOOBN = new Material(Shader.Find("_Vignette_Alpha"));
		LCDLJABOOBN.name = "ForceDamage";
		Texture2D mainTexture = Resources.Load("_TimeX") as Texture2D;
		LCDLJABOOBN.SetColor("custard", Color.white);
		LCDLJABOOBN.mainTexture = mainTexture;
		LCDLJABOOBN.mainTextureScale = new Vector2(244f, 1406f);
		return LCDLJABOOBN;
	}

	public static Material DefaultShockwaveMaterial()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find("Particles/Additive"));
		BPLPBIHMPEP.name = "Shockwave-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Shockwave") as Texture2D;
		BPLPBIHMPEP.SetColor("_TintColor", new Color(0.1f, 0.1f, 0.1f, 1f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (!DHGANMBLNNK)
		{
			DHGANMBLNNK = __BB_OBFUSCATOR_9();
		}
		if (!FMNGJEGCFIE)
		{
			FMNGJEGCFIE = __BB_OBFUSCATOR_21();
		}
		if (!NLCJNPAMOEH)
		{
			NLCJNPAMOEH = DefaultSmokeAMaterial();
		}
		if (!KDNNLMHFKOJ)
		{
			KDNNLMHFKOJ = __BB_OBFUSCATOR_19();
		}
		if (!LPBFFNKMPBF)
		{
			LPBFFNKMPBF = __BB_OBFUSCATOR_16();
		}
		if (!OOBJJKOBLHO)
		{
			OOBJJKOBLHO = __BB_OBFUSCATOR_44();
		}
		if (!NENOJAIPONP)
		{
			NENOJAIPONP = __BB_OBFUSCATOR_35();
		}
		if (!JFCAMPLCDPL)
		{
			JFCAMPLCDPL = __BB_OBFUSCATOR_5();
		}
	}

	public static Material __BB_OBFUSCATOR_12()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("__Room"));
		PDOKKCJABHI.name = "_Value";
		Texture2D mainTexture = Resources.Load("_ScreenResolution") as Texture2D;
		PDOKKCJABHI.SetColor("Horizontal", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	public static Material __BB_OBFUSCATOR_38()
	{
		if (BIBAEIKBJJF != null)
		{
			return BIBAEIKBJJF;
		}
		BIBAEIKBJJF = new Material(Shader.Find(">"));
		BIBAEIKBJJF.name = "_AdaptTex";
		Texture2D mainTexture = Resources.Load("_U") as Texture2D;
		BIBAEIKBJJF.SetColor("_Value", Color.white);
		BIBAEIKBJJF.mainTexture = mainTexture;
		BIBAEIKBJJF.mainTextureScale = new Vector2(28f, 143f);
		BIBAEIKBJJF.mainTextureOffset = new Vector2(1911f, 1833f);
		return BIBAEIKBJJF;
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!DHGANMBLNNK)
		{
			DHGANMBLNNK = __BB_OBFUSCATOR_9();
		}
		if (!FMNGJEGCFIE)
		{
			FMNGJEGCFIE = DefaultFireballBMaterial();
		}
		if (!NLCJNPAMOEH)
		{
			NLCJNPAMOEH = __BB_OBFUSCATOR_46();
		}
		if (!KDNNLMHFKOJ)
		{
			KDNNLMHFKOJ = __BB_OBFUSCATOR_54();
		}
		if (!LPBFFNKMPBF)
		{
			LPBFFNKMPBF = __BB_OBFUSCATOR_15();
		}
		if (!OOBJJKOBLHO)
		{
			OOBJJKOBLHO = __BB_OBFUSCATOR_12();
		}
		if (!NENOJAIPONP)
		{
			NENOJAIPONP = __BB_OBFUSCATOR_36();
		}
		if (!JFCAMPLCDPL)
		{
			JFCAMPLCDPL = __BB_OBFUSCATOR_3();
		}
	}

	public static Material __BB_OBFUSCATOR_55()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find("FurShader: Simulate Movement option enabled on GameObject: '"));
		BPLPBIHMPEP.name = "_ScreenResolution";
		Texture2D mainTexture = Resources.Load("3") as Texture2D;
		BPLPBIHMPEP.SetColor("Kills", new Color(1253f, 1274f, 1554f, 1462f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	public static Material __BB_OBFUSCATOR_18()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find("custard"));
		BPLPBIHMPEP.name = "_Value4";
		Texture2D mainTexture = Resources.Load("State2") as Texture2D;
		BPLPBIHMPEP.SetColor("_TimeX", new Color(1289f, 28f, 1799f, 1415f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	public void __BB_OBFUSCATOR_10()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 1; i < fNLMFDIEJMN.Length; i += 0)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			__BB_OBFUSCATOR_57();
			detonatorComponent.Explode();
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		__BB_OBFUSCATOR_24();
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i += 0)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			if (detonatorComponent is DetonatorFireball)
			{
				EEOEFCPMNGE = detonatorComponent as DetonatorFireball;
			}
			if (detonatorComponent is DetonatorSparks)
			{
				KBLDLECJNGB = detonatorComponent as DetonatorSparks;
			}
			if (detonatorComponent is DetonatorShockwave)
			{
				OPEBENDACBH = detonatorComponent as DetonatorShockwave;
			}
			if (detonatorComponent is DetonatorSmoke)
			{
				IPANIAGAHCA = detonatorComponent as DetonatorSmoke;
			}
			if (detonatorComponent is DetonatorGlow)
			{
				AIEKFKBMNFI = detonatorComponent as DetonatorGlow;
			}
			if (detonatorComponent is DetonatorLight)
			{
				KCJFKFEINIH = detonatorComponent as DetonatorLight;
			}
			if (detonatorComponent is DetonatorForce)
			{
				GBIDGDLCOPH = detonatorComponent as DetonatorForce;
			}
			if (detonatorComponent is DetonatorHeatwave)
			{
				JINNABLHEML = detonatorComponent as DetonatorHeatwave;
			}
		}
		if (!EEOEFCPMNGE && ACBCLONBCBL)
		{
			EEOEFCPMNGE = base.gameObject.AddComponent<DetonatorFireball>();
			EEOEFCPMNGE.__BB_OBFUSCATOR_9();
		}
		if (!IPANIAGAHCA && IPLFCIAEGGK)
		{
			IPANIAGAHCA = base.gameObject.AddComponent<DetonatorSmoke>();
			IPANIAGAHCA.__BB_OBFUSCATOR_81();
		}
		if (!KBLDLECJNGB && LNCPJNEMDBM)
		{
			KBLDLECJNGB = base.gameObject.AddComponent<DetonatorSparks>();
			KBLDLECJNGB.__BB_OBFUSCATOR_75();
		}
		if (!OPEBENDACBH && MPMHEGDLDGE)
		{
			OPEBENDACBH = base.gameObject.AddComponent<DetonatorShockwave>();
			OPEBENDACBH.__BB_OBFUSCATOR_57();
		}
		if (!AIEKFKBMNFI && OLOACLAJGPC)
		{
			AIEKFKBMNFI = base.gameObject.AddComponent<DetonatorGlow>();
			AIEKFKBMNFI.__BB_OBFUSCATOR_53();
		}
		if (!KCJFKFEINIH && FBGJPMBFBHK)
		{
			KCJFKFEINIH = base.gameObject.AddComponent<DetonatorLight>();
			KCJFKFEINIH.__BB_OBFUSCATOR_37();
		}
		if (!GBIDGDLCOPH && LEPHINODGJM)
		{
			GBIDGDLCOPH = base.gameObject.AddComponent<DetonatorForce>();
			GBIDGDLCOPH.__BB_OBFUSCATOR_36();
		}
		if (!JINNABLHEML && PKAMPGKIDCH && SystemInfo.supportsImageEffects)
		{
			JINNABLHEML = base.gameObject.AddComponent<DetonatorHeatwave>();
			JINNABLHEML.Reset();
		}
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
	}

	public void Explode()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i++)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			UpdateComponents();
			detonatorComponent.Explode();
		}
	}

	public static Material __BB_OBFUSCATOR_47()
	{
		if (IKLIKFCFCNH != null)
		{
			return IKLIKFCFCNH;
		}
		IKLIKFCFCNH = new Material(Shader.Find("TeamName"));
		IKLIKFCFCNH.name = "3";
		Texture2D mainTexture = Resources.Load("CameraFilterPack/OldFilm_Cutting2") as Texture2D;
		IKLIKFCFCNH.SetColor("Attack", Color.white);
		IKLIKFCFCNH.mainTexture = mainTexture;
		IKLIKFCFCNH.mainTextureScale = new Vector2(1995f, 477f);
		return IKLIKFCFCNH;
	}

	public static Material __BB_OBFUSCATOR_25()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("Language"));
		AMIIMFLDGPL.name = "ServerID";
		Texture2D mainTexture = Resources.Load(">") as Texture2D;
		AMIIMFLDGPL.SetColor("Network", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(376f, 1689f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(321f, 1763f);
		return AMIIMFLDGPL;
	}

	public static Material __BB_OBFUSCATOR_11()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("SUR/"));
		BFHMAIPECAJ.name = "_Value";
		Texture2D mainTexture = Resources.Load("Ping") as Texture2D;
		BFHMAIPECAJ.SetColor(">", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (KKPABCIFCLM > 978f && OPADOPLLMNE + KKPABCIFCLM <= Time.time)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (PNKNNGNGCGA)
		{
			Component[] fNLMFDIEJMN = FNLMFDIEJMN;
			for (int i = 0; i < fNLMFDIEJMN.Length; i += 0)
			{
				DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
				detonatorComponent.Init();
				detonatorComponent.SetStartValues();
			}
			PNKNNGNGCGA = false;
		}
		if (PNKNNGNGCGA)
		{
			return;
		}
		Component[] fNLMFDIEJMN2 = FNLMFDIEJMN;
		for (int j = 1; j < fNLMFDIEJMN2.Length; j += 0)
		{
			DetonatorComponent detonatorComponent2 = (DetonatorComponent)fNLMFDIEJMN2[j];
			if (detonatorComponent2.KPMHIHPFGMB)
			{
				detonatorComponent2.EEDMLOPHDJA = detonatorComponent2.IOAKGDAKKEE * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.PJKHHCHLFIF = LCLHCEHHBNM / BNCCIDBIPBF;
				detonatorComponent2.NCGMMIBMBEL = detonatorComponent2.CLLMMGIJIBC * NCGMMIBMBEL;
				detonatorComponent2.ICPDBNNPACO = detonatorComponent2.IIHAGBLLJBA * (EEDMLOPHDJA / KBGFHOJODBF) + INBMDEIBLKA * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.PACAMLAINIK = detonatorComponent2.OHNEBJKDAOD * (EEDMLOPHDJA / KBGFHOJODBF) + INBMDEIBLKA * (EEDMLOPHDJA / KBGFHOJODBF);
				detonatorComponent2.IOFNOJHNJAJ = Color.Lerp(detonatorComponent2.EOEMJCCFMEE, IOFNOJHNJAJ, IOFNOJHNJAJ.a);
			}
		}
	}

	public static Material __BB_OBFUSCATOR_6()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("_Value3"));
		AMIIMFLDGPL.name = "_ClutTex";
		Texture2D mainTexture = Resources.Load(">") as Texture2D;
		AMIIMFLDGPL.SetColor("_Offsets", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(1877f, 128f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(1359f, 875f);
		return AMIIMFLDGPL;
	}

	public static Material __BB_OBFUSCATOR_29()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("<size="));
		AMIIMFLDGPL.name = "_Bullet_5";
		Texture2D mainTexture = Resources.Load("Wood") as Texture2D;
		AMIIMFLDGPL.SetColor("TRACKING", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(525f, 1752f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(654f, 1981f);
		return AMIIMFLDGPL;
	}

	public static Material __BB_OBFUSCATOR_56()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find("ServerID"));
		BPLPBIHMPEP.name = "Purchase";
		Texture2D mainTexture = Resources.Load("CameraFilterPack/TV_Chromatical") as Texture2D;
		BPLPBIHMPEP.SetColor("_Value4", new Color(10f, 33f, 779f, 932f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	public void __BB_OBFUSCATOR_43()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i += 0)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			__BB_OBFUSCATOR_57();
			detonatorComponent.Explode();
		}
	}

	public void __BB_OBFUSCATOR_49()
	{
		EEDMLOPHDJA = 467f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		LCLHCEHHBNM = BNCCIDBIPBF;
		__BB_OBFUSCATOR_24();
	}

	public static Material __BB_OBFUSCATOR_26()
	{
		if (IKLIKFCFCNH != null)
		{
			return IKLIKFCFCNH;
		}
		IKLIKFCFCNH = new Material(Shader.Find("ResetObject"));
		IKLIKFCFCNH.name = "_ScreenResolution";
		Texture2D mainTexture = Resources.Load("Cluster") as Texture2D;
		IKLIKFCFCNH.SetColor(">", Color.white);
		IKLIKFCFCNH.mainTexture = mainTexture;
		IKLIKFCFCNH.mainTextureScale = new Vector2(987f, 1461f);
		return IKLIKFCFCNH;
	}

	public void Reset()
	{
		EEDMLOPHDJA = 10f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		LCLHCEHHBNM = BNCCIDBIPBF;
		FillDefaultMaterials();
	}

	private void Awake()
	{
		FillDefaultMaterials();
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i++)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			if (detonatorComponent is DetonatorFireball)
			{
				EEOEFCPMNGE = detonatorComponent as DetonatorFireball;
			}
			if (detonatorComponent is DetonatorSparks)
			{
				KBLDLECJNGB = detonatorComponent as DetonatorSparks;
			}
			if (detonatorComponent is DetonatorShockwave)
			{
				OPEBENDACBH = detonatorComponent as DetonatorShockwave;
			}
			if (detonatorComponent is DetonatorSmoke)
			{
				IPANIAGAHCA = detonatorComponent as DetonatorSmoke;
			}
			if (detonatorComponent is DetonatorGlow)
			{
				AIEKFKBMNFI = detonatorComponent as DetonatorGlow;
			}
			if (detonatorComponent is DetonatorLight)
			{
				KCJFKFEINIH = detonatorComponent as DetonatorLight;
			}
			if (detonatorComponent is DetonatorForce)
			{
				GBIDGDLCOPH = detonatorComponent as DetonatorForce;
			}
			if (detonatorComponent is DetonatorHeatwave)
			{
				JINNABLHEML = detonatorComponent as DetonatorHeatwave;
			}
		}
		if (!EEOEFCPMNGE && ACBCLONBCBL)
		{
			EEOEFCPMNGE = base.gameObject.AddComponent<DetonatorFireball>();
			EEOEFCPMNGE.Reset();
		}
		if (!IPANIAGAHCA && IPLFCIAEGGK)
		{
			IPANIAGAHCA = base.gameObject.AddComponent<DetonatorSmoke>();
			IPANIAGAHCA.Reset();
		}
		if (!KBLDLECJNGB && LNCPJNEMDBM)
		{
			KBLDLECJNGB = base.gameObject.AddComponent<DetonatorSparks>();
			KBLDLECJNGB.Reset();
		}
		if (!OPEBENDACBH && MPMHEGDLDGE)
		{
			OPEBENDACBH = base.gameObject.AddComponent<DetonatorShockwave>();
			OPEBENDACBH.Reset();
		}
		if (!AIEKFKBMNFI && OLOACLAJGPC)
		{
			AIEKFKBMNFI = base.gameObject.AddComponent<DetonatorGlow>();
			AIEKFKBMNFI.Reset();
		}
		if (!KCJFKFEINIH && FBGJPMBFBHK)
		{
			KCJFKFEINIH = base.gameObject.AddComponent<DetonatorLight>();
			KCJFKFEINIH.Reset();
		}
		if (!GBIDGDLCOPH && LEPHINODGJM)
		{
			GBIDGDLCOPH = base.gameObject.AddComponent<DetonatorForce>();
			GBIDGDLCOPH.Reset();
		}
		if (!JINNABLHEML && PKAMPGKIDCH && SystemInfo.supportsImageEffects)
		{
			JINNABLHEML = base.gameObject.AddComponent<DetonatorHeatwave>();
			JINNABLHEML.Reset();
		}
		FNLMFDIEJMN = GetComponents(typeof(DetonatorComponent));
	}

	public static Material __BB_OBFUSCATOR_53()
	{
		if (LCDLJABOOBN != null)
		{
			return LCDLJABOOBN;
		}
		LCDLJABOOBN = new Material(Shader.Find("b"));
		LCDLJABOOBN.name = "box";
		Texture2D mainTexture = Resources.Load("_Value") as Texture2D;
		LCDLJABOOBN.SetColor("Count", Color.white);
		LCDLJABOOBN.mainTexture = mainTexture;
		LCDLJABOOBN.mainTextureScale = new Vector2(19f, 1285f);
		return LCDLJABOOBN;
	}

	public static Material __BB_OBFUSCATOR_30()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("_Value"));
		PDOKKCJABHI.name = "_ScreenResolution";
		Texture2D mainTexture = Resources.Load("{0}:{1}") as Texture2D;
		PDOKKCJABHI.SetColor("_Value3", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	private void Update()
	{
		if (KKPABCIFCLM > 0f && OPADOPLLMNE + KKPABCIFCLM <= Time.time)
		{
			Object.Destroy(base.gameObject);
		}
	}

	public static Material __BB_OBFUSCATOR_35()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("Label"));
		BFHMAIPECAJ.name = "Crouch";
		Texture2D mainTexture = Resources.Load("_Value2") as Texture2D;
		BFHMAIPECAJ.SetColor("name", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public static Material __BB_OBFUSCATOR_14()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("Player"));
		BFHMAIPECAJ.name = "_ScreenResolution";
		Texture2D mainTexture = Resources.Load("Player") as Texture2D;
		BFHMAIPECAJ.SetColor("n15", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!DHGANMBLNNK)
		{
			DHGANMBLNNK = __BB_OBFUSCATOR_9();
		}
		if (!FMNGJEGCFIE)
		{
			FMNGJEGCFIE = DefaultFireballBMaterial();
		}
		if (!NLCJNPAMOEH)
		{
			NLCJNPAMOEH = __BB_OBFUSCATOR_53();
		}
		if (!KDNNLMHFKOJ)
		{
			KDNNLMHFKOJ = __BB_OBFUSCATOR_42();
		}
		if (!LPBFFNKMPBF)
		{
			LPBFFNKMPBF = __BB_OBFUSCATOR_18();
		}
		if (!OOBJJKOBLHO)
		{
			OOBJJKOBLHO = __BB_OBFUSCATOR_52();
		}
		if (!NENOJAIPONP)
		{
			NENOJAIPONP = DefaultGlowMaterial();
		}
		if (!JFCAMPLCDPL)
		{
			JFCAMPLCDPL = DefaultHeatwaveMaterial();
		}
	}

	public static Material __BB_OBFUSCATOR_19()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("_Distortion"));
		AMIIMFLDGPL.name = "\tAmbientRenderSettings:  {\n\t\tVersion: 101\n\t\tAmbientLightColor: 0.0,0.0,0.0,0\n\t}\n\tFogOptions:  {\n\t\tFogEnable: 0\n\t\tFogMode: 0\n\t\tFogDensity: 0.000\n\t\tFogStart: 5.000\n\t\tFogEnd: 25.000\n\t\tFogColor: 0.1,0.1,0.1,1\n\t}\n\tSettings:  {\n\t\tFrameRate: \"24\"\n\t\tTimeFormat: 1\n\t\tSnapOnFrames: 0\n\t\tReferenceTimeIndex: -1\n\t\tTimeLineStartTime: 0\n\t\tTimeLineStopTime: 479181389250\n\t}\n\tRendererSetting:  {\n\t\tDefaultCamera: \"Producer Perspective\"\n\t\tDefaultViewingMode: 0\n\t}\n";
		Texture2D mainTexture = Resources.Load("CameraFilterPack/Color_GrayScale") as Texture2D;
		AMIIMFLDGPL.SetColor("CameraFilterPack/Vision_Drost", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(1513f, 1533f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(1027f, 1024f);
		return AMIIMFLDGPL;
	}

	public static Material __BB_OBFUSCATOR_58()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("_TimeX"));
		PDOKKCJABHI.name = "<color=";
		Texture2D mainTexture = Resources.Load("PlayerFellDown") as Texture2D;
		PDOKKCJABHI.SetColor("_Distortion", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	public static Material DefaultSmokeBMaterial()
	{
		if (AMIIMFLDGPL != null)
		{
			return AMIIMFLDGPL;
		}
		AMIIMFLDGPL = new Material(Shader.Find("Particles/Alpha Blended"));
		AMIIMFLDGPL.name = "SmokeB-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Smoke") as Texture2D;
		AMIIMFLDGPL.SetColor("_TintColor", Color.white);
		AMIIMFLDGPL.mainTexture = mainTexture;
		AMIIMFLDGPL.mainTextureScale = new Vector2(0.5f, 1f);
		AMIIMFLDGPL.mainTextureOffset = new Vector2(0.5f, 0f);
		return AMIIMFLDGPL;
	}

	public static Material __BB_OBFUSCATOR_44()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("<size="));
		PDOKKCJABHI.name = "_Value";
		Texture2D mainTexture = Resources.Load("_Value2") as Texture2D;
		PDOKKCJABHI.SetColor(": ", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	public static Material __BB_OBFUSCATOR_4()
	{
		if (IKLIKFCFCNH != null)
		{
			return IKLIKFCFCNH;
		}
		IKLIKFCFCNH = new Material(Shader.Find(" "));
		IKLIKFCFCNH.name = "red";
		Texture2D mainTexture = Resources.Load("Cannot Sell") as Texture2D;
		IKLIKFCFCNH.SetColor("CameraFilterPack/TV_50", Color.white);
		IKLIKFCFCNH.mainTexture = mainTexture;
		IKLIKFCFCNH.mainTextureScale = new Vector2(416f, 1794f);
		return IKLIKFCFCNH;
	}

	public static Material DefaultFireballBMaterial()
	{
		if (BIBAEIKBJJF != null)
		{
			return BIBAEIKBJJF;
		}
		BIBAEIKBJJF = new Material(Shader.Find("Particles/Additive"));
		BIBAEIKBJJF.name = "FireballB-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Fireball") as Texture2D;
		BIBAEIKBJJF.SetColor("_TintColor", Color.white);
		BIBAEIKBJJF.mainTexture = mainTexture;
		BIBAEIKBJJF.mainTextureScale = new Vector2(0.5f, 1f);
		BIBAEIKBJJF.mainTextureOffset = new Vector2(0.5f, 0f);
		return BIBAEIKBJJF;
	}

	public static Material __BB_OBFUSCATOR_21()
	{
		if (BIBAEIKBJJF != null)
		{
			return BIBAEIKBJJF;
		}
		BIBAEIKBJJF = new Material(Shader.Find("_Gain"));
		BIBAEIKBJJF.name = "_LowRez";
		Texture2D mainTexture = Resources.Load("INF") as Texture2D;
		BIBAEIKBJJF.SetColor("_Blue_C", Color.white);
		BIBAEIKBJJF.mainTexture = mainTexture;
		BIBAEIKBJJF.mainTextureScale = new Vector2(1407f, 11f);
		BIBAEIKBJJF.mainTextureOffset = new Vector2(1551f, 142f);
		return BIBAEIKBJJF;
	}

	public static Material __BB_OBFUSCATOR_27()
	{
		if (BPLPBIHMPEP != null)
		{
			return BPLPBIHMPEP;
		}
		BPLPBIHMPEP = new Material(Shader.Find(" Waypoint Target"));
		BPLPBIHMPEP.name = "_Red_B";
		Texture2D mainTexture = Resources.Load("MapName") as Texture2D;
		BPLPBIHMPEP.SetColor("_Offsets", new Color(1920f, 1436f, 1810f, 967f));
		BPLPBIHMPEP.mainTexture = mainTexture;
		return BPLPBIHMPEP;
	}

	public static Material __BB_OBFUSCATOR_9()
	{
		if (IKLIKFCFCNH != null)
		{
			return IKLIKFCFCNH;
		}
		IKLIKFCFCNH = new Material(Shader.Find("Difficulty"));
		IKLIKFCFCNH.name = "Walk";
		Texture2D mainTexture = Resources.Load(">") as Texture2D;
		IKLIKFCFCNH.SetColor("Ping", Color.white);
		IKLIKFCFCNH.mainTexture = mainTexture;
		IKLIKFCFCNH.mainTextureScale = new Vector2(577f, 1810f);
		return IKLIKFCFCNH;
	}

	private void FillDefaultMaterials()
	{
		if (!DHGANMBLNNK)
		{
			DHGANMBLNNK = DefaultFireballAMaterial();
		}
		if (!FMNGJEGCFIE)
		{
			FMNGJEGCFIE = DefaultFireballBMaterial();
		}
		if (!NLCJNPAMOEH)
		{
			NLCJNPAMOEH = DefaultSmokeAMaterial();
		}
		if (!KDNNLMHFKOJ)
		{
			KDNNLMHFKOJ = DefaultSmokeBMaterial();
		}
		if (!LPBFFNKMPBF)
		{
			LPBFFNKMPBF = DefaultShockwaveMaterial();
		}
		if (!OOBJJKOBLHO)
		{
			OOBJJKOBLHO = DefaultSparksMaterial();
		}
		if (!NENOJAIPONP)
		{
			NENOJAIPONP = DefaultGlowMaterial();
		}
		if (!JFCAMPLCDPL)
		{
			JFCAMPLCDPL = DefaultHeatwaveMaterial();
		}
	}

	public static Material __BB_OBFUSCATOR_52()
	{
		if (PDOKKCJABHI != null)
		{
			return PDOKKCJABHI;
		}
		PDOKKCJABHI = new Material(Shader.Find("Language"));
		PDOKKCJABHI.name = "Wood";
		Texture2D mainTexture = Resources.Load("_TimeX") as Texture2D;
		PDOKKCJABHI.SetColor("1.2", Color.white);
		PDOKKCJABHI.mainTexture = mainTexture;
		return PDOKKCJABHI;
	}

	public static Material DefaultGlowMaterial()
	{
		if (BFHMAIPECAJ != null)
		{
			return BFHMAIPECAJ;
		}
		BFHMAIPECAJ = new Material(Shader.Find("Particles/Additive"));
		BFHMAIPECAJ.name = "Glow-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Glow") as Texture2D;
		BFHMAIPECAJ.SetColor("_TintColor", Color.white);
		BFHMAIPECAJ.mainTexture = mainTexture;
		return BFHMAIPECAJ;
	}

	public static Material DefaultFireballAMaterial()
	{
		if (IKLIKFCFCNH != null)
		{
			return IKLIKFCFCNH;
		}
		IKLIKFCFCNH = new Material(Shader.Find("Particles/Additive"));
		IKLIKFCFCNH.name = "FireballA-Default";
		Texture2D mainTexture = Resources.Load("Detonator/Textures/Fireball") as Texture2D;
		IKLIKFCFCNH.SetColor("_TintColor", Color.white);
		IKLIKFCFCNH.mainTexture = mainTexture;
		IKLIKFCFCNH.mainTextureScale = new Vector2(0.5f, 1f);
		return IKLIKFCFCNH;
	}

	public void __BB_OBFUSCATOR_50()
	{
		OPADOPLLMNE = Time.time;
		Component[] fNLMFDIEJMN = FNLMFDIEJMN;
		for (int i = 0; i < fNLMFDIEJMN.Length; i++)
		{
			DetonatorComponent detonatorComponent = (DetonatorComponent)fNLMFDIEJMN[i];
			UpdateComponents();
			detonatorComponent.Explode();
		}
	}

	private void Start()
	{
		if (LIPKHINMGCG)
		{
			UpdateComponents();
			Explode();
		}
	}

	public void __BB_OBFUSCATOR_37()
	{
		EEDMLOPHDJA = 1030f;
		IOFNOJHNJAJ = LNKOBAPEIIM;
		LCLHCEHHBNM = BNCCIDBIPBF;
		__BB_OBFUSCATOR_32();
	}
}
