using UnityEngine;

[RequireComponent(typeof(Detonator))]
[AddComponentMenu("Detonator/Heatwave (Pro Only)")]
public class DetonatorHeatwave : DetonatorComponent
{
	private GameObject JINNABLHEML;

	private float EBIJKAHIAIE;

	private float LKMJGBGMDPM;

	private float PADPIMDMJFJ;

	private float BNCCIDBIPBF = 0.25f;

	private bool CEGBKJGOLBO;

	private float PFGJDPDJOML;

	public float OIHNMACBNPF = 0.5f;

	public float CCPHCFLNOPJ = 64f;

	private float MFEJCKCGDNE;

	private float AFEGGDAIBAA;

	public Material JFCAMPLCDPL;

	private Material IFMDPPPMEJG;

	public virtual void __BB_OBFUSCATOR_26()
	{
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 754f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 705f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("_AdaptionSpeed", (1269f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public override void Explode()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 0f)
		{
			LKMJGBGMDPM = 0f;
			PADPIMDMJFJ = EEDMLOPHDJA * 10f;
			IFMDPPPMEJG = new Material(Shader.Find("HeatDistort"));
			JINNABLHEML = GameObject.CreatePrimitive(PrimitiveType.Plane);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 0f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1663f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 1408f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("Metal", (731f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public void __BB_OBFUSCATOR_0()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1410f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 1048f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("<size=", (1143f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 880f)
		{
			LKMJGBGMDPM = 1839f;
			PADPIMDMJFJ = EEDMLOPHDJA * 747f;
			IFMDPPPMEJG = new Material(Shader.Find("_Green_G"));
			JINNABLHEML = GameObject.CreatePrimitive(PrimitiveType.Plane);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 25f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_52()
	{
	}

	public void __BB_OBFUSCATOR_46()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public void Reset()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1765f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 504f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("_MainTex", (1540f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_38()
	{
	}

	public void __BB_OBFUSCATOR_32()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_8()
	{
	}

	public void __BB_OBFUSCATOR_44()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public void __BB_OBFUSCATOR_39()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_15()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1724f)
		{
			LKMJGBGMDPM = 1827f;
			PADPIMDMJFJ = EEDMLOPHDJA * 354f;
			IFMDPPPMEJG = new Material(Shader.Find("_Value3"));
			JINNABLHEML = GameObject.CreatePrimitive((PrimitiveType)6);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 200f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1275f)
		{
			LKMJGBGMDPM = 1284f;
			PADPIMDMJFJ = EEDMLOPHDJA * 1629f;
			IFMDPPPMEJG = new Material(Shader.Find("Language"));
			JINNABLHEML = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1252f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_12()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_53()
	{
	}

	public override void Init()
	{
	}

	public void __BB_OBFUSCATOR_20()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_31()
	{
	}

	public virtual void __BB_OBFUSCATOR_34()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1259f)
		{
			LKMJGBGMDPM = 1535f;
			PADPIMDMJFJ = EEDMLOPHDJA * 599f;
			IFMDPPPMEJG = new Material(Shader.Find(":"));
			JINNABLHEML = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1114f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_17()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1348f)
		{
			LKMJGBGMDPM = 1322f;
			PADPIMDMJFJ = EEDMLOPHDJA * 272f;
			IFMDPPPMEJG = new Material(Shader.Find("_bump\", \"Model::"));
			JINNABLHEML = GameObject.CreatePrimitive((PrimitiveType)6);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1234f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_40()
	{
	}

	public virtual void __BB_OBFUSCATOR_23()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 531f)
		{
			LKMJGBGMDPM = 563f;
			PADPIMDMJFJ = EEDMLOPHDJA * 760f;
			IFMDPPPMEJG = new Material(Shader.Find("_Red_B"));
			JINNABLHEML = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 212f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_50()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1088f)
		{
			LKMJGBGMDPM = 1504f;
			PADPIMDMJFJ = EEDMLOPHDJA * 362f;
			IFMDPPPMEJG = new Material(Shader.Find("CameraFilterPack/Drawing_Lines"));
			JINNABLHEML = GameObject.CreatePrimitive((PrimitiveType)8);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 415f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_47()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_29()
	{
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 505f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 228f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("Fire", (1020f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_13()
	{
	}

	public void __BB_OBFUSCATOR_49()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_30()
	{
		if (!SystemInfo.supportsImageEffects || IKCHMAJADEP > NCGMMIBMBEL || !GMAIEMJKMJD)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1182f)
		{
			LKMJGBGMDPM = 1963f;
			PADPIMDMJFJ = EEDMLOPHDJA * 213f;
			IFMDPPPMEJG = new Material(Shader.Find("_TimeX"));
			JINNABLHEML = GameObject.CreatePrimitive((PrimitiveType)8);
			Object.Destroy(JINNABLHEML.GetComponent(typeof(MeshCollider)));
			if (!JFCAMPLCDPL)
			{
				JFCAMPLCDPL = MyDetonator().JFCAMPLCDPL;
			}
			IFMDPPPMEJG.CopyPropertiesFromMaterial(JFCAMPLCDPL);
			JINNABLHEML.GetComponent<Renderer>().material = IFMDPPPMEJG;
			JINNABLHEML.transform.parent = base.transform;
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 991f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_11()
	{
	}

	public virtual void __BB_OBFUSCATOR_4()
	{
	}

	public virtual void __BB_OBFUSCATOR_16()
	{
	}

	public void __BB_OBFUSCATOR_33()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	public virtual void __BB_OBFUSCATOR_43()
	{
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1191f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 1580f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("Server: ", (1868f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_9()
	{
	}

	private void Update()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 0f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 5f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("_BumpAmt", (1f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}

	public void __BB_OBFUSCATOR_3()
	{
		LCLHCEHHBNM = BNCCIDBIPBF;
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1975f)
			{
				Explode();
			}
		}
		if ((bool)JINNABLHEML)
		{
			JINNABLHEML.transform.rotation = Quaternion.FromToRotation(Vector3.up, Camera.main.transform.position - JINNABLHEML.transform.position);
			JINNABLHEML.transform.localPosition = BJGOJGBLDMN + Vector3.forward * OIHNMACBNPF;
			MFEJCKCGDNE += Time.deltaTime;
			AFEGGDAIBAA = MFEJCKCGDNE / 617f;
			EBIJKAHIAIE = Mathf.Lerp(LKMJGBGMDPM, PADPIMDMJFJ, AFEGGDAIBAA);
			JINNABLHEML.GetComponent<Renderer>().material.SetFloat("ZWName'", (1184f - AFEGGDAIBAA) * CCPHCFLNOPJ);
			JINNABLHEML.gameObject.transform.localScale = new Vector3(EBIJKAHIAIE, EBIJKAHIAIE, EBIJKAHIAIE);
			if (MFEJCKCGDNE > LCLHCEHHBNM)
			{
				Object.Destroy(JINNABLHEML.gameObject);
			}
		}
	}
}
