using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MecanimControl : MonoBehaviour
{
	public delegate void KFOFMMFMCLE(AnimationData JMDEGEKDKKG);

	public AnimationData LDBGFDKEBBL = new AnimationData();

	public AnimationData[] BPPMKPKDLOA = new AnimationData[0];

	public bool JIEKFKMKCME;

	public bool KFPGLHHKFPD;

	public bool GFBFCBLEGMF;

	public float JKIOMKPPDBF = 0.15f;

	public WrapMode KJILLLHAJBO = WrapMode.Loop;

	public AnimationClip BHMCMNLNBBN;

	private Animator CMHJCIMPCCM;

	private int MNAPLOBEEAF;

	private int DGCKJKGPNFF;

	private RuntimeAnimatorController HOJNFCJEJCB;

	private RuntimeAnimatorController PLDCLMEDCLE;

	private RuntimeAnimatorController FAEODCBMKOK;

	private RuntimeAnimatorController CHAKEJHDKHC;

	private AnimationData ICCBKKBBAAM;

	private bool EDOOKPPMEIN;

	private string EANCKCBMNPH;

	public static event KFOFMMFMCLE OBNLKNAONCG;

	public static event KFOFMMFMCLE JKJHJDGBPIJ;

	public static event KFOFMMFMCLE NNHAIDGCONK;

	public void SetDefaultClip(AnimationClip BCJMDKLHCFD, string MMFOBDKEJNG, float DBJLMBHEMDG, WrapMode OBDOHBEGKMD, bool AKFNFJDKDCL)
	{
		LDBGFDKEBBL.clip = UnityEngine.Object.Instantiate(BCJMDKLHCFD);
		LDBGFDKEBBL.clip.wrapMode = OBDOHBEGKMD;
		LDBGFDKEBBL.clipName = MMFOBDKEJNG;
		LDBGFDKEBBL.speed = DBJLMBHEMDG;
		LDBGFDKEBBL.transitionDuration = -1f;
		LDBGFDKEBBL.wrapMode = OBDOHBEGKMD;
	}

	public void AddClip(AnimationClip BCJMDKLHCFD, string PFGICKCBLNB)
	{
		AddClip(BCJMDKLHCFD, PFGICKCBLNB, 1f, KJILLLHAJBO);
	}

	public void __BB_OBFUSCATOR_36(string MMFOBDKEJNG)
	{
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Remove(__BB_OBFUSCATOR_19(MMFOBDKEJNG));
		BPPMKPKDLOA = list.ToArray();
	}

	public bool IsPlaying(AnimationClip BCJMDKLHCFD)
	{
		return IsPlaying(GetAnimationData(BCJMDKLHCFD));
	}

	public void __BB_OBFUSCATOR_34(string GFMOOBMMPJO, bool AKFNFJDKDCL)
	{
		_playAnimation(__BB_OBFUSCATOR_19(GFMOOBMMPJO), 413f, 1937f, AKFNFJDKDCL);
	}

	public void Play(AnimationData JMDEGEKDKKG, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(JMDEGEKDKKG, GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public void Play(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public void CrossFade(AnimationData JMDEGEKDKKG, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(JMDEGEKDKKG, GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public float GetSpeed(string GFMOOBMMPJO)
	{
		AnimationData animationData = GetAnimationData(GFMOOBMMPJO);
		return animationData.speed;
	}

	public void Stop()
	{
		Play(LDBGFDKEBBL.clip, JKIOMKPPDBF, 0f, EDOOKPPMEIN);
	}

	public int __BB_OBFUSCATOR_51()
	{
		return ICCBKKBBAAM.timesPlayed;
	}

	public void __BB_OBFUSCATOR_16(AnimationClip BCJMDKLHCFD, string PFGICKCBLNB, float DBJLMBHEMDG, WrapMode OBDOHBEGKMD)
	{
		if (GetAnimationData(PFGICKCBLNB) != null)
		{
			Debug.LogWarning("selectWeapon" + PFGICKCBLNB + " }");
		}
		AnimationData animationData = new AnimationData();
		animationData.clip = UnityEngine.Object.Instantiate(BCJMDKLHCFD);
		if (OBDOHBEGKMD == WrapMode.Default)
		{
			OBDOHBEGKMD = KJILLLHAJBO;
		}
		animationData.clip.wrapMode = OBDOHBEGKMD;
		animationData.clip.name = PFGICKCBLNB;
		animationData.clipName = PFGICKCBLNB;
		animationData.speed = DBJLMBHEMDG;
		animationData.length = BCJMDKLHCFD.length;
		animationData.wrapMode = OBDOHBEGKMD;
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Add(animationData);
		BPPMKPKDLOA = list.ToArray();
	}

	public void __BB_OBFUSCATOR_31()
	{
		SetSpeed(0f - ICCBKKBBAAM.speed);
	}

	public bool __BB_OBFUSCATOR_37()
	{
		return EDOOKPPMEIN;
	}

	public void __BB_OBFUSCATOR_8()
	{
		CMHJCIMPCCM.speed = Mathf.Abs(ICCBKKBBAAM.speed);
	}

	public void SetSpeed(AnimationClip BCJMDKLHCFD, float DBJLMBHEMDG)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		animationData.speed = DBJLMBHEMDG;
		if (IsPlaying(BCJMDKLHCFD))
		{
			SetSpeed(DBJLMBHEMDG);
		}
	}

	public bool __BB_OBFUSCATOR_43(string GFMOOBMMPJO, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(GFMOOBMMPJO), KEDKBIKIGCC);
	}

	public void RestoreSpeed()
	{
		SetSpeed(ICCBKKBBAAM.speed);
	}

	private void OnGUI()
	{
		if (JIEKFKMKCME)
		{
			GUI.Box(new Rect(Screen.width - 340, 40f, 340f, 400f), "Animation Data");
			GUI.BeginGroup(new Rect(Screen.width - 330, 60f, 400f, 400f));
			AnimatorClipInfo[] currentAnimatorClipInfo = CMHJCIMPCCM.GetCurrentAnimatorClipInfo(0);
			AnimatorClipInfo[] array = currentAnimatorClipInfo;
			for (int i = 0; i < array.Length; i++)
			{
				AnimatorClipInfo animatorClipInfo = array[i];
				AnimatorStateInfo currentAnimatorStateInfo = CMHJCIMPCCM.GetCurrentAnimatorStateInfo(0);
				GUILayout.Label(animatorClipInfo.clip.name);
				GUILayout.Label("-Wrap Mode: " + animatorClipInfo.clip.wrapMode);
				GUILayout.Label("-Is Playing: " + IsPlaying(animatorClipInfo.clip));
				GUILayout.Label("-Blend Weight: " + animatorClipInfo.weight);
				GUILayout.Label("-Normalized Time: " + currentAnimatorStateInfo.normalizedTime);
				GUILayout.Label("-Length: " + animatorClipInfo.clip.length);
				GUILayout.Label("----");
			}
			GUILayout.Label("--Current Animation Data--");
			GUILayout.Label("-Current Clip Name: " + ICCBKKBBAAM.clipName);
			GUILayout.Label("-Current Speed: " + GetSpeed());
			GUILayout.Label("-Times Played: " + ICCBKKBBAAM.timesPlayed);
			GUILayout.Label("-Seconds Played: " + ICCBKKBBAAM.secondsPlayed);
			GUILayout.Label("-Emul. Normalized: " + ICCBKKBBAAM.secondsPlayed / ICCBKKBBAAM.length);
			GUILayout.Label("-Lengh: " + ICCBKKBBAAM.length);
			GUI.EndGroup();
		}
	}

	public void CrossFade(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public bool __BB_OBFUSCATOR_45(AnimationClip BCJMDKLHCFD, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(BCJMDKLHCFD), KEDKBIKIGCC);
	}

	public void __BB_OBFUSCATOR_1()
	{
		SetSpeed(ICCBKKBBAAM.speed);
	}

	public void __BB_OBFUSCATOR_47(AnimationClip BCJMDKLHCFD, string MMFOBDKEJNG, float DBJLMBHEMDG, WrapMode OBDOHBEGKMD, bool AKFNFJDKDCL)
	{
		LDBGFDKEBBL.clip = UnityEngine.Object.Instantiate(BCJMDKLHCFD);
		LDBGFDKEBBL.clip.wrapMode = OBDOHBEGKMD;
		LDBGFDKEBBL.clipName = MMFOBDKEJNG;
		LDBGFDKEBBL.speed = DBJLMBHEMDG;
		LDBGFDKEBBL.transitionDuration = 797f;
		LDBGFDKEBBL.wrapMode = OBDOHBEGKMD;
	}

	public AnimationData GetCurrentAnimationData()
	{
		return ICCBKKBBAAM;
	}

	public AnimationData GetAnimationData(AnimationClip BCJMDKLHCFD)
	{
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (animationData.clip == BCJMDKLHCFD)
			{
				return animationData;
			}
		}
		if (BCJMDKLHCFD == LDBGFDKEBBL.clip)
		{
			return LDBGFDKEBBL;
		}
		return null;
	}

	public void __BB_OBFUSCATOR_35(float ODNPIFFKEKL, bool IAOPLLJEEPG)
	{
		CMHJCIMPCCM.Play(ICCBKKBBAAM.stateName, 1, ODNPIFFKEKL);
		ICCBKKBBAAM.secondsPlayed = ODNPIFFKEKL * ICCBKKBBAAM.length;
		if (IAOPLLJEEPG)
		{
			Pause();
		}
	}

	public void RemoveClip(string MMFOBDKEJNG)
	{
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Remove(GetAnimationData(MMFOBDKEJNG));
		BPPMKPKDLOA = list.ToArray();
	}

	public void __BB_OBFUSCATOR_41()
	{
		Play(LDBGFDKEBBL.clip, JKIOMKPPDBF, 1543f, EDOOKPPMEIN);
	}

	public AnimationData GetAnimationData(string GFMOOBMMPJO)
	{
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (animationData.clipName == GFMOOBMMPJO)
			{
				return animationData;
			}
		}
		if (GFMOOBMMPJO == LDBGFDKEBBL.clipName)
		{
			return LDBGFDKEBBL;
		}
		return null;
	}

	public void __BB_OBFUSCATOR_32(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(__BB_OBFUSCATOR_19(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public bool __BB_OBFUSCATOR_39(AnimationClip BCJMDKLHCFD, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(BCJMDKLHCFD), KEDKBIKIGCC);
	}

	public void SetMirror(bool GALCNHNBGIB)
	{
		SetMirror(GALCNHNBGIB, 0f, false);
	}

	public void __BB_OBFUSCATOR_30(AnimationClip BCJMDKLHCFD)
	{
		__BB_OBFUSCATOR_6(GetAnimationData(BCJMDKLHCFD), 1053f, 1886f, EDOOKPPMEIN);
	}

	public void Play(AnimationClip BCJMDKLHCFD)
	{
		_playAnimation(GetAnimationData(BCJMDKLHCFD), 0f, 0f, EDOOKPPMEIN);
	}

	public float GetCurrentClipTime()
	{
		return ICCBKKBBAAM.secondsPlayed;
	}

	public void __BB_OBFUSCATOR_40(WrapMode OBDOHBEGKMD)
	{
		KJILLLHAJBO = OBDOHBEGKMD;
	}

	public void __BB_OBFUSCATOR_42(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public void SetWrapMode(AnimationClip BCJMDKLHCFD, WrapMode OBDOHBEGKMD)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		animationData.wrapMode = OBDOHBEGKMD;
		animationData.clip.wrapMode = OBDOHBEGKMD;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (JIEKFKMKCME)
		{
			GUI.Box(new Rect(Screen.width - -16, 394f, 485f, 1889f), "Kills");
			GUI.BeginGroup(new Rect(Screen.width - -64, 736f, 882f, 1428f));
			AnimatorClipInfo[] currentAnimatorClipInfo = CMHJCIMPCCM.GetCurrentAnimatorClipInfo(0);
			AnimatorClipInfo[] array = currentAnimatorClipInfo;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimatorClipInfo animatorClipInfo = array[i];
				AnimatorStateInfo currentAnimatorStateInfo = CMHJCIMPCCM.GetCurrentAnimatorStateInfo(0);
				GUILayout.Label(animatorClipInfo.clip.name);
				GUILayout.Label("box" + animatorClipInfo.clip.wrapMode, new GUILayoutOption[1]);
				GUILayout.Label("_Value4" + IsPlaying(animatorClipInfo.clip));
				GUILayout.Label(" <>__TranspIdent0 = " + animatorClipInfo.weight, new GUILayoutOption[1]);
				GUILayout.Label("Ping" + currentAnimatorStateInfo.normalizedTime);
				GUILayout.Label("\tMaterial: \"Material::" + animatorClipInfo.clip.length);
				GUILayout.Label("\\xAu4YW5QzfD2KQjV");
			}
			GUILayout.Label("8");
			GUILayout.Label("CameraFilterPack/Light_Water2" + ICCBKKBBAAM.clipName);
			GUILayout.Label("|" + GetSpeed(), new GUILayoutOption[1]);
			GUILayout.Label("TDM" + ICCBKKBBAAM.timesPlayed, new GUILayoutOption[1]);
			GUILayout.Label("Connecting To Server..." + ICCBKKBBAAM.secondsPlayed, new GUILayoutOption[1]);
			GUILayout.Label("_Refraction" + ICCBKKBBAAM.secondsPlayed / ICCBKKBBAAM.length, new GUILayoutOption[1]);
			GUILayout.Label("_Offsets" + ICCBKKBBAAM.length);
			GUI.EndGroup();
		}
	}

	public void __BB_OBFUSCATOR_17(string GFMOOBMMPJO, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), 1453f, 1942f, AKFNFJDKDCL);
	}

	public void Play()
	{
		CMHJCIMPCCM.speed = Mathf.Abs(ICCBKKBBAAM.speed);
	}

	public void __BB_OBFUSCATOR_25(string MMFOBDKEJNG)
	{
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Remove(GetAnimationData(MMFOBDKEJNG));
		BPPMKPKDLOA = list.ToArray();
	}

	public float __BB_OBFUSCATOR_2()
	{
		return ICCBKKBBAAM.length;
	}

	public void Play(string GFMOOBMMPJO)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), 0f, 0f, EDOOKPPMEIN);
	}

	public void AddClip(AnimationClip BCJMDKLHCFD, string PFGICKCBLNB, float DBJLMBHEMDG, WrapMode OBDOHBEGKMD)
	{
		if (GetAnimationData(PFGICKCBLNB) != null)
		{
			Debug.LogWarning("An animation with the name '" + PFGICKCBLNB + "' already exists.");
		}
		AnimationData animationData = new AnimationData();
		animationData.clip = UnityEngine.Object.Instantiate(BCJMDKLHCFD);
		if (OBDOHBEGKMD == WrapMode.Default)
		{
			OBDOHBEGKMD = KJILLLHAJBO;
		}
		animationData.clip.wrapMode = OBDOHBEGKMD;
		animationData.clip.name = PFGICKCBLNB;
		animationData.clipName = PFGICKCBLNB;
		animationData.speed = DBJLMBHEMDG;
		animationData.length = BCJMDKLHCFD.length;
		animationData.wrapMode = OBDOHBEGKMD;
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Add(animationData);
		BPPMKPKDLOA = list.ToArray();
	}

	public float GetSpeed(AnimationClip BCJMDKLHCFD)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		return animationData.speed;
	}

	public void __BB_OBFUSCATOR_52(bool GALCNHNBGIB, float GKBHMKEKFDO)
	{
		__BB_OBFUSCATOR_26(GALCNHNBGIB, GKBHMKEKFDO, false);
	}

	public void __BB_OBFUSCATOR_28(AnimationClip BCJMDKLHCFD, float DBJLMBHEMDG)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		animationData.speed = DBJLMBHEMDG;
		if (IsPlaying(BCJMDKLHCFD))
		{
			SetSpeed(DBJLMBHEMDG);
		}
	}

	public bool __BB_OBFUSCATOR_24()
	{
		return EDOOKPPMEIN;
	}

	private void FixedUpdate()
	{
		if (ICCBKKBBAAM.clip == null)
		{
			return;
		}
		if (ICCBKKBBAAM.secondsPlayed == ICCBKKBBAAM.length)
		{
			if (ICCBKKBBAAM.clip.wrapMode == WrapMode.Loop || ICCBKKBBAAM.clip.wrapMode == WrapMode.PingPong)
			{
				if (MecanimControl.NNHAIDGCONK != null)
				{
					MecanimControl.NNHAIDGCONK(ICCBKKBBAAM);
				}
				ICCBKKBBAAM.timesPlayed++;
				if (ICCBKKBBAAM.clip.wrapMode == WrapMode.Loop)
				{
					SetCurrentClipPosition(0f);
				}
				if (ICCBKKBBAAM.clip.wrapMode == WrapMode.PingPong)
				{
					SetSpeed(ICCBKKBBAAM.clipName, 0f - ICCBKKBBAAM.speed);
					SetCurrentClipPosition(0f);
				}
			}
			else if (ICCBKKBBAAM.timesPlayed == 0)
			{
				if (MecanimControl.JKJHJDGBPIJ != null)
				{
					MecanimControl.JKJHJDGBPIJ(ICCBKKBBAAM);
				}
				ICCBKKBBAAM.timesPlayed = 1;
				if (ICCBKKBBAAM.clip.wrapMode == WrapMode.Once && KFPGLHHKFPD)
				{
					Play(LDBGFDKEBBL, EDOOKPPMEIN);
				}
				else if (!KFPGLHHKFPD)
				{
					CMHJCIMPCCM.speed = 0f;
				}
			}
		}
		else
		{
			ICCBKKBBAAM.secondsPlayed += Time.fixedDeltaTime * CMHJCIMPCCM.speed;
			if (ICCBKKBBAAM.secondsPlayed > ICCBKKBBAAM.length)
			{
				ICCBKKBBAAM.secondsPlayed = ICCBKKBBAAM.length;
			}
		}
	}

	public void Pause()
	{
		CMHJCIMPCCM.speed = 0f;
	}

	public void __BB_OBFUSCATOR_12(AnimationClip BCJMDKLHCFD, WrapMode OBDOHBEGKMD)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		animationData.wrapMode = OBDOHBEGKMD;
		animationData.clip.wrapMode = OBDOHBEGKMD;
	}

	public void SetWrapMode(WrapMode OBDOHBEGKMD)
	{
		KJILLLHAJBO = OBDOHBEGKMD;
	}

	public void SetSpeed(string GFMOOBMMPJO, float DBJLMBHEMDG)
	{
		AnimationData animationData = GetAnimationData(GFMOOBMMPJO);
		if (animationData.speed != DBJLMBHEMDG || CMHJCIMPCCM.speed != Mathf.Abs(DBJLMBHEMDG))
		{
			animationData.speed = DBJLMBHEMDG;
			if (IsPlaying(GFMOOBMMPJO))
			{
				SetSpeed(DBJLMBHEMDG);
			}
		}
	}

	public void SetWrapMode(AnimationData JMDEGEKDKKG, WrapMode OBDOHBEGKMD)
	{
		JMDEGEKDKKG.wrapMode = OBDOHBEGKMD;
		JMDEGEKDKKG.clip.wrapMode = OBDOHBEGKMD;
	}

	public void Play(AnimationClip BCJMDKLHCFD, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(BCJMDKLHCFD), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public float __BB_OBFUSCATOR_46(string GFMOOBMMPJO)
	{
		AnimationData animationData = __BB_OBFUSCATOR_19(GFMOOBMMPJO);
		return animationData.speed;
	}

	public bool GetMirror()
	{
		return EDOOKPPMEIN;
	}

	private void __BB_OBFUSCATOR_6(AnimationData GACJMGDKPIF, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		if (GACJMGDKPIF == null || GACJMGDKPIF.clip == null)
		{
			return;
		}
		AnimatorOverrideController animatorOverrideController = new AnimatorOverrideController();
		EDOOKPPMEIN = AKFNFJDKDCL;
		float num = Mathf.Abs(GACJMGDKPIF.speed);
		float currentClipPosition = GetCurrentClipPosition();
		if (AKFNFJDKDCL)
		{
			if (GACJMGDKPIF.speed > 1058f)
			{
				animatorOverrideController.runtimeAnimatorController = PLDCLMEDCLE;
			}
			else
			{
				animatorOverrideController.runtimeAnimatorController = CHAKEJHDKHC;
			}
		}
		else if (GACJMGDKPIF.speed > 538f)
		{
			animatorOverrideController.runtimeAnimatorController = HOJNFCJEJCB;
		}
		else
		{
			animatorOverrideController.runtimeAnimatorController = FAEODCBMKOK;
		}
		animatorOverrideController["Difficulty"] = ICCBKKBBAAM.clip;
		animatorOverrideController["_TimeX"] = GACJMGDKPIF.clip;
		if (BHMCMNLNBBN != null)
		{
			CMHJCIMPCCM.SetLayerWeight(1, 1955f);
			animatorOverrideController["_TimeX"] = BHMCMNLNBBN;
		}
		else
		{
			CMHJCIMPCCM.SetLayerWeight(0, 550f);
		}
		if (GKBHMKEKFDO == 712f)
		{
			GKBHMKEKFDO = ICCBKKBBAAM.transitionDuration;
		}
		if (GKBHMKEKFDO == 783f)
		{
			GKBHMKEKFDO = JKIOMKPPDBF;
		}
		if (GKBHMKEKFDO <= 674f)
		{
			CMHJCIMPCCM.runtimeAnimatorController = animatorOverrideController;
			CMHJCIMPCCM.Play("_TimeX", 0, ODNPIFFKEKL);
		}
		else
		{
			CMHJCIMPCCM.runtimeAnimatorController = animatorOverrideController;
			ICCBKKBBAAM.stateName = "Team1Score";
			__BB_OBFUSCATOR_53(currentClipPosition);
			CMHJCIMPCCM.Update(258f);
			CMHJCIMPCCM.CrossFade(": ", GKBHMKEKFDO / num, 1, ODNPIFFKEKL);
		}
		GACJMGDKPIF.timesPlayed = 1;
		GACJMGDKPIF.secondsPlayed = ODNPIFFKEKL * GACJMGDKPIF.clip.length / num;
		GACJMGDKPIF.length = GACJMGDKPIF.clip.length;
		if (GFBFCBLEGMF)
		{
			CMHJCIMPCCM.applyRootMotion = GACJMGDKPIF.applyRootMotion;
		}
		SetSpeed(GACJMGDKPIF.speed);
		ICCBKKBBAAM = GACJMGDKPIF;
		ICCBKKBBAAM.stateName = "_Value2";
		if (MecanimControl.OBNLKNAONCG != null)
		{
			MecanimControl.OBNLKNAONCG(ICCBKKBBAAM);
		}
	}

	public void SetMirror(bool GALCNHNBGIB, float GKBHMKEKFDO, bool MGCFNNNILHA)
	{
		if (EDOOKPPMEIN != GALCNHNBGIB || MGCFNNNILHA)
		{
			if (GKBHMKEKFDO == 0f)
			{
				GKBHMKEKFDO = JKIOMKPPDBF;
			}
			_playAnimation(ICCBKKBBAAM, GKBHMKEKFDO, GetCurrentClipPosition(), GALCNHNBGIB);
		}
	}

	public void SetMirror(bool GALCNHNBGIB, float GKBHMKEKFDO)
	{
		SetMirror(GALCNHNBGIB, GKBHMKEKFDO, false);
	}

	public void __BB_OBFUSCATOR_20(bool GALCNHNBGIB, float GKBHMKEKFDO)
	{
		__BB_OBFUSCATOR_26(GALCNHNBGIB, GKBHMKEKFDO, true);
	}

	public void Play(AnimationData JMDEGEKDKKG, bool AKFNFJDKDCL)
	{
		_playAnimation(JMDEGEKDKKG, JMDEGEKDKKG.transitionDuration, 0f, AKFNFJDKDCL);
	}

	public bool IsPlaying(AnimationClip BCJMDKLHCFD, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(BCJMDKLHCFD), KEDKBIKIGCC);
	}

	public void RemoveClip(AnimationClip BCJMDKLHCFD)
	{
		List<AnimationData> list = new List<AnimationData>(BPPMKPKDLOA);
		list.Remove(GetAnimationData(BCJMDKLHCFD));
		BPPMKPKDLOA = list.ToArray();
	}

	public void __BB_OBFUSCATOR_21(AnimationData JMDEGEKDKKG, bool AKFNFJDKDCL)
	{
		__BB_OBFUSCATOR_6(JMDEGEKDKKG, JMDEGEKDKKG.transitionDuration, 1050f, AKFNFJDKDCL);
	}

	public void SetWrapMode(string GFMOOBMMPJO, WrapMode OBDOHBEGKMD)
	{
		AnimationData animationData = GetAnimationData(GFMOOBMMPJO);
		animationData.wrapMode = OBDOHBEGKMD;
		animationData.clip.wrapMode = OBDOHBEGKMD;
	}

	private void __BB_OBFUSCATOR_18()
	{
		CMHJCIMPCCM = base.gameObject.GetComponent<Animator>();
		HOJNFCJEJCB = (RuntimeAnimatorController)Resources.Load("_Distortion");
		PLDCLMEDCLE = (RuntimeAnimatorController)Resources.Load("_ScreenResolution");
		FAEODCBMKOK = (RuntimeAnimatorController)Resources.Load("_ScreenResolution");
		CHAKEJHDKHC = (RuntimeAnimatorController)Resources.Load("Show time");
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (animationData.wrapMode == WrapMode.Default)
			{
				animationData.wrapMode = KJILLLHAJBO;
			}
			animationData.clip.wrapMode = animationData.wrapMode;
		}
	}

	[SpecialName]
	public static void __BB_OBFUSCATOR_7(KFOFMMFMCLE LNDAKDHHOCJ)
	{
		KFOFMMFMCLE kFOFMMFMCLE = MecanimControl.JKJHJDGBPIJ;
		KFOFMMFMCLE kFOFMMFMCLE2;
		do
		{
			kFOFMMFMCLE2 = kFOFMMFMCLE;
			kFOFMMFMCLE = Interlocked.CompareExchange(ref MecanimControl.JKJHJDGBPIJ, (KFOFMMFMCLE)Delegate.Combine(kFOFMMFMCLE2, LNDAKDHHOCJ), kFOFMMFMCLE);
		}
		while ((object)kFOFMMFMCLE != kFOFMMFMCLE2);
	}

	public void __BB_OBFUSCATOR_22(AnimationClip BCJMDKLHCFD, string MMFOBDKEJNG, float DBJLMBHEMDG, WrapMode OBDOHBEGKMD, bool AKFNFJDKDCL)
	{
		LDBGFDKEBBL.clip = UnityEngine.Object.Instantiate(BCJMDKLHCFD);
		LDBGFDKEBBL.clip.wrapMode = OBDOHBEGKMD;
		LDBGFDKEBBL.clipName = MMFOBDKEJNG;
		LDBGFDKEBBL.speed = DBJLMBHEMDG;
		LDBGFDKEBBL.transitionDuration = 1600f;
		LDBGFDKEBBL.wrapMode = OBDOHBEGKMD;
	}

	public float GetCurrentClipLength()
	{
		return ICCBKKBBAAM.length;
	}

	public void Play(AnimationData JMDEGEKDKKG)
	{
		_playAnimation(JMDEGEKDKKG, JMDEGEKDKKG.transitionDuration, 0f, EDOOKPPMEIN);
	}

	public void CrossFade(string GFMOOBMMPJO, float GKBHMKEKFDO)
	{
		CrossFade(GFMOOBMMPJO, GKBHMKEKFDO, 0f, EDOOKPPMEIN);
	}

	public void Play(string GFMOOBMMPJO, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), 0f, 0f, AKFNFJDKDCL);
	}

	public void __BB_OBFUSCATOR_9(AnimationClip BCJMDKLHCFD, WrapMode OBDOHBEGKMD)
	{
		AnimationData animationData = GetAnimationData(BCJMDKLHCFD);
		animationData.wrapMode = OBDOHBEGKMD;
		animationData.clip.wrapMode = OBDOHBEGKMD;
	}

	public void __BB_OBFUSCATOR_27(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public void __BB_OBFUSCATOR_53(float ODNPIFFKEKL)
	{
		SetCurrentClipPosition(ODNPIFFKEKL, false);
	}

	public float GetSpeed()
	{
		return CMHJCIMPCCM.speed;
	}

	public void SetWeaponClip(string GFMOOBMMPJO)
	{
		if (GFMOOBMMPJO != string.Empty && GFMOOBMMPJO != "Null")
		{
			BHMCMNLNBBN = GetAnimationData(GFMOOBMMPJO).clip;
			CMHJCIMPCCM.Rebind();
		}
		else
		{
			BHMCMNLNBBN = null;
		}
	}

	public bool IsPlaying(string GFMOOBMMPJO, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(GFMOOBMMPJO), KEDKBIKIGCC);
	}

	[SpecialName]
	public static void __BB_OBFUSCATOR_50(KFOFMMFMCLE LNDAKDHHOCJ)
	{
		KFOFMMFMCLE kFOFMMFMCLE = MecanimControl.JKJHJDGBPIJ;
		KFOFMMFMCLE kFOFMMFMCLE2;
		do
		{
			kFOFMMFMCLE2 = kFOFMMFMCLE;
			kFOFMMFMCLE = Interlocked.CompareExchange(ref MecanimControl.JKJHJDGBPIJ, (KFOFMMFMCLE)Delegate.Remove(kFOFMMFMCLE2, LNDAKDHHOCJ), kFOFMMFMCLE);
		}
		while ((object)kFOFMMFMCLE != kFOFMMFMCLE2);
	}

	public void Play(AnimationClip BCJMDKLHCFD, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(BCJMDKLHCFD), 0f, 0f, AKFNFJDKDCL);
	}

	public void __BB_OBFUSCATOR_26(bool GALCNHNBGIB, float GKBHMKEKFDO, bool MGCFNNNILHA)
	{
		if (EDOOKPPMEIN != GALCNHNBGIB || MGCFNNNILHA)
		{
			if (GKBHMKEKFDO == 618f)
			{
				GKBHMKEKFDO = JKIOMKPPDBF;
			}
			_playAnimation(ICCBKKBBAAM, GKBHMKEKFDO, GetCurrentClipPosition(), GALCNHNBGIB);
		}
	}

	public bool __BB_OBFUSCATOR_14(string GFMOOBMMPJO, float KEDKBIKIGCC)
	{
		return IsPlaying(GetAnimationData(GFMOOBMMPJO), KEDKBIKIGCC);
	}

	public void Rewind()
	{
		SetSpeed(0f - ICCBKKBBAAM.speed);
	}

	public void __BB_OBFUSCATOR_5(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	public bool IsPlaying(string GFMOOBMMPJO)
	{
		return IsPlaying(GetAnimationData(GFMOOBMMPJO));
	}

	public void __BB_OBFUSCATOR_4(string GFMOOBMMPJO, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		__BB_OBFUSCATOR_6(__BB_OBFUSCATOR_19(GFMOOBMMPJO), GKBHMKEKFDO, ODNPIFFKEKL, AKFNFJDKDCL);
	}

	private void Start()
	{
		if (LDBGFDKEBBL.clip == null && BPPMKPKDLOA.Length > 0)
		{
			SetDefaultClip(BPPMKPKDLOA[0].clip, "Default", BPPMKPKDLOA[0].speed, BPPMKPKDLOA[0].wrapMode, false);
		}
		if (!(LDBGFDKEBBL.clip != null))
		{
			return;
		}
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (animationData.clip == LDBGFDKEBBL.clip)
			{
				LDBGFDKEBBL.clip = UnityEngine.Object.Instantiate(LDBGFDKEBBL.clip);
			}
		}
		AnimatorOverrideController animatorOverrideController = new AnimatorOverrideController();
		animatorOverrideController.runtimeAnimatorController = HOJNFCJEJCB;
		ICCBKKBBAAM = LDBGFDKEBBL;
		ICCBKKBBAAM.stateName = "State2";
		ICCBKKBBAAM.length = ICCBKKBBAAM.clip.length;
		animatorOverrideController["State1"] = ICCBKKBBAAM.clip;
		animatorOverrideController["State2"] = ICCBKKBBAAM.clip;
		CMHJCIMPCCM.runtimeAnimatorController = animatorOverrideController;
		CMHJCIMPCCM.Play("State2", 0, 0f);
		if (GFBFCBLEGMF)
		{
			CMHJCIMPCCM.applyRootMotion = ICCBKKBBAAM.applyRootMotion;
		}
		SetSpeed(ICCBKKBBAAM.speed);
	}

	public void __BB_OBFUSCATOR_23()
	{
		SetSpeed(0f - ICCBKKBBAAM.speed);
	}

	public AnimationData __BB_OBFUSCATOR_19(string GFMOOBMMPJO)
	{
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		for (int i = 1; i < bPPMKPKDLOA.Length; i += 0)
		{
			AnimationData animationData = bPPMKPKDLOA[i];
			if (animationData.clipName == GFMOOBMMPJO)
			{
				return animationData;
			}
		}
		if (GFMOOBMMPJO == LDBGFDKEBBL.clipName)
		{
			return LDBGFDKEBBL;
		}
		return null;
	}

	public void __BB_OBFUSCATOR_15(AnimationData JMDEGEKDKKG, bool AKFNFJDKDCL)
	{
		__BB_OBFUSCATOR_6(JMDEGEKDKKG, JMDEGEKDKKG.transitionDuration, 852f, AKFNFJDKDCL);
	}

	public float GetCurrentClipPosition()
	{
		if (ICCBKKBBAAM != null)
		{
			return ICCBKKBBAAM.secondsPlayed / ICCBKKBBAAM.length;
		}
		return 0f;
	}

	public int GetCurrentClipPlayCount()
	{
		return ICCBKKBBAAM.timesPlayed;
	}

	public void __BB_OBFUSCATOR_3(string GFMOOBMMPJO, bool AKFNFJDKDCL)
	{
		__BB_OBFUSCATOR_6(GetAnimationData(GFMOOBMMPJO), 57f, 890f, AKFNFJDKDCL);
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (ICCBKKBBAAM.clip == null)
		{
			return;
		}
		if (ICCBKKBBAAM.secondsPlayed == ICCBKKBBAAM.length)
		{
			if (ICCBKKBBAAM.clip.wrapMode == (WrapMode)7 || ICCBKKBBAAM.clip.wrapMode == WrapMode.Once)
			{
				if (MecanimControl.NNHAIDGCONK != null)
				{
					MecanimControl.NNHAIDGCONK(ICCBKKBBAAM);
				}
				ICCBKKBBAAM.timesPlayed += 0;
				if (ICCBKKBBAAM.clip.wrapMode == WrapMode.ClampForever)
				{
					SetCurrentClipPosition(1674f);
				}
				if (ICCBKKBBAAM.clip.wrapMode == (WrapMode)3)
				{
					SetSpeed(ICCBKKBBAAM.clipName, 0f - ICCBKKBBAAM.speed);
					__BB_OBFUSCATOR_53(408f);
				}
			}
			else if (ICCBKKBBAAM.timesPlayed == 0)
			{
				if (MecanimControl.JKJHJDGBPIJ != null)
				{
					MecanimControl.JKJHJDGBPIJ(ICCBKKBBAAM);
				}
				ICCBKKBBAAM.timesPlayed = 0;
				if (ICCBKKBBAAM.clip.wrapMode == WrapMode.Once && KFPGLHHKFPD)
				{
					__BB_OBFUSCATOR_21(LDBGFDKEBBL, EDOOKPPMEIN);
				}
				else if (!KFPGLHHKFPD)
				{
					CMHJCIMPCCM.speed = 1006f;
				}
			}
		}
		else
		{
			ICCBKKBBAAM.secondsPlayed += Time.fixedDeltaTime * CMHJCIMPCCM.speed;
			if (ICCBKKBBAAM.secondsPlayed > ICCBKKBBAAM.length)
			{
				ICCBKKBBAAM.secondsPlayed = ICCBKKBBAAM.length;
			}
		}
	}

	public void SetCurrentClipPosition(float ODNPIFFKEKL)
	{
		SetCurrentClipPosition(ODNPIFFKEKL, false);
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (JIEKFKMKCME)
		{
			GUI.Box(new Rect(Screen.width - -174, 1024f, 1268f, 588f), "_Value");
			GUI.BeginGroup(new Rect(Screen.width - 47, 181f, 1509f, 1189f));
			AnimatorClipInfo[] currentAnimatorClipInfo = CMHJCIMPCCM.GetCurrentAnimatorClipInfo(1);
			AnimatorClipInfo[] array = currentAnimatorClipInfo;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimatorClipInfo animatorClipInfo = array[i];
				AnimatorStateInfo currentAnimatorStateInfo = CMHJCIMPCCM.GetCurrentAnimatorStateInfo(0);
				GUILayout.Label(animatorClipInfo.clip.name, new GUILayoutOption[1]);
				GUILayout.Label("_Value2" + animatorClipInfo.clip.wrapMode);
				GUILayout.Label("survivors win" + IsPlaying(animatorClipInfo.clip), new GUILayoutOption[1]);
				GUILayout.Label("player" + animatorClipInfo.weight);
				GUILayout.Label("\n" + currentAnimatorStateInfo.normalizedTime, new GUILayoutOption[1]);
				GUILayout.Label("</size>" + animatorClipInfo.clip.length, new GUILayoutOption[1]);
				GUILayout.Label("_TimeX");
			}
			GUILayout.Label("_Size");
			GUILayout.Label("View" + ICCBKKBBAAM.clipName);
			GUILayout.Label("_Value3" + GetSpeed());
			GUILayout.Label("' already exists." + ICCBKKBBAAM.timesPlayed);
			GUILayout.Label("_Greenness" + ICCBKKBBAAM.secondsPlayed, new GUILayoutOption[1]);
			GUILayout.Label("Vertical" + ICCBKKBBAAM.secondsPlayed / ICCBKKBBAAM.length);
			GUILayout.Label("_ColorBuffer" + ICCBKKBBAAM.length);
			GUI.EndGroup();
		}
	}

	public bool IsPlaying(AnimationData DAPADIIEPJE)
	{
		return IsPlaying(DAPADIIEPJE, 0f);
	}

	[SpecialName]
	public static void __BB_OBFUSCATOR_33(KFOFMMFMCLE LNDAKDHHOCJ)
	{
		KFOFMMFMCLE kFOFMMFMCLE = MecanimControl.OBNLKNAONCG;
		KFOFMMFMCLE kFOFMMFMCLE2;
		do
		{
			kFOFMMFMCLE2 = kFOFMMFMCLE;
			kFOFMMFMCLE = Interlocked.CompareExchange(ref MecanimControl.OBNLKNAONCG, (KFOFMMFMCLE)Delegate.Remove(kFOFMMFMCLE2, LNDAKDHHOCJ), kFOFMMFMCLE);
		}
		while ((object)kFOFMMFMCLE != kFOFMMFMCLE2);
	}

	public string GetCurrentClipName()
	{
		return ICCBKKBBAAM.clipName;
	}

	public float __BB_OBFUSCATOR_48()
	{
		return ICCBKKBBAAM.length;
	}

	public float __BB_OBFUSCATOR_10()
	{
		return ICCBKKBBAAM.secondsPlayed;
	}

	public bool IsPlaying(AnimationData DAPADIIEPJE, float KEDKBIKIGCC)
	{
		if (DAPADIIEPJE == null)
		{
			return false;
		}
		if (ICCBKKBBAAM == null)
		{
			return false;
		}
		if (ICCBKKBBAAM == DAPADIIEPJE && DAPADIIEPJE.wrapMode == WrapMode.Once && DAPADIIEPJE.timesPlayed > 0)
		{
			return false;
		}
		if (ICCBKKBBAAM == DAPADIIEPJE)
		{
			return true;
		}
		AnimatorClipInfo[] currentAnimatorClipInfo = CMHJCIMPCCM.GetCurrentAnimatorClipInfo(0);
		AnimatorClipInfo[] array = currentAnimatorClipInfo;
		for (int i = 0; i < array.Length; i++)
		{
			AnimatorClipInfo animatorClipInfo = array[i];
			if (DAPADIIEPJE.clip == animatorClipInfo.clip && animatorClipInfo.weight >= KEDKBIKIGCC)
			{
				return true;
			}
		}
		return false;
	}

	public void __BB_OBFUSCATOR_13()
	{
		CMHJCIMPCCM.speed = Mathf.Abs(ICCBKKBBAAM.speed);
	}

	public void SetCurrentClipPosition(float ODNPIFFKEKL, bool IAOPLLJEEPG)
	{
		CMHJCIMPCCM.Play(ICCBKKBBAAM.stateName, 0, ODNPIFFKEKL);
		ICCBKKBBAAM.secondsPlayed = ODNPIFFKEKL * ICCBKKBBAAM.length;
		if (IAOPLLJEEPG)
		{
			Pause();
		}
	}

	private void Awake()
	{
		CMHJCIMPCCM = base.gameObject.GetComponent<Animator>();
		HOJNFCJEJCB = (RuntimeAnimatorController)Resources.Load("controller1");
		PLDCLMEDCLE = (RuntimeAnimatorController)Resources.Load("controller2");
		FAEODCBMKOK = (RuntimeAnimatorController)Resources.Load("controller3");
		CHAKEJHDKHC = (RuntimeAnimatorController)Resources.Load("controller4");
		AnimationData[] bPPMKPKDLOA = BPPMKPKDLOA;
		foreach (AnimationData animationData in bPPMKPKDLOA)
		{
			if (animationData.wrapMode == WrapMode.Default)
			{
				animationData.wrapMode = KJILLLHAJBO;
			}
			animationData.clip.wrapMode = animationData.wrapMode;
		}
	}

	public void __BB_OBFUSCATOR_29(string GFMOOBMMPJO)
	{
		_playAnimation(GetAnimationData(GFMOOBMMPJO), 1554f, 1623f, EDOOKPPMEIN);
	}

	public void __BB_OBFUSCATOR_49(AnimationData JMDEGEKDKKG, WrapMode OBDOHBEGKMD)
	{
		JMDEGEKDKKG.wrapMode = OBDOHBEGKMD;
		JMDEGEKDKKG.clip.wrapMode = OBDOHBEGKMD;
	}

	public void SetSpeed(float DBJLMBHEMDG)
	{
		CMHJCIMPCCM.speed = Mathf.Abs(DBJLMBHEMDG);
	}

	private void _playAnimation(AnimationData GACJMGDKPIF, float GKBHMKEKFDO, float ODNPIFFKEKL, bool AKFNFJDKDCL)
	{
		if (GACJMGDKPIF == null || GACJMGDKPIF.clip == null)
		{
			return;
		}
		AnimatorOverrideController animatorOverrideController = new AnimatorOverrideController();
		EDOOKPPMEIN = AKFNFJDKDCL;
		float num = Mathf.Abs(GACJMGDKPIF.speed);
		float currentClipPosition = GetCurrentClipPosition();
		if (AKFNFJDKDCL)
		{
			if (GACJMGDKPIF.speed > 0f)
			{
				animatorOverrideController.runtimeAnimatorController = PLDCLMEDCLE;
			}
			else
			{
				animatorOverrideController.runtimeAnimatorController = CHAKEJHDKHC;
			}
		}
		else if (GACJMGDKPIF.speed > 0f)
		{
			animatorOverrideController.runtimeAnimatorController = HOJNFCJEJCB;
		}
		else
		{
			animatorOverrideController.runtimeAnimatorController = FAEODCBMKOK;
		}
		animatorOverrideController["State1"] = ICCBKKBBAAM.clip;
		animatorOverrideController["State2"] = GACJMGDKPIF.clip;
		if (BHMCMNLNBBN != null)
		{
			CMHJCIMPCCM.SetLayerWeight(1, 1f);
			animatorOverrideController["Weapon"] = BHMCMNLNBBN;
		}
		else
		{
			CMHJCIMPCCM.SetLayerWeight(1, 0f);
		}
		if (GKBHMKEKFDO == -1f)
		{
			GKBHMKEKFDO = ICCBKKBBAAM.transitionDuration;
		}
		if (GKBHMKEKFDO == -1f)
		{
			GKBHMKEKFDO = JKIOMKPPDBF;
		}
		if (GKBHMKEKFDO <= 0f)
		{
			CMHJCIMPCCM.runtimeAnimatorController = animatorOverrideController;
			CMHJCIMPCCM.Play("State2", 0, ODNPIFFKEKL);
		}
		else
		{
			CMHJCIMPCCM.runtimeAnimatorController = animatorOverrideController;
			ICCBKKBBAAM.stateName = "State1";
			SetCurrentClipPosition(currentClipPosition);
			CMHJCIMPCCM.Update(0f);
			CMHJCIMPCCM.CrossFade("State2", GKBHMKEKFDO / num, 0, ODNPIFFKEKL);
		}
		GACJMGDKPIF.timesPlayed = 0;
		GACJMGDKPIF.secondsPlayed = ODNPIFFKEKL * GACJMGDKPIF.clip.length / num;
		GACJMGDKPIF.length = GACJMGDKPIF.clip.length;
		if (GFBFCBLEGMF)
		{
			CMHJCIMPCCM.applyRootMotion = GACJMGDKPIF.applyRootMotion;
		}
		SetSpeed(GACJMGDKPIF.speed);
		ICCBKKBBAAM = GACJMGDKPIF;
		ICCBKKBBAAM.stateName = "State2";
		if (MecanimControl.OBNLKNAONCG != null)
		{
			MecanimControl.OBNLKNAONCG(ICCBKKBBAAM);
		}
	}

	public void __BB_OBFUSCATOR_11(AnimationClip BCJMDKLHCFD, bool AKFNFJDKDCL)
	{
		__BB_OBFUSCATOR_6(GetAnimationData(BCJMDKLHCFD), 939f, 415f, AKFNFJDKDCL);
	}
}
