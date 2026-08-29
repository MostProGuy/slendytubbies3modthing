using UnityEngine;

[AddComponentMenu("Detonator/Sound")]
[RequireComponent(typeof(Detonator))]
public class DetonatorSound : DetonatorComponent
{
	public AudioClip[] MBILBJIMMNP;

	public AudioClip[] ACLBMMALIJB;

	public float JNLDIOBANME = 50f;

	public float LIEEGPLOCKA = 0.4f;

	public float MOFEBPGAICK = 1f;

	public float EHKKLNDANBF = 0.5f;

	private AudioSource AGPGNJNEOAA;

	private bool CEGBKJGOLBO;

	private float PFGJDPDJOML;

	private int PIODCIJHPNB;

	public virtual void __BB_OBFUSCATOR_37()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 825f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 916f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public override void Explode()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 0f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 0f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_44()
	{
	}

	public void __BB_OBFUSCATOR_61()
	{
	}

	public void Reset()
	{
	}

	public virtual void __BB_OBFUSCATOR_36()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1234f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1848f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 966f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_32()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public void __BB_OBFUSCATOR_50()
	{
	}

	private void __BB_OBFUSCATOR_41()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1508f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1481f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1440f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_47()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1488f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 986f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_18()
	{
	}

	public void __BB_OBFUSCATOR_58()
	{
	}

	private void __BB_OBFUSCATOR_55()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 15f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_64()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_62()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public void __BB_OBFUSCATOR_35()
	{
	}

	public void __BB_OBFUSCATOR_22()
	{
	}

	public virtual void __BB_OBFUSCATOR_12()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	private void Update()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 0f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_16()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 342f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 505f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_53()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_46()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_59()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 604f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1431f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_57()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_21()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	private void __BB_OBFUSCATOR_60()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1370f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_0()
	{
	}

	public void __BB_OBFUSCATOR_28()
	{
	}

	public void __BB_OBFUSCATOR_7()
	{
	}

	public virtual void __BB_OBFUSCATOR_4()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 529f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 1710f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public override void Init()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_24()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 237f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 423f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_51()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 947f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 714f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_66()
	{
	}

	public void __BB_OBFUSCATOR_14()
	{
	}

	public void __BB_OBFUSCATOR_43()
	{
	}

	public void __BB_OBFUSCATOR_45()
	{
	}

	private void __BB_OBFUSCATOR_11()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 302f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1150f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_19()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_40()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_20()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 755f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = true;
			PFGJDPDJOML = 833f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1583f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_38()
	{
	}

	public virtual void __BB_OBFUSCATOR_8()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_6()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_63()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1221f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 1609f;
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 93f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_33()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_2()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_52()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_42()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	private void __BB_OBFUSCATOR_29()
	{
		AGPGNJNEOAA.pitch = Time.timeScale;
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1693f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_48()
	{
		if (IKCHMAJADEP > NCGMMIBMBEL)
		{
			return;
		}
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1378f)
		{
			if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < JNLDIOBANME)
			{
				PIODCIJHPNB = (int)(Random.value * (float)MBILBJIMMNP.Length);
				AGPGNJNEOAA.PlayOneShot(MBILBJIMMNP[PIODCIJHPNB]);
			}
			else
			{
				PIODCIJHPNB = (int)(Random.value * (float)ACLBMMALIJB.Length);
				AGPGNJNEOAA.PlayOneShot(ACLBMMALIJB[PIODCIJHPNB]);
			}
			CEGBKJGOLBO = false;
			PFGJDPDJOML = 886f;
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_26()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public virtual void __BB_OBFUSCATOR_1()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}

	public void __BB_OBFUSCATOR_30()
	{
	}

	public virtual void __BB_OBFUSCATOR_9()
	{
		AGPGNJNEOAA = base.gameObject.AddComponent<AudioSource>();
	}
}
