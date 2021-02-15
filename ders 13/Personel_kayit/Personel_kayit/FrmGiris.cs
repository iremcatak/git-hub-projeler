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
namespace Personel_kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", tboxkullanıcıadı.Text);
            komut.Parameters.AddWithValue("@p2", tboxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaEkran frm = new FrmAnaEkran();
                frm.Show();
                this.Hide();
                }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
            }
            baglanti.Close();
        }
    }
}
