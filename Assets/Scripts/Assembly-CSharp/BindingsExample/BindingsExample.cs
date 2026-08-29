using InControl;
using UnityEngine;

namespace BindingsExample
{
	public class BindingsExample : MonoBehaviour
	{
		private Renderer FFFJIMGCFDI;

		private MFFDBGEKLCH EJDJGEAHOBF;

		private string IKFJFIIAMBF;

		private void __BB_OBFUSCATOR_42()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_65()
		{
			if (PlayerPrefs.HasKey("CameraFilterPack/Distortion_Flush"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("CameraFilterPack/EyesVision_2");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_29()
		{
			base.transform.Rotate(Vector3.down, 766f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.Self);
			base.transform.Rotate(Vector3.right, 784f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.Self);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 1286f);
		}

		private void __BB_OBFUSCATOR_21()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_69()
		{
			base.transform.Rotate(Vector3.down, 1136f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.Self);
			base.transform.Rotate(Vector3.right, 469f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.World);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 1047f);
		}

		private void __BB_OBFUSCATOR_33()
		{
			if (PlayerPrefs.HasKey("CameraFilterPack/Distortion_Flush"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("_SpherePositionX");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_19()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_16()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void LoadBindings()
		{
			if (PlayerPrefs.HasKey("Bindings"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("Bindings");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_9()
		{
			if (PlayerPrefs.HasKey("ForceDamage"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("_AdaptionSpeed");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_55()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_45()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_36()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_50();
			__BB_OBFUSCATOR_34();
		}

		private void __BB_OBFUSCATOR_78()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("_TimeX", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_17()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_103();
			__BB_OBFUSCATOR_22();
		}

		private void __BB_OBFUSCATOR_60()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_10()
		{
			if (PlayerPrefs.HasKey(" should be overwritten."))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString(",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_20()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_50();
			__BB_OBFUSCATOR_65();
		}

		private void __BB_OBFUSCATOR_54()
		{
			float num = 1226f;
			GUI.Label(new Rect(1488f, num, 1730f, num + 1673f), "_NoiseTex" + EJDJGEAHOBF.LastInputType);
			num += 2f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 0; i < count; i++)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "Version5";
				}
				text = text + "RMB - aim" + playerAction.Value;
				GUI.Label(new Rect(141f, num, 1512f, num + 1513f), text);
				num += 175f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 1; j < count2; j++)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(1292f, num, 711f, num + 1750f), bindingSource.DeviceName + "_DotSize" + bindingSource.Name);
					if (GUI.Button(new Rect(87f, num + 122f, 1469f, 1884f), "Quality"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(923f, num + 21f, 1722f, 842f), "_Value"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 1952f;
				}
				if (GUI.Button(new Rect(1207f, num + 1517f, 5f, 1342f), "DM"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(519f, num + 871f, 334f, 421f), "ObjectType"))
				{
					playerAction.ResetBindings();
				}
				num += 1646f;
			}
			if (GUI.Button(new Rect(391f, num + 622f, 843f, 472f), "_Value2"))
			{
				LoadBindings();
			}
			if (GUI.Button(new Rect(870f, num + 427f, 480f, 1434f), "_Offsets"))
			{
				__BB_OBFUSCATOR_47();
			}
			if (GUI.Button(new Rect(649f, num + 1722f, 757f, 1708f), "Vertical"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_41()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_62()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_52();
			LoadBindings();
		}

		private void __BB_OBFUSCATOR_79()
		{
			float num = 1908f;
			GUI.Label(new Rect(801f, num, 665f, num + 746f), ">" + EJDJGEAHOBF.LastInputType);
			num += 1577f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 1; i < count; i += 0)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "selectWeapon";
				}
				text = text + "Last Input Type: " + playerAction.Value;
				GUI.Label(new Rect(1157f, num, 554f, num + 563f), text);
				num += 1718f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j += 0)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(1052f, num, 1794f, num + 116f), bindingSource.DeviceName + ": " + bindingSource.Name);
					if (GUI.Button(new Rect(635f, num + 712f, 131f, 634f), "0"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(873f, num + 1156f, 625f, 25f), "_Distortion"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 701f;
				}
				if (GUI.Button(new Rect(1086f, num + 257f, 1728f, 1428f), "_Distance"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(1495f, num + 1243f, 154f, 86f), "MP"))
				{
					playerAction.ResetBindings();
				}
				num += 203f;
			}
			if (GUI.Button(new Rect(715f, num + 316f, 900f, 1827f), ",0\n\t\t\tProperty: \"Rotation\", \"Vector\", \"A+\",0,0,0\n\t\t\tProperty: \"Scaling\", \"Vector\", \"A+\","))
			{
				LoadBindings();
			}
			if (GUI.Button(new Rect(1163f, num + 1742f, 62f, 802f), "INF"))
			{
				__BB_OBFUSCATOR_78();
			}
			if (GUI.Button(new Rect(1853f, num + 490f, 828f, 1651f), ": "))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_11()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_63()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_117();
			__BB_OBFUSCATOR_10();
		}

		private void __BB_OBFUSCATOR_73()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("Attack", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_66()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_10();
			__BB_OBFUSCATOR_31();
		}

		private void __BB_OBFUSCATOR_34()
		{
			if (PlayerPrefs.HasKey("_Value"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("_VelocityScale");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_64()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void SaveBindings()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("Bindings", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_50()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("100", IKFJFIIAMBF);
		}

		private void OnEnable()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.CreateWithDefaultBindings();
			LoadBindings();
		}

		private void __BB_OBFUSCATOR_30()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("\n\t\t\tProperty: \"Specular\", \"ColorRGB\", \"\",1.0,1.0,1.0\n\t\t\tProperty: \"Shininess\", \"double\", \"\",12.3\n\t\t\tProperty: \"Opacity\", \"double\", \"\",1.0\n\t\t\tProperty: \"Reflectivity\", \"double\", \"\",0\n\t\t}\n\t}\n", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_32()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_0()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_25()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_65();
			__BB_OBFUSCATOR_51();
		}

		private void __BB_OBFUSCATOR_31()
		{
			if (PlayerPrefs.HasKey("<size="))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("Concrete");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_80()
		{
			if (PlayerPrefs.HasKey("_Value"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("CameraFilterPack_TV_BrokenGlass_2");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void OnDisable()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_52()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_70()
		{
			float num = 66f;
			GUI.Label(new Rect(1754f, num, 339f, num + 493f), "monster" + EJDJGEAHOBF.LastInputType);
			num += 367f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 0; i < count; i++)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "_Radius";
				}
				text = text + "_Blue_C" + playerAction.Value;
				GUI.Label(new Rect(1364f, num, 194f, num + 942f), text);
				num += 1288f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j += 0)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(1144f, num, 1940f, num + 844f), bindingSource.DeviceName + "PlayerLeftRoom" + bindingSource.Name);
					if (GUI.Button(new Rect(681f, num + 1696f, 1414f, 851f), "team1"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(509f, num + 1751f, 1291f, 298f), "_Red_R"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 1214f;
				}
				if (GUI.Button(new Rect(1988f, num + 1050f, 428f, 1267f), ">"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(1539f, num + 1897f, 1992f, 919f), "_CenterX"))
				{
					playerAction.ResetBindings();
				}
				num += 1650f;
			}
			if (GUI.Button(new Rect(1544f, num + 902f, 290f, 400f), ","))
			{
				__BB_OBFUSCATOR_9();
			}
			if (GUI.Button(new Rect(486f, num + 1859f, 888f, 1247f), ";\n"))
			{
				__BB_OBFUSCATOR_28();
			}
			if (GUI.Button(new Rect(573f, num + 1920f, 1907f, 1016f), "Flicker"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void OnApplicationQuit()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_77()
		{
			float num = 334f;
			GUI.Label(new Rect(1809f, num, 1087f, num + 1841f), "TDM" + EJDJGEAHOBF.LastInputType);
			num += 1890f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 1; i < count; i += 0)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "</size>";
				}
				text = text + "MP" + playerAction.Value;
				GUI.Label(new Rect(1224f, num, 184f, num + 953f), text);
				num += 25f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j += 0)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(1910f, num, 1083f, num + 781f), bindingSource.DeviceName + "All players have been killed..." + bindingSource.Name);
					if (GUI.Button(new Rect(44f, num + 1505f, 1552f, 788f), "ERROR"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(826f, num + 1858f, 1277f, 1169f), "_MotionBlurTmpCam"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 474f;
				}
				if (GUI.Button(new Rect(1646f, num + 1840f, 726f, 861f), "HeadlessBeforeSceneLoad"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(1249f, num + 638f, 141f, 406f), "Total AI: <color="))
				{
					playerAction.ResetBindings();
				}
				num += 1045f;
			}
			if (GUI.Button(new Rect(1118f, num + 237f, 510f, 14f), "\n"))
			{
				__BB_OBFUSCATOR_33();
			}
			if (GUI.Button(new Rect(1026f, num + 632f, 1551f, 482f), "Vertical"))
			{
				__BB_OBFUSCATOR_78();
			}
			if (GUI.Button(new Rect(762f, num + 64f, 228f, 494f), "Toast"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_49()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_40()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_15()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_62();
			__BB_OBFUSCATOR_65();
		}

		private void __BB_OBFUSCATOR_82()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("TeamBSpawn", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_22()
		{
			if (PlayerPrefs.HasKey("_Value"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("b");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_47()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("\", \"Model::Scene\"", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_4()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_46()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("ArmsURL", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_18()
		{
			float num = 1581f;
			GUI.Label(new Rect(1851f, num, 175f, num + 1911f), "DEATHMATCH" + EJDJGEAHOBF.LastInputType);
			num += 1707f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 1; i < count; i += 0)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "DM";
				}
				text = text + "," + playerAction.Value;
				GUI.Label(new Rect(830f, num, 988f, num + 1149f), text);
				num += 913f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j += 0)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(478f, num, 70f, num + 840f), bindingSource.DeviceName + "Sparks-Default" + bindingSource.Name);
					if (GUI.Button(new Rect(1709f, num + 1118f, 1699f, 1058f), "Kills"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(1354f, num + 19f, 1083f, 590f), "Extinguish"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 1416f;
				}
				if (GUI.Button(new Rect(110f, num + 135f, 1166f, 1873f), " min"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(1090f, num + 66f, 190f, 1654f), "Toast"))
				{
					playerAction.ResetBindings();
				}
				num += 494f;
			}
			if (GUI.Button(new Rect(1382f, num + 421f, 1640f, 979f), "Idle"))
			{
				__BB_OBFUSCATOR_65();
			}
			if (GUI.Button(new Rect(1227f, num + 1512f, 1597f, 1137f), "ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass"))
			{
				__BB_OBFUSCATOR_73();
			}
			if (GUI.Button(new Rect(922f, num + 1390f, 1736f, 1446f), "CameraFilterPack/TV_BrokenGlass2"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_51()
		{
			if (PlayerPrefs.HasKey("F - weapon pick up"))
			{
				IKFJFIIAMBF = PlayerPrefs.GetString("FurColor");
				EJDJGEAHOBF.Load(IKFJFIIAMBF);
			}
		}

		private void __BB_OBFUSCATOR_86()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_75()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_5()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_27()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_28()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("_ScreenResolution", IKFJFIIAMBF);
		}

		private void Update()
		{
			base.transform.Rotate(Vector3.down, 500f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.World);
			base.transform.Rotate(Vector3.right, 500f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.World);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 0.5f);
		}

		private void __BB_OBFUSCATOR_39()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString(">", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_61()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("Idle", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_14()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_68()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_103();
			__BB_OBFUSCATOR_31();
		}

		private void __BB_OBFUSCATOR_23()
		{
			base.transform.Rotate(Vector3.down, 1540f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.Self);
			base.transform.Rotate(Vector3.right, 38f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.Self);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 582f);
		}

		private void __BB_OBFUSCATOR_12()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_58()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_119();
			__BB_OBFUSCATOR_65();
		}

		private void __BB_OBFUSCATOR_72()
		{
			base.transform.Rotate(Vector3.down, 1610f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.World);
			base.transform.Rotate(Vector3.right, 1546f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.Self);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 1787f);
		}

		private void __BB_OBFUSCATOR_84()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_35()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void Start()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_76()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_117();
			__BB_OBFUSCATOR_65();
		}

		private void __BB_OBFUSCATOR_83()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_67()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_37()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_103();
			__BB_OBFUSCATOR_31();
		}

		private void OnGUI()
		{
			float num = 10f;
			GUI.Label(new Rect(10f, num, 300f, num + 22f), "Last Input Type: " + EJDJGEAHOBF.LastInputType);
			num += 22f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 0; i < count; i++)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += " (Listening)";
				}
				text = text + " = " + playerAction.Value;
				GUI.Label(new Rect(10f, num, 500f, num + 22f), text);
				num += 22f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j++)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(75f, num, 300f, num + 22f), bindingSource.DeviceName + ": " + bindingSource.Name);
					if (GUI.Button(new Rect(20f, num + 3f, 20f, 17f), "-"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(45f, num + 3f, 20f, 17f), "+"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 22f;
				}
				if (GUI.Button(new Rect(20f, num + 3f, 20f, 17f), "+"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(50f, num + 3f, 50f, 17f), "Reset"))
				{
					playerAction.ResetBindings();
				}
				num += 25f;
			}
			if (GUI.Button(new Rect(20f, num + 3f, 50f, 22f), "Load"))
			{
				LoadBindings();
			}
			if (GUI.Button(new Rect(80f, num + 3f, 50f, 22f), "Save"))
			{
				SaveBindings();
			}
			if (GUI.Button(new Rect(140f, num + 3f, 50f, 22f), "Reset"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_13()
		{
			base.transform.Rotate(Vector3.down, 1448f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.Self);
			base.transform.Rotate(Vector3.right, 336f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.World);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 1767f);
		}

		private void __BB_OBFUSCATOR_6()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_10();
			__BB_OBFUSCATOR_33();
		}

		private void __BB_OBFUSCATOR_3()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_35();
			__BB_OBFUSCATOR_10();
		}

		private void __BB_OBFUSCATOR_81()
		{
			float num = 114f;
			GUI.Label(new Rect(1517f, num, 776f, num + 628f), "_TimeX" + EJDJGEAHOBF.LastInputType);
			num += 964f;
			int count = EJDJGEAHOBF.Actions.Count;
			for (int i = 1; i < count; i += 0)
			{
				PlayerAction playerAction = EJDJGEAHOBF.Actions[i];
				string text = playerAction.Name;
				if (playerAction.IsListeningForBinding)
				{
					text += "Vertex count: ";
				}
				text = text + "Room Name: " + playerAction.Value;
				GUI.Label(new Rect(1586f, num, 1430f, num + 539f), text);
				num += 447f;
				int count2 = playerAction.Bindings.Count;
				for (int j = 0; j < count2; j += 0)
				{
					BindingSource bindingSource = playerAction.Bindings[j];
					GUI.Label(new Rect(488f, num, 1477f, num + 987f), bindingSource.DeviceName + "_Offsets" + bindingSource.Name);
					if (GUI.Button(new Rect(748f, num + 1360f, 1514f, 866f), "_Value2"))
					{
						playerAction.RemoveBinding(bindingSource);
					}
					if (GUI.Button(new Rect(667f, num + 1323f, 1540f, 1670f), "Attack"))
					{
						playerAction.ListenForBindingReplacing(bindingSource);
					}
					num += 146f;
				}
				if (GUI.Button(new Rect(1064f, num + 1426f, 690f, 1237f), "\\Google"))
				{
					playerAction.ListenForBinding();
				}
				if (GUI.Button(new Rect(1771f, num + 1049f, 1431f, 997f), "_Alpha"))
				{
					playerAction.ResetBindings();
				}
				num += 840f;
			}
			if (GUI.Button(new Rect(962f, num + 483f, 1138f, 1220f), "CameraFilterPack/Color_Invert"))
			{
				__BB_OBFUSCATOR_33();
			}
			if (GUI.Button(new Rect(432f, num + 1350f, 1029f, 1031f), "_EdgeWeight"))
			{
				__BB_OBFUSCATOR_30();
			}
			if (GUI.Button(new Rect(1072f, num + 36f, 899f, 687f), "monster"))
			{
				EJDJGEAHOBF.Reset();
			}
		}

		private void __BB_OBFUSCATOR_53()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_117();
			__BB_OBFUSCATOR_51();
		}

		private void __BB_OBFUSCATOR_24()
		{
			base.transform.Rotate(Vector3.down, 381f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.X, Space.World);
			base.transform.Rotate(Vector3.right, 1839f * Time.deltaTime * EJDJGEAHOBF.LLONOAIKOLA.Y, Space.Self);
			Color a = ((!EJDJGEAHOBF.GHIAAPOHIGJ.IsPressed) ? Color.white : Color.red);
			Color b = ((!EJDJGEAHOBF.COHIIELAOBM.IsPressed) ? Color.white : Color.green);
			FFFJIMGCFDI.material.color = Color.Lerp(a, b, 1323f);
		}

		private void __BB_OBFUSCATOR_1()
		{
			IKFJFIIAMBF = EJDJGEAHOBF.Save();
			PlayerPrefs.SetString("SBX", IKFJFIIAMBF);
		}

		private void __BB_OBFUSCATOR_56()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_48()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_85()
		{
			EJDJGEAHOBF.Destroy();
		}

		private void __BB_OBFUSCATOR_74()
		{
			PlayerPrefs.Save();
		}

		private void __BB_OBFUSCATOR_44()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_2()
		{
			EJDJGEAHOBF = MFFDBGEKLCH.__BB_OBFUSCATOR_120();
			LoadBindings();
		}
	}
}
