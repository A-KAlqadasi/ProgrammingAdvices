using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            int personID = -1;
            if(int.TryParse(txtPersonID.Text, out personID))
            {
                Form2 frm = new Form2(personID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Id should be number!");
                txtPersonID.Focus();
            }
        }
    }
}
