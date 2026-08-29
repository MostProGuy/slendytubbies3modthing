using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
{
	[Serializable]
	public class serverInfo
	{
		public string serverName;

		public string serverType;

		public string serverIP;
	}

	public string OOAJDCCHNLC = "1.0";

	public int IJJLOKLELAN;

	public string[] BGKBFABPJJC;

	public bool BNFMCBMPFOH;

	public bool GJFFGHICHHH;

	public Text GIBJJPNCONI;

	public List<serverInfo> MOAHEJAOLHM;

	private IEnumerator __BB_OBFUSCATOR_109()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_45()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_32());
		}
		GIBJJPNCONI.text = "Respawn in" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_93()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_131()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_5()
	{
		Application.OpenURL("Custards");
	}

	public void __BB_OBFUSCATOR_110()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_60());
		}
		GIBJJPNCONI.text = "_ScreenResolution" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_75()
	{
		Application.OpenURL("in: ");
	}

	private IEnumerator __BB_OBFUSCATOR_22()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_4()
	{
		StartCoroutine(__BB_OBFUSCATOR_109());
	}

	private IEnumerator __BB_OBFUSCATOR_123()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_77()
	{
		Application.OpenURL("MP");
	}

	private IEnumerator __BB_OBFUSCATOR_1()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_8()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_82());
		}
		GIBJJPNCONI.text = "MP" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_60()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_21()
	{
		Application.OpenURL("_TimeX");
	}

	public void __BB_OBFUSCATOR_89()
	{
		Application.OpenURL("_EdgeSize");
	}

	public void __BB_OBFUSCATOR_3()
	{
		StartCoroutine(__BB_OBFUSCATOR_93());
	}

	private IEnumerator __BB_OBFUSCATOR_70()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_53()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_85()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_30()
	{
		StartCoroutine(__BB_OBFUSCATOR_62());
	}

	public void __BB_OBFUSCATOR_2()
	{
		StartCoroutine(__BB_OBFUSCATOR_112());
	}

	private IEnumerator __BB_OBFUSCATOR_0()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_46()
	{
		Application.OpenURL("Hidden/GlobalFog");
	}

	public void __BB_OBFUSCATOR_81()
	{
		Application.OpenURL("VS");
	}

	public void __BB_OBFUSCATOR_133()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_18());
		}
		GIBJJPNCONI.text = "No secret in authentication response." + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_40()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_82()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_11()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_136());
		}
		GIBJJPNCONI.text = "SyncNPCCount" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_15()
	{
		Application.OpenURL("_ReflectionTex");
	}

	public void __BB_OBFUSCATOR_117()
	{
		StartCoroutine(__BB_OBFUSCATOR_79());
	}

	public void __BB_OBFUSCATOR_17()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_20());
		}
		GIBJJPNCONI.text = "CameraFilterPack/Vision_Aura" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_26()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_119()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_70());
		}
		GIBJJPNCONI.text = "_Green_B" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_128()
	{
		StartCoroutine(__BB_OBFUSCATOR_85());
	}

	private IEnumerator __BB_OBFUSCATOR_9()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_32()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_124()
	{
		StartCoroutine(__BB_OBFUSCATOR_53());
	}

	public void __BB_OBFUSCATOR_41()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_1());
		}
		GIBJJPNCONI.text = "Deaths" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_67()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_107()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_20()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_106()
	{
		StartCoroutine(__BB_OBFUSCATOR_109());
	}

	public void Start()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(CheckForUpdate());
		}
		GIBJJPNCONI.text = "V" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_24()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_121()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_136());
		}
		GIBJJPNCONI.text = "CameraFilterPack/TV_Video3D" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_104()
	{
		StartCoroutine(__BB_OBFUSCATOR_79());
	}

	public void __BB_OBFUSCATOR_10()
	{
		Application.OpenURL("CameraFilterPack/Glitch_Mozaic");
	}

	public void __BB_OBFUSCATOR_52()
	{
		Application.OpenURL("_FadeFX");
	}

	private IEnumerator CheckForUpdate()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_113()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_65()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_26());
		}
		GIBJJPNCONI.text = "_Value" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_68()
	{
		StartCoroutine(__BB_OBFUSCATOR_113());
	}

	public void PrepareServerList()
	{
		StartCoroutine(GetServerList());
	}

	public void __BB_OBFUSCATOR_42()
	{
		StartCoroutine(__BB_OBFUSCATOR_67());
	}

	public void __BB_OBFUSCATOR_74()
	{
		Application.OpenURL("_ScreenResolution");
	}

	public void __BB_OBFUSCATOR_27()
	{
		Application.OpenURL("Type");
	}

	public void __BB_OBFUSCATOR_33()
	{
		StartCoroutine(__BB_OBFUSCATOR_116());
	}

	private IEnumerator __BB_OBFUSCATOR_108()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_58()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_56()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_125()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_59()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(CheckForUpdate());
		}
		GIBJJPNCONI.text = "DoDamage" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_129()
	{
		StartCoroutine(__BB_OBFUSCATOR_69());
	}

	public void __BB_OBFUSCATOR_134()
	{
		StartCoroutine(__BB_OBFUSCATOR_85());
	}

	public void __BB_OBFUSCATOR_103()
	{
		StartCoroutine(__BB_OBFUSCATOR_53());
	}

	private IEnumerator __BB_OBFUSCATOR_112()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_6()
	{
		Application.OpenURL("_Distortion");
	}

	public void __BB_OBFUSCATOR_12()
	{
		Application.OpenURL("_TimeX");
	}

	public void __BB_OBFUSCATOR_122()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_82());
		}
		GIBJJPNCONI.text = "ERROR" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_71()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_22());
		}
		GIBJJPNCONI.text = "FlyCam" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_19()
	{
		StartCoroutine(__BB_OBFUSCATOR_113());
	}

	public void __BB_OBFUSCATOR_92()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_70());
		}
		GIBJJPNCONI.text = "_respawnAfter" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_64()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_90()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_78()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_58());
		}
		GIBJJPNCONI.text = "Kills" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_48()
	{
		Application.OpenURL("_TimeX");
	}

	public void __BB_OBFUSCATOR_47()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_9());
		}
		GIBJJPNCONI.text = "/" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_62()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_29()
	{
		StartCoroutine(__BB_OBFUSCATOR_51());
	}

	private IEnumerator __BB_OBFUSCATOR_61()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_55()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_116()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_69()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_39()
	{
		StartCoroutine(__BB_OBFUSCATOR_109());
	}

	private IEnumerator __BB_OBFUSCATOR_127()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_136()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void UpdateNow()
	{
		Application.OpenURL("http://zeoworks.com/home/other/s3update.html");
	}

	public void __BB_OBFUSCATOR_37()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_107());
		}
		GIBJJPNCONI.text = ", 2: " + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_76()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_126()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_131());
		}
		GIBJJPNCONI.text = "_ScreenResolution" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_28()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_98()
	{
		StartCoroutine(__BB_OBFUSCATOR_109());
	}

	public void __BB_OBFUSCATOR_63()
	{
		StartCoroutine(__BB_OBFUSCATOR_28());
	}

	public void __BB_OBFUSCATOR_100()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_125());
		}
		GIBJJPNCONI.text = "_ScreenResolution" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_31()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_125());
		}
		GIBJJPNCONI.text = "_Value" + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_14()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_96()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_101()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_26());
		}
		GIBJJPNCONI.text = "-Current Speed: " + OOAJDCCHNLC;
	}

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	private IEnumerator __BB_OBFUSCATOR_79()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_130()
	{
		Application.OpenURL("Team1Score");
	}

	private IEnumerator GetServerList()
	{
		MOAHEJAOLHM = new List<serverInfo>();
		WWW wWW = new WWW("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1");
		yield return wWW;
		string[] array = wWW.text.Split("\n"[0]);
		foreach (string text in array)
		{
			string[] array2 = text.Split(":"[0]);
			serverInfo serverInfo = new serverInfo();
			serverInfo.serverType = array2[0];
			serverInfo.serverName = array2[1];
			serverInfo.serverIP = array2[2];
			MOAHEJAOLHM.Add(serverInfo);
		}
		GJFFGHICHHH = false;
	}

	public void __BB_OBFUSCATOR_132()
	{
		StartCoroutine(__BB_OBFUSCATOR_67());
	}

	public void __BB_OBFUSCATOR_43()
	{
		StartCoroutine(__BB_OBFUSCATOR_62());
	}

	private IEnumerator __BB_OBFUSCATOR_18()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_118()
	{
		StartCoroutine(__BB_OBFUSCATOR_108());
	}

	public void __BB_OBFUSCATOR_91()
	{
		StartCoroutine(__BB_OBFUSCATOR_35());
	}

	public void __BB_OBFUSCATOR_135()
	{
		StartCoroutine(__BB_OBFUSCATOR_64());
	}

	public void __BB_OBFUSCATOR_95()
	{
		StartCoroutine(__BB_OBFUSCATOR_112());
	}

	public void __BB_OBFUSCATOR_7()
	{
		StartCoroutine(__BB_OBFUSCATOR_62());
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		GJFFGHICHHH = true;
		WWW wWW = new WWW("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1");
		yield return wWW;
		BGKBFABPJJC = wWW.text.Split(":"[0]);
		if (BGKBFABPJJC.Length > IJJLOKLELAN && BGKBFABPJJC[IJJLOKLELAN] == OOAJDCCHNLC)
		{
			BNFMCBMPFOH = true;
		}
		if (BNFMCBMPFOH)
		{
			PrepareServerList();
		}
		else
		{
			GJFFGHICHHH = false;
		}
	}

	public void __BB_OBFUSCATOR_50()
	{
		if (!GJFFGHICHHH)
		{
			StartCoroutine(__BB_OBFUSCATOR_9());
		}
		GIBJJPNCONI.text = "_TimeX" + OOAJDCCHNLC;
	}

	public void __BB_OBFUSCATOR_111()
	{
		Application.OpenURL("_Tint");
	}
}
