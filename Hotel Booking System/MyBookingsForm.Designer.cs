namespace Hotel_Booking_System
{
    partial class MyBookingsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            lblUserBadge = new Label();
            dgvBookings = new DataGridView();
            pnlGuestNotice = new Panel();
            lblGuestNotice = new Label();
            btnCancelBooking = new Button();
            btnCloseBottom = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            pnlGuestNotice.SuspendLayout();
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
            pnlHeader.Size = new Size(960, 55);
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
            lblTitle.Size = new Size(330, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📅 GrandStay — My Reservations";
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
            btnClose.Location = new Point(915, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblUserBadge
            // 
            lblUserBadge.AutoSize = true;
            lblUserBadge.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserBadge.ForeColor = Color.FromArgb(23, 45, 80);
            lblUserBadge.Location = new Point(25, 75);
            lblUserBadge.Name = "lblUserBadge";
            lblUserBadge.Size = new Size(300, 32);
            lblUserBadge.TabIndex = 1;
            lblUserBadge.Text = "Your Active Reservations";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 45, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.ColumnHeadersHeight = 42;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.Location = new Point(25, 120);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.RowTemplate.Height = 38;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(910, 360);
            dgvBookings.TabIndex = 2;
            // 
            // pnlGuestNotice
            // 
            pnlGuestNotice.BackColor = Color.FromArgb(254, 249, 231);
            pnlGuestNotice.Controls.Add(lblGuestNotice);
            pnlGuestNotice.Location = new Point(25, 495);
            pnlGuestNotice.Name = "pnlGuestNotice";
            pnlGuestNotice.Size = new Size(540, 50);
            pnlGuestNotice.TabIndex = 3;
            // 
            // lblGuestNotice
            // 
            lblGuestNotice.AutoSize = true;
            lblGuestNotice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuestNotice.ForeColor = Color.FromArgb(125, 102, 8);
            lblGuestNotice.Location = new Point(12, 14);
            lblGuestNotice.Name = "lblGuestNotice";
            lblGuestNotice.Size = new Size(480, 20);
            lblGuestNotice.TabIndex = 0;
            lblGuestNotice.Text = "💡 Notice: Sign in to synchronize your bookings and access full invoices.";
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = Color.White;
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBooking.ForeColor = Color.FromArgb(192, 57, 43);
            btnCancelBooking.Location = new Point(590, 495);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(210, 48);
            btnCancelBooking.TabIndex = 4;
            btnCancelBooking.Text = "Cancel Selected";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // btnCloseBottom
            // 
            btnCloseBottom.BackColor = Color.FromArgb(23, 45, 80);
            btnCloseBottom.Cursor = Cursors.Hand;
            btnCloseBottom.FlatAppearance.BorderSize = 0;
            btnCloseBottom.FlatStyle = FlatStyle.Flat;
            btnCloseBottom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseBottom.ForeColor = Color.White;
            btnCloseBottom.Location = new Point(815, 495);
            btnCloseBottom.Name = "btnCloseBottom";
            btnCloseBottom.Size = new Size(120, 48);
            btnCloseBottom.TabIndex = 5;
            btnCloseBottom.Text = "Done";
            btnCloseBottom.UseVisualStyleBackColor = false;
            btnCloseBottom.Click += btnClose_Click;
            // 
            // MyBookingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(960, 570);
            Controls.Add(btnCloseBottom);
            Controls.Add(btnCancelBooking);
            Controls.Add(pnlGuestNotice);
            Controls.Add(dgvBookings);
            Controls.Add(lblUserBadge);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyBookingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "My Reservations";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            pnlGuestNotice.ResumeLayout(false);
            pnlGuestNotice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Label lblUserBadge;
        private DataGridView dgvBookings;
        private Panel pnlGuestNotice;
        private Label lblGuestNotice;
        private Button btnCancelBooking;
        private Button btnCloseBottom;
    }
}
