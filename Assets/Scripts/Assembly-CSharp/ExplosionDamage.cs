using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
	public float GIBPLICLGHC = 5f;

	public float NAMNOGCMKFB = 10f;

	public float AHOJJEKNJAO = 100f;

	public float JDLIJHIFAOP = 2f;

	public bool DFIJGKNOMOG = true;

	public ParticleSystem GEJFFMPDNPI;

	public float DGLJJFHANIB = 0.5f;

	private Vector3 HIGCHADDKHK;

	private GameObject GPNGOODBIJB;

	[HideInInspector]
	public bool KJJALFLDCDF;

	private float DJJAALCLLNC;

	public string BIBDFBJOAFL = "team2";

	private void __BB_OBFUSCATOR_70()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	public void __BB_OBFUSCATOR_58(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_96()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_49();
				num++;
			}
			DJJAALCLLNC = 1711f;
		}
		else
		{
			DJJAALCLLNC += 1116f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_93();
				num++;
			}
			DJJAALCLLNC = 1311f;
		}
		else
		{
			DJJAALCLLNC += 1536f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_45();
		}
	}

	public void __BB_OBFUSCATOR_54(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_71()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1231f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 985f)
			{
				num2 += 812f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("MP").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("Idle", num2, SendMessageOptions.RequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "The shader ")
				{
					collider.SendMessage("_Value", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[7];
				array3[1] = num2 / 1442f;
				array3[1] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "SyncCount")
				{
					collider.SendMessage("_Value2", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j++)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1200f);
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_45();
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_78();
				num += 0;
			}
			DJJAALCLLNC = 1521f;
		}
		else
		{
			DJJAALCLLNC += 1327f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_50();
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_49();
				num += 0;
			}
			DJJAALCLLNC = 1478f;
		}
		else
		{
			DJJAALCLLNC += 1304f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_45()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1171f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 58f)
			{
				num2 += 1870f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("Label").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("Restarting", num2, SendMessageOptions.RequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "_Offsets")
				{
					collider.SendMessage(">", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[6];
				array3[0] = num2 / 188f;
				array3[0] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.")
				{
					collider.SendMessage("B", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j++)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 688f);
			}
		}
	}

	public void __BB_OBFUSCATOR_85(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_55();
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_79()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_77()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_50();
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_78();
		}
	}

	public void __BB_OBFUSCATOR_23(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_49()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1330f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 812f)
			{
				num2 += 151f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("_Offset").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("n4", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "_Value")
				{
					collider.SendMessage(", phase = ", num2, SendMessageOptions.RequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[0];
				array3[1] = num2 / 243f;
				array3[1] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "-Vertical")
				{
					collider.SendMessage("MP", value, SendMessageOptions.RequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 0; j < array4.Length; j += 0)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1053f);
			}
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 914f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 1218f)
			{
				num2 += 1198f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find(">").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("_EdgeSize", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == ">")
				{
					collider.SendMessage("_AdaptParams", num2, SendMessageOptions.RequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[2];
				array3[1] = num2 / 1652f;
				array3[1] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "_ScreenResolution")
				{
					collider.SendMessage("+", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j++)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1045f);
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				CheckHit();
				num++;
			}
			DJJAALCLLNC = 338f;
		}
		else
		{
			DJJAALCLLNC += 774f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_50();
				num++;
			}
			DJJAALCLLNC = 558f;
		}
		else
		{
			DJJAALCLLNC += 1177f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_46()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_88()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	public void __BB_OBFUSCATOR_3(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_98()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_21();
				num += 0;
			}
			DJJAALCLLNC = 893f;
		}
		else
		{
			DJJAALCLLNC += 715f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_66()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_21();
				num++;
			}
			DJJAALCLLNC = 1387f;
		}
		else
		{
			DJJAALCLLNC += 914f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1386f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 100f)
			{
				num2 += 988f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("TeamName").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("CameraFilterPack/Blend2Camera_Lighten", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "_ScreenResolution")
				{
					collider.SendMessage(",", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[4];
				array3[0] = num2 / 1806f;
				array3[0] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "_UnderwaterMode")
				{
					collider.SendMessage("1: ", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 0; j < array4.Length; j += 0)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 43f);
			}
		}
	}

	public void __BB_OBFUSCATOR_27(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_55()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 284f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 667f)
			{
				num2 += 72f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("_Value4").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("_ColorRGB", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "RoundDuration")
				{
					collider.SendMessage("\n", num2, SendMessageOptions.RequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[2];
				array3[1] = num2 / 380f;
				array3[0] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "_TimeX")
				{
					collider.SendMessage("{0}: {1}", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 0; j < array4.Length; j += 0)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1984f);
			}
		}
	}

	public void __BB_OBFUSCATOR_20(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_78();
				num += 0;
			}
			DJJAALCLLNC = 1862f;
		}
		else
		{
			DJJAALCLLNC += 1265f * Time.deltaTime;
		}
	}

	private void Start()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			CheckHit();
		}
	}

	public void __BB_OBFUSCATOR_104(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_84()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_49();
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_72();
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_55();
		}
	}

	public void __BB_OBFUSCATOR_11(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_71();
				num += 0;
			}
			DJJAALCLLNC = 485f;
		}
		else
		{
			DJJAALCLLNC += 1780f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_49();
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_93()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1351f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 1712f)
			{
				num2 += 1150f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("ZWName'").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("Difficulty", num2, SendMessageOptions.RequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "Camera")
				{
					collider.SendMessage("CameraFilterPack/TV_Old_Movie", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[8];
				array3[1] = num2 / 1926f;
				array3[0] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "PlayerType'")
				{
					collider.SendMessage("Kills", value, SendMessageOptions.RequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 0; j < array4.Length; j += 0)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 694f);
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_55();
		}
	}

	public void __BB_OBFUSCATOR_15(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_73()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	public void __BB_OBFUSCATOR_82(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_65()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_95()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void Update()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				CheckHit();
				num++;
			}
			DJJAALCLLNC = 0f;
		}
		else
		{
			DJJAALCLLNC += 1f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_105()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_93();
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_50();
				num += 0;
			}
			DJJAALCLLNC = 1128f;
		}
		else
		{
			DJJAALCLLNC += 1853f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_50()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1711f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 1371f)
			{
				num2 += 962f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("|").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("Please make sure to assign a view target!", num2, SendMessageOptions.RequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "Purchase")
				{
					collider.SendMessage("offsets", num2, SendMessageOptions.RequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[0];
				array3[1] = num2 / 46f;
				array3[1] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "CameraFilterPack/Color_Noise")
				{
					collider.SendMessage("_OffsetScale", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j++)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 700f);
			}
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_99()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_72();
		}
	}

	public void __BB_OBFUSCATOR_18(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_102();
		}
	}

	public void __BB_OBFUSCATOR_25(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void Awake()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	public void __BB_OBFUSCATOR_29(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_78()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Collider collider = array2[i];
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1238f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 198f)
			{
				num2 += 1860f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("_Value").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("<size=15>Or change by this button below</size>", num2, SendMessageOptions.RequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "_Value3")
				{
					collider.SendMessage("TeamTag", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[3];
				array3[0] = num2 / 1826f;
				array3[0] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "_Linecount")
				{
					collider.SendMessage("Left Ctrl - prone", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j += 0)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1488f);
			}
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num++)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_71();
				num += 0;
			}
			DJJAALCLLNC = 1234f;
		}
		else
		{
			DJJAALCLLNC += 630f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_102()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1185f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 819f)
			{
				num2 += 727f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("n4").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("Cluster", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "_Blue_G")
				{
					collider.SendMessage("_FrustumCornersWS", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] array3 = new object[6];
				array3[1] = num2 / 938f;
				array3[1] = string.Empty;
				object[] value = array3;
				if (collider.transform.parent.tag == "</size>")
				{
					collider.SendMessage("Vertical", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array4 = array;
		for (int j = 1; j < array4.Length; j++)
		{
			Collider collider2 = array4[j];
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 1558f);
			}
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_71();
		}
	}

	public void __BB_OBFUSCATOR_6(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	public void __BB_OBFUSCATOR_40(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	public void __BB_OBFUSCATOR_62(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_78();
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_21();
				num++;
			}
			DJJAALCLLNC = 1926f;
		}
		else
		{
			DJJAALCLLNC += 1698f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_53()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_59()
	{
		HIGCHADDKHK = base.transform.position;
		Object.Destroy(base.gameObject, JDLIJHIFAOP);
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				CheckHit();
				num++;
			}
			DJJAALCLLNC = 1605f;
		}
		else
		{
			DJJAALCLLNC += 635f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				CheckHit();
				num++;
			}
			DJJAALCLLNC = 1826f;
		}
		else
		{
			DJJAALCLLNC += 1314f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_55();
				num += 0;
			}
			DJJAALCLLNC = 154f;
		}
		else
		{
			DJJAALCLLNC += 1267f * Time.deltaTime;
		}
	}

	private void CheckHit()
	{
		Collider[] array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			Vector3 a = collider.ClosestPointOnBounds(HIGCHADDKHK);
			float num = Vector3.Distance(a, HIGCHADDKHK);
			float num2 = 1f - Mathf.Clamp01(num / GIBPLICLGHC);
			num2 *= AHOJJEKNJAO;
			if (num2 < 10f)
			{
				num2 += 3f;
			}
			if (DFIJGKNOMOG)
			{
				if (collider.GetComponent<HitBoxBot>() != null || collider.GetComponent<HitboxBoss>() != null)
				{
					Transform transform = null;
					transform = ((!(collider.GetComponent<HitBoxBot>() != null)) ? collider.GetComponent<HitboxBoss>().ALACGHMBNGD.transform : collider.GetComponent<HitBoxBot>().ALACGHMBNGD.transform);
					if (!transform.Find("TeamTag").tag.Contains(BIBDFBJOAFL))
					{
						transform.SendMessageUpwards("ForceDamage", num2, SendMessageOptions.DontRequireReceiver);
					}
				}
				else if (BIBDFBJOAFL == "team2")
				{
					collider.SendMessage("ApplyFallDamage", num2, SendMessageOptions.DontRequireReceiver);
				}
			}
			else if (!KJJALFLDCDF && collider.transform.parent != null)
			{
				object[] value = new object[2]
				{
					num2 / 1f,
					string.Empty
				};
				if (collider.transform.parent.tag == "monster")
				{
					collider.SendMessage("ApplyDamage", value, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		array = Physics.OverlapSphere(HIGCHADDKHK, GIBPLICLGHC);
		Collider[] array3 = array;
		foreach (Collider collider2 in array3)
		{
			if ((bool)collider2.GetComponent<Rigidbody>())
			{
				collider2.GetComponent<Rigidbody>().AddExplosionForce(NAMNOGCMKFB, HIGCHADDKHK, GIBPLICLGHC, 3f);
			}
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (GEJFFMPDNPI == null)
		{
			HIGCHADDKHK = base.transform.position;
			__BB_OBFUSCATOR_45();
		}
	}

	public void SyncTeamName(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	public void __BB_OBFUSCATOR_91(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 0; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_102();
				num += 0;
			}
			DJJAALCLLNC = 279f;
		}
		else
		{
			DJJAALCLLNC += 1306f * Time.deltaTime;
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (!(GEJFFMPDNPI != null))
		{
			return;
		}
		if (DJJAALCLLNC >= DGLJJFHANIB)
		{
			ParticleSystem.Particle[] array = new ParticleSystem.Particle[GEJFFMPDNPI.particleCount];
			GEJFFMPDNPI.GetParticles(array);
			int num;
			for (num = 1; num < array.Length; num += 0)
			{
				HIGCHADDKHK = GEJFFMPDNPI.transform.TransformPoint(array[num].position);
				__BB_OBFUSCATOR_71();
				num += 0;
			}
			DJJAALCLLNC = 873f;
		}
		else
		{
			DJJAALCLLNC += 1153f * Time.deltaTime;
		}
	}
}
