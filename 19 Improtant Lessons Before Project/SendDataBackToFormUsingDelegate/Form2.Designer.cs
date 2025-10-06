namespace SendDataBackToFormUsingDelegate
{
    partial class Form2
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnSendDataBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(139, 83);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(161, 30);
            this.txtPersonID.TabIndex = 3;
            // 
            // btnSendDataBack
            // 
            this.btnSendDataBack.Location = new System.Drawing.Point(330, 80);
            this.btnSendDataBack.Name = "btnSendDataBack";
            this.btnSendDataBack.Size = new System.Drawing.Size(154, 43);
            this.btnSendDataBack.TabIndex = 2;
            this.btnSendDataBack.Text = "Send Data Back";
            this.btnSendDataBack.UseVisualStyleBackColor = true;
            this.btnSendDataBack.Click += new System.EventHandler(this.btnSendDataBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Person ID";
            // 
            // Form2
            // 
            this.AcceptButton = this.btnSendDataBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.btnSendDataBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSendDataBack;
        private System.Windows.Forms.Label label1;
    }
}