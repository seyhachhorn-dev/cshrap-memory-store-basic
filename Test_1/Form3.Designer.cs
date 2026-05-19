namespace Test_1
{
    partial class Form3
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.add_btn_action = new System.Windows.Forms.Button();
            this.student_datagridview = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_btn_action = new System.Windows.Forms.Button();
            this.seach_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.show_btn_action = new System.Windows.Forms.Button();
            this.update_action = new System.Windows.Forms.Button();
            this.delete_btn_action = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(731, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Register Student";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.Location = new System.Drawing.Point(283, 128);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(555, 34);
            this.id_textbox.TabIndex = 7;
            this.id_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(283, 203);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(555, 34);
            this.username_textbox.TabIndex = 8;
            // 
            // age_textbox
            // 
            this.age_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_textbox.Location = new System.Drawing.Point(283, 281);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(555, 34);
            this.age_textbox.TabIndex = 9;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_textbox.Location = new System.Drawing.Point(283, 361);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(555, 34);
            this.phone_textbox.TabIndex = 10;
            // 
            // add_btn_action
            // 
            this.add_btn_action.Location = new System.Drawing.Point(960, 127);
            this.add_btn_action.Name = "add_btn_action";
            this.add_btn_action.Size = new System.Drawing.Size(159, 32);
            this.add_btn_action.TabIndex = 11;
            this.add_btn_action.Text = "Add";
            this.add_btn_action.UseVisualStyleBackColor = true;
            this.add_btn_action.Click += new System.EventHandler(this.add_btn_action_Click);
            // 
            // student_datagridview
            // 
            this.student_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Age,
            this.Phone});
            this.student_datagridview.Location = new System.Drawing.Point(52, 558);
            this.student_datagridview.Name = "student_datagridview";
            this.student_datagridview.RowHeadersWidth = 62;
            this.student_datagridview.RowTemplate.Height = 28;
            this.student_datagridview.Size = new System.Drawing.Size(1364, 369);
            this.student_datagridview.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "#";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // search_btn_action
            // 
            this.search_btn_action.Location = new System.Drawing.Point(891, 502);
            this.search_btn_action.Name = "search_btn_action";
            this.search_btn_action.Size = new System.Drawing.Size(159, 32);
            this.search_btn_action.TabIndex = 13;
            this.search_btn_action.Text = "Search";
            this.search_btn_action.UseVisualStyleBackColor = true;
            this.search_btn_action.Click += new System.EventHandler(this.search_btn_action_Click);
            // 
            // seach_textbox
            // 
            this.seach_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seach_textbox.Location = new System.Drawing.Point(283, 502);
            this.seach_textbox.Name = "seach_textbox";
            this.seach_textbox.Size = new System.Drawing.Size(555, 34);
            this.seach_textbox.TabIndex = 14;
            this.seach_textbox.TextChanged += new System.EventHandler(this.seach_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Student Table";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // show_btn_action
            // 
            this.show_btn_action.Location = new System.Drawing.Point(1102, 502);
            this.show_btn_action.Name = "show_btn_action";
            this.show_btn_action.Size = new System.Drawing.Size(159, 32);
            this.show_btn_action.TabIndex = 16;
            this.show_btn_action.Text = "Show";
            this.show_btn_action.UseVisualStyleBackColor = true;
            this.show_btn_action.Click += new System.EventHandler(this.show_btn_action_Click);
            // 
            // update_action
            // 
            this.update_action.Location = new System.Drawing.Point(960, 192);
            this.update_action.Name = "update_action";
            this.update_action.Size = new System.Drawing.Size(159, 32);
            this.update_action.TabIndex = 17;
            this.update_action.Text = "Update";
            this.update_action.UseVisualStyleBackColor = true;
            this.update_action.Click += new System.EventHandler(this.update_action_Click);
            // 
            // delete_btn_action
            // 
            this.delete_btn_action.Location = new System.Drawing.Point(960, 256);
            this.delete_btn_action.Name = "delete_btn_action";
            this.delete_btn_action.Size = new System.Drawing.Size(159, 32);
            this.delete_btn_action.TabIndex = 18;
            this.delete_btn_action.Text = "Delete";
            this.delete_btn_action.UseVisualStyleBackColor = true;
            this.delete_btn_action.Click += new System.EventHandler(this.delete_btn_action_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 969);
            this.Controls.Add(this.delete_btn_action);
            this.Controls.Add(this.update_action);
            this.Controls.Add(this.show_btn_action);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seach_textbox);
            this.Controls.Add(this.search_btn_action);
            this.Controls.Add(this.student_datagridview);
            this.Controls.Add(this.add_btn_action);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Button add_btn_action;
        private System.Windows.Forms.DataGridView student_datagridview;
        private System.Windows.Forms.Button search_btn_action;
        private System.Windows.Forms.TextBox seach_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button show_btn_action;
        private System.Windows.Forms.Button update_action;
        private System.Windows.Forms.Button delete_btn_action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}