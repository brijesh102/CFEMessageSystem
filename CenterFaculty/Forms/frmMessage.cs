using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenterFaculty.Entities;

namespace CenterFaculty.Forms
{
    public partial class frmMessage : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmCategory;
        private MetroForm frmInfo;
        private MessageModel MessageFields;
        public frmMessage(MessageModel msgModel)
        {
            InitializeComponent();
            MessageFields = msgModel;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MessageFields.MessageBox = string.Empty;
            if(frmCategory == null)
            {
                frmCategory = new frmCategory(MessageFields);
                frmCategory.FormClosed += FrmCategory_FormClosed;
            }
            frmCategory.StyleManager = StyleManager;
            frmCategory.Show();
            Hide();
        }

        private void FrmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCategory = null;
            Application.ExitThread();
        }

        private void nxtToInfo_Click(object sender, EventArgs e)
        {
            MessageFields.MessageBox = messageBox.Text;
            if (frmInfo == null)
            {
                frmInfo = new frmInfo(MessageFields);
                frmInfo.FormClosed += FrmInfo_FormClosed;
            }
            frmInfo.StyleManager = StyleManager;
            frmInfo.Show(this);
            Hide();
        }
        private void FrmInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmInfo = null;
            Application.ExitThread();
        }
    }
}
