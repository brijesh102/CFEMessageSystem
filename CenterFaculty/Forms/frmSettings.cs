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
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmHome;
        private CFEUser _user;
        private SqlServerDAO command = new SqlServerDAO();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            editUserPanel.Visible = false;
            editPasscodePanel.Visible = false;
            txtpasswordBox.Focus();
            txtpasswordBox.KeyPress += TxtpasswordBox_KeyPress;
            SetDataGrid();
            ResetUserDialog();
            _user = new CFEUser();
            userGridView.DoubleClick += UserGridView_DoubleClick;
        }
        

        private void SetDataGrid()
        {
            DataTable gridData = new DataTable();
            var users = command.GetUsersListToSend();
            userGridView.DataSource = users.ToList();
            userGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void TxtpasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Checklogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Checklogin();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            if (frmHome == null)
            {
                frmHome = new frmHome();
                frmHome.FormClosed += FrmHome_FormClosed;
            }
            frmHome.StyleManager = StyleManager;
            frmHome.Show(this);
            Hide();
        }

        private void Checklogin()
        {
            if (txtpasswordBox.Text == "")
            {
                MetroMessageBox.Show(this, "Please provide the Passcode", "Oops!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bool result = command.CheckPasscode(txtpasswordBox.Text, "Admin");
                if(result)
                {
                    
                    mainPanel.Visible = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "Invalid Username or Password! Please try again!", "Oops!", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            if (frmHome == null)
            {
                frmHome = new frmHome();
                frmHome.FormClosed += FrmHome_FormClosed;
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

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            editUserPanel.Visible = true;
            editPasscodePanel.Visible = false;
            txtFirstName.Focus();
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnSaveUser.Visible = true;

        }

        private void UserGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (userGridView.Focused == false) return;
            var cellindex = userGridView.SelectedCells[0].RowIndex;
            _user.Id = Convert.ToInt32(userGridView.Rows[cellindex].Cells[0].FormattedValue);
            _user.Fname = userGridView.Rows[cellindex].Cells[1].FormattedValue.ToString();
            _user.Email = userGridView.Rows[cellindex].Cells[3].FormattedValue.ToString();
            _user.Lname = userGridView.Rows[cellindex].Cells[2].FormattedValue.ToString();
            _user.Role = userGridView.Rows[cellindex].Cells[4].FormattedValue.ToString();

            editUserPanel.Visible = true;
            txtFirstName.Focus();
            btnSave.Visible = true;
            btnDelete.Visible = true;
            btnSaveUser.Visible = false;
            txtFirstName.Text = _user.Fname;
            txtLastName.Text = _user.Lname;
            txtEmail.Text = _user.Email;
            txtRole.Text = _user.Role;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            editUserPanel.Visible = false;
            ResetUserDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.Fname = txtFirstName.Text;
            _user.Email = txtEmail.Text;
            _user.Lname = txtLastName.Text;
            _user.Role = txtRole.Text;
            bool result = command.UpdateUser(_user);
            if(result)
            {
                MetroMessageBox.Show(this, "Record has been successfully updated.");
                _user = new CFEUser();
                SetDataGrid();
                ResetUserDialog();
                editUserPanel.Visible = false;
            }
            else
            {
                MetroMessageBox.Show(this, "Something went wrong.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = command.DeleteUser(_user);
            if (result)
            {
                MetroMessageBox.Show(this, "Record has been successfully Deleted.");
                _user = new CFEUser();
                SetDataGrid();
                editUserPanel.Visible = false;
            }
            else
            {
                MetroMessageBox.Show(this, "Something went wrong.");
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            
            _user.Fname = txtFirstName.Text;
            _user.Email = txtEmail.Text;
            _user.Lname = txtLastName.Text;
            _user.Role = txtRole.Text;
            if(_user.Fname.Equals(String.Empty) || _user.Lname.Equals(String.Empty) || _user.Lname.Equals(String.Empty) || _user.Email.Equals(String.Empty))
            {
                MetroMessageBox.Show(this, "Fields are empty. They cannot be empty.");
                return;
            }
            bool result = command.InsertNewUser(_user);
            if (result)
            {
                MetroMessageBox.Show(this, "Record has been successfully Added.");
                _user = new CFEUser();
                SetDataGrid();
                ResetUserDialog();
                editUserPanel.Visible = false;
            }
            else
            {
                MetroMessageBox.Show(this, "Something went wrong.");
            }
        }

        private void ResetUserDialog()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtRole.Text = String.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editPasscodePanel.Visible = false;
            ResetPasscodeDialog();
        }

        private void ResetPasscodeDialog()
        {
            Passcode _pass = command.GetPasscode();
            txtUserCurrent.Text = _pass.UserPasscode;
            txtUserNew.Text = "";
            txtAdminCurrent.Text = _pass.AdminPasscode;
            txtAdminNew.Text = "";
        }

        private void changePasscode_Click(object sender, EventArgs e)
        {
            ResetPasscodeDialog();
            editUserPanel.Visible = false;
            editPasscodePanel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editPasscodePanel.Visible = false;
            ResetPasscodeDialog();
        }

        private void btnSavePasscode_Click(object sender, EventArgs e)
        {
            if(txtAdminNew.Text != "" || txtUserNew.Text != "")
            {
                if(txtAdminNew.Text != "" && txtUserNew.Text != "")
                {
                    CommitPasscode(txtAdminNew.Text, "Admin");
                    CommitPasscode(txtUserNew.Text, "User");
                }
                else if(txtAdminNew.Text != "")
                {
                    CommitPasscode(txtAdminNew.Text, "Admin");
                }
                else if(txtUserNew.Text != "")
                {
                    CommitPasscode(txtUserNew.Text, "User");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Nothing's been changed.");
                ResetPasscodeDialog();
                editPasscodePanel.Visible = false;
            }
        }

        private void CommitPasscode(string text, string role)
        {
            bool result = command.UpdatePasscode(text, role);
            if (result)
                MetroMessageBox.Show(this, "Passcode has been changed.");
            else
                MetroMessageBox.Show(this, "Something went wrong.");
            ResetPasscodeDialog();
            editPasscodePanel.Visible = false;
        }
    }
}
