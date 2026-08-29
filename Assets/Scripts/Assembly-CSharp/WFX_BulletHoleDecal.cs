using System.Collections;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class WFX_BulletHoleDecal : MonoBehaviour
{
	private static Vector2[] IMMHBOCLJGG = new Vector2[4]
	{
		new Vector2(0f, 0f),
		new Vector2(0f, 1f),
		new Vector2(1f, 0f),
		new Vector2(1f, 1f)
	};

	public float OPMCCFKFDLB = 10f;

	public float CLCMJOICPGN = 80f;

	public Vector2 MKIGIAHLOIL;

	public bool LFJCINCGOKF;

	public bool DEBBJDLCGIP;

	private float CJBLOMOMPDL;

	private float BPBOKBMPHBL;

	private Color IOFNOJHNJAJ;

	private float BGHFJOJFFMM;

	private void __BB_OBFUSCATOR_64()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[3];
		for (int i = 0; i < 3; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (657f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (773f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1093f, 1910f, Random.Range(1065f, 275f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 150f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("RespawnPlayer2", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("v {0:0.000000} {1:0.000000} {2:0.000000}\n");
	}

	private void __BB_OBFUSCATOR_42()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[0];
		for (int i = 1; i < 5; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1572f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1010f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1424f, 1928f, Random.Range(1563f, 1079f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 381f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("SUR/", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_TimeX");
	}

	private IEnumerator __BB_OBFUSCATOR_17()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[7];
		for (int i = 0; i < 3; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (813f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1415f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(363f, 974f, Random.Range(1037f, 1675f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 208f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("TeamTag", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("[;\\\\/:*?\"<>|&']");
	}

	private void __BB_OBFUSCATOR_56()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private IEnumerator holeUpdate()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_4()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[2];
		for (int i = 0; i < 2; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (792f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1638f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1422f, 1161f, Random.Range(1119f, 122f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 739f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_Bullet_3", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("custardPos");
	}

	private void __BB_OBFUSCATOR_58()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_20()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[4];
		for (int i = 0; i < 6; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1967f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (648f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1991f, 923f, Random.Range(1041f, 561f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 863f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_TimeX", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("SetTexAt(): Vertex not found");
	}

	private IEnumerator __BB_OBFUSCATOR_22()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[2];
		for (int i = 1; i < 8; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1833f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1926f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(937f, 433f, Random.Range(436f, 1435f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 579f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("State2", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_TimeX");
	}

	private void __BB_OBFUSCATOR_29()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[1];
		for (int i = 0; i < 8; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (766f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (739f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(901f, 337f, Random.Range(1266f, 152f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 679f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("CameraFilterPack/Color_Invert", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("COOP");
	}

	private void __BB_OBFUSCATOR_25()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void Awake()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private IEnumerator __BB_OBFUSCATOR_38()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[8];
		for (int i = 1; i < 3; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1900f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (444f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(531f, 1020f, Random.Range(391f, 1353f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1720f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("Team1Score", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine(" </color></size>");
	}

	private IEnumerator __BB_OBFUSCATOR_11()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[1];
		for (int i = 1; i < 5; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1180f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1215f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1124f, 1959f, Random.Range(1684f, 176f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 294f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("colorD", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_BumpMap");
	}

	private void __BB_OBFUSCATOR_41()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[7];
		for (int i = 1; i < 1; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1195f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (213f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1724f, 613f, Random.Range(442f, 1523f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1523f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_TimeX", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_TimeX");
	}

	private void __BB_OBFUSCATOR_36()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_60()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_65()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[8];
		for (int i = 1; i < 4; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (539f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1243f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(402f, 1029f, Random.Range(784f, 228f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1326f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("\\Microsoft\\WordPad", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("Collapsing edges");
	}

	private void __BB_OBFUSCATOR_52()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_43()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private IEnumerator __BB_OBFUSCATOR_62()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_32()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[0];
		for (int i = 0; i < 6; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1469f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (794f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(552f, 1324f, Random.Range(893f, 1261f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 713f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_ScreenResolution", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("\", \"Model::");
	}

	private void __BB_OBFUSCATOR_19()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[7];
		for (int i = 1; i < 1; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (811f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1689f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1998f, 311f, Random.Range(246f, 1275f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1052f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("CameraFilterPack/TV_Posterize", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("\t}\n\tCreator: \"EJM Software FBX Exporter\"\n\tOtherFlags:  {\n\t\tFlagPLE: 0\n\t}\n}\n");
	}

	private void __BB_OBFUSCATOR_16()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[8];
		for (int i = 1; i < 3; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1514f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1090f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(493f, 1956f, Random.Range(1868f, 630f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1279f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("http://zeoworks.com/home/getlogin.php", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",");
	}

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		int num = Random.Range(1, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[7];
		for (int i = 1; i < 5; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1583f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (51f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(80f, 1870f, Random.Range(213f, 32f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1014f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("Horizontal", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("GameMode");
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_39()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[8];
		for (int i = 1; i < 7; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (55f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1310f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1082f, 784f, Random.Range(823f, 771f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 1089f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("\tTexture: \"Texture::", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_Value2");
	}

	private IEnumerator __BB_OBFUSCATOR_10()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[0];
		for (int i = 0; i < 4; i += 0)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1784f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (264f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(995f, 1651f, Random.Range(121f, 1919f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 66f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_respawnAfter", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("CameraFilterPack/Drawing_Toon");
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[2];
		for (int i = 0; i < 1; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (579f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1624f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(1731f, 1499f, Random.Range(1420f, 1654f), Space.World);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 136f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("SmokeB", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("_Value4");
	}

	private void __BB_OBFUSCATOR_44()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private void __BB_OBFUSCATOR_31()
	{
		BGHFJOJFFMM = IOFNOJHNJAJ.a;
	}

	private IEnumerator __BB_OBFUSCATOR_59()
	{
		while (CJBLOMOMPDL > 0f)
		{
			CJBLOMOMPDL -= Time.deltaTime;
			if (CJBLOMOMPDL <= BPBOKBMPHBL)
			{
				IOFNOJHNJAJ.a = Mathf.Lerp(0f, BGHFJOJFFMM, CJBLOMOMPDL / BPBOKBMPHBL);
				GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
			}
			yield return null;
		}
	}

	private void OnEnable()
	{
		int num = Random.Range(0, (int)(MKIGIAHLOIL.x * MKIGIAHLOIL.y));
		int num2 = (int)((float)num % MKIGIAHLOIL.x);
		int num3 = (int)((float)num / MKIGIAHLOIL.y);
		Vector2[] array = new Vector2[4];
		for (int i = 0; i < 4; i++)
		{
			array[i].x = (IMMHBOCLJGG[i].x + (float)num2) * (1f / MKIGIAHLOIL.x);
			array[i].y = (IMMHBOCLJGG[i].y + (float)num3) * (1f / MKIGIAHLOIL.y);
		}
		GetComponent<MeshFilter>().mesh.uv = array;
		if (LFJCINCGOKF)
		{
			base.transform.Rotate(0f, 0f, Random.Range(0f, 360f), Space.Self);
		}
		CJBLOMOMPDL = OPMCCFKFDLB;
		BPBOKBMPHBL = CJBLOMOMPDL * (CLCMJOICPGN / 100f);
		IOFNOJHNJAJ.a = BGHFJOJFFMM;
		GetComponent<Renderer>().material.SetColor("_TintColor", IOFNOJHNJAJ);
		StopAllCoroutines();
		StartCoroutine("holeUpdate");
	}
}
