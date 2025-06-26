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
    public partial class FormEmployeeOverview : Form
    {
        DataFunction fn = new DataFunction();
        String query;

        public FormEmployeeOverview()
        {
            InitializeComponent();
        }

        

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where working = 'Yes'";
            DataSet ds = fn.getData(query);
            dataGridViewEmployee.DataSource = ds.Tables[0];
        }
    }
}
