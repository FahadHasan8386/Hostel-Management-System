namespace HostelManagementSystem
{
    partial class FormNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewStudent));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExitFormNewStudent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.Location = new System.Drawing.Point(428, 342);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(280, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "ID";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.Enter += new System.EventHandler(this.Id_Enter);
            this.txtId.Leave += new System.EventHandler(this.Id_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(428, 291);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Enter Student Address_Enter\r\n";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.Enter += new System.EventHandler(this.Address_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // txtEmailId
            // 
            this.txtEmailId.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailId.Location = new System.Drawing.Point(428, 248);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(280, 20);
            this.txtEmailId.TabIndex = 4;
            this.txtEmailId.Text = "Enter Studnet Email ID\r\n";
            this.txtEmailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailId.Enter += new System.EventHandler(this.EmailId_Enter);
            this.txtEmailId.Leave += new System.EventHandler(this.EmailId_Leave);
            // 
            // txtMotherName
            // 
            this.txtMotherName.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherName.Location = new System.Drawing.Point(428, 202);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(280, 20);
            this.txtMotherName.TabIndex = 5;
            this.txtMotherName.Text = "Enter Student Mother Name\r\n";
            this.txtMotherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMotherName.Enter += new System.EventHandler(this.MotherName_Enter);
            this.txtMotherName.Leave += new System.EventHandler(this.MotherName_Leave);
            // 
            // txtFatherName
            // 
            this.txtFatherName.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherName.Location = new System.Drawing.Point(428, 153);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(280, 20);
            this.txtFatherName.TabIndex = 6;
            this.txtFatherName.Text = "Enter Student Father Name";
            this.txtFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFatherName.Enter += new System.EventHandler(this.FatherName_Enter);
            this.txtFatherName.Leave += new System.EventHandler(this.FatherName_Leave);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtMobileNumber.Location = new System.Drawing.Point(428, 107);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(280, 20);
            this.txtMobileNumber.TabIndex = 7;
            this.txtMobileNumber.Text = "Enter Student Mobile Nubmer";
            this.txtMobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMobileNumber.Enter += new System.EventHandler(this.MobileNumber_Enter);
            this.txtMobileNumber.Leave += new System.EventHandler(this.MobileNumber_Leave);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtRoomNumber.Location = new System.Drawing.Point(428, 387);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(280, 20);
            this.txtRoomNumber.TabIndex = 8;
            this.txtRoomNumber.Text = "Enter Student Room Number\r\n";
            this.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomNumber.Enter += new System.EventHandler(this.RoomNumber_Enter);
            this.txtRoomNumber.Leave += new System.EventHandler(this.RoomNumber_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(428, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnExitFormNewStudent
            // 
            this.btnExitFormNewStudent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExitFormNewStudent.FlatAppearance.BorderSize = 0;
            this.btnExitFormNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormNewStudent.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnExitFormNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormNewStudent.Image")));
            this.btnExitFormNewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitFormNewStudent.Location = new System.Drawing.Point(827, 12);
            this.btnExitFormNewStudent.Name = "btnExitFormNewStudent";
            this.btnExitFormNewStudent.Size = new System.Drawing.Size(36, 34);
            this.btnExitFormNewStudent.TabIndex = 18;
            this.btnExitFormNewStudent.Text = "\r\n";
            this.btnExitFormNewStudent.UseVisualStyleBackColor = false;
            this.btnExitFormNewStudent.Click += new System.EventHandler(this.btnExitFormNewStudent_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(592, 430);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(459, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // FormNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExitFormNewStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewStudent";
            this.Load += new System.EventHandler(this.FormEnrollStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExitFormNewStudent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}