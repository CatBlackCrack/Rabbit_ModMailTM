using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Linq;
using ns2;
using ns3;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ToolRegFB;
using ToolRegFB.Properties;

namespace ns10
{
	internal class Class75
	{
		[CompilerGenerated]
		private sealed class Class76
		{
			public string string_0;

			public Func<Process, bool> func_0;

			internal bool method_0(Process process_0)
			{
				return process_0.MainWindowTitle.Contains(string_0);
			}
		}

		public int int_0;

		private Random random_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Process process_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ChromeDriver chromeDriver_0;

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
		private int int_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point point_0;

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
		private string string_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bool_6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point point_2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Enum1 enum1_0;

		public Process process
		{
			[CompilerGenerated]
			get
			{
				return process_0;
			}
			[CompilerGenerated]
			set
			{
				process_0 = value;
			}
		}

		public ChromeDriver chrome
		{
			[CompilerGenerated]
			get
			{
				return chromeDriver_0;
			}
			[CompilerGenerated]
			set
			{
				chromeDriver_0 = value;
			}
		}

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

		public int PixelRatio
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

		public int TimeWaitForSearchingElement
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

		public int TimeWaitForLoadingPage
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
				return int_4;
			}
			[CompilerGenerated]
			set
			{
				int_4 = value;
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

		public string LinkToOtherBrowser
		{
			[CompilerGenerated]
			get
			{
				return string_4;
			}
			[CompilerGenerated]
			set
			{
				string_4 = value;
			}
		}

		public string PathExtension
		{
			[CompilerGenerated]
			get
			{
				return string_5;
			}
			[CompilerGenerated]
			set
			{
				string_5 = value;
			}
		}

		public bool IsUseEmulator
		{
			[CompilerGenerated]
			get
			{
				return bool_5;
			}
			[CompilerGenerated]
			set
			{
				bool_5 = value;
			}
		}

		public bool IsUsePortable
		{
			[CompilerGenerated]
			get
			{
				return bool_6;
			}
			[CompilerGenerated]
			set
			{
				bool_6 = value;
			}
		}

		public string PathToPortableZip
		{
			[CompilerGenerated]
			get
			{
				return string_6;
			}
			[CompilerGenerated]
			set
			{
				string_6 = value;
			}
		}

		public Point Size_Emulator
		{
			[CompilerGenerated]
			get
			{
				return point_2;
			}
			[CompilerGenerated]
			set
			{
				point_2 = value;
			}
		}

		public Enum1 Status
		{
			[CompilerGenerated]
			get
			{
				return enum1_0;
			}
			[CompilerGenerated]
			set
			{
				enum1_0 = value;
			}
		}

		public Class75()
		{
			int_0 = 0;
			HideBrowser = false;
			DisableImage = false;
			DisableSound = false;
			Incognito = false;
			UserAgent = "";
			ProfilePath = "";
			Size = new Point(300, 300);
			Size = new Point(Size.X, Size.Y);
			Proxy = "";
			TypeProxy = 0;
			Position = new Point(Position.X, Position.Y);
			TimeWaitForSearchingElement = 0;
			TimeWaitForLoadingPage = 1;
			App = "";
			AutoPlayVideo = false;
			LinkToOtherBrowser = "";
			PathExtension = "data\\extension";
			IsUseEmulator = false;
			Size_Emulator = new Point(300, 300);
			Status = Enum1.const_0;
			IsUsePortable = false;
			PathToPortableZip = "";
			random_0 = new Random();
		}

		public bool method_0(bool bool_7 = false)
		{
			bool result = false;
			try
			{
				ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
				chromeDriverService.HideCommandPromptWindow = true;
				ChromeOptions chromeOptions = new ChromeOptions();
				chromeOptions.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=\"BlockCredentialedSubresources\"", "--disable-popup-blocking");
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
				if (DisableSound)
				{
					chromeOptions.AddArgument("--mute-audio");
				}
				chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
				chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
				chromeOptions.AddExcludedArgument("enable-automation");
				chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
				if (LinkToOtherBrowser != "" && File.Exists(LinkToOtherBrowser))
				{
					chromeOptions.BinaryLocation = LinkToOtherBrowser;
				}
				if (IsUsePortable)
				{
					if (!string.IsNullOrEmpty(ProfilePath.Trim()))
					{
						if (!Directory.Exists(ProfilePath))
						{
							ZipFile.ExtractToDirectory(PathToPortableZip, ProfilePath);
						}
						chromeOptions.BinaryLocation = ProfilePath + "\\App\\Chrome-bin\\chrome.exe";
						if (!HideBrowser)
						{
							if (DisableImage)
							{
								chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
							}
							chromeOptions.AddArgument("--user-data-dir=" + ProfilePath + "\\Data\\profile");
						}
						else
						{
							chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
							chromeOptions.AddArgument("--headless");
						}
					}
				}
				else if (!HideBrowser)
				{
					if (DisableImage)
					{
						chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
					}
					if (!string.IsNullOrEmpty(ProfilePath.Trim()))
					{
						try
						{
							chromeOptions.AddArgument("--user-data-dir=" + ProfilePath);
							File.Delete(ProfilePath + "\\Default\\Secure Preferences");
							string json = File.ReadAllText(ProfilePath + "\\Default\\Preferences");
							JObject jObject = JObject.Parse(json);
							jObject["profile"]!["exit_type"] = (JToken)"none";
							File.WriteAllText(ProfilePath + "\\Default\\Preferences", jObject.ToString());
						}
						catch (Exception)
						{
						}
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
							chromeOptions.AddExtension("extension\\proxy1.crx");
						}
						else
						{
							chromeOptions.AddArgument("--proxy-server= socks5://" + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
							chromeOptions.AddExtension("extension\\proxy1.crx");
						}
						break;
					}
				}
				if (!bool_7)
				{
					chromeOptions.AddArgument("--user-agent=" + UserAgent);
				}
				bool flag = false;
				if (!HideBrowser && PathExtension.Trim() != "")
				{
					if (!Directory.Exists(PathExtension))
					{
						Directory.CreateDirectory(PathExtension);
					}
					string[] files = Directory.GetFiles(PathExtension);
					if (files.Length != 0)
					{
						flag = true;
					}
					for (int i = 0; i < files.Length; i++)
					{
						chromeOptions.AddExtension(files[i]);
					}
				}
				if (!flag && !string.IsNullOrEmpty(App.Trim()))
				{
					chromeOptions.AddArgument("--app= " + App);
				}
				if (IsUseEmulator)
				{
					ChromeMobileEmulationDeviceSettings deviceSettings = new ChromeMobileEmulationDeviceSettings
					{
						EnableTouchEvents = true,
						Width = Size_Emulator.X,
						Height = Size_Emulator.Y,
						UserAgent = UserAgent,
						PixelRatio = PixelRatio
					};
					chromeOptions.EnableMobileEmulation(deviceSettings);
				}
				if (AutoPlayVideo)
				{
					chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
				}
				chrome = new ChromeDriver(chromeDriverService, chromeOptions);
				chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeWaitForSearchingElement);
				chrome.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(TimeWaitForLoadingPage);
				if (Settings.Default.PathChrome == "")
				{
					chrome.Close();
					return result;
				}
				result = true;
				return true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.Open()");
				return result;
			}
		}

		public string method_1()
		{
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				return chrome.PageSource;
			}
			catch (Exception)
			{
			}
			return "";
		}

		public bool method_2()
		{
			return !method_3();
		}

		public bool method_3()
		{
			if (process != null)
			{
				return process.HasExited;
			}
			bool result = true;
			try
			{
				_ = chrome.Title;
				result = false;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CheckChromeClosed()");
			}
			return result;
		}

		public bool method_4(string string_7, string string_8, string string_9 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string string_10 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
		{
			bool result = false;
			try
			{
				Common.smethod_12(string_7, string_8, string_10, "--user-data-dir=\"" + ProfilePath + "\"", string_10.Substring(0, string_10.LastIndexOf("\\")), string_9);
				return result;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CreateShortcut(" + string_7 + "," + string_8 + "," + string_10 + ")");
				return result;
			}
		}

		public string method_5(string string_7, string string_8, string string_9)
		{
			string result = "";
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_7 + "','" + string_8 + "','" + string_9 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetCssSelector(" + string_7 + "," + string_8 + "," + string_9 + ")");
			}
			return result;
		}

		public string method_6(string string_7)
		{
			string result = "";
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; return GetSelector(" + string_7 + ")").ToString();
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetCssSelector(" + string_7 + ")");
			}
			return result;
		}

		public string method_7(string string_7, string string_8)
		{
			string result = "";
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("return document.querySelector('" + string_7 + "').getAttribute('" + string_8 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetAttributeValue(" + string_7 + "," + string_8 + ")");
			}
			return result;
		}

		public int method_8(int int_5)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				chrome.ExecuteScript("window.scrollBy({ top: " + int_5 + ",behavior: 'smooth'});");
				method_66(0.1);
				if (num == Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString()))
				{
					return 2;
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.ScrollSmooth({int_5})");
			}
			return 1;
		}

		public string method_9()
		{
			string result = "";
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("return navigator.userAgent").ToString();
			}
			catch
			{
			}
			return result;
		}

		public int method_10(int int_5, string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).SendKeys(Keys.ArrowDown);
					break;
				case 2:
					chrome.FindElementByName(string_7).SendKeys(Keys.ArrowDown);
					break;
				case 3:
					chrome.FindElementByXPath(string_7).SendKeys(Keys.ArrowDown);
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).SendKeys(Keys.ArrowDown);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeyDown({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_11(int int_5, string string_7, int int_6 = 0, int int_7 = 0, string string_8 = "", int int_8 = 0, int int_9 = 1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			for (int i = 0; i < int_9; method_66(1.0), i++)
			{
				try
				{
					if (int_7 == 0)
					{
						switch (int_5)
						{
						case 1:
							chrome.FindElementsById(string_7)[int_6].SendKeys(Keys.End);
							break;
						case 2:
							chrome.FindElementsByName(string_7)[int_6].SendKeys(Keys.End);
							break;
						case 3:
							chrome.FindElementsByXPath(string_7)[int_6].SendKeys(Keys.End);
							break;
						case 4:
							chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(Keys.End);
							break;
						}
					}
					else
					{
						switch (int_5)
						{
						case 1:
							chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].SendKeys(Keys.End);
							break;
						case 2:
							chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].SendKeys(Keys.End);
							break;
						case 3:
							chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].SendKeys(Keys.End);
							break;
						case 4:
							chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].SendKeys(Keys.End);
							break;
						}
					}
					flag = true;
				}
				catch (Exception exception_)
				{
					smethod_0(null, exception_, $"chrome.End({int_5},{string_7})");
					continue;
				}
				break;
			}
			return flag ? 1 : 0;
		}

		public string method_12()
		{
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				return chrome.Url;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetURL()");
			}
			return "";
		}

		public int method_13(string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.Navigate().GoToUrl(string_7);
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GotoURL(" + string_7 + ")");
			}
			return flag ? 1 : 0;
		}

		public int method_14(string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (method_12() != string_7)
				{
					chrome.Navigate().GoToUrl(string_7);
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GotoURL(" + string_7 + ")");
			}
			return flag ? 1 : 0;
		}

		public int method_15()
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.Navigate().Refresh();
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.Refresh()");
			}
			return flag ? 1 : 0;
		}

		public int method_16(int int_5 = 1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				for (int i = 0; i < int_5; i++)
				{
					chrome.Navigate().Back();
					method_66(0.5);
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GotoBackPage()");
			}
			return flag ? 1 : 0;
		}

		public int method_17(int int_5, string string_7, int int_6, double double_0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				new WebDriverWait(chrome, TimeSpan.FromSeconds(10.0));
				switch (int_5)
				{
				case 1:
					new Actions(chrome).MoveToElement(chrome.FindElementsById(string_7)[int_6]).Perform();
					break;
				case 2:
					new Actions(chrome).MoveToElement(chrome.FindElementsByName(string_7)[int_6]).Perform();
					break;
				case 3:
					new Actions(chrome).MoveToElement(chrome.FindElementsByXPath(string_7)[int_6]).Perform();
					break;
				case 4:
					new Actions(chrome).MoveToElement(chrome.FindElementsByCssSelector(string_7)[int_6]).Perform();
					break;
				}
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.HoverElement({int_5}, {string_7}, {double_0})");
			}
			return flag ? 1 : 0;
		}

		public int method_18(int int_5, string string_7, double double_0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				WebDriverWait webDriverWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10.0));
				switch (int_5)
				{
				case 1:
					new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(string_7)))).Perform();
					break;
				case 2:
					new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(string_7)))).Perform();
					break;
				case 3:
					new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(string_7)))).Perform();
					break;
				case 4:
					new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(string_7)))).Perform();
					break;
				}
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.HoverElement({int_5}, {string_7}, {double_0})");
			}
			return flag ? 1 : 0;
		}

		public bool method_19(int int_5, string string_7, int int_6)
		{
			bool result = true;
			try
			{
				switch (int_5)
				{
				case 1:
					new Actions(chrome).MoveToElement(chrome.FindElementsById(string_7)[int_6]).Build().Perform();
					break;
				case 2:
					new Actions(chrome).MoveToElement(chrome.FindElementsByName(string_7)[int_6]).Build().Perform();
					break;
				case 3:
					new Actions(chrome).MoveToElement(chrome.FindElementsByXPath(string_7)[int_6]).Build().Perform();
					break;
				case 4:
					new Actions(chrome).MoveToElement(chrome.FindElementsByCssSelector(string_7)[int_6]).Build().Perform();
					break;
				}
				result = true;
				return true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.MoveToElement({int_5},{string_7},{int_6})");
				return result;
			}
		}

		public object method_20(string string_7)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				return chrome.ExecuteScript(string_7);
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ExecuteScript(" + string_7 + ")");
			}
			return "";
		}

		public Image method_21(IntPtr intptr_0)
		{
			IntPtr windowDC = Class79.GetWindowDC(intptr_0);
			Class79.Struct0 struct0_ = default(Class79.Struct0);
			Class79.GetWindowRect(intptr_0, ref struct0_);
			int num = struct0_.int_2 - struct0_.int_0;
			int num2 = struct0_.int_3 - struct0_.int_1;
			IntPtr intptr_ = Class77.CreateCompatibleDC(windowDC);
			IntPtr intPtr = Class77.CreateCompatibleBitmap(windowDC, num, num2);
			IntPtr intptr_2 = Class77.SelectObject(intptr_, intPtr);
			Class77.BitBlt(intptr_, 0, 0, num, num2, windowDC, 0, 0, 13369376);
			Class77.SelectObject(intptr_, intptr_2);
			Class77.DeleteDC(intptr_);
			Class79.ReleaseDC(intptr_0, windowDC);
			Image result = Image.FromHbitmap(intPtr);
			Class77.DeleteObject(intPtr);
			return result;
		}

		public Bitmap method_22(int int_5 = 1)
		{
			Bitmap result = null;
			try
			{
				for (int i = 0; i < int_5; i++)
				{
					try
					{
						result = (Bitmap)method_21(process.MainWindowHandle);
					}
					catch (Exception exception_)
					{
						smethod_0(this, exception_, "CaptureWindow");
						Common.smethod_62(1.0);
						continue;
					}
					break;
				}
			}
			catch (Exception exception_2)
			{
				smethod_0(null, exception_2, "AutoChrome.ScreenCapture()");
			}
			return result;
		}

		public bool method_23(string string_7, int int_5 = 0)
		{
			if (method_24(string_7, int_5).HasValue)
			{
				return true;
			}
			return false;
		}

		public Point? method_24(string string_7, int int_5 = 0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_7);
			FileInfo[] files = directoryInfo.GetFiles();
			int tickCount = Environment.TickCount;
			do
			{
				Bitmap bitmap = method_22(3);
				if (bitmap == null)
				{
					break;
				}
				Point? point = null;
				FileInfo[] array = files;
				FileInfo[] array2 = array;
				foreach (FileInfo fileInfo in array2)
				{
					Bitmap bitmap_ = (Bitmap)Image.FromFile(fileInfo.FullName);
					point = Class78.smethod_3(bitmap, bitmap_);
					if (point.HasValue)
					{
						int x = point.Value.X;
						int y = point.Value.Y;
						return new Point(x, y);
					}
				}
				Common.smethod_62(1.0);
			}
			while (Environment.TickCount - tickCount <= int_5 * 1000);
			return null;
		}

		public int method_25(string string_7, int int_5 = 0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				Point? point = method_24(string_7, int_5);
				if (point.HasValue)
				{
					AutoControl.smethod_17(process.MainWindowHandle, point.Value.X, point.Value.Y);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int method_26(int int_5, string string_7, int int_6 = 0, int int_7 = 0, string string_8 = "", int int_8 = 0, int int_9 = 1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			for (int i = 0; i < int_9; method_66(1.0), i++)
			{
				try
				{
					if (int_7 == 0)
					{
						switch (int_5)
						{
						case 1:
							chrome.FindElementsById(string_7)[int_6].Click();
							break;
						case 2:
							chrome.FindElementsByName(string_7)[int_6].Click();
							break;
						case 3:
							chrome.FindElementsByXPath(string_7)[int_6].Click();
							break;
						case 4:
							chrome.FindElementsByCssSelector(string_7)[int_6].Click();
							break;
						}
					}
					else
					{
						switch (int_5)
						{
						case 1:
							chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].Click();
							break;
						case 2:
							chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].Click();
							break;
						case 3:
							chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].Click();
							break;
						case 4:
							chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].Click();
							break;
						}
					}
					flag = true;
				}
				catch (Exception exception_)
				{
					smethod_0(null, exception_, $"chrome.Click({int_5},{string_7})");
					continue;
				}
				break;
			}
			return flag ? 1 : 0;
		}

		public int method_27(double double_0, int int_5, string string_7, int int_6 = 0, int int_7 = 0, string string_8 = "", int int_8 = 0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					try
					{
						if (int_7 == 0)
						{
							switch (int_5)
							{
							case 1:
								chrome.FindElementsById(string_7)[int_6].Click();
								break;
							case 2:
								chrome.FindElementsByName(string_7)[int_6].Click();
								break;
							case 3:
								chrome.FindElementsByXPath(string_7)[int_6].Click();
								break;
							case 4:
								chrome.FindElementsByCssSelector(string_7)[int_6].Click();
								break;
							}
						}
						else
						{
							switch (int_5)
							{
							case 1:
								chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].Click();
								break;
							case 2:
								chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].Click();
								break;
							case 3:
								chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].Click();
								break;
							case 4:
								chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].Click();
								break;
							}
						}
						flag = true;
						method_66(1.0);
					}
					catch (Exception)
					{
						goto IL_01b2;
					}
					break;
					IL_01b2:
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_66(1.0);
						continue;
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.FindAndClick({double_0},{int_5},{string_7},{int_6},{int_7},{string_8},{int_8}");
			}
			return flag ? 1 : 0;
		}

		public int method_28(int int_5, string string_7, int int_6 = 0, int int_7 = 0, string string_8 = "", int int_8 = 0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (int_7 != 0)
				{
					switch (int_5)
					{
					case 1:
						new Actions(chrome).Click(chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8]).Perform();
						break;
					case 2:
						new Actions(chrome).Click(chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8]).Perform();
						break;
					case 3:
						new Actions(chrome).Click(chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8]).Perform();
						break;
					case 4:
						new Actions(chrome).Click(chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8]).Perform();
						break;
					}
				}
				else
				{
					switch (int_5)
					{
					case 1:
						new Actions(chrome).Click(chrome.FindElementsById(string_7)[int_6]).Perform();
						break;
					case 2:
						new Actions(chrome).Click(chrome.FindElementsByName(string_7)[int_6]).Perform();
						break;
					case 3:
						new Actions(chrome).Click(chrome.FindElementsByXPath(string_7)[int_6]).Perform();
						break;
					case 4:
						new Actions(chrome).Click(chrome.FindElementsByCssSelector(string_7)[int_6]).Perform();
						break;
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.ClickWithAction({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_29(int int_5, string string_7, string string_8, bool bool_7 = true, double double_0 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					method_66(double_0);
				}
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).SendKeys(string_8);
					break;
				case 2:
					chrome.FindElementByName(string_7).SendKeys(string_8);
					break;
				case 3:
					chrome.FindElementByXPath(string_7).SendKeys(string_8);
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).SendKeys(string_8);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_8},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_30(int int_5, string string_7, int int_6, string string_8, bool bool_7 = true, double double_0 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					method_66(double_0);
				}
				switch (int_5)
				{
				case 1:
					chrome.FindElementsById(string_7)[int_6].SendKeys(string_8);
					break;
				case 2:
					chrome.FindElementsByName(string_7)[int_6].SendKeys(string_8);
					break;
				case 3:
					chrome.FindElementsByXPath(string_7)[int_6].SendKeys(string_8);
					break;
				case 4:
					chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(string_8);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_8},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_31(int int_5, string string_7, string string_8, double double_0, bool bool_7 = true, double double_1 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					method_66(double_1);
				}
				for (int i = 0; i < string_8.Length; i++)
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementById(string_7).SendKeys(string_8[i].ToString());
						break;
					case 2:
						chrome.FindElementByName(string_7).SendKeys(string_8[i].ToString());
						break;
					case 3:
						chrome.FindElementByXPath(string_7).SendKeys(string_8[i].ToString());
						break;
					case 4:
						chrome.FindElementByCssSelector(string_7).SendKeys(string_8[i].ToString());
						break;
					}
					if (double_0 > 0.0)
					{
						int num = Convert.ToInt32(double_0 * 1000.0);
						if (num < 100)
						{
							num = 100;
						}
						Thread.Sleep(Common.random_0.Next(num, num + 50));
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_8},{double_0},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_32(int int_5, string string_7, int int_6, string string_8, double double_0, bool bool_7 = true, double double_1 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					method_66(double_1);
				}
				for (int i = 0; i < string_8.Length; i++)
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementsById(string_7)[int_6].SendKeys(string_8[i].ToString());
						break;
					case 2:
						chrome.FindElementsByName(string_7)[int_6].SendKeys(string_8[i].ToString());
						break;
					case 3:
						chrome.FindElementsByXPath(string_7)[int_6].SendKeys(string_8[i].ToString());
						break;
					case 4:
						chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(string_8[i].ToString());
						break;
					}
					if (double_0 > 0.0)
					{
						int num = Convert.ToInt32(double_0 * 1000.0);
						if (num < 100)
						{
							num = 100;
						}
						Thread.Sleep(Common.random_0.Next(num, num + 50));
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_8},{double_0},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_33(Random random_1, int int_5, string string_7, string string_8, double double_0, bool bool_7 = true, double double_1 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					method_66(double_1);
				}
				int num = 0;
				int num2 = random_1.Next(1, 1000) % 3;
				if (string_8.Length < 3)
				{
					num2 = 2;
				}
				else
				{
					num = random_1.Next(1, string_8.Length * 3 / 4);
					switch (num2)
					{
					case 0:
					{
						string string_11 = string_8.Substring(0, num);
						method_31(int_5, string_7, string_11, Convert.ToDouble(random_1.Next(10, 100)) / 1000.0);
						method_66(random_1.Next(1, 3));
						int num3 = random_1.Next(1, num);
						for (int i = 0; i < num3; i++)
						{
							method_37(int_5, string_7);
							method_66(Convert.ToDouble(random_1.Next(1000, 2000)) / 10000.0);
						}
						string text = "";
						switch (int_5)
						{
						case 1:
							text = "#" + string_7;
							break;
						case 2:
							text = "[name=\"" + string_7 + "\"]";
							break;
						case 4:
							text = string_7;
							break;
						}
						string_11 = string_8.Substring(chrome.ExecuteScript("return document.querySelector('" + text + "').value+''").ToString().Length);
						method_66(random_1.Next(1, 3));
						method_31(int_5, string_7, string_11, Convert.ToDouble(random_1.Next(100, 300)) / 1000.0, bool_7: false);
						method_66(random_1.Next(1, 3));
						goto IL_02c8;
					}
					case 1:
					{
						string string_9 = string_8.Substring(0, num);
						string string_10 = string_8.Substring(num);
						method_31(int_5, string_7, string_9, Convert.ToDouble(random_1.Next(10, 100)) / 1000.0);
						method_66(random_1.Next(1, 3));
						method_31(int_5, string_7, string_10, Convert.ToDouble(random_1.Next(100, 300)) / 1000.0, bool_7: false);
						method_66(random_1.Next(1, 3));
						goto IL_02c8;
					}
					case 2:
						break;
					default:
						goto IL_02c8;
					}
				}
				method_31(int_5, string_7, string_8, Convert.ToDouble(random_1.Next(100, 200)) / 1000.0);
				method_66(random_1.Next(1, 3));
				goto IL_02c8;
				IL_02c8:
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_8},{double_0},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_34(int int_5, string string_7, int int_6, int int_7, string string_8, int int_8, string string_9, bool bool_7 = true, double double_0 = 0.1)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7, int_6, int_7, string_8, int_8);
					method_66(double_0);
				}
				if (int_7 == 0)
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementsById(string_7)[int_6].SendKeys(string_9);
						break;
					case 2:
						chrome.FindElementsByName(string_7)[int_6].SendKeys(string_9);
						break;
					case 3:
						chrome.FindElementsByXPath(string_7)[int_6].SendKeys(string_9);
						break;
					case 4:
						chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(string_9);
						break;
					}
				}
				else
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].SendKeys(string_9);
						break;
					case 2:
						chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].SendKeys(string_9);
						break;
					case 3:
						chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].SendKeys(string_9);
						break;
					case 4:
						chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].SendKeys(string_9);
						break;
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendKeys({int_5},{string_7},{string_9},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_35(int int_5, int int_6, string string_7, string string_8, double double_0, bool bool_7 = true, double double_1 = 0.1)
		{
			if (!method_2())
			{
				return -2;
			}
			int result = 0;
			switch (int_5)
			{
			case 0:
				result = method_33(Common.random_0, int_6, string_7, string_8, double_0, bool_7, double_1);
				break;
			case 1:
				result = method_31(int_6, string_7, string_8, double_0, bool_7, double_1);
				break;
			case 2:
				result = method_29(int_6, string_7, string_8, bool_7, double_1);
				break;
			}
			return result;
		}

		public int method_36(int int_5, int int_6, string string_7, int int_7, int int_8, string string_8, int int_9, string string_9, bool bool_7 = true, double double_0 = 0.1)
		{
			if (!method_2())
			{
				return -2;
			}
			int result = 0;
			switch (int_5)
			{
			case 0:
				result = method_34(int_6, string_7, int_7, int_8, string_8, int_9, string_9);
				break;
			case 1:
				result = method_34(int_6, string_7, int_7, int_8, string_8, int_9, string_9);
				break;
			case 2:
				result = method_34(int_6, string_7, int_7, int_8, string_8, int_9, string_9);
				break;
			}
			return result;
		}

		public int method_37(int int_5, string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).SendKeys(Keys.Backspace);
					break;
				case 2:
					chrome.FindElementByName(string_7).SendKeys(Keys.Backspace);
					break;
				case 3:
					chrome.FindElementByXPath(string_7).SendKeys(Keys.Backspace);
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).SendKeys(Keys.Backspace);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendBackspace({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public void method_38(int int_5 = 0, Random random_1 = null)
		{
			if (random_1 == null)
			{
				random_1 = new Random();
			}
			method_66(random_1.Next(int_5 + 1, int_5 + 4));
		}

		public void method_39(int int_5, int int_6)
		{
			method_66(Common.random_0.Next(int_5, int_6 + 1));
		}

		public int method_40(int int_5, string string_7, int int_6 = 0, int int_7 = 0, string string_8 = "", int int_8 = 0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (int_7 == 0)
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementsById(string_7)[int_6].SendKeys(Keys.Enter);
						break;
					case 2:
						chrome.FindElementsByName(string_7)[int_6].SendKeys(Keys.Enter);
						break;
					case 3:
						chrome.FindElementsByXPath(string_7)[int_6].SendKeys(Keys.Enter);
						break;
					case 4:
						chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(Keys.Enter);
						break;
					}
				}
				else
				{
					switch (int_5)
					{
					case 1:
						chrome.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].SendKeys(Keys.Enter);
						break;
					case 2:
						chrome.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].SendKeys(Keys.Enter);
						break;
					case 3:
						chrome.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].SendKeys(Keys.Enter);
						break;
					case 4:
						chrome.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].SendKeys(Keys.Enter);
						break;
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendEnter({int_5},{string_7},{int_6})");
			}
			return flag ? 1 : 0;
		}

		public int method_41(int int_5, string string_7, int int_6 = 0, bool bool_7 = true, int int_7 = 0)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (bool_7)
				{
					method_26(int_5, string_7);
					Thread.Sleep(Convert.ToInt32(int_7 * 1000));
				}
				switch (int_5)
				{
				case 1:
					chrome.FindElementsById(string_7)[int_6].SendKeys(Keys.Control + "v");
					break;
				case 2:
					chrome.FindElementsByName(string_7)[int_6].SendKeys(Keys.Control + "v");
					break;
				case 3:
					chrome.FindElementsByXPath(string_7)[int_6].SendKeys(Keys.Control + "v");
					break;
				case 4:
					chrome.FindElementsByCssSelector(string_7)[int_6].SendKeys(Keys.Control + "v");
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.PasteContent({int_5},{string_7},{bool_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_42(int int_5, string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).SendKeys(Keys.Control + "a");
					break;
				case 2:
					chrome.FindElementByName(string_7).SendKeys(Keys.Control + "a");
					break;
				case 3:
					chrome.FindElementByXPath(string_7).SendKeys(Keys.Control + "a");
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).SendKeys(Keys.Control + "a");
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SelectText({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_43(int int_5, string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).Clear();
					break;
				case 2:
					chrome.FindElementByName(string_7).Clear();
					break;
				case 3:
					chrome.FindElementByXPath(string_7).Clear();
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).Clear();
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.ClearText({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_44(string string_7)
		{
			int result = 0;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				result = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('" + string_7.Replace("'", "\\'") + "').length+''").ToString());
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CountElement(" + string_7 + ")");
			}
			return result;
		}

		public int method_45(string string_7, double double_0 = 0.0)
		{
			bool flag = true;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + string_7.Replace("'", "\\'") + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						if (method_2())
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
				flag = false;
				smethod_0(null, exception_, $"chrome.CheckExistElement({string_7},{double_0})");
			}
			return flag ? 1 : 0;
		}

		public int method_46(string string_7, double double_0 = 0.0)
		{
			bool flag = true;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chrome.ExecuteScript("return " + string_7 + ".length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					flag = false;
					break;
				}
			}
			catch (Exception exception_)
			{
				flag = false;
				smethod_0(null, exception_, $"chrome.CheckExistElement({string_7},{double_0})");
			}
			return flag ? 1 : 0;
		}

		public int method_47(string string_7, int int_5 = 0, double double_0 = 0.0)
		{
			bool flag = true;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				if (int_5 == 0)
				{
					while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + string_7.Replace("'", "\\'") + "').length+''") == "0")
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						flag = false;
						break;
					}
				}
				else
				{
					while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + string_7.Replace("'", "\\'") + "').length+''") != "0")
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						flag = false;
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				flag = false;
				smethod_0(null, exception_, $"chrome.WaitForSearchElement({string_7},{int_5},{double_0})");
			}
			return flag ? 1 : 0;
		}

		public int method_48(double double_0 = 0.0, params string[] string_7)
		{
			int num = 0;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", string_7) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num == 0)
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						break;
					}
					return num;
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, string.Format("chrome.CheckExistElements({0},{1})", double_0, string.Join("|", string_7)));
			}
			return num;
		}

		public string method_49(double double_0 = 0.0, params string[] string_7)
		{
			int num = 0;
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", string_7) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num == 0)
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						break;
					}
					return string_7[num - 1];
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, string.Format("chrome.CheckExistElements({0},{1})", double_0, string.Join("|", string_7)));
			}
			return "";
		}

		public int method_50(double double_0, Dictionary<int, List<string>> dictionary_0)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					foreach (KeyValuePair<int, List<string>> item in dictionary_0)
					{
						if (Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", item.Value) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; } return (output + ''); ")) != 0)
						{
							return item.Key;
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
			catch
			{
			}
			return 0;
		}

		public int method_51(int int_5, string string_7)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					chrome.FindElementById(string_7).SendKeys(Keys.Enter);
					break;
				case 2:
					chrome.FindElementByName(string_7).SendKeys(Keys.Enter);
					break;
				case 3:
					chrome.FindElementByXPath(string_7).SendKeys(Keys.Enter);
					break;
				case 4:
					chrome.FindElementByCssSelector(string_7).SendKeys(Keys.Enter);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.SendEnter({int_5},{string_7})");
			}
			return flag ? 1 : 0;
		}

		public int method_52(int int_5, int int_6)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				string script = $"window.scrollTo({int_5}, {int_6})";
				chrome.ExecuteScript(script);
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.Scroll({int_5},{int_6})");
			}
			return flag ? 1 : 0;
		}

		public int method_53(string string_7)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.ExecuteScript(string_7 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ScrollSmooth(" + string_7 + ")");
				return 0;
			}
		}

		public int method_54(string string_7)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				if (method_55(string_7) != 0)
				{
					chrome.ExecuteScript(string_7 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
				}
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ScrollSmoothIfNotExistOnScreen(" + string_7 + ")");
				return 0;
			}
		}

		public int method_55(string string_7)
		{
			int result = 0;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				result = Convert.ToInt32(chrome.ExecuteScript("var check='';x=" + string_7 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CheckExistElementOnScreen(" + string_7 + ")");
			}
			return result;
		}

		public Point method_56()
		{
			Point result = new Point(0, 0);
			if (method_2())
			{
				try
				{
					string text = chrome.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
					result.X = Convert.ToInt32(text.Split('|')[1]);
					result.Y = Convert.ToInt32(text.Split('|')[0]);
				}
				catch
				{
				}
			}
			return result;
		}

		public int method_57()
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				try
				{
					chrome.Quit();
				}
				catch
				{
				}
				if (process != null)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
				return 1;
			}
			catch
			{
				return 0;
			}
		}

		public int method_58()
		{
			if (!method_2())
			{
				return -2;
			}
			new Actions(chrome).KeyDown(Keys.Shift).SendKeys(Keys.ArrowUp).SendKeys(Keys.ArrowUp)
				.SendKeys(Keys.ArrowUp)
				.SendKeys(Keys.Delete)
				.KeyUp(Keys.Shift)
				.Build()
				.Perform();
			return 1;
		}

		public int method_59(string string_7, string string_8)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)chrome).GetScreenshot();
				screenshot.SaveAsFile(string_7 + (string_7.EndsWith("\\") ? "" : "\\") + string_8 + ".png");
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.ScreenCapture(" + string_7 + "," + string_8 + ")");
			}
			return flag ? 1 : 0;
		}

		public int method_60(string string_7, string string_8 = ".facebook.com")
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				string[] array = string_7.Split(';');
				string[] array2 = array;
				string[] array3 = array2;
				foreach (string text in array3)
				{
					if (text.Trim() != "")
					{
						string[] array4 = text.Split('=');
						if (array4.Count() > 1 && array4[0].Trim() != "")
						{
							Cookie cookie = new Cookie(array4[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_8, "/", DateTime.Now.AddDays(10.0));
							chrome.Manage().Cookies.AddCookie(cookie);
						}
					}
				}
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.AddCookieIntoChrome(" + string_7 + "," + string_8 + ")");
				return 0;
			}
		}

		public string method_61(string string_7 = "facebook")
		{
			string text = "";
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				Cookie[] array = chrome.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				Cookie[] array3 = array2;
				foreach (Cookie cookie in array3)
				{
					if (cookie.Domain.Contains(string_7))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.GetCookieFromChrome(" + string_7 + ")");
			}
			return text;
		}

		public int method_62(string string_7, bool bool_7 = true)
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.ExecuteScript("window.open('" + string_7 + "', '_blank').focus();");
				if (bool_7)
				{
					chrome.SwitchTo().Window(chrome.WindowHandles.Last());
				}
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.OpenNewTab({string_7},{bool_7})");
				return 0;
			}
		}

		public int method_63()
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.Close();
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.CloseCurrentTab()");
				return 0;
			}
		}

		public int method_64()
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.SwitchTo().Window(chrome.WindowHandles.First());
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.SwitchToFirstTab()");
				return 0;
			}
		}

		public int method_65()
		{
			if (!method_2())
			{
				return -2;
			}
			try
			{
				chrome.SwitchTo().Window(chrome.WindowHandles.Last());
				return 1;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, "chrome.SwitchToLastTab()");
				return 0;
			}
		}

		public void method_66(double double_0)
		{
			try
			{
				if (!method_3())
				{
					Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.DelayTime({double_0})");
			}
		}

		public static void smethod_0(Class75 class75_0, Exception exception_0, string string_7 = "")
		{
			try
			{
				if (string_7 == "chrome.Open()")
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
					if (class75_0 != null)
					{
						string contents = class75_0.method_20("var markup = document.documentElement.innerHTML;return markup;").ToString();
						class75_0.method_59("log\\images\\", text);
						File.WriteAllText("log\\html\\" + text + ".html", contents);
					}
					StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
					streamWriter.WriteLine("-----------------------------------------------------------------------------");
					streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					streamWriter.WriteLine("File: " + text);
					if (string_7 != "")
					{
						streamWriter.WriteLine("Error: " + string_7);
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
			}
			catch
			{
			}
		}

		public int method_67(int int_5, string string_7, string string_8)
		{
			bool flag = false;
			if (!method_2())
			{
				return -2;
			}
			try
			{
				switch (int_5)
				{
				case 1:
					new SelectElement(chrome.FindElementById(string_7)).SelectByValue(string_8);
					break;
				case 2:
					new SelectElement(chrome.FindElementByName(string_7)).SelectByValue(string_8);
					break;
				case 3:
					new SelectElement(chrome.FindElementByXPath(string_7)).SelectByValue(string_8);
					break;
				case 4:
					new SelectElement(chrome.FindElementByCssSelector(string_7)).SelectByValue(string_8);
					break;
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, $"chrome.Select({int_5},{string_7},{string_8})");
			}
			return flag ? 1 : 0;
		}

		internal bool method_68()
		{
			try
			{
				if (process != null)
				{
					return true;
				}
				string string_0 = "";
				for (int i = 0; i < 10; i++)
				{
					try
					{
						try
						{
							string_0 = chrome.CurrentWindowHandle;
						}
						catch
						{
							string_0 = Common.smethod_78(15, random_0);
						}
						if (string_0 != "")
						{
							for (int j = 0; j < 30; j++)
							{
								chrome.ExecuteScript("document.title='" + string_0 + "'");
								method_66(1.0);
								process = (from process_0 in Process.GetProcessesByName("chrome")
									where process_0.MainWindowTitle.Contains(string_0)
									select process_0).FirstOrDefault();
								if (process != null)
								{
									return true;
								}
							}
						}
					}
					catch
					{
					}
					method_66(1.0);
				}
			}
			catch
			{
			}
			return false;
		}

		public string method_69(double double_0 = 0.0, params string[] string_7)
		{
			int num = 0;
			if (!method_2())
			{
				return "-2";
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", string_7) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num == 0)
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						break;
					}
					return string_7[num - 1];
				}
			}
			catch (Exception exception_)
			{
				smethod_0(null, exception_, string.Format("chrome.CheckExistElementsv2({0},{1})", double_0, string.Join("|", string_7)));
			}
			return "";
		}
	}
}
