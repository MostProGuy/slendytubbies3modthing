using UnityEngine;

public class AnimationControlDemo : MonoBehaviour
{
	private MecanimControl CDAKMJGDMCF;

	private bool AKFNFJDKDCL;

	private float GGKECKLMEPF = 1f;

	private float OLNGGJMDNNN = 0.1f;

	private float IGCIEIKFFJI = 90f;

	private void __BB_OBFUSCATOR_37()
	{
		GUILayout.Label("VS" + GGKECKLMEPF + "PlayerName");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 759f, 1709f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label(">" + IGCIEIKFFJI + "_BlurRadius4");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1466f, 635f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1786f, IGCIEIKFFJI, 790f);
		GUILayout.Label(">" + OLNGGJMDNNN + "_DepthFade", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 509f, 28f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(935f);
		if (GUILayout.Button("Team A" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_AOTex" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(239f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 0; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		GUILayout.Label("_Value" + GGKECKLMEPF + "_Value", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 998f, 1673f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("/" + IGCIEIKFFJI + "ChatField", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1231f, 410f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(801f, IGCIEIKFFJI, 1935f);
		GUILayout.Label("{0}:{1}" + OLNGGJMDNNN + "9", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 955f, 928f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1446f);
		if (GUILayout.Button("Save" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_TimeX" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1210f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_55()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_5()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_40()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_34()
	{
		GUILayout.Label("_CurveParams" + GGKECKLMEPF + "_Value3");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 118f, 1028f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_ScreenResolution" + IGCIEIKFFJI + ",", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1911f, 1237f);
		base.transform.localEulerAngles = new Vector3(1975f, IGCIEIKFFJI, 542f);
		GUILayout.Label("_TimeX" + OLNGGJMDNNN + "_EdgeSize", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 199f, 860f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(552f);
		if (GUILayout.Button("_RampOffset" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_ScreenResolution" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1825f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_53()
	{
		GUILayout.Label("CameraFilterPack/Vision_Warp" + GGKECKLMEPF + "Room Name ", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1283f, 1880f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Val" + IGCIEIKFFJI + "Player");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 342f, 1198f);
		base.transform.localEulerAngles = new Vector3(1968f, IGCIEIKFFJI, 778f);
		GUILayout.Label("CameraFilterPack/Blizzard" + OLNGGJMDNNN + "CameraFilterPack/Blend2Camera_Color");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 271f, 1052f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(746f);
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_Darken" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("TRACKING" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1586f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUILayout.Label("Picked | " + GGKECKLMEPF + "MapName");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1741f, 162f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("red" + IGCIEIKFFJI + "\"SubDeformer::Cluster ", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 289f, 817f);
		base.transform.localEulerAngles = new Vector3(746f, IGCIEIKFFJI, 1711f);
		GUILayout.Label("offsets" + OLNGGJMDNNN + "</size>");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 541f, 1996f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1850f);
		if (GUILayout.Button("MP" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("Network" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(33f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void Start()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_26()
	{
		GUILayout.Label("☐" + GGKECKLMEPF + "Paused", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1013f, 822f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Value2" + IGCIEIKFFJI + "Difficulty", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 632f, 170f);
		base.transform.localEulerAngles = new Vector3(992f, IGCIEIKFFJI, 209f);
		GUILayout.Label("_ScreenResolution" + OLNGGJMDNNN + "_SpherePositionY", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1540f, 483f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1568f);
		if (GUILayout.Button("Vertical" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("CameraFilterPack/Vision_Tunnel" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1849f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		GUILayout.Label("6" + GGKECKLMEPF + "<color=");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 372f, 419f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("ArmsURL" + IGCIEIKFFJI + "Idle");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 237f, 1194f);
		base.transform.localEulerAngles = new Vector3(1161f, IGCIEIKFFJI, 688f);
		GUILayout.Label("_Value4" + OLNGGJMDNNN + "Kills");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1082f, 802f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(229f);
		if (GUILayout.Button(",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("Ping" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1953f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		GUILayout.Label("Left" + GGKECKLMEPF + "-Vertical", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1385f, 208f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("☠☠☠ (Impossible)" + IGCIEIKFFJI + "CameraFilterPack/FX_Glitch2");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 311f, 1060f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(864f, IGCIEIKFFJI, 195f);
		GUILayout.Label("Text" + OLNGGJMDNNN + "team2", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 427f, 254f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1563f);
		if (GUILayout.Button("_Value" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("__MirrorReflection" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(712f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		GUILayout.Label("RefTime" + GGKECKLMEPF + "|", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1053f, 322f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("Crouch" + IGCIEIKFFJI + "Shop", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1610f, 602f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1786f, IGCIEIKFFJI, 1166f);
		GUILayout.Label("CameraFilterPack/Blend2Camera_LighterColor" + OLNGGJMDNNN + "Resolution", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1145f, 1081f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1860f);
		if (GUILayout.Button("_TimeX" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("," + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(442f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		GUILayout.Label("_Value2" + GGKECKLMEPF + "_TimeX", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1250f, 1914f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_VelocityScale" + IGCIEIKFFJI + "_HrDepthTex", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 454f, 231f);
		base.transform.localEulerAngles = new Vector3(742f, IGCIEIKFFJI, 558f);
		GUILayout.Label("_Value2" + OLNGGJMDNNN + "_Offsets", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 148f, 1471f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(665f);
		if (GUILayout.Button("_TapMedium" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_Blend" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1334f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GUILayout.Label("TeamASpawn" + GGKECKLMEPF + "_Refraction", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 643f, 1500f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Offsets" + IGCIEIKFFJI + "COOP");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1487f, 1832f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(967f, IGCIEIKFFJI, 1545f);
		GUILayout.Label("_Texture" + OLNGGJMDNNN + "_NoiseAmount", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1158f, 1048f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(180f);
		if (GUILayout.Button("\\xAu4YW5QzfD2KQjV" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_TimeX" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(67f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		GUILayout.Label("Quality" + GGKECKLMEPF + "_ScreenResolution", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1337f, 876f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_ScreenResolution" + IGCIEIKFFJI + "_ScreenResolution", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1531f, 1349f);
		base.transform.localEulerAngles = new Vector3(1355f, IGCIEIKFFJI, 33f);
		GUILayout.Label("_ScreenResolution" + OLNGGJMDNNN + "_ScreenResolution", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1388f, 1173f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1445f);
		if (GUILayout.Button("All players have been killed..." + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_MinVelocity" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(926f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 0; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		GUILayout.Label("Menu" + GGKECKLMEPF + "MP", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 825f, 1783f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("FlyCam" + IGCIEIKFFJI + "_Value", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1139f, 1037f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1602f, IGCIEIKFFJI, 221f);
		GUILayout.Label("PlayerName" + OLNGGJMDNNN + "HeadlessBehaviour", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1075f, 1633f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(976f);
		if (GUILayout.Button("Tenkoku DynamicSky" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("\"Model\"" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(406f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_41()
	{
		GUILayout.Label("_TimeX" + GGKECKLMEPF + "_Value4");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1096f, 1999f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("\"Material\"" + IGCIEIKFFJI + "TeamName");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 221f, 1314f);
		base.transform.localEulerAngles = new Vector3(260f, IGCIEIKFFJI, 1009f);
		GUILayout.Label("DoDamage" + OLNGGJMDNNN + "_Relief", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 136f, 1681f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(640f);
		if (GUILayout.Button("offsets" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_Distortion" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1842f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_12()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_42()
	{
		GUILayout.Label("_TimeX" + GGKECKLMEPF + "-Vertical", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 865f, 938f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("team2" + IGCIEIKFFJI + "_Intensity", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 72f, 1302f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1712f, IGCIEIKFFJI, 1598f);
		GUILayout.Label("_MaxRadiusOrKInPaper" + OLNGGJMDNNN + "died", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1775f, 1549f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1193f);
		if (GUILayout.Button("Password" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("SBX" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1297f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_24()
	{
		GUILayout.Label("Simplifying mesh: " + GGKECKLMEPF + "GameMode", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 498f, 291f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Red_C" + IGCIEIKFFJI + "CameraFilterPack/EyesVision_2");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1146f, 401f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1000f, IGCIEIKFFJI, 792f);
		GUILayout.Label("_BlurSize" + OLNGGJMDNNN + "Network", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1928f, 1650f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(79f);
		if (GUILayout.Button("clear" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("," + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1648f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		GUILayout.Label("Player" + GGKECKLMEPF + "Camera", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1884f, 1533f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("PlayerFellDown" + IGCIEIKFFJI + "Y", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 672f, 1209f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(741f, IGCIEIKFFJI, 710f);
		GUILayout.Label("0" + OLNGGJMDNNN + "CameraFilterPack/TV_Old_Movie_2", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 463f, 1227f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(706f);
		if (GUILayout.Button("Network" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_StretchWidth" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1399f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		GUILayout.Label("CameraFilterPack/Colors_Threshold" + GGKECKLMEPF + "_Green_B");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 886f, 584f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("Team1Score" + IGCIEIKFFJI + "MP", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1381f, 1741f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(244f, IGCIEIKFFJI, 127f);
		GUILayout.Label("CameraFilterPack/Vision_Crystal" + OLNGGJMDNNN + "Team2Score", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1620f, 156f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(719f);
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_Overlay" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_EdgeSize" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1966f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_52()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_21()
	{
		GUILayout.Label("team1" + GGKECKLMEPF + "_Value2", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1001f, 853f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_PositionY" + IGCIEIKFFJI + "Walking");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 373f, 1913f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(354f, IGCIEIKFFJI, 159f);
		GUILayout.Label("_MainTex2" + OLNGGJMDNNN + "_Value", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 698f, 74f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(316f);
		if (GUILayout.Button("http://zeoworks.com/home/getlogin.php" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_CenterY" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1595f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		GUILayout.Label("NormRain" + GGKECKLMEPF + "_Offsets");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1204f, 818f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("Player " + IGCIEIKFFJI + "TeamName");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 986f, 919f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(817f, IGCIEIKFFJI, 1926f);
		GUILayout.Label("engine" + OLNGGJMDNNN + "EnableHelper");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1139f, 1638f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(366f);
		if (GUILayout.Button("_BorderColor" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("Attack" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(579f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		GUILayout.Label("Target already added: " + GGKECKLMEPF + "Try Again");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 312f, 869f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("Kills" + IGCIEIKFFJI + "Language");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 982f, 846f);
		base.transform.localEulerAngles = new Vector3(1353f, IGCIEIKFFJI, 1421f);
		GUILayout.Label("_Value" + OLNGGJMDNNN + "Open", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 865f, 1254f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(318f);
		if (GUILayout.Button("HeatDistort" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("\", \"SubDeformer::Cluster " + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(942f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		GUILayout.Label("_Value" + GGKECKLMEPF + ">Difficulty: ");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 171f, 146f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("SupplyHelicopter" + IGCIEIKFFJI + "_SunColor");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 907f, 949f);
		base.transform.localEulerAngles = new Vector3(1918f, IGCIEIKFFJI, 999f);
		GUILayout.Label("Run" + OLNGGJMDNNN + "Custards", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1337f, 797f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1886f);
		if (GUILayout.Button("Extinguish" + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("CameraFilterPack/TV_Tiles" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(650f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 0; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		GUILayout.Label("Player" + GGKECKLMEPF + "Recommended Players");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 109f, 464f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Value" + IGCIEIKFFJI + "<size=");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 712f, 1417f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(671f, IGCIEIKFFJI, 316f);
		GUILayout.Label("CustomSkin" + OLNGGJMDNNN + "_ScreenResolution");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 499f, 1969f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1999f);
		if (GUILayout.Button("Spectators" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("Updater" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1599f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_15(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_9()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_49()
	{
		GUILayout.Label("Language" + GGKECKLMEPF + "MP", new GUILayoutOption[1]);
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1756f, 1637f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("EnableHelper" + IGCIEIKFFJI + "_Value", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 119f, 1428f);
		base.transform.localEulerAngles = new Vector3(1381f, IGCIEIKFFJI, 888f);
		GUILayout.Label("Vertical" + OLNGGJMDNNN + "_TimeX", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 590f, 1250f, new GUILayoutOption[1]);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(92f);
		if (GUILayout.Button("_Value4" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("_Value4" + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1996f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_44()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_35()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void __BB_OBFUSCATOR_48()
	{
		GUILayout.Label("_MainTex2" + GGKECKLMEPF + "_TimeX");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1895f, 1495f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("_Value" + IGCIEIKFFJI + "ForceDamage", new GUILayoutOption[1]);
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 1638f, 712f);
		base.transform.localEulerAngles = new Vector3(566f, IGCIEIKFFJI, 1047f);
		GUILayout.Label("Picked | " + OLNGGJMDNNN + "Noise & Grain effect failing as noise texture is not assigned. please assign.", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1639f, 1235f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(975f);
		if (GUILayout.Button("_ScreenResolution" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("GameMode" + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(1742f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 0; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		CDAKMJGDMCF = base.gameObject.GetComponent<MecanimControl>();
	}

	private void OnGUI()
	{
		GUILayout.Label("Speed (" + GGKECKLMEPF + ")");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 0f, 10f);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("Rotation (" + IGCIEIKFFJI + ")");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 0f, 360f);
		base.transform.localEulerAngles = new Vector3(0f, IGCIEIKFFJI, 0f);
		GUILayout.Label("Blending (" + OLNGGJMDNNN + ")");
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 0f, 1f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(10f);
		if (GUILayout.Button("Mirror " + AKFNFJDKDCL))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("Debug " + CDAKMJGDMCF.JIEKFKMKCME))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(10f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (GUILayout.Button(animationData.clipName))
			{
				CDAKMJGDMCF.Play(animationData, AKFNFJDKDCL);
			}
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		GUILayout.Label("MapName" + GGKECKLMEPF + "_TimeX");
		GGKECKLMEPF = GUILayout.HorizontalSlider(GGKECKLMEPF, 1208f, 994f, new GUILayoutOption[1]);
		CDAKMJGDMCF.SetSpeed(GGKECKLMEPF);
		GUILayout.Label("ServerName" + IGCIEIKFFJI + "_TimeX");
		IGCIEIKFFJI = GUILayout.HorizontalSlider(IGCIEIKFFJI, 816f, 1501f, new GUILayoutOption[1]);
		base.transform.localEulerAngles = new Vector3(1904f, IGCIEIKFFJI, 667f);
		GUILayout.Label("_Value4" + OLNGGJMDNNN + "Vertical", new GUILayoutOption[1]);
		OLNGGJMDNNN = GUILayout.HorizontalSlider(OLNGGJMDNNN, 1065f, 1779f);
		CDAKMJGDMCF.JKIOMKPPDBF = OLNGGJMDNNN;
		GUILayout.Space(1208f);
		if (GUILayout.Button("_Distortion" + AKFNFJDKDCL, new GUILayoutOption[1]))
		{
			AKFNFJDKDCL = !AKFNFJDKDCL;
			CDAKMJGDMCF.SetMirror(AKFNFJDKDCL);
		}
		if (GUILayout.Button("WARNING: 'MeshTK.ExportTools.MeshToFile()' is obsolete. Use MeshTK.ObjTools.ExportToFile()." + CDAKMJGDMCF.JIEKFKMKCME, new GUILayoutOption[1]))
		{
			CDAKMJGDMCF.JIEKFKMKCME = !CDAKMJGDMCF.JIEKFKMKCME;
		}
		GUILayout.Space(425f);
		AnimationData[] bPPMKPKDLOA = CDAKMJGDMCF.BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i++)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (GUILayout.Button(animationData.clipName, new GUILayoutOption[1]))
			{
				CDAKMJGDMCF.__BB_OBFUSCATOR_21(animationData, AKFNFJDKDCL);
			}
		}
	}
}
