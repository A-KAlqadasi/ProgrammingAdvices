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
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name Is Requred!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace (txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name is Required!");
            }
        }
    }
}
