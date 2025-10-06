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
    public partial class frmComboBoxImages : Form
    {
        public frmComboBoxImages()
        {
            InitializeComponent();
        }

        private void cbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPictures.SelectedItem)
            {
                case "Boy":
                    label1.Text = "Boy";
                    pictureBox1.Image = Resources.Boy;
                    break;
                case "Girl":
                    label1.Text = "Girl";
                    pictureBox1.Image = Resources.Girl;
                    break;
                case "Pen":
                    label1.Text = "Pen";
                    pictureBox1.Image = Resources.Pen;
                    break;
                case "Book":
                    label1.Text = "Book";
                    pictureBox1.Image = Resources.Book;
                    break;

            }
        }

        private void frmComboBoxImages_Load(object sender, EventArgs e)
        {
            cbPictures.SelectedIndex = 0;
        }
    }
}
