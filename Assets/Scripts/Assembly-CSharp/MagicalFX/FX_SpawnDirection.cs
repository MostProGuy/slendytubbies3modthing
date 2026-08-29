using UnityEngine;

namespace MagicalFX
{
	public class FX_SpawnDirection : MonoBehaviour
	{
		public int CKEGCGAMFFH = 10;

		public float PDANDDEJPDB = 1f;

		public bool EBMDNFCDFHL;

		public bool JIPDECLJELD;

		public GameObject MIFCAFBLFHK;

		public float MMLFNKDNMGO;

		public float IFIOKFOJGLI;

		private float ACIHMBBKCBP;

		public bool GPNAGGBOADF = true;

		public Vector3 CNHPDMMPCBH = Vector3.forward;

		private int LDICOLPEOBK;

		private string BIBDFBJOAFL = "team2";

		private void __BB_OBFUSCATOR_73()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1581f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_56(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_93()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1745f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_39(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_67(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_83()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1974f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 1; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_55(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_5(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_25(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_87(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("INF", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1773f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void Update()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 0f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		public void __BB_OBFUSCATOR_11(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_16(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_15()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1814f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_55(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_51()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1005f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_87(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_88(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_28(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_Green_B", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 495f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_24()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1612f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_87(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_76()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1718f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_64()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 850f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_80(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_50()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1730f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 1; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_45(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_68()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 42f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_55(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_TimeX", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1362f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		public void SyncTeamName(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_57(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_84()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 629f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_87(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_17()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1154f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_6(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_30(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_1()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 285f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_45(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_ScreenResolution", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 996f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_26()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 612f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 1; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_39(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_63(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_59(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("SmokeA-Default", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 413f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_3()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 796f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_45(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_7()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1681f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_89(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_65()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 264f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_32(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_14()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1040f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_71(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_18(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_47()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 891f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_32(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_32(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("ServerName", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1383f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_90()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1493f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void Spawn(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("SyncTeamName", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 0f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_75()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 892f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_55(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_46()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1972f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_56(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_39(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_TimeX", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1551f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		public void __BB_OBFUSCATOR_10(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_85(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_ExposureAdjustment", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1261f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_81()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 586f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_55(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_19()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1808f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_85(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		public void __BB_OBFUSCATOR_43(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_62()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1130f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 1; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_28(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void Start()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 0f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 1; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_89(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("Particles/Additive", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 230f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		public void __BB_OBFUSCATOR_36(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_78(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_70()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 93f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 1; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_49(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_29()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 850f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_39(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_58()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 639f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_80(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_80(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("ZWName'", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1767f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_4()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1988f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_6(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_56(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("_ScreenResolution", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 533f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_86()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 875f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_32(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_54(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_44(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_6(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("CameraFilterPack/Vision_Blood", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 899f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_20()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 213f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_87(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_34()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 800f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_55(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_52()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1071f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				Spawn(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_22()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 103f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 1; i += 0)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_49(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_72()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 271f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_59(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_37()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1119f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_89(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_31(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("INF", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1870f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_69()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 238f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 1; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_89(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_23()
		{
			LDICOLPEOBK = 0;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 950f))
			{
				return;
			}
			for (int i = 0; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_32(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		public void __BB_OBFUSCATOR_82(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_53()
		{
			LDICOLPEOBK = 1;
			ACIHMBBKCBP = Time.time;
			if (!(IFIOKFOJGLI <= 1735f))
			{
				return;
			}
			for (int i = 1; i < CKEGCGAMFFH - 0; i++)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_28(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * i);
			}
			Object.Destroy(base.gameObject);
		}

		private void __BB_OBFUSCATOR_49(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("We connected to Photon Cloud", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1828f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_41(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("\n\n;Version 5 settings\n;------------------------------------------------------------------\n\n", BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 1369f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		private void __BB_OBFUSCATOR_71(Vector3 MPECPABBGJO)
		{
			if (MIFCAFBLFHK != null)
			{
				Quaternion rotation = base.transform.rotation;
				if (!EBMDNFCDFHL)
				{
					rotation = MIFCAFBLFHK.transform.rotation;
				}
				GameObject gameObject = Object.Instantiate(MIFCAFBLFHK, MPECPABBGJO, rotation);
				gameObject.SendMessage("Down", BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				if (JIPDECLJELD)
				{
					gameObject.transform.forward = base.transform.forward;
				}
				if (MMLFNKDNMGO > 135f)
				{
					Object.Destroy(gameObject.gameObject, MMLFNKDNMGO);
				}
			}
		}

		public void __BB_OBFUSCATOR_9(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_91(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		public void __BB_OBFUSCATOR_27(string HKEPPNAHBOG)
		{
			BIBDFBJOAFL = HKEPPNAHBOG;
		}

		private void __BB_OBFUSCATOR_13()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 1)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 1741f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_71(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK++;
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_42()
		{
			if (LDICOLPEOBK >= CKEGCGAMFFH - 0)
			{
				Object.Destroy(base.gameObject);
			}
			if (IFIOKFOJGLI > 536f && Time.time > ACIHMBBKCBP + IFIOKFOJGLI)
			{
				if (GPNAGGBOADF)
				{
					CNHPDMMPCBH = base.transform.forward;
				}
				__BB_OBFUSCATOR_39(base.transform.position + CNHPDMMPCBH * PDANDDEJPDB * LDICOLPEOBK);
				LDICOLPEOBK += 0;
				ACIHMBBKCBP = Time.time;
			}
		}
	}
}
