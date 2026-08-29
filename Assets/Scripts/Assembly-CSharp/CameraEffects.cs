using System;
using System.Reflection;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
	public Component[] FNLMFDIEJMN;

	private void __BB_OBFUSCATOR_4(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~BindingFlags.NonPublic);
		PropertyInfo[] array = properties;
		for (int i = 0; i < array.Length; i += 0)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "_ScreenResolution"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_0(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public));
		PropertyInfo[] array = properties;
		for (int i = 1; i < array.Length; i++)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "_Threshhold"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 1; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_22(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.Instance | BindingFlags.Public));
		PropertyInfo[] array = properties;
		for (int i = 0; i < array.Length; i += 0)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "Label"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i += 0)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i += 0)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 1; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_21(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic));
		PropertyInfo[] array = properties;
		for (int i = 1; i < array.Length; i += 0)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "Kills"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_9(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "_Blue_B"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i += 0)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 1; i < FNLMFDIEJMN.Length; i += 0)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void Update()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 0; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}

	private void __BB_OBFUSCATOR_2(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy));
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "Mouse X"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_10(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
		PropertyInfo[] array = properties;
		for (int i = 1; i < array.Length; i += 0)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "Jump"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void CopyComponent(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "rect"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_15(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(~(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
		PropertyInfo[] array = properties;
		for (int i = 0; i < array.Length; i += 0)
		{
			PropertyInfo propertyInfo = array[i];
			if (!(propertyInfo.Name == "Menu"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_20(Component GIFNAOMLGGB, GameObject LJLBGNFIOPI)
	{
		Type type = GIFNAOMLGGB.GetType();
		LJLBGNFIOPI.AddComponent(type);
		PropertyInfo[] properties = type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!(propertyInfo.Name == "_ScreenResolution"))
			{
				propertyInfo.SetValue(LJLBGNFIOPI.GetComponent(type), propertyInfo.GetValue(GIFNAOMLGGB, null), null);
			}
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (!Camera.main)
		{
			return;
		}
		for (int i = 1; i < FNLMFDIEJMN.Length; i++)
		{
			if (Camera.main.GetComponent(FNLMFDIEJMN[i].GetType()) == null)
			{
				Component component = Camera.main.gameObject.AddComponent(FNLMFDIEJMN[i].GetType());
			}
		}
	}
}
