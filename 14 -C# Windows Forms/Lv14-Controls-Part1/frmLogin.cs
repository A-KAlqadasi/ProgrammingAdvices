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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string _UserName = "";
        string _Password = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _UserName = txtUserName.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = Convert.ToChar("*");
            _Password = txtPassword.Text;
        }

        bool CheckUserNameAndPassword(string userName , string password)
        {
            return (userName == txtUserName.Tag.ToString()) && (password == txtPassword.Tag.ToString());
        }

        void Login()
        {
            string message = $"Hi {txtUserName.Tag}, Welcome back.";
            if(CheckUserNameAndPassword(_UserName, _Password))
            {
                MessageBox.Show(message, "Check Login");
            }
            else
            {
                MessageBox.Show("Wrong UserName/Password try again!", "Check Login",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
