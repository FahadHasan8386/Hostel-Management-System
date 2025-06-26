using System;
using System.Collections;
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
    public partial class FormStudentPayment : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormStudentPayment()
        {
            InitializeComponent();
        }

     

        private void FormStudentPayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
            dtpPaymentDate.Format = DateTimePickerFormat.Custom;  /// set Custom Date
            dtpPaymentDate.CustomFormat = "MMMM yyyy"; ///Date time picker dtpPaymentDate
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtbStudentReceipt.Clear();
            rtbStudentReceipt.Text += "*********************************************************\n";
            rtbStudentReceipt.Text += "\n****             Payment Receipt                     ****\n";
            rtbStudentReceipt.Text += "Date : " + dtpPaymentDate.Text + "\n\n";
            rtbStudentReceipt.Text += "Phone Number : " + txtStudentPhoneNumber.Text + "\n\n";
            rtbStudentReceipt.Text += "Firt Name : " + txtStudentFirstName.Text + "\n\n";
            rtbStudentReceipt.Text += "Last Name : " + txtStudentLastName.Text + "\n\n";
            rtbStudentReceipt.Text += "Email Id: " + txtStudentEmail.Text + "\n\n";
            rtbStudentReceipt.Text += "Room Number : " + txtStudentRoomNumber.Text + "\n\n";
            rtbStudentReceipt.Text += "Dues Amount : " + txtAmount.Text + "\n\n";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            rtbStudentReceipt.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialogStudent.Document = pdoSudentReceipt;
            PrintPreviewDialogStudent.ShowDialog();
        }

        private void txtSearchByPhone_Enter(object sender, EventArgs e)
        {
            if (txtStudentPhoneNumber.Text == "Search by phone number")
            {
                txtStudentPhoneNumber.Text = "";
                txtStudentPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void txtSearchByPhone_Leave(object sender, EventArgs e)
        {

            if (txtStudentPhoneNumber.Text == "")
            {
                txtStudentPhoneNumber.Text = "Search by phone number";
                txtStudentPhoneNumber.ForeColor = Color.Gray;
            }
        }

        private void pdoSudentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbStudentReceipt.Text, new Font("Microsoft Sans Serif", 10, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void PrintPreviewDialogStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtStudentPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        public void setDataGrid(Int64 mobile)
        {
            /// here fees is table name and mobileNo column name. whever i store in the dataset actually in the table form
            query = "select * from fees where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            dgvStudentPayment.DataSource = ds.Tables[0]; /// gridview


        }
        private void btnPaymentSearcByPhoneNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentPhoneNumber.Text != "")
                {
                    string phone = txtStudentPhoneNumber.Text.Trim();


                    query = "SELECT First_name, Last_name, Email, Room_Number FROM newStudent WHERE Phone_Number = " + phone;

                    DataSet ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtStudentFirstName.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtStudentLastName.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtStudentEmail.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtStudentRoomNumber.Text = ds.Tables[0].Rows[0][3].ToString();

                        setDataGrid(Int64.Parse(phone));  // Safer to use the trimmed string variable
                    }
                    else
                    {
                        MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Phone number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtStudentPhoneNumber.Text != "" && txtAmount.Text != "")
            {
                
                
                query = "select * from fees where mobileNo = " + Int64.Parse(txtStudentPhoneNumber.Text) + " and fmonth = '" + dtpPaymentDate.Text + "' ";  ///date time picker.
                DataSet ds = fn.getData(query);

               
                
                query = "select * from fees where mobileNo = " + Int64.Parse(txtStudentPhoneNumber.Text) + " and fmonth = '" + dtpPaymentDate.Text + "' ";  ///date time picker.
                if (ds.Tables[0].Rows.Count == 0)
                {
                    
                    Int64 mobile = Int64.Parse(txtStudentPhoneNumber.Text);
                    string month = dtpPaymentDate.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    
                    query = "insert into fees values(" + mobile + ", '" + month + "', " + amount + ")"; 
                                                                                                        
                    fn.setData(query, "Fees paid.");

                    clearAll();
                }
                else
                {
                    MessageBox.Show("No dues of " + dtpPaymentDate.Text + " Left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void clearAll()
        {

            txtStudentPhoneNumber.Clear();
            txtStudentFirstName.Clear();
            txtStudentLastName.Clear();
            txtAmount.Clear();
            txtStudentRoomNumber.Clear();
            txtStudentEmail.Clear();
            dgvStudentPayment.DataSource = 0;
        }
        private void btnStudentInfoClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
