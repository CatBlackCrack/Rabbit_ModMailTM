using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DeviceId;

namespace ToolRegFB
{
    public partial class banking : Form
    {
        public banking()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text); //Momo
            MessageBox.Show("Copy MOMO Thành Công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text); //MBBank
            MessageBox.Show("Copy MBBANK Thành Công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        string text = Common.smethod_5(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber()
                .ToString()); // Md5 Encode

        

        private void banking_Load(object sender, EventArgs e)
        {
           
            this.maMay.Text = text.Substring(0, 32) + "_Rabbitv2";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(maMay.Text);

            MessageBox.Show("Copy MÃ MÁY Thành Công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel1.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            banggia bg = new banggia();
            bg.Show();
            this.Hide();
        }

        private void zalo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://zalo.me/0355258611");
        }

        
    }
}
