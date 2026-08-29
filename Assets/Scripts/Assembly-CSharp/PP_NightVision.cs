using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Aubergine/NightVision")]
public class PP_NightVision : PostProcessBase
{
	public Color IOFNOJHNJAJ = Color.white;

	private float PJIFNNLMKIM = 1f;

	private float HHEODCGDNIB = 1.5f;

	private void __BB_OBFUSCATOR_19(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_109().SetFloat("_Value2", PJIFNNLMKIM);
		__BB_OBFUSCATOR_104().SetFloat("\t\tVersion: 1000\n\t\tProperties60:  {\n\t\t\tProperty: \"UpAxis\", \"int\", \"\",1\n\t\t\tProperty: \"UpAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"FrontAxis\", \"int\", \"\",2\n\t\t\tProperty: \"FrontAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"CoordAxis\", \"int\", \"\",0\n\t\t\tProperty: \"CoordAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"UnitScaleFactor\", \"double\", \"\",100\n\t\t}\n", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_69());
	}

	private void __BB_OBFUSCATOR_16(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_127().SetFloat("CameraFilterPack/Edge_Sigmoid", PJIFNNLMKIM);
		__BB_OBFUSCATOR_57().SetFloat("CameraFilterPack_OldFilm1", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_91());
	}

	private void __BB_OBFUSCATOR_2(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_57().SetFloat("CameraFilterPack/Vision_Crystal", PJIFNNLMKIM);
		__BB_OBFUSCATOR_86().SetFloat("Move Up2", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_70());
	}

	private void __BB_OBFUSCATOR_23(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_126().SetFloat("Mouse X", PJIFNNLMKIM);
		__BB_OBFUSCATOR_91().SetFloat("|", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_88());
	}

	private void OnEnable()
	{
		BNLDNPPEODB = Shader.Find("Hidden/Aubergine/NightVision");
	}

	private void __BB_OBFUSCATOR_20(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_116().SetFloat("TeamName", PJIFNNLMKIM);
		__BB_OBFUSCATOR_91().SetFloat("HeadURL", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_3());
	}

	private void __BB_OBFUSCATOR_4(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_113().SetFloat("SyncWave", PJIFNNLMKIM);
		__BB_OBFUSCATOR_85().SetFloat("syncShotGun", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_86());
	}

	private new void __BB_OBFUSCATOR_13()
	{
		BNLDNPPEODB = Shader.Find("Right Stick Up");
	}

	private void __BB_OBFUSCATOR_22()
	{
		BNLDNPPEODB = Shader.Find("_MainTex2");
	}

	private new void __BB_OBFUSCATOR_11()
	{
		BNLDNPPEODB = Shader.Find("_TimeX");
	}

	private void __BB_OBFUSCATOR_10(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_115().SetFloat("TDM", PJIFNNLMKIM);
		__BB_OBFUSCATOR_84().SetFloat("offsets", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, base.MFOLDHOAMNN);
	}

	private void __BB_OBFUSCATOR_9(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		__BB_OBFUSCATOR_8().SetFloat("_Value4", PJIFNNLMKIM);
		__BB_OBFUSCATOR_110().SetFloat("<size=20>", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, __BB_OBFUSCATOR_28());
	}

	private void __BB_OBFUSCATOR_14()
	{
		BNLDNPPEODB = Shader.Find("<");
	}

	private void OnRenderImage(RenderTexture CELCOOMALGI, RenderTexture NMHCJEOGGNO)
	{
		base.MFOLDHOAMNN.SetFloat("_Red", PJIFNNLMKIM);
		base.MFOLDHOAMNN.SetFloat("_Blue", HHEODCGDNIB);
		Graphics.Blit(CELCOOMALGI, NMHCJEOGGNO, base.MFOLDHOAMNN);
	}
}
