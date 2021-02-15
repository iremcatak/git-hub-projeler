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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TblDerslerTableAdapter ds = new DataSet1TableAdapters.TblDerslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.InsertQuery(textBox2.Text);
            MessageBox.Show("Ders eklendi.");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DeleteQuery(byte.Parse(textBox1.Text));
            MessageBox.Show("Ders silindi.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.UpdateQuery(textBox2.Text,byte.Parse(textBox1.Text));
            MessageBox.Show("Ders güncellendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
