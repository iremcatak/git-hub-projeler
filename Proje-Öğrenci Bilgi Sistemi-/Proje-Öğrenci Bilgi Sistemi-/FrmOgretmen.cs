using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Öğrenci_Bilgi_Sistemi_
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmogrenci fr = new Frmogrenci();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSınavlar fr = new FrmSınavlar();
            fr.Show();
        }
    }
}
