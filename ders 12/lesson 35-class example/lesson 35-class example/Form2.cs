using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_35_class_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            car Car2 = new car();
            Car2.color = "Red";
            Car2.speed = 240;
            Car2.motor = 2901.12;
            Car2.price = 120000;
            Car2.usagestatus = 'n';
            label1.Text = Car2.color;
            label2.Text = Car2.speed.ToString();
            label3.Text = Car2.motor.ToString();
            label4.Text = Car2.price.ToString();
            label5.Text = Car2.usagestatus.ToString();
            pictureBox1.BackColor = Color.IndianRed;
        }
    }
}
