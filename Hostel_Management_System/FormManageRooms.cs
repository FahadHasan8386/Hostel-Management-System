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
    public partial class FormManageRooms : Form
    {
        DataFunction fn = new DataFunction();
        string query;
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

      

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
            lblRoomExit.Visible = false;
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            // name of the gridview is dgvManageRooms
            dgvManageRooms.DataSource = ds.Tables[0]; /// show the database data in gridview
        }

        

        private void btnAddRooms_Click(object sender, EventArgs e)
        {
            
            query = "select * from rooms where roomNo=" + txtRoomNumber.Text;

          
            DataSet ds = fn.getData(query);

            
            if (ds.Tables[0].Rows.Count == 0)
            {
                
                String status; 

                
                if (chkRoomStatus.Checked)
                {
                    status = "Yes";
                }
               
                else
                {
                    status = "No";
                }
               
                lblRoomExit.Visible = false;

                
                query = "insert into rooms (roomNo, roomStatus) values (" + txtRoomNumber.Text + ", '" + status + "')";

                
                fn.setData(query, "Room Added Successfully.");
                FormManageRooms_Load(this, null); 

            }
            else
            {
                
                lblRoomExit.Text = "Room All Ready Exist.";

                
                lblRoomExit.Visible = true;
            }
        }

        private void btnSearchByRoomNumber_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtSearchByRoomNumbers.Text;
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {

                lblRoom.Text = "No Room Exist";
                lblRoom.Visible = true;
                chkRoomBooked.Checked = false;
            }
            else
            {
                lblRoom.Text = "Room Found.";
                lblRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")  /// roomStatus
                {
                    chkRoomBooked.Checked = true;
                }
                else
                {
                    chkRoomBooked.Checked = false;
                }
            }
        }

        private void btnStudentInfoUdateRoom_Click(object sender, EventArgs e)
        {
            String status;
            ///means if i click on checkBox then status is yes else no
            if (chkRoomBooked.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus ='" + status + "'where roomNo =" + txtSearchByRoomNumbers.Text + "";
            fn.setData(query, "Details Updated");
            FormManageRooms_Load(this, null);
        }

        private void btnStudentDeleteRoom_Click(object sender, EventArgs e)
        {
            if (lblRoom.Text == "Room Found.")
            {
                query = "delete from rooms where roomNo =" + txtSearchByRoomNumbers.Text + "";
                fn.setData(query, "Room Details Deleated.");
                FormManageRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't  Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
