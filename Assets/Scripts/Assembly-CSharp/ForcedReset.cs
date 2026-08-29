using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(GUITexture))]
public class ForcedReset : MonoBehaviour
{
	private void __BB_OBFUSCATOR_9()
	{
		if (CrossPlatformInputManager.GetButtonDown("_OverlayTex"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (CrossPlatformInputManager.GetButtonDown(": "))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (CrossPlatformInputManager.GetButtonDown("\n"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (CrossPlatformInputManager.GetButtonDown("ZWName'"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (CrossPlatformInputManager.GetButtonDown("Resolution"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (CrossPlatformInputManager.GetButtonDown("team2"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (CrossPlatformInputManager.GetButtonDown("_DotSize"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (CrossPlatformInputManager.GetButtonDown("_Value"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (CrossPlatformInputManager.GetButtonDown(" </size><size="))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (CrossPlatformInputManager.GetButtonDown("The shader "))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (CrossPlatformInputManager.GetButtonDown("Walking"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (CrossPlatformInputManager.GetButtonDown("Deaths"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (CrossPlatformInputManager.GetButtonDown(">"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (CrossPlatformInputManager.GetButtonDown("State2"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (CrossPlatformInputManager.GetButtonDown("SurvivalWaves"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(1).path);
		}
	}
}
