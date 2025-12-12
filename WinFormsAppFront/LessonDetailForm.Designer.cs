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
            lblLessonName.BackColor = Color.Transparent;
            lblLessonName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLessonName.ForeColor = Color.RoyalBlue;
            lblLessonName.Location = new Point(231, 60);
            lblLessonName.Margin = new Padding(4, 0, 4, 0);
            lblLessonName.Name = "lblLessonName";
            lblLessonName.Size = new Size(163, 48);
            lblLessonName.TabIndex = 0;
            lblLessonName.Text = "Ders Adı";
            // 
            // lblEgitmen
            // 
            lblEgitmen.AutoSize = true;
            lblEgitmen.Font = new Font("Segoe UI", 11F);
            lblEgitmen.Location = new Point(21, 25);
            lblEgitmen.Margin = new Padding(4, 0, 4, 0);
            lblEgitmen.Name = "lblEgitmen";
            lblEgitmen.Size = new Size(118, 30);
            lblEgitmen.TabIndex = 0;
            lblEgitmen.Text = "Eğitmen: ...";
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.Font = new Font("Segoe UI", 11F);
            lblSalon.Location = new Point(21, 75);
            lblSalon.Margin = new Padding(4, 0, 4, 0);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(92, 30);
            lblSalon.TabIndex = 1;
            lblSalon.Text = "Salon: ...";
            // 
            // lblGunSaat
            // 
            lblGunSaat.AutoSize = true;
            lblGunSaat.Font = new Font("Segoe UI", 11F);
            lblGunSaat.Location = new Point(21, 125);
            lblGunSaat.Margin = new Padding(4, 0, 4, 0);
            lblGunSaat.Name = "lblGunSaat";
            lblGunSaat.Size = new Size(140, 30);
            lblGunSaat.TabIndex = 2;
            lblGunSaat.Text = "Gün - Saat: ...";
            // 
            // lblKontenjan
            // 
            lblKontenjan.AutoSize = true;
            lblKontenjan.Font = new Font("Segoe UI", 11F);
            lblKontenjan.Location = new Point(21, 175);
            lblKontenjan.Margin = new Padding(4, 0, 4, 0);
            lblKontenjan.Name = "lblKontenjan";
            lblKontenjan.Size = new Size(135, 30);
            lblKontenjan.TabIndex = 3;
            lblKontenjan.Text = "Kontenjan: ...";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDurum.Location = new Point(21, 233);
            lblDurum.Margin = new Padding(4, 0, 4, 0);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(114, 30);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "Durum: ...";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.RoyalBlue;
            btnKayitOl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(364, 486);
            btnKayitOl.Margin = new Padding(4, 5, 4, 5);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(286, 75);
            btnKayitOl.TabIndex = 2;
            btnKayitOl.Text = "📝 Derse Kaydol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Transparent;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeri.ForeColor = Color.RoyalBlue;
            btnGeri.Location = new Point(432, 587);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(143, 58);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "Go Back";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.White;
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(lblEgitmen);
            panelInfo.Controls.Add(lblSalon);
            panelInfo.Controls.Add(lblGunSaat);
            panelInfo.Controls.Add(lblKontenjan);
            panelInfo.Controls.Add(lblDurum);
            panelInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            panelInfo.ForeColor = Color.DimGray;
            panelInfo.Location = new Point(231, 144);
            panelInfo.Margin = new Padding(4, 5, 4, 5);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(571, 299);
            panelInfo.TabIndex = 1;
            // 
            // LessonDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir__3_1;
            ClientSize = new Size(1028, 750);
            Controls.Add(btnGeri);
            Controls.Add(btnKayitOl);
            Controls.Add(panelInfo);
            Controls.Add(lblLessonName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
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
