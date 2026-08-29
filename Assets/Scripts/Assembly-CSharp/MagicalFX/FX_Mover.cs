using UnityEngine;

namespace MagicalFX
{
	[RequireComponent(typeof(Rigidbody))]
	public class FX_Mover : MonoBehaviour
	{
		public float FFNHINFPDBA = 1f;

		public Vector3 INLKNGDBLPI = Vector3.zero;

		public float PFPNLJFBFOL = 0.3f;

		private Quaternion INBMDEIBLKA;

		private void __BB_OBFUSCATOR_10()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 1452f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void __BB_OBFUSCATOR_1()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 1333f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void __BB_OBFUSCATOR_3()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 404f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void Start()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 1000f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void __BB_OBFUSCATOR_0()
		{
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, INBMDEIBLKA, PFPNLJFBFOL);
			base.transform.position += base.transform.forward * FFNHINFPDBA * Time.deltaTime;
		}

		private void __BB_OBFUSCATOR_6()
		{
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, INBMDEIBLKA, PFPNLJFBFOL);
			base.transform.position += base.transform.forward * FFNHINFPDBA * Time.deltaTime;
		}

		private void __BB_OBFUSCATOR_7()
		{
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, INBMDEIBLKA, PFPNLJFBFOL);
			base.transform.position += base.transform.forward * FFNHINFPDBA * Time.deltaTime;
		}

		private void __BB_OBFUSCATOR_8()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 1264f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void __BB_OBFUSCATOR_4()
		{
			INBMDEIBLKA = Quaternion.LookRotation(base.transform.forward * 589f);
			base.transform.Rotate(new Vector3(Random.Range(0f - INLKNGDBLPI.x, INLKNGDBLPI.x), Random.Range(0f - INLKNGDBLPI.y, INLKNGDBLPI.y), Random.Range(0f - INLKNGDBLPI.z, INLKNGDBLPI.z)));
		}

		private void LateUpdate()
		{
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, INBMDEIBLKA, PFPNLJFBFOL);
			base.transform.position += base.transform.forward * FFNHINFPDBA * Time.deltaTime;
		}
	}
}
