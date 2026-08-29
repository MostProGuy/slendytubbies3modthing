using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EFJOCMFBIEG : Attribute
{
	private static IEnumerable FGAEHOGEPIK;

	[CompilerGenerated]
	private static Func<Assembly, IEnumerable<Type>> NCBIMIMMADO;

	[CompilerGenerated]
	private static Func<Assembly, Type, global::CPHLGNDILFM<Assembly, Type>> ENPJJJBJGNE;

	[CompilerGenerated]
	private static Func<global::CPHLGNDILFM<Assembly, Type>, global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> ABLHFBEBGCP;

	[CompilerGenerated]
	private static Func<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>, bool> JCBAILFEDOG;

	[CompilerGenerated]
	private static Func<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>, Type> JOIJJNOBGHB;

	public static void __BB_OBFUSCATOR_12(string JHNPKJMLLEI)
	{
		__BB_OBFUSCATOR_7();
		IEnumerator enumerator = FGAEHOGEPIK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo method = type.GetMethod(JHNPKJMLLEI);
				if (method != null)
				{
					try
					{
						method.Invoke(type, null);
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
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
	}

	private static global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> __BB_OBFUSCATOR_9(global::CPHLGNDILFM<Assembly, Type> HJDGPFHIGEG)
	{
		return new global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>(HJDGPFHIGEG, HJDGPFHIGEG.MDNAJENEMNA.GetCustomAttributes(typeof(EFJOCMFBIEG), true));
	}

	private static IEnumerable<Type> __BB_OBFUSCATOR_14(Assembly IENMFMEGJAB)
	{
		return IENMFMEGJAB.GetTypes();
	}

	public static void __BB_OBFUSCATOR_19(string JHNPKJMLLEI)
	{
		__BB_OBFUSCATOR_7();
		IEnumerator enumerator = FGAEHOGEPIK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo method = type.GetMethod(JHNPKJMLLEI);
				if (method != null)
				{
					try
					{
						method.Invoke(type, null);
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
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
	}

	private static bool __BB_OBFUSCATOR_24(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.BKIPJACEDHN != null && OCICHPKJHLM.BKIPJACEDHN.Length > 1;
	}

	private static global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> __BB_OBFUSCATOR_21(global::CPHLGNDILFM<Assembly, Type> HJDGPFHIGEG)
	{
		return new global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>(HJDGPFHIGEG, HJDGPFHIGEG.MDNAJENEMNA.GetCustomAttributes(typeof(EFJOCMFBIEG), false));
	}

	private static global::CPHLGNDILFM<Assembly, Type> __BB_OBFUSCATOR_6(Assembly IENMFMEGJAB, Type MDNAJENEMNA)
	{
		return new global::CPHLGNDILFM<Assembly, Type>(IENMFMEGJAB, MDNAJENEMNA);
	}

	[CompilerGenerated]
	private static IEnumerable<Type> _003CFindCallbacks_003Em__0(Assembly IENMFMEGJAB)
	{
		return IENMFMEGJAB.GetTypes();
	}

	public static void FindCallbacks()
	{
		if (FGAEHOGEPIK == null)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = _003CFindCallbacks_003Em__0;
			}
			Func<Assembly, IEnumerable<Type>> nCBIMIMMADO = NCBIMIMMADO;
			if (ENPJJJBJGNE == null)
			{
				ENPJJJBJGNE = _003CFindCallbacks_003Em__1;
			}
			IEnumerable<global::CPHLGNDILFM<Assembly, Type>> source = assemblies.SelectMany(nCBIMIMMADO, ENPJJJBJGNE);
			if (ABLHFBEBGCP == null)
			{
				ABLHFBEBGCP = _003CFindCallbacks_003Em__2;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source2 = source.Select(ABLHFBEBGCP);
			if (JCBAILFEDOG == null)
			{
				JCBAILFEDOG = _003CFindCallbacks_003Em__3;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source3 = source2.Where(JCBAILFEDOG);
			if (JOIJJNOBGHB == null)
			{
				JOIJJNOBGHB = _003CFindCallbacks_003Em__4;
			}
			FGAEHOGEPIK = source3.Select(JOIJJNOBGHB);
		}
	}

	public static void __BB_OBFUSCATOR_25()
	{
		if (FGAEHOGEPIK == null)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = _003CFindCallbacks_003Em__0;
			}
			Func<Assembly, IEnumerable<Type>> nCBIMIMMADO = NCBIMIMMADO;
			if (ENPJJJBJGNE == null)
			{
				ENPJJJBJGNE = __BB_OBFUSCATOR_6;
			}
			IEnumerable<global::CPHLGNDILFM<Assembly, Type>> source = assemblies.SelectMany(nCBIMIMMADO, ENPJJJBJGNE);
			if (ABLHFBEBGCP == null)
			{
				ABLHFBEBGCP = _003CFindCallbacks_003Em__2;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source2 = source.Select(ABLHFBEBGCP);
			if (JCBAILFEDOG == null)
			{
				JCBAILFEDOG = _003CFindCallbacks_003Em__3;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source3 = source2.Where(JCBAILFEDOG);
			if (JOIJJNOBGHB == null)
			{
				JOIJJNOBGHB = __BB_OBFUSCATOR_4;
			}
			FGAEHOGEPIK = source3.Select(JOIJJNOBGHB);
		}
	}

	public static void InvokeCallbacks(string JHNPKJMLLEI)
	{
		FindCallbacks();
		IEnumerator enumerator = FGAEHOGEPIK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo method = type.GetMethod(JHNPKJMLLEI);
				if (method != null)
				{
					try
					{
						method.Invoke(type, null);
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
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
	}

	[CompilerGenerated]
	private static bool _003CFindCallbacks_003Em__3(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.BKIPJACEDHN != null && OCICHPKJHLM.BKIPJACEDHN.Length > 0;
	}

	public static void __BB_OBFUSCATOR_7()
	{
		if (FGAEHOGEPIK == null)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = _003CFindCallbacks_003Em__0;
			}
			Func<Assembly, IEnumerable<Type>> nCBIMIMMADO = NCBIMIMMADO;
			if (ENPJJJBJGNE == null)
			{
				ENPJJJBJGNE = _003CFindCallbacks_003Em__1;
			}
			IEnumerable<global::CPHLGNDILFM<Assembly, Type>> source = assemblies.SelectMany(nCBIMIMMADO, ENPJJJBJGNE);
			if (ABLHFBEBGCP == null)
			{
				ABLHFBEBGCP = __BB_OBFUSCATOR_16;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source2 = source.Select(ABLHFBEBGCP);
			if (JCBAILFEDOG == null)
			{
				JCBAILFEDOG = __BB_OBFUSCATOR_24;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source3 = source2.Where(JCBAILFEDOG);
			if (JOIJJNOBGHB == null)
			{
				JOIJJNOBGHB = __BB_OBFUSCATOR_10;
			}
			FGAEHOGEPIK = source3.Select(JOIJJNOBGHB);
		}
	}

	public static void __BB_OBFUSCATOR_22(string JHNPKJMLLEI)
	{
		__BB_OBFUSCATOR_3();
		IEnumerator enumerator = FGAEHOGEPIK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo method = type.GetMethod(JHNPKJMLLEI);
				if (method != null)
				{
					try
					{
						method.Invoke(type, null);
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
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
	}

	[CompilerGenerated]
	private static global::CPHLGNDILFM<Assembly, Type> _003CFindCallbacks_003Em__1(Assembly IENMFMEGJAB, Type MDNAJENEMNA)
	{
		return new global::CPHLGNDILFM<Assembly, Type>(IENMFMEGJAB, MDNAJENEMNA);
	}

	private static Type __BB_OBFUSCATOR_26(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.HJDGPFHIGEG.MDNAJENEMNA;
	}

	private static Type __BB_OBFUSCATOR_15(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.HJDGPFHIGEG.MDNAJENEMNA;
	}

	private static global::CPHLGNDILFM<Assembly, Type> __BB_OBFUSCATOR_17(Assembly IENMFMEGJAB, Type MDNAJENEMNA)
	{
		return new global::CPHLGNDILFM<Assembly, Type>(IENMFMEGJAB, MDNAJENEMNA);
	}

	private static Type __BB_OBFUSCATOR_10(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.HJDGPFHIGEG.MDNAJENEMNA;
	}

	public static void __BB_OBFUSCATOR_2(string JHNPKJMLLEI)
	{
		__BB_OBFUSCATOR_3();
		IEnumerator enumerator = FGAEHOGEPIK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Type type = (Type)enumerator.Current;
				MethodInfo method = type.GetMethod(JHNPKJMLLEI);
				if (method != null)
				{
					try
					{
						method.Invoke(type, null);
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
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
	}

	[CompilerGenerated]
	private static Type _003CFindCallbacks_003Em__4(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.HJDGPFHIGEG.MDNAJENEMNA;
	}

	public static void __BB_OBFUSCATOR_3()
	{
		if (FGAEHOGEPIK == null)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (NCBIMIMMADO == null)
			{
				NCBIMIMMADO = __BB_OBFUSCATOR_14;
			}
			Func<Assembly, IEnumerable<Type>> nCBIMIMMADO = NCBIMIMMADO;
			if (ENPJJJBJGNE == null)
			{
				ENPJJJBJGNE = __BB_OBFUSCATOR_17;
			}
			IEnumerable<global::CPHLGNDILFM<Assembly, Type>> source = assemblies.SelectMany(nCBIMIMMADO, ENPJJJBJGNE);
			if (ABLHFBEBGCP == null)
			{
				ABLHFBEBGCP = _003CFindCallbacks_003Em__2;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source2 = source.Select(ABLHFBEBGCP);
			if (JCBAILFEDOG == null)
			{
				JCBAILFEDOG = _003CFindCallbacks_003Em__3;
			}
			IEnumerable<global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>> source3 = source2.Where(JCBAILFEDOG);
			if (JOIJJNOBGHB == null)
			{
				JOIJJNOBGHB = __BB_OBFUSCATOR_4;
			}
			FGAEHOGEPIK = source3.Select(JOIJJNOBGHB);
		}
	}

	private static global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> __BB_OBFUSCATOR_16(global::CPHLGNDILFM<Assembly, Type> HJDGPFHIGEG)
	{
		return new global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>(HJDGPFHIGEG, HJDGPFHIGEG.MDNAJENEMNA.GetCustomAttributes(typeof(EFJOCMFBIEG), false));
	}

	private static Type __BB_OBFUSCATOR_4(global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> OCICHPKJHLM)
	{
		return OCICHPKJHLM.HJDGPFHIGEG.MDNAJENEMNA;
	}

	[CompilerGenerated]
	private static global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]> _003CFindCallbacks_003Em__2(global::CPHLGNDILFM<Assembly, Type> HJDGPFHIGEG)
	{
		return new global::MPGGCBLKBHA<global::CPHLGNDILFM<Assembly, Type>, object[]>(HJDGPFHIGEG, HJDGPFHIGEG.MDNAJENEMNA.GetCustomAttributes(typeof(EFJOCMFBIEG), true));
	}
}
