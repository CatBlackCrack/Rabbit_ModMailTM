using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace ToolRegFB
{
	public class RequestFacebook
	{
		private HttpClientHandler _handler { get; set; }

		private HttpClient _client { get; set; }

		private CookieContainer _cookieContainer { get; set; }

		public RequestFacebook()
		{
			this._cookieContainer = new CookieContainer();
			this._handler = new HttpClientHandler
			{
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate),
				CookieContainer = this._cookieContainer
			};
			this._client = new HttpClient(this._handler);
			this._client.Timeout = new TimeSpan(0, 2, 0);
		}

		public void SetProxy(string ip, string port, string username = null, string password = null)
		{
			if (!string.IsNullOrEmpty(ip) && !string.IsNullOrEmpty(port) && string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
			{
				WebProxy proxy2 = new WebProxy
				{
					Address = new Uri("http://" + ip + ":" + port),
					BypassProxyOnLocal = false,
					UseDefaultCredentials = false
				};
				this._handler.Proxy = proxy2;
			}
			if (!string.IsNullOrEmpty(ip) && !string.IsNullOrEmpty(port) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
			{
				WebProxy proxy = new WebProxy
				{
					Address = new Uri("http://" + ip + ":" + port),
					BypassProxyOnLocal = false,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(username, password)
				};
				this._handler.Proxy = proxy;
			}
		}

		public void SetHeader(Dictionary<string, string> headers, bool isClear = false)
		{
			if (isClear)
			{
				this._client.DefaultRequestHeaders.Clear();
			}
			foreach (KeyValuePair<string, string> item in headers)
			{
				this._client.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, item.Value);
			}
		}

		public void SetHeader(List<KeyValuePair<string, string>> headers, bool isClear = false)
		{
			if (isClear)
			{
				this._client.DefaultRequestHeaders.Clear();
			}
			foreach (KeyValuePair<string, string> item in headers)
			{
				this._client.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, item.Value);
			}
		}

		public void SetCookie(string cookieInput, string path, string domain)
		{
			string[] cookieArgs = cookieInput.Split(';');
			string[] array = cookieArgs;
			foreach (string cookie in array)
			{
				string[] ckSplit = cookie.Split('=');
				if (!string.IsNullOrEmpty(cookie) && ckSplit.Length == 2)
				{
					try
					{
						string name = ckSplit[0].Trim();
						string value = ckSplit[1].Trim();
						Cookie ck = new Cookie(name, value, path, domain);
						_cookieContainer.Add(ck);
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
			}
		}

		public void SetCookie(List<Cookie> cookies)
		{
			foreach (Cookie cookie in cookies)
			{
				try
				{
					_cookieContainer.Add(cookie);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public string GetCookie(string url)
		{
			if (string.IsNullOrEmpty(url))
			{
				throw new Exception("Url Is Null");
			}
			if (_cookieContainer == null)
			{
				return null;
			}
			string cookie = null;
			Uri uri = new Uri(url);
			List<Cookie> cookies = _cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();
			int length = cookies.Count;
			for (int i = 0; i < length; i++)
			{
				if (i + 1 == length)
				{
					cookie = cookie + cookies[i].Name + "=" + cookies[i].Value;
					break;
				}
				cookie = cookie + cookies[i].Name + "=" + cookies[i].Value + ";";
			}
			return cookie;
		}

		public string Get(string url)
		{
			HttpResponseMessage response = _client.GetAsync(url).Result;
			byte[] buffer = response.Content.ReadAsByteArrayAsync().Result;
			return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
		}

		public string Post(string url, Dictionary<string, string> dataPost)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			HttpResponseMessage response = _client.PostAsync(url, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dataPost)).Result;
			byte[] buffer = response.Content.ReadAsByteArrayAsync().Result;
			return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
		}

		public string Post(string url, List<KeyValuePair<string, string>> dataPost)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			HttpResponseMessage response = _client.PostAsync(url, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dataPost)).Result;
			byte[] buffer = response.Content.ReadAsByteArrayAsync().Result;
			return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
		}

		public string Download(string url)
		{
			string path = Application.StartupPath + "\\Image\\" + Guid.NewGuid().ToString() + ".png";
			HttpResponseMessage response = _client.GetAsync(url, (HttpCompletionOption)1).Result;
			try
			{
				response.EnsureSuccessStatusCode();
				using FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true);
				response.Content.CopyToAsync((Stream)fileStream).Wait();
			}
			finally
			{
				((IDisposable)response)?.Dispose();
			}
			return path;
		}
	}
}
