using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ToolRegFB.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => settings_0;

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Memory")]
		public string Memory
		{
			get
			{
				return (string)this["Memory"];
			}
			set
			{
				this["Memory"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string userLogin
		{
			get
			{
				return (string)this["userLogin"];
			}
			set
			{
				this["userLogin"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string PassLogin
		{
			get
			{
				return (string)this["PassLogin"];
			}
			set
			{
				this["PassLogin"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isRememe
		{
			get
			{
				return (bool)this["isRememe"];
			}
			set
			{
				this["isRememe"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isAutoClearLD
		{
			get
			{
				return (bool)this["isAutoClearLD"];
			}
			set
			{
				this["isAutoClearLD"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isOnGPSLD
		{
			get
			{
				return (bool)this["isOnGPSLD"];
			}
			set
			{
				this["isOnGPSLD"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1 cores (Khuyến nghị)")]
		public string CpuLD
		{
			get
			{
				return (string)this["CpuLD"];
			}
			set
			{
				this["CpuLD"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1024M (Khuyến nghị)")]
		public string RamLD
		{
			get
			{
				return (string)this["RamLD"];
			}
			set
			{
				this["RamLD"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("320")]
		public int SizeLDFrom
		{
			get
			{
				return (int)this["SizeLDFrom"];
			}
			set
			{
				this["SizeLDFrom"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("480")]
		public int SizeLDTo
		{
			get
			{
				return (int)this["SizeLDTo"];
			}
			set
			{
				this["SizeLDTo"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("120")]
		public int DPILD
		{
			get
			{
				return (int)this["DPILD"];
			}
			set
			{
				this["DPILD"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isAdbDebug
		{
			get
			{
				return (bool)this["isAdbDebug"];
			}
			set
			{
				this["isAdbDebug"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isDongBoDB
		{
			get
			{
				return (bool)this["isDongBoDB"];
			}
			set
			{
				this["isDongBoDB"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isAddMailReg
		{
			get
			{
				return (bool)this["isAddMailReg"];
			}
			set
			{
				this["isAddMailReg"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isVeriPhoneNoveri
		{
			get
			{
				return (bool)this["isVeriPhoneNoveri"];
			}
			set
			{
				this["isVeriPhoneNoveri"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isVeriMailNoveri
		{
			get
			{
				return (bool)this["isVeriMailNoveri"];
			}
			set
			{
				this["isVeriMailNoveri"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isThuVeriCheckPoint
		{
			get
			{
				return (bool)this["isThuVeriCheckPoint"];
			}
			set
			{
				this["isThuVeriCheckPoint"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string PathChrome
		{
			get
			{
				return (string)this["PathChrome"];
			}
			set
			{
				this["PathChrome"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int typeRunApp
		{
			get
			{
				return (int)this["typeRunApp"];
			}
			set
			{
				this["typeRunApp"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isCheckUID
		{
			get
			{
				return (bool)this["isCheckUID"];
			}
			set
			{
				this["isCheckUID"] = value;
			}
		}
	}
}
