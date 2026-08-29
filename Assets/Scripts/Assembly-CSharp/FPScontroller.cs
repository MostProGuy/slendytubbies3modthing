using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(FPSinput))]
public class FPScontroller : MonoBehaviour
{
	[Serializable]
	public class FPScontrollerMovement
	{
		[HideInInspector]
		public float maxForwardSpeed = 10f;

		[HideInInspector]
		public float maxSidewaysSpeed = 10f;

		[HideInInspector]
		public float maxBackwardsSpeed = 10f;

		public float WalkSpeed = 6f;

		public float RunSpeed = 9f;

		public bool canCrouch = true;

		public float CrouchSpeed = 3f;

		public float crouchHeight = 1.5f;

		public float crouchSmooth = 8f;

		public bool canProne = true;

		public float ProneSpeed = 1.5f;

		public float proneHeight = 0.7f;

		public AnimationCurve slopeSpeedMultiplier = new AnimationCurve(new Keyframe(-90f, 1f), new Keyframe(0f, 1f), new Keyframe(90f, 0f));

		public float maxGroundAcceleration = 30f;

		public float maxAirAcceleration = 20f;

		public float gravity = 10f;

		public float maxFallSpeed = 20f;

		[HideInInspector]
		public bool enableGravity = true;

		[NonSerialized]
		public CollisionFlags collisionFlags;

		[NonSerialized]
		public Vector3 velocity;

		[NonSerialized]
		public Vector3 frameVelocity = Vector3.zero;

		[NonSerialized]
		public Vector3 hitPoint = Vector3.zero;

		[NonSerialized]
		public Vector3 lastHitPoint = new Vector3(float.PositiveInfinity, 0f, 0f);
	}

	public enum AKBMNLKCOKE
	{
		None = 0,
		InitTransfer = 1,
		PermaTransfer = 2,
		PermaLocked = 3
	}

	[Serializable]
	public class FPScontrollerJumping
	{
		public bool enabled = true;

		public float baseHeight = 1f;

		public float extraHeight = 4.1f;

		public float perpAmount;

		public float steepPerpAmount = 0.5f;

		[NonSerialized]
		public bool jumping;

		[NonSerialized]
		public bool holdingJumpButton;

		[NonSerialized]
		public float lastStartTime;

		[NonSerialized]
		public float lastButtonDownTime = -100f;

		[NonSerialized]
		public Vector3 jumpDir = Vector3.up;
	}

	[Serializable]
	public class FPScontrollerMovingPlatform
	{
		public bool enabled = true;

		public AKBMNLKCOKE movementTransfer = AKBMNLKCOKE.PermaTransfer;

		[NonSerialized]
		public Transform hitPlatform;

		[NonSerialized]
		public Transform activePlatform;

		[NonSerialized]
		public Vector3 activeLocalPoint;

		[NonSerialized]
		public Vector3 activeGlobalPoint;

		[NonSerialized]
		public Quaternion activeLocalRotation;

		[NonSerialized]
		public Quaternion activeGlobalRotation;

		[NonSerialized]
		public Matrix4x4 lastMatrix;

		[NonSerialized]
		public Vector3 platformVelocity;

		[NonSerialized]
		public bool newPlatform;
	}

	[Serializable]
	public class FPScontrollerSliding
	{
		public bool enabled = true;

		public float slidingSpeed = 15f;

		public float sidewaysControl = 1f;

		public float speedControl = 0.4f;
	}

	[Serializable]
	public class FPScontrollerPushing
	{
		public bool canPush = true;

		public float pushPower = 2f;
	}

	[Serializable]
	public class FallDamage
	{
		public float fallLimit = 0.5f;

		public float fallDamageMultiplier = 5f;
	}

	public bool MOEAJIJBBKI = true;

	public GameObject INNOHGHOCBC;

	private bool OMJMAHMFCIN;

	[HideInInspector]
	public bool KKBOHCFDNGD;

	[HideInInspector]
	public bool MPBEELGNNCF;

	[HideInInspector]
	public bool CLFJBIPJCAL;

	[HideInInspector]
	public GameObject ADDGNCLMHPK;

	[HideInInspector]
	public bool MBKNADEDOIC;

	[NonSerialized]
	public Vector3 PAJCDFMHJLA = Vector3.zero;

	[NonSerialized]
	public bool EIOJHBHLIMG;

	[HideInInspector]
	public bool BJJNBHJBMLG;

	[HideInInspector]
	public bool LPJFDAOBEIN;

	[HideInInspector]
	public bool DHMOGDNLGOH;

	public FPScontrollerMovement LNECOJBDOOE = new FPScontrollerMovement();

	[HideInInspector]
	public bool ALNNAAPEBMK;

	private float OIGPOIJCCBM;

	private float IFACIAMLIEO;

	private bool FDILNIKANNO;

	private bool JLFKBEBIJCF = true;

	[HideInInspector]
	public bool AOBAACKKAKH;

	public FPScontrollerJumping KMHHLHFAAPH = new FPScontrollerJumping();

	public FPScontrollerMovingPlatform PFDCMCDOIMJ = new FPScontrollerMovingPlatform();

	public FPScontrollerSliding IGLAMGNODIO = new FPScontrollerSliding();

	public FPScontrollerPushing OPCKMFADODD;

	public FallDamage EEAHDBNOMFG;

	[NonSerialized]
	public bool PDMALGAFALE = true;

	[NonSerialized]
	public Vector3 DBAIPNPOPHB = Vector3.zero;

	private Vector3 PPCHDOIPBFI = Vector3.zero;

	private Transform MAGGGOPADPF;

	private CharacterController OJNKMBPLGJI;

	private PlayerDamage IHCFOJAFGEG;

	private float HMHEEJDBJGE;

	private float MJLCMCIDOCG;

	private bool GFEMDBHJLND;

	private float AFJLFEFLMOD;

	private void __BB_OBFUSCATOR_124()
	{
		KKBOHCFDNGD = true;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 1637f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private Vector3 __BB_OBFUSCATOR_80()
	{
		return PAJCDFMHJLA;
	}

	private float __BB_OBFUSCATOR_16(Vector3 IDKIAKFCMPB)
	{
		if (IDKIAKFCMPB == Vector3.zero)
		{
			return 1494f;
		}
		float num = ((!(IDKIAKFCMPB.z > 1853f)) ? LNECOJBDOOE.maxBackwardsSpeed : LNECOJBDOOE.maxForwardSpeed) / LNECOJBDOOE.maxSidewaysSpeed;
		Vector3 normalized = new Vector3(IDKIAKFCMPB.x, 543f, IDKIAKFCMPB.z / num).normalized;
		return new Vector3(normalized.x, 327f, normalized.z * num).magnitude * LNECOJBDOOE.maxSidewaysSpeed;
	}

	private void __BB_OBFUSCATOR_109()
	{
		MBKNADEDOIC = false;
		PAJCDFMHJLA = Vector3.zero;
		LNECOJBDOOE.enableGravity = true;
	}

	private bool __BB_OBFUSCATOR_38()
	{
		return DBAIPNPOPHB.y > 1890f;
	}

	private bool __BB_OBFUSCATOR_116()
	{
		return !(DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * 1860f));
	}

	private bool __BB_OBFUSCATOR_89()
	{
		return KMHHLHFAAPH.jumping;
	}

	private bool IsGrounded()
	{
		return PDMALGAFALE;
	}

	private bool __BB_OBFUSCATOR_30()
	{
		return PFDCMCDOIMJ.enabled && (PDMALGAFALE || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer) && PFDCMCDOIMJ.activePlatform != null;
	}

