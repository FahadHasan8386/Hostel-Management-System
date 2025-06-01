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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewStudentExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
