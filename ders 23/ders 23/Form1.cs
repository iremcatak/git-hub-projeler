﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("Hello Tunceli");
                listBox2.Items.Add(i);
                i++;
            }

            int j = 1;
            int toplam=0;
            while (j <= 5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());
     



        }
    }
}
