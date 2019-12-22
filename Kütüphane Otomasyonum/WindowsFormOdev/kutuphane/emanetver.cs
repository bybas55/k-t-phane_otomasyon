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
  public partial class emanetver : UserControl
  {
    Tumkodlar kodlar = new Tumkodlar();
    public emanetver()
    {
      InitializeComponent();
    }
    private void emanet_Load(object sender, EventArgs e)
    {
      yeniler();
    }
    void random()
    {
      Random rastgele = new Random();
      int sayi = rastgele.Next(100000, 999999);
      txtEmanetNo.Text = sayi.ToString();
    }
    void yeniler()
    {
      random();
      txtDurum.Text = "Zimmetlendi";

     /* dtEmanetler.DataSource = kodlar.EmanetVer1();
      dtEmanetler.Columns[0].Visible = false;
      dtEmanetler.Columns[1].HeaderText = "Emanet No";
      dtEmanetler.Columns[2].HeaderText = "Adı Soyadı";
      dtEmanetler.Columns[3].HeaderText = "TC Kimlik";
      dtEmanetler.Columns[4].HeaderText = "Okul No";
      dtEmanetler.Columns[5].HeaderText = "Sınıfı";
      dtEmanetler.Columns[6].HeaderText = "Barkod Kodu";
      dtEmanetler.Columns[7].HeaderText = "Kitap Adı";
      dtEmanetler.Columns[8].HeaderText = "Kitap Türü";
      dtEmanetler.Columns[9].HeaderText = "Hasar Durumu";
      dtEmanetler.Columns[10].HeaderText = "Veriliş Tarihi";
      dtEmanetler.Columns[11].HeaderText = "Teslim Tarihi";
        */
      

      dtUyeler.DataSource = kodlar.EmanetVer2();
      dtUyeler.Columns[0].Visible = false;
      dtUyeler.Columns[1].Width = 114;
      dtUyeler.Columns[1].HeaderText = "Tc Kimlik";
      dtUyeler.Columns[2].Visible = false;
      dtUyeler.Columns[3].Width = 130;
      dtUyeler.Columns[3].HeaderText = "Adı Soyadı";
      dtUyeler.Columns[4].Visible = false;
      dtUyeler.Columns[5].Visible = false;
      dtUyeler.Columns[6].Visible = false;
      dtUyeler.Columns[7].Visible = false;
      dtUyeler.Columns[8].Visible = false;
      dtUyeler.Columns[9].HeaderText = "Telefon Numarası";
      dtUyeler.Columns[9].Width = 120;
      dtUyeler.Columns[10].HeaderText = "Eposta Adresi";
      dtUyeler.Columns[10].Width = 180;
      dtUyeler.Columns[11].Visible = false;
      dtUyeler.Columns[12].Visible = false;
      dtUyeler.Columns[13].Visible = false;
      

      dtKitaplar.DataSource = kodlar.EmanetVer3(); 
      dtKitaplar.Columns[0].Visible = false;
      dtKitaplar.Columns[1].Width = 92;
      dtKitaplar.Columns[1].HeaderText = "Barkod Kodu";
      dtKitaplar.Columns[2].Width = 176;
      dtKitaplar.Columns[2].HeaderText = "Kitap Adı";
      dtKitaplar.Columns[3].Visible = false;
      dtKitaplar.Columns[4].Visible = false;
      dtKitaplar.Columns[5].HeaderText = "Kitap Türü";
      dtKitaplar.Columns[6].Visible = false;
      dtKitaplar.Columns[7].HeaderText = "Stok Sayısı";
      dtKitaplar.Columns[8].Visible = false;
    }
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        dtUyeler.DataSource = kodlar.emanetAramaUye(uyeArama.Text);
    }

    private void kitapArama_TextChanged(object sender, EventArgs e)
    {
        dtKitaplar.DataSource = kodlar.emanetAramaKitap(kitapArama.Text);
    }

    private void tcCek_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.UyeBul(txtTc.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("Kullanıcı Bulunamadı. Lütfen Aramak İstediğiniz Kişiniz TC'sini Giriniz....", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        
        txtAd.Text = kutuphane.Rows[0]["Adsoyad"].ToString();
        txtSinif.Text = kutuphane.Rows[0]["Sinif"].ToString();
        txtNo.Text = kutuphane.Rows[0]["Numara"].ToString();
        tcCek.Enabled = false;
        txtTc.Enabled = false;
      }
    }
    void Temizle()
    {
      random();
      txtDurum.Text = "Zimmetlendi";
      txtAd.Text = "";
      txtBarkod.Text = "";
      txtHasar.Text = "";
      txtKitapAdi.Text = "";
      txtNo.Text = "";
      txtSinif.Text = "";
      txtTc.Text = "";
      txtTur.Text = "";
      txtVerilis.Text = "";
      txtTeslim.Text = "";
      tcCek.Enabled = true;
      barkodCek.Enabled = true;
      txtBarkod.Enabled = true;
      txtTc.Enabled = true;
    }
    private void button2_Click(object sender, EventArgs e)
    {
      Temizle();
    }

    private void barkodCek_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.KitapBul2(txtBarkod.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("Kitap Bulunamadı. Lütfen Aramak İstediğiniz Kitabın Barkod Kodunu Giriniz....", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        txtKitapAdi.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
        txtBarkod.Text = kutuphane.Rows[0]["Barkod"].ToString();
        txtTur.Text = kutuphane.Rows[0]["KitapTuru"].ToString();
        txtHasar.Text = kutuphane.Rows[0]["Hasar"].ToString();
        txtStok.Text = kutuphane.Rows[0]["StokSayisi"].ToString();
        txtBarkod.Enabled = false;
        barkodCek.Enabled = false;
        int i = int.Parse(txtStok.Text.ToString());
        int sayi = 1;
        i = i - sayi;
        txtStok.Text = i.ToString();
      }
      

    }
    private void button1_Click(object sender, EventArgs e)
    {
      
      if(txtAd.Text.Length==0 || txtKitapAdi.Text.Length==0)
      {
        MessageBox.Show("Boş Alan var Lütfen Doldurun...");
      }
      else
      {
        if(kodlar.EmanetKontrol(txtEmanetNo.Text)==false)
        {
          MessageBox.Show("Emanet Numarası Daha önce Eklenmiştir. Lütfen Yeni bir Giriş Yapın.");
        }
        else
        {
          int i = int.Parse(txtStok.Text);
          if (i==0 || i<0)
          {
            MessageBox.Show("Emanet Verilmek İstenen Kitap Şuan Stoklarda Bulunmamaktadır.");
          }
          else
          {
            kodlar.KitapGuncelle2(txtKitapAdi.Text, txtStok.Text);
            kodlar.EmanetVer(txtEmanetNo.Text, txtAd.Text, txtTc.Text, txtNo.Text, txtSinif.Text, txtBarkod.Text, txtKitapAdi.Text, txtTur.Text, txtHasar.Text, txtVerilis.Text, txtTeslim.Text, txtDurum.Text);
            MessageBox.Show("Emanet Verme İşlemi tamamlandı... " + txtKitapAdi.Text.ToString() + " Kitabının Yeni Stok Sayısı = " + txtStok.Text.ToString(), "Emanet Verildi", MessageBoxButtons.OK, MessageBoxIcon.None);
            Temizle();
            yeniler();
          }
         
        }
      }
    }
  }
}
