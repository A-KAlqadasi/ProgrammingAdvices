using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstUserControl
{
    public partial class ctrlSimpleCalculator : UserControl
    {
        public ctrlSimpleCalculator()
        {
            InitializeComponent();
        }

        public float Result
        {
            get { return (float)(Convert.ToSingle(lblResult.Text)); }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }
    }
}
