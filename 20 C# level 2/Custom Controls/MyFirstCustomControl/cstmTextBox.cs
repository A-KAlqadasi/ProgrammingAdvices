using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCustomControl
{
    public partial class cstmTextBox : TextBox
    {
        public cstmTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool IsRequired { get; set; }
        public enum enInputType { TextInput =1, NumericInput=2}
        public enInputType InputType { get ; set; }= enInputType.TextInput;

        private bool IsNumeric()
        {
            string s = this.Text.Trim();
            foreach(char c in s)
            {
                if(!char.IsDigit(c) && c != '.')
                    return false;
            }
            return true;
        }
        public Boolean IsValid()
        {
            if(IsRequired)
            {
                if(this.Text.Trim() == "")
                    return false;
            }

            if(InputType == enInputType.NumericInput)
            {
                return IsNumeric();
            }
            return true;
        }

    }
}
