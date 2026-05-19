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
    public partial class Excersice2Frm : Form

    {

        private bool messageShow = false;
        public Excersice2Frm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void add_btn_action_Click(object sender, EventArgs e)
        {
            OpenFileDialog fp = new OpenFileDialog();

            fp.Title = "Add";
            fp.Filter = "Image File|*.png; *.jpg; *.jpeg";

            if(fp.ShowDialog() == DialogResult.OK)

            {
                imgUpload_textBox.Text = fp.FileName;
                Bitmap userImage = new Bitmap(fp.FileName);
                imageUser_gridView.Rows.Add(userImage);

                // to avoid auto display on  pf picture box
                imageUser_gridView.ClearSelection();
                pf_pictureBox.Image = null;
                return;


            }
           


        }

        private void Excersice2Frm_Load(object sender, EventArgs e)
        {


        }

        private void imageUser_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imageUser_gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (imageUser_gridView.CurrentRow == null || imageUser_gridView.CurrentRow.IsNewRow)
            {

                if (!messageShow) { 
                MessageBox.Show("Please Add Image to Display");
                  messageShow = true;
               
                }

            }
            else
            {
                DataGridViewRow dt = imageUser_gridView.CurrentRow;

                // to avoid auto display on  pf picture box handle with ictureBox Image = null;
                if (dt.Cells[0].Value == null)
                    return;

                pf_pictureBox.Image = (Image)dt.Cells[0].Value;

            }



        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (imageUser_gridView.Rows.Count <= 1)
            {
                MessageBox.Show("Add Images First!");

            }
            else
            {
                frmRandomImage rm = new frmRandomImage(imageUser_gridView.Rows);
                rm.ShowDialog();

            }
        }
    }
}
