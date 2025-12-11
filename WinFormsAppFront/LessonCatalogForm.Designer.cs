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
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(317, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Grup Dersleri Kataloğu";
            // 
            // btnKardiyo
            // 
            btnKardiyo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKardiyo.Location = new Point(212, 100);
            btnKardiyo.Margin = new Padding(4, 5, 4, 5);
            btnKardiyo.Name = "btnKardiyo";
            btnKardiyo.Size = new Size(571, 83);
            btnKardiyo.TabIndex = 1;
            btnKardiyo.Text = "🏃 Kardiyo";
            btnKardiyo.UseVisualStyleBackColor = true;
            btnKardiyo.Click += btnKardiyo_Click;
            // 
            // btnGucKondisyon
            // 
            btnGucKondisyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGucKondisyon.Location = new Point(212, 254);
            btnGucKondisyon.Margin = new Padding(4, 5, 4, 5);
            btnGucKondisyon.Name = "btnGucKondisyon";
            btnGucKondisyon.Size = new Size(571, 83);
            btnGucKondisyon.TabIndex = 3;
            btnGucKondisyon.Text = "💪 Güç && Kondisyon";
            btnGucKondisyon.UseVisualStyleBackColor = true;
            btnGucKondisyon.Click += btnGucKondisyon_Click;
            // 
            // btnEsneklikZihin
            // 
            btnEsneklikZihin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEsneklikZihin.Location = new Point(212, 422);
            btnEsneklikZihin.Margin = new Padding(4, 5, 4, 5);
            btnEsneklikZihin.Name = "btnEsneklikZihin";
            btnEsneklikZihin.Size = new Size(571, 83);
            btnEsneklikZihin.TabIndex = 5;
            btnEsneklikZihin.Text = "\U0001f9d8 Esneklik && Zihin";
            btnEsneklikZihin.UseVisualStyleBackColor = true;
            btnEsneklikZihin.Click += btnEsneklikZihin_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(421, 600);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(143, 50);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "← Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblKardiyoDesc
            // 
            lblKardiyoDesc.AutoSize = true;
            lblKardiyoDesc.ForeColor = Color.Gray;
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
            lblGucDesc.ForeColor = Color.Gray;
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
            lblEsneklikDesc.ForeColor = Color.Gray;
            lblEsneklikDesc.Location = new Point(381, 540);
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
