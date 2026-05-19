using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class showFrm : Form
    {

        public showFrm(String id, String username, int age, String phone)
        {
            InitializeComponent();
            id_textbox.Text = id;
            username_textbox.Text = username;
            age_textbox.Text = age.ToString();
            phone_textbox.Text = phone;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showFrm_Load(object sender, EventArgs e)
        {
            id_textbox.ReadOnly = true;
            username_textbox.ReadOnly = true;
            age_textbox.ReadOnly = true;
            phone_textbox.ReadOnly = true;

        }
    }
}
