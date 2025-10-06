using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ContactsBusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsWindowsForms
{
    public partial class frmAddEditContact : Form
    {

        public enum enMode { AddNew =1,Update =2 };
        private enMode _Mode;
        private int _ContactID;
        clsContact _Contact;

        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();
            
            _ContactID=ContactID;

            if (_ContactID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr["CountryName"]);
            }

        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;

            if(_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContact();
                return;
            }

            _Contact = clsContact.Find(_ContactID);

            if(_Contact == null)
            {
                MessageBox.Show("This form will be closed because No contact with ID=" + _ContactID);
                this.Close();
                return;
            }

            lblMode.Text = "Edit Contact ID= " + _ContactID;

            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtAddress.Text = _Contact.Address;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            dtpBirthDate.Value = _Contact.Birthdate;

            if(_Contact.ImagePath != "")
            {
                pbPersonImage.Load(_Contact.ImagePath);
            }

            llRemoveImage.Visible = (_Contact.ImagePath !="");

            //this will select the country in the combobox.

            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.FindCountry(_Contact.CountryID).CountryName);


        }


        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
            
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z]+$"; // only alphapets without space or hyphens


            if (string.IsNullOrEmpty(txtFirstName.ToString().Trim()) || !Regex.IsMatch(txtFirstName.Text.ToString(), pattern))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name should have a valid value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z]+$"; // only alphapets without space or hyphens


            if (string.IsNullOrEmpty(txtLastName.ToString().Trim()) || !Regex.IsMatch(txtLastName.Text.ToString(), pattern))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name should have a valid value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d{9}$";
            if (string.IsNullOrEmpty(txtPhone.Text.ToString()) || !Regex.IsMatch(txtPhone.Text.ToString(), pattern))
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            if (string.IsNullOrEmpty(txtEmail.Text.ToString()) || !Regex.IsMatch(txtEmail.Text.ToString(), pattern)) 
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email should be in valid format(example@gmail.com)!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddress.Text.ToString()))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Address is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog()  == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int countryId = clsCountry.FindCountry(cbCountries.Text).CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Birthdate = dtpBirthDate.Value;
            _Contact.CountryID = countryId;

            if (pbPersonImage.ImageLocation != null)
            {
                _Contact.ImagePath = pbPersonImage.ImageLocation.ToString();
            }

            if (_Contact.Save())
                MessageBox.Show("Data Saved Successfully");
            else
                MessageBox.Show(" Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lblMode.Text = "Edit Contact ID =" + _Contact.ID;
            lblContactID.Text = _Contact.ID.ToString();
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            llRemoveImage.Visible = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
