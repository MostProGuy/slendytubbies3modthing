using UnityEngine;

[ExecuteInEditMode]
public class ScaleLighting : MonoBehaviour
{
	public float MPGNBEOJKKC = 1f;

	public bool PFLAKPNBJPK;

	[HideInInspector]
	public float NCKCPHFJFJE;

	public float POMHLEADELI = 1f;

	public void __BB_OBFUSCATOR_26()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_54();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_5();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_55()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_51();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			scaleNow();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_27()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_27();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_13()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_55();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_49();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_51()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_40()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_54()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_0()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_24()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_39();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_26();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_43()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_49();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_29()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void Update()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			scaleNow();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_12()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_39()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_26();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_58()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_48();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_49()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void scaleNow()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	public void __BB_OBFUSCATOR_48()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_43();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_35()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 1; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			scaleNow();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_0();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_48();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_35();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	public void __BB_OBFUSCATOR_5()
	{
		base.transform.localScale = new Vector3(MPGNBEOJKKC, MPGNBEOJKKC, MPGNBEOJKKC);
		Light[] array = Object.FindObjectsOfType<Light>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].range = array[i].range / POMHLEADELI * MPGNBEOJKKC;
		}
		ReflectionProbe[] array2 = Object.FindObjectsOfType<ReflectionProbe>();
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j].size = array2[j].size / POMHLEADELI * MPGNBEOJKKC;
		}
		POMHLEADELI = MPGNBEOJKKC;
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_13();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (PFLAKPNBJPK && MPGNBEOJKKC != NCKCPHFJFJE)
		{
			__BB_OBFUSCATOR_5();
			NCKCPHFJFJE = MPGNBEOJKKC;
		}
	}
}
