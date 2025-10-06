using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBackToFormUsingDelegate
{
    public partial class Form2 : Form
    {

        //Declare a delegate 
        public delegate void DataBackEventHandler(object sender, int personID);

        //Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendDataBack_Click(object sender, EventArgs e)
        {
            int personID = int.Parse(txtPersonID.Text);

            //Trigger the event to send data back to Form1
            DataBack?.Invoke(this, personID);
            
            this.Close();

        }
    }
}
