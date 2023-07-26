using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using KAutoHelper;

namespace ToolRegFB
{
	internal class AutoControl
	{
		public delegate bool Delegate0(IntPtr hwnd, IntPtr lParam);

		private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);

		[Flags]
		public enum Enum0 : uint
		{
			flag_0 = 0x2u,
			flag_1 = 0x4u,
			flag_2 = 0x20u,
			flag_3 = 0x40u,
			flag_4 = 0x1u,
			flag_5 = 0x8000u,
			flag_6 = 0x8u,
			flag_7 = 0x10u,
			flag_8 = 0x800u,
			flag_9 = 0x80u,
			flag_10 = 0x100u,
			flag_11 = 0x1u,
			flag_12 = 0x2u
		}

		[CompilerGenerated]
		private sealed class Class5
		{
			public string string_0;

			public string string_1;

			internal bool method_0(IntPtr intptr_0)
			{
				string text = smethod_46(intptr_0);
				string text2 = smethod_45(intptr_0);
				return text == string_0 || text2 == string_1;
			}
		}

		[CompilerGenerated]
		private sealed class Class6
		{
			public string string_0;

			public string string_1;

			internal bool method_0(IntPtr intptr_0)
			{
				string text = smethod_46(intptr_0);
				string text2 = smethod_45(intptr_0);
				return text == string_0 || text2 == string_1;
			}
		}

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string string_0, string string_1);

		[DllImport("User32.dll")]
		public static extern bool EnumChildWindows(IntPtr intptr_0, Delegate0 delegate0_0, IntPtr intptr_1);

		[DllImport("User32.dll")]
		public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

		[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
		private static extern IntPtr FindWindow_1(IntPtr intptr_0, string string_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern IntPtr SendMessage_1(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern IntPtr SendMessage_2(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern IntPtr SendMessage_3(IntPtr intptr_0, int int_0, IntPtr intptr_1, string string_0);

		[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
		public static extern int SendMessage_4(IntPtr intptr_0, int int_0, int int_1, string string_0);

		[DllImport("user32.dll")]
		private static extern IntPtr GetDlgItem(IntPtr intptr_0, int int_0);

		[DllImport("user32.dll")]
		private static extern bool SetDlgItemTextA(IntPtr intptr_0, int int_0, string string_0);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

		[DllImport("user32.dll", EntryPoint = "PostMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage_1(IntPtr intptr_0, int int_0, IntPtr intptr_1, string string_0);

		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr intptr_0);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr intptr_0, ref RECT rect_0);

		[DllImport("user32", EntryPoint = "EnumChildWindows")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumChildWindows_1(IntPtr intptr_0, EnumWindowProc enumWindowProc_0, IntPtr intptr_1);

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint uint_0, int int_0, int int_1, int int_2, UIntPtr uintptr_0);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint SendInput(uint uint_0, INPUT[] input_0, int int_0);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsWindowVisible(IntPtr intptr_0);

		public static IntPtr smethod_0(string string_0, string string_1 = null)
		{
			IntPtr intPtr = FindWindow(string_0, string_1);
			SetForegroundWindow(intPtr);
			return intPtr;
		}

			public static IntPtr smethod_1(IntPtr intptr_0)
			{
				SetForegroundWindow(intptr_0);
				return intptr_0;
			}

		public static bool smethod_2(IntPtr intptr_0)
		{
			return IsWindowVisible(intptr_0);
		}

		public static IntPtr smethod_3(string string_0, string string_1)
		{
			return FindWindow(string_0, string_1);
		}

		public static List<IntPtr> smethod_4(string string_0, string string_1, int int_0 = 1)
		{
			Process[] processes = Process.GetProcesses();
			List<IntPtr> list = new List<IntPtr>();
			int num = 0;
			foreach (Process item in processes.Where((Process process_0) => process_0.MainWindowHandle != IntPtr.Zero))
			{
				IntPtr mainWindowHandle = item.MainWindowHandle;
				string text = smethod_46(mainWindowHandle);
				string text2 = smethod_45(mainWindowHandle);
				if (text == string_0 || text2 == string_1)
				{
					list.Add(mainWindowHandle);
					if (num >= int_0)
					{
						break;
					}
					num++;
				}
			}
			return list;
		}

		public static IntPtr smethod_5(string string_0, string string_1)
		{
			Process[] processes = Process.GetProcesses();
			IntPtr result = IntPtr.Zero;
			foreach (Process item in processes.Where((Process process_0) => process_0.MainWindowHandle != IntPtr.Zero))
			{
				IntPtr mainWindowHandle = item.MainWindowHandle;
				string text = smethod_46(mainWindowHandle);
				string text2 = smethod_45(mainWindowHandle);
				if (text == string_0 || text2 == string_1)
				{
					result = mainWindowHandle;
					break;
				}
			}
			return result;
		}

		public static IntPtr smethod_6(IntPtr intptr_0, string string_0, string string_1)
		{
			return FindWindowEx(intptr_0, IntPtr.Zero, string_1, string_0);
		}

		private static IntPtr smethod_7(IntPtr intptr_0, int int_0)
		{
			if (int_0 == 0)
			{
				return intptr_0;
			}
			int num = 0;
			IntPtr intPtr = IntPtr.Zero;
			do
			{
				intPtr = FindWindowEx(intptr_0, intPtr, "Button", null);
				if (intPtr != IntPtr.Zero)
				{
					num++;
				}
			}
			while (num < int_0 && intPtr != IntPtr.Zero);
			return intPtr;
		}

		public static IntPtr smethod_8(IntPtr intptr_0, int int_0)
		{
			return GetDlgItem(intptr_0, int_0);
		}

		public static List<IntPtr> smethod_9(IntPtr intptr_0)
		{
			List<IntPtr> list = new List<IntPtr>();
			GCHandle value = GCHandle.Alloc(list);
			IntPtr intptr_2 = GCHandle.ToIntPtr(value);
			try
			{
				EnumWindowProc enumWindowProc_ = delegate(IntPtr intptr_0, IntPtr intptr_1)
				{
					GCHandle gCHandle = GCHandle.FromIntPtr(intptr_1);
					if (gCHandle.Target == null)
					{
						return false;
					}
					List<IntPtr> list2 = gCHandle.Target as List<IntPtr>;
					list2.Add(intptr_0);
					return true;
				};
				EnumChildWindows_1(intptr_0, enumWindowProc_, intptr_2);
			}
			finally
			{
				value.Free();
			}
			return list;
		}

		public static IntPtr smethod_10(List<IntPtr> list_0, string string_0, string string_1)
		{
			return list_0.Find(delegate(IntPtr intptr_0)
			{
				string text = smethod_46(intptr_0);
				string text2 = smethod_45(intptr_0);
				return text == string_0 || text2 == string_1;
			});
		}

		public static List<IntPtr> smethod_11(List<IntPtr> list_0, string string_0, string string_1)
		{
			new List<IntPtr>();
			IEnumerable<IntPtr> source = list_0.Where(delegate(IntPtr intptr_0)
			{
				string text = smethod_46(intptr_0);
				string text2 = smethod_45(intptr_0);
				return text == string_0 || text2 == string_1;
			});
			return source.ToList();
		}

		public static IntPtr smethod_12(IntPtr intptr_0, string string_0, string string_1)
		{
			return smethod_10(smethod_9(intptr_0), string_0, string_1);
		}

		public static List<IntPtr> smethod_13(IntPtr intptr_0, string string_0, string string_1)
		{
			return smethod_11(smethod_9(intptr_0), string_0, string_1);
		}

		public static bool smethod_14(IntPtr intptr_0, IntPtr intptr_1)
		{
			string text = smethod_45(intptr_0);
			string text2 = smethod_46(intptr_0);
			if (text == "&Options >>" && text2.StartsWith("ToolbarWindow32"))
			{
				SendMessage_2(intptr_0, 0, IntPtr.Zero, IntPtr.Zero);
				return false;
			}
			return true;
		}

		public static void smethod_15(IntPtr intptr_0, int int_0)
		{
			IntPtr dlgItem = GetDlgItem(intptr_0, int_0);
			int int_ = 0 | (int_0 & 0xFFFF);
			SendMessage_1(intptr_0, 273, int_, dlgItem);
		}

		public static void smethod_16(IntPtr intptr_0)
		{
			SendMessage_2(intptr_0, 513, IntPtr.Zero, IntPtr.Zero);
			SendMessage_2(intptr_0, 514, IntPtr.Zero, IntPtr.Zero);
		}

		public static void smethod_17(IntPtr intptr_0, int int_0, int int_1, EMouseKey emouseKey_0 = EMouseKey.LEFT, int int_2 = 1)
		{
			int int_3 = 0;
			int int_4 = 0;
			if (emouseKey_0 == EMouseKey.LEFT)
			{
				int_3 = 513;
				int_4 = 514;
			}
			if (emouseKey_0 == EMouseKey.RIGHT)
			{
				int_3 = 516;
				int_4 = 517;
			}
			IntPtr intptr_ = smethod_48(int_0, int_1);
			if (emouseKey_0 == EMouseKey.LEFT || emouseKey_0 == EMouseKey.RIGHT)
			{
				for (int i = 0; i < int_2; i++)
				{
					PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
					PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
					PostMessage(intptr_0, int_4, new IntPtr(0), intptr_);
				}
				return;
			}
			if (emouseKey_0 == EMouseKey.DOUBLE_LEFT)
			{
				int_3 = 515;
				int_4 = 514;
			}
			if (emouseKey_0 == EMouseKey.DOUBLE_RIGHT)
			{
				int_3 = 518;
				int_4 = 517;
			}
			PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
			PostMessage(intptr_0, int_4, new IntPtr(0), intptr_);
		}

		public static void smethod_18(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, int int_4 = 10, int int_5 = 10, double double_0 = 0.05)
		{
			int int_6 = 513;
			int int_7 = 514;
			IntPtr intptr_ = smethod_48(int_0, int_1);
			IntPtr intptr_2 = smethod_48(int_2, int_3);
			if (int_2 < int_0)
			{
				int_4 *= -1;
			}
			if (int_3 < int_1)
			{
				int_5 *= -1;
			}
			PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
			PostMessage(intptr_0, int_6, new IntPtr(1), intptr_);
			bool flag = false;
			bool flag2 = false;
			while (true)
			{
				PostMessage(intptr_0, 512, new IntPtr(1), smethod_48(int_0, int_1));
				if (int_4 > 0)
				{
					if (int_0 < int_2)
					{
						int_0 += int_4;
					}
					else
					{
						flag = true;
					}
				}
				else if (int_0 > int_2)
				{
					int_0 += int_4;
				}
				else
				{
					flag = true;
				}
				if (int_5 > 0)
				{
					if (int_1 < int_3)
					{
						int_1 += int_5;
					}
					else
					{
						flag2 = true;
					}
				}
				else if (int_1 > int_3)
				{
					int_1 += int_5;
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					break;
				}
				Thread.Sleep(TimeSpan.FromSeconds(double_0));
			}
			PostMessage(intptr_0, int_7, new IntPtr(0), intptr_2);
		}

		public static void smethod_19(IntPtr intptr_0, int int_0, int int_1, EMouseKey emouseKey_0 = EMouseKey.LEFT, int int_2 = 1)
		{
			int int_3 = 0;
			if (emouseKey_0 == EMouseKey.LEFT)
			{
				int_3 = 513;
			}
			if (emouseKey_0 == EMouseKey.RIGHT)
			{
				int_3 = 516;
			}
			IntPtr intptr_ = smethod_48(int_0, int_1);
			for (int i = 0; i < int_2; i++)
			{
				PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
				PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
			}
		}

		public static void smethod_20(IntPtr intptr_0, int int_0, int int_1, EMouseKey emouseKey_0 = EMouseKey.LEFT, int int_2 = 1)
		{
			int int_3 = 0;
			if (emouseKey_0 == EMouseKey.LEFT)
			{
				int_3 = 514;
			}
			if (emouseKey_0 == EMouseKey.RIGHT)
			{
				int_3 = 517;
			}
			IntPtr intptr_ = smethod_48(int_0, int_1);
			for (int i = 0; i < int_2; i++)
			{
				PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
				SendMessage_2(intptr_0, int_3, new IntPtr(0), intptr_);
			}
		}

		public static void smethod_21(IntPtr intptr_0, string string_0)
		{
			SendMessage_4(intptr_0, 12, 0, string_0);
		}

		public static void smethod_22(IntPtr intptr_0, VKeys vkeys_0)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
			PostMessage(intptr_0, 256, new IntPtr((int)vkeys_0), new IntPtr(1));
			PostMessage(intptr_0, 257, new IntPtr((int)vkeys_0), new IntPtr(0));
		}

		public static void smethod_23(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
		{
			string text = string_0.ToLower();
			string text2 = text;
			foreach (char c in text2)
			{
				VKeys vkeys_ = VKeys.VK_0;
				char c2 = c;
				switch (c2)
				{
				default:
					switch (c2)
					{
					case 'a':
						vkeys_ = VKeys.VK_A;
						break;
					case 'b':
						vkeys_ = VKeys.VK_B;
						break;
					case 'c':
						vkeys_ = VKeys.VK_V;
						break;
					case 'd':
						vkeys_ = VKeys.VK_D;
						break;
					case 'e':
						vkeys_ = VKeys.VK_E;
						break;
					case 'f':
						vkeys_ = VKeys.VK_F;
						break;
					case 'g':
						vkeys_ = VKeys.VK_G;
						break;
					case 'h':
						vkeys_ = VKeys.VK_H;
						break;
					case 'i':
						vkeys_ = VKeys.VK_I;
						break;
					case 'j':
						vkeys_ = VKeys.VK_J;
						break;
					case 'k':
						vkeys_ = VKeys.VK_K;
						break;
					case 'l':
						vkeys_ = VKeys.VK_L;
						break;
					case 'm':
						vkeys_ = VKeys.VK_M;
						break;
					case 'n':
						vkeys_ = VKeys.VK_N;
						break;
					case 'o':
						vkeys_ = VKeys.VK_O;
						break;
					case 'p':
						vkeys_ = VKeys.VK_P;
						break;
					case 'q':
						vkeys_ = VKeys.VK_Q;
						break;
					case 'r':
						vkeys_ = VKeys.VK_R;
						break;
					case 's':
						vkeys_ = VKeys.VK_S;
						break;
					case 't':
						vkeys_ = VKeys.VK_T;
						break;
					case 'u':
						vkeys_ = VKeys.VK_U;
						break;
					case 'v':
						vkeys_ = VKeys.VK_V;
						break;
					case 'w':
						vkeys_ = VKeys.VK_W;
						break;
					case 'x':
						vkeys_ = VKeys.VK_X;
						break;
					case 'y':
						vkeys_ = VKeys.VK_Y;
						break;
					case 'z':
						vkeys_ = VKeys.VK_Z;
						break;
					}
					break;
				case '0':
					vkeys_ = VKeys.VK_0;
					break;
				case '1':
					vkeys_ = VKeys.VK_1;
					break;
				case '2':
					vkeys_ = VKeys.VK_2;
					break;
				case '3':
					vkeys_ = VKeys.VK_3;
					break;
				case '4':
					vkeys_ = VKeys.VK_4;
					break;
				case '5':
					vkeys_ = VKeys.VK_5;
					break;
				case '6':
					vkeys_ = VKeys.VK_6;
					break;
				case '7':
					vkeys_ = VKeys.VK_7;
					break;
				case '8':
					vkeys_ = VKeys.VK_8;
					break;
				case '9':
					vkeys_ = VKeys.VK_9;
					break;
				}
				smethod_22(intptr_0, vkeys_);
				Thread.Sleep(TimeSpan.FromSeconds(float_0));
			}
		}

		public static void smethod_24(IntPtr intptr_0, VKeys vkeys_0)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
			PostMessage(intptr_0, 257, new IntPtr((int)vkeys_0), new IntPtr(0));
		}

		public static void smethod_25(IntPtr intptr_0, VKeys vkeys_0)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
			PostMessage(intptr_0, 258, new IntPtr((int)vkeys_0), new IntPtr(0));
		}

		public static void smethod_26(IntPtr intptr_0, int int_0)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
			PostMessage(intptr_0, 258, new IntPtr(int_0), new IntPtr(0));
		}

		public static void smethod_27(IntPtr intptr_0, VKeys vkeys_0)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
			PostMessage(intptr_0, 256, new IntPtr((int)vkeys_0), new IntPtr(0));
		}

		public static void smethod_28(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
		{
			string text = string_0.ToLower();
			string text2 = text;
			foreach (char int_ in text2)
			{
				smethod_26(intptr_0, int_);
			}
		}

		public static void smethod_29(KeyCode keyCode_0)
		{
			smethod_32(keyCode_0);
		}

		public static void smethod_30(KeyCode[] keyCode_0)
		{
			foreach (KeyCode keyCode_ in keyCode_0)
			{
				smethod_34(keyCode_);
			}
			foreach (KeyCode keyCode_2 in keyCode_0)
			{
				smethod_35(keyCode_2);
			}
		}

		public static void smethod_31(string string_0)
		{
			Clipboard.SetText(string_0);
			smethod_30(new KeyCode[2]
			{
				KeyCode.CONTROL,
				KeyCode.KEY_V
			});
		}

		public static void smethod_32(KeyCode keyCode_0)
		{
			INPUT iNPUT = default(INPUT);
			iNPUT.Type = 1u;
			INPUT iNPUT2 = iNPUT;
			ref MOUSEKEYBDHARDWAREINPUT data = ref iNPUT2.Data;
			KEYBDINPUT keyboard = default(KEYBDINPUT);
			keyboard.Vk = (ushort)keyCode_0;
			keyboard.Scan = 0;
			keyboard.Flags = 0u;
			keyboard.Time = 0u;
			keyboard.ExtraInfo = IntPtr.Zero;
			KEYBDINPUT kEYBDINPUT = (data.Keyboard = keyboard);
			iNPUT = default(INPUT);
			iNPUT.Type = 1u;
			INPUT iNPUT3 = iNPUT;
			ref MOUSEKEYBDHARDWAREINPUT data2 = ref iNPUT3.Data;
			keyboard = default(KEYBDINPUT);
			keyboard.Vk = (ushort)keyCode_0;
			keyboard.Scan = 0;
			keyboard.Flags = 2u;
			keyboard.Time = 0u;
			keyboard.ExtraInfo = IntPtr.Zero;
			kEYBDINPUT = (data2.Keyboard = keyboard);
			INPUT[] input_ = new INPUT[2] { iNPUT2, iNPUT3 };
			if (SendInput(2u, input_, Marshal.SizeOf(typeof(INPUT))) == 0)
			{
				throw new Exception();
			}
		}

		public static void smethod_33(string string_0, double double_0 = 0.5)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				switch (string_0[i])
				{
				case '0':
					smethod_32(KeyCode.KEY_0);
					break;
				case '1':
					smethod_32(KeyCode.KEY_1);
					break;
				case '2':
					smethod_32(KeyCode.KEY_2);
					break;
				case '3':
					smethod_32(KeyCode.KEY_3);
					break;
				case '4':
					smethod_32(KeyCode.KEY_4);
					break;
				case '5':
					smethod_32(KeyCode.KEY_5);
					break;
				case '6':
					smethod_32(KeyCode.KEY_6);
					break;
				case '7':
					smethod_32(KeyCode.KEY_7);
					break;
				case '8':
					smethod_32(KeyCode.KEY_8);
					break;
				case '9':
					smethod_32(KeyCode.KEY_9);
					break;
				}
				Thread.Sleep(TimeSpan.FromSeconds(double_0));
			}
		}

		public static void smethod_34(KeyCode keyCode_0)
		{
			INPUT iNPUT = default(INPUT);
			iNPUT.Type = 1u;
			INPUT iNPUT2 = iNPUT;
			iNPUT2.Data.Keyboard = default(KEYBDINPUT);
			iNPUT2.Data.Keyboard.Vk = (ushort)keyCode_0;
			iNPUT2.Data.Keyboard.Scan = 0;
			iNPUT2.Data.Keyboard.Flags = 0u;
			iNPUT2.Data.Keyboard.Time = 0u;
			iNPUT2.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			INPUT[] input_ = new INPUT[1] { iNPUT2 };
			if (SendInput(1u, input_, Marshal.SizeOf(typeof(INPUT))) == 0)
			{
				throw new Exception();
			}
		}

		public static void smethod_35(KeyCode keyCode_0)
		{
			INPUT iNPUT = default(INPUT);
			iNPUT.Type = 1u;
			INPUT iNPUT2 = iNPUT;
			iNPUT2.Data.Keyboard = default(KEYBDINPUT);
			iNPUT2.Data.Keyboard.Vk = (ushort)keyCode_0;
			iNPUT2.Data.Keyboard.Scan = 0;
			iNPUT2.Data.Keyboard.Flags = 2u;
			iNPUT2.Data.Keyboard.Time = 0u;
			iNPUT2.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			INPUT[] input_ = new INPUT[1] { iNPUT2 };
			if (SendInput(1u, input_, Marshal.SizeOf(typeof(INPUT))) == 0)
			{
				throw new Exception();
			}
		}

		public static void smethod_36(int int_0, int int_1, EMouseKey emouseKey_0 = EMouseKey.LEFT)
		{
			Cursor.Position = new Point(int_0, int_1);
			smethod_41(emouseKey_0);
		}

		public static void smethod_37(Point point_0, int int_0, bool bool_0 = false)
		{
			Cursor.Position = point_0;
			mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
			for (int i = 0; i < int_0; i++)
			{
				if (!bool_0)
				{
					mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
				}
				else
				{
					mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
				}
			}
			mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
		}

		public static void smethod_38(Point point_0, int int_0, bool bool_0 = false)
		{
			Cursor.Position = point_0;
			mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
			for (int i = 0; i < int_0; i++)
			{
				if (!bool_0)
				{
					mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
				}
				else
				{
					mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
				}
			}
			mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
		}

		public static void smethod_39(Point point_0, int int_0, bool bool_0 = false)
		{
			Cursor.Position = point_0;
			mouse_event(2048u, 0, 0, int_0, UIntPtr.Zero);
		}

		public static void smethod_40(Point point_0, EMouseKey emouseKey_0 = EMouseKey.LEFT)
		{
			Cursor.Position = point_0;
			smethod_41(emouseKey_0);
		}

		public static void smethod_41(EMouseKey emouseKey_0 = EMouseKey.LEFT)
		{
			switch (emouseKey_0)
			{
			case EMouseKey.LEFT:
				mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.RIGHT:
				mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.DOUBLE_LEFT:
				mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
				mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
				break;
			case EMouseKey.DOUBLE_RIGHT:
				mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
				mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
				break;
			}
		}

		public static RECT smethod_42(IntPtr intptr_0)
		{
			RECT rect_ = default(RECT);
			GetWindowRect(intptr_0, ref rect_);
			return rect_;
		}

		public static Point smethod_43(IntPtr intptr_0, Point? nullable_0 = null)
		{
			Point result = default(Point);
			RECT rECT = smethod_42(intptr_0);
			if (!nullable_0.HasValue)
			{
				nullable_0 = default(Point);
			}
			result.X = nullable_0.Value.X + rECT.Left;
			result.Y = nullable_0.Value.Y + rECT.Top;
			return result;
		}

		public static Point smethod_44(IntPtr intptr_0, int int_0 = 0, int int_1 = 0)
		{
			Point result = default(Point);
			RECT rECT = smethod_42(intptr_0);
			result.X = int_0 + rECT.Left;
			result.Y = int_1 + rECT.Top;
			return result;
		}

		public static string smethod_45(IntPtr intptr_0)
		{	
			StringBuilder stringBuilder = new StringBuilder(256);
			GetWindowText(intptr_0, stringBuilder, 256);
			return stringBuilder.ToString().Trim();
		}

		public static string smethod_46(IntPtr intptr_0)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			GetClassName(intptr_0, stringBuilder, 256);
			return stringBuilder.ToString().Trim();
		}

		public static IntPtr smethod_47(int int_0, int int_1)
		{
			return (IntPtr)((int_1 << 16) | (int_0 & 0xFFFF));
		}

		public static IntPtr smethod_48(int int_0, int int_1)
		{
			return (IntPtr)((int_1 << 16) | int_0);
		}
	}
}
