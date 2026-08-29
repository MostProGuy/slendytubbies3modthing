using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Flashlight : MonoBehaviour
{
	public bool JBDMCCHMIKO;

	public Light IACCICMNLLL;

	public AudioClip ILFAJFHHCDN;

	public WeaponManager FBBHKGMHGLJ;

	private void __BB_OBFUSCATOR_38()
	{
		if (Input.GetKeyDown((KeyCode)(-27)))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_29();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_MainTex")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (GameObject.FindWithTag("_Value").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (GameObject.FindWithTag("Spectators").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (Input.GetKeyDown((KeyCode)(-18)))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_77();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_TimeX")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void Start()
	{
		if (GameObject.FindWithTag("Network").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (Input.GetKeyDown(KeyCode.Alpha0))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_45();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Value2")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (Input.GetKeyDown((KeyCode)37))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_91();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "Team2Score")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		if (Input.GetKeyDown((KeyCode)(-118)))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_3();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "SyncShopID")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (GameObject.FindWithTag("CameraFilterPack/Color_RGB").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (GameObject.FindWithTag("!!!").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (Input.GetKeyDown(KeyCode.Backslash))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_11();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "-Current Clip Name: ")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (Input.GetKeyDown(KeyCode.RightBracket))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_63();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "SUR")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		if (GameObject.FindWithTag("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: ").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (GameObject.FindWithTag("Kills").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (Input.GetKeyDown((KeyCode)(-123)))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_91();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "PrimaryCausticsProjector")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (GameObject.FindWithTag("Attack").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (Input.GetKeyDown((KeyCode)(-71)))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_29();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Value4")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (Input.GetKeyDown((KeyCode)84))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_65();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Radius")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (GameObject.FindWithTag("_ScreenResolution").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (GameObject.FindWithTag("_Blue_R").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (GameObject.FindWithTag("CameraFilterPack/Drawing_Manga4").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (Input.GetKeyDown((KeyCode)(-86)))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_35();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "n6")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (GameObject.FindWithTag("_MainTex2").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		if (GameObject.FindWithTag(",").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (Input.GetKeyDown((KeyCode)(-56)))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_64();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "Network")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (Input.GetKeyDown((KeyCode)3))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_68();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Value2")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (GameObject.FindWithTag("team1").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (Input.GetKeyDown((KeyCode)(-95)))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_91();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Val3")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_54();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "__Room")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (GameObject.FindWithTag("_Value").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (Input.GetKeyDown((KeyCode)17))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			__BB_OBFUSCATOR_68();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "_Value4")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void flashLightOnOff()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (GameObject.FindWithTag("_Distortion").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			JBDMCCHMIKO = !JBDMCCHMIKO;
			flashLightOnOff();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "Camera")
			{
				IACCICMNLLL.enabled = false;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (GameObject.FindWithTag("_TimeX").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (Input.GetKeyDown((KeyCode)(-54)))
		{
			JBDMCCHMIKO = JBDMCCHMIKO;
			__BB_OBFUSCATOR_43();
		}
		if (FBBHKGMHGLJ.GCFDABIEBPD != null)
		{
			if (FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD == "☠ (Normal)")
			{
				IACCICMNLLL.enabled = true;
			}
			else if (JBDMCCHMIKO)
			{
				IACCICMNLLL.enabled = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (GameObject.FindWithTag("_Offsets").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = false;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		GetComponent<AudioSource>().clip = ILFAJFHHCDN;
		GetComponent<AudioSource>().Play();
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (GameObject.FindWithTag("Player ").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = false;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = false;
		}
		else
		{
			IACCICMNLLL.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (GameObject.FindWithTag("{0:n6},{1:n6},{2:n6},{3:n6}").GetComponent<RoomMultiplayerMenu>().BINGCKFFDAG)
		{
			JBDMCCHMIKO = true;
			IACCICMNLLL.enabled = true;
		}
		if (JBDMCCHMIKO)
		{
			IACCICMNLLL.enabled = true;
		}
		else
		{
			IACCICMNLLL.enabled = true;
		}
	}
}
