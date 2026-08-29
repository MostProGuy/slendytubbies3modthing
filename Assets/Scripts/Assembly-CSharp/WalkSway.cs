using System;
using UnityEngine;

[AddComponentMenu("FPS system/Character/FPS WalkSway")]
public class WalkSway : MonoBehaviour
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

	private Vector3 IHGHMGCGNCC;

	private float HLALDECAHFG;

	private void __BB_OBFUSCATOR_36()
	{
		float num = 167f;
		float num2 = 1273f;
		Vector3 b = Vector3.zero;
		float num3 = 1289f;
		float num4 = 525f;
		float num5 = 403f;
		if (Time.timeScale == 1754f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1284f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1886f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 829f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 428f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1554f)
		{
			DJJAALCLLNC -= 1929f;
		}
		if (num != 1055f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(368f, 1836f, 777f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1812f;
			if (HLALDECAHFG < 1106f)
			{
				HLALDECAHFG += 1423f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 694f;
			}
			BGCKDDNIOMK = new Vector3(42f, 1242f, 95f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1487f, 1230f);
		}
		else
		{
			if (HLALDECAHFG > 1824f)
			{
				HLALDECAHFG -= 1274f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 22f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 971f, 184f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 305f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_48()
	{
		float num = 811f;
		float num2 = 896f;
		Vector3 b = Vector3.zero;
		float num3 = 1595f;
		float num4 = 156f;
		float num5 = 313f;
		if (Time.timeScale == 768f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1799f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1500f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1898f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 256f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1089f)
		{
			DJJAALCLLNC -= 1863f;
		}
		if (num != 1727f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(124f, 219f, 1794f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 26f;
			if (HLALDECAHFG < 642f)
			{
				HLALDECAHFG += 944f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1361f;
			}
			BGCKDDNIOMK = new Vector3(740f, 1286f, 48f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1469f, 1377f);
		}
		else
		{
			if (HLALDECAHFG > 24f)
			{
				HLALDECAHFG -= 1500f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1495f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1739f, 778f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1443f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_125()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_55()
	{
		float num = 1260f;
		float num2 = 1172f;
		Vector3 b = Vector3.zero;
		float num3 = 1196f;
		float num4 = 519f;
		float num5 = 77f;
		if (Time.timeScale == 525f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 556f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1808f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 469f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 560f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 790f)
		{
			DJJAALCLLNC -= 512f;
		}
		if (num != 1826f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(780f, 1685f, 1257f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1742f;
			if (HLALDECAHFG < 275f)
			{
				HLALDECAHFG += 183f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1461f;
			}
			BGCKDDNIOMK = new Vector3(1971f, 1529f, 280f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 466f, 87f);
		}
		else
		{
			if (HLALDECAHFG > 543f)
			{
				HLALDECAHFG -= 97f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 764f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 549f, 1992f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1576f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_11()
	{
		float num = 574f;
		float num2 = 1588f;
		Vector3 b = Vector3.zero;
		float num3 = 1824f;
		float num4 = 481f;
		float num5 = 366f;
		if (Time.timeScale == 380f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1724f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1074f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 541f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 171f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 495f)
		{
			DJJAALCLLNC -= 1883f;
		}
		if (num != 789f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(211f, 610f, 566f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1390f;
			if (HLALDECAHFG < 1653f)
			{
				HLALDECAHFG += 1488f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1971f;
			}
			BGCKDDNIOMK = new Vector3(1456f, 1263f, 209f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1046f, 1995f);
		}
		else
		{
			if (HLALDECAHFG > 228f)
			{
				HLALDECAHFG -= 616f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1741f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1356f, 1689f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1211f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_90()
	{
		float num = 1419f;
		float num2 = 1120f;
		Vector3 b = Vector3.zero;
		float num3 = 801f;
		float num4 = 1070f;
		float num5 = 652f;
		if (Time.timeScale == 1312f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 968f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 783f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1271f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 92f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 395f)
		{
			DJJAALCLLNC -= 895f;
		}
		if (num != 690f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1100f, 967f, 741f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 755f;
			if (HLALDECAHFG < 345f)
			{
				HLALDECAHFG += 1668f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1062f;
			}
			BGCKDDNIOMK = new Vector3(1377f, 796f, 1733f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1437f, 1594f);
		}
		else
		{
			if (HLALDECAHFG > 1503f)
			{
				HLALDECAHFG -= 38f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 118f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 80f, 1961f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 286f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_92()
	{
		float num = 704f;
		float num2 = 1334f;
		Vector3 b = Vector3.zero;
		float num3 = 1013f;
		float num4 = 624f;
		float num5 = 839f;
		if (Time.timeScale == 1189f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 733f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1274f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1255f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1159f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1874f)
		{
			DJJAALCLLNC -= 1389f;
		}
		if (num != 751f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(102f, 1315f, 870f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 546f;
			if (HLALDECAHFG < 1658f)
			{
				HLALDECAHFG += 783f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1591f;
			}
			BGCKDDNIOMK = new Vector3(1239f, 1849f, 1301f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1820f, 1659f);
		}
		else
		{
			if (HLALDECAHFG > 566f)
			{
				HLALDECAHFG -= 1843f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 785f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1973f, 1117f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1159f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_78()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_99()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_69()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_23()
	{
		float num = 819f;
		float num2 = 1919f;
		Vector3 b = Vector3.zero;
		float num3 = 1444f;
		float num4 = 614f;
		float num5 = 1237f;
		if (Time.timeScale == 1517f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1363f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1008f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 652f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 851f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 279f)
		{
			DJJAALCLLNC -= 1779f;
		}
		if (num != 1568f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1067f, 1097f, 391f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1180f;
			if (HLALDECAHFG < 635f)
			{
				HLALDECAHFG += 1377f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 970f;
			}
			BGCKDDNIOMK = new Vector3(935f, 688f, 301f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 870f, 1842f);
		}
		else
		{
			if (HLALDECAHFG > 1483f)
			{
				HLALDECAHFG -= 1616f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1209f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1015f, 1989f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 279f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_31()
	{
		float num = 1114f;
		float num2 = 1469f;
		Vector3 b = Vector3.zero;
		float num3 = 843f;
		float num4 = 917f;
		float num5 = 984f;
		if (Time.timeScale == 725f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 446f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1488f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 462f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1509f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1976f)
		{
			DJJAALCLLNC -= 1858f;
		}
		if (num != 972f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(90f, 989f, 917f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 329f;
			if (HLALDECAHFG < 1057f)
			{
				HLALDECAHFG += 1803f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 4f;
			}
			BGCKDDNIOMK = new Vector3(227f, 642f, 1006f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 231f, 1513f);
		}
		else
		{
			if (HLALDECAHFG > 1312f)
			{
				HLALDECAHFG -= 1138f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 601f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1082f, 415f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1952f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_17()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_59()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_7()
	{
		float num = 956f;
		float num2 = 435f;
		Vector3 b = Vector3.zero;
		float num3 = 539f;
		float num4 = 836f;
		float num5 = 1780f;
		if (Time.timeScale == 212f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 932f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 805f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 837f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1160f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 859f)
		{
			DJJAALCLLNC -= 1707f;
		}
		if (num != 1413f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1074f, 778f, 647f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 910f;
			if (HLALDECAHFG < 1120f)
			{
				HLALDECAHFG += 1545f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 731f;
			}
			BGCKDDNIOMK = new Vector3(1502f, 854f, 1200f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 939f, 1409f);
		}
		else
		{
			if (HLALDECAHFG > 1945f)
			{
				HLALDECAHFG -= 1184f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 237f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 760f, 1959f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1562f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_15()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_52()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_76()
	{
		float num = 1072f;
		float num2 = 1309f;
		Vector3 b = Vector3.zero;
		float num3 = 484f;
		float num4 = 1606f;
		float num5 = 1997f;
		if (Time.timeScale == 1568f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1208f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1741f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 479f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 963f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 999f)
		{
			DJJAALCLLNC -= 487f;
		}
		if (num != 74f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(752f, 1091f, 1933f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 760f;
			if (HLALDECAHFG < 31f)
			{
				HLALDECAHFG += 211f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1993f;
			}
			BGCKDDNIOMK = new Vector3(1015f, 1576f, 1138f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1696f, 1370f);
		}
		else
		{
			if (HLALDECAHFG > 425f)
			{
				HLALDECAHFG -= 36f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 262f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 270f, 704f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 298f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_109()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_107()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_68()
	{
		float num = 1007f;
		float num2 = 990f;
		Vector3 b = Vector3.zero;
		float num3 = 1784f;
		float num4 = 1963f;
		float num5 = 76f;
		if (Time.timeScale == 1195f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 410f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 832f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1261f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 123f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 511f)
		{
			DJJAALCLLNC -= 1295f;
		}
		if (num != 867f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1554f, 129f, 84f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 219f;
			if (HLALDECAHFG < 1206f)
			{
				HLALDECAHFG += 893f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1918f;
			}
			BGCKDDNIOMK = new Vector3(1331f, 132f, 583f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1189f, 337f);
		}
		else
		{
			if (HLALDECAHFG > 680f)
			{
				HLALDECAHFG -= 344f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1683f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 647f, 1399f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 717f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_10()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_81()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_1()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_44()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void FixedUpdate()
	{
		float num = 0f;
		float num2 = 0f;
		Vector3 b = Vector3.zero;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		if (Time.timeScale == 1f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 0.02f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 0.02f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 0.02f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 2f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > (float)Math.PI * 2f)
		{
			DJJAALCLLNC -= (float)Math.PI * 2f;
		}
		if (num != 0f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 10f;
			if (HLALDECAHFG < 20f)
			{
				HLALDECAHFG += 60f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 20f;
			}
			BGCKDDNIOMK = new Vector3(0f, 0.15f, 0f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 0f, 0f);
		}
		else
		{
			if (HLALDECAHFG > 0f)
			{
				HLALDECAHFG -= 60f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 0f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 0f, 0f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 0.3f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_105()
	{
		float num = 1026f;
		float num2 = 1008f;
		Vector3 b = Vector3.zero;
		float num3 = 1091f;
		float num4 = 1633f;
		float num5 = 1188f;
		if (Time.timeScale == 881f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1018f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1193f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 636f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1542f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 153f)
		{
			DJJAALCLLNC -= 789f;
		}
		if (num != 1713f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1612f, 1561f, 1099f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1453f;
			if (HLALDECAHFG < 1442f)
			{
				HLALDECAHFG += 265f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 83f;
			}
			BGCKDDNIOMK = new Vector3(906f, 941f, 322f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 452f, 429f);
		}
		else
		{
			if (HLALDECAHFG > 716f)
			{
				HLALDECAHFG -= 852f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 412f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1122f, 1109f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 451f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_75()
	{
		float num = 1484f;
		float num2 = 1640f;
		Vector3 b = Vector3.zero;
		float num3 = 567f;
		float num4 = 1764f;
		float num5 = 1590f;
		if (Time.timeScale == 1246f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1049f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 309f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 870f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 604f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1402f)
		{
			DJJAALCLLNC -= 332f;
		}
		if (num != 1382f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(515f, 588f, 1088f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1903f;
			if (HLALDECAHFG < 564f)
			{
				HLALDECAHFG += 1269f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 419f;
			}
			BGCKDDNIOMK = new Vector3(448f, 1558f, 1598f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1251f, 1825f);
		}
		else
		{
			if (HLALDECAHFG > 843f)
			{
				HLALDECAHFG -= 1039f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 233f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1978f, 1961f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 692f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_82()
	{
		float num = 815f;
		float num2 = 1627f;
		Vector3 b = Vector3.zero;
		float num3 = 95f;
		float num4 = 387f;
		float num5 = 1127f;
		if (Time.timeScale == 378f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1717f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 724f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1828f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 551f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 986f)
		{
			DJJAALCLLNC -= 534f;
		}
		if (num != 1404f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(635f, 1274f, 1088f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1173f;
			if (HLALDECAHFG < 249f)
			{
				HLALDECAHFG += 1232f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1207f;
			}
			BGCKDDNIOMK = new Vector3(1882f, 722f, 594f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1636f, 101f);
		}
		else
		{
			if (HLALDECAHFG > 400f)
			{
				HLALDECAHFG -= 1150f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1183f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1660f, 1545f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1306f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_22()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_9()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_104()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_83()
	{
		float num = 1579f;
		float num2 = 917f;
		Vector3 b = Vector3.zero;
		float num3 = 27f;
		float num4 = 1245f;
		float num5 = 1570f;
		if (Time.timeScale == 787f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1924f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1024f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1926f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1128f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 249f)
		{
			DJJAALCLLNC -= 1281f;
		}
		if (num != 1934f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(998f, 1078f, 1009f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1609f;
			if (HLALDECAHFG < 1042f)
			{
				HLALDECAHFG += 517f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1504f;
			}
			BGCKDDNIOMK = new Vector3(714f, 1445f, 687f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1198f, 1203f);
		}
		else
		{
			if (HLALDECAHFG > 354f)
			{
				HLALDECAHFG -= 64f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1149f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1324f, 1902f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1176f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_12()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_114()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_119()
	{
		float num = 373f;
		float num2 = 1311f;
		Vector3 b = Vector3.zero;
		float num3 = 1109f;
		float num4 = 1772f;
		float num5 = 546f;
		if (Time.timeScale == 982f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1861f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 602f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 260f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 125f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 458f)
		{
			DJJAALCLLNC -= 1747f;
		}
		if (num != 1860f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(928f, 79f, 1013f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 105f;
			if (HLALDECAHFG < 1936f)
			{
				HLALDECAHFG += 720f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1524f;
			}
			BGCKDDNIOMK = new Vector3(613f, 1008f, 260f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 440f, 368f);
		}
		else
		{
			if (HLALDECAHFG > 742f)
			{
				HLALDECAHFG -= 808f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1697f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 987f, 328f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1460f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_115()
	{
		float num = 84f;
		float num2 = 181f;
		Vector3 b = Vector3.zero;
		float num3 = 1805f;
		float num4 = 1241f;
		float num5 = 624f;
		if (Time.timeScale == 1767f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 122f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 930f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1844f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1636f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 46f)
		{
			DJJAALCLLNC -= 1236f;
		}
		if (num != 982f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(538f, 1044f, 597f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 815f;
			if (HLALDECAHFG < 1552f)
			{
				HLALDECAHFG += 535f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 496f;
			}
			BGCKDDNIOMK = new Vector3(322f, 431f, 816f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 227f, 461f);
		}
		else
		{
			if (HLALDECAHFG > 801f)
			{
				HLALDECAHFG -= 55f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1361f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1636f, 358f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 335f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_20()
	{
		float num = 1882f;
		float num2 = 1797f;
		Vector3 b = Vector3.zero;
		float num3 = 1506f;
		float num4 = 1987f;
		float num5 = 469f;
		if (Time.timeScale == 1132f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 778f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 677f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 754f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1672f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 110f)
		{
			DJJAALCLLNC -= 984f;
		}
		if (num != 1706f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1803f, 111f, 1321f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 933f;
			if (HLALDECAHFG < 1503f)
			{
				HLALDECAHFG += 764f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1613f;
			}
			BGCKDDNIOMK = new Vector3(1127f, 981f, 291f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1390f, 1026f);
		}
		else
		{
			if (HLALDECAHFG > 1190f)
			{
				HLALDECAHFG -= 1635f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 224f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 431f, 54f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 702f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_123()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_70()
	{
		float num = 1369f;
		float num2 = 576f;
		Vector3 b = Vector3.zero;
		float num3 = 1345f;
		float num4 = 1671f;
		float num5 = 128f;
		if (Time.timeScale == 1647f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 724f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 595f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1128f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1580f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 97f)
		{
			DJJAALCLLNC -= 119f;
		}
		if (num != 600f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1193f, 1223f, 37f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 726f;
			if (HLALDECAHFG < 337f)
			{
				HLALDECAHFG += 1128f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1313f;
			}
			BGCKDDNIOMK = new Vector3(1548f, 171f, 678f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1848f, 1876f);
		}
		else
		{
			if (HLALDECAHFG > 472f)
			{
				HLALDECAHFG -= 964f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1199f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 476f, 1754f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1608f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_87()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_71()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_58()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_126()
	{
		float num = 902f;
		float num2 = 159f;
		Vector3 b = Vector3.zero;
		float num3 = 300f;
		float num4 = 1376f;
		float num5 = 602f;
		if (Time.timeScale == 622f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1821f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1648f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1841f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1324f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1982f)
		{
			DJJAALCLLNC -= 72f;
		}
		if (num != 174f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1279f, 1026f, 452f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1528f;
			if (HLALDECAHFG < 1776f)
			{
				HLALDECAHFG += 378f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1024f;
			}
			BGCKDDNIOMK = new Vector3(595f, 1923f, 1897f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1998f, 517f);
		}
		else
		{
			if (HLALDECAHFG > 1398f)
			{
				HLALDECAHFG -= 1230f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1179f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1134f, 511f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1528f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_47()
	{
		float num = 461f;
		float num2 = 1890f;
		Vector3 b = Vector3.zero;
		float num3 = 1030f;
		float num4 = 6f;
		float num5 = 965f;
		if (Time.timeScale == 47f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1809f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 587f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 183f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 355f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1736f)
		{
			DJJAALCLLNC -= 1009f;
		}
		if (num != 1899f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1044f, 149f, 79f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 242f;
			if (HLALDECAHFG < 1523f)
			{
				HLALDECAHFG += 1963f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1642f;
			}
			BGCKDDNIOMK = new Vector3(721f, 1500f, 94f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1437f, 435f);
		}
		else
		{
			if (HLALDECAHFG > 1704f)
			{
				HLALDECAHFG -= 1125f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 306f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1802f, 1752f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1690f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_35()
	{
		float num = 1539f;
		float num2 = 1003f;
		Vector3 b = Vector3.zero;
		float num3 = 1420f;
		float num4 = 1761f;
		float num5 = 627f;
		if (Time.timeScale == 782f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1981f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1518f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 66f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1141f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 399f)
		{
			DJJAALCLLNC -= 1941f;
		}
		if (num != 899f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(993f, 1860f, 827f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 380f;
			if (HLALDECAHFG < 976f)
			{
				HLALDECAHFG += 1205f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1579f;
			}
			BGCKDDNIOMK = new Vector3(1733f, 119f, 1628f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 257f, 1733f);
		}
		else
		{
			if (HLALDECAHFG > 285f)
			{
				HLALDECAHFG -= 1104f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 641f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1126f, 501f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1905f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_110()
	{
		float num = 1122f;
		float num2 = 1398f;
		Vector3 b = Vector3.zero;
		float num3 = 1675f;
		float num4 = 927f;
		float num5 = 1797f;
		if (Time.timeScale == 1455f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1725f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1943f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 45f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 310f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1991f)
		{
			DJJAALCLLNC -= 1469f;
		}
		if (num != 525f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1526f, 1405f, 689f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1243f;
			if (HLALDECAHFG < 1934f)
			{
				HLALDECAHFG += 1209f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1267f;
			}
			BGCKDDNIOMK = new Vector3(164f, 513f, 1208f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 847f, 644f);
		}
		else
		{
			if (HLALDECAHFG > 723f)
			{
				HLALDECAHFG -= 1254f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 916f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1838f, 590f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1511f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_85()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_28()
	{
		float num = 1884f;
		float num2 = 969f;
		Vector3 b = Vector3.zero;
		float num3 = 1408f;
		float num4 = 886f;
		float num5 = 216f;
		if (Time.timeScale == 662f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1403f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1061f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1824f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 253f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1506f)
		{
			DJJAALCLLNC -= 1643f;
		}
		if (num != 97f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(410f, 1613f, 1188f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 766f;
			if (HLALDECAHFG < 710f)
			{
				HLALDECAHFG += 1278f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1998f;
			}
			BGCKDDNIOMK = new Vector3(1578f, 661f, 1032f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1359f, 1032f);
		}
		else
		{
			if (HLALDECAHFG > 15f)
			{
				HLALDECAHFG -= 1317f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1560f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1272f, 1800f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 106f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_120()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_13()
	{
		float num = 1444f;
		float num2 = 990f;
		Vector3 b = Vector3.zero;
		float num3 = 570f;
		float num4 = 1816f;
		float num5 = 440f;
		if (Time.timeScale == 222f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1722f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 70f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 936f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 147f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1274f)
		{
			DJJAALCLLNC -= 795f;
		}
		if (num != 36f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(839f, 1225f, 751f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1447f;
			if (HLALDECAHFG < 346f)
			{
				HLALDECAHFG += 1602f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 585f;
			}
			BGCKDDNIOMK = new Vector3(294f, 809f, 616f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 123f, 1917f);
		}
		else
		{
			if (HLALDECAHFG > 460f)
			{
				HLALDECAHFG -= 1070f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1007f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1263f, 651f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 476f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_117()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_27()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_80()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_66()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_102()
	{
		float num = 535f;
		float num2 = 454f;
		Vector3 b = Vector3.zero;
		float num3 = 221f;
		float num4 = 1596f;
		float num5 = 1705f;
		if (Time.timeScale == 1065f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1060f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1765f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 582f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 560f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1816f)
		{
			DJJAALCLLNC -= 312f;
		}
		if (num != 594f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1386f, 161f, 795f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 186f;
			if (HLALDECAHFG < 80f)
			{
				HLALDECAHFG += 1611f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1495f;
			}
			BGCKDDNIOMK = new Vector3(894f, 1694f, 119f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1228f, 1097f);
		}
		else
		{
			if (HLALDECAHFG > 734f)
			{
				HLALDECAHFG -= 660f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1421f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1487f, 1571f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 482f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_112()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_79()
	{
		float num = 295f;
		float num2 = 1400f;
		Vector3 b = Vector3.zero;
		float num3 = 1593f;
		float num4 = 443f;
		float num5 = 1735f;
		if (Time.timeScale == 521f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1869f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 267f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 272f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1507f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1562f)
		{
			DJJAALCLLNC -= 1964f;
		}
		if (num != 604f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1567f, 252f, 1664f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1998f;
			if (HLALDECAHFG < 140f)
			{
				HLALDECAHFG += 242f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1630f;
			}
			BGCKDDNIOMK = new Vector3(636f, 1613f, 326f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 397f, 91f);
		}
		else
		{
			if (HLALDECAHFG > 1726f)
			{
				HLALDECAHFG -= 785f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1274f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 989f, 1306f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 682f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_21()
	{
		float num = 761f;
		float num2 = 908f;
		Vector3 b = Vector3.zero;
		float num3 = 987f;
		float num4 = 1141f;
		float num5 = 211f;
		if (Time.timeScale == 900f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1186f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1481f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 397f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1981f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 62f)
		{
			DJJAALCLLNC -= 1080f;
		}
		if (num != 628f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1259f, 401f, 1958f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 622f;
			if (HLALDECAHFG < 1297f)
			{
				HLALDECAHFG += 824f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1704f;
			}
			BGCKDDNIOMK = new Vector3(595f, 1066f, 1730f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 162f, 683f);
		}
		else
		{
			if (HLALDECAHFG > 1705f)
			{
				HLALDECAHFG -= 250f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 375f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1152f, 107f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1466f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_98()
	{
		float num = 1248f;
		float num2 = 505f;
		Vector3 b = Vector3.zero;
		float num3 = 66f;
		float num4 = 1281f;
		float num5 = 1470f;
		if (Time.timeScale == 1897f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 826f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1330f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 826f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1557f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 735f)
		{
			DJJAALCLLNC -= 597f;
		}
		if (num != 1623f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1314f, 388f, 449f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1030f;
			if (HLALDECAHFG < 1844f)
			{
				HLALDECAHFG += 1318f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1380f;
			}
			BGCKDDNIOMK = new Vector3(148f, 247f, 1068f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1801f, 456f);
		}
		else
		{
			if (HLALDECAHFG > 560f)
			{
				HLALDECAHFG -= 993f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 484f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1111f, 663f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 990f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_46()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_91()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_18()
	{
		float num = 1308f;
		float num2 = 790f;
		Vector3 b = Vector3.zero;
		float num3 = 44f;
		float num4 = 724f;
		float num5 = 1864f;
		if (Time.timeScale == 1362f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1450f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1640f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 824f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1704f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 873f)
		{
			DJJAALCLLNC -= 199f;
		}
		if (num != 1304f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(879f, 722f, 862f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 620f;
			if (HLALDECAHFG < 517f)
			{
				HLALDECAHFG += 1205f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1606f;
			}
			BGCKDDNIOMK = new Vector3(475f, 521f, 888f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1774f, 1080f);
		}
		else
		{
			if (HLALDECAHFG > 178f)
			{
				HLALDECAHFG -= 1599f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 828f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 733f, 484f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1850f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_121()
	{
		float num = 1124f;
		float num2 = 398f;
		Vector3 b = Vector3.zero;
		float num3 = 741f;
		float num4 = 54f;
		float num5 = 1918f;
		if (Time.timeScale == 1469f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1533f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1311f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1322f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 653f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1140f)
		{
			DJJAALCLLNC -= 418f;
		}
		if (num != 3f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1832f, 41f, 734f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1320f;
			if (HLALDECAHFG < 1637f)
			{
				HLALDECAHFG += 1872f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 59f;
			}
			BGCKDDNIOMK = new Vector3(1651f, 1369f, 250f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1054f, 1497f);
		}
		else
		{
			if (HLALDECAHFG > 1423f)
			{
				HLALDECAHFG -= 906f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1787f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1405f, 512f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 539f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_94()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_25()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_67()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_40()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_65()
	{
		float num = 89f;
		float num2 = 1897f;
		Vector3 b = Vector3.zero;
		float num3 = 356f;
		float num4 = 483f;
		float num5 = 596f;
		if (Time.timeScale == 252f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 908f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 107f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 654f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 253f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1347f)
		{
			DJJAALCLLNC -= 1715f;
		}
		if (num != 1293f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1283f, 627f, 518f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 132f;
			if (HLALDECAHFG < 71f)
			{
				HLALDECAHFG += 960f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1386f;
			}
			BGCKDDNIOMK = new Vector3(669f, 259f, 154f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1788f, 1874f);
		}
		else
		{
			if (HLALDECAHFG > 178f)
			{
				HLALDECAHFG -= 839f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1927f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 235f, 1009f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1215f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_103()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_42()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_122()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_38()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_97()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_6()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_3()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_19()
	{
		float num = 1227f;
		float num2 = 389f;
		Vector3 b = Vector3.zero;
		float num3 = 969f;
		float num4 = 1644f;
		float num5 = 1552f;
		if (Time.timeScale == 597f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1846f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1301f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 363f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1320f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 939f)
		{
			DJJAALCLLNC -= 981f;
		}
		if (num != 1939f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(749f, 1870f, 1292f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 679f;
			if (HLALDECAHFG < 1060f)
			{
				HLALDECAHFG += 740f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 928f;
			}
			BGCKDDNIOMK = new Vector3(1676f, 1411f, 668f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 163f, 570f);
		}
		else
		{
			if (HLALDECAHFG > 1117f)
			{
				HLALDECAHFG -= 1018f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 824f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1579f, 180f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 831f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_39()
	{
		float num = 1947f;
		float num2 = 399f;
		Vector3 b = Vector3.zero;
		float num3 = 1420f;
		float num4 = 1397f;
		float num5 = 1097f;
		if (Time.timeScale == 564f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 547f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1374f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1939f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1589f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1796f)
		{
			DJJAALCLLNC -= 369f;
		}
		if (num != 1432f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(975f, 1691f, 1683f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1150f;
			if (HLALDECAHFG < 1818f)
			{
				HLALDECAHFG += 296f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1878f;
			}
			BGCKDDNIOMK = new Vector3(247f, 1822f, 635f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 942f, 236f);
		}
		else
		{
			if (HLALDECAHFG > 1956f)
			{
				HLALDECAHFG -= 315f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1611f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 801f, 480f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1602f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_96()
	{
		float num = 1828f;
		float num2 = 1425f;
		Vector3 b = Vector3.zero;
		float num3 = 197f;
		float num4 = 563f;
		float num5 = 766f;
		if (Time.timeScale == 1223f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1046f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 1864f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1849f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 801f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 1847f)
		{
			DJJAALCLLNC -= 949f;
		}
		if (num != 486f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1592f, 1620f, 1030f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1011f;
			if (HLALDECAHFG < 1488f)
			{
				HLALDECAHFG += 1903f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1095f;
			}
			BGCKDDNIOMK = new Vector3(489f, 805f, 266f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 737f, 237f);
		}
		else
		{
			if (HLALDECAHFG > 1855f)
			{
				HLALDECAHFG -= 1272f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1333f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 60f, 106f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1780f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_2()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void Awake()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_95()
	{
		float num = 885f;
		float num2 = 1796f;
		Vector3 b = Vector3.zero;
		float num3 = 1775f;
		float num4 = 364f;
		float num5 = 1901f;
		if (Time.timeScale == 856f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1409f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 813f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 306f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1892f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 245f)
		{
			DJJAALCLLNC -= 1152f;
		}
		if (num != 579f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(995f, 190f, 1822f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 755f;
			if (HLALDECAHFG < 628f)
			{
				HLALDECAHFG += 1839f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1329f;
			}
			BGCKDDNIOMK = new Vector3(930f, 876f, 1986f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 135f, 539f);
		}
		else
		{
			if (HLALDECAHFG > 401f)
			{
				HLALDECAHFG -= 787f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 401f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1322f, 189f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 454f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_5()
	{
		float num = 1051f;
		float num2 = 1750f;
		Vector3 b = Vector3.zero;
		float num3 = 858f;
		float num4 = 1977f;
		float num5 = 578f;
		if (Time.timeScale == 710f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1323f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 546f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 143f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 663f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 314f)
		{
			DJJAALCLLNC -= 493f;
		}
		if (num != 1374f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(1415f, 801f, 1946f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 1743f;
			if (HLALDECAHFG < 27f)
			{
				HLALDECAHFG += 835f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1972f;
			}
			BGCKDDNIOMK = new Vector3(664f, 1978f, 1878f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 483f, 1487f);
		}
		else
		{
			if (HLALDECAHFG > 1086f)
			{
				HLALDECAHFG -= 922f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 234f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 353f, 95f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1513f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}

	private void __BB_OBFUSCATOR_34()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		BGCKDDNIOMK = base.transform.localPosition;
		IHGHMGCGNCC = BGCKDDNIOMK;
	}

	private void __BB_OBFUSCATOR_51()
	{
		float num = 1746f;
		float num2 = 327f;
		Vector3 b = Vector3.zero;
		float num3 = 1007f;
		float num4 = 188f;
		float num5 = 921f;
		if (Time.timeScale == 1096f)
		{
			if (num3 != CCCHDOBHDEH || num4 != HILHHMBHLBP || num5 != LILEEPENGBJ)
			{
				num3 = CCCHDOBHDEH;
				num4 = HILHHMBHLBP;
				num5 = LILEEPENGBJ;
			}
		}
		else
		{
			num3 = CCCHDOBHDEH * (Time.fixedDeltaTime / 1651f);
			num4 = HILHHMBHLBP * (Time.fixedDeltaTime / 52f);
			num5 = LILEEPENGBJ * (Time.fixedDeltaTime / 1547f);
		}
		num = Mathf.Sin(DJJAALCLLNC * 1243f);
		num2 = Mathf.Sin(DJJAALCLLNC);
		DJJAALCLLNC += GFAEDOJPPOJ;
		if (DJJAALCLLNC > 874f)
		{
			DJJAALCLLNC -= 360f;
		}
		if (num != 147f)
		{
			float num6 = num * EIIBEAIIIEL;
			float num7 = num2 * EIIBEAIIIEL;
			float num8 = Mathf.Clamp(119f, 1869f, 693f);
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
		if (CJFDABKPMND.MPBEELGNNCF && !CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num3;
			EIIBEAIIIEL = DNABPIICJEG;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		if (CJFDABKPMND.KKBOHCFDNGD)
		{
			GFAEDOJPPOJ = num4;
			EIIBEAIIIEL = DNABPIICJEG * 171f;
			if (HLALDECAHFG < 28f)
			{
				HLALDECAHFG += 382f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 210f;
			}
			BGCKDDNIOMK = new Vector3(997f, 680f, 370f);
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 640f, 330f);
		}
		else
		{
			if (HLALDECAHFG > 197f)
			{
				HLALDECAHFG -= 1549f * Time.deltaTime;
			}
			else
			{
				HLALDECAHFG = 1620f;
			}
			base.transform.localEulerAngles = new Vector3(HLALDECAHFG, 1547f, 1464f);
		}
		if ((!CJFDABKPMND.KKBOHCFDNGD && !CJFDABKPMND.MPBEELGNNCF) || CJFDABKPMND.AOBAACKKAKH)
		{
			GFAEDOJPPOJ = num5;
			EIIBEAIIIEL = DNABPIICJEG * 1138f;
			BGCKDDNIOMK = IHGHMGCGNCC;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * HOIAFHMEMIL);
	}
}
