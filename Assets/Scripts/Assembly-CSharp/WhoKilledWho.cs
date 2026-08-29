using System.Collections.Generic;
using System.Runtime.InteropServices;
using Photon;
using UnityEngine;

public class WhoKilledWho : Photon.MonoBehaviour
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct WhoKillWho
	{
		public string killer { get; set; }

		public string killed { get; set; }

		public string middleText { get; set; }

		public Color killerColor { get; set; }

		public Color killedColor { get; set; }

		public float timer { get; set; }

		public WhoKillWho(string string1, string string2, string string3, Color color1, Color color2, float timer1)
		{
			killer = string1;
			killed = string2;
			middleText = string3;
			killerColor = color1;
			killedColor = color2;
			timer = timer1;
		}
	}

	public GUISkin guiSkin;

	public List<WhoKillWho> whoKillWho = new List<WhoKillWho>();

	private RoomMultiplayerMenu rmm;

	private void Start()
	{
		rmm = base.gameObject.GetComponent<RoomMultiplayerMenu>();
		if (PhotonNetwork.room != null)
		{
			PlayerJoinedRoom();
		}
	}

	private void Update()
	{
		for (int i = 0; i < this.whoKillWho.Count; i++)
		{
			WhoKillWho whoKillWho = this.whoKillWho[i];
			whoKillWho.timer -= Time.deltaTime;
			if (whoKillWho.timer > 0f)
			{
				this.whoKillWho[i] = new WhoKillWho(whoKillWho.killer, whoKillWho.killed, whoKillWho.middleText, whoKillWho.killerColor, whoKillWho.killedColor, whoKillWho.timer);
			}
			else
			{
				this.whoKillWho.RemoveAt(i);
			}
		}
	}

	private void OnGUI()
	{
		GUI.skin = guiSkin;
		GUILayout.BeginArea(new Rect((float)Screen.width - (float)Screen.width / 3.5f, 85f, (float)Screen.width / 3.5f, 400f));
		foreach (WhoKillWho item in whoKillWho)
		{
			GUI.color = new Color(1f, 1f, 1f, 0.65f);
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUI.color = item.killerColor;
			GUILayout.Label(item.killer);
			GUILayout.Space(5f);
			GUI.color = new Color(1f, 1f, 1f, 0.65f);
			GUILayout.Label(item.middleText);
			GUILayout.Space(5f);
			GUI.color = item.killedColor;
			GUILayout.Label(item.killed);
			GUILayout.Space(10f);
			GUILayout.EndHorizontal();
		}
		GUILayout.EndArea();
	}

	private void AddKillNotification(string killed)
	{
		base.photonView.RPC("networkAddMessage", PhotonTargets.All, PhotonNetwork.player.name, killed, "killed", (string)PhotonNetwork.player.customProperties["TeamName"]);
	}

	private void PlayerJoinedRoom()
	{
		base.photonView.RPC("networkAddMessage", PhotonTargets.All, PhotonNetwork.player.name, string.Empty, "connected", string.Empty);
	}

	private void PlayerLeftRoom(string playerName)
	{
		base.photonView.RPC("networkAddMessage", PhotonTargets.All, playerName, string.Empty, "left", string.Empty);
		Debug.Log("Player Left.");
	}

	private void PlayerJoinedTeam(string teamName)
	{
		base.photonView.RPC("networkAddMessage", PhotonTargets.All, PhotonNetwork.player.name, string.Empty, "joined " + teamName, string.Empty);
	}

	private void PlayerFellDown(string playerName)
	{
		base.photonView.RPC("networkAddMessage", PhotonTargets.All, playerName, string.Empty, "died", string.Empty);
	}

	[PunRPC]
	private void networkAddMessage(string killer, string killed, string middleText, string teamName)
	{
		Color color = default(Color);
		Color color2 = default(Color);
		if (rmm.MCMCKJIGBJN == "TDM")
		{
			if (teamName != string.Empty)
			{
				if (teamName == rmm.LEPLDNNHJPF.teamName)
				{
					color = rmm.GFICDIOAGKG;
					color2 = rmm.BHJBBMOHLOA;
				}
				else
				{
					color = rmm.BHJBBMOHLOA;
					color2 = rmm.GFICDIOAGKG;
				}
			}
			else
			{
				color = Color.white;
				color2 = Color.white;
			}
		}
		else
		{
			color = rmm.GFICDIOAGKG;
			color2 = rmm.GFICDIOAGKG;
		}
		whoKillWho.Add(new WhoKillWho(killer, killed, middleText, color, color2, 30f));
		if (whoKillWho.Count > 5)
		{
			whoKillWho.RemoveAt(0);
		}
	}

	private void OnLeftRoom()
	{
		whoKillWho.Clear();
		base.enabled = false;
	}

	private void OnJoinedRoom()
	{
		base.enabled = true;
	}

	private void OnCreatedRoom()
	{
		base.enabled = true;
	}

	private void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
		if (PhotonNetwork.isMasterClient)
		{
			base.gameObject.SendMessage("PlayerLeftRoom", otherPlayer.name, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnPhotonPlayerConnected(PhotonPlayer otherPlayer)
	{
		if (GetComponent<SurvivalMechanics>().enabled && PhotonNetwork.isMasterClient)
		{
			GetComponent<SurvivalMechanics>().SyncAllNow(otherPlayer);
		}
	}
}
