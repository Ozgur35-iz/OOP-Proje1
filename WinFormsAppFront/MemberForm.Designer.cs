namespace WinFormsAppFront
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            lblWelcome = new Label();
            lblPackage = new Label();
            lblEndDate = new Label();
            lstMyLessons = new ListBox();
            btnCatalog = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.RoyalBlue;
            lblWelcome.Location = new Point(347, 49);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(257, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Üye Adı";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblPackage.ForeColor = Color.RoyalBlue;
            lblPackage.Location = new Point(217, 107);
            lblPackage.Margin = new Padding(4, 0, 4, 0);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(162, 26);
            lblPackage.TabIndex = 1;
            lblPackage.Text = "Membership: ...";
            lblPackage.Click += lblPackage_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblEndDate.ForeColor = Color.RoyalBlue;
            lblEndDate.Location = new Point(564, 107);
            lblEndDate.Margin = new Padding(4, 0, 4, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(155, 26);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "Expiry Date: ...";
            // 
            // lstMyLessons
            // 
            lstMyLessons.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lstMyLessons.ForeColor = Color.DimGray;
            lstMyLessons.FormattingEnabled = true;
            lstMyLessons.Location = new Point(260, 203);
            lstMyLessons.Margin = new Padding(4, 5, 4, 5);
            lstMyLessons.Name = "lstMyLessons";
            lstMyLessons.Size = new Size(498, 228);
            lstMyLessons.TabIndex = 3;
            // 
            // btnCatalog
            // 
            btnCatalog.BackColor = Color.DodgerBlue;
            btnCatalog.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatalog.ForeColor = Color.White;
            btnCatalog.Location = new Point(343, 483);
            btnCatalog.Margin = new Padding(4, 5, 4, 5);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new Size(314, 75);
            btnCatalog.TabIndex = 4;
            btnCatalog.Text = "Catalog of Group Classes";
            btnCatalog.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogout.ForeColor = Color.RoyalBlue;
            btnLogout.Location = new Point(428, 612);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 39);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(875, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.indir__3_1;
            ClientSize = new Size(1028, 750);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnCatalog);
            Controls.Add(lstMyLessons);
            Controls.Add(lblEndDate);
            Controls.Add(lblPackage);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblPackage;
        private Label lblEndDate;
        private ListBox lstMyLessons;
        private Button btnCatalog;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}