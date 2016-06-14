namespace CenterFaculty.Forms
{
    partial class frmMoodle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoodle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToMoodle = new System.Windows.Forms.Button();
            this.btnToMessage = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.detailComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.nxtToInfoBtn = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.moodleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.nxtToInfoBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.moodleComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToMoodle);
            this.panel2.Controls.Add(this.btnToMessage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.detailComboBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 520);
            this.panel2.TabIndex = 15;
            // 
            // btnToMoodle
            // 
            this.btnToMoodle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToMoodle.Image = ((System.Drawing.Image)(resources.GetObject("btnToMoodle.Image")));
            this.btnToMoodle.Location = new System.Drawing.Point(785, 91);
            this.btnToMoodle.Name = "btnToMoodle";
            this.btnToMoodle.Size = new System.Drawing.Size(87, 48);
            this.btnToMoodle.TabIndex = 14;
            this.btnToMoodle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnToMoodle.UseVisualStyleBackColor = true;
            this.btnToMoodle.Click += new System.EventHandler(this.btnToMoodle_Click);
            // 
            // btnToMessage
            // 
            this.btnToMessage.Location = new System.Drawing.Point(667, 377);
            this.btnToMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnToMessage.Name = "btnToMessage";
            this.btnToMessage.Size = new System.Drawing.Size(205, 52);
            this.btnToMessage.TabIndex = 13;
            this.btnToMessage.Text = "Next";
            this.btnToMessage.UseSelectable = true;
            this.btnToMessage.Click += new System.EventHandler(this.btnToMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 93);
            this.label2.TabIndex = 12;
            this.label2.Text = "More Detail:";
            // 
            // detailComboBox
            // 
            this.detailComboBox.FormattingEnabled = true;
            this.detailComboBox.ItemHeight = 24;
            this.detailComboBox.Location = new System.Drawing.Point(105, 225);
            this.detailComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailComboBox.Name = "detailComboBox";
            this.detailComboBox.PromptText = "Prompted ComboBox";
            this.detailComboBox.Size = new System.Drawing.Size(767, 30);
            this.detailComboBox.TabIndex = 11;
            this.detailComboBox.UseSelectable = true;
            // 
            // btnback
            // 
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(785, 91);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 48);
            this.btnback.TabIndex = 14;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // nxtToInfoBtn
            // 
            this.nxtToInfoBtn.Location = new System.Drawing.Point(667, 377);
            this.nxtToInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nxtToInfoBtn.Name = "nxtToInfoBtn";
            this.nxtToInfoBtn.Size = new System.Drawing.Size(205, 52);
            this.nxtToInfoBtn.TabIndex = 13;
            this.nxtToInfoBtn.Text = "Next";
            this.nxtToInfoBtn.UseSelectable = true;
            this.nxtToInfoBtn.Click += new System.EventHandler(this.nxtToInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 93);
            this.label1.TabIndex = 12;
            this.label1.Text = "What\'s the problem?";
            // 
            // moodleComboBox
            // 
            this.moodleComboBox.FormattingEnabled = true;
            this.moodleComboBox.ItemHeight = 24;
            this.moodleComboBox.Location = new System.Drawing.Point(105, 225);
            this.moodleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.moodleComboBox.Name = "moodleComboBox";
            this.moodleComboBox.PromptText = "Prompted ComboBox";
            this.moodleComboBox.Size = new System.Drawing.Size(767, 30);
            this.moodleComboBox.TabIndex = 11;
            this.moodleComboBox.UseSelectable = true;
            // 
            // frmMoodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Name = "frmMoodle";
            this.Text = "Message Book";
            this.Load += new System.EventHandler(this.frmMoodle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private MetroFramework.Controls.MetroButton nxtToInfoBtn;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox moodleComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToMoodle;
        private MetroFramework.Controls.MetroButton btnToMessage;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox detailComboBox;
    }
}