using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithParameterUsingArgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlSimpleCalculator1_OnCalculationComplete(object sender, ctrlSimpleCalculator.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"Result ={e.Result}, value1={e.Value1}, value2={e.Value2}");
        }
    }
}
