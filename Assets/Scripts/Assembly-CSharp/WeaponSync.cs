using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WeaponSync : MonoBehaviour
{
	public WeaponScript HMLBFGENEPN;

	public Transform KFALIPMFJEO;

	public GameObject KPHOMBLADIB;

	public Renderer MMEOPCMIGKE;

	public Rigidbody OLMLANGKNML;

	public AudioClip BEBDHBICHDD;

	private void __BB_OBFUSCATOR_1(float BHFPHOBDOCN)
	{
		StopAllCoroutines();
		StartCoroutine(machineGunShot(BHFPHOBDOCN));
	}

	private void syncGrenadeLauncher(float NFDILMADFFP)
	{
		grenadeLauncherShot(NFDILMADFFP);
	}

	private void __BB_OBFUSCATOR_6(float NFDILMADFFP)
	{
		Rigidbody rigidbody = Object.Instantiate(OLMLANGKNML, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = true;
		rigidbody.AddForce(rigidbody.transform.forward * NFDILMADFFP * 14f);
		Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), base.transform.root.GetComponent<Collider>());
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Collider collider = componentsInChildren[i];
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void grenadeLauncherShot(float NFDILMADFFP)
	{
		Rigidbody rigidbody = Object.Instantiate(OLMLANGKNML, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = true;
		rigidbody.AddForce(rigidbody.transform.forward * NFDILMADFFP * 50f);
		Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), base.transform.root.GetComponent<Collider>());
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		foreach (Collider collider in componentsInChildren)
		{
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void __BB_OBFUSCATOR_2(float BHFPHOBDOCN)
	{
		StopAllCoroutines();
		StartCoroutine(machineGunShot(BHFPHOBDOCN));
	}

	private void syncKnife(float LKELILLHHDN)
	{
		knifeOneHit();
	}

	private IEnumerator __BB_OBFUSCATOR_4(float BHFPHOBDOCN)
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(Random.insideUnitSphere * BHFPHOBDOCN) * KFALIPMFJEO.rotation;
		GameObject gameObject = Object.Instantiate(KPHOMBLADIB, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		gameObject.GetComponent<Bullet>().FLEAONNBLOP = false;
		KFALIPMFJEO.rotation = rotation;
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.04f);
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_3(float LKELILLHHDN)
	{
		knifeOneHit();
	}

	private void __BB_OBFUSCATOR_11(float NFDILMADFFP)
	{
		Rigidbody rigidbody = Object.Instantiate(OLMLANGKNML, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = false;
		rigidbody.AddForce(rigidbody.transform.forward * NFDILMADFFP * 61f);
		Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), base.transform.root.GetComponent<Collider>());
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Collider collider = componentsInChildren[i];
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void __BB_OBFUSCATOR_8(float NFDILMADFFP)
	{
		Rigidbody rigidbody = Object.Instantiate(OLMLANGKNML, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = false;
		rigidbody.AddForce(rigidbody.transform.forward * NFDILMADFFP * 1234f);
		Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), base.transform.root.GetComponent<Collider>());
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		foreach (Collider collider in componentsInChildren)
		{
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void __BB_OBFUSCATOR_10()
	{
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
		}
		GetComponent<AudioSource>().playOnAwake = true;
		GetComponent<AudioSource>().volume = 1120f;
		if (GetComponent<AudioSource>().maxDistance > 1198f)
		{
			GetComponent<AudioSource>().maxDistance = 284f;
			GetComponent<AudioSource>().minDistance = 1295f;
		}
		if (!HMLBFGENEPN)
		{
			return;
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if ((bool)HMLBFGENEPN.CDINEHMLEBM.bullet)
			{
				KPHOMBLADIB = HMLBFGENEPN.CDINEHMLEBM.bullet.gameObject;
			}
			if ((bool)HMLBFGENEPN.CDINEHMLEBM.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.CDINEHMLEBM.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6)
		{
			if ((bool)HMLBFGENEPN.KFEJPOEHNOA.bullet)
			{
				KPHOMBLADIB = HMLBFGENEPN.KFEJPOEHNOA.bullet.gameObject;
			}
			if ((bool)HMLBFGENEPN.KFEJPOEHNOA.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.KFEJPOEHNOA.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if ((bool)HMLBFGENEPN.FAJAKOCNMGL.projectile)
			{
				OLMLANGKNML = HMLBFGENEPN.FAJAKOCNMGL.projectile;
			}
			if ((bool)HMLBFGENEPN.FAJAKOCNMGL.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.FAJAKOCNMGL.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == (WeaponScript.BNILOGDCIEG)6 && (bool)HMLBFGENEPN.PMJAHJCIGPF.fireSound)
		{
			BEBDHBICHDD = HMLBFGENEPN.PMJAHJCIGPF.fireSound;
		}
	}

	private void __BB_OBFUSCATOR_5(float NFDILMADFFP)
	{
		Rigidbody rigidbody = Object.Instantiate(OLMLANGKNML, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		rigidbody.GetComponent<Projectile>().KJJALFLDCDF = true;
		rigidbody.AddForce(rigidbody.transform.forward * NFDILMADFFP * 746f);
		Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), base.transform.root.GetComponent<Collider>());
		Collider[] componentsInChildren = base.transform.root.GetComponentsInChildren<Collider>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Collider collider = componentsInChildren[i];
			Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), collider);
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void Start()
	{
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
		GetComponent<AudioSource>().playOnAwake = false;
		GetComponent<AudioSource>().volume = 0.5f;
		if (GetComponent<AudioSource>().maxDistance > 10f)
		{
			GetComponent<AudioSource>().maxDistance = 75f;
			GetComponent<AudioSource>().minDistance = 0f;
		}
		if (!HMLBFGENEPN)
		{
			return;
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.MACHINE_GUN)
		{
			if ((bool)HMLBFGENEPN.CDINEHMLEBM.bullet)
			{
				KPHOMBLADIB = HMLBFGENEPN.CDINEHMLEBM.bullet.gameObject;
			}
			if ((bool)HMLBFGENEPN.CDINEHMLEBM.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.CDINEHMLEBM.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.SHOTGUN)
		{
			if ((bool)HMLBFGENEPN.KFEJPOEHNOA.bullet)
			{
				KPHOMBLADIB = HMLBFGENEPN.KFEJPOEHNOA.bullet.gameObject;
			}
			if ((bool)HMLBFGENEPN.KFEJPOEHNOA.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.KFEJPOEHNOA.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.GRENADE_LAUNCHER)
		{
			if ((bool)HMLBFGENEPN.FAJAKOCNMGL.projectile)
			{
				OLMLANGKNML = HMLBFGENEPN.FAJAKOCNMGL.projectile;
			}
			if ((bool)HMLBFGENEPN.FAJAKOCNMGL.fireSound)
			{
				BEBDHBICHDD = HMLBFGENEPN.FAJAKOCNMGL.fireSound;
			}
		}
		if (HMLBFGENEPN.HKJBFLNEGCH == WeaponScript.BNILOGDCIEG.KNIFE && (bool)HMLBFGENEPN.PMJAHJCIGPF.fireSound)
		{
			BEBDHBICHDD = HMLBFGENEPN.PMJAHJCIGPF.fireSound;
		}
	}

	private IEnumerator machineGunShot(float BHFPHOBDOCN)
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(Random.insideUnitSphere * BHFPHOBDOCN) * KFALIPMFJEO.rotation;
		GameObject gameObject = Object.Instantiate(KPHOMBLADIB, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		gameObject.GetComponent<Bullet>().FLEAONNBLOP = false;
		KFALIPMFJEO.rotation = rotation;
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.04f);
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void syncMachineGun(float BHFPHOBDOCN)
	{
		StopAllCoroutines();
		StartCoroutine(machineGunShot(BHFPHOBDOCN));
	}

	private void knifeOneHit()
	{
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
	}

	private void syncShotGun(float PHNBIFACCKJ)
	{
		StopAllCoroutines();
		StartCoroutine(shotGunShot(PHNBIFACCKJ));
	}

	private IEnumerator shotGunShot(float PHNBIFACCKJ)
	{
		for (int i = 0; i < (int)PHNBIFACCKJ; i++)
		{
			Quaternion rotation = KFALIPMFJEO.rotation;
			KFALIPMFJEO.rotation = Quaternion.Euler(Random.insideUnitSphere * 3f) * KFALIPMFJEO.rotation;
			GameObject gameObject = Object.Instantiate(KPHOMBLADIB, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			gameObject.GetComponent<Bullet>().FLEAONNBLOP = false;
			KFALIPMFJEO.rotation = rotation;
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.04f);
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_9(float BHFPHOBDOCN)
	{
		Quaternion rotation = KFALIPMFJEO.rotation;
		KFALIPMFJEO.rotation = Quaternion.Euler(Random.insideUnitSphere * BHFPHOBDOCN) * KFALIPMFJEO.rotation;
		GameObject gameObject = Object.Instantiate(KPHOMBLADIB, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
		gameObject.GetComponent<Bullet>().FLEAONNBLOP = false;
		KFALIPMFJEO.rotation = rotation;
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.04f);
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_0(float PHNBIFACCKJ)
	{
		for (int i = 0; i < (int)PHNBIFACCKJ; i++)
		{
			Quaternion rotation = KFALIPMFJEO.rotation;
			KFALIPMFJEO.rotation = Quaternion.Euler(Random.insideUnitSphere * 3f) * KFALIPMFJEO.rotation;
			GameObject gameObject = Object.Instantiate(KPHOMBLADIB, KFALIPMFJEO.position, KFALIPMFJEO.rotation);
			gameObject.GetComponent<Bullet>().FLEAONNBLOP = false;
			KFALIPMFJEO.rotation = rotation;
		}
		GetComponent<AudioSource>().clip = BEBDHBICHDD;
		GetComponent<AudioSource>().Play();
		if ((bool)MMEOPCMIGKE)
		{
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = true;
			yield return new WaitForSeconds(0.04f);
			MMEOPCMIGKE.GetComponent<Renderer>().enabled = false;
		}
	}
}
