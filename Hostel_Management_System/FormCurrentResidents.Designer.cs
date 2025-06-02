namespace Hostel_Management_System
{
    partial class FormCurrentResidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrentResidents));
            this.btnExitFormCurrentResidents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitFormCurrentResidents
            // 
            this.btnExitFormCurrentResidents.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExitFormCurrentResidents.FlatAppearance.BorderSize = 0;
            this.btnExitFormCurrentResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormCurrentResidents.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormCurrentResidents.ForeColor = System.Drawing.Color.White;
            this.btnExitFormCurrentResidents.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormCurrentResidents.Image")));
            this.btnExitFormCurrentResidents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitFormCurrentResidents.Location = new System.Drawing.Point(827, 12);
            this.btnExitFormCurrentResidents.Name = "btnExitFormCurrentResidents";
            this.btnExitFormCurrentResidents.Size = new System.Drawing.Size(36, 34);
            this.btnExitFormCurrentResidents.TabIndex = 20;
            this.btnExitFormCurrentResidents.Text = "\r\n";
            this.btnExitFormCurrentResidents.UseVisualStyleBackColor = false;
            this.btnExitFormCurrentResidents.Click += new System.EventHandler(this.btnExitFormCurrentResidents_Click);
            // 
            // FormCurrentResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.btnExitFormCurrentResidents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCurrentResidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCurrentResidents";
            this.Load += new System.EventHandler(this.FormCurrentResidents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitFormCurrentResidents;
    }
}