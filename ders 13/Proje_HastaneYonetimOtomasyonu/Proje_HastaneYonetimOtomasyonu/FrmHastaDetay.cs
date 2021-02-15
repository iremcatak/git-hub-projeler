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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string TC;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TC;
            //ad soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] +" "+dr[1];
            }
            bgl.baglanti().Close();
            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + TC, bgl.baglanti());
            da.Fill(dt);
            dgviewrandevugeçmişi.DataSource = dt;
            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cboxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void cboxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxDoktor.Items.Clear();
            //doktor çekme
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cboxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cboxDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cboxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cboxBrans.Text + "'"+ "and RandevuDoktor='"+ cboxDoktor.Text+"' and RandevuDurum=0" , bgl.baglanti());
            // ' yazmak için " kullanmak gerekiyor. ' Sqlde kelime bazlı arama yapmayı sağlar
            da.Fill(dt);
            dgviewaktifradevular.DataSource = dt;
        }

        private void llblbilgileriduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lblTCNo.Text;
            fr.Show();
        }

        private void dgviewaktifradevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgviewaktifradevular.SelectedCells[0].RowIndex;
            txtID.Text = dgviewaktifradevular.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randeuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            komut.Parameters.AddWithValue("@p2", rtboxSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
