using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TranslatorSystem;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
	[Serializable]
	public class weapon
	{
		public string name;

		public string type;

		public int price;

		public int bulletPrice = 1;
	}

	[CompilerGenerated]
	private sealed class AGJPNDJBIOM
	{
		internal int ADPNCFLPNNG;

		internal ShopSystem HIOCKJLGFBP;

		internal void __BB_OBFUSCATOR_22()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_45(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_1()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_11(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_8()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_63(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_12()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_64(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_14()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_29(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_17()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_26(ADPNCFLPNNG);
		}

		internal void _003C_003Em__1()
		{
			HIOCKJLGFBP.PurchaseWeapon(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_0()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_27(ADPNCFLPNNG);
		}

		internal void _003C_003Em__2()
		{
			HIOCKJLGFBP.PurchaseAmmo(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_15()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_26(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_7()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_38(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_16()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_34(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_20()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_32(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_24()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_76(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_4()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_48(ADPNCFLPNNG);
		}

		internal void _003C_003Em__0()
		{
			HIOCKJLGFBP.SellWeapon(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_19()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_63(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_13()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_56(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_21()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_34(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_3()
		{
			HIOCKJLGFBP.PurchaseAmmo(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_11()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_27(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_26()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_99(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_10()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_66(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_6()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_94(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_18()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_11(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_2()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_36(ADPNCFLPNNG);
		}

		internal void __BB_OBFUSCATOR_9()
		{
			HIOCKJLGFBP.__BB_OBFUSCATOR_71(ADPNCFLPNNG);
		}
	}

	public List<weapon> BEIIMOKNPOJ;

	public RectTransform IEJPOGLLCDC;

	public RectTransform KIOGLCBOLIL;

	public Text PMKNLDIGHOJ;

	public RectTransform FAAIBBDNFIF;

	public WeaponManager PEILLCCBAHC;

	public RectTransform GIPKIFANOON;

	private ObscuredInt JOGHMFDBLDK;

	public bool HGPCFMHBALL;

	private List<RectTransform> KLGAIDNNHGP = new List<RectTransform>();

	private string EJJPCAAHDGC = "Sell";

	private string JLNKCLAMFEH = "Cannot Sell";

	private string JOPEBFIANBJ = "Buy";

	private string EKLBFICJHCJ = "Ammo";

	private string PLIJNHIEMMJ = "Heal";

	private int PDIOKBPOILD;

	public bool AFOICCPPEEO;

	[CompilerGenerated]
	private static Func<weapon, int> NCBIMIMMADO;

	private void __BB_OBFUSCATOR_79()
	{
		if (GameObject.FindGameObjectWithTag("_NormalTex") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("_Radius").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)(-80)))
		{
			__BB_OBFUSCATOR_55();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("SwearFilter", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
			HGPCFMHBALL = false;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("_Distortion");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown((KeyCode)(-61)))
		{
			__BB_OBFUSCATOR_74();
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("_Value3");
			if (@int >= -8)
			{
				ObscuredPrefs.SetInt("<size=", @int - -65);
				PhotonNetwork.Instantiate("CreationTime: \"{0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}:{0:fff}\"\n", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (GameObject.FindGameObjectWithTag("</size>") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("*").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)(-36)))
		{
			__BB_OBFUSCATOR_18();
			HGPCFMHBALL = HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("_ScreenResolution", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = true;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("_Circle");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown((KeyCode)(-45)))
		{
			__BB_OBFUSCATOR_22();
		}
	}

	private static int __BB_OBFUSCATOR_53(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	public void __BB_OBFUSCATOR_3()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt(" x ", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_122();
	}

	public void __BB_OBFUSCATOR_14(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("_ScreenResolution", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("Kills") < 0)
			{
				ObscuredPrefs.SetInt("SyncTeamName", 0);
			}
		}
		ResetUI();
	}

	public void __BB_OBFUSCATOR_129(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_Value4", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_132();
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 1; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(713f, 1562f);
			IEJPOGLLCDC.offsetMin = new Vector2(488f, BEIIMOKNPOJ.Count * 3);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_28;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -24;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1501f, 428f, 208f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("\", \"Deformer::Skin ").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_TimeX").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.KNIFE)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = EJJPCAAHDGC + "CameraFilterPack/Color_Invert" + BEIIMOKNPOJ[j].price / 6;
						rectTransform.transform.Find("Restarting").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_8);
					}
					else
					{
						rectTransform.transform.Find("Kills").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("OffLadder").GetComponent<Text>().text = JOPEBFIANBJ + "CameraFilterPack/FX_Hexagon" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_15);
				}
				rectTransform.transform.Find("n8").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_MainTex2").GetComponent<Text>().text = EKLBFICJHCJ + "_Value" + num;
					rectTransform.transform.Find("_Red_R").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_24);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 0;
			FAAIBBDNFIF.Find("Sparks-Default").GetComponent<Text>().text = PLIJNHIEMMJ + "-Times Played: " + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_103());
		}
		if (ObscuredPrefs.GetInt("CameraFilterPack/Gradients_Desert") > 181)
		{
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_45(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_Value", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_54();
	}

	public void __BB_OBFUSCATOR_104(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 7;
				PEILLCCBAHC.__BB_OBFUSCATOR_23(i);
				ObscuredPrefs.SetInt("ApplyDamage", value);
			}
		}
		__BB_OBFUSCATOR_125();
	}

	private static int __BB_OBFUSCATOR_10(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private void __BB_OBFUSCATOR_120()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("Vertical");
			if (@int >= -108)
			{
				ObscuredPrefs.SetInt("_Value3", @int - -47);
				PhotonNetwork.Instantiate("Jump", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 1);
			}
		}
	}

	public void __BB_OBFUSCATOR_89()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_Value2", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_127();
	}

	private void __BB_OBFUSCATOR_122()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1904f, 291f);
			IEJPOGLLCDC.offsetMin = new Vector2(1165f, BEIIMOKNPOJ.Count * -66);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_92;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -81;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1854f, 1098f, 433f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Hat:").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Null").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 1; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)4)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("-Horizontal").GetComponent<Text>().text = EJJPCAAHDGC + "P - Fullscreen" + BEIIMOKNPOJ[j].price / 3;
						rectTransform.transform.Find("_BorderColor").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_14);
					}
					else
					{
						rectTransform.transform.Find(" has been disabled as it's not supported on the current platform.").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = JOPEBFIANBJ + "Floor" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("Death").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_26);
				}
				rectTransform.transform.Find("http://zeoworks.com/home/getlogin.php").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_MainTex").GetComponent<Text>().text = EKLBFICJHCJ + "Horizontal" + num;
					rectTransform.transform.Find("_Value").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_21);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 1;
			FAAIBBDNFIF.Find("Crouch_Idle").GetComponent<Text>().text = PLIJNHIEMMJ + "_Dist" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_21());
		}
		if (ObscuredPrefs.GetInt("Toast") > -177)
		{
			Application.Quit();
		}
	}

	private IEnumerator __BB_OBFUSCATOR_37()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private IEnumerator __BB_OBFUSCATOR_21()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_63(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 4;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("CameraFilterPack/Light_Rainbow", value);
			}
		}
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_70()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Total AI: <color=") > 1)
		{
			EJJPCAAHDGC = translator.Translate(-94, "Move Down2");
			JLNKCLAMFEH = translator.Translate(-52, "_Value3");
			JOPEBFIANBJ = translator.Translate(-25, "custardPos");
			EKLBFICJHCJ = translator.Translate(-11, "MP");
			PLIJNHIEMMJ = translator.Translate(31, "_Level");
		}
	}

	public void __BB_OBFUSCATOR_117(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("n15", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		ResetUI();
	}

	private IEnumerator __BB_OBFUSCATOR_13()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private void __BB_OBFUSCATOR_107()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_TimeX") > 1)
		{
			EJJPCAAHDGC = translator.Translate(34, "\\Microsoft\\WordPad\\Wor96BA.tmp");
			JLNKCLAMFEH = translator.Translate(53, "_Value3");
			JOPEBFIANBJ = translator.Translate(-77, "_Parameter");
			EKLBFICJHCJ = translator.Translate(-128, "_Bullet_1");
			PLIJNHIEMMJ = translator.Translate(-64, "|");
		}
	}

	private IEnumerator __BB_OBFUSCATOR_72()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_51(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 8;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("MapName", value);
			}
		}
		__BB_OBFUSCATOR_122();
	}

	public void __BB_OBFUSCATOR_1()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("Full Ammo    ", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_127();
	}

	public void __BB_OBFUSCATOR_75()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("Label", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_18();
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1989f, 123f);
			IEJPOGLLCDC.offsetMin = new Vector2(1007f, BEIIMOKNPOJ.Count * -46);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_61;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 44;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1813f, 211f, 1188f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("offsets").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Room Name ").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 1; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find(")").GetComponent<Text>().text = EJJPCAAHDGC + "Text" + BEIIMOKNPOJ[j].price / 1;
						rectTransform.transform.Find("_Value").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_14);
					}
					else
					{
						rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = JOPEBFIANBJ + "_Value" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("_Value").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_12);
				}
				rectTransform.transform.Find("SyncShopID").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("Toast").GetComponent<Text>().text = EKLBFICJHCJ + "Run" + num;
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_4);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 2;
			FAAIBBDNFIF.Find("_ScreenResolution").GetComponent<Text>().text = PLIJNHIEMMJ + "n4" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_72());
		}
		if (ObscuredPrefs.GetInt("8") > 66)
		{
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (GameObject.FindGameObjectWithTag("WFX_BImpact") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("ShopPoint").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)(-53)))
		{
			ResetUI();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("Reset", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = false;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("_Value");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown(KeyCode.A))
		{
			__BB_OBFUSCATOR_120();
		}
	}

	private static int __BB_OBFUSCATOR_121(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private void __BB_OBFUSCATOR_42()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("\\Google\\g65KYJszcHtFhpDC") > 1)
		{
			EJJPCAAHDGC = translator.Translate(-92, "/");
			JLNKCLAMFEH = translator.Translate(-58, "_PositionX");
			JOPEBFIANBJ = translator.Translate(-83, "INF");
			EKLBFICJHCJ = translator.Translate(-99, "CameraFilterPack_eyes_vision_2");
			PLIJNHIEMMJ = translator.Translate(-124, "ScreenResolution = ");
		}
	}

	public void __BB_OBFUSCATOR_94(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_Value", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_134()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("HeadURL") > 1)
		{
			EJJPCAAHDGC = translator.Translate(48, "Connect failed: no authentication values specified");
			JLNKCLAMFEH = translator.Translate(109, "controller4");
			JOPEBFIANBJ = translator.Translate(118, "Attack");
			EKLBFICJHCJ = translator.Translate(-126, "Spectators");
			PLIJNHIEMMJ = translator.Translate(-68, "_MainTex2");
		}
	}

	public void __BB_OBFUSCATOR_100()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("ShopPoint", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_118();
	}

	private void DropCurrency()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("Toast");
			if (@int >= 100)
			{
				ObscuredPrefs.SetInt("Toast", @int - 100);
				PhotonNetwork.Instantiate("Toast", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	public void __BB_OBFUSCATOR_46()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_VelocityScale", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("_Value3");
			if (@int >= -69)
			{
				ObscuredPrefs.SetInt("Concrete", @int - 41);
				PhotonNetwork.Instantiate("HostQuit", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	private static int __BB_OBFUSCATOR_77(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	public void __BB_OBFUSCATOR_29(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 6;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("_TimeX", value);
			}
		}
		__BB_OBFUSCATOR_55();
	}

	public void __BB_OBFUSCATOR_43()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_NoiseTex", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_118();
	}

	public void __BB_OBFUSCATOR_119(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 3;
				PEILLCCBAHC.__BB_OBFUSCATOR_6(i);
				ObscuredPrefs.SetInt("_TimeX", value);
			}
		}
		__BB_OBFUSCATOR_127();
	}

	public void __BB_OBFUSCATOR_137(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Plane", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_86();
	}

	public void __BB_OBFUSCATOR_131()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_Offsets", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		ResetUI();
	}

	public void __BB_OBFUSCATOR_65(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("Left Shift - run", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_SoftZDistance") < 1)
			{
				ObscuredPrefs.SetInt("CheckIfAlive", 0);
			}
		}
		__BB_OBFUSCATOR_127();
	}

	public void __BB_OBFUSCATOR_114(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 4;
				PEILLCCBAHC.__BB_OBFUSCATOR_23(i);
				ObscuredPrefs.SetInt("{0:0}:{1:00}", value);
			}
		}
		__BB_OBFUSCATOR_132();
	}

	private static int __BB_OBFUSCATOR_20(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private static int __BB_OBFUSCATOR_2(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	public void __BB_OBFUSCATOR_6()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_ScreenResolution", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_125();
	}

	public void __BB_OBFUSCATOR_48(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("SetTexAt(): Vertex not found", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_Offsets") < 1)
			{
				ObscuredPrefs.SetInt("Count", 0);
			}
		}
		__BB_OBFUSCATOR_18();
	}

	public void PurchaseAmmo(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("Toast", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("Toast") < 0)
			{
				ObscuredPrefs.SetInt("Toast", 0);
			}
		}
		ResetUI();
	}

	private void __BB_OBFUSCATOR_125()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 1; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(111f, 136f);
			IEJPOGLLCDC.offsetMin = new Vector2(1745f, BEIIMOKNPOJ.Count * 14);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_30;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 100;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1412f, 1799f, 1303f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("team1").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("EventSystem").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)6)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 0)
					{
						rectTransform.transform.Find("Joined master server").GetComponent<Text>().text = EJJPCAAHDGC + "CameraFilterPack/Edge_Golden" + BEIIMOKNPOJ[j].price / 5;
						rectTransform.transform.Find("_Value3").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_7);
					}
					else
					{
						rectTransform.transform.Find("Hide Ground").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("Sandbox").GetComponent<Text>().text = JOPEBFIANBJ + "HostQuit" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("monster").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_18);
				}
				rectTransform.transform.Find("LegsURL").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("CameraFilterPack/Blend2Camera_SplitScreen").GetComponent<Text>().text = EKLBFICJHCJ + "TDM" + num;
					rectTransform.transform.Find("Slow Motion").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_16);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 3;
			FAAIBBDNFIF.Find("Lobby").GetComponent<Text>().text = PLIJNHIEMMJ + ">" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_101());
		}
		if (ObscuredPrefs.GetInt("_TimeX") > -193)
		{
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_32(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("\", \"Skin\"", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("HeadlessBeforeSceneLoad") < 1)
			{
				ObscuredPrefs.SetInt("<", 0);
			}
		}
		ResetUI();
	}

	public void __BB_OBFUSCATOR_97(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 5;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("0", value);
			}
		}
		__BB_OBFUSCATOR_86();
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("team1");
			if (@int >= -52)
			{
				ObscuredPrefs.SetInt("SecondaryCausticsProjector", @int - 116);
				PhotonNetwork.Instantiate("Please make sure to assign a view target!", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	public void __BB_OBFUSCATOR_34(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("Label", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_Value2") < 1)
			{
				ObscuredPrefs.SetInt("Fire1", 1);
			}
		}
		__BB_OBFUSCATOR_132();
	}

	public void __BB_OBFUSCATOR_68(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_Threshhold", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_67();
	}

	private IEnumerator __BB_OBFUSCATOR_101()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_69(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("-Horizontal", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_54();
	}

	public void __BB_OBFUSCATOR_50(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("monster", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_9();
	}

	private IEnumerator __BB_OBFUSCATOR_19()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private void __BB_OBFUSCATOR_84()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("Speed (");
			if (@int >= 21)
			{
				ObscuredPrefs.SetInt("_TimeX", @int - 34);
				PhotonNetwork.Instantiate("Private", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("Mouse X");
			if (@int >= -67)
			{
				ObscuredPrefs.SetInt("_ScreenResolution", @int - -74);
				PhotonNetwork.Instantiate("CameraFilterPack/FX_ZebraColor", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 1);
			}
		}
	}

	private void Update()
	{
		if (GameObject.FindGameObjectWithTag("WeaponManager") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("WeaponManager").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			ResetUI();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("Shop", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = false;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("Toast");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown(KeyCode.M))
		{
			DropCurrency();
		}
	}

	public void __BB_OBFUSCATOR_96(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 2;
				PEILLCCBAHC.RemoveWeapon(i);
				ObscuredPrefs.SetInt("_Value3", value);
			}
		}
		ResetUI();
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("Reload_2_3");
			if (@int >= 122)
			{
				ObscuredPrefs.SetInt(" ", @int - 37);
				PhotonNetwork.Instantiate("_U", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 0);
			}
		}
	}

	public void __BB_OBFUSCATOR_66(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("\n", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_67();
	}

	private void __BB_OBFUSCATOR_132()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1293f, 695f);
			IEJPOGLLCDC.offsetMin = new Vector2(1956f, BEIIMOKNPOJ.Count * 104);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_20;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 81;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1486f, 1707f, 1295f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_Value").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Shop").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k += 0)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != 0)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("<size=").GetComponent<Text>().text = EJJPCAAHDGC + "_Size" + BEIIMOKNPOJ[j].price / 8;
						rectTransform.transform.Find(",").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__0);
					}
					else
					{
						rectTransform.transform.Find("|").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("PlayerType'").GetComponent<Text>().text = JOPEBFIANBJ + "CameraFilterPack/Blend2Camera_LinearBurn" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("Teleport").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_26);
				}
				rectTransform.transform.Find("State1").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("offsets").GetComponent<Text>().text = EKLBFICJHCJ + "CameraFilterPack/FX_Hypno" + num;
					rectTransform.transform.Find("Mouse X").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__2);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 4;
			FAAIBBDNFIF.Find("Full Ammo    ").GetComponent<Text>().text = PLIJNHIEMMJ + "Failed on connecting to room" + PDIOKBPOILD;
			StartCoroutine(resetScrollBar());
		}
		if (ObscuredPrefs.GetInt("Flashlight") > -35)
		{
			Application.Quit();
		}
	}

	private static int __BB_OBFUSCATOR_105(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	public void __BB_OBFUSCATOR_11(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_TimeX", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_24();
	}

	private void __BB_OBFUSCATOR_83()
	{
		if (GameObject.FindGameObjectWithTag("Mouse ScrollWheel") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("_TimeX").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)(-73)))
		{
			__BB_OBFUSCATOR_110();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("_MainTex2", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = false;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("OnExternalVelocity");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown(KeyCode.B))
		{
			__BB_OBFUSCATOR_120();
		}
	}

	public void __BB_OBFUSCATOR_126(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 2;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("n1", value);
			}
		}
		__BB_OBFUSCATOR_18();
	}

	private void __BB_OBFUSCATOR_35()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("ArmsURL") > 1)
		{
			EJJPCAAHDGC = translator.Translate(-69, "SUR");
			JLNKCLAMFEH = translator.Translate(93, "_Value3");
			JOPEBFIANBJ = translator.Translate(-61, "_MainTex2");
			EKLBFICJHCJ = translator.Translate(-101, "X");
			PLIJNHIEMMJ = translator.Translate(-34, "_diff\"\n\t\tProperties60:  {\n\t\t\tProperty: \"TextureTypeUse\", \"enum\", \"\",0\n\t\t\tProperty: \"Texture alpha\", \"Number\", \"A+\",1\n\t\t\tProperty: \"CurrentMappingType\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeU\", \"enum\", \"\",0\n\t\t\tProperty: \"WrapModeV\", \"enum\", \"\",0\n\t\t\tProperty: \"UVSwap\", \"bool\", \"\",0\n\t\t\tProperty: \"Translation\", \"Vector\", \"A+\",");
		}
	}

	public void __BB_OBFUSCATOR_133(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 0;
				PEILLCCBAHC.RemoveWeapon(i);
				ObscuredPrefs.SetInt("_Value", value);
			}
		}
		__BB_OBFUSCATOR_24();
	}

	public void __BB_OBFUSCATOR_71(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 8;
				PEILLCCBAHC.__BB_OBFUSCATOR_15(i);
				ObscuredPrefs.SetInt("RespawnPlayers", value);
			}
		}
		__BB_OBFUSCATOR_54();
	}

	public void __BB_OBFUSCATOR_98(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 0;
				PEILLCCBAHC.__BB_OBFUSCATOR_6(i);
				ObscuredPrefs.SetInt("_Value", value);
			}
		}
		__BB_OBFUSCATOR_122();
	}

	private static int __BB_OBFUSCATOR_95(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 1; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1490f, 461f);
			IEJPOGLLCDC.offsetMin = new Vector2(800f, BEIIMOKNPOJ.Count * 35);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = _003CResetUI_003Em__0;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -114;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1377f, 1787f, 1219f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("PlayerType'").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_NormalTex").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k += 0)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)6)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("{0},{1},{2}").GetComponent<Text>().text = EJJPCAAHDGC + "team1" + BEIIMOKNPOJ[j].price / 1;
						rectTransform.transform.Find("_TimeX").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_2);
					}
					else
					{
						rectTransform.transform.Find("_Distance").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("CameraFilterPack/FX_Plasma").GetComponent<Text>().text = JOPEBFIANBJ + "CameraFilterPack/Blend2Camera_Darken" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("INF").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__1);
				}
				rectTransform.transform.Find("_Color").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = EKLBFICJHCJ + "_Blue_C" + num;
					rectTransform.transform.Find("Jump").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_20);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 6;
			FAAIBBDNFIF.Find("F - weapon pick up").GetComponent<Text>().text = PLIJNHIEMMJ + "rect" + PDIOKBPOILD;
			StartCoroutine(resetScrollBar());
		}
		if (ObscuredPrefs.GetInt("_SunThreshold") > 169)
		{
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (GameObject.FindGameObjectWithTag("_ScreenResolution") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("_Value2").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			__BB_OBFUSCATOR_127();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("_Value", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
			HGPCFMHBALL = true;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("Dead");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown(KeyCode.O))
		{
			__BB_OBFUSCATOR_22();
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("CameraFilterPack/Color_Contrast");
			if (@int >= 43)
			{
				ObscuredPrefs.SetInt("RoundDuration", @int - 85);
				PhotonNetwork.Instantiate("Network", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 1);
			}
		}
	}

	public void HealPlayer()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("Toast", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		ResetUI();
	}

	private static int __BB_OBFUSCATOR_61(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1196f, 1403f);
			IEJPOGLLCDC.offsetMin = new Vector2(678f, BEIIMOKNPOJ.Count * 114);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_80;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 52;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1503f, 510f, 729f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_Value").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find(" ").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)7)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("_Offsets").GetComponent<Text>().text = EJJPCAAHDGC + "CameraFilterPack/Drawing_CellShading2" + BEIIMOKNPOJ[j].price / 5;
						rectTransform.transform.Find("_OverlayTex").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_7);
					}
					else
					{
						rectTransform.transform.Find("TeamTag").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("_ScreenResolution").GetComponent<Text>().text = JOPEBFIANBJ + "Toast" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("team1").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_6);
				}
				rectTransform.transform.Find("TeamTag").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_BlurSize").GetComponent<Text>().text = EKLBFICJHCJ + "_TimeX" + num;
					rectTransform.transform.Find("\n\t\tLayerElementColor: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"Col\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tColors: ").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_16);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 2;
			FAAIBBDNFIF.Find("_Value3").GetComponent<Text>().text = PLIJNHIEMMJ + "Fire" + PDIOKBPOILD;
			StartCoroutine(resetScrollBar());
		}
		if (ObscuredPrefs.GetInt("<size=") > 172)
		{
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (GameObject.FindGameObjectWithTag("CameraFilterPack_AAA_Blood1") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag(" ").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)(-73)))
		{
			__BB_OBFUSCATOR_18();
			HGPCFMHBALL = HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("\n", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = true;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("_MainTex2");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(true);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown(KeyCode.V))
		{
			__BB_OBFUSCATOR_84();
		}
	}

	public void __BB_OBFUSCATOR_76(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("_ScreenResolution", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("ZWName'") < 1)
			{
				ObscuredPrefs.SetInt("g", 0);
			}
		}
		__BB_OBFUSCATOR_118();
	}

	public void __BB_OBFUSCATOR_58(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 3;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("Loading complete", value);
			}
		}
		ResetUI();
	}

	private void __BB_OBFUSCATOR_112()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("_ScreenResolution") > 1)
		{
			EJJPCAAHDGC = translator.Translate(-12, "<");
			JLNKCLAMFEH = translator.Translate(-98, "\t\t\tMatrix: ");
			JOPEBFIANBJ = translator.Translate(-67, "Camera");
			EKLBFICJHCJ = translator.Translate(-117, "_Red_R");
			PLIJNHIEMMJ = translator.Translate(38, "MP");
		}
	}

	public void __BB_OBFUSCATOR_111(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("_Value", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_Intensity") < 1)
			{
				ObscuredPrefs.SetInt("_TimeX", 0);
			}
		}
		__BB_OBFUSCATOR_55();
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(669f, 846f);
			IEJPOGLLCDC.offsetMin = new Vector2(1507f, BEIIMOKNPOJ.Count * 55);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_28;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 2;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(474f, 447f, 855f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Consolidating mesh").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("CameraFilterPack/Blur_Focus").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.KNIFE)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("SUR").GetComponent<Text>().text = EJJPCAAHDGC + "<size=" + BEIIMOKNPOJ[j].price / 0;
						rectTransform.transform.Find("SwearFilter").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_14);
					}
					else
					{
						rectTransform.transform.Find(" }").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("Shop").GetComponent<Text>().text = JOPEBFIANBJ + "MapName" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("_Distortion").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_13);
				}
				rectTransform.transform.Find("_Color_B").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("\n\t\tLayerElementTexture: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"NoMappingInformation\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tBlendMode: \"Translucent\"\n\t\t\tTextureAlpha: 1\n\t\t\tTextureId: \n\t\t}").GetComponent<Text>().text = EKLBFICJHCJ + "SBX" + num;
					rectTransform.transform.Find("_Color").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_16);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 6;
			FAAIBBDNFIF.Find("_FadeFX").GetComponent<Text>().text = PLIJNHIEMMJ + "_Value4" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_101());
		}
		if (ObscuredPrefs.GetInt("_OffsetScale") > 138)
		{
			Application.Quit();
		}
	}

	private static int __BB_OBFUSCATOR_80(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private IEnumerator __BB_OBFUSCATOR_103()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_82(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Ping", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_127();
	}

	[CompilerGenerated]
	private static int _003CResetUI_003Em__0(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private IEnumerator __BB_OBFUSCATOR_81()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private void __BB_OBFUSCATOR_110()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(790f, 66f);
			IEJPOGLLCDC.offsetMin = new Vector2(872f, BEIIMOKNPOJ.Count * 92);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_105;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -44;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1002f, 621f, 706f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_PositionY").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_Saturation").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k += 0)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)5)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("_Value5").GetComponent<Text>().text = EJJPCAAHDGC + "_DotSize" + BEIIMOKNPOJ[j].price / 5;
						rectTransform.transform.Find("_Value").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__0);
					}
					else
					{
						rectTransform.transform.Find("CameraFilterPack/FX_InverChromiLum").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("Mouse").GetComponent<Text>().text = JOPEBFIANBJ + "_CutTex" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("1").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_18);
				}
				rectTransform.transform.Find("<size=20>").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("INF").GetComponent<Text>().text = EKLBFICJHCJ + "_MainTex2" + num;
					rectTransform.transform.Find("TeamTag").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_24);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 5;
			FAAIBBDNFIF.Find("*").GetComponent<Text>().text = PLIJNHIEMMJ + "offsets" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_103());
		}
		if (ObscuredPrefs.GetInt("_SoftZDistance") > -165)
		{
			Application.Quit();
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 1; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(573f, 993f);
			IEJPOGLLCDC.offsetMin = new Vector2(1095f, BEIIMOKNPOJ.Count * -114);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_30;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -32;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(272f, 1081f, 1838f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("CameraFilterPack/Blend2Camera_Lighten").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 1; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)6)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("Hat:").GetComponent<Text>().text = EJJPCAAHDGC + "a" + BEIIMOKNPOJ[j].price / 4;
						rectTransform.transform.Find(")").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_11);
					}
					else
					{
						rectTransform.transform.Find("Reload_1_3").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("_TimeX").GetComponent<Text>().text = JOPEBFIANBJ + "<size=" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("ApplyFallDamage").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_18);
				}
				rectTransform.transform.Find("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("Team2Score").GetComponent<Text>().text = EKLBFICJHCJ + "CameraFilterPack/Vision_Crystal" + num;
					rectTransform.transform.Find("CameraFilterPack/Sharpen_Sharpen").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_24);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 4;
			FAAIBBDNFIF.Find("KickPlayer").GetComponent<Text>().text = PLIJNHIEMMJ + "\n\t\tGeometryVersion: 124" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_81());
		}
		if (ObscuredPrefs.GetInt("Sparks") > -10)
		{
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_99(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Toast", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_54();
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("\n\t\t}");
			if (@int >= -125)
			{
				ObscuredPrefs.SetInt("Team1Score", @int - 55);
				PhotonNetwork.Instantiate("_TimeX", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 1);
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_78()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private void __BB_OBFUSCATOR_130()
	{
		if (GameObject.FindGameObjectWithTag("\", \"Model::") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("_Value4").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)2))
		{
			__BB_OBFUSCATOR_118();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("CameraFilterPack/Distortion_Half_Sphere", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = true;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("CameraFilterPack_VHS2");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown((KeyCode)(-121)))
		{
			__BB_OBFUSCATOR_12();
		}
	}

	private static int __BB_OBFUSCATOR_28(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private IEnumerator __BB_OBFUSCATOR_115()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	private void __BB_OBFUSCATOR_127()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(468f, 1138f);
			IEJPOGLLCDC.offsetMin = new Vector2(829f, BEIIMOKNPOJ.Count * -127);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_53;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 0; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -109;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1664f, 159f, 1633f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("_PrevViewProj").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("selectWeapon").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 1; k < PEILLCCBAHC.FMJNOGAKABN.Count; k += 0)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.SHOTGUN)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("Kills").GetComponent<Text>().text = EJJPCAAHDGC + "team1" + BEIIMOKNPOJ[j].price / 0;
						rectTransform.transform.Find("_Blue_G").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_8);
					}
					else
					{
						rectTransform.transform.Find("_Red_C").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("Infect").GetComponent<Text>().text = JOPEBFIANBJ + "custardPos" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("_Value").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__1);
				}
				rectTransform.transform.Find("Metal").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_TimeX").GetComponent<Text>().text = EKLBFICJHCJ + "EventSystem" + num;
					rectTransform.transform.Find("Count").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_24);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 1;
			FAAIBBDNFIF.Find("_Alpha").GetComponent<Text>().text = PLIJNHIEMMJ + "Ammo" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_33());
		}
		if (ObscuredPrefs.GetInt("usemtl ") > 167)
		{
			Application.Quit();
		}
	}

	private static int __BB_OBFUSCATOR_136(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private IEnumerator __BB_OBFUSCATOR_57()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_93(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 0;
				PEILLCCBAHC.__BB_OBFUSCATOR_15(i);
				ObscuredPrefs.SetInt("_Distortion", value);
			}
		}
		__BB_OBFUSCATOR_127();
	}

	public void __BB_OBFUSCATOR_123(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 8;
				PEILLCCBAHC.__BB_OBFUSCATOR_15(i);
				ObscuredPrefs.SetInt("CameraFilterPack_OldFilm2", value);
			}
		}
		__BB_OBFUSCATOR_67();
	}

	public void __BB_OBFUSCATOR_26(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("You", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_24();
	}

	public void __BB_OBFUSCATOR_36(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 0;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("HatID", value);
			}
		}
		__BB_OBFUSCATOR_9();
	}

	public void __BB_OBFUSCATOR_27(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 7;
				PEILLCCBAHC.RemoveWeapon(i);
				ObscuredPrefs.SetInt("_MainTex", value);
			}
		}
		ResetUI();
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (PEILLCCBAHC != null)
		{
			int @int = ObscuredPrefs.GetInt("_Value3");
			if (@int >= 38)
			{
				ObscuredPrefs.SetInt("Horizontal", @int - 89);
				PhotonNetwork.Instantiate("Noise & Grain effect failing as noise texture is not assigned. please assign.", PEILLCCBAHC.transform.position, PEILLCCBAHC.transform.rotation, 1);
			}
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i += 0)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(1414f, 401f);
			IEJPOGLLCDC.offsetMin = new Vector2(1285f, BEIIMOKNPOJ.Count * 87);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_20;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 0; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 31;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1326f, 315f, 343f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("DestroyNow").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("WeaponManager").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = true;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 1; k < PEILLCCBAHC.FMJNOGAKABN.Count; k += 0)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != (WeaponScript.BNILOGDCIEG)5)
					{
						flag = false;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 0)
					{
						rectTransform.transform.Find("Horizontal").GetComponent<Text>().text = EJJPCAAHDGC + "CameraFilterPack/Colors_NewPosterize" + BEIIMOKNPOJ[j].price / 3;
						rectTransform.transform.Find("{0:n6},{1:n6},{2:n6}").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_8);
					}
					else
					{
						rectTransform.transform.Find("Null").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find(" Simplified").GetComponent<Text>().text = JOPEBFIANBJ + "State2" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("CameraFilterPack/Blend2Camera_LinearLight").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_26);
				}
				rectTransform.transform.Find("_TimeX").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("_Value").GetComponent<Text>().text = EKLBFICJHCJ + "_ScreenResolution" + num;
					rectTransform.transform.Find("All players have been infected...").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_3);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 8;
			FAAIBBDNFIF.Find("-Normalized Time: ").GetComponent<Text>().text = PLIJNHIEMMJ + "_respawnAfter" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_81());
		}
		if (ObscuredPrefs.GetInt("_Value3") > -58)
		{
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_62(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Wood", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_54();
	}

	public void __BB_OBFUSCATOR_5(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 2;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("Label", value);
			}
		}
		__BB_OBFUSCATOR_18();
	}

	public void __BB_OBFUSCATOR_113(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("Detonator/Textures/GlowDot", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_ExposureAdjustment") < 0)
			{
				ObscuredPrefs.SetInt(">", 0);
			}
		}
		__BB_OBFUSCATOR_127();
	}

	private static int __BB_OBFUSCATOR_108(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private static int __BB_OBFUSCATOR_92(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 1; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(845f, 1717f);
			IEJPOGLLCDC.offsetMin = new Vector2(1917f, BEIIMOKNPOJ.Count * -67);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_31;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 1; j < BEIIMOKNPOJ.Count; j += 0)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * -29;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1542f, 1162f, 1683f);
				rectTransform.gameObject.SetActive(false);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Mouse ScrollWheel").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Can't set TransportProtocol. Disconnect first! ").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = true;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = false;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.SHOTGUN)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("Press a button to join!").GetComponent<Text>().text = EJJPCAAHDGC + "ZWName'" + BEIIMOKNPOJ[j].price / 1;
						rectTransform.transform.Find("CameraFilterPack/Blend2Camera_LinearDodge").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_7);
					}
					else
					{
						rectTransform.transform.Find("Crouch").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("_Value").GetComponent<Text>().text = JOPEBFIANBJ + "_Value2" + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("_TimeX").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_6);
				}
				rectTransform.transform.Find("intensity").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("CameraFilterPack/Blend2Camera_PinLight").GetComponent<Text>().text = EKLBFICJHCJ + "_Value2" + num;
					rectTransform.transform.Find("SBX").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM.__BB_OBFUSCATOR_24);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 1;
			FAAIBBDNFIF.Find("_TimeX").GetComponent<Text>().text = PLIJNHIEMMJ + "FBXHeaderExtension:  {\n\tFBXHeaderVersion: 1003\n\tFBXVersion: 6100\n\tCreationTimeStamp:  {\n\t\tVersion: 1000\n" + PDIOKBPOILD;
			StartCoroutine(__BB_OBFUSCATOR_115());
		}
		if (ObscuredPrefs.GetInt(")") > -103)
		{
			Application.Quit();
		}
	}

	public void __BB_OBFUSCATOR_38(int LBNKMMOBBOG)
	{
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 7;
				PEILLCCBAHC.__BB_OBFUSCATOR_20(i);
				ObscuredPrefs.SetInt("_Value", value);
			}
		}
		__BB_OBFUSCATOR_118();
	}

	private static int __BB_OBFUSCATOR_31(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	public void __BB_OBFUSCATOR_139()
	{
		if ((int)JOGHMFDBLDK >= PDIOKBPOILD && PEILLCCBAHC != null)
		{
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			parent.GetComponent<PlayerDamage>().HLPBCOGDPCF = parent.GetComponent<PlayerDamage>().CNNOMBEAPIH;
			ObscuredPrefs.SetInt("_ScreenResolution", (int)JOGHMFDBLDK - PDIOKBPOILD);
		}
		__BB_OBFUSCATOR_132();
	}

	public void __BB_OBFUSCATOR_64(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("_BlurredColor", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_127();
	}

	private void __BB_OBFUSCATOR_87()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("SwearFilter") > 1)
		{
			EJJPCAAHDGC = translator.Translate(53, "Player Host");
			JLNKCLAMFEH = translator.Translate(-17, "_MainTex2");
			JOPEBFIANBJ = translator.Translate(-6, "_ScreenResolution");
			EKLBFICJHCJ = translator.Translate(-78, "CameraFilterPack_VHS1");
			PLIJNHIEMMJ = translator.Translate(46, "n15");
		}
	}

	private void ResetUI()
	{
		if (PEILLCCBAHC != null)
		{
			if (KLGAIDNNHGP != null)
			{
				for (int i = 0; i < KLGAIDNNHGP.Count; i++)
				{
					UnityEngine.Object.Destroy(KLGAIDNNHGP[i].gameObject);
				}
				KLGAIDNNHGP = new List<RectTransform>();
			}
			IEJPOGLLCDC.offsetMax = new Vector2(0f, 0f);
			IEJPOGLLCDC.offsetMin = new Vector2(0f, BEIIMOKNPOJ.Count * 100);
			List<weapon> bEIIMOKNPOJ = BEIIMOKNPOJ;
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = _003CResetUI_003Em__0;
			}
			BEIIMOKNPOJ = bEIIMOKNPOJ.OrderBy(NCBIMIMMADO).ToList();
			for (int j = 0; j < BEIIMOKNPOJ.Count; j++)
			{
				AGJPNDJBIOM aGJPNDJBIOM = new AGJPNDJBIOM();
				aGJPNDJBIOM.HIOCKJLGFBP = this;
				RectTransform rectTransform = UnityEngine.Object.Instantiate(KIOGLCBOLIL.transform, base.transform.position, base.transform.rotation) as RectTransform;
				rectTransform.parent = IEJPOGLLCDC;
				Vector3 localPosition = KIOGLCBOLIL.localPosition;
				localPosition.y = IEJPOGLLCDC.offsetMin.y;
				localPosition.y -= j * 100;
				rectTransform.localPosition = localPosition;
				rectTransform.offsetMax = new Vector2(KIOGLCBOLIL.offsetMax.x, rectTransform.offsetMax.y);
				rectTransform.localScale = new Vector3(1f, 1f, 1f);
				rectTransform.gameObject.SetActive(true);
				rectTransform.name = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Name").GetComponent<Text>().text = BEIIMOKNPOJ[j].name;
				rectTransform.transform.Find("Type").GetComponent<Text>().text = BEIIMOKNPOJ[j].type;
				bool flag = false;
				bool flag2 = false;
				int num = BEIIMOKNPOJ[j].bulletPrice;
				for (int k = 0; k < PEILLCCBAHC.FMJNOGAKABN.Count; k++)
				{
					if (!(PEILLCCBAHC.FMJNOGAKABN[k].name == BEIIMOKNPOJ[j].name))
					{
						continue;
					}
					flag2 = true;
					if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH != WeaponScript.BNILOGDCIEG.KNIFE)
					{
						flag = true;
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].CDINEHMLEBM.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[k].KFEJPOEHNOA.patchedClips;
						}
						if (PEILLCCBAHC.FMJNOGAKABN[k].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
						{
							num *= (int)PEILLCCBAHC.FMJNOGAKABN[k].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[k].FAJAKOCNMGL.ammoCount;
						}
					}
				}
				aGJPNDJBIOM.ADPNCFLPNNG = j;
				if (flag2)
				{
					if (PEILLCCBAHC.FMJNOGAKABN.Count > 1)
					{
						rectTransform.transform.Find("Purchase/Text").GetComponent<Text>().text = EJJPCAAHDGC + ": " + BEIIMOKNPOJ[j].price / 2;
						rectTransform.transform.Find("Purchase").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__0);
					}
					else
					{
						rectTransform.transform.Find("Purchase/Text").GetComponent<Text>().text = JLNKCLAMFEH + string.Empty;
					}
				}
				else
				{
					rectTransform.transform.Find("Purchase/Text").GetComponent<Text>().text = JOPEBFIANBJ + ": " + BEIIMOKNPOJ[j].price;
					rectTransform.transform.Find("Purchase").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__1);
				}
				rectTransform.transform.Find("Ammo").gameObject.SetActive(flag);
				if (flag)
				{
					rectTransform.transform.Find("Ammo/Text").GetComponent<Text>().text = EKLBFICJHCJ + ": " + num;
					rectTransform.transform.Find("Ammo").GetComponent<Button>().onClick.AddListener(aGJPNDJBIOM._003C_003Em__2);
				}
				KLGAIDNNHGP.Add(rectTransform);
			}
			Transform parent = PEILLCCBAHC.transform.parent.parent.parent.parent;
			PDIOKBPOILD = (int)(parent.GetComponent<PlayerDamage>().CNNOMBEAPIH - (float)parent.GetComponent<PlayerDamage>().HLPBCOGDPCF) * 2;
			FAAIBBDNFIF.Find("ShopBox/Heal/Text").GetComponent<Text>().text = PLIJNHIEMMJ + ": " + PDIOKBPOILD;
			StartCoroutine(resetScrollBar());
		}
		if (ObscuredPrefs.GetInt("Toast") > 99999)
		{
			Application.Quit();
		}
	}

	private IEnumerator resetScrollBar()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void PurchaseWeapon(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Toast", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		ResetUI();
	}

	public void __BB_OBFUSCATOR_23(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("_TimeX", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_Distortion") < 1)
			{
				ObscuredPrefs.SetInt("_NoiseTex", 1);
			}
		}
		__BB_OBFUSCATOR_18();
	}

	private IEnumerator __BB_OBFUSCATOR_60()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_91(int LBNKMMOBBOG)
	{
		int num = BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
		for (int i = 1; i < PEILLCCBAHC.FMJNOGAKABN.Count; i += 0)
		{
			if (!(PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name))
			{
				continue;
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.MachineGun cDINEHMLEBM = PEILLCCBAHC.FMJNOGAKABN[i].CDINEHMLEBM;
					cDINEHMLEBM.patchedClips = (int)cDINEHMLEBM.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - (int)PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA.patchedClips = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					WeaponScript.shotGun kFEJPOEHNOA = PEILLCCBAHC.FMJNOGAKABN[i].KFEJPOEHNOA;
					kFEJPOEHNOA.patchedClips = (int)kFEJPOEHNOA.patchedClips + (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			if (PEILLCCBAHC.FMJNOGAKABN[i].HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				num *= (int)PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH - PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount;
				if ((int)JOGHMFDBLDK >= num)
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount = PEILLCCBAHC.FMJNOGAKABN[i].ELNOFDELCBH;
				}
				else
				{
					PEILLCCBAHC.FMJNOGAKABN[i].FAJAKOCNMGL.ammoCount += (int)JOGHMFDBLDK / BEIIMOKNPOJ[LBNKMMOBBOG].bulletPrice;
				}
			}
			ObscuredPrefs.SetInt("_OffsetScale", (int)JOGHMFDBLDK - num);
			if (ObscuredPrefs.GetInt("_BumpMap") < 1)
			{
				ObscuredPrefs.SetInt("Space - jump", 1);
			}
		}
		__BB_OBFUSCATOR_127();
	}

	public void SellWeapon(int LBNKMMOBBOG)
	{
		for (int i = 0; i < PEILLCCBAHC.FMJNOGAKABN.Count; i++)
		{
			if (PEILLCCBAHC.FMJNOGAKABN[i].name == BEIIMOKNPOJ[LBNKMMOBBOG].name)
			{
				int value = (int)JOGHMFDBLDK + BEIIMOKNPOJ[LBNKMMOBBOG].price / 2;
				PEILLCCBAHC.RemoveWeapon(i);
				ObscuredPrefs.SetInt("Toast", value);
			}
		}
		ResetUI();
	}

	private void Awake()
	{
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			EJJPCAAHDGC = translator.Translate(122, "MP");
			JLNKCLAMFEH = translator.Translate(27, "MP");
			JOPEBFIANBJ = translator.Translate(121, "MP");
			EKLBFICJHCJ = translator.Translate(124, "MP");
			PLIJNHIEMMJ = translator.Translate(123, "MP");
		}
	}

	public void __BB_OBFUSCATOR_56(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Horizontal", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_18();
	}

	private static int __BB_OBFUSCATOR_30(weapon FBPAMINIDIM)
	{
		return FBPAMINIDIM.price;
	}

	private IEnumerator __BB_OBFUSCATOR_33()
	{
		yield return new WaitForEndOfFrame();
		FAAIBBDNFIF.Find("ShopBox/Scrollbar").GetComponent<Scrollbar>().value = 1f;
	}

	public void __BB_OBFUSCATOR_138(int LBNKMMOBBOG)
	{
		if (PEILLCCBAHC != null && (int)JOGHMFDBLDK >= BEIIMOKNPOJ[LBNKMMOBBOG].price)
		{
			PEILLCCBAHC.FMJNOGAKABN.Add(PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>());
			WeaponScript component = PEILLCCBAHC.transform.Find(BEIIMOKNPOJ[LBNKMMOBBOG].name).GetComponent<WeaponScript>();
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
			{
				component.CDINEHMLEBM.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.KFEJPOEHNOA.patchedClips = component.ELNOFDELCBH;
			}
			if (component.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				component.FAJAKOCNMGL.ammoCount = component.ELNOFDELCBH;
			}
			ObscuredPrefs.SetInt("Horizontal", (int)JOGHMFDBLDK - BEIIMOKNPOJ[LBNKMMOBBOG].price);
		}
		__BB_OBFUSCATOR_122();
	}

	private void __BB_OBFUSCATOR_106()
	{
		if (GameObject.FindGameObjectWithTag("colorB") != null)
		{
			PEILLCCBAHC = GameObject.FindGameObjectWithTag("_Value").GetComponent<WeaponManager>();
		}
		if (Input.GetKeyDown((KeyCode)79))
		{
			__BB_OBFUSCATOR_67();
			HGPCFMHBALL = !HGPCFMHBALL;
		}
		ObscuredPrefs.SetBool("Kills", HGPCFMHBALL);
		if (HGPCFMHBALL && PEILLCCBAHC != null && AFOICCPPEEO)
		{
			FAAIBBDNFIF.gameObject.SetActive(true);
		}
		else
		{
			FAAIBBDNFIF.gameObject.SetActive(false);
			HGPCFMHBALL = false;
		}
		JOGHMFDBLDK = ObscuredPrefs.GetInt("Your Time | ");
		PMKNLDIGHOJ.text = string.Empty + JOGHMFDBLDK.ToString();
		if (AFOICCPPEEO && !FAAIBBDNFIF.gameObject.activeSelf)
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		else
		{
			GIPKIFANOON.gameObject.SetActive(false);
		}
		if (PEILLCCBAHC != null && Input.GetKeyDown((KeyCode)(-117)))
		{
			__BB_OBFUSCATOR_120();
		}
	}
}
