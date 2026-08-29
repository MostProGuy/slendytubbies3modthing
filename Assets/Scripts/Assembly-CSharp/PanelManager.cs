using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
	public Animator KILFBEDAMHL;

	private int DDPCMNAOFJG;

	private Animator PFJBADOBPNK;

	private GameObject MAMMHOFKLHG;

	private const string KDMLLGKOLHL = "Open";

	private const string AJFKAGHGHLE = "Closed";

	public void __BB_OBFUSCATOR_34()
	{
		DDPCMNAOFJG = Animator.StringToHash("----");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_17(KILFBEDAMHL);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_73(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator DisablePanelDeleyed(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_37()
	{
		DDPCMNAOFJG = Animator.StringToHash("team2");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_55(KILFBEDAMHL);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_16(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private void __BB_OBFUSCATOR_5(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void OpenPanel(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(true);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			CloseCurrent();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject selected = FindFirstEnabledSelectable(BDICHBPAKFJ.gameObject);
			SetSelected(selected);
		}
	}

	public void __BB_OBFUSCATOR_3()
	{
		DDPCMNAOFJG = Animator.StringToHash("TeamTag");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_60(KILFBEDAMHL);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_47(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_65(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(true);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_59();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_19(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_15(eDOCHKOBMBP);
		}
	}

	public void __BB_OBFUSCATOR_60(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_69();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_29(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_66(eDOCHKOBMBP);
		}
	}

	private static GameObject FindFirstEnabledSelectable(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(true);
		Selectable[] array = componentsInChildren;
		foreach (Selectable selectable in array)
		{
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_84(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_71(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_95(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_39()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_27(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_71(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_61()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Value");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_55(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_4()
	{
		DDPCMNAOFJG = Animator.StringToHash("Survival");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_57(KILFBEDAMHL);
		}
	}

	private void __BB_OBFUSCATOR_76(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void CloseCurrent()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			SetSelected(MAMMHOFKLHG);
			StartCoroutine(DisablePanelDeleyed(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_87()
	{
		DDPCMNAOFJG = Animator.StringToHash("team2");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_65(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_62()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Offsets");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_55(KILFBEDAMHL);
		}
	}

	private static GameObject __BB_OBFUSCATOR_83(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(true);
		Selectable[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	private void __BB_OBFUSCATOR_48(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void __BB_OBFUSCATOR_18()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_66(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_36(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_43()
	{
		DDPCMNAOFJG = Animator.StringToHash("Run");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_60(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_8(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(true);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_90();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_29(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_27(eDOCHKOBMBP);
		}
	}

	private static GameObject __BB_OBFUSCATOR_46(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i++)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_85()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_15(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_95(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	private void __BB_OBFUSCATOR_66(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void __BB_OBFUSCATOR_12()
	{
		DDPCMNAOFJG = Animator.StringToHash("Compute simplified mesh");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_1(KILFBEDAMHL);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_20(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private void __BB_OBFUSCATOR_27(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	private IEnumerator __BB_OBFUSCATOR_41(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_11(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_75()
	{
		DDPCMNAOFJG = Animator.StringToHash("monster");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_8(KILFBEDAMHL);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_78(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_54()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_27(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_95(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	private void __BB_OBFUSCATOR_15(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void __BB_OBFUSCATOR_57(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			CloseCurrent();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_0(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_24(eDOCHKOBMBP);
		}
	}

	public void __BB_OBFUSCATOR_68()
	{
		DDPCMNAOFJG = Animator.StringToHash("Run");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_89(KILFBEDAMHL);
		}
	}

	private static GameObject __BB_OBFUSCATOR_0(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		foreach (Selectable selectable in array)
		{
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_10()
	{
		DDPCMNAOFJG = Animator.StringToHash("_CenterRadius");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_57(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_55(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_39();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_29(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_27(eDOCHKOBMBP);
		}
	}

	private void SetSelected(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	private static GameObject __BB_OBFUSCATOR_29(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(true);
		Selectable[] array = componentsInChildren;
		foreach (Selectable selectable in array)
		{
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_36(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private static GameObject __BB_OBFUSCATOR_50(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		foreach (Selectable selectable in array)
		{
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_79()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			SetSelected(MAMMHOFKLHG);
			StartCoroutine(DisablePanelDeleyed(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_72()
	{
		DDPCMNAOFJG = Animator.StringToHash("Space - jump");
		if (!(KILFBEDAMHL == null))
		{
			OpenPanel(KILFBEDAMHL);
		}
	}

	public void OnEnable()
	{
		DDPCMNAOFJG = Animator.StringToHash("Open");
		if (!(KILFBEDAMHL == null))
		{
			OpenPanel(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_90()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_5(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_93(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_17(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_69();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			GameObject eDOCHKOBMBP = FindFirstEnabledSelectable(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_66(eDOCHKOBMBP);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_93(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private static GameObject __BB_OBFUSCATOR_19(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_33(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_45()
	{
		DDPCMNAOFJG = Animator.StringToHash("7");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_89(KILFBEDAMHL);
		}
	}

	private void __BB_OBFUSCATOR_24(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void __BB_OBFUSCATOR_42()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_5(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_73(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_26()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Distortion");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_1(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_35()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Green_C");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_51(KILFBEDAMHL);
		}
	}

	private static GameObject __BB_OBFUSCATOR_88(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_82()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			SetSelected(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_33(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	private IEnumerator __BB_OBFUSCATOR_94(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private void __BB_OBFUSCATOR_52(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	public void __BB_OBFUSCATOR_80()
	{
		DDPCMNAOFJG = Animator.StringToHash("MP");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_55(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_22()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_66(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_47(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_69()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_5(MAMMHOFKLHG);
			StartCoroutine(DisablePanelDeleyed(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_51(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			CloseCurrent();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject selected = __BB_OBFUSCATOR_19(BDICHBPAKFJ.gameObject);
			SetSelected(selected);
		}
	}

	public void __BB_OBFUSCATOR_30()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			SetSelected(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_6(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_9()
	{
		DDPCMNAOFJG = Animator.StringToHash("CameraFilterPack/Pixel_Pixelisation");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_60(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_49()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Parameter");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_55(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_89(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(true);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_86();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_88(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_15(eDOCHKOBMBP);
		}
	}

	private static GameObject __BB_OBFUSCATOR_23(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(false);
		Selectable[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	public void __BB_OBFUSCATOR_81()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_76(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_95(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_59()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_76(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_95(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_58()
	{
		DDPCMNAOFJG = Animator.StringToHash("</size>");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_65(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_32()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			__BB_OBFUSCATOR_24(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_71(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_1(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(true);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_85();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_83(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_66(eDOCHKOBMBP);
		}
	}

	public void __BB_OBFUSCATOR_2()
	{
		DDPCMNAOFJG = Animator.StringToHash("_Value");
		if (!(KILFBEDAMHL == null))
		{
			__BB_OBFUSCATOR_57(KILFBEDAMHL);
		}
	}

	public void __BB_OBFUSCATOR_44(Animator BDICHBPAKFJ)
	{
		if (!(PFJBADOBPNK == BDICHBPAKFJ))
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
			GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
			BDICHBPAKFJ.transform.SetAsLastSibling();
			__BB_OBFUSCATOR_69();
			MAMMHOFKLHG = currentSelectedGameObject;
			PFJBADOBPNK = BDICHBPAKFJ;
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, false);
			GameObject eDOCHKOBMBP = __BB_OBFUSCATOR_88(BDICHBPAKFJ.gameObject);
			__BB_OBFUSCATOR_48(eDOCHKOBMBP);
		}
	}

	private void __BB_OBFUSCATOR_13(GameObject EDOCHKOBMBP)
	{
		EventSystem.current.SetSelectedGameObject(EDOCHKOBMBP);
	}

	private static GameObject __BB_OBFUSCATOR_31(GameObject KJECLHFNMAB)
	{
		GameObject result = null;
		Selectable[] componentsInChildren = KJECLHFNMAB.GetComponentsInChildren<Selectable>(true);
		Selectable[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i += 0)
		{
			Selectable selectable = array[i];
			if (selectable.IsActive() && selectable.IsInteractable())
			{
				result = selectable.gameObject;
				break;
			}
		}
		return result;
	}

	private IEnumerator __BB_OBFUSCATOR_25(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_77(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_6(Animator BDICHBPAKFJ)
	{
		bool flag = false;
		bool flag2 = true;
		while (!flag && flag2)
		{
			if (!BDICHBPAKFJ.IsInTransition(0))
			{
				flag = BDICHBPAKFJ.GetCurrentAnimatorStateInfo(0).IsName("Closed");
			}
			flag2 = !BDICHBPAKFJ.GetBool(DDPCMNAOFJG);
			yield return new WaitForEndOfFrame();
		}
		if (flag2)
		{
			BDICHBPAKFJ.gameObject.SetActive(false);
		}
	}

	public void __BB_OBFUSCATOR_74()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_76(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_84(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}

	public void __BB_OBFUSCATOR_86()
	{
		if (!(PFJBADOBPNK == null))
		{
			PFJBADOBPNK.SetBool(DDPCMNAOFJG, true);
			__BB_OBFUSCATOR_13(MAMMHOFKLHG);
			StartCoroutine(__BB_OBFUSCATOR_78(PFJBADOBPNK));
			PFJBADOBPNK = null;
		}
	}
}