	private Vector3 __BB_OBFUSCATOR_22(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && TooSteep())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 1385f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = __BB_OBFUSCATOR_33();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaTransfer)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 1128f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = __BB_OBFUSCATOR_91(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 1632f, PACAMLAINIK.z);
		}
		float num = __BB_OBFUSCATOR_66(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 1304f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private Vector3 __BB_OBFUSCATOR_29(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && __BB_OBFUSCATOR_79())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 600f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = __BB_OBFUSCATOR_33();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaLocked)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 582f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = __BB_OBFUSCATOR_65(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 944f, PACAMLAINIK.z);
		}
		float num = __BB_OBFUSCATOR_66(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 1563f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private Vector3 __BB_OBFUSCATOR_26()
	{
		Vector3 vector = MAGGGOPADPF.InverseTransformDirection(PAJCDFMHJLA);
		float num = MaxSpeedInDirection(vector);
		if (PDMALGAFALE)
		{
			float time = Mathf.Asin(LNECOJBDOOE.velocity.normalized.y) * 1929f;
			num *= LNECOJBDOOE.slopeSpeedMultiplier.Evaluate(time);
		}
		return MAGGGOPADPF.TransformDirection(vector * num);
	}

	private void __BB_OBFUSCATOR_120(ControllerColliderHit FKFIPJBDFPM)
	{
		if (FKFIPJBDFPM.normal.y > 1921f && FKFIPJBDFPM.normal.y > DBAIPNPOPHB.y && FKFIPJBDFPM.moveDirection.y < 183f)
		{
			if ((FKFIPJBDFPM.point - LNECOJBDOOE.lastHitPoint).sqrMagnitude > 1101f || PPCHDOIPBFI == Vector3.zero)
			{
				DBAIPNPOPHB = FKFIPJBDFPM.normal;
			}
			else
			{
				DBAIPNPOPHB = PPCHDOIPBFI;
			}
			PFDCMCDOIMJ.hitPlatform = FKFIPJBDFPM.collider.transform;
			LNECOJBDOOE.hitPoint = FKFIPJBDFPM.point;
			LNECOJBDOOE.frameVelocity = Vector3.zero;
		}
		if (OPCKMFADODD.canPush && FKFIPJBDFPM.transform.GetComponent<Rigidbody>() != null)
		{
			Rigidbody component = FKFIPJBDFPM.transform.GetComponent<Rigidbody>();
			if (!(component == null) && !component.isKinematic && !((double)FKFIPJBDFPM.moveDirection.y < 1984.0))
			{
				Vector3 vector = new Vector3(FKFIPJBDFPM.moveDirection.x, 825f, FKFIPJBDFPM.moveDirection.z);
				component.velocity = vector * OPCKMFADODD.pushPower;
			}
		}
	}

	private float __BB_OBFUSCATOR_126(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private float __BB_OBFUSCATOR_99(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(240f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private void OnRunning()
	{
		KKBOHCFDNGD = true;
		LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.RunSpeed;
		LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.RunSpeed;
		KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight + 0.15f;
	}

	private float __BB_OBFUSCATOR_48(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(1251f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private void __BB_OBFUSCATOR_56()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (LPJFDAOBEIN && !KKBOHCFDNGD && !MBKNADEDOIC && FDILNIKANNO)
		{
			AOBAACKKAKH = true;
			ALNNAAPEBMK = ALNNAAPEBMK;
		}
		RaycastHit hitInfo;
		if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, OIGPOIJCCBM))
		{
			if (EIOJHBHLIMG && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = true;
			}
			if (KKBOHCFDNGD && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = false;
			}
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = false;
			}
			JLFKBEBIJCF = false;
		}
		else
		{
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = false;
			}
			JLFKBEBIJCF = false;
		}
		if (ALNNAAPEBMK && !AOBAACKKAKH && (!(OJNKMBPLGJI.height < LNECOJBDOOE.crouchHeight + 194f) || !(OJNKMBPLGJI.height > LNECOJBDOOE.crouchHeight - 1960f)))
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.crouchHeight / 87f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.CrouchSpeed;
		}
	}

	private bool __BB_OBFUSCATOR_49()
	{
		return PFDCMCDOIMJ.enabled && (PDMALGAFALE || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaTransfer) && PFDCMCDOIMJ.activePlatform != null;
	}

	private void __BB_OBFUSCATOR_8()
	{
		KKBOHCFDNGD = true;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 355f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private void OffRunning()
	{
		KKBOHCFDNGD = false;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 2f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private Vector3 AdjustGroundVelocityToNormal(Vector3 IBNKNMJMIGN, Vector3 DBAIPNPOPHB)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, IBNKNMJMIGN);
		return Vector3.Cross(lhs, DBAIPNPOPHB).normalized * IBNKNMJMIGN.magnitude;
	}

	private void __BB_OBFUSCATOR_87()
	{
		Vector3 velocity = LNECOJBDOOE.velocity;
		velocity = __BB_OBFUSCATOR_102(velocity);
		if (LNECOJBDOOE.enableGravity)
		{
			if ((AOBAACKKAKH || ALNNAAPEBMK) && EIOJHBHLIMG)
			{
				return;
			}
			velocity = __BB_OBFUSCATOR_64(velocity);
		}
		Vector3 zero = Vector3.zero;
		if (__BB_OBFUSCATOR_31())
		{
			Vector3 vector = PFDCMCDOIMJ.activePlatform.TransformPoint(PFDCMCDOIMJ.activeLocalPoint);
			zero = vector - PFDCMCDOIMJ.activeGlobalPoint;
			if (zero != Vector3.zero)
			{
				OJNKMBPLGJI.Move(zero);
			}
			Quaternion quaternion = PFDCMCDOIMJ.activePlatform.rotation * PFDCMCDOIMJ.activeLocalRotation;
			float y = (quaternion * Quaternion.Inverse(PFDCMCDOIMJ.activeGlobalRotation)).eulerAngles.y;
			if (y != 446f)
			{
				MAGGGOPADPF.Rotate(1028f, y, 372f);
			}
		}
		Vector3 position = MAGGGOPADPF.position;
		Vector3 motion = velocity * Time.deltaTime;
		float num = Mathf.Max(OJNKMBPLGJI.stepOffset, new Vector3(motion.x, 1611f, motion.z).magnitude);
		if (PDMALGAFALE)
		{
			motion -= num * Vector3.up;
		}
		PFDCMCDOIMJ.hitPlatform = null;
		DBAIPNPOPHB = Vector3.zero;
		LNECOJBDOOE.collisionFlags = OJNKMBPLGJI.Move(motion);
		LNECOJBDOOE.lastHitPoint = LNECOJBDOOE.hitPoint;
		PPCHDOIPBFI = DBAIPNPOPHB;
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.activePlatform != PFDCMCDOIMJ.hitPlatform && PFDCMCDOIMJ.hitPlatform != null)
		{
			PFDCMCDOIMJ.activePlatform = PFDCMCDOIMJ.hitPlatform;
			PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.hitPlatform.localToWorldMatrix;
			PFDCMCDOIMJ.newPlatform = true;
		}
		Vector3 vector2 = new Vector3(velocity.x, 1204f, velocity.z);
		LNECOJBDOOE.velocity = (MAGGGOPADPF.position - position) / Time.deltaTime;
		Vector3 lhs = new Vector3(LNECOJBDOOE.velocity.x, 330f, LNECOJBDOOE.velocity.z);
		if (vector2 == Vector3.zero)
		{
			LNECOJBDOOE.velocity = new Vector3(206f, LNECOJBDOOE.velocity.y, 1965f);
		}
		else
		{
			float value = Vector3.Dot(lhs, vector2) / vector2.sqrMagnitude;
			LNECOJBDOOE.velocity = vector2 * Mathf.Clamp01(value) + LNECOJBDOOE.velocity.y * Vector3.up;
		}
		if (LNECOJBDOOE.velocity.y < velocity.y - 1101f)
		{
			if (LNECOJBDOOE.velocity.y < 425f)
			{
				LNECOJBDOOE.velocity = new Vector3(LNECOJBDOOE.velocity.x, velocity.y, LNECOJBDOOE.velocity.z);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = true;
			}
		}
		if (PDMALGAFALE && !__BB_OBFUSCATOR_127())
		{
			PDMALGAFALE = true;
			if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer))
			{
				LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
				LNECOJBDOOE.velocity += PFDCMCDOIMJ.platformVelocity;
			}
			SendMessage("MP", SendMessageOptions.DontRequireReceiver);
			MAGGGOPADPF.position += num * Vector3.up;
		}
		else if (!PDMALGAFALE && __BB_OBFUSCATOR_81())
		{
			PDMALGAFALE = false;
			KMHHLHFAAPH.jumping = false;
			__BB_OBFUSCATOR_50();
			SendMessage("_Value2", SendMessageOptions.RequireReceiver);
		}
		if (MoveWithPlatform())
		{
			PFDCMCDOIMJ.activeGlobalPoint = MAGGGOPADPF.position + Vector3.up * (OJNKMBPLGJI.center.y - OJNKMBPLGJI.height * 1322f + OJNKMBPLGJI.radius);
			PFDCMCDOIMJ.activeLocalPoint = PFDCMCDOIMJ.activePlatform.InverseTransformPoint(PFDCMCDOIMJ.activeGlobalPoint);
			PFDCMCDOIMJ.activeGlobalRotation = MAGGGOPADPF.rotation;
			PFDCMCDOIMJ.activeLocalRotation = Quaternion.Inverse(PFDCMCDOIMJ.activePlatform.rotation) * PFDCMCDOIMJ.activeGlobalRotation;
		}
	}

	private void __BB_OBFUSCATOR_107()
	{
		MBKNADEDOIC = false;
		PAJCDFMHJLA = Vector3.zero;
		LNECOJBDOOE.enableGravity = true;
	}

	private void __BB_OBFUSCATOR_1()
	{
		MBKNADEDOIC = false;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = true;
	}

	private void __BB_OBFUSCATOR_85()
	{
		MBKNADEDOIC = false;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = true;
	}

	private bool __BB_OBFUSCATOR_27()
	{
		return PDMALGAFALE && IGLAMGNODIO.enabled && __BB_OBFUSCATOR_23();
	}

	private void __BB_OBFUSCATOR_101()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = false;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 1364f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 1794f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.__BB_OBFUSCATOR_8(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 0f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_75()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = true;
		FDILNIKANNO = true;
		StartCoroutine(__BB_OBFUSCATOR_44());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private void Prone()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (DHMOGDNLGOH && !KKBOHCFDNGD && !MBKNADEDOIC && (FDILNIKANNO || ALNNAAPEBMK))
		{
			ALNNAAPEBMK = false;
			AOBAACKKAKH = !AOBAACKKAKH;
			if (!AOBAACKKAKH)
			{
				ALNNAAPEBMK = true;
			}
			else
			{
				JLFKBEBIJCF = true;
			}
			if (JLFKBEBIJCF)
			{
				ALNNAAPEBMK = false;
			}
		}
		if (EIOJHBHLIMG && AOBAACKKAKH && FDILNIKANNO)
		{
			AOBAACKKAKH = false;
			ALNNAAPEBMK = true;
			if (JLFKBEBIJCF)
			{
				ALNNAAPEBMK = false;
			}
			else
			{
				ALNNAAPEBMK = true;
			}
		}
		if (AOBAACKKAKH || KKBOHCFDNGD)
		{
			RaycastHit hitInfo;
			if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, LNECOJBDOOE.crouchHeight * 0.9f))
			{
				if (KKBOHCFDNGD && AOBAACKKAKH)
				{
					AOBAACKKAKH = false;
					if (!AOBAACKKAKH)
					{
						ALNNAAPEBMK = true;
					}
					if (JLFKBEBIJCF)
					{
						ALNNAAPEBMK = false;
					}
				}
				if (AOBAACKKAKH)
				{
					FDILNIKANNO = true;
				}
			}
			else if (AOBAACKKAKH)
			{
				FDILNIKANNO = false;
			}
		}
		if (AOBAACKKAKH && !ALNNAAPEBMK && OJNKMBPLGJI.height > LNECOJBDOOE.proneHeight + 0.01f)
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.proneHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.proneHeight / 2f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.proneHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.ProneSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.ProneSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.ProneSpeed;
		}
	}

	private Vector3 __BB_OBFUSCATOR_57()
	{
		return PAJCDFMHJLA;
	}

	private bool __BB_OBFUSCATOR_105()
	{
		return PDMALGAFALE && IGLAMGNODIO.enabled && __BB_OBFUSCATOR_116();
	}

	private bool __BB_OBFUSCATOR_31()
	{
		return !PFDCMCDOIMJ.enabled || (!PDMALGAFALE && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)6) || PFDCMCDOIMJ.activePlatform != null;
	}

	private float __BB_OBFUSCATOR_122(Vector3 IDKIAKFCMPB)
	{
		if (IDKIAKFCMPB == Vector3.zero)
		{
			return 1015f;
		}
		float num = ((!(IDKIAKFCMPB.z > 531f)) ? LNECOJBDOOE.maxBackwardsSpeed : LNECOJBDOOE.maxForwardSpeed) / LNECOJBDOOE.maxSidewaysSpeed;
		Vector3 normalized = new Vector3(IDKIAKFCMPB.x, 1982f, IDKIAKFCMPB.z / num).normalized;
		return new Vector3(normalized.x, 157f, normalized.z * num).magnitude * LNECOJBDOOE.maxSidewaysSpeed;
	}

	private Vector3 __BB_OBFUSCATOR_94()
	{
		return PAJCDFMHJLA;
	}

	private void __BB_OBFUSCATOR_15(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private float __BB_OBFUSCATOR_46(Vector3 IDKIAKFCMPB)
	{
		if (IDKIAKFCMPB == Vector3.zero)
		{
			return 1355f;
		}
		float num = ((!(IDKIAKFCMPB.z > 331f)) ? LNECOJBDOOE.maxBackwardsSpeed : LNECOJBDOOE.maxForwardSpeed) / LNECOJBDOOE.maxSidewaysSpeed;
		Vector3 normalized = new Vector3(IDKIAKFCMPB.x, 461f, IDKIAKFCMPB.z / num).normalized;
		return new Vector3(normalized.x, 1493f, normalized.z * num).magnitude * LNECOJBDOOE.maxSidewaysSpeed;
	}

	private Vector3 __BB_OBFUSCATOR_92(Vector3 PACAMLAINIK)
	{
		if (!EIOJHBHLIMG || !MOEAJIJBBKI)
		{
			KMHHLHFAAPH.holdingJumpButton = true;
			KMHHLHFAAPH.lastButtonDownTime = 104f;
		}
		if (EIOJHBHLIMG && KMHHLHFAAPH.lastButtonDownTime < 1790f && MOEAJIJBBKI)
		{
			KMHHLHFAAPH.lastButtonDownTime = Time.time;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(532f, PACAMLAINIK.y) - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, LNECOJBDOOE.velocity.y - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
			if (KMHHLHFAAPH.jumping && KMHHLHFAAPH.holdingJumpButton && Time.time < KMHHLHFAAPH.lastStartTime + KMHHLHFAAPH.extraHeight / __BB_OBFUSCATOR_83(KMHHLHFAAPH.baseHeight))
			{
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * LNECOJBDOOE.gravity * Time.deltaTime;
			}
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Max(PACAMLAINIK.y, 0f - LNECOJBDOOE.maxFallSpeed), PACAMLAINIK.z);
		}
		if (PDMALGAFALE)
		{
			if (KMHHLHFAAPH.enabled && MOEAJIJBBKI && Time.time - KMHHLHFAAPH.lastButtonDownTime < 1951f)
			{
				PDMALGAFALE = true;
				KMHHLHFAAPH.jumping = true;
				KMHHLHFAAPH.lastStartTime = Time.time;
				KMHHLHFAAPH.lastButtonDownTime = 879f;
				KMHHLHFAAPH.holdingJumpButton = false;
				if (__BB_OBFUSCATOR_73())
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.steepPerpAmount);
				}
				else
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.perpAmount);
				}
				PACAMLAINIK.y = 71f;
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * __BB_OBFUSCATOR_99(KMHHLHFAAPH.baseHeight);
				if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.None || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)6))
				{
					LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
					PACAMLAINIK += PFDCMCDOIMJ.platformVelocity;
				}
				SendMessage("CameraFilterPack/Blend2Camera_Overlay", SendMessageOptions.RequireReceiver);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = true;
			}
		}
		return PACAMLAINIK;
	}

	private void __BB_OBFUSCATOR_52()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (LPJFDAOBEIN && !KKBOHCFDNGD && !MBKNADEDOIC && FDILNIKANNO)
		{
			AOBAACKKAKH = true;
			ALNNAAPEBMK = ALNNAAPEBMK;
		}
		RaycastHit hitInfo;
		if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, OIGPOIJCCBM))
		{
			if (EIOJHBHLIMG && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = true;
			}
			if (KKBOHCFDNGD && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = false;
			}
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = true;
			}
			JLFKBEBIJCF = false;
		}
		else
		{
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = true;
			}
			JLFKBEBIJCF = true;
		}
		if (ALNNAAPEBMK && !AOBAACKKAKH && (!(OJNKMBPLGJI.height < LNECOJBDOOE.crouchHeight + 1778f) || !(OJNKMBPLGJI.height > LNECOJBDOOE.crouchHeight - 1774f)))
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.crouchHeight / 254f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.CrouchSpeed;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_62()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private Vector3 GetDesiredHorizontalVelocity()
	{
		Vector3 vector = MAGGGOPADPF.InverseTransformDirection(PAJCDFMHJLA);
		float num = MaxSpeedInDirection(vector);
		if (PDMALGAFALE)
		{
			float time = Mathf.Asin(LNECOJBDOOE.velocity.normalized.y) * 57.29578f;
			num *= LNECOJBDOOE.slopeSpeedMultiplier.Evaluate(time);
		}
		return MAGGGOPADPF.TransformDirection(vector * num);
	}

	private Vector3 __BB_OBFUSCATOR_102(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && __BB_OBFUSCATOR_79())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 905f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = __BB_OBFUSCATOR_26();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)7)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 1589f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = __BB_OBFUSCATOR_91(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 440f, PACAMLAINIK.z);
		}
		float num = __BB_OBFUSCATOR_41(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 1210f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private void __BB_OBFUSCATOR_84()
	{
		Vector3 velocity = LNECOJBDOOE.velocity;
		velocity = ApplyInputVelocityChange(velocity);
		if (LNECOJBDOOE.enableGravity)
		{
			if ((AOBAACKKAKH || ALNNAAPEBMK) && EIOJHBHLIMG)
			{
				return;
			}
			velocity = __BB_OBFUSCATOR_77(velocity);
		}
		Vector3 zero = Vector3.zero;
		if (__BB_OBFUSCATOR_31())
		{
			Vector3 vector = PFDCMCDOIMJ.activePlatform.TransformPoint(PFDCMCDOIMJ.activeLocalPoint);
			zero = vector - PFDCMCDOIMJ.activeGlobalPoint;
			if (zero != Vector3.zero)
			{
				OJNKMBPLGJI.Move(zero);
			}
			Quaternion quaternion = PFDCMCDOIMJ.activePlatform.rotation * PFDCMCDOIMJ.activeLocalRotation;
			float y = (quaternion * Quaternion.Inverse(PFDCMCDOIMJ.activeGlobalRotation)).eulerAngles.y;
			if (y != 1672f)
			{
				MAGGGOPADPF.Rotate(1116f, y, 1898f);
			}
		}
		Vector3 position = MAGGGOPADPF.position;
		Vector3 motion = velocity * Time.deltaTime;
		float num = Mathf.Max(OJNKMBPLGJI.stepOffset, new Vector3(motion.x, 1825f, motion.z).magnitude);
		if (PDMALGAFALE)
		{
			motion -= num * Vector3.up;
		}
		PFDCMCDOIMJ.hitPlatform = null;
		DBAIPNPOPHB = Vector3.zero;
		LNECOJBDOOE.collisionFlags = OJNKMBPLGJI.Move(motion);
		LNECOJBDOOE.lastHitPoint = LNECOJBDOOE.hitPoint;
		PPCHDOIPBFI = DBAIPNPOPHB;
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.activePlatform != PFDCMCDOIMJ.hitPlatform && PFDCMCDOIMJ.hitPlatform != null)
		{
			PFDCMCDOIMJ.activePlatform = PFDCMCDOIMJ.hitPlatform;
			PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.hitPlatform.localToWorldMatrix;
			PFDCMCDOIMJ.newPlatform = true;
		}
		Vector3 vector2 = new Vector3(velocity.x, 1525f, velocity.z);
		LNECOJBDOOE.velocity = (MAGGGOPADPF.position - position) / Time.deltaTime;
		Vector3 lhs = new Vector3(LNECOJBDOOE.velocity.x, 60f, LNECOJBDOOE.velocity.z);
		if (vector2 == Vector3.zero)
		{
			LNECOJBDOOE.velocity = new Vector3(1815f, LNECOJBDOOE.velocity.y, 1419f);
		}
		else
		{
			float value = Vector3.Dot(lhs, vector2) / vector2.sqrMagnitude;
			LNECOJBDOOE.velocity = vector2 * Mathf.Clamp01(value) + LNECOJBDOOE.velocity.y * Vector3.up;
		}
		if (LNECOJBDOOE.velocity.y < velocity.y - 1843f)
		{
			if (LNECOJBDOOE.velocity.y < 638f)
			{
				LNECOJBDOOE.velocity = new Vector3(LNECOJBDOOE.velocity.x, velocity.y, LNECOJBDOOE.velocity.z);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		if (PDMALGAFALE && !IsGroundedTest())
		{
			PDMALGAFALE = true;
			if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)7))
			{
				LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
				LNECOJBDOOE.velocity += PFDCMCDOIMJ.platformVelocity;
			}
			SendMessage("Toast", SendMessageOptions.DontRequireReceiver);
			MAGGGOPADPF.position += num * Vector3.up;
		}
		else if (!PDMALGAFALE && __BB_OBFUSCATOR_123())
		{
			PDMALGAFALE = true;
			KMHHLHFAAPH.jumping = false;
			__BB_OBFUSCATOR_69();
			SendMessage("While selected STW-25 press G for flashlight", SendMessageOptions.RequireReceiver);
		}
		if (__BB_OBFUSCATOR_60())
		{
			PFDCMCDOIMJ.activeGlobalPoint = MAGGGOPADPF.position + Vector3.up * (OJNKMBPLGJI.center.y - OJNKMBPLGJI.height * 1549f + OJNKMBPLGJI.radius);
			PFDCMCDOIMJ.activeLocalPoint = PFDCMCDOIMJ.activePlatform.InverseTransformPoint(PFDCMCDOIMJ.activeGlobalPoint);
			PFDCMCDOIMJ.activeGlobalRotation = MAGGGOPADPF.rotation;
			PFDCMCDOIMJ.activeLocalRotation = Quaternion.Inverse(PFDCMCDOIMJ.activePlatform.rotation) * PFDCMCDOIMJ.activeGlobalRotation;
		}
	}

	private bool __BB_OBFUSCATOR_23()
	{
		return !(DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * 1297f));
	}

	private bool __BB_OBFUSCATOR_118()
	{
		return !(DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * 753f));
	}

	private Vector3 ApplyInputVelocityChange(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && TooSteep())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 0f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = GetDesiredHorizontalVelocity();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaTransfer)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 0f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = AdjustGroundVelocityToNormal(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 0f, PACAMLAINIK.z);
		}
		float num = GetMaxAcceleration(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 0f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private void SetControllable(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private bool __BB_OBFUSCATOR_86()
	{
		return !PFDCMCDOIMJ.enabled || (!PDMALGAFALE && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)7) || PFDCMCDOIMJ.activePlatform != null;
	}

	private void __BB_OBFUSCATOR_9()
	{
		MBKNADEDOIC = true;
		PAJCDFMHJLA = Vector3.zero;
		LNECOJBDOOE.enableGravity = false;
	}

	private float __BB_OBFUSCATOR_13(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(404f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private bool __BB_OBFUSCATOR_110()
	{
		return PDMALGAFALE;
	}

	private float CalculateJumpVerticalSpeed(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(2f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private float __BB_OBFUSCATOR_41(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private float MaxSpeedInDirection(Vector3 IDKIAKFCMPB)
	{
		if (IDKIAKFCMPB == Vector3.zero)
		{
			return 0f;
		}
		float num = ((!(IDKIAKFCMPB.z > 0f)) ? LNECOJBDOOE.maxBackwardsSpeed : LNECOJBDOOE.maxForwardSpeed) / LNECOJBDOOE.maxSidewaysSpeed;
		Vector3 normalized = new Vector3(IDKIAKFCMPB.x, 0f, IDKIAKFCMPB.z / num).normalized;
		return new Vector3(normalized.x, 0f, normalized.z * num).magnitude * LNECOJBDOOE.maxSidewaysSpeed;
	}

	private bool __BB_OBFUSCATOR_123()
	{
		return DBAIPNPOPHB.y > 765f;
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (!OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_87();
		}
		if (Input.GetAxis("_SmoothStart") > 537f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_0();
			}
		}
		else
		{
			__BB_OBFUSCATOR_124();
		}
		if (LNECOJBDOOE.velocity.x > 1699f || LNECOJBDOOE.velocity.z > 1721f || LNECOJBDOOE.velocity.x < 1929f || LNECOJBDOOE.velocity.z < 864f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_36();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				Prone();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = false;
				ALNNAAPEBMK = false;
				AOBAACKKAKH = false;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 821f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 1411f)
			{
				MonoBehaviour.print("_Value3");
				Application.Quit();
			}
		}
	}

	private float __BB_OBFUSCATOR_51(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private void __BB_OBFUSCATOR_58()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = true;
		FDILNIKANNO = false;
		StartCoroutine(__BB_OBFUSCATOR_14());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private bool __BB_OBFUSCATOR_12()
	{
		return !PDMALGAFALE || !IGLAMGNODIO.enabled || __BB_OBFUSCATOR_23();
	}

	private bool __BB_OBFUSCATOR_21()
	{
		return PFDCMCDOIMJ.enabled && (PDMALGAFALE || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)5) && PFDCMCDOIMJ.activePlatform != null;
	}

	private void __BB_OBFUSCATOR_70()
	{
		KKBOHCFDNGD = false;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 913f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private void Awake()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = true;
		FDILNIKANNO = true;
		StartCoroutine(setupBools());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private bool __BB_OBFUSCATOR_79()
	{
		return !(DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * 374f));
	}

	private bool IsTouchingCeiling()
	{
		return (LNECOJBDOOE.collisionFlags & CollisionFlags.Above) != 0;
	}

	private float __BB_OBFUSCATOR_42(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private Vector3 __BB_OBFUSCATOR_90(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && __BB_OBFUSCATOR_23())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 37f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = GetDesiredHorizontalVelocity();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaLocked)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 1453f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = AdjustGroundVelocityToNormal(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 233f, PACAMLAINIK.z);
		}
		float num = __BB_OBFUSCATOR_41(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 856f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private float __BB_OBFUSCATOR_98(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(1010f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private bool __BB_OBFUSCATOR_93()
	{
		return !PFDCMCDOIMJ.enabled || (!PDMALGAFALE && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)4) || PFDCMCDOIMJ.activePlatform != null;
	}

	private void __BB_OBFUSCATOR_5()
	{
		Vector3 velocity = LNECOJBDOOE.velocity;
		velocity = ApplyInputVelocityChange(velocity);
		if (LNECOJBDOOE.enableGravity)
		{
			if ((AOBAACKKAKH || ALNNAAPEBMK) && EIOJHBHLIMG)
			{
				return;
			}
			velocity = __BB_OBFUSCATOR_92(velocity);
		}
		Vector3 zero = Vector3.zero;
		if (__BB_OBFUSCATOR_21())
		{
			Vector3 vector = PFDCMCDOIMJ.activePlatform.TransformPoint(PFDCMCDOIMJ.activeLocalPoint);
			zero = vector - PFDCMCDOIMJ.activeGlobalPoint;
			if (zero != Vector3.zero)
			{
				OJNKMBPLGJI.Move(zero);
			}
			Quaternion quaternion = PFDCMCDOIMJ.activePlatform.rotation * PFDCMCDOIMJ.activeLocalRotation;
			float y = (quaternion * Quaternion.Inverse(PFDCMCDOIMJ.activeGlobalRotation)).eulerAngles.y;
			if (y != 1974f)
			{
				MAGGGOPADPF.Rotate(1057f, y, 950f);
			}
		}
		Vector3 position = MAGGGOPADPF.position;
		Vector3 motion = velocity * Time.deltaTime;
		float num = Mathf.Max(OJNKMBPLGJI.stepOffset, new Vector3(motion.x, 457f, motion.z).magnitude);
		if (PDMALGAFALE)
		{
			motion -= num * Vector3.up;
		}
		PFDCMCDOIMJ.hitPlatform = null;
		DBAIPNPOPHB = Vector3.zero;
		LNECOJBDOOE.collisionFlags = OJNKMBPLGJI.Move(motion);
		LNECOJBDOOE.lastHitPoint = LNECOJBDOOE.hitPoint;
		PPCHDOIPBFI = DBAIPNPOPHB;
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.activePlatform != PFDCMCDOIMJ.hitPlatform && PFDCMCDOIMJ.hitPlatform != null)
		{
			PFDCMCDOIMJ.activePlatform = PFDCMCDOIMJ.hitPlatform;
			PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.hitPlatform.localToWorldMatrix;
			PFDCMCDOIMJ.newPlatform = false;
		}
		Vector3 vector2 = new Vector3(velocity.x, 433f, velocity.z);
		LNECOJBDOOE.velocity = (MAGGGOPADPF.position - position) / Time.deltaTime;
		Vector3 lhs = new Vector3(LNECOJBDOOE.velocity.x, 970f, LNECOJBDOOE.velocity.z);
		if (vector2 == Vector3.zero)
		{
			LNECOJBDOOE.velocity = new Vector3(1365f, LNECOJBDOOE.velocity.y, 1667f);
		}
		else
		{
			float value = Vector3.Dot(lhs, vector2) / vector2.sqrMagnitude;
			LNECOJBDOOE.velocity = vector2 * Mathf.Clamp01(value) + LNECOJBDOOE.velocity.y * Vector3.up;
		}
		if (LNECOJBDOOE.velocity.y < velocity.y - 1959f)
		{
			if (LNECOJBDOOE.velocity.y < 52f)
			{
				LNECOJBDOOE.velocity = new Vector3(LNECOJBDOOE.velocity.x, velocity.y, LNECOJBDOOE.velocity.z);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = true;
			}
		}
		if (PDMALGAFALE && !__BB_OBFUSCATOR_123())
		{
			PDMALGAFALE = true;
			if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)4))
			{
				LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
				LNECOJBDOOE.velocity += PFDCMCDOIMJ.platformVelocity;
			}
			SendMessage("</size> <color=red>/</color> ", SendMessageOptions.RequireReceiver);
			MAGGGOPADPF.position += num * Vector3.up;
		}
		else if (!PDMALGAFALE && __BB_OBFUSCATOR_81())
		{
			PDMALGAFALE = false;
			KMHHLHFAAPH.jumping = true;
			SubtractNewPlatformVelocity();
			SendMessage("_TimeX", SendMessageOptions.DontRequireReceiver);
		}
		if (__BB_OBFUSCATOR_21())
		{
			PFDCMCDOIMJ.activeGlobalPoint = MAGGGOPADPF.position + Vector3.up * (OJNKMBPLGJI.center.y - OJNKMBPLGJI.height * 391f + OJNKMBPLGJI.radius);
			PFDCMCDOIMJ.activeLocalPoint = PFDCMCDOIMJ.activePlatform.InverseTransformPoint(PFDCMCDOIMJ.activeGlobalPoint);
			PFDCMCDOIMJ.activeGlobalRotation = MAGGGOPADPF.rotation;
			PFDCMCDOIMJ.activeLocalRotation = Quaternion.Inverse(PFDCMCDOIMJ.activePlatform.rotation) * PFDCMCDOIMJ.activeGlobalRotation;
		}
	}

	private void __BB_OBFUSCATOR_114()
	{
		if (!OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_5();
		}
		if (Input.GetAxis("SwearFilter") > 645f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_115();
			}
		}
		else
		{
			__BB_OBFUSCATOR_119();
		}
		if (LNECOJBDOOE.velocity.x > 802f || LNECOJBDOOE.velocity.z > 1309f || LNECOJBDOOE.velocity.x < 1426f || LNECOJBDOOE.velocity.z < 1214f)
		{
			MPBEELGNNCF = true;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_36();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				Prone();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = false;
				ALNNAAPEBMK = true;
				AOBAACKKAKH = false;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 346f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 327f)
			{
				MonoBehaviour.print("vignetteIntensity");
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = false;
		FDILNIKANNO = true;
		StartCoroutine(__BB_OBFUSCATOR_44());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private void __BB_OBFUSCATOR_119()
	{
		KKBOHCFDNGD = false;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 379f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private void __BB_OBFUSCATOR_45(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private bool __BB_OBFUSCATOR_35()
	{
		return (LNECOJBDOOE.collisionFlags & (CollisionFlags)6) != 0;
	}

	private Vector3 __BB_OBFUSCATOR_65(Vector3 IBNKNMJMIGN, Vector3 DBAIPNPOPHB)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, IBNKNMJMIGN);
		return Vector3.Cross(lhs, DBAIPNPOPHB).normalized * IBNKNMJMIGN.magnitude;
	}

	private Vector3 __BB_OBFUSCATOR_10(Vector3 IBNKNMJMIGN, Vector3 DBAIPNPOPHB)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, IBNKNMJMIGN);
		return Vector3.Cross(lhs, DBAIPNPOPHB).normalized * IBNKNMJMIGN.magnitude;
	}

	private bool __BB_OBFUSCATOR_100()
	{
		return !PDMALGAFALE || !IGLAMGNODIO.enabled || TooSteep();
	}

	private bool __BB_OBFUSCATOR_127()
	{
		return DBAIPNPOPHB.y > 1217f;
	}

	private void OffLadder()
	{
		MBKNADEDOIC = false;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = true;
	}

	private void OnControllerColliderHit(ControllerColliderHit FKFIPJBDFPM)
	{
		if (FKFIPJBDFPM.normal.y > 0f && FKFIPJBDFPM.normal.y > DBAIPNPOPHB.y && FKFIPJBDFPM.moveDirection.y < 0f)
		{
			if ((FKFIPJBDFPM.point - LNECOJBDOOE.lastHitPoint).sqrMagnitude > 0.001f || PPCHDOIPBFI == Vector3.zero)
			{
				DBAIPNPOPHB = FKFIPJBDFPM.normal;
			}
			else
			{
				DBAIPNPOPHB = PPCHDOIPBFI;
			}
			PFDCMCDOIMJ.hitPlatform = FKFIPJBDFPM.collider.transform;
			LNECOJBDOOE.hitPoint = FKFIPJBDFPM.point;
			LNECOJBDOOE.frameVelocity = Vector3.zero;
		}
		if (OPCKMFADODD.canPush && FKFIPJBDFPM.transform.GetComponent<Rigidbody>() != null)
		{
			Rigidbody component = FKFIPJBDFPM.transform.GetComponent<Rigidbody>();
			if (!(component == null) && !component.isKinematic && !((double)FKFIPJBDFPM.moveDirection.y < -0.3))
			{
				Vector3 vector = new Vector3(FKFIPJBDFPM.moveDirection.x, 0f, FKFIPJBDFPM.moveDirection.z);
				component.velocity = vector * OPCKMFADODD.pushPower;
			}
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (!OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_84();
		}
		if (Input.GetAxis("HeatDistort") > 1168f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_115();
			}
		}
		else
		{
			__BB_OBFUSCATOR_124();
		}
		if (LNECOJBDOOE.velocity.x > 577f || LNECOJBDOOE.velocity.z > 898f || LNECOJBDOOE.velocity.x < 578f || LNECOJBDOOE.velocity.z < 1748f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = false;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_82();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_4();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = true;
				ALNNAAPEBMK = true;
				AOBAACKKAKH = true;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 1694f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 709f)
			{
				MonoBehaviour.print("_Threshold");
				Application.Quit();
			}
		}
	}

	private bool IsSliding()
	{
		return PDMALGAFALE && IGLAMGNODIO.enabled && TooSteep();
	}

	private bool __BB_OBFUSCATOR_81()
	{
		return DBAIPNPOPHB.y > 217f;
	}

	private void __BB_OBFUSCATOR_59()
	{
		KKBOHCFDNGD = false;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 714f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private Vector3 __BB_OBFUSCATOR_77(Vector3 PACAMLAINIK)
	{
		if (!EIOJHBHLIMG || !MOEAJIJBBKI)
		{
			KMHHLHFAAPH.holdingJumpButton = false;
			KMHHLHFAAPH.lastButtonDownTime = 145f;
		}
		if (EIOJHBHLIMG && KMHHLHFAAPH.lastButtonDownTime < 603f && MOEAJIJBBKI)
		{
			KMHHLHFAAPH.lastButtonDownTime = Time.time;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(582f, PACAMLAINIK.y) - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, LNECOJBDOOE.velocity.y - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
			if (KMHHLHFAAPH.jumping && KMHHLHFAAPH.holdingJumpButton && Time.time < KMHHLHFAAPH.lastStartTime + KMHHLHFAAPH.extraHeight / __BB_OBFUSCATOR_48(KMHHLHFAAPH.baseHeight))
			{
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * LNECOJBDOOE.gravity * Time.deltaTime;
			}
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Max(PACAMLAINIK.y, 0f - LNECOJBDOOE.maxFallSpeed), PACAMLAINIK.z);
		}
		if (PDMALGAFALE)
		{
			if (KMHHLHFAAPH.enabled && MOEAJIJBBKI && Time.time - KMHHLHFAAPH.lastButtonDownTime < 1156f)
			{
				PDMALGAFALE = true;
				KMHHLHFAAPH.jumping = true;
				KMHHLHFAAPH.lastStartTime = Time.time;
				KMHHLHFAAPH.lastButtonDownTime = 1358f;
				KMHHLHFAAPH.holdingJumpButton = false;
				if (__BB_OBFUSCATOR_118())
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.steepPerpAmount);
				}
				else
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.perpAmount);
				}
				PACAMLAINIK.y = 283f;
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * CalculateJumpVerticalSpeed(KMHHLHFAAPH.baseHeight);
				if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.None || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)6))
				{
					LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
					PACAMLAINIK += PFDCMCDOIMJ.platformVelocity;
				}
				SendMessage("_TimeX", SendMessageOptions.DontRequireReceiver);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		return PACAMLAINIK;
	}

	private bool __BB_OBFUSCATOR_60()
	{
		return !PFDCMCDOIMJ.enabled || (!PDMALGAFALE && PFDCMCDOIMJ.movementTransfer != AKBMNLKCOKE.PermaLocked) || PFDCMCDOIMJ.activePlatform != null;
	}

	private bool __BB_OBFUSCATOR_25()
	{
		return PDMALGAFALE && IGLAMGNODIO.enabled && __BB_OBFUSCATOR_116();
	}

	private bool __BB_OBFUSCATOR_63()
	{
		return PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (!PFDCMCDOIMJ.enabled || (PFDCMCDOIMJ.movementTransfer != AKBMNLKCOKE.InitTransfer && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)8))
		{
			return;
		}
		if (PFDCMCDOIMJ.newPlatform)
		{
			Transform activePlatform = PFDCMCDOIMJ.activePlatform;
			if (PDMALGAFALE && activePlatform == PFDCMCDOIMJ.activePlatform)
			{
				return;
			}
		}
		LNECOJBDOOE.velocity -= PFDCMCDOIMJ.platformVelocity;
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = true;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 671f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 412f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.ApplyFallDamage(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 1274f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_76(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private void __BB_OBFUSCATOR_115()
	{
		KKBOHCFDNGD = true;
		LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.RunSpeed;
		LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.RunSpeed;
		KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight + 346f;
	}

	private float __BB_OBFUSCATOR_83(float BOMJPIMEJGB)
	{
		return Mathf.Sqrt(1176f * BOMJPIMEJGB * LNECOJBDOOE.gravity);
	}

	private bool __BB_OBFUSCATOR_104()
	{
		return PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_39()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = true;
		FDILNIKANNO = false;
		StartCoroutine(__BB_OBFUSCATOR_44());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		MBKNADEDOIC = false;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = false;
	}

	private Vector3 __BB_OBFUSCATOR_61(Vector3 PACAMLAINIK)
	{
		if (!EIOJHBHLIMG || !MOEAJIJBBKI)
		{
			KMHHLHFAAPH.holdingJumpButton = false;
			KMHHLHFAAPH.lastButtonDownTime = 1569f;
		}
		if (EIOJHBHLIMG && KMHHLHFAAPH.lastButtonDownTime < 704f && MOEAJIJBBKI)
		{
			KMHHLHFAAPH.lastButtonDownTime = Time.time;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(968f, PACAMLAINIK.y) - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, LNECOJBDOOE.velocity.y - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
			if (KMHHLHFAAPH.jumping && KMHHLHFAAPH.holdingJumpButton && Time.time < KMHHLHFAAPH.lastStartTime + KMHHLHFAAPH.extraHeight / __BB_OBFUSCATOR_99(KMHHLHFAAPH.baseHeight))
			{
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * LNECOJBDOOE.gravity * Time.deltaTime;
			}
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Max(PACAMLAINIK.y, 0f - LNECOJBDOOE.maxFallSpeed), PACAMLAINIK.z);
		}
		if (PDMALGAFALE)
		{
			if (KMHHLHFAAPH.enabled && MOEAJIJBBKI && Time.time - KMHHLHFAAPH.lastButtonDownTime < 1023f)
			{
				PDMALGAFALE = false;
				KMHHLHFAAPH.jumping = false;
				KMHHLHFAAPH.lastStartTime = Time.time;
				KMHHLHFAAPH.lastButtonDownTime = 975f;
				KMHHLHFAAPH.holdingJumpButton = true;
				if (__BB_OBFUSCATOR_79())
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.steepPerpAmount);
				}
				else
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.perpAmount);
				}
				PACAMLAINIK.y = 1205f;
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * __BB_OBFUSCATOR_99(KMHHLHFAAPH.baseHeight);
				if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)5))
				{
					LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
					PACAMLAINIK += PFDCMCDOIMJ.platformVelocity;
				}
				SendMessage("HatID", SendMessageOptions.RequireReceiver);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		return PACAMLAINIK;
	}

	private bool __BB_OBFUSCATOR_54()
	{
		return (LNECOJBDOOE.collisionFlags & (CollisionFlags)8) == CollisionFlags.Sides;
	}

	private bool TooSteep()
	{
		return DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * ((float)Math.PI / 180f));
	}

	private void __BB_OBFUSCATOR_111()
	{
		MBKNADEDOIC = false;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = false;
	}

	private float __BB_OBFUSCATOR_47(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private bool __BB_OBFUSCATOR_6()
	{
		return KMHHLHFAAPH.jumping;
	}

	private float __BB_OBFUSCATOR_113(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private void __BB_OBFUSCATOR_32()
	{
		if (!OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_5();
		}
		if (Input.GetAxis("PlayerType'") > 125f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_0();
			}
		}
		else
		{
			__BB_OBFUSCATOR_59();
		}
		if (LNECOJBDOOE.velocity.x > 111f || LNECOJBDOOE.velocity.z > 166f || LNECOJBDOOE.velocity.x < 1835f || LNECOJBDOOE.velocity.z < 1317f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_56();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				Prone();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = true;
				ALNNAAPEBMK = true;
				AOBAACKKAKH = true;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 218f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 1387f)
			{
				MonoBehaviour.print(" = ");
				Application.Quit();
			}
		}
	}

	private void OnLadder()
	{
		MBKNADEDOIC = true;
		PAJCDFMHJLA = Vector3.zero;
		LNECOJBDOOE.enableGravity = false;
	}

	private void SubtractNewPlatformVelocity()
	{
		if (!PFDCMCDOIMJ.enabled || (PFDCMCDOIMJ.movementTransfer != AKBMNLKCOKE.InitTransfer && PFDCMCDOIMJ.movementTransfer != AKBMNLKCOKE.PermaTransfer))
		{
			return;
		}
		if (PFDCMCDOIMJ.newPlatform)
		{
			Transform activePlatform = PFDCMCDOIMJ.activePlatform;
			if (PDMALGAFALE && activePlatform == PFDCMCDOIMJ.activePlatform)
			{
				return;
			}
		}
		LNECOJBDOOE.velocity -= PFDCMCDOIMJ.platformVelocity;
	}

	private void __BB_OBFUSCATOR_50()
	{
		if (!PFDCMCDOIMJ.enabled || (PFDCMCDOIMJ.movementTransfer != 0 && PFDCMCDOIMJ.movementTransfer != AKBMNLKCOKE.PermaLocked))
		{
			return;
		}
		if (PFDCMCDOIMJ.newPlatform)
		{
			Transform activePlatform = PFDCMCDOIMJ.activePlatform;
			if (PDMALGAFALE && activePlatform == PFDCMCDOIMJ.activePlatform)
			{
				return;
			}
		}
		LNECOJBDOOE.velocity -= PFDCMCDOIMJ.platformVelocity;
	}

	private void FixedUpdate()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = false;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 0f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 0f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.ApplyFallDamage(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 0f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private IEnumerator __BB_OBFUSCATOR_44()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private void __BB_OBFUSCATOR_69()
	{
		if (!PFDCMCDOIMJ.enabled || (PFDCMCDOIMJ.movementTransfer != 0 && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)7))
		{
			return;
		}
		if (PFDCMCDOIMJ.newPlatform)
		{
			Transform activePlatform = PFDCMCDOIMJ.activePlatform;
			if (PDMALGAFALE && activePlatform == PFDCMCDOIMJ.activePlatform)
			{
				return;
			}
		}
		LNECOJBDOOE.velocity -= PFDCMCDOIMJ.platformVelocity;
	}

	private void UpdateFunction()
	{
		Vector3 velocity = LNECOJBDOOE.velocity;
		velocity = ApplyInputVelocityChange(velocity);
		if (LNECOJBDOOE.enableGravity)
		{
			if ((AOBAACKKAKH || ALNNAAPEBMK) && EIOJHBHLIMG)
			{
				return;
			}
			velocity = ApplyGravityAndJumping(velocity);
		}
		Vector3 zero = Vector3.zero;
		if (MoveWithPlatform())
		{
			Vector3 vector = PFDCMCDOIMJ.activePlatform.TransformPoint(PFDCMCDOIMJ.activeLocalPoint);
			zero = vector - PFDCMCDOIMJ.activeGlobalPoint;
			if (zero != Vector3.zero)
			{
				OJNKMBPLGJI.Move(zero);
			}
			Quaternion quaternion = PFDCMCDOIMJ.activePlatform.rotation * PFDCMCDOIMJ.activeLocalRotation;
			float y = (quaternion * Quaternion.Inverse(PFDCMCDOIMJ.activeGlobalRotation)).eulerAngles.y;
			if (y != 0f)
			{
				MAGGGOPADPF.Rotate(0f, y, 0f);
			}
		}
		Vector3 position = MAGGGOPADPF.position;
		Vector3 motion = velocity * Time.deltaTime;
		float num = Mathf.Max(OJNKMBPLGJI.stepOffset, new Vector3(motion.x, 0f, motion.z).magnitude);
		if (PDMALGAFALE)
		{
			motion -= num * Vector3.up;
		}
		PFDCMCDOIMJ.hitPlatform = null;
		DBAIPNPOPHB = Vector3.zero;
		LNECOJBDOOE.collisionFlags = OJNKMBPLGJI.Move(motion);
		LNECOJBDOOE.lastHitPoint = LNECOJBDOOE.hitPoint;
		PPCHDOIPBFI = DBAIPNPOPHB;
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.activePlatform != PFDCMCDOIMJ.hitPlatform && PFDCMCDOIMJ.hitPlatform != null)
		{
			PFDCMCDOIMJ.activePlatform = PFDCMCDOIMJ.hitPlatform;
			PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.hitPlatform.localToWorldMatrix;
			PFDCMCDOIMJ.newPlatform = true;
		}
		Vector3 vector2 = new Vector3(velocity.x, 0f, velocity.z);
		LNECOJBDOOE.velocity = (MAGGGOPADPF.position - position) / Time.deltaTime;
		Vector3 lhs = new Vector3(LNECOJBDOOE.velocity.x, 0f, LNECOJBDOOE.velocity.z);
		if (vector2 == Vector3.zero)
		{
			LNECOJBDOOE.velocity = new Vector3(0f, LNECOJBDOOE.velocity.y, 0f);
		}
		else
		{
			float value = Vector3.Dot(lhs, vector2) / vector2.sqrMagnitude;
			LNECOJBDOOE.velocity = vector2 * Mathf.Clamp01(value) + LNECOJBDOOE.velocity.y * Vector3.up;
		}
		if (LNECOJBDOOE.velocity.y < velocity.y - 0.001f)
		{
			if (LNECOJBDOOE.velocity.y < 0f)
			{
				LNECOJBDOOE.velocity = new Vector3(LNECOJBDOOE.velocity.x, velocity.y, LNECOJBDOOE.velocity.z);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		if (PDMALGAFALE && !IsGroundedTest())
		{
			PDMALGAFALE = false;
			if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaTransfer))
			{
				LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
				LNECOJBDOOE.velocity += PFDCMCDOIMJ.platformVelocity;
			}
			SendMessage("OnFall", SendMessageOptions.DontRequireReceiver);
			MAGGGOPADPF.position += num * Vector3.up;
		}
		else if (!PDMALGAFALE && IsGroundedTest())
		{
			PDMALGAFALE = true;
			KMHHLHFAAPH.jumping = false;
			SubtractNewPlatformVelocity();
			SendMessage("OnLand", SendMessageOptions.DontRequireReceiver);
		}
		if (MoveWithPlatform())
		{
			PFDCMCDOIMJ.activeGlobalPoint = MAGGGOPADPF.position + Vector3.up * (OJNKMBPLGJI.center.y - OJNKMBPLGJI.height * 0.5f + OJNKMBPLGJI.radius);
			PFDCMCDOIMJ.activeLocalPoint = PFDCMCDOIMJ.activePlatform.InverseTransformPoint(PFDCMCDOIMJ.activeGlobalPoint);
			PFDCMCDOIMJ.activeGlobalRotation = MAGGGOPADPF.rotation;
			PFDCMCDOIMJ.activeLocalRotation = Quaternion.Inverse(PFDCMCDOIMJ.activePlatform.rotation) * PFDCMCDOIMJ.activeGlobalRotation;
		}
	}

	private void Update()
	{
		if (!OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		if (Input.GetAxis("Vertical") > 0.1f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				OnRunning();
			}
		}
		else
		{
			OffRunning();
		}
		if (LNECOJBDOOE.velocity.x > 0.01f || LNECOJBDOOE.velocity.z > 0.01f || LNECOJBDOOE.velocity.x < -0.01f || LNECOJBDOOE.velocity.z < -0.01f)
		{
			MPBEELGNNCF = true;
		}
		else
		{
			MPBEELGNNCF = false;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				Crouch();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				Prone();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = false;
				ALNNAAPEBMK = false;
				AOBAACKKAKH = false;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 0.01f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 15f)
			{
				MonoBehaviour.print("Hacker");
				Application.Quit();
			}
		}
	}

	private float GetMaxAcceleration(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private void __BB_OBFUSCATOR_4()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (DHMOGDNLGOH && !KKBOHCFDNGD && !MBKNADEDOIC && (FDILNIKANNO || ALNNAAPEBMK))
		{
			ALNNAAPEBMK = true;
			AOBAACKKAKH = AOBAACKKAKH;
			if (!AOBAACKKAKH)
			{
				ALNNAAPEBMK = true;
			}
			else
			{
				JLFKBEBIJCF = false;
			}
			if (JLFKBEBIJCF)
			{
				ALNNAAPEBMK = false;
			}
		}
		if (EIOJHBHLIMG && AOBAACKKAKH && FDILNIKANNO)
		{
			AOBAACKKAKH = false;
			ALNNAAPEBMK = true;
			if (JLFKBEBIJCF)
			{
				ALNNAAPEBMK = true;
			}
			else
			{
				ALNNAAPEBMK = false;
			}
		}
		if (AOBAACKKAKH || KKBOHCFDNGD)
		{
			RaycastHit hitInfo;
			if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, LNECOJBDOOE.crouchHeight * 433f))
			{
				if (KKBOHCFDNGD && AOBAACKKAKH)
				{
					AOBAACKKAKH = true;
					if (!AOBAACKKAKH)
					{
						ALNNAAPEBMK = true;
					}
					if (JLFKBEBIJCF)
					{
						ALNNAAPEBMK = true;
					}
				}
				if (AOBAACKKAKH)
				{
					FDILNIKANNO = false;
				}
			}
			else if (AOBAACKKAKH)
			{
				FDILNIKANNO = true;
			}
		}
		if (AOBAACKKAKH && !ALNNAAPEBMK && OJNKMBPLGJI.height > LNECOJBDOOE.proneHeight + 1649f)
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.proneHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.proneHeight / 44f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.proneHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.ProneSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.ProneSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.ProneSpeed;
		}
	}

	private void __BB_OBFUSCATOR_103()
	{
		if (!OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		if (Input.GetAxis("_Red_G") > 789f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_115();
			}
		}
		else
		{
			__BB_OBFUSCATOR_119();
		}
		if (LNECOJBDOOE.velocity.x > 634f || LNECOJBDOOE.velocity.z > 1924f || LNECOJBDOOE.velocity.x < 44f || LNECOJBDOOE.velocity.z < 1972f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_56();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_4();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = true;
				ALNNAAPEBMK = true;
				AOBAACKKAKH = true;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 1029f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 1681f)
			{
				MonoBehaviour.print("CameraFilterPack/Glitch_Mozaic");
				Application.Quit();
			}
		}
	}

	private void __BB_OBFUSCATOR_117()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = false;
		FDILNIKANNO = true;
		StartCoroutine(__BB_OBFUSCATOR_95());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private bool __BB_OBFUSCATOR_73()
	{
		return !(DBAIPNPOPHB.y <= Mathf.Cos(OJNKMBPLGJI.slopeLimit * 1119f));
	}

	private bool MoveWithPlatform()
	{
		return PFDCMCDOIMJ.enabled && (PDMALGAFALE || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaLocked) && PFDCMCDOIMJ.activePlatform != null;
	}

	private Vector3 __BB_OBFUSCATOR_91(Vector3 IBNKNMJMIGN, Vector3 DBAIPNPOPHB)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, IBNKNMJMIGN);
		return Vector3.Cross(lhs, DBAIPNPOPHB).normalized * IBNKNMJMIGN.magnitude;
	}

	private IEnumerator __BB_OBFUSCATOR_14()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private Vector3 __BB_OBFUSCATOR_33()
	{
		Vector3 vector = MAGGGOPADPF.InverseTransformDirection(PAJCDFMHJLA);
		float num = __BB_OBFUSCATOR_46(vector);
		if (PDMALGAFALE)
		{
			float time = Mathf.Asin(LNECOJBDOOE.velocity.normalized.y) * 4f;
			num *= LNECOJBDOOE.slopeSpeedMultiplier.Evaluate(time);
		}
		return MAGGGOPADPF.TransformDirection(vector * num);
	}

	private void __BB_OBFUSCATOR_43()
	{
		if (!OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		if (Input.GetAxis("_ScreenResolution") > 583f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_0();
			}
		}
		else
		{
			__BB_OBFUSCATOR_119();
		}
		if (LNECOJBDOOE.velocity.x > 1539f || LNECOJBDOOE.velocity.z > 306f || LNECOJBDOOE.velocity.x < 59f || LNECOJBDOOE.velocity.z < 11f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_52();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				Prone();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = true;
				ALNNAAPEBMK = false;
				AOBAACKKAKH = false;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 1814f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 565f)
			{
				MonoBehaviour.print(">");
				Application.Quit();
			}
		}
	}

	private Vector3 GetDirection()
	{
		return PAJCDFMHJLA;
	}

	private void __BB_OBFUSCATOR_67(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private Vector3 __BB_OBFUSCATOR_68()
	{
		return PAJCDFMHJLA;
	}

	private bool __BB_OBFUSCATOR_7()
	{
		return !PFDCMCDOIMJ.enabled || (!PDMALGAFALE && PFDCMCDOIMJ.movementTransfer != (AKBMNLKCOKE)5) || PFDCMCDOIMJ.activePlatform != null;
	}

	private void __BB_OBFUSCATOR_11()
	{
		if (!OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_5();
		}
		if (Input.GetAxis("MP") > 208f && BJJNBHJBMLG && CLFJBIPJCAL && !MBKNADEDOIC && MPBEELGNNCF)
		{
			if (FDILNIKANNO && JLFKBEBIJCF)
			{
				__BB_OBFUSCATOR_0();
			}
		}
		else
		{
			__BB_OBFUSCATOR_119();
		}
		if (LNECOJBDOOE.velocity.x > 1555f || LNECOJBDOOE.velocity.z > 101f || LNECOJBDOOE.velocity.x < 1402f || LNECOJBDOOE.velocity.z < 1968f)
		{
			MPBEELGNNCF = false;
		}
		else
		{
			MPBEELGNNCF = true;
		}
		if (MOEAJIJBBKI)
		{
			if (LNECOJBDOOE.canCrouch && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_82();
			}
			if (LNECOJBDOOE.canProne && !MBKNADEDOIC)
			{
				__BB_OBFUSCATOR_4();
			}
			if (MBKNADEDOIC)
			{
				PDMALGAFALE = false;
				ALNNAAPEBMK = false;
				AOBAACKKAKH = true;
			}
			if (!ALNNAAPEBMK && !AOBAACKKAKH && OJNKMBPLGJI.height < OIGPOIJCCBM - 397f)
			{
				OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
				OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, IFACIAMLIEO, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
				INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, OIGPOIJCCBM, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			}
			if (LNECOJBDOOE.maxForwardSpeed > 1719f)
			{
				MonoBehaviour.print("Collapsing edges");
				Application.Quit();
			}
		}
	}

	private Vector3 __BB_OBFUSCATOR_24()
	{
		return PAJCDFMHJLA;
	}

	private float __BB_OBFUSCATOR_66(bool PDMALGAFALE)
	{
		if (PDMALGAFALE)
		{
			return LNECOJBDOOE.maxGroundAcceleration;
		}
		return LNECOJBDOOE.maxAirAcceleration;
	}

	private void __BB_OBFUSCATOR_97()
	{
		OJNKMBPLGJI = base.gameObject.GetComponent<CharacterController>();
		OIGPOIJCCBM = OJNKMBPLGJI.height;
		IFACIAMLIEO = OJNKMBPLGJI.center.y;
		MAGGGOPADPF = base.transform;
		ADDGNCLMHPK = Camera.main.gameObject;
		CLFJBIPJCAL = false;
		FDILNIKANNO = false;
		StartCoroutine(__BB_OBFUSCATOR_95());
		if (base.gameObject.GetComponent<PlayerDamage>() != null)
		{
			IHCFOJAFGEG = base.gameObject.GetComponent<PlayerDamage>();
		}
	}

	private void SetVelocity(Vector3 PACAMLAINIK)
	{
		PDMALGAFALE = false;
		LNECOJBDOOE.velocity = PACAMLAINIK;
		LNECOJBDOOE.frameVelocity = Vector3.zero;
		SendMessage("OnExternalVelocity");
	}

	private void __BB_OBFUSCATOR_112()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = true;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_87();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 1998f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 1368f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.__BB_OBFUSCATOR_9(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 1963f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_82()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (LPJFDAOBEIN && !KKBOHCFDNGD && !MBKNADEDOIC && FDILNIKANNO)
		{
			AOBAACKKAKH = true;
			ALNNAAPEBMK = !ALNNAAPEBMK;
		}
		RaycastHit hitInfo;
		if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, OIGPOIJCCBM))
		{
			if (EIOJHBHLIMG && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = true;
			}
			if (KKBOHCFDNGD && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = false;
			}
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = false;
			}
			JLFKBEBIJCF = true;
		}
		else
		{
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = true;
			}
			JLFKBEBIJCF = false;
		}
		if (ALNNAAPEBMK && !AOBAACKKAKH && (!(OJNKMBPLGJI.height < LNECOJBDOOE.crouchHeight + 362f) || !(OJNKMBPLGJI.height > LNECOJBDOOE.crouchHeight - 1326f)))
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.crouchHeight / 183f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.CrouchSpeed;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_88()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private IEnumerator setupBools()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (LPJFDAOBEIN && !KKBOHCFDNGD && !MBKNADEDOIC && FDILNIKANNO)
		{
			AOBAACKKAKH = false;
			ALNNAAPEBMK = !ALNNAAPEBMK;
		}
		RaycastHit hitInfo;
		if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, OIGPOIJCCBM))
		{
			if (EIOJHBHLIMG && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = true;
			}
			if (KKBOHCFDNGD && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = true;
			}
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = true;
			}
			JLFKBEBIJCF = true;
		}
		else
		{
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = false;
			}
			JLFKBEBIJCF = false;
		}
		if (ALNNAAPEBMK && !AOBAACKKAKH && (!(OJNKMBPLGJI.height < LNECOJBDOOE.crouchHeight + 125f) || !(OJNKMBPLGJI.height > LNECOJBDOOE.crouchHeight - 633f)))
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.crouchHeight / 700f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.CrouchSpeed;
		}
	}

	private void __BB_OBFUSCATOR_74(ControllerColliderHit FKFIPJBDFPM)
	{
		if (FKFIPJBDFPM.normal.y > 1911f && FKFIPJBDFPM.normal.y > DBAIPNPOPHB.y && FKFIPJBDFPM.moveDirection.y < 157f)
		{
			if ((FKFIPJBDFPM.point - LNECOJBDOOE.lastHitPoint).sqrMagnitude > 1579f || PPCHDOIPBFI == Vector3.zero)
			{
				DBAIPNPOPHB = FKFIPJBDFPM.normal;
			}
			else
			{
				DBAIPNPOPHB = PPCHDOIPBFI;
			}
			PFDCMCDOIMJ.hitPlatform = FKFIPJBDFPM.collider.transform;
			LNECOJBDOOE.hitPoint = FKFIPJBDFPM.point;
			LNECOJBDOOE.frameVelocity = Vector3.zero;
		}
		if (OPCKMFADODD.canPush && FKFIPJBDFPM.transform.GetComponent<Rigidbody>() != null)
		{
			Rigidbody component = FKFIPJBDFPM.transform.GetComponent<Rigidbody>();
			if (!(component == null) && !component.isKinematic && !((double)FKFIPJBDFPM.moveDirection.y < 788.0))
			{
				Vector3 vector = new Vector3(FKFIPJBDFPM.moveDirection.x, 1180f, FKFIPJBDFPM.moveDirection.z);
				component.velocity = vector * OPCKMFADODD.pushPower;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_121()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private bool IsJumping()
	{
		return KMHHLHFAAPH.jumping;
	}

	private Vector3 ApplyGravityAndJumping(Vector3 PACAMLAINIK)
	{
		if (!EIOJHBHLIMG || !MOEAJIJBBKI)
		{
			KMHHLHFAAPH.holdingJumpButton = false;
			KMHHLHFAAPH.lastButtonDownTime = -100f;
		}
		if (EIOJHBHLIMG && KMHHLHFAAPH.lastButtonDownTime < 0f && MOEAJIJBBKI)
		{
			KMHHLHFAAPH.lastButtonDownTime = Time.time;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(0f, PACAMLAINIK.y) - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, LNECOJBDOOE.velocity.y - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
			if (KMHHLHFAAPH.jumping && KMHHLHFAAPH.holdingJumpButton && Time.time < KMHHLHFAAPH.lastStartTime + KMHHLHFAAPH.extraHeight / CalculateJumpVerticalSpeed(KMHHLHFAAPH.baseHeight))
			{
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * LNECOJBDOOE.gravity * Time.deltaTime;
			}
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Max(PACAMLAINIK.y, 0f - LNECOJBDOOE.maxFallSpeed), PACAMLAINIK.z);
		}
		if (PDMALGAFALE)
		{
			if (KMHHLHFAAPH.enabled && MOEAJIJBBKI && Time.time - KMHHLHFAAPH.lastButtonDownTime < 0.2f)
			{
				PDMALGAFALE = false;
				KMHHLHFAAPH.jumping = true;
				KMHHLHFAAPH.lastStartTime = Time.time;
				KMHHLHFAAPH.lastButtonDownTime = -100f;
				KMHHLHFAAPH.holdingJumpButton = true;
				if (TooSteep())
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.steepPerpAmount);
				}
				else
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.perpAmount);
				}
				PACAMLAINIK.y = 0f;
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * CalculateJumpVerticalSpeed(KMHHLHFAAPH.baseHeight);
				if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.InitTransfer || PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.PermaTransfer))
				{
					LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
					PACAMLAINIK += PFDCMCDOIMJ.platformVelocity;
				}
				SendMessage("OnJump", SendMessageOptions.DontRequireReceiver);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		return PACAMLAINIK;
	}

	private Vector3 __BB_OBFUSCATOR_34(Vector3 PACAMLAINIK)
	{
		if (!MOEAJIJBBKI)
		{
			PAJCDFMHJLA = Vector3.zero;
		}
		Vector3 normalized;
		if (PDMALGAFALE && __BB_OBFUSCATOR_73())
		{
			normalized = new Vector3(DBAIPNPOPHB.x, 1355f, DBAIPNPOPHB.z).normalized;
			Vector3 vector = Vector3.Project(PAJCDFMHJLA, normalized);
			normalized = normalized + vector * IGLAMGNODIO.speedControl + (PAJCDFMHJLA - vector) * IGLAMGNODIO.sidewaysControl;
			normalized *= IGLAMGNODIO.slidingSpeed;
		}
		else
		{
			normalized = __BB_OBFUSCATOR_33();
		}
		if (PFDCMCDOIMJ.enabled && PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.None)
		{
			normalized += LNECOJBDOOE.frameVelocity;
			normalized = new Vector3(normalized.x, 323f, normalized.z);
		}
		if (PDMALGAFALE)
		{
			normalized = __BB_OBFUSCATOR_125(normalized, DBAIPNPOPHB);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, 453f, PACAMLAINIK.z);
		}
		float num = __BB_OBFUSCATOR_47(PDMALGAFALE) * Time.deltaTime;
		Vector3 vector2 = normalized - PACAMLAINIK;
		if (vector2.sqrMagnitude > num * num)
		{
			vector2 = vector2.normalized * num;
		}
		if (PDMALGAFALE || MOEAJIJBBKI)
		{
			PACAMLAINIK += vector2;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(PACAMLAINIK.y, 1781f), PACAMLAINIK.z);
		}
		return PACAMLAINIK;
	}

	private void __BB_OBFUSCATOR_108()
	{
		KKBOHCFDNGD = true;
		if (!ALNNAAPEBMK && !AOBAACKKAKH)
		{
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.WalkSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.WalkSpeed / 1317f;
			KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight;
		}
	}

	private void __BB_OBFUSCATOR_53(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private Vector3 __BB_OBFUSCATOR_125(Vector3 IBNKNMJMIGN, Vector3 DBAIPNPOPHB)
	{
		Vector3 lhs = Vector3.Cross(Vector3.up, IBNKNMJMIGN);
		return Vector3.Cross(lhs, DBAIPNPOPHB).normalized * IBNKNMJMIGN.magnitude;
	}

	private void __BB_OBFUSCATOR_18()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = false;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			UpdateFunction();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 439f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 1530f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.__BB_OBFUSCATOR_9(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 1158f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private bool IsGroundedTest()
	{
		return DBAIPNPOPHB.y > 0.01f;
	}

	private bool __BB_OBFUSCATOR_2()
	{
		return !PDMALGAFALE || !IGLAMGNODIO.enabled || __BB_OBFUSCATOR_73();
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (PFDCMCDOIMJ.enabled)
		{
			if (PFDCMCDOIMJ.activePlatform != null)
			{
				if (!PFDCMCDOIMJ.newPlatform)
				{
					PFDCMCDOIMJ.platformVelocity = (PFDCMCDOIMJ.activePlatform.localToWorldMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint) - PFDCMCDOIMJ.lastMatrix.MultiplyPoint3x4(PFDCMCDOIMJ.activeLocalPoint)) / Time.deltaTime;
				}
				PFDCMCDOIMJ.lastMatrix = PFDCMCDOIMJ.activePlatform.localToWorldMatrix;
				PFDCMCDOIMJ.newPlatform = false;
			}
			else
			{
				PFDCMCDOIMJ.platformVelocity = Vector3.zero;
			}
		}
		if (OMJMAHMFCIN)
		{
			__BB_OBFUSCATOR_5();
		}
		HMHEEJDBJGE = (MJLCMCIDOCG - base.transform.position.y) / Time.deltaTime;
		if (!PDMALGAFALE && HMHEEJDBJGE > 1755f)
		{
			AFJLFEFLMOD += Time.deltaTime;
		}
		if (MBKNADEDOIC)
		{
			AFJLFEFLMOD = 1598f;
		}
		MJLCMCIDOCG = base.transform.position.y;
		if (!IHCFOJAFGEG || GFEMDBHJLND == PDMALGAFALE)
		{
			return;
		}
		if (PDMALGAFALE)
		{
			if (AFJLFEFLMOD > EEAHDBNOMFG.fallLimit)
			{
				IHCFOJAFGEG.ApplyFallDamage(HMHEEJDBJGE * EEAHDBNOMFG.fallDamageMultiplier);
			}
			AFJLFEFLMOD = 118f;
		}
		GFEMDBHJLND = PDMALGAFALE;
	}

	private void __BB_OBFUSCATOR_28(bool HBANMAPOKEG)
	{
		MOEAJIJBBKI = HBANMAPOKEG;
	}

	private void __BB_OBFUSCATOR_0()
	{
		KKBOHCFDNGD = false;
		LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.RunSpeed;
		LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.RunSpeed;
		KMHHLHFAAPH.extraHeight = KMHHLHFAAPH.baseHeight + 1754f;
	}

	private void __BB_OBFUSCATOR_72(Vector3 PACAMLAINIK)
	{
		PDMALGAFALE = true;
		LNECOJBDOOE.velocity = PACAMLAINIK;
		LNECOJBDOOE.frameVelocity = Vector3.zero;
		SendMessage(" simplified mesh");
	}

	private Vector3 __BB_OBFUSCATOR_64(Vector3 PACAMLAINIK)
	{
		if (!EIOJHBHLIMG || !MOEAJIJBBKI)
		{
			KMHHLHFAAPH.holdingJumpButton = false;
			KMHHLHFAAPH.lastButtonDownTime = 271f;
		}
		if (EIOJHBHLIMG && KMHHLHFAAPH.lastButtonDownTime < 1071f && MOEAJIJBBKI)
		{
			KMHHLHFAAPH.lastButtonDownTime = Time.time;
		}
		if (PDMALGAFALE)
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Min(637f, PACAMLAINIK.y) - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
		}
		else
		{
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, LNECOJBDOOE.velocity.y - LNECOJBDOOE.gravity * Time.deltaTime, PACAMLAINIK.z);
			if (KMHHLHFAAPH.jumping && KMHHLHFAAPH.holdingJumpButton && Time.time < KMHHLHFAAPH.lastStartTime + KMHHLHFAAPH.extraHeight / __BB_OBFUSCATOR_99(KMHHLHFAAPH.baseHeight))
			{
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * LNECOJBDOOE.gravity * Time.deltaTime;
			}
			PACAMLAINIK = new Vector3(PACAMLAINIK.x, Mathf.Max(PACAMLAINIK.y, 0f - LNECOJBDOOE.maxFallSpeed), PACAMLAINIK.z);
		}
		if (PDMALGAFALE)
		{
			if (KMHHLHFAAPH.enabled && MOEAJIJBBKI && Time.time - KMHHLHFAAPH.lastButtonDownTime < 953f)
			{
				PDMALGAFALE = false;
				KMHHLHFAAPH.jumping = false;
				KMHHLHFAAPH.lastStartTime = Time.time;
				KMHHLHFAAPH.lastButtonDownTime = 590f;
				KMHHLHFAAPH.holdingJumpButton = true;
				if (__BB_OBFUSCATOR_79())
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.steepPerpAmount);
				}
				else
				{
					KMHHLHFAAPH.jumpDir = Vector3.Slerp(Vector3.up, DBAIPNPOPHB, KMHHLHFAAPH.perpAmount);
				}
				PACAMLAINIK.y = 1061f;
				PACAMLAINIK += KMHHLHFAAPH.jumpDir * __BB_OBFUSCATOR_98(KMHHLHFAAPH.baseHeight);
				if (PFDCMCDOIMJ.enabled && (PFDCMCDOIMJ.movementTransfer == AKBMNLKCOKE.None || PFDCMCDOIMJ.movementTransfer == (AKBMNLKCOKE)4))
				{
					LNECOJBDOOE.frameVelocity = PFDCMCDOIMJ.platformVelocity;
					PACAMLAINIK += PFDCMCDOIMJ.platformVelocity;
				}
				SendMessage("_Value3", SendMessageOptions.DontRequireReceiver);
			}
			else
			{
				KMHHLHFAAPH.holdingJumpButton = false;
			}
		}
		return PACAMLAINIK;
	}

	private IEnumerator __BB_OBFUSCATOR_95()
	{
		if (!LNECOJBDOOE.canProne)
		{
			LNECOJBDOOE.canProne = true;
			yield return new WaitForSeconds(0.2f);
			LNECOJBDOOE.canProne = false;
		}
	}

	private void Crouch()
	{
		CharacterController oJNKMBPLGJI = OJNKMBPLGJI;
		Vector3 position = base.transform.position;
		if (LPJFDAOBEIN && !KKBOHCFDNGD && !MBKNADEDOIC && FDILNIKANNO)
		{
			AOBAACKKAKH = false;
			ALNNAAPEBMK = !ALNNAAPEBMK;
		}
		RaycastHit hitInfo;
		if (!Physics.SphereCast(position, oJNKMBPLGJI.radius, base.transform.up, out hitInfo, OIGPOIJCCBM))
		{
			if (EIOJHBHLIMG && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = false;
			}
			if (KKBOHCFDNGD && ALNNAAPEBMK)
			{
				ALNNAAPEBMK = false;
			}
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = true;
			}
			JLFKBEBIJCF = true;
		}
		else
		{
			if (ALNNAAPEBMK)
			{
				FDILNIKANNO = false;
			}
			JLFKBEBIJCF = false;
		}
		if (ALNNAAPEBMK && !AOBAACKKAKH && (!(OJNKMBPLGJI.height < LNECOJBDOOE.crouchHeight + 0.01f) || !(OJNKMBPLGJI.height > LNECOJBDOOE.crouchHeight - 0.01f)))
		{
			OJNKMBPLGJI.height = Mathf.Lerp(OJNKMBPLGJI.height, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth);
			OJNKMBPLGJI.center = new Vector3(OJNKMBPLGJI.center.x, Mathf.Lerp(OJNKMBPLGJI.center.y, LNECOJBDOOE.crouchHeight / 2f, Time.deltaTime / LNECOJBDOOE.crouchSmooth), OJNKMBPLGJI.center.z);
			INNOHGHOCBC.transform.localPosition = new Vector3(INNOHGHOCBC.transform.localPosition.x, Mathf.Lerp(INNOHGHOCBC.transform.localPosition.y, LNECOJBDOOE.crouchHeight, Time.deltaTime / LNECOJBDOOE.crouchSmooth), INNOHGHOCBC.transform.localPosition.z);
			LNECOJBDOOE.maxForwardSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxSidewaysSpeed = LNECOJBDOOE.CrouchSpeed;
			LNECOJBDOOE.maxBackwardsSpeed = LNECOJBDOOE.CrouchSpeed;
		}
	}

	private float __BB_OBFUSCATOR_106(Vector3 IDKIAKFCMPB)
	{
		if (IDKIAKFCMPB == Vector3.zero)
		{
			return 1746f;
		}
		float num = ((!(IDKIAKFCMPB.z > 1836f)) ? LNECOJBDOOE.maxBackwardsSpeed : LNECOJBDOOE.maxForwardSpeed) / LNECOJBDOOE.maxSidewaysSpeed;
		Vector3 normalized = new Vector3(IDKIAKFCMPB.x, 773f, IDKIAKFCMPB.z / num).normalized;
		return new Vector3(normalized.x, 114f, normalized.z * num).magnitude * LNECOJBDOOE.maxSidewaysSpeed;
	}

	private void __BB_OBFUSCATOR_96()
	{
		MBKNADEDOIC = true;
		Vector3 forward = ADDGNCLMHPK.transform.forward;
		forward = base.transform.TransformDirection(forward);
		LNECOJBDOOE.enableGravity = true;
	}
}
