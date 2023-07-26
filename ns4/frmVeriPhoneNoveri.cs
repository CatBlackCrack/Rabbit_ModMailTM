using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns7;
using ToolRegFB;

namespace ns4
{
	internal class frmVeriPhoneNoveri : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private Label label28;

		private PictureBox pictureBox1;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		private Panel pnlContent;

		private BunifuFlatButton btnSaveConf;

		private Panel pnlCodetextnow;

		private CheckBox ckCodetextnow;

		private Panel pnlPrimeotp;

		private CheckBox ckPrimeotp;

		private Panel pnlOtpmmo;

		private CheckBox ckOtpmmo;

		private Panel panel2;

		private Button btnCheckOtpmmo;

		private TextBox txtAPIOtpmmo;

		private Label label2;

		private Panel panel1;

		private Button btnCheckCodeText;

		private TextBox txtAPICodetext;

		private Label label1;

		private Panel panel3;

		private Button btnCheckPrimeotp;

		private TextBox txtPrimeotp;

		private Label label3;

		private Label label4;

		private NumericUpDown nudTimeGetPhone;

		private Label label5;

		private Panel panel5;

		private Panel panel6;

		private Button btnTempSMS;

		private TextBox txtTempSMS;

		private Label label6;

		private CheckBox ckTempSMS;

		private Panel panel8;

		private Panel panel7;

		private Button btnCheckBalanceRabbit;

		private TextBox txtAPIKeyRabbit;

		private Label label7;

		private CheckBox ckRabbitOtp;

		public frmVeriPhoneNoveri()
		{
			InitializeComponent();
			method_0();
		}

		private void method_0()
		{
			try
			{
				Class48 @class = new Class48("setting_veriaccnoveri.ini");
				nudTimeGetPhone.Value = ((@class.method_1("nudTimeGetPhone") != "") ? Convert.ToInt32(@class.method_1("nudTimeGetPhone")) : 10);
				int num = ((@class.method_1("typePhone") != "") ? Convert.ToInt32(@class.method_1("typePhone")) : 0);
				string text = ((@class.method_1("apikey") != "") ? @class.method_1("apikey") : "");
				switch (num)
				{
				case 0:
					ckCodetextnow.Checked = true;
					txtAPICodetext.Text = text;
					panel2.Enabled = false;
					panel3.Enabled = false;
					panel6.Enabled = false;
					panel7.Enabled = false;
					break;
				case 1:
					ckOtpmmo.Checked = true;
					txtAPIOtpmmo.Text = text;
					panel1.Enabled = false;
					panel3.Enabled = false;
					panel6.Enabled = false;
					panel7.Enabled = false;
					break;
				case 2:
					ckPrimeotp.Checked = true;
					txtPrimeotp.Text = text;
					panel1.Enabled = false;
					panel2.Enabled = false;
					panel6.Enabled = false;
					panel7.Enabled = false;
					break;
				case 3:
					ckTempSMS.Checked = true;
					txtTempSMS.Text = text;
					panel1.Enabled = false;
					panel2.Enabled = false;
					panel3.Enabled = false;
					panel7.Enabled = false;
					break;
				case 4:
					ckRabbitOtp.Checked = true;
					txtAPIKeyRabbit.Text = text;
					panel1.Enabled = false;
					panel2.Enabled = false;
					panel3.Enabled = false;
					panel6.Enabled = false;
					break;
				}
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ckCodetextnow_CheckedChanged(object sender, EventArgs e)
		{
			if (ckCodetextnow.Checked)
			{
				CheckBox checkBox = ckOtpmmo;
				CheckBox checkBox2 = ckPrimeotp;
				CheckBox checkBox3 = ckTempSMS;
				ckRabbitOtp.Checked = false;
				checkBox3.Checked = false;
				checkBox2.Checked = false;
				checkBox.Checked = false;
				panel1.Enabled = true;
				panel2.Enabled = false;
				panel3.Enabled = false;
				panel6.Enabled = false;
				panel7.Enabled = false;
			}
		}

		private void ckOtpmmo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckOtpmmo.Checked)
			{
				CheckBox checkBox = ckCodetextnow;
				CheckBox checkBox2 = ckPrimeotp;
				CheckBox checkBox3 = ckTempSMS;
				ckRabbitOtp.Checked = false;
				checkBox3.Checked = false;
				checkBox2.Checked = false;
				checkBox.Checked = false;
				panel2.Enabled = true;
				panel1.Enabled = false;
				panel3.Enabled = false;
				panel6.Enabled = false;
				panel7.Enabled = false;
			}
		}

