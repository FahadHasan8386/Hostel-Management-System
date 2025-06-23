namespace Hostel_Management_System
{
    partial class FormFormerStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormerStudents));
            this.btnFrmShowDetails = new System.Windows.Forms.Button();
            this.dgvFormerStudent = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmShowDetails
            // 
            this.btnFrmShowDetails.BackColor = System.Drawing.Color.Black;
            this.btnFrmShowDetails.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmShowDetails.ForeColor = System.Drawing.Color.White;
            this.btnFrmShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmShowDetails.Image")));
            this.btnFrmShowDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmShowDetails.Location = new System.Drawing.Point(0, 86);
            this.btnFrmShowDetails.Name = "btnFrmShowDetails";
            this.btnFrmShowDetails.Size = new System.Drawing.Size(160, 34);
            this.btnFrmShowDetails.TabIndex = 103;
            this.btnFrmShowDetails.Text = "Show Details >>";
            this.btnFrmShowDetails.UseVisualStyleBackColor = false;
            // 
            // dgvFormerStudent
            // 
            this.dgvFormerStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFormerStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormerStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFormerStudent.Location = new System.Drawing.Point(0, 126);
            this.dgvFormerStudent.Name = "dgvFormerStudent";
            this.dgvFormerStudent.Size = new System.Drawing.Size(878, 386);
            this.dgvFormerStudent.TabIndex = 102;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(520, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 101;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(256, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 100;
            this.label1.Text = "Former Student Details";
            // 
            // FormFormerStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.btnFrmShowDetails);
            this.Controls.Add(this.dgvFormerStudent);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFormerStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFormerResidents";
            this.Load += new System.EventHandler(this.FormFormerResidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmShowDetails;
        private System.Windows.Forms.DataGridView dgvFormerStudent;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}