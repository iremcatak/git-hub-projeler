using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, toplam, çarpım, fark, bölüm;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            toplam = sayı1 + sayı2;
            çarpım = sayı1 * sayı2;
            bölüm = sayı1 / sayı2;
            fark = sayı1 - sayı2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark: " + fark + "\n" + "Çarpım: " + çarpım + "\n" + "Bölüm: " + bölüm);


        }
    }
}
