namespace Hostel_Management_System
{
    partial class FormEmployeeSalaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeSalaries));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeSalariesPayment = new System.Windows.Forms.Label();
            this.btnPayEmployeePayment = new System.Windows.Forms.Button();
            this.btnEmployeeSalariesClear = new System.Windows.Forms.Button();
            this.lblEmployeeSalariesDate = new System.Windows.Forms.Label();
            this.dgvEmployeePayment = new System.Windows.Forms.DataGridView();
            this.dtpEmployeeSalariesPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeSalariesNetSelery = new System.Windows.Forms.Label();
            this.txtEmployeeSalariesNetSelery = new System.Windows.Forms.TextBox();
            this.lblEmployeeDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeSalariesEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalariesEmail = new System.Windows.Forms.Label();
            this.txtEmployeeSalariesFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalariesName = new System.Windows.Forms.Label();
            this.lblEmployeeSalariesPhoneNum = new System.Windows.Forms.Label();
            this.btnSearcByEmployeeSalariesPhone = new System.Windows.Forms.Button();
            this.txtEmployeeSalariesPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbEmployeeSalariesDesignattion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmployeeSalariesPayment
            // 
            this.lblEmployeeSalariesPayment.AutoSize = true;
            this.lblEmployeeSalariesPayment.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeSalariesPayment.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesPayment.Location = new System.Drawing.Point(307, 3);
            this.lblEmployeeSalariesPayment.Name = "lblEmployeeSalariesPayment";
            this.lblEmployeeSalariesPayment.Size = new System.Drawing.Size(212, 25);
            this.lblEmployeeSalariesPayment.TabIndex = 128;
            this.lblEmployeeSalariesPayment.Text = "Employee Payment";
            // 
            // btnPayEmployeePayment
            // 
            this.btnPayEmployeePayment.BackColor = System.Drawing.Color.Black;
            this.btnPayEmployeePayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnPayEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayEmployeePayment.Image")));
            this.btnPayEmployeePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayEmployeePayment.Location = new System.Drawing.Point(353, 294);
            this.btnPayEmployeePayment.Name = "btnPayEmployeePayment";
            this.btnPayEmployeePayment.Size = new System.Drawing.Size(83, 29);
            this.btnPayEmployeePayment.TabIndex = 123;
            this.btnPayEmployeePayment.Text = "Pay";
            this.btnPayEmployeePayment.UseVisualStyleBackColor = false;
            this.btnPayEmployeePayment.Click += new System.EventHandler(this.btnPayEmployeePayment_Click);
            // 
            // btnEmployeeSalariesClear
            // 
            this.btnEmployeeSalariesClear.BackColor = System.Drawing.Color.Black;
            this.btnEmployeeSalariesClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSalariesClear.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSalariesClear.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeSalariesClear.Image")));
            this.btnEmployeeSalariesClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeSalariesClear.Location = new System.Drawing.Point(499, 294);
            this.btnEmployeeSalariesClear.Name = "btnEmployeeSalariesClear";
            this.btnEmployeeSalariesClear.Size = new System.Drawing.Size(114, 29);
            this.btnEmployeeSalariesClear.TabIndex = 122;
            this.btnEmployeeSalariesClear.Text = "Clear";
            this.btnEmployeeSalariesClear.UseVisualStyleBackColor = false;
            this.btnEmployeeSalariesClear.Click += new System.EventHandler(this.btnEmployeeSalariesClear_Click);
            // 
            // lblEmployeeSalariesDate
            // 
            this.lblEmployeeSalariesDate.AutoSize = true;
            this.lblEmployeeSalariesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesDate.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesDate.Location = new System.Drawing.Point(235, 211);
            this.lblEmployeeSalariesDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesDate.Name = "lblEmployeeSalariesDate";
            this.lblEmployeeSalariesDate.Size = new System.Drawing.Size(34, 13);
            this.lblEmployeeSalariesDate.TabIndex = 121;
            this.lblEmployeeSalariesDate.Text = "Date";
            // 
            // dgvEmployeePayment
            // 
            this.dgvEmployeePayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeePayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(130)))), ((int)(((byte)(106)))));
            this.dgvEmployeePayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeePayment.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvEmployeePayment.Location = new System.Drawing.Point(0, 376);
            this.dgvEmployeePayment.Name = "dgvEmployeePayment";
            this.dgvEmployeePayment.RowHeadersWidth = 62;
            this.dgvEmployeePayment.Size = new System.Drawing.Size(878, 136);
            this.dgvEmployeePayment.TabIndex = 120;
            // 
            // dtpEmployeeSalariesPaymentDate
            // 
            this.dtpEmployeeSalariesPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeeSalariesPaymentDate.Location = new System.Drawing.Point(385, 207);
            this.dtpEmployeeSalariesPaymentDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            this.dtpEmployeeSalariesPaymentDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpEmployeeSalariesPaymentDate.Name = "dtpEmployeeSalariesPaymentDate";
            this.dtpEmployeeSalariesPaymentDate.Size = new System.Drawing.Size(220, 20);
            this.dtpEmployeeSalariesPaymentDate.TabIndex = 119;
            this.dtpEmployeeSalariesPaymentDate.ValueChanged += new System.EventHandler(this.dtpEmployeeSalariesPaymentDate_ValueChanged);
            // 
            // lblEmployeeSalariesNetSelery
            // 
            this.lblEmployeeSalariesNetSelery.AutoSize = true;
            this.lblEmployeeSalariesNetSelery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesNetSelery.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesNetSelery.Location = new System.Drawing.Point(235, 253);
            this.lblEmployeeSalariesNetSelery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesNetSelery.Name = "lblEmployeeSalariesNetSelery";
            this.lblEmployeeSalariesNetSelery.Size = new System.Drawing.Size(66, 13);
            this.lblEmployeeSalariesNetSelery.TabIndex = 118;
            this.lblEmployeeSalariesNetSelery.Text = "Net Selery";
            // 
            // txtEmployeeSalariesNetSelery
            // 
            this.txtEmployeeSalariesNetSelery.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeSalariesNetSelery.Location = new System.Drawing.Point(385, 249);
            this.txtEmployeeSalariesNetSelery.Name = "txtEmployeeSalariesNetSelery";
            this.txtEmployeeSalariesNetSelery.Size = new System.Drawing.Size(220, 20);
            this.txtEmployeeSalariesNetSelery.TabIndex = 117;
            this.txtEmployeeSalariesNetSelery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeDesignation
            // 
            this.lblEmployeeDesignation.AutoSize = true;
            this.lblEmployeeDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDesignation.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeDesignation.Location = new System.Drawing.Point(235, 171);
            this.lblEmployeeDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDesignation.Name = "lblEmployeeDesignation";
            this.lblEmployeeDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeDesignation.TabIndex = 115;
            this.lblEmployeeDesignation.Text = "Designation";
            // 
            // txtEmployeeSalariesEmail
            // 
            this.txtEmployeeSalariesEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmployeeSalariesEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeSalariesEmail.Location = new System.Drawing.Point(385, 134);
            this.txtEmployeeSalariesEmail.Name = "txtEmployeeSalariesEmail";
            this.txtEmployeeSalariesEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmployeeSalariesEmail.TabIndex = 114;
            this.txtEmployeeSalariesEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeSalariesEmail
            // 
            this.lblEmployeeSalariesEmail.AutoSize = true;
            this.lblEmployeeSalariesEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesEmail.Location = new System.Drawing.Point(235, 138);
            this.lblEmployeeSalariesEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesEmail.Name = "lblEmployeeSalariesEmail";
            this.lblEmployeeSalariesEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeSalariesEmail.TabIndex = 113;
            this.lblEmployeeSalariesEmail.Text = "Email";
            // 
            // txtEmployeeSalariesFirstName
            // 
            this.txtEmployeeSalariesFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeSalariesFirstName.Location = new System.Drawing.Point(385, 100);
            this.txtEmployeeSalariesFirstName.Name = "txtEmployeeSalariesFirstName";
            this.txtEmployeeSalariesFirstName.Size = new System.Drawing.Size(220, 20);
            this.txtEmployeeSalariesFirstName.TabIndex = 112;
            this.txtEmployeeSalariesFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeSalariesName
            // 
            this.lblEmployeeSalariesName.AutoSize = true;
            this.lblEmployeeSalariesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesName.Location = new System.Drawing.Point(235, 102);
            this.lblEmployeeSalariesName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesName.Name = "lblEmployeeSalariesName";
            this.lblEmployeeSalariesName.Size = new System.Drawing.Size(97, 13);
            this.lblEmployeeSalariesName.TabIndex = 109;
            this.lblEmployeeSalariesName.Text = "Employee Name";
            // 
            // lblEmployeeSalariesPhoneNum
            // 
            this.lblEmployeeSalariesPhoneNum.AutoSize = true;
            this.lblEmployeeSalariesPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeSalariesPhoneNum.Location = new System.Drawing.Point(235, 60);
            this.lblEmployeeSalariesPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesPhoneNum.Name = "lblEmployeeSalariesPhoneNum";
            this.lblEmployeeSalariesPhoneNum.Size = new System.Drawing.Size(91, 13);
            this.lblEmployeeSalariesPhoneNum.TabIndex = 108;
            this.lblEmployeeSalariesPhoneNum.Text = "Mobile Number";
            // 
            // btnSearcByEmployeeSalariesPhone
            // 
            this.btnSearcByEmployeeSalariesPhone.BackColor = System.Drawing.Color.Black;
            this.btnSearcByEmployeeSalariesPhone.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearcByEmployeeSalariesPhone.ForeColor = System.Drawing.Color.White;
            this.btnSearcByEmployeeSalariesPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnSearcByEmployeeSalariesPhone.Image")));
            this.btnSearcByEmployeeSalariesPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearcByEmployeeSalariesPhone.Location = new System.Drawing.Point(631, 60);
            this.btnSearcByEmployeeSalariesPhone.Name = "btnSearcByEmployeeSalariesPhone";
            this.btnSearcByEmployeeSalariesPhone.Size = new System.Drawing.Size(99, 22);
            this.btnSearcByEmployeeSalariesPhone.TabIndex = 107;
            this.btnSearcByEmployeeSalariesPhone.Text = "Search";
            this.btnSearcByEmployeeSalariesPhone.UseVisualStyleBackColor = false;
            this.btnSearcByEmployeeSalariesPhone.Click += new System.EventHandler(this.btnSearcByEmployeeSalariesPhone_Click);
            // 
            // txtEmployeeSalariesPhoneNumber
            // 
            this.txtEmployeeSalariesPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeSalariesPhoneNumber.Location = new System.Drawing.Point(385, 60);
            this.txtEmployeeSalariesPhoneNumber.Multiline = true;
            this.txtEmployeeSalariesPhoneNumber.Name = "txtEmployeeSalariesPhoneNumber";
            this.txtEmployeeSalariesPhoneNumber.Size = new System.Drawing.Size(220, 22);
            this.txtEmployeeSalariesPhoneNumber.TabIndex = 106;
            this.txtEmployeeSalariesPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEmployeeSalariesDesignattion
            // 
            this.cmbEmployeeSalariesDesignattion.FormattingEnabled = true;
            this.cmbEmployeeSalariesDesignattion.Items.AddRange(new object[] {
            "Hostel Incharge",
            "Cleaning Staff",
            "Mess Staff",
            "Accounts Manager"});
            this.cmbEmployeeSalariesDesignattion.Location = new System.Drawing.Point(385, 171);
            this.cmbEmployeeSalariesDesignattion.Name = "cmbEmployeeSalariesDesignattion";
            this.cmbEmployeeSalariesDesignattion.Size = new System.Drawing.Size(220, 21);
            this.cmbEmployeeSalariesDesignattion.TabIndex = 130;
            // 
            // FormEmployeeSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.cmbEmployeeSalariesDesignattion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmployeeSalariesPayment);
            this.Controls.Add(this.btnPayEmployeePayment);
            this.Controls.Add(this.btnEmployeeSalariesClear);
            this.Controls.Add(this.lblEmployeeSalariesDate);
            this.Controls.Add(this.dgvEmployeePayment);
            this.Controls.Add(this.dtpEmployeeSalariesPaymentDate);
            this.Controls.Add(this.lblEmployeeSalariesNetSelery);
            this.Controls.Add(this.txtEmployeeSalariesNetSelery);
            this.Controls.Add(this.lblEmployeeDesignation);
            this.Controls.Add(this.txtEmployeeSalariesEmail);
            this.Controls.Add(this.lblEmployeeSalariesEmail);
            this.Controls.Add(this.txtEmployeeSalariesFirstName);
            this.Controls.Add(this.lblEmployeeSalariesName);
            this.Controls.Add(this.lblEmployeeSalariesPhoneNum);
            this.Controls.Add(this.btnSearcByEmployeeSalariesPhone);
            this.Controls.Add(this.txtEmployeeSalariesPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeSalaries";
            this.Text = "FormEmployeeSalaries";
            this.Load += new System.EventHandler(this.FormEmployeeSalaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmployeeSalariesPayment;
        private System.Windows.Forms.Button btnPayEmployeePayment;
        private System.Windows.Forms.Button btnEmployeeSalariesClear;
        private System.Windows.Forms.Label lblEmployeeSalariesDate;
        private System.Windows.Forms.DataGridView dgvEmployeePayment;
        private System.Windows.Forms.DateTimePicker dtpEmployeeSalariesPaymentDate;
        private System.Windows.Forms.Label lblEmployeeSalariesNetSelery;
        private System.Windows.Forms.TextBox txtEmployeeSalariesNetSelery;
        private System.Windows.Forms.Label lblEmployeeDesignation;
        private System.Windows.Forms.TextBox txtEmployeeSalariesEmail;
        private System.Windows.Forms.Label lblEmployeeSalariesEmail;
        private System.Windows.Forms.TextBox txtEmployeeSalariesFirstName;
        private System.Windows.Forms.Label lblEmployeeSalariesName;
        private System.Windows.Forms.Label lblEmployeeSalariesPhoneNum;
        private System.Windows.Forms.Button btnSearcByEmployeeSalariesPhone;
        private System.Windows.Forms.TextBox txtEmployeeSalariesPhoneNumber;
        private System.Windows.Forms.ComboBox cmbEmployeeSalariesDesignattion;
    }
}