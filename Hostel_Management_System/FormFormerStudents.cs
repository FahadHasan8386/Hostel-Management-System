using System;
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
    public partial class FormFormerStudents : Form
    {
        DataFunction fn = new DataFunction();
     
        string query;

        public FormFormerStudents()
        {
            InitializeComponent();
        }

       

        private void FormFormerResidents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
        }

        private void btnFrmShowDetails_Click(object sender, EventArgs e)
        {

            query = "select * from newStudent where Living_Status = 'Yes'";
            DataSet ds = fn.getData(query);
            dgvFormerStudent.DataSource = ds.Tables[0];
        }
    
    }
}
