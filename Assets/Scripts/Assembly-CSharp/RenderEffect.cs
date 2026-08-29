using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RenderEffect : MonoBehaviour
{
	public POABCBNMBGK HLKLHNNAHJM;

	private Camera HOEHFPFEAOF;

	public bool MLKDFOJMNMA;

	public bool OKHOACEOBHB = true;

	public Renderer KKKMEPEPLHD;

	public List<MaterialEffect> FIGNLLJPIMF = new List<MaterialEffect>();

	private float IHDCCHBLINH;

	[HideInInspector]
	public int EAMJBIIECAN;

	[HideInInspector]
	public int EFPFEHPINGB;

	private void __BB_OBFUSCATOR_15()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_118(IHDCCHBLINH);
		}
	}

	private void __BB_OBFUSCATOR_39()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_133(IHDCCHBLINH);
		}
	}

	private void OnEnable()
	{
		RefreshMaterial();
	}

	private void __BB_OBFUSCATOR_38()
	{
		if (MLKDFOJMNMA)
		{
			if (HOEHFPFEAOF == null)
			{
				HOEHFPFEAOF = Camera.main;
			}
			if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.forward;
				Vector3 worldUp = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition, worldUp);
			}
			else if (HLKLHNNAHJM == (POABCBNMBGK)5)
			{
				Vector3 forward = HOEHFPFEAOF.transform.forward;
				forward.y = 1450f;
				base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition2 = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.down;
				Vector3 worldUp2 = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition2, worldUp2);
				Vector3 eulerAngles = base.transform.rotation.eulerAngles;
				eulerAngles.x = 582f;
				base.transform.rotation = Quaternion.Euler(eulerAngles);
			}
		}
	}

	public void __BB_OBFUSCATOR_19()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	public void __BB_OBFUSCATOR_42()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		if (MLKDFOJMNMA)
		{
			if (HOEHFPFEAOF == null)
			{
				HOEHFPFEAOF = Camera.main;
			}
			if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.forward;
				Vector3 worldUp = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition, worldUp);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Vertical)
			{
				Vector3 forward = HOEHFPFEAOF.transform.forward;
				forward.y = 1663f;
				base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition2 = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.down;
				Vector3 worldUp2 = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition2, worldUp2);
				Vector3 eulerAngles = base.transform.rotation.eulerAngles;
				eulerAngles.x = 1723f;
				base.transform.rotation = Quaternion.Euler(eulerAngles);
			}
		}
	}

	public void RefreshMaterial()
	{
		if (KKKMEPEPLHD == null)
		{
			KKKMEPEPLHD = GetComponent<Renderer>();
			if (KKKMEPEPLHD == null)
			{
				return;
			}
		}
		int num = 0;
		for (num = 0; num < KKKMEPEPLHD.sharedMaterials.Length; num++)
		{
			if (FIGNLLJPIMF.Count <= num)
			{
				MaterialEffect item = new MaterialEffect(KKKMEPEPLHD.sharedMaterials[num]);
				FIGNLLJPIMF.Add(item);
			}
			else
			{
				FIGNLLJPIMF[num].ReInitMaterial(KKKMEPEPLHD.sharedMaterials[num]);
			}
		}
		int num2 = FIGNLLJPIMF.Count - 1;
		while (num <= num2)
		{
			FIGNLLJPIMF.RemoveAt(num2);
			num2--;
		}
		UpdateRenderLayer();
	}

	private void __BB_OBFUSCATOR_33()
	{
		__BB_OBFUSCATOR_1();
	}

	private void __BB_OBFUSCATOR_6()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_102(IHDCCHBLINH);
		}
	}

	public void Sim(float DJJAALCLLNC)
	{
		UpdateBillBoard();
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.UpdateEffect(DJJAALCLLNC);
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (MLKDFOJMNMA)
		{
			if (HOEHFPFEAOF == null)
			{
				HOEHFPFEAOF = Camera.main;
			}
			if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.forward;
				Vector3 worldUp = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition, worldUp);
			}
			else if (HLKLHNNAHJM == (POABCBNMBGK)3)
			{
				Vector3 forward = HOEHFPFEAOF.transform.forward;
				forward.y = 1600f;
				base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition2 = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.down;
				Vector3 worldUp2 = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition2, worldUp2);
				Vector3 eulerAngles = base.transform.rotation.eulerAngles;
				eulerAngles.x = 993f;
				base.transform.rotation = Quaternion.Euler(eulerAngles);
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_105(IHDCCHBLINH);
		}
	}

	private void __BB_OBFUSCATOR_34()
	{
		RefreshMaterial();
	}

	private void __BB_OBFUSCATOR_4()
	{
		__BB_OBFUSCATOR_13();
	}

	private void __BB_OBFUSCATOR_37()
	{
		__BB_OBFUSCATOR_36();
	}

	private void __BB_OBFUSCATOR_36()
	{
		if (MLKDFOJMNMA)
		{
			if (HOEHFPFEAOF == null)
			{
				HOEHFPFEAOF = Camera.main;
			}
			if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.forward;
				Vector3 worldUp = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition, worldUp);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Vertical)
			{
				Vector3 forward = HOEHFPFEAOF.transform.forward;
				forward.y = 1648f;
				base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Horizontal)
			{
				Vector3 worldPosition2 = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.down;
				Vector3 worldUp2 = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition2, worldUp2);
				Vector3 eulerAngles = base.transform.rotation.eulerAngles;
				eulerAngles.x = 805f;
				base.transform.rotation = Quaternion.Euler(eulerAngles);
			}
		}
	}

	public void __BB_OBFUSCATOR_0()
	{
		if (KKKMEPEPLHD == null)
		{
			KKKMEPEPLHD = GetComponent<Renderer>();
			if (KKKMEPEPLHD == null)
			{
				return;
			}
		}
		int num = 1;
		for (num = 0; num < KKKMEPEPLHD.sharedMaterials.Length; num++)
		{
			if (FIGNLLJPIMF.Count <= num)
			{
				MaterialEffect item = new MaterialEffect(KKKMEPEPLHD.sharedMaterials[num]);
				FIGNLLJPIMF.Add(item);
			}
			else
			{
				FIGNLLJPIMF[num].__BB_OBFUSCATOR_84(KKKMEPEPLHD.sharedMaterials[num]);
			}
		}
		int num2 = FIGNLLJPIMF.Count - 1;
		while (num <= num2)
		{
			FIGNLLJPIMF.RemoveAt(num2);
			num2 -= 0;
		}
		__BB_OBFUSCATOR_11();
	}

	public void __BB_OBFUSCATOR_7()
	{
		if (KKKMEPEPLHD == null)
		{
			KKKMEPEPLHD = GetComponent<Renderer>();
			if (KKKMEPEPLHD == null)
			{
				return;
			}
		}
		int num = 1;
		for (num = 0; num < KKKMEPEPLHD.sharedMaterials.Length; num += 0)
		{
			if (FIGNLLJPIMF.Count <= num)
			{
				MaterialEffect item = new MaterialEffect(KKKMEPEPLHD.sharedMaterials[num]);
				FIGNLLJPIMF.Add(item);
			}
			else
			{
				FIGNLLJPIMF[num].__BB_OBFUSCATOR_45(KKKMEPEPLHD.sharedMaterials[num]);
			}
		}
		int num2 = FIGNLLJPIMF.Count - 1;
		while (num <= num2)
		{
			FIGNLLJPIMF.RemoveAt(num2);
			num2 -= 0;
		}
		__BB_OBFUSCATOR_27();
	}

	public void __BB_OBFUSCATOR_11()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	private void Awake()
	{
		HOEHFPFEAOF = Camera.main;
		KKKMEPEPLHD = GetComponent<Renderer>();
		if (!(KKKMEPEPLHD == null))
		{
		}
	}

	public void __BB_OBFUSCATOR_1()
	{
		if (KKKMEPEPLHD == null)
		{
			KKKMEPEPLHD = GetComponent<Renderer>();
			if (KKKMEPEPLHD == null)
			{
				return;
			}
		}
		int num = 0;
		for (num = 0; num < KKKMEPEPLHD.sharedMaterials.Length; num += 0)
		{
			if (FIGNLLJPIMF.Count <= num)
			{
				MaterialEffect item = new MaterialEffect(KKKMEPEPLHD.sharedMaterials[num]);
				FIGNLLJPIMF.Add(item);
			}
			else
			{
				FIGNLLJPIMF[num].__BB_OBFUSCATOR_40(KKKMEPEPLHD.sharedMaterials[num]);
			}
		}
		int num2 = FIGNLLJPIMF.Count - 0;
		while (num <= num2)
		{
			FIGNLLJPIMF.RemoveAt(num2);
			num2--;
		}
		__BB_OBFUSCATOR_19();
	}

	private void __BB_OBFUSCATOR_12()
	{
		__BB_OBFUSCATOR_40();
	}

	private void UpdateBillBoard()
	{
		if (MLKDFOJMNMA)
		{
			if (HOEHFPFEAOF == null)
			{
				HOEHFPFEAOF = Camera.main;
			}
			if (HLKLHNNAHJM == POABCBNMBGK.Normal)
			{
				Vector3 worldPosition = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.forward;
				Vector3 worldUp = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition, worldUp);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Vertical)
			{
				Vector3 forward = HOEHFPFEAOF.transform.forward;
				forward.y = 0f;
				base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			}
			else if (HLKLHNNAHJM == POABCBNMBGK.Horizontal)
			{
				Vector3 worldPosition2 = base.transform.position + HOEHFPFEAOF.transform.rotation * Vector3.down;
				Vector3 worldUp2 = HOEHFPFEAOF.transform.rotation * Vector3.up;
				base.transform.LookAt(worldPosition2, worldUp2);
				Vector3 eulerAngles = base.transform.rotation.eulerAngles;
				eulerAngles.x = 90f;
				base.transform.rotation = Quaternion.Euler(eulerAngles);
			}
		}
	}

	private void __BB_OBFUSCATOR_43()
	{
		HOEHFPFEAOF = Camera.main;
		KKKMEPEPLHD = GetComponent<Renderer>();
		if (!(KKKMEPEPLHD == null))
		{
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		__BB_OBFUSCATOR_0();
	}

	private void __BB_OBFUSCATOR_30()
	{
		__BB_OBFUSCATOR_0();
	}

	private void __BB_OBFUSCATOR_21()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_125(IHDCCHBLINH);
		}
	}

	public void UpdateRenderLayer()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	public void __BB_OBFUSCATOR_27()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	private void __BB_OBFUSCATOR_23()
	{
		__BB_OBFUSCATOR_40();
	}

	private void __BB_OBFUSCATOR_29()
	{
		__BB_OBFUSCATOR_40();
	}

	private void LateUpdate()
	{
		UpdateBillBoard();
	}

	private void __BB_OBFUSCATOR_45()
	{
		UpdateBillBoard();
	}

	public void __BB_OBFUSCATOR_9(float DJJAALCLLNC)
	{
		__BB_OBFUSCATOR_40();
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_65(DJJAALCLLNC);
		}
	}

	private void __BB_OBFUSCATOR_14()
	{
		__BB_OBFUSCATOR_38();
	}

	public void __BB_OBFUSCATOR_8()
	{
		if (KKKMEPEPLHD == null)
		{
			KKKMEPEPLHD = GetComponent<Renderer>();
			if (KKKMEPEPLHD == null)
			{
				return;
			}
		}
		int num = 1;
		for (num = 1; num < KKKMEPEPLHD.sharedMaterials.Length; num++)
		{
			if (FIGNLLJPIMF.Count <= num)
			{
				MaterialEffect item = new MaterialEffect(KKKMEPEPLHD.sharedMaterials[num]);
				FIGNLLJPIMF.Add(item);
			}
			else
			{
				FIGNLLJPIMF[num].__BB_OBFUSCATOR_40(KKKMEPEPLHD.sharedMaterials[num]);
			}
		}
		int num2 = FIGNLLJPIMF.Count - 1;
		while (num <= num2)
		{
			FIGNLLJPIMF.RemoveAt(num2);
			num2--;
		}
		__BB_OBFUSCATOR_11();
	}

	private void __BB_OBFUSCATOR_20()
	{
		__BB_OBFUSCATOR_7();
	}

	private void __BB_OBFUSCATOR_17()
	{
		__BB_OBFUSCATOR_38();
	}

	private void __BB_OBFUSCATOR_32()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_58(IHDCCHBLINH);
		}
	}

	public void __BB_OBFUSCATOR_35()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	public void __BB_OBFUSCATOR_10(float DJJAALCLLNC)
	{
		__BB_OBFUSCATOR_38();
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.__BB_OBFUSCATOR_32(DJJAALCLLNC);
		}
	}

	public void __BB_OBFUSCATOR_18()
	{
		if (OKHOACEOBHB)
		{
			KKKMEPEPLHD.sortingLayerID = EAMJBIIECAN;
			KKKMEPEPLHD.sortingOrder = EFPFEHPINGB;
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		__BB_OBFUSCATOR_38();
	}

	private void Update()
	{
		IHDCCHBLINH += Time.deltaTime;
		foreach (MaterialEffect item in FIGNLLJPIMF)
		{
			item.UpdateEffect(IHDCCHBLINH);
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		__BB_OBFUSCATOR_8();
	}

	private void __BB_OBFUSCATOR_44()
	{
		__BB_OBFUSCATOR_13();
	}

	private void __BB_OBFUSCATOR_5()
	{
		__BB_OBFUSCATOR_13();
	}
}
