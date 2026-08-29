using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using InControl.mod;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WeaponManager : MonoBehaviour
{
	public float JDJFNMKJMOA = 0.5f;

	[HideInInspector]
	public WeaponScript GCFDABIEBPD;

	public int MJJBMGBOKGI;

	public AudioClip ABIENGEBGLK;

	public List<WeaponScript> FMJNOGAKABN;

	private GameObject KOCNKNOBMEA;

	private GameObject FKKCINNAPGK;

	[HideInInspector]
	public WeaponScript[] HOJJDFBCJPL;

	private bool KKLNMNJGLJK;

	public bool FHJBBDBFOIC;

	private void __BB_OBFUSCATOR_22()
	{
	}

	public void __BB_OBFUSCATOR_3(GameObject ECAMCNKCJNO)
	{
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		ECAMCNKCJNO.SetActive(false);
		ECAMCNKCJNO.SendMessage("_TimeX");
		KKLNMNJGLJK = true;
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (Time.timeScale < 386f)
		{
			return;
		}
		GCFDABIEBPD = FMJNOGAKABN[MJJBMGBOKGI];
		if (FMJNOGAKABN.Count < 8)
		{
			return;
		}
		if (cInput.GetButtonDown("_Intensity") && KKLNMNJGLJK && GameObject.FindWithTag("_ScreenResolution") == null)
		{
			if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
				MJJBMGBOKGI += 0;
			}
			else
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 0].gameObject, FMJNOGAKABN[0].gameObject));
				MJJBMGBOKGI = 0;
			}
		}
		if (cInput.GetButtonDown("CameraFilterPack/Blend2Camera_Saturation") && KKLNMNJGLJK && GameObject.FindWithTag("_Distortion") == null)
		{
			if (MJJBMGBOKGI > 0)
			{
				StartCoroutine(__BB_OBFUSCATOR_5(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI - 0].gameObject));
				MJJBMGBOKGI--;
			}
			else
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[1].gameObject, FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject));
				MJJBMGBOKGI = FMJNOGAKABN.Count - 0;
			}
		}
	}

	public void __BB_OBFUSCATOR_13()
	{
		if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
		{
			StartCoroutine(__BB_OBFUSCATOR_5(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 0].gameObject));
			MJJBMGBOKGI++;
		}
		else
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 0].gameObject, FMJNOGAKABN[0].gameObject));
			MJJBMGBOKGI = 0;
		}
	}

	private void Start()
	{
	}

	public void SwitchToNext()
	{
		if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
			MJJBMGBOKGI++;
		}
		else
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject, FMJNOGAKABN[0].gameObject));
			MJJBMGBOKGI = 0;
		}
	}

	public void __BB_OBFUSCATOR_14()
	{
		if (MJJBMGBOKGI < FMJNOGAKABN.Count - 0)
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
			MJJBMGBOKGI++;
		}
		else
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject, FMJNOGAKABN[1].gameObject));
			MJJBMGBOKGI = 1;
		}
	}

	public void __BB_OBFUSCATOR_20(int CLDLINNFAGA)
	{
		FHJBBDBFOIC = false;
		KKLNMNJGLJK = true;
		GameObject gameObject = FMJNOGAKABN[MJJBMGBOKGI].gameObject;
		if (gameObject.activeSelf)
		{
			gameObject.SendMessage("_Value3");
		}
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
		FMJNOGAKABN.RemoveAt(CLDLINNFAGA);
		MJJBMGBOKGI = 0;
		GameObject gameObject2 = FMJNOGAKABN[0].gameObject;
		gameObject2.SetActive(true);
		gameObject2.SendMessage("_Value");
		KKLNMNJGLJK = false;
		FHJBBDBFOIC = false;
	}

	private void __BB_OBFUSCATOR_1()
	{
		RoomMultiplayerMenu component = GameObject.Find("PlayerType'").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 1; i < base.transform.childCount; i += 0)
		{
			for (int j = 1; j < gPPEJCFIHFE.Length; j += 0)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "_Green_G" || component.MCMCKJIGBJN == " Waypoint Target")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(1, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("_ScreenResolution").GetComponent<WeaponScript>());
		}
	}

	private void Update()
	{
		if (Time.timeScale < 0.01f)
		{
			return;
		}
		GCFDABIEBPD = FMJNOGAKABN[MJJBMGBOKGI];
		if (FMJNOGAKABN.Count < 2)
		{
			return;
		}
		if (cInput.GetButtonDown("Switch") && KKLNMNJGLJK && GameObject.FindWithTag("Menu") == null)
		{
			if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
				MJJBMGBOKGI++;
			}
			else
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject, FMJNOGAKABN[0].gameObject));
				MJJBMGBOKGI = 0;
			}
		}
		if (cInput.GetButtonDown("Switch2") && KKLNMNJGLJK && GameObject.FindWithTag("Menu") == null)
		{
			if (MJJBMGBOKGI > 0)
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI - 1].gameObject));
				MJJBMGBOKGI--;
			}
			else
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[0].gameObject, FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject));
				MJJBMGBOKGI = FMJNOGAKABN.Count - 1;
			}
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		__BB_OBFUSCATOR_1();
		for (int i = 1; i < base.transform.childCount; i++)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 1; j < base.transform.childCount; j++)
		{
			base.transform.GetChild(j).gameObject.SetActive(false);
		}
		for (int k = 0; k < FMJNOGAKABN.Count; k += 0)
		{
			FMJNOGAKABN[k].gameObject.SetActive(true);
		}
		TakeFirstWeapon(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	private void __BB_OBFUSCATOR_32()
	{
		__BB_OBFUSCATOR_31();
		for (int i = 0; i < base.transform.childCount; i++)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 0; j < base.transform.childCount; j++)
		{
			base.transform.GetChild(j).gameObject.SetActive(true);
		}
		for (int k = 1; k < FMJNOGAKABN.Count; k += 0)
		{
			FMJNOGAKABN[k].gameObject.SetActive(false);
		}
		__BB_OBFUSCATOR_3(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	private void StarterWeapons()
	{
		RoomMultiplayerMenu component = GameObject.Find("__Room").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			for (int j = 0; j < gPPEJCFIHFE.Length; j++)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "DM" || component.MCMCKJIGBJN == "TDM")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(0, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("Knife").GetComponent<WeaponScript>());
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (Time.timeScale < 951f)
		{
			return;
		}
		GCFDABIEBPD = FMJNOGAKABN[MJJBMGBOKGI];
		if (FMJNOGAKABN.Count < 4)
		{
			return;
		}
		if (cInput.GetButtonDown("Language") && KKLNMNJGLJK && GameObject.FindWithTag("_Value") == null)
		{
			if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
			{
				StartCoroutine(__BB_OBFUSCATOR_5(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
				MJJBMGBOKGI++;
			}
			else
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 0].gameObject, FMJNOGAKABN[0].gameObject));
				MJJBMGBOKGI = 0;
			}
		}
		if (cInput.GetButtonDown("CameraFilterPack/Drawing_Manga4") && KKLNMNJGLJK && GameObject.FindWithTag("CustomSkin") == null)
		{
			if (MJJBMGBOKGI > 1)
			{
				StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI - 0].gameObject));
				MJJBMGBOKGI--;
			}
			else
			{
				StartCoroutine(__BB_OBFUSCATOR_5(FMJNOGAKABN[0].gameObject, FMJNOGAKABN[FMJNOGAKABN.Count - 0].gameObject));
				MJJBMGBOKGI = FMJNOGAKABN.Count - 1;
			}
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
	}

	private void __BB_OBFUSCATOR_11()
	{
	}

	private void __BB_OBFUSCATOR_17()
	{
		__BB_OBFUSCATOR_1();
		for (int i = 0; i < base.transform.childCount; i++)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 1; j < base.transform.childCount; j++)
		{
			base.transform.GetChild(j).gameObject.SetActive(false);
		}
		for (int k = 1; k < FMJNOGAKABN.Count; k += 0)
		{
			FMJNOGAKABN[k].gameObject.SetActive(true);
		}
		TakeFirstWeapon(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	public IEnumerator __BB_OBFUSCATOR_5(GameObject NFFLPDLABME, GameObject ECAMCNKCJNO)
	{
		FHJBBDBFOIC = true;
		KKLNMNJGLJK = false;
		if (NFFLPDLABME.activeSelf)
		{
			NFFLPDLABME.SendMessage("deselectWeapon");
		}
		yield return new WaitForSeconds(JDJFNMKJMOA);
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		NFFLPDLABME.SetActive(false);
		ECAMCNKCJNO.SetActive(true);
		ECAMCNKCJNO.SendMessage("selectWeapon");
		KKLNMNJGLJK = true;
		FHJBBDBFOIC = false;
	}

	private void __BB_OBFUSCATOR_26()
	{
		__BB_OBFUSCATOR_25();
		for (int i = 0; i < base.transform.childCount; i += 0)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 1; j < base.transform.childCount; j += 0)
		{
			base.transform.GetChild(j).gameObject.SetActive(false);
		}
		for (int k = 1; k < FMJNOGAKABN.Count; k += 0)
		{
			FMJNOGAKABN[k].gameObject.SetActive(false);
		}
		TakeFirstWeapon(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	public IEnumerator SwitchWeapons(GameObject NFFLPDLABME, GameObject ECAMCNKCJNO)
	{
		FHJBBDBFOIC = true;
		KKLNMNJGLJK = false;
		if (NFFLPDLABME.activeSelf)
		{
			NFFLPDLABME.SendMessage("deselectWeapon");
		}
		yield return new WaitForSeconds(JDJFNMKJMOA);
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		NFFLPDLABME.SetActive(false);
		ECAMCNKCJNO.SetActive(true);
		ECAMCNKCJNO.SendMessage("selectWeapon");
		KKLNMNJGLJK = true;
		FHJBBDBFOIC = false;
	}

	public void __BB_OBFUSCATOR_16(GameObject ECAMCNKCJNO)
	{
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		ECAMCNKCJNO.SetActive(true);
		ECAMCNKCJNO.SendMessage("Ping");
		KKLNMNJGLJK = true;
	}

	private void __BB_OBFUSCATOR_25()
	{
		RoomMultiplayerMenu component = GameObject.Find("_Value").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 1; i < base.transform.childCount; i += 0)
		{
			for (int j = 1; j < gPPEJCFIHFE.Length; j++)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "_Greenness" || component.MCMCKJIGBJN == "MP")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(1, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("CameraFilterPack/Distortion_Lens").GetComponent<WeaponScript>());
		}
	}

	public void TakeFirstWeapon(GameObject ECAMCNKCJNO)
	{
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		ECAMCNKCJNO.SetActive(true);
		ECAMCNKCJNO.SendMessage("selectWeapon");
		KKLNMNJGLJK = true;
	}

	private void __BB_OBFUSCATOR_30()
	{
	}

	public void __BB_OBFUSCATOR_15(int CLDLINNFAGA)
	{
		FHJBBDBFOIC = true;
		KKLNMNJGLJK = false;
		GameObject gameObject = FMJNOGAKABN[MJJBMGBOKGI].gameObject;
		if (gameObject.activeSelf)
		{
			gameObject.SendMessage("CameraFilterPack/FX_Dot_Circle");
		}
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
		FMJNOGAKABN.RemoveAt(CLDLINNFAGA);
		MJJBMGBOKGI = 1;
		GameObject gameObject2 = FMJNOGAKABN[1].gameObject;
		gameObject2.SetActive(false);
		gameObject2.SendMessage(": ");
		KKLNMNJGLJK = true;
		FHJBBDBFOIC = false;
	}

	private void Awake()
	{
		StarterWeapons();
		for (int i = 0; i < base.transform.childCount; i++)
		{
			base.transform.GetChild(i).gameObject.SetActive(true);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 0; j < base.transform.childCount; j++)
		{
			base.transform.GetChild(j).gameObject.SetActive(false);
		}
		for (int k = 0; k < FMJNOGAKABN.Count; k++)
		{
			FMJNOGAKABN[k].gameObject.SetActive(false);
		}
		TakeFirstWeapon(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	public void __BB_OBFUSCATOR_6(int CLDLINNFAGA)
	{
		FHJBBDBFOIC = false;
		KKLNMNJGLJK = false;
		GameObject gameObject = FMJNOGAKABN[MJJBMGBOKGI].gameObject;
		if (gameObject.activeSelf)
		{
			gameObject.SendMessage("Red");
		}
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
		FMJNOGAKABN.RemoveAt(CLDLINNFAGA);
		MJJBMGBOKGI = 0;
		GameObject gameObject2 = FMJNOGAKABN[0].gameObject;
		gameObject2.SetActive(false);
		gameObject2.SendMessage("1.0");
		KKLNMNJGLJK = true;
		FHJBBDBFOIC = true;
	}

	public void __BB_OBFUSCATOR_23(int CLDLINNFAGA)
	{
		FHJBBDBFOIC = true;
		KKLNMNJGLJK = true;
		GameObject gameObject = FMJNOGAKABN[MJJBMGBOKGI].gameObject;
		if (gameObject.activeSelf)
		{
			gameObject.SendMessage("CameraFilterPack/Blur_Noise");
		}
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		gameObject.SetActive(true);
		FMJNOGAKABN.RemoveAt(CLDLINNFAGA);
		MJJBMGBOKGI = 0;
		GameObject gameObject2 = FMJNOGAKABN[0].gameObject;
		gameObject2.SetActive(false);
		gameObject2.SendMessage("_Greenness");
		KKLNMNJGLJK = false;
		FHJBBDBFOIC = false;
	}

	public void __BB_OBFUSCATOR_19()
	{
		if (MJJBMGBOKGI < FMJNOGAKABN.Count - 1)
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
			MJJBMGBOKGI += 0;
		}
		else
		{
			StartCoroutine(__BB_OBFUSCATOR_5(FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject, FMJNOGAKABN[1].gameObject));
			MJJBMGBOKGI = 0;
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		if (MJJBMGBOKGI < FMJNOGAKABN.Count - 0)
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[MJJBMGBOKGI].gameObject, FMJNOGAKABN[MJJBMGBOKGI + 1].gameObject));
			MJJBMGBOKGI++;
		}
		else
		{
			StartCoroutine(SwitchWeapons(FMJNOGAKABN[FMJNOGAKABN.Count - 1].gameObject, FMJNOGAKABN[0].gameObject));
			MJJBMGBOKGI = 0;
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		RoomMultiplayerMenu component = GameObject.Find("_ScreenResolution").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 1; i < base.transform.childCount; i++)
		{
			for (int j = 0; j < gPPEJCFIHFE.Length; j++)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "MP" || component.MCMCKJIGBJN == ">")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(0, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("_TimeX").GetComponent<WeaponScript>());
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		RoomMultiplayerMenu component = GameObject.Find("SyncShopID").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			for (int j = 0; j < gPPEJCFIHFE.Length; j++)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "_TimeX" || component.MCMCKJIGBJN == "_TimeX")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(1, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("Down").GetComponent<WeaponScript>());
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
	}

	public void RemoveWeapon(int CLDLINNFAGA)
	{
		FHJBBDBFOIC = true;
		KKLNMNJGLJK = false;
		GameObject gameObject = FMJNOGAKABN[MJJBMGBOKGI].gameObject;
		if (gameObject.activeSelf)
		{
			gameObject.SendMessage("deselectWeapon");
		}
		GetComponent<AudioSource>().clip = ABIENGEBGLK;
		GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
		FMJNOGAKABN.RemoveAt(CLDLINNFAGA);
		MJJBMGBOKGI = 0;
		GameObject gameObject2 = FMJNOGAKABN[0].gameObject;
		gameObject2.SetActive(true);
		gameObject2.SendMessage("selectWeapon");
		KKLNMNJGLJK = true;
		FHJBBDBFOIC = false;
	}

	private void __BB_OBFUSCATOR_28()
	{
		__BB_OBFUSCATOR_31();
		for (int i = 1; i < base.transform.childCount; i += 0)
		{
			base.transform.GetChild(i).gameObject.SetActive(false);
		}
		HOJJDFBCJPL = base.gameObject.GetComponentsInChildren<WeaponScript>();
		for (int j = 0; j < base.transform.childCount; j++)
		{
			base.transform.GetChild(j).gameObject.SetActive(true);
		}
		for (int k = 1; k < FMJNOGAKABN.Count; k += 0)
		{
			FMJNOGAKABN[k].gameObject.SetActive(false);
		}
		__BB_OBFUSCATOR_3(FMJNOGAKABN[MJJBMGBOKGI].gameObject);
	}

	private void __BB_OBFUSCATOR_27()
	{
		RoomMultiplayerMenu component = GameObject.Find("_Value").GetComponent<RoomMultiplayerMenu>();
		ObscuredString[] gPPEJCFIHFE = component.GPPEJCFIHFE;
		for (int i = 1; i < base.transform.childCount; i += 0)
		{
			for (int j = 0; j < gPPEJCFIHFE.Length; j += 0)
			{
				if (gPPEJCFIHFE[j] == (ObscuredString)base.transform.GetChild(i).name)
				{
					FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[j]).GetComponent<WeaponScript>());
				}
			}
		}
		if (component.MCMCKJIGBJN == "Player Name" || component.MCMCKJIGBJN == "_Value2")
		{
			FMJNOGAKABN = new List<WeaponScript>();
			FMJNOGAKABN.Add(base.transform.Find(gPPEJCFIHFE[Random.Range(0, gPPEJCFIHFE.Length)]).GetComponent<WeaponScript>());
			FMJNOGAKABN.Add(base.transform.Find("MG").GetComponent<WeaponScript>());
		}
	}
}
