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
    public partial class Gaurdian : Form
    {
        public Gaurdian()
        {
            InitializeComponent();
        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Gaurdian", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;

                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("INSERT INTO Gaurdian (ParInfoNum,RegNum,PName,PID,PAddress,PEmail,PPNum,PRShip,SName,SID,SAddress,SEmail,SPNum,SRShip) " +
                    "VALUES (@ParInfoNum,@RegNum,@PName,@PID,@PAddress,@PEmail,@PPNum,@PRShip,@SName,@SID,@SAddress,@SEmail,@SPNum,@SRShip)", conn);

                cmd.Parameters.Add("@ParInfoNum", SqlDbType.Int).Value = txtParInfoNum.Text;
                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@PName", SqlDbType.VarChar).Value = txtPName.Text;
                cmd.Parameters.Add("@PID", SqlDbType.NVarChar).Value = txtPID.Text;
                cmd.Parameters.Add("@PAddress", SqlDbType.VarChar).Value = txtPAdd.Text;
                cmd.Parameters.Add("@PEmail", SqlDbType.VarChar).Value = txtPEmail.Text;
                cmd.Parameters.Add("@PPNum", SqlDbType.NVarChar).Value = txtPPNum.Text;
                cmd.Parameters.Add("@PRShip", SqlDbType.VarChar).Value = txtPRShip.Text;
                cmd.Parameters.Add("@SName", SqlDbType.VarChar).Value = txtSName.Text;
                cmd.Parameters.Add("@SID", SqlDbType.NVarChar).Value = txtSID.Text;
                cmd.Parameters.Add("@SAddress", SqlDbType.VarChar).Value = txtSAdd.Text;
                cmd.Parameters.Add("@SEmail", SqlDbType.VarChar).Value = txtSEmail.Text;
                cmd.Parameters.Add("@SPNum", SqlDbType.NVarChar).Value = txtSPNum.Text;
                cmd.Parameters.Add("@SRShip", SqlDbType.VarChar).Value = txtSRShip.Text;
                
                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                disply();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM Gaurdian WHERE RegNum like '" + txtRegNum.Text + "%'", con);
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

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("UPDATE Gaurdian " +
                    "SET ParInfoNum=@ParInfoNum,PName=@PName,PID=@PID,PAddress=@PAddress,PEmail=@PEmail,PPNum=@PPNum,PRShip=@PRShip,SName=@SName,SID=@SID,SAddress=@SAddress,SEmail=@SEmail,SPNum=@SPNum,SRShip=@SRShip " +
                    " WHERE RegNum=@RegNum ", con);

                cmd.Parameters.Add("@ParInfoNum",SqlDbType.Int).Value= txtParInfoNum.Text;
                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@PName",SqlDbType.VarChar).Value= txtPName.Text;
                cmd.Parameters.Add("@PID",SqlDbType.NVarChar).Value= txtPID.Text;
                cmd.Parameters.Add("@PAddress",SqlDbType.VarChar).Value= txtPAdd.Text;
                cmd.Parameters.Add("@PEmail",SqlDbType.VarChar).Value= txtPEmail.Text;
                cmd.Parameters.Add("@PPNum",SqlDbType.NVarChar).Value= txtPPNum.Text;
                cmd.Parameters.Add("@PRShip", SqlDbType.VarChar).Value = txtPRShip.Text;
                cmd.Parameters.Add("@SName",SqlDbType.VarChar).Value= txtSName.Text;
                cmd.Parameters.Add("@SID",SqlDbType.NVarChar).Value= txtSID.Text;
                cmd.Parameters.Add("@SAddress",SqlDbType.VarChar).Value= txtSAdd.Text;
                cmd.Parameters.Add("@SEmail", SqlDbType.VarChar).Value = txtSEmail.Text;
                cmd.Parameters.Add("@SPNum",SqlDbType.NVarChar).Value= txtSPNum.Text;
                cmd.Parameters.Add("@SRShip",SqlDbType.VarChar).Value= txtSRShip.Text;
                a.UpdateCommand = cmd;
                a.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                con.Close();
                disply();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd;
                string command = string.Format("DELETE Gaurdian WHERE RegNum LIKE '" + txtRegNum.Text + "%'", con);
                SqlDataAdapter a = new SqlDataAdapter();
                con.Open();
                cmd = new SqlCommand(command, con);
                a.DeleteCommand = new SqlCommand(command, con);
                a.DeleteCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                disply();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            disply();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {

            txtParInfoNum.Text = string.Empty;
            txtRegNum.Text= string.Empty;
            txtPName.Text= string.Empty;
            txtPID.Text= string.Empty;
            txtPAdd.Text= string.Empty;
            txtPEmail.Text= string.Empty;
            txtPPNum.Text= string.Empty;
            txtPRShip.Text= string.Empty;
            txtSName.Text= string.Empty;
            txtSID.Text= string.Empty;
            txtSAdd.Text= string.Empty;
            txtSEmail.Text= string.Empty;
            txtSPNum.Text= string.Empty;
            txtSRShip.Text= string.Empty;
           
        }
    }
}
