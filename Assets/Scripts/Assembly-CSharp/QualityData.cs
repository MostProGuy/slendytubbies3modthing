using System;

[Serializable]
public class QualityData
{
	public string QualityLevelName = string.Empty;

	public int textureQuality;

	public BMIIJBGBCIA antialiasingValues;

	public int anisotropic;

	public int vsync;
}
