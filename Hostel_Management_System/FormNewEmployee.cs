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
    public partial class FormNewEmployee : Form
    {
        public FormNewEmployee()
        {
            InitializeComponent();
        }

        private void btnExitFormNewEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpoyeeInfomationSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeInfomationFirstName.Text != "" && txtEmployeeInformationId.Text != "" && txtEmployeeInformationPhoneNum.Text != "" && txtEmpployeeInformationEmail.Text != "" && txtEmployeeInfromationAddress.Text != "" && cmbEmployeeDesignattion.SelectedIndex != -1)
            {
                string name = txtEmployeeInfomationFirstName.Text;
                Int64 id = Int64.Parse(txtEmployeeInformationId.Text);
                Int64 phone = Int64.Parse(txtEmployeeInformationPhoneNum.Text);
                string email = txtEmpployeeInformationEmail.Text;
                string address = txtEmployeeInfromationAddress.Text;
                string designation = cmbEmployeeDesignattion.Text;

            }
            else
            {
                MessageBox.Show("Fill all Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEmployeeInformationClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtEmployeeInfomationFirstName.Clear();
            txtEmployeeInformationId.Clear();
            txtEmployeeInformationPhoneNum.Clear();
            txtEmpployeeInformationEmail.Clear();
            txtEmployeeInfromationAddress.Clear();
            cmbEmployeeDesignattion.SelectedIndex = -1;

        }

        
    }
}
