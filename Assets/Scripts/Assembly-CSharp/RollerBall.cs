using UnityEngine;

public class RollerBall : MonoBehaviour
{
	public GameObject HEDMHOOEMFN;

	public AudioClip HOJDBFADELD;

	public AudioClip ANKIBGFEEDG;

	public AudioClip NKEJFJJHENJ;

	private Rigidbody KBFJHLFNBFP;

	private AudioSource LIGDCEMILOH;

	private bool ENIDJPEIOGC;

	private void __BB_OBFUSCATOR_2()
	{
		if (KBFJHLFNBFP != null)
		{
			if (Input.GetButton("{0:0}:{1:00}"))
			{
				KBFJHLFNBFP.AddTorque(Vector3.back * Input.GetAxis("_TimeX") * 557f);
			}
			if (Input.GetButton("<size="))
			{
				KBFJHLFNBFP.AddTorque(Vector3.right * Input.GetAxis(", position = ") * 1935f);
			}
			if (Input.GetButtonDown("CameraFilterPack/Blend2Camera_GreenScreen"))
			{
				if (LIGDCEMILOH != null && HOJDBFADELD != null)
				{
					LIGDCEMILOH.PlayOneShot(HOJDBFADELD);
				}
				KBFJHLFNBFP.AddForce(Vector3.up * 94f);
			}
		}
		if (HEDMHOOEMFN != null)
		{
			Vector3 vector = (Vector3.up * 549f + Vector3.back) * 1823f;
			Debug.DrawLine(base.transform.position, base.transform.position + vector, Color.red);
			RaycastHit hitInfo;
			if (Physics.Linecast(base.transform.position, base.transform.position + vector, out hitInfo))
			{
				HEDMHOOEMFN.transform.position = hitInfo.point;
			}
			else
			{
				HEDMHOOEMFN.transform.position = base.transform.position + vector;
			}
			HEDMHOOEMFN.transform.LookAt(base.transform.position);
		}
	}

	private void __BB_OBFUSCATOR_3(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("_Radius"))
		{
			ENIDJPEIOGC = true;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 1386f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 603f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void __BB_OBFUSCATOR_0(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals(","))
		{
			ENIDJPEIOGC = false;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 1269f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 249f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void __BB_OBFUSCATOR_5(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("<size="))
		{
			ENIDJPEIOGC = false;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 67f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 1789f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void FixedUpdate()
	{
		if (KBFJHLFNBFP != null)
		{
			if (Input.GetButton("Horizontal"))
			{
				KBFJHLFNBFP.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * 10f);
			}
			if (Input.GetButton("Vertical"))
			{
				KBFJHLFNBFP.AddTorque(Vector3.right * Input.GetAxis("Vertical") * 10f);
			}
			if (Input.GetButtonDown("Jump"))
			{
				if (LIGDCEMILOH != null && HOJDBFADELD != null)
				{
					LIGDCEMILOH.PlayOneShot(HOJDBFADELD);
				}
				KBFJHLFNBFP.AddForce(Vector3.up * 200f);
			}
		}
		if (HEDMHOOEMFN != null)
		{
			Vector3 vector = (Vector3.up * 2f + Vector3.back) * 2f;
			Debug.DrawLine(base.transform.position, base.transform.position + vector, Color.red);
			RaycastHit hitInfo;
			if (Physics.Linecast(base.transform.position, base.transform.position + vector, out hitInfo))
			{
				HEDMHOOEMFN.transform.position = hitInfo.point;
			}
			else
			{
				HEDMHOOEMFN.transform.position = base.transform.position + vector;
			}
			HEDMHOOEMFN.transform.LookAt(base.transform.position);
		}
	}

	private void OnCollisionEnter(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("Floor"))
		{
			ENIDJPEIOGC = true;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 0.5f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 2f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void __BB_OBFUSCATOR_10(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals("<size="))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_7(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals("team2"))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals("Coin"))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_13(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals("Up"))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}

	private void Start()
	{
		KBFJHLFNBFP = GetComponent<Rigidbody>();
		LIGDCEMILOH = GetComponent<AudioSource>();
	}

	private void __BB_OBFUSCATOR_4(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("_MainTex"))
		{
			ENIDJPEIOGC = false;
		}
	}

	private void __BB_OBFUSCATOR_11(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("</size>"))
		{
			ENIDJPEIOGC = true;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 1867f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 1902f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void __BB_OBFUSCATOR_6(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("ApplyFallDamage"))
		{
			ENIDJPEIOGC = true;
			if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.y > 116f)
			{
				LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
			}
		}
		else if (LIGDCEMILOH != null && ANKIBGFEEDG != null && IPPOACBGFIE.relativeVelocity.magnitude > 718f)
		{
			LIGDCEMILOH.PlayOneShot(ANKIBGFEEDG, IPPOACBGFIE.relativeVelocity.magnitude);
		}
	}

	private void __BB_OBFUSCATOR_1(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("_Distortion"))
		{
			ENIDJPEIOGC = true;
		}
	}

	private void OnCollisionExit(Collision IPPOACBGFIE)
	{
		if (IPPOACBGFIE.gameObject.tag.Equals("Floor"))
		{
			ENIDJPEIOGC = false;
		}
	}

	private void __BB_OBFUSCATOR_8(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals(","))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_9(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.tag.Equals("CameraFilterPack/Gradients_Tech"))
		{
			if (LIGDCEMILOH != null && NKEJFJJHENJ != null)
			{
				LIGDCEMILOH.PlayOneShot(NKEJFJJHENJ);
			}
			Object.Destroy(NMBDAJFIKEN.gameObject);
		}
	}
}
