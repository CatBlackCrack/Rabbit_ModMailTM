using System;
using System.Runtime.InteropServices;

namespace ns3
{
	internal class Class77
	{
		public const int int_0 = 13369376;

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr intptr_0, int int_1, int int_2, int int_3, int int_4, IntPtr intptr_1, int int_5, int int_6, int int_7);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_1, int int_2);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr intptr_0);

		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);
	}
}
