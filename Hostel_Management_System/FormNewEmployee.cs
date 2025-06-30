using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FormNewEmployee : Form
    {
        DataFunction fn = new DataFunction();
        string query;
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
            if ( txtEmployeeInformationPhoneNum.Text != "" && txtEmployeeInfomationFirstName.Text != "" &&   txtEmpployeeInformationEmail.Text != "" && txtEmployeeInfromationAddress.Text != "" && txtEmployeeInformationNID.Text != "" && cmbEmployeeDesignattion.SelectedIndex != -1)
            {
                //Int64 id = Int64.Parse(txtEmployeeInformationId.Text);
                Int64 phone = Int64.Parse(txtEmployeeInformationPhoneNum.Text);
                string name = txtEmployeeInfomationFirstName.Text;              
                string email = txtEmpployeeInformationEmail.Text;
                string address = txtEmployeeInfromationAddress.Text;
                Int64 nid = Int64.Parse(txtEmployeeInformationNID.Text);
                string designation = cmbEmployeeDesignattion.Text;

               
                query = "INSERT INTO newEmployee ( mobile, name, email, address ,nid, designation) " +
                        "VALUES ( '" + phone + "', '" + name + "', '" + email + "', '" + address + "', '" + nid + "', '" + designation + "')"; 
                       
                fn.setData(query, "Employee Registration Successful.");
                clearAll();
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
            txtEmployeeInformationNID.Clear();
            //txtEmployeeInformationId.Clear();
            txtEmployeeInformationPhoneNum.Clear();
            txtEmpployeeInformationEmail.Clear();
            txtEmployeeInfromationAddress.Clear();
            cmbEmployeeDesignattion.SelectedIndex = -1;

        }
        string expression = " ^([0 - 9a - zA - Z]([-\\.\\w] * [0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w]*[0 - 9a - zA - Z]\\.)+[a-zA-Z]{2,9})$";
        private void txtEmpployeeInformationEmail_TextChanged(object sender, EventArgs e)
        {
            ///Email Validation

            if (Regex.IsMatch(txtEmpployeeInformationEmail.Text, expression) == false)
            {
                txtEmpployeeInformationEmail.Focus();
                errorProviderAddStudentInformation.SetError(this.txtEmpployeeInformationEmail, "Invalid Email Adderss");
            }
            else
            {
                errorProviderAddStudentInformation.Clear();
            }
        }
    }
}
