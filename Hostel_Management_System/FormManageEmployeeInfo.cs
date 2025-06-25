using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
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

            /// newStudent is table name and mobile is column name
            // ✅ Correct SQL
            query = "SELECT * FROM newEmployee WHERE mobile = " + phone;

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
                MessageBox.Show("No Record with this Mobile Number Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnManageEmployeeUpdate_Click(object sender, EventArgs e)
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

        private void btnManageEmployeeDelete_Click(object sender, EventArgs e)
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

        
    }
}
