using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            TeacherLogin LTeach = new TeacherLogin();
            LTeach.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {

            LoginAdmin LAdmin = new LoginAdmin();
            LAdmin.Show();
            this.Hide();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            StudentLogin LStu = new StudentLogin();
            LStu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
