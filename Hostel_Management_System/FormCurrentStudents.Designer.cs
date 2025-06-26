namespace Hostel_Management_System
{
    partial class FormCurrentStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrentStudents));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCurrentStudent = new System.Windows.Forms.DataGridView();
            this.btnCrntShowDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(526, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Current Student Details";
            // 
            // dgvCurrentStudent
            // 
            this.dgvCurrentStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(130)))), ((int)(((byte)(106)))));
            this.dgvCurrentStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCurrentStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCurrentStudent.Location = new System.Drawing.Point(0, 126);
            this.dgvCurrentStudent.Name = "dgvCurrentStudent";
            this.dgvCurrentStudent.Size = new System.Drawing.Size(878, 386);
            this.dgvCurrentStudent.TabIndex = 96;
            // 
            // btnCrntShowDetails
            // 
            this.btnCrntShowDetails.BackColor = System.Drawing.Color.Black;
            this.btnCrntShowDetails.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrntShowDetails.ForeColor = System.Drawing.Color.White;
            this.btnCrntShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCrntShowDetails.Image")));
            this.btnCrntShowDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrntShowDetails.Location = new System.Drawing.Point(6, 91);
            this.btnCrntShowDetails.Name = "btnCrntShowDetails";
            this.btnCrntShowDetails.Size = new System.Drawing.Size(160, 26);
            this.btnCrntShowDetails.TabIndex = 99;
            this.btnCrntShowDetails.Text = "Show Details >>";
            this.btnCrntShowDetails.UseVisualStyleBackColor = false;
            this.btnCrntShowDetails.Click += new System.EventHandler(this.btnCrntShowDetails_Click);
            // 
            // FormCurrentStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.btnCrntShowDetails);
            this.Controls.Add(this.dgvCurrentStudent);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCurrentStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCurrentResidents";
            this.Load += new System.EventHandler(this.FormCurrentResidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCurrentStudent;
        private System.Windows.Forms.Button btnCrntShowDetails;
    }
}