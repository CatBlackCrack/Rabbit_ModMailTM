using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DeviceId;




namespace ToolRegFB
{
	public partial class CheckKey : Form
	{
		
		
		private string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + cmd;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}
		
		public CheckKey()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

        string text = Common.smethod_5(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber()
                .ToString()); // Md5 Encode

        private void button1_Click(object sender, EventArgs e)
		{

			string output = RunCMD("wmic diskdrive get serialNumber"); // check số serial ổ cứng
			using (StreamWriter HDD = new StreamWriter("HDD.txt", true))
			{
				HDD.WriteLine(output);
				HDD.Close();
			}
			string[] lines = File.ReadAllLines("HDD.txt");
			File.Delete("HDD.txt");
			string str = Regex.Replace(lines[2], @"\s", ""); // lấy serial đầu tiên

			string outputs = RunCMD("wmic bios get serialnumber"); // check số serial bios
			using (StreamWriter BIOS = new StreamWriter("bios.txt", true))
			{
				BIOS.WriteLine(outputs);
				BIOS.Close();
			}
			string[] liness = File.ReadAllLines("bios.txt");
			File.Delete("bios.txt");
			string strs = Regex.Replace(liness[2], @"\s", ""); // lấy serial đầu tiên
			
			string keys = string.Concat(strs, str);
			string text2 = text.Substring(0, 32) + "_Regfbv2";

			HttpClient httpClient = new HttpClient();
			
			string requestUri2 = "https://docs.google.com/spreadsheets/d/1DX5q1Cvb7H1RNhO6DSo7eA-DEutDzeaCrRciayiS1ko/edit?usp=sharing";
			string text3 = httpClient.GetAsync(requestUri2).Result.Content.ReadAsStringAsync().Result.ToString();
			Match match2 = Regex.Match(text3.ToString(), text2 + ".*?(?=ok)");
			bool flag2 = match2 != Match.Empty;
			if (flag2)
			{
				string[] array = match2.ToString().Split(new char[]
				{
							'|'
				});


				DateTime time = DateTime.Now;
				int dayn = time.Day;
				int monthn = time.Month;
				int yearn = time.Year;

				string[] arrays = array[1].ToString().Split(new char[]
			   {
							'/'
			   });

				int dayt = Int32.Parse(arrays[0]);
				int montht = Int32.Parse(arrays[1]);
				int yeart = Int32.Parse(arrays[2]);

				System.DateTime now = new System.DateTime(yearn, monthn, dayn);
				System.DateTime then = new System.DateTime(yeart, montht, dayt);
				System.TimeSpan diff1 = then.Subtract(now);


				int days = (int)Math.Ceiling(diff1.TotalDays);


				bool flag3 = days <= 0;
				bool flag4 = days > 1000;
				
				
				if (flag3)
				{

					MessageBox.Show("Vui lòng liên hệ admin để gia hạn !!", "Phần mềm hết hạn" + days + " ngày trước ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.textBox1.Text = text.Substring(0, 32) + "_Regfbv2";
					
					this.label3.Text = array[1].ToString();
					this.ngayconlai.Text = "Hết hạn" + days.ToString() + " ngày trước rồi !!";

					return;
				}
				else if (flag4)
				{
					MessageBox.Show("Đăng Nhập Thành Công !!", "Key bản quyền VĨNH VIỄN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.textBox1.Text = text.Substring(0, 32) + "_Regfbv2";
					
					this.label3.Text = array[1].ToString();
					this.ngayconlai.Text = days.ToString() + " ngày";
					this.Hide();
					new frmMain("12-12-2099").ShowDialog();
				}
				else
				{

					MessageBox.Show("Đăng Ký Dùng Thử Thành Công !!", "Còn lại: " + days + " ngày!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.textBox1.Text = text.Substring(0, 32) + "_Regfbv2";
					this.label3.Text = array[1].ToString();
					this.ngayconlai.Text = days.ToString() + " ngày";
					this.Hide();
					new frmMain("12-12-2099").ShowDialog();
					
				}
			}

			else
			{
				MessageBox.Show(string.Format("Bạn chưa mua bản quyền tool, vui lòng COPY và gửi mã " /* + text.Substring(0, 32) + "_Regfbv2" + */+ " qua Zalo 035.525.8611 để kích hoạt tool!", keys), "Thông báo active bản quyền!", MessageBoxButtons.OK);
				
				this.textBox1.Text = text.Substring(0, 32) + "_Regfbv2";

				//Environment.Exit(Environment.ExitCode);
			}
		}
		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox1.Text);
			MessageBox.Show("Copy thành công ! Vui lòng gửi mã qua Facebook hoặc Zalo để được kích hoạt", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
        private void CheckKey_Load(object sender, EventArgs e)
        {
			string output = RunCMD("wmic diskdrive get serialNumber"); // check số serial ổ cứng
			using (StreamWriter HDD = new StreamWriter("HDD.txt", true))
			{
				HDD.WriteLine(output);
				HDD.Close();
			}
			string[] lines = File.ReadAllLines("HDD.txt");
			File.Delete("HDD.txt");
			string str = Regex.Replace(lines[2], @"\s", ""); // lấy serial đầu tiên

			string outputs = RunCMD("wmic bios get serialnumber"); // check số serial bios
			using (StreamWriter BIOS = new StreamWriter("bios.txt", true))
			{
				BIOS.WriteLine(outputs);
				BIOS.Close();
			}
			string[] liness = File.ReadAllLines("bios.txt");
			File.Delete("bios.txt");
			string strs = Regex.Replace(liness[2], @"\s", ""); // lấy serial đầu tiên

			string keys = string.Concat(strs, str);
			string text2 = text.Substring(0, 32) + "_Regfbv2";

			HttpClient httpClient = new HttpClient();

			string requestUri2 = "https://docs.google.com/spreadsheets/d/1DX5q1Cvb7H1RNhO6DSo7eA-DEutDzeaCrRciayiS1ko/edit?usp=sharing";
			string text3 = httpClient.GetAsync(requestUri2).Result.Content.ReadAsStringAsync().Result.ToString();
			Match match2 = Regex.Match(text3.ToString(), text2 + ".*?(?=ok)");
			bool flag2 = match2 != Match.Empty;
			if (flag2)
			{
				string[] array = match2.ToString().Split(new char[]
				{
							'|'
				});


				DateTime time = DateTime.Now;
				int dayn = time.Day;
				int monthn = time.Month;
				int yearn = time.Year;

				string[] arrays = array[1].ToString().Split(new char[]
			   {
							'/'
			   });

				int dayt = Int32.Parse(arrays[0]);
				int montht = Int32.Parse(arrays[1]);
				int yeart = Int32.Parse(arrays[2]);

				System.DateTime now = new System.DateTime(yearn, monthn, dayn);
				System.DateTime then = new System.DateTime(yeart, montht, dayt);
				System.TimeSpan diff1 = then.Subtract(now);


				int days = (int)Math.Ceiling(diff1.TotalDays);


				bool flag3 = days <= 0;
				bool flag4 = days > 1000;


				if (flag3)
				{
					label4.Text = text.Substring(0, 32) + "_Regfbv2";
					Clipboard.SetText(label4.Text);
					MessageBox.Show("Hết Hạn ! Tự động Copy Mã Máy thành công ! Vui lòng gửi mã qua Facebook hoặc Zalo để được gia hạn ngày dùng !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (flag4)
				{
					
				}
				else
				{ 

				}
			}

			else
			{
				label4.Text = text.Substring(0, 32) + "_Regfbv2";
				Clipboard.SetText(label4.Text);
				MessageBox.Show("Tự động Copy Mã Máy thành công ! Vui lòng gửi mã qua Facebook hoặc Zalo để được kích hoạt", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}

			
        }
        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckKey));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngayconlai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.faceBook = new System.Windows.Forms.LinkLabel();
            this.Zalo = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisence Key:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nếu chưa đăng kí. Hãy click button LOGIN để hiển thị Mã Máy Đăng Nhập";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày còn lại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "...";
            // 
            // ngayconlai
            // 
            this.ngayconlai.AutoSize = true;
            this.ngayconlai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayconlai.Location = new System.Drawing.Point(238, 236);
            this.ngayconlai.Name = "ngayconlai";
            this.ngayconlai.Size = new System.Drawing.Size(22, 23);
            this.ngayconlai.TabIndex = 0;
            this.ngayconlai.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(415, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.Location = new System.Drawing.Point(278, 88);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(116, 33);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy Key";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "FaceBook: Hoàng Hải Long";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Zalo: 035.525.8611";
            // 
            // faceBook
            // 
            this.faceBook.AutoSize = true;
            this.faceBook.Location = new System.Drawing.Point(299, 143);
            this.faceBook.Name = "faceBook";
            this.faceBook.Size = new System.Drawing.Size(37, 17);
            this.faceBook.TabIndex = 4;
            this.faceBook.TabStop = true;
            this.faceBook.Text = "Click";
            this.faceBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.faceBook_LinkClicked);
            // 
            // Zalo
            // 
            this.Zalo.AutoSize = true;
            this.Zalo.Location = new System.Drawing.Point(299, 174);
            this.Zalo.Name = "Zalo";
            this.Zalo.Size = new System.Drawing.Size(37, 17);
            this.Zalo.TabIndex = 4;
            this.Zalo.TabStop = true;
            this.Zalo.Text = "Click";
            this.Zalo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Zalo_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Website: Selltoolmmo.site";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(694, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webSite_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Youtube: Chia sẻ - Hỗ Trợ MXH";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(694, 172);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 17);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Click";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youTube_LinkClicked);
            // 
            // bk
            // 
            this.bk.ActiveLinkColor = System.Drawing.Color.Red;
            this.bk.AutoSize = true;
            this.bk.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk.LinkColor = System.Drawing.Color.RoyalBlue;
            this.bk.Location = new System.Drawing.Point(143, 207);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(494, 23);
            this.bk.TabIndex = 6;
            this.bk.TabStop = true;
            this.bk.Text = "==>>Hướng dẫn kích hoạt hoặc gia hạn tự động Tool <<==";
            this.bk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.banking_LinkClicked);
            // 
            // CheckKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(786, 270);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Zalo);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.faceBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngayconlai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Key Bản Quyền Zalo 035.525.8611";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckKey_FormClosed);
            this.Load += new System.EventHandler(this.CheckKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        private void faceBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/longk.hoanghai");
        }

        private void Zalo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://zalo.me/0355258611");
        }

        private void webSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://selltoolmmo.site/");
        }

        private void youTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC3_9K7xgvgQQS5svn0EXgsg");
        }

        private void banking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            banking bk = new banking();
            bk.Show();
        }

        private void CheckKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
