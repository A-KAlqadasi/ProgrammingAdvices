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
    public partial class myUserControl : UserControl
    {

        //Define a custom event handler delegate with parameters
        public event Action<int> OnCalculateComplete;
        //Create a protected method to raise the event with a parameters
        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> handler = OnCalculateComplete;
            if(handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public myUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
           lblResult.Text =result.ToString(); 

            if(OnCalculateComplete != null)
                //Raise the event with a paramter
                CalculationComplete(result);

        }
    }
}
