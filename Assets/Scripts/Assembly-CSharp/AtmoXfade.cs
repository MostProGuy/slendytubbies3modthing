using System.Collections;
using UnityEngine;

public class AtmoXfade : MonoBehaviour
{
	public enum PNFBPAOHIKM
	{
		FadeDark = 0,
		FadeBright = 1
	}

	public Material KJHKKNKPBOK;

	public Color EIALDFHILCN = Color.grey;

	public Color PCHMJKPCJOF = Color.black;

	public Light JOFJPMCPJCI;

	public Color IJFAFHNPNCN = Color.grey;

	public Color DCLBNMPLBPL = Color.black;

	public float EHEGHCDPKHF = 0.2f;

	public float JKKDHMGNPLL = 0.85f;

	private float AAAPPNAEPPE;

	public bool GCJHJPOPEAP = true;

	public Color HKLMDJLHFIC = Color.grey;

	public Color LIABPHPPJAI = Color.black;

	public float PLKLOOFBDNF = 0.004f;

	public float AIIHLNGIMKE = 0.02f;

	public PNFBPAOHIKM HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;

	public float HKOMCCMODOE = 80f;

	private IEnumerator __BB_OBFUSCATOR_67()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_68()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_44(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "CameraFilterPack/Colors_HSV")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_54());
		}
	}

	private void Start()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("_Tint", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private IEnumerator __BB_OBFUSCATOR_5()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_48(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == ",")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_7());
		}
	}

	private void __BB_OBFUSCATOR_52(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_MainTex2")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_61());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("_ScreenResolution", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_15(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_ScreenResolution")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_76());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_74()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_11(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Start Game")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_41());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_34()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_66()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_4(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "</size>")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_34());
		}
	}

	private void __BB_OBFUSCATOR_82(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Toast")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_66());
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("Back", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_93(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value2")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_13());
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("6", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("_BumpMap", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_39(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "monster")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_54());
		}
	}

	private void __BB_OBFUSCATOR_69(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_68());
		}
	}

	private void __BB_OBFUSCATOR_21(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "PlayerName")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_8());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_76()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_26()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_58()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("_Offsets", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private IEnumerator __BB_OBFUSCATOR_50()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_83()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_73(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "View")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_42());
		}
	}

	private void __BB_OBFUSCATOR_77(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "CameraFilterPack/TV_Videoflip")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_50());
		}
	}

	private void __BB_OBFUSCATOR_22(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "CameraFilterPack/Distortion_Dissipation")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_68());
		}
	}

	private void __BB_OBFUSCATOR_33(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_PositionX")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_47());
		}
	}

	private void __BB_OBFUSCATOR_43(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "selectWeapon")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_20());
		}
	}

	private void __BB_OBFUSCATOR_79(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_AdaptTex")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_7());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_8()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("team2", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private IEnumerator __BB_OBFUSCATOR_47()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("CameraFilterPack/Drawing_CellShading2", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_60(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "colorD")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_25());
		}
	}

	private void __BB_OBFUSCATOR_28(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "TeamName")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_67());
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("GiveCurrency", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private IEnumerator __BB_OBFUSCATOR_1()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_18(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "V")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_34());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_7()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_10(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_25());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_63()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_89(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "GameMode")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_35());
		}
	}

	private void __BB_OBFUSCATOR_23(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Hat:")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_55()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator FadeBright()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void OnTriggerExit(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Player")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(FadeBright());
		}
	}

	private void __BB_OBFUSCATOR_53(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "\\Google\\g65KYJszcHtFhpDC")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_49());
		}
	}

	private void __BB_OBFUSCATOR_90(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value2")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_34());
		}
	}

	private void __BB_OBFUSCATOR_38(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "TeamName")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_58());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_12()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_41()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_27(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Hide Ground")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_83());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_87(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "CameraFilterPack/TV_Old")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_66());
		}
	}

	private void __BB_OBFUSCATOR_0(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "CameraFilterPack/Drawing_Manga_FlashWhite")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_47());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_70()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_25()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("FurColor", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_2(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == ": ")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(FadeDark());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_17()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_29(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value2")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_63());
		}
	}

	private void __BB_OBFUSCATOR_56(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == " has been disabled as it's not supported on the current platform.")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(FadeBright());
		}
	}

	private void OnTriggerEnter(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Player")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(FadeDark());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_20()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator FadeDark()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_54()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("CameraFilterPack/Blur_DitherOffset", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = true;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_31(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "\tTexture: \"Texture::")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_61());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_42()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_62(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_Value3")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_66());
		}
	}

	private void __BB_OBFUSCATOR_45(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "ZWName'")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_1());
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("Attack", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = false;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private IEnumerator __BB_OBFUSCATOR_61()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeDark && AAAPPNAEPPE > EHEGHCDPKHF)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), PCHMJKPCJOF, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, DCLBNMPLBPL, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, EHEGHCDPKHF, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, LIABPHPPJAI, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, AIIHLNGIMKE, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_32(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_DotSize")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_58());
		}
	}

	private void __BB_OBFUSCATOR_46(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "Lobby")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_70());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_13()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_30()
	{
		float num = 1E-05f;
		while (HKPPIAJDKJK == PNFBPAOHIKM.FadeBright && AAAPPNAEPPE < JKKDHMGNPLL)
		{
			KJHKKNKPBOK.SetColor("_Tint", Color.Lerp(KJHKKNKPBOK.GetColor("_Tint"), EIALDFHILCN, num));
			JOFJPMCPJCI.color = Color.Lerp(JOFJPMCPJCI.color, IJFAFHNPNCN, num);
			AAAPPNAEPPE = JOFJPMCPJCI.intensity;
			JOFJPMCPJCI.intensity = Mathf.SmoothStep(AAAPPNAEPPE, JKKDHMGNPLL, num);
			if (GCJHJPOPEAP)
			{
				RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, HKLMDJLHFIC, num);
				RenderSettings.fogDensity = Mathf.SmoothStep(RenderSettings.fogDensity, PLKLOOFBDNF, num);
			}
			yield return null;
			num += Time.deltaTime / HKOMCCMODOE;
		}
	}

	private void __BB_OBFUSCATOR_85()
	{
		if ((bool)KJHKKNKPBOK)
		{
			KJHKKNKPBOK.SetColor("SyncTeamName", EIALDFHILCN);
		}
		if ((bool)JOFJPMCPJCI)
		{
			JOFJPMCPJCI.color = IJFAFHNPNCN;
		}
		if (GCJHJPOPEAP)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = HKLMDJLHFIC;
		}
		else
		{
			RenderSettings.fog = false;
		}
		AAAPPNAEPPE = JKKDHMGNPLL;
	}

	private void __BB_OBFUSCATOR_40(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "_ScreenResolution")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeDark;
			StartCoroutine(__BB_OBFUSCATOR_26());
		}
	}

	private void __BB_OBFUSCATOR_9(Collider KONMOOBKIJE)
	{
		if (KONMOOBKIJE.sharedMaterial != null && KONMOOBKIJE.sharedMaterial.name == "v0.0.1")
		{
			HKPPIAJDKJK = PNFBPAOHIKM.FadeBright;
			StartCoroutine(__BB_OBFUSCATOR_12());
		}
	}
}
