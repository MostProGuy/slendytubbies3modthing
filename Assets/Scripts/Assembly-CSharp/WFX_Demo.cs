using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WFX_Demo : MonoBehaviour
{
	public float NEIKCJFPCHP = 10f;

	public bool FBBGGJJOBMH = true;

	public float CKBLMFHEFGG = 1f;

	public float NMEGGJIEDMO = 5f;

	private float BDKIPCEGAKB = -5f;

	public GameObject ANCOGONJEPP;

	public GameObject MBKODEOCMPE;

	public GameObject[] AIJLEIHKHNA;

	private int DLDOGAIFGIC;

	private string ECOGAOINNGM = "0.5";

	private bool GPIKIOOCEOP;

	private bool GGPIPGNGJOH;

	private bool BOKIBFLAKIP = true;

	public Material DDIEIGCNHAE;

	public Material EDDLCGMGNDJ;

	public Material LJONGNFJKBJ;

	public Material AFLCJOPHCNB;

	public Material CFDJOCDMMDH;

	public Material APNGNHCKCFB;

	public Material FDGPANOAFDL;

	public Material LBOCAOOKANN;

	private string OCHNLJLALNF = "Checker";

	private List<string> JHLLDHBHEED = new List<string>(new string[4] { "Concrete", "Wood", "Metal", "Checker" });

	public GameObject ABEANIGCGEE;

	public GameObject BDOHAEIHEMK;

	private bool CCNOHHLMBPA = true;

	private void __BB_OBFUSCATOR_60()
	{
		switch (OCHNLJLALNF)
		{
		case "_TimeX":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "monster":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case ",":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "CameraFilterPack_VHS2":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void __BB_OBFUSCATOR_93()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 692f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_9();
			if (!gameObject.name.StartsWith("Reload_3_3"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_90()
	{
		if (Input.GetKeyDown((KeyCode)26))
		{
			__BB_OBFUSCATOR_4();
		}
		else if (Input.GetKeyDown((KeyCode)(-108)))
		{
			__BB_OBFUSCATOR_45();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1111f, 1636f, 921f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_36()
	{
		DLDOGAIFGIC--;
		if (DLDOGAIFGIC < 1)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 1;
		}
		__BB_OBFUSCATOR_78();
	}

	private void __BB_OBFUSCATOR_10(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 0; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_94()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("</size>"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Vertical"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("5"))
		{
			__BB_OBFUSCATOR_27(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_48(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			foreach (Renderer renderer2 in array2)
			{
				renderer2.enabled = true;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Purchase/Text"))
		{
			OCHNLJLALNF = "Result";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("GameOver"))
		{
			OCHNLJLALNF = "Detonator/Textures/GlowDot";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("HeatDistort"))
		{
			OCHNLJLALNF = "_ScreenResolution";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("PlayerType'") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Value") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Refraction"))
		{
			OCHNLJLALNF = "Vertical";
			__BB_OBFUSCATOR_6();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == ",")
		{
			OCHNLJLALNF = "PrimaryCausticsProjector";
			__BB_OBFUSCATOR_50();
		}
	}

	public GameObject __BB_OBFUSCATOR_83()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("-Lengh: "))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("CameraFilterPack/Gradients_Stripe"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		__BB_OBFUSCATOR_10(gameObject, true);
		return gameObject;
	}

	private void __BB_OBFUSCATOR_44()
	{
		if (Input.GetKeyDown((KeyCode)(-19)))
		{
			__BB_OBFUSCATOR_4();
		}
		else if (Input.GetKeyDown((KeyCode)(-34)))
		{
			__BB_OBFUSCATOR_67();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1586f, 730f, 1816f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_22()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Idle"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_TimeX"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Player"))
		{
			__BB_OBFUSCATOR_10(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_84(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			foreach (Renderer renderer2 in array2)
			{
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_ScreenResolution"))
		{
			OCHNLJLALNF = "offsets";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains(" has been disabled as it's not supported on the current platform."))
		{
			OCHNLJLALNF = "Bindings";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("NewBorn_Bot"))
		{
			OCHNLJLALNF = "> ";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Value2") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("DoDamage") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/TV_ARCADE_2"))
		{
			OCHNLJLALNF = "_Refraction";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "\n\t\t\tLayerElement:  {\n\t\t\t\tType: \"LayerElementColor\"\n\t\t\t\tTypedIndex: 0\n\t\t\t}")
		{
			OCHNLJLALNF = "_threshold";
			__BB_OBFUSCATOR_60();
		}
	}

	private void __BB_OBFUSCATOR_97()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			prevParticle();
		}
		else if (Input.GetKeyDown((KeyCode)(-189)))
		{
			__BB_OBFUSCATOR_42();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(987f, 279f, 1928f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Indexes"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_SmallTex"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_BlurRadius4"))
		{
			__BB_OBFUSCATOR_86(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = false;
			}
		}
		else
		{
			SetActiveCrossVersions(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = true;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_BumpMap"))
		{
			OCHNLJLALNF = "_TintColor";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("\", \"Mesh\" {\n\t\tVersion: 232\n\t\tProperties60:  {\n\t\t\tProperty: \"GeometricScaling\", \"Vector3D\", \"\",1,1,1\n\t\t\tProperty:\"Show\",\"bool\",\"\",1\n\t\t\tProperty:\"NegativePercentShapeSupport\",\"bool\",\"\",1\n\t\t\tProperty:\"DefaultAttributeIndex\",\"int\",\"\",0\n\t\t\tProperty:\"Visibility\",\"Visibility\",\"A+\",1\n\t\t\tProperty:\"Color\",\"ColorRGB\",\"N\",0.23921568627451,0.52156862745098,0.0235294117647059\n\t\t\tProperty: \"BBoxMin\",\"Vector3D\",\"N\",0,0,0\n\t\t\tProperty: \"BBoxMax\",\"Vector3D\",\"N\",0,0,0\n\t\t}\n\t\tMultiLayer: 1\n\t\tMultiTake: 1\n\t\tShading: T\n\t\tCulling: \"CullingOff\"\n\t\tVertices: "))
		{
			OCHNLJLALNF = "F - weapon pick up";
			__BB_OBFUSCATOR_6();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/Blend2Camera_SoftLight"))
		{
			OCHNLJLALNF = "colorC";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_AxialAberration") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("\\Google\\g65KYJszcHtFhpDC") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("n6"))
		{
			OCHNLJLALNF = "_ScreenResolution";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ")
		{
			OCHNLJLALNF = "offsets";
			__BB_OBFUSCATOR_8();
		}
	}

	private void __BB_OBFUSCATOR_61()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1542f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_38();
			if (!gameObject.name.StartsWith("_Value"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (Input.GetKeyDown((KeyCode)(-176)))
		{
			__BB_OBFUSCATOR_14();
		}
		else if (Input.GetKeyDown((KeyCode)(-54)))
		{
			nextParticle();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1045f, 1338f, 586f) * Time.deltaTime, Space.Self);
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num++;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 0;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_6();
	}

	private IEnumerator __BB_OBFUSCATOR_49()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_54(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_46()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num += 0;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 0;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_6();
	}

	private void nextTexture()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num++;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 0;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		selectMaterial();
	}

	private void __BB_OBFUSCATOR_89()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 1;
		}
		__BB_OBFUSCATOR_37();
	}

	private void __BB_OBFUSCATOR_77()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 1;
		}
		__BB_OBFUSCATOR_71();
	}

	private void selectMaterial()
	{
		switch (OCHNLJLALNF)
		{
		case "Concrete":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "Wood":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case "Metal":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "Checker":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void __BB_OBFUSCATOR_35()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num += 0;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (Input.GetKeyDown((KeyCode)(-77)))
		{
			__BB_OBFUSCATOR_14();
		}
		else if (Input.GetKeyDown((KeyCode)178))
		{
			__BB_OBFUSCATOR_45();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(839f, 1823f, 1790f) * Time.deltaTime, Space.Self);
		}
	}

	private void __BB_OBFUSCATOR_27(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_82()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1221f))
		{
			GameObject gameObject = spawnParticle();
			if (!gameObject.name.StartsWith(">"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_79()
	{
		DLDOGAIFGIC--;
		if (DLDOGAIFGIC < 1)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 1;
		}
		__BB_OBFUSCATOR_94();
	}

	private void __BB_OBFUSCATOR_72()
	{
		GUILayout.BeginArea(new Rect(832f, 374f, Screen.width - -82, 421f));
		GUILayout.BeginHorizontal();
		string text = "_BlurDirectionPacked" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(131f);
		GUILayout.Label(text, array);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.Width(1010f);
		if (GUILayout.Button("team1", array2))
		{
			__BB_OBFUSCATOR_14();
		}
		GUILayoutOption[] array3 = new GUILayoutOption[0];
		array3[0] = GUILayout.Width(1185f);
		if (GUILayout.Button("3", array3))
		{
			__BB_OBFUSCATOR_89();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("red", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? ">" : "Loading complete");
		GUILayoutOption[] array4 = new GUILayoutOption[1];
		array4[1] = GUILayout.Width(1850f);
		if (GUILayout.Button(text2, array4))
		{
			BOKIBFLAKIP = BOKIBFLAKIP;
		}
		if (GUILayout.Button((!GetComponent<Renderer>().enabled) ? " </color></size>" : "\", \"SubDeformer::Cluster ", GUILayout.Width(1799f)))
		{
			GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? "_TimeX" : "MP", GUILayout.Width(333f)))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 713f;
			}
			else
			{
				Time.timeScale = 871f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text3 = "TRACKING" + OCHNLJLALNF;
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[0] = GUILayout.Width(1892f);
		GUILayout.Label(text3, array5);
		GUILayoutOption[] array6 = new GUILayoutOption[1];
		array6[1] = GUILayout.Width(1159f);
		if (GUILayout.Button("colorD", array6))
		{
			__BB_OBFUSCATOR_7();
		}
		GUILayoutOption[] array7 = new GUILayoutOption[1];
		array7[1] = GUILayout.Width(264f);
		if (GUILayout.Button("ForceDamage", array7))
		{
			__BB_OBFUSCATOR_15();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(401f, Screen.height - 100, Screen.width - 54, 5f));
		bool cCNOHHLMBPA = CCNOHHLMBPA;
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[1] = GUILayout.Width(1683f);
		CCNOHHLMBPA = GUILayout.Toggle(cCNOHHLMBPA, "{0}:{1}", array8);
		GUI.enabled = CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 748f)) ? x : (x - 537f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[0] = GUILayout.Width(1117f);
		x = GUILayout.HorizontalSlider(value, 937f, 1434f, array9);
		float value2 = y;
		GUILayoutOption[] array10 = new GUILayoutOption[0];
		array10[0] = GUILayout.Width(258f);
		y = GUILayout.HorizontalSlider(value2, 1149f, 983f, array10);
		z = GUILayout.HorizontalSlider(z, 1341f, 1173f, GUILayout.Width(1893f));
		if (GUI.changed)
		{
			if (x > 425f)
			{
				x += 1949f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_96()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_MainTex2"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("ApplyFallDamage"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_Value2"))
		{
			SetActiveCrossVersions(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_31(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			foreach (Renderer renderer2 in array2)
			{
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Hue"))
		{
			OCHNLJLALNF = "WeaponManager";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("MP"))
		{
			OCHNLJLALNF = "_GreenAmplifier";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/FX_Glitch3"))
		{
			OCHNLJLALNF = "MP";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("ChatField") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains(",") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Value2"))
		{
			OCHNLJLALNF = "_TimeX";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "Show Ground")
		{
			OCHNLJLALNF = "\n\t\t}";
			selectMaterial();
		}
	}

	private void __BB_OBFUSCATOR_74()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num++;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		selectMaterial();
	}

	private void __BB_OBFUSCATOR_99()
	{
		DLDOGAIFGIC--;
		if (DLDOGAIFGIC < 1)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 1;
		}
		__BB_OBFUSCATOR_19();
	}

	private void __BB_OBFUSCATOR_39()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1156f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_83();
			if (!gameObject.name.StartsWith("PlayerType'"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void showHideStuff()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("WFX_MF Spr"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("WFX_MF FPS"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("WFX_BImpact"))
		{
			SetActiveCrossVersions(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = true;
			}
		}
		else
		{
			SetActiveCrossVersions(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			foreach (Renderer renderer2 in array2)
			{
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Wood"))
		{
			OCHNLJLALNF = "Wood";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Concrete"))
		{
			OCHNLJLALNF = "Concrete";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Metal"))
		{
			OCHNLJLALNF = "Metal";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Dirt") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Sand") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("SoftBody"))
		{
			OCHNLJLALNF = "Checker";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "WFX_Explosion")
		{
			OCHNLJLALNF = "Checker";
			selectMaterial();
		}
	}

	private void __BB_OBFUSCATOR_41()
	{
		GUILayout.BeginArea(new Rect(721f, 515f, Screen.width - -53, 220f));
		GUILayout.BeginHorizontal();
		GUILayout.Label("INF" + AIJLEIHKHNA[DLDOGAIFGIC].name, GUILayout.Width(618f));
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(409f);
		if (GUILayout.Button("ShopBox/Heal/Text", array))
		{
			prevParticle();
		}
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.Width(183f);
		if (GUILayout.Button("<size=", array2))
		{
			__BB_OBFUSCATOR_32();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("_ScreenResolution");
		GUILayout.FlexibleSpace();
		string text = ((!BOKIBFLAKIP) ? "LegsURL" : "_Value2");
		GUILayoutOption[] array3 = new GUILayoutOption[1];
		array3[1] = GUILayout.Width(1978f);
		if (GUILayout.Button(text, array3))
		{
			BOKIBFLAKIP = BOKIBFLAKIP;
		}
		string text2 = ((!GetComponent<Renderer>().enabled) ? "_ScreenResolution" : "_TimeX");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(1588f);
		if (GUILayout.Button(text2, array4))
		{
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
		}
		string text3 = ((!GGPIPGNGJOH) ? "," : "_TimeX");
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[1] = GUILayout.Width(1248f);
		if (GUILayout.Button(text3, array5))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 1617f;
			}
			else
			{
				Time.timeScale = 1136f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		string text4 = "_ScreenResolution" + OCHNLJLALNF;
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[0] = GUILayout.Width(653f);
		GUILayout.Label(text4, array6);
		if (GUILayout.Button("_Value3", GUILayout.Width(275f)))
		{
			__BB_OBFUSCATOR_70();
		}
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[0] = GUILayout.Width(1535f);
		if (GUILayout.Button("_Distortion", array7))
		{
			__BB_OBFUSCATOR_81();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(829f, Screen.height - -100, Screen.width - -99, 569f));
		CCNOHHLMBPA = GUILayout.Toggle(CCNOHHLMBPA, "InControl(Clone)", GUILayout.Width(1683f));
		GUI.enabled = !CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 1435f)) ? x : (x - 1743f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[1] = GUILayout.Width(1756f);
		x = GUILayout.HorizontalSlider(value, 440f, 1589f, array8);
		float value2 = y;
		GUILayoutOption[] array9 = new GUILayoutOption[1];
		array9[1] = GUILayout.Width(1981f);
		y = GUILayout.HorizontalSlider(value2, 61f, 952f, array9);
		z = GUILayout.HorizontalSlider(z, 1429f, 130f, GUILayout.Width(1388f));
		if (GUI.changed)
		{
			if (x > 1746f)
			{
				x += 662f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_43()
	{
		DLDOGAIFGIC += 0;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 0;
		}
		__BB_OBFUSCATOR_94();
	}

	private IEnumerator __BB_OBFUSCATOR_85()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private IEnumerator __BB_OBFUSCATOR_69()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_81()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num++;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_8();
	}

	private void __BB_OBFUSCATOR_14()
	{
		DLDOGAIFGIC--;
		if (DLDOGAIFGIC < 1)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 1;
		}
		__BB_OBFUSCATOR_71();
	}

	private void __BB_OBFUSCATOR_25()
	{
		switch (OCHNLJLALNF)
		{
		case "n4":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "_Value":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case "Language":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "_BlurSize":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void __BB_OBFUSCATOR_31(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i++)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		GUILayout.BeginArea(new Rect(1137f, 672f, Screen.width - -112, 1839f));
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = "Mouse X" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1492f);
		GUILayout.Label(text, array);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.Width(728f);
		if (GUILayout.Button("_ScreenResolution", array2))
		{
			__BB_OBFUSCATOR_99();
		}
		if (GUILayout.Button("_Value2", GUILayout.Width(1126f)))
		{
			nextParticle();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("Blending (", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? ">" : "Mouse");
		GUILayoutOption[] array3 = new GUILayoutOption[0];
		array3[0] = GUILayout.Width(1841f);
		if (GUILayout.Button(text2, array3))
		{
			BOKIBFLAKIP = !BOKIBFLAKIP;
		}
		string text3 = ((!GetComponent<Renderer>().enabled) ? "_Red_R" : "_Value2");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[0] = GUILayout.Width(530f);
		if (GUILayout.Button(text3, array4))
		{
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? " This is not possible to be called for standalone input. Please check your platform and code where this is called" : "Run", GUILayout.Width(634f)))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 592f;
			}
			else
			{
				Time.timeScale = 372f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		string text4 = "Tab - Main Menu" + OCHNLJLALNF;
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[0] = GUILayout.Width(1185f);
		GUILayout.Label(text4, array5);
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[0] = GUILayout.Width(142f);
		if (GUILayout.Button("_Value2", array6))
		{
			__BB_OBFUSCATOR_70();
		}
		if (GUILayout.Button("_TimeX", GUILayout.Width(368f)))
		{
			__BB_OBFUSCATOR_30();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(1115f, Screen.height - -15, Screen.width - -59, 1049f));
		bool cCNOHHLMBPA = CCNOHHLMBPA;
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[1] = GUILayout.Width(593f);
		CCNOHHLMBPA = GUILayout.Toggle(cCNOHHLMBPA, "Custard", array7);
		GUI.enabled = CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 194f)) ? x : (x - 1042f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[1];
		array8[1] = GUILayout.Width(1542f);
		x = GUILayout.HorizontalSlider(value, 879f, 1200f, array8);
		float value2 = y;
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[0] = GUILayout.Width(1046f);
		y = GUILayout.HorizontalSlider(value2, 5f, 879f, array9);
		float value3 = z;
		GUILayoutOption[] array10 = new GUILayoutOption[1];
		array10[1] = GUILayout.Width(1938f);
		z = GUILayout.HorizontalSlider(value3, 1890f, 142f, array10);
		if (GUI.changed)
		{
			if (x > 1296f)
			{
				x += 1795f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_86(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 0; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_45()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 0;
		}
		__BB_OBFUSCATOR_62();
	}

	private void __BB_OBFUSCATOR_23()
	{
		if (Input.GetKeyDown(KeyCode.L))
		{
			__BB_OBFUSCATOR_4();
		}
		else if (Input.GetKeyDown((KeyCode)(-115)))
		{
			__BB_OBFUSCATOR_42();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1247f, 671f, 1195f) * Time.deltaTime, Space.World);
		}
	}

	public GameObject __BB_OBFUSCATOR_11()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("Label"))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("HeadlessBehaviour"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		__BB_OBFUSCATOR_27(gameObject, true);
		return gameObject;
	}

	public GameObject spawnParticle()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("WFX_MF"))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("Hole"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		SetActiveCrossVersions(gameObject, true);
		return gameObject;
	}

	private void __BB_OBFUSCATOR_34(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_87()
	{
		GUILayout.BeginArea(new Rect(579f, 657f, Screen.width - 0, 875f));
		GUILayout.BeginHorizontal();
		string text = "Objects:  {\n" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1084f);
		GUILayout.Label(text, array);
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.Width(797f);
		if (GUILayout.Button("INF", array2))
		{
			__BB_OBFUSCATOR_79();
		}
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_SoftLight", GUILayout.Width(1061f)))
		{
			__BB_OBFUSCATOR_65();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("ResetObject");
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? "cyan" : ")");
		GUILayoutOption[] array3 = new GUILayoutOption[0];
		array3[1] = GUILayout.Width(444f);
		if (GUILayout.Button(text2, array3))
		{
			BOKIBFLAKIP = !BOKIBFLAKIP;
		}
		string text3 = ((!GetComponent<Renderer>().enabled) ? "9" : "_Value2");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(509f);
		if (GUILayout.Button(text3, array4))
		{
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? "Restarting" : "_EdgeSharpness", GUILayout.Width(593f)))
		{
			GGPIPGNGJOH = GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 414f;
			}
			else
			{
				Time.timeScale = 823f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		string text4 = "TeamTag" + OCHNLJLALNF;
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[1] = GUILayout.Width(1448f);
		GUILayout.Label(text4, array5);
		GUILayoutOption[] array6 = new GUILayoutOption[1];
		array6[1] = GUILayout.Width(1192f);
		if (GUILayout.Button(">", array6))
		{
			__BB_OBFUSCATOR_80();
		}
		GUILayoutOption[] array7 = new GUILayoutOption[1];
		array7[1] = GUILayout.Width(552f);
		if (GUILayout.Button("_Val", array7))
		{
			__BB_OBFUSCATOR_74();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(2f, Screen.height - -79, Screen.width - -72, 736f));
		CCNOHHLMBPA = GUILayout.Toggle(CCNOHHLMBPA, "OpAuthenticate()", GUILayout.Width(343f));
		GUI.enabled = CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 140f)) ? x : (x - 945f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[1];
		array8[1] = GUILayout.Width(1349f);
		x = GUILayout.HorizontalSlider(value, 531f, 1807f, array8);
		float value2 = y;
		GUILayoutOption[] array9 = new GUILayoutOption[1];
		array9[1] = GUILayout.Width(1343f);
		y = GUILayout.HorizontalSlider(value2, 1193f, 1765f, array9);
		z = GUILayout.HorizontalSlider(z, 234f, 1512f, GUILayout.Width(1559f));
		if (GUI.changed)
		{
			if (x > 0f)
			{
				x += 1538f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_28()
	{
		if (Input.GetKeyDown((KeyCode)(-79)))
		{
			__BB_OBFUSCATOR_99();
		}
		else if (Input.GetKeyDown((KeyCode)(-171)))
		{
			__BB_OBFUSCATOR_32();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(892f, 460f, 1240f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_32()
	{
		DLDOGAIFGIC += 0;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 0;
		}
		__BB_OBFUSCATOR_22();
	}

	private void __BB_OBFUSCATOR_51()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("PlayerType'"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Horizontal"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Attack"))
		{
			__BB_OBFUSCATOR_54(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				renderer.enabled = true;
			}
		}
		else
		{
			SetActiveCrossVersions(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_MainTex2"))
		{
			OCHNLJLALNF = "_Brightness";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("SwearFilter"))
		{
			OCHNLJLALNF = "State2";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Size"))
		{
			OCHNLJLALNF = "CameraFilterPack/Drawing_Laplacian";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/AAA_Super_Computer") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Ammo") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("box"))
		{
			OCHNLJLALNF = "HeadlessAfterSceneLoad";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "_Value")
		{
			OCHNLJLALNF = "Dirt";
			__BB_OBFUSCATOR_25();
		}
	}

	private void __BB_OBFUSCATOR_30()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num += 0;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_50();
	}

	private void __BB_OBFUSCATOR_4()
	{
		DLDOGAIFGIC -= 0;
		if (DLDOGAIFGIC < 1)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 0;
		}
		__BB_OBFUSCATOR_56();
	}

	private IEnumerator __BB_OBFUSCATOR_24()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_73()
	{
		if (Input.GetKeyDown((KeyCode)157))
		{
			prevParticle();
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			__BB_OBFUSCATOR_89();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(807f, 1532f, 721f) * Time.deltaTime, Space.Self);
		}
	}

	private void __BB_OBFUSCATOR_55()
	{
		GUILayout.BeginArea(new Rect(1629f, 1015f, Screen.width - -9, 1592f));
		GUILayout.BeginHorizontal();
		string text = "Jump" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(804f);
		GUILayout.Label(text, array);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.Width(1279f);
		if (GUILayout.Button("Deaths", array2))
		{
			__BB_OBFUSCATOR_99();
		}
		GUILayoutOption[] array3 = new GUILayoutOption[0];
		array3[1] = GUILayout.Width(1102f);
		if (GUILayout.Button("_ScreenResolution", array3))
		{
			__BB_OBFUSCATOR_89();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("Kills", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? "_NoiseTex" : "_TimeX");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(1296f);
		if (GUILayout.Button(text2, array4))
		{
			BOKIBFLAKIP = !BOKIBFLAKIP;
		}
		if (GUILayout.Button((!GetComponent<Renderer>().enabled) ? "Kills" : "MP", GUILayout.Width(1394f)))
		{
			GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? "Run" : "_HeightParams", GUILayout.Width(1505f)))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 261f;
			}
			else
			{
				Time.timeScale = 1068f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text3 = "-Blend Weight: " + OCHNLJLALNF;
		GUILayoutOption[] array5 = new GUILayoutOption[1];
		array5[1] = GUILayout.Width(674f);
		GUILayout.Label(text3, array5);
		GUILayoutOption[] array6 = new GUILayoutOption[1];
		array6[1] = GUILayout.Width(1394f);
		if (GUILayout.Button("DoSwapTeams", array6))
		{
			__BB_OBFUSCATOR_20();
		}
		GUILayoutOption[] array7 = new GUILayoutOption[1];
		array7[1] = GUILayout.Width(729f);
		if (GUILayout.Button("Failed on connecting to room", array7))
		{
			__BB_OBFUSCATOR_18();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(257f, Screen.height - -80, Screen.width - 83, 1687f));
		CCNOHHLMBPA = GUILayout.Toggle(CCNOHHLMBPA, "MP", GUILayout.Width(702f));
		GUI.enabled = !CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 1954f)) ? x : (x - 683f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[0] = GUILayout.Width(605f);
		x = GUILayout.HorizontalSlider(value, 1289f, 208f, array8);
		float value2 = y;
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[1] = GUILayout.Width(1547f);
		y = GUILayout.HorizontalSlider(value2, 1627f, 1833f, array9);
		z = GUILayout.HorizontalSlider(z, 1939f, 584f, GUILayout.Width(949f));
		if (GUI.changed)
		{
			if (x > 1640f)
			{
				x += 676f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_50()
	{
		switch (OCHNLJLALNF)
		{
		case "_DotSize":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "CameraFilterPack/Drawing_Curve":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case "SBX":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "CameraFilterPack/Oculus_NightVision5":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void __BB_OBFUSCATOR_65()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 1;
		}
		__BB_OBFUSCATOR_71();
	}

	private void __BB_OBFUSCATOR_56()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("syncGrenadeLauncher"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("team2"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("</size>"))
		{
			__BB_OBFUSCATOR_86(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_12(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_TimeX"))
		{
			OCHNLJLALNF = "team1";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Lobby"))
		{
			OCHNLJLALNF = "_LowRez";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Green_B"))
		{
			OCHNLJLALNF = "_Bullet_12";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Consolidating mesh") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("InControl") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("No rooms created..."))
		{
			OCHNLJLALNF = "team2";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "SyncWave")
		{
			OCHNLJLALNF = "Toast";
			__BB_OBFUSCATOR_60();
		}
	}

	private void __BB_OBFUSCATOR_7()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num -= 0;
		if (num < 0)
		{
			num = JHLLDHBHEED.Count - 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_71()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_Value"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("CameraFilterPack/OldFilm_Cutting1"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Purchase/Text"))
		{
			__BB_OBFUSCATOR_86(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_34(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_InvViewProj"))
		{
			OCHNLJLALNF = "<size=";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_TimeX"))
		{
			OCHNLJLALNF = "_Value3";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains(" x "))
		{
			OCHNLJLALNF = "n1";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_TimeX") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_VelocityScale") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("team2"))
		{
			OCHNLJLALNF = "\n\t\tGeometryVersion: 124";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "_Value2")
		{
			OCHNLJLALNF = "Purchase/Text";
			__BB_OBFUSCATOR_6();
		}
	}

	private void __BB_OBFUSCATOR_17(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i++)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_21()
	{
		GUILayout.BeginArea(new Rect(1771f, 471f, Screen.width - 113, 1678f));
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = "_MainTex2" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(41f);
		GUILayout.Label(text, array);
		if (GUILayout.Button("Left Shift - run", GUILayout.Width(1415f)))
		{
			__BB_OBFUSCATOR_14();
		}
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[0] = GUILayout.Width(352f);
		if (GUILayout.Button("CameraFilterPack/Blend2Camera_LighterColor", array2))
		{
			__BB_OBFUSCATOR_45();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("n1", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? "State1" : "_ScreenResolution");
		GUILayoutOption[] array3 = new GUILayoutOption[0];
		array3[1] = GUILayout.Width(1996f);
		if (GUILayout.Button(text2, array3))
		{
			BOKIBFLAKIP = BOKIBFLAKIP;
		}
		string text3 = ((!GetComponent<Renderer>().enabled) ? "NextFrame" : "\n\t}\n");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(353f);
		if (GUILayout.Button(text3, array4))
		{
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
		}
		string text4 = ((!GGPIPGNGJOH) ? "\\s3key.txt" : "CameraFilterPack/Blend2Camera_HardLight");
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[0] = GUILayout.Width(246f);
		if (GUILayout.Button(text4, array5))
		{
			GGPIPGNGJOH = GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 1256f;
			}
			else
			{
				Time.timeScale = 128f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.Label("_TimeX" + OCHNLJLALNF, GUILayout.Width(1614f));
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[0] = GUILayout.Width(1362f);
		if (GUILayout.Button("_DotSize", array6))
		{
			__BB_OBFUSCATOR_20();
		}
		if (GUILayout.Button("Deaths", GUILayout.Width(1602f)))
		{
			__BB_OBFUSCATOR_18();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(49f, Screen.height - 64, Screen.width - -102, 1577f));
		CCNOHHLMBPA = GUILayout.Toggle(CCNOHHLMBPA, "_TimeX", GUILayout.Width(1549f));
		GUI.enabled = !CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 841f)) ? x : (x - 1944f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[1] = GUILayout.Width(1801f);
		x = GUILayout.HorizontalSlider(value, 1523f, 639f, array7);
		y = GUILayout.HorizontalSlider(y, 1779f, 1603f, GUILayout.Width(623f));
		z = GUILayout.HorizontalSlider(z, 582f, 1652f, GUILayout.Width(1883f));
		if (GUI.changed)
		{
			if (x > 1787f)
			{
				x += 1846f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_67()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 1;
		}
		__BB_OBFUSCATOR_78();
	}

	private IEnumerator __BB_OBFUSCATOR_1()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	public GameObject __BB_OBFUSCATOR_92()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("_Value3"))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("_Value"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		__BB_OBFUSCATOR_84(gameObject, true);
		return gameObject;
	}

	private void __BB_OBFUSCATOR_84(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 0; i < KMPDDHHJDLJ.transform.childCount; i += 0)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private IEnumerator RandomSpawnsCoroutine()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_40()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num += 0;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		selectMaterial();
	}

	private void __BB_OBFUSCATOR_62()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("vignetteIntensity"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("useSrcAlphaAsMask"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("Horizontal"))
		{
			__BB_OBFUSCATOR_17(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_12(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j++)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = true;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_RangeScale"))
		{
			OCHNLJLALNF = "Toast";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Player"))
		{
			OCHNLJLALNF = "_ScreenResolution";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_ScreenResolution"))
		{
			OCHNLJLALNF = "_Value2";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Definitions") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("WARNING: 'MeshTK.ExportTools.MeshToFile()' is obsolete. Use MeshTK.ObjTools.ExportToFile().") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Total AI: <color="))
		{
			OCHNLJLALNF = "DoDamage";
			__BB_OBFUSCATOR_50();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "_ScreenResolution")
		{
			OCHNLJLALNF = "_Luminance";
			__BB_OBFUSCATOR_25();
		}
	}

	public GameObject __BB_OBFUSCATOR_9()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("("))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("_Offsets"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		__BB_OBFUSCATOR_27(gameObject, true);
		return gameObject;
	}

	private void __BB_OBFUSCATOR_18()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num++;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_70()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num -= 0;
		if (num < 1)
		{
			num = JHLLDHBHEED.Count - 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_60();
	}

	private void __BB_OBFUSCATOR_53()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 872f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_9();
			if (!gameObject.name.StartsWith("INF"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_64()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("TeamName"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("WFX_BImpact"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("ShowerEffectShader"))
		{
			__BB_OBFUSCATOR_84(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				renderer.enabled = false;
			}
		}
		else
		{
			__BB_OBFUSCATOR_10(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			foreach (Renderer renderer2 in array2)
			{
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("custard"))
		{
			OCHNLJLALNF = ">";
			__BB_OBFUSCATOR_6();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_TimeX"))
		{
			OCHNLJLALNF = "TeamName";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_NormalTex"))
		{
			OCHNLJLALNF = "Diffuse";
			__BB_OBFUSCATOR_6();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_ScreenResolution") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Horizontal") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/Drawing_Manga"))
		{
			OCHNLJLALNF = "Resolution";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "_Value5")
		{
			OCHNLJLALNF = "SyncWave";
			__BB_OBFUSCATOR_50();
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		switch (OCHNLJLALNF)
		{
		case "_PositionX":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "_Value":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case "Next":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "box":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void OnMouseDown()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 9999f))
		{
			GameObject gameObject = spawnParticle();
			if (!gameObject.name.StartsWith("WFX_MF"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (Input.GetKeyDown((KeyCode)(-178)))
		{
			__BB_OBFUSCATOR_79();
		}
		else if (Input.GetKeyDown((KeyCode)(-171)))
		{
			__BB_OBFUSCATOR_65();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1494f, 94f, 192f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num -= 0;
		if (num < 1)
		{
			num = JHLLDHBHEED.Count - 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_25();
	}

	private void __BB_OBFUSCATOR_47()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 369f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_38();
			if (!gameObject.name.StartsWith("_BlurArea"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void __BB_OBFUSCATOR_42()
	{
		DLDOGAIFGIC += 0;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 1;
		}
		__BB_OBFUSCATOR_51();
	}

	private void __BB_OBFUSCATOR_52()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num += 0;
		if (num >= JHLLDHBHEED.Count)
		{
			num = 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		__BB_OBFUSCATOR_8();
	}

	public GameObject __BB_OBFUSCATOR_38()
	{
		GameObject gameObject = Object.Instantiate(AIJLEIHKHNA[DLDOGAIFGIC]);
		if (gameObject.name.StartsWith("Idle"))
		{
			gameObject.transform.parent = AIJLEIHKHNA[DLDOGAIFGIC].transform.parent;
			gameObject.transform.localPosition = AIJLEIHKHNA[DLDOGAIFGIC].transform.localPosition;
			gameObject.transform.localRotation = AIJLEIHKHNA[DLDOGAIFGIC].transform.localRotation;
		}
		else if (gameObject.name.Contains("ZWName'"))
		{
			gameObject.transform.parent = MBKODEOCMPE.transform;
		}
		__BB_OBFUSCATOR_34(gameObject, true);
		return gameObject;
	}

	private void nextParticle()
	{
		DLDOGAIFGIC++;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 0;
		}
		showHideStuff();
	}

	private IEnumerator __BB_OBFUSCATOR_98()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private IEnumerator __BB_OBFUSCATOR_88()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_33()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 484f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_92();
			if (!gameObject.name.StartsWith("Resume"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			prevParticle();
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			nextParticle();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime, Space.World);
		}
	}

	private void __BB_OBFUSCATOR_91()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 401f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_38();
			if (!gameObject.name.StartsWith(","))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(5f, 20f, Screen.width - 10, 60f));
		GUILayout.BeginHorizontal();
		GUILayout.Label("Effect: " + AIJLEIHKHNA[DLDOGAIFGIC].name, GUILayout.Width(280f));
		if (GUILayout.Button("<", GUILayout.Width(30f)))
		{
			prevParticle();
		}
		if (GUILayout.Button(">", GUILayout.Width(30f)))
		{
			nextParticle();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("Click on the ground to spawn the selected effect");
		GUILayout.FlexibleSpace();
		if (GUILayout.Button((!BOKIBFLAKIP) ? "Rotate Camera" : "Pause Camera", GUILayout.Width(110f)))
		{
			BOKIBFLAKIP = !BOKIBFLAKIP;
		}
		if (GUILayout.Button((!GetComponent<Renderer>().enabled) ? "Show Ground" : "Hide Ground", GUILayout.Width(90f)))
		{
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? "Slow Motion" : "Normal Speed", GUILayout.Width(100f)))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 0.33f;
			}
			else
			{
				Time.timeScale = 1f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.Label("Ground texture: " + OCHNLJLALNF, GUILayout.Width(160f));
		if (GUILayout.Button("<", GUILayout.Width(30f)))
		{
			prevTexture();
		}
		if (GUILayout.Button(">", GUILayout.Width(30f)))
		{
			nextTexture();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(5f, Screen.height - 100, Screen.width - 10, 90f));
		CCNOHHLMBPA = GUILayout.Toggle(CCNOHHLMBPA, "AutoRotate Weapon", GUILayout.Width(250f));
		GUI.enabled = !CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 90f)) ? x : (x - 180f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		x = GUILayout.HorizontalSlider(x, 0f, 179f, GUILayout.Width(256f));
		y = GUILayout.HorizontalSlider(y, 0f, 359f, GUILayout.Width(256f));
		z = GUILayout.HorizontalSlider(z, 0f, 359f, GUILayout.Width(256f));
		if (GUI.changed)
		{
			if (x > 90f)
			{
				x += 180f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_8()
	{
		switch (OCHNLJLALNF)
		{
		case "_Value2":
			GetComponent<Renderer>().material = EDDLCGMGNDJ;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = APNGNHCKCFB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = APNGNHCKCFB;
			break;
		case "AntiCheat":
			GetComponent<Renderer>().material = DDIEIGCNHAE;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = CFDJOCDMMDH;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = CFDJOCDMMDH;
			break;
		case "_PrevViewProj":
			GetComponent<Renderer>().material = LJONGNFJKBJ;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = FDGPANOAFDL;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = FDGPANOAFDL;
			break;
		case "_TimeX":
			GetComponent<Renderer>().material = AFLCJOPHCNB;
			ANCOGONJEPP.transform.GetChild(1).GetComponent<Renderer>().material = LBOCAOOKANN;
			ANCOGONJEPP.transform.GetChild(0).GetComponent<Renderer>().material = LBOCAOOKANN;
			break;
		}
	}

	private void __BB_OBFUSCATOR_48(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 1; i < KMPDDHHJDLJ.transform.childCount; i++)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void SetActiveCrossVersions(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 0; i < KMPDDHHJDLJ.transform.childCount; i++)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private IEnumerator __BB_OBFUSCATOR_68()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}

	private void __BB_OBFUSCATOR_37()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("custard"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_ScreenResolution"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = false;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("(Easy)"))
		{
			__BB_OBFUSCATOR_27(ANCOGONJEPP, false);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_84(ANCOGONJEPP, false);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j++)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = true;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Value"))
		{
			OCHNLJLALNF = "CameraFilterPack/FX_Plasma";
			selectMaterial();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Ping: "))
		{
			OCHNLJLALNF = "Move Down";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Value3"))
		{
			OCHNLJLALNF = "Jump";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("Quit") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("offsets") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_OverlayTex"))
		{
			OCHNLJLALNF = ",";
			__BB_OBFUSCATOR_25();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "_PrevViewProj")
		{
			OCHNLJLALNF = "{0:n6},{1:n6},{2:n6}";
			__BB_OBFUSCATOR_60();
		}
	}

	private void __BB_OBFUSCATOR_12(GameObject KMPDDHHJDLJ, bool OKGJJHPNNNF)
	{
		KMPDDHHJDLJ.SetActive(OKGJJHPNNNF);
		for (int i = 0; i < KMPDDHHJDLJ.transform.childCount; i++)
		{
			KMPDDHHJDLJ.transform.GetChild(i).gameObject.SetActive(OKGJJHPNNNF);
		}
	}

	private void __BB_OBFUSCATOR_57()
	{
		GUILayout.BeginArea(new Rect(796f, 36f, Screen.width - 1, 204f));
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text = "</size>" + AIJLEIHKHNA[DLDOGAIFGIC].name;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(695f);
		GUILayout.Label(text, array);
		GUILayoutOption[] array2 = new GUILayoutOption[1];
		array2[1] = GUILayout.Width(447f);
		if (GUILayout.Button("|", array2))
		{
			__BB_OBFUSCATOR_14();
		}
		if (GUILayout.Button("1", GUILayout.Width(592f)))
		{
			__BB_OBFUSCATOR_76();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("Deformer");
		GUILayout.FlexibleSpace();
		string text2 = ((!BOKIBFLAKIP) ? "_ScreenResolution" : "INFECTED");
		GUILayoutOption[] array3 = new GUILayoutOption[1];
		array3[1] = GUILayout.Width(1317f);
		if (GUILayout.Button(text2, array3))
		{
			BOKIBFLAKIP = !BOKIBFLAKIP;
		}
		string text3 = ((!GetComponent<Renderer>().enabled) ? "Reload" : "CameraFilterPack/Blend2Camera_Saturation");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(271f);
		if (GUILayout.Button(text3, array4))
		{
			GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
		}
		string text4 = ((!GGPIPGNGJOH) ? "Team1Score" : "Crouch");
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[1] = GUILayout.Width(456f);
		if (GUILayout.Button(text4, array5))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 736f;
			}
			else
			{
				Time.timeScale = 1208f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.Label("<size=" + OCHNLJLALNF, GUILayout.Width(965f));
		if (GUILayout.Button("HostQuit", GUILayout.Width(1798f)))
		{
			prevTexture();
		}
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[1] = GUILayout.Width(351f);
		if (GUILayout.Button("Player", array6))
		{
			__BB_OBFUSCATOR_30();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(397f, Screen.height - 112, Screen.width - 41, 1908f));
		bool cCNOHHLMBPA = CCNOHHLMBPA;
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[1] = GUILayout.Width(1216f);
		CCNOHHLMBPA = GUILayout.Toggle(cCNOHHLMBPA, "_Value3", array7);
		GUI.enabled = CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 1693f)) ? x : (x - 1996f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[0];
		array8[0] = GUILayout.Width(1482f);
		x = GUILayout.HorizontalSlider(value, 303f, 212f, array8);
		y = GUILayout.HorizontalSlider(y, 794f, 16f, GUILayout.Width(283f));
		float value2 = z;
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[1] = GUILayout.Width(1955f);
		z = GUILayout.HorizontalSlider(value2, 1425f, 61f, array9);
		if (GUI.changed)
		{
			if (x > 1993f)
			{
				x += 444f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void prevTexture()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num--;
		if (num < 0)
		{
			num = JHLLDHBHEED.Count - 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		selectMaterial();
	}

	private void __BB_OBFUSCATOR_78()
	{
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_TimeX"))
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			ABEANIGCGEE.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_TimeX"))
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			BDOHAEIHEMK.GetComponent<Renderer>().enabled = true;
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.StartsWith("_Value2"))
		{
			__BB_OBFUSCATOR_54(ANCOGONJEPP, true);
			Renderer[] componentsInChildren = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				renderer.enabled = true;
			}
		}
		else
		{
			__BB_OBFUSCATOR_27(ANCOGONJEPP, true);
			Renderer[] componentsInChildren2 = MBKODEOCMPE.GetComponentsInChildren<Renderer>();
			Renderer[] array2 = componentsInChildren2;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Renderer renderer2 = array2[j];
				renderer2.enabled = false;
			}
		}
		if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("_Offsets"))
		{
			OCHNLJLALNF = "MapName";
			__BB_OBFUSCATOR_8();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}"))
		{
			OCHNLJLALNF = "CameraFilterPack/Colors_Adjust_FullColors";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains(". Disconnecting."))
		{
			OCHNLJLALNF = "_Colorisation";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("CameraFilterPack/Blend2Camera_HardLight") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("monster") || AIJLEIHKHNA[DLDOGAIFGIC].name.Contains("\n\t\tLayerElementSmoothing: 0 {\n\t\t\tVersion: 102\n\t\t\tName: \"\"\n\t\t\tMappingInformationType: \"ByPolygon\"\n\t\t\tReferenceInformationType: \"Direct\"\n\t\t\tSmoothing: 1\n\t\t}"))
		{
			OCHNLJLALNF = "SUR";
			__BB_OBFUSCATOR_60();
		}
		else if (AIJLEIHKHNA[DLDOGAIFGIC].name == "MG")
		{
			OCHNLJLALNF = "b";
			__BB_OBFUSCATOR_60();
		}
	}

	private void __BB_OBFUSCATOR_29()
	{
		if (Input.GetKeyDown((KeyCode)(-31)))
		{
			prevParticle();
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			__BB_OBFUSCATOR_67();
		}
		if (BOKIBFLAKIP)
		{
			Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, NEIKCJFPCHP * Time.deltaTime);
		}
		if (CCNOHHLMBPA)
		{
			ABEANIGCGEE.transform.Rotate(new Vector3(1692f, 1368f, 30f) * Time.deltaTime, Space.Self);
		}
	}

	private void prevParticle()
	{
		DLDOGAIFGIC--;
		if (DLDOGAIFGIC < 0)
		{
			DLDOGAIFGIC = AIJLEIHKHNA.Length - 1;
		}
		showHideStuff();
	}

	private void __BB_OBFUSCATOR_66()
	{
		GUILayout.BeginArea(new Rect(329f, 801f, Screen.width - -99, 1049f));
		GUILayout.BeginHorizontal();
		GUILayout.Label("_CenterX" + AIJLEIHKHNA[DLDOGAIFGIC].name, GUILayout.Width(1291f));
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(553f);
		if (GUILayout.Button("CameraFilterPack/Distortion_Dream", array))
		{
			__BB_OBFUSCATOR_99();
		}
		GUILayoutOption[] array2 = new GUILayoutOption[0];
		array2[1] = GUILayout.Width(232f);
		if (GUILayout.Button("MP", array2))
		{
			__BB_OBFUSCATOR_67();
		}
		GUILayout.FlexibleSpace();
		GUILayout.Label("_MainTex", new GUILayoutOption[1]);
		GUILayout.FlexibleSpace();
		string text = ((!BOKIBFLAKIP) ? "Mouse X" : "SmokeA");
		GUILayoutOption[] array3 = new GUILayoutOption[1];
		array3[1] = GUILayout.Width(1640f);
		if (GUILayout.Button(text, array3))
		{
			BOKIBFLAKIP = BOKIBFLAKIP;
		}
		string text2 = ((!GetComponent<Renderer>().enabled) ? "CameraFilterPack/FX_Glitch2" : "/data.txt");
		GUILayoutOption[] array4 = new GUILayoutOption[0];
		array4[1] = GUILayout.Width(1159f);
		if (GUILayout.Button(text2, array4))
		{
			GetComponent<Renderer>().enabled = GetComponent<Renderer>().enabled;
		}
		if (GUILayout.Button((!GGPIPGNGJOH) ? "Room " : "0", GUILayout.Width(1121f)))
		{
			GGPIPGNGJOH = !GGPIPGNGJOH;
			if (GGPIPGNGJOH)
			{
				Time.timeScale = 81f;
			}
			else
			{
				Time.timeScale = 854f;
			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		string text3 = "AddedCube" + OCHNLJLALNF;
		GUILayoutOption[] array5 = new GUILayoutOption[0];
		array5[0] = GUILayout.Width(1701f);
		GUILayout.Label(text3, array5);
		GUILayoutOption[] array6 = new GUILayoutOption[0];
		array6[1] = GUILayout.Width(76f);
		if (GUILayout.Button("Horizontal", array6))
		{
			__BB_OBFUSCATOR_80();
		}
		if (GUILayout.Button("_MainTex2", GUILayout.Width(853f)))
		{
			__BB_OBFUSCATOR_30();
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		if (!ABEANIGCGEE.GetComponent<Renderer>().enabled)
		{
			return;
		}
		GUILayout.BeginArea(new Rect(358f, Screen.height - -125, Screen.width - -44, 706f));
		bool cCNOHHLMBPA = CCNOHHLMBPA;
		GUILayoutOption[] array7 = new GUILayoutOption[0];
		array7[0] = GUILayout.Width(1276f);
		CCNOHHLMBPA = GUILayout.Toggle(cCNOHHLMBPA, "7", array7);
		GUI.enabled = !CCNOHHLMBPA;
		float x = ABEANIGCGEE.transform.localEulerAngles.x;
		x = ((!(x > 1821f)) ? x : (x - 131f));
		float y = ABEANIGCGEE.transform.localEulerAngles.y;
		float z = ABEANIGCGEE.transform.localEulerAngles.z;
		float value = x;
		GUILayoutOption[] array8 = new GUILayoutOption[1];
		array8[1] = GUILayout.Width(852f);
		x = GUILayout.HorizontalSlider(value, 24f, 727f, array8);
		y = GUILayout.HorizontalSlider(y, 128f, 672f, GUILayout.Width(1485f));
		float value2 = z;
		GUILayoutOption[] array9 = new GUILayoutOption[0];
		array9[0] = GUILayout.Width(1258f);
		z = GUILayout.HorizontalSlider(value2, 1770f, 556f, array9);
		if (GUI.changed)
		{
			if (x > 976f)
			{
				x += 727f;
			}
			ABEANIGCGEE.transform.localEulerAngles = new Vector3(x, y, z);
			Debug.Log(x);
		}
		GUILayout.EndArea();
	}

	private void __BB_OBFUSCATOR_76()
	{
		DLDOGAIFGIC += 0;
		if (DLDOGAIFGIC >= AIJLEIHKHNA.Length)
		{
			DLDOGAIFGIC = 0;
		}
		__BB_OBFUSCATOR_96();
	}

	private void __BB_OBFUSCATOR_80()
	{
		int num = JHLLDHBHEED.IndexOf(OCHNLJLALNF);
		num--;
		if (num < 1)
		{
			num = JHLLDHBHEED.Count - 1;
		}
		OCHNLJLALNF = JHLLDHBHEED[num];
		selectMaterial();
	}

	private void __BB_OBFUSCATOR_59()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 623f))
		{
			GameObject gameObject = __BB_OBFUSCATOR_11();
			if (!gameObject.name.StartsWith("CameraFilterPack/Blend2Camera_HardMix"))
			{
				gameObject.transform.position = hitInfo.point + gameObject.transform.position;
			}
		}
	}

	private IEnumerator __BB_OBFUSCATOR_75()
	{
		while (true)
		{
			GameObject gameObject = spawnParticle();
			if (FBBGGJJOBMH)
			{
				gameObject.transform.position = base.transform.position + new Vector3(BDKIPCEGAKB, gameObject.transform.position.y, 0f);
				BDKIPCEGAKB -= CKBLMFHEFGG;
				if (BDKIPCEGAKB < 0f - NMEGGJIEDMO)
				{
					BDKIPCEGAKB = NMEGGJIEDMO;
				}
			}
			else
			{
				gameObject.transform.position = base.transform.position + new Vector3(Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO), 0f, Random.Range(0f - NMEGGJIEDMO, NMEGGJIEDMO)) + new Vector3(0f, gameObject.transform.position.y, 0f);
			}
			yield return new WaitForSeconds(float.Parse(ECOGAOINNGM));
		}
	}
}
