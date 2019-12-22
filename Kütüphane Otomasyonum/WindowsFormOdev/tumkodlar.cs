using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormOdev
{
    class Tumkodlar
    {
    //VERİTABANI BAĞLANTI KODU
        public string Yol()
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb";
        }








    // KÜTÜPHANE OTOMASYONU

      // KİTAP EKLEME BÖLÜMÜ
    
    public void KitapEkle(string Barkod, string KitapAdi, string YazarAdi, string YayinEvi, string KitapTuru, string Temin, string StokSayisi, string Hasar)
    {
        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();
        string sql = "insert into kitaplar(Barkod,KitapAdi,YazarAdi,YayinEvi,KitapTuru,Temin,StokSayisi,Hasar) values (@Barkod,@KitapAdi,@YazarAdi,@YayinEvi,@KitapTuru,@Temin,@StokSayisi,@Hasar)";
        OleDbCommand komut = new OleDbCommand(sql, con);
        komut.Parameters.AddWithValue("@Barkod", Barkod);
        komut.Parameters.AddWithValue("@KitapAdi", KitapAdi);
        komut.Parameters.AddWithValue("@YazarAdi", YazarAdi);
        komut.Parameters.AddWithValue("@YayinEvi", YayinEvi);
        komut.Parameters.AddWithValue("@KitapTuru", KitapTuru);
        komut.Parameters.AddWithValue("@Temin", Temin);
        komut.Parameters.AddWithValue("@StokSayisi", StokSayisi);
        komut.Parameters.AddWithValue("@Hasar", Hasar);
        komut.ExecuteNonQuery();
        con.Close();
    }
    public void KitapGuncelle(string Barkod, string KitapAdi, string YazarAdi, string YayinEvi, string KitapTuru, string Temin, string StokSayisi, string Hasar)
    {

        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();

        string sql = "update kitaplar set Barkod=@Barkod,YazarAdi=@YazarAdi,YayinEvi=@YayinEvi,KitapTuru=@KitapTuru,Temin=@Temin,StokSayisi=@StokSayisi,Hasar=@Hasar where KitapAdi=@KitapAdi";
        OleDbCommand komut = new OleDbCommand(sql, con);
        komut.Parameters.AddWithValue("@Barkod", Barkod);
        komut.Parameters.AddWithValue("@YazarAdi", YazarAdi);
        komut.Parameters.AddWithValue("@YayinEvi", YayinEvi);
        komut.Parameters.AddWithValue("@KitapTuru", KitapTuru);
        komut.Parameters.AddWithValue("@Temin", Temin);
        komut.Parameters.AddWithValue("@StokSayisi", StokSayisi);
        komut.Parameters.AddWithValue("@Hasar", Hasar);
        komut.Parameters.AddWithValue("@KitapAdi", KitapAdi);
        komut.ExecuteNonQuery();
        con.Close();

    }
    public void KitapGuncelle2( string KitapAdi,string StokSayisi)
    {

      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();

      string sql = "update kitaplar set StokSayisi=@StokSayisi where KitapAdi=@KitapAdi";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@StokSayisi", StokSayisi);
      komut.Parameters.AddWithValue("@KitapAdi", KitapAdi);
      komut.ExecuteNonQuery();
      con.Close();

    }

    public void KitapSil(string KitapAdi)
    {
        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();
        string sql = "delete from kitaplar where KitapAdi=@KitapAdi";
        OleDbCommand con1 = new OleDbCommand(sql, con);
        con1.Parameters.AddWithValue("@KitapAdi", KitapAdi);
        con1.ExecuteNonQuery();

    }
    public DataTable TumKitaplar()
    {
        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();
        string sql = "select * from kitaplar Order by KitapAdi ASC";
        DataTable dt = new DataTable();
        OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
        adp.Fill(dt);
        return dt;
    }
    public DataTable TumKitaplar1()
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select TOP 3 * from kitaplar Order by Temin DESC";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable KitapBul(string KitapAdi)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from kitaplar where KitapAdi=@KitapAdi";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@KitapAdi", KitapAdi);
      adp.Fill(dt);
      return dt;
    }
    public DataTable KitapBul1(string Barkod)
    {
        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();
        string sql = "select * from kitaplar where Barkod=@Barkod";
        DataTable dt = new DataTable();
        OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
        adp.SelectCommand.Parameters.AddWithValue("@Barkod", Barkod);
        adp.Fill(dt);
        return dt;
    }
    public bool KitapKontrol1(string KitapAdi)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from kitaplar where KitapAdi=@KitapAdi";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@KitapAdi", KitapAdi);
      adp.Fill(dt);
      if (dt.Rows.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool KitapKontrol2(string Barkod)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from kitaplar where Barkod=@Barkod";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@Barkod", Barkod);
      adp.Fill(dt);
      if (dt.Rows.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
     }
    public DataTable kitapArama1(string kitap)
    {
        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection(Yol());
        tablo.Clear();
        baglanti.Open();
        OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From kitaplar where Barkod like '%" + kitap + "%'", baglanti);
        adtr.Fill(tablo);
        return tablo;
    }
    public DataTable kitapArama2(string kitap)
    {
        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection(Yol());
        tablo.Clear();
        baglanti.Open();
        OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From kitaplar where KitapAdi like '%" + kitap + "%'", baglanti);
        adtr.Fill(tablo);
        return tablo;
    }
    public DataTable kitapArama3(string kitap)
    {
        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection(Yol());
        tablo.Clear();
        baglanti.Open();
        OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From kitaplar where KitapTuru like '%" + kitap + "%'", baglanti);
        adtr.Fill(tablo);
        return tablo;
    }





















    // KULLANICI EKLEME BÖLÜMÜ 

    public void KullaniciEkle(string Tc, string Sifre, string Adsoyad, string Yetki, string Sinif, string Numara, string DogumT, string DogumY,string Telefon,string Eposta,string UyelikT,string Cinsiyet,string Adres)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "insert into uyeler(Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres) values (@Tc,@Sifre,@Adsoyad,@Yetki,@Sinif,@Numara,@DogumT,@DogumY,@Telefon,@Eposta,@UyelikT,@Cinsiyet,@Adres)";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@Tc", Tc);
      komut.Parameters.AddWithValue("@Sifre", Sifre);
      komut.Parameters.AddWithValue("@Adsoyad", Adsoyad);
      komut.Parameters.AddWithValue("@Yetki", Yetki);
      komut.Parameters.AddWithValue("@Sinif", Sinif);
      komut.Parameters.AddWithValue("@Numara", Numara);
      komut.Parameters.AddWithValue("@DogumT", DogumT);
      komut.Parameters.AddWithValue("@DogumY", DogumY);
      komut.Parameters.AddWithValue("@Telefon", Telefon);
      komut.Parameters.AddWithValue("@Eposta", Eposta);
      komut.Parameters.AddWithValue("@UyelikT", UyelikT);
      komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
      komut.Parameters.AddWithValue("@Adres", Adres);
      komut.ExecuteNonQuery();
      con.Close();
    }
    public void KullaniciGuncelle(string Tc, string Sifre, string Adsoyad, string Yetki, string Sinif, string Numara, string DogumT, string DogumY, string Telefon, string Eposta, string UyelikT, string Cinsiyet, string Adres)
    {

      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "update uyeler set Sifre=@Sifre,Adsoyad=@Adsoyad,Yetki=@Yetki,Sinif=@Sinif,Numara=@Numara,DogumT=@DogumT,DogumY=@DogumY,Telefon=@Telefon,Eposta=@Eposta,UyelikT=@UyelikT,Cinsiyet=@Cinsiyet,Adres=@Adres where Tc=@Tc";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@Sifre", Sifre);
      komut.Parameters.AddWithValue("@Adsoyad", Adsoyad);
      komut.Parameters.AddWithValue("@Yetki", Yetki);
      komut.Parameters.AddWithValue("@Sinif", Sinif);
      komut.Parameters.AddWithValue("@Numara", Numara);
      komut.Parameters.AddWithValue("@DogumT", DogumT);
      komut.Parameters.AddWithValue("@DogumY", DogumY);
      komut.Parameters.AddWithValue("@Telefon", Telefon);
      komut.Parameters.AddWithValue("@Eposta", Eposta);
      komut.Parameters.AddWithValue("@UyelikT", UyelikT);
      komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
      komut.Parameters.AddWithValue("@Adres", Adres);
      komut.Parameters.AddWithValue("@Tc", Tc);
      komut.ExecuteNonQuery();
      con.Close();

    }

    public void KullaniciSil(string Tc)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "delete from uyeler where Tc=@Tc";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@Tc", Tc);
      komut.ExecuteNonQuery();

    }
    public DataTable TumKullanicilar()
    {
        OleDbConnection con = new OleDbConnection(Yol());
        con.Open();
        string sql = "select * from uyeler Order by Adsoyad ASC";
        DataTable dt = new DataTable();
        OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
        adp.Fill(dt);
        return dt;
    }
    public DataTable KullaniciArama1(string Bul)  
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Tc like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable KullaniciArama2(string Bul)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Adsoyad like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable KullaniciArama3(string Bul)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Sinif like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    
    public DataTable KullaniciBul(string Tc)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Tc=@Tc";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@Tc", Tc);
      adp.Fill(dt);
      return dt;
    }
    public bool KullaniciKontrol(string Tc)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Tc=@Tc";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@Tc", Tc);
      adp.Fill(dt);
      if (dt.Rows.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
      













    // EMANET BÖLÜMÜ

    public DataTable UyeBul(string Tc)
     {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler where Tc=@Tc";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@Tc", Tc);
      adp.Fill(dt);
      return dt;
     }
    public DataTable KitapBul2(string Barkod)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from kitaplar where Barkod=@Barkod";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@Barkod", Barkod);
      adp.Fill(dt);
      return dt;
    }
    public void EmanetVer(string EmanetNo,string Adsoyad, string Tc, string Numara, string Sınıf, string Barkod,string KitapAdi,string Turu,string Hasar,string vTarih,string tTarih,string Durum)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "insert into emanet(EmanetNo,Adsoyad,Tc,Numara,Sınıf,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum) values (@EmanetNo,@Adsoyad,@Tc,@Numara,@Sınıf,@Barkod,@KitapAdi,@Turu,@Hasar,@vTarih,@tTarih,@Durum)";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@EmanetNo", EmanetNo);
      komut.Parameters.AddWithValue("@Adsoyad", Adsoyad);
      komut.Parameters.AddWithValue("@Tc", Tc);
      komut.Parameters.AddWithValue("@Numara", Numara);
      komut.Parameters.AddWithValue("@Sınıf", Sınıf);
      komut.Parameters.AddWithValue("@Barkod", Barkod);
      komut.Parameters.AddWithValue("@KitapAdi", KitapAdi);
      komut.Parameters.AddWithValue("@Turu", Turu);
      komut.Parameters.AddWithValue("@Hasar", Hasar);
      komut.Parameters.AddWithValue("@vTarih", vTarih);
      komut.Parameters.AddWithValue("@tTarih", tTarih);
      komut.Parameters.AddWithValue("@Durum", Durum);
      komut.ExecuteNonQuery();
      con.Close();
    }
    public bool EmanetKontrol(string EmanetNo)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet where EmanetNo=@EmanetNo";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@EmanetNo", EmanetNo);
      adp.Fill(dt);
      if (dt.Rows.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public void EmanetSil(string EmanetNo)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "delete from emanet where EmanetNo=@EmanetNo";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@EmanetNo", EmanetNo);
      komut.ExecuteNonQuery();

    }
    public void DurumGuncelle(string EmanetNo,string Durum)
    {

      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "update emanet set Durum=@Durum where EmanetNo=@EmanetNo";
      OleDbCommand komut = new OleDbCommand(sql, con);
      komut.Parameters.AddWithValue("@Durum", Durum);
      komut.Parameters.AddWithValue("@EmanetNo", EmanetNo);
      komut.ExecuteNonQuery();
      con.Close();

    }
    public DataTable emanetAramaUye(string uye)
    {
        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection(Yol());
        tablo.Clear();
        baglanti.Open();
        OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From uyeler where Adsoyad like '%" + uye + "%'", baglanti);
        adtr.Fill(tablo);
        return tablo;
    }
    public DataTable emanetAramaKitap(string kitap)
    {
        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection(Yol());
        tablo.Clear();
        baglanti.Open();
        OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From kitaplar where KitapAdi like '%" + kitap + "%'", baglanti);
        adtr.Fill(tablo);
        return tablo;
    }
    public DataTable EmanetVer1()
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable EmanetVer2()
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from uyeler";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable EmanetVer3()
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from kitaplar";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable EmanetAl()
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable emanetArama1(string Bul)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet where Adsoyad like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable emanetArama2(string Bul)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet where Tc like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable emanetArama3(string Bul)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet where KitapAdi like '%" + Bul + "%'";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.Fill(dt);
      return dt;
    }
    public DataTable EmanetGetir(string EmanetNo)
    {
      OleDbConnection con = new OleDbConnection(Yol());
      con.Open();
      string sql = "select * from emanet where EmanetNo=@EmanetNo";
      DataTable dt = new DataTable();
      OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
      adp.SelectCommand.Parameters.AddWithValue("@EmanetNo", EmanetNo);
      adp.Fill(dt);
      return dt;
    }
  }
}
