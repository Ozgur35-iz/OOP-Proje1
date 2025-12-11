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
            this.Text = $"Ders Detayı - {_lesson.Ad}";
            lblLessonName.Text = _lesson.Ad;
            lblEgitmen.Text = $"👨‍🏫 Eğitmen: {_lesson.Egitmen}";
            lblSalon.Text = $"🏢 Salon: {_lesson.Salon}";

            string gunTurkce = GetTurkishDayName(_lesson.Gun);
            lblGunSaat.Text = $"📅 {gunTurkce} - {_lesson.Saat:hh\\:mm}";

            UpdateKontenjanInfo();
            UpdateButtonState();
        }

        private void UpdateKontenjanInfo()
        {
            lblKontenjan.Text = $"👥 Kontenjan: {_lesson.KontenjanDolu} / {_lesson.KontenjanToplam}";

            if (_lesson.BosYerVar)
            {
                lblDurum.Text = "✅ Boş yer var!";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "❌ Kontenjan dolu!";
                lblDurum.ForeColor = Color.Red;
            }
        }

        private void UpdateButtonState()
        {
            bool zatenKayitli = _member.DerseKayitliMi(_lesson);

            if (zatenKayitli)
            {
                btnKayitOl.Enabled = false;
                btnKayitOl.Text = "✓ Zaten Kayıtlısınız";
                lblDurum.Text = "✓ Bu derse kayıtlısınız";
                lblDurum.ForeColor = Color.Blue;
            }
            else if (!_lesson.BosYerVar)
            {
                btnKayitOl.Enabled = false;
                btnKayitOl.Text = "Kontenjan Dolu";
            }
            else
            {
                btnKayitOl.Enabled = true;
                btnKayitOl.Text = "📝 Derse Kaydol";
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
                MessageBox.Show("Bu derse zaten kayıtlısınız!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_lesson.BosYerVar)
            {
                MessageBox.Show("Üzgünüz, kontenjan dolu!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool kayitBasarili = _lesson.UyeKaydet(_member);

            if (kayitBasarili)
            {
                // Kaydı dosyaya yaz
                SaveRegistrationToFile();

                MessageBox.Show(
                    $"'{_lesson.Ad}' dersine başarıyla kaydoldunuz!\n\n" +
                    $"Gün: {GetTurkishDayName(_lesson.Gun)}\n" +
                    $"Saat: {_lesson.Saat:hh\\:mm}\n" +
                    $"Salon: {_lesson.Salon}",
                    "Kayıt Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateKontenjanInfo();
                UpdateButtonState();
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı. Lütfen tekrar deneyin.", "Hata",
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
                System.Diagnostics.Debug.WriteLine($"Kayıt dosyaya yazılamadı: {ex.Message}");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
