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
            this.Location = new Point(450, 180);
        }

        

       
        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
