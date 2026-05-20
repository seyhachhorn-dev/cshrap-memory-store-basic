namespace Test_1
{
    partial class PictureBoxForm
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
            this.pf_picturebox = new System.Windows.Forms.PictureBox();
            this.btn_upload_action = new System.Windows.Forms.Button();
            this.textBox_ImageLocationUpload = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pf_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pf_picturebox
            // 
            this.pf_picturebox.Location = new System.Drawing.Point(264, 134);
            this.pf_picturebox.Name = "pf_picturebox";
            this.pf_picturebox.Size = new System.Drawing.Size(262, 275);
            this.pf_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pf_picturebox.TabIndex = 0;
            this.pf_picturebox.TabStop = false;
            this.pf_picturebox.Click += new System.EventHandler(this.pf_picturebox_Click);
            // 
            // btn_upload_action
            // 
            this.btn_upload_action.Location = new System.Drawing.Point(340, 445);
            this.btn_upload_action.Name = "btn_upload_action";
            this.btn_upload_action.Size = new System.Drawing.Size(115, 35);
            this.btn_upload_action.TabIndex = 1;
            this.btn_upload_action.Text = "Upload";
            this.btn_upload_action.UseVisualStyleBackColor = true;
            this.btn_upload_action.Click += new System.EventHandler(this.btn_upload_action_Click);
            // 
            // textBox_ImageLocationUpload
            // 
            this.textBox_ImageLocationUpload.Location = new System.Drawing.Point(204, 76);
            this.textBox_ImageLocationUpload.Name = "textBox_ImageLocationUpload";
            this.textBox_ImageLocationUpload.Size = new System.Drawing.Size(386, 26);
            this.textBox_ImageLocationUpload.TabIndex = 3;
            this.textBox_ImageLocationUpload.TextChanged += new System.EventHandler(this.textBox_ImageLocationUpload_TextChanged);
            this.textBox_ImageLocationUpload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ImageLocationUpload_KeyDown);
            // 
            // PictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.textBox_ImageLocationUpload);
            this.Controls.Add(this.btn_upload_action);
            this.Controls.Add(this.pf_picturebox);
            this.Name = "PictureBoxForm";
            this.Text = "PictureBoxForm";
            this.Load += new System.EventHandler(this.PictureBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pf_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pf_picturebox;
        private System.Windows.Forms.Button btn_upload_action;
        private System.Windows.Forms.TextBox textBox_ImageLocationUpload;
    }
}