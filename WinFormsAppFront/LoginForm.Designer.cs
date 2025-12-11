namespace WinFormsAppFront
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblPassword = new Label();
            txtTc = new TextBox();
            txtPassword = new TextBox();
            btnMemberLogin = new Button();
            btnAdminLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            lblTc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassword.ForeColor = Color.RoyalBlue;
            lblPassword.Location = new Point(279, 510);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 26);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtTc
            // 
            txtTc.BorderStyle = BorderStyle.None;
            txtTc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTc.ForeColor = Color.RoyalBlue;
            txtTc.Location = new Point(420, 426);
            txtTc.Margin = new Padding(4, 5, 4, 5);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(371, 21);
            txtTc.TabIndex = 2;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtPassword.ForeColor = Color.RoyalBlue;
            txtPassword.Location = new Point(414, 512);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(380, 21);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnMemberLogin
            // 
            btnMemberLogin.BackColor = Color.RoyalBlue;
            btnMemberLogin.FlatStyle = FlatStyle.Flat;
            btnMemberLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMemberLogin.ForeColor = Color.White;
            btnMemberLogin.Location = new Point(214, 619);
            btnMemberLogin.Margin = new Padding(4, 5, 4, 5);
            btnMemberLogin.Name = "btnMemberLogin";
            btnMemberLogin.Size = new Size(259, 56);
            btnMemberLogin.TabIndex = 4;
            btnMemberLogin.Text = "Member Login";
            btnMemberLogin.UseVisualStyleBackColor = false;
            btnMemberLogin.Click += btnMemberLogin_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.RoyalBlue;
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(520, 619);
            btnAdminLogin.Margin = new Padding(4, 5, 4, 5);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(276, 56);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(210, 410);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(298, 313);
            label1.Name = "label1";
            label1.Size = new Size(414, 57);
            label1.TabIndex = 8;
            label1.Text = "Success is a decision";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.ForeColor = Color.RoyalBlue;
            panel1.Location = new Point(214, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 2);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(210, 500);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.ForeColor = Color.RoyalBlue;
            panel2.Location = new Point(214, 557);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 2);
            panel2.TabIndex = 9;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTc.ForeColor = Color.RoyalBlue;
            lblTc.Location = new Point(279, 424);
            lblTc.Margin = new Padding(4, 0, 4, 0);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(132, 26);
            lblTc.TabIndex = 0;
            lblTc.Text = "UserName:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1028, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnMemberLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtTc);
            Controls.Add(lblPassword);
            Controls.Add(lblTc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            BackColorChanged += white;
            Paint += LoginForm_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private TextBox txtTc;
        private TextBox txtPassword;
        private Button btnMemberLogin;
        private Button btnAdminLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label lblTc;
    }
}
