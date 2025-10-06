using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace PracticeOnListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListAllContacts()
        {           

            DataTable dt = clsContact.GetAllContacts();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["ContactID"].ToString());

                item.SubItems.Add(dr["FirstName"].ToString());
                item.SubItems.Add(dr["LastName"].ToString());
                item.SubItems.Add(dr["BirthDate"].ToString());
                item.SubItems.Add(dr["Address"].ToString());
                item.SubItems.Add(dr["CountryID"].ToString());
                item.SubItems.Add(dr["Salary"].ToString());
                item.SubItems.Add(dr["Email"].ToString());
                item.SubItems.Add(dr["Phone"].ToString());


                listView1.Items.Add(item);


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllContacts();
        }
    }
}