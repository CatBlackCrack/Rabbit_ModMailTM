using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns5;
using ns6;
using ns7;

namespace ToolRegFB
{
	public class frmViewLD : Form
	{
		[CompilerGenerated]
		private sealed class Class40
		{
			public Panel panel_0;

			public frmViewLD frmViewLD_0;

			internal void method_0()
			{
				frmViewLD_0.panelListDevice.Controls.Add(panel_0);
			}
		}

		[CompilerGenerated]
		private sealed class Class41
		{
			public frmViewLD frmViewLD_0;

			public int int_0;

			internal void method_0()
			{
				frmViewLD_0.panelListDevice.Controls["dv" + int_0].Controls[3].Visible = false;
				frmViewLD_0.panelListDevice.Controls["dv" + int_0].Controls[4].Visible = false;
			}
		}

		[CompilerGenerated]
		private sealed class Class42
		{
			public frmViewLD frmViewLD_0;

			public int int_0;

			public string string_0;

			internal void method_0()
			{
				frmViewLD_0.panelListDevice.Controls["dv" + int_0].Controls[2].Text = string_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class43
		{
			public frmViewLD frmViewLD_0;

			public int int_0;

			public string string_0;

			internal void method_0()
			{
				frmViewLD_0.panelListDevice.Controls["dv" + int_0].Controls[1].Text = "> " + string_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class44
		{
			public int int_0;

			public IntPtr intptr_0;

			public frmViewLD frmViewLD_0;

			internal bool method_0(Control control_0)
			{
				return control_0.Tag.Equals(int_0);
			}
		}

		[CompilerGenerated]
		private sealed class Class45
		{
			public Control control_0;

			public Class44 class44_0;

			internal void method_0()
			{
				Class72.SetParent(class44_0.intptr_0, control_0.Handle);
				Class72.MoveWindow(class44_0.intptr_0, class44_0.frmViewLD_0.int_0[2], class44_0.frmViewLD_0.int_0[3], class44_0.frmViewLD_0.int_0[4], class44_0.frmViewLD_0.int_0[5], bool_0: true);
			}
		}

		[CompilerGenerated]
		private sealed class Class46
		{
			public Control control_0;

			public int int_0;

			public string string_0;

			public int int_1;

			internal void method_0()
			{
				control_0.Name = "dv" + int_0;
				control_0.Tag = int_0;
				if (int_0 == -1)
				{
					control_0.Controls[0].Text = "LDPlayer-None";
				}
				else
				{
					control_0.Controls[0].Text = string_0;
				}
				if (int_1 > 0)
				{
					Control control = control_0.Controls[0];
					control.Text = control.Text + ": Ta\u0300i khoa\u0309n " + int_1;
				}
				control_0.Controls[0].Name = int_0.ToString();
				control_0.Controls[1].Name = int_0.ToString();
				control_0.Controls[2].Name = int_0.ToString();
				control_0.Controls[3].Name = int_0.ToString();
			}
		}

		public bool bool_0 = false;

		private object object_0 = new object();

		public int[] int_0 = new int[6] { 240, 360, -1, -36, 240, 395 };

		public static frmViewLD frmViewLD_0;

		private IContainer icontainer_0 = null;

		private FlowLayoutPanel panelListDevice;

		private Panel panel1;

		private BunifuDragControl bunifuDragControl_0;

		private Button btnClose;

		private Button btnMinimize;

		private Button btnMaximum;

		private PictureBox pictureBox1;

		private Label label1;
        private IContainer components;
        private ToolTip toolTip_0;

		public frmViewLD()
		{
			InitializeComponent();
			frmViewLD_0 = this;
		}

		public void method_0(int int_1)
		{
			try
			{
				if (!bool_0)
				{
					int_1 = -1;
				}
				Panel panel_0 = new Panel();
				panel_0.Name = "dv" + int_1;
				panel_0.Tag = int_1;
				panel_0.Size = new Size(int_0[0], int_0[1] + 60);
				panel_0.BackColor = Color.White;
				panel_0.BorderStyle = BorderStyle.FixedSingle;
				string text = ((int_1 != -1) ? ("LDPlayer-" + int_1) : "LDPlayer-None");
				Label label = new Label
				{
					Text = text,
					Location = new Point(0, int_0[1]),
					Size = new Size(int_0[0] - 55, 20),
					BackColor = Color.White,
					BorderStyle = BorderStyle.None,
					ForeColor = Color.Black,
					Name = (int_1.ToString() ?? ""),
					AutoSize = false
				};
				panel_0.Controls.Add(label);
				label.DoubleClick += method_6;
				Label value = new Label
				{
					Text = ">",
					Location = new Point(0, int_0[1] + 20),
					Size = new Size(int_0[0], 20),
					BackColor = Color.White,
					BorderStyle = BorderStyle.None,
					ForeColor = Color.Black,
					Name = (int_1.ToString() ?? ""),
					AutoSize = false
				};
				panel_0.Controls.Add(value);
				Label value2 = new Label
				{
					Text = "",
					Location = new Point(0, int_0[1] + 40),
					Size = new Size(int_0[0], 20),
					BackColor = Color.White,
					BorderStyle = BorderStyle.None,
					ForeColor = Color.Black,
					Name = (int_1.ToString() ?? ""),
					AutoSize = false
				};
				panel_0.Controls.Add(value2);
				PictureBox pictureBox = new PictureBox
				{
					Image = ns5.Class74.icons8_multiply_20,
					Location = new Point(int_0[0] - 25, int_0[1]),
					Name = (int_1.ToString() ?? ""),
					Size = new Size(20, 20),
					Cursor = Cursors.Hand,
					Visible = true
				};
				pictureBox.Click += method_2;
				panel_0.Controls.Add(pictureBox);
				toolTip_0.SetToolTip(pictureBox, "Close");
				PictureBox pictureBox2 = new PictureBox
				{
					Image = ns5.Class74.icons8_undo_20,
					Location = new Point(int_0[0] - 50, int_0[1]),
					Name = (int_1.ToString() ?? ""),
					Size = new Size(20, 20),
					Cursor = Cursors.Hand,
					Visible = true
				};
				pictureBox2.Click += method_1;
				panel_0.Controls.Add(pictureBox2);
				toolTip_0.SetToolTip(pictureBox2, "Back");
				PictureBox pictureBox3 = new PictureBox
				{
					Image = ns5.Class74.LogoCustom,
					SizeMode = PictureBoxSizeMode.Zoom,
					Location = new Point(0, -30),
					Name = "pictureBoxLogo",

					Size = new Size(int_0[0], int_0[1] + 60),
					TabIndex = 0,
					TabStop = false
				};
				pictureBox3.BringToFront();
				panel_0.Controls.Add(pictureBox3);
				object obj = object_0;
				lock (obj)
				{
					panelListDevice.Invoke((MethodInvoker)delegate
					{
						panelListDevice.Controls.Add(panel_0);
					});
				}
				for (int i = 0; i < 5; i++)
				{
					if (panelListDevice.Controls["dv" + int_1] != null)
					{
						break;
					}
					Thread.Sleep(1000);
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "AddPanelDevice");
			}
		}

		private void method_1(object sender, EventArgs e)
		{
			try
			{
				string name = (sender as PictureBox).Name;
				Class2.smethod_23(name, "shell input keyevent 4");
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "Back");
			}
		}

		private void method_2(object sender, EventArgs e)
		{
			try
			{
				int int_ = Convert.ToInt32((sender as PictureBox).Name);
				method_4(int_);
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "TurnOffDevice");
			}
		}

		public void method_3(int int_1)
		{
			try
			{
				if (panelListDevice != null)
				{
					Invoke((MethodInvoker)delegate
					{
						panelListDevice.Controls["dv" + int_1].Controls[3].Visible = false;
						panelListDevice.Controls["dv" + int_1].Controls[4].Visible = false;
					});
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "HidePicTurnOffDevice");
			}
		}

		public void method_4(int int_1)
		{
			try
			{
				Class48 @class = new Class48("setting.ini");
				string string_ = @class.method_1("linkLD").ToString();
				Class2.smethod_21(string_, int_1);
				method_7(int_1, "");
				method_8(int_1, "");
				method_3(int_1);
				if (!bool_0)
				{
					Control control_ = panelListDevice.Controls["dv" + int_1];
					method_10(control_, -1, 0, string.Empty);
				}
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "RemovePanelDevice");
			}
		}

