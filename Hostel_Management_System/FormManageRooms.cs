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
        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
        }

        private void btnExitFormManageRooms_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
