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

namespace WindowsFormOdev.girisler
{
    public partial class user : UserControl
    {
        Tumkodlar kodlar = new Tumkodlar();
        public user()
        {
            InitializeComponent();
        }

        private void appBarClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string KAdi;
        public static string Yetki;
        private void GirisYap_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(kodlar.Yol());
            con.Open();
            string sql = "select * from uyeler where Tc=@Tc and Sifre=@Sifre";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@Tc", kullanici.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Sifre", sifre.Text);
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız. Lütfen Bilgilerinizi Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Yetki = dt.Rows[0]["Yetki"].ToString();
                if (Yetki == "Üye" || Yetki == "Yetkili")
                {

                    kullanici uyeForm = new kullanici();
                    uyeForm.Show();
                    Giris ac = (Giris)((Panel)Parent).Parent;
                    ac.Hide();
                }
                else
                {
                    MessageBox.Show("Üyeliğiniz Aktifleştirilmemiş Olabilir. Lütfen Yetkililerle İletişime Geçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
