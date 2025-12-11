using System;
using System.Windows.Forms;
using GymSystem.Core;

namespace WinFormsAppFront   // yine sende neyse o
{
    public partial class AdminForm : Form
    {
        private GymSystem.Core.GymSystem _system = null!;

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(GymSystem.Core.GymSystem system) : this()
        {
            _system = system;

            this.Text = "Admin Panel";

            MessageBox.Show(
                $"Admin panel opened.\n" +
                $"Members: {_system.Members.Count}\n" +
                $"Lessons: {_system.Lessons.Count}",
                "Admin Panel");
        }
    }
}
