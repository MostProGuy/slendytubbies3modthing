using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class weapon_preview : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024attack_002432 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal weapon_preview _0024self__002433;

			public _0024(weapon_preview self_)
			{
				_0024self__002433 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002433.target.GetComponent<Animation>().Play(_0024self__002433.attacks[_0024self__002433.attacknumber].name);
					_0024self__002433.attacknumber++;
					if (_0024self__002433.attacknumber == 3)
					{
						_0024self__002433.attacknumber = 0;
					}
					result = (Yield(2, new WaitForSeconds(0.8f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002433.target.GetComponent<Animation>().Play("idle");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal weapon_preview _0024self__002434;

		public _0024attack_002432(weapon_preview self_)
		{
			_0024self__002434 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002434);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024powerattack_002435 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal weapon_preview _0024self__002436;

			public _0024(weapon_preview self_)
			{
				_0024self__002436 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002436.target.GetComponent<Animation>().Play("powerAttack");
					result = (Yield(2, new WaitForSeconds(1.7f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002436.target.GetComponent<Animation>().Play("idle");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal weapon_preview _0024self__002437;

		public _0024powerattack_002435(weapon_preview self_)
		{
			_0024self__002437 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002437);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024finishattack_002438 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal weapon_preview _0024self__002439;

			public _0024(weapon_preview self_)
			{
				_0024self__002439 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002439.target.GetComponent<Animation>().Play("finishAttack");
					result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002439.target.GetComponent<Animation>().Play("idle");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal weapon_preview _0024self__002440;

		public _0024finishattack_002438(weapon_preview self_)
		{
			_0024self__002440 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002440);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024drawholster_002441 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal weapon_preview _0024self__002442;

			public _0024(weapon_preview self_)
			{
				_0024self__002442 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__002442.drawed)
					{
						_0024self__002442.target.GetComponent<Animation>().Play("holster");
						_0024self__002442.drawed = false;
						goto IL_00ac;
					}
					_0024self__002442.target.GetComponent<Animation>().Play("draw");
					_0024self__002442.drawed = true;
					result = (Yield(2, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002442.target.GetComponent<Animation>().Play("idle");
					goto IL_00ac;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ac:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal weapon_preview _0024self__002443;

		public _0024drawholster_002441(weapon_preview self_)
		{
			_0024self__002443 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002443);
		}
	}

	public AnimationClip[] attacks;

	public GameObject target;

	public AnimationClip powerAttack;

	private int attacknumber;

	private bool drawed;

	public weapon_preview()
	{
		drawed = true;
	}

	public virtual void OnGUI()
	{
		if (GUI.Button(new Rect(10f, 10f, 150f, 25f), "random attack (3)"))
		{
			StartCoroutine(attack());
		}
		if (GUI.Button(new Rect(170f, 10f, 150f, 25f), "power attack"))
		{
			StartCoroutine(powerattack());
		}
		if (GUI.Button(new Rect(330f, 10f, 150f, 25f), "finish him"))
		{
			StartCoroutine(finishattack());
		}
		if (GUI.Button(new Rect(490f, 10f, 150f, 25f), "draw/holster "))
		{
			StartCoroutine(drawholster());
		}
	}

	public virtual IEnumerator attack()
	{
		return new _0024attack_002432(this).GetEnumerator();
	}

	public virtual IEnumerator powerattack()
	{
		return new _0024powerattack_002435(this).GetEnumerator();
	}

	public virtual IEnumerator finishattack()
	{
		return new _0024finishattack_002438(this).GetEnumerator();
	}

	public virtual IEnumerator drawholster()
	{
		return new _0024drawholster_002441(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
