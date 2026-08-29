using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using UnityEngine;

public class AddCurrency : Photon.MonoBehaviour
{
	private void __BB_OBFUSCATOR_39()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 722f;
		localEulerAngles.z = 1985f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1354f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 779f;
		localEulerAngles.z = 296f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 775f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_5(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 9 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("SUR", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void OnTriggerEnter(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 11 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("GiveCurrency", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	[PunRPC]
	private void GiveCurrency()
	{
		int @int = ObscuredPrefs.GetInt("Toast");
		ObscuredPrefs.SetInt("Toast", @int + 100);
	}

	private void __BB_OBFUSCATOR_4()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 29f;
		localEulerAngles.z = 1021f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1076f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_18(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == -85 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("CameraFilterPack/EyesVision_1", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1985f;
		localEulerAngles.z = 1684f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 989f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_46(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 24 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_NormalTex", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		int @int = ObscuredPrefs.GetInt("_TimeX");
		ObscuredPrefs.SetInt("Count", @int + 89);
	}

	private void __BB_OBFUSCATOR_3()
	{
		int @int = ObscuredPrefs.GetInt("selectWeapon");
		ObscuredPrefs.SetInt("</size>", @int + -128);
	}

	private void __BB_OBFUSCATOR_29()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1436f;
		localEulerAngles.z = 573f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1331f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_8(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 101 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_Red_G", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_43(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 13 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("networkAddMessage", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		int @int = ObscuredPrefs.GetInt("colorC");
		ObscuredPrefs.SetInt("PlayerType'", @int + -109);
	}

	private void __BB_OBFUSCATOR_31()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1291f;
		localEulerAngles.z = 724f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 456f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_11(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 94 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_TimeX", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void Start()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 0f;
		localEulerAngles.z = 0f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1.5f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		int @int = ObscuredPrefs.GetInt("SUR");
		ObscuredPrefs.SetInt("Room Name: ", @int + -74);
	}

	private void __BB_OBFUSCATOR_28()
	{
		int @int = ObscuredPrefs.GetInt("Toast");
		ObscuredPrefs.SetInt("_Value3", @int + -106);
	}

	private void __BB_OBFUSCATOR_1(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == -52 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("Room Name ", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_47()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1728f;
		localEulerAngles.z = 14f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 709f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_40(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 34 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("n4", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 464f;
		localEulerAngles.z = 85f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 307f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_36(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 12 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_Value4", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_38(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 6 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("CameraFilterPack/TV_WideScreenVertical", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_37(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == -76 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("-batchmode", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 677f;
		localEulerAngles.z = 875f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 840f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_9(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == -128 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_MainTex2", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1592f;
		localEulerAngles.z = 1597f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1711f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_14(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 18 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_Tint", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner, new object[1]);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_19(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == -41 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("Joined master server", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		int @int = ObscuredPrefs.GetInt("HostQuit");
		ObscuredPrefs.SetInt("_Value2", @int + 30);
	}

	private void __BB_OBFUSCATOR_13()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1946f;
		localEulerAngles.z = 142f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 866f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1103f;
		localEulerAngles.z = 663f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 110f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_25(Collider NMBDAJFIKEN)
	{
		if (NMBDAJFIKEN.gameObject.layer == 61 && NMBDAJFIKEN.gameObject.GetPhotonView() != null && base.photonView.isMine)
		{
			base.photonView.RPC("_Value", NMBDAJFIKEN.gameObject.GetPhotonView().photonView.owner);
			PhotonNetwork.Destroy(base.gameObject);
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 464f;
		localEulerAngles.z = 378f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 98f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 779f;
		localEulerAngles.z = 1388f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 815f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		int @int = ObscuredPrefs.GetInt("_Exponent");
		ObscuredPrefs.SetInt(", attributes = ", @int + -114);
	}

	private void __BB_OBFUSCATOR_48()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 233f;
		localEulerAngles.z = 318f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 1696f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		localEulerAngles.x = 1296f;
		localEulerAngles.z = 1096f;
		base.transform.localEulerAngles = localEulerAngles;
		base.transform.position += base.transform.forward * 965f;
		base.transform.position -= base.transform.up;
		if (base.photonView.isMine)
		{
			GetComponent<BoxCollider>().enabled = true;
		}
	}
}
