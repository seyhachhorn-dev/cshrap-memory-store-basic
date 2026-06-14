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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tbl_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.csharpDataSet);

        }

        private void tbl_usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.csharpDataSet);

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'csharpDataSet.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.csharpDataSet.tbl_users);

        }

        private void picturePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            this.tbl_usersBindingNavigatorSaveItem_Click(sender, e);
            MessageBox.Show("Saved!");
        }

        private void toolStrip_Create_Click(object sender, EventArgs e)
        {
            this.tbl_usersBindingSource.AddNew();
            this.disableCheckBox.Checked = false;

        }

        private void picturePictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fp = new OpenFileDialog();
            fp.Title = "Selected Image";
            fp.Filter = "Image|*.png";
            fp.Multiselect = false;

            if(fp.ShowDialog() == DialogResult.OK)
            {
                picturePictureBox.ImageLocation = fp.FileName;
            }
        }

        private void toolStrip_Delete_Click(object sender, EventArgs e)


        {

            var msg = MessageBox.Show("Delete", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(msg == DialogResult.Yes)
            {
                this.tbl_usersBindingSource.RemoveCurrent();
                this.tbl_usersBindingNavigatorSaveItem_Click(sender, e);
                MessageBox.Show("Delete Successfully!");
            }
            
        }

        private void toolStrip_Search_Click(object sender, EventArgs e)
        {
            //this.tbl_usersBindingSource.Filter = "id" +
        }
    }
}
