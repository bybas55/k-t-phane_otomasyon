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
    public partial class kullaniciAnasayfa : UserControl
    {
        Tumkodlar kodlar = new Tumkodlar();
        public kullaniciAnasayfa()
        {
            InitializeComponent();
        }
        public static int kayitsayisi;
        public static int i;
        public void yukle()
        {
            DataTable tablo = kodlar.TumKitaplar1();
            kayitsayisi = tablo.Rows.Count;
            kayitsayisi = kayitsayisi - 1;
            int x = 10, y = 14 ,a=324,b=14;
            for (i = 1; i <= kayitsayisi; i++)
            {
                post detay2 = new post();
                Point lblyer2 = new Point(a, b);
                detay2.Location = lblyer2;
                detay2.getir();
                this.Controls.Add(detay2);
                b += 160;

                post detay = new post();
                Point lblyer = new Point(x, y);
                detay.Location = lblyer;
                detay.getir();
                this.Controls.Add(detay);
                y += 160;
                    
                


            }

        }
        private void kullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            yukle();
        }
    }
}
