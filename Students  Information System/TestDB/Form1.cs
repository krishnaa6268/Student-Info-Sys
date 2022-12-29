// Developed By Krishna Kumar Gupta @2022_Col_Project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace TestDB
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string Gedner;
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vivek\Documents\5-C#.NET Projects\0-C# Form App\Student Portal\LogDB.accdb");
            try{
                con.Open();

                OleDbCommand cmd = new OleDbCommand("INSERT INTO Logs(username,pass,mob,gender,dob,course) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + Gedner + "','" + this.dateTimePicker1.Text + "','"+this.listBox1.Text+"')", con);


                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Register!");

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gedner = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gedner = "Female";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gedner = "Others";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Experties_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2Login fm = new Form2Login();
            fm.Show();
          
            this.Visible = false;

        }
    }
}
