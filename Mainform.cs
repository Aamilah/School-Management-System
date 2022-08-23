using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fees Mform = new Fees();
            Mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher Teach = new Teacher();
            Teach.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students Mform = new Students();
            Mform.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           UserList logout = new UserList();
            logout.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exam Mform = new Exam();
            Mform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Subject Mform = new Subject();
            Mform.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gaurdian Mform = new Gaurdian();
            Mform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAccount aa = new AddAccount();
            aa.Show();
            this.Hide();
        }
    }
}
