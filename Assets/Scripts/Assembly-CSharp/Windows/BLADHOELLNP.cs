using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace Windows
{
	public class BLADHOELLNP
	{
		private TextWriter PMCGJFDGNBI;

		private const int FGKGIHEPIPK = -11;

		public void __BB_OBFUSCATOR_21()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(-56);
				FileStream stream = new FileStream(stdHandle, FileAccess.ReadWrite);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = true;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("_Overlay" + ex.Message);
			}
		}

		[DllImport("kernel32.dll")]
		private static extern bool SetConsoleTitle(string MHMPFFFLHND);

		public void __BB_OBFUSCATOR_25(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void __BB_OBFUSCATOR_32()
		{
			Console.SetOut(PMCGJFDGNBI);
			FreeConsole();
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool FreeConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool AllocConsole();

		public void __BB_OBFUSCATOR_2(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void __BB_OBFUSCATOR_30()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(-86);
				FileStream stream = new FileStream(stdHandle, (FileAccess)0);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = false;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("TDM" + ex.Message);
			}
		}

		public void __BB_OBFUSCATOR_24()
		{
			Console.SetOut(PMCGJFDGNBI);
			FreeConsole();
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool AttachConsole(uint GLHPKFPGIIF);

		public void Shutdown()
		{
			Console.SetOut(PMCGJFDGNBI);
			FreeConsole();
		}

		public void __BB_OBFUSCATOR_31()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(-26);
				FileStream stream = new FileStream(stdHandle, FileAccess.Read);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = true;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("_Distortion" + ex.Message);
			}
		}

		public void __BB_OBFUSCATOR_4(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void __BB_OBFUSCATOR_5(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void __BB_OBFUSCATOR_28()
		{
			Console.SetOut(PMCGJFDGNBI);
			FreeConsole();
		}

		public void __BB_OBFUSCATOR_12()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(118);
				FileStream stream = new FileStream(stdHandle, (FileAccess)8);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = false;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("Purchase/Text" + ex.Message);
			}
		}

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetStdHandle(int NEAGBNBAACO);

		public void __BB_OBFUSCATOR_7()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(34);
				FileStream stream = new FileStream(stdHandle, FileAccess.Write);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = true;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("_NoiseTex" + ex.Message);
			}
		}

		public void __BB_OBFUSCATOR_14(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void Initialize()
		{
			if (!AttachConsole(uint.MaxValue))
			{
				AllocConsole();
			}
			PMCGJFDGNBI = Console.Out;
			try
			{
				IntPtr stdHandle = GetStdHandle(-11);
				FileStream stream = new FileStream(stdHandle, FileAccess.Write);
				Encoding aSCII = Encoding.ASCII;
				StreamWriter streamWriter = new StreamWriter(stream, aSCII);
				streamWriter.AutoFlush = true;
				Console.SetOut(streamWriter);
			}
			catch (Exception ex)
			{
				Debug.Log("Couldn't redirect output: " + ex.Message);
			}
		}

		public void __BB_OBFUSCATOR_23(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void SetTitle(string GBKGGNGJMHA)
		{
			SetConsoleTitle(GBKGGNGJMHA);
		}

		public void __BB_OBFUSCATOR_34()
		{
			Console.SetOut(PMCGJFDGNBI);
			FreeConsole();
		}
	}
}
