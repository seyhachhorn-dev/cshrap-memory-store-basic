namespace Test_1
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label disableLabel;
            System.Windows.Forms.Label pictureLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_Create = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.csharpDataSet = new Test_1.csharpDataSet();
            this.tbl_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_usersTableAdapter = new Test_1.csharpDataSetTableAdapters.tbl_usersTableAdapter();
            this.tableAdapterManager = new Test_1.csharpDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.disableCheckBox = new System.Windows.Forms.CheckBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            disableLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(55, 142);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new System.Drawing.Point(55, 174);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(81, 20);
            nicknameLabel.TabIndex = 5;
            nicknameLabel.Text = "nickname:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(55, 206);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(84, 20);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "username:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(55, 238);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(63, 20);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(55, 272);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(58, 20);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(55, 304);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(55, 336);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(81, 20);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "password:";
            // 
            // disableLabel
            // 
            disableLabel.AutoSize = true;
            disableLabel.Location = new System.Drawing.Point(55, 370);
            disableLabel.Name = "disableLabel";
            disableLabel.Size = new System.Drawing.Size(63, 20);
            disableLabel.TabIndex = 17;
            disableLabel.Text = "disable:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(730, 136);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(61, 20);
            pictureLabel.TabIndex = 19;
            pictureLabel.Text = "picture:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Create,
            this.toolStrip_Save,
            this.toolStrip_Delete,
            this.toolStrip_Search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStrip_Create
            // 
            this.toolStrip_Create.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Create.Image")));
            this.toolStrip_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Create.Name = "toolStrip_Create";
            this.toolStrip_Create.Size = new System.Drawing.Size(90, 29);
            this.toolStrip_Create.Text = "Create";
            this.toolStrip_Create.Click += new System.EventHandler(this.toolStrip_Create_Click);
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Save.Image")));
            this.toolStrip_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.Size = new System.Drawing.Size(77, 29);
            this.toolStrip_Save.Text = "Save";
            this.toolStrip_Save.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip_Delete
            // 
            this.toolStrip_Delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Delete.Image")));
            this.toolStrip_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Delete.Name = "toolStrip_Delete";
            this.toolStrip_Delete.Size = new System.Drawing.Size(90, 29);
            this.toolStrip_Delete.Text = "Delete";
            this.toolStrip_Delete.Click += new System.EventHandler(this.toolStrip_Delete_Click);
            // 
            // toolStrip_Search
            // 
            this.toolStrip_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStrip_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Search.Image")));
            this.toolStrip_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Search.Name = "toolStrip_Search";
            this.toolStrip_Search.Size = new System.Drawing.Size(92, 29);
            this.toolStrip_Search.Text = "Search";
            this.toolStrip_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStrip_Search.Click += new System.EventHandler(this.toolStrip_Search_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Location = new System.Drawing.Point(0, 34);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // csharpDataSet
            // 
            this.csharpDataSet.DataSetName = "csharpDataSet";
            this.csharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_usersBindingSource
            // 
            this.tbl_usersBindingSource.DataMember = "tbl_users";
            this.tbl_usersBindingSource.DataSource = this.csharpDataSet;
            // 
            // tbl_usersTableAdapter
            // 
            this.tbl_usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_usersTableAdapter = this.tbl_usersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Test_1.csharpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(145, 139);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(501, 26);
            this.idTextBox.TabIndex = 4;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "nickname", true));
            this.nicknameTextBox.Location = new System.Drawing.Point(145, 171);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(501, 26);
            this.nicknameTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(145, 203);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(501, 26);
            this.usernameTextBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(145, 235);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(501, 28);
            this.genderComboBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(145, 269);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(501, 26);
            this.phoneTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(145, 301);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(501, 26);
            this.emailTextBox.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(145, 333);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(501, 26);
            this.passwordTextBox.TabIndex = 16;
            // 
            // disableCheckBox
            // 
            this.disableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_usersBindingSource, "disable", true));
            this.disableCheckBox.Location = new System.Drawing.Point(145, 370);
            this.disableCheckBox.Name = "disableCheckBox";
            this.disableCheckBox.Size = new System.Drawing.Size(501, 24);
            this.disableCheckBox.TabIndex = 18;
            this.disableCheckBox.Text = "checkBox1";
            this.disableCheckBox.UseVisualStyleBackColor = true;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbl_usersBindingSource, "picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(809, 136);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(198, 223);
            this.picturePictureBox.TabIndex = 20;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.Click += new System.EventHandler(this.picturePictureBox_Click);
            this.picturePictureBox.DoubleClick += new System.EventHandler(this.picturePictureBox_DoubleClick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 605);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(disableLabel);
            this.Controls.Add(this.disableCheckBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_Create;
        private System.Windows.Forms.ToolStripButton toolStrip_Save;
        private System.Windows.Forms.ToolStripButton toolStrip_Delete;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStrip_Search;
        private csharpDataSet csharpDataSet;
        private System.Windows.Forms.BindingSource tbl_usersBindingSource;
        private csharpDataSetTableAdapters.tbl_usersTableAdapter tbl_usersTableAdapter;
        private csharpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox disableCheckBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
    }
}