using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpRequest;
using Newtonsoft.Json.Linq;
using ns6;
using ns7;

namespace ns1
{
	internal class Class0
	{
		private static string string_0 = "https://rabbitsocialtools.com/api/";

		private static RequestHTTP requestHTTP_0 = new RequestHTTP();

		public static int smethod_0(Class83 class83_0)
		{
			try
			{
				Class48 @class = new Class48("update.ini");
				string text = @class.method_1("Version", "Infor");
				string s = "name=" + class83_0.name + "&email=" + class83_0.email + "&password=" + class83_0.password + "&macAddress=" + class83_0.macAddress + "&rb_version=" + text;
				string json = requestHTTP_0.Request("POST", string_0 + "register", null, Encoding.UTF8.GetBytes(s));
				JObject jObject = JObject.Parse(json);
				return Convert.ToInt32(jObject["code"]!.ToString());
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static int smethod_1(string string_1, string string_2)
		{
			Class48 @class = new Class48("update.ini");
			string text = @class.method_1("Version", "Infor");
			string s = "email=" + string_1 + "&newPass=" + string_2 + "&rb_version=" + text;
			string json = requestHTTP_0.Request("POST", string_0 + "changepass", null, Encoding.UTF8.GetBytes(s));
			JObject jObject = JObject.Parse(json);
			return Convert.ToInt32(jObject["code"]!.ToString());
		}

		public static Class83 smethod_2(string string_1, string string_2, string string_3)
		{
			try
			{
				Class48 @class = new Class48("update.ini");
				string text = @class.method_1("Version", "Infor");
				Class83 class2 = null;
				string s = "email=" + string_1 + "&password=" + string_2 + "&rb_version=" + text + "&macAddress=" + string_3;
				string json = requestHTTP_0.Request("POST", string_0 + "login", null, Encoding.UTF8.GetBytes(s));
				JObject jObject = JObject.Parse(json);
				int num = Convert.ToInt32(jObject["code"]!.ToString());
				if (num == 200)
				{
					class2 = new Class83();
					class2.name = jObject["data"]![0]!["name"]!.ToString();
					class2.email = jObject["data"]![0]!["email"]!.ToString();
					class2.id = Convert.ToInt32(jObject["data"]![0]!["user_id"]!.ToString());
					class2.token = jObject["data"]![0]!["token"]!.ToString();
					class2.totalMoney = Convert.ToDouble(jObject["data"]![0]!["totalMoney"]!.ToString());
					if (jObject["license"].ToArray().Count() > 0)
					{
						class2.listLicense = new List<Class80>();
						for (int i = 0; i < jObject["license"].ToArray().Count(); i++)
						{
							class2.listLicense.Add(new Class80
							{
								timeExpired = Convert.ToDateTime(jObject["license"]![i]!["time_expired"]!.ToString()),
								typeProduct = jObject["license"]![i]!["name"]!.ToString()
							});
						}
					}
				}
				return class2;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static bool smethod_3(string string_1, string string_2, string string_3, string string_4 = "facebook", string string_5 = "register", double double_0 = 0.0, int int_0 = 1)
		{
			Class48 @class = new Class48("update.ini");
			string text = @class.method_1("Version", "Infor");
			requestHTTP_0.SetDefaultHeaders(new string[1] { "token:" + string_1 });
			string s = "mac_address=" + string_3 + "&user_id=" + string_2 + "&type_proc=" + string_4 + "&xuMua=" + double_0 + "&type_reg=" + string_5 + "&typePackage=" + int_0 + "&rb_version=" + text;
			string empty = string.Empty;
			empty = requestHTTP_0.Request("POST", string_0 + "registerProduct", null, Encoding.UTF8.GetBytes(s));
			if (empty != "")
			{
				JObject jObject = JObject.Parse(empty);
				int num = Convert.ToInt32(jObject["code"]!.ToString());
				if (num == 200)
				{
					return true;
				}
			}
			return false;
		}

		public static string smethod_4(string string_1, string string_2, string string_3, string string_4 = "facebook")
		{
			Class48 @class = new Class48("update.ini");
			string text = @class.method_1("Version", "Infor");
			requestHTTP_0.SetDefaultHeaders(new string[1] { "token:" + string_1 });
			string s = "mac_address=" + string_3 + "&user_id=" + string_2 + "&type_proc=" + string_4 + "&rb_version=" + text;
			string empty = string.Empty;
			empty = requestHTTP_0.Request("POST", string_0 + "checkLicenseKey", null, Encoding.UTF8.GetBytes(s));
			if (empty != "")
			{
				JObject jObject = JObject.Parse(empty);
				int num = Convert.ToInt32(jObject["code"]!.ToString());
				if (num == 200)
				{
					return jObject["data"]![0]!["time_expired"]!.ToString();
				}
				empty = "";
			}
			return empty;
		}

		public static double smethod_5(string string_1, string string_2, string string_3)
		{
			Class48 @class = new Class48("update.ini");
			string text = @class.method_1("Version", "Infor");
			requestHTTP_0.SetDefaultHeaders(new string[1] { "token:" + string_3 });
			string s = "email=" + string_2 + "&user_id=" + string_1 + "&rb_version=" + text;
			string empty = string.Empty;
			empty = requestHTTP_0.Request("POST", string_0 + "capnhatxu", null, Encoding.UTF8.GetBytes(s));
			if (empty != "")
			{
				JObject jObject = JObject.Parse(empty);
				int num = Convert.ToInt32(jObject["code"]!.ToString());
				if (num == 200)
				{
					return Convert.ToDouble(jObject["tongXu"]!.ToString());
				}
			}
			return 0.0;
		}
	}
}
