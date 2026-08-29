using UnityEngine;

namespace MeshTK
{
	public static class PFKBPHDMLII
	{
		public static Vector3 Center(Mesh NHNJHDGBOLE)
		{
			NHNJHDGBOLE.RecalculateBounds();
			Vector3 center = NHNJHDGBOLE.bounds.center;
			Move(NHNJHDGBOLE, center);
			return center;
		}

		public static void Move(Mesh NHNJHDGBOLE, Vector3 GNPGGMIFCOD)
		{
			Vector3[] vertices = NHNJHDGBOLE.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				vertices[i] = new Vector3(vertices[i].x - GNPGGMIFCOD.x, vertices[i].y - GNPGGMIFCOD.y, vertices[i].z - GNPGGMIFCOD.z);
			}
			NHNJHDGBOLE.vertices = vertices;
			NHNJHDGBOLE.RecalculateBounds();
		}

		public static Vector3 Set(Mesh NHNJHDGBOLE, Vector3 GNPGGMIFCOD)
		{
			NHNJHDGBOLE.RecalculateBounds();
			Vector3 vector = NHNJHDGBOLE.bounds.center - GNPGGMIFCOD;
			Move(NHNJHDGBOLE, vector);
			return vector;
		}
	}
}
