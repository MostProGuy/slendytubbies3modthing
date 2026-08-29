using System;
using System.Collections;
using CodeStage.AntiCheat.ObscuredTypes;
using InControl.mod;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WeaponScript : MonoBehaviour
{
	public enum BNILOGDCIEG
	{
		MACHINE_GUN = 0,
		GRENADE_LAUNCHER = 1,
		SHOTGUN = 2,
		KNIFE = 3
	}

	[Serializable]
	public class AimVariables
	{
		public Vector3 aimPosition = Vector3.zero;

		public float smoothTime = 5f;

		public int toFov = 45;

		public float aimBobbingAmount;

		public bool playAnimation;
	}

	[Serializable]
	public class shotGun
	{
		public Transform bullet;

		public int fractions = 5;

		public float errorAngle = 3f;

		public float fireRate = 1f;

		public float reloadTime = 2f;

		public AudioClip fireSound;

		public AudioClip reloadSound;

		public ObscuredInt bulletsPerClip = 40;

		public ObscuredInt bulletsLeft;

		public int clips = 15;

		public ObscuredInt patchedClips;

		public ParticleEmitter smoke;
	}

	[Serializable]
	public class GrenadeLauncher
	{
		public Rigidbody projectile;

		public AudioClip fireSound;

		public AudioClip reloadSound;

		public int initialSpeed = 20;

		public float shotDelay;

		public float waitBeforeReload = 0.5f;

		public float reloadTime = 0.5f;

		public int ammoCount = 20;
	}

	[Serializable]
	public class MachineGun
	{
		public Transform bullet;

		public GameObject muzzleFlash;

		public AudioClip fireSound;

		public AudioClip reloadSound;

		public Light pointLight;

		public float fireRate = 0.05f;

		public ObscuredInt bulletsPerClip = 40;

		public int clips = 15;

		public ObscuredInt patchedClips;

		public ObscuredInt bulletsLeft;

		public float reloadTime = 1f;

		public float NoAimErrorAngle = 3f;

		public float AimErrorAngle;
	}

	[Serializable]
	public class Knife
	{
		public Transform bullet;

		public AudioClip fireSound;

		public float fireRate = 0.5f;

		public float delayTime;
	}

	[Serializable]
	public class RotationReal
	{
		public int RotationAmplitude = 2;

		public int smooth = 7;
	}

	[Serializable]
	public class SmoothMov
	{
		public float maxAmount = 0.5f;

		public int Smooth = 3;
	}

	[Serializable]
	public class cameraRecoil
	{
		public float recoilPower = 0.5f;

		public float shakeAmount = 6f;

		public int smooth = 3;
	}

	public Texture2D MMIKEKOKOPA;

	public Texture2D DOAAHNIKDDN;

	public bool HAJOPKELMEB;

	[HideInInspector]
	public bool DMCAELEFJFD;

	[HideInInspector]
	public bool OCKKJJLFBPC;

	[HideInInspector]
	public bool NOKLEPHMCJO;

	[HideInInspector]
	public bool ABCKOODMGBE;

	[HideInInspector]
	public bool PLIOKPDLDPI;

	[HideInInspector]
	public bool JCMFPCADILO;

	[HideInInspector]
	public bool OJMPENKKGPJ;

	[HideInInspector]
	public bool GOJHNNDJMFJ;

	private FPScontroller CJFDABKPMND;

	private GameObject HKOIJFEMIMB;

	private CharacterController OJNKMBPLGJI;

	private FPSMouseLook FIEOHPDPMKL;

	private WalkSway KNKNFEJHHBB;

	private float LHAHKKPAPGH;

	private GameObject BAIJKILJPDL;

	public ObscuredInt ELNOFDELCBH;

	public BNILOGDCIEG HKJBFLNEGCH;

	public bool BFPDADLBNLH;

	public string OAPMCFAEBKD = string.Empty;

	public AimVariables GIAILINMPIG;

	private float EDIBGJHPOLD;

	private Vector3 FOAJFALEKJD;

	private float LKIBOKENDLG;

	private Vector3 KEHNHHBGBKP;

	public Transform KFALIPMFJEO;

	public shotGun KFEJPOEHNOA;

	public GrenadeLauncher FAJAKOCNMGL;

	private float HBGPOFNINHD = -10f;

	public MachineGun CDINEHMLEBM;

	[HideInInspector]
	public float BHFPHOBDOCN;

	private float GLECANKJDEB;

	public Knife PMJAHJCIGPF;

	public RotationReal ICBDPGIFMLM;

	private float ADDPLKBBMKE;

	private float KAJJBIGMCFD;

	public SmoothMov LCMIJDPCOGN;

	private Vector3 LBOHNOPIKLI;

	public cameraRecoil JODOFANGJIE;

	private Quaternion MEHHMEOKNOM;

	private Quaternion MADPBACAPKA;

	private WeaponAnimation BANOGNPHFMI;

	private SniperAnimation GGCHHCHAFPB;

	private Transform PAOALFIOFDK;

	private WeaponSync_Catcher DMIPKMBAFKP;

	public bool BBEAFEEBHJJ;

	public Transform HMBJBCLCDAI;

	public bool JAICJAJMJIA;

	private void machineGunFixedUpdate()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			machineGunFire();
		}
		else
		{
			machineGunStopFire();
			if ((bool)CDINEHMLEBM.muzzleFlash)
			{
				CDINEHMLEBM.muzzleFlash.SetActive(false);
			}
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_19()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if ((int)KFEJPOEHNOA.bulletsLeft != 0)
		{
			if (Time.time - KFEJPOEHNOA.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)KFEJPOEHNOA.bulletsLeft != 0)
			{
				StartCoroutine(shotGunOneShot());
				GLECANKJDEB += KFEJPOEHNOA.fireRate;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_66()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private IEnumerator __BB_OBFUSCATOR_59()
	{
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.transform.localRotation = Quaternion.AngleAxis(UnityEngine.Random.Range(0, 359), Vector3.left);
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = true;
		}
		yield return new WaitForSeconds(0.04f);
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(false);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = false;
		}
	}

	private void shotGunStopFire()
	{
		CJFDABKPMND.CLFJBIPJCAL = true;
	}

	private void deselectWeapon()
	{
		DMCAELEFJFD = false;
		ABCKOODMGBE = false;
		OJMPENKKGPJ = false;
		NOKLEPHMCJO = false;
		ABCKOODMGBE = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.takeOut();
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.takeOut();
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			__BB_OBFUSCATOR_87();
		}
		else
		{
			shotGunStopFire();
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_0()
	{
		if (!KFEJPOEHNOA.smoke)
		{
			yield return null;
		}
		KFEJPOEHNOA.smoke.emit = true;
		yield return new WaitForSeconds(0.3f);
		KFEJPOEHNOA.smoke.emit = false;
	}

	private void machineGunFire()
	{
		if ((int)CDINEHMLEBM.bulletsLeft != 0 && !CJFDABKPMND.KKBOHCFDNGD)
		{
			if (Time.time - CDINEHMLEBM.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)CDINEHMLEBM.bulletsLeft != 0)
			{
				StartCoroutine(machineGunOneShot());
				GLECANKJDEB += CDINEHMLEBM.fireRate;
			}
		}
	}

	private void shotGunAwake()
	{
		KFEJPOEHNOA.bulletsLeft = KFEJPOEHNOA.bulletsPerClip;
		if ((bool)KFEJPOEHNOA.smoke)
		{
			KFEJPOEHNOA.smoke.emit = false;
		}
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = true;
	}

	private IEnumerator __BB_OBFUSCATOR_28()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if ((int)KFEJPOEHNOA.bulletsLeft != 0)
		{
			if (Time.time - KFEJPOEHNOA.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)KFEJPOEHNOA.bulletsLeft != 0)
			{
				StartCoroutine(__BB_OBFUSCATOR_89());
				GLECANKJDEB += KFEJPOEHNOA.fireRate;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_4()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void SmoothMove()
	{
		float y = OJNKMBPLGJI.velocity.y;
		float num = 0f;
		float num2 = 0f - cInput.GetAxis("Vertical");
		if (y > LCMIJDPCOGN.maxAmount + 1f)
		{
			num = 0f - LCMIJDPCOGN.maxAmount;
		}
		if (y < 0f - LCMIJDPCOGN.maxAmount - 1f)
		{
			num = LCMIJDPCOGN.maxAmount;
		}
		if (num2 > LCMIJDPCOGN.maxAmount)
		{
			num2 = LCMIJDPCOGN.maxAmount;
		}
		if (num2 < 0f - LCMIJDPCOGN.maxAmount)
		{
			num2 = 0f - LCMIJDPCOGN.maxAmount;
		}
		Vector3 b = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y + num, base.transform.localPosition.z + num2);
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * (float)LCMIJDPCOGN.Smooth);
	}

	private IEnumerator __BB_OBFUSCATOR_2()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_70()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			__BB_OBFUSCATOR_62();
		}
		else
		{
			__BB_OBFUSCATOR_67();
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = true;
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = false;
	}

	private void __BB_OBFUSCATOR_78()
	{
		float axis = cInput.GetAxis("</size>", 572f);
		float axis2 = cInput.GetAxis("Language", 1016f);
		float y = 1591f;
		float x = 1751f;
		if (Mathf.Abs(axis) > 819f)
		{
			if (axis < 882f)
			{
				y = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis);
			}
			else if (axis > 1529f)
			{
				y = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis);
			}
		}
		else
		{
			y = 1328f;
		}
		if (Mathf.Abs(axis2) > 1447f)
		{
			if (axis2 < 76f)
			{
				x = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis2);
			}
			else if ((double)axis2 > 109.0)
			{
				x = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis2);
			}
		}
		else
		{
			x = 1717f;
		}
		Quaternion b = Quaternion.Euler(x, y, 1075f);
		base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, b, Time.deltaTime * (float)ICBDPGIFMLM.smooth);
	}

	private void __BB_OBFUSCATOR_24()
	{
		CDINEHMLEBM.bulletsLeft = CDINEHMLEBM.bulletsPerClip;
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = false;
	}

	private void Update()
	{
		if (!(Time.timeScale < 0.01f))
		{
			Aiming();
			RotationRealism();
			SmoothMove();
			if (JCMFPCADILO)
			{
				cameraRecoilDo();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
			{
				machineGunFixedUpdate();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
			{
				grenadeLauncherFixedUpdate();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN)
			{
				shotGunFixedUpdate();
			}
			if (CJFDABKPMND.KKBOHCFDNGD && !BBEAFEEBHJJ)
			{
				DMCAELEFJFD = false;
			}
			if (!ObscuredPrefs.GetBool("Shop") && !CJFDABKPMND.KKBOHCFDNGD && GameObject.FindWithTag("Menu") == null)
			{
				InputUpdate();
			}
		}
	}

	private void Start()
	{
		KNKNFEJHHBB = base.transform.root.GetComponentInChildren<WalkSway>();
		LHAHKKPAPGH = KNKNFEJHHBB.DNABPIICJEG;
		MEHHMEOKNOM = Camera.main.transform.localRotation;
		EDIBGJHPOLD = Camera.main.fieldOfView;
		FOAJFALEKJD = base.transform.localPosition;
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			machineGunAwake();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			grenadeLauncherAwake();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN)
		{
			shotGunAwake();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE)
		{
			knifeAwake();
		}
		PAOALFIOFDK = Camera.main.transform;
	}

	private void __BB_OBFUSCATOR_13()
	{
		KNKNFEJHHBB = base.transform.root.GetComponentInChildren<WalkSway>();
		LHAHKKPAPGH = KNKNFEJHHBB.DNABPIICJEG;
		MEHHMEOKNOM = Camera.main.transform.localRotation;
		EDIBGJHPOLD = Camera.main.fieldOfView;
		FOAJFALEKJD = base.transform.localPosition;
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			__BB_OBFUSCATOR_80();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			grenadeLauncherAwake();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)5)
		{
			__BB_OBFUSCATOR_72();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			knifeAwake();
		}
		PAOALFIOFDK = Camera.main.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_39()
	{
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.transform.localRotation = Quaternion.AngleAxis(UnityEngine.Random.Range(0, 359), Vector3.left);
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = true;
		}
		yield return new WaitForSeconds(0.04f);
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(false);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		CDINEHMLEBM.bulletsLeft = CDINEHMLEBM.bulletsPerClip;
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = false;
	}

	private void __BB_OBFUSCATOR_20()
	{
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = false;
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (cInput.GetButtonDown("CameraFilterPack/TV_VHS") && NOKLEPHMCJO && !CJFDABKPMND.KKBOHCFDNGD)
		{
			DMCAELEFJFD = DMCAELEFJFD;
		}
		if (cInput.GetButton("MP") && OJMPENKKGPJ && !GOJHNNDJMFJ)
		{
			OCKKJJLFBPC = false;
		}
		else
		{
			OCKKJJLFBPC = false;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			if (cInput.GetButtonDown("offsets") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
			{
				machineGunFire();
			}
			else
			{
				machineGunStopFire();
			}
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER && cInput.GetButtonDown("_Value3") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			__BB_OBFUSCATOR_79();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)7 && cInput.GetButtonDown("_ScreenResolution") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			__BB_OBFUSCATOR_87();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)5 && cInput.GetButtonDown("Camera") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			StartCoroutine(__BB_OBFUSCATOR_37());
		}
		if (cInput.GetButtonDown("CameraFilterPack/Light_Water") && !ABCKOODMGBE && ((int)CDINEHMLEBM.patchedClips > 1 || (int)KFEJPOEHNOA.patchedClips > 1))
		{
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && (int)CDINEHMLEBM.bulletsLeft != (int)CDINEHMLEBM.bulletsPerClip)
			{
				StartCoroutine(machineGunReload());
			}
			if (HKJBFLNEGCH == (BNILOGDCIEG)4 && (int)KFEJPOEHNOA.bulletsLeft != (int)KFEJPOEHNOA.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_82());
			}
		}
	}

	private void shotGunFire()
	{
		if ((int)KFEJPOEHNOA.bulletsLeft != 0)
		{
			if (Time.time - KFEJPOEHNOA.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)KFEJPOEHNOA.bulletsLeft != 0)
			{
				StartCoroutine(shotGunOneShot());
				GLECANKJDEB += KFEJPOEHNOA.fireRate;
			}
		}
	}

	private IEnumerator shotGunReload()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(KFEJPOEHNOA.reloadTime);
		}
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(KFEJPOEHNOA.reloadTime);
		if ((int)KFEJPOEHNOA.patchedClips > 0)
		{
			int num = (int)KFEJPOEHNOA.bulletsPerClip - (int)KFEJPOEHNOA.bulletsLeft;
			if ((int)KFEJPOEHNOA.patchedClips > num)
			{
				KFEJPOEHNOA.patchedClips = (int)KFEJPOEHNOA.patchedClips - num;
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + num;
			}
			else
			{
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + (int)KFEJPOEHNOA.patchedClips;
				KFEJPOEHNOA.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		CJFDABKPMND.CLFJBIPJCAL = false;
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (cInput.GetButtonDown("_ScreenResolution") && NOKLEPHMCJO && !CJFDABKPMND.KKBOHCFDNGD)
		{
			DMCAELEFJFD = !DMCAELEFJFD;
		}
		if (cInput.GetButton("CameraFilterPack/Special_Bubble") && OJMPENKKGPJ && !GOJHNNDJMFJ)
		{
			OCKKJJLFBPC = false;
		}
		else
		{
			OCKKJJLFBPC = false;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			if (cInput.GetButtonDown("offsets") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
			{
				__BB_OBFUSCATOR_30();
			}
			else
			{
				__BB_OBFUSCATOR_44();
			}
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER && cInput.GetButtonDown("Subscribe can't be called for empty or null channels-list.") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			grenadeLauncherFIre();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE && cInput.GetButtonDown("_TimeX") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			shotGunFire();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)6 && cInput.GetButtonDown("While selected STW-25 press G for flashlight") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			StartCoroutine(__BB_OBFUSCATOR_2());
		}
		if (cInput.GetButtonDown("Connect") && !ABCKOODMGBE && ((int)CDINEHMLEBM.patchedClips > 1 || (int)KFEJPOEHNOA.patchedClips > 0))
		{
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && (int)CDINEHMLEBM.bulletsLeft != (int)CDINEHMLEBM.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_73());
			}
			if (HKJBFLNEGCH == (BNILOGDCIEG)5 && (int)KFEJPOEHNOA.bulletsLeft != (int)KFEJPOEHNOA.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_82());
			}
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		KNKNFEJHHBB = base.transform.root.GetComponentInChildren<WalkSway>();
		LHAHKKPAPGH = KNKNFEJHHBB.DNABPIICJEG;
		MEHHMEOKNOM = Camera.main.transform.localRotation;
		EDIBGJHPOLD = Camera.main.fieldOfView;
		FOAJFALEKJD = base.transform.localPosition;
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			__BB_OBFUSCATOR_24();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			__BB_OBFUSCATOR_74();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)4)
		{
			__BB_OBFUSCATOR_91();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE)
		{
			__BB_OBFUSCATOR_20();
		}
		PAOALFIOFDK = Camera.main.transform;
	}

	private void __BB_OBFUSCATOR_44()
	{
		CJFDABKPMND.CLFJBIPJCAL = false;
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (cInput.GetButtonDown("_Tint") && NOKLEPHMCJO && !CJFDABKPMND.KKBOHCFDNGD)
		{
			DMCAELEFJFD = DMCAELEFJFD;
		}
		if (cInput.GetButton("_Green_C") && OJMPENKKGPJ && !GOJHNNDJMFJ)
		{
			OCKKJJLFBPC = false;
		}
		else
		{
			OCKKJJLFBPC = true;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			if (cInput.GetButtonDown("Walk") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
			{
				__BB_OBFUSCATOR_30();
			}
			else
			{
				__BB_OBFUSCATOR_9();
			}
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && cInput.GetButtonDown("Concrete") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			__BB_OBFUSCATOR_48();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)8 && cInput.GetButtonDown("SupplyHelicopter") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			__BB_OBFUSCATOR_34();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)5 && cInput.GetButtonDown("<size=25><color=#b50000>") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			StartCoroutine(__BB_OBFUSCATOR_37());
		}
		if (cInput.GetButtonDown("Click on the ground to spawn the selected effect") && !ABCKOODMGBE && ((int)CDINEHMLEBM.patchedClips > 1 || (int)KFEJPOEHNOA.patchedClips > 1))
		{
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && (int)CDINEHMLEBM.bulletsLeft != (int)CDINEHMLEBM.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_73());
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN && (int)KFEJPOEHNOA.bulletsLeft != (int)KFEJPOEHNOA.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_82());
			}
		}
	}

	private void selectWeapon()
	{
		OJMPENKKGPJ = true;
		if (HKJBFLNEGCH != BNILOGDCIEG.KNIFE)
		{
			NOKLEPHMCJO = true;
		}
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.takeIn();
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.takeIn();
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 0)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_89()
	{
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		Quaternion rotation = KFALIPMFJEO.rotation;
		for (int i = 0; i < KFEJPOEHNOA.fractions; i++)
		{
			KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * KFEJPOEHNOA.errorAngle) * base.transform.rotation;
			Transform transform = UnityEngine.Object.Instantiate(KFEJPOEHNOA.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if ((bool)transform)
			{
				transform.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
		}
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.fireSound;
		GetComponent<AudioSource>().Play();
		--KFEJPOEHNOA.bulletsLeft;
		if (DMCAELEFJFD && GIAILINMPIG.playAnimation && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if (!DMCAELEFJFD && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		StartCoroutine(shotGunSmokeEffect());
		if (JCMFPCADILO)
		{
			StartCoroutine(shotGunCameraRecoil());
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
		}
		HMBJBCLCDAI = KFEJPOEHNOA.bullet;
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)KFEJPOEHNOA.patchedClips > 0 && (int)KFEJPOEHNOA.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(shotGunReload());
			}
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		if ((int)CDINEHMLEBM.bulletsLeft != 0 && !CJFDABKPMND.KKBOHCFDNGD)
		{
			if (Time.time - CDINEHMLEBM.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)CDINEHMLEBM.bulletsLeft != 0)
			{
				StartCoroutine(machineGunOneShot());
				GLECANKJDEB += CDINEHMLEBM.fireRate;
			}
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		float y = OJNKMBPLGJI.velocity.y;
		float num = 36f;
		float num2 = 0f - cInput.GetAxis("_Value2", 1178f);
		if (y > LCMIJDPCOGN.maxAmount + 1868f)
		{
			num = 0f - LCMIJDPCOGN.maxAmount;
		}
		if (y < 0f - LCMIJDPCOGN.maxAmount - 190f)
		{
			num = LCMIJDPCOGN.maxAmount;
		}
		if (num2 > LCMIJDPCOGN.maxAmount)
		{
			num2 = LCMIJDPCOGN.maxAmount;
		}
		if (num2 < 0f - LCMIJDPCOGN.maxAmount)
		{
			num2 = 0f - LCMIJDPCOGN.maxAmount;
		}
		Vector3 b = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y + num, base.transform.localPosition.z + num2);
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * (float)LCMIJDPCOGN.Smooth);
	}

	private void __BB_OBFUSCATOR_7()
	{
		CJFDABKPMND.CLFJBIPJCAL = true;
	}

	private IEnumerator __BB_OBFUSCATOR_32()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private IEnumerator __BB_OBFUSCATOR_88()
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation;
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		HMBJBCLCDAI = UnityEngine.Object.Instantiate(CDINEHMLEBM.bullet, KFALIPMFJEO.position, Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation);
		HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		--CDINEHMLEBM.bulletsLeft;
		GetComponent<AudioSource>().clip = CDINEHMLEBM.fireSound;
		GetComponent<AudioSource>().Play();
		StartCoroutine(machineGunMuzzleFlash());
		if (DMCAELEFJFD)
		{
			if (GIAILINMPIG.playAnimation)
			{
				if ((bool)BANOGNPHFMI)
				{
					BANOGNPHFMI.Fire();
				}
				if ((bool)GGCHHCHAFPB)
				{
					GGCHHCHAFPB.Fire();
				}
			}
		}
		else
		{
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)GGCHHCHAFPB)
			{
				GGCHHCHAFPB.Fire();
			}
		}
		if (JCMFPCADILO)
		{
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
			StartCoroutine(machineGunCameraRecoil());
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)CDINEHMLEBM.patchedClips > 0 && (int)CDINEHMLEBM.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(machineGunReload());
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_57()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private void __BB_OBFUSCATOR_63()
	{
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = true;
	}

	private void __BB_OBFUSCATOR_40()
	{
		float axis = cInput.GetAxis("GameMode", 825f);
		float axis2 = cInput.GetAxis("SecondaryCausticsProjector", 1720f);
		float y = 1709f;
		float x = 1841f;
		if (Mathf.Abs(axis) > 1166f)
		{
			if (axis < 431f)
			{
				y = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis);
			}
			else if (axis > 704f)
			{
				y = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis);
			}
		}
		else
		{
			y = 1612f;
		}
		if (Mathf.Abs(axis2) > 1362f)
		{
			if (axis2 < 953f)
			{
				x = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis2);
			}
			else if ((double)axis2 > 575.0)
			{
				x = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis2);
			}
		}
		else
		{
			x = 1086f;
		}
		Quaternion b = Quaternion.Euler(x, y, 31f);
		base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, b, Time.deltaTime * (float)ICBDPGIFMLM.smooth);
	}

	private IEnumerator shotGunOneShot()
	{
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		Quaternion rotation = KFALIPMFJEO.rotation;
		for (int i = 0; i < KFEJPOEHNOA.fractions; i++)
		{
			KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * KFEJPOEHNOA.errorAngle) * base.transform.rotation;
			Transform transform = UnityEngine.Object.Instantiate(KFEJPOEHNOA.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if ((bool)transform)
			{
				transform.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
		}
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.fireSound;
		GetComponent<AudioSource>().Play();
		--KFEJPOEHNOA.bulletsLeft;
		if (DMCAELEFJFD && GIAILINMPIG.playAnimation && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if (!DMCAELEFJFD && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		StartCoroutine(shotGunSmokeEffect());
		if (JCMFPCADILO)
		{
			StartCoroutine(shotGunCameraRecoil());
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
		}
		HMBJBCLCDAI = KFEJPOEHNOA.bullet;
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)KFEJPOEHNOA.patchedClips > 0 && (int)KFEJPOEHNOA.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(shotGunReload());
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 1)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_81()
	{
		if (!KFEJPOEHNOA.smoke)
		{
			yield return null;
		}
		KFEJPOEHNOA.smoke.emit = true;
		yield return new WaitForSeconds(0.3f);
		KFEJPOEHNOA.smoke.emit = false;
	}

	private void __BB_OBFUSCATOR_62()
	{
		if ((int)KFEJPOEHNOA.bulletsLeft != 0)
		{
			if (Time.time - KFEJPOEHNOA.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)KFEJPOEHNOA.bulletsLeft != 0)
			{
				StartCoroutine(shotGunOneShot());
				GLECANKJDEB += KFEJPOEHNOA.fireRate;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_47()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (!(Time.timeScale < 1535f))
		{
			Aiming();
			__BB_OBFUSCATOR_71();
			__BB_OBFUSCATOR_77();
			if (JCMFPCADILO)
			{
				cameraRecoilDo();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
			{
				machineGunFixedUpdate();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
			{
				grenadeLauncherFixedUpdate();
			}
			if (HKJBFLNEGCH == (BNILOGDCIEG)4)
			{
				__BB_OBFUSCATOR_61();
			}
			if (CJFDABKPMND.KKBOHCFDNGD && !BBEAFEEBHJJ)
			{
				DMCAELEFJFD = true;
			}
			if (!ObscuredPrefs.GetBool("Paused") && !CJFDABKPMND.KKBOHCFDNGD && GameObject.FindWithTag("_Value") == null)
			{
				__BB_OBFUSCATOR_5();
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		CJFDABKPMND.CLFJBIPJCAL = false;
	}

	private void __BB_OBFUSCATOR_71()
	{
		float axis = cInput.GetAxis("_TimeX", 1026f);
		float axis2 = cInput.GetAxis("MP", 561f);
		float y = 13f;
		float x = 1353f;
		if (Mathf.Abs(axis) > 795f)
		{
			if (axis < 640f)
			{
				y = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis);
			}
			else if (axis > 1667f)
			{
				y = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis);
			}
		}
		else
		{
			y = 419f;
		}
		if (Mathf.Abs(axis2) > 1925f)
		{
			if (axis2 < 737f)
			{
				x = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis2);
			}
			else if ((double)axis2 > 337.0)
			{
				x = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis2);
			}
		}
		else
		{
			x = 1606f;
		}
		Quaternion b = Quaternion.Euler(x, y, 607f);
		base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, b, Time.deltaTime * (float)ICBDPGIFMLM.smooth);
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 0)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (DMCAELEFJFD && (!CJFDABKPMND.KKBOHCFDNGD || BBEAFEEBHJJ))
		{
			KEHNHHBGBKP = GIAILINMPIG.aimPosition;
			LKIBOKENDLG = GIAILINMPIG.toFov;
			BHFPHOBDOCN = CDINEHMLEBM.AimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = GIAILINMPIG.aimBobbingAmount;
		}
		else
		{
			KEHNHHBGBKP = FOAJFALEKJD;
			LKIBOKENDLG = EDIBGJHPOLD;
			BHFPHOBDOCN = CDINEHMLEBM.NoAimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = LHAHKKPAPGH;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, KEHNHHBGBKP, Time.deltaTime / GIAILINMPIG.smoothTime);
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, LKIBOKENDLG, Time.deltaTime / GIAILINMPIG.smoothTime);
	}

	private void OnDisable()
	{
		JAICJAJMJIA = false;
	}

	private void __BB_OBFUSCATOR_27()
	{
		CDINEHMLEBM.bulletsLeft = CDINEHMLEBM.bulletsPerClip;
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = false;
	}

	private IEnumerator __BB_OBFUSCATOR_10()
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation;
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		HMBJBCLCDAI = UnityEngine.Object.Instantiate(CDINEHMLEBM.bullet, KFALIPMFJEO.position, Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation);
		HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		--CDINEHMLEBM.bulletsLeft;
		GetComponent<AudioSource>().clip = CDINEHMLEBM.fireSound;
		GetComponent<AudioSource>().Play();
		StartCoroutine(machineGunMuzzleFlash());
		if (DMCAELEFJFD)
		{
			if (GIAILINMPIG.playAnimation)
			{
				if ((bool)BANOGNPHFMI)
				{
					BANOGNPHFMI.Fire();
				}
				if ((bool)GGCHHCHAFPB)
				{
					GGCHHCHAFPB.Fire();
				}
			}
		}
		else
		{
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)GGCHHCHAFPB)
			{
				GGCHHCHAFPB.Fire();
			}
		}
		if (JCMFPCADILO)
		{
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
			StartCoroutine(machineGunCameraRecoil());
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)CDINEHMLEBM.patchedClips > 0 && (int)CDINEHMLEBM.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(machineGunReload());
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		KNKNFEJHHBB = base.transform.root.GetComponentInChildren<WalkSway>();
		LHAHKKPAPGH = KNKNFEJHHBB.DNABPIICJEG;
		MEHHMEOKNOM = Camera.main.transform.localRotation;
		EDIBGJHPOLD = Camera.main.fieldOfView;
		FOAJFALEKJD = base.transform.localPosition;
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			__BB_OBFUSCATOR_24();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			grenadeLauncherAwake();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)4)
		{
			__BB_OBFUSCATOR_72();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)4)
		{
			__BB_OBFUSCATOR_20();
		}
		PAOALFIOFDK = Camera.main.transform;
	}

	private void __BB_OBFUSCATOR_67()
	{
		CJFDABKPMND.CLFJBIPJCAL = false;
	}

	private void __BB_OBFUSCATOR_84()
	{
		float y = OJNKMBPLGJI.velocity.y;
		float num = 1390f;
		float num2 = 0f - cInput.GetAxis("survivors win", 1819f);
		if (y > LCMIJDPCOGN.maxAmount + 1536f)
		{
			num = 0f - LCMIJDPCOGN.maxAmount;
		}
		if (y < 0f - LCMIJDPCOGN.maxAmount - 610f)
		{
			num = LCMIJDPCOGN.maxAmount;
		}
		if (num2 > LCMIJDPCOGN.maxAmount)
		{
			num2 = LCMIJDPCOGN.maxAmount;
		}
		if (num2 < 0f - LCMIJDPCOGN.maxAmount)
		{
			num2 = 0f - LCMIJDPCOGN.maxAmount;
		}
		Vector3 b = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y + num, base.transform.localPosition.z + num2);
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * (float)LCMIJDPCOGN.Smooth);
	}

	private IEnumerator grenadeLauncherCameraRecoil()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private void __BB_OBFUSCATOR_52()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		OJNKMBPLGJI = HKOIJFEMIMB.GetComponent<CharacterController>();
		FPSMouseLook[] componentsInChildren = base.transform.root.GetComponentsInChildren<FPSMouseLook>();
		FPSMouseLook[] array = componentsInChildren;
		foreach (FPSMouseLook fPSMouseLook in array)
		{
			if (fPSMouseLook.ONGNICDKGDF == FPSMouseLook.LCBGHDDCHFJ.MouseXAndY)
			{
				FIEOHPDPMKL = fPSMouseLook;
			}
		}
		if (base.gameObject.GetComponentInChildren<WeaponAnimation>() != null)
		{
			BANOGNPHFMI = base.gameObject.GetComponentInChildren<WeaponAnimation>();
		}
		else if (base.gameObject.GetComponentInChildren<SniperAnimation>() != null)
		{
			GGCHHCHAFPB = base.gameObject.GetComponentInChildren<SniperAnimation>();
		}
		if (base.gameObject.GetComponent<WeaponSync_Catcher>() != null)
		{
			DMIPKMBAFKP = base.gameObject.GetComponent<WeaponSync_Catcher>();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			CDINEHMLEBM.patchedClips = CDINEHMLEBM.clips;
			ELNOFDELCBH = CDINEHMLEBM.clips;
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)4)
		{
			KFEJPOEHNOA.patchedClips = KFEJPOEHNOA.clips;
			ELNOFDELCBH = KFEJPOEHNOA.clips;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			ELNOFDELCBH = FAJAKOCNMGL.ammoCount;
		}
	}

	private IEnumerator grenadeLauncherReload()
	{
		ABCKOODMGBE = true;
		yield return new WaitForSeconds(FAJAKOCNMGL.waitBeforeReload);
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(FAJAKOCNMGL.reloadTime);
		}
		GetComponent<AudioSource>().clip = FAJAKOCNMGL.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(FAJAKOCNMGL.reloadTime);
		ABCKOODMGBE = false;
	}

	private void Awake()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		OJNKMBPLGJI = HKOIJFEMIMB.GetComponent<CharacterController>();
		FPSMouseLook[] componentsInChildren = base.transform.root.GetComponentsInChildren<FPSMouseLook>();
		FPSMouseLook[] array = componentsInChildren;
		foreach (FPSMouseLook fPSMouseLook in array)
		{
			if (fPSMouseLook.ONGNICDKGDF == FPSMouseLook.LCBGHDDCHFJ.MouseY)
			{
				FIEOHPDPMKL = fPSMouseLook;
			}
		}
		if (base.gameObject.GetComponentInChildren<WeaponAnimation>() != null)
		{
			BANOGNPHFMI = base.gameObject.GetComponentInChildren<WeaponAnimation>();
		}
		else if (base.gameObject.GetComponentInChildren<SniperAnimation>() != null)
		{
			GGCHHCHAFPB = base.gameObject.GetComponentInChildren<SniperAnimation>();
		}
		if (base.gameObject.GetComponent<WeaponSync_Catcher>() != null)
		{
			DMIPKMBAFKP = base.gameObject.GetComponent<WeaponSync_Catcher>();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			CDINEHMLEBM.patchedClips = CDINEHMLEBM.clips;
			ELNOFDELCBH = CDINEHMLEBM.clips;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN)
		{
			KFEJPOEHNOA.patchedClips = KFEJPOEHNOA.clips;
			ELNOFDELCBH = KFEJPOEHNOA.clips;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			ELNOFDELCBH = FAJAKOCNMGL.ammoCount;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_60()
	{
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.transform.localRotation = Quaternion.AngleAxis(UnityEngine.Random.Range(0, 359), Vector3.left);
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = true;
		}
		yield return new WaitForSeconds(0.04f);
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(false);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_86()
	{
		ABCKOODMGBE = true;
		yield return new WaitForSeconds(FAJAKOCNMGL.waitBeforeReload);
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(FAJAKOCNMGL.reloadTime);
		}
		GetComponent<AudioSource>().clip = FAJAKOCNMGL.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(FAJAKOCNMGL.reloadTime);
		ABCKOODMGBE = false;
	}

	private IEnumerator __BB_OBFUSCATOR_42()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private IEnumerator knifeOneShot()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void Aiming()
	{
		if (DMCAELEFJFD && (!CJFDABKPMND.KKBOHCFDNGD || BBEAFEEBHJJ))
		{
			KEHNHHBGBKP = GIAILINMPIG.aimPosition;
			LKIBOKENDLG = GIAILINMPIG.toFov;
			BHFPHOBDOCN = CDINEHMLEBM.AimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = GIAILINMPIG.aimBobbingAmount;
		}
		else
		{
			KEHNHHBGBKP = FOAJFALEKJD;
			LKIBOKENDLG = EDIBGJHPOLD;
			BHFPHOBDOCN = CDINEHMLEBM.NoAimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = LHAHKKPAPGH;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, KEHNHHBGBKP, Time.deltaTime / GIAILINMPIG.smoothTime);
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, LKIBOKENDLG, Time.deltaTime / GIAILINMPIG.smoothTime);
	}

	private IEnumerator __BB_OBFUSCATOR_64()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range(0f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(0f - JODOFANGJIE.shakeAmount, JODOFANGJIE.shakeAmount), 0f);
		yield return new WaitForSeconds(0.05f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private IEnumerator __BB_OBFUSCATOR_83()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 1)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private void grenadeLauncherAwake()
	{
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = true;
	}

	private IEnumerator machineGunCameraRecoil()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range(0f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(0f - JODOFANGJIE.shakeAmount, JODOFANGJIE.shakeAmount), 0f);
		yield return new WaitForSeconds(0.05f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private IEnumerator __BB_OBFUSCATOR_75()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		NOKLEPHMCJO = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(CDINEHMLEBM.reloadTime);
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.Reloading(CDINEHMLEBM.reloadTime);
		}
		GetComponent<AudioSource>().clip = CDINEHMLEBM.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(CDINEHMLEBM.reloadTime);
		if ((int)CDINEHMLEBM.patchedClips > 0)
		{
			int num = (int)CDINEHMLEBM.bulletsPerClip - (int)CDINEHMLEBM.bulletsLeft;
			if ((int)CDINEHMLEBM.patchedClips > num)
			{
				CDINEHMLEBM.patchedClips = (int)CDINEHMLEBM.patchedClips - num;
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + num;
			}
			else
			{
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + (int)CDINEHMLEBM.patchedClips;
				CDINEHMLEBM.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_82()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(KFEJPOEHNOA.reloadTime);
		}
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(KFEJPOEHNOA.reloadTime);
		if ((int)KFEJPOEHNOA.patchedClips > 0)
		{
			int num = (int)KFEJPOEHNOA.bulletsPerClip - (int)KFEJPOEHNOA.bulletsLeft;
			if ((int)KFEJPOEHNOA.patchedClips > num)
			{
				KFEJPOEHNOA.patchedClips = (int)KFEJPOEHNOA.patchedClips - num;
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + num;
			}
			else
			{
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + (int)KFEJPOEHNOA.patchedClips;
				KFEJPOEHNOA.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private void __BB_OBFUSCATOR_85()
	{
		if (DMCAELEFJFD && (!CJFDABKPMND.KKBOHCFDNGD || BBEAFEEBHJJ))
		{
			KEHNHHBGBKP = GIAILINMPIG.aimPosition;
			LKIBOKENDLG = GIAILINMPIG.toFov;
			BHFPHOBDOCN = CDINEHMLEBM.AimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = GIAILINMPIG.aimBobbingAmount;
		}
		else
		{
			KEHNHHBGBKP = FOAJFALEKJD;
			LKIBOKENDLG = EDIBGJHPOLD;
			BHFPHOBDOCN = CDINEHMLEBM.NoAimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = LHAHKKPAPGH;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, KEHNHHBGBKP, Time.deltaTime / GIAILINMPIG.smoothTime);
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, LKIBOKENDLG, Time.deltaTime / GIAILINMPIG.smoothTime);
	}

	private void grenadeLauncherFixedUpdate()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			grenadeLauncherFIre();
		}
		else
		{
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private IEnumerator machineGunReload()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		NOKLEPHMCJO = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(CDINEHMLEBM.reloadTime);
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.Reloading(CDINEHMLEBM.reloadTime);
		}
		GetComponent<AudioSource>().clip = CDINEHMLEBM.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(CDINEHMLEBM.reloadTime);
		if ((int)CDINEHMLEBM.patchedClips > 0)
		{
			int num = (int)CDINEHMLEBM.bulletsPerClip - (int)CDINEHMLEBM.bulletsLeft;
			if ((int)CDINEHMLEBM.patchedClips > num)
			{
				CDINEHMLEBM.patchedClips = (int)CDINEHMLEBM.patchedClips - num;
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + num;
			}
			else
			{
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + (int)CDINEHMLEBM.patchedClips;
				CDINEHMLEBM.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private void machineGunStopFire()
	{
		CJFDABKPMND.CLFJBIPJCAL = true;
	}

	private IEnumerator __BB_OBFUSCATOR_45()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(KFEJPOEHNOA.reloadTime);
		}
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(KFEJPOEHNOA.reloadTime);
		if ((int)KFEJPOEHNOA.patchedClips > 0)
		{
			int num = (int)KFEJPOEHNOA.bulletsPerClip - (int)KFEJPOEHNOA.bulletsLeft;
			if ((int)KFEJPOEHNOA.patchedClips > num)
			{
				KFEJPOEHNOA.patchedClips = (int)KFEJPOEHNOA.patchedClips - num;
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + num;
			}
			else
			{
				KFEJPOEHNOA.bulletsLeft = (int)KFEJPOEHNOA.bulletsLeft + (int)KFEJPOEHNOA.patchedClips;
				KFEJPOEHNOA.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private void cameraRecoilDo()
	{
		Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, MADPBACAPKA, Time.deltaTime * (float)JODOFANGJIE.smooth);
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 1)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private Vector3 GetCenterOfScreen()
	{
		Ray ray = default(Ray);
		ray.origin = PAOALFIOFDK.position;
		ray.direction = PAOALFIOFDK.transform.forward;
		RaycastHit hitInfo = default(RaycastHit);
		int layerMask = -2049;
		if (Physics.Raycast(ray, out hitInfo, 300f, layerMask))
		{
			return hitInfo.point;
		}
		return PAOALFIOFDK.position + PAOALFIOFDK.forward * 100f;
	}

	private IEnumerator __BB_OBFUSCATOR_25()
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation;
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		HMBJBCLCDAI = UnityEngine.Object.Instantiate(CDINEHMLEBM.bullet, KFALIPMFJEO.position, Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation);
		HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		--CDINEHMLEBM.bulletsLeft;
		GetComponent<AudioSource>().clip = CDINEHMLEBM.fireSound;
		GetComponent<AudioSource>().Play();
		StartCoroutine(machineGunMuzzleFlash());
		if (DMCAELEFJFD)
		{
			if (GIAILINMPIG.playAnimation)
			{
				if ((bool)BANOGNPHFMI)
				{
					BANOGNPHFMI.Fire();
				}
				if ((bool)GGCHHCHAFPB)
				{
					GGCHHCHAFPB.Fire();
				}
			}
		}
		else
		{
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)GGCHHCHAFPB)
			{
				GGCHHCHAFPB.Fire();
			}
		}
		if (JCMFPCADILO)
		{
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
			StartCoroutine(machineGunCameraRecoil());
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)CDINEHMLEBM.patchedClips > 0 && (int)CDINEHMLEBM.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(machineGunReload());
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_16()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			__BB_OBFUSCATOR_30();
		}
		else
		{
			__BB_OBFUSCATOR_58();
			if ((bool)CDINEHMLEBM.muzzleFlash)
			{
				CDINEHMLEBM.muzzleFlash.SetActive(true);
			}
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private IEnumerator __BB_OBFUSCATOR_37()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		KFEJPOEHNOA.bulletsLeft = KFEJPOEHNOA.bulletsPerClip;
		if ((bool)KFEJPOEHNOA.smoke)
		{
			KFEJPOEHNOA.smoke.emit = false;
		}
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = true;
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			machineGunFire();
		}
		else
		{
			machineGunStopFire();
			if ((bool)CDINEHMLEBM.muzzleFlash)
			{
				CDINEHMLEBM.muzzleFlash.SetActive(false);
			}
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = true;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_56()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void grenadeLauncherFIre()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 0)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		KFEJPOEHNOA.bulletsLeft = KFEJPOEHNOA.bulletsPerClip;
		if ((bool)KFEJPOEHNOA.smoke)
		{
			KFEJPOEHNOA.smoke.emit = false;
		}
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = false;
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (FAJAKOCNMGL.ammoCount != 0 && OJMPENKKGPJ)
		{
			if (Time.time - FAJAKOCNMGL.reloadTime > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && FAJAKOCNMGL.ammoCount > 1)
			{
				StartCoroutine(grenadeLauncherOneShot());
				GLECANKJDEB += FAJAKOCNMGL.reloadTime;
			}
		}
	}

	private Vector3 __BB_OBFUSCATOR_68()
	{
		Ray ray = default(Ray);
		ray.origin = PAOALFIOFDK.position;
		ray.direction = PAOALFIOFDK.transform.forward;
		RaycastHit hitInfo = default(RaycastHit);
		int layerMask = 60;
		if (Physics.Raycast(ray, out hitInfo, 1273f, layerMask))
		{
			return hitInfo.point;
		}
		return PAOALFIOFDK.position + PAOALFIOFDK.forward * 1233f;
	}

	private IEnumerator __BB_OBFUSCATOR_73()
	{
		ABCKOODMGBE = true;
		DMCAELEFJFD = false;
		NOKLEPHMCJO = false;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Reloading(CDINEHMLEBM.reloadTime);
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.Reloading(CDINEHMLEBM.reloadTime);
		}
		GetComponent<AudioSource>().clip = CDINEHMLEBM.reloadSound;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(CDINEHMLEBM.reloadTime);
		if ((int)CDINEHMLEBM.patchedClips > 0)
		{
			int num = (int)CDINEHMLEBM.bulletsPerClip - (int)CDINEHMLEBM.bulletsLeft;
			if ((int)CDINEHMLEBM.patchedClips > num)
			{
				CDINEHMLEBM.patchedClips = (int)CDINEHMLEBM.patchedClips - num;
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + num;
			}
			else
			{
				CDINEHMLEBM.bulletsLeft = (int)CDINEHMLEBM.bulletsLeft + (int)CDINEHMLEBM.patchedClips;
				CDINEHMLEBM.patchedClips = 0;
			}
			PLIOKPDLDPI = false;
			ABCKOODMGBE = false;
			NOKLEPHMCJO = true;
			CJFDABKPMND.CLFJBIPJCAL = true;
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = true;
	}

	private void knifeAwake()
	{
		NOKLEPHMCJO = false;
		OJMPENKKGPJ = true;
	}

	private IEnumerator __BB_OBFUSCATOR_15()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private void __BB_OBFUSCATOR_36()
	{
		OJMPENKKGPJ = false;
		if (HKJBFLNEGCH != (BNILOGDCIEG)5)
		{
			NOKLEPHMCJO = true;
		}
		DMCAELEFJFD = true;
		if ((bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.__BB_OBFUSCATOR_1();
		}
		if ((bool)GGCHHCHAFPB)
		{
			GGCHHCHAFPB.__BB_OBFUSCATOR_28();
		}
	}

	private IEnumerator shotGunCameraRecoil()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private void __BB_OBFUSCATOR_72()
	{
		KFEJPOEHNOA.bulletsLeft = KFEJPOEHNOA.bulletsPerClip;
		if ((bool)KFEJPOEHNOA.smoke)
		{
			KFEJPOEHNOA.smoke.emit = true;
		}
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = false;
	}

	private IEnumerator __BB_OBFUSCATOR_31()
	{
		MADPBACAPKA = Quaternion.Euler(UnityEngine.Random.Range((0f - JODOFANGJIE.shakeAmount) * 1.5f, 0f - JODOFANGJIE.shakeAmount), UnityEngine.Random.Range(JODOFANGJIE.shakeAmount / 3f, JODOFANGJIE.shakeAmount / 2f), 0f);
		yield return new WaitForSeconds(0.1f);
		MADPBACAPKA = MEHHMEOKNOM;
	}

	private IEnumerator shotGunSmokeEffect()
	{
		if (!KFEJPOEHNOA.smoke)
		{
			yield return null;
		}
		KFEJPOEHNOA.smoke.emit = true;
		yield return new WaitForSeconds(0.3f);
		KFEJPOEHNOA.smoke.emit = false;
	}

	private void RotationRealism()
	{
		float axis = cInput.GetAxis("Mouse X");
		float axis2 = cInput.GetAxis("Mouse Y");
		float y = 0f;
		float x = 0f;
		if (Mathf.Abs(axis) > 0.1f)
		{
			if (axis < 0.1f)
			{
				y = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis);
			}
			else if (axis > 0.1f)
			{
				y = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis);
			}
		}
		else
		{
			y = 0f;
		}
		if (Mathf.Abs(axis2) > 0.1f)
		{
			if (axis2 < 0.1f)
			{
				x = (float)ICBDPGIFMLM.RotationAmplitude * Mathf.Abs(axis2);
			}
			else if ((double)axis2 > 0.1)
			{
				x = (float)(-ICBDPGIFMLM.RotationAmplitude) * Mathf.Abs(axis2);
			}
		}
		else
		{
			x = 0f;
		}
		Quaternion b = Quaternion.Euler(x, y, 0f);
		base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, b, Time.deltaTime * (float)ICBDPGIFMLM.smooth);
	}

	private void __BB_OBFUSCATOR_8()
	{
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = true;
	}

	private void machineGunAwake()
	{
		CDINEHMLEBM.bulletsLeft = CDINEHMLEBM.bulletsPerClip;
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(false);
		}
		NOKLEPHMCJO = true;
		OJMPENKKGPJ = true;
	}

	private IEnumerator machineGunMuzzleFlash()
	{
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.transform.localRotation = Quaternion.AngleAxis(UnityEngine.Random.Range(0, 359), Vector3.left);
			CDINEHMLEBM.muzzleFlash.SetActive(true);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = true;
		}
		yield return new WaitForSeconds(0.04f);
		if ((bool)CDINEHMLEBM.muzzleFlash)
		{
			CDINEHMLEBM.muzzleFlash.SetActive(false);
		}
		if ((bool)CDINEHMLEBM.pointLight)
		{
			CDINEHMLEBM.pointLight.enabled = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_50()
	{
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		Quaternion rotation = KFALIPMFJEO.rotation;
		for (int i = 0; i < KFEJPOEHNOA.fractions; i++)
		{
			KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * KFEJPOEHNOA.errorAngle) * base.transform.rotation;
			Transform transform = UnityEngine.Object.Instantiate(KFEJPOEHNOA.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if ((bool)transform)
			{
				transform.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
		}
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		GetComponent<AudioSource>().clip = KFEJPOEHNOA.fireSound;
		GetComponent<AudioSource>().Play();
		--KFEJPOEHNOA.bulletsLeft;
		if (DMCAELEFJFD && GIAILINMPIG.playAnimation && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if (!DMCAELEFJFD && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		StartCoroutine(shotGunSmokeEffect());
		if (JCMFPCADILO)
		{
			StartCoroutine(shotGunCameraRecoil());
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
		}
		HMBJBCLCDAI = KFEJPOEHNOA.bullet;
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)KFEJPOEHNOA.patchedClips > 0 && (int)KFEJPOEHNOA.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(shotGunReload());
			}
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		if ((int)KFEJPOEHNOA.bulletsLeft != 0)
		{
			if (Time.time - KFEJPOEHNOA.fireRate > GLECANKJDEB)
			{
				GLECANKJDEB = Time.time - Time.deltaTime;
			}
			while (GLECANKJDEB < Time.time && (int)KFEJPOEHNOA.bulletsLeft != 0)
			{
				StartCoroutine(__BB_OBFUSCATOR_50());
				GLECANKJDEB += KFEJPOEHNOA.fireRate;
			}
		}
	}

	private void __BB_OBFUSCATOR_54()
	{
		if (DMCAELEFJFD && (!CJFDABKPMND.KKBOHCFDNGD || BBEAFEEBHJJ))
		{
			KEHNHHBGBKP = GIAILINMPIG.aimPosition;
			LKIBOKENDLG = GIAILINMPIG.toFov;
			BHFPHOBDOCN = CDINEHMLEBM.AimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = GIAILINMPIG.aimBobbingAmount;
		}
		else
		{
			KEHNHHBGBKP = FOAJFALEKJD;
			LKIBOKENDLG = EDIBGJHPOLD;
			BHFPHOBDOCN = CDINEHMLEBM.NoAimErrorAngle;
			KNKNFEJHHBB.DNABPIICJEG = LHAHKKPAPGH;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, KEHNHHBGBKP, Time.deltaTime / GIAILINMPIG.smoothTime);
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, LKIBOKENDLG, Time.deltaTime / GIAILINMPIG.smoothTime);
	}

	private void shotGunFixedUpdate()
	{
		if (OCKKJJLFBPC && !ABCKOODMGBE)
		{
			shotGunFire();
		}
		else
		{
			shotGunStopFire();
		}
		if (ABCKOODMGBE)
		{
			NOKLEPHMCJO = false;
		}
	}

	private IEnumerator grenadeLauncherOneShot()
	{
		if (FAJAKOCNMGL.shotDelay > 0f)
		{
			if (DMCAELEFJFD && GIAILINMPIG.playAnimation && (bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if (!DMCAELEFJFD && (bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if (JCMFPCADILO)
			{
				if ((bool)FIEOHPDPMKL)
				{
					FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
				}
				StartCoroutine(grenadeLauncherCameraRecoil());
			}
			StartCoroutine(grenadeLauncherReload());
			yield return new WaitForSeconds(FAJAKOCNMGL.shotDelay);
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		Rigidbody rigidbody = UnityEngine.Object.Instantiate(FAJAKOCNMGL.projectile, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = false;
		rigidbody.velocity = base.transform.TransformDirection(new Vector3(0f, 0f, FAJAKOCNMGL.initialSpeed));
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		foreach (Collider collider in componentsInChildren)
		{
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		HBGPOFNINHD = Time.time;
		FAJAKOCNMGL.ammoCount--;
		GetComponent<AudioSource>().clip = FAJAKOCNMGL.fireSound;
		GetComponent<AudioSource>().Play();
		if (FAJAKOCNMGL.shotDelay != 0f)
		{
			yield break;
		}
		if (DMCAELEFJFD && GIAILINMPIG.playAnimation && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if (!DMCAELEFJFD && (bool)BANOGNPHFMI)
		{
			BANOGNPHFMI.Fire();
		}
		if (JCMFPCADILO)
		{
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
			StartCoroutine(grenadeLauncherCameraRecoil());
		}
		if (FAJAKOCNMGL.ammoCount > 0)
		{
			StartCoroutine(grenadeLauncherReload());
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		CJFDABKPMND.CLFJBIPJCAL = false;
	}

	private void __BB_OBFUSCATOR_21()
	{
		KNKNFEJHHBB = base.transform.root.GetComponentInChildren<WalkSway>();
		LHAHKKPAPGH = KNKNFEJHHBB.DNABPIICJEG;
		MEHHMEOKNOM = Camera.main.transform.localRotation;
		EDIBGJHPOLD = Camera.main.fieldOfView;
		FOAJFALEKJD = base.transform.localPosition;
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			__BB_OBFUSCATOR_27();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			grenadeLauncherAwake();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE)
		{
			__BB_OBFUSCATOR_91();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)6)
		{
			knifeAwake();
		}
		PAOALFIOFDK = Camera.main.transform;
	}

	private IEnumerator __BB_OBFUSCATOR_33()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (cInput.GetButtonDown("DoDamage") && NOKLEPHMCJO && !CJFDABKPMND.KKBOHCFDNGD)
		{
			DMCAELEFJFD = DMCAELEFJFD;
		}
		if (cInput.GetButton("_Value4") && OJMPENKKGPJ && !GOJHNNDJMFJ)
		{
			OCKKJJLFBPC = false;
		}
		else
		{
			OCKKJJLFBPC = true;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			if (cInput.GetButtonDown("_ScreenResolution") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
			{
				__BB_OBFUSCATOR_30();
			}
			else
			{
				machineGunStopFire();
			}
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER && cInput.GetButtonDown("_Distance") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			__BB_OBFUSCATOR_3();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)6 && cInput.GetButtonDown("_NeighbourMaxTex") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			shotGunFire();
		}
		if (HKJBFLNEGCH == (BNILOGDCIEG)5 && cInput.GetButtonDown("_TimeX") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			StartCoroutine(__BB_OBFUSCATOR_37());
		}
		if (cInput.GetButtonDown("A") && !ABCKOODMGBE && ((int)CDINEHMLEBM.patchedClips > 0 || (int)KFEJPOEHNOA.patchedClips > 1))
		{
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && (int)CDINEHMLEBM.bulletsLeft != (int)CDINEHMLEBM.bulletsPerClip)
			{
				StartCoroutine(machineGunReload());
			}
			if (HKJBFLNEGCH == (BNILOGDCIEG)6 && (int)KFEJPOEHNOA.bulletsLeft != (int)KFEJPOEHNOA.bulletsPerClip)
			{
				StartCoroutine(__BB_OBFUSCATOR_82());
			}
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		HKOIJFEMIMB = base.transform.root.gameObject;
		CJFDABKPMND = HKOIJFEMIMB.GetComponent<FPScontroller>();
		OJNKMBPLGJI = HKOIJFEMIMB.GetComponent<CharacterController>();
		FPSMouseLook[] componentsInChildren = base.transform.root.GetComponentsInChildren<FPSMouseLook>();
		FPSMouseLook[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i += 0)
		{
			FPSMouseLook fPSMouseLook = array[i];
			if (fPSMouseLook.ONGNICDKGDF == FPSMouseLook.LCBGHDDCHFJ.MouseY)
			{
				FIEOHPDPMKL = fPSMouseLook;
			}
		}
		if (base.gameObject.GetComponentInChildren<WeaponAnimation>() != null)
		{
			BANOGNPHFMI = base.gameObject.GetComponentInChildren<WeaponAnimation>();
		}
		else if (base.gameObject.GetComponentInChildren<SniperAnimation>() != null)
		{
			GGCHHCHAFPB = base.gameObject.GetComponentInChildren<SniperAnimation>();
		}
		if (base.gameObject.GetComponent<WeaponSync_Catcher>() != null)
		{
			DMIPKMBAFKP = base.gameObject.GetComponent<WeaponSync_Catcher>();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			CDINEHMLEBM.patchedClips = CDINEHMLEBM.clips;
			ELNOFDELCBH = CDINEHMLEBM.clips;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE)
		{
			KFEJPOEHNOA.patchedClips = KFEJPOEHNOA.clips;
			ELNOFDELCBH = KFEJPOEHNOA.clips;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			ELNOFDELCBH = FAJAKOCNMGL.ammoCount;
		}
	}

	private void InputUpdate()
	{
		if (cInput.GetButtonDown("Aim") && NOKLEPHMCJO && !CJFDABKPMND.KKBOHCFDNGD)
		{
			DMCAELEFJFD = !DMCAELEFJFD;
		}
		if (cInput.GetButton("Fire") && OJMPENKKGPJ && !GOJHNNDJMFJ)
		{
			OCKKJJLFBPC = true;
		}
		else
		{
			OCKKJJLFBPC = false;
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
		{
			if (cInput.GetButtonDown("Fire") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
			{
				machineGunFire();
			}
			else
			{
				machineGunStopFire();
			}
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.GRENADE_LAUNCHER && cInput.GetButtonDown("Fire") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			grenadeLauncherFIre();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN && cInput.GetButtonDown("Fire") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			shotGunFire();
		}
		if (HKJBFLNEGCH == BNILOGDCIEG.KNIFE && cInput.GetButtonDown("Fire") && OJMPENKKGPJ && !ABCKOODMGBE && GOJHNNDJMFJ)
		{
			StartCoroutine(knifeOneShot());
		}
		if (cInput.GetButtonDown("Reload") && !ABCKOODMGBE && ((int)CDINEHMLEBM.patchedClips > 0 || (int)KFEJPOEHNOA.patchedClips > 0))
		{
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN && (int)CDINEHMLEBM.bulletsLeft != (int)CDINEHMLEBM.bulletsPerClip)
			{
				StartCoroutine(machineGunReload());
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.SHOTGUN && (int)KFEJPOEHNOA.bulletsLeft != (int)KFEJPOEHNOA.bulletsPerClip)
			{
				StartCoroutine(shotGunReload());
			}
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (!(Time.timeScale < 1417f))
		{
			__BB_OBFUSCATOR_85();
			__BB_OBFUSCATOR_40();
			SmoothMove();
			if (JCMFPCADILO)
			{
				__BB_OBFUSCATOR_6();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
			{
				__BB_OBFUSCATOR_65();
			}
			if (HKJBFLNEGCH == BNILOGDCIEG.MACHINE_GUN)
			{
				grenadeLauncherFixedUpdate();
			}
			if (HKJBFLNEGCH == (BNILOGDCIEG)8)
			{
				shotGunFixedUpdate();
			}
			if (CJFDABKPMND.KKBOHCFDNGD && !BBEAFEEBHJJ)
			{
				DMCAELEFJFD = true;
			}
			if (!ObscuredPrefs.GetBool("MP") && !CJFDABKPMND.KKBOHCFDNGD && GameObject.FindWithTag("Null") == null)
			{
				__BB_OBFUSCATOR_53();
			}
		}
	}

	private IEnumerator MeleeAnimation()
	{
		JAICJAJMJIA = true;
		yield return new WaitForSeconds(0.5f);
		JAICJAJMJIA = false;
	}

	private void __BB_OBFUSCATOR_6()
	{
		Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, MADPBACAPKA, Time.deltaTime * (float)JODOFANGJIE.smooth);
	}

	private void __BB_OBFUSCATOR_46()
	{
		Camera.main.transform.localRotation = Quaternion.Slerp(Camera.main.transform.localRotation, MADPBACAPKA, Time.deltaTime * (float)JODOFANGJIE.smooth);
	}

	private IEnumerator __BB_OBFUSCATOR_23()
	{
		if (!KFEJPOEHNOA.smoke)
		{
			yield return null;
		}
		KFEJPOEHNOA.smoke.emit = true;
		yield return new WaitForSeconds(0.3f);
		KFEJPOEHNOA.smoke.emit = false;
	}

	private IEnumerator machineGunOneShot()
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation;
		KFALIPMFJEO.LookAt(GetCenterOfScreen());
		HMBJBCLCDAI = UnityEngine.Object.Instantiate(CDINEHMLEBM.bullet, KFALIPMFJEO.position, Quaternion.Euler(UnityEngine.Random.insideUnitSphere * BHFPHOBDOCN) * base.transform.rotation);
		HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
		KFALIPMFJEO.rotation = rotation;
		HBGPOFNINHD = Time.time;
		--CDINEHMLEBM.bulletsLeft;
		GetComponent<AudioSource>().clip = CDINEHMLEBM.fireSound;
		GetComponent<AudioSource>().Play();
		StartCoroutine(machineGunMuzzleFlash());
		if (DMCAELEFJFD)
		{
			if (GIAILINMPIG.playAnimation)
			{
				if ((bool)BANOGNPHFMI)
				{
					BANOGNPHFMI.Fire();
				}
				if ((bool)GGCHHCHAFPB)
				{
					GGCHHCHAFPB.Fire();
				}
			}
		}
		else
		{
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)GGCHHCHAFPB)
			{
				GGCHHCHAFPB.Fire();
			}
		}
		if (JCMFPCADILO)
		{
			if ((bool)FIEOHPDPMKL)
			{
				FIEOHPDPMKL.Recoil(JODOFANGJIE.recoilPower);
			}
			StartCoroutine(machineGunCameraRecoil());
		}
		if ((bool)DMIPKMBAFKP)
		{
			DMIPKMBAFKP.Fire();
		}
		yield return new WaitForEndOfFrame();
		HMBJBCLCDAI = null;
		if ((int)CDINEHMLEBM.patchedClips > 0 && (int)CDINEHMLEBM.bulletsLeft == 0)
		{
			PLIOKPDLDPI = true;
			yield return new WaitForSeconds(1f);
			if (!ABCKOODMGBE)
			{
				StartCoroutine(machineGunReload());
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_41()
	{
		if (Time.time > PMJAHJCIGPF.fireRate + HBGPOFNINHD)
		{
			KFALIPMFJEO.LookAt(GetCenterOfScreen());
			GetComponent<AudioSource>().clip = PMJAHJCIGPF.fireSound;
			if (!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}
			if ((bool)BANOGNPHFMI)
			{
				BANOGNPHFMI.Fire();
			}
			if ((bool)DMIPKMBAFKP)
			{
				DMIPKMBAFKP.Fire();
			}
			if (!JAICJAJMJIA)
			{
				StartCoroutine(MeleeAnimation());
			}
			yield return new WaitForSeconds(PMJAHJCIGPF.delayTime);
			HMBJBCLCDAI = UnityEngine.Object.Instantiate(PMJAHJCIGPF.bullet, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			if (HMBJBCLCDAI != null)
			{
				HMBJBCLCDAI.GetComponent<Bullet>().FLEAONNBLOP = true;
			}
			HBGPOFNINHD = Time.time;
		}
	}
}
