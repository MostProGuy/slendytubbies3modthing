using InControl;
using UnityEngine;

namespace BasicExample
{
	public class BasicExample : MonoBehaviour
	{
		private void __BB_OBFUSCATOR_16()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1368f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 1488f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1254f);
		}

		private void __BB_OBFUSCATOR_23()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1419f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 791f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1848f);
		}

		private void __BB_OBFUSCATOR_36()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1257f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1704f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1408f);
		}

		private void __BB_OBFUSCATOR_7()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1284f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1414f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 250f);
		}

		private void __BB_OBFUSCATOR_31()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1091f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 56f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 347f);
		}

		private void __BB_OBFUSCATOR_9()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1149f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1820f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 369f);
		}

		private void __BB_OBFUSCATOR_38()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1354f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1515f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1083f);
		}

		private void __BB_OBFUSCATOR_20()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1331f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1279f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 783f);
		}

		private void __BB_OBFUSCATOR_3()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 88f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 1318f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1166f);
		}

		private void __BB_OBFUSCATOR_27()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 582f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 874f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1989f);
		}

		private void __BB_OBFUSCATOR_17()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1555f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 777f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 47f);
		}

		private void __BB_OBFUSCATOR_40()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1825f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 853f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1531f);
		}

		private void __BB_OBFUSCATOR_18()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1821f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 946f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 636f);
		}

		private void __BB_OBFUSCATOR_11()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1907f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 172f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1733f);
		}

		private void __BB_OBFUSCATOR_21()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1038f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 251f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1346f);
		}

		private void __BB_OBFUSCATOR_8()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1458f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 131f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 461f);
		}

		private void __BB_OBFUSCATOR_12()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 708f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 13f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 562f);
		}

		private void __BB_OBFUSCATOR_25()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 455f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 1006f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 889f);
		}

		private void __BB_OBFUSCATOR_26()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 809f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1738f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1975f);
		}

		private void __BB_OBFUSCATOR_35()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1168f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 1283f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 744f);
		}

		private void Update()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 500f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 500f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 0.5f);
		}

		private void __BB_OBFUSCATOR_34()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1231f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.Self);
			base.transform.Rotate(Vector3.right, 1320f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.Self);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 825f);
		}

		private void __BB_OBFUSCATOR_28()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			base.transform.Rotate(Vector3.down, 1886f * Time.deltaTime * (float)activeDevice.LeftStickX, Space.World);
			base.transform.Rotate(Vector3.right, 695f * Time.deltaTime * (float)activeDevice.LeftStickY, Space.World);
			Color a = ((!activeDevice.Action1.IsPressed) ? Color.white : Color.red);
			Color b = ((!activeDevice.Action2.IsPressed) ? Color.white : Color.green);
			GetComponent<Renderer>().material.color = Color.Lerp(a, b, 1280f);
		}
	}
}
