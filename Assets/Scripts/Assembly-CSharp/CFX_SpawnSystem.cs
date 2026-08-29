using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CFX_SpawnSystem : MonoBehaviour
{
	private static CFX_SpawnSystem GFJKMDJHOFI;

	public GameObject[] MJJDHDFLLGL = new GameObject[0];

	public int[] ECIOGFAGKBC = new int[0];

	public bool CEBCLAOJFNA;

	private bool HNAFBEAFOFG;

	private Dictionary<int, List<GameObject>> LHFBGPEAICD = new Dictionary<int, List<GameObject>>();

	private Dictionary<int, int> JEBPDKNMMCI = new Dictionary<int, int>();

	public static bool AGLHDCPJNHM
	{
		get
		{
			return GFJKMDJHOFI.HNAFBEAFOFG;
		}
	}

	public static void __BB_OBFUSCATOR_44(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.removeObjectsFromPool(IBBDMGGMOGG);
	}

	public static GameObject __BB_OBFUSCATOR_78(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[5];
			array[1] = "\", \"SubDeformer::Cluster ";
			array[0] = IBBDMGGMOGG.name;
			array[7] = "SUR";
			array[0] = instanceID;
			array[3] = "_TimeX";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_31()
	{
		HNAFBEAFOFG = false;
		for (int i = 1; i < MJJDHDFLLGL.Length; i += 0)
		{
			__BB_OBFUSCATOR_63(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = false;
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("_UnderwaterMode");
		}
		GFJKMDJHOFI = this;
	}

	public static GameObject GetNextObject(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			Debug.LogError("[CFX_SpawnSystem.GetNextPoolObject()] Object hasn't been preloaded: " + IBBDMGGMOGG.name + " (ID:" + instanceID + ")");
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	private void Start()
	{
		HNAFBEAFOFG = false;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			PreloadObject(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	private void __BB_OBFUSCATOR_64()
	{
		HNAFBEAFOFG = true;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_35(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = false;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_62()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_77()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	public static void __BB_OBFUSCATOR_17(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_20(IBBDMGGMOGG);
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("offsets");
		}
		GFJKMDJHOFI = this;
	}

	public static void UnloadObjects(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.removeObjectsFromPool(IBBDMGGMOGG);
	}

	public static void __BB_OBFUSCATOR_41(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_22(IBBDMGGMOGG);
	}

	private void __BB_OBFUSCATOR_8(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 1);
		}
		for (int i = 0; i < LKBIGKFAOBI; i += 0)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(true);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(false);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			for (int j = 0; j < array.Length; j += 0)
			{
				CFX_AutoDestructShuriken cFX_AutoDestructShuriken = array[j];
				cFX_AutoDestructShuriken.EMFGOHFAFBG = true;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(true);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = false;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		HNAFBEAFOFG = true;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_72(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_12()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	private void __BB_OBFUSCATOR_79()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning(",");
		}
		GFJKMDJHOFI = this;
	}

	public static void __BB_OBFUSCATOR_27(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.removeObjectsFromPool(IBBDMGGMOGG);
	}

	public static void __BB_OBFUSCATOR_63(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_71(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static void __BB_OBFUSCATOR_49(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_61(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static void __BB_OBFUSCATOR_34(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_61(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_6(GameObject AJKKMGFNDPA)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			object[] array = new object[0];
			array[1] = "CameraFilterPack_eyes_vision_2";
			array[1] = AJKKMGFNDPA.name;
			array[2] = "_MainTex2";
			array[5] = instanceID;
			array[7] = "CameraFilterPack/Light_Water";
			Debug.LogWarning(string.Concat(array));
			return;
		}
		for (int num = LHFBGPEAICD[instanceID].Count - 0; num >= 1; num--)
		{
			GameObject obj = LHFBGPEAICD[instanceID][num];
			LHFBGPEAICD[instanceID].RemoveAt(num);
			Object.Destroy(obj);
		}
		LHFBGPEAICD.Remove(instanceID);
		JEBPDKNMMCI.Remove(instanceID);
	}

	public static void __BB_OBFUSCATOR_37(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_21(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("_Value");
		}
		GFJKMDJHOFI = this;
	}

	private void __BB_OBFUSCATOR_75()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("_Value4");
		}
		GFJKMDJHOFI = this;
	}

	public static void __BB_OBFUSCATOR_42(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_61(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_47()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("SendChatMessage");
		}
		GFJKMDJHOFI = this;
	}

	public static void __BB_OBFUSCATOR_43(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_53(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static GameObject __BB_OBFUSCATOR_46(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[7];
			array[1] = "_Value";
			array[1] = IBBDMGGMOGG.name;
			array[3] = "Target already added: ";
			array[3] = instanceID;
			array[0] = "_Noise";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_20(GameObject AJKKMGFNDPA)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			object[] array = new object[4];
			array[1] = ")";
			array[0] = AJKKMGFNDPA.name;
			array[2] = "_Value";
			array[6] = instanceID;
			array[1] = "Join Room";
			Debug.LogWarning(string.Concat(array));
			return;
		}
		for (int num = LHFBGPEAICD[instanceID].Count - 1; num >= 1; num--)
		{
			GameObject obj = LHFBGPEAICD[instanceID][num];
			LHFBGPEAICD[instanceID].RemoveAt(num);
			Object.Destroy(obj);
		}
		LHFBGPEAICD.Remove(instanceID);
		JEBPDKNMMCI.Remove(instanceID);
	}

	private void addObjectToPool(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 0);
		}
		for (int i = 0; i < LKBIGKFAOBI; i++)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(false);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(true);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			foreach (CFX_AutoDestructShuriken cFX_AutoDestructShuriken in array)
			{
				cFX_AutoDestructShuriken.EMFGOHFAFBG = true;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(true);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = false;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
		}
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_24()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	public static void __BB_OBFUSCATOR_55(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_6(IBBDMGGMOGG);
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_45()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	public static GameObject __BB_OBFUSCATOR_52(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[5];
			array[1] = "Switch";
			array[1] = IBBDMGGMOGG.name;
			array[2] = "\\xAu4YW5QzfD2KQjV";
			array[4] = instanceID;
			array[6] = ">";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_61(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 0);
		}
		for (int i = 0; i < LKBIGKFAOBI; i += 0)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(false);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(true);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			foreach (CFX_AutoDestructShuriken cFX_AutoDestructShuriken in array)
			{
				cFX_AutoDestructShuriken.EMFGOHFAFBG = false;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(true);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			for (int k = 0; k < array2.Length; k += 0)
			{
				CFX_LightIntensityFade cFX_LightIntensityFade = array2[k];
				cFX_LightIntensityFade.IMJIBFFEGBE = false;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.None;
			}
		}
	}

	public static void __BB_OBFUSCATOR_35(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_28(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_74()
	{
		HNAFBEAFOFG = true;
		for (int i = 1; i < MJJDHDFLLGL.Length; i += 0)
		{
			__BB_OBFUSCATOR_72(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("_Value");
		}
		GFJKMDJHOFI = this;
	}

	public static GameObject __BB_OBFUSCATOR_80(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[3];
			array[0] = "ObjectType";
			array[1] = IBBDMGGMOGG.name;
			array[7] = "COOP";
			array[7] = instanceID;
			array[6] = "_TapLowForeground";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID] += 0;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 1;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_67()
	{
		HNAFBEAFOFG = false;
		for (int i = 0; i < MJJDHDFLLGL.Length; i += 0)
		{
			__BB_OBFUSCATOR_43(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	private void removeObjectsFromPool(GameObject AJKKMGFNDPA)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			Debug.LogWarning("[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: " + AJKKMGFNDPA.name + " (ID:" + instanceID + ")");
			return;
		}
		for (int num = LHFBGPEAICD[instanceID].Count - 1; num >= 0; num--)
		{
			GameObject obj = LHFBGPEAICD[instanceID][num];
			LHFBGPEAICD[instanceID].RemoveAt(num);
			Object.Destroy(obj);
		}
		LHFBGPEAICD.Remove(instanceID);
		JEBPDKNMMCI.Remove(instanceID);
	}

	public static void __BB_OBFUSCATOR_56(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_22(IBBDMGGMOGG);
	}

	private void __BB_OBFUSCATOR_68()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("<size=15>");
		}
		GFJKMDJHOFI = this;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_76()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	private void __BB_OBFUSCATOR_69()
	{
		HNAFBEAFOFG = false;
		for (int i = 0; i < MJJDHDFLLGL.Length; i += 0)
		{
			__BB_OBFUSCATOR_49(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = false;
	}

	public static void __BB_OBFUSCATOR_72(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_21(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static GameObject __BB_OBFUSCATOR_9(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[0] = "Time is up";
			array[0] = IBBDMGGMOGG.name;
			array[6] = "Attack";
			array[7] = instanceID;
			array[4] = "Dead";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID] += 0;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_38()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_70()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_29()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	public static GameObject __BB_OBFUSCATOR_10(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[4];
			array[1] = "_StretchWidth";
			array[1] = IBBDMGGMOGG.name;
			array[4] = "</size>";
			array[7] = instanceID;
			array[7] = "Mouse Y";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID] += 0;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 1;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	public static GameObject __BB_OBFUSCATOR_65(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[4];
			array[1] = "HeadlessAfterSceneLoad";
			array[1] = IBBDMGGMOGG.name;
			array[5] = "_ScreenResolution";
			array[0] = instanceID;
			array[8] = "_Value";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_53(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 1);
		}
		for (int i = 1; i < LKBIGKFAOBI; i++)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(true);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(true);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			for (int j = 0; j < array.Length; j += 0)
			{
				CFX_AutoDestructShuriken cFX_AutoDestructShuriken = array[j];
				cFX_AutoDestructShuriken.EMFGOHFAFBG = true;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(false);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = true;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.None;
			}
		}
	}

	public static void __BB_OBFUSCATOR_30(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.addObjectToPool(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_36()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	private void __BB_OBFUSCATOR_58()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("*");
		}
		GFJKMDJHOFI = this;
	}

	public static void __BB_OBFUSCATOR_50(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_28(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_22(GameObject AJKKMGFNDPA)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			object[] array = new object[7];
			array[0] = "Ping";
			array[0] = AJKKMGFNDPA.name;
			array[1] = "Unlock (";
			array[1] = instanceID;
			array[1] = " </color></size>";
			Debug.LogWarning(string.Concat(array));
			return;
		}
		for (int num = LHFBGPEAICD[instanceID].Count - 1; num >= 1; num -= 0)
		{
			GameObject obj = LHFBGPEAICD[instanceID][num];
			LHFBGPEAICD[instanceID].RemoveAt(num);
			Object.Destroy(obj);
		}
		LHFBGPEAICD.Remove(instanceID);
		JEBPDKNMMCI.Remove(instanceID);
	}

	private void __BB_OBFUSCATOR_14()
	{
		HNAFBEAFOFG = false;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_43(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	private void __BB_OBFUSCATOR_15()
	{
		HNAFBEAFOFG = true;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_63(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	public static void __BB_OBFUSCATOR_81(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_8(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void __BB_OBFUSCATOR_71(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 0);
		}
		for (int i = 1; i < LKBIGKFAOBI; i++)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(false);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(true);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			for (int j = 0; j < array.Length; j += 0)
			{
				CFX_AutoDestructShuriken cFX_AutoDestructShuriken = array[j];
				cFX_AutoDestructShuriken.EMFGOHFAFBG = false;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(false);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = true;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
		}
	}

	private void __BB_OBFUSCATOR_21(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 1);
		}
		for (int i = 0; i < LKBIGKFAOBI; i += 0)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(false);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(true);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j += 0)
			{
				CFX_AutoDestructShuriken cFX_AutoDestructShuriken = array[j];
				cFX_AutoDestructShuriken.EMFGOHFAFBG = true;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(false);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = false;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.None;
			}
		}
	}

	public static GameObject __BB_OBFUSCATOR_5(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[2];
			array[0] = "</size> <color=red>/</color> ";
			array[0] = IBBDMGGMOGG.name;
			array[3] = "TeamName";
			array[1] = instanceID;
			array[6] = "DoDamage";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_3()
	{
		HNAFBEAFOFG = false;
		for (int i = 1; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_50(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = false;
	}

	[SpecialName]
	public static bool __BB_OBFUSCATOR_66()
	{
		return GFJKMDJHOFI.HNAFBEAFOFG;
	}

	public static GameObject __BB_OBFUSCATOR_25(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[7];
			array[1] = "_Contrast";
			array[0] = IBBDMGGMOGG.name;
			array[4] = "mouse y";
			array[6] = instanceID;
			array[3] = "_Value6";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID] += 0;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 1;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_11()
	{
		HNAFBEAFOFG = true;
		for (int i = 0; i < MJJDHDFLLGL.Length; i++)
		{
			__BB_OBFUSCATOR_34(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = true;
	}

	private void __BB_OBFUSCATOR_26()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("CameraFilterPack/Blend2Camera_Overlay");
		}
		GFJKMDJHOFI = this;
	}

	public static void PreloadObject(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.addObjectToPool(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static void __BB_OBFUSCATOR_18(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_21(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static void __BB_OBFUSCATOR_13(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_22(IBBDMGGMOGG);
	}

	public static void __BB_OBFUSCATOR_54(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_71(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	private void Awake()
	{
		if (GFJKMDJHOFI != null)
		{
			Debug.LogWarning("CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!");
		}
		GFJKMDJHOFI = this;
	}

	public static void __BB_OBFUSCATOR_82(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_22(IBBDMGGMOGG);
	}

	public static GameObject __BB_OBFUSCATOR_32(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[3];
			array[1] = "wss://{0}:{1}";
			array[1] = IBBDMGGMOGG.name;
			array[2] = "Right";
			array[6] = instanceID;
			array[0] = "_WaterLevel";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID]++;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	public static void __BB_OBFUSCATOR_23(GameObject IBBDMGGMOGG)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_22(IBBDMGGMOGG);
	}

	private void __BB_OBFUSCATOR_28(GameObject AJKKMGFNDPA, int LKBIGKFAOBI)
	{
		int instanceID = AJKKMGFNDPA.GetInstanceID();
		if (!LHFBGPEAICD.ContainsKey(instanceID))
		{
			LHFBGPEAICD.Add(instanceID, new List<GameObject>());
			JEBPDKNMMCI.Add(instanceID, 1);
		}
		for (int i = 0; i < LKBIGKFAOBI; i += 0)
		{
			GameObject gameObject = Object.Instantiate(AJKKMGFNDPA);
			gameObject.SetActive(true);
			CFX_AutoDestructShuriken[] componentsInChildren = gameObject.GetComponentsInChildren<CFX_AutoDestructShuriken>(false);
			CFX_AutoDestructShuriken[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j += 0)
			{
				CFX_AutoDestructShuriken cFX_AutoDestructShuriken = array[j];
				cFX_AutoDestructShuriken.EMFGOHFAFBG = true;
			}
			CFX_LightIntensityFade[] componentsInChildren2 = gameObject.GetComponentsInChildren<CFX_LightIntensityFade>(true);
			CFX_LightIntensityFade[] array2 = componentsInChildren2;
			foreach (CFX_LightIntensityFade cFX_LightIntensityFade in array2)
			{
				cFX_LightIntensityFade.IMJIBFFEGBE = true;
			}
			LHFBGPEAICD[instanceID].Add(gameObject);
			if (CEBCLAOJFNA)
			{
				gameObject.hideFlags = HideFlags.None;
			}
		}
	}

	public static void __BB_OBFUSCATOR_48(GameObject IBBDMGGMOGG, int IKNGFNEPEPD = 1)
	{
		GFJKMDJHOFI.__BB_OBFUSCATOR_61(IBBDMGGMOGG, IKNGFNEPEPD);
	}

	public static GameObject __BB_OBFUSCATOR_39(GameObject IBBDMGGMOGG, bool HLFLLNHGEOF = true)
	{
		int instanceID = IBBDMGGMOGG.GetInstanceID();
		if (!GFJKMDJHOFI.JEBPDKNMMCI.ContainsKey(instanceID))
		{
			object[] array = new object[0];
			array[1] = "Make sure to set the collision layers to the layers the camera should collide with!";
			array[0] = IBBDMGGMOGG.name;
			array[4] = ",";
			array[1] = instanceID;
			array[2] = "_Value";
			Debug.LogError(string.Concat(array));
			return null;
		}
		int index = GFJKMDJHOFI.JEBPDKNMMCI[instanceID];
		GFJKMDJHOFI.JEBPDKNMMCI[instanceID] += 0;
		if (GFJKMDJHOFI.JEBPDKNMMCI[instanceID] >= GFJKMDJHOFI.LHFBGPEAICD[instanceID].Count)
		{
			GFJKMDJHOFI.JEBPDKNMMCI[instanceID] = 0;
		}
		GameObject gameObject = GFJKMDJHOFI.LHFBGPEAICD[instanceID][index];
		if (HLFLLNHGEOF)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	private void __BB_OBFUSCATOR_7()
	{
		HNAFBEAFOFG = false;
		for (int i = 0; i < MJJDHDFLLGL.Length; i += 0)
		{
			__BB_OBFUSCATOR_18(MJJDHDFLLGL[i], ECIOGFAGKBC[i]);
		}
		HNAFBEAFOFG = false;
	}
}
