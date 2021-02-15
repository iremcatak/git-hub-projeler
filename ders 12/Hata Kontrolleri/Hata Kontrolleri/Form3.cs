using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hata_Kontrolleri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //finally
            try
            {
                int sayi1;
                int sayi2;
                int sonuc;
                sayi1 = Convert.ToInt16(textBox1.Text);
                sayi2 = Convert.ToInt16(textBox2.Text);
                sonuc = sayi1 * sayi2;
                label1.Text = sonuc.ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("Hatalı program.Yalnızca bu kısım çalıştı.");
            }
            finally
            {
                MessageBox.Show("Finally kodu çalıştı.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
