using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1.view
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string str_username = textUsername.Text.Trim();
            string str_password = textPassword.Text.Trim();

            if(string.IsNullOrEmpty(str_username) && string.IsNullOrEmpty(str_password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isLogged = HelperClass.IsValidUser(str_username, str_password);

            if (isLogged)
            {
                MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void showPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassword_CheckBox.Checked == true)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';

            }
        }
    }
}
