using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; /// Email validation


namespace Hostel_Management_System
{
    public partial class FormEmployeeSalaries : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormEmployeeSalaries()
        {
            InitializeComponent();
        }

        private void btnSearcByEmployeeSalariesPhone_Click(object sender, EventArgs e)
        {
            if (txtEmployeeSalariesPhoneNumber.Text != "")
            {
                string phone = txtEmployeeSalariesPhoneNumber.Text;
                query = "SELECT name, email, designation FROM newEmployee WHERE mobile = " + phone;
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    // index 0=name, 1=email, 2=designation
                    txtEmployeeSalariesFirstName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmployeeSalariesEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    cmbEmployeeSalariesDesignattion.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDataGrid(Int64.Parse(phone));
                }
                else
                {
                    MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        public void  setDataGrid(Int64 mobile)
        {
            query = "SELECT * FROM employeeSalary WHERE mobileNo = " + mobile;
            DataSet ds = fn.getData(query);
            dgvEmployeePayment.DataSource = ds.Tables[0];
        }

        private void btnPayEmployeePayment_Click(object sender, EventArgs e)
        {
            if (txtEmployeeSalariesPhoneNumber.Text != "" && txtEmployeeSalariesNetSelery.Text != "")
            {
                
                // Check if payment already exists
                query = "SELECT * FROM employeeSalary WHERE mobileNo = " + txtEmployeeSalariesPhoneNumber.Text + " AND month = '" + dtpEmployeeSalariesPaymentDate.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtEmployeeSalariesPhoneNumber.Text);
                    string month = dtpEmployeeSalariesPaymentDate.Text;
                    Int64 amount = Int64.Parse(txtEmployeeSalariesNetSelery.Text);

                    query = "insert into employeeSalary values (" + mobile + ",'" + month + "'  ," + amount + " )";
                    fn.setData(query, "Salary for month " + dtpEmployeeSalariesPaymentDate.Text + " paid");

                    setDataGrid (mobile);
                    //MessageBox.Show("Payment Successful for " + month + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Payment of " + dtpEmployeeSalariesPaymentDate.Text + " already done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
           
        }

        private void dtpEmployeeSalariesPaymentDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEmployeeSalariesClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtEmployeeSalariesPhoneNumber.Clear();
            txtEmployeeSalariesFirstName.Clear();
            txtEmployeeSalariesEmail.Clear();
            cmbEmployeeSalariesDesignattion.SelectedIndex = -1;
            txtEmployeeSalariesNetSelery.Clear();
            dgvEmployeePayment.DataSource = 0;
            dtpEmployeeSalariesPaymentDate.ResetText();
        }

        private void FormEmployeeSalaries_Load(object sender, EventArgs e)
        {
            dtpEmployeeSalariesPaymentDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeSalariesPaymentDate.CustomFormat = "MMMM yyyy";
        }

        string expression = " ^([0 - 9a - zA - Z]([-\\.\\w] * [0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w]*[0 - 9a - zA - Z]\\.)+[a-zA-Z]{2,9})$";
        private void txtEmployeeSalariesEmail_TextChanged(object sender, EventArgs e)
        {
            ///Email Validation
            
            if(Regex.IsMatch(txtEmployeeSalariesEmail.Text,expression) == false)
            {
                txtEmployeeSalariesEmail.Focus();
                empPaymetEmailErrorProvider.SetError(this.txtEmployeeSalariesEmail, "Invalid Email Adderss");
            }
            else
            {
                empPaymetEmailErrorProvider.Clear();
            }
        }

        private void txtEmployeeSalariesNetSelery_TextChanged(object sender, EventArgs e)
        {

           
            if (double.TryParse(txtEmployeeSalariesNetSelery.Text, out double amount))
            {
                if (amount <= 0)
                {
                    errorProviderEmployeeSalary.SetError(txtEmployeeSalariesNetSelery, "Amount must be greater than 0.");
                }
                else
                {
                    errorProviderEmployeeSalary.Clear();
                }
            }
            else
            {
                errorProviderEmployeeSalary.SetError(txtEmployeeSalariesNetSelery, "Please enter a valid number.");
            }
        }
    }
}
