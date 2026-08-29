using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Mono.CompilerServices.SymbolWriter
{
	internal class MonoDebuggerSupport
	{
		private delegate int GetMethodTokenFunc(MethodBase method);

		private delegate Guid GetGuidFunc(Module module);

		private delegate int GetLocalIndexFunc(LocalBuilder local);

		private static GetMethodTokenFunc get_method_token;

		private static GetGuidFunc get_guid;

		private static GetLocalIndexFunc get_local_index;

		static MonoDebuggerSupport()
		{
			get_method_token = (GetMethodTokenFunc)create_delegate(typeof(Assembly), typeof(GetMethodTokenFunc), "MonoDebugger_GetMethodToken");
			get_guid = (GetGuidFunc)create_delegate(typeof(Module), typeof(GetGuidFunc), "Mono_GetGuid");
			get_local_index = (GetLocalIndexFunc)create_delegate(typeof(LocalBuilder), typeof(GetLocalIndexFunc), "Mono_GetLocalIndex");
		}

		private static Delegate create_delegate(Type type, Type delegate_type, string name)
		{
			MethodInfo method = type.GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new Exception("Can't find " + name);
			}
			return Delegate.CreateDelegate(delegate_type, method);
		}

		public static int GetMethodToken(MethodBase method)
		{
			return get_method_token(method);
		}

		public static Guid GetGuid(Module module)
		{
			return get_guid(module);
		}

		public static int GetLocalIndex(LocalBuilder local)
		{
			return get_local_index(local);
		}
	}
}
