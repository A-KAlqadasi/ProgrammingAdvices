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
    public partial class frmMaskedTextBox : Form
    {
        public frmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskFull)
            {
                button1.Text = "Full";
            }
            else
            {
                button1.Text = "Not Full";
            }
        }
    }
}
