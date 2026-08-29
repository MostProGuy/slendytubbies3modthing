using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
	public Transform POLMJLMPAED;

	public Transform HKLDMDMEJDN;

	public LayerMask NAACHMOFLGF;

	public float EHLONJLDLCM = 2.5f;

	public float AIGANDOLOAH = 1.75f;

	public float GNPGGMIFCOD = 0.65f;

	public float GNKACNJMADM = 0.3f;

	public float BEOIEOIPOIL = 250f;

	public float DPALFOBNALK = 150f;

	public float MIGPOKEHJHD = 0.75f;

	public float OHHDGNGFOHP = -60f;

	public float EOJCALHEJIC = 60f;

	public bool KPPLPAOIMOF = true;

	public bool FKNAMIJOGIC;

	public float KGMGCNKCEPO;

	public float LAACIOEHFCJ;

	private Vector3 KIJIFLAJKPE;

	private Quaternion CMAHMAGGBDP;

	private Quaternion DNCHFCEBKPF;

	private Transform BFJNIENBAIL;

	private float MAAJODMFHNO;

	private void __BB_OBFUSCATOR_57()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("_Value4") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("CameraFilterPack/Blend2Camera_LighterColor") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("Deaths") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_69(KGMGCNKCEPO, 521f, 1865f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_42(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1349f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_56(1701f / MIGPOKEHJHD * 258f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_24();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1722f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1831f, BFJNIENBAIL.eulerAngles.y, 477f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private float __BB_OBFUSCATOR_126(float DBJLMBHEMDG)
	{
		return 927f / (847f + 158f * Mathf.Exp((0f - DBJLMBHEMDG) * 1871f));
	}

	private void __BB_OBFUSCATOR_117()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 713f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_89(float DBJLMBHEMDG)
	{
		return 1627f / (634f + 21f * Mathf.Exp((0f - DBJLMBHEMDG) * 574f));
	}

	private void __BB_OBFUSCATOR_100()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 953f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_116();
	}

	private void Awake()
	{
		MAAJODMFHNO = 1f * (float)ObscuredPrefs.GetInt("Mouse");
		if (MAAJODMFHNO == 0f)
		{
			MAAJODMFHNO = 1f;
		}
		if (MAAJODMFHNO < 0f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 2f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 1f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 1f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_107()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_80();
	}

	private void __BB_OBFUSCATOR_115()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 889f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_52(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 591f)
		{
			AIMMHLDGPGB += 1359f;
		}
		if (AIMMHLDGPGB > 1616f)
		{
			AIMMHLDGPGB -= 844f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("TeamName");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("ChatField");
		}
	}

	private float __BB_OBFUSCATOR_92(float DBJLMBHEMDG)
	{
		return 926f / (849f + 1006f * Mathf.Exp((0f - DBJLMBHEMDG) * 669f));
	}

	private void __BB_OBFUSCATOR_47()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("_diff\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\",") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("_TimeX") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("Username") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_97(KGMGCNKCEPO, 1625f, 566f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_79(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1808f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_56(1350f / MIGPOKEHJHD * 74f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_3();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 533f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(349f, BFJNIENBAIL.eulerAngles.y, 734f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1435f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Room Name: ");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_MotionBlurTmpCam");
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1866f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_111()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 570f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_66();
	}

	private float __BB_OBFUSCATOR_10(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 661f)
		{
			AIMMHLDGPGB += 1451f;
		}
		if (AIMMHLDGPGB > 1380f)
		{
			AIMMHLDGPGB -= 778f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_77()
	{
		MAAJODMFHNO = 310f * (float)ObscuredPrefs.GetInt("_DepthFade");
		if (MAAJODMFHNO == 31f)
		{
			MAAJODMFHNO = 917f;
		}
		if (MAAJODMFHNO < 1000f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1833f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 939f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 1149f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_120();
	}

	private void __BB_OBFUSCATOR_41()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1523f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1910f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_86(float DBJLMBHEMDG)
	{
		return 1636f / (947f + 845f * Mathf.Exp((0f - DBJLMBHEMDG) * 1888f));
	}

	private float __BB_OBFUSCATOR_105(float DBJLMBHEMDG)
	{
		return 1243f / (1062f + 963f * Mathf.Exp((0f - DBJLMBHEMDG) * 1047f));
	}

	private void __BB_OBFUSCATOR_98()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Mouse X");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_BlurredColor");
		}
	}

	private float __BB_OBFUSCATOR_14(float DBJLMBHEMDG)
	{
		return 1831f / (1490f + 1977f * Mathf.Exp((0f - DBJLMBHEMDG) * 693f));
	}

	private void __BB_OBFUSCATOR_28()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 37f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_1()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 809f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_75();
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

	private void Update()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		__BB_OBFUSCATOR_20();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 1365f;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 769f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 646f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_127()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1426f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_120()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("MP");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_Texture");
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		MAAJODMFHNO = 237f * (float)ObscuredPrefs.GetInt("Wave ");
		if (MAAJODMFHNO == 693f)
		{
			MAAJODMFHNO = 788f;
		}
		if (MAAJODMFHNO < 1629f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1433f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 984f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 268f * DPALFOBNALK;
	}

	private float __BB_OBFUSCATOR_69(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1927f)
		{
			AIMMHLDGPGB += 413f;
		}
		if (AIMMHLDGPGB > 1638f)
		{
			AIMMHLDGPGB -= 1250f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_106()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1053f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_79(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1855f)
		{
			AIMMHLDGPGB += 162f;
		}
		if (AIMMHLDGPGB > 82f)
		{
			AIMMHLDGPGB -= 104f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_2()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 923f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_94()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1327f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_122(float DBJLMBHEMDG)
	{
		return 1980f / (531f + 769f * Mathf.Exp((0f - DBJLMBHEMDG) * 958f));
	}

	private void __BB_OBFUSCATOR_60()
	{
		__BB_OBFUSCATOR_109();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 571f;
		}
	}

	private float TimeSignature(float DBJLMBHEMDG)
	{
		return 1f / (1f + 80f * Mathf.Exp((0f - DBJLMBHEMDG) * 0.02f));
	}

	private void __BB_OBFUSCATOR_113()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_116();
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("_Value5");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("DM");
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		__BB_OBFUSCATOR_109();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 801f;
		}
	}

	private void Start()
	{
		Initialize();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 0f;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 375f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("_Blue_G") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("_ScreenResolution") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("_ScreenResolution") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_10(KGMGCNKCEPO, 136f, 178f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_125(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1068f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_85(1578f / MIGPOKEHJHD * 1373f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_106();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1202f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1976f, BFJNIENBAIL.eulerAngles.y, 393f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void OnEnable()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 0f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_96(float DBJLMBHEMDG)
	{
		return 582f / (632f + 169f * Mathf.Exp((0f - DBJLMBHEMDG) * 1469f));
	}

	private void __BB_OBFUSCATOR_48()
	{
		__BB_OBFUSCATOR_74();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 1481f;
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("a");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_Contrast");
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_36();
	}

	private void __BB_OBFUSCATOR_11()
	{
		__BB_OBFUSCATOR_121();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 146f;
		}
	}

	private float __BB_OBFUSCATOR_125(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 482f)
		{
			AIMMHLDGPGB += 780f;
		}
		if (AIMMHLDGPGB > 1217f)
		{
			AIMMHLDGPGB -= 368f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_81()
	{
		MAAJODMFHNO = 1635f * (float)ObscuredPrefs.GetInt("|");
		if (MAAJODMFHNO == 280f)
		{
			MAAJODMFHNO = 1519f;
		}
		if (MAAJODMFHNO < 1998f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 230f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 987f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 634f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_43()
	{
		MAAJODMFHNO = 1841f * (float)ObscuredPrefs.GetInt("Sparks");
		if (MAAJODMFHNO == 473f)
		{
			MAAJODMFHNO = 1207f;
		}
		if (MAAJODMFHNO < 1926f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1863f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 350f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 429f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_87()
	{
		Initialize();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 1239f;
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		MAAJODMFHNO = 1976f * (float)ObscuredPrefs.GetInt("CameraFilterPack/Colors_Brightness");
		if (MAAJODMFHNO == 1106f)
		{
			MAAJODMFHNO = 359f;
		}
		if (MAAJODMFHNO < 979f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 177f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 1383f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 981f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_88()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 884f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_50(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1170f)
		{
			AIMMHLDGPGB += 632f;
		}
		if (AIMMHLDGPGB > 680f)
		{
			AIMMHLDGPGB -= 348f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float __BB_OBFUSCATOR_99(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 392f)
		{
			AIMMHLDGPGB += 1221f;
		}
		if (AIMMHLDGPGB > 1570f)
		{
			AIMMHLDGPGB -= 112f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_82()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("ArmsURL") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("\", \"Cluster\"") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("_Value3") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_97(KGMGCNKCEPO, 270f, 1453f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_50(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1331f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_63(721f / MIGPOKEHJHD * 375f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_31();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1918f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(709f, BFJNIENBAIL.eulerAngles.y, 1633f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("_ScreenResolution") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("_TimeX") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("_Value2") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_17(KGMGCNKCEPO, 929f, 496f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_125(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 89f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_56(1471f / MIGPOKEHJHD * 1706f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_100();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 667f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1361f, BFJNIENBAIL.eulerAngles.y, 139f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_121()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		NullErrorCheck();
	}

	private void __BB_OBFUSCATOR_26()
	{
		MAAJODMFHNO = 1385f * (float)ObscuredPrefs.GetInt("offsets");
		if (MAAJODMFHNO == 1925f)
		{
			MAAJODMFHNO = 1302f;
		}
		if (MAAJODMFHNO < 1196f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 644f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 55f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 551f * DPALFOBNALK;
	}

	private float __BB_OBFUSCATOR_33(float DBJLMBHEMDG)
	{
		return 435f / (86f + 1086f * Mathf.Exp((0f - DBJLMBHEMDG) * 743f));
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (POLMJLMPAED == null)
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("_BorderSize") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("<size=") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("_BlurDirectionPacked") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_91(KGMGCNKCEPO, 517f, 1399f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_97(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1890f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_105(1353f / MIGPOKEHJHD * 679f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_3();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1279f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1037f, BFJNIENBAIL.eulerAngles.y, 1568f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private float __BB_OBFUSCATOR_42(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1886f)
		{
			AIMMHLDGPGB += 915f;
		}
		if (AIMMHLDGPGB > 1988f)
		{
			AIMMHLDGPGB -= 1447f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_13()
	{
		__BB_OBFUSCATOR_30();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 128f;
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Concrete");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_ColorLevel");
		}
	}

	private float __BB_OBFUSCATOR_108(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 293f)
		{
			AIMMHLDGPGB += 1576f;
		}
		if (AIMMHLDGPGB > 264f)
		{
			AIMMHLDGPGB -= 1845f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
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

	private void __BB_OBFUSCATOR_103()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1504f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_114(float DBJLMBHEMDG)
	{
		return 1689f / (1169f + 1319f * Mathf.Exp((0f - DBJLMBHEMDG) * 1063f));
	}

	private void __BB_OBFUSCATOR_124()
	{
		Initialize();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 357f;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		MAAJODMFHNO = 1459f * (float)ObscuredPrefs.GetInt("Default");
		if (MAAJODMFHNO == 1458f)
		{
			MAAJODMFHNO = 59f;
		}
		if (MAAJODMFHNO < 926f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 738f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 1794f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 893f * DPALFOBNALK;
	}

	private void Initialize()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		NullErrorCheck();
	}

	private float __BB_OBFUSCATOR_40(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 242f)
		{
			AIMMHLDGPGB += 1642f;
		}
		if (AIMMHLDGPGB > 37f)
		{
			AIMMHLDGPGB -= 1335f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_90()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 408f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("-batchmode");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning(": ");
		}
	}

	private float __BB_OBFUSCATOR_91(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 567f)
		{
			AIMMHLDGPGB += 375f;
		}
		if (AIMMHLDGPGB > 1563f)
		{
			AIMMHLDGPGB -= 1662f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_65()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("Respawn in") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("_TimeX") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("\"Skin\"") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_10(KGMGCNKCEPO, 1338f, 676f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_97(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 491f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_126(1603f / MIGPOKEHJHD * 516f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_127();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1838f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1062f, BFJNIENBAIL.eulerAngles.y, 88f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		MAAJODMFHNO = 1169f * (float)ObscuredPrefs.GetInt("_Green_B");
		if (MAAJODMFHNO == 1075f)
		{
			MAAJODMFHNO = 572f;
		}
		if (MAAJODMFHNO < 515f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 834f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 490f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 1940f * DPALFOBNALK;
	}

	private float __BB_OBFUSCATOR_17(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1949f)
		{
			AIMMHLDGPGB += 1306f;
		}
		if (AIMMHLDGPGB > 1105f)
		{
			AIMMHLDGPGB -= 1467f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_19()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 972f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		MAAJODMFHNO = 558f * (float)ObscuredPrefs.GetInt("SwearFilter");
		if (MAAJODMFHNO == 396f)
		{
			MAAJODMFHNO = 699f;
		}
		if (MAAJODMFHNO < 1163f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1167f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 503f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 1166f * DPALFOBNALK;
	}

	private void __BB_OBFUSCATOR_118()
	{
		MAAJODMFHNO = 1633f * (float)ObscuredPrefs.GetInt("_Distortion");
		if (MAAJODMFHNO == 1181f)
		{
			MAAJODMFHNO = 217f;
		}
		if (MAAJODMFHNO < 695f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1316f / MAAJODMFHNO;
		}
		BEOIEOIPOIL = MAAJODMFHNO * 411f * BEOIEOIPOIL;
		DPALFOBNALK = MAAJODMFHNO * 1395f * DPALFOBNALK;
	}

	private float __BB_OBFUSCATOR_34(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 608f)
		{
			AIMMHLDGPGB += 1096f;
		}
		if (AIMMHLDGPGB > 1196f)
		{
			AIMMHLDGPGB -= 813f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private float __BB_OBFUSCATOR_85(float DBJLMBHEMDG)
	{
		return 5f / (835f + 339f * Mathf.Exp((0f - DBJLMBHEMDG) * 1466f));
	}

	private void CheckSphere()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 0.3f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("{0} FPS");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Crouch");
		}
	}

	private float __BB_OBFUSCATOR_63(float DBJLMBHEMDG)
	{
		return 1764f / (1903f + 1605f * Mathf.Exp((0f - DBJLMBHEMDG) * 868f));
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError(" registered.");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("_Value4");
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_36();
	}

	private void __BB_OBFUSCATOR_0()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1996f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_104()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("|");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("UnlockButton/Button");
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("\", \"Model::");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("Untagged");
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		__BB_OBFUSCATOR_12();
		if (base.transform.parent != null && !KPPLPAOIMOF)
		{
			base.transform.parent = null;
		}
		if (!KPPLPAOIMOF)
		{
			MIGPOKEHJHD = 1584f;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("_TimeX");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("\n\t\tLayerElementSmoothing: 0 {\n\t\t\tVersion: 102\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tSmoothing: 1\n\t\t}");
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 306f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private float __BB_OBFUSCATOR_56(float DBJLMBHEMDG)
	{
		return 1346f / (1205f + 382f * Mathf.Exp((0f - DBJLMBHEMDG) * 1740f));
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_27();
	}

	private void LateUpdate()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("Menu") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("Mouse X") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("Mouse Y") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = ClampAngle(KGMGCNKCEPO, -360f, 360f);
			LAACIOEHFCJ = ClampAngle(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 0f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, TimeSignature(1f / MIGPOKEHJHD * 100f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			CheckSphere();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 0f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(0f, BFJNIENBAIL.eulerAngles.y, 0f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1390f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private void __BB_OBFUSCATOR_72()
	{
		if ((bool)POLMJLMPAED && !(GameObject.FindGameObjectWithTag("Chat Operation {0} unknown on server. Check your AppId and make sure it's for a Chat application.") != null))
		{
			KGMGCNKCEPO += Input.GetAxis("><color=red>") * (BEOIEOIPOIL * Time.deltaTime);
			LAACIOEHFCJ -= Input.GetAxis("_Value2") * (DPALFOBNALK * Time.deltaTime);
			KGMGCNKCEPO = __BB_OBFUSCATOR_91(KGMGCNKCEPO, 1589f, 1567f);
			LAACIOEHFCJ = __BB_OBFUSCATOR_99(LAACIOEHFCJ, OHHDGNGFOHP, EOJCALHEJIC);
			CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1269f);
			DNCHFCEBKPF = Quaternion.Slerp(DNCHFCEBKPF, CMAHMAGGBDP, __BB_OBFUSCATOR_86(1619f / MIGPOKEHJHD * 391f));
			KIJIFLAJKPE = POLMJLMPAED.position;
			KIJIFLAJKPE += DNCHFCEBKPF * new Vector3(GNPGGMIFCOD, AIGANDOLOAH, 0f - EHLONJLDLCM);
			__BB_OBFUSCATOR_3();
			DNCHFCEBKPF.eulerAngles = new Vector3(DNCHFCEBKPF.eulerAngles.x, DNCHFCEBKPF.eulerAngles.y, 1572f);
			BFJNIENBAIL.position = KIJIFLAJKPE;
			BFJNIENBAIL.rotation = DNCHFCEBKPF;
			Vector3 euler = new Vector3(1771f, BFJNIENBAIL.eulerAngles.y, 1013f);
			if (KPPLPAOIMOF)
			{
				POLMJLMPAED.rotation = Quaternion.Euler(euler);
			}
			euler = HKLDMDMEJDN.eulerAngles;
			if (FKNAMIJOGIC)
			{
				euler.x = BFJNIENBAIL.eulerAngles.x;
			}
			else
			{
				euler.x = 0f - BFJNIENBAIL.eulerAngles.x;
			}
			HKLDMDMEJDN.rotation = Quaternion.Euler(euler);
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1321f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (!POLMJLMPAED)
		{
			Debug.LogError("Transform");
			Debug.Break();
		}
		if ((int)NAACHMOFLGF == 0)
		{
			Debug.LogWarning("COOP");
		}
	}

	private void __BB_OBFUSCATOR_123()
	{
		if (!KPPLPAOIMOF)
		{
			KGMGCNKCEPO = POLMJLMPAED.transform.eulerAngles.y;
			LAACIOEHFCJ = POLMJLMPAED.transform.eulerAngles.x;
		}
		BFJNIENBAIL = base.transform;
		__BB_OBFUSCATOR_36();
	}

	private void __BB_OBFUSCATOR_18()
	{
		CMAHMAGGBDP = Quaternion.Euler(LAACIOEHFCJ, KGMGCNKCEPO, 1228f);
		DNCHFCEBKPF = CMAHMAGGBDP;
	}

	private float __BB_OBFUSCATOR_97(float AIMMHLDGPGB, float IOHIAGADLCA, float NACNBLICIKB)
	{
		if (AIMMHLDGPGB < 1259f)
		{
			AIMMHLDGPGB += 343f;
		}
		if (AIMMHLDGPGB > 1949f)
		{
			AIMMHLDGPGB -= 1630f;
		}
		return Mathf.Clamp(AIMMHLDGPGB, IOHIAGADLCA, NACNBLICIKB);
	}

	private void __BB_OBFUSCATOR_24()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 1218f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		Vector3 position = POLMJLMPAED.position;
		position.x += GNPGGMIFCOD;
		position.y += AIGANDOLOAH;
		Vector3 normalized = (KIJIFLAJKPE - position).normalized;
		RaycastHit hitInfo;
		if (Physics.SphereCast(position, 463f, normalized, out hitInfo, EHLONJLDLCM, NAACHMOFLGF))
		{
			KIJIFLAJKPE = hitInfo.point + hitInfo.normal * GNKACNJMADM;
		}
	}
}
