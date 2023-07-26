using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns7;

namespace ns0
{
	internal class frmUpdateContent : Form
	{
		public const int int_0 = 161;

		public const int int_1 = 2;

		private Class48 class48_0 = null;

		private Class48 class48_1 = null;

		private string string_0 = "";

		private string string_1 = "";

		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Label label1;

		private Button btnClose;

		private Panel panel1;

		private BunifuCustomLabel bunifuCustomLabel2;

		private BunifuCustomLabel lblCurrent;

		private BunifuCustomLabel lblNew;

		private BunifuCustomLabel bunifuCustomLabel1;

		private BunifuFlatButton btnUpdateVersion;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr intptr_0, int int_2, int int_3, int int_4);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public frmUpdateContent()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		public static string smethod_0(string string_2)
		{
			byte[] bytes = Convert.FromBase64String(string_2);
			return Encoding.UTF8.GetString(bytes);
		}

		private void method_0(object sender, MouseEventArgs e)
		{
		}

		private void frmUpdateContent_Load(object sender, EventArgs e)
		{
			class48_0 = new Class48("./update/update.ini");
			string_0 = class48_0.method_1("Version", "Infor");
			lblNew.Text = string_0;
			class48_1 = new Class48("update.ini");
			string_1 = class48_1.method_1("Version", "Infor");
			lblCurrent.Text = string_1;
			try
			{
				string string_ = class48_0.method_1("Content", "Infor");
				string_ = smethod_0(string_);
			}
			catch
			{
			}
		}

		private void btnUpdateVersion_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật phiên bản mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			if (dialogResult == DialogResult.Yes)
			{
				frm_progress frm_progress = new frm_progress();
				Hide();
				frm_progress.ShowDialog();
				File.Delete("./update/update.ini");
				class48_1.method_2("Version", string_0, "Infor");
				MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.frmUpdateContent));
			panel4 = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lblCurrent = new Bunifu.Framework.UI.BunifuCustomLabel();
			lblNew = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			btnUpdateVersion = new Bunifu.Framework.UI.BunifuFlatButton();
			btnClose = new System.Windows.Forms.Button();
			panel4.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(label1);
			panel4.Controls.Add(btnClose);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(544, 46);
			panel4.TabIndex = 10;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(3, 6);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(285, 32);
			label1.TabIndex = 6;
			label1.Text = "Thông tin phiên bản mới";
			panel1.Controls.Add(btnUpdateVersion);
			panel1.Controls.Add(bunifuCustomLabel2);
			panel1.Controls.Add(lblCurrent);
			panel1.Controls.Add(lblNew);
			panel1.Controls.Add(bunifuCustomLabel1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(0, 46);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(544, 371);
			panel1.TabIndex = 11;
			bunifuCustomLabel2.AutoSize = true;
			bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel2.Location = new System.Drawing.Point(13, 51);
			bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			bunifuCustomLabel2.Size = new System.Drawing.Size(137, 20);
			bunifuCustomLabel2.TabIndex = 1;
			bunifuCustomLabel2.Text = "Phiên bản hiện tại:";
			lblCurrent.AutoSize = true;
			lblCurrent.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblCurrent.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblCurrent.Location = new System.Drawing.Point(166, 51);
			lblCurrent.Name = "lblCurrent";
			lblCurrent.Size = new System.Drawing.Size(44, 20);
			lblCurrent.TabIndex = 1;
			lblCurrent.Text = "1.0.0";
			lblNew.AutoSize = true;
			lblNew.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblNew.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblNew.Location = new System.Drawing.Point(166, 18);
			lblNew.Name = "lblNew";
			lblNew.Size = new System.Drawing.Size(44, 20);
			lblNew.TabIndex = 1;
			lblNew.Text = "1.0.1";
			bunifuCustomLabel1.AutoSize = true;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.Location = new System.Drawing.Point(13, 18);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(147, 20);
			bunifuCustomLabel1.TabIndex = 1;
			bunifuCustomLabel1.Text = "Phiên bản mới nhất:";
			btnUpdateVersion.Activecolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnUpdateVersion.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnUpdateVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			btnUpdateVersion.BorderRadius = 0;
			btnUpdateVersion.ButtonText = "Cập nhật";
			btnUpdateVersion.Cursor = System.Windows.Forms.Cursors.Hand;
			btnUpdateVersion.DisabledColor = System.Drawing.Color.Gray;
			btnUpdateVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnUpdateVersion.Iconcolor = System.Drawing.Color.Transparent;
			btnUpdateVersion.Iconimage = (System.Drawing.Image)resources.GetObject("btnUpdateVersion.Iconimage");
			btnUpdateVersion.Iconimage_right = null;
			btnUpdateVersion.Iconimage_right_Selected = null;
			btnUpdateVersion.Iconimage_Selected = null;
			btnUpdateVersion.IconMarginLeft = 130;
			btnUpdateVersion.IconMarginRight = 0;
			btnUpdateVersion.IconRightVisible = true;
			btnUpdateVersion.IconRightZoom = 0.0;
			btnUpdateVersion.IconVisible = true;
			btnUpdateVersion.IconZoom = 90.0;
			btnUpdateVersion.IsTab = false;
			btnUpdateVersion.Location = new System.Drawing.Point(0, 312);
			btnUpdateVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			btnUpdateVersion.Name = "btnUpdateVersion";
			btnUpdateVersion.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
			btnUpdateVersion.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
			btnUpdateVersion.OnHoverTextColor = System.Drawing.Color.White;
			btnUpdateVersion.selected = false;
			btnUpdateVersion.Size = new System.Drawing.Size(544, 59);
			btnUpdateVersion.TabIndex = 2;
			btnUpdateVersion.Text = "Cập nhật";
			btnUpdateVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			btnUpdateVersion.Textcolor = System.Drawing.Color.White;
			btnUpdateVersion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnUpdateVersion.Click += new System.EventHandler(btnUpdateVersion_Click);
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(497, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(544, 417);
			base.Controls.Add(panel1);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmUpdateContent";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmUpdateContent";
			base.Load += new System.EventHandler(frmUpdateContent_Load);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
