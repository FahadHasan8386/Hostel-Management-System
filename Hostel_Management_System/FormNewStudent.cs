using System;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class FormNewStudent : Form
    {
        public FormNewStudent()
        {
            InitializeComponent();
        }

        private void FormEnrollStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(595, 300);
        }

        private void btnExitFormNewStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MobileNumber_Enter(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text == "Enter Student Mobile Nubmer")
            {
                txtMobileNumber.Text = "";
                txtMobileNumber.ForeColor = Color.Black;
            }
        }

        private void FatherName_Enter(object sender, EventArgs e)
        {
            if (txtFatherName.Text == "Enter Student Father Name")
            {
                txtFatherName.Text = "";
                txtFatherName.ForeColor = Color.Black;
            }
        }

        private void MotherName_Enter(object sender, EventArgs e)
        {
            if (txtMotherName.Text == "Enter Student Mother Name\r\n")
            {
                txtMotherName.Text = "";
                txtMotherName.ForeColor = Color.Black;
            }
        }

        private void EmailId_Enter(object sender, EventArgs e)
        {
            if (txtEmailId.Text == "Enter Studnet Email ID\r\n")
            {
                txtEmailId.Text = "";
                txtEmailId.ForeColor = Color.Black;
            }
        }

        private void Id_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
            
        }

        private void Address_Enter(object sender, EventArgs e)
        {

            if (txtAddress.Text == "Enter Student Address_Enter\r\n")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }

            
        }

        private void RoomNumber_Enter(object sender, EventArgs e)
        {
            
            if (txtRoomNumber.Text == "Enter Student Room Number\r\n")
            {
                txtRoomNumber.Text = "";
                txtRoomNumber.ForeColor = Color.Black;
            }

        }

        private void MobileNumber_Leave(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text == "")
            {
                txtMobileNumber.Text = "Enter Student Mobile Nubmer";
                txtMobileNumber.ForeColor = Color.Gray;
            }
        }

        private void FatherName_Leave(object sender, EventArgs e)
        {
            if (txtFatherName.Text == "")
            {
                txtFatherName.Text = "Enter Student Father Name";
                txtFatherName.ForeColor = Color.Gray;
            }
        }

        private void MotherName_Leave(object sender, EventArgs e)
        {
            if (txtMotherName.Text == "")
            {
                txtMotherName.Text = "Enter Student Mother Name\r\n";
                txtMotherName.ForeColor = Color.Gray;
            }
        }

        private void EmailId_Leave(object sender, EventArgs e)
        {
            if (txtEmailId.Text == "")
            {
                txtEmailId.Text = "Enter Studnet Email ID\r\n";
                txtEmailId.ForeColor = Color.Gray;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (txtEmailId.Text == "")
            {
                txtEmailId.Text = "Enter Studnet Email ID\r\n";
                txtEmailId.ForeColor = Color.Gray;
            }
        }

        private void Id_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void RoomNumber_Leave(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text == "")
            {
                txtRoomNumber.Text = "Enter Student Room Number\r\n";
                txtRoomNumber.ForeColor = Color.Gray;
            }
        }
    }
}
