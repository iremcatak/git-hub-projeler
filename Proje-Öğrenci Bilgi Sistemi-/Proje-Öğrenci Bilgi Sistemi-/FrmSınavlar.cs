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
    public partial class FrmSınavlar : Form
    {
        public FrmSınavlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        DataSet1TableAdapters.TblNotlarTableAdapter ds = new DataSet1TableAdapters.TblNotlarTableAdapter();
        int notid;
        private void FrmSınavlar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblDersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "DersID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData(int.Parse(tboxid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid=int.Parse( dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            tboxid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tboxsınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tboxsınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tboxsınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tboxproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tboxortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tboxdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
        
            //string durum;
            sınav1 = Convert.ToInt16(tboxsınav1.Text);
            sınav2 = Convert.ToInt16(tboxsınav2.Text);
            sınav3 = Convert.ToInt16(tboxsınav3.Text);
            proje = Convert.ToInt16(tboxproje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            tboxortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                tboxdurum.Text = "True";
            }
            else
            {
                tboxdurum.Text = "False";
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.UpdateQuery(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(tboxid.Text),byte.Parse(sınav1.ToString()), byte.Parse(sınav2.ToString()), byte.Parse(sınav3.ToString()), byte.Parse(proje.ToString()), byte.Parse(ortalama.ToString()), bool.Parse(tboxdurum.Text),notid);
        }
    }
    }

