using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_HastaneYonetimOtomasyonu
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mtboxTCKimlikno.Text = TCNO;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtboxTCKimlikno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tboxAd.Text = dr[1].ToString();
                tboxSoyad.Text = dr[2].ToString();
                cboxBrans.Text = dr[3].ToString();
                tboxsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tboxAd.Text);
            komut.Parameters.AddWithValue("@p2", tboxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cboxBrans.Text);
            komut.Parameters.AddWithValue("@p4", tboxsifre.Text);
            komut.Parameters.AddWithValue("@p5", mtboxTCKimlikno.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler güncellendi!");
        }
    }
}
