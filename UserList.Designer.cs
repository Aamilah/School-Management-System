
namespace School_Management_System
{
    partial class UserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.admin = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.ForeColor = System.Drawing.Color.Black;
            this.admin.Location = new System.Drawing.Point(77, 212);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(101, 38);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student.ForeColor = System.Drawing.Color.Black;
            this.Student.Location = new System.Drawing.Point(77, 277);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(101, 38);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Teacher
            // 
            this.Teacher.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher.ForeColor = System.Drawing.Color.Black;
            this.Teacher.Location = new System.Drawing.Point(77, 342);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(101, 38);
            this.Teacher.TabIndex = 2;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = false;
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Teacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}