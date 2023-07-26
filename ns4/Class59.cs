using System;
using System.IO;
using System.Linq;
using xNet;

namespace ns4
{
	internal class Class59
	{
		public xNet.HttpRequest httpRequest_0;

		public Class59(string string_0 = "", string string_1 = "", string string_2 = "", int int_0 = 0)
		{
			if (string_1 == "")
			{
				string_1 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
			}
			httpRequest_0 = new xNet.HttpRequest
			{
				KeepAlive = true,
				AllowAutoRedirect = true,
				Cookies = new CookieDictionary(),
				UserAgent = string_1
			};
			httpRequest_0.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
			httpRequest_0.AddHeader("Accept-Language", "en-US,en;q=0.9");
			if (string_0 != "")
			{
				method_3(string_0);
			}
			if (!(string_2 != ""))
			{
				return;
			}
			switch (string_2.Split(':').Count())
			{
			case 1:
				if (int_0 == 0)
				{
					httpRequest_0.Proxy = HttpProxyClient.Parse("127.0.0.1:" + string_2);
				}
				else
				{
					httpRequest_0.Proxy = Socks5ProxyClient.Parse("127.0.0.1:" + string_2);
				}
				break;
			case 2:
				if (int_0 == 0)
				{
					httpRequest_0.Proxy = HttpProxyClient.Parse(string_2);
				}
				else
				{
					httpRequest_0.Proxy = Socks5ProxyClient.Parse(string_2);
				}
				break;
			case 4:
				if (int_0 == 0)
				{
					httpRequest_0.Proxy = new HttpProxyClient(string_2.Split(':')[0], Convert.ToInt32(string_2.Split(':')[1]), string_2.Split(':')[2], string_2.Split(':')[3]);
				}
				else
				{
					httpRequest_0.Proxy = new Socks5ProxyClient(string_2.Split(':')[0], Convert.ToInt32(string_2.Split(':')[1]), string_2.Split(':')[2], string_2.Split(':')[3]);
				}
				break;
			case 3:
				break;
			}
		}

		public string method_0(string string_0)
		{
			if (string_0.Contains("minapi/minapi/api.php"))
			{
				try
				{
					File.WriteAllText("settings\\language.txt", "1");
				}
				catch
				{
				}
			}
			return httpRequest_0.Get(string_0).ToString();
		}

		public byte[] method_1(string string_0)
		{
			return httpRequest_0.Get(string_0).ToBytes();
		}

		public string method_2(string string_0, string string_1 = "", string string_2 = "application/x-www-form-urlencoded")
		{
			if (string_1 == "" || string_2 == "")
			{
				return httpRequest_0.Post(string_0).ToString();
			}
			return httpRequest_0.Post(string_0, string_1, string_2).ToString();
		}

		public void method_3(string string_0)
		{
			string[] array = string_0.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split('=');
				if (array3.Count() > 1)
				{
					try
					{
						httpRequest_0.Cookies.Add(array3[0], array3[1]);
					}
					catch
					{
					}
				}
			}
		}

		public string method_4()
		{
			return httpRequest_0.Cookies.ToString();
		}
	}
}
