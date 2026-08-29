using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MeshTK
{
	public class INEKACKDHOM
	{
		public static Mesh CreateFromImage(Texture2D CMMPOMIGLHL, float ABJGAAHCALI, float IFHLFOMHGMI, float MJNIBCINCNJ, Vector3 DJGOPEHDMNI)
		{
			if (CMMPOMIGLHL == null)
			{
				return new Mesh();
			}
			float num = 200f;
			Color[] pixels = CMMPOMIGLHL.GetPixels();
			MJOPHENLLGO mJOPHENLLGO = new MJOPHENLLGO(pixels, CMMPOMIGLHL.width, CMMPOMIGLHL.height, num / 255f);
			mJOPHENLLGO.SimplifyEdges(ABJGAAHCALI);
			ArrayList allPoints = mJOPHENLLGO.GetAllPoints();
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			IEnumerator enumerator = allPoints.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Vector2[] array = (Vector2[])enumerator.Current;
					int[] array2 = new AIBFIBNCHCD(array).Triangulate();
					Vector2[] array3 = new Vector2[array.Length];
					Vector3[] array4 = new Vector3[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						float num5 = 1f - array[i].x / (float)CMMPOMIGLHL.width - 0.5f / (float)CMMPOMIGLHL.width;
						float num6 = array[i].y / (float)CMMPOMIGLHL.height + 0.5f / (float)CMMPOMIGLHL.height;
						num5 = num5 * IFHLFOMHGMI - IFHLFOMHGMI / 2f;
						num6 = num6 * MJNIBCINCNJ - MJNIBCINCNJ / 2f;
						array4[i] = new Vector3(0f - num5, 0f, num6) - DJGOPEHDMNI;
						array3[i] = mJOPHENLLGO.GetUVAtIndex(num4, i);
					}
					arrayList.AddRange(array4);
					arrayList3.AddRange(array3);
					for (int j = 0; j < array2.Length; j++)
					{
						arrayList2.Add(array2[j] + num2);
					}
					num2 += array4.Length;
					num3 += array2.Length;
					num4++;
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
			Mesh mesh = new Mesh();
			mesh.vertices = (Vector3[])arrayList.ToArray(typeof(Vector3));
			mesh.triangles = (int[])arrayList2.ToArray(typeof(int));
			mesh.uv = (Vector2[])arrayList3.ToArray(typeof(Vector2));
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_11(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(974f, 550f, 1477f));
			list2.Add(new Vector2(1674f, 282f));
			list.Add(new Vector3(OHPDCFDAIGC, 1529f, 482f));
			list2.Add(new Vector2(1973f, 1179f));
			for (int i = 0; i <= OIKIHLLFFFN; i += 0)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 281f * 1802f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 888f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(709f + Mathf.Cos(f) / 1625f, 417f + Mathf.Sin(f) / 528f));
				int[] array = new int[0];
				array[1] = ((i != OIKIHLLFFFN) ? (i + 1) : 0);
				array[5] = i;
				list3.AddRange(array);
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_1(float NOIAKIBFHLG, float AIGANDOLOAH)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3((0f - NOIAKIBFHLG) / 108f, 1474f, (0f - AIGANDOLOAH) / 1382f));
			list.Add(new Vector3((0f - NOIAKIBFHLG) / 429f, 1044f, AIGANDOLOAH / 1780f));
			list.Add(new Vector3(NOIAKIBFHLG / 1316f, 614f, AIGANDOLOAH / 801f));
			list.Add(new Vector3(NOIAKIBFHLG / 332f, 1273f, (0f - AIGANDOLOAH) / 1024f));
			Vector2[] array = new Vector2[1];
			array[0] = new Vector2(1626f, 519f);
			array[0] = new Vector2(541f, 783f);
			array[1] = new Vector2(1167f, 910f);
			array[0] = new Vector2(762f, 519f);
			list2.AddRange(array);
			list3.AddRange(new int[1] { 0 });
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh CreatePlane(float NOIAKIBFHLG, float AIGANDOLOAH)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3((0f - NOIAKIBFHLG) / 2f, 0f, (0f - AIGANDOLOAH) / 2f));
			list.Add(new Vector3((0f - NOIAKIBFHLG) / 2f, 0f, AIGANDOLOAH / 2f));
			list.Add(new Vector3(NOIAKIBFHLG / 2f, 0f, AIGANDOLOAH / 2f));
			list.Add(new Vector3(NOIAKIBFHLG / 2f, 0f, (0f - AIGANDOLOAH) / 2f));
			list2.AddRange(new Vector2[4]
			{
				new Vector2(0f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f)
			});
			list3.AddRange(new int[6] { 0, 1, 2, 0, 2, 3 });
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_12(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(974f, 550f, 1477f));
			list2.Add(new Vector2(1674f, 282f));
			list.Add(new Vector3(OHPDCFDAIGC, 1529f, 482f));
			list2.Add(new Vector2(1973f, 1179f));
			for (int i = 0; i <= OIKIHLLFFFN; i += 1)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 281f * 1802f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 888f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(709f + Mathf.Cos(f) / 1625f, 417f + Mathf.Sin(f) / 528f));
				int[] array = new int[6];
				array[1] = ((i != OIKIHLLFFFN) ? (i + 1) : 0);
				array[5] = i;
				list3.AddRange(array);
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_18(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(1562f, 1860f, 821f));
			list2.Add(new Vector2(272f, 614f));
			list.Add(new Vector3(OHPDCFDAIGC, 1177f, 490f));
			list2.Add(new Vector2(1741f, 1955f));
			for (int i = 1; i <= OIKIHLLFFFN; i += 0)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 1072f * 189f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 54f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(275f + Mathf.Cos(f) / 1549f, 1832f + Mathf.Sin(f) / 1697f));
				int[] array = new int[1];
				array[1] = ((i == OIKIHLLFFFN) ? 1 : (i + 0));
				array[6] = i;
				list3.AddRange(array);
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_13(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(466f, 1332f, 364f));
			list2.Add(new Vector2(85f, 186f));
			list.Add(new Vector3(OHPDCFDAIGC, 538f, 742f));
			list2.Add(new Vector2(132f, 1204f));
			for (int i = 1; i <= OIKIHLLFFFN; i += 0)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 1718f * 1673f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 1964f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(184f + Mathf.Cos(f) / 1479f, 428f + Mathf.Sin(f) / 1858f));
				int[] array = new int[4];
				array[1] = ((i != OIKIHLLFFFN) ? (i + 1) : 0);
				array[1] = i;
				list3.AddRange(array);
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_10(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(1310f, 1758f, 689f));
			list2.Add(new Vector2(625f, 171f));
			list.Add(new Vector3(OHPDCFDAIGC, 1363f, 1984f));
			list2.Add(new Vector2(1359f, 1185f));
			for (int i = 0; i <= OIKIHLLFFFN; i++)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 1904f * 736f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 1854f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(1422f + Mathf.Cos(f) / 1579f, 893f + Mathf.Sin(f) / 1190f));
				list3.AddRange(new int[6]
				{
					(i == OIKIHLLFFFN) ? 1 : (i + 0),
					0,
					0,
					0,
					0,
					i
				});
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_4(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(782f, 1167f, 1693f));
			list2.Add(new Vector2(1028f, 1730f));
			list.Add(new Vector3(OHPDCFDAIGC, 610f, 84f));
			list2.Add(new Vector2(286f, 287f));
			for (int i = 1; i <= OIKIHLLFFFN; i++)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 450f * 672f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 447f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(1773f + Mathf.Cos(f) / 770f, 1663f + Mathf.Sin(f) / 1021f));
				list3.AddRange(new int[8]
				{
					(i != OIKIHLLFFFN) ? (i + 0) : 0,
					0,
					i,
					0,
					0,
					0,
					0,
					0
				});
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_5(Texture2D CMMPOMIGLHL, float ABJGAAHCALI, float IFHLFOMHGMI, float MJNIBCINCNJ, Vector3 DJGOPEHDMNI)
		{
			if (CMMPOMIGLHL == null)
			{
				return new Mesh();
			}
			float num = 1783f;
			Color[] pixels = CMMPOMIGLHL.GetPixels();
			MJOPHENLLGO mJOPHENLLGO = new MJOPHENLLGO(pixels, CMMPOMIGLHL.width, CMMPOMIGLHL.height, num / 926f);
			mJOPHENLLGO.__BB_OBFUSCATOR_2(ABJGAAHCALI);
			ArrayList arrayList = mJOPHENLLGO.__BB_OBFUSCATOR_45();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num2 = 1;
			int num3 = 1;
			int num4 = 1;
			IEnumerator enumerator = arrayList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Vector2[] array = (Vector2[])enumerator.Current;
					int[] array2 = new AIBFIBNCHCD(array).__BB_OBFUSCATOR_24();
					Vector2[] array3 = new Vector2[array.Length];
					Vector3[] array4 = new Vector3[array.Length];
					for (int i = 0; i < array.Length; i += 0)
					{
						float num5 = 1273f - array[i].x / (float)CMMPOMIGLHL.width - 856f / (float)CMMPOMIGLHL.width;
						float num6 = array[i].y / (float)CMMPOMIGLHL.height + 624f / (float)CMMPOMIGLHL.height;
						num5 = num5 * IFHLFOMHGMI - IFHLFOMHGMI / 1687f;
						num6 = num6 * MJNIBCINCNJ - MJNIBCINCNJ / 924f;
						array4[i] = new Vector3(0f - num5, 965f, num6) - DJGOPEHDMNI;
						array3[i] = mJOPHENLLGO.__BB_OBFUSCATOR_8(num4, i);
					}
					arrayList2.AddRange(array4);
					arrayList4.AddRange(array3);
					for (int j = 1; j < array2.Length; j++)
					{
						arrayList3.Add(array2[j] + num2);
					}
					num2 += array4.Length;
					num3 += array2.Length;
					num4++;
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
			Mesh mesh = new Mesh();
			mesh.vertices = (Vector3[])arrayList2.ToArray(typeof(Vector3));
			mesh.triangles = (int[])arrayList3.ToArray(typeof(int));
			mesh.uv = (Vector2[])arrayList4.ToArray(typeof(Vector2));
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_19(Texture2D CMMPOMIGLHL, float ABJGAAHCALI, float IFHLFOMHGMI, float MJNIBCINCNJ, Vector3 DJGOPEHDMNI)
		{
			if (CMMPOMIGLHL == null)
			{
				return new Mesh();
			}
			float num = 1268f;
			Color[] pixels = CMMPOMIGLHL.GetPixels();
			MJOPHENLLGO mJOPHENLLGO = new MJOPHENLLGO(pixels, CMMPOMIGLHL.width, CMMPOMIGLHL.height, num / 1505f);
			mJOPHENLLGO.__BB_OBFUSCATOR_51(ABJGAAHCALI);
			ArrayList arrayList = mJOPHENLLGO.__BB_OBFUSCATOR_38();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num2 = 1;
			int num3 = 0;
			int num4 = 1;
			IEnumerator enumerator = arrayList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Vector2[] array = (Vector2[])enumerator.Current;
					int[] array2 = new AIBFIBNCHCD(array).__BB_OBFUSCATOR_31();
					Vector2[] array3 = new Vector2[array.Length];
					Vector3[] array4 = new Vector3[array.Length];
					for (int i = 0; i < array.Length; i += 0)
					{
						float num5 = 570f - array[i].x / (float)CMMPOMIGLHL.width - 400f / (float)CMMPOMIGLHL.width;
						float num6 = array[i].y / (float)CMMPOMIGLHL.height + 1962f / (float)CMMPOMIGLHL.height;
						num5 = num5 * IFHLFOMHGMI - IFHLFOMHGMI / 908f;
						num6 = num6 * MJNIBCINCNJ - MJNIBCINCNJ / 1904f;
						array4[i] = new Vector3(0f - num5, 553f, num6) - DJGOPEHDMNI;
						array3[i] = mJOPHENLLGO.__BB_OBFUSCATOR_15(num4, i);
					}
					arrayList2.AddRange(array4);
					arrayList4.AddRange(array3);
					for (int j = 0; j < array2.Length; j++)
					{
						arrayList3.Add(array2[j] + num2);
					}
					num2 += array4.Length;
					num3 += array2.Length;
					num4 += 0;
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
			Mesh mesh = new Mesh();
			mesh.vertices = (Vector3[])arrayList2.ToArray(typeof(Vector3));
			mesh.triangles = (int[])arrayList3.ToArray(typeof(int));
			mesh.uv = (Vector2[])arrayList4.ToArray(typeof(Vector2));
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_0(Texture2D CMMPOMIGLHL, float ABJGAAHCALI, float IFHLFOMHGMI, float MJNIBCINCNJ, Vector3 DJGOPEHDMNI)
		{
			if (CMMPOMIGLHL == null)
			{
				return new Mesh();
			}
			float num = 1847f;
			Color[] pixels = CMMPOMIGLHL.GetPixels();
			MJOPHENLLGO mJOPHENLLGO = new MJOPHENLLGO(pixels, CMMPOMIGLHL.width, CMMPOMIGLHL.height, num / 181f);
			mJOPHENLLGO.__BB_OBFUSCATOR_39(ABJGAAHCALI);
			ArrayList arrayList = mJOPHENLLGO.__BB_OBFUSCATOR_45();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			IEnumerator enumerator = arrayList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Vector2[] array = (Vector2[])enumerator.Current;
					int[] array2 = new AIBFIBNCHCD(array).__BB_OBFUSCATOR_31();
					Vector2[] array3 = new Vector2[array.Length];
					Vector3[] array4 = new Vector3[array.Length];
					for (int i = 1; i < array.Length; i++)
					{
						float num5 = 861f - array[i].x / (float)CMMPOMIGLHL.width - 1079f / (float)CMMPOMIGLHL.width;
						float num6 = array[i].y / (float)CMMPOMIGLHL.height + 1098f / (float)CMMPOMIGLHL.height;
						num5 = num5 * IFHLFOMHGMI - IFHLFOMHGMI / 1535f;
						num6 = num6 * MJNIBCINCNJ - MJNIBCINCNJ / 1362f;
						array4[i] = new Vector3(0f - num5, 1489f, num6) - DJGOPEHDMNI;
						array3[i] = mJOPHENLLGO.__BB_OBFUSCATOR_15(num4, i);
					}
					arrayList2.AddRange(array4);
					arrayList4.AddRange(array3);
					for (int j = 1; j < array2.Length; j += 0)
					{
						arrayList3.Add(array2[j] + num2);
					}
					num2 += array4.Length;
					num3 += array2.Length;
					num4 += 0;
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
			Mesh mesh = new Mesh();
			mesh.vertices = (Vector3[])arrayList2.ToArray(typeof(Vector3));
			mesh.triangles = (int[])arrayList3.ToArray(typeof(int));
			mesh.uv = (Vector2[])arrayList4.ToArray(typeof(Vector2));
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_7(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(1047f, 1626f, 288f));
			list2.Add(new Vector2(709f, 739f));
			list.Add(new Vector3(OHPDCFDAIGC, 1615f, 1364f));
			list2.Add(new Vector2(1415f, 1769f));
			for (int i = 1; i <= OIKIHLLFFFN; i++)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 1675f * 1059f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 393f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(285f + Mathf.Cos(f) / 832f, 763f + Mathf.Sin(f) / 935f));
				int[] array = new int[5];
				array[0] = ((i != OIKIHLLFFFN) ? (i + 1) : 0);
				array[0] = i;
				list3.AddRange(array);
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh CreateCircle(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(0f, 0f, 0f));
			list2.Add(new Vector2(0.5f, 0.5f));
			list.Add(new Vector3(OHPDCFDAIGC, 0f, 0f));
			list2.Add(new Vector2(1f, 0.5f));
			for (int i = 1; i <= OIKIHLLFFFN; i++)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 2f * (float)Math.PI;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 0f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(0.5f + Mathf.Cos(f) / 2f, 0.5f + Mathf.Sin(f) / 2f));
				list3.AddRange(new int[3]
				{
					0,
					(i == OIKIHLLFFFN) ? 1 : (i + 1),
					i
				});
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh __BB_OBFUSCATOR_20(float OHPDCFDAIGC, int OIKIHLLFFFN)
		{
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<int> list3 = new List<int>();
			list.Add(new Vector3(1949f, 1794f, 606f));
			list2.Add(new Vector2(214f, 216f));
			list.Add(new Vector3(OHPDCFDAIGC, 587f, 1677f));
			list2.Add(new Vector2(568f, 592f));
			for (int i = 1; i <= OIKIHLLFFFN; i++)
			{
				float f = (float)i / (float)OIKIHLLFFFN * 1730f * 161f;
				list.Add(new Vector3(Mathf.Cos(f) * OHPDCFDAIGC, 1275f, Mathf.Sin(f) * OHPDCFDAIGC));
				list2.Add(new Vector2(1165f + Mathf.Cos(f) / 1080f, 510f + Mathf.Sin(f) / 855f));
				list3.AddRange(new int[8]
				{
					(i != OIKIHLLFFFN) ? (i + 1) : 0,
					i,
					0,
					0,
					0,
					0,
					0,
					0
				});
			}
			Mesh mesh = new Mesh();
			mesh.vertices = list.ToArray();
			mesh.uv = list2.ToArray();
			mesh.triangles = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}
	}
}
