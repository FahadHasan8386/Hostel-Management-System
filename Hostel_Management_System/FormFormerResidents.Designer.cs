namespace Hostel_Management_System
{
    partial class FormFormerResidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormerResidents));
            this.btnExitFormFormerResidents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitFormFormerResidents
            // 
            this.btnExitFormFormerResidents.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExitFormFormerResidents.FlatAppearance.BorderSize = 0;
            this.btnExitFormFormerResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormFormerResidents.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormFormerResidents.ForeColor = System.Drawing.Color.White;
            this.btnExitFormFormerResidents.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormFormerResidents.Image")));
            this.btnExitFormFormerResidents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitFormFormerResidents.Location = new System.Drawing.Point(827, 12);
            this.btnExitFormFormerResidents.Name = "btnExitFormFormerResidents";
            this.btnExitFormFormerResidents.Size = new System.Drawing.Size(36, 34);
            this.btnExitFormFormerResidents.TabIndex = 20;
            this.btnExitFormFormerResidents.Text = "\r\n";
            this.btnExitFormFormerResidents.UseVisualStyleBackColor = false;
            this.btnExitFormFormerResidents.Click += new System.EventHandler(this.btnExitFormFormerResidents_Click);
            // 
            // FormFormerResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.btnExitFormFormerResidents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFormerResidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFormerResidents";
            this.Load += new System.EventHandler(this.FormFormerResidents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitFormFormerResidents;
    }
}