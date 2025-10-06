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
    public partial class Form2 : Form
    {
        private int _PersonID;
        public Form2(int personID)
        {
            InitializeComponent();
            this._PersonID = personID;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblPersonID.Text = _PersonID.ToString();
        }
    }
}
