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
    public partial class StudentLogin : Form
    {
       
  
        public StudentLogin()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr;

            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT (*) FROM LoginStudent WHERE RegNum ='" + textBox1.Text + " ' AND password= '" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome!", textBox1.Text);
                    StudentHome StuHome = new StudentHome();
                    StuHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild Username or Password");
                }
            conn.Close();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
