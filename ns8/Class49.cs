using System.Runtime.InteropServices;

namespace ns8
{
	internal class Class49
	{
		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(out int int_0, int int_1);

		public static bool smethod_0()
		{
			int int_;
			return InternetGetConnectedState(out int_, 0);
		}
	}
}
