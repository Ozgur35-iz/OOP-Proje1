using System;
using System.Windows.Forms;
using GymSystem.Core;

namespace WinFormsAppFront   // sende neyse aynen kalsýn
{
    public partial class LoginForm : Form
    {
        private GymSystem.Core.GymSystem _system;

        public LoginForm()
        {
            InitializeComponent();
            _system = new GymSystem.Core.GymSystem();
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text.Trim();
            string sifre = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Please enter both T.C. ID and password.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = _system.Login(tc, sifre);

            if (member == null)
            {
                MessageBox.Show("Invalid T.C. ID or password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var memberForm = new MemberForm(_system, member);
            memberForm.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtTc.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Alanlar boþ býrakýlamaz!");
                return;
            }

            if (!File.Exists("admins.txt"))
            {
                MessageBox.Show("admins.txt bulunamadý!");
                return;
            }

            string[] admins = File.ReadAllLines("admins.txt");

            foreach (string admin in admins)
            {
                string[] data = admin.Split(';');

                if (data[0] == username && data[1] == password)
                {
                    string adminName = data[2];

                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Admin bilgileri hatalý!",
                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void white(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
