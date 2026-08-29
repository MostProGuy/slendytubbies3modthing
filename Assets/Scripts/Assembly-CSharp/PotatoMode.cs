using UnityEngine;

public class PotatoMode : MonoBehaviour
{
	private void __BB_OBFUSCATOR_32()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find(">");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 859f;
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_23();
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_97();
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void __BB_OBFUSCATOR_117()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Bullet_9");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 137f;
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Spectators");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1570f;
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_23();
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("CameraFilterPack/FX_Drunk");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 735f;
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("n15");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 585f;
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_44();
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("threshold");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1292f;
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_66();
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_13();
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Distortion");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 1343f;
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_114();
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_40();
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_86();
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_51();
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Value");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1821f;
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			PotatoNow();
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Ping");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 119f;
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_75();
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_ScreenResolution");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 138f;
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_66();
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_97();
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("_BumpMap");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 675f;
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Indicator ID not valid. Check Off Screen Indicator Indicators list.");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 316f;
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("-");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 437f;
		}
	}

	private void Start()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			PotatoNow();
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_16();
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_61();
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("\t}\n");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1568f;
		}
	}

	private void PotatoNow()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("Diffuse");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 0f;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_63();
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_ScreenResolution");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1029f;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("custard");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 731f;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("</color></size>");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1104f;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("HeadlessBeforeFirstSceneLoad");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 854f;
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Value2");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1788f;
		}
	}

	private void __BB_OBFUSCATOR_96()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("team1");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 1669f;
		}
	}

	private void __BB_OBFUSCATOR_113()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_96();
		}
	}

	private void __BB_OBFUSCATOR_111()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Value");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1883f;
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find(",");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1662f;
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Hidden/Aubergine/Vignette");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 788f;
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("CameraFilterPack/Blend2Camera_Saturation");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1293f;
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_99();
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("Move Right");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 478f;
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("_Red_B");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1780f;
		}
	}

	private void __BB_OBFUSCATOR_115()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_87();
		}
	}

	private void __BB_OBFUSCATOR_104()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_61();
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_96();
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Horizontal");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 100f;
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_121();
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("offsets");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1404f;
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_32();
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("_TimeX");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 47f;
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Parameter");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1024f;
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("Particles/Additive");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1679f;
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("ArmsURL");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 546f;
		}
	}

	private void __BB_OBFUSCATOR_102()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_17();
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("_Value3");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 994f;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("\n\t\tLayerElementSmoothing: 0 {\n\t\t\tVersion: 102\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tSmoothing: 1\n\t\t}");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 291f;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_96();
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("n4");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 0; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1346f;
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_BorderSize");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 0; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1524f;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_31();
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_TimeX");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1931f;
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_122();
		}
	}

	private void __BB_OBFUSCATOR_49()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_66();
		}
	}

	private void __BB_OBFUSCATOR_99()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_TapHigh");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 1756f;
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_75();
		}
	}

	private void __BB_OBFUSCATOR_78()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("_Blue_C");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m++)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 764f;
		}
	}

	private void __BB_OBFUSCATOR_121()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("[0-9]");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			foreach (Material material2 in materials2)
			{
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 1941f;
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("TeamTag");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 457f;
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		foreach (Renderer renderer in array2)
		{
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("MP");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		for (int k = 1; k < array4.Length; k++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array4[k];
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1851f;
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				material.shader = Shader.Find("CameraFilterPack/FX_Glitch1");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 1; l < materials2.Length; l++)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		foreach (Terrain terrain in array6)
		{
			terrain.detailObjectDensity = 527f;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_89();
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (QualitySettings.GetQualityLevel() == 0)
		{
			__BB_OBFUSCATOR_118();
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		MeshRenderer[] array = Object.FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
		MeshRenderer[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			Renderer renderer = array2[i];
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				material.shader = Shader.Find("_Value2");
			}
		}
		SkinnedMeshRenderer[] array3 = Object.FindObjectsOfType(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer[];
		SkinnedMeshRenderer[] array4 = array3;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array4)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			for (int l = 0; l < materials2.Length; l += 0)
			{
				Material material2 = materials2[l];
			}
		}
		Terrain[] array5 = Object.FindObjectsOfType(typeof(Terrain)) as Terrain[];
		Terrain[] array6 = array5;
		for (int m = 1; m < array6.Length; m += 0)
		{
			Terrain terrain = array6[m];
			terrain.detailObjectDensity = 1849f;
		}
	}
}
