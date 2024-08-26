// Token: 0x02000002 RID: 2
public partial class Form1 : global::System.Windows.Forms.Form
{
	// Token: 0x06000011 RID: 17 RVA: 0x00002105 File Offset: 0x00000305
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000036BC File Offset: 0x000018BC
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Form1));
		this.mevcutSurumLabel = new global::System.Windows.Forms.Label();
		this.AltLabel = new global::System.Windows.Forms.Label();
		this.TitleLabel = new global::System.Windows.Forms.Label();
		this.owlImage = new global::System.Windows.Forms.PictureBox();
		this.dotdot = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.exitLabel = new global::System.Windows.Forms.Label();
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		((global::System.ComponentModel.ISupportInitialize)this.owlImage).BeginInit();
		base.SuspendLayout();
		this.mevcutSurumLabel.BackColor = global::System.Drawing.Color.White;
		this.mevcutSurumLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
		this.mevcutSurumLabel.Location = new global::System.Drawing.Point(384, 132);
		this.mevcutSurumLabel.Name = "mevcutSurumLabel";
		this.mevcutSurumLabel.Size = new global::System.Drawing.Size(72, 17);
		this.mevcutSurumLabel.TabIndex = 9;
		this.mevcutSurumLabel.Text = "ver: 00";
		this.mevcutSurumLabel.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
		this.AltLabel.BackColor = global::System.Drawing.Color.White;
		this.AltLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
		this.AltLabel.Location = new global::System.Drawing.Point(13, 109);
		this.AltLabel.Name = "AltLabel";
		this.AltLabel.Size = new global::System.Drawing.Size(444, 23);
		this.AltLabel.TabIndex = 12;
		this.AltLabel.Text = "güncel sürüm kontrol ediliyor";
		this.AltLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.TitleLabel.BackColor = global::System.Drawing.Color.White;
		this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 12.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
		this.TitleLabel.Location = new global::System.Drawing.Point(13, 86);
		this.TitleLabel.Name = "TitleLabel";
		this.TitleLabel.Size = new global::System.Drawing.Size(444, 23);
		this.TitleLabel.TabIndex = 11;
		this.TitleLabel.Text = "HİLEBOL";
		this.TitleLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.owlImage.BackColor = global::System.Drawing.Color.White;
		this.owlImage.Image = global::csgobolwall.Properties.Resources.opening_owl;
		this.owlImage.Location = new global::System.Drawing.Point(193, 16);
		this.owlImage.Name = "owlImage";
		this.owlImage.Size = new global::System.Drawing.Size(83, 62);
		this.owlImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.owlImage.TabIndex = 10;
		this.owlImage.TabStop = false;
		this.dotdot.BackColor = global::System.Drawing.Color.White;
		this.dotdot.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
		this.dotdot.Location = new global::System.Drawing.Point(13, 128);
		this.dotdot.Name = "dotdot";
		this.dotdot.Size = new global::System.Drawing.Size(444, 23);
		this.dotdot.TabIndex = 13;
		this.dotdot.Text = "•••";
		this.dotdot.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.timer_0.Interval = 1;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.exitLabel.AutoSize = true;
		this.exitLabel.BackColor = global::System.Drawing.Color.White;
		this.exitLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.exitLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
		this.exitLabel.Location = new global::System.Drawing.Point(441, 9);
		this.exitLabel.Name = "exitLabel";
		this.exitLabel.Size = new global::System.Drawing.Size(16, 17);
		this.exitLabel.TabIndex = 15;
		this.exitLabel.Text = "X";
		this.exitLabel.Click += new global::System.EventHandler(this.exitLabel_Click);
		this.timer_1.Interval = 1;
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = global::csgobolwall.Properties.Resources.opening;
		this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
		base.ClientSize = new global::System.Drawing.Size(468, 158);
		base.Controls.Add(this.exitLabel);
		base.Controls.Add(this.mevcutSurumLabel);
		base.Controls.Add(this.AltLabel);
		base.Controls.Add(this.TitleLabel);
		base.Controls.Add(this.owlImage);
		base.Controls.Add(this.dotdot);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Form1";
		base.ShowIcon = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Hile Bol - Ad Approve";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.Form1_Load);
		((global::System.ComponentModel.ISupportInitialize)this.owlImage).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000005 RID: 5
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000006 RID: 6
	internal global::System.Windows.Forms.Label mevcutSurumLabel;

	// Token: 0x04000007 RID: 7
	internal global::System.Windows.Forms.Label AltLabel;

	// Token: 0x04000008 RID: 8
	internal global::System.Windows.Forms.Label TitleLabel;

	// Token: 0x04000009 RID: 9
	internal global::System.Windows.Forms.PictureBox owlImage;

	// Token: 0x0400000A RID: 10
	internal global::System.Windows.Forms.Label dotdot;

	// Token: 0x0400000B RID: 11
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x0400000C RID: 12
	internal global::System.Windows.Forms.Label exitLabel;

	// Token: 0x0400000D RID: 13
	private global::System.Windows.Forms.Timer timer_1;
}
