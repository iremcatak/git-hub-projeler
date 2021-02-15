using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_28_pasta_pişirme_süreci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Beige;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Cyan;
            }
            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Lavender;
            }
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Magenta;
            }
            if (progressBar2.Value == 100)
            {

                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 40 == 0)
            {
                label3.BackColor = Color.Chocolate;
            }
            if (progressBar3.Value % 40 == 20)
            {
                label3.BackColor = Color.DarkGoldenrod;
            }
            if (progressBar3.Value == 100)
            {

                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.LightPink;
            }
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.Orchid;
            }
            if (progressBar4.Value == 100)
            {

                timer4.Stop();
                MessageBox.Show("Pasta hazır :)");
            }
        }
    }
}
