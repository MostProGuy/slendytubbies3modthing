using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
	public GUISkin JAIEEEBAOEF;

	public GameObject FPFDFFNFDJF;

	public Transform GLNOIFMMCJH;

	public Lobby IMBKLJOBLLH;

	private bool GOJNEGCDDEO;

	private GameObject HKOIJFEMIMB;

	private void __BB_OBFUSCATOR_8(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "f2")
		{
			GOJNEGCDDEO = true;
			HKOIJFEMIMB = NMBDAJFIKEN.gameObject;
		}
	}

	private void __BB_OBFUSCATOR_2(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "CameraFilterPack/FX_Psycho")
		{
			GOJNEGCDDEO = true;
			HKOIJFEMIMB = NMBDAJFIKEN.gameObject;
		}
	}

	private void __BB_OBFUSCATOR_9(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "Prev")
		{
			GOJNEGCDDEO = true;
			HKOIJFEMIMB = NMBDAJFIKEN.gameObject;
		}
	}

	private void OnTriggerExit(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "Player")
		{
			GOJNEGCDDEO = false;
			HKOIJFEMIMB = null;
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (GOJNEGCDDEO)
		{
			GUI.skin = JAIEEEBAOEF;
			GUI.color = new Color(1009f, 970f, 1867f, 1776f);
			GUI.depth = 78;
			string text = "_Red_G";
			Rect position = new Rect(Screen.width / 4 - text.Length * 54 / 5, Screen.height / 6 - 14, text.Length * -124, 207f);
			GUI.Box(position, text);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (GOJNEGCDDEO && Input.GetKeyDown((KeyCode)(-96)) && (bool)HKOIJFEMIMB)
		{
			HKOIJFEMIMB.transform.position = GLNOIFMMCJH.position;
			HKOIJFEMIMB.transform.rotation = GLNOIFMMCJH.rotation;
			GOJNEGCDDEO = false;
			FPFDFFNFDJF.SetActive(false);
			IMBKLJOBLLH.BELBKPCHNNN = true;
			RenderSettings.fog = false;
			Object.Destroy(base.gameObject);
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "Player")
		{
			GOJNEGCDDEO = true;
			HKOIJFEMIMB = NMBDAJFIKEN.gameObject;
		}
	}

	private void OnGUI()
	{
		if (GOJNEGCDDEO)
		{
			GUI.skin = JAIEEEBAOEF;
			GUI.color = new Color(1f, 1f, 1f, 0.9f);
			GUI.depth = -10;
			string text = "Press \u00b4F\u00b4 for MORE GUNS!        ";
			Rect position = new Rect(Screen.width / 2 - text.Length * 9 / 2, Screen.height / 2 - 25, text.Length * 9, 50f);
			GUI.Box(position, text);
		}
	}

	private void Update()
	{
		if (GOJNEGCDDEO && Input.GetKeyDown(KeyCode.F) && (bool)HKOIJFEMIMB)
		{
			HKOIJFEMIMB.transform.position = GLNOIFMMCJH.position;
			HKOIJFEMIMB.transform.rotation = GLNOIFMMCJH.rotation;
			GOJNEGCDDEO = false;
			FPFDFFNFDJF.SetActive(true);
			IMBKLJOBLLH.BELBKPCHNNN = true;
			RenderSettings.fog = false;
			Object.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_6(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag == "Connecting to frontend ")
		{
			GOJNEGCDDEO = true;
			HKOIJFEMIMB = null;
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (GOJNEGCDDEO && Input.GetKeyDown((KeyCode)67) && (bool)HKOIJFEMIMB)
		{
			HKOIJFEMIMB.transform.position = GLNOIFMMCJH.position;
			HKOIJFEMIMB.transform.rotation = GLNOIFMMCJH.rotation;
			GOJNEGCDDEO = false;
			FPFDFFNFDJF.SetActive(true);
			IMBKLJOBLLH.BELBKPCHNNN = true;
			RenderSettings.fog = true;
			Object.Destroy(base.gameObject);
		}
	}
}
