using UnityEngine;

public class DrawPlayerName : MonoBehaviour
{
	public GUISkin KIMBOADOOCP;

	public Transform ANDHPKKEEFB;

	public Texture2D DMEIDCPJFON;

	private string DLHMCKDJIHG;

	private int GJJLCBEIBPC;

	public Color[] NHMHKJGPDCA;

	public bool PAGBFJLNMIF;

	private PlayerDamage IHCFOJAFGEG;

	private GUIStyle OLCONFFIKFO = new GUIStyle();

	private void __BB_OBFUSCATOR_49()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 3;
		float num = 645f;
		GUI.color = new Color(1273f, 1773f, 1912f, 165f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1409f < 945f)) ? 1783f : (vector.z * 1661f));
		if (!(vector.z > 1268f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("Can't authenticate on front end server. Secret is not set");
			style.alignment = TextAnchor.LowerCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 333f, (float)Screen.height - vector.y - 910f - num, 1130f, 1133f), "Animation Data", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1808f, (float)Screen.height - vector.y + 1308f - num, IHCFOJAFGEG.CNNOMBEAPIH / 721f, 170f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1554f, (float)Screen.height - vector.y + 1383f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1362f, 1641f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Exit");
		style2.alignment = TextAnchor.MiddleLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 744f, (float)Screen.height - vector.y - 377f - num, 1048f, 990f), "Team1Score" + DLHMCKDJIHG + "CameraFilterPack/Vision_Psycho", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 386f, (float)Screen.height - vector.y - 1957f - num, 1524f, 607f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 872f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 657f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 955f, (float)Screen.height - vector.y + 652f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1043f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 54f, (float)Screen.height - vector.y + 932f - num, IHCFOJAFGEG.HLPBCOGDPCF, 74f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_8()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_13()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_Value2").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.UpperRight;
	}

	private void __BB_OBFUSCATOR_51()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("Text").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerRight;
	}

	private void __BB_OBFUSCATOR_28()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 6;
		float num = 1758f;
		GUI.color = new Color(1485f, 45f, 1188f, 999f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1557f < 600f)) ? 77f : (vector.z * 1232f));
		if (!(vector.z > 1199f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("Team1Score");
			style.alignment = TextAnchor.UpperRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1003f, (float)Screen.height - vector.y - 498f - num, 666f, 1099f), "_Value", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1873f, (float)Screen.height - vector.y + 690f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1050f, 1913f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 675f, (float)Screen.height - vector.y + 1914f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1800f, 840f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("_TimeX");
		style2.alignment = TextAnchor.LowerCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1783f, (float)Screen.height - vector.y - 111f - num, 877f, 574f), "Kills" + DLHMCKDJIHG + "_Value4", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1486f, (float)Screen.height - vector.y - 227f - num, 536f, 1549f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 476f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 223f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 726f, (float)Screen.height - vector.y + 1000f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1768f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 275f, (float)Screen.height - vector.y + 825f - num, IHCFOJAFGEG.HLPBCOGDPCF, 34f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void Update()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_56()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_Offsets").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.MiddleRight;
	}

	private void __BB_OBFUSCATOR_5()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 4;
		float num = 367f;
		GUI.color = new Color(310f, 73f, 1297f, 1723f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 625f < 625f)) ? 808f : (vector.z * 1980f));
		if (!(vector.z > 1776f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_Value");
			style.alignment = TextAnchor.LowerRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1806f, (float)Screen.height - vector.y - 702f - num, 1555f, 971f), "_Normal", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 764f, (float)Screen.height - vector.y + 216f - num, IHCFOJAFGEG.CNNOMBEAPIH / 501f, 868f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1841f, (float)Screen.height - vector.y + 982f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1339f, 867f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("_Value2");
		style2.alignment = TextAnchor.UpperRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 563f, (float)Screen.height - vector.y - 1629f - num, 1360f, 1494f), "All Players" + DLHMCKDJIHG + "[0-9]", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 463f, (float)Screen.height - vector.y - 1064f - num, 1932f, 1340f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1811f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 350f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1564f, (float)Screen.height - vector.y + 1217f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1633f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1960f, (float)Screen.height - vector.y + 720f - num, IHCFOJAFGEG.HLPBCOGDPCF, 943f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_15()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_60()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 2;
		float num = 1809f;
		GUI.color = new Color(1125f, 1265f, 835f, 1276f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1614f < 1820f)) ? 189f : (vector.z * 1585f));
		if (!(vector.z > 1583f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("CameraFilterPack/Blend2Camera_PinLight");
			style.alignment = TextAnchor.LowerRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 428f, (float)Screen.height - vector.y - 1027f - num, 781f, 288f), " ☠", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1454f, (float)Screen.height - vector.y + 1191f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1549f, 1566f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1917f, (float)Screen.height - vector.y + 1847f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1639f, 1986f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: ");
		style2.alignment = TextAnchor.MiddleRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1003f, (float)Screen.height - vector.y - 1583f - num, 1824f, 1391f), "_TimeX" + DLHMCKDJIHG + "_TimeX", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1055f, (float)Screen.height - vector.y - 458f - num, 317f, 1060f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1765f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 209f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1744f, (float)Screen.height - vector.y + 968f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1531f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 763f, (float)Screen.height - vector.y + 1452f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1063f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_54()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_Distortion").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.UpperRight;
	}

	private void __BB_OBFUSCATOR_40()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_33()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("CameraFilterPack/TV_Old_Movie").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.MiddleRight;
	}

	private void __BB_OBFUSCATOR_42()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_18()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_26()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_2()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 2;
		float num = 507f;
		GUI.color = new Color(19f, 253f, 1914f, 19f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1922f < 1291f)) ? 1012f : (vector.z * 876f));
		if (!(vector.z > 1064f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("n15");
			style.alignment = TextAnchor.LowerLeft;
			style.font = null;
			GUI.Label(new Rect(vector.x - 629f, (float)Screen.height - vector.y - 852f - num, 1673f, 1900f), "_Color_B", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1926f, (float)Screen.height - vector.y + 968f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1844f, 1112f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 834f, (float)Screen.height - vector.y + 635f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1262f, 1474f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Vertical");
		style2.alignment = TextAnchor.UpperRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 731f, (float)Screen.height - vector.y - 40f - num, 84f, 1336f), "_Offsets" + DLHMCKDJIHG + "_Screen", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 94f, (float)Screen.height - vector.y - 449f - num, 1700f, 981f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 105f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 4f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 328f, (float)Screen.height - vector.y + 148f - num, IHCFOJAFGEG.CNNOMBEAPIH, 357f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 766f, (float)Screen.height - vector.y + 392f - num, IHCFOJAFGEG.HLPBCOGDPCF, 326f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_50()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 5;
		float num = 463f;
		GUI.color = new Color(1664f, 1574f, 1718f, 142f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 69f < 1109f)) ? 760f : (vector.z * 13f));
		if (!(vector.z > 1661f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_TimeX");
			style.alignment = TextAnchor.LowerCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 941f, (float)Screen.height - vector.y - 1568f - num, 75f, 1160f), "<size=", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 185f, (float)Screen.height - vector.y + 286f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1064f, 1570f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 620f, (float)Screen.height - vector.y + 910f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1787f, 1994f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Speed (");
		style2.alignment = TextAnchor.UpperLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 67f, (float)Screen.height - vector.y - 1674f - num, 1858f, 1518f), "AntiCheat" + DLHMCKDJIHG + "Diffuse", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 449f, (float)Screen.height - vector.y - 461f - num, 352f, 776f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1102f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1629f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 528f, (float)Screen.height - vector.y + 1118f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1876f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1632f, (float)Screen.height - vector.y + 847f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1905f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_21()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 5;
		float num = 1320f;
		GUI.color = new Color(1497f, 1318f, 541f, 851f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1365f < 1376f)) ? 925f : (vector.z * 1995f));
		if (!(vector.z > 1354f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("(");
			style.alignment = TextAnchor.MiddleRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 912f, (float)Screen.height - vector.y - 1515f - num, 1314f, 223f), "box", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1650f, (float)Screen.height - vector.y + 1345f - num, IHCFOJAFGEG.CNNOMBEAPIH / 944f, 951f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1522f, (float)Screen.height - vector.y + 810f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 694f, 1876f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Infect");
		style2.alignment = TextAnchor.LowerCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 270f, (float)Screen.height - vector.y - 291f - num, 1956f, 536f), "COOP" + DLHMCKDJIHG + "Indicator ID not valid. Check Off Screen Indicator Indicators list.", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1877f, (float)Screen.height - vector.y - 652f - num, 905f, 1611f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 473f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 553f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 352f, (float)Screen.height - vector.y + 157f - num, IHCFOJAFGEG.CNNOMBEAPIH, 531f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 899f, (float)Screen.height - vector.y + 1387f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1635f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_7()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_9()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("-Vertical").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerRight;
	}

	private void __BB_OBFUSCATOR_53()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_TintColor").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.MiddleLeft;
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 7;
		float num = 1732f;
		GUI.color = new Color(962f, 1003f, 1011f, 730f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1642f < 1713f)) ? 1979f : (vector.z * 398f));
		if (!(vector.z > 1002f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_TimeX");
			style.alignment = TextAnchor.MiddleRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 62f, (float)Screen.height - vector.y - 224f - num, 878f, 1163f), "_Value4", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 736f, (float)Screen.height - vector.y + 1289f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1097f, 833f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 403f, (float)Screen.height - vector.y + 1452f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 196f, 1363f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Hidden/GlobalFog");
		style2.alignment = TextAnchor.UpperRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1882f, (float)Screen.height - vector.y - 1928f - num, 1612f, 1446f), "Failed on creating room" + DLHMCKDJIHG + "_NoiseAmount", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1657f, (float)Screen.height - vector.y - 1375f - num, 462f, 309f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 345f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1105f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 256f, (float)Screen.height - vector.y + 875f - num, IHCFOJAFGEG.CNNOMBEAPIH, 563f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1903f, (float)Screen.height - vector.y + 394f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1713f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_46()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 1;
		float num = 1959f;
		GUI.color = new Color(1380f, 1375f, 167f, 247f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1622f < 249f)) ? 324f : (vector.z * 16f));
		if (!(vector.z > 1123f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("Ping: ");
			style.alignment = TextAnchor.LowerLeft;
			style.font = null;
			GUI.Label(new Rect(vector.x - 995f, (float)Screen.height - vector.y - 531f - num, 167f, 924f), "_Value2", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1709f, (float)Screen.height - vector.y + 973f - num, IHCFOJAFGEG.CNNOMBEAPIH / 458f, 1097f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1949f, (float)Screen.height - vector.y + 1096f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1895f, 17f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("CameraFilterPack/Oculus_NightVision2");
		style2.alignment = TextAnchor.LowerCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1326f, (float)Screen.height - vector.y - 1844f - num, 1421f, 956f), "CameraFilterPack/Distortion_BlackHole" + DLHMCKDJIHG + "CameraFilterPack/Pixel_Pixelisation", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 524f, (float)Screen.height - vector.y - 534f - num, 1223f, 269f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1014f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1612f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1852f, (float)Screen.height - vector.y + 1001f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1228f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 117f, (float)Screen.height - vector.y + 1367f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1409f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_30()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_34()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_41()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_TimeX").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerCenter;
	}

	private void __BB_OBFUSCATOR_59()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_47()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_23()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 3;
		float num = 1183f;
		GUI.color = new Color(503f, 1784f, 1702f, 772f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1020f < 1050f)) ? 1854f : (vector.z * 756f));
		if (!(vector.z > 472f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("CameraFilterPack/TV_Old_Movie");
			style.alignment = TextAnchor.MiddleLeft;
			style.font = null;
			GUI.Label(new Rect(vector.x - 728f, (float)Screen.height - vector.y - 1672f - num, 632f, 1884f), "\n\t\t}", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 513f, (float)Screen.height - vector.y + 25f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1197f, 498f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 346f, (float)Screen.height - vector.y + 282f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1122f, 1656f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("CameraFilterPack/FX_Plasma");
		style2.alignment = TextAnchor.LowerRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1010f, (float)Screen.height - vector.y - 1090f - num, 1826f, 1818f), "Tab - Main Menu" + DLHMCKDJIHG + "LegsURL", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 776f, (float)Screen.height - vector.y - 1418f - num, 1808f, 1876f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1843f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 339f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1157f, (float)Screen.height - vector.y + 486f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1742f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1077f, (float)Screen.height - vector.y + 327f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1687f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_38()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 0;
		float num = 286f;
		GUI.color = new Color(1520f, 1048f, 1353f, 1355f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1180f < 1404f)) ? 873f : (vector.z * 53f));
		if (!(vector.z > 745f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			style.alignment = TextAnchor.MiddleLeft;
			style.font = null;
			GUI.Label(new Rect(vector.x - 158f, (float)Screen.height - vector.y - 1829f - num, 1165f, 1248f), "Connect", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1912f, (float)Screen.height - vector.y + 872f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1500f, 1357f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 231f, (float)Screen.height - vector.y + 1735f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 56f, 1076f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("_ProjInfo");
		style2.alignment = TextAnchor.MiddleRight;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 527f, (float)Screen.height - vector.y - 747f - num, 208f, 1392f), "_Value" + DLHMCKDJIHG + "-", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1821f, (float)Screen.height - vector.y - 667f - num, 303f, 479f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1179f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1857f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 712f, (float)Screen.height - vector.y + 963f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1691f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 403f, (float)Screen.height - vector.y + 1037f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1482f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_20()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_4()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 0;
		float num = 252f;
		GUI.color = new Color(1125f, 655f, 917f, 1999f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1660f < 872f)) ? 356f : (vector.z * 1240f));
		if (!(vector.z > 834f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("CameraFilterPack/Retro_Loading");
			style.alignment = TextAnchor.MiddleLeft;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1285f, (float)Screen.height - vector.y - 168f - num, 458f, 212f), "0.5", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 305f, (float)Screen.height - vector.y + 1846f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1981f, 612f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1735f, (float)Screen.height - vector.y + 464f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 750f, 1963f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("CameraFilterPack/Blend2Camera_LinearDodge");
		style2.alignment = TextAnchor.MiddleCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 982f, (float)Screen.height - vector.y - 1679f - num, 1994f, 329f), "name" + DLHMCKDJIHG + "Next", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1905f, (float)Screen.height - vector.y - 935f - num, 75f, 1326f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 611f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1504f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1161f, (float)Screen.height - vector.y + 758f - num, IHCFOJAFGEG.CNNOMBEAPIH, 86f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1358f, (float)Screen.height - vector.y + 1199f - num, IHCFOJAFGEG.HLPBCOGDPCF, 614f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_6()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_48()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 1;
		float num = 1841f;
		GUI.color = new Color(1050f, 1197f, 860f, 1615f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 1774f < 1654f)) ? 995f : (vector.z * 1571f));
		if (!(vector.z > 1526f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_Value");
			style.alignment = TextAnchor.LowerRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 338f, (float)Screen.height - vector.y - 789f - num, 1126f, 313f), "InfectedWin", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 673f, (float)Screen.height - vector.y + 279f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1977f, 1056f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1989f, (float)Screen.height - vector.y + 1738f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1573f, 1466f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("All players have been infected...");
		style2.alignment = TextAnchor.MiddleLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1768f, (float)Screen.height - vector.y - 1588f - num, 1986f, 219f), "CustomSkin" + DLHMCKDJIHG + "Fire", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 536f, (float)Screen.height - vector.y - 492f - num, 710f, 201f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 575f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 464f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1358f, (float)Screen.height - vector.y + 1283f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1245f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 629f, (float)Screen.height - vector.y + 1815f - num, IHCFOJAFGEG.HLPBCOGDPCF, 668f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_36()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 4;
		float num = 1631f;
		GUI.color = new Color(164f, 1644f, 968f, 1931f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 894f < 952f)) ? 1531f : (vector.z * 1840f));
		if (!(vector.z > 687f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("-Vertical");
			style.alignment = TextAnchor.MiddleCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 873f, (float)Screen.height - vector.y - 1016f - num, 33f, 873f), "3", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1755f, (float)Screen.height - vector.y + 792f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1682f, 1069f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 387f, (float)Screen.height - vector.y + 164f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1867f, 1869f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("_ScreenResolution");
		style2.alignment = TextAnchor.MiddleLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 124f, (float)Screen.height - vector.y - 182f - num, 460f, 125f), "_TintColor" + DLHMCKDJIHG + " registered.", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1870f, (float)Screen.height - vector.y - 1284f - num, 519f, 1551f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1175f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 948f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1651f, (float)Screen.height - vector.y + 547f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1687f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1497f, (float)Screen.height - vector.y + 787f - num, IHCFOJAFGEG.HLPBCOGDPCF, 324f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_25()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("colorA").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerLeft;
	}

	private void __BB_OBFUSCATOR_45()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_19()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_1()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_SoftZDistance").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.UpperRight;
	}

	private void __BB_OBFUSCATOR_57()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_37()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void OnGUI()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 2;
		float num = 0f;
		GUI.color = new Color(0.1f, 0.9f, 0.5f, 1f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 3f < 50f)) ? 50f : (vector.z * 3f));
		if (!(vector.z > 0f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("Label");
			style.alignment = TextAnchor.MiddleCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 100f, (float)Screen.height - vector.y - 5f - num, 200f, 30f), "<color=red><b>▼</b></color>", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 4f, (float)Screen.height - vector.y + 25f - num, IHCFOJAFGEG.CNNOMBEAPIH / 2f, 5f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 4f, (float)Screen.height - vector.y + 25f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 2f, 5f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Label");
		style2.alignment = TextAnchor.MiddleCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 101f, (float)Screen.height - vector.y - 4f - num, 200f, 30f), "<color=black>" + DLHMCKDJIHG + "</color>", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 100f, (float)Screen.height - vector.y - 5f - num, 200f, 30f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 60f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 30f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 2f, (float)Screen.height - vector.y + 25f - num, IHCFOJAFGEG.CNNOMBEAPIH, 5f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 2f, (float)Screen.height - vector.y + 25f - num, IHCFOJAFGEG.HLPBCOGDPCF, 5f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_52()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void OnEnable()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("Label").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.MiddleCenter;
	}

	private void __BB_OBFUSCATOR_0()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_64()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 7;
		float num = 128f;
		GUI.color = new Color(1730f, 360f, 1907f, 132f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 686f < 691f)) ? 718f : (vector.z * 660f));
		if (!(vector.z > 740f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_Refraction");
			style.alignment = TextAnchor.LowerCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 281f, (float)Screen.height - vector.y - 296f - num, 1785f, 970f), "APP", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 627f, (float)Screen.height - vector.y + 225f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1593f, 161f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1796f, (float)Screen.height - vector.y + 1726f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 941f, 1992f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("MP");
		style2.alignment = TextAnchor.LowerCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 977f, (float)Screen.height - vector.y - 789f - num, 333f, 1292f), "_DotSize" + DLHMCKDJIHG + "CameraFilterPack/TV_WideScreenHV", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 87f, (float)Screen.height - vector.y - 546f - num, 497f, 1107f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 422f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 723f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 312f, (float)Screen.height - vector.y + 1019f - num, IHCFOJAFGEG.CNNOMBEAPIH, 981f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1993f, (float)Screen.height - vector.y + 932f - num, IHCFOJAFGEG.HLPBCOGDPCF, 331f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_11()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 8;
		float num = 1006f;
		GUI.color = new Color(1842f, 189f, 1567f, 280f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 727f < 364f)) ? 1347f : (vector.z * 668f));
		if (!(vector.z > 130f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("<color=green>☑</color>");
			style.alignment = TextAnchor.UpperRight;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1789f, (float)Screen.height - vector.y - 268f - num, 291f, 340f), "Attack", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 991f, (float)Screen.height - vector.y + 1645f - num, IHCFOJAFGEG.CNNOMBEAPIH / 39f, 1817f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 138f, (float)Screen.height - vector.y + 1323f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 611f, 359f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("_MinVelocity");
		style2.alignment = TextAnchor.UpperCenter;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 1911f, (float)Screen.height - vector.y - 287f - num, 255f, 1986f), "Mouse Y" + DLHMCKDJIHG + "_PrevViewProj", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1493f, (float)Screen.height - vector.y - 982f - num, 1004f, 1738f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 42f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1367f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1321f, (float)Screen.height - vector.y + 1622f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1981f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1850f, (float)Screen.height - vector.y + 461f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1588f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_17()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("Attack").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerCenter;
	}

	private void __BB_OBFUSCATOR_27()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_62()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_14()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("CameraFilterPack/FX_Drunk2").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.LowerCenter;
	}

	private void __BB_OBFUSCATOR_44()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("_BorderColor").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.UpperLeft;
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 6;
		float num = 371f;
		GUI.color = new Color(1001f, 1055f, 642f, 13f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 128f < 1679f)) ? 18f : (vector.z * 546f));
		if (!(vector.z > 449f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("\\xAu4YW5QzfD2KQjV");
			style.alignment = TextAnchor.UpperCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1760f, (float)Screen.height - vector.y - 1745f - num, 1397f, 1320f), "MainMenu", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 496f, (float)Screen.height - vector.y + 1366f - num, IHCFOJAFGEG.CNNOMBEAPIH / 1076f, 71f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1831f, (float)Screen.height - vector.y + 192f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1015f, 620f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Collect all");
		style2.alignment = TextAnchor.UpperLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 892f, (float)Screen.height - vector.y - 1483f - num, 794f, 7f), "_Value" + DLHMCKDJIHG + "Kills", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 511f, (float)Screen.height - vector.y - 614f - num, 1626f, 1889f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 278f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1727f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 108f, (float)Screen.height - vector.y + 829f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1293f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 115f, (float)Screen.height - vector.y + 1705f - num, IHCFOJAFGEG.HLPBCOGDPCF, 1580f), DMEIDCPJFON, ScaleMode.ScaleAndCrop);
	}

	private void __BB_OBFUSCATOR_16()
	{
		DLHMCKDJIHG = base.gameObject.name;
		GJJLCBEIBPC = GetComponent<PlayerNetworkController>().GJJLCBEIBPC;
	}

	private void __BB_OBFUSCATOR_35()
	{
		GUI.skin = KIMBOADOOCP;
		GUI.depth = 2;
		float num = 1843f;
		GUI.color = new Color(895f, 1411f, 1032f, 1565f);
		if (!Camera.main)
		{
			return;
		}
		Vector3 vector = Camera.main.WorldToScreenPoint(ANDHPKKEEFB.position);
		num = ((!(vector.z * 544f < 1506f)) ? 1804f : (vector.z * 384f));
		if (!(vector.z > 1098f))
		{
			return;
		}
		if (PAGBFJLNMIF)
		{
			GUIStyle style = KIMBOADOOCP.GetStyle("_Val3");
			style.alignment = TextAnchor.UpperCenter;
			style.font = null;
			GUI.Label(new Rect(vector.x - 1400f, (float)Screen.height - vector.y - 665f - num, 583f, 1036f), "_TimeX", OLCONFFIKFO);
			GUI.color = Color.red;
			GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1236f, (float)Screen.height - vector.y + 1376f - num, IHCFOJAFGEG.CNNOMBEAPIH / 229f, 1708f), string.Empty);
			GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 74f, (float)Screen.height - vector.y + 1192f - num, (float)IHCFOJAFGEG.HLPBCOGDPCF / 1221f, 948f), DMEIDCPJFON, ScaleMode.StretchToFill);
			return;
		}
		GUI.color = NHMHKJGPDCA[GJJLCBEIBPC];
		GUIStyle style2 = KIMBOADOOCP.GetStyle("Target no longer exists: ");
		style2.alignment = TextAnchor.LowerLeft;
		GUI.contentColor = NHMHKJGPDCA[GJJLCBEIBPC];
		GUI.Label(new Rect(vector.x - 598f, (float)Screen.height - vector.y - 1322f - num, 363f, 808f), "_Value" + DLHMCKDJIHG + "SetOnlineStatus called while not connected to front end server.", OLCONFFIKFO);
		GUI.Label(new Rect(vector.x - 1477f, (float)Screen.height - vector.y - 1807f - num, 1059f, 1460f), DLHMCKDJIHG, OLCONFFIKFO);
		if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 1195f)
		{
			GUI.color = Color.green;
		}
		else if ((float)IHCFOJAFGEG.HLPBCOGDPCF > 804f)
		{
			GUI.color = Color.yellow;
		}
		else
		{
			GUI.color = Color.red;
		}
		GUI.Box(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1540f, (float)Screen.height - vector.y + 47f - num, IHCFOJAFGEG.CNNOMBEAPIH, 1142f), string.Empty);
		GUI.DrawTexture(new Rect(vector.x - IHCFOJAFGEG.CNNOMBEAPIH / 1322f, (float)Screen.height - vector.y + 1466f - num, IHCFOJAFGEG.HLPBCOGDPCF, 873f), DMEIDCPJFON, ScaleMode.StretchToFill);
	}

	private void __BB_OBFUSCATOR_32()
	{
		IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		if (!ANDHPKKEEFB)
		{
			ANDHPKKEEFB = base.transform;
		}
		OLCONFFIKFO.font = KIMBOADOOCP.font;
		OLCONFFIKFO.fontSize = KIMBOADOOCP.GetStyle("CameraFilterPack/Blend2Camera_Hue").fontSize;
		OLCONFFIKFO.normal.textColor = Color.white;
		OLCONFFIKFO.alignment = TextAnchor.UpperRight;
	}
}
