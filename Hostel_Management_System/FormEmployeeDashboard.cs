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
        public FormEmployeeDashboard()
        {
            InitializeComponent();
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

        
    }
}
