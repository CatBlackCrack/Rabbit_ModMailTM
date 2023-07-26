using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns5
{
	internal class frmLoading : Form
	{
		public string string_0 = "";

		private IContainer icontainer_0 = null;

		public frmLoading(int int_0, int int_1, int int_2, int int_3)
		{
			InitializeComponent();
			base.Width = int_0;
			base.Height = int_1;
			base.Location = new Point(int_2, int_3);
		}

		private void frmLoading_Load(object sender, EventArgs e)
		{
		}

		public void method_0()
		{
			try
			{
				int num = 0;
				int num2 = base.Width / 2 - (base.Width + base.Height) / 10;
				num = base.Height / 2 - (base.Width + base.Height) / 10;
				PictureBox pictureBox = new PictureBox();
				pictureBox.Location = new Point(num2, num);
				pictureBox.Size = new Size(base.Width / 3, base.Height / 2);
				pictureBox.Image = Class74.Eclipse_1s_200px;
				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				base.Controls.Add(pictureBox);
				Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public void method_1()
		{
			try
			{
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns5.frmLoading));
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			base.ClientSize = new System.Drawing.Size(843, 503);
			Font = new System.Drawing.Font("Nirmala UI", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			ForeColor = System.Drawing.Color.White;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmLoading";
			base.Opacity = 0.8;
			base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "Loading Indicator";
			base.Load += new System.EventHandler(frmLoading_Load);
			ResumeLayout(false);
		}
	}
}
