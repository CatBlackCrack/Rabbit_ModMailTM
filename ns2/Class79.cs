using System;
using System.Runtime.InteropServices;

namespace ns2
{
	internal class Class79
	{
		public struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;
		}

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr intptr_0);

		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr intptr_0, ref Struct0 struct0_0);
	}
}
