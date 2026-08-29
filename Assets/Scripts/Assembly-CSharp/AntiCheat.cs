using System.Diagnostics;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

public class AntiCheat : MonoBehaviour
{
	private void __BB_OBFUSCATOR_53()
	{
		MonoBehaviour.print(", phase = ");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_64()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_86);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_43);
		__BB_OBFUSCATOR_58();
	}

	private void __BB_OBFUSCATOR_10()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_7);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_71);
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_44()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_52);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_77);
		CheckCheatEngine();
	}

	private void __BB_OBFUSCATOR_71()
	{
		MonoBehaviour.print("_Value4");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_23()
	{
		MonoBehaviour.print(", ");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_58()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("_Value") && process.ProcessName.ToLower().Contains("_MainTex2"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_40);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_36);
		__BB_OBFUSCATOR_79();
	}

	private void __BB_OBFUSCATOR_11()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_2);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_66);
		__BB_OBFUSCATOR_39();
	}

	private void __BB_OBFUSCATOR_2()
	{
		MonoBehaviour.print("Vertical");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_25()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 1; i < processes.Length; i += 0)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("Jump") && process.ProcessName.ToLower().Contains("<size="))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		MonoBehaviour.print("_Distortion");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_1()
	{
		MonoBehaviour.print("_Value4");
		Application.Quit();
	}

	private void OnSpeedHackDetected()
	{
		MonoBehaviour.print("ERROR");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_17()
	{
		SpeedHackDetector.StartDetection(OnSpeedHackDetected);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_14);
		__BB_OBFUSCATOR_79();
	}

	private void __BB_OBFUSCATOR_68()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_78);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_77);
		__BB_OBFUSCATOR_85();
	}

	private void __BB_OBFUSCATOR_31()
	{
		MonoBehaviour.print("Vertical");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_63()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_86);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_14);
		__BB_OBFUSCATOR_39();
	}

	private void __BB_OBFUSCATOR_81()
	{
		MonoBehaviour.print("MP");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_34()
	{
		MonoBehaviour.print("\n\t\tLayerElementMaterial: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tMaterials: ");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_41()
	{
		MonoBehaviour.print("HeatDistort");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_76()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i += 0)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("Mouse Y") && process.ProcessName.ToLower().Contains("CameraFilterPack/Blur_Radial_Fast"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		MonoBehaviour.print("_ScreenResolution");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_73()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_29);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_66);
		__BB_OBFUSCATOR_79();
	}

	private void __BB_OBFUSCATOR_18()
	{
		MonoBehaviour.print("_TintColor");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_83()
	{
		SpeedHackDetector.StartDetection(OnSpeedHackDetected);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_77);
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_52()
	{
		MonoBehaviour.print("_Value4");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_54()
	{
		MonoBehaviour.print("_DepthFade");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_39()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 1; i < processes.Length; i++)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("_FadeFX") && process.ProcessName.ToLower().Contains("HeadURL"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("TakeIn") && process.ProcessName.ToLower().Contains("_Blue_B"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("CameraFilterPack/VHS_Tracking") && process.ProcessName.ToLower().Contains("\"Model\""))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		MonoBehaviour.print("_TimeX");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_14()
	{
		MonoBehaviour.print("_TimeX");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_69()
	{
		MonoBehaviour.print("Deaths");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_67()
	{
		MonoBehaviour.print("SmokeA");
		Application.Quit();
	}

	private void CheckCheatEngine()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("cheat") && process.ProcessName.ToLower().Contains("engine"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		MonoBehaviour.print("\n\t\tLayerElementUV: 1 {\n\t\t\tVersion: 101\n\t\t\tName: \"UVMap_2\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tUV: ");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_56()
	{
		MonoBehaviour.print("B");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_74()
	{
		MonoBehaviour.print("SwearFilter");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_26()
	{
		MonoBehaviour.print("_Value3");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_55()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 1; i < processes.Length; i++)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("_SunColor") && process.ProcessName.ToLower().Contains("_Value"))
			{
				Application.Quit();
			}
		}
	}

	private void OnObscuredCheatingDetected()
	{
		MonoBehaviour.print("ERROR");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_9()
	{
		MonoBehaviour.print("SUR");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_88()
	{
		MonoBehaviour.print("_NormalOffsetScale");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_0()
	{
		MonoBehaviour.print("CameraFilterPack/Blend2Camera_DarkerColor");
		Application.Quit();
	}

	private void OnInjectionDetected()
	{
		MonoBehaviour.print("ERROR");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_51()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_31);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_53);
		__BB_OBFUSCATOR_58();
	}

	private void __BB_OBFUSCATOR_7()
	{
		MonoBehaviour.print("<size=");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_36()
	{
		MonoBehaviour.print("SyncShopID");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_42()
	{
		MonoBehaviour.print("_Value");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_75()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_52);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_53);
		__BB_OBFUSCATOR_79();
	}

	private void __BB_OBFUSCATOR_15()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_9);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_71);
		__BB_OBFUSCATOR_55();
	}

	private void __BB_OBFUSCATOR_21()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_0);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_36);
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_61()
	{
		MonoBehaviour.print("CameraFilterPack/Blizzard");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_66()
	{
		MonoBehaviour.print("_ForegroundBlurExtrude");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_13()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_59);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_60);
		__BB_OBFUSCATOR_58();
	}

	private void Start()
	{
		SpeedHackDetector.StartDetection(OnSpeedHackDetected);
		ObscuredCheatingDetector.StartDetection(OnObscuredCheatingDetected);
		CheckCheatEngine();
	}

	private void __BB_OBFUSCATOR_72()
	{
		MonoBehaviour.print("SUR");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_3()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_52);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_14);
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_32()
	{
		MonoBehaviour.print("_Value");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_79()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 1; i < processes.Length; i += 0)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("\r\n|\r|\n") && process.ProcessName.ToLower().Contains("Custards"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		MonoBehaviour.print("_ScreenResolution");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_35()
	{
		MonoBehaviour.print("_NoiseTilingPerChannel");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_78()
	{
		MonoBehaviour.print("_CutTex");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_49()
	{
		MonoBehaviour.print("Label");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_24()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_2);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_66);
		__BB_OBFUSCATOR_76();
	}

	private void __BB_OBFUSCATOR_85()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("Default") && process.ProcessName.ToLower().Contains("ns.exitgames.com"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		MonoBehaviour.print("Make sure to set the collision layers to the layers the camera should collide with!");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_29()
	{
		MonoBehaviour.print("100");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_59()
	{
		MonoBehaviour.print("P - Fullscreen");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_47()
	{
		SpeedHackDetector.StartDetection(__BB_OBFUSCATOR_29);
		ObscuredCheatingDetector.StartDetection(__BB_OBFUSCATOR_84);
		__BB_OBFUSCATOR_27();
	}

	private void __BB_OBFUSCATOR_46()
	{
		MonoBehaviour.print(",");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_43()
	{
		MonoBehaviour.print("_RGB");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_86()
	{
		MonoBehaviour.print("We disconencted from Photon Cloud");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_40()
	{
		MonoBehaviour.print("_Intensity");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_57()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i += 0)
		{
			Process process = processes[i];
			if (process.ProcessName.ToLower().Contains("CameraFilterPack/Retro_Loading") && process.ProcessName.ToLower().Contains("_NoisePerChannel"))
			{
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		MonoBehaviour.print(" min");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_30()
	{
		MonoBehaviour.print("Press a button or a/s/d/f key to join!");
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_28()
	{
		MonoBehaviour.print("CameraFilterPack/Edge_Sigmoid");
		Application.Quit();
	}
}
