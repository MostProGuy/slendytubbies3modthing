using UnityEngine;

public class EnableHelper : MonoBehaviour
{
	public FPScontroller GJBFPMGPHPF;

	public WeaponManager FBBHKGMHGLJ;

	public FPSMouseLook JHHLMFLLHHN;

	public FPSMouseLook CBGCOEKANJH;

	private GameObject BFBEOFLGAGD;

	private void __BB_OBFUSCATOR_115()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Extinguish");
	}

	private void Start()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("EnableHelper");
	}

	private void __BB_OBFUSCATOR_42()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value4") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_PositionX");
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_TimeX") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("MapName");
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		BFBEOFLGAGD = GameObject.FindWithTag(">");
	}

	private void __BB_OBFUSCATOR_90()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Connect");
	}

	private void __BB_OBFUSCATOR_93()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("\n\n; Object connections\n;------------------------------------------------------------------\n\n");
	}

	private void __BB_OBFUSCATOR_27()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Value2");
	}

	private void __BB_OBFUSCATOR_121()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("ApplyDamage");
	}

	private void __BB_OBFUSCATOR_26()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Turn") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("HeadURL");
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Custard Found") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("<size=");
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_ScreenResolution");
	}

	private void __BB_OBFUSCATOR_43()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("mm)");
	}

	private void __BB_OBFUSCATOR_122()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Light2");
	}

	private void __BB_OBFUSCATOR_68()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_ScreenResolution") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_CenterY");
		}
	}

	private void __BB_OBFUSCATOR_105()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("X");
	}

	private void __BB_OBFUSCATOR_49()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
	}

	private void __BB_OBFUSCATOR_31()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("team2") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Threshold");
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value2") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value");
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_CenterX");
	}

	private void __BB_OBFUSCATOR_87()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
	}

	private void __BB_OBFUSCATOR_64()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_TimeX") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("threshold");
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Value4");
	}

	private void __BB_OBFUSCATOR_2()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Picked ammo for | ");
	}

	private void FixedUpdate()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("EnableHelper") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("EnableHelper");
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag(")") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("Hidden/Aubergine/Vignette");
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("CameraFilterPack/Light_Rainbow2") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Color_G");
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Deaths");
	}

	private void __BB_OBFUSCATOR_7()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Player ");
	}

	private void __BB_OBFUSCATOR_99()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("networkAddMessage") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("Click on the ground to spawn the selected effect");
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("S3.1.26");
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Distortion") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag(" Custards)");
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_ScreenResolution");
	}

	private void __BB_OBFUSCATOR_72()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_NoiseAmount");
	}

	private void __BB_OBFUSCATOR_103()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Start Game") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("Ping: ");
		}
	}

	private void __BB_OBFUSCATOR_85()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_OnOff") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("OnDetonatorForceHit");
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Crouch") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_MainTex2");
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Your Time | ") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Parameter");
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Tenkoku DynamicSky") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("Dead");
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Particles/Additive");
	}

	private void __BB_OBFUSCATOR_35()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("ShowerEffectShader");
	}

	private void __BB_OBFUSCATOR_50()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("[IntRect {0}-{1} {2}-{3}]");
	}

	private void __BB_OBFUSCATOR_15()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("OnRenderImage in Helper called ...");
	}

	private void __BB_OBFUSCATOR_6()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("CameraFilterPack/Distortion_Flush");
	}

	private void __BB_OBFUSCATOR_55()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("Attack");
	}

	private void __BB_OBFUSCATOR_44()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_ToPrevViewProjCombined") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("0.5") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_BgFade");
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("CameraFilterPack/Gradients_Rainbow");
	}

	private void __BB_OBFUSCATOR_30()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("CameraFilterPack/Blend2Camera_LinearBurn") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("n15");
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Red_C") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("team2");
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Value5");
	}

	private void __BB_OBFUSCATOR_71()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag(": ") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag(" <>__TranspIdent0 = ");
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("ForceDamage") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("<size=");
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_MainTex");
	}

	private void __BB_OBFUSCATOR_3()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("NormRain");
	}

	private void __BB_OBFUSCATOR_83()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("team2");
	}

	private void __BB_OBFUSCATOR_104()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Mouse X") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("COOP");
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_BorderColor") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_ScreenResolution");
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value4") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value2");
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("VHS") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("-Is Playing: ");
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
	}

	private void __BB_OBFUSCATOR_56()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("☐");
	}

	private void __BB_OBFUSCATOR_92()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("Null") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value2");
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("VS/") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_ScreenResolution") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("\n");
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("TeamASpawn") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("selColor");
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("n4") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_ScreenResolution");
		}
	}

	private void __BB_OBFUSCATOR_111()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("CameraFilterPack/Distortion_FishEye") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Offsets") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value");
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_SmoothEnd") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("ApplyDamage");
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Refraction");
	}

	private void __BB_OBFUSCATOR_1()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_NoiseTex");
	}

	private void __BB_OBFUSCATOR_63()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value4") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("\\Google");
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Value") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value");
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_TimeX") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("_Value3");
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Green_B");
	}

	private void __BB_OBFUSCATOR_120()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Radius");
	}

	private void __BB_OBFUSCATOR_118()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = false;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = false;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = true;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("_Blue_C") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("TeamTag");
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		if ((bool)BFBEOFLGAGD && BFBEOFLGAGD.activeSelf)
		{
			if (!GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (!FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && !FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.enabled = true;
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = false;
			}
		}
		if (!BFBEOFLGAGD || !BFBEOFLGAGD.activeSelf)
		{
			if (GJBFPMGPHPF.MOEAJIJBBKI)
			{
				GJBFPMGPHPF.MOEAJIJBBKI = true;
			}
			if (FBBHKGMHGLJ.enabled && (bool)FBBHKGMHGLJ.GCFDABIEBPD && FBBHKGMHGLJ.GCFDABIEBPD.enabled)
			{
				FBBHKGMHGLJ.GCFDABIEBPD.enabled = true;
				FBBHKGMHGLJ.enabled = false;
			}
		}
		if (!BFBEOFLGAGD && GameObject.FindWithTag("SyncNPCCount") != null)
		{
			BFBEOFLGAGD = GameObject.FindWithTag("Private");
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("TeamTag");
	}

	private void __BB_OBFUSCATOR_109()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("_Value4");
	}

	private void __BB_OBFUSCATOR_78()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("TeamName");
	}

	private void __BB_OBFUSCATOR_66()
	{
		BFBEOFLGAGD = GameObject.FindWithTag("[;\\\\/:*?\"<>|&']");
	}
}
