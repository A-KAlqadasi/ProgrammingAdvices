using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        private int _Number1 ;
        private int _Number2 ;
        private int _Result ;

        private string _Num1;
        
        private void SetNumberOne(Button btn)
        {
            _Number1 = Convert.ToInt32(btn.Tag.ToString());
            textBox1.Tag = "N2";
        }

        private void  SetNumberTwo(Button btn)
        {
            _Number2= Convert.ToInt32(btn.Tag.ToString());
            textBox1.Tag = "N1";
        }

        private void DisplayNumber()
        {

            if(textBox1.Tag.ToString() == "N1")
            {
                textBox1.Text = _Number2.ToString();
               
            }
            else if(textBox1.Tag.ToString() == "N2")
            {
                textBox1.Text = _Number1.ToString();  
            }

        }

        private void btnOne_Click(object sender, EventArgs e)
        {   
            
            btnOne.Tag += btnOne.Text.ToString();

            if(textBox1.Tag.ToString() == "N1")
            {
                SetNumberOne(btnOne);
            }
            else if(textBox1.Tag.ToString() == "N2")
            {
                SetNumberTwo(btnOne);
            }
            DisplayNumber();
            btnTwo.Tag = "0".ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            
            btnTwo.Tag += btnTwo.Text.ToString();
            
            if (textBox1.Tag.ToString() == "N1")
            {
                SetNumberOne(btnTwo);
            }
            else if (textBox1.Tag.ToString() == "N2")
            {
                SetNumberTwo(btnTwo);
            }
            DisplayNumber();
            btnOne.Tag = "0".ToString();

        }

        private int Sum ()
        {
            return _Number1 + _Number2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Sum().ToString();
        }
    }
}
