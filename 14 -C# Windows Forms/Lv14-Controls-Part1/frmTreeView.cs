using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lv14_Controls_Part1
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
            PrintCheckedNodes(e.Node,e.Node.Checked);
        }

        private void PrintCheckedNodes(TreeNode node,Boolean isChecked)
        {
            

            foreach(TreeNode childeNode in node.Nodes)
            {
                 
                if(childeNode.Checked)
                    txtTreeView.Text += childeNode.Text + Environment.NewLine;

                if (childeNode.Nodes.Count > 0)
                {
                    this.PrintCheckedNodes(childeNode, childeNode.Checked);
                }
            }
        }

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = isChecked;
                if(childNode.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(childNode, isChecked);
                }
            }
        }

        private void btnAddRootNode_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Books");

        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add("1", "Books", "Book.png", "Book.png");
        }
        private void DeleteCheckedNode()
        {
            foreach (TreeNode childeNode in treeView1.Nodes)
            {
                if (childeNode.Checked)
                    treeView1.Nodes.Remove(childeNode);

                if (childeNode.Nodes.Count > 0)
                {
                    
                }
                
            }
        }
        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            DeleteCheckedNode();
        }

        private void txtTreeView_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopySelected_Click(object sender, EventArgs e)
        {
            

        }
    }
}
