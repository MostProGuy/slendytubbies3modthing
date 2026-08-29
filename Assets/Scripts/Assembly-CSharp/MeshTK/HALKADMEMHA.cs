using System.IO;
using System.Text;
using UnityEngine;

namespace MeshTK
{
	public class HALKADMEMHA
	{
		public static void __BB_OBFUSCATOR_28(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_44(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static void __BB_OBFUSCATOR_9(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_0(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static void __BB_OBFUSCATOR_6(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_33(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static string __BB_OBFUSCATOR_19(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("\n").Append("_ScreenResolution").Append("_BorderColor");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("Team2Score", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("SUR");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("ForceDamage", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("n4");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("CameraFilterPack/Drawing_Manga3", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append(")</color></size>");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append(",").Append(sharedMaterials[l].name).Append("_Value3");
				}
				stringBuilder.Append("><color=grey>").Append(sharedMaterials[l].name).Append("<size=");
				stringBuilder.Append("_Value4").Append(sharedMaterials[l].name).Append(" ☠☠☠");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 2)
				{
					stringBuilder.Append(string.Format("_TimeX", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 1, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 7] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_16(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("_TimeX").Append(",").Append("_Parameter");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("CameraFilterPack/Vision_Crystal", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("colorD");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("TeamName", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_MainTex2");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("_ColorRGB", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("_Value2");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_TimeX").Append(sharedMaterials[l].name).Append("_Value2");
				}
				stringBuilder.Append("</color>").Append(sharedMaterials[l].name).Append("Wood");
				stringBuilder.Append("_TopMainTex").Append(sharedMaterials[l].name).Append("_Tint");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 3)
				{
					stringBuilder.Append(string.Format("CameraFilterPack/Edge_BlackLine", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 0] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_26(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("team2").Append("n4").Append("_TimeX");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i += 0)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("\\Google", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append(">");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("There is already a virtual axis named ", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("CameraFilterPack/Color_YUV");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("While selected STW-25 press G for flashlight", vector3.x, vector3.y));
			}
			for (int l = 1; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("_Value2");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append(": ").Append(sharedMaterials[l].name).Append("PrimaryCausticsProjector");
				}
				stringBuilder.Append("Ammo/Text").Append(sharedMaterials[l].name).Append("_ScreenResolution");
				stringBuilder.Append("_Blue").Append(sharedMaterials[l].name).Append("MP");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 7)
				{
					stringBuilder.Append(string.Format("Weapon", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 1, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 0, triangles[m + 2] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_43(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_23(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static string __BB_OBFUSCATOR_21(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Mouse Y").Append("<size=15><color=red>").Append("\n\n;Version 5 settings\n;------------------------------------------------------------------\n\n");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("8", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("NPCDeath");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_Val2", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append(",");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("Null", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("PlayerType'");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_RotationMatrix").Append(sharedMaterials[l].name).Append("CustomSkin");
				}
				stringBuilder.Append("_Value").Append(sharedMaterials[l].name).Append("Prev");
				stringBuilder.Append("_TimeX").Append(sharedMaterials[l].name).Append("OnRenderImage in Helper called ...");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 7)
				{
					stringBuilder.Append(string.Format("team2", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 8] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_29(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("/kick ").Append("PublishMessage parameters must be non-null and not empty.").Append("\n}\n");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i += 0)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("CameraFilterPack/Blend2Camera_Subtract", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("</size>");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_Distortion", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_MainTex2");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("HatID", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("_Value2");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("Right").Append(sharedMaterials[l].name).Append(": ");
				}
				stringBuilder.Append("_Bullet_9").Append(sharedMaterials[l].name).Append("<");
				stringBuilder.Append("_Value").Append(sharedMaterials[l].name).Append("Move Down");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 5)
				{
					stringBuilder.Append(string.Format("_Value4", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 0, triangles[m + 5] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_23(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraFilterPack/TV_Noise").Append("team2").Append("_ScreenResolution");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("<size=", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("CameraFilterPack/Blend2Camera_Lighten");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_Value4", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("(Easy)");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("Menu", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append(" {\n");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("[MazeCell {0} {1}]").Append(sharedMaterials[l].name).Append("_InvRenderTargetSize");
				}
				stringBuilder.Append("_TimeX").Append(sharedMaterials[l].name).Append(",");
				stringBuilder.Append("6").Append(sharedMaterials[l].name).Append("ScreenResolution = ");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 3)
				{
					stringBuilder.Append(string.Format("Authentication request error: ", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 1, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 3] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_14(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_13(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static string __BB_OBFUSCATOR_2(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<size=15>").Append("_TimeX").Append("TeamTag");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("CameraFilterPack/Retro_Loading", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("CameraFilterPack/Atmosphere_Snow_8bits");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_Gain", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_ScreenResolution");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("</size>", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("CameraFilterPack/Distortion_Water_Drop");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append(": ").Append(sharedMaterials[l].name).Append("Left Stick Right");
				}
				stringBuilder.Append("Crouch").Append(sharedMaterials[l].name).Append("Prone");
				stringBuilder.Append("\"OO\", \"Model::").Append(sharedMaterials[l].name).Append("MP");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 6)
				{
					stringBuilder.Append(string.Format("Missing shader in ", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 6] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_20(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_26(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string __BB_OBFUSCATOR_44(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("_TimeX").Append(":").Append("\n\t\tLayerElementNormal: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tNormals: ");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("Vertical", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("5");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("MapName", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_Green_C");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("custard", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("_SceneFogParams");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_ColorRGB").Append(sharedMaterials[l].name).Append("SyncTeamName");
				}
				stringBuilder.Append("_Value2").Append(sharedMaterials[l].name).Append("Win");
				stringBuilder.Append("Subscribe called while not connected to front end server.").Append(sharedMaterials[l].name).Append("ns.exitgames.com");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m++)
				{
					stringBuilder.Append(string.Format("-Times Played: ", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 0, triangles[m + 1] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_36(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(ExportToString(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static void __BB_OBFUSCATOR_8(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_38(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string __BB_OBFUSCATOR_33(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(" on effect ").Append("INF").Append("Horizontal");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("_TimeX", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("\tModel: \"Model::");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("offsets", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("Username");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("_Distortion", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("_Blue_B");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_ScreenResolution").Append(sharedMaterials[l].name).Append("There is already a virtual button named ");
				}
				stringBuilder.Append("Ban").Append(sharedMaterials[l].name).Append("ReferenceResolution = ");
				stringBuilder.Append("syncKnife").Append(sharedMaterials[l].name).Append("_Value");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 7)
				{
					stringBuilder.Append(string.Format("AddFriends can't be called for empty or null list.", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 0, triangles[m + 1] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_38(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraFilterPack/Drawing_Toon").Append("_TimeX").Append("INF");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i += 0)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("Team1Score", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("Forward");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("Custard", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_Exponent");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("CameraFilterPack/Distortion_Flag", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("<");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append(",").Append(sharedMaterials[l].name).Append("WARNING: 'MeshTK.ExportTools.MeshToObjString()' is obsolete. Use MeshTK.ObjTools.ExportToString().");
				}
				stringBuilder.Append("_TimeX").Append(sharedMaterials[l].name).Append("0");
				stringBuilder.Append(": ").Append(sharedMaterials[l].name).Append("monster");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 4)
				{
					stringBuilder.Append(string.Format("4", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 1, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 0, triangles[m + 4] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_37(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_33(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string __BB_OBFUSCATOR_24(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("offsets").Append("SBX").Append("_Value3");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("SwearFilter", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("_ScreenResolution");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("Deaths", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_Value4");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("Crouch", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("\", \"Model::Scene\"");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("CameraFilterPack/FX_Hexagon").Append(sharedMaterials[l].name).Append("1");
				}
				stringBuilder.Append("n15").Append(sharedMaterials[l].name).Append("CameraFilterPack/FX_Hexagon");
				stringBuilder.Append("Ping").Append(sharedMaterials[l].name).Append("GiveCurrency");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 6)
				{
					stringBuilder.Append(string.Format("ZWName'", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 1, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 1, triangles[m + 7] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static void ExportToFile(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(ExportToString(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string __BB_OBFUSCATOR_46(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("_ScreenResolution").Append("AddedCube").Append(">");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("*", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("Toast");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("SecondaryCausticsProjector");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("GameMode", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("_Offsets");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_Red_C").Append(sharedMaterials[l].name).Append("_Value");
				}
				stringBuilder.Append("_Value2").Append(sharedMaterials[l].name).Append("TDM");
				stringBuilder.Append("spawn").Append(sharedMaterials[l].name).Append("_Offsets");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 6)
				{
					stringBuilder.Append(string.Format("_MainTex2", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 1, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 0, triangles[m + 3] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_35(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_21(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static string __BB_OBFUSCATOR_13(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("box").Append("_TimeX").Append("_NormalTex");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("6", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("TeamTag");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("SBX", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_Value2");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("SyncShopID", vector3.x, vector3.y));
			}
			for (int l = 1; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("TeamBSpawn");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("Reset").Append(sharedMaterials[l].name).Append("|");
				}
				stringBuilder.Append("CameraFilterPack/Blend2Camera_SoftLight").Append(sharedMaterials[l].name).Append("_ScreenResolution");
				stringBuilder.Append("v0.0.1").Append(sharedMaterials[l].name).Append("_Radius");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 3)
				{
					stringBuilder.Append(string.Format("_ColorBuffer", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 1, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 6] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_39(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_16(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static void __BB_OBFUSCATOR_45(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_33(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string ExportToString(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("o ").Append("Plane").Append("\n");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("v {0:0.000000} {1:0.000000} {2:0.000000}\n", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("\n");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("vn {0:0.000000} {1:0.000000} {2:0.000000}\n", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("\n");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("vt {0:0.000000} {1:0.000000}\n", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("\n");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("g ").Append(sharedMaterials[l].name).Append("\n");
				}
				stringBuilder.Append("usemtl ").Append(sharedMaterials[l].name).Append("\n");
				stringBuilder.Append("usemap ").Append(sharedMaterials[l].name).Append("\n");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 3)
				{
					stringBuilder.Append(string.Format("f {0}/{0}/{0} {1}/{1}/{1} {2}/{2}/{2}\n", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 1, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 2] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_40(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_46(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static void __BB_OBFUSCATOR_3(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_0(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}

		public static string __BB_OBFUSCATOR_18(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraFilterPack/Blend2Camera_PinLight").Append("Light").Append("\n\t}\n");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("\n\t\tLayerElementMaterial: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tMaterials: ", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("TeamASpawn");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("Switch", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("offsets");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("/", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("Mouse X");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("\t\tYear: {0:yyyy}\n\t\tMonth: {0:MM}\n\t\tDay: {0:dd}\n\t\tHour: {0:HH}\n\t\tMinute: {0:mm}\n\t\tSecond: {0:ss}\n\t\tMillisecond: {0:fff}\n").Append(sharedMaterials[l].name).Append(" Simplified");
				}
				stringBuilder.Append("The chatPeer is null.").Append(sharedMaterials[l].name).Append("_Distortion");
				stringBuilder.Append("CameraFilterPack/Blend2Camera_LinearLight").Append(sharedMaterials[l].name).Append("_Value4");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 8)
				{
					stringBuilder.Append(string.Format("_MainTex", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 0, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 0, triangles[m + 6] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_5(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_16(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM, false));
			}
		}

		public static string __BB_OBFUSCATOR_1(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Horizontal").Append("TeamName").Append("Full Ammo    ");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("_TimeX", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("</size>");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("3", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("<size=");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("_Value4", vector3.x, vector3.y));
			}
			for (int l = 1; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("CameraFilterPack/Vision_Crystal");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("\", \"Model::").Append(sharedMaterials[l].name).Append("_ScreenResolution");
				}
				stringBuilder.Append("TeamName").Append(sharedMaterials[l].name).Append("_UV_Transform");
				stringBuilder.Append("Hue/Knob").Append(sharedMaterials[l].name).Append("Mirror ");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 5)
				{
					stringBuilder.Append(string.Format("</size>", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 1, triangles[(!DFBJADBJCFM) ? (m + 1) : m] + 1, triangles[m + 6] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_7(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Walk").Append("n6").Append("CameraFilterPack/Blend2Camera_Hue");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format(", ", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("CameraFilterPack/Distortion_Flag");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 0; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("TDM", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_TimeX");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("_Value2", vector3.x, vector3.y));
			}
			for (int l = 0; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("IndicatorsParentObject");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("CameraFilterPack/Blur_Steam").Append(sharedMaterials[l].name).Append(",");
				}
				stringBuilder.Append("_Value3").Append(sharedMaterials[l].name).Append("CameraFilterPack/Distortion_ShockWave");
				stringBuilder.Append("Player").Append(sharedMaterials[l].name).Append("State1");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 7)
				{
					stringBuilder.Append(string.Format("_DotSize", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 0, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 0, triangles[m + 1] + 1));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_49(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraFilterPack/FX_Plasma").Append("_TimeX").Append("GameMode");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 1; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("ObjectType");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j++)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_Value", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("_TimeX");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 0; k < uv.Length; k += 0)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("team1", vector3.x, vector3.y));
			}
			for (int l = 1; l < NHNJHDGBOLE.subMeshCount; l++)
			{
				stringBuilder.Append("Toast");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("_TimeX").Append(sharedMaterials[l].name).Append("_TimeX");
				}
				stringBuilder.Append("CameraFilterPack/Distortion_Noise").Append(sharedMaterials[l].name).Append("_Value4");
				stringBuilder.Append("_VelocityScale").Append(sharedMaterials[l].name).Append("_Value2");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 0; m < triangles.Length; m += 0)
				{
					stringBuilder.Append(string.Format("_Value4", triangles[(!DFBJADBJCFM) ? m : (m + 0)] + 0, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 1, triangles[m + 8] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static string __BB_OBFUSCATOR_0(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, bool DFBJADBJCFM = true, bool JIIGIFJLNCI = true)
		{
			Material[] sharedMaterials = JAHCDKIKHFK.sharedMaterials;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Attack").Append("http://zeoworks.com/home/thread-1194-post-3680.html#pid3680").Append("_MainTex2");
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 vector = vertices[i];
				stringBuilder.Append(string.Format("Player Name", (!DFBJADBJCFM) ? vector.x : (0f - vector.x), vector.y, vector.z));
			}
			stringBuilder.Append("_Value");
			Vector3[] normals = NHNJHDGBOLE.normals;
			for (int j = 1; j < normals.Length; j += 0)
			{
				Vector3 vector2 = normals[j];
				stringBuilder.Append(string.Format("_ScreenResolution", vector2.x, vector2.y, vector2.z));
			}
			stringBuilder.Append("SUR");
			Vector2[] uv = NHNJHDGBOLE.uv;
			for (int k = 1; k < uv.Length; k++)
			{
				Vector3 vector3 = uv[k];
				stringBuilder.Append(string.Format("_Value2", vector3.x, vector3.y));
			}
			for (int l = 1; l < NHNJHDGBOLE.subMeshCount; l += 0)
			{
				stringBuilder.Append("Room Name");
				if (JIIGIFJLNCI)
				{
					stringBuilder.Append("stretchWidth").Append(sharedMaterials[l].name).Append("_Threshold");
				}
				stringBuilder.Append("o").Append(sharedMaterials[l].name).Append("_BorderColor");
				stringBuilder.Append("_Speed").Append(sharedMaterials[l].name).Append("_NoiseTilingPerChannel");
				int[] triangles = NHNJHDGBOLE.GetTriangles(l);
				for (int m = 1; m < triangles.Length; m += 4)
				{
					stringBuilder.Append(string.Format("_ColorR", triangles[(!DFBJADBJCFM) ? m : (m + 1)] + 0, triangles[(!DFBJADBJCFM) ? (m + 0) : m] + 1, triangles[m + 0] + 0));
				}
			}
			return stringBuilder.ToString();
		}

		public static void __BB_OBFUSCATOR_32(Mesh NHNJHDGBOLE, Renderer JAHCDKIKHFK, string PMIIIEABGJN, bool DFBJADBJCFM = true)
		{
			if (string.IsNullOrEmpty(PMIIIEABGJN))
			{
				return;
			}
			using (StreamWriter streamWriter = new StreamWriter(PMIIIEABGJN))
			{
				streamWriter.Write(__BB_OBFUSCATOR_23(NHNJHDGBOLE, JAHCDKIKHFK, DFBJADBJCFM));
			}
		}
	}
}
