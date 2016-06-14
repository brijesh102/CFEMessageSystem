using CenterFaculty.Controller;
using CenterFaculty.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterFaculty.Forms
{
    public partial class frmMoodle : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmCategory;
        private MetroForm frmMessage;
        private SqlServerDAO command = new SqlServerDAO();
        private MessageModel MessageFields;
        public frmMoodle(MessageModel msgModel)
        {
            InitializeComponent();
            this.MessageFields = msgModel;
        }

        private void frmMoodle_Load(object sender, EventArgs e)
        {
            var subcategories = command.GetSubCategoryRequestByCategory("Moodle");
            panel2.Visible = false;
            detailComboBox.Visible = false;
            moodleComboBox.DataSource = subcategories.Select(u => u.Description).ToList();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MessageFields.Description = string.Empty;
            MessageFields.Detail = string.Empty;
            if (frmCategory == null)
            {
                frmCategory = new frmCategory(MessageFields);
                frmCategory.FormClosed += FrmCategory_FormClosed; ;
            }
            frmCategory.StyleManager = StyleManager;
            frmCategory.Show(this);
            Hide();
        }

        private void FrmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCategory = null;
            Application.ExitThread();
        }

        private void nxtToInfoBtn_Click(object sender, EventArgs e)
        {
            string selectedMoodleQuestion = moodleComboBox.SelectedValue.ToString();
            if(selectedMoodleQuestion.Equals("Other",StringComparison.CurrentCultureIgnoreCase))
            {
                btnToMessage_Click(sender, e);
            }
            else
            {
                panel2.Visible = true;
                var details = command.GetProblemDetailBySubcategory(selectedMoodleQuestion);
                detailComboBox.DataSource = details.Select(u => u.Label).ToList();
                detailComboBox.Visible = true;
            }
            
        }

        private void btnToMoodle_Click(object sender, EventArgs e)
        {
            moodleComboBox.ResetText();
            detailComboBox.ResetText();
            detailComboBox.Visible = false;
            panel2.Visible = false;
        }

        private void btnToMessage_Click(object sender, EventArgs e)
        {
            MessageFields.Description = moodleComboBox.SelectedValue.ToString();
            if(MessageFields.Description.Equals("Other",StringComparison.CurrentCultureIgnoreCase))
            {
                MessageFields.Detail = "N/A";
            }
            else
            {
                MessageFields.Detail = detailComboBox.SelectedValue.ToString();
            }
            
            if (frmMessage == null)
            {
                frmMessage = new frmMessage(MessageFields);
                frmMessage.FormClosed += FrmMessage_FormClosed;
            }
            frmMessage.StyleManager = StyleManager;
            frmMessage.Show(this);
            Hide();
        }
        private void FrmMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMessage = null;
            Application.ExitThread();
        }
    }
}
