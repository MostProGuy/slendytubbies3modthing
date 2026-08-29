using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl.mod
{
	public class cInput : PlayerActionSet
	{
		public static cInput input = CreateWithDefaultBindings();

		public PlayerAction Fire;

		public PlayerAction Aim;

		public PlayerAction Switch;

		public PlayerAction Switch2;

		public PlayerAction Reload;

		public PlayerAction Run;

		public PlayerAction Crouch;

		public PlayerAction Jump;

		public PlayerAction Left;

		public PlayerAction Right;

		public PlayerAction Up;

		public PlayerAction Down;

		public PlayerAction Left2;

		public PlayerAction Right2;

		public PlayerAction Up2;

		public PlayerAction Down2;

		public PlayerAction View;

		[CompilerGenerated]
		private static Func<PlayerAction, BindingSource, bool> _003C_003Ef__am_0024cache0;

		[CompilerGenerated]
		private static Action<PlayerAction, BindingSource> _003C_003Ef__am_0024cache1;

		[CompilerGenerated]
		private static Action<PlayerAction, BindingSource, BindingSourceRejectionType> _003C_003Ef__am_0024cache2;

		public cInput()
		{
			Fire = CreatePlayerAction("Fire");
			Aim = CreatePlayerAction("Aim");
			Switch = CreatePlayerAction("Switch");
			Switch2 = CreatePlayerAction("Switch2");
			Reload = CreatePlayerAction("Reload");
			Jump = CreatePlayerAction("Jump");
			Run = CreatePlayerAction("Run");
			Crouch = CreatePlayerAction("Crouch");
			Left = CreatePlayerAction("-Horizontal");
			Right = CreatePlayerAction("Horizontal");
			Up = CreatePlayerAction("Vertical");
			Down = CreatePlayerAction("-Vertical");
			Left2 = CreatePlayerAction("-Mouse X");
			Right2 = CreatePlayerAction("Mouse X");
			Up2 = CreatePlayerAction("Mouse Y");
			Down2 = CreatePlayerAction("-Mouse Y");
			View = CreatePlayerAction("View");
		}

		public static cInput CreateWithDefaultBindings()
		{
			cInput cInput2 = new cInput();
			cInput2.Fire.AddDefaultBinding(InputControlType.RightTrigger);
			cInput2.Fire.AddDefaultBinding(Mouse.LeftButton);
			cInput2.Aim.AddDefaultBinding(InputControlType.LeftTrigger);
			cInput2.Aim.AddDefaultBinding(Mouse.RightButton);
			cInput2.Switch.AddDefaultBinding(InputControlType.Action4);
			cInput2.Switch.AddDefaultBinding(Key.Key2);
			cInput2.Switch.AddDefaultBinding(Mouse.PositiveScrollWheel);
			cInput2.Switch2.AddDefaultBinding(Key.Key1);
			cInput2.Switch2.AddDefaultBinding(Mouse.NegativeScrollWheel);
			cInput2.Reload.AddDefaultBinding(InputControlType.Action3);
			cInput2.Reload.AddDefaultBinding(Key.R);
			cInput2.Run.AddDefaultBinding(InputControlType.LeftStickButton);
			cInput2.Run.AddDefaultBinding(InputControlType.LeftBumper);
			cInput2.Run.AddDefaultBinding(Key.Shift);
			cInput2.Crouch.AddDefaultBinding(InputControlType.Action2);
			cInput2.Crouch.AddDefaultBinding(Key.Control);
			cInput2.Jump.AddDefaultBinding(Key.Space);
			cInput2.Jump.AddDefaultBinding(InputControlType.Action1);
			cInput2.Up.AddDefaultBinding(Key.UpArrow);
			cInput2.Down.AddDefaultBinding(Key.DownArrow);
			cInput2.Left.AddDefaultBinding(Key.LeftArrow);
			cInput2.Right.AddDefaultBinding(Key.RightArrow);
			cInput2.Up.AddDefaultBinding(Key.W);
			cInput2.Down.AddDefaultBinding(Key.S);
			cInput2.Left.AddDefaultBinding(Key.A);
			cInput2.Right.AddDefaultBinding(Key.D);
			cInput2.Left.AddDefaultBinding(InputControlType.LeftStickLeft);
			cInput2.Right.AddDefaultBinding(InputControlType.LeftStickRight);
			cInput2.Up.AddDefaultBinding(InputControlType.LeftStickUp);
			cInput2.Down.AddDefaultBinding(InputControlType.LeftStickDown);
			cInput2.Up2.AddDefaultBinding(Mouse.PositiveY);
			cInput2.Down2.AddDefaultBinding(Mouse.NegativeY);
			cInput2.Left2.AddDefaultBinding(Mouse.NegativeX);
			cInput2.Right2.AddDefaultBinding(Mouse.PositiveX);
			cInput2.Up2.AddDefaultBinding(InputControlType.RightStickUp);
			cInput2.Down2.AddDefaultBinding(InputControlType.RightStickDown);
			cInput2.Left2.AddDefaultBinding(InputControlType.RightStickLeft);
			cInput2.Right2.AddDefaultBinding(InputControlType.RightStickRight);
			cInput2.View.AddDefaultBinding(Key.V);
			cInput2.View.AddDefaultBinding(InputControlType.DPadDown);
			cInput2.ListenOptions.IncludeUnknownControllers = true;
			cInput2.ListenOptions.MaxAllowedBindings = 4u;
			BindingListenOptions bindingListenOptions = cInput2.ListenOptions;
			if (_003C_003Ef__am_0024cache0 == null)
			{
				_003C_003Ef__am_0024cache0 = _003CCreateWithDefaultBindings_003Em__0;
			}
			bindingListenOptions.OnBindingFound = _003C_003Ef__am_0024cache0;
			BindingListenOptions bindingListenOptions2 = cInput2.ListenOptions;
			Action<PlayerAction, BindingSource> onBindingAdded = bindingListenOptions2.OnBindingAdded;
			if (_003C_003Ef__am_0024cache1 == null)
			{
				_003C_003Ef__am_0024cache1 = _003CCreateWithDefaultBindings_003Em__1;
			}
			bindingListenOptions2.OnBindingAdded = (Action<PlayerAction, BindingSource>)Delegate.Combine(onBindingAdded, _003C_003Ef__am_0024cache1);
			BindingListenOptions bindingListenOptions3 = cInput2.ListenOptions;
			Action<PlayerAction, BindingSource, BindingSourceRejectionType> onBindingRejected = bindingListenOptions3.OnBindingRejected;
			if (_003C_003Ef__am_0024cache2 == null)
			{
				_003C_003Ef__am_0024cache2 = _003CCreateWithDefaultBindings_003Em__2;
			}
			bindingListenOptions3.OnBindingRejected = (Action<PlayerAction, BindingSource, BindingSourceRejectionType>)Delegate.Combine(onBindingRejected, _003C_003Ef__am_0024cache2);
			Debug.Log("Binded");
			return cInput2;
		}

		public static bool GetButtonDown(string name)
		{
			bool result = false;
			if (input.GetPlayerActionByName(name).WasPressed)
			{
				result = true;
			}
			return result;
		}

		public static bool GetButton(string name)
		{
			bool flag = false;
			return input.GetPlayerActionByName(name).IsPressed;
		}

		public static bool GetButtonUp(string name)
		{
			bool result = false;
			if (input.GetPlayerActionByName(name).WasReleased)
			{
				result = true;
			}
			return result;
		}

		public static float GetAxis(string name, float multiplier = 1f)
		{
			float num = 0f;
			num = input.GetPlayerActionByName(name).Value;
			num -= input.GetPlayerActionByName("-" + name).Value;
			return num * multiplier;
		}

		public static float GetAxisRaw(string name, float multiplier = 1f)
		{
			float num = 0f;
			num = input.GetPlayerActionByName(name).RawValue;
			num -= input.GetPlayerActionByName("-" + name).RawValue;
			return num * multiplier;
		}

		[CompilerGenerated]
		private static bool _003CCreateWithDefaultBindings_003Em__0(PlayerAction action, BindingSource binding)
		{
			if (binding == new KeyBindingSource(Key.Escape))
			{
				action.StopListeningForBinding();
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private static void _003CCreateWithDefaultBindings_003Em__1(PlayerAction action, BindingSource binding)
		{
			Debug.Log("Binding added... " + binding.DeviceName + ": " + binding.Name);
		}

		[CompilerGenerated]
		private static void _003CCreateWithDefaultBindings_003Em__2(PlayerAction action, BindingSource binding, BindingSourceRejectionType reason)
		{
			Debug.Log("Binding rejected... " + reason);
		}
	}
}
