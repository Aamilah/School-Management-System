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
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void Results_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapt;
            DataTable dt;

            con.Open();
            adapt = new SqlDataAdapter("select * from Exam where RegNum like '" + txtRegNum.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            UserList UList = new UserList();
            UList.Show();
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapt;
            DataTable dt;

            con.Open();
            adapt = new SqlDataAdapter("select * from Student where RegNum like '" + txtRegNum.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Fee_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM FSStudent WHERE RegNum like '" + txtRegNum.Text + "%'", con);
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

                adapt = new SqlDataAdapter("SELECT * FROM Subject WHERE SubCod like '" + txtSubCode.Text + "%'", con);
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
