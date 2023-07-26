using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ToolRegFB;

namespace ns2
{
	internal class Class61
	{
		[CompilerGenerated]
		private sealed class Class62
		{
			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class63
		{
			public HttpContent httpContent_0;

			public Class62 class62_0;

			internal Task<string> method_0()
			{
				return smethod_2(new Uri(class62_0.string_0), httpContent_0);
			}
		}

		[CompilerGenerated]
		private sealed class Class64
		{
			public string string_0;

			internal Task<string> method_0()
			{
				return smethod_3(new Uri(string_0));
			}
		}

		private Random random_0 = new Random();

		private object object_0 = new object();

		public int int_0 = 0;

		public int int_1 = 0;

		public int int_2 = 3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

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
				return int_3;
			}
			[CompilerGenerated]
			set
			{
				int_3 = value;
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

		public Class61(string string_3, int int_5, int int_6)
		{
			api_key = string_3;
			proxy = "";
			ip = "";
			port = 0;
			typeProxy = int_5;
			int_2 = int_6;
			int_0 = 0;
			int_1 = 0;
		}

		public void method_0(int int_5)
		{
			lock (object_0)
			{
				int_0--;
				if (int_5 == 1)
				{
					int_1--;
				}
				if (int_0 == 0 && int_1 == int_2)
				{
					int_1 = 0;
				}
			}
		}

		public bool method_1()
		{
			proxy = "";
			ip = "";
			port = 0;
			string text = smethod_1("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + api_key);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject["status"]!.ToString() == "success")
					{
						if (typeProxy == 0)
						{
							proxy = jObject["data"]!["proxy"]!.ToString();
							string[] array = proxy.Split(':');
							ip = array[0];
							port = int.Parse(array[1]);
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

		public bool method_2()
		{
			proxy = "";
			ip = "";
			port = 0;
			string text = smethod_1("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + api_key);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject["status"]!.ToString() == "success")
					{
						proxy = jObject["data"]!["proxy"]!.ToString();
						string[] array = proxy.Split(':');
						ip = array[0];
						port = int.Parse(array[1]);
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		public string method_3()
		{
			while (!method_2())
			{
			}
			return proxy;
		}

		private static string smethod_0(string string_3, string string_4)
		{
			try
			{
				new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpContent httpContent_0 = null;
				Task<string> task = Task.Run(() => smethod_2(new Uri(string_3), httpContent_0));
				task.Wait();
				return task.Result;
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request Post");
				return "";
			}
		}

		public static string smethod_1(string string_3)
		{
			try
			{
				new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run(() => smethod_3(new Uri(string_3)));
				task.Wait();
				return task.Result;
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request get");
				return "";
			}
		}

		
		private static async Task<string> smethod_2(Uri uri_0, HttpContent httpContent_0)
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

		
		private static async Task<string> smethod_3(Uri uri_0)
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
