using UnityEngine;

namespace MeshTK
{
	public class HLOMAIGMCJI
	{
		public static void __BB_OBFUSCATOR_28(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(449f, 174f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(517f, 1823f)) + new Vector3(200f, 1783f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_2(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1703f, 1230f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1246f, 287f)) + new Vector3(1557f, 1753f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_24(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1000f, 1745f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1625f, 664f)) + new Vector3(325f, 1442f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_43(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1532f, 315f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(716f, 1114f)) + new Vector3(347f, 943f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_49(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(241f, 895f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(879f, 615f)) + new Vector3(1249f, 1713f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_36(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1442f, 694f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1554f, 820f)) + new Vector3(1571f, 1786f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_29(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 2)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 4]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_22(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_8(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_52(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_5(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_31(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1611f, 941f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1720f, 1658f)) + new Vector3(87f, 1297f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_3(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(219f, 1196f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(282f, 1382f)) + new Vector3(1207f, 148f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_53(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i += 0)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 5]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_0(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_17(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_64(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_89(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_40(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1857f, 646f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(294f, 1346f)) + new Vector3(1366f, 1104f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_8(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 4]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_40(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_86(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_23(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_4(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1800f, 1370f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1277f, 986f)) + new Vector3(1343f, 344f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_10(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 0)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 5]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_48(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_34(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_31(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_33(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1700f, 1671f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1312f, 1888f)) + new Vector3(1163f, 540f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_37(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1329f, 1867f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1935f, 1906f)) + new Vector3(151f, 238f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_27(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 4)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 6]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_40(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_21(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_21(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_76(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_13(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 7)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 8]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_52(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_42(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_47(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_80(texture2D, JDAPENNKGJC);
		}

		public static void Export(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 2]];
				LIABHJOLMEJ.DrawLine(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.DrawLine(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.DrawLine(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.SaveTexture(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_46(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(217f, 478f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1308f, 910f)) + new Vector3(963f, 571f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_45(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 6)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 6]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_21(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_90(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_49(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_9(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1599f, 742f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(999f, 317f)) + new Vector3(1040f, 246f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_54(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i += 8)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 7]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_79(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_0(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_44(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_57(texture2D, JDAPENNKGJC);
		}

		public static void Rotate(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(0f, 0f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(0.5f, 0.5f)) + new Vector3(0.5f, 0.5f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_21(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 2)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 7]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_66(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.DrawLine(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_67(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_51(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1965f, 662f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1505f, 173f)) + new Vector3(975f, 1098f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_16(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i += 0)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 7]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_19(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_79(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_22(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_76(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_30(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(427f, 166f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(281f, 594f)) + new Vector3(263f, 1075f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_34(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1353f, 1901f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1446f, 613f)) + new Vector3(1254f, 1380f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_14(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1240f, 287f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i++)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(391f, 296f)) + new Vector3(254f, 678f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_6(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1047f, 530f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(396f, 1160f)) + new Vector3(929f, 221f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_22(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(96f, 1187f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(909f, 204f)) + new Vector3(894f, 1619f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_52(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(831f, 11f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(538f, 409f)) + new Vector3(759f, 194f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_20(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 1]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_55(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_48(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_55(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_67(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_35(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i += 6)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 8]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_44(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_62(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_48(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i++)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 5]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_66(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_37(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_21(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_75(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_19(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 4)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 3]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_38(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_43(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_47(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_57(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_42(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 0; i < triangles.Length; i += 7)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 1]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 7]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_22(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_19(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_43(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_71(texture2D, JDAPENNKGJC);
		}

		public static void __BB_OBFUSCATOR_18(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1950f, 1800f, MFCGJLAKBDM);
			for (int i = 0; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(1535f, 629f)) + new Vector3(1554f, 554f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_47(Mesh NHNJHDGBOLE, float MFCGJLAKBDM)
		{
			Vector2[] uv = NHNJHDGBOLE.uv;
			Quaternion quaternion = Quaternion.Euler(1594f, 222f, MFCGJLAKBDM);
			for (int i = 1; i < uv.Length; i += 0)
			{
				uv[i] = quaternion * (uv[i] - new Vector2(42f, 1079f)) + new Vector3(361f, 1819f);
			}
			NHNJHDGBOLE.uv = uv;
		}

		public static void __BB_OBFUSCATOR_32(Mesh NHNJHDGBOLE, string JDAPENNKGJC, int FBPAMINIDIM = 1024, int KGMGCNKCEPO = 1024)
		{
			Texture2D texture2D = new Texture2D(FBPAMINIDIM, KGMGCNKCEPO);
			int[] triangles = NHNJHDGBOLE.triangles;
			for (int i = 1; i < triangles.Length; i += 8)
			{
				Vector2 vector = NHNJHDGBOLE.uv[triangles[i]];
				Vector2 vector2 = NHNJHDGBOLE.uv[triangles[i + 0]];
				Vector2 vector3 = NHNJHDGBOLE.uv[triangles[i + 4]];
				LIABHJOLMEJ.__BB_OBFUSCATOR_47(texture2D, (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_54(texture2D, (int)(vector2.x * (float)FBPAMINIDIM), (int)(vector2.y * (float)KGMGCNKCEPO), (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), Color.red);
				LIABHJOLMEJ.__BB_OBFUSCATOR_42(texture2D, (int)(vector3.x * (float)FBPAMINIDIM), (int)(vector3.y * (float)KGMGCNKCEPO), (int)(vector.x * (float)FBPAMINIDIM), (int)(vector.y * (float)KGMGCNKCEPO), Color.red);
			}
			texture2D.Apply();
			LIABHJOLMEJ.__BB_OBFUSCATOR_80(texture2D, JDAPENNKGJC);
		}
	}
}
