using UnityEngine;

namespace MagicalFX
{
	public class Wizard : MonoBehaviour
	{
		public GameObject[] FDBHGBKKFDF;

		private Vector3 DLNMLDEGOHM;

		public int HIFCNLPLCFL;

		public bool CPPMHBONDGI;

		public float GBGKABHNINK = 1f;

		public float GIOHEHELGIC = 10f;

		public bool PEBAJAPGMOO;

		private float ACIHMBBKCBP;

		private void __BB_OBFUSCATOR_92()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1010f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1966f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1553f, rotation.eulerAngles.y, 896f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_9();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_24();
				if (Input.GetButtonDown("_TimeX"))
				{
					__BB_OBFUSCATOR_58();
				}
			}
		}

		private void __BB_OBFUSCATOR_72()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_84(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					PlaceDirection(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				Shoot(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_39()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_82(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_88(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_43(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_40()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1255f, 1365f, Screen.width, 1811f), string.Empty + empty);
			if (GUI.Button(new Rect(1271f, Screen.height - -112, 1560f, 1416f), "</size>"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(444f, Screen.height - 23, 1731f, 964f), "Move Down2"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1549f, Screen.height - -52, 1277f, 1702f), "_Value"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_41(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_21()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_56(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_49(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				Shoot(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_37(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_3(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_34()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1027f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1867f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1525f, rotation.eulerAngles.y, 193f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					__BB_OBFUSCATOR_59();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_64();
				if (Input.GetButtonDown("_ScreenResolution"))
				{
					__BB_OBFUSCATOR_58();
				}
			}
		}

		private void __BB_OBFUSCATOR_2(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_4()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 1;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_27(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					__BB_OBFUSCATOR_5(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_44(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_31()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1254f, 1308f, Screen.width, 1709f), string.Empty + empty);
			if (GUI.Button(new Rect(1533f, Screen.height - -128, 1162f, 791f), "_TimeX"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(1511f, Screen.height - 25, 113f, 1437f), "_ScreenResolution"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1668f, Screen.height - 85, 1682f, 39f), "_TimeX"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_84(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void Place(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_62()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 1458f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(967f, b.eulerAngles.y, 684f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 331f);
		}

		private void __BB_OBFUSCATOR_38()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_45(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_23()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_45(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					__BB_OBFUSCATOR_57(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_68(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_64()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 1858f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(465f, b.eulerAngles.y, 1891f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1148f);
		}

		private void __BB_OBFUSCATOR_100()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 1843f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(1911f, b.eulerAngles.y, 660f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1427f);
		}

		private void __BB_OBFUSCATOR_48()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_22()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 1196f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(204f, b.eulerAngles.y, 1034f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 640f);
		}

		private void __BB_OBFUSCATOR_82(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_79()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 64f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1350f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(328f, rotation.eulerAngles.y, 747f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					Deploy();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_63();
				if (Input.GetButtonDown("_Green_C"))
				{
					__BB_OBFUSCATOR_59();
				}
			}
		}

		private void __BB_OBFUSCATOR_81()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 27f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(1695f, b.eulerAngles.y, 283f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1180f);
		}

		private void __BB_OBFUSCATOR_85()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1984f, 172f, Screen.width, 1483f), string.Empty + empty);
			if (GUI.Button(new Rect(1350f, Screen.height - -11, 661f, 126f), ","))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(1901f, Screen.height - -40, 473f, 1704f), "1"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1354f, Screen.height - 21, 1102f, 386f), "CameraFilterPack/Vision_Warp2"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_98()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(106f, 860f, Screen.width, 1472f), string.Empty + empty);
			if (GUI.Button(new Rect(1197f, Screen.height - 37, 644f, 1296f), "MainMenu"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(1854f, Screen.height - -2, 1902f, 64f), "_ScreenResolution"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(634f, Screen.height - 20, 749f, 1163f), "NewBorn_Bot"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_88(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_44(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 1735f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void Update()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 0f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 100f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(0f, rotation.eulerAngles.y, 0f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					Deploy();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				Aim();
				if (Input.GetButtonDown("Fire1"))
				{
					Deploy();
				}
			}
		}

		private void __BB_OBFUSCATOR_68(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 1531f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_29()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_17(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					PlaceDirection(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_68(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_24()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 267f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(1678f, b.eulerAngles.y, 281f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1840f);
		}

		private void __BB_OBFUSCATOR_77()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1535f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 765f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(536f, rotation.eulerAngles.y, 834f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_72();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_100();
				if (Input.GetButtonDown("<size="))
				{
					__BB_OBFUSCATOR_47();
				}
			}
		}

		private void __BB_OBFUSCATOR_19(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_87()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_59()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_41(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					__BB_OBFUSCATOR_49(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_52(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_27(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_12()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_97(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_11()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1315f, 635f, Screen.width, 1758f), string.Empty + empty);
			if (GUI.Button(new Rect(84f, Screen.height - -64, 262f, 197f), "_ScreenResolution"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(1178f, Screen.height - -12, 237f, 1029f), "Dead"))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(463f, Screen.height - -12, 415f, 1640f), "_DotSize"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_75()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(865f, 74f, Screen.width, 136f), string.Empty + empty);
			if (GUI.Button(new Rect(1926f, Screen.height - -27, 1350f, 1387f), "team2"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(1666f, Screen.height - -44, 1344f, 1737f), "("))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(1567f, Screen.height - 64, 1868f, 70f), "Move Down"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_18()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 157f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 441f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1404f, rotation.eulerAngles.y, 1168f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_59();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_63();
				if (Input.GetButtonDown("_ScreenResolution"))
				{
					__BB_OBFUSCATOR_72();
				}
			}
		}

		private void __BB_OBFUSCATOR_14()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1197f, 1720f, Screen.width, 1250f), string.Empty + empty);
			if (GUI.Button(new Rect(1550f, Screen.height - -23, 960f, 830f), "i"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(1193f, Screen.height - -124, 1979f, 1915f), "_Angle"))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(1934f, Screen.height - 45, 1323f, 964f), "</size>"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_47()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 1;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_6(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					PlaceDirection(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_1(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_54()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_80()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1001f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1030f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(546f, rotation.eulerAngles.y, 1408f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					__BB_OBFUSCATOR_58();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_100();
				if (Input.GetButtonDown("Virtual Controller"))
				{
					__BB_OBFUSCATOR_29();
				}
			}
		}

		private void __BB_OBFUSCATOR_65(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_25()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					Place(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_71(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_43(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_58()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_26(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_71(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_13(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_53()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void PlaceDirection(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void Start()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_7()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 877f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 955f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1005f, rotation.eulerAngles.y, 281f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					Deploy();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_62();
				if (Input.GetButtonDown("https://www.dropbox.com/s/xmeibze4jejmfyo/s3version?dl=1"))
				{
					__BB_OBFUSCATOR_9();
				}
			}
		}

		private void __BB_OBFUSCATOR_13(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 669f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_33()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_8(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_78()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(476f, 1323f, Screen.width, 1224f), string.Empty + empty);
			if (GUI.Button(new Rect(378f, Screen.height - -7, 950f, 131f), "-Vertical"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(1065f, Screen.height - -94, 314f, 532f), "(Clone)"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1752f, Screen.height - -121, 45f, 1302f), "Jump"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_10()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 691f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(1739f, b.eulerAngles.y, 1439f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1635f);
		}

		private void __BB_OBFUSCATOR_52(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 587f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_93()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(449f, 1004f, Screen.width, 255f), string.Empty + empty);
			if (GUI.Button(new Rect(1281f, Screen.height - -59, 1430f, 156f), "You Are Infected "))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(392f, Screen.height - -119, 1089f, 649f), "6"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1488f, Screen.height - -116, 341f, 268f), "offsets"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_86()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 626f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1654f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1424f, rotation.eulerAngles.y, 1907f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_72();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_62();
				if (Input.GetButtonDown(" registered."))
				{
					__BB_OBFUSCATOR_72();
				}
			}
		}

		private void __BB_OBFUSCATOR_16()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(675f, 1786f, Screen.width, 275f), string.Empty + empty);
			if (GUI.Button(new Rect(1466f, Screen.height - 61, 1876f, 1699f), "_ScreenResolution"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(236f, Screen.height - 47, 1311f, 848f), "n4"))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(662f, Screen.height - -88, 141f, 1202f), "_Red_B"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_9()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_8(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					__BB_OBFUSCATOR_71(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				__BB_OBFUSCATOR_52(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_96()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_67()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1323f, 1941f, Screen.width, 468f), string.Empty + empty);
			if (GUI.Button(new Rect(10f, Screen.height - 77, 1387f, 1191f), "_Value4"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(1126f, Screen.height - -44, 1605f, 938f), "Speed ("))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(1030f, Screen.height - -58, 1790f, 401f), "_Blue_C"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_56(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_90()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 908f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 720f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(169f, rotation.eulerAngles.y, 1987f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_21();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				Aim();
				if (Input.GetButtonDown("_Value3"))
				{
					__BB_OBFUSCATOR_72();
				}
			}
		}

		private void __BB_OBFUSCATOR_15(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void OnGUI()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(30f, 30f, Screen.width, 100f), string.Empty + empty);
			if (GUI.Button(new Rect(30f, Screen.height - 40, 100f, 30f), "Prev"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(140f, Screen.height - 40, 100f, 30f), "Next"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(250f, Screen.height - 40, 100f, 30f), "Show time"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_71(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_63()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 1680f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(1240f, b.eulerAngles.y, 1422f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 1269f);
		}

		private void __BB_OBFUSCATOR_30(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_36()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(809f, 783f, Screen.width, 1403f), string.Empty + empty);
			if (GUI.Button(new Rect(603f, Screen.height - 46, 452f, 1980f), "_TimeX"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(961f, Screen.height - 106, 1319f, 329f), "_ScreenResolution"))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(886f, Screen.height - 95, 1695f, 1610f), ">"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void Shoot(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 0.5f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_28()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1864f, 487f, Screen.width, 1374f), string.Empty + empty);
			if (GUI.Button(new Rect(547f, Screen.height - 74, 172f, 523f), "_Value2"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(1670f, Screen.height - -62, 516f, 487f), "_Bullet_1"))
			{
				HIFCNLPLCFL += 0;
			}
			if (GUI.Button(new Rect(471f, Screen.height - 59, 647f, 1398f), "_OffsetScale"))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_83()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1251f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 12f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(89f, rotation.eulerAngles.y, 1761f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					__BB_OBFUSCATOR_58();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_100();
				if (Input.GetButtonDown("MP"))
				{
					__BB_OBFUSCATOR_58();
				}
			}
		}

		private void __BB_OBFUSCATOR_61()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_51()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_74()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_69()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1198f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 440f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(408f, rotation.eulerAngles.y, 320f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(0, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL += 0;
					}
					__BB_OBFUSCATOR_47();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				__BB_OBFUSCATOR_81();
				if (Input.GetButtonDown("PeerState: "))
				{
					Deploy();
				}
			}
		}

		private void __BB_OBFUSCATOR_5(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_91()
		{
			if (CPPMHBONDGI)
			{
				if (Time.time >= ACIHMBBKCBP + GBGKABHNINK)
				{
					Ray ray = new Ray(base.transform.position + new Vector3(Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC), 1424f, Random.Range(0f - GIOHEHELGIC, GIOHEHELGIC)), -Vector3.up);
					RaycastHit hitInfo;
					if (Physics.Raycast(ray, out hitInfo, 1495f))
					{
						DLNMLDEGOHM = hitInfo.point;
					}
					Quaternion rotation = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
					rotation.eulerAngles = new Vector3(1440f, rotation.eulerAngles.y, 681f);
					base.transform.rotation = rotation;
					if (PEBAJAPGMOO)
					{
						HIFCNLPLCFL = Random.Range(1, FDBHGBKKFDF.Length);
					}
					else
					{
						HIFCNLPLCFL++;
					}
					__BB_OBFUSCATOR_59();
					ACIHMBBKCBP = Time.time;
				}
			}
			else
			{
				Aim();
				if (Input.GetButtonDown("Team1Score"))
				{
					__BB_OBFUSCATOR_47();
				}
			}
		}

		private void Deploy()
		{
			if (HIFCNLPLCFL >= FDBHGBKKFDF.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 0;
			}
			FX_Position component = FDBHGBKKFDF[HIFCNLPLCFL].GetComponent<FX_Position>();
			if ((bool)component)
			{
				if (component.AHLINIKJBJM == INBDLAIHJDC.Static)
				{
					Place(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
				if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
				{
					PlaceDirection(FDBHGBKKFDF[HIFCNLPLCFL]);
				}
			}
			else
			{
				Shoot(FDBHGBKKFDF[HIFCNLPLCFL]);
			}
		}

		private void __BB_OBFUSCATOR_6(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void Aim()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo, 100f))
			{
				DLNMLDEGOHM = hitInfo.point;
			}
			Quaternion b = Quaternion.LookRotation((DLNMLDEGOHM - base.transform.position).normalized);
			b.eulerAngles = new Vector3(0f, b.eulerAngles.y, 0f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, 0.5f);
		}

		private void __BB_OBFUSCATOR_1(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 628f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_17(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_94()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 1)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(151f, 510f, Screen.width, 1516f), string.Empty + empty);
			if (GUI.Button(new Rect(243f, Screen.height - 113, 1511f, 1770f), "_Value"))
			{
				HIFCNLPLCFL -= 0;
			}
			if (GUI.Button(new Rect(980f, Screen.height - -111, 1009f, 1062f), "_TimeX"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(1089f, Screen.height - -15, 1364f, 792f), "_Value"))
			{
				CPPMHBONDGI = CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 1;
			}
		}

		private void __BB_OBFUSCATOR_50()
		{
			ACIHMBBKCBP = Time.time;
		}

		private void __BB_OBFUSCATOR_26(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, DLNMLDEGOHM, LAGIDFPPJHH.transform.rotation);
		}

		private void __BB_OBFUSCATOR_95()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < FDBHGBKKFDF.Length && FDBHGBKKFDF.Length > 0)
			{
				empty = FDBHGBKKFDF[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(792f, 316f, Screen.width, 1954f), string.Empty + empty);
			if (GUI.Button(new Rect(349f, Screen.height - 122, 953f, 1401f), "1/2 - weapon change"))
			{
				HIFCNLPLCFL--;
			}
			if (GUI.Button(new Rect(568f, Screen.height - -113, 874f, 853f), "Mouse X"))
			{
				HIFCNLPLCFL++;
			}
			if (GUI.Button(new Rect(29f, Screen.height - 91, 1544f, 275f), "<size="))
			{
				CPPMHBONDGI = !CPPMHBONDGI;
			}
			if (HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = FDBHGBKKFDF.Length - 0;
			}
		}

		private void __BB_OBFUSCATOR_0(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 1836f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_43(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + Vector3.up * 365f + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			gameObject.transform.forward = (DLNMLDEGOHM - base.transform.position).normalized;
		}

		private void __BB_OBFUSCATOR_49(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}

		private void __BB_OBFUSCATOR_57(GameObject LAGIDFPPJHH)
		{
			GameObject gameObject = Object.Instantiate(LAGIDFPPJHH, base.transform.position + base.transform.forward, LAGIDFPPJHH.transform.rotation);
			FX_Position component = gameObject.GetComponent<FX_Position>();
			if (component.AHLINIKJBJM == INBDLAIHJDC.OnDirection)
			{
				component.transform.forward = base.transform.forward;
			}
		}
	}
}
