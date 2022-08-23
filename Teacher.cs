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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("INSERT INTO Teacher (SNum, FName,LName,OName,Gender,MStatus,Address,SubCod,SalaryStat,Amount,TOffice) " +
                    "VALUES (@SNum, @FName, @LName,@OName,@Gender,@MStatus,@Address,@SubCod, @SalaryStat,@Amount,@TOffice)", conn);

                cmd.Parameters.Add("@SNum", SqlDbType.NVarChar).Value = txtSNum.Text;
                cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = txtFName.Text;
                cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = txtLName.Text;
                cmd.Parameters.Add("@OName", SqlDbType.VarChar).Value = txtOName.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cmboxGender.Text.ToString();
                cmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = cmboxMStatus.Text.ToString();
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAdd.Text;
                cmd.Parameters.Add("@SubCod", SqlDbType.Int).Value = txtSubCode.Text;
                cmd.Parameters.Add("@SalaryStat", SqlDbType.VarChar).Value = cmboxSalary.Text.ToString();
                cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = txtASalary.Text;
                cmd.Parameters.Add("@TOffice", SqlDbType.VarChar).Value = txtTOffice.Text;

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

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("UPDATE Teacher" +
                    " SET FName=@FName, LName=@LName, OName=@OName, Gender=@Gender, MStatus=@MStatus, Address=@Address, SubCod=@SubCod, SalaryStat=@SalaryStat, Amount=@Amount, TOffice=@TOffice" +
                    " WHERE SNum=@SNum",con);

                cmd.Parameters.Add("@SNum", SqlDbType.NVarChar).Value = txtSNum.Text;
                cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = txtFName.Text;
                cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = txtLName.Text;
                cmd.Parameters.Add("@OName", SqlDbType.VarChar).Value = txtOName.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cmboxGender.Text.ToString();
                cmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = cmboxMStatus.Text.ToString();
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAdd.Text;
                cmd.Parameters.Add("@SubCod", SqlDbType.Int).Value = txtSubCode.Text;
                cmd.Parameters.Add("@SalaryStat", SqlDbType.VarChar).Value = cmboxSalary.Text.ToString();
                cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = txtASalary.Text;
                cmd.Parameters.Add("@TOffice", SqlDbType.VarChar).Value = txtTOffice.Text;

                ad.UpdateCommand = cmd;
                ad.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated!");
                disply();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teacher", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                string command = string.Format("DELETE Teacher WHERE SNum LIKE '" + txtSNum.Text + "%'", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
             txtSNum.Text= string.Empty;
             txtFName.Text= string.Empty;
             txtLName.Text= string.Empty;
             txtOName.Text= string.Empty;
             cmboxGender.Text= "Pick Gender";
             cmboxMStatus.Text= "Indicate Status";
             txtAdd.Text= string.Empty;
             txtSubCode.Text= string.Empty;
             cmboxSalary.Text= "Indicate Status";
             txtASalary.Text= string.Empty;

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }
    }
}
