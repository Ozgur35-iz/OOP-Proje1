using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class LessonCatalogForm : Form
    {
        private GymSystem.Core.GymSystem _system;
        private Member _member;

        public LessonCatalogForm()
        {
            InitializeComponent();
        }

        public LessonCatalogForm(GymSystem.Core.GymSystem system, Member member) : this()
        {
            _system = system;
            _member = member;
            this.Text = "Grup Dersleri Kataloğu";
        }

        private void btnKardiyo_Click(object sender, EventArgs e)
        {
            OpenLessonList(LessonCategory.Kardiyo);
        }

        private void btnGucKondisyon_Click(object sender, EventArgs e)
        {
            OpenLessonList(LessonCategory.GucKondisyon);
        }

        private void btnEsneklikZihin_Click(object sender, EventArgs e)
        {
            OpenLessonList(LessonCategory.EsneklikZihin);
        }

        private void OpenLessonList(LessonCategory category)
        {
            var lessonListForm = new LessonListForm(_system, _member, category);
            lessonListForm.ShowDialog();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
