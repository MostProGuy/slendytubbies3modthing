using System.Collections.Generic;
using UnityEngine;

public class automaticDoors : MonoBehaviour
{
	public float NGGEIJHEEMA = 5f;

	public List<Light> MIBFELHHHGG = new List<Light>();

	public Color KMHFOFKOJFE = new Color(1f, 1f, 1f, 1f);

	public Color PLOBMBGBGHP = new Color(0f, 0f, 0f, 0f);

	public Transform MABGHNEMGLB;

	public Vector3 HMDJLHLMJIA = new Vector3(0f, 0f, 0f);

	private Vector3 JLKAFALFDEB = new Vector3(0f, 0f, 0f);

	private int DBEBHBIEJFO;

	private float IGKDACLNJLE;

	public bool NGGIKAFGDOO = true;

	public AudioClip CCPLEJIMIEC;

	public AudioClip DFDCHGLPGMH;

	public void __BB_OBFUSCATOR_16()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 1582f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 8;
			}
		}
		else if (DBEBHBIEJFO != 7 && DBEBHBIEJFO == 8)
		{
			if (IGKDACLNJLE > 353f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_22(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_5()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 930f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 8;
			}
		}
		else if (DBEBHBIEJFO != 8 && DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE > 1120f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	private void Update()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 1)
		{
			if (IGKDACLNJLE < 1f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 2;
			}
		}
		else if (DBEBHBIEJFO != 2 && DBEBHBIEJFO == 3)
		{
			if (IGKDACLNJLE > 0f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_33(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_39()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 8;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void __BB_OBFUSCATOR_53(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void Open()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	public void __BB_OBFUSCATOR_18(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 8;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void Close()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 3;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 831f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 8;
			}
		}
		else if (DBEBHBIEJFO != 6 && DBEBHBIEJFO == 6)
		{
			if (IGKDACLNJLE > 871f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 1;
			}
		}
	}

	public void __BB_OBFUSCATOR_1()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	public void __BB_OBFUSCATOR_0()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	public void __BB_OBFUSCATOR_43()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 5;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void setOpenable(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_29()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void __BB_OBFUSCATOR_24()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 6;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void __BB_OBFUSCATOR_17()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_49(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 1)
		{
			if (IGKDACLNJLE < 431f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 7;
			}
		}
		else if (DBEBHBIEJFO != 8 && DBEBHBIEJFO == 5)
		{
			if (IGKDACLNJLE > 271f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 1;
			}
		}
	}

	public void __BB_OBFUSCATOR_44(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 1)
		{
			if (IGKDACLNJLE < 1354f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 6;
			}
		}
		else if (DBEBHBIEJFO != 7 && DBEBHBIEJFO == 6)
		{
			if (IGKDACLNJLE > 438f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	private void Start()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_32(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_9(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_51()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	public void __BB_OBFUSCATOR_37()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 1;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 1588f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 8;
			}
		}
		else if (DBEBHBIEJFO != 0 && DBEBHBIEJFO == 8)
		{
			if (IGKDACLNJLE > 1562f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 246f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 4;
			}
		}
		else if (DBEBHBIEJFO != 2 && DBEBHBIEJFO == 6)
		{
			if (IGKDACLNJLE > 1734f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_31(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 1)
		{
			if (IGKDACLNJLE < 852f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 4;
			}
		}
		else if (DBEBHBIEJFO != 8 && DBEBHBIEJFO == 6)
		{
			if (IGKDACLNJLE > 91f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 1;
			}
		}
	}

	public void __BB_OBFUSCATOR_46()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 5;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void __BB_OBFUSCATOR_13(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_30()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	public void __BB_OBFUSCATOR_42()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 5;
			if ((bool)DFDCHGLPGMH)
			{
				GetComponent<AudioSource>().PlayOneShot(DFDCHGLPGMH);
			}
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		JLKAFALFDEB = MABGHNEMGLB.transform.localPosition;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	public void __BB_OBFUSCATOR_36(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 1)
		{
			if (IGKDACLNJLE < 1741f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 2;
			}
		}
		else if (DBEBHBIEJFO != 7 && DBEBHBIEJFO == 8)
		{
			if (IGKDACLNJLE > 1395f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_20()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (DBEBHBIEJFO == 0)
		{
			return;
		}
		if (DBEBHBIEJFO == 0)
		{
			if (IGKDACLNJLE < 220f)
			{
				IGKDACLNJLE += Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 2;
			}
		}
		else if (DBEBHBIEJFO != 5 && DBEBHBIEJFO == 2)
		{
			if (IGKDACLNJLE > 887f)
			{
				IGKDACLNJLE -= Time.deltaTime * NGGEIJHEEMA;
				MABGHNEMGLB.localPosition = Vector3.Lerp(JLKAFALFDEB, HMDJLHLMJIA, IGKDACLNJLE);
			}
			else
			{
				DBEBHBIEJFO = 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_6()
	{
		if (NGGIKAFGDOO)
		{
			DBEBHBIEJFO = 0;
			if ((bool)CCPLEJIMIEC)
			{
				GetComponent<AudioSource>().PlayOneShot(CCPLEJIMIEC);
			}
		}
	}

	public void __BB_OBFUSCATOR_3(bool IFHLNICHNNK)
	{
		NGGIKAFGDOO = IFHLNICHNNK;
		if (NGGIKAFGDOO)
		{
			foreach (Light item in MIBFELHHHGG)
			{
				item.color = KMHFOFKOJFE;
			}
			return;
		}
		if (NGGIKAFGDOO)
		{
			return;
		}
		foreach (Light item2 in MIBFELHHHGG)
		{
			item2.color = PLOBMBGBGHP;
		}
	}
}
