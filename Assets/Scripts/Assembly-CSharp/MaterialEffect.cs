using System;
using UnityEngine;

[Serializable]
public class MaterialEffect
{
	public Material m_EffectMaterial;

	public bool m_EnableAlphaAnimation;

	public float m_AlphaAnimationTimeScale = 1f;

	public AnimationCurve m_AlphaCurve = new AnimationCurve();

	public Texture m_MainTexture;

	public Texture m_MaskTexutre;

	public TextureWrapMode m_MainTexWrapMode;

	public TextureWrapMode m_MaskTexWrapMode;

	public bool m_EnableUVScroll;

	public Vector2 m_UVScrollMainTex;

	public Vector2 m_UVScrollCutTex;

	public void __BB_OBFUSCATOR_33(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("mouse y", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_Value2", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_26(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Hat:", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_TimeX", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_44(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("SUR"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MG");
			}
			if (MFOLDHOAMNN.HasProperty("Difficulty"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_UnderwaterMode");
			}
		}
	}

	private void __BB_OBFUSCATOR_10(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_84(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("Team1Score"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MainMenu");
			}
			if (MFOLDHOAMNN.HasProperty("SyncNPCCount"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture(" ");
			}
		}
	}

	public void __BB_OBFUSCATOR_1(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Signed in", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("DoDamage", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_41(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public MaterialEffect(Material MFOLDHOAMNN)
	{
	}

	public void __BB_OBFUSCATOR_80(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty(" a = "))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_ScreenResolution");
			}
			if (MFOLDHOAMNN.HasProperty("\\Google"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_ScreenResolution");
			}
		}
	}

	private void __BB_OBFUSCATOR_116(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_58(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("colorC", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("MP", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_112(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("\t\t\tMatrix: ", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Image", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_36(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_SunPosition"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_FgOverlap");
			}
			if (MFOLDHOAMNN.HasProperty("_Green_C"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_EdgeThresholdMin");
			}
		}
	}

	private void __BB_OBFUSCATOR_93(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_107(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_128(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_2(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_Red_R", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("MainMenu", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_20(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_48(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("Difficulty"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_MainTex");
			}
			if (MFOLDHOAMNN.HasProperty("http://zeoworks.com/home/other/s3update.html"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Jump");
			}
		}
	}

	private void __BB_OBFUSCATOR_55(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_126(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty(","))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("CameraFilterPack/Edge_Sigmoid");
			}
			if (MFOLDHOAMNN.HasProperty("_Value4"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("3");
			}
		}
	}

	private void __BB_OBFUSCATOR_27(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_24(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("-Seconds Played: ", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset(" Simplified", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_65(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("team2", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset(">", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_53(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_121(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_89(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_respawnAfter", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Fire", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_40(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("APP"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MapName");
			}
			if (MFOLDHOAMNN.HasProperty("_ScreenResolution"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Dead");
			}
		}
	}

	public void __BB_OBFUSCATOR_54(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("controller3", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/Blur_Noise", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_82(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_83(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_102(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_NeighbourMaxTex", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/Colors_Adjust_PreFilters", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_57(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_23(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_ExposureAdjustment", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Vertical", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_113(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_105(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Run", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Team B", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_43(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("/data.txt"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("INF");
			}
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/Color_BrightContrastSaturation"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Concrete");
			}
		}
	}

	public void __BB_OBFUSCATOR_14(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("PlayerLeftRoom", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("clear", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_94(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_TimeX"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MP");
			}
			if (MFOLDHOAMNN.HasProperty("Vertical"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Value2");
			}
		}
	}

	public void __BB_OBFUSCATOR_75(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/FX_Dot_Circle"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("n15");
			}
			if (MFOLDHOAMNN.HasProperty(" Simplified"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_FoamContrast");
			}
		}
	}

	public void __BB_OBFUSCATOR_9(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("ZWName'"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_Value5");
			}
			if (MFOLDHOAMNN.HasProperty("Vertical"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("TeamTag");
			}
		}
	}

	private void __BB_OBFUSCATOR_99(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_110(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/Drawing_CellShading2", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("MP", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_117(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Player", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Network", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_3(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("<size=", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("SyncShopID", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_49(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_25(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void UpdateEffect(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_MainTex", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_CutTex", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_5(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_119(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("WeaponManager", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("SecondaryCausticsProjector", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_124(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_45(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("Player"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Reset");
			}
			if (MFOLDHOAMNN.HasProperty("Difficulty"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("8");
			}
		}
	}

	public void __BB_OBFUSCATOR_135(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_Offsets", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("TeamTag", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_62(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_37(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_78(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("FlyCam", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_ScreenResolution", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_115(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("<"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_MinVelocity");
			}
			if (MFOLDHOAMNN.HasProperty("|"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("We connected to Photon Cloud");
			}
		}
	}

	public void __BB_OBFUSCATOR_18(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("OnExternalVelocity", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("\n\t\tGeometryVersion: 124", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_51(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_125(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/TV_BrokenGlass2", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("team2", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_100(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset(" ", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("threshold", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_28(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_ScreenResolution"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_PositionX");
			}
			if (MFOLDHOAMNN.HasProperty("WFX_MF FPS"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Value4");
			}
		}
	}

	public void __BB_OBFUSCATOR_61(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("Ping"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Attack");
			}
			if (MFOLDHOAMNN.HasProperty("_Value2"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Vertical");
			}
		}
	}

	public void __BB_OBFUSCATOR_11(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_TimeX"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_Smooth");
			}
			if (MFOLDHOAMNN.HasProperty("_MainTex2"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Intensity");
			}
		}
	}

	public void __BB_OBFUSCATOR_108(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("SoftBody"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MP");
			}
			if (MFOLDHOAMNN.HasProperty("FlyCam"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Teleport");
			}
		}
	}

	public void __BB_OBFUSCATOR_98(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_TapLowBackground", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("No secret in authentication response.", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_12(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_Offsets"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_TimeX");
			}
			if (MFOLDHOAMNN.HasProperty("<size="))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Value2");
			}
		}
	}

	private void __BB_OBFUSCATOR_71(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_91(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_74(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_TimeX"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("COOP/");
			}
			if (MFOLDHOAMNN.HasProperty(", phase = "))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Value2");
			}
		}
	}

	public void __BB_OBFUSCATOR_111(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_Intensity"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_DotSize");
			}
			if (MFOLDHOAMNN.HasProperty("_CutTex"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("\t\t\tMatrix: ");
			}
		}
	}

	private void __BB_OBFUSCATOR_8(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_31(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Player connected", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_ExposureAdjustment", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_76(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_79(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Fire", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Deformer", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_97(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_46(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("SyncTime", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("n1", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_118(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Label", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("ForceDamage", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_39(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_127(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_AOTex"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_ToPrevViewProjCombined");
			}
			if (MFOLDHOAMNN.HasProperty("Respawn in"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("\", \"Limb\" {\n\t\tVersion: 232\n\t\tProperties60:  {\n\t\t\tProperty: \"Visibility\", \"Visibility\", \"A+\",1\n\t\t\tProperty: \"Lcl Translation\", \"Lcl Translation\", \"A+\",");
			}
		}
	}

	public void __BB_OBFUSCATOR_16(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("INF", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("PrimaryCausticsProjector", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_77(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty(", "))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("CameraFilterPack/Real_VHS");
			}
			if (MFOLDHOAMNN.HasProperty("_Value3"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("LegsURL");
			}
		}
	}

	public void ReInitMaterial(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_MainTex"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_MainTex");
			}
			if (MFOLDHOAMNN.HasProperty("_CutTex"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_CutTex");
			}
		}
	}

	public void __BB_OBFUSCATOR_72(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset(" ", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_Value3", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_120(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_Distance", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Team2Score", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_64(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("custard"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("MP");
			}
			if (MFOLDHOAMNN.HasProperty("_Red_C"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("CameraFilterPack/Drawing_Manga5");
			}
		}
	}

	public void __BB_OBFUSCATOR_56(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("TakeOut", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Deaths", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_52(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_66(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_Value3"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("team1");
			}
			if (MFOLDHOAMNN.HasProperty("_TintColor"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_MaxVelocity");
			}
		}
	}

	private void __BB_OBFUSCATOR_13(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_104(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("GameMode"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Vertical");
			}
			if (MFOLDHOAMNN.HasProperty("_Value2"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("CameraFilterPack/Blur_Radial");
			}
		}
	}

	public void __BB_OBFUSCATOR_132(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("\n"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_Value2");
			}
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/Drawing_Manga4"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_Offsets");
			}
		}
	}

	private void __BB_OBFUSCATOR_86(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_32(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("1", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_Value4", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_106(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	private void __BB_OBFUSCATOR_6(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_90(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("PublishMessage parameters must be non-null and not empty."))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Start Game");
			}
			if (MFOLDHOAMNN.HasProperty("_ScreenResolution"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture(",");
			}
		}
	}

	public void __BB_OBFUSCATOR_59(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_Value2"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("_ScreenResolution");
			}
			if (MFOLDHOAMNN.HasProperty("Mouse X"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture(",");
			}
		}
	}

	public void __BB_OBFUSCATOR_60(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/FX_Ascii", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Room Name ", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_70(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Building unique vertex data", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_Value3", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	private void __BB_OBFUSCATOR_17(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_88(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Mouse X", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_ScreenResolution", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_133(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_TimeX", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("_Value4", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_50(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("\", \"\" {\n\t\tVersion: 102\n\t\tShadingModel: \"lambert\"\n\t\tMultiLayer: 0\n\t\tProperties60:  {\n\t\t\tProperty: \"ShadingModel\", \"KString\", \"\", \"Lambert\"\n\t\t\tProperty: \"MultiLayer\", \"bool\", \"\",0\n\t\t\tProperty: \"EmissiveColor\", \"ColorRGB\", \"\",0.8000,0.8000,0.8000\n\t\t\tProperty: \"EmissiveFactor\", \"double\", \"\",0.0000\n\t\t\tProperty: \"AmbientColor\", \"ColorRGB\", \"\","))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Ping: ");
			}
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/TV_Noise"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("_TimeX");
			}
		}
	}

	public void __BB_OBFUSCATOR_131(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/Gradients_Ansi", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/TV_Posterize", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_81(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/Oculus_NightVision2"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("Deaths");
			}
			if (MFOLDHOAMNN.HasProperty("CameraFilterPack/Distortion_BlackHole"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("n6");
			}
		}
	}

	public void __BB_OBFUSCATOR_38(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("Restarted"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("CameraFilterPack/Distortion_Wave_Horizontal");
			}
			if (MFOLDHOAMNN.HasProperty("INF"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("Heal");
			}
		}
	}

	public void __BB_OBFUSCATOR_96(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("Mouse X", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/FX_Plasma", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_109(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("SUR/"))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("7");
			}
			if (MFOLDHOAMNN.HasProperty("\""))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("><b>▼</b></color>");
			}
		}
	}

	private void SetAlpha(float LNDAKDHHOCJ)
	{
		Color color = m_EffectMaterial.color;
		color.a = LNDAKDHHOCJ;
		m_EffectMaterial.color = color;
	}

	public void __BB_OBFUSCATOR_29(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("_ScreenResolution", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("Vertical", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}

	public void __BB_OBFUSCATOR_136(Material MFOLDHOAMNN)
	{
		if (!(MFOLDHOAMNN == null))
		{
			m_EffectMaterial = MFOLDHOAMNN;
			if (MFOLDHOAMNN.HasProperty("_diff\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\","))
			{
				m_MainTexture = MFOLDHOAMNN.GetTexture("CameraFilterPack_OldFilm2");
			}
			if (MFOLDHOAMNN.HasProperty("_Bullet_5"))
			{
				m_MaskTexutre = MFOLDHOAMNN.GetTexture("PublishMessage parameters must be non-null and not empty.");
			}
		}
	}

	public void __BB_OBFUSCATOR_92(float KOEHALKALKG)
	{
		if (m_MainTexture != null && m_MainTexWrapMode != m_MainTexture.wrapMode)
		{
			m_MainTexture.wrapMode = m_MainTexWrapMode;
		}
		if (m_MaskTexutre != null && m_MaskTexWrapMode != m_MaskTexutre.wrapMode)
		{
			m_MaskTexutre.wrapMode = m_MaskTexWrapMode;
		}
		if (m_EnableUVScroll)
		{
			if ((bool)m_MainTexture)
			{
				m_EffectMaterial.SetTextureOffset("TakeIn", m_UVScrollMainTex * KOEHALKALKG);
			}
			if ((bool)m_MaskTexutre)
			{
				m_EffectMaterial.SetTextureOffset("CameraFilterPack/Color_Invert", m_UVScrollCutTex * KOEHALKALKG);
			}
		}
	}
}
