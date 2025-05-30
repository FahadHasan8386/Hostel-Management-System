using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FormDashboard : Form
    {
        private Login login;
        public FormDashboard()
        {
            InitializeComponent();
        }

        public FormDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            FormManageRooms manageRooms = new FormManageRooms();
            manageRooms.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            tmrHms.Enabled = true;
            tmrHms.Start();
        }

        
        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {

        }

        Boolean lavelVisible = true;
        private void tmrHms_Tick(object sender, EventArgs e)
        {
            if(lavelVisible)
            {
                lblHms.Visible = true;
                lavelVisible = false;
            }
            else
            {
                lblHms.Visible = false;
                lavelVisible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.login.Visible = true;
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
