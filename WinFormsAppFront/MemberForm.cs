using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class MemberForm : Form
    {
        private GymSystem.Core.GymSystem _system = null!;
        private Member _member = null!;

        // Designer'ın kullandığı parametresiz constructor
        public MemberForm()
        {
            InitializeComponent();
        }

        // Bizim kullandığımız constructor (LoginForm burayı çağıracak)
        public MemberForm(GymSystem.Core.GymSystem system, Member member) : this()
        {
            _system = system;
            _member = member;

            this.Text = $"Üye Paneli - {_member.AdSoyad}";

            LoadMemberInfo();
            LoadMyLessons();

            // Event handler'ları bağla
            btnCatalog.Click += btnCatalog_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void LoadMemberInfo()
        {
            lblWelcome.Text = $"Welcome, {_member.AdSoyad}";
            lblPackage.Text = $"Membership: {_member.UyelikPaketi?.Ad ?? "Belirtilmemiş"}";
            lblEndDate.Text = $"Expiry Date: {_member.UyelikBitisTarihi:dd.MM.yyyy}";

            // Üyelik durumu kontrolü
            if (!_member.UyelikAktifMi())
            {
                lblEndDate.ForeColor = Color.Red;
                lblEndDate.Text += " (Your membership has expired!)";
            }
        }

        private void LoadMyLessons()
        {
            lstMyLessons.Items.Clear();

            if (_member.KayitliDersler.Count == 0)
            {
                lstMyLessons.Items.Add("You have no enrolled courses yet");
                return;
            }

            foreach (var lesson in _member.KayitliDersler)
            {
                string gunTurkce = GetTurkishDayName(lesson.Gun);
                lstMyLessons.Items.Add($"{lesson.Ad} - {gunTurkce} {lesson.Saat:hh\\:mm}");
            }
        }

        private string GetTurkishDayName(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Monday",
                DayOfWeek.Tuesday => "Tuesday",
                DayOfWeek.Wednesday => "Wednesday",
                DayOfWeek.Thursday => "Thursday",
                DayOfWeek.Friday => "Friday",
                DayOfWeek.Saturday => "Saturday",
                DayOfWeek.Sunday => "Sunday",
                _ => day.ToString()
            };
        }

        private void btnCatalog_Click(object? sender, EventArgs e)
        {
            var catalogForm = new LessonCatalogForm(_system, _member);
            catalogForm.ShowDialog();

            // Katalogdan döndükten sonra kayıtlı dersleri güncelle
            LoadMyLessons();
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?",
                "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.OpenForms["LoginForm"]?.Show();
            }
        }

        private void lblPackage_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
