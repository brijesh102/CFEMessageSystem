namespace CenterFaculty
{
    partial class frmLogin
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
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.phoneCallButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // phoneCallButton
            // 
            this.phoneCallButton.Image = null;
            this.phoneCallButton.Location = new System.Drawing.Point(313, 254);
            this.phoneCallButton.Name = "phoneCallButton";
            this.phoneCallButton.Size = new System.Drawing.Size(357, 115);
            this.phoneCallButton.TabIndex = 0;
            this.phoneCallButton.Text = "Click to Open up the Message Book";
            this.phoneCallButton.UseSelectable = true;
            this.phoneCallButton.UseVisualStyleBackColor = true;
            this.phoneCallButton.Click += new System.EventHandler(this.phoneCallButton_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.phoneCallButton);
            this.Name = "frmLogin";
            this.Text = "Center For Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton phoneCallButton;
    }
}

