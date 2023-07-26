using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns4;
using ns5;
using ns6;
using ToolRegFB.Properties;

namespace ns3
{
	internal class frmAutoFunction : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private Label label28;

		private PictureBox pictureBox1;

		private Panel panel1;

		private CheckBox chkAutoClearLD;

		private CheckBox cbTurnOnLDPlayer;

		private GroupBox groupBox1;

		private Panel panel2;

		private PictureBox pictureBox2;

		private NumericUpDown nudSizeFr;

		private ComboBox cbRamLD;

		private Label label3;

		private Label label2;

		private ComboBox cbCPULD;

		private Label label1;

		private NumericUpDown nudSizeTo;

		private NumericUpDown nudDPILD;

		private Label label4;

		private BunifuFlatButton btnSaveConf;

		private CheckBox ckAdbDebug;

		private BunifuDragControl bunifuDragControl_0;

		private GroupBox groupBox2;

		private Panel panel3;

		private Button btnDongBoDanhBa;

		private BunifuDragControl bunifuDragControl_1;

		private CheckBox ckDongBoDB;

		private Button btnAddMailReg;

		private CheckBox ckAddMailReg;

		private Label label5;

		private Button btnVeriphoneNoveri;

		private CheckBox ckVeriPhoneNoveri;

		private Button btnVeriMailNoveri;

		private CheckBox ckVeriMailNoveri;

		private CheckBox ckThuVeriCkpoint282;

		private RadioButton rdFbLite;

		private RadioButton rdFbKatana;

		private Label label6;
        private IContainer components;
        private CheckBox ckCheckUIDAndWall;

