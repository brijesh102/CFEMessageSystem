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
            this.editPasscodePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdminNew = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminCurrent = new MetroFramework.Controls.MetroTextBox();
            this.txtUserNew = new MetroFramework.Controls.MetroTextBox();
            this.txtUserCurrent = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnSavePasscode = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
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
            this.changePasscode = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnNewUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnback = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpasswordBox = new System.Windows.Forms.RichTextBox();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cFEUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.editPasscodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.btnBackHome);
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
            this.mainPanel.Controls.Add(this.editPasscodePanel);
            this.mainPanel.Controls.Add(this.editUserPanel);
            this.mainPanel.Controls.Add(this.changePasscode);
            this.mainPanel.Controls.Add(this.btnNewUser);
            this.mainPanel.Controls.Add(this.btnback);
            this.mainPanel.Controls.Add(this.userGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 520);
            this.mainPanel.TabIndex = 3;
            // 
            // editPasscodePanel
            // 
            this.editPasscodePanel.BackColor = System.Drawing.Color.Silver;
            this.editPasscodePanel.Controls.Add(this.label11);
            this.editPasscodePanel.Controls.Add(this.label8);
            this.editPasscodePanel.Controls.Add(this.label10);
            this.editPasscodePanel.Controls.Add(this.label9);
            this.editPasscodePanel.Controls.Add(this.label7);
            this.editPasscodePanel.Controls.Add(this.txtAdminNew);
            this.editPasscodePanel.Controls.Add(this.label6);
            this.editPasscodePanel.Controls.Add(this.txtAdminCurrent);
            this.editPasscodePanel.Controls.Add(this.txtUserNew);
            this.editPasscodePanel.Controls.Add(this.txtUserCurrent);
            this.editPasscodePanel.Controls.Add(this.pictureBox2);
            this.editPasscodePanel.Controls.Add(this.btnCancel);
            this.editPasscodePanel.Controls.Add(this.btnSavePasscode);
            this.editPasscodePanel.Location = new System.Drawing.Point(6, 66);
            this.editPasscodePanel.Name = "editPasscodePanel";
            this.editPasscodePanel.Size = new System.Drawing.Size(416, 425);
            this.editPasscodePanel.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "New";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "New";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Present";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Admin Passcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Present";
            // 
            // txtAdminNew
            // 
            // 
            // 
            // 
            this.txtAdminNew.CustomButton.Image = null;
            this.txtAdminNew.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAdminNew.CustomButton.Name = "";
            this.txtAdminNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminNew.CustomButton.TabIndex = 1;
            this.txtAdminNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminNew.CustomButton.UseSelectable = true;
            this.txtAdminNew.CustomButton.Visible = false;
            this.txtAdminNew.Lines = new string[0];
            this.txtAdminNew.Location = new System.Drawing.Point(233, 222);
            this.txtAdminNew.MaxLength = 32767;
            this.txtAdminNew.Name = "txtAdminNew";
            this.txtAdminNew.PasswordChar = '\0';
            this.txtAdminNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminNew.SelectedText = "";
            this.txtAdminNew.SelectionLength = 0;
            this.txtAdminNew.SelectionStart = 0;
            this.txtAdminNew.Size = new System.Drawing.Size(125, 23);
            this.txtAdminNew.TabIndex = 34;
            this.txtAdminNew.UseSelectable = true;
            this.txtAdminNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "User Passcode";
            // 
            // txtAdminCurrent
            // 
            // 
            // 
            // 
            this.txtAdminCurrent.CustomButton.Image = null;
            this.txtAdminCurrent.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAdminCurrent.CustomButton.Name = "";
            this.txtAdminCurrent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminCurrent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminCurrent.CustomButton.TabIndex = 1;
            this.txtAdminCurrent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminCurrent.CustomButton.UseSelectable = true;
            this.txtAdminCurrent.CustomButton.Visible = false;
            this.txtAdminCurrent.Enabled = false;
            this.txtAdminCurrent.Lines = new string[0];
            this.txtAdminCurrent.Location = new System.Drawing.Point(47, 222);
            this.txtAdminCurrent.MaxLength = 32767;
            this.txtAdminCurrent.Name = "txtAdminCurrent";
            this.txtAdminCurrent.PasswordChar = '\0';
            this.txtAdminCurrent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminCurrent.SelectedText = "";
            this.txtAdminCurrent.SelectionLength = 0;
            this.txtAdminCurrent.SelectionStart = 0;
            this.txtAdminCurrent.Size = new System.Drawing.Size(125, 23);
            this.txtAdminCurrent.TabIndex = 34;
            this.txtAdminCurrent.UseSelectable = true;
            this.txtAdminCurrent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminCurrent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserNew
            // 
            // 
            // 
            // 
            this.txtUserNew.CustomButton.Image = null;
            this.txtUserNew.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtUserNew.CustomButton.Name = "";
            this.txtUserNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserNew.CustomButton.TabIndex = 1;
            this.txtUserNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserNew.CustomButton.UseSelectable = true;
            this.txtUserNew.CustomButton.Visible = false;
            this.txtUserNew.Lines = new string[0];
            this.txtUserNew.Location = new System.Drawing.Point(233, 109);
            this.txtUserNew.MaxLength = 32767;
            this.txtUserNew.Name = "txtUserNew";
            this.txtUserNew.PasswordChar = '\0';
            this.txtUserNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserNew.SelectedText = "";
            this.txtUserNew.SelectionLength = 0;
            this.txtUserNew.SelectionStart = 0;
            this.txtUserNew.Size = new System.Drawing.Size(125, 23);
            this.txtUserNew.TabIndex = 34;
            this.txtUserNew.UseSelectable = true;
            this.txtUserNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserCurrent
            // 
            // 
            // 
            // 
            this.txtUserCurrent.CustomButton.Image = null;
            this.txtUserCurrent.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtUserCurrent.CustomButton.Name = "";
            this.txtUserCurrent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserCurrent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserCurrent.CustomButton.TabIndex = 1;
            this.txtUserCurrent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserCurrent.CustomButton.UseSelectable = true;
            this.txtUserCurrent.CustomButton.Visible = false;
            this.txtUserCurrent.Enabled = false;
            this.txtUserCurrent.Lines = new string[0];
            this.txtUserCurrent.Location = new System.Drawing.Point(47, 111);
            this.txtUserCurrent.MaxLength = 32767;
            this.txtUserCurrent.Name = "txtUserCurrent";
            this.txtUserCurrent.PasswordChar = '\0';
            this.txtUserCurrent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserCurrent.SelectedText = "";
            this.txtUserCurrent.SelectionLength = 0;
            this.txtUserCurrent.SelectionStart = 0;
            this.txtUserCurrent.Size = new System.Drawing.Size(125, 23);
            this.txtUserCurrent.TabIndex = 34;
            this.txtUserCurrent.UseSelectable = true;
            this.txtUserCurrent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserCurrent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = null;
            this.btnCancel.Location = new System.Drawing.Point(212, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 57);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSavePasscode
            // 
            this.btnSavePasscode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePasscode.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePasscode.Image = null;
            this.btnSavePasscode.Location = new System.Drawing.Point(46, 272);
            this.btnSavePasscode.Name = "btnSavePasscode";
            this.btnSavePasscode.Size = new System.Drawing.Size(143, 57);
            this.btnSavePasscode.TabIndex = 32;
            this.btnSavePasscode.Text = "Save Changes";
            this.btnSavePasscode.UseSelectable = true;
            this.btnSavePasscode.UseVisualStyleBackColor = true;
            this.btnSavePasscode.Click += new System.EventHandler(this.btnSavePasscode_Click);
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
            // changePasscode
            // 
            this.changePasscode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changePasscode.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasscode.Image = null;
            this.changePasscode.Location = new System.Drawing.Point(177, 3);
            this.changePasscode.Name = "changePasscode";
            this.changePasscode.Size = new System.Drawing.Size(165, 57);
            this.changePasscode.TabIndex = 33;
            this.changePasscode.Text = "Change the Passcode";
            this.changePasscode.UseSelectable = true;
            this.changePasscode.UseVisualStyleBackColor = true;
            this.changePasscode.Click += new System.EventHandler(this.changePasscode_Click);
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
            // btnBackHome
            // 
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBackHome.Location = new System.Drawing.Point(447, 231);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(186, 65);
            this.btnBackHome.TabIndex = 2;
            this.btnBackHome.Text = "Cancel";
            this.btnBackHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
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
            this.editPasscodePanel.ResumeLayout(false);
            this.editPasscodePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel editPasscodePanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtAdminNew;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtAdminCurrent;
        private MetroFramework.Controls.MetroTextBox txtUserNew;
        private MetroFramework.Controls.MetroTextBox txtUserCurrent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnCancel;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSavePasscode;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton changePasscode;
        private System.Windows.Forms.Button btnBackHome;
    }
}