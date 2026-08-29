using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	[Serializable]
	public class language
	{
		public string name;

		public Sprite icon;
	}

	[Header("Splash Screen")]
	public bool GAGCMJDPMNL = true;

	public GameObject IAFBBLMLGLG;

	private List<Graphic> PDEDBMHLEDK = new List<Graphic>();

	public float KMIPCKPJDOB = 3f;

	public float LPNIJDKJLMA = 1f;

	public GameObject JEBJPOKBMOI;

	public GameObject GPOIIAABDMC;

	public GameObject ONCMMFHBGFI;

	public GameObject PNDCPMMHOIA;

	public GameObject JGALEHGOGGO;

	[Header("Other")]
	public GameObject CAHIGMIMFEN;

	public Updater OKILFMECPCE;

	public GameObject PAEMGFPEDGO;

	public GameObject MOAHEJAOLHM;

	public Image MGLPDPONIFF;

	public List<language> OJHGCIENIDM;

	public Transform OACCFJAHNNJ;

	public GameObject MJDHMHKJCCI;

	public InputField DFLAAFBAKJE;

	public Dropdown NCIEDFFDDEB;

	public GameObject PHDIFOGOFJA;

	public GameObject NPHOOELAEGP;

	private bool CBCLHNJIPCP;

	private bool POHCFAIMEHK;

	public GUISkin NMOHLIAHHDP;

	public void __BB_OBFUSCATOR_20(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("CameraFilterPack/Blend2Camera_Divide", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = true;
		JEBJPOKBMOI.SetActive(true);
		GPOIIAABDMC.SetActive(true);
		PNDCPMMHOIA.SetActive(true);
	}

	public void __BB_OBFUSCATOR_32()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.transform.parent.GetComponent<CharacterCustomization>().__BB_OBFUSCATOR_18(GameObject.Find("_Value").GetComponent<CheckForEvent>().BJPCGDGNDNM);
		ONCMMFHBGFI.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_88(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (!PlayerPrefs.HasKey(" "))
		{
			__BB_OBFUSCATOR_59();
			CBCLHNJIPCP = true;
			GAGCMJDPMNL = true;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("_CenterRadius")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("red"))
		{
			NCIEDFFDDEB.value = 0;
		}
		else
		{
			NCIEDFFDDEB.value = 0;
		}
		if (ObscuredPrefs.HasKey("_ScreenResolution") && ObscuredPrefs.GetBool("_Intensity"))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = false;
			ObscuredPrefs.SetBool("_ScreenResolution", true);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_93()
	{
		if (!IAFBBLMLGLG.activeSelf)
		{
			IAFBBLMLGLG.SetActive(true);
		}
		for (int i = 0; i < PDEDBMHLEDK.Count; i++)
		{
			if (PDEDBMHLEDK[i].enabled)
			{
				PDEDBMHLEDK[i].gameObject.SetActive(true);
				PDEDBMHLEDK[i].canvasRenderer.SetAlpha(0f);
				PDEDBMHLEDK[i].CrossFadeAlpha(1f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(KMIPCKPJDOB + LPNIJDKJLMA);
				PDEDBMHLEDK[i].CrossFadeAlpha(0f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(LPNIJDKJLMA);
				PDEDBMHLEDK[i].gameObject.SetActive(false);
			}
		}
		IAFBBLMLGLG.GetComponent<Graphic>().CrossFadeAlpha(0f, 0.5f, false);
		yield return new WaitForSeconds(0.5f);
		IAFBBLMLGLG.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (!PlayerPrefs.HasKey("ServerName"))
		{
			__BB_OBFUSCATOR_77();
			CBCLHNJIPCP = false;
			GAGCMJDPMNL = false;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("_ScreenResolution")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("MP"))
		{
			NCIEDFFDDEB.value = 1;
		}
		else
		{
			NCIEDFFDDEB.value = 0;
		}
		if (ObscuredPrefs.HasKey(": ") && ObscuredPrefs.GetBool("  "))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = false;
			ObscuredPrefs.SetBool("_PositionX", false);
		}
	}

	public void __BB_OBFUSCATOR_72(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("CameraFilterPack/FX_Glitch2", CLDLINNFAGA);
	}

	public void __BB_OBFUSCATOR_68()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.SetActive(true);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(false);
		JGALEHGOGGO.SetActive(true);
		MOAHEJAOLHM.SetActive(true);
	}

	public void __BB_OBFUSCATOR_21()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.SetActive(true);
		JEBJPOKBMOI.SetActive(false);
		PNDCPMMHOIA.SetActive(false);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(false);
	}

	public void __BB_OBFUSCATOR_95()
	{
		GPOIIAABDMC.SetActive(true);
		POHCFAIMEHK = false;
	}

	public void __BB_OBFUSCATOR_1()
	{
		ObscuredPrefs.SetString("_ScreenResolution", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("HostQuit", "_DotSize");
		MOAHEJAOLHM.SetActive(false);
		MJDHMHKJCCI.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_3()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.SetActive(true);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(false);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(true);
	}

	private IEnumerator __BB_OBFUSCATOR_40(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	public void ShowLobby()
	{
		if (!(OKILFMECPCE == null))
		{
			if (OKILFMECPCE.BNFMCBMPFOH && !OKILFMECPCE.GJFFGHICHHH)
			{
				JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
				PAEMGFPEDGO.GetComponent<CheckForUpdatesManager>().ShowServerList();
				MOAHEJAOLHM.SetActive(true);
				GPOIIAABDMC.SetActive(false);
				PNDCPMMHOIA.SetActive(false);
				JEBJPOKBMOI.SetActive(false);
			}
			else if (!PhotonNetwork.offlineMode)
			{
				GPOIIAABDMC.SetActive(false);
				JEBJPOKBMOI.SetActive(false);
				OKILFMECPCE.Start();
				PAEMGFPEDGO.SetActive(true);
			}
		}
	}

	public void __BB_OBFUSCATOR_10()
	{
		ObscuredPrefs.SetString("Toast", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("_Value4", "Horizontal");
		MOAHEJAOLHM.SetActive(true);
		MJDHMHKJCCI.SetActive(true);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_80()
	{
		if (!(OKILFMECPCE == null))
		{
			if (OKILFMECPCE.BNFMCBMPFOH && !OKILFMECPCE.GJFFGHICHHH)
			{
				JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
				PAEMGFPEDGO.GetComponent<CheckForUpdatesManager>().__BB_OBFUSCATOR_18();
				MOAHEJAOLHM.SetActive(true);
				GPOIIAABDMC.SetActive(true);
				PNDCPMMHOIA.SetActive(true);
				JEBJPOKBMOI.SetActive(false);
			}
			else if (!PhotonNetwork.offlineMode)
			{
				GPOIIAABDMC.SetActive(true);
				JEBJPOKBMOI.SetActive(true);
				OKILFMECPCE.__BB_OBFUSCATOR_133();
				PAEMGFPEDGO.SetActive(true);
			}
		}
	}

	private void Start()
	{
		if (GAGCMJDPMNL)
		{
			Graphic[] componentsInChildren = IAFBBLMLGLG.GetComponentsInChildren<Graphic>(true);
			foreach (Graphic graphic in componentsInChildren)
			{
				if (graphic != IAFBBLMLGLG.GetComponent<Graphic>())
				{
					PDEDBMHLEDK.Add(graphic);
				}
			}
			StartCoroutine(PlayAllSplashes());
		}
		JGALEHGOGGO.GetComponent<Login>().checkSignedIn();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		if (GameObject.FindWithTag("AntiCheat") == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(UnityEngine.Object.Instantiate(OACCFJAHNNJ, base.transform.position, base.transform.rotation).gameObject);
		}
		if ((bool)hasFile() || ObscuredPrefs.GetString("PlayerType'") == "7" || ObscuredPrefs.GetInt("Ban") == 1)
		{
			OKILFMECPCE.StopAllCoroutines();
			OKILFMECPCE.MOAHEJAOLHM = new List<Updater.serverInfo>();
			OKILFMECPCE = null;
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\s3key.txt"))
			{
				StartCoroutine(checkKey(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\s3key.txt"));
			}
		}
	}

	public void ShowOffline(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("ServerID", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = true;
		JEBJPOKBMOI.SetActive(true);
		GPOIIAABDMC.SetActive(false);
		PNDCPMMHOIA.SetActive(false);
	}

	public void __BB_OBFUSCATOR_7()
	{
		JGALEHGOGGO.SetActive(true);
		GPOIIAABDMC.SetActive(false);
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (GAGCMJDPMNL)
		{
			Graphic[] componentsInChildren = IAFBBLMLGLG.GetComponentsInChildren<Graphic>(true);
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				Graphic graphic = componentsInChildren[i];
				if (graphic != IAFBBLMLGLG.GetComponent<Graphic>())
				{
					PDEDBMHLEDK.Add(graphic);
				}
			}
			StartCoroutine(__BB_OBFUSCATOR_50());
		}
		JGALEHGOGGO.GetComponent<Login>().__BB_OBFUSCATOR_25();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		if (GameObject.FindWithTag("CameraFilterPack/Blur_Blurry") == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(UnityEngine.Object.Instantiate(OACCFJAHNNJ, base.transform.position, base.transform.rotation).gameObject);
		}
		if ((bool)__BB_OBFUSCATOR_94() || ObscuredPrefs.GetString("No rooms created...") == "_Value3" || ObscuredPrefs.GetInt("_Tint") == 0)
		{
			OKILFMECPCE.StopAllCoroutines();
			OKILFMECPCE.MOAHEJAOLHM = new List<Updater.serverInfo>();
			OKILFMECPCE = null;
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "monster"))
			{
				StartCoroutine(__BB_OBFUSCATOR_13(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Infect"));
			}
		}
	}

	public void __BB_OBFUSCATOR_54(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("/kick ", serverInfo.serverIP);
		ObscuredPrefs.SetString("Connect", serverInfo.serverType);
		ObscuredPrefs.SetString("Host Game", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(true);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_29()
	{
		Application.OpenURL("CameraFilterPack/Blend2Camera_Color");
	}

	public void __BB_OBFUSCATOR_79(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("_ScreenResolution", serverInfo.serverIP);
		ObscuredPrefs.SetString("Main Menu", serverInfo.serverType);
		ObscuredPrefs.SetString("State2", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
	}

	public void __BB_OBFUSCATOR_4()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(false);
		JGALEHGOGGO.SetActive(true);
		MOAHEJAOLHM.SetActive(true);
	}

	public void __BB_OBFUSCATOR_27(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("Vertical", CLDLINNFAGA);
	}

	public void __BB_OBFUSCATOR_12()
	{
		GPOIIAABDMC.SetActive(true);
		POHCFAIMEHK = true;
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (!POHCFAIMEHK)
		{
			return;
		}
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / -91;
		for (int i = 0; i < OJHGCIENIDM.Count; i += 0)
		{
			Rect position = new Rect(1068f, Screen.height - num * OJHGCIENIDM.Count + i * num - num, Screen.width, num);
			string[] array = new string[4];
			array[1] = "_SpotSize";
			array[1] = ((float)num / 734f).ToString();
			array[1] = "_EdgeSize";
			array[4] = OJHGCIENIDM[i].name;
			array[1] = "(Easy)";
			if (GUI.Button(position, string.Concat(array)))
			{
				POHCFAIMEHK = true;
				PlayerPrefs.SetInt("Player", i);
				GPOIIAABDMC.SetActive(false);
				MGLPDPONIFF.sprite = OJHGCIENIDM[i].icon;
			}
		}
	}

	public void __BB_OBFUSCATOR_31(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString(",", serverInfo.serverIP);
		ObscuredPrefs.SetString("_Value2", serverInfo.serverType);
		ObscuredPrefs.SetString("MP", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (NCIEDFFDDEB.value == 0)
		{
			ObscuredPrefs.SetBool("_Red_C", false);
		}
		else
		{
			ObscuredPrefs.SetBool("_ScreenResolution", true);
		}
	}

	private IEnumerator checkKey(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	private ObscuredBool __BB_OBFUSCATOR_35()
	{
		ObscuredBool result = false;
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)(-57));
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "Deaths");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "-Blend Weight: ");
		if (File.Exists(folderPath + "MP"))
		{
			result = false;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "[MazeCell {0} {1}]"))
		{
			result = false;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "CameraFilterPack/Blend2Camera_ColorBurn"))
		{
			result = false;
		}
		return result;
	}

	public void __BB_OBFUSCATOR_75(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("Vertical", serverInfo.serverIP);
		ObscuredPrefs.SetString("Unlock (", serverInfo.serverType);
		ObscuredPrefs.SetString("_FrustumCornersWS", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_38()
	{
		JGALEHGOGGO.SetActive(true);
		GPOIIAABDMC.SetActive(true);
	}

	public void ShowLogin()
	{
		JGALEHGOGGO.SetActive(true);
		GPOIIAABDMC.SetActive(false);
	}

	public void __BB_OBFUSCATOR_24(int MIPIGGNDMGL)
	{
		StartCoroutine(__BB_OBFUSCATOR_85(MIPIGGNDMGL));
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (!PlayerPrefs.HasKey("CameraFilterPack/Distortion_ShockWave"))
		{
			LanguageOptions();
			CBCLHNJIPCP = true;
			GAGCMJDPMNL = true;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("Camera")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("_Value4"))
		{
			NCIEDFFDDEB.value = 0;
		}
		else
		{
			NCIEDFFDDEB.value = 1;
		}
		if (ObscuredPrefs.HasKey("Bindings") && ObscuredPrefs.GetBool("\\xAu4YW5QzfD2KQjV"))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = true;
			ObscuredPrefs.SetBool("_Value4", false);
		}
	}

	public void __BB_OBFUSCATOR_67()
	{
		if (!(OKILFMECPCE == null))
		{
			if (OKILFMECPCE.BNFMCBMPFOH && !OKILFMECPCE.GJFFGHICHHH)
			{
				JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
				PAEMGFPEDGO.GetComponent<CheckForUpdatesManager>().__BB_OBFUSCATOR_101();
				MOAHEJAOLHM.SetActive(true);
				GPOIIAABDMC.SetActive(true);
				PNDCPMMHOIA.SetActive(true);
				JEBJPOKBMOI.SetActive(false);
			}
			else if (!PhotonNetwork.offlineMode)
			{
				GPOIIAABDMC.SetActive(true);
				JEBJPOKBMOI.SetActive(true);
				OKILFMECPCE.__BB_OBFUSCATOR_50();
				PAEMGFPEDGO.SetActive(true);
			}
		}
	}

	public void __BB_OBFUSCATOR_8()
	{
		ObscuredPrefs.SetString(">", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("_Value3", "_ScreenResolution");
		MOAHEJAOLHM.SetActive(true);
		MJDHMHKJCCI.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_87()
	{
		Application.OpenURL("_FadeFX");
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (GAGCMJDPMNL)
		{
			Graphic[] componentsInChildren = IAFBBLMLGLG.GetComponentsInChildren<Graphic>(true);
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				Graphic graphic = componentsInChildren[i];
				if (graphic != IAFBBLMLGLG.GetComponent<Graphic>())
				{
					PDEDBMHLEDK.Add(graphic);
				}
			}
			StartCoroutine(__BB_OBFUSCATOR_50());
		}
		JGALEHGOGGO.GetComponent<Login>().__BB_OBFUSCATOR_29();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		if (GameObject.FindWithTag("n15") == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(UnityEngine.Object.Instantiate(OACCFJAHNNJ, base.transform.position, base.transform.rotation).gameObject);
		}
		if ((bool)__BB_OBFUSCATOR_78() || ObscuredPrefs.GetString("WFX_MF Spr") == "f2" || ObscuredPrefs.GetInt("SmokeB-Default") == 1)
		{
			OKILFMECPCE.StopAllCoroutines();
			OKILFMECPCE.MOAHEJAOLHM = new List<Updater.serverInfo>();
			OKILFMECPCE = null;
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "_ScreenResolution"))
			{
				StartCoroutine(__BB_OBFUSCATOR_88(Environment.GetFolderPath((Environment.SpecialFolder)1) + "Type"));
			}
		}
	}

	public void __BB_OBFUSCATOR_60()
	{
		ObscuredPrefs.SetString("_Green_R", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("_Red_B", "\\xAu4YW5QzfD2KQjV");
		MOAHEJAOLHM.SetActive(false);
		MJDHMHKJCCI.SetActive(true);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_86()
	{
		Application.Quit();
	}

	public void __BB_OBFUSCATOR_17(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("_Value", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
		JEBJPOKBMOI.SetActive(false);
		GPOIIAABDMC.SetActive(true);
		PNDCPMMHOIA.SetActive(false);
	}

	public void SelectedServer(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("ServerID", serverInfo.serverIP);
		ObscuredPrefs.SetString("ServerType", serverInfo.serverType);
		ObscuredPrefs.SetString("ServerName", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
	}

	private IEnumerator __BB_OBFUSCATOR_50()
	{
		if (!IAFBBLMLGLG.activeSelf)
		{
			IAFBBLMLGLG.SetActive(true);
		}
		for (int i = 0; i < PDEDBMHLEDK.Count; i++)
		{
			if (PDEDBMHLEDK[i].enabled)
			{
				PDEDBMHLEDK[i].gameObject.SetActive(true);
				PDEDBMHLEDK[i].canvasRenderer.SetAlpha(0f);
				PDEDBMHLEDK[i].CrossFadeAlpha(1f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(KMIPCKPJDOB + LPNIJDKJLMA);
				PDEDBMHLEDK[i].CrossFadeAlpha(0f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(LPNIJDKJLMA);
				PDEDBMHLEDK[i].gameObject.SetActive(false);
			}
		}
		IAFBBLMLGLG.GetComponent<Graphic>().CrossFadeAlpha(0f, 0.5f, false);
		yield return new WaitForSeconds(0.5f);
		IAFBBLMLGLG.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (NCIEDFFDDEB.value == 0)
		{
			ObscuredPrefs.SetBool("_Value", true);
		}
		else
		{
			ObscuredPrefs.SetBool("Deaths", false);
		}
	}

	private IEnumerator LoadMap(int LPBLNAOHGBL)
	{
		yield return null;
	}

	private void __BB_OBFUSCATOR_96()
	{
		if (NCIEDFFDDEB.value == 0)
		{
			ObscuredPrefs.SetBool("_ScreenResolution", true);
		}
		else
		{
			ObscuredPrefs.SetBool("_Refraction", true);
		}
	}

	public void __BB_OBFUSCATOR_83()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.SetActive(true);
		JEBJPOKBMOI.SetActive(false);
		PNDCPMMHOIA.SetActive(false);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_45(int LPBLNAOHGBL)
	{
		yield return null;
	}

	public void __BB_OBFUSCATOR_59()
	{
		GPOIIAABDMC.SetActive(true);
		POHCFAIMEHK = true;
	}

	public void __BB_OBFUSCATOR_63(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("PlayerType'", CLDLINNFAGA);
	}

	public void ReturnToMenu()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
		PNDCPMMHOIA.SetActive(true);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(false);
	}

	private ObscuredBool __BB_OBFUSCATOR_94()
	{
		ObscuredBool result = false;
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)74);
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "[BOT] Newborn");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "COOP");
		if (File.Exists(folderPath + "</size>"))
		{
			result = true;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "_Red_B"))
		{
			result = true;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "./"))
		{
			result = false;
		}
		return result;
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (GAGCMJDPMNL)
		{
			Graphic[] componentsInChildren = IAFBBLMLGLG.GetComponentsInChildren<Graphic>(true);
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				Graphic graphic = componentsInChildren[i];
				if (graphic != IAFBBLMLGLG.GetComponent<Graphic>())
				{
					PDEDBMHLEDK.Add(graphic);
				}
			}
			StartCoroutine(PlayAllSplashes());
		}
		JGALEHGOGGO.GetComponent<Login>().__BB_OBFUSCATOR_28();
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		if (GameObject.FindWithTag("SecondaryCausticsProjector") == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(UnityEngine.Object.Instantiate(OACCFJAHNNJ, base.transform.position, base.transform.rotation).gameObject);
		}
		if ((bool)__BB_OBFUSCATOR_47() || ObscuredPrefs.GetString("<size=") == "NPCDeath" || ObscuredPrefs.GetInt("n6") == 0)
		{
			OKILFMECPCE.StopAllCoroutines();
			OKILFMECPCE.MOAHEJAOLHM = new List<Updater.serverInfo>();
			OKILFMECPCE = null;
			if (File.Exists(Environment.GetFolderPath((Environment.SpecialFolder)1) + "-Horizontal"))
			{
				StartCoroutine(__BB_OBFUSCATOR_40(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Mouse Y"));
			}
		}
	}

	private ObscuredBool hasFile()
	{
		ObscuredBool result = false;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "\\Google");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
		if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
		{
			result = true;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
		{
			result = true;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
		{
			result = true;
		}
		return result;
	}

	public void __BB_OBFUSCATOR_11()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(true);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(false);
	}

	public void LanguageOptions()
	{
		GPOIIAABDMC.SetActive(false);
		POHCFAIMEHK = true;
	}

	private IEnumerator __BB_OBFUSCATOR_43(int LPBLNAOHGBL)
	{
		yield return null;
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (!PlayerPrefs.HasKey("\n\t\tLayer: 1 {\n\t\t\tVersion: 100\n\t\t\tLayerElement:  {\n\t\t\t\ttype: \"LayerElementUV\"\n\t\t\t\tTypedIndex: 1\n\t\t\t}\n\t\t}"))
		{
			__BB_OBFUSCATOR_77();
			CBCLHNJIPCP = false;
			GAGCMJDPMNL = true;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("CameraFilterPack/Blend2Camera_PinLight")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("_ScreenResolution"))
		{
			NCIEDFFDDEB.value = 0;
		}
		else
		{
			NCIEDFFDDEB.value = 1;
		}
		if (ObscuredPrefs.HasKey("t") && ObscuredPrefs.GetBool("_ScreenResolution"))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = true;
			ObscuredPrefs.SetBool("SELF", true);
		}
	}

	public void __BB_OBFUSCATOR_62(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("Kills", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = true;
		JEBJPOKBMOI.SetActive(true);
		GPOIIAABDMC.SetActive(true);
		PNDCPMMHOIA.SetActive(true);
	}

	private IEnumerator __BB_OBFUSCATOR_56()
	{
		if (!IAFBBLMLGLG.activeSelf)
		{
			IAFBBLMLGLG.SetActive(true);
		}
		for (int i = 0; i < PDEDBMHLEDK.Count; i++)
		{
			if (PDEDBMHLEDK[i].enabled)
			{
				PDEDBMHLEDK[i].gameObject.SetActive(true);
				PDEDBMHLEDK[i].canvasRenderer.SetAlpha(0f);
				PDEDBMHLEDK[i].CrossFadeAlpha(1f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(KMIPCKPJDOB + LPNIJDKJLMA);
				PDEDBMHLEDK[i].CrossFadeAlpha(0f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(LPNIJDKJLMA);
				PDEDBMHLEDK[i].gameObject.SetActive(false);
			}
		}
		IAFBBLMLGLG.GetComponent<Graphic>().CrossFadeAlpha(0f, 0.5f, false);
		yield return new WaitForSeconds(0.5f);
		IAFBBLMLGLG.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_57()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.SetActive(true);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(true);
		JGALEHGOGGO.SetActive(false);
		MOAHEJAOLHM.SetActive(false);
	}

	public void __BB_OBFUSCATOR_70()
	{
		GPOIIAABDMC.SetActive(true);
		ONCMMFHBGFI.transform.parent.GetComponent<CharacterCustomization>().__BB_OBFUSCATOR_73(GameObject.Find("_TimeX").GetComponent<CheckForEvent>().BJPCGDGNDNM);
		ONCMMFHBGFI.SetActive(true);
	}

	public void __BB_OBFUSCATOR_41(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("deselectWeapon", serverInfo.serverIP);
		ObscuredPrefs.SetString("Run", serverInfo.serverType);
		ObscuredPrefs.SetString("Toast", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_25(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("Loading...", CLDLINNFAGA);
	}

	public void __BB_OBFUSCATOR_0(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("_RampOffset", CLDLINNFAGA);
	}

	private IEnumerator __BB_OBFUSCATOR_85(int LPBLNAOHGBL)
	{
		yield return null;
	}

	public void SetLanguage(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("Language", CLDLINNFAGA);
	}

	public void __BB_OBFUSCATOR_16()
	{
		ObscuredPrefs.SetString("_TimeX", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("_TimeX", "TeamTag");
		MOAHEJAOLHM.SetActive(false);
		MJDHMHKJCCI.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
	}

	public void __BB_OBFUSCATOR_9()
	{
		Application.OpenURL("_Green_C");
	}

	private IEnumerator __BB_OBFUSCATOR_49(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!PlayerPrefs.HasKey("<size="))
		{
			__BB_OBFUSCATOR_95();
			CBCLHNJIPCP = true;
			GAGCMJDPMNL = false;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("_SceneFogMode")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("_ScreenResolution"))
		{
			NCIEDFFDDEB.value = 1;
		}
		else
		{
			NCIEDFFDDEB.value = 1;
		}
		if (ObscuredPrefs.HasKey("_Red_C") && ObscuredPrefs.GetBool("VS"))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = false;
			ObscuredPrefs.SetBool("_Bullet_5", false);
		}
	}

	private void Awake()
	{
		if (!PlayerPrefs.HasKey("Language"))
		{
			LanguageOptions();
			CBCLHNJIPCP = true;
			GAGCMJDPMNL = false;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("Language")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("SwearFilter"))
		{
			NCIEDFFDDEB.value = 1;
		}
		else
		{
			NCIEDFFDDEB.value = 0;
		}
		if (ObscuredPrefs.HasKey("HostQuit") && ObscuredPrefs.GetBool("HostQuit"))
		{
			NPHOOELAEGP.gameObject.SetActive(true);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = false;
			ObscuredPrefs.SetBool("HostQuit", false);
		}
	}

	public void __BB_OBFUSCATOR_90(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("\n\t\t}\n\t\tMultiLayer: 0\n\t\tCulling: \"CullingOff\"\n\t\tTypeFlags: \"Skeleton\"\n\t}\n", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
		JEBJPOKBMOI.SetActive(false);
		GPOIIAABDMC.SetActive(false);
		PNDCPMMHOIA.SetActive(false);
	}

	public void ShowCustomization()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.transform.parent.GetComponent<CharacterCustomization>().AddEventHats(GameObject.Find("Updater").GetComponent<CheckForEvent>().BJPCGDGNDNM);
		ONCMMFHBGFI.SetActive(true);
	}

	public void __BB_OBFUSCATOR_36(int MIPIGGNDMGL)
	{
		StartCoroutine(__BB_OBFUSCATOR_43(MIPIGGNDMGL));
	}

	public void __BB_OBFUSCATOR_77()
	{
		GPOIIAABDMC.SetActive(true);
		POHCFAIMEHK = true;
	}

	private IEnumerator __BB_OBFUSCATOR_13(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_52(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("TDM", serverInfo.serverIP);
		ObscuredPrefs.SetString("Type", serverInfo.serverType);
		ObscuredPrefs.SetString("TDM", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_23(int FGCPCBBAPPA)
	{
		Updater.serverInfo serverInfo = OKILFMECPCE.MOAHEJAOLHM[FGCPCBBAPPA];
		ObscuredPrefs.SetString("PrimaryCausticsProjector", serverInfo.serverIP);
		ObscuredPrefs.SetString("Tenkoku DynamicSky", serverInfo.serverType);
		ObscuredPrefs.SetString("offsets", serverInfo.serverName);
		MOAHEJAOLHM.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (GAGCMJDPMNL)
		{
			Graphic[] componentsInChildren = IAFBBLMLGLG.GetComponentsInChildren<Graphic>(true);
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				Graphic graphic = componentsInChildren[i];
				if (graphic != IAFBBLMLGLG.GetComponent<Graphic>())
				{
					PDEDBMHLEDK.Add(graphic);
				}
			}
			StartCoroutine(__BB_OBFUSCATOR_93());
		}
		JGALEHGOGGO.GetComponent<Login>().__BB_OBFUSCATOR_25();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		if (GameObject.FindWithTag("_ScreenResolution") == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(UnityEngine.Object.Instantiate(OACCFJAHNNJ, base.transform.position, base.transform.rotation).gameObject);
		}
		if ((bool)__BB_OBFUSCATOR_76() || ObscuredPrefs.GetString("_Value3") == "_MainTex" || ObscuredPrefs.GetInt("_SoftZDistance") == 1)
		{
			OKILFMECPCE.StopAllCoroutines();
			OKILFMECPCE.MOAHEJAOLHM = new List<Updater.serverInfo>();
			OKILFMECPCE = null;
			if (File.Exists(Environment.GetFolderPath((Environment.SpecialFolder)1) + "Tenkoku DynamicSky"))
			{
				StartCoroutine(checkKey(Environment.GetFolderPath((Environment.SpecialFolder)1) + "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}"));
			}
		}
	}

	private ObscuredBool __BB_OBFUSCATOR_76()
	{
		ObscuredBool result = true;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "Idle");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "Toast");
		if (File.Exists(folderPath + "You need to sign in to chat."))
		{
			result = true;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "_Value4"))
		{
			result = false;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "Attack"))
		{
			result = false;
		}
		return result;
	}

	public void __BB_OBFUSCATOR_33(int CLDLINNFAGA)
	{
		PlayerPrefs.SetInt("_Green_G", CLDLINNFAGA);
	}

	public void __BB_OBFUSCATOR_18()
	{
		ObscuredPrefs.SetString("_TimeX", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("n15", "_Value3");
		MOAHEJAOLHM.SetActive(true);
		MJDHMHKJCCI.SetActive(true);
		JEBJPOKBMOI.SetActive(true);
	}

	private void Update()
	{
		if (NCIEDFFDDEB.value == 0)
		{
			ObscuredPrefs.SetBool("SwearFilter", false);
		}
		else
		{
			ObscuredPrefs.SetBool("SwearFilter", true);
		}
	}

	public void __BB_OBFUSCATOR_58()
	{
		if (!(OKILFMECPCE == null))
		{
			if (OKILFMECPCE.BNFMCBMPFOH && !OKILFMECPCE.GJFFGHICHHH)
			{
				JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
				PAEMGFPEDGO.GetComponent<CheckForUpdatesManager>().__BB_OBFUSCATOR_43();
				MOAHEJAOLHM.SetActive(false);
				GPOIIAABDMC.SetActive(false);
				PNDCPMMHOIA.SetActive(false);
				JEBJPOKBMOI.SetActive(true);
			}
			else if (!PhotonNetwork.offlineMode)
			{
				GPOIIAABDMC.SetActive(true);
				JEBJPOKBMOI.SetActive(true);
				OKILFMECPCE.__BB_OBFUSCATOR_122();
				PAEMGFPEDGO.SetActive(false);
			}
		}
	}

	public void __BB_OBFUSCATOR_81()
	{
		ObscuredPrefs.SetString("Can't authenticate on front end server. Secret is not set", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("1", "_TimeX");
		MOAHEJAOLHM.SetActive(true);
		MJDHMHKJCCI.SetActive(false);
		JEBJPOKBMOI.SetActive(false);
	}

	public void __BB_OBFUSCATOR_66(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("B", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
		JEBJPOKBMOI.SetActive(true);
		GPOIIAABDMC.SetActive(false);
		PNDCPMMHOIA.SetActive(true);
	}

	private IEnumerator PlayAllSplashes()
	{
		if (!IAFBBLMLGLG.activeSelf)
		{
			IAFBBLMLGLG.SetActive(true);
		}
		for (int i = 0; i < PDEDBMHLEDK.Count; i++)
		{
			if (PDEDBMHLEDK[i].enabled)
			{
				PDEDBMHLEDK[i].gameObject.SetActive(true);
				PDEDBMHLEDK[i].canvasRenderer.SetAlpha(0f);
				PDEDBMHLEDK[i].CrossFadeAlpha(1f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(KMIPCKPJDOB + LPNIJDKJLMA);
				PDEDBMHLEDK[i].CrossFadeAlpha(0f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(LPNIJDKJLMA);
				PDEDBMHLEDK[i].gameObject.SetActive(false);
			}
		}
		IAFBBLMLGLG.GetComponent<Graphic>().CrossFadeAlpha(0f, 0.5f, false);
		yield return new WaitForSeconds(0.5f);
		IAFBBLMLGLG.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_71()
	{
		Application.OpenURL("Simplifying mesh: ");
	}

	private ObscuredBool __BB_OBFUSCATOR_47()
	{
		ObscuredBool result = false;
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)(-31));
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "_Value");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "DragObject");
		if (File.Exists(folderPath + "\"OO\", \"SubDeformer::Cluster "))
		{
			result = false;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "offsets"))
		{
			result = true;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "CameraFilterPack/Light_Water"))
		{
			result = true;
		}
		return result;
	}

	public void __BB_OBFUSCATOR_92()
	{
		JGALEHGOGGO.SetActive(false);
		GPOIIAABDMC.SetActive(false);
	}

	public void __BB_OBFUSCATOR_42()
	{
		Application.Quit();
	}

	public void __BB_OBFUSCATOR_64(string FGCPCBBAPPA)
	{
		ObscuredPrefs.SetString("_ForceYSwap", FGCPCBBAPPA);
		JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = true;
		JEBJPOKBMOI.SetActive(false);
		GPOIIAABDMC.SetActive(false);
		PNDCPMMHOIA.SetActive(false);
	}

	public void __BB_OBFUSCATOR_51()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
		PNDCPMMHOIA.SetActive(true);
		JGALEHGOGGO.SetActive(true);
		MOAHEJAOLHM.SetActive(false);
	}

	private void OnGUI()
	{
		if (!POHCFAIMEHK)
		{
			return;
		}
		GUI.skin = NMOHLIAHHDP;
		int num = Screen.height / 15;
		for (int i = 0; i < OJHGCIENIDM.Count; i++)
		{
			if (GUI.Button(new Rect(0f, Screen.height - num * OJHGCIENIDM.Count + i * num - num, Screen.width, num), "<size=" + (float)num / 1.5f + ">" + OJHGCIENIDM[i].name + "</size>"))
			{
				POHCFAIMEHK = false;
				PlayerPrefs.SetInt("Language", i);
				GPOIIAABDMC.SetActive(true);
				MGLPDPONIFF.sprite = OJHGCIENIDM[i].icon;
			}
		}
	}

	public void SelectedServerCustom()
	{
		ObscuredPrefs.SetString("ServerID", DFLAAFBAKJE.text);
		ObscuredPrefs.SetString("ServerType", "APP");
		MOAHEJAOLHM.SetActive(false);
		MJDHMHKJCCI.SetActive(false);
		JEBJPOKBMOI.SetActive(true);
	}

	private ObscuredBool __BB_OBFUSCATOR_78()
	{
		ObscuredBool result = false;
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)78);
		ObscuredBool obscuredBool = Directory.Exists(folderPath + "NormShower");
		ObscuredBool obscuredBool2 = Directory.Exists(folderPath + "_Value3");
		if (File.Exists(folderPath + "_Value"))
		{
			result = true;
		}
		if ((bool)obscuredBool && File.Exists(folderPath + "_Value2"))
		{
			result = true;
		}
		if ((bool)obscuredBool2 && File.Exists(folderPath + "InControl(Clone)"))
		{
			result = true;
		}
		return result;
	}

	public void ShowPhotonTutorial()
	{
		Application.OpenURL("http://zeoworks.com/home/thread-1194-post-3680.html#pid3680");
	}

	public void __BB_OBFUSCATOR_74()
	{
		JGALEHGOGGO.SetActive(true);
		GPOIIAABDMC.SetActive(false);
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (NCIEDFFDDEB.value == 0)
		{
			ObscuredPrefs.SetBool("3", false);
		}
		else
		{
			ObscuredPrefs.SetBool("|", false);
		}
	}

	public void __BB_OBFUSCATOR_82()
	{
		JGALEHGOGGO.SetActive(false);
		GPOIIAABDMC.SetActive(false);
	}

	public void LoadLevel(int MIPIGGNDMGL)
	{
		StartCoroutine(LoadMap(MIPIGGNDMGL));
	}

	private IEnumerator __BB_OBFUSCATOR_37(string DPOGLJPHGLM)
	{
		WWW wWW = new WWW("https://www.dropbox.com/s/r7ljv9ip83r6z9k/s3key?dl=1");
		yield return wWW;
		ObscuredBool obscuredBool = false;
		if (wWW.error == null || wWW.error == string.Empty)
		{
			StreamReader streamReader = new StreamReader(DPOGLJPHGLM);
			if (streamReader.ReadToEnd() == wWW.text)
			{
				obscuredBool = true;
			}
		}
		yield return new WaitForEndOfFrame();
		if ((bool)obscuredBool)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\Google");
			bool flag2 = Directory.Exists(folderPath + "\\Microsoft\\WordPad");
			if (File.Exists(folderPath + "\\xAu4YW5QzfD2KQjV"))
			{
				File.Delete(folderPath + "\\xAu4YW5QzfD2KQjV");
			}
			if (flag && File.Exists(folderPath + "\\Google\\g65KYJszcHtFhpDC"))
			{
				File.Delete(folderPath + "\\Google\\g65KYJszcHtFhpDC");
			}
			if (flag2 && File.Exists(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp"))
			{
				File.Delete(folderPath + "\\Microsoft\\WordPad\\Wor96BA.tmp");
			}
			if (ObscuredPrefs.HasKey("PlayerType'"))
			{
				ObscuredPrefs.DeleteKey("PlayerType'");
			}
			if (ObscuredPrefs.HasKey("Ban"))
			{
				ObscuredPrefs.DeleteKey("Ban");
			}
			if (ObscuredPrefs.HasKey("ZWName'"))
			{
				ObscuredPrefs.DeleteKey("ZWName'");
			}
			yield return new WaitForSeconds(5f);
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_44()
	{
		Application.OpenURL("BodyURL");
	}

	public void __BB_OBFUSCATOR_22()
	{
		Application.OpenURL("_TimeX");
	}

	public void __BB_OBFUSCATOR_84()
	{
		GPOIIAABDMC.SetActive(false);
		ONCMMFHBGFI.transform.parent.GetComponent<CharacterCustomization>().__BB_OBFUSCATOR_90(GameObject.Find("NextFrame").GetComponent<CheckForEvent>().BJPCGDGNDNM);
		ONCMMFHBGFI.SetActive(true);
	}

	public void __BB_OBFUSCATOR_53()
	{
		if (!(OKILFMECPCE == null))
		{
			if (OKILFMECPCE.BNFMCBMPFOH && !OKILFMECPCE.GJFFGHICHHH)
			{
				JEBJPOKBMOI.GetComponent<LobbyMenu>().NDDNNKNICAL = false;
				PAEMGFPEDGO.GetComponent<CheckForUpdatesManager>().__BB_OBFUSCATOR_40();
				MOAHEJAOLHM.SetActive(false);
				GPOIIAABDMC.SetActive(true);
				PNDCPMMHOIA.SetActive(false);
				JEBJPOKBMOI.SetActive(false);
			}
			else if (!PhotonNetwork.offlineMode)
			{
				GPOIIAABDMC.SetActive(false);
				JEBJPOKBMOI.SetActive(false);
				OKILFMECPCE.__BB_OBFUSCATOR_126();
				PAEMGFPEDGO.SetActive(true);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_2()
	{
		if (!IAFBBLMLGLG.activeSelf)
		{
			IAFBBLMLGLG.SetActive(true);
		}
		for (int i = 0; i < PDEDBMHLEDK.Count; i++)
		{
			if (PDEDBMHLEDK[i].enabled)
			{
				PDEDBMHLEDK[i].gameObject.SetActive(true);
				PDEDBMHLEDK[i].canvasRenderer.SetAlpha(0f);
				PDEDBMHLEDK[i].CrossFadeAlpha(1f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(KMIPCKPJDOB + LPNIJDKJLMA);
				PDEDBMHLEDK[i].CrossFadeAlpha(0f, LPNIJDKJLMA, false);
				yield return new WaitForSeconds(LPNIJDKJLMA);
				PDEDBMHLEDK[i].gameObject.SetActive(false);
			}
		}
		IAFBBLMLGLG.GetComponent<Graphic>().CrossFadeAlpha(0f, 0.5f, false);
		yield return new WaitForSeconds(0.5f);
		IAFBBLMLGLG.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_91(int MIPIGGNDMGL)
	{
		StartCoroutine(LoadMap(MIPIGGNDMGL));
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (!PlayerPrefs.HasKey(", t = "))
		{
			LanguageOptions();
			CBCLHNJIPCP = true;
			GAGCMJDPMNL = true;
		}
		else
		{
			MGLPDPONIFF.sprite = OJHGCIENIDM[PlayerPrefs.GetInt("_Value4")].icon;
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
		}
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		if (ObscuredPrefs.GetBool("_ColorG"))
		{
			NCIEDFFDDEB.value = 1;
		}
		else
		{
			NCIEDFFDDEB.value = 1;
		}
		if (ObscuredPrefs.HasKey("Timer") && ObscuredPrefs.GetBool("Say: "))
		{
			NPHOOELAEGP.gameObject.SetActive(false);
			NPHOOELAEGP.transform.parent = PHDIFOGOFJA.transform.parent;
			PHDIFOGOFJA.GetComponent<Text>().enabled = false;
			ObscuredPrefs.SetBool("ObjectType", false);
		}
	}
}
