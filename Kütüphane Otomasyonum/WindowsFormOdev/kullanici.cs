using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOdev
{
    public partial class kullanici : MetroFramework.Forms.MetroForm
    {
        Tumkodlar kodlar = new Tumkodlar();
        public kullanici()
        {
            InitializeComponent();
        }
        private Color defaultSelectedColor;
        private void ChangePage(Control page)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(page);
        }
        private void DeAktiveAll()
        {
            AnaSayfa.BackColor = pictureBox1.BackColor;
        }
        private void kullanici_Load(object sender, EventArgs e)
        {
            defaultSelectedColor = AnaSayfa.BackColor;
            icerik.Controls.Add(new post.kullaniciAnasayfa());
        }
       
        private void appBarClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            DeAktiveAll();
            AnaSayfa.BackColor = defaultSelectedColor;
            ChangePage(new post.kullaniciAnasayfa());
        }
        private void icerik_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
