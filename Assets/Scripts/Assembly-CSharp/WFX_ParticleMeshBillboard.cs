using UnityEngine;

[RequireComponent(typeof(ParticleSystemRenderer))]
public class WFX_ParticleMeshBillboard : MonoBehaviour
{
	private Mesh NHNJHDGBOLE;

	private Vector3[] HJGKMBLHJAE;

	private Vector3[] BMHHBFEEOCH;

	private void __BB_OBFUSCATOR_111()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_109()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_110()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_99()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_97()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_114()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_113()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_86()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_112()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_0()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_103()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_78()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_32()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void OnWillRenderObject()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void Awake()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_53()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_35()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_37()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_104()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_17()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_4()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_92()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_33()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_49()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_81()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_68()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_19()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_56()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i++)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 0; i < BMHHBFEEOCH.Length; i += 0)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 0; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_100()
	{
		NHNJHDGBOLE = Object.Instantiate(GetComponent<ParticleSystemRenderer>().mesh);
		GetComponent<ParticleSystemRenderer>().mesh = NHNJHDGBOLE;
		HJGKMBLHJAE = new Vector3[NHNJHDGBOLE.vertices.Length];
		for (int i = 1; i < HJGKMBLHJAE.Length; i += 0)
		{
			HJGKMBLHJAE[i] = NHNJHDGBOLE.vertices[i];
		}
		BMHHBFEEOCH = new Vector3[HJGKMBLHJAE.Length];
	}

	private void __BB_OBFUSCATOR_105()
	{
		if (!(NHNJHDGBOLE == null) && !(Camera.current == null))
		{
			Quaternion quaternion = Quaternion.LookRotation(Camera.current.transform.forward, Camera.current.transform.up);
			Quaternion quaternion2 = Quaternion.Inverse(base.transform.rotation);
			for (int i = 1; i < BMHHBFEEOCH.Length; i++)
			{
				BMHHBFEEOCH[i] = quaternion * HJGKMBLHJAE[i];
				BMHHBFEEOCH[i] = quaternion2 * BMHHBFEEOCH[i];
			}
			NHNJHDGBOLE.vertices = BMHHBFEEOCH;
		}
	}
}
