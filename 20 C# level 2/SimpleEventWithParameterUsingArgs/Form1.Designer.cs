namespace SimpleEventWithParameterUsingArgs
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
            this.ctrlSimpleCalculator1 = new SimpleEventWithParameterUsingArgs.ctrlSimpleCalculator();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalculator1
            // 
            this.ctrlSimpleCalculator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ctrlSimpleCalculator1.Location = new System.Drawing.Point(21, 37);
            this.ctrlSimpleCalculator1.Name = "ctrlSimpleCalculator1";
            this.ctrlSimpleCalculator1.Size = new System.Drawing.Size(554, 167);
            this.ctrlSimpleCalculator1.TabIndex = 0;
            this.ctrlSimpleCalculator1.OnCalculationComplete += new System.EventHandler<SimpleEventWithParameterUsingArgs.ctrlSimpleCalculator.CalculationCompleteEventArgs>(this.ctrlSimpleCalculator1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlSimpleCalculator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSimpleCalculator ctrlSimpleCalculator1;
    }
}

