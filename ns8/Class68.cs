using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ns0;
using ToolRegFB;

namespace ns8
{
	internal class Class68
	{
		[CompilerGenerated]
		private sealed class Class69
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

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_6;

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

		public int timeout
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

		public int port
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

		public Class68(string string_3, int int_7, int int_8)
		{
			api_key = string_3;
			proxy = "";
			ip = "";
			port = 0;
			next_change = 0;
			typeProxy = int_7;
			int_2 = int_8;
			int_0 = 0;
			int_1 = 0;
		}

		public static bool smethod_0(string string_3)
		{
			string string_4 = "{\"api_key\": \"" + string_3 + "\"}";
			string text = smethod_1("https://tmproxy.com/api/proxy/stats", string_4);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					string text2 = jObject["data"]!["expired_at"]!.ToString();
					DateTime t = Common.smethod_3(text2, "HH:mm:ss dd/MM/yyyy");
					if (DateTime.Compare(t, DateTime.Now) > 0)
					{
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		public string method_0()
		{
			lock (object_0)
			{
				if (int_0 == 0)
				{
					if (int_1 > 0 && int_1 < int_2)
					{
						if (method_1() < 30 && !method_4())
						{
							return "0";
						}
					}
					else if (!method_4())
					{
						return "0";
					}
				}
				else
				{
					if (int_1 >= int_2)
					{
						return "2";
					}
					if (method_1() < 30 && !method_4())
					{
						return "0";
					}
				}
				int_1++;
				int_0++;
				return "1";
			}
		}

		public int method_1()
		{
			method_6();
			return timeout;
		}

		public void method_2(int int_7)
		{
			lock (object_1)
			{
				int_0--;
				if (int_7 == 1 && method_1() > 1580)
				{
					int_1--;
				}
				if (int_0 == 0 && int_1 == int_2)
				{
					int_1 = 0;
				}
			}
		}

		public string method_3(string string_3)
		{
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_3));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		public bool method_4()
		{
			next_change = 0;
			proxy = "";
			ip = "";
			port = 0;
			string arg = "abccd9f3bf38f38414cb87e36f76c8e4";
			int num = 8989;
			string value = method_5("https://tmproxy.com/api/proxy/current-time");
			long num2 = 0L;
			try
			{
				num2 = Convert.ToInt64(value);
			}
			catch
			{
				num2 = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			}
			long num3 = Convert.ToInt64(num2 / 60L) + num;
			string string_ = $"{arg}{api_key}{num3}";
			string text = method_3(string_);
			string string_2 = "{\"api_key\": \"" + api_key + "\",\"sign\": \"" + text + "\"}";
			string text2 = smethod_1("https://tmproxy.com/api/proxy/get-new-proxy", string_2);
			if (text2 != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text2);
					string value2 = Regex.Match(JObject.Parse(text2)["message"]!.ToString(), "\\d+").Value;
					next_change = ((!(value2 == "")) ? int.Parse(value2) : 0);
					if (next_change == 0)
					{
						if (typeProxy == 0)
						{
							proxy = jObject["data"]!["https"]!.ToString();
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

		private string method_5(string string_3)
		{
			string text = "";
			try
			{
				text = new Class58().method_0(string_3);
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			catch
			{
			}
			return text;
		}

		public bool method_6()
		{
			next_change = 0;
			proxy = "";
			ip = "";
			port = 0;
			timeout = 0;
			string string_ = "{\"api_key\": \"" + api_key + "\"}";
			string text = smethod_1("https://tmproxy.com/api/proxy/get-current-proxy", string_);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject["code"]!.ToString() == "0")
					{
						next_change = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
						timeout = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
						if (typeProxy == 0)
						{
							proxy = jObject["data"]!["https"]!.ToString();
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

		public string method_7()
		{
			while (!method_6())
			{
			}
			return proxy;
		}

		private static string smethod_1(string string_3, string string_4)
		{
			string text = "";
			try
			{
				using WebClient webClient = new WebClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
				text = webClient.UploadString(string_3, string_4);
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request Post");
				text = "";
			}
			return text;
		}

		public static string smethod_2(string string_3)
		{
			string text = "";
			try
			{
				new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run(() => smethod_4(new Uri(string_3)));
				task.Wait();
				return task.Result;
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Request get");
				return "";
			}
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
