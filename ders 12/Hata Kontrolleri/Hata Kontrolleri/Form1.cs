﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //try-catch hata yakalama
            try
            {
                int sayi1 = Convert.ToInt16(tboxSayi1.Text);
                int sayi2 = Convert.ToInt16(tBoxSayi2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen değerlerinizi kontrol edin!");
            }
        }
    }
}