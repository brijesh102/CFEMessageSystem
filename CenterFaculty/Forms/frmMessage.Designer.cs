namespace CenterFaculty.Forms
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.messagePanel = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nxtToInfo = new MetroFramework.Controls.MetroButton();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.backbtn);
            this.messagePanel.Controls.Add(this.label2);
            this.messagePanel.Controls.Add(this.nxtToInfo);
            this.messagePanel.Controls.Add(this.messageBox);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(20, 60);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(960, 520);
            this.messagePanel.TabIndex = 12;
            // 
            // backbtn
            // 
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(758, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(87, 48);
            this.backbtn.TabIndex = 12;
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message:";
            // 
            // nxtToInfo
            // 
            this.nxtToInfo.Location = new System.Drawing.Point(640, 358);
            this.nxtToInfo.Margin = new System.Windows.Forms.Padding(4);
            this.nxtToInfo.Name = "nxtToInfo";
            this.nxtToInfo.Size = new System.Drawing.Size(205, 52);
            this.nxtToInfo.TabIndex = 10;
            this.nxtToInfo.Text = "Next";
            this.nxtToInfo.UseSelectable = true;
            this.nxtToInfo.Click += new System.EventHandler(this.nxtToInfo_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(78, 72);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(564, 279);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "";
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.messagePanel);
            this.Name = "frmMessage";
            this.Text = "Message Book";
            this.Load += new System.EventHandler(this.MessageBox_Load);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton nxtToInfo;
        private System.Windows.Forms.RichTextBox messageBox;
    }
}