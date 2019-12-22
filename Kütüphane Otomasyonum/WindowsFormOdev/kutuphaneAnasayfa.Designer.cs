namespace WindowsFormOdev
{
  partial class kutuphaneAnasayfa
  {
    /// <summary>
    ///Gerekli tasarımcı değişkeni.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///Kullanılan tüm kaynakları temizleyin.
    /// </summary>
    ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer üretilen kod

    /// <summary>
    /// Tasarımcı desteği için gerekli metot - bu metodun 
    ///içeriğini kod düzenleyici ile değiştirmeyin.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kutuphaneAnasayfa));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.emanetVer = new System.Windows.Forms.Button();
            this.UyeEkle = new System.Windows.Forms.Button();
            this.icerik = new MetroFramework.Controls.MetroPanel();
            this.appBarClose = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.AnaSayfa = new System.Windows.Forms.Button();
            this.KitapEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ana = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emanetAl = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Teal;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(272, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(416, 25);
            this.metroLabel1.TabIndex = 91;
            this.metroLabel1.Text = "Mehmet Aksın Kütüphane Otomasyon Uygulamam";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            this.ımageList1.Images.SetKeyName(1, "register.png");
            this.ımageList1.Images.SetKeyName(2, "help.png");
            this.ımageList1.Images.SetKeyName(3, "report.png");
            this.ımageList1.Images.SetKeyName(4, "close.png");
            // 
            // emanetVer
            // 
            this.emanetVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.emanetVer.FlatAppearance.BorderSize = 0;
            this.emanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetVer.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetVer.ForeColor = System.Drawing.Color.White;
            this.emanetVer.Image = ((System.Drawing.Image)(resources.GetObject("emanetVer.Image")));
            this.emanetVer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.emanetVer.Location = new System.Drawing.Point(1, 285);
            this.emanetVer.Name = "emanetVer";
            this.emanetVer.Size = new System.Drawing.Size(170, 38);
            this.emanetVer.TabIndex = 86;
            this.emanetVer.Text = "        Emanet Ver";
            this.emanetVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emanetVer.UseVisualStyleBackColor = false;
            this.emanetVer.Click += new System.EventHandler(this.button3_Click);
            // 
            // UyeEkle
            // 
            this.UyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.UyeEkle.FlatAppearance.BorderSize = 0;
            this.UyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UyeEkle.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeEkle.ForeColor = System.Drawing.Color.White;
            this.UyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("UyeEkle.Image")));
            this.UyeEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UyeEkle.Location = new System.Drawing.Point(1, 242);
            this.UyeEkle.Name = "UyeEkle";
            this.UyeEkle.Size = new System.Drawing.Size(170, 38);
            this.UyeEkle.TabIndex = 85;
            this.UyeEkle.Text = "        Üye Ekle";
            this.UyeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UyeEkle.UseVisualStyleBackColor = false;
            this.UyeEkle.Click += new System.EventHandler(this.UyeEkle_Click);
            // 
            // icerik
            // 
            this.icerik.HorizontalScrollbarBarColor = true;
            this.icerik.HorizontalScrollbarHighlightOnWheel = false;
            this.icerik.HorizontalScrollbarSize = 10;
            this.icerik.Location = new System.Drawing.Point(171, 36);
            this.icerik.Name = "icerik";
            this.icerik.Size = new System.Drawing.Size(630, 465);
            this.icerik.TabIndex = 84;
            this.icerik.Theme = MetroFramework.MetroThemeStyle.Light;
            this.icerik.VerticalScrollbarBarColor = true;
            this.icerik.VerticalScrollbarHighlightOnWheel = false;
            this.icerik.VerticalScrollbarSize = 10;
            this.icerik.Paint += new System.Windows.Forms.PaintEventHandler(this.icerik_Paint);
            // 
            // appBarClose
            // 
            this.appBarClose.BackColor = System.Drawing.Color.Teal;
            this.appBarClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.appBarClose.FlatAppearance.BorderSize = 0;
            this.appBarClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appBarClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appBarClose.ForeColor = System.Drawing.Color.White;
            this.appBarClose.ImageIndex = 0;
            this.appBarClose.ImageList = this.ımageList2;
            this.appBarClose.Location = new System.Drawing.Point(769, 6);
            this.appBarClose.Name = "appBarClose";
            this.appBarClose.Size = new System.Drawing.Size(32, 30);
            this.appBarClose.TabIndex = 82;
            this.appBarClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.appBarClose.UseVisualStyleBackColor = false;
            this.appBarClose.Click += new System.EventHandler(this.appBarClose_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "close.png");
            // 
            // AnaSayfa
            // 
            this.AnaSayfa.BackColor = System.Drawing.Color.Teal;
            this.AnaSayfa.FlatAppearance.BorderSize = 0;
            this.AnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfa.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSayfa.ForeColor = System.Drawing.Color.White;
            this.AnaSayfa.Image = global::WindowsFormOdev.Properties.Resources._1492126387_home;
            this.AnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.Location = new System.Drawing.Point(1, 162);
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.Size = new System.Drawing.Size(170, 38);
            this.AnaSayfa.TabIndex = 81;
            this.AnaSayfa.Text = "        Ana Sayfa";
            this.AnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.UseVisualStyleBackColor = false;
            this.AnaSayfa.Click += new System.EventHandler(this.AnaSayfa_Click);
            // 
            // KitapEkle
            // 
            this.KitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.KitapEkle.FlatAppearance.BorderSize = 0;
            this.KitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitapEkle.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("KitapEkle.Image")));
            this.KitapEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KitapEkle.Location = new System.Drawing.Point(1, 203);
            this.KitapEkle.Name = "KitapEkle";
            this.KitapEkle.Size = new System.Drawing.Size(170, 37);
            this.KitapEkle.TabIndex = 80;
            this.KitapEkle.Text = "        Kitap Ekle";
            this.KitapEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KitapEkle.UseVisualStyleBackColor = false;
            this.KitapEkle.Click += new System.EventHandler(this.KitapEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(5, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "        Menüler ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Location = new System.Drawing.Point(171, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(630, 32);
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ana.Image = ((System.Drawing.Image)(resources.GetObject("ana.Image")));
            this.ana.Location = new System.Drawing.Point(1, 6);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(170, 112);
            this.ana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ana.TabIndex = 77;
            this.ana.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 495);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // emanetAl
            // 
            this.emanetAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.emanetAl.FlatAppearance.BorderSize = 0;
            this.emanetAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetAl.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetAl.ForeColor = System.Drawing.Color.White;
            this.emanetAl.Image = ((System.Drawing.Image)(resources.GetObject("emanetAl.Image")));
            this.emanetAl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.emanetAl.Location = new System.Drawing.Point(1, 329);
            this.emanetAl.Name = "emanetAl";
            this.emanetAl.Size = new System.Drawing.Size(170, 38);
            this.emanetAl.TabIndex = 92;
            this.emanetAl.Text = "        Emanet Al";
            this.emanetAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emanetAl.UseVisualStyleBackColor = false;
            this.emanetAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox2.Location = new System.Drawing.Point(0, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 3);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // kutuphaneAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.emanetAl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.emanetVer);
            this.Controls.Add(this.UyeEkle);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.appBarClose);
            this.Controls.Add(this.AnaSayfa);
            this.Controls.Add(this.KitapEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ana);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "kutuphaneAnasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroLabel metroLabel1;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.Button emanetVer;
    private System.Windows.Forms.Button UyeEkle;
    private MetroFramework.Controls.MetroPanel icerik;
    private System.Windows.Forms.Button appBarClose;
    private System.Windows.Forms.ImageList ımageList2;
    private System.Windows.Forms.Button AnaSayfa;
    private System.Windows.Forms.Button KitapEkle;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox ana;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button emanetAl;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}

