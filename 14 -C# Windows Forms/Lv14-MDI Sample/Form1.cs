using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lv14_MDI_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        Form frm2 = new Form2();
            
        private void button1_Click(object sender, EventArgs e)
        {
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}
