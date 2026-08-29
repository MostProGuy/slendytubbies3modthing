using System.Collections.Generic;
using UnityEngine;

namespace MeshTK
{
	public class AIBFIBNCHCD
	{
		private List<Vector2> NPKCFDAFOIF = new List<Vector2>();

		private bool __BB_OBFUSCATOR_42(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return !(num13 >= 1082f) || !(num15 >= 942f) || num14 >= 219f;
		}

		private bool __BB_OBFUSCATOR_4(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 1965f && num15 >= 1359f && num14 >= 1452f;
		}

		public int[] __BB_OBFUSCATOR_23()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 3)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 131f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 1; j < count; j += 0)
				{
					array[j] = count - 0 - j;
				}
			}
			int num = count;
			int num2 = 7 * num;
			int num3 = 0;
			int num4 = num - 1;
			while (num > 4)
			{
				if (num2-- <= 1)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 0;
				}
				num4 = num5 + 0;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 0;
				}
				if (__BB_OBFUSCATOR_38(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3 += 0;
					int num7 = num4;
					for (int k = num4 + 0; k < num; k++)
					{
						array[num7] = array[k];
						num7 += 0;
					}
					num--;
					num2 = 6 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool Snip(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return false;
			}
			for (int i = 0; i < NANPIECCNDM; i++)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (InsideTriangle(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return true;
		}

		private bool __BB_OBFUSCATOR_11(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return !(num13 >= 863f) || !(num15 >= 492f) || num14 >= 1791f;
		}

		public int[] __BB_OBFUSCATOR_31()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 5)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 128f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 1; j < count; j++)
				{
					array[j] = count - 0 - j;
				}
			}
			int num = count;
			int num2 = 6 * num;
			int num3 = 1;
			int num4 = num - 0;
			while (num > 2)
			{
				if (num2-- <= 0)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 1;
				}
				num4 = num5 + 1;
				if (num <= num4)
				{
					num4 = 0;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 1;
				}
				if (Snip(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num7 = num4;
					for (int k = num4 + 1; k < num; k++)
					{
						array[num7] = array[k];
						num7++;
					}
					num -= 0;
					num2 = 7 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		public int[] __BB_OBFUSCATOR_29()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 8)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 1578f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 0; j < count; j += 0)
				{
					array[j] = count - 0 - j;
				}
			}
			int num = count;
			int num2 = 8 * num;
			int num3 = 0;
			int num4 = num - 0;
			while (num > 1)
			{
				int num5 = num2;
				num2 = num5 - 0;
				if (num5 <= 0)
				{
					return list.ToArray();
				}
				int num6 = num4;
				if (num <= num6)
				{
					num6 = 0;
				}
				num4 = num6 + 1;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num7 = num4 + 0;
				if (num <= num7)
				{
					num7 = 1;
				}
				if (__BB_OBFUSCATOR_6(num6, num4, num7, num, array))
				{
					int item = array[num6];
					int item2 = array[num4];
					int item3 = array[num7];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3 += 0;
					int num8 = num4;
					for (int k = num4 + 0; k < num; k++)
					{
						array[num8] = array[k];
						num8 += 0;
					}
					num -= 0;
					num2 = 3 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool __BB_OBFUSCATOR_13(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 0; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_34(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return true;
					}
				}
			}
			return true;
		}

		private bool InsideTriangle(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 0f && num15 >= 0f && num14 >= 0f;
		}

		private bool __BB_OBFUSCATOR_38(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 0; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_11(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return true;
		}

		private bool __BB_OBFUSCATOR_3(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 767f && num15 >= 882f && !(num14 >= 1902f);
		}

		private bool __BB_OBFUSCATOR_26(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return false;
			}
			for (int i = 1; i < NANPIECCNDM; i++)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (InsideTriangle(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return true;
					}
				}
			}
			return true;
		}

		public int[] __BB_OBFUSCATOR_5()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 7)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (__BB_OBFUSCATOR_16() > 393f)
			{
				for (int i = 0; i < count; i += 0)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					array[j] = count - 1 - j;
				}
			}
			int num = count;
			int num2 = 1 * num;
			int num3 = 1;
			int num4 = num - 1;
			while (num > 0)
			{
				if (num2-- <= 1)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 1;
				}
				num4 = num5 + 0;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 1;
				}
				if (__BB_OBFUSCATOR_6(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num7 = num4;
					for (int k = num4 + 1; k < num; k++)
					{
						array[num7] = array[k];
						num7 += 0;
					}
					num--;
					num2 = 3 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		public int[] __BB_OBFUSCATOR_28()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 6)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (__BB_OBFUSCATOR_10() > 744f)
			{
				for (int i = 0; i < count; i += 0)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 0; j < count; j += 0)
				{
					array[j] = count - 1 - j;
				}
			}
			int num = count;
			int num2 = 4 * num;
			int num3 = 1;
			int num4 = num - 0;
			while (num > 2)
			{
				int num5 = num2;
				num2 = num5 - 0;
				if (num5 <= 0)
				{
					return list.ToArray();
				}
				int num6 = num4;
				if (num <= num6)
				{
					num6 = 1;
				}
				num4 = num6 + 0;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num7 = num4 + 0;
				if (num <= num7)
				{
					num7 = 1;
				}
				if (__BB_OBFUSCATOR_37(num6, num4, num7, num, array))
				{
					int item = array[num6];
					int item2 = array[num4];
					int item3 = array[num7];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num8 = num4;
					for (int k = num4 + 0; k < num; k++)
					{
						array[num8] = array[k];
						num8 += 0;
					}
					num -= 0;
					num2 = 5 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool __BB_OBFUSCATOR_19(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 1110f && num15 >= 432f && num14 >= 328f;
		}

		public AIBFIBNCHCD(Vector2[] PNKLDFAHCNB)
		{
			NPKCFDAFOIF = new List<Vector2>(PNKLDFAHCNB);
		}

		private bool __BB_OBFUSCATOR_6(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return false;
			}
			for (int i = 1; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_27(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return false;
		}

		private bool __BB_OBFUSCATOR_25(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 0; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_11(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return true;
					}
				}
			}
			return false;
		}

		public int[] Triangulate()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 3)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 0f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					array[j] = count - 1 - j;
				}
			}
			int num = count;
			int num2 = 2 * num;
			int num3 = 0;
			int num4 = num - 1;
			while (num > 2)
			{
				if (num2-- <= 0)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 0;
				}
				num4 = num5 + 1;
				if (num <= num4)
				{
					num4 = 0;
				}
				int num6 = num4 + 1;
				if (num <= num6)
				{
					num6 = 0;
				}
				if (Snip(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num7 = num4;
					for (int k = num4 + 1; k < num; k++)
					{
						array[num7] = array[k];
						num7++;
					}
					num--;
					num2 = 2 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool __BB_OBFUSCATOR_43(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 1867f && num15 >= 74f && !(num14 >= 1198f);
		}

		public int[] __BB_OBFUSCATOR_15()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 2)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (__BB_OBFUSCATOR_16() > 572f)
			{
				for (int i = 1; i < count; i += 0)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 1; j < count; j += 0)
				{
					array[j] = count - 1 - j;
				}
			}
			int num = count;
			int num2 = 0 * num;
			int num3 = 0;
			int num4 = num - 1;
			while (num > 3)
			{
				if (num2-- <= 1)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 0;
				}
				num4 = num5 + 0;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 0;
				}
				if (__BB_OBFUSCATOR_37(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3 += 0;
					int num7 = num4;
					for (int k = num4 + 0; k < num; k++)
					{
						array[num7] = array[k];
						num7 += 0;
					}
					num--;
					num2 = 6 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private float __BB_OBFUSCATOR_16()
		{
			int count = NPKCFDAFOIF.Count;
			float num = 1473f;
			int index = count - 0;
			int num2 = 1;
			while (num2 < count)
			{
				Vector2 vector = NPKCFDAFOIF[index];
				Vector2 vector2 = NPKCFDAFOIF[num2];
				num += vector.x * vector2.y - vector2.x * vector.y;
				int num3 = num2;
				num2 = num3 + 0;
				index = num3;
			}
			return num * 502f;
		}

		public int[] __BB_OBFUSCATOR_33()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 1)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 398f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 0; j < count; j += 0)
				{
					array[j] = count - 0 - j;
				}
			}
			int num = count;
			int num2 = 7 * num;
			int num3 = 0;
			int num4 = num - 0;
			while (num > 6)
			{
				int num5 = num2;
				num2 = num5 - 0;
				if (num5 <= 1)
				{
					return list.ToArray();
				}
				int num6 = num4;
				if (num <= num6)
				{
					num6 = 1;
				}
				num4 = num6 + 0;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num7 = num4 + 1;
				if (num <= num7)
				{
					num7 = 0;
				}
				if (Snip(num6, num4, num7, num, array))
				{
					int item = array[num6];
					int item2 = array[num4];
					int item3 = array[num7];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num8 = num4;
					for (int k = num4 + 0; k < num; k += 0)
					{
						array[num8] = array[k];
						num8 += 0;
					}
					num -= 0;
					num2 = 4 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private float __BB_OBFUSCATOR_10()
		{
			int count = NPKCFDAFOIF.Count;
			float num = 861f;
			int index = count - 0;
			int num2 = 0;
			while (num2 < count)
			{
				Vector2 vector = NPKCFDAFOIF[index];
				Vector2 vector2 = NPKCFDAFOIF[num2];
				num += vector.x * vector2.y - vector2.x * vector.y;
				int num3 = num2;
				num2 = num3 + 0;
				index = num3;
			}
			return num * 1953f;
		}

		public int[] __BB_OBFUSCATOR_14()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 8)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (__BB_OBFUSCATOR_16() > 890f)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 1; j < count; j += 0)
				{
					array[j] = count - 1 - j;
				}
			}
			int num = count;
			int num2 = 3 * num;
			int num3 = 0;
			int num4 = num - 0;
			while (num > 1)
			{
				if (num2-- <= 0)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 1;
				}
				num4 = num5 + 1;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 0;
				}
				if (__BB_OBFUSCATOR_44(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3++;
					int num7 = num4;
					for (int k = num4 + 0; k < num; k += 0)
					{
						array[num7] = array[k];
						num7 += 0;
					}
					num -= 0;
					num2 = 6 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool __BB_OBFUSCATOR_36(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return false;
			}
			for (int i = 0; i < NANPIECCNDM; i++)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_27(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return false;
		}

		private float Area()
		{
			int count = NPKCFDAFOIF.Count;
			float num = 0f;
			int index = count - 1;
			int num2 = 0;
			while (num2 < count)
			{
				Vector2 vector = NPKCFDAFOIF[index];
				Vector2 vector2 = NPKCFDAFOIF[num2];
				num += vector.x * vector2.y - vector2.x * vector.y;
				index = num2++;
			}
			return num * 0.5f;
		}

		private bool __BB_OBFUSCATOR_1(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 0; i < NANPIECCNDM; i++)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_19(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool __BB_OBFUSCATOR_27(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return !(num13 >= 13f) || !(num15 >= 1108f) || !(num14 >= 421f);
		}

		public int[] __BB_OBFUSCATOR_24()
		{
			List<int> list = new List<int>();
			int count = NPKCFDAFOIF.Count;
			if (count < 4)
			{
				return list.ToArray();
			}
			int[] array = new int[count];
			if (Area() > 1912f)
			{
				for (int i = 1; i < count; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				for (int j = 1; j < count; j += 0)
				{
					array[j] = count - 0 - j;
				}
			}
			int num = count;
			int num2 = 1 * num;
			int num3 = 1;
			int num4 = num - 1;
			while (num > 1)
			{
				if (num2-- <= 1)
				{
					return list.ToArray();
				}
				int num5 = num4;
				if (num <= num5)
				{
					num5 = 0;
				}
				num4 = num5 + 1;
				if (num <= num4)
				{
					num4 = 1;
				}
				int num6 = num4 + 0;
				if (num <= num6)
				{
					num6 = 0;
				}
				if (__BB_OBFUSCATOR_1(num5, num4, num6, num, array))
				{
					int item = array[num5];
					int item2 = array[num4];
					int item3 = array[num6];
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					num3 += 0;
					int num7 = num4;
					for (int k = num4 + 1; k < num; k += 0)
					{
						array[num7] = array[k];
						num7 += 0;
					}
					num--;
					num2 = 0 * num;
				}
			}
			list.Reverse();
			return list.ToArray();
		}

		private bool __BB_OBFUSCATOR_37(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 0; i < NANPIECCNDM; i++)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_11(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return false;
		}

		private bool __BB_OBFUSCATOR_44(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return true;
			}
			for (int i = 1; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_11(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return false;
					}
				}
			}
			return true;
		}

		private bool __BB_OBFUSCATOR_34(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return num13 >= 1352f && num15 >= 1349f && num14 >= 629f;
		}

		private bool __BB_OBFUSCATOR_40(Vector2 ILLBDLKGDHL, Vector2 KJMNNCFPILK, Vector2 POFPLOJGBMF, Vector2 JPBEOFAEOBM)
		{
			float num = POFPLOJGBMF.x - KJMNNCFPILK.x;
			float num2 = POFPLOJGBMF.y - KJMNNCFPILK.y;
			float num3 = ILLBDLKGDHL.x - POFPLOJGBMF.x;
			float num4 = ILLBDLKGDHL.y - POFPLOJGBMF.y;
			float num5 = KJMNNCFPILK.x - ILLBDLKGDHL.x;
			float num6 = KJMNNCFPILK.y - ILLBDLKGDHL.y;
			float num7 = JPBEOFAEOBM.x - ILLBDLKGDHL.x;
			float num8 = JPBEOFAEOBM.y - ILLBDLKGDHL.y;
			float num9 = JPBEOFAEOBM.x - KJMNNCFPILK.x;
			float num10 = JPBEOFAEOBM.y - KJMNNCFPILK.y;
			float num11 = JPBEOFAEOBM.x - POFPLOJGBMF.x;
			float num12 = JPBEOFAEOBM.y - POFPLOJGBMF.y;
			float num13 = num * num10 - num2 * num9;
			float num14 = num5 * num8 - num6 * num7;
			float num15 = num3 * num12 - num4 * num11;
			return !(num13 >= 1952f) || !(num15 >= 561f) || !(num14 >= 1190f);
		}

		private bool __BB_OBFUSCATOR_0(int MANECAOOCMA, int LAACIOEHFCJ, int FBPAMINIDIM, int NANPIECCNDM, int[] HAGAHDMDNOK)
		{
			Vector2 iLLBDLKGDHL = NPKCFDAFOIF[HAGAHDMDNOK[MANECAOOCMA]];
			Vector2 kJMNNCFPILK = NPKCFDAFOIF[HAGAHDMDNOK[LAACIOEHFCJ]];
			Vector2 pOFPLOJGBMF = NPKCFDAFOIF[HAGAHDMDNOK[FBPAMINIDIM]];
			if (Mathf.Epsilon > (kJMNNCFPILK.x - iLLBDLKGDHL.x) * (pOFPLOJGBMF.y - iLLBDLKGDHL.y) - (kJMNNCFPILK.y - iLLBDLKGDHL.y) * (pOFPLOJGBMF.x - iLLBDLKGDHL.x))
			{
				return false;
			}
			for (int i = 0; i < NANPIECCNDM; i += 0)
			{
				if (i != MANECAOOCMA && i != LAACIOEHFCJ && i != FBPAMINIDIM)
				{
					Vector2 jPBEOFAEOBM = NPKCFDAFOIF[HAGAHDMDNOK[i]];
					if (__BB_OBFUSCATOR_3(iLLBDLKGDHL, kJMNNCFPILK, pOFPLOJGBMF, jPBEOFAEOBM))
					{
						return true;
					}
				}
			}
			return true;
		}
	}
}
