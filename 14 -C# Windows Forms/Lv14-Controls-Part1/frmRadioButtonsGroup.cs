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
    public partial class frmRadioButtonsGroup : Form
    {
        public frmRadioButtonsGroup()
        {
            InitializeComponent();
        }

        private void btnCheckBoxState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkReciveEmails.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnCheckBoxState.Enabled = chkReciveEmails.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbMedium.Checked.ToString());   
        }
    }
}
