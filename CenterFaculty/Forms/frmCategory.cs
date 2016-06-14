using MetroFramework.Forms;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenterFaculty.Entities;
using CenterFaculty.Controller;

namespace CenterFaculty.Forms
{
    public partial class frmCategory : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmHome;
        private MetroForm frmMoodle;
        private MetroForm frmMessage;
        private MessageModel MessageFields { get; set; }
        private SqlServerDAO command = new SqlServerDAO();
        public frmCategory(MessageModel msgmodel)
        {
            InitializeComponent();
            MessageFields = msgmodel;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            subCatergoryPanel.Visible = false;
        }

        private void moodleTile_Click(object sender, EventArgs e)
        {
            MessageFields.Category = Category.Moodle;
            if (frmMoodle == null)
            {
                frmMoodle = new frmMoodle(MessageFields);
                frmMoodle.FormClosed += FrmMoodle_FormClosed; ;
            }
            frmMoodle.StyleManager = StyleManager;
            frmMoodle.Show(this);
            Hide();
        }

        private void FrmMoodle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMoodle = null;
            Application.ExitThread();
        }

        private void projectTile_Click(object sender, EventArgs e)
        {
            var subcategories = command.GetSubCategoryRequestByCategory("Project");
            subCatergoryPanel.Visible = true;
            subcategoryComboBox.DataSource = subcategories.Select(u => u.Description).ToList();
            MessageFields.Category = Category.Project;
        }

        private void nxtToInfoBtn_Click(object sender, EventArgs e)
        {
            if(MessageFields.Category != Category.Other)
            {
                MessageFields.Description = subcategoryComboBox.SelectedValue.ToString();
                MessageFields.Detail = "N/A";
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

        private void posterTile_Click(object sender, EventArgs e)
        {
            var subcategories = command.GetSubCategoryRequestByCategory("Poster");
            subCatergoryPanel.Visible = true;
            subcategoryComboBox.DataSource = subcategories.Select(u => u.Description).ToList();
            MessageFields.Category = Category.Posters;
        }

        private void otherTile_Click(object sender, EventArgs e)
        {
            MessageFields.Category = Category.Other;
            nxtToInfoBtn_Click(sender, e);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            subcategoryComboBox.ResetText();
            subCatergoryPanel.Visible = false;
        }
        

        private void subcategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmHome == null)
            {
                frmHome = new frmHome();
                frmHome.FormClosed += FrmHome_FormClosed; ; ; ;
            }
            frmHome.StyleManager = StyleManager;
            frmHome.Show(this);
            Hide();
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome = null;
            Application.ExitThread();
        }
    }
}
