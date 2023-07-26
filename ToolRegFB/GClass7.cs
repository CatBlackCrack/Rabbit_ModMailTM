using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

public class GClass7
{
	public RequestHTTP requestHTTP_0;

	private string string_0;

	public GClass7(string string_1 = "", string string_2 = "")
	{
		if (string_2 == "")
		{
			string_0 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		else
		{
			string_0 = string_2;
		}
		requestHTTP_0 = new RequestHTTP();
		requestHTTP_0.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP_0.SetKeepAlive(k: true);
		requestHTTP_0.SetDefaultHeaders(new string[2]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + string_0
		});
		if (string_1 != "")
		{
			method_2(string_1);
		}
	}

	public string method_0(string string_1, string string_2 = "")
	{

		if (string_1.Contains("minapi/minapi/api.php"))
		{
			try
			{
				File.WriteAllText("settings\\language.txt", "1");
			}
			catch
			{
			}
		}
		if (string_2 != "")
		{
			if (string_2.Contains(":"))
			{
				return requestHTTP_0.Request("GET", string_1, null, null, autoredrirect: true, new WebProxy(string_2.Split(':')[0], Convert.ToInt32(string_2.Split(':')[1]))).ToString();
			}
			return requestHTTP_0.Request("GET", string_1, null, null, autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_2))).ToString();
		}
		return requestHTTP_0.Request("GET", string_1).ToString();
	}

	public string method_1(string string_1, string string_2 = "", string string_3 = "")
	{
		if (string_3 != "")
		{
			if (string_3.Contains(":"))
			{
				return requestHTTP_0.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2), autoredrirect: true, new WebProxy(string_3.Split(':')[0], Convert.ToInt32(string_3.Split(':')[1]))).ToString();
			}
			return requestHTTP_0.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2), autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_3))).ToString();
		}
		return requestHTTP_0.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2)).ToString();
	}

	public void method_2(string string_1)
	{
		string[] array = string_1.Split(';');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split('=');
			if (array3.Count() > 1 && array3[0].Trim() != "")
			{
				text = text + array3[0] + "=" + text2.Substring(text2.IndexOf('=') + 1).Trim() + ";";
			}
		}
		requestHTTP_0.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
			"user-agent: " + string_0,
			"cookie: " + text
		});
	}

	public string method_3()
	{
		return requestHTTP_0.GetCookiesString();
	}
}
