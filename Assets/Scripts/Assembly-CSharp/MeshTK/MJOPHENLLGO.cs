using System;
using System.Collections;
using UnityEngine;

namespace MeshTK
{
	internal class MJOPHENLLGO
	{
		private ArrayList OMECLOOFOMO;

		private ArrayList PNKLDFAHCNB;

		private ArrayList ABOINPJFNBM;

		public ArrayList __BB_OBFUSCATOR_4()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_33());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public ArrayList __BB_OBFUSCATOR_45()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_0());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_35(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private void __BB_OBFUSCATOR_21()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 1)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_32())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(0);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 1; i < OMECLOOFOMO.Count; i++)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_52(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j += 0)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_22(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public void __BB_OBFUSCATOR_7(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.ReduceEdge(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_3(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 1; i < PNKLDFAHCNB.Count; i += 0)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public Vector2 __BB_OBFUSCATOR_6(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_47(NEOOCOCLNPO);
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_17(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_44(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 1; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public void __BB_OBFUSCATOR_48(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.__BB_OBFUSCATOR_35(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private void __BB_OBFUSCATOR_31()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
			OMECLOOFOMO.RemoveAt(1);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 1)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_10())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(0);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 1; i < OMECLOOFOMO.Count; i += 0)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_46(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 1; j < arrayList.Count; j += 0)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_36(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 1; i < PNKLDFAHCNB.Count; i += 0)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public void __BB_OBFUSCATOR_2(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.__BB_OBFUSCATOR_35(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public ArrayList __BB_OBFUSCATOR_23()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_0());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public ArrayList __BB_OBFUSCATOR_26()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_38());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public ArrayList __BB_OBFUSCATOR_19()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_45());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private void __BB_OBFUSCATOR_50()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
			OMECLOOFOMO.RemoveAt(1);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 0)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_43())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
					OMECLOOFOMO.RemoveAt(1);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < OMECLOOFOMO.Count; i++)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_46(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_46(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 1; i < PNKLDFAHCNB.Count; i += 0)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private void __BB_OBFUSCATOR_0()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 0)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_37())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(1);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 1; i < OMECLOOFOMO.Count; i++)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_42(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private void __BB_OBFUSCATOR_29()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 0)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_11())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(0);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 1; i < OMECLOOFOMO.Count; i++)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_19(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 1; j < arrayList.Count; j += 0)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		public ArrayList GetAllPoints()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.GetPoints());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public ArrayList __BB_OBFUSCATOR_38()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_33());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_41(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public void __BB_OBFUSCATOR_51(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.__BB_OBFUSCATOR_29(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public MJOPHENLLGO(Color[] PDDMEIDOCIM, int NMPJCBBGEOG, int KJKBGOLAMAP, float HAEOAGJCJHJ)
		{
			OMECLOOFOMO = new ArrayList();
			PNKLDFAHCNB = new ArrayList();
			ABOINPJFNBM = new ArrayList();
			for (int i = 0; i < NMPJCBBGEOG; i++)
			{
				float num = (float)i + 0.5f;
				for (int j = 0; j < KJKBGOLAMAP; j++)
				{
					float num2 = (float)j + 0.5f;
					if (PDDMEIDOCIM[i + NMPJCBBGEOG * j].a < HAEOAGJCJHJ)
					{
						continue;
					}
					float num3 = 0f;
					float num4 = 0f;
					float num5 = 0f;
					float num6 = 0f;
					float num7 = 0f;
					float num8 = 0f;
					float num9 = 0f;
					if (i > 0)
					{
						num6 = PDDMEIDOCIM[i - 1 + NMPJCBBGEOG * j].a;
						if (j < KJKBGOLAMAP - 1)
						{
							num8 = PDDMEIDOCIM[i - 1 + NMPJCBBGEOG * (j + 1)].a;
						}
					}
					if (i < NMPJCBBGEOG - 1)
					{
						if (j > 0)
						{
							num9 = PDDMEIDOCIM[i + 1 + NMPJCBBGEOG * (j - 1)].a;
						}
						num5 = PDDMEIDOCIM[i + 1 + NMPJCBBGEOG * j].a;
						if (j < KJKBGOLAMAP - 1)
						{
							num7 = PDDMEIDOCIM[i + 1 + NMPJCBBGEOG * (j + 1)].a;
						}
					}
					if (j > 0)
					{
						num4 = PDDMEIDOCIM[i + NMPJCBBGEOG * (j - 1)].a;
					}
					if (j < KJKBGOLAMAP - 1)
					{
						num3 = PDDMEIDOCIM[i + NMPJCBBGEOG * (j + 1)].a;
					}
					if (num3 >= HAEOAGJCJHJ)
					{
						if (num7 < HAEOAGJCJHJ && num5 < HAEOAGJCJHJ)
						{
							if (num8 >= HAEOAGJCJHJ || num6 >= HAEOAGJCJHJ)
							{
								MBGOGDDEJMK value = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i, j + 1, num / (float)NMPJCBBGEOG, (num2 + 1f) / (float)KJKBGOLAMAP));
								OMECLOOFOMO.Add(value);
							}
						}
						else if (num8 < HAEOAGJCJHJ && num6 < HAEOAGJCJHJ && (num7 >= HAEOAGJCJHJ || num5 >= HAEOAGJCJHJ))
						{
							MBGOGDDEJMK value2 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i, j + 1, num / (float)NMPJCBBGEOG, (num2 + 1f) / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value2);
						}
					}
					if (num7 >= HAEOAGJCJHJ)
					{
						if (num3 < HAEOAGJCJHJ && num5 >= HAEOAGJCJHJ)
						{
							MBGOGDDEJMK value3 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j + 1, (num + 1f) / (float)NMPJCBBGEOG, (num2 + 1f) / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value3);
						}
						else if (num3 >= HAEOAGJCJHJ && num5 < HAEOAGJCJHJ)
						{
							MBGOGDDEJMK value4 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j + 1, (num + 1f) / (float)NMPJCBBGEOG, (num2 + 1f) / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value4);
						}
					}
					if (num5 >= HAEOAGJCJHJ)
					{
						if (num3 < HAEOAGJCJHJ && num7 < HAEOAGJCJHJ)
						{
							if (num4 >= HAEOAGJCJHJ || num9 >= HAEOAGJCJHJ)
							{
								MBGOGDDEJMK value5 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j, (num + 1f) / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP));
								OMECLOOFOMO.Add(value5);
							}
						}
						else if (num4 < HAEOAGJCJHJ && num9 < HAEOAGJCJHJ && (num3 >= HAEOAGJCJHJ || num7 >= HAEOAGJCJHJ))
						{
							MBGOGDDEJMK value6 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j, (num + 1f) / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value6);
						}
					}
					if (num9 >= HAEOAGJCJHJ)
					{
						if (num5 < HAEOAGJCJHJ && num4 >= HAEOAGJCJHJ)
						{
							MBGOGDDEJMK value7 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j - 1, (num + 1f) / (float)NMPJCBBGEOG, (num2 - 1f) / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value7);
						}
						else if (num5 >= HAEOAGJCJHJ && num4 < HAEOAGJCJHJ)
						{
							MBGOGDDEJMK value8 = new MBGOGDDEJMK(GetPoint(i, j, num / (float)NMPJCBBGEOG, num2 / (float)KJKBGOLAMAP), GetPoint(i + 1, j - 1, (num + 1f) / (float)NMPJCBBGEOG, (num2 - 1f) / (float)KJKBGOLAMAP));
							OMECLOOFOMO.Add(value8);
						}
					}
				}
			}
			CreateFaces();
		}

		public ArrayList __BB_OBFUSCATOR_43()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_12());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public void __BB_OBFUSCATOR_39(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.__BB_OBFUSCATOR_35(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public Vector2 __BB_OBFUSCATOR_32(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_41(NEOOCOCLNPO);
		}

		public ArrayList __BB_OBFUSCATOR_33()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.GetPoints());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public Vector2 __BB_OBFUSCATOR_37(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_50(NEOOCOCLNPO);
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_10(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_5(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 1; i < PNKLDFAHCNB.Count; i += 0)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_20(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		private void CreateFaces()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 0)
			{
				if (jHGCNEBMPDF.IsClosed())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
					OMECLOOFOMO.RemoveAt(0);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < OMECLOOFOMO.Count; i++)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.AddEdge(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private void __BB_OBFUSCATOR_40()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 1)
			{
				if (jHGCNEBMPDF.IsClosed())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(0);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 1; i < OMECLOOFOMO.Count; i += 0)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_48(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		private void __BB_OBFUSCATOR_13()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
			OMECLOOFOMO.RemoveAt(1);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 1)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_15())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[1]);
					OMECLOOFOMO.RemoveAt(1);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < OMECLOOFOMO.Count; i += 0)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.AddEdge(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 0; j < arrayList.Count; j += 0)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}

		public Vector2 __BB_OBFUSCATOR_8(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_50(NEOOCOCLNPO);
		}

		public void __BB_OBFUSCATOR_14(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.__BB_OBFUSCATOR_29(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public void SimplifyEdges(float ABJGAAHCALI = 0.448f)
		{
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					jHGCNEBMPDF.ReduceEdge(ABJGAAHCALI);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		private MNENKKOPDCE __BB_OBFUSCATOR_27(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i += 0)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public Vector2 __BB_OBFUSCATOR_30(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_7(NEOOCOCLNPO);
		}

		private MNENKKOPDCE GetPoint(float FEEBIIBNNIE, float DHHLFIEAIBC, float MANECAOOCMA, float LAACIOEHFCJ)
		{
			for (int i = 0; i < PNKLDFAHCNB.Count; i++)
			{
				MNENKKOPDCE mNENKKOPDCE = (MNENKKOPDCE)PNKLDFAHCNB[i];
				if (mNENKKOPDCE.FEEBIIBNNIE == FEEBIIBNNIE && mNENKKOPDCE.DHHLFIEAIBC == DHHLFIEAIBC)
				{
					return mNENKKOPDCE;
				}
			}
			MNENKKOPDCE mNENKKOPDCE2 = new MNENKKOPDCE(FEEBIIBNNIE, DHHLFIEAIBC, MANECAOOCMA, LAACIOEHFCJ);
			PNKLDFAHCNB.Add(mNENKKOPDCE2);
			return mNENKKOPDCE2;
		}

		public ArrayList __BB_OBFUSCATOR_42()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_0());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public Vector2 __BB_OBFUSCATOR_15(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_18(NEOOCOCLNPO);
		}

		public Vector2 __BB_OBFUSCATOR_49(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_44(NEOOCOCLNPO);
		}

		public Vector2 __BB_OBFUSCATOR_18(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.__BB_OBFUSCATOR_50(NEOOCOCLNPO);
		}

		public ArrayList __BB_OBFUSCATOR_9()
		{
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = ABOINPJFNBM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)enumerator.Current;
					arrayList.Add(jHGCNEBMPDF.__BB_OBFUSCATOR_0());
				}
				return arrayList;
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}

		public Vector2 GetUVAtIndex(int MLGOBAGOHIL, int NEOOCOCLNPO)
		{
			JHGCNEBMPDF jHGCNEBMPDF = (JHGCNEBMPDF)ABOINPJFNBM[MLGOBAGOHIL];
			return jHGCNEBMPDF.GetUVAtIndex(NEOOCOCLNPO);
		}

		private void __BB_OBFUSCATOR_11()
		{
			JHGCNEBMPDF jHGCNEBMPDF = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
			OMECLOOFOMO.RemoveAt(0);
			ABOINPJFNBM.Add(jHGCNEBMPDF);
			while (OMECLOOFOMO.Count > 0)
			{
				if (jHGCNEBMPDF.__BB_OBFUSCATOR_34())
				{
					JHGCNEBMPDF jHGCNEBMPDF2 = new JHGCNEBMPDF((MBGOGDDEJMK)OMECLOOFOMO[0]);
					OMECLOOFOMO.RemoveAt(1);
					ABOINPJFNBM.Add(jHGCNEBMPDF2);
					jHGCNEBMPDF = jHGCNEBMPDF2;
				}
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < OMECLOOFOMO.Count; i += 0)
				{
					MBGOGDDEJMK mBGOGDDEJMK = (MBGOGDDEJMK)OMECLOOFOMO[i];
					if (jHGCNEBMPDF.__BB_OBFUSCATOR_2(mBGOGDDEJMK))
					{
						arrayList.Add(mBGOGDDEJMK);
					}
				}
				for (int j = 1; j < arrayList.Count; j++)
				{
					OMECLOOFOMO.Remove((MBGOGDDEJMK)arrayList[j]);
				}
			}
		}
	}
}
