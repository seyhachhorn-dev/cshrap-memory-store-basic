namespace Test_1
{
    partial class frmRandomImage
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
            this.pf_pictureBox = new System.Windows.Forms.PictureBox();
            this.randomTitle_lb = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pf_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pf_pictureBox
            // 
            this.pf_pictureBox.Location = new System.Drawing.Point(200, 197);
            this.pf_pictureBox.Name = "pf_pictureBox";
            this.pf_pictureBox.Size = new System.Drawing.Size(258, 300);
            this.pf_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pf_pictureBox.TabIndex = 2;
            this.pf_pictureBox.TabStop = false;
            // 
            // randomTitle_lb
            // 
            this.randomTitle_lb.AutoSize = true;
            this.randomTitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomTitle_lb.Location = new System.Drawing.Point(262, 109);
            this.randomTitle_lb.Name = "randomTitle_lb";
            this.randomTitle_lb.Size = new System.Drawing.Size(121, 32);
            this.randomTitle_lb.TabIndex = 3;
            this.randomTitle_lb.Text = "Random";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(247, 524);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(170, 35);
            this.buttonRandom.TabIndex = 4;
            this.buttonRandom.Text = "Stop";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // frmRandomImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 676);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.randomTitle_lb);
            this.Controls.Add(this.pf_pictureBox);
            this.Name = "frmRandomImage";
            this.Text = "frmRandomImage";
            this.Load += new System.EventHandler(this.frmRandomImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pf_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pf_pictureBox;
        private System.Windows.Forms.Label randomTitle_lb;
        private System.Windows.Forms.Button buttonRandom;
    }
}