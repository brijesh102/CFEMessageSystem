using CenterFaculty.Forms;
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
            if(frmhome == null)
            {
                frmhome = new frmHome();//Create form if not created
                frmhome.FormClosed += Frmhome_FormClosed; //Add eventhandler to cleanup after form closes
            }
            frmhome.StyleManager = StyleManager;
            frmhome.Show(this); //Show Form assigning this form as the forms owner
            Hide();
            //this.Hide();
            ////frmMain _main = new frmMain();
            //frmHome _home = new frmHome();
            //_home.StyleManager = this.StyleManager;
            //_home.Show();
            ////_main.Show();
        }

        private void Frmhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmhome = null; //If form is closed make sure reference is set to null
            Application.ExitThread();
        }
    }
}
