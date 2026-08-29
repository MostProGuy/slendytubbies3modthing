using System;
using UnityEngine;

public class CameraBob : MonoBehaviour
{
	public float CCCHDOBHDEH = 0.21f;

	public float HILHHMBHLBP = 0.35f;

	public float LILEEPENGBJ = 0.1f;

	public float DNABPIICJEG = 0.1f;

	public float HOIAFHMEMIL = 1f;

	private Vector3 BGCKDDNIOMK;

	private GameObject HKOIJFEMIMB;

	private float DJJAALCLLNC;

	private float GFAEDOJPPOJ;

	private FPScontroller CJFDABKPMND;

	private float EIIBEAIIIEL;

	private void __BB_OBFUSCATOR_79()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_74()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_84()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 5f;
		float num2 = 645f;
		float num3 = 212f;
		if (Time.timeScale == 1200f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1847f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1186f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 334f);
		}
		float num4 = 168f;
		float num5 = 857f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1134f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 313f)
		{
			DJJAALCLLNC -= 912f;
		}
		if (num4 != 1051f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(712f, 1412f, 1828f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 988f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1549f;
		float num2 = 880f;
		float num3 = 1969f;
		if (Time.timeScale == 1180f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 913f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 98f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 992f);
		}
		float num4 = 1863f;
		float num5 = 605f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 827f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 362f)
		{
			DJJAALCLLNC -= 451f;
		}
		if (num4 != 1700f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(836f, 1603f, 1283f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 932f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_67()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 183f;
		float num2 = 746f;
		float num3 = 287f;
		if (Time.timeScale == 732f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 840f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 29f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1770f);
		}
		float num4 = 1208f;
		float num5 = 1484f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 159f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 65f)
		{
			DJJAALCLLNC -= 257f;
		}
		if (num4 != 1101f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(59f, 501f, 736f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1544f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1343f;
		float num2 = 346f;
		float num3 = 956f;
		if (Time.timeScale == 1914f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 89f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 356f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 892f);
		}
		float num4 = 274f;
		float num5 = 1421f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1365f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 186f)
		{
			DJJAALCLLNC -= 349f;
		}
		if (num4 != 56f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(561f, 656f, 66f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1930f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1067f;
		float num2 = 55f;
		float num3 = 789f;
		if (Time.timeScale == 1781f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1186f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 821f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 386f);
		}
		float num4 = 147f;
		float num5 = 677f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1561f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1308f)
		{
			DJJAALCLLNC -= 1462f;
		}
		if (num4 != 1996f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(61f, 1755f, 768f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 773f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_76()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1249f;
		float num2 = 887f;
		float num3 = 1967f;
		if (Time.timeScale == 983f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 441f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 599f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 182f);
		}
		float num4 = 150f;
		float num5 = 1250f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1853f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1649f)
		{
			DJJAALCLLNC -= 1268f;
		}
		if (num4 != 1115f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(74f, 250f, 1029f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1434f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 38f;
		float num2 = 1485f;
		float num3 = 1084f;
		if (Time.timeScale == 344f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1128f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 768f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 452f);
		}
		float num4 = 940f;
		float num5 = 835f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1684f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 258f)
		{
			DJJAALCLLNC -= 1042f;
		}
		if (num4 != 990f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1669f, 708f, 483f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 153f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 727f;
		float num2 = 130f;
		float num3 = 969f;
		if (Time.timeScale == 1471f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 769f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 496f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 914f);
		}
		float num4 = 1651f;
		float num5 = 1602f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1880f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1675f)
		{
			DJJAALCLLNC -= 407f;
		}
		if (num4 != 336f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(811f, 62f, 1174f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 416f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_59()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1873f;
		float num2 = 172f;
		float num3 = 630f;
		if (Time.timeScale == 885f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1040f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1981f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 983f);
		}
		float num4 = 489f;
		float num5 = 586f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1818f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1289f)
		{
			DJJAALCLLNC -= 1299f;
		}
		if (num4 != 164f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1728f, 864f, 1654f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1662f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_48()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_36()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_37()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1012f;
		float num2 = 798f;
		float num3 = 897f;
		if (Time.timeScale == 1021f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 279f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 485f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 35f);
		}
		float num4 = 378f;
		float num5 = 695f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 656f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 145f)
		{
			DJJAALCLLNC -= 1518f;
		}
		if (num4 != 1018f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1515f, 490f, 1722f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1522f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1655f;
		float num2 = 867f;
		float num3 = 1670f;
		if (Time.timeScale == 1172f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1175f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 820f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1624f);
		}
		float num4 = 591f;
		float num5 = 1637f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 401f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 732f)
		{
			DJJAALCLLNC -= 1845f;
		}
		if (num4 != 618f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(366f, 374f, 1183f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1595f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_72()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_45()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_30()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void Awake()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 599f;
		float num2 = 1058f;
		float num3 = 268f;
		if (Time.timeScale == 194f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 547f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 952f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1417f);
		}
		float num4 = 1013f;
		float num5 = 1219f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 461f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1223f)
		{
			DJJAALCLLNC -= 323f;
		}
		if (num4 != 87f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(983f, 672f, 1417f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 417f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void FixedUpdate()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		if (Time.timeScale == 1f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 0.02f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 0.02f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 0.02f);
		}
		float num4 = 0f;
		float num5 = 0f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 2f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > (float)Math.PI * 2f)
		{
			DJJAALCLLNC -= (float)Math.PI * 2f;
		}
		if (num4 != 0f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1f, 0f, 1f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 0.3f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 142f;
		float num2 = 864f;
		float num3 = 1474f;
		if (Time.timeScale == 1391f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1929f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1837f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 890f);
		}
		float num4 = 1895f;
		float num5 = 406f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1960f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 995f)
		{
			DJJAALCLLNC -= 1894f;
		}
		if (num4 != 980f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1852f, 1541f, 146f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1411f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_82()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 149f;
		float num2 = 1984f;
		float num3 = 1562f;
		if (Time.timeScale == 1210f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1458f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1859f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1623f);
		}
		float num4 = 51f;
		float num5 = 349f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 788f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1823f)
		{
			DJJAALCLLNC -= 233f;
		}
		if (num4 != 765f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(715f, 388f, 1319f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1301f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_35()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 644f;
		float num2 = 1857f;
		float num3 = 1357f;
		if (Time.timeScale == 352f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 790f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 51f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1147f);
		}
		float num4 = 1266f;
		float num5 = 1359f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 80f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1780f)
		{
			DJJAALCLLNC -= 15f;
		}
		if (num4 != 701f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1166f, 180f, 531f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 647f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1583f;
		float num2 = 689f;
		float num3 = 429f;
		if (Time.timeScale == 1812f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1542f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1536f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1515f);
		}
		float num4 = 124f;
		float num5 = 1299f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1976f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 737f)
		{
			DJJAALCLLNC -= 1764f;
		}
		if (num4 != 204f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1416f, 1791f, 1528f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 155f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1034f;
		float num2 = 1882f;
		float num3 = 1500f;
		if (Time.timeScale == 645f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1187f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 691f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 447f);
		}
		float num4 = 1831f;
		float num5 = 346f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 273f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1592f)
		{
			DJJAALCLLNC -= 1697f;
		}
		if (num4 != 836f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1990f, 17f, 1264f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 826f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1201f;
		float num2 = 677f;
		float num3 = 527f;
		if (Time.timeScale == 1903f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 50f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1519f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 115f);
		}
		float num4 = 1298f;
		float num5 = 382f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1072f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 119f)
		{
			DJJAALCLLNC -= 56f;
		}
		if (num4 != 1884f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1780f, 776f, 277f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 358f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_66()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_51()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 681f;
		float num2 = 1373f;
		float num3 = 813f;
		if (Time.timeScale == 1852f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 241f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 441f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1155f);
		}
		float num4 = 1391f;
		float num5 = 545f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1099f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 447f)
		{
			DJJAALCLLNC -= 1048f;
		}
		if (num4 != 425f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1261f, 894f, 293f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 477f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_60()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_34()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_70()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 171f;
		float num2 = 413f;
		float num3 = 1281f;
		if (Time.timeScale == 1133f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1490f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 329f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1231f);
		}
		float num4 = 263f;
		float num5 = 1393f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 936f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1413f)
		{
			DJJAALCLLNC -= 1030f;
		}
		if (num4 != 756f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(869f, 167f, 18f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1469f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_10()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_42()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_8()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1136f;
		float num2 = 1185f;
		float num3 = 1257f;
		if (Time.timeScale == 1829f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1014f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1239f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1039f);
		}
		float num4 = 700f;
		float num5 = 1468f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 305f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 395f)
		{
			DJJAALCLLNC -= 1606f;
		}
		if (num4 != 571f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(339f, 846f, 239f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1796f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 700f;
		float num2 = 1853f;
		float num3 = 1454f;
		if (Time.timeScale == 771f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 886f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 81f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1803f);
		}
		float num4 = 1248f;
		float num5 = 126f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1654f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 716f)
		{
			DJJAALCLLNC -= 1741f;
		}
		if (num4 != 343f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(915f, 952f, 894f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1372f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_4()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 372f;
		float num2 = 313f;
		float num3 = 1345f;
		if (Time.timeScale == 1843f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 558f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 197f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 380f);
		}
		float num4 = 1892f;
		float num5 = 290f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 226f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 338f)
		{
			DJJAALCLLNC -= 308f;
		}
		if (num4 != 1038f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1821f, 1744f, 1876f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 414f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1725f;
		float num2 = 1825f;
		float num3 = 878f;
		if (Time.timeScale == 831f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1724f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1009f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 476f);
		}
		float num4 = 874f;
		float num5 = 1516f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1062f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 109f)
		{
			DJJAALCLLNC -= 1455f;
		}
		if (num4 != 468f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1743f, 1726f, 962f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1998f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1477f;
		float num2 = 918f;
		float num3 = 170f;
		if (Time.timeScale == 556f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1675f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 85f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1813f);
		}
		float num4 = 892f;
		float num5 = 393f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 635f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1436f)
		{
			DJJAALCLLNC -= 964f;
		}
		if (num4 != 850f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(693f, 470f, 436f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 529f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_58()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 1812f;
		float num2 = 1560f;
		float num3 = 1900f;
		if (Time.timeScale == 1489f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 346f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 22f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1769f);
		}
		float num4 = 1934f;
		float num5 = 1228f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1482f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1640f)
		{
			DJJAALCLLNC -= 121f;
		}
		if (num4 != 1018f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(224f, 1635f, 1784f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 534f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_3()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 464f;
		float num2 = 1673f;
		float num3 = 1721f;
		if (Time.timeScale == 186f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1134f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 726f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1034f);
		}
		float num4 = 418f;
		float num5 = 939f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1649f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1817f)
		{
			DJJAALCLLNC -= 1970f;
		}
		if (num4 != 780f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1664f, 492f, 1678f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1939f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 625f;
		float num2 = 288f;
		float num3 = 1710f;
		if (Time.timeScale == 1610f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 188f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 1079f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1440f);
		}
		float num4 = 368f;
		float num5 = 135f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1625f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1744f)
		{
			DJJAALCLLNC -= 1019f;
		}
		if (num4 != 766f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(40f, 968f, 1787f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1647f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_65()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 596f;
		float num2 = 420f;
		float num3 = 1748f;
		if (Time.timeScale == 1356f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 31f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 547f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 1084f);
		}
		float num4 = 1884f;
		float num5 = 1431f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 1223f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 945f)
		{
			DJJAALCLLNC -= 494f;
		}
		if (num4 != 322f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1793f, 483f, 1327f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 890f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_55()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_16()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_0()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (CJFDABKPMND.AOBAACKKAKH)
		{
			return;
		}
		float num = 845f;
		float num2 = 1026f;
		float num3 = 1289f;
		if (Time.timeScale == 1578f)
		{
			if (num != CCCHDOBHDEH || num2 != HILHHMBHLBP || num3 != LILEEPENGBJ)
			{
				num = CCCHDOBHDEH;
				num2 = HILHHMBHLBP;
				num3 = LILEEPENGBJ;
			}
		}
		else
		{
			num = CCCHDOBHDEH * (Time.fixedDeltaTime / 1597f);
			num2 = HILHHMBHLBP * (Time.fixedDeltaTime / 544f);
			num3 = LILEEPENGBJ * (Time.fixedDeltaTime / 193f);
		}
		float num4 = 143f;
		float num5 = 249f;
		Vector3 b = Vector3.zero;
		num4 = Mathf.Sin(DJJAALCLLNC * 257f);
		num5 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1214f)
		{
			DJJAALCLLNC -= 26f;
		}
		if (num4 != 588f)
		{
			float num6 = num4 * EIIBEAIIIEL;
			float num7 = num5 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(334f, 416f, 898f);
			float num9 = num8 * num6;
			float num10 = num8 * num7;
			if (CJFDABKPMND.PDMALGAFALE)
			{
				b = new Vector3(BGCKDDNIOMK.x + num10, BGCKDDNIOMK.y + num9, b.z);
			}
		}
		else
		{
			b = BGCKDDNIOMK;
		}
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		else if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num2;
			EIIBEAIIIEL = DNABPIICJEG;
		}
		if (!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG * 1762f;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}
}