		public void method_5(int int_1, string string_0 = "", string string_1 = "", string string_2 = "")
		{
			try
			{
				string text = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
				string text2 = int_1 + "_" + text;
				if (string_2 == "")
				{
					string_2 = "CheckDevice";
				}
				Common.smethod_4(string_2);
				Common.smethod_4(string_2 + "\\" + int_1);
				string text3 = Class2.smethod_36(int_1);
				if (text3 != "")
				{
					Class2.smethod_3(text3, string_2 + "\\" + int_1 + "\\" + text2 + ".png");
					File.AppendAllText(string_2 + "\\" + int_1 + "\\" + text2 + ".txt", panelListDevice.Controls["dv" + int_1].Controls[1].Text + "\r\n");
					if (string_0 == "")
					{
						string_0 = Class2.smethod_19(text3).Split('{', '}')[1].Split(' ')[2];
					}
					File.AppendAllText(string_2 + "\\" + int_1 + "\\" + text2 + ".txt", string_0 + "\r\n");
					if (string_1 == "")
					{
						string_1 = Class2.smethod_18(text3);
					}
					File.AppendAllText(string_2 + "\\" + int_1 + "\\" + text2 + ".txt", string_1);
				}
			}
			catch
			{
			}
		}

		private void method_6(object sender, EventArgs e)
		{
			try
			{
				int int_ = Convert.ToInt32((sender as Label).Name);
				method_5(int_);
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "CheckDevice");
			}
		}

