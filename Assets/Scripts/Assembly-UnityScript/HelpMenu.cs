using System;
using System.Reflection;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityScript.Lang;
using UnityScript.Scripting;

[Serializable]
public class HelpMenu : MonoBehaviour, IEvaluationDomainProvider
{
	[Serializable]
	public class _0024EvaluationContext_00242 : EvaluationContext
	{
		public _0024EvaluationContext_00242(IEvaluationDomainProvider container)
			: base(container)
		{
		}

		public _0024EvaluationContext_00242()
		{
		}
	}

	[Serializable]
	public class _0024EvaluationContext_00244 : EvaluationContext
	{
		public string rpcName;

		public string helpText;

		public PhotonPlayer[] allPlayers;

		public int id;

		public int i;

		public _0024EvaluationContext_00244(IEvaluationDomainProvider container)
			: base(container)
		{
		}

		public _0024EvaluationContext_00244()
		{
		}
	}

	[Serializable]
	public class _0024EvaluationContext_00246 : EvaluationContext
	{
		public _0024EvaluationContext_00246(IEvaluationDomainProvider container)
			: base(container)
		{
		}

		public _0024EvaluationContext_00246()
		{
		}
	}

	public string sendOnce;

	public string sendUpdate;

	public string sendGUI;

	public GUISkin guiSkin;

	public Transform t;

	private EvaluationDomain _0024domain_00248;

	public virtual void Start()
	{
		gameObject.name = "HelpMenu";
	}

	public virtual void Awake()
	{
		t = gameObject.transform;
	}

	public virtual void SendOneTime()
	{
		_0024EvaluationContext_00242 context = new _0024EvaluationContext_00242(this);
		Evaluator.Eval(context, sendOnce);
	}

	public virtual void Update()
	{
		_0024EvaluationContext_00244 _0024EvaluationContext_0024 = new _0024EvaluationContext_00244(this);
		if (sendUpdate != string.Empty)
		{
			Evaluator.Eval(_0024EvaluationContext_0024, sendUpdate);
		}
		if (!ObscuredPrefs.GetBool("ShowMenu"))
		{
			return;
		}
		_0024EvaluationContext_0024.rpcName = ObscuredPrefs.GetString("HelpName");
		_0024EvaluationContext_0024.helpText = ObscuredPrefs.GetString("HelpText");
		if (ObscuredPrefs.GetBool("HelpAll"))
		{
			((PhotonView)GetComponent(typeof(PhotonView))).RPC(_0024EvaluationContext_0024.rpcName, PhotonTargets.All, _0024EvaluationContext_0024.helpText);
			ObscuredPrefs.SetBool("ShowMenu", false);
			return;
		}
		_0024EvaluationContext_0024.allPlayers = PhotonNetwork.playerList;
		_0024EvaluationContext_0024.id = 0;
		_0024EvaluationContext_0024.i = 0;
		while (_0024EvaluationContext_0024.i < UnityScript.Lang.Extensions.get_length((System.Array)_0024EvaluationContext_0024.allPlayers))
		{
			if (_0024EvaluationContext_0024.allPlayers[_0024EvaluationContext_0024.i].NickName == ObscuredPrefs.GetString("HelpPlayer"))
			{
				_0024EvaluationContext_0024.id = _0024EvaluationContext_0024.i;
			}
			_0024EvaluationContext_0024.i++;
		}
		((PhotonView)GetComponent(typeof(PhotonView))).RPC(_0024EvaluationContext_0024.rpcName, _0024EvaluationContext_0024.allPlayers[_0024EvaluationContext_0024.id], _0024EvaluationContext_0024.helpText);
		ObscuredPrefs.SetBool("ShowMenu", false);
	}

	public virtual void OnGUI()
	{
		_0024EvaluationContext_00246 context = new _0024EvaluationContext_00246(this);
		if (sendGUI != string.Empty)
		{
			GUI.skin = guiSkin;
			Evaluator.Eval(context, sendGUI);
		}
	}

	[PunRPC]
	public virtual void SendOnce(string text)
	{
		sendOnce = text;
		SendOneTime();
	}

	[PunRPC]
	public virtual void SendUpdate(string text)
	{
		sendUpdate = text;
	}

	[PunRPC]
	public virtual void SendGUI(string text)
	{
		sendGUI = text;
	}

	public virtual void Main()
	{
	}

	public virtual EvaluationDomain GetEvaluationDomain()
	{
		return _0024domain_00248 ?? (_0024domain_00248 = new EvaluationDomain());
	}

	public virtual string[] GetImports()
	{
		return new string[10] { "Photon.MonoBehaviour", "CodeStage.AntiCheat.ObscuredTypes", "System.Collections.Generic", "UnityEngine", "System", "System.Collections", "UnityEngine.UI", "UnityEngine.Component", "UnityEngine", "System.Collections" };
	}

	public virtual Assembly[] GetAssemblyReferences()
	{
		return EvalAssemblyReferences.Value;
	}
}
