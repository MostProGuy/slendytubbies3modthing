using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public int DBJLMBHEMDG = 500;

	public float CJBLOMOMPDL = 3f;

	public int LNBAOJFOGDF = 20;

	public int LNPGAHBMKHH = 10;

	public bool KGPOOIIMJFD = true;

	public string OHJBLLKDFHO;

	[HideInInspector]
	public bool FLEAONNBLOP;

	public List<GameObject> BLGPGOLJHKB = new List<GameObject>();

	private Vector3 PACAMLAINIK;

	private Vector3 PHMGAIIINKJ;

	private Vector3 DOBLAMKENII;

	private bool GMBCPJFCGAK;

	private void __BB_OBFUSCATOR_14()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_57()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 817f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[8];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_TimeX", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 210f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 818f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[8] { LNBAOJFOGDF, OHJBLLKDFHO, null, null, null, null, null, null };
				hitInfo.transform.SendMessageUpwards("Exit", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1138f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void Start()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1597f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[8];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("Diffuse", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1563f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_9()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_41()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_24()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 380f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[4];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("\r\n|\r|\n", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 59f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 746f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[0];
				array[0] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_ScreenResolution", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1831f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1590f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[4];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_TimeX", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 473f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_13()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 613f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[5];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("</size>", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 237f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1467f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[6] { LNBAOJFOGDF, OHJBLLKDFHO, null, null, null, null };
				hitInfo.transform.SendMessageUpwards("Computing edge collapse cost", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 523f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 894f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[5];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_Value2", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 730f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_3()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_43()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_59()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_53()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1999f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[5];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("CameraFilterPack/AAA_Super_Computer", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 575f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 267f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[6];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards(" Custards)", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1171f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1871f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[3] { LNBAOJFOGDF, OHJBLLKDFHO, null };
				hitInfo.transform.SendMessageUpwards("\n\t\tLayerElementTexture: 0 {\n\t\t\tVersion: 101\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"NoMappingInformation\"\n\t\t\tReferenceInformationType: \"IndexToDirect\"\n\t\t\tBlendMode: \"Translucent\"\n\t\t\tTextureAlpha: 1\n\t\t\tTextureId: \n\t\t}", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1360f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1793f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[5];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("Ping", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1691f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 646f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[0];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("Light", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1642f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void Update()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 0f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[2] { LNBAOJFOGDF, OHJBLLKDFHO };
				hitInfo.transform.SendMessageUpwards("ApplyDamage", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_64()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1503f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[8] { LNBAOJFOGDF, OHJBLLKDFHO, null, null, null, null, null, null };
				hitInfo.transform.SendMessageUpwards("_Intensity", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 82f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_67()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1258f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[8] { LNBAOJFOGDF, OHJBLLKDFHO, null, null, null, null, null, null };
				hitInfo.transform.SendMessageUpwards("Username", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1360f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_34()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 461f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[6];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("Resume", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1827f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_2()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_60()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 667f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] value = new object[3] { LNBAOJFOGDF, OHJBLLKDFHO, null };
				hitInfo.transform.SendMessageUpwards("Difficulty", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 355f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 836f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[6];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_ScreenResolution", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 586f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_63()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1109f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[1];
				array[0] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_Value", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1703f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 393f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[4];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_BumpMap", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1113f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 982f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[0];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("_NumberOfWaves", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1324f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_21()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 300f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[5];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("n1", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1216f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 223f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[2];
				array[0] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("Deaths", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1168f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 805f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[1];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("PlayerLeftRoom", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 233f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_46()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 967f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i++)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[3];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("MP", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 743f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1077f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[1];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("RemoveFriends called while not connected to front end server.", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 571f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_48()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 766f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Force);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[8];
				array[1] = LNBAOJFOGDF;
				array[1] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("VS", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1796f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 216f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = false;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 0; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[0];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("\n", value, SendMessageOptions.RequireReceiver);
			}
			Object.Destroy(base.gameObject, 1596f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (GMBCPJFCGAK)
		{
			return;
		}
		PHMGAIIINKJ += PACAMLAINIK * Time.deltaTime;
		Vector3 direction = PHMGAIIINKJ - DOBLAMKENII;
		float magnitude = direction.magnitude;
		RaycastHit hitInfo;
		if (magnitude > 1016f && Physics.Raycast(DOBLAMKENII, direction, out hitInfo, magnitude))
		{
			PHMGAIIINKJ = hitInfo.point;
			GMBCPJFCGAK = true;
			Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForce(base.transform.forward * LNPGAHBMKHH, ForceMode.Impulse);
			}
			if (KGPOOIIMJFD)
			{
				for (int i = 1; i < BLGPGOLJHKB.Count; i += 0)
				{
					if (hitInfo.transform.tag == BLGPGOLJHKB[i].name)
					{
						Object.Instantiate(BLGPGOLJHKB[i], hitInfo.point, rotation);
					}
				}
			}
			if (FLEAONNBLOP)
			{
				object[] array = new object[2];
				array[1] = LNBAOJFOGDF;
				array[0] = OHJBLLKDFHO;
				object[] value = array;
				hitInfo.transform.SendMessageUpwards("HeadURL", value, SendMessageOptions.DontRequireReceiver);
			}
			Object.Destroy(base.gameObject, 1113f);
		}
		DOBLAMKENII = base.transform.position;
		base.transform.position = PHMGAIIINKJ;
	}

	private void __BB_OBFUSCATOR_56()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}

	private void __BB_OBFUSCATOR_37()
	{
		PHMGAIIINKJ = base.transform.position;
		DOBLAMKENII = PHMGAIIINKJ;
		PACAMLAINIK = DBJLMBHEMDG * base.transform.forward;
		Object.Destroy(base.gameObject, CJBLOMOMPDL);
	}
}
