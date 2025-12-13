using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class LessonDetailForm : Form
    {
        private GymSystem.Core.GymSystem _system;
        private Member _member;
        private GroupLesson _lesson;

        public LessonDetailForm()
        {
            InitializeComponent();
        }

        public LessonDetailForm(GymSystem.Core.GymSystem system, Member member, GroupLesson lesson) : this()
        {
            _system = system;
            _member = member;
            _lesson = lesson;

            LoadLessonDetails();
        }

        private void LoadLessonDetails()
        {
            this.Text = $"Class Detail - {_lesson.Ad}";
            lblLessonName.Text = _lesson.Ad;
            lblEgitmen.Text = $"👨‍🏫 Trainer: {_lesson.Egitmen}";
            lblSalon.Text = $"🏢 Studio: {_lesson.Salon}";

            string gunTurkce = GetTurkishDayName(_lesson.Gun);
            lblGunSaat.Text = $"📅 {gunTurkce} - {_lesson.Saat:hh\\:mm}";

            UpdateKontenjanInfo();
            UpdateButtonState();
        }

        private void UpdateKontenjanInfo()
        {
            lblKontenjan.Text = $"👥 Quota: {_lesson.KontenjanDolu} / {_lesson.KontenjanToplam}";

            if (_lesson.BosYerVar)
            {
                lblDurum.Text = "✅ There is an available place!";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "❌ The course is full!";
                lblDurum.ForeColor = Color.Red;
            }
        }

        private void UpdateButtonState()
        {
            bool zatenKayitli = _member.DerseKayitliMi(_lesson);

            if (zatenKayitli)
            {
                //btnKayitOl.Enabled = false;
                btnKayitOl.Text = "✓ You are already registered!";
                lblDurum.Text = "✓ You are enrolled in this course!";
                lblDurum.ForeColor = Color.White;
                btnKayitOl.ForeColor = Color.White;
            }
            else if (!_lesson.BosYerVar)
            {
                btnKayitOl.Enabled = false;
                btnKayitOl.Text = "The course is full";
            }
            else
            {
                btnKayitOl.Enabled = true;
                btnKayitOl.Text = "📝 Enroll in the course";
            }
        }

        private string GetTurkishDayName(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Pazartesi",
                DayOfWeek.Tuesday => "Salı",
                DayOfWeek.Wednesday => "Çarşamba",
                DayOfWeek.Thursday => "Perşembe",
                DayOfWeek.Friday => "Cuma",
                DayOfWeek.Saturday => "Cumartesi",
                DayOfWeek.Sunday => "Pazar",
                _ => day.ToString()
            };
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (_member.DerseKayitliMi(_lesson))
            {
                MessageBox.Show("You are already registered to this lesson!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_lesson.BosYerVar)
            {
                MessageBox.Show("Sorry, the course is full!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool kayitBasarili = _lesson.UyeKaydet(_member);

            if (kayitBasarili)
            {
                // Kaydı dosyaya yaz
                SaveRegistrationToFile();

                MessageBox.Show(
                    $"You have successfully enrolled in the '{_lesson.Ad}' course.\n\n" +
                    $"Day: {GetTurkishDayName(_lesson.Gun)}\n" +
                    $"Time: {_lesson.Saat:hh\\:mm}\n" +
                    $"Studio: {_lesson.Salon}",
                    "Enrollment successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateKontenjanInfo();
                UpdateButtonState();
            }
            else
            {
                MessageBox.Show("Enrollment failed, please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRegistrationToFile()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                // Proje kök dizinine git
                string projectPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
                string filePath = Path.Combine(projectPath, "registrations.txt");

                string line = $"{_lesson.Id};{_member.TcKimlikNo}";
                File.AppendAllText(filePath, line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Dosyaya yazma hatası olursa sessizce devam et
                System.Diagnostics.Debug.WriteLine($"Failed to write to the file: {ex.Message}");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
