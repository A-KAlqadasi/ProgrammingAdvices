namespace Lv14_Controls_Part1
{
    partial class frmImagesExcercise
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
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoy.Location = new System.Drawing.Point(273, 368);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(67, 29);
            this.rbBoy.TabIndex = 1;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "Boy";
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGirl.Location = new System.Drawing.Point(369, 368);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(62, 29);
            this.rbGirl.TabIndex = 2;
            this.rbGirl.TabStop = true;
            this.rbGirl.Tag = "Girl";
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.Location = new System.Drawing.Point(461, 368);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(78, 29);
            this.rbBook.TabIndex = 3;
            this.rbBook.TabStop = true;
            this.rbBook.Tag = "Book";
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPen.Location = new System.Drawing.Point(565, 368);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(68, 29);
            this.rbPen.TabIndex = 4;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "Pen";
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Lv14_Controls_Part1.Properties.Resources.Girl;
            this.pictureBox1.Location = new System.Drawing.Point(264, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmImagesExcercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPen);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rbGirl);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmImagesExcercise";
            this.Text = "frmImagesExcercise";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.Label label1;
    }
}