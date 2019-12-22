using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormOdev;
using System.Data.OleDb;

namespace WindowsFormOdev.kutuphane
{
  public partial class kitapEkle : UserControl
  {
    Tumkodlar kodlar = new Tumkodlar();
    public kitapEkle()
    {
      InitializeComponent();
    }
    private void kitapEkle_Load(object sender, EventArgs e)
    {
      Yükle();
    }
    void yeniler()
    {
      dtKitaplar.DataSource = kodlar.TumKitaplar();
      dtKitaplar.Columns[0].Visible = false;
    }
    void random()
    {
      Random rastgele = new Random();
      int sayi = rastgele.Next(1000, 9999);
      txtBarkod.Text = sayi.ToString();
    }
    void Yükle()
    {
      yeniler();
      cmbKitapTuru.SelectedIndex = 0;
      cmbHasar.SelectedIndex = 0;
      rBarkod.Checked = true;
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      random();
    }
    private void btnGetir_Click(object sender, EventArgs e)
    {
      DataTable kutuphane = kodlar.KitapBul(cmbKitapAdi.Text);
      DataTable kutuphane1 = kodlar.KitapBul1(txtBarkod.Text);
      if (kutuphane.Rows.Count == 0)
      {
        if (kutuphane1.Rows.Count == 0)
        {
          MessageBox.Show("Barkod veya Kitap Adı Hatalı Veya Yazılmamış. Lütfen Tekrar Deneyin...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          cmbKitapAdi.Text = kutuphane1.Rows[0]["KitapAdi"].ToString();
          txtBarkod.Text = kutuphane1.Rows[0]["Barkod"].ToString();
          txtYazar.Text = kutuphane1.Rows[0]["YazarAdi"].ToString();
          txtYayinEvi.Text = kutuphane1.Rows[0]["YayinEvi"].ToString();
          cmbKitapTuru.Text = kutuphane1.Rows[0]["KitapTuru"].ToString();
          cmbTarih.Text = kutuphane1.Rows[0]["Temin"].ToString();
          txtStok.Text = kutuphane1.Rows[0]["StokSayisi"].ToString();
          cmbHasar.Text = kutuphane1.Rows[0]["Hasar"].ToString();
          btnGuncelle.Visible = true;
          btnSil.Visible = true;
          btnEkle.Visible = false;
          btnGetir.Enabled = false;
          cmbKitapAdi.Enabled = false;
          txtBarkod.Enabled = false;
          btnYeni.Enabled = true;
          label9.Enabled = true;
        }
      }
      else
      {
        cmbKitapAdi.Text = kutuphane.Rows[0]["KitapAdi"].ToString();
        txtBarkod.Text = kutuphane.Rows[0]["Barkod"].ToString();
        txtYazar.Text = kutuphane.Rows[0]["YazarAdi"].ToString();
        txtYayinEvi.Text = kutuphane.Rows[0]["YayinEvi"].ToString();
        cmbKitapTuru.Text = kutuphane.Rows[0]["KitapTuru"].ToString();
        cmbTarih.Text = kutuphane.Rows[0]["Temin"].ToString();
        txtStok.Text = kutuphane.Rows[0]["StokSayisi"].ToString();
        cmbHasar.Text = kutuphane.Rows[0]["Hasar"].ToString();
        btnGuncelle.Visible = true;
        btnSil.Visible = true;
        btnEkle.Visible = false;
        btnGetir.Enabled = false;
        cmbKitapAdi.Enabled = false;
        txtBarkod.Enabled = false;
        btnYeni.Enabled = true;
        label9.Enabled = true;
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      if (txtBarkod.Text.Length == 0 || cmbKitapAdi.Text.Length == 0 || txtYazar.Text.Length == 0 || txtYayinEvi.Text.Length == 0 || cmbKitapTuru.Text.Length == 0 || txtStok.Text.Length == 0 || cmbHasar.Text.Length == 0)
      {
        MessageBox.Show("Eksik Alanlar Var Lütfen Doldurun...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (kodlar.KitapKontrol1(cmbKitapAdi.Text) == true)
        {
          if (kodlar.KitapKontrol2(txtBarkod.Text) == false)
          {
            MessageBox.Show("Barkod Kodu Daha Önce Eklenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
            kodlar.KitapEkle(txtBarkod.Text, cmbKitapAdi.Text, txtYazar.Text, txtYayinEvi.Text, cmbKitapTuru.Text, cmbTarih.Text, txtStok.Text, cmbHasar.Text);
            yeniler();
            MessageBox.Show("Kayıt Tamamlanmıştır...");
          }
        }
        else
        {
          MessageBox.Show("Kitap Daha Önce Eklenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }
    
    private void btnSil_Click(object sender, EventArgs e)
    {
      DialogResult dr = MessageBox.Show("Kaydi Silmek İstediginizden Eminmisiniz", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dr == DialogResult.Yes)
      {
        kodlar.KitapSil(cmbKitapAdi.Text);
        MessageBox.Show("Silme İşlemi Tamamlanmıştır.");
        temizle();
        yeniler();
      }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      if (txtBarkod.Text.Length == 0 || cmbKitapAdi.Text.Length == 0 || txtYazar.Text.Length == 0 || txtYayinEvi.Text.Length == 0 || cmbKitapTuru.Text.Length == 0 || txtStok.Text.Length == 0 || cmbHasar.Text.Length == 0)
      {
        MessageBox.Show("Eksik Alanlar Var Lütfen Doldurun...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        kodlar.KitapGuncelle(txtBarkod.Text, cmbKitapAdi.Text, txtYazar.Text, txtYayinEvi.Text, cmbKitapTuru.Text, cmbTarih.Text, txtStok.Text, cmbHasar.Text);
        yeniler();
        MessageBox.Show("Güncelleme Tamamlanmıştır...");
      }
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      temizle();
    }
    void temizle()
    {
      cmbKitapAdi.Text = "";
      txtYazar.Text = "";
      cmbHasar.SelectedIndex = 0;
      txtYayinEvi.Text = "";
      cmbKitapTuru.Text = "";
      txtStok.Text = "";
      cmbTarih.Text = "";
      btnGuncelle.Visible = false;
      btnSil.Visible = false;
      btnEkle.Visible = true;
      btnGetir.Enabled = true;
      cmbKitapAdi.Enabled = true;
      txtBarkod.Enabled = true;
      btnYeni.Enabled = true;
      label9.Enabled = true;
      rBarkod.Checked = true;
      random();
    }

    private void label9_Click(object sender, EventArgs e)
    {
      temizle();
    }

    private void txtAra_TextChanged(object sender, EventArgs e)
    {
      if (rBarkod.Checked == true)
      {
          dtKitaplar.DataSource = kodlar.kitapArama1(txtAra.Text.ToString());
      }
      else if (rKitap.Checked == true)
      {

          dtKitaplar.DataSource = kodlar.kitapArama2(txtAra.Text.ToString());
      }
      else if (rTur.Checked == true)
      {
          dtKitaplar.DataSource = kodlar.kitapArama3(txtAra.Text.ToString());
      }
    }
  }
}
