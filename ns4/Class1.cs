namespace ns4
{
	internal class Class1
	{
		public static string string_0 = "shell am start -W -a android.intent.action.VIEW -d \"{0}\" {1}";

		public static string string_1 = "shell am start -n {0}";

		public static string string_2 = "shell settings put global http_proxy {0}";

		public static string string_3 = "shell settings put global http_proxy :0";

		public static string string_4 = "shell settings delete global http_proxy";

		public static string string_5 = "shell settings delete global global_http_proxy_host";

		public static string string_6 = "shell settings delete global global_http_proxy_port";

		public static string string_7 = "shell curl {0}";

		public static string string_8 = "shell screencap -p \"{0}\"";

		public static string string_9 = "shell pm clear {0}";

		public static string string_10 = "push \"{0}\" \"{1}\"";

		public static string string_11 = "pull \"{0}\" \"{1}\"";

		public static string string_12 = "shell rm \"{0}\"";

		public static string string_13 = "shell rm -r \"{0}\"";

		public static string string_14 = "shell uiautomator dump {0}";

		public static string string_15 = "shell cat {0}";

		public static string string_16 = "shell am start -t \"text/vcard\" -d \"file://{0}\" -a android.intent.action.VIEW com.android.contacts";

		public static string string_17 = "shell tar -cvzf {0} {1}";

		public static string string_18 = "shell tar -xvzf {0} -C /";

		public static string string_19 = "shell input touchscreen swipe {0} {1} {2} {3} {4}";

		public static string string_20 = "shell input keyevent {0}";

		public static string string_21 = "shell input text \"{0}\"";

		public static string string_22 = "shell input tap {0} {1}";

		public static string string_23 = "shell ime set com.android.adbkeyboard/.AdbIME";

		public static string string_24 = "shell ime set com.android.inputmethod.pinyin/.InputService";

		public static string string_25 = "shell \"dumpsys window windows | grep -E 'mCurrentFocus'\"";

		public static string string_26 = "shell monkey -p {0} -c android.intent.category.LAUNCHER 1";

		public static string string_27 = "shell am force-stop {0}";

		public static string string_28 = "install {0}";

		public static string string_29 = "uninstall {0}";

		public static string string_30 = "shell pm list packages";

		public static string string_31 = "shell pm list packages -3\" | cut - f 2 -d \":";
	}
}
