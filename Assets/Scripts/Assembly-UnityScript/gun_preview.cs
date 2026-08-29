using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class gun_preview : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_002423 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal gun_preview _0024self__002424;

			public _0024(gun_preview self_)
			{
				_0024self__002424 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002424.silencerDisplay.GetComponent<Renderer>().enabled = false;
					_0024self__002424.target.GetComponent<Animation>().CrossFade("idleAct", 0.4f);
					result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002424.target.GetComponent<Animation>().CrossFade("idle", 0.4f);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal gun_preview _0024self__002425;

		public _0024Start_002423(gun_preview self_)
		{
			_0024self__002425 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002425);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024reload_002426 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal gun_preview _0024self__002427;

			public _0024(gun_preview self_)
			{
				_0024self__002427 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002427.GetComponent<Camera>().fieldOfView = 50f;
					_0024self__002427.target.GetComponent<Animation>().Play("reload");
					result = (Yield(2, new WaitForSeconds(2.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002427.target.GetComponent<Animation>().CrossFade("idle");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal gun_preview _0024self__002428;

		public _0024reload_002426(gun_preview self_)
		{
			_0024self__002428 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002428);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024silencer_002429 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal gun_preview _0024self__002430;

			public _0024(gun_preview self_)
			{
				_0024self__002430 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002430.GetComponent<Camera>().fieldOfView = 50f;
					if (_0024self__002430.drawed)
					{
						_0024self__002430.target.GetComponent<Animation>()["silencerOn"].speed = 1.3f;
						_0024self__002430.target.GetComponent<Animation>().Play("silencerOn");
						_0024self__002430.silencerDisplay.GetComponent<Renderer>().enabled = true;
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					}
					else
					{
						_0024self__002430.target.GetComponent<Animation>().Play("silencerOff");
						_0024self__002430.drawed = true;
						result = (Yield(3, new WaitForSeconds(3.5f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024self__002430.target.GetComponent<Animation>().Play("idle");
					_0024self__002430.drawed = false;
					goto IL_0140;
				case 3:
					_0024self__002430.target.GetComponent<Animation>().CrossFade("idle");
					_0024self__002430.silencerDisplay.GetComponent<Renderer>().enabled = false;
					goto IL_0140;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0140:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal gun_preview _0024self__002431;

		public _0024silencer_002429(gun_preview self_)
		{
			_0024self__002431 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002431);
		}
	}

	public AnimationClip[] pumplist;

	public GameObject target;

	private int pumpnumber;

	private bool drawed;

	private bool playerview;

	public GameObject silencerDisplay;

	public gun_preview()
	{
		drawed = true;
		playerview = true;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_002423(this).GetEnumerator();
	}

	public virtual void OnGUI()
	{
		if (GUI.Button(new Rect(10f, 10f, 120f, 25f), "fire"))
		{
			fire();
		}
		if (GUI.Button(new Rect(140f, 10f, 70f, 25f), "reload"))
		{
			StartCoroutine(reload());
		}
		if (GUI.Button(new Rect(220f, 10f, 115f, 25f), "silencer on/off"))
		{
			StartCoroutine(silencer());
		}
		if (GUI.Button(new Rect(345f, 10f, 30f, 25f), "run"))
		{
			run();
		}
		if (GUI.Button(new Rect(595f, 10f, 130f, 25f), "player/world model"))
		{
			switchview();
		}
	}

	public virtual void fire()
	{
		GetComponent<Camera>().fieldOfView = 50f;
		target.GetComponent<Animation>().Play("fire2");
		target.GetComponent<Animation>().CrossFade("idle", 0.4f);
	}

	public virtual IEnumerator reload()
	{
		return new _0024reload_002426(this).GetEnumerator();
	}

	public virtual void run()
	{
		GetComponent<Camera>().fieldOfView = 50f;
		target.GetComponent<Animation>().Play("runStart");
		target.GetComponent<Animation>().CrossFade("run", 0.5f);
	}

	public virtual IEnumerator silencer()
	{
		return new _0024silencer_002429(this).GetEnumerator();
	}

	public virtual void switchview()
	{
		if (playerview)
		{
			GameObject.Find("gunHD").GetComponent<Renderer>().enabled = true;
			GameObject.Find("hands").GetComponent<Renderer>().enabled = false;
			GameObject.Find("gun").GetComponent<Renderer>().enabled = false;
			GameObject.Find("topshell").GetComponent<Renderer>().enabled = false;
			GameObject.Find("silencer").GetComponent<Renderer>().enabled = false;
			GameObject.Find("charger").GetComponent<Renderer>().enabled = false;
			playerview = false;
		}
		else
		{
			GameObject.Find("gunHD").GetComponent<Renderer>().enabled = false;
			GameObject.Find("hands").GetComponent<Renderer>().enabled = true;
			GameObject.Find("gun").GetComponent<Renderer>().enabled = true;
			GameObject.Find("topshell").GetComponent<Renderer>().enabled = true;
			GameObject.Find("silencer").GetComponent<Renderer>().enabled = true;
			GameObject.Find("charger").GetComponent<Renderer>().enabled = true;
			playerview = true;
		}
	}

	public virtual void Main()
	{
	}
}
