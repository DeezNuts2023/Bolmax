using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using csgobolwall.Properties;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x02000005 RID: 5
public partial class Form3 : Form
{
	// Token: 0x06000017 RID: 23 RVA: 0x0000216F File Offset: 0x0000036F
	public Form3()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00003C54 File Offset: 0x00001E54
	private void warningButton_Click(object sender, EventArgs e)
	{
		MessageBox.Show(string.Concat(new string[]
		{
			"--> Vac ban yememek için kesinlikle yapmanız gerekenler ",
			Environment.NewLine,
			Environment.NewLine,
			"(1) Hilenin güncel tarihli sürümünü kullanmak.",
			Environment.NewLine,
			"Not: Her gün 00:00'da indirme linki güncellenir.",
			Environment.NewLine,
			Environment.NewLine,
			"(2) Hile dosyasını açmadan önce vmprotectlemek.",
			Environment.NewLine,
			Environment.NewLine,
			"--> Overwatch'a düşmemek için tavsiyeler",
			Environment.NewLine,
			Environment.NewLine,
			"Temel prensip: Hile olduğunuzu diğer oyunculara belli etmemek.",
			Environment.NewLine,
			Environment.NewLine,
			"(1) Kill sayısını abartmamak.",
			Environment.NewLine,
			Environment.NewLine,
			"(2) Peşpeşe headshot atmamak.",
			Environment.NewLine,
			Environment.NewLine,
			"Not: Hilemizi ücretsiz csgo hesaplarınızda kullanmanızı öneriyoruz."
		}), "Ban yememek için uyarılar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00003D4C File Offset: 0x00001F4C
	private void downButton_Click(object sender, EventArgs e)
	{
		string text = "";
		try
		{
			text = Class0.smethod_0("https://hilebol.space/csgobol/wall-link.php", 10000);
		}
		catch (Exception)
		{
			MessageBox.Show("Link getirilirken bir hata meydana geldi. Lütfen daha sonra tekrar deneyin, sorun düzelmezse facebook sayfamızdan bize bildirmenizi rica ederiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		if (!string.IsNullOrEmpty(text) && text != "TIMEOUT")
		{
			try
			{
				Process.Start(text);
				return;
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
		}
		MessageBox.Show("Bir şeyler yolunda gitmedi, lütfen tekrar deneyin. Sorun devam ederse facebook sayfamızdan bize ulaşın.", "Hay aksi!?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003DEC File Offset: 0x00001FEC
	private void Form3_Load(object sender, EventArgs e)
	{
		base.Size = new Size(455, 500);
		this.altPanel.Location = new Point(45, 425);
		this.Text = "CSGOBOL WALL HACK v" + Form1.string_0;
		this.downloadLinkPanel.Location = this.ImageLoading.Location;
		this.linkApprovePanel.Location = this.ImageLoading.Location;
		this.timer_0.Start();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000021AD File Offset: 0x000003AD
	private bool method_0()
	{
		return !(Class0.smethod_0("https://hilebol.space/linkApprove/check.php?hwid=" + Class0.form1_0.string_2, 5000) == "1");
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003E74 File Offset: 0x00002074
	private void method_1()
	{
		try
		{
			this.object_0 = new JavaScriptSerializer().Deserialize<object>(Class0.smethod_0("https://hilebol.space/linkApprove/links.php?hwid=" + Class0.form1_0.string_2, 10000));
		}
		catch (Exception)
		{
			MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen bağlantınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.method_1();
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003EE0 File Offset: 0x000020E0
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.son24SaatLabel.Text = "Son 24 saatte, seninle beraber {0} kişi buradaydı.".Replace("{0}", Class0.smethod_0("https://hilebol.space/linkApprove/last24h.php?s=bolwall", 2000));
		if (this.method_0())
		{
			base.Size = new Size(455, 580);
			this.timer_2.Start();
			this.linkApprovePanel.Visible = true;
			this.downloadLinkPanel.Visible = false;
			this.method_1();
			Control control = this.onayPeriyoduLabel;
			if (Form3.<>o__11.<>p__3 == null)
			{
				Form3.<>o__11.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target = Form3.<>o__11.<>p__3.Target;
			CallSite <>p__ = Form3.<>o__11.<>p__3;
			if (Form3.<>o__11.<>p__2 == null)
			{
				Form3.<>o__11.<>p__2 = CallSite<Func<CallSite, string, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, string, object, object> target2 = Form3.<>o__11.<>p__2.Target;
			CallSite <>p__2 = Form3.<>o__11.<>p__2;
			string arg = "Onay için {0} adet link geçişi yapmalısınız.\nOnay periyodu 24 saattir.";
			string arg2 = "{0}";
			if (Form3.<>o__11.<>p__1 == null)
			{
				Form3.<>o__11.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> target3 = Form3.<>o__11.<>p__1.Target;
			CallSite <>p__3 = Form3.<>o__11.<>p__1;
			if (Form3.<>o__11.<>p__0 == null)
			{
				Form3.<>o__11.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control.Text = target(<>p__, target2(<>p__2, arg, arg2, target3(<>p__3, Form3.<>o__11.<>p__0.Target(Form3.<>o__11.<>p__0, this.object_0, "linkCountForDone"))));
			if (Form3.<>o__11.<>p__8 == null)
			{
				Form3.<>o__11.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target4 = Form3.<>o__11.<>p__8.Target;
			CallSite <>p__4 = Form3.<>o__11.<>p__8;
			if (Form3.<>o__11.<>p__7 == null)
			{
				Form3.<>o__11.<>p__7 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target5 = Form3.<>o__11.<>p__7.Target;
			CallSite <>p__5 = Form3.<>o__11.<>p__7;
			if (Form3.<>o__11.<>p__6 == null)
			{
				Form3.<>o__11.<>p__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target6 = Form3.<>o__11.<>p__6.Target;
			CallSite <>p__6 = Form3.<>o__11.<>p__6;
			if (Form3.<>o__11.<>p__5 == null)
			{
				Form3.<>o__11.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target7 = Form3.<>o__11.<>p__5.Target;
			CallSite <>p__7 = Form3.<>o__11.<>p__5;
			if (Form3.<>o__11.<>p__4 == null)
			{
				Form3.<>o__11.<>p__4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target4(<>p__4, target5(<>p__5, target6(<>p__6, target7(<>p__7, Form3.<>o__11.<>p__4.Target(Form3.<>o__11.<>p__4, this.object_0, "links"), 0), "show"), false)))
			{
				this.linkLabel1.Visible = false;
				this.linkIcon1.Visible = false;
			}
			if (Form3.<>o__11.<>p__13 == null)
			{
				Form3.<>o__11.<>p__13 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target8 = Form3.<>o__11.<>p__13.Target;
			CallSite <>p__8 = Form3.<>o__11.<>p__13;
			if (Form3.<>o__11.<>p__12 == null)
			{
				Form3.<>o__11.<>p__12 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target9 = Form3.<>o__11.<>p__12.Target;
			CallSite <>p__9 = Form3.<>o__11.<>p__12;
			if (Form3.<>o__11.<>p__11 == null)
			{
				Form3.<>o__11.<>p__11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target10 = Form3.<>o__11.<>p__11.Target;
			CallSite <>p__10 = Form3.<>o__11.<>p__11;
			if (Form3.<>o__11.<>p__10 == null)
			{
				Form3.<>o__11.<>p__10 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target11 = Form3.<>o__11.<>p__10.Target;
			CallSite <>p__11 = Form3.<>o__11.<>p__10;
			if (Form3.<>o__11.<>p__9 == null)
			{
				Form3.<>o__11.<>p__9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target8(<>p__8, target9(<>p__9, target10(<>p__10, target11(<>p__11, Form3.<>o__11.<>p__9.Target(Form3.<>o__11.<>p__9, this.object_0, "links"), 1), "show"), false)))
			{
				this.linkLabel2.Visible = false;
				this.linkIcon2.Visible = false;
			}
			if (Form3.<>o__11.<>p__18 == null)
			{
				Form3.<>o__11.<>p__18 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target12 = Form3.<>o__11.<>p__18.Target;
			CallSite <>p__12 = Form3.<>o__11.<>p__18;
			if (Form3.<>o__11.<>p__17 == null)
			{
				Form3.<>o__11.<>p__17 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target13 = Form3.<>o__11.<>p__17.Target;
			CallSite <>p__13 = Form3.<>o__11.<>p__17;
			if (Form3.<>o__11.<>p__16 == null)
			{
				Form3.<>o__11.<>p__16 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target14 = Form3.<>o__11.<>p__16.Target;
			CallSite <>p__14 = Form3.<>o__11.<>p__16;
			if (Form3.<>o__11.<>p__15 == null)
			{
				Form3.<>o__11.<>p__15 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target15 = Form3.<>o__11.<>p__15.Target;
			CallSite <>p__15 = Form3.<>o__11.<>p__15;
			if (Form3.<>o__11.<>p__14 == null)
			{
				Form3.<>o__11.<>p__14 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target12(<>p__12, target13(<>p__13, target14(<>p__14, target15(<>p__15, Form3.<>o__11.<>p__14.Target(Form3.<>o__11.<>p__14, this.object_0, "links"), 2), "show"), false)))
			{
				this.linkLabel3.Visible = false;
				this.linkIcon3.Visible = false;
			}
			if (Form3.<>o__11.<>p__23 == null)
			{
				Form3.<>o__11.<>p__23 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target16 = Form3.<>o__11.<>p__23.Target;
			CallSite <>p__16 = Form3.<>o__11.<>p__23;
			if (Form3.<>o__11.<>p__22 == null)
			{
				Form3.<>o__11.<>p__22 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target17 = Form3.<>o__11.<>p__22.Target;
			CallSite <>p__17 = Form3.<>o__11.<>p__22;
			if (Form3.<>o__11.<>p__21 == null)
			{
				Form3.<>o__11.<>p__21 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target18 = Form3.<>o__11.<>p__21.Target;
			CallSite <>p__18 = Form3.<>o__11.<>p__21;
			if (Form3.<>o__11.<>p__20 == null)
			{
				Form3.<>o__11.<>p__20 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target19 = Form3.<>o__11.<>p__20.Target;
			CallSite <>p__19 = Form3.<>o__11.<>p__20;
			if (Form3.<>o__11.<>p__19 == null)
			{
				Form3.<>o__11.<>p__19 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target16(<>p__16, target17(<>p__17, target18(<>p__18, target19(<>p__19, Form3.<>o__11.<>p__19.Target(Form3.<>o__11.<>p__19, this.object_0, "links"), 3), "show"), false)))
			{
				this.linkLabel4.Visible = false;
				this.linkIcon4.Visible = false;
			}
			if (Form3.<>o__11.<>p__28 == null)
			{
				Form3.<>o__11.<>p__28 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target20 = Form3.<>o__11.<>p__28.Target;
			CallSite <>p__20 = Form3.<>o__11.<>p__28;
			if (Form3.<>o__11.<>p__27 == null)
			{
				Form3.<>o__11.<>p__27 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target21 = Form3.<>o__11.<>p__27.Target;
			CallSite <>p__21 = Form3.<>o__11.<>p__27;
			if (Form3.<>o__11.<>p__26 == null)
			{
				Form3.<>o__11.<>p__26 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target22 = Form3.<>o__11.<>p__26.Target;
			CallSite <>p__22 = Form3.<>o__11.<>p__26;
			if (Form3.<>o__11.<>p__25 == null)
			{
				Form3.<>o__11.<>p__25 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target23 = Form3.<>o__11.<>p__25.Target;
			CallSite <>p__23 = Form3.<>o__11.<>p__25;
			if (Form3.<>o__11.<>p__24 == null)
			{
				Form3.<>o__11.<>p__24 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target20(<>p__20, target21(<>p__21, target22(<>p__22, target23(<>p__23, Form3.<>o__11.<>p__24.Target(Form3.<>o__11.<>p__24, this.object_0, "links"), 4), "show"), false)))
			{
				this.linkLabel5.Visible = false;
				this.linkIcon5.Visible = false;
			}
			if (Form3.<>o__11.<>p__33 == null)
			{
				Form3.<>o__11.<>p__33 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target24 = Form3.<>o__11.<>p__33.Target;
			CallSite <>p__24 = Form3.<>o__11.<>p__33;
			if (Form3.<>o__11.<>p__32 == null)
			{
				Form3.<>o__11.<>p__32 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target25 = Form3.<>o__11.<>p__32.Target;
			CallSite <>p__25 = Form3.<>o__11.<>p__32;
			if (Form3.<>o__11.<>p__31 == null)
			{
				Form3.<>o__11.<>p__31 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target26 = Form3.<>o__11.<>p__31.Target;
			CallSite <>p__26 = Form3.<>o__11.<>p__31;
			if (Form3.<>o__11.<>p__30 == null)
			{
				Form3.<>o__11.<>p__30 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target27 = Form3.<>o__11.<>p__30.Target;
			CallSite <>p__27 = Form3.<>o__11.<>p__30;
			if (Form3.<>o__11.<>p__29 == null)
			{
				Form3.<>o__11.<>p__29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target24(<>p__24, target25(<>p__25, target26(<>p__26, target27(<>p__27, Form3.<>o__11.<>p__29.Target(Form3.<>o__11.<>p__29, this.object_0, "links"), 5), "show"), false)))
			{
				this.linkLabel6.Visible = false;
				this.linkIcon6.Visible = false;
			}
			if (Form3.<>o__11.<>p__38 == null)
			{
				Form3.<>o__11.<>p__38 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target28 = Form3.<>o__11.<>p__38.Target;
			CallSite <>p__28 = Form3.<>o__11.<>p__38;
			if (Form3.<>o__11.<>p__37 == null)
			{
				Form3.<>o__11.<>p__37 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target29 = Form3.<>o__11.<>p__37.Target;
			CallSite <>p__29 = Form3.<>o__11.<>p__37;
			if (Form3.<>o__11.<>p__36 == null)
			{
				Form3.<>o__11.<>p__36 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target30 = Form3.<>o__11.<>p__36.Target;
			CallSite <>p__30 = Form3.<>o__11.<>p__36;
			if (Form3.<>o__11.<>p__35 == null)
			{
				Form3.<>o__11.<>p__35 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target31 = Form3.<>o__11.<>p__35.Target;
			CallSite <>p__31 = Form3.<>o__11.<>p__35;
			if (Form3.<>o__11.<>p__34 == null)
			{
				Form3.<>o__11.<>p__34 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target28(<>p__28, target29(<>p__29, target30(<>p__30, target31(<>p__31, Form3.<>o__11.<>p__34.Target(Form3.<>o__11.<>p__34, this.object_0, "links"), 6), "show"), false)))
			{
				this.linkLabel7.Visible = false;
				this.linkIcon7.Visible = false;
			}
			if (Form3.<>o__11.<>p__43 == null)
			{
				Form3.<>o__11.<>p__43 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target32 = Form3.<>o__11.<>p__43.Target;
			CallSite <>p__32 = Form3.<>o__11.<>p__43;
			if (Form3.<>o__11.<>p__42 == null)
			{
				Form3.<>o__11.<>p__42 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target33 = Form3.<>o__11.<>p__42.Target;
			CallSite <>p__33 = Form3.<>o__11.<>p__42;
			if (Form3.<>o__11.<>p__41 == null)
			{
				Form3.<>o__11.<>p__41 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target34 = Form3.<>o__11.<>p__41.Target;
			CallSite <>p__34 = Form3.<>o__11.<>p__41;
			if (Form3.<>o__11.<>p__40 == null)
			{
				Form3.<>o__11.<>p__40 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target35 = Form3.<>o__11.<>p__40.Target;
			CallSite <>p__35 = Form3.<>o__11.<>p__40;
			if (Form3.<>o__11.<>p__39 == null)
			{
				Form3.<>o__11.<>p__39 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target32(<>p__32, target33(<>p__33, target34(<>p__34, target35(<>p__35, Form3.<>o__11.<>p__39.Target(Form3.<>o__11.<>p__39, this.object_0, "links"), 7), "show"), false)))
			{
				this.linkLabel8.Visible = false;
				this.linkIcon8.Visible = false;
			}
			if (Form3.<>o__11.<>p__48 == null)
			{
				Form3.<>o__11.<>p__48 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target36 = Form3.<>o__11.<>p__48.Target;
			CallSite <>p__36 = Form3.<>o__11.<>p__48;
			if (Form3.<>o__11.<>p__47 == null)
			{
				Form3.<>o__11.<>p__47 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target37 = Form3.<>o__11.<>p__47.Target;
			CallSite <>p__37 = Form3.<>o__11.<>p__47;
			if (Form3.<>o__11.<>p__46 == null)
			{
				Form3.<>o__11.<>p__46 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target38 = Form3.<>o__11.<>p__46.Target;
			CallSite <>p__38 = Form3.<>o__11.<>p__46;
			if (Form3.<>o__11.<>p__45 == null)
			{
				Form3.<>o__11.<>p__45 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target39 = Form3.<>o__11.<>p__45.Target;
			CallSite <>p__39 = Form3.<>o__11.<>p__45;
			if (Form3.<>o__11.<>p__44 == null)
			{
				Form3.<>o__11.<>p__44 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target36(<>p__36, target37(<>p__37, target38(<>p__38, target39(<>p__39, Form3.<>o__11.<>p__44.Target(Form3.<>o__11.<>p__44, this.object_0, "links"), 8), "show"), false)))
			{
				this.linkLabel9.Visible = false;
				this.linkIcon9.Visible = false;
			}
			if (Form3.<>o__11.<>p__53 == null)
			{
				Form3.<>o__11.<>p__53 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target40 = Form3.<>o__11.<>p__53.Target;
			CallSite <>p__40 = Form3.<>o__11.<>p__53;
			if (Form3.<>o__11.<>p__52 == null)
			{
				Form3.<>o__11.<>p__52 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target41 = Form3.<>o__11.<>p__52.Target;
			CallSite <>p__41 = Form3.<>o__11.<>p__52;
			if (Form3.<>o__11.<>p__51 == null)
			{
				Form3.<>o__11.<>p__51 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target42 = Form3.<>o__11.<>p__51.Target;
			CallSite <>p__42 = Form3.<>o__11.<>p__51;
			if (Form3.<>o__11.<>p__50 == null)
			{
				Form3.<>o__11.<>p__50 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target43 = Form3.<>o__11.<>p__50.Target;
			CallSite <>p__43 = Form3.<>o__11.<>p__50;
			if (Form3.<>o__11.<>p__49 == null)
			{
				Form3.<>o__11.<>p__49 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target40(<>p__40, target41(<>p__41, target42(<>p__42, target43(<>p__43, Form3.<>o__11.<>p__49.Target(Form3.<>o__11.<>p__49, this.object_0, "links"), 9), "show"), false)))
			{
				this.linkLabel10.Visible = false;
				this.linkIcon10.Visible = false;
			}
			if (Form3.<>o__11.<>p__58 == null)
			{
				Form3.<>o__11.<>p__58 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target44 = Form3.<>o__11.<>p__58.Target;
			CallSite <>p__44 = Form3.<>o__11.<>p__58;
			if (Form3.<>o__11.<>p__57 == null)
			{
				Form3.<>o__11.<>p__57 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target45 = Form3.<>o__11.<>p__57.Target;
			CallSite <>p__45 = Form3.<>o__11.<>p__57;
			if (Form3.<>o__11.<>p__56 == null)
			{
				Form3.<>o__11.<>p__56 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target46 = Form3.<>o__11.<>p__56.Target;
			CallSite <>p__46 = Form3.<>o__11.<>p__56;
			if (Form3.<>o__11.<>p__55 == null)
			{
				Form3.<>o__11.<>p__55 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target47 = Form3.<>o__11.<>p__55.Target;
			CallSite <>p__47 = Form3.<>o__11.<>p__55;
			if (Form3.<>o__11.<>p__54 == null)
			{
				Form3.<>o__11.<>p__54 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target44(<>p__44, target45(<>p__45, target46(<>p__46, target47(<>p__47, Form3.<>o__11.<>p__54.Target(Form3.<>o__11.<>p__54, this.object_0, "links"), 10), "show"), false)))
			{
				this.linkLabel11.Visible = false;
				this.linkIcon11.Visible = false;
			}
			if (Form3.<>o__11.<>p__63 == null)
			{
				Form3.<>o__11.<>p__63 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target48 = Form3.<>o__11.<>p__63.Target;
			CallSite <>p__48 = Form3.<>o__11.<>p__63;
			if (Form3.<>o__11.<>p__62 == null)
			{
				Form3.<>o__11.<>p__62 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target49 = Form3.<>o__11.<>p__62.Target;
			CallSite <>p__49 = Form3.<>o__11.<>p__62;
			if (Form3.<>o__11.<>p__61 == null)
			{
				Form3.<>o__11.<>p__61 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target50 = Form3.<>o__11.<>p__61.Target;
			CallSite <>p__50 = Form3.<>o__11.<>p__61;
			if (Form3.<>o__11.<>p__60 == null)
			{
				Form3.<>o__11.<>p__60 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target51 = Form3.<>o__11.<>p__60.Target;
			CallSite <>p__51 = Form3.<>o__11.<>p__60;
			if (Form3.<>o__11.<>p__59 == null)
			{
				Form3.<>o__11.<>p__59 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target48(<>p__48, target49(<>p__49, target50(<>p__50, target51(<>p__51, Form3.<>o__11.<>p__59.Target(Form3.<>o__11.<>p__59, this.object_0, "links"), 11), "show"), false)))
			{
				this.linkLabel12.Visible = false;
				this.linkIcon12.Visible = false;
			}
			if (Form3.<>o__11.<>p__68 == null)
			{
				Form3.<>o__11.<>p__68 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target52 = Form3.<>o__11.<>p__68.Target;
			CallSite <>p__52 = Form3.<>o__11.<>p__68;
			if (Form3.<>o__11.<>p__67 == null)
			{
				Form3.<>o__11.<>p__67 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target53 = Form3.<>o__11.<>p__67.Target;
			CallSite <>p__53 = Form3.<>o__11.<>p__67;
			if (Form3.<>o__11.<>p__66 == null)
			{
				Form3.<>o__11.<>p__66 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target54 = Form3.<>o__11.<>p__66.Target;
			CallSite <>p__54 = Form3.<>o__11.<>p__66;
			if (Form3.<>o__11.<>p__65 == null)
			{
				Form3.<>o__11.<>p__65 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target55 = Form3.<>o__11.<>p__65.Target;
			CallSite <>p__55 = Form3.<>o__11.<>p__65;
			if (Form3.<>o__11.<>p__64 == null)
			{
				Form3.<>o__11.<>p__64 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target52(<>p__52, target53(<>p__53, target54(<>p__54, target55(<>p__55, Form3.<>o__11.<>p__64.Target(Form3.<>o__11.<>p__64, this.object_0, "links"), 0), "done"), true)))
			{
				this.linkIcon1.Image = Resources.link_done;
				this.linkIcon1.Cursor = Cursors.Default;
				this.int_0[0] = 3;
			}
			if (Form3.<>o__11.<>p__73 == null)
			{
				Form3.<>o__11.<>p__73 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target56 = Form3.<>o__11.<>p__73.Target;
			CallSite <>p__56 = Form3.<>o__11.<>p__73;
			if (Form3.<>o__11.<>p__72 == null)
			{
				Form3.<>o__11.<>p__72 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target57 = Form3.<>o__11.<>p__72.Target;
			CallSite <>p__57 = Form3.<>o__11.<>p__72;
			if (Form3.<>o__11.<>p__71 == null)
			{
				Form3.<>o__11.<>p__71 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target58 = Form3.<>o__11.<>p__71.Target;
			CallSite <>p__58 = Form3.<>o__11.<>p__71;
			if (Form3.<>o__11.<>p__70 == null)
			{
				Form3.<>o__11.<>p__70 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target59 = Form3.<>o__11.<>p__70.Target;
			CallSite <>p__59 = Form3.<>o__11.<>p__70;
			if (Form3.<>o__11.<>p__69 == null)
			{
				Form3.<>o__11.<>p__69 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target56(<>p__56, target57(<>p__57, target58(<>p__58, target59(<>p__59, Form3.<>o__11.<>p__69.Target(Form3.<>o__11.<>p__69, this.object_0, "links"), 1), "done"), true)))
			{
				this.linkIcon2.Image = Resources.link_done;
				this.linkIcon2.Cursor = Cursors.Default;
				this.int_0[1] = 3;
			}
			if (Form3.<>o__11.<>p__78 == null)
			{
				Form3.<>o__11.<>p__78 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target60 = Form3.<>o__11.<>p__78.Target;
			CallSite <>p__60 = Form3.<>o__11.<>p__78;
			if (Form3.<>o__11.<>p__77 == null)
			{
				Form3.<>o__11.<>p__77 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target61 = Form3.<>o__11.<>p__77.Target;
			CallSite <>p__61 = Form3.<>o__11.<>p__77;
			if (Form3.<>o__11.<>p__76 == null)
			{
				Form3.<>o__11.<>p__76 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target62 = Form3.<>o__11.<>p__76.Target;
			CallSite <>p__62 = Form3.<>o__11.<>p__76;
			if (Form3.<>o__11.<>p__75 == null)
			{
				Form3.<>o__11.<>p__75 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target63 = Form3.<>o__11.<>p__75.Target;
			CallSite <>p__63 = Form3.<>o__11.<>p__75;
			if (Form3.<>o__11.<>p__74 == null)
			{
				Form3.<>o__11.<>p__74 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target60(<>p__60, target61(<>p__61, target62(<>p__62, target63(<>p__63, Form3.<>o__11.<>p__74.Target(Form3.<>o__11.<>p__74, this.object_0, "links"), 2), "done"), true)))
			{
				this.linkIcon3.Image = Resources.link_done;
				this.linkIcon3.Cursor = Cursors.Default;
				this.int_0[2] = 3;
			}
			if (Form3.<>o__11.<>p__83 == null)
			{
				Form3.<>o__11.<>p__83 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target64 = Form3.<>o__11.<>p__83.Target;
			CallSite <>p__64 = Form3.<>o__11.<>p__83;
			if (Form3.<>o__11.<>p__82 == null)
			{
				Form3.<>o__11.<>p__82 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target65 = Form3.<>o__11.<>p__82.Target;
			CallSite <>p__65 = Form3.<>o__11.<>p__82;
			if (Form3.<>o__11.<>p__81 == null)
			{
				Form3.<>o__11.<>p__81 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target66 = Form3.<>o__11.<>p__81.Target;
			CallSite <>p__66 = Form3.<>o__11.<>p__81;
			if (Form3.<>o__11.<>p__80 == null)
			{
				Form3.<>o__11.<>p__80 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target67 = Form3.<>o__11.<>p__80.Target;
			CallSite <>p__67 = Form3.<>o__11.<>p__80;
			if (Form3.<>o__11.<>p__79 == null)
			{
				Form3.<>o__11.<>p__79 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target64(<>p__64, target65(<>p__65, target66(<>p__66, target67(<>p__67, Form3.<>o__11.<>p__79.Target(Form3.<>o__11.<>p__79, this.object_0, "links"), 3), "done"), true)))
			{
				this.linkIcon4.Image = Resources.link_done;
				this.linkIcon4.Cursor = Cursors.Default;
				this.int_0[3] = 3;
			}
			if (Form3.<>o__11.<>p__88 == null)
			{
				Form3.<>o__11.<>p__88 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target68 = Form3.<>o__11.<>p__88.Target;
			CallSite <>p__68 = Form3.<>o__11.<>p__88;
			if (Form3.<>o__11.<>p__87 == null)
			{
				Form3.<>o__11.<>p__87 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target69 = Form3.<>o__11.<>p__87.Target;
			CallSite <>p__69 = Form3.<>o__11.<>p__87;
			if (Form3.<>o__11.<>p__86 == null)
			{
				Form3.<>o__11.<>p__86 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target70 = Form3.<>o__11.<>p__86.Target;
			CallSite <>p__70 = Form3.<>o__11.<>p__86;
			if (Form3.<>o__11.<>p__85 == null)
			{
				Form3.<>o__11.<>p__85 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target71 = Form3.<>o__11.<>p__85.Target;
			CallSite <>p__71 = Form3.<>o__11.<>p__85;
			if (Form3.<>o__11.<>p__84 == null)
			{
				Form3.<>o__11.<>p__84 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target68(<>p__68, target69(<>p__69, target70(<>p__70, target71(<>p__71, Form3.<>o__11.<>p__84.Target(Form3.<>o__11.<>p__84, this.object_0, "links"), 4), "done"), true)))
			{
				this.linkIcon5.Image = Resources.link_done;
				this.linkIcon5.Cursor = Cursors.Default;
				this.int_0[4] = 3;
			}
			if (Form3.<>o__11.<>p__93 == null)
			{
				Form3.<>o__11.<>p__93 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target72 = Form3.<>o__11.<>p__93.Target;
			CallSite <>p__72 = Form3.<>o__11.<>p__93;
			if (Form3.<>o__11.<>p__92 == null)
			{
				Form3.<>o__11.<>p__92 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target73 = Form3.<>o__11.<>p__92.Target;
			CallSite <>p__73 = Form3.<>o__11.<>p__92;
			if (Form3.<>o__11.<>p__91 == null)
			{
				Form3.<>o__11.<>p__91 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target74 = Form3.<>o__11.<>p__91.Target;
			CallSite <>p__74 = Form3.<>o__11.<>p__91;
			if (Form3.<>o__11.<>p__90 == null)
			{
				Form3.<>o__11.<>p__90 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target75 = Form3.<>o__11.<>p__90.Target;
			CallSite <>p__75 = Form3.<>o__11.<>p__90;
			if (Form3.<>o__11.<>p__89 == null)
			{
				Form3.<>o__11.<>p__89 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target72(<>p__72, target73(<>p__73, target74(<>p__74, target75(<>p__75, Form3.<>o__11.<>p__89.Target(Form3.<>o__11.<>p__89, this.object_0, "links"), 5), "done"), true)))
			{
				this.linkIcon6.Image = Resources.link_done;
				this.linkIcon6.Cursor = Cursors.Default;
				this.int_0[5] = 3;
			}
			if (Form3.<>o__11.<>p__98 == null)
			{
				Form3.<>o__11.<>p__98 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target76 = Form3.<>o__11.<>p__98.Target;
			CallSite <>p__76 = Form3.<>o__11.<>p__98;
			if (Form3.<>o__11.<>p__97 == null)
			{
				Form3.<>o__11.<>p__97 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target77 = Form3.<>o__11.<>p__97.Target;
			CallSite <>p__77 = Form3.<>o__11.<>p__97;
			if (Form3.<>o__11.<>p__96 == null)
			{
				Form3.<>o__11.<>p__96 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target78 = Form3.<>o__11.<>p__96.Target;
			CallSite <>p__78 = Form3.<>o__11.<>p__96;
			if (Form3.<>o__11.<>p__95 == null)
			{
				Form3.<>o__11.<>p__95 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target79 = Form3.<>o__11.<>p__95.Target;
			CallSite <>p__79 = Form3.<>o__11.<>p__95;
			if (Form3.<>o__11.<>p__94 == null)
			{
				Form3.<>o__11.<>p__94 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target76(<>p__76, target77(<>p__77, target78(<>p__78, target79(<>p__79, Form3.<>o__11.<>p__94.Target(Form3.<>o__11.<>p__94, this.object_0, "links"), 6), "done"), true)))
			{
				this.linkIcon7.Image = Resources.link_done;
				this.linkIcon7.Cursor = Cursors.Default;
				this.int_0[6] = 3;
			}
			if (Form3.<>o__11.<>p__103 == null)
			{
				Form3.<>o__11.<>p__103 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target80 = Form3.<>o__11.<>p__103.Target;
			CallSite <>p__80 = Form3.<>o__11.<>p__103;
			if (Form3.<>o__11.<>p__102 == null)
			{
				Form3.<>o__11.<>p__102 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target81 = Form3.<>o__11.<>p__102.Target;
			CallSite <>p__81 = Form3.<>o__11.<>p__102;
			if (Form3.<>o__11.<>p__101 == null)
			{
				Form3.<>o__11.<>p__101 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target82 = Form3.<>o__11.<>p__101.Target;
			CallSite <>p__82 = Form3.<>o__11.<>p__101;
			if (Form3.<>o__11.<>p__100 == null)
			{
				Form3.<>o__11.<>p__100 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target83 = Form3.<>o__11.<>p__100.Target;
			CallSite <>p__83 = Form3.<>o__11.<>p__100;
			if (Form3.<>o__11.<>p__99 == null)
			{
				Form3.<>o__11.<>p__99 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target80(<>p__80, target81(<>p__81, target82(<>p__82, target83(<>p__83, Form3.<>o__11.<>p__99.Target(Form3.<>o__11.<>p__99, this.object_0, "links"), 7), "done"), true)))
			{
				this.linkIcon8.Image = Resources.link_done;
				this.linkIcon8.Cursor = Cursors.Default;
				this.int_0[7] = 3;
			}
			if (Form3.<>o__11.<>p__108 == null)
			{
				Form3.<>o__11.<>p__108 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target84 = Form3.<>o__11.<>p__108.Target;
			CallSite <>p__84 = Form3.<>o__11.<>p__108;
			if (Form3.<>o__11.<>p__107 == null)
			{
				Form3.<>o__11.<>p__107 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target85 = Form3.<>o__11.<>p__107.Target;
			CallSite <>p__85 = Form3.<>o__11.<>p__107;
			if (Form3.<>o__11.<>p__106 == null)
			{
				Form3.<>o__11.<>p__106 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target86 = Form3.<>o__11.<>p__106.Target;
			CallSite <>p__86 = Form3.<>o__11.<>p__106;
			if (Form3.<>o__11.<>p__105 == null)
			{
				Form3.<>o__11.<>p__105 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target87 = Form3.<>o__11.<>p__105.Target;
			CallSite <>p__87 = Form3.<>o__11.<>p__105;
			if (Form3.<>o__11.<>p__104 == null)
			{
				Form3.<>o__11.<>p__104 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target84(<>p__84, target85(<>p__85, target86(<>p__86, target87(<>p__87, Form3.<>o__11.<>p__104.Target(Form3.<>o__11.<>p__104, this.object_0, "links"), 8), "done"), true)))
			{
				this.linkIcon9.Image = Resources.link_done;
				this.linkIcon9.Cursor = Cursors.Default;
				this.int_0[8] = 3;
			}
			if (Form3.<>o__11.<>p__113 == null)
			{
				Form3.<>o__11.<>p__113 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target88 = Form3.<>o__11.<>p__113.Target;
			CallSite <>p__88 = Form3.<>o__11.<>p__113;
			if (Form3.<>o__11.<>p__112 == null)
			{
				Form3.<>o__11.<>p__112 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target89 = Form3.<>o__11.<>p__112.Target;
			CallSite <>p__89 = Form3.<>o__11.<>p__112;
			if (Form3.<>o__11.<>p__111 == null)
			{
				Form3.<>o__11.<>p__111 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target90 = Form3.<>o__11.<>p__111.Target;
			CallSite <>p__90 = Form3.<>o__11.<>p__111;
			if (Form3.<>o__11.<>p__110 == null)
			{
				Form3.<>o__11.<>p__110 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target91 = Form3.<>o__11.<>p__110.Target;
			CallSite <>p__91 = Form3.<>o__11.<>p__110;
			if (Form3.<>o__11.<>p__109 == null)
			{
				Form3.<>o__11.<>p__109 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target88(<>p__88, target89(<>p__89, target90(<>p__90, target91(<>p__91, Form3.<>o__11.<>p__109.Target(Form3.<>o__11.<>p__109, this.object_0, "links"), 9), "done"), true)))
			{
				this.linkIcon10.Image = Resources.link_done;
				this.linkIcon10.Cursor = Cursors.Default;
				this.int_0[9] = 3;
			}
			if (Form3.<>o__11.<>p__118 == null)
			{
				Form3.<>o__11.<>p__118 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target92 = Form3.<>o__11.<>p__118.Target;
			CallSite <>p__92 = Form3.<>o__11.<>p__118;
			if (Form3.<>o__11.<>p__117 == null)
			{
				Form3.<>o__11.<>p__117 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target93 = Form3.<>o__11.<>p__117.Target;
			CallSite <>p__93 = Form3.<>o__11.<>p__117;
			if (Form3.<>o__11.<>p__116 == null)
			{
				Form3.<>o__11.<>p__116 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target94 = Form3.<>o__11.<>p__116.Target;
			CallSite <>p__94 = Form3.<>o__11.<>p__116;
			if (Form3.<>o__11.<>p__115 == null)
			{
				Form3.<>o__11.<>p__115 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target95 = Form3.<>o__11.<>p__115.Target;
			CallSite <>p__95 = Form3.<>o__11.<>p__115;
			if (Form3.<>o__11.<>p__114 == null)
			{
				Form3.<>o__11.<>p__114 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target92(<>p__92, target93(<>p__93, target94(<>p__94, target95(<>p__95, Form3.<>o__11.<>p__114.Target(Form3.<>o__11.<>p__114, this.object_0, "links"), 10), "done"), true)))
			{
				this.linkIcon11.Image = Resources.link_done;
				this.linkIcon11.Cursor = Cursors.Default;
				this.int_0[10] = 3;
			}
			if (Form3.<>o__11.<>p__123 == null)
			{
				Form3.<>o__11.<>p__123 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target96 = Form3.<>o__11.<>p__123.Target;
			CallSite <>p__96 = Form3.<>o__11.<>p__123;
			if (Form3.<>o__11.<>p__122 == null)
			{
				Form3.<>o__11.<>p__122 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, bool, object> target97 = Form3.<>o__11.<>p__122.Target;
			CallSite <>p__97 = Form3.<>o__11.<>p__122;
			if (Form3.<>o__11.<>p__121 == null)
			{
				Form3.<>o__11.<>p__121 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target98 = Form3.<>o__11.<>p__121.Target;
			CallSite <>p__98 = Form3.<>o__11.<>p__121;
			if (Form3.<>o__11.<>p__120 == null)
			{
				Form3.<>o__11.<>p__120 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target99 = Form3.<>o__11.<>p__120.Target;
			CallSite <>p__99 = Form3.<>o__11.<>p__120;
			if (Form3.<>o__11.<>p__119 == null)
			{
				Form3.<>o__11.<>p__119 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target96(<>p__96, target97(<>p__97, target98(<>p__98, target99(<>p__99, Form3.<>o__11.<>p__119.Target(Form3.<>o__11.<>p__119, this.object_0, "links"), 11), "done"), true)))
			{
				this.linkIcon12.Image = Resources.link_done;
				this.linkIcon12.Cursor = Cursors.Default;
				this.int_0[11] = 3;
			}
			Control control2 = this.linkLabel1;
			if (Form3.<>o__11.<>p__127 == null)
			{
				Form3.<>o__11.<>p__127 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target100 = Form3.<>o__11.<>p__127.Target;
			CallSite <>p__100 = Form3.<>o__11.<>p__127;
			if (Form3.<>o__11.<>p__126 == null)
			{
				Form3.<>o__11.<>p__126 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target101 = Form3.<>o__11.<>p__126.Target;
			CallSite <>p__101 = Form3.<>o__11.<>p__126;
			if (Form3.<>o__11.<>p__125 == null)
			{
				Form3.<>o__11.<>p__125 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target102 = Form3.<>o__11.<>p__125.Target;
			CallSite <>p__102 = Form3.<>o__11.<>p__125;
			if (Form3.<>o__11.<>p__124 == null)
			{
				Form3.<>o__11.<>p__124 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control2.Text = target100(<>p__100, target101(<>p__101, target102(<>p__102, Form3.<>o__11.<>p__124.Target(Form3.<>o__11.<>p__124, this.object_0, "links"), 0), "name"));
			Control control3 = this.linkLabel2;
			if (Form3.<>o__11.<>p__131 == null)
			{
				Form3.<>o__11.<>p__131 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target103 = Form3.<>o__11.<>p__131.Target;
			CallSite <>p__103 = Form3.<>o__11.<>p__131;
			if (Form3.<>o__11.<>p__130 == null)
			{
				Form3.<>o__11.<>p__130 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target104 = Form3.<>o__11.<>p__130.Target;
			CallSite <>p__104 = Form3.<>o__11.<>p__130;
			if (Form3.<>o__11.<>p__129 == null)
			{
				Form3.<>o__11.<>p__129 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target105 = Form3.<>o__11.<>p__129.Target;
			CallSite <>p__105 = Form3.<>o__11.<>p__129;
			if (Form3.<>o__11.<>p__128 == null)
			{
				Form3.<>o__11.<>p__128 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control3.Text = target103(<>p__103, target104(<>p__104, target105(<>p__105, Form3.<>o__11.<>p__128.Target(Form3.<>o__11.<>p__128, this.object_0, "links"), 1), "name"));
			Control control4 = this.linkLabel3;
			if (Form3.<>o__11.<>p__135 == null)
			{
				Form3.<>o__11.<>p__135 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target106 = Form3.<>o__11.<>p__135.Target;
			CallSite <>p__106 = Form3.<>o__11.<>p__135;
			if (Form3.<>o__11.<>p__134 == null)
			{
				Form3.<>o__11.<>p__134 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target107 = Form3.<>o__11.<>p__134.Target;
			CallSite <>p__107 = Form3.<>o__11.<>p__134;
			if (Form3.<>o__11.<>p__133 == null)
			{
				Form3.<>o__11.<>p__133 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target108 = Form3.<>o__11.<>p__133.Target;
			CallSite <>p__108 = Form3.<>o__11.<>p__133;
			if (Form3.<>o__11.<>p__132 == null)
			{
				Form3.<>o__11.<>p__132 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control4.Text = target106(<>p__106, target107(<>p__107, target108(<>p__108, Form3.<>o__11.<>p__132.Target(Form3.<>o__11.<>p__132, this.object_0, "links"), 2), "name"));
			Control control5 = this.linkLabel4;
			if (Form3.<>o__11.<>p__139 == null)
			{
				Form3.<>o__11.<>p__139 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target109 = Form3.<>o__11.<>p__139.Target;
			CallSite <>p__109 = Form3.<>o__11.<>p__139;
			if (Form3.<>o__11.<>p__138 == null)
			{
				Form3.<>o__11.<>p__138 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target110 = Form3.<>o__11.<>p__138.Target;
			CallSite <>p__110 = Form3.<>o__11.<>p__138;
			if (Form3.<>o__11.<>p__137 == null)
			{
				Form3.<>o__11.<>p__137 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target111 = Form3.<>o__11.<>p__137.Target;
			CallSite <>p__111 = Form3.<>o__11.<>p__137;
			if (Form3.<>o__11.<>p__136 == null)
			{
				Form3.<>o__11.<>p__136 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control5.Text = target109(<>p__109, target110(<>p__110, target111(<>p__111, Form3.<>o__11.<>p__136.Target(Form3.<>o__11.<>p__136, this.object_0, "links"), 3), "name"));
			Control control6 = this.linkLabel5;
			if (Form3.<>o__11.<>p__143 == null)
			{
				Form3.<>o__11.<>p__143 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target112 = Form3.<>o__11.<>p__143.Target;
			CallSite <>p__112 = Form3.<>o__11.<>p__143;
			if (Form3.<>o__11.<>p__142 == null)
			{
				Form3.<>o__11.<>p__142 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target113 = Form3.<>o__11.<>p__142.Target;
			CallSite <>p__113 = Form3.<>o__11.<>p__142;
			if (Form3.<>o__11.<>p__141 == null)
			{
				Form3.<>o__11.<>p__141 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target114 = Form3.<>o__11.<>p__141.Target;
			CallSite <>p__114 = Form3.<>o__11.<>p__141;
			if (Form3.<>o__11.<>p__140 == null)
			{
				Form3.<>o__11.<>p__140 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control6.Text = target112(<>p__112, target113(<>p__113, target114(<>p__114, Form3.<>o__11.<>p__140.Target(Form3.<>o__11.<>p__140, this.object_0, "links"), 4), "name"));
			Control control7 = this.linkLabel6;
			if (Form3.<>o__11.<>p__147 == null)
			{
				Form3.<>o__11.<>p__147 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target115 = Form3.<>o__11.<>p__147.Target;
			CallSite <>p__115 = Form3.<>o__11.<>p__147;
			if (Form3.<>o__11.<>p__146 == null)
			{
				Form3.<>o__11.<>p__146 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target116 = Form3.<>o__11.<>p__146.Target;
			CallSite <>p__116 = Form3.<>o__11.<>p__146;
			if (Form3.<>o__11.<>p__145 == null)
			{
				Form3.<>o__11.<>p__145 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target117 = Form3.<>o__11.<>p__145.Target;
			CallSite <>p__117 = Form3.<>o__11.<>p__145;
			if (Form3.<>o__11.<>p__144 == null)
			{
				Form3.<>o__11.<>p__144 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control7.Text = target115(<>p__115, target116(<>p__116, target117(<>p__117, Form3.<>o__11.<>p__144.Target(Form3.<>o__11.<>p__144, this.object_0, "links"), 5), "name"));
			Control control8 = this.linkLabel7;
			if (Form3.<>o__11.<>p__151 == null)
			{
				Form3.<>o__11.<>p__151 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target118 = Form3.<>o__11.<>p__151.Target;
			CallSite <>p__118 = Form3.<>o__11.<>p__151;
			if (Form3.<>o__11.<>p__150 == null)
			{
				Form3.<>o__11.<>p__150 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target119 = Form3.<>o__11.<>p__150.Target;
			CallSite <>p__119 = Form3.<>o__11.<>p__150;
			if (Form3.<>o__11.<>p__149 == null)
			{
				Form3.<>o__11.<>p__149 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target120 = Form3.<>o__11.<>p__149.Target;
			CallSite <>p__120 = Form3.<>o__11.<>p__149;
			if (Form3.<>o__11.<>p__148 == null)
			{
				Form3.<>o__11.<>p__148 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control8.Text = target118(<>p__118, target119(<>p__119, target120(<>p__120, Form3.<>o__11.<>p__148.Target(Form3.<>o__11.<>p__148, this.object_0, "links"), 6), "name"));
			Control control9 = this.linkLabel8;
			if (Form3.<>o__11.<>p__155 == null)
			{
				Form3.<>o__11.<>p__155 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target121 = Form3.<>o__11.<>p__155.Target;
			CallSite <>p__121 = Form3.<>o__11.<>p__155;
			if (Form3.<>o__11.<>p__154 == null)
			{
				Form3.<>o__11.<>p__154 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target122 = Form3.<>o__11.<>p__154.Target;
			CallSite <>p__122 = Form3.<>o__11.<>p__154;
			if (Form3.<>o__11.<>p__153 == null)
			{
				Form3.<>o__11.<>p__153 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target123 = Form3.<>o__11.<>p__153.Target;
			CallSite <>p__123 = Form3.<>o__11.<>p__153;
			if (Form3.<>o__11.<>p__152 == null)
			{
				Form3.<>o__11.<>p__152 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control9.Text = target121(<>p__121, target122(<>p__122, target123(<>p__123, Form3.<>o__11.<>p__152.Target(Form3.<>o__11.<>p__152, this.object_0, "links"), 7), "name"));
			Control control10 = this.linkLabel9;
			if (Form3.<>o__11.<>p__159 == null)
			{
				Form3.<>o__11.<>p__159 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target124 = Form3.<>o__11.<>p__159.Target;
			CallSite <>p__124 = Form3.<>o__11.<>p__159;
			if (Form3.<>o__11.<>p__158 == null)
			{
				Form3.<>o__11.<>p__158 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target125 = Form3.<>o__11.<>p__158.Target;
			CallSite <>p__125 = Form3.<>o__11.<>p__158;
			if (Form3.<>o__11.<>p__157 == null)
			{
				Form3.<>o__11.<>p__157 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target126 = Form3.<>o__11.<>p__157.Target;
			CallSite <>p__126 = Form3.<>o__11.<>p__157;
			if (Form3.<>o__11.<>p__156 == null)
			{
				Form3.<>o__11.<>p__156 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control10.Text = target124(<>p__124, target125(<>p__125, target126(<>p__126, Form3.<>o__11.<>p__156.Target(Form3.<>o__11.<>p__156, this.object_0, "links"), 8), "name"));
			Control control11 = this.linkLabel10;
			if (Form3.<>o__11.<>p__163 == null)
			{
				Form3.<>o__11.<>p__163 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target127 = Form3.<>o__11.<>p__163.Target;
			CallSite <>p__127 = Form3.<>o__11.<>p__163;
			if (Form3.<>o__11.<>p__162 == null)
			{
				Form3.<>o__11.<>p__162 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target128 = Form3.<>o__11.<>p__162.Target;
			CallSite <>p__128 = Form3.<>o__11.<>p__162;
			if (Form3.<>o__11.<>p__161 == null)
			{
				Form3.<>o__11.<>p__161 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target129 = Form3.<>o__11.<>p__161.Target;
			CallSite <>p__129 = Form3.<>o__11.<>p__161;
			if (Form3.<>o__11.<>p__160 == null)
			{
				Form3.<>o__11.<>p__160 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control11.Text = target127(<>p__127, target128(<>p__128, target129(<>p__129, Form3.<>o__11.<>p__160.Target(Form3.<>o__11.<>p__160, this.object_0, "links"), 9), "name"));
			Control control12 = this.linkLabel11;
			if (Form3.<>o__11.<>p__167 == null)
			{
				Form3.<>o__11.<>p__167 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target130 = Form3.<>o__11.<>p__167.Target;
			CallSite <>p__130 = Form3.<>o__11.<>p__167;
			if (Form3.<>o__11.<>p__166 == null)
			{
				Form3.<>o__11.<>p__166 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target131 = Form3.<>o__11.<>p__166.Target;
			CallSite <>p__131 = Form3.<>o__11.<>p__166;
			if (Form3.<>o__11.<>p__165 == null)
			{
				Form3.<>o__11.<>p__165 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target132 = Form3.<>o__11.<>p__165.Target;
			CallSite <>p__132 = Form3.<>o__11.<>p__165;
			if (Form3.<>o__11.<>p__164 == null)
			{
				Form3.<>o__11.<>p__164 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control12.Text = target130(<>p__130, target131(<>p__131, target132(<>p__132, Form3.<>o__11.<>p__164.Target(Form3.<>o__11.<>p__164, this.object_0, "links"), 10), "name"));
			Control control13 = this.linkLabel12;
			if (Form3.<>o__11.<>p__171 == null)
			{
				Form3.<>o__11.<>p__171 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
			}
			Func<CallSite, object, string> target133 = Form3.<>o__11.<>p__171.Target;
			CallSite <>p__133 = Form3.<>o__11.<>p__171;
			if (Form3.<>o__11.<>p__170 == null)
			{
				Form3.<>o__11.<>p__170 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target134 = Form3.<>o__11.<>p__170.Target;
			CallSite <>p__134 = Form3.<>o__11.<>p__170;
			if (Form3.<>o__11.<>p__169 == null)
			{
				Form3.<>o__11.<>p__169 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target135 = Form3.<>o__11.<>p__169.Target;
			CallSite <>p__135 = Form3.<>o__11.<>p__169;
			if (Form3.<>o__11.<>p__168 == null)
			{
				Form3.<>o__11.<>p__168 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			control13.Text = target133(<>p__133, target134(<>p__134, target135(<>p__135, Form3.<>o__11.<>p__168.Target(Form3.<>o__11.<>p__168, this.object_0, "links"), 11), "name"));
		}
		else
		{
			base.Size = new Size(455, 510);
			this.altPanel.Location = new Point(45, 356);
			this.method_2();
			this.linkApprovePanel.Visible = false;
			this.downloadLinkPanel.Visible = true;
		}
		this.ImageLoading.Visible = false;
		this.altPanel.Visible = true;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000079F8 File Offset: 0x00005BF8
	public void method_2()
	{
		string str = Class0.smethod_0("https://hilebol.space/csgobol/tarih.php", 10000);
		this.downButton.Text = str + " tarihli hilenin indirme linkine git";
		this.downButton.Enabled = true;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000021DC File Offset: 0x000003DC
	private void ImageHilebol_Click(object sender, EventArgs e)
	{
		Process.Start("https://hilebol.space");
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000021E9 File Offset: 0x000003E9
	private void ImageFacebook_Click(object sender, EventArgs e)
	{
		Process.Start("https://facebook.com/hilebol");
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000021F6 File Offset: 0x000003F6
	private void ImageYoutube_Click(object sender, EventArgs e)
	{
		Process.Start("https://youtube.com/hilebol");
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000020FE File Offset: 0x000002FE
	private void Form3_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00007A38 File Offset: 0x00005C38
	private string method_3()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (Form3.GetWindowText(Form3.GetForegroundWindow(), stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	// Token: 0x06000024 RID: 36
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06000025 RID: 37
	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_4);

	// Token: 0x06000026 RID: 38 RVA: 0x00002203 File Offset: 0x00000403
	private void linkOnayiNasilYapilirButton_MouseEnter(object sender, EventArgs e)
	{
		this.linkOnayiNasilYapilirButton.BackColor = Color.FromArgb(23, 127, 236);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000221E File Offset: 0x0000041E
	private void linkOnayiNasilYapilirButton_MouseLeave(object sender, EventArgs e)
	{
		this.linkOnayiNasilYapilirButton.BackColor = Color.FromArgb(28, 117, 239);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002239 File Offset: 0x00000439
	private void ustteTutButton_MouseEnter(object sender, EventArgs e)
	{
		this.ustteTutButton.BackColor = Color.FromArgb(245, 248, 248);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000225A File Offset: 0x0000045A
	private void ustteTutButton_MouseLeave(object sender, EventArgs e)
	{
		this.ustteTutButton.BackColor = Color.FromArgb(241, 242, 246);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00007A70 File Offset: 0x00005C70
	private void method_4()
	{
		if (this.int_0[0] == 2)
		{
			this.linkIcon1.Image = Resources.link_waiting;
		}
		else if (this.int_0[0] == 3)
		{
			this.linkIcon1.Image = Resources.link_done;
			this.linkIcon1.Cursor = Cursors.Default;
		}
		if (this.int_0[1] == 2)
		{
			this.linkIcon2.Image = Resources.link_waiting;
		}
		else if (this.int_0[1] == 3)
		{
			this.linkIcon2.Image = Resources.link_done;
			this.linkIcon2.Cursor = Cursors.Default;
		}
		if (this.int_0[2] == 2)
		{
			this.linkIcon3.Image = Resources.link_waiting;
		}
		else if (this.int_0[2] == 3)
		{
			this.linkIcon3.Image = Resources.link_done;
			this.linkIcon3.Cursor = Cursors.Default;
		}
		if (this.int_0[3] == 2)
		{
			this.linkIcon4.Image = Resources.link_waiting;
		}
		else if (this.int_0[3] == 3)
		{
			this.linkIcon4.Image = Resources.link_done;
			this.linkIcon4.Cursor = Cursors.Default;
		}
		if (this.int_0[4] == 2)
		{
			this.linkIcon5.Image = Resources.link_waiting;
		}
		else if (this.int_0[4] == 3)
		{
			this.linkIcon5.Image = Resources.link_done;
			this.linkIcon5.Cursor = Cursors.Default;
		}
		if (this.int_0[5] == 2)
		{
			this.linkIcon6.Image = Resources.link_waiting;
		}
		else if (this.int_0[5] == 3)
		{
			this.linkIcon6.Image = Resources.link_done;
			this.linkIcon6.Cursor = Cursors.Default;
		}
		if (this.int_0[6] == 2)
		{
			this.linkIcon7.Image = Resources.link_waiting;
		}
		else if (this.int_0[6] == 3)
		{
			this.linkIcon7.Image = Resources.link_done;
			this.linkIcon7.Cursor = Cursors.Default;
		}
		if (this.int_0[7] == 2)
		{
			this.linkIcon8.Image = Resources.link_waiting;
		}
		else if (this.int_0[7] == 3)
		{
			this.linkIcon8.Image = Resources.link_done;
			this.linkIcon8.Cursor = Cursors.Default;
		}
		if (this.int_0[8] == 2)
		{
			this.linkIcon9.Image = Resources.link_waiting;
		}
		else if (this.int_0[8] == 3)
		{
			this.linkIcon9.Image = Resources.link_done;
			this.linkIcon9.Cursor = Cursors.Default;
		}
		if (this.int_0[9] == 2)
		{
			this.linkIcon10.Image = Resources.link_waiting;
		}
		else if (this.int_0[9] == 3)
		{
			this.linkIcon10.Image = Resources.link_done;
			this.linkIcon10.Cursor = Cursors.Default;
		}
		if (this.int_0[10] == 2)
		{
			this.linkIcon11.Image = Resources.link_waiting;
		}
		else if (this.int_0[10] == 3)
		{
			this.linkIcon11.Image = Resources.link_done;
			this.linkIcon11.Cursor = Cursors.Default;
		}
		if (this.int_0[11] == 2)
		{
			this.linkIcon12.Image = Resources.link_waiting;
			return;
		}
		if (this.int_0[11] == 3)
		{
			this.linkIcon12.Image = Resources.link_done;
			this.linkIcon12.Cursor = Cursors.Default;
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00007DE4 File Offset: 0x00005FE4
	private void linkIcon1_Click(object sender, EventArgs e)
	{
		if (this.linkIcon1.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 1;
			try
			{
				if (Form3.<>o__26.<>p__3 == null)
				{
					Form3.<>o__26.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__26.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__26.<>p__3;
				if (Form3.<>o__26.<>p__2 == null)
				{
					Form3.<>o__26.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__26.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__26.<>p__2;
				if (Form3.<>o__26.<>p__1 == null)
				{
					Form3.<>o__26.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__26.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__26.<>p__1;
				if (Form3.<>o__26.<>p__0 == null)
				{
					Form3.<>o__26.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__26.<>p__0.Target(Form3.<>o__26.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00007FE4 File Offset: 0x000061E4
	private void linkIcon2_Click(object sender, EventArgs e)
	{
		if (this.linkIcon2.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 2;
			try
			{
				if (Form3.<>o__27.<>p__3 == null)
				{
					Form3.<>o__27.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__27.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__27.<>p__3;
				if (Form3.<>o__27.<>p__2 == null)
				{
					Form3.<>o__27.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__27.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__27.<>p__2;
				if (Form3.<>o__27.<>p__1 == null)
				{
					Form3.<>o__27.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__27.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__27.<>p__1;
				if (Form3.<>o__27.<>p__0 == null)
				{
					Form3.<>o__27.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__27.<>p__0.Target(Form3.<>o__27.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000081E4 File Offset: 0x000063E4
	private void linkIcon3_Click(object sender, EventArgs e)
	{
		if (this.linkIcon3.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 3;
			try
			{
				if (Form3.<>o__28.<>p__3 == null)
				{
					Form3.<>o__28.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__28.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__28.<>p__3;
				if (Form3.<>o__28.<>p__2 == null)
				{
					Form3.<>o__28.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__28.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__28.<>p__2;
				if (Form3.<>o__28.<>p__1 == null)
				{
					Form3.<>o__28.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__28.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__28.<>p__1;
				if (Form3.<>o__28.<>p__0 == null)
				{
					Form3.<>o__28.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__28.<>p__0.Target(Form3.<>o__28.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000083E4 File Offset: 0x000065E4
	private void linkIcon4_Click(object sender, EventArgs e)
	{
		if (this.linkIcon4.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 4;
			try
			{
				if (Form3.<>o__29.<>p__3 == null)
				{
					Form3.<>o__29.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__29.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__29.<>p__3;
				if (Form3.<>o__29.<>p__2 == null)
				{
					Form3.<>o__29.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__29.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__29.<>p__2;
				if (Form3.<>o__29.<>p__1 == null)
				{
					Form3.<>o__29.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__29.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__29.<>p__1;
				if (Form3.<>o__29.<>p__0 == null)
				{
					Form3.<>o__29.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__29.<>p__0.Target(Form3.<>o__29.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000085E4 File Offset: 0x000067E4
	private void linkIcon5_Click(object sender, EventArgs e)
	{
		if (this.linkIcon5.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 5;
			try
			{
				if (Form3.<>o__30.<>p__3 == null)
				{
					Form3.<>o__30.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__30.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__30.<>p__3;
				if (Form3.<>o__30.<>p__2 == null)
				{
					Form3.<>o__30.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__30.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__30.<>p__2;
				if (Form3.<>o__30.<>p__1 == null)
				{
					Form3.<>o__30.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__30.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__30.<>p__1;
				if (Form3.<>o__30.<>p__0 == null)
				{
					Form3.<>o__30.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__30.<>p__0.Target(Form3.<>o__30.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000087E4 File Offset: 0x000069E4
	private void linkIcon6_Click(object sender, EventArgs e)
	{
		if (this.linkIcon6.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 6;
			try
			{
				if (Form3.<>o__31.<>p__3 == null)
				{
					Form3.<>o__31.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__31.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__31.<>p__3;
				if (Form3.<>o__31.<>p__2 == null)
				{
					Form3.<>o__31.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__31.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__31.<>p__2;
				if (Form3.<>o__31.<>p__1 == null)
				{
					Form3.<>o__31.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__31.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__31.<>p__1;
				if (Form3.<>o__31.<>p__0 == null)
				{
					Form3.<>o__31.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__31.<>p__0.Target(Form3.<>o__31.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000089E4 File Offset: 0x00006BE4
	private void linkIcon7_Click(object sender, EventArgs e)
	{
		if (this.linkIcon7.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 7;
			try
			{
				if (Form3.<>o__32.<>p__3 == null)
				{
					Form3.<>o__32.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__32.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__32.<>p__3;
				if (Form3.<>o__32.<>p__2 == null)
				{
					Form3.<>o__32.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__32.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__32.<>p__2;
				if (Form3.<>o__32.<>p__1 == null)
				{
					Form3.<>o__32.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__32.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__32.<>p__1;
				if (Form3.<>o__32.<>p__0 == null)
				{
					Form3.<>o__32.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__32.<>p__0.Target(Form3.<>o__32.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00008BE4 File Offset: 0x00006DE4
	private void linkIcon8_Click(object sender, EventArgs e)
	{
		if (this.linkIcon8.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 8;
			try
			{
				if (Form3.<>o__33.<>p__3 == null)
				{
					Form3.<>o__33.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__33.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__33.<>p__3;
				if (Form3.<>o__33.<>p__2 == null)
				{
					Form3.<>o__33.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__33.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__33.<>p__2;
				if (Form3.<>o__33.<>p__1 == null)
				{
					Form3.<>o__33.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__33.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__33.<>p__1;
				if (Form3.<>o__33.<>p__0 == null)
				{
					Form3.<>o__33.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__33.<>p__0.Target(Form3.<>o__33.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00008DE4 File Offset: 0x00006FE4
	private void linkIcon9_Click(object sender, EventArgs e)
	{
		if (this.linkIcon9.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 9;
			try
			{
				if (Form3.<>o__34.<>p__3 == null)
				{
					Form3.<>o__34.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__34.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__34.<>p__3;
				if (Form3.<>o__34.<>p__2 == null)
				{
					Form3.<>o__34.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__34.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__34.<>p__2;
				if (Form3.<>o__34.<>p__1 == null)
				{
					Form3.<>o__34.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__34.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__34.<>p__1;
				if (Form3.<>o__34.<>p__0 == null)
				{
					Form3.<>o__34.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__34.<>p__0.Target(Form3.<>o__34.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00008FE4 File Offset: 0x000071E4
	private void linkIcon10_Click(object sender, EventArgs e)
	{
		if (this.linkIcon10.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 10;
			try
			{
				if (Form3.<>o__35.<>p__3 == null)
				{
					Form3.<>o__35.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__35.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__35.<>p__3;
				if (Form3.<>o__35.<>p__2 == null)
				{
					Form3.<>o__35.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__35.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__35.<>p__2;
				if (Form3.<>o__35.<>p__1 == null)
				{
					Form3.<>o__35.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__35.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__35.<>p__1;
				if (Form3.<>o__35.<>p__0 == null)
				{
					Form3.<>o__35.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__35.<>p__0.Target(Form3.<>o__35.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000091E4 File Offset: 0x000073E4
	private void linkIcon11_Click(object sender, EventArgs e)
	{
		if (this.linkIcon11.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 11;
			try
			{
				if (Form3.<>o__36.<>p__3 == null)
				{
					Form3.<>o__36.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__36.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__36.<>p__3;
				if (Form3.<>o__36.<>p__2 == null)
				{
					Form3.<>o__36.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__36.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__36.<>p__2;
				if (Form3.<>o__36.<>p__1 == null)
				{
					Form3.<>o__36.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__36.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__36.<>p__1;
				if (Form3.<>o__36.<>p__0 == null)
				{
					Form3.<>o__36.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__36.<>p__0.Target(Form3.<>o__36.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000093E4 File Offset: 0x000075E4
	private void linkIcon12_Click(object sender, EventArgs e)
	{
		if (this.linkIcon12.Cursor == Cursors.Hand)
		{
			string fileName = "";
			int num = 12;
			try
			{
				if (Form3.<>o__37.<>p__3 == null)
				{
					Form3.<>o__37.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form3)));
				}
				Func<CallSite, object, string> target = Form3.<>o__37.<>p__3.Target;
				CallSite <>p__ = Form3.<>o__37.<>p__3;
				if (Form3.<>o__37.<>p__2 == null)
				{
					Form3.<>o__37.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Form3.<>o__37.<>p__2.Target;
				CallSite <>p__2 = Form3.<>o__37.<>p__2;
				if (Form3.<>o__37.<>p__1 == null)
				{
					Form3.<>o__37.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = Form3.<>o__37.<>p__1.Target;
				CallSite <>p__3 = Form3.<>o__37.<>p__1;
				if (Form3.<>o__37.<>p__0 == null)
				{
					Form3.<>o__37.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				fileName = target(<>p__, target2(<>p__2, target3(<>p__3, Form3.<>o__37.<>p__0.Target(Form3.<>o__37.<>p__0, this.object_0, "links"), num - 1), "url"));
				this.int_0[num - 1] = 2;
			}
			catch (Exception)
			{
				MessageBox.Show("Json getirilirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_1();
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_4();
			this.timer_1.Start();
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000095E4 File Offset: 0x000077E4
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.int_2++;
		int num = 0;
		int[] array = this.int_0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == 3)
			{
				num++;
			}
		}
		int num2 = num;
		if (Form3.<>o__38.<>p__1 == null)
		{
			Form3.<>o__38.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Form3)));
		}
		Func<CallSite, object, int> target = Form3.<>o__38.<>p__1.Target;
		CallSite <>p__ = Form3.<>o__38.<>p__1;
		if (Form3.<>o__38.<>p__0 == null)
		{
			Form3.<>o__38.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		if (num2 >= target(<>p__, Form3.<>o__38.<>p__0.Target(Form3.<>o__38.<>p__0, this.object_0, "linkCountForDone")))
		{
			this.timer_1.Stop();
			Class0.smethod_0(string.Concat(new string[]
			{
				"https://hilebol.space/linkApprove/finish.php?hwid=",
				Class0.form1_0.string_2,
				"&t=",
				this.int_2.ToString(),
				"&o=",
				this.int_1.ToString(),
				"&s=bolwall"
			}), 5000);
			base.TopMost = false;
			this.method_2();
			base.Size = new Size(455, 510);
			this.altPanel.Location = new Point(45, 356);
			this.linkApprovePanel.Visible = false;
			this.downloadLinkPanel.Visible = true;
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000227B File Offset: 0x0000047B
	private void ustteTutButton_Click(object sender, EventArgs e)
	{
		base.TopMost = !base.TopMost;
		if (base.TopMost)
		{
			this.ustteTutButton.Text = "Üstte Tut ✖";
			return;
		}
		this.ustteTutButton.Text = "Üstte Tut";
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000977C File Offset: 0x0000797C
	private void timer_2_Tick(object sender, EventArgs e)
	{
		try
		{
			this.string_0 = this.method_3();
			if (this.int_0[0] == 2 && !this.bool_0[0])
			{
				if (Form3.<>o__40.<>p__4 == null)
				{
					Form3.<>o__40.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = Form3.<>o__40.<>p__4.Target;
				CallSite <>p__ = Form3.<>o__40.<>p__4;
				if (Form3.<>o__40.<>p__3 == null)
				{
					Form3.<>o__40.<>p__3 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target2 = Form3.<>o__40.<>p__3.Target;
				CallSite <>p__2 = Form3.<>o__40.<>p__3;
				string arg = this.string_0;
				if (Form3.<>o__40.<>p__2 == null)
				{
					Form3.<>o__40.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = Form3.<>o__40.<>p__2.Target;
				CallSite <>p__3 = Form3.<>o__40.<>p__2;
				if (Form3.<>o__40.<>p__1 == null)
				{
					Form3.<>o__40.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target4 = Form3.<>o__40.<>p__1.Target;
				CallSite <>p__4 = Form3.<>o__40.<>p__1;
				if (Form3.<>o__40.<>p__0 == null)
				{
					Form3.<>o__40.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(<>p__, target2(<>p__2, arg, target3(<>p__3, target4(<>p__4, Form3.<>o__40.<>p__0.Target(Form3.<>o__40.<>p__0, this.object_0, "links"), 0), "code"))))
				{
					this.int_0[0] = 3;
					this.bool_0[0] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=1&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[1] == 2 && !this.bool_0[1])
			{
				if (Form3.<>o__40.<>p__9 == null)
				{
					Form3.<>o__40.<>p__9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target5 = Form3.<>o__40.<>p__9.Target;
				CallSite <>p__5 = Form3.<>o__40.<>p__9;
				if (Form3.<>o__40.<>p__8 == null)
				{
					Form3.<>o__40.<>p__8 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target6 = Form3.<>o__40.<>p__8.Target;
				CallSite <>p__6 = Form3.<>o__40.<>p__8;
				string arg2 = this.string_0;
				if (Form3.<>o__40.<>p__7 == null)
				{
					Form3.<>o__40.<>p__7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target7 = Form3.<>o__40.<>p__7.Target;
				CallSite <>p__7 = Form3.<>o__40.<>p__7;
				if (Form3.<>o__40.<>p__6 == null)
				{
					Form3.<>o__40.<>p__6 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target8 = Form3.<>o__40.<>p__6.Target;
				CallSite <>p__8 = Form3.<>o__40.<>p__6;
				if (Form3.<>o__40.<>p__5 == null)
				{
					Form3.<>o__40.<>p__5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target5(<>p__5, target6(<>p__6, arg2, target7(<>p__7, target8(<>p__8, Form3.<>o__40.<>p__5.Target(Form3.<>o__40.<>p__5, this.object_0, "links"), 1), "code"))))
				{
					this.int_0[1] = 3;
					this.bool_0[1] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=2&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[2] == 2 && !this.bool_0[2])
			{
				if (Form3.<>o__40.<>p__14 == null)
				{
					Form3.<>o__40.<>p__14 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target9 = Form3.<>o__40.<>p__14.Target;
				CallSite <>p__9 = Form3.<>o__40.<>p__14;
				if (Form3.<>o__40.<>p__13 == null)
				{
					Form3.<>o__40.<>p__13 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target10 = Form3.<>o__40.<>p__13.Target;
				CallSite <>p__10 = Form3.<>o__40.<>p__13;
				string arg3 = this.string_0;
				if (Form3.<>o__40.<>p__12 == null)
				{
					Form3.<>o__40.<>p__12 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target11 = Form3.<>o__40.<>p__12.Target;
				CallSite <>p__11 = Form3.<>o__40.<>p__12;
				if (Form3.<>o__40.<>p__11 == null)
				{
					Form3.<>o__40.<>p__11 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target12 = Form3.<>o__40.<>p__11.Target;
				CallSite <>p__12 = Form3.<>o__40.<>p__11;
				if (Form3.<>o__40.<>p__10 == null)
				{
					Form3.<>o__40.<>p__10 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target9(<>p__9, target10(<>p__10, arg3, target11(<>p__11, target12(<>p__12, Form3.<>o__40.<>p__10.Target(Form3.<>o__40.<>p__10, this.object_0, "links"), 2), "code"))))
				{
					this.int_0[2] = 3;
					this.bool_0[2] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=3&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[3] == 2 && !this.bool_0[3])
			{
				if (Form3.<>o__40.<>p__19 == null)
				{
					Form3.<>o__40.<>p__19 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target13 = Form3.<>o__40.<>p__19.Target;
				CallSite <>p__13 = Form3.<>o__40.<>p__19;
				if (Form3.<>o__40.<>p__18 == null)
				{
					Form3.<>o__40.<>p__18 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target14 = Form3.<>o__40.<>p__18.Target;
				CallSite <>p__14 = Form3.<>o__40.<>p__18;
				string arg4 = this.string_0;
				if (Form3.<>o__40.<>p__17 == null)
				{
					Form3.<>o__40.<>p__17 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target15 = Form3.<>o__40.<>p__17.Target;
				CallSite <>p__15 = Form3.<>o__40.<>p__17;
				if (Form3.<>o__40.<>p__16 == null)
				{
					Form3.<>o__40.<>p__16 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target16 = Form3.<>o__40.<>p__16.Target;
				CallSite <>p__16 = Form3.<>o__40.<>p__16;
				if (Form3.<>o__40.<>p__15 == null)
				{
					Form3.<>o__40.<>p__15 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target13(<>p__13, target14(<>p__14, arg4, target15(<>p__15, target16(<>p__16, Form3.<>o__40.<>p__15.Target(Form3.<>o__40.<>p__15, this.object_0, "links"), 3), "code"))))
				{
					this.int_0[3] = 3;
					this.bool_0[3] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=4&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[4] == 2 && !this.bool_0[4])
			{
				if (Form3.<>o__40.<>p__24 == null)
				{
					Form3.<>o__40.<>p__24 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target17 = Form3.<>o__40.<>p__24.Target;
				CallSite <>p__17 = Form3.<>o__40.<>p__24;
				if (Form3.<>o__40.<>p__23 == null)
				{
					Form3.<>o__40.<>p__23 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target18 = Form3.<>o__40.<>p__23.Target;
				CallSite <>p__18 = Form3.<>o__40.<>p__23;
				string arg5 = this.string_0;
				if (Form3.<>o__40.<>p__22 == null)
				{
					Form3.<>o__40.<>p__22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target19 = Form3.<>o__40.<>p__22.Target;
				CallSite <>p__19 = Form3.<>o__40.<>p__22;
				if (Form3.<>o__40.<>p__21 == null)
				{
					Form3.<>o__40.<>p__21 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target20 = Form3.<>o__40.<>p__21.Target;
				CallSite <>p__20 = Form3.<>o__40.<>p__21;
				if (Form3.<>o__40.<>p__20 == null)
				{
					Form3.<>o__40.<>p__20 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target17(<>p__17, target18(<>p__18, arg5, target19(<>p__19, target20(<>p__20, Form3.<>o__40.<>p__20.Target(Form3.<>o__40.<>p__20, this.object_0, "links"), 4), "code"))))
				{
					this.int_0[4] = 3;
					this.bool_0[4] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=5&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[5] == 2 && !this.bool_0[5])
			{
				if (Form3.<>o__40.<>p__29 == null)
				{
					Form3.<>o__40.<>p__29 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target21 = Form3.<>o__40.<>p__29.Target;
				CallSite <>p__21 = Form3.<>o__40.<>p__29;
				if (Form3.<>o__40.<>p__28 == null)
				{
					Form3.<>o__40.<>p__28 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target22 = Form3.<>o__40.<>p__28.Target;
				CallSite <>p__22 = Form3.<>o__40.<>p__28;
				string arg6 = this.string_0;
				if (Form3.<>o__40.<>p__27 == null)
				{
					Form3.<>o__40.<>p__27 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target23 = Form3.<>o__40.<>p__27.Target;
				CallSite <>p__23 = Form3.<>o__40.<>p__27;
				if (Form3.<>o__40.<>p__26 == null)
				{
					Form3.<>o__40.<>p__26 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target24 = Form3.<>o__40.<>p__26.Target;
				CallSite <>p__24 = Form3.<>o__40.<>p__26;
				if (Form3.<>o__40.<>p__25 == null)
				{
					Form3.<>o__40.<>p__25 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target21(<>p__21, target22(<>p__22, arg6, target23(<>p__23, target24(<>p__24, Form3.<>o__40.<>p__25.Target(Form3.<>o__40.<>p__25, this.object_0, "links"), 5), "code"))))
				{
					this.int_0[5] = 3;
					this.bool_0[5] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=6&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[6] == 2 && !this.bool_0[6])
			{
				if (Form3.<>o__40.<>p__34 == null)
				{
					Form3.<>o__40.<>p__34 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target25 = Form3.<>o__40.<>p__34.Target;
				CallSite <>p__25 = Form3.<>o__40.<>p__34;
				if (Form3.<>o__40.<>p__33 == null)
				{
					Form3.<>o__40.<>p__33 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target26 = Form3.<>o__40.<>p__33.Target;
				CallSite <>p__26 = Form3.<>o__40.<>p__33;
				string arg7 = this.string_0;
				if (Form3.<>o__40.<>p__32 == null)
				{
					Form3.<>o__40.<>p__32 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target27 = Form3.<>o__40.<>p__32.Target;
				CallSite <>p__27 = Form3.<>o__40.<>p__32;
				if (Form3.<>o__40.<>p__31 == null)
				{
					Form3.<>o__40.<>p__31 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target28 = Form3.<>o__40.<>p__31.Target;
				CallSite <>p__28 = Form3.<>o__40.<>p__31;
				if (Form3.<>o__40.<>p__30 == null)
				{
					Form3.<>o__40.<>p__30 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target25(<>p__25, target26(<>p__26, arg7, target27(<>p__27, target28(<>p__28, Form3.<>o__40.<>p__30.Target(Form3.<>o__40.<>p__30, this.object_0, "links"), 6), "code"))))
				{
					this.int_0[6] = 3;
					this.bool_0[6] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=7&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[7] == 2 && !this.bool_0[7])
			{
				if (Form3.<>o__40.<>p__39 == null)
				{
					Form3.<>o__40.<>p__39 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target29 = Form3.<>o__40.<>p__39.Target;
				CallSite <>p__29 = Form3.<>o__40.<>p__39;
				if (Form3.<>o__40.<>p__38 == null)
				{
					Form3.<>o__40.<>p__38 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target30 = Form3.<>o__40.<>p__38.Target;
				CallSite <>p__30 = Form3.<>o__40.<>p__38;
				string arg8 = this.string_0;
				if (Form3.<>o__40.<>p__37 == null)
				{
					Form3.<>o__40.<>p__37 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target31 = Form3.<>o__40.<>p__37.Target;
				CallSite <>p__31 = Form3.<>o__40.<>p__37;
				if (Form3.<>o__40.<>p__36 == null)
				{
					Form3.<>o__40.<>p__36 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target32 = Form3.<>o__40.<>p__36.Target;
				CallSite <>p__32 = Form3.<>o__40.<>p__36;
				if (Form3.<>o__40.<>p__35 == null)
				{
					Form3.<>o__40.<>p__35 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target29(<>p__29, target30(<>p__30, arg8, target31(<>p__31, target32(<>p__32, Form3.<>o__40.<>p__35.Target(Form3.<>o__40.<>p__35, this.object_0, "links"), 7), "code"))))
				{
					this.int_0[7] = 3;
					this.bool_0[7] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=8&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[8] == 2 && !this.bool_0[8])
			{
				if (Form3.<>o__40.<>p__44 == null)
				{
					Form3.<>o__40.<>p__44 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target33 = Form3.<>o__40.<>p__44.Target;
				CallSite <>p__33 = Form3.<>o__40.<>p__44;
				if (Form3.<>o__40.<>p__43 == null)
				{
					Form3.<>o__40.<>p__43 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target34 = Form3.<>o__40.<>p__43.Target;
				CallSite <>p__34 = Form3.<>o__40.<>p__43;
				string arg9 = this.string_0;
				if (Form3.<>o__40.<>p__42 == null)
				{
					Form3.<>o__40.<>p__42 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target35 = Form3.<>o__40.<>p__42.Target;
				CallSite <>p__35 = Form3.<>o__40.<>p__42;
				if (Form3.<>o__40.<>p__41 == null)
				{
					Form3.<>o__40.<>p__41 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target36 = Form3.<>o__40.<>p__41.Target;
				CallSite <>p__36 = Form3.<>o__40.<>p__41;
				if (Form3.<>o__40.<>p__40 == null)
				{
					Form3.<>o__40.<>p__40 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target33(<>p__33, target34(<>p__34, arg9, target35(<>p__35, target36(<>p__36, Form3.<>o__40.<>p__40.Target(Form3.<>o__40.<>p__40, this.object_0, "links"), 8), "code"))))
				{
					this.int_0[8] = 3;
					this.bool_0[8] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=9&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[9] == 2 && !this.bool_0[9])
			{
				if (Form3.<>o__40.<>p__49 == null)
				{
					Form3.<>o__40.<>p__49 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target37 = Form3.<>o__40.<>p__49.Target;
				CallSite <>p__37 = Form3.<>o__40.<>p__49;
				if (Form3.<>o__40.<>p__48 == null)
				{
					Form3.<>o__40.<>p__48 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target38 = Form3.<>o__40.<>p__48.Target;
				CallSite <>p__38 = Form3.<>o__40.<>p__48;
				string arg10 = this.string_0;
				if (Form3.<>o__40.<>p__47 == null)
				{
					Form3.<>o__40.<>p__47 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target39 = Form3.<>o__40.<>p__47.Target;
				CallSite <>p__39 = Form3.<>o__40.<>p__47;
				if (Form3.<>o__40.<>p__46 == null)
				{
					Form3.<>o__40.<>p__46 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target40 = Form3.<>o__40.<>p__46.Target;
				CallSite <>p__40 = Form3.<>o__40.<>p__46;
				if (Form3.<>o__40.<>p__45 == null)
				{
					Form3.<>o__40.<>p__45 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target37(<>p__37, target38(<>p__38, arg10, target39(<>p__39, target40(<>p__40, Form3.<>o__40.<>p__45.Target(Form3.<>o__40.<>p__45, this.object_0, "links"), 9), "code"))))
				{
					this.int_0[9] = 3;
					this.bool_0[9] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=10&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[10] == 2 && !this.bool_0[10])
			{
				if (Form3.<>o__40.<>p__54 == null)
				{
					Form3.<>o__40.<>p__54 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target41 = Form3.<>o__40.<>p__54.Target;
				CallSite <>p__41 = Form3.<>o__40.<>p__54;
				if (Form3.<>o__40.<>p__53 == null)
				{
					Form3.<>o__40.<>p__53 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target42 = Form3.<>o__40.<>p__53.Target;
				CallSite <>p__42 = Form3.<>o__40.<>p__53;
				string arg11 = this.string_0;
				if (Form3.<>o__40.<>p__52 == null)
				{
					Form3.<>o__40.<>p__52 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target43 = Form3.<>o__40.<>p__52.Target;
				CallSite <>p__43 = Form3.<>o__40.<>p__52;
				if (Form3.<>o__40.<>p__51 == null)
				{
					Form3.<>o__40.<>p__51 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target44 = Form3.<>o__40.<>p__51.Target;
				CallSite <>p__44 = Form3.<>o__40.<>p__51;
				if (Form3.<>o__40.<>p__50 == null)
				{
					Form3.<>o__40.<>p__50 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target41(<>p__41, target42(<>p__42, arg11, target43(<>p__43, target44(<>p__44, Form3.<>o__40.<>p__50.Target(Form3.<>o__40.<>p__50, this.object_0, "links"), 10), "code"))))
				{
					this.int_0[10] = 3;
					this.bool_0[10] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=11&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
			if (this.int_0[11] == 2 && !this.bool_0[11])
			{
				if (Form3.<>o__40.<>p__59 == null)
				{
					Form3.<>o__40.<>p__59 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target45 = Form3.<>o__40.<>p__59.Target;
				CallSite <>p__45 = Form3.<>o__40.<>p__59;
				if (Form3.<>o__40.<>p__58 == null)
				{
					Form3.<>o__40.<>p__58 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> target46 = Form3.<>o__40.<>p__58.Target;
				CallSite <>p__46 = Form3.<>o__40.<>p__58;
				string arg12 = this.string_0;
				if (Form3.<>o__40.<>p__57 == null)
				{
					Form3.<>o__40.<>p__57 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target47 = Form3.<>o__40.<>p__57.Target;
				CallSite <>p__47 = Form3.<>o__40.<>p__57;
				if (Form3.<>o__40.<>p__56 == null)
				{
					Form3.<>o__40.<>p__56 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target48 = Form3.<>o__40.<>p__56.Target;
				CallSite <>p__48 = Form3.<>o__40.<>p__56;
				if (Form3.<>o__40.<>p__55 == null)
				{
					Form3.<>o__40.<>p__55 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Form3), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target45(<>p__45, target46(<>p__46, arg12, target47(<>p__47, target48(<>p__48, Form3.<>o__40.<>p__55.Target(Form3.<>o__40.<>p__55, this.object_0, "links"), 11), "code"))))
				{
					this.int_0[11] = 3;
					this.bool_0[11] = true;
					Class0.smethod_0("https://hilebol.space/linkApprove/log.php?hwid=" + Class0.form1_0.string_2 + "&shid=12&s=bolwall", 2000);
					this.int_1++;
					this.method_4();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000B01C File Offset: 0x0000921C
	private void linkOnayiNasilYapilirButton_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://hilebol.space/mylinks/link-onayi-csgo.php");
		}
		catch (Exception)
		{
			MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000022B5 File Offset: 0x000004B5
	private void downButton_MouseEnter(object sender, EventArgs e)
	{
		this.downButton.BackColor = Color.FromArgb(23, 127, 236);
		this.downButton.ForeColor = Color.White;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000022E0 File Offset: 0x000004E0
	private void downButton_MouseLeave(object sender, EventArgs e)
	{
		this.downButton.BackColor = Color.FromArgb(28, 117, 239);
		this.downButton.ForeColor = Color.FromArgb(241, 242, 246);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000231A File Offset: 0x0000051A
	private void warningButton_MouseEnter(object sender, EventArgs e)
	{
		this.warningButton.BackColor = Color.FromArgb(245, 248, 248);
		this.warningButton.ForeColor = Color.FromArgb(28, 117, 239);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002354 File Offset: 0x00000554
	private void warningButton_MouseLeave(object sender, EventArgs e)
	{
		this.warningButton.BackColor = Color.FromArgb(241, 242, 246);
		this.warningButton.ForeColor = Color.FromArgb(47, 53, 66);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000B05C File Offset: 0x0000925C
	private void ImageCSBOL_Click(object sender, EventArgs e)
	{
		this.int_3++;
		if (this.int_3 >= 5)
		{
			this.int_3 = 0;
			if (MessageBox.Show(Class0.form1_0.string_2 + Environment.NewLine + "HWID numaranızı kopyalamak istiyor musunuz?", "Hile Bol HWID", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				Clipboard.SetText(Class0.form1_0.string_2);
				MessageBox.Show("HWID kopyalandı.", "Hile Bol HWID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}

	// Token: 0x04000034 RID: 52
	public int[] int_0 = new int[]
	{
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1
	};

	// Token: 0x04000035 RID: 53
	public bool[] bool_0 = new bool[12];

	// Token: 0x04000036 RID: 54
	private int int_1;

	// Token: 0x04000037 RID: 55
	[Dynamic]
	private dynamic object_0;

	// Token: 0x04000038 RID: 56
	private string string_0 = "";

	// Token: 0x04000039 RID: 57
	private int int_2;

	// Token: 0x0400003A RID: 58
	private int int_3;
}
