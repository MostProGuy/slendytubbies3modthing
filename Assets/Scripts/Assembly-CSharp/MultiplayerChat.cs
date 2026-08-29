using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Photon;
using TranslatorSystem;
using UnityEngine;

public class MultiplayerChat : Photon.MonoBehaviour
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct ChatData
	{
		public string name { get; set; }

		public string text { get; set; }

		public Color color { get; set; }

		public float timer { get; set; }

		public ChatData(string string1, string string2, Color color1, float timer1)
		{
			name = string1;
			text = string2;
			color = color1;
			timer = timer1;
		}
	}

	public static MultiplayerChat SP;

	public List<ChatData> messages = new List<ChatData>();

	private int chatHeight = 300;

	private Vector2 scrollPos = Vector2.zero;

	[HideInInspector]
	public string chatInput = string.Empty;

	[HideInInspector]
	public bool isChatting;

	public GUIStyle chatStyle;

	private RoomMultiplayerMenu rmm;

	private bool muteGuests;

	private string youneedtosignintochat = "You need to sign in to chat.";

	private void Awake()
	{
		SP = this;
		rmm = base.gameObject.GetComponent<RoomMultiplayerMenu>();
		Translator translator = new Translator();
		if (PlayerPrefs.GetInt("Language") > 0)
		{
			youneedtosignintochat = translator.Translate(77, "MP");
		}
	}

	private void Start()
	{
		if ((int)PhotonNetwork.room.customProperties["MG"] == 1)
		{
			muteGuests = true;
		}
	}

	private void Update()
	{
		for (int i = 0; i < messages.Count; i++)
		{
			ChatData chatData = messages[i];
			chatData.timer -= Time.deltaTime;
			if (chatData.timer > 0f)
			{
				messages[i] = new ChatData(chatData.name, chatData.text, chatData.color, chatData.timer);
			}
			else
			{
				messages.RemoveAt(i);
			}
		}
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(5f, Screen.height - 35, Screen.width, 30f));
		if (isChatting)
		{
			GUI.FocusControl("ChatField");
			GUI.SetNextControlName("ChatField");
			GUILayout.BeginHorizontal("box", GUILayout.Width(400f));
			GUI.color = Color.red;
			GUILayout.Label("Say: ", chatStyle);
			GUILayout.Space(5f);
			GUI.color = Color.white;
			chatInput = GUILayout.TextField(chatInput, chatStyle, GUILayout.Width(400f));
			GUILayout.EndHorizontal();
		}
		else
		{
			GUI.FocusControl(string.Empty);
		}
		GUILayout.EndArea();
		if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.T && !isChatting)
		{
			if (muteGuests)
			{
				if (ObscuredPrefs.HasKey("PlayerType"))
				{
					isChatting = true;
				}
				else
				{
					AddMessage("  SYSTEM: ", youneedtosignintochat, "Team B");
				}
			}
			else
			{
				isChatting = true;
			}
			StartCoroutine(ClearChat());
		}
		if (Event.current.type == EventType.KeyDown && Event.current.character == '\n')
		{
			isChatting = false;
			SendChat(PhotonTargets.All);
		}
		GUILayout.BeginArea(new Rect(5f, Screen.height - chatHeight - 80, Screen.width, chatHeight + 10));
		scrollPos = GUILayout.BeginScrollView(scrollPos);
		GUI.color = Color.white;
		GUILayout.FlexibleSpace();
		for (int i = 0; i < messages.Count; i++)
		{
			GUILayout.BeginHorizontal("box", GUILayout.Width(10f));
			GUI.color = messages[i].color;
			GUILayout.Label(messages[i].name, chatStyle);
			GUILayout.Space(5f);
			GUI.color = Color.white;
			GUILayout.Label(messages[i].text, chatStyle);
			GUILayout.EndHorizontal();
		}
		GUILayout.EndScrollView();
		GUILayout.EndArea();
	}

	private void SendChat(PhotonTargets target)
	{
		if (chatInput != string.Empty)
		{
			string text = " " + chatInput;
			base.photonView.RPC("SendChatMessage", target, text, (string)PhotonNetwork.player.customProperties["TeamName"]);
			chatInput = string.Empty;
		}
	}

	[PunRPC]
	private void SendChatMessage(string text, string teamName, PhotonMessageInfo info)
	{
		AddMessage(string.Concat("  ", info.sender, ": "), text, teamName);
		if (text.Contains("/kick ") && info.sender.name == PhotonNetwork.masterClient.name)
		{
			string text2 = text.Replace("/kick ", string.Empty);
			text2 = text2.Remove(0, 1);
			if (text2 == PhotonNetwork.playerName)
			{
				PhotonNetwork.Disconnect();
			}
		}
	}

	private void AddMessage(string name, string text, string teamName)
	{
		Color color = default(Color);
		color = ((!(teamName == rmm.LEPLDNNHJPF.teamName)) ? rmm.BHJBBMOHLOA : rmm.GFICDIOAGKG);
		SP.messages.Add(new ChatData(name, text, color, 30f));
		if (SP.messages.Count > 8)
		{
			SP.messages.RemoveAt(0);
		}
	}

	private void OnLeftRoom()
	{
		messages.Clear();
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

	private IEnumerator ClearChat()
	{
		yield return new WaitForSeconds(0.01f);
		chatInput = string.Empty;
	}
}
