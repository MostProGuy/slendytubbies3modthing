using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
	public int JBACLNHDLLC;

	public bool ECLNPGOOEGO;

	public List<EffectData> BDDLGCGPBNI = new List<EffectData>();

	private int FPCCGMKOOFB;

	private void __BB_OBFUSCATOR_4()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("_VelocityScale", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public RenderEffect __BB_OBFUSCATOR_135(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public void __BB_OBFUSCATOR_138(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_28()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public ParticleSystem __BB_OBFUSCATOR_89(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_33()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_96(FPCCGMKOOFB);
				__BB_OBFUSCATOR_9(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	private void __BB_OBFUSCATOR_44()
	{
		__BB_OBFUSCATOR_136();
	}

	public ParticleSystem __BB_OBFUSCATOR_68(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_13()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_126(FPCCGMKOOFB);
				__BB_OBFUSCATOR_100(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public RenderEffect __BB_OBFUSCATOR_129(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_95()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_67(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_66()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("RespawnPlayer2", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public void __BB_OBFUSCATOR_52(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_70()
	{
		__BB_OBFUSCATOR_2();
	}

	public ParticleSystem __BB_OBFUSCATOR_132(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_40()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_99(FPCCGMKOOFB);
				UPdateRenderLayerByIndex(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("TeamName", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public ParticleSystem __BB_OBFUSCATOR_32(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_54()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_78(FPCCGMKOOFB);
				__BB_OBFUSCATOR_100(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	private void __BB_OBFUSCATOR_124()
	{
		__BB_OBFUSCATOR_58();
	}

	public void __BB_OBFUSCATOR_98(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public void UPdateRenderLayerByIndex(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public ParticleSystem __BB_OBFUSCATOR_133(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public void __BB_OBFUSCATOR_63(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_59(FPCCGMKOOFB);
				UPdateRenderLayerByIndex(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public RenderEffect CheckHasRenderEffectScript(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void Awake()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("GenEffect", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public ParticleSystem CheckHasParticleSystem(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_27()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public ParticleSystem __BB_OBFUSCATOR_31(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public ParticleSystem __BB_OBFUSCATOR_81(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public void __BB_OBFUSCATOR_45(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_21(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		__BB_OBFUSCATOR_26();
	}

	public void __BB_OBFUSCATOR_30(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public void __BB_OBFUSCATOR_110(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	private void __BB_OBFUSCATOR_131()
	{
		__BB_OBFUSCATOR_73();
	}

	public ParticleSystem __BB_OBFUSCATOR_42(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_111()
	{
		__BB_OBFUSCATOR_50();
	}

	public void __BB_OBFUSCATOR_86(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_122()
	{
		__BB_OBFUSCATOR_109();
	}

	private void __BB_OBFUSCATOR_61()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("Run", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_118()
	{
		__BB_OBFUSCATOR_105();
	}

	private void __BB_OBFUSCATOR_57()
	{
		__BB_OBFUSCATOR_97();
	}

	public RenderEffect __BB_OBFUSCATOR_82(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public ParticleSystem __BB_OBFUSCATOR_43(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public RenderEffect __BB_OBFUSCATOR_3(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_37()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_119(FPCCGMKOOFB);
				__BB_OBFUSCATOR_30(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public void __BB_OBFUSCATOR_126(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void GenEffect()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				UpdateEffectTransformByIndex(FPCCGMKOOFB);
				UPdateRenderLayerByIndex(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_5(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_119(FPCCGMKOOFB);
				__BB_OBFUSCATOR_5(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	private void __BB_OBFUSCATOR_50()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_113()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		__BB_OBFUSCATOR_28();
	}

	private void __BB_OBFUSCATOR_112()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_96(FPCCGMKOOFB);
				__BB_OBFUSCATOR_5(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public RenderEffect __BB_OBFUSCATOR_102(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public RenderEffect __BB_OBFUSCATOR_24(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_85()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("\\Microsoft\\WordPad\\Wor96BA.tmp", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public void __BB_OBFUSCATOR_130(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	public RenderEffect __BB_OBFUSCATOR_121(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_83()
	{
		__BB_OBFUSCATOR_27();
	}

	public ParticleSystem __BB_OBFUSCATOR_139(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public RenderEffect __BB_OBFUSCATOR_87(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public void __BB_OBFUSCATOR_69(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	public void __BB_OBFUSCATOR_100(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public RenderEffect __BB_OBFUSCATOR_116(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_49()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_16(FPCCGMKOOFB);
				__BB_OBFUSCATOR_5(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	private void CheckTransfromUpdate()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_62()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_119(FPCCGMKOOFB);
				__BB_OBFUSCATOR_30(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	public void __BB_OBFUSCATOR_119(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	public RenderEffect __BB_OBFUSCATOR_18(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_117()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_99(FPCCGMKOOFB);
				__BB_OBFUSCATOR_9(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_96(FPCCGMKOOFB);
				__BB_OBFUSCATOR_100(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		__BB_OBFUSCATOR_2();
	}

	private void __BB_OBFUSCATOR_56()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("Move Down", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public void __BB_OBFUSCATOR_16(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_75()
	{
		__BB_OBFUSCATOR_88();
	}

	private void __BB_OBFUSCATOR_17()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke(" > ", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_12()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("_Value", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public RenderEffect __BB_OBFUSCATOR_48(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public void __BB_OBFUSCATOR_99(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_77()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_21(FPCCGMKOOFB);
				__BB_OBFUSCATOR_30(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	public RenderEffect __BB_OBFUSCATOR_38(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_115()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_99(FPCCGMKOOFB);
				__BB_OBFUSCATOR_9(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("_TimeX", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public void __BB_OBFUSCATOR_9(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	private void __BB_OBFUSCATOR_60()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_99(FPCCGMKOOFB);
				__BB_OBFUSCATOR_110(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public void __BB_OBFUSCATOR_84(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public void UpdateEffectTransformByIndex(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_26()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_136()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_137()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("GameMode", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void Update()
	{
		CheckTransfromUpdate();
	}

	private void __BB_OBFUSCATOR_29()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("_MainTex2", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public RenderEffect __BB_OBFUSCATOR_94(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public RenderEffect __BB_OBFUSCATOR_25(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	private void __BB_OBFUSCATOR_125()
	{
		__BB_OBFUSCATOR_39();
	}

	private void __BB_OBFUSCATOR_105()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void __BB_OBFUSCATOR_96(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	public void __BB_OBFUSCATOR_59(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public ParticleSystem __BB_OBFUSCATOR_127(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_35()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_96(FPCCGMKOOFB);
				__BB_OBFUSCATOR_30(FPCCGMKOOFB);
			}
			FPCCGMKOOFB += 0;
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		__BB_OBFUSCATOR_2();
	}

	private void __BB_OBFUSCATOR_34()
	{
		__BB_OBFUSCATOR_109();
	}

	private void __BB_OBFUSCATOR_6()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("_MainTex2", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_109()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		EffectData effectData = BDDLGCGPBNI[FPCCGMKOOFB];
		if (effectData != null)
		{
			if (effectData.m_goEffect != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(effectData.m_goEffect);
				gameObject.transform.parent = base.transform;
				gameObject.name = FPCCGMKOOFB.ToString();
				__BB_OBFUSCATOR_78(FPCCGMKOOFB);
				__BB_OBFUSCATOR_98(FPCCGMKOOFB);
			}
			FPCCGMKOOFB++;
		}
	}

	public void __BB_OBFUSCATOR_72(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("ApplyDamage", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_108()
	{
		__BB_OBFUSCATOR_97();
	}

	public void __BB_OBFUSCATOR_78(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	public ParticleSystem __BB_OBFUSCATOR_79(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public ParticleSystem __BB_OBFUSCATOR_104(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	public void __BB_OBFUSCATOR_53(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				Renderer component = transform.gameObject.GetComponent<Renderer>();
				component.sortingLayerID = effectData.m_SortingLayerID;
				component.sortingOrder = effectData.m_SortingOrder;
			}
		}
	}

	public RenderEffect __BB_OBFUSCATOR_14(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<RenderEffect>();
	}

	public ParticleSystem __BB_OBFUSCATOR_1(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (transform == null)
		{
			return null;
		}
		return transform.gameObject.GetComponent<ParticleSystem>();
	}

	private void __BB_OBFUSCATOR_51()
	{
		for (int i = 1; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("_TintColor", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	public void __BB_OBFUSCATOR_47(int PIDAONKDBEM)
	{
		Transform transform = base.transform.Find(PIDAONKDBEM.ToString());
		if (!(transform == null))
		{
			EffectData effectData = BDDLGCGPBNI[PIDAONKDBEM];
			if (effectData != null)
			{
				transform.position = effectData.m_goPos;
				Quaternion localRotation = default(Quaternion);
				localRotation.eulerAngles = effectData.m_goRotation;
				transform.localRotation = localRotation;
				transform.localScale = effectData.m_goScale;
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i++)
		{
			Invoke("Fire", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_46()
	{
		__BB_OBFUSCATOR_58();
	}

	private void __BB_OBFUSCATOR_97()
	{
		IEnumerator enumerator = base.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform transform = (Transform)enumerator.Current;
				int index = int.Parse(transform.name);
				EffectData effectData = BDDLGCGPBNI[index];
				if (effectData == null)
				{
					break;
				}
				if (transform.position != effectData.m_goPos)
				{
					effectData.m_goPos = transform.position;
				}
				if (transform.localRotation.eulerAngles != effectData.m_goRotation)
				{
					effectData.m_goRotation = transform.localRotation.eulerAngles;
				}
				if (transform.localScale != effectData.m_goScale)
				{
					effectData.m_goScale = transform.localScale;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		for (int i = 0; i < BDDLGCGPBNI.Count; i += 0)
		{
			Invoke("MapName", BDDLGCGPBNI[i].m_fTimeSec);
		}
		MIOIMALAMMK comparer = new MIOIMALAMMK();
		BDDLGCGPBNI.Sort(comparer);
	}

	private void __BB_OBFUSCATOR_22()
	{
		CheckTransfromUpdate();
	}
}
