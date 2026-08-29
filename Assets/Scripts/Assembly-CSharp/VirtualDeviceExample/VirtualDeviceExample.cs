using System.Runtime.CompilerServices;
using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	public class VirtualDeviceExample : MonoBehaviour
	{
		public GameObject JLNHDJBJCFG;

		public GameObject EIGGMLJIEAC;

		private AMBLPLHGKBM DEOHECOFDDH;

		private void __BB_OBFUSCATOR_10()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1416f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 1887f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1755f * Time.deltaTime * (float)activeDevice.RightStickX, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 1972f * Time.deltaTime * (float)activeDevice.RightStickY, Space.Self);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_12()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_5()
		{
			DEOHECOFDDH = new AMBLPLHGKBM();
			InputManager.OnSetup += _003COnEnable_003Em__0;
		}

		private void __BB_OBFUSCATOR_21()
		{
			InputManager.DetachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_3()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 351f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 1539f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1853f * Time.deltaTime * (float)activeDevice.RightStickX, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 50f * Time.deltaTime * (float)activeDevice.RightStickY, Space.World);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_20()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1962f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 592f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 189f * Time.deltaTime * (float)activeDevice.RightStickX, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 1629f * Time.deltaTime * (float)activeDevice.RightStickY, Space.Self);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_19()
		{
			InputManager.DetachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_2()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_7()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1568f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 972f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 430f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 23f * Time.deltaTime * (float)activeDevice.RightStickY, Space.World);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_18()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_9()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1662f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 1826f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1019f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 1894f * Time.deltaTime * (float)activeDevice.RightStickY, Space.World);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_0()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 749f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 795f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 739f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 1905f * Time.deltaTime * (float)activeDevice.RightStickY, Space.Self);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void OnEnable()
		{
			DEOHECOFDDH = new AMBLPLHGKBM();
			InputManager.OnSetup += _003COnEnable_003Em__0;
		}

		private void __BB_OBFUSCATOR_6()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1651f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 985f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1114f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 660f * Time.deltaTime * (float)activeDevice.RightStickY, Space.Self);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_23()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		[CompilerGenerated]
		private void _003COnEnable_003Em__0()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_1()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1218f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 998f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1654f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 768f * Time.deltaTime * (float)activeDevice.RightStickY, Space.World);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_4()
		{
			InputManager.AttachDevice(DEOHECOFDDH);
		}

		private void Update()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 500f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 500f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 500f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 500f * Time.deltaTime * (float)activeDevice.RightStickY, Space.World);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}

		private void __BB_OBFUSCATOR_13()
		{
			DEOHECOFDDH = new AMBLPLHGKBM();
			InputManager.OnSetup += _003COnEnable_003Em__0;
		}

		private void OnDisable()
		{
			InputManager.DetachDevice(DEOHECOFDDH);
		}

		private void __BB_OBFUSCATOR_15()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			JLNHDJBJCFG.transform.Rotate(Vector3.down, 1945f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			JLNHDJBJCFG.transform.Rotate(Vector3.right, 1898f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			EIGGMLJIEAC.transform.Rotate(Vector3.down, 1291f * Time.deltaTime * (float)activeDevice.RightStickX, Space.World);
			EIGGMLJIEAC.transform.Rotate(Vector3.right, 67f * Time.deltaTime * (float)activeDevice.RightStickY, Space.Self);
			Color color = Color.white;
			if (activeDevice.Action1.IsPressed)
			{
				color = Color.green;
			}
			if (activeDevice.Action2.IsPressed)
			{
				color = Color.red;
			}
			if (activeDevice.Action3.IsPressed)
			{
				color = Color.blue;
			}
			if (activeDevice.Action4.IsPressed)
			{
				color = Color.yellow;
			}
			JLNHDJBJCFG.GetComponent<Renderer>().material.color = color;
		}
	}
}
