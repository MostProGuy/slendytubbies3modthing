using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("")]
public class PostProcessBase : MonoBehaviour
{
	public Shader BNLDNPPEODB;

	private Material HDNJALGDPNF;

	protected Material MFOLDHOAMNN
	{
		get
		{
			if (HDNJALGDPNF == null)
			{
				HDNJALGDPNF = new Material(BNLDNPPEODB);
				HDNJALGDPNF.hideFlags = HideFlags.HideAndDontSave;
			}
			return HDNJALGDPNF;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_8()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_102()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_38()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_127()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_84()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-89);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_79()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_50()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_30()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_61()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_12()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)122;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_120()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_96()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_19()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_101()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_83()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_70()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-85);
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_6()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)85;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_35()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_26()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_75()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_44()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void OnDisable()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_11()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_39()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)73;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_98()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_74()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_119()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_124()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)89;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_108()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_2()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_36()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_62()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_86()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_41()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_82()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_99()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_97()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_78()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_43()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-76);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_114()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_80()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_68()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_125()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_16()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_113()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_111()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_93()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_52()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)79;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_58()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_25()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_7()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_33()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)69;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_110()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_46()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_88()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_95()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_56()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_116()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-93);
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_109()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_103()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_117()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_66()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_57()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_47()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_94()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_0()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_106()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_87()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_104()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_71()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_85()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-101);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_18()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_37()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_27()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_126()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-80);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_105()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_40()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	protected void __BB_OBFUSCATOR_42()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_100()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)68;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_17()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_55()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_115()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_9()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void __BB_OBFUSCATOR_45()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void __BB_OBFUSCATOR_63()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_3()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)88;
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_77()
	{
		if ((bool)HDNJALGDPNF)
		{
			Object.DestroyImmediate(HDNJALGDPNF);
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_23()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_122()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)119;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_69()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_65()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_54()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)(-117);
		}
		return HDNJALGDPNF;
	}

	protected void __BB_OBFUSCATOR_13()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!BNLDNPPEODB || !BNLDNPPEODB.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_91()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = (HideFlags)95;
		}
		return HDNJALGDPNF;
	}

	[SpecialName]
	protected Material __BB_OBFUSCATOR_28()
	{
		if (HDNJALGDPNF == null)
		{
			HDNJALGDPNF = new Material(BNLDNPPEODB);
			HDNJALGDPNF.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return HDNJALGDPNF;
	}
}
