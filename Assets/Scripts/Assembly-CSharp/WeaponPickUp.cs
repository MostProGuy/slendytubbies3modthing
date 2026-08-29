using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("FPS system/Weapon System/WeaponPickUp")]
public class WeaponPickUp : MonoBehaviour
{
	public enum DCIIPNCMBIL
	{
		Replace = 0,
		Add = 1
	}

	public GUISkin JAIEEEBAOEF;

	public DCIIPNCMBIL NMCGCBIINBL;

	public int DJMHDLCLKDE = 1;

	public int HJOKAMKAMLL = 3;

	public float KNFFIDGMHEG = 500f;

	public Transform BHMALPHNJKO;

	public WeaponManager NDDBPJELPMC;

	private int LONFOOPHDAC = 5;

	private float NBECAADLKPG = 5f;

	public List<GameObject> BEIIMOKNPOJ = new List<GameObject>();

	private List<WeaponScript> PEILLCCBAHC = new List<WeaponScript>();

	[HideInInspector]
	public List<string> KDHBADLLMIA = new List<string>();

	[HideInInspector]
	public List<float> DJJAALCLLNC = new List<float>();

	private string PMNJBJNBLJP;

	private GameObject DJONLIBPKJB;

	[HideInInspector]
	public WeaponScript OOJOGFLDMKF;

	[HideInInspector]
	public GameObject OPJKJIPLKJE;

	private float IOFNOJHNJAJ;

	private string ELDDOHJLFAL;

