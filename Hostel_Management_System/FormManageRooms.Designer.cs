namespace HostelManagementSystem
{
    partial class FormManageRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageRooms));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.chkRoomStatus = new System.Windows.Forms.CheckBox();
            this.chkRoomBooked = new System.Windows.Forms.CheckBox();
            this.btnSearchByRoomNumber = new System.Windows.Forms.Button();
            this.btnStudentDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRooms = new System.Windows.Forms.Button();
            this.btnStudentInfoUdateRoom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvManageRooms = new System.Windows.Forms.DataGridView();
            this.txtSearchByRoomNumbers = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoomExit = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(376, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Status ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update or Delete Room\r\n";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(30, 115);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(171, 22);
            this.txtRoomNumber.TabIndex = 6;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtRoomNumber_TextChanged);
            // 
            // chkRoomStatus
            // 
            this.chkRoomStatus.AutoSize = true;
            this.chkRoomStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRoomStatus.ForeColor = System.Drawing.Color.Black;
            this.chkRoomStatus.Location = new System.Drawing.Point(482, 120);
            this.chkRoomStatus.Name = "chkRoomStatus";
            this.chkRoomStatus.Size = new System.Drawing.Size(46, 18);
            this.chkRoomStatus.TabIndex = 7;
            this.chkRoomStatus.Text = "Yes\r\n";
            this.chkRoomStatus.UseVisualStyleBackColor = true;
            // 
            // chkRoomBooked
            // 
            this.chkRoomBooked.AutoSize = true;
            this.chkRoomBooked.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRoomBooked.ForeColor = System.Drawing.Color.Black;
            this.chkRoomBooked.Location = new System.Drawing.Point(745, 248);
            this.chkRoomBooked.Name = "chkRoomBooked";
            this.chkRoomBooked.Size = new System.Drawing.Size(46, 18);
            this.chkRoomBooked.TabIndex = 8;
            this.chkRoomBooked.Text = "Yes\r\n";
            this.chkRoomBooked.UseVisualStyleBackColor = true;
            // 
            // btnSearchByRoomNumber
            // 
            this.btnSearchByRoomNumber.BackColor = System.Drawing.Color.Black;
            this.btnSearchByRoomNumber.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByRoomNumber.ForeColor = System.Drawing.Color.White;
            this.btnSearchByRoomNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByRoomNumber.Image")));
            this.btnSearchByRoomNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByRoomNumber.Location = new System.Drawing.Point(235, 242);
            this.btnSearchByRoomNumber.Name = "btnSearchByRoomNumber";
            this.btnSearchByRoomNumber.Size = new System.Drawing.Size(118, 30);
            this.btnSearchByRoomNumber.TabIndex = 10;
            this.btnSearchByRoomNumber.Text = "Search\r\n";
            this.btnSearchByRoomNumber.UseVisualStyleBackColor = false;
            this.btnSearchByRoomNumber.Click += new System.EventHandler(this.btnSearchByRoomNumber_Click);
            // 
            // btnStudentDeleteRoom
            // 
            this.btnStudentDeleteRoom.BackColor = System.Drawing.Color.Black;
            this.btnStudentDeleteRoom.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnStudentDeleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentDeleteRoom.Image")));
            this.btnStudentDeleteRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDeleteRoom.Location = new System.Drawing.Point(508, 240);
            this.btnStudentDeleteRoom.Name = "btnStudentDeleteRoom";
            this.btnStudentDeleteRoom.Size = new System.Drawing.Size(118, 30);
            this.btnStudentDeleteRoom.TabIndex = 11;
            this.btnStudentDeleteRoom.Text = "Delete\r\n\r\n";
            this.btnStudentDeleteRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentDeleteRoom.UseVisualStyleBackColor = false;
            this.btnStudentDeleteRoom.Click += new System.EventHandler(this.btnStudentDeleteRoom_Click);
            // 
            // btnAddRooms
            // 
            this.btnAddRooms.BackColor = System.Drawing.Color.Black;
            this.btnAddRooms.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRooms.ForeColor = System.Drawing.Color.White;
            this.btnAddRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRooms.Image")));
            this.btnAddRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRooms.Location = new System.Drawing.Point(235, 110);
            this.btnAddRooms.Name = "btnAddRooms";
            this.btnAddRooms.Size = new System.Drawing.Size(118, 31);
            this.btnAddRooms.TabIndex = 12;
            this.btnAddRooms.Text = "Add Room";
            this.btnAddRooms.UseVisualStyleBackColor = false;
            this.btnAddRooms.Click += new System.EventHandler(this.btnAddRooms_Click);
            // 
            // btnStudentInfoUdateRoom
            // 
            this.btnStudentInfoUdateRoom.BackColor = System.Drawing.Color.Black;
            this.btnStudentInfoUdateRoom.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfoUdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnStudentInfoUdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentInfoUdateRoom.Image")));
            this.btnStudentInfoUdateRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentInfoUdateRoom.Location = new System.Drawing.Point(369, 242);
            this.btnStudentInfoUdateRoom.Name = "btnStudentInfoUdateRoom";
            this.btnStudentInfoUdateRoom.Size = new System.Drawing.Size(118, 30);
            this.btnStudentInfoUdateRoom.TabIndex = 13;
            this.btnStudentInfoUdateRoom.Text = "Update\r\n\r\n";
            this.btnStudentInfoUdateRoom.UseVisualStyleBackColor = false;
            this.btnStudentInfoUdateRoom.Click += new System.EventHandler(this.btnStudentInfoUdateRoom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(643, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room Status";
            // 
            // dgvManageRooms
            // 
            this.dgvManageRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(130)))), ((int)(((byte)(106)))));
            this.dgvManageRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvManageRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvManageRooms.Location = new System.Drawing.Point(0, 353);
            this.dgvManageRooms.Name = "dgvManageRooms";
            this.dgvManageRooms.RowHeadersWidth = 51;
            this.dgvManageRooms.Size = new System.Drawing.Size(878, 159);
            this.dgvManageRooms.TabIndex = 15;
            // 
            // txtSearchByRoomNumbers
            // 
            this.txtSearchByRoomNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByRoomNumbers.Location = new System.Drawing.Point(28, 244);
            this.txtSearchByRoomNumbers.Multiline = true;
            this.txtSearchByRoomNumbers.Name = "txtSearchByRoomNumbers";
            this.txtSearchByRoomNumbers.Size = new System.Drawing.Size(173, 24);
            this.txtSearchByRoomNumbers.TabIndex = 16;
            this.txtSearchByRoomNumbers.Text = "Search By Room Number";
            this.txtSearchByRoomNumbers.Enter += new System.EventHandler(this.btnExitFormManageRooms_Enter);
            this.txtSearchByRoomNumbers.Leave += new System.EventHandler(this.btnExitFormManageRooms_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room Number";
            // 
            // lblRoomExit
            // 
            this.lblRoomExit.AutoSize = true;
            this.lblRoomExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomExit.ForeColor = System.Drawing.Color.Black;
            this.lblRoomExit.Location = new System.Drawing.Point(61, 149);
            this.lblRoomExit.Name = "lblRoomExit";
            this.lblRoomExit.Size = new System.Drawing.Size(59, 16);
            this.lblRoomExit.TabIndex = 18;
            this.lblRoomExit.Text = "Set Text";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Black;
            this.lblRoom.Location = new System.Drawing.Point(61, 284);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(59, 16);
            this.lblRoom.TabIndex = 19;
            this.lblRoom.Text = "Set Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(365, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "All Rooms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(282, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 106;
            this.label9.Text = "Manage Rooms";
            // 
            // FormManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblRoomExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchByRoomNumbers);
            this.Controls.Add(this.dgvManageRooms);
            this.Controls.Add(this.btnStudentInfoUdateRoom);
            this.Controls.Add(this.btnAddRooms);
            this.Controls.Add(this.btnStudentDeleteRoom);
            this.Controls.Add(this.btnSearchByRoomNumber);
            this.Controls.Add(this.chkRoomBooked);
            this.Controls.Add(this.chkRoomStatus);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Rooms";
            this.Load += new System.EventHandler(this.FormManageRooms_Load);
            this.Leave += new System.EventHandler(this.FormManageRooms_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.CheckBox chkRoomStatus;
        private System.Windows.Forms.CheckBox chkRoomBooked;
        private System.Windows.Forms.Button btnSearchByRoomNumber;
        private System.Windows.Forms.Button btnStudentDeleteRoom;
        private System.Windows.Forms.Button btnAddRooms;
        private System.Windows.Forms.Button btnStudentInfoUdateRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvManageRooms;
        private System.Windows.Forms.TextBox txtSearchByRoomNumbers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoomExit;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}