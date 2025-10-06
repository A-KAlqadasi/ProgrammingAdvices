namespace Lv14_Controls_Part1
{
    partial class frmImageBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWeak = new System.Windows.Forms.Button();
            this.btnStrong = new System.Windows.Forms.Button();
            this.btnQuestionImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lv14_Controls_Part1.Properties.Resources.strong;
            this.pictureBox1.Location = new System.Drawing.Point(156, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnWeak
            // 
            this.btnWeak.Location = new System.Drawing.Point(151, 375);
            this.btnWeak.Name = "btnWeak";
            this.btnWeak.Size = new System.Drawing.Size(167, 65);
            this.btnWeak.TabIndex = 1;
            this.btnWeak.Text = "Weak";
            this.btnWeak.UseVisualStyleBackColor = true;
            this.btnWeak.Click += new System.EventHandler(this.btnWeak_Click);
            // 
            // btnStrong
            // 
            this.btnStrong.Location = new System.Drawing.Point(362, 375);
            this.btnStrong.Name = "btnStrong";
            this.btnStrong.Size = new System.Drawing.Size(167, 65);
            this.btnStrong.TabIndex = 2;
            this.btnStrong.Text = "Strong";
            this.btnStrong.UseVisualStyleBackColor = true;
            this.btnStrong.Click += new System.EventHandler(this.btnStrong_Click);
            // 
            // btnQuestionImage
            // 
            this.btnQuestionImage.Location = new System.Drawing.Point(558, 375);
            this.btnQuestionImage.Name = "btnQuestionImage";
            this.btnQuestionImage.Size = new System.Drawing.Size(167, 65);
            this.btnQuestionImage.TabIndex = 3;
            this.btnQuestionImage.Text = "Image From File";
            this.btnQuestionImage.UseVisualStyleBackColor = true;
            this.btnQuestionImage.Click += new System.EventHandler(this.btnQuestionImage_Click);
            // 
            // frmImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.btnQuestionImage);
            this.Controls.Add(this.btnStrong);
            this.Controls.Add(this.btnWeak);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmImageBox";
            this.Text = "frmPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWeak;
        private System.Windows.Forms.Button btnStrong;
        private System.Windows.Forms.Button btnQuestionImage;
    }
}