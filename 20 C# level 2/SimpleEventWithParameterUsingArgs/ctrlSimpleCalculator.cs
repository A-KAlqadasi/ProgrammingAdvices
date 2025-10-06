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
    public partial class ctrlSimpleCalculator : UserControl
    {
        // Define a custom event handler delegate with parameters
        //public event Action<int> OnCalculationComplete;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void CalculationComplete(int PersonID)
        //{
        //    Action<int> handler = OnCalculationComplete;
        //    if (handler != null)
        //    {
        //        handler(PersonID); // Raise the event with the parameter
        //    }
        //}

        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Value1 { get; }
            public int Value2 { get; }
            public int Result { get; }
            public CalculationCompleteEventArgs(int value1, int value2, int result)
            {
                this.Value1 = value1; 
                this.Value2 = value2;
                this.Result = result;
            }
        }
        //define the event 
        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaisOnCalculationComplete(int value1, int value2, int result)
        {
            RaisOnCalculationComplete(new CalculationCompleteEventArgs(value1, value2, result));
        }
        
        protected virtual void RaisOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        public ctrlSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt32(txtNumber1.Text);
            int value2 = Convert.ToInt32(txtNumber2.Text);
            int result = value1 + value2;
            lblResult.Text = result.ToString();

            if(OnCalculationComplete != null)
                // Raise the event with parameters
                RaisOnCalculationComplete(value1,value2,result);

        }
    }
}
