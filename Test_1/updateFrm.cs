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
    public partial class updateFrm : Form
    {
        private DataGridViewRow _selectedRow;

        public updateFrm(DataGridViewRow row)
        {
         
            InitializeComponent();
            _selectedRow = row;
            id_textbox.Text = row.Cells[0].Value.ToString();
            username_textbox.Text = row.Cells[1].Value.ToString();
            age_textbox.Text = row.Cells[2].Value.ToString();
            phone_textbox.Text = row.Cells[3].Value.ToString();
        }

        private void calcen_btn_aciton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_action_Click(object sender, EventArgs e)
        {
            string id = id_textbox.Text;
            string username = username_textbox.Text;
            string phone = phone_textbox.Text;
            bool isValidAge = int.TryParse(age_textbox.Text, out int age);

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(username) || !isValidAge || age <= 0 || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill all the Box or Age must be a positive number.");
            }
            else {


                _selectedRow.Cells[0].Value = id;
                _selectedRow.Cells[1].Value = username;
                _selectedRow.Cells[2].Value = age;
                _selectedRow.Cells[3].Value = phone;

                MessageBox.Show("Updated successfully!");
                this.Close(); 
            }

        }

        private void updateFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
