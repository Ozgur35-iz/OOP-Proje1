using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsAppFront
{
    public partial class MemberOperationsForm : Form
    {
        private GymSystem.Core.GymSystem _system;

        public MemberOperationsForm(GymSystem.Core.GymSystem system)
        {
            InitializeComponent();
            _system = system;
        }
        public MemberOperationsForm() { InitializeComponent(); }

        private void MemberOperationsForm_Load(object sender, EventArgs e)
        {
            if (cmbMembershipType.Items.Count == 0)
            {
                cmbMembershipType.Items.Add("Gold");
                cmbMembershipType.Items.Add("Silver");
                cmbMembershipType.Items.Add("Bronze");
            }
            cmbMembershipType.SelectedIndex = 0;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbMembershipType.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.Text.Length != 11 || !long.TryParse(txtUsername.Text, out _))
            {
                MessageBox.Show("Username (TC) must be 11 digits and numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string membershipType = cmbMembershipType.SelectedItem.ToString();
            DateTime expiryDate = DateTime.Now;
            switch (membershipType)
            {
                case "Gold": expiryDate = expiryDate.AddYears(1); break;
                case "Silver": expiryDate = expiryDate.AddMonths(6); break;
                case "Bronze": expiryDate = expiryDate.AddMonths(1); break;
            }

            string formattedDate = expiryDate.ToString("yyyy-MM-dd");
            string newLine = $"{txtUsername.Text.Trim()};{txtPassword.Text.Trim()};{txtName.Text.Trim()};{txtSurname.Text.Trim()};{membershipType};{formattedDate}";

            try
            {
                string path = GetMembersFilePath();
                File.AppendAllText(path, newLine + Environment.NewLine);
                MessageBox.Show($"Member added successfully!\nExpiry Date: {formattedDate}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear(); txtSurname.Clear(); txtUsername.Clear(); txtPassword.Clear(); cmbMembershipType.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            string targetTc = txtRemoveTc.Text.Trim();
            string targetPass = txtRemovePass.Text.Trim();

            if (string.IsNullOrWhiteSpace(targetTc) || string.IsNullOrWhiteSpace(targetPass))
            {
                MessageBox.Show("Enter TC and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string path = GetMembersFilePath();
                if (!File.Exists(path)) return;

                var lines = File.ReadAllLines(path).ToList();
                var linesToKeep = new List<string>();
                bool found = false;

                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length >= 2 && parts[0].Trim() == targetTc && parts[1].Trim() == targetPass)
                    {
                        found = true;
                        continue;
                    }
                    linesToKeep.Add(line);
                }

                if (found)
                {
                    File.WriteAllLines(path, linesToKeep);
                    MessageBox.Show("Member removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemoveTc.Clear(); txtRemovePass.Clear();
                }
                else
                {
                    MessageBox.Show("Member not found or incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapatır, Admin paneli zaten altta açıktır.
        }

        private string GetMembersFilePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
            return Path.Combine(projectPath, "members.txt");
        }
    }
}