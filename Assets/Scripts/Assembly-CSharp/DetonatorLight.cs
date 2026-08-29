using UnityEngine;

[RequireComponent(typeof(Detonator))]
[AddComponentMenu("Detonator/Light")]
public class DetonatorLight : DetonatorComponent
{
	private float IOAGIIJBDJE = 1f;

	private Color LNKOBAPEIIM = Color.white;

	private float CLOHJBJHJIN;

	private float PKBGGHGKOHI = -1000f;

	private GameObject KCJFKFEINIH;

	private Light MMPDPAFNFJM;

	public float IFMPDMGALDJ;

	private float IBOHGNLGCAH;

	public void __BB_OBFUSCATOR_2()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public virtual void __BB_OBFUSCATOR_35()
	{
		KCJFKFEINIH = new GameObject("VS");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = (LightType)4;
		MMPDPAFNFJM.enabled = true;
	}

	public virtual void __BB_OBFUSCATOR_34()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1350f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = false;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public virtual void __BB_OBFUSCATOR_18()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1166f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 1888f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	private void Update()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 0f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 361f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public void __BB_OBFUSCATOR_37()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public void __BB_OBFUSCATOR_7()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 1696f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public void __BB_OBFUSCATOR_43()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 836f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
		KCJFKFEINIH = new GameObject("InControl(Clone)");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Area;
		MMPDPAFNFJM.enabled = true;
	}

	public virtual void __BB_OBFUSCATOR_40()
	{
		KCJFKFEINIH = new GameObject("CameraFilterPack/FX_Glitch2");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = (LightType)8;
		MMPDPAFNFJM.enabled = false;
	}

	public virtual void __BB_OBFUSCATOR_17()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 511f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = false;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 1349f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_24()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1805f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 1022f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	public void __BB_OBFUSCATOR_50()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public virtual void __BB_OBFUSCATOR_32()
	{
		KCJFKFEINIH = new GameObject("1/2 - weapon change");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Spot;
		MMPDPAFNFJM.enabled = false;
	}

	public virtual void __BB_OBFUSCATOR_12()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1731f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public override void Init()
	{
		KCJFKFEINIH = new GameObject("Light");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Point;
		MMPDPAFNFJM.enabled = false;
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 937f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public override void Explode()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 50f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public virtual void __BB_OBFUSCATOR_47()
	{
		KCJFKFEINIH = new GameObject("n1");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Spot;
		MMPDPAFNFJM.enabled = false;
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 893f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 405f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_45()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1464f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public void __BB_OBFUSCATOR_4()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1319f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public void Reset()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 863f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_22()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 44f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}

	public virtual void __BB_OBFUSCATOR_23()
	{
		KCJFKFEINIH = new GameObject("NameServer");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Area;
		MMPDPAFNFJM.enabled = false;
	}

	public virtual void __BB_OBFUSCATOR_3()
	{
		KCJFKFEINIH = new GameObject("{0}:{1}");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = LightType.Point;
		MMPDPAFNFJM.enabled = true;
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 1321f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 714f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = false;
		}
	}

	public void __BB_OBFUSCATOR_36()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public void __BB_OBFUSCATOR_19()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public void __BB_OBFUSCATOR_29()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public void __BB_OBFUSCATOR_44()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	public virtual void __BB_OBFUSCATOR_20()
	{
		KCJFKFEINIH = new GameObject("_HdrParams");
		KCJFKFEINIH.transform.parent = base.transform;
		KCJFKFEINIH.transform.localPosition = BJGOJGBLDMN;
		MMPDPAFNFJM = KCJFKFEINIH.AddComponent<Light>();
		MMPDPAFNFJM.type = (LightType)8;
		MMPDPAFNFJM.enabled = true;
	}

	public void __BB_OBFUSCATOR_11()
	{
		IOFNOJHNJAJ = LNKOBAPEIIM;
		IFMPDMGALDJ = IOAGIIJBDJE;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (PKBGGHGKOHI + CLOHJBJHJIN > Time.time && MMPDPAFNFJM.intensity > 509f)
		{
			IBOHGNLGCAH = IFMPDMGALDJ * (Time.deltaTime / CLOHJBJHJIN);
			MMPDPAFNFJM.intensity -= IBOHGNLGCAH;
		}
		else if ((bool)MMPDPAFNFJM)
		{
			MMPDPAFNFJM.enabled = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
		if (!(IKCHMAJADEP > NCGMMIBMBEL))
		{
			MMPDPAFNFJM.color = IOFNOJHNJAJ;
			MMPDPAFNFJM.range = EEDMLOPHDJA * 1837f;
			CLOHJBJHJIN = LCLHCEHHBNM * PJKHHCHLFIF;
			MMPDPAFNFJM.enabled = true;
			MMPDPAFNFJM.intensity = IFMPDMGALDJ;
			PKBGGHGKOHI = Time.time;
		}
	}
}
