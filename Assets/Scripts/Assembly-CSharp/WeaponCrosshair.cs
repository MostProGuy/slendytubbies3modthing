using UnityEngine;

public class WeaponCrosshair : MonoBehaviour
{
	public Texture2D PJJMIJHIJIO;

	public float NJEBPPDINDF = 15f;

	public float NOIAKIBFHLG = 1f;

	public bool LBGNAAMDGHH = true;

	public float CFLFMGMPMLL = 60f;

	public float JLPHIJAMGOK = 40f;

	public float HOIAFHMEMIL = 0.3f;

	private bool FGEAHCFOAIP = true;

	private GUIStyle CMGOFPLBLKP;

	private float EHLONJLDLCM;

	private float IPPDPDNNLOB;

	private FPScontroller CJFDABKPMND;

	private WeaponManager FBBHKGMHGLJ;

	private WeaponScript CBDHAHFFPLG;

	private void __BB_OBFUSCATOR_63()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1130f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 838f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1944f, ((float)Screen.height - NOIAKIBFHLG) / 526f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1328f, ((float)Screen.height - EHLONJLDLCM) / 11f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1523f, ((float)Screen.height + EHLONJLDLCM) / 1705f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_114()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 8)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 64f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 368f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 293f, ((float)Screen.height - NOIAKIBFHLG) / 856f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1389f, ((float)Screen.height - EHLONJLDLCM) / 1000f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1850f, ((float)Screen.height + EHLONJLDLCM) / 1400f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 2)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 240f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1210f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1886f, ((float)Screen.height - NOIAKIBFHLG) / 1993f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 940f, ((float)Screen.height - EHLONJLDLCM) / 874f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1897f, ((float)Screen.height + EHLONJLDLCM) / 1256f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1755f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1873f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1106f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1653f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_126()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void Update()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 0.01f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 4f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 2f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 2f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 6)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1576f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 541f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 228f, ((float)Screen.height - NOIAKIBFHLG) / 1646f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1476f, ((float)Screen.height - EHLONJLDLCM) / 218f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 872f, ((float)Screen.height + EHLONJLDLCM) / 918f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1346f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1779f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 798f, ((float)Screen.height - NOIAKIBFHLG) / 1873f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1732f, ((float)Screen.height - EHLONJLDLCM) / 1637f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1517f, ((float)Screen.height + EHLONJLDLCM) / 487f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_53()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 197f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1188f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 750f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 325f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_22()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_109()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 279f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 110f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1405f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 698f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1763f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1529f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1110f, ((float)Screen.height - NOIAKIBFHLG) / 1581f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 420f, ((float)Screen.height - EHLONJLDLCM) / 331f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 606f, ((float)Screen.height + EHLONJLDLCM) / 824f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 5)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1693f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1952f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 525f, ((float)Screen.height - NOIAKIBFHLG) / 178f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1488f, ((float)Screen.height - EHLONJLDLCM) / 1759f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 113f, ((float)Screen.height + EHLONJLDLCM) / 1813f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1055f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 172f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 540f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1251f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 5)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 578f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1206f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 998f, ((float)Screen.height - NOIAKIBFHLG) / 1381f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 647f, ((float)Screen.height - EHLONJLDLCM) / 1423f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1323f, ((float)Screen.height + EHLONJLDLCM) / 376f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 604f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1954f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1821f, ((float)Screen.height - NOIAKIBFHLG) / 1739f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1648f, ((float)Screen.height - EHLONJLDLCM) / 1021f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1314f, ((float)Screen.height + EHLONJLDLCM) / 661f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 5)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1746f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1681f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 101f, ((float)Screen.height - NOIAKIBFHLG) / 1136f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 426f, ((float)Screen.height - EHLONJLDLCM) / 114f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 6f, ((float)Screen.height + EHLONJLDLCM) / 594f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 8)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1074f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1431f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1176f, ((float)Screen.height - NOIAKIBFHLG) / 1410f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 216f, ((float)Screen.height - EHLONJLDLCM) / 543f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 652f, ((float)Screen.height + EHLONJLDLCM) / 1602f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 4)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 318f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 375f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 626f, ((float)Screen.height - NOIAKIBFHLG) / 1644f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1375f, ((float)Screen.height - EHLONJLDLCM) / 1567f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1361f, ((float)Screen.height + EHLONJLDLCM) / 370f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 8)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1979f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1991f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1712f, ((float)Screen.height - NOIAKIBFHLG) / 1138f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 499f, ((float)Screen.height - EHLONJLDLCM) / 1146f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 815f, ((float)Screen.height + EHLONJLDLCM) / 1509f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 2)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 112f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 648f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 93f, ((float)Screen.height - NOIAKIBFHLG) / 1604f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1483f, ((float)Screen.height - EHLONJLDLCM) / 1116f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 439f, ((float)Screen.height + EHLONJLDLCM) / 700f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_102()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_120()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 244f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 838f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1638f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 934f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 286f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 254f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1452f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1293f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 4)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 831f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 381f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1012f, ((float)Screen.height - NOIAKIBFHLG) / 1903f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 547f, ((float)Screen.height - EHLONJLDLCM) / 318f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1738f, ((float)Screen.height + EHLONJLDLCM) / 1736f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1030f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1989f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 629f, ((float)Screen.height - NOIAKIBFHLG) / 1530f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1069f, ((float)Screen.height - EHLONJLDLCM) / 1601f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 270f, ((float)Screen.height + EHLONJLDLCM) / 1633f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void OnGUI()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 2)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 2f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 2f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 2f, ((float)Screen.height - NOIAKIBFHLG) / 2f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 2f, ((float)Screen.height - EHLONJLDLCM) / 2f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 2f, ((float)Screen.height + EHLONJLDLCM) / 2f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 526f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1475f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1152f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1059f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 46f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1241f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 332f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 450f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_128()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 317f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 736f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 47f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 918f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 6)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1547f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 436f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 714f, ((float)Screen.height - NOIAKIBFHLG) / 1167f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 418f, ((float)Screen.height - EHLONJLDLCM) / 1125f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 484f, ((float)Screen.height + EHLONJLDLCM) / 380f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 4)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1613f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1378f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1452f, ((float)Screen.height - NOIAKIBFHLG) / 211f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 285f, ((float)Screen.height - EHLONJLDLCM) / 1651f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 864f, ((float)Screen.height + EHLONJLDLCM) / 1586f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 2)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1048f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1312f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 42f, ((float)Screen.height - NOIAKIBFHLG) / 38f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 697f, ((float)Screen.height - EHLONJLDLCM) / 1243f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 615f, ((float)Screen.height + EHLONJLDLCM) / 1253f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1403f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1861f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1432f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 473f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 987f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1971f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 998f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 382f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1820f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 24f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 570f, ((float)Screen.height - NOIAKIBFHLG) / 649f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 798f, ((float)Screen.height - EHLONJLDLCM) / 125f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 269f, ((float)Screen.height + EHLONJLDLCM) / 1094f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_32()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_72()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_52()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 838f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 875f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 901f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1844f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_99()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_77()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1445f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 341f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1855f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 251f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_113()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1156f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 344f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 432f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1092f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_135()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 950f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1083f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 213f, ((float)Screen.height - NOIAKIBFHLG) / 1533f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 306f, ((float)Screen.height - EHLONJLDLCM) / 1894f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 74f, ((float)Screen.height + EHLONJLDLCM) / 1858f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1170f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 171f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1397f, ((float)Screen.height - NOIAKIBFHLG) / 1096f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 909f, ((float)Screen.height - EHLONJLDLCM) / 56f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1647f, ((float)Screen.height + EHLONJLDLCM) / 118f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_98()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1689f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1021f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1918f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 318f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void Awake()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_73()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_35()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 11f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 114f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1864f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1576f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1413f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1838f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 178f, ((float)Screen.height - NOIAKIBFHLG) / 1536f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 925f, ((float)Screen.height - EHLONJLDLCM) / 1868f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1970f, ((float)Screen.height + EHLONJLDLCM) / 1380f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 30f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 252f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1089f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1463f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_134()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1850f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1219f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1145f, ((float)Screen.height - NOIAKIBFHLG) / 1470f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 766f, ((float)Screen.height - EHLONJLDLCM) / 1489f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 678f, ((float)Screen.height + EHLONJLDLCM) / 671f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 532f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1706f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 982f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 879f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_115()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1349f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 697f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1600f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1265f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 0)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1944f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1282f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 629f, ((float)Screen.height - NOIAKIBFHLG) / 1369f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1042f, ((float)Screen.height - EHLONJLDLCM) / 1789f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 606f, ((float)Screen.height + EHLONJLDLCM) / 1067f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 8)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1671f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 756f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 964f, ((float)Screen.height - NOIAKIBFHLG) / 1628f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1423f, ((float)Screen.height - EHLONJLDLCM) / 1296f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 686f, ((float)Screen.height + EHLONJLDLCM) / 1093f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1953f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 267f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1305f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 390f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_57()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_68()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 2)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 609f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 860f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1398f, ((float)Screen.height - NOIAKIBFHLG) / 683f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 971f, ((float)Screen.height - EHLONJLDLCM) / 317f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 119f, ((float)Screen.height + EHLONJLDLCM) / 1454f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_67()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 3)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1522f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1215f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 718f, ((float)Screen.height - NOIAKIBFHLG) / 234f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 590f, ((float)Screen.height - EHLONJLDLCM) / 1330f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 968f, ((float)Screen.height + EHLONJLDLCM) / 1030f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 6)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 468f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 24f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 755f, ((float)Screen.height - NOIAKIBFHLG) / 444f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1658f, ((float)Screen.height - EHLONJLDLCM) / 1018f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1901f, ((float)Screen.height + EHLONJLDLCM) / 1143f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1373f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1004f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 424f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 173f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 710f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1147f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 569f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 138f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_37()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1668f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1582f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1774f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 250f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1937f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 516f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 976f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1190f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_40()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 422f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1974f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 87f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 671f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1879f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 781f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 422f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 848f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_125()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_132()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1602f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 749f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1020f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 922f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_49()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1023f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 720f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1249f, ((float)Screen.height - NOIAKIBFHLG) / 859f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 684f, ((float)Screen.height - EHLONJLDLCM) / 1801f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1070f, ((float)Screen.height + EHLONJLDLCM) / 625f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_117()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_46()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 297f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 304f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 404f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 88f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_12()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1025f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 1052f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1211f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 25f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 6)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1922f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 1209f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1299f, ((float)Screen.height - NOIAKIBFHLG) / 857f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 57f, ((float)Screen.height - EHLONJLDLCM) / 1289f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1688f, ((float)Screen.height + EHLONJLDLCM) / 494f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}

	private void __BB_OBFUSCATOR_123()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_131()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 912f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 388f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 334f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 464f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = true;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_84()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 1992f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 79f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 1592f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1791f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		CMGOFPLBLKP = new GUIStyle();
		CMGOFPLBLKP.normal.background = PJJMIJHIJIO;
		CJFDABKPMND = base.transform.root.GetComponent<FPScontroller>();
		FBBHKGMHGLJ = base.transform.root.GetComponentInChildren<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_48()
	{
		if ((bool)FBBHKGMHGLJ && (bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			CBDHAHFFPLG = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (Time.timeScale < 134f)
		{
			return;
		}
		if (LBGNAAMDGHH)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(1);
			if ((bool)CBDHAHFFPLG && (mouseButtonDown || CBDHAHFFPLG.OCKKJJLFBPC))
			{
				if (CBDHAHFFPLG.GOJHNNDJMFJ)
				{
					if (mouseButtonDown && CBDHAHFFPLG.OJMPENKKGPJ && !CBDHAHFFPLG.ABCKOODMGBE && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						if (EHLONJLDLCM < CFLFMGMPMLL * 227f)
						{
							EHLONJLDLCM += CFLFMGMPMLL;
						}
					}
					else
					{
						EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, JLPHIJAMGOK, Time.deltaTime / HOIAFHMEMIL);
					}
				}
				else
				{
					if (CBDHAHFFPLG.OCKKJJLFBPC && !CBDHAHFFPLG.PLIOKPDLDPI)
					{
						IPPDPDNNLOB = CFLFMGMPMLL * 867f;
					}
					else
					{
						IPPDPDNNLOB = JLPHIJAMGOK;
					}
					EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
				}
			}
			else
			{
				if (CJFDABKPMND.MPBEELGNNCF)
				{
					IPPDPDNNLOB = CFLFMGMPMLL + CJFDABKPMND.LNECOJBDOOE.velocity.magnitude * 1200f;
				}
				else
				{
					IPPDPDNNLOB = JLPHIJAMGOK;
				}
				EHLONJLDLCM = Mathf.Lerp(EHLONJLDLCM, IPPDPDNNLOB, Time.deltaTime / HOIAFHMEMIL);
			}
		}
		else
		{
			EHLONJLDLCM = JLPHIJAMGOK;
		}
		if ((bool)CBDHAHFFPLG)
		{
			if (CBDHAHFFPLG.DMCAELEFJFD)
			{
				FGEAHCFOAIP = false;
			}
			else
			{
				FGEAHCFOAIP = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (!(EHLONJLDLCM > (float)(Screen.height / 1)) && FGEAHCFOAIP)
		{
			GUI.Box(new Rect(((float)Screen.width - EHLONJLDLCM) / 1462f - NJEBPPDINDF, ((float)Screen.height - NOIAKIBFHLG) / 4f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width + EHLONJLDLCM) / 1061f, ((float)Screen.height - NOIAKIBFHLG) / 859f, NJEBPPDINDF, NOIAKIBFHLG), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1492f, ((float)Screen.height - EHLONJLDLCM) / 198f - NJEBPPDINDF, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
			GUI.Box(new Rect(((float)Screen.width - NOIAKIBFHLG) / 1249f, ((float)Screen.height + EHLONJLDLCM) / 1868f, NOIAKIBFHLG, NJEBPPDINDF), string.Empty, CMGOFPLBLKP);
		}
	}
}
