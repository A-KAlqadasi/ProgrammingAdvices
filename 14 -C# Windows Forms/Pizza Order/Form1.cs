using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        void UpdateOrderSummary()
        {
            UpdateTotalPrice();
            UpdateCrust();
            UpdateSize();
            UpdateWhereToEat();
            UpdateToppings();
        }

        float GetSizePrice()
        {
            
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if(rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }   

            return Convert.ToSingle(rbLarge.Tag);
        }

        float GetCrustPrice()
        {
            if(rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else 
                return Convert.ToSingle(rbThickCrust.Tag);
        }
    
        float GetToppingsPrice()
        {
            float toppingsPrice = 0;

            if(chkExtraChees.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if(chkOnion.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if(chkOlives.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if(chkTomatoes.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if(chkMushrooms.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if(chkGreenPeppers.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return toppingsPrice;

        }
        
        float CalculateTotalPrice()
        {
            return GetCrustPrice()+ GetSizePrice() + GetToppingsPrice();
        }
        
        void UpdateTotalPrice()
        {
            
            lblPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            if (NumOfPizzas.Value.ToString() == "1")
            {
                UpdateTotalPrice();
            }
            else
            {
                UpdateNumberOfPizzas();

            }

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            lblSize.Text = "Large";

        }

        void UpdateCrust()
        {

            if (NumOfPizzas.Value.ToString() == "1")
            {
                UpdateTotalPrice();
            }
            else
            {
                UpdateNumberOfPizzas();

            }

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
            if(rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            if(rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }

            if(rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        }

        void UpdateToppings()
        {
            if (NumOfPizzas.Value.ToString() == "1")
            {
                UpdateTotalPrice();
            }
            else
            {
                UpdateNumberOfPizzas();

            }
            
            string toppings = "";
            if(chkExtraChees.Checked)
            {
                toppings += "Extra Chees";
            }

            if(chkOnion.Checked)
            {
                toppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                toppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                toppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                toppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                toppings += ", Green Peppers";
            }

            if (toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1, toppings.Length - 1).Trim();
            }
            if (toppings == "")
            {
                toppings = "No Toppings";
            }

            lblToppings.Text = toppings;

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Succeeded");
                
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbSize.Enabled = false;

                btnOrderPizza.Enabled = false;

            }
            
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            // desiable toppings 
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;


            // enable group box
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbSize.Enabled = true;

            // enable size 
            rbEatIn.Checked = true;
            rbMedium.Checked = true;
            rbThinCrust.Checked = true;


            // enable order button
            btnOrderPizza.Enabled = true;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        string  UpdateNumberOfPizzas()
        {
            int number1 = Convert.ToInt32(NumOfPizzas.Value);
            int number2 = Convert.ToInt32(CalculateTotalPrice());
            
            int result = number1 * number2;

            lblPrice.Text = "$" + result.ToString();
            return result.ToString();
        }

        private void NumOfPizzas_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfPizzas();
        }
    }
}
