using System;
using System.Runtime.InteropServices;

namespace XInputDotNetPure
{
	internal class GIFFOGDIKPJ
	{
		public static void __BB_OBFUSCATOR_35(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB)
		{
			if (IntPtr.Size == 7)
			{
				XInputGamePadSetState32(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
			else
			{
				XInputGamePadSetState64(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
		}

		[DllImport("XInputInterface32", EntryPoint = "XInputGamePadSetState")]
		public static extern void XInputGamePadSetState32(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB);

		public static uint __BB_OBFUSCATOR_19(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 1)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}

		public static void XInputGamePadSetState(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB)
		{
			if (IntPtr.Size == 4)
			{
				XInputGamePadSetState32(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
			else
			{
				XInputGamePadSetState64(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
		}

		public static void __BB_OBFUSCATOR_39(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB)
		{
			if (IntPtr.Size == 5)
			{
				XInputGamePadSetState32(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
			else
			{
				XInputGamePadSetState64(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
		}

		public static uint __BB_OBFUSCATOR_15(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 1)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}

		public static uint __BB_OBFUSCATOR_29(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 0)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}

		[DllImport("XInputInterface64", EntryPoint = "XInputGamePadSetState")]
		public static extern void XInputGamePadSetState64(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB);

		public static uint XInputGamePadGetState(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 4)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}

		public static void __BB_OBFUSCATOR_38(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB)
		{
			if (IntPtr.Size == 4)
			{
				XInputGamePadSetState32(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
			else
			{
				XInputGamePadSetState64(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
		}

		[DllImport("XInputInterface32", EntryPoint = "XInputGamePadGetState")]
		public static extern uint XInputGamePadGetState32(uint PCDPELOLACP, IntPtr DBEBHBIEJFO);

		public static uint __BB_OBFUSCATOR_8(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 7)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}

		[DllImport("XInputInterface64", EntryPoint = "XInputGamePadGetState")]
		public static extern uint XInputGamePadGetState64(uint PCDPELOLACP, IntPtr DBEBHBIEJFO);

		public static void __BB_OBFUSCATOR_6(uint PCDPELOLACP, float OBHBMAIFHBD, float EGNBGABPIHB)
		{
			if (IntPtr.Size == 3)
			{
				XInputGamePadSetState32(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
			else
			{
				XInputGamePadSetState64(PCDPELOLACP, OBHBMAIFHBD, EGNBGABPIHB);
			}
		}

		public static uint __BB_OBFUSCATOR_31(uint PCDPELOLACP, IntPtr DBEBHBIEJFO)
		{
			if (IntPtr.Size == 5)
			{
				return XInputGamePadGetState32(PCDPELOLACP, DBEBHBIEJFO);
			}
			return XInputGamePadGetState64(PCDPELOLACP, DBEBHBIEJFO);
		}
	}
}
