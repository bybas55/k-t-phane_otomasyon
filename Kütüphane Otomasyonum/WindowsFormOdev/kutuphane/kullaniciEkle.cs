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
  public partial class kullaniciEkle : UserControl
  {
    Tumkodlar kodlar = new Tumkodlar();
    public kullaniciEkle()
    {
      InitializeComponent();
    }
      void yeniler()
    {
        dtKullanicilar.DataSource = kodlar.TumKullanicilar();
        dtKullanicilar.Columns[0].Visible = false;
        dtKullanicilar.Columns[1].HeaderText = "TC";
        dtKullanicilar.Columns[1].Width = 100;
        dtKullanicilar.Columns[2].HeaderText = "Şifre";
        dtKullanicilar.Columns[2].Width = 60;
        dtKullanicilar.Columns[3].HeaderText = "Ad Soyad";
        dtKullanicilar.Columns[3].Width = 100;
        dtKullanicilar.Columns[5].HeaderText = "Yetki";
        dtKullanicilar.Columns[5].Width = 60;
        dtKullanicilar.Columns[5].HeaderText = "Sınıfı";
        dtKullanicilar.Columns[5].Width = 60;
        dtKullanicilar.Columns[6].HeaderText = "Numarası";
        dtKullanicilar.Columns[6].Width = 60;
        dtKullanicilar.Columns[7].HeaderText = "Doğum Tarihi";
        dtKullanicilar.Columns[7].Width = 100;
        dtKullanicilar.Columns[8].HeaderText = "Doğum Yeri";
        dtKullanicilar.Columns[8].Width = 100;
        dtKullanicilar.Columns[9].HeaderText = "Telefon";
        dtKullanicilar.Columns[9].Width = 50;
        dtKullanicilar.Columns[10].HeaderText = "E-Posta";
        dtKullanicilar.Columns[10].Width = 50;
        dtKullanicilar.Columns[11].HeaderText = "Üyelik Tarihi";
        dtKullanicilar.Columns[11].Width = 110;
        dtKullanicilar.Columns[12].HeaderText = "Cinsiyet";
        dtKullanicilar.Columns[12].Width = 80;
        dtKullanicilar.Columns[13].HeaderText = "Adres";
        dtKullanicilar.Columns[13].Width = 80;
    }
    void Yukle()
    {
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      rTc.Checked = true;
      cmbCinsiyet.SelectedIndex = 0;
      txtYetki.SelectedIndex = 0;
      yeniler();
    }

    private void kullaniciEkle_Load(object sender, EventArgs e)
    {
      Yukle();
    }

    private void txtAra_TextChanged(object sender, EventArgs e)
    {
      if (rTc.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama1(txtAra.Text.ToString());
      }
      else if (rİsim.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama2(txtAra.Text.ToString());
      }
      else if (rSinif.Checked == true)
      {
          dtKullanicilar.DataSource = kodlar.KullaniciArama3(txtAra.Text.ToString());
      }
   }

    private void btnGetir_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.KullaniciBul(txtTc.Text);
      if (kutuphane.Rows.Count == 0)
      {
        MessageBox.Show("Kullanıcı Bulunamadı. Lütfen Aramak İstediğiniz Kişiniz TC'sini Giriniz....", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        txtSifre.Text = kutuphane.Rows[0]["Sifre"].ToString();
        txtAd.Text = kutuphane.Rows[0]["Adsoyad"].ToString();
        txtYetki.Text = kutuphane.Rows[0]["Yetki"].ToString();
        txtSinif.Text = kutuphane.Rows[0]["Sinif"].ToString();
        txtNo.Text = kutuphane.Rows[0]["Numara"].ToString();
        cmbDtarih.Text = kutuphane.Rows[0]["DogumT"].ToString();
        txtDyeri.Text = kutuphane.Rows[0]["DogumY"].ToString();
        txtTel.Text = kutuphane.Rows[0]["Telefon"].ToString();
        txtEposta.Text = kutuphane.Rows[0]["Eposta"].ToString();
        cmbUtarih.Text = kutuphane.Rows[0]["UyelikT"].ToString();
        cmbCinsiyet.Text = kutuphane.Rows[0]["Cinsiyet"].ToString();
        txtAdres.Text = kutuphane.Rows[0]["Adres"].ToString();
        btnEkle.Visible = false;
        btnGetir.Enabled = false;
        btnGuncelle.Visible = true;
        btnSil.Visible = true;
        txtTc.Enabled = false;
      }
    }

    private void label9_Click(object sender, EventArgs e)
    {
      Yeni();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      Yeni();
    }
    void Yeni()
    {
      txtTc.Text = "";
      txtSifre.Text = "";
      txtAd.Text = "";
      txtSinif.Text = "";
      txtNo.Text = "";
      cmbDtarih.Text = "";
      txtDyeri.Text = "";
      txtTel.Text = "";
      txtEposta.Text = "";
      cmbUtarih.Text = "";
      txtAdres.Text = "";
      cmbCinsiyet.SelectedIndex = 0;
      txtYetki.SelectedIndex = 0;
      btnEkle.Visible = true;
      btnGetir.Enabled = true;
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      txtTc.Enabled = true;
    }
    private void btnEkle_Click(object sender, EventArgs e)
    {
      if (txtTc.Text.Length == 0 || txtSifre.Text.Length == 0 || txtSinif.Text.Length == 0 || txtYetki.Text.Length == 0 || txtEposta.Text.Length == 0 || txtTel.Text.Length == 0 || txtAdres.Text.Length == 0 || txtAd.Text.Length == 0)
      {
        MessageBox.Show("Eksik Alanlar Var Lütfen Doldurun...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if(txtTc.Text.Length<11)
        {
          MessageBox.Show("Lütfen Tc Kimlik Numaranızı Tam Giriniz (11 HANELİ)");
        }
        else
        {
          if (kodlar.KullaniciKontrol(txtTc.Text) == true)
          {
            kodlar.KullaniciEkle(txtTc.Text, txtSifre.Text, txtAd.Text, txtYetki.Text, txtSinif.Text, txtNo.Text, cmbDtarih.Text, txtDyeri.Text, txtTel.Text, txtEposta.Text, cmbUtarih.Text, cmbCinsiyet.Text, txtAdres.Text);
            yeniler();
            MessageBox.Show("Kayıt Tamamlanmıştır...");
          }
          else
          {
            MessageBox.Show("Kullanıcı Tc Kimlik Daha Önce Eklenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      if (txtSifre.Text.Length == 0 || txtSinif.Text.Length == 0 || txtYetki.Text.Length == 0 || txtEposta.Text.Length == 0 || txtTel.Text.Length == 0 || txtAdres.Text.Length == 0 || txtAd.Text.Length == 0)
      {
        MessageBox.Show("Eksik Alanlar Var Lütfen Doldurun...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        kodlar.KullaniciGuncelle(txtTc.Text, txtSifre.Text, txtAd.Text, txtYetki.Text, txtSinif.Text, txtNo.Text, cmbDtarih.Text, txtDyeri.Text, txtTel.Text, txtEposta.Text, cmbUtarih.Text, cmbCinsiyet.Text, txtAdres.Text);
        yeniler();
        MessageBox.Show("Güncelleme Tamamlanmıştır...");
      }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      DialogResult dr = MessageBox.Show("Kaydi Silmek İstediginizden Eminmisiniz", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dr == DialogResult.Yes)
      {
        kodlar.KullaniciSil(txtTc.Text);
        MessageBox.Show("Silme İşlemi Tamamlanmıştır.");
        yeniler();
        Yeni();
      }
    }
  }
}
