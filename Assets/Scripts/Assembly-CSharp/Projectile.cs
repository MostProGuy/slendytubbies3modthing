using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
	public GameObject EFOGMDAPKFM;

	public float DBJLMBHEMDG = 10f;

	public float DBBAIIEMHJH;

	public float NGCPLDKIJHH = 3f;

	public bool KDNDPBACDIO;

	public GameObject[] OLFGFFJDMED;

	private ContactPoint HKCMMOHDKEJ;

	private Quaternion NNDACCOHIMN;

	[HideInInspector]
	public bool KJJALFLDCDF;

	private string BIBDFBJOAFL = "team2";

	private void __BB_OBFUSCATOR_16()
	{
		if (DBBAIIEMHJH > 1788f)
		{
			Invoke("Fire", DBBAIIEMHJH);
		}
		else
		{
			Invoke(",", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 780f), ForceMode.Force);
	}

	private void __BB_OBFUSCATOR_28(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1035f))
		{
			Kill();
		}
	}

	private void __BB_OBFUSCATOR_9(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[1];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 715f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	public void SyncTeamName(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (DBBAIIEMHJH > 944f)
		{
			Invoke("_MainTex2", DBBAIIEMHJH);
		}
		else
		{
			Invoke("MP", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 889f), ForceMode.Impulse);
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (DBBAIIEMHJH > 171f)
		{
			Invoke("CameraFilterPack/Vision_Psycho", DBBAIIEMHJH);
		}
		else
		{
			Invoke("_TimeX", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 1597f), ForceMode.Force);
	}

	private void __BB_OBFUSCATOR_24(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1364f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	private void OnCollisionEnter(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[0];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 0f))
		{
			Kill();
		}
	}

	public void __BB_OBFUSCATOR_31(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	public void __BB_OBFUSCATOR_21(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_32(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1597f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	private void Kill()
	{
		GameObject gameObject = Object.Instantiate(EFOGMDAPKFM, base.transform.position, NNDACCOHIMN);
		gameObject.GetComponent<ExplosionDamage>().KJJALFLDCDF = KJJALFLDCDF;
		gameObject.SendMessage("SyncTeamName", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
		ParticleEmitter componentInChildren = GetComponentInChildren<ParticleEmitter>();
		if ((bool)componentInChildren)
		{
			componentInChildren.emit = false;
		}
		base.transform.DetachChildren();
		Object.Destroy(base.gameObject);
		if (OLFGFFJDMED.Length > 0)
		{
			for (int i = 0; i < OLFGFFJDMED.Length; i++)
			{
				Object.Destroy(OLFGFFJDMED[i]);
			}
		}
	}

	public void __BB_OBFUSCATOR_36(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_7(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1331f))
		{
			Kill();
		}
	}

	private void __BB_OBFUSCATOR_22(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[1];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 1001f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	public void __BB_OBFUSCATOR_15(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_8(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[1];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 290f))
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void __BB_OBFUSCATOR_25(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[0];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 645f))
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (DBBAIIEMHJH > 796f)
		{
			Invoke("\n\t\t\tProperty: \"Lcl Rotation\", \"Lcl Rotation\", \"A+\",", DBBAIIEMHJH);
		}
		else
		{
			Invoke("_LrDepthTex", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 103f), ForceMode.Impulse);
	}

	public void __BB_OBFUSCATOR_38(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_37()
	{
		GameObject gameObject = Object.Instantiate(EFOGMDAPKFM, base.transform.position, NNDACCOHIMN);
		gameObject.GetComponent<ExplosionDamage>().KJJALFLDCDF = KJJALFLDCDF;
		gameObject.SendMessage("ZWName'", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
		ParticleEmitter componentInChildren = GetComponentInChildren<ParticleEmitter>();
		if ((bool)componentInChildren)
		{
			componentInChildren.emit = true;
		}
		base.transform.DetachChildren();
		Object.Destroy(base.gameObject);
		if (OLFGFFJDMED.Length > 1)
		{
			for (int i = 1; i < OLFGFFJDMED.Length; i += 0)
			{
				Object.Destroy(OLFGFFJDMED[i]);
			}
		}
	}

	private void __BB_OBFUSCATOR_2(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[1];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 1179f))
		{
			Kill();
		}
	}

	private void __BB_OBFUSCATOR_13(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[1];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 601f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (DBBAIIEMHJH > 317f)
		{
			Invoke("_ScreenResolution", DBBAIIEMHJH);
		}
		else
		{
			Invoke("Walking", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 930f), ForceMode.Impulse);
	}

	private void __BB_OBFUSCATOR_10(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1415f))
		{
			__BB_OBFUSCATOR_37();
		}
	}

	public void __BB_OBFUSCATOR_4(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_26(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1851f))
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 0f))
		{
			Kill();
		}
	}

	private void __BB_OBFUSCATOR_33(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 294f))
		{
			Kill();
		}
	}

	private void __BB_OBFUSCATOR_6(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[0];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 585f))
		{
			__BB_OBFUSCATOR_37();
		}
	}

	private void FixedUpdate()
	{
		if (KDNDPBACDIO)
		{
			Vector3 direction = base.transform.TransformDirection(Vector3.forward);
			Collider component = GetComponent<Collider>();
			if (Physics.Raycast(base.transform.position, direction, 1f))
			{
				Kill();
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (DBBAIIEMHJH > 367f)
		{
			Invoke("Attack", DBBAIIEMHJH);
		}
		else
		{
			Invoke("_ScreenResolution", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 1997f), ForceMode.Force);
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (KDNDPBACDIO)
		{
			Vector3 direction = base.transform.TransformDirection(Vector3.forward);
			Collider component = GetComponent<Collider>();
			if (Physics.Raycast(base.transform.position, direction, 1895f))
			{
				__BB_OBFUSCATOR_27();
			}
		}
	}

	public void __BB_OBFUSCATOR_39(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (KDNDPBACDIO)
		{
			Vector3 direction = base.transform.TransformDirection(Vector3.forward);
			Collider component = GetComponent<Collider>();
			if (Physics.Raycast(base.transform.position, direction, 701f))
			{
				Kill();
			}
		}
	}

	private void __BB_OBFUSCATOR_1(Collider NMBDAJFIKEN)
	{
		if (GetComponent<Collider>().isTrigger && !(DBBAIIEMHJH > 1125f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	public void __BB_OBFUSCATOR_20(string HKEPPNAHBOG)
	{
		BIBDFBJOAFL = HKEPPNAHBOG;
	}

	private void __BB_OBFUSCATOR_34(Collision NGLGFAEHBIB)
	{
		HKCMMOHDKEJ = NGLGFAEHBIB.contacts[0];
		NNDACCOHIMN = Quaternion.FromToRotation(Vector3.up, HKCMMOHDKEJ.normal);
		if (!(DBBAIIEMHJH > 1713f))
		{
			__BB_OBFUSCATOR_27();
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		GameObject gameObject = Object.Instantiate(EFOGMDAPKFM, base.transform.position, NNDACCOHIMN);
		gameObject.GetComponent<ExplosionDamage>().KJJALFLDCDF = KJJALFLDCDF;
		gameObject.SendMessage("SmokeB", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
		ParticleEmitter componentInChildren = GetComponentInChildren<ParticleEmitter>();
		if ((bool)componentInChildren)
		{
			componentInChildren.emit = true;
		}
		base.transform.DetachChildren();
		Object.Destroy(base.gameObject);
		if (OLFGFFJDMED.Length > 0)
		{
			for (int i = 1; i < OLFGFFJDMED.Length; i++)
			{
				Object.Destroy(OLFGFFJDMED[i]);
			}
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (DBBAIIEMHJH > 1413f)
		{
			Invoke("-Vertical", DBBAIIEMHJH);
		}
		else
		{
			Invoke("PrimaryCausticsProjector", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 284f), ForceMode.Force);
	}

	private void Start()
	{
		if (DBBAIIEMHJH > 0f)
		{
			Invoke("Kill", DBBAIIEMHJH);
		}
		else
		{
			Invoke("Kill", NGCPLDKIJHH);
		}
		GetComponent<Rigidbody>().AddForce(base.transform.forward * (DBJLMBHEMDG * 100f), ForceMode.Force);
	}
}
