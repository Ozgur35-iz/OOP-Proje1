using System;
using System.Windows.Forms;
using GymSystem.Core;

namespace WinFormsAppFront
{
    public partial class AdminForm : Form
    {
        private GymSystem.Core.GymSystem _system;
        private string _adminName;

        public AdminForm(GymSystem.Core.GymSystem system, string adminName)
        {
            InitializeComponent();
            _system = system;
            _adminName = adminName;
        }

        // Designer için boş constructor
        public AdminForm() { InitializeComponent(); }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + _adminName;
        }

        private void btnMemberOps_Click(object sender, EventArgs e)
        {
            // Yeni oluşturacağımız MemberOperationsForm'u açar
            MemberOperationsForm memberOps = new MemberOperationsForm(_system);
            memberOps.ShowDialog();
        }

        private void btnClassOps_Click(object sender, EventArgs e)
        {
            // Yeni oluşturacağımız ClassOperationsForm'u açar
            ClassOperationsForm classOps = new ClassOperationsForm();
            classOps.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["LoginForm"]?.Show();
        }
    }
}