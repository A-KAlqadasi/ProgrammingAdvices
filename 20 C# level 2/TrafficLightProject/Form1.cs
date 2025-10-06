using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
            ctrlTrafficLight21.Start();
        }

        private void ctrlTrafficLight1_GreenLightOn(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
           MessageBox.Show(e.CurrentLight.ToString()+", stop car people walk");
        }

        private void ctrlTrafficLight21_GreenLightOn(object sender, ctrlTrafficLight2.TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString() + ", stop car people walk");

        }
    }
}
