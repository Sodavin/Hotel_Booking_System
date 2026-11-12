namespace Hotel_Booking_System
{
    partial class AboutForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            lblMainHeading = new Label();
            lblDescription = new Label();
            pnlCard1 = new Panel();
            lblCard1Text = new Label();
            lblCard1Title = new Label();
            pnlCard2 = new Panel();
            lblCard2Text = new Label();
            lblCard2Title = new Label();
            pnlCard3 = new Panel();
            lblCard3Text = new Label();
            lblCard3Title = new Label();
            btnExploreRooms = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 45, 80);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 55);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 1;
            lblTitle.Text = "🏨 GrandStay Hotel & Resorts — About";
            lblTitle.MouseDown += pnlHeader_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(955, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblMainHeading
            // 
            lblMainHeading.AutoSize = true;
            lblMainHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainHeading.ForeColor = Color.FromArgb(23, 45, 80);
            lblMainHeading.Location = new Point(30, 78);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.TabIndex = 1;
            lblMainHeading.Text = "Cambodia's Leading Luxury Hospitality Group";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(70, 80, 95);
            lblDescription.Location = new Point(30, 125);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(940, 75);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Founded with a passion for timeless Khmer warmth and contemporary elegance, GrandStay Hotel & Resorts offers premier accommodations across the Kingdom's most breathtaking destinations. Whether visiting for business or holiday, your comfort and satisfaction are our utmost priority.";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.Controls.Add(lblCard1Text);
            pnlCard1.Controls.Add(lblCard1Title);
            pnlCard1.Location = new Point(30, 220);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(295, 230);
            pnlCard1.TabIndex = 3;
            pnlCard1.Paint += pnlCard1_Paint;
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = false;
            lblCard1Title.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCard1Title.ForeColor = Color.FromArgb(23, 45, 80);
            lblCard1Title.Location = new Point(16, 18);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(263, 35);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "📍 Prime Locations";
            // 
            // lblCard1Text
            // 
            lblCard1Text.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCard1Text.ForeColor = Color.DimGray;
            lblCard1Text.Location = new Point(16, 60);
            lblCard1Text.Name = "lblCard1Text";
            lblCard1Text.Size = new Size(263, 155);
            lblCard1Text.TabIndex = 1;
            lblCard1Text.Text = "Conveniently located across Phnom Penh, Siem Reap, Sihanoukville, Kampot, Battambang, and Kep. Situated near major landmarks and scenic vistas.";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.Controls.Add(lblCard2Text);
            pnlCard2.Controls.Add(lblCard2Title);
            pnlCard2.Location = new Point(352, 220);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(295, 230);
            pnlCard2.TabIndex = 4;
            pnlCard2.Paint += pnlCard2_Paint;
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = false;
            lblCard2Title.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCard2Title.ForeColor = Color.FromArgb(23, 45, 80);
            lblCard2Title.Location = new Point(16, 18);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(263, 35);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "⭐ 5-Star Amenities";
            // 
            // lblCard2Text
            // 
            lblCard2Text.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCard2Text.ForeColor = Color.DimGray;
            lblCard2Text.Location = new Point(16, 60);
            lblCard2Text.Name = "lblCard2Text";
            lblCard2Text.Size = new Size(263, 155);
            lblCard2Text.TabIndex = 1;
            lblCard2Text.Text = "Indulge in infinity rooftop pools, 24/7 dedicated concierge, full-service Khmer wellness spas, gourmet breakfast buffets, and high-speed fiber Wi-Fi.";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.Controls.Add(lblCard3Text);
            pnlCard3.Controls.Add(lblCard3Title);
            pnlCard3.Location = new Point(675, 220);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(295, 230);
            pnlCard3.TabIndex = 5;
            pnlCard3.Paint += pnlCard3_Paint;
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = false;
            lblCard3Title.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCard3Title.ForeColor = Color.FromArgb(23, 45, 80);
            lblCard3Title.Location = new Point(16, 18);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(263, 35);
            lblCard3Title.TabIndex = 0;
            lblCard3Title.Text = "🔒 Best Rate Guarantee";
            // 
            // lblCard3Text
            // 
            lblCard3Text.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCard3Text.ForeColor = Color.DimGray;
            lblCard3Text.Location = new Point(16, 60);
            lblCard3Text.Name = "lblCard3Text";
            lblCard3Text.Size = new Size(263, 155);
            lblCard3Text.TabIndex = 1;
            lblCard3Text.Text = "Book directly through our system for guaranteed best rates, zero hidden charges, instant confirmation, and flexible check-in policies.";
            // 
            // btnExploreRooms
            // 
            btnExploreRooms.BackColor = Color.FromArgb(23, 45, 80);
            btnExploreRooms.Cursor = Cursors.Hand;
            btnExploreRooms.FlatAppearance.BorderSize = 0;
            btnExploreRooms.FlatStyle = FlatStyle.Flat;
            btnExploreRooms.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExploreRooms.ForeColor = Color.White;
            btnExploreRooms.Location = new Point(770, 490);
            btnExploreRooms.Name = "btnExploreRooms";
            btnExploreRooms.Size = new Size(200, 45);
            btnExploreRooms.TabIndex = 6;
            btnExploreRooms.Text = "Browse Rooms →";
            btnExploreRooms.UseVisualStyleBackColor = false;
            btnExploreRooms.Click += btnExploreRooms_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.LightGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(23, 45, 80);
            btnBack.Location = new Point(635, 490);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 45);
            btnBack.TabIndex = 7;
            btnBack.Text = "Close";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1000, 580);
            Controls.Add(btnBack);
            Controls.Add(btnExploreRooms);
            Controls.Add(pnlCard3);
            Controls.Add(pnlCard2);
            Controls.Add(pnlCard1);
            Controls.Add(lblDescription);
            Controls.Add(lblMainHeading);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About GrandStay";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlCard3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Label lblMainHeading;
        private Label lblDescription;
        private Panel pnlCard1;
        private Label lblCard1Title;
        private Label lblCard1Text;
        private Panel pnlCard2;
        private Label lblCard2Title;
        private Label lblCard2Text;
        private Panel pnlCard3;
        private Label lblCard3Title;
        private Label lblCard3Text;
        private Button btnExploreRooms;
        private Button btnBack;
    }
}
