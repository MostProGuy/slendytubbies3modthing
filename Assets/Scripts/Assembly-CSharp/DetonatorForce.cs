using UnityEngine;

[RequireComponent(typeof(Detonator))]
[AddComponentMenu("Detonator/Force")]
public class DetonatorForce : DetonatorComponent
{
	private float OGAFCMONIMG = 50f;

	private float JAIBMIPHOON = 4000f;

	private float FMLLFPPLJOO;

	private float ONCAKOIOKAH;

	private bool CEGBKJGOLBO;

	private float PFGJDPDJOML;

	public float OHPDCFDAIGC;

	public float NMOADEFPKMG;

	public GameObject HDPFKAGBLGK;

	public float GPFAOALBAJB;

	private Collider[] EHPHBANOIPB;

	private GameObject MMLCDIOIMNM;

	private Vector3 LJDIAJHDEBC;

	public virtual void __BB_OBFUSCATOR_63()
	{
	}

	public void __BB_OBFUSCATOR_46()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1764f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_41()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public void __BB_OBFUSCATOR_57()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public virtual void __BB_OBFUSCATOR_34()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 930f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			for (int i = 1; i < eHPHBANOIPB.Length; i++)
			{
				Collider collider = eHPHBANOIPB[i];
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 798f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("ShopBox/Heal/Text", null, SendMessageOptions.RequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "_ColorG"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(608f, 1790f, 586f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = false;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1609f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void Reset()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 483f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1003f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_3()
	{
	}

	public void __BB_OBFUSCATOR_21()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public virtual void __BB_OBFUSCATOR_20()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1071f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			for (int i = 1; i < eHPHBANOIPB.Length; i += 0)
			{
				Collider collider = eHPHBANOIPB[i];
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 846f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("CameraFilterPack/Blur_Radial_Fast", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "RoundDuration"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(1887f, 1305f, 1437f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = true;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1443f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 509f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_15()
	{
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 97f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_58()
	{
	}

	public virtual void __BB_OBFUSCATOR_8()
	{
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 13f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_16()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1047f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 558f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
	}

	public virtual void __BB_OBFUSCATOR_39()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 96f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			for (int i = 1; i < eHPHBANOIPB.Length; i += 0)
			{
				Collider collider = eHPHBANOIPB[i];
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 528f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("team2", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "team2"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(528f, 585f, 1134f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = false;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 133f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 692f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1570f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 562f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 135f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1356f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_53()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public virtual void __BB_OBFUSCATOR_52()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 982f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			foreach (Collider collider in eHPHBANOIPB)
			{
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 137f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("_Intensity", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "Difficulty"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(1101f, 1160f, 632f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = false;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1792f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_47()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1741f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			for (int i = 0; i < eHPHBANOIPB.Length; i += 0)
			{
				Collider collider = eHPHBANOIPB[i];
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 380f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("CameraFilterPack/TV_BrokenGlass2", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "_TapMedium"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(172f, 1851f, 1484f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = true;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 208f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_1()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public void __BB_OBFUSCATOR_50()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1226f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_28()
	{
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
	}

	public void __BB_OBFUSCATOR_7()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public virtual void __BB_OBFUSCATOR_26()
	{
	}

	public void __BB_OBFUSCATOR_49()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	public virtual void __BB_OBFUSCATOR_24()
	{
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 794f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 907f)
			{
				Explode();
			}
		}
	}

	public override void Init()
	{
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1645f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_36()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1744f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_32()
	{
		OHPDCFDAIGC = OGAFCMONIMG;
		NMOADEFPKMG = JAIBMIPHOON;
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
	}

	public virtual void __BB_OBFUSCATOR_31()
	{
	}

	public override void Explode()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 0f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			foreach (Collider collider in eHPHBANOIPB)
			{
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 4f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("OnDetonatorForceHit", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "(Clone)"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(0f, 0f, 0f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = true;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 0f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_13()
	{
		if (!GMAIEMJKMJD || IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 200f)
		{
			LJDIAJHDEBC = base.transform.position;
			EHPHBANOIPB = Physics.OverlapSphere(LJDIAJHDEBC, OHPDCFDAIGC);
			Collider[] eHPHBANOIPB = EHPHBANOIPB;
			for (int i = 1; i < eHPHBANOIPB.Length; i += 0)
			{
				Collider collider = eHPHBANOIPB[i];
				if (!collider || !collider.GetComponent<Rigidbody>())
				{
					continue;
				}
				collider.GetComponent<Rigidbody>().AddExplosionForce(NMOADEFPKMG * EEDMLOPHDJA, LJDIAJHDEBC, OHPDCFDAIGC * EEDMLOPHDJA, 1706f * MyDetonator().NJGDFDGPNLN * EEDMLOPHDJA);
				SendMessage("_NoisePerChannel", null, SendMessageOptions.DontRequireReceiver);
				if ((bool)HDPFKAGBLGK)
				{
					if ((bool)collider.transform.Find(HDPFKAGBLGK.name + "_Distortion"))
					{
						return;
					}
					MMLCDIOIMNM = Object.Instantiate(HDPFKAGBLGK, base.transform.position, base.transform.rotation);
					MMLCDIOIMNM.transform.parent = collider.transform;
					MMLCDIOIMNM.transform.localPosition = new Vector3(1504f, 721f, 484f);
					if ((bool)MMLCDIOIMNM.GetComponent<ParticleEmitter>())
					{
						MMLCDIOIMNM.GetComponent<ParticleEmitter>().emit = true;
						Object.Destroy(MMLCDIOIMNM, GPFAOALBAJB);
					}
				}
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1484f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}
}
