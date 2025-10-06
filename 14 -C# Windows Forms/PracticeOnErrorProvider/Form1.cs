using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOnErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d+$"; // regular expression for only numbers

            if (string.IsNullOrEmpty(txtID.Text.ToString()) || !Regex.IsMatch(txtID.Text.ToString(),pattern))
            {
                e.Cancel = true;
                txtID.Focus();

                errorProvider1.SetError(txtID, "ID should have a valid numaric value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z]+$"; // only alphapets without space or hyphens
            string pattern2 = @"^[a-zA-Z\s'-]+$"; // alphapets with space or hyphen

            if(string.IsNullOrEmpty(txtName.Text.ToString().Trim()) || !Regex.IsMatch(txtName.Text.ToString(),pattern2))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Name should have a valid value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }


        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d+(\.\d{1,2})?$";
            if(string.IsNullOrEmpty(txtSalary.Text.ToString()) || !Regex.IsMatch(txtSalary.Text.ToString(),pattern))
            {
                e.Cancel = true;
                txtSalary.Focus();
                errorProvider1.SetError(txtSalary, "Salary should have a valid value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSalary, "");
            }

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d{9}$";
            if(!string.IsNullOrEmpty(txtPhone.Text.ToString()) && !Regex.IsMatch(txtPhone.Text.ToString(),pattern))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone should have a valid 9 digit number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }

        }
    }
}
