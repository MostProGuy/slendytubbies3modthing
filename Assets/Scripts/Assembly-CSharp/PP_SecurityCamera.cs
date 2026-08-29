using UnityEngine;

[AddComponentMenu("Image Effects/Aubergine/SecurityCamera")]
[ExecuteInEditMode]
public class PP_SecurityCamera : PostProcessBase
{
	public Color IOFNOJHNJAJ = Color.white;

	public float DBJLMBHEMDG = 2f;

	public float NLGBFNNFBBK = 3f;

	public float HBFCEOLLLEN = 0.5f;

	public float CPKOFALNJEM = 0.75f;

	private void __BB_OBFUSCATOR_11(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_36().SetColor("MP", IOFNOJHNJAJ);
		__BB_OBFUSCATOR_100().SetFloat("Fight Off Infected To win", DBJLMBHEMDG);
		__BB_OBFUSCATOR_126().SetFloat("_Value", NLGBFNNFBBK);
		__BB_OBFUSCATOR_39().SetFloat("_SoftZDistance", HBFCEOLLLEN);
		base.__BB_OBFUSCATOR_23().SetFloat("PlayerFellDown", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_127());
	}

	private new void __BB_OBFUSCATOR_23()
	{
		BNLDNPPEODB = Shader.Find("n6");
	}

	private void __BB_OBFUSCATOR_22()
	{
		BNLDNPPEODB = Shader.Find("_Value");
	}

	private void __BB_OBFUSCATOR_19(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		base.__BB_OBFUSCATOR_12().SetColor("_Radius", IOFNOJHNJAJ);
		__BB_OBFUSCATOR_91().SetFloat("_BumpAmt", DBJLMBHEMDG);
		__BB_OBFUSCATOR_39().SetFloat("CameraFilterPack/Light_Rainbow2", NLGBFNNFBBK);
		__BB_OBFUSCATOR_91().SetFloat("\"Deformer::Skin ", HBFCEOLLLEN);
		__BB_OBFUSCATOR_75().SetFloat(",", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, base.MFOLDHOAMNN);
	}

	private void __BB_OBFUSCATOR_25(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_84().SetColor("CameraFilterPack/Blend2Camera_Blend", IOFNOJHNJAJ);
		__BB_OBFUSCATOR_85().SetFloat("Continue", DBJLMBHEMDG);
		__BB_OBFUSCATOR_85().SetFloat("team1", NLGBFNNFBBK);
		__BB_OBFUSCATOR_116().SetFloat("ZWName'", HBFCEOLLLEN);
		__BB_OBFUSCATOR_52().SetFloat("_TapLow", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_126());
	}

	private new void __BB_OBFUSCATOR_12()
	{
		BNLDNPPEODB = Shader.Find("WeaponManager");
	}

	private new void __BB_OBFUSCATOR_7()
	{
		BNLDNPPEODB = Shader.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
	}

	private void __BB_OBFUSCATOR_20()
	{
		BNLDNPPEODB = Shader.Find("_Value2");
	}

	private void OnEnable()
	{
		BNLDNPPEODB = Shader.Find("Hidden/Aubergine/SecurityCamera");
	}

	private new void __BB_OBFUSCATOR_18()
	{
		BNLDNPPEODB = Shader.Find("wrong details..");
	}

	private void __BB_OBFUSCATOR_14(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_122().SetColor("Open", IOFNOJHNJAJ);
		__BB_OBFUSCATOR_84().SetFloat("left", DBJLMBHEMDG);
		__BB_OBFUSCATOR_74().SetFloat(">", NLGBFNNFBBK);
		__BB_OBFUSCATOR_100().SetFloat("ns.exitgames.com", HBFCEOLLLEN);
		__BB_OBFUSCATOR_116().SetFloat("InControl", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_54());
	}

	private void OnRenderImage(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		base.MFOLDHOAMNN.SetColor("_MainTex", IOFNOJHNJAJ);
		base.MFOLDHOAMNN.SetFloat("_Speed", DBJLMBHEMDG);
		base.MFOLDHOAMNN.SetFloat("_Thickness", NLGBFNNFBBK);
		base.MFOLDHOAMNN.SetFloat("_Luminance", HBFCEOLLLEN);
		base.MFOLDHOAMNN.SetFloat("_Darkness", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, base.MFOLDHOAMNN);
	}

	private new void __BB_OBFUSCATOR_8()
	{
		BNLDNPPEODB = Shader.Find("Deaths");
	}

	private new void __BB_OBFUSCATOR_2()
	{
		BNLDNPPEODB = Shader.Find("red");
	}

	private new void __BB_OBFUSCATOR_26()
	{
		BNLDNPPEODB = Shader.Find("_TimeX");
	}

	private new void __BB_OBFUSCATOR_16()
	{
		BNLDNPPEODB = Shader.Find("_DotSize");
	}

	private void __BB_OBFUSCATOR_15(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_54().SetColor("mouse x", IOFNOJHNJAJ);
		base.__BB_OBFUSCATOR_12().SetFloat("_TimeX", DBJLMBHEMDG);
		__BB_OBFUSCATOR_91().SetFloat("Crouch", NLGBFNNFBBK);
		__BB_OBFUSCATOR_116().SetFloat("_Value5", HBFCEOLLLEN);
		base.__BB_OBFUSCATOR_8().SetFloat("Loading complete", CPKOFALNJEM);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_91());
	}

	private void __BB_OBFUSCATOR_21()
	{
		BNLDNPPEODB = Shader.Find("_Value3");
	}
}
