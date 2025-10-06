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
    public partial class frmDialogs : Form
    {
        public frmDialogs()
        {
            InitializeComponent();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowHelp = true;

            fontDialog1.Font = textBox1.Font;
           
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Title = "File Save";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter =  "txt files(*.txt)|*.txt" +
                                      "|All files(*.*)|*.*" +
                                      "|Images (*.jpg)|*.jpg";
            saveFileDialog1.FilterIndex = 2;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "File Open";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files(*.txt)|*.txt" +
                                      "|All files(*.*)|*.*" +
                                      "|Images (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void btnOpenFileDialogMulti_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            //openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "File Open";
            //openFileDialog1.DefaultExt = "txt";
            //openFileDialog1.Filter = "txt files(*.txt)|*.txt" +
            //                        "|All files(*.*)|*.*" +
            //                       "|Images (*.jpg)|*.jpg";
            //openFileDialog1.FilterIndex = 2;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openFileDialog1.FileNames)
                {
                    MessageBox.Show(file);
                }
            }

        }

        private void btnFolderBrowsingDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
