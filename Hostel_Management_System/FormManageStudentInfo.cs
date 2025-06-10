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
    public partial class FormManageStudentInfo : Form
    {
        public FormManageStudentInfo()
        {
            InitializeComponent();
        }

       

        private void FormManageStudentInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
        }
    }
}
