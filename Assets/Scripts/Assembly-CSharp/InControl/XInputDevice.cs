using XInputDotNetPure;

namespace InControl
{
	public class XInputDevice : InputDevice
	{
		private const float LowerDeadZone = 0.2f;

		private const float UpperDeadZone = 0.9f;

		private XInputDeviceManager owner;

		private GHMBOFCIIJJ state;

		public int DeviceIndex { get; private set; }

		public bool IsConnected
		{
			get
			{
				return state.LDGKLJPIFFE;
			}
		}

		public XInputDevice(int deviceIndex, XInputDeviceManager owner)
			: base("XInput Controller")
		{
			this.owner = owner;
			DeviceIndex = deviceIndex;
			base.SortOrder = deviceIndex;
			base.Meta = "XInput Device #" + deviceIndex;
			base.DeviceClass = InputDeviceClass.Controller;
			base.DeviceStyle = InputDeviceStyle.XboxOne;
			AddControl(InputControlType.LeftStickLeft, "Left Stick Left", 0.2f, 0.9f);
			AddControl(InputControlType.LeftStickRight, "Left Stick Right", 0.2f, 0.9f);
			AddControl(InputControlType.LeftStickUp, "Left Stick Up", 0.2f, 0.9f);
			AddControl(InputControlType.LeftStickDown, "Left Stick Down", 0.2f, 0.9f);
			AddControl(InputControlType.RightStickLeft, "Right Stick Left", 0.2f, 0.9f);
			AddControl(InputControlType.RightStickRight, "Right Stick Right", 0.2f, 0.9f);
			AddControl(InputControlType.RightStickUp, "Right Stick Up", 0.2f, 0.9f);
			AddControl(InputControlType.RightStickDown, "Right Stick Down", 0.2f, 0.9f);
			AddControl(InputControlType.LeftTrigger, "Left Trigger", 0.2f, 0.9f);
			AddControl(InputControlType.RightTrigger, "Right Trigger", 0.2f, 0.9f);
			AddControl(InputControlType.DPadUp, "DPad Up", 0.2f, 0.9f);
			AddControl(InputControlType.DPadDown, "DPad Down", 0.2f, 0.9f);
			AddControl(InputControlType.DPadLeft, "DPad Left", 0.2f, 0.9f);
			AddControl(InputControlType.DPadRight, "DPad Right", 0.2f, 0.9f);
			AddControl(InputControlType.Action1, "A");
			AddControl(InputControlType.Action2, "B");
			AddControl(InputControlType.Action3, "X");
			AddControl(InputControlType.Action4, "Y");
			AddControl(InputControlType.LeftBumper, "Left Bumper");
			AddControl(InputControlType.RightBumper, "Right Bumper");
			AddControl(InputControlType.LeftStickButton, "Left Stick Button");
			AddControl(InputControlType.RightStickButton, "Right Stick Button");
			AddControl(InputControlType.Start, "Start");
			AddControl(InputControlType.Back, "Back");
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
			GetState();
			UpdateLeftStickWithValue(state.HEEAOCFHINL.FKONKKBIPIN.KBGKFFDGPNN, updateTick, deltaTime);
			UpdateRightStickWithValue(state.HEEAOCFHINL.GEBIPOPBEGL.KBGKFFDGPNN, updateTick, deltaTime);
			UpdateWithValue(InputControlType.LeftTrigger, state.HBIOJGLDMOF.FKONKKBIPIN, updateTick, deltaTime);
			UpdateWithValue(InputControlType.RightTrigger, state.HBIOJGLDMOF.GEBIPOPBEGL, updateTick, deltaTime);
			UpdateWithState(InputControlType.DPadUp, state.MHIMEFLCGBH.PMACCHLODHP == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.DPadDown, state.MHIMEFLCGBH.EEPNJCEFABF == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.DPadLeft, state.MHIMEFLCGBH.FKONKKBIPIN == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.DPadRight, state.MHIMEFLCGBH.GEBIPOPBEGL == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Action1, state.HJDGCEDFILP.ILLBDLKGDHL == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Action2, state.HJDGCEDFILP.KJMNNCFPILK == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Action3, state.HJDGCEDFILP.NILLCDNIONH == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Action4, state.HJDGCEDFILP.FGLIPCNDGDD == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.LeftBumper, state.HJDGCEDFILP.KGNBKIEJDLH == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.RightBumper, state.HJDGCEDFILP.HINAPBOFNAA == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.LeftStickButton, state.HJDGCEDFILP.GEGOKIICIIM == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.RightStickButton, state.HJDGCEDFILP.LDEDBBODNMO == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Start, state.HJDGCEDFILP.AKCOFKFIEDK == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			UpdateWithState(InputControlType.Back, state.HJDGCEDFILP.PBFNOKDCPPB == MMCEIDLPNIN.Pressed, updateTick, deltaTime);
			Commit(updateTick, deltaTime);
		}

		public override void Vibrate(float leftMotor, float rightMotor)
		{
			NLIKGPCKJBM.SetVibration((LKIHIADKFOI)DeviceIndex, leftMotor, rightMotor);
		}

		internal void GetState()
		{
			state = owner.GetState(DeviceIndex);
		}
	}
}
