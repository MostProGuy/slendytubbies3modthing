using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class LadderPlayer : Photon.MonoBehaviour
{
	public float JJNOKIPBEPK = 6f;

	public float GGCLNIDGGAN = -0.4f;

	private Vector3 EIHAPAMDGLM = Vector3.zero;

	private Vector3 DCJAKIPNCLC = Vector3.zero;

	private Vector3 NDDFMLLCBIH = Vector3.zero;

	private Ladder HKMEKOPAFNL;

	private bool CJMDDPHFCPE;

	private bool CGFNJCPAIID;

	private GameObject ADDGNCLMHPK;

	private CharacterController OJNKMBPLGJI;

	private bool MDBNLBMNEPP;

	public void __BB_OBFUSCATOR_15(Ladder GNHPHIAOFHG)
	{
		HKMEKOPAFNL = GNHPHIAOFHG;
		CJMDDPHFCPE = false;
		EIHAPAMDGLM = HKMEKOPAFNL.__BB_OBFUSCATOR_0();
		base.gameObject.SendMessage("SBX", null, SendMessageOptions.DontRequireReceiver);
		MDBNLBMNEPP = false;
	}

	public void __BB_OBFUSCATOR_12(Ladder GNHPHIAOFHG)
	{
		HKMEKOPAFNL = GNHPHIAOFHG;
		CJMDDPHFCPE = false;
		EIHAPAMDGLM = HKMEKOPAFNL.__BB_OBFUSCATOR_38();
		base.gameObject.SendMessage("{0}{1}{2}={3}", null, SendMessageOptions.DontRequireReceiver);
		MDBNLBMNEPP = false;
	}

	public void LatchLadder(Ladder GNHPHIAOFHG)
	{
		HKMEKOPAFNL = GNHPHIAOFHG;
		CJMDDPHFCPE = true;
		EIHAPAMDGLM = HKMEKOPAFNL.ClimbDirection();
		base.gameObject.SendMessage("OnLadder", null, SendMessageOptions.RequireReceiver);
		MDBNLBMNEPP = true;
	}

	private void Start()
	{
		ADDGNCLMHPK = Camera.main.gameObject;
		OJNKMBPLGJI = GetComponent<CharacterController>();
		if (!base.photonView.isMine)
		{
			return;
		}
		switch (ObscuredPrefs.GetString("PlayerType'"))
		{
		case "8":
		case "3":
		case "6":
			if (GameObject.Find("HelpMenu") == null)
			{
				GameObject gameObject = PhotonNetwork.Instantiate("HelpMenu", base.transform.position, base.transform.rotation, 0);
				gameObject.transform.parent = base.transform;
				gameObject.transform.localPosition = Vector3.zero;
			}
			break;
		}
	}

	private void UnlatchLadder()
	{
		CJMDDPHFCPE = false;
		HKMEKOPAFNL = null;
		MDBNLBMNEPP = false;
		base.gameObject.SendMessage("OffLadder", NDDFMLLCBIH, SendMessageOptions.RequireReceiver);
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				__BB_OBFUSCATOR_5();
			}
			if (Input.GetKey((KeyCode)4))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("OnJump");
			normalized *= (float)((ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN) ? 1 : (-1));
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("CameraFilterPack/Color_Contrast"), 559f, Input.GetAxis("/"));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Network"), 1767f, 291f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				__BB_OBFUSCATOR_5();
			}
			if (Input.GetKey(KeyCode.BackQuote))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("CameraFilterPack/FX_Screens");
			normalized *= (float)((ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN) ? 1 : (-1));
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis(" "), 430f, Input.GetAxis(" "));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("_Value3"), 553f, 735f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				__BB_OBFUSCATOR_5();
			}
			if (Input.GetKey(KeyCode.Alpha5))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("Language");
			normalized *= (float)((ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN) ? 1 : (-1));
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Shockwave-Default"), 1668f, Input.GetAxis("<size=16><color=red>[KICK]</color> "));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("_Value2"), 1243f, 451f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		Vector3 vector = base.transform.position + OJNKMBPLGJI.center + Vector3.up * ((0f - OJNKMBPLGJI.height) * 998f);
		Vector3 point = vector + Vector3.up * OJNKMBPLGJI.height;
		RaycastHit hitInfo;
		if (!Physics.CapsuleCast(vector, point, OJNKMBPLGJI.radius, base.transform.forward, out hitInfo, OJNKMBPLGJI.radius))
		{
			UnlatchLadder();
		}
	}

	public void __BB_OBFUSCATOR_11(Ladder GNHPHIAOFHG)
	{
		HKMEKOPAFNL = GNHPHIAOFHG;
		CJMDDPHFCPE = true;
		EIHAPAMDGLM = HKMEKOPAFNL.__BB_OBFUSCATOR_24();
		base.gameObject.SendMessage("_threshold", null, SendMessageOptions.DontRequireReceiver);
		MDBNLBMNEPP = false;
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				__BB_OBFUSCATOR_0();
			}
			if (Input.GetKey((KeyCode)(-47)))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("_Blue_C");
			normalized *= (float)((!(ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN)) ? (-1) : 0);
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Jump"), 434f, Input.GetAxis("Private"));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Idle"), 298f, 1024f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		ADDGNCLMHPK = Camera.main.gameObject;
		OJNKMBPLGJI = GetComponent<CharacterController>();
		if (!base.photonView.isMine)
		{
			return;
		}
		switch (ObscuredPrefs.GetString("PlayerName"))
		{
		case "><color=grey>":
		case "SyncTeamName":
		case "_Value6":
			if (GameObject.Find("CameraFilterPack/Distortion_Water_Drop") == null)
			{
				GameObject gameObject = PhotonNetwork.Instantiate("_Value2", base.transform.position, base.transform.rotation, 0);
				gameObject.transform.parent = base.transform;
				gameObject.transform.localPosition = Vector3.zero;
			}
			break;
		}
	}

	public void __BB_OBFUSCATOR_7(Ladder GNHPHIAOFHG)
	{
		HKMEKOPAFNL = GNHPHIAOFHG;
		CJMDDPHFCPE = false;
		EIHAPAMDGLM = HKMEKOPAFNL.__BB_OBFUSCATOR_8();
		base.gameObject.SendMessage("_bump\", \"\" {\n\t\tType: \"TextureVideoClip\"\n\t\tVersion: 202\n\t\tTextureName: \"Texture::", null, SendMessageOptions.RequireReceiver);
		MDBNLBMNEPP = true;
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				__BB_OBFUSCATOR_0();
			}
			if (Input.GetKey((KeyCode)(-100)))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("TeamName");
			normalized *= (float)((ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN) ? 1 : (-1));
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("<color="), 937f, Input.GetAxis("</size>"));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Connect"), 145f, 240f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void FixedUpdate()
	{
		if (CJMDDPHFCPE)
		{
			if (MDBNLBMNEPP)
			{
				RaycastCheck();
			}
			if (Input.GetKey(KeyCode.Space))
			{
				UnlatchLadder();
			}
			Vector3 normalized = EIHAPAMDGLM.normalized;
			normalized *= Input.GetAxis("Vertical");
			normalized *= (float)((ADDGNCLMHPK.transform.forward.y > GGCLNIDGGAN) ? 1 : (-1));
			if (CGFNJCPAIID)
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			}
			else
			{
				DCJAKIPNCLC = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
			}
			DCJAKIPNCLC = base.transform.TransformDirection(DCJAKIPNCLC);
			NDDFMLLCBIH = normalized + DCJAKIPNCLC;
			OJNKMBPLGJI.Move(NDDFMLLCBIH * JJNOKIPBEPK * Time.deltaTime);
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		Vector3 vector = base.transform.position + OJNKMBPLGJI.center + Vector3.up * ((0f - OJNKMBPLGJI.height) * 1755f);
		Vector3 point = vector + Vector3.up * OJNKMBPLGJI.height;
		RaycastHit hitInfo;
		if (!Physics.CapsuleCast(vector, point, OJNKMBPLGJI.radius, base.transform.forward, out hitInfo, OJNKMBPLGJI.radius))
		{
			UnlatchLadder();
		}
	}

	private void RaycastCheck()
	{
		Vector3 vector = base.transform.position + OJNKMBPLGJI.center + Vector3.up * ((0f - OJNKMBPLGJI.height) * 0.5f);
		Vector3 point = vector + Vector3.up * OJNKMBPLGJI.height;
		RaycastHit hitInfo;
		if (!Physics.CapsuleCast(vector, point, OJNKMBPLGJI.radius, base.transform.forward, out hitInfo, OJNKMBPLGJI.radius))
		{
			UnlatchLadder();
		}
	}
}
