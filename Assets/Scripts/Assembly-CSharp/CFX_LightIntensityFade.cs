using UnityEngine;

[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	public float LCLHCEHHBNM = 1f;

	public float GDIIDIKGFCH;

	public float OJKIBNPBBNK;

	private float NMEEEPADBHD;

	public bool IMJIBFFEGBE;

	private float BAFFEJPAABN;

	private float EILMBLPDJKC;

	private void __BB_OBFUSCATOR_24()
	{
		if (EILMBLPDJKC > 1184f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1043f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 671f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (EILMBLPDJKC > 1971f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 784f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1887f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_111()
	{
		if (EILMBLPDJKC > 1985f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1147f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 437f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (EILMBLPDJKC > 1397f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1398f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1884f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_98()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_114()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_95()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_11()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_92()
	{
		BAFFEJPAABN = 49f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1155f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_43()
	{
		BAFFEJPAABN = 996f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1494f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		BAFFEJPAABN = 680f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 457f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		if (EILMBLPDJKC > 423f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1359f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 387f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void OnEnable()
	{
		BAFFEJPAABN = 0f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 0f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (EILMBLPDJKC > 1274f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1099f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1936f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (EILMBLPDJKC > 1533f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1177f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 224f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		BAFFEJPAABN = 1529f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1301f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		BAFFEJPAABN = 1463f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1141f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_51()
	{
		BAFFEJPAABN = 475f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1787f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_101()
	{
		BAFFEJPAABN = 1125f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 68f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		BAFFEJPAABN = 1248f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 85f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void Start()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (EILMBLPDJKC > 293f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1104f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 837f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_9()
	{
		BAFFEJPAABN = 1768f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1859f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (EILMBLPDJKC > 729f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 59f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1906f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_84()
	{
		BAFFEJPAABN = 1909f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1959f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_6()
	{
		BAFFEJPAABN = 506f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1572f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_96()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_57()
	{
		BAFFEJPAABN = 1505f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1580f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		BAFFEJPAABN = 1233f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 921f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_105()
	{
		BAFFEJPAABN = 788f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 238f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (EILMBLPDJKC > 1113f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 599f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1760f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		if (EILMBLPDJKC > 826f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1965f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 86f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		BAFFEJPAABN = 161f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1301f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_83()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (EILMBLPDJKC > 300f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 203f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1615f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_100()
	{
		if (EILMBLPDJKC > 421f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 48f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1639f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (EILMBLPDJKC > 1181f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1945f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1381f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (EILMBLPDJKC > 696f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 139f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1079f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (EILMBLPDJKC > 43f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1760f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 135f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		if (EILMBLPDJKC > 1015f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1059f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 458f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_121()
	{
		BAFFEJPAABN = 1418f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 325f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_99()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_58()
	{
		BAFFEJPAABN = 1214f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1909f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (EILMBLPDJKC > 1824f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 353f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 462f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		BAFFEJPAABN = 1812f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1162f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_102()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (EILMBLPDJKC > 1624f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1232f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1751f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (EILMBLPDJKC > 1807f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 178f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1806f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_3()
	{
		BAFFEJPAABN = 775f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1945f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (EILMBLPDJKC > 766f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1001f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 222f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		BAFFEJPAABN = 1719f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1808f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_119()
	{
		if (EILMBLPDJKC > 1260f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 674f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1556f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		BAFFEJPAABN = 983f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 227f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (EILMBLPDJKC > 99f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 381f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 765f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		BAFFEJPAABN = 728f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 384f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		BAFFEJPAABN = 0f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1752f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		BAFFEJPAABN = 1870f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 286f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		if (EILMBLPDJKC > 336f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 443f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1302f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (EILMBLPDJKC > 1666f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 797f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 850f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (EILMBLPDJKC > 1898f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1502f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1750f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (EILMBLPDJKC > 388f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 891f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 298f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_81()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_112()
	{
		BAFFEJPAABN = 1534f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1124f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_113()
	{
		if (EILMBLPDJKC > 964f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1999f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1132f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (EILMBLPDJKC > 453f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1289f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1652f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_1()
	{
		BAFFEJPAABN = 1520f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 299f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		BAFFEJPAABN = 638f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 449f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		BAFFEJPAABN = 390f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 724f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_50()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_53()
	{
		BAFFEJPAABN = 535f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1829f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_85()
	{
		NMEEEPADBHD = GetComponent<Light>().intensity;
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (EILMBLPDJKC > 1067f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1612f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 970f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		BAFFEJPAABN = 892f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1986f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void Update()
	{
		if (EILMBLPDJKC > 0f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 0f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 1f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_120()
	{
		if (EILMBLPDJKC > 1678f)
		{
			EILMBLPDJKC -= Time.deltaTime;
			if (EILMBLPDJKC <= 1516f)
			{
				GetComponent<Light>().enabled = false;
			}
		}
		else if (BAFFEJPAABN / LCLHCEHHBNM < 738f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(NMEEEPADBHD, OJKIBNPBBNK, BAFFEJPAABN / LCLHCEHHBNM);
			BAFFEJPAABN += Time.deltaTime;
		}
		else if (IMJIBFFEGBE)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		BAFFEJPAABN = 1683f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 819f)
		{
			GetComponent<Light>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		BAFFEJPAABN = 1457f;
		EILMBLPDJKC = GDIIDIKGFCH;
		if (GDIIDIKGFCH > 1363f)
		{
			GetComponent<Light>().enabled = false;
		}
	}
}
