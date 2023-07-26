using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns7;

namespace ns6
{
	internal class frmVeriMailNoveri : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private Label label28;

		private PictureBox pictureBox1;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		private BunifuFlatButton btnSaveConf;

		private Panel pnlVeriMailNoveri;

		private RadioButton rdTempmail;

		public frmVeriMailNoveri()
		{
			InitializeComponent();
			method_0();
		}

		private void method_0()
		{
			try
			{
				Class48 @class = new Class48("setting_verimailaccnoveri.ini");
				if (!(@class.method_1("typeMail") != "") || Convert.ToInt32(@class.method_1("typeMail")) == 0)
				{
					rdTempmail.Checked = true;
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

		private void btnSaveConf_Click(object sender, EventArgs e)
		{
			try
			{
				Class48 @class = new Class48("setting_verimailaccnoveri.ini");
				int num = 0;
				if (rdTempmail.Checked)
				{
					num = 0;
				}
				@class.method_2("typeMail", num.ToString());
				MessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns6.frmVeriMailNoveri));
			panel4 = new System.Windows.Forms.Panel();
			btnClose = new System.Windows.Forms.Button();
			label28 = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			btnSaveConf = new Bunifu.Framework.UI.BunifuFlatButton();
			pnlVeriMailNoveri = new System.Windows.Forms.Panel();
			rdTempmail = new System.Windows.Forms.RadioButton();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			pnlVeriMailNoveri.SuspendLayout();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(btnClose);
			panel4.Controls.Add(label28);
			panel4.Controls.Add(pictureBox1);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(568, 46);
			panel4.TabIndex = 10;
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(521, 0);
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
			btnSaveConf.Location = new System.Drawing.Point(0, 391);
			btnSaveConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			btnSaveConf.Name = "btnSaveConf";
			btnSaveConf.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnSaveConf.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
			btnSaveConf.OnHoverTextColor = System.Drawing.Color.White;
			btnSaveConf.selected = false;
			btnSaveConf.Size = new System.Drawing.Size(568, 59);
			btnSaveConf.TabIndex = 11;
			btnSaveConf.Text = "Lưu cấu hình";
			btnSaveConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			btnSaveConf.Textcolor = System.Drawing.Color.White;
			btnSaveConf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSaveConf.Click += new System.EventHandler(btnSaveConf_Click);
			pnlVeriMailNoveri.Controls.Add(rdTempmail);
			pnlVeriMailNoveri.Dock = System.Windows.Forms.DockStyle.Fill;
			pnlVeriMailNoveri.Location = new System.Drawing.Point(0, 46);
			pnlVeriMailNoveri.Name = "pnlVeriMailNoveri";
			pnlVeriMailNoveri.Size = new System.Drawing.Size(568, 345);
			pnlVeriMailNoveri.TabIndex = 12;
			rdTempmail.AutoSize = true;
			rdTempmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			rdTempmail.Location = new System.Drawing.Point(32, 20);
			rdTempmail.Name = "rdTempmail";
			rdTempmail.Size = new System.Drawing.Size(126, 24);
			rdTempmail.TabIndex = 0;
			rdTempmail.TabStop = true;
			rdTempmail.Text = "Temp-mail.io";
			rdTempmail.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(568, 450);
			base.Controls.Add(pnlVeriMailNoveri);
			base.Controls.Add(btnSaveConf);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmVeriMailNoveri";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Veri Mail acc Noveri";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			pnlVeriMailNoveri.ResumeLayout(false);
			pnlVeriMailNoveri.PerformLayout();
			ResumeLayout(false);
		}
	}
}
