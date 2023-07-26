using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using HtmlAgilityPack;
using xNet;

namespace ToolRegFB
{
	public class CaptchaService
	{
		public static string Twocaptcha_Giai_recaptcha(string apikey)
		{
			string result = "";
			try
			{
				xNet.HttpRequest httpRequest = new xNet.HttpRequest();
				httpRequest.KeepAlive = true;
				httpRequest.Cookies = new CookieDictionary();
				httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
				httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
				httpRequest.UserAgent = Http.ChromeUserAgent();
				string text2 = httpRequest.Get("https://2captcha.com/in.php?key=" + apikey + "&method=userrecaptcha&googlekey=6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR&pageurl=https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com").ToString();
				if (text2.StartsWith("OK|"))
				{
					string value = Regex.Match(text2, "(\\d+)").Groups[1].Value;
					Thread.Sleep(1000);
					int i = 0;
					while (i < 62)
					{
						text2 = httpRequest.Get("https://2captcha.com/res.php?key=" + apikey + "&action=get&id=" + value).ToString();
						if (!text2.StartsWith("OK|"))
						{
							if (text2.Contains("CAPCHA_NOT_READY"))
							{
								Thread.Sleep(5000);
							}
							else if (text2.Contains("ERROR_CAPTCHA_UNSOLVABLE"))
							{
								return result;
							}
							Thread.Sleep(1000);
							if (i > 60)
							{
								Console.WriteLine("Time out!!!");
								return result;
							}
							i++;
							continue;
						}
						string value2 = Regex.Match(text2, "OK.(.*?)$").Groups[1].Value;
						result = value2;
						goto end_IL_0007;
					}
				}
				else if (text2.Contains("ERROR_WRONG_USER_KEY"))
				{
					result = "ERROR_WRONG_USER_KEY";
					return result;
				}
				return result;
			end_IL_0007:;
			}
			catch
			{
				return result;
			}
			return result;
		}

		public bool Giainormalcaptcha(string APIKey, string base64Image, out string result)
		{
			string text = "";
			string text2 = "2captcha.com";
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["method"] = "base64";
				nameValueCollection["key"] = APIKey;
				nameValueCollection["body"] = base64Image;
				byte[] bytes = webClient.UploadValues("http://" + text2 + "/in.php", nameValueCollection);
				text = Encoding.Default.GetString(bytes);
			}
			Thread.Sleep(TimeSpan.FromSeconds(5.0));
			if (text.Substring(0, 3) == "OK|")
			{
				string text3 = text.Remove(0, 3);
				for (int i = 0; i < 24; i++)
				{
					WebRequest webRequest = WebRequest.Create("http://" + text2 + "/res.php?key=" + APIKey + "&action=get&id=" + text3);
					using (WebResponse webResponse = webRequest.GetResponse())
					{
						StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
						string text4 = streamReader.ReadToEnd();
						if (text4.Length < 3)
						{
							result = text4;
							return false;
						}
						if (text4.Substring(0, 3) == "OK|")
						{
							result = text4.Remove(0, 3);
							return true;
						}
						if (text4 != "CAPCHA_NOT_READY")
						{
							result = text4;
							return false;
						}
					}
					Thread.Sleep(5000);
				}
				result = "Timeout";
				return false;
			}
			result = text;
			return false;
		}

		public static string Anycaptcha_Giai_recaptcha(string AntiKey, string Website, string SiteKey)
		{
			string result = "";
			try
			{
				xNet.HttpRequest httpRequest = new xNet.HttpRequest();
				httpRequest.KeepAlive = true;
				httpRequest.Cookies = new CookieDictionary();
				httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, *; q=0.01");
				httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
				httpRequest.UserAgent = Http.ChromeUserAgent();
				string text = Base64Decode("ewogICAgImNsaWVudEtleSI6ICJ4eHh4eHh4eHgiLAogICAgInRhc2siOiB7CiAgICAgICAgInR5cGUiOiAiUmVjYXB0Y2hhVjJUYXNrIiwKICAgICAgICAid2Vic2l0ZVVSTCI6ICJ6enp6enp6enp6IiwKICAgICAgICAid2Vic2l0ZUtleSI6ICJ5eXl5eXl5eXkiCiAgICB9Cn0=");
				text = text.Replace("xxxxxxxxx", AntiKey);
				text = text.Replace("yyyyyyyyy", SiteKey);
				text = text.Replace("zzzzzzzzzz", Website);
				string text2 = httpRequest.Post("https://api.anycaptcha.com/createTask", text, "application/json").ToString();
				if (text2.Contains("\"errorId\":0"))
				{
					string value = Regex.Match(text2, "taskId\":(.*?)}").Groups[1].Value;
					string text3 = Base64Decode("ewogICAgImNsaWVudEtleSI6Inl5eXl5eXl5eSIsCiAgICAidGFza0lkIjogeHh4Cn0=");
					text3 = text3.Replace("yyyyyyyyy", AntiKey);
					text3 = text3.Replace("xxx", value);
					Thread.Sleep(1000);
					int i = 0;
					while (i < 62)
					{
						text2 = httpRequest.Post("https://api.anycaptcha.com/getTaskResult", text3, "application/json").ToString();
						if (text2.Contains("processing"))
						{
							Thread.Sleep(1000);
							if (i > 60)
							{
								Console.WriteLine("Time out!!!");
								return result;
							}
							i++;
							continue;
						}
						string value2 = Regex.Match(text2, "gRecaptchaResponse\":\"(.*?)\"").Groups[1].Value;
						result = value2;
						goto end_IL_0007;
					}
				}
				return result;
			end_IL_0007:;
			}
			catch
			{
			}
			return result;
		}

