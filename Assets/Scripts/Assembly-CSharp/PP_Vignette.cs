using UnityEngine;

[AddComponentMenu("Image Effects/Aubergine/Vignette")]
[ExecuteInEditMode]
public class PP_Vignette : PostProcessBase
{
	public float OHPDCFDAIGC = 3f;

	public float CPKOFALNJEM = 0.5f;

	private void OnRenderImage(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		base.MFOLDHOAMNN.SetFloat("_Radius", OHPDCFDAIGC);
		base.MFOLDHOAMNN.SetFloat("_Darkness", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, base.MFOLDHOAMNN);
	}

	private void __BB_OBFUSCATOR_18(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_104().SetFloat("TeamName", OHPDCFDAIGC);
		__BB_OBFUSCATOR_93().SetFloat("\n\t\t}", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_12());
	}

	private void __BB_OBFUSCATOR_9(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_126().SetFloat("_Value2", OHPDCFDAIGC);
		__BB_OBFUSCATOR_12().SetFloat("_Value4", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_91());
	}

	private void OnEnable()
	{
		BNLDNPPEODB = Shader.Find("Hidden/Aubergine/Vignette");
	}

	private void __BB_OBFUSCATOR_19(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_127().SetFloat("_ColorB", OHPDCFDAIGC);
		__BB_OBFUSCATOR_69().SetFloat("Draw... Restarting", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_93());
	}

	private void __BB_OBFUSCATOR_16(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_86().SetFloat("_Value", OHPDCFDAIGC);
		__BB_OBFUSCATOR_124().SetFloat("_Value2", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_109());
	}

	private new void __BB_OBFUSCATOR_11()
	{
		BNLDNPPEODB = Shader.Find("Toast");
	}

	private new void __BB_OBFUSCATOR_25()
	{
		BNLDNPPEODB = Shader.Find("Max Players: ");
	}

	private void __BB_OBFUSCATOR_6(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_124().SetFloat("Vertices: ", OHPDCFDAIGC);
		__BB_OBFUSCATOR_28().SetFloat("MP", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_28());
	}

	private void __BB_OBFUSCATOR_21(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_84().SetFloat("_SampleDistance", OHPDCFDAIGC);
		__BB_OBFUSCATOR_54().SetFloat("offsets", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_69());
	}

	private void __BB_OBFUSCATOR_14()
	{
		BNLDNPPEODB = Shader.Find("Diffuse");
	}

	private new void __BB_OBFUSCATOR_23()
	{
		BNLDNPPEODB = Shader.Find("Label");
	}

	private void __BB_OBFUSCATOR_5()
	{
		BNLDNPPEODB = Shader.Find("_Value");
	}

	private void __BB_OBFUSCATOR_10(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_54().SetFloat("CameraFilterPack/Blend2Camera_Color", OHPDCFDAIGC);
		__BB_OBFUSCATOR_36().SetFloat("_Value3", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_74());
	}

	private void __BB_OBFUSCATOR_7(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_52().SetFloat(",", OHPDCFDAIGC);
		__BB_OBFUSCATOR_39().SetFloat("_Value4", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_91());
	}

	private void __BB_OBFUSCATOR_4()
	{
		BNLDNPPEODB = Shader.Find("OnLadder");
	}

	private void __BB_OBFUSCATOR_13(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_109().SetFloat("DM", OHPDCFDAIGC);
		__BB_OBFUSCATOR_54().SetFloat("<color=black>", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_8());
	}

	private void __BB_OBFUSCATOR_1(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_88().SetFloat("APP", OHPDCFDAIGC);
		__BB_OBFUSCATOR_75().SetFloat("MP", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_100());
	}

	private new void __BB_OBFUSCATOR_3()
	{
		BNLDNPPEODB = Shader.Find("_BlurSize");
	}

	private new void __BB_OBFUSCATOR_27()
	{
		BNLDNPPEODB = Shader.Find("</color></size>");
	}

	private new void __BB_OBFUSCATOR_0()
	{
		BNLDNPPEODB = Shader.Find("\n\t\t}");
	}
}
