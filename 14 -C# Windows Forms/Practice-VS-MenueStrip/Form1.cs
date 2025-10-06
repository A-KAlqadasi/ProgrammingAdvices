using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_VS_MenueStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;


        }

        private void fileToolStripMenueItem_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show(saveFileDialog1.FileName.ToString());
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
