using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns6;

namespace ns4
{
	internal class frmProductOptions : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Label label1;

		private Button btnClose;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		private Panel panel1;

		private BunifuCustomLabel bunifuCustomLabel9;

		private BunifuCustomLabel bunifuCustomLabel6;

		private BunifuCustomLabel bunifuCustomLabel10;

		private BunifuCustomLabel bunifuCustomLabel4;

		public BunifuCustomLabel lbl12thang;

		public BunifuCustomLabel lbl6thang;

		public BunifuCustomLabel lbl1ngay;

		public BunifuCustomLabel lbl1thang;

		private BunifuCustomLabel bunifuCustomLabel7;

		public BunifuCheckbox chk12thang;

		private BunifuCustomLabel bunifuCustomLabel3;

		public BunifuCheckbox chk6thang;

		private BunifuCustomLabel bunifuCustomLabel5;

		public BunifuCheckbox chk1ngay;

		private BunifuCustomLabel bunifuCustomLabel2;

		public BunifuCheckbox chk1thang;

		private BunifuCustomLabel bunifuCustomLabel1;

		public Button btnRegProduct;

		public BunifuCustomLabel bunifuCustomLabel8;

		public frmProductOptions(Class81 class81_0, bool bool_0)
		{
			InitializeComponent();
			double num = (double)class81_0.listProc[1].tongxu * 0.9;
			double num2 = (double)class81_0.listProc[2].tongxu * 0.7;
			lbl1thang.Text = class81_0.listProc[0].tongxu.ToString();
			lbl6thang.Text = num.ToString();
			lbl12thang.Text = num2.ToString();
			lbl1ngay.Text = class81_0.listProc[3].tongxu.ToString();
			chk6thang.Checked = (chk12thang.Checked = (chk1ngay.Checked = !chk1thang.Checked));
			chk1ngay.Enabled = bool_0;
			btnRegProduct.DialogResult = DialogResult.OK;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			btnRegProduct.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void chk1thang_OnChange(object sender, EventArgs e)
		{
			BunifuCheckbox bunifuCheckbox = chk1ngay;
			BunifuCheckbox bunifuCheckbox2 = chk6thang;
			bool flag2 = (chk12thang.Checked = !chk1thang.Checked);
			bool @checked = (bunifuCheckbox2.Checked = flag2);
			bunifuCheckbox.Checked = @checked;
		}

		private void chk6thang_OnChange(object sender, EventArgs e)
		{
			BunifuCheckbox bunifuCheckbox = chk1ngay;
			BunifuCheckbox bunifuCheckbox2 = chk1thang;
			bool flag2 = (chk12thang.Checked = !chk6thang.Checked);
			bool @checked = (bunifuCheckbox2.Checked = flag2);
			bunifuCheckbox.Checked = @checked;
		}

		private void chk12thang_OnChange(object sender, EventArgs e)
		{
			BunifuCheckbox bunifuCheckbox = chk1ngay;
			BunifuCheckbox bunifuCheckbox2 = chk1thang;
			bool flag2 = (chk6thang.Checked = !chk12thang.Checked);
			bool @checked = (bunifuCheckbox2.Checked = flag2);
			bunifuCheckbox.Checked = @checked;
		}

		private void method_0(object sender, EventArgs e)
		{
		}

		private void method_1(object sender, EventArgs e)
		{
		}

		private void method_2(object sender, EventArgs e)
		{
		}

		private void chk1ngay_OnChange(object sender, EventArgs e)
		{
			BunifuCheckbox bunifuCheckbox = chk1thang;
			BunifuCheckbox bunifuCheckbox2 = chk6thang;
			bool flag2 = (chk12thang.Checked = !chk1ngay.Checked);
			bool @checked = (bunifuCheckbox2.Checked = flag2);
			bunifuCheckbox.Checked = @checked;
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
			label1 = new System.Windows.Forms.Label();
			btnClose = new System.Windows.Forms.Button();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			panel1 = new System.Windows.Forms.Panel();
			btnRegProduct = new System.Windows.Forms.Button();
			bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lbl12thang = new Bunifu.Framework.UI.BunifuCustomLabel();
			lbl6thang = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lbl1ngay = new Bunifu.Framework.UI.BunifuCustomLabel();
			lbl1thang = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
			chk12thang = new Bunifu.Framework.UI.BunifuCheckbox();
			bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			chk6thang = new Bunifu.Framework.UI.BunifuCheckbox();
			bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			chk1ngay = new Bunifu.Framework.UI.BunifuCheckbox();
			bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			chk1thang = new Bunifu.Framework.UI.BunifuCheckbox();
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			panel4.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(label1);
			panel4.Controls.Add(btnClose);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(614, 46);
			panel4.TabIndex = 8;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(4, 6);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(202, 32);
			label1.TabIndex = 19;
			label1.Text = "Các gói thuê tool";
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(567, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(44, 39);
			btnClose.TabIndex = 5;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += new System.EventHandler(btnClose_Click);
			bunifuDragControl_0.Fixed = true;
			bunifuDragControl_0.Horizontal = true;
			bunifuDragControl_0.TargetControl = panel4;
			bunifuDragControl_0.Vertical = true;
			bunifuDragControl_1.Fixed = true;
			bunifuDragControl_1.Horizontal = true;
			bunifuDragControl_1.TargetControl = null;
			bunifuDragControl_1.Vertical = true;
			panel1.Controls.Add(btnRegProduct);
			panel1.Controls.Add(bunifuCustomLabel9);
			panel1.Controls.Add(bunifuCustomLabel6);
			panel1.Controls.Add(bunifuCustomLabel10);
			panel1.Controls.Add(bunifuCustomLabel4);
			panel1.Controls.Add(lbl12thang);
			panel1.Controls.Add(lbl6thang);
			panel1.Controls.Add(bunifuCustomLabel8);
			panel1.Controls.Add(lbl1ngay);
			panel1.Controls.Add(lbl1thang);
			panel1.Controls.Add(bunifuCustomLabel7);
			panel1.Controls.Add(chk12thang);
			panel1.Controls.Add(bunifuCustomLabel3);
			panel1.Controls.Add(chk6thang);
			panel1.Controls.Add(bunifuCustomLabel5);
			panel1.Controls.Add(chk1ngay);
			panel1.Controls.Add(bunifuCustomLabel2);
			panel1.Controls.Add(chk1thang);
			panel1.Controls.Add(bunifuCustomLabel1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(0, 46);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(614, 265);
			panel1.TabIndex = 9;
			btnRegProduct.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			btnRegProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
			btnRegProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
			btnRegProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRegProduct.Font = new System.Drawing.Font("Segoe UI", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnRegProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
			btnRegProduct.Location = new System.Drawing.Point(0, 218);
			btnRegProduct.Name = "btnRegProduct";
			btnRegProduct.Size = new System.Drawing.Size(614, 47);
			btnRegProduct.TabIndex = 37;
			btnRegProduct.Text = "Đăng ký";
			btnRegProduct.UseVisualStyleBackColor = false;
			bunifuCustomLabel9.AutoSize = true;
			bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel9.Location = new System.Drawing.Point(207, 164);
			bunifuCustomLabel9.Name = "bunifuCustomLabel9";
			bunifuCustomLabel9.Size = new System.Drawing.Size(107, 20);
			bunifuCustomLabel9.TabIndex = 36;
			bunifuCustomLabel9.Text = "xu (giảm 30%)";
			bunifuCustomLabel6.AutoSize = true;
			bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel6.Location = new System.Drawing.Point(207, 129);
			bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			bunifuCustomLabel6.Size = new System.Drawing.Size(105, 20);
			bunifuCustomLabel6.TabIndex = 34;
			bunifuCustomLabel6.Text = "xu (giảm 10%)";
			bunifuCustomLabel10.AutoSize = true;
			bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel10.Location = new System.Drawing.Point(199, 58);
			bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			bunifuCustomLabel10.Size = new System.Drawing.Size(26, 20);
			bunifuCustomLabel10.TabIndex = 33;
			bunifuCustomLabel10.Text = "xu";
			bunifuCustomLabel4.AutoSize = true;
			bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel4.Location = new System.Drawing.Point(198, 94);
			bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			bunifuCustomLabel4.Size = new System.Drawing.Size(26, 20);
			bunifuCustomLabel4.TabIndex = 32;
			bunifuCustomLabel4.Text = "xu";
			lbl12thang.AutoSize = true;
			lbl12thang.BackColor = System.Drawing.Color.Transparent;
			lbl12thang.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lbl12thang.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lbl12thang.Location = new System.Drawing.Point(165, 164);
			lbl12thang.Name = "lbl12thang";
			lbl12thang.Size = new System.Drawing.Size(41, 20);
			lbl12thang.TabIndex = 31;
			lbl12thang.Text = "9600";
			lbl6thang.AutoSize = true;
			lbl6thang.BackColor = System.Drawing.Color.Transparent;
			lbl6thang.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lbl6thang.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lbl6thang.Location = new System.Drawing.Point(165, 129);
			lbl6thang.Name = "lbl6thang";
			lbl6thang.Size = new System.Drawing.Size(42, 20);
			lbl6thang.TabIndex = 30;
			lbl6thang.Text = "4800";
			bunifuCustomLabel8.AutoSize = true;
			bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			bunifuCustomLabel8.Location = new System.Drawing.Point(236, 58);
			bunifuCustomLabel8.Name = "bunifuCustomLabel8";
			bunifuCustomLabel8.Size = new System.Drawing.Size(342, 20);
			bunifuCustomLabel8.TabIndex = 29;
			bunifuCustomLabel8.Text = "(Nếu bạn đã mua gói tháng, có thể mua gói này)";
			lbl1ngay.AutoSize = true;
			lbl1ngay.BackColor = System.Drawing.Color.Transparent;
			lbl1ngay.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lbl1ngay.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lbl1ngay.Location = new System.Drawing.Point(165, 58);
			lbl1ngay.Name = "lbl1ngay";
			lbl1ngay.Size = new System.Drawing.Size(33, 20);
			lbl1ngay.TabIndex = 29;
			lbl1ngay.Text = "200";
			lbl1thang.AutoSize = true;
			lbl1thang.BackColor = System.Drawing.Color.Transparent;
			lbl1thang.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lbl1thang.ForeColor = System.Drawing.Color.FromArgb(245, 66, 66);
			lbl1thang.Location = new System.Drawing.Point(165, 94);
			lbl1thang.Name = "lbl1thang";
			lbl1thang.Size = new System.Drawing.Size(33, 20);
			lbl1thang.TabIndex = 35;
			lbl1thang.Text = "800";
			bunifuCustomLabel7.AutoSize = true;
			bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel7.Location = new System.Drawing.Point(93, 164);
			bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			bunifuCustomLabel7.Size = new System.Drawing.Size(71, 20);
			bunifuCustomLabel7.TabIndex = 28;
			bunifuCustomLabel7.Text = "12 tháng:";
			chk12thang.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk12thang.ChechedOffColor = System.Drawing.Color.FromArgb(132, 135, 140);
			chk12thang.Checked = true;
			chk12thang.CheckedOnColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk12thang.ForeColor = System.Drawing.Color.White;
			chk12thang.Location = new System.Drawing.Point(66, 163);
			chk12thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			chk12thang.Name = "chk12thang";
			chk12thang.Size = new System.Drawing.Size(20, 20);
			chk12thang.TabIndex = 24;
			chk12thang.OnChange += new System.EventHandler(chk12thang_OnChange);
			bunifuCustomLabel3.AutoSize = true;
			bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel3.Location = new System.Drawing.Point(93, 129);
			bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			bunifuCustomLabel3.Size = new System.Drawing.Size(65, 20);
			bunifuCustomLabel3.TabIndex = 27;
			bunifuCustomLabel3.Text = "6 tháng:";
			chk6thang.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk6thang.ChechedOffColor = System.Drawing.Color.FromArgb(132, 135, 140);
			chk6thang.Checked = true;
			chk6thang.CheckedOnColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk6thang.ForeColor = System.Drawing.Color.White;
			chk6thang.Location = new System.Drawing.Point(66, 128);
			chk6thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			chk6thang.Name = "chk6thang";
			chk6thang.Size = new System.Drawing.Size(20, 20);
			chk6thang.TabIndex = 23;
			chk6thang.OnChange += new System.EventHandler(chk6thang_OnChange);
			bunifuCustomLabel5.AutoSize = true;
			bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel5.Location = new System.Drawing.Point(93, 58);
			bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			bunifuCustomLabel5.Size = new System.Drawing.Size(54, 20);
			bunifuCustomLabel5.TabIndex = 26;
			bunifuCustomLabel5.Text = "1 tuần:";
			chk1ngay.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk1ngay.ChechedOffColor = System.Drawing.Color.FromArgb(132, 135, 140);
			chk1ngay.Checked = true;
			chk1ngay.CheckedOnColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk1ngay.ForeColor = System.Drawing.Color.White;
			chk1ngay.Location = new System.Drawing.Point(66, 57);
			chk1ngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			chk1ngay.Name = "chk1ngay";
			chk1ngay.Size = new System.Drawing.Size(20, 20);
			chk1ngay.TabIndex = 22;
			chk1ngay.OnChange += new System.EventHandler(chk1ngay_OnChange);
			bunifuCustomLabel2.AutoSize = true;
			bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel2.Location = new System.Drawing.Point(93, 94);
			bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			bunifuCustomLabel2.Size = new System.Drawing.Size(63, 20);
			bunifuCustomLabel2.TabIndex = 25;
			bunifuCustomLabel2.Text = "1 tháng:";
			chk1thang.BackColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk1thang.ChechedOffColor = System.Drawing.Color.FromArgb(132, 135, 140);
			chk1thang.Checked = true;
			chk1thang.CheckedOnColor = System.Drawing.Color.FromArgb(51, 205, 117);
			chk1thang.ForeColor = System.Drawing.Color.White;
			chk1thang.Location = new System.Drawing.Point(66, 93);
			chk1thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			chk1thang.Name = "chk1thang";
			chk1thang.Size = new System.Drawing.Size(20, 20);
			chk1thang.TabIndex = 21;
			chk1thang.OnChange += new System.EventHandler(chk1thang_OnChange);
			bunifuCustomLabel1.AutoSize = true;
			bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(245, 81, 66);
			bunifuCustomLabel1.Location = new System.Drawing.Point(37, 10);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(498, 28);
			bunifuCustomLabel1.TabIndex = 19;
			bunifuCustomLabel1.Text = "Bạn có thể lựa chọn gói theo tháng để tiết kiệm nhé!";
			bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(614, 311);
			base.Controls.Add(panel1);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmProductOptions";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Danh sách gói mua";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
