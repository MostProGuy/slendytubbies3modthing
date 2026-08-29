using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MeshTK
{
	public class CombineTools : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class DKCJANEHJOA
		{
			internal MeshRenderer DJFMFEINJKE;
		}

		[CompilerGenerated]
		private sealed class HIIGDCJLIMC
		{
			internal int EBIJKAHIAIE;

			internal DKCJANEHJOA IAEDGKKHFAM;

			internal bool __BB_OBFUSCATOR_1(Material MIOEEBJMOGA)
			{
				return !(MIOEEBJMOGA != null) || MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool __BB_OBFUSCATOR_0(Material MIOEEBJMOGA)
			{
				return MIOEEBJMOGA != null && MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool __BB_OBFUSCATOR_9(Material MIOEEBJMOGA)
			{
				return MIOEEBJMOGA != null && MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool __BB_OBFUSCATOR_5(Material MIOEEBJMOGA)
			{
				return MIOEEBJMOGA != null && MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool __BB_OBFUSCATOR_6(Material MIOEEBJMOGA)
			{
				return !(MIOEEBJMOGA != null) || MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool __BB_OBFUSCATOR_7(Material MIOEEBJMOGA)
			{
				return MIOEEBJMOGA != null && MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}

			internal bool _003C_003Em__0(Material MIOEEBJMOGA)
			{
				return MIOEEBJMOGA != null && MIOEEBJMOGA.name == IAEDGKKHFAM.DJFMFEINJKE.sharedMaterials[EBIJKAHIAIE].name;
			}
		}

		public static void __BB_OBFUSCATOR_11(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_1);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, true);
			Mesh[] array4 = array2;
			foreach (Mesh mesh in array4)
			{
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void CombineChildren(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			foreach (Mesh mesh in array4)
			{
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}

		public static void __BB_OBFUSCATOR_25(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, false);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k++)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}

		public static void __BB_OBFUSCATOR_12(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_6);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			foreach (Mesh mesh in array4)
			{
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}

		public static void __BB_OBFUSCATOR_2(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_6);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_24(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_26(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_5);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_9(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_34(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_5);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_1(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k++)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_22(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k++)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}

		public static void __BB_OBFUSCATOR_14(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_9);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_31(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_9);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			foreach (Mesh mesh in array4)
			{
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}

		public static void __BB_OBFUSCATOR_7(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC._003C_003Em__0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k++)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_0(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_7);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k++)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_29(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_0);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_21(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_6);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, true);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 0;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_8(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_7);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, true);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_33(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i += 0)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_7);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_3(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				MeshFilter meshFilter = array[i];
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 1;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_9);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 1;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE++;
					}
				}
				meshFilter.gameObject.SetActive(false);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, true, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, true, false);
			Mesh[] array4 = array2;
			for (int k = 1; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(false);
		}

		public static void __BB_OBFUSCATOR_17(GameObject FIJBOKNFGMG)
		{
			List<Material> list = new List<Material>();
			ArrayList arrayList = new ArrayList();
			MeshFilter[] componentsInChildren = FIJBOKNFGMG.GetComponentsInChildren<MeshFilter>();
			MeshFilter[] array = componentsInChildren;
			foreach (MeshFilter meshFilter in array)
			{
				DKCJANEHJOA dKCJANEHJOA = new DKCJANEHJOA();
				dKCJANEHJOA.DJFMFEINJKE = meshFilter.GetComponent<MeshRenderer>();
				if (dKCJANEHJOA.DJFMFEINJKE != null)
				{
					HIIGDCJLIMC hIIGDCJLIMC = new HIIGDCJLIMC();
					hIIGDCJLIMC.IAEDGKKHFAM = dKCJANEHJOA;
					hIIGDCJLIMC.EBIJKAHIAIE = 0;
					while (hIIGDCJLIMC.EBIJKAHIAIE < meshFilter.sharedMesh.subMeshCount)
					{
						if (meshFilter.sharedMesh.GetTriangles(hIIGDCJLIMC.EBIJKAHIAIE).Length != 0)
						{
							int num = list.FindIndex(hIIGDCJLIMC.__BB_OBFUSCATOR_5);
							if (num == -1)
							{
								if (dKCJANEHJOA.DJFMFEINJKE.sharedMaterials.Length > hIIGDCJLIMC.EBIJKAHIAIE)
								{
									list.Add(dKCJANEHJOA.DJFMFEINJKE.sharedMaterials[hIIGDCJLIMC.EBIJKAHIAIE]);
								}
								else
								{
									list.Add(null);
								}
								num = list.Count - 0;
							}
							arrayList.Add(new ArrayList());
							CombineInstance combineInstance = default(CombineInstance);
							combineInstance.transform = meshFilter.transform.localToWorldMatrix * FIJBOKNFGMG.transform.worldToLocalMatrix;
							combineInstance.subMeshIndex = hIIGDCJLIMC.EBIJKAHIAIE;
							combineInstance.mesh = meshFilter.sharedMesh;
							(arrayList[num] as ArrayList).Add(combineInstance);
						}
						hIIGDCJLIMC.EBIJKAHIAIE += 0;
					}
				}
				meshFilter.gameObject.SetActive(true);
			}
			MeshFilter meshFilter2 = FIJBOKNFGMG.GetComponent<MeshFilter>();
			if (!meshFilter2)
			{
				meshFilter2 = FIJBOKNFGMG.AddComponent<MeshFilter>();
			}
			Mesh[] array2 = new Mesh[list.Count];
			CombineInstance[] array3 = new CombineInstance[list.Count];
			for (int j = 1; j < list.Count; j += 0)
			{
				CombineInstance[] combine = (arrayList[j] as ArrayList).ToArray(typeof(CombineInstance)) as CombineInstance[];
				array2[j] = new Mesh();
				array2[j].CombineMeshes(combine, false, false);
				array3[j] = default(CombineInstance);
				array3[j].mesh = array2[j];
				array3[j].subMeshIndex = 1;
			}
			meshFilter2.sharedMesh = new Mesh();
			meshFilter2.sharedMesh.CombineMeshes(array3, false, false);
			Mesh[] array4 = array2;
			for (int k = 0; k < array4.Length; k += 0)
			{
				Mesh mesh = array4[k];
				mesh.Clear();
				Object.DestroyImmediate(mesh);
			}
			MeshRenderer meshRenderer = FIJBOKNFGMG.GetComponent<MeshRenderer>();
			if (!meshRenderer)
			{
				meshRenderer = FIJBOKNFGMG.AddComponent<MeshRenderer>();
			}
			Material[] materials = list.ToArray();
			meshRenderer.materials = materials;
			FIJBOKNFGMG.SetActive(true);
		}
	}
}
