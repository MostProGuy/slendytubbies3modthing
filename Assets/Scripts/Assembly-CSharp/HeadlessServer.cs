using System.Collections;
using System.IO;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

public class HeadlessServer : Photon.MonoBehaviour
{
	private string[] JLLAFBHKDMM;

	private bool EMLAJGMNLKK;

	private float DJJAALCLLNC;

	private IEnumerator __BB_OBFUSCATOR_86(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator __BB_OBFUSCATOR_98(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_40()
	{
		StartCoroutine(__BB_OBFUSCATOR_44((string)PhotonNetwork.room.customProperties[","]));
	}

	private IEnumerator __BB_OBFUSCATOR_52(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_85()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_ScreenResolution");
		JLLAFBHKDMM = text.Split("n6"[1]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[0];
		array[1] = "\t}\n"[1];
		UnityEngine.MonoBehaviour.print("</size>" + obj.Split(array)[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[1];
		array2[1] = "Diffuse"[1];
		UnityEngine.MonoBehaviour.print("controller2" + obj2.Split(array2)[0]);
		UnityEngine.MonoBehaviour.print("_ColorLevel" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("Horizontal" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("SBX" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("n4" + JLLAFBHKDMM[8]);
		ObscuredPrefs.SetString("PlayerType'", JLLAFBHKDMM[0].Split("CameraFilterPack/Gradients_Rainbow"[1])[0]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[0] = "8"[1];
		ObscuredPrefs.SetString("deselectWeapon", obj3.Split(array3)[1]);
		ObscuredPrefs.SetString("_TimeX", "Missing shader in ");
		ObscuredPrefs.SetBool("SwearFilter", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_50()
	{
		float num = 412f;
		float num2 = 994f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != 0)
				{
					UnityEngine.MonoBehaviour.print("_ScreenResolution");
					PhotonNetwork.ConnectUsingSettings("TeamTag");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1396f * Time.deltaTime;
			if (!(DJJAALCLLNC < 985f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		float num = 1042f;
		float num2 = 438f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)6 && PhotonNetwork.connectionState != 0)
				{
					UnityEngine.MonoBehaviour.print("_NoiseTex");
					PhotonNetwork.ConnectUsingSettings("V");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1125f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1458f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		UnityEngine.MonoBehaviour.print("_ChromaticAberration");
		PhotonNetwork.playerName = " <>__TranspIdent0 = ";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_ScreenResolution"] = JLLAFBHKDMM[8];
		hashtable["GameMode"] = 135;
		hashtable["_ScreenResolution"] = JLLAFBHKDMM[3];
		hashtable["_FoamContrast"] = 114;
		hashtable["_Red_R"] = 0;
		hashtable["Simplifying mesh: "] = 0;
		string[] array = new string[8];
		array[0] = "syncKnife";
		array[1] = "HostQuit";
		array[0] = "Label";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[3]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_69(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_60()
	{
		float num = 1831f;
		float num2 = 486f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)7 && PhotonNetwork.connectionState != 0)
				{
					UnityEngine.MonoBehaviour.print("_Value4");
					PhotonNetwork.ConnectUsingSettings("_Bullet_3");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 186f * Time.deltaTime;
			if (!(DJJAALCLLNC < 275f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		float num = 1396f;
		float num2 = 1620f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					UnityEngine.MonoBehaviour.print("_Value");
					PhotonNetwork.ConnectUsingSettings("TeamASpawn");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1580f * Time.deltaTime;
			if (!(DJJAALCLLNC < 374f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		float num = 1040f;
		float num2 = 1211f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Disconnecting && PhotonNetwork.connectionState != ConnectionState.Connected)
				{
					UnityEngine.MonoBehaviour.print(",");
					PhotonNetwork.ConnectUsingSettings("Sell");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1002f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1853f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private IEnumerator LoadMap(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_45()
	{
		UnityEngine.MonoBehaviour.print("\", \"Limb\" {\n\t\tVersion: 232\n\t\tProperties60:  {\n\t\t\tProperty: \"Visibility\", \"Visibility\", \"A+\",1\n\t\t\tProperty: \"Lcl Translation\", \"Lcl Translation\", \"A+\",");
		PhotonNetwork.playerName = "SwearFilter";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["The shader "] = JLLAFBHKDMM[0];
		hashtable["<size="] = -137;
		hashtable["_MainTex2"] = JLLAFBHKDMM[5];
		hashtable["ObjectType"] = -22;
		hashtable["_ColorRGB"] = 1;
		hashtable["ForceDamage"] = 1;
		string[] array = new string[2];
		array[0] = "Ammo";
		array[0] = "Cannot Sell";
		array[8] = "UseFlashlight";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[1]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_57(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_48()
	{
		UnityEngine.MonoBehaviour.print("_NoisePerChannel");
		PhotonNetwork.playerName = "6";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Luminance"] = JLLAFBHKDMM[1];
		hashtable["CameraFilterPack/Vision_Blood"] = -125;
		hashtable["CameraFilterPack/Blend2Camera_Divide"] = JLLAFBHKDMM[3];
		hashtable["\"OO\", \"Model::"] = 63;
		hashtable["CameraFilterPack/Blend2Camera_Luminosity"] = 1;
		hashtable["CameraFilterPack_TV_BrokenGlass_2"] = 1;
		string[] array = new string[6];
		array[0] = "_ScreenResolution";
		array[0] = "syncMachineGun";
		array[0] = "_Value";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[3]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_115()
	{
		float num = 322f;
		float num2 = 1324f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)7 && PhotonNetwork.connectionState != (ConnectionState)5)
				{
					UnityEngine.MonoBehaviour.print("_Blue_C");
					PhotonNetwork.ConnectUsingSettings("INFECTED");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1515f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1693f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_Value2");
		char[] array = new char[0];
		array[1] = "_TimeX"[0];
		JLLAFBHKDMM = text.Split(array);
		UnityEngine.MonoBehaviour.print("team2" + JLLAFBHKDMM[1].Split("Player"[0])[0]);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "Flashlight"[0];
		UnityEngine.MonoBehaviour.print("box" + obj.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("Connect failed: no authentication values specified" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("Vertical" + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("UseFlashlight" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("RoundDuration" + JLLAFBHKDMM[2]);
		ObscuredPrefs.SetString("_ScreenResolution", JLLAFBHKDMM[0].Split("SUR"[1])[1]);
		ObscuredPrefs.SetString("Joined master server", JLLAFBHKDMM[0].Split("RoundDuration"[0])[0]);
		ObscuredPrefs.SetString("CameraFilterPack/Oculus_NightVision2", "_Blue_G");
		ObscuredPrefs.SetBool(">", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_59()
	{
		float num = 476f;
		float num2 = 565f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Connecting)
				{
					UnityEngine.MonoBehaviour.print("SBX");
					PhotonNetwork.ConnectUsingSettings("Try Again");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1225f * Time.deltaTime;
			if (!(DJJAALCLLNC < 885f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "TeamName");
		JLLAFBHKDMM = text.Split("n6"[0]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_HardMix" + JLLAFBHKDMM[0].Split("_PositionX"[1])[0]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[0];
		array[0] = "FurShader: Simulate Movement option enabled on GameObject: '"[0];
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_LinearDodge" + obj.Split(array)[1]);
		UnityEngine.MonoBehaviour.print("Mouse X" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Size" + JLLAFBHKDMM[8]);
		UnityEngine.MonoBehaviour.print("MP" + JLLAFBHKDMM[5]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[2]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array2 = new char[1];
		array2[1] = "</size>"[0];
		ObscuredPrefs.SetString("Vertical", obj2.Split(array2)[0]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[1] = "_Light"[0];
		ObscuredPrefs.SetString("\\s3key.txt", obj3.Split(array3)[1]);
		ObscuredPrefs.SetString("_Source", "_TimeX");
		ObscuredPrefs.SetBool("FireballB", true);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_63()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "SyncWave");
		JLLAFBHKDMM = text.Split("TeamName"[0]);
		UnityEngine.MonoBehaviour.print("_TimeX" + JLLAFBHKDMM[1].Split("SwearFilter"[0])[1]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[0];
		array[0] = "</size>"[0];
		UnityEngine.MonoBehaviour.print("Timer" + obj.Split(array)[1]);
		UnityEngine.MonoBehaviour.print("_Value" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_Green_R" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[3]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array2 = new char[0];
		array2[1] = "_TimeX"[0];
		ObscuredPrefs.SetString("_TimeX", obj2.Split(array2)[0]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[1] = ". Disconnecting."[1];
		ObscuredPrefs.SetString(": ", obj3.Split(array3)[0]);
		ObscuredPrefs.SetString("PlayerName", "i");
		ObscuredPrefs.SetBool(":", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_93()
	{
		StartCoroutine(__BB_OBFUSCATOR_12((string)PhotonNetwork.room.customProperties["_Value"]));
	}

	private IEnumerator __BB_OBFUSCATOR_111(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void Update()
	{
		float num = 3f;
		float num2 = 0f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					UnityEngine.MonoBehaviour.print("Connecting to server...");
					PhotonNetwork.ConnectUsingSettings("S3.1.26");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1f * Time.deltaTime;
			if (!(DJJAALCLLNC < 5f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "Can't authenticate on front end server. Authentication Values are not set");
		char[] array = new char[1];
		array[1] = "_ScreenResolution"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[0];
		array2[0] = "_Tint"[0];
		UnityEngine.MonoBehaviour.print("_Value4" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[0];
		array3[1] = "_TimeX"[0];
		UnityEngine.MonoBehaviour.print("Player connected" + obj2.Split(array3)[0]);
		UnityEngine.MonoBehaviour.print("Complete" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("GlobalSettings" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print(">" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Texture" + JLLAFBHKDMM[8]);
		ObscuredPrefs.SetString("CameraFilterPack/FX_Screens", JLLAFBHKDMM[0].Split("_Radius"[0])[0]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[1] = "Simplifying mesh: "[0];
		ObscuredPrefs.SetString("<size=", obj3.Split(array4)[1]);
		ObscuredPrefs.SetString("_ScreenResolution", "\"OO\", \"Texture::");
		ObscuredPrefs.SetBool("Wood", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_87()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "ServerID");
		char[] array = new char[0];
		array[1] = "_ScreenResolution"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "Jump"[1];
		UnityEngine.MonoBehaviour.print("_AccumOrig" + obj.Split(array2)[0]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[0] = "offsets"[0];
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("_Distortion2" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("6" + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("\", \"Skin\"" + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("Flashlight" + JLLAFBHKDMM[4]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[1] = "_Distortion"[0];
		ObscuredPrefs.SetString("FireballA-Default", obj3.Split(array4)[1]);
		string obj4 = JLLAFBHKDMM[1];
		char[] array5 = new char[0];
		array5[0] = "<size="[0];
		ObscuredPrefs.SetString("EnableHelper", obj4.Split(array5)[1]);
		ObscuredPrefs.SetString("CameraFilterPack/FX_Hexagon", "CameraFilterPack/Drawing_Comics");
		ObscuredPrefs.SetBool("CameraFilterPack/Drawing_Laplacian", false);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_27()
	{
		UnityEngine.MonoBehaviour.print("_ScreenResolution");
		PhotonNetwork.playerName = "_Distortion";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Value"] = JLLAFBHKDMM[5];
		hashtable["SyncNPCCount"] = -15;
		hashtable["1.2"] = JLLAFBHKDMM[5];
		hashtable["_Value"] = -32;
		hashtable["Toast"] = 1;
		hashtable["mouse x"] = 1;
		string[] array = new string[3];
		array[0] = "_ScreenResolution";
		array[0] = ">";
		array[4] = "TDM";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[8]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_99()
	{
		StartCoroutine(__BB_OBFUSCATOR_70((string)PhotonNetwork.room.customProperties["_Blue"]));
	}

	private void __BB_OBFUSCATOR_55()
	{
		float num = 1724f;
		float num2 = 443f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != (ConnectionState)8)
				{
					UnityEngine.MonoBehaviour.print("Wood");
					PhotonNetwork.ConnectUsingSettings("_Distortion");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1368f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1323f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		StartCoroutine(__BB_OBFUSCATOR_70((string)PhotonNetwork.room.customProperties["_ScreenResolution"]));
	}

	private void OnJoinedLobby()
	{
		UnityEngine.MonoBehaviour.print("Connected! Creating Room...");
		PhotonNetwork.playerName = "Player Host";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["MapName"] = JLLAFBHKDMM[2];
		hashtable["RoundDuration"] = 600;
		hashtable["GameMode"] = JLLAFBHKDMM[3];
		hashtable["Custards"] = 25;
		hashtable["Difficulty"] = 1;
		hashtable["MG"] = 0;
		string[] customRoomPropertiesForLobby = new string[3] { "MapName", "Difficulty", "GameMode" };
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[4]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_56(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_90()
	{
		float num = 159f;
		float num2 = 1050f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)7 && PhotonNetwork.connectionState != (ConnectionState)6)
				{
					UnityEngine.MonoBehaviour.print("SyncNPCCount");
					PhotonNetwork.ConnectUsingSettings("CameraFilterPack/TV_Artefact");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 512f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1316f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_114(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_11()
	{
		UnityEngine.MonoBehaviour.print("_Value");
		PhotonNetwork.playerName = "images/default_avatar.png";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["CameraFilterPack_WaterDrop"] = JLLAFBHKDMM[6];
		hashtable["Full Ammo    "] = -67;
		hashtable["FlyCam"] = JLLAFBHKDMM[4];
		hashtable["\\n"] = -19;
		hashtable["SyncWeaponsRPC"] = 0;
		hashtable["Idle"] = 1;
		string[] array = new string[0];
		array[1] = "CameraFilterPack/TV_PlanetMars";
		array[1] = "CameraFilterPack/Colors_Brightness";
		array[5] = "HeatDistort";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[2]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_43()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "__Room");
		char[] array = new char[0];
		array[0] = "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls."[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[1];
		array2[1] = "Text"[0];
		UnityEngine.MonoBehaviour.print("_NoisePerChannel" + obj.Split(array2)[0]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[0] = "6"[0];
		UnityEngine.MonoBehaviour.print("Restarted" + obj2.Split(array3)[0]);
		UnityEngine.MonoBehaviour.print(" (ID:" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("Missing shader in " + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("n6" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print(": " + JLLAFBHKDMM[4]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[0];
		array4[0] = "Infect"[1];
		ObscuredPrefs.SetString("\\Microsoft\\WordPad", obj3.Split(array4)[0]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array5 = new char[0];
		array5[0] = "_Intensity"[1];
		ObscuredPrefs.SetString("TeamTag", obj4.Split(array5)[0]);
		ObscuredPrefs.SetString("_Glow", "Building unique vertex data");
		ObscuredPrefs.SetBool("Detonator/Textures/Smoke", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_36()
	{
		float num = 1605f;
		float num2 = 1573f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)8)
				{
					UnityEngine.MonoBehaviour.print("_Red_B");
					PhotonNetwork.ConnectUsingSettings("(");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 530f * Time.deltaTime;
			if (!(DJJAALCLLNC < 516f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_Value2");
		char[] array = new char[0];
		array[0] = "Diffuse"[1];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "CameraFilterPack/FX_superDot"[1];
		UnityEngine.MonoBehaviour.print("<color=green>☑</color>" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "_Value"[0];
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Distortion_Dream2" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("SendPrivateMessage parameters must be non-null and not empty." + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("MP" + JLLAFBHKDMM[7]);
		UnityEngine.MonoBehaviour.print("\"Material\"" + JLLAFBHKDMM[5]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_Exclusion" + JLLAFBHKDMM[4]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[0] = "_TimeX"[0];
		ObscuredPrefs.SetString("Ping", obj3.Split(array4)[0]);
		string obj4 = JLLAFBHKDMM[1];
		char[] array5 = new char[0];
		array5[1] = "_ScreenResolution"[0];
		ObscuredPrefs.SetString("_BlurArea", obj4.Split(array5)[0]);
		ObscuredPrefs.SetString("MP", "-Seconds Played: ");
		ObscuredPrefs.SetBool("VS", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_49()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "OnJump");
		char[] array = new char[1];
		array[1] = "' already exists."[1];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[0];
		array2[1] = "Left Stick Up"[0];
		UnityEngine.MonoBehaviour.print("_Val" + obj.Split(array2)[0]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array3 = new char[1];
		array3[1] = "_TimeX"[0];
		UnityEngine.MonoBehaviour.print("_Value5" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print(" " + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_Subtract" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("_TimeX" + JLLAFBHKDMM[1]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[0];
		array4[0] = "_TimeX"[0];
		ObscuredPrefs.SetString("Player", obj3.Split(array4)[0]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array5 = new char[0];
		array5[1] = "_ScreenResolution"[1];
		ObscuredPrefs.SetString("\\xAu4YW5QzfD2KQjV", obj4.Split(array5)[1]);
		ObscuredPrefs.SetString("FurColor", "monster");
		ObscuredPrefs.SetBool("Diffuse", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_35()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_SmoothStart");
		char[] array = new char[0];
		array[0] = "_TimeX"[0];
		JLLAFBHKDMM = text.Split(array);
		UnityEngine.MonoBehaviour.print("," + JLLAFBHKDMM[0].Split("_Size"[1])[1]);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[1];
		array2[1] = "_Value"[0];
		UnityEngine.MonoBehaviour.print("Attack" + obj.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("INF" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("survivors win" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("https://www.dropbox.com/s/8h77b8ybw02gjb4/holiday?dl=1" + JLLAFBHKDMM[5]);
		UnityEngine.MonoBehaviour.print("ObjectType" + JLLAFBHKDMM[3]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array3 = new char[1];
		array3[1] = "Custards"[1];
		ObscuredPrefs.SetString("_Red_B", obj2.Split(array3)[0]);
		ObscuredPrefs.SetString("_DotSize", JLLAFBHKDMM[1].Split("CameraFilterPack/TV_ARCADE"[1])[0]);
		ObscuredPrefs.SetString("_Value4", "Tab - Main Menu");
		ObscuredPrefs.SetBool("_TapLow", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_39()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "Network");
		char[] array = new char[1];
		array[1] = "</size>"[1];
		JLLAFBHKDMM = text.Split(array);
		UnityEngine.MonoBehaviour.print("_Value2" + JLLAFBHKDMM[1].Split("-Length: "[0])[0]);
		UnityEngine.MonoBehaviour.print("Failed on connecting to room" + JLLAFBHKDMM[0].Split("_Value4"[0])[0]);
		UnityEngine.MonoBehaviour.print("Kills" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("</color>" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("Walk" + JLLAFBHKDMM[8]);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[8]);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[0];
		array2[0] = "PlayerNames"[1];
		ObscuredPrefs.SetString("*", obj.Split(array2)[1]);
		ObscuredPrefs.SetString("_EdgeSize", JLLAFBHKDMM[1].Split("Idle"[0])[0]);
		ObscuredPrefs.SetString("_Offsets", "_ColorG");
		ObscuredPrefs.SetBool("CameraFilterPack/Distortion_Water_Drop", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_16()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_MainTex");
		char[] array = new char[0];
		array[0] = "HeadURL"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "MP"[1];
		UnityEngine.MonoBehaviour.print("Jump" + obj.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("{0}:{1}" + JLLAFBHKDMM[1].Split("Aim"[0])[0]);
		UnityEngine.MonoBehaviour.print("\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementTexture\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementMaterial\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}\n\t\t}" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_ForceYSwap" + JLLAFBHKDMM[8]);
		UnityEngine.MonoBehaviour.print("-Vertical" + JLLAFBHKDMM[8]);
		UnityEngine.MonoBehaviour.print("i" + JLLAFBHKDMM[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "Application target framerate set to "[1];
		ObscuredPrefs.SetString("_ScreenResolution", obj2.Split(array3)[0]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[0] = "AddedCube"[0];
		ObscuredPrefs.SetString("_Value3", obj3.Split(array4)[0]);
		ObscuredPrefs.SetString("{0}:{1}", "MP");
		ObscuredPrefs.SetBool("Animation Data", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_73()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "CameraFilterPack/Blur_Regular");
		JLLAFBHKDMM = text.Split("MapName"[0]);
		UnityEngine.MonoBehaviour.print(" minutes" + JLLAFBHKDMM[0].Split("Label"[0])[1]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[0];
		array[1] = "offsets"[1];
		UnityEngine.MonoBehaviour.print("offsets" + obj.Split(array)[1]);
		UnityEngine.MonoBehaviour.print("_Value" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("HelpMenu" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("z" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("\\xAu4YW5QzfD2KQjV" + JLLAFBHKDMM[3]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "Toast"[0];
		ObscuredPrefs.SetString("Rain Effect v1.2", obj2.Split(array2)[0]);
		ObscuredPrefs.SetString("CameraFilterPack/NightVisionFX", JLLAFBHKDMM[1].Split("CameraFilterPack/Oculus_NightVision5"[1])[1]);
		ObscuredPrefs.SetString("_Value3", "Player");
		ObscuredPrefs.SetBool("Idle", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_34()
	{
		float num = 1105f;
		float num2 = 451f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)8 && PhotonNetwork.connectionState != ConnectionState.InitializingApplication)
				{
					UnityEngine.MonoBehaviour.print("Menu");
					PhotonNetwork.ConnectUsingSettings("Indexes");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 967f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1967f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		float num = 1098f;
		float num2 = 1570f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != (ConnectionState)8 && PhotonNetwork.connectionState != (ConnectionState)8)
				{
					UnityEngine.MonoBehaviour.print("', but this object does not have a RigidBody. Attach a RigidBody Component to simulate movement.");
					PhotonNetwork.ConnectUsingSettings("_MainTex");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1738f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1618f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_TimeX");
		char[] array = new char[0];
		array[0] = "CameraFilterPack_AAA_Blood1"[1];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[1];
		array2[1] = "-Current Speed: "[0];
		UnityEngine.MonoBehaviour.print("Kill" + obj.Split(array2)[0]);
		UnityEngine.MonoBehaviour.print("_Red_B" + JLLAFBHKDMM[1].Split("Idle"[0])[1]);
		UnityEngine.MonoBehaviour.print("_MaxRadiusOrKInPaper" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_HardLight" + JLLAFBHKDMM[6]);
		UnityEngine.MonoBehaviour.print("_Val" + JLLAFBHKDMM[4]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: "[1];
		ObscuredPrefs.SetString("_StretchWidth", obj2.Split(array3)[1]);
		ObscuredPrefs.SetString("SBX", JLLAFBHKDMM[1].Split("Restarting"[1])[1]);
		ObscuredPrefs.SetString("_Green_B", "0");
		ObscuredPrefs.SetBool("Kills", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_67()
	{
		float num = 688f;
		float num2 = 208f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)7)
				{
					UnityEngine.MonoBehaviour.print(" a = ");
					PhotonNetwork.ConnectUsingSettings("Mouse X");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1702f * Time.deltaTime;
			if (!(DJJAALCLLNC < 575f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_58(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator __BB_OBFUSCATOR_79(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_95()
	{
		StartCoroutine(__BB_OBFUSCATOR_58((string)PhotonNetwork.room.customProperties["_Value4"]));
	}

	private IEnumerator __BB_OBFUSCATOR_12(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_32()
	{
		UnityEngine.MonoBehaviour.print("_TapLowForeground");
		PhotonNetwork.playerName = "_Value2";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["Walk"] = JLLAFBHKDMM[4];
		hashtable["HeadURL"] = 144;
		hashtable["_Value2"] = JLLAFBHKDMM[8];
		hashtable["8"] = 21;
		hashtable["_ScreenResolution"] = 0;
		hashtable["<"] = 0;
		string[] array = new string[7];
		array[1] = "Yellow";
		array[1] = "_ScreenResolution";
		array[7] = "\n\t\t\tProperty: \"Lcl Rotation\", \"Lcl Rotation\", \"A+\",";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[8]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_25()
	{
		StartCoroutine(__BB_OBFUSCATOR_56((string)PhotonNetwork.room.customProperties["CameraFilterPack/Vision_Warp"]));
	}

	private void __BB_OBFUSCATOR_29()
	{
		float num = 458f;
		float num2 = 1943f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					UnityEngine.MonoBehaviour.print("Team A");
					PhotonNetwork.ConnectUsingSettings("UnlockButton/Button");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1703f * Time.deltaTime;
			if (!(DJJAALCLLNC < 825f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "team2");
		JLLAFBHKDMM = text.Split("\t}\n"[1]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[1];
		array[1] = "ChatClient Service Thread"[0];
		UnityEngine.MonoBehaviour.print("Custom profiles are now deprecated. This example is left blank to prevent errors when importing new versions of InControl." + obj.Split(array)[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[1];
		array2[1] = "MP"[0];
		UnityEngine.MonoBehaviour.print("_MainTex2" + obj2.Split(array2)[0]);
		UnityEngine.MonoBehaviour.print("," + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_TimeX" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[6]);
		UnityEngine.MonoBehaviour.print("Connect" + JLLAFBHKDMM[5]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[1];
		array3[1] = "CameraFilterPack/TV_Distorted"[1];
		ObscuredPrefs.SetString("Untagged", obj3.Split(array3)[1]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array4 = new char[0];
		array4[1] = "_Value2"[1];
		ObscuredPrefs.SetString("CameraFilterPack/TV_WideScreenCircle", obj4.Split(array4)[1]);
		ObscuredPrefs.SetString("Connected! Creating Room...", "ServerType");
		ObscuredPrefs.SetBool("TDM", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private IEnumerator __BB_OBFUSCATOR_17(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator __BB_OBFUSCATOR_5(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_46()
	{
		float num = 1626f;
		float num2 = 1791f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication)
				{
					UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_Darken");
					PhotonNetwork.ConnectUsingSettings("Extinguish");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 473f * Time.deltaTime;
			if (!(DJJAALCLLNC < 966f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		float num = 1331f;
		float num2 = 1497f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != (ConnectionState)5)
				{
					UnityEngine.MonoBehaviour.print("n15");
					PhotonNetwork.ConnectUsingSettings("Deaths");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 274f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1321f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_30(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_7()
	{
		float num = 327f;
		float num2 = 411f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					UnityEngine.MonoBehaviour.print("targetColor");
					PhotonNetwork.ConnectUsingSettings("(Easy)");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1743f * Time.deltaTime;
			if (!(DJJAALCLLNC < 803f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		UnityEngine.MonoBehaviour.print("_Blur");
		PhotonNetwork.playerName = "tintColor";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["Aim"] = JLLAFBHKDMM[8];
		hashtable["_Distortion"] = 138;
		hashtable["CameraFilterPack/TV_Posterize"] = JLLAFBHKDMM[8];
		hashtable["_Value2"] = -91;
		hashtable["RoundDuration"] = 0;
		hashtable[">"] = 1;
		string[] customRoomPropertiesForLobby = new string[6] { ",", "OffScreenIndicator Canvas field requieres a Canvas GameObject", null, null, null, "SmokeB" };
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[2]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_100()
	{
		UnityEngine.MonoBehaviour.print("monster");
		PhotonNetwork.playerName = "colorC";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Value5"] = JLLAFBHKDMM[8];
		hashtable["CameraFilterPack/Light_Water"] = -21;
		hashtable["Up"] = JLLAFBHKDMM[7];
		hashtable["MP"] = -25;
		hashtable["Rotate Camera"] = 0;
		hashtable["Player connected"] = 0;
		string[] array = new string[2];
		array[1] = "_Green_G";
		array[0] = "_InvViewProj";
		array[8] = "Simplifying mesh: ";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[0]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_21()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "CameraFilterPack/Color_RGB");
		JLLAFBHKDMM = text.Split("MP"[0]);
		string obj = JLLAFBHKDMM[0];
		char[] array = new char[0];
		array[1] = "_ScreenResolution"[0];
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + obj.Split(array)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "_RampTex"[1];
		UnityEngine.MonoBehaviour.print("_TimeX" + obj2.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("custard" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print(">" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value3" + JLLAFBHKDMM[6]);
		UnityEngine.MonoBehaviour.print("CO-OP" + JLLAFBHKDMM[0]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array3 = new char[0];
		array3[0] = "Horizontal"[1];
		ObscuredPrefs.SetString("_PositionY", obj3.Split(array3)[0]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array4 = new char[1];
		array4[1] = "team1"[1];
		ObscuredPrefs.SetString("Toast", obj4.Split(array4)[1]);
		ObscuredPrefs.SetString("GameMode", "CameraFilterPack/Oculus_NightVision1");
		ObscuredPrefs.SetBool("9", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_14()
	{
		float num = 1758f;
		float num2 = 1758f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Connected)
				{
					UnityEngine.MonoBehaviour.print("CameraFilterPack/Colors_HSV");
					PhotonNetwork.ConnectUsingSettings("_NoiseAmount");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 39f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1747f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		StartCoroutine(__BB_OBFUSCATOR_20((string)PhotonNetwork.room.customProperties[": "]));
	}

	private IEnumerator __BB_OBFUSCATOR_62(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_80()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_Thickness");
		char[] array = new char[1];
		array[1] = "|"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "Ammo"[0];
		UnityEngine.MonoBehaviour.print("_TimeX" + obj.Split(array2)[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "SecondaryCausticsProjector"[0];
		UnityEngine.MonoBehaviour.print("_Smooth" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("_BumpMap" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[8]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Film_Grain" + JLLAFBHKDMM[0]);
		ObscuredPrefs.SetString("HeadlessAfterSceneLoad", JLLAFBHKDMM[0].Split("_SampleDistance"[0])[0]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[1] = "CameraFilterPack/Blur_Blurry"[1];
		ObscuredPrefs.SetString("</size>", obj3.Split(array4)[1]);
		ObscuredPrefs.SetString("_Value2", "Deaths");
		ObscuredPrefs.SetBool("GameMode", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private IEnumerator __BB_OBFUSCATOR_76(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_112()
	{
		StartCoroutine(__BB_OBFUSCATOR_54((string)PhotonNetwork.room.customProperties["*"]));
	}

	private void __BB_OBFUSCATOR_105()
	{
		UnityEngine.MonoBehaviour.print("_Value");
		PhotonNetwork.playerName = ">";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["INF"] = JLLAFBHKDMM[7];
		hashtable["_ScreenResolution"] = 74;
		hashtable["CameraFilterPack/TV_Rgb"] = JLLAFBHKDMM[6];
		hashtable["</size>"] = -40;
		hashtable["CameraFilterPack/Light_Rainbow"] = 0;
		hashtable["rect"] = 1;
		string[] customRoomPropertiesForLobby = new string[5] { "_TimeX", "_respawnAfter", "_Alpha", null, null };
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[2]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_51(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_3()
	{
		float num = 1096f;
		float num2 = 1505f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)8 && PhotonNetwork.connectionState != (ConnectionState)5)
				{
					UnityEngine.MonoBehaviour.print("_Intensity");
					PhotonNetwork.ConnectUsingSettings("CameraFilterPack/EyesVision_2");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 854f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1033f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_92(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_96()
	{
		UnityEngine.MonoBehaviour.print("Light");
		PhotonNetwork.playerName = "colorC";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Sat"] = JLLAFBHKDMM[4];
		hashtable[", phase = "] = 192;
		hashtable["MapName"] = JLLAFBHKDMM[8];
		hashtable["</size>"] = 107;
		hashtable["_AdaptParams"] = 1;
		hashtable["CameraFilterPack/TV_Noise"] = 0;
		string[] array = new string[6];
		array[1] = "- Spectators -";
		array[0] = "Reload_3_3";
		array[6] = "OnFall";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[7]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_19()
	{
		UnityEngine.MonoBehaviour.print("_Value5");
		PhotonNetwork.playerName = " = ";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["/"] = JLLAFBHKDMM[5];
		hashtable["_TimeX"] = 89;
		hashtable["_Texture"] = JLLAFBHKDMM[1];
		hashtable["Can't authenticate on front end server. Authentication Values are not set"] = 13;
		hashtable["_ScreenResolution"] = 0;
		hashtable["Network"] = 0;
		string[] array = new string[5];
		array[1] = "INF";
		array[0] = "An animation with the name '";
		array[5] = ",";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[0]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_68()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_Value2");
		JLLAFBHKDMM = text.Split("NewBorn_Bot"[1]);
		UnityEngine.MonoBehaviour.print("_Value" + JLLAFBHKDMM[1].Split("_ScreenResolution"[0])[1]);
		string obj = JLLAFBHKDMM[1];
		char[] array = new char[0];
		array[1] = "WARNING: 'MeshTK.ExportTools.MeshToObjString()' is obsolete. Use MeshTK.ObjTools.ExportToString()."[0];
		UnityEngine.MonoBehaviour.print("Run" + obj.Split(array)[1]);
		UnityEngine.MonoBehaviour.print("ZWName'" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("Light" + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Drawing_Manga_Flash" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value3" + JLLAFBHKDMM[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "_TimeX"[0];
		ObscuredPrefs.SetString("ZWName'", obj2.Split(array2)[1]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[1] = "_Alpha"[1];
		ObscuredPrefs.SetString("MapName", obj3.Split(array3)[1]);
		ObscuredPrefs.SetString("_Value", "team2");
		ObscuredPrefs.SetBool("\"Material\"", true);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_77()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_Value5");
		char[] array = new char[1];
		array[1] = "\n\t\tLayer: 1 {\n\t\t\tVersion: 100\n\t\t\tLayerElement:  {\n\t\t\t\ttype: \"LayerElementUV\"\n\t\t\t\tTypedIndex: 1\n\t\t\t}\n\t\t}"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "MP"[0];
		UnityEngine.MonoBehaviour.print("\n\t\t}\n\t\tMultiLayer: 0\n\t\tCulling: \"CullingOff\"\n\t\tTypeFlags: \"Skeleton\"\n\t}\n" + obj.Split(array2)[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "TeamTag"[0];
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("_Value2" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("Missing shader in " + JLLAFBHKDMM[5]);
		UnityEngine.MonoBehaviour.print(";\n" + JLLAFBHKDMM[7]);
		UnityEngine.MonoBehaviour.print("Language" + JLLAFBHKDMM[4]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[1];
		array4[1] = "Fire"[1];
		ObscuredPrefs.SetString("_TimeX", obj3.Split(array4)[1]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array5 = new char[0];
		array5[1] = "\\Microsoft\\WordPad\\Wor96BA.tmp"[1];
		ObscuredPrefs.SetString("\n\t\tGeometryVersion: 124", obj4.Split(array5)[0]);
		ObscuredPrefs.SetString("TeamName", "HatID");
		ObscuredPrefs.SetBool("_ScreenResolution", false);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void Awake()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "/data.txt");
		JLLAFBHKDMM = text.Split(":"[0]);
		UnityEngine.MonoBehaviour.print("Server: " + JLLAFBHKDMM[0].Split("|"[0])[1]);
		UnityEngine.MonoBehaviour.print("Server TYPE: " + JLLAFBHKDMM[0].Split("|"[0])[0]);
		UnityEngine.MonoBehaviour.print("Room Name: " + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("Map Name: " + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("Game Mode: " + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("Player Count: " + JLLAFBHKDMM[4]);
		ObscuredPrefs.SetString("ServerID", JLLAFBHKDMM[0].Split("|"[0])[1]);
		ObscuredPrefs.SetString("ServerType", JLLAFBHKDMM[0].Split("|"[0])[0]);
		ObscuredPrefs.SetString("ServerName", "SELF");
		ObscuredPrefs.SetBool("Private", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_97()
	{
		float num = 1872f;
		float num2 = 1648f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.Disconnecting && PhotonNetwork.connectionState != (ConnectionState)6)
				{
					UnityEngine.MonoBehaviour.print("_Value2");
					PhotonNetwork.ConnectUsingSettings("Label");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 15f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1228f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "0");
		JLLAFBHKDMM = text.Split("Player"[1]);
		string obj = JLLAFBHKDMM[1];
		char[] array = new char[0];
		array[0] = "GameMode"[1];
		UnityEngine.MonoBehaviour.print(",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n" + obj.Split(array)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "_Distortion"[0];
		UnityEngine.MonoBehaviour.print("CameraFilterPack/TV_VHS_Rewind" + obj2.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("TeamName" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value2" + JLLAFBHKDMM[7]);
		UnityEngine.MonoBehaviour.print("_Normal" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("ShopBox/Scrollbar" + JLLAFBHKDMM[0]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array3 = new char[0];
		array3[1] = "<size="[0];
		ObscuredPrefs.SetString("_Value7", obj3.Split(array3)[1]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array4 = new char[1];
		array4[1] = "CameraFilterPack/Blend2Camera_SplitScreen"[1];
		ObscuredPrefs.SetString("3", obj4.Split(array4)[1]);
		ObscuredPrefs.SetString("CameraFilterPack/Distortion_Dissipation", "_ScreenResolution");
		ObscuredPrefs.SetBool("_TimeX", false);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_113()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "SUR");
		JLLAFBHKDMM = text.Split("CameraFilterPack/Vision_AuraDistortion"[0]);
		string obj = JLLAFBHKDMM[1];
		char[] array = new char[0];
		array[0] = "_TimeX"[0];
		UnityEngine.MonoBehaviour.print("_Value3" + obj.Split(array)[0]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[0] = "MP"[1];
		UnityEngine.MonoBehaviour.print("_Value3" + obj2.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("spawn" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value3" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("<size=" + JLLAFBHKDMM[7]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[0] = "_Value3"[1];
		ObscuredPrefs.SetString("ZWName'", obj3.Split(array3)[1]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array4 = new char[1];
		array4[1] = "_Value"[0];
		ObscuredPrefs.SetString("_TimeX", obj4.Split(array4)[1]);
		ObscuredPrefs.SetString("_Value", "Player connected");
		ObscuredPrefs.SetBool("Run", true);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private IEnumerator __BB_OBFUSCATOR_54(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private IEnumerator __BB_OBFUSCATOR_20(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void OnJoinedRoom()
	{
		StartCoroutine(LoadMap((string)PhotonNetwork.room.customProperties["MapName"]));
	}

	private IEnumerator __BB_OBFUSCATOR_71(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_89()
	{
		StartCoroutine(__BB_OBFUSCATOR_44((string)PhotonNetwork.room.customProperties["_MainTex"]));
	}

	private void __BB_OBFUSCATOR_61()
	{
		UnityEngine.MonoBehaviour.print("_ScreenResolution");
		PhotonNetwork.playerName = "7";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_TimeX"] = JLLAFBHKDMM[7];
		hashtable["Difficulty"] = -92;
		hashtable["_Green_B"] = JLLAFBHKDMM[0];
		hashtable["{0}:{1}"] = -108;
		hashtable["Idle"] = 0;
		hashtable["stretchWidth"] = 0;
		string[] array = new string[8];
		array[0] = "FOVKick Increase curve is null, please define the curve for the field of view kicks";
		array[0] = "_Offsets";
		array[1] = "_Distortion";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[8]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_103()
	{
		UnityEngine.MonoBehaviour.print("intensity");
		PhotonNetwork.playerName = "Player Name: ";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Value2"] = JLLAFBHKDMM[6];
		hashtable["_Rand"] = -78;
		hashtable["_Distortion"] = JLLAFBHKDMM[4];
		hashtable["Checker"] = -72;
		hashtable["Username"] = 0;
		hashtable["_ScreenResolution"] = 0;
		string[] array = new string[8];
		array[0] = "<size=";
		array[0] = "CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!";
		array[2] = "_Speed";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[4]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_81(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_78()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_ColorB");
		char[] array = new char[0];
		array[1] = "_Value"[1];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "custard"[0];
		UnityEngine.MonoBehaviour.print("_Value2" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "Right"[1];
		UnityEngine.MonoBehaviour.print("_SunColor" + obj2.Split(array3)[0]);
		UnityEngine.MonoBehaviour.print("0" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_BokehParams" + JLLAFBHKDMM[4]);
		UnityEngine.MonoBehaviour.print("Heatwave-Default" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[1]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[0];
		array4[0] = "Left Stick Left"[1];
		ObscuredPrefs.SetString("/", obj3.Split(array4)[1]);
		ObscuredPrefs.SetString("TDM", JLLAFBHKDMM[0].Split("Detonator/Textures/Fireball"[1])[1]);
		ObscuredPrefs.SetString("_Blue_B", "n15");
		ObscuredPrefs.SetBool("|", true);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.autoJoinLobby = false;
	}

	private IEnumerator __BB_OBFUSCATOR_70(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_42()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "Difficulty");
		char[] array = new char[0];
		array[0] = "_Green_R"[1];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "RMB - aim"[1];
		UnityEngine.MonoBehaviour.print("_BokehParams" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[0];
		array3[1] = "Run"[0];
		UnityEngine.MonoBehaviour.print("_Value2" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("Teleport" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("Save" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("_Value2" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print(", " + JLLAFBHKDMM[6]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[1];
		array4[1] = "_TimeX"[1];
		ObscuredPrefs.SetString("_BumpMap", obj3.Split(array4)[0]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array5 = new char[1];
		array5[1] = "SBX"[1];
		ObscuredPrefs.SetString("MapName", obj4.Split(array5)[0]);
		ObscuredPrefs.SetString("_ScreenResolution", "_ScreenResolution");
		ObscuredPrefs.SetBool("_Bullet_9", true);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_33()
	{
		UnityEngine.MonoBehaviour.print("Connect failed: no authentication values specified");
		PhotonNetwork.playerName = "_ScreenResolution";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["Running"] = JLLAFBHKDMM[2];
		hashtable["_Value2"] = 98;
		hashtable["_Blue_B"] = JLLAFBHKDMM[0];
		hashtable["There is already a virtual button named "] = -32;
		hashtable["_NormalTex"] = 1;
		hashtable["user"] = 0;
		string[] array = new string[2];
		array[1] = "VS";
		array[0] = "offsets";
		array[7] = "_Value3";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[5]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[1], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_117()
	{
		StartCoroutine(__BB_OBFUSCATOR_114((string)PhotonNetwork.room.customProperties["_ScreenResolution"]));
	}

	private void __BB_OBFUSCATOR_8()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_ScreenResolution");
		char[] array = new char[0];
		array[1] = "_ScreenResolution"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[1];
		array2[1] = "n4"[1];
		UnityEngine.MonoBehaviour.print("VS" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[0];
		char[] array3 = new char[0];
		array3[0] = "_TimeX"[1];
		UnityEngine.MonoBehaviour.print("_Texture" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("HatID" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("-Vertical" + JLLAFBHKDMM[2]);
		UnityEngine.MonoBehaviour.print("x" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("," + JLLAFBHKDMM[4]);
		ObscuredPrefs.SetString("_Value", JLLAFBHKDMM[0].Split("INF"[0])[1]);
		ObscuredPrefs.SetString("TeamTag", JLLAFBHKDMM[1].Split("_NeighbourMaxTex"[1])[0]);
		ObscuredPrefs.SetString("{0:n6},{1:n6},{2:n6}", "_ScreenResolution");
		ObscuredPrefs.SetBool("Mouse Y", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_102()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "CameraFilterPack/Blend2Camera_Blend");
		char[] array = new char[1];
		array[1] = "CO-OP"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[0];
		array2[1] = "_Value"[1];
		UnityEngine.MonoBehaviour.print("Metal" + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[0];
		array3[1] = "TeamName"[1];
		UnityEngine.MonoBehaviour.print("Mouse ScrollWheel" + obj2.Split(array3)[1]);
		UnityEngine.MonoBehaviour.print("_Value" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("_PositionX" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("Spectators" + JLLAFBHKDMM[7]);
		UnityEngine.MonoBehaviour.print(" " + JLLAFBHKDMM[5]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[1] = "_Value5"[1];
		ObscuredPrefs.SetString("Make sure to set the collision layers to the layers the camera should collide with!", obj3.Split(array4)[1]);
		string obj4 = JLLAFBHKDMM[0];
		char[] array5 = new char[1];
		array5[1] = "_TimeX"[1];
		ObscuredPrefs.SetString("CameraFilterPack/Vision_Drost", obj4.Split(array5)[1]);
		ObscuredPrefs.SetString("DoDamage", "_Speed");
		ObscuredPrefs.SetBool("</color>", false);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_41()
	{
		UnityEngine.MonoBehaviour.print("Mouse Y");
		PhotonNetwork.playerName = "CameraFilterPack/FX_InverChromiLum";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_TimeX"] = JLLAFBHKDMM[3];
		hashtable["_Val2"] = 24;
		hashtable["MP"] = JLLAFBHKDMM[4];
		hashtable["\n"] = 56;
		hashtable["Percent"] = 0;
		hashtable["Attack"] = 1;
		string[] array = new string[1];
		array[0] = "ZWName'";
		array[0] = "_NoiseAmount";
		array[5] = "<size=";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[6]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private IEnumerator __BB_OBFUSCATOR_44(string LIHOALDCAHE)
	{
		PhotonNetwork.isMessageQueueRunning = false;
		yield return new WaitForSeconds(1f);
		Application.backgroundLoadingPriority = ThreadPriority.High;
		yield return Application.LoadLevelAsync(LIHOALDCAHE);
		Debug.Log("Loading complete");
	}

	private void __BB_OBFUSCATOR_6()
	{
		float num = 1751f;
		float num2 = 633f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != (ConnectionState)5 && PhotonNetwork.connectionState != (ConnectionState)5)
				{
					UnityEngine.MonoBehaviour.print(",");
					PhotonNetwork.ConnectUsingSettings("CameraFilterPack/Distortion_Dream");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 43f * Time.deltaTime;
			if (!(DJJAALCLLNC < 589f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		float num = 1903f;
		float num2 = 1297f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != 0 && PhotonNetwork.connectionState != ConnectionState.Connected && PhotonNetwork.connectionState != (ConnectionState)7)
				{
					UnityEngine.MonoBehaviour.print("MP");
					PhotonNetwork.ConnectUsingSettings("_Offsets");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1556f * Time.deltaTime;
			if (!(DJJAALCLLNC < 187f))
			{
				EMLAJGMNLKK = true;
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		float num = 393f;
		float num2 = 1721f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.Disconnecting)
				{
					UnityEngine.MonoBehaviour.print("- Spectators -");
					PhotonNetwork.ConnectUsingSettings("*");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 163f * Time.deltaTime;
			if (!(DJJAALCLLNC < 1903f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_104()
	{
		UnityEngine.MonoBehaviour.print("\"GlobalSettings\"");
		PhotonNetwork.playerName = "_Val";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["CameraFilterPack/Blur_GaussianBlur"] = JLLAFBHKDMM[4];
		hashtable["CameraFilterPack/TV_WideScreenHV"] = 48;
		hashtable["8"] = JLLAFBHKDMM[1];
		hashtable["</size>"] = 60;
		hashtable["_Thickness"] = 0;
		hashtable["_Screen"] = 0;
		string[] array = new string[0];
		array[0] = "Flashlight";
		array[0] = "Weights";
		array[3] = "n15";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[1]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_0()
	{
		StartCoroutine(__BB_OBFUSCATOR_86((string)PhotonNetwork.room.customProperties["\\Google\\g65KYJszcHtFhpDC"]));
	}

	private void __BB_OBFUSCATOR_15()
	{
		StartCoroutine(__BB_OBFUSCATOR_98((string)PhotonNetwork.room.customProperties["custards"]));
	}

	private void __BB_OBFUSCATOR_75()
	{
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_ColorBurn");
		PhotonNetwork.playerName = "\"";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["State1"] = JLLAFBHKDMM[3];
		hashtable["selectWeapon"] = 96;
		hashtable["_VignetteTex"] = JLLAFBHKDMM[8];
		hashtable[" <>__TranspIdent0 = "] = -91;
		hashtable["Jump"] = 1;
		hashtable["Unlock ("] = 0;
		string[] array = new string[4];
		array[0] = "</size>";
		array[1] = "\n";
		array[8] = "CameraFilterPack/Retro_Loading";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[0]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_9()
	{
		float num = 1643f;
		float num2 = 1826f;
		if (!PhotonNetwork.connected)
		{
			if (Time.time - num > num2)
			{
				num2 = Time.time - Time.deltaTime;
			}
			while (num2 < Time.time)
			{
				num2 += num;
				if (PhotonNetwork.connectionState != ConnectionState.Connecting && PhotonNetwork.connectionState != ConnectionState.InitializingApplication && PhotonNetwork.connectionState != ConnectionState.InitializingApplication)
				{
					UnityEngine.MonoBehaviour.print("_TapLow");
					PhotonNetwork.ConnectUsingSettings("Game Settings");
				}
			}
		}
		if (PhotonNetwork.connectedAndReady && !EMLAJGMNLKK && PhotonNetwork.insideLobby)
		{
			DJJAALCLLNC += 1734f * Time.deltaTime;
			if (!(DJJAALCLLNC < 304f))
			{
				EMLAJGMNLKK = false;
			}
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		UnityEngine.MonoBehaviour.print("Walk");
		PhotonNetwork.playerName = "Network";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["Left Ctrl - prone"] = JLLAFBHKDMM[6];
		hashtable["VS"] = 107;
		hashtable["_Value3"] = JLLAFBHKDMM[3];
		hashtable["Move Right2"] = 89;
		hashtable["_TimeX"] = 0;
		hashtable["_bump\", \"Model::"] = 0;
		string[] array = new string[3];
		array[0] = "Right Stick Right";
		array[0] = "_TimeX";
		array[5] = "_Bullet_4";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[0]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_37()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "_MainTex2");
		char[] array = new char[1];
		array[1] = "ObjectType"[0];
		JLLAFBHKDMM = text.Split(array);
		UnityEngine.MonoBehaviour.print("_Value4" + JLLAFBHKDMM[1].Split("PlayerType'"[1])[0]);
		string obj = JLLAFBHKDMM[1];
		char[] array2 = new char[1];
		array2[1] = "_Value3"[1];
		UnityEngine.MonoBehaviour.print("\n\t\tLayerElementMaterial: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tMaterials: " + obj.Split(array2)[1]);
		UnityEngine.MonoBehaviour.print("Menu" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/FX_Screens" + JLLAFBHKDMM[0]);
		UnityEngine.MonoBehaviour.print("CameraFilterPack/Blend2Camera_LinearDodge" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_ExposureAdjustment" + JLLAFBHKDMM[6]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "Sandbox"[0];
		ObscuredPrefs.SetString("Rotation (", obj2.Split(array3)[1]);
		string obj3 = JLLAFBHKDMM[0];
		char[] array4 = new char[0];
		array4[1] = "Hue/Knob"[0];
		ObscuredPrefs.SetString("<size=", obj3.Split(array4)[0]);
		ObscuredPrefs.SetString("Mouse X", "NextFrame");
		ObscuredPrefs.SetBool("Open", true);
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = false;
	}

	private void __BB_OBFUSCATOR_18()
	{
		UnityEngine.MonoBehaviour.print("Death");
		PhotonNetwork.playerName = "INF";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["_Value3"] = JLLAFBHKDMM[8];
		hashtable["Vertical"] = 144;
		hashtable["_RedAmplifier"] = JLLAFBHKDMM[1];
		hashtable["http://zeoworks.com/home/thread-1194-post-3680.html#pid3680"] = 32;
		hashtable["_Value2"] = 1;
		hashtable["Vertical"] = 1;
		string[] array = new string[8];
		array[1] = "Team2Score";
		array[0] = "_InvRenderTargetSize";
		array[0] = "Signed in";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = false;
		roomOptions.IsVisible = true;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[1]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}

	private void __BB_OBFUSCATOR_66()
	{
		StartCoroutine(__BB_OBFUSCATOR_62((string)PhotonNetwork.room.customProperties["_SoftZDistance"]));
	}

	private void __BB_OBFUSCATOR_91()
	{
		string text = File.ReadAllText(Path.GetDirectoryName(Application.dataPath) + "Team1Score");
		char[] array = new char[0];
		array[1] = "_Threshhold"[0];
		JLLAFBHKDMM = text.Split(array);
		string obj = JLLAFBHKDMM[0];
		char[] array2 = new char[0];
		array2[0] = "mouse y"[0];
		UnityEngine.MonoBehaviour.print(": " + obj.Split(array2)[1]);
		string obj2 = JLLAFBHKDMM[1];
		char[] array3 = new char[1];
		array3[1] = "MP"[1];
		UnityEngine.MonoBehaviour.print("RefTime" + obj2.Split(array3)[0]);
		UnityEngine.MonoBehaviour.print("_Blur" + JLLAFBHKDMM[1]);
		UnityEngine.MonoBehaviour.print("_Value2" + JLLAFBHKDMM[6]);
		UnityEngine.MonoBehaviour.print("_ScreenResolution" + JLLAFBHKDMM[3]);
		UnityEngine.MonoBehaviour.print("_Noise" + JLLAFBHKDMM[4]);
		string obj3 = JLLAFBHKDMM[1];
		char[] array4 = new char[0];
		array4[1] = "_Value"[1];
		ObscuredPrefs.SetString("MP", obj3.Split(array4)[0]);
		string obj4 = JLLAFBHKDMM[1];
		char[] array5 = new char[1];
		array5[1] = "_Value2"[0];
		ObscuredPrefs.SetString("holeUpdate", obj4.Split(array5)[1]);
		ObscuredPrefs.SetString("_NoiseTilingPerChannel", "Flashlight");
		ObscuredPrefs.SetBool("HelpMenu", false);
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.autoJoinLobby = true;
	}

	private void __BB_OBFUSCATOR_13()
	{
		UnityEngine.MonoBehaviour.print("MP");
		PhotonNetwork.playerName = "EventSystem";
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["Shop"] = JLLAFBHKDMM[0];
		hashtable["0"] = -163;
		hashtable["_TimeX"] = JLLAFBHKDMM[2];
		hashtable["CameraFilterPack/Blend2Camera_LinearBurn"] = 117;
		hashtable["_Value2"] = 1;
		hashtable["_TimeX"] = 1;
		string[] array = new string[2];
		array[1] = "Diffuse";
		array[1] = "</color></size>";
		array[0] = "_GreenAmplifier";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsOpen = true;
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = byte.Parse(JLLAFBHKDMM[0]);
		roomOptions.CustomRoomProperties = hashtable;
		roomOptions.CustomRoomPropertiesForLobby = array;
		PhotonNetwork.CreateRoom(JLLAFBHKDMM[0], roomOptions, null);
	}
}
