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

            string selectedLang = comboBox_lan.SelectedItem.ToString();
            currentLang = (selectedLang == "Khmer" ? "KH" : "EN");

            UpdateUILabels();

            ClearDropdowns(true, true, true, true);

            LoadLocation(null, comboBox_city);
        }

        private void LoadLocation(int? parentId, ComboBox targetCombo)
        {
            targetCombo.Items.Clear();

            string columnName = (currentLang == "KH") ? "TitleKH" : "TitleEN";

            string query = parentId == null ?
                $"SELECT ID, {columnName} AS Title FROM AdministrativeBoundaries WHERE Code IS NULL ORDER BY ID" :
                $"SELECT ID, {columnName} AS Title FROM AdministrativeBoundaries WHERE Code = @parentId ORDER BY ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parentId != null)
                    {
                        cmd.Parameters.AddWithValue("@parentId", parentId.Value);
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

                if (targetCombo == comboBox_city && targetCombo.Items.Count > 0)
                {
                    targetCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDropdowns(bool city, bool dis, bool comm, bool village)
        {
            if (city) comboBox_city.Items.Clear();
            if (dis) comboBox_district.Items.Clear();
            if (comm) comboBox_commune.Items.Clear();
            if (village) comboBox_village.Items.Clear();
        }

        private void Exercise3_Load(object sender, EventArgs e)
        {
            comboBox_lan.SelectedIndex = 1;

            if(currentLang == "KH")
            { 
            lblCity.Text = "រាជធានី/ខេត្ត";
            lblDistrict.Text = "ស្រុក/ខណ្ឌ";
            lblCommune.Text = "ឃុំ/សង្កាត់";
            lblVillage.Text = "ភូមិ";
            lblLanguage.Text​ = "ភាសា";
            }

        }

        private void UpdateUILabels()
        {
            if (currentLang == "KH")
            {
                lblCity.Text = "រាជធានី/ខេត្ត";
                lblDistrict.Text = "ស្រុក/ខណ្ឌ";
                lblCommune.Text = "ឃុំ/សង្កាត់";
                lblVillage.Text = "ភូមិ";
                lblLanguage.Text = "ភាសា"; 
                btn_save.Text = "រក្សាទុក";
                btn_clear.Text = "សម្អាត";
            }
            else
            {
                lblCity.Text = "City/Province";
                lblDistrict.Text = "District";
                lblCommune.Text = "Commune";
                lblVillage.Text = "Village";
                lblLanguage.Text = "Language";
                btn_save.Text = "Save";
                btn_clear.Text = "Clear";
            }
        }


        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDropdowns(false, true, true, true);

            if (comboBox_city.SelectedItem is ComboBoxItem selectedCity)
            {
                LoadLocation(selectedCity.id, comboBox_district);
            }
        }

        private void comboBox_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDropdowns(false, false, true, true);

            if (comboBox_district.SelectedItem is ComboBoxItem selectedDistrict)
            {
                LoadLocation(selectedDistrict.id, comboBox_commune);
            }
        }

        private void comboBox_commune_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDropdowns(false, false, false, true);

            if (comboBox_commune.SelectedItem is ComboBoxItem selectedCommune)
            {
                LoadLocation(selectedCommune.id, comboBox_village);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string city = comboBox_city.SelectedItem?.ToString();
            string dis = comboBox_district.SelectedItem?.ToString();
            string comm = comboBox_commune.SelectedItem?.ToString();
            string village = comboBox_village.SelectedItem?.ToString();

            List<string> addressPart = new List<string>();

            if (currentLang == "KH")
            {


                if (!string.IsNullOrEmpty(village)) addressPart.Add("ភូមិ" + village);
                if (!string.IsNullOrEmpty(comm)) addressPart.Add("សង្កាត់" + comm);
                if (!string.IsNullOrEmpty(dis)) addressPart.Add("ខណ្ឌ" + dis);
                if (!string.IsNullOrEmpty(city)) addressPart.Add(city);

                textBox_address.Text = string.Join(" ", addressPart);
            }
            else
            {
                if (!string.IsNullOrEmpty(village)) addressPart.Add(village + " Village");
                if (!string.IsNullOrEmpty(comm)) addressPart.Add(comm + " Commune");
                if (!string.IsNullOrEmpty(dis)) addressPart.Add(dis + " District");
                if (!string.IsNullOrEmpty(city)) addressPart.Add(city);

                textBox_address.Text = string.Join(", ", addressPart);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_address.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}