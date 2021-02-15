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
namespace Proje_Öğrenci_Bilgi_Sistemi_
{
    public partial class Frmogrenci : Form
    {
        public Frmogrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
       
        private void Frmogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKulupler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember="KulupAd";
            comboBox1.ValueMember="KulupID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }
        string cinsiyet = "";
        private void btnekle_Click(object sender, EventArgs e)
        {
            string cinsiyet="";
            if (rbtnkız.Checked == true)
            {
                cinsiyet = "Kadın";
            }
            if (rbtnerkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            ds.InsertQuery(tboxad.Text,tboxsoyad.Text, cinsiyet, byte.Parse(comboBox1.SelectedValue.ToString()));
            MessageBox.Show("Öğrenci eklendi.");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // tboxid.Text = comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tboxad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tboxsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DeleteQuery(int.Parse(tboxid.Text));
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.UpdateQuery(tboxad.Text, tboxsoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), cinsiyet, int.Parse(tboxid.Text));
        }

        private void rbtnkız_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbtnkız.Checked == true)
            {
                cinsiyet = "Kadın";
            }
          
        }

        private void rbtnerkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnerkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.GetDataBy3(textBox1.Text);
        }
    }
}
