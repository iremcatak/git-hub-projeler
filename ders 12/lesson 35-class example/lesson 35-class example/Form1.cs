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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car Car = new car();
            Car.color = "Blue";
            Car.speed = 180;
            Car.motor = 1201.32;
            Car.price = 20000;
            Car.usagestatus = 's';
            Car.YEAR = -2017;
            Car.BRAND = "fuji";
            Car.control = 2018;
            Car.licencePlate = "34 KI 2099";
            Car.owner = "Afife Jale";
            
            label1.Text = Car.color;
            label2.Text = Car.speed.ToString();
            label3.Text = Car.motor.ToString();
            label4.Text = Car.price.ToString();
            label5.Text = Car.usagestatus.ToString();
            label6.Text = Car.YEAR.ToString();
            label7.Text = Car.BRAND;
            pictureBox1.BackColor = Color.CadetBlue;
            label8.Text = Car.control.ToString();
            label9.Text = Car.licencePlate;
            label10.Text = Car.owner;


        }
    }
}
