using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns0;
using ns5;
using ns7;
using ns8;

namespace ns4
{
	internal class frmUpdate : Form
	{
		public static string string_0 = "ToolRegFB";

		public static string string_1 = "https://rabbitsocialtools.com/public/update/" + string_0 + "/";

		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuCustomLabel bunifuCustomLabel1;

		private BunifuCustomLabel lblLoading;

		private Timer timer_0;

		private Label label1;

		public frmUpdate()
		{
			InitializeComponent();
			lblLoading.Text = "<<<   <<<   <<<   <<<   <<<   ";
			method_1();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			lblLoading.Text = lblLoading.Text.Substring(1) + lblLoading.Text.Substring(0, 1);
		}

		private void method_0(object sender, EventArgs e)
		{
		}

		private void method_1()
		{
			if (Class49.smethod_0())
			{
				WebClient webClient = new WebClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				webClient.DownloadFileCompleted += method_2;
				Uri address = new Uri(string_1 + "update.ini");
				webClient.DownloadFileAsync(address, "./update/update.ini");
			}
			else
			{
				MessageBox.Show("No internet connect.Please check your network!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void method_2(object sender, AsyncCompletedEventArgs e)
		{
			try
			{
				Class48 @class = new Class48("./update/update.ini");
				string text = @class.method_1("Version", "Infor");
				double num = Convert.ToDouble(text.Replace(".", "").Insert(1, "."));
				Class48 class2 = new Class48("update.ini");
				string text2 = class2.method_1("Version", "Infor");
				double num2 = Convert.ToDouble(text2.Replace(".", "").Insert(1, "."));
				if (num > num2)
				{
					frmUpdateContent frmUpdateContent = new frmUpdateContent();
					Hide();
					frmUpdateContent.Show();
				}
				else
				{
					MessageBox.Show("Bạn đang được sử dụng phiên bản mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
				}
			}
			catch
			{
				MessageBox.Show("Lô\u0303i update!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
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
			panel4 = new System.Windows.Forms.Panel();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lblLoading = new Bunifu.Framework.UI.BunifuCustomLabel();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			label1 = new System.Windows.Forms.Label();
			btnClose = new System.Windows.Forms.Button();
			panel4.SuspendLayout();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(label1);
			panel4.Controls.Add(btnClose);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(542, 46);
			panel4.TabIndex = 9;
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel4;
			bunifuDragControl_0.Vertical = true;
			bunifuCustomLabel1.AutoSize = true;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.Location = new System.Drawing.Point(138, 64);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(254, 28);
			bunifuCustomLabel1.TabIndex = 10;
			bunifuCustomLabel1.Text = "Đang kiểm tra phiên bản...";
			bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			lblLoading.AutoSize = true;
			lblLoading.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLoading.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLoading.Location = new System.Drawing.Point(117, 103);
			lblLoading.Name = "lblLoading";
			lblLoading.Size = new System.Drawing.Size(201, 28);
			lblLoading.TabIndex = 11;
			lblLoading.Text = "bunifuCustomLabel2";
			timer_0.Enabled = true;
			timer_0.Interval = 200;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(3, 7);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(164, 32);
			label1.TabIndex = 6;
			label1.Text = "Cập nhật tool";
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(495, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(542, 159);
			base.Controls.Add(lblLoading);
			base.Controls.Add(bunifuCustomLabel1);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmUpdate";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmUpdate";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
