namespace Hostel_Management_System
{
    partial class FormStudentPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentPayment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbStudentReceipt = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnStudentInfoClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStudentPayment = new System.Windows.Forms.DataGridView();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStudentRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPaymentSearcByPhoneNumber = new System.Windows.Forms.Button();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.pdoSudentReceipt = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialogStudent = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(317, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 25);
            this.label8.TabIndex = 104;
            this.label8.Text = "Student Payment";
            // 
            // rtbStudentReceipt
            // 
            this.rtbStudentReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStudentReceipt.Location = new System.Drawing.Point(470, 100);
            this.rtbStudentReceipt.Name = "rtbStudentReceipt";
            this.rtbStudentReceipt.Size = new System.Drawing.Size(384, 249);
            this.rtbStudentReceipt.TabIndex = 103;
            this.rtbStudentReceipt.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(607, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 29);
            this.btnReset.TabIndex = 102;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(746, 56);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 29);
            this.btnPrint.TabIndex = 101;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Black;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(470, 56);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 29);
            this.btnGenerate.TabIndex = 100;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(12, 328);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(136, 29);
            this.btnPay.TabIndex = 99;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnStudentInfoClear
            // 
            this.btnStudentInfoClear.BackColor = System.Drawing.Color.Black;
            this.btnStudentInfoClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfoClear.ForeColor = System.Drawing.Color.White;
            this.btnStudentInfoClear.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentInfoClear.Image")));
            this.btnStudentInfoClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentInfoClear.Location = new System.Drawing.Point(225, 328);
            this.btnStudentInfoClear.Name = "btnStudentInfoClear";
            this.btnStudentInfoClear.Size = new System.Drawing.Size(141, 29);
            this.btnStudentInfoClear.TabIndex = 98;
            this.btnStudentInfoClear.Text = "Clear";
            this.btnStudentInfoClear.UseVisualStyleBackColor = false;
            this.btnStudentInfoClear.Click += new System.EventHandler(this.btnStudentInfoClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(9, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Date";
            // 
            // dgvStudentPayment
            // 
            this.dgvStudentPayment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudentPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudentPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentPayment.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudentPayment.Location = new System.Drawing.Point(0, 376);
            this.dgvStudentPayment.Name = "dgvStudentPayment";
            this.dgvStudentPayment.Size = new System.Drawing.Size(878, 133);
            this.dgvStudentPayment.TabIndex = 96;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(12, 190);
            this.dtpPaymentDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            this.dtpPaymentDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(388, 20);
            this.dtpPaymentDate.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(222, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Dues Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Location = new System.Drawing.Point(225, 295);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 20);
            this.txtAmount.TabIndex = 93;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentRoomNumber
            // 
            this.txtStudentRoomNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtStudentRoomNumber.Location = new System.Drawing.Point(12, 295);
            this.txtStudentRoomNumber.Name = "txtStudentRoomNumber";
            this.txtStudentRoomNumber.Size = new System.Drawing.Size(175, 20);
            this.txtStudentRoomNumber.TabIndex = 92;
            this.txtStudentRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(9, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Room Number";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStudentEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtStudentEmail.Location = new System.Drawing.Point(12, 238);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(388, 20);
            this.txtStudentEmail.TabIndex = 90;
            this.txtStudentEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(9, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Email";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtStudentFirstName.Location = new System.Drawing.Point(12, 131);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(175, 20);
            this.txtStudentFirstName.TabIndex = 88;
            this.txtStudentFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(222, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Last Name";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtStudentLastName.Location = new System.Drawing.Point(225, 131);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(175, 20);
            this.txtStudentLastName.TabIndex = 86;
            this.txtStudentLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Phone number";
            // 
            // btnPaymentSearcByPhoneNumber
            // 
            this.btnPaymentSearcByPhoneNumber.BackColor = System.Drawing.Color.Black;
            this.btnPaymentSearcByPhoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentSearcByPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.btnPaymentSearcByPhoneNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentSearcByPhoneNumber.Image")));
            this.btnPaymentSearcByPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentSearcByPhoneNumber.Location = new System.Drawing.Point(284, 61);
            this.btnPaymentSearcByPhoneNumber.Name = "btnPaymentSearcByPhoneNumber";
            this.btnPaymentSearcByPhoneNumber.Size = new System.Drawing.Size(116, 27);
            this.btnPaymentSearcByPhoneNumber.TabIndex = 83;
            this.btnPaymentSearcByPhoneNumber.Text = "Search";
            this.btnPaymentSearcByPhoneNumber.UseVisualStyleBackColor = false;
            this.btnPaymentSearcByPhoneNumber.Click += new System.EventHandler(this.btnPaymentSearcByPhoneNumber_Click);
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(12, 61);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(220, 20);
            this.txtStudentPhoneNumber.TabIndex = 82;
            this.txtStudentPhoneNumber.Text = "Search by phone number";
            this.txtStudentPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentPhoneNumber.TextChanged += new System.EventHandler(this.txtStudentPhoneNumber_TextChanged);
            this.txtStudentPhoneNumber.Enter += new System.EventHandler(this.txtSearchByPhone_Enter);
            this.txtStudentPhoneNumber.Leave += new System.EventHandler(this.txtSearchByPhone_Leave);
            // 
            // pdoSudentReceipt
            // 
            this.pdoSudentReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdoSudentReceipt_PrintPage);
            // 
            // PrintPreviewDialogStudent
            // 
            this.PrintPreviewDialogStudent.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogStudent.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogStudent.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialogStudent.Enabled = true;
            this.PrintPreviewDialogStudent.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialogStudent.Icon")));
            this.PrintPreviewDialogStudent.Name = "PrintPreviewDialogStudent";
            this.PrintPreviewDialogStudent.Visible = false;
            this.PrintPreviewDialogStudent.Load += new System.EventHandler(this.PrintPreviewDialogStudent_Load);
            // 
            // FormStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbStudentReceipt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnStudentInfoClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvStudentPayment);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtStudentRoomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPaymentSearcByPhoneNumber);
            this.Controls.Add(this.txtStudentPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                ";
            this.Load += new System.EventHandler(this.FormStudentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbStudentReceipt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnStudentInfoClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStudentPayment;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtStudentRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPaymentSearcByPhoneNumber;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Drawing.Printing.PrintDocument pdoSudentReceipt;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialogStudent;
    }
}