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
    public partial class FormStatusOverview : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormStatusOverview()
        {
            InitializeComponent();
        }

        private void FormStatusOverview_Load(object sender, EventArgs e)
        {
            TotalStudents();
            TotalRooms();
            BedAssign();
            PendingFees();
        }


        public void TotalStudents()
        {
            lblTotalStudents.Text = fn.Count("SELECT COUNT(*) FROM newStudent");
        }

        public void TotalRooms()
        {

            lblTotalRooms.Text = fn.Count("SELECT COUNT(*) FROM rooms");
        }

        public void BedAssign()
        {
            lblBedAssign.Text = fn.Count("SELECT COUNT(*) FROM newStudent WHERE Living_Status = 'Yes'");
        }

        public void PendingFees()
        {

            lblPaidStudents.Text = fn.Count("SELECT COUNT(*) FROM fees");
        }
      

       
    }
}
