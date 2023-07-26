using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ns7
{
	internal class Class48
	{
		private string string_0;

		private string string_1 = Assembly.GetExecutingAssembly().GetName().Name;

		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string string_2, string string_3, string string_4, string string_5);

		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string string_2, string string_3, string string_4, StringBuilder stringBuilder_0, int int_0, string string_5);

		[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode)]
		private static extern uint GetPrivateProfileStringW(string string_2, string string_3, string string_4, byte[] byte_0, uint uint_0, string string_5);

		public Class48(string string_2 = null)
		{
			string_0 = new FileInfo(string_2 ?? (string_1 + ".ini")).FullName.ToString();
		}

		public string method_0(string string_2, string string_3 = null)
		{
			byte[] array = new byte[1024];
			uint privateProfileStringW = GetPrivateProfileStringW(string_3 ?? string_1, string_2, "", array, (uint)array.Length, string_0);
			return Encoding.Unicode.GetString(array, 0, (int)(privateProfileStringW * 2));
		}

		public string method_1(string string_2, string string_3 = null)
		{
			StringBuilder stringBuilder = new StringBuilder(5000);
			GetPrivateProfileString(string_3 ?? string_1, string_2, "", stringBuilder, 5000, string_0);
			return stringBuilder.ToString();
		}

		public void method_2(string string_2, string string_3, string string_4 = null)
		{
			WritePrivateProfileString(string_4 ?? string_1, string_2, string_3, string_0);
		}

		public void method_3(string string_2, string string_3 = null)
		{
			method_2(string_2, null, string_3 ?? string_1);
		}

		public void method_4(string string_2 = null)
		{
			method_2(null, null, string_2 ?? string_1);
		}

		public bool method_5(string string_2, string string_3 = null)
		{
			return method_1(string_2, string_3).Length > 0;
		}
	}
}
