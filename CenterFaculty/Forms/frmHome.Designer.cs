namespace CenterFaculty.Forms
{
    partial class frmHome
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
            this.settingTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.historyTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.messageTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.typePanel = new System.Windows.Forms.Panel();
            this.walkinTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.callTile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.typePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTile
            // 
            this.settingTile.AutoSize = true;
            this.settingTile.Image = null;
            this.settingTile.Location = new System.Drawing.Point(511, 307);
            this.settingTile.Name = "settingTile";
            this.settingTile.Size = new System.Drawing.Size(273, 238);
            this.settingTile.TabIndex = 11;
            this.settingTile.Text = "Settings";
            this.settingTile.UseSelectable = true;
            this.settingTile.UseVisualStyleBackColor = true;
            this.settingTile.Click += new System.EventHandler(this.settingTile_Click);
            // 
            // historyTile
            // 
            this.historyTile.AutoSize = true;
            this.historyTile.Image = null;
            this.historyTile.Location = new System.Drawing.Point(232, 307);
            this.historyTile.Name = "historyTile";
            this.historyTile.Size = new System.Drawing.Size(273, 238);
            this.historyTile.TabIndex = 10;
            this.historyTile.Text = "History";
            this.historyTile.UseSelectable = true;
            this.historyTile.UseVisualStyleBackColor = true;
            this.historyTile.Click += new System.EventHandler(this.historyTile_Click);
            // 
            // messageTile
            // 
            this.messageTile.AutoSize = true;
            this.messageTile.Image = null;
            this.messageTile.Location = new System.Drawing.Point(232, 63);
            this.messageTile.Name = "messageTile";
            this.messageTile.Size = new System.Drawing.Size(552, 238);
            this.messageTile.TabIndex = 9;
            this.messageTile.Text = "Send a Message";
            this.messageTile.UseSelectable = true;
            this.messageTile.UseVisualStyleBackColor = true;
            this.messageTile.Click += new System.EventHandler(this.messageTile_Click);
            // 
            // typePanel
            // 
            this.typePanel.Controls.Add(this.walkinTile);
            this.typePanel.Controls.Add(this.callTile);
            this.typePanel.Location = new System.Drawing.Point(20, 60);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(960, 520);
            this.typePanel.TabIndex = 12;
            // 
            // walkinTile
            // 
            this.walkinTile.Image = null;
            this.walkinTile.Location = new System.Drawing.Point(212, 164);
            this.walkinTile.Name = "walkinTile";
            this.walkinTile.Size = new System.Drawing.Size(273, 146);
            this.walkinTile.TabIndex = 0;
            this.walkinTile.Text = "WALK IN";
            this.walkinTile.UseSelectable = true;
            this.walkinTile.UseVisualStyleBackColor = true;
            this.walkinTile.Click += new System.EventHandler(this.walkinTile_Click);
            // 
            // callTile
            // 
            this.callTile.Image = null;
            this.callTile.Location = new System.Drawing.Point(491, 164);
            this.callTile.Name = "callTile";
            this.callTile.Size = new System.Drawing.Size(273, 146);
            this.callTile.TabIndex = 0;
            this.callTile.Text = "Call";
            this.callTile.UseSelectable = true;
            this.callTile.UseVisualStyleBackColor = true;
            this.callTile.Click += new System.EventHandler(this.callTile_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.typePanel);
            this.Controls.Add(this.settingTile);
            this.Controls.Add(this.historyTile);
            this.Controls.Add(this.messageTile);
            this.Name = "frmHome";
            this.Text = "Message Book";
            this.Load += new System.EventHandler(this.frmForm_Load);
            this.typePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton settingTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton historyTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton messageTile;
        private System.Windows.Forms.Panel typePanel;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton callTile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton walkinTile;
    }
}