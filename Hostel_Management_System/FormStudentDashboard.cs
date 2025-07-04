﻿using Hostel_Management_System;
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
    public partial class FormStudentDashboard : Form
    {
        private Login login;
        private Form activeForm = null;
        

        public FormStudentDashboard()
        {
            InitializeComponent();

        }

        public FormStudentDashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
           
        }


        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();  // Optional: Clear previous controls if needed
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void UpdateHeaderInfo(string labelText)
        {
            lableInfo.Text = labelText;
            lableInfo.Visible = true;

        }
      

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            tmrHms.Enabled = true;
            tmrHms.Start();
            tmrHostelLogo.Enabled = true;
            tmrHostelLogo.Start();
        }

        
        private void btnNewStudent_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FormNewStudent());
            UpdateHeaderInfo("New Student");

        }

        Boolean lavelVisible = true;
      
        private void tmrHms_Tick(object sender, EventArgs e)
        {
            if(lavelVisible)
            {
                lblHms.Visible = true;
                lavelVisible = false;
            }
            else
            {
                lblHms.Visible = false;
                lavelVisible = true;
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCurrentResidents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCurrentStudents());
            UpdateHeaderInfo("Current Residents");
        }

        private void btnManageStudentInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManageStudentInfo());
            UpdateHeaderInfo("Manage Student Info");


        }

        private void btnFormerResidents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFormerStudents());
            UpdateHeaderInfo("Former Residents");

        }

       
        

        private void btnStudentPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStudentPayment());
            UpdateHeaderInfo("Student Payment");
        }

       

        private void picCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnloout_Click(object sender, EventArgs e)
        {
            this.login.Visible = true;
            this.Hide();

        }

        
       

        private void btnStudentDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStatusOverview());
            UpdateHeaderInfo("Status Overview");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tmrSidebarTransition.Start();
        }


        bool sidebarExpan = true;
        private void tmrSidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpan)
            {
                pnlSidebar.Width -= 10;
                if(pnlSidebar.Width <= 53)
                {
                    sidebarExpan = false;
                    tmrSidebarTransition.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if(pnlSidebar.Width >= 215)
                {
                   sidebarExpan = true;
                   tmrSidebarTransition.Stop();
                }
            }
        }

       
    }
}
