using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ToolRegFB;

namespace ns6
{
	internal class Class15
	{
		[CompilerGenerated]
		private sealed class Class16
		{
			public DataGridView dataGridView_0;

			public int int_0;

			public string string_0;

			public string string_1;

			public int int_1;
		}

		[CompilerGenerated]
		private sealed class Class17
		{
			public int int_0;

			public Class16 class16_0;

			internal void method_0()
			{
				class16_0.dataGridView_0.Rows[class16_0.int_0].Cells[class16_0.string_0].Value = class16_0.string_1.Replace("{time}", (class16_0.int_1 - (Environment.TickCount - int_0) / 1000).ToString());
			}
		}

		[CompilerGenerated]
		private sealed class Class18
		{
			public DataGridView dataGridView_0;

			public int int_0;

			public string string_0;

			public string string_1;

			public int int_1;
		}

		[CompilerGenerated]
		private sealed class Class19
		{
			public int int_0;

			public Class18 class18_0;

			internal void method_0()
			{
				class18_0.dataGridView_0.Rows[class18_0.int_0].Cells[class18_0.string_0].Value = class18_0.string_1.Replace("{time}", (class18_0.int_1 - (Environment.TickCount - int_0) / 1000).ToString());
			}
		}

		[CompilerGenerated]
		private sealed class Class20
		{
			public string string_0;

			public DataGridView dataGridView_0;

			public int int_0;

			public int int_1;

			internal void method_0()
			{
				string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
			}
		}

		[CompilerGenerated]
		private sealed class Class21
		{
			public string string_0;

			public DataGridView dataGridView_0;

			public int int_0;

			public string string_1;

			internal void method_0()
			{
				string_0 = dataGridView_0.Rows[int_0].Cells[string_1].Value.ToString();
			}
		}

		[CompilerGenerated]
		private sealed class Class22
		{
			public DataGridView dataGridView_0;

			public int int_0;

			public string string_0;

			public object object_0;

			internal void method_0()
			{
				dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class23
		{
			public DataGridView dataGridView_0;

			public int int_0;

			public int int_1;

			public object object_0;

			internal void method_0()
			{
				dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
			}
		}

		public static void smethod_0(DataGridView dataGridView_0, int int_0, string string_0, int int_1 = 0, string string_1 = "Đơ\u0323i {time} giây...")
		{
			try
			{
				int int_2 = Environment.TickCount;
				while ((Environment.TickCount - int_2) / 1000 - int_1 < 0)
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						dataGridView_0.Rows[int_0].Cells[string_0].Value = string_1.Replace("{time}", (int_1 - (Environment.TickCount - int_2) / 1000).ToString());
					});
					Common.smethod_62(0.5);
				}
			}
			catch
			{
			}
		}

		public static void smethod_1(DataGridView dataGridView_0, int int_0, string string_0, int int_1 = 0, int int_2 = 0, string string_1 = "Đơ\u0323i {time} giây...")
		{
			try
			{
				int int_3 = Environment.TickCount;
				while ((Environment.TickCount - int_3) / 1000 - int_1 < 0)
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						dataGridView_0.Rows[int_0].Cells[string_0].Value = string_1.Replace("{time}", (int_2 - (Environment.TickCount - int_3) / 1000).ToString());
					});
					Common.smethod_62(0.5);
				}
			}
			catch
			{
			}
		}

		public static string smethod_2(DataGridView dataGridView_0, int int_0, int int_1)
		{
			string string_0 = "";
			try
			{
				if (dataGridView_0.Rows[int_0].Cells[int_1].Value != null)
				{
					try
					{
						string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
					}
					catch
					{
						dataGridView_0.Invoke((MethodInvoker)delegate
						{
							string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
						});
					}
				}
			}
			catch
			{
			}
			return string_0;
		}

		public static string smethod_3(DataGridView dataGridView_0, int int_0, string string_0)
		{
			string string_ = "";
			try
			{
				if (dataGridView_0.Rows[int_0].Cells[string_0].Value != null)
				{
					try
					{
						string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
					}
					catch
					{
						dataGridView_0.Invoke((MethodInvoker)delegate
						{
							string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
						});
					}
				}
			}
			catch
			{
			}
			return string_;
		}

		public static void smethod_4(DataGridView dataGridView_0, int int_0, string string_0, object object_0)
		{
			try
			{
				if (string_0 == "cStatus")
				{
					smethod_3(dataGridView_0, int_0, "cId");
				}
				try
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
					});
				}
				catch
				{
					dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
				}
			}
			catch
			{
			}
		}

		public static void smethod_5(DataGridView dataGridView_0, int int_0, int int_1, object object_0)
		{
			try
			{
				try
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
					});
				}
				catch
				{
					dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
				}
			}
			catch
			{
			}
		}
	}
}
