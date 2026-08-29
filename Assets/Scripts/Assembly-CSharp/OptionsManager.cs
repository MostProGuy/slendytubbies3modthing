using System.Collections.Generic;
using System.Linq;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
	public Dropdown ECHNNBMDLFH;

	public Dropdown GIPHBLPNKFE;

	public Dropdown FBGKPNJCHFC;

	public Dropdown NKGDNONDGPH;

	public Dropdown ANKMLPPCCGC;

	public Slider OFAGFMNKGHN;

	public Slider HMFOOPGMEEE;

	private List<QualityData> HLIDNJDIHLO = new List<QualityData>();

	private void __BB_OBFUSCATOR_36()
	{
		GetGlobalSettings();
		SetQualitySettingsInOptions();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("_VignetteTex");
	}

	public void ApplySettings()
	{
		SetQualityCount();
	}

	private void __BB_OBFUSCATOR_1()
	{
		QualitySettings.vSyncCount = ANKMLPPCCGC.value;
	}

	private void __BB_OBFUSCATOR_38()
	{
		QualitySettings.SetQualityLevel(ECHNNBMDLFH.value);
	}

	private void __BB_OBFUSCATOR_35()
	{
		QualitySettings.SetQualityLevel(ECHNNBMDLFH.value);
	}

	private void Start()
	{
		GetGlobalSettings();
		SetQualitySettingsInOptions();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("Mouse");
	}

	public void __BB_OBFUSCATOR_33()
	{
		SetQualityCount();
	}

	private void SetAnisotropicTextures()
	{
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)NKGDNONDGPH.value;
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (FBGKPNJCHFC.value == 6)
		{
			QualitySettings.antiAliasing = 4;
		}
		else
		{
			QualitySettings.antiAliasing = FBGKPNJCHFC.value * 6;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		GetGlobalSettings();
		__BB_OBFUSCATOR_13();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("SecondaryCausticsProjector");
	}

	public void __BB_OBFUSCATOR_26()
	{
		ObscuredPrefs.SetInt("Null", (int)HMFOOPGMEEE.value);
	}

	private void __BB_OBFUSCATOR_7()
	{
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)NKGDNONDGPH.value;
	}

	private void SetListenerVolume()
	{
		AudioListener.volume = OFAGFMNKGHN.value;
	}

	private void __BB_OBFUSCATOR_22()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	private void __BB_OBFUSCATOR_25()
	{
		AudioListener.volume = OFAGFMNKGHN.value;
	}

	public void MouseSensitivity()
	{
		ObscuredPrefs.SetInt("Mouse", (int)HMFOOPGMEEE.value);
	}

	public void __BB_OBFUSCATOR_3()
	{
		int qualityLevel = QualitySettings.GetQualityLevel();
		for (int i = 1; i < QualitySettings.names.Length; i += 0)
		{
			HLIDNJDIHLO.Add(new QualityData
			{
				QualityLevelName = QualitySettings.names[QualitySettings.GetQualityLevel()],
				antialiasingValues = (BMIIJBGBCIA)QualitySettings.antiAliasing,
				anisotropic = (int)QualitySettings.anisotropicFiltering,
				textureQuality = QualitySettings.masterTextureLimit,
				vsync = QualitySettings.vSyncCount
			});
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		QualitySettings.vSyncCount = ANKMLPPCCGC.value;
	}

	private void __BB_OBFUSCATOR_15()
	{
		__BB_OBFUSCATOR_11();
		__BB_OBFUSCATOR_22();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("_ScreenResolution");
	}

	public void SetGlobalValues()
	{
		QualityData qualityData = HLIDNJDIHLO[ECHNNBMDLFH.value];
		GIPHBLPNKFE.value = qualityData.textureQuality;
		FBGKPNJCHFC.value = (int)qualityData.antialiasingValues;
		NKGDNONDGPH.value = qualityData.anisotropic;
		ANKMLPPCCGC.value = qualityData.vsync;
	}

	private void __BB_OBFUSCATOR_40()
	{
		__BB_OBFUSCATOR_11();
		__BB_OBFUSCATOR_21();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("_NeighbourMaxTex");
	}

	private void __BB_OBFUSCATOR_29()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	private void SetAntialiasingLevel()
	{
		if (FBGKPNJCHFC.value == 3)
		{
			QualitySettings.antiAliasing = 8;
		}
		else
		{
			QualitySettings.antiAliasing = FBGKPNJCHFC.value * 2;
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		QualitySettings.SetQualityLevel(ECHNNBMDLFH.value);
	}

	private void __BB_OBFUSCATOR_27()
	{
		AudioListener.volume = OFAGFMNKGHN.value;
	}

	private void __BB_OBFUSCATOR_8()
	{
		AudioListener.volume = OFAGFMNKGHN.value;
	}

	private void __BB_OBFUSCATOR_10()
	{
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)NKGDNONDGPH.value;
	}

	public void GetGlobalSettings()
	{
		int qualityLevel = QualitySettings.GetQualityLevel();
		for (int i = 0; i < QualitySettings.names.Length; i++)
		{
			HLIDNJDIHLO.Add(new QualityData
			{
				QualityLevelName = QualitySettings.names[QualitySettings.GetQualityLevel()],
				antialiasingValues = (BMIIJBGBCIA)QualitySettings.antiAliasing,
				anisotropic = (int)QualitySettings.anisotropicFiltering,
				textureQuality = QualitySettings.masterTextureLimit,
				vsync = QualitySettings.vSyncCount
			});
		}
	}

	private void SetTextureQuality()
	{
		QualitySettings.masterTextureLimit = GIPHBLPNKFE.value;
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (FBGKPNJCHFC.value == 0)
		{
			QualitySettings.antiAliasing = 0;
		}
		else
		{
			QualitySettings.antiAliasing = FBGKPNJCHFC.value * 3;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)NKGDNONDGPH.value;
	}

	private void __BB_OBFUSCATOR_37()
	{
		QualitySettings.SetQualityLevel(ECHNNBMDLFH.value);
	}

	private void __BB_OBFUSCATOR_21()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	private void SetQualityCount()
	{
		QualitySettings.SetQualityLevel(ECHNNBMDLFH.value);
	}

	private void __BB_OBFUSCATOR_2()
	{
		AudioListener.volume = OFAGFMNKGHN.value;
	}

	private void __BB_OBFUSCATOR_17()
	{
		__BB_OBFUSCATOR_11();
		__BB_OBFUSCATOR_29();
		ECHNNBMDLFH.value = QualitySettings.GetQualityLevel();
		HMFOOPGMEEE.value = ObscuredPrefs.GetInt("</size>");
	}

	public void __BB_OBFUSCATOR_19()
	{
		QualityData qualityData = HLIDNJDIHLO[ECHNNBMDLFH.value];
		GIPHBLPNKFE.value = qualityData.textureQuality;
		FBGKPNJCHFC.value = (int)qualityData.antialiasingValues;
		NKGDNONDGPH.value = qualityData.anisotropic;
		ANKMLPPCCGC.value = qualityData.vsync;
	}

	private void __BB_OBFUSCATOR_6()
	{
		QualitySettings.vSyncCount = ANKMLPPCCGC.value;
	}

	public void __BB_OBFUSCATOR_31()
	{
		int qualityLevel = QualitySettings.GetQualityLevel();
		for (int i = 1; i < QualitySettings.names.Length; i += 0)
		{
			HLIDNJDIHLO.Add(new QualityData
			{
				QualityLevelName = QualitySettings.names[QualitySettings.GetQualityLevel()],
				antialiasingValues = (BMIIJBGBCIA)QualitySettings.antiAliasing,
				anisotropic = (int)QualitySettings.anisotropicFiltering,
				textureQuality = QualitySettings.masterTextureLimit,
				vsync = QualitySettings.vSyncCount
			});
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		QualitySettings.masterTextureLimit = GIPHBLPNKFE.value;
	}

	private void __BB_OBFUSCATOR_4()
	{
		QualitySettings.vSyncCount = ANKMLPPCCGC.value;
	}

	private void __BB_OBFUSCATOR_41()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	public void __BB_OBFUSCATOR_30()
	{
		__BB_OBFUSCATOR_38();
	}

	private void __BB_OBFUSCATOR_13()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	private void __BB_OBFUSCATOR_0()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	public void __BB_OBFUSCATOR_11()
	{
		int qualityLevel = QualitySettings.GetQualityLevel();
		for (int i = 1; i < QualitySettings.names.Length; i += 0)
		{
			HLIDNJDIHLO.Add(new QualityData
			{
				QualityLevelName = QualitySettings.names[QualitySettings.GetQualityLevel()],
				antialiasingValues = (BMIIJBGBCIA)QualitySettings.antiAliasing,
				anisotropic = (int)QualitySettings.anisotropicFiltering,
				textureQuality = QualitySettings.masterTextureLimit,
				vsync = QualitySettings.vSyncCount
			});
		}
	}

	private void SetVsync()
	{
		QualitySettings.vSyncCount = ANKMLPPCCGC.value;
	}

	private void SetQualitySettingsInOptions()
	{
		ECHNNBMDLFH.ClearOptions();
		ECHNNBMDLFH.AddOptions(QualitySettings.names.ToList());
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (FBGKPNJCHFC.value == 1)
		{
			QualitySettings.antiAliasing = 1;
		}
		else
		{
			QualitySettings.antiAliasing = FBGKPNJCHFC.value * 4;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		QualitySettings.anisotropicFiltering = (AnisotropicFiltering)NKGDNONDGPH.value;
	}

	public void __BB_OBFUSCATOR_28()
	{
		ObscuredPrefs.SetInt("_Value4", (int)HMFOOPGMEEE.value);
	}
}
