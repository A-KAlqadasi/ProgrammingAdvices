using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsWindowsForms
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefereshContactsList()
        {
            dgvListAllContacts.DataSource = clsContact.GetAllContacts();

        }


        private void frmListContacts_Load(object sender, EventArgs e)
        {
            _RefereshContactsList();
        }

       

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact((int)dgvListAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefereshContactsList();
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(-1);
            frm.ShowDialog();
            _RefereshContactsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllContacts.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete contact [" + id +"]","Confirm Deletion",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if(clsContact.DeleteContact(id))
                {
                    MessageBox.Show("Contact deleted successfully");
                    _RefereshContactsList();
                }
                else
                    MessageBox.Show("Contact deletion Failed");

            }
        }
    }
}
