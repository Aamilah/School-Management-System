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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Exam (RegNum, StuName, SubName, SubCod,Extype, Session, Mark,Total,Percentage,Grade,Remark) " +
                    "VALUES(@RegNum,@StuName, @SubName, @SubCod,@Extype, @Session, @Mark,@Total,@Percentage,@Grade,@Remark)", conn);

                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = txtStuName.Text;
                cmd.Parameters.Add("@SubName", SqlDbType.VarChar).Value = txtSubName.Text;
                cmd.Parameters.Add("@SubCod", SqlDbType.VarChar).Value = txtSubCod.Text;
                cmd.Parameters.Add("@Extype", SqlDbType.VarChar).Value = txtExamType.Text;
                cmd.Parameters.Add("@Session", SqlDbType.Int).Value = txtSession.Text;
                cmd.Parameters.Add("@Mark", SqlDbType.Int).Value = txtMark.Text;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = txtTotal.Text;
                cmd.Parameters.Add("@Percentage", SqlDbType.Int).Value = txtPercent.Text;
                cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = cmboxGrade.Text.ToString();
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;
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

        private void Delete_Click(object sender, EventArgs e)
        {
          

            string constr;

            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";

            SqlConnection con = new SqlConnection(constr);           
            SqlCommand cmd;
            string command = string.Format("delete Exam where RegNum like '" + txtRegNum.Text + "%'", con);          
            SqlDataAdapter a = new SqlDataAdapter();
            con.Open();         
            cmd = new SqlCommand(command, con);
            a.InsertCommand = new SqlCommand(command, con);
            a.InsertCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            disply();
        }
        
        private void Exam_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Exam", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            disply();
        }

        private void Search_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                SqlCommand cmd = new SqlCommand("UPDATE Exam " +
                    "SET StuName=@StuName, SubName=@SubName, SubCod=@SubCod,Extype=@Extype,Session=@Session,Mark=@Mark,Total=@Total,Percentage=@Percentage,Grade=@Grade,Remark=@Remark " +
                    "WHERE RegNum=@RegNum ", con);

                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = txtStuName.Text;
                cmd.Parameters.Add("@SubName", SqlDbType.VarChar).Value = txtSubName.Text;
                cmd.Parameters.Add("@SubCod", SqlDbType.VarChar).Value = txtSubCod.Text;
                cmd.Parameters.Add("@Extype", SqlDbType.VarChar).Value = txtExamType.Text;
                cmd.Parameters.Add("@Session", SqlDbType.Int).Value = txtSession.Text;
                cmd.Parameters.Add("@Mark", SqlDbType.Int).Value = txtMark.Text;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = txtTotal.Text;
                cmd.Parameters.Add("@Percentage", SqlDbType.Int).Value = txtPercent.Text;
                cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = cmboxGrade.Text.ToString();
                cmd.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;

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

        private void txtMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmboxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtExamType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStuName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtRegNum.Text = string.Empty;
            txtStuName.Text = string.Empty;
            txtSubName.Text = string.Empty;
            txtSubCod.Text = string.Empty;
            txtExamType.Text = string.Empty;
            txtSession.Text = string.Empty;
            txtMark.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtPercent.Text = string.Empty;
            cmboxGrade.Text = "Pick Grade";
            txtRemark.Text = string.Empty;

        }
    }
}

