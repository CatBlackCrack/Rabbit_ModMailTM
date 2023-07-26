using System;
using System.Runtime.InteropServices;

namespace ns6
{
	internal class Class72
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0);
	}
}
