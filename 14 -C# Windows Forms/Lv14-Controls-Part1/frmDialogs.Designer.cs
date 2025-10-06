namespace Lv14_Controls_Part1
{
    partial class frmDialogs
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tpColorDialog = new System.Windows.Forms.TabPage();
            this.btnFolderBrowsingDialog = new System.Windows.Forms.Button();
            this.btnOpenFileDialogMulti = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tpColorDialog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpColorDialog
            // 
            this.tpColorDialog.Controls.Add(this.btnFolderBrowsingDialog);
            this.tpColorDialog.Controls.Add(this.btnOpenFileDialogMulti);
            this.tpColorDialog.Controls.Add(this.btnOpenFileDialog);
            this.tpColorDialog.Controls.Add(this.btnSaveFileDialog);
            this.tpColorDialog.Controls.Add(this.btnChangeFont);
            this.tpColorDialog.Controls.Add(this.btnFontColor);
            this.tpColorDialog.Controls.Add(this.btnBackColor);
            this.tpColorDialog.Controls.Add(this.textBox1);
            this.tpColorDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpColorDialog.Location = new System.Drawing.Point(4, 25);
            this.tpColorDialog.Name = "tpColorDialog";
            this.tpColorDialog.Padding = new System.Windows.Forms.Padding(3);
            this.tpColorDialog.Size = new System.Drawing.Size(782, 351);
            this.tpColorDialog.TabIndex = 1;
            this.tpColorDialog.Text = "Color Dialog";
            this.tpColorDialog.UseVisualStyleBackColor = true;
            // 
            // btnFolderBrowsingDialog
            // 
            this.btnFolderBrowsingDialog.Location = new System.Drawing.Point(294, 188);
            this.btnFolderBrowsingDialog.Name = "btnFolderBrowsingDialog";
            this.btnFolderBrowsingDialog.Size = new System.Drawing.Size(228, 40);
            this.btnFolderBrowsingDialog.TabIndex = 7;
            this.btnFolderBrowsingDialog.Text = "Folder Browsing Dialog";
            this.btnFolderBrowsingDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowsingDialog.Click += new System.EventHandler(this.btnFolderBrowsingDialog_Click);
            // 
            // btnOpenFileDialogMulti
            // 
            this.btnOpenFileDialogMulti.Location = new System.Drawing.Point(537, 251);
            this.btnOpenFileDialogMulti.Name = "btnOpenFileDialogMulti";
            this.btnOpenFileDialogMulti.Size = new System.Drawing.Size(228, 40);
            this.btnOpenFileDialogMulti.TabIndex = 6;
            this.btnOpenFileDialogMulti.Text = "Open File Dialog Multi";
            this.btnOpenFileDialogMulti.UseVisualStyleBackColor = true;
            this.btnOpenFileDialogMulti.Click += new System.EventHandler(this.btnOpenFileDialogMulti_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(294, 251);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(228, 40);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(39, 251);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(228, 40);
            this.btnSaveFileDialog.TabIndex = 4;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(39, 188);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(228, 40);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(290, 132);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(232, 40);
            this.btnFontColor.TabIndex = 2;
            this.btnFontColor.Text = "Change Font Color";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(39, 132);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(228, 40);
            this.btnBackColor.TabIndex = 1;
            this.btnBackColor.Text = "Change Back Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is a title";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpColorDialog);
            this.tabControl1.Location = new System.Drawing.Point(74, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDialogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogs";
            this.tpColorDialog.ResumeLayout(false);
            this.tpColorDialog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tpColorDialog;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialogMulti;
        private System.Windows.Forms.Button btnFolderBrowsingDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}