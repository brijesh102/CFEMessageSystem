using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using CenterFaculty.Entities;

namespace CenterFaculty.Forms
{
    public partial class frmHome : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmCategory;
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
            
        }

        private void settingTile_Click(object sender, EventArgs e)
        {
            
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
    }
}
