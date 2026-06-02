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
            this.lbl_language = new System.Windows.Forms.Label();
            this.comboBox_lan = new System.Windows.Forms.ComboBox();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.comboBox_district = new System.Windows.Forms.ComboBox();
            this.comboBox_commune = new System.Windows.Forms.ComboBox();
            this.comboBox_village = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.Location = new System.Drawing.Point(583, 47);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(108, 26);
            this.lbl_language.TabIndex = 0;
            this.lbl_language.Text = "Language";
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
            this.btn_clear.Location = new System.Drawing.Point(562, 484);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 29);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(736, 484);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 29);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "City/Province";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "District ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Village";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Commune ";
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 923);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.comboBox_village);
            this.Controls.Add(this.comboBox_commune);
            this.Controls.Add(this.comboBox_district);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_lan);
            this.Controls.Add(this.lbl_language);
            this.Name = "Exercise3";
            this.Text = "Exercise3";
            this.Load += new System.EventHandler(this.Exercise3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox comboBox_lan;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.ComboBox comboBox_district;
        private System.Windows.Forms.ComboBox comboBox_commune;
        private System.Windows.Forms.ComboBox comboBox_village;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}