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
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Grup Dersleri Kataloğu";
            // 
            // btnKardiyo
            // 
            btnKardiyo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKardiyo.Location = new Point(50, 80);
            btnKardiyo.Name = "btnKardiyo";
            btnKardiyo.Size = new Size(400, 50);
            btnKardiyo.TabIndex = 1;
            btnKardiyo.Text = "🏃 Kardiyo";
            btnKardiyo.UseVisualStyleBackColor = true;
            btnKardiyo.Click += btnKardiyo_Click;
            // 
            // lblKardiyoDesc
            // 
            lblKardiyoDesc.AutoSize = true;
            lblKardiyoDesc.ForeColor = Color.Gray;
            lblKardiyoDesc.Location = new Point(50, 133);
            lblKardiyoDesc.Name = "lblKardiyoDesc";
            lblKardiyoDesc.Size = new Size(200, 15);
            lblKardiyoDesc.TabIndex = 2;
            lblKardiyoDesc.Text = "Spinning, Zumba, Aerobik...";
            // 
            // btnGucKondisyon
            // 
            btnGucKondisyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGucKondisyon.Location = new Point(50, 170);
            btnGucKondisyon.Name = "btnGucKondisyon";
            btnGucKondisyon.Size = new Size(400, 50);
            btnGucKondisyon.TabIndex = 3;
            btnGucKondisyon.Text = "💪 Güç && Kondisyon";
            btnGucKondisyon.UseVisualStyleBackColor = true;
            btnGucKondisyon.Click += btnGucKondisyon_Click;
            // 
            // lblGucDesc
            // 
            lblGucDesc.AutoSize = true;
            lblGucDesc.ForeColor = Color.Gray;
            lblGucDesc.Location = new Point(50, 223);
            lblGucDesc.Name = "lblGucDesc";
            lblGucDesc.Size = new Size(200, 15);
            lblGucDesc.TabIndex = 4;
            lblGucDesc.Text = "Crossfit, Body Pump, Fonksiyonel...";
            // 
            // btnEsneklikZihin
            // 
            btnEsneklikZihin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEsneklikZihin.Location = new Point(50, 260);
            btnEsneklikZihin.Name = "btnEsneklikZihin";
            btnEsneklikZihin.Size = new Size(400, 50);
            btnEsneklikZihin.TabIndex = 5;
            btnEsneklikZihin.Text = "🧘 Esneklik && Zihin";
            btnEsneklikZihin.UseVisualStyleBackColor = true;
            btnEsneklikZihin.Click += btnEsneklikZihin_Click;
            // 
            // lblEsneklikDesc
            // 
            lblEsneklikDesc.AutoSize = true;
            lblEsneklikDesc.ForeColor = Color.Gray;
            lblEsneklikDesc.Location = new Point(50, 313);
            lblEsneklikDesc.Name = "lblEsneklikDesc";
            lblEsneklikDesc.Size = new Size(200, 15);
            lblEsneklikDesc.TabIndex = 6;
            lblEsneklikDesc.Text = "Yoga, Pilates, Meditasyon...";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(50, 360);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(100, 30);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "← Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // LessonCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 420);
            Controls.Add(btnGeri);
            Controls.Add(lblEsneklikDesc);
            Controls.Add(btnEsneklikZihin);
            Controls.Add(lblGucDesc);
            Controls.Add(btnGucKondisyon);
            Controls.Add(lblKardiyoDesc);
            Controls.Add(btnKardiyo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
