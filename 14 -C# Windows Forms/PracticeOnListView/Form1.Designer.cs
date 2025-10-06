namespace PracticeOnListView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhCountryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhID,
            this.colhFirstName,
            this.colhLastName,
            this.colhBirthDate,
            this.colhAddress,
            this.colhCountryID,
            this.colhSalary,
            this.colhEmail,
            this.colhPhone});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1383, 418);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colhID
            // 
            this.colhID.Text = "ID";
            this.colhID.Width = 78;
            // 
            // colhFirstName
            // 
            this.colhFirstName.Text = "FirstName";
            this.colhFirstName.Width = 131;
            // 
            // colhLastName
            // 
            this.colhLastName.Text = "LastName";
            this.colhLastName.Width = 138;
            // 
            // colhBirthDate
            // 
            this.colhBirthDate.Text = "BirthDate";
            this.colhBirthDate.Width = 169;
            // 
            // colhAddress
            // 
            this.colhAddress.DisplayIndex = 4;
            this.colhAddress.Text = "Address";
            this.colhAddress.Width = 188;
            // 
            // colhCountryID
            // 
            this.colhCountryID.DisplayIndex = 5;
            this.colhCountryID.Text = "CountryID";
            this.colhCountryID.Width = 73;
            // 
            // colhSalary
            // 
            this.colhSalary.Text = "Salary";
            this.colhSalary.Width = 142;
            // 
            // colhEmail
            // 
            this.colhEmail.DisplayIndex = 7;
            this.colhEmail.Text = "Email";
            // 
            // colhPhone
            // 
            this.colhPhone.DisplayIndex = 8;
            this.colhPhone.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Contacts From Data Base";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "frmPracticeOnListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colhID;
        private System.Windows.Forms.ColumnHeader colhFirstName;
        private System.Windows.Forms.ColumnHeader colhLastName;
        private System.Windows.Forms.ColumnHeader colhBirthDate;
        private System.Windows.Forms.ColumnHeader colhAddress;
        private System.Windows.Forms.ColumnHeader colhCountryID;
        private System.Windows.Forms.ColumnHeader colhPhone;
        private System.Windows.Forms.ColumnHeader colhEmail;
        private System.Windows.Forms.ColumnHeader colhSalary;
        private System.Windows.Forms.Label label1;
    }
}

