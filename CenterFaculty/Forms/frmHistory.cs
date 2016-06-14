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
    public partial class frmHistory : MetroFramework.Forms.MetroForm
    {
        private MetroForm frmHome;
        private SqlServerDAO command = new SqlServerDAO();
        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            DataTable gridData = new DataTable();
            var messages = command.GetAllMessages();

            gridData.Columns.Add("Type");
            gridData.Columns.Add("Name");
            gridData.Columns.Add("Message");
            gridData.Columns.Add("Staff's Name");
            gridData.Columns.Add("Users");
            foreach (var msg in messages)
            {
                DataRow row = gridData.NewRow();
                row[0] = msg.Type;
                row[1] = msg.Fname + " " + msg.Lname;
                row[2] = msg.Detail;
                row[3] = msg.StaffName;
                row[4] = msg.Users;
                gridData.Rows.Add(row);
            }

            messageGridView.DataSource = gridData;
            messageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnback_Click(object sender, EventArgs e)
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

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome = null;
            Application.ExitThread();
        }
    }
}
