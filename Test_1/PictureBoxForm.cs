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
    public partial class PictureBoxForm : Form
    {
        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void btn_upload_action_Click(object sender, EventArgs e)
        {

            OpenFileDialog fp = new OpenFileDialog();
            fp.Title ="Upload";
            fp.Filter =  "Image File|*.png; *.jpg; *.jpeg";
            fp.Multiselect = true;



            if(fp.ShowDialog() == DialogResult.OK)
            {
                pf_picturebox.ImageLocation = fp.FileName;
            }

        }

        private void textBox_ImageLocationUpload_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_ImageLocationUpload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               pf_picturebox.ImageLocation =  textBox_ImageLocationUpload.Text;
            }
        }

        private void PictureBoxForm_Load(object sender, EventArgs e)
        {
            this.pf_picturebox.Image = global::Test_1.Properties.Resources.SeyhaProfile;
        }
    }
}
