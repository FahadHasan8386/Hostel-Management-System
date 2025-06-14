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
    public partial class FormStudentPayment : Form
    {
        public FormStudentPayment()
        {
            InitializeComponent();
        }

     

        private void FormStudentPayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
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
            rtbStudentReceipt.Text += "Dues Amount : " + txtStudentDueFees.Text + "\n\n";

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
    }
}
