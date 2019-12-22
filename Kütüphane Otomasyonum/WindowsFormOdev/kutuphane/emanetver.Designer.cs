namespace WindowsFormOdev.kutuphane
{
    partial class emanetver
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcCek = new System.Windows.Forms.Button();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmanetNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHasar = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.barkodCek = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeslim = new System.Windows.Forms.DateTimePicker();
            this.txtVerilis = new System.Windows.Forms.DateTimePicker();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.dtUyeler = new System.Windows.Forms.DataGridView();
            this.dtKitaplar = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.uyeArama = new System.Windows.Forms.TextBox();
            this.kitapArama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tcCek);
            this.groupBox1.Controls.Add(this.txtSinif);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgisi";
            // 
            // tcCek
            // 
            this.tcCek.Location = new System.Drawing.Point(6, 115);
            this.tcCek.Name = "tcCek";
            this.tcCek.Size = new System.Drawing.Size(236, 23);
            this.tcCek.TabIndex = 8;
            this.tcCek.Text = "TC İle Bilgi Çekme";
            this.tcCek.UseVisualStyleBackColor = true;
            this.tcCek.Click += new System.EventHandler(this.tcCek_Click);
            // 
            // txtSinif
            // 
            this.txtSinif.Enabled = false;
            this.txtSinif.Location = new System.Drawing.Point(85, 90);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(157, 20);
            this.txtSinif.TabIndex = 7;
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(85, 68);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(157, 20);
            this.txtNo.TabIndex = 6;
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(85, 43);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(157, 23);
            this.txtTc.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(85, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 20);
            this.txtAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(40, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınıfı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtEmanetNo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtDurum);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtHasar);
            this.groupBox2.Controls.Add(this.txtTur);
            this.groupBox2.Controls.Add(this.barkodCek);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTeslim);
            this.groupBox2.Controls.Add(this.txtVerilis);
            this.groupBox2.Controls.Add(this.txtKitapAdi);
            this.groupBox2.Controls.Add(this.txtStok);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(264, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgisi";
            // 
            // txtEmanetNo
            // 
            this.txtEmanetNo.Enabled = false;
            this.txtEmanetNo.Location = new System.Drawing.Point(269, 15);
            this.txtEmanetNo.Name = "txtEmanetNo";
            this.txtEmanetNo.Size = new System.Drawing.Size(77, 20);
            this.txtEmanetNo.TabIndex = 101;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(183, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 100;
            this.label16.Text = "Emanet No :";
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Location = new System.Drawing.Point(269, 40);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(77, 20);
            this.txtDurum.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(167, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 98;
            this.label14.Text = "Kitap Durumu :";
            // 
            // txtHasar
            // 
            this.txtHasar.Enabled = false;
            this.txtHasar.Location = new System.Drawing.Point(83, 87);
            this.txtHasar.Name = "txtHasar";
            this.txtHasar.Size = new System.Drawing.Size(79, 20);
            this.txtHasar.TabIndex = 97;
            // 
            // txtTur
            // 
            this.txtTur.Enabled = false;
            this.txtTur.Location = new System.Drawing.Point(83, 63);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(79, 20);
            this.txtTur.TabIndex = 96;
            // 
            // barkodCek
            // 
            this.barkodCek.Location = new System.Drawing.Point(39, 113);
            this.barkodCek.Name = "barkodCek";
            this.barkodCek.Size = new System.Drawing.Size(282, 23);
            this.barkodCek.TabIndex = 95;
            this.barkodCek.Text = "Barkod Kodu İle Bilgi Çekme";
            this.barkodCek.UseVisualStyleBackColor = true;
            this.barkodCek.Click += new System.EventHandler(this.barkodCek_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(175, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 87;
            this.label13.Text = "Veriliş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(11, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Kitap Adı :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(83, 37);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(79, 20);
            this.txtBarkod.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(0, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Barkod No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(29, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 84;
            this.label10.Text = "Hasar :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(172, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 17);
            this.label15.TabIndex = 91;
            this.label15.Text = "Teslim Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(1, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Kitap Türü :";
            // 
            // txtTeslim
            // 
            this.txtTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTeslim.Location = new System.Drawing.Point(269, 85);
            this.txtTeslim.Name = "txtTeslim";
            this.txtTeslim.Size = new System.Drawing.Size(77, 20);
            this.txtTeslim.TabIndex = 89;
            // 
            // txtVerilis
            // 
            this.txtVerilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVerilis.Location = new System.Drawing.Point(269, 63);
            this.txtVerilis.Name = "txtVerilis";
            this.txtVerilis.Size = new System.Drawing.Size(77, 20);
            this.txtVerilis.TabIndex = 86;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Enabled = false;
            this.txtKitapAdi.Location = new System.Drawing.Point(83, 13);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(79, 20);
            this.txtKitapAdi.TabIndex = 88;
            // 
            // txtStok
            // 
            this.txtStok.Enabled = false;
            this.txtStok.Location = new System.Drawing.Point(83, 13);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(79, 20);
            this.txtStok.TabIndex = 102;
            this.txtStok.Visible = false;
            // 
            // dtUyeler
            // 
            this.dtUyeler.AllowUserToAddRows = false;
            this.dtUyeler.AllowUserToDeleteRows = false;
            this.dtUyeler.BackgroundColor = System.Drawing.Color.White;
            this.dtUyeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUyeler.Location = new System.Drawing.Point(10, 222);
            this.dtUyeler.Name = "dtUyeler";
            this.dtUyeler.ReadOnly = true;
            this.dtUyeler.Size = new System.Drawing.Size(612, 105);
            this.dtUyeler.TabIndex = 2;
            // 
            // dtKitaplar
            // 
            this.dtKitaplar.AllowUserToAddRows = false;
            this.dtKitaplar.AllowUserToDeleteRows = false;
            this.dtKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dtKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKitaplar.Location = new System.Drawing.Point(10, 354);
            this.dtKitaplar.Name = "dtKitaplar";
            this.dtKitaplar.ReadOnly = true;
            this.dtKitaplar.Size = new System.Drawing.Size(612, 105);
            this.dtKitaplar.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(25, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adı Soyadı :";
            // 
            // uyeArama
            // 
            this.uyeArama.Location = new System.Drawing.Point(114, 200);
            this.uyeArama.Name = "uyeArama";
            this.uyeArama.Size = new System.Drawing.Size(157, 20);
            this.uyeArama.TabIndex = 9;
            this.uyeArama.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // kitapArama
            // 
            this.kitapArama.Location = new System.Drawing.Point(135, 332);
            this.kitapArama.Name = "kitapArama";
            this.kitapArama.Size = new System.Drawing.Size(157, 20);
            this.kitapArama.TabIndex = 10;
            this.kitapArama.TextChanged += new System.EventHandler(this.kitapArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(46, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kitap Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(319, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Üye Arama Bölümü";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(319, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kitap Arama Bölümü";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "Kitap Emanet Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 97;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emanetver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kitapArama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uyeArama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtKitaplar);
            this.Controls.Add(this.dtUyeler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "emanetver";
            this.Size = new System.Drawing.Size(630, 465);
            this.Load += new System.EventHandler(this.emanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tcCek;
        private System.Windows.Forms.Button barkodCek;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtTeslim;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.DateTimePicker txtVerilis;
        private System.Windows.Forms.DataGridView dtUyeler;
        private System.Windows.Forms.DataGridView dtKitaplar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uyeArama;
        private System.Windows.Forms.TextBox kitapArama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtHasar;
    private System.Windows.Forms.TextBox txtTur;
    private System.Windows.Forms.TextBox txtDurum;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox txtEmanetNo;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox txtStok;
  }
}
