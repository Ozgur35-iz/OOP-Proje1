using GymSystem.Core; // Enum için gerekli
using OOP_Proje1.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class ClassOperationsForm : Form
    {
        public ClassOperationsForm()
        {
            InitializeComponent();
        }

        private void ClassOperationsForm_Load(object sender, EventArgs e)
        {
            // 1. Kategorileri Enum'dan çek ve İngilizce isimlerle doldur
            // (Enum isimlerini değiştirdiğin için direkt ToString() iş görür)
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add(LessonCategory.Cardio.ToString());
            cmbCategory.Items.Add(LessonCategory.StrengthConditioning.ToString());
            cmbCategory.Items.Add(LessonCategory.FlexibilityMind.ToString());
            cmbCategory.SelectedIndex = 0;

            // 2. Günleri Seç (Varsayılan Pazartesi)
            cmbDay.SelectedIndex = 0;

            // 3. Silme listesini doldur
            RefreshRemoveList();
        }

        // --- LİSTE GÜNCELLEME METODU ---
        private void RefreshRemoveList()
        {
            cmbClassList.Items.Clear();
            try
            {
                string path = GetLessonsFilePath();
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');
                        if (parts.Length >= 2)
                        {
                            // Format: ID - DersAdı (Örn: 5 - Zumba)
                            string display = $"{parts[0]} - {parts[1]}";
                            cmbClassList.Items.Add(display);
                        }
                    }
                }
            }
            catch { }
        }

        // --- EKLEME İŞLEMİ ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCoach.Text) ||
                string.IsNullOrWhiteSpace(txtStudio.Text) ||
                string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string path = GetLessonsFilePath();
                int newId = 1;

                // Otomatik ID hesaplama
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path);
                    if (lines.Length > 0)
                    {
                        var lastLine = lines.Last(); // En son satırı al
                        var parts = lastLine.Split(';');
                        if (parts.Length > 0 && int.TryParse(parts[0], out int lastId))
                        {
                            newId = lastId + 1;
                        }
                    }
                }

                // Verileri Hazırla
                string category = cmbCategory.SelectedItem.ToString();
                string day = cmbDay.SelectedItem.ToString();

                // Format: ID;Ad;Kategori;Hoca;Salon;Gün;Saat;Kontenjan
                string newLine = $"{newId};{txtName.Text.Trim()};{category};{txtCoach.Text.Trim()};{txtStudio.Text.Trim()};{day};{txtTime.Text.Trim()};{numQuota.Value}";

                File.AppendAllText(path, newLine + Environment.NewLine);

                MessageBox.Show($"Class added successfully!\nID: {newId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu Temizle
                txtName.Clear();
                txtCoach.Clear();
                txtStudio.Clear();
                txtTime.Clear();
                numQuota.Value = 0;

                // Sağ taraftaki listeyi güncelle ki yeni ekleneni de görelim
                RefreshRemoveList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving class: " + ex.Message);
            }
        }

        // --- SİLME İŞLEMİ ---
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbClassList.SelectedItem == null)
            {
                MessageBox.Show("Please select a class to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen: "5 - Zumba" -> Buradan ID'yi (5) çekmemiz lazım
            string selectedText = cmbClassList.SelectedItem.ToString();
            string selectedId = selectedText.Split('-')[0].Trim();

            try
            {
                string path = GetLessonsFilePath();
                if (!File.Exists(path)) return;

                var lines = File.ReadAllLines(path).ToList();
                var linesToKeep = new List<string>();
                bool found = false;

                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length > 0 && parts[0].Trim() == selectedId)
                    {
                        found = true;
                        continue; // Bu satırı atla (Sil)
                    }
                    linesToKeep.Add(line);
                }

                if (found)
                {
                    File.WriteAllLines(path, linesToKeep);
                    MessageBox.Show("Class removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshRemoveList(); // Listeyi güncelle
                }
                else
                {
                    MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing class: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetLessonsFilePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
            return Path.Combine(projectPath, "lessons.txt");
        }
    }
}