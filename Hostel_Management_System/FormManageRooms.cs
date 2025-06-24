using Hostel_Management_System;
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
        DataFunction fn = new DataFunction();
        string query;
        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void btnExitFormManageRooms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitFormManageRooms_Leave(object sender, EventArgs e)
        {
            if (txtSearchByRoomNumbers.Text == "")
            {
                txtSearchByRoomNumbers.Text = "Search By Room Number";
                txtSearchByRoomNumbers.ForeColor = Color.Gray;
            }
        }

        private void btnExitFormManageRooms_Enter(object sender, EventArgs e)
        {
            if(txtSearchByRoomNumbers.Text == "Search By Room Number")
            {
                txtSearchByRoomNumbers.Text = "";
                txtSearchByRoomNumbers.ForeColor = Color.Black;
            }
        }

        private void FormManageRooms_Leave(object sender, EventArgs e)
        {

        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            lblRoom.Visible = false;
            lblRoomExit.Visible = false;
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            // name of the gridview is dgvManageRooms
            dgvManageRooms.DataSource = ds.Tables[0]; /// show the database data in gridview
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRooms_Click(object sender, EventArgs e)
        {
            // 1. ডেটাবেস হেল্পার অবজেক্ট তৈরি:
            // DatabaseHelper ক্লাসের একটি নতুন ইনস্ট্যান্স তৈরি করা হয়েছে।
            // এটি getData এবং setData পদ্ধতির মতো ডেটাবেস অপারেশনগুলি অ্যাক্সেস করার জন্য ব্যবহৃত হবে।


            // 2. রুম নম্বর দিয়ে ডেটা খোঁজা:
            // একটি SQL ক্যোয়ারী স্ট্রিং তৈরি করা হয়েছে যা 'rooms' টেবিল থেকে নির্দিষ্ট 'roomNo' এর সমস্ত ডেটা নির্বাচন করে।
            // txtRoomNo1.Text একটি TextBox কন্ট্রোল থেকে রুম নম্বর নিচ্ছে।
            query = "select * from rooms where roomNo=" + txtRoomNumber.Text;

            // 3. ক্যোয়ারী এক্সিকিউট করা এবং ফলাফল প্রাপ্তি:
            // fn.getData(query) পদ্ধতি কল করে ক্যোয়ারীটি চালানো হয় এবং ফলাফল একটি DataSet অবজেক্ট 'ds' এ জমা হয়।
            // এই DataSet-এ যদি রুম নম্বরটি আগে থেকেই বিদ্যমান থাকে তবে তার তথ্য থাকবে।
            DataSet ds = fn.getData(query);

            // 4. রুম বিদ্যমান কিনা তা পরীক্ষা করা:
            // ds.Tables[0].Rows.Count == 0: এটি পরীক্ষা করে যে DataSet এর প্রথম টেবিলে কোনো সারি আছে কিনা।
            // যদি সারির সংখ্যা 0 হয়, তার মানে হলো প্রদত্ত রুম নম্বরটি ডেটাবেসে বিদ্যমান নেই।
            if (ds.Tables[0].Rows.Count == 0)
            {
                // 5. রুমের স্ট্যাটাস নির্ধারণ করা:
                String status; // রুমের স্ট্যাটাস ('Yes' বা 'No') সংরক্ষণের জন্য একটি স্ট্রিং ভেরিয়েবল।

                // checkbox1.Checked: একটি CheckBox কন্ট্রোল, যা চেক করা আছে কিনা তা পরীক্ষা করা হয়।
                // যদি চেক করা থাকে (অর্থাৎ, রুম সক্রিয় বা উপলব্ধ), স্ট্যাটাস "Yes" সেট করা হয়।
                if (chkRoomStatus.Checked)
                {
                    status = "Yes";
                }
                // যদি চেক করা না থাকে, স্ট্যাটাস "No" সেট করা হয়।
                else
                {
                    status = "No";
                }
                // 8. লেবেল অদৃশ্য করা:
                // labelRoomExist.Visible = false: একটি লেবেল কন্ট্রোলকে অদৃশ্য করে দেয়।
                // সম্ভবত এই লেবেলটি "Room All Ready Exist." বার্তা প্রদর্শনের জন্য ব্যবহৃত হয়,
                // এবং নতুন রুম সফলভাবে যুক্ত হওয়ার পর এটি অদৃশ্য করা হয়।
                lblRoomExit.Visible = false;

                // 6. ডেটাবেসে নতুন রুম যোগ করা:
                // একটি SQL INSERT ক্যোয়ারী তৈরি করা হয়েছে নতুন রুম ডেটা 'rooms' টেবিলে যুক্ত করার জন্য।
                // txtRoomNo1.Text থেকে রুম নম্বর এবং উপরে নির্ধারিত 'status' ব্যবহৃত হয়।
                query = "insert into rooms (roomNo, roomStatus) values (" + txtRoomNumber.Text + ", '" + status + "')";

                // 7. ক্যোয়ারী এক্সিকিউট করা এবং বার্তা প্রদর্শন:
                // fn.setData(query, "Room Added Successfully.") পদ্ধতি কল করে INSERT ক্যোয়ারীটি চালানো হয়।
                // "Room Added Successfully." বার্তাটি ব্যবহারকারীকে দেখানো হবে।
                fn.setData(query, "Room Added Successfully.");
                FormManageRooms_Load(this, null); // load the form again so that if we add room then show that in gridview on that time
                                                  // 9. যদি রুম আগে থেকেই বিদ্যমান থাকে:
                                                  // যদি ds.Tables[0].Rows.Count 0 না হয়, তার মানে রুম নম্বরটি আগে থেকেই ডেটাবেসে বিদ্যমান।

            }
            else
            {
                // 10. মেসেজ সেট করা:
                // labelRoomExist.Text = "Room All Ready Exist.": লেবেলটিতে "Room All Ready Exist." বার্তা সেট করা হয়।
                lblRoomExit.Text = "Room All Ready Exist.";

                // 11. লেবেল দৃশ্যমান করা:
                // labelRoomExist.Visible = true: লেবেলটি দৃশ্যমান করা হয় যাতে ব্যবহারকারী বার্তাটি দেখতে পারে।
                lblRoomExit.Visible = true;
            }
        }

        private void btnSearchByRoomNumber_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtSearchByRoomNumbers.Text;
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {

                lblRoom.Text = "No Room Exist";
                lblRoom.Visible = true;
                chkRoomBooked.Checked = false;
            }
            else
            {
                lblRoom.Text = "Room Found.";
                lblRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")  /// roomStatus
                {
                    chkRoomBooked.Checked = true;
                }
                else
                {
                    chkRoomBooked.Checked = false;
                }
            }
        }

        private void btnStudentInfoUdateRoom_Click(object sender, EventArgs e)
        {
            String status;
            ///means if i click on checkBox then status is yes else no
            if (chkRoomBooked.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus ='" + status + "'where roomNo =" + txtSearchByRoomNumbers.Text + "";
            fn.setData(query, "Details Updated");
            FormManageRooms_Load(this, null);
        }

        private void btnStudentDeleteRoom_Click(object sender, EventArgs e)
        {
            if (lblRoom.Text == "Room Found.")
            {
                query = "delete from rooms where roomNo =" + txtSearchByRoomNumbers.Text + "";
                fn.setData(query, "Room Details Deleated.");
                FormManageRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't  Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
