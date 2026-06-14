namespace Test_1
{
    partial class Exercise3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLanguage = new System.Windows.Forms.Label();
            this.comboBox_lan = new System.Windows.Forms.ComboBox();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.comboBox_district = new System.Windows.Forms.ComboBox();
            this.comboBox_commune = new System.Windows.Forms.ComboBox();
            this.comboBox_village = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblVillage = new System.Windows.Forms.Label();
            this.lblCommune = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(583, 47);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(108, 26);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language";
            // 
            // comboBox_lan
            // 
            this.comboBox_lan.FormattingEnabled = true;
            this.comboBox_lan.Items.AddRange(new object[] {
            "English",
            "Khmer"});
            this.comboBox_lan.Location = new System.Drawing.Point(717, 47);
            this.comboBox_lan.Name = "comboBox_lan";
            this.comboBox_lan.Size = new System.Drawing.Size(140, 28);
            this.comboBox_lan.TabIndex = 1;
            this.comboBox_lan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_city
            // 
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Items.AddRange(new object[] {
            "English",
            "Khmer"});
            this.comboBox_city.Location = new System.Drawing.Point(266, 178);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(357, 40);
            this.comboBox_city.TabIndex = 2;
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
            // 
            // comboBox_district
            // 
            this.comboBox_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_district.FormattingEnabled = true;
            this.comboBox_district.Items.AddRange(new object[] {
            "English",
            "Khmer"});
            this.comboBox_district.Location = new System.Drawing.Point(266, 250);
            this.comboBox_district.Name = "comboBox_district";
            this.comboBox_district.Size = new System.Drawing.Size(357, 40);
            this.comboBox_district.TabIndex = 3;
            this.comboBox_district.SelectedIndexChanged += new System.EventHandler(this.comboBox_district_SelectedIndexChanged);
            // 
            // comboBox_commune
            // 
            this.comboBox_commune.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_commune.FormattingEnabled = true;
            this.comboBox_commune.Items.AddRange(new object[] {
            "English",
            "Khmer"});
            this.comboBox_commune.Location = new System.Drawing.Point(266, 316);
            this.comboBox_commune.Name = "comboBox_commune";
            this.comboBox_commune.Size = new System.Drawing.Size(357, 40);
            this.comboBox_commune.TabIndex = 4;
            this.comboBox_commune.SelectedIndexChanged += new System.EventHandler(this.comboBox_commune_SelectedIndexChanged);
            this.comboBox_commune.SelectedValueChanged += new System.EventHandler(this.comboBox_commune_SelectedIndexChanged);
            // 
            // comboBox_village
            // 
            this.comboBox_village.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_village.FormattingEnabled = true;
            this.comboBox_village.Items.AddRange(new object[] {
            "English",
            "Khmer"});
            this.comboBox_village.Location = new System.Drawing.Point(266, 381);
            this.comboBox_village.Name = "comboBox_village";
            this.comboBox_village.Size = new System.Drawing.Size(357, 40);
            this.comboBox_village.TabIndex = 6;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Khaki;
            this.btn_clear.Location = new System.Drawing.Point(562, 484);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 40);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(736, 484);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 40);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(108, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(141, 26);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City/Province";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(108, 258);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(85, 26);
            this.lblDistrict.TabIndex = 10;
            this.lblDistrict.Text = "District ";
            this.lblDistrict.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVillage
            // 
            this.lblVillage.AutoSize = true;
            this.lblVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillage.Location = new System.Drawing.Point(108, 389);
            this.lblVillage.Name = "lblVillage";
            this.lblVillage.Size = new System.Drawing.Size(78, 26);
            this.lblVillage.TabIndex = 11;
            this.lblVillage.Text = "Village";
            // 
            // lblCommune
            // 
            this.lblCommune.AutoSize = true;
            this.lblCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommune.Location = new System.Drawing.Point(108, 324);
            this.lblCommune.Name = "lblCommune";
            this.lblCommune.Size = new System.Drawing.Size(120, 26);
            this.lblCommune.TabIndex = 12;
            this.lblCommune.Text = "Commune ";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(94, 569);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(703, 281);
            this.textBox_address.TabIndex = 13;
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 923);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.lblCommune);
            this.Controls.Add(this.lblVillage);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.comboBox_village);
            this.Controls.Add(this.comboBox_commune);
            this.Controls.Add(this.comboBox_district);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_lan);
            this.Controls.Add(this.lblLanguage);
            this.Name = "Exercise3";
            this.Text = "Exercise3";
            this.Load += new System.EventHandler(this.Exercise3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox comboBox_lan;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.ComboBox comboBox_district;
        private System.Windows.Forms.ComboBox comboBox_commune;
        private System.Windows.Forms.ComboBox comboBox_village;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblVillage;
        private System.Windows.Forms.Label lblCommune;
        private System.Windows.Forms.TextBox textBox_address;
    }
}