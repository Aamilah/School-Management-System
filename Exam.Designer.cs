
namespace School_Management_System
{
    partial class Exam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubCod = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.txtExamType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboxGrade = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exams Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mark";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSubCod
            // 
            this.txtSubCod.Location = new System.Drawing.Point(240, 209);
            this.txtSubCod.Name = "txtSubCod";
            this.txtSubCod.Size = new System.Drawing.Size(121, 23);
            this.txtSubCod.TabIndex = 4;
            this.txtSubCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(714, 125);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(121, 23);
            this.txtMark.TabIndex = 5;
            this.txtMark.TextChanged += new System.EventHandler(this.txtMark_TextChanged);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(240, 293);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(121, 23);
            this.txtSession.TabIndex = 6;
            this.txtSession.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.Location = new System.Drawing.Point(9, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(969, 240);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Create.Location = new System.Drawing.Point(895, 347);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(83, 23);
            this.Create.TabIndex = 8;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update.Location = new System.Drawing.Point(489, 85);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(408, 84);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.Location = new System.Drawing.Point(895, -3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 32);
            this.Home.TabIndex = 12;
            this.Home.Text = "Menu";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subject Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Session";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(240, 170);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(121, 23);
            this.txtSubName.TabIndex = 16;
            this.txtSubName.TextChanged += new System.EventHandler(this.txtSubName_TextChanged);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(240, 133);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 23);
            this.txtStuName.TabIndex = 17;
            this.txtStuName.TextChanged += new System.EventHandler(this.txtStuName_TextChanged);
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(100, 84);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(261, 23);
            this.txtRegNum.TabIndex = 18;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Location = new System.Drawing.Point(12, 347);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(89, 23);
            this.Display.TabIndex = 19;
            this.Display.Text = "Diaplay";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Location = new System.Drawing.Point(570, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtExamType
            // 
            this.txtExamType.Location = new System.Drawing.Point(240, 251);
            this.txtExamType.Name = "txtExamType";
            this.txtExamType.Size = new System.Drawing.Size(121, 23);
            this.txtExamType.TabIndex = 21;
            this.txtExamType.TextChanged += new System.EventHandler(this.txtExamType_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Exam Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(714, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 23);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(714, 209);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(121, 23);
            this.txtPercent.TabIndex = 25;
            this.txtPercent.TextChanged += new System.EventHandler(this.txtPercent_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Percentage";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmboxGrade
            // 
            this.cmboxGrade.FormattingEnabled = true;
            this.cmboxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "F"});
            this.cmboxGrade.Location = new System.Drawing.Point(714, 251);
            this.cmboxGrade.Name = "cmboxGrade";
            this.cmboxGrade.Size = new System.Drawing.Size(121, 23);
            this.cmboxGrade.TabIndex = 27;
            this.cmboxGrade.Text = "Pick Grade";
            this.cmboxGrade.SelectedIndexChanged += new System.EventHandler(this.cmboxGrade_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(574, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Grade";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Remark";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(714, 290);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(121, 61);
            this.txtRemark.TabIndex = 30;
            this.txtRemark.Text = "";
            this.txtRemark.TextChanged += new System.EventHandler(this.txtRemark_TextChanged);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.White;
            this.ClearAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearAll.Location = new System.Drawing.Point(895, 311);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(83, 23);
            this.ClearAll.TabIndex = 31;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 62);
            this.panel1.TabIndex = 32;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(990, 624);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmboxGrade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExamType);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtSubCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubCod;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtExamType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmboxGrade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Panel panel1;
    }
}