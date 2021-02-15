using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouthLeague_İremCatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
            // TODO: This line of code loads data into the 'dataSet1.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: This line of code loads data into the 'dataSet1.Parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.dataSet1.Parents);
            // TODO: This line of code loads data into the 'dataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void button1_Click_1(object sender, EventArgs e)//INSERT TEAM
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button11_Click(object sender, EventArgs e)//INSERT PLAYER
        {
            int T_Id, PL_Age;
            int.TryParse(textBox13.Text, out PL_Age);
            int.TryParse(comboBox11.SelectedValue.ToString(), out T_Id);
            this.playerTableAdapter.InsertQuery(textBox11.Text, textBox12.Text, PL_Age, T_Id);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button41_Click(object sender, EventArgs e)//INSERT COACH
        {
            int T_Id,C_phone;
            int.TryParse(comboBox41.SelectedValue.ToString(), out T_Id);
            int.TryParse(textBox43.Text, out C_phone);
            this.coachTableAdapter.InsertQuery(textBox41.Text, textBox42.Text, C_phone , T_Id);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button21_Click(object sender, EventArgs e)//INSERT PARENT
        {
            int P_phone;
            int.TryParse(textBox23.Text, out P_phone);
            this.parentsTableAdapter.InsertQuery(textBox21.Text, textBox22.Text, P_phone, textBox0.Text );
            this.parentsTableAdapter.Fill(this.dataSet1.Parents);
        }


        private void button4_Click(object sender, EventArgs e)//INSERT ENROLL
        {
            int PL_Id, PR_Id;
            int.TryParse(comboBox51.SelectedValue.ToString(), out PL_Id);
            int.TryParse(comboBox52.SelectedValue.ToString(), out PR_Id);
            this.enrollTableAdapter.InsertQuery( PL_Id,PR_Id);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button2_Click(object sender, EventArgs e)//UPDATE TEAM
        {
            int T_ID;
            int.TryParse(textBox3.Text, out T_ID);
            this.teamTableAdapter.UpdateQuery(textBox4.Text, textBox5.Text, T_ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button3_Click(object sender, EventArgs e)//DELETE TEAM
        {
            int T_ID;
            int.TryParse(textBox6.Text, out T_ID);
            this.teamTableAdapter.DeleteQuery(T_ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button12_Click(object sender, EventArgs e)//PLAYER UPDATE
        {
            int PL_ID;
            int.TryParse(textBox14.Text, out PL_ID);
            this.playerTableAdapter.UpdateQuery( PL_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }
      
        private void button13_Click(object sender, EventArgs e)//DELETE PLAYER
        {
            int P_ID;
            int.TryParse(textBox18.Text, out P_ID);
            this.playerTableAdapter.DeleteQuery(P_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button43_Click(object sender, EventArgs e)//DELETE COACH
        {
            int C_ID;
            int.TryParse(textBox48.Text, out C_ID);
            this.coachTableAdapter.DeleteQuery(C_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button23_Click(object sender, EventArgs e)//DELETE PARENT
        {
            int PR_ID;
            int.TryParse(textBox30.Text, out PR_ID);
            this.parentsTableAdapter.DeleteQuery(PR_ID);
            this.parentsTableAdapter.Fill(this.dataSet1.Parents);
        }

        private void button5_Click(object sender, EventArgs e)//DELETE ENROLL
        {
            int Enroll_ID;
            int.TryParse(textBox52.Text, out Enroll_ID);
            this.enrollTableAdapter.DeleteQuery(Enroll_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button22_Click(object sender, EventArgs e)//PARENT UPDATE
        {
            int P_phone,PR_ID;
            int.TryParse(textBox28.Text, out P_phone);
            int.TryParse(textBox25.Text, out PR_ID);
            this.parentsTableAdapter.UpdateQuery(PR_ID,textBox26.Text, textBox27.Text, P_phone, textBox29.Text);
            this.parentsTableAdapter.Fill(this.dataSet1.Parents);
        }

        private void button42_Click(object sender, EventArgs e)//COACH UPDATE
        {
            int T_Id, C_Id,C_phone;
            int.TryParse(comboBox42.SelectedValue.ToString(), out T_Id);
            int.TryParse(textBox43.Text, out C_phone);
            int.TryParse(textBox44.Text, out C_Id);
            this.coachTableAdapter.UpdateQuery(textBox45.Text, textBox46.Text, C_phone, T_Id, C_Id);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button6_Click(object sender, EventArgs e)//ENROLL UPDATE
        {
            int PL_Id, PR_Id;
            int.TryParse(comboBox51.SelectedValue.ToString(), out PL_Id);
            int.TryParse(comboBox52.SelectedValue.ToString(), out PR_Id);
            this.enrollTableAdapter.UpdateQuery(textBox51.Text,PL_Id, PR_Id);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }


    }
}
