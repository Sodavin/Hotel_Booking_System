namespace Hotel_Booking_System
{
    partial class AdminDashboardForm
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
            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            btnMin = new Button();
            btnClose = new Button();
            pnlSidebar = new Panel();
            btnNavExit = new Button();
            btnNavUsers = new Button();
            btnNavBookings = new Button();
            btnNavRooms = new Button();
            btnNavOverview = new Button();
            pnlAdminProfile = new Panel();
            lblAdminRole = new Label();
            lblAdminName = new Label();
            pnlContent = new Panel();
            lblPageTitle = new Label();
            pnlViewOverview = new Panel();
            pnlKpi4 = new Panel();
            lblKpi4Value = new Label();
            lblKpi4Title = new Label();
            pnlKpi3 = new Panel();
            lblKpi3Value = new Label();
            lblKpi3Title = new Label();
            pnlKpi2 = new Panel();
            lblKpi2Value = new Label();
            lblKpi2Title = new Label();
            pnlKpi1 = new Panel();
            lblKpi1Value = new Label();
            lblKpi1Title = new Label();
            lblOverviewHeading = new Label();
            pnlViewRooms = new Panel();
            btnToggleRoomStatus = new Button();
            btnAddRoom = new Button();
            dgvRooms = new DataGridView();
            pnlViewBookings = new Panel();
            btnCancelBookingAdmin = new Button();
            btnCheckOutGuest = new Button();
            btnCheckInGuest = new Button();
            btnApproveBooking = new Button();
            dgvBookings = new DataGridView();
            pnlViewUsers = new Panel();
            dgvUsers = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlAdminProfile.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlViewOverview.SuspendLayout();
            pnlKpi4.SuspendLayout();
            pnlKpi3.SuspendLayout();
            pnlKpi2.SuspendLayout();
            pnlKpi1.SuspendLayout();
            pnlViewRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            pnlViewBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            pnlViewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 45, 80);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(btnMin);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 50);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(20, 12);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(390, 25);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "GrandStay Operations Console — Master Admin";
            lblHeaderTitle.MouseDown += pnlHeader_MouseDown;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(1195, 6);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(35, 38);
            btnMin.TabIndex = 2;
            btnMin.Text = "—";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
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
            btnClose.Location = new Point(1235, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 34, 60);
            pnlSidebar.Controls.Add(btnNavExit);
            pnlSidebar.Controls.Add(btnNavUsers);
            pnlSidebar.Controls.Add(btnNavBookings);
            pnlSidebar.Controls.Add(btnNavRooms);
            pnlSidebar.Controls.Add(btnNavOverview);
            pnlSidebar.Controls.Add(pnlAdminProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 50);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 710);
            pnlSidebar.TabIndex = 1;
            // 
            // btnNavExit
            // 
            btnNavExit.BackColor = Color.FromArgb(17, 34, 60);
            btnNavExit.Cursor = Cursors.Hand;
            btnNavExit.Dock = DockStyle.Bottom;
            btnNavExit.FlatAppearance.BorderSize = 0;
            btnNavExit.FlatStyle = FlatStyle.Flat;
            btnNavExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavExit.ForeColor = Color.Salmon;
            btnNavExit.Location = new Point(0, 655);
            btnNavExit.Name = "btnNavExit";
            btnNavExit.Padding = new Padding(20, 0, 0, 0);
            btnNavExit.Size = new Size(230, 55);
            btnNavExit.TabIndex = 5;
            btnNavExit.Text = "🚪 Exit Dashboard";
            btnNavExit.TextAlign = ContentAlignment.MiddleLeft;
            btnNavExit.UseVisualStyleBackColor = false;
            btnNavExit.Click += btnNavExit_Click;
            // 
            // btnNavUsers
            // 
            btnNavUsers.BackColor = Color.FromArgb(17, 34, 60);
            btnNavUsers.Cursor = Cursors.Hand;
            btnNavUsers.Dock = DockStyle.Top;
            btnNavUsers.FlatAppearance.BorderSize = 0;
            btnNavUsers.FlatStyle = FlatStyle.Flat;
            btnNavUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavUsers.ForeColor = Color.Gainsboro;
            btnNavUsers.Location = new Point(0, 245);
            btnNavUsers.Name = "btnNavUsers";
            btnNavUsers.Padding = new Padding(20, 0, 0, 0);
            btnNavUsers.Size = new Size(230, 55);
            btnNavUsers.TabIndex = 4;
            btnNavUsers.Text = "👥 User Directory";
            btnNavUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavUsers.UseVisualStyleBackColor = false;
            btnNavUsers.Click += btnNavUsers_Click;
            // 
            // btnNavBookings
            // 
            btnNavBookings.BackColor = Color.FromArgb(17, 34, 60);
            btnNavBookings.Cursor = Cursors.Hand;
            btnNavBookings.Dock = DockStyle.Top;
            btnNavBookings.FlatAppearance.BorderSize = 0;
            btnNavBookings.FlatStyle = FlatStyle.Flat;
            btnNavBookings.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavBookings.ForeColor = Color.Gainsboro;
            btnNavBookings.Location = new Point(0, 190);
            btnNavBookings.Name = "btnNavBookings";
            btnNavBookings.Padding = new Padding(20, 0, 0, 0);
            btnNavBookings.Size = new Size(230, 55);
            btnNavBookings.TabIndex = 3;
            btnNavBookings.Text = "📋 Guest Bookings";
            btnNavBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBookings.UseVisualStyleBackColor = false;
            btnNavBookings.Click += btnNavBookings_Click;
            // 
            // btnNavRooms
            // 
            btnNavRooms.BackColor = Color.FromArgb(17, 34, 60);
            btnNavRooms.Cursor = Cursors.Hand;
            btnNavRooms.Dock = DockStyle.Top;
            btnNavRooms.FlatAppearance.BorderSize = 0;
            btnNavRooms.FlatStyle = FlatStyle.Flat;
            btnNavRooms.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavRooms.ForeColor = Color.Gainsboro;
            btnNavRooms.Location = new Point(0, 135);
            btnNavRooms.Name = "btnNavRooms";
            btnNavRooms.Padding = new Padding(20, 0, 0, 0);
            btnNavRooms.Size = new Size(230, 55);
            btnNavRooms.TabIndex = 2;
            btnNavRooms.Text = "🛏️ Room Inventory";
            btnNavRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRooms.UseVisualStyleBackColor = false;
            btnNavRooms.Click += btnNavRooms_Click;
            // 
            // btnNavOverview
            // 
            btnNavOverview.BackColor = Color.FromArgb(23, 45, 80);
            btnNavOverview.Cursor = Cursors.Hand;
            btnNavOverview.Dock = DockStyle.Top;
            btnNavOverview.FlatAppearance.BorderSize = 0;
            btnNavOverview.FlatStyle = FlatStyle.Flat;
            btnNavOverview.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavOverview.ForeColor = Color.White;
            btnNavOverview.Location = new Point(0, 80);
            btnNavOverview.Name = "btnNavOverview";
            btnNavOverview.Padding = new Padding(20, 0, 0, 0);
            btnNavOverview.Size = new Size(230, 55);
            btnNavOverview.TabIndex = 1;
            btnNavOverview.Text = "📊 Overview";
            btnNavOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnNavOverview.UseVisualStyleBackColor = false;
            btnNavOverview.Click += btnNavOverview_Click;
            // 
            // pnlAdminProfile
            // 
            pnlAdminProfile.BackColor = Color.FromArgb(12, 25, 45);
            pnlAdminProfile.Controls.Add(lblAdminRole);
            pnlAdminProfile.Controls.Add(lblAdminName);
            pnlAdminProfile.Dock = DockStyle.Top;
            pnlAdminProfile.Location = new Point(0, 0);
            pnlAdminProfile.Name = "pnlAdminProfile";
            pnlAdminProfile.Size = new Size(230, 80);
            pnlAdminProfile.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            lblAdminRole.AutoSize = true;
            lblAdminRole.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminRole.ForeColor = Color.LightSteelBlue;
            lblAdminRole.Location = new Point(18, 44);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(130, 20);
            lblAdminRole.TabIndex = 1;
            lblAdminRole.Text = "Super Admin Role";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(16, 18);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(138, 25);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "👤 Master Admin";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Controls.Add(lblPageTitle);
            pnlContent.Controls.Add(pnlViewOverview);
            pnlContent.Controls.Add(pnlViewRooms);
            pnlContent.Controls.Add(pnlViewBookings);
            pnlContent.Controls.Add(pnlViewUsers);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(230, 50);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(25, 20, 25, 20);
            pnlContent.Size = new Size(1050, 710);
            pnlContent.TabIndex = 2;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(23, 45, 80);
            lblPageTitle.Location = new Point(25, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(465, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "📊 Operations Overview & Analytics";
            // 
            // pnlViewOverview
            // 
            pnlViewOverview.Controls.Add(pnlKpi4);
            pnlViewOverview.Controls.Add(pnlKpi3);
            pnlViewOverview.Controls.Add(pnlKpi2);
            pnlViewOverview.Controls.Add(pnlKpi1);
            pnlViewOverview.Controls.Add(lblOverviewHeading);
            pnlViewOverview.Location = new Point(25, 75);
            pnlViewOverview.Name = "pnlViewOverview";
            pnlViewOverview.Size = new Size(1000, 600);
            pnlViewOverview.TabIndex = 1;
            // 
            // pnlKpi4
            // 
            pnlKpi4.BackColor = Color.White;
            pnlKpi4.Controls.Add(lblKpi4Value);
            pnlKpi4.Controls.Add(lblKpi4Title);
            pnlKpi4.Location = new Point(765, 20);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(230, 130);
            pnlKpi4.TabIndex = 4;
            // 
            // lblKpi4Value
            // 
            lblKpi4Value.AutoSize = true;
            lblKpi4Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi4Value.ForeColor = Color.FromArgb(41, 128, 185);
            lblKpi4Value.Location = new Point(15, 60);
            lblKpi4Value.Name = "lblKpi4Value";
            lblKpi4Value.Size = new Size(147, 41);
            lblKpi4Value.TabIndex = 1;
            lblKpi4Value.Text = "18 Rooms";
            // 
            // lblKpi4Title
            // 
            lblKpi4Title.AutoSize = true;
            lblKpi4Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi4Title.ForeColor = Color.DimGray;
            lblKpi4Title.Location = new Point(15, 20);
            lblKpi4Title.Name = "lblKpi4Title";
            lblKpi4Title.Size = new Size(137, 23);
            lblKpi4Title.TabIndex = 0;
            lblKpi4Title.Text = "Available Rooms";
            // 
            // pnlKpi3
            // 
            pnlKpi3.BackColor = Color.White;
            pnlKpi3.Controls.Add(lblKpi3Value);
            pnlKpi3.Controls.Add(lblKpi3Title);
            pnlKpi3.Location = new Point(510, 20);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(230, 130);
            pnlKpi3.TabIndex = 3;
            // 
            // lblKpi3Value
            // 
            lblKpi3Value.AutoSize = true;
            lblKpi3Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi3Value.ForeColor = Color.FromArgb(142, 68, 173);
            lblKpi3Value.Location = new Point(15, 60);
            lblKpi3Value.Name = "lblKpi3Value";
            lblKpi3Value.Size = new Size(95, 41);
            lblKpi3Value.TabIndex = 1;
            lblKpi3Value.Text = "86.4%";
            // 
            // lblKpi3Title
            // 
            lblKpi3Title.AutoSize = true;
            lblKpi3Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi3Title.ForeColor = Color.DimGray;
            lblKpi3Title.Location = new Point(15, 20);
            lblKpi3Title.Name = "lblKpi3Title";
            lblKpi3Title.Size = new Size(137, 23);
            lblKpi3Title.TabIndex = 0;
            lblKpi3Title.Text = "Occupancy Rate";
            // 
            // pnlKpi2
            // 
            pnlKpi2.BackColor = Color.White;
            pnlKpi2.Controls.Add(lblKpi2Value);
            pnlKpi2.Controls.Add(lblKpi2Title);
            pnlKpi2.Location = new Point(255, 20);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(230, 130);
            pnlKpi2.TabIndex = 2;
            // 
            // lblKpi2Value
            // 
            lblKpi2Value.AutoSize = true;
            lblKpi2Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi2Value.ForeColor = Color.FromArgb(230, 126, 34);
            lblKpi2Value.Location = new Point(15, 60);
            lblKpi2Value.Name = "lblKpi2Value";
            lblKpi2Value.Size = new Size(160, 41);
            lblKpi2Value.TabIndex = 1;
            lblKpi2Value.Text = "142 Active";
            // 
            // lblKpi2Title
            // 
            lblKpi2Title.AutoSize = true;
            lblKpi2Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi2Title.ForeColor = Color.DimGray;
            lblKpi2Title.Location = new Point(15, 20);
            lblKpi2Title.Name = "lblKpi2Title";
            lblKpi2Title.Size = new Size(128, 23);
            lblKpi2Title.TabIndex = 0;
            lblKpi2Title.Text = "Total Bookings";
            // 
            // pnlKpi1
            // 
            pnlKpi1.BackColor = Color.White;
            pnlKpi1.Controls.Add(lblKpi1Value);
            pnlKpi1.Controls.Add(lblKpi1Title);
            pnlKpi1.Location = new Point(0, 20);
            pnlKpi1.Name = "pnlKpi1";
            pnlKpi1.Size = new Size(230, 130);
            pnlKpi1.TabIndex = 1;
            // 
            // lblKpi1Value
            // 
            lblKpi1Value.AutoSize = true;
            lblKpi1Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi1Value.ForeColor = Color.FromArgb(39, 174, 96);
            lblKpi1Value.Location = new Point(15, 60);
            lblKpi1Value.Name = "lblKpi1Value";
            lblKpi1Value.Size = new Size(140, 41);
            lblKpi1Value.TabIndex = 1;
            lblKpi1Value.Text = "$ 48,250";
            // 
            // lblKpi1Title
            // 
            lblKpi1Title.AutoSize = true;
            lblKpi1Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi1Title.ForeColor = Color.DimGray;
            lblKpi1Title.Location = new Point(15, 20);
            lblKpi1Title.Name = "lblKpi1Title";
            lblKpi1Title.Size = new Size(122, 23);
            lblKpi1Title.TabIndex = 0;
            lblKpi1Title.Text = "Total Revenue";
            // 
            // lblOverviewHeading
            // 
            lblOverviewHeading.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverviewHeading.ForeColor = Color.FromArgb(70, 80, 95);
            lblOverviewHeading.Location = new Point(0, 180);
            lblOverviewHeading.Name = "lblOverviewHeading";
            lblOverviewHeading.Size = new Size(990, 80);
            lblOverviewHeading.TabIndex = 0;
            lblOverviewHeading.Text = "Welcome to the GrandStay Administration Console. From here, hotel managers can monitor real-time revenue, supervise active reservations across all 6 Cambodian provinces, maintain room status, and manage staff privileges.";
            // 
            // pnlViewRooms
            // 
            pnlViewRooms.Controls.Add(btnToggleRoomStatus);
            pnlViewRooms.Controls.Add(btnAddRoom);
            pnlViewRooms.Controls.Add(dgvRooms);
            pnlViewRooms.Location = new Point(25, 75);
            pnlViewRooms.Name = "pnlViewRooms";
            pnlViewRooms.Size = new Size(1000, 600);
            pnlViewRooms.TabIndex = 2;
            pnlViewRooms.Visible = false;
            // 
            // btnToggleRoomStatus
            // 
            btnToggleRoomStatus.BackColor = Color.White;
            btnToggleRoomStatus.Cursor = Cursors.Hand;
            btnToggleRoomStatus.FlatAppearance.BorderColor = Color.LightGray;
            btnToggleRoomStatus.FlatStyle = FlatStyle.Flat;
            btnToggleRoomStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggleRoomStatus.ForeColor = Color.FromArgb(23, 45, 80);
            btnToggleRoomStatus.Location = new Point(200, 535);
            btnToggleRoomStatus.Name = "btnToggleRoomStatus";
            btnToggleRoomStatus.Size = new Size(220, 45);
            btnToggleRoomStatus.TabIndex = 2;
            btnToggleRoomStatus.Text = "Toggle Status (Available/Maint)";
            btnToggleRoomStatus.UseVisualStyleBackColor = false;
            btnToggleRoomStatus.Click += btnToggleRoomStatus_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(23, 45, 80);
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(0, 535);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(180, 45);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "➕ Add Demo Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle1.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle1.ForeColor = Color.White;
            dgvStyle1.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dgvStyle1;
            dgvRooms.ColumnHeadersHeight = 40;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.Location = new Point(0, 10);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle2.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle2.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvRooms.RowsDefaultCellStyle = dgvStyle2;
            dgvRooms.RowTemplate.Height = 36;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1000, 500);
            dgvRooms.TabIndex = 0;
            // 
            // pnlViewBookings
            // 
            pnlViewBookings.Controls.Add(btnCancelBookingAdmin);
            pnlViewBookings.Controls.Add(btnCheckOutGuest);
            pnlViewBookings.Controls.Add(btnCheckInGuest);
            pnlViewBookings.Controls.Add(btnApproveBooking);
            pnlViewBookings.Controls.Add(dgvBookings);
            pnlViewBookings.Location = new Point(25, 75);
            pnlViewBookings.Name = "pnlViewBookings";
            pnlViewBookings.Size = new Size(1000, 600);
            pnlViewBookings.TabIndex = 3;
            pnlViewBookings.Visible = false;
            // 
            // btnCancelBookingAdmin
            // 
            btnCancelBookingAdmin.BackColor = Color.White;
            btnCancelBookingAdmin.Cursor = Cursors.Hand;
            btnCancelBookingAdmin.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnCancelBookingAdmin.FlatStyle = FlatStyle.Flat;
            btnCancelBookingAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBookingAdmin.ForeColor = Color.FromArgb(192, 57, 43);
            btnCancelBookingAdmin.Location = new Point(560, 535);
            btnCancelBookingAdmin.Name = "btnCancelBookingAdmin";
            btnCancelBookingAdmin.Size = new Size(140, 45);
            btnCancelBookingAdmin.TabIndex = 4;
            btnCancelBookingAdmin.Text = "Cancel Booking";
            btnCancelBookingAdmin.UseVisualStyleBackColor = false;
            btnCancelBookingAdmin.Click += btnCancelBookingAdmin_Click;
            // 
            // btnCheckOutGuest
            // 
            btnCheckOutGuest.BackColor = Color.White;
            btnCheckOutGuest.Cursor = Cursors.Hand;
            btnCheckOutGuest.FlatAppearance.BorderColor = Color.LightGray;
            btnCheckOutGuest.FlatStyle = FlatStyle.Flat;
            btnCheckOutGuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOutGuest.ForeColor = Color.FromArgb(23, 45, 80);
            btnCheckOutGuest.Location = new Point(370, 535);
            btnCheckOutGuest.Name = "btnCheckOutGuest";
            btnCheckOutGuest.Size = new Size(170, 45);
            btnCheckOutGuest.TabIndex = 3;
            btnCheckOutGuest.Text = "Check-Out (Completed)";
            btnCheckOutGuest.UseVisualStyleBackColor = false;
            btnCheckOutGuest.Click += btnCheckOutGuest_Click;
            // 
            // btnCheckInGuest
            // 
            btnCheckInGuest.BackColor = Color.FromArgb(39, 174, 96);
            btnCheckInGuest.Cursor = Cursors.Hand;
            btnCheckInGuest.FlatAppearance.BorderSize = 0;
            btnCheckInGuest.FlatStyle = FlatStyle.Flat;
            btnCheckInGuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckInGuest.ForeColor = Color.White;
            btnCheckInGuest.Location = new Point(190, 535);
            btnCheckInGuest.Name = "btnCheckInGuest";
            btnCheckInGuest.Size = new Size(160, 45);
            btnCheckInGuest.TabIndex = 2;
            btnCheckInGuest.Text = "Check-In Guest";
            btnCheckInGuest.UseVisualStyleBackColor = false;
            btnCheckInGuest.Click += btnCheckInGuest_Click;
            // 
            // btnApproveBooking
            // 
            btnApproveBooking.BackColor = Color.FromArgb(23, 45, 80);
            btnApproveBooking.Cursor = Cursors.Hand;
            btnApproveBooking.FlatAppearance.BorderSize = 0;
            btnApproveBooking.FlatStyle = FlatStyle.Flat;
            btnApproveBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApproveBooking.ForeColor = Color.White;
            btnApproveBooking.Location = new Point(0, 535);
            btnApproveBooking.Name = "btnApproveBooking";
            btnApproveBooking.Size = new Size(170, 45);
            btnApproveBooking.TabIndex = 1;
            btnApproveBooking.Text = "Confirm Booking";
            btnApproveBooking.UseVisualStyleBackColor = false;
            btnApproveBooking.Click += btnApproveBooking_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle3.ForeColor = Color.White;
            dgvStyle3.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dgvStyle3;
            dgvBookings.ColumnHeadersHeight = 40;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.Location = new Point(0, 10);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle4.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle4.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvBookings.RowsDefaultCellStyle = dgvStyle4;
            dgvBookings.RowTemplate.Height = 36;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1000, 500);
            dgvBookings.TabIndex = 0;
            // 
            // pnlViewUsers
            // 
            pnlViewUsers.Controls.Add(dgvUsers);
            pnlViewUsers.Location = new Point(25, 75);
            pnlViewUsers.Name = "pnlViewUsers";
            pnlViewUsers.Size = new Size(1000, 600);
            pnlViewUsers.TabIndex = 4;
            pnlViewUsers.Visible = false;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle5.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle5.ForeColor = Color.White;
            dgvStyle5.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle5.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle5.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dgvStyle5;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(0, 10);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle6.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle6.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvUsers.RowsDefaultCellStyle = dgvStyle6;
            dgvUsers.RowTemplate.Height = 36;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1000, 560);
            dgvUsers.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 760);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrandStay Admin Operations Console";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlAdminProfile.ResumeLayout(false);
            pnlAdminProfile.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlViewOverview.ResumeLayout(false);
            pnlKpi4.ResumeLayout(false);
            pnlKpi4.PerformLayout();
            pnlKpi3.ResumeLayout(false);
            pnlKpi3.PerformLayout();
            pnlKpi2.ResumeLayout(false);
            pnlKpi2.PerformLayout();
            pnlKpi1.ResumeLayout(false);
            pnlKpi1.PerformLayout();
            pnlViewRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            pnlViewBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            pnlViewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Button btnClose;
        private Button btnMin;
        private Panel pnlSidebar;
        private Panel pnlAdminProfile;
        private Label lblAdminName;
        private Label lblAdminRole;
        private Button btnNavOverview;
        private Button btnNavRooms;
        private Button btnNavBookings;
        private Button btnNavUsers;
        private Button btnNavExit;
        private Panel pnlContent;
        private Label lblPageTitle;
        private Panel pnlViewOverview;
        private Label lblOverviewHeading;
        private Panel pnlKpi1;
        private Label lblKpi1Title;
        private Label lblKpi1Value;
        private Panel pnlKpi2;
        private Label lblKpi2Title;
        private Label lblKpi2Value;
        private Panel pnlKpi3;
        private Label lblKpi3Title;
        private Label lblKpi3Value;
        private Panel pnlKpi4;
        private Label lblKpi4Title;
        private Label lblKpi4Value;
        private Panel pnlViewRooms;
        private DataGridView dgvRooms;
        private Button btnAddRoom;
        private Button btnToggleRoomStatus;
        private Panel pnlViewBookings;
        private DataGridView dgvBookings;
        private Button btnApproveBooking;
        private Button btnCheckInGuest;
        private Button btnCheckOutGuest;
        private Button btnCancelBookingAdmin;
        private Panel pnlViewUsers;
        private DataGridView dgvUsers;
    }
}
