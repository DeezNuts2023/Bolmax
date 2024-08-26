using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using csgobolwall.Properties;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x02000002 RID: 2
public partial class Form1 : Form
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002080 File Offset: 0x00000280
	public Form1()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002520 File Offset: 0x00000720
	public static string smethod_0()
	{
		string text = "";
		string result;
		try
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard").Get())
			{
				text = ((ManagementObject)managementBaseObject)["SerialNumber"].ToString();
			}
			result = text;
		}
		catch (Exception)
		{
			result = text;
		}
		return result;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000025A0 File Offset: 0x000007A0
	private static string smethod_1(string string_3 = "C")
	{
		if (!string.IsNullOrEmpty(string_3) && string_3.EndsWith(":\\"))
		{
			string_3 = string_3.Substring(0, string_3.Length - 2);
		}
		ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_3 + ":\"");
		managementObject.Get();
		string result = managementObject["VolumeSerialNumber"].ToString();
		managementObject.Dispose();
		return result;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002608 File Offset: 0x00000808
	private static string smethod_2(string string_3)
	{
		string result;
		using (MD5 md = MD5.Create())
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_3);
			byte[] array = md.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002688 File Offset: 0x00000888
	public static string smethod_3()
	{
		string text = "";
		try
		{
			text = Form1.smethod_2(Form1.smethod_0() + Form1.smethod_1("C") + Environment.MachineName + Environment.UserName);
		}
		catch (Exception)
		{
			text = Form1.smethod_2(Environment.MachineName + Environment.UserName);
			text = "PPP" + text.Substring(3);
		}
		return text;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000026FC File Offset: 0x000008FC
	private static string smethod_4()
	{
		object obj = (from ManagementObject x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
		select x.GetPropertyValue("Caption")).FirstOrDefault<object>();
		if (obj != null)
		{
			string text = obj.ToString();
			string result;
			if (text.Contains("XP"))
			{
				result = "Windows XP";
			}
			else if (text.Contains("Vista"))
			{
				result = "Windows Vista";
			}
			else if (text.Contains("2003"))
			{
				result = "Windows 2003 Server";
			}
			else if (text.Contains("2008"))
			{
				result = "Windows 2008 Server";
			}
			else if (text.Contains("2012"))
			{
				result = "Windows 2012 Server";
			}
			else if (text.Contains("2016"))
			{
				result = "Windows 2016 Server";
			}
			else if (text.Contains("2019"))
			{
				result = "Windows 2019 Server";
			}
			else if (text.Contains("7"))
			{
				result = "Windows 7";
			}
			else if (text.Contains("8.1"))
			{
				result = "Windows 8.1";
			}
			else if (text.Contains("8"))
			{
				result = "Windows 8";
			}
			else if (text.Contains("10"))
			{
				result = "Windows 10";
			}
			else
			{
				result = text;
			}
			return result;
		}
		return "Unknown";
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000285C File Offset: 0x00000A5C
	private static string smethod_5()
	{
		string text = Class0.smethod_0("https://raw.githubusercontent.com/hilebolonline/csgobol/master/wall/version.txt", 10000);
		if (text != "TIMEOUT" && !string.IsNullOrEmpty(text))
		{
			return text;
		}
		return "-1";
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002099 File Offset: 0x00000299
	private static void smethod_6(string string_3, string string_4)
	{
		new WebClient().DownloadFile(string_3, string_4);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002898 File Offset: 0x00000A98
	private void method_0()
	{
		try
		{
			Form1.smethod_6("https://raw.githubusercontent.com/hilebolonline/csgobol/master/wall/csgobolwallUpdater.exe", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "csgobolwallUpdater.exe"));
			Thread.Sleep(3000);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000020A7 File Offset: 0x000002A7
	private void method_1()
	{
		Process.Start("csgobolwallUpdater.exe");
		Application.Exit();
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000028E4 File Offset: 0x00000AE4
	public void method_2()
	{
		try
		{
			if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "csgobolwallUpdater.exe")))
			{
				File.Delete(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "csgobolwallUpdater.exe"));
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020B9 File Offset: 0x000002B9
	private void Form1_Load(object sender, EventArgs e)
	{
		this.mevcutSurumLabel.Text = "ver: " + Form1.string_0;
		this.timer_0.Start();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000020E0 File Offset: 0x000002E0
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.string_2 = Form1.smethod_3();
		this.method_3();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000293C File Offset: 0x00000B3C
	private void method_3()
	{
		Class0.smethod_0(string.Concat(new string[]
		{
			"https://hilebol.space/onayE/hwidcheck.php?hwid=",
			this.string_2,
			"&kayitprogram=",
			Form1.string_1,
			"&os=",
			Form1.smethod_4()
		}), 10000);
		try
		{
			object arg = new JavaScriptSerializer().Deserialize<object>(Class0.smethod_0("https://raw.githubusercontent.com/hilebolonline/csgobol/master/wall/main.json", 5000));
			string arg2 = "v" + Form1.string_0;
			if (Form1.<>o__17.<>p__3 == null)
			{
				Form1.<>o__17.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target = Form1.<>o__17.<>p__3.Target;
			CallSite <>p__ = Form1.<>o__17.<>p__3;
			if (Form1.<>o__17.<>p__2 == null)
			{
				Form1.<>o__17.<>p__2 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target2 = Form1.<>o__17.<>p__2.Target;
			CallSite <>p__2 = Form1.<>o__17.<>p__2;
			if (Form1.<>o__17.<>p__1 == null)
			{
				Form1.<>o__17.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target3 = Form1.<>o__17.<>p__1.Target;
			CallSite <>p__3 = Form1.<>o__17.<>p__1;
			if (Form1.<>o__17.<>p__0 == null)
			{
				Form1.<>o__17.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target(<>p__, target2(<>p__2, target3(<>p__3, Form1.<>o__17.<>p__0.Target(Form1.<>o__17.<>p__0, arg, "root"), "showMessage"), true)))
			{
				if (Form1.<>o__17.<>p__6 == null)
				{
					Form1.<>o__17.<>p__6 = CallSite<Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Show", null, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon> target4 = Form1.<>o__17.<>p__6.Target;
				CallSite <>p__4 = Form1.<>o__17.<>p__6;
				Type typeFromHandle = typeof(MessageBox);
				if (Form1.<>o__17.<>p__5 == null)
				{
					Form1.<>o__17.<>p__5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target5 = Form1.<>o__17.<>p__5.Target;
				CallSite <>p__5 = Form1.<>o__17.<>p__5;
				if (Form1.<>o__17.<>p__4 == null)
				{
					Form1.<>o__17.<>p__4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				target4(<>p__4, typeFromHandle, target5(<>p__5, Form1.<>o__17.<>p__4.Target(Form1.<>o__17.<>p__4, arg, "root"), "message"), "HILEBOL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				if (Form1.<>o__17.<>p__10 == null)
				{
					Form1.<>o__17.<>p__10 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target6 = Form1.<>o__17.<>p__10.Target;
				CallSite <>p__6 = Form1.<>o__17.<>p__10;
				if (Form1.<>o__17.<>p__9 == null)
				{
					Form1.<>o__17.<>p__9 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target7 = Form1.<>o__17.<>p__9.Target;
				CallSite <>p__7 = Form1.<>o__17.<>p__9;
				if (Form1.<>o__17.<>p__8 == null)
				{
					Form1.<>o__17.<>p__8 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target8 = Form1.<>o__17.<>p__8.Target;
				CallSite <>p__8 = Form1.<>o__17.<>p__8;
				if (Form1.<>o__17.<>p__7 == null)
				{
					Form1.<>o__17.<>p__7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				if (target6(<>p__6, target7(<>p__7, target8(<>p__8, Form1.<>o__17.<>p__7.Target(Form1.<>o__17.<>p__7, arg, arg2), "showMessage"), true)))
				{
					if (Form1.<>o__17.<>p__13 == null)
					{
						Form1.<>o__17.<>p__13 = CallSite<Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Show", null, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon> target9 = Form1.<>o__17.<>p__13.Target;
					CallSite <>p__9 = Form1.<>o__17.<>p__13;
					Type typeFromHandle2 = typeof(MessageBox);
					if (Form1.<>o__17.<>p__12 == null)
					{
						Form1.<>o__17.<>p__12 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target10 = Form1.<>o__17.<>p__12.Target;
					CallSite <>p__10 = Form1.<>o__17.<>p__12;
					if (Form1.<>o__17.<>p__11 == null)
					{
						Form1.<>o__17.<>p__11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					target9(<>p__9, typeFromHandle2, target10(<>p__10, Form1.<>o__17.<>p__11.Target(Form1.<>o__17.<>p__11, arg, arg2), "message"), "HILEBOL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			if (Form1.<>o__17.<>p__17 == null)
			{
				Form1.<>o__17.<>p__17 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target11 = Form1.<>o__17.<>p__17.Target;
			CallSite <>p__11 = Form1.<>o__17.<>p__17;
			if (Form1.<>o__17.<>p__16 == null)
			{
				Form1.<>o__17.<>p__16 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target12 = Form1.<>o__17.<>p__16.Target;
			CallSite <>p__12 = Form1.<>o__17.<>p__16;
			if (Form1.<>o__17.<>p__15 == null)
			{
				Form1.<>o__17.<>p__15 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target13 = Form1.<>o__17.<>p__15.Target;
			CallSite <>p__13 = Form1.<>o__17.<>p__15;
			if (Form1.<>o__17.<>p__14 == null)
			{
				Form1.<>o__17.<>p__14 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target11(<>p__11, target12(<>p__12, target13(<>p__13, Form1.<>o__17.<>p__14.Target(Form1.<>o__17.<>p__14, arg, "root"), "openURL"), true)))
			{
				if (Form1.<>o__17.<>p__20 == null)
				{
					Form1.<>o__17.<>p__20 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Start", null, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, Type, object> target14 = Form1.<>o__17.<>p__20.Target;
				CallSite <>p__14 = Form1.<>o__17.<>p__20;
				Type typeFromHandle3 = typeof(Process);
				if (Form1.<>o__17.<>p__19 == null)
				{
					Form1.<>o__17.<>p__19 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target15 = Form1.<>o__17.<>p__19.Target;
				CallSite <>p__15 = Form1.<>o__17.<>p__19;
				if (Form1.<>o__17.<>p__18 == null)
				{
					Form1.<>o__17.<>p__18 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				target14(<>p__14, typeFromHandle3, target15(<>p__15, Form1.<>o__17.<>p__18.Target(Form1.<>o__17.<>p__18, arg, "root"), "URL"));
			}
			else
			{
				if (Form1.<>o__17.<>p__24 == null)
				{
					Form1.<>o__17.<>p__24 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target16 = Form1.<>o__17.<>p__24.Target;
				CallSite <>p__16 = Form1.<>o__17.<>p__24;
				if (Form1.<>o__17.<>p__23 == null)
				{
					Form1.<>o__17.<>p__23 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target17 = Form1.<>o__17.<>p__23.Target;
				CallSite <>p__17 = Form1.<>o__17.<>p__23;
				if (Form1.<>o__17.<>p__22 == null)
				{
					Form1.<>o__17.<>p__22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target18 = Form1.<>o__17.<>p__22.Target;
				CallSite <>p__18 = Form1.<>o__17.<>p__22;
				if (Form1.<>o__17.<>p__21 == null)
				{
					Form1.<>o__17.<>p__21 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				if (target16(<>p__16, target17(<>p__17, target18(<>p__18, Form1.<>o__17.<>p__21.Target(Form1.<>o__17.<>p__21, arg, arg2), "openURL"), true)))
				{
					if (Form1.<>o__17.<>p__27 == null)
					{
						Form1.<>o__17.<>p__27 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Start", null, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Type, object> target19 = Form1.<>o__17.<>p__27.Target;
					CallSite <>p__19 = Form1.<>o__17.<>p__27;
					Type typeFromHandle4 = typeof(Process);
					if (Form1.<>o__17.<>p__26 == null)
					{
						Form1.<>o__17.<>p__26 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target20 = Form1.<>o__17.<>p__26.Target;
					CallSite <>p__20 = Form1.<>o__17.<>p__26;
					if (Form1.<>o__17.<>p__25 == null)
					{
						Form1.<>o__17.<>p__25 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					target19(<>p__19, typeFromHandle4, target20(<>p__20, Form1.<>o__17.<>p__25.Target(Form1.<>o__17.<>p__25, arg, arg2), "URL"));
				}
			}
			if (Form1.<>o__17.<>p__31 == null)
			{
				Form1.<>o__17.<>p__31 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target21 = Form1.<>o__17.<>p__31.Target;
			CallSite <>p__21 = Form1.<>o__17.<>p__31;
			if (Form1.<>o__17.<>p__30 == null)
			{
				Form1.<>o__17.<>p__30 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target22 = Form1.<>o__17.<>p__30.Target;
			CallSite <>p__22 = Form1.<>o__17.<>p__30;
			if (Form1.<>o__17.<>p__29 == null)
			{
				Form1.<>o__17.<>p__29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target23 = Form1.<>o__17.<>p__29.Target;
			CallSite <>p__23 = Form1.<>o__17.<>p__29;
			if (Form1.<>o__17.<>p__28 == null)
			{
				Form1.<>o__17.<>p__28 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target21(<>p__21, target22(<>p__22, target23(<>p__23, Form1.<>o__17.<>p__28.Target(Form1.<>o__17.<>p__28, arg, "root"), "ProgramIsActive"), false)))
			{
				Application.Exit();
			}
			else
			{
				if (Form1.<>o__17.<>p__35 == null)
				{
					Form1.<>o__17.<>p__35 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target24 = Form1.<>o__17.<>p__35.Target;
				CallSite <>p__24 = Form1.<>o__17.<>p__35;
				if (Form1.<>o__17.<>p__34 == null)
				{
					Form1.<>o__17.<>p__34 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target25 = Form1.<>o__17.<>p__34.Target;
				CallSite <>p__25 = Form1.<>o__17.<>p__34;
				if (Form1.<>o__17.<>p__33 == null)
				{
					Form1.<>o__17.<>p__33 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target26 = Form1.<>o__17.<>p__33.Target;
				CallSite <>p__26 = Form1.<>o__17.<>p__33;
				if (Form1.<>o__17.<>p__32 == null)
				{
					Form1.<>o__17.<>p__32 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				if (target24(<>p__24, target25(<>p__25, target26(<>p__26, Form1.<>o__17.<>p__32.Target(Form1.<>o__17.<>p__32, arg, arg2), "ProgramIsActive"), false)))
				{
					Application.Exit();
				}
			}
		}
		catch (Exception)
		{
		}
		string text = Form1.smethod_5();
		if (!(text != "TIMEOUT") || string.IsNullOrEmpty(text))
		{
			Application.Exit();
			return;
		}
		if (text == Form1.string_0)
		{
			this.method_2();
			this.timer_1.Start();
			return;
		}
		this.method_0();
		this.method_1();
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020FE File Offset: 0x000002FE
	private void exitLabel_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00003650 File Offset: 0x00001850
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (this.dotdot.Text.Length <= 1)
		{
			this.timer_1.Stop();
			Form1.form3_0.Show();
			base.Hide();
			return;
		}
		this.dotdot.Text = this.dotdot.Text.Substring(1, this.dotdot.Text.Length - 1);
	}

	// Token: 0x04000001 RID: 1
	public static Form3 form3_0 = new Form3();

	// Token: 0x04000002 RID: 2
	public static string string_0 = "16.0.4";

	// Token: 0x04000003 RID: 3
	public static string string_1 = "csgobolwall" + Form1.string_0;

	// Token: 0x04000004 RID: 4
	public string string_2 = "";
}
