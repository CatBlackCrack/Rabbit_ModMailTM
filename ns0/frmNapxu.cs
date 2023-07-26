using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;

namespace ns0
{
	internal class frmNapxu : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Button btnClose;

		private PictureBox pictureBox1;

		private Panel panel2;

		private Panel panel3;

		private PictureBox pictureBox2;

		private Label label2;

		private Label label1;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label lblNoiDung;

		private Label label6;

		private BunifuDragControl bunifuDragControl_0;

		private Panel panel4;

		private PictureBox pictureBox3;

		private Label label8;

		private Label label9;

		private Label lblMomo;

		private Label label11;

		private Label label12;

		private Label label13;

		private Label label14;

		private Label label7;

		private Label label10;

		private Label label16;

		private Label label15;

		public frmNapxu(string string_0)
		{
			InitializeComponent();
			lblNoiDung.Text = "NAPXU " + string_0;
			lblMomo.Text = "NAPXU " + string_0;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.frmNapxu));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			btnClose = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			panel4 = new System.Windows.Forms.Panel();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			lblMomo = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			panel3 = new System.Windows.Forms.Panel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			lblNoiDung = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(btnClose);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(739, 44);
			panel1.TabIndex = 0;
			pictureBox1.Image = ns5.Class74.Bitmap_1;
			pictureBox1.Location = new System.Drawing.Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(44, 38);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(703, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(33, 31);
			btnClose.TabIndex = 0;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel3);
			panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			panel2.Location = new System.Drawing.Point(0, 44);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(739, 420);
			panel2.TabIndex = 1;
			panel4.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel4.Controls.Add(pictureBox3);
			panel4.Controls.Add(label8);
			panel4.Controls.Add(label9);
			panel4.Controls.Add(label16);
			panel4.Controls.Add(label10);
			panel4.Controls.Add(lblMomo);
			panel4.Controls.Add(label11);
			panel4.Controls.Add(label12);
			panel4.Controls.Add(label13);
			panel4.Controls.Add(label14);
			panel4.Location = new System.Drawing.Point(12, 222);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(715, 179);
			panel4.TabIndex = 4;
			pictureBox3.Image = ns5.Class74.MoMo_Logo;
			pictureBox3.Location = new System.Drawing.Point(5, 15);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(133, 113);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 1;
			pictureBox3.TabStop = false;
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label8.Location = new System.Drawing.Point(274, 50);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(98, 18);
			label8.TabIndex = 0;
			label8.Text = "0394027654";
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.White;
			label9.Location = new System.Drawing.Point(144, 50);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(112, 18);
			label9.TabIndex = 0;
			label9.Text = "Số điện thoại:";
			label16.AutoSize = true;
			label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label16.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label16.Location = new System.Drawing.Point(517, 140);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(156, 18);
			label16.TabIndex = 0;
			label16.Text = "(Nạp tối thiểu 200k)";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label10.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			label10.Location = new System.Drawing.Point(273, 140);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(204, 18);
			label10.TabIndex = 0;
			label10.Text = "Ví du: NAPXU phongrabbit";
			lblMomo.AutoSize = true;
			lblMomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblMomo.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblMomo.Location = new System.Drawing.Point(274, 110);
			lblMomo.Name = "lblMomo";
			lblMomo.Size = new System.Drawing.Size(96, 18);
			lblMomo.TabIndex = 0;
			lblMomo.Text = "NAPXU abc";
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label11.ForeColor = System.Drawing.Color.White;
			label11.Location = new System.Drawing.Point(144, 110);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(80, 18);
			label11.TabIndex = 0;
			label11.Text = "Nội dung:";
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label12.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label12.Location = new System.Drawing.Point(274, 79);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(125, 18);
			label12.TabIndex = 0;
			label12.Text = "Trần Đại Phong";
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label13.ForeColor = System.Drawing.Color.White;
			label13.Location = new System.Drawing.Point(144, 79);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(122, 18);
			label13.TabIndex = 0;
			label13.Text = "Chủ tài khoản: ";
			label14.AutoSize = true;
			label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label14.ForeColor = System.Drawing.Color.White;
			label14.Location = new System.Drawing.Point(142, 17);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(59, 20);
			label14.TabIndex = 0;
			label14.Text = "Momo";
			panel3.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
			panel3.Controls.Add(pictureBox2);
			panel3.Controls.Add(label4);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label15);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(lblNoiDung);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(label5);
			panel3.Location = new System.Drawing.Point(12, 9);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(715, 179);
			panel3.TabIndex = 4;
			pictureBox2.Image = ns5.Class74.logo_bidv1;
			pictureBox2.Location = new System.Drawing.Point(5, 15);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(133, 113);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label4.Location = new System.Drawing.Point(273, 50);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(134, 18);
			label4.TabIndex = 0;
			label4.Text = "31010001829809";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(144, 50);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(108, 18);
			label3.TabIndex = 0;
			label3.Text = "Số tài khoản:";
			label15.AutoSize = true;
			label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label15.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label15.Location = new System.Drawing.Point(517, 140);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(156, 18);
			label15.TabIndex = 0;
			label15.Text = "(Nạp tối thiểu 200k)";
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			label7.Location = new System.Drawing.Point(273, 140);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(204, 18);
			label7.TabIndex = 0;
			label7.Text = "Ví du: NAPXU phongrabbit";
			lblNoiDung.AutoSize = true;
			lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblNoiDung.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			lblNoiDung.Location = new System.Drawing.Point(273, 110);
			lblNoiDung.Name = "lblNoiDung";
			lblNoiDung.Size = new System.Drawing.Size(96, 18);
			lblNoiDung.TabIndex = 0;
			lblNoiDung.Text = "NAPXU abc";
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.White;
			label6.Location = new System.Drawing.Point(144, 110);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(80, 18);
			label6.TabIndex = 0;
			label6.Text = "Nội dung:";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.FromArgb(50, 226, 178);
			label2.Location = new System.Drawing.Point(273, 79);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(125, 18);
			label2.TabIndex = 0;
			label2.Text = "Trần Đại Phong";
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(144, 79);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(122, 18);
			label1.TabIndex = 0;
			label1.Text = "Chủ tài khoản: ";
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(142, 17);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(355, 20);
			label5.TabIndex = 0;
			label5.Text = "Ngân hàng Đầu tư và Phát triển Việt Nam";
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel1;
			bunifuDragControl_0.Vertical = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
			base.ClientSize = new System.Drawing.Size(739, 464);
			base.Controls.Add(panel2);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmNapxu";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Phương thức thanh toán";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}
	}
}
