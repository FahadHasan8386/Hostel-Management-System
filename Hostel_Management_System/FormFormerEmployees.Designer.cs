namespace Hostel_Management_System
{
    partial class FormFormerEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormerEmployees));
            this.btnStudentInfoClear = new System.Windows.Forms.Button();
            this.dgvFormerEmployee = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentInfoClear
            // 
            this.btnStudentInfoClear.BackColor = System.Drawing.Color.Black;
            this.btnStudentInfoClear.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfoClear.ForeColor = System.Drawing.Color.White;
            this.btnStudentInfoClear.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentInfoClear.Image")));
            this.btnStudentInfoClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentInfoClear.Location = new System.Drawing.Point(2, 103);
            this.btnStudentInfoClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStudentInfoClear.Name = "btnStudentInfoClear";
            this.btnStudentInfoClear.Size = new System.Drawing.Size(240, 43);
            this.btnStudentInfoClear.TabIndex = 107;
            this.btnStudentInfoClear.Text = "Show Details >>";
            this.btnStudentInfoClear.UseVisualStyleBackColor = false;
            this.btnStudentInfoClear.Click += new System.EventHandler(this.btnStudentInfoClear_Click);
            // 
            // dgvFormerEmployee
            // 
            this.dgvFormerEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormerEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFormerEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormerEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFormerEmployee.Location = new System.Drawing.Point(0, 155);
            this.dgvFormerEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFormerEmployee.Name = "dgvFormerEmployee";
            this.dgvFormerEmployee.RowHeadersWidth = 62;
            this.dgvFormerEmployee.Size = new System.Drawing.Size(1302, 594);
            this.dgvFormerEmployee.TabIndex = 106;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(790, -2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 105;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(366, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 39);
            this.label1.TabIndex = 104;
            this.label1.Text = "Former Employee Details";
            // 
            // FormFormerEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.btnStudentInfoClear);
            this.Controls.Add(this.dgvFormerEmployee);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFormerEmployees";
            this.Text = "FormFormerEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormerEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentInfoClear;
        private System.Windows.Forms.DataGridView dgvFormerEmployee;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}