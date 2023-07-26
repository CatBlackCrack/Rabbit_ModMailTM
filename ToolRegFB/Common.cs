using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;
using HttpRequest;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Newtonsoft.Json.Linq;
using ns0;
using ns3;
using ns4;
using OtpNet;
using RestSharp;
using xNet;
using ZXing;

namespace ToolRegFB
{
	public class Common
	{
		[CompilerGenerated]
		private static class Class8
		{
			public static CallSite<Func<CallSite, object, GInterface3>> callSite_0;
		}

		[CompilerGenerated]
		private sealed class Class9
		{
			public StringBuilder stringBuilder_0;

			internal void method_0(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					stringBuilder_0.Append(e.Data + "\n");
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class13
		{
			public string string_0;

			internal Task<string> method_0()
			{
				return smethod_49(new Uri(string_0));
			}
		}

		[CompilerGenerated]
		private sealed class Class14
		{
			public Form form_0;

			internal void method_0()
			{
				form_0.Close();
			}
		}

		public static Random random_0 = new Random();

		public static int int_0;

		public static int int_1;

		public static List<string> smethod_0()
		{
			return new List<string>
			{
				"0|91", "1|94", "2|86", "3|96", "4|97", "5|98", "6|32", "7|33", "8|34", "9|35",
				"10|36", "11|37", "12|38", "13|39", "14|88", "15|83", "16|84", "17|85", "18|81", "19|82",
				"20|89", "21|90", "22|93", "23|70", "24|79", "25|77", "26|76", "27|78", "28|92", "29|56",
				"30|58", "31|99", "32|59"
			};
		}

		public static List<string> smethod_1()
		{
			return new List<string>
			{
				"0|205", "1|251", "2|659", "3|256", "4|334", "5|907", "6|520", "7|928", "8|480", "9|602",
				"10|623", "11|501", "12|479", "13|870", "14|341", "15|442", "16|628", "17|657", "18|669", "19|747",
				"20|752", "21|764", "22|951", "23|209", "24|559", "25|408", "26|831", "27|510", "28|213", "29|310",
				"30|424", "31|323", "32|562", "33|707", "34|369", "35|627", "36|530", "37|714", "38|949", "39|626",
				"40|909", "41|916", "42|760", "43|619", "44|858", "45|935", "46|818", "47|415", "48|925", "49|661",
				"50|805", "51|650", "52|211", "53|720", "54|970", "55|303", "56|719", "57|203", "58|475", "59|860",
				"60|959", "61|302", "62|411", "63|202", "64|911", "65|239", "66|386", "67|689", "68|754", "69|941",
				"70|954", "71|561", "72|407", "73|727", "74|352", "75|904", "76|850", "77|786", "78|863", "79|305",
				"80|321", "81|813", "82|470", "83|478", "84|770", "85|678", "86|404", "87|706", "88|912", "89|229",
				"90|710", "91|671", "92|808", "93|208", "94|312", "95|773", "96|630", "97|847", "98|708", "99|815",
				"100|224", "101|331", "102|464", "103|872", "104|217", "105|618", "106|309", "107|260", "108|317", "109|219",
				"110|765", "111|812", "112|563", "113|641", "114|515", "115|319", "116|712", "117|876", "118|620", "119|785",
				"120|913", "121|316", "122|270", "123|859", "124|606", "125|502", "126|225", "127|337", "128|985", "129|504",
				"130|318", "131|207", "132|227", "133|240", "134|443", "135|667", "136|410", "137|301", "138|339", "139|351",
				"140|774", "141|781", "142|857", "143|978", "144|508", "145|617", "146|413", "147|231", "148|269", "149|989",
				"150|734", "151|517", "152|313", "153|810", "154|248", "155|278", "156|586", "157|679", "158|947", "159|906",
				"160|616", "161|320", "162|612", "163|763", "164|952", "165|218", "166|507", "167|651", "168|228", "169|601",
				"170|557", "171|573", "172|636", "173|660", "174|975", "175|314", "176|816", "177|417", "178|664", "179|406",
				"180|402", "181|308", "182|775", "183|702", "184|506", "185|603", "186|551", "187|848", "188|862", "189|732",
				"190|908", "191|201", "192|973", "193|609", "194|856", "195|505", "196|575", "197|585", "198|845", "199|917",
				"200|516", "201|212", "202|646", "203|315", "204|518", "205|347", "206|718", "207|607", "208|914", "209|631",
				"210|716", "211|252", "212|336", "213|828", "214|910", "215|980", "216|984", "217|919", "218|704", "219|701",
				"220|283", "221|380", "222|567", "223|216", "224|614", "225|937", "226|330", "227|234", "228|440", "229|419",
				"230|740", "231|513", "232|580", "233|918", "234|405", "235|541", "236|971", "237|445", "238|610", "239|835",
				"240|878", "241|484", "242|717", "243|570", "244|412", "245|215", "246|267", "247|814", "248|724", "249|787",
				"250|939", "251|401", "252|306", "253|803", "254|843", "255|864", "256|605", "257|731", "258|865", "259|931",
				"260|423", "261|615", "262|901", "263|325", "264|361", "265|430", "266|432", "267|469", "268|682", "269|737",
				"270|979", "271|214", "272|972", "273|254", "274|940", "275|713", "276|281", "277|832", "278|956", "279|817",
				"280|806", "281|903", "282|210", "283|830", "284|409", "285|936", "286|512", "287|915", "288|340", "289|385",
				"290|435", "291|801", "292|802", "293|276", "294|434", "295|540", "296|571", "297|757", "298|703", "299|804",
				"300|509", "301|206", "302|425", "303|253", "304|360", "305|564", "306|304", "307|262", "308|920", "309|414",
				"310|715", "311|608", "312|307", "313|867", "314|866", "315|456", "316|11", "317|880", "318|881", "319|882",
				"320|500", "321|611", "322|311", "323|200", "324|300", "325|400", "326|700", "327|711", "328|811", "329|800",
				"330|877", "331|888"
			};
		}

		public static Point smethod_2(int int_2, int int_3 = 6)
		{
			Point result = default(Point);
			int num = 2 * int_0 / int_3;
			int num2 = int_3 / 2;
			while (int_2 > 5)
			{
				int_2 -= 6;
			}
			if (int_2 <= num2 - 1)
			{
				result.Y = 0;
			}
			else if (int_2 < int_3)
			{
				result.Y = int_1 / 2;
				int_2 -= num2;
			}
			result.X = int_2 * num;
			return result;
		}

		public static DateTime smethod_3(string string_0, string string_1 = "dd/MM/yyyy HH:mm:ss")
		{
			return DateTime.ParseExact(string_0, string_1, CultureInfo.InvariantCulture);
		}

		public static void smethod_4(string string_0)
		{
			try
			{
				if (!Directory.Exists(string_0))
				{
					Directory.CreateDirectory(string_0);
				}
			}
			catch
			{
			}
		}

		public static string smethod_5(string string_0)
		{
			MD5 mD = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string smethod_6(int int_2, Random random_1 = null)
		{
			string text = "";
			if (random_1 == null)
			{
				random_1 = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 0; i < int_2; i++)
			{
				text += text2[random_1.Next(0, text2.Length)];
			}
			return text;
		}

		public static bool smethod_7(int int_2)
		{
			int num = random_0.Next(1, 101);
			return num <= int_2;
		}

		public static List<string> smethod_8(List<string> list_0)
		{
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(list_0[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		public static string smethod_9(string string_0, Random random_1)
		{
			int num = -1;
			char[] anyOf = new char[2] { '{', '}' };
			string_0 += "~";
			do
			{
				int num2 = num;
				num = -1;
				while ((num2 = string_0.IndexOf('{', num2 + 1)) != -1)
				{
					int num3 = num2;
					while ((num3 = string_0.IndexOfAny(anyOf, num3 + 1)) != -1 && string_0[num3] != '}')
					{
						if (num == -1)
						{
							num = num2;
						}
						num2 = num3;
					}
					if (num3 != -1)
					{
						string[] array = string_0.Substring(num2 + 1, num3 - 1 - (num2 + 1 - 1)).Split('|');
						string_0 = string_0.Remove(num2, num3 - (num2 - 1)).Insert(num2, array[random_1.Next(array.Length)]);
					}
				}
			}
			while (num-- != -1);
			return string_0.Remove(string_0.Length - 1);
		}

		//=====/SITE SIM/======

		//Bat dau tempcode.co
		//public static string smethod_47(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		//{
		//	string text = "";
		//	string text2 = "";
		//	if (services == 1)
		//	{
		//		RequestHTTP requestHTTP = new RequestHTTP();
		//		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		//		requestHTTP.SetKeepAlive(k: true);
		//		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
		//		int tickCount = Environment.TickCount;
		//		try
		//		{
		//			while (Environment.TickCount - tickCount < timeout * 1000)
		//			{
		//				string json = requestHTTP.Request("GET", "http://servertextnow.xyz/api/get-phone/?access_token=" + apiKey, null).ToString();
		//				JObject jObject = JObject.Parse(json);
		//				Thread.Sleep(TimeSpan.FromSeconds(3.0));

		//				if (json != "")
		//				{
		//					text = jObject["phone"].ToString();
		//					idRequest = jObject["phone"].ToString();

		//				}
		//				if (!text.Equals(""))
		//				{
		//					break;
		//				}

		//			}
		//		}
		//		catch
		//		{
		//		}
		//	}
		//	return text;
		//}

		//public static string smethod_44(string apiKey, string idRequest, int timeout = 60, int services = 1) // Get code otptextnow
		//{
		//	string text = "";
		//	string text2 = "";
		//	if (services == 1)
		//	{
		//		RequestHTTP requestHTTP = new RequestHTTP();
		//		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		//		requestHTTP.SetKeepAlive(k: true);
		//		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
		//		int tickCount = Environment.TickCount;
		//		try
		//		{
		//			while (Environment.TickCount - tickCount < timeout * 1000)
		//			{
		//				string json = requestHTTP.Request("GET", "http://servertextnow.xyz/api/get-otp/?access_token=" + apiKey + "&phone=" + idRequest);
		//				JObject jObject = JObject.Parse(json);
		//				Thread.Sleep(TimeSpan.FromSeconds(3.0));
		//				text = jObject["otp"].ToString();
		//				//if (json != "" ) 
		//				//{

		//				//	break;
		//				//                  }
		//				if (!text.Equals(""))
		//				{
		//					break;
		//				}
		//				//text = jObject["otp_code"].ToString();
		//				//bool flag = text != "is_comming";
		//				//if (flag)
		//				//{
		//				//	break;
		//				//}
		//			}
		//		}
		//		catch
		//		{
		//		}
		//	}
		//	return text;
		//} // Ket thuc tempcode.co
		  //Bat dau Ahasim.com


		public static string CheckKeyAhasim(string string_0, int int_2 = 60, int int_3 = 7)
		{
			string result = "";
			if (int_3 == 7)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				string json = requestHTTP.Request("GET", "http://ahasim.com/api/user/balance?token=" + string_0);
				try
				{
					JObject jObject = JObject.Parse(json);
					if (Convert.ToBoolean(jObject["success"].ToString()))
					{
						result = JObject.Parse(json)["data"]["balance"].ToString();
					}
				}
				catch
				{
				}
			}
			return (result == "") ? "" : Convert.ToInt32(result).ToString();
		}

		public static string GetListServiceAhasim(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			string text = "";
			string text2 = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < timeout * 1000)
					{
						string json = requestHTTP.Request("GET", "http://ahasim.com/api/service/list?token=" + apiKey);
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						text = jObject["data"]["id"]["name"]["price"].ToString();
						bool flag = text != "";
						if (flag)
						{
							
							idRequest = jObject["id"].ToString();
							break;
						}
						Thread.Sleep(500);
					}
				}
				catch
				{
				}
			}
			return text;
		}


		public static string GetPhoneAhasim(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			string text = "";
			string text2 = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < timeout * 1000)
					{
						string json = requestHTTP.Request("GET", "http://ahasim.com/api/phone/new-session?token=" + apiKey + "&service=4&network=1,2,3,4");
						JObject jObject = JObject.Parse(json);
						idRequest = jObject["data"]!["session"]!.ToString();
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						
						if (json != "")
						{
							text = jObject["data"]!["phone_number"]!.ToString();

						}
						

					}
				}
				catch
				{
				}
			}
			return idRequest + "|" + text;
		}


