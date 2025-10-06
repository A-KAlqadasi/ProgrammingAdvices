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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }
        private int _Counter = 0;
        private int _Counter2 = 60;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Counter++;
            label1.Text = _Counter.ToString();
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled= false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_Counter2 == 0)
            {
                timer2.Enabled = false;
            }
            label2.Text = _Counter2.ToString();
            _Counter2--;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _Counter2 = 60;
            label2.Text = _Counter2.ToString();
        }
    }
}
