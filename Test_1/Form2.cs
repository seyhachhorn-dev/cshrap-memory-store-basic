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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String textBoxShowValue = textBox_Show.Text;

            if (!string.IsNullOrWhiteSpace(textBoxShowValue)) {
                lbl_show.Text += $"{textBoxShowValue}\n";
                
                textBox_Show.Clear();

            }
            else
            {
                MessageBox.Show("Please enter some text!");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
