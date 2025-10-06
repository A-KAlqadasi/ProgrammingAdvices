namespace Lv14_Controls_Part1
{
    partial class frmTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Yasmin", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ahmed", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ali");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Girls", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Osama");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Fatma", 1, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node2");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAddRootNode = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTreeView = new System.Windows.Forms.TextBox();
            this.btnCopySelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            this.imageList1.Images.SetKeyName(2, "Book.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(63, 42);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Yasmin";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Ahmed";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Ali";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Girls";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Osama";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node5";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Fatma";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Boys";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node2";
            treeNode8.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(390, 353);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // btnAddRootNode
            // 
            this.btnAddRootNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddRootNode.Location = new System.Drawing.Point(476, 141);
            this.btnAddRootNode.Name = "btnAddRootNode";
            this.btnAddRootNode.Size = new System.Drawing.Size(184, 65);
            this.btnAddRootNode.TabIndex = 1;
            this.btnAddRootNode.Text = "Add Root Node";
            this.btnAddRootNode.UseVisualStyleBackColor = true;
            this.btnAddRootNode.Click += new System.EventHandler(this.btnAddRootNode_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddChild.Location = new System.Drawing.Point(476, 212);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(184, 65);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "Add Child Node";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(476, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Checked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // txtTreeView
            // 
            this.txtTreeView.Location = new System.Drawing.Point(721, 109);
            this.txtTreeView.Multiline = true;
            this.txtTreeView.Name = "txtTreeView";
            this.txtTreeView.Size = new System.Drawing.Size(269, 260);
            this.txtTreeView.TabIndex = 4;
            this.txtTreeView.TextChanged += new System.EventHandler(this.txtTreeView_TextChanged);
            // 
            // btnCopySelected
            // 
            this.btnCopySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCopySelected.Location = new System.Drawing.Point(476, 60);
            this.btnCopySelected.Name = "btnCopySelected";
            this.btnCopySelected.Size = new System.Drawing.Size(184, 65);
            this.btnCopySelected.TabIndex = 5;
            this.btnCopySelected.Text = ">>";
            this.btnCopySelected.UseVisualStyleBackColor = true;
            this.btnCopySelected.Click += new System.EventHandler(this.btnCopySelected_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.btnCopySelected);
            this.Controls.Add(this.txtTreeView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnAddRootNode);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAddRootNode;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTreeView;
        private System.Windows.Forms.Button btnCopySelected;
    }
}