namespace Lv14_Controls_Part1
{
    partial class frmMessageBox
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
            this.btnShowMessageBox = new System.Windows.Forms.Button();
            this.btnMessageWithTitle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMessageBox
            // 
            this.btnShowMessageBox.Location = new System.Drawing.Point(72, 89);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new System.Drawing.Size(190, 63);
            this.btnShowMessageBox.TabIndex = 0;
            this.btnShowMessageBox.Text = "Show Message";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.Click += new System.EventHandler(this.btnShowMessageBox_Click);
            // 
            // btnMessageWithTitle
            // 
            this.btnMessageWithTitle.Location = new System.Drawing.Point(72, 187);
            this.btnMessageWithTitle.Name = "btnMessageWithTitle";
            this.btnMessageWithTitle.Size = new System.Drawing.Size(190, 63);
            this.btnMessageWithTitle.TabIndex = 1;
            this.btnMessageWithTitle.Text = "Show Message with title";
            this.btnMessageWithTitle.UseVisualStyleBackColor = true;
            this.btnMessageWithTitle.Click += new System.EventHandler(this.btnMessageWithTitle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Message with title and buttons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Message with title and buttons and image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show Message with title and buttons and image and default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMessageWithTitle);
            this.Controls.Add(this.btnShowMessageBox);
            this.Name = "frmMessageBox";
            this.Text = "Message Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessageBox;
        private System.Windows.Forms.Button btnMessageWithTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}