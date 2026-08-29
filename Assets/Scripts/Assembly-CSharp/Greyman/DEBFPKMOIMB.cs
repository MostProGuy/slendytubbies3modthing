using UnityEngine;

namespace Greyman
{
	public static class DEBFPKMOIMB
	{
		public static void DrawPlane(Vector3 KDDJNDKJKHJ, Vector3 MPECPABBGJO, float OHPDCFDAIGC)
		{
			Vector3 vector = ((!(KDDJNDKJKHJ.normalized != Vector3.forward)) ? (Vector3.Cross(KDDJNDKJKHJ, Vector3.up).normalized * KDDJNDKJKHJ.magnitude * OHPDCFDAIGC) : (Vector3.Cross(KDDJNDKJKHJ, Vector3.forward).normalized * KDDJNDKJKHJ.magnitude * OHPDCFDAIGC));
			Vector3 vector2 = MPECPABBGJO + vector;
			Vector3 vector3 = MPECPABBGJO - vector;
			Quaternion quaternion = Quaternion.AngleAxis(90f, KDDJNDKJKHJ);
			vector = quaternion * vector;
			Vector3 vector4 = MPECPABBGJO + vector;
			Vector3 vector5 = MPECPABBGJO - vector;
			Debug.DrawLine(vector2, vector3, Color.green);
			Debug.DrawLine(vector4, vector5, Color.green);
			Debug.DrawLine(vector2, vector4, Color.green);
			Debug.DrawLine(vector4, vector3, Color.green);
			Debug.DrawLine(vector3, vector5, Color.green);
			Debug.DrawLine(vector5, vector2, Color.green);
			Debug.DrawRay(MPECPABBGJO, KDDJNDKJKHJ, Color.blue);
		}
	}
}
