namespace Lv14_Controls_Part1
{
    partial class frmDateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateString = new System.Windows.Forms.Label();
            this.btnShortDate = new System.Windows.Forms.Button();
            this.btnLongDate = new System.Windows.Forms.Button();
            this.btnLocalTime = new System.Windows.Forms.Button();
            this.btnTestDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 67);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 12, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDateString
            // 
            this.lblDateString.AutoSize = true;
            this.lblDateString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateString.Location = new System.Drawing.Point(508, 90);
            this.lblDateString.Name = "lblDateString";
            this.lblDateString.Size = new System.Drawing.Size(109, 25);
            this.lblDateString.TabIndex = 1;
            this.lblDateString.Text = "Date String";
            // 
            // btnShortDate
            // 
            this.btnShortDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShortDate.Location = new System.Drawing.Point(42, 237);
            this.btnShortDate.Name = "btnShortDate";
            this.btnShortDate.Size = new System.Drawing.Size(189, 49);
            this.btnShortDate.TabIndex = 2;
            this.btnShortDate.Text = "Short DateString";
            this.btnShortDate.UseVisualStyleBackColor = true;
            this.btnShortDate.Click += new System.EventHandler(this.btnShortDate_Click);
            // 
            // btnLongDate
            // 
            this.btnLongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLongDate.Location = new System.Drawing.Point(265, 237);
            this.btnLongDate.Name = "btnLongDate";
            this.btnLongDate.Size = new System.Drawing.Size(191, 49);
            this.btnLongDate.TabIndex = 3;
            this.btnLongDate.Text = "Long DateString";
            this.btnLongDate.UseVisualStyleBackColor = true;
            this.btnLongDate.Click += new System.EventHandler(this.btnLongDate_Click);
            // 
            // btnLocalTime
            // 
            this.btnLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLocalTime.Location = new System.Drawing.Point(471, 237);
            this.btnLocalTime.Name = "btnLocalTime";
            this.btnLocalTime.Size = new System.Drawing.Size(191, 49);
            this.btnLocalTime.TabIndex = 4;
            this.btnLocalTime.Text = "Local Time";
            this.btnLocalTime.UseVisualStyleBackColor = true;
            this.btnLocalTime.Click += new System.EventHandler(this.btnLocalTime_Click);
            // 
            // btnTestDate
            // 
            this.btnTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestDate.Location = new System.Drawing.Point(668, 237);
            this.btnTestDate.Name = "btnTestDate";
            this.btnTestDate.Size = new System.Drawing.Size(191, 49);
            this.btnTestDate.TabIndex = 5;
            this.btnTestDate.Text = "Test date Time";
            this.btnTestDate.UseVisualStyleBackColor = true;
            this.btnTestDate.Click += new System.EventHandler(this.btnTestDate_Click);
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 438);
            this.Controls.Add(this.btnTestDate);
            this.Controls.Add(this.btnLocalTime);
            this.Controls.Add(this.btnLongDate);
            this.Controls.Add(this.btnShortDate);
            this.Controls.Add(this.lblDateString);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmDateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateString;
        private System.Windows.Forms.Button btnShortDate;
        private System.Windows.Forms.Button btnLongDate;
        private System.Windows.Forms.Button btnLocalTime;
        private System.Windows.Forms.Button btnTestDate;
    }
}