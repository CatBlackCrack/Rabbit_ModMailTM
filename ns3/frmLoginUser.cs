using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DeviceId;
using ns0;
using ns1;
using ns2;
using ns5;
using ns7;
using ToolRegFB;
using ToolRegFB.Properties;

namespace ns3
{
	internal class frmLoginUser : Form
	{
		[CompilerGenerated]
		private sealed class Class29
		{
			public Class83 class83_0;

			public frmLoginUser frmLoginUser_0;

			internal void method_0()
			{
				frmLoginUser_0.Visible = false;
				frmContainer frmContainer = new frmContainer(class83_0);
				frmContainer.ShowDialog();
				string text2 = (frmLoginUser_0.txtEmailSigin.Text = (frmLoginUser_0.txtPassSigin.Text = string.Empty));
				if (frmContainer.DialogResult != DialogResult.No)
				{
					frmLoginUser_0.Close();
				}
				if (Settings.Default.isRememe)
				{
					frmLoginUser_0.chkRememe.Checked = true;
					frmLoginUser_0.txtEmailSigin.Text = Settings.Default.userLogin;
					frmLoginUser_0.txtPassSigin.Text = Settings.Default.PassLogin;
				}
				else
				{
					frmLoginUser_0.chkRememe.Checked = false;
					frmLoginUser_0.txtEmailSigin.Text = string.Empty;
					frmLoginUser_0.txtPassSigin.Text = string.Empty;
				}
				frmLoginUser_0.Visible = true;
			}
		}

		[CompilerGenerated]
		private sealed class Class30
		{
			public Exception exception_0;

			public frmLoginUser frmLoginUser_0;

			internal void method_0()
			{
				frmLoginUser_0.btnSigin.Enabled = true;
				frmLoginUser_0.frmLoading_0.method_1();
				Common.smethod_82(exception_0, "Error_Login");
				MessageBox.Show("Đăng nhập không thành công. \nLỗi: " + exception_0.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private frmLoading frmLoading_0;

		private string string_0 = string.Empty;

		private IContainer icontainer_0 = null;

		private Button btnClose;

		private Button btnMinimize;

		private Panel panel1;

		private Panel panel2;

		private Label lblVersion;

		private Label label4;

		private Label label2;

		private PictureBox pictureBox1;

		private BunifuDragControl bunifuDragControl_0;

		private Button btnNapXu;

		private Button btnSignup1;

		private Button btnSigin1;

		private TabPage tabPage2;

		private TabPage tabPage1;

		private Label label3;

		private TabControl tabControl1;

		private LinkLabel lblLinkForgotPass;

		private Label label6;

		private BunifuCheckbox chkRememe;

		private Label label5;

		private Button btnSigin;

		private Label label1;

		private TextBox txtPassSigin;

		private TextBox txtEmailSigin;

		private TabPage tabPage3;

		private Label label7;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private TextBox txtRePass;

		private TextBox txtPassword;

		private TextBox txtEmail;

		private TextBox txtUserName;

		private Button btnSigup;

		private Label label14;

		private Button btnChangePass;

		private Label label13;

		private TextBox txtChangePass;

		private Label label12;

		private TextBox txtMailCPass;

		private Label lblMachineName;

		private Label label15;

		private PictureBox pictureBox2;

		public frmLoginUser()
		{
			InitializeComponent();
			Class48 @class = new Class48("update.ini");
			lblVersion.Text = @class.method_1("Version", "Infor");
			string_0 = Common.smethod_79(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString());
			lblMachineName.Text = string_0;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void method_0()
		{
			if (chkRememe.Checked)
			{
				if (txtEmailSigin.Text != string.Empty && txtPassSigin.Text != string.Empty)
				{
					Settings.Default.userLogin = txtEmailSigin.Text.Trim();
					Settings.Default.PassLogin = txtPassSigin.Text.Trim();
					Settings.Default.isRememe = chkRememe.Checked;
					Settings.Default.Save();
				}
			}
			else
			{
				Settings.Default.userLogin = string.Empty;
				Settings.Default.PassLogin = string.Empty;
				Settings.Default.isRememe = false;
				Settings.Default.Save();
			}
		}

		private void frmLoginUser_Load(object sender, EventArgs e)
		{
			if (Settings.Default.isRememe)
			{
				chkRememe.Checked = true;
				txtEmailSigin.Text = Settings.Default.userLogin;
				txtPassSigin.Text = Settings.Default.PassLogin;
			}
			else
			{
				chkRememe.Checked = false;
			}
		}

		private void btnSigin1_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(0);
		}

		private void btnSignup1_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(1);
		}

		private void btnNapXu_Click(object sender, EventArgs e)
		{
			if (!Common.smethod_84("frmNapxu"))
			{
				string text = "+ Tài khoản đăng ký";
				frmNapxu frmNapxu = new frmNapxu(text);
				frmNapxu.ShowDialog();
			}
		}

		private void lblLinkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			tabControl1.SelectTab(2);
		}

