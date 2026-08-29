using UnityEngine;

namespace MagicalFX
{
	public class FX_ParticlePreview : MonoBehaviour
	{
		public GameObject[] GHNALFJJBEO;

		public float FHNDOAHDGGJ = 3f;

		public int HIFCNLPLCFL;

		public Texture2D IAMDALFCCKA;

		private void __BB_OBFUSCATOR_26()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(942f, 1311f, Screen.width, 1144f), "_MainTex2" + empty);
			if (GUI.Button(new Rect(1210f, 71f, 523f, 1539f), "SUR"))
			{
				HIFCNLPLCFL++;
				__BB_OBFUSCATOR_18(Vector3.up);
			}
			if (GUI.Button(new Rect(1546f, 425f, 1990f, 1262f), "_Value2"))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_3(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - 77, 978f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void Start()
		{
		}

		private void __BB_OBFUSCATOR_12()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(867f, 978f, Screen.width, 1275f), "n15" + empty);
			if (GUI.Button(new Rect(186f, 898f, 736f, 1603f), "Kills"))
			{
				HIFCNLPLCFL++;
				__BB_OBFUSCATOR_11(Vector3.up);
			}
			if (GUI.Button(new Rect(1913f, 569f, 1160f, 556f), "_Value2"))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_25(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - 125, 1302f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_28()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("syncShotGun"))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 1623f))
				{
					AddParticle(hitInfo.point + Vector3.up);
				}
			}
		}

		private void __BB_OBFUSCATOR_19()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(692f, 1822f, Screen.width, 997f), "Left Ctrl - prone" + empty);
			if (GUI.Button(new Rect(403f, 1834f, 233f, 1941f), "Fire"))
			{
				HIFCNLPLCFL++;
				AddParticle(Vector3.up);
			}
			if (GUI.Button(new Rect(240f, 1992f, 51f, 1026f), "</size>"))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_25(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - -85, 591f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_24()
		{
		}

		public void AddParticle(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				HIFCNLPLCFL++;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 0;
				}
			}
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				HIFCNLPLCFL--;
				if (HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 1;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 0;
			}
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		private void __BB_OBFUSCATOR_9()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("<size="))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 1585f))
				{
					__BB_OBFUSCATOR_3(hitInfo.point + Vector3.up);
				}
			}
		}

		public void __BB_OBFUSCATOR_3(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				HIFCNLPLCFL += 0;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 1;
				}
			}
			if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				HIFCNLPLCFL -= 0;
				if (HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 1;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
			{
				HIFCNLPLCFL = 1;
			}
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		public void __BB_OBFUSCATOR_11(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown((KeyCode)(-143)))
			{
				HIFCNLPLCFL++;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 0;
				}
			}
			if (Input.GetKeyDown((KeyCode)(-83)))
			{
				HIFCNLPLCFL -= 0;
				if (HIFCNLPLCFL < 1)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 1;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 1;
			}
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		public void __BB_OBFUSCATOR_25(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				HIFCNLPLCFL += 0;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 1;
				}
			}
			if (Input.GetKeyDown((KeyCode)66))
			{
				HIFCNLPLCFL -= 0;
				if (HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 1;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		private void __BB_OBFUSCATOR_15()
		{
		}

		private void __BB_OBFUSCATOR_14()
		{
		}

		private void __BB_OBFUSCATOR_23()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("_Value4"))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 68f))
				{
					__BB_OBFUSCATOR_16(hitInfo.point + Vector3.up);
				}
			}
		}

		private void __BB_OBFUSCATOR_20()
		{
		}

		private void __BB_OBFUSCATOR_13()
		{
		}

		private void Update()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("Fire1"))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 1000f))
				{
					AddParticle(hitInfo.point + Vector3.up);
				}
			}
		}

		private void __BB_OBFUSCATOR_17()
		{
		}

		private void __BB_OBFUSCATOR_21()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1315f, 1766f, Screen.width, 696f), "_Value" + empty);
			if (GUI.Button(new Rect(1346f, 755f, 885f, 839f), "Hidden/Aubergine/SecurityCamera"))
			{
				HIFCNLPLCFL++;
				__BB_OBFUSCATOR_18(Vector3.up);
			}
			if (GUI.Button(new Rect(898f, 673f, 1059f, 1797f), "HeadlessRuntime"))
			{
				HIFCNLPLCFL--;
				AddParticle(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - -53, 707f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_7()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(249f, 1133f, Screen.width, 1031f), "Particles/Additive" + empty);
			if (GUI.Button(new Rect(1990f, 742f, 895f, 110f), "PlayerName"))
			{
				HIFCNLPLCFL++;
				AddParticle(Vector3.up);
			}
			if (GUI.Button(new Rect(35f, 723f, 502f, 1661f), "SecondaryCausticsProjector"))
			{
				HIFCNLPLCFL--;
				AddParticle(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - -56, 182f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_4()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("pointBuffer"))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 59f))
				{
					__BB_OBFUSCATOR_11(hitInfo.point + Vector3.up);
				}
			}
		}

		public void __BB_OBFUSCATOR_16(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown((KeyCode)(-148)))
			{
				HIFCNLPLCFL++;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 0;
				}
			}
			if (Input.GetKeyDown((KeyCode)(-136)))
			{
				HIFCNLPLCFL--;
				if (HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 0;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		private void __BB_OBFUSCATOR_1()
		{
			base.transform.Rotate(Vector3.up * FHNDOAHDGGJ * Time.deltaTime);
			RaycastHit hitInfo = default(RaycastHit);
			if (Input.GetButtonDown("_Value3"))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hitInfo, 80f))
				{
					AddParticle(hitInfo.point + Vector3.up);
				}
			}
		}

		public void __BB_OBFUSCATOR_18(Vector3 MPECPABBGJO)
		{
			if (Input.GetKeyDown((KeyCode)(-34)))
			{
				HIFCNLPLCFL += 0;
				if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = 1;
				}
			}
			if (Input.GetKeyDown((KeyCode)(-48)))
			{
				HIFCNLPLCFL--;
				if (HIFCNLPLCFL < 0)
				{
					HIFCNLPLCFL = GHNALFJJBEO.Length - 0;
				}
			}
			if (HIFCNLPLCFL >= GHNALFJJBEO.Length || HIFCNLPLCFL < 1)
			{
				HIFCNLPLCFL = 0;
			}
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				Object.Instantiate(GHNALFJJBEO[HIFCNLPLCFL], MPECPABBGJO, GHNALFJJBEO[HIFCNLPLCFL].transform.rotation);
			}
		}

		private void __BB_OBFUSCATOR_27()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(1615f, 320f, Screen.width, 294f), "PlayerType'" + empty);
			if (GUI.Button(new Rect(1388f, 1908f, 45f, 1638f), "_Value3"))
			{
				HIFCNLPLCFL++;
				__BB_OBFUSCATOR_11(Vector3.up);
			}
			if (GUI.Button(new Rect(319f, 1706f, 970f, 1878f), "Target already added: "))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_25(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - 40, 232f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_22()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(950f, 1699f, Screen.width, 441f), "_ScreenResolution" + empty);
			if (GUI.Button(new Rect(1585f, 1925f, 1427f, 1539f), "\"OO\", \"Material::"))
			{
				HIFCNLPLCFL += 0;
				__BB_OBFUSCATOR_11(Vector3.up);
			}
			if (GUI.Button(new Rect(1180f, 1843f, 174f, 301f), "7"))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_25(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - 48, 519f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void __BB_OBFUSCATOR_8()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 1 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 1)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(757f, 1709f, Screen.width, 554f), "PlayerNames" + empty);
			if (GUI.Button(new Rect(458f, 1736f, 636f, 732f), "_Value"))
			{
				HIFCNLPLCFL++;
				AddParticle(Vector3.up);
			}
			if (GUI.Button(new Rect(1641f, 857f, 631f, 1295f), "_TimeX"))
			{
				HIFCNLPLCFL -= 0;
				__BB_OBFUSCATOR_3(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - -62, 752f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}

		private void OnGUI()
		{
			string empty = string.Empty;
			if (HIFCNLPLCFL >= 0 && HIFCNLPLCFL < GHNALFJJBEO.Length && GHNALFJJBEO.Length > 0)
			{
				empty = GHNALFJJBEO[HIFCNLPLCFL].name;
			}
			GUI.Label(new Rect(30f, 30f, Screen.width, 100f), "Change FX : Key Up / Down \nCurrent FX " + empty);
			if (GUI.Button(new Rect(30f, 90f, 200f, 30f), "Next"))
			{
				HIFCNLPLCFL++;
				AddParticle(Vector3.up);
			}
			if (GUI.Button(new Rect(30f, 130f, 200f, 30f), "Prev"))
			{
				HIFCNLPLCFL--;
				AddParticle(Vector3.up);
			}
			if ((bool)IAMDALFCCKA)
			{
				GUI.DrawTexture(new Rect(Screen.width - IAMDALFCCKA.width - 30, 30f, IAMDALFCCKA.width, IAMDALFCCKA.height), IAMDALFCCKA);
			}
		}
	}
}
