using Hostel_Management_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class Login : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM Userinfo WHERE Id = '"
            + textUserId.Text + "' AND Password = '"
            + txtPassword.Text + "';";

            DataSet ds = fn.getData(query);



            if (ds.Tables[0].Rows.Count == 1)
            {
                var name = ds.Tables[0].Rows[0][1].ToString();
                MessageBox.Show("Valid User", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;

                if (ds.Tables[0].Rows[0][0].ToString().Equals("u-001") && ds.Tables[0].Rows[0][1].ToString().Equals("123"))
                {
                    new FormStudentDashboard(this).Show();
                    ClearAll();
                }
                else if (ds.Tables[0].Rows[0][0].ToString().Equals("u-002") && ds.Tables[0].Rows[0][1].ToString().Equals("456"))
                {
                    new FormEmployeeDashboard(this).Show();
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Invalid User", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExitFormFormLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        public void ClearAll()
        {
            textUserId.Clear();
            txtPassword.Clear();
        }

        private void btnLoginFromClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    } 
}
