namespace WindowsFormOdev
{
    partial class Giris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
      this.panel1 = new System.Windows.Forms.Panel();
      this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
      this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
      this.ana = new System.Windows.Forms.PictureBox();
      this.uGiris = new System.Windows.Forms.Button();
      this.gGiris = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.ana)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
      this.panel1.Location = new System.Drawing.Point(169, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(374, 352);
      this.panel1.TabIndex = 62;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // ımageList2
      // 
      this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
      this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList2.Images.SetKeyName(0, "close.png");
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
      // ana
      // 
      this.ana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.ana.Image = ((System.Drawing.Image)(resources.GetObject("ana.Image")));
      this.ana.Location = new System.Drawing.Point(-1, -1);
      this.ana.Name = "ana";
      this.ana.Size = new System.Drawing.Size(170, 265);
      this.ana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ana.TabIndex = 63;
      this.ana.TabStop = false;
      // 
      // uGiris
      // 
      this.uGiris.BackColor = System.Drawing.Color.Brown;
      this.uGiris.FlatAppearance.BorderSize = 0;
      this.uGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.uGiris.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.uGiris.ForeColor = System.Drawing.Color.White;
      this.uGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.uGiris.ImageIndex = 0;
      this.uGiris.ImageList = this.ımageList1;
      this.uGiris.Location = new System.Drawing.Point(-1, 271);
      this.uGiris.Name = "uGiris";
      this.uGiris.Size = new System.Drawing.Size(170, 34);
      this.uGiris.TabIndex = 67;
      this.uGiris.Text = "      Üye Giriş";
      this.uGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.uGiris.UseVisualStyleBackColor = false;
      this.uGiris.Click += new System.EventHandler(this.uGiris_Click);
      // 
      // gGiris
      // 
      this.gGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.gGiris.FlatAppearance.BorderSize = 0;
      this.gGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.gGiris.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.gGiris.ForeColor = System.Drawing.Color.White;
      this.gGiris.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.gGiris.ImageIndex = 3;
      this.gGiris.ImageList = this.ımageList1;
      this.gGiris.Location = new System.Drawing.Point(-1, 311);
      this.gGiris.Name = "gGiris";
      this.gGiris.Size = new System.Drawing.Size(170, 34);
      this.gGiris.TabIndex = 66;
      this.gGiris.Text = "      Görevli Giriş";
      this.gGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.gGiris.UseVisualStyleBackColor = false;
      this.gGiris.Click += new System.EventHandler(this.gGiris_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(171, 352);
      this.pictureBox1.TabIndex = 61;
      this.pictureBox1.TabStop = false;
      // 
      // Giris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(540, 350);
      this.ControlBox = false;
      this.Controls.Add(this.ana);
      this.Controls.Add(this.uGiris);
      this.Controls.Add(this.gGiris);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Giris";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      ((System.ComponentModel.ISupportInitialize)(this.ana)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ana;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button uGiris;
        private System.Windows.Forms.Button gGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}