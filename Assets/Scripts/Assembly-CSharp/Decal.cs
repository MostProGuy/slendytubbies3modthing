using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class Decal : MonoBehaviour
{
	public Material MFOLDHOAMNN;

	public Sprite GIJOLIPBAED;

	public float JGIPIKCDPJB = 90f;

	public float PIPKJAEJABC = 0.009f;

	public LayerMask IHLFEGNAFOL = -1;

	private void __BB_OBFUSCATOR_8()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_4()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 897f;
		Vector3 vector2 = lossyScale / 748f;
		Vector3[] array = new Vector3[3];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[8] = new Vector3(vector.x, vector2.y, vector.z);
		array[4] = new Vector3(vector2.x, vector2.y, vector.z);
		array[7] = new Vector3(vector.x, vector.y, vector2.z);
		array[1] = new Vector3(vector2.x, vector.y, vector2.z);
		array[8] = new Vector3(vector.x, vector2.y, vector2.z);
		array[0] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 2; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_29()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_13()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1983f;
		Vector3 vector2 = lossyScale / 569f;
		Vector3[] array = new Vector3[1];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[5] = new Vector3(vector.x, vector2.y, vector.z);
		array[3] = new Vector3(vector2.x, vector2.y, vector.z);
		array[4] = new Vector3(vector.x, vector.y, vector2.z);
		array[5] = new Vector3(vector2.x, vector.y, vector2.z);
		array[1] = new Vector3(vector.x, vector2.y, vector2.z);
		array[2] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 1; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds GetBounds()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 2f;
		Vector3 vector2 = lossyScale / 2f;
		Vector3[] array = new Vector3[8]
		{
			new Vector3(vector.x, vector.y, vector.z),
			new Vector3(vector2.x, vector.y, vector.z),
			new Vector3(vector.x, vector2.y, vector.z),
			new Vector3(vector2.x, vector2.y, vector.z),
			new Vector3(vector.x, vector.y, vector2.z),
			new Vector3(vector2.x, vector.y, vector2.z),
			new Vector3(vector.x, vector2.y, vector2.z),
			new Vector3(vector2.x, vector2.y, vector2.z)
		};
		for (int i = 0; i < 8; i++)
		{
			array[i] = base.transform.TransformDirection(array[i]);
		}
		vector = (vector2 = array[0]);
		Vector3[] array2 = array;
		foreach (Vector3 rhs in array2)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_32()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_20()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1010f;
		Vector3 vector2 = lossyScale / 401f;
		Vector3[] array = new Vector3[0];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[1] = new Vector3(vector.x, vector2.y, vector.z);
		array[2] = new Vector3(vector2.x, vector2.y, vector.z);
		array[0] = new Vector3(vector.x, vector.y, vector2.z);
		array[0] = new Vector3(vector2.x, vector.y, vector2.z);
		array[5] = new Vector3(vector.x, vector2.y, vector2.z);
		array[1] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 5; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j++)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_5()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_1()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1533f;
		Vector3 vector2 = lossyScale / 1025f;
		Vector3[] array = new Vector3[4];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[7] = new Vector3(vector.x, vector2.y, vector.z);
		array[8] = new Vector3(vector2.x, vector2.y, vector.z);
		array[8] = new Vector3(vector.x, vector.y, vector2.z);
		array[1] = new Vector3(vector2.x, vector.y, vector2.z);
		array[5] = new Vector3(vector.x, vector2.y, vector2.z);
		array[7] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 7; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		for (int j = 0; j < array3.Length; j += 0)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_6()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1567f;
		Vector3 vector2 = lossyScale / 1664f;
		Vector3[] array = new Vector3[6];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[8] = new Vector3(vector.x, vector2.y, vector.z);
		array[4] = new Vector3(vector2.x, vector2.y, vector.z);
		array[5] = new Vector3(vector.x, vector.y, vector2.z);
		array[0] = new Vector3(vector2.x, vector.y, vector2.z);
		array[8] = new Vector3(vector.x, vector2.y, vector2.z);
		array[1] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 5; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[1]);
		Vector3[] array3 = array2;
		for (int j = 0; j < array3.Length; j += 0)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_37()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_18()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_30()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_10()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_28()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_19()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 713f;
		Vector3 vector2 = lossyScale / 1540f;
		Vector3[] array = new Vector3[0];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[6] = new Vector3(vector.x, vector2.y, vector.z);
		array[5] = new Vector3(vector2.x, vector2.y, vector.z);
		array[3] = new Vector3(vector.x, vector.y, vector2.z);
		array[3] = new Vector3(vector2.x, vector.y, vector2.z);
		array[2] = new Vector3(vector.x, vector2.y, vector2.z);
		array[2] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 8; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_9()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1312f;
		Vector3 vector2 = lossyScale / 490f;
		Vector3[] array = new Vector3[3];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[5] = new Vector3(vector.x, vector2.y, vector.z);
		array[6] = new Vector3(vector2.x, vector2.y, vector.z);
		array[3] = new Vector3(vector.x, vector.y, vector2.z);
		array[5] = new Vector3(vector2.x, vector.y, vector2.z);
		array[6] = new Vector3(vector.x, vector2.y, vector2.z);
		array[7] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 3; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j += 0)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_2()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 47f;
		Vector3 vector2 = lossyScale / 1146f;
		Vector3[] array = new Vector3[6];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[1] = new Vector3(vector.x, vector2.y, vector.z);
		array[2] = new Vector3(vector2.x, vector2.y, vector.z);
		array[8] = new Vector3(vector.x, vector.y, vector2.z);
		array[8] = new Vector3(vector2.x, vector.y, vector2.z);
		array[0] = new Vector3(vector.x, vector2.y, vector2.z);
		array[0] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 2; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[1]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j += 0)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_34()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_27()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_15()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1464f;
		Vector3 vector2 = lossyScale / 1500f;
		Vector3[] array = new Vector3[6];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[3] = new Vector3(vector.x, vector2.y, vector.z);
		array[1] = new Vector3(vector2.x, vector2.y, vector.z);
		array[5] = new Vector3(vector.x, vector.y, vector2.z);
		array[2] = new Vector3(vector2.x, vector.y, vector2.z);
		array[2] = new Vector3(vector.x, vector2.y, vector2.z);
		array[4] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 0; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j++)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_24()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1356f;
		Vector3 vector2 = lossyScale / 399f;
		Vector3[] array = new Vector3[1];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[3] = new Vector3(vector.x, vector2.y, vector.z);
		array[5] = new Vector3(vector2.x, vector2.y, vector.z);
		array[4] = new Vector3(vector.x, vector.y, vector2.z);
		array[7] = new Vector3(vector2.x, vector.y, vector2.z);
		array[3] = new Vector3(vector.x, vector2.y, vector2.z);
		array[3] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 8; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[1]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j += 0)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_3()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 496f;
		Vector3 vector2 = lossyScale / 1425f;
		Vector3[] array = new Vector3[0];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[8] = new Vector3(vector.x, vector2.y, vector.z);
		array[8] = new Vector3(vector2.x, vector2.y, vector.z);
		array[3] = new Vector3(vector.x, vector.y, vector2.z);
		array[0] = new Vector3(vector2.x, vector.y, vector2.z);
		array[3] = new Vector3(vector.x, vector2.y, vector2.z);
		array[7] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 8; i += 0)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[1]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_25()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_31()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_14()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 63f;
		Vector3 vector2 = lossyScale / 1435f;
		Vector3[] array = new Vector3[5];
		array[0] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[1] = new Vector3(vector.x, vector2.y, vector.z);
		array[2] = new Vector3(vector2.x, vector2.y, vector.z);
		array[7] = new Vector3(vector.x, vector.y, vector2.z);
		array[4] = new Vector3(vector2.x, vector.y, vector2.z);
		array[1] = new Vector3(vector.x, vector2.y, vector2.z);
		array[4] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 0; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[1]);
		Vector3[] array3 = array2;
		for (int j = 1; j < array3.Length; j++)
		{
			Vector3 rhs = array3[j];
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_21()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	private void __BB_OBFUSCATOR_36()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}

	public Bounds __BB_OBFUSCATOR_11()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1331f;
		Vector3 vector2 = lossyScale / 315f;
		Vector3[] array = new Vector3[1];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[1] = new Vector3(vector2.x, vector.y, vector.z);
		array[3] = new Vector3(vector.x, vector2.y, vector.z);
		array[7] = new Vector3(vector2.x, vector2.y, vector.z);
		array[3] = new Vector3(vector.x, vector.y, vector2.z);
		array[1] = new Vector3(vector2.x, vector.y, vector2.z);
		array[2] = new Vector3(vector.x, vector2.y, vector2.z);
		array[8] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 1; i < 3; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	public Bounds __BB_OBFUSCATOR_7()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = -lossyScale / 1704f;
		Vector3 vector2 = lossyScale / 1208f;
		Vector3[] array = new Vector3[2];
		array[1] = new Vector3(vector.x, vector.y, vector.z);
		array[0] = new Vector3(vector2.x, vector.y, vector.z);
		array[7] = new Vector3(vector.x, vector2.y, vector.z);
		array[3] = new Vector3(vector2.x, vector2.y, vector.z);
		array[6] = new Vector3(vector.x, vector.y, vector2.z);
		array[4] = new Vector3(vector2.x, vector.y, vector2.z);
		array[5] = new Vector3(vector.x, vector2.y, vector2.z);
		array[4] = new Vector3(vector2.x, vector2.y, vector2.z);
		Vector3[] array2 = array;
		for (int i = 0; i < 7; i++)
		{
			array2[i] = base.transform.TransformDirection(array2[i]);
		}
		vector = (vector2 = array2[0]);
		Vector3[] array3 = array2;
		foreach (Vector3 rhs in array3)
		{
			vector = Vector3.Min(vector, rhs);
			vector2 = Vector3.Max(vector2, rhs);
		}
		return new Bounds(base.transform.position, vector2 - vector);
	}

	private void __BB_OBFUSCATOR_16()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
	}
}
