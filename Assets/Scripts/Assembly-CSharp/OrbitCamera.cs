using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
	public Transform POLMJLMPAED;

	public LayerMask NAACHMOFLGF;

	public float EHLONJLDLCM = 6f;

	public float AIHOHJAHPDN = 150f;

	public float GNKACNJMADM = 0.3f;

	public float FHOKKBBNCGN = 4f;

	public float JGMGOJPEKEK = 12f;

	public float AIGANDOLOAH = 1.5f;

	public float BEOIEOIPOIL = 250f;

	public float DPALFOBNALK = 150f;

	public float MIGPOKEHJHD = 0.75f;

	public float OHHDGNGFOHP = -60f;

	public float EOJCALHEJIC = 60f;

	public bool IHJKDGIGCDJ;

	private float KGMGCNKCEPO;

	private float LAACIOEHFCJ;

	private float GEGOGMBHEEP;

	private float AGPFJGEFJNO;

	private Vector3 KIJIFLAJKPE;

	private Quaternion CMAHMAGGBDP;

	private Quaternion DNCHFCEBKPF;

	private Transform BFJNIENBAIL;

	private void __BB_OBFUSCATOR_56()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_73();
	}

	private float __BB_OBFUSCATOR_70(float DBJLMBHEMDG)
	{
		return 916f / (922f + 577f * Mathf.Exp((0f - DBJLMBHEMDG) * 1129f));
	}

	private float __BB_OBFUSCATOR_32(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 724f)
		{
			AIMMHLDGPGB += 1884f;
		}
		if (AIMMHLDGPGB > 145f)
		{
			AIMMHLDGPGB -= 1840f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 481f)
			{
				KGMGCNKCEPO += Input.GetAxis("<size=") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("box") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_20(KGMGCNKCEPO, 1331f, 1506f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_13(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1983f);
		}
		else if (Input.GetMouseButton(0))
		{
			if (Time.timeScale > 1763f)
			{
				KGMGCNKCEPO += Input.GetAxis("_Blue_R") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Remote") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_63(KGMGCNKCEPO, 1006f, 748f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_13(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 85f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("_ScreenResolution") * 1742f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_70(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_23(466f / MIGPOKEHJHD * 1644f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(293f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_31();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 18f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private void __BB_OBFUSCATOR_25()
	{
		__BB_OBFUSCATOR_8();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		__BB_OBFUSCATOR_21();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_71();
	}

	private float __BB_OBFUSCATOR_6(float DBJLMBHEMDG)
	{
		return 1559f / (34f + 552f * Mathf.Exp((0f - DBJLMBHEMDG) * 1138f));
	}

	private float __BB_OBFUSCATOR_20(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 55f)
		{
			AIMMHLDGPGB += 1122f;
		}
		if (AIMMHLDGPGB > 1989f)
		{
			AIMMHLDGPGB -= 1037f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float __BB_OBFUSCATOR_47(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 955f)
		{
			AIMMHLDGPGB += 726f;
		}
		if (AIMMHLDGPGB > 1549f)
		{
			AIMMHLDGPGB -= 1598f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void Initialize()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		NullErrorCheck();
	}

	private void CheckSphere()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 0.3f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_35(float DBJLMBHEMDG)
	{
		return 1581f / (220f + 27f * Mathf.Exp((0f - DBJLMBHEMDG) * 558f));
	}

	private float __BB_OBFUSCATOR_2(float DBJLMBHEMDG)
	{
		return 626f / (852f + 940f * Mathf.Exp((0f - DBJLMBHEMDG) * 1505f));
	}

	private float __BB_OBFUSCATOR_63(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1326f)
		{
			AIMMHLDGPGB += 1448f;
		}
		if (AIMMHLDGPGB > 1595f)
		{
			AIMMHLDGPGB -= 988f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 1176f)
			{
				KGMGCNKCEPO += Input.GetAxis("Attack") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_Texture") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_41(KGMGCNKCEPO, 327f, 1798f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_51(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1720f);
		}
		else if (Input.GetMouseButton(1))
		{
			if (Time.timeScale > 340f)
			{
				KGMGCNKCEPO += Input.GetAxis(", 2: ") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Ammo") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_20(KGMGCNKCEPO, 319f, 1898f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_15(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 697f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("custardPos") * 670f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_53(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_49(1891f / MIGPOKEHJHD * 1058f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(378f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_4();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 544f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_ColorBurn");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_Value");
		}
	}

	private float __BB_OBFUSCATOR_53(float DBJLMBHEMDG)
	{
		return 1250f / (811f + 423f * Mathf.Exp((0f - DBJLMBHEMDG) * 847f));
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("_Intensity");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_Value");
		}
	}

	private float ClampAngle(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < -360f)
		{
			AIMMHLDGPGB += 360f;
		}
		if (AIMMHLDGPGB > 360f)
		{
			AIMMHLDGPGB -= 360f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_12()
	{
		__BB_OBFUSCATOR_21();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private float __BB_OBFUSCATOR_1(float DBJLMBHEMDG)
	{
		return 99f / (1930f + 1026f * Mathf.Exp((0f - DBJLMBHEMDG) * 399f));
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("CameraFilterPack/Gradients_Tech");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Prev");
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1584f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_14(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 256f)
		{
			AIMMHLDGPGB += 796f;
		}
		if (AIMMHLDGPGB > 453f)
		{
			AIMMHLDGPGB -= 1348f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_19()
	{
		__BB_OBFUSCATOR_45();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private float __BB_OBFUSCATOR_13(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 612f)
		{
			AIMMHLDGPGB += 268f;
		}
		if (AIMMHLDGPGB > 1817f)
		{
			AIMMHLDGPGB -= 586f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float __BB_OBFUSCATOR_15(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 650f)
		{
			AIMMHLDGPGB += 1176f;
		}
		if (AIMMHLDGPGB > 1253f)
		{
			AIMMHLDGPGB -= 868f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_46()
	{
		__BB_OBFUSCATOR_43();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		__BB_OBFUSCATOR_68();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_64()
	{
		__BB_OBFUSCATOR_68();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void LateUpdate()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 0f)
			{
				KGMGCNKCEPO += Input.GetAxis("Mouse X") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Mouse Y") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = ClampAngle(KGMGCNKCEPO, -360f, 360f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 0f);
		}
		else if (Input.GetMouseButton(1))
		{
			if (Time.timeScale > 0f)
			{
				KGMGCNKCEPO += Input.GetAxis("Mouse X") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Mouse Y") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = ClampAngle(KGMGCNKCEPO, -360f, 360f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 0f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("Mouse ScrollWheel") * 10f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, TimeSignature(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, TimeSignature(1f / MIGPOKEHJHD * 100f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(0f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		CheckSphere();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 0f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private void __BB_OBFUSCATOR_66()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_33();
	}

	private void __BB_OBFUSCATOR_38()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1767f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("<size=");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Toast");
		}
	}

	private float __BB_OBFUSCATOR_26(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 487f)
		{
			AIMMHLDGPGB += 1389f;
		}
		if (AIMMHLDGPGB > 67f)
		{
			AIMMHLDGPGB -= 115f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_4()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 693f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_11(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 493f)
		{
			AIMMHLDGPGB += 879f;
		}
		if (AIMMHLDGPGB > 1886f)
		{
			AIMMHLDGPGB -= 1235f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float __BB_OBFUSCATOR_50(float DBJLMBHEMDG)
	{
		return 838f / (1438f + 1905f * Mathf.Exp((0f - DBJLMBHEMDG) * 1393f));
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 1755f)
			{
				KGMGCNKCEPO += Input.GetAxis("CameraFilterPack/TV_CompressionFX") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("SBX") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_15(KGMGCNKCEPO, 891f, 1796f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 837f);
		}
		else if (Input.GetMouseButton(1))
		{
			if (Time.timeScale > 669f)
			{
				KGMGCNKCEPO += Input.GetAxis("MP") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_TimeX") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_32(KGMGCNKCEPO, 1247f, 1415f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_13(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1754f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("_TimeX") * 281f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_30(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_49(170f / MIGPOKEHJHD * 1600f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(408f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_58();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 33f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private void __BB_OBFUSCATOR_8()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_17()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_69();
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 1710f)
			{
				KGMGCNKCEPO += Input.GetAxis("ShopBox/Scrollbar") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_ScreenResolution") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_47(KGMGCNKCEPO, 362f, 68f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_15(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1050f);
		}
		else if (Input.GetMouseButton(1))
		{
			if (Time.timeScale > 1311f)
			{
				KGMGCNKCEPO += Input.GetAxis("We disconencted from Photon Cloud") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Select model:") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_47(KGMGCNKCEPO, 1133f, 595f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_13(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 954f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("_Distortion") * 1028f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, TimeSignature(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_50(99f / MIGPOKEHJHD * 756f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(34f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_67();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 41f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private void __BB_OBFUSCATOR_31()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 940f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void Start()
	{
		Initialize();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1681f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_51(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 151f)
		{
			AIMMHLDGPGB += 805f;
		}
		if (AIMMHLDGPGB > 860f)
		{
			AIMMHLDGPGB -= 205f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 426f)
			{
				KGMGCNKCEPO += Input.GetAxis("_Contrast") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_Value3") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_14(KGMGCNKCEPO, 809f, 112f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_32(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1888f);
		}
		else if (Input.GetMouseButton(0))
		{
			if (Time.timeScale > 904f)
			{
				KGMGCNKCEPO += Input.GetAxis("Vertical") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis(", attributes = ") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_51(KGMGCNKCEPO, 230f, 842f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_13(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1404f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("Language") * 1230f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, TimeSignature(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_35(1716f / MIGPOKEHJHD * 21f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(1395f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_72();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 885f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private float __BB_OBFUSCATOR_41(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1359f)
		{
			AIMMHLDGPGB += 1946f;
		}
		if (AIMMHLDGPGB > 361f)
		{
			AIMMHLDGPGB -= 16f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float TimeSignature(float DBJLMBHEMDG)
	{
		return 1f / (1f + 80f * Mathf.Exp((0f - DBJLMBHEMDG) * 0.02f));
	}

	private void __BB_OBFUSCATOR_45()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		__BB_OBFUSCATOR_69();
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Mouse Y");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Show Ground");
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("controller4");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_CutTex");
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 578f)
			{
				KGMGCNKCEPO += Input.GetAxis("Left Stick Up") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_InvRenderTargetSize") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = ClampAngle(KGMGCNKCEPO, 1628f, 643f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 6f);
		}
		else if (Input.GetMouseButton(0))
		{
			if (Time.timeScale > 1060f)
			{
				KGMGCNKCEPO += Input.GetAxis("_ScreenResolution") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("TenkokuModule") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_41(KGMGCNKCEPO, 1914f, 1111f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_5(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 354f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("offsets") * 1463f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_23(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_6(84f / MIGPOKEHJHD * 1812f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(1577f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_38();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 610f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private float __BB_OBFUSCATOR_3(float DBJLMBHEMDG)
	{
		return 1928f / (1838f + 1113f * Mathf.Exp((0f - DBJLMBHEMDG) * 881f));
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("CO-OP");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("s");
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		KGMGCNKCEPO = base.transform.eulerAngles.x;
		LAACIOEHFCJ = base.transform.eulerAngles.y;
		BFJNIENBAIL = base.transform;
		AGPFJGEFJNO = EHLONJLDLCM;
		NullErrorCheck();
	}

	private void __BB_OBFUSCATOR_67()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 975f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		Vector3 position = POLMJLMPAED.position;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1908f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void NullErrorCheck()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Please make sure to assign a view target!");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Make sure to set the collision layers to the layers the camera should collide with!");
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 1355f)
			{
				KGMGCNKCEPO += Input.GetAxis("</size>") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_Distortion") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_63(KGMGCNKCEPO, 438f, 679f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1966f);
		}
		else if (Input.GetMouseButton(0))
		{
			if (Time.timeScale > 3f)
			{
				KGMGCNKCEPO += Input.GetAxis("_NormalTex") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("Running") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_51(KGMGCNKCEPO, 1957f, 1723f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_47(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 788f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("_Value") * 374f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_53(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_35(1827f / MIGPOKEHJHD * 307f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(1909f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_72();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1765f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private float __BB_OBFUSCATOR_5(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1506f)
		{
			AIMMHLDGPGB += 797f;
		}
		if (AIMMHLDGPGB > 1750f)
		{
			AIMMHLDGPGB -= 1037f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 759f)
			{
				KGMGCNKCEPO += Input.GetAxis("TDM") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_Greenness") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_47(KGMGCNKCEPO, 1509f, 1330f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 964f);
		}
		else if (Input.GetMouseButton(1))
		{
			if (Time.timeScale > 433f)
			{
				KGMGCNKCEPO += Input.GetAxis("9") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("_ColorBuffer") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_32(KGMGCNKCEPO, 1804f, 568f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_26(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 715f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("Unsubscribe can't be called for empty or null channels-list.") * 733f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_36(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_23(40f / MIGPOKEHJHD * 1005f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(33f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_67();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1335f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private float __BB_OBFUSCATOR_49(float DBJLMBHEMDG)
	{
		return 1f / (909f + 1077f * Mathf.Exp((0f - DBJLMBHEMDG) * 1018f));
	}

	private float __BB_OBFUSCATOR_36(float DBJLMBHEMDG)
	{
		return 1373f / (924f + 1879f * Mathf.Exp((0f - DBJLMBHEMDG) * 664f));
	}

	private float __BB_OBFUSCATOR_18(float DBJLMBHEMDG)
	{
		return 1380f / (398f + 594f * Mathf.Exp((0f - DBJLMBHEMDG) * 587f));
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (!POLMJLMPAED)
		{
			return;
		}
		if (!IHJKDGIGCDJ)
		{
			if (Time.timeScale > 190f)
			{
				KGMGCNKCEPO += Input.GetAxis("Failed on connecting to room") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("offsets") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_32(KGMGCNKCEPO, 498f, 1755f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_51(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1833f);
		}
		else if (Input.GetMouseButton(0))
		{
			if (Time.timeScale > 176f)
			{
				KGMGCNKCEPO += Input.GetAxis("<size=") * BEOIEOIPOIL * Time.deltaTime;
			}
			LAACIOEHFCJ -= Input.GetAxis("State2") * DPALFOBNALK * Time.deltaTime;
			KGMGCNKCEPO = __BB_OBFUSCATOR_32(KGMGCNKCEPO, 1953f, 180f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_41(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1470f);
		}
		EHLONJLDLCM = Mathf.Clamp(EHLONJLDLCM - Input.GetAxis("Can't authenticate on front end server. Secret is not set") * 22f, FHOKKBBNCGN, JGMGOJPEKEK);
		AGPFJGEFJNO = Mathf.Lerp(AGPFJGEFJNO, EHLONJLDLCM, __BB_OBFUSCATOR_3(AIHOHJAHPDN));
		DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_1(294f / MIGPOKEHJHD * 1023f));
		KIJIFLAJKPE = POLMJLMPAED.position;
		KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(1703f, AIGANDOLOAH, 0f - AGPFJGEFJNO);
		__BB_OBFUSCATOR_58();
		DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 54f);
		BFJNIENBAIL.position = KIJIFLAJKPE;
		BFJNIENBAIL.rotation = DNCHFCEBKPF;
	}

	private float __BB_OBFUSCATOR_23(float DBJLMBHEMDG)
	{
		return 329f / (260f + 285f * Mathf.Exp((0f - DBJLMBHEMDG) * 1829f));
	}

	private float __BB_OBFUSCATOR_27(float DBJLMBHEMDG)
	{
		return 208f / (1234f + 669f * Mathf.Exp((0f - DBJLMBHEMDG) * 356f));
	}

	private void __BB_OBFUSCATOR_10()
	{
		__BB_OBFUSCATOR_66();
		if (base.transform.parent != null)
		{
			base.transform.parent = null;
		}
	}

	private float __BB_OBFUSCATOR_30(float DBJLMBHEMDG)
	{
		return 1282f / (1350f + 1620f * Mathf.Exp((0f - DBJLMBHEMDG) * 1985f));
	}
}
