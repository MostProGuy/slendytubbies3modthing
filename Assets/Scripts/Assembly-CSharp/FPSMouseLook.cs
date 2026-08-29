using CodeStage.AntiCheat.ObscuredTypes;
using InControl.mod;
using UnityEngine;

public class FPSMouseLook : MonoBehaviour
{
	public enum LCBGHDDCHFJ
	{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	public LCBGHDDCHFJ ONGNICDKGDF;

	private float KFNNDHLFDHD = 85f;

	private float DEBDGENOOGF = 50f;

	private float NFAMBKFCFBP = 3.5f;

	private float AGIHKOFEBOE = 3.5f;

	public float JDCHHLIPAAA = -80f;

	public float MEEBBBDLLEH = 80f;

	private float MMLCCAILDHF;

	public bool JACLFEDHAII;

	public bool CCBDLBPKHLP;

	private WeaponManager NDDBPJELPMC;

	private WeaponScript BCGHCDKOGFJ;

	[HideInInspector]
	public float AJEPCFDIIFN;

	private float MAAJODMFHNO;

	public int FPKEGEADACE = 6;

	public int MFIBFMBNCLM = 12;

	private void __BB_OBFUSCATOR_74()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_Offsets", 11f);
			float axis2 = cInput.GetAxis("_RedAmplifier", 464f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Value3"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 208f));
		}
		if (Time.timeScale < 1213f || GameObject.FindGameObjectWithTag("_TimeX") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("TeamName", 1641f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("_ScreenResolution", 1293f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1440f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(1935f, cInput.GetAxis("MP", 340f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1913f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("State2", 1798f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 530f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "intensity")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1613f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_42(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_35(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_68(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1729f * (float)ObscuredPrefs.GetInt("CameraFilterPack/Gradients_NeonGradient");
		if (MAAJODMFHNO == 275f)
		{
			MAAJODMFHNO = 1140f;
		}
		if (MAAJODMFHNO < 1235f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1704f / MAAJODMFHNO;
		}
	}

	public void __BB_OBFUSCATOR_20(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_13(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_59(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void Recoil(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("\t\t}\n", 140f);
			float axis2 = cInput.GetAxis("-Blend Weight: ", 128f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("team1"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1409f));
		}
		if (Time.timeScale < 1022f || GameObject.FindGameObjectWithTag("Recommended Players") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("_Distance", 1775f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("_ScreenResolution", 1448f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1113f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1337f, cInput.GetAxis("-Times Played: ", 1980f) * NFAMBKFCFBP * Time.smoothDeltaTime, 58f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("GameMode", 386f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1006f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "ForceDamage")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1960f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_79(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_1(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("</size>", 1430f);
			float axis2 = cInput.GetAxis("HatID", 1310f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Value2"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1805f));
		}
		if (Time.timeScale < 1648f || GameObject.FindGameObjectWithTag("Authentication request error: ") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("SUR", 1006f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis(", 2: ", 1015f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1197f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(116f, cInput.GetAxis("Difficulty", 882f) * NFAMBKFCFBP * Time.smoothDeltaTime, 261f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_FoamContrast", 1241f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 312f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "RangedAttack")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 422f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1199f * (float)ObscuredPrefs.GetInt("3");
		if (MAAJODMFHNO == 1364f)
		{
			MAAJODMFHNO = 50f;
		}
		if (MAAJODMFHNO < 1682f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1706f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_Value3", 843f);
			float axis2 = cInput.GetAxis("Prone", 337f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Value"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1863f));
		}
		if (Time.timeScale < 446f || GameObject.FindGameObjectWithTag("_ScreenResolution") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("CameraFilterPack_OldFilm2", 156f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("</size>", 55f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 737f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(315f, cInput.GetAxis("\tMaterial: \"Material::", 596f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1284f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("<size=", 1787f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1164f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "MP")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 805f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("</size>", 909f);
			float axis2 = cInput.GetAxis("Connected! Creating Room...", 1626f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("ws://{0}:{1}"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 284f));
		}
		if (Time.timeScale < 186f || GameObject.FindGameObjectWithTag("mouse y") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("_Bullet_12", 1399f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("KickPlayer", 1830f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 897f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(616f, cInput.GetAxis(">", 1963f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1223f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_ScreenResolution", 1794f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 187f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_Distortion")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 441f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("deselectWeapon", 1183f);
			float axis2 = cInput.GetAxis("_Bullet_11", 270f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Value"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1806f));
		}
		if (Time.timeScale < 855f || GameObject.FindGameObjectWithTag("TeamName") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("ServerType", 1801f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Simplifying mesh: ", 1115f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 618f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(191f, cInput.GetAxis("Particles/Additive", 782f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1887f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_EdgeWeight", 1784f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1849f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_Value3")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 883f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1701f * (float)ObscuredPrefs.GetInt("_Blue_G");
		if (MAAJODMFHNO == 11f)
		{
			MAAJODMFHNO = 671f;
		}
		if (MAAJODMFHNO < 1860f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 924f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis(": ", 762f);
			float axis2 = cInput.GetAxis("</size>", 309f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Value5"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 711f));
		}
		if (Time.timeScale < 1247f || GameObject.FindGameObjectWithTag("_NormalTex") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("100", 399f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("_Value6", 1104f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1001f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(804f, cInput.GetAxis("Particles/Additive", 280f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1464f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_Value4", 569f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1827f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_TimeX")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 505f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_47(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_62(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_SunPosition", 1768f);
			float axis2 = cInput.GetAxis("\"", 11f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("TeamBSpawn"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1674f));
		}
		if (Time.timeScale < 1381f || GameObject.FindGameObjectWithTag("_HeightParams") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("CameraFilterPack/TV_80", 27f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Left Stick Left", 34f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1701f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1150f, cInput.GetAxis("DoDamage", 1468f) * NFAMBKFCFBP * Time.smoothDeltaTime, 261f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("Death", 1599f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 643f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_ScreenResolution")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1630f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_50(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 749f * (float)ObscuredPrefs.GetInt("_ScreenResolution");
		if (MAAJODMFHNO == 1436f)
		{
			MAAJODMFHNO = 1662f;
		}
		if (MAAJODMFHNO < 445f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1406f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 973f * (float)ObscuredPrefs.GetInt("\"");
		if (MAAJODMFHNO == 1495f)
		{
			MAAJODMFHNO = 1042f;
		}
		if (MAAJODMFHNO < 1720f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1930f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1251f * (float)ObscuredPrefs.GetInt("\", \"SubDeformer::Cluster ");
		if (MAAJODMFHNO == 1418f)
		{
			MAAJODMFHNO = 642f;
		}
		if (MAAJODMFHNO < 1846f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1142f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 681f * (float)ObscuredPrefs.GetInt("SUR");
		if (MAAJODMFHNO == 1269f)
		{
			MAAJODMFHNO = 1938f;
		}
		if (MAAJODMFHNO < 402f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 753f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1358f * (float)ObscuredPrefs.GetInt("Player Name: ");
		if (MAAJODMFHNO == 150f)
		{
			MAAJODMFHNO = 1364f;
		}
		if (MAAJODMFHNO < 1355f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1537f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 705f * (float)ObscuredPrefs.GetInt("Buy");
		if (MAAJODMFHNO == 1816f)
		{
			MAAJODMFHNO = 1580f;
		}
		if (MAAJODMFHNO < 1155f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 888f / MAAJODMFHNO;
		}
	}

	private void Update()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("Vertical");
			float axis2 = cInput.GetAxis("Horizontal");
			int num = FPKEGEADACE;
			if (cInput.GetButton("Run"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1.5f));
		}
		if (Time.timeScale < 0.01f || GameObject.FindGameObjectWithTag("Menu") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("Mouse X") * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Mouse Y") * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 0f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(0f, cInput.GetAxis("Mouse X") * NFAMBKFCFBP * Time.smoothDeltaTime, 0f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("Mouse Y") * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 0f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "Camera")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 3.5f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_8(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 576f * (float)ObscuredPrefs.GetInt("_Value");
		if (MAAJODMFHNO == 85f)
		{
			MAAJODMFHNO = 1665f;
		}
		if (MAAJODMFHNO < 1401f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1497f / MAAJODMFHNO;
		}
	}

	public void __BB_OBFUSCATOR_12(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_41(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	public void __BB_OBFUSCATOR_37(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 457f * (float)ObscuredPrefs.GetInt("_TimeX");
		if (MAAJODMFHNO == 1879f)
		{
			MAAJODMFHNO = 775f;
		}
		if (MAAJODMFHNO < 461f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1586f / MAAJODMFHNO;
		}
	}

	public void __BB_OBFUSCATOR_18(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("!!!", 304f);
			float axis2 = cInput.GetAxis(",", 748f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("An animation with the name '"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 49f));
		}
		if (Time.timeScale < 1658f || GameObject.FindGameObjectWithTag("_Skybox") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("Custards", 718f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("CameraFilterPack/FX_Screens", 1965f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1635f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(431f, cInput.GetAxis("Ping: ", 908f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1438f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("\", \"Model::", 1245f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1371f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_InvRenderTargetSize")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1214f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_70()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1536f * (float)ObscuredPrefs.GetInt("_MainTex2");
		if (MAAJODMFHNO == 655f)
		{
			MAAJODMFHNO = 1300f;
		}
		if (MAAJODMFHNO < 985f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 608f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("Idle", 1709f);
			float axis2 = cInput.GetAxis("_Value", 1590f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("-Vertical"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1411f));
		}
		if (Time.timeScale < 1012f || GameObject.FindGameObjectWithTag("\\s3key.txt") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("CameraFilterPack/Blend2Camera_Saturation", 1448f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("\t\t\tMatrix: ", 759f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 920f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(669f, cInput.GetAxis("COOP", 1995f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1490f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("__MirrorReflection", 1505f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 496f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "AddFriends can't be called for empty or null list.")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 485f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_53(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("Shop", 1295f);
			float axis2 = cInput.GetAxis("Right Stick Up", 1525f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("red"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1313f));
		}
		if (Time.timeScale < 362f || GameObject.FindGameObjectWithTag("a") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("_ScreenResolution", 1883f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Label", 1147f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1045f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(1375f, cInput.GetAxis("MP", 623f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1998f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("box", 1069f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1900f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "team2")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 894f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_48(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_ScreenResolution", 110f);
			float axis2 = cInput.GetAxis("SoftBody", 955f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("</size>"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 668f));
		}
		if (Time.timeScale < 523f || GameObject.FindGameObjectWithTag("Flicker") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("Label2", 321f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("SBX", 1705f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1438f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1330f, cInput.GetAxis("Difficulty", 950f) * NFAMBKFCFBP * Time.smoothDeltaTime, 466f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("MP", 1823f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1920f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "VS")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 545f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 638f * (float)ObscuredPrefs.GetInt("Ping");
		if (MAAJODMFHNO == 424f)
		{
			MAAJODMFHNO = 735f;
		}
		if (MAAJODMFHNO < 1417f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 1004f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_NoisePerChannel", 1438f);
			float axis2 = cInput.GetAxis("Deaths", 1392f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("ZWName'"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 727f));
		}
		if (Time.timeScale < 875f || GameObject.FindGameObjectWithTag("PlayerName") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("Deaths", 1717f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("_ProjMatrix", 1174f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 104f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1414f, cInput.GetAxis("LMB - fire", 596f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1025f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_InvRenderTargetSize", 1966f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1714f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "- Spectators -")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 502f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis(",", 1050f);
			float axis2 = cInput.GetAxis("n1", 1288f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_MainTex2"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 622f));
		}
		if (Time.timeScale < 1464f || GameObject.FindGameObjectWithTag("_TimeX") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis(",", 668f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis(" </size><size=", 289f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 229f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(801f, cInput.GetAxis("Toast", 1512f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1384f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("Mouse X", 1854f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1156f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_TimeX")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1736f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_14(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 487f * (float)ObscuredPrefs.GetInt("', but this object does not have a RigidBody. Attach a RigidBody Component to simulate movement.");
		if (MAAJODMFHNO == 1039f)
		{
			MAAJODMFHNO = 258f;
		}
		if (MAAJODMFHNO < 25f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 492f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_ChromaticAberration", 670f);
			float axis2 = cInput.GetAxis("Pause Camera", 1312f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("UNUSED"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 695f));
		}
		if (Time.timeScale < 899f || GameObject.FindGameObjectWithTag("SUR") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("_TimeX", 1108f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Tenkoku DynamicSky", 1889f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1969f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(1137f, cInput.GetAxis("_Value", 1717f) * NFAMBKFCFBP * Time.smoothDeltaTime, 13f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis(" This is not possible to be called for standalone input. Please check your platform and code where this is called", 470f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1542f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_Dist")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 378f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("_Value", 1685f);
			float axis2 = cInput.GetAxis("Metal", 1473f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("CameraFilterPack/Blend2Camera_LinearBurn"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1814f));
		}
		if (Time.timeScale < 1093f || GameObject.FindGameObjectWithTag("TRACKING") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("team2", 878f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("TeamName", 717f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 734f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1374f, cInput.GetAxis("<size=", 1849f) * NFAMBKFCFBP * Time.smoothDeltaTime, 133f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_Value2", 1363f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 312f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "HeadlessBeforeSceneLoad")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 748f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 639f * (float)ObscuredPrefs.GetInt("CameraFilterPack/Blend2Camera_Difference");
		if (MAAJODMFHNO == 1198f)
		{
			MAAJODMFHNO = 275f;
		}
		if (MAAJODMFHNO < 940f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 920f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 570f * (float)ObscuredPrefs.GetInt("_ScreenResolution");
		if (MAAJODMFHNO == 448f)
		{
			MAAJODMFHNO = 170f;
		}
		if (MAAJODMFHNO < 589f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 574f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("o", 1740f);
			float axis2 = cInput.GetAxis("DM", 1360f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("Quality"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 338f));
		}
		if (Time.timeScale < 1767f || GameObject.FindGameObjectWithTag("_Value2") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("_ScreenResolution", 303f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("MP", 1781f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1592f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(634f, cInput.GetAxis("SecondaryCausticsProjector", 1328f) * NFAMBKFCFBP * Time.smoothDeltaTime, 862f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("Count", 794f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 109f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "_Blue_G")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1584f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_71(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
		MAAJODMFHNO = 1006f * (float)ObscuredPrefs.GetInt("_Threshhold");
		if (MAAJODMFHNO == 739f)
		{
			MAAJODMFHNO = 888f;
		}
		if (MAAJODMFHNO < 1523f)
		{
			MAAJODMFHNO *= MAAJODMFHNO;
			MAAJODMFHNO = MAAJODMFHNO / 738f / MAAJODMFHNO;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("<size=", 1978f);
			float axis2 = cInput.GetAxis("<size=", 1373f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("_Intensity"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 1745f));
		}
		if (Time.timeScale < 1257f || GameObject.FindGameObjectWithTag("_ScreenResolution") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("{1},{0},{2}", 812f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Next", 883f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 165f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseX)
		{
			base.transform.Rotate(1015f, cInput.GetAxis("_Value3", 163f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1829f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("F - weapon pick up", 1812f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1143f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "CameraFilterPack/TV_Posterize")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 585f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	public void __BB_OBFUSCATOR_32(float HMDGGGIHGCO)
	{
		MMLCCAILDHF += HMDGGGIHGCO;
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("box", 1412f);
			float axis2 = cInput.GetAxis("TakeIn", 140f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("Mouse Y"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 8f));
		}
		if (Time.timeScale < 438f || GameObject.FindGameObjectWithTag(">") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", 479f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("Reload_1_3", 1632f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 176f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(1528f, cInput.GetAxis("MapName", 1899f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1391f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("_Value2", 207f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 1441f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "\n\t\t}")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1775f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}

	private void Awake()
	{
		if (!JACLFEDHAII)
		{
			NDDBPJELPMC = base.transform.root.GetComponentInChildren<WeaponManager>();
		}
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
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (JACLFEDHAII)
		{
			float axis = cInput.GetAxis("Language", 77f);
			float axis2 = cInput.GetAxis("CameraFilterPack/Drawing_Manga", 1951f);
			int num = FPKEGEADACE;
			if (cInput.GetButton("|"))
			{
				num = MFIBFMBNCLM;
			}
			base.transform.position += base.transform.forward * Time.deltaTime * (axis * (float)num);
			base.transform.position += base.transform.right * Time.deltaTime * (axis2 * ((float)num / 601f));
		}
		if (Time.timeScale < 1830f || GameObject.FindGameObjectWithTag("Failed on creating room") != null)
		{
			return;
		}
		if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + cInput.GetAxis("offsets", 1572f) * NFAMBKFCFBP;
			MMLCCAILDHF += cInput.GetAxis("_Value4", 1052f) * AGIHKOFEBOE;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, y, 1018f);
		}
		else if (ONGNICDKGDF == LCBGHDDCHFJ.MouseXAndY)
		{
			base.transform.Rotate(202f, cInput.GetAxis("_ScreenResolution", 836f) * NFAMBKFCFBP * Time.smoothDeltaTime, 1246f);
		}
		else
		{
			MMLCCAILDHF += cInput.GetAxis("\"", 998f) * AGIHKOFEBOE * Time.smoothDeltaTime;
			MMLCCAILDHF = Mathf.Clamp(MMLCCAILDHF, JDCHHLIPAAA, MEEBBBDLLEH);
			base.transform.localEulerAngles = new Vector3(0f - MMLCCAILDHF, base.transform.localEulerAngles.y, 879f);
		}
		if (!JACLFEDHAII)
		{
			if (NDDBPJELPMC != null && (bool)NDDBPJELPMC.GCFDABIEBPD)
			{
				if (!BCGHCDKOGFJ)
				{
					BCGHCDKOGFJ = NDDBPJELPMC.GCFDABIEBPD.GetComponent<WeaponScript>();
				}
			}
			else
			{
				BCGHCDKOGFJ = null;
			}
			if ((bool)BCGHCDKOGFJ && BCGHCDKOGFJ.DMCAELEFJFD && BCGHCDKOGFJ.name != "Hidden/GlobalFog")
			{
				AJEPCFDIIFN = DEBDGENOOGF;
			}
			else
			{
				AJEPCFDIIFN = KFNNDHLFDHD;
			}
		}
		else
		{
			AJEPCFDIIFN = 1592f;
		}
		NFAMBKFCFBP = AJEPCFDIIFN * MAAJODMFHNO;
		AGIHKOFEBOE = AJEPCFDIIFN * MAAJODMFHNO;
	}
}
