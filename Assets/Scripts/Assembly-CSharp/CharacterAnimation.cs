using System;
using System.Collections.Generic;
using InControl.mod;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
	public enum BGEKKPPAPMJ
	{
		Stand = 0,
		Crouch = 1,
		Prone = 2
	}

	[Serializable]
	public class animations
	{
		public AnimationClip jumpPose;

		public AnimationClip stayIdle;

		public AnimationClip crouchIdle;

		public AnimationClip proneIdle;

		public AnimationClip walkFront;

		public AnimationClip walkBack;

		public AnimationClip walkLeft;

		public AnimationClip walkRight;

		public AnimationClip runFront;

		public AnimationClip crouchFront;

		public AnimationClip crouchLeft;

		public AnimationClip crouchRight;

		public AnimationClip crouchBack;

		public AnimationClip proneFront;

		public AnimationClip proneLeft;

		public AnimationClip proneRight;

		public AnimationClip proneBack;

		public AnimationClip pistolIdle;

		public AnimationClip knifeIdle;

		public AnimationClip gunIdle;
	}

	[HideInInspector]
	public string HIJPAJKFKKI;

	[HideInInspector]
	public string JEHPINKEBCE;

	[HideInInspector]
	public string PEODMPNBHEA;

	[HideInInspector]
	public string AKHHMGKELGO;

	public WeaponManager FBBHKGMHGLJ;

	private BGEKKPPAPMJ CMIPAFEDNHE;

	public animations KPNCFGGKBCM;

	public List<WeaponScript> IDEFHFMPDKB = new List<WeaponScript>();

	public List<WeaponScript> AGOIANJDCFP = new List<WeaponScript>();

	public List<WeaponScript> GACOFCKKLBM = new List<WeaponScript>();

	private FPScontroller GJBFPMGPHPF;

	private void __BB_OBFUSCATOR_21()
	{
		if (CMIPAFEDNHE != 0)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "NormRain";
			}
		}
		else
		{
			JEHPINKEBCE = "_TimeX";
		}
	}

	private void __BB_OBFUSCATOR_101()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_115();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_114();
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_120();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_65();
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (CMIPAFEDNHE != BGEKKPPAPMJ.Prone)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "_Value2";
			}
		}
		else
		{
			JEHPINKEBCE = "n1";
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_111();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_63();
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)8;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "State1";
						if (cInput.GetButton("PlayerType'"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 924f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("-Horizontal"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 187f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Spectators") && !cInput.GetButton("Kill"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 631f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(","))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 457f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_HeightParams";
						if (cInput.GetButton("_Value2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1393f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1356f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1237f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "SBX";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(">  "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 456f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("CameraFilterPack_WaterDrop") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 267f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("INF") && !cInput.GetButton("_EdgeWeight"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1530f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("[BOT] Newborn"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1316f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1307f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)3)
		{
			AKHHMGKELGO = "SyncCount";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("State2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1611f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("TeamName") && !cInput.GetButton("Kills"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1461f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("SwearFilter") && !cInput.GetButton("_CenterX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 268f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("SBX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 217f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1367f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_28();
	}

	private void __BB_OBFUSCATOR_66()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_49();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_46();
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_CurTex";
						if (cInput.GetButton("Horizontal"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 970f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("</size>") && !cInput.GetButton("Run"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1602f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("</color>") && !cInput.GetButton("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1101f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("</size>"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 978f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Value2";
						if (cInput.GetButton("MP"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 328f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 422f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1941f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_Value2";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("team1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 286f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("6") && !cInput.GetButton("</color>"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1884f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_Vignette") && !cInput.GetButton("_BgColor"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1980f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("Back"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1410f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 710f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_Value";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("HeadlessBehaviour"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1346f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton(": ") && !cInput.GetButton(" ☠☠☠"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 581f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_BlurRadius4") && !cInput.GetButton("_EdgeSize"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 688f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("<size="))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 337f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 885f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_41();
	}

	private void __BB_OBFUSCATOR_40()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)6;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_ScreenResolution";
						if (cInput.GetButton("offsets"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 786f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("CameraFilterPack/Distortion_Heat") && !cInput.GetButton("\"GlobalSettings\""))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 226f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Toast") && !cInput.GetButton("_Value3"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1542f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Greenness"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1634f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "offsets";
						if (cInput.GetButton(": "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 290f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1371f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1580f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = " ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_NumberOfWaves"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1837f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("8") && !cInput.GetButton("CameraFilterPack/Blur_Radial_Fast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 562f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("1") && !cInput.GetButton("TeamASpawn"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1778f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("GameMode"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 447f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 650f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "SUR";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CustomSkin"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 739f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("networkAddMessage") && !cInput.GetButton(", phase = "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 142f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton(":") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1914f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("mm)"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 179f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1692f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_54();
	}

	private void __BB_OBFUSCATOR_57()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_17();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_87();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_125();
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_111();
		if ((bool)FBBHKGMHGLJ)
		{
			ThirdPersonWeaponControl();
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)6;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Kills";
						if (cInput.GetButton("Max Players: "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 919f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Bullet_1") && !cInput.GetButton("_Value2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1899f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("BodyURL") && !cInput.GetButton("Attack"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 803f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(", phase = "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 159f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "ShopPoint";
						if (cInput.GetButton("\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementColor\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1774f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 274f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 341f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_Value3";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("FireballB"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 974f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("Running") && !cInput.GetButton("_NormalTex"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 316f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Distortion_Flush") && !cInput.GetButton("ZWName'"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1940f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("{0:n6},{1:n6},{2:n6}"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1855f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1035f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)5)
		{
			AKHHMGKELGO = "<size=";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("<size="))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 208f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Distortion") && !cInput.GetButton("_Intensity"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 483f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("<size=16><color=cyan>[YOU]</color> ") && !cInput.GetButton("n6"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 177f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("UNUSED"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1818f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 653f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_21();
	}

	private void __BB_OBFUSCATOR_17()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Default;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)5;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "COOP";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 213f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Red_B") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 900f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton(" ") && !cInput.GetButton("TeamName"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1623f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("n6"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 880f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Value2";
						if (cInput.GetButton(")"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 336f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1855f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 242f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_ChromaticAberration";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Deaths"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 871f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Value7") && !cInput.GetButton("_NoisePerChannel"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 142f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("ForceDamage") && !cInput.GetButton("CameraFilterPack/Vision_Crystal"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 87f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("\n\n; Object properties\n;------------------------------------------------------------------\n\n"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1662f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 466f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_FadeFX";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("TDM"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 916f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("f2") && !cInput.GetButton("3"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1568f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("n8"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1952f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_Red_C"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 585f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1330f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_4();
	}

	private void __BB_OBFUSCATOR_13()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.PingPong;
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)6;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("_Value6"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 654f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("6") && !cInput.GetButton("Jump"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1739f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("\n\t\t}") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1363f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("Show Ground"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 141f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "</size>";
						if (cInput.GetButton("Consolidating mesh"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1637f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 837f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 333f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_Blue_B";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Value4"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1327f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("TDM") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 78f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_Color_R") && !cInput.GetButton("stretchWidth"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1803f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Distortion_ShockWave"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 465f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1816f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)3)
		{
			AKHHMGKELGO = "\t\tNbPoseNodes: ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CameraFilterPack/Blur_Noise"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 823f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("HatID") && !cInput.GetButton("Toast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 529f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Value2") && !cInput.GetButton("CameraFilterPack/Colors_HSV"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 636f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Remote"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1693f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1437f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_109();
	}

	private void __BB_OBFUSCATOR_123()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)3;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("_Value2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1463f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("><color=grey>") && !cInput.GetButton("_ScreenResolution"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 518f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("CameraFilterPack/Drawing_CellShading2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1839f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("Kills"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1446f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "MP";
						if (cInput.GetButton("Coin"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 509f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 328f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 539f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "RoundDuration";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("ScreenScaleX = "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 654f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("6") && !cInput.GetButton("CameraFilterPack/TV_WideScreenCircle"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1159f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("PlayerTinky") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1264f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("offsets"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 683f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 686f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "_Value4";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1988f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("monster") && !cInput.GetButton("\"OO\", \"Texture::"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1975f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Mouse Y") && !cInput.GetButton("offsets"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 741f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/TV_PlanetMars"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1002f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1865f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_27();
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (CMIPAFEDNHE != BGEKKPPAPMJ.Prone)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "_Value2";
			}
		}
		else
		{
			JEHPINKEBCE = "n15";
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_115();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_62();
		}
	}

	private void __BB_OBFUSCATOR_132()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "CameraFilterPack/NightVisionFX";
						if (cInput.GetButton("_Value3"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1598f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("mouse y") && !cInput.GetButton("Attack"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1531f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("</size> <color=red>/</color> ") && !cInput.GetButton("_Texture"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 665f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("TeamTag"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1076f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_NoisePerChannel";
						if (cInput.GetButton("INF"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1981f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1732f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1236f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_Axis";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(": "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 339f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("\n") && !cInput.GetButton("</size>"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1238f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("Attack") && !cInput.GetButton("SyncAll"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1218f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 80f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 377f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "Create Room";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 98f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("Crouch_Idle") && !cInput.GetButton("Consolidating mesh"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 358f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.") && !cInput.GetButton("SBX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1877f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_Contrast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 751f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 192f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_54();
	}

	private void __BB_OBFUSCATOR_114()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "SwearFilter";
			}
		}
		else
		{
			JEHPINKEBCE = "_TimeX";
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_124();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_65();
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Default;
		}
	}

	private void __BB_OBFUSCATOR_125()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)5)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Team1Score";
			}
		}
		else
		{
			JEHPINKEBCE = "TeamASpawn";
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_2();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_54();
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)7;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)7;
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)3;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Label";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1950f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton(",") && !cInput.GetButton("_Darkness"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1432f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("team2") && !cInput.GetButton("Network"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 976f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("CameraFilterPack/Drawing_Curve"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 406f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Thickness";
						if (cInput.GetButton("Quality"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1459f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 752f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1190f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "SyncNPCCount";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("[;\\\\/:*?\"<>|&']"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 121f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("Target no longer exists: ") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1776f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1773f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("TeamASpawn"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 669f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1566f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "threshold";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("/"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 538f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_MainTex") && !cInput.GetButton("X"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 42f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Team2Score") && !cInput.GetButton("Missing shader in "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 272f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1068f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 105f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_18();
	}

	private void __BB_OBFUSCATOR_10()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)3;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Team A";
						if (cInput.GetButton("\", \"Model::Scene\""))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1291f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("{0}:{1}") && !cInput.GetButton("_Bullet_6"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 816f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_TintColor") && !cInput.GetButton("RefTime"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 181f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("GameMode"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1093f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("Room Name: "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 111f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 267f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1146f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Paused";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("\"OO\", \"Model::"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1320f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("<size=") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1102f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Colors_DarkColor") && !cInput.GetButton("CameraFilterPack/Blend2Camera_Lighten"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 451f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("Toast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1188f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1505f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)5)
		{
			AKHHMGKELGO = ", phase = ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 585f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Colorisation") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1048f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton(",") && !cInput.GetButton("CameraFilterPack/Blur_Dithering2x2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 352f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Cannot Sell"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1635f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 144f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_73();
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "CameraFilterPack/TV_Posterize";
			}
		}
		else
		{
			JEHPINKEBCE = "OpAuthenticate()";
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Custom profiles are now deprecated. This example is left blank to prevent errors when importing new versions of InControl.";
						if (cInput.GetButton("_AlphaHexa"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 365f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("0") && !cInput.GetButton("_Red_C"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 250f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Deaths") && !cInput.GetButton("_Red_B"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1267f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("vn {0:0.000000} {1:0.000000} {2:0.000000}\n"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1261f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Value";
						if (cInput.GetButton("_ScreenResolution"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 425f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1775f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 948f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_Value";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(")"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1202f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_TimeX") && !cInput.GetButton("Left Stick Left"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 623f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("Tenkoku DynamicSky"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1872f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("Run"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1485f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1756f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "An animation with the name '";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("ApplyFallDamage"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1920f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("colorC") && !cInput.GetButton("_VelocityScale"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 723f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("DragObject") && !cInput.GetButton("_Value3"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 900f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("SyncTeamName"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 617f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 892f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_23();
	}

	private void __BB_OBFUSCATOR_109()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "MP";
			}
		}
		else
		{
			JEHPINKEBCE = "_BlurFilterDistance";
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Loop;
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value2";
						if (cInput.GetButton("_Value7"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 175f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("INF") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 451f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Hat:") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1840f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(" for incoming message event not found."))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1180f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "CameraFilterPack/Drawing_Halftone";
						if (cInput.GetButton("CameraFilterPack/FX_Funk"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1925f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1567f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1963f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_ProjInfo";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(" </color></size>"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1556f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("mouse y") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1094f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton(">") && !cInput.GetButton("_Value2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 116f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_Offsets"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1873f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 277f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "Mouse X";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Green"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 882f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Texture") && !cInput.GetButton("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 479f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("LegsURL") && !cInput.GetButton("_ProjInfo"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 59f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1080f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 432f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_125();
	}

	private void __BB_OBFUSCATOR_117()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)3;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Difficulty";
						if (cInput.GetButton("_Sensitivity"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 862f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("OnDetonatorForceHit") && !cInput.GetButton("_TintColor"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1960f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("MP") && !cInput.GetButton("useSrcAlphaAsMask"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1003f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Value6"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1011f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_ScreenResolution";
						if (cInput.GetButton("COOP"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1954f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 725f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1857f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Language";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Brightness"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1171f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Value4") && !cInput.GetButton("_AccumOrig"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 365f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_MainTex2") && !cInput.GetButton("Particles/Additive"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1144f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("SBX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1894f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1787f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = " (ID:";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("ZWName'"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1566f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("\n\n; Object properties\n;------------------------------------------------------------------\n\n") && !cInput.GetButton("team1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1602f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Light_Water2") && !cInput.GetButton("_Value4"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 590f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("MP"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1427f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1907f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_54();
	}

	private void __BB_OBFUSCATOR_49()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value";
						if (cInput.GetButton("Difficulty"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 196f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("CameraFilterPack/FX_Ascii") && !cInput.GetButton("\"GlobalSettings\""))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 399f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("CameraFilterPack/Gradients_FireGradient") && !cInput.GetButton("CameraFilterPack/BlurHole"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 31f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 442f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Hidden/Aubergine/SecurityCamera";
						if (cInput.GetButton("CameraFilterPack/FX_Spot"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1235f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1386f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1549f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_TimeX";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 8f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("TeamName") && !cInput.GetButton("Left Stick Right"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 419f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("SwearFilter") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 682f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Oculus_NightVision2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1943f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 118f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "Collapsing edges";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CameraFilterPack/Light_Water"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1801f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("WFX_MF Spr") && !cInput.GetButton("Attack"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 194f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Blue") && !cInput.GetButton("_Value3"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 31f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("|"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 301f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1379f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_30();
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)5)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = ",";
			}
		}
		else
		{
			JEHPINKEBCE = "0";
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)4;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("_PositionX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 132f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("FurColor") && !cInput.GetButton("Collapsing edges"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 883f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Idle") && !cInput.GetButton("Idle"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 205f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("CameraFilterPack/TV_50"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1000f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_CenterX";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 187f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 234f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 145f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "CameraFilterPack/FX_8bits";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 602f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_BlurRadius4") && !cInput.GetButton("RemoveFriends max list size exceeded: "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1983f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_ExposureAdjustment") && !cInput.GetButton(","))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1743f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 191f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 406f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "+";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("ServerID"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 643f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("#"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 944f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Consolidating mesh") && !cInput.GetButton("_Axis"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 528f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Diffuse"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1807f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 778f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_18();
	}

	private void __BB_OBFUSCATOR_96()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_74();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_23();
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)3;
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		if (CMIPAFEDNHE != BGEKKPPAPMJ.Prone)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "CameraFilterPack/Blend2Camera_Color";
			}
		}
		else
		{
			JEHPINKEBCE = "SUR";
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)6)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Detected";
			}
		}
		else
		{
			JEHPINKEBCE = "MP";
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Prone;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 60f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("ArmsURL") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 153f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Language") && !cInput.GetButton("CameraFilterPack/Gradients_Desert"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1267f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("\"Material\""))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 164f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("Language"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 473f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1085f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1512f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Loading complete";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CameraFilterPack/Retro_Loading"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 254f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("monster") && !cInput.GetButton("Password"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 579f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("LMB - fire") && !cInput.GetButton("SetTexAt(): Vertex not found"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1068f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_Value2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1591f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 128f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)7)
		{
			AKHHMGKELGO = "_SoftZDistance";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Language"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1876f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("offsets") && !cInput.GetButton("_NoiseAmount"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 480f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Ammo") && !cInput.GetButton("ApplyFallDamage"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 339f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Toast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1717f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1537f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_65();
	}

	private void __BB_OBFUSCATOR_104()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "team1";
			}
		}
		else
		{
			JEHPINKEBCE = "A";
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_33();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_28();
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_48();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_125();
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)3;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "SetTexAt(): Vertex not found";
						if (cInput.GetButton("{0}: {1}"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1510f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("networkAddMessage") && !cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 622f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("MP") && !cInput.GetButton("SyncWave"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 159f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(","))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1672f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_BlurDirectionPacked";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1814f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 313f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 69f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "n15";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("ObjectType"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1302f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("Make sure to set the collision layers to the layers the camera should collide with!"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1980f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("Network"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 807f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_Green_G"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 60f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1652f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "Last Input Type: ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_MainTex2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1610f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("\t\t\tMatrix: ") && !cInput.GetButton("_MainTex2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 680f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Value4") && !cInput.GetButton("s"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1092f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_AdaptionSpeed"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 172f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 647f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_21();
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)6)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp";
			}
		}
		else
		{
			JEHPINKEBCE = "Indexes";
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_124();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_30();
		}
	}

	private void __BB_OBFUSCATOR_120()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_126()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)8;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_ScreenResolution";
						if (cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 590f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("n4") && !cInput.GetButton("SecondaryCausticsProjector"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1867f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("/") && !cInput.GetButton("http://zeoworks.com/home/thread-1194-post-3680.html#pid3680"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 432f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Value2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1956f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_MainTex2";
						if (cInput.GetButton("Network"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 530f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1376f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 574f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "CameraFilterPack/Colors_Brightness";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Attack"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1189f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("HatID") && !cInput.GetButton("Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1094f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_Value") && !cInput.GetButton("CameraFilterPack/Blend2Camera_Multiply"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1105f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Blur_Steam"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1175f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 814f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "Connect";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("l"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 75f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton(": ") && !cInput.GetButton("Failed on connecting to room"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1566f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Parameter") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1200f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("\\Microsoft\\WordPad\\Wor96BA.tmp"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1363f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 48f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_41();
	}

	private void __BB_OBFUSCATOR_14()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value2";
						if (cInput.GetButton("Extinguish"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1617f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("DoDamage") && !cInput.GetButton("Toast"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 858f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("offsets"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1277f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(": "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1196f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Vertices: ";
						if (cInput.GetButton("TeamName"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1782f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1006f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 503f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_Distortion";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 238f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("Camera") && !cInput.GetButton("TDM"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1463f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_Threshhold") && !cInput.GetButton("Connecting to nameserver "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 936f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("/"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 619f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 968f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)6)
		{
			AKHHMGKELGO = "_ScreenResolution";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Walk"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 908f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("_Refraction"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 809f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Drawing_Manga_Color") && !cInput.GetButton("\n"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 267f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_PositionX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 858f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1833f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_41();
	}

	private void LateUpdate()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Prone;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Walking";
						if (cInput.GetButton("Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 0.2f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("-Horizontal") && !cInput.GetButton("-Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 0.2f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Horizontal") && !cInput.GetButton("-Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 0.2f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("-Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 0.2f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Running";
						if (cInput.GetButton("Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 0.2f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 0.2f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Crouch";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("-Horizontal") && !cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("Horizontal") && !cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 0.2f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "Prone";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("-Horizontal") && !cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Horizontal") && !cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("-Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 0.2f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 0.2f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		ThirdPersonWeaponControl();
	}

	private void __BB_OBFUSCATOR_53()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_15();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_125();
		}
	}

	private void __BB_OBFUSCATOR_113()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value";
						if (cInput.GetButton("_Value4"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1612f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("\r\n|\r|\n") && !cInput.GetButton("Map Name"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 40f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_TimeX") && !cInput.GetButton(">"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1611f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton(": "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 773f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Can't authenticate on front end server. Secret is not set";
						if (cInput.GetButton("_respawnAfter"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 542f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 491f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 486f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "\n\t\tLayerElementNormal: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByVertice\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tNormals: ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CameraFilterPack/Vision_Plasma"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1007f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("\"OO\", \"Texture::") && !cInput.GetButton("Right Stick Down"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 484f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("GameMode") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 658f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 598f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 367f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)8)
		{
			AKHHMGKELGO = "monster";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("PrimaryCausticsProjector"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 770f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("Player") && !cInput.GetButton("Image"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 156f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Fire1") && !cInput.GetButton("ZWName'"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 503f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("DoDamage"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1607f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 805f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_65();
	}

	private void __BB_OBFUSCATOR_26()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value2";
						if (cInput.GetButton("NewBorn_Bot"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1125f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("CameraFilterPack/Color_GrayScale") && !cInput.GetButton("Result"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1182f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_TimeX") && !cInput.GetButton("Horizontal"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1474f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_ScreenResolution"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 867f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_TintColor";
						if (cInput.GetButton("</size>"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1682f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 532f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 997f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "close";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("team2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1417f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Radius") && !cInput.GetButton("_Value2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 256f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_Value3") && !cInput.GetButton("ApplyDamage"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 413f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("\""))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1301f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1608f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "InControl(Clone)";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Noise"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 157f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("WeaponScript.js should be attached to same gameObject") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1744f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("<color=red><b>▼</b></color>") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1062f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Vertical"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 336f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1434f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_65();
	}

	private void __BB_OBFUSCATOR_105()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_74();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_54();
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_1();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_30();
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (CMIPAFEDNHE != BGEKKPPAPMJ.Prone)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "_PrevViewProj";
			}
		}
		else
		{
			JEHPINKEBCE = "Metal";
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "FBXHeaderExtension:  {\n\tFBXHeaderVersion: 1003\n\tFBXVersion: 6100\n\tCreationTimeStamp:  {\n\t\tVersion: 1000\n";
						if (cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 910f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("Null") && !cInput.GetButton(" ☠☠☠"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 232f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_Distortion") && !cInput.GetButton(">"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 127f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 499f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_OverlayTex";
						if (cInput.GetButton("_ToPrevViewProjCombined"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 261f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 787f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1714f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Team1Score";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1615f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton(",") && !cInput.GetButton("Null"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1434f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("MP") && !cInput.GetButton("Player "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 451f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Drawing_Curve"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 237f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 931f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)4)
		{
			AKHHMGKELGO = "_MainTex2";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Right Stick Up"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1909f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("Target already added: ") && !cInput.GetButton("\n\t\t\tProperty: \"Specular\", \"ColorRGB\", \"\",1.0,1.0,1.0\n\t\t\tProperty: \"Shininess\", \"double\", \"\",12.3\n\t\t\tProperty: \"Opacity\", \"double\", \"\",1.0\n\t\t\tProperty: \"Reflectivity\", \"double\", \"\",0\n\t\t}\n\t}\n"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1744f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_VelocityScale") && !cInput.GetButton("*"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 715f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Failed on creating room"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 119f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 843f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_62();
	}

	private void __BB_OBFUSCATOR_1()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)5;
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_15();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_30();
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (CMIPAFEDNHE != 0)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "_Value";
			}
		}
		else
		{
			JEHPINKEBCE = "MainMenu";
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.PingPong;
		}
	}

	private void __BB_OBFUSCATOR_124()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Once;
		}
	}

	private void __BB_OBFUSCATOR_111()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)5;
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_13();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_41();
		}
	}

	private void __BB_OBFUSCATOR_140()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_133();
		if ((bool)FBBHKGMHGLJ)
		{
			ThirdPersonWeaponControl();
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)4)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Shop";
			}
		}
		else
		{
			JEHPINKEBCE = "7";
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)8)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "_Value2";
			}
		}
		else
		{
			JEHPINKEBCE = "The shader ";
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_2();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_73();
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_49();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_21();
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "https://www.dropbox.com/s/xahqjy613z94kyg/s3_servers.txt?dl=1";
						if (cInput.GetButton("n6"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1946f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("\n\n;Version 5 settings\n;------------------------------------------------------------------\n\n") && !cInput.GetButton("Label"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1853f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Main Menu") && !cInput.GetButton("Complete"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 358f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("Count"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1578f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Mouse";
						if (cInput.GetButton("Diffuse"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 760f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1312f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1881f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "CameraFilterPack/Blur_GaussianBlur";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("DM"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 39f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("team2") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1669f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("\tModel: \"Model::") && !cInput.GetButton("box"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1689f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("<size="))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 111f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1233f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)3)
		{
			AKHHMGKELGO = "_MainTex";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Default"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1735f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Value") && !cInput.GetButton("CameraFilterPack_VHS1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 740f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Value") && !cInput.GetButton("monster"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 935f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_PrevViewProj"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 337f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1637f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_27();
	}

	private void __BB_OBFUSCATOR_102()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)4)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Time until next wave";
			}
		}
		else
		{
			JEHPINKEBCE = "Metal";
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_120();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_65();
		}
	}

	private void __BB_OBFUSCATOR_133()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)3;
		}
	}

	private void __BB_OBFUSCATOR_136()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Default;
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)4;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_MainTex2";
						if (cInput.GetButton("_DotSize"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1901f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("\n\t\tLayerElementSmoothing: 0 {\n\t\t\tVersion: 102\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tSmoothing: 1\n\t\t}") && !cInput.GetButton("SBX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 865f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Ping") && !cInput.GetButton("team2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1166f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_ScreenResolution"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 859f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "CameraFilterPack/Blend2Camera_Multiply";
						if (cInput.GetButton("_Scale"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1040f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 819f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 34f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_TimeX";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("offsets"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1174f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Threshhold") && !cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 699f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton(">") && !cInput.GetButton("Toast"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1120f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_EdgeThreshold"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 559f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 822f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)6)
		{
			AKHHMGKELGO = "Private";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("PrimaryCausticsProjector"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 845f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Blend2Camera_Darken") && !cInput.GetButton("Jump"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1211f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton(" </color></size>") && !cInput.GetButton("_Value2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1150f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 833f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1340f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_103();
	}

	private void __BB_OBFUSCATOR_25()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_133();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)4)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "CameraFilterPack/FX_DigitalMatrix";
			}
		}
		else
		{
			JEHPINKEBCE = "TeamTag";
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_BorderSize";
						if (cInput.GetButton("_Value2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1318f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("\n\t\t\tProperty: \"Diffuse\", \"ColorRGB\", \"\",0.8,0.8,0.8") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 263f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Mouse") && !cInput.GetButton("CameraFilterPack/Colors_Adjust_FullColors"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 155f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("-Vertical"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 464f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = ">";
						if (cInput.GetButton("_ScreenResolution"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 757f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 302f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 404f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_ExposureAdjustment";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 94f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_ForegroundBlurExtrude") && !cInput.GetButton("NextFrame"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 24f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Blend2Camera_LinearBurn") && !cInput.GetButton("Plane"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1706f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("Player"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 174f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 569f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_bump\", \"Model::";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1712f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("We connected to Photon Cloud") && !cInput.GetButton("\\xAu4YW5QzfD2KQjV"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 186f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("MP") && !cInput.GetButton("Press a button to join!"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 794f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Connections"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1238f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 532f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_30();
	}

	private void __BB_OBFUSCATOR_138()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)6;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "State2";
						if (cInput.GetButton(","))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 887f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("HostQuit") && !cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 168f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Loading") && !cInput.GetButton("ObjectType"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 121f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("</size>"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 580f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "\"OO\", \"Model::";
						if (cInput.GetButton("Connect"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 494f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1283f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1527f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "pointBuffer";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Untagged"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1037f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("Crouch") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1823f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("box") && !cInput.GetButton("VS"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 480f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_Intensity"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1829f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 347f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)5)
		{
			AKHHMGKELGO = "A player has been caught";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CreationTime: \"{0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}:{0:fff}\"\n"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 182f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_TimeX") && !cInput.GetButton("_TimeX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 502f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("ReferenceResolution = ") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1606f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Grounded"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1077f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1610f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_4();
	}

	private void __BB_OBFUSCATOR_100()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)8;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "CameraFilterPack/Special_Bubble";
						if (cInput.GetButton(": "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 731f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Intensity") && !cInput.GetButton("_WaveIntensity"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1760f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("Connect") && !cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1836f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 883f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "</size>";
						if (cInput.GetButton("Ban"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1830f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1773f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 599f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_TimeX";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Deaths"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1047f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Value") && !cInput.GetButton("CameraFilterPack/Blend2Camera_Screen"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1481f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("GiveCurrency") && !cInput.GetButton("DoDamage"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 666f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 677f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 781f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)4)
		{
			AKHHMGKELGO = "Move Left2";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Speed ("))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 286f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Circle") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1403f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("Debug ") && !cInput.GetButton("_CenterY"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1524f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_FadeFX"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1501f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 905f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_21();
	}

	private void ThirdPersonWeaponControl()
	{
		if (CMIPAFEDNHE != BGEKKPPAPMJ.Prone)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Melee";
			}
		}
		else
		{
			JEHPINKEBCE = "Null";
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)7;
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_94();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_108()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value";
						if (cInput.GetButton("_BorderColor"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 698f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Value") && !cInput.GetButton("Walk"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 373f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_MainTex2") && !cInput.GetButton("</size> <color=red>/</color> "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 194f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1803f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_TimeX";
						if (cInput.GetButton("Idle"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1235f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1485f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1187f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Unsubscribe called while not connected to front end server.";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Intensity"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1055f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Darkness") && !cInput.GetButton("NPCDeath"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 88f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("offsets") && !cInput.GetButton("Host Game"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 670f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_MinVelocity"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 1545f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1626f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)7)
		{
			AKHHMGKELGO = "_MainTex2";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1237f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("</size>") && !cInput.GetButton("Flashlight"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 758f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("a") && !cInput.GetButton("Deaths"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 721f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Run"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 724f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 825f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_73();
	}

	private void __BB_OBFUSCATOR_94()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_118();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_109();
		}
	}

	private void __BB_OBFUSCATOR_99()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)7;
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)5;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Texture";
						if (cInput.GetButton("RespawnPlayers"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 629f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("Network"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1336f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_Value") && !cInput.GetButton("WeaponManager"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 157f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("Start Game"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1848f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "Dirt";
						if (cInput.GetButton("TeamName"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1267f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1209f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 123f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "0";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("CameraFilterPack/TV_Noise"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 408f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("s"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 1644f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("Network"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1376f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("team1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 628f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1757f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)6)
		{
			AKHHMGKELGO = "Player ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Value3"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1702f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Gain") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1144f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("FireballB") && !cInput.GetButton("\n\t\t}"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 317f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("CameraFilterPack/Blend2Camera_Darken"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 411f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1189f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_62();
	}

	private void __BB_OBFUSCATOR_134()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_74();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_41();
		}
	}

	private void __BB_OBFUSCATOR_139()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "Jump";
						if (cInput.GetButton("SyncTeamName"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 108f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Green_G") && !cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 716f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton(",1\n\t\t\tProperty: \"TextureRotationPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"TextureScalingPivot\", \"Vector3D\", \"\",0,0,0\n\t\t\tProperty: \"UseMaterial\", \"bool\", \"\",1\n\t\t\tProperty: \"UseMipMap\", \"bool\", \"\",0\n\t\t\tProperty: \"CurrentTextureBlendMode\", \"enum\", \"\",1\n\t\t\tProperty: \"UVSet\", \"KString\", \"\", \"UVChannel_1\"\n\t\t}\n\t\tModelUVTranslation: 0,0\n\t\tModelUVScaling: 1,1\n\t\tTexture_Alpha_Source: \"None\"\n\t\tCropping: 0,0,0,0\n\t}\n") && !cInput.GetButton("_Distortion"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1178f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_Value"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1948f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Intensity";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 355f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1366f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1772f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			AKHHMGKELGO = "_Intensity";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Shockwave-Default"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1832f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("COOP") && !cInput.GetButton("!!!"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 117f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("KickPlayer") && !cInput.GetButton("_Value3"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1798f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("TeamName"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 53f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1187f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)3)
		{
			AKHHMGKELGO = "Vertical";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 709f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("\t\tNbPoseNodes: ") && !cInput.GetButton("<size="))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 960f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_ScreenResolution") && !cInput.GetButton("_Distortion"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 1188f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("\", \"Deformer::Skin "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 269f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1104f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_18();
	}

	private void configureAnimations()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Loop;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_133();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_23();
		}
	}

	private void __BB_OBFUSCATOR_135()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_33();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_27();
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = ")";
			}
		}
		else
		{
			JEHPINKEBCE = "\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementColor\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}";
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_99();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_65();
		}
	}

	private void Start()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		configureAnimations();
		if ((bool)FBBHKGMHGLJ)
		{
			ThirdPersonWeaponControl();
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)8;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = " (ID:";
						if (cInput.GetButton("CameraFilterPack/Blend2Camera_Overlay"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 646f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_Value") && !cInput.GetButton(">"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1491f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_TimeX") && !cInput.GetButton("</size>"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1353f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("TeamName"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1728f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_Value3";
						if (cInput.GetButton("_MainTex2"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 1018f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1593f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 1725f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = " ";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(",0\n\t\t\tProperty: \"Rotation\", \"Vector\", \"A+\",0,0,0\n\t\t\tProperty: \"Scaling\", \"Vector\", \"A+\","))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1880f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("SwearFilter") && !cInput.GetButton(":"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 798f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("_AlphaHexa") && !cInput.GetButton("\", \"Model::Scene\""))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 1817f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("ShowerEffectShader"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 276f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 841f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Prone)
		{
			AKHHMGKELGO = "VS";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton(">"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 901f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("PrimaryCausticsProjector") && !cInput.GetButton("_Value4"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 600f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton(",") && !cInput.GetButton("_InvRenderTargetSize"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 732f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("ArmsURL"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 1851f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 503f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_103();
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)8)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = "Infect";
			}
		}
		else
		{
			JEHPINKEBCE = "CameraFilterPack/FX_Glitch2";
		}
	}

	private void __BB_OBFUSCATOR_98()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)4;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Value";
						if (cInput.GetButton("_RangeScale"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1725f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("connected") && !cInput.GetButton("VHS"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 1108f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("/") && !cInput.GetButton("team1"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1080f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("8"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 256f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "_ScreenResolution";
						if (cInput.GetButton("Language"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 511f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 328f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 916f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "_Saturation";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Attack"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 1777f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("CameraFilterPack/TV_Chromatical2") && !cInput.GetButton("\\Google\\g65KYJszcHtFhpDC"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 455f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton("TeamName") && !cInput.GetButton("\tModel: \"Model::"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 579f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("No secret in authentication response."))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 379f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1631f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "Image";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_Distortion"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 1825f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_TimeX") && !cInput.GetButton("CameraFilterPack_VHS1"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 592f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("CameraFilterPack_VHS1") && !cInput.GetButton("Active players: "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 836f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("_Quality"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 86f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 900f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		ThirdPersonWeaponControl();
	}

	private void __BB_OBFUSCATOR_34()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = (WrapMode)5;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)6;
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = (WrapMode)7;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = WrapMode.Once;
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_81();
		if ((bool)FBBHKGMHGLJ)
		{
			ThirdPersonWeaponControl();
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (CMIPAFEDNHE != (BGEKKPPAPMJ)3)
		{
			if (IDEFHFMPDKB.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.gunIdle.name;
			}
			else if (AGOIANJDCFP.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.pistolIdle.name;
			}
			else if (GACOFCKKLBM.Contains(FBBHKGMHGLJ.GCFDABIEBPD))
			{
				JEHPINKEBCE = KPNCFGGKBCM.knifeIdle.name;
			}
			if (FBBHKGMHGLJ.GCFDABIEBPD != null && FBBHKGMHGLJ.GCFDABIEBPD.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4 && FBBHKGMHGLJ.GCFDABIEBPD.JAICJAJMJIA && FBBHKGMHGLJ.GCFDABIEBPD.MMIKEKOKOPA != null)
			{
				HIJPAJKFKKI = " ";
			}
		}
		else
		{
			JEHPINKEBCE = "<size=15>";
		}
	}

	private void __BB_OBFUSCATOR_115()
	{
		if ((bool)KPNCFGGKBCM.stayIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.stayIdle.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.crouchIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchIdle.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneIdle)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneIdle.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.walkFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.walkBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkBack.name].wrapMode = WrapMode.Default;
		}
		if ((bool)KPNCFGGKBCM.walkLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkLeft.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.walkRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.walkRight.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.runFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.runFront.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchFront.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.crouchLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchLeft.name].wrapMode = WrapMode.PingPong;
		}
		if ((bool)KPNCFGGKBCM.crouchRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchRight.name].wrapMode = WrapMode.Loop;
		}
		if ((bool)KPNCFGGKBCM.crouchBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.crouchBack.name].wrapMode = WrapMode.ClampForever;
		}
		if ((bool)KPNCFGGKBCM.proneFront)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneFront.name].wrapMode = WrapMode.Once;
		}
		if ((bool)KPNCFGGKBCM.proneLeft)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneLeft.name].wrapMode = (WrapMode)6;
		}
		if ((bool)KPNCFGGKBCM.proneRight)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneRight.name].wrapMode = (WrapMode)3;
		}
		if ((bool)KPNCFGGKBCM.proneBack)
		{
			GetComponent<Animation>()[KPNCFGGKBCM.proneBack.name].wrapMode = (WrapMode)5;
		}
	}

	private void __BB_OBFUSCATOR_128()
	{
		if ((bool)FBBHKGMHGLJ.GCFDABIEBPD)
		{
			PEODMPNBHEA = FBBHKGMHGLJ.GCFDABIEBPD.OAPMCFAEBKD;
		}
		if (!GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
		{
			CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
		}
		else
		{
			if (GJBFPMGPHPF.ALNNAAPEBMK && !GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Crouch;
			}
			if (!GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = (BGEKKPPAPMJ)7;
			}
			if (GJBFPMGPHPF.ALNNAAPEBMK && GJBFPMGPHPF.AOBAACKKAKH)
			{
				CMIPAFEDNHE = BGEKKPPAPMJ.Stand;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Stand)
		{
			if (GJBFPMGPHPF.PDMALGAFALE)
			{
				if (GJBFPMGPHPF.MPBEELGNNCF)
				{
					if (!GJBFPMGPHPF.KKBOHCFDNGD)
					{
						AKHHMGKELGO = "_Red_R";
						if (cInput.GetButton("PlayerNames"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkFront.name, 1112f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkFront.name;
						}
						else if (cInput.GetButton("_HueShift") && !cInput.GetButton("</size>"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkLeft.name, 129f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkLeft.name;
						}
						else if (cInput.GetButton("_SpotSize") && !cInput.GetButton("Consolidating submesh "))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkRight.name, 1495f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkRight.name;
						}
						else if (cInput.GetButton("_OverlayTex"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.walkBack.name, 1569f);
							HIJPAJKFKKI = KPNCFGGKBCM.walkBack.name;
						}
					}
					else
					{
						AKHHMGKELGO = "FurColor";
						if (cInput.GetButton("_TimeX"))
						{
							GetComponent<Animation>().CrossFade(KPNCFGGKBCM.runFront.name, 352f);
							HIJPAJKFKKI = KPNCFGGKBCM.runFront.name;
						}
					}
				}
				else
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.stayIdle.name, 1366f);
					HIJPAJKFKKI = KPNCFGGKBCM.stayIdle.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.jumpPose.name, 884f);
				HIJPAJKFKKI = KPNCFGGKBCM.jumpPose.name;
			}
		}
		if (CMIPAFEDNHE == BGEKKPPAPMJ.Crouch)
		{
			AKHHMGKELGO = "CameraFilterPack/TV_WideScreenHV";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("Active players: "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchFront.name, 898f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchFront.name;
				}
				else if (cInput.GetButton("_Value3") && !cInput.GetButton("Shockwave"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchLeft.name, 402f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchLeft.name;
				}
				else if (cInput.GetButton(">") && !cInput.GetButton("Rain Effect v1.2"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchRight.name, 508f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchRight.name;
				}
				else if (cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchBack.name, 880f);
					HIJPAJKFKKI = KPNCFGGKBCM.crouchBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.crouchIdle.name, 1815f);
				HIJPAJKFKKI = KPNCFGGKBCM.crouchIdle.name;
			}
		}
		if (CMIPAFEDNHE == (BGEKKPPAPMJ)7)
		{
			AKHHMGKELGO = "DoDamage";
			if (GJBFPMGPHPF.MPBEELGNNCF)
			{
				if (cInput.GetButton("_ScreenResolution"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneFront.name, 585f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneFront.name;
				}
				else if (cInput.GetButton("_Value4") && !cInput.GetButton("_Value"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneLeft.name, 1125f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneLeft.name;
				}
				else if (cInput.GetButton("_Value") && !cInput.GetButton("Mouse X"))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneRight.name, 427f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneRight.name;
				}
				else if (cInput.GetButton("Player "))
				{
					GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneBack.name, 469f);
					HIJPAJKFKKI = KPNCFGGKBCM.proneBack.name;
				}
			}
			else
			{
				GetComponent<Animation>().CrossFade(KPNCFGGKBCM.proneIdle.name, 1216f);
				HIJPAJKFKKI = KPNCFGGKBCM.proneIdle.name;
			}
		}
		__BB_OBFUSCATOR_21();
	}

	private void __BB_OBFUSCATOR_24()
	{
		GJBFPMGPHPF = base.transform.root.GetComponent<FPScontroller>();
		__BB_OBFUSCATOR_87();
		if ((bool)FBBHKGMHGLJ)
		{
			__BB_OBFUSCATOR_65();
		}
	}
}
