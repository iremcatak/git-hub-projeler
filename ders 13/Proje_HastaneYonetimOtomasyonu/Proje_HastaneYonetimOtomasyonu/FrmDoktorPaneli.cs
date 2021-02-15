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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",tboxAd.Text);
            komut.Parameters.AddWithValue("@d2", tboxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cboxBrans.Text);
            komut.Parameters.AddWithValue("@d4", mtboxTC.Text);
            komut.Parameters.AddWithValue("@d5", tboxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //doktorları aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cboxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tboxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tboxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cboxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtboxTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tboxsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtboxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", tboxAd.Text);
            komut.Parameters.AddWithValue("@d2", tboxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cboxBrans.Text);
            komut.Parameters.AddWithValue("@d4", mtboxTC.Text);
            komut.Parameters.AddWithValue("@d5", tboxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
