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
    public partial class Form3 : Form
    {


        String id;

        String username;

        int age;

        String phone;

        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_action_Click(object sender, EventArgs e)
        {


            id = id_textbox.Text;
            username = username_textbox.Text;
            phone = phone_textbox.Text;

            bool isValidAge = int.TryParse(age_textbox.Text, out age);



            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(username) || !isValidAge || age <= 0 || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill the empty box!! or age must be positive number");
            }
            else
            {
                student_datagridview.Rows.Add(id, username, age, phone);
                id_textbox.Clear();
                username_textbox.Clear();
                age_textbox.Clear();
                phone_textbox.Clear();

            }



        }



        private void delete_btn_action_Click(object sender, EventArgs e)
        {

            if (student_datagridview.CurrentRow == null || student_datagridview.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please selecte row first! to delete");

            }
            else
            {
                String deleteMsg = "Are you sure that you would like to delteed this student?";

                DialogResult result = MessageBox.Show(deleteMsg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    student_datagridview.Rows.Remove(student_datagridview.CurrentRow);
                    MessageBox.Show("Student deleted successfully.");

                }

            }

        }


        private void show_btn_action_Click(object sender, EventArgs e)
        {

            if (student_datagridview.CurrentRow == null || student_datagridview.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please selecte row first!");

            }
            else
            {

                DataGridViewRow dt = student_datagridview.CurrentRow;

                id = dt.Cells[0].Value?.ToString() ?? "is id null?";
                username = dt.Cells[1].Value.ToString();
                age = int.Parse(dt.Cells[2].Value.ToString());
                phone = dt.Cells[3].Value.ToString();


                showFrm sh = new showFrm(id, username, age, phone);


                sh.Show();



            }

        }

        private void update_action_Click(object sender, EventArgs e)
        {
            if (student_datagridview.CurrentRow == null)
            {
                MessageBox.Show("Please select a row first to update!");
            }
            else
            {
                //get all the value
                DataGridViewRow dt = student_datagridview.CurrentRow;

                //past to udpateFrm

                updateFrm up = new updateFrm(dt);

                //show dialog

                up.ShowDialog();


            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void search_btn_action_Click(object sender, EventArgs e)
        {
            String searchKeyWord = seach_textbox.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchKeyWord))
            {
                MessageBox.Show("Please type something to search!");
            }

            bool isFound = false;


            for (int i = 0; i < student_datagridview.Rows.Count; i++)

             {

                if (student_datagridview.Rows[i].IsNewRow) continue;

                String usernameValue = student_datagridview.Rows[i].Cells[1].Value.ToString();

                //compare with ignore case

                if (usernameValue.ToLower().Contains(searchKeyWord))
                {

                    student_datagridview.ClearSelection();
                    student_datagridview.Rows[i].Selected = true;
                    student_datagridview.CurrentCell = student_datagridview.Rows[i].Cells[1];

                    isFound = true;

                    break;


                }

             
            }

            if (isFound == false)
            {
                MessageBox.Show("Student not found!");
            }



        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void seach_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
