
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonListForm));
            lblCategoryTitle = new Label();
            lstLessons = new ListBox();
            btnDetay = new Button();
            btnGeri = new Button();
            lblInfo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCategoryTitle.ForeColor = Color.RoyalBlue;
            lblCategoryTitle.Location = new Point(192, 31);
            lblCategoryTitle.Margin = new Padding(4, 0, 4, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(223, 38);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Kategori Başlığı";
            // 
            // lstLessons
            // 
            lstLessons.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lstLessons.ForeColor = Color.DimGray;
            lstLessons.FormattingEnabled = true;
            lstLessons.Location = new Point(192, 127);
            lstLessons.Margin = new Padding(4, 5, 4, 5);
            lstLessons.Name = "lstLessons";
            lstLessons.Size = new Size(648, 274);
            lstLessons.TabIndex = 2;
            lstLessons.DoubleClick += lstLessons_DoubleClick;
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.RoyalBlue;
            btnDetay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDetay.ForeColor = Color.White;
            btnDetay.Location = new Point(366, 540);
            btnDetay.Margin = new Padding(4, 5, 4, 5);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(284, 73);
            btnDetay.TabIndex = 3;
            btnDetay.Text = "Course Details";
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.White;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeri.ForeColor = Color.RoyalBlue;
            btnGeri.Location = new Point(412, 645);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(183, 38);
            btnGeri.TabIndex = 4;
            btnGeri.Text = "Go Back";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.FromArgb(128, 128, 255);
            lblInfo.Location = new Point(192, 84);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(306, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Double-click the course to see details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(734, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LessonListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1028, 750);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lstLessons_DrawItem(object sender, DrawItemEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblCategoryTitle;
        private Label lblInfo;
        private ListBox lstLessons;
        private Button btnDetay;
        private Button btnGeri;
        private PictureBox pictureBox1;
    }
}
