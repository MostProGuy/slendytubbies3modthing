using System;
using System.Collections;
using UnityEngine;

public class ShowSkin : MonoBehaviour
{
	public GUISkin MEIFHLFHOOP;

	public float DBNNOFLKGBL = 100f;

	public float MKPCLEAKOMC = 30f;

	public Texture2D LODOHJNDJAL;

	private bool DOMMIHOKECE;

	private int OJMHKKKIEMP;

	private void __BB_OBFUSCATOR_54()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(725f, 849f, Screen.width - -97, Screen.height - 3), skin.name, "CameraFilterPack/OldFilm_Cutting1");
		GUIStyle style = GUI.skin.GetStyle("_ScreenResolution");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1127f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 815f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 995f) > (float)Screen.width - DBNNOFLKGBL - 508f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_32()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(145f, 549f, Screen.width - 120, Screen.height - -64), skin.name, "Click on the ground to spawn the selected effect");
		GUIStyle style = GUI.skin.GetStyle("CameraFilterPack/Drawing_Manga2");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1001f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 342f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 515f) > (float)Screen.width - DBNNOFLKGBL - 401f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_39()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(649f, 495f, Screen.width - 28, Screen.height - 96), skin.name, "Kills");
		GUIStyle style = GUI.skin.GetStyle("\\Microsoft\\WordPad\\Wor96BA.tmp");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 274f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 953f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1730f) > (float)Screen.width - DBNNOFLKGBL - 1212f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_26()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(838f, 606f, Screen.width - -28, Screen.height - 85), skin.name, "_ScreenResolution");
		GUIStyle style = GUI.skin.GetStyle("Vertical");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 343f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 521f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1284f) > (float)Screen.width - DBNNOFLKGBL - 1436f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_67()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1461f, 1005f, Screen.width - -20, Screen.height - -29), skin.name, "_TintColor");
		GUIStyle style = GUI.skin.GetStyle("_SunPosition");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1214f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1231f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1123f) > (float)Screen.width - DBNNOFLKGBL - 933f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_14()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(330f, 965f, Screen.width - -6, Screen.height - -17), skin.name, "CameraFilterPack/Drawing_CellShading");
		GUIStyle style = GUI.skin.GetStyle("CameraFilterPack/Blend2Camera_Screen");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1462f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 631f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 364f) > (float)Screen.width - DBNNOFLKGBL - 1612f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_61()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(311f, 132f, Screen.width - 5, Screen.height - -16), skin.name, "Move Left2");
		GUIStyle style = GUI.skin.GetStyle("_Color_G");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1307f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1712f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1792f) > (float)Screen.width - DBNNOFLKGBL - 1232f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_15()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(922f, 700f, Screen.width - -20, Screen.height - -94), skin.name, "_Blue_R");
		GUIStyle style = GUI.skin.GetStyle("Spectators");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 532f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1145f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1580f) > (float)Screen.width - DBNNOFLKGBL - 1453f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_63()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(656f, 1513f, Screen.width - -47, Screen.height - -37), skin.name, "PlayerType'");
		GUIStyle style = GUI.skin.GetStyle("Hacker");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 812f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 801f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1101f) > (float)Screen.width - DBNNOFLKGBL - 1829f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_36()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1260f, 1142f, Screen.width - 116, Screen.height - 67), skin.name, "_Offsets");
		GUIStyle style = GUI.skin.GetStyle("Connect");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 181f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 631f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1456f) > (float)Screen.width - DBNNOFLKGBL - 1516f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1650f, 1911f, Screen.width - 0, Screen.height - 47), skin.name, "V");
		GUIStyle style = GUI.skin.GetStyle("<size=");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1532f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 171f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1461f) > (float)Screen.width - DBNNOFLKGBL - 1731f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_20()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1349f, 1029f, Screen.width - -40, Screen.height - -102), skin.name, "_ScreenResolution");
		GUIStyle style = GUI.skin.GetStyle("Connecting");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1953f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1860f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1531f) > (float)Screen.width - DBNNOFLKGBL - 573f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_13()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(41f, 124f, Screen.width - -87, Screen.height - -71), skin.name, "CameraFilterPack/FX_Drunk2");
		GUIStyle style = GUI.skin.GetStyle("CameraFilterPack/Colors_Adjust_FullColors");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1774f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 848f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1156f) > (float)Screen.width - DBNNOFLKGBL - 875f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_66()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1318f, 1322f, Screen.width - -5, Screen.height - -111), skin.name, "Hue/Knob");
		GUIStyle style = GUI.skin.GetStyle("_ScreenResolution");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 788f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 938f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 40f) > (float)Screen.width - DBNNOFLKGBL - 651f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_10()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(529f, 575f, Screen.width - 23, Screen.height - 32), skin.name, "_Source");
		GUIStyle style = GUI.skin.GetStyle("Vertical");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1943f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1889f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1081f) > (float)Screen.width - DBNNOFLKGBL - 1224f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_8()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(421f, 1722f, Screen.width - -100, Screen.height - -30), skin.name, "_Intensity");
		GUIStyle style = GUI.skin.GetStyle("DoDamage");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1587f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 207f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 494f) > (float)Screen.width - DBNNOFLKGBL - 707f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_77()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(953f, 17f, Screen.width - 39, Screen.height - -115), skin.name, "ns.exitgames.com");
		GUIStyle style = GUI.skin.GetStyle("PlayerType'");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1660f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1209f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 527f) > (float)Screen.width - DBNNOFLKGBL - 1636f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_30()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(455f, 1174f, Screen.width - -15, Screen.height - -42), skin.name, "CameraFilterPack/Distortion_Dream");
		GUIStyle style = GUI.skin.GetStyle("DM");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1479f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 723f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1054f) > (float)Screen.width - DBNNOFLKGBL - 402f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_21()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(371f, 1029f, Screen.width - 98, Screen.height - -28), skin.name, "Toast");
		GUIStyle style = GUI.skin.GetStyle("Room Name: ");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1477f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1299f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1534f) > (float)Screen.width - DBNNOFLKGBL - 795f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_74()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(992f, 1487f, Screen.width - 70, Screen.height - 10), skin.name, "Hat:");
		GUIStyle style = GUI.skin.GetStyle("</color></size>");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 900f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1876f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1478f) > (float)Screen.width - DBNNOFLKGBL - 837f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_70()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(215f, 1987f, Screen.width - 127, Screen.height - 103), skin.name, "Connect");
		GUIStyle style = GUI.skin.GetStyle("ShopBox/Scrollbar");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1495f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1729f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 988f) > (float)Screen.width - DBNNOFLKGBL - 375f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_23()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(456f, 1244f, Screen.width - -47, Screen.height - 83), skin.name, "_TimeX");
		GUIStyle style = GUI.skin.GetStyle("CameraFilterPack/TV_80");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1019f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1572f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1900f) > (float)Screen.width - DBNNOFLKGBL - 1056f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_41()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1024f, 439f, Screen.width - 23, Screen.height - 105), skin.name, "_ScreenResolution");
		GUIStyle style = GUI.skin.GetStyle("FireShadow");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1191f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 679f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1947f) > (float)Screen.width - DBNNOFLKGBL - 1160f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_53()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(745f, 1450f, Screen.width - -48, Screen.height - 14), skin.name, "Aim");
		GUIStyle style = GUI.skin.GetStyle("_Sat");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1895f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 260f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 176f) > (float)Screen.width - DBNNOFLKGBL - 1870f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_62()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(832f, 1126f, Screen.width - 85, Screen.height - -115), skin.name, "CreationTime: \"{0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}:{0:fff}\"\n");
		GUIStyle style = GUI.skin.GetStyle("8");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 118f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1336f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 152f) > (float)Screen.width - DBNNOFLKGBL - 817f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_45()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1084f, 362f, Screen.width - -117, Screen.height - 124), skin.name, "_ScreenResolution");
		GUIStyle style = GUI.skin.GetStyle("_Radius");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 75f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1324f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1871f) > (float)Screen.width - DBNNOFLKGBL - 1313f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_1()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1656f, 255f, Screen.width - 17, Screen.height - 26), skin.name, "PlayerType'");
		GUIStyle style = GUI.skin.GetStyle("colorA");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 548f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 873f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1683f) > (float)Screen.width - DBNNOFLKGBL - 728f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_73()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(491f, 6f, Screen.width - -38, Screen.height - -62), skin.name, "_ScreenResolution");
		GUIStyle style = GUI.skin.GetStyle("_ScreenResolution");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 815f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1501f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 975f) > (float)Screen.width - DBNNOFLKGBL - 1387f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_87()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1342f, 1912f, Screen.width - -23, Screen.height - -105), skin.name, "HatList");
		GUIStyle style = GUI.skin.GetStyle("Count");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 584f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 580f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1220f) > (float)Screen.width - DBNNOFLKGBL - 1425f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_89()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(561f, 629f, Screen.width - -84, Screen.height - -37), skin.name, "_TimeX");
		GUIStyle style = GUI.skin.GetStyle("\n\t\t}");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1293f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1872f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1076f) > (float)Screen.width - DBNNOFLKGBL - 68f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_18()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(350f, 337f, Screen.width - 30, Screen.height - -115), skin.name, "8");
		GUIStyle style = GUI.skin.GetStyle("RemoveFriends can't be called for empty or null list.");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 625f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1729f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 308f) > (float)Screen.width - DBNNOFLKGBL - 1829f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_3()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(729f, 392f, Screen.width - 112, Screen.height - -17), skin.name, "_FgOverlap");
		GUIStyle style = GUI.skin.GetStyle("Mouse X");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1042f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 716f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 532f) > (float)Screen.width - DBNNOFLKGBL - 910f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_5()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1346f, 1681f, Screen.width - 72, Screen.height - 27), skin.name, ":");
		GUIStyle style = GUI.skin.GetStyle("MP");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1026f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1165f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1717f) > (float)Screen.width - DBNNOFLKGBL - 1966f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_59()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1314f, 1183f, Screen.width - 122, Screen.height - 95), skin.name, "_FadeFX");
		GUIStyle style = GUI.skin.GetStyle("networkAddMessage");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 508f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1675f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1605f) > (float)Screen.width - DBNNOFLKGBL - 1887f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_84()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1401f, 418f, Screen.width - -3, Screen.height - 48), skin.name, "_RgbTex");
		GUIStyle style = GUI.skin.GetStyle("RefTime");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1334f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 786f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 144f) > (float)Screen.width - DBNNOFLKGBL - 1659f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_34()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(364f, 1074f, Screen.width - -89, Screen.height - 87), skin.name, "MP");
		GUIStyle style = GUI.skin.GetStyle("_Value2");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1720f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 289f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 1285f) > (float)Screen.width - DBNNOFLKGBL - 1135f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_80()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(781f, 339f, Screen.width - 55, Screen.height - 0), skin.name, "Diffuse");
		GUIStyle style = GUI.skin.GetStyle("1");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1045f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 543f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 312f) > (float)Screen.width - DBNNOFLKGBL - 1025f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_28()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(862f, 540f, Screen.width - -109, Screen.height - 44), skin.name, "Team1Score");
		GUIStyle style = GUI.skin.GetStyle("_Value2");
		int num = 1;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1951f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1464f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1946f) > (float)Screen.width - DBNNOFLKGBL - 239f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_0()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(775f, 1829f, Screen.width - -74, Screen.height - 116), skin.name, "COOP");
		GUIStyle style = GUI.skin.GetStyle("Name");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1562f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 969f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num += 0;
				if ((float)num * (DBNNOFLKGBL + 948f) > (float)Screen.width - DBNNOFLKGBL - 42f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_82()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(155f, 471f, Screen.width - 52, Screen.height - 96), skin.name, "_Amount");
		GUIStyle style = GUI.skin.GetStyle(",");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1150f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1919f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1403f) > (float)Screen.width - DBNNOFLKGBL - 776f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_76()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(289f, 1808f, Screen.width - -2, Screen.height - -124), skin.name, "_CutoutReferenceTexture");
		GUIStyle style = GUI.skin.GetStyle("_Value2");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1319f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1537f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1015f) > (float)Screen.width - DBNNOFLKGBL - 1466f - (float)style.padding.right)
				{
					num = 0;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_46()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1167f, 1802f, Screen.width - 71, Screen.height - 13), skin.name, "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp");
		GUIStyle style = GUI.skin.GetStyle("FlyCam");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 76f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1094f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1628f) > (float)Screen.width - DBNNOFLKGBL - 1742f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_31()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(832f, 958f, Screen.width - 50, Screen.height - 63), skin.name, "Diffuse");
		GUIStyle style = GUI.skin.GetStyle("_Specular");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 1379f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1355f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 223f) > (float)Screen.width - DBNNOFLKGBL - 1418f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_75()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1116f, 1434f, Screen.width - 39, Screen.height - -102), skin.name, "_TimeX");
		GUIStyle style = GUI.skin.GetStyle("Text");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 717f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1983f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1112f) > (float)Screen.width - DBNNOFLKGBL - 596f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void OnGUI()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(30f, 20f, Screen.width - 60, Screen.height - 40), skin.name, "window");
		GUIStyle style = GUI.skin.GetStyle("window");
		int num = 0;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 20f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 15f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 20f) > (float)Screen.width - DBNNOFLKGBL - 40f - (float)style.padding.right)
				{
					num = 0;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_58()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(748f, 372f, Screen.width - -124, Screen.height - 61), skin.name, "_Distance");
		GUIStyle style = GUI.skin.GetStyle("_Value4");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 350f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 923f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1147f) > (float)Screen.width - DBNNOFLKGBL - 1433f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_9()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(863f, 297f, Screen.width - 17, Screen.height - -36), skin.name, "_TimeX");
		GUIStyle style = GUI.skin.GetStyle("_TimeX");
		int num = 0;
		int num2 = 1;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 338f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 1834f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 1398f) > (float)Screen.width - DBNNOFLKGBL - 481f - (float)style.padding.right)
				{
					num = 1;
					num2++;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}

	private void __BB_OBFUSCATOR_29()
	{
		GUI.skin = MEIFHLFHOOP;
		GUISkin skin = GUI.skin;
		GUI.BeginGroup(new Rect(1006f, 1930f, Screen.width - 68, Screen.height - 98), skin.name, "0.00");
		GUIStyle style = GUI.skin.GetStyle("-batchmode");
		int num = 1;
		int num2 = 0;
		IEnumerator enumerator = skin.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GUIStyle gUIStyle = (GUIStyle)enumerator.Current;
				DOMMIHOKECE = GUI.Toggle(new Rect((float)num * (DBNNOFLKGBL + 94f) + (float)style.padding.left, (float)num2 * (MKPCLEAKOMC + 765f) + (float)style.padding.top, DBNNOFLKGBL, MKPCLEAKOMC), DOMMIHOKECE, new GUIContent(gUIStyle.name.ToUpper(), LODOHJNDJAL), gUIStyle);
				num++;
				if ((float)num * (DBNNOFLKGBL + 636f) > (float)Screen.width - DBNNOFLKGBL - 67f - (float)style.padding.right)
				{
					num = 1;
					num2 += 0;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
		GUI.EndGroup();
	}
}
