using UnityEngine;

[AddComponentMenu("Image Effects/Rain/ShowerEffect")]
[ExecuteInEditMode]
public class ShowerEffect : MonoBehaviour
{
	private Material FKEJPAKBCNA;

	public Shader BNLDNPPEODB;

	public Texture2D CPNKHGPBCBH;

	[Range(0.01f, 1.5f)]
	public float IPFIDJNEEOO = 0.03f;

	[Range(0.05f, 2f)]
	public float IFMPDMGALDJ = 1f;

	[Range(0.05f, 2f)]
	public float PODINKPOENO = 0.5f;

	private float IDBKMMFEFCP;

	private void __BB_OBFUSCATOR_38()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Value2", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("Team1Score", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("WFX_MF", CPNKHGPBCBH);
	}

	public void __BB_OBFUSCATOR_15()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Value4", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("ScreenResolution = ", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("TeamName", CPNKHGPBCBH);
	}

	public void __BB_OBFUSCATOR_13()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_25(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("\n", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("offsets", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("FlyCam", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("ZWName'", new Vector4(1961f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	public void __BB_OBFUSCATOR_47()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	public void __BB_OBFUSCATOR_39()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	public void __BB_OBFUSCATOR_5()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_MainTex2", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("<size=", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_Red_B", CPNKHGPBCBH);
	}

	public void __BB_OBFUSCATOR_40()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_16(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Blend2Camera_LighterColor", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("Ping", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("V", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("_TimeX", new Vector4(1527f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("targetColor", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_MainTex2", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture(" ", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_0(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("_Red_C", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("Image", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("_Red_G", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("_TimeX", new Vector4(1936f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	public void __BB_OBFUSCATOR_11()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	public void __BB_OBFUSCATOR_1()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Val2", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_Value3", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_ScreenResolution", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("<size=", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("Team B", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Distortion_Half_Sphere", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_BgColor", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("colorB", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Light_Rainbow", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_7(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("CameraFilterPack/Distortion_Dream", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("_TimeX", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("n1", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("colorD", new Vector4(847f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	public void __BB_OBFUSCATOR_20()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void Awake()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("ShowerEffectShader", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("NormShower", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_NormalTex", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_28(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("_InvViewProj", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("n1", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("SyncWeaponsRPC", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("SyncWeaponsRPC", new Vector4(1313f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("CameraFilterPack/Color_GrayScale", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_Value4", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("<", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_10(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("_TimeX", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("_Value", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("team1", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("_Bullet_3", new Vector4(1424f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	public void __BB_OBFUSCATOR_27()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Green_R", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("SUR", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("TeamName", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("All custards have been found...", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("Horizontal", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("Walk", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Parameter", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("SyncWeaponsRPC", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("DM", CPNKHGPBCBH);
	}

	public void Update()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("\n\t\tLayerElementMaterial: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tMaterials: ", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("-Vertical", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("ShopBox/Heal/Text", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("Run", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_MainTex2", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_BumpMap", CPNKHGPBCBH);
	}

	public void __BB_OBFUSCATOR_30()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	public void __BB_OBFUSCATOR_46()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void __BB_OBFUSCATOR_37(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("\tTexture: \"Texture::", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("Hidden/Aubergine/SecurityCamera", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("_NoiseTex", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("CameraFilterPack/Gradients_Desert", new Vector4(1874f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("CameraFilterPack/Blur_Movie", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_ScreenResolution", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_MainTex2", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_19(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("_ScreenResolution", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("AddedCube", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("Connect", new Vector4(238f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("Target already added: ", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_TimeX", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_Value4", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load(" cannot be used as a 3D LUT.", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_PositionY", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("1: ", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_41(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("<size=", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("INF", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("_MainTex", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("\n", new Vector4(606f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	public void __BB_OBFUSCATOR_23()
	{
		IDBKMMFEFCP += Time.deltaTime * PODINKPOENO;
	}

	private void OnRenderImage(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("_NormalTex", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("_Intensity", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("_Alpha", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("_OffsetScale", new Vector4(0f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_Value", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("_ScreenResolution", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("_TimeX", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (!BNLDNPPEODB)
		{
			BNLDNPPEODB = Resources.Load("_TimeX", typeof(Shader)) as Shader;
		}
		if (!CPNKHGPBCBH)
		{
			CPNKHGPBCBH = Resources.Load("View", typeof(Texture2D)) as Texture2D;
		}
		FKEJPAKBCNA = new Material(BNLDNPPEODB);
		FKEJPAKBCNA.SetTexture("<size=", CPNKHGPBCBH);
	}

	private void __BB_OBFUSCATOR_22(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		FKEJPAKBCNA.SetTexture("Deaths", CPNKHGPBCBH);
		FKEJPAKBCNA.SetFloat("MP", IFMPDMGALDJ);
		FKEJPAKBCNA.SetFloat("Switch", IPFIDJNEEOO);
		FKEJPAKBCNA.SetVector("CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!", new Vector4(1964f, IDBKMMFEFCP, (float)Screen.width / (float)CPNKHGPBCBH.width, (float)Screen.height / (float)CPNKHGPBCBH.height));
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, FKEJPAKBCNA);
	}
}
