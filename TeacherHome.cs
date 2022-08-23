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
    public partial class TeacherHome : Form
    {
        public TeacherHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserList logout = new UserList();
            logout.Show();
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM Teacher WHERE SNum like '" + txtSNum.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM FSTeacher WHERE SNum like '" + txtSNum.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
