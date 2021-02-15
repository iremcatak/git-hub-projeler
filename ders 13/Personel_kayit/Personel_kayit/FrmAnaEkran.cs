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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabanıDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet.Tbl_Personel);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cboxsehir.Text);
            komut.Parameters.AddWithValue("@p4", mtboxmaas.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            //executenonquery--->sorguyu çalıştırır.
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi.");
        }

        private void rbtnevli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnevli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void rbtnbekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnbekar.Checked == true)
            {
                label8.Text = "False";
            }
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmeslek.Text = "";
            mtboxmaas.Text = "";
            cboxsehir.Text = "";
            rbtnbekar.Checked = false;
            rbtnevli.Checked = false;
            txtad.Focus();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mtboxmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cboxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                rbtnevli.Checked = true;
            }
            if (label8.Text == "False")
            {
                rbtnbekar.Checked = true;
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cboxsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mtboxmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgi güncellendi.");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void Grafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}
