namespace myFirstUserControl
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
            this.ctrlSimpleCalculator1 = new myFirstUserControl.ctrlSimpleCalculator();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalculator1
            // 
            this.ctrlSimpleCalculator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalculator1.Location = new System.Drawing.Point(41, 67);
            this.ctrlSimpleCalculator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalculator1.Name = "ctrlSimpleCalculator1";
            this.ctrlSimpleCalculator1.Size = new System.Drawing.Size(210, 233);
            this.ctrlSimpleCalculator1.TabIndex = 0;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(417, 110);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(108, 38);
            this.btnShowResult.TabIndex = 1;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 481);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.ctrlSimpleCalculator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSimpleCalculator ctrlSimpleCalculator1;
        private System.Windows.Forms.Button btnShowResult;
    }
}

