namespace WinFormsAppFront
{
    partial class LessonCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonCatalogForm));
            lblTitle = new Label();
            btnKardiyo = new Button();
            btnGucKondisyon = new Button();
            btnEsneklikZihin = new Button();
            btnGeri = new Button();
            lblKardiyoDesc = new Label();
            lblGucDesc = new Label();
            lblEsneklikDesc = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(317, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Group Classes Catalog";
            // 
            // btnKardiyo
            // 
            btnKardiyo.BackColor = Color.RoyalBlue;
            btnKardiyo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKardiyo.ForeColor = Color.White;
            btnKardiyo.Location = new Point(212, 100);
            btnKardiyo.Margin = new Padding(4, 5, 4, 5);
            btnKardiyo.Name = "btnKardiyo";
            btnKardiyo.Size = new Size(571, 83);
            btnKardiyo.TabIndex = 1;
            btnKardiyo.Text = "🏃 Kardiyo";
            btnKardiyo.UseVisualStyleBackColor = false;
            btnKardiyo.Click += btnKardiyo_Click;
            // 
            // btnGucKondisyon
            // 
            btnGucKondisyon.BackColor = Color.RoyalBlue;
            btnGucKondisyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGucKondisyon.ForeColor = Color.White;
            btnGucKondisyon.Location = new Point(212, 254);
            btnGucKondisyon.Margin = new Padding(4, 5, 4, 5);
            btnGucKondisyon.Name = "btnGucKondisyon";
            btnGucKondisyon.Size = new Size(571, 83);
            btnGucKondisyon.TabIndex = 3;
            btnGucKondisyon.Text = "💪 Güç && Kondisyon";
            btnGucKondisyon.UseVisualStyleBackColor = false;
            btnGucKondisyon.Click += btnGucKondisyon_Click;
            // 
            // btnEsneklikZihin
            // 
            btnEsneklikZihin.BackColor = Color.RoyalBlue;
            btnEsneklikZihin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEsneklikZihin.ForeColor = Color.White;
            btnEsneklikZihin.Location = new Point(212, 422);
            btnEsneklikZihin.Margin = new Padding(4, 5, 4, 5);
            btnEsneklikZihin.Name = "btnEsneklikZihin";
            btnEsneklikZihin.Size = new Size(571, 83);
            btnEsneklikZihin.TabIndex = 5;
            btnEsneklikZihin.Text = "\U0001f9d8 Esneklik && Zihin";
            btnEsneklikZihin.UseVisualStyleBackColor = false;
            btnEsneklikZihin.Click += btnEsneklikZihin_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Transparent;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeri.ForeColor = Color.RoyalBlue;
            btnGeri.Location = new Point(425, 624);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(143, 50);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "Go Back";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblKardiyoDesc
            // 
            lblKardiyoDesc.AutoSize = true;
            lblKardiyoDesc.BackColor = Color.Transparent;
            lblKardiyoDesc.ForeColor = Color.CornflowerBlue;
            lblKardiyoDesc.Location = new Point(375, 200);
            lblKardiyoDesc.Margin = new Padding(4, 0, 4, 0);
            lblKardiyoDesc.Name = "lblKardiyoDesc";
            lblKardiyoDesc.Size = new Size(230, 25);
            lblKardiyoDesc.TabIndex = 2;
            lblKardiyoDesc.Text = "Spinning, Zumba, Aerobik...";
            // 
            // lblGucDesc
            // 
            lblGucDesc.AutoSize = true;
            lblGucDesc.BackColor = Color.Transparent;
            lblGucDesc.ForeColor = Color.FromArgb(128, 128, 255);
            lblGucDesc.Location = new Point(353, 365);
            lblGucDesc.Margin = new Padding(4, 0, 4, 0);
            lblGucDesc.Name = "lblGucDesc";
            lblGucDesc.Size = new Size(289, 25);
            lblGucDesc.TabIndex = 4;
            lblGucDesc.Text = "Crossfit, Body Pump, Fonksiyonel...";
            // 
            // lblEsneklikDesc
            // 
            lblEsneklikDesc.AutoSize = true;
            lblEsneklikDesc.BackColor = Color.Transparent;
            lblEsneklikDesc.ForeColor = Color.FromArgb(128, 128, 255);
            lblEsneklikDesc.Location = new Point(390, 524);
            lblEsneklikDesc.Margin = new Padding(4, 0, 4, 0);
            lblEsneklikDesc.Name = "lblEsneklikDesc";
            lblEsneklikDesc.Size = new Size(224, 25);
            lblEsneklikDesc.TabIndex = 6;
            lblEsneklikDesc.Text = "Yoga, Pilates, Meditasyon...";
            // 
            // LessonCatalogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1028, 750);
            Controls.Add(btnGeri);
            Controls.Add(lblEsneklikDesc);
            Controls.Add(btnEsneklikZihin);
            Controls.Add(lblGucDesc);
            Controls.Add(btnGucKondisyon);
            Controls.Add(lblKardiyoDesc);
            Controls.Add(btnKardiyo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LessonCatalogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grup Dersleri Kataloğu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnKardiyo;
        private Label lblKardiyoDesc;
        private Button btnGucKondisyon;
        private Label lblGucDesc;
        private Button btnEsneklikZihin;
        private Label lblEsneklikDesc;
        private Button btnGeri;
    }
}
