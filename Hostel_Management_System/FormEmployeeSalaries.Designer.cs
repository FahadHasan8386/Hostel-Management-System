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
            this.lblEmployeePayment = new System.Windows.Forms.Label();
            this.rtbEmployeeReceipt = new System.Windows.Forms.RichTextBox();
            this.btnResetEmployeePayment = new System.Windows.Forms.Button();
            this.btnPrintEmployeePayment = new System.Windows.Forms.Button();
            this.btnGenerateEmployeePayment = new System.Windows.Forms.Button();
            this.btnPayEmployeePayment = new System.Windows.Forms.Button();
            this.btnEmployeePaymentClear = new System.Windows.Forms.Button();
            this.lblEmployeeDate = new System.Windows.Forms.Label();
            this.dgvEmployeePayment = new System.Windows.Forms.DataGridView();
            this.dtpEmployeePaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeSalariesAmount = new System.Windows.Forms.Label();
            this.txtEmployeeSalaries = new System.Windows.Forms.TextBox();
            this.lblEmployeeDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.lblEmployeePhoneNum = new System.Windows.Forms.Label();
            this.btnSearcByEmployeePhoneNumber = new System.Windows.Forms.Button();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
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
            // lblEmployeePayment
            // 
            this.lblEmployeePayment.AutoSize = true;
            this.lblEmployeePayment.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmployeePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeePayment.Location = new System.Drawing.Point(317, 5);
            this.lblEmployeePayment.Name = "lblEmployeePayment";
            this.lblEmployeePayment.Size = new System.Drawing.Size(212, 25);
            this.lblEmployeePayment.TabIndex = 128;
            this.lblEmployeePayment.Text = "Employee Payment";
            // 
            // rtbEmployeeReceipt
            // 
            this.rtbEmployeeReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.rtbEmployeeReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEmployeeReceipt.Location = new System.Drawing.Point(470, 99);
            this.rtbEmployeeReceipt.Name = "rtbEmployeeReceipt";
            this.rtbEmployeeReceipt.Size = new System.Drawing.Size(384, 249);
            this.rtbEmployeeReceipt.TabIndex = 127;
            this.rtbEmployeeReceipt.Text = "";
            // 
            // btnResetEmployeePayment
            // 
            this.btnResetEmployeePayment.BackColor = System.Drawing.Color.Black;
            this.btnResetEmployeePayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnResetEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnResetEmployeePayment.Image")));
            this.btnResetEmployeePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetEmployeePayment.Location = new System.Drawing.Point(607, 55);
            this.btnResetEmployeePayment.Name = "btnResetEmployeePayment";
            this.btnResetEmployeePayment.Size = new System.Drawing.Size(110, 29);
            this.btnResetEmployeePayment.TabIndex = 126;
            this.btnResetEmployeePayment.Text = "Reset";
            this.btnResetEmployeePayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintEmployeePayment
            // 
            this.btnPrintEmployeePayment.BackColor = System.Drawing.Color.Black;
            this.btnPrintEmployeePayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnPrintEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintEmployeePayment.Image")));
            this.btnPrintEmployeePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintEmployeePayment.Location = new System.Drawing.Point(746, 55);
            this.btnPrintEmployeePayment.Name = "btnPrintEmployeePayment";
            this.btnPrintEmployeePayment.Size = new System.Drawing.Size(108, 29);
            this.btnPrintEmployeePayment.TabIndex = 125;
            this.btnPrintEmployeePayment.Text = "Print";
            this.btnPrintEmployeePayment.UseVisualStyleBackColor = false;
            // 
            // btnGenerateEmployeePayment
            // 
            this.btnGenerateEmployeePayment.BackColor = System.Drawing.Color.Black;
            this.btnGenerateEmployeePayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnGenerateEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateEmployeePayment.Image")));
            this.btnGenerateEmployeePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateEmployeePayment.Location = new System.Drawing.Point(470, 55);
            this.btnGenerateEmployeePayment.Name = "btnGenerateEmployeePayment";
            this.btnGenerateEmployeePayment.Size = new System.Drawing.Size(112, 29);
            this.btnGenerateEmployeePayment.TabIndex = 124;
            this.btnGenerateEmployeePayment.Text = "Generate";
            this.btnGenerateEmployeePayment.UseVisualStyleBackColor = false;
            // 
            // btnPayEmployeePayment
            // 
            this.btnPayEmployeePayment.BackColor = System.Drawing.Color.Black;
            this.btnPayEmployeePayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnPayEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayEmployeePayment.Image")));
            this.btnPayEmployeePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayEmployeePayment.Location = new System.Drawing.Point(12, 327);
            this.btnPayEmployeePayment.Name = "btnPayEmployeePayment";
            this.btnPayEmployeePayment.Size = new System.Drawing.Size(136, 29);
            this.btnPayEmployeePayment.TabIndex = 123;
            this.btnPayEmployeePayment.Text = "Pay";
            this.btnPayEmployeePayment.UseVisualStyleBackColor = false;
            // 
            // btnEmployeePaymentClear
            // 
            this.btnEmployeePaymentClear.BackColor = System.Drawing.Color.Black;
            this.btnEmployeePaymentClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePaymentClear.ForeColor = System.Drawing.Color.White;
            this.btnEmployeePaymentClear.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeePaymentClear.Image")));
            this.btnEmployeePaymentClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeePaymentClear.Location = new System.Drawing.Point(225, 327);
            this.btnEmployeePaymentClear.Name = "btnEmployeePaymentClear";
            this.btnEmployeePaymentClear.Size = new System.Drawing.Size(141, 29);
            this.btnEmployeePaymentClear.TabIndex = 122;
            this.btnEmployeePaymentClear.Text = "Clear";
            this.btnEmployeePaymentClear.UseVisualStyleBackColor = false;
            // 
            // lblEmployeeDate
            // 
            this.lblEmployeeDate.AutoSize = true;
            this.lblEmployeeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeDate.Location = new System.Drawing.Point(9, 162);
            this.lblEmployeeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDate.Name = "lblEmployeeDate";
            this.lblEmployeeDate.Size = new System.Drawing.Size(34, 13);
            this.lblEmployeeDate.TabIndex = 121;
            this.lblEmployeeDate.Text = "Date";
            // 
            // dgvEmployeePayment
            // 
            this.dgvEmployeePayment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmployeePayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePayment.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvEmployeePayment.Location = new System.Drawing.Point(2, 371);
            this.dgvEmployeePayment.Name = "dgvEmployeePayment";
            this.dgvEmployeePayment.Size = new System.Drawing.Size(878, 133);
            this.dgvEmployeePayment.TabIndex = 120;
            // 
            // dtpEmployeePaymentDate
            // 
            this.dtpEmployeePaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeePaymentDate.Location = new System.Drawing.Point(12, 189);
            this.dtpEmployeePaymentDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            this.dtpEmployeePaymentDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpEmployeePaymentDate.Name = "dtpEmployeePaymentDate";
            this.dtpEmployeePaymentDate.Size = new System.Drawing.Size(388, 20);
            this.dtpEmployeePaymentDate.TabIndex = 119;
            // 
            // lblEmployeeSalariesAmount
            // 
            this.lblEmployeeSalariesAmount.AutoSize = true;
            this.lblEmployeeSalariesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalariesAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeSalariesAmount.Location = new System.Drawing.Point(222, 272);
            this.lblEmployeeSalariesAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeSalariesAmount.Name = "lblEmployeeSalariesAmount";
            this.lblEmployeeSalariesAmount.Size = new System.Drawing.Size(101, 13);
            this.lblEmployeeSalariesAmount.TabIndex = 118;
            this.lblEmployeeSalariesAmount.Text = "Payment Amount";
            // 
            // txtEmployeeSalaries
            // 
            this.txtEmployeeSalaries.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeSalaries.Location = new System.Drawing.Point(225, 294);
            this.txtEmployeeSalaries.Name = "txtEmployeeSalaries";
            this.txtEmployeeSalaries.Size = new System.Drawing.Size(175, 20);
            this.txtEmployeeSalaries.TabIndex = 117;
            this.txtEmployeeSalaries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeDesignation
            // 
            this.lblEmployeeDesignation.AutoSize = true;
            this.lblEmployeeDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeDesignation.Location = new System.Drawing.Point(9, 272);
            this.lblEmployeeDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDesignation.Name = "lblEmployeeDesignation";
            this.lblEmployeeDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeDesignation.TabIndex = 115;
            this.lblEmployeeDesignation.Text = "Designation";
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmployeeEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(12, 237);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(388, 20);
            this.txtEmployeeEmail.TabIndex = 114;
            this.txtEmployeeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(9, 221);
            this.lblEmployeeEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmployeeEmail.TabIndex = 113;
            this.lblEmployeeEmail.Text = "Email";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(12, 130);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(175, 20);
            this.txtEmployeeFirstName.TabIndex = 112;
            this.txtEmployeeFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeLastName.Location = new System.Drawing.Point(222, 102);
            this.lblEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeLastName.TabIndex = 111;
            this.lblEmployeeLastName.Text = "Last Name";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeLastName.Location = new System.Drawing.Point(225, 130);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(175, 20);
            this.txtEmployeeLastName.TabIndex = 110;
            this.txtEmployeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(9, 102);
            this.lblEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeFirstName.TabIndex = 109;
            this.lblEmployeeFirstName.Text = "First Name";
            // 
            // lblEmployeePhoneNum
            // 
            this.lblEmployeePhoneNum.AutoSize = true;
            this.lblEmployeePhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhoneNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmployeePhoneNum.Location = new System.Drawing.Point(9, 38);
            this.lblEmployeePhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeePhoneNum.Name = "lblEmployeePhoneNum";
            this.lblEmployeePhoneNum.Size = new System.Drawing.Size(88, 13);
            this.lblEmployeePhoneNum.TabIndex = 108;
            this.lblEmployeePhoneNum.Text = "Phone number";
            // 
            // btnSearcByEmployeePhoneNumber
            // 
            this.btnSearcByEmployeePhoneNumber.BackColor = System.Drawing.Color.Black;
            this.btnSearcByEmployeePhoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearcByEmployeePhoneNumber.ForeColor = System.Drawing.Color.White;
            this.btnSearcByEmployeePhoneNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnSearcByEmployeePhoneNumber.Image")));
            this.btnSearcByEmployeePhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearcByEmployeePhoneNumber.Location = new System.Drawing.Point(284, 60);
            this.btnSearcByEmployeePhoneNumber.Name = "btnSearcByEmployeePhoneNumber";
            this.btnSearcByEmployeePhoneNumber.Size = new System.Drawing.Size(116, 27);
            this.btnSearcByEmployeePhoneNumber.TabIndex = 107;
            this.btnSearcByEmployeePhoneNumber.Text = "Search";
            this.btnSearcByEmployeePhoneNumber.UseVisualStyleBackColor = false;
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(12, 60);
            this.txtEmployeePhoneNumber.Multiline = true;
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(220, 27);
            this.txtEmployeePhoneNumber.TabIndex = 106;
            this.txtEmployeePhoneNumber.Text = "Search by phone number";
            this.txtEmployeePhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEmployeeSalariesDesignattion
            // 
            this.cmbEmployeeSalariesDesignattion.FormattingEnabled = true;
            this.cmbEmployeeSalariesDesignattion.Location = new System.Drawing.Point(12, 294);
            this.cmbEmployeeSalariesDesignattion.Name = "cmbEmployeeSalariesDesignattion";
            this.cmbEmployeeSalariesDesignattion.Size = new System.Drawing.Size(175, 21);
            this.cmbEmployeeSalariesDesignattion.TabIndex = 130;
            // 
            // FormEmployeeSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(878, 507);
            this.Controls.Add(this.cmbEmployeeSalariesDesignattion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmployeePayment);
            this.Controls.Add(this.rtbEmployeeReceipt);
            this.Controls.Add(this.btnResetEmployeePayment);
            this.Controls.Add(this.btnPrintEmployeePayment);
            this.Controls.Add(this.btnGenerateEmployeePayment);
            this.Controls.Add(this.btnPayEmployeePayment);
            this.Controls.Add(this.btnEmployeePaymentClear);
            this.Controls.Add(this.lblEmployeeDate);
            this.Controls.Add(this.dgvEmployeePayment);
            this.Controls.Add(this.dtpEmployeePaymentDate);
            this.Controls.Add(this.lblEmployeeSalariesAmount);
            this.Controls.Add(this.txtEmployeeSalaries);
            this.Controls.Add(this.lblEmployeeDesignation);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.txtEmployeeFirstName);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.lblEmployeePhoneNum);
            this.Controls.Add(this.btnSearcByEmployeePhoneNumber);
            this.Controls.Add(this.txtEmployeePhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeSalaries";
            this.Text = "FormEmployeeSalaries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmployeePayment;
        private System.Windows.Forms.RichTextBox rtbEmployeeReceipt;
        private System.Windows.Forms.Button btnResetEmployeePayment;
        private System.Windows.Forms.Button btnPrintEmployeePayment;
        private System.Windows.Forms.Button btnGenerateEmployeePayment;
        private System.Windows.Forms.Button btnPayEmployeePayment;
        private System.Windows.Forms.Button btnEmployeePaymentClear;
        private System.Windows.Forms.Label lblEmployeeDate;
        private System.Windows.Forms.DataGridView dgvEmployeePayment;
        private System.Windows.Forms.DateTimePicker dtpEmployeePaymentDate;
        private System.Windows.Forms.Label lblEmployeeSalariesAmount;
        private System.Windows.Forms.TextBox txtEmployeeSalaries;
        private System.Windows.Forms.Label lblEmployeeDesignation;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeePhoneNum;
        private System.Windows.Forms.Button btnSearcByEmployeePhoneNumber;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.ComboBox cmbEmployeeSalariesDesignattion;
    }
}