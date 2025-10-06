namespace Lv14_Controls_Part1
{
    partial class frmCheckBoxList
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Location = new System.Drawing.Point(222, 39);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(368, 174);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(54, 272);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 53);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add items";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Check All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(638, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Uncheck All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "Delete First";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Checked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCheckBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "frmCheckBoxList";
            this.Text = "frmCheckBoxList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}