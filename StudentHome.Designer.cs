
namespace School_Management_System
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
            this.Registration = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Button();
            this.Fee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.RegNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Registration.Location = new System.Drawing.Point(0, 200);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(180, 44);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Results.Location = new System.Drawing.Point(0, 72);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(180, 44);
            this.Results.TabIndex = 1;
            this.Results.Text = "Academic Results";
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // Fee
            // 
            this.Fee.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Fee.Location = new System.Drawing.Point(0, 132);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(180, 44);
            this.Fee.TabIndex = 2;
            this.Fee.Text = "Finacial Statement";
            this.Fee.UseVisualStyleBackColor = false;
            this.Fee.Click += new System.EventHandler(this.Fee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Fee);
            this.panel1.Controls.Add(this.Registration);
            this.panel1.Controls.Add(this.Results);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(0, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Subjects";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 57);
            this.panel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Portal";
            // 
            // txtRegNum
            // 
            this.txtRegNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRegNum.Location = new System.Drawing.Point(143, 19);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(208, 23);
            this.txtRegNum.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSubCode);
            this.panel2.Controls.Add(this.RegNum);
            this.panel2.Controls.Add(this.txtRegNum);
            this.panel2.Location = new System.Drawing.Point(179, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 57);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject Code";
            // 
            // txtSubCode
            // 
            this.txtSubCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubCode.Location = new System.Drawing.Point(484, 17);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(208, 23);
            this.txtSubCode.TabIndex = 9;
            // 
            // RegNum
            // 
            this.RegNum.AutoSize = true;
            this.RegNum.Location = new System.Drawing.Point(20, 22);
            this.RegNum.Name = "RegNum";
            this.RegNum.Size = new System.Drawing.Size(117, 15);
            this.RegNum.TabIndex = 5;
            this.RegNum.Text = "Registration Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(705, 183);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Display Screen";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOut.Location = new System.Drawing.Point(830, 404);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(87, 35);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(916, 440);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHome";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Button Fee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RegNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubCode;
    }
}