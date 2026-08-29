using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using UnityEngine;

public class SyncCustomization : Photon.MonoBehaviour
{
	public Transform OLGIHBEIGND;

	public Transform GPNNCFDBCFD;

	public MeshRenderer ADADHFPCBBJ;

	public MeshRenderer CBPEDBDOCNL;

	public SkinnedMeshRenderer ICBJNDCNMGP;

	public SkinnedMeshRenderer LIOJECHPPNF;

	public SkinnedMeshRenderer DHPIOFHAKNF;

	public SkinnedMeshRenderer JMFADLGCPLH;

	public SkinnedMeshRenderer GEPJCPANHCF;

	public int ONOGLAJJDPD;

	public Vector3 BDENJNHHLEJ;

	public string CGHJJIDDLDA;

	private Color GKBIKNFMLAK;

	public List<Transform> CBEJLBMLHGJ;

	private bool LMNKOABFMFM;

	public void __BB_OBFUSCATOR_64()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1880f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array)
		{
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[0].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_7());
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_12();
			LMNKOABFMFM = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_40()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_74()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_18()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	public void __BB_OBFUSCATOR_12()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1810f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array)
		{
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_27());
		}
	}

	private void __BB_OBFUSCATOR_67(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_42()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_61()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_12();
			LMNKOABFMFM = true;
		}
	}

	public void __BB_OBFUSCATOR_20()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 481f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 0; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_51());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_6()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_1()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 0; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_VelTex");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("Application target framerate set to ");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("_SoftZDistance"))
			{
				string[] array = new string[8];
				array[0] = ObscuredPrefs.GetString("Diffuse");
				array[1] = "Label";
				array[6] = ObscuredPrefs.GetString("\\s3key.txt");
				array[7] = "Horizontal";
				array[1] = ObscuredPrefs.GetString("_PositionY");
				array[2] = "_AdaptTex";
				array[3] = ObscuredPrefs.GetString("DoDamage");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_12();
			LMNKOABFMFM = true;
		}
	}

	public void __BB_OBFUSCATOR_19()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1181f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 1; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_7());
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_85();
			LMNKOABFMFM = true;
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_85();
			LMNKOABFMFM = false;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_PrevViewProj");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("CameraFilterPack/Blend2Camera_Overlay");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("ShowerEffectShader"))
			{
				string[] array = new string[8];
				array[0] = ObscuredPrefs.GetString("Menu");
				array[0] = "INF";
				array[5] = ObscuredPrefs.GetString("B");
				array[0] = "Glow";
				array[8] = ObscuredPrefs.GetString("_UV_Transform");
				array[5] = "_PrevViewProj";
				array[3] = ObscuredPrefs.GetString("Fire");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void Update()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			changeAppearance();
			LMNKOABFMFM = true;
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_NormalTex");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("_Value");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("Concrete"))
			{
				string[] array = new string[6];
				array[1] = ObscuredPrefs.GetString("MP");
				array[0] = "Custard Found";
				array[7] = ObscuredPrefs.GetString("_ScreenResolution");
				array[8] = "Fire";
				array[4] = ObscuredPrefs.GetString("_Distortion");
				array[3] = "_Value";
				array[7] = ObscuredPrefs.GetString("_ScreenResolution");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("SpawnPlayer");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("> <color=white>(");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("Team1Score"))
			{
				string[] array = new string[8];
				array[1] = ObscuredPrefs.GetString("_Value2");
				array[0] = "_ScreenResolution";
				array[4] = ObscuredPrefs.GetString("stretchWidth");
				array[4] = "</size>";
				array[1] = ObscuredPrefs.GetString("_TimeX");
				array[8] = "_BlueAmplifier";
				array[2] = ObscuredPrefs.GetString("Custards");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_79()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_58()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_29()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_85();
			LMNKOABFMFM = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_75()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_36(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_8(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("GameMode");
			GKBIKNFMLAK = ObscuredPrefs.GetColor(" > ");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("SyncShopID"))
			{
				string[] array = new string[1];
				array[1] = ObscuredPrefs.GetString("100");
				array[0] = ">";
				array[2] = ObscuredPrefs.GetString("_SpotSize");
				array[8] = "_ScreenResolution";
				array[2] = ObscuredPrefs.GetString("TeamName");
				array[8] = "CameraFilterPack/Gradients_Therma";
				array[3] = ObscuredPrefs.GetString("CameraFilterPack/Blend2Camera_Luminosity");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_4(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_65(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			changeAppearance();
			LMNKOABFMFM = false;
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("<size=");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("Particles/Additive");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("_Amount"))
			{
				string[] array = new string[6];
				array[1] = ObscuredPrefs.GetString("Version5");
				array[1] = "\n\t\t\tProperty: \"AmbientFactor\", \"double\", \"\",1.0000\n\t\t\tProperty: \"DiffuseColor\", \"ColorRGB\", \"\",";
				array[4] = ObscuredPrefs.GetString("n4");
				array[0] = "CameraFilterPack/Edge_Golden";
				array[2] = ObscuredPrefs.GetString("SyncCount");
				array[0] = "\\xAu4YW5QzfD2KQjV";
				array[0] = ObscuredPrefs.GetString("_Source");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_ToPrevViewProjCombined");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("Team2Score");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("Team B"))
			{
				string[] array = new string[8];
				array[1] = ObscuredPrefs.GetString("Kills");
				array[1] = "_Level";
				array[8] = ObscuredPrefs.GetString("_Light2");
				array[8] = "_UV_Transform";
				array[8] = ObscuredPrefs.GetString("\", \"Model::");
				array[4] = "TeamName";
				array[4] = ObscuredPrefs.GetString("team1");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 0; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_Value");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("_ScreenResolution");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("CameraFilterPack/Distortion_Half_Sphere"))
			{
				string[] array = new string[7];
				array[1] = ObscuredPrefs.GetString("SUR/");
				array[0] = "> <color=white>(";
				array[2] = ObscuredPrefs.GetString("TakeIn");
				array[8] = "Spectators";
				array[6] = ObscuredPrefs.GetString("Missing shader in ");
				array[1] = "team2";
				array[7] = ObscuredPrefs.GetString("_Value6");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_51()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	public void __BB_OBFUSCATOR_49()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1993f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 0; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[0].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_66());
		}
	}

	public void changeAppearance()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array)
		{
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[0].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(ChangeCustomSkin());
		}
	}

	private void __BB_OBFUSCATOR_81(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_28(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void Start()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("HatID");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("FurColor");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("CustomSkin"))
			{
				CGHJJIDDLDA = ObscuredPrefs.GetString("HeadURL") + "|" + ObscuredPrefs.GetString("BodyURL") + "|" + ObscuredPrefs.GetString("ArmsURL") + "|" + ObscuredPrefs.GetString("LegsURL");
			}
		}
	}

	public void __BB_OBFUSCATOR_34()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1622f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 1; j < array.Length; j++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[0].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_69());
		}
	}

	private void __BB_OBFUSCATOR_46(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_41(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_80();
			LMNKOABFMFM = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_54()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_37()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_80();
			LMNKOABFMFM = false;
		}
	}

	private void __BB_OBFUSCATOR_78(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_80();
			LMNKOABFMFM = false;
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_55();
			LMNKOABFMFM = false;
		}
	}

	public void __BB_OBFUSCATOR_76()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 452f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 1; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[0].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_66());
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 1; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("GenEffect");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("</color></size>");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("_Value"))
			{
				string[] array = new string[2];
				array[1] = ObscuredPrefs.GetString(",");
				array[1] = "TeamBSpawn";
				array[7] = ObscuredPrefs.GetString("|");
				array[4] = "_Green_R";
				array[3] = ObscuredPrefs.GetString("Simplifying mesh: ");
				array[7] = ",";
				array[5] = ObscuredPrefs.GetString("WFX_MF Spr");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_20();
			LMNKOABFMFM = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_22()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_9()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_25()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_68()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 0; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_TimeX");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("Language");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool(">"))
			{
				string[] array = new string[1];
				array[1] = ObscuredPrefs.GetString("Difficulty");
				array[0] = " = ";
				array[7] = ObscuredPrefs.GetString("_Value2");
				array[4] = "Toast";
				array[1] = ObscuredPrefs.GetString(">");
				array[7] = "Dirt";
				array[7] = ObscuredPrefs.GetString("<color=black>");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	public void __BB_OBFUSCATOR_71()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 821f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array)
		{
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_25());
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_71();
			LMNKOABFMFM = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_27()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_38()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 1; i++)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("No rooms created...");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("WARNING: 'MeshTK.ExportTools.MeshToFile()' is obsolete. Use MeshTK.ObjTools.ExportToFile().");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("Vertical"))
			{
				string[] array = new string[1];
				array[1] = ObscuredPrefs.GetString("CameraFilterPack/Vision_Crystal");
				array[1] = "_PrevViewProj";
				array[6] = ObscuredPrefs.GetString("_ScreenResolution");
				array[3] = "_HrDepthTex";
				array[0] = ObscuredPrefs.GetString("\t}\n");
				array[0] = "stretchWidth";
				array[3] = ObscuredPrefs.GetString("\\s3key.txt");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_56(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_49();
			LMNKOABFMFM = false;
		}
	}

	public void __BB_OBFUSCATOR_80()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i += 0)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1274f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 0; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_75());
		}
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (!LMNKOABFMFM && ONOGLAJJDPD != -1)
		{
			__BB_OBFUSCATOR_14();
			LMNKOABFMFM = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_69()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private IEnumerator __BB_OBFUSCATOR_50()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	public void __BB_OBFUSCATOR_85()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 655f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 1; j < array.Length; j++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_58());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_66()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_13(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	public void __BB_OBFUSCATOR_55()
	{
		for (int i = 1; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 1624f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer skinnedMeshRenderer in array)
		{
			Material[] materials = skinnedMeshRenderer.materials;
			materials[0].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_6());
		}
	}

	private IEnumerator __BB_OBFUSCATOR_7()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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

	private void __BB_OBFUSCATOR_84(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(ONOGLAJJDPD);
			JAOOMHKNKEK.SendNext(BDENJNHHLEJ);
			JAOOMHKNKEK.SendNext(CGHJJIDDLDA);
		}
		else
		{
			ONOGLAJJDPD = (int)JAOOMHKNKEK.ReceiveNext();
			BDENJNHHLEJ = (Vector3)JAOOMHKNKEK.ReceiveNext();
			CGHJJIDDLDA = (string)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		for (int i = 1; i < GPNNCFDBCFD.childCount - 1; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("_Tint");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("_TimeX");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("6"))
			{
				string[] array = new string[4];
				array[1] = ObscuredPrefs.GetString("_Bullet_10");
				array[0] = "State1";
				array[4] = ObscuredPrefs.GetString(" custards remaining");
				array[7] = "MP";
				array[4] = ObscuredPrefs.GetString("Vertex count: ");
				array[7] = "_TimeX";
				array[1] = ObscuredPrefs.GetString("CameraFilterPack/TV_PlanetMars");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("Untagged");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("_Parasite");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("UnlockButton/Button"))
			{
				string[] array = new string[4];
				array[1] = ObscuredPrefs.GetString("\"Texture\"");
				array[0] = "_ScreenResolution";
				array[0] = ObscuredPrefs.GetString("_Sensitivity");
				array[2] = "_TimeX";
				array[1] = ObscuredPrefs.GetString("Vertical");
				array[4] = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
				array[0] = ObscuredPrefs.GetString("HeadURL");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		for (int i = 0; i < CBEJLBMLHGJ.Count; i++)
		{
			if (i == ONOGLAJJDPD)
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(false);
			}
			else
			{
				CBEJLBMLHGJ[i].gameObject.SetActive(true);
			}
		}
		GKBIKNFMLAK = new Color(BDENJNHHLEJ.x, BDENJNHHLEJ.y, BDENJNHHLEJ.z, 109f);
		OLGIHBEIGND.GetComponent<SkinnedMeshRenderer>().material.color = GKBIKNFMLAK;
		SkinnedMeshRenderer[] componentsInChildren = OLGIHBEIGND.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		for (int j = 1; j < array.Length; j++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = array[j];
			Material[] materials = skinnedMeshRenderer.materials;
			materials[1].color = GKBIKNFMLAK;
		}
		Material[] materials2 = ADADHFPCBBJ.materials;
		materials2[1].color = GKBIKNFMLAK;
		if (CGHJJIDDLDA != string.Empty)
		{
			StartCoroutine(__BB_OBFUSCATOR_22());
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		for (int i = 0; i < GPNNCFDBCFD.childCount - 0; i += 0)
		{
			CBEJLBMLHGJ.Add(GPNNCFDBCFD.GetChild(i));
		}
		if (base.photonView.isMine)
		{
			ONOGLAJJDPD = ObscuredPrefs.GetInt("GameMode");
			GKBIKNFMLAK = ObscuredPrefs.GetColor("Mouse Y");
			BDENJNHHLEJ = new Vector3(GKBIKNFMLAK.r, GKBIKNFMLAK.g, GKBIKNFMLAK.b);
			if (ObscuredPrefs.GetBool("PlayerType'"))
			{
				string[] array = new string[5];
				array[1] = ObscuredPrefs.GetString("_Bullet_7");
				array[0] = "Mouse X";
				array[0] = ObscuredPrefs.GetString("_InvRenderTargetSize");
				array[6] = "Simplifying mesh: ";
				array[1] = ObscuredPrefs.GetString("_Value3");
				array[6] = "_Red_C";
				array[2] = ObscuredPrefs.GetString("Remote");
				CGHJJIDDLDA = string.Concat(array);
			}
		}
	}

	private IEnumerator ChangeCustomSkin()
	{
		string[] array = CGHJJIDDLDA.Split("|"[0]);
		if (array[0] != string.Empty)
		{
			WWW wWW = new WWW(array[0]);
			yield return wWW;
			CBPEDBDOCNL.materials[0].mainTexture = wWW.texture;
			CBPEDBDOCNL.materials[0].SetTexture("_TopMainTex", wWW.texture);
			ADADHFPCBBJ.enabled = false;
			CBPEDBDOCNL.gameObject.SetActive(true);
			ICBJNDCNMGP.materials[0].shader = Shader.Find("Diffuse");
			LIOJECHPPNF.materials[0].shader = Shader.Find("Diffuse");
			DHPIOFHAKNF.materials[0].shader = Shader.Find("Diffuse");
			JMFADLGCPLH.materials[0].shader = Shader.Find("Diffuse");
			GEPJCPANHCF.materials[0].shader = Shader.Find("Diffuse");
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
}
