namespace CenterFaculty.Forms
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.editUserPanel = new System.Windows.Forms.Panel();
            this.btnSaveUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnSave = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnNewUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnback = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpasswordBox = new System.Windows.Forms.RichTextBox();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cFEUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.editUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFEUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtpasswordBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 520);
            this.panel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.editUserPanel);
            this.mainPanel.Controls.Add(this.btnNewUser);
            this.mainPanel.Controls.Add(this.btnback);
            this.mainPanel.Controls.Add(this.userGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 520);
            this.mainPanel.TabIndex = 3;
            // 
            // editUserPanel
            // 
            this.editUserPanel.BackColor = System.Drawing.Color.Silver;
            this.editUserPanel.Controls.Add(this.btnSaveUser);
            this.editUserPanel.Controls.Add(this.pictureBox1);
            this.editUserPanel.Controls.Add(this.btnDelete);
            this.editUserPanel.Controls.Add(this.btnSave);
            this.editUserPanel.Controls.Add(this.label5);
            this.editUserPanel.Controls.Add(this.label4);
            this.editUserPanel.Controls.Add(this.label3);
            this.editUserPanel.Controls.Add(this.label2);
            this.editUserPanel.Controls.Add(this.txtRole);
            this.editUserPanel.Controls.Add(this.txtEmail);
            this.editUserPanel.Controls.Add(this.txtLastName);
            this.editUserPanel.Controls.Add(this.txtFirstName);
            this.editUserPanel.Location = new System.Drawing.Point(268, 44);
            this.editUserPanel.Name = "editUserPanel";
            this.editUserPanel.Size = new System.Drawing.Size(416, 425);
            this.editUserPanel.TabIndex = 32;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveUser.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Image = null;
            this.btnSaveUser.Location = new System.Drawing.Point(46, 272);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(143, 57);
            this.btnSaveUser.TabIndex = 34;
            this.btnSaveUser.Text = "Save Changes";
            this.btnSaveUser.UseSelectable = true;
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = null;
            this.btnDelete.Location = new System.Drawing.Point(212, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 57);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete the Record";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(46, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 57);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // txtRole
            // 
            this.txtRole.AcceptsTab = true;
            this.txtRole.Location = new System.Drawing.Point(178, 197);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(159, 22);
            this.txtRole.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Location = new System.Drawing.Point(178, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.AcceptsTab = true;
            this.txtLastName.Location = new System.Drawing.Point(178, 111);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsTab = true;
            this.txtFirstName.Location = new System.Drawing.Point(178, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnNewUser
            // 
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewUser.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Image = null;
            this.btnNewUser.Location = new System.Drawing.Point(6, 3);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(165, 57);
            this.btnNewUser.TabIndex = 31;
            this.btnNewUser.Text = "Add a new User";
            this.btnNewUser.UseSelectable = true;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnback
            // 
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(870, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 48);
            this.btnback.TabIndex = 11;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userGridView.Location = new System.Drawing.Point(6, 66);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(954, 379);
            this.userGridView.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(255, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 65);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Passcode";
            // 
            // txtpasswordBox
            // 
            this.txtpasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordBox.Location = new System.Drawing.Point(255, 138);
            this.txtpasswordBox.MaxLength = 4;
            this.txtpasswordBox.Name = "txtpasswordBox";
            this.txtpasswordBox.Size = new System.Drawing.Size(373, 66);
            this.txtpasswordBox.TabIndex = 0;
            this.txtpasswordBox.Text = "";
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataSource = typeof(CenterFaculty.Entities.SubCategory);
            // 
            // cFEUserBindingSource
            // 
            this.cFEUserBindingSource.DataSource = typeof(CenterFaculty.Entities.CFEUser);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Name = "frmSettings";
            this.Text = "Message Book";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.editUserPanel.ResumeLayout(false);
            this.editUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFEUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        




        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtpasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.BindingSource cFEUserBindingSource;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnNewUser;
        private System.Windows.Forms.Panel editUserPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRole;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDelete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSaveUser;
    }
}