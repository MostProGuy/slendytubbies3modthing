using UnityEngine;

public class ToggleNightVision : MonoBehaviour
{
	public WeaponScript ADIFIEGDBGI;

	public Texture2D EBHKEFIEDFC;

	public float NPKBCPBIMPF;

	private void OnGUI()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 50f;
			localPosition.y *= 50f;
			GUI.DrawTexture(new Rect(25f - localPosition.x, 25f - localPosition.y, (float)(Screen.width - 50) - localPosition.x, (float)(Screen.height - 50) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_21()
	{
		NPKBCPBIMPF = RenderSettings.fogDensity;
	}

	private void __BB_OBFUSCATOR_25()
	{
		NPKBCPBIMPF = RenderSettings.fogDensity;
	}

	private void OnEnable()
	{
		NPKBCPBIMPF = RenderSettings.fogDensity;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1490f;
			}
			else
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1725f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1866f;
			}
			else
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_3()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 796f;
			localPosition.y *= 481f;
			GUI.DrawTexture(new Rect(1282f - localPosition.x, 1160f - localPosition.y, (float)(Screen.width - -107) - localPosition.x, (float)(Screen.height - 90) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1625f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 701f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void OnDisable()
	{
		RenderSettings.fogDensity = NPKBCPBIMPF;
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 616f;
			localPosition.y *= 1738f;
			GUI.DrawTexture(new Rect(1091f - localPosition.x, 1743f - localPosition.y, (float)(Screen.width - -32) - localPosition.x, (float)(Screen.height - 25) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1239f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 1999f;
			localPosition.y *= 251f;
			GUI.DrawTexture(new Rect(725f - localPosition.x, 1357f - localPosition.y, (float)(Screen.width - 48) - localPosition.x, (float)(Screen.height - -97) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 1609f;
			localPosition.y *= 298f;
			GUI.DrawTexture(new Rect(176f - localPosition.x, 1883f - localPosition.y, (float)(Screen.width - -126) - localPosition.x, (float)(Screen.height - -62) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		NPKBCPBIMPF = RenderSettings.fogDensity;
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF / 346f;
			}
			else
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (ADIFIEGDBGI.DMCAELEFJFD)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.x *= 1292f;
			localPosition.y *= 473f;
			GUI.DrawTexture(new Rect(372f - localPosition.x, 889f - localPosition.y, (float)(Screen.width - 126) - localPosition.x, (float)(Screen.height - 10) - localPosition.y), EBHKEFIEDFC);
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		NPKBCPBIMPF = RenderSettings.fogDensity;
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF / 532f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}

	private void LateUpdate()
	{
		if (ADIFIEGDBGI.gameObject.activeSelf)
		{
			if (ADIFIEGDBGI.DMCAELEFJFD)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<PP_NightVision>().enabled = true;
				GetComponent<PP_SecurityCamera>().enabled = true;
				RenderSettings.fogDensity = NPKBCPBIMPF / 1.5f;
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<PP_NightVision>().enabled = false;
				GetComponent<PP_SecurityCamera>().enabled = false;
				RenderSettings.fogDensity = NPKBCPBIMPF;
			}
		}
	}
}