		public static string GetCodeAhasim(string apiKey, string idRequest, int timeout = 60, int services = 1)
		{
			string text = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < timeout * 1000)
				{
					try
					{

						string json = requestHTTP.Request("GET", "http://ahasim.com/api/session/" + idRequest + "/get-otp?token=" + apiKey);
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						try
						{
							text = jObject["data"]["messages"][0]["otp"].ToString();
							if (text != "")
							{
								break;
							}
						}
						catch
						{
						}
						Thread.Sleep(3000);
						continue;

					}
					catch
					{

					}
				}
			}
			return text;
		}

		//Bat dau Thuecodetextnow
		public static string GetPhoneOtpFb(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			GClass8 gClass = new GClass8();
			string text = "";
			for (int i = 0; i < timeout; i++)
			{
				try
				{
					text = gClass.method_0("http://otpfb.com/api.php?apikey=" + apiKey + "&action=create-request&serviceId=1&count=1");
					if (text != "")
					{
						JObject jObject = JObject.Parse(text);
						return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
					}
					Thread.Sleep(1000);
				}
				catch
				{
				}
			}
			return "";
		}

		public static string GetCodethuecodetextnow(string apiKey, string idRequest, int timeout = 60, int services = 1) // Get code otptextnow
		{
			string text = "";
			string text2 = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < timeout * 1000)
					{
						string json = requestHTTP.Request("GET", "http://thuecodetextnow.com/api/get-otp/?access_token=" + apiKey + "&phone=" + idRequest);
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						text = jObject["otp"].ToString();
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		} // Ket thuc thuecodetextnow

		//Bat dau Otptn
		public static string GetPhoneOtptn(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			string text = "";
			string text2 = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < timeout * 1000)
					{
						string json = requestHTTP.Request("GET", "http://otptn.com/api/get-phone/?access_token=" + apiKey, null).ToString();
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						
						if (json != "")
						{
							text = jObject["phone"].ToString();
							idRequest = jObject["phone"].ToString();
							
						}
						if (!text.Equals(""))
						{
							break;
						}
						
					}
				}
				catch
				{
				}
			}
			return text;
		}
		
		public static string GetCodeOtptn(string apiKey, string idRequest, int timeout = 60, int services = 1) // Get code otptextnow
		{
			string text = "";
			string text2 = "";
			if (services == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < timeout * 1000)
					{
						string json = requestHTTP.Request("GET", "http://otptn.com/api/get-otp/?access_token=" + apiKey + "&phone=" + idRequest);
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						text = jObject["otp"].ToString();
						//if (json != "" ) 
						//{
							
						//	break;
      //                  }
                        if (!text.Equals(""))
                        {
							break;
                        }
						//text = jObject["otp_code"].ToString();
						//bool flag = text != "is_comming";
						//if (flag)
						//{
						//	break;
						//}
					}
				}
				catch
				{
				}
			}
			return text;
		} // Ket thuc Otptn

		public static bool CheckKeyOtpTextnow(string apiKey, int timeout = 60) //Bat dau Otptextnow
		{
			bool result = false;
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string json = requestHTTP.Request("GET", "http://otptextnow.com/api/?key=" + apiKey + "&action=get_all_services");
			JArray jArray = JArray.Parse(json);
			if (jArray.Count > 0)
			{
				result = true;
			}
			return result;
		}

        public static string CheckKeyWinMailShop(string string_0, int timeout = 60)
        {
			string result = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://api.winmail.shop/services/all?clientId=" + string_0 + "&type=phone");
			JObject jObject = JObject.Parse(json);
			string text = jObject["code"]!.ToString();
			if ((text == "200") ? true : false)
			{
				result = jObject["services"]!["key"]!.ToString();
			}
			return result;
		}
        public static string GetPhoneWinMailShop(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			GClass17 gclass = new GClass17("", "", "", 0);
			string text = "";
			for (int i = 0; i < 33; i++)
			{
				try
				{
					string json = gclass.method_0("https://api.winmail.shop/phone/rent?clientId=" + apiKey + "&serviceId=facebook");
					JObject jobject = JObject.Parse(json);
					text = jobject["email"]["phone"].ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			return text;
		}

		public static string GetCodeWinMailShop(string apiKey, string idRequest, int timeout = 120, int services = 1) // Get code otptextnow
		{
			string text = "";
			GClass17 gclass = new GClass17("", "", "", 0);
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					string json = gclass.method_0("https://api.winmail.shop/phone/code?clientId=" + apiKey + "&phone=" + idRequest);
					JObject jobject = JObject.Parse(json);
					try
					{
						text = Regex.Match(jobject["result"]["code"].ToString(), "\\d+").Value;
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
					Thread.Sleep(5000);
				}
				catch
				{
				}
			}
			while (Environment.TickCount - tickCount <= timeout * 1000);
			return text;
		} // Ket thuc Otptextnow

		//Bat dau runotp.com
		//public static bool CheckKeyAhasim(string string_0, int timeout = 60)
		//{
		//	bool result = false;
		//	RequestHTTP requestHTTP = new RequestHTTP();
		//	requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		//	requestHTTP.SetKeepAlive(k: true);
		//	requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
		//	string json = requestHTTP.Request("GET", "http://runotp.com/api.php?apikey=" + string_0 + "&action=services");
		//	JArray jArray = JArray.Parse(json);
		//	if (jArray.Count > 0)
		//	{
		//		result = true;
		//	}
		//	return result;
		//}

		//public static string GetPhoneAhasim(string apiKey, ref string idRequest, int timeout = 60, int services = 1)
		//{
		//	string text = "";
		//	if (services == 1)
		//	{
		//		RequestHTTP requestHTTP = new RequestHTTP();
		//		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		//		requestHTTP.SetKeepAlive(k: true);
		//		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
		//		int tickCount = Environment.TickCount;
		//		try
		//		{
		//			while (Environment.TickCount - tickCount < timeout * 1000)
		//			{
		//				string json = requestHTTP.Request("GET", "http://runotp.com/api.php?apikey=" + apiKey + "&action=create-request&serviceId=1&count=1");
		//				JObject jObject = JObject.Parse(json);
		//				Thread.Sleep(TimeSpan.FromSeconds(3.0));
		//				string text2 = jObject["status"].ToString();
		//				if ((text2 == "200") ? true : false)
		//				{
		//					text = jObject["results"]["data"][0]["sdt"].ToString();
		//					idRequest = jObject["results"]["data"][0]["requestId"].ToString();
		//				}
		//				if (!text.Equals(""))
		//				{
		//					break;
		//				}
		//			}
		//		}
		//		catch
		//		{
		//		}
		//	}
		//	return text;
		//} // runotp.com

		//public static string GetCodeAhasim(string apiKey, string idRequest, int timeout = 60, int services = 1)
		//{
		//	string text = "";
		//	if (services == 1)
		//	{
		//		RequestHTTP requestHTTP = new RequestHTTP();
		//		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		//		requestHTTP.SetKeepAlive(k: true);
		//		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
		//		int tickCount = Environment.TickCount;
		//		try
		//		{
		//			while (Environment.TickCount - tickCount < timeout * 1000)
		//			{
		//				string json = requestHTTP.Request("GET", "http://runotp.com/api.php?apikey=" + apiKey + "&action=data-request&requestId=" + idRequest);
		//				JObject jObject = JObject.Parse(json);
		//				Thread.Sleep(TimeSpan.FromSeconds(3.0));
		//				string text2 = jObject["status"].ToString();
		//				if ((text2 == "200") ? true : false)
		//				{
		//					text = jObject["data"][0]["otp"].ToString();
		//				}
		//				if (!text.Equals(""))
		//				{
		//					break;
		//				}
		//			}
		//		}
		//		catch
		//		{
		//		}
		//	}
		//	return text;
		//}

		//public static string GetPhoneAhasim(string apikey, int timeOut = 60)
		//{
		//	string text = "";
		//	int num = 0;
		//	Class59 @class = new Class59();
		//	string text2 = "";
		//	for (int i = 0; i < 5; i++)
		//	{
		//		try
		//		{
		//			string json = @class.method_0("http://runotp.com/api.php?apikey=" + apikey + "&action=create-request&serviceId=1&count=1" + num);
		//			JObject jObject = JObject.Parse(json);
		//			text2 = jObject["results"]["data"][0]["requestId"].ToString();
		//			if (text2 != "")
		//			{
		//				text = jObject["results"]["data"][0]["sdt"].ToString();
		//				break;
		//			}
		//			Thread.Sleep(3000);
		//			continue;
		//		}
		//		catch
		//		{
		//			throw;
		//		}
		//	}
		//	return text2 + "|" + text;
		//}
        //Chothuesimcode balance
        public static string smethod_10(string string_0, int int_2 = 60, int int_3 = 1001)
        {
            string result = "";
            if (int_3 == 1001)
            {
                RequestHTTP requestHTTP = new RequestHTTP();
                requestHTTP.SetSSL(SecurityProtocolType.Tls12);
                requestHTTP.SetKeepAlive(k: true);
                requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
                string json = requestHTTP.Request("GET", "https://chothuesimcode.com/api?act=account&apik=" + string_0);
                JObject jObject = JObject.Parse(json);
                string text = jObject["ResponseCode"]!.ToString();
                if ((text == "0") ? true : false)
                {
                    result = jObject["Result"]!["Balance"]!.ToString();
                }
            }
            return result;
        }

        public static DialogResult smethod_11(string string_0, string string_1, ref string string_2)
		{
			Form form = new Form();
			Label label = new Label();
			TextBox textBox = new TextBox();
			Button button = new Button();
			Button button2 = new Button();
			form.Text = string_0;
			label.Text = string_1;
			textBox.Text = string_2;
			button.Text = "OK";
			button2.Text = "Cancel";
			button.DialogResult = DialogResult.OK;
			button2.DialogResult = DialogResult.Cancel;
			label.SetBounds(9, 20, 372, 13);
			textBox.SetBounds(12, 36, 372, 20);
			button.SetBounds(228, 72, 75, 23);
			button2.SetBounds(309, 72, 75, 23);
			label.AutoSize = true;
			textBox.Anchor |= AnchorStyles.Right;
			button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			form.ClientSize = new Size(396, 107);
			form.Controls.AddRange(new Control[4] { label, textBox, button, button2 });
			form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = button;
			form.CancelButton = button2;
			DialogResult result = form.ShowDialog();
			string_2 = textBox.Text;
			return result;
		}

		public static void smethod_12(string string_0, string string_1, string string_2, string string_3, string string_4 = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string string_5 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
		{
			string string_6 = Path.Combine(string_1, string_0 + ".lnk");
			GInterface4 gInterface = (GInterface4)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			GInterface3 gInterface2 = (GInterface3)(dynamic)gInterface.imethod_0(string_6);
			gInterface2.Description = "Shortcut Chrome MIN Software";
			gInterface2.WorkingDirectory = string_4;
			gInterface2.IconLocation = string_5;
			gInterface2.TargetPath = string_2;
			gInterface2.Arguments = string_3;
			gInterface2.imethod_0();
		}

		public static string smethod_13(string string_0, int int_2 = 60)
		{
			string result = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://api.tempsms.co/money?api_key=" + string_0);
			JObject jObject = JObject.Parse(json);
			string text = jObject["status_code"]!.ToString();
			if ((text == "0") ? true : false)
			{
				result = jObject["money"]!.ToString();
			}
			return result;
		}

		public static string smethod_14(string string_0, int int_2 = 60)
		{
			string result = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://rabbitsocialtools.com/api/checkBalanceOTP/" + string_0);
			JObject jObject = JObject.Parse(json);
			string text = jObject["status"]!.ToString();
			if ((text == "200") ? true : false)
			{
				result = jObject["totalMoney"]!.ToString();
			}
			return result;  //Check total rabbit
		}

		public static string smethod_15(string string_0, int int_2 = 60, int int_3 = 7)
		{
			string result = "";
			if (int_3 == 7)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://api.viotp.com/users/balance?token=" + string_0);
				JObject jObject = JObject.Parse(json);
				int num = Convert.ToInt32(jObject["status_code"]!.ToString());
				if (num == 200)
				{
					result = jObject["data"]!["balance"]!.ToString();
				}
			}
			return result;
		}

		public static string smethod_16(string string_0)
		{
			string result = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });

			string json = requestHTTP.Request("GET", "https://administrator.codetext247.com/api/balance?token=" + string_0);
			try
			{
				JObject jObject = JObject.Parse(json);
				result = jObject["balance"].ToString(); 
			}
			catch
			{
			}
			return result;
		}

		public static bool smethod_17(string string_0, int int_2 = 60)
		{
			bool result = false;
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string json = requestHTTP.Request("GET", "http://www.primeotp.me/api.php?apikey=" + string_0 + "&action=services");
			JArray jArray = JArray.Parse(json);
			if (jArray.Count > 0)
			{
				result = true;
			}
			return result;
		}

		public static string smethod_18(int int_2 = 60)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			int tickCount = Environment.TickCount;
			try
			{
				while (Environment.TickCount - tickCount < int_2 * 1000)
				{
					string json = requestHTTP.Request("POST", "https://api.internal.temp-mail.io/api/v3/email/new");
					JObject jObject = JObject.Parse(json);
					string text2 = jObject["email"]!.ToString();
					if (text2 != "")
					{
						text = text2;
					}
					if (!text.Equals(""))
					{
						break;
					}
				}
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_19(string string_0 = "blondemorkin.com", int int_2 = 60)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			int tickCount = Environment.TickCount;
			try
			{
				while (Environment.TickCount - tickCount < int_2 * 1000)
				{
					string s = string.Concat(new string[2] { "domain=", string_0 });
					string json = requestHTTP.Request("POST", "https://api.internal.temp-mail.io/api/v3/email/new", null, Encoding.UTF8.GetBytes(s));
					JObject jObject = JObject.Parse(json);
					string text2 = jObject["email"]!.ToString();
					if (text2 != "")
					{
						text = text2;
					}
					if (!text.Equals(""))
					{
						break;
					}
				}
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_20(string string_0, int int_2 = 60)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			int tickCount = Environment.TickCount;
			try
			{
				while (Environment.TickCount - tickCount < int_2 * 1000)
				{
					string json = requestHTTP.Request("GET", "https://api.internal.temp-mail.io/api/v3/email/" + string_0 + "/messages");
					JArray jArray = JArray.Parse(json);
					if (jArray.Count > 0)
					{
						string input = jArray[0]["subject"]!.ToString();
						string value = Regex.Match(input, "\\d{5}", RegexOptions.Singleline).Value;
						text = value;
					}
					if (!text.Equals(""))
					{
						break;
					}
				}
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_21(string string_0, ref string string_1, int int_2 = 60, int int_3 = 1)
		{
			string text = "";
			GClass7 gClass = new GClass7();
			string text2 = "";
			for (int i = 0; i < 33; i++)
			{
				try
				{
					text2 = gClass.method_1("https://administrator.codetext247.com/api/sim-request?token=" + string_0 + "&service=19");
					JObject jObject = JObject.Parse(text2);
					text = jObject["phone"].ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			return text + "|" + text;
		}


		public static string smethod_22(string string_0, ref string string_1, int int_2 = 60, int int_3 = 1)
		{
			string text = "";
			if (int_3 == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < int_2 * 1000)
					{
						string json = requestHTTP.Request("GET", "http://www.primeotp.me/api.php?apikey=" + string_0 + "&action=create-request&serviceId=1&count=1");
						JObject jObject = JObject.Parse(json);
						Thread.Sleep(TimeSpan.FromSeconds(3.0));
						string text2 = jObject["status"]!.ToString();
						if ((text2 == "200") ? true : false)
						{
							text = jObject["results"]!["data"]![0]!["sdt"]!.ToString();
							string_1 = jObject["results"]!["data"]![0]!["requestId"]!.ToString();
						}
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		}

		public static string smethod_23(string string_0, ref string string_1, int int_2 = 60, int int_3 = 13)
		{
			string result = "";
			if (int_3 == 13)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				_ = Environment.TickCount;
				try
				{
					string json = requestHTTP.Request("GET", "https://api.tempsms.co/create?api_key=" + string_0 + "&service_id=" + int_3);
					JObject jObject = JObject.Parse(json);
					string text = jObject["status_code"]!.ToString();
					if ((text == "0") ? true : false)
					{
						string_1 = jObject["request_id"]!.ToString();
						result = smethod_25(string_0, string_1);
					}
				}
				catch
				{
				}
			}
			return result;
		}

		public static string smethod_24(string apiKey, ref string idRequest, int timeout = 60, int services = 1) // Phone 1
		{
			GClass8 gClass = new GClass8();
			string text = "";
			for (int i = 0; i < timeout; i++)
			{
				try
				{
					text = gClass.method_0("http://otpfb.com/api.php?apikey=" + apiKey + "&action=create-request&serviceId=1&count=1");
					if (text != "")
					{
						JObject jObject = JObject.Parse(text);
						return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
					}
					Thread.Sleep(1000);
				}
				catch
				{
				}
			}
			return "";
		}

		public static string smethod_25(string string_0, string string_1, int int_2 = 60)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			int tickCount = Environment.TickCount;
			try
			{
				while (Environment.TickCount - tickCount < int_2 * 1000)
				{
					string json = requestHTTP.Request("GET", "https://api.tempsms.co/detail?api_key=" + string_0 + "&request_id=" + string_1);
					JObject jObject = JObject.Parse(json);
					string text2 = jObject["status_code"]!.ToString();
					if ((text2 == "0") ? true : false)
					{
						text = jObject["phone"]!.ToString();
					}
					if (!text.Equals(""))
					{
						break;
					}
				}
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_26(string string_0, string string_1, int int_2 = 60, int int_3 = 1)
		{
			string text = "";
			GClass7 gClass = new GClass7();
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= int_2 * 1000)
			{
				try
				{
					string json = gClass.method_0("https://administrator.codetext247.com/api/get-message?token=" + string_0 + "&phone=" + string_1);
					JObject jObject = JObject.Parse(json);
					try
					{
						text = Regex.Match(jObject["message"].ToString(), "\\d+").Value;
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text;
		}


		public static string smethod_27(string string_0, string string_1, int int_2 = 60, int int_3 = 1)
		{
			string text = "";
			if (int_3 == 1)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < int_2 * 1000)
					{
						string json = requestHTTP.Request("GET", "http://www.primeotp.me/api.php?apikey=" + string_0 + "&action=data-request&requestId=" + string_1);
						JObject jObject = JObject.Parse(json);
						string text2 = jObject["status"]!.ToString();
						if ((text2 == "200") ? true : false)
						{
							text = jObject["data"]![0]!["otp"]!.ToString();
						}
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		}

		public static string smethod_28(string string_0, string string_1, int int_2 = 60)
		{
			string text = "";
			GClass7 gClass = new GClass7();
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= int_2 * 1000)
			{
				try
				{
					string json = gClass.method_0(" http://api.codesim.net/api/CodeSim/KiemTraGiaoDich?apikey=" + string_0 + "&giaodich_id=" + string_1);
					JObject jObject = JObject.Parse(json);
					if (jObject["stt"].ToString() == "1")
					{
						try
						{
							text = jObject["data"]["listSms"][0]["number"].ToString();
							if (text != "")
							{
								break;
							}
						}
						catch (Exception)
						{
						}
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text;
		}

		public static bool smethod_29()
		{
			bool result = false;
			string text = DateTime.Now.ToShortDateString();
			if (text == DateTime.Now.ToString("dd/MM/yyyy"))
			{
				result = true;
			}
			return result;
		}

		public static string smethod_30(string string_0, int int_2 = 60)
		{
			string result = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string s = string.Concat(new string[2] { "clientKey=", string_0 });
			string json = requestHTTP.Request("POST", "https://api.anycaptcha.com/getBalance", null, Encoding.UTF8.GetBytes(s));
			JObject jObject = JObject.Parse(json);
			string value = jObject["errorId"]!.ToString();
			if ((Convert.ToInt32(value) == 0) ? true : false)
			{
				result = jObject["balance"]!.ToString();
			}
			return result;
		}

		public static string smethod_31(string string_0, string string_1, int int_2 = 90, string string_2 = "00000")
		{
			bool flag = false;
			string text = "";
			int tickCount = Environment.TickCount;
			try
			{
				do
				{
					if (Environment.TickCount - tickCount <= int_2 * 1000)
					{
						MailServer mailServer = new MailServer("imap-mail.outlook.com", string_0, string_1, ServerProtocol.Imap4);
						MailClient mailClient = new MailClient("TryIt");
						mailServer.SSLConnection = true;
						mailServer.Port = 993;
						Thread.Sleep(5000);
						try
						{
							mailClient.Connect(mailServer);
							mailClient.GetMailInfosParam.Reset();
							MailInfo[] mailInfos = mailClient.GetMailInfos();
							for (int i = 0; i < mailInfos.Length; i++)
							{
								Mail mail = mailClient.GetMail(mailInfos[i]);
								mailClient.MarkAsRead(mailInfos[i], read: true);
								if (!mail.From.Address.Contains("registration@facebookmail.com"))
								{
									continue;
								}
								Match match = Regex.Match(mail.Subject, "\\d+\\s");
								if (match.Success)
								{
									text = match.Value.Trim();
									if ((!text.Equals("") && text != string_2) || string_2 == "00000")
									{
										flag = true;
										break;
									}
								}
							}
							mailClient.Quit();
							mailClient.Close();
						}
						catch
						{
							mailClient.Quit();
							mailClient.Close();
						}
						continue;
					}
					return "";
				}
				while (!flag);
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_32(string string_0, string string_1, string string_2)
		{
			string result = "";
			try
			{
				xNet.HttpRequest httpRequest = new xNet.HttpRequest();
				httpRequest.KeepAlive = true;
				httpRequest.Cookies = new CookieDictionary();
				httpRequest.AddHeader(xNet.HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
				httpRequest.AddHeader(xNet.HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
				httpRequest.UserAgent = xNet.Http.ChromeUserAgent();
				string text = smethod_81("ewogICAgImNsaWVudEtleSI6ICJ4eHh4eHh4eHgiLAogICAgInRhc2siOiB7CiAgICAgICAgInR5cGUiOiAiRnVuQ2FwdGNoYVRhc2tQcm94eWxlc3MiLAogICAgICAgICJ3ZWJzaXRlVVJMIjogInp6enp6enp6enoiLAogICAgICAgICJ3ZWJzaXRlUHVibGljS2V5IjogInl5eXl5eXl5eSIKICAgIH0KfQ==");
				text = text.Replace("xxxxxxxxx", string_0);
				text = text.Replace("yyyyyyyyy", string_2);
				text = text.Replace("zzzzzzzzzz", string_1);
				string text2 = httpRequest.Post("https://api.anycaptcha.com/createTask", text, "application/json").ToString();
				if (text2.Contains("\"errorId\":0"))
				{
					string value = Regex.Match(text2, "taskId\":(.*?)}").Groups[1].Value;
					string text3 = smethod_81("ewogICAgImNsaWVudEtleSI6Inl5eXl5eXl5eSIsCiAgICAidGFza0lkIjogeHh4Cn0=");
					text3 = text3.Replace("yyyyyyyyy", string_0);
					text3 = text3.Replace("xxx", value);
					int num = 0;
					while (num < 62)
					{
						text2 = httpRequest.Post("https://api.anycaptcha.com/getTaskResult", text3, "application/json").ToString();
						if (text2.Contains("processing"))
						{
							Thread.Sleep(1000);
							if (num <= 60)
							{
								num++;
								continue;
							}
							Console.WriteLine("Time out!!!");
							return result;
						}
						string value2 = Regex.Match(text2, "token\":\"(.*?)\"").Groups[1].Value;
						result = value2;
						goto end_IL_0006;
					}
				}
				return result;
			end_IL_0006:;
			}
			catch
			{
			}
			return result;
		}

		public static string smethod_33(string string_0)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: " + Class60.smethod_0(random_0)
			});
			try
			{
				string text = requestHTTP.Request("POST", "https://graph.facebook.com/" + string_0 + "/picture?redirect=false");
				if (!string.IsNullOrEmpty(text))
				{
					if (text.Contains("height") && text.Contains("width"))
					{
						return "1|";
					}
					return "0|";
				}
			}
			catch (Exception)
			{
			}
			return "2|";
		}

		public static string smethod_34(string string_0, string string_1, int int_2 = 10)
		{
			Process process = new Process();
			process.StartInfo.FileName = string_0;
			process.StartInfo.Arguments = string_1;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
			process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
			StringBuilder stringBuilder_0 = new StringBuilder();
			process.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					stringBuilder_0.Append(e.Data + "\n");
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			if (int_2 < 0)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(int_2 * 1000);
			}
			process.Close();
			return stringBuilder_0.ToString();
		}

		public static string smethod_35(string string_0, int int_2)
		{
			string text = "";
			try
			{
				Class59 @class = new Class59("", Class60.smethod_0(random_0), string_0, int_2);
				return @class.method_0("https://api64.ipify.org/");
			}
			catch (Exception)
			{
				return smethod_37(string_0, int_2);
			}
		}

		public static string smethod_36(string string_0, int int_2, int int_3 = 30)
		{
			string text = "";
			if (int_2 == 0 && string_0 != "")
			{
				WebProxy webProxy = new WebProxy(string_0.Split(':')[0], Convert.ToInt32(string_0.Split(':')[1]));
				if (string_0.Split(':').Length == 4)
				{
					webProxy.Credentials = new NetworkCredential(string_0.Split(':')[2], string_0.Split(':')[3]);
				}
				try
				{
					Uri baseUrl = new Uri("https://api64.ipify.org/");
					IRestResponse restResponse = new RestClient
					{
						BaseUrl = baseUrl,
						Proxy = webProxy,
						CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Revalidate)
					}.Execute(new RestRequest
					{
						Method = Method.GET,
						Timeout = int_3 * 1000,
						RequestFormat = DataFormat.Json
					});
					text = ((restResponse.ErrorException == null) ? restResponse.Content : restResponse.ErrorException!.Message);
				}
				catch (Exception)
				{
				}
			}
			else
			{
				try
				{
					Class59 @class = new Class59("", Class60.smethod_0(random_0), string_0, int_2);
					text = @class.method_0("https://api64.ipify.org/");
				}
				catch (Exception)
				{
					text = smethod_37(string_0, int_2);
				}
			}
			if (text.Contains("html") || (text.Split('.').Length != 4 && text.Split(':').Length != 8))
			{
				text = "";
			}
			return text;
		}

		public static string smethod_37(string string_0, int int_2)
		{
			string result = "";
			try
			{
				Class59 @class = new Class59("", Class60.smethod_0(random_0), string_0, int_2);
				result = @class.method_0("https://ipcuatoi.com/");
				result = @class.method_0("http://v4v6.ipv6-test.com/api/myip.php");
			}
			catch (Exception)
			{
			}
			return result;
		}

		public static List<string> smethod_38(List<string> list_0)
		{
			string text = "";
			int num = list_0.Count;
			int num2 = 0;
			while (num != 0)
			{
				num2 = random_0.Next(0, list_0.Count);
				num--;
				text = list_0[num];
				list_0[num] = list_0[num2];
				list_0[num2] = text;
			}
			return list_0;
		}

		public static void smethod_39(string string_0)
		{
			int num = Directory.GetDirectories(string_0 + "\\vms", "*", SearchOption.TopDirectoryOnly).Length;
			for (int i = 0; i < num; i++)
			{
				if (i != 0 && Directory.Exists(string_0 + "\\vms\\leidian" + i))
				{
					string string_ = string_0 + "\\vms\\leidian" + i;
					smethod_40(string_);
				}
			}
			int num2 = Directory.GetFiles(string_0 + "\\vms\\config", "*.config", SearchOption.TopDirectoryOnly).Length;
			for (int j = 0; j < num2; j++)
			{
				if (j != 0 && File.Exists(string_0 + "\\vms\\config\\leidian" + j + ".config"))
				{
					string string_2 = string_0 + "\\vms\\config\\leidian" + j + ".config";
					smethod_76(string_2);
				}
			}
		}

		public static bool smethod_40(string string_0)
		{
			try
			{
				Directory.Delete(string_0, recursive: true);
				return true;
			}
			catch
			{
			}
			return false;
		}

		public static bool smethod_41(string string_0)
		{
			bool flag = false;
			string text = smethod_34("rasdial.exe", "\"" + string_0 + "\"", 3);
			if (text.Contains("Successfully connected to "))
			{
				flag = true;
			}
			else
			{
				if (text.Contains("You are already connected to "))
				{
					for (int i = 0; i < 3; i++)
					{
						text = smethod_34("rasdial.exe", "\"" + string_0 + "\" /disconnect", 3);
						if (!(text.Trim() == "Command completed successfully."))
						{
							smethod_62(1.0);
							continue;
						}
						flag = true;
						smethod_62(1.0);
						for (int j = 0; j < 3; j++)
						{
							text = smethod_34("rasdial.exe", "\"" + string_0 + "\"", 3);
							if (!text.Contains("Successfully connected to "))
							{
								smethod_62(1.0);
								continue;
							}
							flag = true;
							break;
						}
						smethod_62(1.0);
						return flag;
					}
				}
				flag = false;
			}
			return flag;
		}
        //Getmail chothuesimcode
        public static string smethod_42(string string_0, string string_1, int int_2 = 60)
        {
            string text = "";
            int num = 0;
            Class59 @class = new Class59();
            num = ((!(string_1 == "hotmail")) ? 1009 : 1017);
            string text2 = "";
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    string json = @class.method_0("https://chothuesimcode.com/api?act=number&apik=" + string_0 + "&appId=" + num);
                    JObject jObject = JObject.Parse(json);
                    text2 = jObject["Result"]!["Id"]!.ToString();
                    if (text2 != "")
                    {
                        text = jObject["Result"]!["Number"]!.ToString();
                        break;
                    }
                    Thread.Sleep(3000);
                    continue;
                }
                catch
                {
                    throw;
                }
            }
            return text2 + "|" + text;
        }

        //Otp again chothuesimcode
        public static string smethod_43(string string_0, string string_1, int int_2 = 120)
        {
            string text = "";
            Class59 @class = new Class59();
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount <= int_2 * 1000)
            {
                string json = @class.method_0("https://chothuesimcode.com/api?act=code&apik=" + string_0 + "&id=" + string_1);
                JObject jObject = JObject.Parse(json);
                if (!(jObject["ResponseCode"]!.ToString() == "0"))
                {
                    continue;
                }
                try
                {
                    text = jObject["Result"]!["Code"]!.ToString();
                    if (text != "")
                    {
                        break;
                    }
                    Thread.Sleep(3000);
                    continue;
                }
                catch
                {
                    continue;
                }
            }
            return text;
        }

        //Otp Chothuesimcode
        public static string smethod_44(string string_0, string string_1, int int_2 = 60, int int_3 = 1001)
        {
            string text = "";
            if (int_3 == 1001)
            {
                RequestHTTP requestHTTP = new RequestHTTP();
                requestHTTP.SetSSL(SecurityProtocolType.Tls12);
                requestHTTP.SetKeepAlive(k: true);
                requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
                int tickCount = Environment.TickCount;
                try
                {
                    while (Environment.TickCount - tickCount < int_2 * 1000)
                    {
                        string json = requestHTTP.Request("GET", "https://chothuesimcode.com/api?act=code&apik=" + string_0 + "&id=" + string_1);
                        JObject jObject = JObject.Parse(json);
                        string text2 = jObject["ResponseCode"]!.ToString();
                        if ((text2 == "0") ? true : false)
                        {
                            text = jObject["Result"]!["Code"]!.ToString();
                        }
                        if (!text.Equals(""))
                        {
                            break;
                        }
                    }
                }
                catch
                {
                }
            }
            return text;
        }

        public static string smethod_45(string string_0, string string_1, int int_2 = 60, int int_3 = 13)
		{
			string text = "";
			if (int_3 == 13)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < int_2 * 1000)
					{
						string json = requestHTTP.Request("GET", "https://api.tempsms.co/sms?api_key=" + string_0 + "&request_id=" + string_1);
						JObject jObject = JObject.Parse(json);
						string text2 = jObject["status_code"]!.ToString();
						if ((text2 == "0") ? true : false)
						{
							JArray jArray = JArray.Parse(jObject["data"]!.ToString());
							if (jArray.Count > 0)
							{
								text = jArray[0]["otp"]!.ToString();
							}
						}
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		}

		public static string smethod_46(string apiKey, string idRequest, int timeout = 60, int services = 1) // Get code otptextnow
		{
			GClass8 gClass = new GClass8();
			string text = "";
			string text2 = "";
			for (int i = 0; i < timeout; i++)
			{
				try
				{
					text = gClass.method_0("http://otpfb.com/api.php?apikey=" + apiKey + "&action=data-request&requestId=" + idRequest);
					if (text != "")
					{
						JObject jObject = JObject.Parse(text);
						text2 = jObject["data"]![0]!["otp"]!.ToString();
						if (text2 != "")
						{
							return Regex.Match(text2, "\\d+").Value;
						}
					}
					Thread.Sleep(1000);
				}
				catch
				{
				}
			}
			return "";
		}

        //Get phone chothuesimcode
        public static string smethod_47(string string_0, ref string string_1, int int_2 = 60, int int_3 = 1001)
        {
            string text = "";
            if (int_3 == 1001)
            {
                RequestHTTP requestHTTP = new RequestHTTP();
                requestHTTP.SetSSL(SecurityProtocolType.Tls12);
                requestHTTP.SetKeepAlive(k: true);
                requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
                int tickCount = Environment.TickCount;
                try
                {
                    while (Environment.TickCount - tickCount < int_2 * 1000)
                    {
                        string json = requestHTTP.Request("GET", "https://chothuesimcode.com/api?act=number&apik=" + string_0 + "&appId=1001");
                        JObject jObject = JObject.Parse(json);
                        string text2 = jObject["ResponseCode"]!.ToString();
                        if ((text2 == "0") ? true : false)
                        {
                            text = jObject["Result"]!["Number"]!.ToString();
                            string_1 = jObject["Result"]!["Id"]!.ToString();
                        }
                        if (!text.Equals(""))
                        {
                            break;
                        }
                    }
                }
                catch
                {
                }
            }
            return text;
        }

        public static string smethod_48(string string_0, int int_2 = 90) // codesim.net
		{
			string text = "";
			GClass7 gClass = new GClass7();
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 33; i++)
			{
				try
				{
					text2 = gClass.method_0("http://api.codesim.net/api/CodeSim/DangKy_GiaoDich?apikey=" + string_0 + "&dichvu_id=20&so_sms_nhan=1");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["data"]["id_giaodich"].ToString();
					if (text3 != "")
					{
						text = jObject["data"]["phoneNumber"].ToString();
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			return text3 + "|" + text;
		}


		private static async Task<string> smethod_49(Uri uri_0)
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


		public static string smethod_55()
		{
			string result = "";
			try
			{
				Class59 @class = new Class59();
				string text = "";
				text = @class.method_0("http://lumtest.com/myip.json");
				if (JObject.Parse(text).ContainsKey("ip"))
				{
					result = JObject.Parse(text)["ip"]!.ToString();
				}
			}
			catch
			{
			}
			return result;
		}

		public static bool smethod_56(int int_2, int int_3, string string_0, string string_1)
		{
			bool result = false;
			string text = "";
			try
			{
				switch (int_2)
				{
					case 0:
						return false;
					case 1:
						if (int_3 == 0)
						{
							result = smethod_41(string_0);
						}
						break;
					case 4:
						{
							string text2 = smethod_55();
							IntPtr intptr_ = AutoControl.smethod_3(null, "HMA VPN");
							AutoControl.smethod_1(intptr_);
							AutoControl.smethod_17(AutoControl.smethod_12(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 464, 366);
							Thread.Sleep(10000);
							string text3 = smethod_55();
							int tickCount = Environment.TickCount;
							do
							{
								text = smethod_55();
							}
							while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
							if (text != text2)
							{
								result = true;
							}
							break;
						}
					case 2:
					case 3:
						break;
				}
			}
			catch (Exception exception_)
			{
				smethod_82(exception_, "Error ChangeIP");
			}
			return result;
		}

		public static string smethod_57(string string_0, ref string string_1, int int_2 = 60, int int_3 = 7)
		{
			string text = "";
			if (int_3 == 7)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(true);
				requestHTTP.SetDefaultHeaders(new string[]
				{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36"
				});
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < int_2 * 1000)
					{
						string json = requestHTTP.Request("GET", "https://api.viotp.com/request/get?token=" + string_0 + "&serviceId=7", null, null, true, null, 60000);
						JObject jobject = JObject.Parse(json);
						int num = Convert.ToInt32(jobject["status_code"].ToString());
						if (num == 200)
						{
							text = jobject["data"]["phone_number"].ToString();
							string_1 = jobject["data"]["request_id"].ToString();
						}
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		}

		public static string smethod_58(string string_0, int int_2 = 60)
		{
			string str = "";
			int num = 0;
			Class59 @class = new Class59("", "", "", 0);
			string text = "";
			for (int i = 0; i < 5; i++)
			{
				try
				{
					string json = @class.method_0("https://api.viotp.com/request/get?token=" + string_0 + "&serviceId=5" + num.ToString());
					JObject jobject = JObject.Parse(json);
					text = jobject["data"]["request_id"].ToString();
					if (text != "")
					{
						str = jobject["data"]["phone_number"].ToString();
						break;
					}
					Thread.Sleep(3000);
				}
				catch
				{
					throw;
				}
			}
			return text + "|" + str;
		}

		public static string smethod_59(string string_0, int int_2 = 60)
		{
			string text = "";
			GClass7 gClass = new GClass7();
			string text2 = "";
			for (int i = 0; i < 33; i++)
			{
				try
				{
					text2 = gClass.method_1("https://administrator.codetext247.com/api/sim-request?token=" + string_0 + "&service=19");
					JObject jObject = JObject.Parse(text2);
					text = jObject["phone"].ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			return text + "|" + text;
		}


		public static string smethod_60(string string_0, int int_2 = 60)
		{
			string text = "";
			int num = 0;
			Class59 @class = new Class59();
			string text2 = "";
			for (int i = 0; i < 5; i++)
			{
				try
				{
					string json = @class.method_0("http://www.primeotp.me/api.php?apikey=" + string_0 + "&action=create-request&serviceId=1&count=1" + num);
					JObject jObject = JObject.Parse(json);
					text2 = jObject["results"]!["data"]![0]!["requestId"]!.ToString();
					if (text2 != "")
					{
						text = jObject["results"]!["data"]![0]!["sdt"]!.ToString();
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					throw;
				}
			}
			return text2 + "|" + text;
		}

		public static string smethod_61(string string_0, string string_1, int int_2 = 60, int int_3 = 7)
		{
			string text = "";
			if (int_3 == 7)
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(true);
				requestHTTP.SetDefaultHeaders(new string[]
				{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36"
				});
				int tickCount = Environment.TickCount;
				try
				{
					while (Environment.TickCount - tickCount < int_2 * 1000)
					{
						string json = requestHTTP.Request("GET", "https://api.viotp.com/session/get?requestId=" + string_1 + "&token=" + string_0, null, null, true, null, 60000);
						JObject jobject = JObject.Parse(json);
						int num = Convert.ToInt32(jobject["status_code"].ToString());
						if (num == 200)
						{
							text = jobject["data"]["Code"].ToString();
						}
						if (!text.Equals(""))
						{
							break;
						}
					}
				}
				catch
				{
				}
			}
			return text;
		}

		public static void smethod_62(double double_0)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		}

		public static void smethod_63(string string_0)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(string_0);
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		public static bool smethod_64(string string_0)
		{
			bool result;
			if (string_0 == "")
			{
				result = false;
			}
			else
			{
				foreach (char c in string_0)
				{
					if (!char.IsDigit(c))
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		public static void smethod_65(ref List<int> list_0, int int_2)
		{
			List<int> list = list_0;
			lock (list)
			{
				list_0[int_2] = 0;
			}
		}

		public static string smethod_66(Bitmap bitmap_0)
		{
			try
			{
				if (bitmap_0 != null)
				{
					QRCodeDecoder qRCodeDecoder = new QRCodeDecoder();
					return qRCodeDecoder.Decode(new QRCodeBitmapImage(bitmap_0));
				}
				return "";
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static string smethod_67(Bitmap bitmap_0)
		{
			try
			{
				if (bitmap_0 != null)
				{
					BarcodeReader barcodeReader = new BarcodeReader();
					Result result = barcodeReader.Decode(bitmap_0);
					if (result != null)
					{
						return result.ToString().Trim();
					}
					return string.Empty;
				}
				return "";
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static string smethod_68(Bitmap bitmap_0)
		{
			QRCodeDecoder qRCodeDecoder = new QRCodeDecoder();
			return qRCodeDecoder.Decode(new QRCodeBitmapImage(bitmap_0), Encoding.Unicode);
		}

		public static string smethod_69(string string_0)
		{
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				return requestHTTP.Request("GET", string_0);
			}
			catch
			{
				return null;
			}
		}

		public static string smethod_70(string string_0)
		{
			string text = "";
			try
			{
				string_0 = string_0.Replace(" ", "").Trim();
				string string_ = "http://app.minsoftware.vn/api/2fa1?secret=" + string_0;
				string string_2 = "http://2fa.live/tok/" + string_0;
				for (int i = 0; i < 5; i++)
				{
					text = "";
					try
					{
						string text2 = smethod_69(string_2);
						if (text2.Contains("token"))
						{
							JObject jObject = JObject.Parse(text2);
							text = jObject["token"]!.ToString().Trim();
						}
					}
					catch (Exception exception_)
					{
						smethod_82(exception_, string_2);
					}
					try
					{
						if (text.Trim() == "")
						{
							text = smethod_69(string_);
						}
					}
					catch (Exception exception_2)
					{
						smethod_82(exception_2, string_);
					}
					if (!(text != "") || !smethod_64(text))
					{
						smethod_62(1.0);
						continue;
					}
					for (int j = text.Length; j < 6; j++)
					{
						text = "0" + text;
					}
					break;
				}
			}
			catch
			{
			}
			return text;
		}

		public static string smethod_71(string string_0)
		{
			try
			{
				byte[] secretKey = Base32Encoding.ToBytes(string_0.Trim().Replace(" ", ""));
				Totp totp = new Totp(secretKey);
				return totp.ComputeTotp(DateTime.UtcNow);
			}
			catch (Exception exception_)
			{
				smethod_82(exception_, "GetTotp(" + string_0 + ")");
			}
			return "";
		}

		public static string smethod_72(string string_0)
		{
			string text = smethod_70(string_0);
			if (text == "")
			{
				text = smethod_71(string_0);
			}
			return text;
		}

		public static bool smethod_73(string string_0)
		{
			try
			{
				FormCollection openForms = Application.OpenForms;
				IEnumerator enumerator = openForms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form_0 = (Form)enumerator.Current;
					if (form_0.Name == string_0)
					{
						form_0.Invoke((MethodInvoker)delegate
						{
							form_0.Close();
						});
						break;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		public static string smethod_74(string string_0)
		{
			Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
			string input = string_0.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}

		public static string smethod_75(string string_0)
		{
			string_0 = smethod_74(string_0);
			string_0 = string_0.ToLower().Replace(" ", "");
			string text = "0123456789";
			Random random = new Random();
			int num = 4;
			for (int i = 0; i < num; i++)
			{
				string_0 += text[random.Next(0, text.Length)];
			}
			return string_0;
		}

		public static bool smethod_76(string string_0)
		{
			try
			{
				File.Delete(string_0);
				return true;
			}
			catch
			{
			}
			return false;
		}

		public static List<string> smethod_77(List<string> list_0)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < list_0.Count; i++)
			{
				string text = list_0[i].Trim();
				if (text != "")
				{
					list.Add(text);
				}
			}
			return list;
		}

		public static string smethod_78(int int_2, Random random_1 = null)
		{
			string text = "";
			if (random_1 == null)
			{
				random_1 = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < int_2; i++)
			{
				text += text2[random_1.Next(0, text2.Length)];
			}
			return text;
		}

		public static string smethod_79(string string_0, string string_1 = "X2")
		{
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(string_1));
			}
			return stringBuilder.ToString();
		}

		public static string smethod_80(int int_2, Random random_1 = null)
		{
			string text = "";
			if (random_1 == null)
			{
				random_1 = new Random();
			}
			string text2 = "0123456789";
			for (int i = 0; i < int_2; i++)
			{
				text += text2[random_1.Next(0, text2.Length)];
			}
			return text;
		}

		public static string smethod_81(string string_0)
		{
			byte[] bytes = Convert.FromBase64String(string_0);
			return Encoding.UTF8.GetString(bytes);
		}

		public static void smethod_82(Exception exception_0, string string_0 = "")
		{
			try
			{
				using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
				streamWriter.WriteLine("-----------------------------------------------------------------------------");
				streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
				if (string_0 != "")
				{
					streamWriter.WriteLine("Error: " + string_0);
				}
				streamWriter.WriteLine();
				if (exception_0 != null)
				{
					streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
					streamWriter.WriteLine("Message: " + exception_0.Message);
					streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
					exception_0 = exception_0.InnerException;
				}
			}
			catch
			{
			}
		}

		public static int smethod_83(ref List<int> list_0)
		{
			int result = 0;
			List<int> list = list_0;
			lock (list)
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					if (list_0[i] == 0)
					{
						result = i;
						list_0[i] = 1;
						break;
					}
				}
			}
			return result;
		}

		public static bool smethod_84(string string_0)
		{
			try
			{
				FormCollection openForms = Application.OpenForms;
				foreach (object item in openForms)
				{
					Form form = (Form)item;
					if (form.Name == string_0)
					{
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		public static string smethod_85(int int_2 = 0)
		{
			string result = "";
			string text = "";
			switch (int_2)
			{
				case 0:
					text = "vn";
					break;
				case 1:
					text = "us";
					break;
			}
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
			string text2 = "";
			text2 = ((int_2 != 0 && int_2 != 1) ? "https://api.proxyorbit.com/v1/?facebook=true&token=sS1wDnGiv5U44M66jMPPjDpdGV8UO1zzPaIXstCuEGo&rtt=2&protocol=http&ssl=true" : ("https://api.proxyorbit.com/v1/?facebook=true&token=sS1wDnGiv5U44M66jMPPjDpdGV8UO1zzPaIXstCuEGo&ssl=true&protocol=http&location=" + text));
			while (true)
			{
				string json = requestHTTP.Request("GET", text2);
				JObject jObject = JObject.Parse(json);
				if (!jObject.ContainsKey("error"))
				{
					string text3 = jObject["protocol"]!.ToString();
					if (!(text3 != "http") && jObject.ContainsKey("ip") && jObject.ContainsKey("port"))
					{
						result = jObject["ip"]!.ToString() + ":" + jObject["port"]!.ToString();
						break;
					}
					continue;
				}
				break;
			}
			return result;
		}
	}
}
