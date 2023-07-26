using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using ToolRegFB;

namespace ns0
{
	internal class Class50
	{
		private string string_0;

		private JObject jobject_0;

		public Class50(string string_1, bool bool_0 = false)
		{
			if (bool_0)
			{
				if (string_1.Trim() == "")
				{
					string_1 = "{}";
				}
				jobject_0 = JObject.Parse(string_1);
				return;
			}
			try
			{
				if (string_1.Contains("\\") || string_1.Contains("/"))
				{
					string_0 = string_1;
				}
				else
				{
					string_0 = "settings\\" + string_1 + ".json";
				}
				if (!File.Exists(string_0))
				{
					using (File.AppendText(string_0))
					{
					}
				}
				jobject_0 = JObject.Parse(File.ReadAllText(string_0));
			}
			catch
			{
				jobject_0 = new JObject();
			}
		}

		public Class50()
		{
			jobject_0 = new JObject();
		}

		public string method_0(string string_1, string string_2 = "")
		{
			string result = string_2;
			try
			{
				result = ((jobject_0[string_1] == null) ? string_2 : jobject_0[string_1]!.ToString());
			}
			catch
			{
			}
			return result;
		}

		public List<string> method_1(string string_1, int int_0 = 0)
		{
			List<string> list = new List<string>();
			try
			{
				list = ((int_0 != 0) ? method_0(string_1).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : method_0(string_1).Split('\n').ToList());
				list = Common.smethod_77(list);
			}
			catch
			{
			}
			return list;
		}

		public int method_2(string string_1, int int_0 = 0)
		{
			int result = int_0;
			try
			{
				result = ((jobject_0[string_1] == null) ? int_0 : Convert.ToInt32(jobject_0[string_1]!.ToString()));
			}
			catch
			{
			}
			return result;
		}

		public bool method_3(string string_1, bool bool_0 = false)
		{
			bool result = bool_0;
			try
			{
				result = ((jobject_0[string_1] == null) ? bool_0 : Convert.ToBoolean(jobject_0[string_1]!.ToString()));
				return result;
			}
			catch
			{
				return result;
			}
		}

		public void method_4(string string_1, string string_2)
		{
			try
			{
				if (!jobject_0.ContainsKey(string_1))
				{
					jobject_0.Add(string_1, (JToken)string_2);
				}
				else
				{
					jobject_0[string_1] = (JToken)string_2;
				}
			}
			catch (Exception)
			{
			}
		}

		public void method_5(string string_1, object object_0)
		{
			try
			{
				jobject_0[string_1] = (JToken)object_0.ToString();
			}
			catch
			{
			}
		}

		public void method_6(string string_1, List<string> list_0)
		{
			try
			{
				bool flag = false;
				foreach (string item in list_0)
				{
					if (item.Contains("\n"))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					jobject_0[string_1] = (JToken)string.Join("\n|\n", list_0).ToString();
				}
				else
				{
					jobject_0[string_1] = (JToken)string.Join("\n", list_0).ToString();
				}
			}
			catch
			{
			}
		}

		public void method_7(string string_1)
		{
			try
			{
				jobject_0.Remove(string_1);
			}
			catch
			{
			}
		}

		public void method_8(string string_1 = "")
		{
			try
			{
				if (string_1 == "")
				{
					string_1 = string_0;
				}
				File.WriteAllText(string_1, jobject_0.ToString());
			}
			catch
			{
			}
		}

		public string method_9()
		{
			string result = "";
			try
			{
				result = jobject_0.ToString().Replace("\r\n", "");
			}
			catch (Exception)
			{
			}
			return result;
		}
	}
}
