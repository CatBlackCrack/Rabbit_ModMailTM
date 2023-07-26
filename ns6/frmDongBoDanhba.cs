using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns7;
using ToolRegFB;

namespace ns6
{
	internal class frmDongBoDanhba : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private Label label28;

		private PictureBox pictureBox1;

		private RichTextBox txtListPhone;

		private Label lblListPhone;

		private Label label1;

		private Label label2;

		private NumericUpDown nPhoneFr;

		private Label label3;

		private NumericUpDown nPhoneTo;

		private CheckBox ckDeletePhone;

		private CheckBox ckAddFriends;

		private Panel pnlAddfriends;

		private Label label9;

		private Label label4;

		private Label label8;

		private Label label7;

		private Label label6;

		private NumericUpDown nDelayFr;

		private Label label5;

		private NumericUpDown nDelayTo;

		private NumericUpDown nKetbanFr;

		private NumericUpDown nKetBanTo;

		private BunifuFlatButton btnSaveConf;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		public frmDongBoDanhba()
		{
			InitializeComponent();
			method_0();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label9_Click(object sender, EventArgs e)
		{
		}

		private void method_0()
		{
			try
			{
				Class48 @class = new Class48("setting_danhba.ini");
				nPhoneFr.Value = ((@class.method_1("nPhoneFr") == null) ? 1 : Convert.ToInt32(@class.method_1("nPhoneFr")));
				nPhoneTo.Value = ((@class.method_1("nPhoneTo") != null) ? Convert.ToInt32(@class.method_1("nPhoneTo")) : 10);
				nKetbanFr.Value = ((@class.method_1("nKetbanFr") != null) ? Convert.ToInt32(@class.method_1("nKetbanFr")) : 2);
				nKetBanTo.Value = ((@class.method_1("nKetBanTo") != null) ? Convert.ToInt32(@class.method_1("nKetBanTo")) : 5);
				nDelayFr.Value = ((@class.method_1("nDelayFr") != null) ? Convert.ToInt32(@class.method_1("nDelayFr")) : 2);
				nDelayTo.Value = ((@class.method_1("nDelayTo") != null) ? Convert.ToInt32(@class.method_1("nDelayTo")) : 5);
				ckDeletePhone.Checked = @class.method_1("ckDeletePhone") != null && Convert.ToBoolean(@class.method_1("ckDeletePhone"));
				ckAddFriends.Checked = @class.method_1("ckAddFriends") != null && Convert.ToBoolean(@class.method_1("ckAddFriends"));
				string text = ((@class.method_1("txtListPhone") != null) ? @class.method_1("txtListPhone") : "");
				if (!(text != string.Empty))
				{
					return;
				}
				string[] array = text.Split('|');
				string text2 = string.Empty;
				for (int i = 0; i < array.Length; i++)
				{
					text2 += array[i];
					if (i < array.Length - 1)
					{
						text2 += Environment.NewLine;
					}
				}
				txtListPhone.Text = text2;
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void btnSaveConf_Click(object sender, EventArgs e)
		{
			try
			{
				Class48 @class = new Class48("setting_danhba.ini");
				@class.method_2("nPhoneFr", nPhoneFr.Value.ToString());
				@class.method_2("nPhoneTo", nPhoneTo.Value.ToString());
				@class.method_2("ckDeletePhone", ckDeletePhone.Checked.ToString());
				@class.method_2("ckAddFriends", ckAddFriends.Checked.ToString());
				@class.method_2("nKetbanFr", nKetbanFr.Value.ToString());
				@class.method_2("nKetBanTo", nKetBanTo.Value.ToString());
				@class.method_2("nDelayFr", nDelayFr.Value.ToString());
				@class.method_2("nDelayTo", nDelayTo.Value.ToString());
				if (txtListPhone.Text != "")
				{
					string[] array = txtListPhone.Text.Split('\n');
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
						@class.method_2("txtListPhone", text);
					}
				}
				else
				{
					@class.method_2("txtListPhone", string.Empty);
				}
				MessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void txtListPhone_TextChanged(object sender, EventArgs e)
		{
			List<string> list_ = txtListPhone.Lines.ToList();
			list_ = Common.smethod_77(list_);
			lblListPhone.Text = $"Nhập danh sách số điện thoại ({list_.Count.ToString()}):";
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns6.frmDongBoDanhba));
			panel4 = new System.Windows.Forms.Panel();
			label28 = new System.Windows.Forms.Label();
			btnClose = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			txtListPhone = new System.Windows.Forms.RichTextBox();
			lblListPhone = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			nPhoneFr = new System.Windows.Forms.NumericUpDown();
			label3 = new System.Windows.Forms.Label();
			nPhoneTo = new System.Windows.Forms.NumericUpDown();
			ckDeletePhone = new System.Windows.Forms.CheckBox();
			ckAddFriends = new System.Windows.Forms.CheckBox();
			pnlAddfriends = new System.Windows.Forms.Panel();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			nKetbanFr = new System.Windows.Forms.NumericUpDown();
			nKetBanTo = new System.Windows.Forms.NumericUpDown();
			label6 = new System.Windows.Forms.Label();
			nDelayTo = new System.Windows.Forms.NumericUpDown();
			nDelayFr = new System.Windows.Forms.NumericUpDown();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			btnSaveConf = new Bunifu.Framework.UI.BunifuFlatButton();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)nPhoneFr).BeginInit();
			((System.ComponentModel.ISupportInitialize)nPhoneTo).BeginInit();
			pnlAddfriends.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nKetbanFr).BeginInit();
			((System.ComponentModel.ISupportInitialize)nKetBanTo).BeginInit();
			((System.ComponentModel.ISupportInitialize)nDelayTo).BeginInit();
			((System.ComponentModel.ISupportInitialize)nDelayFr).BeginInit();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(btnClose);
			panel4.Controls.Add(label28);
			panel4.Controls.Add(pictureBox1);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(510, 46);
			panel4.TabIndex = 9;
			label28.AutoSize = true;
			label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label28.ForeColor = System.Drawing.Color.White;
			label28.Location = new System.Drawing.Point(42, 8);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(247, 32);
			label28.TabIndex = 6;
			label28.Text = "Đồng bộ danh bạ";
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(463, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			pictureBox1.Image = ns5.Class74.icons8_facebook_970;
			pictureBox1.Location = new System.Drawing.Point(2, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(40, 40);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			txtListPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			txtListPhone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtListPhone.Location = new System.Drawing.Point(24, 90);
			txtListPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtListPhone.Name = "txtListPhone";
			txtListPhone.Size = new System.Drawing.Size(459, 218);
			txtListPhone.TabIndex = 121;
			txtListPhone.Text = "";
			txtListPhone.WordWrap = false;
			txtListPhone.TextChanged += new System.EventHandler(txtListPhone_TextChanged);
			lblListPhone.AutoSize = true;
			lblListPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblListPhone.Location = new System.Drawing.Point(20, 60);
			lblListPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblListPhone.Name = "lblListPhone";
			lblListPhone.Size = new System.Drawing.Size(269, 23);
			lblListPhone.TabIndex = 120;
			lblListPhone.Text = "Nhập danh sách số điện thoại (0):";
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.Location = new System.Drawing.Point(20, 312);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(213, 23);
			label1.TabIndex = 120;
			label1.Text = "(Mỗi số điện thoại 1 dòng)";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.Location = new System.Drawing.Point(20, 347);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(179, 23);
			label2.TabIndex = 120;
			label2.Text = "Số lượng SĐT/thiết bị:";
			label2.Click += new System.EventHandler(label9_Click);
			nPhoneFr.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			nPhoneFr.Location = new System.Drawing.Point(222, 347);
			nPhoneFr.Name = "nPhoneFr";
			nPhoneFr.Size = new System.Drawing.Size(57, 25);
			nPhoneFr.TabIndex = 122;
			nPhoneFr.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.Location = new System.Drawing.Point(286, 347);
			label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(39, 23);
			label3.TabIndex = 120;
			label3.Text = "đến";
			label3.Click += new System.EventHandler(label9_Click);
			nPhoneTo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			nPhoneTo.Location = new System.Drawing.Point(332, 347);
			nPhoneTo.Name = "nPhoneTo";
			nPhoneTo.Size = new System.Drawing.Size(57, 25);
			nPhoneTo.TabIndex = 122;
			nPhoneTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
			ckDeletePhone.AutoSize = true;
			ckDeletePhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			ckDeletePhone.Location = new System.Drawing.Point(24, 383);
			ckDeletePhone.Name = "ckDeletePhone";
			ckDeletePhone.Size = new System.Drawing.Size(372, 27);
			ckDeletePhone.TabIndex = 123;
			ckDeletePhone.Text = "Tự động xóa số điện thoại đã được đồng bộ";
			ckDeletePhone.UseVisualStyleBackColor = true;
			ckAddFriends.AutoSize = true;
			ckAddFriends.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			ckAddFriends.Location = new System.Drawing.Point(24, 416);
			ckAddFriends.Name = "ckAddFriends";
			ckAddFriends.Size = new System.Drawing.Size(280, 27);
			ckAddFriends.TabIndex = 123;
			ckAddFriends.Text = "Tự động kết bạn nếu có đề xuất";
			ckAddFriends.UseVisualStyleBackColor = true;
			pnlAddfriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pnlAddfriends.Controls.Add(label9);
			pnlAddfriends.Controls.Add(label4);
			pnlAddfriends.Controls.Add(label8);
			pnlAddfriends.Controls.Add(label7);
			pnlAddfriends.Controls.Add(label6);
			pnlAddfriends.Controls.Add(nDelayFr);
			pnlAddfriends.Controls.Add(label5);
			pnlAddfriends.Controls.Add(nDelayTo);
			pnlAddfriends.Controls.Add(nKetbanFr);
			pnlAddfriends.Controls.Add(nKetBanTo);
			pnlAddfriends.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			pnlAddfriends.Location = new System.Drawing.Point(48, 450);
			pnlAddfriends.Name = "pnlAddfriends";
			pnlAddfriends.Size = new System.Drawing.Size(414, 80);
			pnlAddfriends.TabIndex = 124;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.Location = new System.Drawing.Point(6, 11);
			label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(83, 23);
			label4.TabIndex = 120;
			label4.Text = "Số lượng:";
			label4.Click += new System.EventHandler(label9_Click);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.Location = new System.Drawing.Point(203, 11);
			label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(39, 23);
			label5.TabIndex = 120;
			label5.Text = "đến";
			label5.Click += new System.EventHandler(label9_Click);
			nKetbanFr.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			nKetbanFr.Location = new System.Drawing.Point(139, 11);
			nKetbanFr.Name = "nKetbanFr";
			nKetbanFr.Size = new System.Drawing.Size(57, 25);
			nKetbanFr.TabIndex = 122;
			nKetbanFr.Value = new decimal(new int[4] { 2, 0, 0, 0 });
			nKetBanTo.Location = new System.Drawing.Point(249, 11);
			nKetBanTo.Name = "nKetBanTo";
			nKetBanTo.Size = new System.Drawing.Size(57, 25);
			nKetBanTo.TabIndex = 122;
			nKetBanTo.Value = new decimal(new int[4] { 5, 0, 0, 0 });
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.Location = new System.Drawing.Point(313, 11);
			label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(39, 23);
			label6.TabIndex = 120;
			label6.Text = "bạn";
			label6.Click += new System.EventHandler(label9_Click);
			nDelayTo.Location = new System.Drawing.Point(249, 45);
			nDelayTo.Name = "nDelayTo";
			nDelayTo.Size = new System.Drawing.Size(57, 25);
			nDelayTo.TabIndex = 122;
			nDelayTo.Value = new decimal(new int[4] { 5, 0, 0, 0 });
			nDelayFr.Location = new System.Drawing.Point(139, 45);
			nDelayFr.Name = "nDelayFr";
			nDelayFr.Size = new System.Drawing.Size(57, 25);
			nDelayFr.TabIndex = 122;
			nDelayFr.Value = new decimal(new int[4] { 2, 0, 0, 0 });
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.Location = new System.Drawing.Point(203, 45);
			label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(39, 23);
			label7.TabIndex = 120;
			label7.Text = "đến";
			label7.Click += new System.EventHandler(label9_Click);
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label8.Location = new System.Drawing.Point(313, 45);
			label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(42, 23);
			label8.TabIndex = 120;
			label8.Text = "giây";
			label8.Click += new System.EventHandler(label9_Click);
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label9.Location = new System.Drawing.Point(6, 45);
			label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(118, 23);
			label9.TabIndex = 120;
			label9.Text = "Thời gian chờ:";
			label9.Click += new System.EventHandler(label9_Click);
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
			btnSaveConf.Location = new System.Drawing.Point(0, 555);
			btnSaveConf.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			btnSaveConf.Name = "btnSaveConf";
			btnSaveConf.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnSaveConf.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
			btnSaveConf.OnHoverTextColor = System.Drawing.Color.White;
			btnSaveConf.selected = false;
			btnSaveConf.Size = new System.Drawing.Size(510, 47);
			btnSaveConf.TabIndex = 125;
			btnSaveConf.Text = "Lưu cấu hình";
			btnSaveConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			btnSaveConf.Textcolor = System.Drawing.Color.White;
			btnSaveConf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSaveConf.Click += new System.EventHandler(btnSaveConf_Click);
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel4;
			bunifuDragControl_0.Vertical = true;
			bunifuDragControl_1.Fixed = true;
			bunifuDragControl_1.Horizontal = true;
			bunifuDragControl_1.TargetControl = label28;
			bunifuDragControl_1.Vertical = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(510, 602);
			base.Controls.Add(btnSaveConf);
			base.Controls.Add(pnlAddfriends);
			base.Controls.Add(ckAddFriends);
			base.Controls.Add(ckDeletePhone);
			base.Controls.Add(nPhoneTo);
			base.Controls.Add(nPhoneFr);
			base.Controls.Add(txtListPhone);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Controls.Add(lblListPhone);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmDongBoDanhba";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Đồng bộ danh bạ";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)nPhoneFr).EndInit();
			((System.ComponentModel.ISupportInitialize)nPhoneTo).EndInit();
			pnlAddfriends.ResumeLayout(false);
			pnlAddfriends.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nKetbanFr).EndInit();
			((System.ComponentModel.ISupportInitialize)nKetBanTo).EndInit();
			((System.ComponentModel.ISupportInitialize)nDelayTo).EndInit();
			((System.ComponentModel.ISupportInitialize)nDelayFr).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
