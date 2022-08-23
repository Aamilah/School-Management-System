
namespace School_Management_System
{
    partial class Subject
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
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtCStart = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Create = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCRoom = new System.Windows.Forms.TextBox();
            this.txtCEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTOffice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboxDay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Start";
            // 
            // txtSubCod
            // 
            this.txtSubCod.Location = new System.Drawing.Point(186, 68);
            this.txtSubCod.Name = "txtSubCod";
            this.txtSubCod.Size = new System.Drawing.Size(214, 23);
            this.txtSubCod.TabIndex = 4;
            this.txtSubCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(186, 104);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(136, 23);
            this.txtSubName.TabIndex = 5;
            // 
            // txtCStart
            // 
            this.txtCStart.Location = new System.Drawing.Point(581, 138);
            this.txtCStart.Name = "txtCStart";
            this.txtCStart.Size = new System.Drawing.Size(132, 23);
            this.txtCStart.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 234);
            this.dataGridView1.TabIndex = 7;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Create.Location = new System.Drawing.Point(617, 331);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 26);
            this.Create.TabIndex = 8;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Display.Location = new System.Drawing.Point(12, 331);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 26);
            this.Display.TabIndex = 9;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Update.Location = new System.Drawing.Point(626, 68);
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
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete.Location = new System.Drawing.Point(536, 68);
            this.Delete.Name = "Delete";
            this.Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu.Location = new System.Drawing.Point(695, -7);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(107, 37);
            this.Menu.TabIndex = 12;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 61);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Class Room Assigned";
            // 
            // txtCRoom
            // 
            this.txtCRoom.Location = new System.Drawing.Point(186, 138);
            this.txtCRoom.Name = "txtCRoom";
            this.txtCRoom.Size = new System.Drawing.Size(136, 23);
            this.txtCRoom.TabIndex = 15;
            // 
            // txtCEnd
            // 
            this.txtCEnd.Location = new System.Drawing.Point(581, 171);
            this.txtCEnd.Name = "txtCEnd";
            this.txtCEnd.Size = new System.Drawing.Size(132, 23);
            this.txtCEnd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Class End";
            // 
            // txtSNum
            // 
            this.txtSNum.Location = new System.Drawing.Point(156, 26);
            this.txtSNum.Name = "txtSNum";
            this.txtSNum.Size = new System.Drawing.Size(130, 23);
            this.txtSNum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Staff Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTOffice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSNum);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(30, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 114);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher Information";
            // 
            // txtTOffice
            // 
            this.txtTOffice.Location = new System.Drawing.Point(563, 26);
            this.txtTOffice.Name = "txtTOffice";
            this.txtTOffice.Size = new System.Drawing.Size(132, 23);
            this.txtTOffice.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Teacher Office";
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(156, 58);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(130, 23);
            this.txtTName.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Teacher Name";
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.White;
            this.ClearAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearAll.Location = new System.Drawing.Point(713, 331);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClearAll.Size = new System.Drawing.Size(75, 26);
            this.ClearAll.TabIndex = 21;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Search.Location = new System.Drawing.Point(448, 68);
            this.Search.Name = "Search";
            this.Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Day of the Week";
            // 
            // cmboxDay
            // 
            this.cmboxDay.FormattingEnabled = true;
            this.cmboxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmboxDay.Location = new System.Drawing.Point(580, 107);
            this.cmboxDay.Name = "cmboxDay";
            this.cmboxDay.Size = new System.Drawing.Size(133, 23);
            this.cmboxDay.TabIndex = 24;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.cmboxDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtSubCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubCod;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.TextBox txtCStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCRoom;
        private System.Windows.Forms.TextBox txtCEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtTOffice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboxDay;
    }
}