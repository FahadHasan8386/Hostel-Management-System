using Hostel_Management_System;
using System;
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
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String connectionstring = "data source=FAHAD\\SQLEXPRESS;database=HMS;Integrated Security=True";

            string sql = "SELECT * FROM Userinfo WHERE Id = '"
            + textUserId.Text + "' AND Password = '"
            + txtPassword.Text + "';";


            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                var name = ds.Tables[0].Rows[0][1].ToString();
                MessageBox.Show("Valid User");
                this.Visible = false;

                if (ds.Tables[0].Rows[0][0].ToString().Equals("u-001") && ds.Tables[0].Rows[0][1].ToString().Equals("123"))
                {
                    new FormStudentDashboard(this).Show();
                }
                else if (ds.Tables[0].Rows[0][0].ToString().Equals("u-002") && ds.Tables[0].Rows[0][1].ToString().Equals("456"))
                {
                    new FormEmployeeDashboard(this).Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid User");
            }

            sqlcon.Close();

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExitFormFormLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
