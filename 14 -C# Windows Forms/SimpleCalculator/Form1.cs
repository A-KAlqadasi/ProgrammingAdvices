using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        short _NumOne = 0;
        short _NumTwo = 0;
        string _Operation = "";

        void Addition()
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(_Operation == "")
            {

                lblCalculatorScreen.Text += btnOne.Tag;
                _NumOne = Convert.ToInt16(lblCalculatorScreen.Text);
            }
            else
            {
                if (lblCalculatorScreen.Text == _Operation)
                    lblCalculatorScreen.Text = "";
                
                lblCalculatorScreen.Text += btnOne.Tag;
                _NumTwo = Convert.ToInt16(lblCalculatorScreen.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblCalculatorScreen.Text = "0";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_Operation == "")
            {

                lblCalculatorScreen.Text += btnTwo.Tag;
                _NumOne = Convert.ToInt16(lblCalculatorScreen.Text);
            }
            else
            {
                if (lblCalculatorScreen.Text == _Operation)
                    lblCalculatorScreen.Text = "";

                lblCalculatorScreen.Text += btnTwo.Tag;
                _NumTwo = Convert.ToInt16(lblCalculatorScreen.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblCalculatorScreen.Text = btnAdd.Tag.ToString();
            _Operation = btnAdd.Tag.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(_Operation)
            {
                case "+":
                    lblCalculatorScreen.Text = (_NumOne + _NumTwo).ToString();
                    break;

            }
        }
    }
}
