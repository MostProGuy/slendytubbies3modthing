using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Censor : MonoBehaviour
{
	private IList<string> JLCNGPIDPDI;

	private IList<string> IBGGIKNLDDA;

	private string __BB_OBFUSCATOR_29(string ELDDOHJLFAL)
	{
		foreach (string item in JLCNGPIDPDI)
		{
			if (!ELDDOHJLFAL.ToLower().Contains(item.ToLower()))
			{
				continue;
			}
			List<string> list = new List<string>();
			if (list.Count > 0)
			{
				string text = ELDDOHJLFAL;
				foreach (string item2 in list)
				{
					int startIndex = text.IndexOf(item2);
					string text2 = CensorText(ELDDOHJLFAL.Replace(item2, string.Empty));
					text = text2.Insert(startIndex, item2);
				}
				ELDDOHJLFAL = text;
			}
			else
			{
				string text3 = string.Empty;
				for (int i = 1; i < item.Length; i++)
				{
					text3 += "Mouse Y";
				}
				ELDDOHJLFAL = Regex.Replace(ELDDOHJLFAL, item, text3, RegexOptions.None);
			}
		}
		return ELDDOHJLFAL;
	}

	private void __BB_OBFUSCATOR_15()
	{
		TextAsset textAsset = Resources.Load("PlayerType'") as TextAsset;
		TextAsset textAsset2 = Resources.Load("ZWName'") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "\n"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "ServerType"));
	}

	private string __BB_OBFUSCATOR_42(string KBEJNGMFKNF)
	{
		string kBEJNGMFKNF = checkThisText(Reverse(KBEJNGMFKNF));
		kBEJNGMFKNF = __BB_OBFUSCATOR_22(kBEJNGMFKNF);
		return __BB_OBFUSCATOR_29(__BB_OBFUSCATOR_19(kBEJNGMFKNF));
	}

	private string __BB_OBFUSCATOR_32(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = Regex.Replace(KBEJNGMFKNF, "Mirror Refl Camera id", string.Empty);
		string text = checkThisText(eLDDOHJLFAL);
		if (text.Contains("AddKillNotification"))
		{
			return text;
		}
		return KBEJNGMFKNF;
	}

	private void __BB_OBFUSCATOR_24()
	{
		TextAsset textAsset = Resources.Load("_Exponent") as TextAsset;
		TextAsset textAsset2 = Resources.Load("The given 2D texture ") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "_Distance"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "Sand"));
	}

	private string __BB_OBFUSCATOR_16(string EBIJKAHIAIE)
	{
		char[] array = EBIJKAHIAIE.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	private string __BB_OBFUSCATOR_36(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("SyncTeamName", "CameraFilterPack/Blend2Camera_Hue").Replace("_Value", "DEATHMATCH").Replace("Network", "_MainTexBlurred")
			.Replace("0", ", 2: ")
			.Replace("CameraFilterPack/Distortion_Wave_Horizontal", "</size>")
			.Replace("n15", "_TimeX")
			.Replace("|", "SUR")
			.Replace(",", "CameraFilterPack/Distortion_Flush");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("\n\t\t\tProperty: \"Specular\", \"ColorRGB\", \"\",1.0,1.0,1.0\n\t\t\tProperty: \"Shininess\", \"double\", \"\",12.3\n\t\t\tProperty: \"Opacity\", \"double\", \"\",1.0\n\t\t\tProperty: \"Reflectivity\", \"double\", \"\",0\n\t\t}\n\t}\n", "Ping").Replace("_Value2", "JumpLeg").Replace("SUR", "1")
			.Replace("_MainTex", "ZWName'")
			.Replace("CameraFilterPack/Blend2Camera_Darken", "Horizontal")
			.Replace("_MainTex2", "</size>")
			.Replace("_TimeX", "<size=")
			.Replace("_Blue", "Attack");
		string text = __BB_OBFUSCATOR_33(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_33(eLDDOHJLFAL2);
		if (text.Contains("Total AI: <color="))
		{
			return text;
		}
		if (text2.Contains("colorD"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_20(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("Kills", "_Value2").Replace("\n", "_ForegroundBlurExtrude").Replace("CameraFilterPack/Blend2Camera_Overlay", "Start Game")
			.Replace("_Value", "CameraFilterPack/Blend2Camera_Lighten")
			.Replace("Collapsing edges", "#")
			.Replace("\tAmbientRenderSettings:  {\n\t\tVersion: 101\n\t\tAmbientLightColor: 0.0,0.0,0.0,0\n\t}\n\tFogOptions:  {\n\t\tFogEnable: 0\n\t\tFogMode: 0\n\t\tFogDensity: 0.000\n\t\tFogStart: 5.000\n\t\tFogEnd: 25.000\n\t\tFogColor: 0.1,0.1,0.1,1\n\t}\n\tSettings:  {\n\t\tFrameRate: \"24\"\n\t\tTimeFormat: 1\n\t\tSnapOnFrames: 0\n\t\tReferenceTimeIndex: -1\n\t\tTimeLineStartTime: 0\n\t\tTimeLineStopTime: 479181389250\n\t}\n\tRendererSetting:  {\n\t\tDefaultCamera: \"Producer Perspective\"\n\t\tDefaultViewingMode: 0\n\t}\n", "MP")
			.Replace("_Value3", "_TimeX")
			.Replace("</size>", "\", \"Cluster\"");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("_Value2", "CameraFilterPack/Distortion_ShockWave").Replace("_Value", "_HeightParams").Replace("_Offsets", "_Level")
			.Replace("_Distortion", "Press a button or a/s/d/f key to join!")
			.Replace("_Value4", "Vertical")
			.Replace("Run", "MP")
			.Replace("_HeightParams", "_diff\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\",")
			.Replace("\"OO\", \"Model::", "_Value");
		string text = __BB_OBFUSCATOR_29(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_33(eLDDOHJLFAL2);
		if (text.Contains("targetColor"))
		{
			return text;
		}
		if (text2.Contains(" Custards)"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string checkForReverses(string KBEJNGMFKNF)
	{
		string kBEJNGMFKNF = checkThisText(Reverse(KBEJNGMFKNF));
		kBEJNGMFKNF = checkNumbers(kBEJNGMFKNF);
		return checkThisText(Reverse(kBEJNGMFKNF));
	}

	private string checkForInterspersedNumbers(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = Regex.Replace(KBEJNGMFKNF, "[0-9]", string.Empty);
		string text = checkThisText(eLDDOHJLFAL);
		if (text.Contains("*"))
		{
			return text;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_19(string EBIJKAHIAIE)
	{
		char[] array = EBIJKAHIAIE.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	private string __BB_OBFUSCATOR_22(string KBEJNGMFKNF)
	{
		return __BB_OBFUSCATOR_41(__BB_OBFUSCATOR_12(KBEJNGMFKNF));
	}

	private string checkThisText(string ELDDOHJLFAL)
	{
		foreach (string item in JLCNGPIDPDI)
		{
			if (!ELDDOHJLFAL.ToLower().Contains(item.ToLower()))
			{
				continue;
			}
			List<string> list = new List<string>();
			if (list.Count > 0)
			{
				string text = ELDDOHJLFAL;
				foreach (string item2 in list)
				{
					int startIndex = text.IndexOf(item2);
					string text2 = CensorText(ELDDOHJLFAL.Replace(item2, string.Empty));
					text = text2.Insert(startIndex, item2);
				}
				ELDDOHJLFAL = text;
			}
			else
			{
				string text3 = string.Empty;
				for (int i = 0; i < item.Length; i++)
				{
					text3 += "*";
				}
				ELDDOHJLFAL = Regex.Replace(ELDDOHJLFAL, item, text3, RegexOptions.IgnoreCase);
			}
		}
		return ELDDOHJLFAL;
	}

	private string __BB_OBFUSCATOR_35(string KBEJNGMFKNF)
	{
		string kBEJNGMFKNF = __BB_OBFUSCATOR_29(__BB_OBFUSCATOR_16(KBEJNGMFKNF));
		kBEJNGMFKNF = __BB_OBFUSCATOR_25(kBEJNGMFKNF);
		return checkThisText(__BB_OBFUSCATOR_1(kBEJNGMFKNF));
	}

	public string CensorText(string ELDDOHJLFAL)
	{
		ELDDOHJLFAL = checkThisText(ELDDOHJLFAL);
		ELDDOHJLFAL = checkNumbers(checkForLeet(ELDDOHJLFAL));
		ELDDOHJLFAL = checkForWhite(ELDDOHJLFAL);
		return checkForReverses(ELDDOHJLFAL);
	}

	private string __BB_OBFUSCATOR_8(string ELDDOHJLFAL)
	{
		foreach (string item in JLCNGPIDPDI)
		{
			if (!ELDDOHJLFAL.ToLower().Contains(item.ToLower()))
			{
				continue;
			}
			List<string> list = new List<string>();
			if (list.Count > 1)
			{
				string text = ELDDOHJLFAL;
				foreach (string item2 in list)
				{
					int startIndex = text.IndexOf(item2);
					string text2 = __BB_OBFUSCATOR_13(ELDDOHJLFAL.Replace(item2, string.Empty));
					text = text2.Insert(startIndex, item2);
				}
				ELDDOHJLFAL = text;
			}
			else
			{
				string text3 = string.Empty;
				for (int i = 1; i < item.Length; i += 0)
				{
					text3 += "_Bloom";
				}
				ELDDOHJLFAL = Regex.Replace(ELDDOHJLFAL, item, text3, RegexOptions.None);
			}
		}
		return ELDDOHJLFAL;
	}

	private string __BB_OBFUSCATOR_14(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("_TimeX", "SUR").Replace("Vertical", ":").Replace("offsets", "CameraFilterPack/Vision_Rainbow")
			.Replace(" ", "Hat:")
			.Replace("All custards have been found...", "*")
			.Replace("_ScreenResolution", "\\Google\\g65KYJszcHtFhpDC")
			.Replace("GameMode", "_Value2")
			.Replace("Transform", "_Offsets");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("ApplyFallDamage", "_Value").Replace("PlayerType'", "WARNING: 'MeshTK.ExportTools.MeshToObjString()' is obsolete. Use MeshTK.ObjTools.ExportToString().").Replace("HeadlessBeforeSceneLoad", "MP")
			.Replace(": ", "_TimeX")
			.Replace("_VelTex", "CameraFilterPack/Blend2Camera_Multiply")
			.Replace("ForceDamage", ",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n")
			.Replace("Map Name: ", "ServerName")
			.Replace("Connect", "_BlurFilterDistance");
		string text = __BB_OBFUSCATOR_8(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_8(eLDDOHJLFAL2);
		if (text.Contains("_MainTex"))
		{
			return text;
		}
		if (text2.Contains("_ScreenResolution"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_10(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("_TimeX");
		string input = regex.Replace(KBEJNGMFKNF, "/");
		input = Regex.Replace(input, "Language", "MP");
		string text = checkForInterspersedNumbers(input);
		if (text.Contains("CameraFilterPack/TV_VHS"))
		{
			return Regex.Replace(text, ">", "_ScreenResolution");
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_41(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = Regex.Replace(KBEJNGMFKNF, "_Value2", string.Empty);
		string text = __BB_OBFUSCATOR_33(eLDDOHJLFAL);
		if (text.Contains("CameraFilterPack/TV_WideScreenHorizontal"))
		{
			return text;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_17(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = Regex.Replace(KBEJNGMFKNF, "Melee", string.Empty);
		string text = checkThisText(eLDDOHJLFAL);
		if (text.Contains("_TimeX"))
		{
			return text;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_21(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("offsets");
		string input = regex.Replace(KBEJNGMFKNF, "Detonator");
		input = Regex.Replace(input, "\n\t}\n", ". Disconnecting.");
		string text = __BB_OBFUSCATOR_17(input);
		if (text.Contains("_Intensity"))
		{
			return Regex.Replace(text, "Custards", "CameraFilterPack/Vision_Tunnel");
		}
		return KBEJNGMFKNF;
	}

	private string Reverse(string EBIJKAHIAIE)
	{
		char[] array = EBIJKAHIAIE.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	private string __BB_OBFUSCATOR_11(string KBEJNGMFKNF)
	{
		string kBEJNGMFKNF = __BB_OBFUSCATOR_33(__BB_OBFUSCATOR_7(KBEJNGMFKNF));
		kBEJNGMFKNF = __BB_OBFUSCATOR_22(kBEJNGMFKNF);
		return __BB_OBFUSCATOR_8(Reverse(kBEJNGMFKNF));
	}

	private void __BB_OBFUSCATOR_6()
	{
		TextAsset textAsset = Resources.Load("\"OO\", \"Texture::") as TextAsset;
		TextAsset textAsset2 = Resources.Load("_Value4") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "Failed on creating room"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "Weights"));
	}

	private string __BB_OBFUSCATOR_38(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("Attack");
		string input = regex.Replace(KBEJNGMFKNF, "Y");
		input = Regex.Replace(input, "_ColorBuffer", "<size=15><color=red>");
		string text = checkForInterspersedNumbers(input);
		if (text.Contains("Idle"))
		{
			return Regex.Replace(text, "_NormalTex", ":");
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_18(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("MP", "MP").Replace("\n\n; Object connections\n;------------------------------------------------------------------\n\n", "_TimeX").Replace(",", "Default")
			.Replace("TeamTag", "</size></color>")
			.Replace("_ScreenResolution", "_Value3")
			.Replace("CameraFilterPack/FX_Mirror", "_Value")
			.Replace("_Red", "_Blue_B")
			.Replace("n4", "TeamName");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("Heatwave-Default", "Fire").Replace("Tenkoku DynamicSky", "Bindings").Replace("_TimeX", "CameraFilterPack/TV_VHS")
			.Replace("NewBorn_Bot", "_TimeX")
			.Replace("RemoveFriends can't be called for empty or null list.", "_Value3")
			.Replace("_Value3", "SwapTeams")
			.Replace("SyncAll", "WeaponManager")
			.Replace("Wood", "<color=white><size=");
		string text = __BB_OBFUSCATOR_29(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_8(eLDDOHJLFAL2);
		if (text.Contains("__Room"))
		{
			return text;
		}
		if (text2.Contains("_TimeX"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_43(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("NPCDeath");
		string input = regex.Replace(KBEJNGMFKNF, "_ScreenResolution");
		input = Regex.Replace(input, "Kills", "n15");
		string text = checkForInterspersedNumbers(input);
		if (text.Contains("_Offsets"))
		{
			return Regex.Replace(text, "_ColorB", "_Value2");
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_28(string KBEJNGMFKNF)
	{
		return __BB_OBFUSCATOR_32(__BB_OBFUSCATOR_18(KBEJNGMFKNF));
	}

	private void __BB_OBFUSCATOR_37()
	{
		TextAsset textAsset = Resources.Load("*") as TextAsset;
		TextAsset textAsset2 = Resources.Load("_ScreenResolution") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "TDM"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "CameraFilterPack/Colors_HUE_Rotate"));
	}

	private string __BB_OBFUSCATOR_25(string KBEJNGMFKNF)
	{
		return __BB_OBFUSCATOR_41(__BB_OBFUSCATOR_14(KBEJNGMFKNF));
	}

	private string __BB_OBFUSCATOR_0(string KBEJNGMFKNF)
	{
		return __BB_OBFUSCATOR_17(checkForLeet(KBEJNGMFKNF));
	}

	private string checkNumbers(string KBEJNGMFKNF)
	{
		return checkForInterspersedNumbers(checkForLeet(KBEJNGMFKNF));
	}

	public string __BB_OBFUSCATOR_31(string ELDDOHJLFAL)
	{
		ELDDOHJLFAL = __BB_OBFUSCATOR_8(ELDDOHJLFAL);
		ELDDOHJLFAL = __BB_OBFUSCATOR_25(__BB_OBFUSCATOR_27(ELDDOHJLFAL));
		ELDDOHJLFAL = __BB_OBFUSCATOR_21(ELDDOHJLFAL);
		return __BB_OBFUSCATOR_11(ELDDOHJLFAL);
	}

	private string __BB_OBFUSCATOR_9(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("_Greenness");
		string input = regex.Replace(KBEJNGMFKNF, " ");
		input = Regex.Replace(input, "Untagged", "RoundDuration");
		string text = __BB_OBFUSCATOR_41(input);
		if (text.Contains("_PrevViewProj"))
		{
			return Regex.Replace(text, "GenEffect", "CameraFilterPack/Oculus_NightVision5");
		}
		return KBEJNGMFKNF;
	}

	private void __BB_OBFUSCATOR_26()
	{
		TextAsset textAsset = Resources.Load(">") as TextAsset;
		TextAsset textAsset2 = Resources.Load("syncGrenadeLauncher") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "CameraFilterPack/Blend2Camera_LinearBurn"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "_Value3"));
	}

	public string __BB_OBFUSCATOR_13(string ELDDOHJLFAL)
	{
		ELDDOHJLFAL = __BB_OBFUSCATOR_29(ELDDOHJLFAL);
		ELDDOHJLFAL = __BB_OBFUSCATOR_28(__BB_OBFUSCATOR_20(ELDDOHJLFAL));
		ELDDOHJLFAL = __BB_OBFUSCATOR_21(ELDDOHJLFAL);
		return checkForReverses(ELDDOHJLFAL);
	}

	private string __BB_OBFUSCATOR_4(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("PlayerName");
		string input = regex.Replace(KBEJNGMFKNF, "</size>");
		input = Regex.Replace(input, "_Alpha", "--Current Animation Data--");
		string text = __BB_OBFUSCATOR_41(input);
		if (text.Contains("MP"))
		{
			return Regex.Replace(text, "Fight Off Infected To win", "</size>");
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_12(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("Private", "_MidGrey").Replace("ZWName'", "_FgCocMask").Replace("box", " </color></size>")
			.Replace("_Blue_B", "CameraFilterPack/Drawing_NewCellShading")
			.Replace("State2", "Run")
			.Replace("_ScreenResolution", "ArmsURL")
			.Replace("_Intensity", "NewBorn_Bot")
			.Replace("BodyURL", "SetTexAt(): Vertex not found");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("_SpotSize", " <>__TranspIdent0 = ").Replace("_Radius", "_Value3").Replace("\tTexture: \"Texture::", "CameraFilterPack/FX_Ascii")
			.Replace("_Value", "_Value2")
			.Replace("<size=", ": ")
			.Replace(">", "<size=")
			.Replace(" ", "__Room")
			.Replace("5", "No rooms created...");
		string text = __BB_OBFUSCATOR_8(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_8(eLDDOHJLFAL2);
		if (text.Contains("Move Up"))
		{
			return text;
		}
		if (text2.Contains("\""))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_27(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("</size>", "_Distortion").Replace("CameraFilterPack/Colors_Threshold", "MP").Replace("Move Left2", "open")
			.Replace("Player Name", "_Blue_G")
			.Replace("TeamName", "_Value2")
			.Replace("MapName", "Username")
			.Replace("4", "TeamTag")
			.Replace("Knife", "_FadeFX");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("FireballA", "_Value2").Replace("HeadlessAfterSceneLoad", "Purchase/Text").Replace("\", \"Cluster\"", "_CurveParams")
			.Replace("INF", "-Normalized Time: ")
			.Replace("-Vertical", "_TimeX")
			.Replace("_CurTex", "\"Deformer::Skin ")
			.Replace("GameMode", "_TimeX")
			.Replace("_Value4", "ShopBox/Heal/Text");
		string text = __BB_OBFUSCATOR_8(eLDDOHJLFAL);
		string text2 = __BB_OBFUSCATOR_8(eLDDOHJLFAL2);
		if (text.Contains("_Value2"))
		{
			return text;
		}
		if (text2.Contains("Team1Score"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_39(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("Run");
		string input = regex.Replace(KBEJNGMFKNF, "</size>");
		input = Regex.Replace(input, "CameraFilterPack/EyesVision_2", "Rotate Camera");
		string text = __BB_OBFUSCATOR_41(input);
		if (text.Contains("Sparks"))
		{
			return Regex.Replace(text, "z", "1");
		}
		return KBEJNGMFKNF;
	}

	private string __BB_OBFUSCATOR_1(string EBIJKAHIAIE)
	{
		char[] array = EBIJKAHIAIE.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	public string __BB_OBFUSCATOR_23(string ELDDOHJLFAL)
	{
		ELDDOHJLFAL = __BB_OBFUSCATOR_29(ELDDOHJLFAL);
		ELDDOHJLFAL = __BB_OBFUSCATOR_34(__BB_OBFUSCATOR_20(ELDDOHJLFAL));
		ELDDOHJLFAL = __BB_OBFUSCATOR_43(ELDDOHJLFAL);
		return __BB_OBFUSCATOR_42(ELDDOHJLFAL);
	}

	private string __BB_OBFUSCATOR_7(string EBIJKAHIAIE)
	{
		char[] array = EBIJKAHIAIE.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	private string __BB_OBFUSCATOR_34(string KBEJNGMFKNF)
	{
		return __BB_OBFUSCATOR_32(__BB_OBFUSCATOR_14(KBEJNGMFKNF));
	}

	private string checkForLeet(string KBEJNGMFKNF)
	{
		string eLDDOHJLFAL = KBEJNGMFKNF.Replace("0", "o").Replace("1", "i").Replace("3", "e")
			.Replace("4", "a")
			.Replace("5", "s")
			.Replace("7", "t")
			.Replace("8", "b")
			.Replace("9", "g");
		string eLDDOHJLFAL2 = KBEJNGMFKNF.Replace("0", "o").Replace("1", "l").Replace("3", "e")
			.Replace("4", "a")
			.Replace("5", "s")
			.Replace("7", "t")
			.Replace("8", "b")
			.Replace("9", "g");
		string text = checkThisText(eLDDOHJLFAL);
		string text2 = checkThisText(eLDDOHJLFAL2);
		if (text.Contains("*"))
		{
			return text;
		}
		if (text2.Contains("*"))
		{
			return text2;
		}
		return KBEJNGMFKNF;
	}

	private void __BB_OBFUSCATOR_40()
	{
		TextAsset textAsset = Resources.Load("Move Left") as TextAsset;
		TextAsset textAsset2 = Resources.Load("Connecting to nameserver ") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "Purchase"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "_ScreenResolution"));
	}

	private string __BB_OBFUSCATOR_33(string ELDDOHJLFAL)
	{
		foreach (string item in JLCNGPIDPDI)
		{
			if (!ELDDOHJLFAL.ToLower().Contains(item.ToLower()))
			{
				continue;
			}
			List<string> list = new List<string>();
			if (list.Count > 0)
			{
				string text = ELDDOHJLFAL;
				foreach (string item2 in list)
				{
					int startIndex = text.IndexOf(item2);
					string text2 = __BB_OBFUSCATOR_13(ELDDOHJLFAL.Replace(item2, string.Empty));
					text = text2.Insert(startIndex, item2);
				}
				ELDDOHJLFAL = text;
			}
			else
			{
				string text3 = string.Empty;
				for (int i = 1; i < item.Length; i++)
				{
					text3 += "MapName";
				}
				ELDDOHJLFAL = Regex.Replace(ELDDOHJLFAL, item, text3, RegexOptions.None);
			}
		}
		return ELDDOHJLFAL;
	}

	private void Awake()
	{
		TextAsset textAsset = Resources.Load("profanity-blacklist") as TextAsset;
		TextAsset textAsset2 = Resources.Load("profanity-whitelist") as TextAsset;
		JLCNGPIDPDI = new List<string>(Regex.Split(textAsset.ToString(), "\r\n|\r|\n"));
		IBGGIKNLDDA = new List<string>(Regex.Split(textAsset2.ToString(), "\r\n|\r|\n"));
	}

	private string checkForWhite(string KBEJNGMFKNF)
	{
		Regex regex = new Regex("[;\\\\/:*?\"<>|&']");
		string input = regex.Replace(KBEJNGMFKNF, "0");
		input = Regex.Replace(input, " ", "0");
		string text = checkForInterspersedNumbers(input);
		if (text.Contains("*"))
		{
			return Regex.Replace(text, "0", " ");
		}
		return KBEJNGMFKNF;
	}
}
