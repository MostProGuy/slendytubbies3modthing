using System;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	[Serializable]
	public class RelevanceSphere
	{
		public bool m_bExpanded;

		public Vector3 m_v3Position;

		public Vector3 m_v3Rotation;

		public Vector3 m_v3Scale;

		public float m_fRelevance;

		public void __BB_OBFUSCATOR_3(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = true;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public RelevanceSphere()
		{
			m_v3Scale = Vector3.one;
		}

		public void __BB_OBFUSCATOR_15(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = true;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_4(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_2(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = true;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_11(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_18(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_7(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_5(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_8(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_13(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_16(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = true;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void SetDefault(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = true;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}

		public void __BB_OBFUSCATOR_6(Transform LJLBGNFIOPI, float PJGOMMJONKF)
		{
			m_bExpanded = false;
			m_v3Position = LJLBGNFIOPI.position + Vector3.up;
			m_v3Rotation = LJLBGNFIOPI.rotation.eulerAngles;
			m_v3Scale = Vector3.one;
			m_fRelevance = PJGOMMJONKF;
		}
	}
}