		public frmAutoFunction()
		{
			InitializeComponent();
			method_0();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void method_0()
		{
			try
			{
				cbCPULD.Text = Settings.Default.CpuLD;
				cbRamLD.Text = Settings.Default.RamLD;
				nudSizeFr.Value = Settings.Default.SizeLDFrom;
				nudSizeTo.Value = Settings.Default.SizeLDTo;
				nudDPILD.Value = Settings.Default.DPILD;
				if (Settings.Default.isAutoClearLD)
				{
					chkAutoClearLD.Checked = true;
				}
				if (Settings.Default.isOnGPSLD)
				{
					cbTurnOnLDPlayer.Checked = true;
				}
				if (Settings.Default.isAdbDebug)
				{
					ckAdbDebug.Checked = true;
				}
				if (Settings.Default.isDongBoDB)
				{
					ckDongBoDB.Checked = true;
					btnDongBoDanhBa.Enabled = true;
				}
				if (Settings.Default.isAddMailReg)
				{
					ckAddMailReg.Checked = true;
					btnAddMailReg.Enabled = true;
				}
				if (Settings.Default.isVeriPhoneNoveri)
				{
					ckVeriPhoneNoveri.Checked = true;
					btnVeriphoneNoveri.Enabled = true;
				}
				if (Settings.Default.isVeriMailNoveri)
				{
					ckVeriMailNoveri.Checked = true;
					btnVeriMailNoveri.Enabled = true;
				}
				if (Settings.Default.isThuVeriCheckPoint)
				{
					ckThuVeriCkpoint282.Checked = true;
				}
				if (Settings.Default.typeRunApp == 0)
				{
					rdFbKatana.Checked = true;
					rdFbLite.Checked = false;
				}
				else
				{
					rdFbLite.Checked = true;
					rdFbKatana.Checked = false;
				}
				if (Settings.Default.isCheckUID)
				{
					ckCheckUIDAndWall.Checked = true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void chkAutoClearLD_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cbTurnOnLDPlayer_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void nudSizeFr_ValueChanged(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void btnSaveConf_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbCPULD.GetItemText(cbCPULD.SelectedItem) == string.Empty)
				{
					MessageBox.Show("Chưa chọn loại CPU", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (cbRamLD.GetItemText(cbRamLD.SelectedItem) == string.Empty)
				{
					MessageBox.Show("Chưa chọn loại Ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (nudSizeFr.Value < 320m)
				{
					MessageBox.Show("Chiều ngang LDPlayer tối thiểu là 320", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (nudSizeTo.Value < 480m)
				{
					MessageBox.Show("Chiều dọc LDPlayer tối thiểu là 480", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (nudDPILD.Value < 120m)
				{
					MessageBox.Show("DPI LDPlayer tối thiểu là 120", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				Settings.Default.CpuLD = cbCPULD.GetItemText(cbCPULD.SelectedItem);
				Settings.Default.RamLD = cbRamLD.GetItemText(cbRamLD.SelectedItem);
				Settings.Default.SizeLDFrom = Convert.ToInt32(nudSizeFr.Value);
				Settings.Default.SizeLDTo = Convert.ToInt32(nudSizeTo.Value);
				Settings.Default.DPILD = Convert.ToInt32(nudDPILD.Value);
				if (chkAutoClearLD.Checked)
				{
					Settings.Default.isAutoClearLD = true;
				}
				else
				{
					Settings.Default.isAutoClearLD = false;
				}
				if (cbTurnOnLDPlayer.Checked)
				{
					Settings.Default.isOnGPSLD = true;
				}
				else
				{
					Settings.Default.isOnGPSLD = false;
				}
				if (ckAdbDebug.Checked)
				{
					Settings.Default.isAdbDebug = true;
				}
				else
				{
					Settings.Default.isAdbDebug = false;
				}
				if (ckDongBoDB.Checked)
				{
					Settings.Default.isDongBoDB = true;
				}
				else
				{
					Settings.Default.isDongBoDB = false;
				}
				if (ckAddMailReg.Checked)
				{
					Settings.Default.isAddMailReg = true;
				}
				else
				{
					Settings.Default.isAddMailReg = false;
				}
				if (ckVeriPhoneNoveri.Checked)
				{
					Settings.Default.isVeriPhoneNoveri = true;
				}
				else
				{
					Settings.Default.isVeriPhoneNoveri = false;
				}
				if (ckVeriMailNoveri.Checked)
				{
					Settings.Default.isVeriMailNoveri = true;
				}
				else
				{
					Settings.Default.isVeriMailNoveri = false;
				}
				if (ckThuVeriCkpoint282.Checked)
				{
					Settings.Default.isThuVeriCheckPoint = true;
				}
				else
				{
					Settings.Default.isThuVeriCheckPoint = false;
				}
				if (rdFbKatana.Checked)
				{
					Settings.Default.typeRunApp = 0;
				}
				else
				{
					Settings.Default.typeRunApp = 1;
				}
				if (ckCheckUIDAndWall.Checked)
				{
					Settings.Default.isCheckUID = true;
				}
				else
				{
					Settings.Default.isCheckUID = false;
				}
				Settings.Default.Save();
				MessageBox.Show("Lưu cấu hình thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void btnDongBoDanhBa_Click(object sender, EventArgs e)
		{
			frmDongBoDanhba frmDongBoDanhba = new frmDongBoDanhba();
			frmDongBoDanhba.ShowDialog();
		}

		private void ckDongBoDB_CheckedChanged(object sender, EventArgs e)
		{
			btnDongBoDanhBa.Enabled = ckDongBoDB.Checked;
		}

		private void btnAddMailReg_Click(object sender, EventArgs e)
		{
			Process.Start("EmailVeri.txt");
		}

		private void ckAddMailReg_CheckedChanged(object sender, EventArgs e)
		{
			btnAddMailReg.Enabled = ckAddMailReg.Checked;
		}

		private void ckVeriPhoneNoveri_CheckedChanged(object sender, EventArgs e)
		{
			btnVeriphoneNoveri.Enabled = ckVeriPhoneNoveri.Checked;
		}

		private void btnVeriphoneNoveri_Click(object sender, EventArgs e)
		{
			frmVeriPhoneNoveri frmVeriPhoneNoveri = new frmVeriPhoneNoveri();
			frmVeriPhoneNoveri.ShowDialog();
		}

		private void btnVeriMailNoveri_Click(object sender, EventArgs e)
		{
			frmVeriMailNoveri frmVeriMailNoveri = new frmVeriMailNoveri();
			frmVeriMailNoveri.ShowDialog();
		}

		private void ckVeriMailNoveri_CheckedChanged(object sender, EventArgs e)
		{
			btnVeriMailNoveri.Enabled = ckVeriMailNoveri.Checked;
		}

		private void ckThuVeriCkpoint282_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void ckCheckUIDAndWall_Click(object sender, EventArgs e)
		{
			if (ckThuVeriCkpoint282.Checked)
			{
				switch (MessageBox.Show("Khi sử dụng tính năng này:\nNếu bạn chọn veri bằng số điện thoại, nếu xác thực thất bại, có thể mất tiền OTP.\nBạn có thể chọn veri qua tempmail nhưng tỉ lệ thành công không cao.\nBạn có đồng ý sử dụng tính năng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
				{
				case DialogResult.Yes:
					ckThuVeriCkpoint282.Checked = true;
					break;
				case DialogResult.No:
					ckThuVeriCkpoint282.Checked = false;
					break;
				}
			}
		}

		private void rdFbKatana_CheckedChanged(object sender, EventArgs e)
		{
			rdFbLite.Checked = !rdFbKatana.Checked;
		}

		private void rdFbLite_CheckedChanged(object sender, EventArgs e)
		{
			rdFbKatana.Checked = !rdFbLite.Checked;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoFunction));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveConf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdFbLite = new System.Windows.Forms.RadioButton();
            this.rdFbKatana = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVeriMailNoveri = new System.Windows.Forms.Button();
            this.ckCheckUIDAndWall = new System.Windows.Forms.CheckBox();
            this.ckThuVeriCkpoint282 = new System.Windows.Forms.CheckBox();
            this.ckVeriMailNoveri = new System.Windows.Forms.CheckBox();
            this.btnVeriphoneNoveri = new System.Windows.Forms.Button();
            this.ckVeriPhoneNoveri = new System.Windows.Forms.CheckBox();
            this.btnAddMailReg = new System.Windows.Forms.Button();
            this.ckAddMailReg = new System.Windows.Forms.CheckBox();
            this.btnDongBoDanhBa = new System.Windows.Forms.Button();
            this.ckDongBoDB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ckAdbDebug = new System.Windows.Forms.CheckBox();
            this.chkAutoClearLD = new System.Windows.Forms.CheckBox();
            this.nudSizeTo = new System.Windows.Forms.NumericUpDown();
            this.nudDPILD = new System.Windows.Forms.NumericUpDown();
            this.nudSizeFr = new System.Windows.Forms.NumericUpDown();
            this.cbRamLD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCPULD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTurnOnLDPlayer = new System.Windows.Forms.CheckBox();
            this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPILD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeFr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1150, 46);
            this.panel4.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1103, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(42, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(245, 32);
            this.label28.TabIndex = 6;
            this.label28.Text = "Cài đặt nâng cao";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveConf);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 404);
            this.panel1.TabIndex = 9;
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveConf.BorderRadius = 0;
            this.btnSaveConf.ButtonText = "Lưu cấu hình";
            this.btnSaveConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConf.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveConf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveConf.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveConf.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveConf.Iconimage")));
            this.btnSaveConf.Iconimage_right = null;
            this.btnSaveConf.Iconimage_right_Selected = null;
            this.btnSaveConf.Iconimage_Selected = null;
            this.btnSaveConf.IconMarginLeft = 0;
            this.btnSaveConf.IconMarginRight = 0;
            this.btnSaveConf.IconRightVisible = true;
            this.btnSaveConf.IconRightZoom = 0D;
            this.btnSaveConf.IconVisible = false;
            this.btnSaveConf.IconZoom = 90D;
            this.btnSaveConf.IsTab = false;
            this.btnSaveConf.Location = new System.Drawing.Point(0, 345);
            this.btnSaveConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveConf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveConf.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveConf.selected = false;
            this.btnSaveConf.Size = new System.Drawing.Size(1150, 59);
            this.btnSaveConf.TabIndex = 2;
            this.btnSaveConf.Text = "Lưu cấu hình";
            this.btnSaveConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveConf.Textcolor = System.Drawing.Color.White;
            this.btnSaveConf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConf.Click += new System.EventHandler(this.btnSaveConf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(513, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng khác";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdFbLite);
            this.panel3.Controls.Add(this.rdFbKatana);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnVeriMailNoveri);
            this.panel3.Controls.Add(this.ckCheckUIDAndWall);
            this.panel3.Controls.Add(this.ckThuVeriCkpoint282);
            this.panel3.Controls.Add(this.ckVeriMailNoveri);
            this.panel3.Controls.Add(this.btnVeriphoneNoveri);
            this.panel3.Controls.Add(this.ckVeriPhoneNoveri);
            this.panel3.Controls.Add(this.btnAddMailReg);
            this.panel3.Controls.Add(this.ckAddMailReg);
            this.panel3.Controls.Add(this.btnDongBoDanhBa);
            this.panel3.Controls.Add(this.ckDongBoDB);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 279);
            this.panel3.TabIndex = 0;
            // 
            // rdFbLite
            // 
            this.rdFbLite.AutoSize = true;
            this.rdFbLite.Location = new System.Drawing.Point(268, 7);
            this.rdFbLite.Name = "rdFbLite";
            this.rdFbLite.Size = new System.Drawing.Size(136, 27);
            this.rdFbLite.TabIndex = 129;
            this.rdFbLite.TabStop = true;
            this.rdFbLite.Text = "Facebook Lite";
            this.rdFbLite.UseVisualStyleBackColor = true;
            this.rdFbLite.CheckedChanged += new System.EventHandler(this.rdFbLite_CheckedChanged);
            // 
            // rdFbKatana
            // 
            this.rdFbKatana.AutoSize = true;
            this.rdFbKatana.Location = new System.Drawing.Point(91, 7);
            this.rdFbKatana.Name = "rdFbKatana";
            this.rdFbKatana.Size = new System.Drawing.Size(161, 27);
            this.rdFbKatana.TabIndex = 129;
            this.rdFbKatana.TabStop = true;
            this.rdFbKatana.Text = "Facebook katana";
            this.rdFbKatana.UseVisualStyleBackColor = true;
            this.rdFbKatana.CheckedChanged += new System.EventHandler(this.rdFbKatana_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 128;
            this.label5.Text = "(Mỗi Email 1 dòng)";
            // 
            // btnVeriMailNoveri
            // 
            this.btnVeriMailNoveri.Enabled = false;
            this.btnVeriMailNoveri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeriMailNoveri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnVeriMailNoveri.Location = new System.Drawing.Point(43, 160);
            this.btnVeriMailNoveri.Name = "btnVeriMailNoveri";
            this.btnVeriMailNoveri.Size = new System.Drawing.Size(288, 34);
            this.btnVeriMailNoveri.TabIndex = 0;
            this.btnVeriMailNoveri.Text = "Veri mail sau khi reg noveri";
            this.btnVeriMailNoveri.UseVisualStyleBackColor = true;
            this.btnVeriMailNoveri.Click += new System.EventHandler(this.btnVeriMailNoveri_Click);
            // 
            // ckCheckUIDAndWall
            // 
            this.ckCheckUIDAndWall.AutoSize = true;
            this.ckCheckUIDAndWall.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCheckUIDAndWall.Location = new System.Drawing.Point(15, 232);
            this.ckCheckUIDAndWall.Name = "ckCheckUIDAndWall";
            this.ckCheckUIDAndWall.Size = new System.Drawing.Size(155, 24);
            this.ckCheckUIDAndWall.TabIndex = 0;
            this.ckCheckUIDAndWall.Text = "Check UID và Wall";
            this.ckCheckUIDAndWall.UseVisualStyleBackColor = true;
            this.ckCheckUIDAndWall.CheckedChanged += new System.EventHandler(this.ckThuVeriCkpoint282_CheckedChanged);
            this.ckCheckUIDAndWall.Click += new System.EventHandler(this.ckCheckUIDAndWall_Click);
            // 
            // ckThuVeriCkpoint282
            // 
            this.ckThuVeriCkpoint282.AutoSize = true;
            this.ckThuVeriCkpoint282.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckThuVeriCkpoint282.Location = new System.Drawing.Point(15, 205);
            this.ckThuVeriCkpoint282.Name = "ckThuVeriCkpoint282";
            this.ckThuVeriCkpoint282.Size = new System.Drawing.Size(164, 24);
            this.ckThuVeriCkpoint282.TabIndex = 0;
            this.ckThuVeriCkpoint282.Text = "Giải checkpoint 282";
            this.ckThuVeriCkpoint282.UseVisualStyleBackColor = true;
            this.ckThuVeriCkpoint282.CheckedChanged += new System.EventHandler(this.ckThuVeriCkpoint282_CheckedChanged);
            // 
            // ckVeriMailNoveri
            // 
            this.ckVeriMailNoveri.AutoSize = true;
            this.ckVeriMailNoveri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVeriMailNoveri.Location = new System.Drawing.Point(15, 168);
            this.ckVeriMailNoveri.Name = "ckVeriMailNoveri";
            this.ckVeriMailNoveri.Size = new System.Drawing.Size(18, 17);
            this.ckVeriMailNoveri.TabIndex = 0;
            this.ckVeriMailNoveri.UseVisualStyleBackColor = true;
            this.ckVeriMailNoveri.CheckedChanged += new System.EventHandler(this.ckVeriMailNoveri_CheckedChanged);
            // 
            // btnVeriphoneNoveri
            // 
            this.btnVeriphoneNoveri.Enabled = false;
            this.btnVeriphoneNoveri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeriphoneNoveri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnVeriphoneNoveri.Location = new System.Drawing.Point(43, 120);
            this.btnVeriphoneNoveri.Name = "btnVeriphoneNoveri";
            this.btnVeriphoneNoveri.Size = new System.Drawing.Size(288, 34);
            this.btnVeriphoneNoveri.TabIndex = 0;
            this.btnVeriphoneNoveri.Text = "Veri phone sau khi reg noveri";
            this.btnVeriphoneNoveri.UseVisualStyleBackColor = true;
            this.btnVeriphoneNoveri.Click += new System.EventHandler(this.btnVeriphoneNoveri_Click);
            // 
            // ckVeriPhoneNoveri
            // 
            this.ckVeriPhoneNoveri.AutoSize = true;
            this.ckVeriPhoneNoveri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVeriPhoneNoveri.Location = new System.Drawing.Point(15, 128);
            this.ckVeriPhoneNoveri.Name = "ckVeriPhoneNoveri";
            this.ckVeriPhoneNoveri.Size = new System.Drawing.Size(18, 17);
            this.ckVeriPhoneNoveri.TabIndex = 0;
            this.ckVeriPhoneNoveri.UseVisualStyleBackColor = true;
            this.ckVeriPhoneNoveri.CheckedChanged += new System.EventHandler(this.ckVeriPhoneNoveri_CheckedChanged);
            // 
            // btnAddMailReg
            // 
            this.btnAddMailReg.Enabled = false;
            this.btnAddMailReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMailReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddMailReg.Location = new System.Drawing.Point(43, 82);
            this.btnAddMailReg.Name = "btnAddMailReg";
            this.btnAddMailReg.Size = new System.Drawing.Size(171, 34);
            this.btnAddMailReg.TabIndex = 0;
            this.btnAddMailReg.Text = "Thêm mail sau reg";
            this.btnAddMailReg.UseVisualStyleBackColor = true;
            this.btnAddMailReg.Click += new System.EventHandler(this.btnAddMailReg_Click);
            // 
            // ckAddMailReg
            // 
            this.ckAddMailReg.AutoSize = true;
            this.ckAddMailReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAddMailReg.Location = new System.Drawing.Point(15, 90);
            this.ckAddMailReg.Name = "ckAddMailReg";
            this.ckAddMailReg.Size = new System.Drawing.Size(18, 17);
            this.ckAddMailReg.TabIndex = 0;
            this.ckAddMailReg.UseVisualStyleBackColor = true;
            this.ckAddMailReg.CheckedChanged += new System.EventHandler(this.ckAddMailReg_CheckedChanged);
            // 
            // btnDongBoDanhBa
            // 
            this.btnDongBoDanhBa.Enabled = false;
            this.btnDongBoDanhBa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongBoDanhBa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDongBoDanhBa.Location = new System.Drawing.Point(43, 43);
            this.btnDongBoDanhBa.Name = "btnDongBoDanhBa";
            this.btnDongBoDanhBa.Size = new System.Drawing.Size(171, 34);
            this.btnDongBoDanhBa.TabIndex = 0;
            this.btnDongBoDanhBa.Text = "Đồng bộ danh bạ";
            this.btnDongBoDanhBa.UseVisualStyleBackColor = true;
            this.btnDongBoDanhBa.Click += new System.EventHandler(this.btnDongBoDanhBa_Click);
            // 
            // ckDongBoDB
            // 
            this.ckDongBoDB.AutoSize = true;
            this.ckDongBoDB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDongBoDB.Location = new System.Drawing.Point(15, 51);
            this.ckDongBoDB.Name = "ckDongBoDB";
            this.ckDongBoDB.Size = new System.Drawing.Size(18, 17);
            this.ckDongBoDB.TabIndex = 0;
            this.ckDongBoDB.UseVisualStyleBackColor = true;
            this.ckDongBoDB.CheckedChanged += new System.EventHandler(this.ckDongBoDB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại App:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình LDPlayer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ckAdbDebug);
            this.panel2.Controls.Add(this.chkAutoClearLD);
            this.panel2.Controls.Add(this.nudSizeTo);
            this.panel2.Controls.Add(this.nudDPILD);
            this.panel2.Controls.Add(this.nudSizeFr);
            this.panel2.Controls.Add(this.cbRamLD);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbCPULD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbTurnOnLDPlayer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 279);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(156, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // ckAdbDebug
            // 
            this.ckAdbDebug.AutoSize = true;
            this.ckAdbDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAdbDebug.Location = new System.Drawing.Point(33, 232);
            this.ckAdbDebug.Name = "ckAdbDebug";
            this.ckAdbDebug.Size = new System.Drawing.Size(414, 24);
            this.ckAdbDebug.TabIndex = 0;
            this.ckAdbDebug.Text = "ADB Debug (Dành cho các phiên bản LDPlayer cao hơn)";
            this.ckAdbDebug.UseVisualStyleBackColor = true;
            this.ckAdbDebug.CheckedChanged += new System.EventHandler(this.chkAutoClearLD_CheckedChanged);
            // 
            // chkAutoClearLD
            // 
            this.chkAutoClearLD.AutoSize = true;
            this.chkAutoClearLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoClearLD.Location = new System.Drawing.Point(32, 202);
            this.chkAutoClearLD.Name = "chkAutoClearLD";
            this.chkAutoClearLD.Size = new System.Drawing.Size(233, 24);
            this.chkAutoClearLD.TabIndex = 0;
            this.chkAutoClearLD.Text = "Tự động clear cache LDPlayer";
            this.chkAutoClearLD.UseVisualStyleBackColor = true;
            this.chkAutoClearLD.CheckedChanged += new System.EventHandler(this.chkAutoClearLD_CheckedChanged);
            // 
            // nudSizeTo
            // 
            this.nudSizeTo.Location = new System.Drawing.Point(197, 94);
            this.nudSizeTo.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudSizeTo.Name = "nudSizeTo";
            this.nudSizeTo.Size = new System.Drawing.Size(67, 30);
            this.nudSizeTo.TabIndex = 3;
            this.nudSizeTo.ValueChanged += new System.EventHandler(this.nudSizeFr_ValueChanged);
            // 
            // nudDPILD
            // 
            this.nudDPILD.Location = new System.Drawing.Point(83, 131);
            this.nudDPILD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDPILD.Name = "nudDPILD";
            this.nudDPILD.Size = new System.Drawing.Size(67, 30);
            this.nudDPILD.TabIndex = 3;
            this.nudDPILD.ValueChanged += new System.EventHandler(this.nudSizeFr_ValueChanged);
            // 
            // nudSizeFr
            // 
            this.nudSizeFr.Location = new System.Drawing.Point(83, 94);
            this.nudSizeFr.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudSizeFr.Name = "nudSizeFr";
            this.nudSizeFr.Size = new System.Drawing.Size(67, 30);
            this.nudSizeFr.TabIndex = 3;
            this.nudSizeFr.ValueChanged += new System.EventHandler(this.nudSizeFr_ValueChanged);
            // 
            // cbRamLD
            // 
            this.cbRamLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRamLD.FormattingEnabled = true;
            this.cbRamLD.Items.AddRange(new object[] {
            "256M",
            "512M",
            "768M",
            "1024M (Khuyến nghị)",
            "1536M",
            "2048M",
            "3072M",
            "4096M",
            "8192M"});
            this.cbRamLD.Location = new System.Drawing.Point(83, 52);
            this.cbRamLD.Name = "cbRamLD";
            this.cbRamLD.Size = new System.Drawing.Size(233, 31);
            this.cbRamLD.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "DPI:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SIZE:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM:";
            // 
            // cbCPULD
            // 
            this.cbCPULD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPULD.FormattingEnabled = true;
            this.cbCPULD.Items.AddRange(new object[] {
            "1 cores (Khuyến nghị)",
            "2 cores",
            "3 cores",
            "4 cores",
            "6 cores"});
            this.cbCPULD.Location = new System.Drawing.Point(83, 10);
            this.cbCPULD.Name = "cbCPULD";
            this.cbCPULD.Size = new System.Drawing.Size(233, 31);
            this.cbCPULD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU:";
            // 
            // cbTurnOnLDPlayer
            // 
            this.cbTurnOnLDPlayer.AutoSize = true;
            this.cbTurnOnLDPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnOnLDPlayer.Location = new System.Drawing.Point(32, 172);
            this.cbTurnOnLDPlayer.Name = "cbTurnOnLDPlayer";
            this.cbTurnOnLDPlayer.Size = new System.Drawing.Size(149, 24);
            this.cbTurnOnLDPlayer.TabIndex = 0;
            this.cbTurnOnLDPlayer.Text = "Bật GPS LDPlayer";
            this.cbTurnOnLDPlayer.UseVisualStyleBackColor = true;
            this.cbTurnOnLDPlayer.CheckedChanged += new System.EventHandler(this.cbTurnOnLDPlayer_CheckedChanged);
            // 
            // bunifuDragControl_0
            // 
            this.bunifuDragControl_0.Fixed = true;
            this.bunifuDragControl_0.Horizontal = true;
            this.bunifuDragControl_0.TargetControl = this.panel4;
            this.bunifuDragControl_0.Vertical = true;
            // 
            // bunifuDragControl_1
            // 
            this.bunifuDragControl_1.Fixed = true;
            this.bunifuDragControl_1.Horizontal = true;
            this.bunifuDragControl_1.TargetControl = this.label28;
            this.bunifuDragControl_1.Vertical = true;
            // 
            // frmAutoFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAutoFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình nâng cao";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPILD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeFr)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
