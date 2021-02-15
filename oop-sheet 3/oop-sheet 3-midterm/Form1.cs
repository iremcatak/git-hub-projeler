using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_sheet_3_midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numberAdult;
        int numberChild;
        int numberInfant;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberChild += 1;
            label10.Text = numberChild.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string button;
            if (roundtrip.Checked == true)
            {
                button = "Round trip";
                MessageBox.Show(button);
                MessageBox.Show("From: " + comboBox1.Text + " to " + comboBox2.Text + "\nDate of dep: " + dep.Text + "\nDate of return: " + returntime.Text);
               
            }
            else if (oneway.Checked == true){
                button = "One way";
                MessageBox.Show(button);
                MessageBox.Show("to " + comboBox2.Text + "\nDate of dep: " + dep.Text);
                
            }

            MessageBox.Show("Adult amount: "+label9.Text+"\nChild amount: "+label10.Text+"\nInfant amount: "+label11.Text);

           MessageBox.Show("Passenger registration was successful. ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }

        private void addAdult_Click(object sender, EventArgs e)
        {
            numberAdult +=1;
            label9.Text = numberAdult.ToString();

        }

        private void minAdult_Click(object sender, EventArgs e)
        {
            numberAdult -= 1;
            label9.Text = numberAdult.ToString();
        }

        private void minChild_Click(object sender, EventArgs e)
        {
            numberChild -= 1;
            label10.Text = numberChild.ToString();
        }

        private void addInfant_Click(object sender, EventArgs e)
        {
            numberInfant += 1;
            label11.Text = numberInfant.ToString();
        }

        private void minInfant_Click(object sender, EventArgs e)
        {
            numberInfant -= 1;
            label11.Text = numberInfant.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
