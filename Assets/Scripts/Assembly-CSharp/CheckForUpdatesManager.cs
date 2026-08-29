using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CheckForUpdatesManager : MonoBehaviour
{
	public GameObject BFGCEBCMFIC;

	public MainMenu LFKDLNLJOPE;

	public Updater OKILFMECPCE;

	public Text[] GHJIPHIEHMJ;

	private IEnumerator __BB_OBFUSCATOR_52()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator WaitForFinish()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_91()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_81()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Value" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		StartCoroutine(__BB_OBFUSCATOR_83());
	}

	private IEnumerator __BB_OBFUSCATOR_36()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_49()
	{
		StartCoroutine(__BB_OBFUSCATOR_12());
	}

	private void __BB_OBFUSCATOR_77()
	{
		StartCoroutine(__BB_OBFUSCATOR_4());
	}

	public void ShowServerList()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + " " + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_57()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "Failed on creating room" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_21()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Color" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		StartCoroutine(__BB_OBFUSCATOR_75());
	}

	private IEnumerator __BB_OBFUSCATOR_4()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_43()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Offsets" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_34()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Level" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_18()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_ScreenResolution" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		StartCoroutine(__BB_OBFUSCATOR_78());
	}

	private IEnumerator __BB_OBFUSCATOR_54()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_88()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_62()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_84()
	{
		StartCoroutine(__BB_OBFUSCATOR_12());
	}

	private void __BB_OBFUSCATOR_28()
	{
		StartCoroutine(__BB_OBFUSCATOR_62());
	}

	public void __BB_OBFUSCATOR_40()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Distortion" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		StartCoroutine(__BB_OBFUSCATOR_47());
	}

	public void __BB_OBFUSCATOR_70()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "Hat:" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		StartCoroutine(__BB_OBFUSCATOR_54());
	}

	private void __BB_OBFUSCATOR_100()
	{
		StartCoroutine(__BB_OBFUSCATOR_35());
	}

	public void __BB_OBFUSCATOR_96()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_ColorBuffer" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_82()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "CameraFilterPack/FX_Funk" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void OnEnable()
	{
		StartCoroutine(WaitForFinish());
	}

	public void __BB_OBFUSCATOR_27()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Value" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_10()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_16()
	{
		StartCoroutine(__BB_OBFUSCATOR_38());
	}

	private IEnumerator __BB_OBFUSCATOR_44()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_3()
	{
		StartCoroutine(__BB_OBFUSCATOR_12());
	}

	private void __BB_OBFUSCATOR_74()
	{
		StartCoroutine(__BB_OBFUSCATOR_44());
	}

	public void __BB_OBFUSCATOR_59()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "TeamName" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		StartCoroutine(__BB_OBFUSCATOR_38());
	}

	public void __BB_OBFUSCATOR_32()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "<size=" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_0()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "</size>" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_47()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_79()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_ScreenResolution" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_69()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "Shop" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_63()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Value" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		StartCoroutine(__BB_OBFUSCATOR_78());
	}

	private IEnumerator __BB_OBFUSCATOR_7()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_23()
	{
		StartCoroutine(__BB_OBFUSCATOR_4());
	}

	private void __BB_OBFUSCATOR_11()
	{
		StartCoroutine(__BB_OBFUSCATOR_36());
	}

	public void __BB_OBFUSCATOR_22()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Value" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_25()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "Survivors" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_101()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_ProjInfo" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_38()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_78()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_45()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_71()
	{
		StartCoroutine(__BB_OBFUSCATOR_36());
	}

	private IEnumerator __BB_OBFUSCATOR_53()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_33()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "Can't authenticate on front end server. Authentication Values are not set" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_15()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	public void __BB_OBFUSCATOR_65()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "{0}:{1}" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_83()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_66()
	{
		StartCoroutine(__BB_OBFUSCATOR_51());
	}

	private void __BB_OBFUSCATOR_64()
	{
		StartCoroutine(__BB_OBFUSCATOR_54());
	}

	private IEnumerator __BB_OBFUSCATOR_60()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_75()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_46()
	{
		StartCoroutine(__BB_OBFUSCATOR_75());
	}

	public void __BB_OBFUSCATOR_24()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(true);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "CameraFilterPack/Blend2Camera_ColorDodge" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		StartCoroutine(__BB_OBFUSCATOR_91());
	}

	private void __BB_OBFUSCATOR_80()
	{
		StartCoroutine(__BB_OBFUSCATOR_60());
	}

	private void __BB_OBFUSCATOR_2()
	{
		StartCoroutine(__BB_OBFUSCATOR_78());
	}

	private IEnumerator __BB_OBFUSCATOR_12()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private void __BB_OBFUSCATOR_61()
	{
		StartCoroutine(__BB_OBFUSCATOR_35());
	}

	public void __BB_OBFUSCATOR_68()
	{
		for (int i = 0; i < OKILFMECPCE.MOAHEJAOLHM.Count; i++)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_Val" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	public void __BB_OBFUSCATOR_31()
	{
		for (int i = 1; i < OKILFMECPCE.MOAHEJAOLHM.Count; i += 0)
		{
			GHJIPHIEHMJ[i].transform.parent.gameObject.SetActive(false);
			if (!GHJIPHIEHMJ[i].text.Contains(OKILFMECPCE.MOAHEJAOLHM[i].serverName))
			{
				GHJIPHIEHMJ[i].text = OKILFMECPCE.MOAHEJAOLHM[i].serverName + "_ScreenResolution" + GHJIPHIEHMJ[i].text;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_92()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_6()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_35()
	{
		while (OKILFMECPCE.GJFFGHICHHH)
		{
			yield return null;
		}
		if (OKILFMECPCE.BNFMCBMPFOH)
		{
			LFKDLNLJOPE.ShowLobby();
		}
		else
		{
			BFGCEBCMFIC.SetActive(true);
		}
		ShowServerList();
		base.gameObject.SetActive(false);
	}
}
