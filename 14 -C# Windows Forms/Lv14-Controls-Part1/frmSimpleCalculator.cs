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
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }
        float _Number1 = 0;
        float _Number2 = 0;
        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            if(txtNumber1.Text != "")
            _Number1 = Convert.ToSingle(txtNumber1.Text);
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            if(txtNumber2.Text != "")
            _Number2 = Convert.ToSingle(txtNumber2.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNumber1.Text != "" || txtNumber2.Text != "" )
            lblResult.Text = (_Number1 + _Number2).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" || txtNumber2.Text != "")
                lblResult.Text = (_Number1 - _Number2).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" || txtNumber2.Text != "")
                lblResult.Text = (_Number1 * _Number2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != "" || txtNumber2.Text != "")
                lblResult.Text = (_Number1 / _Number2).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0000";
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            _Number1 = 0;
            _Number2 = 0;
        }
    }
}
