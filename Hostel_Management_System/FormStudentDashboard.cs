using Hostel_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class FormStudentDashboard : Form
    {
        private Login login;
        private FormManageRooms manageRooms;
        private FormNewStudent newStudent;
        private FormManageStudentInfo manageStudentInfo;
        private FormStudentPayment studentPayment;
        private FormCurrentResidents currentResidents;
        private FormFormerResidents formerResidents;

        public FormStudentDashboard()
        {
            InitializeComponent();

        }

        public FormStudentDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
           
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            if (manageRooms == null || manageRooms.IsDisposed)
            {
                manageRooms = new FormManageRooms(); // Create a new instance only if it doesn't exist or was disposed
            }
            manageRooms.Show(); // Show the form
            manageRooms.BringToFront();

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

            if (newStudent == null || newStudent.IsDisposed)
            {
                newStudent = new FormNewStudent(); 
            }
            newStudent.Show();
            newStudent.BringToFront();
           
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
            if (currentResidents == null || currentResidents.IsDisposed)
            {
                currentResidents = new FormCurrentResidents(); 
            }
            currentResidents.Show(); 
            currentResidents.BringToFront();
        }

        private void btnManageStudentInfo_Click(object sender, EventArgs e)
        {
            if (manageStudentInfo == null || manageStudentInfo.IsDisposed)
            {
                manageStudentInfo = new FormManageStudentInfo();
            }
            manageStudentInfo.Show(); 
            manageStudentInfo.BringToFront();


        }

        private void btnFormerResidents_Click(object sender, EventArgs e)
        {
            if (formerResidents == null || formerResidents.IsDisposed)
            {
                formerResidents = new FormFormerResidents(); 
            }
            formerResidents.Show(); 
            formerResidents.BringToFront();

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

        private void btnStudentPayment_Click(object sender, EventArgs e)
        {
            if (studentPayment == null || studentPayment.IsDisposed)
            {
                studentPayment = new FormStudentPayment(); // Create a new instance only if it doesn't exist or was disposed
            }
            studentPayment.Show(); // Show the form
            studentPayment.BringToFront();
        }
    }
}
