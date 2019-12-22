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
    public partial class Giris : Form
    {
        private Color defaultSelectedColor;
        public Giris()
        {
            InitializeComponent();
            defaultSelectedColor = uGiris.BackColor;
            ChangePage(new girisler.user());
        }
        private void ChangePage(Control page)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
        }
        private void DeAktiveAll()
        {
            uGiris.BackColor = pictureBox1.BackColor;
            gGiris.BackColor = pictureBox1.BackColor;
        }
        private void appBarClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uGiris_Click(object sender, EventArgs e)
        {
            if (uGiris.BackColor != defaultSelectedColor)
            {
                DeAktiveAll();
                uGiris.BackColor = defaultSelectedColor;
                ChangePage(new girisler.user());
            }
        }

        private void gGiris_Click(object sender, EventArgs e)
        {
            if (gGiris.BackColor != defaultSelectedColor)
            {
                DeAktiveAll();
                gGiris.BackColor = defaultSelectedColor;
                ChangePage(new girisler.gorevli());
            }
        }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
