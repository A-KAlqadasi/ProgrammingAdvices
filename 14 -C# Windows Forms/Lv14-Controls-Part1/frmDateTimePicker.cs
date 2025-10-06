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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnShortDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());
        }

        private void btnLongDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString().ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDateString.Text = dateTimePicker1.Value.ToString("dd/MMM/yyyy") + Environment.NewLine;
            lblDateString.Text += dateTimePicker1.Value.ToString("dddd/MMM/yyyy") + Environment.NewLine;
            lblDateString.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            lblDateString.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            lblDateString.Text += dateTimePicker1.Value.ToString("dddd, dd-MMM-yyyy") + Environment.NewLine;
        }

        private void btnLocalTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLocalTime().ToString());
        }

        private void btnTestDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString().ToString());
            // MessageBox.Show(dateTimePicker1.Value.ToUniversalTime().ToString());
            //MessageBox.Show(dateTimePicker1.Value.ToOADate().ToString());
        }

    }
}