		private void btnSigin_Click(object sender, EventArgs e)
		{
			if (txtEmailSigin.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtEmailSigin.Focus();
				return;
			}
			if (!new EmailAddressAttribute().IsValid(txtEmailSigin.Text.Trim()))
			{
				MessageBox.Show("Email định dạng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtEmailSigin.Focus();
				return;
			}
			if (txtPassSigin.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtPassSigin.Focus();
				return;
			}
			method_0();
			frmLoading_0 = new frmLoading(base.Width, base.Height, base.Location.X, base.Location.Y);
			Class83 class83_0;
			Exception exception_0;
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnSigin.Invoke((MethodInvoker)delegate
					{
						btnSigin.Enabled = false;
						frmLoading_0.string_0 = "Đang đăng nhập...";
						frmLoading_0.method_0();
					});
					class83_0 = Class0.smethod_2(txtEmailSigin.Text.Trim(), txtPassSigin.Text.Trim(), string_0);
					btnSigin.Invoke((MethodInvoker)delegate
					{
						btnSigin.Enabled = true;
						frmLoading_0.method_1();
					});
					if (class83_0 == null)
					{
						MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hoặc bạn chưa nạp để kích hoạt tool, hoặc bạn đã đăng nhập trên máy khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						btnSigin.Invoke((MethodInvoker)delegate
						{
							base.Visible = false;
							frmContainer frmContainer = new frmContainer(class83_0);
							frmContainer.ShowDialog();
							string text2 = (txtEmailSigin.Text = (txtPassSigin.Text = string.Empty));
							if (frmContainer.DialogResult != DialogResult.No)
							{
								Close();
							}
							if (Settings.Default.isRememe)
							{
								chkRememe.Checked = true;
								txtEmailSigin.Text = Settings.Default.userLogin;
								txtPassSigin.Text = Settings.Default.PassLogin;
							}
							else
							{
								chkRememe.Checked = false;
								txtEmailSigin.Text = string.Empty;
								txtPassSigin.Text = string.Empty;
							}
							base.Visible = true;
						});
					}
				}
				catch (Exception ex)
				{
					exception_0 = ex;
					btnSigin.Invoke((MethodInvoker)delegate
					{
						btnSigin.Enabled = true;
						frmLoading_0.method_1();
						Common.smethod_82(exception_0, "Error_Login");
						MessageBox.Show("Đăng nhập không thành công. \nLỗi: " + exception_0.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					});
				}
			}).Start();
		}

		private void chkRememe_OnChange(object sender, EventArgs e)
		{
			method_0();
		}

