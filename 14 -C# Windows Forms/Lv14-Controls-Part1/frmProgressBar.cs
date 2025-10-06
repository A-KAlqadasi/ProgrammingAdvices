using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lv14_Controls_Part1
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnIncreaseProgress_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            for(int i = 0;i <=10;i++)
            {
                if(progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    lblPercent.Text = (((float)progressBar1.Value / progressBar1.Maximum)*100) +"%";

                    progressBar1.Refresh();
                    lblPercent.Refresh();
                }
                else
                {
                    btnIncreaseProgress.Enabled = false;
                }
            }
        }

        private void btnResetProgress_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            lblPercent.Text = "0%";
            btnIncreaseProgress.Enabled = true;
        }
    }
}
