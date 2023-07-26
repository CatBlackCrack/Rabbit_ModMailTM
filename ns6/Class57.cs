using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using ns3;
using ToolRegFB;

namespace ns6
{
	internal static class Class57
	{
		[STAThread]
		private static void Main()
		{
			bool createdNew = false;
			using (new Mutex(initiallyOwned: true, "MyToolRunning", out createdNew))
			{
				try
				{
					if (createdNew)
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(defaultValue: false);
						if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
						{
							MessageBox.Show("Vui lòng chạy Tool bằng quyền Admin!\r\nPlease Run Aplication As Administrator!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							Environment.Exit(0);
						}
						//Application.Run(new CheckKey());
						Application.Run(new frmMain("12-12-2099"));
					}
					else
					{
						MessageBox.Show("ToolRegFbv2 đang chạy. Vui lòng mở Task Manager hoặc tổ hợp Ctrl Shift ESC rồi tìm xuống dưới để tắt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				catch
				{
				}
			}
		}
	}
}
