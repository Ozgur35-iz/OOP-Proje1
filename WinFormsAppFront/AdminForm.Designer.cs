using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnMemberOps = new Button();
            btnClassOps = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.RoyalBlue;
            lblWelcome.Location = new Point(40, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(276, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // btnMemberOps
            // 
            btnMemberOps.BackColor = Color.RoyalBlue;
            btnMemberOps.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMemberOps.ForeColor = Color.White;
            btnMemberOps.Location = new Point(150, 150);
            btnMemberOps.Name = "btnMemberOps";
            btnMemberOps.Size = new Size(300, 150);
            btnMemberOps.TabIndex = 1;
            btnMemberOps.Text = "Member Operations";
            btnMemberOps.UseVisualStyleBackColor = false;
            btnMemberOps.Click += btnMemberOps_Click;
            // 
            // btnClassOps
            // 
            btnClassOps.BackColor = Color.SeaGreen;
            btnClassOps.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClassOps.ForeColor = Color.White;
            btnClassOps.Location = new Point(550, 150);
            btnClassOps.Name = "btnClassOps";
            btnClassOps.Size = new Size(300, 150);
            btnClassOps.TabIndex = 2;
            btnClassOps.Text = "Class Operations";
            btnClassOps.UseVisualStyleBackColor = false;
            btnClassOps.Click += btnClassOps_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.RoyalBlue;
            btnLogout.Location = new Point(40, 500);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 750);
            Controls.Add(btnLogout);
            Controls.Add(btnClassOps);
            Controls.Add(btnMemberOps);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnMemberOps;
        private Button btnClassOps;
        private Button btnLogout;
    }
}