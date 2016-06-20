using CenterFaculty.Controller;
using CenterFaculty.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterFaculty
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private SqlServerDAO command = new SqlServerDAO();
        MetroFramework.Forms.MetroForm frmhome;
        public frmLogin()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void phoneCallButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            txtpasswordBox.Focus();
            txtpasswordBox.KeyPress += TxtpasswordBox_KeyPress; ;
        }

        private void TxtpasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Checklogin();
            }
        }

        private void Frmhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome = null; //If form is closed make sure reference is set to null
            Application.ExitThread();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
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
                bool result = command.CheckPasscode(txtpasswordBox.Text, "User");
                if (result)
                {

                    loginPanel.Visible = false;
                    if (frmhome == null)
                    {
                        frmhome = new frmHome();//Create form if not created
                        frmhome.FormClosed += Frmhome_FormClosed; //Add eventhandler to cleanup after form closes
                    }
                    frmhome.StyleManager = StyleManager;
                    frmhome.Show(this); //Show Form assigning this form as the forms owner
                    Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Invalid Username or Password! Please try again!", "Oops!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Checklogin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            txtpasswordBox.Text = "";
        }
    }
}
