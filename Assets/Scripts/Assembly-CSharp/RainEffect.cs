using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Image Effects/Rain/RainEffect")]
[ExecuteInEditMode]
public class RainEffect : MonoBehaviour
{
	public enum FGBBKFLIOCG
	{
		Single = 0,
		Double = 1,
		Triple = 2,
		Quadruple = 3
	}

	[Serializable]
	private class NormData
	{
		public float timeLeft;

		public float intensity;

		public float acceleration = 0.1f;

		public float valx;

		public float valy;

		public float t;

		public float c;

		public float fadeSpeed;
	}

	private const int PBKBAADLNIE = 4;

	public Shader BNLDNPPEODB;

	public FGBBKFLIOCG NOLAGAOJELF = FGBBKFLIOCG.Triple;

	public Texture2D CPNKHGPBCBH;

	public Color GKHMAPDGANJ = Color.gray;

	public bool GLCAMCAMIMF;

	[Range(0.05f, 1f)]
	public float KHJJDIADALD = 0.7f;

	[Range(0.05f, 1f)]
	public float HHOHFJLDHJE = 0.6f;

	[Range(0f, 1f)]
	public float LMNDNMILCJB = 0.2f;

	[Range(0.1f, 0.9f)]
	public float GDLONHCPAKF = 0.75f;

	[Range(0f, 10f)]
	public float HFDNMMCHMBO;

	[Range(0f, 10f)]
	public float CHINDKADBDO = 0.06f;

	[Range(0f, 10f)]
	public float AHFNEKDNNEO = 0.2f;

	[Range(0.05f, 60f)]
	public float LOIMGLOPEPM = 0.6f;

	[Range(0.05f, 60f)]
	public float CMGLILNFIHB = 1.4f;

	[Range(0.0001f, 3f)]
	public float AMOAFABIKNH = 0.09f;

	[Range(0.0001f, 3f)]
	public float PJEGDGJOPAI = 0.09f;

	private Material FKEJPAKBCNA;

	private Texture2D DFJIPKENOGK;

	private NormData[] GHMOHGFHJOA = new NormData[4];

	private int MJJBMGBOKGI
	{
		get
		{
			return (int)NOLAGAOJELF;
		}
	}

