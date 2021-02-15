using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_exercise
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
            Car2.color = "black";
            Car2.speed = 210;
            Car2.motor = 1195;
            Car2.price = 180000;
            Car2.status = 's';
            Car2.Brand = "bmw";
            Car2.Year = 1996;
            Car2.control = 2017;
            Car2.licenceplate = "89 JK 1092";
            Car2.owner = "Jane Eyre";
            label1.Text = Car2.color;
            label2.Text = Car2.speed.ToString();
            label3.Text = Car2.motor.ToString();
            label4.Text = Car2.price.ToString();
            label5.Text = Car2.status.ToString();
            pictureBox1.BackColor = Color.Chocolate;
            label6.Text = Car2.Brand;
            label7.Text = Car2.Year.ToString();
            label8.Text = Car2.Year.ToString();
            label9.Text = Car2.control.ToString();
            label10.Text = Car2.licenceplate;
        }
    }
}
