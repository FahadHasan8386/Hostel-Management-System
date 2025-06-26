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
    public partial class FormManageStudentInfo : Form
    {

        DataFunction fn = new DataFunction();
        string query;
        public FormManageStudentInfo()
        {
            InitializeComponent();
        }

       

        private void FormManageStudentInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
            
        }

        private void btnMngStudnetInfomationClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtMngStudentSearchByPhoneNumber.Clear();
            txtMngStudentFirstName.Clear();
            txtMngStudentLastName.Clear();
            txtMngStudentNid.Clear();
            txtMngStudentPhoneNum.Clear();
            txtMngStudentEmail.Clear();
            txtMngStudentAddress.Clear();
            txtManageStudnetRoomNum.Clear();
            chkMngkStudentLivingStatus.SelectedIndex = -1;

        }

        private void btnSearcByPhoneNumber_Click(object sender, EventArgs e)
        {
            string phone = txtMngStudentSearchByPhoneNumber.Text.Trim();


            /// newStudent is table name and mobile is column name
           
            query = "SELECT * FROM newStudent WHERE Phone_Number = " + phone;

            DataSet ds = fn.getData(query);

            /// table column 0id , 1 mobile , 2 first name , 3 last name ,4 email ,5 address ,6 idProof is not id ,7 room number ,8 living status

            /// At first we check that the phone number exist or not,
            if (ds.Tables[0].Rows.Count != 0)  /// != 0 means it / tables contails some data
            {
                txtMngStudentFirstName.Text = ds.Tables[0].Rows[0][2].ToString();  /// if i found search by mobile number then tables data first name will show in the First name text box
                txtMngStudentLastName.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMngStudentEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMngStudentAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMngStudentNid.Text = ds.Tables[0].Rows[0][6].ToString(); /// idProof mean Nid
                txtManageStudnetRoomNum.Text = ds.Tables[0].Rows[0][7].ToString();
                chkMngkStudentLivingStatus.Text = ds.Tables[0].Rows[0][8].ToString();
                 
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record with this Mobile Number Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudentInfomationUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                Int64 mobile = Int64.Parse(txtMngStudentSearchByPhoneNumber.Text);
                string firstName = txtMngStudentFirstName.Text;
                string lastName = txtMngStudentLastName.Text;
                string email = txtMngStudentEmail.Text;
                string address = txtMngStudentAddress.Text;
                string nid = txtMngStudentNid.Text;
                Int64 roomNum = Int64.Parse(txtManageStudnetRoomNum.Text);
                string livingStatus = chkMngkStudentLivingStatus.Text;


                /// here set same column name as Table column name. If i don,t write where cluse then if i not found the mobile number then every textfield  is fill with this data

                query = "UPDATE newStudent SET First_name = '" + firstName + "', Last_name = '" + lastName + "', " +
                        "Email = '" + email + "', Address = '" + address + "', Nid = '" + nid + "', " +
                        "Room_Number = " + roomNum + ", Living_Status = '" + livingStatus + "' " +
                        "WHERE Phone_Number = " + mobile + "; " +
                        "UPDATE rooms SET Booked = '" + livingStatus + "' WHERE roomNo = " + roomNum;

                fn.setData(query, "Data Updation Successful");


            }
            catch (FormatException)
            {
                MessageBox.Show("please At first Search with valid Phone Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void btnStudentInformationDelete_Click(object sender, EventArgs e)
        {
            string phone = txtMngStudentSearchByPhoneNumber.Text.Trim();
            ///messageBox name is Conformation
            if (MessageBox.Show("Are You Sure?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newStudent where Phone_Number = " + phone + "";
                fn.setData(query, "Student Record Delete.");
                clearAll();
            }
        }

        

        private void btnExitFormManageRooms_Enter(object sender, EventArgs e)
        {
            if (txtMngStudentSearchByPhoneNumber.Text == "Search by phone number")
            {
                txtMngStudentSearchByPhoneNumber.Text = "";
                txtMngStudentSearchByPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void btnExitFormManageRooms_Leave(object sender, EventArgs e)
        {
            if (txtMngStudentSearchByPhoneNumber.Text == "")
            {
                txtMngStudentSearchByPhoneNumber.Text = "Search by phone number";
                txtMngStudentSearchByPhoneNumber.ForeColor = Color.Gray;
            }
        }

       
    }
}
