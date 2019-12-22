using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOdev.post
{
    public partial class post : UserControl
    {
        Tumkodlar kodlar = new Tumkodlar();
        public post()
        {
            InitializeComponent();
        }
        public static int a;
        public void  getir()
        {
            DataTable tablo = kodlar.TumKitaplar1();
            for (a = 0; a < kullaniciAnasayfa.i; a++)
            {
                label5.Text = tablo.Rows[a]["KitapAdi"].ToString();
                label2.Text = tablo.Rows[a]["Temin"].ToString();
                label3.Text = tablo.Rows[a]["KitapTuru"].ToString();
                label4.Text = tablo.Rows[a]["YazarAdi"].ToString();
            }
            
        }
        private void post_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
