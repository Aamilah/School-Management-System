using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class LoginAdmin : Form
    {
        string query = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30";
        public LoginAdmin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(query))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT (*) FROM LoginAdmin WHERE username='" + textBox1.Text + " ' AND password= '" + textBox2.Text + "'", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome!", textBox1.Text);
                    MainForm Mform = new MainForm();
                    Mform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild Username or Password");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
