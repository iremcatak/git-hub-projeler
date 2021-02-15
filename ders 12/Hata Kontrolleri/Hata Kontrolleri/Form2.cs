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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //exception
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
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
               
            }
            

        }
    }
}
