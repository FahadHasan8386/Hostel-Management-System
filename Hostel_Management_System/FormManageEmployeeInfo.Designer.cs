namespace Hostel_Management_System
{
    partial class FormManageEmployeeInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageEmployeeInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageEmployeeClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkManageEmployeeDesignation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtManageEmployeeNID = new System.Windows.Forms.TextBox();
            this.btnManageEmployeeDelete = new System.Windows.Forms.Button();
            this.btnManageEmployeeUpdate = new System.Windows.Forms.Button();
            this.txtManageEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManageNumSearch = new System.Windows.Forms.Button();
            this.txtManageEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtManageEmpployeeEmail = new System.Windows.Forms.TextBox();
            this.lblManageEmpoyeeAddress = new System.Windows.Forms.Label();
            this.txtManageEmployeeAddress = new System.Windows.Forms.TextBox();
            this.lblManageEmployeeEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMangeEWorkingStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(277, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "Manage Employee Inofrmation";
            // 
            // btnManageEmployeeClear
            // 
            this.btnManageEmployeeClear.BackColor = System.Drawing.Color.Black;
            this.btnManageEmployeeClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployeeClear.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployeeClear.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEmployeeClear.Image")));
            this.btnManageEmployeeClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployeeClear.Location = new System.Drawing.Point(611, 395);
            this.btnManageEmployeeClear.Name = "btnManageEmployeeClear";
            this.btnManageEmployeeClear.Size = new System.Drawing.Size(122, 34);
            this.btnManageEmployeeClear.TabIndex = 126;
            this.btnManageEmployeeClear.Text = "Clear";
            this.btnManageEmployeeClear.UseVisualStyleBackColor = false;
            this.btnManageEmployeeClear.Click += new System.EventHandler(this.btnManageEmployeeClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Designation";
            // 
            // chkManageEmployeeDesignation
            // 
            this.chkManageEmployeeDesignation.FormattingEnabled = true;
            this.chkManageEmployeeDesignation.Items.AddRange(new object[] {
            "Hostel Incharge",
            "Cleaning Staff",
            "Mess Staff",
            "Accounts Manager"});
            this.chkManageEmployeeDesignation.Location = new System.Drawing.Point(346, 289);
            this.chkManageEmployeeDesignation.Name = "chkManageEmployeeDesignation";
            this.chkManageEmployeeDesignation.Size = new System.Drawing.Size(388, 21);
            this.chkManageEmployeeDesignation.TabIndex = 124;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(225, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "NID";
            // 
            // txtManageEmployeeNID
            // 
            this.txtManageEmployeeNID.ForeColor = System.Drawing.Color.Gray;
            this.txtManageEmployeeNID.Location = new System.Drawing.Point(346, 147);
            this.txtManageEmployeeNID.Multiline = true;
            this.txtManageEmployeeNID.Name = "txtManageEmployeeNID";
            this.txtManageEmployeeNID.Size = new System.Drawing.Size(200, 22);
            this.txtManageEmployeeNID.TabIndex = 119;
            this.txtManageEmployeeNID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnManageEmployeeDelete
            // 
            this.btnManageEmployeeDelete.BackColor = System.Drawing.Color.Black;
            this.btnManageEmployeeDelete.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployeeDelete.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployeeDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEmployeeDelete.Image")));
            this.btnManageEmployeeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployeeDelete.Location = new System.Drawing.Point(419, 395);
            this.btnManageEmployeeDelete.Name = "btnManageEmployeeDelete";
            this.btnManageEmployeeDelete.Size = new System.Drawing.Size(111, 34);
            this.btnManageEmployeeDelete.TabIndex = 118;
            this.btnManageEmployeeDelete.Text = "Delete";
            this.btnManageEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnManageEmployeeDelete.Click += new System.EventHandler(this.btnManageEmployeeDelete_Click);
            // 
            // btnManageEmployeeUpdate
            // 
            this.btnManageEmployeeUpdate.BackColor = System.Drawing.Color.Black;
            this.btnManageEmployeeUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployeeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployeeUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEmployeeUpdate.Image")));
            this.btnManageEmployeeUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployeeUpdate.Location = new System.Drawing.Point(228, 395);
            this.btnManageEmployeeUpdate.Name = "btnManageEmployeeUpdate";
            this.btnManageEmployeeUpdate.Size = new System.Drawing.Size(118, 34);
            this.btnManageEmployeeUpdate.TabIndex = 117;
            this.btnManageEmployeeUpdate.Text = "Update";
            this.btnManageEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnManageEmployeeUpdate.Click += new System.EventHandler(this.btnManageEmployeeUpdate_Click);
            // 
            // txtManageEmployeeName
            // 
            this.txtManageEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.txtManageEmployeeName.Location = new System.Drawing.Point(346, 103);
            this.txtManageEmployeeName.Name = "txtManageEmployeeName";
            this.txtManageEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtManageEmployeeName.TabIndex = 116;
            this.txtManageEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(225, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(225, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Phone number";
            // 
            // btnManageNumSearch
            // 
            this.btnManageNumSearch.BackColor = System.Drawing.Color.Black;
            this.btnManageNumSearch.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageNumSearch.ForeColor = System.Drawing.Color.White;
            this.btnManageNumSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnManageNumSearch.Image")));
            this.btnManageNumSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageNumSearch.Location = new System.Drawing.Point(593, 54);
            this.btnManageNumSearch.Name = "btnManageNumSearch";
            this.btnManageNumSearch.Size = new System.Drawing.Size(116, 27);
            this.btnManageNumSearch.TabIndex = 111;
            this.btnManageNumSearch.Text = "Search";
            this.btnManageNumSearch.UseVisualStyleBackColor = false;
            this.btnManageNumSearch.Click += new System.EventHandler(this.btnManageNumSearch_Click);
            // 
            // txtManageEmployeePhone
            // 
            this.txtManageEmployeePhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeePhone.Location = new System.Drawing.Point(346, 60);
            this.txtManageEmployeePhone.Name = "txtManageEmployeePhone";
            this.txtManageEmployeePhone.Size = new System.Drawing.Size(200, 20);
            this.txtManageEmployeePhone.TabIndex = 110;
            this.txtManageEmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtManageEmpployeeEmail
            // 
            this.txtManageEmpployeeEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtManageEmpployeeEmail.Location = new System.Drawing.Point(346, 196);
            this.txtManageEmpployeeEmail.Multiline = true;
            this.txtManageEmpployeeEmail.Name = "txtManageEmpployeeEmail";
            this.txtManageEmpployeeEmail.Size = new System.Drawing.Size(388, 21);
            this.txtManageEmpployeeEmail.TabIndex = 131;
            this.txtManageEmpployeeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblManageEmpoyeeAddress
            // 
            this.lblManageEmpoyeeAddress.AutoSize = true;
            this.lblManageEmpoyeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmpoyeeAddress.ForeColor = System.Drawing.Color.Black;
            this.lblManageEmpoyeeAddress.Location = new System.Drawing.Point(225, 248);
            this.lblManageEmpoyeeAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageEmpoyeeAddress.Name = "lblManageEmpoyeeAddress";
            this.lblManageEmpoyeeAddress.Size = new System.Drawing.Size(52, 13);
            this.lblManageEmpoyeeAddress.TabIndex = 130;
            this.lblManageEmpoyeeAddress.Text = "Address";
            // 
            // txtManageEmployeeAddress
            // 
            this.txtManageEmployeeAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtManageEmployeeAddress.Location = new System.Drawing.Point(346, 240);
            this.txtManageEmployeeAddress.Multiline = true;
            this.txtManageEmployeeAddress.Name = "txtManageEmployeeAddress";
            this.txtManageEmployeeAddress.Size = new System.Drawing.Size(388, 21);
            this.txtManageEmployeeAddress.TabIndex = 129;
            this.txtManageEmployeeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblManageEmployeeEmail
            // 
            this.lblManageEmployeeEmail.AutoSize = true;
            this.lblManageEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployeeEmail.ForeColor = System.Drawing.Color.Black;
            this.lblManageEmployeeEmail.Location = new System.Drawing.Point(225, 196);
            this.lblManageEmployeeEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageEmployeeEmail.Name = "lblManageEmployeeEmail";
            this.lblManageEmployeeEmail.Size = new System.Drawing.Size(37, 13);
            this.lblManageEmployeeEmail.TabIndex = 128;
            this.lblManageEmployeeEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(225, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Working Status";
            // 
            // cmbMangeEWorkingStatus
            // 
            this.cmbMangeEWorkingStatus.FormattingEnabled = true;
            this.cmbMangeEWorkingStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbMangeEWorkingStatus.Location = new System.Drawing.Point(346, 352);
            this.cmbMangeEWorkingStatus.Name = "cmbMangeEWorkingStatus";
            this.cmbMangeEWorkingStatus.Size = new System.Drawing.Size(388, 21);
            this.cmbMangeEWorkingStatus.TabIndex = 132;
            // 
            // FormManageEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(868, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMangeEWorkingStatus);
            this.Controls.Add(this.txtManageEmpployeeEmail);
            this.Controls.Add(this.lblManageEmpoyeeAddress);
            this.Controls.Add(this.txtManageEmployeeAddress);
            this.Controls.Add(this.lblManageEmployeeEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManageEmployeeClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkManageEmployeeDesignation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtManageEmployeeNID);
            this.Controls.Add(this.btnManageEmployeeDelete);
            this.Controls.Add(this.btnManageEmployeeUpdate);
            this.Controls.Add(this.txtManageEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnManageNumSearch);
            this.Controls.Add(this.txtManageEmployeePhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManageEmployeeInfo";
            this.Text = "FormManageEmployee";
            this.Load += new System.EventHandler(this.FormManageEmployeeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageEmployeeClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chkManageEmployeeDesignation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtManageEmployeeNID;
        private System.Windows.Forms.Button btnManageEmployeeDelete;
        private System.Windows.Forms.Button btnManageEmployeeUpdate;
        private System.Windows.Forms.TextBox txtManageEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManageNumSearch;
        private System.Windows.Forms.TextBox txtManageEmployeePhone;
        private System.Windows.Forms.TextBox txtManageEmpployeeEmail;
        private System.Windows.Forms.Label lblManageEmpoyeeAddress;
        private System.Windows.Forms.TextBox txtManageEmployeeAddress;
        private System.Windows.Forms.Label lblManageEmployeeEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMangeEWorkingStatus;
    }
}