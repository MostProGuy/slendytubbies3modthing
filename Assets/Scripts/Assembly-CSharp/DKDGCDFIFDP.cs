using System;
using System.Collections;
using UnityEngine;

public static class DKDGCDFIFDP
{
	public static Transform FindChildByRecursive(this Transform HCAPKMGHOJJ, string ILFFKICEINM)
	{
		Transform transform = HCAPKMGHOJJ.Find(ILFFKICEINM);
		if (transform != null)
		{
			return transform;
		}
		IEnumerator enumerator = HCAPKMGHOJJ.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Transform hCAPKMGHOJJ = (Transform)enumerator.Current;
				transform = hCAPKMGHOJJ.FindChildByRecursive(ILFFKICEINM);
				if (transform != null)
				{
					return transform;
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
		return null;
	}
}
