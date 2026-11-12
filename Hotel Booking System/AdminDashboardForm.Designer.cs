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
            btnMax = new Button();
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
            txtRoomSearch = new TextBox();
            lblFilterDest = new Label();
            cmbFilterDest = new ComboBox();
            lblFilterStatus = new Label();
            cmbFilterStatus = new ComboBox();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnDeleteRoom = new Button();
            btnToggleRoomStatus = new Button();
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
            pnlHeader.Controls.Add(btnMax);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1920, 58);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(25, 14);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(540, 30);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "GrandStay Operations Console — Master Admin Portal";
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
            btnMin.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(1775, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(44, 44);
            btnMin.TabIndex = 2;
            btnMin.Text = "—";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.Cursor = Cursors.Hand;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMax.ForeColor = Color.White;
            btnMax.Location = new Point(1822, 7);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(44, 44);
            btnMax.TabIndex = 1;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1869, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 44);
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
            pnlSidebar.Location = new Point(0, 58);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(290, 1022);
            pnlSidebar.TabIndex = 1;
            // 
            // btnNavExit
            // 
            btnNavExit.BackColor = Color.FromArgb(17, 34, 60);
            btnNavExit.Cursor = Cursors.Hand;
            btnNavExit.Dock = DockStyle.Bottom;
            btnNavExit.FlatAppearance.BorderSize = 0;
            btnNavExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 20, 30);
            btnNavExit.FlatStyle = FlatStyle.Flat;
            btnNavExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavExit.ForeColor = Color.Salmon;
            btnNavExit.Location = new Point(0, 957);
            btnNavExit.Name = "btnNavExit";
            btnNavExit.Padding = new Padding(30, 0, 15, 0);
            btnNavExit.Size = new Size(290, 65);
            btnNavExit.TabIndex = 5;
            btnNavExit.Text = "🚪  Exit Dashboard";
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
            btnNavUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 95);
            btnNavUsers.FlatStyle = FlatStyle.Flat;
            btnNavUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavUsers.ForeColor = Color.Gainsboro;
            btnNavUsers.Location = new Point(0, 310);
            btnNavUsers.Name = "btnNavUsers";
            btnNavUsers.Padding = new Padding(30, 0, 15, 0);
            btnNavUsers.Size = new Size(290, 65);
            btnNavUsers.TabIndex = 4;
            btnNavUsers.Text = "👥  User Directory";
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
            btnNavBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 95);
            btnNavBookings.FlatStyle = FlatStyle.Flat;
            btnNavBookings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavBookings.ForeColor = Color.Gainsboro;
            btnNavBookings.Location = new Point(0, 245);
            btnNavBookings.Name = "btnNavBookings";
            btnNavBookings.Padding = new Padding(30, 0, 15, 0);
            btnNavBookings.Size = new Size(290, 65);
            btnNavBookings.TabIndex = 3;
            btnNavBookings.Text = "📋  Guest Bookings";
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
            btnNavRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 95);
            btnNavRooms.FlatStyle = FlatStyle.Flat;
            btnNavRooms.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavRooms.ForeColor = Color.Gainsboro;
            btnNavRooms.Location = new Point(0, 180);
            btnNavRooms.Name = "btnNavRooms";
            btnNavRooms.Padding = new Padding(30, 0, 15, 0);
            btnNavRooms.Size = new Size(290, 65);
            btnNavRooms.TabIndex = 2;
            btnNavRooms.Text = "🛏️  Room Inventory";
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
            btnNavOverview.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 95);
            btnNavOverview.FlatStyle = FlatStyle.Flat;
            btnNavOverview.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavOverview.ForeColor = Color.White;
            btnNavOverview.Location = new Point(0, 115);
            btnNavOverview.Name = "btnNavOverview";
            btnNavOverview.Padding = new Padding(30, 0, 15, 0);
            btnNavOverview.Size = new Size(290, 65);
            btnNavOverview.TabIndex = 1;
            btnNavOverview.Text = "📊  Overview";
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
            pnlAdminProfile.Size = new Size(290, 115);
            pnlAdminProfile.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            lblAdminRole.AutoSize = true;
            lblAdminRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminRole.ForeColor = Color.LightSteelBlue;
            lblAdminRole.Location = new Point(25, 62);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(136, 21);
            lblAdminRole.TabIndex = 1;
            lblAdminRole.Text = "Super Admin Role";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(23, 26);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(174, 28);
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
            pnlContent.Location = new Point(290, 58);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(35, 25, 35, 25);
            pnlContent.Size = new Size(1630, 1022);
            pnlContent.TabIndex = 2;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(23, 45, 80);
            lblPageTitle.Location = new Point(35, 22);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(525, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "📊 Operations Overview & Analytics";
            // 
            // pnlViewOverview
            // 
            pnlViewOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlViewOverview.Controls.Add(pnlKpi4);
            pnlViewOverview.Controls.Add(pnlKpi3);
            pnlViewOverview.Controls.Add(pnlKpi2);
            pnlViewOverview.Controls.Add(pnlKpi1);
            pnlViewOverview.Controls.Add(lblOverviewHeading);
            pnlViewOverview.Location = new Point(35, 80);
            pnlViewOverview.Name = "pnlViewOverview";
            pnlViewOverview.Size = new Size(1560, 910);
            pnlViewOverview.TabIndex = 1;
            // 
            // pnlKpi4
            // 
            pnlKpi4.BackColor = Color.White;
            pnlKpi4.Controls.Add(lblKpi4Value);
            pnlKpi4.Controls.Add(lblKpi4Title);
            pnlKpi4.Location = new Point(1170, 20);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(365, 145);
            pnlKpi4.TabIndex = 4;
            pnlKpi4.Paint += pnlKpi_Paint;
            // 
            // lblKpi4Value
            // 
            lblKpi4Value.AutoSize = true;
            lblKpi4Value.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi4Value.ForeColor = Color.FromArgb(41, 128, 185);
            lblKpi4Value.Location = new Point(20, 68);
            lblKpi4Value.Name = "lblKpi4Value";
            lblKpi4Value.Size = new Size(181, 47);
            lblKpi4Value.TabIndex = 1;
            lblKpi4Value.Text = "18 Rooms";
            // 
            // lblKpi4Title
            // 
            lblKpi4Title.AutoSize = true;
            lblKpi4Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi4Title.ForeColor = Color.DimGray;
            lblKpi4Title.Location = new Point(20, 22);
            lblKpi4Title.Name = "lblKpi4Title";
            lblKpi4Title.Size = new Size(157, 25);
            lblKpi4Title.TabIndex = 0;
            lblKpi4Title.Text = "Available Rooms";
            // 
            // pnlKpi3
            // 
            pnlKpi3.BackColor = Color.White;
            pnlKpi3.Controls.Add(lblKpi3Value);
            pnlKpi3.Controls.Add(lblKpi3Title);
            pnlKpi3.Location = new Point(780, 20);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(365, 145);
            pnlKpi3.TabIndex = 3;
            pnlKpi3.Paint += pnlKpi_Paint;
            // 
            // lblKpi3Value
            // 
            lblKpi3Value.AutoSize = true;
            lblKpi3Value.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi3Value.ForeColor = Color.FromArgb(142, 68, 173);
            lblKpi3Value.Location = new Point(20, 68);
            lblKpi3Value.Name = "lblKpi3Value";
            lblKpi3Value.Size = new Size(116, 47);
            lblKpi3Value.TabIndex = 1;
            lblKpi3Value.Text = "86.4%";
            // 
            // lblKpi3Title
            // 
            lblKpi3Title.AutoSize = true;
            lblKpi3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi3Title.ForeColor = Color.DimGray;
            lblKpi3Title.Location = new Point(20, 22);
            lblKpi3Title.Name = "lblKpi3Title";
            lblKpi3Title.Size = new Size(157, 25);
            lblKpi3Title.TabIndex = 0;
            lblKpi3Title.Text = "Occupancy Rate";
            // 
            // pnlKpi2
            // 
            pnlKpi2.BackColor = Color.White;
            pnlKpi2.Controls.Add(lblKpi2Value);
            pnlKpi2.Controls.Add(lblKpi2Title);
            pnlKpi2.Location = new Point(390, 20);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(365, 145);
            pnlKpi2.TabIndex = 2;
            pnlKpi2.Paint += pnlKpi_Paint;
            // 
            // lblKpi2Value
            // 
            lblKpi2Value.AutoSize = true;
            lblKpi2Value.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi2Value.ForeColor = Color.FromArgb(230, 126, 34);
            lblKpi2Value.Location = new Point(20, 68);
            lblKpi2Value.Name = "lblKpi2Value";
            lblKpi2Value.Size = new Size(196, 47);
            lblKpi2Value.TabIndex = 1;
            lblKpi2Value.Text = "142 Active";
            // 
            // lblKpi2Title
            // 
            lblKpi2Title.AutoSize = true;
            lblKpi2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi2Title.ForeColor = Color.DimGray;
            lblKpi2Title.Location = new Point(20, 22);
            lblKpi2Title.Name = "lblKpi2Title";
            lblKpi2Title.Size = new Size(144, 25);
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
            pnlKpi1.Size = new Size(365, 145);
            pnlKpi1.TabIndex = 1;
            pnlKpi1.Paint += pnlKpi_Paint;
            // 
            // lblKpi1Value
            // 
            lblKpi1Value.AutoSize = true;
            lblKpi1Value.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi1Value.ForeColor = Color.FromArgb(39, 174, 96);
            lblKpi1Value.Location = new Point(20, 68);
            lblKpi1Value.Name = "lblKpi1Value";
            lblKpi1Value.Size = new Size(171, 47);
            lblKpi1Value.TabIndex = 1;
            lblKpi1Value.Text = "$ 48,250";
            // 
            // lblKpi1Title
            // 
            lblKpi1Title.AutoSize = true;
            lblKpi1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpi1Title.ForeColor = Color.DimGray;
            lblKpi1Title.Location = new Point(20, 22);
            lblKpi1Title.Name = "lblKpi1Title";
            lblKpi1Title.Size = new Size(138, 25);
            lblKpi1Title.TabIndex = 0;
            lblKpi1Title.Text = "Total Revenue";
            // 
            // lblOverviewHeading
            // 
            lblOverviewHeading.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverviewHeading.ForeColor = Color.FromArgb(70, 80, 95);
            lblOverviewHeading.Location = new Point(0, 195);
            lblOverviewHeading.Name = "lblOverviewHeading";
            lblOverviewHeading.Size = new Size(1540, 75);
            lblOverviewHeading.TabIndex = 0;
            lblOverviewHeading.Text = "Welcome to the GrandStay Administration Console. From here, hotel managers can monitor real-time revenue, supervise active reservations across all 6 Cambodian provinces, maintain scalable room inventory with full CRUD operations, and manage staff privileges.";
            // 
            // pnlViewRooms
            // 
            pnlViewRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlViewRooms.Controls.Add(txtRoomSearch);
            pnlViewRooms.Controls.Add(lblFilterDest);
            pnlViewRooms.Controls.Add(cmbFilterDest);
            pnlViewRooms.Controls.Add(lblFilterStatus);
            pnlViewRooms.Controls.Add(cmbFilterStatus);
            pnlViewRooms.Controls.Add(btnAddRoom);
            pnlViewRooms.Controls.Add(btnEditRoom);
            pnlViewRooms.Controls.Add(btnDeleteRoom);
            pnlViewRooms.Controls.Add(btnToggleRoomStatus);
            pnlViewRooms.Controls.Add(dgvRooms);
            pnlViewRooms.Location = new Point(35, 80);
            pnlViewRooms.Name = "pnlViewRooms";
            pnlViewRooms.Size = new Size(1560, 910);
            pnlViewRooms.TabIndex = 2;
            pnlViewRooms.Visible = false;
            // 
            // txtRoomSearch
            // 
            txtRoomSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomSearch.Location = new Point(0, 10);
            txtRoomSearch.Name = "txtRoomSearch";
            txtRoomSearch.PlaceholderText = "🔍 Search room # or name...";
            txtRoomSearch.Size = new Size(260, 32);
            txtRoomSearch.TabIndex = 0;
            txtRoomSearch.TextChanged += txtRoomSearch_TextChanged;
            // 
            // lblFilterDest
            // 
            lblFilterDest.AutoSize = true;
            lblFilterDest.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDest.ForeColor = Color.FromArgb(23, 45, 80);
            lblFilterDest.Location = new Point(280, 14);
            lblFilterDest.Name = "lblFilterDest";
            lblFilterDest.Size = new Size(91, 25);
            lblFilterDest.TabIndex = 1;
            lblFilterDest.Text = "Location:";
            // 
            // cmbFilterDest
            // 
            cmbFilterDest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterDest.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterDest.FormattingEnabled = true;
            cmbFilterDest.Items.AddRange(new object[] { "All Locations", "Phnom Penh", "Siem Reap", "Sihanoukville", "Kampot", "Battambang", "Kep" });
            cmbFilterDest.Location = new Point(395, 10);
            cmbFilterDest.Name = "cmbFilterDest";
            cmbFilterDest.Size = new Size(170, 31);
            cmbFilterDest.TabIndex = 2;
            cmbFilterDest.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterStatus.ForeColor = Color.FromArgb(23, 45, 80);
            lblFilterStatus.Location = new Point(595, 14);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(70, 25);
            lblFilterStatus.TabIndex = 3;
            lblFilterStatus.Text = "Status:";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "All Statuses", "Available", "Occupied", "Maintenance", "Reserved" });
            cmbFilterStatus.Location = new Point(685, 10);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(160, 31);
            cmbFilterStatus.TabIndex = 4;
            cmbFilterStatus.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(23, 45, 80);
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(875, 5);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(155, 42);
            btnAddRoom.TabIndex = 5;
            btnAddRoom.Text = "➕ Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.White;
            btnEditRoom.Cursor = Cursors.Hand;
            btnEditRoom.FlatAppearance.BorderColor = Color.FromArgb(23, 45, 80);
            btnEditRoom.FlatStyle = FlatStyle.Flat;
            btnEditRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRoom.ForeColor = Color.FromArgb(23, 45, 80);
            btnEditRoom.Location = new Point(1045, 5);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(135, 42);
            btnEditRoom.TabIndex = 6;
            btnEditRoom.Text = "✏️ Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.White;
            btnDeleteRoom.Cursor = Cursors.Hand;
            btnDeleteRoom.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDeleteRoom.FlatStyle = FlatStyle.Flat;
            btnDeleteRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRoom.ForeColor = Color.FromArgb(192, 57, 43);
            btnDeleteRoom.Location = new Point(1195, 5);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(145, 42);
            btnDeleteRoom.TabIndex = 7;
            btnDeleteRoom.Text = "🗑️ Delete Room";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // btnToggleRoomStatus
            // 
            btnToggleRoomStatus.BackColor = Color.White;
            btnToggleRoomStatus.Cursor = Cursors.Hand;
            btnToggleRoomStatus.FlatAppearance.BorderColor = Color.FromArgb(200, 215, 230);
            btnToggleRoomStatus.FlatStyle = FlatStyle.Flat;
            btnToggleRoomStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggleRoomStatus.ForeColor = Color.FromArgb(23, 45, 80);
            btnToggleRoomStatus.Location = new Point(1355, 5);
            btnToggleRoomStatus.Name = "btnToggleRoomStatus";
            btnToggleRoomStatus.Size = new Size(175, 42);
            btnToggleRoomStatus.TabIndex = 8;
            btnToggleRoomStatus.Text = "🔄 Toggle Status";
            btnToggleRoomStatus.UseVisualStyleBackColor = false;
            btnToggleRoomStatus.Click += btnToggleRoomStatus_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle1.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle1.ForeColor = Color.White;
            dgvStyle1.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dgvStyle1;
            dgvRooms.ColumnHeadersHeight = 46;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.Location = new Point(0, 60);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle2.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle2.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvRooms.RowsDefaultCellStyle = dgvStyle2;
            dgvRooms.RowTemplate.Height = 42;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1560, 840);
            dgvRooms.TabIndex = 9;
            dgvRooms.DoubleClick += dgvRooms_DoubleClick;
            // 
            // pnlViewBookings
            // 
            pnlViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlViewBookings.Controls.Add(btnCancelBookingAdmin);
            pnlViewBookings.Controls.Add(btnCheckOutGuest);
            pnlViewBookings.Controls.Add(btnCheckInGuest);
            pnlViewBookings.Controls.Add(btnApproveBooking);
            pnlViewBookings.Controls.Add(dgvBookings);
            pnlViewBookings.Location = new Point(35, 80);
            pnlViewBookings.Name = "pnlViewBookings";
            pnlViewBookings.Size = new Size(1560, 910);
            pnlViewBookings.TabIndex = 3;
            pnlViewBookings.Visible = false;
            // 
            // btnCancelBookingAdmin
            // 
            btnCancelBookingAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelBookingAdmin.BackColor = Color.White;
            btnCancelBookingAdmin.Cursor = Cursors.Hand;
            btnCancelBookingAdmin.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnCancelBookingAdmin.FlatStyle = FlatStyle.Flat;
            btnCancelBookingAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBookingAdmin.ForeColor = Color.FromArgb(192, 57, 43);
            btnCancelBookingAdmin.Location = new Point(660, 855);
            btnCancelBookingAdmin.Name = "btnCancelBookingAdmin";
            btnCancelBookingAdmin.Size = new Size(190, 48);
            btnCancelBookingAdmin.TabIndex = 4;
            btnCancelBookingAdmin.Text = "Cancel Booking";
            btnCancelBookingAdmin.UseVisualStyleBackColor = false;
            btnCancelBookingAdmin.Click += btnCancelBookingAdmin_Click;
            // 
            // btnCheckOutGuest
            // 
            btnCheckOutGuest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckOutGuest.BackColor = Color.White;
            btnCheckOutGuest.Cursor = Cursors.Hand;
            btnCheckOutGuest.FlatAppearance.BorderColor = Color.LightGray;
            btnCheckOutGuest.FlatStyle = FlatStyle.Flat;
            btnCheckOutGuest.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOutGuest.ForeColor = Color.FromArgb(23, 45, 80);
            btnCheckOutGuest.Location = new Point(420, 855);
            btnCheckOutGuest.Name = "btnCheckOutGuest";
            btnCheckOutGuest.Size = new Size(220, 48);
            btnCheckOutGuest.TabIndex = 3;
            btnCheckOutGuest.Text = "Check-Out (Completed)";
            btnCheckOutGuest.UseVisualStyleBackColor = false;
            btnCheckOutGuest.Click += btnCheckOutGuest_Click;
            // 
            // btnCheckInGuest
            // 
            btnCheckInGuest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckInGuest.BackColor = Color.FromArgb(39, 174, 96);
            btnCheckInGuest.Cursor = Cursors.Hand;
            btnCheckInGuest.FlatAppearance.BorderSize = 0;
            btnCheckInGuest.FlatStyle = FlatStyle.Flat;
            btnCheckInGuest.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckInGuest.ForeColor = Color.White;
            btnCheckInGuest.Location = new Point(210, 855);
            btnCheckInGuest.Name = "btnCheckInGuest";
            btnCheckInGuest.Size = new Size(190, 48);
            btnCheckInGuest.TabIndex = 2;
            btnCheckInGuest.Text = "Check-In Guest";
            btnCheckInGuest.UseVisualStyleBackColor = false;
            btnCheckInGuest.Click += btnCheckInGuest_Click;
            // 
            // btnApproveBooking
            // 
            btnApproveBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApproveBooking.BackColor = Color.FromArgb(23, 45, 80);
            btnApproveBooking.Cursor = Cursors.Hand;
            btnApproveBooking.FlatAppearance.BorderSize = 0;
            btnApproveBooking.FlatStyle = FlatStyle.Flat;
            btnApproveBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApproveBooking.ForeColor = Color.White;
            btnApproveBooking.Location = new Point(0, 855);
            btnApproveBooking.Name = "btnApproveBooking";
            btnApproveBooking.Size = new Size(190, 48);
            btnApproveBooking.TabIndex = 1;
            btnApproveBooking.Text = "Confirm Booking";
            btnApproveBooking.UseVisualStyleBackColor = false;
            btnApproveBooking.Click += btnApproveBooking_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle3.ForeColor = Color.White;
            dgvStyle3.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dgvStyle3;
            dgvBookings.ColumnHeadersHeight = 46;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.Location = new Point(0, 10);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle4.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle4.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvBookings.RowsDefaultCellStyle = dgvStyle4;
            dgvBookings.RowTemplate.Height = 42;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1560, 830);
            dgvBookings.TabIndex = 0;
            // 
            // pnlViewUsers
            // 
            pnlViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlViewUsers.Controls.Add(dgvUsers);
            pnlViewUsers.Location = new Point(35, 80);
            pnlViewUsers.Name = "pnlViewUsers";
            pnlViewUsers.Size = new Size(1560, 910);
            pnlViewUsers.TabIndex = 4;
            pnlViewUsers.Visible = false;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle5.BackColor = Color.FromArgb(23, 45, 80);
            dgvStyle5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStyle5.ForeColor = Color.White;
            dgvStyle5.SelectionBackColor = Color.FromArgb(35, 65, 110);
            dgvStyle5.SelectionForeColor = SystemColors.HighlightText;
            dgvStyle5.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dgvStyle5;
            dgvUsers.ColumnHeadersHeight = 46;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(0, 10);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStyle6.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvStyle6.SelectionForeColor = Color.FromArgb(23, 45, 80);
            dgvUsers.RowsDefaultCellStyle = dgvStyle6;
            dgvUsers.RowTemplate.Height = 42;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1560, 890);
            dgvUsers.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1920, 1080);
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
            pnlViewRooms.PerformLayout();
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
        private Button btnMax;
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
        private TextBox txtRoomSearch;
        private Label lblFilterDest;
        private ComboBox cmbFilterDest;
        private Label lblFilterStatus;
        private ComboBox cmbFilterStatus;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnDeleteRoom;
        private Button btnToggleRoomStatus;
        private DataGridView dgvRooms;
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
