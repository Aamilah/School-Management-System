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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Subject", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Home_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Subject (SubCod,SubNam,CRoom,Day, CStart, CEnd, SNum,TName,TOffice) " +
                    "VALUES ( @SubCod,@SubNam, @CRoom, @Day,@CStart,@CEnd,@SNum, @TName, @TOffice)", conn);

                    cmd.Parameters.Add("@SubCod",SqlDbType.Int).Value = txtSubCod.Text;        
                    cmd.Parameters.Add("@SubNam",SqlDbType. VarChar).Value= txtSubName.Text;            
                    cmd.Parameters.Add("@CRoom",SqlDbType.  VarChar).Value= txtCRoom.Text;
                    cmd.Parameters.Add("@Day",SqlDbType.    VarChar).Value= cmboxDay.Text.ToString();
                    cmd.Parameters.Add("@CStart",SqlDbType.Int).Value = txtCStart.Text;    
                    cmd.Parameters.Add("@CEnd",SqlDbType.Int).Value = txtCEnd.Text;    
                    cmd.Parameters.Add("@SNum",SqlDbType.   NVarChar).Value= txtSNum.Text;
                    cmd.Parameters.Add("@TName",SqlDbType.  VarChar).Value= txtTName.Text;
                    cmd.Parameters.Add("@TOffice",SqlDbType.NVarChar).Value= txtTOffice.Text;       

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

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("UPDATE Subject " +
                    "SET SubNam=@SubNam,CRoom= @CRoom,Day=@Day, CStart=@CStart, CEnd=@CEnd, SNum=@SNum,TName= @TName,TOffice= @TOffice " +
                    " WHERE  SubCod= @SubCod ", con);


                    cmd.Parameters.Add("@SubCod",SqlDbType.Int).Value = txtSubCod.Text;        
                    cmd.Parameters.Add("@SubNam",SqlDbType. VarChar).Value= txtSubName.Text;            
                    cmd.Parameters.Add("@CRoom",SqlDbType.  VarChar).Value= txtCRoom.Text;
                    cmd.Parameters.Add("@Day",SqlDbType.    VarChar).Value= cmboxDay.Text.ToString();
                    cmd.Parameters.Add("@CStart",SqlDbType.Int).Value = txtCStart.Text;    
                    cmd.Parameters.Add("@CEnd",SqlDbType.Int).Value = txtCEnd.Text;    
                    cmd.Parameters.Add("@SNum",SqlDbType.   NVarChar).Value= txtSNum.Text;
                    cmd.Parameters.Add("@TName",SqlDbType.  VarChar).Value= txtTName.Text;
                    cmd.Parameters.Add("@TOffice",SqlDbType.VarChar).Value= txtTOffice.Text;

                a.UpdateCommand = cmd;
                a.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                disply();
                con.Close();
               
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
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM Subject WHERE Subcod like '" + txtSubCod.Text + "%'", con);
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

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtSubCod.Text = string.Empty;
            txtSubName.Text = string.Empty;
            txtCRoom.Text = string.Empty;
            cmboxDay.Text = " ";
            txtCStart.Text = string.Empty;
            txtCEnd.Text = string.Empty;
            txtSNum.Text = string.Empty;
            txtTName.Text = string.Empty;
            txtTOffice.Text = string.Empty;
        }
    }
}