		public static bool Anycaptcha_Giai_normalcaptcha(string cookieFB, string captchaKey, string url)
		{
			while (true)
			{
				string pathSave = string.Empty;
				try
				{
					string result = "";
					Request request = new Request(cookieFB);
					RequestFacebook requestfb = new RequestFacebook();
					requestfb.SetHeader(new Dictionary<string, string>
					{
						{ "content-length", "1271" },
						{ "x-fb-lsd", "AVrgrRwg9n4" },
						{ "sec-ch-ua", "\"Not_A Brand\";v=\"99\", \"Microsoft Edge\";v=\"109\", \"Chromium\";v=\"109\"" },
						{ "content-type", "application/x-www-form-urlencoded" },
						{ "sec-ch-ua-mobile", "?0" },
						{ "user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36 Edg/109.0.1518.52" },
						{ "sec-ch-ua-platform", "\"Windows\"" },
						{ "accept", "*/*" },
						{ "origin", "https://mbasic.facebook.com" },
						{ "sec-fetch-site", "same-origin" },
						{ "sec-fetch-mode", "cors" },
						{ "sec-fetch-dest", "empty" },
						{ "referer", "https://mbasic.facebook.com/" },
						{ "accept-encoding", "gzip, deflate" },
						{ "accept-language", "vi" }
					});
					requestfb.SetCookie(cookieFB, "/", ".facebook.com");
					HtmlDocument doc = new HtmlDocument();
					string htmlCheckpoint = requestfb.Get(url);
					doc.LoadHtml(htmlCheckpoint);
					string linkImage = doc.DocumentNode.SelectSingleNode("//div[@id='captcha']/img").Attributes["src"].Value;
					if (string.IsNullOrEmpty(linkImage))
					{
						return false;
					}
					pathSave = requestfb.Download(linkImage);
					byte[] imageArray = File.ReadAllBytes(pathSave);
					string base64image = Convert.ToBase64String(imageArray);
					xNet.HttpRequest httpRequest = new xNet.HttpRequest();
					httpRequest.KeepAlive = true;
					httpRequest.Cookies = new CookieDictionary();
					httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
					httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
					httpRequest.UserAgent = Http.ChromeUserAgent();
					string text = Base64Decode("ewogICAgImNsaWVudEtleSI6ICJ4eHh4eHh4eHgiLAogICAgInRhc2siOiB7CiAgICAgICAgInR5cGUiOiAiSW1hZ2VUb1RleHRUYXNrIiwKICAgICAgICAiYm9keSI6ICJ5eXl5eXl5eXkiCiAgICB9Cn0=");
					text = text.Replace("xxxxxxxxx", captchaKey);
					text = text.Replace("yyyyyyyyy", base64image);
					string text2 = httpRequest.Post("https://api.anycaptcha.com/createTask", text, "application/json").ToString();
					if (text2.Contains("\"errorId\":0"))
					{
						string value = Regex.Match(text2, "taskId\":(.*?)}").Groups[1].Value;
						string text3 = Base64Decode("ewogICAgImNsaWVudEtleSI6Inl5eXl5eXl5eSIsCiAgICAidGFza0lkIjogeHh4Cn0=");
						text3 = text3.Replace("yyyyyyyyy", captchaKey);
						text3 = text3.Replace("xxx", value);
						Thread.Sleep(1000);
						for (int i = 0; i < 62; i++)
						{
							text2 = httpRequest.Post("https://api.anycaptcha.com/getTaskResult", text3, "application/json").ToString();
							if (!text2.Contains("processing"))
							{
								string value2 = Regex.Match(text2, "text\":\"(.*?)\"").Groups[1].Value;
								result = value2;
								break;
							}
							Thread.Sleep(1000);
							if (i > 60)
							{
								Console.WriteLine("Time out!!!");
								return false;
							}
						}
					}
					if (result != "" && result != null)
					{
						MatchCollection matches_fb_dtsg = Regex.Matches(htmlCheckpoint, "name=\"fb_dtsg\" value=\"(.*?)\"");
						MatchCollection matches_jazoest = Regex.Matches(htmlCheckpoint, "name=\"jazoest\" value=\"(.*?)\"");
						string fb_dtsg = matches_fb_dtsg[0].Groups[1].Value;
						string jazoest = matches_jazoest[0].Groups[1].Value;
						string url_post = "https://mbasic.facebook.com/checkpoint/1501092823525282/submit" + Regex.Match(htmlCheckpoint, "form method=\"post\" action=\"/checkpoint/1501092823525282/submit(.*?)\"").Groups[1].Value.Replace("amp;", "");
						Dictionary<string, string> Dic_post_data = new Dictionary<string, string>();
						Dic_post_data.Add("fb_dtsg", fb_dtsg);
						Dic_post_data.Add("jazoest", jazoest);
						Dic_post_data.Add("captcha_persist_data", Regex.Match(htmlCheckpoint, "captcha_persist_data\" value=\"(.*?)\"").Groups[1].Value);
						Dic_post_data.Add("captcha_response", result);
						Dic_post_data.Add("action_submit_bot_captcha_response", "Continue");
						Dic_post_data.Add("origin", "https://mbasic.facebook.com");
						Dic_post_data.Add("cookie", cookieFB);
						Dic_post_data.Add("referer", url_post);
						string slovel_capcha = requestfb.Post(url_post, Dic_post_data);
						if (File.Exists(pathSave))
						{
							File.Delete(pathSave);
						}
						if (slovel_capcha.Contains("The text you entered"))
						{
							continue;
						}
						if (slovel_capcha.Contains("name=\"mobile_image_data"))
						{
							return true;
						}
						return false;
					}
					if (File.Exists(pathSave))
					{
						File.Delete(pathSave);
					}
					return false;
				}
				catch
				{
					if (File.Exists(pathSave))
					{
						File.Delete(pathSave);
					}
					return false;
				}
			}
		}

