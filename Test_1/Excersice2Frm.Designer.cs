namespace Test_1
{
    partial class Excersice2Frm
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
            this.imgUpload_textBox = new System.Windows.Forms.TextBox();
            this.pf_pictureBox = new System.Windows.Forms.PictureBox();
            this.add_btn_action = new System.Windows.Forms.Button();
            this.imageUser_gridView = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pf_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUpload_textBox
            // 
            this.imgUpload_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgUpload_textBox.Location = new System.Drawing.Point(141, 98);
            this.imgUpload_textBox.Name = "imgUpload_textBox";
            this.imgUpload_textBox.Size = new System.Drawing.Size(498, 34);
            this.imgUpload_textBox.TabIndex = 0;
            // 
            // pf_pictureBox
            // 
            this.pf_pictureBox.Location = new System.Drawing.Point(1115, 324);
            this.pf_pictureBox.Name = "pf_pictureBox";
            this.pf_pictureBox.Size = new System.Drawing.Size(258, 300);
            this.pf_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pf_pictureBox.TabIndex = 1;
            this.pf_pictureBox.TabStop = false;
            this.pf_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_btn_action
            // 
            this.add_btn_action.Location = new System.Drawing.Point(704, 98);
            this.add_btn_action.Name = "add_btn_action";
            this.add_btn_action.Size = new System.Drawing.Size(112, 39);
            this.add_btn_action.TabIndex = 2;
            this.add_btn_action.Text = "Add";
            this.add_btn_action.UseVisualStyleBackColor = true;
            this.add_btn_action.Click += new System.EventHandler(this.add_btn_action_Click);
            // 
            // imageUser_gridView
            // 
            this.imageUser_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageUser_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image});
            this.imageUser_gridView.Location = new System.Drawing.Point(35, 251);
            this.imageUser_gridView.Name = "imageUser_gridView";
            this.imageUser_gridView.RowHeadersWidth = 62;
            this.imageUser_gridView.RowTemplate.Height = 28;
            this.imageUser_gridView.Size = new System.Drawing.Size(986, 541);
            this.imageUser_gridView.TabIndex = 3;
            this.imageUser_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imageUser_gridView_CellContentClick);
            this.imageUser_gridView.SelectionChanged += new System.EventHandler(this.imageUser_gridView_SelectionChanged);
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 8;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 90;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1202, 267);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 34);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Excersice2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 834);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.imageUser_gridView);
            this.Controls.Add(this.add_btn_action);
            this.Controls.Add(this.pf_pictureBox);
            this.Controls.Add(this.imgUpload_textBox);
            this.Name = "Excersice2Frm";
            this.Text = "Excersice2Frm";
            this.Load += new System.EventHandler(this.Excersice2Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pf_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imgUpload_textBox;
        private System.Windows.Forms.PictureBox pf_pictureBox;
        private System.Windows.Forms.Button add_btn_action;
        private System.Windows.Forms.DataGridView imageUser_gridView;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.Button btnShow;
    }
}