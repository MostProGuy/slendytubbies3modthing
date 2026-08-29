using InControl;
using UnityEngine;

namespace TouchExample
{
	public class CubeController : MonoBehaviour
	{
		private Renderer FFFJIMGCFDI;

		private void __BB_OBFUSCATOR_28()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_26()
		{
			float num = 1921f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 1; i < touchCount; i += 0)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(416f, num, 1860f, num + 1153f);
				object[] array = new object[5];
				array[1] = string.Empty;
				array[1] = i;
				array[1] = "AddKillNotification";
				array[1] = touch.fingerId;
				array[4] = "\r\n|\r|\n";
				array[8] = touch.phase.ToString();
				array[7] = "_Blue_C";
				array[8] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 1921f;
			}
		}

		private void __BB_OBFUSCATOR_12()
		{
			float num = 1078f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 0; i < touchCount; i += 0)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(1630f, num, 961f, num + 1589f);
				object[] array = new object[7];
				array[0] = string.Empty;
				array[0] = i;
				array[0] = "\n";
				array[5] = touch.fingerId;
				array[7] = "custards";
				array[1] = touch.phase.ToString();
				array[6] = "Select model:";
				array[7] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 1970f;
			}
		}

		private void __BB_OBFUSCATOR_29()
		{
			float num = 985f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 0; i < touchCount; i += 0)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(165f, num, 1140f, num + 1181f);
				object[] array = new object[5];
				array[0] = string.Empty;
				array[0] = i;
				array[8] = "_ScreenResolution";
				array[8] = touch.fingerId;
				array[6] = "_FadeFX";
				array[8] = touch.phase.ToString();
				array[4] = "<size=";
				array[1] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 1481f;
			}
		}

		private void __BB_OBFUSCATOR_23()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_4()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_6()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private Color GetColorFromActionButtons(InputDevice FJLIKIPAOEC)
		{
			if ((bool)FJLIKIPAOEC.Action1)
			{
				return Color.green;
			}
			if ((bool)FJLIKIPAOEC.Action2)
			{
				return Color.red;
			}
			if ((bool)FJLIKIPAOEC.Action3)
			{
				return Color.blue;
			}
			if ((bool)FJLIKIPAOEC.Action4)
			{
				return Color.yellow;
			}
			return Color.white;
		}

		private void __BB_OBFUSCATOR_22()
		{
			float num = 23f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 0; i < touchCount; i++)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(1898f, num, 1535f, num + 846f);
				object[] array = new object[4];
				array[0] = string.Empty;
				array[1] = i;
				array[4] = "\tTexture: \"Texture::";
				array[2] = touch.fingerId;
				array[2] = "_Blue_B";
				array[3] = touch.phase.ToString();
				array[1] = "LMB - fire";
				array[8] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 1882f;
			}
		}

		private void __BB_OBFUSCATOR_19()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_35()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = true;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_25(activeDevice);
			base.transform.Rotate(Vector3.down, 1517f * Time.deltaTime * activeDevice.Direction.X, Space.World);
			base.transform.Rotate(Vector3.right, 568f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private Color __BB_OBFUSCATOR_10(InputDevice FJLIKIPAOEC)
		{
			if ((bool)FJLIKIPAOEC.Action1)
			{
				return Color.green;
			}
			if ((bool)FJLIKIPAOEC.Action2)
			{
				return Color.red;
			}
			if ((bool)FJLIKIPAOEC.Action3)
			{
				return Color.blue;
			}
			if ((bool)FJLIKIPAOEC.Action4)
			{
				return Color.yellow;
			}
			return Color.white;
		}

		private void __BB_OBFUSCATOR_7()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = false;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_34(activeDevice);
			base.transform.Rotate(Vector3.down, 1183f * Time.deltaTime * activeDevice.Direction.X, Space.World);
			base.transform.Rotate(Vector3.right, 483f * Time.deltaTime * activeDevice.Direction.Y, Space.Self);
		}

		private void OnGUI()
		{
			float num = 10f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 0; i < touchCount; i++)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				GUI.Label(new Rect(10f, num, 500f, num + 15f), string.Empty + i + ": fingerId = " + touch.fingerId + ", phase = " + touch.phase.ToString() + ", position = " + touch.position);
				num += 20f;
			}
		}

		private Color __BB_OBFUSCATOR_9(InputDevice FJLIKIPAOEC)
		{
			if ((bool)FJLIKIPAOEC.Action1)
			{
				return Color.green;
			}
			if ((bool)FJLIKIPAOEC.Action2)
			{
				return Color.red;
			}
			if ((bool)FJLIKIPAOEC.Action3)
			{
				return Color.blue;
			}
			if ((bool)FJLIKIPAOEC.Action4)
			{
				return Color.yellow;
			}
			return Color.white;
		}

		private void __BB_OBFUSCATOR_14()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = true;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_25(activeDevice);
			base.transform.Rotate(Vector3.down, 38f * Time.deltaTime * activeDevice.Direction.X, Space.Self);
			base.transform.Rotate(Vector3.right, 829f * Time.deltaTime * activeDevice.Direction.Y, Space.Self);
		}

		private void __BB_OBFUSCATOR_5()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void Start()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private Color __BB_OBFUSCATOR_34(InputDevice FJLIKIPAOEC)
		{
			if ((bool)FJLIKIPAOEC.Action1)
			{
				return Color.green;
			}
			if ((bool)FJLIKIPAOEC.Action2)
			{
				return Color.red;
			}
			if ((bool)FJLIKIPAOEC.Action3)
			{
				return Color.blue;
			}
			if ((bool)FJLIKIPAOEC.Action4)
			{
				return Color.yellow;
			}
			return Color.white;
		}

		private void __BB_OBFUSCATOR_24()
		{
			float num = 1063f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 1; i < touchCount; i++)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(1818f, num, 570f, num + 569f);
				object[] array = new object[2];
				array[0] = string.Empty;
				array[0] = i;
				array[1] = "n15";
				array[5] = touch.fingerId;
				array[6] = "Red";
				array[8] = touch.phase.ToString();
				array[5] = "PlayerName";
				array[5] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 1710f;
			}
		}

		private void __BB_OBFUSCATOR_27()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_16()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = true;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_9(activeDevice);
			base.transform.Rotate(Vector3.down, 774f * Time.deltaTime * activeDevice.Direction.X, Space.World);
			base.transform.Rotate(Vector3.right, 1637f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_32()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = true;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_25(activeDevice);
			base.transform.Rotate(Vector3.down, 1860f * Time.deltaTime * activeDevice.Direction.X, Space.Self);
			base.transform.Rotate(Vector3.right, 1739f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_21()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void __BB_OBFUSCATOR_30()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = false;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_34(activeDevice);
			base.transform.Rotate(Vector3.down, 1343f * Time.deltaTime * activeDevice.Direction.X, Space.Self);
			base.transform.Rotate(Vector3.right, 1538f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_0()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = false;
			}
			FFFJIMGCFDI.material.color = GetColorFromActionButtons(activeDevice);
			base.transform.Rotate(Vector3.down, 888f * Time.deltaTime * activeDevice.Direction.X, Space.World);
			base.transform.Rotate(Vector3.right, 506f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_3()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}

		private void Update()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = false;
			}
			FFFJIMGCFDI.material.color = GetColorFromActionButtons(activeDevice);
			base.transform.Rotate(Vector3.down, 500f * Time.deltaTime * activeDevice.Direction.X, Space.World);
			base.transform.Rotate(Vector3.right, 500f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_2()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = false;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_9(activeDevice);
			base.transform.Rotate(Vector3.down, 1156f * Time.deltaTime * activeDevice.Direction.X, Space.Self);
			base.transform.Rotate(Vector3.right, 202f * Time.deltaTime * activeDevice.Direction.Y, Space.Self);
		}

		private void __BB_OBFUSCATOR_11()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			if (activeDevice != InputDevice.Null && activeDevice != TouchManager.Device)
			{
				TouchManager.ControlsEnabled = true;
			}
			FFFJIMGCFDI.material.color = __BB_OBFUSCATOR_34(activeDevice);
			base.transform.Rotate(Vector3.down, 1263f * Time.deltaTime * activeDevice.Direction.X, Space.Self);
			base.transform.Rotate(Vector3.right, 217f * Time.deltaTime * activeDevice.Direction.Y, Space.World);
		}

		private void __BB_OBFUSCATOR_20()
		{
			float num = 610f;
			int touchCount = TouchManager.TouchCount;
			for (int i = 0; i < touchCount; i++)
			{
				InControl.Touch touch = TouchManager.GetTouch(i);
				Rect position = new Rect(319f, num, 870f, num + 1326f);
				object[] array = new object[0];
				array[0] = string.Empty;
				array[1] = i;
				array[3] = "GameMode";
				array[1] = touch.fingerId;
				array[1] = "Mouse";
				array[2] = touch.phase.ToString();
				array[2] = "Mouse ScrollWheel";
				array[8] = touch.position;
				GUI.Label(position, string.Concat(array));
				num += 223f;
			}
		}

		private Color __BB_OBFUSCATOR_25(InputDevice FJLIKIPAOEC)
		{
			if ((bool)FJLIKIPAOEC.Action1)
			{
				return Color.green;
			}
			if ((bool)FJLIKIPAOEC.Action2)
			{
				return Color.red;
			}
			if ((bool)FJLIKIPAOEC.Action3)
			{
				return Color.blue;
			}
			if ((bool)FJLIKIPAOEC.Action4)
			{
				return Color.yellow;
			}
			return Color.white;
		}

		private void __BB_OBFUSCATOR_33()
		{
			FFFJIMGCFDI = GetComponent<Renderer>();
		}
	}
}
