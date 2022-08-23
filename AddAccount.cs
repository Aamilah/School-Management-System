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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void CreateA_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;

                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("INSERT INTO LoginAdmin  (Username, Password) " +
                    "VALUES (@Username, @Password)", conn);

                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUName.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPA.Text;

                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
                DataTable dt = new DataTable();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteA_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd;

                string command = string.Format("DELETE LoginAdmin WHERE Username LIKE '" + txtUName.Text + "%'", con);
                SqlDataAdapter a = new SqlDataAdapter();

                con.Open();
                cmd = new SqlCommand(command, con);
                a.DeleteCommand = new SqlCommand(command, con);
                a.DeleteCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                a.Fill(dt);

                MessageBox.Show("Record Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateT_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;

                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("INSERT INTO TeacherLogin  (SNum, password) " +
                    "VALUES (@SNum, @password)", conn);

                cmd.Parameters.Add("@SNum", SqlDbType.NVarChar).Value = txtSNum.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPT.Text;

                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
                DataTable dt = new DataTable();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd;

                string command = string.Format("DELETE TeacherLogin WHERE SNum LIKE '" + txtSNum.Text + "%'", con);
                SqlDataAdapter a = new SqlDataAdapter();

                con.Open();
                cmd = new SqlCommand(command, con);
                a.DeleteCommand = new SqlCommand(command, con);
                a.DeleteCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted Successfully!");
                DataTable dt = new DataTable();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateS_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;

                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("INSERT INTO LoginStudent  (RegNum, Password) " +
                    "VALUES (@RegNum, @Password)", conn);

                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPS.Text;

                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
                DataTable dt = new DataTable();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteS_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd;

                string command = string.Format("DELETE LoginStudent WHERE RegNum LIKE '" + txtRegNum.Text + "%'", con);
                SqlDataAdapter a = new SqlDataAdapter();

                con.Open();
                cmd = new SqlCommand(command, con);
                a.DeleteCommand = new SqlCommand(command, con);
                a.DeleteCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                a.Fill(dt);

                MessageBox.Show("Record Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }
    }
}
