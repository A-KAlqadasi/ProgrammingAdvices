namespace Lv14_Controls_Part1
{
    partial class frmTapPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbMajors = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tpCourses = new System.Windows.Forms.TabPage();
            this.btnCourses = new System.Windows.Forms.Button();
            this.tpSubjects = new System.Windows.Forms.TabPage();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.tpTeachers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpStudents.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            this.tpCourses.SuspendLayout();
            this.tpSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tpStudents);
            this.tabControl1.Controls.Add(this.tpCourses);
            this.tabControl1.Controls.Add(this.tpSubjects);
            this.tabControl1.Controls.Add(this.tpTeachers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(133, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStudents
            // 
            this.tpStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tpStudents.Controls.Add(this.gbStudentInfo);
            this.tpStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpStudents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpStudents.Location = new System.Drawing.Point(4, 4);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudents.Size = new System.Drawing.Size(824, 245);
            this.tpStudents.TabIndex = 0;
            this.tpStudents.Text = "Students";
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.BirthDate);
            this.gbStudentInfo.Controls.Add(this.cbMajors);
            this.gbStudentInfo.Controls.Add(this.textBox2);
            this.gbStudentInfo.Controls.Add(this.textBox1);
            this.gbStudentInfo.Controls.Add(this.lblBirthDate);
            this.gbStudentInfo.Controls.Add(this.lblMajor);
            this.gbStudentInfo.Controls.Add(this.lblLastName);
            this.gbStudentInfo.Controls.Add(this.lblFirstName);
            this.gbStudentInfo.Location = new System.Drawing.Point(11, 16);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(516, 218);
            this.gbStudentInfo.TabIndex = 8;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(142, 142);
            this.BirthDate.MaxDate = new System.DateTime(2028, 1, 1, 0, 0, 0, 0);
            this.BirthDate.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(356, 30);
            this.BirthDate.TabIndex = 1;
            // 
            // cbMajors
            // 
            this.cbMajors.FormattingEnabled = true;
            this.cbMajors.Items.AddRange(new object[] {
            "",
            "CS",
            "IT",
            "IS",
            "CYS"});
            this.cbMajors.Location = new System.Drawing.Point(142, 97);
            this.cbMajors.Name = "cbMajors";
            this.cbMajors.Size = new System.Drawing.Size(121, 33);
            this.cbMajors.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 58);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 23);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 30);
            this.textBox1.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(44, 147);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(98, 25);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "BirthDate:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(75, 105);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(67, 25);
            this.lblMajor.TabIndex = 2;
            this.lblMajor.Text = "Major:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(33, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // tpCourses
            // 
            this.tpCourses.BackColor = System.Drawing.Color.MistyRose;
            this.tpCourses.Controls.Add(this.btnCourses);
            this.tpCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tpCourses.Location = new System.Drawing.Point(4, 4);
            this.tpCourses.Name = "tpCourses";
            this.tpCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tpCourses.Size = new System.Drawing.Size(824, 245);
            this.tpCourses.TabIndex = 1;
            this.tpCourses.Text = "Courses";
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(166, 54);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(171, 38);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // tpSubjects
            // 
            this.tpSubjects.BackColor = System.Drawing.Color.Tomato;
            this.tpSubjects.Controls.Add(this.btnSubjects);
            this.tpSubjects.Location = new System.Drawing.Point(4, 4);
            this.tpSubjects.Name = "tpSubjects";
            this.tpSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubjects.Size = new System.Drawing.Size(824, 245);
            this.tpSubjects.TabIndex = 2;
            this.tpSubjects.Text = "Subjects";
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(144, 62);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(159, 45);
            this.btnSubjects.TabIndex = 0;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // tpTeachers
            // 
            this.tpTeachers.Location = new System.Drawing.Point(4, 4);
            this.tpTeachers.Name = "tpTeachers";
            this.tpTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeachers.Size = new System.Drawing.Size(824, 245);
            this.tpTeachers.TabIndex = 3;
            this.tpTeachers.Text = "Teachers";
            this.tpTeachers.UseVisualStyleBackColor = true;
            // 
            // frmTapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTapPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTapPage";
            this.tabControl1.ResumeLayout(false);
            this.tpStudents.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.tpCourses.ResumeLayout(false);
            this.tpSubjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.TabPage tpCourses;
        private System.Windows.Forms.TabPage tpSubjects;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.ComboBox cbMajors;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.TabPage tpTeachers;
    }
}