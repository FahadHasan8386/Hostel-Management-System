using HostelManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FormEmployeeDashboard : Form
    {
        private Login empLogin;
        private Form activeEmpChildForm = null;
        public FormEmployeeDashboard()
        {
            InitializeComponent();
        }
        private void OepenEmpChildForm(Form empChildForm)
        {
            if (activeEmpChildForm != null)
            {
                activeEmpChildForm.Close();
            }

            activeEmpChildForm = empChildForm;
            empChildForm.TopLevel = false;
            empChildForm.FormBorderStyle = FormBorderStyle.None;
            empChildForm.Dock = DockStyle.Fill;
            pnlEmployeeContainer.Controls.Clear();  // Optional: Clear previous controls if needed
            pnlEmployeeContainer.Controls.Add(empChildForm);
            pnlEmployeeContainer.Tag = empChildForm;
            empChildForm.BringToFront();
            empChildForm.Show();
        }
        public FormEmployeeDashboard(Login empLogin)
        {
            InitializeComponent();
            this.empLogin = empLogin;
        }
        private void FormEmployeeDashboarde_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpLogout_Click(object sender, EventArgs e)
        {
            this.empLogin.Visible = true;
            this.Hide();
        }

        private void picCloseButtonEmployeeDB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnStudentDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            OepenEmpChildForm(new FormEmployeeSalaries());
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            OepenEmpChildForm(new FormManageRooms());
            
        }

        private void btnEnrollEmployee_Click(object sender, EventArgs e)
        {
            OepenEmpChildForm(new FormNewEmployee());
            
        }

        private void btnManageEmplpoyee_Click(object sender, EventArgs e)
        {

            OepenEmpChildForm(new FormManageEmployeeInfo());
            
        }

        private void btnEmployeeOverview_Click(object sender, EventArgs e)
        {
            
            OepenEmpChildForm(new FormEmployeeOverview());
        }

        private void btnFormerEmployees_Click(object sender, EventArgs e)
        {
            
            OepenEmpChildForm(new FormFormerEmployees());
        }

        private void picHostelLogo_Click(object sender, EventArgs e)
        {

        }
   
        
    }
}
