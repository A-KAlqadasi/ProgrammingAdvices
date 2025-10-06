namespace MathGame
{
    partial class frmPrepareGame
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbGameLevel = new System.Windows.Forms.ComboBox();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 14.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 14.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Questions";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Lucida Calligraphy", 14.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(48, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 41);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Lucida Calligraphy", 14.8F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(179, 378);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbGameLevel
            // 
            this.cbGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cbGameLevel.FormattingEnabled = true;
            this.cbGameLevel.Items.AddRange(new object[] {
            "",
            "Easy",
            "Medium",
            "Hard",
            "Mix"});
            this.cbGameLevel.Location = new System.Drawing.Point(59, 158);
            this.cbGameLevel.Name = "cbGameLevel";
            this.cbGameLevel.Size = new System.Drawing.Size(199, 33);
            this.cbGameLevel.TabIndex = 0;
            // 
            // cbOperations
            // 
            this.cbOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/",
            "Mix"});
            this.cbOperations.Location = new System.Drawing.Point(59, 245);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(199, 33);
            this.cbOperations.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(109, 330);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 30);
            this.numericUpDown1.TabIndex = 7;
            // 
            // frmPrepareGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.cbGameLevel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrepareGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbGameLevel;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

