using Lv14_Controls_Part1.Properties;
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
    public partial class frmImageBox : Form
    {
        public frmImageBox()
        {
            InitializeComponent();
        }

        private void btnWeak_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.weak;
        }

        private void btnStrong_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.strong;
        }

        private void btnQuestionImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Abdulkarim\Downloads\Question.jpg");
        }
    }
}
