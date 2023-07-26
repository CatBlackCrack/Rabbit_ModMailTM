using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DeviceId;
using HttpRequest;
using KAutoHelper;
using Newtonsoft.Json.Linq;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;
using AutoUpdaterDotNET;
using System.Reflection;
using ToolRegFB.Properties;
using System.Security.Cryptography;
using System.Text;
using AnyCaptchaHelper;

namespace ToolRegFB
{
	public class frmMain : Form
	{
		[CompilerGenerated]
		private sealed class Class31
		{
			public string string_0;

			public frmMain frmMain_0;

			internal void method_0()
			{
				try
				{
					if (string_0 == "start")
					{
						frmMain_0.btnReg.Enabled = false;
						frmMain_0.btnSaveConf.Enabled = false;
						frmMain_0.btnAutoConfig.Enabled = false;
						frmMain_0.btnStop.Enabled = true;
					}
					else if (string_0 == "stop")
					{
						frmMain_0.btnReg.Enabled = true;
						frmMain_0.btnSaveConf.Enabled = true;
						frmMain_0.btnAutoConfig.Enabled = true;
						frmMain_0.btnStop.Enabled = false;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class32
		{
			public frmMain frmMain_0;

			public Thread thread_0;

			public MethodInvoker methodInvoker_0;

			public MethodInvoker methodInvoker_1;

			internal void method_0()
			{
				while (true)
				{
					try
					{
						if (frmMain_0.bool_1 && frmMain_0.list_4.Count > 0)
						{
							bool flag = false;
							while (!flag)
							{
								flag = true;
								for (int i = 0; i < frmMain_0.list_4.Count; i++)
								{
									string text = Class2.smethod_36(frmMain_0.list_4[i].int_0);
									if (string.IsNullOrEmpty(text))
									{
										flag = false;
									}
									else
									{
										frmMain_0.list_4[i].DeviceId = text;
									}
								}
							}
							frmMain_0.bool_1 = false;
						}
					}
					catch
					{
					}
					frmMain_0.method_51(5.0);
				}
			}

			internal void method_1()
			{
				frmMain_0.dgvAcc.Rows.Clear();
			}

			internal void method_2()
			{
				frmMain_0.stIPCur.Text = frmMain_0.method_54();
			}

			internal void method_3()
			{
				frmMain_0.stIPCur.Text = frmMain_0.method_54();
			}

			internal void method_4()
			{
				frmMain_0.btnStop.Text = "Dừng lại";
				frmMain_0.plTrangThai.Text = "Kết thúc đăng ký";
			}
		}

		[CompilerGenerated]
		private sealed class Class33
		{
			public int int_0;

			public List<int> list_0;

			public bool bool_0;

			public bool bool_1;

			public Class32 class32_0;

			internal void method_0()
			{
				class32_0.frmMain_0.method_19("start");
				int num = 0;
				class32_0.frmMain_0.dgvAcc.Invoke((MethodInvoker)delegate
				{
					class32_0.frmMain_0.dgvAcc.Rows.Clear();
				});
				if (class32_0.frmMain_0.int_36 == 0)
				{
					string text = "";
					int num2 = class32_0.frmMain_0.int_1;
					if (num2 == 0)
					{
						num2 = 1;
					}
					int num3 = 0;
					while (num3 < num2 && (class32_0.frmMain_0.queue_0 == null || class32_0.frmMain_0.queue_0.Count != 0))
					{
						text = ((num2 > 1) ? $"Lượt {num3 + 1}/{num2}. " : "");
						if (num2 > 1)
						{
							class32_0.frmMain_0.method_20("Đang reg..." + text);
						}
						else
						{
							class32_0.frmMain_0.method_20("Đang reg...");
						}
						Common.smethod_62(0.5);
						if (class32_0.frmMain_0.bool_0)
						{
							break;
						}
						int num4 = 0;
						while (num4 < class32_0.frmMain_0.int_11 && !class32_0.frmMain_0.bool_0 && !class32_0.frmMain_0.bool_0)
						{
							if (int_0 < class32_0.frmMain_0.int_11)
							{
								Class34 CS_0024_003C_003E8__locals1 = new Class34
								{
									class33_0 = this
								};
								Interlocked.Increment(ref int_0);
								CS_0024_003C_003E8__locals1.int_0 = 0;
								class32_0.frmMain_0.dgvAcc.Invoke((MethodInvoker)delegate
								{
									CS_0024_003C_003E8__locals1.int_0 = CS_0024_003C_003E8__locals1.class33_0.class32_0.frmMain_0.dgvAcc.Rows.Add();
								});
								num4++;
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										int num9 = Common.smethod_83(ref CS_0024_003C_003E8__locals1.class33_0.list_0);
										//CS_0024_003C_003E8__locals1.class33_0.class32_0.frmMain_0.method_24(CS_0024_003C_003E8__locals1.int_0, num9 + 1, CS_0024_003C_003E8__locals1.class33_0.bool_0, CS_0024_003C_003E8__locals1.class33_0.class32_0.frmMain_0.string_9);
										Common.smethod_65(ref CS_0024_003C_003E8__locals1.class33_0.list_0, num9 + 1);
										Interlocked.Decrement(ref CS_0024_003C_003E8__locals1.class33_0.int_0);
									}
									catch
									{
										Interlocked.Decrement(ref CS_0024_003C_003E8__locals1.class33_0.int_0);
									}
								})
								{
									Name = CS_0024_003C_003E8__locals1.int_0.ToString()
								};
								class32_0.frmMain_0.list_3.Add(thread);
								Common.smethod_62(1.0);
								thread.Start();
							}
							else
							{
								for (int i = 0; i < class32_0.frmMain_0.list_3.Count(); i++)
								{
									class32_0.frmMain_0.list_3[i].Join();
								}
								for (int j = 0; j < class32_0.frmMain_0.list_3.Count(); j++)
								{
									try
									{
										class32_0.frmMain_0.list_3[j].Abort();
									}
									catch
									{
									}
								}
								class32_0.frmMain_0.list_3.Clear();
								int_0 = 0;
							}
							if (class32_0.frmMain_0.int_9 == 6 && class32_0.frmMain_0.bool_12)
							{
								try
								{
									for (int k = 0; k < class32_0.frmMain_0.list_3.Count; k++)
									{
										class32_0.frmMain_0.list_3[k].Join();
										class32_0.frmMain_0.list_3.RemoveAt(k--);
									}
								}
								catch
								{
								}
							}
							if (class32_0.frmMain_0.bool_0)
							{
								break;
							}
						}
						for (int l = 0; l < class32_0.frmMain_0.list_3.Count(); l++)
						{
							class32_0.frmMain_0.list_3[l].Join();
						}
						for (int m = 0; m < class32_0.frmMain_0.list_3.Count(); m++)
						{
							try
							{
								class32_0.frmMain_0.list_3[m].Abort();
							}
							catch
							{
							}
						}
						class32_0.frmMain_0.list_3.Clear();
						num++;
						if (!class32_0.frmMain_0.bool_0 && num >= class32_0.frmMain_0.int_8 && (class32_0.frmMain_0.int_9 == 1 || class32_0.frmMain_0.int_9 == 4))
						{
							class32_0.frmMain_0.method_20("Đang đổi IP...");
							bool_1 = Common.smethod_56(class32_0.frmMain_0.int_9, 0, class32_0.frmMain_0.string_10, "");
							num = 0;
							if (bool_1)
							{
								class32_0.frmMain_0.Invoke((MethodInvoker)delegate
								{
									class32_0.frmMain_0.stIPCur.Text = class32_0.frmMain_0.method_54();
								});
							}
						}
						if (num3 + 1 < num2)
						{
							int num5 = class32_0.frmMain_0.random_0.Next(0, 10);
							int tickCount = Environment.TickCount;
							while ((Environment.TickCount - tickCount) / 1000 - num5 < 0)
							{
								class32_0.frmMain_0.method_20(string.Format("Chạy lượt tiếp theo sau {time} giây...".Replace("{time}", (num5 - (Environment.TickCount - tickCount) / 1000).ToString())));
								Common.smethod_62(0.5);
								if (Settings.Default.isAutoClearLD)
								{
									Common.smethod_39(class32_0.frmMain_0.string_9);
								}
								if (class32_0.frmMain_0.bool_0)
								{
									break;
								}
							}
						}
						if (!class32_0.frmMain_0.bool_0)
						{
							num3++;
						}
						else if (class32_0.frmMain_0.bool_0)
						{
							class32_0.frmMain_0.method_19("stop");
							break;
						}
					}
				}
				else
				{
					while (!class32_0.frmMain_0.bool_0)
					{
						if (class32_0.frmMain_0.int_9 == 1 || class32_0.frmMain_0.int_9 == 4)
						{
							class32_0.frmMain_0.method_20("Đang đổi IP...");
							bool_1 = Common.smethod_56(class32_0.frmMain_0.int_9, 0, class32_0.frmMain_0.string_10, "");
							num = 0;
							if (bool_1)
							{
								class32_0.frmMain_0.Invoke((MethodInvoker)delegate
								{
									class32_0.frmMain_0.stIPCur.Text = class32_0.frmMain_0.method_54();
								});
							}
						}
						if (class32_0.frmMain_0.queue_0 != null && class32_0.frmMain_0.queue_0.Count == 0)
						{
							break;
						}
						class32_0.frmMain_0.method_20("Đang reg...");
						Common.smethod_62(0.5);
						if (class32_0.frmMain_0.bool_0)
						{
							break;
						}
						int num6 = 0;
						while (num6 < class32_0.frmMain_0.int_11)
						{
							Class35 CS_0024_003C_003E8__locals0 = new Class35
							{
								class33_0 = this
							};
							if (class32_0.frmMain_0.bool_0)
							{
								break;
							}
							CS_0024_003C_003E8__locals0.int_0 = 0;
							class32_0.frmMain_0.dgvAcc.Invoke((MethodInvoker)delegate
							{
								CS_0024_003C_003E8__locals0.int_0 = CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.dgvAcc.Rows.Add();
							});
							num6++;
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								while (!CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.bool_0)
								{
									if (!CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.bool_0)
									{
										try
										{
											CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.dgvAcc.Invoke((MethodInvoker)delegate
											{
												CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.dgvAcc.Rows[CS_0024_003C_003E8__locals0.int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
											});
											string textcaptcha = "";
											CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.method_24(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.int_0 + 1, CS_0024_003C_003E8__locals0.class33_0.bool_0, CS_0024_003C_003E8__locals0.class33_0.class32_0.frmMain_0.string_9, textcaptcha);
											Common.smethod_62(1.0);
										}
										catch
										{
										}
									}
								}
							});
							thread2.Name = CS_0024_003C_003E8__locals0.int_0.ToString();
							thread2.Start();
							class32_0.frmMain_0.list_3.Add(thread2);
							if (class32_0.frmMain_0.int_9 != 6 || !class32_0.frmMain_0.bool_12)
							{
								continue;
							}
							try
							{
								for (int n = 0; n < class32_0.frmMain_0.list_3.Count; n++)
								{
									class32_0.frmMain_0.list_3[n].Join();
									class32_0.frmMain_0.list_3.RemoveAt(n--);
								}
							}
							catch
							{
							}
						}
						for (int num7 = 0; num7 < class32_0.frmMain_0.list_3.Count(); num7++)
						{
							try
							{
								class32_0.frmMain_0.list_3[num7].Join();
							}
							catch
							{
							}
						}
						for (int num8 = 0; num8 < class32_0.frmMain_0.list_3.Count(); num8++)
						{
							try
							{
								class32_0.frmMain_0.list_3[num8].Abort();
							}
							catch
							{
							}
						}
						class32_0.frmMain_0.list_3.Clear();
					}
				}
				class32_0.frmMain_0.method_50();
				class32_0.frmMain_0.method_19("stop");
				class32_0.frmMain_0.list_4.Clear();
				class32_0.frmMain_0.btnStop.Invoke((MethodInvoker)delegate
				{
					class32_0.frmMain_0.btnStop.Text = "Dừng lại";
					class32_0.frmMain_0.plTrangThai.Text = "Kết thúc đăng ký";
				});
				if (Settings.Default.isAutoClearLD)
				{
					Common.smethod_39(class32_0.frmMain_0.string_9);
				}
				try
				{
					class32_0.thread_0.Abort();
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class34
		{
			public int int_0;

			public Class33 class33_0;

			internal void method_0()
			{
				int_0 = class33_0.class32_0.frmMain_0.dgvAcc.Rows.Add();
			}

			internal void method_1()
			{
				try
				{
					int num = Common.smethod_83(ref class33_0.list_0);
					string textcaptcha = "";
					class33_0.class32_0.frmMain_0.method_24(int_0, num + 1, class33_0.bool_0, class33_0.class32_0.frmMain_0.string_9, textcaptcha);
					Common.smethod_65(ref class33_0.list_0, num + 1);
					Interlocked.Decrement(ref class33_0.int_0);
				}
				catch
				{
					Interlocked.Decrement(ref class33_0.int_0);
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class35
		{
			public int int_0;

			public Class33 class33_0;

			public MethodInvoker methodInvoker_0;

			internal void method_0()
			{
				int_0 = class33_0.class32_0.frmMain_0.dgvAcc.Rows.Add();
			}

			internal void method_1()
			{
				while (!class33_0.class32_0.frmMain_0.bool_0)
				{
					if (class33_0.class32_0.frmMain_0.bool_0)
					{
						continue;
					}
					try
					{
						string textcaptcha = "";
						class33_0.class32_0.frmMain_0.dgvAcc.Invoke((MethodInvoker)delegate
						{
							class33_0.class32_0.frmMain_0.dgvAcc.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
						});
						class33_0.class32_0.frmMain_0.method_24(int_0, int_0 + 1, class33_0.bool_0, class33_0.class32_0.frmMain_0.string_9, textcaptcha);
						Common.smethod_62(1.0);
					}
					catch
					{
					}
				}
			}

			internal void method_2()
			{
				class33_0.class32_0.frmMain_0.dgvAcc.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
			}
		}

		[CompilerGenerated]
		private sealed class Class36
		{
			public frmMain frmMain_0;

			public string string_0;

			internal void method_0()
			{
				frmMain_0.plTrangThai.Text = string_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class37
		{
			public frmMain frmMain_0;

			public int int_0;

			public Device device_0;

			internal void method_0()
			{
				frmMain_0.dgvAcc.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			}

			internal void method_1()
			{
				frmMain_0.dgvAcc.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			}

			internal void method_2()
			{
				frmViewLD.frmViewLD_0.method_4(device_0.int_0);
			}
		}

		[CompilerGenerated]
		private sealed class Class38
		{
			public DataGridView dataGridView_0;

			public int int_0;

			public string string_0;

			public string string_1;

			internal void method_0()
			{
				dataGridView_0.Rows[int_0].Cells[string_0].Value = string_1;
			}
		}

		[CompilerGenerated]
		private sealed class Class39
		{
			public int int_0;

			public frmMain frmMain_0;

			internal void method_0()
			{
				int i;
				for (i = 0; i < int_0; i++)
				{
					Class2.smethod_24("add", 0, bool_0: true, frmMain_0.txtLinkLD.Text);
				}
				MessageBox.Show("Tạo thành công " + i + " LDPlayer");
			}
		}

		public static frmMain frmMain_0;

		private Random random_0 = new Random();

		private List<int> list_0 = new List<int>();

		private List<string> list_1 = new List<string>();

		private List<string> list_2 = new List<string>();

		private bool bool_0;

		private string[] string_0 = File.ReadAllLines("data/US/firstname_female.txt");

		private string[] string_1 = File.ReadAllLines("data/US/firstname_male.txt");

		private string[] string_2 = File.ReadAllLines("data/US/lastname.txt");

		private string[] string_3 = File.ReadAllLines("data/VN/firstname_female.txt");

		private string[] string_4 = File.ReadAllLines("data/VN/firstname_male.txt");

		private string[] string_5 = File.ReadAllLines("data/VN/lastname.txt");

		private string[] string_6 = File.ReadAllLines("data/THAI/firstname_female.txt");

		private string[] string_7 = File.ReadAllLines("data/THAI/firstname_male.txt");

		private string[] string_8 = File.ReadAllLines("data/THAI/lastname.txt");

		private int int_0 = 0;

		private int int_1 = 0;

		private int int_2 = 0;

		private int int_3 = 0;

		private int int_4 = 0;

		private int int_5 = 0;

		private int int_6 = 0;

		private int int_7 = 0;

		private string string_9 = "";

		private int int_8 = 0;

		private int int_9 = 0;

		private string string_10 = "";

		private string string_11 = "";

		private string string_12 = "";

		private int int_10 = 0;

		public string string_13;

		private int int_11 = 0;

		private List<Thread> list_3;

		public bool bool_1;

		private List<Device> list_4;

		private object object_0;

		private int int_12 = 0;

		private string string_14 = "";

		private int int_13 = 0;

		private int int_14 = 0;

		private bool bool_2 = false;

		private bool bool_3 = false;

		private bool bool_4 = false;

		private bool bool_5 = false;

		private bool bool_6 = false;

		private bool bool_7 = false;

		private int int_15 = 0;

		private int int_16 = 0;

		private bool bool_8 = false;

		private int int_17;

		private object object_1;

		private int int_18;

		private object object_2;

		private object object_3;

		private object object_4;

		private bool bool_9;

		private List<Class67> list_5;

		private List<string> list_6;

		private string string_15 = "";

		private int int_19 = 0;

		private int int_20 = 0;

		private object object_5 = new object();

		private string string_16 = "";

		private int int_21 = 0;

		private List<string> list_7 = null;

		private int int_22;

		private int int_23;

		private object object_6;

		private bool bool_10 = false;

		private string string_17 = "";

		private static List<float> list_8 = new List<float>();

		private static List<float> list_9 = new List<float>();

		protected static PerformanceCounter performanceCounter_0;

		protected static PerformanceCounter performanceCounter_1;

		private object object_7 = new object();

		private object object_8 = new object();

		private object object_9 = new object();

		private object object_10 = new object();

		private object object_11 = new object();

		private object object_12;

		private List<string> list_10 = new List<string>();

		private List<string> list_11 = new List<string>();

		private List<Class51> list_12 = null;

		private int int_24 = 0;

		private object object_13 = new object();

		private object object_14 = new object();

		private string string_18;

		private string string_19;

		private List<string> list_13 = new List<string>();

		private Queue<string> queue_0;

		private Queue<string> queue_1;

		private bool bool_11 = false;

		private int int_25;

		private List<Class73> list_14 = new List<Class73>();

		private List<Class68> list_15 = new List<Class68>();

		private List<Class61> list_16 = new List<Class61>();

		private List<ClassProxyv6> list_16z = new List<ClassProxyv6>();

		private int int_26;

		private int int_27;

		private bool bool_12 = false;

		private List<string> list_17 = new List<string>();

		private List<string> list_18 = new List<string>();

		private List<string> list_19 = new List<string>();

		private List<string> list_19z = new List<string>();
		private List<string> list_20;

		private int int_28;

		private int int_29;

		private bool bool_13;

		private bool bool_14;

		private int int_30;

		private int int_31;

		private int int_32;

		private int int_33;

		private bool bool_15;

		private int int_34 = 10;

		private int int_35 = 0;

		private int int_36 = 0;

		private bool bool_16 = false;

		private bool bool_17 = false;

		private int int_37 = 0;

		private int int_38 = 0;

		private string string_20 = "";

		private int int_39 = 0;

		private int int_40 = 0;

		private IContainer icontainer_0 = null;

		private StatusStrip statusStrip1;

		private ToolStripStatusLabel toolStripStatusLabel1;

		private ToolStripStatusLabel stTotalSuccess;

		private ToolStripStatusLabel toolStripStatusLabel3;

		private ToolStripStatusLabel toolStripStatusLabel4;

		private ToolStripStatusLabel stTotalFail;

		private ToolStripStatusLabel toolStripStatusLabel6;

		private ToolStripStatusLabel stIPCur;

		private ToolStripStatusLabel toolStripStatusLabel2;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem copyToolStripMenuItem;

		private ToolStripMenuItem uidPassToolStripMenuItem;

		private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripStatusLabel toolStripStatusLabel5;

		private ToolStripStatusLabel lblCountSelect;

		private ToolStripStatusLabel toolStripStatusLabel7;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripMenuItem toolStripMenuItem_4;

		private ToolStripMenuItem uidPass2FAToolStripMenuItem;

		private ToolStripMenuItem liveToolStripMenuItem;

		private ToolStripMenuItem dieToolStripMenuItem;

		private ToolStripMenuItem checkpointToolStripMenuItem;

		private ToolStripMenuItem mailPassMailToolStripMenuItem;

		private ToolStripStatusLabel toolStripStatusLabel8;

		private ToolStripStatusLabel toolStripStatusLabel9;

		private ToolStripStatusLabel plTrangThai;

		private ToolStripStatusLabel toolStripStatusLabel10;

		private System.Windows.Forms.Timer timer_0;

		private PictureBox pictureBox1;

		private Button btnClose;

		private Button btnMinimized;

		private Label label28;

		private Panel panel4;

		private System.Windows.Forms.Timer timer_1;

		private ToolStripStatusLabel toolStripStatusLabel14;

		private ToolStripStatusLabel lblTimeExpired;

		private ToolStripStatusLabel toolStripStatusLabel15;

		private ToolStripStatusLabel toolStripStatusLabel16;

		private ToolStripStatusLabel lblMachineName;

		private ToolStripMenuItem allToolStripMenuItem;

		private BunifuDragControl bunifuDragControl_0;

		private Button btnMaximum;

		private Panel pnlContainer;

		private Button btnAutoConfig;

		private Button btnSaveConf;

		private Button btnStop;

		private Button btnReg;

		private GroupBox groupBox2;

		private DataGridView dgvAcc;

		private GroupBox groupBox1;

		private GroupBox groupBox7;

		private TextBox txtLinkAvartar;

		private Button btnNhapanh;

		private Panel panel3;

		private RadioButton rbRandomMF;

		private RadioButton rbFemale;

		private RadioButton rbMale;

		private CheckBox chkCoverImg;

		private CheckBox chkAvartar;

		private CheckBox chk2FA;

		private CheckBox chkRandomPass;

		private Label label14;

		private Label label13;

		private TextBox txtPassFb;

		private Label label12;

		private ComboBox cbNameReg;

		private GroupBox groupBox6;

		private Panel panel2;

		private Panel plNovery;

		private RadioButton rdNoveriMail;

		private RadioButton rdNovriPhone;

		private Label label18;

		private Label label17;

		private ComboBox cbMailAo;

		private ComboBox cbbPhoneCountry;

		private Panel plVeriPhone;

		private Button btnCheckSim;

		private Label label9;

		private Label label10;

		private ComboBox cbDvSim;

		private TextBox txtAPISim;

		private RadioButton rdThuePhone;

		private RadioButton rdNoVeri;

		private GroupBox groupBox8;

		private Panel pnlTuongTac;

		private GroupBox gbCamxuc;

		private CheckBox chkGian;

		private CheckBox chkBuon;

		private CheckBox chkHaha;

		private CheckBox chkTym;

		private CheckBox chkLike;

		private Panel plAddfriend;

		private NumericUpDown nFriendTo;

		private Label label25;

		private NumericUpDown nFriendFrom;

		private Label label26;

		private Label label27;

		private CheckBox chkInNewfeed;

		private CheckBox chkWatch;

		private CheckBox chkWStory;

		private CheckBox chkAddFUID;

		private CheckBox chkReadNotifi;

		private GroupBox groupBox5;

		private Panel panel5;

		private Panel plCheckDoiIP;

		private Button btnTestChangeIP;

		private NumericUpDown numChangeIP;

		private Label label20;

		private Label label21;

		private Panel plChangeIPDcom;

		private Button btnGetDcom;

		private TextBox txtNameDcom;

		private RadioButton rdHMA;

		private RadioButton rdChangeIPDcom;

		private RadioButton rdNoChangeIP;

		private GroupBox groupBox4;

		private Panel panel7;

		private NumericUpDown numDelayTo;

		private RadioButton rdDelayLD;

		private Label label4;

		private NumericUpDown numDelayFr;

		private Label label5;

		private TextBox txtLinkLD;

		private NumericUpDown numDeClsTo;

		private NumericUpDown numDeClsFr;

		private Label label7;

		private RadioButton rdNormal;

		private Label label8;

		private Label label6;

		private Label label3;

		private GroupBox groupBox3;

		private NumericUpDown numOTP;

		private NumericUpDown nudSoLuotChay;

		private NumericUpDown numThrLdPlay;

		private Label label24;

		private Label label11;

		private Button button1;

		private Label label23;

		private Label label2;

		private Label label1;

		private RadioButton rdSwap;

		private NumericUpDown nudDelayQR2Fa;

		private Label label40;

		private NumericUpDown nAgeTo;

		private NumericUpDown nAgeFrom;

		private Label label43;

		private Label label41;

		private ComboBox cbbPrePhone;

		private TextBox txtListDauso;

		private DataGridViewCheckBoxColumn cChose;

		private DataGridViewTextBoxColumn cId;

		private DataGridViewTextBoxColumn status;

		private DataGridViewTextBoxColumn uid;

		private DataGridViewTextBoxColumn pass;

		private DataGridViewTextBoxColumn ho;

		private DataGridViewTextBoxColumn ten;

		private DataGridViewTextBoxColumn age;

		private DataGridViewTextBoxColumn gender;

		private DataGridViewTextBoxColumn conf_2fa;

		private DataGridViewTextBoxColumn token;

		private DataGridViewTextBoxColumn cookie;

		private DataGridViewTextBoxColumn email;

		private DataGridViewTextBoxColumn passMail;

		private DataGridViewTextBoxColumn phone;

		private DataGridViewTextBoxColumn proxy;

		private DataGridViewTextBoxColumn cInfo;

		private DataGridViewTextBoxColumn cDevice;

		private Label label45;

		private ComboBox cbModeRunReg;

		private Panel pnlSoLanReg;

		private CheckBox ckCheckIP;

		private Button btnOutpuData;

		private ToolStripMenuItem phoneToolStripMenuItem;

		private NumericUpDown nudTimeWaitOTP;

		private Label label48;

		private Label label46;

		private BunifuDragControl bunifuDragControl_1;

		private Button btnManagerLD;

		private Button btnRepairLD;

		private Button btnCreateLDPLayer;

		private Button btnTurnOffAllLD;
		private IContainer components;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabMailVeri;
        private TabPage tabPage6;
        private Panel plVeriMail;
        private Panel plHotmailReg;
        private Button btnCheckAPIAny;
        private TextBox txtPassmail;
        private TextBox txtAPIAnyCat;
        private Label label22;
        private CheckBox ckRdPassmail;
        private CheckBox chkHideBrowser;
        private CheckBox ckTaoMailBox;
        private Label label19;
        private Button btnNhapHotmail;
        private RadioButton rdHotMailReg;
        private RadioButton rdHotMailRegisted;
        private TabPage tabPage7;
        private Panel pnlTemmail;
        private LinkLabel lnkMailTM;
        private RadioButton rdMailTM;
        private LinkLabel lnkTempMailIO;
        private RadioButton rdTempMailIO;
        private RadioButton rdProxy;
        private TabControl tabProxy;
        private TabPage tabPage1;
        private LinkLabel linkLabel1;
        private Panel plTinsoftProxy;
        private NumericUpDown nudLuongPerIPTinsoft;
        private Button btnCheckProxy;
        private Label label16;
        private Label label29;
        private Label label15;
        private TextBox txtProxy;
        private ComboBox cbLocationProxy;
        private RadioButton rdTinsoftProxy;
        private TabPage tabPage2;
        private LinkLabel linkLabel2;
        private Panel pnlAPIMinProxy;
        private Button btnCheckAPIMinProxy;
        private RichTextBox txtApiKeyMinProxy;
        private Label lblAPIMinKey;
        private Label label32;
        private Label label50;
        private NumericUpDown nudLuongPerIPMinProxy;
        private RadioButton rdMinProxy;
        private TabPage tabPage3;
        private Panel pnlIpPort;
        private ComboBox cbbTypeProxyIP;
        private Label label33;
        private Label label31;
        private RadioButton rdIPDong;
        private RadioButton rdIPStatic;
        private Label label34;
        private Label label30;
        private RichTextBox txtListProxyIp;
        private Label lblListProxyIP;
        private RadioButton rdIPPortUserPass;
        private TabPage tabPage4;
        private Panel panel1;
        private Panel plXproxy;
        private Panel panel8;
        private Label label53;
        private RadioButton rbXproxyResetAllProxy;
        private RadioButton rbXproxyResetEachProxy;
        private CheckBox ckbWaitDoneAllXproxy;
        private RichTextBox txtListXProxy;
        private RadioButton rbSock5Proxy;
        private RadioButton rbHttpProxy;
        private Label label35;
        private Label lblCountXproxy;
        private Label label52;
        private Label label51;
        private Label label39;
        private Label label37;
        private NumericUpDown nudDelayResetXProxy;
        private NumericUpDown nudLuongPerIPXProxy;
        private Label label38;
        private TextBox txtServiceURLXProxy;
        private RadioButton rbXproxy;
        private TabPage tabPage5;
        private LinkLabel linkLabel3;
        private Panel plTMProxy;
        private Button btnCheckTMProxy;
        private RichTextBox txtApiKeyTMProxy;
        private Label lblCountTmProxy;
        private Label label42;
        private NumericUpDown nudLuongPerIPTMProxy;
        private RadioButton rbTMProxy;
        private TabPage tabPage8;
        private LinkLabel lnkShopLike;
        private Panel plProxyShopLike;
        private RichTextBox txtAPIKeyShoplike;
        private Label lblAPIKeyShopLike;
        private Label label47;
        private NumericUpDown nudThreadShopLike;
        private RadioButton rbProxyShoplike;
        private TabPage tabPage9;
        private Panel pnlProxyFree;
        private RadioButton rdProxyFreeRandom;
        private RadioButton rdProxyFreeUS;
        private RadioButton rdProxyFreeVN;
        private RadioButton rdProxyOrbit;
        private RadioButton rdConfMail;
        private Button button2;
        private Button btnUpdate;
        private Label label44;
        private TabPage Proxyv6;
        private LinkLabel linkLabelprxv6;
        private Panel plProxyv6;
        private Button btnCheckProxyv6;
        private RichTextBox txtApiProxyv6;
        private Label lblApiProxyv6;
        private Label label54;
        private NumericUpDown numericUpDown1;
        private RadioButton rbProxyv6;
        private Label label49;
        private TextBox text_api_captcha;
        private Label label36;

		public frmMain(string timeExpired)
		{
			InitializeComponent();
			frmMain_0 = this;
            base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
            base.WindowState = FormWindowState.Maximized;
            method_58();
			method_61();
			btnReg.Enabled = true;
			btnStop.Enabled = false;
			btnSaveConf.Enabled = true;
			int_18 = 0;
			object_2 = new object();
			int_17 = 0;
			object_1 = new object();
			object_3 = new object();
			object_4 = new object();
			bool_9 = false;
			list_5 = null;
			list_6 = null;
			list_3 = new List<Thread>();
			list_7 = (from string_0 in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "extension")
					  where Path.GetExtension(string_0) == ".crx"
					  select string_0).ToList();
			if (Settings.Default.isDongBoDB)
			{
				method_0();
			}
			stIPCur.Text = method_54();
			tabProxy.Controls.Remove(tabPage1);
			tabProxy.Controls.Remove(tabPage2);
			try
			{
				Common.int_0 = Screen.PrimaryScreen.Bounds.Width;
				Common.int_1 = Screen.PrimaryScreen.Bounds.Height;
				int_22 = 2 * Common.int_0 / 6;
				int_23 = Common.int_1 / 2;
			}
			catch
			{
			}
			string text = Common.smethod_79(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString());
			string mamay = Environment.MachineName;
			lblMachineName.Text = text.Substring(0,4) + "****" + mamay;
			lblTimeExpired.Text = Convert.ToDateTime(timeExpired).ToString("dd/MM/yyyy");
		}

		private void method_0()
		{
			Class48 @class = new Class48("setting_danhba.ini");
			int_28 = ((@class.method_1("nPhoneFr") == null) ? 1 : Convert.ToInt32(@class.method_1("nPhoneFr")));
			int_29 = ((@class.method_1("nPhoneTo") != null) ? Convert.ToInt32(@class.method_1("nPhoneTo")) : 10);
			int_30 = ((@class.method_1("nKetbanFr") != null) ? Convert.ToInt32(@class.method_1("nKetbanFr")) : 2);
			int_31 = ((@class.method_1("nKetBanTo") != null) ? Convert.ToInt32(@class.method_1("nKetBanTo")) : 5);
			int_32 = ((@class.method_1("nDelayFr") != null) ? Convert.ToInt32(@class.method_1("nDelayFr")) : 2);
			int_33 = ((@class.method_1("nDelayTo") != null) ? Convert.ToInt32(@class.method_1("nDelayTo")) : 5);
			bool_13 = @class.method_1("ckDeletePhone") != null && Convert.ToBoolean(@class.method_1("ckDeletePhone"));
			bool_14 = @class.method_1("ckAddFriends") != null && Convert.ToBoolean(@class.method_1("ckAddFriends"));
			string text = ((@class.method_1("txtListPhone") != null) ? @class.method_1("txtListPhone") : "");
			if (text != string.Empty)
			{
				list_20 = new List<string>();
				string[] array = text.Split('|');
				for (int i = 0; i < array.Length; i++)
				{
					list_20.Add(array[i]);
				}
			}
		}

		public string method_1(int int_41, string string_21)
		{
			return Class15.smethod_3(dgvAcc, int_41, string_21);
		}

		void OnLoad(EventArgs e)
		{
			Application.Idle += method_2;
		}

		private void method_2(object sender, EventArgs e)
		{
			Application.Idle -= method_2;
			new Thread((ThreadStart)delegate
			{
				while (true)
				{
					try
					{
						string text = Class2.smethod_34("adb devices");
						if (!text.Contains("List of devices attached"))
						{
							Common.smethod_63("adb");
							bool_1 = true;
						}
					}
					catch
					{
					}
					Common.smethod_62(30.0);
				}
			}).Start();
		}

		private string method_3()
		{
			return string_2[random_0.Next(0, string_2.Length - 1)];
		}

		private string method_4()
		{
			return string_0[random_0.Next(0, string_0.Length - 1)];
		}

		private string method_5()
		{
			return string_1[random_0.Next(0, string_1.Length - 1)];
		}

		private string method_6()
		{
			return string_5[random_0.Next(0, string_5.Length - 1)];
		}

		private string method_7()
		{
			return string_4[random_0.Next(0, string_4.Length - 1)];
		}

		private string method_8()
		{
			return string_3[random_0.Next(0, string_3.Length - 1)];
		}

		private string method_9()
		{
			return string_8[random_0.Next(0, string_8.Length - 1)].Trim();
		}

		private string method_10()
		{
			return string_7[random_0.Next(0, string_7.Length - 1)].Trim();
		}

		private string method_11()
		{
			return string_6[random_0.Next(0, string_6.Length - 1)].Trim();
		}

		private string method_12()
		{
			string text = "Nguyen|Tran|Le|Pham|Hoang|Huynh|Phan|Vu|Vo|Dang|Dinh|Trinh|Doan|Bui|Do|Ho|Ngo|Duong|Ly|Dao|Ung|Lieu|Mai";
			string[] array = text.Split('|');
			return array[random_0.Next(0, array.Length - 1)];
		}

		public void method_13()
		{
			try
			{
				plTrangThai.Text = "Dừng chạy";
				plTrangThai.ForeColor = Color.Red;
				bool_0 = true;
				if (list_3.Count > 0)
				{
					list_3.Clear();
				}
				if (list_4 != null && list_4.Count > 0)
				{
					list_4.Clear();
				}
				method_19("stop");
			}
			catch
			{
			}
		}

		private string method_14()
		{
			string text = "Kim Quyen|Phuoc Thien|Quynh Tran|Vinh|Binh|Huynh Ngoc Dung| Van|Thanh Bich|Thu Hien|Bao Ngoc|Thao|Huynh Truc Vy|Ba Duy|Thuy Linh|Huyen Tram|Ngoc Hoa|Hoang Quyen|Ngoc Diep|Thanh Ha|Hoang Phuong|Truc Ly|Tram|Trang Oanh|My|Nhu|Lai|Kim|Phuc|Phuong|Tram Anh|Dieu Anh|Quynh Anh|Ngoc Diep|Kim Khanh|Ngoc Lien|Cat TuongDiệu Ái|Khả Ái|Ngọc Ái|Hoài An|Huệ An|Minh An|Phương An|Thanh An|Hải Ân|Huệ Ân|Bảo Anh|Diệp Anh|Diệu Anh|Hải Anh|Hồng Anh|Huyền Anh|Kiều Anh|Kim Anh|Lan Anh|Mai Anh|Minh Anh|Mỹ Anh|Ngọc Anh|Nguyệt Anh|Như Anh|Phương Anh|Quế Anh|Quỳnh Anh|Thục Anh|Thúy Anh|Thùy Anh|Trâm Anh|Trang Anh|Tú Anh|Tuyết Anh|Vân Anh|Yến Anh|Kim Ánh|Ngọc Ánh|Nguyệt Ánh|Nhật Ánh|Băng Băng|Lệ Băng|Tuyết Băng|Như Bảo|Gia Bảo|Xuân Bảo|Ngọc Bích|An Bình|Thái Bình|Sơn Ca|Ngọc Cầm|Nguyệt Cầm|Thi Cầm|Bảo Châu|Bích Châu|Diễm Châu|Hải Châu|Hoàn Châu|Hồng Châu|Linh Châu|Loan Châu|Ly Châu|Mai Châu|Minh Châu|Trân Châu|Diệp Chi|Diễm Chi|Hạnh Chi|Khánh Chi|Kim Chi|Lan Chi|Lệ Chi|Linh Chi|Mai Chi|Phương Chi|Quế Chi|Quỳnh Chi|Bích Chiêu|Hoàng Cúc|Kim Cương|Trang Ðài|Tâm Đan|Thanh Đan|Linh Ðan|Quỳnh Dao|Anh Ðào|Bích Ðào|Hồng Ðào|Ngọc Ðào|Thục Ðào|Trúc Ðào|An Di|Thiên Di|Hồng Diễm|Kiều Diễm|Phương Diễm|Thúy Diễm|Bích Diệp|Hồng Diệp|Ngọc Diệp|Bích Ðiệp|Hồng Ðiệp|Mộng Ðiệp|Ngọc Ðiệp|Huyền Diệu|Tâm Ðoan|Thục Ðoan|Hạnh Dung|Kiều Dung|Kim Dung|Mỹ Dung|Nghi Dung|Ngọc Dung|Phương Dung|Quỳnh Dung|Thùy Dung|Ánh Dương|Chiêu Dương|Thùy Dương|Hải Ðường|Bích Duyên|Kỳ Duyên|Linh Duyên|Minh Duyên|Mỹ Duyên|Thu Duyên|Bảo An|Bình An|Ðăng An|Duy An|Khánh An|Nam An|Phước An|Thành An|Thế An|Thiên An|Trường An|Việt An|Xuân An|Công Ân|Ðức Ân|Gia Ân|Hoàng Ân|Minh Ân|Phú Ân|Thành Ân|Thiên Ân|Thiện Ân|Duy Bảo|Gia Bảo|Hữu Bảo|Nguyên Bảo|Quốc Bảo|Thiệu Bảo|Tiểu Bảo|Ðức Bình|Gia Bình|Khải Ca|Gia Cần|Duy Cẩn|Gia Cẩn|Hữu Canh|Gia Cảnh|Hữu Cảnh|Minh Cảnh|Ngọc Cảnh|Đức Cao|Xuân Cao|Bảo Chấn|Bảo Châu|";
			string[] array = text.Split('|');
			return array[random_0.Next(0, array.Length - 1)];
		}

		private void method_15(object sender, EventArgs e)
		{
		}

		private void method_16(object sender, EventArgs e)
		{
		}

		private void method_17(object sender, EventArgs e)
		{
		}

		private void method_18(object sender, EventArgs e)
		{
		}

		public void method_19(string string_21)
		{
			if (!base.IsHandleCreated)
			{
				return;
			}
			Invoke((MethodInvoker)delegate
			{
				try
				{
					if (string_21 == "start")
					{
						btnReg.Enabled = false;
						btnSaveConf.Enabled = false;
						btnAutoConfig.Enabled = false;
						btnStop.Enabled = true;
					}
					else if (string_21 == "stop")
					{
						btnReg.Enabled = true;
						btnSaveConf.Enabled = true;
						btnAutoConfig.Enabled = true;
						btnStop.Enabled = false;
					}
				}
				catch (Exception)
				{
				}
			});
		}

		private void btnReg_Click(object sender, EventArgs e)
		{
			list_4 = new List<Device>();
			Thread thread_0 = null;
			try
			{
				thread_0 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (this.bool_1 && list_4.Count > 0)
							{
								bool flag = false;
								while (!flag)
								{
									flag = true;
									for (int num17 = 0; num17 < list_4.Count; num17++)
									{
										string text3 = Class2.smethod_36(list_4[num17].int_0);
										if (string.IsNullOrEmpty(text3))
										{
											flag = false;
										}
										else
										{
											list_4[num17].DeviceId = text3;
										}
									}
								}
								this.bool_1 = false;
							}
						}
						catch
						{
						}
						method_51(5.0);
					}
				});
				thread_0.IsBackground = true;
				thread_0.Start();
			}
			catch
			{
			}
			try
			{
				Class48 @class = new Class48("setting.ini");
				int_11 = Convert.ToInt32(@class.method_1("nudThread"));
				if (int_11 <= 0)
				{
					MessageBox.Show("Số luồng phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				method_60();
				int_1 = Convert.ToInt32(@class.method_1("nudSoLuotChay"));
				int_7 = Convert.ToInt32(@class.method_1("nudThoiGianChoNhapOTP"));
				int_2 = Convert.ToInt32(@class.method_1("optionMemu"));
				int_3 = Convert.ToInt32(@class.method_1("numDelayFr"));
				int_4 = Convert.ToInt32(@class.method_1("numDelayTo"));
				int_5 = Convert.ToInt32(@class.method_1("numDeClsFr"));
				int_6 = Convert.ToInt32(@class.method_1("numDeClsTo"));
				int_9 = Convert.ToInt32(@class.method_1("typeChangeIp"));
				string_9 = @class.method_1("linkLD").ToString();
				string_10 = @class.method_1("txtProfileNameDcom").ToString();
				string_12 = @class.method_1("typeVerify");
				int_21 = Convert.ToInt32(@class.method_1("cbbPhoneCountry"));
				int_12 = Convert.ToInt32(@class.method_1("typeNameReg"));
				string_14 = @class.method_1("passFB").ToString();
				bool_5 = Convert.ToBoolean(@class.method_1("isRdPass"));
				int_13 = Convert.ToInt32(@class.method_1("typeGender"));
				int_15 = Convert.ToInt32(@class.method_1("ageFrom"));
				int_16 = Convert.ToInt32(@class.method_1("ageTo"));
				bool_2 = Convert.ToBoolean(@class.method_1("is2Fa"));
				bool_3 = Convert.ToBoolean(@class.method_1("isAvartar"));
				bool_4 = Convert.ToBoolean(@class.method_1("isCoverImg"));
				bool_7 = Convert.ToBoolean(@class.method_1("isLanguage"));
				bool_6 = Convert.ToBoolean(@class.method_1("is2Fa"));
				string_15 = @class.method_1("txtAPIProxy").ToString();
				int_8 = Convert.ToInt32(@class.method_1("iSoLuotDoiIpMotLan"));
				bool_10 = Convert.ToBoolean(@class.method_1("ckTaoMailBox"));
				string_17 = @class.method_1("txtPassmail");
				string_11 = @class.method_1("txtAPISim");
				string_16 = @class.method_1("txtAPIAnyCat");
				int_24 = Convert.ToInt32(@class.method_1("nudLuongPerIPMinProxy"));
				string_18 = @class.method_1("linkAvartar");
				string_19 = @class.method_1("linkCover");
				bool_11 = Convert.ToBoolean(@class.method_1("ckRdPassmail"));
				bool bool_0 = Convert.ToInt32(@class.method_1("modeRun")) == 1;
				bool_15 = Settings.Default.isDongBoDB;
				int_34 = Convert.ToInt32(@class.method_1("nudDelayQR2Fa"));
				int_15 = ((@class.method_1("nAgeFrom") == "") ? 18 : Convert.ToInt32(@class.method_1("nAgeFrom")));
				int_16 = ((@class.method_1("nAgeTo") == "") ? 35 : Convert.ToInt32(@class.method_1("nAgeTo")));
				int_36 = ((!(@class.method_1("cbModeRunReg") == "")) ? Convert.ToInt32(@class.method_1("cbModeRunReg")) : 0);
				int_14 = ((@class.method_1("nudTimeWaitOTP") == "") ? 60 : Convert.ToInt32(@class.method_1("nudTimeWaitOTP")));
				if (Settings.Default.isVeriPhoneNoveri)
				{
					Class48 class2 = new Class48("setting_veriaccnoveri.ini");
					bool_16 = Settings.Default.isVeriPhoneNoveri;
					string_20 = ((class2.method_1("apikey") == "") ? "" : class2.method_1("apikey"));
					int_37 = ((!(class2.method_1("typePhone") == "")) ? Convert.ToInt32(class2.method_1("typePhone")) : 0);
					int_39 = ((class2.method_1("nudTimeGetPhone") == "") ? 10 : Convert.ToInt32(class2.method_1("nudTimeGetPhone")));
				}
				if (Settings.Default.isVeriMailNoveri)
				{
					Class48 class3 = new Class48("setting_verimailaccnoveri.ini");
					bool_17 = Settings.Default.isVeriMailNoveri;
					int_38 = ((!(class3.method_1("typeMail") == "")) ? Convert.ToInt32(class3.method_1("typeMail")) : 0);
				}
				if (int_1 == 0)
				{
					MessageBox.Show("Số lượt chạy > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (!Directory.Exists(string_9))
				{
					MessageBox.Show("Đường dẫn LDPlayer không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (chkAvartar.Checked && string_18 == string.Empty)
				{
					MessageBox.Show("Đường dẫn Folder avatar không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (rdProxy.Checked && rdIPPortUserPass.Checked)
				{
					list_13.Clear();
					List<string> list = txtListProxyIp.Lines.ToList();
					list = Common.smethod_77(list);
					foreach (string item6 in list)
					{
						list_13.Add(item6);
					}
					list_13 = Common.smethod_38(list_13);
					if (list_13.Count == 0)
					{
						MessageBox.Show("Vui lòng nhập danh sách proxy cần chạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						txtListProxyIp.Focus();
						return;
					}
					if (list_13.Count < int_11)
					{
						MessageBox.Show("Không đủ proxy để chạy với số luồng hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					queue_0 = new Queue<string>(list_13);
				}
				if (int_9 == 2)
				{
					list_6 = Class67.smethod_2(string_15);
					if (list_6.Count == 0)
					{
						MessageBox.Show("Proxy Tinsoft không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					list_5 = new List<Class67>();
					int_19 = Convert.ToInt32(@class.method_1("nudLuongPerIPTinsoft"));
					int_20 = Convert.ToInt32(@class.method_1("cbbLocationTinsoft"));
					if (int_19 == 0)
					{
						MessageBox.Show("Số luồng chạy proxy Tinsoft > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					for (int i = 0; i < list_6.Count; i++)
					{
						Class67 item = new Class67(list_6[i], int_19, int_20);
						list_5.Add(item);
					}
					if (list_6.Count * int_19 < int_11)
					{
						int_11 = list_6.Count * int_19;
					}
				}
				else if (int_9 == 1)
				{
					try
					{
						ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
						{
							UseShellExecute = false,
							RedirectStandardOutput = true,
							CreateNoWindow = true
						};
						Process process = Process.Start(startInfo);
						string text = process.StandardOutput.ReadToEnd();
						if (text.Split('\n').Length <= 3)
						{
							MessageBox.Show("Vui lòng kết nối Dcom trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
					}
					catch
					{
						MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				else if (int_9 == 3)
				{
					if (list_11.Count == 0)
					{
						MessageBox.Show("MinProxy không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					list_12 = new List<Class51>();
					for (int j = 0; j < list_11.Count; j++)
					{
						Class51 item2 = new Class51(list_11[j], 0, int_24);
						list_12.Add(item2);
					}
					if (list_11.Count * int_24 < int_11)
					{
						int_11 = list_11.Count * int_24;
					}
				}
				else if (int_9 == 6)
				{
					if (list_17.Count == 0)
					{
						MessageBox.Show("XProxy không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					int_26 = Convert.ToInt32(@class.method_1("typeRunXproxy"));
					int_27 = Convert.ToInt32(@class.method_1("nudDelayResetXProxy"));
					bool_12 = Convert.ToBoolean(@class.method_1("ckbWaitDoneAllXproxy"));
					list_14 = new List<Class73>();
					for (int k = 0; k < list_17.Count; k++)
					{
						Class73 item3 = new Class73(@class.method_1("txtServiceURLXProxy"), list_17[k], Convert.ToInt32(@class.method_1("typeRunXproxy")), Convert.ToInt32(@class.method_1("nudLuongPerIPXProxy")));
						list_14.Add(item3);
					}
					if (list_17.Count * Convert.ToInt32(@class.method_1("nudLuongPerIPXProxy")) < int_11)
					{
						int_11 = list_17.Count * Convert.ToInt32(@class.method_1("nudLuongPerIPXProxy"));
					}
				}
				else if (int_9 == 7)
				{
					if (list_18.Count == 0)
					{
						MessageBox.Show("TMProxy không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					list_15 = new List<Class68>();
					for (int l = 0; l < list_18.Count; l++)
					{
						Class68 item4 = new Class68(list_18[l], 0, Convert.ToInt32(@class.method_1("nudLuongPerIPTMProxy")));
						list_15.Add(item4);
					}
					if (list_18.Count * Convert.ToInt32(@class.method_1("nudLuongPerIPTMProxy")) < int_11)
					{
						int_11 = list_18.Count * Convert.ToInt32(@class.method_1("nudLuongPerIPTMProxy"));
					}
				}
				else if (int_9 == 8)
				{
					if (list_19.Count == 0)
					{
						MessageBox.Show("Proxy Shoplike không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					list_16 = new List<Class61>();
					for (int m = 0; m < list_19.Count; m++)
					{
						Class61 item5 = new Class61(list_19[m], 0, Convert.ToInt32(@class.method_1("nudThreadShopLike")));
						list_16.Add(item5);
					}
					if (list_19.Count * Convert.ToInt32(@class.method_1("nudThreadShopLike")) < int_11)
					{
						int_11 = list_19.Count * Convert.ToInt32(@class.method_1("nudThreadShopLike"));
					}
				}
				else if (int_9 == 5)
				{
					int_35 = ((!(@class.method_1("cbbTypeProxyIP") == "")) ? Convert.ToInt32(@class.method_1("cbbTypeProxyIP")) : 0);
				}
				else if (int_9 == 9)
				{
					int_40 = ((!(@class.method_1("typeProxyOrbit") == "")) ? Convert.ToInt32(@class.method_1("typeProxyOrbit")) : 0);
				}
				else if (int_9 == 10)
				{
					if (list_19z.Count == 0)
					{
						MessageBox.Show("Proxyv6 không đủ, vui lòng mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					list_16 = new List<Class61>();
					for (int m = 0; m < list_19.Count; m++)
					{
						Class61 item5 = new Class61(list_19[m], 0, Convert.ToInt32(@class.method_1("nudThreadShopLike")));
						list_16.Add(item5);
					}
					if (list_19.Count * Convert.ToInt32(@class.method_1("nudThreadShopLike")) < int_11)
					{
						int_11 = list_19.Count * Convert.ToInt32(@class.method_1("nudThreadShopLike"));
					}
				}
				if (rdHotMailRegisted.Checked)
				{
					list_1 = File.ReadAllLines("hotmail.txt").ToList();
					list_1 = Common.smethod_77(list_1);
					if (list_1.Count <= 0 || list_1.Count < int_11)
					{
						MessageBox.Show("Vui lòng nhập thêm hotmail đã đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				if (Settings.Default.isAddMailReg)
				{
					list_2 = File.ReadAllLines("EmailVeri.txt").ToList();
					list_2 = Common.smethod_77(list_2);
					if (list_2.Count <= 0 || list_2.Count < int_11)
					{
						MessageBox.Show("Email không đủ để add sau khi reg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					queue_1 = new Queue<string>(list_2);
				}
				if (string_12.Substring(0, 1) == "0")
				{
					if (string_12.Substring(1, 1) != "0" && Settings.Default.isVeriPhoneNoveri)
					{
						MessageBox.Show("Vui lòng tắt chức năng veri phone cho noveri trong Cài đặt nâng cao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					if (string_12.Substring(1, 1) != "0" && Settings.Default.isVeriMailNoveri)
					{
						MessageBox.Show("Vui lòng tắt chức năng veri mail cho noveri trong Cài đặt nâng cao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					if (Settings.Default.isVeriMailNoveri && Settings.Default.isVeriPhoneNoveri)
					{
						MessageBox.Show("Vui lòng chỉ sử dụng 1 kiểu veri cho noveri trong Cài đặt nâng cao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				if (string_12.Substring(0, 1) != "0" && (Settings.Default.isVeriMailNoveri || Settings.Default.isVeriPhoneNoveri))
				{
					MessageBox.Show("Vui lòng tắt chức năng veri cho noveri trong Cài đặt nâng cao trước khi reg veri trực tiếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				int int_0 = 0;
				this.bool_0 = false;
				bool bool_1 = false;
				List<int> list_0 = new List<int>();
				for (int n = 0; n < int_11; n++)
				{
					list_0.Add(0);
				}
				method_21(bool_0);
				for (int num = 0; num < int_11; num++)
				{
					frmViewLD.frmViewLD_0.method_0(num + 1);
				}
				new Thread((ThreadStart)delegate
				{
					method_19("start");
					int num2 = 0;
					dgvAcc.Invoke((MethodInvoker)delegate
					{
						dgvAcc.Rows.Clear();
					});
					if (int_36 == 0)
					{
						string text2 = "";
						int num3 = int_1;
						if (num3 == 0)
						{
							num3 = 1;
						}
						int num4 = 0;
						while (num4 < num3 && (queue_0 == null || queue_0.Count != 0))
						{
							text2 = ((num3 > 1) ? $"Lượt {num4 + 1}/{num3}. " : "");
							if (num3 > 1)
							{
								method_20("Đang reg..." + text2);
							}
							else
							{
								method_20("Đang reg...");
							}
							Common.smethod_62(0.5);
							if (this.bool_0)
							{
								break;
							}
							int num5 = 0;
							while (num5 < int_11 && !this.bool_0 && !this.bool_0)
							{
								if (int_0 < int_11)
								{
									Interlocked.Increment(ref int_0);
									int int_2 = 0;
									dgvAcc.Invoke((MethodInvoker)delegate
									{
										int_2 = dgvAcc.Rows.Add();
									});
									num5++;
									Thread thread = new Thread((ThreadStart)delegate
									{
										try
										{
											int num16 = Common.smethod_83(ref list_0);
											string textcaptcha = text_api_captcha.Text;
											method_24(int_2, num16 + 1, bool_0, string_9, textcaptcha);
											Common.smethod_65(ref list_0, num16 + 1);
											Interlocked.Decrement(ref int_0);
										}
										catch
										{
											Interlocked.Decrement(ref int_0);
										}
									})
									{
										Name = int_2.ToString()
									};
									list_3.Add(thread);
									Common.smethod_62(1.0);
									thread.Start();
								}
								else
								{
									for (int num6 = 0; num6 < list_3.Count(); num6++)
									{
										list_3[num6].Join();
									}
									for (int num7 = 0; num7 < list_3.Count(); num7++)
									{
										try
										{
											list_3[num7].Abort();
										}
										catch
										{
										}
									}
									list_3.Clear();
									int_0 = 0;
								}
								if (int_9 == 6 && bool_12)
								{
									try
									{
										for (int num8 = 0; num8 < list_3.Count; num8++)
										{
											list_3[num8].Join();
											list_3.RemoveAt(num8--);
										}
									}
									catch
									{
									}
								}
								if (this.bool_0)
								{
									break;
								}
							}
							for (int num9 = 0; num9 < list_3.Count(); num9++)
							{
								list_3[num9].Join();
							}
							for (int num10 = 0; num10 < list_3.Count(); num10++)
							{
								try
								{
									list_3[num10].Abort();
								}
								catch
								{
								}
							}
							list_3.Clear();
							num2++;
							if (!this.bool_0 && num2 >= int_8 && (int_9 == 1 || int_9 == 4))
							{
								method_20("Đang đổi IP...");
								bool_1 = Common.smethod_56(int_9, 0, string_10, "");
								num2 = 0;
								if (bool_1)
								{
									Invoke((MethodInvoker)delegate
									{
										stIPCur.Text = method_54();
									});
								}
							}
							if (num4 + 1 < num3)
							{
								int num11 = random_0.Next(0, 10);
								int tickCount = Environment.TickCount;
								while ((Environment.TickCount - tickCount) / 1000 - num11 < 0)
								{
									method_20(string.Format("Chạy lượt tiếp theo sau {time} giây...".Replace("{time}", (num11 - (Environment.TickCount - tickCount) / 1000).ToString())));
									Common.smethod_62(0.5);
									if (Settings.Default.isAutoClearLD)
									{
										Common.smethod_39(string_9);
									}
									if (this.bool_0)
									{
										break;
									}
								}
							}
							if (!this.bool_0)
							{
								num4++;
							}
							else if (this.bool_0)
							{
								method_19("stop");
								break;
							}
						}
					}
					else
					{
						while (!this.bool_0)
						{
							if (int_9 == 1 || int_9 == 4)
							{
								method_20("Đang đổi IP...");
								bool_1 = Common.smethod_56(int_9, 0, string_10, "");
								num2 = 0;
								if (bool_1)
								{
									Invoke((MethodInvoker)delegate
									{
										stIPCur.Text = method_54();
									});
								}
							}
							if (queue_0 != null && queue_0.Count == 0)
							{
								break;
							}
							method_20("Đang reg...");
							Common.smethod_62(0.5);
							if (this.bool_0)
							{
								break;
							}
							int num12 = 0;
							while (num12 < int_11)
							{
								if (this.bool_0)
								{
									break;
								}
								int int_ = 0;
								dgvAcc.Invoke((MethodInvoker)delegate
								{
									int_ = dgvAcc.Rows.Add();
								});
								num12++;
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									while (!this.bool_0)
									{
										if (!this.bool_0)
										{
											try
											{
												dgvAcc.Invoke((MethodInvoker)delegate
												{
													dgvAcc.Rows[int_].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
												});
												string textcaptcha = text_api_captcha.Text;
												method_24(int_, int_ + 1, bool_0, string_9, textcaptcha);
												Common.smethod_62(1.0);
											}
											catch
											{
											}
										}
									}
								});
								thread2.Name = int_.ToString();
								thread2.Start();
								list_3.Add(thread2);
								if (int_9 == 6 && bool_12)
								{
									try
									{
										for (int num13 = 0; num13 < list_3.Count; num13++)
										{
											list_3[num13].Join();
											list_3.RemoveAt(num13--);
										}
									}
									catch
									{
									}
								}
							}
							for (int num14 = 0; num14 < list_3.Count(); num14++)
							{
								try
								{
									list_3[num14].Join();
								}
								catch
								{
								}
							}
							for (int num15 = 0; num15 < list_3.Count(); num15++)
							{
								try
								{
									list_3[num15].Abort();
								}
								catch
								{
								}
							}
							list_3.Clear();
						}
					}
					method_50();
					method_19("stop");
					list_4.Clear();
					btnStop.Invoke((MethodInvoker)delegate
					{
						btnStop.Text = "Dừng lại";
						plTrangThai.Text = "Kết thúc đăng ký";
					});
					if (Settings.Default.isAutoClearLD)
					{
						Common.smethod_39(string_9);
					}
					try
					{
						thread_0.Abort();
					}
					catch
					{
					}
				}).Start();
			}
			catch
			{
				plTrangThai.Text = "Kết thúc đăng ký";
				btnStop.Text = "Dừng lại";
				method_19("stop");
				method_50();
				list_4.Clear();
				list_4.Clear();
				if (Settings.Default.isAutoClearLD)
				{
					Common.smethod_39(string_9);
				}
				try
				{
					thread_0.Abort();
				}
				catch
				{
				}
			}
		}

		private void method_20(string string_21)
		{
			try
			{
				Invoke((MethodInvoker)delegate
				{
					plTrangThai.Text = string_21;
				});
			}
			catch
			{
			}
		}

		private void method_21(bool bool_18)
		{
			if (!Common.smethod_84("frmViewLD"))
			{
				frmViewLD obj = new frmViewLD();
				obj.bool_0 = bool_18;
				obj.Show();
			}
		}

		public void method_22(int int_41, string string_21, object object_15, bool bool_18 = true)
		{
			if (bool_18 || !(object_15.ToString().Trim() == ""))
			{
				Class15.smethod_4(dgvAcc, int_41, string_21, object_15);
			}
		}

		private bool method_23(Device device_0)
		{
			device_0.method_103();
			device_0.method_121(1.0);
			bool flag = false;
			int num = 0;
			device_0.method_91(262, 387);
			device_0.method_121(1.0);
			while (num < 5)
			{
				num++;
				if (device_0.method_52("DataClick\\xposed\\on"))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				device_0.method_91(97, 222);
				device_0.method_121(2.0);
				device_0.method_91(53, 247);
				int i = 0;
				bool flag2 = false;
				for (; i < 60; i++)
				{
					if (device_0.method_52("DataClick\\xposed\\rememberchoice"))
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					device_0.method_91(240, 463);
					device_0.method_121(10.0);
					device_0.method_69();
					flag = (device_0.method_11() ? true : false);
				}
			}
			return flag;
		}

		private void method_24(int int_41, int int_42, bool bool_18, string string_21, string text_api_captcha) // reg start
		{
			Device device = null;
			string text = null;
			Class67 @class = null;
			Class51 class2 = null;
			Class73 class3 = null;
			Class68 class4 = null;
			Class61 class5 = null;
			int num = 0;
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			bool flag = false;
			bool flag2 = ((!(string_12.Substring(0, 1) == "0")) ? true : false);
			int num2 = 0;
			int num3 = 0;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			int num4 = 0;
			method_52((int_41 + 1).ToString(), "cId", int_41, 0, dgvAcc);
			if (bool_0)
			{
				return;
			}
			while (true)
			{
				switch (int_9)
				{
					case 8:
						method_62(int_41, "Đang lấy Proxy ShopLike ...");
						if (int_36 == 1)
						{
							lock (object_5)
							{
								while (!bool_0)
								{
									class5 = null;
									while (!bool_0)
									{
										foreach (Class61 item in list_16)
										{
											if (class5 == null || item.int_1 < class5.int_1)
											{
												class5 = item;
												if (class5.int_1 != class5.int_2)
												{
													break;
												}
											}
										}
										if (class5.int_1 != class5.int_2)
										{
											break;
										}
									}
									if (bool_0)
									{
										break;
									}
									if (class5.int_1 > 0 || class5.method_1())
									{
										text2 = class5.proxy;
										if (text2 == "")
										{
											text2 = class5.method_3();
										}
										Class61 class16 = class5;
										class16.int_0++;
										class16 = class5;
										class16.int_1++;
										break;
									}
								}
								if (bool_0)
								{
									method_62(int_41, text3 + "Dừng chạy...");
									break;
								}
								text3 = "(IP: " + text2.Split(':')[0] + ") ";
								if (ckCheckIP.Checked)
								{
									bool flag33 = true;
									method_62(int_41, text3 + "Check IP...");
									text4 = Common.smethod_35(text2, 0);
									if (text4 == "")
									{
										flag33 = false;
									}
									if (!flag33)
									{
										Class61 class16 = class5;
										class16.int_0--;
										class16 = class5;
										class16.int_1--;
										continue;
									}
								}
								method_52(text2, "proxy", int_41, 0, dgvAcc);
								goto default;
							}
						}
						lock (object_5)
						{
							while (!bool_0)
							{
								class5 = null;
								while (!bool_0)
								{
									foreach (Class61 item2 in list_16)
									{
										if (class5 == null || item2.int_1 < class5.int_1)
										{
											class5 = item2;
											if (class5.int_1 != class5.int_2)
											{
												break;
											}
										}
									}
									if (class5.int_1 != class5.int_2)
									{
										break;
									}
								}
								if (bool_0)
								{
									break;
								}
								if (class5.int_1 > 0 || class5.method_1())
								{
									text2 = class5.proxy;
									if (text2 == "")
									{
										text2 = class5.method_3();
									}
									Class61 class16 = class5;
									class16.int_0++;
									class16 = class5;
									class16.int_1++;
									break;
								}
							}
							if (bool_0)
							{
								method_62(int_41, text3 + "Dừng chạy...");
								break;
							}
							text3 = "(IP: " + text2.Split(':')[0] + ") ";
							if (ckCheckIP.Checked)
							{
								bool flag34 = true;
								method_62(int_41, text3 + "Check IP...");
								text4 = Common.smethod_35(text2, 0);
								if (text4 == "")
								{
									flag34 = false;
								}
								if (!flag34)
								{
									Class61 class16 = class5;
									class16.int_0--;
									class16 = class5;
									class16.int_1--;
									continue;
								}
							}
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						}
					case 7:
						method_62(int_41, "Đang lấy TMProxy...");
						if (int_36 == 1)
						{
							lock (object_5)
							{
								while (!bool_0)
								{
									class4 = null;
									while (!bool_0)
									{
										foreach (Class68 item3 in list_15)
										{
											if (class4 == null || item3.int_1 < class4.int_1 || item3.next_change == 0)
											{
												class4 = item3;
												if (class4.int_1 != class4.int_2)
												{
													break;
												}
											}
										}
										if (class4.next_change > 0)
										{
											method_62(int_41, "Thời gian lấy Proxy kế tiếp: " + class4.next_change + " giây");
										}
										if (class4.int_1 != class4.int_2)
										{
											break;
										}
									}
									if (!bool_0)
									{
										if (class4.int_1 > 0 || class4.method_4())
										{
											text2 = class4.proxy;
											if (text2 == "")
											{
												text2 = class4.method_7();
											}
											Class68 class11 = class4;
											Class68 class12 = class11;
											class12.int_0++;
											class11 = class4;
											class12 = class11;
											class12.int_1++;
											break;
										}
										continue;
									}
									method_62(int_41, text3 + "Dừng chạy...");
									break;
								}
								if (bool_0)
								{
									method_62(int_41, text3 + "Dừng chạy...");
									break;
								}
								text3 = "(IP: " + text2.Split(':')[0] + ") ";
								if (ckCheckIP.Checked)
								{
									bool flag31 = true;
									method_62(int_41, text3 + "Check IP...");
									text4 = Common.smethod_35(text2, 0);
									if (text4 == "")
									{
										flag31 = false;
									}
									if (!flag31)
									{
										Class68 class13 = class4;
										Class68 class12 = class13;
										class12.int_0--;
										class13 = class4;
										class12 = class13;
										class12.int_1--;
										continue;
									}
								}
								method_52(text2, "proxy", int_41, 0, dgvAcc);
								goto default;
							}
						}
						lock (object_5)
						{
							while (!bool_0)
							{
								class4 = null;
								while (!bool_0)
								{
									foreach (Class68 item4 in list_15)
									{
										if (class4 == null || item4.int_1 < class4.int_1)
										{
											class4 = item4;
											if (class4.int_1 != class4.int_2)
											{
												break;
											}
										}
									}
									if (class4.next_change > 0)
									{
										method_62(int_41, "Thời gian lấy Proxy kế tiếp: " + class4.next_change + " giây");
									}
									if (class4.int_1 != class4.int_2)
									{
										break;
									}
								}
								if (!bool_0)
								{
									if (class4.int_1 > 0 || class4.method_4())
									{
										text2 = class4.proxy;
										if (text2 == "")
										{
											text2 = class4.method_7();
										}
										Class68 class14 = class4;
										Class68 class12 = class14;
										class12.int_0++;
										class14 = class4;
										class12 = class14;
										class12.int_1++;
										break;
									}
									continue;
								}
								method_62(int_41, text3 + "Dừng chạy...");
								break;
							}
							if (bool_0)
							{
								method_62(int_41, text3 + "Dừng chạy...");
								break;
							}
							text3 = "(IP: " + text2.Split(':')[0] + ") ";
							if (ckCheckIP.Checked)
							{
								bool flag32 = true;
								method_62(int_41, text3 + "Check IP...");
								text4 = Common.smethod_35(text2, 0);
								if (text4 == "")
								{
									flag32 = false;
								}
								if (!flag32)
								{
									Class68 class15 = class4;
									Class68 class12 = class15;
									class12.int_0--;
									class15 = class4;
									class12 = class15;
									class12.int_1--;
									continue;
								}
							}
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						}
					case 6:
						method_62(int_41, "Đang lấy Proxy...");
						if (int_36 == 1)
						{
							lock (object_5)
							{
								if (int_26 == 0)
								{
									while (!bool_0)
									{
										class3 = null;
										while (!bool_0)
										{
											foreach (Class73 item5 in list_14)
											{
												if (item5.bool_0 && (class3 == null || item5.int_2 < class3.int_2))
												{
													class3 = item5;
													if (class3.int_2 != class3.int_3)
													{
														break;
													}
												}
											}
											if (class3.int_2 != class3.int_3)
											{
												break;
											}
										}
										if (!bool_0)
										{
											if (!class3.bool_0 || (class3.int_2 <= 0 && !class3.method_2()))
											{
												class3.bool_0 = false;
												continue;
											}
											text2 = class3.string_1;
											num = class3.int_0;
											Class73 class19 = class3;
											Class73 class20 = class19;
											class20.int_1++;
											class19 = class3;
											class20 = class19;
											class20.int_2++;
											break;
										}
										method_62(int_41, text3 + "Dừng chạy!");
										break;
									}
								}
								else
								{
									while (!bool_0)
									{
										class3 = null;
										List<Class73> list5 = new List<Class73>();
										foreach (Class73 item6 in list_14)
										{
											if (item6.bool_0)
											{
												if (item6.int_2 < item6.int_3)
												{
													list5.Add(item6);
												}
												else if (item6.int_1 == 0)
												{
													item6.method_1();
													item6.int_2 = 0;
												}
											}
										}
										for (int num72 = 0; num72 < list5.Count; num72++)
										{
											if (list5[num72].method_4(0))
											{
												class3 = list5[num72];
												break;
											}
										}
										if (class3 != null)
										{
											text2 = class3.string_1;
											num = class3.int_0;
											Class73 class21 = class3;
											Class73 class20 = class21;
											class20.int_1++;
											class21 = class3;
											class20 = class21;
											class20.int_2++;
											break;
										}
									}
								}
								if (bool_0)
								{
									method_62(int_41, text3 + "Dừng chạy!");
									break;
								}
								text3 = "(IP: " + text2 + ") ";
								if (ckCheckIP.Checked)
								{
									bool flag35 = true;
									method_62(int_41, text3 + "Check IP...");
									text4 = Common.smethod_36(text2, num, int_27 * 60);
									if (text4 == "")
									{
										class3.bool_0 = false;
										flag35 = false;
									}
									if (!flag35)
									{
										Class73 class20 = class3;
										class20.int_1--;
										class20 = class3;
										class20.int_2--;
										continue;
									}
								}
								method_52(text2, "proxy", int_41, 0, dgvAcc);
								goto default;
							}
						}
						lock (object_5)
						{
							if (int_26 == 0)
							{
								while (!bool_0)
								{
									class3 = null;
									while (!bool_0)
									{
										foreach (Class73 item7 in list_14)
										{
											if (item7.bool_0 && (class3 == null || item7.int_2 < class3.int_2))
											{
												class3 = item7;
												if (class3.int_2 != class3.int_3)
												{
													break;
												}
											}
										}
										if (class3.int_2 != class3.int_3)
										{
											break;
										}
									}
									if (!bool_0)
									{
										if (!class3.bool_0 || (class3.int_2 <= 0 && !class3.method_2()))
										{
											class3.bool_0 = false;
											continue;
										}
										text2 = class3.string_1;
										num = class3.int_0;
										Class73 class20 = class3;
										class20.int_1++;
										class20 = class3;
										class20.int_2++;
										break;
									}
									method_62(int_41, text3 + "Dừng chạy!");
									break;
								}
							}
							else
							{
								while (!bool_0)
								{
									class3 = null;
									List<Class73> list6 = new List<Class73>();
									foreach (Class73 item8 in list_14)
									{
										if (item8.bool_0)
										{
											if (item8.int_2 < item8.int_3)
											{
												list6.Add(item8);
											}
											else if (item8.int_1 == 0)
											{
												item8.method_1();
												item8.int_2 = 0;
											}
										}
									}
									for (int num73 = 0; num73 < list6.Count; num73++)
									{
										if (list6[num73].method_4(0))
										{
											class3 = list6[num73];
											break;
										}
									}
									if (class3 != null)
									{
										text2 = class3.string_1;
										num = class3.int_0;
										Class73 class20 = class3;
										class20.int_1++;
										class20 = class3;
										class20.int_2++;
										break;
									}
								}
							}
							if (bool_0)
							{
								method_62(int_41, text3 + "Dừng chạy!");
								break;
							}
							text3 = "(IP: " + text2 + ") ";
							if (ckCheckIP.Checked)
							{
								bool flag36 = true;
								method_62(int_41, text3 + "Check IP...");
								text4 = Common.smethod_36(text2, num, int_27 * 60);
								if (text4 == "")
								{
									class3.bool_0 = false;
									flag36 = false;
								}
								if (!flag36)
								{
									Class73 class20 = class3;
									class20.int_1--;
									class20 = class3;
									class20.int_2--;
									continue;
								}
							}
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						}
					case 3:
						method_62(int_41, "Đang lấy Api MinProxy...");
						class2 = null;
						flag = false;
						if (list_12.Count != 0)
						{
							lock (object_5)
							{
								while (true)
								{
									if (!bool_0)
									{
										if (bool_0)
										{
											break;
										}
										foreach (Class51 item9 in list_12)
										{
											if (item9.int_1 != 0)
											{
												if (class2 == null || item9.int_2 < class2.int_2)
												{
													class2 = item9;
												}
												continue;
											}
											class2 = item9;
											break;
										}
										if (class2.int_2 >= class2.int_3)
										{
											continue;
										}
									}
									if (class2 != null)
									{
										Class51 class17 = class2;
										Class51 class18 = class17;
										class18.int_1++;
										class17 = class2;
										class18 = class17;
										class18.int_2++;
										goto IL_11ec;
									}
									break;
								}
							}
							goto IL_13e9;
						}
						method_62(int_41, "Hết proxy rồi!!!.");
						break;
					case 2:
						method_62(int_41, "Đang lấy proxy Tinsoft...");
						if (int_36 == 1)
						{
							lock (object_5)
							{
								while (!bool_0)
								{
									@class = null;
									while (!bool_0)
									{
										foreach (Class67 item10 in list_5)
										{
											if (@class == null || item10.int_2 < @class.int_2 || item10.next_change == 0)
											{
												@class = item10;
												if (@class.int_2 != @class.int_3)
												{
													break;
												}
											}
										}
										if (@class.next_change > 0)
										{
											method_62(int_41, "Thời gian lấy Proxy kế tiếp: " + @class.next_change + " giây");
										}
										if (@class.int_2 != @class.int_3)
										{
											break;
										}
									}
									if (!bool_0)
									{
										if (@class.int_2 > 0 || @class.method_2())
										{
											text2 = @class.proxy;
											if (text2 == "")
											{
												text2 = @class.method_3();
											}
											Class67 class6 = @class;
											Class67 class7 = class6;
											class7.int_1++;
											class6 = @class;
											class7 = class6;
											class7.int_2++;
											break;
										}
										continue;
									}
									method_62(int_41, text3 + "Dừng chạy!");
									break;
								}
								if (bool_0)
								{
									method_62(int_41, text3 + "Dừng chạy", device);
									break;
								}
								text3 = "(IP: " + text2.Split(':')[0] + ") ";
								if (ckCheckIP.Checked)
								{
									bool flag8 = true;
									method_62(int_41, text3 + "Check IP...");
									text4 = Common.smethod_35(text2, 0);
									if (text4 == "")
									{
										flag8 = false;
									}
									if (!flag8)
									{
										Class67 class8 = @class;
										Class67 class7 = class8;
										class7.int_1--;
										class8 = @class;
										class7 = class8;
										class7.int_2--;
										continue;
									}
								}
								method_52(text2, "proxy", int_41, 0, dgvAcc);
								goto default;
							}
						}
						lock (object_5)
						{
							while (!bool_0)
							{
								@class = null;
								while (!bool_0)
								{
									foreach (Class67 item11 in list_5)
									{
										if (@class == null || item11.int_2 < @class.int_2)
										{
											@class = item11;
											if (@class.int_2 != @class.int_3)
											{
												break;
											}
										}
									}
									if (@class.next_change > 0)
									{
										method_62(int_41, "Thời gian lấy Proxy kế tiếp: " + @class.next_change + " giây");
									}
									if (@class.int_2 != @class.int_3)
									{
										break;
									}
								}
								if (!bool_0)
								{
									if (@class.int_2 > 0 || @class.method_2())
									{
										text2 = @class.proxy;
										if (text2 == "")
										{
											text2 = @class.method_3();
										}
										Class67 class9 = @class;
										Class67 class7 = class9;
										class7.int_1++;
										class9 = @class;
										class7 = class9;
										class7.int_2++;
										break;
									}
									continue;
								}
								method_62(int_41, text3 + "Dừng chạy!");
								break;
							}
							if (bool_0)
							{
								method_62(int_41, text3 + "Dừng chạy", device);
								break;
							}
							text3 = "(IP: " + text2.Split(':')[0] + ") ";
							if (ckCheckIP.Checked)
							{
								bool flag9 = true;
								method_62(int_41, text3 + "Check IP...");
								text4 = Common.smethod_35(text2, 0);
								if (text4 == "")
								{
									flag9 = false;
								}
								if (!flag9)
								{
									Class67 class10 = @class;
									Class67 class7 = class10;
									class7.int_1--;
									class10 = @class;
									class7 = class10;
									class7.int_2--;
									continue;
								}
							}
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						}
					case 5:
						method_62(int_41, "Lấy proxy từ danh sách...");
						if (int_36 == 1)
						{
							if (queue_0.Count == 0)
							{
								queue_0 = new Queue<string>(list_13);
							}
							text2 = queue_0.Dequeue();
							if (text2 != "")
							{
								text3 = "(IP: " + text2.Split(':')[0] + ") ";
							}
							if (ckCheckIP.Checked)
							{
								method_62(int_41, text3 + "Check IP...");
								bool flag6 = false;
								int num5 = 0;
								while (true)
								{
									if (num5 < 5)
									{
										if (!bool_0)
										{
											Common.smethod_62(1.0);
											text4 = Common.smethod_35(text2, int_35);
											if (!(text4 != ""))
											{
												if (bool_0)
												{
													break;
												}
												num5++;
												continue;
											}
											flag6 = true;
										}
										else
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
										}
									}
									if (!flag6)
									{
										goto IL_1a83;
									}
									goto IL_1ac3;
								}
								break;
							}
							goto IL_1ac3;
						}
						lock (object_5)
						{
							if (queue_0.Count == 0)
							{
								break;
							}
							text2 = queue_0.Dequeue();
							if (text2 != "")
							{
								text3 = "(IP: " + text2.Split(':')[0] + ") ";
							}
							if (!ckCheckIP.Checked)
							{
								goto IL_1c28;
							}
							method_62(int_41, text3 + "Check IP...");
							bool flag7 = false;
							int num6 = 0;
							while (true)
							{
								if (num6 < 5)
								{
									if (!bool_0)
									{
										Common.smethod_62(1.0);
										text4 = Common.smethod_35(text2, int_35);
										if (!(text4 != ""))
										{
											if (!bool_0)
											{
												num6++;
												continue;
											}
											break;
										}
										flag7 = true;
									}
									else
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
									}
								}
								if (!flag7)
								{
									if (text2 != "")
									{
										method_62(int_41, text3 + "Không thể kết nối proxy!");
									}
									else
									{
										method_62(int_41, text3 + "Không có kết nối Internet!");
									}
									break;
								}
								goto IL_1c28;
							}
							goto end_IL_1ae8;
						IL_1c28:
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						end_IL_1ae8:;
						}
						break;
					case 9:
						method_62(int_41, "Đang lấy Proxy free ...");
						lock (object_5)
						{
							if (bool_0)
							{
								method_62(int_41, text3 + "Dừng chạy!");
								break;
							}
							text2 = Common.smethod_85(int_40);
							if (text2 == "")
							{
								method_62(int_41, "Đã hết proxy free... Vui lòng chọn loại khác");
								break;
							}
							text3 = "(IP: " + text2.Split(':')[0] + ") ";
							method_52(text2, "proxy", int_41, 0, dgvAcc);
							goto default;
						}
					default:
                        {
                      /*3217*/      if ((rdConfMail.Checked && rdTempMailIO.Checked) || (rdConfMail.Checked && rdMailTM.Checked) )
                            {
								try
								{
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										break;
									}
									if (bool_18)
									{
										method_22(int_41, "cDevice", int_42.ToString());
										device = new Device(string_21, int_42.ToString() ?? "", string_18);
										goto IL_1f3e;
									}
									string text11 = method_1(int_41, "cDevice");
									if (text11 == "" || !Directory.Exists(string_21 + "\\vms\\leidian" + text11))
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										method_62(int_41, text3 + "Tạo thiết bị, chờ đến lượt...", device);
										object obj = object_3;
										lock (obj)
										{
											method_62(int_41, text3 + "Tạo thiết bị...", device);
											List<string> second = Class2.smethod_31(string_21);
											Class2.smethod_29(string_21);
											int num7 = 0;
											while (true)
											{
												if (num7 >= 30)
												{
													goto IL_1e63;
												}
												if (!bool_0)
												{
													text11 = Class2.smethod_31(string_21).Except(second).First();
													if (!(text11 != ""))
													{
														num7++;
														continue;
													}
													goto IL_1e63;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1d06;
											IL_1e63:
												if (text11 == "")
												{
													method_62(int_41, text3 + "Tạo thiết bị thất bại!");
													method_49("Tạo LD thất bại", device.int_0, int_41, int_42, device, bool_18: false);
													goto end_IL_1928;
												}
												break;
											}
										}
										device = new Device(string_21, text11, string_18);
										device.PathLDPlayer = string_21;
										method_22(int_41, "cDevice", text11);
										method_62(int_41, text3 + "Cấu hình LDPlayer...");
										device.method_117();
										device.method_116();
										goto IL_1f3e;
									}
									device = new Device(string_21, text11 ?? "", string_18);
									goto IL_1f3e;
								IL_1f3e:
									device.method_117();
									device.method_116();
									method_62(int_41, text3 + "Chờ đến lượt...");
									object obj2 = object_2;
									lock (obj2)
									{
										if (int_2 == 0)
										{
											do
											{
												if (bool_9)
												{
													Common.smethod_62(0.5);
													continue;
												}
												bool_9 = true;
												break;
											}
											while (!bool_0);
										}
										else if (int_18 > 0)
										{
											int num8 = random_0.Next(int_3, int_4);
											if (num8 > 0)
											{
												int tickCount = Environment.TickCount;
												while ((Environment.TickCount - tickCount) / 1000 - num8 < 0)
												{
													method_62(int_41, text3 + "Mở thiê\u0301t bi\u0323 sau {time}s...".Replace("{time}", (num8 - (Environment.TickCount - tickCount) / 1000).ToString()));
													Common.smethod_62(0.5);
													if (!bool_0)
													{
														continue;
													}
													method_62(int_41, text3 + "Dừng chạy...", device);
													goto end_IL_1d06;
												}
											}
										}
										else
										{
											int_18++;
										}
									}
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...");
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									method_62(int_41, text3 + "Mở thiết bị...");
									device.method_118();
									if (device.process == null)
									{
										method_62(int_41, text3 + "Lỗi mở thiết bị");
										method_49("Lỗi mở LD", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									text8 = device.method_114();
									frmViewLD.frmViewLD_0.method_9(device.process.MainWindowHandle, device.int_0, int_41 + 1, text8);
									if (!device.method_11())
									{
										method_62(int_41, text3 + "Lỗi mở thiết bị");
										method_49("Lỗi mở LD", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									method_62(int_41, text3 + "Mở thiết bị thành công", device);
									list_4.Add(device);
									method_51(5.0);
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									text = (device.DeviceId = Class2.smethod_36(device.int_0));
									device.list_0 = device.method_108();
									bool flag10 = true;
									try
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										method_62(int_41, text3 + "Kiểm tra App cần cài đặt", device);
										if (Settings.Default.typeRunApp == 0)
										{
											if (device.list_0.Contains("com.facebook.katana"))
											{
												goto IL_2311;
											}
											method_62(int_41, text3 + "Cài đặt App Facebook Katana...", device);
											while (true)
											{
												if (!bool_0)
												{
													flag10 = false;
													if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\facebook.apk")))
													{
														continue;
													}
													goto IL_2311;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											break;
										}
                                        if (device.list_0.Contains("com.facebook.lite"))
                                        {
                                            goto IL_2413;
                                        }
                                        method_62(int_41, text3 + "Cài đặt App Facebook Lite...", device);
										while (true)
										{
											if (!bool_0)
											{
												flag10 = false;
												if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\facebooklite.apk"))) //3416 cai fb lite 
												{
													continue;
												}
												goto IL_2413;
											}
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										goto end_IL_2237;
									IL_2311:
										if (!device.list_0.Contains("com.android.adbkeyboard"))
										{
											method_62(int_41, text3 + "Cài đặt App Keyboard...", device);
											while (true)
											{
												if (!bool_0)
												{
													flag10 = false;
													if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\ADBKeyboard.apk")))
													{
														continue;
													}
													goto IL_24d0;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											break;
										}
										goto IL_24d0;
									IL_2413:
										if (device.list_0.Contains("cz.october.app"))
										{
											goto IL_2491;
										}
										method_62(int_41, text3 + "Cài đặt App Keyboard...", device);
										while (true)
										{
											if (!bool_0)
											{
												flag10 = false;
												if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\keyboard.apk")))
												{
													continue;
												}
												goto IL_2491;
											}
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										goto end_IL_2237;
									IL_2491:
										device.method_46("shell ime set cz.october.app/.KeyboardReceiver");
										goto IL_24d0;
									end_IL_2237:;
									}
									catch
									{
										method_62(int_41, text3 + "Cài đặt các ứng dụng không thành công", device);
										method_49("Cài đặt các ứng dụng không thành công", device.int_0, int_41, int_42, device, bool_18: false);
									}
									goto end_IL_1d06;
								IL_2876:
									if (text10 != "")
									{
										method_62(int_41, text3 + "Lỗi treo LD khi kết nối proxy");
										method_49("Lỗi treo LD khi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (Settings.Default.typeRunApp == 0)
									{
										while (true)
										{
										IL_909d:
											method_62(int_41, text3 + "Mở App Facebook Katana", device);
											device.method_39();
											try
											{
												if (bool_0)
												{
													method_62(int_41, text3 + "Dừng chạy...", device);
													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												if (device.method_95())
												{
													string text13 = string.Empty;
													bool flag11 = true;
													if (!rdThuePhone.Checked || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "2")
													{
													}
													method_62(int_41, text3 + "Đăng ký Facebook Katana", device);
													for (int i = 0; i < 20; i++)
													{
														if (device.method_91(158, 377))
														{
															flag11 = true;
															break;
														}
													}
													if (!flag11)
													{
														method_62(int_41, text3 + "Lỗi khi đăng ký", device);
														method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...");
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													int num9 = 0;
													while (true)
													{
														if (num9 < 30)
														{
															text13 = device.method_93();
															if (device.method_120(text13).Count == 1)
															{
																num9++;
																continue;
															}
															if (device.method_82("join facebook", text13) || device.method_82("tham gia facebook", text13))
															{
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																flag11 = true;
																if (device.method_82("\"next\"", text13))
																{
																	device.method_99("\"next\"");
																}
																else
																{
																	device.method_99("\"tiếp\"");
																}
															}
															else
															{
																flag11 = false;
															}
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Tạo thông tin đăng ký", device);
														string text14 = "";
														string text15 = "";
														string text16 = "";
														string text17 = "";
														string text18 = "";
														string text19 = "";
														string text20 = "";
														string text21 = "";
														string text22 = "";
														string text23 = "";
														string text24 = "";
														string text25 = "";
														string text26 = "";
														string[] array = new string[11]
														{
													"thg 1", "thg 2", "thg 3", "thg 4", "thg 5", "thg 6", "thg 7", "thg 8", "thg 10", "thg 11",
													"thg 12"
														};
														string text27 = random_0.Next(0, 2).ToString();
														string text28 = "";
														string text29 = "";
														if (int_13 == 0)
														{
															text27 = "0";
														}
														else if (int_13 == 1)
														{
															text27 = "1";
														}
														if (int_12 == 0)
														{
															text14 = method_6();
                                                            text15 = ((!(text27 == "0")) ? method_7() : method_8());
                                                        }
														else if (int_12 == 1)
														{
															text14 = method_3();
                                                            text15 = ((!(text27 == "0")) ? method_5() : method_4());
                                                        }
														else if (int_12 == 2)
														{
															text14 = method_9();
															text15 = ((!(text27 == "0")) ? method_10() : method_11());
															text28 = method_3();
															text29 = ((!(text27 == "0")) ? method_5() : method_4());
														}
														text16 = ((int_12 == 2) ? ((!bool_5) ? string_14.Trim() : Common.smethod_75(text29 + text28)) : ((!bool_5) ? string_14.Trim() : Common.smethod_75(text15 + text14)));
														text24 = random_0.Next(1, 28).ToString();
														text25 = array[random_0.Next(0, 11)].ToString();
														text26 = random_0.Next(Convert.ToInt32(DateTime.Now.Year.ToString()) - int_16, Convert.ToInt32(DateTime.Now.Year.ToString()) - int_15).ToString();
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_52(text14, "ho", int_41, 0, dgvAcc);
														method_52(text15, "ten", int_41, 0, dgvAcc);
														method_52((text27 == "1") ? "Nam" : "Nữ", "gender", int_41, 0, dgvAcc);
														method_52(text16, "pass", int_41, 0, dgvAcc);
														method_52((Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(text26)).ToString(), "age", int_41, 0, dgvAcc);
														text17 = string_11;
														if (bool_16)
														{
															text17 = string_20;
														}
														try
														{
															for (int j = 0; j < 5; j++)
															{
																if (!bool_0)
																{
																	text13 = device.method_93();
																	if (device.method_120(text13).Count == 1)
																	{
																		continue;
																	}
																	if (device.method_82("enter the name you use in real life.", text13) || device.method_82("nhập tên bạn sử dụng trong đời thực", text13))
																	{
																		flag11 = true;
																		if (device.method_82("nhập tên bạn sử dụng trong đời thực", text13))
																		{
																			method_62(int_41, text3 + "Nhập họ", device);
																			device.method_100(text14);
																			device.method_121(1.0);
																			method_62(int_41, text3 + "Nhập tên...", device);
																			device.method_121(1.0);
																			if (device.method_82("\"last name\"", text13))
																			{
																				device.method_99("\"last name\"", text13);
																			}
																			else if (device.method_52("DataClick\\image\\ten"))
																			{
																				device.method_3("DataClick\\image\\ten");
																			}
																			else
																			{
																				ADBHelper.TapByPercent(text, 59.5, 42.9);
																			}
																			device.method_121(1.0);
																			device.method_100(text15);
																			break;
																		}
																		method_62(int_41, text3 + "Nhập tên", device);
																		device.method_121(1.0);
																		device.method_100(text15);
																		device.method_121(1.0);
																		method_62(int_41, text3 + "Nhập họ...", device);
																		device.method_121(1.0);
																		if (device.method_82("\"last name\"", text13))
																		{
																			device.method_99("\"last name\"", text13);
																		}
																		else if (device.method_52("DataClick\\image\\ten"))
																		{
																			device.method_3("DataClick\\image\\ten");
																		}
																		else
																		{
																			ADBHelper.TapByPercent(text, 59.5, 42.9);
																		}
																		device.method_121(1.0);
																		device.method_100(text14);
																	}
																	else
																	{
																		flag11 = false;
																	}
																	break;
																}
																method_62(int_41, text3 + "Dừng chạy...");
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_2a36;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														device.method_121(1.0);
														if (device.method_82("\"next\""))
														{
															device.method_99("\"next\"");
														}
														else
														{
															device.method_99("\"tiếp\"");
														}
														try
														{
															method_62(int_41, text3 + "Chọn ngày tháng năm sinh...", device);
															int num10 = 0;
															while (true)
															{
																if (num10 < 10)
																{
																	text13 = device.method_93();
                                                                    //if (!device.method_82("sinh nhật của bạn khi nào?", text13))
                                                                    //{
                                                                    //    flag11 = false;
                                                                    //    num10++;
                                                                    //    continue;
                                                                    //}
                                                                    //if (bool_0)
                                                                    //{
                                                                    //    method_62(int_41, text3 + "Dừng chạy...");
                                                                    //    method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
                                                                    //    break;
                                                                    //}
                                                                    flag11 = true;
																	if (device.method_82("\"select birthday\"", text13))
																	{
																		device.method_99("\"select birthday\"", text13);
																	}
																	else if (device.method_82("\"chọn ngày sinh\"", text13))
																	{
																		device.method_99("\"chọn ngày sinh\"", text13);
																	}
																	else
																	{
																		ADBHelper.TapByPercent(text, 49.8, 41.0);
																	}
																	device.method_121(1.0);
																}
																if (flag11)
																{
																	device.method_91(108, 247); // Ngay
																	device.method_100(text24);
																	device.method_121(1.0);
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		break;
																	}
																	device.method_7(156, 246); // Thang
																	device.method_100(text25);
																	device.method_121(1.0);
																	device.method_91(206, 247);// Nam
																	device.method_100(text26);
																	device.method_121(1.0);
																	device.method_99("\"ok\"", "", 10);
																	device.method_121(1.0);
																	if (device.method_82("\"next\"", text13))
																	{
																		device.method_99("\"next\"", "", 10);
																	}
																	else
																	{
																		device.method_99("\"tiếp\"", "", 10);
																	}
																	flag11 = true;
																}
																goto IL_3513;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														}
														break;
													IL_3513:
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														try
														{
															for (int k = 0; k < 10; k++)
															{
																text13 = device.method_93();
																if (device.method_120(text13).Count == 1)
																{
																	continue;
																}
																if (device.method_82("what's your gender?", text13) || device.method_82("giới tính của bạn là gì?", text13))
																{
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_2a36;
																	}
																	method_62(int_41, text3 + "Chọn giới tính...", device);
																	if (text27 == "0")
																	{
																		device.method_91(38, 183);
																	}
																	else if (text27 == "1")
																	{
																		device.method_91(30, 223);
																	}
																	flag11 = true;
																	device.method_121(1.0);
																	if (device.method_82("\"next\"", text13))
																	{
																		device.method_99("\"next\"", "", 10);
																	}
																	else
																	{
																		device.method_99("\"tiếp\"", "", 10);
																	}
																}
																else
																{
																	flag11 = false;
																}
																break;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															flag11 = false;
															break;
														}
														while (true)
														{
														IL_3756:
															Mailtm mailtm = new Mailtm();
															try
															{
																for (int l = 0; l < 10; l++)
																{
																	text13 = device.method_93();
																	if (device.method_120(text13).Count == 1)
																	{
																		continue;
																	}
																	if (!device.method_82("enter your mobile number", text13) && !device.method_82("nhập số di động của bạn", text13) && !device.method_82("nhập địa chỉ email của bạn", text13))
																	{
																		flag11 = false;
																		continue;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...");
																		flag11 = false;
																		break;
																	}


																	if (num4 == 0)
																	{
																		if (device.method_82("\"đăng ký bằng địa chỉ email\"", "", 10.0))
																		{
																			device.method_99("\"đăng ký bằng địa chỉ email\"", "", 10);
																		}
																		else if (device.method_82("\"sign up with email address\"", "", 10.0))
																		{
																			device.method_99("\"sign up with email address\"", "", 10);
																		}
																	}
																	if ((rdConfMail.Checked && rdTempMailIO.Checked))
																	{
																		int num12 = 0;
																		method_62(int_41, text3 + "Đang lấy TempMail...", device);
																		while (true)
																		{
																			string text32 = method_73(); // Mail tm k co reg sdt
																			string text33 = Common.smethod_19(text32);
																			if (!(text33 != ""))
																			{
																				if (num12 != 5)
																				{
																					num12++;
																					continue;
																				}
																				method_62(int_41, text3 + "Lỗi không lấy được TempMail...", device);
																				flag11 = false;
																				//goto end_IL_37d2;
																				break;
																			}
																			method_52(text33, "email", int_41, 0, dgvAcc);
																			flag2 = true;
																			device.method_100(text33);
																			device.method_121(1.0);
																			goto IL_4cf7;
																		}
																	}

																	else if(rdConfMail.Checked && rdMailTM.Checked) //mailtm
																	{
																		int num12 = 0;
																		
																		method_62(int_41, text3 + "Đang lấy Mailtm...", device);
																		while (true)
																		{
																			string getdomains = mailtm.getdomains(); // Get duoi @ gigi day . mail dang ki
																			string account_mailtm = Getrandomemail() + "@" + getdomains;
																			string pass_mailtm = Getrandompassmailtm();
                                                                            if (mailtm.Create_Mailtm(account_mailtm, pass_mailtm, string_21))
                                                                            {
																				break;
                                                                            }
                                                                            string text33 = account_mailtm;
                                                                            if (!(text33 != "" && text33 != null))
                                                                            {
                                                                                break;
                                                                            }
                                                                            if (!(text33 != ""))
																			{
																				if (num12 != 5)
																				{
																					num12++;
																					continue;
																				}
																				method_62(int_41, text3 + "Lỗi không lấy được Mailtm...", device);
																				flag11 = false;
																				//goto end_IL_37d2;
																				break;
																			}
																			method_52(text33, "email", int_41, 0, dgvAcc);
																			flag2 = true;
																			device.method_100(text33);
																			device.method_121(1.0);
																			goto IL_4cf7;
																		}
																	}
                                                                    else
                                                                    {
																		break;
                                                                    }
																}
															}
															catch
															{
																method_62(int_41, text3 + "Tạo tài khoản thất bại", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															if (!flag11)
															{
																method_62(int_41, text3 + "Tạo tài khoản thất bại", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															goto IL_4cf7;
														IL_4cf7:
															if (!bool_0)
															{
																if (device.method_82("\"next\""))
																{
																	device.method_99("\"next\"", "", 10);
																}
																else
																{
																	device.method_99("\"tiếp\"", "", 10);
																}
																try
																{
																	for (int m = 0; m < 5; m++)
																	{
																		text13 = device.method_93();
																		if (device.method_120(text13).Count == 1)
																		{
																			continue;
																		}
																		if (device.method_82("choose a password", text13) || device.method_82("chọn mật khẩu", text13))
																		{
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_3756;
																			}
																			flag11 = true;
																			method_62(int_41, text3 + "Nhập mật khẩu...", device);
																			device.method_102(text16.Trim());
																			device.method_121(1.0);
																			if (device.method_82("\"next\""))
																			{
																				device.method_99("\"next\"", "", 10);
																			}
																			else
																			{
																				device.method_99("\"tiếp\"", "", 10);
																			}
																		}
																		else
																		{
																			flag11 = false;
																		}
																		break;
																	}
																}
																catch
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																if (flag11)
																{
																	if (!bool_0)
																	{
																		int num13 = 0;
																		while (true)
																		{
																			if (num13 < 5)
																			{
																				text13 = device.method_93();
																				if (device.method_120(text13).Count == 1)
																				{
																					num13++;
																					continue;
																				}
																				if (device.method_82("finish signing up", text13) || device.method_82("hoàn tất đăng ký", text13))
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					flag11 = true;
																					method_62(int_41, text3 + "Đăng ký...", device);
																					device.method_121(2.0);
																					if (device.method_82("\"sign up\""))
																					{
																						device.method_99("\"sign up\"");
																					}
																					else
																					{
																						device.method_99("\"đăng ký\"");
																					}
																				}
																				else
																				{
																					flag11 = false;
																				}
																			}
																			if (flag11)
																			{
																				if (!bool_0)
																				{
																					break;
																				}
																				method_62(int_41, text3 + "Dừng chạy...");
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			else
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			goto end_IL_3756;
																		}
																		goto IL_4ccc;
																	}
																	method_62(int_41, text3 + "Dừng chạy...");
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														IL_4ccc:
															while (true)
															{
															IL_4ccc_2:
																device.method_121(1.0);
																method_62(int_41, text3 + "Check status đăng ký...", device);
																int num14 = 0;
																try
																{
																	while (true)
																	{
																		if (!bool_0)
																		{
																			if (num14 != 30)
																			{
																				num14++;
																				text13 = device.method_93();
																				if (device.method_120(text13).Count == 1)
																				{
																					continue;
																				}
																				if (!bool_0)
																				{
																					if (rdConfMail.Checked && rdTempMailIO.Checked) {
																						if (device.method_82("bạn đã có tài khoản facebook chưa?", text13) || device.method_82("do you already have a facebook account?", text13))
																						{
																							if (device.method_82("no, create new account", text13))
																							{
																								device.method_99("no, create new account", "", 10);
																							}
																							else
																							{
																								device.method_99("không, tạo tài khoản mới", "", 10);
																							}
																							goto IL_4ccc_2;
																						}
																						if (device.method_82("use a different name", text13) || device.method_82("chọn tên của bạn", text13) || device.method_82("bạn tên gì?", text13))
																						{
																							flag11 = false;
																							method_62(int_41, text3 + "Trùng tên...Chọn tên khác", device); //Sửa sau tenpmail 
																							if (device.method_52("DataClick\\image\\tenkhac"))
																							{
																								device.method_3("DataClick\\image\\tenkhac");
																							}
																							else
																							{
																								device.method_91(299, 232); // Click vao vi tri xuat hien tren man hinh
																							}
																							//if (device.method_82("\"next\""))
																							//{
																							//	device.method_99("\"next\"", "", 10);
																							//}
																							//else
																							//{
																							//	device.method_99("\"tiếp\"", "", 10);
																							//}
																							if (device.method_52("DataClick\\image\\next"))
																							{
																								device.method_3("DataClick\\image\\next");
																							}
																							else
																							{
																								device.method_91(161, 315); // Click vao vi tri xuat hien tren man hinh
																							}
																							//device.method_70();
																							device.method_121(1.0);
																							goto IL_4ccc_2;
																							//goto end_IL_4ccc;
																						}
																						if (!device.method_82("next time, log in with one tap", text13) && !device.method_82("lần sau, đăng nhập bằng một lần nhấn", text13))
																						{

																							if (!device.method_82("do you already have a facebook account?", text13) && !device.method_82("bạn đã có tài khoản facebook chưa?", text13))
																							{
																								if (!device.method_82("the action attempted has been deemed abusive or is otherwise disallowed", text13) && !device.method_82("an unknown error occurred", text13) && !device.method_82("we couldn't create your account", text13) && !device.method_82("chúng tôi không thể tạo tài khoản của bạn", text13) && !device.method_82("một lỗi không xác định đã xảy ra", text13) && !device.method_82("hành động đã cố gắng bị coi là lạm dụng hoặc không được phép", text13) && !device.method_82("gần đây số điện thoại bạn đang cố gắng xác minh đã được sử dụng để xác minh một tài khoản khác. Vui lòng thử số khác.", text13))
																								{
																									if (device.method_82("we need more information", text13) || device.method_82("Something went wrong. Please try again.", text13) || device.method_82("chúng tôi cần thêm thông tin", text13))
																									{
																										if (Settings.Default.isThuVeriCheckPoint)
																										{
																											method_62(int_41, text3 + "Checkpoint...thử xác nhận", device);
																											flag3 = true;
																											goto IL_4e67;
																										}
																										method_62(int_41, text3 + "Checkpoint 282. Lưu acc...", device);
																										flag5 = true;
																										method_42(int_41, "Checkpoint");
																										goto IL_738b;
																									}
																									if (!device.method_82("there was an issue with your connection. check the following and try again.", text13) && !device.method_82("đã xảy ra lỗi", text13) && !device.method_82("đã xảy ra sự cố với kết nối của bạn. hãy kiểm tra những vấn đề sau và thử lại:", text13))
																									{
																										if (!device.method_52("DataClick\\image\\siginfail"))
																										{
																											if (!device.method_82("vui lòng nhập địa chỉ email hợp lệ.", text13))
																											{
																												if (device.method_82("tên hoặc họ trên facebook không được quá ngắn", text13))
																												{
																													flag11 = false;
																													method_62(int_41, text3 + "Lỗi khi đăng ký. Thực hiện đăng ký lại", device);
																													device.method_70();
																													device.method_121(1.0);
																													goto end_IL_4ccc;
																												}
																												if (!device.method_82("mất kết nối", text13))
																												{
																													continue;
																												}
																												flag11 = false;
																												method_62(int_41, text3 + "Lỗi mất kết nối", device);
																											}
																											else
																											{
																												if (num4 != 5)
																												{
																													method_62(int_41, text3 + "Lấy mail khác...lần " + (num4 + 1), device);
																													device.method_121(1.0);
																													if (device.method_52("DataClick\\image\\x"))
																													{
																														device.method_3("DataClick\\image\\x");
																													}
																													else
																													{
																														device.method_91(295, 209);
																													}
																													num4++;
																													goto IL_3756;
																												}
																												method_62(int_41, text3 + "Lỗi email không hợp lệ", device);
																												flag11 = false;
																											}
																										}
																										else
																										{
																											flag11 = false;
																											method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																										}
																									}
																									else
																									{
																										flag11 = false;
																										method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																									}
																								}
																								else if (bool_0)
																								{
																									method_62(int_41, text3 + "Dừng chạy...");
																									flag11 = false;
																								}
																								else
																								{
																									flag11 = false;
																									method_62(int_41, text3 + "Lỗi khi đăng ký. Thử lại sau", device);
																								}
																							}
																							else
																							{
																								if (!bool_0)
																								{
																									if (device.method_82("không, tạo tài khoản mới", text13))
																									{
																										device.method_99("không, tạo tài khoản mới", text13, 10);
																									}
																									else if (device.method_82("no, create new account", text13))
																									{
																										device.method_99("no, create new account", text13, 10);
																									}
																									goto IL_4ccc_2;
																								}
																								method_62(int_41, text3 + "Dừng chạy...", device);
																								flag11 = false;
																							}
																						}
																						else
																						{
																							flag11 = true;
																							method_62(int_41, text3 + "Đăng ký thành công...", device);
																							if (device.method_82("\"not now\"", text13))
																							{
																								device.method_99("\"not now\"", "", 10);
																							}
																							else
																							{
																								device.method_99("\"lúc khác\"", "", 10);
																							}
																						}
																					}
                                                                                    else if(rdConfMail.Checked && rdMailTM.Checked)
                                                                                    {
																						if (device.method_82("bạn đã có tài khoản facebook chưa?", text13) || device.method_82("do you already have a facebook account?", text13))
																						{
																							if (device.method_82("no, create new account", text13))
																							{
																								device.method_99("no, create new account", "", 10);
																							}
																							else
																							{
																								device.method_99("không, tạo tài khoản mới", "", 10);
																							}
																							goto IL_4ccc_2;
																						}
																						if (device.method_82("use a different name", text13) || device.method_82("chọn tên của bạn", text13) || device.method_82("bạn tên gì?", text13))
																						{
																							flag11 = false;
																							method_62(int_41, text3 + "Trùng tên...Chọn tên khác", device); //Sửa sau mailtm
																							if (device.method_52("DataClick\\image\\tenkhac"))
																							{
																								device.method_3("DataClick\\image\\tenkhac");
																							}
																							else
																							{
																								device.method_91(299, 232); // Click vao vi tri xuat hien tren man hinh
																							}
																							//if (device.method_82("\"next\""))
																							//{
																							//	device.method_99("\"next\"", "", 10);
																							//}
																							//else
																							//{
																							//	device.method_99("\"tiếp\"", "", 10);
																							//}
																							if (device.method_52("DataClick\\image\\next"))
																							{
																								device.method_3("DataClick\\image\\next");
																							}
																							else
																							{
																								device.method_91(161, 315); // Click vao vi tri xuat hien tren man hinh
																							}
																							//device.method_70();
																							device.method_121(1.0);
																							goto IL_4ccc_2;
																							//goto end_IL_4ccc;
																						}
																						if (!device.method_82("next time, log in with one tap", text13) && !device.method_82("lần sau, đăng nhập bằng một lần nhấn", text13))
																						{

																							if (!device.method_82("do you already have a facebook account?", text13) && !device.method_82("bạn đã có tài khoản facebook chưa?", text13))
																							{
																								if (!device.method_82("the action attempted has been deemed abusive or is otherwise disallowed", text13) && !device.method_82("an unknown error occurred", text13) && !device.method_82("we couldn't create your account", text13) && !device.method_82("chúng tôi không thể tạo tài khoản của bạn", text13) && !device.method_82("một lỗi không xác định đã xảy ra", text13) && !device.method_82("hành động đã cố gắng bị coi là lạm dụng hoặc không được phép", text13) && !device.method_82("gần đây số điện thoại bạn đang cố gắng xác minh đã được sử dụng để xác minh một tài khoản khác. Vui lòng thử số khác.", text13))
																								{
																									if (device.method_82("we need more information", text13) || device.method_82("Something went wrong. Please try again.", text13) || device.method_82("chúng tôi cần thêm thông tin", text13))
																									{
																										if (Settings.Default.isThuVeriCheckPoint)
																										{
																											method_62(int_41, text3 + "Checkpoint...thử xác nhận", device);
																											flag3 = true;
																											goto IL_4e67;
																										}
																										method_62(int_41, text3 + "Checkpoint 282. Lưu acc...", device);
																										flag5 = true;
																										method_42(int_41, "Checkpoint");
																										goto IL_738b;
																									}
																									if (!device.method_82("there was an issue with your connection. check the following and try again.", text13) && !device.method_82("đã xảy ra lỗi", text13) && !device.method_82("đã xảy ra sự cố với kết nối của bạn. hãy kiểm tra những vấn đề sau và thử lại:", text13))
																									{
																										if (!device.method_52("DataClick\\image\\siginfail"))
																										{
																											if (!device.method_82("vui lòng nhập địa chỉ email hợp lệ.", text13))
																											{
																												if (device.method_82("tên hoặc họ trên facebook không được quá ngắn", text13))
																												{
																													flag11 = false;
																													method_62(int_41, text3 + "Lỗi khi đăng ký. Thực hiện đăng ký lại", device);
																													device.method_70();
																													device.method_121(1.0);
																													goto end_IL_4ccc;
																												}
																												if (!device.method_82("mất kết nối", text13))
																												{
																													continue;
																												}
																												flag11 = false;
																												method_62(int_41, text3 + "Lỗi mất kết nối", device);
																											}
																											else
																											{
																												if (num4 != 5)
																												{
																													method_62(int_41, text3 + "Lấy mail khác...lần " + (num4 + 1), device);
																													device.method_121(1.0);
																													if (device.method_52("DataClick\\image\\x"))
																													{
																														device.method_3("DataClick\\image\\x");
																													}
																													else
																													{
																														device.method_91(295, 209);
																													}
																													num4++;
																													goto IL_3756;
																												}
																												method_62(int_41, text3 + "Lỗi email không hợp lệ", device);
																												flag11 = false;
																											}
																										}
																										else
																										{
																											flag11 = false;
																											method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																										}
																									}
																									else
																									{
																										flag11 = false;
																										method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																									}
																								}
																								else if (bool_0)
																								{
																									method_62(int_41, text3 + "Dừng chạy...");
																									flag11 = false;
																								}
																								else
																								{
																									flag11 = false;
																									method_62(int_41, text3 + "Lỗi khi đăng ký. Thử lại sau", device);
																								}
																							}
																							else
																							{
																								if (!bool_0)
																								{
																									if (device.method_82("không, tạo tài khoản mới", text13))
																									{
																										device.method_99("không, tạo tài khoản mới", text13, 10);
																									}
																									else if (device.method_82("no, create new account", text13))
																									{
																										device.method_99("no, create new account", text13, 10);
																									}
																									goto IL_4ccc_2;
																								}
																								method_62(int_41, text3 + "Dừng chạy...", device);
																								flag11 = false;
																							}
																						}
																						else
																						{
																							flag11 = true;
																							method_62(int_41, text3 + "Đăng ký thành công...", device);
																							if (device.method_82("\"not now\"", text13))
																							{
																								device.method_99("\"not now\"", "", 10);
																							}
																							else
																							{
																								device.method_99("\"lúc khác\"", "", 10);
																							}
																						}
																					}
                                                                                    else
                                                                                    {
																						break;
                                                                                    }
																					
																				}
																				else
																				{
																					method_62(int_41, text3 + "Dừng chạy...");
																					flag11 = false;
																				}
																				goto IL_4dbc;
																			}
																			method_62(int_41, text3 + "Không check được status...");
																			method_49("Không check được status đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		break;
																	}
																}
																catch (Exception exception_)
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	Common.smethod_82(exception_, "Check_status_dangky");
																}
																goto end_IL_3756;
															IL_4dbc:
																if (!flag11)
																{
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																method_62(int_41, text3 + "Lưu mật khẩu và Email...", device);
																device.method_121(1.0);
																if (device.method_52("DataClick\\image\\ok1"))
																{
																	device.method_3("DataClick\\image\\ok1");
																}
																else
																{
																	device.method_91(160, 356);
																}
																goto IL_4e67;
															IL_738b:
																device.method_121(1.0);
																string text35 = device.method_13();
																text19 = Regex.Match(text35.Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
																if (text19.Trim() != "")
																{
																	method_52(text19, "uid", int_41, 0, dgvAcc);
																}
																text20 = text35.Split('|')[0];
																text21 = text35.Split('|')[1];
																method_52(text20, "token", int_41, 0, dgvAcc);
																method_52(text21, "cookie", int_41, 0, dgvAcc);
																if (!flag5)
																{
																	if (!flag11)
																	{
																		method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																		method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	method_62(int_41, text3 + "Chuyển đổi ngôn ngữ về English...", device);
																	device.method_122();
																	int n = 0;
																	device.method_121(1.0);
																	for (; n < 10; n++)
																	{
																		string text36 = device.method_93();
																		if (!device.method_99("english", text36))
																		{
																			device.method_121(1.0);
																			continue;
																		}
																		flag11 = true;
																		break;
																	}
																	if (flag11)
																	{
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		device.method_121(5.0);
																		if (Settings.Default.isAddMailReg && flag2)
																		{
																			string text37 = queue_1.Dequeue();
																			method_62(int_41, text3 + "Thêm mail sau khi reg...", device);
																			device.method_128();
																			device.method_121(10.0);
																			if (device.method_52("DataClick\\image\\addmailreg", null, 1))
																			{
																				device.method_3("DataClick\\image\\addmailreg", null, 1);
																			}
																			device.method_121(5.0);
																			if (device.method_52("DataClick\\image\\input", null, 1))
																			{
																				device.method_3("DataClick\\image\\input", null, 1);
																			}
																			device.method_121(2.0);
																			device.method_100(text37);
																			device.method_121(1.0);
																			if (device.method_52("DataClick\\image\\addmail", null, 1))
																			{
																				device.method_3("DataClick\\image\\addmail", null, 1);
																			}
																			device.method_121(5.0);
																		}
																		try
																		{
																			if (bool_3)
																			{
																				try
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					method_62(int_41, text3 + "Up avatar...", device);
																					int num15 = 1;
																					int num16 = 0;
																					string text38 = "";
																					int num17 = 0;
																					while (true)
																					{
																						if (bool_0)
																						{
																							method_62(int_41, text3 + "Dừng chạy...", device);
																							method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																							break;
																						}
																						if (num17 != 5)
																						{
																							device.method_12();
																							if (flag2 || !device.method_52("DataClick\\image\\checkpoint"))
																							{
																								text38 = device.method_93();
																								num17++;
																								switch (method_44(device, int_41, ""))
																								{
																									case 0:
																										method_62(int_41, text3 + "Up lại avatar...", device);
																										continue;
																									case 2:
																										continue;
																									case 3:
																										goto end_IL_7690;
																								}
																								bool flag12 = device.method_99("profile picture", "", 10);
																								while (flag12)
																								{
																									if (!bool_0)
																									{
																										num15++;
																										int num18 = num15;
																										int num19 = num18;
																										if (num19 == 1 || num19 != 2)
																										{
																											break;
																										}
																										flag12 = false;
																										device.method_85("shell rm /sdcard/*.png");
																										device.method_85("shell am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard/Pictures");
																										device.method_121(1.0);
																										if (!device.method_99("select profile picture", "", 5))
																										{
																											continue;
																										}
																										int num20 = 0;
																										while (true)
																										{
																											if (num20 < 5)
																											{
																												if (bool_0)
																												{
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												text38 = device.method_93();
																												switch (device.method_84(text38, 0.0, "\"allow\"", "\"enable gallery access", "\"want to upload your photos", "\"photo\""))
																												{
																													case 1:
																														device.method_99("\"allow\"", text38);
																														goto IL_7902;
																													case 2:
																														device.method_99("\"enable gallery access", text38);
																														goto IL_7902;
																													case 3:
																														device.method_99("\"want to upload your photos", text38);
																														device.method_121(2.0);
																														device.method_74();
																														goto IL_7902;
																													default:
																														goto IL_7902;
																													case 4:
																														break;
																												}
																											}
																											List<string> list = device.method_76("\"photo\"", text38);
																											if (list.Count >= 10)
																											{
																												int num21 = random_0.Next(0, 10);
																												int num22 = 0;
																												while (true)
																												{
																													if (num22 < num21 && !device.method_81(1000, 1, "[125,444][179,465]", "[146,313][223,348]", "[124,359][196,423]"))
																													{
																														if (!bool_0)
																														{
																															device.method_121(1.0);
																															num22++;
																															continue;
																														}
																														method_62(int_41, text3 + "Dừng chạy...", device);
																														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																														break;
																													}
																													text38 = device.method_93();
																													goto IL_79b3;
																												}
																												break;
																											}
																											goto IL_79b3;
																										IL_7902:
																											device.method_121(1.0);
																											num20++;
																											continue;
																										IL_79b3:
																											string value = (from string_0 in device.method_76("\"photo\"", text38)
																															orderby Guid.NewGuid()
																															select string_0).FirstOrDefault();
																											if (!string.IsNullOrEmpty(value))
																											{
																												device.method_89(value);
																												device.method_121(1.0);
																												flag12 = device.method_99("\"save\"", "", 10);
																												flag11 = true;
																											}
																											goto IL_7a2c;
																										}
																										goto end_IL_776e;
																									}
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									goto end_IL_776e;
																								IL_7a2c:;
																								}
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Không up được avartar...", device);
																						}
																						goto end_IL_7690;
																						continue;
																					end_IL_776e:
																						break;
																					}
																				}
																				catch
																				{
																					goto IL_8211;
																				}
																				goto end_IL_3756;
																			}
																		end_IL_7690:;
																		}
																		catch (Exception)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (!flag11)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (bool_4)
																		{
																			try
																			{
																				device.method_115(string_19);
																				method_62(int_41, text3 + "Up cover photo...", device);
																				bool flag13 = false;
																				string text39 = "";
																				int num23 = 1;
																				int num24 = 0;
																				while (true)
																				{
																					if (!bool_0)
																					{
																						if (num24 != 5)
																						{
																							device.method_12();
																							if (flag2 || !device.method_52("DataClick\\image\\checkpoint"))
																							{
																								text39 = device.method_93();
																								num24++;
																								switch (method_44(device, int_41, text3))
																								{
																									case 0:
																										method_62(int_41, text3 + "Up lại cover photo...", device);
																										continue;
																									case 2:
																										continue;
																									case 3:
																										goto IL_7fe5;
																								}
																								string text40 = device.method_97("profile picture", "", 10);
																								if (text40 != "")
																								{
																									string[] array2 = text40.Split('[', ',', ']');
																									device.method_91(Convert.ToInt32(array2[1]) - 10, Convert.ToInt32(array2[2]) - 10);
																									flag13 = true;
																								}
																								while (flag13)
																								{
																									if (!bool_0)
																									{
																										num23++;
																										switch (num23)
																										{
																											case 2:
																												{
																													flag13 = false;
																													device.method_85("shell rm /sdcard.png");
																													device.method_85("shell am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard/Pictures");
																													device.method_121(1.0);
																													if (!device.method_99("upload photo", "", 5))
																													{
																														continue;
																													}
																													int num25 = 0;
																													while (true)
																													{
																														if (num25 < 5)
																														{
																															if (bool_0)
																															{
																																method_62(int_41, text3 + "Dừng chạy...", device);
																																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																																goto end_IL_7c2c;
																															}
																															text39 = device.method_93();
																															switch (device.method_84(text39, 0.0, "\"allow\"", "\"enable gallery access", "\"want to upload your photos", "\"photo\""))
																															{
																																case 1:
																																	device.method_99("\"allow\"", text39);
																																	goto IL_7e16;
																																case 2:
																																	device.method_99("\"enable gallery access", text39);
																																	goto IL_7e16;
																																case 3:
																																	device.method_99("\"want to upload your photos", text39);
																																	device.method_121(2.0);
																																	device.method_74();
																																	goto IL_7e16;
																																default:
																																	goto IL_7e16;
																																case 4:
																																	break;
																															}
																														}
																														List<string> list2 = device.method_76("\"photo\"", text39);
																														if (list2.Count >= 24)
																														{
																															int num26 = random_0.Next(0, 5);
																															for (int num27 = 0; num27 < num26; num27++)
																															{
																																if (device.method_81(1000, 1, "[125,444][179,465]", "[146,313][223,348]", "[124,359][196,423]"))
																																{
																																	break;
																																}
																																device.method_121(1.0);
																															}
																															text39 = device.method_93();
																														}
																														string value2 = (from string_0 in device.method_76("\"photo\"", text39)
																																		 orderby Guid.NewGuid()
																																		 select string_0).FirstOrDefault();
																														if (!string.IsNullOrEmpty(value2))
																														{
																															device.method_89(value2);
																															device.method_121(1.0);
																															flag13 = device.method_99("\"save\"", "", 10);
																															flag11 = true;
																														}
																														break;
																													IL_7e16:
																														device.method_121(1.0);
																														num25++;
																													}
																													continue;
																												}
																											case 3:
																												device.method_121(3.0);
																												flag13 = device.method_75(60.0, "uploading your cover photo.");
																												continue;
																										}
																										break;
																									}
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									goto end_IL_7c2c;
																								}
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Không up được cover photo...", device);
																						}
																						goto IL_7fe5;
																					}
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					break;
																					continue;
																				end_IL_7c2c:
																					break;
																				}
																			}
																			catch
																			{
																				goto IL_8211;
																			}
																			goto end_IL_3756;
																		}
																		goto IL_7fe5;
																	}
																	flag11 = false;
																	method_62(int_41, text3 + "Không đổi được ngôn ngữ. Ko thể làm các step tiếp theo", device);
																}
																goto IL_8211;
															IL_4e67:
																string text44;
																if (flag3)
																{
																	device.method_99("\"tiếp tục\"");
																	for (int num28 = 0; num28 < 5; num28++)
																	{
																		text13 = device.method_93();
																		if (device.method_82("giúp chúng tôi xác nhận đó là bạn", text13))
																		{
																			//method_62(int_41, "Captcha...Không xác thực", device);
																			//method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			//method_62(int_41, text3 + "Checkpoint 282. Lưu acc...", device);
																			//flag5 = true;
																			//method_42(int_41, "Checkpoint");
																			//goto IL_738b;
																			method_62(int_41, "Captcha...Dang giai Captcha", device);
																			//if (device.method_52("DataClick\\image\\captchaaudio"))
																			//{
																			//	device.method_3("DataClick\\image\\captchaaudio");
																			//}
																			//device.method_121(10.0);
																			string captcha = "";
																			captcha = CaptchaService.Anycaptcha_Giai_recaptcha(text_api_captcha, "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR");
																			if (captcha != "")
																			{
																				string kytu = "LTD";
																				method_62(int_41, "Giai Captcha thanh cong... Dien ki tu", device);
																				if (device.method_52("DataClick\\image\\captcha"))
																				{
																					device.method_3("DataClick\\image\\captcha");
																				}
																				var imageToTextRequest = new AnyCaptcha().ImageToText(text_api_captcha, "task.type", "COMMON");
																				if (imageToTextRequest.IsSuccess)
																					Console.WriteLine(imageToTextRequest.Result);
																				else
																					Console.WriteLine(imageToTextRequest.Message);
																				method_62(int_41, captcha + "Ky tu captcha:" + kytu, device);
																				//method_52(kytu, "phone", int_41, 0, dgvAcc);
																				device.method_121(1.0);
																				device.method_102(imageToTextRequest.Result); //Send
																				device.method_121(1.0);
																				device.method_99("\"tiếp tục\"");
																			}
																		}
																	}
																	if (string_12.Substring(0, 1) == "0" && !flag2)
																	{
																		if (bool_16)
																		{
																			int num29 = 0;
																			while (true)
																			{
																				if (num29 == 0)
																				{
																					method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																				}
																				else
																				{
																					method_62(int_41, text3 + "Lấy số khác...Lần: " + num29, device);
																					device.method_121(1.0);
																					int tickCount2 = Environment.TickCount;
																					while ((Environment.TickCount - tickCount2) / 1000 - int_39 < 0)
																					{
																						if (!bool_0)
																						{
																							method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount2) / 1000).ToString()), device);
																							continue;
																						}
																						method_62(int_41, "Dừng chạy!", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_52b9;
																					}
																				}
																				text5 = "";
																				if (int_37 == 0)
																				{
																					text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																				}
																				else if (int_37 == 1)
																				{
																					text5 = Common.smethod_57(text17, ref text18);
																					text9 = text5;
																				}
																				else if (int_37 == 2)
																				{
																					text5 = Common.smethod_21(text17, ref text18);
																				}
																				else if (int_37 == 3)
																				{
																					text5 = Common.smethod_48(text17);
																				}
																				else if (int_37 == 4)
																				{
																					text5 = Common.smethod_27(text17, text18);
																				}
																				else if (int_37 == 5)
																				{
																					text5 = Common.smethod_25(text17, text18);
																				}
																				else if (int_37 == 6)
																				{
																					text5 = Common.GetPhoneOtpFb(text17, ref text18);
																				}
																				else if (int_37 == 7)
																				{
																					text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																				}
																				else if (int_37 == 8)
																				{
																					text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																				}
																				else if (int_37 == 9)
																				{
																					text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																				}
																				if (text5 != "")
																				{
																					if (!(text5 == "API sai"))
																					{
																						if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																						{
																							if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 3 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																							{
																								text5 = "+84" + text5; // truoc la +1
																							}
																							if (device.method_52("DataClick\\image\\inputsdtemail"))
																							{
																								device.method_3("DataClick\\image\\inputsdtemail");
																							}
																							else
																							{
																								device.method_99("nhập số điện thoại hoặc email mới");
																							}
																							method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																							method_52(text5, "phone", int_41, 0, dgvAcc);
																							device.method_121(1.0);
																							device.method_102(text5);
																							device.method_121(1.0);
																							if (device.method_52("DataClick\\image\\sendcodeotp"))
																							{
																								device.method_3("DataClick\\image\\sendcodeotp");
																							}
																							else
																							{
																								device.method_99("gửi mã đăng nhập");
																							}
																							bool flag14 = false;
																							for (int num30 = 0; num30 < 5; num30++)
																							{
																								text13 = device.method_93();
																								if (device.method_82("nhập mã mà chúng tôi vừa gửi qua tin nhắn văn bản", text13))
																								{
																									flag14 = true;
																									break;
																								}
																							}
																							if (!flag14)
																							{
																								if (num29 != 5)
																								{
																									device.method_44("nhập số điện thoại hoặc email mới");
																									num29++;
																									continue;
																								}
																								method_62(int_41, text3 + "Hết số điện thoại", device);
																								method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								break;
																							}
																							method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																							string text41 = string.Empty;
																							if (int_37 == 0)
																							{
																								text41 = Common.smethod_26(text17, text18, int_14);
																							}
																							else if (int_37 == 1)
																							{
																								text41 = Common.smethod_28(text17, text9, int_14);
																							}
																							else if (int_37 == 2)
																							{
																								text41 = Common.smethod_27(text17, text18, int_14);
																							}
																							else if (int_37 == 3)
																							{
																								text41 = Common.smethod_45(text17, text18, int_14);
																							}
																							else if (int_37 == 4)
																							{
																								text41 = Common.smethod_46(text17, text18, int_14);
																							}
																							else if (int_37 == 5)
																							{
																								text41 = Common.GetCodeWinMailShop(text17, text18, int_14);
																							}
																							else if (int_37 == 6)
																							{
																								text41 = Common.GetCodeAhasim(text17, text18, int_14);
																							}
																							else if (int_37 == 7)
																							{
																								text41 = Common.GetCodeOtptn(text17, text18, int_14);
																							}
																							else if (int_37 == 8)
																							{
																								text41 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																							}
																							else if (int_37 == 9)
																							{
																								text41 = Common.GetCodeAhasim(text17, text18, int_14);
																							}


																							if (!(text41 != ""))
																							{
																								if (num29 != 5)
																								{
																									if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																									{
																										device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																									}
																									else
																									{
																										device.method_99("cập nhật thông tin liên hệ");
																									}
																									num29++;
																									continue;
																								}
																								method_62(int_41, text3 + "Hết số điện thoại", device);
																								method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																								break;
																							}
																							if (device.method_52("DataClick\\image\\inputotpckp"))
																							{
																								device.method_3("DataClick\\image\\inputotpckp");
																							}
																							else
																							{
																								device.method_91(32, 173);
																							}
																							device.method_121(1.0);
																							device.method_102(text41);
																							device.method_121(1.0);
																							device.method_99("\"tiếp\"");
																							bool flag15 = false;
																							for (int num31 = 0; num31 < 20; num31++)
																							{
																								text13 = device.method_93();
																								if (device.method_82("bạn có thể dùng facebook", text13))
																								{
																									flag15 = true;
																									flag4 = true;
																									flag2 = true;
																									break;
																								}
																							}
																							if (flag15)
																							{
																								if (device.method_52("DataClick\\image\\truycapfacebook"))
																								{
																									device.method_3("DataClick\\image\\truycapfacebook");
																								}
																								else
																								{
																									device.method_91(160, 165);
																								}
																								flag11 = true;
																								device.method_121(1.0);
																							}
																							else
																							{
																								method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																								method_42(int_41, "Checkpoint");
																								flag5 = true;
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																							flag2 = false;
																							device.method_12();
																						}
																						goto IL_738b;
																					}
																					method_62(int_41, text3 + "API key sai...", device);
																					method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																					break;
																				}
																				if (text5 == "Đã hết số điện thoại, chờ cập nhật")
																				{
																					method_62(int_41, text3 + "Hết số điện thoại", device);
																					method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																				else
																				{
																					method_62(int_41, text3 + "Hết số điện thoại", device);
																					method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																				break;
																				continue;
																			end_IL_52b9:
																				break;
																			}
																			goto end_IL_3756;
																		}
																		if (bool_17)
																		{
																			int num32 = 0;
																			while (true)
																			{
																				method_62(int_41, text3 + "Đang lấy tempmail.io", device);
																				string text42 = "";
																				string text43 = method_73();
																				if (int_38 == 0)
																				{
																					text42 = Common.smethod_19(text43);
																				}
																				if (!(text42 != ""))
																				{
																					break;
																				}
																				if (device.method_52("DataClick\\image\\inputsdtemail"))
																				{
																					device.method_3("DataClick\\image\\inputsdtemail");
																				}
																				else
																				{
																					device.method_99("nhập số điện thoại hoặc email mới");
																				}
																				method_62(int_41, text3 + "TempMail:" + text42, device);
																				method_52(text42, "email", int_41, 0, dgvAcc);
																				device.method_121(1.0);
																				device.method_102(text42);
																				device.method_121(1.0);
																				if (device.method_52("DataClick\\image\\sendcodeotp"))
																				{
																					device.method_3("DataClick\\image\\sendcodeotp");
																				}
																				else
																				{
																					device.method_99("gửi mã đăng nhập");
																				}
																				bool flag16 = false;
																				for (int num33 = 0; num33 < 5; num33++)
																				{
																					text13 = device.method_93();
																					if (device.method_82("nhập mã xác nhận", text13))
																					{
																						flag16 = true;
																						break;
																					}
																				}
																				if (flag16)
																				{
																					method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																					text44 = Common.smethod_20(method_39(int_41));
																					if (!(text44 != ""))
																					{
																						if (num32 != 5)
																						{
																							if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																							{
																								device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																							}
																							else
																							{
																								device.method_99("cập nhật thông tin liên hệ");
																							}
																							num32++;
																							continue;
																						}
																						method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					goto IL_5776;
																				}
																				if (num32 != 5)
																				{
																					if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																					{
																						device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																					}
																					else
																					{
																						device.method_99("cập nhật thông tin liên hệ");
																					}
																					num32++;
																					continue;
																				}
																				method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_3756;
																			}
																		}
																	}
																}
																while (true)
																{
																	if (string_12.Substring(0, 1) == "0" && !flag2)
																	{
																		if (bool_16)
																		{
																			if (!bool_0)
																			{
																				text13 = device.method_93();
																				if (device.method_82("change phone number", text13))
																				{
																					device.method_99("change phone number", text13);
																				}
																				else
																				{
																					device.method_99("thay đổi số điện thoại", text13);
																				}
																				while (true)
																				{
																					if (num2 == 0)
																					{
																						method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																					}
																					else
																					{
																						method_62(int_41, text3 + "Lấy số khác...Lần: " + num2, device);
																						device.method_121(1.0);
																						int tickCount3 = Environment.TickCount;
																						while ((Environment.TickCount - tickCount3) / 1000 - int_39 < 0)
																						{
																							if (!bool_0)
																							{
																								method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount3) / 1000).ToString()), device);
																								continue;
																							}
																							method_62(int_41, "Dừng chạy!", device);
																							method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																							goto end_IL_5c15;
																						}
																					}
																					text5 = "";
																					if (int_37 == 0)
																					{
																						text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																					}
																					else if (int_37 == 1)
																					{
																						text5 = Common.smethod_57(text17, ref text18);
																						text9 = text5;
																					}
																					else if (int_37 == 2)
																					{
																						text5 = Common.smethod_21(text17, ref text18);
																					}
																					else if (int_37 == 3)
																					{
																						text5 = Common.smethod_48(text17);
																					}
																					else if (int_37 == 4)
																					{
																						text5 = Common.smethod_27(text17, text18);
																					}
																					else if (int_37 == 5)
																					{
																						text5 = Common.smethod_25(text17, text18);
																					}
																					else if (int_37 == 6)
																					{
																						text5 = Common.GetPhoneOtpFb(text17, ref text18);
																					}
																					else if (int_37 == 7)
																					{
																						text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																					}
																					else if (int_37 == 8)
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																					}
																					else if (int_37 == 9)
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18);
																					}

																					if (text5 != "")
																					{
																						if (!(text5 == "API sai"))
																						{
																							if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																							{
																								if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																								{
																									text5 = "+84" + text5; // truoc la +1
																								}
																								else if (int_37 == 9 || int_37 == 3 || int_37 == 6)
																								{
																									text5 = "+84" + text5;
																								}
																								method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																								method_52(text5, "phone", int_41, 0, dgvAcc);
																								device.method_121(1.0);
																								if (num2 == 0)
																								{
																									if (device.method_52("DataClick\\image\\phone"))
																									{
																										device.method_3("DataClick\\image\\phone");
																									}
																									else
																									{
																										device.method_91(36, 147);
																									}
																								}
																								device.method_121(1.0);
																								device.method_102(text5);
																								device.method_121(1.0);
																								if (device.method_52("DataClick\\image\\continue"))
																								{
																									device.method_3("DataClick\\image\\continue");
																								}
																								bool flag17 = false;
																								for (int num34 = 0; num34 < 5; num34++)
																								{
																									text13 = device.method_93();
																									if (!device.method_82("nhập mã từ sms của bạn", text13))
																									{
																										flag17 = true;
																										continue;
																									}
																									flag17 = false;
																									break;
																								}
																								if (!flag17)
																								{
																									goto IL_5c24;
																								}
																								if (num2 != 5)
																								{
																									device.method_44("số điện thoại di động");
																									num2++;
																									continue;
																								}
																								goto IL_5e64;
																							}
																							goto IL_5e8d;
																						}
																						method_62(int_41, text3 + "API key sai...", device);
																						method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																						break;
																					}
																					if (num2 != 5)
																					{
																						num2++;
																						continue;
																					}
																					goto IL_5ee2;
																					continue;
																				end_IL_5c15:
																					break;
																				}
																			}
																			else
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			break;
																		}
																		if (bool_17)
																		{
																			if (!bool_0)
																			{
																				text13 = device.method_93();
																				if (device.method_82("email confirmation", text13))
																				{
																					device.method_99("email confirmation", text13);
																				}
																				else
																				{
																					device.method_99("xác nhận qua email", text13);
																				}
																				method_62(int_41, text3 + "Đang lấy tempmail.io", device);
																				string text45 = "";
																				while (true)
																				{
																					string text46 = method_73();
																					if (int_38 == 0)
																					{
																						text45 = Common.smethod_19(text46);
																					}
																					if (text45 != "")
																					{
																						method_52(text45, "email", int_41, 0, dgvAcc);
																						if (device.method_52("DataClick\\image\\emailveri"))
																						{
																							device.method_3("DataClick\\image\\emailveri");
																						}
																						device.method_121(1.0);
																						device.method_102(text45);
																						device.method_121(1.0);
																						if (device.method_52("DataClick\\image\\continue"))
																						{
																							device.method_3("DataClick\\image\\continue");
																						}
																						bool flag18 = false;
																						for (int num35 = 0; num35 < 5; num35++)
																						{
																							text13 = device.method_93();
																							if (!device.method_82("nhập mã từ email của bạn", text13))
																							{
																								flag18 = true;
																								continue;
																							}
																							flag18 = false;
																							break;
																						}
																						if (!flag18)
																						{
																							break;
																						}
																						if (num3 != 5)
																						{
																							device.method_44("địa chỉ email");
																							num3++;
																							method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																							continue;
																						}
																						goto IL_5f39;
																					}
																					if (num3 != 5)
																					{
																						num3++;
																						method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																						continue;
																					}
																					goto IL_5f62;
																				}
																				flag2 = true;
																				continue;
																			}
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		flag2 = false;
																		device.method_12();
																	}
																	else
																	{
																		while (true)
																		{
																		IL_6c5f:
																			text13 = device.method_93();
																			if (!device.method_82("enter your mobile number", text13) && !device.method_82("nhập số di động của bạn", text13))
																			{
																				int num36 = 0;
																				while (num36 < 2)
																				{
																					text13 = device.method_93();
																					if (device.method_120(text13).Count == 1)
																					{
																						num36++;
																						continue;
																					}
																					goto IL_6008;
																				}
																				goto IL_6064;
																			}
																			flag2 = false;
																			method_62(int_41, text3 + "Lỗi xác nhận số điện thoại hoặc email... Goto Newfeed", device);
																			device.method_124();
																			break;
																		IL_6008:
																			if (device.method_82("enter the code from your sms", text13) || device.method_82("nhập mã từ sms của bạn", text13) || device.method_82("nhập mã từ email của bạn", text13))
																			{
																				if (!bool_0)
																				{
																					flag11 = true;
																					goto IL_6064;
																				}
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			flag2 = false;
																			method_62(int_41, text3 + "Lỗi xác nhận số điện thoại hoặc email... Goto Newfeed", device);
																			device.method_124();
																			break;
																		IL_6064:
																			if (flag11)
																			{
																				if (!bool_0)
																				{
																					try
																					{
																						if (rdThuePhone.Checked || bool_16)
																						{
																							int num37 = 0;
																							int num38 = 0;
																							while (num38 < 2)
																							{
																								if (!bool_0)
																								{
																									method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																									string text47 = string.Empty;
																									if (rdThuePhone.Checked)
																									{
																										if (string_12.Substring(2, 1) == "0")
																										{
																											text47 = Common.smethod_44(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "1")
																										{
																											text47 = Common.smethod_61(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "2")
																										{
																											text47 = Common.smethod_26(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "3")
																										{
																											text47 = Common.smethod_28(text17, text9, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "4")
																										{
																											text47 = Common.smethod_27(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "5")
																										{
																											text47 = Common.smethod_45(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "6")
																										{
																											text47 = Common.smethod_46(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "7")
																										{
																											text47 = Common.GetCodeWinMailShop(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "8")
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "9")
																										{
																											text47 = Common.GetCodeOtptn(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "10")
																										{
																											text47 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "11")
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}

																									}
																									else if (bool_16)
																									{
																										if (int_37 == 0)
																										{
																											text47 = Common.smethod_26(text17, text18, int_14);
																										}
																										else if (int_37 == 1)
																										{
																											text47 = Common.smethod_28(text17, text9, int_14);
																										}
																										else if (int_37 == 2)
																										{
																											text47 = Common.smethod_27(text17, text18, int_14);
																										}
																										else if (int_37 == 3)
																										{
																											text47 = Common.smethod_45(text17, text18, int_14);
																										}
																										else if (int_37 == 4)
																										{
																											text47 = Common.smethod_46(text17, text18, int_14);
																										}
																										else if (int_37 == 5)
																										{
																											text47 = Common.GetCodeWinMailShop(text17, text18, int_14);
																										}
																										else if (int_37 == 6)
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																										else if (int_37 == 7)
																										{
																											text47 = Common.GetCodeOtptn(text17, text18, int_14);
																										}
																										else if (int_37 == 8)
																										{
																											text47 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																										}
																										else if (int_37 == 9)
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																									}
																									if (!(text47 == ""))
																									{
																										flag11 = true;
																										method_62(int_41, text3 + "Mã OTP:" + text47, device);
																										if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																										{
																											device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																										}
																										device.method_102(text47);
																										break;
																									}
																									if (!bool_0)
																									{
																										num37++;
																										text13 = device.method_93();
																										if (device.method_120(text13).Count == 1)
																										{
																											goto IL_639d;
																										}
																										method_62(int_41, text3 + "Không lấy được mã OTP...", device);
																										if (!device.method_82("account confirmation", text13) && !device.method_82("xác nhận tài khoản", text13))
																										{
																											goto IL_639d;
																										}
																										if (!bool_0)
																										{
																											if (!device.method_82("change phone number", text13) && !device.method_82("thay đổi số điện thoại", text13))
																											{
																												goto IL_639d;
																											}
																											if (bool_0)
																											{
																												method_62(int_41, text3 + "Dừng chạy...");
																												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																												break;
																											}
																											if (device.method_82("change phone number", text13))
																											{
																												device.method_99("change phone number", text13);
																											}
																											else
																											{
																												device.method_99("thay đổi số điện thoại", text13);
																											}
																											device.method_121(1.0);
																											while (true)
																											{
																												method_62(int_41, text3 + "Đang lấy số điện thoại khác...", device);
																												if (!rdThuePhone.Checked)
																												{
																													if (bool_16)
																													{
																														if (int_37 == 0)
																														{
																															text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																														}
																														else if (int_37 == 1)
																														{
																															text5 = Common.smethod_57(text17, ref text18);
																															text9 = text5;
																														}
																														else if (int_37 == 2)
																														{
																															text5 = Common.smethod_21(text17, ref text18);
																														}
																														else if (int_37 == 3)
																														{
																															text5 = Common.smethod_48(text17);
																														}
																														else if (int_37 == 4)
																														{
																															text5 = Common.smethod_27(text17, text18);
																														}
																														else if (int_37 == 5)
																														{
																															text5 = Common.smethod_25(text17, text18);
																														}
																														else if (int_37 == 6)
																														{
																															text5 = Common.GetPhoneOtpFb(text17, ref text18);
																														}
																														else if (int_37 == 7)
																														{
																															text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																														}
																														else if (int_37 == 8)
																														{
																															text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																														}
																														else if (int_37 == 9)
																														{
																															text5 = Common.GetPhoneAhasim(text17, ref text18);
																														}
																													}
																												}
																												else if (string_12.Substring(2, 1) == "0")
																												{
																													text5 = Common.smethod_47(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "1")
																												{
																													text5 = Common.smethod_57(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "2")
																												{
																													text5 = Common.smethod_21(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "3")
																												{
																													text5 = Common.smethod_48(text17);
																													text9 = text5;
																												}
																												else if (string_12.Substring(2, 1) == "4")
																												{
																													text5 = Common.smethod_22(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "5")
																												{
																													text5 = Common.smethod_23(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "6")
																												{
																													text5 = Common.smethod_24(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "7")
																												{
																													text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "8")
																												{
																													text5 = Common.GetPhoneAhasim(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "9")
																												{
																													text5 = Common.GetPhoneOtptn(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "10")
																												{
																													text5 = Common.GetPhoneOtpFb(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "11")
																												{
																													text5 = Common.GetPhoneAhasim(text17, ref text18);
																												}
																												if (text5 == "")
																												{
																													if (!bool_0)
																													{
																														method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác", device);
																														continue;
																													}
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												if (text5 == "Đã hết số điện thoại, chờ cập nhật" && string_12.Substring(2, 1) == "3")
																												{
																													method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																													method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																													goto end_IL_63b1;
																												}
																												if (text5 == "API sai")
																												{
																													method_62(int_41, text3 + "API key sai...Kiểm tra lại", device);
																													method_49("API key sai...Kiểm tra lại", device.int_0, int_41, int_42, device, bool_18: false);
																													goto end_IL_63b1;
																												}
																												if (bool_0)
																												{
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												if (rdThuePhone.Checked)
																												{
																													if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																													{
																														text5 = "+84" + text5;
																													}
																													if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																													{
																														text5 = "+84" + text5; // truoc la +1
																													}
																												}
																												else if (bool_16)
																												{
																													if (int_37 == 3 || int_37 == 9 || int_37 == 6)
																													{
																														text5 = "+84" + text5;
																													}
																													if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																													{
																														text5 = "+84" + text5; // truoc la +1
																													}
																												}
																												method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																												method_52(text5, "phone", int_41, 0, dgvAcc);
																												device.method_121(1.0);
																												if (device.method_52("DataClick\\image\\phone"))
																												{
																													device.method_3("DataClick\\image\\phone");
																												}
																												else
																												{
																													device.method_91(36, 147);
																												}
																												device.method_121(1.0);
																												device.method_102(text5);
																												device.method_121(1.0);
																												if (device.method_52("DataClick\\image\\continue"))
																												{
																													device.method_3("DataClick\\image\\continue");
																												}
																												device.method_121(3.0);
																												goto IL_6c5f;
																											}
																										}
																										else
																										{
																											method_62(int_41, text3 + "Dừng chạy...", device);
																											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																										}
																									}
																									else
																									{
																										method_62(int_41, text3 + "Dừng chạy...");
																										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									}
																								}
																								else
																								{
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								}
																								goto end_IL_607a;
																							IL_639d:
																								if (num37 != 5)
																								{
																									num38++;
																									continue;
																								}
																								flag2 = false;
																								device.method_12();
																								goto end_IL_6c5f;
																								continue;
																							end_IL_63b1:
																								break;
																							}
																							goto IL_6c84;
																						}
																						if (rdConfMail.Checked)
																						{
																							if (bool_0)
																							{
																								method_62(int_41, text3 + "Dừng chạy...", device);
																								method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								goto end_IL_5e1f;
																							}
																							string text48 = string_12.Substring(2, 1);
																							if (text48 != null)
																							{
																								if (!(text48 == "0"))
																								{
																									if (!(text48 == "1"))
																									{
																										string text49 = Common.smethod_20(method_39(int_41));
																										if (!(text49 != ""))
																										{
																											method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																											flag11 = true;
																											flag2 = false;
																											device.method_124();
																											break;
																										}
																										if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																										{
																											device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																										}
																										device.method_102(text49);
																										flag11 = true;
																									}
																								}
																								else
																								{
																									string text50 = Common.smethod_31(text6, text7);
																									if (text50 == "")
																									{
																										flag2 = false;
																										method_52("Mail không nhận được OTP. Goto Newfeed", "status", int_41, 2, dgvAcc);
																										device.method_124();
																									}
																									if (text50.Contains("kcon"))
																									{
																										flag2 = false;
																										method_52("Không kê\u0301t nô\u0301i đươ\u0323c server hotmail!", "status", int_41, 2, dgvAcc);
																										device.method_124();
																									}
																									if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																									{
																										device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																									}
																									device.method_102(text50);
																									flag11 = true;
																								}
																							}
																							goto IL_6c84;
																						}
																						if (bool_17)
																						{
																							string text51 = Common.smethod_20(method_39(int_41));
																							if (!(text51 != ""))
																							{
																								method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																								flag11 = true;
																								flag2 = false;
																								device.method_124();
																								break;
																							}
																							if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																							{
																								device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																							}
																							flag2 = true;
																							device.method_102(text51);
																							flag11 = true;
																						}
																						goto IL_6c84;
																					end_IL_607a:;
																					}
																					catch (Exception ex2)
																					{
																						method_62(int_41, text3 + "Lỗi khi xác nhận. Lỗi: " + ex2.Message, device);
																						method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					}
																				}
																				else
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																			}
																			else
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			goto end_IL_5e1f;
																		IL_6c84:
																			if (!flag11)
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			if (device.method_82("\"confirm\"", text13))
																			{
																				device.method_99("\"confirm\"");
																			}
																			else
																			{
																				device.method_99("\"xác nhận\"");
																			}
																			device.method_121(15.0);
																			int num39 = 0;
																			while (true)
																			{
																				if (num39 < 10)
																				{
																					text13 = device.method_93();
																					if (device.method_120(text13).Count == 1)
																					{
																						goto IL_6eac;
																					}
																					if (!device.method_82("skip", text13) && !device.method_82("bỏ qua", text13))
																					{
																						if (!device.method_82("we need more information", text13) && !device.method_82("Something went wrong. Please try again.", text13) && !device.method_82("chúng tôi cần thêm thông tin", text13))
																						{
																							if (device.method_82("enter the code from your sms", text13) || device.method_82("nhập mã từ sms của bạn", text13) || device.method_82("nhập mã từ email của bạn", text13))
																							{
																								if (num39 == 3)
																								{
																									flag2 = false;
																									method_62(int_41, text3 + "Lỗi xác thực số điện thoại từ Facebook...Goto Newfeed", device);
																									break;
																								}
																								method_62(int_41, text3 + "Xác nhận lại lần " + num39, device);
																								device.method_121(2.0);
																								if (device.method_82("\"confirm\"", text13))
																								{
																									device.method_99("\"confirm\"");
																								}
																								else
																								{
																									device.method_99("\"xác nhận\"");
																								}
																								flag11 = true;
																								flag2 = true;
																							}
																							goto IL_6eac;
																						}
																						method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																						method_42(int_41, "Checkpoint");
																						flag5 = true;
																						break;
																					}
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_5e1f;
																					}
																					flag11 = true;
																					if (device.method_82("skip", text13))
																					{
																						device.method_99("\"skip\"");
																					}
																					else
																					{
																						device.method_99("\"bỏ qua\"");
																					}
																				}
																				if (!flag11)
																				{
																					method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																					method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				if (bool_0)
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				method_62(int_41, text3 + "Thêm 5 bạn bè gợi ý...", device);
																				device.method_121(2.0);
																				text13 = device.method_93();
																				if (device.method_82("add 5 friends", text13) || device.method_82("thêm 5 người bạn", text13) || device.method_82("mời tất cả", text13))
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_5e1f;
																					}
																					flag11 = true;
																					if (device.method_82("add 5 friends", text13))
																					{
																						device.method_99("\"add 5 friends\"", "", 10);
																					}
																					else if (device.method_82("thêm 5 người bạn", text13))
																					{
																						device.method_99("\"thêm 5 người bạn\"", "", 10);
																					}
																					else if (device.method_82("mời tất cả", text13))
																					{
																						device.method_99("\"mời tất cả\"", "", 10);
																					}
																				}
																				else
																				{
																					flag11 = true;
																					if (device.method_82("skip", text13))
																					{
																						device.method_99("\"skip\"", "", 10);
																					}
																					else if (device.method_82("bỏ qua", text13))
																					{
																						device.method_99("\"bỏ qua\"", "", 10);
																					}
																					else if (device.method_82("xong", text13))
																					{
																						device.method_99("\"xong\"", "", 10);
																					}
																					else if (device.method_82("tiếp", text13))
																					{
																						device.method_99("\"tiếp\"", "", 10);
																					}
																				}
																				if (!flag11)
																				{
																					method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																					method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				if (bool_0)
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				device.method_121(1.0);
																				if (device.method_82("\"xong\""))
																				{
																					device.method_99("\"xong\"");
																				}
																				if (device.method_82("\"ok\""))
																				{
																					device.method_99("\"ok\"");
																				}
																				break;
																			IL_6eac:
																				num39++;
																			}
																			break;
																			continue;
																		end_IL_6c5f:
																			break;
																		}
																	}
																	goto IL_738b;
																IL_5e64:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5c24:
																	flag2 = true;
																	continue;
																IL_5e8d:
																	method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5ee2:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5f39:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5f62:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																	continue;
																end_IL_5e1f:
																	break;
																}
																goto end_IL_3756;
															IL_5776:
																if (device.method_52("DataClick\\image\\inputotpckp"))
																{
																	device.method_3("DataClick\\image\\inputotpckp");
																}
																else
																{
																	device.method_91(32, 173);
																}
																device.method_121(1.0);
																device.method_102(text44);
																device.method_99("\"tiếp\"");
																bool flag19 = false;
																for (int num40 = 0; num40 < 20; num40++)
																{
																	text13 = device.method_93();
																	if (device.method_82("bạn có thể dùng facebook", text13))
																	{
																		flag19 = true;
																		flag4 = true;
																		flag2 = true;
																		break;
																	}
																}
																if (flag19)
																{
																	if (device.method_52("DataClick\\image\\truycapfacebook"))
																	{
																		device.method_3("DataClick\\image\\truycapfacebook");
																	}
																	else
																	{
																		device.method_91(160, 165);
																	}
																	flag11 = true;
																	device.method_121(1.0);
																}
																else
																{
																	method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																	method_42(int_41, "Checkpoint");
																	flag5 = true;
																}
																goto IL_738b;
															IL_7fe5:
																if (!flag11)
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_6)
																{
																	method_62(int_41, text3 + "Bật 2FA...", device);
																	try
																	{
																		for (int num41 = 0; num41 < 2; num41++)
																		{
																			if (!bool_0)
																			{
																				int num42 = 0;
																				num42 = ((!flag2) ? method_35(int_41, int_42, device, 1) : method_34(int_41, device));
																				if (num42 != 1)
																				{
																					method_62(int_41, text3 + "Bật 2FA thất bại. Thử bật lại...");
																					continue;
																				}
																				method_62(int_41, text3 + "Bật 2FA thành công", device);
																				device.method_121(1.0);
																				break;
																			}
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																	}
																	catch (Exception exception_2)
																	{
																		Common.smethod_82(exception_2, "HDOnOff2FA");
																		goto IL_8211;
																	}
																}
																if (bool_15)
																{
																	try
																	{
																		method_62(int_41, text3 + "Đồng bộ danh bạ...", device);
																		device.method_124();
																		device.method_121(1.0);
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		int num43 = 0;
																		for (int num44 = 0; num44 < 2; num44++)
																		{
																			if (method_30(int_41, text3, device, int_28, int_29, bool_13, bool_14, int_30, int_31, int_32, int_33) != 0)
																			{
																				method_62(int_41, text3 + "Đồng bộ danh bạ xong...", device);
																				break;
																			}
																		}
																		goto IL_8211;
																	}
																	catch (Exception)
																	{
																		goto IL_8211;
																	}
																}
																goto IL_8211;
															IL_8211:
																if (text19 != "")
																{
																	string text52 = "";
																	text52 = ((int_9 == 5) ? ("|" + method_38(int_41)) : "");
																	if (!flag2)
																	{
																		if (flag5)
																		{
																			object obj12 = object_10;
																			lock (obj12)
																			{
																				File.AppendAllText("output/facebook/acc_282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																			}
																		}
																		else
																		{
																			string text53 = method_37(int_41);
																			object obj12 = object_7;
																			if (text53 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Noverify_2fa.txt", text19 + "|" + text16 + "|" + text53 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Noverify.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																		}
																	}
																	
																	else if ((rdConfMail.Checked && rdTempMailIO.Checked) || (rdConfMail.Checked && rdMailTM.Checked))
																	{
																		string text55 = method_37(int_41);
																		object obj12 = object_9;
																		if (rdConfMail.Checked && rdTempMailIO.Checked)
																		{
																			if (text55 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text6 + "|" + text7 + "|" + text52 + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_tempmail_Cp282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text6 + "|" + text7 + "|" + text52 + Environment.NewLine);
																				}
																			}
																		}
																		else if (rdConfMail.Checked && rdMailTM.Checked) // Checkpoint282
																		{
																			if (text55 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_mailtm_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_mailtm_Cp282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																				}
																			}
																		}
																		else if (bool_17)
																		{
																			if (Settings.Default.isThuVeriCheckPoint && flag4)
																			{
																				if (rdConfMail.Checked && rdTempMailIO.Checked)
																				{
																					if (text55 != "")
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/Verify_tempmail_2fa_Cp282.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																					else
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/Verify_tempmail.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																				}
																				else if (rdConfMail.Checked && rdMailTM.Checked)
																				{
																					if (text55 != "")
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/Verify_mailtm_2fa_Cp282.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																					else
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/Verify_mailtm.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																				}
																			}
																			//else if (int_38 == 0)
																			//{
																			//	if (text55 != "")
																			//	{
																			//		lock (obj12)
																			//		{
																			//			File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																			//		}
																			//	}
																			//	else
																			//	{
																			//		lock (obj12)
																			//		{
																			//			File.AppendAllText("output/facebook/Verify_tempmail.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																			//		}
																			//	}
																			//}
																		}
																	}
																}
																device.method_121(1.0);
																method_62(int_41, text3 + "Tắt app Facebook và mở lại", device);
																device.method_121(1.0);
																device.method_70();
																device.method_121(3.0);
																device.method_105();
																device.method_121(1.0);
																if (flag11)
																{
																	if (chkReadNotifi.Checked)
																	{
																		method_62(int_41, text3 + "Đọc thông báo", device);
																		device.method_121(1.0);
																		method_32(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkWStory.Checked)
																	{
																		method_62(int_41, text3 + "Lướt story", device);
																		device.method_121(1.0);
																		method_29(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkAddFUID.Checked)
																	{
																		method_62(int_41, text3 + "Thêm bạn bè gợi ý", device);
																		int int_43 = Convert.ToInt32(nFriendFrom.Value);
																		int int_44 = Convert.ToInt32(nFriendFrom.Value);
																		device.method_121(1.0);
																		method_28(int_41, text3, device, int_43, int_44);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkInNewfeed.Checked)
																	{
																		method_62(int_41, text3 + "Tương tác newsfeed", device);
																		device.method_121(1.0);
																		method_26(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkWatch.Checked)
																	{
																		method_62(int_41, text3 + "Xem watch", device);
																		device.method_121(1.0);
																		method_25(int_41, text3, device, 1, 5, 10, 20, bool_18: true, 1, 5, bool_19: true, 1, 3, bool_20: false, null, 0, 0, 100, 100, 100);
																	}
																}
																if (Settings.Default.isCheckUID)
																{
																	method_62(int_41, text3 + "Check uid và wall...", device);
																	device.method_121(1.0);
																	if (method_48(text19) && Common.smethod_33(text19).StartsWith("0|"))
																	{
																		method_42(int_41, "Live");
																		if (flag5)
																		{
																			method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																		}
																		else
																		{
																			method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
																		}
																	}
																	else
																	{
																		method_42(int_41, "Die");
																		method_49("Tài khoản die!!!", device.int_0, int_41, int_42, device, bool_18: false);
																	}
																}
																else if (flag5)
																{
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																}
																else
																{
																	method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
																}
																goto end_IL_3756;
																continue;
															end_IL_4ccc:
																break;
															}
															goto IL_909d;
															continue;
														end_IL_3756:
															break;
														}
														break;
														continue;
													end_IL_2a36:
														break;
													}
													break;
												}
												method_62(int_41, text3 + "Bị treo LD khi mở app facebook. Thực hiện lại.", device);
												device.method_70();
												device.method_121(1.0);
												continue;
											}
											catch (Exception exception_3)
											{
												method_62(int_41, text3 + "Lỗi treo LD khi mở app Facebook", device);
												method_49("Lỗi treo LD khi mở app Facebook", device.int_0, int_41, int_42, device, bool_18: false);
												Common.smethod_82(exception_3, "ErrorOpenAppFacebook");
											}
											break;
										}
										break;
									}
								IL_moapp:
									method_62(int_41, text3 + "Mở App Facebook Lite", device);
									device.method_40();
									string text56 = "";
									try
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										device.method_106();
										bool flag20 = false;
										bool flag21 = false;
										bool flag22 = false;
										int num45 = 0;
										for (int num46 = 0; num46 < 30; num46++)
										{
											if (device.method_52("DataClick\\fblite\\facebook"))
											{
												flag20 = true;
												break;
											}
										}
										if (flag20)
										{
											device.method_121(1.0);
											method_62(int_41, text3 + "Đăng ký facebook lite", device);
											if (device.method_52("DataClick\\fblite\\tiengviet"))
											{
												device.method_3("DataClick\\fblite\\tiengviet");
											}
											device.method_121(1.0);
											if (!device.method_52("DataClick\\fblite\\createaccount"))
											{
												device.method_91(32, 376); // Tieng viet
												device.method_121(1.0);
											}
											if (device.method_52("DataClick\\fblite\\createaccount"))
											{
												device.method_3 ("DataClick\\fblite\\createaccount");
											}
											device.method_121(1.0);
											if (device.method_52("DataClick\\fblite\\next"))
											{
												device.method_3("DataClick\\fblite\\next");
											}
											device.method_121(1.0);
											method_62(int_41, text3 + "Tạo thông tin đăng ký", device);
											string text57 = "";
											string text58 = "";
											string text59 = "";
											string text60 = "";
											string text61 = "";
											string text62 = "";
											string text63 = "";
											string text64 = "";
											string text65 = "";
											string text66 = "";
											string text67 = "";
											string text68 = "";
											string text69 = "";
											string text669 = "";
											string text70 = "";
											string text71 = "";
											bool flag23 = false;
											bool flag223 = false;
											string text72 = random_0.Next(0, 2).ToString();
											if (int_13 == 0)
											{
												text72 = "0";
											}
											else if (int_13 == 1)
											{
												text72 = "1";
											}
											if (int_12 == 0)
											{
												text57 = method_6();
												text58 = ((!(text72 == "0")) ? method_7() : method_8());
											}
											else if (int_12 == 1)
											{
												text57 = method_3();
												text58 = ((!(text72 == "0")) ? method_5() : method_4());
											}
											else if (int_12 == 2)
											{
												text57 = method_9();
												text58 = ((!(text72 == "0")) ? method_10() : method_11());
												text70 = method_3();
												text71 = ((!(text72 == "0")) ? method_5() : method_4());
											}
											text59 = ((int_12 == 2) ? ((!bool_5) ? string_14.Trim() : Common.smethod_75(text71 + text70)) : ((!bool_5) ? string_14.Trim() : Common.smethod_75(text58 + text57)));
											method_52(text57, "ho", int_41, 0, dgvAcc);
											method_52(text58, "ten", int_41, 0, dgvAcc);
											method_52((text72 == "1") ? "Nam" : "Nữ", "gender", int_41, 0, dgvAcc);
											method_52(text59, "pass", int_41, 0, dgvAcc);
											text60 = string_11;
											if (bool_16)
											{
												text60 = string_20;
											}
											for (int num47 = 0; num47 < 10; num47++)
											{
												text56 = device.method_93();
												if (device.method_52("DataClick\\fblite\\whatyourname"))
												{
													flag23 = true;
													break;
												}
											}
											if (!flag23)
											{
												method_62(int_41, text3 + "Lỗi khi đăng ký", device);
												method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											method_62(int_41, text3 + "Nhập họ", device);
											device.method_49(text57, bool_0: false, bool_1: false);
											device.method_121(1.0);
											method_62(int_41, text3 + "Nhập tên", device);
											device.method_91(176, 165);
											device.method_121(1.0);
											device.method_49(text58, bool_0: false, bool_1: false);
											device.method_121(1.0);
											
											if (device.method_52("DataClick\\fblite\\next"))
											{
												device.method_3("DataClick\\fblite\\next");
											}
											//for(int i=0; i<5; i++)
           //                                 {
											//	if (!device.method_52("DataClick\\fblite\\tenkhac"))
											//	{
											//		string text56z = device.method_93();
											//		flag23 = false;
											//		continue;
											//	}
											//	flag23 = true;
											//	break;
											//	//device.method_91(250, 250); // Click vao vi tri xuat hien tren man hinh
											//}
											//try
											//{
												
											//}
											//catch
											//{
											//	device.method_3("DataClick\\fblite\\tenkhac");
											//}
											device.method_121(1.0);
											for (int num48 = 0; num48 < 5; num48++)
											{
												text56 = device.method_93();
												if (!device.method_52("DataClick\\fblite\\yourphone"))
												{
													flag23 = false;
													continue;
												}
												flag23 = true;
												break;
											}
											if (!flag23)
											{
												method_62(int_41, text3 + "Lỗi khi đăng ký", device);
												method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											while (true)
											{
												if (!(string_12.Substring(0, 1) == "0"))
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													
													if (rdConfMail.Checked)
													{
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (num4 == 0 && device.method_52("DataClick\\fblite\\registerbymail"))
														{
															device.method_3("DataClick\\fblite\\registerbymail");
														}
														string text73 = string_12.Substring(2, 1);
														int num50 = 0;
														if (text73 != null)
														{
															if (rdConfMail.Checked && rdTempMailIO.Checked || rdConfMail.Checked && rdMailTM.Checked)
															{
																if (rdConfMail.Checked && rdTempMailIO.Checked)
																{
																	method_62(int_41, text3 + "Đang lấy TempMail...", device);
																	while (true)
																	{
																		string text74 = method_73();
																		string text75 = Common.smethod_19(text74);
																		if (!(text75 != ""))
																		{
																			if (num50 != 5)
																			{
																				num50++;
																				continue;
																			}
																			method_62(int_41, text3 + "Lỗi không lấy được tempmail...", device);
																			goto end_IL_a96f;
																		}
																		method_52(text75, "email", int_41, 0, dgvAcc);
																		flag2 = true;
																		device.method_91(59, 184);
																		device.method_121(1.0);
																		device.method_49(text75, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																		break;
																	}
																}
																else if (rdConfMail.Checked && rdMailTM.Checked) 
																{
																	Mailtm mailtm = new Mailtm();
																	method_62(int_41, text3 + "Đang lấy Mailtm...", device);
																	while (true)
																	{
																		string getdomains = mailtm.getdomains(); // Get duoi @ gigi day . mail dang ki
																		string account_mailtm = Getrandomemail() + "@" + getdomains;
																		string pass_mailtm = Getrandompassmailtm();
																		if (mailtm.Create_Mailtm(account_mailtm, pass_mailtm, string_21))
																		{
																			break;
																		}

																		string text75 = account_mailtm;
																		if (!(text75 != ""))
																		{
																			if (num50 != 5)
																			{
																				num50++;
																				continue;
																			}
																			method_62(int_41, text3 + "Lỗi không lấy được Mailtm...", device);
																			goto end_IL_a96f;
																		}
																		method_52(text75, "email", int_41, 0, dgvAcc);
																		flag2 = true;
																		device.method_91(59, 184);
																		device.method_121(1.0);
																		device.method_49(text75, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																		break;
																	}
																}
																else
																{
																	 
																	 
																}
															}
															else
															{
															 
															}
														}
													}
												}
												else
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
												 
												}
												goto IL_9eb2;
											IL_a50c:
												if (num45 != 5)
												{
													method_62(int_41, text3 + "Thử nhập lại mật khẩu", device);
													flag22 = true;
													num45++;
													goto IL_a53f;
												}
												bool flag24 = false;
												goto IL_ac6f;
											IL_a6eb:
												method_62(int_41, text3 + "Trùng số. Lấy số khác", device);
												flag21 = true;
												continue;
											IL_d388: // GET UID DIE OR LIVE
												string text78 = device.method_14(int_42.ToString());
												if (text78 != "")
												{
													text62 = text78.Split('|')[0];
													text64 = text78.Split('|')[1];
													text63 = text78.Split('|')[2];
													method_52(text62, "uid", int_41, 0, dgvAcc);
													method_52(text63, "token", int_41, 0, dgvAcc);
													method_52(text64, "cookie", int_41, 0, dgvAcc);
												}
												if (!flag5 && flag2)
												{
													if (bool_3)
													{
														method_62(int_41, text3 + "Up avatar...", device);
														if (method_65(text62, device))
														{
															method_62(int_41, text3 + "Up avatar thành công", device);
														}
														else
														{
															method_62(int_41, text3 + "Up avatar thất bại", device);
														}
													}
													if (bool_6)
													{
														method_62(int_41, text3 + "Bật 2FA...", device);
														if (method_64(int_41, device))
														{
															method_62(int_41, text3 + "Bật 2FA thành công", device);
														}
														else
														{
															method_62(int_41, text3 + "Bật 2FA thất bại", device);
														}
													}
												}
												string text79 = "";
												text79 = ((int_9 == 5) ? ("|" + method_38(int_41)) : "");
												if (text62 != "")
												{
													if (!flag2)
													{
														if (flag5)
														{
															object obj14 = object_10;
															lock (obj14)
															{
																File.AppendAllText("output/facebook/acc_282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
														else
														{
															string text80 = method_37(int_41);
															object obj14 = object_7;
															if (text80 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Noverify_2fa.txt", text62 + "|" + text59 + "|" + text80 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Noverify.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
														}
													}
													else if (rdThuePhone.Checked || bool_16)
													{
														string text81 = method_37(int_41);
														object obj14 = object_8;
														if (Settings.Default.isThuVeriCheckPoint && flag4)
														{
															if (text81 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifySdt_checkpoint282_2fa.txt", text62 + "|" + text59 + "|" + text81 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifySdt_checkpoint282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
														}
														else if (text81 != "")
														{
															lock (obj14)
															{
																File.AppendAllText("output/facebook/VerifySdt_2fa.txt", text62 + "|" + text59 + "|" + text81 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
														else
														{
															lock (obj14)
															{
																File.AppendAllText("output/facebook/VerifySdt.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
													}
													else
													{
														string text82 = method_37(int_41);
														object obj14 = object_9;
														if (rdHotMailReg.Checked || rdHotMailRegisted.Checked)
														{
															if (text82 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifyHotMail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text6 + "|" + text7 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifyHotMail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text6 + "|" + text7 + "|" + text79 + Environment.NewLine);
																}
															}
														}
														else if (rdTempMailIO.Checked)
														{
															if (text82 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Verify_tempmail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																}
															}
														}
														else if (bool_17)
														{
															if (Settings.Default.isThuVeriCheckPoint && flag4)
															{
																if (int_38 == 0)
																{
																	if (text82 != "")
																	{
																		lock (obj14)
																		{
																			File.AppendAllText("output/facebook/VerifyMail_checkpoint282_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																		}
																	}
																	else
																	{
																		lock (obj14)
																		{
																			File.AppendAllText("output/facebook/VerifyMail_checkpoint282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																		}
																	}
																}
															}
															else if (int_38 == 0)
															{
																if (text82 != "")
																{
																	lock (obj14)
																	{
																		File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																	}
																}
																else
																{
																	lock (obj14)
																	{
																		File.AppendAllText("output/facebook/Verify_tempmail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																	}
																}
															}
														}
													}
												}
												if (Settings.Default.isCheckUID)
												{
													method_62(int_41, text3 + "Check uid và wall...", device);
													device.method_121(1.0);
													if (method_48(text62) && Common.smethod_33(text62).StartsWith("0|"))
													{
														method_42(int_41, "Live");
														if (flag5)
														{
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														}
														else
														{
															method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
														}
													}
													else
													{
														method_42(int_41, "Die");
														method_49("Tài khoản die!!!", device.int_0, int_41, int_42, device, bool_18: false);
													}
												}
												else if (flag5)
												{
													method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
												}
												else
												{
													method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
												}
												break;
											giaicp282:
												if (Settings.Default.isThuVeriCheckPoint)
												{
													method_62(int_41, text3 + "Checkpoint...thử xác nhận", device); // Check 282 fblite
													flag3 = true;
													goto IL_aca6;
												}
												method_62(int_41, text3 + "Checkpoint 282!!!", device);
												flag5 = true;
												flag2 = false;
												method_42(int_41, "Checkpoint");
												goto IL_d388;
											IL_aca6:
												string text86;
												if (flag3)
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													device.method_99("\"tiếp tục\"");
													for (int num52 = 0; num52 < 5; num52++)
													{
														text56 = device.method_93();
														if (device.method_82("giúp chúng tôi xác nhận đó là bạn", text56))
														{
															//method_62(int_41, "Captcha...Không xác thực", device); // Thử giải captcha 282 fblite
															//method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															//goto end_IL_a96f;
															method_62(int_41, "Captcha...Dang giai Captcha", device);
															method_49("Dang Giai Captcha !!!", device.int_0, int_41, int_42, device, bool_18: false);

															string captcha = "";
															captcha = CaptchaService.Anycaptcha_Giai_recaptcha(text_api_captcha, "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR");
															if (captcha != "")
															{
																method_62(int_41, "Giai Captcha thanh cong... Up anh", device);
																method_49("Giai Captcha thanh cong !!!", device.int_0, int_41, int_42, device, bool_18: false);
															}
														}
													}
													if (bool_16 || rdThuePhone.Checked)
													{
														int num53 = 0;
														while (true)
														{
															if (num53 == 0)
															{
																method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
															}
															else
															{
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lấy số khác...Lần: " + num53, device);
																device.method_121(1.0);
																int tickCount4 = Environment.TickCount;
																while ((Environment.TickCount - tickCount4) / 1000 - int_39 < 0)
																{
																	if (!bool_0)
																	{
																		method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount4) / 1000).ToString()), device);
																		continue;
																	}
																	method_62(int_41, "Dừng chạy!", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_b4a0;
																}
															}
															text5 = "";
															if (bool_16)
															{
																if (int_37 == 0)
																{
																	text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																}
																else if (int_37 == 1)
																{
																	text5 = Common.smethod_57(text60, ref text61);
																	text9 = text5;
																}
																else if (int_37 == 2)
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (int_37 == 3)
																{
																	text5 = Common.smethod_48(text60);
																}
																else if (int_37 == 4)
																{
																	text5 = Common.smethod_27(text60, text61);
																}
																else if (int_37 == 5)
																{
																	text5 = Common.smethod_25(text60, text61);
																}
																else if (int_37 == 6)
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (int_37 == 7)
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (int_37 == 8)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																}
																else if (int_37 == 9)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
															}
															else if (string_12.Substring(2, 1) == "0")
															{
																text5 = Common.smethod_47(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "1")
															{
																text5 = Common.smethod_57(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "2")
															{
																text5 = Common.smethod_21(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "3")
															{
																text5 = Common.smethod_48(text60);
																text9 = text5;
															}
															else if (string_12.Substring(2, 1) == "4")
															{
																text5 = Common.smethod_22(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "5")
															{
																text5 = Common.smethod_23(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "6")
															{
																text5 = Common.smethod_24(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "7")
															{
																text5 = Common.GetPhoneWinMailShop(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "8")
															{
																text5 = Common.GetPhoneAhasim(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "9")
															{
																text5 = Common.GetPhoneOtptn(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "10")
															{
																text5 = Common.GetPhoneOtpFb(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "11")
															{
																text5 = Common.GetPhoneAhasim(text60, ref text61);
															}
															if (text5 != "")
															{
																if (!(text5 == "API sai"))
																{
																	if (text5 == "Đã hết số điện thoại, chờ cập nhật")
																	{
																		method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																		flag2 = false;
																		device.method_12();
																	}
																	if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																	{
																		text5 = "+84" + text5;
																	}
																	if (device.method_52("DataClick\\image\\inputsdtemail"))
																	{
																		device.method_3("DataClick\\image\\inputsdtemail");
																	}
																	else
																	{
																		device.method_99("nhập số điện thoại hoặc email mới");
																	}
																	method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																	method_52(text5, "phone", int_41, 0, dgvAcc);
																	device.method_121(1.0);
																	device.method_102(text5);
																	device.method_121(1.0);
																	if (device.method_52("DataClick\\image\\sendcodeotp"))
																	{
																		device.method_3("DataClick\\image\\sendcodeotp");
																	}
																	else
																	{
																		device.method_99("gửi mã đăng nhập");
																	}
																	bool flag25 = false;
																	for (int num54 = 0; num54 < 5; num54++)
																	{
																		text56 = device.method_93();
																		if (device.method_82("nhập mã mà chúng tôi vừa gửi qua tin nhắn văn bản", text56))
																		{
																			flag25 = true;
																			break;
																		}
																	}
																	if (flag25)
																	{
																		method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																		string text83 = string.Empty;
																		if (bool_16)
																		{
																			if (int_37 == 0)
																			{
																				text83 = Common.smethod_26(text60, text61, int_14);
																			}
																			else if (int_37 == 1)
																			{
																				text83 = Common.smethod_28(text60, text9, int_14);
																			}
																			else if (int_37 == 2)
																			{
																				text83 = Common.smethod_27(text60, text61, int_14);
																			}
																			else if (int_37 == 3)
																			{
																				text83 = Common.smethod_45(text60, text61, int_14);
																			}
																			else if (int_37 == 4)
																			{
																				text83 = Common.smethod_46(text60, text61, int_14);
																			}
																			else if (int_37 == 5)
																			{
																				text83 = Common.GetCodeWinMailShop(text60, text61, int_14);
																			}
																			else if (int_37 == 6)
																			{
																				text83 = Common.GetCodeAhasim(text60, text61, int_14);
																			}
																			else if (int_37 == 7)
																			{
																				text83 = Common.GetCodeOtptn(text60, text61, int_14);
																			}
																			else if (int_37 == 8)
																			{
																				text83 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																			}
																			else if (int_37 == 9)
																			{
																				text83 = Common.GetCodeAhasim(text60, text61, int_14);
																			}
																		}
																		else if (string_12.Substring(2, 1) == "0")
																		{
																			text83 = Common.smethod_44(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "1")
																		{
																			text83 = Common.smethod_61(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "2")
																		{
																			text83 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "3")
																		{
																			text83 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "4")
																		{
																			text83 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "5")
																		{
																			text83 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "6")
																		{
																			text83 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "7")
																		{
																			text83 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "8")
																		{
																			text83 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "9")
																		{
																			text83 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "10")
																		{
																			text83 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "11")
																		{
																			text83 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		if (!(text83 != ""))
																		{
																			if (num53 != 5)
																			{
																				if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																				{
																					device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																				}
																				else
																				{
																					device.method_99("cập nhật thông tin liên hệ");
																				}
																				num53++;
																				continue;
																			}
																			method_62(int_41, text3 + "Hết số điện thoại", device);
																			method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		if (device.method_52("DataClick\\image\\inputotpckp"))
																		{
																			device.method_3("DataClick\\image\\inputotpckp");
																		}
																		else
																		{
																			device.method_91(32, 173);
																		}
																		device.method_121(1.0);
																		device.method_102(text83);
																		device.method_121(1.0);
																		device.method_99("\"tiếp\"");
																		bool flag26 = false;
																		for (int num55 = 0; num55 < 20; num55++)
																		{
																			text56 = device.method_93();
																			if (device.method_82("bạn có thể dùng facebook", text56))
																			{
																				flag26 = true;
																				flag4 = true;
																				flag2 = true;
																				break;
																			}
																		}
																		if (flag26)
																		{
																			if (device.method_52("DataClick\\image\\truycapfacebook"))
																			{
																				device.method_3("DataClick\\image\\truycapfacebook");
																			}
																			else
																			{
																				device.method_91(160, 165);
																			}
																			device.method_121(1.0);
																		}
																		else
																		{
																			method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																			method_42(int_41, "Checkpoint");
																			flag5 = true;
																		}
																		goto IL_d388;
																	}
																	if (num53 != 5)
																	{
																		device.method_44("nhập số điện thoại hoặc email mới");
																		num53++;
																		continue;
																	}
																	method_62(int_41, text3 + "Hết số điện thoại", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "API key sai...", device);
																method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															if (text5 == "Đã hết số điện thoại, chờ cập nhật")
															{
																method_62(int_41, text3 + "Hết số điện thoại", device);
																method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															else
															{
																method_62(int_41, text3 + "Hết số điện thoại", device);
																method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															break;
															continue;
														end_IL_b4a0:
															break;
														}
														break;
													}
													if (bool_17 || rdConfMail.Checked)
													{
														if (rdConfMail.Checked)
														{
															if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
															{
																device.method_3("DataClick\\image\\capnhatthongtinlienhe");
															}
															else
															{
																device.method_99("cập nhật thông tin liên hệ");
															}
														}
														int num56 = 0;
														while (true)
														{
															method_62(int_41, text3 + "Đang lấy tempmail.io", device);
															string text84 = "";
															string text85 = method_73();
															if (int_38 == 0)
															{
																text84 = Common.smethod_19(text85);
															}
															if (!(text84 != ""))
															{
																break;
															}
															if (device.method_52("DataClick\\image\\inputsdtemail"))
															{
																device.method_3("DataClick\\image\\inputsdtemail");
																method_62(int_41, text3 + "TempMail:" + text84, device);
																method_52(text84, "email", int_41, 0, dgvAcc);
																device.method_121(1.0);
																device.method_102(text84);
																device.method_121(1.0);
																if (device.method_52("DataClick\\image\\sendcodeotp"))
																{
																	device.method_3("DataClick\\image\\sendcodeotp");
																}
																else
																{
																	device.method_99("gửi mã đăng nhập");
																}
															}
															bool flag27 = false;
															for (int num57 = 0; num57 < 5; num57++)
															{
																text56 = device.method_93();
																if (device.method_82("nhập mã xác nhận", text56))
																{
																	flag27 = true;
																	break;
																}
															}
															if (flag27)
															{
																method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																text86 = Common.smethod_20(method_39(int_41));
																if (!(text86 != ""))
																{
																	if (num56 != 5)
																	{
																		if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																		{
																			device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																		}
																		else
																		{
																			device.method_99("cập nhật thông tin liên hệ");
																		}
																		num56++;
																		continue;
																	}
																	method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_a96f;
																}
																goto IL_b9eb;
															}
															if (num56 != 5)
															{
																if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																{
																	device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																}
																else
																{
																	device.method_99("cập nhật thông tin liên hệ");
																}
																num56++;
																continue;
															}
															method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															goto end_IL_a96f;
														}
													}
												}
												goto IL_bf36;
											IL_9eb2:
												if (!bool_0)
												{
													if (!flag21)
													{
														for (int num58 = 0; num58 < 5; num58++)
														{
															text56 = device.method_93();
															if (!device.method_52("DataClick\\fblite\\yourbirthday"))
															{
																flag23 = false;
																continue;
															}
															flag23 = true;
															break;
														}
														if (flag23)
														{
															method_62(int_41, text3 + "Nhập ngày sinh....", device);
															List<string> list3 = new List<string>();
															list3.Add("160,468");
															list3.Add("54,393");
															list3.Add("160,392");
															list3.Add("267,392");
															list3.Add("53,417");
															list3.Add("160,415");
															list3.Add("268,414");
															list3.Add("52,441");
															list3.Add("160,443");
															list3.Add("268,440");
															List<string> list4 = list3;
															text68 = random_0.Next(1, 12).ToString();
															text67 = random_0.Next(1, 28).ToString();
															text69 = random_0.Next(Convert.ToInt32(DateTime.Now.Year.ToString()) - int_16, Convert.ToInt32(DateTime.Now.Year.ToString()) - int_15).ToString();
															method_52((Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(text69)).ToString(), "age", int_41, 0, dgvAcc);
															if (text68.Length < 2)
															{
																text68 = "0" + text68;
															}
															if (text67.Length < 2)
															{
																text67 = "0" + text67;
															}
															device.method_121(1.0);
															char[] array3 = text67.ToCharArray();
															foreach (char c in array3)
															{
																int index = Convert.ToInt32(c.ToString());
																device.method_47(Convert.ToInt32(list4[index].Split(',')[0]), Convert.ToInt32(list4[index].Split(',')[1]));
															}
															device.method_121(1.0);
															char[] array4 = text68.ToCharArray();
															foreach (char c2 in array4)
															{
																int index2 = Convert.ToInt32(c2.ToString());
																device.method_47(Convert.ToInt32(list4[index2].Split(',')[0]), Convert.ToInt32(list4[index2].Split(',')[1]));
															}
															device.method_121(1.0);
															char[] array5 = text69.ToCharArray();
															foreach (char c3 in array5)
															{
																int index3 = Convert.ToInt32(c3.ToString());
																device.method_47(Convert.ToInt32(list4[index3].Split(',')[0]), Convert.ToInt32(list4[index3].Split(',')[1]));
															}
															device.method_121(1.0);
															if (device.method_52("DataClick\\fblite\\next"))
															{
																device.method_3("DataClick\\fblite\\next");
															}
															device.method_121(1.0);
															if (!bool_0)
															{
																for (int num62 = 0; num62 < 5; num62++)
																{
																	text56 = device.method_93();
																	if (!device.method_52("DataClick\\fblite\\yourgender"))
																	{
																		flag23 = false;
																		continue;
																	}
																	flag23 = true;
																	break;
																}
																if (flag23)
																{
																	method_62(int_41, text3 + "Chọn giới tính....", device);
																	if (text72 == "0")
																	{
																		device.method_91(300, 169);
																	}
																	else if (text72 == "1")
																	{
																		device.method_91(303, 200);
																	}
																	device.method_121(1.0);
																	if (!bool_0)
																	{
																		for (int num63 = 0; num63 < 5; num63++)
																		{
																			text56 = device.method_93();
																			if (!device.method_52("DataClick\\fblite\\createpass"))
																			{
																				flag23 = false;
																				continue;
																			}
																			flag23 = true;
																			break;
																		}
																		if (!flag23)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		goto IL_a53f;
																	}
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Lỗi khi đăng ký", device);
														method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													goto IL_a6c7;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											IL_bf36:
												method_62(int_41, text3 + "Lưu thông tin đăng nhập..", device);
												device.method_91(233, 455);
												while (true)
												{
													if (string_12.Substring(0, 1) == "0" && !flag2)
													{
														if (bool_16)
														{
															device.method_121(1.0);
															device.method_91(53, 292);
															device.method_121(1.0);
															while (true)
															{
																if (num2 == 0)
																{
																	method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																}
																else
																{
																	method_62(int_41, text3 + "Lấy số khác...Lần: " + num2, device);
																	device.method_121(1.0);
																	int tickCount5 = Environment.TickCount;
																	while ((Environment.TickCount - tickCount5) / 1000 - int_39 < 0)
																	{
																		if (!bool_0)
																		{
																			method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount5) / 1000).ToString()), device);
																			continue;
																		}
																		method_62(int_41, "Dừng chạy!", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_c2be;
																	}
																}
																text5 = "";
																if (int_37 == 0)
																{
																	text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																}
																else if (int_37 == 1)
																{
																	text5 = Common.smethod_57(text60, ref text61);
																	text9 = text5;
																}
																else if (int_37 == 2)
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (int_37 == 3)
																{
																	text5 = Common.smethod_48(text60);
																}
																else if (int_37 == 4)
																{
																	text5 = Common.smethod_27(text60, text61);
																}
																else if (int_37 == 5)
																{
																	text5 = Common.smethod_25(text60, text61);
																}
																else if (int_37 == 6)
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (int_37 == 7)
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (int_37 == 8)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																}
																else if (int_37 == 9)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																if (text5 != "")
																{
																	if (!(text5 == "API sai"))
																	{
																		if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																		{
																			if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																			method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																			method_52(text5, "phone", int_41, 0, dgvAcc);
																			device.method_121(1.0);
																			device.method_91(300, 110);
																			device.method_121(1.0);
																			device.method_45();
																			device.method_121(1.0);
																			device.method_49(text5, bool_0: false, bool_1: false);
																			device.method_121(1.0);
																			if (device.method_52("DataClick\\fblite\\next"))
																			{
																				device.method_3("DataClick\\fblite\\next");
																			}
																			bool flag28 = false;
																			for (int num64 = 0; num64 < 10; num64++)
																			{
																				if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																				{
																					flag28 = true;
																					continue;
																				}
																				flag28 = false;
																				break;
																			}
																			if (!flag28)
																			{
																				goto IL_c2cd;
																			}
																			if (num2 != 5)
																			{
																				device.method_121(1.0);
																				device.method_91(53, 292);
																				device.method_121(1.0);
																				device.method_91(300, 110);
																				device.method_121(1.0);
																				device.method_45();
																				num2++;
																				continue;
																			}
																			goto IL_c54b;
																		}
																		goto IL_c574;
																	}
																	method_62(int_41, text3 + "API key sai...", device);
																	method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																if (num2 != 5)
																{
																	num2++;
																	continue;
																}
																goto IL_c5c4;
																continue;
															end_IL_c2be:
																break;
															}
															break;
														}
														if (bool_17)
														{
															device.method_121(1.0);
															device.method_91(53, 321);
															device.method_121(1.0);
															method_62(int_41, text3 + "Đang lấy tempmail.io", device);
															string text87 = "";
															while (true)
															{
																string text88 = method_73();
																if (int_38 == 0)
																{
																	text87 = Common.smethod_19(text88);
																}
																if (text87 != "")
																{
																	method_52(text87, "email", int_41, 0, dgvAcc);
																	device.method_91(300, 110);
																	device.method_121(1.0);
																	device.method_45();
																	device.method_121(1.0);
																	device.method_49(text87, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	if (device.method_52("DataClick\\fblite\\next"))
																	{
																		device.method_3("DataClick\\fblite\\next");
																	}
																	bool flag29 = false;
																	for (int num65 = 0; num65 < 10; num65++)
																	{
																		text56 = device.method_93();
																		if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																		{
																			flag29 = true;
																			continue;
																		}
																		flag29 = false;
																		break;
																	}
																	if (!flag29)
																	{
																		break;
																	}
																	if (num3 != 5)
																	{
																		device.method_121(1.0);
																		device.method_91(53, 321);
																		device.method_121(1.0);
																		device.method_91(300, 110);
																		device.method_121(1.0);
																		device.method_45();
																		num3++;
																		method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																		continue;
																	}
																	goto IL_c5e8;
																}
																if (num3 != 5)
																{
																	num3++;
																	method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																	continue;
																}
																goto IL_c611;
															}
															flag2 = true;
															continue;
														}
														flag2 = false;
														device.method_125();
														goto IL_d388;
													}
													while (true)
													{
														if (rdThuePhone.Checked || bool_16)
														{
															int num66 = 0;
															int num67 = 0;
															while (num67 < 2)
															{
																if (!bool_0)
																{
																	method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																	string text89 = string.Empty;
																	if (rdThuePhone.Checked)
																	{
																		if (string_12.Substring(2, 1) == "0")
																		{
																			text89 = Common.smethod_44(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "1")
																		{
																			text89 = Common.smethod_61(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "2")
																		{
																			text89 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "3")
																		{
																			text89 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "4")
																		{
																			text89 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "5")
																		{
																			text89 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "6")
																		{
																			text89 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "7")
																		{
																			text89 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "8")
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "9")
																		{
																			text89 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "10")
																		{
																			text89 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "11")
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																	}
																	else if (bool_16)
																	{
																		if (int_37 == 0)
																		{
																			text89 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (int_37 == 1)
																		{
																			text89 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (int_37 == 2)
																		{
																			text89 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (int_37 == 3)
																		{
																			text89 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (int_37 == 4)
																		{
																			text89 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (int_37 == 5)
																		{
																			text89 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (int_37 == 6)
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (int_37 == 7)
																		{
																			text89 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (int_37 == 8)
																		{
																			text89 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (int_37 == 9)
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																	}
																	if (text89 == "")
																	{
																		if (!bool_0)
																		{
																			num66++;
																			method_62(int_41, text3 + "Không lấy được mã OTP...", device);
																			if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																			{
																				if (num66 == 5)
																				{
																					flag2 = false;
																					device.method_125();
																				}
																				num67++;
																				continue;
																			}
																			goto IL_c952;
																		}
																		method_62(int_41, text3 + "Dừng chạy...");
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_cdda;
																	}
																	flag2 = true;
																	method_62(int_41, text3 + "Mã OTP:" + text89, device);
																	device.method_91(154, 177);
																	device.method_121(1.0);
																	device.method_49(text89, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	device.method_91(160, 211);
																	break;
																}
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_cdda;
															}
														}
														else if (rdConfMail.Checked)
														{
															method_62(int_41, text3 + "Đang lấy mã OTP...", device);
															if (bool_0)
															{
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															string text90 = string_12.Substring(2, 1);
															if (text90 != null)
															{
																if (!(text90 == "0"))
																{
																	if (!(text90 == "1"))
																	{
																		string text91 = Common.smethod_20(method_39(int_41)); // OTP tempmail.io
																		if (!(text91 != ""))
																		{
																			method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																			flag2 = false;
																			device.method_124();
																			goto IL_d388;
																		}
																		device.method_91(154, 177);
																		device.method_121(1.0);
																		device.method_49(text91, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		device.method_91(160, 211);
																	}
																}
																else
																{
																	string text92 = Common.smethod_31(text6, text7);
																	if (text92 == "")
																	{
																		flag2 = false;
																		method_52("Mail không nhận được OTP. Goto Newfeed", "status", int_41, 2, dgvAcc);
																		device.method_124();
																	}
																	if (text92.Contains("kcon"))
																	{
																		flag2 = false;
																		method_52("Không kê\u0301t nô\u0301i đươ\u0323c server hotmail!", "status", int_41, 2, dgvAcc);
																		device.method_124();
																	}
																	flag2 = true;
																	device.method_121(1.0);
																	device.method_91(154, 177);
																	device.method_121(1.0);
																	device.method_49(text92, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	device.method_91(160, 211);
																}
															}
														}
														else if (bool_17)
														{
															string text93 = Common.smethod_20(method_39(int_41));
															if (!(text93 != ""))
															{
																method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																flag2 = false;
																device.method_124();
																goto IL_d388;
															}
															device.method_91(137, 180);
															device.method_121(1.0);
															flag2 = true;
															device.method_49(text93, bool_0: false, bool_1: false);
															device.method_121(1.0);
															device.method_91(160, 211);
														}
														goto IL_d253;
													IL_d253:
														device.method_121(10.0);
														for (int num68 = 0; num68 < 10; num68++)
														{
															if (device.method_52("DataClick\\fblite\\skip"))
															{
																device.method_3("DataClick\\fblite\\skip");
																break;
															}
														}
														device.method_121(1.0);
														if (device.method_52("DataClick\\fblite\\skip"))
														{
															device.method_3("DataClick\\fblite\\skip");
														}
														device.method_121(5.0);
														text56 = device.method_93();
														if (device.method_82("thêm bạn bè", text56))
														{
															device.method_3("DataClick\\fblite\\skip");
															device.method_121(1.0);
															device.method_91(153, 320);
														}
														device.method_121(1.0);
														device.method_91(133, 311);
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														goto IL_d388;
													IL_c952:
														if (!bool_0)
														{
															device.method_121(1.0);
															device.method_91(53, 292);
															device.method_121(1.0);
															while (true)
															{
																method_62(int_41, text3 + "Đang lấy số điện thoại khác...", device);
																if (!rdThuePhone.Checked)
																{
																	if (bool_16)
																	{
																		if (int_37 == 0)
																		{
																			text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																		}
																		else if (int_37 == 1)
																		{
																			text5 = Common.smethod_57(text60, ref text61);
																			text9 = text5;
																		}
																		else if (int_37 == 2)
																		{
																			text5 = Common.smethod_21(text60, ref text61);
																		}
																		else if (int_37 == 3)
																		{
																			text5 = Common.smethod_48(text60);
																		}
																		else if (int_37 == 4)
																		{
																			text5 = Common.smethod_27(text60, text61);
																		}
																		else if (int_37 == 5)
																		{
																			text5 = Common.smethod_25(text60, text61);
																		}
																		else if (int_37 == 6)
																		{
																			text5 = Common.GetPhoneOtpFb(text60, ref text61);
																		}
																		else if (int_37 == 7)
																		{
																			text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																		}
																		else if (int_37 == 8)
																		{
																			text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																		}
																		else if (int_37 == 9)
																		{
																			text5 = Common.GetPhoneAhasim(text60, ref text61);
																		}
																	}
																}
																else if (string_12.Substring(2, 1) == "0")
																{
																	text5 = Common.smethod_47(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "1")
																{
																	text5 = Common.smethod_57(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "2")
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "3")
																{
																	text5 = Common.smethod_48(text60);
																	text9 = text5;
																}
																else if (string_12.Substring(2, 1) == "4")
																{
																	text5 = Common.smethod_22(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "5")
																{
																	text5 = Common.smethod_23(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "6")
																{
																	text5 = Common.smethod_24(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "7")
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "8")
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "9")
																{
																	text5 = Common.GetPhoneOtptn(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "10")
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "11")
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																if (!(text5 == ""))
																{
																	break;
																}
																if (!bool_0)
																{
																	method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác", device);
																	continue;
																}
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_cdda;
															}
															if (!(text5 == "Đã hết số điện thoại, chờ cập nhật") || !(string_12.Substring(2, 1) == "3"))
															{
																if (!(text5 == "API sai"))
																{
																	if (!bool_0)
																	{
																		if (rdThuePhone.Checked)
																		{
																			if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																			{
																				text5 = "+84" + text5;
																			}
																			if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																		}
																		else if (bool_16)
																		{
																			if (int_37 == 3 || int_37 == 9 || int_37 == 6)
																			{
																				text5 = "+84" + text5;
																			}
																			if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																		}
																		method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																		method_52(text5, "phone", int_41, 0, dgvAcc);
																		device.method_121(1.0);
																		device.method_91(64, 104);
																		device.method_121(1.0);
																		device.method_45();
																		device.method_121(1.0);
																		device.method_49(text5, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		device.method_3("DataClick\\fblite\\next1", null, 5);
																		device.method_121(1.0);
																		continue;
																	}
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "API key sai...Kiểm tra lại", device);
																method_49("API key sai...Kiểm tra lại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															else
															{
																method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
														}
														else
														{
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														}
														goto IL_d253;
														continue;
													end_IL_cdda:
														break;
													}
													break;
												IL_c5c4:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c611:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c574:
													method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c5e8:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_126("");
													goto IL_d388;
												IL_c54b:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_12();
													goto IL_d388;
												IL_c2cd:
													flag2 = true;
												}
												break;
											IL_ac56:
												method_62(int_41, text3 + "Đăng ký thành công..", device);
												flag24 = true;
												goto IL_ac6f;
											IL_ac6f:
												if (!flag24)
												{
													method_62(int_41, text3 + "Đăng ký không thành công..", device);
													method_49("Đăng ký không thành công", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												goto IL_aca6;
											IL_b9eb:
												if (device.method_52("DataClick\\image\\inputotpckp"))
												{
													device.method_3("DataClick\\image\\inputotpckp");
												}
												else
												{
													device.method_91(32, 173);
												}
												device.method_121(1.0);
												device.method_102(text86);
												device.method_99("\"tiếp\"");
												bool flag30 = false;
												for (int num69 = 0; num69 < 20; num69++)
												{
													text56 = device.method_93();
													if (device.method_82("bạn có thể dùng facebook", text56))
													{
														flag30 = true;
														flag4 = true;
														flag2 = true;
														break;
													}
												}
												if (flag30)
												{
													if (device.method_52("DataClick\\image\\truycapfacebook"))
													{
														device.method_3("DataClick\\image\\truycapfacebook");
													}
													else
													{
														device.method_91(160, 165);
													}
													device.method_121(1.0);
													goto IL_d388;
												}
												if (device.method_52("DataClick\\fblite\\yeucauxemxet"))
												{
													device.method_3("DataClick\\fblite\\yeucauxemxet");
												}
												device.method_121(1.0);
												while (true)
												{
													method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
													text5 = "";
													if (!bool_16)
													{
														if (string_12.Substring(2, 1) == "0")
														{
															text5 = Common.smethod_47(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "1")
														{
															text5 = Common.smethod_57(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "2")
														{
															text5 = Common.smethod_21(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "3")
														{
															text5 = Common.smethod_48(text60);
															text9 = text5;
														}
														else if (string_12.Substring(2, 1) == "4")
														{
															text5 = Common.smethod_22(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "5")
														{
															text5 = Common.smethod_23(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "6")
														{
															text5 = Common.smethod_24(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "7")
														{
															text5 = Common.GetPhoneWinMailShop(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "8")
														{
															text5 = Common.GetPhoneAhasim(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "9")
														{
															text5 = Common.GetPhoneOtptn(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "10")
														{
															text5 = Common.GetPhoneOtpFb(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "11")
														{
															text5 = Common.GetPhoneAhasim(text60, ref text61);
														}
													}
													else if (int_37 == 0)
													{
														text5 = Common.smethod_21(text60, ref text61);
													}
													else if (int_37 == 1)
													{
														text5 = Common.smethod_48(text60);
														text9 = text5;
													}
													else if (int_37 == 2)
													{
														text5 = Common.smethod_22(text60, ref text61);
													}
													else if (int_37 == 3)
													{
														text5 = Common.smethod_23(text60, ref text61);
													}
													else if (int_37 == 4)
													{
														text5 = Common.smethod_24(text60, ref text61);
													}
													else if (int_37 == 5)
													{
														text5 = Common.GetPhoneWinMailShop(text60, ref text61);
													}
													else if (int_37 == 6)
													{
														text5 = Common.GetPhoneAhasim(text60, ref text61);
													}
													else if (int_37 == 7)
													{
														text5 = Common.GetPhoneOtptn(text60, ref text61);
													}
													else if (int_37 == 8)
													{
														text5 = Common.GetPhoneOtpFb(text60, ref text61);
													}
													else if (int_37 == 9)
													{
														text5 = Common.GetPhoneAhasim(text60, ref text61);
													}
													if (text5 != "")
													{
														break;
													}
													device.method_91(270, 195);
													device.method_45();
												}
												if (bool_0)
												{
													method_62(int_41, text3 + "Dừng chạy...", device);
													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												if (rdThuePhone.Checked)
												{
													if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
													{
														text5 = "+84" + text5;
													}
													if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
													{
														text5 = "+84" + text5; // truoc la +1
													}
												}
												else if (bool_16)
												{
													if (int_37 == 3 || int_37 == 9 || int_37 == 6)
													{
														text5 = "+84" + text5;
													}
													if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
													{
														text5 = "+84" + text5; // truoc la +1
													}
												}
												device.method_91(270, 195);
												device.method_121(1.0);
												device.method_49(text5, bool_0: false, bool_1: false);
												device.method_121(1.0);
												device.method_91(160, 382);
												goto IL_bf36;
											IL_a6c7:
												while (true)
												{
													flag24 = false;
													method_62(int_41, text3 + "Check status đăng ký....", device); //fblite
													if (flag21)
													{
														device.method_121(10.0);
													}
													int num70 = 0;
													while (true)
													{
														text56 = device.method_93();
														if (!bool_0)
														{
															if (num70 != 30)
															{
																num70++;
																if (!device.method_52("DataClick\\fblite\\luuthongtindangnhap"))
																{
																	if (!device.method_82("we need more information", text56) && !device.method_82("Something went wrong. Please try again.", text56) && !device.method_82("chúng tôi cần thêm thông tin", text56))
																	{
																		if (device.method_52("DataClick\\fblite\\yourphone"))
																		{
																			goto IL_a6eb;
																		}
																		if (device.method_52("DataClick\\fblite\\whatyourname"))
																		{
																			goto IL_a686;
																		}
																		if (!device.method_52("DataClick\\fblite\\createpass"))
																		{
																			continue;
																		}
																		goto IL_a50c;
																	}
																	goto giaicp282; 
																}
																goto IL_ac56;
															}
															method_62(int_41, text3 + "Không check được status...");
															method_49("Không check được status đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Stop run...", device);
														method_49("Stop run", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													break;
												IL_a686:
													method_62(int_41, text3 + "Trùng tên...", device);
													flag21 = true;
													device.method_91(175, 180);
												}
												break;
											IL_a53f:
												method_62(int_41, text3 + "Nhập mật khẩu....", device);
												device.method_46("shell ime set cz.october.app/.KeyboardReceiver");
												device.method_91(44, 176);
												device.method_121(1.0);
												device.method_45();
												device.method_121(1.0);
												device.method_49(text59, bool_0: false, bool_1: false);
												device.method_121(1.0);
												if (device.method_52("DataClick\\fblite\\next"))
												{
													device.method_3("DataClick\\fblite\\next");
												}
												device.method_121(1.0);
												if (!bool_0)
												{
													if (flag22)
													{
														device.method_121(10.0);
													}
													else
													{
														for (int num71 = 0; num71 < 5; num71++)
														{
															text56 = device.method_93();
															if (!device.method_52("DataClick\\fblite\\confirmregist"))
															{
																flag23 = false;
																continue;
															}
															flag23 = true;
															break;
														}
														if (!flag23)
														{
															method_62(int_41, text3 + "Error when register", device);
															method_49("Error when register", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Đăng ký....", device);
                                                        if (device.method_52("DataClick\\fblite\\register"))
                                                        {
                                                            device.method_3("DataClick\\fblite\\register");
                                                        }
                                                        else
                                                        { 
															device.method_91(160, 233);
														}
                                                        //if (!device.method_52("DataClick\\fblite\\confirmregist"))
                                                        //{
                                                        //KAutoHelper.ADBHelper.TapByPercent(device, 160, 231);
														device.method_121(1.0);
														//}

													}
													goto IL_a6c7;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
												continue;
											end_IL_a96f:
												break;
											}
										}
										else
										{
											method_62(int_41, text3 + "Không mở được app Facebook lite");
											method_49("Không mở được app Facebook lite", device.int_0, int_41, int_42, device, bool_18: false);
										}
									}
									catch
									{
										method_62(int_41, text3 + "Lỗi treo LD");
										method_49("Lỗi treo LD", device.int_0, int_41, int_42, device, bool_18: false);
									}
									goto end_IL_1d06;
								IL_25fa:
									device.method_1("com.cell47.College_Proxy");
									method_62(int_41, text3 + "Đang kết nối proxy...", device);
									switch (int_9)
									{
										case 2:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 3:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 5:
											if (rdIPDong.Checked)
											{
												if (!method_88(device, text2))
												{
													method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
													method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
													goto end_IL_1928;
												}
												text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
												break;
											}
											device.method_4(text2);
											break;
										case 6:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 7:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 8:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 9:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											device.method_4(text2);
											break;
									}
									goto IL_2876;
								IL_24d0:
									if (!flag10)
									{
										method_62(int_41, text3 + "Cài đặt các ứng dụng không thành công", device);
										method_49("Cài đặt các ứng dụng không thành công", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (Settings.Default.isOnGPSLD)
									{
										device.method_85("shell settings put secure location_providers_allowed +gps");
									}
									else
									{
										device.method_85("shell settings put secure location_providers_allowed -gps");
									}
									device.method_6();
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (!(text2 != ""))
									{
										goto IL_2876;
									}
									if (device.list_0.Contains("com.cell47.College_Proxy"))
									{
										goto IL_25fa;
									}
									method_62(int_41, text3 + "Cài đặt App Proxy...", device);
									while (true)
									{
										if (!bool_0)
										{
											flag10 = false;
											if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\collegeproxy.apk")))
											{
												continue;
											}
											goto IL_25fa;
										}
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
								end_IL_1d06:;
								}
								catch (Exception ex4)
								{
									method_62(int_41, text3 + "Lỗi khi đăng ký. Lỗi: " + ex4.Message, device);
									method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
								}
							}
                     /*8985*/       else
                            {
								try
								{
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										break;
									}
									if (bool_18)
									{
										method_22(int_41, "cDevice", int_42.ToString());
										device = new Device(string_21, int_42.ToString() ?? "", string_18);
										goto IL_1f3e;
									}
									string text11 = method_1(int_41, "cDevice");
									if (text11 == "" || !Directory.Exists(string_21 + "\\vms\\leidian" + text11))
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										method_62(int_41, text3 + "Tạo thiết bị, chờ đến lượt...", device);
										object obj = object_3;
										lock (obj)
										{
											method_62(int_41, text3 + "Tạo thiết bị...", device);
											List<string> second = Class2.smethod_31(string_21);
											Class2.smethod_29(string_21);
											int num7 = 0;
											while (true)
											{
												if (num7 >= 30)
												{
													goto IL_1e63;
												}
												if (!bool_0)
												{
													text11 = Class2.smethod_31(string_21).Except(second).First();
													if (!(text11 != ""))
													{
														num7++;
														continue;
													}
													goto IL_1e63;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1d06;
											IL_1e63:
												if (text11 == "")
												{
													method_62(int_41, text3 + "Tạo thiết bị thất bại!");
													method_49("Tạo LD thất bại", device.int_0, int_41, int_42, device, bool_18: false);
													goto end_IL_1928;
												}
												break;
											}
										}
										device = new Device(string_21, text11, string_18);
										device.PathLDPlayer = string_21;
										method_22(int_41, "cDevice", text11);
										method_62(int_41, text3 + "Cấu hình LDPlayer...");
										device.method_117();
										device.method_116();
										goto IL_1f3e;
									}
									device = new Device(string_21, text11 ?? "", string_18);
									goto IL_1f3e;
								IL_1f3e:
									device.method_117();
									device.method_116();
									method_62(int_41, text3 + "Chờ đến lượt...");
									object obj2 = object_2;
									lock (obj2)
									{
										if (int_2 == 0)
										{
											do
											{
												if (bool_9)
												{
													Common.smethod_62(0.5);
													continue;
												}
												bool_9 = true;
												break;
											}
											while (!bool_0);
										}
										else if (int_18 > 0)
										{
											int num8 = random_0.Next(int_3, int_4);
											if (num8 > 0)
											{
												int tickCount = Environment.TickCount;
												while ((Environment.TickCount - tickCount) / 1000 - num8 < 0)
												{
													method_62(int_41, text3 + "Mở thiê\u0301t bi\u0323 sau {time}s...".Replace("{time}", (num8 - (Environment.TickCount - tickCount) / 1000).ToString()));
													Common.smethod_62(0.5);
													if (!bool_0)
													{
														continue;
													}
													method_62(int_41, text3 + "Dừng chạy...", device);
													goto end_IL_1d06;
												}
											}
										}
										else
										{
											int_18++;
										}
									}
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...");
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									method_62(int_41, text3 + "Mở thiết bị...");
									device.method_118();
									if (device.process == null)
									{
										method_62(int_41, text3 + "Lỗi mở thiết bị");
										method_49("Lỗi mở LD", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									text8 = device.method_114();
									frmViewLD.frmViewLD_0.method_9(device.process.MainWindowHandle, device.int_0, int_41 + 1, text8);
									if (!device.method_11())
									{
										method_62(int_41, text3 + "Lỗi mở thiết bị");
										method_49("Lỗi mở LD", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									method_62(int_41, text3 + "Mở thiết bị thành công", device);
									list_4.Add(device);
									method_51(5.0);
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									text = (device.DeviceId = Class2.smethod_36(device.int_0));
									device.list_0 = device.method_108();
									bool flag10 = true;
									try
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										method_62(int_41, text3 + "Kiểm tra App cần cài đặt", device);
										if (Settings.Default.typeRunApp == 0)
										{
											if (device.list_0.Contains("com.facebook.katana"))
											{
												goto IL_2311;
											}
											method_62(int_41, text3 + "Cài đặt App Facebook Katana...", device);
											while (true)
											{
												if (!bool_0)
												{
													flag10 = false;
													if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\facebook.apk")))
													{
														continue;
													}
													goto IL_2311;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											break;
										}
										if (device.list_0.Contains("com.facebook.lite"))
										{
											goto IL_2413;
										}
										method_62(int_41, text3 + "Cài đặt App Facebook Lite...", device);
										while (true)
										{
											if (!bool_0)
											{
												flag10 = false;
												if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\facebooklite.apk")))
												{
													continue;
												}
												goto IL_2413;
											}
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										goto end_IL_2237;
									IL_2311:
										if (!device.list_0.Contains("com.android.adbkeyboard"))
										{
											method_62(int_41, text3 + "Cài đặt App Keyboard...", device);
											while (true)
											{
												if (!bool_0)
												{
													flag10 = false;
													if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\ADBKeyboard.apk")))
													{
														continue;
													}
													goto IL_24d0;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											break;
										}
										goto IL_24d0;
									IL_2413:
										if (device.list_0.Contains("cz.october.app"))
										{
											goto IL_2491;
										}
										method_62(int_41, text3 + "Cài đặt App Keyboard...", device);
										while (true)
										{
											if (!bool_0)
											{
												flag10 = false;
												if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\keyboard.apk")))
												{
													continue;
												}
												goto IL_2491;
											}
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										goto end_IL_2237;
									IL_2491:
										device.method_46("shell ime set cz.october.app/.KeyboardReceiver");
										goto IL_24d0;
									end_IL_2237:;
									}
									catch
									{
										method_62(int_41, text3 + "Cài đặt các ứng dụng không thành công", device);
										method_49("Cài đặt các ứng dụng không thành công", device.int_0, int_41, int_42, device, bool_18: false);
									}
									goto end_IL_1d06;
								IL_2876:
									if (text10 != "")
									{
										method_62(int_41, text3 + "Lỗi treo LD khi kết nối proxy");
										method_49("Lỗi treo LD khi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (Settings.Default.typeRunApp == 0)
									{
										while (true)
										{
										IL_909d:
											method_62(int_41, text3 + "Mở App Facebook Katana", device);
											device.method_39();
											try
											{
												if (bool_0)
												{
													method_62(int_41, text3 + "Dừng chạy...", device);
													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												if (device.method_95())
												{
													string text13 = string.Empty;
													bool flag11 = true;
													if (!rdThuePhone.Checked || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "2")
													{
													}
													method_62(int_41, text3 + "Đăng ký Facebook Katana", device);
													for (int i = 0; i < 20; i++)
													{
														if (device.method_91(158, 377))
														{
															flag11 = true;
															break;
														}
													}
													if (!flag11)
													{
														method_62(int_41, text3 + "Lỗi khi đăng ký", device);
														method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...");
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													int num9 = 0;
													while (true)
													{
														if (num9 < 30)
														{
															text13 = device.method_93();
															if (device.method_120(text13).Count == 1)
															{
																num9++;
																continue;
															}
															if (device.method_82("join facebook", text13) || device.method_82("tham gia facebook", text13))
															{
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																flag11 = true;
																if (device.method_82("\"next\"", text13))
																{
																	device.method_99("\"next\"");
																}
																else
																{
																	device.method_99("\"tiếp\"");
																}
															}
															else
															{
																flag11 = false;
															}
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Tạo thông tin đăng ký", device);
														string text14 = "";
														string text15 = "";
														string text16 = "";
														string text17 = "";
														string text18 = "";
														string text19 = "";
														string text20 = "";
														string text21 = "";
														string text22 = "";
														string text23 = "";
														string text24 = "";
														string text25 = "";
														string text26 = "";
														string[] array = new string[11]
														{
													"thg 1", "thg 2", "thg 3", "thg 4", "thg 5", "thg 6", "thg 7", "thg 8", "thg 10", "thg 11",
													"thg 12"
														};
														string text27 = random_0.Next(0, 2).ToString();
														string text28 = "";
														string text29 = "";
														if (int_13 == 0)
														{
															text27 = "0";
														}
														else if (int_13 == 1)
														{
															text27 = "1";
														}
														if (int_12 == 0)
														{
															text14 = method_6();
															text15 = ((!(text27 == "0")) ? method_7() : method_8());
														}
														else if (int_12 == 1)
														{
															text14 = method_3();
															text15 = ((!(text27 == "0")) ? method_5() : method_4());
														}
														else if (int_12 == 2)
														{
															text14 = method_9();
															text15 = ((!(text27 == "0")) ? method_10() : method_11());
															text28 = method_3();
															text29 = ((!(text27 == "0")) ? method_5() : method_4());
														}
														text16 = ((int_12 == 2) ? ((!bool_5) ? string_14.Trim() : Common.smethod_75(text29 + text28)) : ((!bool_5) ? string_14.Trim() : Common.smethod_75(text15 + text14)));
														text24 = random_0.Next(1, 28).ToString();
														text25 = array[random_0.Next(0, 11)].ToString();
														text26 = random_0.Next(Convert.ToInt32(DateTime.Now.Year.ToString()) - int_16, Convert.ToInt32(DateTime.Now.Year.ToString()) - int_15).ToString();
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_52(text14, "ho", int_41, 0, dgvAcc);
														method_52(text15, "ten", int_41, 0, dgvAcc);
														method_52((text27 == "1") ? "Nam" : "Nữ", "gender", int_41, 0, dgvAcc);
														method_52(text16, "pass", int_41, 0, dgvAcc);
														method_52((Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(text26)).ToString(), "age", int_41, 0, dgvAcc);
														text17 = string_11;
														if (bool_16)
														{
															text17 = string_20;
														}
														try
														{
															for (int j = 0; j < 5; j++)
															{
																if (!bool_0)
																{
																	text13 = device.method_93();
																	if (device.method_120(text13).Count == 1)
																	{
																		continue;
																	}
																	if (device.method_82("enter the name you use in real life.", text13) || device.method_82("nhập tên bạn sử dụng trong đời thực", text13))
																	{
																		flag11 = true;
																		if (device.method_82("nhập tên bạn sử dụng trong đời thực", text13))
																		{
																			method_62(int_41, text3 + "Nhập họ", device);
																			device.method_100(text14);
																			device.method_121(1.0);
																			method_62(int_41, text3 + "Nhập tên...", device);
																			device.method_121(1.0);
																			if (device.method_82("\"last name\"", text13))
																			{
																				device.method_99("\"last name\"", text13);
																			}
																			else if (device.method_52("DataClick\\image\\ten"))
																			{
																				device.method_3("DataClick\\image\\ten");
																			}
																			else
																			{
																				ADBHelper.TapByPercent(text, 59.5, 42.9);
																			}
																			device.method_121(1.0);
																			device.method_100(text15);
																			break;
																		}
																		method_62(int_41, text3 + "Nhập tên", device);
																		device.method_121(1.0);
																		device.method_100(text15);
																		device.method_121(1.0);
																		method_62(int_41, text3 + "Nhập họ...", device);
																		device.method_121(1.0);
																		if (device.method_82("\"last name\"", text13))
																		{
																			device.method_99("\"last name\"", text13);
																		}
																		else if (device.method_52("DataClick\\image\\ten"))
																		{
																			device.method_3("DataClick\\image\\ten");
																		}
																		else
																		{
																			ADBHelper.TapByPercent(text, 59.5, 42.9);
																		}
																		device.method_121(1.0);
																		device.method_100(text14);
																	}
																	else
																	{
																		flag11 = false;
																	}
																	break;
																}
																method_62(int_41, text3 + "Dừng chạy...");
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_2a36;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														device.method_121(1.0);
														if (device.method_82("\"next\""))
														{
															device.method_99("\"next\"");
														}
														else
														{
															device.method_99("\"tiếp\"");
														}
														try
														{
															method_62(int_41, text3 + "Chọn ngày tháng năm sinh...", device);
															int num10 = 0;
															while (true)
															{
																if (num10 < 10)
																{
																	text13 = device.method_93();
																	//if (!device.method_82("sinh nhật của bạn khi nào?", text13))
																	//{
																	//    flag11 = false;
																	//    num10++;
																	//    continue;
																	//}
																	//if (bool_0)
																	//{
																	//    method_62(int_41, text3 + "Dừng chạy...");
																	//    method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	//    break;
																	//}
																	flag11 = true;
																	if (device.method_82("\"select birthday\"", text13))
																	{
																		device.method_99("\"select birthday\"", text13);
																	}
																	else if (device.method_82("\"chọn ngày sinh\"", text13))
																	{
																		device.method_99("\"chọn ngày sinh\"", text13);
																	}
																	else
																	{
																		ADBHelper.TapByPercent(text, 49.8, 41.0);
																	}
																	device.method_121(1.0);
																}
																if (flag11)
																{
																	device.method_91(108, 247); // Ngay
																	device.method_100(text24);
																	device.method_121(1.0);
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		break;
																	}
																	device.method_7(156, 246); // Thang
																	device.method_100(text25);
																	device.method_121(1.0);
																	device.method_91(206, 247);// Nam
																	device.method_100(text26);
																	device.method_121(1.0);
																	device.method_99("\"ok\"", "", 10);
																	device.method_121(1.0);
																	if (device.method_82("\"next\"", text13))
																	{
																		device.method_99("\"next\"", "", 10);
																	}
																	else
																	{
																		device.method_99("\"tiếp\"", "", 10);
																	}
																	flag11 = true;
																}
																goto IL_3513;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														}
														break;
													IL_3513:
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														try
														{
															for (int k = 0; k < 10; k++)
															{
																text13 = device.method_93();
																if (device.method_120(text13).Count == 1)
																{
																	continue;
																}
																if (device.method_82("what's your gender?", text13) || device.method_82("giới tính của bạn là gì?", text13))
																{
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_2a36;
																	}
																	method_62(int_41, text3 + "Chọn giới tính...", device);
																	if (text27 == "0")
																	{
																		device.method_91(38, 183);
																	}
																	else if (text27 == "1")
																	{
																		device.method_91(30, 223);
																	}
																	flag11 = true;
																	device.method_121(1.0);
																	if (device.method_82("\"next\"", text13))
																	{
																		device.method_99("\"next\"", "", 10);
																	}
																	else
																	{
																		device.method_99("\"tiếp\"", "", 10);
																	}
																}
																else
																{
																	flag11 = false;
																}
																break;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (!flag11)
														{
															method_62(int_41, text3 + "Lỗi khi đăng ký", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															flag11 = false;
															break;
														}
														while (true)
														{
														IL_3756:
															try
															{
																for (int l = 0; l < 10; l++)
																{
																	text13 = device.method_93();
																	if (device.method_120(text13).Count == 1)
																	{
																		continue;
																	}
																	if (!device.method_82("enter your mobile number", text13) && !device.method_82("nhập số di động của bạn", text13) && !device.method_82("nhập địa chỉ email của bạn", text13))
																	{
																		flag11 = false;
																		continue;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...");
																		flag11 = false;
																		break;
																	}
																	if (string_12.Substring(0, 1) == "0")
																	{
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			flag11 = false;
																			break;
																		}
																		if (string_12.Substring(1, 1) == "0")
																		{
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...");
																				flag11 = false;
																				break;
																			}
																			method_62(int_41, text3 + "Đang tạo số điện thoại ảo....", device);
																			if (device.method_52("DataClick\\image\\x"))
																			{
																				device.method_3("DataClick\\image\\x");
																			}
																			else
																			{
																				device.method_91(295, 209);
																			}
																			text23 = method_72(int_21);
																			if (text23 == string.Empty)
																			{
																				method_62(int_41, text3 + "Không tạo được số điện thoại ảo...", device);
																				flag11 = false;
																				return;
																			}
																			method_51(2.0);
																			flag11 = true;
																			method_62(int_41, text3 + "Số điện thoại ảo:" + text23, device);
																			method_52(text23, "phone", int_41, 0, dgvAcc);
																			device.method_100(text23);
																			flag2 = false;
																			break;
																		}
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (device.method_82("\"đăng ký bằng địa chỉ email\"", null, 10.0))
																		{
																			device.method_99("\"đăng ký bằng địa chỉ email\"", "", 10);
																		}
																		else if (device.method_82("\"sign up with email address\"", null, 10.0))
																		{
																			device.method_99("\"sign up with email address\"", "", 10);
																		}
																		if (Convert.ToInt32(string_12.Substring(2, 1)) != 3)
																		{
																			method_62(int_41, text3 + "Đang tạo Email ảo....", device);
																			text22 = method_76(text15, text14, Convert.ToInt32(string_12.Substring(2, 1)));
																		}
																		else
																		{
																			method_62(int_41, text3 + "Đang lấy mail từ Temp-mail.io....", device);
																			string text30 = method_73();
																			text22 = Common.smethod_19(text30);
																		}
																		if (text22 == string.Empty)
																		{
																			method_62(int_41, text3 + "Không tạo được email ảo...", device);
																			method_49("Không tạo được email ảo", device.int_0, int_41, int_42, device, bool_18: false);
																			flag11 = false;
																		}
																		else
																		{
																			method_51(2.0);
																			flag11 = true;
																			method_62(int_41, text3 + "Email ảo:" + text22, device);
																			method_52(text22, "email", int_41, 0, dgvAcc);
																			device.method_100(text22);
																		}
																		break;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		flag11 = false;
																		break;
																	}
																	if (rdThuePhone.Checked)
																	{
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			flag11 = false;
																			break;
																		}
																		try
																		{
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				flag11 = false;
																				break;
																			}
																			int num11 = 0;
																			while (true)
																			{
																				if (num11 != 2)
																				{
																					method_62(int_41, text3 + "Đang lấy số điện thoại....", device);
																					if (device.method_52("DataClick\\image\\x"))
																					{
																						device.method_3("DataClick\\image\\x");
																					}
																					else
																					{
																						device.method_91(295, 209);
																					}
																					if (string_12.Substring(2, 1) == "0")
																					{
																						text5 = Common.smethod_47(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "1")
																					{
																						text5 = Common.smethod_57(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "2")
																					{
																						text5 = Common.smethod_21(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "3")
																					{
																						text5 = Common.smethod_48(text17);
																						text9 = text5;
																					}
																					else if (string_12.Substring(2, 1) == "4")
																					{
																						text5 = Common.smethod_22(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "5")
																					{
																						text5 = Common.smethod_23(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "6")
																					{
																						text5 = Common.smethod_24(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "7")
																					{
																						text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "8") //Ahasim ne
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "9")
																					{
																						text5 = Common.GetPhoneOtptn(text17, ref text18);
																					}
																					else if (string_12.Substring(2, 1) == "10")
																					{
																						text5 = Common.GetPhoneOtpFb(text17, ref text18); //1
																					}
																					else if (string_12.Substring(2, 1) == "11")
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18); //1
																					}
																					if (!bool_0)
																					{
																						if (text5 == "")
																						{
																							num11++;
																							method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác!!!", device);
																							device.method_121(2.0);
																							continue;
																						}
																						if (text5 == "Đã hết số điện thoại, chờ cập nhật" && string_12.Substring(2, 1) == "3")
																						{
																							method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																							flag11 = false;
																							break;
																						}
																						if (text5 == "API sai" && string_12.Substring(2, 1) == "3")
																						{
																							method_62(int_41, text3 + "API sai. Kiểm tra lại API key..", device);
																							flag11 = false;
																							break;
																						}
																						if (bool_0)
																						{
																							method_62(int_41, text3 + "Dừng chạy...", device);
																							flag11 = false;
																							break;
																						}
																						if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																						{
																							text5 = "+84" + text5;
																						}
																						if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																						{
																							text5 = "+84" + text5; // truoc la +1
																						}
																						method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																						method_52(text5, "phone", int_41, 0, dgvAcc);
																						device.method_100(text5);
																						flag2 = true;
																						goto IL_4cf7;
																					}
																					method_62(int_41, text3 + "Dừng chạy...");
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_3756;
																				}
																				flag11 = false;
																				method_62(int_41, text3 + "Đã hết số điện thoại", device);
																				break;
																			}
																		}
																		catch
																		{
																			method_62(int_41, text3 + "Lỗi khi lấy số điện thoại", device);
																			flag11 = false;
																		}
																		break;
																	}
																	if (!rdConfMail.Checked)
																	{
																		break;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...");
																		flag11 = false;
																		break;
																	}
																	if (num4 == 0)
																	{
																		if (device.method_82("\"đăng ký bằng địa chỉ email\"", "", 10.0))
																		{
																			device.method_99("\"đăng ký bằng địa chỉ email\"", "", 10);
																		}
																		else if (device.method_82("\"sign up with email address\"", "", 10.0))
																		{
																			device.method_99("\"sign up with email address\"", "", 10);
																		}
																	}
																	string text31 = string_12.Substring(2, 1);
																	int num12 = 0;
																	if (text31 == null)
																	{
																		break;
																	}
																	if (!(text31 == "0"))
																	{
																		if (!(text31 == "1"))
																		{
																			method_62(int_41, text3 + "Đang lấy Mailtm...", device);
																			while (true)
																			{
																				string text32 = method_73();
																				string text33 = Common.smethod_19(text32);
																				if (!(text33 != ""))
																				{
																					if (num12 != 5)
																					{
																						num12++;
																						continue;
																					}
																					method_62(int_41, text3 + "Lỗi không lấy được Mailtm...", device);
																					flag11 = false;
																					//goto end_IL_37d2;
																					break;
																				}
																				method_52(text33, "email", int_41, 0, dgvAcc);
																				flag2 = true;
																				device.method_100(text33);
																				device.method_121(1.0);
																				//if (num4 == 0)
																				//{
																				//	break;
																				//}
																				//if (device.method_82("\"next\""))
																				//{
																				//	device.method_99("\"next\"", "", 10);
																				//}
																				//else
																				//{
																				//	device.method_99("\"tiếp\"", "", 10);
																				//}
																				goto IL_4cf7;
																			}
																		}
																		else
																		{
																			string text34 = list_1[int_41];
																			if (!(text34 != ""))
																			{
																				break;
																			}
																			method_62(int_41, text3 + "Nhập hotmail có sẵn....", device);
																			text6 = text34.Split('|')[0];
																			text7 = text34.Split('|')[1];
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_3756;
																			}
																			method_52(text6, "email", int_41, 0, dgvAcc);
																			method_52(text7, "passMail", int_41, 0, dgvAcc);
																			device.method_100(text6);
																			flag2 = true;
																			device.method_121(1.0);
																			goto IL_4cf7; // Next
																		}
																	}
																	else
																	{
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...");
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		method_51(2.0);
																		method_62(int_41, text3 + "Đăng ký hotmail....", device); // Fb Katana
																		while (!method_85(int_41))
																		{
																			method_52("Đang tạo lại mail khác", "status", int_41, 0, dgvAcc);
																			flag11 = false;
																		}
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			flag11 = false;
																			break;
																		}
																		text6 = method_39(int_41); // Xuất Email
																		text7 = method_40(int_41); // Xuất Passmail
																		File.AppendAllText("output/facebook/hotmail.txt", string.Concat(new string[4]
																		{
																	text6,
																	"|",
																	text7,
																	Environment.NewLine
																		}));
																		device.method_100(text6);
																		goto IL_4cf7;

																		flag2 = true;
																		device.method_121(1.0);

																		//continue; // Fb katana

																	}
																}
															}
															catch
															{
																method_62(int_41, text3 + "Tạo tài khoản thất bại", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															if (!flag11)
															{
																method_62(int_41, text3 + "Tạo tài khoản thất bại", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															goto IL_4cf7;
														IL_4cf7:
															if (!bool_0)
															{
																if (device.method_82("\"next\""))
																{
																	device.method_99("\"next\"", "", 10);
																}
																else
																{
																	device.method_99("\"tiếp\"", "", 10);
																}
																try
																{
																	for (int m = 0; m < 5; m++)
																	{
																		text13 = device.method_93();
																		if (device.method_120(text13).Count == 1)
																		{
																			continue;
																		}
																		if (device.method_82("choose a password", text13) || device.method_82("chọn mật khẩu", text13))
																		{
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_3756;
																			}
																			flag11 = true;
																			method_62(int_41, text3 + "Nhập mật khẩu...", device);
																			device.method_102(text16.Trim());
																			device.method_121(1.0);
																			if (device.method_82("\"next\""))
																			{
																				device.method_99("\"next\"", "", 10);
																			}
																			else
																			{
																				device.method_99("\"tiếp\"", "", 10);
																			}
																		}
																		else
																		{
																			flag11 = false;
																		}
																		break;
																	}
																}
																catch
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																if (flag11)
																{
																	if (!bool_0)
																	{
																		int num13 = 0;
																		while (true)
																		{
																			if (num13 < 5)
																			{
																				text13 = device.method_93();
																				if (device.method_120(text13).Count == 1)
																				{
																					num13++;
																					continue;
																				}
																				if (device.method_82("finish signing up", text13) || device.method_82("hoàn tất đăng ký", text13))
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					flag11 = true;
																					method_62(int_41, text3 + "Đăng ký...", device);
																					device.method_121(2.0);
																					if (device.method_82("\"sign up\""))
																					{
																						device.method_99("\"sign up\"");
																					}
																					else
																					{
																						device.method_99("\"đăng ký\"");
																					}
																				}
																				else
																				{
																					flag11 = false;
																				}
																			}
																			if (flag11)
																			{
																				if (!bool_0)
																				{
																					break;
																				}
																				method_62(int_41, text3 + "Dừng chạy...");
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			else
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			goto end_IL_3756;
																		}
																		goto IL_4ccc;
																	}
																	method_62(int_41, text3 + "Dừng chạy...");
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														IL_4ccc:
															while (true)
															{
															IL_4ccc_2:
																device.method_121(1.0);
																method_62(int_41, text3 + "Check status đăng ký...", device);
																int num14 = 0;
																try
																{
																	while (true)
																	{
																		if (!bool_0)
																		{
																			if (num14 != 30)
																			{
																				num14++;
																				text13 = device.method_93();
																				if (device.method_120(text13).Count == 1)
																				{
																					continue;
																				}
																				if (!bool_0)
																				{
																					if (device.method_82("bạn đã có tài khoản facebook chưa?", text13) || device.method_82("do you already have a facebook account?", text13))
																					{
																						if (device.method_82("no, create new account", text13))
																						{
																							device.method_99("no, create new account", "", 10);
																						}
																						else
																						{
																							device.method_99("không, tạo tài khoản mới", "", 10);
																						}
																						goto IL_4ccc_2;
																					}
																					if (device.method_82("use a different name", text13) || device.method_82("chọn tên của bạn", text13) || device.method_82("bạn tên gì?", text13))
																					{
																						flag11 = false;
																						method_62(int_41, text3 + "Trùng tên...thực hiện đăng ký lại", device);
																						if (device.method_52("DataClick\\image\\tenkhac"))
																						{
																							device.method_3("DataClick\\image\\tenkhac");
																						}
																						else
																						{
																							device.method_91(299, 232); // Click vao vi tri xuat hien tren man hinh
																						}
																						//if (device.method_82("\"next\""))
																						//{
																						//	device.method_99("\"next\"", "", 10);
																						//}
																						//else
																						//{
																						//	device.method_99("\"tiếp\"", "", 10);
																						//}
																						if (device.method_52("DataClick\\image\\next"))
																						{
																							device.method_3("DataClick\\image\\next");
																						}
																						else
																						{
																							device.method_91(161, 315); // Click vao vi tri xuat hien tren man hinh
																						}
																						//device.method_70();
																						device.method_121(1.0);
																						goto IL_4ccc_2;
																						//goto end_IL_4ccc;
																					}
																					if (!device.method_82("next time, log in with one tap", text13) && !device.method_82("lần sau, đăng nhập bằng một lần nhấn", text13))
																					{
																						if (device.method_82("enter your mobile number", text13) || device.method_82("nhập số di động của bạn", text13))
																						{
																							method_62(int_41, text3 + "Lỗi xác nhận số điện thoại. Tạo lại...", device);
																							device.method_70();
																							device.method_121(1.0);
																							goto end_IL_4ccc;
																						}
																						if (!device.method_82("do you already have a facebook account?", text13) && !device.method_82("bạn đã có tài khoản facebook chưa?", text13))
																						{
																							if (!device.method_82("the action attempted has been deemed abusive or is otherwise disallowed", text13) && !device.method_82("an unknown error occurred", text13) && !device.method_82("we couldn't create your account", text13) && !device.method_82("chúng tôi không thể tạo tài khoản của bạn", text13) && !device.method_82("một lỗi không xác định đã xảy ra", text13) && !device.method_82("hành động đã cố gắng bị coi là lạm dụng hoặc không được phép", text13) && !device.method_82("gần đây số điện thoại bạn đang cố gắng xác minh đã được sử dụng để xác minh một tài khoản khác. Vui lòng thử số khác.", text13))
																							{
																								if (device.method_82("we need more information", text13) || device.method_82("Something went wrong. Please try again.", text13) || device.method_82("chúng tôi cần thêm thông tin", text13))
																								{
																									if (Settings.Default.isThuVeriCheckPoint)
																									{
																										method_62(int_41, text3 + "Checkpoint...thử xác nhận", device);
																										flag3 = true;
																										goto IL_4e67;
																									}
																									method_62(int_41, text3 + "Checkpoint 282. Lưu acc...", device);
																									flag5 = true;
																									method_42(int_41, "Checkpoint");
																									goto IL_738b;
																								}
																								if (!device.method_82("there was an issue with your connection. check the following and try again.", text13) && !device.method_82("đã xảy ra lỗi", text13) && !device.method_82("đã xảy ra sự cố với kết nối của bạn. hãy kiểm tra những vấn đề sau và thử lại:", text13))
																								{
																									if (!device.method_52("DataClick\\image\\siginfail"))
																									{
																										if (!device.method_82("vui lòng nhập địa chỉ email hợp lệ.", text13))
																										{
																											if (device.method_82("tên hoặc họ trên facebook không được quá ngắn", text13))
																											{
																												flag11 = false;
																												method_62(int_41, text3 + "Lỗi khi đăng ký. Thực hiện đăng ký lại", device);
																												device.method_70();
																												device.method_121(1.0);
																												goto end_IL_4ccc;
																											}
																											if (!device.method_82("mất kết nối", text13))
																											{
																												continue;
																											}
																											flag11 = false;
																											method_62(int_41, text3 + "Lỗi mất kết nối", device);
																										}
																										else
																										{
																											if (num4 != 5)
																											{
																												method_62(int_41, text3 + "Lấy mail khác...lần " + (num4 + 1), device);
																												device.method_121(1.0);
																												if (device.method_52("DataClick\\image\\x"))
																												{
																													device.method_3("DataClick\\image\\x");
																												}
																												else
																												{
																													device.method_91(295, 209);
																												}
																												num4++;
																												goto IL_3756;
																											}
																											method_62(int_41, text3 + "Lỗi email không hợp lệ", device);
																											flag11 = false;
																										}
																									}
																									else
																									{
																										flag11 = false;
																										method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																									}
																								}
																								else
																								{
																									flag11 = false;
																									method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																								}
																							}
																							else if (bool_0)
																							{
																								method_62(int_41, text3 + "Dừng chạy...");
																								flag11 = false;
																							}
																							else
																							{
																								flag11 = false;
																								method_62(int_41, text3 + "Lỗi khi đăng ký. Thử lại sau", device);
																							}
																						}
																						else
																						{
																							if (!bool_0)
																							{
																								if (device.method_82("không, tạo tài khoản mới", text13))
																								{
																									device.method_99("không, tạo tài khoản mới", text13, 10);
																								}
																								else if (device.method_82("no, create new account", text13))
																								{
																									device.method_99("no, create new account", text13, 10);
																								}
																								goto IL_4ccc_2;
																							}
																							method_62(int_41, text3 + "Dừng chạy...", device);
																							flag11 = false;
																						}
																					}
																					else
																					{
																						flag11 = true;
																						method_62(int_41, text3 + "Đăng ký thành công...", device);
																						if (device.method_82("\"not now\"", text13))
																						{
																							device.method_99("\"not now\"", "", 10);
																						}
																						else
																						{
																							device.method_99("\"lúc khác\"", "", 10);
																						}
																					}
																				}
																				else
																				{
																					method_62(int_41, text3 + "Dừng chạy...");
																					flag11 = false;
																				}
																				goto IL_4dbc;
																			}
																			method_62(int_41, text3 + "Không check được status...");
																			method_49("Không check được status đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		break;
																	}
																}
																catch (Exception exception_)
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	Common.smethod_82(exception_, "Check_status_dangky");
																}
																goto end_IL_3756;
															IL_4dbc:
																if (!flag11)
																{
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																method_62(int_41, text3 + "Lưu mật khẩu và số điện thoại...", device);
																device.method_121(1.0);
																if (device.method_52("DataClick\\image\\ok1"))
																{
																	device.method_3("DataClick\\image\\ok1");
																}
																else
																{
																	device.method_91(160, 356);
																}
																goto IL_4e67;
															IL_738b:
																device.method_121(1.0);
																string text35 = device.method_13();
																text19 = Regex.Match(text35.Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
																if (text19.Trim() != "")
																{
																	method_52(text19, "uid", int_41, 0, dgvAcc);
																}
																text20 = text35.Split('|')[0];
																text21 = text35.Split('|')[1];
																method_52(text20, "token", int_41, 0, dgvAcc);
																method_52(text21, "cookie", int_41, 0, dgvAcc);
																if (!flag5)
																{
																	if (!flag11)
																	{
																		method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																		method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	method_62(int_41, text3 + "Chuyển đổi ngôn ngữ về English...", device);
																	device.method_122();
																	int n = 0;
																	device.method_121(1.0);
																	for (; n < 10; n++)
																	{
																		string text36 = device.method_93();
																		if (!device.method_99("english", text36))
																		{
																			device.method_121(1.0);
																			continue;
																		}
																		flag11 = true;
																		break;
																	}
																	if (flag11)
																	{
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		device.method_121(5.0);
																		if (Settings.Default.isAddMailReg && flag2)
																		{
																			string text37 = queue_1.Dequeue();
																			method_62(int_41, text3 + "Thêm mail sau khi reg...", device);
																			device.method_128();
																			device.method_121(10.0);
																			if (device.method_52("DataClick\\image\\addmailreg", null, 1))
																			{
																				device.method_3("DataClick\\image\\addmailreg", null, 1);
																			}
																			device.method_121(5.0);
																			if (device.method_52("DataClick\\image\\input", null, 1))
																			{
																				device.method_3("DataClick\\image\\input", null, 1);
																			}
																			device.method_121(2.0);
																			device.method_100(text37);
																			device.method_121(1.0);
																			if (device.method_52("DataClick\\image\\addmail", null, 1))
																			{
																				device.method_3("DataClick\\image\\addmail", null, 1);
																			}
																			device.method_121(5.0);
																		}
																		try
																		{
																			if (bool_3)
																			{
																				try
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					method_62(int_41, text3 + "Up avatar...", device);
																					int num15 = 1;
																					int num16 = 0;
																					string text38 = "";
																					int num17 = 0;
																					while (true)
																					{
																						if (bool_0)
																						{
																							method_62(int_41, text3 + "Dừng chạy...", device);
																							method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																							break;
																						}
																						if (num17 != 5)
																						{
																							device.method_12();
																							if (flag2 || !device.method_52("DataClick\\image\\checkpoint"))
																							{
																								text38 = device.method_93();
																								num17++;
																								switch (method_44(device, int_41, ""))
																								{
																									case 0:
																										method_62(int_41, text3 + "Up lại avatar...", device);
																										continue;
																									case 2:
																										continue;
																									case 3:
																										goto end_IL_7690;
																								}
																								bool flag12 = device.method_99("profile picture", "", 10);
																								while (flag12)
																								{
																									if (!bool_0)
																									{
																										num15++;
																										int num18 = num15;
																										int num19 = num18;
																										if (num19 == 1 || num19 != 2)
																										{
																											break;
																										}
																										flag12 = false;
																										device.method_85("shell rm /sdcard/*.png");
																										device.method_85("shell am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard/Pictures");
																										device.method_121(1.0);
																										if (!device.method_99("select profile picture", "", 5))
																										{
																											continue;
																										}
																										int num20 = 0;
																										while (true)
																										{
																											if (num20 < 5)
																											{
																												if (bool_0)
																												{
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												text38 = device.method_93();
																												switch (device.method_84(text38, 0.0, "\"allow\"", "\"enable gallery access", "\"want to upload your photos", "\"photo\""))
																												{
																													case 1:
																														device.method_99("\"allow\"", text38);
																														goto IL_7902;
																													case 2:
																														device.method_99("\"enable gallery access", text38);
																														goto IL_7902;
																													case 3:
																														device.method_99("\"want to upload your photos", text38);
																														device.method_121(2.0);
																														device.method_74();
																														goto IL_7902;
																													default:
																														goto IL_7902;
																													case 4:
																														break;
																												}
																											}
																											List<string> list = device.method_76("\"photo\"", text38);
																											if (list.Count >= 10)
																											{
																												int num21 = random_0.Next(0, 10);
																												int num22 = 0;
																												while (true)
																												{
																													if (num22 < num21 && !device.method_81(1000, 1, "[125,444][179,465]", "[146,313][223,348]", "[124,359][196,423]"))
																													{
																														if (!bool_0)
																														{
																															device.method_121(1.0);
																															num22++;
																															continue;
																														}
																														method_62(int_41, text3 + "Dừng chạy...", device);
																														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																														break;
																													}
																													text38 = device.method_93();
																													goto IL_79b3;
																												}
																												break;
																											}
																											goto IL_79b3;
																										IL_7902:
																											device.method_121(1.0);
																											num20++;
																											continue;
																										IL_79b3:
																											string value = (from string_0 in device.method_76("\"photo\"", text38)
																															orderby Guid.NewGuid()
																															select string_0).FirstOrDefault();
																											if (!string.IsNullOrEmpty(value))
																											{
																												device.method_89(value);
																												device.method_121(1.0);
																												flag12 = device.method_99("\"save\"", "", 10);
																												flag11 = true;
																											}
																											goto IL_7a2c;
																										}
																										goto end_IL_776e;
																									}
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									goto end_IL_776e;
																								IL_7a2c:;
																								}
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Không up được avartar...", device);
																						}
																						goto end_IL_7690;
																						continue;
																					end_IL_776e:
																						break;
																					}
																				}
																				catch
																				{
																					goto IL_8211;
																				}
																				goto end_IL_3756;
																			}
																		end_IL_7690:;
																		}
																		catch (Exception)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (!flag11)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		if (bool_4)
																		{
																			try
																			{
																				device.method_115(string_19);
																				method_62(int_41, text3 + "Up cover photo...", device);
																				bool flag13 = false;
																				string text39 = "";
																				int num23 = 1;
																				int num24 = 0;
																				while (true)
																				{
																					if (!bool_0)
																					{
																						if (num24 != 5)
																						{
																							device.method_12();
																							if (flag2 || !device.method_52("DataClick\\image\\checkpoint"))
																							{
																								text39 = device.method_93();
																								num24++;
																								switch (method_44(device, int_41, text3))
																								{
																									case 0:
																										method_62(int_41, text3 + "Up lại cover photo...", device);
																										continue;
																									case 2:
																										continue;
																									case 3:
																										goto IL_7fe5;
																								}
																								string text40 = device.method_97("profile picture", "", 10);
																								if (text40 != "")
																								{
																									string[] array2 = text40.Split('[', ',', ']');
																									device.method_91(Convert.ToInt32(array2[1]) - 10, Convert.ToInt32(array2[2]) - 10);
																									flag13 = true;
																								}
																								while (flag13)
																								{
																									if (!bool_0)
																									{
																										num23++;
																										switch (num23)
																										{
																											case 2:
																												{
																													flag13 = false;
																													device.method_85("shell rm /sdcard.png");
																													device.method_85("shell am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard/Pictures");
																													device.method_121(1.0);
																													if (!device.method_99("upload photo", "", 5))
																													{
																														continue;
																													}
																													int num25 = 0;
																													while (true)
																													{
																														if (num25 < 5)
																														{
																															if (bool_0)
																															{
																																method_62(int_41, text3 + "Dừng chạy...", device);
																																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																																goto end_IL_7c2c;
																															}
																															text39 = device.method_93();
																															switch (device.method_84(text39, 0.0, "\"allow\"", "\"enable gallery access", "\"want to upload your photos", "\"photo\""))
																															{
																																case 1:
																																	device.method_99("\"allow\"", text39);
																																	goto IL_7e16;
																																case 2:
																																	device.method_99("\"enable gallery access", text39);
																																	goto IL_7e16;
																																case 3:
																																	device.method_99("\"want to upload your photos", text39);
																																	device.method_121(2.0);
																																	device.method_74();
																																	goto IL_7e16;
																																default:
																																	goto IL_7e16;
																																case 4:
																																	break;
																															}
																														}
																														List<string> list2 = device.method_76("\"photo\"", text39);
																														if (list2.Count >= 24)
																														{
																															int num26 = random_0.Next(0, 5);
																															for (int num27 = 0; num27 < num26; num27++)
																															{
																																if (device.method_81(1000, 1, "[125,444][179,465]", "[146,313][223,348]", "[124,359][196,423]"))
																																{
																																	break;
																																}
																																device.method_121(1.0);
																															}
																															text39 = device.method_93();
																														}
																														string value2 = (from string_0 in device.method_76("\"photo\"", text39)
																																		 orderby Guid.NewGuid()
																																		 select string_0).FirstOrDefault();
																														if (!string.IsNullOrEmpty(value2))
																														{
																															device.method_89(value2);
																															device.method_121(1.0);
																															flag13 = device.method_99("\"save\"", "", 10);
																															flag11 = true;
																														}
																														break;
																													IL_7e16:
																														device.method_121(1.0);
																														num25++;
																													}
																													continue;
																												}
																											case 3:
																												device.method_121(3.0);
																												flag13 = device.method_75(60.0, "uploading your cover photo.");
																												continue;
																										}
																										break;
																									}
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									goto end_IL_7c2c;
																								}
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Không up được cover photo...", device);
																						}
																						goto IL_7fe5;
																					}
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					break;
																					continue;
																				end_IL_7c2c:
																					break;
																				}
																			}
																			catch
																			{
																				goto IL_8211;
																			}
																			goto end_IL_3756;
																		}
																		goto IL_7fe5;
																	}
																	flag11 = false;
																	method_62(int_41, text3 + "Không đổi được ngôn ngữ. Ko thể làm các step tiếp theo", device);
																}
																goto IL_8211;
															IL_4e67:
																string text44;
																if (flag3)
																{
																	device.method_99("\"tiếp tục\"");
																	for (int num28 = 0; num28 < 5; num28++)
																	{
																		text13 = device.method_93();
																		if (device.method_82("giúp chúng tôi xác nhận đó là bạn", text13)) //Giai captcha
																		{
																			//method_62(int_41, "Captcha...Không xác thực", device);
																			//method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			//goto end_IL_3756;
																			method_62(int_41, "Captcha...Dang giai Captcha", device);
																			method_49("Dang Giai Captcha !!!", device.int_0, int_41, int_42, device, bool_18: false);

																			string captcha = "";
																			captcha = CaptchaService.Anycaptcha_Giai_recaptcha(text_api_captcha, "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR");
																			if(captcha != "")
                                                                            {
																				method_62(int_41, "Giai Captcha thanh cong... Up anh", device);
																				method_49("Giai Captcha thanh cong !!!", device.int_0, int_41, int_42, device, bool_18: false);
																			}

																		}
																	}
																	if (string_12.Substring(0, 1) == "0" && !flag2)
																	{
																		if (bool_16)
																		{
																			int num29 = 0;
																			while (true)
																			{
																				if (num29 == 0)
																				{
																					method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																				}
																				else
																				{
																					method_62(int_41, text3 + "Lấy số khác...Lần: " + num29, device);
																					device.method_121(1.0);
																					int tickCount2 = Environment.TickCount;
																					while ((Environment.TickCount - tickCount2) / 1000 - int_39 < 0)
																					{
																						if (!bool_0)
																						{
																							method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount2) / 1000).ToString()), device);
																							continue;
																						}
																						method_62(int_41, "Dừng chạy!", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_52b9;
																					}
																				}
																				text5 = "";
																				if (int_37 == 0)
																				{
																					text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																				}
																				else if (int_37 == 1)
																				{
																					text5 = Common.smethod_57(text17, ref text18);
																					text9 = text5;
																				}
																				else if (int_37 == 2)
																				{
																					text5 = Common.smethod_21(text17, ref text18);
																				}
																				else if (int_37 == 3)
																				{
																					text5 = Common.smethod_48(text17);
																				}
																				else if (int_37 == 4)
																				{
																					text5 = Common.smethod_27(text17, text18);
																				}
																				else if (int_37 == 5)
																				{
																					text5 = Common.smethod_25(text17, text18);
																				}
																				else if (int_37 == 6)
																				{
																					text5 = Common.GetPhoneOtpFb(text17, ref text18);
																				}
																				else if (int_37 == 7)
																				{
																					text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																				}
																				else if (int_37 == 8)
																				{
																					text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																				}
																				else if (int_37 == 9)
																				{
																					text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																				}
																				if (text5 != "")
																				{
																					if (!(text5 == "API sai"))
																					{
																						if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																						{
																							if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 3 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																							{
																								text5 = "+84" + text5; // truoc la +1
																							}
																							if (device.method_52("DataClick\\image\\inputsdtemail"))
																							{
																								device.method_3("DataClick\\image\\inputsdtemail");
																							}
																							else
																							{
																								device.method_99("nhập số điện thoại hoặc email mới");
																							}
																							method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																							method_52(text5, "phone", int_41, 0, dgvAcc);
																							device.method_121(1.0);
																							device.method_102(text5);
																							device.method_121(1.0);
																							if (device.method_52("DataClick\\image\\sendcodeotp"))
																							{
																								device.method_3("DataClick\\image\\sendcodeotp");
																							}
																							else
																							{
																								device.method_99("gửi mã đăng nhập");
																							}
																							bool flag14 = false;
																							for (int num30 = 0; num30 < 5; num30++)
																							{
																								text13 = device.method_93();
																								if (device.method_82("nhập mã mà chúng tôi vừa gửi qua tin nhắn văn bản", text13))
																								{
																									flag14 = true;
																									break;
																								}
																							}
																							if (!flag14)
																							{
																								if (num29 != 5)
																								{
																									device.method_44("nhập số điện thoại hoặc email mới");
																									num29++;
																									continue;
																								}
																								method_62(int_41, text3 + "Hết số điện thoại", device);
																								method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								break;
																							}
																							method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																							string text41 = string.Empty;
																							if (int_37 == 0)
																							{
																								text41 = Common.smethod_26(text17, text18, int_14);
																							}
																							else if (int_37 == 1)
																							{
																								text41 = Common.smethod_28(text17, text9, int_14);
																							}
																							else if (int_37 == 2)
																							{
																								text41 = Common.smethod_27(text17, text18, int_14);
																							}
																							else if (int_37 == 3)
																							{
																								text41 = Common.smethod_45(text17, text18, int_14);
																							}
																							else if (int_37 == 4)
																							{
																								text41 = Common.smethod_46(text17, text18, int_14);
																							}
																							else if (int_37 == 5)
																							{
																								text41 = Common.GetCodeWinMailShop(text17, text18, int_14);
																							}
																							else if (int_37 == 6)
																							{
																								text41 = Common.GetCodeAhasim(text17, text18, int_14);
																							}
																							else if (int_37 == 7)
																							{
																								text41 = Common.GetCodeOtptn(text17, text18, int_14);
																							}
																							else if (int_37 == 8)
																							{
																								text41 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																							}
																							else if (int_37 == 9)
																							{
																								text41 = Common.GetCodeAhasim(text17, text18, int_14);
																							}


																							if (!(text41 != ""))
																							{
																								if (num29 != 5)
																								{
																									if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																									{
																										device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																									}
																									else
																									{
																										device.method_99("cập nhật thông tin liên hệ");
																									}
																									num29++;
																									continue;
																								}
																								method_62(int_41, text3 + "Hết số điện thoại", device);
																								method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																								break;
																							}
																							if (device.method_52("DataClick\\image\\inputotpckp"))
																							{
																								device.method_3("DataClick\\image\\inputotpckp");
																							}
																							else
																							{
																								device.method_91(32, 173);
																							}
																							device.method_121(1.0);
																							device.method_102(text41);
																							device.method_121(1.0);
																							device.method_99("\"tiếp\"");
																							bool flag15 = false;
																							for (int num31 = 0; num31 < 20; num31++)
																							{
																								text13 = device.method_93();
																								if (device.method_82("bạn có thể dùng facebook", text13))
																								{
																									flag15 = true;
																									flag4 = true;
																									flag2 = true;
																									break;
																								}
																							}
																							if (flag15)
																							{
																								if (device.method_52("DataClick\\image\\truycapfacebook"))
																								{
																									device.method_3("DataClick\\image\\truycapfacebook");
																								}
																								else
																								{
																									device.method_91(160, 165);
																								}
																								flag11 = true;
																								device.method_121(1.0);
																							}
																							else
																							{
																								method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																								method_42(int_41, "Checkpoint");
																								flag5 = true;
																							}
																						}
																						else
																						{
																							method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																							flag2 = false;
																							device.method_12();
																						}
																						goto IL_738b;
																					}
																					method_62(int_41, text3 + "API key sai...", device);
																					method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																					break;
																				}
																				if (text5 == "Đã hết số điện thoại, chờ cập nhật")
																				{
																					method_62(int_41, text3 + "Hết số điện thoại", device);
																					method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																				else
																				{
																					method_62(int_41, text3 + "Hết số điện thoại", device);
																					method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																				break;
																				continue;
																			end_IL_52b9:
																				break;
																			}
																			goto end_IL_3756;
																		}
																		if (bool_17)
																		{
																			int num32 = 0;
																			while (true)
																			{
																				method_62(int_41, text3 + "Đang lấy tempmail.io", device);
																				string text42 = "";
																				string text43 = method_73();
																				if (int_38 == 0)
																				{
																					text42 = Common.smethod_19(text43);
																				}
																				if (!(text42 != ""))
																				{
																					break;
																				}
																				if (device.method_52("DataClick\\image\\inputsdtemail"))
																				{
																					device.method_3("DataClick\\image\\inputsdtemail");
																				}
																				else
																				{
																					device.method_99("nhập số điện thoại hoặc email mới");
																				}
																				method_62(int_41, text3 + "TempMail:" + text42, device);
																				method_52(text42, "email", int_41, 0, dgvAcc);
																				device.method_121(1.0);
																				device.method_102(text42);
																				device.method_121(1.0);
																				if (device.method_52("DataClick\\image\\sendcodeotp"))
																				{
																					device.method_3("DataClick\\image\\sendcodeotp");
																				}
																				else
																				{
																					device.method_99("gửi mã đăng nhập");
																				}
																				bool flag16 = false;
																				for (int num33 = 0; num33 < 5; num33++)
																				{
																					text13 = device.method_93();
																					if (device.method_82("nhập mã xác nhận", text13))
																					{
																						flag16 = true;
																						break;
																					}
																				}
																				if (flag16)
																				{
																					method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																					text44 = Common.smethod_20(method_39(int_41));
																					if (!(text44 != ""))
																					{
																						if (num32 != 5)
																						{
																							if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																							{
																								device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																							}
																							else
																							{
																								device.method_99("cập nhật thông tin liên hệ");
																							}
																							num32++;
																							continue;
																						}
																						method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_3756;
																					}
																					goto IL_5776;
																				}
																				if (num32 != 5)
																				{
																					if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																					{
																						device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																					}
																					else
																					{
																						device.method_99("cập nhật thông tin liên hệ");
																					}
																					num32++;
																					continue;
																				}
																				method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_3756;
																			}
																		}
																	}
																}
																while (true)
																{
																	if (string_12.Substring(0, 1) == "0" && !flag2)
																	{
																		if (bool_16)
																		{
																			if (!bool_0)
																			{
																				text13 = device.method_93();
																				if (device.method_82("change phone number", text13))
																				{
																					device.method_99("change phone number", text13);
																				}
																				else
																				{
																					device.method_99("thay đổi số điện thoại", text13);
																				}
																				while (true)
																				{
																					if (num2 == 0)
																					{
																						method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																					}
																					else
																					{
																						method_62(int_41, text3 + "Lấy số khác...Lần: " + num2, device);
																						device.method_121(1.0);
																						int tickCount3 = Environment.TickCount;
																						while ((Environment.TickCount - tickCount3) / 1000 - int_39 < 0)
																						{
																							if (!bool_0)
																							{
																								method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount3) / 1000).ToString()), device);
																								continue;
																							}
																							method_62(int_41, "Dừng chạy!", device);
																							method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																							goto end_IL_5c15;
																						}
																					}
																					text5 = "";
																					if (int_37 == 0)
																					{
																						text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																					}
																					else if (int_37 == 1)
																					{
																						text5 = Common.smethod_57(text17, ref text18);
																						text9 = text5;
																					}
																					else if (int_37 == 2)
																					{
																						text5 = Common.smethod_21(text17, ref text18);
																					}
																					else if (int_37 == 3)
																					{
																						text5 = Common.smethod_48(text17);
																					}
																					else if (int_37 == 4)
																					{
																						text5 = Common.smethod_27(text17, text18);
																					}
																					else if (int_37 == 5)
																					{
																						text5 = Common.smethod_25(text17, text18);
																					}
																					else if (int_37 == 6)
																					{
																						text5 = Common.GetPhoneOtpFb(text17, ref text18);
																					}
																					else if (int_37 == 7)
																					{
																						text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																					}
																					else if (int_37 == 8)
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																					}
																					else if (int_37 == 9)
																					{
																						text5 = Common.GetPhoneAhasim(text17, ref text18);
																					}

																					if (text5 != "")
																					{
																						if (!(text5 == "API sai"))
																						{
																							if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																							{
																								if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																								{
																									text5 = "+84" + text5; // truoc la +1
																								}
																								else if (int_37 == 9 || int_37 == 3 || int_37 == 6)
																								{
																									text5 = "+84" + text5;
																								}
																								method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																								method_52(text5, "phone", int_41, 0, dgvAcc);
																								device.method_121(1.0);
																								if (num2 == 0)
																								{
																									if (device.method_52("DataClick\\image\\phone"))
																									{
																										device.method_3("DataClick\\image\\phone");
																									}
																									else
																									{
																										device.method_91(36, 147);
																									}
																								}
																								device.method_121(1.0);
																								device.method_102(text5);
																								device.method_121(1.0);
																								if (device.method_52("DataClick\\image\\continue"))
																								{
																									device.method_3("DataClick\\image\\continue");
																								}
																								bool flag17 = false;
																								for (int num34 = 0; num34 < 5; num34++)
																								{
																									text13 = device.method_93();
																									if (!device.method_82("nhập mã từ sms của bạn", text13))
																									{
																										flag17 = true;
																										continue;
																									}
																									flag17 = false;
																									break;
																								}
																								if (!flag17)
																								{
																									goto IL_5c24;
																								}
																								if (num2 != 5)
																								{
																									device.method_44("số điện thoại di động");
																									num2++;
																									continue;
																								}
																								goto IL_5e64;
																							}
																							goto IL_5e8d;
																						}
																						method_62(int_41, text3 + "API key sai...", device);
																						method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																						break;
																					}
																					if (num2 != 5)
																					{
																						num2++;
																						continue;
																					}
																					goto IL_5ee2;
																					continue;
																				end_IL_5c15:
																					break;
																				}
																			}
																			else
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			break;
																		}
																		if (bool_17)
																		{
																			if (!bool_0)
																			{
																				text13 = device.method_93();
																				if (device.method_82("email confirmation", text13))
																				{
																					device.method_99("email confirmation", text13);
																				}
																				else
																				{
																					device.method_99("xác nhận qua email", text13);
																				}
																				method_62(int_41, text3 + "Đang lấy tempmail.io", device);
																				string text45 = "";
																				while (true)
																				{
																					string text46 = method_73();
																					if (int_38 == 0)
																					{
																						text45 = Common.smethod_19(text46);
																					}
																					if (text45 != "")
																					{
																						method_52(text45, "email", int_41, 0, dgvAcc);
																						if (device.method_52("DataClick\\image\\emailveri"))
																						{
																							device.method_3("DataClick\\image\\emailveri");
																						}
																						device.method_121(1.0);
																						device.method_102(text45);
																						device.method_121(1.0);
																						if (device.method_52("DataClick\\image\\continue"))
																						{
																							device.method_3("DataClick\\image\\continue");
																						}
																						bool flag18 = false;
																						for (int num35 = 0; num35 < 5; num35++)
																						{
																							text13 = device.method_93();
																							if (!device.method_82("nhập mã từ email của bạn", text13))
																							{
																								flag18 = true;
																								continue;
																							}
																							flag18 = false;
																							break;
																						}
																						if (!flag18)
																						{
																							break;
																						}
																						if (num3 != 5)
																						{
																							device.method_44("địa chỉ email");
																							num3++;
																							method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																							continue;
																						}
																						goto IL_5f39;
																					}
																					if (num3 != 5)
																					{
																						num3++;
																						method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																						continue;
																					}
																					goto IL_5f62;
																				}
																				flag2 = true;
																				continue;
																			}
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		flag2 = false;
																		device.method_12();
																	}
																	else
																	{
																		while (true)
																		{
																		IL_6c5f:
																			text13 = device.method_93();
																			if (!device.method_82("enter your mobile number", text13) && !device.method_82("nhập số di động của bạn", text13))
																			{
																				int num36 = 0;
																				while (num36 < 2)
																				{
																					text13 = device.method_93();
																					if (device.method_120(text13).Count == 1)
																					{
																						num36++;
																						continue;
																					}
																					goto IL_6008;
																				}
																				goto IL_6064;
																			}
																			flag2 = false;
																			method_62(int_41, text3 + "Lỗi xác nhận số điện thoại hoặc email... Goto Newfeed", device);
																			device.method_124();
																			break;
																		IL_6008:
																			if (device.method_82("enter the code from your sms", text13) || device.method_82("nhập mã từ sms của bạn", text13) || device.method_82("nhập mã từ email của bạn", text13))
																			{
																				if (!bool_0)
																				{
																					flag11 = true;
																					goto IL_6064;
																				}
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			flag2 = false;
																			method_62(int_41, text3 + "Lỗi xác nhận số điện thoại hoặc email... Goto Newfeed", device);
																			device.method_124();
																			break;
																		IL_6064:
																			if (flag11)
																			{
																				if (!bool_0)
																				{
																					try
																					{
																						if (rdThuePhone.Checked || bool_16)
																						{
																							int num37 = 0;
																							int num38 = 0;
																							while (num38 < 2)
																							{
																								if (!bool_0)
																								{
																									method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																									string text47 = string.Empty;
																									if (rdThuePhone.Checked)
																									{
																										if (string_12.Substring(2, 1) == "0")
																										{
																											text47 = Common.smethod_44(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "1")
																										{
																											text47 = Common.smethod_61(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "2")
																										{
																											text47 = Common.smethod_26(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "3")
																										{
																											text47 = Common.smethod_28(text17, text9, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "4")
																										{
																											text47 = Common.smethod_27(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "5")
																										{
																											text47 = Common.smethod_45(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "6")
																										{
																											text47 = Common.smethod_46(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "7")
																										{
																											text47 = Common.GetCodeWinMailShop(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "8")
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "9")
																										{
																											text47 = Common.GetCodeOtptn(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "10")
																										{
																											text47 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																										}
																										else if (string_12.Substring(2, 1) == "11")
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}

																									}
																									else if (bool_16)
																									{
																										if (int_37 == 0)
																										{
																											text47 = Common.smethod_26(text17, text18, int_14);
																										}
																										else if (int_37 == 1)
																										{
																											text47 = Common.smethod_28(text17, text9, int_14);
																										}
																										else if (int_37 == 2)
																										{
																											text47 = Common.smethod_27(text17, text18, int_14);
																										}
																										else if (int_37 == 3)
																										{
																											text47 = Common.smethod_45(text17, text18, int_14);
																										}
																										else if (int_37 == 4)
																										{
																											text47 = Common.smethod_46(text17, text18, int_14);
																										}
																										else if (int_37 == 5)
																										{
																											text47 = Common.GetCodeWinMailShop(text17, text18, int_14);
																										}
																										else if (int_37 == 6)
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																										else if (int_37 == 7)
																										{
																											text47 = Common.GetCodeOtptn(text17, text18, int_14);
																										}
																										else if (int_37 == 8)
																										{
																											text47 = Common.GetCodethuecodetextnow(text17, text18, int_14);
																										}
																										else if (int_37 == 9)
																										{
																											text47 = Common.GetCodeAhasim(text17, text18, int_14);
																										}
																									}
																									if (!(text47 == ""))
																									{
																										flag11 = true;
																										method_62(int_41, text3 + "Mã OTP:" + text47, device);
																										if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																										{
																											device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																										}
																										device.method_102(text47);
																										break;
																									}
																									if (!bool_0)
																									{
																										num37++;
																										text13 = device.method_93();
																										if (device.method_120(text13).Count == 1)
																										{
																											goto IL_639d;
																										}
																										method_62(int_41, text3 + "Không lấy được mã OTP...", device);
																										if (!device.method_82("account confirmation", text13) && !device.method_82("xác nhận tài khoản", text13))
																										{
																											goto IL_639d;
																										}
																										if (!bool_0)
																										{
																											if (!device.method_82("change phone number", text13) && !device.method_82("thay đổi số điện thoại", text13))
																											{
																												goto IL_639d;
																											}
																											if (bool_0)
																											{
																												method_62(int_41, text3 + "Dừng chạy...");
																												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																												break;
																											}
																											if (device.method_82("change phone number", text13))
																											{
																												device.method_99("change phone number", text13);
																											}
																											else
																											{
																												device.method_99("thay đổi số điện thoại", text13);
																											}
																											device.method_121(1.0);
																											while (true)
																											{
																												method_62(int_41, text3 + "Đang lấy số điện thoại khác...", device);
																												if (!rdThuePhone.Checked)
																												{
																													if (bool_16)
																													{
																														if (int_37 == 0)
																														{
																															text5 = Common.smethod_47(text17, ref text18); // Chothuesimcode
																														}
																														else if (int_37 == 1)
																														{
																															text5 = Common.smethod_57(text17, ref text18);
																															text9 = text5;
																														}
																														else if (int_37 == 2)
																														{
																															text5 = Common.smethod_21(text17, ref text18);
																														}
																														else if (int_37 == 3)
																														{
																															text5 = Common.smethod_48(text17);
																														}
																														else if (int_37 == 4)
																														{
																															text5 = Common.smethod_27(text17, text18);
																														}
																														else if (int_37 == 5)
																														{
																															text5 = Common.smethod_25(text17, text18);
																														}
																														else if (int_37 == 6)
																														{
																															text5 = Common.GetPhoneOtpFb(text17, ref text18);
																														}
																														else if (int_37 == 7)
																														{
																															text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																														}
																														else if (int_37 == 8)
																														{
																															text5 = Common.GetPhoneAhasim(text17, ref text18); //2
																														}
																														else if (int_37 == 9)
																														{
																															text5 = Common.GetPhoneAhasim(text17, ref text18);
																														}
																													}
																												}
																												else if (string_12.Substring(2, 1) == "0")
																												{
																													text5 = Common.smethod_47(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "1")
																												{
																													text5 = Common.smethod_57(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "2")
																												{
																													text5 = Common.smethod_21(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "3")
																												{
																													text5 = Common.smethod_48(text17);
																													text9 = text5;
																												}
																												else if (string_12.Substring(2, 1) == "4")
																												{
																													text5 = Common.smethod_22(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "5")
																												{
																													text5 = Common.smethod_23(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "6")
																												{
																													text5 = Common.smethod_24(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "7")
																												{
																													text5 = Common.GetPhoneWinMailShop(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "8")
																												{
																													text5 = Common.GetPhoneAhasim(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "9")
																												{
																													text5 = Common.GetPhoneOtptn(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "10")
																												{
																													text5 = Common.GetPhoneOtpFb(text17, ref text18);
																												}
																												else if (string_12.Substring(2, 1) == "11")
																												{
																													text5 = Common.GetPhoneAhasim(text17, ref text18);
																												}
																												if (text5 == "")
																												{
																													if (!bool_0)
																													{
																														method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác", device);
																														continue;
																													}
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												if (text5 == "Đã hết số điện thoại, chờ cập nhật" && string_12.Substring(2, 1) == "3")
																												{
																													method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																													method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																													goto end_IL_63b1;
																												}
																												if (text5 == "API sai")
																												{
																													method_62(int_41, text3 + "API key sai...Kiểm tra lại", device);
																													method_49("API key sai...Kiểm tra lại", device.int_0, int_41, int_42, device, bool_18: false);
																													goto end_IL_63b1;
																												}
																												if (bool_0)
																												{
																													method_62(int_41, text3 + "Dừng chạy...", device);
																													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																													break;
																												}
																												if (rdThuePhone.Checked)
																												{
																													if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																													{
																														text5 = "+84" + text5;
																													}
																													if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																													{
																														text5 = "+84" + text5; // truoc la +1
																													}
																												}
																												else if (bool_16)
																												{
																													if (int_37 == 3 || int_37 == 9 || int_37 == 6)
																													{
																														text5 = "+84" + text5;
																													}
																													if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																													{
																														text5 = "+84" + text5; // truoc la +1
																													}
																												}
																												method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																												method_52(text5, "phone", int_41, 0, dgvAcc);
																												device.method_121(1.0);
																												if (device.method_52("DataClick\\image\\phone"))
																												{
																													device.method_3("DataClick\\image\\phone");
																												}
																												else
																												{
																													device.method_91(36, 147);
																												}
																												device.method_121(1.0);
																												device.method_102(text5);
																												device.method_121(1.0);
																												if (device.method_52("DataClick\\image\\continue"))
																												{
																													device.method_3("DataClick\\image\\continue");
																												}
																												device.method_121(3.0);
																												goto IL_6c5f;
																											}
																										}
																										else
																										{
																											method_62(int_41, text3 + "Dừng chạy...", device);
																											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																										}
																									}
																									else
																									{
																										method_62(int_41, text3 + "Dừng chạy...");
																										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																									}
																								}
																								else
																								{
																									method_62(int_41, text3 + "Dừng chạy...", device);
																									method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								}
																								goto end_IL_607a;
																							IL_639d:
																								if (num37 != 5)
																								{
																									num38++;
																									continue;
																								}
																								flag2 = false;
																								device.method_12();
																								goto end_IL_6c5f;
																								continue;
																							end_IL_63b1:
																								break;
																							}
																							goto IL_6c84;
																						}
																						if (rdConfMail.Checked)
																						{
																							if (bool_0)
																							{
																								method_62(int_41, text3 + "Dừng chạy...", device);
																								method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																								goto end_IL_5e1f;
																							}
																							string text48 = string_12.Substring(2, 1);
																							if (text48 != null)
																							{
																								if (!(text48 == "0"))
																								{
																									if (!(text48 == "1"))
																									{
																										string text49 = Common.smethod_20(method_39(int_41));
																										if (!(text49 != ""))
																										{
																											method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																											flag11 = true;
																											flag2 = false;
																											device.method_124();
																											break;
																										}
																										if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																										{
																											device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																										}
																										device.method_102(text49);
																										flag11 = true;
																									}
																								}
																								else
																								{
																									string text50 = Common.smethod_31(text6, text7);
																									if (text50 == "")
																									{
																										flag2 = false;
																										method_52("Mail không nhận được OTP. Goto Newfeed", "status", int_41, 2, dgvAcc);
																										device.method_124();
																									}
																									if (text50.Contains("kcon"))
																									{
																										flag2 = false;
																										method_52("Không kê\u0301t nô\u0301i đươ\u0323c server hotmail!", "status", int_41, 2, dgvAcc);
																										device.method_124();
																									}
																									if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																									{
																										device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																									}
																									device.method_102(text50);
																									flag11 = true;
																								}
																							}
																							goto IL_6c84;
																						}
																						if (bool_17)
																						{
																							string text51 = Common.smethod_20(method_39(int_41));
																							if (!(text51 != ""))
																							{
																								method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																								flag11 = true;
																								flag2 = false;
																								device.method_124();
																								break;
																							}
																							if (device.method_52("DataClick\\image\\confirmcode2fa", null, 1))
																							{
																								device.method_3("DataClick\\image\\confirmcode2fa", null, 1);
																							}
																							flag2 = true;
																							device.method_102(text51);
																							flag11 = true;
																						}
																						goto IL_6c84;
																					end_IL_607a:;
																					}
																					catch (Exception ex2)
																					{
																						method_62(int_41, text3 + "Lỗi khi xác nhận. Lỗi: " + ex2.Message, device);
																						method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					}
																				}
																				else
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				}
																			}
																			else
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																			}
																			goto end_IL_5e1f;
																		IL_6c84:
																			if (!flag11)
																			{
																				method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																				method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			if (bool_0)
																			{
																				method_62(int_41, text3 + "Dừng chạy...", device);
																				method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																				goto end_IL_5e1f;
																			}
																			if (device.method_82("\"confirm\"", text13))
																			{
																				device.method_99("\"confirm\"");
																			}
																			else
																			{
																				device.method_99("\"xác nhận\"");
																			}
																			device.method_121(15.0);
																			int num39 = 0;
																			while (true)
																			{
																				if (num39 < 10)
																				{
																					text13 = device.method_93();
																					if (device.method_120(text13).Count == 1)
																					{
																						goto IL_6eac;
																					}
																					if (!device.method_82("skip", text13) && !device.method_82("bỏ qua", text13))
																					{
																						if (!device.method_82("we need more information", text13) && !device.method_82("Something went wrong. Please try again.", text13) && !device.method_82("chúng tôi cần thêm thông tin", text13))
																						{
																							if (device.method_82("enter the code from your sms", text13) || device.method_82("nhập mã từ sms của bạn", text13) || device.method_82("nhập mã từ email của bạn", text13))
																							{
																								if (num39 == 3)
																								{
																									flag2 = false;
																									method_62(int_41, text3 + "Lỗi xác thực số điện thoại từ Facebook...Goto Newfeed", device);
																									break;
																								}
																								method_62(int_41, text3 + "Xác nhận lại lần " + num39, device);
																								device.method_121(2.0);
																								if (device.method_82("\"confirm\"", text13))
																								{
																									device.method_99("\"confirm\"");
																								}
																								else
																								{
																									device.method_99("\"xác nhận\"");
																								}
																								flag11 = true;
																								flag2 = true;
																							}
																							goto IL_6eac;
																						}
																						method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																						method_42(int_41, "Checkpoint");
																						flag5 = true;
																						break;
																					}
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_5e1f;
																					}
																					flag11 = true;
																					if (device.method_82("skip", text13))
																					{
																						device.method_99("\"skip\"");
																					}
																					else
																					{
																						device.method_99("\"bỏ qua\"");
																					}
																				}
																				if (!flag11)
																				{
																					method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																					method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				if (bool_0)
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				method_62(int_41, text3 + "Thêm 5 bạn bè gợi ý...", device);
																				device.method_121(2.0);
																				text13 = device.method_93();
																				if (device.method_82("add 5 friends", text13) || device.method_82("thêm 5 người bạn", text13) || device.method_82("mời tất cả", text13))
																				{
																					if (bool_0)
																					{
																						method_62(int_41, text3 + "Dừng chạy...", device);
																						method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																						goto end_IL_5e1f;
																					}
																					flag11 = true;
																					if (device.method_82("add 5 friends", text13))
																					{
																						device.method_99("\"add 5 friends\"", "", 10);
																					}
																					else if (device.method_82("thêm 5 người bạn", text13))
																					{
																						device.method_99("\"thêm 5 người bạn\"", "", 10);
																					}
																					else if (device.method_82("mời tất cả", text13))
																					{
																						device.method_99("\"mời tất cả\"", "", 10);
																					}
																				}
																				else
																				{
																					flag11 = true;
																					if (device.method_82("skip", text13))
																					{
																						device.method_99("\"skip\"", "", 10);
																					}
																					else if (device.method_82("bỏ qua", text13))
																					{
																						device.method_99("\"bỏ qua\"", "", 10);
																					}
																					else if (device.method_82("xong", text13))
																					{
																						device.method_99("\"xong\"", "", 10);
																					}
																					else if (device.method_82("tiếp", text13))
																					{
																						device.method_99("\"tiếp\"", "", 10);
																					}
																				}
																				if (!flag11)
																				{
																					method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																					method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				if (bool_0)
																				{
																					method_62(int_41, text3 + "Dừng chạy...", device);
																					method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																					goto end_IL_5e1f;
																				}
																				device.method_121(1.0);
																				if (device.method_82("\"xong\""))
																				{
																					device.method_99("\"xong\"");
																				}
																				if (device.method_82("\"ok\""))
																				{
																					device.method_99("\"ok\"");
																				}
																				break;
																			IL_6eac:
																				num39++;
																			}
																			break;
																			continue;
																		end_IL_6c5f:
																			break;
																		}
																	}
																	goto IL_738b;
																IL_5e64:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5c24:
																	flag2 = true;
																	continue;
																IL_5e8d:
																	method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5ee2:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5f39:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																IL_5f62:
																	method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
																	flag2 = false;
																	device.method_12();
																	goto IL_738b;
																	continue;
																end_IL_5e1f:
																	break;
																}
																goto end_IL_3756;
															IL_5776:
																if (device.method_52("DataClick\\image\\inputotpckp"))
																{
																	device.method_3("DataClick\\image\\inputotpckp");
																}
																else
																{
																	device.method_91(32, 173);
																}
																device.method_121(1.0);
																device.method_102(text44);
																device.method_99("\"tiếp\"");
																bool flag19 = false;
																for (int num40 = 0; num40 < 20; num40++)
																{
																	text13 = device.method_93();
																	if (device.method_82("bạn có thể dùng facebook", text13))
																	{
																		flag19 = true;
																		flag4 = true;
																		flag2 = true;
																		break;
																	}
																}
																if (flag19)
																{
																	if (device.method_52("DataClick\\image\\truycapfacebook"))
																	{
																		device.method_3("DataClick\\image\\truycapfacebook");
																	}
																	else
																	{
																		device.method_91(160, 165);
																	}
																	flag11 = true;
																	device.method_121(1.0);
																}
																else
																{
																	method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																	method_42(int_41, "Checkpoint");
																	flag5 = true;
																}
																goto IL_738b;
															IL_7fe5:
																if (!flag11)
																{
																	method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_3756;
																}
																if (bool_6)
																{
																	method_62(int_41, text3 + "Bật 2FA...", device);
																	try
																	{
																		for (int num41 = 0; num41 < 2; num41++)
																		{
																			if (!bool_0)
																			{
																				int num42 = 0;
																				num42 = ((!flag2) ? method_35(int_41, int_42, device, 1) : method_34(int_41, device));
																				if (num42 != 1)
																				{
																					method_62(int_41, text3 + "Bật 2FA thất bại. Thử bật lại...");
																					continue;
																				}
																				method_62(int_41, text3 + "Bật 2FA thành công", device);
																				device.method_121(1.0);
																				break;
																			}
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																	}
																	catch (Exception exception_2)
																	{
																		Common.smethod_82(exception_2, "HDOnOff2FA");
																		goto IL_8211;
																	}
																}
																if (bool_15)
																{
																	try
																	{
																		method_62(int_41, text3 + "Đồng bộ danh bạ...", device);
																		device.method_124();
																		device.method_121(1.0);
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			goto end_IL_3756;
																		}
																		int num43 = 0;
																		for (int num44 = 0; num44 < 2; num44++)
																		{
																			if (method_30(int_41, text3, device, int_28, int_29, bool_13, bool_14, int_30, int_31, int_32, int_33) != 0)
																			{
																				method_62(int_41, text3 + "Đồng bộ danh bạ xong...", device);
																				break;
																			}
																		}
																		goto IL_8211;
																	}
																	catch (Exception)
																	{
																		goto IL_8211;
																	}
																}
																goto IL_8211;
															IL_8211:
																if (text19 != "")
																{
																	string text52 = "";
																	text52 = ((int_9 == 5) ? ("|" + method_38(int_41)) : "");
																	if (!flag2)
																	{
																		if (flag5)
																		{
																			object obj12 = object_10;
																			lock (obj12)
																			{
																				File.AppendAllText("output/facebook/acc_282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																			}
																		}
																		else
																		{
																			string text53 = method_37(int_41);
																			object obj12 = object_7;
																			if (text53 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Noverify_2fa.txt", text19 + "|" + text16 + "|" + text53 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Noverify.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																		}
																	}
																	else if (rdThuePhone.Checked || bool_16)
																	{
																		string text54 = method_37(int_41);
																		object obj12 = object_8;
																		if (Settings.Default.isThuVeriCheckPoint && flag4)
																		{
																			if (text54 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/VerifySdt_checkpoint282_2fa.txt", text19 + "|" + text16 + "|" + text54 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/VerifySdt_checkpoint282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																				}
																			}
																		}
																		else if (text54 != "")
																		{
																			lock (obj12)
																			{
																				File.AppendAllText("output/facebook/VerifySdt_2fa.txt", text19 + "|" + text16 + "|" + text54 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																			}
																		}
																		else
																		{
																			lock (obj12)
																			{
																				File.AppendAllText("output/facebook/VerifySdt.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + Environment.NewLine);
																			}
																		}
																	}
																	else
																	{
																		string text55 = method_37(int_41);
																		object obj12 = object_9;
																		if (rdHotMailReg.Checked || rdHotMailRegisted.Checked)
																		{
																			if (text55 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/VerifyHotMail_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text6 + "|" + text7 + "|" + text52 + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/VerifyHotMail.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text6 + "|" + text7 + "|" + text52 + Environment.NewLine);
																				}
																			}
																		}
																		else if (rdTempMailIO.Checked)
																		{
																			if (text55 != "")
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																				}
																			}
																			else
																			{
																				lock (obj12)
																				{
																					File.AppendAllText("output/facebook/Verify_tempmail.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																				}
																			}
																		}
																		else if (bool_17)
																		{
																			if (Settings.Default.isThuVeriCheckPoint && flag4)
																			{
																				if (int_38 == 0)
																				{
																					if (text55 != "")
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/VerifyMail_checkpoint282_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																					else
																					{
																						lock (obj12)
																						{
																							File.AppendAllText("output/facebook/VerifyMail_checkpoint282.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																						}
																					}
																				}
																			}
																			else if (int_38 == 0)
																			{
																				if (text55 != "")
																				{
																					lock (obj12)
																					{
																						File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text19 + "|" + text16 + "|" + text55 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																					}
																				}
																				else
																				{
																					lock (obj12)
																					{
																						File.AppendAllText("output/facebook/Verify_tempmail.txt", text19 + "|" + text16 + "|" + text20 + "|" + text21 + "|" + text52 + "|" + method_39(int_41) + Environment.NewLine);
																					}
																				}
																			}
																		}
																	}
																}
																device.method_121(1.0);
																method_62(int_41, text3 + "Tắt app Facebook và mở lại", device);
																device.method_121(1.0);
																device.method_70();
																device.method_121(3.0);
																device.method_105();
																device.method_121(1.0);
																if (flag11)
																{
																	if (chkReadNotifi.Checked)
																	{
																		method_62(int_41, text3 + "Đọc thông báo", device);
																		device.method_121(1.0);
																		method_32(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkWStory.Checked)
																	{
																		method_62(int_41, text3 + "Lướt story", device);
																		device.method_121(1.0);
																		method_29(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkAddFUID.Checked)
																	{
																		method_62(int_41, text3 + "Thêm bạn bè gợi ý", device);
																		int int_43 = Convert.ToInt32(nFriendFrom.Value);
																		int int_44 = Convert.ToInt32(nFriendFrom.Value);
																		device.method_121(1.0);
																		method_28(int_41, text3, device, int_43, int_44);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkInNewfeed.Checked)
																	{
																		method_62(int_41, text3 + "Tương tác newsfeed", device);
																		device.method_121(1.0);
																		method_26(int_41, text3, device);
																	}
																	if (bool_0)
																	{
																		method_62(int_41, text3 + "Dừng chạy...", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_3756;
																	}
																	if (chkWatch.Checked)
																	{
																		method_62(int_41, text3 + "Xem watch", device);
																		device.method_121(1.0);
																		method_25(int_41, text3, device, 1, 5, 10, 20, bool_18: true, 1, 5, bool_19: true, 1, 3, bool_20: false, null, 0, 0, 100, 100, 100);
																	}
																}
																if (Settings.Default.isCheckUID)
																{
																	method_62(int_41, text3 + "Check uid và wall...", device);
																	device.method_121(1.0);
																	if (method_48(text19) && Common.smethod_33(text19).StartsWith("0|"))
																	{
																		method_42(int_41, "Live");
																		if (flag5)
																		{
																			method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																		}
																		else
																		{
																			method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
																		}
																	}
																	else
																	{
																		method_42(int_41, "Die");
																		method_49("Tài khoản die!!!", device.int_0, int_41, int_42, device, bool_18: false);
																	}
																}
																else if (flag5)
																{
																	method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
																}
																else
																{
																	method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
																}
																goto end_IL_3756;
																continue;
															end_IL_4ccc:
																break;
															}
															goto IL_909d;
															continue;
														end_IL_3756:
															break;
														}
														break;
														continue;
													end_IL_2a36:
														break;
													}
													break;
												}
												method_62(int_41, text3 + "Bị treo LD khi mở app facebook. Thực hiện lại.", device);
												device.method_70();
												device.method_121(1.0);
												continue;
											}
											catch (Exception exception_3)
											{
												method_62(int_41, text3 + "Lỗi treo LD khi mở app Facebook", device);
												method_49("Lỗi treo LD khi mở app Facebook", device.int_0, int_41, int_42, device, bool_18: false);
												Common.smethod_82(exception_3, "ErrorOpenAppFacebook");
											}
											break;
										}
										break;
									}
								IL_moapp:
									method_62(int_41, text3 + "Mở App Facebook Lite", device);
									device.method_40();
									string text56 = "";
									try
									{
										if (bool_0)
										{
											method_62(int_41, text3 + "Dừng chạy...", device);
											method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
											break;
										}
										device.method_106();
										bool flag20 = false;
										bool flag21 = false;
										bool flag22 = false;
										int num45 = 0;
										for (int num46 = 0; num46 < 30; num46++)
										{
											if (device.method_52("DataClick\\fblite\\facebook"))
											{
												flag20 = true;
												break;
											}
										}
										if (flag20)
										{
											device.method_121(1.0);
											method_62(int_41, text3 + "Đăng ký facebook lite", device);
											if (device.method_52("DataClick\\fblite\\tiengviet"))
											{
												device.method_3("DataClick\\fblite\\tiengviet");
											}
											device.method_121(1.0);
											if (!device.method_52("DataClick\\fblite\\createaccount"))
											{
												device.method_91(32, 376); // Tieng viet
												device.method_121(1.0);
											}
											if (device.method_52("DataClick\\fblite\\createaccount"))
											{
												device.method_3("DataClick\\fblite\\createaccount");
											}
											device.method_121(1.0);
											if (device.method_52("DataClick\\fblite\\next"))
											{
												device.method_3("DataClick\\fblite\\next");
											}
											device.method_121(1.0);
											method_62(int_41, text3 + "Tạo thông tin đăng ký", device);
											string text57 = "";
											string text58 = "";
											string text59 = "";
											string text60 = "";
											string text61 = "";
											string text62 = "";
											string text63 = "";
											string text64 = "";
											string text65 = "";
											string text66 = "";
											string text67 = "";
											string text68 = "";
											string text69 = "";
											string text669 = "";
											string text70 = "";
											string text71 = "";
											bool flag23 = false;
											bool flag223 = false;
											string text72 = random_0.Next(0, 2).ToString();
											if (int_13 == 0)
											{
												text72 = "0";
											}
											else if (int_13 == 1)
											{
												text72 = "1";
											}
											if (int_12 == 0)
											{
												text57 = method_6();
												text58 = ((!(text72 == "0")) ? method_7() : method_8());
											}
											else if (int_12 == 1)
											{
												text57 = method_3();
												text58 = ((!(text72 == "0")) ? method_5() : method_4());
											}
											else if (int_12 == 2)
											{
												text57 = method_9();
												text58 = ((!(text72 == "0")) ? method_10() : method_11());
												text70 = method_3();
												text71 = ((!(text72 == "0")) ? method_5() : method_4());
											}
											text59 = ((int_12 == 2) ? ((!bool_5) ? string_14.Trim() : Common.smethod_75(text71 + text70)) : ((!bool_5) ? string_14.Trim() : Common.smethod_75(text58 + text57)));
											method_52(text57, "ho", int_41, 0, dgvAcc);
											method_52(text58, "ten", int_41, 0, dgvAcc);
											method_52((text72 == "1") ? "Nam" : "Nữ", "gender", int_41, 0, dgvAcc);
											method_52(text59, "pass", int_41, 0, dgvAcc);
											text60 = string_11;
											if (bool_16)
											{
												text60 = string_20;
											}
											for (int num47 = 0; num47 < 10; num47++)
											{
												text56 = device.method_93();
												if (device.method_52("DataClick\\fblite\\whatyourname"))
												{
													flag23 = true;
													break;
												}
											}
											if (!flag23)
											{
												method_62(int_41, text3 + "Lỗi khi đăng ký", device);
												method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											method_62(int_41, text3 + "Nhập họ", device);
											device.method_49(text57, bool_0: false, bool_1: false);
											device.method_121(1.0);
											method_62(int_41, text3 + "Nhập tên", device);
											device.method_91(176, 165);
											device.method_121(1.0);
											device.method_49(text58, bool_0: false, bool_1: false);
											device.method_121(1.0);
											if (device.method_52("DataClick\\fblite\\next"))
											{
												device.method_3("DataClick\\fblite\\next");
											}
											device.method_121(1.0);
											for (int num48 = 0; num48 < 5; num48++)
											{
												text56 = device.method_93();
												if (!device.method_52("DataClick\\fblite\\yourphone"))
												{
													flag23 = false;
													continue;
												}
												flag23 = true;
												break;
											}
											if (!flag23)
											{
												method_62(int_41, text3 + "Lỗi khi đăng ký", device);
												method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											}
											while (true)
											{
												if (!(string_12.Substring(0, 1) == "0"))
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													if (rdThuePhone.Checked)
													{
														try
														{
															int num49 = 0;
															while (true)
															{
																if (num49 != 2)
																{
																	method_62(int_41, text3 + "Đang lấy số điện thoại....", device);
																	if (string_12.Substring(2, 1) == "0")
																	{
																		text5 = Common.smethod_47(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "1")
																	{
																		text5 = Common.smethod_57(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "2")
																	{
																		text5 = Common.smethod_21(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "3")
																	{
																		text5 = Common.smethod_48(text60);
																		text9 = text5;
																	}
																	else if (string_12.Substring(2, 1) == "4")
																	{
																		text5 = Common.smethod_22(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "5")
																	{
																		text5 = Common.smethod_23(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "6")
																	{
																		text5 = Common.smethod_24(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "7")
																	{
																		text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "8")
																	{
																		text5 = Common.GetPhoneAhasim(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "9")
																	{
																		text5 = Common.GetPhoneOtptn(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "10")
																	{
																		text5 = Common.GetPhoneOtpFb(text60, ref text61);
																	}
																	else if (string_12.Substring(2, 1) == "11")
																	{
																		text5 = Common.GetPhoneAhasim(text60, ref text61);
																	}
																	if (!bool_0)
																	{
																		if (text5 == "")
																		{
																			num49++;
																			method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác!!!", device);
																			device.method_121(2.0);
																			continue;
																		}
																		if (text5 == "Đã hết số điện thoại, chờ cập nhật" && string_12.Substring(2, 1) == "3")
																		{
																			method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																			method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		if (text5 == "API sai" && string_12.Substring(2, 1) == "3")
																		{
																			method_62(int_41, text3 + "API sai. Kiểm tra lại API key..", device);
																			method_49("API sai. Kiểm tra lại API key..", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy...", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																		{
																			text5 = "+84" + text5;
																		}
																		if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																		{
																			text5 = "+84" + text5; // truoc la +1
																		}
																		method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																		method_52(text5, "phone", int_41, 0, dgvAcc);
																		device.method_121(1.0);
																		device.method_91(117, 181);
																		device.method_121(1.0);
																		device.method_45();
																		device.method_121(1.0);
																		device.method_49(text5, bool_0: false, bool_1: false);
																		flag2 = true;
																		device.method_121(1.0);
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																		goto IL_9eb2;
																	}
																	method_62(int_41, text3 + "Dừng chạy...");
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Đã hết số điện thoại", device);
																method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
														}
														catch
														{
															method_62(int_41, text3 + "Lỗi khi lấy số điện thoại", device);
															method_49("Lỗi khi lấy số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
														}
														break;
													}
													if (rdConfMail.Checked)
													{
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														if (num4 == 0 && device.method_52("DataClick\\fblite\\registerbymail"))
														{
															device.method_3("DataClick\\fblite\\registerbymail");
														}
														string text73 = string_12.Substring(2, 1);
														int num50 = 0;
														if (text73 != null)
														{
															if (!(text73 == "0"))
															{
																if (!(text73 == "1"))
																{
																	method_62(int_41, text3 + "Đang lấy TempMail...", device);
																	while (true)
																	{
																		string text74 = method_73();
																		string text75 = Common.smethod_19(text74);
																		if (!(text75 != ""))
																		{
																			if (num50 != 5)
																			{
																				num50++;
																				continue;
																			}
																			method_62(int_41, text3 + "Lỗi không lấy được tempmail...", device);
																			goto end_IL_a96f;
																		}
																		method_52(text75, "email", int_41, 0, dgvAcc);
																		flag2 = true;
																		device.method_91(59, 184);
																		device.method_121(1.0);
																		device.method_49(text75, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																		break;
																	}
																}
																else
																{
																	string text76 = list_1[int_41];
																	if (text76 != "")
																	{
																		method_62(int_41, text3 + "Nhập hotmail có sẵn....", device); //Fb lite
																		text6 = text76.Split('|')[0];
																		text7 = text76.Split('|')[1];
																		if (bool_0)
																		{
																			method_62(int_41, text3 + "Dừng chạy...", device);
																			method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		method_52(text6, "email", int_41, 0, dgvAcc);
																		method_52(text7, "passMail", int_41, 0, dgvAcc);
																		device.method_91(59, 184);
																		device.method_121(1.0);
																		device.method_49(text6, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																	}
																}
															}
															else
															{
																for (int num51 = 0; num51 < 5; num51++)
																{
																	if (!bool_0)
																	{
																		method_51(2.0);
																		method_62(int_41, text3 + "Đăng ký hotmail....", device); // Fb Lite
																		while (!method_85(int_41))
																		{
																			method_52("Đang tạo lại mail khác", "status", int_41, 0, dgvAcc);
																		}
																		if (!bool_0)
																		{
																			text6 = method_39(int_41);
																			text7 = method_40(int_41);
																			File.AppendAllText("output/facebook/hotmail.txt", string.Concat(new string[4]
																			{
																		text6,
																		"|",
																		text7,
																		Environment.NewLine
																			}));
																			device.method_121(1.0);
																			device.method_91(59, 184);
																			device.method_121(1.0);
																			device.method_49(text6, bool_0: false, bool_1: false);
																		}
																		if (device.method_52("DataClick\\fblite\\next"))
																		{
																			device.method_3("DataClick\\fblite\\next");
																		}
																		goto IL_9eb2;


																	}
																	else
																	{
																		method_62(int_41, text3 + "Dừng chạy...");
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_a96f;
																	}

																}
															}
														}
													}
												}
												else
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													if (string_12.Substring(1, 1) == "0")
													{

														method_62(int_41, text3 + "Đang tạo số điện thoại ảo....", device);
														device.method_91(117, 181);
														device.method_121(2.0);
														device.method_45();
														text66 = method_72(int_21);
														method_62(int_41, text3 + "Số điện thoại ảo:" + text66, device);
														method_52(text66, "phone", int_41, 0, dgvAcc);
														device.method_121(1.0);
														device.method_49(text66, bool_0: false, bool_1: false);
														device.method_121(1.0);

														if (device.method_52("DataClick\\fblite\\next"))
														{
															device.method_3("DataClick\\fblite\\next");
														}
														//else
														//                                       {
														//	method_62(int_41, text3 + "Không dùng được số này. Tạo lại...", device);
														//	method_49("Không dùng được số này. Tạo lại", device.int_0, int_41, int_42, device, bool_18: false);
														//	break;
														//	goto IL_moapp;

														//}
													}
													else
													{
														if (device.method_52("DataClick\\fblite\\registerbymail"))
														{
															device.method_3("DataClick\\fblite\\registerbymail");
														}
														device.method_121(1.0);
														device.method_91(27, 182);
														device.method_45();
														if (Convert.ToInt32(string_12.Substring(2, 1)) != 3)
														{
															method_62(int_41, text3 + "Đang tạo Email ảo....", device);
															text65 = method_76(text58, text57, Convert.ToInt32(string_12.Substring(2, 1)));
														}
														else
														{
															method_62(int_41, text3 + "Đang lấy mail từ Temp-mail.io....", device);
															string text77 = method_73();
															text65 = Common.smethod_19(text77);
														}
														if (text65 == string.Empty)
														{
															method_62(int_41, text3 + "Không tạo được email ảo...", device);
															method_49("Không tạo được email ảo", device.int_0, int_41, int_42, device, bool_18: false);
														}
														method_62(int_41, text3 + "Email ảo:" + text65, device);
														method_52(text65, "email", int_41, 0, dgvAcc);
														device.method_121(1.0);
														device.method_49(text65, bool_0: false, bool_1: false);
														device.method_121(1.0);
														if (device.method_52("DataClick\\fblite\\next"))
														{
															device.method_3("DataClick\\fblite\\next");
														}
													}
												}
												goto IL_9eb2;
											IL_a50c:
												if (num45 != 5)
												{
													method_62(int_41, text3 + "Thử nhập lại mật khẩu", device);
													flag22 = true;
													num45++;
													goto IL_a53f;
												}
												bool flag24 = false;
												goto IL_ac6f;
											IL_a6eb:
												method_62(int_41, text3 + "Trùng số. Lấy số khác", device);
												flag21 = true;
												continue;
											IL_d388: // GET UID DIE OR LIVE
												string text78 = device.method_14(int_42.ToString());
												if (text78 != "")
												{
													text62 = text78.Split('|')[0];
													text64 = text78.Split('|')[1];
													text63 = text78.Split('|')[2];
													method_52(text62, "uid", int_41, 0, dgvAcc);
													method_52(text63, "token", int_41, 0, dgvAcc);
													method_52(text64, "cookie", int_41, 0, dgvAcc);
												}
												if (!flag5 && flag2)
												{
													if (bool_3)
													{
														method_62(int_41, text3 + "Up avatar...", device);
														if (method_65(text62, device))
														{
															method_62(int_41, text3 + "Up avatar thành công", device);
														}
														else
														{
															method_62(int_41, text3 + "Up avatar thất bại", device);
														}
													}
													if (bool_6)
													{
														method_62(int_41, text3 + "Bật 2FA...", device);
														if (method_64(int_41, device))
														{
															method_62(int_41, text3 + "Bật 2FA thành công", device);
														}
														else
														{
															method_62(int_41, text3 + "Bật 2FA thất bại", device);
														}
													}
												}
												string text79 = "";
												text79 = ((int_9 == 5) ? ("|" + method_38(int_41)) : "");
												if (text62 != "")
												{
													if (!flag2)
													{
														if (flag5)
														{
															object obj14 = object_10;
															lock (obj14)
															{
																File.AppendAllText("output/facebook/acc_282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
														else
														{
															string text80 = method_37(int_41);
															object obj14 = object_7;
															if (text80 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Noverify_2fa.txt", text62 + "|" + text59 + "|" + text80 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Noverify.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
														}
													}
													else if (rdThuePhone.Checked || bool_16)
													{
														string text81 = method_37(int_41);
														object obj14 = object_8;
														if (Settings.Default.isThuVeriCheckPoint && flag4)
														{
															if (text81 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifySdt_checkpoint282_2fa.txt", text62 + "|" + text59 + "|" + text81 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifySdt_checkpoint282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
																}
															}
														}
														else if (text81 != "")
														{
															lock (obj14)
															{
																File.AppendAllText("output/facebook/VerifySdt_2fa.txt", text62 + "|" + text59 + "|" + text81 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
														else
														{
															lock (obj14)
															{
																File.AppendAllText("output/facebook/VerifySdt.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + Environment.NewLine);
															}
														}
													}
													else
													{
														string text82 = method_37(int_41);
														object obj14 = object_9;
														if (rdHotMailReg.Checked || rdHotMailRegisted.Checked)
														{
															if (text82 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifyHotMail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text6 + "|" + text7 + "|" + text79 + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/VerifyHotMail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text6 + "|" + text7 + "|" + text79 + Environment.NewLine);
																}
															}
														}
														else if (rdTempMailIO.Checked)
														{
															if (text82 != "")
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																}
															}
															else
															{
																lock (obj14)
																{
																	File.AppendAllText("output/facebook/Verify_tempmail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																}
															}
														}
														else if (bool_17)
														{
															if (Settings.Default.isThuVeriCheckPoint && flag4)
															{
																if (int_38 == 0)
																{
																	if (text82 != "")
																	{
																		lock (obj14)
																		{
																			File.AppendAllText("output/facebook/VerifyMail_checkpoint282_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																		}
																	}
																	else
																	{
																		lock (obj14)
																		{
																			File.AppendAllText("output/facebook/VerifyMail_checkpoint282.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																		}
																	}
																}
															}
															else if (int_38 == 0)
															{
																if (text82 != "")
																{
																	lock (obj14)
																	{
																		File.AppendAllText("output/facebook/Verify_tempmail_2fa.txt", text62 + "|" + text59 + "|" + text82 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																	}
																}
																else
																{
																	lock (obj14)
																	{
																		File.AppendAllText("output/facebook/Verify_tempmail.txt", text62 + "|" + text59 + "|" + text63 + "|" + text64 + "|" + text79 + "|" + method_39(int_41) + Environment.NewLine);
																	}
																}
															}
														}
													}
												}
												if (Settings.Default.isCheckUID)
												{
													method_62(int_41, text3 + "Check uid và wall...", device);
													device.method_121(1.0);
													if (method_48(text62) && Common.smethod_33(text62).StartsWith("0|"))
													{
														method_42(int_41, "Live");
														if (flag5)
														{
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
														}
														else
														{
															method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
														}
													}
													else
													{
														method_42(int_41, "Die");
														method_49("Tài khoản die!!!", device.int_0, int_41, int_42, device, bool_18: false);
													}
												}
												else if (flag5)
												{
													method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
												}
												else
												{
													method_49("Tạo tài khoản thành công", device.int_0, int_41, int_42, device, bool_18: true);
												}
												break;
											giaicp282:
												if (Settings.Default.isThuVeriCheckPoint)
												{
													method_62(int_41, text3 + "Checkpoint...thử xác nhận", device);
													flag3 = true;
													goto IL_aca6;
												}
												method_62(int_41, text3 + "Checkpoint 282!!!", device);
												flag5 = true;
												flag2 = false;
												method_42(int_41, "Checkpoint");
												goto IL_d388;
											IL_aca6:
												string text86;
												if (flag3)
												{
													if (bool_0)
													{
														method_62(int_41, text3 + "Dừng chạy...", device);
														method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													device.method_99("\"tiếp tục\"");
													for (int num52 = 0; num52 < 5; num52++)
													{
														text56 = device.method_93();
														if (device.method_82("giúp chúng tôi xác nhận đó là bạn", text56))
														{
															method_62(int_41, "Captcha...Không xác thực", device);
															method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
															goto end_IL_a96f;
														}
													}
													if (bool_16 || rdThuePhone.Checked)
													{
														int num53 = 0;
														while (true)
														{
															if (num53 == 0)
															{
																method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
															}
															else
															{
																if (bool_0)
																{
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lấy số khác...Lần: " + num53, device);
																device.method_121(1.0);
																int tickCount4 = Environment.TickCount;
																while ((Environment.TickCount - tickCount4) / 1000 - int_39 < 0)
																{
																	if (!bool_0)
																	{
																		method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount4) / 1000).ToString()), device);
																		continue;
																	}
																	method_62(int_41, "Dừng chạy!", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_b4a0;
																}
															}
															text5 = "";
															if (bool_16)
															{
																if (int_37 == 0)
																{
																	text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																}
																else if (int_37 == 1)
																{
																	text5 = Common.smethod_57(text60, ref text61);
																	text9 = text5;
																}
																else if (int_37 == 2)
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (int_37 == 3)
																{
																	text5 = Common.smethod_48(text60);
																}
																else if (int_37 == 4)
																{
																	text5 = Common.smethod_27(text60, text61);
																}
																else if (int_37 == 5)
																{
																	text5 = Common.smethod_25(text60, text61);
																}
																else if (int_37 == 6)
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (int_37 == 7)
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (int_37 == 8)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																}
																else if (int_37 == 9)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
															}
															else if (string_12.Substring(2, 1) == "0")
															{
																text5 = Common.smethod_47(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "1")
															{
																text5 = Common.smethod_57(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "2")
															{
																text5 = Common.smethod_21(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "3")
															{
																text5 = Common.smethod_48(text60);
																text9 = text5;
															}
															else if (string_12.Substring(2, 1) == "4")
															{
																text5 = Common.smethod_22(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "5")
															{
																text5 = Common.smethod_23(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "6")
															{
																text5 = Common.smethod_24(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "7")
															{
																text5 = Common.GetPhoneWinMailShop(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "8")
															{
																text5 = Common.GetPhoneAhasim(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "9")
															{
																text5 = Common.GetPhoneOtptn(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "10")
															{
																text5 = Common.GetPhoneOtpFb(text60, ref text61);
															}
															else if (string_12.Substring(2, 1) == "11")
															{
																text5 = Common.GetPhoneAhasim(text60, ref text61);
															}
															if (text5 != "")
															{
																if (!(text5 == "API sai"))
																{
																	if (text5 == "Đã hết số điện thoại, chờ cập nhật")
																	{
																		method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
																		flag2 = false;
																		device.method_12();
																	}
																	if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																	{
																		text5 = "+84" + text5;
																	}
																	if (device.method_52("DataClick\\image\\inputsdtemail"))
																	{
																		device.method_3("DataClick\\image\\inputsdtemail");
																	}
																	else
																	{
																		device.method_99("nhập số điện thoại hoặc email mới");
																	}
																	method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																	method_52(text5, "phone", int_41, 0, dgvAcc);
																	device.method_121(1.0);
																	device.method_102(text5);
																	device.method_121(1.0);
																	if (device.method_52("DataClick\\image\\sendcodeotp"))
																	{
																		device.method_3("DataClick\\image\\sendcodeotp");
																	}
																	else
																	{
																		device.method_99("gửi mã đăng nhập");
																	}
																	bool flag25 = false;
																	for (int num54 = 0; num54 < 5; num54++)
																	{
																		text56 = device.method_93();
																		if (device.method_82("nhập mã mà chúng tôi vừa gửi qua tin nhắn văn bản", text56))
																		{
																			flag25 = true;
																			break;
																		}
																	}
																	if (flag25)
																	{
																		method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																		string text83 = string.Empty;
																		if (bool_16)
																		{
																			if (int_37 == 0)
																			{
																				text83 = Common.smethod_26(text60, text61, int_14);
																			}
																			else if (int_37 == 1)
																			{
																				text83 = Common.smethod_28(text60, text9, int_14);
																			}
																			else if (int_37 == 2)
																			{
																				text83 = Common.smethod_27(text60, text61, int_14);
																			}
																			else if (int_37 == 3)
																			{
																				text83 = Common.smethod_45(text60, text61, int_14);
																			}
																			else if (int_37 == 4)
																			{
																				text83 = Common.smethod_46(text60, text61, int_14);
																			}
																			else if (int_37 == 5)
																			{
																				text83 = Common.GetCodeWinMailShop(text60, text61, int_14);
																			}
																			else if (int_37 == 6)
																			{
																				text83 = Common.GetCodeAhasim(text60, text61, int_14);
																			}
																			else if (int_37 == 7)
																			{
																				text83 = Common.GetCodeOtptn(text60, text61, int_14);
																			}
																			else if (int_37 == 8)
																			{
																				text83 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																			}
																			else if (int_37 == 9)
																			{
																				text83 = Common.GetCodeAhasim(text60, text61, int_14);
																			}
																		}
																		else if (string_12.Substring(2, 1) == "0")
																		{
																			text83 = Common.smethod_44(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "1")
																		{
																			text83 = Common.smethod_61(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "2")
																		{
																			text83 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "3")
																		{
																			text83 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "4")
																		{
																			text83 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "5")
																		{
																			text83 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "6")
																		{
																			text83 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "7")
																		{
																			text83 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "8")
																		{
																			text83 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "9")
																		{
																			text83 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "10")
																		{
																			text83 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "11")
																		{
																			text83 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		if (!(text83 != ""))
																		{
																			if (num53 != 5)
																			{
																				if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																				{
																					device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																				}
																				else
																				{
																					device.method_99("cập nhật thông tin liên hệ");
																				}
																				num53++;
																				continue;
																			}
																			method_62(int_41, text3 + "Hết số điện thoại", device);
																			method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		if (device.method_52("DataClick\\image\\inputotpckp"))
																		{
																			device.method_3("DataClick\\image\\inputotpckp");
																		}
																		else
																		{
																			device.method_91(32, 173);
																		}
																		device.method_121(1.0);
																		device.method_102(text83);
																		device.method_121(1.0);
																		device.method_99("\"tiếp\"");
																		bool flag26 = false;
																		for (int num55 = 0; num55 < 20; num55++)
																		{
																			text56 = device.method_93();
																			if (device.method_82("bạn có thể dùng facebook", text56))
																			{
																				flag26 = true;
																				flag4 = true;
																				flag2 = true;
																				break;
																			}
																		}
																		if (flag26)
																		{
																			if (device.method_52("DataClick\\image\\truycapfacebook"))
																			{
																				device.method_3("DataClick\\image\\truycapfacebook");
																			}
																			else
																			{
																				device.method_91(160, 165);
																			}
																			device.method_121(1.0);
																		}
																		else
																		{
																			method_62(int_41, text3 + "Checkpoint 282. Lưu acc", device);
																			method_42(int_41, "Checkpoint");
																			flag5 = true;
																		}
																		goto IL_d388;
																	}
																	if (num53 != 5)
																	{
																		device.method_44("nhập số điện thoại hoặc email mới");
																		num53++;
																		continue;
																	}
																	method_62(int_41, text3 + "Hết số điện thoại", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "API key sai...", device);
																method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															if (text5 == "Đã hết số điện thoại, chờ cập nhật")
															{
																method_62(int_41, text3 + "Hết số điện thoại", device);
																method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															else
															{
																method_62(int_41, text3 + "Hết số điện thoại", device);
																method_49("Hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															break;
															continue;
														end_IL_b4a0:
															break;
														}
														break;
													}
													if (bool_17 || rdConfMail.Checked)
													{
														if (rdConfMail.Checked)
														{
															if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
															{
																device.method_3("DataClick\\image\\capnhatthongtinlienhe");
															}
															else
															{
																device.method_99("cập nhật thông tin liên hệ");
															}
														}
														int num56 = 0;
														while (true)
														{
															method_62(int_41, text3 + "Đang lấy tempmail.io", device);
															string text84 = "";
															string text85 = method_73();
															if (int_38 == 0)
															{
																text84 = Common.smethod_19(text85);
															}
															if (!(text84 != ""))
															{
																break;
															}
															if (device.method_52("DataClick\\image\\inputsdtemail"))
															{
																device.method_3("DataClick\\image\\inputsdtemail");
																method_62(int_41, text3 + "TempMail:" + text84, device);
																method_52(text84, "email", int_41, 0, dgvAcc);
																device.method_121(1.0);
																device.method_102(text84);
																device.method_121(1.0);
																if (device.method_52("DataClick\\image\\sendcodeotp"))
																{
																	device.method_3("DataClick\\image\\sendcodeotp");
																}
																else
																{
																	device.method_99("gửi mã đăng nhập");
																}
															}
															bool flag27 = false;
															for (int num57 = 0; num57 < 5; num57++)
															{
																text56 = device.method_93();
																if (device.method_82("nhập mã xác nhận", text56))
																{
																	flag27 = true;
																	break;
																}
															}
															if (flag27)
															{
																method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																text86 = Common.smethod_20(method_39(int_41));
																if (!(text86 != ""))
																{
																	if (num56 != 5)
																	{
																		if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																		{
																			device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																		}
																		else
																		{
																			device.method_99("cập nhật thông tin liên hệ");
																		}
																		num56++;
																		continue;
																	}
																	method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	goto end_IL_a96f;
																}
																goto IL_b9eb;
															}
															if (num56 != 5)
															{
																if (device.method_52("DataClick\\image\\capnhatthongtinlienhe"))
																{
																	device.method_3("DataClick\\image\\capnhatthongtinlienhe");
																}
																else
																{
																	device.method_99("cập nhật thông tin liên hệ");
																}
																num56++;
																continue;
															}
															method_62(int_41, text3 + "Không thể xác thực tài khoản", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															goto end_IL_a96f;
														}
													}
												}
												goto IL_bf36;
											IL_9eb2:
												if (!bool_0)
												{
													if (!flag21)
													{
														for (int num58 = 0; num58 < 5; num58++)
														{
															text56 = device.method_93();
															if (!device.method_52("DataClick\\fblite\\yourbirthday"))
															{
																flag23 = false;
																continue;
															}
															flag23 = true;
															break;
														}
														if (flag23)
														{
															method_62(int_41, text3 + "Nhập ngày sinh....", device);
															List<string> list3 = new List<string>();
															list3.Add("160,468");
															list3.Add("54,393");
															list3.Add("160,392");
															list3.Add("267,392");
															list3.Add("53,417");
															list3.Add("160,415");
															list3.Add("268,414");
															list3.Add("52,441");
															list3.Add("160,443");
															list3.Add("268,440");
															List<string> list4 = list3;
															text68 = random_0.Next(1, 12).ToString();
															text67 = random_0.Next(1, 28).ToString();
															text69 = random_0.Next(Convert.ToInt32(DateTime.Now.Year.ToString()) - int_16, Convert.ToInt32(DateTime.Now.Year.ToString()) - int_15).ToString();
															method_52((Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(text69)).ToString(), "age", int_41, 0, dgvAcc);
															if (text68.Length < 2)
															{
																text68 = "0" + text68;
															}
															if (text67.Length < 2)
															{
																text67 = "0" + text67;
															}
															device.method_121(1.0);
															char[] array3 = text67.ToCharArray();
															foreach (char c in array3)
															{
																int index = Convert.ToInt32(c.ToString());
																device.method_47(Convert.ToInt32(list4[index].Split(',')[0]), Convert.ToInt32(list4[index].Split(',')[1]));
															}
															device.method_121(1.0);
															char[] array4 = text68.ToCharArray();
															foreach (char c2 in array4)
															{
																int index2 = Convert.ToInt32(c2.ToString());
																device.method_47(Convert.ToInt32(list4[index2].Split(',')[0]), Convert.ToInt32(list4[index2].Split(',')[1]));
															}
															device.method_121(1.0);
															char[] array5 = text69.ToCharArray();
															foreach (char c3 in array5)
															{
																int index3 = Convert.ToInt32(c3.ToString());
																device.method_47(Convert.ToInt32(list4[index3].Split(',')[0]), Convert.ToInt32(list4[index3].Split(',')[1]));
															}
															device.method_121(1.0);
															if (device.method_52("DataClick\\fblite\\next"))
															{
																device.method_3("DataClick\\fblite\\next");
															}
															device.method_121(1.0);
															if (!bool_0)
															{
																for (int num62 = 0; num62 < 5; num62++)
																{
																	text56 = device.method_93();
																	if (!device.method_52("DataClick\\fblite\\yourgender"))
																	{
																		flag23 = false;
																		continue;
																	}
																	flag23 = true;
																	break;
																}
																if (flag23)
																{
																	method_62(int_41, text3 + "Chọn giới tính....", device);
																	if (text72 == "0")
																	{
																		device.method_91(300, 169);
																	}
																	else if (text72 == "1")
																	{
																		device.method_91(303, 200);
																	}
																	device.method_121(1.0);
																	if (!bool_0)
																	{
																		for (int num63 = 0; num63 < 5; num63++)
																		{
																			text56 = device.method_93();
																			if (!device.method_52("DataClick\\fblite\\createpass"))
																			{
																				flag23 = false;
																				continue;
																			}
																			flag23 = true;
																			break;
																		}
																		if (!flag23)
																		{
																			method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																			method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																			break;
																		}
																		goto IL_a53f;
																	}
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "Lỗi khi đăng ký", device);
																method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Lỗi khi đăng ký", device);
														method_49("Lỗi khi đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													goto IL_a6c7;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
											IL_bf36:
												method_62(int_41, text3 + "Lưu thông tin đăng nhập..", device);
												device.method_91(233, 455);
												while (true)
												{
													if (string_12.Substring(0, 1) == "0" && !flag2)
													{
														if (bool_16)
														{
															device.method_121(1.0);
															device.method_91(53, 292);
															device.method_121(1.0);
															while (true)
															{
																if (num2 == 0)
																{
																	method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
																}
																else
																{
																	method_62(int_41, text3 + "Lấy số khác...Lần: " + num2, device);
																	device.method_121(1.0);
																	int tickCount5 = Environment.TickCount;
																	while ((Environment.TickCount - tickCount5) / 1000 - int_39 < 0)
																	{
																		if (!bool_0)
																		{
																			method_62(int_41, "Thời gian lấy số tiếp theo {time}s...".Replace("{time}", (int_39 - (Environment.TickCount - tickCount5) / 1000).ToString()), device);
																			continue;
																		}
																		method_62(int_41, "Dừng chạy!", device);
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_c2be;
																	}
																}
																text5 = "";
																if (int_37 == 0)
																{
																	text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																}
																else if (int_37 == 1)
																{
																	text5 = Common.smethod_57(text60, ref text61);
																	text9 = text5;
																}
																else if (int_37 == 2)
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (int_37 == 3)
																{
																	text5 = Common.smethod_48(text60);
																}
																else if (int_37 == 4)
																{
																	text5 = Common.smethod_27(text60, text61);
																}
																else if (int_37 == 5)
																{
																	text5 = Common.smethod_25(text60, text61);
																}
																else if (int_37 == 6)
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (int_37 == 7)
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (int_37 == 8)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																}
																else if (int_37 == 9)
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																if (text5 != "")
																{
																	if (!(text5 == "API sai"))
																	{
																		if (!(text5 == "Đã hết số điện thoại, chờ cập nhật"))
																		{
																			if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																			method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																			method_52(text5, "phone", int_41, 0, dgvAcc);
																			device.method_121(1.0);
																			device.method_91(300, 110);
																			device.method_121(1.0);
																			device.method_45();
																			device.method_121(1.0);
																			device.method_49(text5, bool_0: false, bool_1: false);
																			device.method_121(1.0);
																			if (device.method_52("DataClick\\fblite\\next"))
																			{
																				device.method_3("DataClick\\fblite\\next");
																			}
																			bool flag28 = false;
																			for (int num64 = 0; num64 < 10; num64++)
																			{
																				if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																				{
																					flag28 = true;
																					continue;
																				}
																				flag28 = false;
																				break;
																			}
																			if (!flag28)
																			{
																				goto IL_c2cd;
																			}
																			if (num2 != 5)
																			{
																				device.method_121(1.0);
																				device.method_91(53, 292);
																				device.method_121(1.0);
																				device.method_91(300, 110);
																				device.method_121(1.0);
																				device.method_45();
																				num2++;
																				continue;
																			}
																			goto IL_c54b;
																		}
																		goto IL_c574;
																	}
																	method_62(int_41, text3 + "API key sai...", device);
																	method_49("API key sai", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																if (num2 != 5)
																{
																	num2++;
																	continue;
																}
																goto IL_c5c4;
																continue;
															end_IL_c2be:
																break;
															}
															break;
														}
														if (bool_17)
														{
															device.method_121(1.0);
															device.method_91(53, 321);
															device.method_121(1.0);
															method_62(int_41, text3 + "Đang lấy tempmail.io", device);
															string text87 = "";
															while (true)
															{
																string text88 = method_73();
																if (int_38 == 0)
																{
																	text87 = Common.smethod_19(text88);
																}
																if (text87 != "")
																{
																	method_52(text87, "email", int_41, 0, dgvAcc);
																	device.method_91(300, 110);
																	device.method_121(1.0);
																	device.method_45();
																	device.method_121(1.0);
																	device.method_49(text87, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	if (device.method_52("DataClick\\fblite\\next"))
																	{
																		device.method_3("DataClick\\fblite\\next");
																	}
																	bool flag29 = false;
																	for (int num65 = 0; num65 < 10; num65++)
																	{
																		text56 = device.method_93();
																		if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																		{
																			flag29 = true;
																			continue;
																		}
																		flag29 = false;
																		break;
																	}
																	if (!flag29)
																	{
																		break;
																	}
																	if (num3 != 5)
																	{
																		device.method_121(1.0);
																		device.method_91(53, 321);
																		device.method_121(1.0);
																		device.method_91(300, 110);
																		device.method_121(1.0);
																		device.method_45();
																		num3++;
																		method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																		continue;
																	}
																	goto IL_c5e8;
																}
																if (num3 != 5)
																{
																	num3++;
																	method_62(int_41, text3 + "Lấy mail khác...Lần: " + num3, device);
																	continue;
																}
																goto IL_c611;
															}
															flag2 = true;
															continue;
														}
														flag2 = false;
														device.method_125();
														goto IL_d388;
													}
													while (true)
													{
														if (rdThuePhone.Checked || bool_16)
														{
															int num66 = 0;
															int num67 = 0;
															while (num67 < 2)
															{
																if (!bool_0)
																{
																	method_62(int_41, text3 + "Đang lấy mã OTP...", device);
																	string text89 = string.Empty;
																	if (rdThuePhone.Checked)
																	{
																		if (string_12.Substring(2, 1) == "0")
																		{
																			text89 = Common.smethod_44(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "1")
																		{
																			text89 = Common.smethod_61(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "2")
																		{
																			text89 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "3")
																		{
																			text89 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "4")
																		{
																			text89 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "5")
																		{
																			text89 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "6")
																		{
																			text89 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "7")
																		{
																			text89 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "8")
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "9")
																		{
																			text89 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "10")
																		{
																			text89 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (string_12.Substring(2, 1) == "11")
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																	}
																	else if (bool_16)
																	{
																		if (int_37 == 0)
																		{
																			text89 = Common.smethod_26(text60, text61, int_14);
																		}
																		else if (int_37 == 1)
																		{
																			text89 = Common.smethod_28(text60, text9, int_14);
																		}
																		else if (int_37 == 2)
																		{
																			text89 = Common.smethod_27(text60, text61, int_14);
																		}
																		else if (int_37 == 3)
																		{
																			text89 = Common.smethod_45(text60, text61, int_14);
																		}
																		else if (int_37 == 4)
																		{
																			text89 = Common.smethod_46(text60, text61, int_14);
																		}
																		else if (int_37 == 5)
																		{
																			text89 = Common.GetCodeWinMailShop(text60, text61, int_14);
																		}
																		else if (int_37 == 6)
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																		else if (int_37 == 7)
																		{
																			text89 = Common.GetCodeOtptn(text60, text61, int_14);
																		}
																		else if (int_37 == 8)
																		{
																			text89 = Common.GetCodethuecodetextnow(text60, text61, int_14);
																		}
																		else if (int_37 == 9)
																		{
																			text89 = Common.GetCodeAhasim(text60, text61, int_14);
																		}
																	}
																	if (text89 == "")
																	{
																		if (!bool_0)
																		{
																			num66++;
																			method_62(int_41, text3 + "Không lấy được mã OTP...", device);
																			if (!device.method_52("DataClick\\fblite\\inputsmsopt"))
																			{
																				if (num66 == 5)
																				{
																					flag2 = false;
																					device.method_125();
																				}
																				num67++;
																				continue;
																			}
																			goto IL_c952;
																		}
																		method_62(int_41, text3 + "Dừng chạy...");
																		method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																		goto end_IL_cdda;
																	}
																	flag2 = true;
																	method_62(int_41, text3 + "Mã OTP:" + text89, device);
																	device.method_91(154, 177);
																	device.method_121(1.0);
																	device.method_49(text89, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	device.method_91(160, 211);
																	break;
																}
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_cdda;
															}
														}
														else if (rdConfMail.Checked)
														{
															method_62(int_41, text3 + "Đang lấy mã OTP...", device);
															if (bool_0)
															{
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																break;
															}
															string text90 = string_12.Substring(2, 1);
															if (text90 != null)
															{
																if (!(text90 == "0"))
																{
																	if (!(text90 == "1"))
																	{
																		string text91 = Common.smethod_20(method_39(int_41)); // OTP tempmail.io
																		if (!(text91 != ""))
																		{
																			method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																			flag2 = false;
																			device.method_124();
																			goto IL_d388;
																		}
																		device.method_91(154, 177);
																		device.method_121(1.0);
																		device.method_49(text91, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		device.method_91(160, 211);
																	}
																}
																else
																{
																	string text92 = Common.smethod_31(text6, text7);
																	if (text92 == "")
																	{
																		flag2 = false;
																		method_52("Mail không nhận được OTP. Goto Newfeed", "status", int_41, 2, dgvAcc);
																		device.method_124();
																	}
																	if (text92.Contains("kcon"))
																	{
																		flag2 = false;
																		method_52("Không kê\u0301t nô\u0301i đươ\u0323c server hotmail!", "status", int_41, 2, dgvAcc);
																		device.method_124();
																	}
																	flag2 = true;
																	device.method_121(1.0);
																	device.method_91(154, 177);
																	device.method_121(1.0);
																	device.method_49(text92, bool_0: false, bool_1: false);
																	device.method_121(1.0);
																	device.method_91(160, 211);
																}
															}
														}
														else if (bool_17)
														{
															string text93 = Common.smethod_20(method_39(int_41));
															if (!(text93 != ""))
															{
																method_62(int_41, text3 + "Mail không nhận OTP - NoVeri account. Goto", device);
																flag2 = false;
																device.method_124();
																goto IL_d388;
															}
															device.method_91(137, 180);
															device.method_121(1.0);
															flag2 = true;
															device.method_49(text93, bool_0: false, bool_1: false);
															device.method_121(1.0);
															device.method_91(160, 211);
														}
														goto IL_d253;
													IL_d253:
														device.method_121(10.0);
														for (int num68 = 0; num68 < 10; num68++)
														{
															if (device.method_52("DataClick\\fblite\\skip"))
															{
																device.method_3("DataClick\\fblite\\skip");
																break;
															}
														}
														device.method_121(1.0);
														if (device.method_52("DataClick\\fblite\\skip"))
														{
															device.method_3("DataClick\\fblite\\skip");
														}
														device.method_121(5.0);
														text56 = device.method_93();
														if (device.method_82("thêm bạn bè", text56))
														{
															device.method_3("DataClick\\fblite\\skip");
															device.method_121(1.0);
															device.method_91(153, 320);
														}
														device.method_121(1.0);
														device.method_91(133, 311);
														if (bool_0)
														{
															method_62(int_41, text3 + "Dừng chạy...", device);
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														goto IL_d388;
													IL_c952:
														if (!bool_0)
														{
															device.method_121(1.0);
															device.method_91(53, 292);
															device.method_121(1.0);
															while (true)
															{
																method_62(int_41, text3 + "Đang lấy số điện thoại khác...", device);
																if (!rdThuePhone.Checked)
																{
																	if (bool_16)
																	{
																		if (int_37 == 0)
																		{
																			text5 = Common.smethod_47(text60, ref text61); // Chothuesimcode
																		}
																		else if (int_37 == 1)
																		{
																			text5 = Common.smethod_57(text60, ref text61);
																			text9 = text5;
																		}
																		else if (int_37 == 2)
																		{
																			text5 = Common.smethod_21(text60, ref text61);
																		}
																		else if (int_37 == 3)
																		{
																			text5 = Common.smethod_48(text60);
																		}
																		else if (int_37 == 4)
																		{
																			text5 = Common.smethod_27(text60, text61);
																		}
																		else if (int_37 == 5)
																		{
																			text5 = Common.smethod_25(text60, text61);
																		}
																		else if (int_37 == 6)
																		{
																			text5 = Common.GetPhoneOtpFb(text60, ref text61);
																		}
																		else if (int_37 == 7)
																		{
																			text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																		}
																		else if (int_37 == 8)
																		{
																			text5 = Common.GetPhoneAhasim(text60, ref text61); //2
																		}
																		else if (int_37 == 9)
																		{
																			text5 = Common.GetPhoneAhasim(text60, ref text61);
																		}
																	}
																}
																else if (string_12.Substring(2, 1) == "0")
																{
																	text5 = Common.smethod_47(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "1")
																{
																	text5 = Common.smethod_57(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "2")
																{
																	text5 = Common.smethod_21(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "3")
																{
																	text5 = Common.smethod_48(text60);
																	text9 = text5;
																}
																else if (string_12.Substring(2, 1) == "4")
																{
																	text5 = Common.smethod_22(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "5")
																{
																	text5 = Common.smethod_23(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "6")
																{
																	text5 = Common.smethod_24(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "7")
																{
																	text5 = Common.GetPhoneWinMailShop(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "8")
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "9")
																{
																	text5 = Common.GetPhoneOtptn(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "10")
																{
																	text5 = Common.GetPhoneOtpFb(text60, ref text61);
																}
																else if (string_12.Substring(2, 1) == "11")
																{
																	text5 = Common.GetPhoneAhasim(text60, ref text61);
																}
																if (!(text5 == ""))
																{
																	break;
																}
																if (!bool_0)
																{
																	method_62(int_41, text3 + "Không lấy được số điện thoại. Lấy số khác", device);
																	continue;
																}
																method_62(int_41, text3 + "Dừng chạy...", device);
																method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																goto end_IL_cdda;
															}
															if (!(text5 == "Đã hết số điện thoại, chờ cập nhật") || !(string_12.Substring(2, 1) == "3"))
															{
																if (!(text5 == "API sai"))
																{
																	if (!bool_0)
																	{
																		if (rdThuePhone.Checked)
																		{
																			if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
																			{
																				text5 = "+84" + text5;
																			}
																			if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																		}
																		else if (bool_16)
																		{
																			if (int_37 == 3 || int_37 == 9 || int_37 == 6)
																			{
																				text5 = "+84" + text5;
																			}
																			if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
																			{
																				text5 = "+84" + text5; // truoc la +1
																			}
																		}
																		method_62(int_41, text3 + "Số điện thoại:" + text5, device);
																		method_52(text5, "phone", int_41, 0, dgvAcc);
																		device.method_121(1.0);
																		device.method_91(64, 104);
																		device.method_121(1.0);
																		device.method_45();
																		device.method_121(1.0);
																		device.method_49(text5, bool_0: false, bool_1: false);
																		device.method_121(1.0);
																		device.method_3("DataClick\\fblite\\next1", null, 5);
																		device.method_121(1.0);
																		continue;
																	}
																	method_62(int_41, text3 + "Dừng chạy...", device);
																	method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
																	break;
																}
																method_62(int_41, text3 + "API key sai...Kiểm tra lại", device);
																method_49("API key sai...Kiểm tra lại", device.int_0, int_41, int_42, device, bool_18: false);
															}
															else
															{
																method_62(int_41, text3 + "Đã hết số điện thoại...", device);
																method_49("Đã hết số điện thoại", device.int_0, int_41, int_42, device, bool_18: false);
															}
														}
														else
														{
															method_62(int_41, text3 + "Dừng chạy...");
															method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
														}
														goto IL_d253;
														continue;
													end_IL_cdda:
														break;
													}
													break;
												IL_c5c4:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c611:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c574:
													method_62(int_41, text3 + "Hết số điện thoại. Chuyển sang noveri", device);
													flag2 = false;
													device.method_125();
													goto IL_d388;
												IL_c5e8:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_126("");
													goto IL_d388;
												IL_c54b:
													method_62(int_41, text3 + "Không veri được. Chuyển sang noveri" + text5, device);
													flag2 = false;
													device.method_12();
													goto IL_d388;
												IL_c2cd:
													flag2 = true;
												}
												break;
											IL_ac56:
												method_62(int_41, text3 + "Đăng ký thành công..", device);
												flag24 = true;
												goto IL_ac6f;
											IL_ac6f:
												if (!flag24)
												{
													method_62(int_41, text3 + "Đăng ký không thành công..", device);
													method_49("Đăng ký không thành công", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												goto IL_aca6;
											IL_b9eb:
												if (device.method_52("DataClick\\image\\inputotpckp"))
												{
													device.method_3("DataClick\\image\\inputotpckp");
												}
												else
												{
													device.method_91(32, 173);
												}
												device.method_121(1.0);
												device.method_102(text86);
												device.method_99("\"tiếp\"");
												bool flag30 = false;
												for (int num69 = 0; num69 < 20; num69++)
												{
													text56 = device.method_93();
													if (device.method_82("bạn có thể dùng facebook", text56))
													{
														flag30 = true;
														flag4 = true;
														flag2 = true;
														break;
													}
												}
												if (flag30)
												{
													if (device.method_52("DataClick\\image\\truycapfacebook"))
													{
														device.method_3("DataClick\\image\\truycapfacebook");
													}
													else
													{
														device.method_91(160, 165);
													}
													device.method_121(1.0);
													goto IL_d388;
												}
												if (device.method_52("DataClick\\fblite\\yeucauxemxet"))
												{
													device.method_3("DataClick\\fblite\\yeucauxemxet");
												}
												device.method_121(1.0);
												while (true)
												{
													method_62(int_41, text3 + "Đang lấy số điện thoại...", device);
													text5 = "";
													if (!bool_16)
													{
														if (string_12.Substring(2, 1) == "0")
														{
															text5 = Common.smethod_47(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "1")
														{
															text5 = Common.smethod_57(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "2")
														{
															text5 = Common.smethod_21(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "3")
														{
															text5 = Common.smethod_48(text60);
															text9 = text5;
														}
														else if (string_12.Substring(2, 1) == "4")
														{
															text5 = Common.smethod_22(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "5")
														{
															text5 = Common.smethod_23(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "6")
														{
															text5 = Common.smethod_24(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "7")
														{
															text5 = Common.GetPhoneWinMailShop(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "8")
														{
															text5 = Common.GetPhoneAhasim(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "9")
														{
															text5 = Common.GetPhoneOtptn(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "10")
														{
															text5 = Common.GetPhoneOtpFb(text60, ref text61);
														}
														else if (string_12.Substring(2, 1) == "11")
														{
															text5 = Common.GetPhoneAhasim(text60, ref text61);
														}
													}
													else if (int_37 == 0)
													{
														text5 = Common.smethod_21(text60, ref text61);
													}
													else if (int_37 == 1)
													{
														text5 = Common.smethod_48(text60);
														text9 = text5;
													}
													else if (int_37 == 2)
													{
														text5 = Common.smethod_22(text60, ref text61);
													}
													else if (int_37 == 3)
													{
														text5 = Common.smethod_23(text60, ref text61);
													}
													else if (int_37 == 4)
													{
														text5 = Common.smethod_24(text60, ref text61);
													}
													else if (int_37 == 5)
													{
														text5 = Common.GetPhoneWinMailShop(text60, ref text61);
													}
													else if (int_37 == 6)
													{
														text5 = Common.GetPhoneAhasim(text60, ref text61);
													}
													else if (int_37 == 7)
													{
														text5 = Common.GetPhoneOtptn(text60, ref text61);
													}
													else if (int_37 == 8)
													{
														text5 = Common.GetPhoneOtpFb(text60, ref text61);
													}
													else if (int_37 == 9)
													{
														text5 = Common.GetPhoneAhasim(text60, ref text61);
													}
													if (text5 != "")
													{
														break;
													}
													device.method_91(270, 195);
													device.method_45();
												}
												if (bool_0)
												{
													method_62(int_41, text3 + "Dừng chạy...", device);
													method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
													break;
												}
												if (rdThuePhone.Checked)
												{
													if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
													{
														text5 = "+84" + text5;
													}
													if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "3" || string_12.Substring(2, 1) == "4" || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7" || string_12.Substring(2, 1) == "9" || string_12.Substring(2, 1) == "10")
													{
														text5 = "+84" + text5; // truoc la +1
													}
												}
												else if (bool_16)
												{
													if (int_37 == 3 || int_37 == 9 || int_37 == 6)
													{
														text5 = "+84" + text5;
													}
													if (int_37 == 0 || int_37 == 1 || int_37 == 2 || int_37 == 4 || int_37 == 5 || int_37 == 7 || int_37 == 8)
													{
														text5 = "+84" + text5; // truoc la +1
													}
												}
												device.method_91(270, 195);
												device.method_121(1.0);
												device.method_49(text5, bool_0: false, bool_1: false);
												device.method_121(1.0);
												device.method_91(160, 382);
												goto IL_bf36;
											IL_a6c7:
												while (true)
												{
													flag24 = false;
													method_62(int_41, text3 + "Check status đăng ký....", device);
													if (flag21)
													{
														device.method_121(10.0);
													}
													int num70 = 0;
													while (true)
													{
														text56 = device.method_93();
														if (!bool_0)
														{
															if (num70 != 30)
															{
																num70++;
																if (!device.method_52("DataClick\\fblite\\luuthongtindangnhap"))
																{
																	if (!device.method_82("we need more information", text56) && !device.method_82("Something went wrong. Please try again.", text56) && !device.method_82("chúng tôi cần thêm thông tin", text56))
																	{
																		if (device.method_52("DataClick\\fblite\\yourphone"))
																		{
																			goto IL_a6eb;
																		}
																		if (device.method_52("DataClick\\fblite\\whatyourname"))
																		{
																			goto IL_a686;
																		}
																		if (!device.method_52("DataClick\\fblite\\createpass"))
																		{
																			continue;
																		}
																		goto IL_a50c;
																	}
																	goto giaicp282;
																}
																goto IL_ac56;
															}
															method_62(int_41, text3 + "Không check được status...");
															method_49("Không check được status đăng ký", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Stop run...", device);
														method_49("Stop run", device.int_0, int_41, int_42, device, bool_18: false);
														break;
													}
													break;
												IL_a686:
													method_62(int_41, text3 + "Trùng tên...", device);
													flag21 = true;
													device.method_91(175, 180);
												}
												break;
											IL_a53f:
												method_62(int_41, text3 + "Nhập mật khẩu....", device);
												device.method_46("shell ime set cz.october.app/.KeyboardReceiver");
												device.method_91(44, 176);
												device.method_121(1.0);
												device.method_45();
												device.method_121(1.0);
												device.method_49(text59, bool_0: false, bool_1: false);
												device.method_121(1.0);
												if (device.method_52("DataClick\\fblite\\next"))
												{
													device.method_3("DataClick\\fblite\\next");
												}
												device.method_121(1.0);
												if (!bool_0)
												{
													if (flag22)
													{
														device.method_121(10.0);
													}
													else
													{
														for (int num71 = 0; num71 < 5; num71++)
														{
															text56 = device.method_93();
															if (!device.method_52("DataClick\\fblite\\confirmregist"))
															{
																flag23 = false;
																continue;
															}
															flag23 = true;
															break;
														}
														if (!flag23)
														{
															method_62(int_41, text3 + "Error when register", device);
															method_49("Error when register", device.int_0, int_41, int_42, device, bool_18: false);
															break;
														}
														method_62(int_41, text3 + "Đăng ký....", device);
														//if (device.method_52("DataClick\\fblite\\confirmregist"))
														//{
														//    device.method_3("DataClick\\fblite\\confirmregist");
														//}
														//if (!device.method_52("DataClick\\fblite\\confirmregist"))
														//{
														//KAutoHelper.ADBHelper.TapByPercent(device, 160, 231);
														device.method_91(160, 290);
														device.method_121(1.0);
														//}

													}
													goto IL_a6c7;
												}
												method_62(int_41, text3 + "Dừng chạy...", device);
												method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
												break;
												continue;
											end_IL_a96f:
												break;
											}
										}
										else
										{
											method_62(int_41, text3 + "Không mở được app Facebook lite");
											method_49("Không mở được app Facebook lite", device.int_0, int_41, int_42, device, bool_18: false);
										}
									}
									catch
									{
										method_62(int_41, text3 + "Lỗi treo LD");
										method_49("Lỗi treo LD", device.int_0, int_41, int_42, device, bool_18: false);
									}
									goto end_IL_1d06;
								IL_25fa:
									device.method_1("com.cell47.College_Proxy");
									method_62(int_41, text3 + "Đang kết nối proxy...", device);
									switch (int_9)
									{
										case 2:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 3:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 5:
											if (rdIPDong.Checked)
											{
												if (!method_88(device, text2))
												{
													method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
													method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
													goto end_IL_1928;
												}
												text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
												break;
											}
											device.method_4(text2);
											break;
										case 6:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 7:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 8:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											break;
										case 9:
											if (!method_88(device, text2))
											{
												method_62(int_41, text3 + "Lô\u0303i kết nối proxy!");
												method_49("Lỗi kết nối proxy", device.int_0, int_41, int_42, device, bool_18: false);
												goto end_IL_1928;
											}
											text10 = device.method_101(Device.KeyEvent.KEYCODE_HOME);
											device.method_4(text2);
											break;
									}
									goto IL_2876;
								IL_24d0:
									if (!flag10)
									{
										method_62(int_41, text3 + "Cài đặt các ứng dụng không thành công", device);
										method_49("Cài đặt các ứng dụng không thành công", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (Settings.Default.isOnGPSLD)
									{
										device.method_85("shell settings put secure location_providers_allowed +gps");
									}
									else
									{
										device.method_85("shell settings put secure location_providers_allowed -gps");
									}
									device.method_6();
									if (bool_0)
									{
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
									if (!(text2 != ""))
									{
										goto IL_2876;
									}
									if (device.list_0.Contains("com.cell47.College_Proxy"))
									{
										goto IL_25fa;
									}
									method_62(int_41, text3 + "Cài đặt App Proxy...", device);
									while (true)
									{
										if (!bool_0)
										{
											flag10 = false;
											if (!(flag10 = device.method_109(Class25.smethod_0() + "\\app\\collegeproxy.apk")))
											{
												continue;
											}
											goto IL_25fa;
										}
										method_62(int_41, text3 + "Dừng chạy...", device);
										method_49("Dừng chạy", device.int_0, int_41, int_42, device, bool_18: false);
										break;
									}
								end_IL_1d06:;
								}
								catch (Exception ex4)
								{
									method_62(int_41, text3 + "Lỗi khi đăng ký. Lỗi: " + ex4.Message, device);
									method_49("Tạo tài khoản thất bại", device.int_0, int_41, int_42, device, bool_18: false);
								}
							}
							
							break;
						}
					IL_11ec:
						method_62(int_41, "Đang lấy Proxy từ API...");
						if (class2.int_2 > 1)
						{
							text2 = class2.method_6();
							goto IL_1336;
						}
						while (true)
						{
							switch (class2.method_3())
							{
								case 1:
									text2 = class2.proxy;
									goto IL_121c;
								default:
									goto IL_121c;
								case 0:
									method_62(int_41, "Đang lấy Proxy từ API: Chờ " + class2.next_change + " s");
									if (class2.next_change > 10)
									{
										Common.smethod_62(10.0);
									}
									else if (class2.next_change > 0)
									{
										Common.smethod_62(class2.next_change);
									}
									goto IL_121c;
								case -2:
									method_62(int_41, "Api không đúng");
									lock (object_5)
									{
										list_12.Remove(class2);
									}
									break;
								case -1:
									method_62(int_41, "Api hết hạn");
									lock (object_5)
									{
										list_12.Remove(class2);
									}
									break;
							}
							break;
						IL_121c:
							if (!(text2 != ""))
							{
								continue;
							}
							goto IL_1336;
						}
						continue;
					IL_1a83:
						if (text2 != "")
						{
							method_62(int_41, text3 + "Không thể kết nối proxy!");
						}
						else
						{
							method_62(int_41, text3 + "Không có kết nối Internet!");
						}
						break;
					IL_13e9:
						if (!flag)
						{
							lock (object_5)
							{
								Class51 class22 = class2;
								Class51 class18 = class22;
								class18.int_1--;
								class22 = class2;
								class18 = class22;
								class18.int_2--;
							}
							continue;
						}
						goto default;
					IL_1336:
						if (!(text2 == ""))
						{
							method_62(int_41, "Đang kiểm tra proxy...");
							if (!(Common.smethod_36(text2, 0, 15) == ""))
							{
								flag = true;
								if (ckCheckIP.Checked)
								{
									text3 = "(IP: " + text2.Split(':')[0] + ") ";
									method_62(int_41, text3 + "Check IP...");
									text4 = Common.smethod_35(text2, 0);
									if (text4 == "")
									{
										flag = false;
									}
								}
								method_52(text2, "proxy", int_41, 0, dgvAcc);
							}
						}
						goto IL_13e9;
					IL_1ac3:
						method_52(text2, "proxy", int_41, 0, dgvAcc);
						goto default;
					end_IL_1928:
						break;
				}
				break;
			}
			lock (object_14)
			{
				switch (int_9)
				{
					case 2:
						@class?.method_1(int_36);
						break;
					case 3:
						class2?.method_2(int_36);
						break;
					case 6:
						class3?.method_3(int_26, int_36);
						break;
					case 7:
						class4?.method_2(int_36);
						break;
					case 8:
						class5?.method_0(int_36);
						break;
					case 0:
					case 1:
					case 4:
					case 5:
						break;
				}
			}
		}

		private int method_25(int int_41, string string_21, Device device_0, int int_42, int int_43, int int_44, int int_45, bool bool_18, int int_46, int int_47, bool bool_19, int int_48, int int_49, bool bool_20, List<string> list_21, int int_50, int int_51, int int_52, int int_53, int int_54)
		{
			int num = 0;
			int num2 = random_0.Next(int_46, int_47 + 1);
			int num3 = random_0.Next(int_50, int_51 + 1);
			int num4 = random_0.Next(int_48, int_49 + 1);
			int num5 = random_0.Next(int_42, int_43 + 1);
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			try
			{
				for (int i = 0; i < 10; i++)
				{
					while (true)
					{
						device_0.method_35();
						if (!device_0.method_82("more options", "", 5.0))
						{
							if (!device_0.method_52("DataClick\\image\\tryagain"))
							{
								if (!device_0.method_54())
								{
									switch (method_45(device_0, int_41, string_21))
									{
										case 1:
											continue;
										case 0:
											break;
										default:
											return num;
									}
								}
							}
							else
							{
								device_0.method_56("DataClick\\image\\tryagain");
							}
							break;
						}
						while (true)
						{
							if (num >= num5)
							{
								continue;
							}
							device_0.method_54();
							while (true)
							{
								if (!device_0.method_81(500, 1, "[97,401][179,413]", "[180,88][254,100]", "[99,416][169,456]"))
								{
									num++;
									device_0.method_23(int_44, int_45);
									if (bool_18 && num6 < num2 && Common.smethod_7(int_52))
									{
										string text = device_0.method_93();
										string value = device_0.method_76("\"like\"", text).LastOrDefault();
										if (!string.IsNullOrEmpty(value))
										{
											device_0.method_34(value);
											device_0.method_10(6);
											num6++;
										}
									}
									if (bool_20 && num7 < num3 && Common.smethod_7(int_54))
									{
										string text2 = device_0.method_93();
										string value2 = device_0.method_76("\"comment\"", text2).LastOrDefault();
										if (!string.IsNullOrEmpty(value2))
										{
											string text3 = list_21[device_0.method_15(0, list_21.Count - 1)];
											text3 = Common.smethod_9(text3, random_0);
											text3 = ns3.Class47.smethod_3(text3, random_0);
											device_0.method_89(value2);
											device_0.method_23(2.0, 3.0);
											device_0.method_54();
											device_0.method_93();
											int num9 = device_0.method_84(text2, 3.0, "\"comment…\"", "write a comment…\"");
											if (num9 == 1)
											{
												device_0.method_99("\"comment…\"", text2);
											}
											if (!device_0.method_8(10, "write a comment…\"", Device.smethod_0().ToArray()))
											{
												break;
											}
											device_0.method_100(text3);
											device_0.method_99("\"send\"", "", 3);
											device_0.method_23(2.0, 2.5);
											device_0.method_74(2);
											device_0.method_23(1.0, 1.5);
											num7++;
										}
									}
									if (bool_19 && num8 < num4 && Common.smethod_7(int_53))
									{
										string text4 = device_0.method_93();
										if (device_0.method_82("share", text4))
										{
											List<string> list = device_0.method_76("share", text4);
											string text5 = list[list.Count - 1];
											device_0.method_89(text5);
											device_0.method_99("\"share now\"", "", 3);
											device_0.method_23(1.5, 2.0);
											num8++;
										}
									}
									method_62(int_41, string_21 + "Đang xem watch" + string.Format(" {0} ({1}/{2})...", num, num5));
									continue;
								}
								return num;
							}
						}
					}
				}
			}
			catch
			{
			}
			return num;
		}

		private int method_26(int int_41, string string_21, Device device_0)
		{
			int result = 0;
			try
			{
				while (true)
				{
					device_0.method_124();
					device_0.method_23(1.0, 2.0);
					switch (method_45(device_0, int_41, string_21))
					{
						case 1:
							break;
						case 0:
							method_27(int_41, string_21, device_0, 10, 30, bool_18: true, 1, 5, bool_19: false, 0, 0, null, bool_20: true, 1, 3);
							goto end_IL_0003;
						default:
							goto end_IL_0003;
					}
					continue;
				end_IL_0003:
					break;
				}
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		private int method_27(int int_41, string string_21, Device device_0, int int_42, int int_43, bool bool_18, int int_44, int int_45, bool bool_19, int int_46, int int_47, List<string> list_21, bool bool_20, int int_48, int int_49)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			List<string> list = new List<string>();
			if (bool_18)
			{
				num4 = device_0.method_15(int_44, int_45);
			}
			if (list_21 != null)
			{
				list_21 = Common.smethod_77(list_21);
				list = Common.smethod_8(list_21);
			}
			if (bool_19)
			{
				num5 = device_0.method_15(int_46, int_47);
			}
			if (bool_20)
			{
				num6 = device_0.method_15(int_48, int_49);
			}
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			int num7 = device_0.method_15(int_42, int_43);
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < num7 * 1000)
			{
				int num8 = method_45(device_0, int_41, string_21);
				if (num8 == 1)
				{
					device_0.method_124();
				}
				else if (num8 != 0)
				{
					break;
				}
				string text = device_0.method_93();
				list2 = device_0.method_76("like button. double tap and hold to react", text);
				if (list2.Count > 0 && bool_18 && num < num4 && device_0.method_15(1, 100) % 2 == 0)
				{
					string text2 = list2[list2.Count - 1];
					if (text2 != "" && device_0.method_34(text2, "[0,100][320,480]"))
					{
						device_0.method_23(1.0, 1.5);
						device_0.method_10(6);
						num++;
						device_0.method_23(1.0, 2.0);
						text = device_0.method_93();
					}
				}
				list3 = device_0.method_76("comment button", text);
				if (list3.Count > 0 && bool_19 && num2 < num5 && device_0.method_15(1, 100) % 2 == 0 && list_21 != null)
				{
					string text3 = list3[list3.Count - 1];
					if (text3 != "")
					{
						if (list.Count == 0)
						{
							list = Common.smethod_8(list_21);
						}
						string item = list[device_0.method_15(0, list.Count - 1)];
						list.Remove(item);
						item = Common.smethod_9(item, random_0);
						if (device_0.method_89(text3, "[0,100][320,480]"))
						{
							device_0.method_23(1.0, 2.0);
							device_0.method_100(item);
							device_0.method_23(1.0, 2.0);
							if (device_0.method_99("send"))
							{
								device_0.method_23(3.0, 5.0);
							}
							device_0.method_74(2, 0.3);
							num2++;
							device_0.method_23(1.0, 2.0);
							text = device_0.method_93();
						}
					}
				}
				list4 = device_0.method_76("share button", text);
				if (list4.Count > 0 && bool_20 && num3 < num6 && device_0.method_15(1, 100) % 2 == 0)
				{
					string text4 = list4[list4.Count - 1];
					if (text4 != "" && device_0.method_89(text4, "[0,100][320,480]"))
					{
						device_0.method_23(1.5, 2.0);
						device_0.method_99("share now");
						device_0.method_23(2.0, 3.0);
						num3++;
					}
				}
				if (device_0.method_81(500, 1, "[97,401][179,413]", "[180,88][254,100]"))
				{
					break;
				}
				device_0.method_23(1.5, 3.0);
			}
			return 0;
		}

		private int method_28(int int_41, string string_21, Device device_0, int int_42, int int_43)
		{
			int num = 0;
			try
			{
				int num2 = random_0.Next(int_42, int_43 + 1);
				if (num2 != 0)
				{
					while (true)
					{
						device_0.method_9();
						device_0.method_23(1.0, 2.0);
						switch (method_45(device_0, int_41, string_21))
						{
							case 0:
								{
									List<string> list = device_0.method_76("as a friend\"");
									if (list.Count == 0)
									{
										goto end_IL_0174;
									}
									for (int i = 0; i < num2 + 10; i++)
									{
										switch (method_45(device_0, int_41, string_21))
										{
											case 0:
												{
													string text = list[device_0.method_15(0, list.Count - 1)];
													if (text != "" && device_0.method_89(text))
													{
														num++;
														method_62(int_41, string_21 + "Đang" + string.Format(" kết bạn gợi ý ({1}/{2})...", num, num2));
														device_0.method_23(2.0, 5.0);
													}
													if (num >= num2)
													{
														goto end_IL_0166;
													}
													list = device_0.method_76("as a friend");
													if (list.Count != 0)
													{
														continue;
													}
													if (!device_0.method_81(device_0.method_15(200, 300)))
													{
														list = device_0.method_76("as a friend");
														if (list.Count != 0)
														{
															continue;
														}
													}
													goto end_IL_0166;
												}
											case 1:
												break;
											default:
												goto end_IL_0166;
										}
										goto end_IL_01a6;
										continue;
									end_IL_0166:
										break;
									}
									goto end_IL_0174;
								}
							case 1:
								break;
							default:
								goto end_IL_0174;
							end_IL_01a6:
								break;
						}
						continue;
					end_IL_0174:
						break;
					}
				}
			}
			catch
			{
				num = -1;
			}
			return num;
		}

		private int method_29(int int_41, string string_21, Device device_0)
		{
			int num = device_0.method_15(3, 5);
			try
			{
				while (true)
				{
					device_0.method_124();
					device_0.method_23(1.0, 2.0);
					switch (method_45(device_0, int_41, string_21))
					{
						case 1:
							break;
						case 0:
							{
								string text = device_0.method_97("'s story");
								if (!(text != ""))
								{
									goto end_IL_000a;
								}
								device_0.method_89(text);
								int tickCount = Environment.TickCount;
								while (Environment.TickCount - tickCount < num * 1000)
								{
									device_0.method_23(4.0, 8.0);
									if (list_10.Count > 0 && device_0.method_15(1, 9) % 3 == 0)
									{
										string text2 = "[165,445][195,470]";
										string text3 = "[35,445][65,470]";
										device_0.method_80(text2, text3);
										device_0.method_23(1.0, 1.5);
										int num2 = Convert.ToInt32(list_10[device_0.method_15(0, list_10.Count - 1)].ToString());
										device_0.method_10(num2);
										device_0.method_23(1.0, 1.5);
										device_0.method_89("[260,198][300,268]");
										device_0.method_23(1.0, 1.5);
									}
									device_0.method_89("[260,198][300,268]");
								}
								goto end_IL_000a;
							}
						default:
							goto end_IL_000a;
					}
					continue;
				end_IL_000a:
					break;
				}
			}
			catch
			{
			}
			return num;
		}

		private int method_30(int int_41, string string_21, Device device_0, int int_42, int int_43, bool bool_18, bool bool_19, int int_44, int int_45, int int_46, int int_47)
		{
			int result = 0;
			try
			{
				int num = device_0.method_15(int_42, int_43);
				List<string> list = new List<string>();
				if (!bool_18)
				{
					list = list_20.GetRange(0, num);
				}
				else
				{
					List<string> list2 = list_20;
					lock (list2)
					{
						if (list_20.Count > 0)
						{
							if (num > list_20.Count)
							{
								num = list_20.Count;
							}
							list = list_20.GetRange(0, num);
							list_20.RemoveRange(0, num);
						}
					}
				}
				if (list.Count > 0)
				{
					method_62(int_41, string_21 + "Import danh bạ...");
					string text = device_0.method_93();
					device_0.method_20(list);
					device_0.method_121(10.0);
					result = (device_0.method_19() ? 1 : 0);
					if (bool_19)
					{
						List<string> list3 = device_0.method_76("add friend", text, 5);
						if (list3.Count > 0)
						{
							int num2 = 0;
							int num3 = random_0.Next(int_44, int_45 + 1);
							if (num3 != 0)
							{
								int num4 = 0;
								for (int i = 0; i < num3 + 10; i++)
								{
									if (device_0.method_129())
									{
										num4++;
										if (num4 % 3 == 0 && method_31(device_0, int_41, string_21) != 0)
										{
											break;
										}
										string text2 = list3[device_0.method_15(0, list3.Count - 1)];
										if (text2 != "" && device_0.method_18("[0,130][320,480]", text2) && device_0.method_89(text2))
										{
											num2++;
											method_62(int_41, string_21 + "Add friends...");
											device_0.method_23(int_46, int_47);
										}
										if (num2 >= num3)
										{
											break;
										}
										list3 = device_0.method_76("add friend");
										if (list3.Count == 0 || (list3.Count == 1 && !device_0.method_18("[0,130][320,480]", list3[0])))
										{
											if (device_0.method_81(device_0.method_15(200, 300)))
											{
												break;
											}
											list3 = device_0.method_76("add friend");
											if (list3.Count == 0 || (list3.Count == 1 && !device_0.method_18("[0,130][320,480]", list3[0])))
											{
												break;
											}
										}
										continue;
									}
									return -2;
								}
							}
						}
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		private int method_31(Device device_0, int int_41, string string_21, bool bool_18 = true)
		{
			device_0.method_130("Check status...");
			string text = "";
			int num = device_0.method_60(ref text, bool_18);
			device_0.method_130($"Check status: {num}...");
			if ((num.ToString() ?? "").StartsWith("-1"))
			{
				if (device_0.method_82("\"ok\"", text))
				{
					device_0.method_121(1.0);
					device_0.method_99("\"ok\"", text);
				}
				num = -1;
			}
			int num2 = num;
			int num3 = num2;
			int result;
			if (num3 != -1)
			{
				result = num;
			}
			else
			{
				if (bool_8 && device_0.method_87() != "Application")
				{
					device_0.method_70();
					string text2 = "";
					for (int i = 0; i < 10; i++)
					{
						text2 = device_0.method_61(0).Split('|')[1];
						if (text2 == "0")
						{
							break;
						}
					}
					if (text2 != "1" && method_46(device_0, int_41, string_21) == 1)
					{
						return 1;
					}
				}
				result = -1;
			}
			return result;
		}

		private int method_32(int int_41, string string_21, Device device_0)
		{
			int num = 0;
			int num2 = device_0.method_15(1, 5);
			try
			{
				string text = "manage the notification";
				List<string> list = new List<string>();
				while (num < num2)
				{
					for (int i = 0; i < 10; i++)
					{
						string text2 = device_0.method_93();
						list = device_0.method_76(text);
						if (list.Count <= 0)
						{
							if (!device_0.method_82("no notifications", text2))
							{
								while (true)
								{
									device_0.method_22();
									device_0.method_121(3.0);
									if (!device_0.method_54())
									{
										switch (method_45(device_0, int_41, string_21))
										{
											case 1:
												continue;
											case 0:
												break;
											default:
												return num;
										}
									}
									break;
								}
								continue;
							}
							method_62(int_41, string_21 + "Không có thông báo để đọc", device_0);
							return num;
						}
						if (list.Count <= 4)
						{
							num2 = list.Count;
						}
						Point point_;
						do
						{
							if (list.Count == 0)
							{
								if (!device_0.method_81(150))
								{
									list = device_0.method_76(text);
									if (list.Count != 0)
									{
										goto IL_00d5;
									}
								}
								return num;
							}
							goto IL_00d5;
						IL_00d5:
							string item = list[device_0.method_15(0, list.Count - 1)];
							list.Remove(item);
							point_ = device_0.method_88(item);
						}
						while (!device_0.method_98("[0,60][320,480]", point_));
						device_0.method_91(point_.X - device_0.method_15(100, 150), point_.Y);
						device_0.method_23(1.0, 2.0);
						int tickCount = Environment.TickCount;
						int num3 = device_0.method_15(3, 5);
						while (Environment.TickCount - tickCount < num3 * 1000 && !device_0.method_81())
						{
							device_0.method_23(1.0, 2.0);
						}
						num++;
						method_62(int_41, string_21 + "Đang" + string.Format(" Đọc thông báo ({1}/{2})...", num, num2), device_0);
						device_0.method_74();
						device_0.method_23(1.0, 2.0);
						break;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		private void method_33(int int_41 = 0)
		{
			Common.smethod_62(random_0.Next(int_41 + 1, int_41 + 4));
		}

		private int method_34(int int_41, Device device_0)
		{
			string text = method_1(int_41, "pass");
			int result = 0;
			bool flag = false;
			string text2 = "";
			int num = 0;
			string text3 = "";
			for (int i = 0; i < 2 && !bool_0 && num != 5; i++)
			{
				device_0.method_127();
				device_0.method_121(5.0);
				if (!device_0.method_3("DataClick\\image\\usetwofactorauthentication"))
				{
					if (!device_0.method_81())
					{
						device_0.method_121(1.0);
						num++;
						continue;
					}
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					continue;
				}
				int num2 = 0;
				while (num2 < 5)
				{
					text3 = device_0.method_93();
					if (!device_0.method_82("\"continue\"", text3))
					{
						if (!device_0.method_81())
						{
							device_0.method_121(1.0);
							num2++;
						}
						continue;
					}
					flag = true;
					device_0.method_99("\"continue\"", text3);
					break;
				}
				if (flag)
				{
					for (int j = 0; j < 5; j++)
					{
						try
						{
							method_62(int_41, "Chờ " + int_34 + " giây để quét QRCode", device_0);
							device_0.method_121(int_34);
							Bitmap bitmap_ = device_0.method_33();
							text2 = Common.smethod_66(bitmap_);
							text2 = Regex.Match(text2, "secret=(.*?)&").Groups[1].Value;
							if (!string.IsNullOrEmpty(text2))
							{
								break;
							}
							device_0.method_121(1.0);
							continue;
						}
						catch (Exception exception_)
						{
							method_62(int_41, "Không quét được mã QRCode. Thực hiện lại", device_0);
							Common.smethod_82(exception_, "ScanQRCode2Fa");
						}
						break;
					}
				}
				if (!string.IsNullOrEmpty(text2))
				{
					int num3 = 0;
					while (num3 < 5)
					{
						text3 = device_0.method_93();
						if (!device_0.method_99("\"continue\"", text3))
						{
							if (!device_0.method_81(500))
							{
								device_0.method_121(1.0);
								num3++;
								flag = false;
							}
							continue;
						}
						flag = true;
						break;
					}
					if (!flag)
					{
						continue;
					}
					int num4 = 0;
					while (num4 < 5)
					{
						if (!device_0.method_3("DataClick\\image\\enterthe6digitcode"))
						{
							continue;
						}
						string text4 = Common.smethod_72(text2);
						device_0.method_100(text4);
						device_0.method_99("\"continue\"");
						int num5 = 0;
						while (num5 < 5)
						{
							if (device_0.method_52("DataClick\\image\\thiscodeisntright"))
							{
								continue;
							}
							text3 = device_0.method_93();
							if (!device_0.method_82("incorrect password", text3))
							{
								if (device_0.method_82("\"password\"", text3))
								{
									if (text.Trim() == "")
									{
										break;
									}
									device_0.method_99("\"password\"", text3);
									device_0.method_100(text);
									device_0.method_3("DataClick\\image\\continue", null, 10);
								}
								else if (device_0.method_82("two-factor authentication is on", text3))
								{
									goto IL_0394;
								}
								device_0.method_121(1.0);
								num5++;
								continue;
							}
							method_42(int_41, "Changed pass");
							break;
						}
					}
					continue;
				}
				result = 0;
				break;
			IL_0394:
				flag = true;
				break;
			}
			if (text2 != "")
			{
				result = 1;
				method_22(int_41, "conf_2fa", text2);
			}
			return result;
		}

		private int method_35(int int_41, int int_42, Device device_0, int int_43) //2fa katana
		{
			try
			{
				method_1(int_41, "uid");
				string text = method_1(int_41, "pass");
				int num = 0;
				if (int_43 == 1)
				{
					int result = 0;
					int num2 = 0;
					try
					{
						int num3 = 0;
						while (num3 < 5)
						{
							device_0.method_124();
							num2++;
							num3++;
							if (num3 == 5)
							{
								break;
							}
							if (!device_0.method_3("DataClick\\image\\menu") || device_0.method_52("DataClick\\image\\fastermessage"))
							{
								continue;
							}
							bool flag = false;
							num2++;
							int num4 = 0;
							while (num4 < 5)
							{
								string text2 = device_0.method_93();
								if (!device_0.method_3("DataClick\\image\\settingandprivacy"))
								{
									if (!device_0.method_81(500))
									{
										device_0.method_121(1.0);
										num4++;
										continue;
									}
								}
								else
								{
									flag = true;
								}
								if (!flag)
								{
									goto end_IL_00d7;
								}
								flag = false;
								num2++;
								int num5 = 0;
								while (num5 < 5)
								{
									if (!device_0.method_3("DataClick\\image\\caidat"))
									{
										if (num5 % 2 != 1 || !device_0.method_81())
										{
											device_0.method_121(1.0);
											num5++;
											continue;
										}
									}
									else
									{
										flag = true;
									}
									if (!flag)
									{
										break;
									}
									flag = false;
									int num6 = 0;
									while (num6 < 5)
									{
										text2 = device_0.method_93();
										if (!device_0.method_3("DataClick\\image\\passwordandsecurity"))
										{
											if (!device_0.method_81())
											{
												device_0.method_121(1.0);
												num6++;
												continue;
											}
										}
										else
										{
											flag = true;
										}
										if (!flag)
										{
											break;
										}
										flag = false;
										int num7 = 0;
										while (num7 < 10)
										{
											text2 = device_0.method_93();
											if (!device_0.method_3("DataClick\\image\\usetwofactorauthentication"))
											{
												if (!device_0.method_81())
												{
													device_0.method_121(1.0);
													num7++;
													continue;
												}
											}
											else
											{
												flag = true;
											}
											if (!flag)
											{
												break;
											}
											flag = false;
											for (int i = 0; i < 10; i++)
											{
												text2 = device_0.method_93();
												if (device_0.method_3("DataClick\\image\\continue", null, 10))
												{
													flag = true;
													break;
												}
											}
											if (!flag)
											{
												break;
											}
											string text3 = "";
											string text4 = "";
											int num8 = 0;
											while (true)
											{
												if (num8 < 2)
												{
													try
													{
														method_62(int_41, "Chờ " + int_34 + " giây để quét QRCode", device_0);
														device_0.method_121(int_34);
														Bitmap bitmap_ = device_0.method_33();
														text4 = Common.smethod_66(bitmap_);
														text4 = Regex.Match(text4, "secret=(.*?)&").Groups[1].Value;
														if (string.IsNullOrEmpty(text4))
														{
															device_0.method_121(1.0);
															goto IL_0334;
														}
													}
													catch (Exception exception_)
													{
														method_62(int_41, "Không quét được mã QRCode. Thực hiện lại", device_0);
														Common.smethod_82(exception_, "ScanQRCode2Fa");
														break;
													}
												}
												if (!string.IsNullOrEmpty(text4))
												{
													int num9 = 0;
													int num10 = 0;
													while (true)
													{
														text3 = device_0.method_93();
														if (!device_0.method_99("\"continue\"", text3))
														{
															break;
														}
														flag = false;
														num10++;
														if (num10 != 5 && device_0.method_3("DataClick\\image\\enterthe6digitcode", null, 10))
														{
															string text5 = Common.smethod_72(text4);
															device_0.method_100(text5);
															device_0.method_99("\"continue\"");
															int num11 = 0;
															while (num11 < 5)
															{
																if (!device_0.method_52("DataClick\\image\\thiscodeisntright"))
																{
																	text2 = device_0.method_93();
																	if (!device_0.method_82("incorrect password", text2))
																	{
																		if (device_0.method_82("\"password\"", text2))
																		{
																			if (text.Trim() == "")
																			{
																				break;
																			}
																			device_0.method_99("\"password\"", text2);
																			device_0.method_100(text);
																			device_0.method_99("\"continue\"", text2);
																		}
																		else if (device_0.method_82("two-factor authentication is on", text2))
																		{
																			flag = true;
																			break;
																		}
																		device_0.method_121(1.0);
																		num11++;
																		continue;
																	}
																	method_42(int_41, "Changed pass");
																	break;
																}
																goto IL_0486;
															}
														}
														goto IL_04d3;
													IL_0486:
														num9++;
														if (num9 < 3)
														{
															device_0.method_99("\"back\"");
															continue;
														}
														goto IL_04d3;
													IL_04d3:
														if (text4 != "")
														{
															result = 1;
															method_22(int_41, "conf_2fa", text4);
														}
														break;
													}
												}
												else
												{
													result = 0;
												}
												break;
											IL_0334:
												num8++;
											}
											break;
										}
										break;
									}
									break;
								}
								goto end_IL_00d7;
							}
							continue;
						end_IL_00d7:
							break;
						}
					}
					catch
					{
					}
					return result;
				}
				return 0;
			}
			catch (Exception)
			{
				return 0;
			}
		}

		public string method_36(int int_41)
		{
			return Class15.smethod_3(dgvAcc, int_41, "cInfo");
		}

		public string method_37(int int_41)
		{
			return Class15.smethod_3(dgvAcc, int_41, "conf_2fa");
		}

		public string method_38(int int_41)
		{
			return Class15.smethod_3(dgvAcc, int_41, "proxy");
		}

		public string method_39(int int_41)
		{
			return Class15.smethod_3(dgvAcc, int_41, "email");
		}

		public string method_40(int int_41)
		{
			return Class15.smethod_3(dgvAcc, int_41, "passMail");
		}

		private void method_41(int int_41 = -1)
		{
			if (int_41 == -1)
			{
				for (int i = 0; i < dgvAcc.RowCount; i++)
				{
					string text = method_36(i);
					if (text == "Live")
					{
						dgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains("Checkpoint") || text.Contains("Changed pass"))
					{
						dgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
			}
			else
			{
				string text2 = method_36(int_41);
				if (text2 == "Live")
				{
					dgvAcc.Rows[int_41].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
				else if (text2.Contains("Die") || text2.Contains("Checkpoint") || text2.Contains("Changed pass"))
				{
					dgvAcc.Rows[int_41].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
		}

		public void method_42(int int_41, string string_21)
		{
			Class15.smethod_4(dgvAcc, int_41, "cInfo", string_21);
			method_41(int_41);
		}

		private bool method_43(Device device_0)
		{
			bool result = false;
			for (int i = 0; i < 60; i++)
			{
				string text = device_0.method_93();
				if (device_0.method_120(text).Count != 1)
				{
					if (device_0.method_82("we need more information", text, 5.0))
					{
						result = true;
						break;
					}
					if (device_0.method_82("Something went wrong. Please try again.", text, 5.0))
					{
						result = true;
						break;
					}
					if (device_0.method_82("chúng tôi cần thêm thông tin", text, 5.0))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		private int method_44(Device device_0, int int_41, string string_21)
		{
			int result = 0;
			int num = 0;
			int num2 = 5;
			int num3 = 0;
			while (true)
			{
				if (num3 < 2)
				{
					string text = device_0.method_93();
					if (device_0.method_120(text).Count != 1)
					{
						if (device_0.method_82("profile picture", text))
						{
							result = 1;
							break;
						}
						if (!device_0.method_82("reload page", text))
						{
							switch (method_45(device_0, int_41, string_21))
							{
								case 0:
									goto IL_00b3;
								default:
									result = 3;
									break;
								case 1:
									result = 2;
									break;
							}
							break;
						}
						num++;
						if (num >= num2)
						{
							break;
						}
						device_0.method_99("reload page", text);
					}
					else
					{
						device_0.method_99(device_0.method_120(text)[0], text);
					}
					goto IL_00b3;
				}
				return result;
			IL_00b3:
				device_0.method_121(1.0);
				num3++;
			}
			return result;
		}

		private int method_45(Device device_0, int int_41, string string_21)
		{
			device_0.method_130("Check status...");
			string text = "";
			int num = device_0.method_60(ref text);
			device_0.method_130($"Check status: {num}...");
			if ((num.ToString() ?? "").StartsWith("-1"))
			{
				if (device_0.method_82("\"ok\"", text))
				{
					device_0.method_99("\"ok\"", text);
				}
				else
				{
					device_0.method_54(text);
				}
				num = -1;
			}
			int num2 = num;
			int num3 = num2;
			int result;
			if (num3 != -1)
			{
				result = num;
			}
			else
			{
				if (bool_8)
				{
					device_0.method_70();
					string text2 = "";
					for (int i = 0; i < 10; i++)
					{
						text2 = device_0.method_61(0).Split('|')[1];
						if (text2 == "0")
						{
							break;
						}
					}
					if (text2 != "1" && method_46(device_0, int_41, string_21) == 1)
					{
						return 1;
					}
				}
				result = -1;
			}
			return result;
		}

		private int method_46(Device device_0, int int_41, string string_21)
		{
			return -1;
		}

		private void method_47(ToolStripStatusLabel toolStripStatusLabel_0)
		{
			try
			{
				int num = Convert.ToInt32(toolStripStatusLabel_0.Text);
				toolStripStatusLabel_0.Text = (num + 1).ToString();
			}
			catch
			{
			}
		}

		private bool method_48(string string_21)
		{
			return Common.smethod_64(string_21) && !string_21.StartsWith("0");
		}

		private void method_49(string string_21, int int_41, int int_42, int int_43, Device device_0, bool bool_18)
		{
			int num = random_0.Next(int_5, int_6 + 1);
			if (num > 0)
			{
				int tickCount = Environment.TickCount;
				while ((Environment.TickCount - tickCount) / 1000 - num < 0)
				{
					if (!bool_0)
					{
						method_62(int_42, "Đóng LD sau {time}s...".Replace("{time}", (num - (Environment.TickCount - tickCount) / 1000).ToString()));
						Common.smethod_62(0.5);
						continue;
					}
					method_62(int_42, "Dừng chạy!");
					break;
				}
			}
			if (!bool_18)
			{
				method_47(stTotalFail);
				method_62(int_42, string_21, device_0);
				dgvAcc.Invoke((MethodInvoker)delegate
				{
					dgvAcc.Rows[int_42].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				});
			}
			else
			{
				method_47(stTotalSuccess);
				method_62(int_42, string_21, device_0);
				dgvAcc.Invoke((MethodInvoker)delegate
				{
					dgvAcc.Rows[int_42].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				});
			}
			Invoke((MethodInvoker)delegate
			{
				frmViewLD.frmViewLD_0.method_4(device_0.int_0);
			});
			device_0.method_68();
			list_4.Remove(device_0);
			if (int_36 == 1 && File.Exists(string_9 + "\\vms\\config\\leidian" + int_41 + ".config"))
			{
				int num2 = 0;
				string text;
				do
				{
					num2++;
					text = string_9 + "\\vms\\config\\leidian" + int_41 + ".config";
				}
				while (!Common.smethod_76(text));
			}
			if (!Settings.Default.isAutoClearLD)
			{
				return;
			}
			if (Directory.Exists(string_9 + "\\vms\\leidian" + int_41))
			{
				int num3 = 0;
				string text2;
				do
				{
					num3++;
					text2 = string_9 + "\\vms\\leidian" + int_41;
				}
				while (!Common.smethod_40(text2));
			}
			if (File.Exists(string_9 + "\\vms\\config\\leidian" + int_41 + ".config"))
			{
				int num4 = 0;
				string text3;
				do
				{
					num4++;
					text3 = string_9 + "\\vms\\config\\leidian" + int_41 + ".config";
				}
				while (!Common.smethod_76(text3));
			}
		}

		private void method_50()
		{
			Common.smethod_73("frmViewLD");
		}

		private void method_51(double double_0)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		}

		private void method_52(string string_21, string string_22, int int_41, int int_42, DataGridView dataGridView_0)
		{
			try
			{
				dataGridView_0.Invoke((Action)delegate
				{
					dataGridView_0.Rows[int_41].Cells[string_22].Value = string_21;
				});
			}
			catch
			{
			}
		}

		private string method_53()
		{
			string text = "";
			string text2 = txtListDauso.Text.Trim();
			string text3 = text2.Split(',')[random_0.Next(0, text2.Split(',').Length)];
			return text + text3;
		}

		private string method_54()
		{
			string text = "";
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "http://lumtest.com/myip.json").ToString();
				JObject jObject = JObject.Parse(json);
				return jObject["ip"]!.ToString();
			}
			catch
			{
				return "Lỗi lấy IP";
			}
		}

		private void method_55(object sender, EventArgs e)
		{
		}

		private void method_56(int int_41)
		{
			Dictionary<string, string> dataSource = method_57(int_41);
			cbbPrePhone.DataSource = new BindingSource(dataSource, null);
			cbbPrePhone.ValueMember = "Key";
			cbbPrePhone.DisplayMember = "Value";
		}

		private Dictionary<string, string> method_57(int int_41)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> list = ((int_41 == 0) ? Common.smethod_0() : Common.smethod_1());
			for (int i = 0; i < list.Count; i++)
			{
				string[] array = list[i].Split('|');
				dictionary.Add(array[0], array[1]);
			}
			return dictionary;
		}

		private void method_58()
		{
			Dictionary<string, string> dataSource = method_59();
			cbLocationProxy.DataSource = new BindingSource(dataSource, null);
			cbLocationProxy.ValueMember = "Key";
			cbLocationProxy.DisplayMember = "Value";
		}

		private Dictionary<string, string> method_59()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> list = Class67.smethod_3();
			for (int i = 0; i < list.Count; i++)
			{
				string[] array = list[i].Split('|');
				dictionary.Add(array[0], array[1]);
			}
			return dictionary;
		}

		private void method_60()
		{
			list_17.Clear();
			list_18.Clear();
			list_19.Clear();
			Class48 @class = new Class48("setting.ini");
			string text = @class.method_1("txtListXProxy");
			if (text != string.Empty)
			{
				string[] array = text.Split(';');
				string text2 = string.Empty;
				for (int i = 0; i < array.Length; i++)
				{
					list_17.Add(array[i]);
					text2 += array[i];
					if (i < array.Length - 1)
					{
						text2 += Environment.NewLine;
					}
				}
				txtListXProxy.Text = text2;
			}
			string text3 = @class.method_1("txtApiKeyTMProxy");
			if (text3 != string.Empty)
			{
				string[] array2 = text3.Split('|');
				string text4 = string.Empty;
				for (int j = 0; j < array2.Length; j++)
				{
					list_18.Add(array2[j]);
					text4 += array2[j];
					if (j < array2.Length - 1)
					{
						text4 += Environment.NewLine;
					}
				}
				txtApiKeyTMProxy.Text = text4;
			}
			string text5 = @class.method_1("txtAPIKeyShoplike");
			if (!(text5 != string.Empty))
			{
				return;
			}
			string[] array3 = text5.Split('|');
			string text6 = string.Empty;
			for (int k = 0; k < array3.Length; k++)
			{
				list_19.Add(array3[k]);
				text6 += array3[k];
				if (k < array3.Length - 1)
				{
					text6 += Environment.NewLine;
				}
			}
			txtAPIKeyShoplike.Text = text6;
		}

		private void method_61()
		{
			try
			{
				Class48 @class = new Class48("setting.ini");
				cbModeRunReg.SelectedIndex = ((!(@class.method_1("cbModeRunReg") == "")) ? Convert.ToInt32(@class.method_1("cbModeRunReg")) : 0);
				numThrLdPlay.Value = Convert.ToInt32(@class.method_1("nudThread"));
				numOTP.Value = Convert.ToInt32(@class.method_1("nudThoiGianChoNhapOTP"));
				rdNormal.Checked = ((Convert.ToInt32(@class.method_1("modeRun")) == 0) ? true : false);
				rdSwap.Checked = Convert.ToInt32(@class.method_1("modeRun")) == 1;
				rdDelayLD.Checked = true;
				numDelayFr.Value = Convert.ToInt32(@class.method_1("numDelayFr"));
				numDelayTo.Value = Convert.ToInt32(@class.method_1("numDelayTo"));
				numDeClsFr.Value = Convert.ToInt32(@class.method_1("numDeClsFr"));
				numDeClsTo.Value = Convert.ToInt32(@class.method_1("numDeClsTo"));
				numChangeIP.Value = Convert.ToInt32(@class.method_1("iSoLuotDoiIpMotLan"));
				nudSoLuotChay.Value = Convert.ToInt32(@class.method_1("nudSoLuotChay"));
				txtLinkLD.Text = @class.method_1("linkLD");
				txtNameDcom.Text = @class.method_1("txtProfileNameDcom");
				txtProxy.Text = @class.method_1("txtAPIProxy");
				nAgeFrom.Value = ((@class.method_1("nAgeFrom") == "") ? 18 : Convert.ToInt32(@class.method_1("nAgeFrom")));
				nAgeTo.Value = ((@class.method_1("nAgeTo") == "") ? 35 : Convert.ToInt32(@class.method_1("nAgeTo")));
				nudTimeWaitOTP.Value = ((@class.method_1("nudTimeWaitOTP") == "") ? 60 : Convert.ToInt32(@class.method_1("nudTimeWaitOTP")));
				nudLuongPerIPTinsoft.Value = Convert.ToInt32(@class.method_1("nudLuongPerIPTinsoft"));
				nudLuongPerIPMinProxy.Value = Convert.ToInt32(@class.method_1("nudLuongPerIPMinProxy"));
				plHotmailReg.Enabled = false;
				string text = @class.method_1("typeVerify");
				try
				{
					if (text.Substring(0, 1) == "0")
					{
						rdNoVeri.Checked = true;
						plVeriPhone.Enabled = false;
						plVeriMail.Enabled = false;
						if (text.Substring(1, 1) == "0")
						{
							rdNovriPhone.Checked = true;
							cbbPhoneCountry.SelectedIndex = Convert.ToInt32(text.Substring(2, 1));
						}
						else
						{
							rdNoveriMail.Checked = true;
							cbMailAo.SelectedIndex = Convert.ToInt32(text.Substring(2, 1));
						}
					}
					else
					{
						rdThuePhone.Checked = true;
						plNovery.Enabled = false;
						plVeriMail.Enabled = false;
						if (text.Substring(1, 1) == "0")
						{
							cbDvSim.SelectedIndex = Convert.ToInt32(text.Substring(2, 1));
						}
						else
						{
							rdConfMail.Checked = true;
							string text2 = text.Substring(2, 1);
							if (text2 != null)
							{
								switch (text2)
								{
									default:
										tabMailVeri.SelectTab(1);
										rdMailTM.Checked = true;
										break;
									case "2":
										tabMailVeri.SelectTab(1);
										rdTempMailIO.Checked = true;
										break;
									case "1":
										rdHotMailRegisted.Checked = true;
										tabMailVeri.SelectTab(0);
										break;
									case "0":
										rdHotMailReg.Checked = true;
										plHotmailReg.Enabled = true;
										tabMailVeri.SelectTab(0);
										break;
								}
							}
						}
					}
				}
				catch
				{
					rdNoVeri.Checked = true;
					rdNovriPhone.Checked = true;
				}
				ckTaoMailBox.Checked = Convert.ToBoolean(@class.method_1("ckTaoMailBox"));
				ckRdPassmail.Checked = Convert.ToBoolean(@class.method_1("ckRdPassmail"));
				txtPassmail.Text = @class.method_1("txtPassmail");
				txtAPISim.Text = @class.method_1("txtAPISim");
				txtAPIAnyCat.Text = @class.method_1("txtAPIAnyCat");
				cbNameReg.SelectedIndex = Convert.ToInt32(@class.method_1("typeNameReg"));
				txtPassFb.Text = @class.method_1("passFB");
				chkRandomPass.Checked = Convert.ToBoolean(@class.method_1("isRdPass"));
				ckCheckIP.Checked = !(@class.method_1("ckCheckIP") == "") && Convert.ToBoolean(@class.method_1("ckCheckIP"));
				switch (Convert.ToInt32(@class.method_1("typeGender")))
				{
					case 0:
						rbFemale.Checked = true;
						break;
					case 1:
						rbMale.Checked = true;
						break;
					case 2:
						rbRandomMF.Checked = true;
						break;
				}
				switch (Convert.ToInt32(@class.method_1("typeChangeIp")))
				{
					case 0:
						rdNoChangeIP.Checked = true;
						rdProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rdMinProxy.Checked = false;
						rbTMProxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rbXproxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plXproxy.Enabled = false;
						plTMProxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;	
						tabProxy.Enabled = false;
						pnlProxyFree.Enabled = false;
						break;
					case 1:
						rdChangeIPDcom.Checked = true;
						rdProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbTMProxy.Checked = false;
						rdMinProxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rbXproxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plXproxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						plTMProxy.Enabled = false;
						tabProxy.Enabled = false;
						plTMProxy.Enabled = false;
						pnlProxyFree.Enabled = false;
						break;
					case 2:
						rdProxy.Checked = true;
						rdTinsoftProxy.Checked = true;
						rdMinProxy.Checked = false;
						rbTMProxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rbXproxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plXproxy.Enabled = false;
						plTMProxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						pnlProxyFree.Enabled = false;
						tabProxy.SelectTab(0);
						break;
					case 4:
						rdHMA.Checked = true;
						rdProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbTMProxy.Checked = false;
						rdMinProxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rbXproxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plChangeIPDcom.Enabled = false;
						plXproxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						plTMProxy.Enabled = false;
						tabProxy.Enabled = false;
						plTMProxy.Enabled = false;
						pnlProxyFree.Enabled = false;
						break;
					case 5:
						rdProxy.Checked = true;
						rdIPPortUserPass.Checked = true;
						rbTMProxy.Checked = false;
						rbXproxy.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plXproxy.Enabled = false;
						plTMProxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						pnlProxyFree.Enabled = false;
						tabProxy.SelectTab(1);
						break;
					case 6:
						rdProxy.Checked = true;
						rbXproxy.Checked = true;
						rbTMProxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plTMProxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						pnlProxyFree.Enabled = false;
						tabProxy.SelectTab(2);
						break;
					case 7:
						rdProxy.Checked = true;
						rbTMProxy.Checked = true;
						rbXproxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbProxyShoplike.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plXproxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						pnlProxyFree.Enabled = false;
						tabProxy.SelectTab(3);
						break;
					case 8:
						rdProxy.Checked = true;
						rbProxyShoplike.Checked = true;
						rbXproxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbTMProxy.Checked = false;
						rdProxyOrbit.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plTMProxy.Enabled = false;
						plXproxy.Enabled = false;
						pnlProxyFree.Enabled = false;
						tabProxy.SelectTab(4);
						break;
					case 9:
						rdProxy.Checked = true;
						rdProxyOrbit.Checked = true;
						rbProxyShoplike.Checked = false;
						rbXproxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbTMProxy.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plTMProxy.Enabled = false;
						plXproxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						plProxyv6.Enabled = false;
						rbProxyv6.Checked = false;
						tabProxy.SelectTab(5);
						break;
					case 10:
						rdProxy.Checked = true;
						rbProxyv6.Checked = true;
						plProxyv6.Enabled = true;
						rdProxyOrbit.Checked = false;
						rbProxyShoplike.Checked = false;
						rbXproxy.Checked = false;
						rdIPPortUserPass.Checked = false;
						rdMinProxy.Checked = false;
						rdTinsoftProxy.Checked = false;
						rbTMProxy.Checked = false;
						plChangeIPDcom.Enabled = false;
						plTinsoftProxy.Enabled = false;
						pnlAPIMinProxy.Enabled = false;
						plCheckDoiIP.Enabled = false;
						plTMProxy.Enabled = false;
						plXproxy.Enabled = false;
						plProxyShopLike.Enabled = false;
						tabProxy.SelectTab(6);
						break;
				}
				txtListDauso.Text = ((@class.method_1("txtListDauso") == "") ? "" : @class.method_1("txtListDauso"));
				cbLocationProxy.SelectedValue = @class.method_1("cbbLocationTinsoft");
				chk2FA.Checked = Convert.ToBoolean(@class.method_1("is2Fa"));
				nudDelayQR2Fa.Value = ((@class.method_1("nudDelayQR2Fa") == "") ? 10 : Convert.ToInt32(@class.method_1("nudDelayQR2Fa")));
				chkAvartar.Checked = Convert.ToBoolean(@class.method_1("isAvartar"));
				chkCoverImg.Checked = Convert.ToBoolean(@class.method_1("isCoverImg"));
				cbbPhoneCountry.SelectedIndex = Convert.ToInt32(@class.method_1("cbbPhoneCountry"));
				chkAddFUID.Checked = Convert.ToBoolean(@class.method_1("chkAddFUID"));
				chkInNewfeed.Checked = Convert.ToBoolean(@class.method_1("chkInNewfeed"));
				chkWStory.Checked = Convert.ToBoolean(@class.method_1("chkWStory"));
				chkWatch.Checked = Convert.ToBoolean(@class.method_1("chkWatch"));
				chkReadNotifi.Checked = Convert.ToBoolean(@class.method_1("chkReadNotifi"));
				nFriendFrom.Value = Convert.ToInt32(@class.method_1("nFriendFrom"));
				nFriendTo.Value = Convert.ToInt32(@class.method_1("nFriendTo"));
				chkLike.Checked = Convert.ToBoolean(@class.method_1("chkLike"));
				chkBuon.Checked = Convert.ToBoolean(@class.method_1("chkBuon"));
				chkTym.Checked = Convert.ToBoolean(@class.method_1("chkTym"));
				chkGian.Checked = Convert.ToBoolean(@class.method_1("chkGian"));
				chkHaha.Checked = Convert.ToBoolean(@class.method_1("chkHaha"));
				chkHideBrowser.Checked = Convert.ToBoolean(@class.method_1("chkHideBrowser"));
				txtLinkAvartar.Text = ((@class.method_1("linkAvartar") == "") ? "" : @class.method_1("linkAvartar"));
				cbbTypeProxyIP.SelectedIndex = ((!(@class.method_1("cbbTypeProxyIP") == "")) ? Convert.ToInt32(@class.method_1("cbbTypeProxyIP")) : 0);
				int_25 = ((@class.method_1("cbbTypeProxyIP") == "") ? (-1) : Convert.ToInt32(@class.method_1("cbbTypeProxyIP")));
				rdIPDong.Checked = !(@class.method_1("rdIPDong") == "") && Convert.ToBoolean(@class.method_1("rdIPDong"));
				rdIPStatic.Checked = !(@class.method_1("rdIPStatic") == "") && Convert.ToBoolean(@class.method_1("rdIPStatic"));
				plAddfriend.Enabled = chkAddFUID.Checked;
				gbCamxuc.Enabled = chkWStory.Checked;
				pnlAPIMinProxy.Enabled = rdMinProxy.Checked;
				if (chkLike.Checked)
				{
					list_10.Add(1.ToString());
				}
				if (chkTym.Checked)
				{
					list_10.Add(2.ToString());
				}
				if (chkHaha.Checked)
				{
					list_10.Add(3.ToString());
				}
				if (chkBuon.Checked)
				{
					list_10.Add(4.ToString());
				}
				if (chkGian.Checked)
				{
					list_10.Add(5.ToString());
				}
				string text3 = @class.method_1("apiMinProxy");
				if (text3 != string.Empty)
				{
					string[] array = text3.Split('|');
					string text4 = string.Empty;
					for (int i = 0; i < array.Length; i++)
					{
						list_11.Add(array[i]);
						text4 += array[i];
						if (i < array.Length - 1)
						{
							text4 += Environment.NewLine;
						}
					}
					txtApiKeyMinProxy.Text = text4;
				}
				txtServiceURLXProxy.Text = ((@class.method_1("txtServiceURLXProxy") == "") ? "" : @class.method_1("txtServiceURLXProxy"));
				if (@class.method_1("typeXProxy") == "" || Convert.ToInt32(@class.method_1("typeXProxy")) == 0)
				{
					rbHttpProxy.Checked = true;
				}
				else
				{
					rbSock5Proxy.Checked = true;
				}
				nudLuongPerIPXProxy.Value = ((@class.method_1("nudLuongPerIPXProxy") == "") ? 1 : Convert.ToInt32(@class.method_1("nudLuongPerIPXProxy")));
				nudDelayResetXProxy.Value = ((@class.method_1("nudDelayResetXProxy") == "") ? 1 : Convert.ToInt32(@class.method_1("nudDelayResetXProxy")));
				ckbWaitDoneAllXproxy.Checked = !(@class.method_1("ckbWaitDoneAllXproxy") == "") && Convert.ToBoolean(@class.method_1("ckbWaitDoneAllXproxy"));
				if (@class.method_1("typeRunXproxy") == "" || Convert.ToInt32(@class.method_1("typeRunXproxy")) == 0)
				{
					rbXproxyResetEachProxy.Checked = true;
				}
				else
				{
					rbXproxyResetAllProxy.Checked = true;
				}
				string text5 = @class.method_1("txtListXProxy");
				if (text5 != string.Empty)
				{
					string[] array2 = text5.Split(';');
					string text6 = string.Empty;
					for (int j = 0; j < array2.Length; j++)
					{
						text6 += array2[j];
						if (j < array2.Length - 1)
						{
							text6 += Environment.NewLine;
						}
					}
					txtListXProxy.Text = text6;
				}
				nudLuongPerIPTMProxy.Value = ((@class.method_1("nudLuongPerIPTMProxy") == "") ? 1 : Convert.ToInt32(@class.method_1("nudLuongPerIPTMProxy")));
				string text7 = @class.method_1("txtApiKeyTMProxy");
				if (text7 != string.Empty)
				{
					string[] array3 = text7.Split('|');
					string text8 = string.Empty;
					for (int k = 0; k < array3.Length; k++)
					{
						text8 += array3[k];
						if (k < array3.Length - 1)
						{
							text8 += Environment.NewLine;
						}
					}
					txtApiKeyTMProxy.Text = text8;
				}
				nudThreadShopLike.Value = ((@class.method_1("nudThreadShopLike") == "") ? 1 : Convert.ToInt32(@class.method_1("nudThreadShopLike")));
				string text9 = @class.method_1("txtAPIKeyShoplike");
				if (text9 != string.Empty)
				{
					string[] array4 = text9.Split('|');
					string text10 = string.Empty;
					for (int l = 0; l < array4.Length; l++)
					{
						text10 += array4[l];
						if (l < array4.Length - 1)
						{
							text10 += Environment.NewLine;
						}
					}
					txtAPIKeyShoplike.Text = text10;
				}
				switch ((!(@class.method_1("typeProxyOrbit") == "")) ? Convert.ToInt32(@class.method_1("typeProxyOrbit")) : 0)
				{
					case 1:
						rdProxyFreeUS.Checked = true;
						break;
					case 2:
						rdProxyFreeRandom.Checked = true;
						break;
					default:
						rdProxyFreeVN.Checked = true;
						break;
				}
			}
			catch
			{
			}
		}

		private void btnSaveConf_Click(object sender, EventArgs e)
		{
			try
			{
				Class48 @class = new Class48("setting.ini");
				@class.method_2("cbModeRunReg", cbModeRunReg.SelectedIndex.ToString());
				@class.method_2("nudThread", numThrLdPlay.Value.ToString());
				@class.method_2("nudThoiGianChoNhapOTP", numOTP.Value.ToString());
				int num = 0;
				if (rdNormal.Checked)
				{
					num = 0;
				}
				else if (rdSwap.Checked)
				{
					num = 1;
				}
				@class.method_2("modeRun", num.ToString());
				int num2 = 0;
				if (rdDelayLD.Checked)
				{
					num2 = 1;
				}
				@class.method_2("optionMemu", num2.ToString());
				@class.method_2("numDelayFr", numDelayFr.Value.ToString());
				@class.method_2("numDelayTo", numDelayTo.Value.ToString());
				@class.method_2("numDeClsFr", numDeClsFr.Value.ToString());
				@class.method_2("numDeClsTo", numDeClsTo.Value.ToString());
				@class.method_2("linkLD", txtLinkLD.Text.Trim());
				@class.method_2("nAgeFrom", nAgeFrom.Value.ToString());
				@class.method_2("nAgeTo", nAgeTo.Value.ToString());
				@class.method_2("nudTimeWaitOTP", nudTimeWaitOTP.Value.ToString());
				int num3 = 0;
				if (rdNoChangeIP.Checked)
				{
					num3 = 0;
				}
				else if (rdChangeIPDcom.Checked)
				{
					num3 = 1;
				}
				else if (rdProxy.Checked)
				{
					if (rdTinsoftProxy.Checked)
					{
						num3 = 2;
					}
					else if (rdMinProxy.Checked)
					{
						num3 = 3;
					}
					else if (rdIPPortUserPass.Checked)
					{
						num3 = 5;
					}
					else if (rbXproxy.Checked)
					{
						num3 = 6;
					}
					else if (rbTMProxy.Checked)
					{
						num3 = 7;
					}
					else if (rbProxyShoplike.Checked)
					{
						num3 = 8;
					}
					else if (rdProxyOrbit.Checked)
					{
						num3 = 9;
					}
					else if (rbProxyv6.Checked)
                    {
						num3 = 10;
                    }
				}
				else if (rdHMA.Checked)
				{
					num3 = 4;
				}
				@class.method_2("rdIPStatic", rdIPStatic.Checked.ToString());
				@class.method_2("rdIPDong", rdIPDong.Checked.ToString());
				@class.method_2("typeChangeIp", num3.ToString());
				@class.method_2("txtProfileNameDcom", txtNameDcom.Text);
				@class.method_2("txtAPIProxy", txtProxy.Text);
				@class.method_2("cbbLocationTinsoft", cbLocationProxy.SelectedValue.ToString());
				@class.method_2("nudLuongPerIPTinsoft", nudLuongPerIPTinsoft.Value.ToString());
				@class.method_2("nudSoLuotChay", nudSoLuotChay.Value.ToString());
				@class.method_2("nudLuongPerIPMinProxy", nudLuongPerIPMinProxy.Value.ToString());
				@class.method_2("nudLuongPerIPTMProxy", nudLuongPerIPTMProxy.Value.ToString());
				@class.method_2("nudThreadShopLike", nudThreadShopLike.Value.ToString());
				@class.method_2("txtListDauso", txtListDauso.Text.ToString());
				int num4 = 0;
				if (rdProxyOrbit.Checked)
				{
					if (rdProxyFreeUS.Checked)
					{
						num4 = 1;
					}
					else if (rdProxyFreeRandom.Checked)
					{
						num4 = 2;
					}
				}
				@class.method_2("typeProxyOrbit", num4.ToString());
				if (txtApiKeyMinProxy.Text != "")
				{
					string[] array = txtApiKeyMinProxy.Text.Split('\n');
					if (array.Length != 0)
					{
						string text = string.Empty;
						for (int i = 0; i < array.Length; i++)
						{
							text += array[i];
							if (i < array.Length - 1)
							{
								text += "|";
							}
						}
						@class.method_2("apiMinProxy", text);
					}
				}
				else
				{
					@class.method_2("apiMinProxy", string.Empty);
				}
				if (txtApiKeyTMProxy.Text != "")
				{
					string[] array2 = txtApiKeyTMProxy.Text.Split('\n');
					if (array2.Length != 0)
					{
						string text2 = string.Empty;
						for (int j = 0; j < array2.Length; j++)
						{
							text2 += array2[j];
							if (j < array2.Length - 1)
							{
								text2 += "|";
							}
						}
						@class.method_2("txtApiKeyTMProxy", text2);
					}
				}
				else
				{
					@class.method_2("txtApiKeyTMProxy", string.Empty);
				}
				if (txtAPIKeyShoplike.Text != "")
				{
					string[] array3 = txtAPIKeyShoplike.Text.Split('\n');
					if (array3.Length != 0)
					{
						string text3 = string.Empty;
						for (int k = 0; k < array3.Length; k++)
						{
							text3 += array3[k];
							if (k < array3.Length - 1)
							{
								text3 += "|";
							}
						}
						@class.method_2("txtAPIKeyShoplike", text3);
					}
				}
				else
				{
					@class.method_2("txtAPIKeyShoplike", string.Empty);
				}
				if (txtApiProxyv6.Text != "")
				{
					string[] array4 = txtApiProxyv6.Text.Split('\n');
					if (array4.Length != 0)
					{
						string text5 = string.Empty;
						for (int f = 0; f < array4.Length; f++)
						{
							text5 += array4[f];
							if (f < array4.Length - 1)
							{
								text5 += "|";
							}
						}
						@class.method_2("txtApiProxyv6", text5);
					}
				}
				else
				{
					@class.method_2("txtApiProxyv6", string.Empty);
				}
				string text4 = "";
				if (rdNoVeri.Checked)
				{
					if (rdNovriPhone.Checked)
					{
						text4 = "00" + cbbPhoneCountry.SelectedIndex;
					}
					else if (rdNoveriMail.Checked)
					{
						text4 = "01" + cbMailAo.SelectedIndex;
					}
				}
				else if (rdThuePhone.Checked)
				{
					text4 = "10" + cbDvSim.SelectedIndex;
				}
				else if (rdHotMailReg.Checked)
				{
					text4 = "110";
				}
				else if (rdHotMailRegisted.Checked)
				{
					text4 = "111";
				}
				else if (rdTempMailIO.Checked)
				{
					text4 = "112";
				}
				else if (rdMailTM.Checked)
				{
					text4 = "113";
				}
				@class.method_2("typeVerify", text4);
				@class.method_2("txtAPISim", txtAPISim.Text);
				@class.method_2("txtAPIAnyCat", txtAPIAnyCat.Text);
				@class.method_2("txtPassmail", txtPassmail.Text);
				@class.method_2("ckTaoMailBox", ckTaoMailBox.Checked.ToString());
				@class.method_2("ckRdPassmail", ckRdPassmail.Checked.ToString());
				@class.method_2("typeNameReg", cbNameReg.SelectedIndex.ToString());
				@class.method_2("passFB", txtPassFb.Text);
				@class.method_2("isRdPass", chkRandomPass.Checked.ToString());
				@class.method_2("ckCheckIP", ckCheckIP.Checked.ToString());
				int num5 = 0;
				@class.method_2("typeGender", ((!rbFemale.Checked) ? (rbMale.Checked ? 1 : 2) : 0).ToString());
				@class.method_2("is2Fa", chk2FA.Checked.ToString());
				@class.method_2("nudDelayQR2Fa", nudDelayQR2Fa.Value.ToString());
				@class.method_2("isAvartar", chkAvartar.Checked.ToString());
				@class.method_2("isCoverImg", chkCoverImg.Checked.ToString());
				@class.method_2("cbbPhoneCountry", cbbPhoneCountry.SelectedIndex.ToString());
				@class.method_2("iSoLuotDoiIpMotLan", numChangeIP.Value.ToString());
				@class.method_2("chkReadNotifi", chkReadNotifi.Checked.ToString());
				@class.method_2("chkWatch", chkWatch.Checked.ToString());
				@class.method_2("chkWStory", chkWStory.Checked.ToString());
				@class.method_2("chkInNewfeed", chkInNewfeed.Checked.ToString());
				@class.method_2("chkAddFUID", chkAddFUID.Checked.ToString());
				@class.method_2("nFriendFrom", nFriendFrom.Value.ToString());
				@class.method_2("nFriendTo", nFriendTo.Value.ToString());
				@class.method_2("chkLike", chkLike.Checked.ToString());
				@class.method_2("chkGian", chkGian.Checked.ToString());
				@class.method_2("chkHaha", chkHaha.Checked.ToString());
				@class.method_2("chkBuon", chkBuon.Checked.ToString());
				@class.method_2("chkTym", chkTym.Checked.ToString());
				@class.method_2("chkHideBrowser", chkHideBrowser.Checked.ToString());
				@class.method_2("linkAvartar", txtLinkAvartar.Text.Trim());
				if (rdIPPortUserPass.Checked)
				{
					@class.method_2("cbbTypeProxyIP", cbbTypeProxyIP.SelectedIndex.ToString());
				}
				@class.method_2("txtServiceURLXProxy", txtServiceURLXProxy.Text.Trim());
				int num6 = 0;
				if (rbSock5Proxy.Checked)
				{
					num6 = 1;
				}
				@class.method_2("typeXProxy", num6.ToString());
				@class.method_2("nudLuongPerIPXProxy", nudLuongPerIPXProxy.Value.ToString());
				@class.method_2("nudDelayResetXProxy", nudDelayResetXProxy.Value.ToString());
				@class.method_2("ckbWaitDoneAllXproxy", ckbWaitDoneAllXproxy.Checked.ToString());
				int num7 = 0;
				if (rbXproxyResetAllProxy.Checked)
				{
					num7 = 1;
				}
				@class.method_2("typeRunXproxy", num7.ToString());
				if (txtListXProxy.Text != "")
				{
					string[] array4 = txtListXProxy.Text.Split('\n');
					if (array4.Length != 0)
					{
						string text5 = string.Empty;
						for (int l = 0; l < array4.Length; l++)
						{
							text5 += array4[l];
							if (l < array4.Length - 1)
							{
								text5 += ";";
							}
						}
						@class.method_2("txtListXProxy", text5);
					}
				}
				else
				{
					@class.method_2("txtListXProxy", string.Empty);
				}
				MessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch
			{
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnStop.Text = "Đang dừng...";
			bool_0 = true;
			list_17.Clear();
			list_18.Clear();
			list_19.Clear();
		}

		private void method_62(int int_41, string string_21, Device device_0 = null)
		{
			try
			{
				method_52(string_21, "status", int_41, 0, dgvAcc);
				if (device_0 != null)
				{
					if (string_21.StartsWith("("))
					{
						string_21 = string_21.Substring(string_21.IndexOf(")") + 1);
					}
					device_0.method_112(string_21);
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "SetStatusAccount");
			}
		}

		private void btnCheckSim_Click(object sender, EventArgs e)
		{
			try
			{
				if (!rdThuePhone.Checked)
				{
					return;
				}
				string text = txtAPISim.Text.ToString();
				string empty = string.Empty;
				if (cbDvSim.SelectedIndex == 0) // Ctsc
				{

					empty = Common.smethod_10(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}

				}
				else if (cbDvSim.SelectedIndex == 1) // viotp
				{
					empty = Common.smethod_15(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (cbDvSim.SelectedIndex == 2) // Codetext247
				{
					empty = Common.smethod_16(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (cbDvSim.SelectedIndex == 3) // codesimnet
				{
					MessageBox.Show("Codesim.net không hỗ trợ API check Balance!!!" + Environment.NewLine + "Bạn kiểm tra số tiền trên web trước khi chạy nha! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (cbDvSim.SelectedIndex == 4) //primeotp.me
				{
					if (Common.smethod_17(text))
					{
						MessageBox.Show("Api key hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Api key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (cbDvSim.SelectedIndex == 5) // tempsms.co
				{
					empty = Common.smethod_13(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (cbDvSim.SelectedIndex == 6)
				{
					MessageBox.Show("Vui long check tren web !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (cbDvSim.SelectedIndex == 7)
				{
					MessageBox.Show("Check tren web chuan la duoc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					
				}
				else if (cbDvSim.SelectedIndex == 8)
				{
					empty = Common.CheckKeyAhasim(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (cbDvSim.SelectedIndex == 9)
				{

					empty = Common.CheckKeyAhasim(text);
					if (empty == "")
					{
						MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}

				}
				else if (cbDvSim.SelectedIndex == 10)
				{

					MessageBox.Show("Vui long check tren web !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

				}
				//else if (cbDvSim.SelectedIndex == 11)
				//{

				//	empty = Common.CheckKeyAhasim(text);
				//	if (empty == "")
				//	{
				//		MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				//	}
				//	else
				//	{
				//		MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				//	}

				//}
			}
			catch (Exception)
			{
				MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			method_13();
		}

		private void btnGetDcom_Click(object sender, EventArgs e)
		{
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				};
				Process process = Process.Start(startInfo);
				string text = process.StandardOutput.ReadToEnd();
				if (text.Split('\n').Length <= 3)
				{
					MessageBox.Show("Vui lòng kết nối Dcom trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				txtNameDcom.Text = text.Split('\n').ToList()[1];
				MessageBox.Show("Lấy tên cấu hình Dcom thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void method_63(object sender, EventArgs e)
		{
			plTinsoftProxy.Enabled = rdTinsoftProxy.Checked;
		}

		private void rdConfMail_CheckedChanged(object sender, EventArgs e)
		{
			Panel panel = plVeriMail;
			bool enabled = (pnlTemmail.Enabled = rdConfMail.Checked);
			panel.Enabled = enabled;
		}
		private void radiobutton1_CheckedChanged(object sender, EventArgs e)
		{

        }
        private void rdThuePhone_CheckedChanged(object sender, EventArgs e)
		{
			plVeriPhone.Enabled = rdThuePhone.Checked;
		}

		private void btnCheckProxy_Click(object sender, EventArgs e)
		{
			string text = txtProxy.Text.Trim();
			List<string> list = Class67.smethod_2(text);
			if (list.Count > 0)
			{
				MessageBox.Show($"Đang có {list.Count} proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Không có proxy khả dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void rdNoVeri_CheckedChanged(object sender, EventArgs e)
		{
			plNovery.Enabled = rdNoVeri.Checked;
			rdNovriPhone.Checked = true;
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			method_66("All");
		}

		private bool method_64(int int_41, Device device_0)
		{
			bool flag = false;
			string text = "";
			for (int i = 0; i < 3; i++)
			{
				device_0.method_125();
				device_0.method_121(5.0);
				for (int j = 0; j < 5; j++)
				{
					if (device_0.method_3("DataClick\\fblite\\menu"))
					{
						flag = true;
						break;
					}
				}
				int num = 0;
				if (!flag)
				{
					continue;
				}
				while (num < 5)
				{
					if (!device_0.method_3("DataClick\\fblite\\caidat"))
					{
						if (!device_0.method_81(500))
						{
							flag = false;
							device_0.method_121(1.0);
							num++;
						}
						continue;
					}
					flag = true;
					break;
				}
				int num2 = 0;
				if (!flag)
				{
					continue;
				}
				device_0.method_121(3.0);
				while (num2 < 5)
				{
					if (!device_0.method_3("DataClick\\fblite\\securityandlogin"))
					{
						if (!device_0.method_81(500))
						{
							flag = false;
							device_0.method_121(1.0);
							num2++;
						}
						continue;
					}
					flag = true;
					break;
				}
				int num3 = 0;
				if (!flag)
				{
					continue;
				}
				while (num3 < 5)
				{
					if (!device_0.method_3("DataClick\\fblite\\usetwoauthen"))
					{
						if (!device_0.method_81(500))
						{
							flag = false;
							device_0.method_121(1.0);
							num3++;
						}
						continue;
					}
					flag = true;
					break;
				}
				int k = 0;
				if (!flag)
				{
					continue;
				}
				for (; k < 5; k++)
				{
					if (!device_0.method_3("DataClick\\fblite\\useappverify"))
					{
						flag = false;
						continue;
					}
					flag = true;
					break;
				}
				if (!flag)
				{
					continue;
				}
				for (int l = 0; l < 3; l++)
				{
					try
					{
						method_62(int_41, "Chờ " + int_34 + " giây để quét QRCode", device_0);
						device_0.method_121(int_34);
						Bitmap bitmap_ = device_0.method_33();
						text = Common.smethod_67(bitmap_);
						text = Regex.Match(text, "secret=(.*?)&").Groups[1].Value;
						if (!string.IsNullOrEmpty(text))
						{
							flag = true;
							break;
						}
						flag = false;
						device_0.method_121(1.0);
						continue;
					}
					catch (Exception exception_)
					{
						method_62(int_41, "Không quét được mã QRCode. Thực hiện lại", device_0);
						Common.smethod_82(exception_, "ScanQRCode2Fa");
						flag = false;
					}
					break;
				}
				if (!string.IsNullOrEmpty(text))
				{
					method_22(int_41, "conf_2fa", text);
					int num4 = 0;
					while (num4 < 10)
					{
						if (!device_0.method_3("DataClick\\fblite\\next"))
						{
							if (!device_0.method_81(500))
							{
								flag = false;
								device_0.method_121(1.0);
								num4++;
							}
							continue;
						}
						flag = true;
						break;
					}
					if (flag)
					{
						string text2 = Common.smethod_72(text);
						device_0.method_121(2.0);
						device_0.method_3("DataClick\\fblite\\codeotp");
						device_0.method_121(1.0);
						device_0.method_49(text2, bool_0: false, bool_1: false);
						device_0.method_121(1.0);
						device_0.method_3("DataClick\\fblite\\next");
						device_0.method_121(5.0);
						break;
					}
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		private bool method_65(string string_21, Device device_0)
		{
			bool flag = false;
			device_0.method_126(string_21);
			device_0.method_121(1.0);
			for (int i = 0; i < 10; i++)
			{
				if (device_0.method_52("DataClick\\fblite\\x"))
				{
					device_0.method_3("DataClick\\fblite\\x");
					flag = true;
					break;
				}
			}
			if (flag)
			{
				device_0.method_85("shell rm /sdcard/*.png");
				device_0.method_85("shell am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard/Pictures");
				device_0.method_121(2.0);
				if (device_0.method_52("DataClick\\fblite\\avartar"))
				{
					device_0.method_3("DataClick\\fblite\\avartar");
				}
				device_0.method_121(2.0);
				if (device_0.method_52("DataClick\\fblite\\taianhlen"))
				{
					device_0.method_3("DataClick\\fblite\\taianhlen");
				}
				device_0.method_121(1.0);
				device_0.method_91(143, 324);
				string text = "";
				for (int j = 0; j < 5; j++)
				{
					text = device_0.method_94();
					List<string> list = device_0.method_77("\"android.widget.imageview\"", text);
					if (list.Count >= 2)
					{
						int num = random_0.Next(0, 10);
						for (int k = 0; k < num; k++)
						{
							if (device_0.method_81(500, 2, "[125,444][179,465]", "[146,313][223,348]", "[124,359][196,423]"))
							{
								break;
							}
							device_0.method_121(1.0);
						}
					}
					device_0.method_89("[40,100][300,400]");
					device_0.method_121(5.0);
					if (device_0.method_52("DataClick\\fblite\\capnhat"))
					{
						device_0.method_3("DataClick\\fblite\\capnhat");
						flag = true;
						device_0.method_121(10.0);
						break;
					}
				}
			}
			return flag;
		}

		private void method_66(string string_21)
		{
			switch (string_21)
			{
				case "ToggleCheck":
					{
						for (int k = 0; k < dgvAcc.SelectedRows.Count; k++)
						{
							int index = dgvAcc.SelectedRows[k].Index;
							method_22(index, "cChose", !Convert.ToBoolean(method_1(index, "cChose")));
						}
						method_67();
						break;
					}
				case "SelectHighline":
					{
						DataGridViewSelectedRowCollection selectedRows = dgvAcc.SelectedRows;
						for (int j = 0; j < selectedRows.Count; j++)
						{
							method_22(selectedRows[j].Index, "cChose", true);
						}
						method_67();
						break;
					}
				case "UnAll":
					{
						for (int l = 0; l < dgvAcc.RowCount; l++)
						{
							method_22(l, "cChose", false);
						}
						method_67(0);
						break;
					}
				case "All":
					{
						for (int i = 0; i < dgvAcc.RowCount; i++)
						{
							method_22(i, "cChose", true);
						}
						method_67(dgvAcc.RowCount);
						break;
					}
			}
		}

		private void method_67(int int_41 = -1)
		{
			if (int_41 == -1)
			{
				int_41 = 0;
				for (int i = 0; i < dgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dgvAcc.Rows[i].Cells["cChose"].Value))
					{
						int_41++;
					}
				}
			}
			lblCountSelect.Text = int_41.ToString();
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			method_66("UnAll");
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			method_66("SelectHighline");
		}

		private uint method_68(string string_21)
		{
			uint num = 0u;
			if (string_21 != null)
			{
				num = 2166136261u;
				for (int i = 0; i < string_21.Length; i++)
				{
					num = (string_21[i] ^ num) * 16777619;
				}
			}
			return num;
		}

		private void method_69(string string_21)
		{
			try
			{
				string text = "";
				List<string> list = new List<string>();
				int num = 0;
				while (true)
				{
					if (num < dgvAcc.Rows.Count)
					{
						if (Convert.ToBoolean(method_1(num, "cChose")))
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				list.Add(method_1(num, "cId"));
				if (list.Count == 0)
				{
					MessageBox.Show("Vui lòng chọn danh sách tài khoản muốn copy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				switch (method_68(string_21))
				{
					case 457434463u:
						{
							if (!(string_21 == "uid|pass|token|cookie"))
							{
								break;
							}
							for (int num9 = 0; num9 < dgvAcc.RowCount; num9++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num9].Cells["cChose"].Value))
								{
									text = text + method_1(num9, "uid") + "|" + method_1(num9, "pass") + "|" + method_1(num9, "token") + "|" + method_1(num9, "cookie") + "\r\n";
								}
							}
							break;
						}
					case 159575910u:
						{
							if (!(string_21 == "uid|pass"))
							{
								break;
							}
							for (int num7 = 0; num7 < dgvAcc.RowCount; num7++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num7].Cells["cChose"].Value))
								{
									text = text + method_1(num7, "uid") + "|" + method_1(num7, "pass") + "\r\n";
								}
							}
							break;
						}
					case 1329202400u:
						{
							if (!(string_21 == "mail|passmail"))
							{
								break;
							}
							for (int m = 0; m < dgvAcc.RowCount; m++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[m].Cells["cChose"].Value))
								{
									text = text + method_1(m, "email") + "|" + method_1(m, "passMail") + "\r\n";
								}
							}
							break;
						}
					case 738560386u:
						if (!(string_21 == "ma2fa"))
						{
						}
						break;
					case 1718322808u:
						{
							if (!(string_21 == "2fa"))
							{
								break;
							}
							for (int num3 = 0; num3 < dgvAcc.RowCount; num3++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num3].Cells["cChose"].Value))
								{
									text = text + method_1(num3, "cFa2") + "\r\n";
								}
							}
							break;
						}
					case 1556604621u:
						{
							if (!(string_21 == "uid"))
							{
								break;
							}
							for (int num12 = 0; num12 < dgvAcc.RowCount; num12++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num12].Cells["cChose"].Value))
								{
									text = text + method_1(num12, "cUid") + "\r\n";
								}
							}
							break;
						}
					case 2071622424u:
						{
							if (!(string_21 == "pass"))
							{
								break;
							}
							for (int num4 = 0; num4 < dgvAcc.RowCount; num4++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num4].Cells["cChose"].Value))
								{
									text = text + method_1(num4, "cPassword") + "\r\n";
								}
							}
							break;
						}
					case 2000032175u:
						{
							if (!(string_21 == "phone"))
							{
								break;
							}
							for (int j = 0; j < dgvAcc.RowCount; j++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[j].Cells["cChose"].Value))
								{
									text = text + method_1(j, "phone") + "\r\n";
								}
							}
							break;
						}
					case 2007449791u:
						{
							if (!(string_21 == "cookie"))
							{
								break;
							}
							for (int num10 = 0; num10 < dgvAcc.RowCount; num10++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num10].Cells["cChose"].Value))
								{
									string text2 = method_1(num10, "cCookies");
									text = text + text2 + "\r\n";
								}
							}
							break;
						}
					case 2337339239u:
						{
							if (!(string_21 == "useragent"))
							{
								break;
							}
							for (int num6 = 0; num6 < dgvAcc.RowCount; num6++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num6].Cells["cChose"].Value))
								{
									text = text + method_1(num6, "cUseragent") + "\r\n";
								}
							}
							break;
						}
					case 2107770459u:
						{
							if (!(string_21 == "proxy"))
							{
								break;
							}
							for (int n = 0; n < dgvAcc.RowCount; n++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[n].Cells["cChose"].Value))
								{
									text = text + method_1(n, "uid") + "|" + method_1(n, "pass") + "|" + method_1(n, "conf_2fa") + "|" + method_1(n, "cookie") + "|" + method_1(n, "token") + "|" + method_1(n, "ho") + "|" + method_1(n, "ten") + "|" + method_1(n, "gender") + "|" + method_1(n, "phone") + "|" + method_1(n, "email") + "|" + method_1(n, "passMail") + "|" + method_1(n, "proxy") + "\r\n";
								}
							}
							break;
						}
					case 2491017778u:
						{
							if (!(string_21 == "token"))
							{
								break;
							}
							for (int k = 0; k < dgvAcc.RowCount; k++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[k].Cells["cChose"].Value))
								{
									text = text + method_1(k, "cToken") + "\r\n";
								}
							}
							break;
						}
					case 2369371622u:
						{
							if (!(string_21 == "name"))
							{
								break;
							}
							for (int num11 = 0; num11 < dgvAcc.RowCount; num11++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num11].Cells["cChose"].Value))
								{
									text = text + method_1(num11, "cName") + "\r\n";
								}
							}
							break;
						}
					case 3144981877u:
						{
							if (!(string_21 == "uid|pass|2fa"))
							{
								break;
							}
							for (int num8 = 0; num8 < dgvAcc.RowCount; num8++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num8].Cells["cChose"].Value))
								{
									text = text + method_1(num8, "uid") + "|" + method_1(num8, "pass") + "|" + method_1(num8, "conf_2fa") + "\r\n";
								}
							}
							break;
						}
					case 2703251604u:
						{
							if (!(string_21 == "uid|pass|token|cookie|mail|passmail"))
							{
								break;
							}
							for (int num5 = 0; num5 < dgvAcc.RowCount; num5++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num5].Cells["cChose"].Value))
								{
									text = text + method_1(num5, "cUid") + "|" + method_1(num5, "cPassword") + "|" + method_1(num5, "cToken") + "|" + method_1(num5, "cCookies") + "|" + method_1(num5, "cEmail") + "|" + method_1(num5, "cPassMail") + "\r\n";
								}
							}
							break;
						}
					case 4025178668u:
						{
							if (!(string_21 == "birthday"))
							{
								break;
							}
							for (int num2 = 0; num2 < dgvAcc.RowCount; num2++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[num2].Cells["cChose"].Value))
								{
									text = text + method_1(num2, "cBirthday") + "\r\n";
								}
							}
							break;
						}
					case 3968918830u:
						{
							if (!(string_21 == "mail"))
							{
								break;
							}
							for (int l = 0; l < dgvAcc.RowCount; l++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[l].Cells["cChose"].Value))
								{
									text = text + method_1(l, "cEmail") + "\r\n";
								}
							}
							break;
						}
					case 3728375369u:
						if (string_21 == "uid|pass|token|cookie|mail|passmail|fa2")
						{
							for (int i = 0; i < dgvAcc.RowCount; i++)
							{
								if (Convert.ToBoolean(dgvAcc.Rows[i].Cells["cChose"].Value))
								{
									text = text + method_1(i, "cUid") + "|" + method_1(i, "cPassword") + "|" + method_1(i, "cToken") + "|" + method_1(i, "cCookies") + "|" + method_1(i, "cEmail") + "|" + method_1(i, "cPassMail") + "|" + method_1(i, "cFa2") + "\r\n";
								}
							}
						}
						else if (!(string_21 == "all"))
						{
						}
						break;
				}
				Clipboard.SetText(text.TrimEnd('\r', '\n'));
			}
			catch
			{
			}
		}

		private void uidPassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("uid|pass");
		}

		private void uidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("uid|pass|token|cookie");
		}

		private void method_70(object sender, EventArgs e)
		{
		}

		private void method_71(object sender, EventArgs e)
		{
		}

		private string method_72(int int_41)
		{
			string text;
			do
			{
				text = "";
				text = method_53().Trim();
				int num = 10 - text.Length;
				if (int_41 == 209)
				{
					num--;
				}
				if (num > 0)
				{
					for (int i = 0; i < num; i++)
					{
						text += random_0.Next(0, 9);
					}
				}
				switch (int_41)
				{
					case 0:
						text = "+93" + text;
						break;
					case 1:
						text = "+355" + text;
						break;
					case 2:
						text = "+213" + text;
						break;
					case 3:
						text = "+684" + text;
						break;
					case 4:
						text = "+376" + text;
						break;
					case 5:
						text = "+244" + text;
						break;
					case 6:
						text = "+1264" + text;
						break;
					case 7:
						text = "+1268" + text;
						break;
					case 8:
						text = "+54" + text;
						break;
					case 9:
						text = "+374" + text;
						break;
					case 10:
						text = "+297" + text;
						break;
					case 11:
						text = "+61" + text;
						break;
					case 12:
						text = "+43" + text;
						break;
					case 13:
						text = "+994" + text;
						break;
					case 14:
						text = "+1242" + text;
						break;
					case 15:
						text = "+973" + text;
						break;
					case 16:
						text = "+880" + text;
						break;
					case 17:
						text = "+1246" + text;
						break;
					case 18:
						text = "+375" + text;
						break;
					case 19:
						text = "+32" + text;
						break;
					case 20:
						text = "+501" + text;
						break;
					case 21:
						text = "+229" + text;
						break;
					case 22:
						text = "+1441" + text;
						break;
					case 23:
						text = "+975" + text;
						break;
					case 24:
						text = "+591" + text;
						break;
					case 25:
						text = "+387" + text;
						break;
					case 26:
						text = "+267" + text;
						break;
					case 27:
						text = "+55" + text;
						break;
					case 28:
						text = "+673" + text;
						break;
					case 29:
						text = "+359" + text;
						break;
					case 30:
						text = "+226" + text;
						break;
					case 31:
						text = "+257" + text;
						break;
					case 32:
						text = "+855" + text;
						break;
					case 33:
						text = "+237" + text;
						break;
					case 34:
						text = "+1" + text;
						break;
					case 35:
						text = "+238" + text;
						break;
					case 36:
						text = "+1345" + text;
						break;
					case 37:
						text = "+236" + text;
						break;
					case 38:
						text = "+235" + text;
						break;
					case 39:
						text = "+246" + text;
						break;
					case 40:
						text = "+56" + text;
						break;
					case 41:
						text = "+86" + text;
						break;
					case 42:
						text = "+57" + text;
						break;
					case 43:
						text = "+269" + text;
						break;
					case 44:
						text = "+242" + text;
						break;
					case 45:
						text = "+243" + text;
						break;
					case 46:
						text = "+682" + text;
						break;
					case 47:
						text = "+506" + text;
						break;
					case 48:
						text = "+225" + text;
						break;
					case 49:
						text = "+385" + text;
						break;
					case 50:
						text = "+53" + text;
						break;
					case 51:
						text = "+420" + text;
						break;
					case 52:
						text = "+45" + text;
						break;
					case 53:
						text = "+253" + text;
						break;
					case 54:
						text = "+1767" + text;
						break;
					case 55:
						text = "+357" + text;
						break;
					case 56:
						text = "+593" + text;
						break;
					case 57:
						text = "+20" + text;
						break;
					case 58:
						text = "+503" + text;
						break;
					case 59:
						text = "+240" + text;
						break;
					case 60:
						text = "+372" + text;
						break;
					case 61:
						text = "+251" + text;
						break;
					case 62:
						text = "+298" + text;
						break;
					case 63:
						text = "+500" + text;
						break;
					case 64:
						text = "+679" + text;
						break;
					case 65:
						text = "+358" + text;
						break;
					case 66:
						text = "+33" + text;
						break;
					case 67:
						text = "+596" + text;
						break;
					case 68:
						text = "+594" + text;
						break;
					case 69:
						text = "+689" + text;
						break;
					case 70:
						text = "+241" + text;
						break;
					case 71:
						text = "+220" + text;
						break;
					case 72:
						text = "+995" + text;
						break;
					case 73:
						text = "+49" + text;
						break;
					case 74:
						text = "+233" + text;
						break;
					case 75:
						text = "+350" + text;
						break;
					case 76:
						text = "+30" + text;
						break;
					case 77:
						text = "+299" + text;
						break;
					case 78:
						text = "+1473" + text;
						break;
					case 79:
						text = "+590" + text;
						break;
					case 80:
						text = "+1671" + text;
						break;
					case 81:
						text = "+502" + text;
						break;
					case 82:
						text = "+224" + text;
						break;
					case 83:
						text = "+245" + text;
						break;
					case 84:
						text = "+592" + text;
						break;
					case 85:
						text = "+509" + text;
						break;
					case 86:
						text = "+504" + text;
						break;
					case 87:
						text = "+852" + text;
						break;
					case 88:
						text = "+36" + text;
						break;
					case 89:
						text = "+354" + text;
						break;
					case 90:
						text = "+91" + text;
						break;
					case 91:
						text = "+62" + text;
						break;
					case 92:
						text = "+98" + text;
						break;
					case 93:
						text = "+964" + text;
						break;
					case 94:
						text = "+353" + text;
						break;
					case 95:
						text = "+972" + text;
						break;
					case 96:
						text = "+39" + text;
						break;
					case 97:
						text = "+225" + text;
						break;
					case 98:
						text = "+1876" + text;
						break;
					case 99:
						text = "+81" + text;
						break;
					case 100:
						text = "+962" + text;
						break;
					case 101:
						text = "+254" + text;
						break;
					case 102:
						text = "+850" + text;
						break;
					case 103:
						text = "+82" + text;
						break;
					case 104:
						text = "+965" + text;
						break;
					case 105:
						text = "+996" + text;
						break;
					case 106:
						text = "+260" + text;
						break;
					case 107:
						text = "+263" + text;
						break;
					case 108:
						text = "+856" + text;
						break;
					case 109:
						text = "+371" + text;
						break;
					case 110:
						text = "+961" + text;
						break;
					case 111:
						text = "+266" + text;
						break;
					case 112:
						text = "+231" + text;
						break;
					case 113:
						text = "+218" + text;
						break;
					case 114:
						text = "+423" + text;
						break;
					case 115:
						text = "+370" + text;
						break;
					case 116:
						text = "+352" + text;
						break;
					case 117:
						text = "+853" + text;
						break;
					case 118:
						text = "+389" + text;
						break;
					case 119:
						text = "+261" + text;
						break;
					case 120:
						text = "+265" + text;
						break;
					case 121:
						text = "+60" + text;
						break;
					case 122:
						text = "+960" + text;
						break;
					case 123:
						text = "+223" + text;
						break;
					case 124:
						text = "+356" + text;
						break;
					case 125:
						text = "+692" + text;
						break;
					case 126:
						text = "+596" + text;
						break;
					case 127:
						text = "+222" + text;
						break;
					case 128:
						text = "+230" + text;
						break;
					case 129:
						text = "+52" + text;
						break;
					case 130:
						text = "+808" + text;
						break;
					case 131:
						text = "+373" + text;
						break;
					case 132:
						text = "+377" + text;
						break;
					case 133:
						text = "+976" + text;
						break;
					case 134:
						text = "+381" + text;
						break;
					case 135:
						text = "+1664" + text;
						break;
					case 136:
						text = "+212" + text;
						break;
					case 137:
						text = "+258" + text;
						break;
					case 138:
						text = "+95" + text;
						break;
					case 139:
						text = "+264" + text;
						break;
					case 140:
						text = "+977" + text;
						break;
					case 141:
						text = "+31" + text;
						break;
					case 142:
						text = "+599" + text;
						break;
					case 143:
						text = "+687" + text;
						break;
					case 144:
						text = "+64" + text;
						break;
					case 145:
						text = "+505" + text;
						break;
					case 146:
						text = "+227" + text;
						break;
					case 147:
						text = "+234" + text;
						break;
					case 148:
						text = "+1670" + text;
						break;
					case 149:
						text = "+47" + text;
						break;
					case 150:
						text = "+968" + text;
						break;
					case 151:
						text = "+92" + text;
						break;
					case 152:
						text = "+680" + text;
						break;
					case 153:
						text = "+507" + text;
						break;
					case 154:
						text = "+675" + text;
						break;
					case 155:
						text = "+595" + text;
						break;
					case 156:
						text = "+51" + text;
						break;
					case 157:
						text = "+63" + text;
						break;
					case 158:
						text = "+48" + text;
						break;
					case 159:
						text = "+351" + text;
						break;
					case 160:
						text = "+974" + text;
						break;
					case 161:
						text = "+262" + text;
						break;
					case 162:
						text = "+40" + text;
						break;
					case 163:
						text = "+7" + text;
						break;
					case 164:
						text = "+250" + text;
						break;
					case 165:
						text = "+378" + text;
						break;
					case 166:
						text = "+239" + text;
						break;
					case 167:
						text = "+966" + text;
						break;
					case 168:
						text = "+221" + text;
						break;
					case 169:
						text = "+248" + text;
						break;
					case 170:
						text = "+232" + text;
						break;
					case 171:
						text = "+65" + text;
						break;
					case 172:
						text = "+421" + text;
						break;
					case 173:
						text = "+386" + text;
						break;
					case 174:
						text = "+677" + text;
						break;
					case 175:
						text = "+252" + text;
						break;
					case 176:
						text = "+27" + text;
						break;
					case 177:
						text = "+34" + text;
						break;
					case 178:
						text = "+94" + text;
						break;
					case 179:
						text = "+1869" + text;
						break;
					case 180:
						text = "+1758" + text;
						break;
					case 181:
						text = "+1784" + text;
						break;
					case 182:
						text = "+249" + text;
						break;
					case 183:
						text = "+597" + text;
						break;
					case 184:
						text = "+268" + text;
						break;
					case 185:
						text = "+46" + text;
						break;
					case 186:
						text = "+41" + text;
						break;
					case 187:
						text = "+963" + text;
						break;
					case 188:
						text = "+886" + text;
						break;
					case 189:
						text = "+992" + text;
						break;
					case 190:
						text = "+255" + text;
						break;
					case 191:
						text = "+66" + text;
						break;
					case 192:
						text = "+228" + text;
						break;
					case 193:
						text = "+676" + text;
						break;
					case 194:
						text = "+1868" + text;
						break;
					case 195:
						text = "+216" + text;
						break;
					case 196:
						text = "+90" + text;
						break;
					case 197:
						text = "+993" + text;
						break;
					case 198:
						text = "+1649" + text;
						break;
					case 199:
						text = "+688" + text;
						break;
					case 200:
						text = "+256" + text;
						break;
					case 201:
						text = "+380" + text;
						break;
					case 202:
						text = "+971" + text;
						break;
					case 203:
						text = "+44" + text;
						break;
					case 204:
						text = "+1" + text;
						break;
					case 205:
						text = "+598" + text;
						break;
					case 206:
						text = "+998" + text;
						break;
					case 207:
						text = "+678" + text;
						break;
					case 208:
						text = "+58" + text;
						break;
					case 209:
						text = "+84" + text;
						break;
					case 210:
						text = "+1284" + text;
						break;
					case 211:
						text = "+1340" + text;
						break;
					case 212:
						text = "+685" + text;
						break;
					case 213:
						text = "+967" + text;
						break;
					case 214:
						text = "+381" + text;
						break;
					case 215:
						text = "+243" + text;
						break;
					case 216:
						text = "+381" + text;
						break;
				}
				if (text.Trim().Length > 13)
				{
					text = text.Remove(text.Trim().Length - 1, 1);
				}
			}
			while (text.Trim().Length < 10);
			return text;
		}

		private string method_73()
		{
			string text = "";
			List<string> list = new List<string>(new string[10] { "thejoker5.com", "greencafe24.com", "crepeau12.com", "coffeetimer24.com", "popcornfarm7.com", "cashflow35.com", "bestparadize.com", "the23app.com", "blondemorkin.com", "kobrandly.com" });
			return list[random_0.Next(0, list.Count)].ToString();
		}

		private string method_74()
		{
			string text = "205|251|659|256|334|907|520|928|480|602|623|501|479|870|341|442|628|657|669|747|752|764|951|209|559|408|831|510|213|310|424|323|562|707|369|627|530|714|949|626|909|916|760|619|858|935|818|415|925|661|805|650|211|720|970|303|719|203|475|860|959|302|411|202|911|239|386|689|754|941|954|561|407|727|352|904|850|786|863|305|321|813|470|478|770|678|404|706|912|229|710|671|808|208|312|773|630|847|708|815|224|331|464|872|217|618|309|260|317|219|765|812|563|641|515|319|712|876|620|785|913|316|270|859|606|502|225|337|985|504|318|207|227|240|443|667|410|301|339|351|774|781|857|978|508|617|413|231|269|989|734|517|313|810|248|278|586|679|947|906|616|320|612|763|952|218|507|651|228|601|557|573|636|660|975|314|816|417|664|406|402|308|775|702|506|603|551|848|862|732|908|201|973|609|856|505|575|585|845|917|516|212|646|315|518|347|718|607|914|631|716|252|336|828|910|980|984|919|704|701|283|380|567|216|614|937|330|234|440|419|740|513|580|918|405|541|971|445|610|835|878|484|717|570|412|215|267|814|724|787|939|401|306|803|843|864|605|731|865|931|423|615|901|325|361|430|432|469|682|737|979|214|972|254|940|713|281|832|956|817|806|903|210|830|409|936|512|915|340|385|435|801|802|276|434|540|571|757|703|804|509|206|425|253|360|564|304|262|920|414|715|608|307|867|866|456|011|880|881|882|500|611|311|200|300|400|700|711|811|800|877|888";
			string[] array = text.Split('|');
			return array[random_0.Next(0, array.Length - 1)];
		}

		private string method_75(string string_21)
		{
			string_21 = string_21.ToLower().Replace(" ", "");
			string_21 = Common.smethod_74(string_21);
			return string_21;
		}

		private string method_76(string string_21, string string_22, int int_41)
		{
			string string_23 = string_21 + string_22;
			string_23 = method_75(string_23);
			string_23 += random_0.Next(0, 1000);
			string_23 = string_23.ToLower();
			switch (int_41)
			{
				case 0:
					string_23 += "@gmail.com";
					break;
				case 1:
					string_23 += "@yahoo.com";
					break;
				case 2:
					string_23 += "@hotmail.com";
					break;
			}
			return string_23;
		}

		private void ckCheckIP_CheckedChanged(object sender, EventArgs e)
		{
			txtPassFb.Enabled = !chkRandomPass.Checked;
		}

		private void method_77(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				try
				{
					dgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dgvAcc.CurrentRow.Cells["cChose"].Value);
					method_67();
				}
				catch
				{
				}
			}
		}

		private void method_78(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void method_79(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void method_80(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				dgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dgvAcc.CurrentRow.Cells["cChose"].Value);
				method_67();
			}
			catch
			{
			}
		}

		private void uidPass2FAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("uid|pass|2fa");
		}

		private void btnCheckAPIAny_Click(object sender, EventArgs e)
		{
			string text = txtAPIAnyCat.Text.ToString();
			string text2 = Common.smethod_30(text);
			if (text2 == "")
			{
				MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Số tiền còn dư: " + text2 + " $", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnNhapanh_Click(object sender, EventArgs e)
		{
			try
			{
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				folderBrowserDialog.ShowNewFolderButton = true;
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					txtLinkAvartar.Text = folderBrowserDialog.SelectedPath;
					_ = folderBrowserDialog.RootFolder;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public string method_81()
		{
			string result = "";
			try
			{
				string path = txtLinkLD.Text + "\\vms\\config\\leidian0.config";
				string text = txtLinkLD.Text + "\\vms\\config\\leidian1.config";
				if (File.Exists(text))
				{
					path = text;
				}
				JObject jObject = JObject.Parse(File.ReadAllText(path));
				result = jObject["statusSettings.sharedPictures"]!.ToString();
			}
			catch
			{
			}
			return result;
		}

		private void liveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_82(sender, e);
		}

		private void method_82(object sender, EventArgs e)
		{
			method_83("cInfo", (sender as ToolStripMenuItem).Text);
		}

		private void method_83(string string_21, string string_22)
		{
			for (int i = 0; i < dgvAcc.RowCount; i++)
			{
				dgvAcc.Rows[i].Cells["cChose"].Value = method_1(i, string_21).Contains(string_22);
			}
			method_67();
		}

		private void dieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_82(sender, e);
		}

		private void checkpointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_82(sender, e);
		}

		private string method_84(Random random_1, int int_41)
		{
			string text = "";
			string text2 = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			for (int i = 0; i < int_41; i++)
			{
				text += text2[random_1.Next(0, text2.Length)];
			}
			return text;
		}

		private bool method_85(int int_41)
		{
			bool result = false;
			Class7 @class = new Class7();
			@class.Position = Common.smethod_2(int_41);
			@class.Size = new Point(int_22, int_23);
			string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.82 Safari/537.36";
			try
			{
				@class.HideBrowser = chkHideBrowser.Checked;
				@class.UserAgent = userAgent;
				@class.method_0();
			}
			catch (Exception)
			{
			}
			method_52("Đang đăng ký tài khoản hotmail...", "status", int_41, 1, dgvAcc);
			@class.method_3("https://signup.live.com/signup");
			@class.method_31(5.0);
			string string_ = method_6();
			string string_2 = method_7();
			string text = method_76(string_2, string_, 2);
			string string_3 = (bool_11 ? method_84(random_0, 15) : string_17);
			method_52(text, "email", int_41, 0, dgvAcc);
			method_52(string_3, "passMail", int_41, 0, dgvAcc);
			if (@class.method_16("[name=\"MemberName\"]", 60.0))
			{
				@class.method_12(4, "[name=\"MemberName\"]", text, 0.0);
			}
			@class.method_31(3.0);
			if (text.EndsWith("@hotmail.com"))
			{
				@class.method_32(1, "LiveDomainBoxList", "hotmail.com");
			}
			if (!@class.method_20(2, "MemberName"))
			{
				@class.method_6("document.querySelector('#iSignupAction').click()");
			}
			if (!@class.method_16("#PasswordInput", 10.0))
			{
				if (@class.method_16("#MemberName"))
				{
					method_52("Mail không thể đăng ký!", "status", int_41, 1, dgvAcc);
				}
				else
				{
					method_52("Không load được trang!", "status", int_41, 1, dgvAcc);
				}
			}
			else
			{
				@class.method_12(1, "PasswordInput", string_3, 0.0);
				@class.method_31(1.0);
				if (!@class.method_20(1, "PasswordInput"))
				{
					@class.method_6("document.querySelector('#iSignupAction').click()");
				}
				@class.method_31(1.0);
				if (@class.method_16("#LastName", 60.0))
				{
					@class.method_12(1, "LastName", method_12(), 0.1);
					method_51(0.5);
					@class.method_12(1, "FirstName", method_14(), 0.1);
					method_51(0.5);
				}
				if (!@class.method_20(1, "LastName"))
				{
					@class.method_6("document.querySelector('#iSignupAction').click()");
				}
				@class.method_31(1.0);
				if (@class.method_16("[name=\"BirthDay\"]", 60.0))
				{
					@class.method_32(2, "BirthDay", random_0.Next(1, 28).ToString());
				}
				if (@class.method_16("[name=\"BirthMonth\"]", 60.0))
				{
					@class.method_32(2, "BirthMonth", random_0.Next(1, 12).ToString());
				}
				if (@class.method_16("[name=\"BirthYear\"]", 60.0) && !@class.method_32(2, "BirthYear", random_0.Next(1970, 2000).ToString()))
				{
					@class.method_11(2, "BirthYear", random_0.Next(1970, 2000).ToString());
				}
				@class.method_31(1.0);
				@class.method_6("document.querySelector('#iSignupAction').click()");
				method_51(3.0);
				while (true)
				{
				IL_05e9:
					int num = @class.method_19(90.0, "#hipTemplateContainer>div:nth-child(3)>input", "#wlspispHipChallengeContainer>div:nth-child(2)>input", "#HipEnforcementForm");
					if (num != 1)
					{
						if (num == 2)
						{
							if (!method_86(@class, int_41, string_11)) // Getphone
							{
								break;
							}
							while (true)
							{
								num = @class.method_19(90.0, "#KmsiCheckboxField", "#hipTemplateContainer>div:nth-child(3)>input", "#uhfSkipToMain", "#o365header", "#HipEnforcementForm", "#idPageTitle");
								if (num != 1)
								{
									if (num == 3 || num == 4)
									{
										break;
									}
									if (num == 5)
									{
										while (true)
										{
											method_52("Đang giải funcaptcha...", "status", int_41, 1, dgvAcc);
											string text2 = Common.smethod_32(txtAPIAnyCat.Text.Trim(), "https://signup.live.com", "B7D8911C-5CC8-A9A3-35B0-554ACEE604DA");
											@class.chromeDriver_0.SwitchTo().Frame(0);
											@class.method_6("parent.postMessage(JSON.stringify({eventId: \"challenge-complete\",payload: {sessionToken: \"" + text2 + "\"}}), \"*\")");
											@class.method_31(1.0);
											switch (@class.method_19(30.0, "#KmsiCheckboxField", "#o365header", "#wlspispHipChallengeContainer>div:nth-child(2)>input", "#HipEnforcementForm"))
											{
												case 4:
													break;
												case 1:
													goto end_IL_0421;
												case 3:
													goto IL_0526;
												default:
													goto IL_05e9;
												case 2:
													goto end_IL_0593;
											}
											continue;
										end_IL_0421:
											break;
										}
										@class.method_7(1, "KmsiCheckboxField");
										@class.method_31(1.0);
										@class.method_7(1, "idSIButton9");
										@class.method_31(1.0);
										continue;
									}
									if (num != 6)
									{
										break;
									}
									method_52("Không load được trang!", "status", int_41, 1, dgvAcc);
									goto end_IL_05e9;
								}
								try
								{
									try
									{
										@class.method_7(1, "KmsiCheckboxField");
									}
									catch
									{
										@class.method_6("document.querySelector('#KmsiCheckboxField').click()");
									}
									@class.method_31(1.0);
									try
									{
										@class.method_7(1, "idSIButton9");
									}
									catch
									{
										@class.method_6("document.querySelector('#idSIButton9').click()");
									}
								}
								catch
								{
									break;
								}
								continue;
							IL_0526:
								if (!method_86(@class, int_41, string_11))
								{
									goto end_IL_05e9;
								}
								continue;
							end_IL_0593:
								break;
							}
						}
						else if (num == 3)
						{
							int num2;
							do
							{
								method_52("Đang giải funcaptcha...", "status", int_41, 1, dgvAcc);
								string text3 = Common.smethod_32(txtAPIAnyCat.Text.Trim(), "https://signup.live.com", "B7D8911C-5CC8-A9A3-35B0-554ACEE604DA");
								@class.chromeDriver_0.SwitchTo().Frame(0);
								@class.method_6("parent.postMessage(JSON.stringify({eventId: \"challenge-complete\",payload: {sessionToken: \"" + text3 + "\"}}), \"*\")");
								@class.method_31(1.0);
								num2 = @class.method_19(30.0, "#KmsiCheckboxField", "#o365header", "#wlspispHipChallengeContainer>div:nth-child(2)>input", "#HipEnforcementForm");
							}
							while (num2 == 4);
							if (num2 == 1)
							{
								@class.method_7(1, "KmsiCheckboxField");
								@class.method_31(1.0);
								@class.method_7(1, "idSIButton9");
								@class.method_31(1.0);
							}
							else if (num2 == 3 && !method_86(@class, int_41, string_11))
							{
								break;
							}
						}
					}
					if (bool_10)
					{
						@class.method_31(1.0);
						method_52("Đang tạo mailbox...", "status", int_41, 1, dgvAcc);
						@class.method_31(1.0);
						@class.method_3("https://outlook.live.com/mail/0");
						@class.method_31(5.0);
						int num3 = @class.method_19(90.0, "#owaBranding_container", ".ms-Modal-scrollableContent");
						if (num3 == 1 || num3 == 2)
						{
							method_52("Tạo mailbox thành công!", "status", int_41, 1, dgvAcc);
						}
					}
					method_52("Đăng ký Mail thành công!", "status", int_41, 1, dgvAcc);
					result = true;
					break;
					continue;
				end_IL_05e9:
					break;
				}
			}
			@class.method_23();
			return result;
		}

		private bool method_86(Class7 class7_0, int int_41, string string_21)
		{
			bool result = false;
			string text = "";
			string text2 = "";
			string text3 = "";
			int num = 5;
			try
			{
				method_52("Đang xác minh sđt...", "status", int_41, 1, dgvAcc);
				class7_0.method_6("document.querySelector(\"#wlspispHipChallengeContainer > div:nth-child(1) > select\").value=\"VN\"");
				method_52("Đang lâ\u0301y sđt...", "status", int_41, 0, dgvAcc);
				if (string_21 == "")
				{
					method_52("Không có api, không thể lấy sđt!", "status", int_41, 0, dgvAcc);
				}
				else
				{
					while (true) // Re-get phone
					{
						string text4 = string.Empty;
						if (!(string_12.Substring(2, 1) == "0"))
						{
							if (string_12.Substring(2, 1) == "1")
							{
								text4 = Common.smethod_58(string_11);
							}
							else if (string_12.Substring(2, 1) == "2")
							{
								text4 = Common.smethod_59(string_11);
							}
							else if (string_12.Substring(2, 1) == "4")
							{
								text4 = Common.smethod_60(string_11);
							} // Get lai phone
						}
						else
						{
							text4 = Common.smethod_42(string_11, "hotmail");
						}
						text = text4.Split('|')[0];
						text2 = text4.Split('|')[1];
						if (text2 == "")
						{
							method_52("Không lâ\u0301y đươ\u0323c sđt! Đang lấy lại...", "status", int_41, 0, dgvAcc);
							continue;
						}
						if (string_12.Substring(2, 1) == "0" || string_12.Substring(2, 1) == "1" || string_12.Substring(2, 1) == "11" || string_12.Substring(2, 1) == "5" || string_12.Substring(2, 1) == "8")
						{
							text2 = "+84" + text2;
						}
						else if (string_12.Substring(2, 1) == "2" || string_12.Substring(2, 1) == "4"  || string_12.Substring(2, 1) == "6" || string_12.Substring(2, 1) == "7"  || string_12.Substring(2, 1) == "9"  || string_12.Substring(2, 1) == "10")
						{
							text2 = "+84" + text2; // truoc la +1
						}
						if (class7_0.method_16("#wlspispHipChallengeContainer>div:nth-child(2)>input", 10.0))
						{
							class7_0.method_14(4, "#wlspispHipChallengeContainer>div:nth-child(2)>input");
							class7_0.method_11(4, "#wlspispHipChallengeContainer>div:nth-child(2)>input", text2);
						}
						class7_0.method_31(3.0);
						class7_0.method_6("document.querySelector('#wlspispHipControlButtonsContainer>a').click()");
						class7_0.method_31(3.0);
						if (!Convert.ToBoolean(class7_0.method_6("return document.querySelector('#iSignupAction').disabled+''").ToString()))
						{
							break;
						}
						if (num >= 0)
						{
							method_52("Sđt không dùng được! Đang lấy số khác...", "status", int_41, 0, dgvAcc);
							num--;
							continue;
						}
						return result;
					}
					method_52("Đơ\u0323i lâ\u0301y ma\u0303 code...", "status", int_41, 0, dgvAcc);
					if (string_12.Substring(2, 1) == "0")
					{
						text3 = Common.smethod_47(string_11,ref text, int_14);
					}
                    else if (string_12.Substring(2, 1) == "1")
                    {
                        text3 = Common.smethod_61(string_11, text, int_14);
                    }
                    else if (string_12.Substring(2, 1) == "2")
					{
						text3 = Common.smethod_26(string_11, text, int_14);
					}
					else if (string_12.Substring(2, 1) == "4")
					{
						text3 = Common.smethod_27(string_11, text, int_14);
					} //Get lai code

					if (text3 == "")
					{
						method_52("Không lâ\u0301y đươ\u0323c ma\u0303 code!", "status", int_41, 0, dgvAcc);
					}
					else
					{
						if (class7_0.method_16("#wlspispHipSolutionContainer>div>input", 10.0))
						{
							class7_0.method_11(4, "#wlspispHipSolutionContainer>div>input", text3);
						}
						class7_0.method_31(3.0);
						class7_0.method_6("document.querySelector('#iSignupAction').click()");
						class7_0.method_31(3.0);
						result = true;
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		private void method_87(object sender, EventArgs e)
		{
		}

		private bool method_88(Device device_0, string string_21)
		{
			bool result = false;
			try
			{
				device_0.method_86("com.cell47.College_Proxy");
				int i = 0;
				int num = 0;
				num = string_21.Split(':').Length;
				for (; i < 5; i++)
				{
					if (device_0.method_87() == "com.cell47.College_Proxy/com.cell47.College_Proxy.ui.MainActivity")
					{
						break;
					}
					device_0.method_121(1.0);
				}
				if (device_0.method_75(30.0, "please wait"))
				{
					string text = device_0.method_93();
					if (device_0.method_82("stop proxy service", text))
					{
						device_0.method_99("stop proxy service", text);
						device_0.method_121(1.0);
						text = device_0.method_93();
					}
					string text2 = device_0.method_2();
					List<string> list = new List<string> { "125,90", "125,125", "125,160", "125,195" };
					for (int j = 0; j < num; j++)
					{
						device_0.method_7(Convert.ToInt32(list[j].Split(',')[0]), Convert.ToInt32(list[j].Split(',')[1]));
						device_0.method_121(1.0);
						device_0.method_102(string_21.Split(':')[j].ToString());
						device_0.method_121(1.0);
					}
					device_0.method_99("start proxy service", text);
					string text3 = "127.0.0.1:" + (device_0.int_0 * 2 + 5555);
					for (int k = 0; k < 5; k++)
					{
						text = device_0.method_93();
						int num2 = device_0.method_84(text, 0.0, "connection request", "stop proxy service", "yêu cầu kết nối");
						if (num2 == 0)
						{
							Class2.smethod_35(text3);
							method_89();
							continue;
						}
						if (num2 == 1 || num2 == 3)
						{
							device_0.method_99("ok", text);
							device_0.method_121(1.0);
						}
						Class2.smethod_35(text3);
						method_89();
						string text4 = "";
						for (int l = 0; l < 2; l++)
						{
							text4 = device_0.method_2();
							if (text4 != "" && !text4.Contains("error"))
							{
								break;
							}
							Thread.Sleep(1000);
						}
						return text2 != text4 && !text4.Contains("error") && text4 != "";
					}
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Error_ConnectProxy");
			}
			return result;
		}

		public void method_89()
		{
			for (int i = 0; i < list_4.Count; i++)
			{
				string text = Class2.smethod_36(list_4[i].int_0);
				if (!string.IsNullOrEmpty(text))
				{
					list_4[i].DeviceId = text;
				}
			}
		}

		private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("mail|passmail");
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
		}

		private void method_90(object sender, EventArgs e)
		{
		}

		private void method_91(object sender, EventArgs e)
		{
			plAddfriend.Enabled = chkAddFUID.Checked;
		}

		private void chkWStory_CheckedChanged(object sender, EventArgs e)
		{
			gbCamxuc.Enabled = chkWStory.Checked;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void method_92(object sender, EventArgs e)
		{
		}

		private void rdNoChangeIP_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void timer_1_Tick(object sender, EventArgs e)
		{
		}

		private void frmMain_Paint(object sender, PaintEventArgs e)
		{
		}

		private void btnCheckAPIMinProxy_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = txtApiKeyMinProxy.Lines.ToList();
				list2 = Common.smethod_77(list2);
				foreach (string item in list2)
				{
					if (Class51.smethod_0(item))
					{
						list.Add(item);
					}
				}
				txtApiKeyMinProxy.Lines = list.ToArray();
				if (list.Count > 0)
				{
					MessageBox.Show($"Đang có {list.Count} proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Không có proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không có proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void rbMale_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void rdHMA_CheckedChanged(object sender, EventArgs e)
		{
			method_93();
		}

		private void method_93()
		{
			plCheckDoiIP.Enabled = rdChangeIPDcom.Checked || rdHMA.Checked;
			RadioButton radioButton = rdProxy;
			RadioButton radioButton2 = rdIPPortUserPass;
			RadioButton radioButton3 = rdTinsoftProxy;
			bool flag2 = (rdMinProxy.Checked = !rdChangeIPDcom.Checked && !rdHMA.Checked);
			bool flag4 = (radioButton3.Checked = flag2);
			bool @checked = (radioButton2.Checked = flag4);
			radioButton.Checked = @checked;
		}

		private void rdChangeIPDcom_CheckedChanged(object sender, EventArgs e)
		{
			plChangeIPDcom.Enabled = rdChangeIPDcom.Checked;
			method_93();
		}

		private void method_94(object sender, EventArgs e)
		{
		}

		private void method_95(object sender, EventArgs e)
		{
			method_21(bool_18: false);
			for (int i = 0; i < 2; i++)
			{
				frmViewLD.frmViewLD_0.method_0(i + 1);
			}
		}

		private void btnTestChangeIP_Click(object sender, EventArgs e)
		{
			Class48 @class = new Class48("setting.ini");
			int num = Convert.ToInt32(@class.method_1("typeChangeIp"));
			if (num == 1 || num == 4)
			{
				if (Common.smethod_56(num, 0, @class.method_1("txtProfileNameDcom").ToString(), ""))
				{
					stIPCur.Text = method_54();
					MessageBox.Show("Đổi IP thành công. IP mới: " + stIPCur.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Đổi IP thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		private void method_96(object sender, EventArgs e)
		{
		}

		private void btnNhapHotmail_Click(object sender, EventArgs e)
		{
			Process.Start("hotmail.txt");
		}

		private void allToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("proxy");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://tinsoftproxy.com/");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://minproxy.vn/");
		}
		private void linkLabelprxv6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://proxyv6.net/dashboard");
		}
		private void method_97(object sender, EventArgs e)
		{
		}

		private void btnAutoConfig_Click(object sender, EventArgs e)
		{
			frmAutoFunction frmAutoFunction = new frmAutoFunction();
			frmAutoFunction.ShowDialog();
		}

		private void method_98(object sender, EventArgs e)
		{
		}

		private void btnMaximum_Click(object sender, EventArgs e)
		{
			method_99();
		}

		private void method_99()
		{
			base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			else if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			else if (base.WindowState == FormWindowState.Maximized)
			{
				base.WindowState = FormWindowState.Normal;
			}
		}

		private void rdNormal_CheckedChanged(object sender, EventArgs e)
		{
			rdSwap.Checked = !rdNormal.Checked;
		}

		private void rdSwap_CheckedChanged(object sender, EventArgs e)
		{
			rdNormal.Checked = !rdSwap.Checked;
		}

		private void rdProxy_CheckedChanged(object sender, EventArgs e)
		{
			tabProxy.Enabled = rdProxy.Checked;
		}

		private void rdTinsoftProxy_CheckedChanged(object sender, EventArgs e)
		{
			if (rdTinsoftProxy.Checked)
			{
				RadioButton radioButton = rdMinProxy;
				RadioButton radioButton2 = rdIPPortUserPass;
				RadioButton radioButton3 = rbXproxy;
				RadioButton radioButton4 = rbTMProxy;
				RadioButton radioButton5 = rdProxyOrbit;
				RadioButton radioButton6 = rbProxyv6 ;
				radioButton6.Checked = false;
				rbProxyShoplike.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			plTinsoftProxy.Enabled = rdTinsoftProxy.Checked;
		}

		private void rdMinProxy_CheckedChanged(object sender, EventArgs e)
		{
			if (rdMinProxy.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdIPPortUserPass;
				RadioButton radioButton3 = rbXproxy;
				RadioButton radioButton4 = rbTMProxy;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rbProxyShoplike.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			pnlAPIMinProxy.Enabled = rdMinProxy.Checked;
		}

		private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
		{
			List<string> list = txtApiKeyMinProxy.Lines.ToList();
			list = Common.smethod_77(list);
			lblAPIMinKey.Text = $"Nhập API KEY ({list.Count.ToString()}):";
		}

		private void rdIPPortUserPass_CheckedChanged(object sender, EventArgs e)
		{
			if (rdIPPortUserPass.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rbXproxy;
				RadioButton radioButton4 = rbTMProxy;
				RadioButton radioButton5 = rbProxyShoplike;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rdProxyOrbit.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			pnlIpPort.Enabled = rdIPPortUserPass.Checked;
		}

		private void txtListProxyIp_TextChanged(object sender, EventArgs e)
		{
			List<string> list = txtListProxyIp.Lines.ToList();
			list = Common.smethod_77(list);
			lblListProxyIP.Text = $"Danh sa\u0301ch Proxy ({list.Count.ToString()}):";
		}

		private void rdIPStatic_CheckedChanged(object sender, EventArgs e)
		{
			rdIPDong.Checked = !rdIPStatic.Checked;
		}

		private void rdIPDong_CheckedChanged(object sender, EventArgs e)
		{
			rdIPStatic.Checked = !rdIPDong.Checked;
		}

		private void rbXproxy_CheckedChanged(object sender, EventArgs e)
		{
			if (rbXproxy.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rdIPPortUserPass;
				RadioButton radioButton4 = rbTMProxy;
				RadioButton radioButton5 = rbProxyShoplike;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rdProxyOrbit.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			plXproxy.Enabled = rbXproxy.Checked;
		}

		private void txtListXProxy_TextChanged(object sender, EventArgs e)
		{
			List<string> list = txtListXProxy.Lines.ToList();
			list = Common.smethod_77(list);
			lblCountXproxy.Text = $"Nhập proxy ({list.Count.ToString()}):";
		}

		private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
		{
			if (rbTMProxy.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rdIPPortUserPass;
				RadioButton radioButton4 = rbXproxy;
				RadioButton radioButton5 = rbProxyShoplike;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rdProxyOrbit.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			plTMProxy.Enabled = rbTMProxy.Checked;
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://tmproxy.com/");
		}

		private void method_100(object sender, EventArgs e)
		{
		}

		private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = txtApiKeyTMProxy.Lines.ToList();
				list = Common.smethod_77(list);
				lblCountTmProxy.Text = $"Nhập API KEY ({list.Count.ToString()}):";
			}
			catch
			{
			}
		}

		private void lnkTempMailIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://temp-mail.io/");
		}

		private void rdHotMailReg_CheckedChanged(object sender, EventArgs e)
		{
			if (rdHotMailReg.Checked)
			{
				plHotmailReg.Enabled = rdHotMailReg.Checked;
				rdTempMailIO.Checked = false;
				rdMailTM.Checked = false;
			}
		}

		private void rdHotMailRegisted_CheckedChanged(object sender, EventArgs e)
		{
			if (rdHotMailRegisted.Checked)
			{
				rdTempMailIO.Checked = false;
				rdMailTM.Checked = false;
				btnNhapHotmail.Enabled = true;
			}
		}

		private void rdTempMailIO_CheckedChanged(object sender, EventArgs e)
		{
			if (rdTempMailIO.Checked)
			{
				rdHotMailReg.Checked = false;
				rdHotMailRegisted.Checked = false;
				rdMailTM.Checked = false;
			}
		}

		private void cbbPhoneCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbPhoneCountry.SelectedIndex == 0)
			{
				method_56(0);
			}
			else if (cbbPhoneCountry.SelectedIndex == 1)
			{
				method_56(1);
			}
		}

		private void cbbPrePhone_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] array = cbbPrePhone.SelectedItem.ToString().Split('[', ']', ',');
			txtListDauso.Text += array[2];
			txtListDauso.Text += ",";
		}

		private void cbModeRunReg_SelectedIndexChanged(object sender, EventArgs e)
		{
			pnlSoLanReg.Enabled = ((cbModeRunReg.SelectedIndex == 0) ? true : false);
		}

		private void btnOutpuData_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "output\\facebook\\";
				if (Directory.Exists(text))
				{
					Process.Start("explorer.exe", text);
				}
			}
			catch
			{
				MessageBox.Show("Không tìm thấy folder data", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			method_69("phone");
		}

		private void lnkShopLike_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://proxy.shoplike.vn/");
		}

		private void rbProxyShoplike_CheckedChanged(object sender, EventArgs e)
		{
			if (rbProxyShoplike.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rdIPPortUserPass;
				RadioButton radioButton4 = rbXproxy;
				RadioButton radioButton5 = rbTMProxy;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rdProxyOrbit.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			plProxyShopLike.Enabled = rbProxyShoplike.Checked;
		}

		private void txtAPIKeyShoplike_TextChanged(object sender, EventArgs e)
		{
			List<string> list = txtAPIKeyShoplike.Lines.ToList();
			list = Common.smethod_77(list);
			lblAPIKeyShopLike.Text = $"Nhập API KEY ({list.Count.ToString()}):";
		}

		private void method_101(object sender, EventArgs e)
		{
		}

		private void btnCheckTMProxy_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = txtApiKeyTMProxy.Lines.ToList();
			list2 = Common.smethod_77(list2);
			foreach (string item in list2)
			{
				if (Class68.smethod_0(item))
				{
					list.Add(item);
				}
			}
			txtApiKeyTMProxy.Lines = list.ToArray();
			if (list.Count > 0)
			{
				MessageBox.Show($"Đang có {list.Count} proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Không có proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void method_102(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://mail.tm/vi/");
		}

		private void method_103(object sender, EventArgs e)
		{
		}

		private void rdMailTM_CheckedChanged(object sender, EventArgs e)
		{
			if (rdMailTM.Checked)
			{
				rdHotMailReg.Checked = false;
				rdHotMailRegisted.Checked = false;
				rdTempMailIO.Checked = false;
			}
		}

		private void btnManagerLD_Click(object sender, EventArgs e)
		{
			if (txtLinkLD.Text == "" || !Directory.Exists(txtLinkLD.Text))
			{
				MessageBox.Show("Đường dẫn LDPlayer không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Task task = new Task(delegate
			{
				Process.Start(txtLinkLD.Text + "\\dnmultiplayer.exe");
			});
			task.Start();
		}

		private void btnRepairLD_Click(object sender, EventArgs e)
		{
			if (txtLinkLD.Text == "" || !Directory.Exists(txtLinkLD.Text))
			{
				MessageBox.Show("Đường dẫn LDPlayer không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Task task = new Task(delegate
			{
				Process.Start(txtLinkLD.Text + "\\dnrepairer.exe");
				method_51(10.0);
				MessageBox.Show("Sửa chữa LDPlayer thành công", "Thông báo");
			});
			task.Start();
		}

		private void btnCreateLDPLayer_Click(object sender, EventArgs e)
		{
			if (txtLinkLD.Text == "" || !Directory.Exists(txtLinkLD.Text))
			{
				MessageBox.Show("Đường dẫn LDPlayer không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string value = "";
			if (Common.smethod_11("Thông báo", "Nhập số lượng LDPlayer muốn tạo", ref value) != DialogResult.OK)
			{
				return;
			}
			int int_0 = Convert.ToInt32(value);
			new Task(delegate
			{
				int i;
				for (i = 0; i < int_0; i++)
				{
					Class2.smethod_24("add", 0, bool_0: true, txtLinkLD.Text);
				}
				MessageBox.Show("Tạo thành công " + i + " LDPlayer");
			}).Start();
		}

		private void btnTurnOffAllLD_Click(object sender, EventArgs e)
		{
			if (txtLinkLD.Text == "" || !Directory.Exists(txtLinkLD.Text))
			{
				MessageBox.Show("Đường dẫn LDPlayer không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Class2.smethod_24("quitall", 0, bool_0: true, txtLinkLD.Text);
			list_3.Clear();
		}

		private void rdProxyOrbit_CheckedChanged(object sender, EventArgs e)
		{
			if (rdProxyOrbit.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rdIPPortUserPass;
				RadioButton radioButton4 = rbXproxy;
				RadioButton radioButton5 = rbTMProxy;
				RadioButton radioButton6 = rbProxyv6;
				radioButton6.Checked = false;
				rbProxyShoplike.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			pnlProxyFree.Enabled = rdProxyOrbit.Checked;
		}

		private void method_104(object sender, EventArgs e)
		{
		}

		void Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPass2FAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.plTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stTotalSuccess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stTotalFail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stIPCur = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel14 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel16 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimeExpired = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel15 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMachineName = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label49 = new System.Windows.Forms.Label();
            this.btnOutpuData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTurnOffAllLD = new System.Windows.Forms.Button();
            this.btnCreateLDPLayer = new System.Windows.Forms.Button();
            this.btnRepairLD = new System.Windows.Forms.Button();
            this.btnManagerLD = new System.Windows.Forms.Button();
            this.btnAutoConfig = new System.Windows.Forms.Button();
            this.btnSaveConf = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conf_2fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pnlTuongTac = new System.Windows.Forms.Panel();
            this.gbCamxuc = new System.Windows.Forms.GroupBox();
            this.chkGian = new System.Windows.Forms.CheckBox();
            this.chkBuon = new System.Windows.Forms.CheckBox();
            this.chkHaha = new System.Windows.Forms.CheckBox();
            this.chkTym = new System.Windows.Forms.CheckBox();
            this.chkLike = new System.Windows.Forms.CheckBox();
            this.plAddfriend = new System.Windows.Forms.Panel();
            this.nFriendTo = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.nFriendFrom = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.chkInNewfeed = new System.Windows.Forms.CheckBox();
            this.chkWatch = new System.Windows.Forms.CheckBox();
            this.chkWStory = new System.Windows.Forms.CheckBox();
            this.chkAddFUID = new System.Windows.Forms.CheckBox();
            this.chkReadNotifi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLinkAvartar = new System.Windows.Forms.TextBox();
            this.nAgeTo = new System.Windows.Forms.NumericUpDown();
            this.nAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudDelayQR2Fa = new System.Windows.Forms.NumericUpDown();
            this.btnNhapanh = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbRandomMF = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.chkCoverImg = new System.Windows.Forms.CheckBox();
            this.chkAvartar = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.chk2FA = new System.Windows.Forms.CheckBox();
            this.chkRandomPass = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassFb = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNameReg = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMailVeri = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.plVeriMail = new System.Windows.Forms.Panel();
            this.plHotmailReg = new System.Windows.Forms.Panel();
            this.btnCheckAPIAny = new System.Windows.Forms.Button();
            this.txtPassmail = new System.Windows.Forms.TextBox();
            this.txtAPIAnyCat = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ckRdPassmail = new System.Windows.Forms.CheckBox();
            this.chkHideBrowser = new System.Windows.Forms.CheckBox();
            this.ckTaoMailBox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnNhapHotmail = new System.Windows.Forms.Button();
            this.rdHotMailReg = new System.Windows.Forms.RadioButton();
            this.rdHotMailRegisted = new System.Windows.Forms.RadioButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pnlTemmail = new System.Windows.Forms.Panel();
            this.lnkMailTM = new System.Windows.Forms.LinkLabel();
            this.rdMailTM = new System.Windows.Forms.RadioButton();
            this.lnkTempMailIO = new System.Windows.Forms.LinkLabel();
            this.rdTempMailIO = new System.Windows.Forms.RadioButton();
            this.rdConfMail = new System.Windows.Forms.RadioButton();
            this.plNovery = new System.Windows.Forms.Panel();
            this.rdNoveriMail = new System.Windows.Forms.RadioButton();
            this.rdNovriPhone = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtListDauso = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMailAo = new System.Windows.Forms.ComboBox();
            this.cbbPhoneCountry = new System.Windows.Forms.ComboBox();
            this.plVeriPhone = new System.Windows.Forms.Panel();
            this.btnCheckSim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDvSim = new System.Windows.Forms.ComboBox();
            this.txtAPISim = new System.Windows.Forms.TextBox();
            this.rdThuePhone = new System.Windows.Forms.RadioButton();
            this.rdNoVeri = new System.Windows.Forms.RadioButton();
            this.cbbPrePhone = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabProxy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.plTinsoftProxy = new System.Windows.Forms.Panel();
            this.nudLuongPerIPTinsoft = new System.Windows.Forms.NumericUpDown();
            this.btnCheckProxy = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.cbLocationProxy = new System.Windows.Forms.ComboBox();
            this.rdTinsoftProxy = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pnlAPIMinProxy = new System.Windows.Forms.Panel();
            this.btnCheckAPIMinProxy = new System.Windows.Forms.Button();
            this.txtApiKeyMinProxy = new System.Windows.Forms.RichTextBox();
            this.lblAPIMinKey = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.nudLuongPerIPMinProxy = new System.Windows.Forms.NumericUpDown();
            this.rdMinProxy = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlIpPort = new System.Windows.Forms.Panel();
            this.cbbTypeProxyIP = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.rdIPDong = new System.Windows.Forms.RadioButton();
            this.rdIPStatic = new System.Windows.Forms.RadioButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtListProxyIp = new System.Windows.Forms.RichTextBox();
            this.lblListProxyIP = new System.Windows.Forms.Label();
            this.rdIPPortUserPass = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plXproxy = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.rbXproxyResetAllProxy = new System.Windows.Forms.RadioButton();
            this.rbXproxyResetEachProxy = new System.Windows.Forms.RadioButton();
            this.ckbWaitDoneAllXproxy = new System.Windows.Forms.CheckBox();
            this.txtListXProxy = new System.Windows.Forms.RichTextBox();
            this.rbSock5Proxy = new System.Windows.Forms.RadioButton();
            this.rbHttpProxy = new System.Windows.Forms.RadioButton();
            this.label35 = new System.Windows.Forms.Label();
            this.lblCountXproxy = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.nudDelayResetXProxy = new System.Windows.Forms.NumericUpDown();
            this.nudLuongPerIPXProxy = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.txtServiceURLXProxy = new System.Windows.Forms.TextBox();
            this.rbXproxy = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.plTMProxy = new System.Windows.Forms.Panel();
            this.btnCheckTMProxy = new System.Windows.Forms.Button();
            this.txtApiKeyTMProxy = new System.Windows.Forms.RichTextBox();
            this.lblCountTmProxy = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.nudLuongPerIPTMProxy = new System.Windows.Forms.NumericUpDown();
            this.rbTMProxy = new System.Windows.Forms.RadioButton();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.lnkShopLike = new System.Windows.Forms.LinkLabel();
            this.plProxyShopLike = new System.Windows.Forms.Panel();
            this.txtAPIKeyShoplike = new System.Windows.Forms.RichTextBox();
            this.lblAPIKeyShopLike = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.nudThreadShopLike = new System.Windows.Forms.NumericUpDown();
            this.rbProxyShoplike = new System.Windows.Forms.RadioButton();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.pnlProxyFree = new System.Windows.Forms.Panel();
            this.rdProxyFreeRandom = new System.Windows.Forms.RadioButton();
            this.rdProxyFreeUS = new System.Windows.Forms.RadioButton();
            this.rdProxyFreeVN = new System.Windows.Forms.RadioButton();
            this.rdProxyOrbit = new System.Windows.Forms.RadioButton();
            this.Proxyv6 = new System.Windows.Forms.TabPage();
            this.linkLabelprxv6 = new System.Windows.Forms.LinkLabel();
            this.plProxyv6 = new System.Windows.Forms.Panel();
            this.btnCheckProxyv6 = new System.Windows.Forms.Button();
            this.txtApiProxyv6 = new System.Windows.Forms.RichTextBox();
            this.lblApiProxyv6 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbProxyv6 = new System.Windows.Forms.RadioButton();
            this.plCheckDoiIP = new System.Windows.Forms.Panel();
            this.btnTestChangeIP = new System.Windows.Forms.Button();
            this.numChangeIP = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rdProxy = new System.Windows.Forms.RadioButton();
            this.plChangeIPDcom = new System.Windows.Forms.Panel();
            this.btnGetDcom = new System.Windows.Forms.Button();
            this.txtNameDcom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rdHMA = new System.Windows.Forms.RadioButton();
            this.rdChangeIPDcom = new System.Windows.Forms.RadioButton();
            this.rdNoChangeIP = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numDelayTo = new System.Windows.Forms.NumericUpDown();
            this.rdDelayLD = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numDelayFr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLinkLD = new System.Windows.Forms.TextBox();
            this.numDeClsTo = new System.Windows.Forms.NumericUpDown();
            this.numDeClsFr = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rdSwap = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlSoLanReg = new System.Windows.Forms.Panel();
            this.nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nudTimeWaitOTP = new System.Windows.Forms.NumericUpDown();
            this.numOTP = new System.Windows.Forms.NumericUpDown();
            this.numThrLdPlay = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.cbModeRunReg = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckCheckIP = new System.Windows.Forms.CheckBox();
            this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label44 = new System.Windows.Forms.Label();
            this.text_api_captcha = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.pnlTuongTac.SuspendLayout();
            this.gbCamxuc.SuspendLayout();
            this.plAddfriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFriendTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFriendFrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayQR2Fa)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMailVeri.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.plVeriMail.SuspendLayout();
            this.plHotmailReg.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.pnlTemmail.SuspendLayout();
            this.plNovery.SuspendLayout();
            this.plVeriPhone.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabProxy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.plTinsoftProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTinsoft)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlAPIMinProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPMinProxy)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlIpPort.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plXproxy.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayResetXProxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPXProxy)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.plTMProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTMProxy)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.plProxyShopLike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadShopLike)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.pnlProxyFree.SuspendLayout();
            this.Proxyv6.SuspendLayout();
            this.plProxyv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.plCheckDoiIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeIP)).BeginInit();
            this.plChangeIPDcom.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeClsTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeClsFr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlSoLanReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuotChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWaitOTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThrLdPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_0,
            this.toolStripMenuItem_3,
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 76);
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_1,
            this.toolStripMenuItem_2,
            this.toolStripMenuItem_4});
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItem_0.Text = "Chọn";
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem_1.Text = "Tất cả";
            this.toolStripMenuItem_1.Click += new System.EventHandler(this.toolStripMenuItem_1_Click);
            // 
            // toolStripMenuItem_2
            // 
            this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
            this.toolStripMenuItem_2.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem_2.Text = "Bôi đen";
            this.toolStripMenuItem_2.Click += new System.EventHandler(this.toolStripMenuItem_2_Click);
            // 
            // toolStripMenuItem_4
            // 
            this.toolStripMenuItem_4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.dieToolStripMenuItem,
            this.checkpointToolStripMenuItem});
            this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
            this.toolStripMenuItem_4.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem_4.Text = "Trạng thái";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.liveToolStripMenuItem.Text = "Live";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // dieToolStripMenuItem
            // 
            this.dieToolStripMenuItem.Name = "dieToolStripMenuItem";
            this.dieToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.dieToolStripMenuItem.Text = "Die";
            this.dieToolStripMenuItem.Click += new System.EventHandler(this.dieToolStripMenuItem_Click);
            // 
            // checkpointToolStripMenuItem
            // 
            this.checkpointToolStripMenuItem.Name = "checkpointToolStripMenuItem";
            this.checkpointToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.checkpointToolStripMenuItem.Text = "Checkpoint";
            this.checkpointToolStripMenuItem.Click += new System.EventHandler(this.checkpointToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_3
            // 
            this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
            this.toolStripMenuItem_3.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItem_3.Text = "Bỏ chọn tất cả";
            this.toolStripMenuItem_3.Click += new System.EventHandler(this.toolStripMenuItem_3_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uidPassToolStripMenuItem,
            this.uidPass2FAToolStripMenuItem,
            this.uidPassTokenCookieToolStripMenuItem,
            this.mailPassMailToolStripMenuItem,
            this.phoneToolStripMenuItem,
            this.allToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // uidPassToolStripMenuItem
            // 
            this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
            this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.uidPassToolStripMenuItem.Text = "Uid|Pass";
            this.uidPassToolStripMenuItem.Click += new System.EventHandler(this.uidPassToolStripMenuItem_Click);
            // 
            // uidPass2FAToolStripMenuItem
            // 
            this.uidPass2FAToolStripMenuItem.Name = "uidPass2FAToolStripMenuItem";
            this.uidPass2FAToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.uidPass2FAToolStripMenuItem.Text = "Uid|Pass|2FA";
            this.uidPass2FAToolStripMenuItem.Click += new System.EventHandler(this.uidPass2FAToolStripMenuItem_Click);
            // 
            // uidPassTokenCookieToolStripMenuItem
            // 
            this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
            this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
            this.uidPassTokenCookieToolStripMenuItem.Click += new System.EventHandler(this.uidPassTokenCookieToolStripMenuItem_Click);
            // 
            // mailPassMailToolStripMenuItem
            // 
            this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
            this.mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.mailPassMailToolStripMenuItem.Text = "Mail|PassMail";
            this.mailPassMailToolStripMenuItem.Click += new System.EventHandler(this.mailPassMailToolStripMenuItem_Click);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.phoneToolStripMenuItem.Text = "Phone";
            this.phoneToolStripMenuItem.Click += new System.EventHandler(this.phoneToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel9,
            this.plTrangThai,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel1,
            this.stTotalSuccess,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.stTotalFail,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel6,
            this.stIPCur,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel14,
            this.lblCountSelect,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel16,
            this.lblTimeExpired,
            this.toolStripStatusLabel15,
            this.toolStripStatusLabel5,
            this.lblMachineName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1073);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1942, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(97, 23);
            this.toolStripStatusLabel9.Text = "Trạng thái:";
            // 
            // plTrangThai
            // 
            this.plTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(6)))), ((int)(((byte)(30)))));
            this.plTrangThai.Name = "plTrangThai";
            this.plTrangThai.Size = new System.Drawing.Size(81, 23);
            this.plTrangThai.Text = "Chưa chạy";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel10.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 23);
            this.toolStripStatusLabel1.Text = "Thành công:";
            // 
            // stTotalSuccess
            // 
            this.stTotalSuccess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stTotalSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(189)))), ((int)(((byte)(11)))));
            this.stTotalSuccess.Name = "stTotalSuccess";
            this.stTotalSuccess.Size = new System.Drawing.Size(18, 23);
            this.stTotalSuccess.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(81, 23);
            this.toolStripStatusLabel4.Text = "Thất bại:";
            // 
            // stTotalFail
            // 
            this.stTotalFail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stTotalFail.ForeColor = System.Drawing.Color.Red;
            this.stTotalFail.Name = "stTotalFail";
            this.stTotalFail.Size = new System.Drawing.Size(18, 23);
            this.stTotalFail.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(95, 23);
            this.toolStripStatusLabel6.Text = "IP hiện tại:";
            // 
            // stIPCur
            // 
            this.stIPCur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stIPCur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(189)))));
            this.stIPCur.Name = "stIPCur";
            this.stIPCur.Size = new System.Drawing.Size(74, 23);
            this.stIPCur.Text = "currentIP";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // toolStripStatusLabel14
            // 
            this.toolStripStatusLabel14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel14.Name = "toolStripStatusLabel14";
            this.toolStripStatusLabel14.Size = new System.Drawing.Size(80, 23);
            this.toolStripStatusLabel14.Text = "Đã chọn:";
            // 
            // lblCountSelect
            // 
            this.lblCountSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(6)))), ((int)(((byte)(165)))));
            this.lblCountSelect.Name = "lblCountSelect";
            this.lblCountSelect.Size = new System.Drawing.Size(18, 23);
            this.lblCountSelect.Text = "0";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // toolStripStatusLabel16
            // 
            this.toolStripStatusLabel16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel16.Name = "toolStripStatusLabel16";
            this.toolStripStatusLabel16.Size = new System.Drawing.Size(117, 23);
            this.toolStripStatusLabel16.Text = "Hạn sử dụng:";
            // 
            // lblTimeExpired
            // 
            this.lblTimeExpired.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.lblTimeExpired.Name = "lblTimeExpired";
            this.lblTimeExpired.Size = new System.Drawing.Size(18, 23);
            this.lblTimeExpired.Text = "0";
            // 
            // toolStripStatusLabel15
            // 
            this.toolStripStatusLabel15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel15.Name = "toolStripStatusLabel15";
            this.toolStripStatusLabel15.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel15.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(79, 23);
            this.toolStripStatusLabel5.Text = "Mã máy:";
            // 
            // lblMachineName
            // 
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(10)))));
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(18, 23);
            this.lblMachineName.Text = "0";
            // 
            // timer_0
            // 
            this.timer_0.Interval = 1000;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(42, 2);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(498, 38);
            this.label28.TabIndex = 6;
            this.label28.Text = "Auto Register Facebook On LDPlayer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.btnMaximum);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnMinimized);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1942, 46);
            this.panel4.TabIndex = 7;
            // 
            // btnMaximum
            // 
            this.btnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximum.FlatAppearance.BorderSize = 0;
            this.btnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximum.ForeColor = System.Drawing.Color.White;
            this.btnMaximum.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximum.Image")));
            this.btnMaximum.Location = new System.Drawing.Point(1853, 5);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(44, 34);
            this.btnMaximum.TabIndex = 7;
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1897, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(1808, 2);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(44, 39);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer_1
            // 
            this.timer_1.Interval = 5000;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // bunifuDragControl_0
            // 
            this.bunifuDragControl_0.Fixed = true;
            this.bunifuDragControl_0.Horizontal = true;
            this.bunifuDragControl_0.TargetControl = this.panel4;
            this.bunifuDragControl_0.Vertical = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.label49);
            this.pnlContainer.Controls.Add(this.btnOutpuData);
            this.pnlContainer.Controls.Add(this.btnUpdate);
            this.pnlContainer.Controls.Add(this.btnTurnOffAllLD);
            this.pnlContainer.Controls.Add(this.btnCreateLDPLayer);
            this.pnlContainer.Controls.Add(this.btnRepairLD);
            this.pnlContainer.Controls.Add(this.btnManagerLD);
            this.pnlContainer.Controls.Add(this.btnAutoConfig);
            this.pnlContainer.Controls.Add(this.btnSaveConf);
            this.pnlContainer.Controls.Add(this.btnStop);
            this.pnlContainer.Controls.Add(this.btnReg);
            this.pnlContainer.Controls.Add(this.groupBox2);
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Location = new System.Drawing.Point(0, 47);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1923, 979);
            this.pnlContainer.TabIndex = 8;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(846, 87);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(138, 17);
            this.label49.TabIndex = 15;
            this.label49.Text = "Update Reg Verimail";
            this.label49.Paint += new System.Windows.Forms.PaintEventHandler(this.label49_Paint);
            // 
            // btnOutpuData
            // 
            this.btnOutpuData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutpuData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutpuData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(50)))), ((int)(((byte)(155)))));
            this.btnOutpuData.Image = ((System.Drawing.Image)(resources.GetObject("btnOutpuData.Image")));
            this.btnOutpuData.Location = new System.Drawing.Point(772, 22);
            this.btnOutpuData.Name = "btnOutpuData";
            this.btnOutpuData.Size = new System.Drawing.Size(143, 61);
            this.btnOutpuData.TabIndex = 11;
            this.btnOutpuData.Text = "Output Data";
            this.btnOutpuData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutpuData.UseVisualStyleBackColor = true;
            this.btnOutpuData.Click += new System.EventHandler(this.btnOutpuData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1611, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 63);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Tool";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTurnOffAllLD
            // 
            this.btnTurnOffAllLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnOffAllLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOffAllLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.btnTurnOffAllLD.Image = ((System.Drawing.Image)(resources.GetObject("btnTurnOffAllLD.Image")));
            this.btnTurnOffAllLD.Location = new System.Drawing.Point(1435, 21);
            this.btnTurnOffAllLD.Name = "btnTurnOffAllLD";
            this.btnTurnOffAllLD.Size = new System.Drawing.Size(170, 63);
            this.btnTurnOffAllLD.TabIndex = 11;
            this.btnTurnOffAllLD.Text = "Tắt tất cả LDPlayer";
            this.btnTurnOffAllLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurnOffAllLD.UseVisualStyleBackColor = true;
            this.btnTurnOffAllLD.Click += new System.EventHandler(this.btnTurnOffAllLD_Click);
            // 
            // btnCreateLDPLayer
            // 
            this.btnCreateLDPLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateLDPLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLDPLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.btnCreateLDPLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateLDPLayer.Image")));
            this.btnCreateLDPLayer.Location = new System.Drawing.Point(1259, 21);
            this.btnCreateLDPLayer.Name = "btnCreateLDPLayer";
            this.btnCreateLDPLayer.Size = new System.Drawing.Size(170, 63);
            this.btnCreateLDPLayer.TabIndex = 11;
            this.btnCreateLDPLayer.Text = "Tạo mới LDPlayer";
            this.btnCreateLDPLayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateLDPLayer.UseVisualStyleBackColor = true;
            this.btnCreateLDPLayer.Click += new System.EventHandler(this.btnCreateLDPLayer_Click);
            // 
            // btnRepairLD
            // 
            this.btnRepairLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepairLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.btnRepairLD.Image = ((System.Drawing.Image)(resources.GetObject("btnRepairLD.Image")));
            this.btnRepairLD.Location = new System.Drawing.Point(1083, 21);
            this.btnRepairLD.Name = "btnRepairLD";
            this.btnRepairLD.Size = new System.Drawing.Size(170, 63);
            this.btnRepairLD.TabIndex = 11;
            this.btnRepairLD.Text = "Sửa chữa LDPlayer";
            this.btnRepairLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepairLD.UseVisualStyleBackColor = true;
            this.btnRepairLD.Click += new System.EventHandler(this.btnRepairLD_Click);
            // 
            // btnManagerLD
            // 
            this.btnManagerLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(78)))), ((int)(((byte)(50)))));
            this.btnManagerLD.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerLD.Image")));
            this.btnManagerLD.Location = new System.Drawing.Point(921, 21);
            this.btnManagerLD.Name = "btnManagerLD";
            this.btnManagerLD.Size = new System.Drawing.Size(157, 61);
            this.btnManagerLD.TabIndex = 11;
            this.btnManagerLD.Text = "Quản lý LDPlayer";
            this.btnManagerLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagerLD.UseVisualStyleBackColor = true;
            this.btnManagerLD.Click += new System.EventHandler(this.btnManagerLD_Click);
            // 
            // btnAutoConfig
            // 
            this.btnAutoConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnAutoConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoConfig.Image")));
            this.btnAutoConfig.Location = new System.Drawing.Point(606, 22);
            this.btnAutoConfig.Name = "btnAutoConfig";
            this.btnAutoConfig.Size = new System.Drawing.Size(157, 61);
            this.btnAutoConfig.TabIndex = 11;
            this.btnAutoConfig.Text = "Cài đặt nâng cao";
            this.btnAutoConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoConfig.UseVisualStyleBackColor = true;
            this.btnAutoConfig.Click += new System.EventHandler(this.btnAutoConfig_Click);
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnSaveConf.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveConf.Image")));
            this.btnSaveConf.Location = new System.Drawing.Point(443, 22);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Size = new System.Drawing.Size(157, 61);
            this.btnSaveConf.TabIndex = 12;
            this.btnSaveConf.Text = "Lưu cấu hình";
            this.btnSaveConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveConf.UseVisualStyleBackColor = true;
            this.btnSaveConf.Click += new System.EventHandler(this.btnSaveConf_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(280, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(157, 61);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Dừng lại";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReg
            // 
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(189)))), ((int)(((byte)(6)))));
            this.btnReg.Image = ((System.Drawing.Image)(resources.GetObject("btnReg.Image")));
            this.btnReg.Location = new System.Drawing.Point(117, 21);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(157, 61);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "Bắt đầu";
            this.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvAcc);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 825);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgvAcc
            // 
            this.dgvAcc.AllowUserToAddRows = false;
            this.dgvAcc.AllowUserToDeleteRows = false;
            this.dgvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChose,
            this.cId,
            this.status,
            this.uid,
            this.pass,
            this.ho,
            this.ten,
            this.age,
            this.gender,
            this.conf_2fa,
            this.token,
            this.cookie,
            this.email,
            this.passMail,
            this.phone,
            this.proxy,
            this.cInfo,
            this.cDevice});
            this.dgvAcc.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAcc.Location = new System.Drawing.Point(3, 23);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersVisible = false;
            this.dgvAcc.RowHeadersWidth = 51;
            this.dgvAcc.RowTemplate.Height = 24;
            this.dgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcc.Size = new System.Drawing.Size(728, 633);
            this.dgvAcc.TabIndex = 1;
            // 
            // cChose
            // 
            this.cChose.HeaderText = "Chọn";
            this.cChose.MinimumWidth = 6;
            this.cChose.Name = "cChose";
            this.cChose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cChose.Width = 85;
            // 
            // cId
            // 
            this.cId.HeaderText = "STT";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Width = 50;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 350;
            // 
            // uid
            // 
            this.uid.HeaderText = "UID";
            this.uid.MinimumWidth = 6;
            this.uid.Name = "uid";
            this.uid.Width = 125;
            // 
            // pass
            // 
            this.pass.HeaderText = "Mật khẩu";
            this.pass.MinimumWidth = 6;
            this.pass.Name = "pass";
            this.pass.Width = 125;
            // 
            // ho
            // 
            this.ho.HeaderText = "Họ";
            this.ho.MinimumWidth = 6;
            this.ho.Name = "ho";
            this.ho.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Tuổi";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 125;
            // 
            // conf_2fa
            // 
            this.conf_2fa.HeaderText = "2Fa";
            this.conf_2fa.MinimumWidth = 6;
            this.conf_2fa.Name = "conf_2fa";
            this.conf_2fa.Width = 125;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 6;
            this.token.Name = "token";
            this.token.Width = 125;
            // 
            // cookie
            // 
            this.cookie.HeaderText = "Cookie";
            this.cookie.MinimumWidth = 6;
            this.cookie.Name = "cookie";
            this.cookie.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // passMail
            // 
            this.passMail.HeaderText = "Pass Mail";
            this.passMail.MinimumWidth = 6;
            this.passMail.Name = "passMail";
            this.passMail.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // proxy
            // 
            this.proxy.HeaderText = "Proxy";
            this.proxy.MinimumWidth = 6;
            this.proxy.Name = "proxy";
            this.proxy.Width = 125;
            // 
            // cInfo
            // 
            this.cInfo.HeaderText = "Tình trạng";
            this.cInfo.MinimumWidth = 6;
            this.cInfo.Name = "cInfo";
            this.cInfo.Width = 125;
            // 
            // cDevice
            // 
            this.cDevice.HeaderText = "LD index";
            this.cDevice.MinimumWidth = 6;
            this.cDevice.Name = "cDevice";
            this.cDevice.Width = 125;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pnlTuongTac);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox8.Location = new System.Drawing.Point(17, 670);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(579, 149);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tương tác sau khi reg thành công";
            // 
            // pnlTuongTac
            // 
            this.pnlTuongTac.AutoScroll = true;
            this.pnlTuongTac.Controls.Add(this.gbCamxuc);
            this.pnlTuongTac.Controls.Add(this.plAddfriend);
            this.pnlTuongTac.Controls.Add(this.chkInNewfeed);
            this.pnlTuongTac.Controls.Add(this.chkWatch);
            this.pnlTuongTac.Controls.Add(this.chkWStory);
            this.pnlTuongTac.Controls.Add(this.chkAddFUID);
            this.pnlTuongTac.Controls.Add(this.chkReadNotifi);
            this.pnlTuongTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTuongTac.Location = new System.Drawing.Point(3, 20);
            this.pnlTuongTac.Name = "pnlTuongTac";
            this.pnlTuongTac.Size = new System.Drawing.Size(573, 126);
            this.pnlTuongTac.TabIndex = 6;
            // 
            // gbCamxuc
            // 
            this.gbCamxuc.Controls.Add(this.chkGian);
            this.gbCamxuc.Controls.Add(this.chkBuon);
            this.gbCamxuc.Controls.Add(this.chkHaha);
            this.gbCamxuc.Controls.Add(this.chkTym);
            this.gbCamxuc.Controls.Add(this.chkLike);
            this.gbCamxuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCamxuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gbCamxuc.Location = new System.Drawing.Point(142, 64);
            this.gbCamxuc.Name = "gbCamxuc";
            this.gbCamxuc.Size = new System.Drawing.Size(351, 44);
            this.gbCamxuc.TabIndex = 12;
            this.gbCamxuc.TabStop = false;
            this.gbCamxuc.Text = "Cảm xúc";
            // 
            // chkGian
            // 
            this.chkGian.AutoSize = true;
            this.chkGian.Location = new System.Drawing.Point(276, 22);
            this.chkGian.Name = "chkGian";
            this.chkGian.Size = new System.Drawing.Size(61, 22);
            this.chkGian.TabIndex = 3;
            this.chkGian.Text = "Giận";
            this.chkGian.UseVisualStyleBackColor = true;
            // 
            // chkBuon
            // 
            this.chkBuon.AutoSize = true;
            this.chkBuon.Location = new System.Drawing.Point(203, 22);
            this.chkBuon.Name = "chkBuon";
            this.chkBuon.Size = new System.Drawing.Size(65, 22);
            this.chkBuon.TabIndex = 3;
            this.chkBuon.Text = "Buồn";
            this.chkBuon.UseVisualStyleBackColor = true;
            // 
            // chkHaha
            // 
            this.chkHaha.AutoSize = true;
            this.chkHaha.Location = new System.Drawing.Point(135, 22);
            this.chkHaha.Name = "chkHaha";
            this.chkHaha.Size = new System.Drawing.Size(65, 22);
            this.chkHaha.TabIndex = 3;
            this.chkHaha.Text = "Haha";
            this.chkHaha.UseVisualStyleBackColor = true;
            // 
            // chkTym
            // 
            this.chkTym.AutoSize = true;
            this.chkTym.Location = new System.Drawing.Point(72, 23);
            this.chkTym.Name = "chkTym";
            this.chkTym.Size = new System.Drawing.Size(59, 22);
            this.chkTym.TabIndex = 3;
            this.chkTym.Text = "Tym";
            this.chkTym.UseVisualStyleBackColor = true;
            // 
            // chkLike
            // 
            this.chkLike.AutoSize = true;
            this.chkLike.Location = new System.Drawing.Point(12, 23);
            this.chkLike.Name = "chkLike";
            this.chkLike.Size = new System.Drawing.Size(57, 22);
            this.chkLike.TabIndex = 3;
            this.chkLike.Text = "Like";
            this.chkLike.UseVisualStyleBackColor = true;
            // 
            // plAddfriend
            // 
            this.plAddfriend.Controls.Add(this.nFriendTo);
            this.plAddfriend.Controls.Add(this.label25);
            this.plAddfriend.Controls.Add(this.nFriendFrom);
            this.plAddfriend.Controls.Add(this.label26);
            this.plAddfriend.Controls.Add(this.label27);
            this.plAddfriend.Location = new System.Drawing.Point(217, 25);
            this.plAddfriend.Name = "plAddfriend";
            this.plAddfriend.Size = new System.Drawing.Size(300, 33);
            this.plAddfriend.TabIndex = 11;
            // 
            // nFriendTo
            // 
            this.nFriendTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFriendTo.Location = new System.Drawing.Point(194, 9);
            this.nFriendTo.Name = "nFriendTo";
            this.nFriendTo.Size = new System.Drawing.Size(55, 24);
            this.nFriendTo.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 18);
            this.label25.TabIndex = 0;
            this.label25.Text = "Số lượng:";
            // 
            // nFriendFrom
            // 
            this.nFriendFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFriendFrom.Location = new System.Drawing.Point(88, 9);
            this.nFriendFrom.Name = "nFriendFrom";
            this.nFriendFrom.Size = new System.Drawing.Size(55, 24);
            this.nFriendFrom.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(153, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 18);
            this.label26.TabIndex = 0;
            this.label26.Text = "đến";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(258, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 18);
            this.label27.TabIndex = 0;
            this.label27.Text = "bạn";
            // 
            // chkInNewfeed
            // 
            this.chkInNewfeed.AutoSize = true;
            this.chkInNewfeed.Location = new System.Drawing.Point(16, 30);
            this.chkInNewfeed.Name = "chkInNewfeed";
            this.chkInNewfeed.Size = new System.Drawing.Size(175, 22);
            this.chkInNewfeed.TabIndex = 6;
            this.chkInNewfeed.Text = "Tương tác Newfeed";
            this.chkInNewfeed.UseVisualStyleBackColor = true;
            // 
            // chkWatch
            // 
            this.chkWatch.AutoSize = true;
            this.chkWatch.Location = new System.Drawing.Point(16, 59);
            this.chkWatch.Name = "chkWatch";
            this.chkWatch.Size = new System.Drawing.Size(117, 22);
            this.chkWatch.TabIndex = 7;
            this.chkWatch.Text = "Xem Watch";
            this.chkWatch.UseVisualStyleBackColor = true;
            // 
            // chkWStory
            // 
            this.chkWStory.AutoSize = true;
            this.chkWStory.Location = new System.Drawing.Point(16, 91);
            this.chkWStory.Name = "chkWStory";
            this.chkWStory.Size = new System.Drawing.Size(109, 22);
            this.chkWStory.TabIndex = 8;
            this.chkWStory.Text = "Xem Story";
            this.chkWStory.UseVisualStyleBackColor = true;
            this.chkWStory.CheckedChanged += new System.EventHandler(this.chkWStory_CheckedChanged);
            // 
            // chkAddFUID
            // 
            this.chkAddFUID.AutoSize = true;
            this.chkAddFUID.Location = new System.Drawing.Point(227, 3);
            this.chkAddFUID.Name = "chkAddFUID";
            this.chkAddFUID.Size = new System.Drawing.Size(128, 22);
            this.chkAddFUID.TabIndex = 9;
            this.chkAddFUID.Text = "Kết bạn gợi ý";
            this.chkAddFUID.UseVisualStyleBackColor = true;
            // 
            // chkReadNotifi
            // 
            this.chkReadNotifi.AutoSize = true;
            this.chkReadNotifi.Location = new System.Drawing.Point(16, 3);
            this.chkReadNotifi.Name = "chkReadNotifi";
            this.chkReadNotifi.Size = new System.Drawing.Size(141, 22);
            this.chkReadNotifi.TabIndex = 10;
            this.chkReadNotifi.Text = "Đọc thông báo";
            this.chkReadNotifi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox1.Location = new System.Drawing.Point(761, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 813);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.text_api_captcha);
            this.groupBox7.Controls.Add(this.txtLinkAvartar);
            this.groupBox7.Controls.Add(this.nAgeTo);
            this.groupBox7.Controls.Add(this.nAgeFrom);
            this.groupBox7.Controls.Add(this.nudDelayQR2Fa);
            this.groupBox7.Controls.Add(this.btnNhapanh);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.panel3);
            this.groupBox7.Controls.Add(this.chkCoverImg);
            this.groupBox7.Controls.Add(this.chkAvartar);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.chk2FA);
            this.groupBox7.Controls.Add(this.chkRandomPass);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtPassFb);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.cbNameReg);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox7.Location = new System.Drawing.Point(598, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(547, 333);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cấu hình tài khoản";
            // 
            // txtLinkAvartar
            // 
            this.txtLinkAvartar.Location = new System.Drawing.Point(16, 252);
            this.txtLinkAvartar.Name = "txtLinkAvartar";
            this.txtLinkAvartar.Size = new System.Drawing.Size(318, 24);
            this.txtLinkAvartar.TabIndex = 6;
            // 
            // nAgeTo
            // 
            this.nAgeTo.Location = new System.Drawing.Point(466, 21);
            this.nAgeTo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nAgeTo.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nAgeTo.Name = "nAgeTo";
            this.nAgeTo.Size = new System.Drawing.Size(58, 24);
            this.nAgeTo.TabIndex = 1;
            this.nAgeTo.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // nAgeFrom
            // 
            this.nAgeFrom.Location = new System.Drawing.Point(357, 21);
            this.nAgeFrom.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nAgeFrom.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nAgeFrom.Name = "nAgeFrom";
            this.nAgeFrom.Size = new System.Drawing.Size(55, 24);
            this.nAgeFrom.TabIndex = 1;
            this.nAgeFrom.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nudDelayQR2Fa
            // 
            this.nudDelayQR2Fa.Location = new System.Drawing.Point(401, 163);
            this.nudDelayQR2Fa.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudDelayQR2Fa.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDelayQR2Fa.Name = "nudDelayQR2Fa";
            this.nudDelayQR2Fa.Size = new System.Drawing.Size(67, 24);
            this.nudDelayQR2Fa.TabIndex = 1;
            this.nudDelayQR2Fa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnNhapanh
            // 
            this.btnNhapanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapanh.Location = new System.Drawing.Point(357, 244);
            this.btnNhapanh.Name = "btnNhapanh";
            this.btnNhapanh.Size = new System.Drawing.Size(131, 40);
            this.btnNhapanh.TabIndex = 5;
            this.btnNhapanh.Text = "Folder ảnh";
            this.btnNhapanh.UseVisualStyleBackColor = true;
            this.btnNhapanh.Click += new System.EventHandler(this.btnNhapanh_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(489, 166);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 18);
            this.label40.TabIndex = 0;
            this.label40.Text = "giây";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbRandomMF);
            this.panel3.Controls.Add(this.rbFemale);
            this.panel3.Controls.Add(this.rbMale);
            this.panel3.Location = new System.Drawing.Point(85, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 40);
            this.panel3.TabIndex = 4;
            // 
            // rbRandomMF
            // 
            this.rbRandomMF.AutoSize = true;
            this.rbRandomMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRandomMF.Location = new System.Drawing.Point(146, 10);
            this.rbRandomMF.Name = "rbRandomMF";
            this.rbRandomMF.Size = new System.Drawing.Size(103, 22);
            this.rbRandomMF.TabIndex = 1;
            this.rbRandomMF.TabStop = true;
            this.rbRandomMF.Text = "Ngẫu nhiên";
            this.rbRandomMF.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(81, 10);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(48, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(8, 10);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 22);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // chkCoverImg
            // 
            this.chkCoverImg.AutoSize = true;
            this.chkCoverImg.Location = new System.Drawing.Point(16, 290);
            this.chkCoverImg.Name = "chkCoverImg";
            this.chkCoverImg.Size = new System.Drawing.Size(125, 22);
            this.chkCoverImg.TabIndex = 3;
            this.chkCoverImg.Text = "Thay ảnh bìa";
            this.chkCoverImg.UseVisualStyleBackColor = true;
            // 
            // chkAvartar
            // 
            this.chkAvartar.AutoSize = true;
            this.chkAvartar.Location = new System.Drawing.Point(16, 218);
            this.chkAvartar.Name = "chkAvartar";
            this.chkAvartar.Size = new System.Drawing.Size(432, 22);
            this.chkAvartar.TabIndex = 3;
            this.chkAvartar.Text = "Thay avatar ( Đường dẫn ảnh không dấu không cách )";
            this.chkAvartar.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(263, 169);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(116, 18);
            this.label36.TabIndex = 0;
            this.label36.Text = "Delay QR Code:";
            // 
            // chk2FA
            // 
            this.chk2FA.AutoSize = true;
            this.chk2FA.Location = new System.Drawing.Point(16, 166);
            this.chk2FA.Name = "chk2FA";
            this.chk2FA.Size = new System.Drawing.Size(18, 17);
            this.chk2FA.TabIndex = 3;
            this.chk2FA.UseVisualStyleBackColor = true;
            // 
            // chkRandomPass
            // 
            this.chkRandomPass.AutoSize = true;
            this.chkRandomPass.Location = new System.Drawing.Point(172, 81);
            this.chkRandomPass.Name = "chkRandomPass";
            this.chkRandomPass.Size = new System.Drawing.Size(114, 22);
            this.chkRandomPass.TabIndex = 3;
            this.chkRandomPass.Text = "Ngẫu nhiên";
            this.chkRandomPass.UseVisualStyleBackColor = true;
            this.chkRandomPass.CheckedChanged += new System.EventHandler(this.ckCheckIP_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Giới tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mật khẩu Facebook:";
            // 
            // txtPassFb
            // 
            this.txtPassFb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassFb.Location = new System.Drawing.Point(171, 53);
            this.txtPassFb.Name = "txtPassFb";
            this.txtPassFb.Size = new System.Drawing.Size(143, 24);
            this.txtPassFb.TabIndex = 2;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(422, 24);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(32, 18);
            this.label43.TabIndex = 1;
            this.label43.Text = "đến";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(291, 24);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 18);
            this.label41.TabIndex = 1;
            this.label41.Text = "Độ tuổi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên đăng ký:";
            // 
            // cbNameReg
            // 
            this.cbNameReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNameReg.FormattingEnabled = true;
            this.cbNameReg.Items.AddRange(new object[] {
            "Tên Việt",
            "Tên nước ngoài",
            "Thailand"});
            this.cbNameReg.Location = new System.Drawing.Point(119, 21);
            this.cbNameReg.Name = "cbNameReg";
            this.cbNameReg.Size = new System.Drawing.Size(154, 26);
            this.cbNameReg.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox6.Location = new System.Drawing.Point(598, 364);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(547, 362);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cấu hình xác minh";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tabMailVeri);
            this.panel2.Controls.Add(this.rdConfMail);
            this.panel2.Controls.Add(this.plNovery);
            this.panel2.Controls.Add(this.plVeriPhone);
            this.panel2.Controls.Add(this.rdThuePhone);
            this.panel2.Controls.Add(this.rdNoVeri);
            this.panel2.Controls.Add(this.cbbPrePhone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 339);
            this.panel2.TabIndex = 7;
            // 
            // tabMailVeri
            // 
            this.tabMailVeri.Controls.Add(this.tabPage6);
            this.tabMailVeri.Controls.Add(this.tabPage7);
            this.tabMailVeri.Location = new System.Drawing.Point(13, 272);
            this.tabMailVeri.Name = "tabMailVeri";
            this.tabMailVeri.SelectedIndex = 0;
            this.tabMailVeri.Size = new System.Drawing.Size(516, 268);
            this.tabMailVeri.TabIndex = 6;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.plVeriMail);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(508, 237);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Hotmail";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // plVeriMail
            // 
            this.plVeriMail.AutoScroll = true;
            this.plVeriMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVeriMail.Controls.Add(this.plHotmailReg);
            this.plVeriMail.Controls.Add(this.btnNhapHotmail);
            this.plVeriMail.Controls.Add(this.rdHotMailReg);
            this.plVeriMail.Controls.Add(this.rdHotMailRegisted);
            this.plVeriMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plVeriMail.Location = new System.Drawing.Point(3, 3);
            this.plVeriMail.Name = "plVeriMail";
            this.plVeriMail.Size = new System.Drawing.Size(502, 231);
            this.plVeriMail.TabIndex = 3;
            // 
            // plHotmailReg
            // 
            this.plHotmailReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plHotmailReg.Controls.Add(this.btnCheckAPIAny);
            this.plHotmailReg.Controls.Add(this.txtPassmail);
            this.plHotmailReg.Controls.Add(this.txtAPIAnyCat);
            this.plHotmailReg.Controls.Add(this.label22);
            this.plHotmailReg.Controls.Add(this.ckRdPassmail);
            this.plHotmailReg.Controls.Add(this.chkHideBrowser);
            this.plHotmailReg.Controls.Add(this.ckTaoMailBox);
            this.plHotmailReg.Controls.Add(this.label19);
            this.plHotmailReg.Location = new System.Drawing.Point(31, 29);
            this.plHotmailReg.Name = "plHotmailReg";
            this.plHotmailReg.Size = new System.Drawing.Size(434, 140);
            this.plHotmailReg.TabIndex = 4;
            // 
            // btnCheckAPIAny
            // 
            this.btnCheckAPIAny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAPIAny.Location = new System.Drawing.Point(320, 2);
            this.btnCheckAPIAny.Name = "btnCheckAPIAny";
            this.btnCheckAPIAny.Size = new System.Drawing.Size(111, 45);
            this.btnCheckAPIAny.TabIndex = 3;
            this.btnCheckAPIAny.Text = "Kiểm tra";
            this.btnCheckAPIAny.UseVisualStyleBackColor = true;
            this.btnCheckAPIAny.Click += new System.EventHandler(this.btnCheckAPIAny_Click);
            // 
            // txtPassmail
            // 
            this.txtPassmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassmail.Location = new System.Drawing.Point(145, 82);
            this.txtPassmail.Name = "txtPassmail";
            this.txtPassmail.Size = new System.Drawing.Size(151, 24);
            this.txtPassmail.TabIndex = 2;
            // 
            // txtAPIAnyCat
            // 
            this.txtAPIAnyCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPIAnyCat.Location = new System.Drawing.Point(145, 12);
            this.txtAPIAnyCat.Name = "txtAPIAnyCat";
            this.txtAPIAnyCat.Size = new System.Drawing.Size(151, 24);
            this.txtAPIAnyCat.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(4, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Mật khẩu mail:";
            // 
            // ckRdPassmail
            // 
            this.ckRdPassmail.AutoSize = true;
            this.ckRdPassmail.Location = new System.Drawing.Point(302, 84);
            this.ckRdPassmail.Name = "ckRdPassmail";
            this.ckRdPassmail.Size = new System.Drawing.Size(93, 22);
            this.ckRdPassmail.TabIndex = 3;
            this.ckRdPassmail.Text = "Random";
            this.ckRdPassmail.UseVisualStyleBackColor = true;
            this.ckRdPassmail.CheckedChanged += new System.EventHandler(this.ckCheckIP_CheckedChanged);
            // 
            // chkHideBrowser
            // 
            this.chkHideBrowser.AutoSize = true;
            this.chkHideBrowser.Location = new System.Drawing.Point(7, 112);
            this.chkHideBrowser.Name = "chkHideBrowser";
            this.chkHideBrowser.Size = new System.Drawing.Size(132, 22);
            this.chkHideBrowser.TabIndex = 3;
            this.chkHideBrowser.Text = "Ẩn trình duyệt";
            this.chkHideBrowser.UseVisualStyleBackColor = true;
            // 
            // ckTaoMailBox
            // 
            this.ckTaoMailBox.AutoSize = true;
            this.ckTaoMailBox.Location = new System.Drawing.Point(7, 48);
            this.ckTaoMailBox.Name = "ckTaoMailBox";
            this.ckTaoMailBox.Size = new System.Drawing.Size(338, 22);
            this.ckTaoMailBox.TabIndex = 3;
            this.ckTaoMailBox.Text = "Tự động tạo Mailbox (Hotmail + Outlook)";
            this.ckTaoMailBox.UseVisualStyleBackColor = true;
            this.ckTaoMailBox.CheckedChanged += new System.EventHandler(this.chkWStory_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "API Anycaptcha:";
            // 
            // btnNhapHotmail
            // 
            this.btnNhapHotmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHotmail.Location = new System.Drawing.Point(187, 175);
            this.btnNhapHotmail.Name = "btnNhapHotmail";
            this.btnNhapHotmail.Size = new System.Drawing.Size(178, 37);
            this.btnNhapHotmail.TabIndex = 3;
            this.btnNhapHotmail.Text = "Nhập Hotmail";
            this.btnNhapHotmail.UseVisualStyleBackColor = true;
            this.btnNhapHotmail.Click += new System.EventHandler(this.btnNhapHotmail_Click);
            // 
            // rdHotMailReg
            // 
            this.rdHotMailReg.AutoSize = true;
            this.rdHotMailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHotMailReg.Location = new System.Drawing.Point(10, 7);
            this.rdHotMailReg.Name = "rdHotMailReg";
            this.rdHotMailReg.Size = new System.Drawing.Size(198, 22);
            this.rdHotMailReg.TabIndex = 1;
            this.rdHotMailReg.TabStop = true;
            this.rdHotMailReg.Text = "Hotmail (tự động đăng ký)";
            this.rdHotMailReg.UseVisualStyleBackColor = true;
            this.rdHotMailReg.CheckedChanged += new System.EventHandler(this.rdHotMailReg_CheckedChanged);
            // 
            // rdHotMailRegisted
            // 
            this.rdHotMailRegisted.AutoSize = true;
            this.rdHotMailRegisted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHotMailRegisted.Location = new System.Drawing.Point(10, 185);
            this.rdHotMailRegisted.Name = "rdHotMailRegisted";
            this.rdHotMailRegisted.Size = new System.Drawing.Size(155, 22);
            this.rdHotMailRegisted.TabIndex = 1;
            this.rdHotMailRegisted.TabStop = true;
            this.rdHotMailRegisted.Text = "Hotmail đã đăng ký";
            this.rdHotMailRegisted.UseVisualStyleBackColor = true;
            this.rdHotMailRegisted.CheckedChanged += new System.EventHandler(this.rdHotMailRegisted_CheckedChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pnlTemmail);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(508, 237);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Veri tempmail + mailtm";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pnlTemmail
            // 
            this.pnlTemmail.Controls.Add(this.lnkMailTM);
            this.pnlTemmail.Controls.Add(this.rdMailTM);
            this.pnlTemmail.Controls.Add(this.lnkTempMailIO);
            this.pnlTemmail.Controls.Add(this.rdTempMailIO);
            this.pnlTemmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTemmail.Location = new System.Drawing.Point(3, 3);
            this.pnlTemmail.Name = "pnlTemmail";
            this.pnlTemmail.Size = new System.Drawing.Size(502, 231);
            this.pnlTemmail.TabIndex = 0;
            // 
            // lnkMailTM
            // 
            this.lnkMailTM.AutoSize = true;
            this.lnkMailTM.Location = new System.Drawing.Point(159, 41);
            this.lnkMailTM.Name = "lnkMailTM";
            this.lnkMailTM.Size = new System.Drawing.Size(137, 18);
            this.lnkMailTM.TabIndex = 165;
            this.lnkMailTM.TabStop = true;
            this.lnkMailTM.Text = "https://mail.tm/vi/";
            // 
            // rdMailTM
            // 
            this.rdMailTM.AutoSize = true;
            this.rdMailTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMailTM.Location = new System.Drawing.Point(11, 39);
            this.rdMailTM.Name = "rdMailTM";
            this.rdMailTM.Size = new System.Drawing.Size(84, 22);
            this.rdMailTM.TabIndex = 164;
            this.rdMailTM.Text = "Mail.tm";
            this.rdMailTM.UseVisualStyleBackColor = true;
            this.rdMailTM.CheckedChanged += new System.EventHandler(this.rdMailTM_CheckedChanged);
            // 
            // lnkTempMailIO
            // 
            this.lnkTempMailIO.AutoSize = true;
            this.lnkTempMailIO.Location = new System.Drawing.Point(159, 13);
            this.lnkTempMailIO.Name = "lnkTempMailIO";
            this.lnkTempMailIO.Size = new System.Drawing.Size(158, 18);
            this.lnkTempMailIO.TabIndex = 159;
            this.lnkTempMailIO.TabStop = true;
            this.lnkTempMailIO.Text = "https://temp-mail.io/";
            this.lnkTempMailIO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTempMailIO_LinkClicked);
            // 
            // rdTempMailIO
            // 
            this.rdTempMailIO.AutoSize = true;
            this.rdTempMailIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTempMailIO.Location = new System.Drawing.Point(11, 11);
            this.rdTempMailIO.Name = "rdTempMailIO";
            this.rdTempMailIO.Size = new System.Drawing.Size(127, 22);
            this.rdTempMailIO.TabIndex = 158;
            this.rdTempMailIO.Text = "Temp-Mail.io";
            this.rdTempMailIO.UseVisualStyleBackColor = true;
            this.rdTempMailIO.CheckedChanged += new System.EventHandler(this.rdTempMailIO_CheckedChanged);
            // 
            // rdConfMail
            // 
            this.rdConfMail.AutoSize = true;
            this.rdConfMail.Checked = true;
            this.rdConfMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdConfMail.Location = new System.Drawing.Point(13, 228);
            this.rdConfMail.Name = "rdConfMail";
            this.rdConfMail.Size = new System.Drawing.Size(150, 22);
            this.rdConfMail.TabIndex = 1;
            this.rdConfMail.TabStop = true;
            this.rdConfMail.Text = "Xác minh qua mail";
            this.rdConfMail.UseVisualStyleBackColor = true;
            this.rdConfMail.CheckedChanged += new System.EventHandler(this.rdConfMail_CheckedChanged);
            // 
            // plNovery
            // 
            this.plNovery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plNovery.Controls.Add(this.rdNoveriMail);
            this.plNovery.Controls.Add(this.rdNovriPhone);
            this.plNovery.Controls.Add(this.label18);
            this.plNovery.Controls.Add(this.txtListDauso);
            this.plNovery.Controls.Add(this.label17);
            this.plNovery.Controls.Add(this.cbMailAo);
            this.plNovery.Controls.Add(this.cbbPhoneCountry);
            this.plNovery.Location = new System.Drawing.Point(10, 41);
            this.plNovery.Name = "plNovery";
            this.plNovery.Size = new System.Drawing.Size(522, 74);
            this.plNovery.TabIndex = 5;
            // 
            // rdNoveriMail
            // 
            this.rdNoveriMail.AutoSize = true;
            this.rdNoveriMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNoveriMail.Location = new System.Drawing.Point(6, 41);
            this.rdNoveriMail.Name = "rdNoveriMail";
            this.rdNoveriMail.Size = new System.Drawing.Size(77, 22);
            this.rdNoveriMail.TabIndex = 1;
            this.rdNoveriMail.Text = "Mail ảo";
            this.rdNoveriMail.UseVisualStyleBackColor = true;
            // 
            // rdNovriPhone
            // 
            this.rdNovriPhone.AutoSize = true;
            this.rdNovriPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNovriPhone.Location = new System.Drawing.Point(6, 3);
            this.rdNovriPhone.Name = "rdNovriPhone";
            this.rdNovriPhone.Size = new System.Drawing.Size(93, 22);
            this.rdNovriPhone.TabIndex = 1;
            this.rdNovriPhone.Text = "Phone ảo";
            this.rdNovriPhone.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(96, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Loại mail:";
            // 
            // txtListDauso
            // 
            this.txtListDauso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListDauso.Location = new System.Drawing.Point(348, 2);
            this.txtListDauso.Name = "txtListDauso";
            this.txtListDauso.Size = new System.Drawing.Size(166, 24);
            this.txtListDauso.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(115, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Quốc gia:";
            // 
            // cbMailAo
            // 
            this.cbMailAo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMailAo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMailAo.FormattingEnabled = true;
            this.cbMailAo.Items.AddRange(new object[] {
            "Gmail",
            "Yahoo",
            "Hotmail",
            "Temp-mail.io"});
            this.cbMailAo.Location = new System.Drawing.Point(194, 38);
            this.cbMailAo.Name = "cbMailAo";
            this.cbMailAo.Size = new System.Drawing.Size(114, 26);
            this.cbMailAo.TabIndex = 2;
            // 
            // cbbPhoneCountry
            // 
            this.cbbPhoneCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhoneCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhoneCountry.FormattingEnabled = true;
            this.cbbPhoneCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antigua & Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia (Úc)",
            "Austria (Áo)",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Bỉ",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia & Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia (Campuchia)",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chagos Archipelago",
            "Chile",
            "China (Trung Quốc)",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, Dem. Rep. of",
            "Cook Islands",
            "Costa Rica",
            "Côte d’lvoire",
            "Croatia",
            "Cuba",
            "Czech Republic (Séc)",
            "Denmark (Đan Mạch)",
            "Djibouti",
            "Dominica",
            "Cyprus",
            "Ecuador",
            "Egypt (DST",
            "El Salvador",
            "Equatorial Guinea",
            "Estonia",
            "Ethiopia",
            "Faeroe Islands",
            "Falkland Islands",
            "Fiji",
            "Finland (Phần Lan)",
            "France (Pháp)",
            "French Antilles",
            "French Guiana",
            "French Polynesia††",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany (Đức)",
            "Ghana",
            "Gibraltar",
            "Greece (Hy Lạp)",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India (Ấn Độ)",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan (Nhật Bản)",
            "Jordan",
            "Kenya",
            "Korea, North (Hàn Quốc)",
            "Korea, South (Triều Tiên)",
            "Kuwait",
            "Kyrgyzstan",
            "Zambia",
            "Zimbabwe",
            "Laos (Lào)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Midway Islands",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro & Serbia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger Republic",
            "Nigeria",
            "Northern Mariana Isl.",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland (Ba Lan)",
            "Portugal (Bồ Đào Nha)",
            "Qatar",
            "Reunion Island",
            "Romania",
            "Russia (Nga)",
            "Rwanda",
            "San Marino",
            "Sใo Tom้ & Principe",
            "Saudi Arabia",
            "Senegal",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa (Nam Phi)",
            "Spain (Tây Ban Nha)",
            "Sri Lanka",
            "St. Kitts & Nevis",
            "St. Lucia",
            "St. Vincents & Grenadines",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden (Thụy Điển)",
            "Switzerland (Thụy Sĩ)",
            "Syria",
            "Taiwan (Đài Loan)",
            "Tajikistan",
            "Tanzania",
            "Thái Lan",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey (Thổ Nhĩ Kì)",
            "Turkmenistan",
            "Turks & Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates (Ả Rập)",
            "United Kingdom (Vương Quốc Anh)",
            "United States (Mỹ)",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Virgin Islands, British",
            "Virgin Islands, U.S.",
            "Western Samoa",
            "Yemen",
            "Yugoslavia",
            "Zaire",
            "Serbia"});
            this.cbbPhoneCountry.Location = new System.Drawing.Point(206, 2);
            this.cbbPhoneCountry.Name = "cbbPhoneCountry";
            this.cbbPhoneCountry.Size = new System.Drawing.Size(136, 26);
            this.cbbPhoneCountry.TabIndex = 2;
            this.cbbPhoneCountry.SelectedIndexChanged += new System.EventHandler(this.cbbPhoneCountry_SelectedIndexChanged);
            // 
            // plVeriPhone
            // 
            this.plVeriPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVeriPhone.Controls.Add(this.btnCheckSim);
            this.plVeriPhone.Controls.Add(this.label9);
            this.plVeriPhone.Controls.Add(this.label10);
            this.plVeriPhone.Controls.Add(this.cbDvSim);
            this.plVeriPhone.Controls.Add(this.txtAPISim);
            this.plVeriPhone.Location = new System.Drawing.Point(10, 144);
            this.plVeriPhone.Name = "plVeriPhone";
            this.plVeriPhone.Size = new System.Drawing.Size(522, 78);
            this.plVeriPhone.TabIndex = 4;
            // 
            // btnCheckSim
            // 
            this.btnCheckSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSim.Location = new System.Drawing.Point(411, 18);
            this.btnCheckSim.Name = "btnCheckSim";
            this.btnCheckSim.Size = new System.Drawing.Size(100, 45);
            this.btnCheckSim.TabIndex = 3;
            this.btnCheckSim.Text = "Kiểm tra";
            this.btnCheckSim.UseVisualStyleBackColor = true;
            this.btnCheckSim.Click += new System.EventHandler(this.btnCheckSim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chọn dịch vụ sim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "API:";
            // 
            // cbDvSim
            // 
            this.cbDvSim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDvSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDvSim.FormattingEnabled = true;
            this.cbDvSim.Items.AddRange(new object[] {
            "1. Chothuesimcode - 1100đ/sms",
            "2. Viotp - 1200đ/sms",
            "3. Codetext247.com - ",
            "4. Codesim.net - ",
            "5. PrimeOtp.me - ",
            "6. Tempsms.co - 1000đ/sms",
            "7. Otpfb.com - ",
            "8. Winmail.shop - ",
            "9. Ahasim - 1000đ/sms",
            "Updating ..."});
            this.cbDvSim.Location = new System.Drawing.Point(151, 5);
            this.cbDvSim.Name = "cbDvSim";
            this.cbDvSim.Size = new System.Drawing.Size(254, 26);
            this.cbDvSim.TabIndex = 2;
            // 
            // txtAPISim
            // 
            this.txtAPISim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPISim.Location = new System.Drawing.Point(59, 39);
            this.txtAPISim.Name = "txtAPISim";
            this.txtAPISim.Size = new System.Drawing.Size(325, 24);
            this.txtAPISim.TabIndex = 2;
            // 
            // rdThuePhone
            // 
            this.rdThuePhone.AutoSize = true;
            this.rdThuePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThuePhone.Location = new System.Drawing.Point(10, 119);
            this.rdThuePhone.Name = "rdThuePhone";
            this.rdThuePhone.Size = new System.Drawing.Size(150, 22);
            this.rdThuePhone.TabIndex = 1;
            this.rdThuePhone.Text = "Thuê số điện thoại";
            this.rdThuePhone.UseVisualStyleBackColor = true;
            this.rdThuePhone.CheckedChanged += new System.EventHandler(this.rdThuePhone_CheckedChanged);
            // 
            // rdNoVeri
            // 
            this.rdNoVeri.AutoSize = true;
            this.rdNoVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNoVeri.Location = new System.Drawing.Point(10, 10);
            this.rdNoVeri.Name = "rdNoVeri";
            this.rdNoVeri.Size = new System.Drawing.Size(135, 22);
            this.rdNoVeri.TabIndex = 1;
            this.rdNoVeri.Text = "Không xác minh";
            this.rdNoVeri.UseVisualStyleBackColor = true;
            this.rdNoVeri.CheckedChanged += new System.EventHandler(this.rdNoVeri_CheckedChanged);
            // 
            // cbbPrePhone
            // 
            this.cbbPrePhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrePhone.FormattingEnabled = true;
            this.cbbPrePhone.Items.AddRange(new object[] {
            "VN",
            "USA"});
            this.cbbPrePhone.Location = new System.Drawing.Point(424, 9);
            this.cbbPrePhone.Name = "cbbPrePhone";
            this.cbbPrePhone.Size = new System.Drawing.Size(89, 26);
            this.cbbPrePhone.TabIndex = 2;
            this.cbbPrePhone.Visible = false;
            this.cbbPrePhone.SelectedIndexChanged += new System.EventHandler(this.cbbPrePhone_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox5.Location = new System.Drawing.Point(6, 364);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(585, 443);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cấu hình đổi IP";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.tabProxy);
            this.panel5.Controls.Add(this.plCheckDoiIP);
            this.panel5.Controls.Add(this.rdProxy);
            this.panel5.Controls.Add(this.plChangeIPDcom);
            this.panel5.Controls.Add(this.rdHMA);
            this.panel5.Controls.Add(this.rdChangeIPDcom);
            this.panel5.Controls.Add(this.rdNoChangeIP);
            this.panel5.Location = new System.Drawing.Point(3, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 417);
            this.panel5.TabIndex = 7;
            // 
            // tabProxy
            // 
            this.tabProxy.Controls.Add(this.tabPage1);
            this.tabProxy.Controls.Add(this.tabPage2);
            this.tabProxy.Controls.Add(this.tabPage3);
            this.tabProxy.Controls.Add(this.tabPage4);
            this.tabProxy.Controls.Add(this.tabPage5);
            this.tabProxy.Controls.Add(this.tabPage8);
            this.tabProxy.Controls.Add(this.tabPage9);
            this.tabProxy.Controls.Add(this.Proxyv6);
            this.tabProxy.Location = new System.Drawing.Point(30, 113);
            this.tabProxy.Name = "tabProxy";
            this.tabProxy.SelectedIndex = 0;
            this.tabProxy.Size = new System.Drawing.Size(566, 372);
            this.tabProxy.TabIndex = 157;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.plTinsoftProxy);
            this.tabPage1.Controls.Add(this.rdTinsoftProxy);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tinsoft";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(186, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 18);
            this.linkLabel1.TabIndex = 159;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://tinsoftproxy.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // plTinsoftProxy
            // 
            this.plTinsoftProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTinsoftProxy.Controls.Add(this.nudLuongPerIPTinsoft);
            this.plTinsoftProxy.Controls.Add(this.btnCheckProxy);
            this.plTinsoftProxy.Controls.Add(this.label16);
            this.plTinsoftProxy.Controls.Add(this.label29);
            this.plTinsoftProxy.Controls.Add(this.label15);
            this.plTinsoftProxy.Controls.Add(this.txtProxy);
            this.plTinsoftProxy.Controls.Add(this.cbLocationProxy);
            this.plTinsoftProxy.Location = new System.Drawing.Point(19, 45);
            this.plTinsoftProxy.Name = "plTinsoftProxy";
            this.plTinsoftProxy.Size = new System.Drawing.Size(452, 109);
            this.plTinsoftProxy.TabIndex = 158;
            // 
            // nudLuongPerIPTinsoft
            // 
            this.nudLuongPerIPTinsoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLuongPerIPTinsoft.Location = new System.Drawing.Point(285, 58);
            this.nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
            this.nudLuongPerIPTinsoft.Size = new System.Drawing.Size(55, 24);
            this.nudLuongPerIPTinsoft.TabIndex = 1;
            // 
            // btnCheckProxy
            // 
            this.btnCheckProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckProxy.Location = new System.Drawing.Point(272, 5);
            this.btnCheckProxy.Name = "btnCheckProxy";
            this.btnCheckProxy.Size = new System.Drawing.Size(101, 34);
            this.btnCheckProxy.TabIndex = 3;
            this.btnCheckProxy.Text = "Check";
            this.btnCheckProxy.UseVisualStyleBackColor = true;
            this.btnCheckProxy.Click += new System.EventHandler(this.btnCheckProxy_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(176, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Số luồng/IP:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(5, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(94, 18);
            this.label29.TabIndex = 6;
            this.label29.Text = "API key user:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Vị trí:";
            // 
            // txtProxy
            // 
            this.txtProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxy.Location = new System.Drawing.Point(108, 10);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(149, 24);
            this.txtProxy.TabIndex = 2;
            // 
            // cbLocationProxy
            // 
            this.cbLocationProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocationProxy.FormattingEnabled = true;
            this.cbLocationProxy.Location = new System.Drawing.Point(50, 58);
            this.cbLocationProxy.Name = "cbLocationProxy";
            this.cbLocationProxy.Size = new System.Drawing.Size(110, 26);
            this.cbLocationProxy.TabIndex = 2;
            // 
            // rdTinsoftProxy
            // 
            this.rdTinsoftProxy.AutoSize = true;
            this.rdTinsoftProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTinsoftProxy.Location = new System.Drawing.Point(22, 17);
            this.rdTinsoftProxy.Name = "rdTinsoftProxy";
            this.rdTinsoftProxy.Size = new System.Drawing.Size(134, 22);
            this.rdTinsoftProxy.TabIndex = 157;
            this.rdTinsoftProxy.Text = "Proxy Tinsoft:";
            this.rdTinsoftProxy.UseVisualStyleBackColor = true;
            this.rdTinsoftProxy.CheckedChanged += new System.EventHandler(this.rdTinsoftProxy_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Controls.Add(this.pnlAPIMinProxy);
            this.tabPage2.Controls.Add(this.rdMinProxy);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MinProxy - IPV6 động";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(311, 16);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(155, 18);
            this.linkLabel2.TabIndex = 159;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://minproxy.vn/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pnlAPIMinProxy
            // 
            this.pnlAPIMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAPIMinProxy.Controls.Add(this.btnCheckAPIMinProxy);
            this.pnlAPIMinProxy.Controls.Add(this.txtApiKeyMinProxy);
            this.pnlAPIMinProxy.Controls.Add(this.lblAPIMinKey);
            this.pnlAPIMinProxy.Controls.Add(this.label32);
            this.pnlAPIMinProxy.Controls.Add(this.label50);
            this.pnlAPIMinProxy.Controls.Add(this.nudLuongPerIPMinProxy);
            this.pnlAPIMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlAPIMinProxy.Location = new System.Drawing.Point(24, 46);
            this.pnlAPIMinProxy.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAPIMinProxy.Name = "pnlAPIMinProxy";
            this.pnlAPIMinProxy.Size = new System.Drawing.Size(443, 288);
            this.pnlAPIMinProxy.TabIndex = 158;
            // 
            // btnCheckAPIMinProxy
            // 
            this.btnCheckAPIMinProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAPIMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckAPIMinProxy.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAPIMinProxy.Location = new System.Drawing.Point(212, 209);
            this.btnCheckAPIMinProxy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckAPIMinProxy.Name = "btnCheckAPIMinProxy";
            this.btnCheckAPIMinProxy.Size = new System.Drawing.Size(69, 33);
            this.btnCheckAPIMinProxy.TabIndex = 145;
            this.btnCheckAPIMinProxy.Text = "Check";
            this.btnCheckAPIMinProxy.UseVisualStyleBackColor = true;
            this.btnCheckAPIMinProxy.Click += new System.EventHandler(this.btnCheckAPIMinProxy_Click);
            // 
            // txtApiKeyMinProxy
            // 
            this.txtApiKeyMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiKeyMinProxy.Location = new System.Drawing.Point(8, 28);
            this.txtApiKeyMinProxy.Margin = new System.Windows.Forms.Padding(4);
            this.txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
            this.txtApiKeyMinProxy.Size = new System.Drawing.Size(424, 171);
            this.txtApiKeyMinProxy.TabIndex = 144;
            this.txtApiKeyMinProxy.Text = "";
            this.txtApiKeyMinProxy.WordWrap = false;
            this.txtApiKeyMinProxy.TextChanged += new System.EventHandler(this.txtApiKeyMinProxy_TextChanged);
            // 
            // lblAPIMinKey
            // 
            this.lblAPIMinKey.AutoSize = true;
            this.lblAPIMinKey.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAPIMinKey.Location = new System.Drawing.Point(4, 2);
            this.lblAPIMinKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPIMinKey.Name = "lblAPIMinKey";
            this.lblAPIMinKey.Size = new System.Drawing.Size(148, 21);
            this.lblAPIMinKey.TabIndex = 79;
            this.lblAPIMinKey.Text = "Nhập API KEY (0):";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(6, 255);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(166, 21);
            this.label32.TabIndex = 139;
            this.label32.Text = "(Mỗi API key 1 dòng)";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label50.Location = new System.Drawing.Point(4, 213);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(101, 21);
            this.label50.TabIndex = 139;
            this.label50.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPMinProxy
            // 
            this.nudLuongPerIPMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPMinProxy.Location = new System.Drawing.Point(117, 211);
            this.nudLuongPerIPMinProxy.Margin = new System.Windows.Forms.Padding(4);
            this.nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
            this.nudLuongPerIPMinProxy.Size = new System.Drawing.Size(89, 27);
            this.nudLuongPerIPMinProxy.TabIndex = 140;
            this.nudLuongPerIPMinProxy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdMinProxy
            // 
            this.rdMinProxy.AutoSize = true;
            this.rdMinProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMinProxy.Location = new System.Drawing.Point(24, 14);
            this.rdMinProxy.Name = "rdMinProxy";
            this.rdMinProxy.Size = new System.Drawing.Size(255, 22);
            this.rdMinProxy.TabIndex = 157;
            this.rdMinProxy.Text = "MinProxy.vn: Proxy IPV6 động";
            this.rdMinProxy.UseVisualStyleBackColor = true;
            this.rdMinProxy.CheckedChanged += new System.EventHandler(this.rdMinProxy_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlIpPort);
            this.tabPage3.Controls.Add(this.rdIPPortUserPass);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(558, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proxy có sẵn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlIpPort
            // 
            this.pnlIpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIpPort.Controls.Add(this.cbbTypeProxyIP);
            this.pnlIpPort.Controls.Add(this.label33);
            this.pnlIpPort.Controls.Add(this.label31);
            this.pnlIpPort.Controls.Add(this.rdIPDong);
            this.pnlIpPort.Controls.Add(this.rdIPStatic);
            this.pnlIpPort.Controls.Add(this.label34);
            this.pnlIpPort.Controls.Add(this.label30);
            this.pnlIpPort.Controls.Add(this.txtListProxyIp);
            this.pnlIpPort.Controls.Add(this.lblListProxyIP);
            this.pnlIpPort.Location = new System.Drawing.Point(10, 43);
            this.pnlIpPort.Name = "pnlIpPort";
            this.pnlIpPort.Size = new System.Drawing.Size(476, 291);
            this.pnlIpPort.TabIndex = 159;
            // 
            // cbbTypeProxyIP
            // 
            this.cbbTypeProxyIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxyIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxyIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxyIP.FormattingEnabled = true;
            this.cbbTypeProxyIP.Items.AddRange(new object[] {
            "HTTP và HTTPs",
            "Sock5"});
            this.cbbTypeProxyIP.Location = new System.Drawing.Point(111, 4);
            this.cbbTypeProxyIP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeProxyIP.Name = "cbbTypeProxyIP";
            this.cbbTypeProxyIP.Size = new System.Drawing.Size(171, 27);
            this.cbbTypeProxyIP.TabIndex = 127;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(304, 8);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(163, 20);
            this.label33.TabIndex = 124;
            this.label33.Text = "(1 tài khoản/1 Proxy)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(308, 63);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(148, 20);
            this.label31.TabIndex = 124;
            this.label31.Text = "(Mỗi proxy 1 dòng)";
            // 
            // rdIPDong
            // 
            this.rdIPDong.AutoSize = true;
            this.rdIPDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIPDong.Location = new System.Drawing.Point(166, 36);
            this.rdIPDong.Name = "rdIPDong";
            this.rdIPDong.Size = new System.Drawing.Size(69, 22);
            this.rdIPDong.TabIndex = 10;
            this.rdIPDong.TabStop = true;
            this.rdIPDong.Text = "Động";
            this.rdIPDong.UseVisualStyleBackColor = true;
            this.rdIPDong.CheckedChanged += new System.EventHandler(this.rdIPDong_CheckedChanged);
            // 
            // rdIPStatic
            // 
            this.rdIPStatic.AutoSize = true;
            this.rdIPStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIPStatic.Location = new System.Drawing.Point(90, 36);
            this.rdIPStatic.Name = "rdIPStatic";
            this.rdIPStatic.Size = new System.Drawing.Size(61, 22);
            this.rdIPStatic.TabIndex = 10;
            this.rdIPStatic.TabStop = true;
            this.rdIPStatic.Text = "Tĩnh";
            this.rdIPStatic.UseVisualStyleBackColor = true;
            this.rdIPStatic.CheckedChanged += new System.EventHandler(this.rdIPStatic_CheckedChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 38);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 20);
            this.label34.TabIndex = 124;
            this.label34.Text = "Kiểu IP:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(5, 8);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(93, 20);
            this.label30.TabIndex = 124;
            this.label30.Text = "Loại Proxy:";
            // 
            // txtListProxyIp
            // 
            this.txtListProxyIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListProxyIp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListProxyIp.Location = new System.Drawing.Point(9, 90);
            this.txtListProxyIp.Margin = new System.Windows.Forms.Padding(4);
            this.txtListProxyIp.Name = "txtListProxyIp";
            this.txtListProxyIp.Size = new System.Drawing.Size(453, 218);
            this.txtListProxyIp.TabIndex = 119;
            this.txtListProxyIp.Text = "";
            this.txtListProxyIp.WordWrap = false;
            this.txtListProxyIp.TextChanged += new System.EventHandler(this.txtListProxyIp_TextChanged);
            // 
            // lblListProxyIP
            // 
            this.lblListProxyIP.AutoSize = true;
            this.lblListProxyIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProxyIP.Location = new System.Drawing.Point(5, 63);
            this.lblListProxyIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListProxyIP.Name = "lblListProxyIP";
            this.lblListProxyIP.Size = new System.Drawing.Size(168, 20);
            this.lblListProxyIP.TabIndex = 7;
            this.lblListProxyIP.Text = "Danh sách Proxy (0):";
            // 
            // rdIPPortUserPass
            // 
            this.rdIPPortUserPass.AutoSize = true;
            this.rdIPPortUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIPPortUserPass.Location = new System.Drawing.Point(19, 15);
            this.rdIPPortUserPass.Name = "rdIPPortUserPass";
            this.rdIPPortUserPass.Size = new System.Drawing.Size(301, 22);
            this.rdIPPortUserPass.TabIndex = 158;
            this.rdIPPortUserPass.Text = "IP:Port hoặc IP:Port:User:Password";
            this.rdIPPortUserPass.UseVisualStyleBackColor = true;
            this.rdIPPortUserPass.CheckedChanged += new System.EventHandler(this.rdIPPortUserPass_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(558, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xproxy, Mobi, OBC, Eager, S Proxy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plXproxy);
            this.panel1.Controls.Add(this.rbXproxy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 335);
            this.panel1.TabIndex = 0;
            // 
            // plXproxy
            // 
            this.plXproxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plXproxy.Controls.Add(this.panel8);
            this.plXproxy.Controls.Add(this.ckbWaitDoneAllXproxy);
            this.plXproxy.Controls.Add(this.txtListXProxy);
            this.plXproxy.Controls.Add(this.rbSock5Proxy);
            this.plXproxy.Controls.Add(this.rbHttpProxy);
            this.plXproxy.Controls.Add(this.label35);
            this.plXproxy.Controls.Add(this.lblCountXproxy);
            this.plXproxy.Controls.Add(this.label52);
            this.plXproxy.Controls.Add(this.label51);
            this.plXproxy.Controls.Add(this.label39);
            this.plXproxy.Controls.Add(this.label37);
            this.plXproxy.Controls.Add(this.nudDelayResetXProxy);
            this.plXproxy.Controls.Add(this.nudLuongPerIPXProxy);
            this.plXproxy.Controls.Add(this.label38);
            this.plXproxy.Controls.Add(this.txtServiceURLXProxy);
            this.plXproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plXproxy.Location = new System.Drawing.Point(7, 35);
            this.plXproxy.Margin = new System.Windows.Forms.Padding(4);
            this.plXproxy.Name = "plXproxy";
            this.plXproxy.Size = new System.Drawing.Size(512, 296);
            this.plXproxy.TabIndex = 144;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label53);
            this.panel8.Controls.Add(this.rbXproxyResetAllProxy);
            this.panel8.Controls.Add(this.rbXproxyResetEachProxy);
            this.panel8.Location = new System.Drawing.Point(216, 127);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 67);
            this.panel8.TabIndex = 152;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label53.Location = new System.Drawing.Point(1, 7);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(107, 21);
            this.label53.TabIndex = 155;
            this.label53.Text = "Chế độ chạy:";
            // 
            // rbXproxyResetAllProxy
            // 
            this.rbXproxyResetAllProxy.AutoSize = true;
            this.rbXproxyResetAllProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXproxyResetAllProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbXproxyResetAllProxy.Location = new System.Drawing.Point(120, 36);
            this.rbXproxyResetAllProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbXproxyResetAllProxy.Name = "rbXproxyResetAllProxy";
            this.rbXproxyResetAllProxy.Size = new System.Drawing.Size(167, 25);
            this.rbXproxyResetAllProxy.TabIndex = 153;
            this.rbXproxyResetAllProxy.Text = "Reset tất cả proxy";
            this.rbXproxyResetAllProxy.UseVisualStyleBackColor = true;
            // 
            // rbXproxyResetEachProxy
            // 
            this.rbXproxyResetEachProxy.AutoSize = true;
            this.rbXproxyResetEachProxy.Checked = true;
            this.rbXproxyResetEachProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXproxyResetEachProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbXproxyResetEachProxy.Location = new System.Drawing.Point(120, 9);
            this.rbXproxyResetEachProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbXproxyResetEachProxy.Name = "rbXproxyResetEachProxy";
            this.rbXproxyResetEachProxy.Size = new System.Drawing.Size(158, 25);
            this.rbXproxyResetEachProxy.TabIndex = 154;
            this.rbXproxyResetEachProxy.TabStop = true;
            this.rbXproxyResetEachProxy.Text = "Reset từng proxy";
            this.rbXproxyResetEachProxy.UseVisualStyleBackColor = true;
            // 
            // ckbWaitDoneAllXproxy
            // 
            this.ckbWaitDoneAllXproxy.AutoSize = true;
            this.ckbWaitDoneAllXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWaitDoneAllXproxy.Location = new System.Drawing.Point(289, 34);
            this.ckbWaitDoneAllXproxy.Margin = new System.Windows.Forms.Padding(4);
            this.ckbWaitDoneAllXproxy.Name = "ckbWaitDoneAllXproxy";
            this.ckbWaitDoneAllXproxy.Size = new System.Drawing.Size(165, 25);
            this.ckbWaitDoneAllXproxy.TabIndex = 145;
            this.ckbWaitDoneAllXproxy.Text = "Đợi chạy xong hết";
            this.ckbWaitDoneAllXproxy.UseVisualStyleBackColor = true;
            // 
            // txtListXProxy
            // 
            this.txtListXProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListXProxy.Location = new System.Drawing.Point(8, 87);
            this.txtListXProxy.Margin = new System.Windows.Forms.Padding(4);
            this.txtListXProxy.Name = "txtListXProxy";
            this.txtListXProxy.Size = new System.Drawing.Size(200, 203);
            this.txtListXProxy.TabIndex = 144;
            this.txtListXProxy.Text = "";
            this.txtListXProxy.WordWrap = false;
            this.txtListXProxy.TextChanged += new System.EventHandler(this.txtListXProxy_TextChanged);
            // 
            // rbSock5Proxy
            // 
            this.rbSock5Proxy.AutoSize = true;
            this.rbSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSock5Proxy.Location = new System.Drawing.Point(201, 33);
            this.rbSock5Proxy.Margin = new System.Windows.Forms.Padding(4);
            this.rbSock5Proxy.Name = "rbSock5Proxy";
            this.rbSock5Proxy.Size = new System.Drawing.Size(74, 25);
            this.rbSock5Proxy.TabIndex = 82;
            this.rbSock5Proxy.Text = "Sock5";
            this.rbSock5Proxy.UseVisualStyleBackColor = true;
            // 
            // rbHttpProxy
            // 
            this.rbHttpProxy.AutoSize = true;
            this.rbHttpProxy.Checked = true;
            this.rbHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHttpProxy.Location = new System.Drawing.Point(120, 34);
            this.rbHttpProxy.Margin = new System.Windows.Forms.Padding(4);
            this.rbHttpProxy.Name = "rbHttpProxy";
            this.rbHttpProxy.Size = new System.Drawing.Size(63, 25);
            this.rbHttpProxy.TabIndex = 82;
            this.rbHttpProxy.TabStop = true;
            this.rbHttpProxy.Text = "Http";
            this.rbHttpProxy.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(4, 34);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 21);
            this.label35.TabIndex = 79;
            this.label35.Text = "Loại Proxy:";
            // 
            // lblCountXproxy
            // 
            this.lblCountXproxy.AutoSize = true;
            this.lblCountXproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountXproxy.Location = new System.Drawing.Point(4, 62);
            this.lblCountXproxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountXproxy.Name = "lblCountXproxy";
            this.lblCountXproxy.Size = new System.Drawing.Size(127, 21);
            this.lblCountXproxy.TabIndex = 79;
            this.lblCountXproxy.Text = "Nhập Proxy (0):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label52.Location = new System.Drawing.Point(525, 127);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(43, 21);
            this.label52.TabIndex = 139;
            this.label52.Text = "phút";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label51.Location = new System.Drawing.Point(213, 100);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(180, 21);
            this.label51.TabIndex = 139;
            this.label51.Text = "Chờ reset proxy tối đa:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label39.Location = new System.Drawing.Point(454, 133);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(43, 21);
            this.label39.TabIndex = 139;
            this.label39.Text = "phút";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.Location = new System.Drawing.Point(213, 64);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(101, 21);
            this.label37.TabIndex = 139;
            this.label37.Text = "Số luồng/IP:";
            // 
            // nudDelayResetXProxy
            // 
            this.nudDelayResetXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudDelayResetXProxy.Location = new System.Drawing.Point(396, 97);
            this.nudDelayResetXProxy.Margin = new System.Windows.Forms.Padding(4);
            this.nudDelayResetXProxy.Name = "nudDelayResetXProxy";
            this.nudDelayResetXProxy.Size = new System.Drawing.Size(50, 27);
            this.nudDelayResetXProxy.TabIndex = 140;
            this.nudDelayResetXProxy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLuongPerIPXProxy
            // 
            this.nudLuongPerIPXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPXProxy.Location = new System.Drawing.Point(326, 63);
            this.nudLuongPerIPXProxy.Margin = new System.Windows.Forms.Padding(4);
            this.nudLuongPerIPXProxy.Name = "nudLuongPerIPXProxy";
            this.nudLuongPerIPXProxy.Size = new System.Drawing.Size(58, 27);
            this.nudLuongPerIPXProxy.TabIndex = 140;
            this.nudLuongPerIPXProxy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(4, 6);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(104, 21);
            this.label38.TabIndex = 79;
            this.label38.Text = "Service URL:";
            // 
            // txtServiceURLXProxy
            // 
            this.txtServiceURLXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtServiceURLXProxy.ForeColor = System.Drawing.Color.Black;
            this.txtServiceURLXProxy.Location = new System.Drawing.Point(120, 2);
            this.txtServiceURLXProxy.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceURLXProxy.Name = "txtServiceURLXProxy";
            this.txtServiceURLXProxy.Size = new System.Drawing.Size(355, 27);
            this.txtServiceURLXProxy.TabIndex = 81;
            // 
            // rbXproxy
            // 
            this.rbXproxy.AutoSize = true;
            this.rbXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbXproxy.Location = new System.Drawing.Point(9, 5);
            this.rbXproxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbXproxy.Name = "rbXproxy";
            this.rbXproxy.Size = new System.Drawing.Size(285, 25);
            this.rbXproxy.TabIndex = 143;
            this.rbXproxy.Text = "Xproxy, Mobi, OBC, Eager, S Proxy";
            this.rbXproxy.UseVisualStyleBackColor = true;
            this.rbXproxy.CheckedChanged += new System.EventHandler(this.rbXproxy_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.linkLabel3);
            this.tabPage5.Controls.Add(this.plTMProxy);
            this.tabPage5.Controls.Add(this.rbTMProxy);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(558, 341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "TMProxy";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(128, 17);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(158, 18);
            this.linkLabel3.TabIndex = 160;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://tmproxy.com";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // plTMProxy
            // 
            this.plTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTMProxy.Controls.Add(this.btnCheckTMProxy);
            this.plTMProxy.Controls.Add(this.txtApiKeyTMProxy);
            this.plTMProxy.Controls.Add(this.lblCountTmProxy);
            this.plTMProxy.Controls.Add(this.label42);
            this.plTMProxy.Controls.Add(this.nudLuongPerIPTMProxy);
            this.plTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTMProxy.Location = new System.Drawing.Point(19, 46);
            this.plTMProxy.Margin = new System.Windows.Forms.Padding(4);
            this.plTMProxy.Name = "plTMProxy";
            this.plTMProxy.Size = new System.Drawing.Size(488, 288);
            this.plTMProxy.TabIndex = 148;
            // 
            // btnCheckTMProxy
            // 
            this.btnCheckTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckTMProxy.ForeColor = System.Drawing.Color.Black;
            this.btnCheckTMProxy.Location = new System.Drawing.Point(226, 233);
            this.btnCheckTMProxy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckTMProxy.Name = "btnCheckTMProxy";
            this.btnCheckTMProxy.Size = new System.Drawing.Size(69, 33);
            this.btnCheckTMProxy.TabIndex = 145;
            this.btnCheckTMProxy.Text = "Check";
            this.btnCheckTMProxy.UseVisualStyleBackColor = true;
            this.btnCheckTMProxy.Click += new System.EventHandler(this.btnCheckTMProxy_Click);
            // 
            // txtApiKeyTMProxy
            // 
            this.txtApiKeyTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiKeyTMProxy.Location = new System.Drawing.Point(8, 28);
            this.txtApiKeyTMProxy.Margin = new System.Windows.Forms.Padding(4);
            this.txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
            this.txtApiKeyTMProxy.Size = new System.Drawing.Size(470, 197);
            this.txtApiKeyTMProxy.TabIndex = 144;
            this.txtApiKeyTMProxy.Text = "";
            this.txtApiKeyTMProxy.WordWrap = false;
            this.txtApiKeyTMProxy.TextChanged += new System.EventHandler(this.txtApiKeyTMProxy_TextChanged);
            // 
            // lblCountTmProxy
            // 
            this.lblCountTmProxy.AutoSize = true;
            this.lblCountTmProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountTmProxy.Location = new System.Drawing.Point(4, 2);
            this.lblCountTmProxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountTmProxy.Name = "lblCountTmProxy";
            this.lblCountTmProxy.Size = new System.Drawing.Size(148, 21);
            this.lblCountTmProxy.TabIndex = 79;
            this.lblCountTmProxy.Text = "Nhập API KEY (0):";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label42.Location = new System.Drawing.Point(5, 238);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 21);
            this.label42.TabIndex = 139;
            this.label42.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPTMProxy
            // 
            this.nudLuongPerIPTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPTMProxy.Location = new System.Drawing.Point(118, 237);
            this.nudLuongPerIPTMProxy.Margin = new System.Windows.Forms.Padding(4);
            this.nudLuongPerIPTMProxy.Name = "nudLuongPerIPTMProxy";
            this.nudLuongPerIPTMProxy.Size = new System.Drawing.Size(89, 27);
            this.nudLuongPerIPTMProxy.TabIndex = 140;
            this.nudLuongPerIPTMProxy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbTMProxy
            // 
            this.rbTMProxy.AutoSize = true;
            this.rbTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTMProxy.Location = new System.Drawing.Point(19, 12);
            this.rbTMProxy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTMProxy.Name = "rbTMProxy";
            this.rbTMProxy.Size = new System.Drawing.Size(94, 25);
            this.rbTMProxy.TabIndex = 147;
            this.rbTMProxy.Text = "TMProxy";
            this.rbTMProxy.UseVisualStyleBackColor = true;
            this.rbTMProxy.CheckedChanged += new System.EventHandler(this.rbTMProxy_CheckedChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.lnkShopLike);
            this.tabPage8.Controls.Add(this.plProxyShopLike);
            this.tabPage8.Controls.Add(this.rbProxyShoplike);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(558, 341);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Proxy.Shoplike";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // lnkShopLike
            // 
            this.lnkShopLike.AutoSize = true;
            this.lnkShopLike.Location = new System.Drawing.Point(217, 14);
            this.lnkShopLike.Name = "lnkShopLike";
            this.lnkShopLike.Size = new System.Drawing.Size(196, 18);
            this.lnkShopLike.TabIndex = 163;
            this.lnkShopLike.TabStop = true;
            this.lnkShopLike.Text = "https://proxy.shoplike.vn/";
            this.lnkShopLike.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShopLike_LinkClicked);
            // 
            // plProxyShopLike
            // 
            this.plProxyShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plProxyShopLike.Controls.Add(this.txtAPIKeyShoplike);
            this.plProxyShopLike.Controls.Add(this.lblAPIKeyShopLike);
            this.plProxyShopLike.Controls.Add(this.label47);
            this.plProxyShopLike.Controls.Add(this.nudThreadShopLike);
            this.plProxyShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plProxyShopLike.Location = new System.Drawing.Point(20, 43);
            this.plProxyShopLike.Margin = new System.Windows.Forms.Padding(4);
            this.plProxyShopLike.Name = "plProxyShopLike";
            this.plProxyShopLike.Size = new System.Drawing.Size(488, 288);
            this.plProxyShopLike.TabIndex = 162;
            // 
            // txtAPIKeyShoplike
            // 
            this.txtAPIKeyShoplike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPIKeyShoplike.Location = new System.Drawing.Point(8, 28);
            this.txtAPIKeyShoplike.Margin = new System.Windows.Forms.Padding(4);
            this.txtAPIKeyShoplike.Name = "txtAPIKeyShoplike";
            this.txtAPIKeyShoplike.Size = new System.Drawing.Size(470, 201);
            this.txtAPIKeyShoplike.TabIndex = 144;
            this.txtAPIKeyShoplike.Text = "";
            this.txtAPIKeyShoplike.WordWrap = false;
            this.txtAPIKeyShoplike.TextChanged += new System.EventHandler(this.txtAPIKeyShoplike_TextChanged);
            // 
            // lblAPIKeyShopLike
            // 
            this.lblAPIKeyShopLike.AutoSize = true;
            this.lblAPIKeyShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAPIKeyShopLike.Location = new System.Drawing.Point(4, 2);
            this.lblAPIKeyShopLike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPIKeyShopLike.Name = "lblAPIKeyShopLike";
            this.lblAPIKeyShopLike.Size = new System.Drawing.Size(148, 21);
            this.lblAPIKeyShopLike.TabIndex = 79;
            this.lblAPIKeyShopLike.Text = "Nhập API KEY (0):";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label47.Location = new System.Drawing.Point(5, 238);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(101, 21);
            this.label47.TabIndex = 139;
            this.label47.Text = "Số luồng/IP:";
            // 
            // nudThreadShopLike
            // 
            this.nudThreadShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudThreadShopLike.Location = new System.Drawing.Point(118, 237);
            this.nudThreadShopLike.Margin = new System.Windows.Forms.Padding(4);
            this.nudThreadShopLike.Name = "nudThreadShopLike";
            this.nudThreadShopLike.Size = new System.Drawing.Size(89, 27);
            this.nudThreadShopLike.TabIndex = 140;
            this.nudThreadShopLike.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbProxyShoplike
            // 
            this.rbProxyShoplike.AutoSize = true;
            this.rbProxyShoplike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProxyShoplike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbProxyShoplike.Location = new System.Drawing.Point(20, 9);
            this.rbProxyShoplike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbProxyShoplike.Name = "rbProxyShoplike";
            this.rbProxyShoplike.Size = new System.Drawing.Size(158, 25);
            this.rbProxyShoplike.TabIndex = 161;
            this.rbProxyShoplike.Text = "proxy.shoplike.vn";
            this.rbProxyShoplike.UseVisualStyleBackColor = true;
            this.rbProxyShoplike.CheckedChanged += new System.EventHandler(this.rbProxyShoplike_CheckedChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.pnlProxyFree);
            this.tabPage9.Controls.Add(this.rdProxyOrbit);
            this.tabPage9.Location = new System.Drawing.Point(4, 27);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(558, 341);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "Proxy Free";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // pnlProxyFree
            // 
            this.pnlProxyFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProxyFree.Controls.Add(this.rdProxyFreeRandom);
            this.pnlProxyFree.Controls.Add(this.rdProxyFreeUS);
            this.pnlProxyFree.Controls.Add(this.rdProxyFreeVN);
            this.pnlProxyFree.Location = new System.Drawing.Point(19, 45);
            this.pnlProxyFree.Name = "pnlProxyFree";
            this.pnlProxyFree.Size = new System.Drawing.Size(494, 56);
            this.pnlProxyFree.TabIndex = 163;
            // 
            // rdProxyFreeRandom
            // 
            this.rdProxyFreeRandom.AutoSize = true;
            this.rdProxyFreeRandom.Location = new System.Drawing.Point(297, 14);
            this.rdProxyFreeRandom.Name = "rdProxyFreeRandom";
            this.rdProxyFreeRandom.Size = new System.Drawing.Size(161, 22);
            this.rdProxyFreeRandom.TabIndex = 0;
            this.rdProxyFreeRandom.TabStop = true;
            this.rdProxyFreeRandom.Text = "Proxy Ngẫu nhiên";
            this.rdProxyFreeRandom.UseVisualStyleBackColor = true;
            // 
            // rdProxyFreeUS
            // 
            this.rdProxyFreeUS.AutoSize = true;
            this.rdProxyFreeUS.Location = new System.Drawing.Point(158, 14);
            this.rdProxyFreeUS.Name = "rdProxyFreeUS";
            this.rdProxyFreeUS.Size = new System.Drawing.Size(100, 22);
            this.rdProxyFreeUS.TabIndex = 0;
            this.rdProxyFreeUS.TabStop = true;
            this.rdProxyFreeUS.Text = "Proxy US";
            this.rdProxyFreeUS.UseVisualStyleBackColor = true;
            // 
            // rdProxyFreeVN
            // 
            this.rdProxyFreeVN.AutoSize = true;
            this.rdProxyFreeVN.Location = new System.Drawing.Point(24, 14);
            this.rdProxyFreeVN.Name = "rdProxyFreeVN";
            this.rdProxyFreeVN.Size = new System.Drawing.Size(99, 22);
            this.rdProxyFreeVN.TabIndex = 0;
            this.rdProxyFreeVN.TabStop = true;
            this.rdProxyFreeVN.Text = "Proxy VN";
            this.rdProxyFreeVN.UseVisualStyleBackColor = true;
            // 
            // rdProxyOrbit
            // 
            this.rdProxyOrbit.AutoSize = true;
            this.rdProxyOrbit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdProxyOrbit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdProxyOrbit.Location = new System.Drawing.Point(19, 19);
            this.rdProxyOrbit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdProxyOrbit.Name = "rdProxyOrbit";
            this.rdProxyOrbit.Size = new System.Drawing.Size(105, 25);
            this.rdProxyOrbit.TabIndex = 162;
            this.rdProxyOrbit.Text = "Proxy free";
            this.rdProxyOrbit.UseVisualStyleBackColor = true;
            this.rdProxyOrbit.CheckedChanged += new System.EventHandler(this.rdProxyOrbit_CheckedChanged);
            // 
            // Proxyv6
            // 
            this.Proxyv6.Controls.Add(this.linkLabelprxv6);
            this.Proxyv6.Controls.Add(this.plProxyv6);
            this.Proxyv6.Controls.Add(this.rbProxyv6);
            this.Proxyv6.Location = new System.Drawing.Point(4, 27);
            this.Proxyv6.Name = "Proxyv6";
            this.Proxyv6.Padding = new System.Windows.Forms.Padding(3);
            this.Proxyv6.Size = new System.Drawing.Size(558, 341);
            this.Proxyv6.TabIndex = 7;
            this.Proxyv6.Text = "Proxyv6.net";
            this.Proxyv6.UseVisualStyleBackColor = true;
            // 
            // linkLabelprxv6
            // 
            this.linkLabelprxv6.AutoSize = true;
            this.linkLabelprxv6.Location = new System.Drawing.Point(143, 28);
            this.linkLabelprxv6.Name = "linkLabelprxv6";
            this.linkLabelprxv6.Size = new System.Drawing.Size(146, 18);
            this.linkLabelprxv6.TabIndex = 163;
            this.linkLabelprxv6.TabStop = true;
            this.linkLabelprxv6.Text = "https://proxyv6.net";
            this.linkLabelprxv6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelprxv6_LinkClicked);
            // 
            // plProxyv6
            // 
            this.plProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plProxyv6.Controls.Add(this.btnCheckProxyv6);
            this.plProxyv6.Controls.Add(this.txtApiProxyv6);
            this.plProxyv6.Controls.Add(this.lblApiProxyv6);
            this.plProxyv6.Controls.Add(this.label54);
            this.plProxyv6.Controls.Add(this.numericUpDown1);
            this.plProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plProxyv6.Location = new System.Drawing.Point(34, 57);
            this.plProxyv6.Margin = new System.Windows.Forms.Padding(4);
            this.plProxyv6.Name = "plProxyv6";
            this.plProxyv6.Size = new System.Drawing.Size(488, 288);
            this.plProxyv6.TabIndex = 162;
            // 
            // btnCheckProxyv6
            // 
            this.btnCheckProxyv6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckProxyv6.ForeColor = System.Drawing.Color.Black;
            this.btnCheckProxyv6.Location = new System.Drawing.Point(226, 233);
            this.btnCheckProxyv6.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckProxyv6.Name = "btnCheckProxyv6";
            this.btnCheckProxyv6.Size = new System.Drawing.Size(69, 33);
            this.btnCheckProxyv6.TabIndex = 145;
            this.btnCheckProxyv6.Text = "Check";
            this.btnCheckProxyv6.UseVisualStyleBackColor = true;
            this.btnCheckProxyv6.Click += new System.EventHandler(this.btnCheckProxyv6_Click);
            // 
            // txtApiProxyv6
            // 
            this.txtApiProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiProxyv6.Location = new System.Drawing.Point(8, 28);
            this.txtApiProxyv6.Margin = new System.Windows.Forms.Padding(4);
            this.txtApiProxyv6.Name = "txtApiProxyv6";
            this.txtApiProxyv6.Size = new System.Drawing.Size(470, 197);
            this.txtApiProxyv6.TabIndex = 144;
            this.txtApiProxyv6.Text = "";
            this.txtApiProxyv6.WordWrap = false;
            this.txtApiProxyv6.TextChanged += new System.EventHandler(this.txtApiProxyv6_TextChanged);
            // 
            // lblApiProxyv6
            // 
            this.lblApiProxyv6.AutoSize = true;
            this.lblApiProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblApiProxyv6.Location = new System.Drawing.Point(4, 2);
            this.lblApiProxyv6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApiProxyv6.Name = "lblApiProxyv6";
            this.lblApiProxyv6.Size = new System.Drawing.Size(148, 21);
            this.lblApiProxyv6.TabIndex = 79;
            this.lblApiProxyv6.Text = "Nhập API KEY (0):";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label54.Location = new System.Drawing.Point(5, 238);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(101, 21);
            this.label54.TabIndex = 139;
            this.label54.Text = "Số luồng/IP:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.Location = new System.Drawing.Point(118, 237);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 27);
            this.numericUpDown1.TabIndex = 140;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbProxyv6
            // 
            this.rbProxyv6.AutoSize = true;
            this.rbProxyv6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbProxyv6.Location = new System.Drawing.Point(34, 23);
            this.rbProxyv6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbProxyv6.Name = "rbProxyv6";
            this.rbProxyv6.Size = new System.Drawing.Size(88, 25);
            this.rbProxyv6.TabIndex = 161;
            this.rbProxyv6.Text = "Proxyv6";
            this.rbProxyv6.UseVisualStyleBackColor = true;
            this.rbProxyv6.CheckedChanged += new System.EventHandler(this.rbProxyv6_CheckedChanged);
            // 
            // plCheckDoiIP
            // 
            this.plCheckDoiIP.Controls.Add(this.btnTestChangeIP);
            this.plCheckDoiIP.Controls.Add(this.numChangeIP);
            this.plCheckDoiIP.Controls.Add(this.label20);
            this.plCheckDoiIP.Controls.Add(this.label21);
            this.plCheckDoiIP.Location = new System.Drawing.Point(34, 8);
            this.plCheckDoiIP.Name = "plCheckDoiIP";
            this.plCheckDoiIP.Size = new System.Drawing.Size(306, 36);
            this.plCheckDoiIP.TabIndex = 155;
            // 
            // btnTestChangeIP
            // 
            this.btnTestChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestChangeIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTestChangeIP.ForeColor = System.Drawing.Color.Black;
            this.btnTestChangeIP.Location = new System.Drawing.Point(201, 0);
            this.btnTestChangeIP.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestChangeIP.Name = "btnTestChangeIP";
            this.btnTestChangeIP.Size = new System.Drawing.Size(103, 35);
            this.btnTestChangeIP.TabIndex = 156;
            this.btnTestChangeIP.Text = "Test";
            this.btnTestChangeIP.UseVisualStyleBackColor = true;
            this.btnTestChangeIP.Click += new System.EventHandler(this.btnTestChangeIP_Click);
            // 
            // numChangeIP
            // 
            this.numChangeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChangeIP.Location = new System.Drawing.Point(84, 7);
            this.numChangeIP.Name = "numChangeIP";
            this.numChangeIP.Size = new System.Drawing.Size(55, 24);
            this.numChangeIP.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(2, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 7;
            this.label20.Text = "Đổi IP sau:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(145, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 18);
            this.label21.TabIndex = 6;
            this.label21.Text = "lần reg";
            // 
            // rdProxy
            // 
            this.rdProxy.AutoSize = true;
            this.rdProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdProxy.Location = new System.Drawing.Point(36, 84);
            this.rdProxy.Name = "rdProxy";
            this.rdProxy.Size = new System.Drawing.Size(67, 22);
            this.rdProxy.TabIndex = 10;
            this.rdProxy.TabStop = true;
            this.rdProxy.Text = "Proxy";
            this.rdProxy.UseVisualStyleBackColor = true;
            this.rdProxy.CheckedChanged += new System.EventHandler(this.rdProxy_CheckedChanged);
            // 
            // plChangeIPDcom
            // 
            this.plChangeIPDcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plChangeIPDcom.Controls.Add(this.btnGetDcom);
            this.plChangeIPDcom.Controls.Add(this.txtNameDcom);
            this.plChangeIPDcom.Controls.Add(this.button2);
            this.plChangeIPDcom.Location = new System.Drawing.Point(337, 50);
            this.plChangeIPDcom.Name = "plChangeIPDcom";
            this.plChangeIPDcom.Size = new System.Drawing.Size(349, 54);
            this.plChangeIPDcom.TabIndex = 13;
            // 
            // btnGetDcom
            // 
            this.btnGetDcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDcom.Location = new System.Drawing.Point(176, 4);
            this.btnGetDcom.Name = "btnGetDcom";
            this.btnGetDcom.Size = new System.Drawing.Size(168, 45);
            this.btnGetDcom.TabIndex = 3;
            this.btnGetDcom.Text = "Lấy tên Dcom";
            this.btnGetDcom.UseVisualStyleBackColor = true;
            this.btnGetDcom.Click += new System.EventHandler(this.btnGetDcom_Click);
            // 
            // txtNameDcom
            // 
            this.txtNameDcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDcom.Location = new System.Drawing.Point(9, 13);
            this.txtNameDcom.Name = "txtNameDcom";
            this.txtNameDcom.Size = new System.Drawing.Size(126, 24);
            this.txtNameDcom.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(208, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dont click here";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdHMA
            // 
            this.rdHMA.AutoSize = true;
            this.rdHMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHMA.Location = new System.Drawing.Point(202, 83);
            this.rdHMA.Name = "rdHMA";
            this.rdHMA.Size = new System.Drawing.Size(106, 22);
            this.rdHMA.TabIndex = 10;
            this.rdHMA.TabStop = true;
            this.rdHMA.Text = "Đổi IP HMA";
            this.rdHMA.UseVisualStyleBackColor = true;
            this.rdHMA.CheckedChanged += new System.EventHandler(this.rdHMA_CheckedChanged);
            // 
            // rdChangeIPDcom
            // 
            this.rdChangeIPDcom.AutoSize = true;
            this.rdChangeIPDcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChangeIPDcom.Location = new System.Drawing.Point(202, 50);
            this.rdChangeIPDcom.Name = "rdChangeIPDcom";
            this.rdChangeIPDcom.Size = new System.Drawing.Size(118, 22);
            this.rdChangeIPDcom.TabIndex = 10;
            this.rdChangeIPDcom.TabStop = true;
            this.rdChangeIPDcom.Text = "Đổi IP Dcom:";
            this.rdChangeIPDcom.UseVisualStyleBackColor = true;
            this.rdChangeIPDcom.CheckedChanged += new System.EventHandler(this.rdChangeIPDcom_CheckedChanged);
            // 
            // rdNoChangeIP
            // 
            this.rdNoChangeIP.AutoSize = true;
            this.rdNoChangeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNoChangeIP.Location = new System.Drawing.Point(36, 50);
            this.rdNoChangeIP.Name = "rdNoChangeIP";
            this.rdNoChangeIP.Size = new System.Drawing.Size(113, 22);
            this.rdNoChangeIP.TabIndex = 11;
            this.rdNoChangeIP.TabStop = true;
            this.rdNoChangeIP.Text = "Không đổi IP";
            this.rdNoChangeIP.UseVisualStyleBackColor = true;
            this.rdNoChangeIP.CheckedChanged += new System.EventHandler(this.rdNoChangeIP_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.txtLinkLD);
            this.groupBox4.Controls.Add(this.numDeClsTo);
            this.groupBox4.Controls.Add(this.numDeClsFr);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rdSwap);
            this.groupBox4.Controls.Add(this.rdNormal);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox4.Location = new System.Drawing.Point(7, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 200);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cấu hình LDPlayer";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numDelayTo);
            this.panel7.Controls.Add(this.rdDelayLD);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.numDelayFr);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(15, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(543, 33);
            this.panel7.TabIndex = 3;
            // 
            // numDelayTo
            // 
            this.numDelayTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelayTo.Location = new System.Drawing.Point(411, 6);
            this.numDelayTo.Name = "numDelayTo";
            this.numDelayTo.Size = new System.Drawing.Size(55, 24);
            this.numDelayTo.TabIndex = 1;
            // 
            // rdDelayLD
            // 
            this.rdDelayLD.AutoSize = true;
            this.rdDelayLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDelayLD.Location = new System.Drawing.Point(188, 6);
            this.rdDelayLD.Name = "rdDelayLD";
            this.rdDelayLD.Size = new System.Drawing.Size(96, 22);
            this.rdDelayLD.TabIndex = 1;
            this.rdDelayLD.TabStop = true;
            this.rdDelayLD.Text = "Delay mở:";
            this.rdDelayLD.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mở LDPlayer:";
            // 
            // numDelayFr
            // 
            this.numDelayFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelayFr.Location = new System.Drawing.Point(307, 6);
            this.numDelayFr.Name = "numDelayFr";
            this.numDelayFr.Size = new System.Drawing.Size(55, 24);
            this.numDelayFr.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "đến";
            // 
            // txtLinkLD
            // 
            this.txtLinkLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkLD.Location = new System.Drawing.Point(202, 168);
            this.txtLinkLD.Name = "txtLinkLD";
            this.txtLinkLD.Size = new System.Drawing.Size(320, 24);
            this.txtLinkLD.TabIndex = 2;
            // 
            // numDeClsTo
            // 
            this.numDeClsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeClsTo.Location = new System.Drawing.Point(320, 131);
            this.numDeClsTo.Name = "numDeClsTo";
            this.numDeClsTo.Size = new System.Drawing.Size(55, 24);
            this.numDeClsTo.TabIndex = 1;
            // 
            // numDeClsFr
            // 
            this.numDeClsFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeClsFr.Location = new System.Drawing.Point(203, 132);
            this.numDeClsFr.Name = "numDeClsFr";
            this.numDeClsFr.Size = new System.Drawing.Size(55, 24);
            this.numDeClsFr.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "đến";
            // 
            // rdSwap
            // 
            this.rdSwap.AutoSize = true;
            this.rdSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSwap.Location = new System.Drawing.Point(203, 57);
            this.rdSwap.Name = "rdSwap";
            this.rdSwap.Size = new System.Drawing.Size(258, 22);
            this.rdSwap.TabIndex = 1;
            this.rdSwap.TabStop = true;
            this.rdSwap.Text = "Swap (Nhiều tài khoản/1 LDPlayer)";
            this.rdSwap.UseVisualStyleBackColor = true;
            this.rdSwap.CheckedChanged += new System.EventHandler(this.rdSwap_CheckedChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNormal.Location = new System.Drawing.Point(203, 29);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(241, 22);
            this.rdNormal.TabIndex = 1;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Thường (1 tài khoản/1 LDPlayer)";
            this.rdNormal.UseVisualStyleBackColor = true;
            this.rdNormal.CheckedChanged += new System.EventHandler(this.rdNormal_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đường dẫn LDPlayer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Delay đóng LDPlayer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chế độ chạy LDPlayer:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlSoLanReg);
            this.groupBox3.Controls.Add(this.nudTimeWaitOTP);
            this.groupBox3.Controls.Add(this.numOTP);
            this.groupBox3.Controls.Add(this.numThrLdPlay);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.cbModeRunReg);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ckCheckIP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 126);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấu hình chung";
            // 
            // pnlSoLanReg
            // 
            this.pnlSoLanReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoLanReg.Controls.Add(this.nudSoLuotChay);
            this.pnlSoLanReg.Controls.Add(this.label23);
            this.pnlSoLanReg.Controls.Add(this.label24);
            this.pnlSoLanReg.Location = new System.Drawing.Point(326, 22);
            this.pnlSoLanReg.Name = "pnlSoLanReg";
            this.pnlSoLanReg.Size = new System.Drawing.Size(217, 38);
            this.pnlSoLanReg.TabIndex = 3;
            // 
            // nudSoLuotChay
            // 
            this.nudSoLuotChay.Location = new System.Drawing.Point(92, 5);
            this.nudSoLuotChay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuotChay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuotChay.Name = "nudSoLuotChay";
            this.nudSoLuotChay.Size = new System.Drawing.Size(77, 24);
            this.nudSoLuotChay.TabIndex = 1;
            this.nudSoLuotChay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 18);
            this.label23.TabIndex = 0;
            this.label23.Text = "Số lần reg:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(175, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 18);
            this.label24.TabIndex = 0;
            this.label24.Text = "lần";
            // 
            // nudTimeWaitOTP
            // 
            this.nudTimeWaitOTP.Location = new System.Drawing.Point(426, 61);
            this.nudTimeWaitOTP.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudTimeWaitOTP.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeWaitOTP.Name = "nudTimeWaitOTP";
            this.nudTimeWaitOTP.Size = new System.Drawing.Size(63, 24);
            this.nudTimeWaitOTP.TabIndex = 1;
            this.nudTimeWaitOTP.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numOTP
            // 
            this.numOTP.Location = new System.Drawing.Point(204, 91);
            this.numOTP.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOTP.Name = "numOTP";
            this.numOTP.Size = new System.Drawing.Size(77, 24);
            this.numOTP.TabIndex = 1;
            this.numOTP.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numThrLdPlay
            // 
            this.numThrLdPlay.Location = new System.Drawing.Point(204, 61);
            this.numThrLdPlay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numThrLdPlay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThrLdPlay.Name = "numThrLdPlay";
            this.numThrLdPlay.Size = new System.Drawing.Size(77, 24);
            this.numThrLdPlay.TabIndex = 1;
            this.numThrLdPlay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(502, 63);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(34, 18);
            this.label48.TabIndex = 0;
            this.label48.Text = "giây";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "giây";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(189)))), ((int)(((byte)(6)))));
            this.button1.Location = new System.Drawing.Point(-943, -131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(9, 29);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 18);
            this.label45.TabIndex = 0;
            this.label45.Text = "Chế độ chạy:";
            // 
            // cbModeRunReg
            // 
            this.cbModeRunReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeRunReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeRunReg.FormattingEnabled = true;
            this.cbModeRunReg.Items.AddRange(new object[] {
            "Theo số lần reg",
            "Theo số luồng LD"});
            this.cbModeRunReg.Location = new System.Drawing.Point(123, 26);
            this.cbModeRunReg.Name = "cbModeRunReg";
            this.cbModeRunReg.Size = new System.Drawing.Size(182, 26);
            this.cbModeRunReg.TabIndex = 2;
            this.cbModeRunReg.SelectedIndexChanged += new System.EventHandler(this.cbModeRunReg_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(298, 65);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(109, 18);
            this.label46.TabIndex = 0;
            this.label46.Text = "Time chờ OTP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian nhập OTP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số luồng chạy LDPlayer:";
            // 
            // ckCheckIP
            // 
            this.ckCheckIP.AutoSize = true;
            this.ckCheckIP.Location = new System.Drawing.Point(326, 93);
            this.ckCheckIP.Name = "ckCheckIP";
            this.ckCheckIP.Size = new System.Drawing.Size(98, 22);
            this.ckCheckIP.TabIndex = 3;
            this.ckCheckIP.Text = "Check IP";
            this.ckCheckIP.UseVisualStyleBackColor = true;
            this.ckCheckIP.CheckedChanged += new System.EventHandler(this.ckCheckIP_CheckedChanged);
            // 
            // bunifuDragControl_1
            // 
            this.bunifuDragControl_1.Fixed = true;
            this.bunifuDragControl_1.Horizontal = true;
            this.bunifuDragControl_1.TargetControl = this.label28;
            this.bunifuDragControl_1.Vertical = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(1772, 1032);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(65, 18);
            this.label44.TabIndex = 9;
            this.label44.Text = "Version";
            // 
            // text_api_captcha
            // 
            this.text_api_captcha.Location = new System.Drawing.Point(150, 288);
            this.text_api_captcha.Name = "text_api_captcha";
            this.text_api_captcha.Size = new System.Drawing.Size(318, 24);
            this.text_api_captcha.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegClone";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.pnlTuongTac.ResumeLayout(false);
            this.pnlTuongTac.PerformLayout();
            this.gbCamxuc.ResumeLayout(false);
            this.gbCamxuc.PerformLayout();
            this.plAddfriend.ResumeLayout(false);
            this.plAddfriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFriendTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFriendFrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayQR2Fa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMailVeri.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.plVeriMail.ResumeLayout(false);
            this.plVeriMail.PerformLayout();
            this.plHotmailReg.ResumeLayout(false);
            this.plHotmailReg.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.pnlTemmail.ResumeLayout(false);
            this.pnlTemmail.PerformLayout();
            this.plNovery.ResumeLayout(false);
            this.plNovery.PerformLayout();
            this.plVeriPhone.ResumeLayout(false);
            this.plVeriPhone.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabProxy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.plTinsoftProxy.ResumeLayout(false);
            this.plTinsoftProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTinsoft)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlAPIMinProxy.ResumeLayout(false);
            this.pnlAPIMinProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPMinProxy)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlIpPort.ResumeLayout(false);
            this.pnlIpPort.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plXproxy.ResumeLayout(false);
            this.plXproxy.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayResetXProxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPXProxy)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.plTMProxy.ResumeLayout(false);
            this.plTMProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTMProxy)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.plProxyShopLike.ResumeLayout(false);
            this.plProxyShopLike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadShopLike)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.pnlProxyFree.ResumeLayout(false);
            this.pnlProxyFree.PerformLayout();
            this.Proxyv6.ResumeLayout(false);
            this.Proxyv6.PerformLayout();
            this.plProxyv6.ResumeLayout(false);
            this.plProxyv6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.plCheckDoiIP.ResumeLayout(false);
            this.plCheckDoiIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeIP)).EndInit();
            this.plChangeIPDcom.ResumeLayout(false);
            this.plChangeIPDcom.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeClsTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeClsFr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlSoLanReg.ResumeLayout(false);
            this.pnlSoLanReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuotChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeWaitOTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThrLdPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		[CompilerGenerated]
		private void method_105()
		{
			while (true)
			{
				try
				{
					string text = Class2.smethod_34("adb devices");
					if (!text.Contains("List of devices attached"))
					{
						Common.smethod_63("adb");
						bool_1 = true;
					}
				}
				catch
				{
				}
				Common.smethod_62(30.0);
			}
		}

		[CompilerGenerated]
		private void method_106()
		{
			Process.Start(txtLinkLD.Text + "\\dnmultiplayer.exe");
		}

		[CompilerGenerated]
		private void method_107()
		{
			Process.Start(txtLinkLD.Text + "\\dnrepairer.exe");
			method_51(10.0);
			MessageBox.Show("Sửa chữa LDPlayer thành công", "Thông báo");
		}

        private void button2_Click(object sender, EventArgs e)
        {
			MessageBox.Show("This is a Joker button. Dont click haha !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			
			AutoUpdater.Start("http://selltoolmmo.site/update/updateregclone/version.xml");
			//LoadUpdate();
		}

		private void LoadUpdate()
		{
			Assembly excutingAssembly = Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(excutingAssembly.Location);
			AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
			string fileVersion = versionInfo.FileVersion;
			label44.Text = "Version: " + fileVersion;
			AutoUpdater.DownloadPath = "update";
			//System.Timers.Timer timer = new System.Timers.Timer
			//{
			//	//Interval = 1.0,
			//	SynchronizingObject = this
			//};
			//timer.Elapsed += delegate
			//{
				AutoUpdater.Start("http://selltoolmmo.site/update/updateregclone/version.xml");
			//};
			//timer.Start();
		}
		private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
		{
			if (args.IsUpdateAvailable)
			{
				DialogResult dialogResult = MessageBox.Show($"Đã có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng {args.InstalledVersion}. Bạn có muốn cập nhật không?", "Cập nhật phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				if (!dialogResult.Equals(DialogResult.Yes) && !dialogResult.Equals(DialogResult.OK))
				{
					return;
				}
				try
				{
					if (AutoUpdater.DownloadUpdate(args))
					{
						Application.Exit();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Phiên bản bạn đang sử dụng đã được cập nhật mới nhất", "Cập nhật phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

        private void frmMain_Load(object sender, EventArgs e)
        {

			rdHotMailRegisted.Hide();
			btnNhapHotmail.Hide();

		   LoadUpdate();
        }

       
        private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
        {
			if (rbProxyv6.Checked)
			{
				RadioButton radioButton = rdTinsoftProxy;
				RadioButton radioButton2 = rdMinProxy;
				RadioButton radioButton3 = rdIPPortUserPass;
				RadioButton radioButton4 = rbXproxy;
				RadioButton radioButton5 = rbTMProxy;
				RadioButton radioButton6 = rbProxyShoplike;
				rdProxyOrbit.Checked = false;
				radioButton6.Checked = false;
				radioButton5.Checked = false;
				radioButton4.Checked = false;
				radioButton3.Checked = false;
				radioButton2.Checked = false;
				radioButton.Checked = false;
			}
			plProxyv6.Enabled = rbProxyv6.Checked;
		}

        private void txtApiProxyv6_TextChanged(object sender, EventArgs e)
        {
			List<string> list = txtApiProxyv6.Lines.ToList();
			list = Common.smethod_77(list);
			lblApiProxyv6.Text = $"Nhập API KEY ({list.Count.ToString()}):";
		}

        private void btnCheckProxyv6_Click(object sender, EventArgs e)
        {
			List<string> list = new List<string>();
			List<string> list2 = txtApiProxyv6.Lines.ToList();
			list2 = Common.smethod_77(list2);
			foreach (string item in list2)
			{
				if (ClassProxyv6.smethod_0(item))
				{
					list.Add(item);
				}
			}
			txtApiProxyv6.Lines = list.ToArray();
			if (list.Count > 0)
			{
				MessageBox.Show($"Đang có {list.Count} proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Không có proxy khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
		private string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + cmd;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}
		string text = smethod_5(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString()); // Md5 Encode
		private void label49_Paint(object sender, PaintEventArgs e)
        {
			//string value = RunCMD("wmic diskdrive get serialNumber");
			//using (StreamWriter streamWriter = new StreamWriter("HDD.txt", append: true))
			//{
			//	streamWriter.WriteLine(value);
			//	streamWriter.Close();
			//}
			//string[] array = File.ReadAllLines("HDD.txt");
			//File.Delete("HDD.txt");
			//string text = Regex.Replace(array[2], "\\s", "");
			//string value2 = RunCMD("wmic bios get serialnumber");
			//using (StreamWriter streamWriter2 = new StreamWriter("bios.txt", append: true))
			//{
			//	streamWriter2.WriteLine(value2);
			//	streamWriter2.Close();
			//}
			//string[] array2 = File.ReadAllLines("bios.txt");
			//File.Delete("bios.txt");
			//string arg = Regex.Replace(array2[2], "\\s", "") + text;
			//string text2 = this.text.Substring(0, 32) + "_Regfbv2";
			//System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
			//string requestUri = "https://docs.google.com/spreadsheets/d/1DX5q1Cvb7H1RNhO6DSo7eA-DEutDzeaCrRciayiS1ko/edit?usp=sharing";
			//Match match = Regex.Match(httpClient.GetAsync(requestUri).Result.Content.ReadAsStringAsync().Result.ToString().ToString(), text2 + ".*?(?=ok)");
			//if (match != Match.Empty)
			//{
			//	string[] array3 = match.ToString().Split('|');
			//	DateTime now = DateTime.Now;
			//	int day = now.Day;
			//	int month = now.Month;
			//	int year = now.Year;
			//	string[] array4 = array3[1].ToString().Split('/');
			//	int day2 = int.Parse(array4[0]);
			//	int month2 = int.Parse(array4[1]);
			//	int year2 = int.Parse(array4[2]);
			//	DateTime value3 = new DateTime(year, month, day);
			//	int num = (int)Math.Ceiling(new DateTime(year2, month2, day2).Subtract(value3).TotalDays);
			//	bool num2 = num <= 0;
			//	bool flag = num > 1000;
			//	if (num2)
			//	{
			//		MessageBox.Show("Vui lòng liên hệ admin để gia hạn !!", "Phần mềm hết hạn" + num + " ngày trước ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			//		this.Hide();
			//		new CheckKey().ShowDialog();
			//		return;
			//	}
			//	else if (flag)
			//	{
			//	}
			//	else
			//	{
			//		MessageBox.Show("Đăng Ký Dùng Thử Thành Công !!", "Còn lại: " + num + " ngày!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			//	}
			//}
			//else
			//{
			//	MessageBox.Show(string.Format("Bạn chưa mua bản quyền tool, vui lòng COPY và gửi mã " + this.text.Substring(0, 32) + "_Regfbv2 qua Zalo để kích hoạt tool!", arg), "Thông báo active bản quyền!", MessageBoxButtons.OK);
			//	this.Hide();
			//	new CheckKey().ShowDialog();
			//	return;
			//}
		}

		//int x;
		//      private void timer1_Tick(object sender, EventArgs e)
		//      {

		//	x = label44.Location.X;
		//	x--;
		//	label44.Location = new Point(x, label44.Location.Y);

		//	if (x == 0)
		//	{
		//		frmMain fr = new frmMain("12-12-2099");
		//		x = fr.Size.Width;
		//		label44.Location = new Point(fr.Size.Width, label44.Location.Y);
		//	}
		//}
		public string Getrandomemail()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(RandomString1(1, lowerCase: true));
			stringBuilder.Append(RandomString1(6, lowerCase: true));
			stringBuilder.Append(RandomNumber1(1000, 9999));
			stringBuilder.Append(RandomString1(4, lowerCase: true));
			return stringBuilder.ToString();
		}
		private int RandomNumber1(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}
		private string RandomString1(int size, bool lowerCase)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < size; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
		public string Getrandompassmailtm()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(RandomString(1, lowerCase: false));
			stringBuilder.Append(RandomString(5, lowerCase: true));
			stringBuilder.Append(RandomNumber(100, 999));
			stringBuilder.Append(RandomString(1, lowerCase: true));
			return stringBuilder.ToString();
		}
		private string RandomString(int size, bool lowerCase)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < size; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
		private int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}
	}
	
}
