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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

           if (txtPassword.Text == "Sadman")
           {
                FormStudentDashboard dashboard = new FormStudentDashboard(this);
                dashboard.Visible = true;
                this.Hide();
           }
           else if(txtPassword.Text == "Fahad")
           {
                FormEmployeeDashboard empDashboard = new FormEmployeeDashboard(this);
                empDashboard.Visible = true;
                this.Hide();
           }
           else
           {
                txtPassword.Clear();
           }
           
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExitFormFormLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
