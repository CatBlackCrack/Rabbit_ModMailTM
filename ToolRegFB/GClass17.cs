using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

// Token: 0x02000052 RID: 82
public class GClass17
{
	// Token: 0x06000345 RID: 837 RVA: 0x00023384 File Offset: 0x00021584
	public GClass17(string string_2 = "", string string_3 = "", string string_4 = "", int int_0 = 0)
	{
		if (string_3 == "")
		{
			this.string_0 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		else
		{
			this.string_0 = string_3;
		}
		this.requestHTTP_0 = new RequestHTTP();
		this.requestHTTP_0.SetSSL(SecurityProtocolType.Tls12);
		this.requestHTTP_0.SetKeepAlive(true);
		this.requestHTTP_0.SetDefaultHeaders(new string[]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + this.string_0
		});
		if (string_2 != "")
		{
			this.method_2(string_2);
		}
		this.string_1 = string_4;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00023428 File Offset: 0x00021628
	public string method_0(string string_2)
	{
		if (string_2.Contains("minapi/minapi/api.php"))
		{
			try
			{
				File.WriteAllText("settings\\language.txt", "1");
			}
			catch
			{
			}
		}
		string result;
		if (this.string_1 != "")
		{
			if (this.string_1.Contains(":"))
			{
				result = this.requestHTTP_0.Request("GET", string_2, null, null, true, new WebProxy(this.string_1.Split(new char[]
				{
					':'
				})[0], Convert.ToInt32(this.string_1.Split(new char[]
				{
					':'
				})[1])), 60000).ToString();
			}
			else
			{
				result = this.requestHTTP_0.Request("GET", string_2, null, null, true, new WebProxy("127.0.0.1", Convert.ToInt32(this.string_1)), 60000).ToString();
			}
		}
		else
		{
			result = this.requestHTTP_0.Request("GET", string_2, null, null, true, null, 60000).ToString();
		}
		return result;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00023540 File Offset: 0x00021740
	public string method_1(string string_2, string string_3 = "")
	{
		string result;
		if (this.string_1 != "")
		{
			if (this.string_1.Contains(":"))
			{
				result = this.requestHTTP_0.Request("POST", string_2, null, Encoding.ASCII.GetBytes(string_3), true, new WebProxy(this.string_1.Split(new char[]
				{
					':'
				})[0], Convert.ToInt32(this.string_1.Split(new char[]
				{
					':'
				})[1])), 60000).ToString();
			}
			else
			{
				result = this.requestHTTP_0.Request("POST", string_2, null, Encoding.ASCII.GetBytes(string_3), true, new WebProxy("127.0.0.1", Convert.ToInt32(this.string_1)), 60000).ToString();
			}
		}
		else
		{
			result = this.requestHTTP_0.Request("POST", string_2, null, Encoding.ASCII.GetBytes(string_3), true, null, 60000).ToString();
		}
		return result;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00023644 File Offset: 0x00021844
	public void method_2(string string_2)
	{
		string[] array = string_2.Split(new char[]
		{
			';'
		});
		string text = "";
		foreach (string text2 in array)
		{
			string[] array3 = text2.Split(new char[]
			{
				'='
			});
			if (array3.Count<string>() > 1)
			{
				try
				{
					text = string.Concat(new string[]
					{
						text,
						array3[0],
						"=",
						array3[1],
						";"
					});
				}
				catch
				{
				}
			}
		}
		this.requestHTTP_0.SetDefaultHeaders(new string[]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
			"user-agent: " + this.string_0,
			"cookie: " + text
		});
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0002371C File Offset: 0x0002191C
	public string method_3()
	{
		return this.requestHTTP_0.GetCookiesString();
	}

	// Token: 0x04000256 RID: 598
	public RequestHTTP requestHTTP_0;

	// Token: 0x04000257 RID: 599
	private string string_0;

	// Token: 0x04000258 RID: 600
	private string string_1;
}
