using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns4;
using ns8;

namespace ns7
{
	internal class frm_progress : Form
	{
		private IContainer icontainer_0 = null;

		private BunifuCustomLabel bunifuCustomLabel1;

		private BunifuCustomLabel lblLoading;

		private Timer timer_0;

		public frm_progress()
		{
			InitializeComponent();
			lblLoading.Text = "<<<   <<<   <<<   <<<   <<<   ";
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			lblLoading.Text = lblLoading.Text.Substring(1) + lblLoading.Text.Substring(0, 1);
		}

		private void frm_progress_Load(object sender, EventArgs e)
		{
			try
			{
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string string_ = frmUpdate.string_1;
				if (Class49.smethod_0())
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFileCompleted += method_2;
					Uri address = new Uri(string_ + frmUpdate.string_0 + ".zip");
					webClient.DownloadFileAsync(address, "./update/" + frmUpdate.string_0 + ".zip");
				}
				else
				{
					MessageBox.Show("No internet connect.Please check your network!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Application.Exit();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
		}

		public void method_0(string string_0, string string_1)
		{
			DirectoryInfo directoryInfo_ = new DirectoryInfo(string_0);
			DirectoryInfo directoryInfo_2 = new DirectoryInfo(string_1);
			method_1(directoryInfo_, directoryInfo_2);
		}

		public void method_1(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
		{
			Directory.CreateDirectory(directoryInfo_1.FullName);
			int num = 1;
			FileInfo[] files = directoryInfo_0.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				Application.DoEvents();
				fileInfo.CopyTo(Path.Combine(directoryInfo_1.FullName, fileInfo.Name), overwrite: true);
				num++;
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo in directories)
			{
				DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
				method_1(directoryInfo, directoryInfo_2);
			}
		}

		private void method_2(object sender, AsyncCompletedEventArgs e)
		{
			try
			{
				if (Directory.Exists("./update/" + frmUpdate.string_0))
				{
					Directory.Delete("./update/" + frmUpdate.string_0, recursive: true);
				}
				ZipFile.ExtractToDirectory("./update/" + frmUpdate.string_0 + ".zip", "./update/");
				try
				{
					string string_ = "./update/" + frmUpdate.string_0 + "/";
					string startupPath = Application.StartupPath;
					method_0(string_, startupPath);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Update fail:" + ex.Message);
					return;
				}
				if (File.Exists("./update/" + frmUpdate.string_0 + ".zip"))
				{
					File.Delete("./update/" + frmUpdate.string_0 + ".zip");
				}
				if (Directory.Exists("./update/" + frmUpdate.string_0))
				{
					Directory.Delete("./update/" + frmUpdate.string_0, recursive: true);
				}
				timer_0.Stop();
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Close();
			}
			finally
			{
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
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lblLoading = new Bunifu.Framework.UI.BunifuCustomLabel();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			SuspendLayout();
			bunifuCustomLabel1.AutoSize = true;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.Location = new System.Drawing.Point(106, 26);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(242, 28);
			bunifuCustomLabel1.TabIndex = 11;
			bunifuCustomLabel1.Text = "Đang tải phiên bản mới...";
			bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			lblLoading.AutoSize = true;
			lblLoading.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblLoading.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lblLoading.Location = new System.Drawing.Point(85, 62);
			lblLoading.Name = "lblLoading";
			lblLoading.Size = new System.Drawing.Size(201, 28);
			lblLoading.TabIndex = 12;
			lblLoading.Text = "bunifuCustomLabel2";
			timer_0.Enabled = true;
			timer_0.Interval = 200;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(469, 137);
			base.Controls.Add(lblLoading);
			base.Controls.Add(bunifuCustomLabel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frm_progress";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frm_progress";
			base.Load += new System.EventHandler(frm_progress_Load);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
