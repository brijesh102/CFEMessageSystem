namespace CenterFaculty.Forms
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.messageGridView = new System.Windows.Forms.DataGridView();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageGridView
            // 
            this.messageGridView.AllowUserToAddRows = false;
            this.messageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGridView.Location = new System.Drawing.Point(20, 139);
            this.messageGridView.Name = "messageGridView";
            this.messageGridView.ReadOnly = true;
            this.messageGridView.RowTemplate.Height = 24;
            this.messageGridView.Size = new System.Drawing.Size(960, 441);
            this.messageGridView.TabIndex = 0;
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataSource = typeof(CenterFaculty.Entities.SubCategory);
            // 
            // btnback
            // 
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(893, 63);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 48);
            this.btnback.TabIndex = 11;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.messageGridView);
            this.Name = "frmHistory";
            this.Text = "Message Book";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView messageGridView;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private System.Windows.Forms.Button btnback;
    }
}