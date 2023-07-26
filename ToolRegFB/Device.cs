using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ns0;
using ns2;
using ns4;
using ns5;
using ToolRegFB.Properties;

namespace ToolRegFB
{
	internal class Device
	{
		public enum KeyEvent
		{
			KEYCODE_0 = 0,
			KEYCODE_SOFT_LEFT = 1,
			KEYCODE_SOFT_RIGHT = 2,
			KEYCODE_HOME = 3,
			KEYCODE_BACK = 4,
			KEYCODE_CALL = 5,
			KEYCODE_ENDCALL = 6,
			KEYCODE_0_ = 7,
			KEYCODE_1 = 8,
			KEYCODE_2 = 9,
			KEYCODE_3 = 10,
			KEYCODE_4 = 11,
			KEYCODE_5 = 12,
			KEYCODE_6 = 13,
			KEYCODE_7 = 14,
			KEYCODE_8 = 0xF,
			KEYCODE_9 = 0x10,
			KEYCODE_STAR = 17,
			KEYCODE_POUND = 18,
			KEYCODE_DPAD_UP = 19,
			KEYCODE_DPAD_DOWN = 20,
			KEYCODE_DPAD_LEFT = 21,
			KEYCODE_DPAD_RIGHT = 22,
			KEYCODE_DPAD_CENTER = 23,
			KEYCODE_VOLUME_UP = 24,
			KEYCODE_VOLUME_DOWN = 25,
			KEYCODE_POWER = 26,
			KEYCODE_CAMERA = 27,
			KEYCODE_CLEAR = 28,
			KEYCODE_A = 29,
			KEYCODE_B = 30,
			KEYCODE_C = 0x1F,
			KEYCODE_D = 0x20,
			KEYCODE_E = 33,
			KEYCODE_F = 34,
			KEYCODE_G = 35,
			KEYCODE_H = 36,
			KEYCODE_I = 37,
			KEYCODE_J = 38,
			KEYCODE_K = 39,
			KEYCODE_L = 40,
			KEYCODE_M = 41,
			KEYCODE_N = 42,
			KEYCODE_O = 43,
			KEYCODE_P = 44,
			KEYCODE_Q = 45,
			KEYCODE_R = 46,
			KEYCODE_S = 47,
			KEYCODE_T = 48,
			KEYCODE_U = 49,
			KEYCODE_V = 50,
			KEYCODE_W = 51,
			KEYCODE_X = 52,
			KEYCODE_Y = 53,
			KEYCODE_Z = 54,
			KEYCODE_COMMA = 55,
			KEYCODE_PERIOD = 56,
			KEYCODE_ALT_LEFT = 57,
			KEYCODE_ALT_RIGHT = 58,
			KEYCODE_SHIFT_LEFT = 59,
			KEYCODE_SHIFT_RIGHT = 60,
			KEYCODE_TAB = 61,
			KEYCODE_SPACE = 62,
			KEYCODE_SYM = 0x3F,
			KEYCODE_EXPLORER = 0x40,
			KEYCODE_ENVELOPE = 65,
			KEYCODE_ENTER = 66,
			KEYCODE_DEL = 67,
			KEYCODE_GRAVE = 68,
			KEYCODE_MINUS = 69,
			KEYCODE_EQUALS = 70,
			KEYCODE_LEFT_BRACKET = 71,
			KEYCODE_RIGHT_BRACKET = 72,
			KEYCODE_BACKSLASH = 73,
			KEYCODE_SEMICOLON = 74,
			KEYCODE_APOSTROPHE = 75,
			KEYCODE_SLASH = 76,
			KEYCODE_AT = 77,
			KEYCODE_NUM = 78,
			KEYCODE_HEADSETHOOK = 79,
			KEYCODE_FOCUS = 80,
			KEYCODE_PLUS = 81,
			KEYCODE_MENU = 82,
			KEYCODE_NOTIFICATION = 83,
			KEYCODE_APP_SWITCH = 187
		}

		[CompilerGenerated]
		private sealed class Class24
		{
			public List<string> list_0;

			internal bool method_0(string string_0)
			{
				return list_0.Contains(string_0);
			}
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Process process_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Random random_0;

		public int int_0 = -1;

		public List<string> list_0 = new List<string>();

		private string string_3 = "fb://profile";

		private string string_4 = "fb://feed";

		private string string_5 = "fb://notifications";

		private string string_6 = "fb://watch";

		private string string_7 = "fb://language_switch";

		private string string_8 = "fb://security_settings";

		private string string_9 = "fb://faceweb/f?href=/settings/email";

		private int int_1 = 0;

		public int int_2 = 0;

		public int int_3 = 3;

		private string string_10 = "fblite://feed";

		private string string_11 = "fblite://profile/";

		public string DeviceId
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string PathLDPlayer
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public string LinkAvartar
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
			[CompilerGenerated]
			set
			{
				string_2 = value;
			}
		}

		public Process process
		{
			[CompilerGenerated]
			get
			{
				return process_0;
			}
			[CompilerGenerated]
			set
			{
				process_0 = value;
			}
		}

		private Random rd
		{
			[CompilerGenerated]
			get
			{
				return random_0;
			}
			[CompilerGenerated]
			set
			{
				random_0 = value;
			}
		}

		public Device(string pathLDPlayer, string indexDevice, string linkAvartar)
		{
			int_0 = Convert.ToInt32(indexDevice);
			PathLDPlayer = pathLDPlayer;
			LinkAvartar = linkAvartar;
			rd = new Random();
		}

		public void method_0()
		{
		}

		public string method_1(string string_12)
		{
			return Class2.smethod_2(DeviceId, string_12);
		}

		public string method_2()
		{
			return Class2.smethod_1(DeviceId, "https://api64.ipify.org/").Trim();
		}

		public bool method_3(string string_12, Bitmap bitmap_0 = null, int int_4 = 0)
		{
			try
			{
				method_130("Find Img: " + string_12.Substring(string_12.LastIndexOf('\\') + 1));
				string text = method_42(string_12, bitmap_0, int_4);
				if (text != "")
				{
					method_130("Click Img: " + string_12.Substring(string_12.LastIndexOf('\\') + 1));
					return method_89(text);
				}
			}
			catch
			{
			}
			return false;
		}

		public bool method_4(string string_12)
		{
			if (!method_129())
			{
				return false;
			}
			bool result = false;
			if (!string.IsNullOrEmpty(string_12.Trim()))
			{
				switch (string_12.Split(':').Count())
				{
					case 2:
						method_5(string_12);
						result = true;
						break;
				}
			}
			return result;
		}

		private string method_5(string string_12)
		{
			return Class2.smethod_7(DeviceId, string_12);
		}

		public void method_6()
		{
			if (method_129())
			{
				Class2.smethod_6(DeviceId);
			}
		}

		public bool method_7(int int_4, int int_5)
		{
			if (method_92("[0,0][320,480]", int_4, int_5))
			{
				method_85($"shell \"input tap {int_4} {int_5} & sleep 0.1; input tap {int_4} {int_5}\"");
				return true;
			}
			return false;
		}

		public bool method_8(int int_4, string string_12, string[] string_13)
		{
			bool result = false;
			int num = 0;
			while (true)
			{
				if (num < int_4)
				{
					string text = method_93();
					List<string> list = new List<string> { string_12 };
					list.AddRange(string_13);
					int num2 = method_84(text, 0.0, list.ToArray());
					if (num2 != 0)
					{
						method_99(list[num2 - 1], text);
					}
					if (num2 == 1)
					{
						break;
					}
					method_121(1.0);
					num++;
					continue;
				}
				return result;
			}
			result = true;
			return true;
		}

		public bool method_9()
		{
			method_124();
			int num = 1;
			while (true)
			{
				bool flag = method_3("DataClick\\image\\menu", null, 5);
				while (true)
				{
					num++;
					if (flag)
					{
						switch (num)
						{
							case 2:
								flag = method_3("DataClick\\image\\banbe", null, 5);
								continue;
							case 3:
								{
									int num2 = method_84("", 5.0, "\"suggestions\"", "as a friend\"");
									int num3 = num2;
									int num4 = num3;
									flag = ((num4 == 1) ? method_99("\"suggestions\"") : (num4 == 2));
									continue;
								}
							case 1:
								break;
							default:
								return flag;
						}
						break;
					}
					return flag;
				}
			}
		}

		public bool method_10(int int_4 = 1)
		{
			try
			{
				List<string> list = new List<string> { "like", "love", "haha", "wow", "sad", "angry" };
				if (int_4 == 6)
				{
					int_4 = method_15(0, 4);
				}
				method_3("DataClick\\image\\reaction\\" + list[int_4]);
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		public bool method_11(int int_4 = 60)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < int_4; i++)
				{
					if (!method_129())
					{
						break;
					}
					List<string> source = Class2.smethod_32();
					List<string> list_0 = new List<string>
					{
						"127.0.0.1:" + (int_0 * 2 + 5555),
						"emulator-" + (int_0 * 2 + 5554)
					};
					list = source.Where((string string_0) => list_0.Contains(string_0)).ToList();
					if (list.Count > 0)
					{
						DeviceId = list[0];
						for (int j = 0; j < 60; j++)
						{
							if (method_129())
							{
								string text = method_87();
								if (!(text == "com.android.launcher3/com.android.launcher3.Launcher") && !(text != ""))
								{
									Thread.Sleep(1000);
									continue;
								}
								return true;
							}
							return false;
						}
					}
					if (i == 30)
					{
						for (int k = 0; k < list_0.Count; k++)
						{
							Class2.smethod_33(list_0[k]);
						}
						Class2.smethod_35(list_0[0]);
					}
					method_121(1.0);
				}
			}
			catch
			{
			}
			return false;
		}

		public void method_12(string string_12 = "")
		{
			method_85(string.Format(Class1.string_0, string_3 + ((string_12 == "") ? "" : ("/" + string_12)), "com.facebook.katana"));
		}

