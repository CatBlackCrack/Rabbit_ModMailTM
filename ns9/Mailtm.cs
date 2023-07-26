using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace ns9
{ 

	public class Mailtm
	{
		public string getdomains()
		{
			string result = string.Empty;
			string requestUriString = "https://api.mail.tm/domains?page=1";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Accept = "application/json";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				string text = streamReader.ReadToEnd();
				if (text != "" && text != null)
				{
					result = Regex.Match(text, "domain\":\"(.*?)\"").Groups[1].Value;
				}
			}
			return result;
		}

		public bool Create_Mailtm(string email, string password, string strProxy)
		{
			string requestUriString = "https://api.mail.tm/accounts";
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Method = "POST";
				if (strProxy != "")
				{
					if (strProxy.Split(':').Length == 4)
					{
						httpWebRequest.Proxy = WebRequest.DefaultWebProxy;
						httpWebRequest.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
						httpWebRequest.Proxy.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
					}
					else if (strProxy.Split(':').Length == 2)
					{
						httpWebRequest.Proxy = new WebProxy(strProxy.Split(':')[0], int.Parse(strProxy.Split(':')[1]));
					}
				}
				httpWebRequest.Accept = "application/json, text/plain, */*";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
				httpWebRequest.Referer = "https://mail.tm/";
				httpWebRequest.Headers["origin"] = "https://mail.tm";
				httpWebRequest.ContentType = "application/json";
				string value = "{\"address\":\"" + email + "\",\"password\":\"" + password + "\"}";
				using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
				{
					streamWriter.Write(value);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text = streamReader.ReadToEnd();
				if (text.Contains(email.ToLower()))
				{
					Console.WriteLine("Susscess: " + email);
					return true;
				}
				Console.WriteLine("Fail: " + email);
				return false;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error mail tm: " + ex.Message);
				return false;
			}
		}

		public string GetCodeMailTm(string email, string password, string strProxy)
		{
			string text = string.Empty;
			string result = string.Empty;
			string requestUriString = "https://api.mail.tm/token";
			string requestUriString2 = "https://api.mail.tm/messages";
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Method = "POST";
				if (strProxy != "")
				{
					if (strProxy.Split(':').Length == 4)
					{
						httpWebRequest.Proxy = WebRequest.DefaultWebProxy;
						httpWebRequest.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
						httpWebRequest.Proxy.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
					}
					else if (strProxy.Split(':').Length == 2)
					{
						httpWebRequest.Proxy = new WebProxy(strProxy.Split(':')[0], int.Parse(strProxy.Split(':')[1]));
					}
				}
				httpWebRequest.Accept = "application/json, text/plain, */*";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
				httpWebRequest.Referer = "https://mail.tm/";
				httpWebRequest.Headers["origin"] = "https://mail.tm";
				httpWebRequest.ContentType = "application/json";
				string value = "{\"address\":\"" + email + "\",\"password\":\"" + password + "\"}";
				using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
				{
					streamWriter.Write(value);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					string text2 = streamReader.ReadToEnd();
					if (!text2.Contains("token"))
					{
						Console.WriteLine("Fail token mail: " + email);
						return result;
					}
					text = Regex.Match(text2, "token\":\"(.*?)\"").Groups[1].Value;
				}
				HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(requestUriString2);
				if (strProxy != "")
				{
					if (strProxy.Split(':').Length == 4)
					{
						httpWebRequest2.Proxy = WebRequest.DefaultWebProxy;
						httpWebRequest2.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
						httpWebRequest2.Proxy.Credentials = new NetworkCredential(strProxy.Split(':')[2], strProxy.Split(':')[3]);
					}
					else if (strProxy.Split(':').Length == 2)
					{
						httpWebRequest2.Proxy = new WebProxy(strProxy.Split(':')[0], int.Parse(strProxy.Split(':')[1]));
					}
				}
				httpWebRequest2.Accept = "application/json, text/plain, */*";
				httpWebRequest2.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
				httpWebRequest2.Referer = "https://mail.tm/";
				httpWebRequest2.Headers["origin"] = "https://mail.tm";
				httpWebRequest2.ContentType = "application/json";
				httpWebRequest2.Headers["Authorization"] = "Bearer " + text;
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					string text3 = streamReader2.ReadToEnd();
					if (text3 != "" && text3 != null)
					{
						result = Regex.Match(text3, "subject\":\"(\\d{5})").Groups[1].Value;
					}
				}
				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error code mailtm: " + ex.Message);
				return result;
			}
		}
	}
}
