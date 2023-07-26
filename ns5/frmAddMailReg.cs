using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ns5
{
	internal class frmAddMailReg : Form
	{
		private IContainer icontainer_0 = null;

		private Panel panel4;

		private Button btnClose;

		private Label label28;

		private PictureBox pictureBox1;

		private BunifuDragControl bunifuDragControl_0;

		private BunifuDragControl bunifuDragControl_1;

		public frmAddMailReg()
		{
			InitializeComponent();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns5.frmAddMailReg));
			panel4 = new System.Windows.Forms.Panel();
			label28 = new System.Windows.Forms.Label();
			btnClose = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			panel4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
			panel4.Controls.Add(btnClose);
			panel4.Controls.Add(label28);
			panel4.Controls.Add(pictureBox1);
			panel4.Dock = System.Windows.Forms.DockStyle.Top;
			panel4.Location = new System.Drawing.Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(594, 46);
			panel4.TabIndex = 10;
			label28.AutoSize = true;
			label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label28.ForeColor = System.Drawing.Color.White;
			label28.Location = new System.Drawing.Point(42, 8);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(330, 32);
			label28.TabIndex = 6;
			label28.Text = "Thêm email sau khi reg";
			btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnClose.Image = ns5.Class74.icons8_x_20;
			btnClose.Location = new System.Drawing.Point(547, 0);
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
			base.ClientSize = new System.Drawing.Size(594, 450);
			base.Controls.Add(panel4);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmAddMailReg";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Thêm Email";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}
	}
}
