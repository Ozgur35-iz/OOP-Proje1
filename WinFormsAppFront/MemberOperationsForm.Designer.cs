using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    partial class MemberOperationsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpAdd = new GroupBox();
            cmbMembershipType = new ComboBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtSurname = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnAddMember = new Button();
            grpRemove = new GroupBox();
            btnRemoveMember = new Button();
            txtRemovePass = new TextBox();
            label6 = new Label();
            txtRemoveTc = new TextBox();
            label7 = new Label();
            btnBack = new Button();
            grpAdd.SuspendLayout();
            grpRemove.SuspendLayout();
            SuspendLayout();
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(cmbMembershipType);
            grpAdd.Controls.Add(label5);
            grpAdd.Controls.Add(txtPassword);
            grpAdd.Controls.Add(label4);
            grpAdd.Controls.Add(txtUsername);
            grpAdd.Controls.Add(label3);
            grpAdd.Controls.Add(txtSurname);
            grpAdd.Controls.Add(label2);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(label1);
            grpAdd.Controls.Add(btnAddMember);
            grpAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpAdd.ForeColor = Color.RoyalBlue;
            grpAdd.Location = new Point(20, 20);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(400, 500);
            grpAdd.TabIndex = 0;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add New Member";
            // 
            // cmbMembershipType
            // 
            cmbMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembershipType.Location = new Point(130, 247);
            cmbMembershipType.Name = "cmbMembershipType";
            cmbMembershipType.Size = new Size(240, 36);
            cmbMembershipType.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 250);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 1;
            label5.Text = "Type:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 34);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 200);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 147);
            txtUsername.MaxLength = 11;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 34);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(130, 97);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(240, 34);
            txtSurname.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 7;
            label2.Text = "Surname:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 34);
            txtName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.RoyalBlue;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(130, 320);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(240, 50);
            btnAddMember.TabIndex = 10;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // grpRemove
            // 
            grpRemove.Controls.Add(btnRemoveMember);
            grpRemove.Controls.Add(txtRemovePass);
            grpRemove.Controls.Add(label6);
            grpRemove.Controls.Add(txtRemoveTc);
            grpRemove.Controls.Add(label7);
            grpRemove.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRemove.ForeColor = Color.Crimson;
            grpRemove.Location = new Point(450, 20);
            grpRemove.Name = "grpRemove";
            grpRemove.Size = new Size(400, 300);
            grpRemove.TabIndex = 1;
            grpRemove.TabStop = false;
            grpRemove.Text = "Remove Member";
            // 
            // btnRemoveMember
            // 
            btnRemoveMember.BackColor = Color.Crimson;
            btnRemoveMember.FlatStyle = FlatStyle.Flat;
            btnRemoveMember.ForeColor = Color.White;
            btnRemoveMember.Location = new Point(130, 160);
            btnRemoveMember.Name = "btnRemoveMember";
            btnRemoveMember.Size = new Size(240, 50);
            btnRemoveMember.TabIndex = 0;
            btnRemoveMember.Text = "Remove Member";
            btnRemoveMember.UseVisualStyleBackColor = false;
            btnRemoveMember.Click += btnRemoveMember_Click;
            // 
            // txtRemovePass
            // 
            txtRemovePass.Location = new Point(130, 97);
            txtRemovePass.Name = "txtRemovePass";
            txtRemovePass.Size = new Size(240, 34);
            txtRemovePass.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 100);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 2;
            label6.Text = "Password:";
            // 
            // txtRemoveTc
            // 
            txtRemoveTc.Location = new Point(130, 47);
            txtRemoveTc.MaxLength = 11;
            txtRemoveTc.Name = "txtRemoveTc";
            txtRemoveTc.Size = new Size(240, 34);
            txtRemoveTc.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 50);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 4;
            label7.Text = "Username:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(450, 450);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MemberOperationsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 750);
            Controls.Add(btnBack);
            Controls.Add(grpRemove);
            Controls.Add(grpAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MemberOperationsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Member Operations";
            Load += MemberOperationsForm_Load;
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            grpRemove.ResumeLayout(false);
            grpRemove.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox grpAdd;
        private TextBox txtName; private Label label1;
        private TextBox txtSurname; private Label label2;
        private TextBox txtUsername; private Label label3;
        private TextBox txtPassword; private Label label4;
        private ComboBox cmbMembershipType; private Label label5;
        private Button btnAddMember;

        private GroupBox grpRemove;
        private TextBox txtRemoveTc; private Label label7;
        private TextBox txtRemovePass; private Label label6;
        private Button btnRemoveMember;

        private Button btnBack; // Tanımlama
    }
}