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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet)values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tboxAd.Text);
            komut.Parameters.AddWithValue("@p2",tboxSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mtboxTCKimlikno.Text);
            komut.Parameters.AddWithValue("@p4",mtboxTelefon.Text);
            komut.Parameters.AddWithValue("@p5",tboxsifre.Text);
            komut.Parameters.AddWithValue("@p6",cboxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız tamamlandı Şifreniz: " + tboxsifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
