using UnityEngine;

public class WeaponSync_Catcher : MonoBehaviour
{
	private Transform DKIEPOJLABG;

	private WeaponScript BCGHCDKOGFJ;

	private PlayerNetworkController KBLHDNPEGPL;

	private void __BB_OBFUSCATOR_127()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Camera");
		}
	}

	public void __BB_OBFUSCATOR_70()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Player");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_33(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_33()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Change FX : Key Up / Down \nCurrent FX ");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_18(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("100");
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
	}

	private void __BB_OBFUSCATOR_110()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_FrustumCornersWS");
		}
	}

	public void __BB_OBFUSCATOR_59()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Network");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	public void __BB_OBFUSCATOR_22()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_AxialAberration");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_63()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Mouse X");
		}
	}

	public void __BB_OBFUSCATOR_49()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Next");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_71()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("GenEffect");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_Offsets");
		}
	}

	public void __BB_OBFUSCATOR_13()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("VS");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_33(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_106()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Result");
		}
	}

	public void __BB_OBFUSCATOR_98()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	public void Fire()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("WeaponScript.js should be attached to same gameObject");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	public void __BB_OBFUSCATOR_47()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Network");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_28(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_84()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Label");
		}
	}

	private void __BB_OBFUSCATOR_67()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Player");
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("MP");
		}
	}

	public void __BB_OBFUSCATOR_73()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("team1");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Checker");
		}
	}

	public void __BB_OBFUSCATOR_61()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("ServerID");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_90()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Tenkoku DynamicSky");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	public void __BB_OBFUSCATOR_120()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("</size>");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_122()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TopMainTex");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_20(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	public void __BB_OBFUSCATOR_27()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("stretchWidth");
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Quit");
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("State2");
		}
	}

	public void __BB_OBFUSCATOR_31()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("TeamName");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_33(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	private void Awake()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("WeaponScript.js should be attached to same gameObject");
		}
	}

	private void __BB_OBFUSCATOR_117()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_Value");
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_Value2");
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_BlurRadius4");
		}
	}

	public void __BB_OBFUSCATOR_102()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError(" x ");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_RgbTex");
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_Value4");
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Language");
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_VelTex");
		}
	}

	private void __BB_OBFUSCATOR_130()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError(" ");
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("RefTime");
		}
	}

	private void __BB_OBFUSCATOR_51()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
	}

	public void __BB_OBFUSCATOR_65()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Newborn_Bot");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_28(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("HeadlessRuntime");
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("custard");
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Sparks");
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Network");
		}
	}

	public void __BB_OBFUSCATOR_66()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_MainTex2");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_20(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_121()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_ScreenResolution");
		}
	}

	public void __BB_OBFUSCATOR_115()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Vertical");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("TakeIn");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_Value5");
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("The shader ");
		}
	}

	public void __BB_OBFUSCATOR_87()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("CameraFilterPack/Distortion_Wave_Horizontal");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_18(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_20(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("WeaponManager");
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Deaths");
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
	}

	public void __BB_OBFUSCATOR_97()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("CameraFilterPack/AAA_Super_Hexagon");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_18(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_33(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Room Name");
		}
	}

	public void __BB_OBFUSCATOR_48()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Join");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Hacker");
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Weapon_Idle");
		}
	}

	public void __BB_OBFUSCATOR_38()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_ScreenResolution");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_68()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Infect");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_28(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Kills");
		}
	}

	public void __BB_OBFUSCATOR_83()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("SaturationValue");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Run");
		}
	}

	private void __BB_OBFUSCATOR_123()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("HatList");
		}
	}

	public void __BB_OBFUSCATOR_78()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("\", \"Model::");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	public void __BB_OBFUSCATOR_74()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("__Room");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_20(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_52()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_ScreenResolution");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	public void __BB_OBFUSCATOR_8()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Connect");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_4(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncShotGun(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncGrenadeLauncher(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("CameraFilterPack/Color_YUV");
		}
	}

	private void __BB_OBFUSCATOR_105()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_Divide");
		}
	}

	public void __BB_OBFUSCATOR_25()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Prev");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("\n\t\tLayerElementMaterial: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tMaterials: ");
		}
	}

	private void __BB_OBFUSCATOR_124()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("|");
		}
	}

	public void __BB_OBFUSCATOR_44()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.syncMachineGun(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)5)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_11(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)8)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		BCGHCDKOGFJ = base.gameObject.GetComponent<WeaponScript>();
		DKIEPOJLABG = base.transform.root;
		KBLHDNPEGPL = DKIEPOJLABG.GetComponent<PlayerNetworkController>();
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError(",");
		}
	}

	public void __BB_OBFUSCATOR_55()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("</size>");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_26(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_20(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_6();
		}
	}

	public void __BB_OBFUSCATOR_37()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("_TimeX");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_13(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)7)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_17(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_23(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE)
		{
			KBLHDNPEGPL.syncKnife();
		}
	}

	public void __BB_OBFUSCATOR_111()
	{
		if (!BCGHCDKOGFJ)
		{
			Debug.LogError("Floor");
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_28(BCGHCDKOGFJ.BHFPHOBDOCN);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_22(BCGHCDKOGFJ.KFEJPOEHNOA.fractions);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_7(BCGHCDKOGFJ.FAJAKOCNMGL.initialSpeed);
		}
		if (BCGHCDKOGFJ.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)4)
		{
			KBLHDNPEGPL.__BB_OBFUSCATOR_34();
		}
	}
}
