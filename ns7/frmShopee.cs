using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;

namespace ns7
{
	internal class frmShopee : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnMaximum;

		private Button btnClose;

		private Button btnMinimized;

		private Label label28;

		private PictureBox pictureBox1;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		private Button btnSaveConf;

		private Button btnStop;

		private Button btnReg;

		private GroupBox groupBox2;

		private DataGridView dgvAcc;

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

		public frmShopee()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void method_0()
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

		private void btnMaximum_Click(object sender, EventArgs e)
		{
			method_0();
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns7.frmShopee));
			panel4 = new System.Windows.Forms.Panel();
			btnMaximum = new System.Windows.Forms.Button();
			btnClose = new System.Windows.Forms.Button();
			btnMinimized = new System.Windows.Forms.Button();
			label28 = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			btnSaveConf = new System.Windows.Forms.Button();
			btnStop = new System.Windows.Forms.Button();
			btnReg = new System.Windows.Forms.Button();
			groupBox2 = new System.Windows.Forms.GroupBox();
			dgvAcc = new System.Windows.Forms.DataGridView();
			cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			conf_2fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			token = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			passMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvAcc).BeginInit();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(btnMaximum);
			panel4.Controls.Add(btnClose);
			panel4.Controls.Add(btnMinimized);
			panel4.Controls.Add(label28);
			panel4.Controls.Add(pictureBox1);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(1924, 46);
			panel4.TabIndex = 8;
			btnMaximum.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnMaximum.FlatAppearance.BorderSize = 0;
			btnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMaximum.ForeColor = System.Drawing.Color.White;
			btnMaximum.Image = ns5.Class74.icons8_maximize_button_20;
			btnMaximum.Location = new System.Drawing.Point(1842, 2);
			btnMaximum.Name = "btnMaximum";
			btnMaximum.Size = new System.Drawing.Size(44, 34);
			btnMaximum.TabIndex = 7;
			btnMaximum.UseVisualStyleBackColor = true;
			btnMaximum.Click += new System.EventHandler(btnMaximum_Click);
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(1877, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			btnMinimized.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnMinimized.FlatAppearance.BorderSize = 0;
			btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnMinimized.Image = ns5.Class74.icons8_minimize_window_20;
			btnMinimized.Location = new System.Drawing.Point(1804, 0);
			btnMinimized.Name = "btnMinimized";
			btnMinimized.Size = new System.Drawing.Size(44, 39);
			btnMinimized.TabIndex = 5;
			btnMinimized.UseVisualStyleBackColor = true;
			btnMinimized.Click += new System.EventHandler(btnMinimized_Click);
			label28.AutoSize = true;
			label28.Font = new System.Drawing.Font("Nirmala UI", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label28.ForeColor = System.Drawing.Color.White;
			label28.Location = new System.Drawing.Point(42, 2);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(458, 38);
			label28.TabIndex = 6;
			label28.Text = "Auto Register Shopee On Chrome";
			pictureBox1.Image = ns5.Class74.icons8_shopee_970;
			pictureBox1.Location = new System.Drawing.Point(2, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(40, 40);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel4;
			bunifuDragControl_0.Vertical = true;
			bunifuDragControl_1.Fixed = true;
			bunifuDragControl_1.Horizontal = true;
			bunifuDragControl_1.TargetControl = label28;
			bunifuDragControl_1.Vertical = true;
			btnSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSaveConf.ForeColor = System.Drawing.Color.FromArgb(245, 99, 66);
			btnSaveConf.Image = ns5.Class74.icons8_setting_25;
			btnSaveConf.Location = new System.Drawing.Point(305, 64);
			btnSaveConf.Name = "btnSaveConf";
			btnSaveConf.Size = new System.Drawing.Size(140, 61);
			btnSaveConf.TabIndex = 15;
			btnSaveConf.Text = "Lưu cấu hình";
			btnSaveConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			btnSaveConf.UseVisualStyleBackColor = true;
			btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnStop.ForeColor = System.Drawing.Color.Red;
			btnStop.Image = ns5.Class74.icons8_stop_25__1_;
			btnStop.Location = new System.Drawing.Point(158, 63);
			btnStop.Name = "btnStop";
			btnStop.Size = new System.Drawing.Size(140, 61);
			btnStop.TabIndex = 16;
			btnStop.Text = "Dừng lại";
			btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			btnStop.UseVisualStyleBackColor = true;
			btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnReg.ForeColor = System.Drawing.Color.FromArgb(37, 189, 6);
			btnReg.Image = ns5.Class74.icons8_start_25__1_;
			btnReg.Location = new System.Drawing.Point(12, 63);
			btnReg.Name = "btnReg";
			btnReg.Size = new System.Drawing.Size(140, 61);
			btnReg.TabIndex = 17;
			btnReg.Text = "Bắt đầu";
			btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			btnReg.UseVisualStyleBackColor = true;
			groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			groupBox2.BackColor = System.Drawing.SystemColors.Control;
			groupBox2.Controls.Add(dgvAcc);
			groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			groupBox2.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
			groupBox2.Location = new System.Drawing.Point(12, 146);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(735, 884);
			groupBox2.TabIndex = 18;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh sách tài khoản";
			dgvAcc.AllowUserToAddRows = false;
			dgvAcc.AllowUserToDeleteRows = false;
			dgvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			dgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAcc.Columns.AddRange(cChose, cId, status, uid, pass, ho, ten, age, gender, conf_2fa, token, cookie, email, passMail, phone, proxy, cInfo, cDevice);
			dgvAcc.Dock = System.Windows.Forms.DockStyle.Fill;
			dgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			dgvAcc.Location = new System.Drawing.Point(3, 23);
			dgvAcc.Name = "dgvAcc";
			dgvAcc.RowHeadersVisible = false;
			dgvAcc.RowHeadersWidth = 51;
			dgvAcc.RowTemplate.Height = 24;
			dgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			dgvAcc.Size = new System.Drawing.Size(729, 858);
			dgvAcc.TabIndex = 1;
			cChose.HeaderText = "Chọn";
			cChose.MinimumWidth = 6;
			cChose.Name = "cChose";
			cChose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			cChose.Width = 85;
			cId.HeaderText = "STT";
			cId.MinimumWidth = 6;
			cId.Name = "cId";
			cId.Width = 50;
			status.HeaderText = "Trạng thái";
			status.MinimumWidth = 6;
			status.Name = "status";
			status.Width = 350;
			uid.HeaderText = "UID";
			uid.MinimumWidth = 6;
			uid.Name = "uid";
			uid.Width = 125;
			pass.HeaderText = "Mật khẩu";
			pass.MinimumWidth = 6;
			pass.Name = "pass";
			pass.Width = 125;
			ho.HeaderText = "Họ";
			ho.MinimumWidth = 6;
			ho.Name = "ho";
			ho.Width = 125;
			ten.HeaderText = "Tên";
			ten.MinimumWidth = 6;
			ten.Name = "ten";
			ten.Width = 125;
			age.HeaderText = "Tuổi";
			age.MinimumWidth = 6;
			age.Name = "age";
			age.Width = 125;
			gender.HeaderText = "Giới tính";
			gender.MinimumWidth = 6;
			gender.Name = "gender";
			gender.Width = 125;
			conf_2fa.HeaderText = "2Fa";
			conf_2fa.MinimumWidth = 6;
			conf_2fa.Name = "conf_2fa";
			conf_2fa.Width = 125;
			token.HeaderText = "Token";
			token.MinimumWidth = 6;
			token.Name = "token";
			token.Width = 125;
			cookie.HeaderText = "Cookie";
			cookie.MinimumWidth = 6;
			cookie.Name = "cookie";
			cookie.Width = 125;
			email.HeaderText = "Email";
			email.MinimumWidth = 6;
			email.Name = "email";
			email.Width = 125;
			passMail.HeaderText = "Pass Mail";
			passMail.MinimumWidth = 6;
			passMail.Name = "passMail";
			passMail.Width = 125;
			phone.HeaderText = "Phone";
			phone.MinimumWidth = 6;
			phone.Name = "phone";
			phone.Width = 125;
			proxy.HeaderText = "Proxy";
			proxy.MinimumWidth = 6;
			proxy.Name = "proxy";
			proxy.Width = 125;
			cInfo.HeaderText = "Tình trạng";
			cInfo.MinimumWidth = 6;
			cInfo.Name = "cInfo";
			cInfo.Width = 125;
			cDevice.HeaderText = "LD index";
			cDevice.MinimumWidth = 6;
			cDevice.Name = "cDevice";
			cDevice.Width = 125;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1924, 1055);
			base.Controls.Add(groupBox2);
			base.Controls.Add(btnSaveConf);
			base.Controls.Add(btnStop);
			base.Controls.Add(btnReg);
			base.Controls.Add(panel4);
			ForeColor = System.Drawing.Color.White;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmShopee";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Auto Register Shopee on Chrome";
			base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvAcc).EndInit();
			ResumeLayout(false);
		}
	}
}
