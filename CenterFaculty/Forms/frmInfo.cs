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
using CenterFaculty.Controller;
using MetroFramework;
using CenterFaculty.Entities;

namespace CenterFaculty.Forms
{
    public partial class frmInfo : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmEmail;
        private MetroForm frmCategory;
        private SqlServerDAO command = new SqlServerDAO();
        private int currentTab = 0;
        private MessageModel MessageFields;
        public frmInfo(MessageModel msgModel)
        {
            InitializeComponent();
            MessageFields = msgModel;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            fnameInput.Focus();
            fnameInput.GotFocus += FnameInput_GotFocus;
            fnameInput.LostFocus += FnameInput_LostFocus;

            lnameInput.GotFocus += LnameInput_GotFocus;
            lnameInput.LostFocus += LnameInput_LostFocus;
            metroTabPage1.Focus();
            SetDataGrid();
            MessageTabControl.Selecting += new TabControlCancelEventHandler(tabMenu_Selecting);
        }

        private void SetDataGrid()
        {
            DataTable gridData = new DataTable();
            var users = command.GetUsersListToSend();
            gridData.Columns.Add("Name");
            foreach (var user in users)
            {
                gridData.Rows.Add(user.Fname + " " + user.Lname);
            }

            userlistGrid.DataSource = gridData;
            if (userlistGrid.Columns.Count > 0)
                AddCheckBoxColumn();
            userlistGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
            doWork.Name = "Select";
            doWork.HeaderText = "Select";
            doWork.FalseValue = 0;
            doWork.TrueValue = 1;
            userlistGrid.Columns.Insert(0, doWork);
        }
        private void tabMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageTabControl.SelectTab(currentTab);
        }

        private void LnameInput_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lnameInput.Text))
                lnameInput.Text = "Last Name";
        }

        private void LnameInput_GotFocus(object sender, EventArgs e)
        {
            lnameInput.Text = "";
        }

        private void FnameInput_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fnameInput.Text))
                fnameInput.Text = "First Name";
        }

        private void FnameInput_GotFocus(object sender, EventArgs e)
        {
            fnameInput.Text = "";
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            PopulateInformation(true);
            currentTab++;
            MessageTabControl.SelectTab(MessageTabControl.SelectedIndex + 1);
        }

        private void PopulateInformation(bool trigger)
        {
            var checkedButton = metroTabPage1.Controls.OfType<RadioButton>()
                                                  .FirstOrDefault(r => r.Checked);
            MessageFields.Suffix = (checkedButton.Text == "Mrs.") ? Suffix.Mrs : Suffix.Mr;
            MessageFields.Fname = trigger == true ? fnameInput.Text : string.Empty;
            MessageFields.Lname = trigger == true ? lnameInput.Text : string.Empty;
            MessageFields.Department = trigger == true ? departmentInput.Text : string.Empty;
            MessageFields.Phone = trigger == true ? phoneInput.Text : string.Empty;
            MessageFields.Email = trigger == true ? emailInput.Text : string.Empty;
            MessageFields.Date = VisitedDate.Value;
        }

        private void btnBackTab_Click(object sender, EventArgs e)
        {
            MessageFields.Users = null;
            currentTab--;
            MessageTabControl.SelectTab(MessageTabControl.SelectedIndex - 1);
        }

        private void btnToReceipts_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<String>();
            foreach (DataGridViewRow row in userlistGrid.Rows)
            {
                object value = row.Cells["Select"].Value;
                if (value != null && Convert.ToBoolean(value) == true)
                {
                    selected.Add(row.Cells["Name"].Value.ToString());
                }
            }
            List<string> temp = new List<string>();
            if (selected.Count > 0)
            {
                
                foreach(string value in selected)
                {
                    temp.Add(command.GetUsersListToSend().FirstOrDefault(u => u.Fname == value.Substring(0, value.IndexOf(" "))
                                                                        && u.Lname == value.Substring(value.LastIndexOf(' ') + 1)).Email);
                }
            }
            var result = MetroMessageBox.Show(this, "Do you want to send the message to selected CFE Members: ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                TrySendingEmail(temp, selected);
            }

        }

        private void TrySendingEmail(List<string> temp, List<string> selected)
        {
            string receipt = string.Empty;
            foreach(string value in selected)
            {
                receipt += value + " ";
            }
            MessageFields.Users = receipt;
            if(command.StoreMessageInDatabase(MessageFields))
            {
                MetroMessageBox.Show(this, "Successful", "Status Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            PopulateInformation(false);   
            if (frmCategory == null)
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
    }
}
