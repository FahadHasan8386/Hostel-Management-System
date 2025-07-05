using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FormManageEmployeeInfo : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormManageEmployeeInfo()
        {
            InitializeComponent();
        }

      
        private void btnManageEmployeeClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtManageEmployeePhone.Clear();
            txtManageEmployeeName.Clear();
            txtManageEmployeeNID.Clear();
            txtManageEmpployeeEmail.Clear();
            txtManageEmployeeAddress.Clear();
            chkManageEmployeeDesignation.SelectedIndex = -1;

        }

        private void FormManageEmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnManageNumSearch_Click(object sender, EventArgs e)
        {
            string phone = txtManageEmployeePhone.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter a phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if empty
            }

            try
            {
                
                query = "SELECT * FROM newEmployee WHERE mobile = '" + phone + "'";

                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtManageEmployeeName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtManageEmpployeeEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManageEmployeeAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtManageEmployeeNID.Text = ds.Tables[0].Rows[0][5].ToString();
                    chkManageEmployeeDesignation.Text = ds.Tables[0].Rows[0][6].ToString();
                    cmbMangeEWorkingStatus.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    clearAll();
                    MessageBox.Show("No record found with this phone number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Phone number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnManageEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 phone = Int64.Parse(txtManageEmployeePhone.Text);
                string name = txtManageEmployeeName.Text;
                string email = txtManageEmpployeeEmail.Text;
                string address = txtManageEmployeeAddress.Text;
                Int64 nid = Int64.Parse(txtManageEmployeeNID.Text);
                string designation = chkManageEmployeeDesignation.Text;
                string working = cmbMangeEWorkingStatus.Text;


                query = "UPDATE newEmployee SET name = '" + name +
                    "', email = '" + email +
                    "', address = '" + address +
                    "', nid = '" + nid +
                    "', designation = '" + designation +
                    "', working = '" + working +
                    "' WHERE mobile = '" + phone + "'";



                fn.setData(query, "Data Updation Successful");
            }
            catch (FormatException)
            {
                MessageBox.Show("please Fill all the Required value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnManageEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = txtManageEmployeePhone.Text.Trim();
                ///messageBox name is Conformation
                if (MessageBox.Show("Are You Sure?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from newEmployee where mobile = " + phone + "";
                    fn.setData(query, "Employee Record Delete.");
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill all requried vlaue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

<<<<<<< HEAD

=======
        string expression = " ^([0 - 9a - zA - Z]([-\\.\\w] * [0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w]*[0 - 9a - zA - Z]\\.)+[a-zA-Z]{2,9})$";
        private void txtManageEmpployeeEmail_TextChanged(object sender, EventArgs e)
        {
            ///Email Validation

            if (Regex.IsMatch(txtManageEmpployeeEmail.Text, expression) == false)
            {
                txtManageEmpployeeEmail.Focus();
                errorProviderManageEmployee.SetError(this.txtManageEmpployeeEmail, "Invalid Email Adderss");
            }
            else
            {
                errorProviderManageEmployee.Clear();
            }
        }
>>>>>>> 22ca07958437da8d935ed285d48767b5120c19cc
    }
}
