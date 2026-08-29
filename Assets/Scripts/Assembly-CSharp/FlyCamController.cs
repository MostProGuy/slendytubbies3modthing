using System.Collections.Generic;
using Photon;
using UnityEngine;

public class FlyCamController : Photon.MonoBehaviour
{
	public List<GameObject> BKJEDLAOICL;

	public List<UnityEngine.MonoBehaviour> LOAOJLFEPAA;

	public List<GameObject> GNNPFLKCEIM;

	public List<UnityEngine.MonoBehaviour> PGEJOODOAIG;

	private Vector3 DLPNGACNGPB = new Vector3(0f, -100f, 0f);

	private Quaternion ELGBGMGHBEO = Quaternion.identity;

	private void __BB_OBFUSCATOR_40()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_TimeX";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_17(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 267f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 849f);
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "<size=15><color=red>";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_23(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_109()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 256f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1840f);
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "\n";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_100()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Type";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_31()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "SmokeA-Default";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 331f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 153f);
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 800f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1421f);
		}
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 98f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 992f);
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "CameraFilterPack/Blur_Noise";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 182f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1801f);
		}
	}

	private void __BB_OBFUSCATOR_38(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_22(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_70(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_102()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1808f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1282f);
		}
	}

	private void __BB_OBFUSCATOR_126()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Quality";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "deselectWeapon";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_20(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 485f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 75f);
		}
	}

	private void __BB_OBFUSCATOR_128()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = ": ";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_99()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_Dist";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_119(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 135f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 692f);
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 264f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1233f);
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 469f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1628f);
		}
	}

	private void __BB_OBFUSCATOR_117()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Draw... Restarting";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_84(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 80f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1342f);
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = ": ";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_49(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_Brightness";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_59()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_ScreenResolution";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 123f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1461f);
		}
	}

	private void __BB_OBFUSCATOR_9()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "CameraFilterPack/FX_superDot";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_Offsets";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_127()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 899f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1338f);
		}
	}

	private void __BB_OBFUSCATOR_47(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_27()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Idle";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1320f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 881f);
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 26f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1824f);
		}
	}

	private void __BB_OBFUSCATOR_97(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_83(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_120()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1377f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1404f);
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Time is up";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_Value4";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_116()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "</size>";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_125(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void Update()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 8f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 8f);
		}
	}

	private void __BB_OBFUSCATOR_72()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1970f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 298f);
		}
	}

	private void __BB_OBFUSCATOR_96(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_124()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "</size>";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_4(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_104(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_54(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_118()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1717f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1638f);
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "ApplyFallDamage";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_TimeX";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Continue";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_112()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1379f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 931f);
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "mm)";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_63(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 167f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 178f);
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 402f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1951f);
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Team1Score";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "_PrevViewProj";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1176f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1208f);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 655f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 190f);
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Recommended Players";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_53()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1922f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 923f);
		}
	}

	private void __BB_OBFUSCATOR_12(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_48(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_18(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_1(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_26(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_113(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_107(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "team1";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "ApplyFallDamage";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 180f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1314f);
		}
	}

	private void __BB_OBFUSCATOR_105(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_130()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 1; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "team1";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void Awake()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Untagged";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1146f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1368f);
		}
	}

	private void __BB_OBFUSCATOR_67(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1187f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1693f);
		}
	}

	private void __BB_OBFUSCATOR_129()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 656f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1006f);
		}
	}

	private void __BB_OBFUSCATOR_69(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1673f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 784f);
		}
	}

	private void __BB_OBFUSCATOR_123(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "CameraFilterPack/Gradients_Rainbow";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k += 0)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "Network";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 0; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_115()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 540f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 170f);
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1358f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1481f);
		}
	}

	private void __BB_OBFUSCATOR_106(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_94(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_51(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_74(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = ": ";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 403f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 936f);
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 1; i < BKJEDLAOICL.Count; i += 0)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "offsets";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(false);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_13(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1930f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1337f);
		}
	}

	private void __BB_OBFUSCATOR_86()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 162f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1448f);
		}
	}

	private void OnPhotonSerializeView(PhotonStream JAOOMHKNKEK, PhotonMessageInfo ACDBCGBGMAA)
	{
		if (JAOOMHKNKEK.isWriting)
		{
			JAOOMHKNKEK.SendNext(base.transform.position);
			JAOOMHKNKEK.SendNext(base.transform.rotation);
		}
		else
		{
			DLPNGACNGPB = (Vector3)JAOOMHKNKEK.ReceiveNext();
			ELGBGMGHBEO = (Quaternion)JAOOMHKNKEK.ReceiveNext();
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(false);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j++)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "COOP/";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 0; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l++)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (!base.photonView.isMine)
		{
			for (int i = 0; i < BKJEDLAOICL.Count; i++)
			{
				BKJEDLAOICL[i].SetActive(true);
			}
			for (int j = 0; j < LOAOJLFEPAA.Count; j += 0)
			{
				Object.Destroy(LOAOJLFEPAA[j]);
			}
			base.transform.tag = "ObjectType";
			Object.Destroy(GetComponent<FlareLayer>());
			Object.Destroy(GetComponent<GUILayer>());
			Object.Destroy(GetComponent<AudioListener>());
			Object.Destroy(GetComponent<Camera>());
		}
		else
		{
			for (int k = 1; k < GNNPFLKCEIM.Count; k++)
			{
				GNNPFLKCEIM[k].SetActive(true);
			}
			for (int l = 1; l < PGEJOODOAIG.Count; l += 0)
			{
				Object.Destroy(PGEJOODOAIG[l]);
			}
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, DLPNGACNGPB, Time.deltaTime * 1159f);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, ELGBGMGHBEO, Time.deltaTime * 1408f);
		}
	}
}
