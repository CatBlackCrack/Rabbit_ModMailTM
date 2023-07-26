using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using ns4;

namespace ns5
{
	internal class Class2
	{
		[CompilerGenerated]
		private sealed class Class3
		{
			public StringBuilder stringBuilder_0;

			internal void method_0(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					stringBuilder_0.Append(e.Data + "\n");
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public List<string> list_0;

			internal bool method_0(string string_0)
			{
				return list_0.Contains(string_0);
			}
		}

		public static string smethod_0(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_26, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_1(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_7, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_2(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_9, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_3(string string_0, string string_1)
		{
			string result = "";
			try
			{
				string fileName = Path.GetFileName(string_1);
				smethod_16(string_0, "/sdcard/" + fileName);
				smethod_15(string_0, "/sdcard/" + fileName, string_1);
				smethod_8(string_0, "/sdcard/" + fileName);
			}
			catch
			{
			}
			return result;
		}

		public static string smethod_4(string string_0, string string_1, string string_2)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_10, string_1, string_2), 60);
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_5(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_16, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_6(string string_0)
		{
			try
			{
				smethod_7(string_0, ":0");
				smethod_23(string_0, Class1.string_3);
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_7(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_2, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_8(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_12, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_9(string string_0)
		{
			try
			{
				return smethod_23(string_0, Class1.string_23);
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_10(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_27, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_11(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_13, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_12(string string_0, int int_0, int int_1, int int_2, int int_3, int int_4 = 100)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_19, int_0, int_1, int_2, int_3, int_4));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_13(string string_0, List<string> list_0)
		{
			try
			{
				string text = "com.android.inputmethod.pinyin";
				if (list_0.Count > 0 && !list_0.Contains(text))
				{
					text = "com.android.emu.inputservice";
				}
				return smethod_23(string_0, "shell ime set " + text + "/.InputService");
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_14(string string_0, string string_1)
		{
			try
			{
				string_1 = string_1.Replace(" ", "%s").Replace("&", "\\&").Replace("<", "\\<")
					.Replace(">", "\\>")
					.Replace("?", "\\?")
					.Replace(":", "\\:")
					.Replace("{", "\\{")
					.Replace("}", "\\}")
					.Replace("[", "\\[")
					.Replace("]", "\\]")
					.Replace("|", "\\|");
				return smethod_23(string_0, string.Format(Class1.string_21, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_15(string string_0, string string_1, string string_2)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_11, string_1, string_2));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_16(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_8, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_17(string string_0, int int_0, int int_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_22, int_0, int_1));
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_18(string string_0)
		{
			string text = "";
			try
			{
				for (int i = 0; i < 3; i++)
				{
					text = smethod_23(string_0, "adb shell uiautomator dump && adb shell cat /sdcard/window_dump.xml && adb shell rm /sdcard/window_dump.xml").ToLower();
					if (!(text.Trim() != "ui hierchary dumped to: /sdcard/window_dump.xml") || !(text.Trim() != ""))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			return Regex.Match(text, "<\\?xml(.*?)</hierarchy>").Value;
		}

		public static string smethod_19(string string_0)
		{
			try
			{
				return smethod_23(string_0, Class1.string_25);
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_20(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_15, string_1));
			}
			catch
			{
			}
			return "";
		}

		public static void smethod_21(string string_0, int int_0)
		{
			try
			{
				smethod_34(string_0 + "\\dnconsole.exe quit --index " + int_0);
			}
			catch
			{
			}
		}

		public static void smethod_22(string string_0, int int_0)
		{
			try
			{
				smethod_34(string_0 + "\\dnconsole.exe reboot --index " + int_0);
			}
			catch
			{
			}
		}

		public static string smethod_23(string string_0, string string_1, int int_0 = 10)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				string newValue = "adb -s " + string_0;
				string_1 = (string_1.StartsWith("adb") ? string_1.Replace("adb", newValue) : ("adb -s " + string_0 + " " + string_1));
			}
			return smethod_34(string_1, int_0);
		}

		public static string smethod_24(string string_0, int int_0 = 0, bool bool_0 = true, string string_1 = "")
		{
			string result = "";
			try
			{
				string text = string_1 + "\\ldconsole.exe";
				if (text.Length < 1)
				{
					return "";
				}
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					FileName = text,
					Arguments = string_0,
					CreateNoWindow = true,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden,
					RedirectStandardInput = true,
					RedirectStandardOutput = true
				};
				process.Start();
				if (int_0 == 0)
				{
					process.WaitForExit();
				}
				else if (!process.WaitForExit(int_0))
				{
					process.Kill();
					return "";
				}
				if (bool_0)
				{
					result = process.StandardOutput.ReadToEnd();
				}
				process.Close();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static string smethod_25(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_28, string_1), 60);
			}
			catch
			{
			}
			return "";
		}

		public static string smethod_26(string string_0, string string_1)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_29, string_1), 60);
			}
			catch
			{
			}
			return "";
		}

		public static List<string> smethod_27(string string_0)
		{
			List<string> result = new List<string>();
			try
			{
				string text = smethod_23(string_0, Class1.string_30).Replace("package:", "").Trim();
				if (text != "")
				{
					result = text.Split('\n').ToList();
				}
			}
			catch
			{
			}
			return result;
		}

		public static string smethod_28(string string_0, int int_0, int int_1, int int_2 = 100)
		{
			try
			{
				return smethod_23(string_0, string.Format(Class1.string_19, int_0, int_1, int_0, int_1, int_2));
			}
			catch
			{
			}
			return "";
		}

		public static void smethod_29(string string_0)
		{
			try
			{
				smethod_34(string_0 + "\\dnconsole.exe add", 30);
			}
			catch
			{
			}
		}

		public static void smethod_30(string string_0, int int_0)
		{
			try
			{
				smethod_34(string_0 + "\\dnconsole.exe launch --index " + int_0);
			}
			catch
			{
			}
		}

		public static List<string> smethod_31(string string_0)
		{
			List<string> list = new List<string>();
			try
			{
				string text = smethod_34(string_0 + "\\dnconsole.exe list2");
				if (text.Trim() != "")
				{
					List<string> list2 = text.Trim().Split('\n').ToList();
					for (int i = 0; i < list2.Count; i++)
					{
						list.Add(list2[i].Split(',')[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return list;
		}

		public static List<string> smethod_32()
		{
			List<string> list = new List<string>();
			string text = smethod_34("adb devices");
			string[] array = text.Replace("List of devices attached", "").Trim().Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].Contains("offline") && array[i].Contains("device"))
				{
					list.Add(array[i].Trim().Split('\t')[0]);
				}
			}
			return list;
		}

		public static void smethod_33(string string_0)
		{
			try
			{
				smethod_34("adb disconnect " + string_0);
			}
			catch
			{
			}
		}

		public static string smethod_34(string string_0, int int_0 = 10)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + string_0;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
			process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
			StringBuilder stringBuilder_0 = new StringBuilder();
			process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					stringBuilder_0.Append(e.Data + "\n");
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			if (int_0 < 0)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(int_0 * 1000);
			}
			process.Close();
			return stringBuilder_0.ToString();
		}

		public static void smethod_35(string string_0)
		{
			try
			{
				smethod_34("adb connect " + string_0);
			}
			catch
			{
			}
		}

		public static string smethod_36(int int_0)
		{
			string text = "";
			try
			{
				List<string> source = smethod_32();
				List<string> list_0 = new List<string>
				{
					"127.0.0.1:" + (int_0 * 2 + 5555),
					"emulator-" + (int_0 * 2 + 5554)
				};
				text = source.Where((string string_0) => list_0.Contains(string_0)).FirstOrDefault();
				if (string.IsNullOrEmpty(text))
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						smethod_33(list_0[i]);
					}
					smethod_35(list_0[0]);
				}
			}
			catch
			{
			}
			return text;
		}
	}
}
