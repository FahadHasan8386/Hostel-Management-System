using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FormFormerEmployees : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormFormerEmployees()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentInfoClear_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where working = 'NO'";
            DataSet ds = fn.getData(query);
            dgvFormerEmployee.DataSource = ds.Tables[0];
        }
    }
}