		public string method_13()
		{
			string text = "";
			string text2 = "";
			try
			{
				string input = method_25("data/data/com.facebook.katana/app_light_prefs/com.facebook.katana/authentication");
				text = Regex.Match(input, "EAAAAU\\S+").Value;
				string value = Regex.Match(text, "\u0005(.*?)$").Value;
				text = text.Replace(value, "");
				string json = "{\"data\": [" + Regex.Match(input, "\\[(.*?)\\]").Groups[1].Value + "]}";
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					text2 = text2 + jObject["data"]![i]!["name"]!.ToString() + "=" + jObject["data"]![i]!["value"]!.ToString() + ";";
				}
			}
			catch
			{
			}
			return text + "|" + text2;
		}

		public string method_14(string string_12)
		{
			string result = "";
			for (int i = 0; i < 3; i++)
			{
				try
				{
					File.Delete("dump\\cookie_" + string_12 + ".txt");
				}
				catch
				{
				}
				try
				{
					method_46("pull /data/data/com.facebook.lite/files/PropertiesStore_v02 " + Directory.GetCurrentDirectory() + "\\dump\\cookie_" + string_12 + ".txt");
					if (!File.Exists("dump\\cookie_" + string_12 + ".txt"))
					{
						return "";
					}
					string text = File.ReadAllText("dump\\cookie_" + string_12 + ".txt");
					if (text.Length <= 0)
					{
						continue;
					}
					string text2 = "";
					string text3 = "";
					int num = -1;
					string text4 = "EAA";
					string value = "ZD";
					int num2 = text.IndexOf("EAA");
					if (num2 != -1)
					{
						num2 += text4.Length;
						int num3 = text.IndexOf(value, num2);
						if (num3 > num2)
						{
							string text5 = text.Substring(num2, num3 - num2);
							text2 = "EAA" + text5 + "ZD";
						}
					}
					text4 = "[{";
					value = "}]";
					num2 = text.IndexOf("[{");
					if (num2 != num)
					{
						num2 += text4.Length;
						int num4 = text.IndexOf(value, num2);
						if (num4 > num2)
						{
							string text6 = text.Substring(num2, num4 - num2);
							text6 = "[{" + text6 + "}]";
							object obj2 = JsonConvert.DeserializeObject(text6);
							string[] array = (from object object_0 in (IEnumerable)obj2
											  select object_0.ToString()).ToArray();
							foreach (object obj3 in array)
							{
								if (text3 != "")
								{
									text3 += ";";
								}
								JObject jObject = JObject.Parse(obj3.ToString());
								string text7 = jObject["name"]!.ToString();
								string text8 = jObject["value"]!.ToString();
								text3 = text3 + text7 + "=" + text8;
							}
							text3 += ";";
						}
					}
					string input = Regex.Match(text3, "(c_user=)[0-9]{0,}").ToString();
					string text9 = Regex.Match(input, "[0-9]{0,}$").ToString();
					result = text9 + "|" + text3 + "|" + text2;
					return result;
				}
				catch
				{
					method_121(2.0);
				}
			}
			return result;
		}

		public int method_15(int int_4, int int_5)
		{
			try
			{
				return rd.Next(int_4, int_5 + 1);
			}
			catch
			{
				return (int_4 + int_5) / 2;
			}
		}

		private List<string> method_16(List<string> list_1)
		{
			Random random = new Random();
			List<string> list = new List<string>();
			try
			{
				list_1 = Common.smethod_77(list_1);
				string text = "BEGIN:VCARD" + Environment.NewLine + "VERSION:3.0" + Environment.NewLine + "N:{{fname}};;;" + Environment.NewLine + "FN:{{lname}}" + Environment.NewLine + "TEL;TYPE=CELL;TYPE=PREF:{{phone}}" + Environment.NewLine + "END:VCARD";
				for (int i = 0; i < list_1.Count; i++)
				{
					string newValue = list_1[i];
					string newValue2 = Class60.string_0[random.Next(0, Class60.string_0.Length)];
					string newValue3 = Class60.string_1[random.Next(0, Class60.string_1.Length)];
					string text2 = text;
					text2 = text2.Replace("{{fname}}", newValue2);
					text2 = text2.Replace("{{lname}}", newValue3);
					text2 = text2.Replace("{{phone}}", newValue);
					list.Add(text2);
				}
			}
			catch
			{
			}
			return list;
		}

		public bool method_17(string string_12)
		{
			try
			{
				method_85(string.Format(Class1.string_1, string_12), 3);
				return true;
			}
			catch
			{
			}
			return false;
		}

		public bool method_18(string string_12, string string_13)
		{
			string[] array = string_13.Split('[', ',', ']');
			return method_92(string_12, Convert.ToInt32(array[1]), Convert.ToInt32(array[2])) && method_92(string_12, Convert.ToInt32(array[4]), Convert.ToInt32(array[5]));
		}

		public bool method_19()
		{
			bool result = true;
			string string_ = "";
			try
			{
				method_17("com.facebook.katana/com.facebook.katana.settings.activity.SettingsActivity");
				for (int i = 0; i < 2; i++)
				{
					switch (method_84("", 5.0, "continuous contacts upload, off, switch", "continuous contacts upload, on, switch"))
					{
						case 2:
							{
								int num5 = 1;
								bool flag2;
								do
								{
									switch (num5)
									{
										case 1:
											flag2 = method_99("continuous contacts upload, on, switch");
											goto IL_0079;
										case 2:
											flag2 = method_99("turn off", "", 5);
											goto IL_0079;
									}
									break;
								IL_0079:
									num5++;
								}
								while (flag2);
								break;
							}
						case 1:
							{
								i++;
								int num = 1;
								while (true)
								{
								IL_01a3:
									bool flag = method_99("continuous contacts upload, off, switch");
									while (true)
									{
										num++;
										if (flag)
										{
											switch (num)
											{
												case 2:
													break;
												case 3:
													goto IL_0151;
												case 1:
													goto IL_01a3;
												default:
													goto IL_01b8;
											}
											int num2 = method_83(ref string_, 5.0, "\"contacts upload\"", "\"get started\"");
											int num3 = num2;
											int num4 = num3;
											flag = ((num4 == 1) ? method_99("\"contacts upload\"", string_) : (num4 == 2 && method_99("\"get started\"", string_)));
											continue;
										}
										break;
									IL_0151:
										for (int j = 0; j < 30; j++)
										{
											string_ = method_93();
											if (method_82("people you may know", string_))
											{
												break;
											}
											method_121(1.0);
										}
										continue;
									IL_01b8:
										if (num >= 4)
										{
										}
										break;
									}
									break;
								}
								break;
							}
					}
				}
				return result;
			}
			catch
			{
				return false;
			}
		}

		public void method_20(List<string> list_1)
		{
			List<string> contents = method_16(list_1);
			string text = method_29(10) + ".vcf";
			File.WriteAllLines(text, contents);
			try
			{
				method_1("com.android.contacts");
				method_1("com.android.providers.contacts");
				using (File.OpenRead(text))
				{
					method_21(text, "/sdcard/contact.vcf");
				}
				method_85("shell pm grant com.android.contacts android.permission.READ_EXTERNAL_STORAGE");
				Class2.smethod_5(DeviceId, "/sdcard/contact.vcf");
				string string_ = "";
				if (method_62("import contacts from vcard", ref string_, 10.0) || method_62("nhập liên hệ từ vcard", ref string_, 10.0))
				{
					method_99("\"ok\"", string_);
				}
				File.Delete(text);
			}
			catch
			{
			}
		}

		public string method_21(string string_12, string string_13)
		{
			return Class2.smethod_4(DeviceId, string_12, string_13);
		}

		public void method_22()
		{
			method_85(string.Format(Class1.string_0, string_5, "com.facebook.katana"));
		}

		public void method_23(double double_0, double double_1)
		{
			if (method_129())
			{
				Thread.Sleep(rd.Next(Convert.ToInt32(double_0 * 1000.0), Convert.ToInt32(double_1 * 1000.0 + 1.0)));
				Application.DoEvents();
			}
		}

		public string method_24()
		{
			string text = "";
			string text2 = "";
			try
			{
				string input = method_25("data/data/com.instagram.android/app_light_prefs/com.instagram.android/authentication");
				text = Regex.Match(input, "EAAAAU\\S+").Value;
				string value = Regex.Match(text, "\u0005(.*?)$").Value;
				text = text.Replace(value, "");
				string json = "{\"data\": [" + Regex.Match(input, "\\[(.*?)\\]").Groups[1].Value + "]}";
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					text2 = text2 + jObject["data"]![i]!["name"]!.ToString() + "=" + jObject["data"]![i]!["value"]!.ToString() + ";";
				}
			}
			catch
			{
			}
			return text + "|" + text2;
		}

		public string method_25(string string_12)
		{
			return Class2.smethod_20(DeviceId, string_12);
		}

		public void method_26()
		{
			method_85("shell pm grant com.facebook.katana android.permission.READ_CALENDAR");
			method_85("shell pm grant com.facebook.katana android.permission.READ_CONTACTS");
			method_85("shell pm grant com.facebook.katana android.permission.READ_LOCATION");
			method_85("shell pm grant com.facebook.katana android.permission.ACCESS_BACKGROUND_LOCATION");
			method_85("shell pm grant com.facebook.katana android.permission.ACCESS_COARSE_LOCATION");
			method_85("shell pm grant com.facebook.katana android.permission.ACCESS_FINE_LOCATION");
			method_85("shell pm grant com.facebook.katana android.permission.RECORD_AUDIO");
			method_85("shell pm grant com.facebook.katana android.permission.CALL_PHONE");
			method_85("shell pm grant com.facebook.katana android.permission.READ_EXTERNAL_STORAGE");
			method_85("shell pm grant com.facebook.katana android.permission.WRITE_EXTERNAL_STORAGE");
		}

		public void method_27()
		{
			method_85("shell pm grant com.facebook.lite android.permission.READ_CALENDAR");
			method_85("shell pm grant com.facebook.lite android.permission.READ_CONTACTS");
			method_85("shell pm grant com.facebook.lite android.permission.READ_LOCATION");
			method_85("shell pm grant com.facebook.lite android.permission.ACCESS_BACKGROUND_LOCATION");
			method_85("shell pm grant com.facebook.lite android.permission.ACCESS_COARSE_LOCATION");
			method_85("shell pm grant com.facebook.lite android.permission.ACCESS_FINE_LOCATION");
			method_85("shell pm grant com.facebook.lite android.permission.RECORD_AUDIO");
			method_85("shell pm grant com.facebook.lite android.permission.CALL_PHONE");
			method_85("shell pm grant com.facebook.lite android.permission.READ_EXTERNAL_STORAGE");
			method_85("shell pm grant com.facebook.lite android.permission.WRITE_EXTERNAL_STORAGE");
		}

		public void method_28()
		{
			method_85("shell pm grant com.instagram.android android.permission.READ_CALENDAR");
			method_85("shell pm grant com.instagram.android android.permission.READ_CONTACTS");
			method_85("shell pm grant com.instagram.android android.permission.READ_LOCATION");
			method_85("shell pm grant com.instagram.android android.permission.ACCESS_BACKGROUND_LOCATION");
			method_85("shell pm grant com.instagram.android android.permission.ACCESS_COARSE_LOCATION");
			method_85("shell pm grant com.instagram.android android.permission.ACCESS_FINE_LOCATION");
			method_85("shell pm grant com.instagram.android android.permission.RECORD_AUDIO");
			method_85("shell pm grant com.instagram.android android.permission.CALL_PHONE");
			method_85("shell pm grant com.instagram.android android.permission.READ_EXTERNAL_STORAGE");
			method_85("shell pm grant com.instagram.android android.permission.WRITE_EXTERNAL_STORAGE");
		}

		public string method_29(int int_4 = 32, string string_12 = "0_a_A", Random random_1 = null)
		{
			string text = "";
			string[] source = string_12.Split('_');
			if (source.Contains("A"))
			{
				text += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			}
			if (source.Contains("a"))
			{
				text += "abcdefghijklmnopqrstuvwxyz";
			}
			if (source.Contains("0"))
			{
				text += "0123456789";
			}
			char[] array = new char[int_4];
			if (random_1 == null)
			{
				random_1 = rd;
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random_1.Next(text.Length)];
			}
			return new string(array);
		}

		public string method_30(string string_12, string string_13)
		{
			return Class2.smethod_15(DeviceId, string_12, string_13);
		}

		public string method_31(string string_12 = "", string string_13 = "*.png")
		{
			try
			{
				if (!string.IsNullOrEmpty(string_12))
				{
					Directory.CreateDirectory(string_12);
				}
				string_13 = Path.GetFileNameWithoutExtension(string_13) + Path.GetExtension(string_13);
				Class2.smethod_16(DeviceId, "/sdcard/" + string_13);
				if (string.IsNullOrEmpty(string_12))
				{
					string_12 = Class25.smethod_0();
				}
				method_30("/sdcard/" + string_13, string_12);
				method_85("shell rm /sdcard/*.png");
				return string_12 + "\\" + string_13;
			}
			catch
			{
			}
			return "";
		}

		private Bitmap method_32(string string_12, bool bool_0 = true)
		{
			Bitmap result = null;
			try
			{
				using FileStream stream = File.OpenRead(string_12);
				result = (Bitmap)Image.FromStream(stream);
			}
			catch
			{
			}
			if (bool_0)
			{
				Common.smethod_76(string_12);
			}
			return result;
		}

		public Bitmap method_33()
		{
			Bitmap bitmap = null;
			try
			{
				string string_ = method_31("", method_29(10, "a") + ".png");
				return method_32(string_);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool method_34(string string_12, string string_13 = "")
		{
			try
			{
				Point point = method_88(string_12);
				int x = point.X;
				int y = point.Y;
				if (string_13 == "" || method_92(string_13, x, y))
				{
					return method_36(x, y, 3000);
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		public void method_35()
		{
			method_85(string.Format(Class1.string_0, string_6, "com.facebook.katana"));
		}

		public bool method_36(int int_4, int int_5, int int_6 = -1)
		{
			if (method_92("[0,0][320,480]", int_4, int_5))
			{
				if (int_6 == -1)
				{
					int_6 = method_15(1000, 3000);
				}
				Class2.smethod_28(DeviceId, int_4, int_5, int_6);
				return true;
			}
			return false;
		}

		private Point? method_37(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.9)
		{
			try
			{
				Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap_0);
				Image<Bgr, byte> template = new Image<Bgr, byte>(bitmap_1);
				Point? result = null;
				using (Image<Gray, float> image2 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
				{
					image2.MinMax(out var _, out var maxValues, out var _, out var maxLocations);
					if (maxValues[0] > double_0)
					{
						result = maxLocations[0];
					}
				}
				return result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public string method_38()
		{
			if (method_52("DataClick\\image\\phoneoremail"))
			{
				return "";
			}
			return method_1("com.facebook.katana");
		}

		public string method_39()
		{
			return method_1("com.facebook.katana");
		}

		public string method_40()
		{
			return method_1("com.facebook.lite");
		}

		public string method_41(Bitmap bitmap_0, Bitmap bitmap_1 = null, int int_4 = 0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (bitmap_1 == null)
					{
						bitmap_1 = method_33();
					}
					Point? point = null;
					point = method_37(bitmap_1, bitmap_0);
					if (point.HasValue)
					{
						Point value = point.Value;
						if (value.X != 0 && value.Y != 0)
						{
							return $"[{value.X},{value.Y}][{value.X + bitmap_0.Width},{value.Y + bitmap_0.Height}]";
						}
					}
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_121(1.0);
						bitmap_1 = method_33();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		public string method_42(string string_12, Bitmap bitmap_0 = null, int int_4 = 0)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string_12);
				FileInfo[] files = directoryInfo.GetFiles();
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (bitmap_0 == null)
					{
						bitmap_0 = method_33();
					}
					Point? point = null;
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Bitmap bitmap = (Bitmap)Image.FromFile(fileInfo.FullName);
						point = method_37(bitmap_0, bitmap);
						if (point.HasValue)
						{
							Point value = point.Value;
							if (value.X != 0 && value.Y != 0)
							{
								return $"[{value.X},{value.Y}][{value.X + bitmap.Width},{value.Y + bitmap.Height}]";
							}
						}
					}
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_121(1.0);
						bitmap_0 = method_33();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		public string method_43(string string_12, string string_13, string string_14)
		{
			string result = "";
			try
			{
				if (string_12 == "")
				{
					string_12 = method_93();
				}
				string_12 = Regex.Match(string_12, "<\\?xml(.*?)</hierarchy>").Value;
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(string_12);
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_13);
				result = xmlNodeList[xmlNodeList.Count - 1].Attributes[string_14].Value;
			}
			catch
			{
			}
			return result;
		}

		public bool method_44(string string_12 = "", string string_13 = "//*[@class='android.widget.edittext']", string string_14 = "text")
		{
			try
			{
				for (int i = 0; i < 10; i++)
				{
					string text = method_93();
					string text2 = method_43(text, string_13, string_14);
					if (!(text2 == string_12) && text2.Length != 0)
					{
						string[] array = method_43(text, string_13, "bounds").Split('[', ',', ']');
						Point point_ = new Point(int.Parse(array[4]) - 1, int.Parse(array[5]) - 1);
						method_51(point_);
						method_121(1.0);
						int num = text2.Length / 30 + ((text2.Length % 30 > 0) ? 1 : 0);
						string text3 = "";
						for (int j = 0; j < 30; j++)
						{
							text3 += "input keyevent KEYCODE_DEL && ";
						}
						text3 = "shell \"" + text3.TrimEnd(' ', '&') + "\"";
						for (int k = 0; k < num; k++)
						{
							method_85(text3);
						}
						continue;
					}
					if (string_12 != "")
					{
						method_99(string_12, text);
					}
					break;
				}
			}
			catch
			{
			}
			return false;
		}

		public void method_45()
		{
			method_46("shell am broadcast -a ADB_CLEAR_TEXT");
		}

		public string method_46(string string_12, int int_4 = 0, bool bool_0 = true)
		{
			string text = $"adb --index {int_0} --command \"{string_12}\"";
			return Class2.smethod_24(text, int_4, bool_0, PathLDPlayer);
		}

		public void method_47(int int_4, int int_5)
		{
			method_46("shell input tap " + int_4 + " " + int_5);
		}

		public string method_48(int int_4, Random random_1 = null)
		{
			string text = "";
			if (random_1 == null)
			{
				random_1 = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < int_4; i++)
			{
				text += text2[random_1.Next(0, text2.Length)];
			}
			return text;
		}

		public void method_49(string string_12, bool bool_0 = true, bool bool_1 = true)
		{
			method_130("Send: " + string_12);
			if (bool_1)
			{
				char[] array = string_12.ToCharArray();
				char[] array2 = array;
				foreach (char c in array2)
				{
					if (bool_0 && rd.Next(1, 100) < 6)
					{
						int num = rd.Next(1, 5);
						for (int num2 = num; num2 > 0; num2--)
						{
							method_46("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(method_48(1).ToString())) + "'");
							Thread.Sleep(rd.Next(50, 200));
						}
						for (int num3 = num; num3 > 0; num3--)
						{
							method_50(67);
							Thread.Sleep(rd.Next(50, 200));
						}
					}
					method_46("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(c.ToString())) + "'");
					Thread.Sleep(rd.Next(50, 200));
				}
			}
			else
			{
				method_46("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_12.ToString())) + "'");
			}
		}

		public void method_50(int int_4)
		{
			method_46("shell input keyevent \"" + int_4 + "\"");
		}

		public bool method_51(Point point_0, int int_4 = 1)
		{
			if (method_92("[0,0][320,480]", point_0.X, point_0.Y))
			{
				Class2.smethod_17(DeviceId, point_0.X, point_0.Y);
				method_121(int_4);
				return true;
			}
			return false;
		}

		public bool method_52(string string_12, Bitmap bitmap_0 = null, int int_4 = 0)
		{
			try
			{
				string text = method_42(string_12, bitmap_0, int_4);
				return text != "";
			}
			catch (Exception)
			{
			}
			return false;
		}

		public bool method_53(ref string string_12)
		{
			if (method_54(string_12))
			{
				string_12 = method_93();
				return true;
			}
			return false;
		}

		public static List<string> smethod_0()
		{
			return new List<string> { "\"close\"", "\"skip\"", "\"cancel\"", "\"got it\"" };
		}

		public bool method_54(string string_12 = "")
		{
			bool flag = false;
			if (method_52("DataClick\\image\\x"))
			{
				method_56("DataClick\\image\\x", 0, 3);
				flag = true;
			}
			else
			{
				if (string_12 == "")
				{
					string_12 = method_93();
				}
				string text = method_55(string_12, 0.0, smethod_0().ToArray());
				if (text != "" && (!(text == "\"cancel\"") || !method_82("request sent", string_12)))
				{
					method_99(text, string_12);
				}
			}
			if (flag)
			{
				method_121(1.0);
				if (method_52("DataClick\\image\\stop"))
				{
					method_56("DataClick\\image\\stop");
				}
				else
				{
					string_12 = method_93();
					if (method_82("\"stop\"", string_12))
					{
						method_99("\"stop\"", string_12);
					}
					if (method_82("\"dừng\"", string_12))
					{
						method_99("\"dừng\"", string_12);
					}
				}
			}
			return flag;
		}

		public string method_55(string string_12, double double_0, params string[] string_13)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_12 == "")
					{
						string_12 = method_93();
					}
					for (int i = 0; i < string_13.Length; i++)
					{
						if (Regex.IsMatch(string_12, string_13[i] + "(.*?)/>"))
						{
							return string_13[i];
						}
					}
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_121(1.0);
						string_12 = method_93();
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			return "";
		}

		public bool method_56(string string_12, int int_4 = 0, int int_5 = 10)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (method_129())
				{
					method_130("Find Img: " + string_12.Substring(string_12.LastIndexOf('\\') + 1));
					string text = method_42(string_12);
					if (text != "")
					{
						method_130("Click Img: " + string_12.Substring(string_12.LastIndexOf('\\') + 1));
						for (int i = 0; i < int_5; i++)
						{
							if (method_129())
							{
								method_89(text);
								method_121(1.0);
								string text2 = method_42(string_12);
								if (text2 == "" || text2 != text)
								{
									return true;
								}
								continue;
							}
							goto end_IL_00df;
						}
					}
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_121(1.0);
						continue;
					}
					break;
					continue;
				end_IL_00df:
					break;
				}
			}
			catch
			{
			}
			return false;
		}

		private List<string> method_57()
		{
			return new List<string> { "com.facebook.katana/com.facebook.checkpoint.CheckpointActivity", "checkpoint" };
		}

		private List<string> method_58()
		{
			return new List<string> { "com.facebook.katana/com.facebook.katana.dbl.activity.DeviceBasedLoginActivity" };
		}

		private int method_59(string string_12, Dictionary<int, List<string>> dictionary_0)
		{
			foreach (KeyValuePair<int, List<string>> item in dictionary_0)
			{
				foreach (string item2 in item.Value)
				{
					if (Regex.IsMatch(string_12, item2) || string_12.Contains(item2))
					{
						return item.Key;
					}
				}
			}
			return 0;
		}

		private static List<string> smethod_1()
		{
			return new List<string>
			{
				"your account is temporarily unavailable", "your account is temporarily locked", "your account has been disabled", "your account has been locked", "\"learn more\"", "download your information", "go to community standards", "choose a security check", "provide your birthday", "identify photos of friends",
				"get a code sent to your email", "enter number", "check the login details shown. was it you?"
			};
		}

		public int method_60(ref string string_12, bool bool_0 = true)
		{
			try
			{
				if (!method_129())
				{
					return -2;
				}
				Bitmap bitmap_ = method_33();
				if (method_52("DataClick\\image\\logout", bitmap_))
				{
					return -11;
				}
				if (method_52("DataClick\\image\\checkpoint", bitmap_))
				{
					return 2;
				}
				if (method_52("DataClick\\image\\openappagain", bitmap_))
				{
					int_1++;
					if (int_1 >= 3)
					{
						return -4;
					}
					method_56("DataClick\\image\\openappagain");
					return 1;
				}
				string text = method_87();
				if (text.Contains("Launcher"))
				{
					method_105();
					return 1;
				}
				if (text == "Application")
				{
					return -4;
				}
				Dictionary<int, List<string>> dictionary_ = new Dictionary<int, List<string>>
				{
					{
						1,
						method_57()
					},
					{
						2,
						method_58()
					}
				};
				switch (method_59(text, dictionary_))
				{
					case 1:
						return 2;
					case 2:
						return -12;
					default:
						{
							string_12 = method_93();
							method_53(ref string_12);
							List<string> list = method_120(string_12);
							if (list.Count == 2 && list.Contains("back") && (list.Contains("search") || list.Contains("web view")))
							{
								return -13;
							}
							if (list.Count == 3 && list.Contains("back") && list.Contains("facebook") && list.Contains("web view"))
							{
								return -14;
							}
							Dictionary<int, List<string>> dictionary_2 = new Dictionary<int, List<string>>
					{
						{
							1,
							smethod_1()
						},
						{
							4,
							new List<string> { "session expired", "please log in again." }
						}
					};
							switch (method_59(string_12, dictionary_2))
							{
								default:
									{
										for (int i = 0; i < 2; i++)
										{
											string_12 = method_93();
											if (method_82("\"tap to retry\"", string_12))
											{
												method_99("\"tap to retry\"", string_12);
												method_121(1.0);
												continue;
											}
											int_2 = 0;
											break;
										}
										break;
									}
								case 1:
									return 2;
								case 2:
									return -4;
								case 3:
									return 7;
								case 4:
									return -15;
							}
							break;
						}
				}
			}
			catch
			{
			}
			return 0;
		}

		public string method_61(int int_4 = 120)
		{
			string result = "0|";
			try
			{
				string string_ = "";
				int num = -1;
				int tickCount = Environment.TickCount;
				while (method_129())
				{
					string text = method_87();
					if (text.Contains("Launcher"))
					{
						method_105();
					}
					else
					{
						if (text == "Application")
						{
							return "2|";
						}
						if (text == "")
						{
							if (!method_54(string_))
							{
								if (method_82("\"close", string_))
								{
									method_99("\"close", string_);
									method_99("\"back\"");
								}
								else
								{
									method_105();
								}
							}
						}
						else
						{
							List<string> list = new List<string> { "com.facebook.katana/com.facebook.katana.app.FacebookSplashScreenActivity", "com.facebook.katana/com.facebook.deeplinking.activity.StoryDeepLinkLoadingActivity", "com.facebook.katana/com.facebook.resources.impl.WaitingForStringsActivity" };
							if (!list.Contains(text))
							{
								Bitmap bitmap_ = method_33();
								string text2 = method_42("DataClick\\image\\phoneoremail", bitmap_);
								string text3 = method_42("DataClick\\image\\password", bitmap_);
								string text4 = method_42("DataClick\\image\\login", bitmap_);
								if (text2 != "" && text3 != "" && text4 != "")
								{
									return "1|0";
								}
								if (method_52("DataClick\\image\\checkpoint"))
								{
									num = 2;
								}
								else
								{
									string_ = "";
									if (method_52("DataClick\\image\\ok") && !method_52("DataClick\\image\\facebook"))
									{
										method_56("DataClick\\image\\ok");
									}
									else if (method_62("\"ok\"", ref string_))
									{
										method_99("\"ok\"", string_);
									}
									else if (!method_54(string_) && method_82("\"close", string_))
									{
										method_99("\"close", string_);
										method_99("\"back\"");
									}
									num = method_67(text);
									if (num == -1)
									{
										string_ = method_93();
										num = method_63(string_);
									}
								}
								if (Environment.TickCount - tickCount >= int_4 * 1000)
								{
									break;
								}
							}
						}
					}
					if (num != -1)
					{
						if (num != -1)
						{
							result = "1|" + num;
						}
						return result;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		public bool method_62(string string_12, ref string string_13, double double_0 = 0.0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string.IsNullOrEmpty(string_13))
					{
						string_13 = method_93();
					}
					if (!Regex.IsMatch(string_13, string_12 + "(.*?)/>"))
					{
						if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
						{
							method_121(1.0);
							string_13 = method_93();
							continue;
						}
						break;
					}
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		private static List<string> smethod_2()
		{
			return new List<string>
			{
				"\"search facebook\"", "\"go to profile\"", "\"make a post on facebook\"", "\"live\"", "\"messaging\"", "\"photo\"", "\"check in\"", "\"stories\"", "\"marketplace\"", "\"notifications,",
				"\"save your login info\""
			};
		}

		private static List<string> smethod_3()
		{
			return new List<string> { "\"confirmation code\"", "\"change phone number\"", "\"confirm by email\"", "\"change email address\"", "\"confirm by phone number\"" };
		}

		private int method_63(string string_12)
		{
			int result = 0;
			try
			{
				if (string_12 == "")
				{
					string_12 = method_93();
				}
				method_53(ref string_12);
				if (method_84(string_12, 0.0, smethod_2().ToArray()) != 0)
				{
					result = 1;
				}
				else if (method_84(string_12, 0.0, smethod_1().ToArray()) != 0)
				{
					result = 2;
				}
				else if (method_84(string_12, 0.0, smethod_3().ToArray()) != 0)
				{
					result = 8;
				}
				else if (method_84(string_12, 0.0, "session expired", "please log in again.") != 0)
				{
					result = 11;
				}
			}
			catch
			{
			}
			return result;
		}

		private bool method_64(string string_12, List<string> list_1)
		{
			int num = 0;
			while (true)
			{
				if (num < list_1.Count)
				{
					if (string_12.Contains(list_1[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		private List<string> method_65()
		{
			return new List<string> { "com.facebook.katana/com.facebook.katana.activity.FbMainTabActivity", "com.facebook.katana/com.facebook.location.optin.DeviceLocationSettingsOptInActivity", "com.facebook.katana/com.facebook.location.optin.AccountLocationSettingsOptInActivity", "com.facebook.katana/com.facebook.account.switcher.nux.ActivateDeviceBasedLoginNuxActivity" };
		}

		private List<string> method_66()
		{
			return new List<string> { "com.facebook.confirmation.activity.SimpleConfirmAccountActivity" };
		}

		private int method_67(string string_12)
		{
			int result = -1;
			try
			{
				if (method_64(string_12, method_65()))
				{
					result = 1;
				}
				else if (method_64(string_12, method_57()))
				{
					result = 2;
				}
				else if (method_64(string_12, method_66()))
				{
					result = 8;
				}
				else if (method_64(string_12, method_58()))
				{
					result = 0;
				}
			}
			catch
			{
			}
			return result;
		}

		public void method_68()
		{
			try
			{
				Class2.smethod_21(PathLDPlayer, int_0);
			}
			catch
			{
			}
		}

		public void method_69()
		{
			try
			{
				Class2.smethod_22(PathLDPlayer, int_0);
			}
			catch
			{
			}
		}

		public void method_70()
		{
			method_73("com.facebook.katana");
		}

		public void method_71()
		{
			method_73("com.instagram.android");
		}

		public void method_72()
		{
			method_73("com.cell47.College_Proxy");
		}

		public void method_73(string string_12)
		{
			if (method_129())
			{
				Class2.smethod_10(DeviceId, string_12);
			}
		}

		public void method_74(int int_4 = 1, double double_0 = 0.0)
		{
			for (int i = 0; i < int_4; i++)
			{
				method_101(KeyEvent.KEYCODE_BACK);
				method_121(double_0);
			}
		}

		public bool method_75(double double_0 = 0.0, params string[] string_12)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					string input = method_93();
					for (int i = 0; i < string_12.Length; i++)
					{
						if (!Regex.IsMatch(input, string_12[i] + "(.*?)/>"))
						{
							return true;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_121(1.0);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			return false;
		}

		public List<string> method_76(string string_12, string string_13 = "", int int_4 = 0)
		{
			List<string> list = new List<string>();
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_13 == "")
					{
						string_13 = method_93();
					}
					MatchCollection matchCollection = Regex.Matches(string_13, string_12.Replace("[", "\\[").Replace("]", "\\]") + "(.*?)/>");
					for (int i = 0; i < matchCollection.Count; i++)
					{
						list.Add(Regex.Match(matchCollection[i].Value, "bounds=\"(.*?)\"").Groups[1].Value);
					}
					if (list.Count <= 0 && Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_121(1.0);
						string_13 = method_93();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return list;
		}

		public List<string> method_77(string string_12, string string_13 = "", int int_4 = 0)
		{
			List<string> list = new List<string>();
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_13 == "")
					{
						string_13 = method_94();
					}
					MatchCollection matchCollection = Regex.Matches(string_13, string_12.Replace("[", "\\[").Replace("]", "\\]") + "(.*?)/>");
					for (int i = 0; i < matchCollection.Count; i++)
					{
						list.Add(Regex.Match(matchCollection[i].Value, "bounds=\"(.*?)\"").Groups[1].Value);
					}
					if (list.Count <= 0 && Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_121(1.0);
						string_13 = method_93();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return list;
		}

		public Bitmap method_78(Bitmap bitmap_0, string string_12)
		{
			string[] array = string_12.Split('[', ',', ']');
			return bitmap_0.Clone(new Rectangle(Convert.ToInt32(array[1]), Convert.ToInt32(array[2]), Convert.ToInt32(array[4]) - Convert.ToInt32(array[1]), Convert.ToInt32(array[5]) - Convert.ToInt32(array[2])), bitmap_0.PixelFormat);
		}

		public void method_79(int int_4, int int_5, int int_6, int int_7, int int_8 = 100)
		{
			Class2.smethod_12(DeviceId, int_4, int_5, int_6, int_7, int_8);
		}

		public bool method_80(string string_12, string string_13, int int_4 = 100)
		{
			try
			{
				Point point = method_88(string_12);
				int x = point.X;
				int y = point.Y;
				Point point2 = method_88(string_13);
				int x2 = point2.X;
				int y2 = point2.Y;
				method_79(x, y, x2, y2, int_4);
				return true;
			}
			catch
			{
			}
			return false;
		}

		public bool method_81(int int_4 = 1000, int int_5 = 1, string string_12 = "[100,391][219,423]", string string_13 = "[181,195][286,226]", string string_14 = "[72,165][216,294]")
		{
			try
			{
				int num = 3;
				Bitmap bitmap = method_33();
				if (bitmap != null)
				{
					Bitmap bitmap_ = method_78(bitmap, string_14);
					for (int i = 0; i < num; i++)
					{
						if (int_5 == 1)
						{
							method_80(string_12, string_13, int_4);
						}
						else
						{
							method_80(string_13, string_12, int_4);
						}
						method_121(1.0);
						string text = method_41(bitmap_);
						if (string_14 != text)
						{
							return false;
						}
					}
				}
				else
				{
					for (int j = 0; j < num; j++)
					{
						string text2 = method_93();
						if (int_5 == 1)
						{
							method_80(string_12, string_13, int_4);
						}
						else
						{
							method_80(string_13, string_12, int_4);
						}
						string text3 = method_93();
						if (text2 != text3)
						{
							return false;
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return true;
		}

		public bool method_82(string string_12, string string_13 = "", double double_0 = 0.0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_13 == "")
					{
						string_13 = method_93();
					}
					if (!Regex.IsMatch(string_13, string_12 + "(.*?)/>"))
					{
						if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
						{
							method_121(1.0);
							string_13 = method_93();
							continue;
						}
						break;
					}
					return true;
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		public int method_83(ref string string_12, double double_0 = 0.0, params string[] string_13)
		{
			int result = 0;
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_12 == "")
					{
						string_12 = method_93();
					}
					for (int i = 0; i < string_13.Length; i++)
					{
						if (Regex.IsMatch(string_12, string_13[i] + "(.*?)/>"))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_121(1.0);
						string_12 = method_93();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		public int method_84(string string_12 = "", double double_0 = 0.0, params string[] string_13)
		{
			int result = 0;
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_12 == "")
					{
						string_12 = method_93();
					}
					for (int i = 0; i < string_13.Length; i++)
					{
						if (Regex.IsMatch(string_12, string_13[i] + "(.*?)/>"))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_121(1.0);
						string_12 = method_93();
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			return result;
		}

		public string method_85(string string_12, int int_4 = 10)
		{
			if (!method_129())
			{
				return "";
			}
			if (method_87() != "com.facebook.katana/com.facebook.video.channelfeed.activity.ChannelFeedActivity" && string_12.Contains(Class1.string_0.Substring(0, Class1.string_0.IndexOf("\""))))
			{
				method_54();
			}
			return Class2.smethod_23(DeviceId, string_12, int_4);
		}

		public void method_86(string string_12)
		{
			if (method_129())
			{
				Class2.smethod_0(DeviceId, string_12);
			}
		}

		public string method_87()
		{
			try
			{
				if (!method_129())
				{
					return "";
				}
				return Class2.smethod_19(DeviceId).Split('{', '}')[1].Split(' ')[2];
			}
			catch
			{
			}
			return "";
		}

		public Point method_88(string string_12)
		{
			try
			{
				string[] array = string_12.Split('[', ',', ']');
				int x = rd.Next(Convert.ToInt32(array[1]), Convert.ToInt32(array[4]));
				int y = rd.Next(Convert.ToInt32(array[2]), Convert.ToInt32(array[5]));
				return new Point(x, y);
			}
			catch
			{
			}
			return default(Point);
		}

		public bool method_89(string string_12, string string_13 = "")
		{
			try
			{
				Point point = method_88(string_12);
				int x = point.X;
				int y = point.Y;
				if (string_13 == "" || method_92(string_13, x, y))
				{
					return method_91(x, y);
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		public bool method_90(string string_12, string string_13 = "")
		{
			try
			{
				Point point = method_88(string_12);
				int x = point.X;
				int y = point.Y;
				if (string_13 == "" || method_92(string_13, x, y))
				{
					method_47(x, y);
					return true;
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		public bool method_91(int int_4, int int_5, int int_6 = 1)
		{
			if (method_92("[0,0][320,480]", int_4, int_5))
			{
				Class2.smethod_17(DeviceId, int_4, int_5);
				method_121(int_6);
				return true;
			}
			return false;
		}

		public bool method_92(string string_12, int int_4, int int_5)
		{
			string[] array = string_12.Split('[', ',', ']');
			return int_4 >= Convert.ToInt32(array[1]) && int_4 <= Convert.ToInt32(array[4]) && int_5 >= Convert.ToInt32(array[2]) && int_5 <= Convert.ToInt32(array[5]);
		}

		public string method_93()
		{
			string result = "";
			try
			{
				if (method_87().Contains("com.facebook.katana/com.facebook.video.channelfeed.activity.ChannelFeedActivity"))
				{
					return "";
				}
				result = Class2.smethod_18(DeviceId);
			}
			catch
			{
			}
			return result;
		}

		public string method_94()
		{
			string result = "";
			try
			{
				if (method_87().Contains("com.facebook.lite/com.facebook.video.channelfeed.activity.ChannelFeedActivity"))
				{
					return "";
				}
				result = Class2.smethod_18(DeviceId);
			}
			catch
			{
			}
			return result;
		}

		public bool method_95(int int_4 = 120)
		{
			bool flag = false;
			int tickCount = Environment.TickCount;
			int num = 0;
			while (!flag)
			{
				num++;
				if (num == int_4)
				{
					break;
				}
				if (Environment.TickCount - tickCount >= int_4 * 1000 || !method_129())
				{
					continue;
				}
				string text = method_87();
				if (text.Contains("Launcher"))
				{
					method_105();
					continue;
				}
				List<string> list = new List<string> { "", "com.facebook.katana/com.facebook.deeplinking.activity.StoryDeepLinkLoadingActivity", "com.facebook.katana/com.facebook.katana.app.FacebookSplashScreenActivity", "com.facebook.katana/com.facebook.resources.impl.WaitingForStringsActivity" };
				if (list.Contains(text))
				{
					if (!(text == "com.facebook.katana/com.facebook.resources.impl.WaitingForStringsActivity") && text == "")
					{
						method_54();
					}
					continue;
				}
				if (!(text == "com.facebook.katana/com.facebook.account.login.activity.SimpleLoginActivity"))
				{
					if (!(text == "com.facebook.katana/com.facebook.katana.LoginActivity"))
					{
						continue;
					}
					flag = true;
					break;
				}
				flag = true;
				break;
			}
			return flag;
		}

		public int method_96(string string_12, double double_0, Dictionary<int, List<string>> dictionary_0)
		{
			int result = 0;
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (string_12 == "")
					{
						string_12 = method_93();
					}
					foreach (KeyValuePair<int, List<string>> item in dictionary_0)
					{
						foreach (string item2 in item.Value)
						{
							if (Regex.IsMatch(string_12, item2 + "(.*?)/>"))
							{
								return item.Key;
							}
						}
					}
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_121(1.0);
						string_12 = method_93();
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		public string method_97(string string_12, string string_13 = "", int int_4 = 0)
		{
			try
			{
				method_130("Find Text: " + string_12);
				int tickCount = Environment.TickCount;
				while (method_129())
				{
					if (string_13 == "")
					{
						string_13 = method_93();
					}
					string value = Regex.Match(string_13, string_12.Replace("[", "\\[").Replace("]", "\\]") + "(.*?)/>").Groups[1].Value;
					if (!(value != ""))
					{
						if (Environment.TickCount - tickCount < int_4 * 1000)
						{
							method_121(1.0);
							string_13 = method_93();
							continue;
						}
						break;
					}
					return Regex.Match(value, "bounds=\"(.*?)\"").Groups[1].Value;
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		public bool method_98(string string_12, Point point_0)
		{
			int x = point_0.X;
			int y = point_0.Y;
			return method_92(string_12, x, y);
		}

		public bool method_99(string string_12, string string_13 = "", int int_4 = 0)
		{
			string text = method_97(string_12, string_13, int_4);
			if (!string.IsNullOrEmpty(text))
			{
				method_130("Click Text: " + string_12);
				return method_89(text);
			}
			return false;
		}

		public void method_100(string string_12, double double_0 = 0.0)
		{
			Class2.smethod_9(DeviceId);
			method_130("Send: " + string_12);
			if (double_0 == 0.0)
			{
				method_85("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_12.ToString())) + "'");
			}
			else
			{
				double_0 = ((double_0 > 0.35) ? (double_0 - 0.35) : 0.0);
				for (int i = 0; i < string_12.Length; i++)
				{
					method_85("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_12[i].ToString())) + "'");
					method_121(double_0);
				}
			}
			Class2.smethod_13(DeviceId, list_0);
		}

		public string method_101(KeyEvent keyEvent_0)
		{
			return method_85("shell input keyevent " + keyEvent_0);
		}

		public void method_102(string string_12)
		{
			method_130("Send: " + string_12);
			Class2.smethod_14(DeviceId, string_12);
		}

		public void method_103()
		{
			try
			{
				method_86("de.robv.android.xposed.installer");
				for (int i = 0; i < 10; i++)
				{
					string text = method_87();
					if (!text.Contains("de.robv.android.xposed.installer"))
					{
						if (text.Contains("Launcher"))
						{
							method_99("xposed installer");
						}
						else
						{
							method_86("de.robv.android.xposed.installer");
						}
						method_121(3.0);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
		}

		public void method_104()
		{
			try
			{
				method_86("com.phoneinfo.changerpro");
				for (int i = 0; i < 10; i++)
				{
					string text = method_87();
					if (!text.Contains("com.phoneinfo.changerpro"))
					{
						if (text.Contains("Launcher"))
						{
							method_99("device id changer");
						}
						else
						{
							method_86("com.phoneinfo.changerpro");
						}
						method_121(3.0);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
		}

		public void method_105()
		{
			try
			{
				method_26();
				method_86("com.facebook.katana");
				for (int i = 0; i < 10; i++)
				{
					string text = method_87();
					if (!text.Contains("com.facebook.katana"))
					{
						if (text.Contains("Launcher"))
						{
							method_99("facebook");
						}
						else
						{
							method_86("com.facebook.katana");
						}
						method_121(3.0);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
		}

		public void method_106(int int_4 = 10)
		{
			try
			{
				method_27();
				method_86("com.facebook.lite");
				for (int i = 0; i < int_4; i++)
				{
					string text = method_87();
					if (!text.Contains("com.facebook.lite"))
					{
						if (text.Contains("Launcher"))
						{
							method_99("lite");
						}
						else
						{
							method_86("com.facebook.lite");
						}
						method_121(3.0);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
		}

		public void method_107()
		{
			method_28();
			method_86("com.instagram.android");
			for (int i = 0; i < 10; i++)
			{
				string text = method_87();
				if (!text.Contains("com.instagram.android"))
				{
					if (text.Contains("Launcher"))
					{
						method_99("instagram");
					}
					else
					{
						method_86("com.instagram.android");
					}
					method_121(3.0);
					continue;
				}
				break;
			}
		}

		public List<string> method_108()
		{
			return Class2.smethod_27(DeviceId);
		}

		public bool method_109(string string_12)
		{
			if (!method_129())
			{
				return false;
			}
			Class2.smethod_25(DeviceId, string_12);
			return true;
		}

		public void method_110(string string_12)
		{
			Class2.smethod_26(DeviceId, string_12);
		}

		public void method_111(string string_12)
		{
			string sourceFileName = Class25.smethod_0() + "\\device\\" + string_12 + "\\config";
			File.Copy(sourceFileName, PathLDPlayer + "\\vms\\config\\leidian" + int_0 + ".config", overwrite: true);
		}

		public void method_112(string string_12)
		{
			if (frmViewLD.frmViewLD_0 != null)
			{
				frmViewLD.frmViewLD_0.method_8(int_0, string_12);
			}
		}

		private List<string> method_113()
		{
			new List<string>();
			string text = Common.smethod_81("QXN1c3xBbGNhdGVsIFBpeGkgNCAoNSkqQXN1c3xBc3VzIFJPRyBQaG9uZSpBc3VzfEFzdXMgWmVuZm9uZSAyIExhc2VyKkFzdXN8QXN1cyBaZW5Gb25lIDMqQXN1c3xBc3VzIFplbmZvbmUgMypBc3VzfEFzdXMgWmVuZm9uZSAzIERlbHV4ZSA1LjUqQXN1c3xBc3VzIFplbmZvbmUgMyBMYXNlcipBc3VzfEFzdXMgWmVuZm9uZSAzIE1heCpBc3VzfEFzdXMgWmVuZm9uZSAzIFVsdHJhKkFzdXN8QXN1cyBaZW5mb25lIDMgWm9vbSpBc3VzfEFzdXMgWmVuZm9uZSAzcyBNYXgqQXN1c3xBc3VzIFplbkZvbmUgNCAoWkU1NTRLTCkqQXN1c3xBc3VzIFplbkZvbmUgNCBNYXgqQXN1c3xBc3VzIFplbkZvbmUgNCBNYXggUHJvIChaQzU1NEtMKSpBc3VzfEFzdXMgWmVuRm9uZSA0IFBybypBc3VzfEFzdXMgWmVuRm9uZSA0IFNlbGZpZSAoWkQ1NTNLTCkqQXN1c3xBc3VzIFplbkZvbmUgNCBTZWxmaWUgUHJvIChaRDU1MktMKSpBc3VzfEFzdXMgWmVuZm9uZSA1KkFzdXN8QXN1cyBaZW5mb25lIDUgTGl0ZSpBc3VzfEFzdXMgWmVuZm9uZSA1USpBc3VzfEFzdXMgWmVuZm9uZSA1WipBc3VzfEFzdXMgWmVuZm9uZSBBUipBc3VzfEFzdXMgWmVuZm9uZSBHbypBc3VzfEFzdXMgWmVuZm9uZSBHbyAoWkI1NTJLTCkqQXN1c3xBc3VzIFplbkZvbmUgTGl2ZSAoTDEpIFpBNTUwS0wqQXN1c3xBc3VzIFplbmZvbmUgTGl2ZSAoWkI1MDFLTCkqQXN1c3xBc3VzIFplbmZvbmUgTWF4KkFzdXN8QXN1cyBaZW5mb25lIE1heCAoTTEpIFpCNTU1S0wqQXN1c3xBc3VzIFplbmZvbmUgTWF4IFBsdXMgKE0xKSBaQjU3MFRMKkFzdXN8QXN1cyBaZW5mb25lIE1heCBQcm8gKE0xKSBaQjYwMUtMKkFzdXN8QXN1cyBaZW5mb25lIE1heCBQcm8gTTEqQXN1c3xBc3VzIFplbkZvbmUgTWF4IFBybyBNMSpBc3VzfEFzdXMgWmVuZm9uZSBWIFY1MjBLTCpBc3VzfEFzdXMgWmVuUGFkIDNzIDEwKkFzdXN8QXN1cyBaZW5QYWQgM3MgOC4wKkFzdXN8QXN1cyBaZW5QYWQgWjEwKkFzdXN8QXN1cyBaZW5wYWQgWjhzIChaVDU4MktMKSpBc3VzfEJsdWJvbyBENipBc3VzfEJRIEFxdWFyaXMgTTUqQXN1c3xEb29nZWUgWDUgTWF4KkFzdXN8RWxlcGhvbmUgVSBQcm8qQXN1c3xFc3NlbnRpYWwgUGhvbmUgUEgtMSpBc3VzfEdlbmVyYWwgTW9iaWxlIEdNIDUqR29vZ2xlfEdvb2dsZSBOZXh1cyAxMCpHb29nbGV8R29vZ2xlIE5leHVzIDQqR29vZ2xlfEdvb2dsZSBOZXh1cyA1Kkdvb2dsZXxHb29nbGUgTmV4dXMgNipHb29nbGV8R29vZ2xlIE5leHVzIDZQKkdvb2dsZXxHb29nbGUgUGl4ZWwqR29vZ2xlfEdvb2dsZSBQaXhlbCAyKkdvb2dsZXxHb29nbGUgUGl4ZWwgMiBYTCpHb29nbGV8R29vZ2xlIFBpeGVsIEMqR29vZ2xlfEdvb2dsZSBQaXhlbCBYTCpIVEN8SFRDIDEwKkhUQ3xIVEMgMTAgRXZvKkhUQ3xIVEMgMTAgTGlmZXN0eWxlKkhUQ3xIVEMgRGVzaXJlIDEwIExpZmVzdHlsZSpIVEN8SFRDIERlc2lyZSAxMCBQcm8qSFRDfEhUQyBEZXNpcmUgMTIqSFRDfEhUQyBEZXNpcmUgMTIrKkhUQ3xIVEMgT25lIE04KkhUQ3xIVEMgT25lIE05KkhUQ3xIVEMgVSBQbGF5KkhUQ3xIVEMgVSBVbHRyYSpIVEN8SFRDIFUxMSpIVEN8SFRDIFUxMSBFeWVzKkhUQ3xIVEMgVTExIExpZmUqSFRDfEhUQyBVMTErKkhUQ3xIVEMgVTEyIGxpZmUqSFRDfEhUQyBVMTIrKkh1YXdlaXxIdWF3ZWkgR1IzICgyMDE3KSpIdWF3ZWl8SHVhd2VpIEhvbm9yIDEwKkh1YXdlaXxIdWF3ZWkgSG9ub3IgNlgqSHVhd2VpfEh1YXdlaSBIb25vciA3QSpIdWF3ZWl8SHVhd2VpIEhvbm9yIDdzKkh1YXdlaXxIdWF3ZWkgSG9ub3IgN1gqSHVhd2VpfEh1YXdlaSBIb25vciA4IExpdGUqSHVhd2VpfEh1YXdlaSBIb25vciA4IFBybypIdWF3ZWl8SHVhd2VpIEhvbm9yIDkqSHVhd2VpfEh1YXdlaSBIb25vciA5IExpdGUqSHVhd2VpfEh1YXdlaSBIb25vciA5TiAoOWkpKkh1YXdlaXxIdWF3ZWkgSG9ub3IgTm90ZSAxMCpIdWF3ZWl8SHVhd2VpIEhvbm9yIFBsYXkqSHVhd2VpfEh1YXdlaSBIb25vciBWaWV3IDEwKkh1YXdlaXxIdWF3ZWkgTWF0ZSAxMCpIdWF3ZWl8SHVhd2VpIE1hdGUgMTAgTGl0ZSpIdWF3ZWl8SHVhd2VpIE1hdGUgMTAgUHJvKkh1YXdlaXxIdWF3ZWkgTWF0ZSAyMCBMaXRlKkh1YXdlaXxIdWF3ZWkgTWF0ZSA4Kkh1YXdlaXxIdWF3ZWkgTWF0ZSA5Kkh1YXdlaXxIdWF3ZWkgTWF0ZSA5IFBvcnNjaGUgRGVzaWduKkh1YXdlaXxIdWF3ZWkgTWF0ZSA5IFBybypIdWF3ZWl8SHVhd2VpIE5vdmEgMipIdWF3ZWl8SHVhd2VpIE5vdmEgMiBQbHVzKkh1YXdlaXxIdWF3ZWkgTm92YSAyaSpIdWF3ZWl8SHVhd2VpIG5vdmEgMypIdWF3ZWl8SHVhd2VpIE5vdmEgM2UqSHVhd2VpfEh1YXdlaSBub3ZhIDNpKkh1YXdlaXxIdWF3ZWkgTm92YSBMaXRlKkh1YXdlaXxIdWF3ZWkgUCBzbWFydCpIdWF3ZWl8SHVhd2VpIFAgU21hcnQrKkh1YXdlaXxIdWF3ZWkgUDEwKkh1YXdlaXxIdWF3ZWkgUDEwIExpdGUqSHVhd2VpfEh1YXdlaSBQMTAgUGx1cypIdWF3ZWl8SHVhd2VpIFAyMCpIdWF3ZWl8SHVhd2VpIFAyMCBMaXRlKkh1YXdlaXxIdWF3ZWkgUDIwIFBybypIdWF3ZWl8SHVhd2VpIFA4IExpdGUgKDIwMTcpKkh1YXdlaXxIdWF3ZWkgUDggTGl0ZSAyMDE3Kkh1YXdlaXxIdWF3ZWkgUDkgTGl0ZSpIdWF3ZWl8SHVhd2VpIFA5IExpdGUgKDIwMTcpKkh1YXdlaXxIdWF3ZWkgUDkgTGl0ZSAyMDE3Kkh1YXdlaXxIdWF3ZWkgWTMgKDIwMTgpKkh1YXdlaXxIdWF3ZWkgWTUgUHJpbWUgKDIwMTgpKkh1YXdlaXxIdWF3ZWkgWTYgKDIwMTgpKkh1YXdlaXxIdWF3ZWkgWTcgKDIwMTgpKkh1YXdlaXxIdWF3ZWkgWTcgUHJpbWUqSHVhd2VpfEh1YXdlaSBZNyBQcmltZSAyMDE4Kkh1YXdlaXxIdWF3ZWkgWTcgUHJvICgyMDE4KSpIdWF3ZWl8SVVOSSBVMipMZUVjb3xMZUVjbyBMZSAxcypMZUVjb3xMZUVjbyBMZSAyKkxlRWNvfExlRWNvIExlIE1heCAyKkxlRWNvfExlRWNvIExlIFBybyAzKkxlbm92b3xMZW5vdm8gQTUqTGVub3ZvfExlbm92byBBNjAwMCpMZW5vdm98TGVub3ZvIEE2MDAwIFBsdXMqTGVub3ZvfExlbm92byBBNjYwMCBQbHVzKkxlbm92b3xMZW5vdm8gSzMyMHQqTGVub3ZvfExlbm92byBLNSpMZW5vdm98TGVub3ZvIEs1IE5vdGUgKDIwMTgpKkxlbm92b3xMZW5vdm8gSzUgcGxheSpMZW5vdm98TGVub3ZvIEs2Kkxlbm92b3xMZW5vdm8gSzYgTm90ZSpMZW5vdm98TGVub3ZvIEs2IFBvd2VyKkxlbm92b3xMZW5vdm8gSzgqTGVub3ZvfExlbm92byBLOCBOb3RlKkxlbm92b3xMZW5vdm8gSzggUGx1cypMZW5vdm98TGVub3ZvIFAyKkxlbm92b3xMZW5vdm8gUzUqTGVub3ZvfExlbm92byBaNSpMZW5vdm98TGVub3ZvIFp1ayBFZGdlKkxlbm92b3xMZW5vdm8gWnVrIFoxKkxlbm92b3xMZW5vdm8gWnVrIFoyKkxlbm92b3xMZW5vdm8gWlVLIFoyIChQbHVzKSpMZW5vdm98TGVub3ZvIFp1ayBaMiBQcm8qTEd8TEcgQXJpc3RvIDIqTEd8TEcgRzIqTEd8TEcgRzMqTEd8TEcgRzUqTEd8TEcgRzYqTEd8TEcgRzcgRml0KkxHfExHIEc3IE9uZSpMR3xMRyBHNyBUaGluUSpMR3xMRyBHNyBUaGluUSBQbHVzKkxHfExHIEsxMCAyMDE4KkxHfExHIEsxMSBQbHVzKkxHfExHIEszMCpMR3xMRyBLOCAyMDE4KkxHfExHIE5leHVzIDVYKkxHfExHIFBhZCBJViA4LjAqTEd8TEcgUSBTdHlsdXMqTEd8TEcgUTYqTEd8TEcgUTcqTEd8TEcgUTgqTEd8TEcgVjEwKkxHfExHIFYyMCpMR3xMRyBWMzAqTEd8TEcgVjMwUyBUaGluUSpMR3xMRyBWMzUgVGhpblEqTEd8TEcgWCBWZW50dXJlKkxHfExHIFpvbmUgNCpNb3Rvcm9sYXxNb3RvIEMqTW90b3JvbGF8TW90byBFIDIwMTUqTW90b3JvbGF8TW90byBFNCpNb3Rvcm9sYXxNb3RvIEU0IFBsdXMqTW90b3JvbGF8TW90byBFNSpNb3Rvcm9sYXxNb3RvIEU1IFBsYXkqTW90b3JvbGF8TW90byBFNSBQbGF5IEdvKk1vdG9yb2xhfE1vdG8gRTUgUGx1cypNb3Rvcm9sYXxNb3RvIEcgMjAxMypNb3Rvcm9sYXxNb3RvIEcgMjAxNCpNb3Rvcm9sYXxNb3RvIEcgMjAxNSpNb3Rvcm9sYXxNb3RvIEc0Kk1vdG9yb2xhfE1vdG8gRzQgUGx1cypNb3Rvcm9sYXxNb3RvIEc1Kk1vdG9yb2xhfE1vdG8gRzUgUGx1cypNb3Rvcm9sYXxNb3RvIEc1UypNb3Rvcm9sYXxNb3RvIEc1UyBQbHVzKk1vdG9yb2xhfE1vdG8gRzYqTW90b3JvbGF8TW90byBHNiBQbGF5Kk1vdG9yb2xhfE1vdG8gRzYgUGx1cypNb3Rvcm9sYXxNb3RvIE0qTW90b3JvbGF8TW90byBYIFB1cmUqTW90b3JvbGF8TW90byBYNCpNb3Rvcm9sYXxNb3RvIFoqTW90b3JvbGF8TW90byBaIEZvcmNlKk1vdG9yb2xhfE1vdG8gWiBQbGF5Kk1vdG9yb2xhfE1vdG8gWjIgRm9yY2UqTW90b3JvbGF8TW90byBaMiBQbGF5Kk1vdG9yb2xhfE1vdG8gWjMqTW90b3JvbGF8TW90byBaMyBQbGF5Kk1vdG9yb2xhfE1vdG9yb2xhIE1vdG8gRTQqTW90b3JvbGF8TW90b3JvbGEgTW90byBHNiBQbHVzKk1vdG9yb2xhfE1vdG9yb2xhIE1vdG8gWCBQbGF5Kk1vdG9yb2xhfE1vdG9yb2xhIE9uZSBQb3dlcipNb3Rvcm9sYXxNb3Rvcm9sYSBQMzAqTW90b3JvbGF8TmV4dXMgNVgqTW90b3JvbGF8TmV4dXMgNlAqTW90b3JvbGF8TmV4dXMgUGxheWVyKk5va2lhfE5va2lhIDEqTm9raWF8Tm9raWEgMipOb2tpYXxOb2tpYSAyLjEqTm9raWF8Tm9raWEgMypOb2tpYXxOb2tpYSAzLjEqTm9raWF8Tm9raWEgNSpOb2tpYXxOb2tpYSA1LjEqTm9raWF8Tm9raWEgNS4xIFBsdXMqTm9raWF8Tm9raWEgNipOb2tpYXxOb2tpYSA2LjEqTm9raWF8Tm9raWEgNi4xIFBsdXMqTm9raWF8Tm9raWEgNypOb2tpYXxOb2tpYSA3IFBsdXMqTm9raWF8Tm9raWEgNy4xKk5va2lhfE5va2lhIDgqTm9raWF8Tm9raWEgOCBTaXJvY2NvKk5va2lhfE5va2lhIFg1Kk5va2lhfE5va2lhIFg2Kk5va2lhfE51YmlhIFoxNypPbmVQbHVzfE9uZVBsdXMgMipPbmVQbHVzfE9uZVBsdXMgMypPbmVQbHVzfE9uZVBsdXMgM1QqT25lUGx1c3xPbmVQbHVzIDUqT25lUGx1c3xPbmVQbHVzIDUvNVQqT25lUGx1c3xPbmVQbHVzIDVUKk9uZVBsdXN8T25lUGx1cyBPbmUqT25lUGx1c3xPbmVQbHVzIFgqUmVkbWl8UmVkbWkgM3MvM3gvUHJpbWUqUmVkbWl8UmVkbWkgNCBQcmltZSpSZWRtaXxSZWRtaSA0WCpSZWRtaXxSZWRtaSA1IFBsdXMqUmVkbWl8UmVkbWkgTm90ZSA1KlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTMgKDIwMTcpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTUgKDIwMTYpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTUgKDIwMTcpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTYgMjAxOCpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEE2KyAyMDE4KlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTcgKDIwMTYpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTcgKDIwMTcpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTggKDIwMTYpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTggKDIwMTcpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgQTggMjAxOCpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEE4IFN0YXIqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBBOCsgMjAxOCpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEE5IFBybypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEE5IFN0YXIqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBBbHBoYSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEM3IFBybypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEM5IFBybypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEdyYW5kIFByaW1lKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSipTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEoyIENvcmUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKMiBQcm8gKDIwMTgpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSjMgKDIwMTgpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSjQgKDIwMTgpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSjUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNSAoMjAxNykqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNiAoMjAxOCkqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNyAoMjAxOCkqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNyBEdW8qU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNyBNYXggKDIwMTcpKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSjcgUHJpbWUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKNyBQcmltZSAyKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgSjcgUHJvICgyMDE3KSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IEo3IFYqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBKOCAoMjAxOCkqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBNZWdhIDYuMypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IE5vdGUgMypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IE5vdGUgOCpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IE5vdGUgOSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IE5vdGUgRkUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBPbjYqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTMipTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFM0KlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgUzQgTWluaSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFM1IFtrbHRlXSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFM2KlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgUzcqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTNyBBY3RpdmUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTNyBFZGdlKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgUzgqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTOCBBY3RpdmUqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTOCBQbHVzKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgUzkqU2Ftc3VuZ3xTYW1zdW5nIEdhbGF4eSBTOSBQbHVzKlNhbXN1bmd8U2Ftc3VuZyBHYWxheHkgVGFiIEEgMTAuNSpTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFRhYiBBIDkuNypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFRhYiBFIDkuNipTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFRhYiBTMypTYW1zdW5nfFNhbXN1bmcgR2FsYXh5IFRhYiBTNCAxMC41KlNvbnl8U29ueSBYcGVyaWEgRTUqU29ueXxTb255IFhwZXJpYSBMMSpTb255fFNvbnkgWHBlcmlhIFIxIChQbHVzKSpTb255fFNvbnkgWHBlcmlhIFRvdWNoKlNvbnl8U29ueSBYcGVyaWEgWCpTb255fFNvbnkgWHBlcmlhIFggQ29tcGFjdCpTb255fFNvbnkgWHBlcmlhIFggUGVyZm9ybWFuY2UqU29ueXxTb255IFhwZXJpYSBYQSpTb255fFNvbnkgWHBlcmlhIFhBIFVsdHJhKlNvbnl8U29ueSBYcGVyaWEgWEExKlNvbnl8U29ueSBYcGVyaWEgWEExIFBsdXMqU29ueXxTb255IFhwZXJpYSBYQTEgVWx0cmEqU29ueXxTb255IFhwZXJpYSBYQTIqU29ueXxTb255IFhwZXJpYSBYQTIgUGx1cypTb255fFNvbnkgWHBlcmlhIFhBMiBVbHRyYSpTb255fFNvbnkgWHBlcmlhIFhaKlNvbnl8U29ueSBYcGVyaWEgWFogUHJlbWl1bSpTb255fFNvbnkgWHBlcmlhIFhaMSpTb255fFNvbnkgWHBlcmlhIFhaMSBDb21wYWN0KlNvbnl8U29ueSBYcGVyaWEgWFoyKlNvbnl8U29ueSBYcGVyaWEgWFoyIENvbXBhY3QqU29ueXxTb255IFhwZXJpYSBYWjIgUHJlbWl1bSpTb255fFNvbnkgWHBlcmlhIFhacypTb255fFNvbnkgWHBlcmlhIFoxKlNvbnl8U29ueSBYcGVyaWEgWjUqU29ueXxTb255IFhwZXJpYSBaNSBQcmVtaXVtKlNvbnl8U3ByaW50IEdhbGF4eSBUYWIgRSA4LjAqVml2b3x2aXZvIE5FWCpWaXZvfHZpdm8gTkVYIEEqVml2b3x2aXZvIE5FWCBTKlZpdm98dml2byBWMTEqVml2b3x2aXZvIFYxMSBQcm8qVml2b3x2aXZvIFYxMWkqVml2b3x2aXZvIFY3KlZpdm98dml2byBWNyBQbHVzKlZpdm98dml2byBWOSpWaXZvfHZpdm8gVjkgWW91dGgqVml2b3x2aXZvIFgyMCpWaXZvfHZpdm8gWDIwIFBsdXMqVml2b3x2aXZvIFgyMCBVRCpWaXZvfHZpdm8gWDIxKlZpdm98dml2byBYMjEgVUQqVml2b3x2aXZvIFgyMWkqVml2b3x2aXZvIFgyMypWaXZvfFZpdm8gWDkqVml2b3xWaXZvIFg5IFBsdXMqVml2b3xWaXZvIFg5cypWaXZvfFZpdm8gWDlzIFBsdXMqVml2b3x2aXZvIFk1M2kqVml2b3x2aXZvIFk3MSpWaXZvfHZpdm8gWTcxaSpWaXZvfHZpdm8gWTgxKlZpdm98dml2byBZODMqVml2b3x2aXZvIFk4MyBQcm8qVml2b3x2aXZvIFk5NypWaXZvfHZpdm8gWjEqVml2b3x2aXZvIFoxaSpWaXZvfFdpbGV5Zm94IFN3aWZ0KlhpYW9taXxYaWFvbWkgTWkgMypYaWFvbWl8WGlhb21pIE1pIDQqWGlhb21pfFhpYW9taSBNaSA1KlhpYW9taXxYaWFvbWkgTWkgNipYaWFvbWl8WGlhb21pIE1pIEExKlhpYW9taXxYaWFvbWkgTWkgQTIgTGl0ZSpYaWFvbWl8WGlhb21pIE1pIE1heCpYaWFvbWl8WGlhb21pIFBvY28gRjEqWGlhb21pfFhpYW9taSBSZWRtaSAyKlhpYW9taXxYaWFvbWkgUmVkbWkgNCBQcmltZSpYaWFvbWl8WGlhb21pIFJlZG1pIDRYKlhpYW9taXxYaWFvbWkgUmVkbWkgTm90ZSAzKlhpYW9taXxYaWFvbWkgUmVkbWkgTm90ZSA0KlhpYW9taXxYaWFvbWkgUmVkbWkgTm90ZSA1KlhpYW9taXxYaWFvbWkgUmVkbWkgTm90ZSA1IFBsdXMqWGlhb21pfFhpYW9taSBSZWRtaSBOb3RlIDUgUHJvKllVfFl1IEFjZSpZVXxZdSBZdW5pY29ybipZVXxZVSBZdW5pcXVlKllVfFl1IFl1bmlxdWUgMipZVXxZVSBZdXBob3JpYSpZVXxZVSBZdXJla2EqWVV8WVUgWXVyZWthIEJsYWNrKllVfFl1IFl1cmVrYSBOb3RlKllVfFl1IFl1cmVrYSBTKlpURXxaVEUgQXhvbiA3KlpURXxaVEUgQXhvbiA3IE1pbmkqWlRFfFpURSBBeG9uIDdzKlpURXxaVEUgQXhvbiA5IFBybypaVEV8WlRFIEF4b24gRWxpdGUqWlRFfFpURSBBeG9uIE1pbmkqWlRFfFpURSBBeG9uIFBybypaVEV8WlRFIEJsYWRlIEEzKlpURXxaVEUgQmxhZGUgQTYqWlRFfFpURSBCbGFkZSBWNypaVEV8WlRFIEJsYWRlIFY4KlpURXxaVEUgQmxhZGUgVjkqWlRFfFpURSBCbGFkZSBWOSBNaW5pKlpURXxaVEUgTWF2ZW4gMipaVEV8WlRFIE1heCBYTCpaVEV8WlRFIE51YmlhIFoxNypaVEV8WlRFIFRlbXBvIEdvKnhpYW9taXx4aWFvbWkgNipnb29nbGV8Z29vZ2xlIFBpeGVsIDIqeGlhb21pfHhpYW9taSA4Kmh1YXdlaXxodWF3ZWkgSG9ub3IgVjkqdml2b3x2aXZvIFg5IFBsdXMqb3Bwb3xvcHBvIHIxMSpvcHBvfG9wcG8gcjExIHBsdXMqb3Bwb3xvcHBvIFIxMSBQbHVzKm9wcG98b3BwbyBSMTcgUHJvKm1laXp1fG1laXp1IFBSTyA3IFBsdXMqbWVpenV8bWVpenUgUFJPIDYgUGx1cyp4aWFvbWl8eGlhb21pIG1peCp4aWFvbWl8bWkgMw==");
			return text.Split('*').ToList();
		}

		public string method_114()
		{
			try
			{
				string result = string.Empty;
				new Class50("configLDPlayer");
				string path = PathLDPlayer + "/vms/config/leidian" + int_0 + ".config";
				string json = File.ReadAllText(path);
				try
				{
					JObject jObject = JObject.Parse(json);
					result = jObject["propertySettings.phoneModel"]!.ToString();
				}
				catch
				{
					JObject jObject = new JObject();
				}
				return result;
			}
			catch
			{
			}
			return "";
		}

		public bool method_115(string string_12)
		{
			try
			{
				new Class50("configLDPlayer");
				string path = PathLDPlayer + "/vms/config/leidian" + int_0 + ".config";
				string json = File.ReadAllText(path);
				JObject jObject;
				try
				{
					jObject = JObject.Parse(json);
				}
				catch
				{
					jObject = new JObject();
				}
				jObject["statusSettings.sharedPictures"] = (JToken)string_12;
				File.WriteAllText(path, jObject.ToString());
				return true;
			}
			catch
			{
			}
			return false;
		}

		public bool method_116()
		{
			try
			{
				new Class50("configLDPlayer");
				string path = PathLDPlayer + "/vms/config/leidian" + int_0 + ".config";
				string json = File.ReadAllText(path);
				JObject jObject;
				try
				{
					jObject = JObject.Parse(json);
				}
				catch
				{
					jObject = new JObject();
				}
				jObject["statusSettings.playerName"] = (JToken)("LDPlayer-" + int_0);
				int num = ((Settings.Default.SizeLDFrom != 320) ? Settings.Default.SizeLDFrom : 320);
				int num2 = ((Settings.Default.SizeLDTo != 480) ? Settings.Default.SizeLDFrom : 480);
				int num3 = ((Settings.Default.DPILD != 120) ? Settings.Default.SizeLDFrom : 120);
				int num4 = Convert.ToInt32(Settings.Default.CpuLD.Split(' ')[0]);
				int num5 = Convert.ToInt32(Settings.Default.RamLD.Split('M')[0]);
				if (!jObject.ContainsKey("advancedSettings.resolution"))
				{
					jObject.Add("advancedSettings.resolution", new JObject
					{
						{
							"width",
							(JToken)num
						},
						{
							"height",
							(JToken)num2
						}
					});
				}
				else
				{
					jObject["advancedSettings.resolution"]!["width"] = (JToken)num;
					jObject["advancedSettings.resolution"]!["height"] = (JToken)num2;
				}
				jObject["advancedSettings.resolutionDpi"] = (JToken)num3;
				jObject["advancedSettings.cpuCount"] = (JToken)num4;
				jObject["advancedSettings.memorySize"] = (JToken)num5;
				jObject["statusSettings.sharedPictures"] = (JToken)LinkAvartar;
				if (Settings.Default.isAdbDebug)
				{
					jObject["basicSettings.adbDebug"] = (JToken)1;
				}
				File.WriteAllText(path, jObject.ToString());
				return true;
			}
			catch
			{
			}
			return false;
		}

		public void method_117()
		{
			Random random = new Random();
			List<string> list = method_113();
			string text = list[random.Next(0, list.Count)];
			string text2 = text.Split('|')[1];
			string text3 = text.Split('|')[0];
			string text4 = "86516602" + Common.smethod_80(7, random);
			string text5 = "46000" + Common.smethod_80(10, random);
			string text6 = "898600" + Common.smethod_80(14, random);
			string text7 = Common.smethod_79(Common.smethod_78(32, random), "x2").Substring(random.Next(0, 16), 16);
			string[] array = "+1205|+1251|+1659|+1256|+1334|+1907|+1520|+1928|+1480|+1602|+1623|+1501|+1479|+1870|+1341|+1442|+1628|+1657|+1669|+1747|+1752|+1764|+1951|+1209|+1559|+1408|+1831|+1510|+1213|+1310|+1424|+1323|+1562|+1707|+1369|+1627|+1530|+1714|+1949|+1626|+1909|+1916|+1760|+1619|+1858|+1935|+1818|+1415|+1925|+1661|+1805|+1650|+1211|+1720|+1970|+1303|+1719|+1203|+1475|+1860|+1959|+1302|+1411|+1202|+1911|+1239|+1386|+1689|+1754|+1941|+1954|+1561|+1407|+1727|+1352|+1904|+1850|+1786|+1863|+1305|+1321|+1813|+1470|+1478|+1770|+1678|+1404|+1706|+1912|+1229|+1710|+1671|+1808|+1208|+1312|+1773|+1630|+1847|+1708|+1815|+1224|+1331|+1464|+1872|+1217|+1618|+1309|+1260|+1317|+1219|+1765|+1812|+1563|+1641|+1515|+1319|+1712|+1876|+1620|+1785|+1913|+1316|+1270|+1859|+1606|+1502|+1225|+1337|+1985|+1504|+1318|+1207|+1227|+1240|+1443|+1667|+1410|+1301|+1339|+1351|+1774|+1781|+1857|+1978|+1508|+1617|+1413|+1231|+1269|+1989|+1734|+1517|+1313|+1810|+1248|+1278|+1586|+1679|+1947|+1906|+1616|+1320|+1612|+1763|+1952|+1218|+1507|+1651|+1228|+1601|+1557|+1573|+1636|+1660|+1975|+1314|+1816|+1417|+1664|+1406|+1402|+1308|+1775|+1702|+1506|+1603|+1551|+1848|+1862|+1732|+1908|+1201|+1973|+1609|+1856|+1505|+1575|+1585|+1845|+1917|+1516|+1212|+1646|+1315|+1518|+1347|+1718|+1607|+1914|+1631|+1716|+1252|+1336|+1828|+1910|+1980|+1984|+1919|+1704|+1701|+1283|+1380|+1567|+1216|+1614|+1937|+1330|+1234|+1440|+1419|+1740|+1513|+1580|+1918|+1405|+1541|+1971|+1445|+1610|+1835|+1878|+1484|+1717|+1570|+1412|+1215|+1267|+1814|+1724|+1787|+1939|+1401|+1306|+1803|+1843|+1864|+1605|+1731|+1865|+1931|+1423|+1615|+1901|+1325|+1361|+1430|+1432|+1469|+1682|+1737|+1979|+1214|+1972|+1254|+1940|+1713|+1281|+1832|+1956|+1817|+1806|+1903|+1210|+1830|+1409|+1936|+1512|+1915|+1340|+1385|+1435|+1801|+1802|+1276|+1434|+1540|+1571|+1757|+1703|+1804|+1509|+1206|+1425|+1253|+1360|+1564|+1304|+1262|+1920|+1414|+1715|+1608|+1307|+1867|+1866|+1456|+111|+1880|+1881|+1882|+1500|+1611|+1311|+1200|+1300|+1400|+1700|+1711|+1811|+1800|+1877|+1888|+8486|+8496|+8497|+8498|+8432|+8433|+8434|+8435|+8436|+8437|+8438|+8439|+8488|+8491|+8494|+8483|+8484|+8485|+8481|+8482|+8489|+8490|+8493|+8470|+8479|+8477|+8476|+8478|+8492|+8456|+8458|+8499|+8459".Split('|');
			string text8 = array[random.Next(array.Length)] + Common.smethod_80(7, random);
			string text9 = "00DB" + Common.smethod_79(Common.smethod_78(32, random), "x2").Substring(random.Next(0, 8), 8);
			string arguments = "modify --index " + int_0 + " --imei " + text4 + " --model \"" + text2 + "\" --manufacturer " + text3 + " --pnumber " + text8 + " --imsi " + text5 + " --simserial " + text6 + " --androidid " + text7 + " --mac " + text9.ToUpper();
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = PathLDPlayer + "\\dnconsole.exe",
				Arguments = arguments,
				UseShellExecute = false,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			};
			process.Start();
			process.WaitForExit(5000);
		}

		public void method_118(int int_4 = 120)
		{
			Class2.smethod_30(PathLDPlayer, int_0);
			int tickCount = Environment.TickCount;
			try
			{
				int num = 0;
				do
				{
					process = (from process_1 in Process.GetProcessesByName("dnplayer")
							   where process_1.MainWindowTitle.Equals("LDPlayer-" + int_0)
							   select process_1).FirstOrDefault();
					if (process == null)
					{
						num++;
						if (num % 5 == 0)
						{
							Class2.smethod_30(PathLDPlayer, int_0);
						}
						method_121(1.0);
						continue;
					}
					break;
				}
				while (Environment.TickCount - tickCount <= int_4 * 1000);
			}
			catch
			{
			}
		}

		private List<string> method_119(string string_12, string string_13)
		{
			List<string> list = new List<string>();
			try
			{
				MatchCollection matchCollection = Regex.Matches(string_12, string_13);
				for (int i = 0; i < matchCollection.Count; i++)
				{
					if (!string.IsNullOrEmpty(matchCollection[i].Groups[1].Value))
					{
						list.Add(matchCollection[i].Groups[1].Value);
					}
				}
			}
			catch (Exception)
			{
			}
			return list;
		}

		public List<string> method_120(string string_12 = "", int int_4 = 0)
		{
			if (string_12 == "")
			{
				string_12 = method_93();
			}
			List<string> collection = method_119(string_12, "text=\"(.*?)\"");
			List<string> collection2 = method_119(string_12, "content-desc=\"(.*?)\"");
			List<string> collection3 = method_119(string_12, "text='(.*?)'");
			List<string> collection4 = method_119(string_12, "content-desc='(.*?)'");
			List<string> list = new List<string>();
			switch (int_4)
			{
				case 0:
					list.AddRange(collection);
					list.AddRange(collection2);
					list.AddRange(collection3);
					list.AddRange(collection4);
					break;
				case 1:
					list.AddRange(collection);
					list.AddRange(collection3);
					break;
				case 2:
					list.AddRange(collection2);
					list.AddRange(collection4);
					break;
			}
			return list;
		}

		public void method_121(double double_0)
		{
			if (method_129())
			{
				Application.DoEvents();
				Thread.Sleep(Convert.ToInt32(double_0 * 400.0));
			}
		}

		public void method_122()
		{
			method_85(string.Format(Class1.string_0, string_7, "com.facebook.katana"), 3);
		}

		public void method_123()
		{
			method_85(string.Format(Class1.string_0, string_7, "com.facebook.lite"), 3);
		}

		public void method_124()
		{
			method_85(string.Format(Class1.string_0, string_4, "com.facebook.katana"), 3);
		}

		public void method_125()
		{
			method_85(string.Format(Class1.string_0, string_10, "com.facebook.lite"), 3);
		}

		public void method_126(string string_12)
		{
			string arg = string_11 + string_12;
			method_85(string.Format(Class1.string_0, arg, "com.facebook.lite"), 3);
		}

		public void method_127()
		{
			method_85(string.Format(Class1.string_0, string_8, "com.facebook.katana"), 3);
		}

		public void method_128()
		{
			method_85(string.Format(Class1.string_0, string_9, "com.facebook.katana"), 3);
		}

		public bool method_129()
		{
			return process == null || !process.HasExited;
		}

		public void method_130(string string_12)
		{
			if (frmViewLD.frmViewLD_0 != null)
			{
				frmViewLD.frmViewLD_0.method_7(int_0, string_12);
			}
		}

		public string method_131(string string_12)
		{
			return Class2.smethod_11(DeviceId, string_12);
		}

		[CompilerGenerated]
		private bool method_132(Process process_1)
		{
			return process_1.MainWindowTitle.Equals("LDPlayer-" + int_0);
		}
	}
}
