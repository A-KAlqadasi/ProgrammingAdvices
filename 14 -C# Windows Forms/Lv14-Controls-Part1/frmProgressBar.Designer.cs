namespace Lv14_Controls_Part1
{
    partial class frmProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnIncreaseProgress = new System.Windows.Forms.Button();
            this.btnResetProgress = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(191, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 45);
            this.progressBar1.TabIndex = 0;
            // 
            // btnIncreaseProgress
            // 
            this.btnIncreaseProgress.Location = new System.Drawing.Point(143, 243);
            this.btnIncreaseProgress.Name = "btnIncreaseProgress";
            this.btnIncreaseProgress.Size = new System.Drawing.Size(172, 39);
            this.btnIncreaseProgress.TabIndex = 1;
            this.btnIncreaseProgress.Text = "Increase Progress Bar";
            this.btnIncreaseProgress.UseVisualStyleBackColor = true;
            this.btnIncreaseProgress.Click += new System.EventHandler(this.btnIncreaseProgress_Click);
            // 
            // btnResetProgress
            // 
            this.btnResetProgress.Location = new System.Drawing.Point(377, 243);
            this.btnResetProgress.Name = "btnResetProgress";
            this.btnResetProgress.Size = new System.Drawing.Size(172, 39);
            this.btnResetProgress.TabIndex = 2;
            this.btnResetProgress.Text = "Reset Progress Bar";
            this.btnResetProgress.UseVisualStyleBackColor = true;
            this.btnResetProgress.Click += new System.EventHandler(this.btnResetProgress_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPercent.Location = new System.Drawing.Point(337, 60);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(48, 29);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "0%";
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnResetProgress);
            this.Controls.Add(this.btnIncreaseProgress);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmProgressBar";
            this.Text = "frmProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnIncreaseProgress;
        private System.Windows.Forms.Button btnResetProgress;
        private System.Windows.Forms.Label lblPercent;
    }
}