		private void ckPrimeotp_CheckedChanged(object sender, EventArgs e)
		{
			if (ckPrimeotp.Checked)
			{
				CheckBox checkBox = ckCodetextnow;
				CheckBox checkBox2 = ckOtpmmo;
				CheckBox checkBox3 = ckTempSMS;
				ckRabbitOtp.Checked = false;
				checkBox3.Checked = false;
				checkBox2.Checked = false;
				checkBox.Checked = false;
				panel3.Enabled = true;
				panel1.Enabled = false;
				panel2.Enabled = false;
				panel6.Enabled = false;
				panel7.Enabled = false;
			}
		}

		private void btnSaveConf_Click(object sender, EventArgs e)
		{
			try
			{
				Class48 @class = new Class48("setting_veriaccnoveri.ini");
				int num = 0;
				string text = "";
				if (ckCodetextnow.Checked)
				{
					num = 0;
					text = txtAPICodetext.Text;
				}
				else if (ckOtpmmo.Checked)
				{
					num = 1;
					text = txtAPIOtpmmo.Text;
				}
				else if (ckPrimeotp.Checked)
				{
					num = 2;
					text = txtPrimeotp.Text;
				}
				else if (ckTempSMS.Checked)
				{
					num = 3;
					text = txtTempSMS.Text;
				}
				else if (ckRabbitOtp.Checked)
				{
					num = 4;
					text = txtAPIKeyRabbit.Text;
				}
				if (text == "")
				{
					MessageBox.Show("Vui lòng nhập API key", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				@class.method_2("typePhone", num.ToString());
				@class.method_2("apikey", text);
				@class.method_2("nudTimeGetPhone", nudTimeGetPhone.Value.ToString());
				MessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		

		private void btnCheckCodeText_Click(object sender, EventArgs e)
		{
			string text = txtAPICodetext.Text.ToString();
			string empty = string.Empty;

			empty = Common.smethod_15(text);
			if (empty == "")
			{
				MessageBox.Show("API key này không tồn tại", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Số tiền: " + empty, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnCheckOtpmmo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("OTPMMO không hỗ trợ API check Balance!!!" + Environment.NewLine + "Bạn kiểm tra số tiền trên web https://otpmmo.com trước khi chạy nha! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnCheckPrimeotp_Click(object sender, EventArgs e)
		{
			if (Common.smethod_17(txtPrimeotp.Text.Trim()))
			{
				MessageBox.Show("Api key hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Api key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnTempSMS_Click(object sender, EventArgs e)
		{
			string string_ = txtTempSMS.Text.Trim();
			string empty = string.Empty;
			empty = Common.smethod_13(string_);
			if (empty == "")
			{
				MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void ckTempSMS_CheckedChanged(object sender, EventArgs e)
		{
			if (ckTempSMS.Checked)
			{
				CheckBox checkBox = ckOtpmmo;
				CheckBox checkBox2 = ckPrimeotp;
				CheckBox checkBox3 = ckCodetextnow;
				ckRabbitOtp.Checked = false;
				checkBox3.Checked = false;
				checkBox2.Checked = false;
				checkBox.Checked = false;
				panel1.Enabled = false;
				panel2.Enabled = false;
				panel3.Enabled = false;
				panel6.Enabled = true;
				panel7.Enabled = false;
			}
		}

		private void btnCheckBalanceRabbit_Click(object sender, EventArgs e)
		{
			string string_ = txtAPIKeyRabbit.Text.Trim();
			string empty = string.Empty;
			empty = Common.smethod_14(string_);
			if (empty == "")
			{
				MessageBox.Show("API key này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Số tiền: " + empty, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void ckRabbitOtp_CheckedChanged(object sender, EventArgs e)
		{
			if (ckRabbitOtp.Checked)
			{
				CheckBox checkBox = ckOtpmmo;
				CheckBox checkBox2 = ckPrimeotp;
				CheckBox checkBox3 = ckCodetextnow;
				ckTempSMS.Checked = false;
				checkBox3.Checked = false;
				checkBox2.Checked = false;
				checkBox.Checked = false;
				panel1.Enabled = false;
				panel2.Enabled = false;
				panel3.Enabled = false;
				panel6.Enabled = false;
				panel7.Enabled = true;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns4.frmVeriPhoneNoveri));
			panel4 = new System.Windows.Forms.Panel();
			btnClose = new System.Windows.Forms.Button();
			label28 = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			pnlContent = new System.Windows.Forms.Panel();
			nudTimeGetPhone = new System.Windows.Forms.NumericUpDown();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			panel5 = new System.Windows.Forms.Panel();
			panel6 = new System.Windows.Forms.Panel();
			btnTempSMS = new System.Windows.Forms.Button();
			txtTempSMS = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			ckTempSMS = new System.Windows.Forms.CheckBox();
			pnlPrimeotp = new System.Windows.Forms.Panel();
			panel3 = new System.Windows.Forms.Panel();
			btnCheckPrimeotp = new System.Windows.Forms.Button();
			txtPrimeotp = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			ckPrimeotp = new System.Windows.Forms.CheckBox();
			panel8 = new System.Windows.Forms.Panel();
			panel7 = new System.Windows.Forms.Panel();
			btnCheckBalanceRabbit = new System.Windows.Forms.Button();
			txtAPIKeyRabbit = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			ckRabbitOtp = new System.Windows.Forms.CheckBox();
			pnlOtpmmo = new System.Windows.Forms.Panel();
			panel2 = new System.Windows.Forms.Panel();
			btnCheckOtpmmo = new System.Windows.Forms.Button();
			txtAPIOtpmmo = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			ckOtpmmo = new System.Windows.Forms.CheckBox();
			pnlCodetextnow = new System.Windows.Forms.Panel();
			panel1 = new System.Windows.Forms.Panel();
			btnCheckCodeText = new System.Windows.Forms.Button();
			txtAPICodetext = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			ckCodetextnow = new System.Windows.Forms.CheckBox();
			btnSaveConf = new Bunifu.Framework.UI.BunifuFlatButton();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudTimeGetPhone).BeginInit();
			panel5.SuspendLayout();
			panel6.SuspendLayout();
			pnlPrimeotp.SuspendLayout();
			panel3.SuspendLayout();
			panel8.SuspendLayout();
			panel7.SuspendLayout();
			pnlOtpmmo.SuspendLayout();
			panel2.SuspendLayout();
			pnlCodetextnow.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(btnClose);
			panel4.Controls.Add(label28);
			panel4.Controls.Add(pictureBox1);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(1002, 46);
			panel4.TabIndex = 9;
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(955, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			label28.AutoSize = true;
			label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label28.ForeColor = System.Drawing.Color.White;
			label28.Location = new System.Drawing.Point(42, 8);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(137, 32);
			label28.TabIndex = 6;
			label28.Text = "Cấu hình";
			pictureBox1.Image = ns5.Class74.icons8_facebook_970;
			pictureBox1.Location = new System.Drawing.Point(2, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(40, 40);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = label28;
			bunifuDragControl_0.Vertical = true;
			bunifuDragControl_1.Fixed = true;
			bunifuDragControl_1.Horizontal = true;
			bunifuDragControl_1.TargetControl = panel4;
			bunifuDragControl_1.Vertical = true;
			pnlContent.Controls.Add(nudTimeGetPhone);
			pnlContent.Controls.Add(label5);
			pnlContent.Controls.Add(label4);
			pnlContent.Controls.Add(panel5);
			pnlContent.Controls.Add(pnlPrimeotp);
			pnlContent.Controls.Add(panel8);
			pnlContent.Controls.Add(pnlOtpmmo);
			pnlContent.Controls.Add(pnlCodetextnow);
			pnlContent.Controls.Add(btnSaveConf);
			pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			pnlContent.Location = new System.Drawing.Point(0, 46);
			pnlContent.Name = "pnlContent";
			pnlContent.Size = new System.Drawing.Size(1002, 451);
			pnlContent.TabIndex = 10;
			nudTimeGetPhone.Location = new System.Drawing.Point(318, 346);
			nudTimeGetPhone.Maximum = new decimal(new int[4] { 3600, 0, 0, 0 });
			nudTimeGetPhone.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			nudTimeGetPhone.Name = "nudTimeGetPhone";
			nudTimeGetPhone.Size = new System.Drawing.Size(74, 22);
			nudTimeGetPhone.TabIndex = 6;
			nudTimeGetPhone.Value = new decimal(new int[4] { 10, 0, 0, 0 });
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.Location = new System.Drawing.Point(398, 348);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(39, 20);
			label5.TabIndex = 5;
			label5.Text = "giây";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.Location = new System.Drawing.Point(18, 349);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(258, 20);
			label4.TabIndex = 5;
			label4.Text = "Thời gian chờ giữa các lần lấy số:";
			panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel5.Controls.Add(panel6);
			panel5.Controls.Add(ckTempSMS);
			panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			panel5.Location = new System.Drawing.Point(512, 123);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(478, 97);
			panel5.TabIndex = 4;
			panel6.Controls.Add(btnTempSMS);
			panel6.Controls.Add(txtTempSMS);
			panel6.Controls.Add(label6);
			panel6.Location = new System.Drawing.Point(35, 27);
			panel6.Name = "panel6";
			panel6.Size = new System.Drawing.Size(421, 56);
			panel6.TabIndex = 1;
			btnTempSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnTempSMS.Location = new System.Drawing.Point(318, 6);
			btnTempSMS.Name = "btnTempSMS";
			btnTempSMS.Size = new System.Drawing.Size(100, 45);
			btnTempSMS.TabIndex = 7;
			btnTempSMS.Text = "Kiểm tra";
			btnTempSMS.UseVisualStyleBackColor = true;
			btnTempSMS.Click += new System.EventHandler(btnTempSMS_Click);
			txtTempSMS.Location = new System.Drawing.Point(80, 15);
			txtTempSMS.Name = "txtTempSMS";
			txtTempSMS.Size = new System.Drawing.Size(228, 27);
			txtTempSMS.TabIndex = 6;
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(3, 18);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(70, 20);
			label6.TabIndex = 5;
			label6.Text = "API key:";
			ckTempSMS.AutoSize = true;
			ckTempSMS.Location = new System.Drawing.Point(17, 3);
			ckTempSMS.Name = "ckTempSMS";
			ckTempSMS.Size = new System.Drawing.Size(198, 24);
			ckTempSMS.TabIndex = 0;
			ckTempSMS.Text = "TempSMS - 900đ/sms";
			ckTempSMS.UseVisualStyleBackColor = true;
			ckTempSMS.CheckedChanged += new System.EventHandler(ckTempSMS_CheckedChanged);
			pnlPrimeotp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pnlPrimeotp.Controls.Add(panel3);
			pnlPrimeotp.Controls.Add(ckPrimeotp);
			pnlPrimeotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlPrimeotp.Location = new System.Drawing.Point(512, 17);
			pnlPrimeotp.Name = "pnlPrimeotp";
			pnlPrimeotp.Size = new System.Drawing.Size(478, 97);
			pnlPrimeotp.TabIndex = 4;
			panel3.Controls.Add(btnCheckPrimeotp);
			panel3.Controls.Add(txtPrimeotp);
			panel3.Controls.Add(label3);
			panel3.Location = new System.Drawing.Point(35, 27);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(421, 56);
			panel3.TabIndex = 1;
			btnCheckPrimeotp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCheckPrimeotp.Location = new System.Drawing.Point(318, 6);
			btnCheckPrimeotp.Name = "btnCheckPrimeotp";
			btnCheckPrimeotp.Size = new System.Drawing.Size(100, 45);
			btnCheckPrimeotp.TabIndex = 7;
			btnCheckPrimeotp.Text = "Kiểm tra";
			btnCheckPrimeotp.UseVisualStyleBackColor = true;
			btnCheckPrimeotp.Click += new System.EventHandler(btnCheckPrimeotp_Click);
			txtPrimeotp.Location = new System.Drawing.Point(80, 15);
			txtPrimeotp.Name = "txtPrimeotp";
			txtPrimeotp.Size = new System.Drawing.Size(228, 27);
			txtPrimeotp.TabIndex = 6;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(3, 18);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(70, 20);
			label3.TabIndex = 5;
			label3.Text = "API key:";
			ckPrimeotp.AutoSize = true;
			ckPrimeotp.Location = new System.Drawing.Point(17, 3);
			ckPrimeotp.Name = "ckPrimeotp";
			ckPrimeotp.Size = new System.Drawing.Size(198, 24);
			ckPrimeotp.TabIndex = 0;
			ckPrimeotp.Text = "PrimeOTP - 450đ/sms";
			ckPrimeotp.UseVisualStyleBackColor = true;
			ckPrimeotp.CheckedChanged += new System.EventHandler(ckPrimeotp_CheckedChanged);
			panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel8.Controls.Add(panel7);
			panel8.Controls.Add(ckRabbitOtp);
			panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			panel8.Location = new System.Drawing.Point(12, 228);
			panel8.Name = "panel8";
			panel8.Size = new System.Drawing.Size(478, 97);
			panel8.TabIndex = 4;
			panel7.Controls.Add(btnCheckBalanceRabbit);
			panel7.Controls.Add(txtAPIKeyRabbit);
			panel7.Controls.Add(label7);
			panel7.Location = new System.Drawing.Point(35, 24);
			panel7.Name = "panel7";
			panel7.Size = new System.Drawing.Size(421, 56);
			panel7.TabIndex = 1;
			btnCheckBalanceRabbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCheckBalanceRabbit.Location = new System.Drawing.Point(318, 4);
			btnCheckBalanceRabbit.Name = "btnCheckBalanceRabbit";
			btnCheckBalanceRabbit.Size = new System.Drawing.Size(100, 45);
			btnCheckBalanceRabbit.TabIndex = 7;
			btnCheckBalanceRabbit.Text = "Kiểm tra";
			btnCheckBalanceRabbit.UseVisualStyleBackColor = true;
			btnCheckBalanceRabbit.Click += new System.EventHandler(btnCheckBalanceRabbit_Click);
			txtAPIKeyRabbit.Location = new System.Drawing.Point(80, 13);
			txtAPIKeyRabbit.Name = "txtAPIKeyRabbit";
			txtAPIKeyRabbit.Size = new System.Drawing.Size(228, 27);
			txtAPIKeyRabbit.TabIndex = 6;
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(3, 16);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(70, 20);
			label7.TabIndex = 5;
			label7.Text = "API key:";
			ckRabbitOtp.AutoSize = true;
			ckRabbitOtp.Location = new System.Drawing.Point(17, 3);
			ckRabbitOtp.Name = "ckRabbitOtp";
			ckRabbitOtp.Size = new System.Drawing.Size(202, 24);
			ckRabbitOtp.TabIndex = 0;
			ckRabbitOtp.Text = "RabbitOTP - 450đ/sms";
			ckRabbitOtp.UseVisualStyleBackColor = true;
			ckRabbitOtp.CheckedChanged += new System.EventHandler(ckRabbitOtp_CheckedChanged);
			pnlOtpmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pnlOtpmmo.Controls.Add(panel2);
			pnlOtpmmo.Controls.Add(ckOtpmmo);
			pnlOtpmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlOtpmmo.Location = new System.Drawing.Point(12, 123);
			pnlOtpmmo.Name = "pnlOtpmmo";
			pnlOtpmmo.Size = new System.Drawing.Size(478, 97);
			pnlOtpmmo.TabIndex = 4;
			panel2.Controls.Add(btnCheckOtpmmo);
			panel2.Controls.Add(txtAPIOtpmmo);
			panel2.Controls.Add(label2);
			panel2.Location = new System.Drawing.Point(35, 24);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(421, 56);
			panel2.TabIndex = 1;
			btnCheckOtpmmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCheckOtpmmo.Location = new System.Drawing.Point(318, 4);
			btnCheckOtpmmo.Name = "btnCheckOtpmmo";
			btnCheckOtpmmo.Size = new System.Drawing.Size(100, 45);
			btnCheckOtpmmo.TabIndex = 7;
			btnCheckOtpmmo.Text = "Kiểm tra";
			btnCheckOtpmmo.UseVisualStyleBackColor = true;
			btnCheckOtpmmo.Click += new System.EventHandler(btnCheckOtpmmo_Click);
			txtAPIOtpmmo.Location = new System.Drawing.Point(80, 13);
			txtAPIOtpmmo.Name = "txtAPIOtpmmo";
			txtAPIOtpmmo.Size = new System.Drawing.Size(228, 27);
			txtAPIOtpmmo.TabIndex = 6;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(3, 16);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(70, 20);
			label2.TabIndex = 5;
			label2.Text = "API key:";
			ckOtpmmo.AutoSize = true;
			ckOtpmmo.Location = new System.Drawing.Point(17, 3);
			ckOtpmmo.Name = "ckOtpmmo";
			ckOtpmmo.Size = new System.Drawing.Size(184, 24);
			ckOtpmmo.TabIndex = 0;
			ckOtpmmo.Text = "Otpmmo - 450đ/sms";
			ckOtpmmo.UseVisualStyleBackColor = true;
			ckOtpmmo.CheckedChanged += new System.EventHandler(ckOtpmmo_CheckedChanged);
			pnlCodetextnow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pnlCodetextnow.Controls.Add(panel1);
			pnlCodetextnow.Controls.Add(ckCodetextnow);
			pnlCodetextnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlCodetextnow.Location = new System.Drawing.Point(12, 17);
			pnlCodetextnow.Name = "pnlCodetextnow";
			pnlCodetextnow.Size = new System.Drawing.Size(478, 97);
			pnlCodetextnow.TabIndex = 4;
			panel1.Controls.Add(btnCheckCodeText);
			panel1.Controls.Add(txtAPICodetext);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(35, 24);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(421, 56);
			panel1.TabIndex = 5;
			btnCheckCodeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCheckCodeText.Location = new System.Drawing.Point(318, 4);
			btnCheckCodeText.Name = "btnCheckCodeText";
			btnCheckCodeText.Size = new System.Drawing.Size(100, 45);
			btnCheckCodeText.TabIndex = 7;
			btnCheckCodeText.Text = "Kiểm tra";
			btnCheckCodeText.UseVisualStyleBackColor = true;
			btnCheckCodeText.Click += new System.EventHandler(btnCheckCodeText_Click);
			txtAPICodetext.Location = new System.Drawing.Point(80, 13);
			txtAPICodetext.Name = "txtAPICodetext";
			txtAPICodetext.Size = new System.Drawing.Size(228, 27);
			txtAPICodetext.TabIndex = 6;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 16);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(70, 20);
			label1.TabIndex = 5;
			label1.Text = "API key:";
			ckCodetextnow.AutoSize = true;
			ckCodetextnow.Location = new System.Drawing.Point(17, 3);
			ckCodetextnow.Name = "ckCodetextnow";
			ckCodetextnow.Size = new System.Drawing.Size(216, 24);
			ckCodetextnow.TabIndex = 0;
			ckCodetextnow.Text = "Codetextnow - 450đ/sms";
			ckCodetextnow.UseVisualStyleBackColor = true;
			ckCodetextnow.CheckedChanged += new System.EventHandler(ckCodetextnow_CheckedChanged);
			btnSaveConf.Activecolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnSaveConf.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnSaveConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			btnSaveConf.BorderRadius = 0;
			btnSaveConf.ButtonText = "Lưu cấu hình";
			btnSaveConf.Cursor = System.Windows.Forms.Cursors.Hand;
			btnSaveConf.DisabledColor = System.Drawing.Color.Gray;
			btnSaveConf.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnSaveConf.Iconcolor = System.Drawing.Color.Transparent;
			btnSaveConf.Iconimage = (System.Drawing.Image)resources.GetObject("btnSaveConf.Iconimage");
			btnSaveConf.Iconimage_right = null;
			btnSaveConf.Iconimage_right_Selected = null;
			btnSaveConf.Iconimage_Selected = null;
			btnSaveConf.IconMarginLeft = 0;
			btnSaveConf.IconMarginRight = 0;
			btnSaveConf.IconRightVisible = true;
			btnSaveConf.IconRightZoom = 0.0;
			btnSaveConf.IconVisible = false;
			btnSaveConf.IconZoom = 90.0;
			btnSaveConf.IsTab = false;
			btnSaveConf.Location = new System.Drawing.Point(0, 392);
			btnSaveConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			btnSaveConf.Name = "btnSaveConf";
			btnSaveConf.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnSaveConf.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
			btnSaveConf.OnHoverTextColor = System.Drawing.Color.White;
			btnSaveConf.selected = false;
			btnSaveConf.Size = new System.Drawing.Size(1002, 59);
			btnSaveConf.TabIndex = 3;
			btnSaveConf.Text = "Lưu cấu hình";
			btnSaveConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			btnSaveConf.Textcolor = System.Drawing.Color.White;
			btnSaveConf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSaveConf.Click += new System.EventHandler(btnSaveConf_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1002, 497);
			base.Controls.Add(pnlContent);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmVeriPhoneNoveri";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Veri phone acc noveri";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			pnlContent.ResumeLayout(false);
			pnlContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudTimeGetPhone).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			pnlPrimeotp.ResumeLayout(false);
			pnlPrimeotp.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			pnlOtpmmo.ResumeLayout(false);
			pnlOtpmmo.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			pnlCodetextnow.ResumeLayout(false);
			pnlCodetextnow.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
