using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormOdev.kutuphane
{
    public partial class emanetal : UserControl
    {
    Tumkodlar kodlar = new Tumkodlar();
    public emanetal()
    {
      InitializeComponent();
    }

    public static string durum;
    void yeniler()
    {
      dataGridView1.DataSource = kodlar.EmanetAl();
      dataGridView1.Columns[0].Visible = false;
      dataGridView1.Columns[1].HeaderText = "Emanet No";
      dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
      dataGridView1.Columns[3].HeaderText = "TC Kimlik";
      dataGridView1.Columns[4].HeaderText = "Okul No";
      dataGridView1.Columns[5].HeaderText = "Sınıfı";
      dataGridView1.Columns[6].HeaderText = "Barkod Kodu";
      dataGridView1.Columns[7].HeaderText = "Kitap Adı";
      dataGridView1.Columns[8].HeaderText = "Kitap Türü";
      dataGridView1.Columns[9].HeaderText = "Hasar Durumu";
      dataGridView1.Columns[10].HeaderText = "Veriliş Tarihi";
      dataGridView1.Columns[11].HeaderText = "Teslim Tarihi";
    }
    void Temizle()
    {
      txtİptal.Text = "";
      txtEmanetAl.Text = "";
    }
    private void emanetal_Load_1(object sender, EventArgs e)
    {
        yeniler();
    }

    private void txtAd_TextChanged(object sender, EventArgs e)
    {
        dataGridView1.DataSource = kodlar.emanetArama1(txtAd.Text.ToString());
    }

    private void txtTc_TextChanged(object sender, EventArgs e)
    {
      dataGridView1.DataSource = kodlar.emanetArama2(txtTc.Text.ToString());
    }

    private void txtKitapAdi_TextChanged(object sender, EventArgs e)
    {
      dataGridView1.DataSource = kodlar.emanetArama3(txtKitapAdi.Text.ToString());
    }

    private void btnEmanetAl_Click_1(object sender, EventArgs e)
    {
        if (kodlar.EmanetKontrol(txtEmanetAl.Text) == true || txtEmanetAl.Text == "")
        {
            MessageBox.Show("Böyle Bir Emanet Numarası yok veya boş alan var. Lütfen Doğru Girdiğinizden Emin Olun", "HATA");
        }
        else
        {
            DataTable kutuphane = kodlar.EmanetGetir(txtEmanetAl.Text);
            textBox2.Text= kutuphane.Rows[0]["KitapAdi"].ToString();
            DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
            textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
            int i = int.Parse(textBox1.Text.ToString());
            int sayi = 1;
            i = i + sayi;
            textBox1.Text = i.ToString();
            kodlar.KitapGuncelle2(textBox2.Text, textBox1.Text);
            kodlar.DurumGuncelle(txtEmanetAl.Text, durum = "İADE EDİLDİ".ToString());
            MessageBox.Show("Emanet İADE ALINDI.. "+textBox2.Text.ToString()+" Kitabının Yeni Stok Sayısı = "+textBox1.Text.ToString());
            yeniler();
            Temizle();
        }
    }
    private void btnİptal_Click(object sender, EventArgs e)
    {
        if (kodlar.EmanetKontrol(txtİptal.Text) == true || txtİptal.Text == "")
        {
            MessageBox.Show("Böyle Bir Emanet Numarası yok veya boş alan var. Lütfen Doğru Girdiğinizden Emin Olun", "HATA");
        }
        else
        {
            DialogResult dr = MessageBox.Show("Emanet işlemini İptal Edilsinmi ?", "İPTAL ET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
          DataTable kutuphane = kodlar.EmanetGetir(txtİptal.Text);
          textBox2.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
          DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
          textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
          int i = int.Parse(textBox1.Text.ToString());
          int sayi = 1;
          i = i + sayi;
          textBox1.Text = i.ToString();
          kodlar.KitapGuncelle2(textBox2.Text, textBox1.Text);
          kodlar.EmanetSil(txtİptal.Text);
                MessageBox.Show("Emanet İptal Edildi.. " + textBox2.Text.ToString() + " Kitabının Yeni Stok Sayısı = " + textBox1.Text.ToString());
                yeniler();
                Temizle();
            }
        }
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        foreach (DataGridViewRow satir in dataGridView1.Rows)
        {
            if (satir.Cells["Durum"].Value.ToString() == "İADE EDİLDİ")
            {
                satir.DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                satir.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (kodlar.EmanetKontrol(textBox3.Text) == true || textBox3.Text == "")
      {
        MessageBox.Show("Böyle Bir Emanet Numarası yok veya boş alan var. Lütfen Doğru Girdiğinizden Emin Olun", "HATA");
      }
      else
      {
        DialogResult dr = MessageBox.Show("Emanet Silinsinmi ?", "Emanet Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
          DataTable kutuphane = kodlar.EmanetGetir(textBox3.Text);
          textBox2.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
          DataTable kutuphane1 = kodlar.KitapBul(textBox2.Text);
          textBox1.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
          kodlar.EmanetSil(textBox3.Text);
          MessageBox.Show("Silmek istediğiniz "+textBox2.Text.ToString()+ " İsimli Kitap Emanet Geçmişinden Silindi..");
          yeniler();
          Temizle();
        }
      }
    }
  }
}
