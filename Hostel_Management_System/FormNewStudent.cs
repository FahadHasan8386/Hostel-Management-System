using Hostel_Management_System;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class FormNewStudent : Form
    {
        DataFunction fn = new DataFunction();
        string query;
        public FormNewStudent()
        {
            InitializeComponent();
        }

        private void FormEnrollStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 180);
            // ✅ Corrected SQL query
            query = "SELECT roomNo FROM rooms WHERE roomStatus = 'Yes' AND Booked = 'No'";
            DataSet ds = fn.getData(query);

            // ✅ Loop through DataSet and populate ComboBox
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                cmbStudentInformationRoomNum.Items.Add(room);
            }
        }

        

       
        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentInfromationAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStudentInfomationSave_Click(object sender, EventArgs e)
        {
            if (txtStudentInfomationFirstName.Text != "" && txtStudentInformationLastName.Text != "" && txtStudentInformationId.Text != "" && txtStudentInformationPhoneNum.Text != "" && txtStudentInformationEmail.Text != "" && txtStudentInfromationAddress.Text != "" && cmbStudentInformationRoomNum.SelectedIndex != -1)
            {
                // Convert inputs
                Int64 mobile = Int64.Parse(txtStudentInformationPhoneNum.Text);
                string firstName = txtStudentInfomationFirstName.Text;
                string lastName = txtStudentInformationLastName.Text;
                string email = txtStudentInformationEmail.Text;
                string address = txtStudentInfromationAddress.Text;
                string nid = txtStudentInformationId.Text;
                Int64 roomNum = Int64.Parse(cmbStudentInformationRoomNum.Text);

                // Correct SQL: insert + update (2 statements separated by semicolon)
                query = "INSERT INTO newStudent (Phone_Number, First_name, Last_name, Email, Address, Nid, Room_Number) " +
                        "VALUES (" + mobile + ", '" + firstName + "', '" + lastName + "', '" + email + "', '" + address + "', '" + nid + "', " + roomNum + "); " +
                        "UPDATE rooms SET Booked = 'Yes' WHERE roomNo = " + roomNum;  /// if one student is selected for the room then we update Booked status is yes

                fn.setData(query, "Student Registration Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all empty space", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStudentInformationClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtStudentInfomationFirstName.Clear();
            txtStudentInformationLastName.Clear();
            txtStudentInformationId.Clear();
            txtStudentInformationPhoneNum.Clear();
            txtStudentInformationEmail.Clear();
            txtStudentInfromationAddress.Clear();
            cmbStudentInformationRoomNum.SelectedIndex = -1; /// means nothing will be selected in ComboBox
        }
    }
}
