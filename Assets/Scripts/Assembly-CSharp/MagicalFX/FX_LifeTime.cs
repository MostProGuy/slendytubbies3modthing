using UnityEngine;

namespace MagicalFX
{
	public class FX_LifeTime : MonoBehaviour
	{
		public float MMLFNKDNMGO = 3f;

		public GameObject OJLLCLJBPEM;

		private float ACIHMBBKCBP;

		private void __BB_OBFUSCATOR_17()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("UseFlashlight", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void Update()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("SyncTeamName", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_47()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_31()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("Particles/Additive", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_54()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_9()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("\"OO\", \"Model::", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_10()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("Difficulty", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_38()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("The shader ", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_39()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_13()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_27()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_3()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_45()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_56()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_4()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_PositionY", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_42()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_11()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("CameraFilterPack/TV_Old_Movie_2", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_1()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("We connected to Photon Cloud", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_23()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("WARNING: 'MeshTK.ExportTools.MeshToObjString()' is obsolete. Use MeshTK.ObjTools.ExportToString().", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_0()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_21()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_Value4", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void Start()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_22()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage(" min", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_28()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_51()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("TeamName", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_49()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_Greenness", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_53()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("TDM", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_58()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_ScreenResolution", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_46()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_CenterY", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_40()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_15()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("Horizontal", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_18()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_19()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_Saturation", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_6()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_2()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_MainTex", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_20()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_Value4", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_33()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("Floor", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_8()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}

		private void __BB_OBFUSCATOR_24()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("usemap ", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_25()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_TimeX", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_14()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_Value4", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.RequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_7()
		{
			if (OJLLCLJBPEM != null && Time.time > ACIHMBBKCBP + MMLFNKDNMGO)
			{
				Object.Destroy(base.gameObject);
				GameObject gameObject = Object.Instantiate(OJLLCLJBPEM, base.transform.position, OJLLCLJBPEM.transform.rotation);
				if (GetComponent<ExplosionDamage>() != null)
				{
					gameObject.SendMessage("_TimeX", GetComponent<ExplosionDamage>().BIBDFBJOAFL, SendMessageOptions.DontRequireReceiver);
				}
			}
		}

		private void __BB_OBFUSCATOR_37()
		{
			if (OJLLCLJBPEM == null)
			{
				Object.Destroy(base.gameObject, MMLFNKDNMGO);
			}
			else
			{
				ACIHMBBKCBP = Time.time;
			}
		}
	}
}
