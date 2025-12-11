using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class LessonListForm : Form
    {
        private GymSystem.Core.GymSystem _system;
        private Member _member;
        private LessonCategory _category;

        public LessonListForm()
        {
            InitializeComponent();
        }

        public LessonListForm(GymSystem.Core.GymSystem system, Member member, LessonCategory category) : this()
        {
            _system = system;
            _member = member;
            _category = category;

            SetCategoryTitle();
            LoadLessons();
        }

        private void SetCategoryTitle()
        {
            string categoryName = _category switch
            {
                LessonCategory.Kardiyo => "Cardio Classes",
                LessonCategory.GucKondisyon => "Strength & Conditioning Classes",
                LessonCategory.EsneklikZihin => "Flexibility & Mind Classes",
                _ => "Classes"
            };

            lblCategoryTitle.Text = categoryName;
            this.Text = categoryName;

            // -------------------------------
            // Arka plan resmini kategoriye göre ayarla (Resources üzerinden)
            this.BackgroundImage = _category switch
            {
                LessonCategory.Kardiyo => Properties.Resources.Gemini_Generated_Image_e0rlf2e0rlf2e0rl,
                LessonCategory.GucKondisyon => Properties.Resources.Gemini_Generated_Image_4bgp3z4bgp3z4bgp,
                LessonCategory.EsneklikZihin => Properties.Resources.Gemini_Generated_Image_snkoe5snkoe5snko,
                _ => null
            };

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }



        private void LoadLessons()
        {
            lstLessons.Items.Clear();

            var lessons = _system.GetLessonsByCategory(_category).ToList();

            if (lessons.Count == 0)
            {
                lstLessons.Items.Add("No courses available in this category.");
                return;
            }

            foreach (var lesson in lessons)
            {
                string gunTurkce = GetTurkishDayName(lesson.Gun);
                string item = $"{lesson.Ad} - {gunTurkce} {lesson.Saat:hh\\:mm}";
                lstLessons.Items.Add(item);
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

        private void lstLessons_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedLessonDetail();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            OpenSelectedLessonDetail();
        }

        private void OpenSelectedLessonDetail()
        {
            if (lstLessons.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a class.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lessons = _system.GetLessonsByCategory(_category).ToList();

            if (lstLessons.SelectedIndex >= lessons.Count)
                return;

            var selectedLesson = lessons[lstLessons.SelectedIndex];
            var detailForm = new LessonDetailForm(_system, _member, selectedLesson);
            detailForm.ShowDialog();

            // Detay formundan döndükten sonra listeyi güncelle
            LoadLessons();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LessonListForm_Load(object sender, EventArgs e)
        {

        }



    }
}
