using UnityEngine;

public class KillZone : MonoBehaviour
{
	private void __BB_OBFUSCATOR_8(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "INF")
		{
			NMBDAJFIKEN.SendMessage("_ScreenResolution", -135, SendMessageOptions.RequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_28(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "enableFog")
		{
			NMBDAJFIKEN.SendMessage("Mouse Y", 15, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_19(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_Value4")
		{
			NMBDAJFIKEN.SendMessage("CameraFilterPack/Drawing_NewCellShading", -74, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_9(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Ammo")
		{
			NMBDAJFIKEN.SendMessage("Failed on creating room", -170, SendMessageOptions.RequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_27(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "PlayerType'")
		{
			NMBDAJFIKEN.SendMessage("_Value4", 159, SendMessageOptions.RequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_11(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_TimeX")
		{
			NMBDAJFIKEN.SendMessage("VS", 120, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_7(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == ">")
		{
			NMBDAJFIKEN.SendMessage("_ScreenResolution", -145, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_10(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "TeamName")
		{
			NMBDAJFIKEN.SendMessage("SBX", -63, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_13(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Deaths")
		{
			NMBDAJFIKEN.SendMessage("monster", 141, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_14(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Preprocessing mesh: ")
		{
			NMBDAJFIKEN.SendMessage("Ping: ", 86, SendMessageOptions.RequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_3(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "SUR")
		{
			NMBDAJFIKEN.SendMessage("_SoftZDistance", 32, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "Player")
		{
			NMBDAJFIKEN.SendMessage("ApplyFallDamage", 1000, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void __BB_OBFUSCATOR_1(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.tag == "_CameraWS")
		{
			NMBDAJFIKEN.SendMessage("threshold", -141, SendMessageOptions.RequireReceiver);
		}
	}
}
