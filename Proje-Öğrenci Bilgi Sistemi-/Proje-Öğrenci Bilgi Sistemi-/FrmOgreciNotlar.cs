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
    public partial class FrmOgreciNotlar : Form
    {
        public FrmOgreciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        public string numara;
        private void FrmOgreciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TblNotlar INNER JOIN TblDersler ON TblNotlar.DERSID = TblDersler.DERSID WHERE OGRID = @p1 ",baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            // this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

       
    }
}
