namespace WinFormsAppFront
{
    partial class LessonDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblLessonName = new Label();
            lblEgitmen = new Label();
            lblSalon = new Label();
            lblGunSaat = new Label();
            lblKontenjan = new Label();
            lblDurum = new Label();
            btnKayitOl = new Button();
            btnGeri = new Button();
            panelInfo = new Panel();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblLessonName
            // 
            lblLessonName.AutoSize = true;
            lblLessonName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLessonName.Location = new Point(20, 20);
            lblLessonName.Name = "lblLessonName";
            lblLessonName.Size = new Size(120, 32);
            lblLessonName.TabIndex = 0;
            lblLessonName.Text = "Ders Adı";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.WhiteSmoke;
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(lblEgitmen);
            panelInfo.Controls.Add(lblSalon);
            panelInfo.Controls.Add(lblGunSaat);
            panelInfo.Controls.Add(lblKontenjan);
            panelInfo.Controls.Add(lblDurum);
            panelInfo.Location = new Point(20, 70);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(400, 180);
            panelInfo.TabIndex = 1;
            // 
            // lblEgitmen
            // 
            lblEgitmen.AutoSize = true;
            lblEgitmen.Font = new Font("Segoe UI", 11F);
            lblEgitmen.Location = new Point(15, 15);
            lblEgitmen.Name = "lblEgitmen";
            lblEgitmen.Size = new Size(100, 20);
            lblEgitmen.TabIndex = 0;
            lblEgitmen.Text = "Eğitmen: ...";
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.Font = new Font("Segoe UI", 11F);
            lblSalon.Location = new Point(15, 45);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(80, 20);
            lblSalon.TabIndex = 1;
            lblSalon.Text = "Salon: ...";
            // 
            // lblGunSaat
            // 
            lblGunSaat.AutoSize = true;
            lblGunSaat.Font = new Font("Segoe UI", 11F);
            lblGunSaat.Location = new Point(15, 75);
            lblGunSaat.Name = "lblGunSaat";
            lblGunSaat.Size = new Size(120, 20);
            lblGunSaat.TabIndex = 2;
            lblGunSaat.Text = "Gün - Saat: ...";
            // 
            // lblKontenjan
            // 
            lblKontenjan.AutoSize = true;
            lblKontenjan.Font = new Font("Segoe UI", 11F);
            lblKontenjan.Location = new Point(15, 105);
            lblKontenjan.Name = "lblKontenjan";
            lblKontenjan.Size = new Size(110, 20);
            lblKontenjan.TabIndex = 3;
            lblKontenjan.Text = "Kontenjan: ...";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDurum.Location = new Point(15, 140);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(80, 20);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "Durum: ...";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.LimeGreen;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(220, 270);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(200, 45);
            btnKayitOl.TabIndex = 2;
            btnKayitOl.Text = "📝 Derse Kaydol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(20, 280);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(100, 35);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "← Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // LessonDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 340);
            Controls.Add(btnGeri);
            Controls.Add(btnKayitOl);
            Controls.Add(panelInfo);
            Controls.Add(lblLessonName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LessonDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ders Detayı";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLessonName;
        private Panel panelInfo;
        private Label lblEgitmen;
        private Label lblSalon;
        private Label lblGunSaat;
        private Label lblKontenjan;
        private Label lblDurum;
        private Button btnKayitOl;
        private Button btnGeri;
    }
}
