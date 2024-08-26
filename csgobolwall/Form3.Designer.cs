// Token: 0x02000005 RID: 5
public partial class Form3 : global::System.Windows.Forms.Form
{
	// Token: 0x06000040 RID: 64 RVA: 0x0000238B File Offset: 0x0000058B
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0000B0D4 File Offset: 0x000092D4
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Form3));
		this.infoLabel = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.linkLabel1 = new global::System.Windows.Forms.Label();
		this.linkApprovePanel = new global::System.Windows.Forms.Panel();
		this.ustteTutButton = new global::System.Windows.Forms.Label();
		this.linkOnayiNasilYapilirButton = new global::System.Windows.Forms.Label();
		this.onayPeriyoduLabel = new global::System.Windows.Forms.Label();
		this.linkIcon12 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel12 = new global::System.Windows.Forms.Label();
		this.linkIcon9 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel9 = new global::System.Windows.Forms.Label();
		this.linkIcon6 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel6 = new global::System.Windows.Forms.Label();
		this.linkIcon3 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel3 = new global::System.Windows.Forms.Label();
		this.linkIcon11 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel11 = new global::System.Windows.Forms.Label();
		this.linkIcon8 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel8 = new global::System.Windows.Forms.Label();
		this.linkIcon5 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel5 = new global::System.Windows.Forms.Label();
		this.linkIcon2 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel2 = new global::System.Windows.Forms.Label();
		this.linkIcon10 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel10 = new global::System.Windows.Forms.Label();
		this.linkIcon7 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel7 = new global::System.Windows.Forms.Label();
		this.linkIcon4 = new global::System.Windows.Forms.PictureBox();
		this.linkLabel4 = new global::System.Windows.Forms.Label();
		this.linkIcon1 = new global::System.Windows.Forms.PictureBox();
		this.son24SaatLabel = new global::System.Windows.Forms.Label();
		this.downloadLinkPanel = new global::System.Windows.Forms.Panel();
		this.warningButton = new global::System.Windows.Forms.Label();
		this.downButton = new global::System.Windows.Forms.Label();
		this.altPanel = new global::System.Windows.Forms.Panel();
		this.ImageYoutube = new global::System.Windows.Forms.PictureBox();
		this.ImageHilebol = new global::System.Windows.Forms.PictureBox();
		this.ImageFacebook = new global::System.Windows.Forms.PictureBox();
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_2 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.ImageCSBOL = new global::System.Windows.Forms.PictureBox();
		this.ImageLoading = new global::System.Windows.Forms.PictureBox();
		this.linkApprovePanel.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon12).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon9).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon6).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon3).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon11).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon8).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon5).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon2).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon10).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon7).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon4).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon1).BeginInit();
		this.downloadLinkPanel.SuspendLayout();
		this.altPanel.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ImageYoutube).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageHilebol).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageFacebook).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageCSBOL).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageLoading).BeginInit();
		base.SuspendLayout();
		this.infoLabel.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.infoLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.infoLabel.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.infoLabel.Location = new global::System.Drawing.Point(2, 85);
		this.infoLabel.Name = "infoLabel";
		this.infoLabel.Size = new global::System.Drawing.Size(355, 79);
		this.infoLabel.TabIndex = 98;
		this.infoLabel.Text = "Her gün 00:00'da hile linki güncellenmektedir.\r\nYasaklanmamak için güncel dosyayı kullanmalısınız.\r\nRisklerden hilebol sorumlu tutulamaz.";
		this.infoLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.timer_0.Interval = 1;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.linkLabel1.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel1.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel1.Location = new global::System.Drawing.Point(2, 2);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel1.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel1.TabIndex = 0;
		this.linkLabel1.Text = "LINK A";
		this.linkLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkApprovePanel.Controls.Add(this.ustteTutButton);
		this.linkApprovePanel.Controls.Add(this.linkOnayiNasilYapilirButton);
		this.linkApprovePanel.Controls.Add(this.onayPeriyoduLabel);
		this.linkApprovePanel.Controls.Add(this.linkIcon12);
		this.linkApprovePanel.Controls.Add(this.linkLabel12);
		this.linkApprovePanel.Controls.Add(this.linkIcon9);
		this.linkApprovePanel.Controls.Add(this.linkLabel9);
		this.linkApprovePanel.Controls.Add(this.linkIcon6);
		this.linkApprovePanel.Controls.Add(this.linkLabel6);
		this.linkApprovePanel.Controls.Add(this.linkIcon3);
		this.linkApprovePanel.Controls.Add(this.linkLabel3);
		this.linkApprovePanel.Controls.Add(this.linkIcon11);
		this.linkApprovePanel.Controls.Add(this.linkLabel11);
		this.linkApprovePanel.Controls.Add(this.linkIcon8);
		this.linkApprovePanel.Controls.Add(this.linkLabel8);
		this.linkApprovePanel.Controls.Add(this.linkIcon5);
		this.linkApprovePanel.Controls.Add(this.linkLabel5);
		this.linkApprovePanel.Controls.Add(this.linkIcon2);
		this.linkApprovePanel.Controls.Add(this.linkLabel2);
		this.linkApprovePanel.Controls.Add(this.linkIcon10);
		this.linkApprovePanel.Controls.Add(this.linkLabel10);
		this.linkApprovePanel.Controls.Add(this.linkIcon7);
		this.linkApprovePanel.Controls.Add(this.linkLabel7);
		this.linkApprovePanel.Controls.Add(this.linkIcon4);
		this.linkApprovePanel.Controls.Add(this.linkLabel4);
		this.linkApprovePanel.Controls.Add(this.linkIcon1);
		this.linkApprovePanel.Controls.Add(this.linkLabel1);
		this.linkApprovePanel.Location = new global::System.Drawing.Point(429, 166);
		this.linkApprovePanel.Name = "linkApprovePanel";
		this.linkApprovePanel.Size = new global::System.Drawing.Size(359, 227);
		this.linkApprovePanel.TabIndex = 101;
		this.linkApprovePanel.Visible = false;
		this.ustteTutButton.BackColor = global::System.Drawing.Color.FromArgb(241, 242, 246);
		this.ustteTutButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.ustteTutButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.ustteTutButton.ForeColor = global::System.Drawing.Color.FromArgb(28, 117, 239);
		this.ustteTutButton.Location = new global::System.Drawing.Point(235, 197);
		this.ustteTutButton.Name = "ustteTutButton";
		this.ustteTutButton.Padding = new global::System.Windows.Forms.Padding(5);
		this.ustteTutButton.Size = new global::System.Drawing.Size(123, 28);
		this.ustteTutButton.TabIndex = 29;
		this.ustteTutButton.Text = "Üstte Tut";
		this.ustteTutButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.ustteTutButton.Click += new global::System.EventHandler(this.ustteTutButton_Click);
		this.ustteTutButton.MouseEnter += new global::System.EventHandler(this.ustteTutButton_MouseEnter);
		this.ustteTutButton.MouseLeave += new global::System.EventHandler(this.ustteTutButton_MouseLeave);
		this.linkOnayiNasilYapilirButton.BackColor = global::System.Drawing.Color.FromArgb(28, 117, 239);
		this.linkOnayiNasilYapilirButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkOnayiNasilYapilirButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkOnayiNasilYapilirButton.ForeColor = global::System.Drawing.Color.FromArgb(241, 242, 246);
		this.linkOnayiNasilYapilirButton.Location = new global::System.Drawing.Point(1, 197);
		this.linkOnayiNasilYapilirButton.Name = "linkOnayiNasilYapilirButton";
		this.linkOnayiNasilYapilirButton.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkOnayiNasilYapilirButton.Size = new global::System.Drawing.Size(228, 28);
		this.linkOnayiNasilYapilirButton.TabIndex = 28;
		this.linkOnayiNasilYapilirButton.Text = "Link onayı nasıl yapılır? [▶️]";
		this.linkOnayiNasilYapilirButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkOnayiNasilYapilirButton.Click += new global::System.EventHandler(this.linkOnayiNasilYapilirButton_Click);
		this.linkOnayiNasilYapilirButton.MouseEnter += new global::System.EventHandler(this.linkOnayiNasilYapilirButton_MouseEnter);
		this.linkOnayiNasilYapilirButton.MouseLeave += new global::System.EventHandler(this.linkOnayiNasilYapilirButton_MouseLeave);
		this.onayPeriyoduLabel.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.onayPeriyoduLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.onayPeriyoduLabel.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.onayPeriyoduLabel.Location = new global::System.Drawing.Point(1, 140);
		this.onayPeriyoduLabel.Name = "onayPeriyoduLabel";
		this.onayPeriyoduLabel.Padding = new global::System.Windows.Forms.Padding(5);
		this.onayPeriyoduLabel.Size = new global::System.Drawing.Size(357, 42);
		this.onayPeriyoduLabel.TabIndex = 26;
		this.onayPeriyoduLabel.Text = "Onay için 8 adet link geçişi yapmalısınız.\r\nOnay periyodu 24 saattir.";
		this.onayPeriyoduLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon12.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon12.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon12.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon12.Image");
		this.linkIcon12.Location = new global::System.Drawing.Point(328, 98);
		this.linkIcon12.Name = "linkIcon12";
		this.linkIcon12.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon12.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon12.TabIndex = 23;
		this.linkIcon12.TabStop = false;
		this.linkIcon12.Click += new global::System.EventHandler(this.linkIcon12_Click);
		this.linkLabel12.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel12.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel12.Location = new global::System.Drawing.Point(259, 98);
		this.linkLabel12.Name = "linkLabel12";
		this.linkLabel12.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel12.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel12.TabIndex = 22;
		this.linkLabel12.Text = "LINK A";
		this.linkLabel12.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon9.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon9.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon9.Image");
		this.linkIcon9.Location = new global::System.Drawing.Point(328, 66);
		this.linkIcon9.Name = "linkIcon9";
		this.linkIcon9.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon9.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon9.TabIndex = 21;
		this.linkIcon9.TabStop = false;
		this.linkIcon9.Click += new global::System.EventHandler(this.linkIcon9_Click);
		this.linkLabel9.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel9.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel9.Location = new global::System.Drawing.Point(259, 66);
		this.linkLabel9.Name = "linkLabel9";
		this.linkLabel9.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel9.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel9.TabIndex = 20;
		this.linkLabel9.Text = "LINK A";
		this.linkLabel9.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon6.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon6.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon6.Image");
		this.linkIcon6.Location = new global::System.Drawing.Point(328, 34);
		this.linkIcon6.Name = "linkIcon6";
		this.linkIcon6.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon6.TabIndex = 19;
		this.linkIcon6.TabStop = false;
		this.linkIcon6.Click += new global::System.EventHandler(this.linkIcon6_Click);
		this.linkLabel6.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel6.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel6.Location = new global::System.Drawing.Point(259, 34);
		this.linkLabel6.Name = "linkLabel6";
		this.linkLabel6.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel6.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel6.TabIndex = 18;
		this.linkLabel6.Text = "LINK A";
		this.linkLabel6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon3.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon3.Image = global::csgobolwall.Properties.Resources.link_open;
		this.linkIcon3.Location = new global::System.Drawing.Point(328, 2);
		this.linkIcon3.Name = "linkIcon3";
		this.linkIcon3.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon3.TabIndex = 17;
		this.linkIcon3.TabStop = false;
		this.linkIcon3.Click += new global::System.EventHandler(this.linkIcon3_Click);
		this.linkLabel3.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel3.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel3.Location = new global::System.Drawing.Point(259, 2);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel3.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel3.TabIndex = 16;
		this.linkLabel3.Text = "LINK A";
		this.linkLabel3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon11.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon11.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon11.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon11.Image");
		this.linkIcon11.Location = new global::System.Drawing.Point(199, 98);
		this.linkIcon11.Name = "linkIcon11";
		this.linkIcon11.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon11.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon11.TabIndex = 15;
		this.linkIcon11.TabStop = false;
		this.linkIcon11.Click += new global::System.EventHandler(this.linkIcon11_Click);
		this.linkLabel11.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel11.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel11.Location = new global::System.Drawing.Point(130, 98);
		this.linkLabel11.Name = "linkLabel11";
		this.linkLabel11.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel11.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel11.TabIndex = 14;
		this.linkLabel11.Text = "LINK A";
		this.linkLabel11.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon8.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon8.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon8.Image");
		this.linkIcon8.Location = new global::System.Drawing.Point(199, 66);
		this.linkIcon8.Name = "linkIcon8";
		this.linkIcon8.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon8.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon8.TabIndex = 13;
		this.linkIcon8.TabStop = false;
		this.linkIcon8.Click += new global::System.EventHandler(this.linkIcon8_Click);
		this.linkLabel8.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel8.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel8.Location = new global::System.Drawing.Point(130, 66);
		this.linkLabel8.Name = "linkLabel8";
		this.linkLabel8.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel8.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel8.TabIndex = 12;
		this.linkLabel8.Text = "LINK A";
		this.linkLabel8.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon5.BackColor = global::System.Drawing.Color.FromArgb(241, 242, 246);
		this.linkIcon5.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon5.Image");
		this.linkIcon5.Location = new global::System.Drawing.Point(199, 34);
		this.linkIcon5.Name = "linkIcon5";
		this.linkIcon5.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon5.TabIndex = 11;
		this.linkIcon5.TabStop = false;
		this.linkIcon5.Click += new global::System.EventHandler(this.linkIcon5_Click);
		this.linkLabel5.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel5.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel5.Location = new global::System.Drawing.Point(130, 34);
		this.linkLabel5.Name = "linkLabel5";
		this.linkLabel5.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel5.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel5.TabIndex = 10;
		this.linkLabel5.Text = "LINK A";
		this.linkLabel5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon2.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon2.Image = global::csgobolwall.Properties.Resources.link_open;
		this.linkIcon2.Location = new global::System.Drawing.Point(199, 2);
		this.linkIcon2.Name = "linkIcon2";
		this.linkIcon2.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon2.TabIndex = 9;
		this.linkIcon2.TabStop = false;
		this.linkIcon2.Click += new global::System.EventHandler(this.linkIcon2_Click);
		this.linkLabel2.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel2.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel2.Location = new global::System.Drawing.Point(130, 2);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel2.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel2.TabIndex = 8;
		this.linkLabel2.Text = "LINK A";
		this.linkLabel2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon10.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon10.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon10.Image");
		this.linkIcon10.Location = new global::System.Drawing.Point(71, 98);
		this.linkIcon10.Name = "linkIcon10";
		this.linkIcon10.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon10.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon10.TabIndex = 7;
		this.linkIcon10.TabStop = false;
		this.linkIcon10.Click += new global::System.EventHandler(this.linkIcon10_Click);
		this.linkLabel10.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel10.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel10.Location = new global::System.Drawing.Point(2, 98);
		this.linkLabel10.Name = "linkLabel10";
		this.linkLabel10.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel10.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel10.TabIndex = 6;
		this.linkLabel10.Text = "LINK A";
		this.linkLabel10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon7.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon7.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("linkIcon7.Image");
		this.linkIcon7.Location = new global::System.Drawing.Point(71, 66);
		this.linkIcon7.Name = "linkIcon7";
		this.linkIcon7.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon7.TabIndex = 5;
		this.linkIcon7.TabStop = false;
		this.linkIcon7.Click += new global::System.EventHandler(this.linkIcon7_Click);
		this.linkLabel7.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel7.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel7.Location = new global::System.Drawing.Point(2, 66);
		this.linkLabel7.Name = "linkLabel7";
		this.linkLabel7.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel7.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel7.TabIndex = 4;
		this.linkLabel7.Text = "LINK A";
		this.linkLabel7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon4.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon4.Image = global::csgobolwall.Properties.Resources.link_open;
		this.linkIcon4.Location = new global::System.Drawing.Point(71, 34);
		this.linkIcon4.Name = "linkIcon4";
		this.linkIcon4.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon4.TabIndex = 3;
		this.linkIcon4.TabStop = false;
		this.linkIcon4.Click += new global::System.EventHandler(this.linkIcon4_Click);
		this.linkLabel4.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.linkLabel4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.linkLabel4.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.linkLabel4.Location = new global::System.Drawing.Point(2, 34);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Padding = new global::System.Windows.Forms.Padding(5);
		this.linkLabel4.Size = new global::System.Drawing.Size(69, 28);
		this.linkLabel4.TabIndex = 2;
		this.linkLabel4.Text = "LINK A";
		this.linkLabel4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.linkIcon1.BackColor = global::System.Drawing.Color.FromArgb(244, 244, 246);
		this.linkIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.linkIcon1.Image = global::csgobolwall.Properties.Resources.link_open;
		this.linkIcon1.Location = new global::System.Drawing.Point(71, 2);
		this.linkIcon1.Name = "linkIcon1";
		this.linkIcon1.Size = new global::System.Drawing.Size(30, 28);
		this.linkIcon1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.linkIcon1.TabIndex = 1;
		this.linkIcon1.TabStop = false;
		this.linkIcon1.Click += new global::System.EventHandler(this.linkIcon1_Click);
		this.son24SaatLabel.BackColor = global::System.Drawing.Color.FromArgb(230, 230, 233);
		this.son24SaatLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.son24SaatLabel.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.son24SaatLabel.Location = new global::System.Drawing.Point(1, 69);
		this.son24SaatLabel.Name = "son24SaatLabel";
		this.son24SaatLabel.Padding = new global::System.Windows.Forms.Padding(5);
		this.son24SaatLabel.Size = new global::System.Drawing.Size(357, 28);
		this.son24SaatLabel.TabIndex = 30;
		this.son24SaatLabel.Text = "Son 24 saatte, seninle beraber {0} kişi buradaydı.";
		this.son24SaatLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.downloadLinkPanel.Controls.Add(this.warningButton);
		this.downloadLinkPanel.Controls.Add(this.infoLabel);
		this.downloadLinkPanel.Controls.Add(this.downButton);
		this.downloadLinkPanel.Location = new global::System.Drawing.Point(806, 166);
		this.downloadLinkPanel.Name = "downloadLinkPanel";
		this.downloadLinkPanel.Size = new global::System.Drawing.Size(359, 165);
		this.downloadLinkPanel.TabIndex = 103;
		this.downloadLinkPanel.Visible = false;
		this.warningButton.BackColor = global::System.Drawing.Color.FromArgb(241, 242, 246);
		this.warningButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.warningButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.warningButton.ForeColor = global::System.Drawing.Color.FromArgb(47, 53, 66);
		this.warningButton.Location = new global::System.Drawing.Point(2, 45);
		this.warningButton.Name = "warningButton";
		this.warningButton.Padding = new global::System.Windows.Forms.Padding(5);
		this.warningButton.Size = new global::System.Drawing.Size(355, 35);
		this.warningButton.TabIndex = 31;
		this.warningButton.Text = "ban yememek için uyarılar";
		this.warningButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.warningButton.Click += new global::System.EventHandler(this.warningButton_Click);
		this.warningButton.MouseEnter += new global::System.EventHandler(this.warningButton_MouseEnter);
		this.warningButton.MouseLeave += new global::System.EventHandler(this.warningButton_MouseLeave);
		this.downButton.BackColor = global::System.Drawing.Color.FromArgb(28, 117, 239);
		this.downButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.downButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f);
		this.downButton.ForeColor = global::System.Drawing.Color.FromArgb(241, 242, 246);
		this.downButton.Location = new global::System.Drawing.Point(2, 3);
		this.downButton.Name = "downButton";
		this.downButton.Padding = new global::System.Windows.Forms.Padding(5);
		this.downButton.Size = new global::System.Drawing.Size(355, 37);
		this.downButton.TabIndex = 30;
		this.downButton.Text = "--yükleniyor--";
		this.downButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.downButton.Click += new global::System.EventHandler(this.downButton_Click);
		this.downButton.MouseEnter += new global::System.EventHandler(this.downButton_MouseEnter);
		this.downButton.MouseLeave += new global::System.EventHandler(this.downButton_MouseLeave);
		this.altPanel.Controls.Add(this.ImageYoutube);
		this.altPanel.Controls.Add(this.ImageHilebol);
		this.altPanel.Controls.Add(this.ImageFacebook);
		this.altPanel.Controls.Add(this.son24SaatLabel);
		this.altPanel.Location = new global::System.Drawing.Point(806, 363);
		this.altPanel.Name = "altPanel";
		this.altPanel.Size = new global::System.Drawing.Size(359, 99);
		this.altPanel.TabIndex = 104;
		this.altPanel.Visible = false;
		this.ImageYoutube.BackColor = global::System.Drawing.Color.Transparent;
		this.ImageYoutube.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.ImageYoutube.Image = global::csgobolwall.Properties.Resources.youtube__2_2;
		this.ImageYoutube.Location = new global::System.Drawing.Point(327, 5);
		this.ImageYoutube.Name = "ImageYoutube";
		this.ImageYoutube.Size = new global::System.Drawing.Size(32, 32);
		this.ImageYoutube.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.ImageYoutube.TabIndex = 94;
		this.ImageYoutube.TabStop = false;
		this.ImageYoutube.Click += new global::System.EventHandler(this.ImageYoutube_Click);
		this.ImageHilebol.BackColor = global::System.Drawing.Color.Transparent;
		this.ImageHilebol.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.ImageHilebol.Image = global::csgobolwall.Properties.Resources.mini__;
		this.ImageHilebol.Location = new global::System.Drawing.Point(152, 1);
		this.ImageHilebol.Name = "ImageHilebol";
		this.ImageHilebol.Size = new global::System.Drawing.Size(56, 41);
		this.ImageHilebol.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.ImageHilebol.TabIndex = 95;
		this.ImageHilebol.TabStop = false;
		this.ImageHilebol.Click += new global::System.EventHandler(this.ImageHilebol_Click);
		this.ImageFacebook.BackColor = global::System.Drawing.Color.Transparent;
		this.ImageFacebook.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.ImageFacebook.Image = global::csgobolwall.Properties.Resources.facebook;
		this.ImageFacebook.Location = new global::System.Drawing.Point(1, 5);
		this.ImageFacebook.Name = "ImageFacebook";
		this.ImageFacebook.Size = new global::System.Drawing.Size(32, 32);
		this.ImageFacebook.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.ImageFacebook.TabIndex = 93;
		this.ImageFacebook.TabStop = false;
		this.ImageFacebook.Click += new global::System.EventHandler(this.ImageFacebook_Click);
		this.timer_1.Interval = 1000;
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		this.timer_2.Tick += new global::System.EventHandler(this.timer_2_Tick);
		this.ImageCSBOL.BackColor = global::System.Drawing.Color.Transparent;
		this.ImageCSBOL.Image = global::csgobolwall.Properties.Resources.csgobol_wall_hack;
		this.ImageCSBOL.Location = new global::System.Drawing.Point(45, 35);
		this.ImageCSBOL.Name = "ImageCSBOL";
		this.ImageCSBOL.Size = new global::System.Drawing.Size(359, 105);
		this.ImageCSBOL.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.ImageCSBOL.TabIndex = 91;
		this.ImageCSBOL.TabStop = false;
		this.ImageCSBOL.Click += new global::System.EventHandler(this.ImageCSBOL_Click);
		this.ImageLoading.BackColor = global::System.Drawing.Color.White;
		this.ImageLoading.Image = global::csgobolwall.Properties.Resources.opening_owl;
		this.ImageLoading.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
		this.ImageLoading.Location = new global::System.Drawing.Point(45, 166);
		this.ImageLoading.Name = "ImageLoading";
		this.ImageLoading.Size = new global::System.Drawing.Size(359, 271);
		this.ImageLoading.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.ImageLoading.TabIndex = 96;
		this.ImageLoading.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.ClientSize = new global::System.Drawing.Size(451, 522);
		base.Controls.Add(this.altPanel);
		base.Controls.Add(this.downloadLinkPanel);
		base.Controls.Add(this.ImageCSBOL);
		base.Controls.Add(this.linkApprovePanel);
		base.Controls.Add(this.ImageLoading);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Form3";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CSGOBOL WALL HACK";
		base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
		base.Load += new global::System.EventHandler(this.Form3_Load);
		this.linkApprovePanel.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon12).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon9).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon6).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon3).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon11).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon8).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon5).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon2).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon10).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon7).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon4).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.linkIcon1).EndInit();
		this.downloadLinkPanel.ResumeLayout(false);
		this.altPanel.ResumeLayout(false);
		this.altPanel.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ImageYoutube).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageHilebol).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageFacebook).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageCSBOL).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.ImageLoading).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400003B RID: 59
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x0400003C RID: 60
	internal global::System.Windows.Forms.Label infoLabel;

	// Token: 0x0400003D RID: 61
	internal global::System.Windows.Forms.Timer timer_0;

	// Token: 0x0400003E RID: 62
	internal global::System.Windows.Forms.PictureBox ImageFacebook;

	// Token: 0x0400003F RID: 63
	internal global::System.Windows.Forms.PictureBox ImageHilebol;

	// Token: 0x04000040 RID: 64
	internal global::System.Windows.Forms.PictureBox ImageCSBOL;

	// Token: 0x04000041 RID: 65
	internal global::System.Windows.Forms.PictureBox ImageYoutube;

	// Token: 0x04000042 RID: 66
	private global::System.Windows.Forms.Label linkLabel1;

	// Token: 0x04000043 RID: 67
	private global::System.Windows.Forms.Panel linkApprovePanel;

	// Token: 0x04000044 RID: 68
	private global::System.Windows.Forms.PictureBox linkIcon12;

	// Token: 0x04000045 RID: 69
	private global::System.Windows.Forms.Label linkLabel12;

	// Token: 0x04000046 RID: 70
	private global::System.Windows.Forms.PictureBox linkIcon9;

	// Token: 0x04000047 RID: 71
	private global::System.Windows.Forms.Label linkLabel9;

	// Token: 0x04000048 RID: 72
	private global::System.Windows.Forms.PictureBox linkIcon6;

	// Token: 0x04000049 RID: 73
	private global::System.Windows.Forms.Label linkLabel6;

	// Token: 0x0400004A RID: 74
	private global::System.Windows.Forms.PictureBox linkIcon3;

	// Token: 0x0400004B RID: 75
	private global::System.Windows.Forms.Label linkLabel3;

	// Token: 0x0400004C RID: 76
	private global::System.Windows.Forms.PictureBox linkIcon11;

	// Token: 0x0400004D RID: 77
	private global::System.Windows.Forms.Label linkLabel11;

	// Token: 0x0400004E RID: 78
	private global::System.Windows.Forms.PictureBox linkIcon8;

	// Token: 0x0400004F RID: 79
	private global::System.Windows.Forms.Label linkLabel8;

	// Token: 0x04000050 RID: 80
	private global::System.Windows.Forms.PictureBox linkIcon5;

	// Token: 0x04000051 RID: 81
	private global::System.Windows.Forms.Label linkLabel5;

	// Token: 0x04000052 RID: 82
	private global::System.Windows.Forms.PictureBox linkIcon2;

	// Token: 0x04000053 RID: 83
	private global::System.Windows.Forms.Label linkLabel2;

	// Token: 0x04000054 RID: 84
	private global::System.Windows.Forms.PictureBox linkIcon10;

	// Token: 0x04000055 RID: 85
	private global::System.Windows.Forms.Label linkLabel10;

	// Token: 0x04000056 RID: 86
	private global::System.Windows.Forms.PictureBox linkIcon7;

	// Token: 0x04000057 RID: 87
	private global::System.Windows.Forms.Label linkLabel7;

	// Token: 0x04000058 RID: 88
	private global::System.Windows.Forms.PictureBox linkIcon4;

	// Token: 0x04000059 RID: 89
	private global::System.Windows.Forms.Label linkLabel4;

	// Token: 0x0400005A RID: 90
	private global::System.Windows.Forms.PictureBox linkIcon1;

	// Token: 0x0400005B RID: 91
	private global::System.Windows.Forms.Label onayPeriyoduLabel;

	// Token: 0x0400005C RID: 92
	private global::System.Windows.Forms.Label ustteTutButton;

	// Token: 0x0400005D RID: 93
	private global::System.Windows.Forms.Label linkOnayiNasilYapilirButton;

	// Token: 0x0400005E RID: 94
	private global::System.Windows.Forms.Label son24SaatLabel;

	// Token: 0x0400005F RID: 95
	internal global::System.Windows.Forms.PictureBox ImageLoading;

	// Token: 0x04000060 RID: 96
	private global::System.Windows.Forms.Panel downloadLinkPanel;

	// Token: 0x04000061 RID: 97
	private global::System.Windows.Forms.Panel altPanel;

	// Token: 0x04000062 RID: 98
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x04000063 RID: 99
	private global::System.Windows.Forms.Timer timer_2;

	// Token: 0x04000064 RID: 100
	private global::System.Windows.Forms.Label warningButton;

	// Token: 0x04000065 RID: 101
	private global::System.Windows.Forms.Label downButton;
}
