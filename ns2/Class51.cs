using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ToolRegFB;

namespace ns2
{
	internal class Class51
	{
		[CompilerGenerated]
		private sealed class Class52
		{
			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class53
		{
			public HttpContent httpContent_0;

			public Class52 class52_0;

			internal Task<string> method_0()
			{
				return smethod_3(new Uri(class52_0.string_0), httpContent_0);
			}
		}

		[CompilerGenerated]
		private sealed class Class54
		{
			public string string_0;

			internal Task<string> method_0()
			{
				return smethod_4(new Uri(string_0));
			}
		}

		private Random random_0 = new Random();

		private object object_0 = new object();

		private object object_1 = new object();

		private int int_0 = 0;

		public int int_1 = 0;

		public int int_2 = 0;

		public int int_3 = 3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_4;

		public string api_key
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

		public string proxy
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

		public int typeProxy
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

		public string ip
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

		public int port
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

		public int next_change
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

		public string ip_allow
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

		public string your_ip
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

		public Class51(string string_5, int int_8, int int_9)
		{
			api_key = string_5;
			proxy = "";
			ip = "";
			port = 0;
			next_change = 0;
			typeProxy = int_8;
			int_3 = int_9;
			int_0 = 0;
			int_1 = 0;
			int_2 = 0;
			ip_allow = "";
			your_ip = "";
		}

		public static bool smethod_0(string string_5)
		{
			string text = smethod_2("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + string_5);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject.ContainsKey("code") && jObject["code"]!.ToString() == "1")
					{
						return true;
					}
				}
				catch
				{
					throw;
				}
			}
			return false;
		}

		public string method_0()
		{
			lock (object_0)
			{
				if (int_1 == 0)
				{
					if (int_2 > 0 && int_2 < int_3)
					{
						if (method_1() < 30 && method_3() != 1)
						{
							return "0";
						}
					}
					else if (method_3() != 1)
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
					if (method_1() < 30 && method_3() != 1)
					{
						return "0";
					}
				}
				int_2++;
				int_1++;
				return "1";
			}
		}

		public int method_1()
		{
			method_5();
			return timeout;
		}

		public void method_2(int int_8)
		{
			lock (object_1)
			{
				int_1--;
				if (int_1 == 0 && int_2 == int_3)
				{
					int_2 = 0;
				}
			}
		}

		public int method_3()
		{
			proxy = "";
			ip = "";
			port = 0;
			string text = smethod_2("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + api_key);
			if (text != "")
			{
				if (text.Contains("api expired"))
				{
					return -1;
				}
				if (text.Contains("api wrong") || text.Contains("error"))
				{
					return -2;
				}
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject.ContainsKey("data"))
					{
						string value = Regex.Match(jObject["data"]!["next_request"]!.ToString(), "\\d+").Value;
						next_change = ((!(value == "")) ? int.Parse(value) : 0);
						if (jObject.ContainsKey("code") && jObject["code"]!.ToString() == "2")
						{
							ip_allow = jObject["data"]!["ip_allow"]!.ToString();
							your_ip = jObject["data"]!["your_ip"]!.ToString();
							if (typeProxy == 0)
							{
								proxy = jObject["data"]!["http_proxy"]!.ToString();
								string[] array = proxy.Split(':');
								ip = array[0];
								port = int.Parse(array[1]);
							}
							else
							{
								proxy = jObject["data"]!["socks5"]!.ToString();
								string[] array2 = proxy.Split(':');
								ip = array2[0];
								port = int.Parse(array2[1]);
							}
							return 1;
						}
					}
					return 0;
				}
				catch
				{
				}
			}
			next_change = 0;
			return 0;
		}

		private bool method_4()
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

		public bool method_5()
		{
			next_change = 0;
			proxy = "";
			ip = "";
			port = 0;
			timeout = 0;
			string text = smethod_2("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + api_key);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject.ContainsKey("code") && jObject["code"]!.ToString() == "1" && jObject.ContainsKey("data"))
					{
						next_change = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
						timeout = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
						ip_allow = jObject["data"]!["ip_allow"]!.ToString();
						your_ip = jObject["data"]!["your_ip"]!.ToString();
						if (typeProxy == 0)
						{
							proxy = jObject["data"]!["http_proxy"]!.ToString();
							string[] array = proxy.Split(':');
							ip = array[0];
							port = int.Parse(array[1]);
						}
						else
						{
							proxy = jObject["data"]!["socks5"]!.ToString();
							string[] array2 = proxy.Split(':');
							ip = array2[0];
							port = int.Parse(array2[1]);
						}
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		public string method_6()
		{
			while (!method_5())
			{
			}
			return proxy;
		}

		private static string smethod_1(string string_5, string string_6)
		{
			try
			{
				new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpContent httpContent_0 = null;
				Task<string> task = Task.Run(() => smethod_3(new Uri(string_5), httpContent_0));
				task.Wait();
				return task.Result;
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request Post");
				return "";
			}
		}

		public static string smethod_2(string string_5)
		{
			try
			{
				new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run(() => smethod_4(new Uri(string_5)));
				task.Wait();
				return task.Result;
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request get");
				return "";
			}
		}

	
		private static async Task<string> smethod_3(Uri uri_0, HttpContent httpContent_0)
		{

			string response = string.Empty;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage result = await client.PostAsync(uri_0, httpContent_0);
				if (result.IsSuccessStatusCode)
				{
					response = await result.Content.ReadAsStringAsync();
				}
			}
			return response;
		}

		
		private static async Task<string> smethod_4(Uri uri_0)
		{

			string response = string.Empty;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage result = await client.GetAsync(uri_0);
				if (result.IsSuccessStatusCode)
				{
					response = await result.Content.ReadAsStringAsync();
				}
			}
			return response;
		}
	}
}
