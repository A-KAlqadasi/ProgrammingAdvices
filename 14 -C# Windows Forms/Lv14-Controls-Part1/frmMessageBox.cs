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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is message");
        }

        private void btnMessageWithTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message", "this is a title koko");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("you pressed ok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Cofirm!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("you pressed ok");
            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Confirm!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("you pressed ok");
            }
        }
    }
}
