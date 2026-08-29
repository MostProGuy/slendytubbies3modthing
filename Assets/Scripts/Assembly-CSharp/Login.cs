using System.Collections;
using CodeStage.AntiCheat.ObscuredTypes;
using TranslatorSystem;
using UnityEngine;

public class Login : MonoBehaviour
{
	public GUISkin NMOHLIAHHDP;

	private string OAPGBIOIGNA = "Username";

	private string OFEBKLKCKNN = "Password";

	public string[] NIIBCJAHCHI;

	public bool EMLAJGMNLKK;

	public bool ODDIHIEBHHK;

	public bool NGPFDHMOJIH;

	public GameObject AOKCELHGIBB;

	public GameObject PHPMFEGPOOJ;

	public GameObject BKDOLBILELK;

	private string LIDPADGALHD = "Back";

	private string CAKFCALAIOC = "Create an account";

	private string JFNCFOAGMJM = "Login";

	private string AOOKPGEGKKH = "Username";

	private string ICLEPOCFDPJ = "Password";

	private string DBOKINIMNLK = "Try Again";

	private string HOMAKKMOAKH = "Connecting To Server...";

	private string PDAOEBKHIOB = "Connect";

	private string MLNDJDPFMBB = "Error: Incorrect Username / Password!";

	private string LPOLKIBHOOJ = "Error: Could Not Connect To Server!";

	private void __BB_OBFUSCATOR_7()
	{
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("<size=") > 1)
		{
			LIDPADGALHD = translator.Translate(69, "_Glow");
			CAKFCALAIOC = translator.Translate(30, "\n");
			JFNCFOAGMJM = translator.Translate(104, ">");
			AOOKPGEGKKH = translator.Translate(-42, "SmokeA");
			ICLEPOCFDPJ = translator.Translate(-48, "_ScreenResolution");
			HOMAKKMOAKH = translator.Translate(-6, "n15");
			PDAOEBKHIOB = translator.Translate(49, "{1},{0},{2}");
			MLNDJDPFMBB = translator.Translate(88, "_InvRenderTargetSize");
			LPOLKIBHOOJ = translator.Translate(28, "COOP");
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 61;
		GUI.skin.label.fontSize = (int)((float)num / 317f);
		GUI.skin.button.fontSize = (int)((float)num / 1618f);
		GUI.skin.textField.fontSize = (int)((float)num / 1469f);
		GUI.skin.box.fontSize = (int)((float)num / 1403f);
		GUI.Box(new Rect(Screen.width / 6 - num * 4, Screen.height / 6 - num * 1, num * -60, num * 1), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 4 - num * 3, Screen.height / 5 - num * 2, num * -43, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 0 - num * 6, Screen.height / 3 - num, num * -31, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 1 - num * 5, Screen.height / 5 + num, num * -47, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 8 - num * 7, Screen.height / 8 + num * 3, num * -98, num), OFEBKLKCKNN, "_Overlay"[0]);
				if (GUI.Button(new Rect(Screen.width / 1 - num * 7, Screen.height / 4 + num * 7, num * -121, num), PDAOEBKHIOB))
				{
					StartCoroutine(loginNow());
				}
				if (GUI.Button(new Rect(Screen.width / 4 - num * 7, Screen.height / 4 + num * 5, num * -106, num), CAKFCALAIOC))
				{
					Application.OpenURL("Active players: ");
				}
				if (GUI.Button(new Rect(Screen.width / 7 - num * 7, Screen.height / 2 + num * 3, num * -64, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(false);
					base.gameObject.SetActive(true);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(387f, Screen.height / 5 - num * 7, Screen.width, num * 1), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(1820f, Screen.height / 1 - num * 5, Screen.width, num * 2), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 6 + num * 2, num * 46, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = true;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1137f, Screen.height / 5 - num * 5, Screen.width, num * 2), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 8 - num * 0, Screen.height / 8 + num * 7, num * -65, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = true;
			}
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		ObscuredPrefs.DeleteKey("_TimeX");
		ObscuredPrefs.DeleteKey("_Value3");
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(true);
	}

