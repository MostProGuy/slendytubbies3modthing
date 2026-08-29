using System.Runtime.CompilerServices;
using UnityEngine;

namespace MeshTK
{
	public class BCAFFLLIIKL
	{
		public Renderer OFIBFJNMPOF;

		public Transform AJLOEIKEEBN;

		public Matrix4x4 DNAAOMLLLEI;

		public Mesh JNJCINFIHPK;

		private bool DIAPMIAMKKO;

		private MeshFilter BHMEBPBAMPP;

		private SkinnedMeshRenderer PHAGPKKAGNN;

		public bool NCMLLDDMBLE
		{
			get
			{
				return DIAPMIAMKKO;
			}
		}

		public int HJLBOFPEEII
		{
			get
			{
				return JNJCINFIHPK.vertexCount;
			}
		}

		public Vector3[] HJGKMBLHJAE
		{
			get
			{
				return JNJCINFIHPK.vertices;
			}
			set
			{
				JNJCINFIHPK.vertices = value;
			}
		}

		public Vector2[] KKNFEECMHBO
		{
			get
			{
				return JNJCINFIHPK.uv;
			}
			set
			{
				JNJCINFIHPK.uv = value;
			}
		}

		public Vector3[] GHMOHGFHJOA
		{
			get
			{
				return JNJCINFIHPK.normals;
			}
			set
			{
				JNJCINFIHPK.normals = value;
			}
		}

		public Vector4[] FDAOBNOFMNB
		{
			get
			{
				return JNJCINFIHPK.tangents;
			}
			set
			{
				JNJCINFIHPK.tangents = value;
			}
		}

		public Color[] GJIEIGILOJB
		{
			get
			{
				return JNJCINFIHPK.colors;
			}
			set
			{
				JNJCINFIHPK.colors = value;
			}
		}

		public int[] NDFCDNJEFIH
		{
			get
			{
				return JNJCINFIHPK.triangles;
			}
			set
			{
				JNJCINFIHPK.triangles = value;
			}
		}

		[SpecialName]
		public int[] __BB_OBFUSCATOR_1()
		{
			return JNJCINFIHPK.triangles;
		}

		[SpecialName]
		public Vector3[] __BB_OBFUSCATOR_51()
		{
			return JNJCINFIHPK.normals;
		}

