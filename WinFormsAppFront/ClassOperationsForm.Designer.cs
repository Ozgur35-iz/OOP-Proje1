using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    partial class ClassOperationsForm
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
            btnAdd = new Button();
            numQuota = new NumericUpDown();
            label7 = new Label();
            txtTime = new TextBox();
            label6 = new Label();
            cmbDay = new ComboBox();
            label5 = new Label();
            txtStudio = new TextBox();
            label4 = new Label();
            txtCoach = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            grpRemove = new GroupBox();
            btnRemove = new Button();
            cmbClassList = new ComboBox();
            label8 = new Label();
            btnBack = new Button();
            grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuota).BeginInit();
            grpRemove.SuspendLayout();
            SuspendLayout();
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Controls.Add(numQuota);
            grpAdd.Controls.Add(label7);
            grpAdd.Controls.Add(txtTime);
            grpAdd.Controls.Add(label6);
            grpAdd.Controls.Add(cmbDay);
            grpAdd.Controls.Add(label5);
            grpAdd.Controls.Add(txtStudio);
            grpAdd.Controls.Add(label4);
            grpAdd.Controls.Add(txtCoach);
            grpAdd.Controls.Add(label3);
            grpAdd.Controls.Add(cmbCategory);
            grpAdd.Controls.Add(label2);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(label1);
            grpAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpAdd.ForeColor = Color.RoyalBlue;
            grpAdd.Location = new Point(20, 20);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(400, 520);
            grpAdd.TabIndex = 0;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add New Class";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(140, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(240, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Class";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numQuota
            // 
            numQuota.Location = new Point(140, 337);
            numQuota.Name = "numQuota";
            numQuota.Size = new Size(240, 34);
            numQuota.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 340);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 2;
            label7.Text = "Quota:";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(140, 287);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(240, 34);
            txtTime.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 290);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 4;
            label6.Text = "Time (HH:mm):";
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbDay.Location = new Point(140, 237);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(240, 36);
            cmbDay.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 240);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 6;
            label5.Text = "Day:";
            // 
            // txtStudio
            // 
            txtStudio.Location = new Point(140, 187);
            txtStudio.Name = "txtStudio";
            txtStudio.Size = new Size(240, 34);
            txtStudio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 8;
            label4.Text = "Studio:";
            // 
            // txtCoach
            // 
            txtCoach.Location = new Point(140, 137);
            txtCoach.Name = "txtCoach";
            txtCoach.Size = new Size(240, 34);
            txtCoach.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 10;
            label3.Text = "Coach:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(140, 87);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(240, 36);
            cmbCategory.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 12;
            label2.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 34);
            txtName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 14;
            label1.Text = "Class Name:";
            // 
            // grpRemove
            // 
            grpRemove.Controls.Add(btnRemove);
            grpRemove.Controls.Add(cmbClassList);
            grpRemove.Controls.Add(label8);
            grpRemove.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRemove.ForeColor = Color.Crimson;
            grpRemove.Location = new Point(450, 20);
            grpRemove.Name = "grpRemove";
            grpRemove.Size = new Size(400, 250);
            grpRemove.TabIndex = 1;
            grpRemove.TabStop = false;
            grpRemove.Text = "Remove Class";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(140, 120);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(240, 50);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbClassList
            // 
            cmbClassList.DropDownHeight = 150;
            cmbClassList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassList.IntegralHeight = false;
            cmbClassList.Location = new Point(140, 57);
            cmbClassList.Name = "cmbClassList";
            cmbClassList.Size = new Size(240, 36);
            cmbClassList.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 60);
            label8.Name = "label8";
            label8.Size = new Size(122, 28);
            label8.TabIndex = 2;
            label8.Text = "Select Class:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(450, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ClassOperationsForm
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
            Name = "ClassOperationsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Class Operations";
            Load += ClassOperationsForm_Load;
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuota).EndInit();
            grpRemove.ResumeLayout(false);
            grpRemove.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox grpAdd;
        private TextBox txtName; private Label label1;
        private ComboBox cmbCategory; private Label label2;
        private TextBox txtCoach; private Label label3;
        private TextBox txtStudio; private Label label4;
        private ComboBox cmbDay; private Label label5;
        private TextBox txtTime; private Label label6;
        private NumericUpDown numQuota; private Label label7;
        private Button btnAdd;

        private GroupBox grpRemove;
        private Label label8;
        private ComboBox cmbClassList;
        private Button btnRemove;

        private Button btnBack;
    }
}