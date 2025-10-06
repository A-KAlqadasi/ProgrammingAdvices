using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithParameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myUserControl1_OnCalculateComplete(int obj)
        {
            int result = obj;
            MessageBox.Show("Result is = " + result.ToString(), "Show Result");
        }
    }
}
