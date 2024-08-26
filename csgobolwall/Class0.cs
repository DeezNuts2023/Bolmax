using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

// Token: 0x02000015 RID: 21
internal static class Class0
{
	// Token: 0x06000042 RID: 66 RVA: 0x000023AA File Offset: 0x000005AA
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Class0.form1_0 = new Form1();
		Application.Run(Class0.form1_0);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
	public static string smethod_0(string string_0, int int_0)
	{
		string text = "";
		WebRequest webRequest = WebRequest.Create(string_0);
		webRequest.Method = "GET";
		webRequest.Timeout = int_0;
		try
		{
			StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
			text = streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (WebException ex)
		{
			if (ex.Status == WebExceptionStatus.Timeout)
			{
				text = "TIMEOUT";
			}
			else
			{
				text = "TIMEOUT";
			}
		}
		return text.Trim();
	}

	// Token: 0x04000180 RID: 384
	public static Form1 form1_0;
}
