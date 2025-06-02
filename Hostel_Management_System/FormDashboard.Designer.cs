namespace HostelManagementSystem
{
    partial class FormDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.btnCurrentResidents = new System.Windows.Forms.Button();
            this.btnFormerResidents = new System.Windows.Forms.Button();
            this.btnManageStudentInfo = new System.Windows.Forms.Button();
            this.btnStudentPayment = new System.Windows.Forms.Button();
            this.btnEnrollStudent = new System.Windows.Forms.Button();
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.lbl_navigation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHms = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tmrHms = new System.Windows.Forms.Timer(this.components);
            this.picHostelLogo = new System.Windows.Forms.PictureBox();
            this.tmrHostelLogo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHostelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurrentResidents
            // 
            this.btnCurrentResidents.FlatAppearance.BorderSize = 0;
            this.btnCurrentResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnCurrentResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCurrentResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentResidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentResidents.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentResidents.Image")));
            this.btnCurrentResidents.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCurrentResidents.Location = new System.Drawing.Point(10, 535);
            this.btnCurrentResidents.Name = "btnCurrentResidents";
            this.btnCurrentResidents.Size = new System.Drawing.Size(243, 42);
            this.btnCurrentResidents.TabIndex = 7;
            this.btnCurrentResidents.Text = "Current Residents";
            this.btnCurrentResidents.UseVisualStyleBackColor = true;
            this.btnCurrentResidents.Click += new System.EventHandler(this.btnCurrentResidents_Click);
            // 
            // btnFormerResidents
            // 
            this.btnFormerResidents.FlatAppearance.BorderSize = 0;
            this.btnFormerResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnFormerResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFormerResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormerResidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormerResidents.Image = ((System.Drawing.Image)(resources.GetObject("btnFormerResidents.Image")));
            this.btnFormerResidents.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFormerResidents.Location = new System.Drawing.Point(10, 612);
            this.btnFormerResidents.Name = "btnFormerResidents";
            this.btnFormerResidents.Size = new System.Drawing.Size(241, 44);
            this.btnFormerResidents.TabIndex = 6;
            this.btnFormerResidents.Text = "Former Residents\r\n";
            this.btnFormerResidents.UseVisualStyleBackColor = true;
            this.btnFormerResidents.Click += new System.EventHandler(this.btnFormerResidents_Click);
            // 
            // btnManageStudentInfo
            // 
            this.btnManageStudentInfo.FlatAppearance.BorderSize = 0;
            this.btnManageStudentInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnManageStudentInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStudentInfo.Image")));
            this.btnManageStudentInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudentInfo.Location = new System.Drawing.Point(10, 364);
            this.btnManageStudentInfo.Name = "btnManageStudentInfo";
            this.btnManageStudentInfo.Size = new System.Drawing.Size(241, 40);
            this.btnManageStudentInfo.TabIndex = 3;
            this.btnManageStudentInfo.Text = "Manage Student Info\r\n";
            this.btnManageStudentInfo.UseVisualStyleBackColor = true;
            this.btnManageStudentInfo.Click += new System.EventHandler(this.btnManageStudentInfo_Click);
            // 
            // btnStudentPayment
            // 
            this.btnStudentPayment.FlatAppearance.BorderSize = 0;
            this.btnStudentPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnStudentPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStudentPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentPayment.Image")));
            this.btnStudentPayment.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStudentPayment.Location = new System.Drawing.Point(10, 454);
            this.btnStudentPayment.Name = "btnStudentPayment";
            this.btnStudentPayment.Size = new System.Drawing.Size(241, 43);
            this.btnStudentPayment.TabIndex = 2;
            this.btnStudentPayment.Text = "Student  Payment";
            this.btnStudentPayment.UseVisualStyleBackColor = true;
            this.btnStudentPayment.Click += new System.EventHandler(this.btnStudentPayment_Click);
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.FlatAppearance.BorderSize = 0;
            this.btnEnrollStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnEnrollStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnrollStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnrollStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrollStudent.Image")));
            this.btnEnrollStudent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEnrollStudent.Location = new System.Drawing.Point(10, 284);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.Size = new System.Drawing.Size(241, 37);
            this.btnEnrollStudent.TabIndex = 1;
            this.btnEnrollStudent.Text = "New Student";
            this.btnEnrollStudent.UseVisualStyleBackColor = true;
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnManageRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRoom.Image")));
            this.btnManageRoom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManageRoom.Location = new System.Drawing.Point(10, 197);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(241, 41);
            this.btnManageRoom.TabIndex = 0;
            this.btnManageRoom.Text = "Manage Rooms";
            this.btnManageRoom.UseVisualStyleBackColor = true;
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // lbl_navigation
            // 
            this.lbl_navigation.AutoSize = true;
            this.lbl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_navigation.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_navigation.ForeColor = System.Drawing.Color.White;
            this.lbl_navigation.Location = new System.Drawing.Point(12, 11);
            this.lbl_navigation.Name = "lbl_navigation";
            this.lbl_navigation.Size = new System.Drawing.Size(207, 34);
            this.lbl_navigation.TabIndex = 4;
            this.lbl_navigation.Text = "NAVIGTION BAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblHms
            // 
            this.lblHms.AutoSize = true;
            this.lblHms.Font = new System.Drawing.Font("Cambria", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHms.ForeColor = System.Drawing.Color.White;
            this.lblHms.Location = new System.Drawing.Point(548, 15);
            this.lblHms.Name = "lblHms";
            this.lblHms.Size = new System.Drawing.Size(448, 41);
            this.lblHms.TabIndex = 9;
            this.lblHms.Text = "Hostel Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1315, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "\r\n";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1174, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 30);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tmrHms
            // 
            this.tmrHms.Enabled = true;
            this.tmrHms.Interval = 1000;
            this.tmrHms.Tick += new System.EventHandler(this.tmrHms_Tick);
            // 
            // picHostelLogo
            // 
            this.picHostelLogo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.picHostelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHostelLogo.Image = ((System.Drawing.Image)(resources.GetObject("picHostelLogo.Image")));
            this.picHostelLogo.Location = new System.Drawing.Point(12, 64);
            this.picHostelLogo.Name = "picHostelLogo";
            this.picHostelLogo.Size = new System.Drawing.Size(207, 94);
            this.picHostelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHostelLogo.TabIndex = 20;
            this.picHostelLogo.TabStop = false;
            this.picHostelLogo.Click += new System.EventHandler(this.picHostelLogo_Click);
            // 
            // tmrHostelLogo
            // 
            this.tmrHostelLogo.Interval = 1000;
            this.tmrHostelLogo.Tick += new System.EventHandler(this.tmrHostelLogo_Tick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1363, 723);
            this.Controls.Add(this.picHostelLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStudentPayment);
            this.Controls.Add(this.btnManageStudentInfo);
            this.Controls.Add(this.btnFormerResidents);
            this.Controls.Add(this.btnCurrentResidents);
            this.Controls.Add(this.lbl_navigation);
            this.Controls.Add(this.btnManageRoom);
            this.Controls.Add(this.btnEnrollStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHostelLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_navigation;
        private System.Windows.Forms.Button btnCurrentResidents;
        private System.Windows.Forms.Button btnFormerResidents;
        private System.Windows.Forms.Button btnManageStudentInfo;
        private System.Windows.Forms.Button btnStudentPayment;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.Button btnManageRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHms;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer tmrHms;
        private System.Windows.Forms.PictureBox picHostelLogo;
        private System.Windows.Forms.Timer tmrHostelLogo;
    }
}