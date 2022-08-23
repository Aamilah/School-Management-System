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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        

        private void Fees_Load_1(object sender, EventArgs e)
        {

        }

        void disply()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FSStudent", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
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
                SqlCommand cmd = new SqlCommand("UPDATE FSStudent " +
                    "SET  AmountDue =  @AmountDue,AmountPaid = @AmountPaid,FeeStat = @FeeStat,OutStand =  @OutStand,PayForm = @PayForm,Deadline =  @Deadline " +
                    " WHERE RegNum=@RegNum ", con);

                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@AmountDue", SqlDbType.NVarChar).Value = txtADue.Text;
                cmd.Parameters.Add("@AmountPaid", SqlDbType.NVarChar).Value = txtAPaid.Text;
                cmd.Parameters.Add("@FeeStat", SqlDbType.VarChar).Value = cmboxFeeStat.Text.ToString();
                cmd.Parameters.Add("@OutStand", SqlDbType.NVarChar).Value = txtALeft.Text;
                cmd.Parameters.Add("@PayForm", SqlDbType.VarChar).Value = cmboxPForm.Text.ToString();
                cmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = dateTimePicker1.Value;


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

        private void label4_Click(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("INSERT INTO FSStudent ( RegNum, AmountDue,AmountPaid,FeeStat,OutStand,PayForm,Deadline) " +
                    "VALUES (@RegNum, @AmountDue, @AmountPaid, @FeeStat, @OutStand, @PayForm, @Deadline)", conn);

                cmd.Parameters.Add("@RegNum", SqlDbType.NVarChar).Value = txtRegNum.Text;
                cmd.Parameters.Add("@AmountDue", SqlDbType.NVarChar).Value = txtADue.Text;
                cmd.Parameters.Add("@AmountPaid", SqlDbType.NVarChar).Value = txtAPaid.Text;
                cmd.Parameters.Add("@FeeStat", SqlDbType.VarChar).Value = cmboxFeeStat.Text.ToString();
                cmd.Parameters.Add("@OutStand", SqlDbType.NVarChar).Value = txtALeft.Text;
                cmd.Parameters.Add("@PayForm", SqlDbType.VarChar).Value = cmboxPForm.Text.ToString();
                cmd.Parameters.Add("@Deadline", SqlDbType.Date).Value = dateTimePicker1.Value;

                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
                disply();
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
                string command = string.Format("DELETE FSStudent WHERE RegNum LIKE '" + txtRegNum.Text + "%'", con);
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

        private void DisplayS_Click(object sender, EventArgs e)
        {
            disply();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtRegNum.Text = string.Empty;
            txtADue.Text = string.Empty;
            txtAPaid.Text = string.Empty;
            cmboxFeeStat.Text = " ";
            txtALeft.Text = string.Empty;
            cmboxPForm.Text = " ";
        }

        void display()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FSTeacher", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("INSERT INTO FSTeacher (SNum,SAmount,SStatus,PForm,PaidBy) " +
                    "VALUES ( @SNum, @SAmount, @SStatus, @PForm, @PaidBy)", conn);

                cmd.Parameters.Add("@SNum", SqlDbType.NVarChar).Value = txtSNum.Text;
                cmd.Parameters.Add("@SAmount", SqlDbType.NVarChar).Value = txtSAmount.Text;
                cmd.Parameters.Add("@SStatus", SqlDbType.VarChar).Value = cmboxSStat.Text.ToString();
                cmd.Parameters.Add("@PForm", SqlDbType.VarChar).Value = cmboxPayForm.Text.ToString();
                cmd.Parameters.Add("@PaidBy", SqlDbType.Date).Value = dateTimePicker2.Value;


                a.InsertCommand = cmd;
                a.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Person information added successfully!");
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            try
            {
                string constr;
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\AAMILAH\ONEDRIVE\DOCUMENTS\SCHOOLDATA.MDF;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("UPDATE FSTeacher " +
                    "SET SAmount=@SAmount, SStatus=@SStatus,PForm=@PForm,PaidBy=@PaidBy " +
                    "WHERE SNum=@SNum", con);
                

                 cmd.Parameters.Add("@SNum", SqlDbType.NVarChar).Value = txtSNum.Text;
                 cmd.Parameters.Add("@SAmount", SqlDbType.NVarChar).Value = txtSAmount.Text;
                 cmd.Parameters.Add("@SStatus", SqlDbType.VarChar).Value = cmboxSStat.Text.ToString();
                 cmd.Parameters.Add("@PForm", SqlDbType.VarChar).Value = cmboxPayForm.Text.ToString();
                 cmd.Parameters.Add("@PaidBy",SqlDbType.Date).Value = dateTimePicker2.Value;

                a.UpdateCommand = cmd;
                a.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                con.Close();
                display();
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
                string command = string.Format("DELETE FSTeacher WHERE SNum LIKE '" + txtSNum.Text + "%'", con);
                SqlDataAdapter a = new SqlDataAdapter();
                con.Open();
                cmd = new SqlCommand(command, con);
                a.DeleteCommand = new SqlCommand(command, con);
                a.DeleteCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchT_Click(object sender, EventArgs e)
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

        private void SearchS_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamilah\OneDrive\Documents\SchoolData.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapt;
                DataTable dt;
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM FSSudent WHERE RegNum like '" + txtRegNum.Text + "%'", con);
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
            txtSNum.Text = string.Empty;
            txtSAmount.Text = string.Empty;
            cmboxSStat.Text = " ";
            cmboxPayForm.Text = " ";
        }

        private void DisplayT_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