		public static string Base64Decode(string base64Encoded)
		{
			byte[] bytes = Convert.FromBase64String(base64Encoded);
			return Encoding.UTF8.GetString(bytes);
		}

		public static bool Twocaptcha_Giai_normalcaptcha(string captchaKey, string cookieFB, string url)
		{
			while (true)
			{
				string pathSave = string.Empty;
				try
				{
					string result = "";
					Request request = new Request(cookieFB);
					RequestFacebook requestfb = new RequestFacebook();
					requestfb.SetHeader(new Dictionary<string, string>
					{
						{ "content-length", "1271" },
						{ "x-fb-lsd", "AVrgrRwg9n4" },
						{ "sec-ch-ua", "\"Not_A Brand\";v=\"99\", \"Microsoft Edge\";v=\"109\", \"Chromium\";v=\"109\"" },
						{ "content-type", "application/x-www-form-urlencoded" },
						{ "sec-ch-ua-mobile", "?0" },
						{ "user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36 Edg/109.0.1518.52" },
						{ "sec-ch-ua-platform", "\"Windows\"" },
						{ "accept", "*/*" },
						{ "origin", "https://mbasic.facebook.com" },
						{ "sec-fetch-site", "same-origin" },
						{ "sec-fetch-mode", "cors" },
						{ "sec-fetch-dest", "empty" },
						{ "referer", "https://mbasic.facebook.com/" },
						{ "accept-encoding", "gzip, deflate" },
						{ "accept-language", "vi" }
					});
					requestfb.SetCookie(cookieFB, "/", ".facebook.com");
					HtmlDocument doc = new HtmlDocument();
					string htmlCheckpoint = requestfb.Get(url);
					doc.LoadHtml(htmlCheckpoint);
					string linkImage = doc.DocumentNode.SelectSingleNode("//div[@id='captcha']/img").Attributes["src"].Value;
					if (string.IsNullOrEmpty(linkImage))
					{
						return false;
					}
					pathSave = requestfb.Download(linkImage);
					byte[] imageArray = File.ReadAllBytes(pathSave);
					string base64image = Convert.ToBase64String(imageArray);
					CaptchaService twoCaptcha = new CaptchaService();
					bool flag = twoCaptcha.Giainormalcaptcha(captchaKey, Convert.ToBase64String(imageArray), out result);
					while (!flag)
					{
						flag = twoCaptcha.Giainormalcaptcha(captchaKey, Convert.ToBase64String(imageArray), out result);
						Thread.Sleep(TimeSpan.FromSeconds(2.0));
						if (result == "ERROR_IMAGE_TYPE_NOT_SUPPORTED")
						{
							return false;
						}
					}
					if (result != "" && result != null)
					{
						MatchCollection matches_fb_dtsg = Regex.Matches(htmlCheckpoint, "name=\"fb_dtsg\" value=\"(.*?)\"");
						MatchCollection matches_jazoest = Regex.Matches(htmlCheckpoint, "name=\"jazoest\" value=\"(.*?)\"");
						string fb_dtsg = matches_fb_dtsg[0].Groups[1].Value;
						string jazoest = matches_jazoest[0].Groups[1].Value;
						string url_post = "https://mbasic.facebook.com/checkpoint/1501092823525282/submit" + Regex.Match(htmlCheckpoint, "form method=\"post\" action=\"/checkpoint/1501092823525282/submit(.*?)\"").Groups[1].Value.Replace("amp;", "");
						Dictionary<string, string> Dic_post_data = new Dictionary<string, string>();
						Dic_post_data.Add("fb_dtsg", fb_dtsg);
						Dic_post_data.Add("jazoest", jazoest);
						Dic_post_data.Add("captcha_persist_data", Regex.Match(htmlCheckpoint, "captcha_persist_data\" value=\"(.*?)\"").Groups[1].Value);
						Dic_post_data.Add("captcha_response", result);
						Dic_post_data.Add("action_submit_bot_captcha_response", "Continue");
						Dic_post_data.Add("origin", "https://mbasic.facebook.com");
						Dic_post_data.Add("cookie", cookieFB);
						Dic_post_data.Add("referer", url_post);
						string slovel_capcha = requestfb.Post(url_post, Dic_post_data);
						if (File.Exists(pathSave))
						{
							File.Delete(pathSave);
						}
						if (slovel_capcha.Contains("The text you entered"))
						{
							continue;
						}
						if (slovel_capcha.Contains("name=\"mobile_image_data"))
						{
							return true;
						}
						return false;
					}
					if (File.Exists(pathSave))
					{
						File.Delete(pathSave);
					}
					return false;
				}
				catch
				{
					if (File.Exists(pathSave))
					{
						File.Delete(pathSave);
					}
					return false;
				}
			}
		}

