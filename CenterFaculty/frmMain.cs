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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {

        private int currentTab = 0;
        public frmMain()
        {
            InitializeComponent();
        }


        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            //InterchangeTabs(true);
            currentTab++;
            MessageTabControl.SelectTab(MessageTabControl.SelectedIndex + 2);
            //InterchangeTabs(false);
        }

        private void btnBackTab_Click(object sender, EventArgs e)
        {
            currentTab--;
            MessageTabControl.SelectTab(MessageTabControl.SelectedIndex - 1);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //InterchangeTabs(false);

            MessageTabControl.Selecting += new TabControlCancelEventHandler(tabMenu_Selecting);
        }

        

        private void tabMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageTabControl.SelectTab(currentTab);
        }

    }
}
