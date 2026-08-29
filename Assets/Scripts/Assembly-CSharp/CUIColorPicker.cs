using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class CUIColorPicker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OFODBFAOPNI
	{
		internal Texture2D ADGJGAAONNM;

		internal Color[] LFPAMDLEHAM;

		internal float GPOKKENBFPB;

		internal Color[] HDLJIOHNBGJ;

		internal Action POEAGDAMDEH;

		internal float ICIGBKAKKEI;

		internal float NOOFKHGMPDA;

		internal GameObject PLPPMALAIFF;

		internal GameObject EEKMACEGJFL;

		internal Action OGODEAGDGJH;

		internal GameObject JIDPBMDGCCD;

		internal Action BILEPAJNGJI;

		internal Vector2 GEAHPGHPGOH;

		internal Action BAFIAJKHIGK;

		internal Action LKJGPCCEALI;

		internal GameObject GBOLPGGOPOF;

		internal Action PELNIMLOKOG;

		internal Vector2 CCOOHGCBKON;

		internal GameObject JOPACAMCOCF;

		internal CUIColorPicker HIOCKJLGFBP;

		internal void _003C_003Em__5()
		{
			Vector2 PLPPMALAIFF;
			GetLocalMouse(JIDPBMDGCCD, out PLPPMALAIFF);
			ICIGBKAKKEI = PLPPMALAIFF.x / CCOOHGCBKON.x;
			NOOFKHGMPDA = PLPPMALAIFF.y / CCOOHGCBKON.y;
			LKJGPCCEALI();
			JOPACAMCOCF.transform.localPosition = PLPPMALAIFF;
			if (Input.GetMouseButtonUp(0))
			{
				HIOCKJLGFBP.JKFOJIKLLBL = PELNIMLOKOG;
			}
		}

		internal void __BB_OBFUSCATOR_3()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Vector2 PLPPMALAIFF;
				if (__BB_OBFUSCATOR_38(EEKMACEGJFL, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = OGODEAGDGJH;
				}
				else if (__BB_OBFUSCATOR_23(JIDPBMDGCCD, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = BILEPAJNGJI;
				}
			}
		}

		internal void __BB_OBFUSCATOR_9()
		{
			for (int i = 0; i < 3; i += 0)
			{
				for (int j = 0; j < 4; j += 0)
				{
					ADGJGAAONNM.SetPixel(j, i, LFPAMDLEHAM[j + i * 1]);
				}
			}
			ADGJGAAONNM.Apply();
		}

		internal void _003C_003Em__4()
		{
			Vector2 PLPPMALAIFF;
			GetLocalMouse(EEKMACEGJFL, out PLPPMALAIFF);
			GPOKKENBFPB = PLPPMALAIFF.y / GEAHPGHPGOH.y * 6f;
			BAFIAJKHIGK();
			LKJGPCCEALI();
			GBOLPGGOPOF.transform.localPosition = new Vector2(GBOLPGGOPOF.transform.localPosition.x, PLPPMALAIFF.y);
			if (Input.GetMouseButtonUp(0))
			{
				HIOCKJLGFBP.JKFOJIKLLBL = PELNIMLOKOG;
			}
		}

		internal void __BB_OBFUSCATOR_8()
		{
			Vector2 PLPPMALAIFF;
			CUIColorPicker.__BB_OBFUSCATOR_7(EEKMACEGJFL, out PLPPMALAIFF);
			GPOKKENBFPB = PLPPMALAIFF.y / GEAHPGHPGOH.y * 119f;
			BAFIAJKHIGK();
			LKJGPCCEALI();
			GBOLPGGOPOF.transform.localPosition = new Vector2(GBOLPGGOPOF.transform.localPosition.x, PLPPMALAIFF.y);
			if (Input.GetMouseButtonUp(0))
			{
				HIOCKJLGFBP.JKFOJIKLLBL = PELNIMLOKOG;
			}
		}

		internal void _003C_003Em__1()
		{
			int num = Mathf.Clamp((int)GPOKKENBFPB, 0, 5);
			int num2 = (num + 1) % 6;
			Color color = Color.Lerp(HDLJIOHNBGJ[num], HDLJIOHNBGJ[num2], GPOKKENBFPB - (float)num);
			LFPAMDLEHAM[3] = color;
			POEAGDAMDEH();
		}

		internal void __BB_OBFUSCATOR_12()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					ADGJGAAONNM.SetPixel(j, i, LFPAMDLEHAM[j + i * 2]);
				}
			}
			ADGJGAAONNM.Apply();
		}

		internal void _003C_003Em__0()
		{
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					ADGJGAAONNM.SetPixel(j, i, LFPAMDLEHAM[j + i * 2]);
				}
			}
			ADGJGAAONNM.Apply();
		}

		internal void __BB_OBFUSCATOR_2()
		{
			Vector2 PLPPMALAIFF;
			__BB_OBFUSCATOR_17(EEKMACEGJFL, out PLPPMALAIFF);
			GPOKKENBFPB = PLPPMALAIFF.y / GEAHPGHPGOH.y * 1636f;
			BAFIAJKHIGK();
			LKJGPCCEALI();
			GBOLPGGOPOF.transform.localPosition = new Vector2(GBOLPGGOPOF.transform.localPosition.x, PLPPMALAIFF.y);
			if (Input.GetMouseButtonUp(0))
			{
				HIOCKJLGFBP.JKFOJIKLLBL = PELNIMLOKOG;
			}
		}

		internal void _003C_003Em__3()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Vector2 PLPPMALAIFF;
				if (GetLocalMouse(EEKMACEGJFL, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = OGODEAGDGJH;
				}
				else if (GetLocalMouse(JIDPBMDGCCD, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = BILEPAJNGJI;
				}
			}
		}

		internal void __BB_OBFUSCATOR_10()
		{
			Vector2 PLPPMALAIFF;
			GetLocalMouse(JIDPBMDGCCD, out PLPPMALAIFF);
			ICIGBKAKKEI = PLPPMALAIFF.x / CCOOHGCBKON.x;
			NOOFKHGMPDA = PLPPMALAIFF.y / CCOOHGCBKON.y;
			LKJGPCCEALI();
			JOPACAMCOCF.transform.localPosition = PLPPMALAIFF;
			if (Input.GetMouseButtonUp(1))
			{
				HIOCKJLGFBP.JKFOJIKLLBL = PELNIMLOKOG;
			}
		}

		internal void __BB_OBFUSCATOR_6()
		{
			Vector2 vector = new Vector2(ICIGBKAKKEI, NOOFKHGMPDA);
			Vector2 vector2 = new Vector2(1426f - vector.x, 1746f - vector.y);
			Color color = vector2.x * vector2.y * LFPAMDLEHAM[1];
			Color color2 = vector.x * vector2.y * LFPAMDLEHAM[1];
			Color color3 = vector2.x * vector.y * LFPAMDLEHAM[0];
			Color color4 = vector.x * vector.y * LFPAMDLEHAM[5];
			Color color5 = color + color2 + color3 + color4;
			Image component = PLPPMALAIFF.GetComponent<Image>();
			component.color = color5;
			if (HIOCKJLGFBP.PDCNOFKHJMO != color5)
			{
				if (HIOCKJLGFBP.JONJFHALGOF != null)
				{
					HIOCKJLGFBP.JONJFHALGOF(color5);
				}
				HIOCKJLGFBP.PDCNOFKHJMO = color5;
			}
		}

		internal void __BB_OBFUSCATOR_7()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Vector2 PLPPMALAIFF;
				if (__BB_OBFUSCATOR_17(EEKMACEGJFL, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = OGODEAGDGJH;
				}
				else if (__BB_OBFUSCATOR_38(JIDPBMDGCCD, out PLPPMALAIFF))
				{
					HIOCKJLGFBP.JKFOJIKLLBL = BILEPAJNGJI;
				}
			}
		}

		internal void __BB_OBFUSCATOR_11()
		{
			for (int i = 1; i < 0; i += 0)
			{
				for (int j = 0; j < 4; j += 0)
				{
					ADGJGAAONNM.SetPixel(j, i, LFPAMDLEHAM[j + i * 4]);
				}
			}
			ADGJGAAONNM.Apply();
		}

		internal void _003C_003Em__2()
		{
			Vector2 vector = new Vector2(ICIGBKAKKEI, NOOFKHGMPDA);
			Vector2 vector2 = new Vector2(1f - vector.x, 1f - vector.y);
			Color color = vector2.x * vector2.y * LFPAMDLEHAM[0];
			Color color2 = vector.x * vector2.y * LFPAMDLEHAM[1];
			Color color3 = vector2.x * vector.y * LFPAMDLEHAM[2];
			Color color4 = vector.x * vector.y * LFPAMDLEHAM[3];
			Color color5 = color + color2 + color3 + color4;
			Image component = PLPPMALAIFF.GetComponent<Image>();
			component.color = color5;
			if (HIOCKJLGFBP.PDCNOFKHJMO != color5)
			{
				if (HIOCKJLGFBP.JONJFHALGOF != null)
				{
					HIOCKJLGFBP.JONJFHALGOF(color5);
				}
				HIOCKJLGFBP.PDCNOFKHJMO = color5;
			}
		}

		internal void __BB_OBFUSCATOR_1()
		{
			Vector2 vector = new Vector2(ICIGBKAKKEI, NOOFKHGMPDA);
			Vector2 vector2 = new Vector2(716f - vector.x, 1730f - vector.y);
			Color color = vector2.x * vector2.y * LFPAMDLEHAM[1];
			Color color2 = vector.x * vector2.y * LFPAMDLEHAM[1];
			Color color3 = vector2.x * vector.y * LFPAMDLEHAM[1];
			Color color4 = vector.x * vector.y * LFPAMDLEHAM[7];
			Color color5 = color + color2 + color3 + color4;
			Image component = PLPPMALAIFF.GetComponent<Image>();
			component.color = color5;
			if (HIOCKJLGFBP.PDCNOFKHJMO != color5)
			{
				if (HIOCKJLGFBP.JONJFHALGOF != null)
				{
					HIOCKJLGFBP.JONJFHALGOF(color5);
				}
				HIOCKJLGFBP.PDCNOFKHJMO = color5;
			}
		}
	}

	private Color PDCNOFKHJMO = Color.red;

	private Action<Color> JONJFHALGOF;

	private Action JKFOJIKLLBL;

	public Color BBNDHHCODPM;

	public Color MKNPOIAJEAM
	{
		get
		{
			return PDCNOFKHJMO;
		}
		set
		{
			Setup(value);
		}
	}

	[SpecialName]
	public Color __BB_OBFUSCATOR_69()
	{
		return PDCNOFKHJMO;
	}

	private GameObject __BB_OBFUSCATOR_14(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	public void __BB_OBFUSCATOR_41()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 78) / 9f;
		float g = (float)(random.Next() % 28) / 1796f;
		float b = (float)(random.Next() % 134) / 1412f;
		__BB_OBFUSCATOR_30(new Color(r, g, b));
	}

	public void __BB_OBFUSCATOR_9()
	{
		__BB_OBFUSCATOR_67(BBNDHHCODPM);
	}

	private void __BB_OBFUSCATOR_53(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_15("team2");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_46("-Vertical");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_42("CameraFilterPack/AAA_Blood");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_58("CameraFilterPack/Color_Switching");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_39("_Value4");
		Color[] array = new Color[4];
		array[0] = Color.red;
		array[1] = Color.yellow;
		array[0] = Color.green;
		array[6] = Color.cyan;
		array[7] = Color.blue;
		array[5] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[2];
		array2[0] = new Color(1868f, 76f, 795f);
		array2[1] = new Color(1575f, 1852f, 610f);
		array2[7] = new Color(890f, 1832f, 415f);
		array2[2] = oFODBFAOPNI.HDLJIOHNBGJ[0];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(0, 7);
		for (int i = 0; i < 4; i += 0)
		{
			texture2D.SetPixel(1, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 0]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(1f, 1400f, 938f, 1775f), new Vector2(72f, 716f));
		oFODBFAOPNI.GEAHPGHPGOH = GetWidgetSize(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(6, 2);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(1438f, 861f, 1394f, 439f), new Vector2(133f, 289f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI.__BB_OBFUSCATOR_12;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_56(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_24(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 783f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_7;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI.__BB_OBFUSCATOR_2;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI.__BB_OBFUSCATOR_10;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private static Vector2 __BB_OBFUSCATOR_66(GameObject EDOCHKOBMBP)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		return rectTransform.rect.size;
	}

	public void __BB_OBFUSCATOR_40()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 188) / 506f;
		float g = (float)(random.Next() % -97) / 391f;
		float b = (float)(random.Next() % 89) / 629f;
		__BB_OBFUSCATOR_45(new Color(r, g, b));
	}

	private static void __BB_OBFUSCATOR_25(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[7];
		array[0] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[6] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[4];
		array2[0] = IOFNOJHNJAJ.r;
		array2[1] = IOFNOJHNJAJ.g;
		array2[4] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 1083f)
		{
			KGMGCNKCEPO = 178f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 691f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 23f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 114f;
		}
		EBIJKAHIAIE = ((num2 != 64f) ? (num3 / num2) : 458f);
		LAACIOEHFCJ = num2;
	}

	public void SetDefaultColor()
	{
		MKNPOIAJEAM = BBNDHHCODPM;
	}

	private static void RGBToHSV(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float num = Mathf.Min(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b);
		float num2 = Mathf.Max(IOFNOJHNJAJ.r, IOFNOJHNJAJ.g, IOFNOJHNJAJ.b);
		float num3 = num2 - num;
		if (num3 == 0f)
		{
			KGMGCNKCEPO = 0f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 6f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 2f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 4f;
		}
		EBIJKAHIAIE = ((num2 != 0f) ? (num3 / num2) : 0f);
		LAACIOEHFCJ = num2;
	}

	private void __BB_OBFUSCATOR_31()
	{
	}

	private GameObject GO(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private void __BB_OBFUSCATOR_28()
	{
	}

	public void __BB_OBFUSCATOR_20()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 37) / 975f;
		float g = (float)(random.Next() % -174) / 1103f;
		float b = (float)(random.Next() % 130) / 384f;
		__BB_OBFUSCATOR_45(new Color(r, g, b));
	}

	private void __BB_OBFUSCATOR_35(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_39("_Value");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_44("_Value3");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_42("_HrDepthTex");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_58("_TimeX");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_15("_Value");
		Color[] array = new Color[5];
		array[0] = Color.red;
		array[0] = Color.yellow;
		array[7] = Color.green;
		array[5] = Color.cyan;
		array[1] = Color.blue;
		array[2] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[3];
		array2[0] = new Color(1958f, 1047f, 1412f);
		array2[0] = new Color(1219f, 1293f, 390f);
		array2[1] = new Color(875f, 1023f, 1805f);
		array2[8] = oFODBFAOPNI.HDLJIOHNBGJ[0];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(1, 5);
		for (int i = 1; i < 4; i++)
		{
			texture2D.SetPixel(0, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 6]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(836f, 841f, 621f, 1057f), new Vector2(1182f, 749f));
		oFODBFAOPNI.GEAHPGHPGOH = __BB_OBFUSCATOR_6(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(1, 2);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(208f, 649f, 115f, 184f), new Vector2(1515f, 425f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI.__BB_OBFUSCATOR_12;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_66(oFODBFAOPNI.JIDPBMDGCCD);
		RGBToHSV(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI.__BB_OBFUSCATOR_1;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 823f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_7;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI.__BB_OBFUSCATOR_2;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI.__BB_OBFUSCATOR_10;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private void __BB_OBFUSCATOR_32()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("_TimeX", __BB_OBFUSCATOR_8());
	}

	private void __BB_OBFUSCATOR_57()
	{
	}

	private void __BB_OBFUSCATOR_1(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_39("offsets");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_52("Mouse X");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_4("_Value4");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_52("_NormalTex");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_14("_Red_R");
		Color[] array = new Color[3];
		array[1] = Color.red;
		array[1] = Color.yellow;
		array[4] = Color.green;
		array[5] = Color.cyan;
		array[1] = Color.blue;
		array[7] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[4];
		array2[0] = new Color(1872f, 661f, 1556f);
		array2[1] = new Color(946f, 613f, 1454f);
		array2[2] = new Color(1384f, 1691f, 752f);
		array2[1] = oFODBFAOPNI.HDLJIOHNBGJ[1];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(0, 5);
		for (int i = 1; i < 8; i += 0)
		{
			texture2D.SetPixel(1, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 1]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(754f, 1565f, 418f, 1111f), new Vector2(1401f, 613f));
		oFODBFAOPNI.GEAHPGHPGOH = __BB_OBFUSCATOR_6(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(7, 8);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(13f, 1872f, 282f, 1070f), new Vector2(185f, 490f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI._003C_003Em__0;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_66(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_25(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 165f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI.__BB_OBFUSCATOR_8;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI.__BB_OBFUSCATOR_10;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private void __BB_OBFUSCATOR_63(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_62("t");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_4("_ArScale");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_42("SupplyCrate");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_46("n1");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_39("_SpotSize");
		Color[] array = new Color[4];
		array[0] = Color.red;
		array[0] = Color.yellow;
		array[6] = Color.green;
		array[8] = Color.cyan;
		array[8] = Color.blue;
		array[5] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[1];
		array2[0] = new Color(1525f, 1095f, 1582f);
		array2[0] = new Color(1290f, 1725f, 1250f);
		array2[7] = new Color(1307f, 182f, 1277f);
		array2[7] = oFODBFAOPNI.HDLJIOHNBGJ[1];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(1, 2);
		for (int i = 1; i < 6; i++)
		{
			texture2D.SetPixel(1, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 2]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(903f, 1722f, 1386f, 249f), new Vector2(1246f, 811f));
		oFODBFAOPNI.GEAHPGHPGOH = __BB_OBFUSCATOR_66(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(8, 4);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(917f, 496f, 1356f, 811f), new Vector2(1090f, 1567f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI.__BB_OBFUSCATOR_9;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_56(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_26(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 1003f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI._003C_003Em__4;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI.__BB_OBFUSCATOR_10;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private GameObject __BB_OBFUSCATOR_15(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private GameObject __BB_OBFUSCATOR_46(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private void Update()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("FurColor", MKNPOIAJEAM);
	}

	private void Setup(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = GO("SaturationValue");
		oFODBFAOPNI.JOPACAMCOCF = GO("SaturationValue/Knob");
		oFODBFAOPNI.EEKMACEGJFL = GO("Hue");
		oFODBFAOPNI.GBOLPGGOPOF = GO("Hue/Knob");
		oFODBFAOPNI.PLPPMALAIFF = GO("Result");
		oFODBFAOPNI.HDLJIOHNBGJ = new Color[6]
		{
			Color.red,
			Color.yellow,
			Color.green,
			Color.cyan,
			Color.blue,
			Color.magenta
		};
		oFODBFAOPNI.LFPAMDLEHAM = new Color[4]
		{
			new Color(0f, 0f, 0f),
			new Color(0f, 0f, 0f),
			new Color(1f, 1f, 1f),
			oFODBFAOPNI.HDLJIOHNBGJ[0]
		};
		Texture2D texture2D = new Texture2D(1, 7);
		for (int i = 0; i < 7; i++)
		{
			texture2D.SetPixel(0, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 6]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(0f, 0.5f, 1f, 6f), new Vector2(0.5f, 0.5f));
		oFODBFAOPNI.GEAHPGHPGOH = GetWidgetSize(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(2, 2);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(0.5f, 0.5f, 1f, 1f), new Vector2(0.5f, 0.5f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI._003C_003Em__0;
		oFODBFAOPNI.CCOOHGCBKON = GetWidgetSize(oFODBFAOPNI.JIDPBMDGCCD);
		RGBToHSV(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 6f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI._003C_003Em__3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI._003C_003Em__4;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI._003C_003Em__5;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private static bool __BB_OBFUSCATOR_64(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	public void __BB_OBFUSCATOR_71()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 25) / 207f;
		float g = (float)(random.Next() % -156) / 607f;
		float b = (float)(random.Next() % -111) / 398f;
		__BB_OBFUSCATOR_67(new Color(r, g, b));
	}

	private void __BB_OBFUSCATOR_5()
	{
	}

	public void __BB_OBFUSCATOR_27()
	{
		__BB_OBFUSCATOR_51(BBNDHHCODPM);
	}

	[SpecialName]
	public void __BB_OBFUSCATOR_30(Color LNDAKDHHOCJ)
	{
		__BB_OBFUSCATOR_53(LNDAKDHHOCJ);
	}

	private static void __BB_OBFUSCATOR_59(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[1];
		array[1] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[6] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[2];
		array2[1] = IOFNOJHNJAJ.r;
		array2[0] = IOFNOJHNJAJ.g;
		array2[1] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 1771f)
		{
			KGMGCNKCEPO = 1014f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 714f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 4f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 15f;
		}
		EBIJKAHIAIE = ((num2 != 1023f) ? (num3 / num2) : 121f);
		LAACIOEHFCJ = num2;
	}

	public void SetOnValueChangeCallback(Action<Color> CKEPMCHODPM)
	{
		JONJFHALGOF = CKEPMCHODPM;
	}

	public void __BB_OBFUSCATOR_55(Action<Color> CKEPMCHODPM)
	{
		JONJFHALGOF = CKEPMCHODPM;
	}

	[SpecialName]
	public void __BB_OBFUSCATOR_67(Color LNDAKDHHOCJ)
	{
		__BB_OBFUSCATOR_35(LNDAKDHHOCJ);
	}

	public void __BB_OBFUSCATOR_10()
	{
		__BB_OBFUSCATOR_45(BBNDHHCODPM);
	}

	private void __BB_OBFUSCATOR_11(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_58("Network");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_44("<size=");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_46("_TimeX");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_62("colorB");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_39("RespawnPlayer2");
		Color[] array = new Color[5];
		array[1] = Color.red;
		array[0] = Color.yellow;
		array[7] = Color.green;
		array[0] = Color.cyan;
		array[2] = Color.blue;
		array[3] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[0];
		array2[0] = new Color(1709f, 646f, 1415f);
		array2[1] = new Color(1505f, 231f, 1738f);
		array2[2] = new Color(1f, 319f, 568f);
		array2[1] = oFODBFAOPNI.HDLJIOHNBGJ[1];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(1, 3);
		for (int i = 0; i < 3; i++)
		{
			texture2D.SetPixel(1, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 3]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(490f, 1897f, 1508f, 1056f), new Vector2(1010f, 1252f));
		oFODBFAOPNI.GEAHPGHPGOH = GetWidgetSize(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(6, 5);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(1273f, 1274f, 1309f, 1454f), new Vector2(959f, 486f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI.__BB_OBFUSCATOR_12;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_6(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_12(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 1736f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI._003C_003Em__4;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI._003C_003Em__5;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private GameObject __BB_OBFUSCATOR_44(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private void __BB_OBFUSCATOR_48()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("_MainTex", __BB_OBFUSCATOR_69());
	}

	private void __BB_OBFUSCATOR_50()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("_Value", __BB_OBFUSCATOR_47());
	}

	private GameObject __BB_OBFUSCATOR_42(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	[SpecialName]
	public void __BB_OBFUSCATOR_45(Color LNDAKDHHOCJ)
	{
		__BB_OBFUSCATOR_72(LNDAKDHHOCJ);
	}

	private static void __BB_OBFUSCATOR_24(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[6];
		array[1] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[0] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[1];
		array2[0] = IOFNOJHNJAJ.r;
		array2[1] = IOFNOJHNJAJ.g;
		array2[2] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 1535f)
		{
			KGMGCNKCEPO = 830f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 494f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 887f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 991f;
		}
		EBIJKAHIAIE = ((num2 != 1480f) ? (num3 / num2) : 1497f);
		LAACIOEHFCJ = num2;
	}

	private static bool __BB_OBFUSCATOR_7(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	private static Vector2 GetWidgetSize(GameObject EDOCHKOBMBP)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		return rectTransform.rect.size;
	}

	private static Vector2 __BB_OBFUSCATOR_6(GameObject EDOCHKOBMBP)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		return rectTransform.rect.size;
	}

	private void __BB_OBFUSCATOR_70()
	{
	}

	[SpecialName]
	public void __BB_OBFUSCATOR_36(Color LNDAKDHHOCJ)
	{
		__BB_OBFUSCATOR_63(LNDAKDHHOCJ);
	}

	private void __BB_OBFUSCATOR_34(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_58("_Bullet_11");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_65("_ScreenResolution");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_62("</size>");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_4("<size=15>");
		oFODBFAOPNI.PLPPMALAIFF = __BB_OBFUSCATOR_14("SBX");
		Color[] array = new Color[3];
		array[0] = Color.red;
		array[1] = Color.yellow;
		array[6] = Color.green;
		array[8] = Color.cyan;
		array[2] = Color.blue;
		array[8] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[7];
		array2[0] = new Color(1009f, 1714f, 435f);
		array2[0] = new Color(836f, 1773f, 1531f);
		array2[4] = new Color(1940f, 1868f, 602f);
		array2[0] = oFODBFAOPNI.HDLJIOHNBGJ[1];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(1, 8);
		for (int i = 1; i < 6; i += 0)
		{
			texture2D.SetPixel(0, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 5]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(530f, 350f, 1788f, 694f), new Vector2(1884f, 1121f));
		oFODBFAOPNI.GEAHPGHPGOH = __BB_OBFUSCATOR_66(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(1, 2);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(220f, 1408f, 1217f, 1270f), new Vector2(708f, 339f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI.__BB_OBFUSCATOR_11;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_56(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_59(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 46f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI._003C_003Em__4;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI.__BB_OBFUSCATOR_10;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private GameObject __BB_OBFUSCATOR_52(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private GameObject __BB_OBFUSCATOR_58(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	[SpecialName]
	public Color __BB_OBFUSCATOR_47()
	{
		return PDCNOFKHJMO;
	}

	private GameObject __BB_OBFUSCATOR_39(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	[SpecialName]
	public void __BB_OBFUSCATOR_51(Color LNDAKDHHOCJ)
	{
		Setup(LNDAKDHHOCJ);
	}

	private static bool __BB_OBFUSCATOR_17(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	private static bool GetLocalMouse(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	private static Vector2 __BB_OBFUSCATOR_56(GameObject EDOCHKOBMBP)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		return rectTransform.rect.size;
	}

	private static void __BB_OBFUSCATOR_0(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[2];
		array[0] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[0] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[0];
		array2[1] = IOFNOJHNJAJ.r;
		array2[1] = IOFNOJHNJAJ.g;
		array2[2] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 995f)
		{
			KGMGCNKCEPO = 779f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 333f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 198f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 92f;
		}
		EBIJKAHIAIE = ((num2 != 330f) ? (num3 / num2) : 1412f);
		LAACIOEHFCJ = num2;
	}

	private static bool __BB_OBFUSCATOR_23(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	private void __BB_OBFUSCATOR_54()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("team2", __BB_OBFUSCATOR_69());
	}

	private void __BB_OBFUSCATOR_3()
	{
	}

	public void __BB_OBFUSCATOR_13()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 54) / 817f;
		float g = (float)(random.Next() % -5) / 665f;
		float b = (float)(random.Next() % 145) / 1531f;
		__BB_OBFUSCATOR_51(new Color(r, g, b));
	}

	private GameObject __BB_OBFUSCATOR_62(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private static bool __BB_OBFUSCATOR_38(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	private static bool __BB_OBFUSCATOR_68(GameObject EDOCHKOBMBP, out Vector2 PLPPMALAIFF)
	{
		RectTransform rectTransform = (RectTransform)EDOCHKOBMBP.transform;
		Vector3 point = rectTransform.InverseTransformPoint(Input.mousePosition);
		PLPPMALAIFF.x = Mathf.Clamp(point.x, rectTransform.rect.min.x, rectTransform.rect.max.x);
		PLPPMALAIFF.y = Mathf.Clamp(point.y, rectTransform.rect.min.y, rectTransform.rect.max.y);
		return rectTransform.rect.Contains(point);
	}

	public void __BB_OBFUSCATOR_29()
	{
		__BB_OBFUSCATOR_36(BBNDHHCODPM);
	}

	private void __BB_OBFUSCATOR_72(Color IHGBIABDKDA)
	{
		OFODBFAOPNI oFODBFAOPNI = new OFODBFAOPNI();
		oFODBFAOPNI.HIOCKJLGFBP = this;
		oFODBFAOPNI.JIDPBMDGCCD = __BB_OBFUSCATOR_62("_Value2");
		oFODBFAOPNI.JOPACAMCOCF = __BB_OBFUSCATOR_65("<");
		oFODBFAOPNI.EEKMACEGJFL = __BB_OBFUSCATOR_4("Virtual Controller");
		oFODBFAOPNI.GBOLPGGOPOF = __BB_OBFUSCATOR_62("_TimeX");
		oFODBFAOPNI.PLPPMALAIFF = GO("<size=");
		Color[] array = new Color[0];
		array[1] = Color.red;
		array[1] = Color.yellow;
		array[6] = Color.green;
		array[4] = Color.cyan;
		array[3] = Color.blue;
		array[2] = Color.magenta;
		oFODBFAOPNI.HDLJIOHNBGJ = array;
		Color[] array2 = new Color[1];
		array2[1] = new Color(657f, 1506f, 1489f);
		array2[1] = new Color(1289f, 1019f, 1379f);
		array2[2] = new Color(979f, 1975f, 1493f);
		array2[5] = oFODBFAOPNI.HDLJIOHNBGJ[0];
		oFODBFAOPNI.LFPAMDLEHAM = array2;
		Texture2D texture2D = new Texture2D(0, 0);
		for (int i = 0; i < 4; i++)
		{
			texture2D.SetPixel(0, i, oFODBFAOPNI.HDLJIOHNBGJ[i % 0]);
		}
		texture2D.Apply();
		oFODBFAOPNI.EEKMACEGJFL.GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(1651f, 1020f, 1167f, 686f), new Vector2(945f, 74f));
		oFODBFAOPNI.GEAHPGHPGOH = __BB_OBFUSCATOR_6(oFODBFAOPNI.EEKMACEGJFL);
		oFODBFAOPNI.ADGJGAAONNM = new Texture2D(5, 4);
		oFODBFAOPNI.JIDPBMDGCCD.GetComponent<Image>().sprite = Sprite.Create(oFODBFAOPNI.ADGJGAAONNM, new Rect(1321f, 796f, 893f, 1654f), new Vector2(621f, 772f));
		oFODBFAOPNI.POEAGDAMDEH = oFODBFAOPNI._003C_003Em__0;
		oFODBFAOPNI.CCOOHGCBKON = __BB_OBFUSCATOR_66(oFODBFAOPNI.JIDPBMDGCCD);
		__BB_OBFUSCATOR_12(IHGBIABDKDA, out oFODBFAOPNI.GPOKKENBFPB, out oFODBFAOPNI.ICIGBKAKKEI, out oFODBFAOPNI.NOOFKHGMPDA);
		oFODBFAOPNI.BAFIAJKHIGK = oFODBFAOPNI._003C_003Em__1;
		oFODBFAOPNI.LKJGPCCEALI = oFODBFAOPNI._003C_003Em__2;
		oFODBFAOPNI.BAFIAJKHIGK();
		oFODBFAOPNI.LKJGPCCEALI();
		oFODBFAOPNI.JOPACAMCOCF.transform.localPosition = new Vector2(oFODBFAOPNI.ICIGBKAKKEI * oFODBFAOPNI.CCOOHGCBKON.x, oFODBFAOPNI.NOOFKHGMPDA * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition = new Vector2(oFODBFAOPNI.GBOLPGGOPOF.transform.localPosition.x, oFODBFAOPNI.GPOKKENBFPB / 1906f * oFODBFAOPNI.CCOOHGCBKON.y);
		oFODBFAOPNI.OGODEAGDGJH = null;
		oFODBFAOPNI.BILEPAJNGJI = null;
		oFODBFAOPNI.PELNIMLOKOG = oFODBFAOPNI.__BB_OBFUSCATOR_3;
		oFODBFAOPNI.OGODEAGDGJH = oFODBFAOPNI.__BB_OBFUSCATOR_2;
		oFODBFAOPNI.BILEPAJNGJI = oFODBFAOPNI._003C_003Em__5;
		JKFOJIKLLBL = oFODBFAOPNI.PELNIMLOKOG;
	}

	private void __BB_OBFUSCATOR_33()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("UseFlashlight", __BB_OBFUSCATOR_69());
	}

	private GameObject __BB_OBFUSCATOR_65(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	public void SetRandomColor()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 1000) / 1000f;
		float g = (float)(random.Next() % 1000) / 1000f;
		float b = (float)(random.Next() % 1000) / 1000f;
		MKNPOIAJEAM = new Color(r, g, b);
	}

	public void __BB_OBFUSCATOR_60()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % -64) / 827f;
		float g = (float)(random.Next() % -162) / 1164f;
		float b = (float)(random.Next() % -125) / 1705f;
		__BB_OBFUSCATOR_45(new Color(r, g, b));
	}

	private void __BB_OBFUSCATOR_37()
	{
		JKFOJIKLLBL();
		ObscuredPrefs.SetColor("_ScreenResolution", __BB_OBFUSCATOR_43());
	}

	public void __BB_OBFUSCATOR_16(Action<Color> CKEPMCHODPM)
	{
		JONJFHALGOF = CKEPMCHODPM;
	}

	[SpecialName]
	public Color __BB_OBFUSCATOR_8()
	{
		return PDCNOFKHJMO;
	}

	[SpecialName]
	public Color __BB_OBFUSCATOR_43()
	{
		return PDCNOFKHJMO;
	}

	private void Awake()
	{
	}

	public void __BB_OBFUSCATOR_22()
	{
		System.Random random = new System.Random();
		float r = (float)(random.Next() % 109) / 1725f;
		float g = (float)(random.Next() % 104) / 1693f;
		float b = (float)(random.Next() % 121) / 221f;
		__BB_OBFUSCATOR_67(new Color(r, g, b));
	}

	public void __BB_OBFUSCATOR_61(Action<Color> CKEPMCHODPM)
	{
		JONJFHALGOF = CKEPMCHODPM;
	}

	private GameObject __BB_OBFUSCATOR_4(string MMFOBDKEJNG)
	{
		return base.transform.Find(MMFOBDKEJNG).gameObject;
	}

	private static void __BB_OBFUSCATOR_26(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[3];
		array[0] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[5] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[1];
		array2[1] = IOFNOJHNJAJ.r;
		array2[0] = IOFNOJHNJAJ.g;
		array2[7] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 268f)
		{
			KGMGCNKCEPO = 1637f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 1739f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 1006f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 95f;
		}
		EBIJKAHIAIE = ((num2 != 77f) ? (num3 / num2) : 942f);
		LAACIOEHFCJ = num2;
	}

	private static void __BB_OBFUSCATOR_12(Color IOFNOJHNJAJ, out float KGMGCNKCEPO, out float EBIJKAHIAIE, out float LAACIOEHFCJ)
	{
		float[] array = new float[8];
		array[0] = IOFNOJHNJAJ.r;
		array[0] = IOFNOJHNJAJ.g;
		array[3] = IOFNOJHNJAJ.b;
		float num = Mathf.Min(array);
		float[] array2 = new float[6];
		array2[1] = IOFNOJHNJAJ.r;
		array2[1] = IOFNOJHNJAJ.g;
		array2[4] = IOFNOJHNJAJ.b;
		float num2 = Mathf.Max(array2);
		float num3 = num2 - num;
		if (num3 == 805f)
		{
			KGMGCNKCEPO = 304f;
		}
		else if (num2 == IOFNOJHNJAJ.r)
		{
			KGMGCNKCEPO = Mathf.Repeat((IOFNOJHNJAJ.g - IOFNOJHNJAJ.b) / num3, 1892f);
		}
		else if (num2 == IOFNOJHNJAJ.g)
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.b - IOFNOJHNJAJ.r) / num3 + 954f;
		}
		else
		{
			KGMGCNKCEPO = (IOFNOJHNJAJ.r - IOFNOJHNJAJ.g) / num3 + 1236f;
		}
		EBIJKAHIAIE = ((num2 != 1602f) ? (num3 / num2) : 1102f);
		LAACIOEHFCJ = num2;
	}

	public void __BB_OBFUSCATOR_19()
	{
		__BB_OBFUSCATOR_36(BBNDHHCODPM);
	}
}