		public void method_7(int int_1, string string_0)
		{
			try
			{
				Application.DoEvents();
				if (string_0.Trim() != "")
				{
					string_0 = string_0.Replace("\"", "");
					string_0 += (string_0.EndsWith("...") ? "" : "...");
				}
				if (panelListDevice != null)
				{
					panelListDevice.Invoke((MethodInvoker)delegate
					{
						panelListDevice.Controls["dv" + int_1].Controls[2].Text = string_0;
					});
				}
				Application.DoEvents();
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "LoadStatus");
			}
		}

		public void method_8(int int_1, string string_0)
		{
			try
			{
				Application.DoEvents();
				if (string_0.Trim() != "")
				{
					string_0 = string_0.Replace("\"", "");
					string_0 += (string_0.EndsWith("...") ? "" : "...");
				}
				if (panelListDevice != null)
				{
					panelListDevice.Invoke((MethodInvoker)delegate
					{
						panelListDevice.Controls["dv" + int_1].Controls[1].Text = "> " + string_0;
					});
				}
				method_7(int_1, "");
				Application.DoEvents();
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "LoadHanhDong");
			}
		}

		public void method_9(IntPtr intptr_0, int int_1, int int_2, string string_0)
		{
			try
			{
				Control control_ = (from Control control_0 in panelListDevice.Controls
					where control_0.Tag.Equals(int_1)
					select control_0).FirstOrDefault();
				if (control_ == null)
				{
					control_ = (from Control control_0 in panelListDevice.Controls
						where control_0.Tag.Equals(-1)
						select control_0).FirstOrDefault();
					Application.DoEvents();
				}
				method_10(control_, int_1, int_2, string_0);
				Invoke((MethodInvoker)delegate
				{
					Class72.SetParent(intptr_0, control_.Handle);
					Class72.MoveWindow(intptr_0, int_0[2], int_0[3], int_0[4], int_0[5], bool_0: true);
				});
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "AddLDIntoPanel");
			}
		}

		public void method_10(Control control_0, int int_1, int int_2 = 0, string string_0 = "")
		{
			try
			{
				if (control_0 == null)
				{
					return;
				}
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Name = "dv" + int_1;
					control_0.Tag = int_1;
					if (int_1 == -1)
					{
						control_0.Controls[0].Text = "LDPlayer-None";
					}
					else
					{
						control_0.Controls[0].Text = string_0;
					}
					if (int_2 > 0)
					{
						Control control = control_0.Controls[0];
						control.Text = control.Text + ": Ta\u0300i khoa\u0309n " + int_2;
					}
					control_0.Controls[0].Name = int_1.ToString();
					control_0.Controls[1].Name = int_1.ToString();
					control_0.Controls[2].Name = int_1.ToString();
					control_0.Controls[3].Name = int_1.ToString();
				});
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "UpdateInfoPanelDevice");
			}
		}

		private void frmViewLD_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				frmMain.frmMain_0.method_13();
			}
			catch (Exception exception_)
			{
				Common.smethod_82(exception_, "fViewChrome_FormClosing");
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnMaximum_Click(object sender, EventArgs e)
		{
			method_11();
		}

		private void panel1_Click(object sender, EventArgs e)
		{
		}

		private void method_11()
		{
			base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			else if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			else if (base.WindowState == FormWindowState.Maximized)
			{
				base.WindowState = FormWindowState.Normal;
			}
		}

		private void panel1_DoubleClick(object sender, EventArgs e)
		{
			method_11();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewLD));
            this.panelListDevice = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListDevice
            // 
            this.panelListDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListDevice.AutoScroll = true;
            this.panelListDevice.Location = new System.Drawing.Point(0, 47);
            this.panelListDevice.Name = "panelListDevice";
            this.panelListDevice.Size = new System.Drawing.Size(1382, 854);
            this.panelListDevice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMaximum);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 46);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "LDPlayer View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaximum
            // 
            this.btnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximum.FlatAppearance.BorderSize = 0;
            this.btnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximum.ForeColor = System.Drawing.Color.White;
            this.btnMaximum.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximum.Image")));
            this.btnMaximum.Location = new System.Drawing.Point(1296, 4);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(44, 34);
            this.btnMaximum.TabIndex = 0;
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1255, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 34);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1335, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl_0
            // 
            this.bunifuDragControl_0.Fixed = true;
            this.bunifuDragControl_0.Horizontal = true;
            this.bunifuDragControl_0.TargetControl = this.panel1;
            this.bunifuDragControl_0.Vertical = true;
            // 
            // frmViewLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewLD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDPLayer View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewLD_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
