using UnityEngine;

[RequireComponent(typeof(Detonator))]
[AddComponentMenu("Detonator/Object Spray")]
public class DetonatorSpray : DetonatorComponent
{
	public GameObject EIINLPJAKAF;

	public int FGMDPKFFANG = 10;

	public float EIJBFNBPFCD;

	public float KCADJIKIEBE = 1f;

	public float BHLAGABJKGK = 1f;

	private bool CEGBKJGOLBO;

	private float PFGJDPDJOML;

	private Vector3 LJDIAJHDEBC;

	private float LGGEGLFOOPK;

	public virtual void __BB_OBFUSCATOR_89()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 336f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1340f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1312f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1678f)
			{
				Explode();
			}
		}
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

	public virtual void __BB_OBFUSCATOR_35()
	{
	}

	public virtual void __BB_OBFUSCATOR_19()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 656f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1896f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 823f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 883f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_59()
	{
		PACAMLAINIK = new Vector3(356f, 178f, 1319f);
	}

	public void __BB_OBFUSCATOR_115()
	{
		PACAMLAINIK = new Vector3(135f, 1115f, 1520f);
	}

	public virtual void __BB_OBFUSCATOR_46()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1076f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 951f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_75()
	{
		PACAMLAINIK = new Vector3(254f, 1382f, 1513f);
	}

	public virtual void __BB_OBFUSCATOR_17()
	{
	}

	public virtual void __BB_OBFUSCATOR_66()
	{
	}

	public void __BB_OBFUSCATOR_104()
	{
		PACAMLAINIK = new Vector3(922f, 403f, 1617f);
	}

	public virtual void __BB_OBFUSCATOR_23()
	{
	}

	public virtual void __BB_OBFUSCATOR_5()
	{
	}

	public virtual void __BB_OBFUSCATOR_55()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 257f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1261f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_109()
	{
	}

	public virtual void __BB_OBFUSCATOR_58()
	{
	}

	public virtual void __BB_OBFUSCATOR_53()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1915f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 615f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_79()
	{
		PACAMLAINIK = new Vector3(1077f, 141f, 1410f);
	}

	public virtual void __BB_OBFUSCATOR_83()
	{
	}

	public virtual void __BB_OBFUSCATOR_103()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1989f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 701f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_90()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 721f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1470f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void Reset()
	{
		PACAMLAINIK = new Vector3(15f, 15f, 15f);
	}

	public virtual void __BB_OBFUSCATOR_105()
	{
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 428f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1910f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 865f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_77()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 254f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1662f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		PACAMLAINIK = new Vector3(1641f, 406f, 68f);
	}

	public void __BB_OBFUSCATOR_16()
	{
		PACAMLAINIK = new Vector3(1225f, 190f, 71f);
	}

	public virtual void __BB_OBFUSCATOR_48()
	{
	}

	public virtual void __BB_OBFUSCATOR_39()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 526f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1074f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_113()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1051f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1025f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_108()
	{
	}

	public virtual void __BB_OBFUSCATOR_26()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1112f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 692f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_87()
	{
	}

	public virtual void __BB_OBFUSCATOR_0()
	{
	}

	public virtual void __BB_OBFUSCATOR_49()
	{
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1121f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_107()
	{
		PACAMLAINIK = new Vector3(1069f, 1096f, 1143f);
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1670f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_50()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 637f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 232f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 165f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_63()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1405f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 985f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_100()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 845f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1121f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_3()
	{
	}

	public void __BB_OBFUSCATOR_12()
	{
		PACAMLAINIK = new Vector3(1068f, 61f, 686f);
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 224f)
			{
				Explode();
			}
		}
	}

	public void __BB_OBFUSCATOR_31()
	{
		PACAMLAINIK = new Vector3(1472f, 745f, 1628f);
	}

	public virtual void __BB_OBFUSCATOR_21()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1205f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1625f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_110()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1442f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 38f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1891f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 63f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 940f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_47()
	{
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
	}

	public virtual void __BB_OBFUSCATOR_6()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1336f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1572f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 453f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_116()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 563f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 228f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_92()
	{
		PACAMLAINIK = new Vector3(596f, 631f, 277f);
	}

	public virtual void __BB_OBFUSCATOR_60()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1489f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 354f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_8()
	{
	}

	public virtual void __BB_OBFUSCATOR_27()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1221f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 663f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_81()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1608f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1131f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_24()
	{
	}

	public virtual void __BB_OBFUSCATOR_98()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 597f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 126f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_14()
	{
	}

	public void __BB_OBFUSCATOR_30()
	{
		PACAMLAINIK = new Vector3(1112f, 1815f, 1995f);
	}

	public virtual void __BB_OBFUSCATOR_51()
	{
	}

	public virtual void __BB_OBFUSCATOR_9()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 247f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1128f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public void __BB_OBFUSCATOR_71()
	{
		PACAMLAINIK = new Vector3(816f, 1662f, 1887f);
	}

	public void __BB_OBFUSCATOR_99()
	{
		PACAMLAINIK = new Vector3(183f, 942f, 1599f);
	}

	public virtual void __BB_OBFUSCATOR_20()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 848f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1308f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_36()
	{
		PACAMLAINIK = new Vector3(1246f, 1998f, 287f);
	}

	public virtual void __BB_OBFUSCATOR_111()
	{
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1782f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_4()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1501f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1708f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_28()
	{
		PACAMLAINIK = new Vector3(1491f, 1637f, 901f);
	}

	public virtual void __BB_OBFUSCATOR_88()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1553f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1515f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public virtual void __BB_OBFUSCATOR_101()
	{
	}

	public virtual void __BB_OBFUSCATOR_94()
	{
	}

	public void __BB_OBFUSCATOR_106()
	{
		PACAMLAINIK = new Vector3(32f, 1178f, 997f);
	}

	public virtual void __BB_OBFUSCATOR_112()
	{
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 1210f)
			{
				Explode();
			}
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 918f)
			{
				Explode();
			}
		}
	}

	public virtual void __BB_OBFUSCATOR_73()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 1364f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1345f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}

	public void __BB_OBFUSCATOR_18()
	{
		PACAMLAINIK = new Vector3(712f, 1248f, 1196f);
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (CEGBKJGOLBO)
		{
			PFGJDPDJOML -= Time.deltaTime;
			if (PFGJDPDJOML <= 811f)
			{
				Explode();
			}
		}
	}

	public override void Init()
	{
	}

	public override void Explode()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 0f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 0f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_40()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 253f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = true;
				PFGJDPDJOML = 1331f;
			}
		}
		else
		{
			CEGBKJGOLBO = true;
		}
	}

	public virtual void __BB_OBFUSCATOR_15()
	{
		if (!CEGBKJGOLBO)
		{
			PFGJDPDJOML = BHDOLBHLDGC + Random.value * (DHMOAEAKEBD - BHDOLBHLDGC);
		}
		if (PFGJDPDJOML <= 419f)
		{
			int num = (int)(NCGMMIBMBEL * (float)FGMDPKFFANG);
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = Random.onUnitSphere * (EIJBFNBPFCD * EEDMLOPHDJA);
				Vector3 b = new Vector3(PACAMLAINIK.x * EEDMLOPHDJA, PACAMLAINIK.y * EEDMLOPHDJA, PACAMLAINIK.z * EEDMLOPHDJA);
				GameObject gameObject = Object.Instantiate(EIINLPJAKAF, base.transform.position + vector, base.transform.rotation);
				gameObject.transform.parent = base.transform;
				LGGEGLFOOPK = KCADJIKIEBE + Random.value * (BHLAGABJKGK - KCADJIKIEBE);
				LGGEGLFOOPK *= EEDMLOPHDJA;
				gameObject.transform.localScale = new Vector3(LGGEGLFOOPK, LGGEGLFOOPK, LGGEGLFOOPK);
				gameObject.GetComponent<Rigidbody>().velocity = Vector3.Scale(vector.normalized, b);
				Object.Destroy(gameObject, LCLHCEHHBNM * PJKHHCHLFIF);
				CEGBKJGOLBO = false;
				PFGJDPDJOML = 1257f;
			}
		}
		else
		{
			CEGBKJGOLBO = false;
		}
	}
}