	private void __BB_OBFUSCATOR_45(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_99(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_TimeX", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Value", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat(">", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("Network", LMNDNMILCJB);
		for (int i = 0; i < 2; i++)
		{
			FKEJPAKBCNA.SetFloat("_TimeX" + __BB_OBFUSCATOR_101(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_ScreenResolution" + __BB_OBFUSCATOR_93(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (873f - GDLONHCPAKF)) : (333f * (647f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1887f - GDLONHCPAKF)) : (779f * (1665f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_125());
	}

	private void __BB_OBFUSCATOR_17(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 690f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1116f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(971f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 210f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 891f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 440f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 1519f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_33(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 128f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 404f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(151f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1076f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1485f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 117f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 84f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_138()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_4(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 150f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 223f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1702f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 669f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 655f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1842f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 927f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_58(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_76(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_58(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_111()
	{
		return (int)NOLAGAOJELF;
	}

	private string __BB_OBFUSCATOR_107(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_34()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_133(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_76(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_15(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_119()
	{
		return (int)NOLAGAOJELF;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_125()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_62()
	{
		__BB_OBFUSCATOR_24();
		for (int i = 1; i < 6; i += 0)
		{
			__BB_OBFUSCATOR_61(i);
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Value3", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("\"Deformer::Skin ", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("</size>", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(0, 1, (TextureFormat)6, true);
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Blend2Camera_Lighten", DFJIPKENOGK);
		for (int i = 0; i < 5; i++)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(671f, CMGLILNFIHB);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_20()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_86(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("TeamASpawn", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("Wood", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("_ZCurve", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("RoundDuration", LMNDNMILCJB);
		for (int i = 0; i < 3; i++)
		{
			FKEJPAKBCNA.SetFloat("_Distortion" + __BB_OBFUSCATOR_11(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector(", position = " + __BB_OBFUSCATOR_22(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1498f - GDLONHCPAKF)) : (93f * (1778f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (310f - GDLONHCPAKF)) : (1654f * (172f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_55());
	}

	private void __BB_OBFUSCATOR_29(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_Value2", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Value", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("/", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("HatList", LMNDNMILCJB);
		for (int i = 0; i < 2; i += 0)
		{
			FKEJPAKBCNA.SetFloat("_Value3" + __BB_OBFUSCATOR_5(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: " + __BB_OBFUSCATOR_22(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (13f - GDLONHCPAKF)) : (263f * (1918f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1467f - GDLONHCPAKF)) : (1653f * (243f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_49());
	}

	private void __BB_OBFUSCATOR_51()
	{
		__BB_OBFUSCATOR_1();
		for (int i = 0; i < 7; i += 0)
		{
			__BB_OBFUSCATOR_113(i);
		}
	}

	private void __BB_OBFUSCATOR_103(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("{0:n6},{1:n6},{2:n6}", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Blend2Camera_LinearDodge", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("_Value5", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("Mouse Y", LMNDNMILCJB);
		for (int i = 1; i < 2; i += 0)
		{
			FKEJPAKBCNA.SetFloat("</size>" + s(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_Value4" + __BB_OBFUSCATOR_52(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1243f - GDLONHCPAKF)) : (896f * (1665f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1265f - GDLONHCPAKF)) : (750f * (390f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_141());
	}

	private void __BB_OBFUSCATOR_97()
	{
		__BB_OBFUSCATOR_67();
		for (int i = 0; i < 1; i += 0)
		{
			__BB_OBFUSCATOR_48(i);
		}
	}

	private void __BB_OBFUSCATOR_46(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_ScreenResolution", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Value", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("Username", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("Mouse X", LMNDNMILCJB);
		for (int i = 0; i < 3; i++)
		{
			FKEJPAKBCNA.SetFloat("HostQuit" + __BB_OBFUSCATOR_60(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("ShopBox/Heal/Text" + __BB_OBFUSCATOR_115(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (34f - GDLONHCPAKF)) : (1613f * (832f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1136f - GDLONHCPAKF)) : (199f * (1849f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_129());
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("\"OO\", \"SubDeformer::Cluster ", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_WaterLevel", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("Language", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(0, 0, TextureFormat.ARGB4444, true);
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture(", t = ", DFJIPKENOGK);
		for (int i = 1; i < 1; i += 0)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(1211f, CMGLILNFIHB);
		}
	}

	private void Awake()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("RainEffectShader", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("NormRain", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_NormalTex", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(1, 1, TextureFormat.ARGB32, false);
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_OverlayTex", DFJIPKENOGK);
		for (int i = 0; i < 4; i++)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(0f, CMGLILNFIHB);
		}
	}

	private string __BB_OBFUSCATOR_130(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private string __BB_OBFUSCATOR_83(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_58(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_131()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_15(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_18(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_76(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_140(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 937f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1288f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1194f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 508f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1515f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1730f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 1680f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		__BB_OBFUSCATOR_42();
		for (int i = 1; i < 6; i += 0)
		{
			__BB_OBFUSCATOR_7(i);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_76(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_31(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_118(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_48(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 1536f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1284f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(151f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1801f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1389f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 20f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 728f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_49()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_98()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_77(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_15(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_74(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_10(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 747f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 508f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(222f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1784f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1676f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1069f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 1872f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_43()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_89(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_31(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_81()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_45(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_78(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_45(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_137()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_8(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_58(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_74(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			swap(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_58(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_15(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_136()
	{
		__BB_OBFUSCATOR_68();
		for (int i = 1; i < 2; i++)
		{
			__BB_OBFUSCATOR_139(i);
		}
	}

	private void __BB_OBFUSCATOR_124(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_124(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_45(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_31(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_102(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_132()
	{
		return (int)NOLAGAOJELF;
	}

	private string __BB_OBFUSCATOR_109(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_128()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_124(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_87(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_120(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_88(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 385f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1813f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1160f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1491f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1926f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 285f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 590f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_74(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_78(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_77(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_8(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_74(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("team1", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("Disconnected from Photon", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("Loading complete", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(0, 1, TextureFormat.Alpha8, true);
		DFJIPKENOGK.SetPixel(1, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Can't authenticate on front end server. Authentication Values are not set", DFJIPKENOGK);
		for (int i = 1; i < 4; i += 0)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(138f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_106(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Mouse X", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("SELF", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("CameraFilterPack/EXTRA_Rotation", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_CenterX", LMNDNMILCJB);
		for (int i = 0; i < 0; i++)
		{
			FKEJPAKBCNA.SetFloat("_Blue_G" + __BB_OBFUSCATOR_22(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("WeaponScript.js should be attached to same gameObject" + __BB_OBFUSCATOR_93(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (355f - GDLONHCPAKF)) : (1424f * (500f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1617f - GDLONHCPAKF)) : (1647f * (286f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_119());
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_124(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_120(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_118(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_AOTex", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("COOP", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_MainTex", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(1, 1, (TextureFormat)8, false);
		DFJIPKENOGK.SetPixel(1, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Idle", DFJIPKENOGK);
		for (int i = 1; i < 8; i++)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(967f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_79(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 1833f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1380f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1918f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1087f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 427f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 462f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 934f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_19(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 933f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 103f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(724f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 112f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 653f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1156f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 747f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_31(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_78(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_76(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_76(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_6()
	{
		__BB_OBFUSCATOR_108();
		for (int i = 1; i < 5; i++)
		{
			__BB_OBFUSCATOR_79(i);
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		__BB_OBFUSCATOR_57();
		for (int i = 0; i < 6; i++)
		{
			__BB_OBFUSCATOR_10(i);
		}
	}

	private string __BB_OBFUSCATOR_115(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_63()
	{
		__BB_OBFUSCATOR_24();
		for (int i = 1; i < 3; i += 0)
		{
			__BB_OBFUSCATOR_19(i);
		}
	}

	private void __BB_OBFUSCATOR_66(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(1, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_Value", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_AccumOrig", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("DoDamage", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("CameraFilterPack/FX_Scan", LMNDNMILCJB);
		for (int i = 0; i < 3; i++)
		{
			FKEJPAKBCNA.SetFloat("_FadeFX" + __BB_OBFUSCATOR_107(i + 1), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("WFX_Explosion" + __BB_OBFUSCATOR_60(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1261f - GDLONHCPAKF)) : (1673f * (1738f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (796f - GDLONHCPAKF)) : (832f * (431f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_111());
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_141()
	{
		return (int)NOLAGAOJELF;
	}

	private string __BB_OBFUSCATOR_5(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_15(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_91()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_59(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_Amount", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("FBXHeaderExtension:  {\n\tFBXHeaderVersion: 1003\n\tFBXVersion: 6100\n\tCreationTimeStamp:  {\n\t\tVersion: 1000\n", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("\\Microsoft\\WordPad", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_FoamContrast", LMNDNMILCJB);
		for (int i = 1; i < 6; i++)
		{
			FKEJPAKBCNA.SetFloat("_MainTex2" + __BB_OBFUSCATOR_14(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("Move Down" + __BB_OBFUSCATOR_22(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (365f - GDLONHCPAKF)) : (1568f * (735f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1652f - GDLONHCPAKF)) : (244f * (11f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_49());
	}

	private void __BB_OBFUSCATOR_135(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(1, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_ScreenResolution", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Skybox", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("Label", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("\"OO\", \"Model::", LMNDNMILCJB);
		for (int i = 0; i < 5; i += 0)
		{
			FKEJPAKBCNA.SetFloat("_ScreenResolution" + __BB_OBFUSCATOR_14(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("offsets" + __BB_OBFUSCATOR_107(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (202f - GDLONHCPAKF)) : (303f * (602f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (613f - GDLONHCPAKF)) : (625f * (197f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_91());
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_74(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_15(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_118(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_120(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_78(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_96()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("Speed (", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_Value", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("\\Google\\g65KYJszcHtFhpDC", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(0, 1, TextureFormat.ARGB32, true);
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("offsets", DFJIPKENOGK);
		for (int i = 1; i < 6; i += 0)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(871f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_127()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_87(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_120(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_89(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_18(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private string __BB_OBFUSCATOR_60(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_134(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(1, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("RoundDuration", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Value", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("|", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("ObjectType", LMNDNMILCJB);
		for (int i = 1; i < 4; i++)
		{
			FKEJPAKBCNA.SetFloat("_Transparency" + __BB_OBFUSCATOR_22(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_MainTex2" + __BB_OBFUSCATOR_107(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1038f - GDLONHCPAKF)) : (183f * (642f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1906f - GDLONHCPAKF)) : (331f * (891f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_100());
	}

	private string __BB_OBFUSCATOR_28(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_139(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 1835f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1063f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(307f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 212f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 301f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1070f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 512f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			swap(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_18(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_87(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private string __BB_OBFUSCATOR_52(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private string __BB_OBFUSCATOR_123(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_44(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_Value2", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("Shockwave-Default", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("SUR/", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_ScreenResolution", LMNDNMILCJB);
		for (int i = 1; i < 3; i++)
		{
			FKEJPAKBCNA.SetFloat("g " + __BB_OBFUSCATOR_14(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("DoDamage" + __BB_OBFUSCATOR_93(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1153f - GDLONHCPAKF)) : (1178f * (1096f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (686f - GDLONHCPAKF)) : (1327f * (807f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_100());
	}

	private string __BB_OBFUSCATOR_11(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private string __BB_OBFUSCATOR_101(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("Slow Mo: ", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("All players have been killed...", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture(">", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(1, 0, TextureFormat.ARGB4444, true);
		DFJIPKENOGK.SetPixel(1, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: ", DFJIPKENOGK);
		for (int i = 1; i < 5; i += 0)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(569f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_118(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_72(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Sandbox", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("</size>", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("GlobalSettings", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_Value", LMNDNMILCJB);
		for (int i = 0; i < 7; i += 0)
		{
			FKEJPAKBCNA.SetFloat("PlayerName" + __BB_OBFUSCATOR_107(i + 1), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("RefTime" + __BB_OBFUSCATOR_14(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (941f - GDLONHCPAKF)) : (1990f * (1071f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1739f - GDLONHCPAKF)) : (1675f * (1327f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_132());
	}

	private void __BB_OBFUSCATOR_94()
	{
		__BB_OBFUSCATOR_2();
		for (int i = 0; i < 5; i++)
		{
			__BB_OBFUSCATOR_95(i);
		}
	}

	private void __BB_OBFUSCATOR_16(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_Value3", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("open", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("team2", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_ScreenResolution", LMNDNMILCJB);
		for (int i = 0; i < 8; i++)
		{
			FKEJPAKBCNA.SetFloat("_Y" + __BB_OBFUSCATOR_130(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("Application target framerate set to " + __BB_OBFUSCATOR_115(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (694f - GDLONHCPAKF)) : (1272f * (337f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1448f - GDLONHCPAKF)) : (160f * (121f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_13());
	}

	private string __BB_OBFUSCATOR_117(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_9()
	{
		return (int)NOLAGAOJELF;
	}

	private void OnRenderImage(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_NormalTex", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_OverlayTex", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("_Distortion", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_Relief", LMNDNMILCJB);
		for (int i = 0; i < 4; i++)
		{
			FKEJPAKBCNA.SetFloat("_Intensity" + s(i + 1), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_NormalOffsetScale" + s(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1f - GDLONHCPAKF)) : (2.5f * (1f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1f - GDLONHCPAKF)) : (2.5f * (1f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, MJJBMGBOKGI);
	}

	private void __BB_OBFUSCATOR_26(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("RMB - aim", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("FireballB", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("_Size", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("\n\t\t}", LMNDNMILCJB);
		for (int i = 0; i < 1; i++)
		{
			FKEJPAKBCNA.SetFloat("Jump" + __BB_OBFUSCATOR_5(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("wss://{0}:{1}" + __BB_OBFUSCATOR_101(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1260f - GDLONHCPAKF)) : (161f * (1343f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1985f - GDLONHCPAKF)) : (317f * (1694f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_119());
	}

	private void __BB_OBFUSCATOR_70(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("stopping ", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_Intensity", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("Full Ammo    ", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_TimeX", LMNDNMILCJB);
		for (int i = 1; i < 7; i += 0)
		{
			FKEJPAKBCNA.SetFloat("Restarted" + __BB_OBFUSCATOR_54(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_Value" + __BB_OBFUSCATOR_101(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1236f - GDLONHCPAKF)) : (1531f * (1826f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (394f - GDLONHCPAKF)) : (31f * (926f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, MJJBMGBOKGI);
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_121()
	{
		return (int)NOLAGAOJELF;
	}

	private string s(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_110()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_120(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_89(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			swap(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load(">", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("networkAddMessage", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("\"Skin\"", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(0, 1, (TextureFormat)0, true);
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("{0:0}:{1:00}", DFJIPKENOGK);
		for (int i = 1; i < 1; i++)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(740f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_7(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 17f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 59f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(315f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 773f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1981f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1276f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 754f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		__BB_OBFUSCATOR_110();
		for (int i = 0; i < 8; i += 0)
		{
			__BB_OBFUSCATOR_4(i);
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_133(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_77(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_15(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("CameraFilterPack/Blend2Camera_HardLight", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("Player", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("SBX", CPNKHGPBCBH);
		DFJIPKENOGK = new Texture2D(1, 1, TextureFormat.RGB24, true);
		DFJIPKENOGK.SetPixel(1, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_BlurRadius4", DFJIPKENOGK);
		for (int i = 1; i < 6; i++)
		{
			GHMOHGFHJOA[i] = new NormData();
			GHMOHGFHJOA[i].timeLeft = UnityEngine.Random.Range(518f, CMGLILNFIHB);
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		__BB_OBFUSCATOR_98();
		for (int i = 1; i < 7; i += 0)
		{
			__BB_OBFUSCATOR_88(i);
		}
	}

	private void __BB_OBFUSCATOR_84(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 985f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 388f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(478f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 522f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 437f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1732f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 533f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_92(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("_TimeX", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("{0:n6},{1:n6},{2:n6}", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("_Offsets", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("Floor", LMNDNMILCJB);
		for (int i = 1; i < 4; i++)
		{
			FKEJPAKBCNA.SetFloat(">" + __BB_OBFUSCATOR_22(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("</size>" + __BB_OBFUSCATOR_54(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (866f - GDLONHCPAKF)) : (1557f * (11f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1107f - GDLONHCPAKF)) : (1925f * (117f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_20());
	}

	private void Update()
	{
		Init();
		for (int i = 0; i < 4; i++)
		{
			UpdateInstance(i);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_129()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_32(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture(")</color></size>", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("_MainTex2", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("Please make sure to assign a view target!", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("CameraFilterPack_OldFilm2", LMNDNMILCJB);
		for (int i = 0; i < 4; i += 0)
		{
			FKEJPAKBCNA.SetFloat("_Value" + __BB_OBFUSCATOR_11(i + 1), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_Value4" + __BB_OBFUSCATOR_123(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1828f - GDLONHCPAKF)) : (1307f * (1222f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (666f - GDLONHCPAKF)) : (1710f * (41f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_55());
	}

	private void __BB_OBFUSCATOR_87(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_55()
	{
		return (int)NOLAGAOJELF;
	}

	private void UpdateInstance(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 0.5f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 0.1f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(0f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 0.5f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 0.1f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 0f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 0f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void swap(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private void __BB_OBFUSCATOR_30(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(1, 0, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Kills", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("\n", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("<size=", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("ShowerEffectShader", LMNDNMILCJB);
		for (int i = 0; i < 3; i += 0)
		{
			FKEJPAKBCNA.SetFloat("colorA" + s(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("_SunColor" + __BB_OBFUSCATOR_101(i + 1), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (1398f - GDLONHCPAKF)) : (1544f * (1879f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1495f - GDLONHCPAKF)) : (832f * (969f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_43());
	}

	private void __BB_OBFUSCATOR_61(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 821f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 779f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1520f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 1772f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 1228f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1470f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 1744f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_95(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 1125f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 322f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1781f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 947f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 661f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 558f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 124f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_113(int NEOOCOCLNPO)
	{
		GHMOHGFHJOA[NEOOCOCLNPO].t += Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].timeLeft -= Time.deltaTime;
		GHMOHGFHJOA[NEOOCOCLNPO].valy = GHMOHGFHJOA[NEOOCOCLNPO].c + 884f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].acceleration * 1614f + HFDNMMCHMBO * GHMOHGFHJOA[NEOOCOCLNPO].t;
		GHMOHGFHJOA[NEOOCOCLNPO].intensity = Mathf.Max(1830f, GHMOHGFHJOA[NEOOCOCLNPO].intensity - 536f * GHMOHGFHJOA[NEOOCOCLNPO].t * GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed * 258f);
		if (GHMOHGFHJOA[NEOOCOCLNPO].timeLeft <= 1027f)
		{
			GHMOHGFHJOA[NEOOCOCLNPO].t = 1488f;
			GHMOHGFHJOA[NEOOCOCLNPO].intensity = KHJJDIADALD;
			GHMOHGFHJOA[NEOOCOCLNPO].timeLeft = UnityEngine.Random.Range(LOIMGLOPEPM, CMGLILNFIHB);
			GHMOHGFHJOA[NEOOCOCLNPO].acceleration = UnityEngine.Random.Range(CHINDKADBDO, AHFNEKDNNEO);
			GHMOHGFHJOA[NEOOCOCLNPO].valx = UnityEngine.Random.value;
			GHMOHGFHJOA[NEOOCOCLNPO].valy = (GHMOHGFHJOA[NEOOCOCLNPO].c = UnityEngine.Random.value);
			GHMOHGFHJOA[NEOOCOCLNPO].fadeSpeed = UnityEngine.Random.Range(AMOAFABIKNH, PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_105(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		DFJIPKENOGK.SetPixel(0, 1, GKHMAPDGANJ);
		DFJIPKENOGK.Apply();
		FKEJPAKBCNA.SetTexture("Fire1", CPNKHGPBCBH);
		FKEJPAKBCNA.SetTexture("|", DFJIPKENOGK);
		FKEJPAKBCNA.SetFloat("Connect", 0f - HHOHFJLDHJE);
		FKEJPAKBCNA.SetFloat("_ScreenResolution", LMNDNMILCJB);
		for (int i = 0; i < 8; i++)
		{
			FKEJPAKBCNA.SetFloat("_DotSize" + __BB_OBFUSCATOR_54(i + 0), GHMOHGFHJOA[i].intensity);
			FKEJPAKBCNA.SetVector("MapName" + __BB_OBFUSCATOR_14(i + 0), new Vector4(GHMOHGFHJOA[i].valx, GHMOHGFHJOA[i].valy, (!GLCAMCAMIMF) ? ((float)Screen.width / (float)CPNKHGPBCBH.width * (231f - GDLONHCPAKF)) : (1712f * (123f - GDLONHCPAKF)), (!GLCAMCAMIMF) ? ((float)Screen.height / (float)CPNKHGPBCBH.height * (1140f - GDLONHCPAKF)) : (504f * (76f - GDLONHCPAKF))));
		}
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA, __BB_OBFUSCATOR_20());
	}

	private string __BB_OBFUSCATOR_54(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_104()
	{
		__BB_OBFUSCATOR_68();
		for (int i = 1; i < 7; i++)
		{
			__BB_OBFUSCATOR_19(i);
		}
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_100()
	{
		return (int)NOLAGAOJELF;
	}

	private void __BB_OBFUSCATOR_77(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	private string __BB_OBFUSCATOR_22(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private string __BB_OBFUSCATOR_14(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			__BB_OBFUSCATOR_78(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			__BB_OBFUSCATOR_31(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			__BB_OBFUSCATOR_118(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private string __BB_OBFUSCATOR_93(int GDILHGCPDFC)
	{
		return GDILHGCPDFC.ToString();
	}

	private void __BB_OBFUSCATOR_122()
	{
		__BB_OBFUSCATOR_137();
		for (int i = 1; i < 1; i++)
		{
			__BB_OBFUSCATOR_10(i);
		}
	}

	private void Init()
	{
		if (LOIMGLOPEPM > CMGLILNFIHB)
		{
			swap(ref LOIMGLOPEPM, ref CMGLILNFIHB);
		}
		if (CHINDKADBDO > AHFNEKDNNEO)
		{
			swap(ref CHINDKADBDO, ref AHFNEKDNNEO);
		}
		if (AMOAFABIKNH > PJEGDGJOPAI)
		{
			swap(ref AMOAFABIKNH, ref PJEGDGJOPAI);
		}
	}

	private void __BB_OBFUSCATOR_133(ref float IENMFMEGJAB, ref float AHKONPFPEKH)
	{
		float num = IENMFMEGJAB;
		IENMFMEGJAB = AHKONPFPEKH;
		AHKONPFPEKH = num;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_116()
	{
		return (int)NOLAGAOJELF;
	}

	[SpecialName]
	private int __BB_OBFUSCATOR_13()
	{
		return (int)NOLAGAOJELF;
	}
}
