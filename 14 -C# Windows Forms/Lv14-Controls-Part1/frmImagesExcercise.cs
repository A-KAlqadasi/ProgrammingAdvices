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
    public partial class frmImagesExcercise : Form
    {
        public frmImagesExcercise()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            label1.Text = ((RadioButton)sender).Tag.ToString(); 
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Images\Book.png");
            label1.Text= ((RadioButton)sender).Tag.ToString();
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Images\Pen.png");
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }
    }
}
