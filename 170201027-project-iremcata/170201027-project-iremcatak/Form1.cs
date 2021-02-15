using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170201027_project_iremcatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            // TODO: This line of code loads data into the 'dataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.dataSet1.Order);
            // TODO: This line of code loads data into the 'dataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.dataSet1.Company);
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);
            // TODO: This line of code loads data into the 'dataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
        private void button1_Click(object sender, EventArgs e)//product insert
        {
            double P_Price, S_Price;
            double.TryParse(textBox2.Text, out P_Price);
            double.TryParse(textBox3.Text, out S_Price);
            this.productTableAdapter.InsertQuery(textBox1.Text, P_Price, S_Price);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
        private void button6_Click(object sender, EventArgs e)//customer insert
        {
            int C_Phone;
            int.TryParse(textBox11.Text, out C_Phone);
            this.customerTableAdapter.InsertQuery(textBox9.Text, textBox10.Text, C_Phone, textBox12.Text);
            this.customerTableAdapter.Fill(this.dataSet1.Customer);
        }
        private void button9_Click(object sender, EventArgs e)//company insert
        {
            int Com_Phone;
            int.TryParse(textBox21.Text, out Com_Phone);
            this.companyTableAdapter.InsertQuery(textBox20.Text,  Com_Phone, textBox22.Text);
            this.companyTableAdapter.Fill(this.dataSet1.Company);
        }
        private void button12_Click(object sender, EventArgs e)//order insert
        {
            int piece;
            DateTime Date;
            int.TryParse(textBox15.Text, out piece);
            DateTime.TryParse(maskedTextBox1.Text, out Date);
            this.orderTableAdapter.InsertQuery (Date,piece);
            this.orderTableAdapter.Fill(this.dataSet1.Order);
        }
        private void button17_Click(object sender, EventArgs e)//category insert
        {
            this.categoryTableAdapter.InsertQuery(textBox34.Text);
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
        }
        //*****************************************************************************
        private void button2_Click(object sender, EventArgs e)//product update
        {
            int P_ID;
            double P_Price, S_Price;
            double.TryParse(textBox6.Text, out P_Price);
            double.TryParse(textBox7.Text, out S_Price);
            int.TryParse(textBox4.Text, out P_ID);
            this.productTableAdapter.UpdateQuery(textBox5.Text, P_Price, S_Price,P_ID);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
        private void button5_Click(object sender, EventArgs e)//customer update
        {
            int Cus_ID;
            int Cus_Phone;
            int.TryParse(textBox17.Text, out Cus_Phone);
            int.TryParse(textBox13.Text, out Cus_ID);
            this.customerTableAdapter.UpdateQuery(textBox14.Text, textBox16.Text, Cus_Phone, textBox18.Text,Cus_ID);
            this.customerTableAdapter.Fill(this.dataSet1.Customer);
        }
        private void button8_Click(object sender, EventArgs e)//company update
        {
            int Com_ID;
            int Com_Phone;
            int.TryParse(textBox25.Text, out Com_Phone);
            int.TryParse(textBox23.Text, out Com_ID);
            this.companyTableAdapter.UpdateQuery( textBox24.Text, Com_Phone, textBox26.Text,Com_ID);
            this.companyTableAdapter.Fill(this.dataSet1.Company);
        }
        private void button11_Click(object sender, EventArgs e)//order update
        {   
            int OR_ID;
            int piece;
            DateTime Date;
            int.TryParse(textBox28.Text, out piece);
            int.TryParse(textBox29.Text, out OR_ID);
            DateTime.TryParse(maskedTextBox2.Text, out Date);
            this.orderTableAdapter.UpdateQuery(Date, piece,OR_ID);
            this.orderTableAdapter.Fill(this.dataSet1.Order);
        }
        
        private void button16_Click(object sender, EventArgs e)//category update
        {
            int Cat_ID;
            int.TryParse(textBox37.Text, out Cat_ID);
            this.categoryTableAdapter.UpdateQuery(textBox36.Text,Cat_ID);
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
        }
        //*************************************************************************
        private void button13_Click(object sender, EventArgs e)//category delete
        {
            int Cat_ID;
            int.TryParse(textBox35.Text, out Cat_ID);
            this.categoryTableAdapter.DeleteQuery(Cat_ID);
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
        }
        private void button3_Click(object sender, EventArgs e)//product delete
        {
            int P_ID;
            int.TryParse(textBox8.Text, out P_ID);
            this.productTableAdapter.DeleteQuery(P_ID);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
        private void button4_Click(object sender, EventArgs e)//customer delete
        {
            int Cus_ID;
            int.TryParse(textBox19.Text, out Cus_ID);
            this.customerTableAdapter.DeleteQuery(Cus_ID);
            this.customerTableAdapter.Fill(this.dataSet1.Customer);
        }
        private void button10_Click(object sender, EventArgs e)//order delete
        {
            int O_ID;
            int.TryParse(textBox31.Text, out O_ID);
            this.orderTableAdapter.DeleteQuery(O_ID);
            this.orderTableAdapter.Fill(this.dataSet1.Order);
        }
        private void button7_Click(object sender, EventArgs e)//company delete
        {
            int Com_ID;
            int.TryParse(textBox27.Text, out Com_ID);
            this.companyTableAdapter.DeleteQuery(Com_ID);
            this.companyTableAdapter.Fill(this.dataSet1.Company);
        }
    }
}
