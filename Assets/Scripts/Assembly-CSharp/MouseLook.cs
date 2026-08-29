using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook : MonoBehaviour
{
	public enum LCBGHDDCHFJ
	{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	public LCBGHDDCHFJ ONGNICDKGDF;

	public float NFAMBKFCFBP = 15f;

	public float AGIHKOFEBOE = 15f;

	public float CDIAAEGFAGP = -360f;

	public float AFCJGPHPDCC = 360f;

	public float JDCHHLIPAAA = -60f;

	public float MEEBBBDLLEH = 60f;

	private float MMLCCAILDHF;

	private void __BB_OBFUSCATOR_17()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_CutoutReferenceTexture") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("team1") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 982f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1433f, Input.GetAxis("Fire") * NFAMBKFCFBP, 374f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("Attack") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 99f);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_Distortion") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("Press `F` to pick  |  ") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1109f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1310f, Input.GetAxis("_Value2") * NFAMBKFCFBP, 681f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("_Offsets") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1658f);
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_TimeX") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("<size=15><color=red>") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 735f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(1550f, Input.GetAxis("|") * NFAMBKFCFBP, 1192f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("*") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1363f);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void Update()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("Mouse Y") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 0f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(0f, Input.GetAxis("Mouse X") * NFAMBKFCFBP, 0f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("Mouse Y") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 0f);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("SBX") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("  ") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1598f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(481f, Input.GetAxis("CameraFilterPack/Edge_Golden") * NFAMBKFCFBP, 1532f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("Glow") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 26f);
		}
	}

	private void Start()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_ScreenResolution") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("</size>") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 567f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(79f, Input.GetAxis("_Value5") * NFAMBKFCFBP, 755f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("CameraFilterPack/Distortion_BlackHole") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1739f);
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_ScreenResolution") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("CameraFilterPack/Distortion_Water_Drop") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1929f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(925f, Input.GetAxis("Right") * NFAMBKFCFBP, 646f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("Vertex count: ") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 264f);
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("_TimeX") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("SwearFilter") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 676f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1348f, Input.GetAxis(",") * NFAMBKFCFBP, 1204f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("Fire1") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1723f);
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("offsets") * NFAMBKFCFBP;
			MMLCCAILDHF += Input.GetAxis("_Value") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 153f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1756f, Input.GetAxis("SUR/") * NFAMBKFCFBP, 1362f);
		}
		else
		{
			MMLCCAILDHF += Input.GetAxis("n4") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 598f);
		}
	}
}
