using UnityEngine;

public class FurScript : MonoBehaviour
{
	[Tooltip("Attach the material with the furshader here.")]
	public Material BOLEOBOAMBO;

	[Tooltip("Enable to simulate fur movement when the object is moving. Requires object to have a RigidBody.")]
	[Space(10f)]
	public bool HONNGDNGPCA;

	[Tooltip("Enable to fix fur being culled at the edge of screen. This does affect performance, only use if neccessary.")]
	public bool LALBCLKBLHA;

	[Tooltip("Adjust to a higher value if your fur is removing other transparent objects behind it. If you have a lot of transparent objects you will need to intelligently layer them with this.")]
	[Range(0f, 10f)]
	public int GGBMFCBBCBH;

	private Rigidbody BEMCEEHJHPL;

	private bool JHLPPCNMMCO;

	private Camera PMGJGLIHBBB;

	private Bounds PPMMNBGJNCP;

	private Mesh NHNJHDGBOLE;

	private void __BB_OBFUSCATOR_85()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Attack", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("Walking", new Vector3(789f, 1733f, 282f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 573f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("offsets", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("</size>", new Vector3(1637f, 1728f, 1103f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1053f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_Distortion", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("The given 2D texture ", new Vector3(942f, 1403f, 1880f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1671f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Value2" + base.gameObject.name + "</size>");
		}
		BOLEOBOAMBO.renderQueue = -24 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Intensity" + base.gameObject.name + "Toast");
		}
		BOLEOBOAMBO.renderQueue = 59 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_94()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("MG" + base.gameObject.name + "><color=white>");
		}
		BOLEOBOAMBO.renderQueue = -160 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("n4" + base.gameObject.name + "_ScreenResolution");
		}
		BOLEOBOAMBO.renderQueue = 186 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Detonator", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", new Vector3(1475f, 1587f, 1404f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 826f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("SpawnPlayer", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("Vertical", new Vector3(1548f, 1305f, 1503f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1470f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_SoftZDistance", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("INF", new Vector3(964f, 436f, 1793f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1438f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("</size>" + base.gameObject.name + "CameraFilterPack/Blend2Camera_ColorDodge");
		}
		BOLEOBOAMBO.renderQueue = -174 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("n4" + base.gameObject.name + "\n\n;Version 5 settings\n;------------------------------------------------------------------\n\n");
		}
		BOLEOBOAMBO.renderQueue = -8 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Toast", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("All custards have been found...", new Vector3(908f, 558f, 265f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 729f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("INF", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("Detonator/Textures/Smoke", new Vector3(1670f, 220f, 1250f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 232f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("team2", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("CameraFilterPack/BlurHole", new Vector3(124f, 636f, 227f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 543f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Connect failed: no UserId specified in authentication values.", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_DepthFade", new Vector3(1810f, 1760f, 1364f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1783f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("CameraFilterPack/Blur_Dithering2x2" + base.gameObject.name + "_Value2");
		}
		BOLEOBOAMBO.renderQueue = -88 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Green_B", new Vector3(853f, 1275f, 190f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 312f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Value3" + base.gameObject.name + "MP");
		}
		BOLEOBOAMBO.renderQueue = 156 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void Start()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("FurShader: Simulate Movement option enabled on GameObject: '" + base.gameObject.name + "', but this object does not have a RigidBody. Attach a RigidBody Component to simulate movement.");
		}
		BOLEOBOAMBO.renderQueue = 3000 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_ScreenResolution" + base.gameObject.name + ">  ");
		}
		BOLEOBOAMBO.renderQueue = 64 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("offsets" + base.gameObject.name + "PlayerType'");
		}
		BOLEOBOAMBO.renderQueue = -185 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("CameraFilterPack/TV_VHS_Rewind" + base.gameObject.name + ">");
		}
		BOLEOBOAMBO.renderQueue = -6 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_BlurRadius4", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("Connect", new Vector3(1160f, 25f, 30f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1639f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("</color>" + base.gameObject.name + "_Value5");
		}
		BOLEOBOAMBO.renderQueue = 147 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("CustomSkin", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", new Vector3(1466f, 682f, 716f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1948f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Value3" + base.gameObject.name + "\tMaterial: \"Material::");
		}
		BOLEOBOAMBO.renderQueue = -189 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_84()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_Value", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector(": ", new Vector3(1440f, 1558f, 1765f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1089f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector(">", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("BodyURL", new Vector3(765f, 491f, 636f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 10f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("<size=16><color=red>[KICK]</color> " + base.gameObject.name + "Can't authenticate on front end server. Authentication Values are not set");
		}
		BOLEOBOAMBO.renderQueue = -46 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Value" + base.gameObject.name + "Label");
		}
		BOLEOBOAMBO.renderQueue = 98 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Speed (", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("-Lengh: ", new Vector3(908f, 1770f, 1924f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1371f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("team1" + base.gameObject.name + "CameraFilterPack/Blend2Camera_Screen");
		}
		BOLEOBOAMBO.renderQueue = -80 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_TimeX", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Threshhold", new Vector3(146f, 294f, 170f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1448f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("offsets", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("Team2Score", new Vector3(1793f, 1582f, 1992f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1789f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("<size=25><color=#b50000>" + base.gameObject.name + "Idle");
		}
		BOLEOBOAMBO.renderQueue = 138 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("FurShader: Simulate Movement option enabled on GameObject: '", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_TimeX", new Vector3(500f, 778f, 1967f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1418f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_100()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Intensity", new Vector3(869f, 1452f, 271f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1203f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Mouse Y", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_MainTex2", new Vector3(1358f, 1171f, 104f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 960f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("l" + base.gameObject.name + "Jump");
		}
		BOLEOBOAMBO.renderQueue = 174 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("Joined master server" + base.gameObject.name + "*");
		}
		BOLEOBOAMBO.renderQueue = 196 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_72()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("CameraFilterPack/Blend2Camera_Multiply", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("HeadURL", new Vector3(1697f, 1896f, 1607f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1135f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("CameraFilterPack/Blend2Camera_GreenScreen", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", new Vector3(1655f, 1786f, 1812f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1157f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("Please make sure to assign a view target!" + base.gameObject.name + "MG");
		}
		BOLEOBOAMBO.renderQueue = 100 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log(": " + base.gameObject.name + "_TintColor");
		}
		BOLEOBOAMBO.renderQueue = 118 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log(" " + base.gameObject.name + "HeadURL");
		}
		BOLEOBOAMBO.renderQueue = 77 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_ScreenResolution", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector(",", new Vector3(162f, 384f, 1065f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 379f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("usemtl " + base.gameObject.name + "TDM");
		}
		BOLEOBOAMBO.renderQueue = -8 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector(" is in the lead", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector(",", new Vector3(1717f, 1703f, 1984f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 606f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("Failed on connecting to room" + base.gameObject.name + "box");
		}
		BOLEOBOAMBO.renderQueue = 131 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_99()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Connect", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Value3", new Vector3(1518f, 540f, 1862f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 120f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("window", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("TeamName", new Vector3(845f, 1324f, 1571f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 345f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_98()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_Offsets" + base.gameObject.name + "_ScreenResolution");
		}
		BOLEOBOAMBO.renderQueue = -99 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_ScreenResolution" + base.gameObject.name + "team2");
		}
		BOLEOBOAMBO.renderQueue = 124 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("\"Pose\"", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_TimeX", new Vector3(904f, 300f, 1541f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1409f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Idle", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_TimeX", new Vector3(1195f, 740f, 1009f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1812f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log(": " + base.gameObject.name + "Turn");
		}
		BOLEOBOAMBO.renderQueue = 193 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("Joined master server" + base.gameObject.name + "0.00");
		}
		BOLEOBOAMBO.renderQueue = -70 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Count", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_TimeX", new Vector3(1312f, 1457f, 465f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 339f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_TimeX" + base.gameObject.name + "VS");
		}
		BOLEOBOAMBO.renderQueue = 95 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_ScreenResolution" + base.gameObject.name + "Version");
		}
		BOLEOBOAMBO.renderQueue = 163 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("<color=black>", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Distortion", new Vector3(369f, 1560f, 1008f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 64f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void Update()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("_Velocity", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("_Velocity", new Vector3(0f, 0f, 0f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 2f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("DoDamage" + base.gameObject.name + "_Red_B");
		}
		BOLEOBOAMBO.renderQueue = 15 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("_TimeX" + base.gameObject.name + "Death");
		}
		BOLEOBOAMBO.renderQueue = -160 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("Game Mode", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("\\Google\\g65KYJszcHtFhpDC", new Vector3(1932f, 677f, 1306f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 221f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (!GetComponent<Rigidbody>().Equals(null))
		{
			BEMCEEHJHPL = GetComponent<Rigidbody>();
		}
		else if (GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			Debug.Log("B" + base.gameObject.name + "Connect");
		}
		BOLEOBOAMBO.renderQueue = -149 + GGBMFCBBCBH;
		PMGJGLIHBBB = Camera.main;
		NHNJHDGBOLE = GetComponent<MeshFilter>().mesh;
		PPMMNBGJNCP = NHNJHDGBOLE.bounds;
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (!GetComponent<Rigidbody>().Equals(null) && HONNGDNGPCA)
		{
			BOLEOBOAMBO.SetVector("n4", base.transform.InverseTransformDirection(BEMCEEHJHPL.velocity));
		}
		else
		{
			BOLEOBOAMBO.SetVector("-batchmode", new Vector3(1950f, 823f, 1237f));
		}
		if (LALBCLKBLHA)
		{
			Vector3 position = PMGJGLIHBBB.transform.position;
			Vector3 vector = Vector3.Normalize(PMGJGLIHBBB.transform.forward);
			float num = (PMGJGLIHBBB.farClipPlane - PMGJGLIHBBB.nearClipPlane) / 1120f + PMGJGLIHBBB.nearClipPlane;
			Vector3 position2 = position + vector * num;
			Vector3 center = base.transform.InverseTransformPoint(position2);
			NHNJHDGBOLE.bounds = new Bounds(center, Vector3.one);
		}
		else
		{
			NHNJHDGBOLE.bounds = PPMMNBGJNCP;
		}
	}
}
