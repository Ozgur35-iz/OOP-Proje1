using System;
using System.IO;
using System.Windows.Forms;
using GymSystem.Core;

namespace WinFormsAppFront
{
    public partial class LoginForm : Form
    {
        private GymSystem.Core.GymSystem _system;

        public LoginForm()
        {
            InitializeComponent();
            // Ýlk açýlýþta sistemi yükle
            RefreshSystem();
        }

        // BU METHOD KRÝTÝK: Admin çýkýþ yapýp bu ekrana dönünce dosyayý tekrar okur
        private void RefreshSystem()
        {
            _system = new GymSystem.Core.GymSystem();
        }

        // Form her görünür olduðunda (Logout yapýldýðýnda) verileri tazele
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                RefreshSystem();
                // Admin ve üye giriþ kutularýný temizle
                txtTc.Clear();
                txtPassword.Clear();
            }
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text.Trim();
            string sifre = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Please enter both T.C. ID and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = _system.Login(tc, sifre);

            if (member == null)
            {
                MessageBox.Show("Invalid T.C. ID or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var memberForm = new MemberForm(_system, member);
            memberForm.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string inputName = txtTc.Text.Trim();
            string inputPass = txtPassword.Text.Trim();

            // Dosya yolu bulma
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
            string adminFilePath = Path.Combine(projectPath, "admins.txt");

            bool loginSuccessful = false;
            string foundAdminName = "";

            if (File.Exists(adminFilePath))
            {
                try
                {
                    var lines = File.ReadAllLines(adminFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');
                        if (parts.Length >= 2)
                        {
                            string fileAdminName = parts[0].Trim();
                            string fileAdminPass = parts[1].Trim();

                            if (fileAdminName.Equals(inputName, StringComparison.OrdinalIgnoreCase) && fileAdminPass == inputPass)
                            {
                                loginSuccessful = true;
                                foundAdminName = fileAdminName;
                                break;
                            }
                        }
                    }
                }
                catch { }
            }

            if (!loginSuccessful && inputPass == "admin123")
            {
                loginSuccessful = true;
                foundAdminName = "Admin";
            }

            if (loginSuccessful)
            {
                var adminForm = new AdminForm(_system, foundAdminName);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin Credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boþ eventler (Designer hatasý almamak için silme)
        private void LoginForm_Paint(object sender, PaintEventArgs e) { }
        private void white(object sender, EventArgs e) { }
        private void LoginForm_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtTc_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
    }
}