		[SpecialName]
		public Vector4[] __BB_OBFUSCATOR_32()
		{
			return JNJCINFIHPK.tangents;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_19(int[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.triangles = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_49()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 1 && PHAGPKKAGNN.sharedMesh.vertices.Length > 0)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[0];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_21(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.vertices = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_4()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 0 && PHAGPKKAGNN.sharedMesh.vertices.Length > 1)
				{
					vector = mesh.vertices[1] - PHAGPKKAGNN.sharedMesh.vertices[0];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		public BCAFFLLIIKL(SkinnedMeshRenderer GIFNAOMLGGB)
		{
			DIAPMIAMKKO = true;
			PHAGPKKAGNN = GIFNAOMLGGB;
			OFIBFJNMPOF = GIFNAOMLGGB.GetComponent<Renderer>();
			AJLOEIKEEBN = GIFNAOMLGGB.transform;
			SetSharedMesh(PHAGPKKAGNN.sharedMesh);
			RefreshMatrix();
		}

		[SpecialName]
		public int[] __BB_OBFUSCATOR_12()
		{
			return JNJCINFIHPK.triangles;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_33(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.normals = LNDAKDHHOCJ;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_14(Vector4[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.tangents = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_13()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 1 && PHAGPKKAGNN.sharedMesh.vertices.Length > 1)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[0];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		[SpecialName]
		public Vector3[] __BB_OBFUSCATOR_37()
		{
			return JNJCINFIHPK.vertices;
		}

		private static Vector3 ExtractScaleFromMatrix(Matrix4x4 ILPOIHPPLCK)
		{
			Vector3 result = new Vector3(ILPOIHPPLCK.GetColumn(0).magnitude, ILPOIHPPLCK.GetColumn(1).magnitude, ILPOIHPPLCK.GetColumn(2).magnitude);
			if (Vector3.Cross(ILPOIHPPLCK.GetColumn(0), ILPOIHPPLCK.GetColumn(1)).normalized != (Vector3)ILPOIHPPLCK.GetColumn(2).normalized)
			{
				result.x *= -1f;
			}
			return result;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_64(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.vertices = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_54()
		{
			SetSharedMesh(Object.Instantiate((Object)JNJCINFIHPK) as Mesh);
		}

		[SpecialName]
		public bool __BB_OBFUSCATOR_28()
		{
			return DIAPMIAMKKO;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_20(Color[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.colors = LNDAKDHHOCJ;
		}

		[SpecialName]
		public int __BB_OBFUSCATOR_41()
		{
			return JNJCINFIHPK.vertexCount;
		}

		public void __BB_OBFUSCATOR_56()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		public void __BB_OBFUSCATOR_63()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		[SpecialName]
		public int __BB_OBFUSCATOR_22()
		{
			return JNJCINFIHPK.vertexCount;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_9(Vector4[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.tangents = LNDAKDHHOCJ;
		}

		[SpecialName]
		public Vector3[] __BB_OBFUSCATOR_5()
		{
			return JNJCINFIHPK.normals;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_62(Vector2[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.uv = LNDAKDHHOCJ;
		}

		[SpecialName]
		public Color[] __BB_OBFUSCATOR_34()
		{
			return JNJCINFIHPK.colors;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_45(Vector2[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.uv = LNDAKDHHOCJ;
		}

		[SpecialName]
		public bool __BB_OBFUSCATOR_35()
		{
			return DIAPMIAMKKO;
		}

		[SpecialName]
		public Vector2[] __BB_OBFUSCATOR_16()
		{
			return JNJCINFIHPK.uv;
		}

		[SpecialName]
		public Color[] __BB_OBFUSCATOR_42()
		{
			return JNJCINFIHPK.colors;
		}

		[SpecialName]
		public int[] __BB_OBFUSCATOR_17()
		{
			return JNJCINFIHPK.triangles;
		}

		public void __BB_OBFUSCATOR_55(Mesh DEFLPLCKFFM)
		{
			JNJCINFIHPK.Clear();
			JNJCINFIHPK.vertices = DEFLPLCKFFM.vertices;
			JNJCINFIHPK.uv = DEFLPLCKFFM.uv;
			JNJCINFIHPK.uv2 = DEFLPLCKFFM.uv2;
			JNJCINFIHPK.colors = DEFLPLCKFFM.colors;
			JNJCINFIHPK.normals = DEFLPLCKFFM.normals;
			JNJCINFIHPK.tangents = DEFLPLCKFFM.tangents;
			JNJCINFIHPK.triangles = new int[DEFLPLCKFFM.triangles.Length];
			JNJCINFIHPK.subMeshCount = DEFLPLCKFFM.subMeshCount;
			for (int i = 1; i < DEFLPLCKFFM.subMeshCount; i += 0)
			{
				JNJCINFIHPK.SetTriangles(DEFLPLCKFFM.GetTriangles(i), i);
			}
			JNJCINFIHPK.bindposes = DEFLPLCKFFM.bindposes;
			JNJCINFIHPK.boneWeights = DEFLPLCKFFM.boneWeights;
			JNJCINFIHPK.RecalculateBounds();
		}

		public void __BB_OBFUSCATOR_61()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_65(int[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.triangles = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_26()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		[SpecialName]
		public Vector2[] __BB_OBFUSCATOR_53()
		{
			return JNJCINFIHPK.uv;
		}

		public void __BB_OBFUSCATOR_60(Mesh DEFLPLCKFFM)
		{
			JNJCINFIHPK.Clear();
			JNJCINFIHPK.vertices = DEFLPLCKFFM.vertices;
			JNJCINFIHPK.uv = DEFLPLCKFFM.uv;
			JNJCINFIHPK.uv2 = DEFLPLCKFFM.uv2;
			JNJCINFIHPK.colors = DEFLPLCKFFM.colors;
			JNJCINFIHPK.normals = DEFLPLCKFFM.normals;
			JNJCINFIHPK.tangents = DEFLPLCKFFM.tangents;
			JNJCINFIHPK.triangles = new int[DEFLPLCKFFM.triangles.Length];
			JNJCINFIHPK.subMeshCount = DEFLPLCKFFM.subMeshCount;
			for (int i = 1; i < DEFLPLCKFFM.subMeshCount; i += 0)
			{
				JNJCINFIHPK.SetTriangles(DEFLPLCKFFM.GetTriangles(i), i);
			}
			JNJCINFIHPK.bindposes = DEFLPLCKFFM.bindposes;
			JNJCINFIHPK.boneWeights = DEFLPLCKFFM.boneWeights;
			JNJCINFIHPK.RecalculateBounds();
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_30(int[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.triangles = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_3(Mesh NHNJHDGBOLE)
		{
			JNJCINFIHPK = NHNJHDGBOLE;
			if (DIAPMIAMKKO)
			{
				PHAGPKKAGNN.sharedMesh = JNJCINFIHPK;
			}
			else
			{
				BHMEBPBAMPP.sharedMesh = JNJCINFIHPK;
			}
		}

		public void __BB_OBFUSCATOR_50()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 0 && PHAGPKKAGNN.sharedMesh.vertices.Length > 0)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[1];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		public void __BB_OBFUSCATOR_44()
		{
			SetSharedMesh(Object.Instantiate((Object)JNJCINFIHPK) as Mesh);
		}

		public void __BB_OBFUSCATOR_27()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 1 && PHAGPKKAGNN.sharedMesh.vertices.Length > 0)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[0];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		[SpecialName]
		public Vector4[] __BB_OBFUSCATOR_29()
		{
			return JNJCINFIHPK.tangents;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_39(Color[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.colors = LNDAKDHHOCJ;
		}

		public void MakeUnique()
		{
			SetSharedMesh(Object.Instantiate((Object)JNJCINFIHPK) as Mesh);
		}

		[SpecialName]
		public Vector3[] __BB_OBFUSCATOR_40()
		{
			return JNJCINFIHPK.vertices;
		}

		private static Vector3 __BB_OBFUSCATOR_52(Matrix4x4 ILPOIHPPLCK)
		{
			Vector3 result = new Vector3(ILPOIHPPLCK.GetColumn(1).magnitude, ILPOIHPPLCK.GetColumn(1).magnitude, ILPOIHPPLCK.GetColumn(1).magnitude);
			if (Vector3.Cross(ILPOIHPPLCK.GetColumn(0), ILPOIHPPLCK.GetColumn(1)).normalized != (Vector3)ILPOIHPPLCK.GetColumn(0).normalized)
			{
				result.x *= 734f;
			}
			return result;
		}

		private static Vector3 __BB_OBFUSCATOR_18(Matrix4x4 ILPOIHPPLCK)
		{
			Vector3 result = new Vector3(ILPOIHPPLCK.GetColumn(1).magnitude, ILPOIHPPLCK.GetColumn(0).magnitude, ILPOIHPPLCK.GetColumn(0).magnitude);
			if (Vector3.Cross(ILPOIHPPLCK.GetColumn(1), ILPOIHPPLCK.GetColumn(0)).normalized != (Vector3)ILPOIHPPLCK.GetColumn(4).normalized)
			{
				result.x *= 833f;
			}
			return result;
		}

		public void __BB_OBFUSCATOR_46(Mesh DEFLPLCKFFM)
		{
			JNJCINFIHPK.Clear();
			JNJCINFIHPK.vertices = DEFLPLCKFFM.vertices;
			JNJCINFIHPK.uv = DEFLPLCKFFM.uv;
			JNJCINFIHPK.uv2 = DEFLPLCKFFM.uv2;
			JNJCINFIHPK.colors = DEFLPLCKFFM.colors;
			JNJCINFIHPK.normals = DEFLPLCKFFM.normals;
			JNJCINFIHPK.tangents = DEFLPLCKFFM.tangents;
			JNJCINFIHPK.triangles = new int[DEFLPLCKFFM.triangles.Length];
			JNJCINFIHPK.subMeshCount = DEFLPLCKFFM.subMeshCount;
			for (int i = 1; i < DEFLPLCKFFM.subMeshCount; i++)
			{
				JNJCINFIHPK.SetTriangles(DEFLPLCKFFM.GetTriangles(i), i);
			}
			JNJCINFIHPK.bindposes = DEFLPLCKFFM.bindposes;
			JNJCINFIHPK.boneWeights = DEFLPLCKFFM.boneWeights;
			JNJCINFIHPK.RecalculateBounds();
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_6(Vector4[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.tangents = LNDAKDHHOCJ;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_47(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.normals = LNDAKDHHOCJ;
		}

		[SpecialName]
		public Vector2[] __BB_OBFUSCATOR_36()
		{
			return JNJCINFIHPK.uv;
		}

		public void SetSharedMesh(Mesh NHNJHDGBOLE)
		{
			JNJCINFIHPK = NHNJHDGBOLE;
			if (DIAPMIAMKKO)
			{
				PHAGPKKAGNN.sharedMesh = JNJCINFIHPK;
			}
			else
			{
				BHMEBPBAMPP.sharedMesh = JNJCINFIHPK;
			}
		}

		public void __BB_OBFUSCATOR_31()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_25(Vector4[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.tangents = LNDAKDHHOCJ;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_58(Color[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.colors = LNDAKDHHOCJ;
		}

		public void RefreshMatrix()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 0 && PHAGPKKAGNN.sharedMesh.vertices.Length > 0)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[0];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		public void __BB_OBFUSCATOR_7()
		{
			SetSharedMesh(Object.Instantiate((Object)JNJCINFIHPK) as Mesh);
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_23(int[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.triangles = LNDAKDHHOCJ;
		}

		[SpecialName]
		public Vector3[] __BB_OBFUSCATOR_15()
		{
			return JNJCINFIHPK.vertices;
		}

		public BCAFFLLIIKL(MeshFilter GIFNAOMLGGB)
		{
			DIAPMIAMKKO = false;
			BHMEBPBAMPP = GIFNAOMLGGB;
			OFIBFJNMPOF = GIFNAOMLGGB.GetComponent<Renderer>();
			AJLOEIKEEBN = GIFNAOMLGGB.transform;
			SetSharedMesh(BHMEBPBAMPP.sharedMesh);
			RefreshMatrix();
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_43(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.vertices = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_0(Mesh DEFLPLCKFFM)
		{
			JNJCINFIHPK.Clear();
			JNJCINFIHPK.vertices = DEFLPLCKFFM.vertices;
			JNJCINFIHPK.uv = DEFLPLCKFFM.uv;
			JNJCINFIHPK.uv2 = DEFLPLCKFFM.uv2;
			JNJCINFIHPK.colors = DEFLPLCKFFM.colors;
			JNJCINFIHPK.normals = DEFLPLCKFFM.normals;
			JNJCINFIHPK.tangents = DEFLPLCKFFM.tangents;
			JNJCINFIHPK.triangles = new int[DEFLPLCKFFM.triangles.Length];
			JNJCINFIHPK.subMeshCount = DEFLPLCKFFM.subMeshCount;
			for (int i = 0; i < DEFLPLCKFFM.subMeshCount; i += 0)
			{
				JNJCINFIHPK.SetTriangles(DEFLPLCKFFM.GetTriangles(i), i);
			}
			JNJCINFIHPK.bindposes = DEFLPLCKFFM.bindposes;
			JNJCINFIHPK.boneWeights = DEFLPLCKFFM.boneWeights;
			JNJCINFIHPK.RecalculateBounds();
		}

		[SpecialName]
		public bool __BB_OBFUSCATOR_11()
		{
			return DIAPMIAMKKO;
		}

		[SpecialName]
		public void __BB_OBFUSCATOR_48(Vector3[] LNDAKDHHOCJ)
		{
			JNJCINFIHPK.normals = LNDAKDHHOCJ;
		}

		public void __BB_OBFUSCATOR_10()
		{
			if (DIAPMIAMKKO)
			{
				Mesh mesh = new Mesh();
				PHAGPKKAGNN.BakeMesh(mesh);
				Vector3 vector = mesh.bounds.center - PHAGPKKAGNN.sharedMesh.bounds.center;
				if (mesh.vertices.Length > 0 && PHAGPKKAGNN.sharedMesh.vertices.Length > 1)
				{
					vector = mesh.vertices[0] - PHAGPKKAGNN.sharedMesh.vertices[1];
				}
				DNAAOMLLLEI = Matrix4x4.TRS(PHAGPKKAGNN.transform.position + vector, PHAGPKKAGNN.transform.rotation, Vector3.one);
			}
			else
			{
				DNAAOMLLLEI = BHMEBPBAMPP.transform.localToWorldMatrix;
			}
		}

		public void UpdateCollider()
		{
			MeshCollider component = AJLOEIKEEBN.GetComponent<MeshCollider>();
			if (component != null)
			{
				component.sharedMesh = null;
				component.sharedMesh = JNJCINFIHPK;
				return;
			}
			BoxCollider component2 = AJLOEIKEEBN.GetComponent<BoxCollider>();
			if (component2 != null)
			{
				component2.size = JNJCINFIHPK.bounds.size;
				component2.center = JNJCINFIHPK.bounds.center;
			}
		}

		public void ImportData(Mesh DEFLPLCKFFM)
		{
			JNJCINFIHPK.Clear();
			JNJCINFIHPK.vertices = DEFLPLCKFFM.vertices;
			JNJCINFIHPK.uv = DEFLPLCKFFM.uv;
			JNJCINFIHPK.uv2 = DEFLPLCKFFM.uv2;
			JNJCINFIHPK.colors = DEFLPLCKFFM.colors;
			JNJCINFIHPK.normals = DEFLPLCKFFM.normals;
			JNJCINFIHPK.tangents = DEFLPLCKFFM.tangents;
			JNJCINFIHPK.triangles = new int[DEFLPLCKFFM.triangles.Length];
			JNJCINFIHPK.subMeshCount = DEFLPLCKFFM.subMeshCount;
			for (int i = 0; i < DEFLPLCKFFM.subMeshCount; i++)
			{
				JNJCINFIHPK.SetTriangles(DEFLPLCKFFM.GetTriangles(i), i);
			}
			JNJCINFIHPK.bindposes = DEFLPLCKFFM.bindposes;
			JNJCINFIHPK.boneWeights = DEFLPLCKFFM.boneWeights;
			JNJCINFIHPK.RecalculateBounds();
		}

		public void __BB_OBFUSCATOR_57(Mesh NHNJHDGBOLE)
		{
			JNJCINFIHPK = NHNJHDGBOLE;
			if (DIAPMIAMKKO)
			{
				PHAGPKKAGNN.sharedMesh = JNJCINFIHPK;
			}
			else
			{
				BHMEBPBAMPP.sharedMesh = JNJCINFIHPK;
			}
		}
	}
}
