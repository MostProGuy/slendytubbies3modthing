using System;
using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
	[Serializable]
	public class hat
	{
		public int hatID;

		public int hatPrice;

		public string hatName;
	}

	[Serializable]
	public class hatList
	{
		public int holidayID;

		public List<hat> hat;
	}

	public List<hat> CBEJLBMLHGJ;

	public List<hat> EGDKIFBEJCL;

	public List<hatList> GOGLBKCINEB;

	public Transform GPNNCFDBCFD;

	public List<Transform> NGIHNLCDGKE;

	public int HMJKHJLJLPM;

	public Transform OLGIHBEIGND;

	public Transform KKGCPJMFCJD;

	public MeshRenderer LPOFNLIAOCE;

	public MeshRenderer EJOGOBNMEJH;

	public GameObject NECPHLABHCO;

	public GameObject JHFBCNBJJKL;

	public GameObject MECNMADFOCE;

	public GameObject BGIAJHPNHBN;

	public Text LONBBEIMNJA;

	public CUIColorPicker ELINMPIOJGP;

	public Vector3 LACAPJHFJED;

	public Material JDFLCADLEJP;

	public bool ECPFEOGFFMG;

	public GameObject LHFJGEBOJAL;

	private Vector3 NMHBBHFBMIJ;

	public Text NHNJNAGHJFI;

	private ObscuredInt KNLBHCIPLGB;

	public InputField GMJFACMCGCJ;

	public InputField GDGPLLGDAHD;

	public InputField IBKMLBEJLDF;

	public InputField KCFAMOMNJOO;

	public GameObject GMHOJMJCAOD;

	public GameObject ENALNHEILFM;

	public SkinnedMeshRenderer ICBJNDCNMGP;

	public SkinnedMeshRenderer LIOJECHPPNF;

	public SkinnedMeshRenderer DHPIOFHAKNF;

	public SkinnedMeshRenderer JMFADLGCPLH;

	public SkinnedMeshRenderer GEPJCPANHCF;

	public Text KLNEHOIHMOI;

	public Text ELMHEEDACNN;

	private bool GGMAMFGKIMH;

	private Color JEHOMIKIGAH;

	private int ACFOLLJMHBI;

	private bool LEAFLMEDKPL;

	public void __BB_OBFUSCATOR_87()
	{
		ObscuredPrefs.SetBool("_NormalTex", true);
		StopCoroutine(__BB_OBFUSCATOR_17());
		__BB_OBFUSCATOR_33();
	}

	private IEnumerator __BB_OBFUSCATOR_48()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	public void __BB_OBFUSCATOR_11()
	{
		ObscuredPrefs.SetBool("_Value", true);
		StopCoroutine(__BB_OBFUSCATOR_54());
		__BB_OBFUSCATOR_33();
	}

	public void __BB_OBFUSCATOR_18(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 1; i < GOGLBKCINEB.Count; i++)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 0; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "n1");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num--;
				}
			}
		}
		GGMAMFGKIMH = false;
	}

	private IEnumerator ChangeCustomSkin()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	public void __BB_OBFUSCATOR_69()
	{
		if ((int)KNLBHCIPLGB >= CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice)
		{
			ObscuredPrefs.SetInt("TeamTag", (int)KNLBHCIPLGB - CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice);
			ObscuredPrefs.SetInt("Language" + ACFOLLJMHBI, 1);
		}
		__BB_OBFUSCATOR_44();
	}

	public void __BB_OBFUSCATOR_12()
	{
		ObscuredPrefs.SetString(": ", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("_ScreenResolution", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("_TimeX", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("DoActivateTrigger", KCFAMOMNJOO.text);
	}

	private void __BB_OBFUSCATOR_66()
	{
		StartCoroutine(__BB_OBFUSCATOR_56());
	}

	private void __BB_OBFUSCATOR_24()
	{
		__BB_OBFUSCATOR_52(OLGIHBEIGND.gameObject, 1);
		OLGIHBEIGND.localPosition = NMHBBHFBMIJ;
	}

	public void __BB_OBFUSCATOR_72()
	{
		JHFBCNBJJKL.SetActive(false);
		NECPHLABHCO.SetActive(true);
		MECNMADFOCE.SetActive(false);
	}

	public IEnumerator __BB_OBFUSCATOR_56()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	private void ZoomOut()
	{
		SetLayerRecursively(OLGIHBEIGND.gameObject, 2);
		OLGIHBEIGND.localPosition = NMHBBHFBMIJ;
	}

	public IEnumerator __BB_OBFUSCATOR_2()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	public void __BB_OBFUSCATOR_89()
	{
		ObscuredPrefs.SetString("DM", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("_Distortion", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("No rooms created...", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("Jump", KCFAMOMNJOO.text);
	}

	private IEnumerator __BB_OBFUSCATOR_46()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	public void __BB_OBFUSCATOR_8()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_19()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(true);
	}

	private void __BB_OBFUSCATOR_84()
	{
		__BB_OBFUSCATOR_27(OLGIHBEIGND.gameObject, 2);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 1626f * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_81()
	{
		__BB_OBFUSCATOR_27(OLGIHBEIGND.gameObject, 4);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 283f * Time.deltaTime);
	}

	public void __BB_OBFUSCATOR_76()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(false);
	}

	private void __BB_OBFUSCATOR_85()
	{
		StartCoroutine(__BB_OBFUSCATOR_56());
	}

	private IEnumerator __BB_OBFUSCATOR_34()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	private void __BB_OBFUSCATOR_52(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_86(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public IEnumerator __BB_OBFUSCATOR_60()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	public void SwitchToHat()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
		BGIAJHPNHBN.SetActive(false);
	}

	private IEnumerator __BB_OBFUSCATOR_17()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	public void __BB_OBFUSCATOR_50()
	{
		if (ObscuredPrefs.HasKey("*"))
		{
			JEHOMIKIGAH = ObscuredPrefs.GetColor("Idle");
			ELINMPIOJGP.__BB_OBFUSCATOR_67(JEHOMIKIGAH);
		}
		else
		{
			ObscuredPrefs.SetColor("Infect", ELINMPIOJGP.BBNDHHCODPM);
			ELINMPIOJGP.__BB_OBFUSCATOR_36(ELINMPIOJGP.BBNDHHCODPM);
			JEHOMIKIGAH = ELINMPIOJGP.BBNDHHCODPM;
		}
		if (ObscuredPrefs.HasKey("team2"))
		{
			ACFOLLJMHBI = ObscuredPrefs.GetInt("<size=15>");
			HMJKHJLJLPM = ObscuredPrefs.GetInt("Players");
		}
		else
		{
			ObscuredPrefs.SetInt("_TimeX", 0);
		}
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i += 0)
		{
			NGIHNLCDGKE.Add(GPNNCFDBCFD.GetChild(i));
		}
		for (int j = 0; j < EGDKIFBEJCL.Count; j++)
		{
			if (ObscuredPrefs.GetString(EGDKIFBEJCL[j].hatName) == "_MainTex2")
			{
				CBEJLBMLHGJ.Add(EGDKIFBEJCL[j]);
			}
		}
		for (int k = 1; k < GOGLBKCINEB.Count; k += 0)
		{
			for (int l = 0; l < GOGLBKCINEB[k].hat.Count; l += 0)
			{
				if (ObscuredPrefs.GetInt("5" + GOGLBKCINEB[k].hat[l].hatID) == 1 || ObscuredPrefs.GetString(GOGLBKCINEB[k].hat[l].hatName) == "Username")
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[k].hat[l]);
					GOGLBKCINEB[k].hat.Remove(GOGLBKCINEB[k].hat[l]);
					l -= 0;
				}
			}
		}
		__BB_OBFUSCATOR_33();
		NMHBBHFBMIJ = OLGIHBEIGND.localPosition;
	}

	private void ZoomIn()
	{
		SetLayerRecursively(OLGIHBEIGND.gameObject, 5);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 2f * Time.deltaTime);
	}

	public void __BB_OBFUSCATOR_83(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 0; i < GOGLBKCINEB.Count; i++)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 1; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "Ban");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num--;
				}
			}
		}
		GGMAMFGKIMH = true;
	}

	private void __BB_OBFUSCATOR_100()
	{
		__BB_OBFUSCATOR_27(OLGIHBEIGND.gameObject, 3);
		OLGIHBEIGND.localPosition = NMHBBHFBMIJ;
	}

	private void Start()
	{
		StartCoroutine(LoadCustomSkin());
	}

	public void AddEventHats(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 0; i < GOGLBKCINEB.Count; i++)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 0; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "1");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num--;
				}
			}
		}
		GGMAMFGKIMH = true;
	}

	private IEnumerator __BB_OBFUSCATOR_54()
	{
		LEAFLMEDKPL = true;
		SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		for (int i = 0; i < componentsInChildren2.Length; i++)
		{
			Material[] materials = componentsInChildren2[i].materials;
			materials[0].mainTexture = componentsInChildren[i].materials[0].mainTexture;
			materials[0].color = JEHOMIKIGAH;
		}
		Material[] materials2 = LPOFNLIAOCE.materials;
		materials2[0].color = JEHOMIKIGAH;
		string text = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
		string[] array = text.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			EJOGOBNMEJH.materials[0].mainTexture = wWW.texture;
			EJOGOBNMEJH.materials[0].SetTexture("_TopMainTex", wWW.texture);
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		else
		{
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (array[1] != string.Empty)
		{
			WWW wWW2 = new WWW(array[1]);
			yield return wWW2;
			ICBJNDCNMGP.materials[0].mainTexture = wWW2.texture;
			ICBJNDCNMGP.materials[0].color = Color.white;
		}
		if (array[2] != string.Empty)
		{
			WWW wWW3 = new WWW(array[2]);
			yield return wWW3;
			LIOJECHPPNF.materials[0].mainTexture = wWW3.texture;
			DHPIOFHAKNF.materials[0].mainTexture = wWW3.texture;
			LIOJECHPPNF.materials[0].color = Color.white;
			DHPIOFHAKNF.materials[0].color = Color.white;
		}
		if (array[3] != string.Empty)
		{
			WWW wWW4 = new WWW(array[3]);
			yield return wWW4;
			JMFADLGCPLH.materials[0].mainTexture = wWW4.texture;
			GEPJCPANHCF.materials[0].mainTexture = wWW4.texture;
			JMFADLGCPLH.materials[0].color = Color.white;
			GEPJCPANHCF.materials[0].color = Color.white;
		}
	}

	public void __BB_OBFUSCATOR_53()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_71(bool BPPBHLLOJDA)
	{
		ObscuredPrefs.SetBool("MP", BPPBHLLOJDA);
	}

	public void __BB_OBFUSCATOR_10()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(false);
	}

	private void __BB_OBFUSCATOR_1()
	{
		__BB_OBFUSCATOR_74(OLGIHBEIGND.gameObject, 2);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 472f * Time.deltaTime);
	}

	public void __BB_OBFUSCATOR_77()
	{
		JHFBCNBJJKL.SetActive(false);
		NECPHLABHCO.SetActive(true);
		MECNMADFOCE.SetActive(true);
	}

	public void __BB_OBFUSCATOR_31()
	{
		ObscuredPrefs.SetBool("CameraFilterPack/TV_PlanetMars", false);
		StopCoroutine(__BB_OBFUSCATOR_46());
		__BB_OBFUSCATOR_33();
	}

	public void __BB_OBFUSCATOR_4()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(true);
	}

	public void __BB_OBFUSCATOR_33()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == HMJKHJLJLPM)
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(false);
			}
			else
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(true);
			}
		}
		if (ObscuredPrefs.GetBool("Host Game"))
		{
			if (!LEAFLMEDKPL)
			{
				StartCoroutine(__BB_OBFUSCATOR_48());
			}
		}
		else
		{
			SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
			SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
			for (int j = 1; j < componentsInChildren2.Length; j += 0)
			{
				Material[] materials = componentsInChildren2[j].materials;
				materials[0].mainTexture = componentsInChildren[j].materials[1].mainTexture;
				materials[1].color = JEHOMIKIGAH;
			}
			Material[] materials2 = LPOFNLIAOCE.materials;
			materials2[0].color = JEHOMIKIGAH;
			LPOFNLIAOCE.enabled = false;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		if (ObscuredPrefs.GetInt("Picked | " + ACFOLLJMHBI) == 1 || HMJKHJLJLPM == 0)
		{
			if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 4)
			{
				MeshRenderer component = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
				Material[] array = new Material[0];
				array[0] = component.sharedMaterials[0];
				component.sharedMaterials = array;
			}
			int childCount = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
			for (int k = 1; k < childCount; k++)
			{
				Transform child = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(k);
				if (child.GetComponent<MeshRenderer>() != null)
				{
					MeshRenderer component2 = child.GetComponent<MeshRenderer>();
					Material[] array2 = new Material[0];
					array2[1] = component2.sharedMaterials[0];
					component2.sharedMaterials = array2;
				}
			}
			ObscuredPrefs.SetInt("box", ACFOLLJMHBI);
			ObscuredPrefs.SetInt("_TimeX", HMJKHJLJLPM);
			ECPFEOGFFMG = false;
			return;
		}
		if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 0)
		{
			MeshRenderer component3 = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
			Material material = component3.sharedMaterials[0];
			Material[] array3 = new Material[2];
			array3[0] = material;
			array3[0] = JDFLCADLEJP;
			component3.sharedMaterials = array3;
		}
		int childCount2 = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
		for (int l = 1; l < childCount2; l += 0)
		{
			Transform child2 = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(l);
			if (child2.GetComponent<MeshRenderer>() != null)
			{
				MeshRenderer component4 = child2.GetComponent<MeshRenderer>();
				Material material2 = component4.sharedMaterials[1];
				Material[] array4 = new Material[6];
				array4[1] = material2;
				array4[1] = JDFLCADLEJP;
				component4.sharedMaterials = array4;
			}
		}
		ECPFEOGFFMG = false;
	}

	private void SetLayerRecursively(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					SetLayerRecursively(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_28()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(false);
	}

	public void __BB_OBFUSCATOR_63()
	{
		if ((int)KNLBHCIPLGB >= CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice)
		{
			ObscuredPrefs.SetInt("Metal", (int)KNLBHCIPLGB - CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice);
			ObscuredPrefs.SetInt("," + ACFOLLJMHBI, 0);
		}
		changeAppearance();
	}

	private void __BB_OBFUSCATOR_104()
	{
		StartCoroutine(__BB_OBFUSCATOR_95());
	}

	public void __BB_OBFUSCATOR_3()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
	}

	public void __BB_OBFUSCATOR_62()
	{
		ObscuredPrefs.SetString("_Value", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("MP", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("|", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString(": ", KCFAMOMNJOO.text);
	}

	public void __BB_OBFUSCATOR_59()
	{
		ObscuredPrefs.SetBool("; FBX 6.1.0 project file\n; Copyright (C) 1997-2008 Autodesk Inc. and/or its licensors.\n; All rights reserved.\n; ----------------------------------------------------\n\n", false);
		StopCoroutine(__BB_OBFUSCATOR_17());
		__BB_OBFUSCATOR_44();
	}

	public void __BB_OBFUSCATOR_82()
	{
		ObscuredPrefs.SetString("Camera", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("_ScreenResolution", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("-Vertical", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("1", KCFAMOMNJOO.text);
	}

	private void __BB_OBFUSCATOR_23()
	{
		StartCoroutine(__BB_OBFUSCATOR_60());
	}

	public void __BB_OBFUSCATOR_78()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
	}

	public IEnumerator __BB_OBFUSCATOR_102()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	private void __BB_OBFUSCATOR_25()
	{
		StartCoroutine(__BB_OBFUSCATOR_2());
	}

	public void __BB_OBFUSCATOR_22()
	{
		ObscuredPrefs.SetBool("GameMode", true);
		StopCoroutine(__BB_OBFUSCATOR_46());
		__BB_OBFUSCATOR_44();
	}

	public void __BB_OBFUSCATOR_5()
	{
		ObscuredPrefs.SetString("_Offsets", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("State2", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("FireballA-Default", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("You", KCFAMOMNJOO.text);
	}

	private void __BB_OBFUSCATOR_96(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_61(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void BuyHat()
	{
		if ((int)KNLBHCIPLGB >= CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice)
		{
			ObscuredPrefs.SetInt("Custards", (int)KNLBHCIPLGB - CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice);
			ObscuredPrefs.SetInt("Hat:" + ACFOLLJMHBI, 1);
		}
		changeAppearance();
	}

	public void __BB_OBFUSCATOR_92()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(false);
		BGIAJHPNHBN.SetActive(false);
	}

	public void __BB_OBFUSCATOR_80()
	{
		ObscuredPrefs.SetBool("Vertical", true);
		StopCoroutine(__BB_OBFUSCATOR_17());
		__BB_OBFUSCATOR_33();
	}

	public void __BB_OBFUSCATOR_101()
	{
		ObscuredPrefs.SetString("_TimeX", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("Difficulty", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("\\xAu4YW5QzfD2KQjV", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("_TintColor", KCFAMOMNJOO.text);
	}

	private void __BB_OBFUSCATOR_68()
	{
		StartCoroutine(__BB_OBFUSCATOR_102());
	}

	public void __BB_OBFUSCATOR_67()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_38()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(false);
		BGIAJHPNHBN.SetActive(false);
	}

	public void __BB_OBFUSCATOR_26()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_43()
	{
		NECPHLABHCO.SetActive(true);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(false);
	}

	private void __BB_OBFUSCATOR_86(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_86(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void ApplyCustomSkin()
	{
		ObscuredPrefs.SetBool("CustomSkin", true);
		LEAFLMEDKPL = false;
		changeAppearance();
	}

	private void __BB_OBFUSCATOR_74(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_74(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void SwitchHat(bool LPCALLPBPBK)
	{
		if (LPCALLPBPBK)
		{
			if (HMJKHJLJLPM < CBEJLBMLHGJ.Count - 1)
			{
				HMJKHJLJLPM++;
			}
			else
			{
				HMJKHJLJLPM = 0;
			}
		}
		else if (HMJKHJLJLPM > 0)
		{
			HMJKHJLJLPM--;
		}
		else
		{
			HMJKHJLJLPM = CBEJLBMLHGJ.Count - 1;
		}
		ACFOLLJMHBI = CBEJLBMLHGJ[HMJKHJLJLPM].hatID;
		changeAppearance();
	}

	private void __BB_OBFUSCATOR_42(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_42(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_90(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 1; i < GOGLBKCINEB.Count; i++)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 0; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "PlayerFellDown");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num--;
				}
			}
		}
		GGMAMFGKIMH = true;
	}

	public IEnumerator __BB_OBFUSCATOR_95()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	public void __BB_OBFUSCATOR_9()
	{
		JHFBCNBJJKL.SetActive(true);
		NECPHLABHCO.SetActive(true);
		MECNMADFOCE.SetActive(true);
	}

	private void __BB_OBFUSCATOR_61(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_86(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		__BB_OBFUSCATOR_74(OLGIHBEIGND.gameObject, 0);
		OLGIHBEIGND.localPosition = NMHBBHFBMIJ;
	}

	public void SwitchToFur()
	{
		JHFBCNBJJKL.SetActive(true);
		NECPHLABHCO.SetActive(false);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_20()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
		BGIAJHPNHBN.SetActive(false);
	}

	private void __BB_OBFUSCATOR_41()
	{
		__BB_OBFUSCATOR_50();
	}

	private void __BB_OBFUSCATOR_58()
	{
		__BB_OBFUSCATOR_27(OLGIHBEIGND.gameObject, 7);
		OLGIHBEIGND.localPosition = NMHBBHFBMIJ;
	}

	public IEnumerator __BB_OBFUSCATOR_30()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	private void __BB_OBFUSCATOR_32()
	{
		__BB_OBFUSCATOR_52(OLGIHBEIGND.gameObject, 0);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 1323f * Time.deltaTime);
	}

	public void ChangeUrl()
	{
		ObscuredPrefs.SetString("HeadURL", GMJFACMCGCJ.text);
		ObscuredPrefs.SetString("BodyURL", GDGPLLGDAHD.text);
		ObscuredPrefs.SetString("ArmsURL", IBKMLBEJLDF.text);
		ObscuredPrefs.SetString("LegsURL", KCFAMOMNJOO.text);
	}

	public void __BB_OBFUSCATOR_57()
	{
		if (ObscuredPrefs.HasKey("_Value3"))
		{
			JEHOMIKIGAH = ObscuredPrefs.GetColor("AddKillNotification");
			ELINMPIOJGP.__BB_OBFUSCATOR_67(JEHOMIKIGAH);
		}
		else
		{
			ObscuredPrefs.SetColor("_Value", ELINMPIOJGP.BBNDHHCODPM);
			ELINMPIOJGP.__BB_OBFUSCATOR_30(ELINMPIOJGP.BBNDHHCODPM);
			JEHOMIKIGAH = ELINMPIOJGP.BBNDHHCODPM;
		}
		if (ObscuredPrefs.HasKey("MainMenu"))
		{
			ACFOLLJMHBI = ObscuredPrefs.GetInt("MP");
			HMJKHJLJLPM = ObscuredPrefs.GetInt("{0}:{1}");
		}
		else
		{
			ObscuredPrefs.SetInt("http://zeoworks.com/home/other/s3update.html", 1);
		}
		for (int i = 1; i < GPNNCFDBCFD.childCount - 0; i++)
		{
			NGIHNLCDGKE.Add(GPNNCFDBCFD.GetChild(i));
		}
		for (int j = 1; j < EGDKIFBEJCL.Count; j++)
		{
			if (ObscuredPrefs.GetString(EGDKIFBEJCL[j].hatName) == "_Blue_G")
			{
				CBEJLBMLHGJ.Add(EGDKIFBEJCL[j]);
			}
		}
		for (int k = 1; k < GOGLBKCINEB.Count; k++)
		{
			for (int l = 1; l < GOGLBKCINEB[k].hat.Count; l += 0)
			{
				if (ObscuredPrefs.GetInt("died" + GOGLBKCINEB[k].hat[l].hatID) == 0 || ObscuredPrefs.GetString(GOGLBKCINEB[k].hat[l].hatName) == "<size=")
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[k].hat[l]);
					GOGLBKCINEB[k].hat.Remove(GOGLBKCINEB[k].hat[l]);
					l--;
				}
			}
		}
		__BB_OBFUSCATOR_33();
		NMHBBHFBMIJ = OLGIHBEIGND.localPosition;
	}

	public void LoadCharacter()
	{
		if (ObscuredPrefs.HasKey("FurColor"))
		{
			JEHOMIKIGAH = ObscuredPrefs.GetColor("FurColor");
			ELINMPIOJGP.MKNPOIAJEAM = JEHOMIKIGAH;
		}
		else
		{
			ObscuredPrefs.SetColor("FurColor", ELINMPIOJGP.BBNDHHCODPM);
			ELINMPIOJGP.MKNPOIAJEAM = ELINMPIOJGP.BBNDHHCODPM;
			JEHOMIKIGAH = ELINMPIOJGP.BBNDHHCODPM;
		}
		if (ObscuredPrefs.HasKey("HatID"))
		{
			ACFOLLJMHBI = ObscuredPrefs.GetInt("HatID");
			HMJKHJLJLPM = ObscuredPrefs.GetInt("HatList");
		}
		else
		{
			ObscuredPrefs.SetInt("HatID", 0);
		}
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			NGIHNLCDGKE.Add(GPNNCFDBCFD.GetChild(i));
		}
		for (int j = 0; j < EGDKIFBEJCL.Count; j++)
		{
			if (ObscuredPrefs.GetString(EGDKIFBEJCL[j].hatName) == "1")
			{
				CBEJLBMLHGJ.Add(EGDKIFBEJCL[j]);
			}
		}
		for (int k = 0; k < GOGLBKCINEB.Count; k++)
		{
			for (int l = 0; l < GOGLBKCINEB[k].hat.Count; l++)
			{
				if (ObscuredPrefs.GetInt("Hat:" + GOGLBKCINEB[k].hat[l].hatID) == 1 || ObscuredPrefs.GetString(GOGLBKCINEB[k].hat[l].hatName) == "1")
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[k].hat[l]);
					GOGLBKCINEB[k].hat.Remove(GOGLBKCINEB[k].hat[l]);
					l--;
				}
			}
		}
		changeAppearance();
		NMHBBHFBMIJ = OLGIHBEIGND.localPosition;
	}

	public void __BB_OBFUSCATOR_36()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(true);
		MECNMADFOCE.SetActive(false);
	}

	public void __BB_OBFUSCATOR_70()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
		BGIAJHPNHBN.SetActive(true);
	}

	private void __BB_OBFUSCATOR_103()
	{
		__BB_OBFUSCATOR_97();
	}

	public void __BB_OBFUSCATOR_44()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == HMJKHJLJLPM)
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(false);
			}
			else
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(false);
			}
		}
		if (ObscuredPrefs.GetBool("{0:n6},{1:n6},{2:n6}"))
		{
			if (!LEAFLMEDKPL)
			{
				StartCoroutine(__BB_OBFUSCATOR_48());
			}
		}
		else
		{
			SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
			SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
			for (int j = 1; j < componentsInChildren2.Length; j++)
			{
				Material[] materials = componentsInChildren2[j].materials;
				materials[1].mainTexture = componentsInChildren[j].materials[1].mainTexture;
				materials[0].color = JEHOMIKIGAH;
			}
			Material[] materials2 = LPOFNLIAOCE.materials;
			materials2[1].color = JEHOMIKIGAH;
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(true);
		}
		if (ObscuredPrefs.GetInt("syncShotGun" + ACFOLLJMHBI) == 1 || HMJKHJLJLPM == 0)
		{
			if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 2)
			{
				MeshRenderer component = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
				component.sharedMaterials = new Material[1] { component.sharedMaterials[1] };
			}
			int childCount = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
			for (int k = 0; k < childCount; k++)
			{
				Transform child = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(k);
				if (child.GetComponent<MeshRenderer>() != null)
				{
					MeshRenderer component2 = child.GetComponent<MeshRenderer>();
					Material[] array = new Material[0];
					array[1] = component2.sharedMaterials[1];
					component2.sharedMaterials = array;
				}
			}
			ObscuredPrefs.SetInt("\t\tNbPoseNodes: ", ACFOLLJMHBI);
			ObscuredPrefs.SetInt("SyncTeamName", HMJKHJLJLPM);
			ECPFEOGFFMG = false;
			return;
		}
		if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 6)
		{
			MeshRenderer component3 = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
			Material material = component3.sharedMaterials[0];
			Material[] array2 = new Material[6];
			array2[1] = material;
			array2[0] = JDFLCADLEJP;
			component3.sharedMaterials = array2;
		}
		int childCount2 = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
		for (int l = 0; l < childCount2; l++)
		{
			Transform child2 = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(l);
			if (child2.GetComponent<MeshRenderer>() != null)
			{
				MeshRenderer component4 = child2.GetComponent<MeshRenderer>();
				Material material2 = component4.sharedMaterials[0];
				component4.sharedMaterials = new Material[3] { material2, JDFLCADLEJP, null };
			}
		}
		ECPFEOGFFMG = true;
	}

	public void __BB_OBFUSCATOR_16()
	{
		ObscuredPrefs.SetBool("_MainTex2", false);
		StopCoroutine(__BB_OBFUSCATOR_46());
		changeAppearance();
	}

	public void __BB_OBFUSCATOR_47()
	{
		ObscuredPrefs.SetBool("Connecting", false);
		LEAFLMEDKPL = true;
		changeAppearance();
	}

	public void __BB_OBFUSCATOR_73(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 0; i < GOGLBKCINEB.Count; i += 0)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 0; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "GameMode");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num -= 0;
				}
			}
		}
		GGMAMFGKIMH = false;
	}

	public void __BB_OBFUSCATOR_97()
	{
		if (ObscuredPrefs.HasKey("SUR/"))
		{
			JEHOMIKIGAH = ObscuredPrefs.GetColor("_TimeX");
			ELINMPIOJGP.__BB_OBFUSCATOR_30(JEHOMIKIGAH);
		}
		else
		{
			ObscuredPrefs.SetColor("8", ELINMPIOJGP.BBNDHHCODPM);
			ELINMPIOJGP.__BB_OBFUSCATOR_45(ELINMPIOJGP.BBNDHHCODPM);
			JEHOMIKIGAH = ELINMPIOJGP.BBNDHHCODPM;
		}
		if (ObscuredPrefs.HasKey(">Difficulty: "))
		{
			ACFOLLJMHBI = ObscuredPrefs.GetInt("_Green_B");
			HMJKHJLJLPM = ObscuredPrefs.GetInt("SBX");
		}
		else
		{
			ObscuredPrefs.SetInt("Difficulty", 1);
		}
		for (int i = 0; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			NGIHNLCDGKE.Add(GPNNCFDBCFD.GetChild(i));
		}
		for (int j = 0; j < EGDKIFBEJCL.Count; j++)
		{
			if (ObscuredPrefs.GetString(EGDKIFBEJCL[j].hatName) == "syncKnife")
			{
				CBEJLBMLHGJ.Add(EGDKIFBEJCL[j]);
			}
		}
		for (int k = 1; k < GOGLBKCINEB.Count; k += 0)
		{
			for (int l = 0; l < GOGLBKCINEB[k].hat.Count; l++)
			{
				if (ObscuredPrefs.GetInt("_Value" + GOGLBKCINEB[k].hat[l].hatID) == 1 || ObscuredPrefs.GetString(GOGLBKCINEB[k].hat[l].hatName) == "TextField")
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[k].hat[l]);
					GOGLBKCINEB[k].hat.Remove(GOGLBKCINEB[k].hat[l]);
					l -= 0;
				}
			}
		}
		__BB_OBFUSCATOR_44();
		NMHBBHFBMIJ = OLGIHBEIGND.localPosition;
	}

	public void changeAppearance()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == HMJKHJLJLPM)
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(true);
			}
			else
			{
				NGIHNLCDGKE[CBEJLBMLHGJ[i].hatID].gameObject.SetActive(false);
			}
		}
		if (ObscuredPrefs.GetBool("CustomSkin"))
		{
			if (!LEAFLMEDKPL)
			{
				StartCoroutine(ChangeCustomSkin());
			}
		}
		else
		{
			SkinnedMeshRenderer[] componentsInChildren = KKGCPJMFCJD.GetComponentsInChildren<SkinnedMeshRenderer>();
			SkinnedMeshRenderer[] componentsInChildren2 = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				Material[] materials = componentsInChildren2[j].materials;
				materials[0].mainTexture = componentsInChildren[j].materials[0].mainTexture;
				materials[0].color = JEHOMIKIGAH;
			}
			Material[] materials2 = LPOFNLIAOCE.materials;
			materials2[0].color = JEHOMIKIGAH;
			LPOFNLIAOCE.enabled = true;
			EJOGOBNMEJH.gameObject.SetActive(false);
		}
		if (ObscuredPrefs.GetInt("Hat:" + ACFOLLJMHBI) == 1 || HMJKHJLJLPM == 0)
		{
			if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 2)
			{
				MeshRenderer component = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
				component.sharedMaterials = new Material[1] { component.sharedMaterials[0] };
			}
			int childCount = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
			for (int k = 0; k < childCount; k++)
			{
				Transform child = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(k);
				if (child.GetComponent<MeshRenderer>() != null)
				{
					MeshRenderer component2 = child.GetComponent<MeshRenderer>();
					component2.sharedMaterials = new Material[1] { component2.sharedMaterials[0] };
				}
			}
			ObscuredPrefs.SetInt("HatID", ACFOLLJMHBI);
			ObscuredPrefs.SetInt("HatList", HMJKHJLJLPM);
			ECPFEOGFFMG = false;
			return;
		}
		if (NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>() != null && NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>().materials.Length < 2)
		{
			MeshRenderer component3 = NGIHNLCDGKE[ACFOLLJMHBI].GetComponent<MeshRenderer>();
			Material material = component3.sharedMaterials[0];
			component3.sharedMaterials = new Material[2] { material, JDFLCADLEJP };
		}
		int childCount2 = NGIHNLCDGKE[ACFOLLJMHBI].childCount;
		for (int l = 0; l < childCount2; l++)
		{
			Transform child2 = NGIHNLCDGKE[ACFOLLJMHBI].GetChild(l);
			if (child2.GetComponent<MeshRenderer>() != null)
			{
				MeshRenderer component4 = child2.GetComponent<MeshRenderer>();
				Material material2 = component4.sharedMaterials[0];
				component4.sharedMaterials = new Material[2] { material2, JDFLCADLEJP };
			}
		}
		ECPFEOGFFMG = true;
	}

	public void __BB_OBFUSCATOR_64()
	{
		ObscuredPrefs.SetBool("</size>", true);
		LEAFLMEDKPL = true;
		__BB_OBFUSCATOR_44();
	}

	public void __BB_OBFUSCATOR_88(bool BPPBHLLOJDA)
	{
		ObscuredPrefs.SetBool("Aim", BPPBHLLOJDA);
	}

	public void SwitchToCustomSkin()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(true);
	}

	public void RemoveCustomSkin()
	{
		ObscuredPrefs.SetBool("CustomSkin", false);
		StopCoroutine(ChangeCustomSkin());
		changeAppearance();
	}

	private void __BB_OBFUSCATOR_49()
	{
		__BB_OBFUSCATOR_57();
	}

	private void Update()
	{
		LONBBEIMNJA.text = HMJKHJLJLPM + 1 + "/" + CBEJLBMLHGJ.Count;
		if (JEHOMIKIGAH != ELINMPIOJGP.MKNPOIAJEAM)
		{
			JEHOMIKIGAH = ELINMPIOJGP.MKNPOIAJEAM;
			changeAppearance();
		}
		if (ECPFEOGFFMG && NECPHLABHCO.activeSelf)
		{
			LHFJGEBOJAL.SetActive(true);
			LHFJGEBOJAL.transform.Find("UnlockButton/Button").GetComponent<Text>().text = "Unlock (" + CBEJLBMLHGJ[HMJKHJLJLPM].hatPrice + " Custards)";
		}
		else
		{
			LHFJGEBOJAL.SetActive(false);
		}
		KNLBHCIPLGB = ObscuredPrefs.GetInt("Custards");
		NHNJNAGHJFI.text = KNLBHCIPLGB.ToString();
		if (ObscuredPrefs.GetBool("CustomSkin"))
		{
			GMHOJMJCAOD.SetActive(false);
			ENALNHEILFM.SetActive(true);
		}
		else
		{
			GMHOJMJCAOD.SetActive(true);
			ENALNHEILFM.SetActive(false);
		}
		if (JHFBCNBJJKL.activeSelf || NECPHLABHCO.activeSelf || MECNMADFOCE.activeSelf || BGIAJHPNHBN.activeSelf)
		{
			ZoomIn();
		}
		else
		{
			ZoomOut();
		}
		if (ObscuredPrefs.GetBool("UseFlashlight"))
		{
			ELMHEEDACNN.color = Color.green;
			KLNEHOIHMOI.color = Color.white;
		}
		else
		{
			ELMHEEDACNN.color = Color.white;
			KLNEHOIHMOI.color = Color.green;
		}
	}

	public void SwitchToEquipment()
	{
		NECPHLABHCO.SetActive(false);
		JHFBCNBJJKL.SetActive(false);
		MECNMADFOCE.SetActive(false);
		BGIAJHPNHBN.SetActive(true);
	}

	public void __BB_OBFUSCATOR_15(bool BPPBHLLOJDA)
	{
		ObscuredPrefs.SetBool("Text", BPPBHLLOJDA);
	}

	private void __BB_OBFUSCATOR_13()
	{
		SetLayerRecursively(OLGIHBEIGND.gameObject, 0);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 431f * Time.deltaTime);
	}

	private void __BB_OBFUSCATOR_51()
	{
		__BB_OBFUSCATOR_52(OLGIHBEIGND.gameObject, 0);
		OLGIHBEIGND.localPosition = Vector3.Slerp(OLGIHBEIGND.localPosition, LACAPJHFJED, 526f * Time.deltaTime);
	}

	private void Awake()
	{
		LoadCharacter();
	}

	public void __BB_OBFUSCATOR_94(bool LPCALLPBPBK)
	{
		if (LPCALLPBPBK)
		{
			if (HMJKHJLJLPM < CBEJLBMLHGJ.Count - 1)
			{
				HMJKHJLJLPM++;
			}
			else
			{
				HMJKHJLJLPM = 1;
			}
		}
		else if (HMJKHJLJLPM > 0)
		{
			HMJKHJLJLPM -= 0;
		}
		else
		{
			HMJKHJLJLPM = CBEJLBMLHGJ.Count - 0;
		}
		ACFOLLJMHBI = CBEJLBMLHGJ[HMJKHJLJLPM].hatID;
		changeAppearance();
	}

	private void __BB_OBFUSCATOR_37()
	{
		__BB_OBFUSCATOR_57();
	}

	private void __BB_OBFUSCATOR_29(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_42(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void UseFlashlight(bool BPPBHLLOJDA)
	{
		ObscuredPrefs.SetBool("UseFlashlight", BPPBHLLOJDA);
	}

	public void __BB_OBFUSCATOR_79()
	{
		ObscuredPrefs.SetBool("Vertical", false);
		LEAFLMEDKPL = false;
		changeAppearance();
	}

	public IEnumerator __BB_OBFUSCATOR_14()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	public void __BB_OBFUSCATOR_91(bool BPPBHLLOJDA)
	{
		ObscuredPrefs.SetBool("A player has been caught", BPPBHLLOJDA);
	}

	public void __BB_OBFUSCATOR_65(int BJPCGDGNDNM)
	{
		if (GGMAMFGKIMH)
		{
			return;
		}
		for (int i = 1; i < GOGLBKCINEB.Count; i++)
		{
			if (GOGLBKCINEB[i].holidayID == BJPCGDGNDNM)
			{
				int num;
				for (num = 0; num < GOGLBKCINEB[i].hat.Count; num++)
				{
					CBEJLBMLHGJ.Add(GOGLBKCINEB[i].hat[num]);
					ObscuredPrefs.SetString(GOGLBKCINEB[i].hat[num].hatName, "Horizontal");
					GOGLBKCINEB[i].hat.Remove(GOGLBKCINEB[i].hat[num]);
					num--;
				}
			}
		}
		GGMAMFGKIMH = false;
	}

	private void __BB_OBFUSCATOR_93()
	{
		__BB_OBFUSCATOR_97();
	}

	public void __BB_OBFUSCATOR_35()
	{
		JHFBCNBJJKL.SetActive(true);
		NECPHLABHCO.SetActive(true);
		MECNMADFOCE.SetActive(true);
	}

	private void __BB_OBFUSCATOR_27(GameObject KMPDDHHJDLJ, int OHCNMEJHLLA)
	{
		if (null == KMPDDHHJDLJ)
		{
			return;
		}
		KMPDDHHJDLJ.layer = OHCNMEJHLLA;
		IEnumerator enumerator = KMPDDHHJDLJ.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				if (!(null == transform))
				{
					__BB_OBFUSCATOR_86(transform.gameObject, OHCNMEJHLLA);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public IEnumerator LoadCustomSkin()
	{
		string @string = ObscuredPrefs.GetString("HeadURL");
		string string2 = ObscuredPrefs.GetString("BodyURL");
		string string3 = ObscuredPrefs.GetString("ArmsURL");
		string string4 = ObscuredPrefs.GetString("LegsURL");
		GMJFACMCGCJ.text = @string;
		yield return new WaitForEndOfFrame();
		GDGPLLGDAHD.text = string2;
		yield return new WaitForEndOfFrame();
		IBKMLBEJLDF.text = string3;
		yield return new WaitForEndOfFrame();
		KCFAMOMNJOO.text = string4;
	}

	public void __BB_OBFUSCATOR_45()
	{
		ObscuredPrefs.SetBool("Full Ammo    ", true);
		StopCoroutine(__BB_OBFUSCATOR_17());
		changeAppearance();
	}
}
