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
    public partial class Form2Login : Form
    {

        public Form2Login()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vivek\Documents\5-C#.NET Projects\0-C# Form App\Student Portal\LogDB.accdb");

                conn.Open();
                //MessageBox.Show("Connection Open!");

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "select * from Logs where username='" + textBox1_U.Text + "' and pass='" + textBox2_P.Text + "'";

                OleDbDataReader reader= command.ExecuteReader();

                int count = 0;
                while(reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successfully!");
                    WelcomeForm wel = new WelcomeForm() ;
                    wel.Show();

                    this.Visible = false;
                }
               // if (count > 1)
               // { MessageBox.Show("Duplicate Username and Password"); }
                else
                { MessageBox.Show("Username or Password incorrect, Please Check..."); }

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Register reg = new Register();
            reg.Show();

            this.Visible = false;
        
        }
    }
}
