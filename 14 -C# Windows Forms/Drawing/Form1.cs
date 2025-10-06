using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0,0,0);

           Pen Pen= new Pen(Black);
            Pen.Width = 10;

           //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

           Pen.StartCap =System.Drawing.Drawing2D.LineCap.Round;
           Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 100, 100, 100, 200);
            //e.Graphics.DrawLine(Pen, 300, 100, 300, 400);
            //e.Graphics.DrawLine(Pen, 400, 100, 400, 400);
            //e.Graphics.DrawLine(Pen, 500, 100, 500, 400);

            //e.Graphics.DrawLine(Pen, 200, 200, 500, 200);
            //e.Graphics.DrawLine(Pen, 200, 300, 500, 300);

            e.Graphics.DrawRectangle(Pen, 200, 200, 300, 300);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