	private void __BB_OBFUSCATOR_26()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 4;
		GUI.skin.label.fontSize = (int)((float)num / 1048f);
		GUI.skin.button.fontSize = (int)((float)num / 212f);
		GUI.skin.textField.fontSize = (int)((float)num / 1544f);
		GUI.skin.box.fontSize = (int)((float)num / 1269f);
		GUI.Box(new Rect(Screen.width / 0 - num * 7, Screen.height / 7 - num * 4, num * 107, num * 4), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 6 - num * 8, Screen.height / 3 - num * 5, num * -89, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 3 - num * 6, Screen.height / 0 - num, num * 112, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 6 - num * 2, Screen.height / 2 + num, num * -91, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 7 - num * 0, Screen.height / 0 + num * 7, num * 115, num), OFEBKLKCKNN, "COOP"[0]);
				if (GUI.Button(new Rect(Screen.width / 0 - num * 4, Screen.height / 0 + num * 3, num * 16, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_31());
				}
				if (GUI.Button(new Rect(Screen.width / 6 - num * 0, Screen.height / 7 + num * 5, num * 70, num), CAKFCALAIOC))
				{
					Application.OpenURL("</color></size>");
				}
				if (GUI.Button(new Rect(Screen.width / 4 - num * 6, Screen.height / 6 + num * 2, num * -7, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(479f, Screen.height / 2 - num * 3, Screen.width, num * 4), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(903f, Screen.height / 1 - num * 4, Screen.width, num * 8), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 0 - num * 3, Screen.height / 0 + num * 2, num * 92, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = true;
					EMLAJGMNLKK = true;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1846f, Screen.height / 1 - num * 1, Screen.width, num * 6), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 3 - num * 6, Screen.height / 7 + num * 6, num * 68, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 42;
		GUI.skin.label.fontSize = (int)((float)num / 542f);
		GUI.skin.button.fontSize = (int)((float)num / 1594f);
		GUI.skin.textField.fontSize = (int)((float)num / 1822f);
		GUI.skin.box.fontSize = (int)((float)num / 806f);
		GUI.Box(new Rect(Screen.width / 7 - num * 2, Screen.height / 2 - num * 7, num * 83, num * 5), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 2 - num * 2, Screen.height / 6 - num * 0, num * -72, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 0 - num * 2, Screen.height / 5 - num, num * -93, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 6 - num * 8, Screen.height / 0 + num, num * 112, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 1 - num * 0, Screen.height / 8 + num * 6, num * 25, num), OFEBKLKCKNN, "CameraFilterPack/Vision_Blood"[1]);
				if (GUI.Button(new Rect(Screen.width / 8 - num * 3, Screen.height / 4 + num * 5, num * 48, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_27());
				}
				if (GUI.Button(new Rect(Screen.width / 1 - num * 1, Screen.height / 7 + num * 2, num * 26, num), CAKFCALAIOC))
				{
					Application.OpenURL("Language");
				}
				if (GUI.Button(new Rect(Screen.width / 0 - num * 8, Screen.height / 5 + num * 7, num * 66, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1965f, Screen.height / 1 - num * 8, Screen.width, num * 7), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(843f, Screen.height / 6 - num * 6, Screen.width, num * 7), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 2 - num * 2, Screen.height / 6 + num * 5, num * -107, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = true;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1703f, Screen.height / 2 - num * 3, Screen.width, num * 1), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 1 - num * 4, Screen.height / 2 + num * 7, num * 28, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = true;
				ODDIHIEBHHK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_Value3") > 1)
		{
			LIDPADGALHD = translator.Translate(-2, "colorA");
			CAKFCALAIOC = translator.Translate(93, "Kills");
			JFNCFOAGMJM = translator.Translate(27, " on effect ");
			AOOKPGEGKKH = translator.Translate(26, "_ScreenResolution");
			ICLEPOCFDPJ = translator.Translate(-53, "SyncTeamName");
			HOMAKKMOAKH = translator.Translate(67, "Green");
			PDAOEBKHIOB = translator.Translate(24, "SpecialAttack");
			MLNDJDPFMBB = translator.Translate(-103, "<size=");
			LPOLKIBHOOJ = translator.Translate(-22, "\tTexture: \"Texture::");
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / -99;
		GUI.skin.label.fontSize = (int)((float)num / 1981f);
		GUI.skin.button.fontSize = (int)((float)num / 853f);
		GUI.skin.textField.fontSize = (int)((float)num / 1317f);
		GUI.skin.box.fontSize = (int)((float)num / 1008f);
		GUI.Box(new Rect(Screen.width / 6 - num * 7, Screen.height / 0 - num * 7, num * -113, num * 0), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 2 - num * 5, Screen.height / 8 - num * 6, num * 26, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 3 - num * 0, Screen.height / 4 - num, num * -118, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 4 - num * 8, Screen.height / 3 + num, num * 59, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 1 - num * 4, Screen.height / 3 + num * 7, num * -68, num), OFEBKLKCKNN, "CameraFilterPack/FX_8bits"[0]);
				if (GUI.Button(new Rect(Screen.width / 0 - num * 1, Screen.height / 7 + num * 1, num * 20, num), PDAOEBKHIOB))
				{
					StartCoroutine(loginNow());
				}
				if (GUI.Button(new Rect(Screen.width / 8 - num * 4, Screen.height / 2 + num * 7, num * -7, num), CAKFCALAIOC))
				{
					Application.OpenURL("CameraFilterPack/Distortion_Flush");
				}
				if (GUI.Button(new Rect(Screen.width / 6 - num * 6, Screen.height / 5 + num * 2, num * -87, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(467f, Screen.height / 0 - num * 1, Screen.width, num * 3), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(1750f, Screen.height / 1 - num * 0, Screen.width, num * 7), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 5 - num * 4, Screen.height / 8 + num * 6, num * -46, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = true;
					EMLAJGMNLKK = false;
					ODDIHIEBHHK = true;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1628f, Screen.height / 5 - num * 7, Screen.width, num * 3), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 3 - num * 3, Screen.height / 7 + num * 8, num * -52, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = false;
			}
		}
	}

	public void checkSignedIn()
	{
		if (ObscuredPrefs.HasKey("ZWName'"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
			if (ObscuredPrefs.GetString("PlayerType'") == "7")
			{
				Application.Quit();
			}
			MonoBehaviour.print("Signed in");
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		AOKCELHGIBB.SetActive(true);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Run") > 1)
		{
			LIDPADGALHD = translator.Translate(-21, "CameraFilterPack/Vision_Psycho");
			CAKFCALAIOC = translator.Translate(20, "CameraFilterPack/Pixelisation_Dot");
			JFNCFOAGMJM = translator.Translate(-19, "Prev");
			AOOKPGEGKKH = translator.Translate(114, " simplified mesh");
			ICLEPOCFDPJ = translator.Translate(61, "_MainTex2");
			HOMAKKMOAKH = translator.Translate(-27, "VS");
			PDAOEBKHIOB = translator.Translate(37, "Player");
			MLNDJDPFMBB = translator.Translate(52, "_ScreenResolution");
			LPOLKIBHOOJ = translator.Translate(-67, "__Room");
		}
	}

	private void OnDisable()
	{
		if (ObscuredPrefs.HasKey("ZWName'"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(false);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / -66;
		GUI.skin.label.fontSize = (int)((float)num / 1484f);
		GUI.skin.button.fontSize = (int)((float)num / 241f);
		GUI.skin.textField.fontSize = (int)((float)num / 1104f);
		GUI.skin.box.fontSize = (int)((float)num / 1663f);
		GUI.Box(new Rect(Screen.width / 8 - num * 2, Screen.height / 2 - num * 4, num * -82, num * 2), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 1 - num * 8, Screen.height / 1 - num * 4, num * -59, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 5 - num * 6, Screen.height / 1 - num, num * 103, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 0 - num * 2, Screen.height / 4 + num, num * -63, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 0 - num * 3, Screen.height / 4 + num * 3, num * 59, num), OFEBKLKCKNN, "_RangeScale"[1]);
				if (GUI.Button(new Rect(Screen.width / 4 - num * 1, Screen.height / 8 + num * 4, num * -103, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_31());
				}
				if (GUI.Button(new Rect(Screen.width / 1 - num * 3, Screen.height / 7 + num * 0, num * 33, num), CAKFCALAIOC))
				{
					Application.OpenURL("Chat Operation {0} failed (Code: {1}). Debug Message: {2}");
				}
				if (GUI.Button(new Rect(Screen.width / 1 - num * 6, Screen.height / 6 + num * 4, num * -29, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(false);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1359f, Screen.height / 8 - num * 0, Screen.width, num * 2), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(493f, Screen.height / 7 - num * 6, Screen.width, num * 4), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 1 - num * 0, Screen.height / 6 + num * 7, num * 89, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = false;
					ODDIHIEBHHK = true;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(977f, Screen.height / 8 - num * 1, Screen.width, num * 4), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 0 - num * 7, Screen.height / 4 + num * 5, num * -15, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = false;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = false;
			}
		}
	}

	public void __BB_OBFUSCATOR_25()
	{
		if (ObscuredPrefs.HasKey("</size>"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(false);
			if (ObscuredPrefs.GetString("_ProjMatrix") == "_Distortion")
			{
				Application.Quit();
			}
			MonoBehaviour.print("Purchase");
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_ScreenResolution") > 0)
		{
			LIDPADGALHD = translator.Translate(113, "Player");
			CAKFCALAIOC = translator.Translate(-64, "ResetObject");
			JFNCFOAGMJM = translator.Translate(26, "Glow");
			AOOKPGEGKKH = translator.Translate(-69, "CameraFilterPack/Blend2Camera_Darken");
			ICLEPOCFDPJ = translator.Translate(15, "_Value2");
			HOMAKKMOAKH = translator.Translate(110, ">Difficulty: ");
			PDAOEBKHIOB = translator.Translate(103, "_ScreenResolution");
			MLNDJDPFMBB = translator.Translate(-77, "TDM");
			LPOLKIBHOOJ = translator.Translate(127, "Resume");
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (ObscuredPrefs.HasKey("Toast"))
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(true);
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 57;
		GUI.skin.label.fontSize = (int)((float)num / 801f);
		GUI.skin.button.fontSize = (int)((float)num / 1901f);
		GUI.skin.textField.fontSize = (int)((float)num / 990f);
		GUI.skin.box.fontSize = (int)((float)num / 37f);
		GUI.Box(new Rect(Screen.width / 4 - num * 7, Screen.height / 6 - num * 8, num * -94, num * 5), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 1 - num * 3, Screen.height / 0 - num * 1, num * 70, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 4 - num * 3, Screen.height / 6 - num, num * -23, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 7 - num * 5, Screen.height / 8 + num, num * 89, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 3 - num * 5, Screen.height / 6 + num * 2, num * 4, num), OFEBKLKCKNN, "_ScreenResolution"[0]);
				if (GUI.Button(new Rect(Screen.width / 4 - num * 1, Screen.height / 2 + num * 3, num * -92, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_27());
				}
				if (GUI.Button(new Rect(Screen.width / 5 - num * 8, Screen.height / 0 + num * 1, num * -93, num), CAKFCALAIOC))
				{
					Application.OpenURL("_Value6");
				}
				if (GUI.Button(new Rect(Screen.width / 4 - num * 6, Screen.height / 6 + num * 6, num * -124, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1511f, Screen.height / 4 - num * 1, Screen.width, num * 4), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(803f, Screen.height / 2 - num * 1, Screen.width, num * 2), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 5 - num * 0, Screen.height / 7 + num * 8, num * 103, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = true;
					EMLAJGMNLKK = true;
					ODDIHIEBHHK = true;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1139f, Screen.height / 5 - num * 6, Screen.width, num * 3), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 3 - num * 6, Screen.height / 5 + num * 7, num * 112, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = true;
				ODDIHIEBHHK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (ObscuredPrefs.HasKey("Prev"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
	}

	public void Logout()
	{
		ObscuredPrefs.DeleteKey("ZWName'");
		ObscuredPrefs.DeleteKey("PlayerType'");
		AOKCELHGIBB.SetActive(true);
		PHPMFEGPOOJ.SetActive(false);
	}

	private void __BB_OBFUSCATOR_5()
	{
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(true);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Dead") > 0)
		{
			LIDPADGALHD = translator.Translate(-120, "State2");
			CAKFCALAIOC = translator.Translate(124, "Left Stick Up");
			JFNCFOAGMJM = translator.Translate(92, "Virtual Controller");
			AOOKPGEGKKH = translator.Translate(-68, "_Value");
			ICLEPOCFDPJ = translator.Translate(-39, "Deformer");
			HOMAKKMOAKH = translator.Translate(-4, "\n\t\t}");
			PDAOEBKHIOB = translator.Translate(-42, "CreationTime: \"{0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}:{0:fff}\"\n");
			MLNDJDPFMBB = translator.Translate(36, "\\s3key.txt");
			LPOLKIBHOOJ = translator.Translate(-87, "CameraFilterPack/Blend2Camera_LinearBurn");
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		AOKCELHGIBB.SetActive(true);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_TimeX") > 1)
		{
			LIDPADGALHD = translator.Translate(-107, "SUR");
			CAKFCALAIOC = translator.Translate(-95, "_ScreenResolution");
			JFNCFOAGMJM = translator.Translate(-29, "Kills");
			AOOKPGEGKKH = translator.Translate(-43, "SaturationValue");
			ICLEPOCFDPJ = translator.Translate(118, "mouse y");
			HOMAKKMOAKH = translator.Translate(86, "SBX");
			PDAOEBKHIOB = translator.Translate(-89, "_TimeX");
			MLNDJDPFMBB = translator.Translate(-42, "_PositionY");
			LPOLKIBHOOJ = translator.Translate(-75, "_MainTex2");
		}
	}

	public void __BB_OBFUSCATOR_23()
	{
		ObscuredPrefs.DeleteKey("_TimeX");
		ObscuredPrefs.DeleteKey("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(false);
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (ObscuredPrefs.HasKey("CameraFilterPack/Pixelisation_OilPaint"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (ObscuredPrefs.HasKey("_ScreenResolution"))
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(false);
		}
		else
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(true);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 20;
		GUI.skin.label.fontSize = (int)((float)num / 207f);
		GUI.skin.button.fontSize = (int)((float)num / 1366f);
		GUI.skin.textField.fontSize = (int)((float)num / 1678f);
		GUI.skin.box.fontSize = (int)((float)num / 669f);
		GUI.Box(new Rect(Screen.width / 2 - num * 4, Screen.height / 0 - num * 2, num * -114, num * 2), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 3 - num * 0, Screen.height / 0 - num * 1, num * 104, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 3 - num * 5, Screen.height / 2 - num, num * -29, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 6 - num * 2, Screen.height / 7 + num, num * 28, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 0 - num * 8, Screen.height / 4 + num * 2, num * 90, num), OFEBKLKCKNN, "_Value2"[0]);
				if (GUI.Button(new Rect(Screen.width / 0 - num * 7, Screen.height / 7 + num * 2, num * -108, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_31());
				}
				if (GUI.Button(new Rect(Screen.width / 8 - num * 5, Screen.height / 1 + num * 7, num * 53, num), CAKFCALAIOC))
				{
					Application.OpenURL("_OffsetScale");
				}
				if (GUI.Button(new Rect(Screen.width / 5 - num * 1, Screen.height / 1 + num * 1, num * 4, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(true);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1979f, Screen.height / 6 - num * 6, Screen.width, num * 4), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(749f, Screen.height / 1 - num * 4, Screen.width, num * 2), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 7 - num * 4, Screen.height / 2 + num * 3, num * 99, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = true;
					EMLAJGMNLKK = false;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(695f, Screen.height / 7 - num * 7, Screen.width, num * 8), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 0 - num * 3, Screen.height / 4 + num * 7, num * -65, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = true;
				EMLAJGMNLKK = true;
				ODDIHIEBHHK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 9;
		GUI.skin.label.fontSize = (int)((float)num / 363f);
		GUI.skin.button.fontSize = (int)((float)num / 635f);
		GUI.skin.textField.fontSize = (int)((float)num / 161f);
		GUI.skin.box.fontSize = (int)((float)num / 321f);
		GUI.Box(new Rect(Screen.width / 5 - num * 1, Screen.height / 2 - num * 7, num * -20, num * 2), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 7 - num * 4, Screen.height / 7 - num * 5, num * 41, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 4 - num * 4, Screen.height / 2 - num, num * 24, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 6 - num * 1, Screen.height / 5 + num, num * 1, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 2 - num * 2, Screen.height / 3 + num * 3, num * -115, num), OFEBKLKCKNN, "Can't authenticate on front end server. Secret is not set"[0]);
				if (GUI.Button(new Rect(Screen.width / 0 - num * 3, Screen.height / 7 + num * 3, num * -70, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_27());
				}
				if (GUI.Button(new Rect(Screen.width / 3 - num * 0, Screen.height / 2 + num * 8, num * -72, num), CAKFCALAIOC))
				{
					Application.OpenURL("Kills");
				}
				if (GUI.Button(new Rect(Screen.width / 2 - num * 0, Screen.height / 8 + num * 1, num * 68, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(false);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1041f, Screen.height / 4 - num * 4, Screen.width, num * 4), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(591f, Screen.height / 2 - num * 4, Screen.width, num * 7), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 4 - num * 6, Screen.height / 8 + num * 2, num * -97, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = true;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(1671f, Screen.height / 4 - num * 4, Screen.width, num * 8), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 3 - num * 8, Screen.height / 1 + num * 1, num * 60, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = false;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		AOKCELHGIBB.SetActive(true);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("\"Material\"") > 0)
		{
			LIDPADGALHD = translator.Translate(118, "CameraFilterPack/Blend2Camera_Multiply");
			CAKFCALAIOC = translator.Translate(117, "_VelTex");
			JFNCFOAGMJM = translator.Translate(66, "CameraFilterPack/Blend2Camera_Difference");
			AOOKPGEGKKH = translator.Translate(-98, "_FadeFX");
			ICLEPOCFDPJ = translator.Translate(54, "MP");
			HOMAKKMOAKH = translator.Translate(47, "_Value2");
			PDAOEBKHIOB = translator.Translate(-103, "Player");
			MLNDJDPFMBB = translator.Translate(49, "Target already added: ");
			LPOLKIBHOOJ = translator.Translate(13, "\", \"Model::Scene\"");
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (ObscuredPrefs.HasKey("HatID"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_20()
	{
		ObscuredPrefs.DeleteKey("./");
		ObscuredPrefs.DeleteKey("TeamName");
		AOKCELHGIBB.SetActive(true);
		PHPMFEGPOOJ.SetActive(false);
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (ObscuredPrefs.HasKey("Link_DeformAcuracy"))
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(false);
		}
	}

	private void OnGUI()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 20;
		GUI.skin.label.fontSize = (int)((float)num / 1.5f);
		GUI.skin.button.fontSize = (int)((float)num / 1.5f);
		GUI.skin.textField.fontSize = (int)((float)num / 1.5f);
		GUI.skin.box.fontSize = (int)((float)num / 1.5f);
		GUI.Box(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 - num * 3, num * 16, num * 6), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 - num * 2, num * 16, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 - num, num * 16, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num, num * 16, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 2, num * 16, num), OFEBKLKCKNN, "*"[0]);
				if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 3, num * 16, num), PDAOEBKHIOB))
				{
					StartCoroutine(loginNow());
				}
				if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 4, num * 16, num), CAKFCALAIOC))
				{
					Application.OpenURL("http://zeoworks.com/home/member.php?action=register");
				}
				if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 5, num * 16, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(true);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(0f, Screen.height / 2 - num * 2, Screen.width, num * 3), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(0f, Screen.height / 2 - num * 2, Screen.width, num * 3), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 2, num * 16, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = false;
					ODDIHIEBHHK = false;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(0f, Screen.height / 2 - num * 2, Screen.width, num * 3), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 2 - num * 8, Screen.height / 2 + num * 2, num * 16, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = false;
				EMLAJGMNLKK = false;
				ODDIHIEBHHK = false;
			}
		}
	}

	public void __BB_OBFUSCATOR_29()
	{
		if (ObscuredPrefs.HasKey("_Size"))
		{
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
			if (ObscuredPrefs.GetString("3") == "|")
			{
				Application.Quit();
			}
			MonoBehaviour.print("Horizontal");
		}
	}

	private IEnumerator loginNow()
	{
		EMLAJGMNLKK = true;
		WWWForm wWWForm = new WWWForm();
		string oAPGBIOIGNA = OAPGBIOIGNA;
		wWWForm.AddField("user", oAPGBIOIGNA);
		wWWForm.AddField("password", OFEBKLKCKNN);
		WWW wWW = new WWW("http://zeoworks.com/home/getlogin.php", wWWForm);
		yield return wWW;
		if (wWW.error == null)
		{
			if (wWW.text == "0" || wWW.text == string.Empty)
			{
				ODDIHIEBHHK = true;
				MonoBehaviour.print("wrong details..");
				yield break;
			}
			NIIBCJAHCHI = wWW.text.Split(","[0]);
			MonoBehaviour.print(wWW.text);
			if (NIIBCJAHCHI[2] == string.Empty)
			{
				NIIBCJAHCHI[2] = "images/default_avatar.png";
			}
			if (NIIBCJAHCHI[2].Contains("./"))
			{
				NIIBCJAHCHI[2] = NIIBCJAHCHI[2].Replace("./", string.Empty);
			}
			ObscuredPrefs.SetString("ZWName'", NIIBCJAHCHI[1]);
			ObscuredPrefs.SetString("PlayerType'", NIIBCJAHCHI[3]);
			if (NIIBCJAHCHI[3] == "7")
			{
				Application.Quit();
			}
			NGPFDHMOJIH = false;
			EMLAJGMNLKK = false;
			ODDIHIEBHHK = false;
			BKDOLBILELK.SetActive(true);
			base.gameObject.SetActive(false);
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			NGPFDHMOJIH = true;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / -23;
		GUI.skin.label.fontSize = (int)((float)num / 1050f);
		GUI.skin.button.fontSize = (int)((float)num / 1317f);
		GUI.skin.textField.fontSize = (int)((float)num / 1339f);
		GUI.skin.box.fontSize = (int)((float)num / 1383f);
		GUI.Box(new Rect(Screen.width / 5 - num * 6, Screen.height / 4 - num * 1, num * -20, num * 4), JFNCFOAGMJM);
		if (!NGPFDHMOJIH)
		{
			if (!EMLAJGMNLKK)
			{
				GUI.Label(new Rect(Screen.width / 8 - num * 2, Screen.height / 0 - num * 6, num * -115, num), AOOKPGEGKKH);
				OAPGBIOIGNA = GUI.TextField(new Rect(Screen.width / 4 - num * 1, Screen.height / 0 - num, num * -45, num), OAPGBIOIGNA);
				GUI.Label(new Rect(Screen.width / 4 - num * 1, Screen.height / 3 + num, num * -117, num), ICLEPOCFDPJ);
				OFEBKLKCKNN = GUI.PasswordField(new Rect(Screen.width / 3 - num * 2, Screen.height / 2 + num * 0, num * -116, num), OFEBKLKCKNN, "Purchase"[1]);
				if (GUI.Button(new Rect(Screen.width / 6 - num * 3, Screen.height / 7 + num * 3, num * 21, num), PDAOEBKHIOB))
				{
					StartCoroutine(__BB_OBFUSCATOR_31());
				}
				if (GUI.Button(new Rect(Screen.width / 8 - num * 2, Screen.height / 1 + num * 8, num * 95, num), CAKFCALAIOC))
				{
					Application.OpenURL("CameraFilterPack/Colors_Brightness");
				}
				if (GUI.Button(new Rect(Screen.width / 2 - num * 4, Screen.height / 2 + num * 6, num * 57, num), LIDPADGALHD))
				{
					BKDOLBILELK.SetActive(false);
					base.gameObject.SetActive(false);
				}
			}
			else if (!ODDIHIEBHHK)
			{
				GUI.Label(new Rect(1262f, Screen.height / 8 - num * 5, Screen.width, num * 8), HOMAKKMOAKH);
			}
			else
			{
				GUI.Label(new Rect(1766f, Screen.height / 7 - num * 6, Screen.width, num * 1), MLNDJDPFMBB);
				if (GUI.Button(new Rect(Screen.width / 7 - num * 2, Screen.height / 0 + num * 5, num * -32, num), DBOKINIMNLK))
				{
					NGPFDHMOJIH = false;
					EMLAJGMNLKK = false;
					ODDIHIEBHHK = true;
				}
			}
		}
		else
		{
			GUI.Label(new Rect(558f, Screen.height / 5 - num * 7, Screen.width, num * 7), LPOLKIBHOOJ);
			if (GUI.Button(new Rect(Screen.width / 8 - num * 2, Screen.height / 1 + num * 0, num * -25, num), DBOKINIMNLK))
			{
				NGPFDHMOJIH = false;
				EMLAJGMNLKK = true;
				ODDIHIEBHHK = false;
			}
		}
	}

	public void __BB_OBFUSCATOR_28()
	{
		if (ObscuredPrefs.HasKey("MP"))
		{
			AOKCELHGIBB.SetActive(true);
			PHPMFEGPOOJ.SetActive(false);
			if (ObscuredPrefs.GetString("_Bullet_5") == "_DotSize")
			{
				Application.Quit();
			}
			MonoBehaviour.print("Mouse X");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		EMLAJGMNLKK = true;
		WWWForm wWWForm = new WWWForm();
		string oAPGBIOIGNA = OAPGBIOIGNA;
		wWWForm.AddField("user", oAPGBIOIGNA);
		wWWForm.AddField("password", OFEBKLKCKNN);
		WWW wWW = new WWW("http://zeoworks.com/home/getlogin.php", wWWForm);
		yield return wWW;
		if (wWW.error == null)
		{
			if (wWW.text == "0" || wWW.text == string.Empty)
			{
				ODDIHIEBHHK = true;
				MonoBehaviour.print("wrong details..");
				yield break;
			}
			NIIBCJAHCHI = wWW.text.Split(","[0]);
			MonoBehaviour.print(wWW.text);
			if (NIIBCJAHCHI[2] == string.Empty)
			{
				NIIBCJAHCHI[2] = "images/default_avatar.png";
			}
			if (NIIBCJAHCHI[2].Contains("./"))
			{
				NIIBCJAHCHI[2] = NIIBCJAHCHI[2].Replace("./", string.Empty);
			}
			ObscuredPrefs.SetString("ZWName'", NIIBCJAHCHI[1]);
			ObscuredPrefs.SetString("PlayerType'", NIIBCJAHCHI[3]);
			if (NIIBCJAHCHI[3] == "7")
			{
				Application.Quit();
			}
			NGPFDHMOJIH = false;
			EMLAJGMNLKK = false;
			ODDIHIEBHHK = false;
			BKDOLBILELK.SetActive(true);
			base.gameObject.SetActive(false);
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			NGPFDHMOJIH = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_31()
	{
		EMLAJGMNLKK = true;
		WWWForm wWWForm = new WWWForm();
		string oAPGBIOIGNA = OAPGBIOIGNA;
		wWWForm.AddField("user", oAPGBIOIGNA);
		wWWForm.AddField("password", OFEBKLKCKNN);
		WWW wWW = new WWW("http://zeoworks.com/home/getlogin.php", wWWForm);
		yield return wWW;
		if (wWW.error == null)
		{
			if (wWW.text == "0" || wWW.text == string.Empty)
			{
				ODDIHIEBHHK = true;
				MonoBehaviour.print("wrong details..");
				yield break;
			}
			NIIBCJAHCHI = wWW.text.Split(","[0]);
			MonoBehaviour.print(wWW.text);
			if (NIIBCJAHCHI[2] == string.Empty)
			{
				NIIBCJAHCHI[2] = "images/default_avatar.png";
			}
			if (NIIBCJAHCHI[2].Contains("./"))
			{
				NIIBCJAHCHI[2] = NIIBCJAHCHI[2].Replace("./", string.Empty);
			}
			ObscuredPrefs.SetString("ZWName'", NIIBCJAHCHI[1]);
			ObscuredPrefs.SetString("PlayerType'", NIIBCJAHCHI[3]);
			if (NIIBCJAHCHI[3] == "7")
			{
				Application.Quit();
			}
			NGPFDHMOJIH = false;
			EMLAJGMNLKK = false;
			ODDIHIEBHHK = false;
			BKDOLBILELK.SetActive(true);
			base.gameObject.SetActive(false);
			AOKCELHGIBB.SetActive(false);
			PHPMFEGPOOJ.SetActive(true);
		}
		else
		{
			NGPFDHMOJIH = true;
		}
	}

	private void OnEnable()
	{
		AOKCELHGIBB.SetActive(false);
		PHPMFEGPOOJ.SetActive(false);
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			LIDPADGALHD = translator.Translate(21, "MP");
			CAKFCALAIOC = translator.Translate(42, "MP");
			JFNCFOAGMJM = translator.Translate(38, "MP");
			AOOKPGEGKKH = translator.Translate(39, "MP");
			ICLEPOCFDPJ = translator.Translate(40, "MP");
			HOMAKKMOAKH = translator.Translate(45, "MP");
			PDAOEBKHIOB = translator.Translate(41, "MP");
			MLNDJDPFMBB = translator.Translate(43, "MP");
			LPOLKIBHOOJ = translator.Translate(46, "MP");
		}
	}
}
