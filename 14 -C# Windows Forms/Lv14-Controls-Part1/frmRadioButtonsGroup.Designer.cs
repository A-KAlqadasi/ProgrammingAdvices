namespace Lv14_Controls_Part1
{
    partial class frmRadioButtonsGroup
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
            this.chkReciveEmails = new System.Windows.Forms.CheckBox();
            this.btnCheckBoxState = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbTheck = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReciveEmails
            // 
            this.chkReciveEmails.AutoSize = true;
            this.chkReciveEmails.Location = new System.Drawing.Point(188, 72);
            this.chkReciveEmails.Name = "chkReciveEmails";
            this.chkReciveEmails.Size = new System.Drawing.Size(199, 20);
            this.chkReciveEmails.TabIndex = 0;
            this.chkReciveEmails.Text = "Do you want to recive emails";
            this.chkReciveEmails.UseVisualStyleBackColor = true;
            this.chkReciveEmails.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCheckBoxState
            // 
            this.btnCheckBoxState.Enabled = false;
            this.btnCheckBoxState.Location = new System.Drawing.Point(165, 143);
            this.btnCheckBoxState.Name = "btnCheckBoxState";
            this.btnCheckBoxState.Size = new System.Drawing.Size(137, 46);
            this.btnCheckBoxState.TabIndex = 1;
            this.btnCheckBoxState.Text = "CheckBox State";
            this.btnCheckBoxState.UseVisualStyleBackColor = true;
            this.btnCheckBoxState.Click += new System.EventHandler(this.btnCheckBoxState_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Radio button state";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(408, 87);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(172, 170);
            this.gbSize.TabIndex = 6;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(29, 111);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(30, 66);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(30, 21);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbTheck);
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.Location = new System.Drawing.Point(586, 87);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(172, 112);
            this.gbCrust.TabIndex = 7;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbTheck
            // 
            this.rbTheck.AutoSize = true;
            this.rbTheck.Location = new System.Drawing.Point(30, 66);
            this.rbTheck.Name = "rbTheck";
            this.rbTheck.Size = new System.Drawing.Size(66, 20);
            this.rbTheck.TabIndex = 6;
            this.rbTheck.TabStop = true;
            this.rbTheck.Text = "Theck";
            this.rbTheck.UseVisualStyleBackColor = true;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(30, 21);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(54, 20);
            this.rbThinCrust.TabIndex = 5;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // frmRadioButtonsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckBoxState);
            this.Controls.Add(this.chkReciveEmails);
            this.Name = "frmRadioButtonsGroup";
            this.Text = "RadioButtonsGroup";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReciveEmails;
        private System.Windows.Forms.Button btnCheckBoxState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbTheck;
        private System.Windows.Forms.RadioButton rbThinCrust;
    }
}