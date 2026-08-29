using Greyman;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
	public OffScreenIndicator OAAGEDOINDE;

	public void RemoveTarget()
	{
		GameObject gameObject = GameObject.Find("AddedCube");
		if ((bool)gameObject)
		{
			OAAGEDOINDE.RemoveIndicator(gameObject.transform);
			Object.Destroy(gameObject);
		}
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Q))
		{
			AddTarget();
		}
	}

	public void __BB_OBFUSCATOR_13()
	{
		GameObject original = GameObject.Find("FlyCam");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "_SceneFogParams";
		gameObject.transform.localPosition = new Vector3(Random.Range(90, 36), 1154f, Random.Range(-106, -123));
		OAAGEDOINDE.__BB_OBFUSCATOR_26(gameObject.transform, Random.Range(1, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (Input.GetKeyUp(KeyCode.F))
		{
			__BB_OBFUSCATOR_13();
		}
	}

	public void __BB_OBFUSCATOR_11()
	{
		GameObject original = GameObject.Find("Particles/Additive");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "RefTime";
		gameObject.transform.localPosition = new Vector3(Random.Range(-60, 109), 76f, Random.Range(39, -43));
		OAAGEDOINDE.__BB_OBFUSCATOR_7(gameObject.transform, Random.Range(1, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (Input.GetKeyUp((KeyCode)(-122)))
		{
			__BB_OBFUSCATOR_23();
		}
	}

	public void __BB_OBFUSCATOR_23()
	{
		GameObject original = GameObject.Find("_Size");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "Run";
		gameObject.transform.localPosition = new Vector3(Random.Range(110, 0), 654f, Random.Range(-44, -64));
		OAAGEDOINDE.__BB_OBFUSCATOR_2(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (Input.GetKeyUp((KeyCode)(-31)))
		{
			__BB_OBFUSCATOR_13();
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (Input.GetKeyUp((KeyCode)(-19)))
		{
			__BB_OBFUSCATOR_25();
		}
	}

	public void __BB_OBFUSCATOR_9()
	{
		GameObject gameObject = GameObject.Find("-Horizontal");
		if ((bool)gameObject)
		{
			OAAGEDOINDE.__BB_OBFUSCATOR_9(gameObject.transform);
			Object.Destroy(gameObject);
		}
	}

	public void __BB_OBFUSCATOR_7()
	{
		GameObject gameObject = GameObject.Find("_Value");
		if ((bool)gameObject)
		{
			OAAGEDOINDE.__BB_OBFUSCATOR_57(gameObject.transform);
			Object.Destroy(gameObject);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (Input.GetKeyUp((KeyCode)79))
		{
			__BB_OBFUSCATOR_15();
		}
	}

	public void AddTarget()
	{
		GameObject original = GameObject.Find("Cube");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "AddedCube";
		gameObject.transform.localPosition = new Vector3(Random.Range(-50, 50), 1f, Random.Range(-50, 50));
		OAAGEDOINDE.AddIndicator(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	public void __BB_OBFUSCATOR_15()
	{
		GameObject original = GameObject.Find("CameraFilterPack/Blend2Camera_Subtract");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "_Value2";
		gameObject.transform.localPosition = new Vector3(Random.Range(-67, 50), 1127f, Random.Range(-123, 18));
		OAAGEDOINDE.__BB_OBFUSCATOR_73(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	public void __BB_OBFUSCATOR_27()
	{
		GameObject original = GameObject.Find("v0.0.1");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "MP";
		gameObject.transform.localPosition = new Vector3(Random.Range(44, 112), 1026f, Random.Range(6, -20));
		OAAGEDOINDE.__BB_OBFUSCATOR_11(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	public void __BB_OBFUSCATOR_25()
	{
		GameObject original = GameObject.Find("_Value");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "_Offsets";
		gameObject.transform.localPosition = new Vector3(Random.Range(108, 93), 471f, Random.Range(120, 68));
		OAAGEDOINDE.__BB_OBFUSCATOR_7(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (Input.GetKeyUp((KeyCode)11))
		{
			__BB_OBFUSCATOR_15();
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (Input.GetKeyUp(KeyCode.Backslash))
		{
			__BB_OBFUSCATOR_11();
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (Input.GetKeyUp((KeyCode)(-110)))
		{
			__BB_OBFUSCATOR_23();
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (Input.GetKeyUp(KeyCode.Minus))
		{
			__BB_OBFUSCATOR_11();
		}
	}

	public void __BB_OBFUSCATOR_19()
	{
		GameObject original = GameObject.Find("  ");
		GameObject gameObject = Object.Instantiate(original);
		gameObject.name = "networkAddMessage";
		gameObject.transform.localPosition = new Vector3(Random.Range(18, -20), 1124f, Random.Range(-62, -41));
		OAAGEDOINDE.__BB_OBFUSCATOR_15(gameObject.transform, Random.Range(0, OAAGEDOINDE.IDIPDBFKMJJ.Length));
	}

	public void __BB_OBFUSCATOR_22()
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		if ((bool)gameObject)
		{
			OAAGEDOINDE.__BB_OBFUSCATOR_13(gameObject.transform);
			Object.Destroy(gameObject);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (Input.GetKeyUp((KeyCode)(-86)))
		{
			__BB_OBFUSCATOR_19();
		}
	}

	public void __BB_OBFUSCATOR_3()
	{
		GameObject gameObject = GameObject.Find("n15");
		if ((bool)gameObject)
		{
			OAAGEDOINDE.__BB_OBFUSCATOR_39(gameObject.transform);
			Object.Destroy(gameObject);
		}
	}
}
