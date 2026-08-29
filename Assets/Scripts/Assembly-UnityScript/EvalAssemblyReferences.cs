using System;
using System.Reflection;
using CodeStage.AntiCheat.Examples;
using UnityEngine;
using UnityScript;

[Serializable]
internal class EvalAssemblyReferences
{
	[NonSerialized]
	public static readonly Assembly[] Value = new Assembly[5]
	{
		Assembly.GetExecutingAssembly(),
		typeof(object).Assembly,
		typeof(AndroidJavaObject).Assembly,
		typeof(UnityScriptCompiler).Assembly,
		typeof(ActRotatorExample).Assembly
	};
}
