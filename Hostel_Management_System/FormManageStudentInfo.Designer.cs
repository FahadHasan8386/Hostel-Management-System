namespace Hostel_Management_System
{
    partial class FormManageStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageStudentInfo));
            this.btnExitFormManageStudentInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitFormManageStudentInfo
            // 
            this.btnExitFormManageStudentInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExitFormManageStudentInfo.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageStudentInfo.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageStudentInfo.Image")));
            this.btnExitFormManageStudentInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitFormManageStudentInfo.Location = new System.Drawing.Point(827, 12);
            this.btnExitFormManageStudentInfo.Name = "btnExitFormManageStudentInfo";
            this.btnExitFormManageStudentInfo.Size = new System.Drawing.Size(36, 34);
            this.btnExitFormManageStudentInfo.TabIndex = 18;
            this.btnExitFormManageStudentInfo.Text = "\r\n";
            this.btnExitFormManageStudentInfo.UseVisualStyleBackColor = false;
            this.btnExitFormManageStudentInfo.Click += new System.EventHandler(this.btnExitFormManageStudentInfo_Click);
            // 
            // FormManageStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.btnExitFormManageStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageStudentInfo";
            this.Load += new System.EventHandler(this.FormManageStudentInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitFormManageStudentInfo;
    }
}