		private void btnSigup_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtUserName.Focus();
				return;
			}
			if (txtEmail.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtEmail.Focus();
				return;
			}
			if (!new EmailAddressAttribute().IsValid(txtEmail.Text.Trim()))
			{
				MessageBox.Show("Email định dạng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtEmail.Focus();
				return;
			}
			if (txtPassword.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtPassword.Focus();
				return;
			}
			if (txtRePass.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtRePass.Focus();
				return;
			}
			if (txtRePass.Text.Trim() != txtPassword.Text.Trim())
			{
				MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtRePass.Focus();
				return;
			}
			frmLoading_0 = new frmLoading(base.Width, base.Height, base.Location.X, base.Location.Y);
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnSignup1.Invoke((MethodInvoker)delegate
					{
						btnSignup1.Enabled = false;
						frmLoading_0.string_0 = "Đang đăng ký...";
						frmLoading_0.method_0();
					});
					Class83 class83_ = new Class83
					{
						name = txtUserName.Text.Trim(),
						email = txtEmail.Text.Trim(),
						password = txtPassword.Text.Trim(),
						macAddress = string_0
					};
					int num = Class0.smethod_0(class83_);
					btnSignup1.Invoke((MethodInvoker)delegate
					{
						btnSignup1.Enabled = true;
						frmLoading_0.method_1();
					});
					switch (num)
					{
					case 402:
						MessageBox.Show("Email này đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						break;
					case 401:
						MessageBox.Show("Nhiều tài khoản đã đăng ký trên máy này. Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						btnSignup1.Invoke((MethodInvoker)delegate
						{
							TextBox textBox = txtUserName;
							TextBox textBox2 = txtPassword;
							TextBox textBox3 = txtEmail;
							string text = (txtRePass.Text = string.Empty);
							string text3 = (textBox3.Text = text);
							string text6 = (textBox.Text = (textBox2.Text = text3));
							tabControl1.SelectTab(0);
						});
						break;
					case 404:
						MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						break;
					default:
						btnSignup1.Invoke((MethodInvoker)delegate
						{
							MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							txtEmailSigin.Text = txtEmail.Text.Trim();
							TextBox textBox4 = txtUserName;
							TextBox textBox5 = txtPassword;
							TextBox textBox6 = txtEmail;
							string text7 = (txtRePass.Text = string.Empty);
							string text9 = (textBox6.Text = text7);
							string text12 = (textBox4.Text = (textBox5.Text = text9));
							tabControl1.SelectTab(0);
						});
						break;
					}
				}
				catch (Exception)
				{
					btnSignup1.Invoke((MethodInvoker)delegate
					{
						btnSignup1.Enabled = true;
						frmLoading_0.method_1();
						MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					});
				}
			}).Start();
		}

		private void btnChangePass_Click(object sender, EventArgs e)
		{
			if (txtMailCPass.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtMailCPass.Focus();
				return;
			}
			if (!new EmailAddressAttribute().IsValid(txtMailCPass.Text.Trim()))
			{
				MessageBox.Show("Email định dạng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtMailCPass.Focus();
				return;
			}
			if (txtChangePass.Text.Trim() == "")
			{
				MessageBox.Show("Chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtChangePass.Focus();
				return;
			}
			frmLoading_0 = new frmLoading(base.Width, base.Height, base.Location.X, base.Location.Y);
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnChangePass.Invoke((MethodInvoker)delegate
					{
						frmLoading_0.string_0 = "Đang đổi mật khẩu...";
						frmLoading_0.method_0();
					});
					new Class83
					{
						name = txtUserName.Text.Trim(),
						email = txtEmail.Text.Trim(),
						password = txtPassword.Text.Trim(),
						macAddress = string_0
					};
					int num = Class0.smethod_1(txtMailCPass.Text.Trim(), txtChangePass.Text.Trim());
					btnChangePass.Invoke((MethodInvoker)delegate
					{
						frmLoading_0.method_1();
					});
					switch (num)
					{
					case 404:
						MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						break;
					case 201:
						MessageBox.Show("Mail này không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						break;
					default:
						btnChangePass.Invoke((MethodInvoker)delegate
						{
							MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							string text2 = (txtMailCPass.Text = (txtChangePass.Text = string.Empty));
							tabControl1.SelectTab(0);
						});
						break;
					}
				}
				catch (Exception)
				{
					btnChangePass.Invoke((MethodInvoker)delegate
					{
						frmLoading_0.method_1();
						MessageBox.Show("Đổi mật khẩu không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					});
				}
			}).Start();
		}

		private void txtEmailSigin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigin_Click(sender, e);
			}
		}

		private void txtPassSigin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigin_Click(sender, e);
			}
		}

		private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigup_Click(sender, e);
			}
		}

		private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigup_Click(sender, e);
			}
		}

		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigup_Click(sender, e);
			}
		}

		private void txtRePass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnSigup_Click(sender, e);
			}
		}

		private void txtMailCPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnChangePass_Click(sender, e);
			}
		}

		private void txtChangePass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToInt16(Keys.Return))
			{
				btnChangePass_Click(sender, e);
			}
		}

		private void method_1(object sender, EventArgs e)
		{
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblMachineName.Text);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns3.frmLoginUser));
			panel1 = new System.Windows.Forms.Panel();
			panel2 = new System.Windows.Forms.Panel();
			btnNapXu = new System.Windows.Forms.Button();
			btnSignup1 = new System.Windows.Forms.Button();
			btnSigin1 = new System.Windows.Forms.Button();
			lblMachineName = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			lblVersion = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			tabPage2 = new System.Windows.Forms.TabPage();
			btnSigup = new System.Windows.Forms.Button();
			label11 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			txtRePass = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			txtEmail = new System.Windows.Forms.TextBox();
			txtUserName = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			tabPage1 = new System.Windows.Forms.TabPage();
			lblLinkForgotPass = new System.Windows.Forms.LinkLabel();
			label6 = new System.Windows.Forms.Label();
			chkRememe = new Bunifu.Framework.UI.BunifuCheckbox();
			label5 = new System.Windows.Forms.Label();
			btnSigin = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			txtPassSigin = new System.Windows.Forms.TextBox();
			txtEmailSigin = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			tabControl1 = new System.Windows.Forms.TabControl();
			tabPage3 = new System.Windows.Forms.TabPage();
			label14 = new System.Windows.Forms.Label();
			btnChangePass = new System.Windows.Forms.Button();
			label13 = new System.Windows.Forms.Label();
			txtChangePass = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			txtMailCPass = new System.Windows.Forms.TextBox();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			btnMinimize = new System.Windows.Forms.Button();
			btnClose = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			panel1.Controls.Add(btnMinimize);
			panel1.Controls.Add(btnClose);
			panel1.Location = new System.Drawing.Point(372, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(585, 44);
			panel1.TabIndex = 13;
			panel2.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(btnNapXu);
			panel2.Controls.Add(btnSignup1);
			panel2.Controls.Add(btnSigin1);
			panel2.Controls.Add(lblMachineName);
			panel2.Controls.Add(label15);
			panel2.Controls.Add(lblVersion);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(pictureBox1);
			panel2.Dock = System.Windows.Forms.DockStyle.Left;
			panel2.Location = new System.Drawing.Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(370, 589);
			panel2.TabIndex = 14;
			btnNapXu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnNapXu.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnNapXu.Location = new System.Drawing.Point(116, 495);
			btnNapXu.Name = "btnNapXu";
			btnNapXu.Size = new System.Drawing.Size(131, 49);
			btnNapXu.TabIndex = 14;
			btnNapXu.Text = "Nạp xu";
			btnNapXu.UseVisualStyleBackColor = true;
			btnNapXu.Click += new System.EventHandler(btnNapXu_Click);
			btnSignup1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSignup1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSignup1.Location = new System.Drawing.Point(191, 440);
			btnSignup1.Name = "btnSignup1";
			btnSignup1.Size = new System.Drawing.Size(131, 49);
			btnSignup1.TabIndex = 2;
			btnSignup1.Text = "Đăng ký";
			btnSignup1.UseVisualStyleBackColor = true;
			btnSignup1.Click += new System.EventHandler(btnSignup1_Click);
			btnSigin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSigin1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSigin1.Location = new System.Drawing.Point(54, 440);
			btnSigin1.Name = "btnSigin1";
			btnSigin1.Size = new System.Drawing.Size(131, 49);
			btnSigin1.TabIndex = 1;
			btnSigin1.Text = "Đăng nhập";
			btnSigin1.UseVisualStyleBackColor = true;
			btnSigin1.Click += new System.EventHandler(btnSigin1_Click);
			lblMachineName.AutoSize = true;
			lblMachineName.Font = new System.Drawing.Font("Segoe UI", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblMachineName.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			lblMachineName.Location = new System.Drawing.Point(91, 561);
			lblMachineName.Name = "lblMachineName";
			lblMachineName.Size = new System.Drawing.Size(27, 19);
			lblMachineName.TabIndex = 12;
			lblMachineName.Text = "***";
			label15.AutoSize = true;
			label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label15.ForeColor = System.Drawing.Color.WhiteSmoke;
			label15.Location = new System.Drawing.Point(5, 555);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(87, 25);
			label15.TabIndex = 13;
			label15.Text = "Mã máy:";
			lblVersion.AutoSize = true;
			lblVersion.Font = new System.Drawing.Font("Segoe UI", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblVersion.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			lblVersion.Location = new System.Drawing.Point(197, 391);
			lblVersion.Name = "lblVersion";
			lblVersion.Size = new System.Drawing.Size(55, 25);
			lblVersion.TabIndex = 12;
			lblVersion.Text = "1.0.0";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			label4.Location = new System.Drawing.Point(111, 391);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(80, 25);
			label4.TabIndex = 13;
			label4.Text = "Version:";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.Location = new System.Drawing.Point(35, 319);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(288, 60);
			label2.TabIndex = 11;
			label2.Text = "Chào mừng mọi người đến \r\n    với Tool Social Rabbit";
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel1;
			bunifuDragControl_0.Vertical = true;
			tabPage2.Controls.Add(btnSigup);
			tabPage2.Controls.Add(label11);
			tabPage2.Controls.Add(label10);
			tabPage2.Controls.Add(label9);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(txtRePass);
			tabPage2.Controls.Add(txtPassword);
			tabPage2.Controls.Add(txtEmail);
			tabPage2.Controls.Add(txtUserName);
			tabPage2.Controls.Add(label7);
			tabPage2.Location = new System.Drawing.Point(4, 32);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new System.Windows.Forms.Padding(3);
			tabPage2.Size = new System.Drawing.Size(571, 467);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Đăng ký";
			tabPage2.UseVisualStyleBackColor = true;
			btnSigup.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			btnSigup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSigup.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSigup.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnSigup.Location = new System.Drawing.Point(420, 324);
			btnSigup.Name = "btnSigup";
			btnSigup.Size = new System.Drawing.Size(131, 49);
			btnSigup.TabIndex = 7;
			btnSigup.Text = "Đăng ký";
			btnSigup.UseVisualStyleBackColor = false;
			btnSigup.Click += new System.EventHandler(btnSigup_Click);
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label11.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label11.Location = new System.Drawing.Point(21, 269);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(184, 28);
			label11.TabIndex = 8;
			label11.Text = "Nhập lại mật khẩu:";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label10.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label10.Location = new System.Drawing.Point(21, 224);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(103, 28);
			label10.TabIndex = 8;
			label10.Text = "Mật khẩu:";
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label9.Location = new System.Drawing.Point(21, 177);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(65, 28);
			label9.TabIndex = 8;
			label9.Text = "Email:";
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label8.Location = new System.Drawing.Point(21, 129);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(237, 28);
			label8.TabIndex = 8;
			label8.Text = "Tên tham gia nhóm zalo:";
			txtRePass.Location = new System.Drawing.Point(272, 269);
			txtRePass.Name = "txtRePass";
			txtRePass.PasswordChar = '●';
			txtRePass.Size = new System.Drawing.Size(279, 30);
			txtRePass.TabIndex = 6;
			txtRePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtRePass_KeyPress);
			txtPassword.Location = new System.Drawing.Point(272, 224);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '●';
			txtPassword.Size = new System.Drawing.Size(279, 30);
			txtPassword.TabIndex = 5;
			txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassword_KeyPress);
			txtEmail.Location = new System.Drawing.Point(272, 177);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(279, 30);
			txtEmail.TabIndex = 4;
			txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtEmail_KeyPress);
			txtUserName.Location = new System.Drawing.Point(272, 129);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new System.Drawing.Size(279, 30);
			txtUserName.TabIndex = 3;
			txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtUserName_KeyPress);
			label7.BackColor = System.Drawing.Color.Transparent;
			label7.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label7.Location = new System.Drawing.Point(158, 39);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(314, 62);
			label7.TabIndex = 5;
			label7.Text = "Tạo tài khoản";
			tabPage1.Controls.Add(lblLinkForgotPass);
			tabPage1.Controls.Add(label6);
			tabPage1.Controls.Add(chkRememe);
			tabPage1.Controls.Add(label5);
			tabPage1.Controls.Add(btnSigin);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(txtPassSigin);
			tabPage1.Controls.Add(txtEmailSigin);
			tabPage1.Controls.Add(label3);
			tabPage1.Location = new System.Drawing.Point(4, 32);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new System.Windows.Forms.Padding(3);
			tabPage1.Size = new System.Drawing.Size(571, 467);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Đăng nhập";
			tabPage1.UseVisualStyleBackColor = true;
			lblLinkForgotPass.AutoSize = true;
			lblLinkForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLinkForgotPass.Location = new System.Drawing.Point(243, 301);
			lblLinkForgotPass.Name = "lblLinkForgotPass";
			lblLinkForgotPass.Size = new System.Drawing.Size(138, 23);
			lblLinkForgotPass.TabIndex = 17;
			lblLinkForgotPass.TabStop = true;
			lblLinkForgotPass.Text = "Quên mật khẩu?";
			lblLinkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lblLinkForgotPass_LinkClicked);
			label6.AutoSize = true;
			label6.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label6.Location = new System.Drawing.Point(185, 234);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(148, 23);
			label6.TabIndex = 16;
			label6.Text = "Ghi nhớ tài khoản";
			chkRememe.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chkRememe.ChechedOffColor = System.Drawing.Color.FromArgb(132, 135, 140);
			chkRememe.Checked = true;
			chkRememe.CheckedOnColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chkRememe.ForeColor = System.Drawing.Color.White;
			chkRememe.Location = new System.Drawing.Point(158, 237);
			chkRememe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			chkRememe.Name = "chkRememe";
			chkRememe.Size = new System.Drawing.Size(20, 20);
			chkRememe.TabIndex = 5;
			chkRememe.OnChange += new System.EventHandler(chkRememe_OnChange);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label5.Location = new System.Drawing.Point(49, 192);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(103, 28);
			label5.TabIndex = 6;
			label5.Text = "Mật khẩu:";
			btnSigin.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			btnSigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSigin.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSigin.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnSigin.Location = new System.Drawing.Point(391, 279);
			btnSigin.Name = "btnSigin";
			btnSigin.Size = new System.Drawing.Size(131, 49);
			btnSigin.TabIndex = 6;
			btnSigin.Text = "Đăng nhập";
			btnSigin.UseVisualStyleBackColor = false;
			btnSigin.Click += new System.EventHandler(btnSigin_Click);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label1.Location = new System.Drawing.Point(49, 142);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(65, 28);
			label1.TabIndex = 6;
			label1.Text = "Email:";
			txtPassSigin.Location = new System.Drawing.Point(158, 190);
			txtPassSigin.Name = "txtPassSigin";
			txtPassSigin.PasswordChar = '●';
			txtPassSigin.Size = new System.Drawing.Size(364, 30);
			txtPassSigin.TabIndex = 4;
			txtPassSigin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassSigin_KeyPress);
			txtEmailSigin.Location = new System.Drawing.Point(158, 140);
			txtEmailSigin.Name = "txtEmailSigin";
			txtEmailSigin.Size = new System.Drawing.Size(364, 30);
			txtEmailSigin.TabIndex = 3;
			txtEmailSigin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtEmailSigin_KeyPress);
			label3.BackColor = System.Drawing.Color.Transparent;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label3.Location = new System.Drawing.Point(172, 39);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(314, 62);
			label3.TabIndex = 4;
			label3.Text = "Đăng nhập";
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			tabControl1.Location = new System.Drawing.Point(372, 50);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(579, 503);
			tabControl1.TabIndex = 15;
			tabPage3.Controls.Add(label14);
			tabPage3.Controls.Add(btnChangePass);
			tabPage3.Controls.Add(label13);
			tabPage3.Controls.Add(txtChangePass);
			tabPage3.Controls.Add(label12);
			tabPage3.Controls.Add(txtMailCPass);
			tabPage3.Location = new System.Drawing.Point(4, 32);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new System.Windows.Forms.Padding(3);
			tabPage3.Size = new System.Drawing.Size(571, 467);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Đổi mật khẩu";
			tabPage3.UseVisualStyleBackColor = true;
			label14.BackColor = System.Drawing.Color.Transparent;
			label14.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label14.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label14.Location = new System.Drawing.Point(155, 50);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(314, 62);
			label14.TabIndex = 17;
			label14.Text = "Đổi mật khẩu";
			btnChangePass.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnChangePass.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnChangePass.Location = new System.Drawing.Point(384, 264);
			btnChangePass.Name = "btnChangePass";
			btnChangePass.Size = new System.Drawing.Size(131, 49);
			btnChangePass.TabIndex = 5;
			btnChangePass.Text = "Đổi ngay";
			btnChangePass.UseVisualStyleBackColor = false;
			btnChangePass.Click += new System.EventHandler(btnChangePass_Click);
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label13.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label13.Location = new System.Drawing.Point(63, 207);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(103, 28);
			label13.TabIndex = 12;
			label13.Text = "Mật khẩu:";
			txtChangePass.Location = new System.Drawing.Point(175, 207);
			txtChangePass.Name = "txtChangePass";
			txtChangePass.PasswordChar = '●';
			txtChangePass.Size = new System.Drawing.Size(340, 30);
			txtChangePass.TabIndex = 4;
			txtChangePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtChangePass_KeyPress);
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label12.ForeColor = System.Drawing.Color.FromArgb(46, 51, 73);
			label12.Location = new System.Drawing.Point(63, 152);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(65, 28);
			label12.TabIndex = 10;
			label12.Text = "Email:";
			txtMailCPass.Location = new System.Drawing.Point(175, 152);
			txtMailCPass.Name = "txtMailCPass";
			txtMailCPass.Size = new System.Drawing.Size(340, 30);
			txtMailCPass.TabIndex = 3;
			txtMailCPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtMailCPass_KeyPress);
			pictureBox2.Image = ns5.Class74.icons8_copy_24;
			pictureBox2.Location = new System.Drawing.Point(333, 522);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(33, 33);
			pictureBox2.TabIndex = 15;
			pictureBox2.TabStop = false;
			pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			pictureBox1.Image = ns5.Class74.Bitmap_1;
			pictureBox1.Location = new System.Drawing.Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(370, 316);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnMinimize.Image = ns5.Class74.icons8_minimize_window_25;
			btnMinimize.Location = new System.Drawing.Point(501, 4);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new System.Drawing.Size(37, 36);
			btnMinimize.TabIndex = 8;
			btnMinimize.Text = "button1";
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnClose.Image = ns5.Class74.icons8_x_20__3_;
			btnClose.Location = new System.Drawing.Point(542, 4);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(37, 36);
			btnClose.TabIndex = 9;
			btnClose.Text = "button1";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.WhiteSmoke;
			base.ClientSize = new System.Drawing.Size(957, 589);
			base.Controls.Add(tabControl1);
			base.Controls.Add(panel2);
			base.Controls.Add(panel1);
			ForeColor = System.Drawing.Color.WhiteSmoke;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmLoginUser";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Đăng ký & Đăng nhập";
			base.Load += new System.EventHandler(frmLoginUser_Load);
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		[CompilerGenerated]
		private void method_2()
		{
			try
			{
				btnSigin.Invoke((MethodInvoker)delegate
				{
					btnSigin.Enabled = false;
					frmLoading_0.string_0 = "Đang đăng nhập...";
					frmLoading_0.method_0();
				});
				Class83 class83_0 = Class0.smethod_2(txtEmailSigin.Text.Trim(), txtPassSigin.Text.Trim(), string_0);
				btnSigin.Invoke((MethodInvoker)delegate
				{
					btnSigin.Enabled = true;
					frmLoading_0.method_1();
				});
				if (class83_0 == null)
				{
					MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hoặc bạn chưa nạp để kích hoạt tool, hoặc bạn đã đăng nhập trên máy khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				btnSigin.Invoke((MethodInvoker)delegate
				{
					base.Visible = false;
					frmContainer frmContainer = new frmContainer(class83_0);
					frmContainer.ShowDialog();
					string text2 = (txtEmailSigin.Text = (txtPassSigin.Text = string.Empty));
					if (frmContainer.DialogResult != DialogResult.No)
					{
						Close();
					}
					if (Settings.Default.isRememe)
					{
						chkRememe.Checked = true;
						txtEmailSigin.Text = Settings.Default.userLogin;
						txtPassSigin.Text = Settings.Default.PassLogin;
					}
					else
					{
						chkRememe.Checked = false;
						txtEmailSigin.Text = string.Empty;
						txtPassSigin.Text = string.Empty;
					}
					base.Visible = true;
				});
			}
			catch (Exception ex)
			{
				Exception exception_0 = ex;
				btnSigin.Invoke((MethodInvoker)delegate
				{
					btnSigin.Enabled = true;
					frmLoading_0.method_1();
					Common.smethod_82(exception_0, "Error_Login");
					MessageBox.Show("Đăng nhập không thành công. \nLỗi: " + exception_0.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				});
			}
		}

		[CompilerGenerated]
		private void method_3()
		{
			btnSigin.Enabled = false;
			frmLoading_0.string_0 = "Đang đăng nhập...";
			frmLoading_0.method_0();
		}

		[CompilerGenerated]
		private void method_4()
		{
			btnSigin.Enabled = true;
			frmLoading_0.method_1();
		}

		[CompilerGenerated]
		private void method_5()
		{
			try
			{
				btnSignup1.Invoke((MethodInvoker)delegate
				{
					btnSignup1.Enabled = false;
					frmLoading_0.string_0 = "Đang đăng ký...";
					frmLoading_0.method_0();
				});
				Class83 class83_ = new Class83
				{
					name = txtUserName.Text.Trim(),
					email = txtEmail.Text.Trim(),
					password = txtPassword.Text.Trim(),
					macAddress = string_0
				};
				int num = Class0.smethod_0(class83_);
				btnSignup1.Invoke((MethodInvoker)delegate
				{
					btnSignup1.Enabled = true;
					frmLoading_0.method_1();
				});
				switch (num)
				{
				case 402:
					MessageBox.Show("Email này đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				case 401:
					MessageBox.Show("Nhiều tài khoản đã đăng ký trên máy này. Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					btnSignup1.Invoke((MethodInvoker)delegate
					{
						TextBox textBox4 = txtUserName;
						TextBox textBox5 = txtPassword;
						TextBox textBox6 = txtEmail;
						string text7 = (txtRePass.Text = string.Empty);
						string text9 = (textBox6.Text = text7);
						string text12 = (textBox4.Text = (textBox5.Text = text9));
						tabControl1.SelectTab(0);
					});
					return;
				case 404:
					MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				btnSignup1.Invoke((MethodInvoker)delegate
				{
					MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txtEmailSigin.Text = txtEmail.Text.Trim();
					TextBox textBox = txtUserName;
					TextBox textBox2 = txtPassword;
					TextBox textBox3 = txtEmail;
					string text = (txtRePass.Text = string.Empty);
					string text3 = (textBox3.Text = text);
					string text6 = (textBox.Text = (textBox2.Text = text3));
					tabControl1.SelectTab(0);
				});
			}
			catch (Exception)
			{
				btnSignup1.Invoke((MethodInvoker)delegate
				{
					btnSignup1.Enabled = true;
					frmLoading_0.method_1();
					MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				});
			}
		}

		[CompilerGenerated]
		private void method_6()
		{
			btnSignup1.Enabled = false;
			frmLoading_0.string_0 = "Đang đăng ký...";
			frmLoading_0.method_0();
		}

		[CompilerGenerated]
		private void method_7()
		{
			btnSignup1.Enabled = true;
			frmLoading_0.method_1();
		}

		[CompilerGenerated]
		private void method_8()
		{
			TextBox textBox = txtUserName;
			TextBox textBox2 = txtPassword;
			TextBox textBox3 = txtEmail;
			string text = (txtRePass.Text = string.Empty);
			string text3 = (textBox3.Text = text);
			string text6 = (textBox.Text = (textBox2.Text = text3));
			tabControl1.SelectTab(0);
		}

		[CompilerGenerated]
		private void method_9()
		{
			MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			txtEmailSigin.Text = txtEmail.Text.Trim();
			TextBox textBox = txtUserName;
			TextBox textBox2 = txtPassword;
			TextBox textBox3 = txtEmail;
			string text = (txtRePass.Text = string.Empty);
			string text3 = (textBox3.Text = text);
			string text6 = (textBox.Text = (textBox2.Text = text3));
			tabControl1.SelectTab(0);
		}

		[CompilerGenerated]
		private void method_10()
		{
			btnSignup1.Enabled = true;
			frmLoading_0.method_1();
			MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		[CompilerGenerated]
		private void method_11()
		{
			try
			{
				btnChangePass.Invoke((MethodInvoker)delegate
				{
					frmLoading_0.string_0 = "Đang đổi mật khẩu...";
					frmLoading_0.method_0();
				});
				new Class83
				{
					name = txtUserName.Text.Trim(),
					email = txtEmail.Text.Trim(),
					password = txtPassword.Text.Trim(),
					macAddress = string_0
				};
				int num = Class0.smethod_1(txtMailCPass.Text.Trim(), txtChangePass.Text.Trim());
				btnChangePass.Invoke((MethodInvoker)delegate
				{
					frmLoading_0.method_1();
				});
				switch (num)
				{
				case 404:
					MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				case 201:
					MessageBox.Show("Mail này không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				btnChangePass.Invoke((MethodInvoker)delegate
				{
					MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					string text2 = (txtMailCPass.Text = (txtChangePass.Text = string.Empty));
					tabControl1.SelectTab(0);
				});
			}
			catch (Exception)
			{
				btnChangePass.Invoke((MethodInvoker)delegate
				{
					frmLoading_0.method_1();
					MessageBox.Show("Đổi mật khẩu không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				});
			}
		}

		[CompilerGenerated]
		private void method_12()
		{
			frmLoading_0.string_0 = "Đang đổi mật khẩu...";
			frmLoading_0.method_0();
		}

		[CompilerGenerated]
		private void method_13()
		{
			frmLoading_0.method_1();
		}

		[CompilerGenerated]
		private void method_14()
		{
			MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			string text2 = (txtMailCPass.Text = (txtChangePass.Text = string.Empty));
			tabControl1.SelectTab(0);
		}

		[CompilerGenerated]
		private void method_15()
		{
			frmLoading_0.method_1();
			MessageBox.Show("Đổi mật khẩu không thành công. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
