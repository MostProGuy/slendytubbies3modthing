using InControl.mod;
using UnityEngine;

public class ThirdPersonControl : MonoBehaviour
{
	public Camera ADDGNCLMHPK;

	public Camera OHFENIGGFCN;

	public TPSCamera CFGIMKKNKLB;

	public FPSMouseLook EPIDGMMCEHG;

	public FPSMouseLook GPBCCCFBGAO;

	public FPScontroller GJBFPMGPHPF;

	public bool IJLOPFOGIKA;

	public Transform NAAGAMLOOJL;

	public WeaponManager FBBHKGMHGLJ;

	public Texture2D DOAAHNIKDDN;

	private Vector3 GHGJIHEPIOJ;

	private float FMOKAFHPEDI;

	private bool ENIFKCJEAEO;

	private float MJLELOFCHNM;

	private void __BB_OBFUSCATOR_79()
	{
		if (cInput.GetButtonDown("CameraFilterPack/Blur_Noise"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_17();
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_117()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_113()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 911f;
			}
			if (MJLELOFCHNM > 419f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1768f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 1 - -26, Screen.height / 6 - -117, 1343f, 813f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 473f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 981f;
			}
			if (MJLELOFCHNM > 783f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 949f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 6 - 117, Screen.height / 7 - 34, 548f, 809f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 885f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 773f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("n15");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_Val3");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("pointBuffer");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_132()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_116()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1175f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("{0}:{1}");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Ping: ");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("CameraFilterPack/TV_LED");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_96()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1275f;
			}
			if (MJLELOFCHNM > 198f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 447f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 5 - -116, Screen.height / 7 - -40, 1736f, 339f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1775f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_99()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1693f;
			}
			if (MJLELOFCHNM > 627f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 925f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 5 - 112, Screen.height / 3 - 96, 809f, 654f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1040f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_104()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1695f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Start Game");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_MainTex2");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("FlyCam");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1312f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_TimeX");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play(": ");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Radius2");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1589f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_TimeX");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Diffuse");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Value4");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_32()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_115()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 162f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("7");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_TimeX");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_TimeX");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_124()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (cInput.GetButtonDown("_TimeX"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1212f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("*");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("MP");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_PositionY");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_128()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_121()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 213f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Value2");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_AlphaHexa");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_TimeX");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 789f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("CameraFilterPack/OldFilm_Cutting2");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("SwearFilter");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Value2");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 516f;
			}
			if (MJLELOFCHNM > 1300f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 176f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 6 - 118, Screen.height / 3 - 69, 467f, 424f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 304f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 330f;
			}
			if (MJLELOFCHNM > 1234f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 3f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 7 - 72, Screen.height / 6 - 62, 834f, 961f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1937f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (cInput.GetButtonDown("Player"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_89();
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_105()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_78()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (cInput.GetButtonDown("TenkokuModule"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_1();
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (cInput.GetButtonDown("_TimeX"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_121();
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 446f;
			}
			if (MJLELOFCHNM > 633f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 989f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 4 - 57, Screen.height / 3 - 105, 885f, 1722f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1813f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1854f;
			}
			if (MJLELOFCHNM > 938f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1001f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 1 - 14, Screen.height / 6 - 97, 630f, 1917f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1162f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1653f;
			}
			if (MJLELOFCHNM > 1319f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1472f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 2 - -77, Screen.height / 0 - 18, 379f, 945f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1248f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1892f;
			}
			if (MJLELOFCHNM > 922f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 858f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 2 - 117, Screen.height / 4 - 68, 1620f, 1888f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 95f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_98()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 209f;
			}
			if (MJLELOFCHNM > 834f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 50f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 6 - 71, Screen.height / 1 - -112, 1351f, 1613f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 943f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1355f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("\"OO\", \"Texture::");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("Ping");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("stopping ");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_62()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1283f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Texture");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("</size>");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("Hue/Knob");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_42()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_61()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_67()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (cInput.GetButtonDown("{0}:{1}"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_47();
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 872f;
			}
			if (MJLELOFCHNM > 400f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1097f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 0 - -125, Screen.height / 3 - -56, 1109f, 1614f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 52f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_100()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1780f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Alpha");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("\"Skin\"");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29(">");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1225f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("|");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_Radius2");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_MainTex2");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1533f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("0");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("CheckResources () for ");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Death");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1306f;
			}
			if (MJLELOFCHNM > 252f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1736f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 3 - 87, Screen.height / 5 - -19, 1225f, 1206f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1600f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1090f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Value");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("\"");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("team1");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (cInput.GetButtonDown("CameraFilterPack_VHS1"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_1();
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (cInput.GetButtonDown("Checker"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_25();
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (cInput.GetButtonDown("_Distortion"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_87();
		}
	}

	private void __BB_OBFUSCATOR_127()
	{
		if (cInput.GetButtonDown("|"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_12();
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (cInput.GetButtonDown("_Green_B"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_121();
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 948f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("selectWeapon");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("MP");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("☐");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void Awake()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (cInput.GetButtonDown("Player "))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_104();
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 928f;
			}
			if (MJLELOFCHNM > 64f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1706f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 4 - 123, Screen.height / 3 - -85, 307f, 69f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 657f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (cInput.GetButtonDown("Particles/Additive"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_33();
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 475f;
			}
			if (MJLELOFCHNM > 1956f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 952f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 4 - -98, Screen.height / 3 - -77, 659f, 227f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1015f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1524f;
			}
			if (MJLELOFCHNM > 1416f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 315f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 4 - 111, Screen.height / 2 - 52, 381f, 1567f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1314f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 760f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Value");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Horizontal");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29(">");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 180f;
			}
			if (MJLELOFCHNM > 1703f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1128f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 0 - -124, Screen.height / 0 - -68, 234f, 1444f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 910f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 451f;
			}
			if (MJLELOFCHNM > 764f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 276f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 7 - 120, Screen.height / 6 - -68, 1013f, 845f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 23f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 422f;
			}
			if (MJLELOFCHNM > 213f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1543f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 5 - 64, Screen.height / 2 - -67, 1980f, 1095f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 636f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1066f;
			}
			if (MJLELOFCHNM > 545f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1121f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 0 - 3, Screen.height / 7 - -9, 895f, 1776f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1491f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		if (cInput.GetButtonDown("SyncCount"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (cInput.GetButtonDown("_Value"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_50();
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_112()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 311f;
			}
			if (MJLELOFCHNM > 1360f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1934f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 5 - 18, Screen.height / 7 - -5, 1692f, 1956f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 152f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1136f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Shop");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_Offsets");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_FadeFX");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1729f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("window");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("</size></color>");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("NPCDeath");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = false;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1689f;
			}
			if (MJLELOFCHNM > 488f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 48f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 3 - 114, Screen.height / 7 - 59, 37f, 806f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1264f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (cInput.GetButtonDown("ZWName'"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_53();
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (cInput.GetButtonDown("_MainTex2"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_87();
		}
	}

	private void __BB_OBFUSCATOR_102()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (cInput.GetButtonDown("PublishMessage called while not connected to front end server."))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_25();
		}
	}

	private void OnGUI()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 0.2f;
			}
			if (MJLELOFCHNM > 0f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 2 - 24, Screen.height / 2 - 24, 48f, 48f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1.25f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1016f;
			}
			if (MJLELOFCHNM > 1844f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1833f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 3 - 34, Screen.height / 8 - -48, 1852f, 1261f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 805f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_134()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_103()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 710f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("_MainTex2");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_MainTex");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("LegsURL");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_123()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 664f;
			}
			if (MJLELOFCHNM > 1088f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1292f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 0 - 38, Screen.height / 3 - 61, 768f, 188f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 682f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_130()
	{
		if (cInput.GetButtonDown("ForceDamage"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_82();
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1817f;
			}
			if (MJLELOFCHNM > 25f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 224f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 0 - -74, Screen.height / 7 - 33, 1622f, 1058f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 37f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1122f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Horizontal");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_ColorRGB");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Blue_C");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_108()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1319f;
			}
			if (MJLELOFCHNM > 841f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 370f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 1 - -6, Screen.height / 3 - -2, 227f, 1503f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1629f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = false;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1403f;
			GPBCCCFBGAO.enabled = true;
			NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29(">");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("chat");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Rain Effect v1.2");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		if (cInput.GetButtonDown("CameraFilterPack/NightVisionFX"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_53();
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (cInput.GetButtonDown("TeamName"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = true;
			__BB_OBFUSCATOR_17();
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 960f;
			}
			if (MJLELOFCHNM > 1664f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1873f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 1 - -91, Screen.height / 7 - 100, 11f, 37f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1064f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 58f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("INF");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29("Language");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().__BB_OBFUSCATOR_29(",");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 341f;
			}
			if (MJLELOFCHNM > 483f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1109f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 7 - -26, Screen.height / 4 - -41, 1066f, 1070f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1785f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_131()
	{
		if (cInput.GetButtonDown("_Value"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_27();
		}
	}

	private void ChangeNow()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1.85f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("Idle");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("Run");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("Crouch_Idle");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = false;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = true;
			}
			else
			{
				ENIFKCJEAEO = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void Update()
	{
		if (cInput.GetButtonDown("View"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			ChangeNow();
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1128f;
			}
			if (MJLELOFCHNM > 1530f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 560f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 2 - 3, Screen.height / 3 - -56, 585f, 1460f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 304f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (cInput.GetButtonDown("5"))
		{
			IJLOPFOGIKA = IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_87();
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (cInput.GetButtonDown("Left Stick Down"))
		{
			IJLOPFOGIKA = !IJLOPFOGIKA;
			ENIFKCJEAEO = false;
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (IJLOPFOGIKA)
		{
			OHFENIGGFCN.enabled = false;
			EPIDGMMCEHG.enabled = false;
			base.transform.localEulerAngles = Vector3.zero;
			CFGIMKKNKLB.KGMGCNKCEPO = NAAGAMLOOJL.parent.localEulerAngles.y;
			CFGIMKKNKLB.LAACIOEHFCJ = NAAGAMLOOJL.parent.localEulerAngles.x;
			CFGIMKKNKLB.enabled = true;
			NAAGAMLOOJL.gameObject.SetActive(true);
			OHFENIGGFCN.transform.position = NAAGAMLOOJL.parent.transform.position + NAAGAMLOOJL.up * 1892f;
			GPBCCCFBGAO.enabled = false;
			NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_ScreenResolution");
			if (GJBFPMGPHPF.KKBOHCFDNGD)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("<");
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				NAAGAMLOOJL.GetComponent<MecanimControl>().Play("_Red_G");
			}
		}
		else
		{
			OHFENIGGFCN.enabled = true;
			EPIDGMMCEHG.enabled = true;
			CFGIMKKNKLB.enabled = true;
			base.transform.localPosition = GHGJIHEPIOJ;
			base.transform.localEulerAngles = Vector3.zero;
			NAAGAMLOOJL.gameObject.SetActive(false);
			OHFENIGGFCN.transform.localPosition = Vector3.zero;
			GPBCCCFBGAO.enabled = true;
			if (GJBFPMGPHPF.ALNNAAPEBMK)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, GJBFPMGPHPF.LNECOJBDOOE.crouchHeight, base.transform.localPosition.z);
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD.DMCAELEFJFD)
			{
				ENIFKCJEAEO = false;
			}
			else
			{
				ENIFKCJEAEO = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 29f;
			}
			if (MJLELOFCHNM > 1799f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 158f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 2 - 75, Screen.height / 5 - 80, 195f, 329f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 1451f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!IJLOPFOGIKA)
		{
			return;
		}
		WeaponScript gCFDABIEBPD = FBBHKGMHGLJ.GCFDABIEBPD;
		if (!gCFDABIEBPD.HAJOPKELMEB && gCFDABIEBPD.DMCAELEFJFD && gCFDABIEBPD.DOAAHNIKDDN != null)
		{
			if (gCFDABIEBPD.HMBJBCLCDAI != null)
			{
				MJLELOFCHNM = 1197f;
			}
			if (MJLELOFCHNM > 1245f)
			{
				GUI.color = Color.red;
				MJLELOFCHNM -= 1860f * Time.deltaTime;
			}
			GUI.DrawTexture(new Rect(Screen.width / 6 - -15, Screen.height / 1 - -26, 70f, 1158f), gCFDABIEBPD.DOAAHNIKDDN);
		}
		if (gCFDABIEBPD.DMCAELEFJFD && (bool)gCFDABIEBPD.GetComponent<SniperScope>())
		{
			NAAGAMLOOJL.gameObject.SetActive(true);
		}
		else
		{
			NAAGAMLOOJL.gameObject.SetActive(false);
		}
		if (GJBFPMGPHPF.ALNNAAPEBMK)
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI / 724f;
		}
		else
		{
			CFGIMKKNKLB.AIGANDOLOAH = FMOKAFHPEDI;
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}

	private void __BB_OBFUSCATOR_22()
	{
		GHGJIHEPIOJ = base.transform.localPosition;
		FMOKAFHPEDI = CFGIMKKNKLB.AIGANDOLOAH;
	}
}
