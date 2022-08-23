using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogressbar.Value = startpos;
            if(Myprogressbar.Value == 100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();

                UserList UList = new UserList();
                UList.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogressbar_Click(object sender, EventArgs e)
        {

        }
    }
}
