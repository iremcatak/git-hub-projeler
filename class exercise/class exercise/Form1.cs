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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car Car = new car();
            Car.color = "gray";
            Car.speed = 240;
            Car.motor = 1394;
            Car.price = 200000;
            Car.status = 'n';
            Car.Brand = "cadillac";
            Car.Year = 1980;
            Car.control = 2019;
            Car.licenceplate = "89 AI 1234";
            Car.owner = "Mr. Bean";
            label1.Text = Car.color;
            label2.Text = Car.speed.ToString();
            label3.Text = Car.motor.ToString();
            label4.Text = Car.price.ToString();
            label5.Text = Car.status.ToString();
            label6.Text = Car.Brand;
            label7.Text = Car.Year.ToString();
            pictureBox1.BackColor = Color.Crimson;
            label8.Text = Car.Year.ToString();
            label9.Text = Car.control.ToString();
            label10.Text = Car.licenceplate;
         

        }
    }
}
