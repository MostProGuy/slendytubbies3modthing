using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	public class AMBLPLHGKBM : InputDevice
	{
		private const float KFNNDHLFDHD = 0.1f;

		private const float IDLBHIMAMAB = 0.05f;

		private float ABLFOIIMLJL;

		private float HHEIKCNMNCF;

		private float FAFOMIKCJIB;

		private float KGNAAHADMAN;

		private float __BB_OBFUSCATOR_13()
		{
			float num = ((!Input.GetKey((KeyCode)(-4))) ? 362f : 1232f);
			float num2 = ((!Input.GetKey((KeyCode)(-142))) ? 1146f : 416f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_105(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1638f, 1949f);
			if (Mathf.Approximately(KFNNDHLFDHD, 660f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 529f);
		}

		public virtual void __BB_OBFUSCATOR_68(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_94(GNPEACCNOBD, true);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_14(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.RightBumper, Input.GetKey((KeyCode)65), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-53), Input.GetKey((KeyCode)(-76)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)76, Input.GetKey((KeyCode)(-128)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-118), Input.GetKey(KeyCode.Caret), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_28(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_66(ABLFOIIMLJL, __BB_OBFUSCATOR_87(), GNPEACCNOBD, 521f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_44(HHEIKCNMNCF, __BB_OBFUSCATOR_115(), GNPEACCNOBD, 488f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_77();
				HHEIKCNMNCF = __BB_OBFUSCATOR_51();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_23()
		{
			float num = ((!Input.GetKey((KeyCode)(-117))) ? 564f : 933f);
			float num2 = ((!Input.GetKey((KeyCode)(-27))) ? 725f : 444f);
			return num + num2;
		}

		public virtual void __BB_OBFUSCATOR_79(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_117(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_63(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-47), Input.GetKey((KeyCode)(-80)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)34, Input.GetKey((KeyCode)4), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)98, Input.GetKey((KeyCode)(-38)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-31), Input.GetKey(KeyCode.RightBracket), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_2(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_75(ABLFOIIMLJL, __BB_OBFUSCATOR_98(), GNPEACCNOBD, 1107f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_64(HHEIKCNMNCF, __BB_OBFUSCATOR_51(), GNPEACCNOBD, 1337f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_49();
				HHEIKCNMNCF = __BB_OBFUSCATOR_36();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_73(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_57(ABLFOIIMLJL, __BB_OBFUSCATOR_7(), GNPEACCNOBD, 1431f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_44(HHEIKCNMNCF, __BB_OBFUSCATOR_5(), GNPEACCNOBD, 553f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_29();
				HHEIKCNMNCF = __BB_OBFUSCATOR_21();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_89(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_75(FAFOMIKCJIB, Input.GetAxisRaw("Unsubscribe called while not connected to front end server.") * 166f, GNPEACCNOBD, 394f);
				KGNAAHADMAN = __BB_OBFUSCATOR_46(KGNAAHADMAN, Input.GetAxisRaw("_PositionY") * 1278f, GNPEACCNOBD, 1654f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("COOP") * 1555f;
				KGNAAHADMAN = Input.GetAxisRaw("_TimeX") * 1279f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 __BB_OBFUSCATOR_114(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_16(ABLFOIIMLJL, __BB_OBFUSCATOR_38(), GNPEACCNOBD, 890f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_83(HHEIKCNMNCF, __BB_OBFUSCATOR_5(), GNPEACCNOBD, 1781f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_11();
				HHEIKCNMNCF = __BB_OBFUSCATOR_36();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_26(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 304f, 1411f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1082f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 229f);
		}

		private Vector2 __BB_OBFUSCATOR_37(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_57(ABLFOIIMLJL, __BB_OBFUSCATOR_13(), GNPEACCNOBD, 620f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_105(HHEIKCNMNCF, __BB_OBFUSCATOR_15(), GNPEACCNOBD, 47f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_104();
				HHEIKCNMNCF = __BB_OBFUSCATOR_5();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_21()
		{
			float num = ((!Input.GetKey(KeyCode.Alpha2)) ? 545f : 118f);
			float num2 = ((!Input.GetKey((KeyCode)(-128))) ? 361f : 563f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_56(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 432f, 188f);
			if (Mathf.Approximately(KFNNDHLFDHD, 624f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1129f);
		}

		private float __BB_OBFUSCATOR_57(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1676f, 354f);
			if (Mathf.Approximately(KFNNDHLFDHD, 249f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 258f);
		}

		private float __BB_OBFUSCATOR_36()
		{
			float num = ((!Input.GetKey((KeyCode)156)) ? 1518f : 695f);
			float num2 = ((!Input.GetKey((KeyCode)135)) ? 1185f : 1985f);
			return num + num2;
		}

		private float GetXFromKeyboard()
		{
			float num = ((!Input.GetKey(KeyCode.LeftArrow)) ? 0f : (-1f));
			float num2 = ((!Input.GetKey(KeyCode.RightArrow)) ? 0f : 1f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_5()
		{
			float num = ((!Input.GetKey((KeyCode)(-116))) ? 568f : 321f);
			float num2 = ((!Input.GetKey((KeyCode)(-64))) ? 125f : 123f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_61(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_16(FAFOMIKCJIB, Input.GetAxisRaw("Attack") * 1621f, GNPEACCNOBD, 983f);
				KGNAAHADMAN = __BB_OBFUSCATOR_44(KGNAAHADMAN, Input.GetAxisRaw("|") * 211f, GNPEACCNOBD, 1297f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("_Value") * 717f;
				KGNAAHADMAN = Input.GetAxisRaw("n15") * 1292f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 __BB_OBFUSCATOR_48(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_57(ABLFOIIMLJL, __BB_OBFUSCATOR_43(), GNPEACCNOBD, 88f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_105(HHEIKCNMNCF, __BB_OBFUSCATOR_23(), GNPEACCNOBD, 186f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_77();
				HHEIKCNMNCF = __BB_OBFUSCATOR_19();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_14(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_60(FAFOMIKCJIB, Input.GetAxisRaw("_TimeX") * 624f, GNPEACCNOBD, 1062f);
				KGNAAHADMAN = ApplySmoothing(KGNAAHADMAN, Input.GetAxisRaw("_DisplayVelocityScale") * 1543f, GNPEACCNOBD, 1681f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("CameraFilterPack/Blend2Camera_Hue") * 481f;
				KGNAAHADMAN = Input.GetAxisRaw("<size=") * 1201f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 GetVectorFromKeyboard(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = ApplySmoothing(ABLFOIIMLJL, GetXFromKeyboard(), GNPEACCNOBD, 0.1f);
				HHEIKCNMNCF = ApplySmoothing(HHEIKCNMNCF, GetYFromKeyboard(), GNPEACCNOBD, 0.1f);
			}
			else
			{
				ABLFOIIMLJL = GetXFromKeyboard();
				HHEIKCNMNCF = GetYFromKeyboard();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		public virtual void __BB_OBFUSCATOR_92(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_71(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_101(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Action11, Input.GetKey((KeyCode)(-26)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-37), Input.GetKey(KeyCode.Slash), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)88, Input.GetKey((KeyCode)84), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.None, Input.GetKey(KeyCode.Alpha6), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private float __BB_OBFUSCATOR_98()
		{
			float num = ((!Input.GetKey(KeyCode.V)) ? 692f : 788f);
			float num2 = ((!Input.GetKey((KeyCode)(-162))) ? 1599f : 38f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_84()
		{
			float num = ((!Input.GetKey((KeyCode)141)) ? 510f : 1381f);
			float num2 = ((!Input.GetKey((KeyCode)68)) ? 535f : 1945f);
			return num + num2;
		}

		public virtual void __BB_OBFUSCATOR_97(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_91(GNPEACCNOBD, true);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_14(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)116, Input.GetKey((KeyCode)(-55)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-127), Input.GetKey((KeyCode)124), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-105), Input.GetKey((KeyCode)(-123)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.RightStickUp, Input.GetKey(KeyCode.A), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private float __BB_OBFUSCATOR_38()
		{
			float num = ((!Input.GetKey(KeyCode.B)) ? 810f : 1929f);
			float num2 = ((!Input.GetKey((KeyCode)(-63))) ? 1744f : 1011f);
			return num + num2;
		}

		public AMBLPLHGKBM()
			: base("Virtual Controller")
		{
			AddControl(InputControlType.LeftStickLeft, "Left Stick Left");
			AddControl(InputControlType.LeftStickRight, "Left Stick Right");
			AddControl(InputControlType.LeftStickUp, "Left Stick Up");
			AddControl(InputControlType.LeftStickDown, "Left Stick Down");
			AddControl(InputControlType.RightStickLeft, "Right Stick Left");
			AddControl(InputControlType.RightStickRight, "Right Stick Right");
			AddControl(InputControlType.RightStickUp, "Right Stick Up");
			AddControl(InputControlType.RightStickDown, "Right Stick Down");
			AddControl(InputControlType.Action1, "A");
			AddControl(InputControlType.Action2, "B");
			AddControl(InputControlType.Action3, "X");
			AddControl(InputControlType.Action4, "Y");
		}

		private float __BB_OBFUSCATOR_62(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1026f, 1826f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1980f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1926f);
		}

		private Vector2 __BB_OBFUSCATOR_101(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_16(FAFOMIKCJIB, Input.GetAxisRaw("CameraFilterPack/TV_Old") * 1264f, GNPEACCNOBD, 964f);
				KGNAAHADMAN = __BB_OBFUSCATOR_83(KGNAAHADMAN, Input.GetAxisRaw("TeamName") * 1758f, GNPEACCNOBD, 621f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("box") * 519f;
				KGNAAHADMAN = Input.GetAxisRaw("Animation Data") * 127f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		public virtual void __BB_OBFUSCATOR_99(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_106(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_109(GNPEACCNOBD, false);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)86, Input.GetKey((KeyCode)31), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)126, Input.GetKey((KeyCode)22), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)71, Input.GetKey(KeyCode.Hash), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-113), Input.GetKey((KeyCode)(-15)), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		public override void Update(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 vectorFromKeyboard = GetVectorFromKeyboard(GNPEACCNOBD, true);
			UpdateLeftStickWithValue(vectorFromKeyboard, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 vectorFromMouse = GetVectorFromMouse(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(vectorFromMouse, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Action1, Input.GetKey(KeyCode.Space), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Action2, Input.GetKey(KeyCode.S), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Action3, Input.GetKey(KeyCode.D), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Action4, Input.GetKey(KeyCode.F), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_116(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_59(FAFOMIKCJIB, Input.GetAxisRaw("Fire") * 1281f, GNPEACCNOBD, 882f);
				KGNAAHADMAN = __BB_OBFUSCATOR_59(KGNAAHADMAN, Input.GetAxisRaw("_Speed") * 482f, GNPEACCNOBD, 1544f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("_Value2") * 334f;
				KGNAAHADMAN = Input.GetAxisRaw("_Value") * 709f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_64(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 103f, 870f);
			if (Mathf.Approximately(KFNNDHLFDHD, 73f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 483f);
		}

		private float __BB_OBFUSCATOR_77()
		{
			float num = ((!Input.GetKey((KeyCode)(-30))) ? 971f : 353f);
			float num2 = ((!Input.GetKey((KeyCode)4)) ? 1387f : 1481f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_72(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_40(ABLFOIIMLJL, __BB_OBFUSCATOR_49(), GNPEACCNOBD, 1854f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_56(HHEIKCNMNCF, __BB_OBFUSCATOR_110(), GNPEACCNOBD, 1171f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_82();
				HHEIKCNMNCF = __BB_OBFUSCATOR_34();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_69()
		{
			float num = ((!Input.GetKey((KeyCode)30)) ? 1358f : 708f);
			float num2 = ((!Input.GetKey((KeyCode)16)) ? 857f : 1370f);
			return num + num2;
		}

		public virtual void __BB_OBFUSCATOR_32(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_18(GNPEACCNOBD, true);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_112(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)122, Input.GetKey((KeyCode)(-47)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)113, Input.GetKey(KeyCode.Tab), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-106), Input.GetKey((KeyCode)3), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)88, Input.GetKey((KeyCode)(-72)), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_65(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_66(ABLFOIIMLJL, __BB_OBFUSCATOR_29(), GNPEACCNOBD, 976f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_1(HHEIKCNMNCF, __BB_OBFUSCATOR_115(), GNPEACCNOBD, 1529f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_38();
				HHEIKCNMNCF = __BB_OBFUSCATOR_51();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_90(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_64(ABLFOIIMLJL, __BB_OBFUSCATOR_13(), GNPEACCNOBD, 1083f);
				HHEIKCNMNCF = ApplySmoothing(HHEIKCNMNCF, __BB_OBFUSCATOR_21(), GNPEACCNOBD, 1557f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_58();
				HHEIKCNMNCF = __BB_OBFUSCATOR_51();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_112(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_44(FAFOMIKCJIB, Input.GetAxisRaw("CameraFilterPack/Blur_Dithering2x2") * 1964f, GNPEACCNOBD, 990f);
				KGNAAHADMAN = __BB_OBFUSCATOR_62(KGNAAHADMAN, Input.GetAxisRaw("_Texture") * 1983f, GNPEACCNOBD, 1203f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("Jump") * 922f;
				KGNAAHADMAN = Input.GetAxisRaw("CameraFilterPack/Vision_Drost") * 1691f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_108(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 48f, 1960f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1608f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 790f);
		}

		private float __BB_OBFUSCATOR_27(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1540f, 1703f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1325f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 208f);
		}

		public virtual void __BB_OBFUSCATOR_12(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_48(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_33(GNPEACCNOBD, false);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-24), Input.GetKey(KeyCode.Plus), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-78), Input.GetKey((KeyCode)75), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)41, Input.GetKey((KeyCode)(-109)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.DPadLeft, Input.GetKey((KeyCode)(-40)), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_31(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_59(FAFOMIKCJIB, Input.GetAxisRaw("_ScreenResolution") * 1121f, GNPEACCNOBD, 391f);
				KGNAAHADMAN = __BB_OBFUSCATOR_64(KGNAAHADMAN, Input.GetAxisRaw("VS") * 815f, GNPEACCNOBD, 1925f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("_EdgeSharpness") * 1390f;
				KGNAAHADMAN = Input.GetAxisRaw("Flashlight") * 1296f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_16(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1049f, 999f);
			if (Mathf.Approximately(KFNNDHLFDHD, 960f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1701f);
		}

		private float __BB_OBFUSCATOR_83(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1533f, 193f);
			if (Mathf.Approximately(KFNNDHLFDHD, 282f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 918f);
		}

		private float __BB_OBFUSCATOR_102(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1603f, 1756f);
			if (Mathf.Approximately(KFNNDHLFDHD, 61f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 933f);
		}

		public virtual void __BB_OBFUSCATOR_39(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_94(GNPEACCNOBD, true);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_80(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)70, Input.GetKey((KeyCode)(-19)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-39), Input.GetKey(KeyCode.LeftBracket), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)79, Input.GetKey((KeyCode)(-85)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-90), Input.GetKey((KeyCode)(-82)), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private float __BB_OBFUSCATOR_0(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 5f, 576f);
			if (Mathf.Approximately(KFNNDHLFDHD, 909f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 683f);
		}

		private float __BB_OBFUSCATOR_95()
		{
			float num = ((!Input.GetKey((KeyCode)(-183))) ? 218f : 254f);
			float num2 = ((!Input.GetKey(KeyCode.Pause)) ? 1183f : 1034f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_1(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1352f, 890f);
			if (Mathf.Approximately(KFNNDHLFDHD, 241f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 499f);
		}

		private float __BB_OBFUSCATOR_40(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1822f, 8f);
			if (Mathf.Approximately(KFNNDHLFDHD, 403f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 297f);
		}

		private Vector2 __BB_OBFUSCATOR_96(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_16(FAFOMIKCJIB, Input.GetAxisRaw("Jump") * 49f, GNPEACCNOBD, 158f);
				KGNAAHADMAN = __BB_OBFUSCATOR_1(KGNAAHADMAN, Input.GetAxisRaw("CameraFilterPack/FX_EarthQuake") * 759f, GNPEACCNOBD, 761f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("_Value2") * 815f;
				KGNAAHADMAN = Input.GetAxisRaw("Ping: ") * 1870f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_110()
		{
			float num = ((!Input.GetKey((KeyCode)(-80))) ? 1395f : 1356f);
			float num2 = ((!Input.GetKey((KeyCode)(-198))) ? 215f : 1593f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_15()
		{
			float num = ((!Input.GetKey((KeyCode)190)) ? 287f : 1681f);
			float num2 = ((!Input.GetKey(KeyCode.Alpha5)) ? 579f : 1933f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_113(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 236f, 841f);
			if (Mathf.Approximately(KFNNDHLFDHD, 99f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1059f);
		}

		private float __BB_OBFUSCATOR_7()
		{
			float num = ((!Input.GetKey((KeyCode)(-6))) ? 1624f : 183f);
			float num2 = ((!Input.GetKey(KeyCode.Equals)) ? 625f : 1808f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_76()
		{
			float num = ((!Input.GetKey((KeyCode)(-39))) ? 384f : 1246f);
			float num2 = ((!Input.GetKey((KeyCode)(-69))) ? 1288f : 895f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_71(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_75(ABLFOIIMLJL, __BB_OBFUSCATOR_49(), GNPEACCNOBD, 1869f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_46(HHEIKCNMNCF, __BB_OBFUSCATOR_115(), GNPEACCNOBD, 1578f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_69();
				HHEIKCNMNCF = __BB_OBFUSCATOR_51();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_8(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_102(ABLFOIIMLJL, __BB_OBFUSCATOR_49(), GNPEACCNOBD, 517f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_62(HHEIKCNMNCF, __BB_OBFUSCATOR_34(), GNPEACCNOBD, 954f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_82();
				HHEIKCNMNCF = __BB_OBFUSCATOR_19();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_94(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_102(ABLFOIIMLJL, __BB_OBFUSCATOR_43(), GNPEACCNOBD, 961f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_40(HHEIKCNMNCF, __BB_OBFUSCATOR_55(), GNPEACCNOBD, 337f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_7();
				HHEIKCNMNCF = __BB_OBFUSCATOR_67();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_10(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_64(ABLFOIIMLJL, __BB_OBFUSCATOR_47(), GNPEACCNOBD, 467f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_27(HHEIKCNMNCF, __BB_OBFUSCATOR_23(), GNPEACCNOBD, 1816f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_43();
				HHEIKCNMNCF = __BB_OBFUSCATOR_19();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float GetYFromKeyboard()
		{
			float num = ((!Input.GetKey(KeyCode.UpArrow)) ? 0f : 1f);
			float num2 = ((!Input.GetKey(KeyCode.DownArrow)) ? 0f : (-1f));
			return num + num2;
		}

		private Vector2 GetVectorFromMouse(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = ApplySmoothing(FAFOMIKCJIB, Input.GetAxisRaw("mouse x") * 0.05f, GNPEACCNOBD, 0.1f);
				KGNAAHADMAN = ApplySmoothing(KGNAAHADMAN, Input.GetAxisRaw("mouse y") * 0.05f, GNPEACCNOBD, 0.1f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("mouse x") * 0.05f;
				KGNAAHADMAN = Input.GetAxisRaw("mouse y") * 0.05f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_46(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1595f, 1438f);
			if (Mathf.Approximately(KFNNDHLFDHD, 739f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 976f);
		}

		private float __BB_OBFUSCATOR_11()
		{
			float num = ((!Input.GetKey((KeyCode)(-169))) ? 1994f : 1f);
			float num2 = ((!Input.GetKey((KeyCode)76)) ? 998f : 642f);
			return num + num2;
		}

		public virtual void __BB_OBFUSCATOR_17(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_10(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_86(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-119), Input.GetKey(KeyCode.A), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)89, Input.GetKey((KeyCode)(-106)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-71), Input.GetKey((KeyCode)26), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)84, Input.GetKey(KeyCode.Period), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private float __BB_OBFUSCATOR_34()
		{
			float num = ((!Input.GetKey((KeyCode)(-176))) ? 226f : 1327f);
			float num2 = ((!Input.GetKey((KeyCode)1)) ? 65f : 72f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_49()
		{
			float num = ((!Input.GetKey((KeyCode)(-89))) ? 630f : 1684f);
			float num2 = ((!Input.GetKey(KeyCode.Alpha2)) ? 610f : 603f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_82()
		{
			float num = ((!Input.GetKey((KeyCode)(-195))) ? 840f : 1174f);
			float num2 = ((!Input.GetKey((KeyCode)(-80))) ? 467f : 1679f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_29()
		{
			float num = ((!Input.GetKey((KeyCode)(-94))) ? 1219f : 1947f);
			float num2 = ((!Input.GetKey((KeyCode)(-68))) ? 1304f : 1410f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_100(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = ApplySmoothing(ABLFOIIMLJL, __BB_OBFUSCATOR_77(), GNPEACCNOBD, 505f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_64(HHEIKCNMNCF, __BB_OBFUSCATOR_21(), GNPEACCNOBD, 1596f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_47();
				HHEIKCNMNCF = __BB_OBFUSCATOR_21();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_59(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1059f, 297f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1456f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 834f);
		}

		private float __BB_OBFUSCATOR_75(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1873f, 964f);
			if (Mathf.Approximately(KFNNDHLFDHD, 679f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1503f);
		}

		public virtual void __BB_OBFUSCATOR_24(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_18(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_116(GNPEACCNOBD, true);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-55), Input.GetKey((KeyCode)(-75)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.Menu, Input.GetKey((KeyCode)28), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)46, Input.GetKey((KeyCode)(-12)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)122, Input.GetKey(KeyCode.Quote), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_91(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_1(ABLFOIIMLJL, __BB_OBFUSCATOR_47(), GNPEACCNOBD, 116f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_16(HHEIKCNMNCF, __BB_OBFUSCATOR_34(), GNPEACCNOBD, 1593f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_77();
				HHEIKCNMNCF = __BB_OBFUSCATOR_34();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_115()
		{
			float num = ((!Input.GetKey((KeyCode)(-70))) ? 1359f : 789f);
			float num2 = ((!Input.GetKey((KeyCode)(-68))) ? 1086f : 708f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_106(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_44(ABLFOIIMLJL, __BB_OBFUSCATOR_98(), GNPEACCNOBD, 1678f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_105(HHEIKCNMNCF, __BB_OBFUSCATOR_15(), GNPEACCNOBD, 857f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_43();
				HHEIKCNMNCF = __BB_OBFUSCATOR_51();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private Vector2 __BB_OBFUSCATOR_63(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_27(FAFOMIKCJIB, Input.GetAxisRaw("_NoisePerChannel") * 1790f, GNPEACCNOBD, 1227f);
				KGNAAHADMAN = __BB_OBFUSCATOR_1(KGNAAHADMAN, Input.GetAxisRaw("Bindings") * 1642f, GNPEACCNOBD, 1113f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("offsets") * 248f;
				KGNAAHADMAN = Input.GetAxisRaw("monster") * 1440f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_104()
		{
			float num = ((!Input.GetKey((KeyCode)(-92))) ? 502f : 1991f);
			float num2 = ((!Input.GetKey((KeyCode)16)) ? 321f : 1609f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_43()
		{
			float num = ((!Input.GetKey((KeyCode)15)) ? 1412f : 1253f);
			float num2 = ((!Input.GetKey((KeyCode)(-158))) ? 265f : 1385f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_53(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_105(FAFOMIKCJIB, Input.GetAxisRaw("_Intensity") * 86f, GNPEACCNOBD, 303f);
				KGNAAHADMAN = __BB_OBFUSCATOR_44(KGNAAHADMAN, Input.GetAxisRaw("\n\t\t}") * 1325f, GNPEACCNOBD, 1845f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("{0}:{1}") * 551f;
				KGNAAHADMAN = Input.GetAxisRaw("box") * 1587f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_107()
		{
			float num = ((!Input.GetKey((KeyCode)(-5))) ? 780f : 1731f);
			float num2 = ((!Input.GetKey(KeyCode.Greater)) ? 1058f : 1336f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_87()
		{
			float num = ((!Input.GetKey(KeyCode.RightBracket)) ? 138f : 1448f);
			float num2 = ((!Input.GetKey((KeyCode)(-75))) ? 1951f : 315f);
			return num + num2;
		}

		private float ApplySmoothing(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 0.001f, 1f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 100f);
		}

		private Vector2 __BB_OBFUSCATOR_109(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_88(FAFOMIKCJIB, Input.GetAxisRaw("Simplifying mesh: ") * 956f, GNPEACCNOBD, 1448f);
				KGNAAHADMAN = __BB_OBFUSCATOR_108(KGNAAHADMAN, Input.GetAxisRaw("Player") * 230f, GNPEACCNOBD, 1252f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("-Horizontal") * 1695f;
				KGNAAHADMAN = Input.GetAxisRaw("SmokeA-Default") * 1597f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 __BB_OBFUSCATOR_117(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_44(ABLFOIIMLJL, __BB_OBFUSCATOR_87(), GNPEACCNOBD, 685f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_40(HHEIKCNMNCF, __BB_OBFUSCATOR_36(), GNPEACCNOBD, 894f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_98();
				HHEIKCNMNCF = __BB_OBFUSCATOR_23();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_55()
		{
			float num = ((!Input.GetKey((KeyCode)(-184))) ? 730f : 198f);
			float num2 = ((!Input.GetKey((KeyCode)(-15))) ? 808f : 1810f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_44(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 952f, 567f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1307f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 437f);
		}

		private float __BB_OBFUSCATOR_60(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 246f, 944f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1298f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1610f);
		}

		private float __BB_OBFUSCATOR_54(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 1123f, 991f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1067f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 344f);
		}

		private Vector2 __BB_OBFUSCATOR_18(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_75(ABLFOIIMLJL, __BB_OBFUSCATOR_7(), GNPEACCNOBD, 1838f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_54(HHEIKCNMNCF, __BB_OBFUSCATOR_34(), GNPEACCNOBD, 241f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_41();
				HHEIKCNMNCF = __BB_OBFUSCATOR_34();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_41()
		{
			float num = ((!Input.GetKey((KeyCode)(-64))) ? 1400f : 1863f);
			float num2 = ((!Input.GetKey(KeyCode.Hash)) ? 1039f : 1314f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_19()
		{
			float num = ((!Input.GetKey((KeyCode)(-6))) ? 74f : 1177f);
			float num2 = ((!Input.GetKey((KeyCode)(-45))) ? 574f : 165f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_86(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_16(FAFOMIKCJIB, Input.GetAxisRaw("RoundDuration") * 1295f, GNPEACCNOBD, 170f);
				KGNAAHADMAN = __BB_OBFUSCATOR_62(KGNAAHADMAN, Input.GetAxisRaw(">") * 947f, GNPEACCNOBD, 1549f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw(" ☠") * 1407f;
				KGNAAHADMAN = Input.GetAxisRaw("_Value2") * 1261f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 __BB_OBFUSCATOR_25(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_88(ABLFOIIMLJL, __BB_OBFUSCATOR_58(), GNPEACCNOBD, 576f);
				HHEIKCNMNCF = __BB_OBFUSCATOR_44(HHEIKCNMNCF, __BB_OBFUSCATOR_19(), GNPEACCNOBD, 27f);
			}
			else
			{
				ABLFOIIMLJL = __BB_OBFUSCATOR_98();
				HHEIKCNMNCF = __BB_OBFUSCATOR_19();
			}
			return new Vector2(ABLFOIIMLJL, HHEIKCNMNCF);
		}

		private float __BB_OBFUSCATOR_88(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 45f, 779f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1126f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1406f);
		}

		private float __BB_OBFUSCATOR_66(float KNNPBLLOHCC, float NIHALBKAOMD, float GNPEACCNOBD, float KFNNDHLFDHD)
		{
			KFNNDHLFDHD = Mathf.Clamp(KFNNDHLFDHD, 145f, 994f);
			if (Mathf.Approximately(KFNNDHLFDHD, 1888f))
			{
				return NIHALBKAOMD;
			}
			return Mathf.Lerp(KNNPBLLOHCC, NIHALBKAOMD, GNPEACCNOBD * KFNNDHLFDHD * 1652f);
		}

		private Vector2 __BB_OBFUSCATOR_33(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_0(FAFOMIKCJIB, Input.GetAxisRaw("CheckIfAlive") * 601f, GNPEACCNOBD, 1525f);
				KGNAAHADMAN = __BB_OBFUSCATOR_0(KGNAAHADMAN, Input.GetAxisRaw("_Value") * 521f, GNPEACCNOBD, 1637f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("CameraFilterPack/FX_8bits") * 633f;
				KGNAAHADMAN = Input.GetAxisRaw("_ScreenResolution") * 1616f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_58()
		{
			float num = ((!Input.GetKey((KeyCode)(-29))) ? 1955f : 1256f);
			float num2 = ((!Input.GetKey(KeyCode.Pause)) ? 1161f : 276f);
			return num + num2;
		}

		public virtual void __BB_OBFUSCATOR_85(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_8(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_93(GNPEACCNOBD, false);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.RightStickUp, Input.GetKey((KeyCode)30), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.DPadUp, Input.GetKey((KeyCode)(-59)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)97, Input.GetKey(KeyCode.Minus), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-55), Input.GetKey((KeyCode)(-33)), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		public virtual void __BB_OBFUSCATOR_103(ulong AOBIPNBCMDP, float GNPEACCNOBD)
		{
			Vector2 value = __BB_OBFUSCATOR_73(GNPEACCNOBD, false);
			UpdateLeftStickWithValue(value, AOBIPNBCMDP, GNPEACCNOBD);
			Vector2 value2 = __BB_OBFUSCATOR_53(GNPEACCNOBD, false);
			UpdateRightStickWithRawValue(value2, AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState(InputControlType.None, Input.GetKey(KeyCode.Less), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)(-71), Input.GetKey((KeyCode)77), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)55, Input.GetKey((KeyCode)(-47)), AOBIPNBCMDP, GNPEACCNOBD);
			UpdateWithState((InputControlType)82, Input.GetKey(KeyCode.RightBracket), AOBIPNBCMDP, GNPEACCNOBD);
			Commit(AOBIPNBCMDP, GNPEACCNOBD);
		}

		private Vector2 __BB_OBFUSCATOR_80(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_26(FAFOMIKCJIB, Input.GetAxisRaw("_Intensity") * 1467f, GNPEACCNOBD, 30f);
				KGNAAHADMAN = __BB_OBFUSCATOR_83(KGNAAHADMAN, Input.GetAxisRaw("monster") * 1699f, GNPEACCNOBD, 1481f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("TeamName") * 107f;
				KGNAAHADMAN = Input.GetAxisRaw("_Value6") * 89f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private Vector2 __BB_OBFUSCATOR_6(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_0(FAFOMIKCJIB, Input.GetAxisRaw("Reload") * 574f, GNPEACCNOBD, 836f);
				KGNAAHADMAN = __BB_OBFUSCATOR_44(KGNAAHADMAN, Input.GetAxisRaw("_ColorG") * 1585f, GNPEACCNOBD, 751f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("HeadlessAfterSceneLoad") * 420f;
				KGNAAHADMAN = Input.GetAxisRaw("Null") * 764f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}

		private float __BB_OBFUSCATOR_51()
		{
			float num = ((!Input.GetKey((KeyCode)(-73))) ? 561f : 1383f);
			float num2 = ((!Input.GetKey((KeyCode)(-3))) ? 135f : 436f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_67()
		{
			float num = ((!Input.GetKey((KeyCode)172)) ? 840f : 950f);
			float num2 = ((!Input.GetKey(KeyCode.Dollar)) ? 1199f : 1530f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_50()
		{
			float num = ((!Input.GetKey((KeyCode)(-103))) ? 1991f : 759f);
			float num2 = ((!Input.GetKey((KeyCode)190)) ? 969f : 1778f);
			return num + num2;
		}

		private float __BB_OBFUSCATOR_47()
		{
			float num = ((!Input.GetKey((KeyCode)124)) ? 1870f : 565f);
			float num2 = ((!Input.GetKey(KeyCode.LeftParen)) ? 993f : 187f);
			return num + num2;
		}

		private Vector2 __BB_OBFUSCATOR_93(float GNPEACCNOBD, bool EHLBODFKKIC)
		{
			if (EHLBODFKKIC)
			{
				FAFOMIKCJIB = __BB_OBFUSCATOR_60(FAFOMIKCJIB, Input.GetAxisRaw("Resolution") * 828f, GNPEACCNOBD, 1018f);
				KGNAAHADMAN = __BB_OBFUSCATOR_60(KGNAAHADMAN, Input.GetAxisRaw("_TimeX") * 302f, GNPEACCNOBD, 15f);
			}
			else
			{
				FAFOMIKCJIB = Input.GetAxisRaw("z") * 915f;
				KGNAAHADMAN = Input.GetAxisRaw("_TimeX") * 1832f;
			}
			return new Vector2(FAFOMIKCJIB, KGNAAHADMAN);
		}
	}
}
