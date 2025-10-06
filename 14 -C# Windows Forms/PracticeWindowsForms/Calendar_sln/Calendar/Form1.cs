using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        
        public DateTime now = DateTime.Now;
        int monthsCounter = 0;
        int yearsCounter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays(now.Month, now.Year);
        }

        private void displayDays(int month , int year)
        {
           

            // lets get the first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofMonth to integer 
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            // first lets create a blank user control
            for (int i = 1;i <=dayOfWeek;i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daysContainer.Controls.Add(ucBlank);
            }
            
            for (int i = 1; i <=days;i++)
            {
                UserControlDay ucDays = new UserControlDay();
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            monthsCounter++;

            if((monthsCounter+now.Month)<12)
            {
                daysContainer.Controls.Clear();
                displayDays((monthsCounter + now.Month), now.Year);
            }
            else
            {
                btnNext.Enabled = false;
                daysContainer.Controls.Clear();
                displayDays((monthsCounter + now.Month), now.Year);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            monthsCounter--;
            if ((monthsCounter + now.Month)>0)
            {
                daysContainer.Controls.Clear();
                displayDays((monthsCounter + now.Month), now.Year);
            }
            else
            {
                btnPrevious.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();

        }
    }
}