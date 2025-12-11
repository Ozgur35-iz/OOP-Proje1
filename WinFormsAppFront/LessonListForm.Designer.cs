namespace WinFormsAppFront
{
    partial class LessonListForm
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
            lblCategoryTitle = new Label();
            lstLessons = new ListBox();
            btnDetay = new Button();
            btnGeri = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCategoryTitle.Location = new Point(29, 33);
            lblCategoryTitle.Margin = new Padding(4, 0, 4, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(223, 38);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Kategori Başlığı";
            // 
            // lstLessons
            // 
            lstLessons.Font = new Font("Segoe UI", 11F);
            lstLessons.FormattingEnabled = true;
            lstLessons.Location = new Point(29, 133);
            lstLessons.Margin = new Padding(4, 5, 4, 5);
            lstLessons.Name = "lstLessons";
            lstLessons.Size = new Size(627, 394);
            lstLessons.TabIndex = 2;
            lstLessons.DoubleClick += lstLessons_DoubleClick;
            // 
            // btnDetay
            // 
            btnDetay.Location = new Point(400, 567);
            btnDetay.Margin = new Padding(4, 5, 4, 5);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(257, 58);
            btnDetay.TabIndex = 3;
            btnDetay.Text = "📋 Ders Detayı";
            btnDetay.UseVisualStyleBackColor = true;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(29, 567);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(143, 58);
            btnGeri.TabIndex = 4;
            btnGeri.Text = "← Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.Gray;
            lblInfo.Location = new Point(29, 83);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(316, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Detayları görmek için derse çift tıklayın";
            // 
            // LessonListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 750);
            Controls.Add(btnGeri);
            Controls.Add(btnDetay);
            Controls.Add(lstLessons);
            Controls.Add(lblInfo);
            Controls.Add(lblCategoryTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LessonListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ders Listesi";
            Load += LessonListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryTitle;
        private Label lblInfo;
        private ListBox lstLessons;
        private Button btnDetay;
        private Button btnGeri;
    }
}