		public static string get_captcha_persist(string pagesource)
		{
			return Regex.Match(pagesource, "captcha_persist_data\" value=\"(.*?)\"").Groups[1].Value;
		}

		public static string Omocaptcha_Giai_normalcaptcha(string api, string yyyy)
		{
			string result = "";
			string jobid = string.Empty;
			try
			{
				xNet.HttpRequest httpRequest = new xNet.HttpRequest();
				httpRequest.KeepAlive = true;
				httpRequest.Cookies = new CookieDictionary();
				httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
				httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
				httpRequest.UserAgent = Http.ChromeUserAgent();
				string text = Base64Decode("ewogICAgImFwaV90b2tlbiI6ICJ4eHh4eHh4eHgiLAogICAgImRhdGEiOiB7CiAgICAgICAgInR5cGVfam9iX2lkIjogIjQxIiwKICAgICAgICAiaW5wdXQiOiAieXl5eXl5eXl5IgogICAgfQp9");
				text = text.Replace("xxxxxxxxx", api);
				text = text.Replace("yyyyyyyyy", yyyy);
				string text2 = httpRequest.Post("https://omocaptcha.com/api/createJob", text, "application/json").ToString();
				if (text2.Contains("error\":false"))
				{
					string value = Regex.Match(text2, "job_id\":(.*?),").Groups[1].Value;
					string text3 = Base64Decode("ewogICAgImFwaV90b2tlbiI6Inl5eXl5eXl5eSIsCiAgICAiam9iX2lkIjogeHh4Cn0=");
					text3 = text3.Replace("yyyyyyyyy", api);
					text3 = text3.Replace("xxx", value);
					Thread.Sleep(1000);
					for (int i = 0; i < 62; i++)
					{
						text2 = httpRequest.Post("https://omocaptcha.com/api/getJobResult", text3, "application/json").ToString();
						if (!text2.Contains("running") && !text2.Contains("status\":\"fail"))
						{
							return Regex.Match(text2, "result\":\"(.*?)\"").Groups[1].Value;
						}
						if (text2.Contains("status\":\"fail"))
						{
							return "Get new";
						}
						Thread.Sleep(1000);
						if (i > 60)
						{
							Console.WriteLine("Time out!!!");
							return "Get new";
						}
					}
				}
				return result;
			}
			catch
			{
				return "Get new";
			}
		}
	}
}
