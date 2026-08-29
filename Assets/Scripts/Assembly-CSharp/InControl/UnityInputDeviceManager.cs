using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	public class UnityInputDeviceManager : InputDeviceManager
	{
		[CompilerGenerated]
		private sealed class _003CDetectJoystickDevice_003Ec__AnonStorey0
		{
			internal string unityJoystickName;

			internal bool _003C_003Em__0(UnityInputDeviceProfileBase config)
			{
				return config.HasJoystickName(unityJoystickName);
			}

			internal bool _003C_003Em__1(UnityInputDeviceProfileBase config)
			{
				return config.HasJoystickName(unityJoystickName);
			}

			internal bool _003C_003Em__2(UnityInputDeviceProfileBase config)
			{
				return config.HasLastResortRegex(unityJoystickName);
			}

			internal bool _003C_003Em__3(UnityInputDeviceProfileBase config)
			{
				return config.HasLastResortRegex(unityJoystickName);
			}
		}

		private const float deviceRefreshInterval = 1f;

		private float deviceRefreshTimer;

		private List<UnityInputDeviceProfileBase> systemDeviceProfiles = new List<UnityInputDeviceProfileBase>(UnityInputDeviceProfileList.Profiles.Length);

		private List<UnityInputDeviceProfileBase> customDeviceProfiles = new List<UnityInputDeviceProfileBase>();

		private string[] joystickNames;

		private int lastJoystickCount;

		private int lastJoystickHash;

		private int joystickCount;

		private int joystickHash;

		private bool JoystickInfoHasChanged
		{
			get
			{
				return joystickHash != lastJoystickHash || joystickCount != lastJoystickCount;
			}
		}

		public UnityInputDeviceManager()
		{
			AddSystemDeviceProfiles();
			QueryJoystickInfo();
			AttachDevices();
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
			deviceRefreshTimer += deltaTime;
			if (deviceRefreshTimer >= 1f)
			{
				deviceRefreshTimer = 0f;
				QueryJoystickInfo();
				if (JoystickInfoHasChanged)
				{
					Logger.LogInfo("Change in attached Unity joysticks detected; refreshing device list.");
					DetachDevices();
					AttachDevices();
				}
			}
		}

		private void QueryJoystickInfo()
		{
			joystickNames = Input.GetJoystickNames();
			joystickCount = joystickNames.Length;
			joystickHash = 527 + joystickCount;
			for (int i = 0; i < joystickCount; i++)
			{
				joystickHash = joystickHash * 31 + joystickNames[i].GetHashCode();
			}
		}

		private void AttachDevices()
		{
			AttachKeyboardDevices();
			AttachJoystickDevices();
			lastJoystickCount = joystickCount;
			lastJoystickHash = joystickHash;
		}

		private void DetachDevices()
		{
			int count = devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.DetachDevice(devices[i]);
			}
			devices.Clear();
		}

		public void ReloadDevices()
		{
			QueryJoystickInfo();
			DetachDevices();
			AttachDevices();
		}

		private void AttachDevice(UnityInputDevice device)
		{
			devices.Add(device);
			InputManager.AttachDevice(device);
		}

		private void AttachKeyboardDevices()
		{
			int count = systemDeviceProfiles.Count;
			for (int i = 0; i < count; i++)
			{
				UnityInputDeviceProfileBase unityInputDeviceProfileBase = systemDeviceProfiles[i];
				if (unityInputDeviceProfileBase.IsNotJoystick && unityInputDeviceProfileBase.IsSupportedOnThisPlatform)
				{
					AttachDevice(new UnityInputDevice(unityInputDeviceProfileBase));
				}
			}
		}

		private void AttachJoystickDevices()
		{
			try
			{
				for (int i = 0; i < joystickCount; i++)
				{
					DetectJoystickDevice(i + 1, joystickNames[i]);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError(ex.Message);
				Logger.LogError(ex.StackTrace);
			}
		}

		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			int count = devices.Count;
			for (int i = 0; i < count; i++)
			{
				UnityInputDevice unityInputDevice = devices[i] as UnityInputDevice;
				if (unityInputDevice != null && unityInputDevice.JoystickId == unityJoystickId)
				{
					return true;
				}
			}
			return false;
		}

		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
			_003CDetectJoystickDevice_003Ec__AnonStorey0 _003CDetectJoystickDevice_003Ec__AnonStorey = new _003CDetectJoystickDevice_003Ec__AnonStorey0();
			_003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName = unityJoystickName;
			if (!HasAttachedDeviceWithJoystickId(unityJoystickId) && _003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName.IndexOf("webcam", StringComparison.OrdinalIgnoreCase) == -1 && (!(InputManager.UnityVersion < new VersionInfo(4, 5, 0, 0)) || (Application.platform != 0 && Application.platform != RuntimePlatform.OSXPlayer) || !(_003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName == "Unknown Wireless Controller")) && (!(InputManager.UnityVersion >= new VersionInfo(4, 6, 3, 0)) || (Application.platform != RuntimePlatform.WindowsEditor && Application.platform != RuntimePlatform.WindowsPlayer) || !string.IsNullOrEmpty(_003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName)))
			{
				UnityInputDeviceProfileBase unityInputDeviceProfileBase = null;
				if (unityInputDeviceProfileBase == null)
				{
					unityInputDeviceProfileBase = customDeviceProfiles.Find(_003CDetectJoystickDevice_003Ec__AnonStorey._003C_003Em__0);
				}
				if (unityInputDeviceProfileBase == null)
				{
					unityInputDeviceProfileBase = systemDeviceProfiles.Find(_003CDetectJoystickDevice_003Ec__AnonStorey._003C_003Em__1);
				}
				if (unityInputDeviceProfileBase == null)
				{
					unityInputDeviceProfileBase = customDeviceProfiles.Find(_003CDetectJoystickDevice_003Ec__AnonStorey._003C_003Em__2);
				}
				if (unityInputDeviceProfileBase == null)
				{
					unityInputDeviceProfileBase = systemDeviceProfiles.Find(_003CDetectJoystickDevice_003Ec__AnonStorey._003C_003Em__3);
				}
				if (unityInputDeviceProfileBase == null)
				{
					UnityInputDevice device = new UnityInputDevice(unityJoystickId, _003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName);
					AttachDevice(device);
					Debug.Log("[InControl] Joystick " + unityJoystickId + ": \"" + _003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName + "\"");
					Logger.LogWarning("Device " + unityJoystickId + " with name \"" + _003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName + "\" does not match any supported profiles and will be considered an unknown controller.");
				}
				else if (!unityInputDeviceProfileBase.IsHidden)
				{
					UnityInputDevice device2 = new UnityInputDevice(unityInputDeviceProfileBase, unityJoystickId, _003CDetectJoystickDevice_003Ec__AnonStorey.unityJoystickName);
					AttachDevice(device2);
					Logger.LogInfo("Device " + unityJoystickId + " matched profile " + unityInputDeviceProfileBase.GetType().Name + " (" + unityInputDeviceProfileBase.Name + ")");
				}
				else
				{
					Logger.LogInfo("Device " + unityJoystickId + " matching profile " + unityInputDeviceProfileBase.GetType().Name + " (" + unityInputDeviceProfileBase.Name + ") is hidden and will not be attached.");
				}
			}
		}

		private void AddSystemDeviceProfile(UnityInputDeviceProfile deviceProfile)
		{
			if (deviceProfile.IsSupportedOnThisPlatform)
			{
				systemDeviceProfiles.Add(deviceProfile);
			}
		}

		private void AddSystemDeviceProfiles()
		{
			string[] profiles = UnityInputDeviceProfileList.Profiles;
			foreach (string typeName in profiles)
			{
				UnityInputDeviceProfile deviceProfile = (UnityInputDeviceProfile)Activator.CreateInstance(Type.GetType(typeName));
				AddSystemDeviceProfile(deviceProfile);
			}
		}
	}
}
