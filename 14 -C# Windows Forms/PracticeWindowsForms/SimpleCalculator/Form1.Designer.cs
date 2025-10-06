namespace SimpleCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplayResults = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnModulus);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtDisplayResults);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 506);
            this.panel1.TabIndex = 0;
            // 
            // txtDisplayResults
            // 
            this.txtDisplayResults.BackColor = System.Drawing.Color.Snow;
            this.txtDisplayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayResults.Location = new System.Drawing.Point(7, 15);
            this.txtDisplayResults.Multiline = true;
            this.txtDisplayResults.Name = "txtDisplayResults";
            this.txtDisplayResults.Size = new System.Drawing.Size(351, 47);
            this.txtDisplayResults.TabIndex = 0;
            this.txtDisplayResults.Text = "0";
            this.txtDisplayResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplayResults.TextChanged += new System.EventHandler(this.txtDisplayResults_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Wingdings", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(16, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 76);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(101, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 76);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnModulus
            // 
            this.btnModulus.BackColor = System.Drawing.Color.White;
            this.btnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.ForeColor = System.Drawing.Color.Green;
            this.btnModulus.Location = new System.Drawing.Point(186, 86);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(77, 76);
            this.btnModulus.TabIndex = 1;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.White;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Green;
            this.btnDivide.Location = new System.Drawing.Point(271, 86);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(77, 76);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.White;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(16, 168);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(77, 76);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.White;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(186, 168);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(77, 76);
            this.btnNine.TabIndex = 1;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.White;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(101, 168);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(77, 76);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.White;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Green;
            this.btnMultiply.Location = new System.Drawing.Point(271, 168);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(77, 76);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.White;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(16, 250);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(77, 76);
            this.btnFour.TabIndex = 1;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.White;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(16, 332);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(77, 76);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.White;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(186, 250);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(77, 76);
            this.btnSix.TabIndex = 1;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.White;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(186, 332);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(77, 76);
            this.btnThree.TabIndex = 1;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.White;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(101, 250);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(77, 76);
            this.btnFive.TabIndex = 1;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.White;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(101, 332);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(77, 76);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Green;
            this.btnMinus.Location = new System.Drawing.Point(271, 250);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(77, 76);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Green;
            this.btnPlus.Location = new System.Drawing.Point(271, 332);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(77, 76);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(16, 414);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(162, 76);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(186, 414);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(77, 76);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(271, 414);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(77, 76);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 526);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDisplayResults;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
    }
}

