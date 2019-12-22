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
  public partial class kutuphaneAnasayfa : MetroFramework.Forms.MetroForm
  {
    private Color defaultSelectedColor;
    public kutuphaneAnasayfa()
    {
      InitializeComponent();
    }
    private void ChangePage(Control page)
    {
      icerik.Controls.Clear();
      icerik.Controls.Add(page);
    }
    private void DeAktiveAll()
    {
      UyeEkle.BackColor = pictureBox1.BackColor;
      KitapEkle.BackColor = pictureBox1.BackColor;
      AnaSayfa.BackColor = pictureBox1.BackColor;
      emanetVer.BackColor = pictureBox1.BackColor;
      emanetAl.BackColor = pictureBox1.BackColor;
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      defaultSelectedColor = AnaSayfa.BackColor;
      icerik.Controls.Add(new kutuphane.anasayfa());
    }

    private void appBarClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void AnaSayfa_Click(object sender, EventArgs e)
    {
      DeAktiveAll();
      AnaSayfa.BackColor = defaultSelectedColor;
      ChangePage(new kutuphane.anasayfa());
    }

    private void KitapEkle_Click(object sender, EventArgs e)
    {
      DeAktiveAll();
      KitapEkle.BackColor = defaultSelectedColor;
      ChangePage(new kutuphane.kitapEkle());
    }

    private void UyeEkle_Click(object sender, EventArgs e)
    {
      DeAktiveAll();
      UyeEkle.BackColor = defaultSelectedColor;
      ChangePage(new kutuphane.kullaniciEkle());
    }

    private void button3_Click(object sender, EventArgs e)
    {
      DeAktiveAll();
      emanetVer.BackColor = defaultSelectedColor;
      ChangePage(new kutuphane.emanetver());
    }

    private void icerik_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      DeAktiveAll();
      emanetAl.BackColor = defaultSelectedColor;
      ChangePage(new kutuphane.emanetal());
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
