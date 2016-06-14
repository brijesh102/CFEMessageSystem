using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using CenterFaculty.Entities;

namespace CenterFaculty.Forms
{
    public partial class frmHome : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmSettings;
        private MetroForm frmCategory;
        private MetroForm frmHistory;
        private MessageModel MessageFields = new MessageModel();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            typePanel.Visible = false;
        }


        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCategory = null;
            Application.ExitThread();
        }

        private void messageTile_Click(object sender, EventArgs e)
        {
            typePanel.Visible = true;
        }

        private void historyTile_Click(object sender, EventArgs e)
        {
            if (frmHistory == null)
            {
                frmHistory = new frmHistory();
                frmHistory.FormClosed += FrmHistory_FormClosed;
            }
            frmHistory.StyleManager = StyleManager;
            frmHistory.Show(this);
            Hide();
        }

        private void FrmHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHistory = null;
            Application.ExitThread();
        }

        private void settingTile_Click(object sender, EventArgs e)
        {
            if (frmSettings == null)
            {
                frmSettings = new frmSettings();
                frmSettings.FormClosed += FrmSettings_FormClosed;
            }
            frmSettings.StyleManager = StyleManager;
            frmSettings.Show(this);
            Hide();
        }

        private void FrmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings = null;
            Application.ExitThread();
        }

        private void walkinTile_Click(object sender, EventArgs e)
        {
            MessageFields.Type = Entities.Type.WalkIn;
            CallFormCategory();
        }

        private void callTile_Click(object sender, EventArgs e)
        {
            MessageFields.Type = Entities.Type.Call;
            CallFormCategory();
        }

        private void CallFormCategory()
        {
            if (frmCategory == null)
            {
                frmCategory = new frmCategory(MessageFields);
                frmCategory.FormClosed += FrmMain_FormClosed; ;
            }
            frmCategory.StyleManager = StyleManager;
            frmCategory.Show(this);
            Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            typePanel.Visible = false;
            
        }
    }
}