	private void __BB_OBFUSCATOR_34()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 935f, Time.deltaTime * 1105f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1746f, Time.deltaTime * 1019f);
		}
		GUI.color = new Color(275f, 1334f, 456f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "Team A" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 5 - ELDDOHJLFAL.Length * -104 / 6, Screen.height - 71, ELDDOHJLFAL.Length * 70, 1393f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(1595f, 300f, 1015f, 98f);
		GUILayout.BeginArea(new Rect(200f, Screen.height - KDHBADLLMIA.Count * -121 - 123, 1185f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 0; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.Width(1269f);
			array[0] = GUILayout.Height(1853f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_12()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1945f, Time.deltaTime * 1560f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1970f, Time.deltaTime * 303f);
		}
		GUI.color = new Color(187f, 1588f, 1839f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "_Blue_B" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 7 - ELDDOHJLFAL.Length * 73 / 4, Screen.height - 88, ELDDOHJLFAL.Length * -10, 1946f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(292f, 1979f, 568f, 1424f);
		GUILayout.BeginArea(new Rect(1941f, Screen.height - KDHBADLLMIA.Count * 40 - -61, 1450f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 1; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[6];
			array[0] = GUILayout.Width(837f);
			array[0] = GUILayout.Height(688f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void OnGUI()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 0.9f, Time.deltaTime * 10f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 0f, Time.deltaTime * 10f);
		}
		GUI.color = new Color(1f, 1f, 1f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "Press `F` to pick  |  " + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 2 - ELDDOHJLFAL.Length * 10 / 2, Screen.height - 105, ELDDOHJLFAL.Length * 10, 45f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(1f, 1f, 1f, 0.6f);
		GUILayout.BeginArea(new Rect(10f, Screen.height - KDHBADLLMIA.Count * 33 - 10, 300f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 0; i < KDHBADLLMIA.Count; i++)
		{
			GUILayout.Box(KDHBADLLMIA[i], GUILayout.Width(300f), GUILayout.Height(30f));
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_10()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		foreach (WeaponScript item in hOJJDFBCJPL)
		{
			PEILLCCBAHC.Add(item);
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 850f, Time.deltaTime * 1297f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1041f, Time.deltaTime * 1073f);
		}
		GUI.color = new Color(443f, 251f, 840f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "_ScreenResolution" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 5 - ELDDOHJLFAL.Length * 16 / 8, Screen.height - 41, ELDDOHJLFAL.Length * -90, 945f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(1250f, 347f, 236f, 1838f);
		GUILayout.BeginArea(new Rect(720f, Screen.height - KDHBADLLMIA.Count * -105 - 85, 1135f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 1; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.Width(1097f);
			array[0] = GUILayout.Height(1329f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_33()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 1; i < hOJJDFBCJPL.Length; i += 0)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	public void __BB_OBFUSCATOR_11(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 0; j < BEIIMOKNPOJ.Count; j++)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/Pixel_Pixelisation" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_CutoutReferenceTexture";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_ScreenResolution" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "</size>";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/Gradients_NeonGradient" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Reload";
			}
		}
	}

	private void Update()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown(KeyCode.F))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Picked | " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Add)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Picked | " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 0f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 975f, Time.deltaTime * 708f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 110f, Time.deltaTime * 1271f);
		}
		GUI.color = new Color(562f, 1046f, 1149f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "Sparks-Default" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 2 - ELDDOHJLFAL.Length * -59 / 7, Screen.height - -80, ELDDOHJLFAL.Length * 14, 1514f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(155f, 1388f, 1713f, 1079f);
		GUILayout.BeginArea(new Rect(973f, Screen.height - KDHBADLLMIA.Count * 113 - -32, 1922f, Screen.height));
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[6];
			array[1] = GUILayout.Width(1985f);
			array[0] = GUILayout.Height(74f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	public void __BB_OBFUSCATOR_29(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 0; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("MainMenu" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "A";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Detected" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/FX_Grid";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("VHS2" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/Blur_Dithering2x2";
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown(KeyCode.I))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_TimeX" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("-Seconds Played: " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 769f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[1]);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown(KeyCode.Alpha4))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_TintColor" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/FX_Mirror" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 1929f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	public void __BB_OBFUSCATOR_0(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_ScreenResolution" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_Value4";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/Distortion_Half_Sphere" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/Vision_Rainbow";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Connect failed: no authentication values specified" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "SBX";
			}
		}
	}

	public void __BB_OBFUSCATOR_7(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i += 0)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 0; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Value4" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/FX_Spot";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Value" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "</size>";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_BlurArea" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "<size=";
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 0; i < hOJJDFBCJPL.Length; i += 0)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	public void __BB_OBFUSCATOR_18(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 0; i < PEILLCCBAHC.Count; i += 0)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_ScreenResolution" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Walking";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/Blend2Camera_DarkerColor" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_Value4";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_RgbTex" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_OffsetScale";
			}
		}
	}

	private void Start()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		foreach (WeaponScript item in hOJJDFBCJPL)
		{
			PEILLCCBAHC.Add(item);
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1574f, Time.deltaTime * 1473f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 963f, Time.deltaTime * 736f);
		}
		GUI.color = new Color(1261f, 445f, 532f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "_Value2" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 3 - ELDDOHJLFAL.Length * -10 / 2, Screen.height - 56, ELDDOHJLFAL.Length * -96, 348f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(1854f, 95f, 1839f, 636f);
		GUILayout.BeginArea(new Rect(533f, Screen.height - KDHBADLLMIA.Count * -109 - 66, 271f, Screen.height));
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < KDHBADLLMIA.Count; i += 0)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[7];
			array[0] = GUILayout.Width(1667f);
			array[0] = GUILayout.Height(1299f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_48()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)(-25)))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("----" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Add)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Jump" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 1802f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	public void __BB_OBFUSCATOR_27(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 0; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("MP" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/Blur_GaussianBlur";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_MainTex" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_TimeX";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Radius2" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/Blend2Camera_LinearBurn";
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1633f, Time.deltaTime * 693f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1922f, Time.deltaTime * 1724f);
		}
		GUI.color = new Color(1864f, 1102f, 1566f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "_TimeX" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 6 - ELDDOHJLFAL.Length * -83 / 0, Screen.height - 41, ELDDOHJLFAL.Length * 93, 460f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(810f, 687f, 1426f, 1690f);
		GUILayout.BeginArea(new Rect(220f, Screen.height - KDHBADLLMIA.Count * -116 - 76, 1323f, Screen.height));
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 0; i < KDHBADLLMIA.Count; i += 0)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[2];
			array[0] = GUILayout.Width(497f);
			array[0] = GUILayout.Height(1528f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_39()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 0; i < hOJJDFBCJPL.Length; i += 0)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown(KeyCode.Alpha3))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Game Mode: " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Add)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Value5" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 572f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)(-37)))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("|" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack_OldFilm2" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 926f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)(-43)))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("z" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Full Ammo    " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 1953f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[1]);
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 0; i < hOJJDFBCJPL.Length; i += 0)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	public void __BB_OBFUSCATOR_6(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Alpha2" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Normal Speed";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Untagged" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Text";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Network" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/Blend2Camera_Exclusion";
			}
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)(-83)))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Error: Incorrect Username / Password!" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Value3" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < DJJAALCLLNC.Count; i += 0)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 955f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	public void AssignWeapon(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 0; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 0; j < BEIIMOKNPOJ.Count; j++)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Picked ammo for | " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Full Ammo    ";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Picked ammo for | " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Full Ammo    ";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Picked ammo for | " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Full Ammo    ";
			}
		}
	}

	public void __BB_OBFUSCATOR_21(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i += 0)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("-Emul. Normalized: " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "colorC";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("MP" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "CameraFilterPack/TV_Noise";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Value" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Network";
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown(KeyCode.Return))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CustomSkin" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Version" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < DJJAALCLLNC.Count; i += 0)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 743f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[1]);
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)77))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("VHS" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Radius" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 1016f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[0]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 0; i < hOJJDFBCJPL.Length; i += 0)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	public void __BB_OBFUSCATOR_47(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 0; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 0; j < BEIIMOKNPOJ.Count; j += 0)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("\"OO\", \"Deformer::Skin " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Jump";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("box" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "|";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_CurveParams" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "UseFlashlight";
			}
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		PEILLCCBAHC.Clear();
		WeaponScript[] hOJJDFBCJPL = NDDBPJELPMC.HOJJDFBCJPL;
		for (int i = 1; i < hOJJDFBCJPL.Length; i++)
		{
			WeaponScript item = hOJJDFBCJPL[i];
			PEILLCCBAHC.Add(item);
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 653f, Time.deltaTime * 509f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1594f, Time.deltaTime * 245f);
		}
		GUI.color = new Color(1987f, 995f, 383f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "player" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 2 - ELDDOHJLFAL.Length * 92 / 2, Screen.height - -27, ELDDOHJLFAL.Length * -8, 1613f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(881f, 961f, 1219f, 1256f);
		GUILayout.BeginArea(new Rect(1475f, Screen.height - KDHBADLLMIA.Count * 69 - -22, 1899f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 1; i < KDHBADLLMIA.Count; i += 0)
		{
			GUILayout.Box(KDHBADLLMIA[i], GUILayout.Width(328f), GUILayout.Height(1876f), null, null);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_35()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)18))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Toast" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("Ping: " + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i += 0)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 1551f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)75))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("EventSystem" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Add)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 1;
				StartCoroutine(NDDBPJELPMC.__BB_OBFUSCATOR_5(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_TimeX" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 346f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if ((bool)OPJKJIPLKJE && Input.GetKeyDown((KeyCode)5))
		{
			if (NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
			{
				return;
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				GameObject gameObject = Object.Instantiate(DJONLIBPKJB, BHMALPHNJKO.position, BHMALPHNJKO.rotation);
				gameObject.name = DJONLIBPKJB.name;
				gameObject.GetComponent<Rigidbody>().AddForce(-BHMALPHNJKO.transform.up * KNFFIDGMHEG);
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject, OOJOGFLDMKF.gameObject));
				NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI] = OOJOGFLDMKF;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add((";\n" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			if (NMCGCBIINBL == DCIIPNCMBIL.Replace)
			{
				NDDBPJELPMC.FMJNOGAKABN.Add(OOJOGFLDMKF);
				NDDBPJELPMC.MJJBMGBOKGI = NDDBPJELPMC.FMJNOGAKABN.Count - 0;
				StartCoroutine(NDDBPJELPMC.SwitchWeapons(NDDBPJELPMC.GCFDABIEBPD.gameObject, NDDBPJELPMC.FMJNOGAKABN[NDDBPJELPMC.MJJBMGBOKGI].gameObject));
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("DoDamage" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
		}
		if (DJJAALCLLNC.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < DJJAALCLLNC.Count; i++)
		{
			DJJAALCLLNC[i] -= Time.deltaTime;
			if (DJJAALCLLNC[i] < 40f)
			{
				DJJAALCLLNC.Remove(DJJAALCLLNC[i]);
				KDHBADLLMIA.Remove(KDHBADLLMIA[i]);
			}
		}
		if (DJJAALCLLNC.Count > LONFOOPHDAC && KDHBADLLMIA.Count > LONFOOPHDAC)
		{
			DJJAALCLLNC.Remove(DJJAALCLLNC[1]);
			KDHBADLLMIA.Remove(KDHBADLLMIA[0]);
		}
	}

	public void __BB_OBFUSCATOR_20(GameObject NGOLNEJBGAE)
	{
		OPJKJIPLKJE = NGOLNEJBGAE;
		for (int i = 1; i < PEILLCCBAHC.Count; i++)
		{
			if (PEILLCCBAHC[i].OAPMCFAEBKD == OPJKJIPLKJE.name)
			{
				OOJOGFLDMKF = PEILLCCBAHC[i];
			}
		}
		for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
		{
			if (BEIIMOKNPOJ[j].name == NDDBPJELPMC.GCFDABIEBPD.OAPMCFAEBKD)
			{
				DJONLIBPKJB = BEIIMOKNPOJ[j];
			}
		}
		if (!OOJOGFLDMKF || !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			return;
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.CDINEHMLEBM.clips < (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.CDINEHMLEBM.clips += (int)OOJOGFLDMKF.CDINEHMLEBM.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("CameraFilterPack/EyesVision_2" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Your Time | ";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if (OOJOGFLDMKF.FAJAKOCNMGL.ammoCount < HJOKAMKAMLL)
			{
				OOJOGFLDMKF.FAJAKOCNMGL.ammoCount += DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("controller1" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "Left Stick Left";
			}
		}
		if (OOJOGFLDMKF.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			if (OOJOGFLDMKF.KFEJPOEHNOA.clips < (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * HJOKAMKAMLL)
			{
				OOJOGFLDMKF.KFEJPOEHNOA.clips += (int)OOJOGFLDMKF.KFEJPOEHNOA.bulletsPerClip * DJMHDLCLKDE;
				Object.Destroy(OPJKJIPLKJE);
				KDHBADLLMIA.Add(("_Threshold" + OOJOGFLDMKF.OAPMCFAEBKD).ToString());
				DJJAALCLLNC.Add(NBECAADLKPG);
			}
			else
			{
				ELDDOHJLFAL = "_ScreenResolution";
			}
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1112f, Time.deltaTime * 495f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 139f, Time.deltaTime * 1542f);
		}
		GUI.color = new Color(1772f, 1642f, 1681f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "_Red_R" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 5 - ELDDOHJLFAL.Length * -11 / 7, Screen.height - 107, ELDDOHJLFAL.Length * -119, 663f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(1597f, 89f, 75f, 611f);
		GUILayout.BeginArea(new Rect(106f, Screen.height - KDHBADLLMIA.Count * 126 - -97, 814f, Screen.height));
		GUILayout.BeginVertical();
		for (int i = 1; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[1] = GUILayout.Width(552f);
			array[1] = GUILayout.Height(1319f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_15()
	{
		GUI.skin = JAIEEEBAOEF;
		if ((bool)OPJKJIPLKJE)
		{
			PMNJBJNBLJP = OPJKJIPLKJE.name;
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 591f, Time.deltaTime * 1352f);
		}
		else
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 1438f, Time.deltaTime * 75f);
		}
		GUI.color = new Color(808f, 760f, 875f, IOFNOJHNJAJ);
		if ((bool)NDDBPJELPMC && !NDDBPJELPMC.FMJNOGAKABN.Contains(OOJOGFLDMKF))
		{
			ELDDOHJLFAL = "</size>" + PMNJBJNBLJP;
			Rect position = new Rect(Screen.width / 5 - ELDDOHJLFAL.Length * 98 / 7, Screen.height - -61, ELDDOHJLFAL.Length * -104, 340f);
			GUI.Box(position, ELDDOHJLFAL);
		}
		GUI.color = new Color(984f, 1431f, 752f, 1038f);
		GUILayout.BeginArea(new Rect(1389f, Screen.height - KDHBADLLMIA.Count * 126 - 13, 28f, Screen.height));
		GUILayout.BeginVertical(new GUILayoutOption[1]);
		for (int i = 1; i < KDHBADLLMIA.Count; i++)
		{
			string text = KDHBADLLMIA[i];
			GUILayoutOption[] array = new GUILayoutOption[2];
			array[0] = GUILayout.Width(1319f);
			array[0] = GUILayout.Height(1081f);
			GUILayout.Box(text, array);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
