namespace CenterFaculty.Forms
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.subCatergoryPanel = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.nxtToInfoBtn = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.subcategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.projectTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.otherTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.posterTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.moodleTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.categoryPanel.SuspendLayout();
            this.subCatergoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.subCatergoryPanel);
            this.categoryPanel.Controls.Add(this.projectTile);
            this.categoryPanel.Controls.Add(this.otherTile);
            this.categoryPanel.Controls.Add(this.posterTile);
            this.categoryPanel.Controls.Add(this.moodleTile);
            this.categoryPanel.Controls.Add(this.button1);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPanel.Location = new System.Drawing.Point(20, 60);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(960, 520);
            this.categoryPanel.TabIndex = 0;
            // 
            // subCatergoryPanel
            // 
            this.subCatergoryPanel.Controls.Add(this.btnback);
            this.subCatergoryPanel.Controls.Add(this.nxtToInfoBtn);
            this.subCatergoryPanel.Controls.Add(this.label1);
            this.subCatergoryPanel.Controls.Add(this.subcategoryComboBox);
            this.subCatergoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCatergoryPanel.Location = new System.Drawing.Point(0, 0);
            this.subCatergoryPanel.Name = "subCatergoryPanel";
            this.subCatergoryPanel.Size = new System.Drawing.Size(960, 520);
            this.subCatergoryPanel.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(758, 72);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 48);
            this.btnback.TabIndex = 10;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // nxtToInfoBtn
            // 
            this.nxtToInfoBtn.Location = new System.Drawing.Point(640, 358);
            this.nxtToInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nxtToInfoBtn.Name = "nxtToInfoBtn";
            this.nxtToInfoBtn.Size = new System.Drawing.Size(205, 52);
            this.nxtToInfoBtn.TabIndex = 9;
            this.nxtToInfoBtn.Text = "Next";
            this.nxtToInfoBtn.UseSelectable = true;
            this.nxtToInfoBtn.Click += new System.EventHandler(this.nxtToInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 93);
            this.label1.TabIndex = 7;
            this.label1.Text = "What\'s the problem?";
            // 
            // subcategoryComboBox
            // 
            this.subcategoryComboBox.FormattingEnabled = true;
            this.subcategoryComboBox.ItemHeight = 24;
            this.subcategoryComboBox.Location = new System.Drawing.Point(78, 206);
            this.subcategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subcategoryComboBox.Name = "subcategoryComboBox";
            this.subcategoryComboBox.PromptText = "Prompted ComboBox";
            this.subcategoryComboBox.Size = new System.Drawing.Size(767, 30);
            this.subcategoryComboBox.TabIndex = 6;
            this.subcategoryComboBox.UseSelectable = true;
            this.subcategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.subcategoryComboBox_SelectedIndexChanged);
            // 
            // projectTile
            // 
            this.projectTile.Image = null;
            this.projectTile.Location = new System.Drawing.Point(572, 72);
            this.projectTile.Name = "projectTile";
            this.projectTile.Size = new System.Drawing.Size(273, 146);
            this.projectTile.TabIndex = 1;
            this.projectTile.Text = "Projects";
            this.projectTile.UseSelectable = true;
            this.projectTile.UseVisualStyleBackColor = true;
            this.projectTile.Click += new System.EventHandler(this.projectTile_Click);
            // 
            // otherTile
            // 
            this.otherTile.Image = null;
            this.otherTile.Location = new System.Drawing.Point(572, 264);
            this.otherTile.Name = "otherTile";
            this.otherTile.Size = new System.Drawing.Size(273, 146);
            this.otherTile.TabIndex = 1;
            this.otherTile.Text = "Others";
            this.otherTile.UseSelectable = true;
            this.otherTile.UseVisualStyleBackColor = true;
            this.otherTile.Click += new System.EventHandler(this.otherTile_Click);
            // 
            // posterTile
            // 
            this.posterTile.Image = null;
            this.posterTile.Location = new System.Drawing.Point(78, 264);
            this.posterTile.Name = "posterTile";
            this.posterTile.Size = new System.Drawing.Size(273, 146);
            this.posterTile.TabIndex = 1;
            this.posterTile.Text = "Posters";
            this.posterTile.UseSelectable = true;
            this.posterTile.UseVisualStyleBackColor = true;
            this.posterTile.Click += new System.EventHandler(this.posterTile_Click);
            // 
            // moodleTile
            // 
            this.moodleTile.Image = null;
            this.moodleTile.Location = new System.Drawing.Point(78, 72);
            this.moodleTile.Name = "moodleTile";
            this.moodleTile.Size = new System.Drawing.Size(273, 146);
            this.moodleTile.TabIndex = 1;
            this.moodleTile.Text = "Moodle";
            this.moodleTile.UseSelectable = true;
            this.moodleTile.UseVisualStyleBackColor = true;
            this.moodleTile.Click += new System.EventHandler(this.moodleTile_Click);
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataSource = typeof(CenterFaculty.Entities.SubCategory);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(870, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 48);
            this.button1.TabIndex = 11;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.categoryPanel);
            this.Name = "frmCategory";
            this.Text = "CATEGORIES";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.categoryPanel.ResumeLayout(false);
            this.subCatergoryPanel.ResumeLayout(false);
            this.subCatergoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel categoryPanel;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton moodleTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton projectTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton otherTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton posterTile;
        private System.Windows.Forms.Panel subCatergoryPanel;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private MetroFramework.Controls.MetroComboBox subcategoryComboBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton nxtToInfoBtn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button1;
    }
}