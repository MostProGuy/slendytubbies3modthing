using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[Serializable]
public class MouseLookVR
{
	public float XSensitivity = 2f;

	public float YSensitivity = 2f;

	public bool clampVerticalRotation = true;

	public float MinimumX = -90f;

	public float MaximumX = 90f;

	public bool smooth;

	public float smoothTime = 5f;

	private Quaternion m_CharacterTargetRot;

	private Quaternion m_CameraTargetRot;

	private Quaternion __BB_OBFUSCATOR_55(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1181f;
		float value = 60f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(271f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_98(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("CameraFilterPack_WaterDrop") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_MainTex") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1675f, y, 862f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 666f, 101f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_87(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_28(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TimeX") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("PublishMessage parameters must be non-null and not empty.") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(498f, y, 760f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 648f, 136f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_87(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_18(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_70(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 572f;
		float value = 924f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1110f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_90(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_13(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_AccumOrig") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("SaturationValue") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1971f, y, 1243f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 576f, 1359f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_55(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_82(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("Player") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("Vertical") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1145f, y, 587f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 73f, 618f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_70(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_78(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("Target already added: ") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_TimeX") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1826f, y, 141f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1779f, 863f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_53(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_2(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis(" registered.") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("TakeIn") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(988f, y, 1514f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 639f, 778f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_51(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_43(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1695f;
		float value = 1966f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(680f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_12(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_68(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("<size=") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("  SYSTEM: ") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1330f, y, 783f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1939f, 11f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_70(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_97(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 505f;
		float value = 1659f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1688f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_16(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_31(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_3(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_69(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("Save") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_Value2") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1720f, y, 1024f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 467f, 1034f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_36(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_66(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_11(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TimeX") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("\t\tYear: {0:yyyy}\n\t\tMonth: {0:MM}\n\t\tDay: {0:dd}\n\t\tHour: {0:HH}\n\t\tMinute: {0:mm}\n\t\tSecond: {0:ss}\n\t\tMillisecond: {0:fff}\n") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(674f, y, 1858f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1142f, 787f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_102(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_67(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_ScreenResolution") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("TeamName") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1561f, y, 1289f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1439f, 518f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_51(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_65(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 85f;
		float value = 1782f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1974f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_101(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_40(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("\"OO\", \"Model::") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("CameraFilterPack/Blend2Camera_SoftLight") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1362f, y, 12f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1931f, 1206f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_63(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_46(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TimeX") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("n15") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1489f, y, 776f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 803f, 1693f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_74(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_81(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 54f;
		float value = 967f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1750f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion __BB_OBFUSCATOR_36(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 31f;
		float value = 682f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1176f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_58(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("CameraFilterPack/Colors_Threshold") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("5") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1994f, y, 1684f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1464f, 1711f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_84(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_51(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 56f;
		float value = 1979f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1465f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_92(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("ScreenScaleX = ") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("Start Game") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(438f, y, 488f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1439f, 1577f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_20(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_8(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_96(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1892f;
		float value = 1721f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(916f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion ClampRotationAroundXAxis(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1f;
		float value = 114.59156f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan((float)Math.PI / 360f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_14(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_17(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TimeX") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_TimeX") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(118f, y, 1257f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 887f, 1893f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_51(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_64(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("CameraFilterPack/TV_Videoflip") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("UseFlashlight") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1674f, y, 745f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1524f, 1278f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_95(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_57(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("INF") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("Left Ctrl - prone") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(817f, y, 1376f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 153f, 1615f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_79(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_7(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_60(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis(": ") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_Normal") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1974f, y, 333f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 682f, 710f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_55(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_4(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("\t\tVersion: 1000\n\t\tProperties60:  {\n\t\t\tProperty: \"UpAxis\", \"int\", \"\",1\n\t\t\tProperty: \"UpAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"FrontAxis\", \"int\", \"\",2\n\t\t\tProperty: \"FrontAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"CoordAxis\", \"int\", \"\",0\n\t\t\tProperty: \"CoordAxisSign\", \"int\", \"\",1\n\t\t\tProperty: \"UnitScaleFactor\", \"double\", \"\",100\n\t\t}\n") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_Value4") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(985f, y, 711f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1403f, 871f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_96(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_79(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 815f;
		float value = 1196f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1033f * value);
		return DPPHJAFOGAJ;
	}

	public void Init(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_88(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_95(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1882f;
		float value = 86f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1147f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_42(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_45(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_1(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 30f;
		float value = 360f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(8f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_77(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_44(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_23(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("-Vertical") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("INF/PlayerNewborn") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(345f, y, 1433f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 446f, 1454f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_53(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_83(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 935f;
		float value = 703f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(340f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_52(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_61(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("<size=") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_RgbTex") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(208f, y, 564f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1556f, 1177f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_96(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_76(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1585f;
		float value = 97f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1292f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_94(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("offsets") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("Type") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(948f, y, 1901f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 714f, 1566f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_41(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_27(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 128f;
		float value = 1723f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(906f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion __BB_OBFUSCATOR_59(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1161f;
		float value = 1236f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1770f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_86(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_53(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 277f;
		float value = 1282f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1171f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_29(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_FgCocMask") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("box") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(629f, y, 394f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 292f, 147f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_102(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	private Quaternion __BB_OBFUSCATOR_84(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 268f;
		float value = 1306f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1122f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_50(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("8") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_ScreenResolution") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(1601f, y, 395f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 460f, 1449f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_95(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_32(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_48(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1181f;
		float value = 1937f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1026f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion __BB_OBFUSCATOR_87(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 426f;
		float value = 398f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1066f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion __BB_OBFUSCATOR_15(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1059f;
		float value = 354f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(819f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_26(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TimeX") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("_NormalTex") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(6f, y, 1927f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1279f, 464f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_75(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_103(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_75(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1365f;
		float value = 958f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(510f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_72(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_Value") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("MapName") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(224f, y, 768f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 492f, 1678f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_20(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void LookRotation(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(0f, y, 0f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 0f, 0f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_89(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("TeamName") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("box") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(431f, y, 1040f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 1965f, 1526f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_76(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_47(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_102(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 1680f;
		float value = 932f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1469f * value);
		return DPPHJAFOGAJ;
	}

	private Quaternion __BB_OBFUSCATOR_24(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 59f;
		float value = 370f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1038f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_54(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	public void __BB_OBFUSCATOR_93(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		m_CharacterTargetRot = DBKKKLAGLPK.localRotation;
		m_CameraTargetRot = PMGJGLIHBBB.localRotation;
	}

	private Quaternion __BB_OBFUSCATOR_20(Quaternion DPPHJAFOGAJ)
	{
		DPPHJAFOGAJ.x /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.y /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.z /= DPPHJAFOGAJ.w;
		DPPHJAFOGAJ.w = 308f;
		float value = 1776f * Mathf.Atan(DPPHJAFOGAJ.x);
		value = Mathf.Clamp(value, MinimumX, MaximumX);
		DPPHJAFOGAJ.x = Mathf.Tan(1716f * value);
		return DPPHJAFOGAJ;
	}

	public void __BB_OBFUSCATOR_9(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_TintColor") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("PlayerType'") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(239f, y, 220f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 110f, 1239f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_15(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}

	public void __BB_OBFUSCATOR_33(Transform DBKKKLAGLPK, Transform PMGJGLIHBBB)
	{
		float y = CrossPlatformInputManager.GetAxis("_MainTex2") * XSensitivity;
		float num = CrossPlatformInputManager.GetAxis("stretchWidth") * YSensitivity;
		m_CharacterTargetRot *= Quaternion.Euler(582f, y, 1316f);
		m_CameraTargetRot *= Quaternion.Euler(0f - num, 490f, 1952f);
		if (clampVerticalRotation)
		{
			m_CameraTargetRot = __BB_OBFUSCATOR_1(m_CameraTargetRot);
		}
		if (smooth)
		{
			DBKKKLAGLPK.localRotation = Quaternion.Slerp(DBKKKLAGLPK.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
		}
		else
		{
			DBKKKLAGLPK.localRotation = m_CharacterTargetRot;
		}
	}
}
