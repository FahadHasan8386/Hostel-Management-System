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
    public partial class FormCurrentStudents : Form
    {
        public FormCurrentStudents()
        {
            InitializeComponent();
        }

        private void FormCurrentResidents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
        }
    }
}
