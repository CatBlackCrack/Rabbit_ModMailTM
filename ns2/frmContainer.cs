using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DeviceId;
using ns0;
using ns1;
using ns4;
using ns5;
using ns6;
using ns7;
using ToolRegFB;

namespace ns2
{
	internal class frmContainer : Form
	{
		[CompilerGenerated]
		private sealed class Class26
		{
			public frmContainer frmContainer_0;

			public string string_0;

			internal void method_0()
			{
				frmContainer_0.btnFacebook.Invoke((MethodInvoker)delegate
				{
					if (string_0 == "facebook")
					{
						frmContainer_0.frmLoading_0.string_0 = "Đang khởi tạo Auto Register Facebook...";
					}
					frmContainer_0.frmLoading_0.method_0();
				});
				try
				{
					Class27 CS_0024_003C_003E8__locals0 = new Class27
					{
						class26_0 = this
					};
					string string_ = frmContainer_0.class83_0.id.ToString();
					CS_0024_003C_003E8__locals0.string_0 = Class0.smethod_4(frmContainer_0.class83_0.token, string_, frmContainer_0.string_0, string_0);
					if (CS_0024_003C_003E8__locals0.string_0 == string.Empty)
					{
						frmContainer_0.frmLoading_0.method_1();
						MessageBox.Show("Khởi tạo tool không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					frmContainer_0.btnFacebook.Invoke((MethodInvoker)delegate
					{
						if (!Common.smethod_84("frmMain"))
						{
							CS_0024_003C_003E8__locals0.class26_0.frmContainer_0.frmLoading_0.method_1();
							CS_0024_003C_003E8__locals0.class26_0.frmContainer_0.frmMain_0 = new frmMain(CS_0024_003C_003E8__locals0.string_0);
							CS_0024_003C_003E8__locals0.class26_0.frmContainer_0.frmMain_0.Show();
						}
					});
				}
				catch (Exception ex)
				{
					frmContainer_0.btnFacebook.Invoke((MethodInvoker)delegate
					{
						frmContainer_0.frmLoading_0.method_1();
					});
					MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}

			internal void method_1()
			{
				if (string_0 == "facebook")
				{
					frmContainer_0.frmLoading_0.string_0 = "Đang khởi tạo Auto Register Facebook...";
				}
				frmContainer_0.frmLoading_0.method_0();
			}

			internal void method_2()
			{
				frmContainer_0.frmLoading_0.method_1();
			}
		}

		[CompilerGenerated]
		private sealed class Class27
		{
			public string string_0;

			public Class26 class26_0;

			internal void method_0()
			{
				if (!Common.smethod_84("frmMain"))
				{
					class26_0.frmContainer_0.frmLoading_0.method_1();
					class26_0.frmContainer_0.frmMain_0 = new frmMain(string_0);
					class26_0.frmContainer_0.frmMain_0.Show();
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class28
		{
			public frmContainer frmContainer_0;

			public string string_0;

			public string string_1;

			public double double_0;

			public int int_0;

			internal void method_0()
			{
				frmContainer_0.btnRegFB.Invoke((MethodInvoker)delegate
				{
					if (string_0 == "register")
					{
						frmContainer_0.frmLoading_0.string_0 = "Đang đăng ký Tool...";
					}
					else if (string_0 == "extend")
					{
						frmContainer_0.frmLoading_0.string_0 = "Đang gia hạn Tool...";
					}
					else
					{
						frmContainer_0.frmLoading_0.string_0 = "Đang đăng ký dùng thử...";
					}
					frmContainer_0.frmLoading_0.method_0();
				});
				try
				{
					string string_ = frmContainer_0.class83_0.id.ToString();
					bool flag = Class0.smethod_3(frmContainer_0.class83_0.token, string_, frmContainer_0.string_0, string_1, string_0, double_0, int_0);
					frmContainer_0.btnRegFB.Invoke((MethodInvoker)delegate
					{
						frmContainer_0.frmLoading_0.method_1();
					});
					if (!flag)
					{
						if (string_0 == "register")
						{
							MessageBox.Show("Đăng ký tool này không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else if (string_0 == "extend")
						{
							MessageBox.Show("Gia hạn tool này không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Đăng ký dùng thử tool không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						return;
					}
					frmContainer_0.btnRegFB.Invoke((MethodInvoker)delegate
					{
						if (string_0 == "register" || string_0 == "extend")
						{
							frmContainer_0.btnRegFB.Text = "Gia hạn";
							frmContainer_0.lblSoxu.Text = ((double)Convert.ToInt32(frmContainer_0.lblSoxu.Text) - double_0).ToString();
							int num = 0;
							if (int_0 == 1)
							{
								num = 30;
							}
							else if (int_0 == 6)
							{
								num = 180;
							}
							else if (int_0 == 12)
							{
								num = 360;
							}
							else if (int_0 == 0)
							{
								num = 7;
							}
							if (string_1 == "facebook")
							{
								if (frmContainer_0.lblLimitFB.Text != "Hết hạn")
								{
									frmContainer_0.lblLimitFB.Text = Convert.ToDateTime(frmContainer_0.lblLimitFB.Text).AddDays(num).ToString("dd/MM/yyyy");
								}
								else
								{
									DateTime now = DateTime.Now;
									TimeSpan value = new TimeSpan(num, 0, 0, 0);
									now.Add(value);
									frmContainer_0.lblLimitFB.Text = DateTime.Now.AddDays(num).ToString("dd/MM/yyyy");
								}
							}
						}
						else
						{
							DateTime now2 = DateTime.Now;
							TimeSpan value2 = new TimeSpan(7, 0, 0, 0);
							now2.Add(value2);
							frmContainer_0.lblLimitFB.Text = DateTime.Now.AddDays(7.0).ToString("dd/MM/yyyy");
							frmContainer_0.btnRegFB.Text = "Đăng ký";
						}
						frmContainer_0.lblLimitFB.Visible = true;
						frmContainer_0.lblFb.Visible = true;
						frmContainer_0.timer_0.Stop();
						frmContainer_0.btnFacebook.Visible = true;
						if (string_0 == "register")
						{
							MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else if (string_0 == "extend")
						{
							MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else if (string_0 == "trial")
						{
							MessageBox.Show("Đăng ký dùng thử tool thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Có lỗi xảy ra khi đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					});
				}
				catch (Exception ex)
				{
					frmContainer_0.btnRegFB.Invoke((MethodInvoker)delegate
					{
						frmContainer_0.timer_0.Stop();
						frmContainer_0.frmLoading_0.method_1();
					});
					MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}

			internal void method_1()
			{
				if (string_0 == "register")
				{
					frmContainer_0.frmLoading_0.string_0 = "Đang đăng ký Tool...";
				}
				else if (string_0 == "extend")
				{
					frmContainer_0.frmLoading_0.string_0 = "Đang gia hạn Tool...";
				}
				else
				{
					frmContainer_0.frmLoading_0.string_0 = "Đang đăng ký dùng thử...";
				}
				frmContainer_0.frmLoading_0.method_0();
			}

			internal void method_2()
			{
				frmContainer_0.frmLoading_0.method_1();
			}

			internal void method_3()
			{
				if (string_0 == "register" || string_0 == "extend")
				{
					frmContainer_0.btnRegFB.Text = "Gia hạn";
					frmContainer_0.lblSoxu.Text = ((double)Convert.ToInt32(frmContainer_0.lblSoxu.Text) - double_0).ToString();
					int num = 0;
					if (int_0 == 1)
					{
						num = 30;
					}
					else if (int_0 == 6)
					{
						num = 180;
					}
					else if (int_0 == 12)
					{
						num = 360;
					}
					else if (int_0 == 0)
					{
						num = 7;
					}
					if (string_1 == "facebook")
					{
						if (frmContainer_0.lblLimitFB.Text != "Hết hạn")
						{
							frmContainer_0.lblLimitFB.Text = Convert.ToDateTime(frmContainer_0.lblLimitFB.Text).AddDays(num).ToString("dd/MM/yyyy");
						}
						else
						{
							DateTime now = DateTime.Now;
							TimeSpan value = new TimeSpan(num, 0, 0, 0);
							now.Add(value);
							frmContainer_0.lblLimitFB.Text = DateTime.Now.AddDays(num).ToString("dd/MM/yyyy");
						}
					}
				}
				else
				{
					DateTime now2 = DateTime.Now;
					TimeSpan value2 = new TimeSpan(7, 0, 0, 0);
					now2.Add(value2);
					frmContainer_0.lblLimitFB.Text = DateTime.Now.AddDays(7.0).ToString("dd/MM/yyyy");
					frmContainer_0.btnRegFB.Text = "Đăng ký";
				}
				frmContainer_0.lblLimitFB.Visible = true;
				frmContainer_0.lblFb.Visible = true;
				frmContainer_0.timer_0.Stop();
				frmContainer_0.btnFacebook.Visible = true;
				if (string_0 == "register")
				{
					MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (string_0 == "extend")
				{
					MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (string_0 == "trial")
				{
					MessageBox.Show("Đăng ký dùng thử tool thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra khi đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}

			internal void method_4()
			{
				frmContainer_0.timer_0.Stop();
				frmContainer_0.frmLoading_0.method_1();
			}
		}

		public static frmContainer frmContainer_0;

		private frmLoading frmLoading_0;

		private Class83 class83_0 = new Class83();

		private int int_0 = 0;

		private frmMain frmMain_0;

		private frmViewLD frmViewLD_0;

		private List<Class81> list_0;

		private string string_0 = string.Empty;

		private DateTime dateTime_0;

		private bool bool_0 = false;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Button btnServices;

		private Panel panel2;

		private Label lblSoxu;

		private Label label2;

		private Label lblUserName;

		private PictureBox pictureBox1;

		private Button btnLogout;

		private Button btnFacebook;

		private Button btnShopee;

		private Button btnInstagram;

		private Button btnClose;

		private Button btnMinimized;

		private Button btnZalo;

		private Panel pnlNav;

		private Label label8;

		private Button btnNapxu;

		private Panel panel7;

		private Panel panel8;

		private System.Windows.Forms.Timer timer_0;

		private Panel pnlListProduct;

		private Panel panel4;

		private Button btnRegInsta;

		private PictureBox pictureBox3;

		private Label label9;

		private Label lblLimitInsta;

		private Label lblInstagram;

		private Label label12;

		private Label label4;

		private Panel panel3;

		private Button btnRegFB;

		private PictureBox pictureBox2;

		private Label label6;

		private Label lblLimitFB;

		private Label lblFb;

		private Label label5;

		private Panel panel6;

		private Button btnRegZalo;

		private PictureBox pictureBox5;

		private Label label17;

		private Label lblLimitZalo;

		private Label lblZalo;

		private Label label20;

		private Panel panel5;

		private Button btnRegShopee;

		private PictureBox pictureBox4;

		private Label label13;

		private Label lblLimitShopee;

		private Label lblShopee;

		private Label label16;

		private Label label1;

		private Button btnUpdateVersion;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		private Label lblVersion;

		private Label label3;

		private Panel panel9;

		private Label label7;

		private Label label11;

		private Label label10;

		private System.Windows.Forms.Timer timer_1;

		private Button btnExitTool;

		private Button btnUpdateXu;

		public frmContainer(Class83 class83_1)
		{
			InitializeComponent();
			frmContainer_0 = this;
			pnlNav.Height = btnServices.Height;
			pnlNav.Top = btnServices.Top;
			pnlNav.Left = btnServices.Left;
			btnServices.BackColor = Color.FromArgb(46, 51, 73);
			Label label = lblFb;
			Label label2 = lblInstagram;
			Label label3 = lblShopee;
			lblZalo.Visible = false;
			label3.Visible = false;
			label2.Visible = false;
			label.Visible = false;
			Label label4 = lblLimitFB;
			Label label5 = lblLimitInsta;
			Label label6 = lblLimitShopee;
			lblLimitZalo.Visible = false;
			label6.Visible = false;
			label5.Visible = false;
			label4.Visible = false;
			Button button = btnFacebook;
			Button button2 = btnInstagram;
			Button button3 = btnZalo;
			btnShopee.Visible = false;
			button3.Visible = false;
			button2.Visible = false;
			button.Visible = false;
			class83_0 = class83_1;
			lblUserName.Text = class83_1.email.Split(new string[1] { "@" }, StringSplitOptions.None)[0];
			lblSoxu.Text = class83_1.totalMoney.ToString();
			list_0 = new List<Class81>();
			string_0 = Common.smethod_79(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString());
			method_5();
			if (class83_1.listLicense != null)
			{
				if (class83_1.listLicense.Count <= 0)
				{
					return;
				}
				{
					foreach (Class80 item in class83_1.listLicense)
					{
						if (item.typeProduct == "facebook")
						{
							btnRegFB.Text = "Gia hạn";
							bool_0 = true;
							lblLimitFB.Visible = true;
							lblFb.Visible = true;
							lblLimitFB.Text = item.timeExpired.ToString("dd/MM/yyyy");
							dateTime_0 = item.timeExpired;
							int days = (Convert.ToDateTime(item.timeExpired.ToString("dd/MM/yyyy hh:mm:ss")) - Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"))).Days;
							if (days <= 2 && days > 0)
							{
								timer_0.Start();
							}
							if (DateTime.Parse(item.timeExpired.ToString("dd/MM/yyyy hh:mm:ss")) > DateTime.Now)
							{
								timer_1.Start();
								btnFacebook.Visible = true;
							}
							else
							{
								lblLimitFB.Text = "Hết hạn";
							}
						}
					}
					return;
				}
			}
			btnRegFB.Text = "Đăng ký";
		}

		private void frmContainer_Load(object sender, EventArgs e)
		{
		}

		private void btnServices_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnServices.Height;
			pnlNav.Top = btnServices.Top;
			pnlNav.Left = btnServices.Left;
			btnServices.BackColor = Color.FromArgb(46, 51, 73);
		}

		private void btnFacebook_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnFacebook.Height;
			pnlNav.Top = btnFacebook.Top;
			btnFacebook.BackColor = Color.FromArgb(46, 51, 73);
			method_0("facebook");
		}

		private void method_0(string string_1)
		{
			frmLoading_0 = new frmLoading(base.Width, base.Height, base.Location.X, base.Location.Y);
			string string_2;
			new Thread((ThreadStart)delegate
			{
				btnFacebook.Invoke((MethodInvoker)delegate
				{
					if (string_1 == "facebook")
					{
						frmLoading_0.string_0 = "Đang khởi tạo Auto Register Facebook...";
					}
					frmLoading_0.method_0();
				});
				try
				{
					string string_3 = class83_0.id.ToString();
					string_2 = Class0.smethod_4(class83_0.token, string_3, string_0, string_1);
					if (string_2 == string.Empty)
					{
						frmLoading_0.method_1();
						MessageBox.Show("Khởi tạo tool không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						btnFacebook.Invoke((MethodInvoker)delegate
						{
							if (!Common.smethod_84("frmMain"))
							{
								frmLoading_0.method_1();
								frmMain_0 = new frmMain(string_2);
								frmMain_0.Show();
							}
						});
					}
				}
				catch (Exception ex)
				{
					btnFacebook.Invoke((MethodInvoker)delegate
					{
						frmLoading_0.method_1();
					});
					MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}).Start();
		}

		private void btnInstagram_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnInstagram.Height;
			pnlNav.Top = btnInstagram.Top;
			btnInstagram.BackColor = Color.FromArgb(46, 51, 73);
		}

		private void btnShopee_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnShopee.Height;
			pnlNav.Top = btnShopee.Top;
			btnShopee.BackColor = Color.FromArgb(46, 51, 73);
		}

		private void btnServices_Leave(object sender, EventArgs e)
		{
			btnServices.BackColor = Color.FromArgb(24, 30, 54);
		}

		private void btnFacebook_Leave(object sender, EventArgs e)
		{
			btnFacebook.BackColor = Color.FromArgb(24, 30, 54);
		}

		private void btnInstagram_Leave(object sender, EventArgs e)
		{
			btnInstagram.BackColor = Color.FromArgb(24, 30, 54);
		}

		private void btnShopee_Leave(object sender, EventArgs e)
		{
			btnShopee.BackColor = Color.FromArgb(24, 30, 54);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			method_1();
		}

		private void method_1()
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát tool không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			if (dialogResult == DialogResult.Yes)
			{
				Common.smethod_63("ToolRegFB");
				Common.smethod_63("RabbitUpdater");
				Common.smethod_63("adb");
			}
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void btnZalo_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnZalo.Height;
			pnlNav.Top = btnZalo.Top;
			btnZalo.BackColor = Color.FromArgb(46, 51, 73);
		}

		private void btnZalo_Leave(object sender, EventArgs e)
		{
			btnZalo.BackColor = Color.FromArgb(24, 30, 54);
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (int_0 == 2 || lblLimitFB.Text == "Hết hạn")
			{
				timer_0.Stop();
			}
			else
			{
				if (class83_0.listLicense == null || class83_0.listLicense.Count <= 0)
				{
					return;
				}
				foreach (Class80 item in class83_0.listLicense)
				{
					if (!(item.typeProduct == "facebook"))
					{
						continue;
					}
					int days = (Convert.ToDateTime(item.timeExpired.ToString("dd/MM/yyyy")) - Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))).Days;
					if (days <= 3 && days > 0)
					{
						MessageBox.Show("License sắp hết hạn. Vui lòng gia hạn thêm để sử dụng. Thank you!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						int_0++;
					}
					else if (DateTime.Parse(item.timeExpired.ToString("dd/MM/yyyy hh:mm:ss")) < DateTime.Now)
					{
						if (Common.smethod_84("frmMain"))
						{
							frmMain_0.Close();
						}
						if (Common.smethod_84("frmViewLD"))
						{
							frmViewLD.frmViewLD_0.Close();
						}
						btnFacebook.Visible = false;
						lblLimitFB.Text = "Hết hạn";
						timer_0.Stop();
						break;
					}
				}
			}
		}

		private void btnNapxu_Click(object sender, EventArgs e)
		{
			if (!Common.smethod_84("frmNapxu"))
			{
				string[] array = lblUserName.Text.Split(new string[1] { "@" }, StringSplitOptions.None);
				frmNapxu frmNapxu = new frmNapxu(array[0]);
				frmNapxu.ShowDialog();
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			if (Common.smethod_84("frmMain"))
			{
				frmMain_0.Close();
			}
			Close();
		}

		private void method_2(object sender, EventArgs e)
		{
		}

		private void method_3(string string_1, string string_2, double double_0, int int_1)
		{
			frmLoading_0 = new frmLoading(base.Width, base.Height, base.Location.X, base.Location.Y);
			new Thread((ThreadStart)delegate
			{
				btnRegFB.Invoke((MethodInvoker)delegate
				{
					if (string_1 == "register")
					{
						frmLoading_0.string_0 = "Đang đăng ký Tool...";
					}
					else if (string_1 == "extend")
					{
						frmLoading_0.string_0 = "Đang gia hạn Tool...";
					}
					else
					{
						frmLoading_0.string_0 = "Đang đăng ký dùng thử...";
					}
					frmLoading_0.method_0();
				});
				try
				{
					string string_3 = class83_0.id.ToString();
					bool flag = Class0.smethod_3(class83_0.token, string_3, string_0, string_2, string_1, double_0, int_1);
					btnRegFB.Invoke((MethodInvoker)delegate
					{
						frmLoading_0.method_1();
					});
					if (!flag)
					{
						if (string_1 == "register")
						{
							MessageBox.Show("Đăng ký tool này không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else if (string_1 == "extend")
						{
							MessageBox.Show("Gia hạn tool này không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Đăng ký dùng thử tool không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					else
					{
						btnRegFB.Invoke((MethodInvoker)delegate
						{
							if (string_1 == "register" || string_1 == "extend")
							{
								btnRegFB.Text = "Gia hạn";
								lblSoxu.Text = ((double)Convert.ToInt32(lblSoxu.Text) - double_0).ToString();
								int num = 0;
								if (int_1 == 1)
								{
									num = 30;
								}
								else if (int_1 == 6)
								{
									num = 180;
								}
								else if (int_1 == 12)
								{
									num = 360;
								}
								else if (int_1 == 0)
								{
									num = 7;
								}
								if (string_2 == "facebook")
								{
									if (lblLimitFB.Text != "Hết hạn")
									{
										lblLimitFB.Text = Convert.ToDateTime(lblLimitFB.Text).AddDays(num).ToString("dd/MM/yyyy");
									}
									else
									{
										DateTime now = DateTime.Now;
										TimeSpan value = new TimeSpan(num, 0, 0, 0);
										now.Add(value);
										lblLimitFB.Text = DateTime.Now.AddDays(num).ToString("dd/MM/yyyy");
									}
								}
							}
							else
							{
								DateTime now2 = DateTime.Now;
								TimeSpan value2 = new TimeSpan(7, 0, 0, 0);
								now2.Add(value2);
								lblLimitFB.Text = DateTime.Now.AddDays(7.0).ToString("dd/MM/yyyy");
								btnRegFB.Text = "Đăng ký";
							}
							lblLimitFB.Visible = true;
							lblFb.Visible = true;
							timer_0.Stop();
							btnFacebook.Visible = true;
							if (string_1 == "register")
							{
								MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							else if (string_1 == "extend")
							{
								MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							else if (string_1 == "trial")
							{
								MessageBox.Show("Đăng ký dùng thử tool thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							else
							{
								MessageBox.Show("Có lỗi xảy ra khi đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						});
					}
				}
				catch (Exception ex)
				{
					btnRegFB.Invoke((MethodInvoker)delegate
					{
						timer_0.Stop();
						frmLoading_0.method_1();
					});
					MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}).Start();
		}

		private void method_4(string string_1)
		{
			if (btnRegFB.Text == "Dùng thử")
			{
				DialogResult dialogResult = MessageBox.Show("Thời gian dùng thử tool đã hết. Các bạn có thể đăng ký 1 tuần để test tool.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				if (dialogResult == DialogResult.Yes)
				{
					btnRegFB.Text = "Đăng ký";
				}
			}
			else
			{
				if (Common.smethod_84("frmNapxu"))
				{
					return;
				}
				Class81 @class = new Class81();
				@class.listProc = new List<Class82>
				{
					new Class82
					{
						month = 1,
						tongxu = 800f
					},
					new Class82
					{
						month = 6,
						tongxu = 4800f
					},
					new Class82
					{
						month = 12,
						tongxu = 9600f
					},
					new Class82
					{
						month = 0,
						tongxu = 200f
					}
				};
				frmProductOptions frmProductOptions = new frmProductOptions(@class, bool_0);
				frmProductOptions.ShowDialog();
				if (frmProductOptions.btnRegProduct.DialogResult != DialogResult.OK)
				{
					return;
				}
				double num = 0.0;
				int num2 = 0;
				if (frmProductOptions.chk1ngay.Checked)
				{
					num2 = 0;
					num = Convert.ToDouble(frmProductOptions.lbl1ngay.Text);
				}
				else if (frmProductOptions.chk1thang.Checked)
				{
					num2 = 1;
					num = Convert.ToDouble(frmProductOptions.lbl1thang.Text);
				}
				else if (frmProductOptions.chk6thang.Checked)
				{
					num2 = 6;
					num = Convert.ToDouble(frmProductOptions.lbl6thang.Text);
				}
				else
				{
					if (!frmProductOptions.chk12thang.Checked)
					{
						MessageBox.Show("Vui lòng chọn gói cần đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					num2 = 12;
					num = Convert.ToDouble(frmProductOptions.lbl12thang.Text);
				}
				if (class83_0.totalMoney < num)
				{
					MessageBox.Show("Xu không đủ. Vui lòng nạp thêm xu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (btnRegFB.Text == "Đăng ký")
				{
					DialogResult dialogResult = ((num2 != 0) ? MessageBox.Show("Bạn đồng ý đăng ký " + num2 + " tháng dùng tool?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) : MessageBox.Show("Bạn đồng ý đăng ký 1 tuần dùng tool?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
					if (dialogResult == DialogResult.Yes)
					{
						method_3("register", string_1, num, num2);
					}
				}
				else
				{
					DialogResult dialogResult = ((num2 != 0) ? MessageBox.Show("Bạn đồng ý gia hạn thêm " + num2 + " tháng dùng tool?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) : MessageBox.Show("Bạn đồng ý gia hạn thêm 1 tuần dùng tool?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
					if (dialogResult == DialogResult.Yes)
					{
						method_3("extend", string_1, num, num2);
					}
				}
			}
		}

		private void btnRegFB_Click(object sender, EventArgs e)
		{
			if (Common.smethod_29())
			{
				method_4("facebook");
			}
			else
			{
				MessageBox.Show("Bạn vui lòng chuyển đổi thời gian máy tính của bạn sang định dạng ngày/tháng/năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnRegInsta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đang phát triển. Mọi người chờ nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnRegShopee_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đang phát triển. Mọi người chờ nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnRegZalo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đang phát triển. Mọi người chờ nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnUpdateVersion_Click(object sender, EventArgs e)
		{
			frmUpdate frmUpdate = new frmUpdate();
			frmUpdate.Show();
		}

		public void method_5()
		{
			Class48 @class = new Class48("update.ini");
			lblVersion.Text = @class.method_1("Version", "Infor");
		}

		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (DateTime.Parse(dateTime_0.ToString("dd/MM/yyyy hh:mm:ss")) < DateTime.Now)
			{
				if (frmMain.frmMain_0 != null)
				{
					frmMain.frmMain_0.Close();
				}
				if (frmViewLD.frmViewLD_0 != null)
				{
					frmViewLD.frmViewLD_0.Close();
				}
				btnFacebook.Visible = false;
				lblLimitFB.Text = "Hết hạn";
				timer_1.Stop();
			}
		}

		private void btnExitTool_Click(object sender, EventArgs e)
		{
			method_1();
		}

		private void btnUpdateXu_Click(object sender, EventArgs e)
		{
			if (class83_0 != null)
			{
				lblSoxu.Text = Class0.smethod_5(class83_0.id.ToString(), class83_0.email, class83_0.token).ToString();
			}
			else
			{
				MessageBox.Show("Cập nhật xu không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
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
			icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns2.frmContainer));
			panel1 = new System.Windows.Forms.Panel();
			btnExitTool = new System.Windows.Forms.Button();
			btnUpdateVersion = new System.Windows.Forms.Button();
			pnlNav = new System.Windows.Forms.Panel();
			btnZalo = new System.Windows.Forms.Button();
			btnShopee = new System.Windows.Forms.Button();
			btnInstagram = new System.Windows.Forms.Button();
			btnLogout = new System.Windows.Forms.Button();
			btnFacebook = new System.Windows.Forms.Button();
			btnServices = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			panel7 = new System.Windows.Forms.Panel();
			btnUpdateXu = new System.Windows.Forms.Button();
			btnNapxu = new System.Windows.Forms.Button();
			lblSoxu = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			lblUserName = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label8 = new System.Windows.Forms.Label();
			panel8 = new System.Windows.Forms.Panel();
			btnMinimized = new System.Windows.Forms.Button();
			btnClose = new System.Windows.Forms.Button();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			pnlListProduct = new System.Windows.Forms.Panel();
			panel9 = new System.Windows.Forms.Panel();
			label11 = new System.Windows.Forms.Label();
			lblVersion = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			panel4 = new System.Windows.Forms.Panel();
			btnRegInsta = new System.Windows.Forms.Button();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label9 = new System.Windows.Forms.Label();
			lblLimitInsta = new System.Windows.Forms.Label();
			lblInstagram = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			panel6 = new System.Windows.Forms.Panel();
			btnRegZalo = new System.Windows.Forms.Button();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			label17 = new System.Windows.Forms.Label();
			lblLimitZalo = new System.Windows.Forms.Label();
			lblZalo = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			panel5 = new System.Windows.Forms.Panel();
			btnRegShopee = new System.Windows.Forms.Button();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			label13 = new System.Windows.Forms.Label();
			lblLimitShopee = new System.Windows.Forms.Label();
			lblShopee = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			panel3 = new System.Windows.Forms.Panel();
			btnRegFB = new System.Windows.Forms.Button();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label6 = new System.Windows.Forms.Label();
			lblLimitFB = new System.Windows.Forms.Label();
			lblFb = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			timer_1 = new System.Windows.Forms.Timer(icontainer_0);
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel8.SuspendLayout();
			pnlListProduct.SuspendLayout();
			panel9.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			panel1.Controls.Add(btnExitTool);
			panel1.Controls.Add(btnUpdateVersion);
			panel1.Controls.Add(pnlNav);
			panel1.Controls.Add(btnZalo);
			panel1.Controls.Add(btnShopee);
			panel1.Controls.Add(btnInstagram);
			panel1.Controls.Add(btnLogout);
			panel1.Controls.Add(btnFacebook);
			panel1.Controls.Add(btnServices);
			panel1.Controls.Add(panel2);
			panel1.Dock = System.Windows.Forms.DockStyle.Left;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(287, 700);
			panel1.TabIndex = 0;
			btnExitTool.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnExitTool.FlatAppearance.BorderSize = 0;
			btnExitTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnExitTool.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnExitTool.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnExitTool.Image = ns5.Class74.icons8_exit_25;
			btnExitTool.Location = new System.Drawing.Point(0, 575);
			btnExitTool.Name = "btnExitTool";
			btnExitTool.Size = new System.Drawing.Size(287, 42);
			btnExitTool.TabIndex = 2;
			btnExitTool.Text = "Thoát tool";
			btnExitTool.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnExitTool.UseVisualStyleBackColor = true;
			btnExitTool.Click += new System.EventHandler(btnExitTool_Click);
			btnUpdateVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnUpdateVersion.FlatAppearance.BorderSize = 0;
			btnUpdateVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnUpdateVersion.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnUpdateVersion.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnUpdateVersion.Image = ns5.Class74.icons8_update_left_rotation_25;
			btnUpdateVersion.Location = new System.Drawing.Point(0, 617);
			btnUpdateVersion.Name = "btnUpdateVersion";
			btnUpdateVersion.Size = new System.Drawing.Size(287, 42);
			btnUpdateVersion.TabIndex = 9;
			btnUpdateVersion.Text = "Cập nhật tool";
			btnUpdateVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnUpdateVersion.UseVisualStyleBackColor = true;
			btnUpdateVersion.Visible = false;
			btnUpdateVersion.Click += new System.EventHandler(btnUpdateVersion_Click);
			pnlNav.BackColor = System.Drawing.Color.FromArgb(0, 126, 249);
			pnlNav.Location = new System.Drawing.Point(0, 322);
			pnlNav.Name = "pnlNav";
			pnlNav.Size = new System.Drawing.Size(4, 200);
			pnlNav.TabIndex = 8;
			btnZalo.Dock = System.Windows.Forms.DockStyle.Top;
			btnZalo.FlatAppearance.BorderSize = 0;
			btnZalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnZalo.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnZalo.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnZalo.Image = ns5.Class74.icons8_zalo_25;
			btnZalo.Location = new System.Drawing.Point(0, 502);
			btnZalo.Name = "btnZalo";
			btnZalo.Size = new System.Drawing.Size(287, 52);
			btnZalo.TabIndex = 7;
			btnZalo.Text = "Auto Reg Zalo";
			btnZalo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnZalo.UseVisualStyleBackColor = true;
			btnZalo.Click += new System.EventHandler(btnZalo_Click);
			btnZalo.Leave += new System.EventHandler(btnZalo_Leave);
			btnShopee.Dock = System.Windows.Forms.DockStyle.Top;
			btnShopee.FlatAppearance.BorderSize = 0;
			btnShopee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnShopee.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnShopee.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnShopee.Image = ns5.Class74.icons8_shopee_25;
			btnShopee.Location = new System.Drawing.Point(0, 450);
			btnShopee.Name = "btnShopee";
			btnShopee.Size = new System.Drawing.Size(287, 52);
			btnShopee.TabIndex = 5;
			btnShopee.Text = "Auto Reg Shopee";
			btnShopee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnShopee.UseVisualStyleBackColor = true;
			btnShopee.Click += new System.EventHandler(btnShopee_Click);
			btnShopee.Leave += new System.EventHandler(btnShopee_Leave);
			btnInstagram.Dock = System.Windows.Forms.DockStyle.Top;
			btnInstagram.FlatAppearance.BorderSize = 0;
			btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnInstagram.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnInstagram.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnInstagram.Image = ns5.Class74.icons8_instagram_25__2_;
			btnInstagram.Location = new System.Drawing.Point(0, 398);
			btnInstagram.Name = "btnInstagram";
			btnInstagram.Size = new System.Drawing.Size(287, 52);
			btnInstagram.TabIndex = 4;
			btnInstagram.Text = "Auto Reg Instagram";
			btnInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnInstagram.UseVisualStyleBackColor = true;
			btnInstagram.Click += new System.EventHandler(btnInstagram_Click);
			btnInstagram.Leave += new System.EventHandler(btnInstagram_Leave);
			btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnLogout.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnLogout.Image = ns5.Class74.icons8_shutdown_25;
			btnLogout.Location = new System.Drawing.Point(0, 659);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new System.Drawing.Size(287, 41);
			btnLogout.TabIndex = 10;
			btnLogout.Text = "Đăng xuất";
			btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Visible = false;
			btnLogout.Click += new System.EventHandler(btnLogout_Click);
			btnFacebook.Dock = System.Windows.Forms.DockStyle.Top;
			btnFacebook.FlatAppearance.BorderSize = 0;
			btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnFacebook.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnFacebook.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnFacebook.Image = ns5.Class74.icons8_facebook_25__1_;
			btnFacebook.Location = new System.Drawing.Point(0, 346);
			btnFacebook.Name = "btnFacebook";
			btnFacebook.Size = new System.Drawing.Size(287, 52);
			btnFacebook.TabIndex = 2;
			btnFacebook.Text = "Auto Reg Facebook";
			btnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnFacebook.UseVisualStyleBackColor = true;
			btnFacebook.Click += new System.EventHandler(btnFacebook_Click);
			btnFacebook.Leave += new System.EventHandler(btnFacebook_Leave);
			btnServices.Dock = System.Windows.Forms.DockStyle.Top;
			btnServices.FlatAppearance.BorderSize = 0;
			btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnServices.Font = new System.Drawing.Font("Nirmala UI", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnServices.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			btnServices.Image = ns5.Class74.icons8_sign_in_form_password_25;
			btnServices.Location = new System.Drawing.Point(0, 294);
			btnServices.Name = "btnServices";
			btnServices.Size = new System.Drawing.Size(287, 52);
			btnServices.TabIndex = 2;
			btnServices.Text = "Đăng ký tool";
			btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			btnServices.UseVisualStyleBackColor = true;
			btnServices.Click += new System.EventHandler(btnServices_Click);
			btnServices.Leave += new System.EventHandler(btnServices_Leave);
			panel2.Controls.Add(panel7);
			panel2.Controls.Add(btnUpdateXu);
			panel2.Controls.Add(btnNapxu);
			panel2.Controls.Add(lblSoxu);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(lblUserName);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(label8);
			panel2.Dock = System.Windows.Forms.DockStyle.Top;
			panel2.Location = new System.Drawing.Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(287, 294);
			panel2.TabIndex = 1;
			panel7.BackColor = System.Drawing.Color.FromArgb(158, 161, 176);
			panel7.ForeColor = System.Drawing.Color.FromArgb(158, 161, 176);
			panel7.Location = new System.Drawing.Point(2, 285);
			panel7.Name = "panel7";
			panel7.Size = new System.Drawing.Size(280, 4);
			panel7.TabIndex = 8;
			btnUpdateXu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnUpdateXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnUpdateXu.ForeColor = System.Drawing.Color.FromArgb(50, 168, 50);
			btnUpdateXu.Location = new System.Drawing.Point(127, 220);
			btnUpdateXu.Name = "btnUpdateXu";
			btnUpdateXu.Size = new System.Drawing.Size(143, 49);
			btnUpdateXu.TabIndex = 2;
			btnUpdateXu.Text = "Cập nhật xu";
			btnUpdateXu.UseVisualStyleBackColor = true;
			btnUpdateXu.Click += new System.EventHandler(btnUpdateXu_Click);
			btnNapxu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnNapxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnNapxu.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			btnNapxu.Location = new System.Drawing.Point(16, 220);
			btnNapxu.Name = "btnNapxu";
			btnNapxu.Size = new System.Drawing.Size(105, 49);
			btnNapxu.TabIndex = 2;
			btnNapxu.Text = "Nạp xu";
			btnNapxu.UseVisualStyleBackColor = true;
			btnNapxu.Click += new System.EventHandler(btnNapxu_Click);
			lblSoxu.AutoSize = true;
			lblSoxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblSoxu.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			lblSoxu.Location = new System.Drawing.Point(141, 172);
			lblSoxu.Name = "lblSoxu";
			lblSoxu.Size = new System.Drawing.Size(49, 20);
			lblSoxu.TabIndex = 3;
			lblSoxu.Text = "1000";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.FromArgb(158, 161, 178);
			label2.Location = new System.Drawing.Point(82, 172);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(56, 18);
			label2.TabIndex = 2;
			label2.Text = "Số xu:";
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			label1.Location = new System.Drawing.Point(3, 141);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(79, 18);
			label1.TabIndex = 1;
			label1.Text = "Xin chào,";
			lblUserName.AutoSize = true;
			lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblUserName.ForeColor = System.Drawing.Color.FromArgb(50, 168, 50);
			lblUserName.Location = new System.Drawing.Point(93, 144);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new System.Drawing.Size(88, 17);
			lblUserName.TabIndex = 1;
			lblUserName.Text = "User Name";
			pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			pictureBox1.Image = ns5.Class74.Bitmap_1;
			pictureBox1.Location = new System.Drawing.Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(287, 138);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label8.Location = new System.Drawing.Point(66, 194);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(142, 17);
			label8.TabIndex = 0;
			label8.Text = "(1000 VND = 1 xu)";
			panel8.Controls.Add(btnMinimized);
			panel8.Controls.Add(btnClose);
			panel8.Dock = System.Windows.Forms.DockStyle.Top;
			panel8.Location = new System.Drawing.Point(287, 0);
			panel8.Name = "panel8";
			panel8.Size = new System.Drawing.Size(976, 44);
			panel8.TabIndex = 4;
			btnMinimized.FlatAppearance.BorderSize = 0;
			btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnMinimized.ForeColor = System.Drawing.Color.White;
			btnMinimized.Image = ns5.Class74.icons8_minimize_window_201;
			btnMinimized.Location = new System.Drawing.Point(892, 5);
			btnMinimized.Name = "btnMinimized";
			btnMinimized.Size = new System.Drawing.Size(33, 31);
			btnMinimized.TabIndex = 1;
			btnMinimized.UseVisualStyleBackColor = true;
			btnMinimized.Click += new System.EventHandler(btnMinimized_Click);
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.ForeColor = System.Drawing.Color.White;
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(931, 5);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(33, 31);
			btnClose.TabIndex = 1;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			timer_0.Interval = 18000000;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			pnlListProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			pnlListProduct.Controls.Add(panel9);
			pnlListProduct.Controls.Add(panel4);
			pnlListProduct.Controls.Add(label4);
			pnlListProduct.Controls.Add(panel6);
			pnlListProduct.Controls.Add(panel5);
			pnlListProduct.Controls.Add(panel3);
			pnlListProduct.Location = new System.Drawing.Point(287, 47);
			pnlListProduct.Name = "pnlListProduct";
			pnlListProduct.Size = new System.Drawing.Size(976, 650);
			pnlListProduct.TabIndex = 5;
			panel9.Controls.Add(label11);
			panel9.Controls.Add(lblVersion);
			panel9.Controls.Add(label10);
			panel9.Controls.Add(label7);
			panel9.Controls.Add(label3);
			panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
			panel9.Location = new System.Drawing.Point(0, 611);
			panel9.Name = "panel9";
			panel9.Size = new System.Drawing.Size(976, 39);
			panel9.TabIndex = 9;
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label11.ForeColor = System.Drawing.Color.White;
			label11.Location = new System.Drawing.Point(96, 15);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(99, 18);
			label11.TabIndex = 0;
			label11.Text = "Phong.Ittran";
			lblVersion.AutoSize = true;
			lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblVersion.ForeColor = System.Drawing.Color.White;
			lblVersion.Location = new System.Drawing.Point(914, 15);
			lblVersion.Name = "lblVersion";
			lblVersion.Size = new System.Drawing.Size(45, 18);
			lblVersion.TabIndex = 0;
			lblVersion.Text = "1.0.0";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label10.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			label10.Location = new System.Drawing.Point(3, 15);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(89, 18);
			label10.TabIndex = 0;
			label10.Text = "Developer:";
			label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			label7.Location = new System.Drawing.Point(399, 15);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(180, 18);
			label7.TabIndex = 0;
			label7.Text = "© Copyright 2021-2023";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			label3.Location = new System.Drawing.Point(838, 15);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(70, 18);
			label3.TabIndex = 0;
			label3.Text = "Version:";
			panel4.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel4.Controls.Add(btnRegInsta);
			panel4.Controls.Add(pictureBox3);
			panel4.Controls.Add(label9);
			panel4.Controls.Add(lblLimitInsta);
			panel4.Controls.Add(lblInstagram);
			panel4.Controls.Add(label12);
			panel4.Location = new System.Drawing.Point(521, 77);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(417, 196);
			panel4.TabIndex = 5;
			btnRegInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRegInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRegInsta.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			btnRegInsta.Location = new System.Drawing.Point(22, 128);
			btnRegInsta.Name = "btnRegInsta";
			btnRegInsta.Size = new System.Drawing.Size(130, 58);
			btnRegInsta.TabIndex = 2;
			btnRegInsta.Text = "Đăng ký";
			btnRegInsta.UseVisualStyleBackColor = true;
			btnRegInsta.Click += new System.EventHandler(btnRegInsta_Click);
			pictureBox3.Image = ns5.Class74.icons8_instagram_970;
			pictureBox3.Location = new System.Drawing.Point(267, 21);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(133, 113);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 1;
			pictureBox3.TabStop = false;
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			label9.Location = new System.Drawing.Point(15, 70);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(228, 36);
			label9.TabIndex = 0;
			label9.Text = "600 xu/1 tháng";
			lblLimitInsta.AutoSize = true;
			lblLimitInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLimitInsta.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLimitInsta.Location = new System.Drawing.Point(285, 151);
			lblLimitInsta.Name = "lblLimitInsta";
			lblLimitInsta.Size = new System.Drawing.Size(66, 18);
			lblLimitInsta.TabIndex = 0;
			lblLimitInsta.Text = "30 ngày";
			lblInstagram.AutoSize = true;
			lblInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblInstagram.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblInstagram.Location = new System.Drawing.Point(167, 151);
			lblInstagram.Name = "lblInstagram";
			lblInstagram.Size = new System.Drawing.Size(107, 18);
			lblInstagram.TabIndex = 0;
			lblInstagram.Text = "Hạn sử dụng:";
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label12.ForeColor = System.Drawing.Color.White;
			label12.Location = new System.Drawing.Point(24, 21);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(222, 28);
			label12.TabIndex = 0;
			label12.Text = "Auto Register Instagram";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.FromArgb(158, 161, 176);
			label4.Location = new System.Drawing.Point(37, 16);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(221, 39);
			label4.TabIndex = 4;
			label4.Text = "Đăng ký tool";
			panel6.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel6.Controls.Add(btnRegZalo);
			panel6.Controls.Add(pictureBox5);
			panel6.Controls.Add(label17);
			panel6.Controls.Add(lblLimitZalo);
			panel6.Controls.Add(lblZalo);
			panel6.Controls.Add(label20);
			panel6.Location = new System.Drawing.Point(521, 325);
			panel6.Name = "panel6";
			panel6.Size = new System.Drawing.Size(417, 196);
			panel6.TabIndex = 6;
			btnRegZalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRegZalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRegZalo.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			btnRegZalo.Location = new System.Drawing.Point(22, 128);
			btnRegZalo.Name = "btnRegZalo";
			btnRegZalo.Size = new System.Drawing.Size(130, 58);
			btnRegZalo.TabIndex = 2;
			btnRegZalo.Text = "Đăng ký";
			btnRegZalo.UseVisualStyleBackColor = true;
			btnRegZalo.Click += new System.EventHandler(btnRegZalo_Click);
			pictureBox5.Image = ns5.Class74.icons8_zalo_970;
			pictureBox5.Location = new System.Drawing.Point(267, 21);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(133, 113);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 1;
			pictureBox5.TabStop = false;
			label17.AutoSize = true;
			label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label17.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			label17.Location = new System.Drawing.Point(15, 70);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(228, 36);
			label17.TabIndex = 0;
			label17.Text = "400 xu/1 tháng";
			lblLimitZalo.AutoSize = true;
			lblLimitZalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLimitZalo.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLimitZalo.Location = new System.Drawing.Point(285, 151);
			lblLimitZalo.Name = "lblLimitZalo";
			lblLimitZalo.Size = new System.Drawing.Size(66, 18);
			lblLimitZalo.TabIndex = 0;
			lblLimitZalo.Text = "30 ngày";
			lblZalo.AutoSize = true;
			lblZalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblZalo.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblZalo.Location = new System.Drawing.Point(167, 151);
			lblZalo.Name = "lblZalo";
			lblZalo.Size = new System.Drawing.Size(107, 18);
			lblZalo.TabIndex = 0;
			lblZalo.Text = "Hạn sử dụng:";
			label20.AutoSize = true;
			label20.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label20.ForeColor = System.Drawing.Color.White;
			label20.Location = new System.Drawing.Point(15, 21);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(173, 28);
			label20.TabIndex = 0;
			label20.Text = "Auto Register Zalo";
			panel5.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel5.Controls.Add(btnRegShopee);
			panel5.Controls.Add(pictureBox4);
			panel5.Controls.Add(label13);
			panel5.Controls.Add(lblLimitShopee);
			panel5.Controls.Add(lblShopee);
			panel5.Controls.Add(label16);
			panel5.Location = new System.Drawing.Point(42, 325);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(417, 196);
			panel5.TabIndex = 7;
			btnRegShopee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRegShopee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRegShopee.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			btnRegShopee.Location = new System.Drawing.Point(22, 128);
			btnRegShopee.Name = "btnRegShopee";
			btnRegShopee.Size = new System.Drawing.Size(130, 58);
			btnRegShopee.TabIndex = 2;
			btnRegShopee.Text = "Đăng ký";
			btnRegShopee.UseVisualStyleBackColor = true;
			btnRegShopee.Click += new System.EventHandler(btnRegShopee_Click);
			pictureBox4.Image = ns5.Class74.icons8_shopee_970;
			pictureBox4.Location = new System.Drawing.Point(267, 21);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(133, 113);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 1;
			pictureBox4.TabStop = false;
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label13.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			label13.Location = new System.Drawing.Point(15, 70);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(228, 36);
			label13.TabIndex = 0;
			label13.Text = "500 xu/1 tháng";
			lblLimitShopee.AutoSize = true;
			lblLimitShopee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLimitShopee.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLimitShopee.Location = new System.Drawing.Point(285, 151);
			lblLimitShopee.Name = "lblLimitShopee";
			lblLimitShopee.Size = new System.Drawing.Size(66, 18);
			lblLimitShopee.TabIndex = 0;
			lblLimitShopee.Text = "30 ngày";
			lblShopee.AutoSize = true;
			lblShopee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblShopee.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblShopee.Location = new System.Drawing.Point(167, 151);
			lblShopee.Name = "lblShopee";
			lblShopee.Size = new System.Drawing.Size(107, 18);
			lblShopee.TabIndex = 0;
			lblShopee.Text = "Hạn sử dụng:";
			label16.AutoSize = true;
			label16.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label16.ForeColor = System.Drawing.Color.White;
			label16.Location = new System.Drawing.Point(15, 21);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(201, 28);
			label16.TabIndex = 0;
			label16.Text = "Auto Register Shopee";
			panel3.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel3.Controls.Add(btnRegFB);
			panel3.Controls.Add(pictureBox2);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(lblLimitFB);
			panel3.Controls.Add(lblFb);
			panel3.Controls.Add(label5);
			panel3.Location = new System.Drawing.Point(42, 77);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(417, 196);
			panel3.TabIndex = 8;
			btnRegFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRegFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRegFB.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			btnRegFB.Location = new System.Drawing.Point(22, 128);
			btnRegFB.Name = "btnRegFB";
			btnRegFB.Size = new System.Drawing.Size(130, 58);
			btnRegFB.TabIndex = 2;
			btnRegFB.Text = "Đăng ký";
			btnRegFB.UseVisualStyleBackColor = true;
			btnRegFB.Click += new System.EventHandler(btnRegFB_Click);
			pictureBox2.Image = ns5.Class74.icons8_facebook_970;
			pictureBox2.Location = new System.Drawing.Point(267, 21);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(133, 113);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
			label6.Location = new System.Drawing.Point(15, 70);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(228, 36);
			label6.TabIndex = 0;
			label6.Text = "800 xu/1 tháng";
			lblLimitFB.AutoSize = true;
			lblLimitFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLimitFB.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLimitFB.Location = new System.Drawing.Point(285, 151);
			lblLimitFB.Name = "lblLimitFB";
			lblLimitFB.Size = new System.Drawing.Size(66, 18);
			lblLimitFB.TabIndex = 0;
			lblLimitFB.Text = "30 ngày";
			lblFb.AutoSize = true;
			lblFb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblFb.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblFb.Location = new System.Drawing.Point(167, 151);
			lblFb.Name = "lblFb";
			lblFb.Size = new System.Drawing.Size(107, 18);
			lblFb.TabIndex = 0;
			lblFb.Text = "Hạn sử dụng:";
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(15, 21);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(219, 28);
			label5.TabIndex = 0;
			label5.Text = "Auto Register Facebook";
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = pictureBox1;
			bunifuDragControl_0.Vertical = true;
			bunifuDragControl_1.Fixed = true;
			bunifuDragControl_1.Horizontal = true;
			bunifuDragControl_1.TargetControl = panel8;
			bunifuDragControl_1.Vertical = true;
			timer_1.Interval = 10000;
			timer_1.Tick += new System.EventHandler(timer_1_Tick);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			base.ClientSize = new System.Drawing.Size(1263, 700);
			base.Controls.Add(pnlListProduct);
			base.Controls.Add(panel8);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmContainer";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Social Rabbit Tool";
			base.Load += new System.EventHandler(frmContainer_Load);
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel8.ResumeLayout(false);
			pnlListProduct.ResumeLayout(false);
			pnlListProduct.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}
	}
}
