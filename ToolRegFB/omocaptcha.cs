using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks; 

namespace ToolRegFB
{
    class omocaptcha
    {
        private string CreateJobRecaptcha(string api_token)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://omocaptcha.com/api/createJob");
            request.Content = new StringContent("{\n    \"api_token\": \"" + api_token + "\",\n    \"data\":{\n        \"type_job_id\": \"2\"    }\n}\n");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(responseBody);
                if ((bool)json["error"] == false)
                {
                    return json["job_id"].ToString();
                }
            }
            return "";
        }
        private string CreateJobAudio(string api_token, string value)
        {
            string audiBase64 = DownloadMp3(value, "");
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://omocaptcha.com/api/createJob");
            request.Content = new StringContent("{\n    \"api_token\": \"" + api_token + "\",\n    \"data\":{\n        \"type_job_id\": \"41\",\n\t\t\"input\": \"" + audiBase64 + "\"\n    }\n}\n");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(responseBody);
                if ((bool)json["error"] == false)
                {
                    return json["job_id"].ToString();
                }
            }
            return "";
        }
        private string GetJobResult(string api_token, string job_id, int timeOut)
        {
            for (int i = 0; i < timeOut; i++)
            {
                try
                {
                    HttpClient client = new HttpClient();

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://omocaptcha.com/api/getJobResult");
                    request.Content = new StringContent("{\n\t\"api_token\": \"" + api_token + "\",\n\t\"job_id\": \"" + job_id + "\"\n\t\t\n}\n\n");
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = client.SendAsync(request).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(responseBody);
                        if (json["status"].ToString().Contains("success"))
                        {
                            return json["result"].ToString();
                        }
                    }
                    Thread.Sleep(1000);
                }
                catch { }

            }
            return "";

        }
        string DownloadMp3(string valueLink, string proxy)
        {
            try
            {
                string url = "https://www.facebook.com/captcha/tfbaudio/?captcha_persist_data=" + valueLink;
                Random rd = new Random();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                if (proxy != "")
                {
                    request.Proxy = new WebProxy(proxy);
                }
                request.Method = "GET";
                request.Timeout = 5000;
                request.Headers.Add("authority", "www.facebook.com");
                request.Headers.Add("accept", "*/*");
                request.Headers.Add("accept-language", "vi");
                request.Headers.Add("range", "bytes=0-");
                request.Headers.Add("referer", "https://mbasic.facebook.com/");
                request.Headers.Add("sec-ch-ua", "\"Not?A_Brand\";v=\"8\", \"Chromium\";v=\"108\", \"Google Chrome\";v=\"108\"");
                request.Headers.Add("sec-ch-ua-mobile", "?0");
                request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
                request.Headers.Add("sec-fetch-dest", "audio");
                request.Headers.Add("sec-fetch-mode", "no-cors");
                request.Headers.Add("sec-fetch-site", "same-site");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/10" + rd.Next(0, 9) + ".0.0.0 Safari/537.36";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var memoryStream = new MemoryStream())
                        {

                            return Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public static string smethod_0(string string_0)
        {
            byte[] bytes = Convert.FromBase64String(string_0);
            return Encoding.UTF8.GetString(bytes);
        }

        public string method_0(string string_0)
        {
            return Regex.Match(string_0, "captcha_persist_data\" value=\"(.*?)\"").Groups[1].Value;
        }

        public string method_1(string string_0, string string_1)
        {
            string result = "";
            try
            {
                xNet.HttpRequest httpRequest = new xNet.HttpRequest();
                httpRequest.KeepAlive = true;
                httpRequest.Cookies = new xNet.CookieDictionary();
                httpRequest.AddHeader(xNet.HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
                httpRequest.AddHeader(xNet.HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
                httpRequest.UserAgent = xNet.Http.ChromeUserAgent();
                string text = smethod_0("ewogICAgImFwaV90b2tlbiI6ICJ4eHh4eHh4eHgiLAogICAgImRhdGEiOiB7CiAgICAgICAgInR5cGVfam9iX2lkIjogIjQxIiwKICAgICAgICAiaW5wdXQiOiAieXl5eXl5eXl5IgogICAgfQp9");
                text = text.Replace("xxxxxxxxx", string_0);
                text = text.Replace("yyyyyyyyy", string_1);
                string text2 = httpRequest.Post("https://omocaptcha.com/api/createJob", text, "application/json").ToString();
                if (text2.Contains("error\":false"))
                {
                    string value = Regex.Match(text2, "job_id\":(.*?),").Groups[1].Value;
                    string text3 = smethod_0("ewogICAgImFwaV90b2tlbiI6Inl5eXl5eXl5eSIsCiAgICAiam9iX2lkIjogeHh4Cn0=");
                    text3 = text3.Replace("yyyyyyyyy", string_0);
                    text3 = text3.Replace("xxx", value);
                    Thread.Sleep(1000);
                    for (int i = 0; i < 62; i++)
                    {
                        text2 = httpRequest.Post("https://omocaptcha.com/api/getJobResult", text3, "application/json").ToString();
                        if (text2.Contains("running") || text2.Contains("status\":\"fail"))
                        {
                            if (!text2.Contains("status\":\"fail"))
                            {
                                Thread.Sleep(1000);
                                if (i > 60)
                                {
                                    Console.WriteLine("Time out!!!");
                                    return "Get new";
                                }
                                continue;
                            }
                            return "Get new";
                        }
                        return Regex.Match(text2, "result\":\"(.*?)\"").Groups[1].Value;
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
