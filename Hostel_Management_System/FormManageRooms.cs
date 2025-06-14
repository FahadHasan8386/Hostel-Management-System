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
    public partial class FormManageRooms : Form
    {
        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void btnExitFormManageRooms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitFormManageRooms_Leave(object sender, EventArgs e)
        {
            if (txtSearchByRoomNumbers.Text == "")
            {
                txtSearchByRoomNumbers.Text = "Search By Room Number";
                txtSearchByRoomNumbers.ForeColor = Color.Gray;
            }
        }

        private void btnExitFormManageRooms_Enter(object sender, EventArgs e)
        {
            if(txtSearchByRoomNumbers.Text == "Search By Room Number")
            {
                txtSearchByRoomNumbers.Text = "";
                txtSearchByRoomNumbers.ForeColor = Color.Black;
            }
        }

        private void FormManageRooms_Leave(object sender, EventArgs e)
        {

        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
            lblRoomExit.Visible = false;   
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
