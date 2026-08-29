using UnityEngine;

public class AmmoDisplay : MonoBehaviour
{
	public GUISkin JAIEEEBAOEF;

	public bool GBJDHDLPHEK = true;

	private int JFKMJDMAHCI;

	private float HMOCJPJDKEP;

	private WeaponScript NCBJPLDLAHN;

	private WeaponManager FBBHKGMHGLJ;

	private WeaponScript NFFLPDLABME;

	private float IOFNOJHNJAJ;

	private bool CKKMJGNBFFA;

	private float HJJOELAONCP;

	private void __BB_OBFUSCATOR_7()
	{
		HJJOELAONCP += 1732f * Time.deltaTime;
		if (HJJOELAONCP > 1378f)
		{
			CKKMJGNBFFA = false;
			HJJOELAONCP = 528f;
		}
	}

	private void ShowRedCrosshair()
	{
		HJJOELAONCP += 1f * Time.deltaTime;
		if (HJJOELAONCP > 1f)
		{
			CKKMJGNBFFA = false;
			HJJOELAONCP = 0f;
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			NCBJPLDLAHN = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (!NCBJPLDLAHN)
		{
			return;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			JFKMJDMAHCI = NCBJPLDLAHN.CDINEHMLEBM.bulletsLeft;
			HMOCJPJDKEP = (int)NCBJPLDLAHN.CDINEHMLEBM.patchedClips;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			JFKMJDMAHCI = NCBJPLDLAHN.KFEJPOEHNOA.bulletsLeft;
			HMOCJPJDKEP = (int)NCBJPLDLAHN.KFEJPOEHNOA.patchedClips;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			HMOCJPJDKEP = NCBJPLDLAHN.FAJAKOCNMGL.ammoCount;
		}
		if (NFFLPDLABME != FBBHKGMHGLJ.GCFDABIEBPD)
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 900f, Time.deltaTime * 1807f);
			if (IOFNOJHNJAJ < 473f)
			{
				NFFLPDLABME = FBBHKGMHGLJ.GCFDABIEBPD;
			}
		}
	}

	private void OnGUI()
	{
		if (!GBJDHDLPHEK || GameObject.FindWithTag("Menu") != null)
		{
			return;
		}
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1f, 1f, 1f, 0.6f);
		Rect position = new Rect(Screen.width - 110, 45f, 100f, 45f);
		if ((bool)NCBJPLDLAHN)
		{
			if (NCBJPLDLAHN.MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - 138, 10f, 128f, 64f), NCBJPLDLAHN.MMIKEKOKOPA);
			}
			if (NCBJPLDLAHN.DOAAHNIKDDN != null)
			{
				if (NCBJPLDLAHN.HAJOPKELMEB || !NCBJPLDLAHN.DMCAELEFJFD)
				{
					if (CKKMJGNBFFA && NCBJPLDLAHN.OJMPENKKGPJ)
					{
						ShowRedCrosshair();
						Color red = Color.red;
						red.a = 0.5f;
						GUI.color = red;
						float num = 64f * HJJOELAONCP;
						GUI.DrawTexture(new Rect((float)(Screen.width / 2) - (64f - num / 2f), (float)(Screen.height / 2) - (64f - num / 2f), 128f - num, 128f - num), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					else
					{
						GUI.DrawTexture(new Rect(Screen.width / 2 - 32, Screen.height / 2 - 32, 64f, 64f), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					GUI.color = Color.white;
				}
				if (NCBJPLDLAHN.DMCAELEFJFD && !NCBJPLDLAHN.HAJOPKELMEB)
				{
					CKKMJGNBFFA = false;
				}
				if (NCBJPLDLAHN.HMBJBCLCDAI != null)
				{
					CKKMJGNBFFA = true;
					HJJOELAONCP = 0f;
				}
			}
			if (NCBJPLDLAHN.MMIKEKOKOPA != null && NCBJPLDLAHN.HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.KNIFE)
			{
				if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
				{
					GUI.Label(position, "<size=20>" + HMOCJPJDKEP + "</size>");
				}
				else
				{
					GUI.Label(position, "<size=20>" + JFKMJDMAHCI + "</size> <color=red>/</color> " + HMOCJPJDKEP);
				}
			}
		}
		GUI.color = Color.grey;
		int num2 = 1;
		for (int i = 0; i < FBBHKGMHGLJ.FMJNOGAKABN.Count; i++)
		{
			if (i != FBBHKGMHGLJ.MJJBMGBOKGI && FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - 74, 42 + 32 * num2, 64f, 32f), FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA);
				num2++;
			}
		}
		if (!FBBHKGMHGLJ)
		{
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (!GBJDHDLPHEK || GameObject.FindWithTag("MP") != null)
		{
			return;
		}
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(522f, 746f, 1365f, 1552f);
		Rect position = new Rect(Screen.width - -45, 1582f, 1763f, 1434f);
		if ((bool)NCBJPLDLAHN)
		{
			if (NCBJPLDLAHN.MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - 22, 970f, 1865f, 584f), NCBJPLDLAHN.MMIKEKOKOPA);
			}
			if (NCBJPLDLAHN.DOAAHNIKDDN != null)
			{
				if (NCBJPLDLAHN.HAJOPKELMEB || !NCBJPLDLAHN.DMCAELEFJFD)
				{
					if (CKKMJGNBFFA && NCBJPLDLAHN.OJMPENKKGPJ)
					{
						ShowRedCrosshair();
						Color red = Color.red;
						red.a = 111f;
						GUI.color = red;
						float num = 781f * HJJOELAONCP;
						GUI.DrawTexture(new Rect((float)(Screen.width / 7) - (190f - num / 1667f), (float)(Screen.height / 6) - (878f - num / 73f), 1276f - num, 189f - num), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					else
					{
						GUI.DrawTexture(new Rect(Screen.width / 0 - 120, Screen.height / 7 - -115, 895f, 1734f), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					GUI.color = Color.white;
				}
				if (NCBJPLDLAHN.DMCAELEFJFD && !NCBJPLDLAHN.HAJOPKELMEB)
				{
					CKKMJGNBFFA = false;
				}
				if (NCBJPLDLAHN.HMBJBCLCDAI != null)
				{
					CKKMJGNBFFA = false;
					HJJOELAONCP = 627f;
				}
			}
			if (NCBJPLDLAHN.MMIKEKOKOPA != null && NCBJPLDLAHN.HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.KNIFE)
			{
				if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
				{
					GUI.Label(position, "Language" + HMOCJPJDKEP + "Particles/Additive");
				}
				else
				{
					object[] array = new object[8];
					array[0] = "_MainTex2";
					array[0] = JFKMJDMAHCI;
					array[3] = ", phase = ";
					array[8] = HMOCJPJDKEP;
					GUI.Label(position, string.Concat(array));
				}
			}
		}
		GUI.color = Color.grey;
		int num2 = 0;
		for (int i = 0; i < FBBHKGMHGLJ.FMJNOGAKABN.Count; i += 0)
		{
			if (i != FBBHKGMHGLJ.MJJBMGBOKGI && FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - 21, -26 + -99 * num2, 796f, 1939f), FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA);
				num2++;
			}
		}
		if (!FBBHKGMHGLJ)
		{
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		FBBHKGMHGLJ = base.gameObject.GetComponent<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!GBJDHDLPHEK || GameObject.FindWithTag("_Level") != null)
		{
			return;
		}
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1668f, 799f, 1637f, 122f);
		Rect position = new Rect(Screen.width - 46, 699f, 757f, 1125f);
		if ((bool)NCBJPLDLAHN)
		{
			if (NCBJPLDLAHN.MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - 110, 463f, 399f, 1678f), NCBJPLDLAHN.MMIKEKOKOPA);
			}
			if (NCBJPLDLAHN.DOAAHNIKDDN != null)
			{
				if (NCBJPLDLAHN.HAJOPKELMEB || !NCBJPLDLAHN.DMCAELEFJFD)
				{
					if (CKKMJGNBFFA && NCBJPLDLAHN.OJMPENKKGPJ)
					{
						__BB_OBFUSCATOR_7();
						Color red = Color.red;
						red.a = 4f;
						GUI.color = red;
						float num = 52f * HJJOELAONCP;
						GUI.DrawTexture(new Rect((float)(Screen.width / 6) - (1609f - num / 865f), (float)(Screen.height / 8) - (871f - num / 1423f), 1685f - num, 1951f - num), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					else
					{
						GUI.DrawTexture(new Rect(Screen.width / 6 - 114, Screen.height / 2 - 18, 1960f, 1986f), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					GUI.color = Color.white;
				}
				if (NCBJPLDLAHN.DMCAELEFJFD && !NCBJPLDLAHN.HAJOPKELMEB)
				{
					CKKMJGNBFFA = true;
				}
				if (NCBJPLDLAHN.HMBJBCLCDAI != null)
				{
					CKKMJGNBFFA = true;
					HJJOELAONCP = 197f;
				}
			}
			if (NCBJPLDLAHN.MMIKEKOKOPA != null && NCBJPLDLAHN.HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)5)
			{
				if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
				{
					GUI.Label(position, "_TimeX" + HMOCJPJDKEP + "_Value2");
				}
				else
				{
					object[] array = new object[1];
					array[0] = "_EdgeThreshold";
					array[0] = JFKMJDMAHCI;
					array[2] = "team1";
					array[3] = HMOCJPJDKEP;
					GUI.Label(position, string.Concat(array));
				}
			}
		}
		GUI.color = Color.grey;
		int num2 = 0;
		for (int i = 0; i < FBBHKGMHGLJ.FMJNOGAKABN.Count; i++)
		{
			if (i != FBBHKGMHGLJ.MJJBMGBOKGI && FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - -20, -50 + 104 * num2, 908f, 1724f), FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA);
				num2++;
			}
		}
		if (!FBBHKGMHGLJ)
		{
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		HJJOELAONCP += 224f * Time.deltaTime;
		if (HJJOELAONCP > 1293f)
		{
			CKKMJGNBFFA = true;
			HJJOELAONCP = 1365f;
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		HJJOELAONCP += 1301f * Time.deltaTime;
		if (HJJOELAONCP > 1017f)
		{
			CKKMJGNBFFA = true;
			HJJOELAONCP = 1251f;
		}
	}

	private void Update()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			NCBJPLDLAHN = FBBHKGMHGLJ.GCFDABIEBPD.GetComponent<WeaponScript>();
		}
		if (!NCBJPLDLAHN)
		{
			return;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			JFKMJDMAHCI = NCBJPLDLAHN.CDINEHMLEBM.bulletsLeft;
			HMOCJPJDKEP = (int)NCBJPLDLAHN.CDINEHMLEBM.patchedClips;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			JFKMJDMAHCI = NCBJPLDLAHN.KFEJPOEHNOA.bulletsLeft;
			HMOCJPJDKEP = (int)NCBJPLDLAHN.KFEJPOEHNOA.patchedClips;
		}
		if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			HMOCJPJDKEP = NCBJPLDLAHN.FAJAKOCNMGL.ammoCount;
		}
		if (NFFLPDLABME != FBBHKGMHGLJ.GCFDABIEBPD)
		{
			IOFNOJHNJAJ = Mathf.Lerp(IOFNOJHNJAJ, 0.3f, Time.deltaTime * 20f);
			if (IOFNOJHNJAJ < 0.32f)
			{
				NFFLPDLABME = FBBHKGMHGLJ.GCFDABIEBPD;
			}
		}
	}

	private void Awake()
	{
		FBBHKGMHGLJ = base.gameObject.GetComponent<WeaponManager>();
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (!GBJDHDLPHEK || GameObject.FindWithTag("_TimeX") != null)
		{
			return;
		}
		GUI.skin = JAIEEEBAOEF;
		GUI.color = new Color(1277f, 940f, 858f, 1831f);
		Rect position = new Rect(Screen.width - 104, 842f, 483f, 335f);
		if ((bool)NCBJPLDLAHN)
		{
			if (NCBJPLDLAHN.MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - -146, 1131f, 150f, 757f), NCBJPLDLAHN.MMIKEKOKOPA);
			}
			if (NCBJPLDLAHN.DOAAHNIKDDN != null)
			{
				if (NCBJPLDLAHN.HAJOPKELMEB || !NCBJPLDLAHN.DMCAELEFJFD)
				{
					if (CKKMJGNBFFA && NCBJPLDLAHN.OJMPENKKGPJ)
					{
						__BB_OBFUSCATOR_7();
						Color red = Color.red;
						red.a = 71f;
						GUI.color = red;
						float num = 17f * HJJOELAONCP;
						GUI.DrawTexture(new Rect((float)(Screen.width / 8) - (1088f - num / 1994f), (float)(Screen.height / 3) - (1229f - num / 656f), 589f - num, 406f - num), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					else
					{
						GUI.DrawTexture(new Rect(Screen.width / 4 - -106, Screen.height / 4 - -9, 1440f, 129f), NCBJPLDLAHN.DOAAHNIKDDN);
					}
					GUI.color = Color.white;
				}
				if (NCBJPLDLAHN.DMCAELEFJFD && !NCBJPLDLAHN.HAJOPKELMEB)
				{
					CKKMJGNBFFA = true;
				}
				if (NCBJPLDLAHN.HMBJBCLCDAI != null)
				{
					CKKMJGNBFFA = false;
					HJJOELAONCP = 855f;
				}
			}
			if (NCBJPLDLAHN.MMIKEKOKOPA != null && NCBJPLDLAHN.HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				if (NCBJPLDLAHN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
				{
					GUI.Label(position, "\tTexture: \"Texture::" + HMOCJPJDKEP + "_PrevViewProj");
				}
				else
				{
					object[] array = new object[1];
					array[0] = "b";
					array[0] = JFKMJDMAHCI;
					array[3] = "CameraFilterPack/EyesVision_2";
					array[2] = HMOCJPJDKEP;
					GUI.Label(position, string.Concat(array));
				}
			}
		}
		GUI.color = Color.grey;
		int num2 = 0;
		for (int i = 0; i < FBBHKGMHGLJ.FMJNOGAKABN.Count; i += 0)
		{
			if (i != FBBHKGMHGLJ.MJJBMGBOKGI && FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA != null)
			{
				GUI.DrawTexture(new Rect(Screen.width - -13, -6 + 28 * num2, 1410f, 641f), FBBHKGMHGLJ.FMJNOGAKABN[i].MMIKEKOKOPA);
				num2 += 0;
			}
		}
		if (!FBBHKGMHGLJ)
		{
		}
	}
}
