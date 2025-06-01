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
            tmrHostelLogo.Enabled = true;
            tmrHostelLogo.Start();
        }

        
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            FormNewStudent newStudent = new FormNewStudent();
            newStudent.Show();  
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

        private void btnCurrentResidents_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnFormerResidents_Click(object sender, EventArgs e)
        {

        }
        Boolean hostelLogoVisible = true;

        private void picHostelLogo_Click(object sender, EventArgs e)
        {

        }

        private void tmrHostelLogo_Tick(object sender, EventArgs e)
        {
            if (hostelLogoVisible)
            {
                picHostelLogo.Visible = true;
                hostelLogoVisible = false;
            }
            else
            {
                picHostelLogo.Visible = false;
                hostelLogoVisible = true;
            }
        }
    }
}
