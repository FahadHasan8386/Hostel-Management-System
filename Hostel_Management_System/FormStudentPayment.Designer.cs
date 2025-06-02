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
            this.btnExitFormStudentPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitFormStudentPayment
            // 
            this.btnExitFormStudentPayment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExitFormStudentPayment.FlatAppearance.BorderSize = 0;
            this.btnExitFormStudentPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormStudentPayment.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormStudentPayment.ForeColor = System.Drawing.Color.White;
            this.btnExitFormStudentPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormStudentPayment.Image")));
            this.btnExitFormStudentPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitFormStudentPayment.Location = new System.Drawing.Point(827, 12);
            this.btnExitFormStudentPayment.Name = "btnExitFormStudentPayment";
            this.btnExitFormStudentPayment.Size = new System.Drawing.Size(36, 34);
            this.btnExitFormStudentPayment.TabIndex = 19;
            this.btnExitFormStudentPayment.Text = "\r\n";
            this.btnExitFormStudentPayment.UseVisualStyleBackColor = false;
            this.btnExitFormStudentPayment.Click += new System.EventHandler(this.btnExitFormStudentPayment_Click);
            // 
            // FormStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.btnExitFormStudentPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudentPayment";
            this.Load += new System.EventHandler(this.FormStudentPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitFormStudentPayment;
    }
}