using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lv14_Controls_Part1
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if(rbMale.Checked )
                item.ImageIndex = 1;
            else 
                item.ImageIndex = 0;

            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

        }

        private void frmListView_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count >0)
            {
                for(short i =0; i<listView1.SelectedItems.Count; i++)
                {
                    listView1.Items.Remove(listView1.SelectedItems[i]);
                }
            }
        }

        private void btnFilRandom_Click(object sender, EventArgs e)
        {
            for(short i =1;i<=10;i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                if(i % 2==0)
                    item.ImageIndex = 1;
                else 
                    item.ImageIndex = 0;

                item.SubItems.Add("Person" + i);
                listView1.Items.Add(item);

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void rbDetailicon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallicon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
