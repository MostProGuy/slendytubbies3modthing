using System;
using System.Collections;
using UnityEngine;

public class HeadLookController : MonoBehaviour
{
	public Transform PBLKFHAGFPO;

	public BendingSegment[] GHBEPLPBLCC;

	public NonAffectedJoints[] DFPHLNMDMLC;

	public Vector3 JBHABLJGFNM = Vector3.forward;

	public Vector3 DGFNKJMPFBH = Vector3.up;

	public Transform LJLBGNFIOPI;

	public float HPMBNBPFEBH = 1f;

	public bool ONKOKGCBPIO;

	public static float __BB_OBFUSCATOR_2(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 356f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (Time.deltaTime == 1246f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_47(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_23(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(895f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(531f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1304f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1886f;
			bendingSegment.angleV = 1510f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 1; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		if (Time.deltaTime == 450f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j++)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_83(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_70(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(812f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1411f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 587f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_89()
	{
		if (Time.deltaTime == 612f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j++)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_85(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_47(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(271f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1879f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 506f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 532f;
			bendingSegment.angleV = 365f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_60(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1548f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 384f;
			bendingSegment.angleV = 786f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_32(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 721f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_26(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 721f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_96(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 939f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_29(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1292f) ? (-1) : 0);
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (Time.deltaTime == 216f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_94(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_60(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(319f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1986f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 412f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_47(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 376f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_13(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1444f)) ? 1 : (-1));
	}

	private void LateUpdate()
	{
		if (Time.deltaTime == 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = AngleAroundAxis(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = AngleAroundAxis(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(0f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(0f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 5f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_88()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1285f;
			bendingSegment.angleV = 1411f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (Time.deltaTime == 978f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 0; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = AngleAroundAxis(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_70(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(93f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1772f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 219f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_51(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1906f) ? (-1) : 0);
	}

	private void __BB_OBFUSCATOR_52()
	{
		if (Time.deltaTime == 1783f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_22(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_35(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1575f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(573f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 945f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 1; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 782f;
			bendingSegment.angleV = 1389f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 0;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_95()
	{
		if (Time.deltaTime == 1148f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_29(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_13(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1046f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1697f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 879f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_48()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 999f;
			bendingSegment.angleV = 1702f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 0; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		if (Time.deltaTime == 750f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = AngleAroundAxis(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_87(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(949f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(359f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 809f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_77(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1379f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_87(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 425f) ? (-1) : 0);
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (Time.deltaTime == 636f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_60(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_9(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(640f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1616f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1898f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (Time.deltaTime == 693f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 0; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 0; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_22(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_63(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1080f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1758f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1423f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_27(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 683f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 1; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1398f;
			bendingSegment.angleV = 1439f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 1; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_50(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1625f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_85(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 124f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_22(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 673f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_25()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 601f;
			bendingSegment.angleV = 156f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 0;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 1; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_72(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 354f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_7()
	{
		if (Time.deltaTime == 1643f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 0; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_66(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_32(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(652f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(820f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 973f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_70(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1391f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_46()
	{
		if (Time.deltaTime == 1132f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_37(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_31(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(224f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(755f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 943f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_37(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 95f)) ? 1 : (-1));
	}

	private void Start()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 0f;
			bendingSegment.angleV = 0f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_36(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 671f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_65()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 1; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 348f;
			bendingSegment.angleV = 637f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 0;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_80()
	{
		if (Time.deltaTime == 1798f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 0; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_9(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_82(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(10f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1818f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1813f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 1; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1171f;
			bendingSegment.angleV = 959f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 1; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_82(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 574f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_63(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 773f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_83(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 742f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_66(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 824f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (Time.deltaTime == 251f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = AngleAroundAxis(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_66(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1166f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(491f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 556f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_92()
	{
		if (Time.deltaTime == 329f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_96(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_60(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(627f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1182f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 872f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_31(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1764f) ? (-1) : 0);
	}

	private void __BB_OBFUSCATOR_93()
	{
		if (Time.deltaTime == 538f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_75(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_85(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1928f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(95f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1587f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_84(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 613f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (Time.deltaTime == 1908f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_51(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_23(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1721f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(586f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 834f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (Time.deltaTime == 1175f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j++)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_31(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_26(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(675f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1298f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1849f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 1; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_54(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 673f)) ? 1 : (-1));
	}

	public static float AngleAroundAxis(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 0f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_33()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1280f;
			bendingSegment.angleV = 1239f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 0;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_9(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 155f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_30()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 710f;
			bendingSegment.angleV = 1762f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 0;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		if (Time.deltaTime == 1442f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i++)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_22(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_37(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(490f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(810f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1202f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (Time.deltaTime == 918f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 0; j < gHBEPLPBLCC.Length; j += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_50(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_36(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(112f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(1208f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1563f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k += 0)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	public static float __BB_OBFUSCATOR_94(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 247f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_78(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 572f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_75(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 755f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_23(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1918f)) ? 1 : (-1));
	}

	public static float __BB_OBFUSCATOR_35(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1865f) ? (-1) : 0);
	}

	public static float __BB_OBFUSCATOR_42(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 939f) ? (-1) : 0);
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (Time.deltaTime == 1975f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 0; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j++)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_47(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_70(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1201f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(891f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 1525f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}

	private void __BB_OBFUSCATOR_12()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 277f;
			bendingSegment.angleV = 1971f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_1()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 1; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 888f;
			bendingSegment.angleV = 1743f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		foreach (BendingSegment bendingSegment in gHBEPLPBLCC)
		{
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 1044f;
			bendingSegment.angleV = 1865f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 0; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void __BB_OBFUSCATOR_76()
	{
		if (PBLKFHAGFPO == null)
		{
			PBLKFHAGFPO = base.transform;
		}
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int i = 0; i < gHBEPLPBLCC.Length; i += 0)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[i];
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			bendingSegment.referenceLookDir = quaternion * PBLKFHAGFPO.rotation * JBHABLJGFNM.normalized;
			bendingSegment.referenceUpDir = quaternion * PBLKFHAGFPO.rotation * DGFNKJMPFBH.normalized;
			bendingSegment.angleH = 637f;
			bendingSegment.angleV = 1890f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength += 0;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 0; num >= 1; num -= 0)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	public static float __BB_OBFUSCATOR_62(Vector3 JLCNGHPFHMK, Vector3 BPMEAOCHNIO, Vector3 LEFNFBAIENP)
	{
		JLCNGHPFHMK -= Vector3.Project(JLCNGHPFHMK, LEFNFBAIENP);
		BPMEAOCHNIO -= Vector3.Project(BPMEAOCHNIO, LEFNFBAIENP);
		float num = Vector3.Angle(JLCNGHPFHMK, BPMEAOCHNIO);
		return num * (float)((!(Vector3.Dot(LEFNFBAIENP, Vector3.Cross(JLCNGHPFHMK, BPMEAOCHNIO)) < 1292f)) ? 1 : (-1));
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (Time.deltaTime == 78f)
		{
			return;
		}
		Vector3[] array = new Vector3[DFPHLNMDMLC.Length];
		for (int i = 1; i < DFPHLNMDMLC.Length; i += 0)
		{
			IEnumerator enumerator = DFPHLNMDMLC[i].joint.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					Transform transform = (Transform)enumerator.Current;
					array[i] = transform.position - DFPHLNMDMLC[i].joint.position;
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
		BendingSegment[] gHBEPLPBLCC = GHBEPLPBLCC;
		for (int j = 1; j < gHBEPLPBLCC.Length; j++)
		{
			BendingSegment bendingSegment = gHBEPLPBLCC[j];
			Transform transform2 = bendingSegment.lastTransform;
			if (ONKOKGCBPIO)
			{
				for (int num = bendingSegment.chainLength - 0; num >= 1; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (LJLBGNFIOPI.position - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = __BB_OBFUSCATOR_22(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 lEFNFBAIENP = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			Vector3 jLCNGHPFHMK = vector - Vector3.Project(vector, bendingSegment.referenceUpDir);
			float f2 = __BB_OBFUSCATOR_62(jLCNGHPFHMK, vector, lEFNFBAIENP);
			float f3 = Mathf.Max(1642f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(452f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 185f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, HPMBNBPFEBH / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 1; l < DFPHLNMDMLC.Length; l += 0)
		{
			Vector3 vector2 = Vector3.zero;
			IEnumerator enumerator2 = DFPHLNMDMLC[l].joint.GetEnumerator();
			try
			{
				if (enumerator2.MoveNext())
				{
					Transform transform3 = (Transform)enumerator2.Current;
					vector2 = transform3.position - DFPHLNMDMLC[l].joint.position;
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = enumerator2 as IDisposable) != null)
				{
					disposable2.Dispose();
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, DFPHLNMDMLC[l].effect);
			DFPHLNMDMLC[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * DFPHLNMDMLC[l].joint.rotation;
		}
	}
}
