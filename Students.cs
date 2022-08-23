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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
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
               
                var DOB = dateTimePickerDOB.Value;
                SqlCommand cmd = new SqlCommand("INSERT INTO Student ( RegNum, FName,LName,OName,DOB, Gender,Class,FeeStat,ParInfoNum, Address) " +
                   "VALUES (@RegNum, @FName,@LName,@OName,@DOB, @Gender,@Class,@FeeStat,@ParInfoNum, @Address)",conn);
                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@FName", SqlDbType.NVarChar).Value = txtFName.Text;
                cmd.Parameters.Add("@LName", SqlDbType.NVarChar).Value = txtLName.Text;
                cmd.Parameters.Add("@OName", SqlDbType.NVarChar).Value = txtOName.Text;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dateTimePickerDOB.Value;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = cmboxGender.Text.ToString();
                cmd.Parameters.Add("@Class", SqlDbType.NVarChar).Value = cmboxClass.Text.ToString();
                cmd.Parameters.Add("@FeeStat", SqlDbType.NVarChar).Value = cmboxfee.Text.ToString();
                cmd.Parameters.Add("@ParInfoNum", SqlDbType.Int).Value = txtParInfoNum.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtadd.Text;
                
                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd;
                string command = string.Format("delete Student where RegNum like '" + txtRegNum.Text + "%'", con);
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

        private void Search_Click(object sender, EventArgs e)
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

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Student " +
                    "SET FName=@FName,LName= @LName,OName=@OName,DOB=@DOB,Gender=@Gender,Class=@Class,FeeStat=@FeeStat,ParInfoNum=@ParInfoNum,Address=@Address " +
                    "WHERE RegNum =@RegNum ", con);
                cmd.Parameters.AddWithValue("@RegNum", txtRegNum.Text);
                cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLName.Text); 
                cmd.Parameters.AddWithValue("@OName", txtOName.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePickerDOB.Value);
                cmd.Parameters.AddWithValue("@Gender", cmboxGender.Text);
                cmd.Parameters.AddWithValue("@Class", cmboxClass.Text);
                cmd.Parameters.AddWithValue("@FeeStat", cmboxfee.Text);
                cmd.Parameters.AddWithValue("@ParInfoNum", txtParInfoNum.Text);
                cmd.Parameters.AddWithValue("@Address", txtadd.Text);
                
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

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtRegNum.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtOName.Text = string.Empty;
            cmboxGender.Text= "State Gender";
            cmboxClass.Text = "Choose Class";
            cmboxfee.Text = "Declare Status";
            txtParInfoNum.Text = string.Empty;
            txtadd.Text = string.Empty;
        }
    }
}
