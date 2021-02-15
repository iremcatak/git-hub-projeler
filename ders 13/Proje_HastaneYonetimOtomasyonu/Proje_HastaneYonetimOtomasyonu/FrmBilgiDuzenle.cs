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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mtboxTCKimlikno.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mtboxTCKimlikno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tboxAd.Text = dr[1].ToString();
                tboxSoyad.Text = dr[2].ToString();
                mtboxTelefon.Text = dr[4].ToString();
                tboxsifre.Text = dr[5].ToString();
                cboxCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", tboxAd.Text);
            komut2.Parameters.AddWithValue("@p2", tboxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mtboxTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", tboxsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cboxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mtboxTCKimlikno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme yapıldı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
