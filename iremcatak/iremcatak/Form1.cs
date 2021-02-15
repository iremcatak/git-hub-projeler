using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iremcatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);
            // TODO: This line of code loads data into the 'dataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: This line of code loads data into the 'dataSet1.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: This line of code loads data into the 'dataSet1.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.dataSet1.Game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PL_ID, T_ID;
            int.TryParse(textBox6.Text, out PL_ID);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);
            this.playerTableAdapter.InsertQuery(textBox4.Text, textBox3.Text, PL_ID, T_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int C_ID, T_ID;
            int.TryParse(textBox10.Text, out C_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.InsertQuery(textBox8.Text, textBox9.Text,textBox5.Text, C_ID, T_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }
    }
}
