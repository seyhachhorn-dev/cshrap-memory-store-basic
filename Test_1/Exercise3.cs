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

namespace Test_1
{
    public partial class Exercise3 : Form
    {

        private string currentLang = "KH";
        private readonly string connectionString = "Data Source=(local); Initial Catalog=csharp; Persist Security Info=true; User ID=sa; Password=seyha123";
        public Exercise3()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public int id { get; set; }
            public string Title { get; set; }

            public override string ToString() => Title;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_lan.SelectedItem == null) return;

            //update current selected

            string selectedLang = comboBox_lan.SelectedItem.ToString();
            currentLang = (selectedLang == "Khmer" ? "KH" : "EN");
            LoadLocation(null, comboBox_city);
        }

        private void LoadLocation(int? parentId,ComboBox targetCombo)

        {

            targetCombo.Items.Clear();

            string columnName = (currentLang == "KH") ? "TitleKH" : "TitleEN";

            string query = parentId == null ?
                "SELECT ID, {columnName} AS Title FROM AdministrativeBoundaries WHERE Code IS NULL ORDER BY ID" :
                "SELECT ID, {columnName} AS Title FROM AdministrativeBoundaries WHERE Code = @parentId ORDER BY ID";

                using(SqlConnection con = new SqlConnection(connectionString))
                try
                {

                    using(SqlCommand cmd = new SqlCommand(query,con))
                    {
                        if(parentId != null)
                        {
                            cmd.Parameters.AddWithValue("@columnName", parentId.Value);
                        }
                        con.Open();

                        SqlDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            ComboBoxItem item = new ComboBoxItem
                            {
                                id = Convert.ToInt32(rd["ID"]),
                                Title = rd["Title"].ToString()
                            };

                            targetCombo.Items.Add(item);
                        }

                    }

                    // Auto-select the first item if it's the City/Province box
                    if (targetCombo == comboBox_city && targetCombo.Items.Count > 0)
                    {
                        targetCombo.SelectedIndex = 0;
                    }



                }
                catch(Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

        private void ClearDropdowns(bool city,bool dis, bool comm, bool village)
        {
            if (city) comboBox_city.Items.Clear();
            if (dis) comboBox_district.Items.Clear();
            if (comm) comboBox_commune.Items.Clear();
            if (village) comboBox_village.Items.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exercise3_Load(object sender, EventArgs e)
        {
            comboBox_lan.SelectedIndex = 1;
       

        }
    }
}
