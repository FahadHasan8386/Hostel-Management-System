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
    public partial class FormFormerResidents : Form
    {
        public FormFormerResidents()
        {
            InitializeComponent();
        }

        private void btnExitFormFormerResidents_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFormerResidents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(595, 300);
        }
    }
}
