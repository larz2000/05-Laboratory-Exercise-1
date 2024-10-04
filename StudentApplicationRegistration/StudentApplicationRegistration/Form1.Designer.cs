namespace StudentApplicationRegistration
{
    partial class Form1
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
            this.LastNameTXT = new System.Windows.Forms.TextBox();
            this.FirstnameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiddlenameTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaleRDB = new System.Windows.Forms.RadioButton();
            this.FemaleRDB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.DayTXT = new System.Windows.Forms.ComboBox();
            this.MonthTXT = new System.Windows.Forms.ComboBox();
            this.YearTXT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProgramTXT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT REGISTRATION FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name*";
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTXT.Location = new System.Drawing.Point(12, 72);
            this.LastNameTXT.Multiline = true;
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(285, 24);
            this.LastNameTXT.TabIndex = 3;
            // 
            // FirstnameTXT
            // 
            this.FirstnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameTXT.Location = new System.Drawing.Point(12, 123);
            this.FirstnameTXT.Multiline = true;
            this.FirstnameTXT.Name = "FirstnameTXT";
            this.FirstnameTXT.Size = new System.Drawing.Size(285, 24);
            this.FirstnameTXT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name*";
            // 
            // MiddlenameTXT
            // 
            this.MiddlenameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddlenameTXT.ForeColor = System.Drawing.Color.Black;
            this.MiddlenameTXT.Location = new System.Drawing.Point(12, 174);
            this.MiddlenameTXT.Multiline = true;
            this.MiddlenameTXT.Name = "MiddlenameTXT";
            this.MiddlenameTXT.Size = new System.Drawing.Size(285, 24);
            this.MiddlenameTXT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender*";
            // 
            // MaleRDB
            // 
            this.MaleRDB.AutoSize = true;
            this.MaleRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRDB.Location = new System.Drawing.Point(94, 200);
            this.MaleRDB.Name = "MaleRDB";
            this.MaleRDB.Size = new System.Drawing.Size(61, 24);
            this.MaleRDB.TabIndex = 8;
            this.MaleRDB.TabStop = true;
            this.MaleRDB.Text = "Male";
            this.MaleRDB.UseVisualStyleBackColor = true;
            this.MaleRDB.CheckedChanged += new System.EventHandler(this.MaleRDB_CheckedChanged);
            // 
            // FemaleRDB
            // 
            this.FemaleRDB.AutoSize = true;
            this.FemaleRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRDB.Location = new System.Drawing.Point(170, 200);
            this.FemaleRDB.Name = "FemaleRDB";
            this.FemaleRDB.Size = new System.Drawing.Size(80, 24);
            this.FemaleRDB.TabIndex = 9;
            this.FemaleRDB.TabStop = true;
            this.FemaleRDB.Text = "Female";
            this.FemaleRDB.UseVisualStyleBackColor = true;
            this.FemaleRDB.CheckedChanged += new System.EventHandler(this.FemaleRDB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth*";
            // 
            // DayTXT
            // 
            this.DayTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTXT.FormattingEnabled = true;
            this.DayTXT.Location = new System.Drawing.Point(12, 250);
            this.DayTXT.Name = "DayTXT";
            this.DayTXT.Size = new System.Drawing.Size(72, 24);
            this.DayTXT.TabIndex = 12;
            // 
            // MonthTXT
            // 
            this.MonthTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthTXT.FormattingEnabled = true;
            this.MonthTXT.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthTXT.Location = new System.Drawing.Point(97, 250);
            this.MonthTXT.Name = "MonthTXT";
            this.MonthTXT.Size = new System.Drawing.Size(100, 24);
            this.MonthTXT.TabIndex = 13;
            this.MonthTXT.SelectedIndexChanged += new System.EventHandler(this.MonthTXT_SelectedIndexChanged);
            // 
            // YearTXT
            // 
            this.YearTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTXT.FormattingEnabled = true;
            this.YearTXT.Location = new System.Drawing.Point(209, 250);
            this.YearTXT.Name = "YearTXT";
            this.YearTXT.Size = new System.Drawing.Size(88, 24);
            this.YearTXT.TabIndex = 14;
            this.YearTXT.SelectedIndexChanged += new System.EventHandler(this.YearTXT_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Program to apply*";
            // 
            // ProgramTXT
            // 
            this.ProgramTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTXT.FormattingEnabled = true;
            this.ProgramTXT.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Multimedia Arts",
            "Bachelor of Science in Accountancy",
            "Bachelor of Information Technology"});
            this.ProgramTXT.Location = new System.Drawing.Point(12, 314);
            this.ProgramTXT.Name = "ProgramTXT";
            this.ProgramTXT.Size = new System.Drawing.Size(285, 24);
            this.ProgramTXT.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(318, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 402);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgramTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.YearTXT);
            this.Controls.Add(this.MonthTXT);
            this.Controls.Add(this.DayTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FemaleRDB);
            this.Controls.Add(this.MaleRDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MiddlenameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstnameTXT);
            this.Controls.Add(this.LastNameTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTXT;
        private System.Windows.Forms.TextBox FirstnameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MiddlenameTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MaleRDB;
        private System.Windows.Forms.RadioButton FemaleRDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DayTXT;
        private System.Windows.Forms.ComboBox MonthTXT;
        private System.Windows.Forms.ComboBox YearTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProgramTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

