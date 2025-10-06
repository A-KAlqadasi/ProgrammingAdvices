namespace Lv14_Controls_Part1
{
    partial class frmListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFilRandom = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ILSmallSize = new System.Windows.Forms.ImageList(this.components);
            this.ILlargeSize = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbSmallicon = new System.Windows.Forms.RadioButton();
            this.rbDetailicon = new System.Windows.Forms.RadioButton();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblID.Location = new System.Drawing.Point(85, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(51, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(128, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(326, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(462, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 41);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFilRandom
            // 
            this.btnFilRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilRandom.Location = new System.Drawing.Point(598, 82);
            this.btnFilRandom.Name = "btnFilRandom";
            this.btnFilRandom.Size = new System.Drawing.Size(130, 41);
            this.btnFilRandom.TabIndex = 6;
            this.btnFilRandom.Text = "Fil Random";
            this.btnFilRandom.UseVisualStyleBackColor = true;
            this.btnFilRandom.Click += new System.EventHandler(this.btnFilRandom_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMale.Location = new System.Drawing.Point(97, 142);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 29);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbFemale.Location = new System.Drawing.Point(206, 142);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 29);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ILlargeSize;
            this.listView1.Location = new System.Drawing.Point(49, 232);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1005, 275);
            this.listView1.SmallImageList = this.ILSmallSize;
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ILSmallSize
            // 
            this.ILSmallSize.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILSmallSize.ImageStream")));
            this.ILSmallSize.TransparentColor = System.Drawing.Color.Transparent;
            this.ILSmallSize.Images.SetKeyName(0, "female.jpg");
            this.ILSmallSize.Images.SetKeyName(1, "Male.png");
            // 
            // ILlargeSize
            // 
            this.ILlargeSize.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILlargeSize.ImageStream")));
            this.ILlargeSize.TransparentColor = System.Drawing.Color.Transparent;
            this.ILlargeSize.Images.SetKeyName(0, "female.jpg");
            this.ILlargeSize.Images.SetKeyName(1, "Male.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbList);
            this.groupBox1.Controls.Add(this.rbLargeIcon);
            this.groupBox1.Controls.Add(this.rbTile);
            this.groupBox1.Controls.Add(this.rbSmallicon);
            this.groupBox1.Controls.Add(this.rbDetailicon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(774, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 137);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(136, 59);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(63, 29);
            this.rbList.TabIndex = 16;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(136, 24);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(125, 29);
            this.rbLargeIcon.TabIndex = 15;
            this.rbLargeIcon.Text = "Large Icon";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.rbLargeIcon_CheckedChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(6, 95);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(65, 29);
            this.rbTile.TabIndex = 14;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.rbTile_CheckedChanged);
            // 
            // rbSmallicon
            // 
            this.rbSmallicon.AutoSize = true;
            this.rbSmallicon.Location = new System.Drawing.Point(6, 59);
            this.rbSmallicon.Name = "rbSmallicon";
            this.rbSmallicon.Size = new System.Drawing.Size(124, 29);
            this.rbSmallicon.TabIndex = 13;
            this.rbSmallicon.Text = "Small Icon";
            this.rbSmallicon.UseVisualStyleBackColor = true;
            this.rbSmallicon.CheckedChanged += new System.EventHandler(this.rbSmallicon_CheckedChanged);
            // 
            // rbDetailicon
            // 
            this.rbDetailicon.AutoSize = true;
            this.rbDetailicon.Location = new System.Drawing.Point(9, 24);
            this.rbDetailicon.Name = "rbDetailicon";
            this.rbDetailicon.Size = new System.Drawing.Size(92, 29);
            this.rbDetailicon.TabIndex = 12;
            this.rbDetailicon.Text = "Details";
            this.rbDetailicon.UseVisualStyleBackColor = true;
            this.rbDetailicon.CheckedChanged += new System.EventHandler(this.rbDetailicon_CheckedChanged);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(462, 136);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(139, 59);
            this.btnRemoveSelected.TabIndex = 17;
            this.btnRemoveSelected.Text = "Remove All Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // frmListView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 582);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnFilRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFilRandom;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ILSmallSize;
        private System.Windows.Forms.ImageList ILlargeSize;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbSmallicon;
        private System.Windows.Forms.RadioButton rbDetailicon;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}