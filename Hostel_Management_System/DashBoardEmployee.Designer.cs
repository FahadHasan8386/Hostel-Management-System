namespace Hostel_Management_System
{
    partial class DashBoardEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ManageRoomEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_LogOutEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation Bar";
            // 
            // btn_ManageRoomEmployee
            // 
            this.btn_ManageRoomEmployee.Location = new System.Drawing.Point(13, 91);
            this.btn_ManageRoomEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ManageRoomEmployee.Name = "btn_ManageRoomEmployee";
            this.btn_ManageRoomEmployee.Size = new System.Drawing.Size(362, 63);
            this.btn_ManageRoomEmployee.TabIndex = 1;
            this.btn_ManageRoomEmployee.Text = "Manage Room";
            this.btn_ManageRoomEmployee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(362, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_LogOutEmployee
            // 
            this.btn_LogOutEmployee.Location = new System.Drawing.Point(617, 68);
            this.btn_LogOutEmployee.Name = "btn_LogOutEmployee";
            this.btn_LogOutEmployee.Size = new System.Drawing.Size(362, 63);
            this.btn_LogOutEmployee.TabIndex = 4;
            this.btn_LogOutEmployee.Text = "Logout";
            this.btn_LogOutEmployee.UseVisualStyleBackColor = true;
            // 
            // DashBoardEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.btn_LogOutEmployee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ManageRoomEmployee);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ManageRoomEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_LogOutEmployee;
    }
}