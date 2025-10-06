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
    public partial class frmTapPage : Form
    {
        public frmTapPage()
        {
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is courses tab control");
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is subjects tab control");
        }
    }
}
