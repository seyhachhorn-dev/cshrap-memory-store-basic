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
    public partial class frmRandomImage : Form
    {
     
       
        private DataGridViewRowCollection _row;
        private Random random = new Random();
        private Timer randomTimer = new Timer();


        public frmRandomImage(DataGridViewRowCollection rows)
        {
            InitializeComponent();

            _row = rows;
        }

        public frmRandomImage()
        {
        }

        private void frmRandomImage_Load(object sender, EventArgs e)
        {
          
            randomTimer.Interval = 200;
            randomTimer.Tick += RandomTimer_Tick;
            randomTimer.Start();

        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            showRandomImage();
        }

        private void showRandomImage()
        {
            List<DataGridViewRow> imageRowData = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in _row)
            {

                if(!row.IsNewRow && row.Cells[0].Value != null)

                {
                    imageRowData.Add(row);

                }

                if (imageRowData.Count == 0)
                {
                    randomTimer.Stop();
                    MessageBox.Show("No images found!2");
                    this.Close();

                }
                else
                {
                    //pick random row

                    int randomIndex = random.Next(0, imageRowData.Count);
                    pf_pictureBox.Image = (Image)imageRowData[randomIndex].Cells[0].Value;
                }

             


            }


        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            randomTimer.Stop();
        }
    }
}
