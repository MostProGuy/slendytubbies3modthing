using UnityEngine;

public class automaticDoorsTerminal : MonoBehaviour
{
	public automaticDoors ECLGPAFLMFA;

	private void __BB_OBFUSCATOR_4(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Version" || NMBDAJFIKEN.tag == "Idle")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_39();
		}
	}

	private void __BB_OBFUSCATOR_9(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "SwearFilter" || NMBDAJFIKEN.tag == "_TimeX")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_5(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == ": " || NMBDAJFIKEN.tag == "Horizontal")
		{
			ECLGPAFLMFA.Close();
		}
	}

	private void __BB_OBFUSCATOR_2(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Purchase/Text" || NMBDAJFIKEN.tag == "CameraFilterPack/FX_Scan")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_51();
		}
	}

	private void OnTriggerExit(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Player" || NMBDAJFIKEN.tag == "monster")
		{
			ECLGPAFLMFA.Close();
		}
	}

	private void __BB_OBFUSCATOR_12(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_TimeX" || NMBDAJFIKEN.tag == "Connecting to nameserver ")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_39();
		}
	}

	private void __BB_OBFUSCATOR_8(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == ": " || NMBDAJFIKEN.tag == "DM")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_6();
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Player" || NMBDAJFIKEN.tag == "monster")
		{
			ECLGPAFLMFA.Open();
		}
	}

	private void __BB_OBFUSCATOR_0(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_Value2" || NMBDAJFIKEN.tag == "_Value3")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_39();
		}
	}

	private void __BB_OBFUSCATOR_11(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_Value4" || NMBDAJFIKEN.tag == ">  ")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_37();
		}
	}

	private void __BB_OBFUSCATOR_13(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_ScreenResolution" || NMBDAJFIKEN.tag == "_Vignette")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_46();
		}
	}

	private void __BB_OBFUSCATOR_3(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_FadeFX" || NMBDAJFIKEN.tag == "custard")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_1();
		}
	}

	private void __BB_OBFUSCATOR_1(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "\", \"Limb\" {\n\t\tVersion: 232\n\t\tProperties60:  {\n\t\t\tProperty: \"Visibility\", \"Visibility\", \"A+\",1\n\t\t\tProperty: \"Lcl Translation\", \"Lcl Translation\", \"A+\"," || NMBDAJFIKEN.tag == "Label")
		{
			ECLGPAFLMFA.__BB_OBFUSCATOR_37();
		}
	}
}
