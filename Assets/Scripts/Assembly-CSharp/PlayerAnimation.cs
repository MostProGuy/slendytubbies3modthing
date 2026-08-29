using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	public MecanimControl FKDEGFLAGII;

	public Animation CIAKNODIMFO;

	public string DHFPNBHFHOL;

	public string DJOMEPLDPGA;

	public Transform CFJIELONHLO;

	public Transform DHOHEDOELJI;

	private string EANCKCBMNPH;

	public PlayerNetworkController KBLHDNPEGPL;

	public Vector3 GNPGGMIFCOD;

	private Animator BDICHBPAKFJ;

	private Vector3 FOKJHOACFOK;

	private void __BB_OBFUSCATOR_42()
	{
		float num = 1690f;
		if (DJOMEPLDPGA == "ZWName'")
		{
			num = 949f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_92()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1204f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1131f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "CameraFilterPack/Blur_Blurry" || DHFPNBHFHOL == "Picked ammo for | ")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1443f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 657f);
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 991f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1690f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "vignetteIntensity" || DHFPNBHFHOL == "\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1824f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 891f);
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_17()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1953f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 330f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "3" || DHFPNBHFHOL == "networkAddMessage")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 591f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 176f);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1984f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 593f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_TimeX" || DHFPNBHFHOL == "</size>")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1681f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1296f);
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1705f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 538f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "CameraFilterPack/Blend2Camera_Blend" || DHFPNBHFHOL == "_Value2")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1770f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 176f);
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_19()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_30()
	{
		float num = 1949f;
		if (DJOMEPLDPGA == "Left Stick Down")
		{
			num = 1553f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_91()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1055f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1412f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "KickPlayer" || DHFPNBHFHOL == "-Is Playing: ")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1645f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 26f);
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		float num = 443f;
		if (DJOMEPLDPGA == " Simplified")
		{
			num = 1808f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void Update()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 0.1f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 0.1f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Run" || DHFPNBHFHOL == "Melee")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 0f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1f);
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 844f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1666f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "CameraFilterPack/TV_BrokenGlass" || DHFPNBHFHOL == "in: ")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1553f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1096f);
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 266f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1548f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Teleport" || DHFPNBHFHOL == "Custard")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1582f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 969f);
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1942f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 698f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_ScreenResolution" || DHFPNBHFHOL == "ShopBox/Heal/Text")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1406f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1970f);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		float num = 737f;
		if (DJOMEPLDPGA == "Mouse Y")
		{
			num = 1003f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_53()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 342f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 688f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "n8" || DHFPNBHFHOL == "o")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1844f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1397f);
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_4()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 444f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1570f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "DoDamage" || DHFPNBHFHOL == "-Horizontal")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1327f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1960f);
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_9()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_21()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_85()
	{
		float num = 1737f;
		if (DJOMEPLDPGA == "_PositionX")
		{
			num = 1073f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_64()
	{
		float num = 655f;
		if (DJOMEPLDPGA == "_MainTex2")
		{
			num = 644f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_67()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 94f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1551f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_Distortion" || DHFPNBHFHOL == "Difficulty")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1070f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 432f);
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1347f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1840f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "offsets" || DHFPNBHFHOL == "_Value3")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 305f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 251f);
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_26()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1340f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1446f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Unsubscribe called while not connected to front end server." || DHFPNBHFHOL == "_Value2")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 482f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 730f);
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		float num = 1436f;
		if (DJOMEPLDPGA == "Password")
		{
			num = 103f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_57()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 143f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 754f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Speed (" || DHFPNBHFHOL == "MP")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 381f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 815f);
		}
	}

	private void Awake()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_82()
	{
		float num = 1401f;
		if (DJOMEPLDPGA == "MP")
		{
			num = 1501f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_65()
	{
		float num = 835f;
		if (DJOMEPLDPGA == "_Value")
		{
			num = 1844f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_87()
	{
		float num = 1751f;
		if (DJOMEPLDPGA == "Ping: ")
		{
			num = 1217f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_6()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1408f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1709f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass" || DHFPNBHFHOL == "_NormalOffsetScale")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 423f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1721f);
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		float num = 903f;
		if (DJOMEPLDPGA == "_PositionX")
		{
			num = 599f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_1()
	{
		float num = 1186f;
		if (DJOMEPLDPGA == "Create Room")
		{
			num = 828f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_5()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_58()
	{
		float num = 1267f;
		if (DJOMEPLDPGA == "_Relief")
		{
			num = 213f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_68()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_93()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_54()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 527f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1178f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Shop" || DHFPNBHFHOL == "Start Game")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1546f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1753f);
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_83()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 777f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 754f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "CameraFilterPack/Colors_NewPosterize" || DHFPNBHFHOL == "TeamName")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 944f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 652f);
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1092f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 145f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Mouse X" || DHFPNBHFHOL == "_Bullet_1")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 608f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 848f);
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_88()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_29()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 258f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 65f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_Distortion" || DHFPNBHFHOL == "_Value4")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 790f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 545f);
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 783f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1296f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Mouse X" || DHFPNBHFHOL == "☠☠ (Hard)")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1743f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 740f);
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_34()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1376f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 616f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_AccumOrig" || DHFPNBHFHOL == "_Value")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 56f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1660f);
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		float num = 1502f;
		if (DJOMEPLDPGA == "_Value3")
		{
			num = 812f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_73()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_71()
	{
		float num = 1081f;
		if (DJOMEPLDPGA == "_Offsets")
		{
			num = 428f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void LateUpdate()
	{
		float num = 0f;
		if (DJOMEPLDPGA == "Weapon_Idle")
		{
			num = -23f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_43()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_8()
	{
		float num = 1371f;
		if (DJOMEPLDPGA == "_TimeX")
		{
			num = 1953f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_22()
	{
		float num = 783f;
		if (DJOMEPLDPGA == "_MainTex2")
		{
			num = 85f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_84()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_49()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_39()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 493f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 448f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "stopping " || DHFPNBHFHOL == " <>__TranspIdent0 = ")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 297f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1858f);
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		float num = 1756f;
		if (DJOMEPLDPGA == "CameraFilterPack/Color_Contrast")
		{
			num = 943f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_47()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1890f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 1811f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "Connect" || DHFPNBHFHOL == "_Radius")
		{
			BDICHBPAKFJ.SetLayerWeight(1, 654f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1099f);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		float num = 774f;
		if (DJOMEPLDPGA == "B")
		{
			num = 50f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_63()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_24()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_59()
	{
		float num = 597f;
		if (DJOMEPLDPGA == "MP")
		{
			num = 836f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_41()
	{
		float num = 339f;
		if (DJOMEPLDPGA == "_Offsets")
		{
			num = 1214f;
		}
		DHOHEDOELJI.localEulerAngles = new Vector3(FOKJHOACFOK.x + num, FOKJHOACFOK.y, 0f - KBLHDNPEGPL.IHBMGGNMDED);
		DHOHEDOELJI.localEulerAngles += GNPGGMIFCOD;
	}

	private void __BB_OBFUSCATOR_0()
	{
		BDICHBPAKFJ = GetComponent<Animator>();
	}

	private void __BB_OBFUSCATOR_35()
	{
		DHFPNBHFHOL = KBLHDNPEGPL.ADJPPMOHAMP;
		DJOMEPLDPGA = KBLHDNPEGPL.NNKBAKKCDKJ;
		if (FKDEGFLAGII.GetCurrentClipName() != DHFPNBHFHOL)
		{
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 831f);
		}
		if (DJOMEPLDPGA != EANCKCBMNPH)
		{
			FKDEGFLAGII.SetWeaponClip(DJOMEPLDPGA);
			FKDEGFLAGII.CrossFade(DHFPNBHFHOL, 610f);
			EANCKCBMNPH = DJOMEPLDPGA;
		}
		FOKJHOACFOK = base.transform.localEulerAngles;
		if (DHFPNBHFHOL == "_TimeX" || DHFPNBHFHOL == "{0}:{1}")
		{
			BDICHBPAKFJ.SetLayerWeight(0, 1442f);
		}
		else
		{
			BDICHBPAKFJ.SetLayerWeight(1, 1543f);
		}
	}
}
