using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ns1
{
	internal class Class7
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point point_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point point_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_3;

		public ChromeDriver chromeDriver_0;

		public bool HideBrowser
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public bool Incognito
		{
			[CompilerGenerated]
			get
			{
				return bool_1;
			}
			[CompilerGenerated]
			set
			{
				bool_1 = value;
			}
		}

		public bool DisableImage
		{
			[CompilerGenerated]
			get
			{
				return bool_2;
			}
			[CompilerGenerated]
			set
			{
				bool_2 = value;
			}
		}

		public bool DisableSound
		{
			[CompilerGenerated]
			get
			{
				return bool_3;
			}
			[CompilerGenerated]
			set
			{
				bool_3 = value;
			}
		}

		public bool AutoPlayVideo
		{
			[CompilerGenerated]
			get
			{
				return bool_4;
			}
			[CompilerGenerated]
			set
			{
				bool_4 = value;
			}
		}

		public string UserAgent
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string ProfilePath
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public Point Size
		{
			[CompilerGenerated]
			get
			{
				return point_0;
			}
			[CompilerGenerated]
			set
			{
				point_0 = value;
			}
		}

		public int Size_Heigh
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			set
			{
				int_0 = value;
			}
		}

		public int Size_Width
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}

		public Point Position
		{
			[CompilerGenerated]
			get
			{
				return point_1;
			}
			[CompilerGenerated]
			set
			{
				point_1 = value;
			}
		}

		public int Position_X
		{
			[CompilerGenerated]
			get
			{
				return int_2;
			}
			[CompilerGenerated]
			set
			{
				int_2 = value;
			}
		}

		public int Position_Y
		{
			[CompilerGenerated]
			get
			{
				return int_3;
			}
			[CompilerGenerated]
			set
			{
				int_3 = value;
			}
		}

		public int TimeWaitForSearchingElement
		{
			[CompilerGenerated]
			get
			{
				return int_4;
			}
			[CompilerGenerated]
			set
			{
				int_4 = value;
			}
		}

		public int TimeWaitForLoadingPage
		{
			[CompilerGenerated]
			get
			{
				return int_5;
			}
			[CompilerGenerated]
			set
			{
				int_5 = value;
			}
		}

		public string Proxy
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
			[CompilerGenerated]
			set
			{
				string_2 = value;
			}
		}

		public int TypeProxy
		{
			[CompilerGenerated]
			get
			{
				return int_6;
			}
			[CompilerGenerated]
			set
			{
				int_6 = value;
			}
		}

		public string App
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
			[CompilerGenerated]
			set
			{
				string_3 = value;
			}
		}

		public Class7()
		{
			HideBrowser = false;
			DisableImage = false;
			DisableSound = false;
			Incognito = false;
			UserAgent = "";
			ProfilePath = "";
			Size_Heigh = 300;
			Size_Width = 300;
			Size = new Point(Size_Width, Size_Heigh);
			Position_X = 0;
			Position_Y = 0;
			Proxy = "";
			TypeProxy = 0;
			Position = new Point(Position_X, Position_Y);
			TimeWaitForSearchingElement = 0;
			TimeWaitForLoadingPage = 5;
			App = "";
			AutoPlayVideo = false;
		}

		public bool method_0()
		{
			bool result = false;
			try
			{
				ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
				chromeDriverService.HideCommandPromptWindow = true;
				ChromeOptions chromeOptions = new ChromeOptions();
				chromeOptions.AddArguments("--disable-notifications", "--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-popup-blocking");
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.notifications", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.popups", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.auto_select_certificate", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.mixed_script", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protocol_handlers", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.midi_sysex", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.push_messaging", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.ssl_cert_decisions", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.metro_switch_to_desktop", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protected_media_identifier", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.site_engagement", 1);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.durable_storage", 1);
				chromeOptions.AddUserProfilePreference("useAutomationExtension", true);
				if (DisableSound)
				{
					chromeOptions.AddArgument("--mute-audio");
				}
				if (!HideBrowser)
				{
					if (DisableImage)
					{
						chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
					}
					if (!string.IsNullOrEmpty(ProfilePath.Trim()))
					{
						chromeOptions.AddArgument("--user-data-dir=" + ProfilePath);
					}
				}
				else
				{
					chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
					chromeOptions.AddArgument("--headless");
				}
				if (Incognito)
				{
					chromeOptions.AddArguments("--incognito");
				}
				if (!string.IsNullOrEmpty(Proxy.Trim()))
				{
					switch (Proxy.Split(':').Count())
					{
					case 1:
						if (TypeProxy == 0)
						{
							chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + Proxy);
						}
						else
						{
							chromeOptions.AddArgument("--proxy-server= socks5://127.0.0.1:" + Proxy);
						}
						break;
					case 2:
						if (TypeProxy == 0)
						{
							chromeOptions.AddArgument("--proxy-server= " + Proxy);
						}
						else
						{
							chromeOptions.AddArgument("--proxy-server= socks5://" + Proxy);
						}
						break;
					case 4:
						if (TypeProxy == 0)
						{
							chromeOptions.AddArgument("--proxy-server= " + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
							chromeOptions.AddExtension("extension\\proxy.crx");
						}
						else
						{
							chromeOptions.AddArgument("--proxy-server= socks5://" + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
							chromeOptions.AddExtension("extension\\proxy.crx");
						}
						break;
					}
				}
				if (!string.IsNullOrEmpty(App.Trim()))
				{
					chromeOptions.AddArgument("--app= " + App);
				}
				if (UserAgent != "")
				{
					if (Proxy.Split(':').Count() == 4)
					{
						chromeOptions.AddArgument("--user-agent=" + UserAgent + "$PC$" + Proxy.Split(':')[2] + ":" + Proxy.Split(':')[3]);
					}
					else
					{
						chromeOptions.AddArgument("--user-agent=" + UserAgent);
					}
				}
				if (AutoPlayVideo)
				{
					chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
				}
				chromeDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
				chromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeWaitForSearchingElement);
				chromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(TimeWaitForLoadingPage);
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.Open()");
				return result;
			}
		}

		public bool method_1(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).SendKeys(Keys.ArrowDown);
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).SendKeys(Keys.ArrowDown);
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).SendKeys(Keys.ArrowDown);
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).SendKeys(Keys.ArrowDown);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeyDown({int_7},{string_4})");
				return result;
			}
		}

		public string method_2()
		{
			try
			{
				return chromeDriver_0.Url;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetURL()");
			}
			return "";
		}

		public bool method_3(string string_4)
		{
			bool result = false;
			try
			{
				chromeDriver_0.Navigate().GoToUrl(string_4);
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GotoURL(" + string_4 + ")");
				return result;
			}
		}

		public bool method_4()
		{
			bool result = false;
			try
			{
				chromeDriver_0.Navigate().Refresh();
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.Refresh()");
				return result;
			}
		}

		public bool method_5()
		{
			bool result = false;
			try
			{
				chromeDriver_0.Navigate().Back();
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GotoBackPage()");
				return result;
			}
		}

		public object method_6(string string_4)
		{
			try
			{
				return chromeDriver_0.ExecuteScript(string_4);
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ExecuteScript(" + string_4 + ")");
			}
			return "";
		}

		public bool method_7(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).Click();
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).Click();
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).Click();
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).Click();
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.Click({int_7},{string_4})");
				return result;
			}
		}

		public bool method_8()
		{
			return !method_17();
		}

		public int method_9(int int_7, string string_4, int int_8 = 0, int int_9 = 0, string string_5 = "", int int_10 = 0, int int_11 = 1)
		{
			bool flag = false;
			if (!method_8())
			{
				return -2;
			}
			for (int i = 0; i < int_11; method_31(1.0), i++)
			{
				try
				{
					if (int_9 == 0)
					{
						switch (int_7)
						{
						case 1:
							chromeDriver_0.FindElementsById(string_4)[int_8].Click();
							break;
						case 2:
							chromeDriver_0.FindElementsByName(string_4)[int_8].Click();
							break;
						case 3:
							chromeDriver_0.FindElementsByXPath(string_4)[int_8].Click();
							break;
						case 4:
							chromeDriver_0.FindElementsByCssSelector(string_4)[int_8].Click();
							break;
						}
					}
					else
					{
						switch (int_7)
						{
						case 1:
							chromeDriver_0.FindElementsById(string_4)[int_8].FindElements(By.Id(string_5))[int_10].Click();
							break;
						case 2:
							chromeDriver_0.FindElementsByName(string_4)[int_8].FindElements(By.Name(string_5))[int_10].Click();
							break;
						case 3:
							chromeDriver_0.FindElementsByXPath(string_4)[int_8].FindElements(By.XPath(string_5))[int_10].Click();
							break;
						case 4:
							chromeDriver_0.FindElementsByCssSelector(string_4)[int_8].FindElements(By.CssSelector(string_5))[int_10].Click();
							break;
						}
					}
					flag = true;
				}
				catch (Exception exception_)
				{
					smethod_0(null, exception_, $"chrome.Click({int_7},{string_4})");
					continue;
				}
				break;
			}
			return flag ? 1 : 0;
		}

		public bool method_10(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					new Actions(chromeDriver_0).Click(chromeDriver_0.FindElementById(string_4)).Perform();
					break;
				case 2:
					new Actions(chromeDriver_0).Click(chromeDriver_0.FindElementByName(string_4)).Perform();
					break;
				case 3:
					new Actions(chromeDriver_0).Click(chromeDriver_0.FindElementByXPath(string_4)).Perform();
					break;
				case 4:
					new Actions(chromeDriver_0).Click(chromeDriver_0.FindElementByCssSelector(string_4)).Perform();
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.ClickWithAction({int_7},{string_4})");
				return result;
			}
		}

		public bool method_11(int int_7, string string_4, string string_5, bool bool_5 = true)
		{
			bool result = false;
			try
			{
				if (bool_5)
				{
					method_7(int_7, string_4);
				}
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).SendKeys(string_5);
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).SendKeys(string_5);
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).SendKeys(string_5);
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).SendKeys(string_5);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_7},{string_4},{string_5},{bool_5})");
				return result;
			}
		}

		public bool method_12(int int_7, string string_4, string string_5, double double_0, bool bool_5 = true)
		{
			bool result = false;
			try
			{
				if (bool_5)
				{
					method_7(int_7, string_4);
				}
				for (int i = 0; i < string_5.Length; i++)
				{
					switch (int_7)
					{
					case 1:
						chromeDriver_0.FindElementById(string_4).SendKeys(string_5[i].ToString());
						break;
					case 2:
						chromeDriver_0.FindElementByName(string_4).SendKeys(string_5[i].ToString());
						break;
					case 3:
						chromeDriver_0.FindElementByXPath(string_4).SendKeys(string_5[i].ToString());
						break;
					case 4:
						chromeDriver_0.FindElementByCssSelector(string_4).SendKeys(string_5[i].ToString());
						break;
					}
					Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_7},{string_4},{string_5},{double_0},{bool_5})");
				return result;
			}
		}

		public bool method_13(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).SendKeys(Keys.Control + "a");
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).SendKeys(Keys.Control + "a");
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).SendKeys(Keys.Control + "a");
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).SendKeys(Keys.Control + "a");
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SelectText({int_7},{string_4})");
				return result;
			}
		}

		public bool method_14(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).Clear();
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).Clear();
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).Clear();
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).Clear();
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.ClearText({int_7},{string_4})");
				return result;
			}
		}

		public int method_15(string string_4, double double_0 = 0.0)
		{
			bool flag = true;
			if (!method_8())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_4 + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						if (method_8())
						{
							Thread.Sleep(1000);
							continue;
						}
						return -2;
					}
					flag = false;
					break;
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.CheckExistElement({string_4},{double_0})");
			}
			return flag ? 1 : 0;
		}

		public bool method_16(string string_4, double double_0 = 0.0)
		{
			bool result = true;
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_4 + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					return false;
				}
				return result;
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_0(null, exception_, $"chrome.CheckExistElement({string_4},{double_0})");
				return result;
			}
		}

		public bool method_17()
		{
			bool result = true;
			try
			{
				_ = chromeDriver_0.Title;
				result = false;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CheckChromeClosed()");
				return result;
			}
		}

		public bool method_18(string string_4, int int_7 = 0, double double_0 = 0.0)
		{
			bool result = true;
			try
			{
				int tickCount = Environment.TickCount;
				if (int_7 == 0)
				{
					while ((string)chromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_4 + "').length+''") == "0")
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						return false;
					}
					return result;
				}
				while ((string)chromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_4 + "').length+''") != "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					return false;
				}
				return result;
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_0(null, exception_, $"chrome.WaitForSearchElement({string_4},{int_7},{double_0})");
				return result;
			}
		}

		public int method_19(double double_0 = 0.0, params string[] string_4)
		{
			int result = 0;
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					for (int i = 0; i < string_4.Length; i++)
					{
						if (method_16(string_4[i]))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, string.Format("chrome.CheckExistElements({0},{1})", double_0, string.Join("|", string_4)));
			}
			return result;
		}

		public bool method_20(int int_7, string string_4)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					chromeDriver_0.FindElementById(string_4).SendKeys(Keys.Enter);
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_4).SendKeys(Keys.Enter);
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_4).SendKeys(Keys.Enter);
					break;
				case 4:
					chromeDriver_0.FindElementByCssSelector(string_4).SendKeys(Keys.Enter);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendEnter({int_7},{string_4})");
				return result;
			}
		}

		public bool method_21(int int_7, int int_8)
		{
			bool result = false;
			try
			{
				string script = $"window.scrollTo({int_7}, {int_8})";
				chromeDriver_0.ExecuteScript(script);
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.Scroll({int_7},{int_8})");
				return result;
			}
		}

		public void method_22(string string_4)
		{
			try
			{
				chromeDriver_0.ExecuteScript(string_4 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ScrollSmooth(" + string_4 + ")");
			}
		}

		public void method_23()
		{
			try
			{
				chromeDriver_0.Quit();
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.Close()");
			}
		}

		public bool method_24(string string_4, string string_5)
		{
			bool result = false;
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)chromeDriver_0).GetScreenshot();
				screenshot.SaveAsFile(string_4 + (string_4.EndsWith("\\") ? "" : "\\") + string_5 + ".png");
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ScreenCapture(" + string_4 + "," + string_5 + ")");
				return result;
			}
		}

		public void method_25(string string_4, string string_5 = ".facebook.com")
		{
			try
			{
				string[] array = string_4.Split(';');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Trim() != "")
					{
						string[] array3 = text.Split('=');
						if (array3.Count() > 1 && array3[0].Trim() != "")
						{
							Cookie cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_5, "/", DateTime.Now.AddDays(10.0));
							chromeDriver_0.Manage().Cookies.AddCookie(cookie);
						}
					}
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.AddCookieIntoChrome(" + string_4 + "," + string_5 + ")");
			}
		}

		public string method_26(string string_4 = "facebook")
		{
			string text = "";
			try
			{
				Cookie[] array = chromeDriver_0.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				foreach (Cookie cookie in array2)
				{
					if (cookie.Domain.Contains(string_4))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetCookieFromChrome(" + string_4 + ")");
			}
			return text;
		}

		public void method_27(string string_4, bool bool_5 = true)
		{
			try
			{
				chromeDriver_0.ExecuteScript("window.open('" + string_4 + "', '_blank').focus();");
				if (bool_5)
				{
					chromeDriver_0.SwitchTo().Window(chromeDriver_0.WindowHandles.Last());
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.OpenNewTab({string_4},{bool_5})");
			}
		}

		public void method_28()
		{
			try
			{
				chromeDriver_0.Close();
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CloseCurrentTab()");
			}
		}

		public void method_29()
		{
			try
			{
				chromeDriver_0.SwitchTo().Window(chromeDriver_0.WindowHandles.First());
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.SwitchToFirstTab()");
			}
		}

		public void method_30()
		{
			try
			{
				chromeDriver_0.SwitchTo().Window(chromeDriver_0.WindowHandles.Last());
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.SwitchToLastTab()");
			}
		}

		public void method_31(double double_0)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.DelayTime({double_0})");
			}
		}

		public static void smethod_0(Class7 class7_0, Exception exception_0, string string_4 = "")
		{
			try
			{
				if (!Directory.Exists("log"))
				{
					Directory.CreateDirectory("log");
				}
				if (!Directory.Exists("log\\html"))
				{
					Directory.CreateDirectory("log\\html");
				}
				if (!Directory.Exists("log\\images"))
				{
					Directory.CreateDirectory("log\\images");
				}
				Random random = new Random();
				string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
				if (class7_0 != null)
				{
					string contents = class7_0.method_6("var markup = document.documentElement.innerHTML;return markup;").ToString();
					class7_0.method_24("log\\images\\", text);
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
				streamWriter.WriteLine("-----------------------------------------------------------------------------");
				streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
				streamWriter.WriteLine("File: " + text);
				if (string_4 != "")
				{
					streamWriter.WriteLine("Error: " + string_4);
				}
				streamWriter.WriteLine();
				if (exception_0 != null)
				{
					streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
					streamWriter.WriteLine("Message: " + exception_0.Message);
					streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
					exception_0 = exception_0.InnerException;
				}
			}
			catch
			{
			}
		}

		public bool method_32(int int_7, string string_4, string string_5)
		{
			bool result = false;
			try
			{
				switch (int_7)
				{
				case 1:
					new SelectElement(chromeDriver_0.FindElementById(string_4)).SelectByValue(string_5);
					break;
				case 2:
					new SelectElement(chromeDriver_0.FindElementByName(string_4)).SelectByValue(string_5);
					break;
				case 3:
					new SelectElement(chromeDriver_0.FindElementByXPath(string_4)).SelectByValue(string_5);
					break;
				case 4:
					new SelectElement(chromeDriver_0.FindElementByCssSelector(string_4)).SelectByValue(string_5);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.Select({int_7},{string_4},{string_5})");
				return result;
			}
		}
	}
}
