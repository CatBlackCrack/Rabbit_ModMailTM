using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns4;

namespace ns9
{
	internal class Class67
	{
		private object object_0 = new object();

		private object object_1 = new object();

		public string string_0 = "";

		private string string_1 = "http://proxy.tinsoftsv.com";

		private int int_0 = 0;

		public bool bool_0 = true;

		public int int_1 = 0;

		public int int_2 = 0;

		public int int_3 = 3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_7;

		public string api_key
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

		public string proxy
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
			[CompilerGenerated]
			set
			{
				string_3 = value;
			}
		}

		public string ip
		{
			[CompilerGenerated]
			get
			{
				return string_4;
			}
			[CompilerGenerated]
			set
			{
				string_4 = value;
			}
		}

		public int port
		{
			[CompilerGenerated]
			get
			{
				return int_4;
			}
			[CompilerGenerated]
			set
			{
				int_4 = value;
			}
		}

		public int timeout
		{
			[CompilerGenerated]
			get
			{
				return int_5;
			}
			[CompilerGenerated]
			set
			{
				int_5 = value;
			}
		}

		public int next_change
		{
			[CompilerGenerated]
			get
			{
				return int_6;
			}
			[CompilerGenerated]
			set
			{
				int_6 = value;
			}
		}

		public int location
		{
			[CompilerGenerated]
			get
			{
				return int_7;
			}
			[CompilerGenerated]
			set
			{
				int_7 = value;
			}
		}

		public Class67(string string_5, int int_8, int int_9 = 0)
		{
			api_key = string_5;
			proxy = "";
			ip = "";
			port = 0;
			timeout = 0;
			next_change = 0;
			location = int_9;
			int_3 = int_8;
			int_1 = 0;
			int_2 = 0;
			bool_0 = true;
		}

		public string method_0()
		{
			lock (object_0)
			{
				if (int_1 == 0)
				{
					if (int_2 > 0 && int_2 < int_3)
					{
						if (method_4() < 30 && !method_2())
						{
							return "0";
						}
					}
					else if (!method_2())
					{
						return "0";
					}
				}
				else
				{
					if (int_2 >= int_3)
					{
						return "2";
					}
					if (method_4() < 30 && !method_2())
					{
						return "0";
					}
				}
				int_2++;
				int_1++;
				return "1";
			}
		}

		public void method_1(int int_8)
		{
			lock (object_1)
			{
				if (int_8 == 1 && method_4() > 1580)
				{
					int_2--;
				}
				int_1--;
				if (int_1 == 0 && int_2 == int_3)
				{
					int_2 = 0;
				}
			}
		}

		public bool method_2()
		{
			lock (object_1)
			{
				if (method_7())
				{
					string_0 = "";
					next_change = 0;
					proxy = "";
					ip = "";
					port = 0;
					timeout = 0;
					string text = method_8(string_1 + "/api/changeProxy.php?key=" + api_key + "&location=" + location);
					if (text != "")
					{
						try
						{
							JObject jObject = JObject.Parse(text);
							if (bool.Parse(jObject["success"]!.ToString()))
							{
								proxy = jObject["proxy"]!.ToString();
								string[] array = proxy.Split(':');
								ip = array[0];
								port = int.Parse(array[1]);
								timeout = int.Parse(jObject["timeout"]!.ToString());
								next_change = int.Parse(jObject["next_change"]!.ToString());
								string_0 = "";
								return true;
							}
							string_0 = jObject["description"]!.ToString();
							next_change = int.Parse(jObject["next_change"]!.ToString());
						}
						catch
						{
						}
					}
					else
					{
						string_0 = "request server timeout!";
					}
				}
				else
				{
					string_0 = "Request so fast!";
				}
				return false;
			}
		}

		public string method_3()
		{
			while (!method_6())
			{
			}
			return proxy;
		}

		public int method_4()
		{
			while (!method_6())
			{
			}
			return timeout;
		}

		public int method_5()
		{
			while (!method_6())
			{
			}
			return next_change;
		}

		public bool method_6()
		{
			lock (object_1)
			{
				string_0 = "";
				next_change = 0;
				proxy = "";
				ip = "";
				port = 0;
				timeout = 0;
				string text = method_8(string.Concat(new object[3] { string_1, "/api/getProxy.php?key=", api_key }));
				if (text != "")
				{
					try
					{
						JObject jObject = JObject.Parse(text);
						if (bool.Parse(jObject["success"]!.ToString()))
						{
							proxy = jObject["proxy"]!.ToString();
							string[] array = proxy.Split(':');
							ip = array[0];
							port = int.Parse(array[1]);
							timeout = int.Parse(jObject["timeout"]!.ToString());
							next_change = int.Parse(jObject["next_change"]!.ToString());
							string_0 = "";
							return true;
						}
						string_0 = jObject["description"]!.ToString();
						if (jObject["next_change"] != null)
						{
							next_change = int.Parse(jObject["next_change"]!.ToString());
						}
					}
					catch (Exception)
					{
					}
				}
				else
				{
					string_0 = "request server timeout!";
				}
				return false;
			}
		}

		private bool method_7()
		{
			try
			{
				DateTime dateTime = new DateTime(2001, 1, 1);
				long ticks = DateTime.Now.Ticks - dateTime.Ticks;
				int num = (int)new TimeSpan(ticks).TotalSeconds;
				if (num - int_0 >= 10)
				{
					int_0 = num;
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		private string method_8(string string_5)
		{
			Console.WriteLine(string_5);
			string text = "";
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(string_5);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		private static string smethod_0(string string_5)
		{
			Console.WriteLine(string_5);
			string text = "";
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(string_5);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		public static bool smethod_1(string string_5)
		{
			string text = smethod_0("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + string_5);
			if (text != "")
			{
				JObject jObject = JObject.Parse(text);
				if (bool.Parse(jObject["success"]!.ToString()))
				{
					return true;
				}
			}
			return false;
		}

		public static List<string> smethod_2(string string_5)
		{
			List<string> list = new List<string>();
			try
			{
				Class59 @class = new Class59("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
				string json = @class.method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + string_5);
				JObject jObject = JObject.Parse(json);
				foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
				{
					if (Convert.ToBoolean(item["success"]!.ToString()))
					{
						list.Add(item["key"]!.ToString());
					}
				}
			}
			catch
			{
			}
			return list;
		}

		public static List<string> smethod_3()
		{
			return new List<string>
			{
				"0|Random", "1|Ha Noi", "2|Phu Tho", "3|Ho Chi Minh", "4|Dak Lak", "5|Hai Duong", "6|Binh Dinh", "7|Nghe An", "8|Nam Dinh", "10|Thai Binh",
				"11|Ha Tinh"
			};
		}
	}
}
