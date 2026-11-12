using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class AdminDashboardForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private DataTable dtAdminBookings = new DataTable();
        private DataTable dtAdminRooms = new DataTable();
        private DataTable dtAdminUsers = new DataTable();

        public AdminDashboardForm()
        {
            InitializeComponent();
            InitializeData();
            ShowView("Overview");
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = "🗖";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "🗗";
            }
        }

        private void pnlKpi_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel pnl)
            {
                using var pen = new Pen(Color.FromArgb(220, 226, 235), 1.5f);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void InitializeData()
        {
            if (SessionManager.IsLoggedIn)
            {
                lblAdminName.Text = SessionManager.CurrentUserName;
            }

            if (cmbFilterDest.Items.Count > 0 && cmbFilterDest.SelectedIndex < 0)
            {
                cmbFilterDest.SelectedIndex = 0;
            }

            if (cmbFilterStatus.Items.Count > 0 && cmbFilterStatus.SelectedIndex < 0)
            {
                cmbFilterStatus.SelectedIndex = 0;
            }

            RefreshKpiCards();
            RefreshBookingsGrid();
            RefreshRoomsGrid();
            RefreshUsersGrid();
        }

        private void RefreshKpiCards()
        {
            var kpis = DatabaseHelper.GetDashboardKpis();
            lblKpi1Value.Text = $"$ {kpis.revenue:N2}";
            lblKpi2Value.Text = kpis.totalBookings.ToString();
            lblKpi3Value.Text = $"{kpis.occupancyRate:F1}%";
            lblKpi4Value.Text = kpis.availableRooms.ToString();
        }

        private void RefreshBookingsGrid()
        {
            var dt = DatabaseHelper.GetAllBookingsTable();
            if (dt.Rows.Count > 0)
            {
                dgvBookings.DataSource = dt;
            }
            else
            {
                // Fallback demo data
                dtAdminBookings.Clear();
                if (dtAdminBookings.Columns.Count == 0)
                {
                    dtAdminBookings.Columns.Add("ID", typeof(int));
                    dtAdminBookings.Columns.Add("Ref #", typeof(string));
                    dtAdminBookings.Columns.Add("Guest Name", typeof(string));
                    dtAdminBookings.Columns.Add("Room", typeof(string));
                    dtAdminBookings.Columns.Add("Room #", typeof(string));
                    dtAdminBookings.Columns.Add("Location", typeof(string));
                    dtAdminBookings.Columns.Add("Check In", typeof(string));
                    dtAdminBookings.Columns.Add("Check Out", typeof(string));
                    dtAdminBookings.Columns.Add("Nights", typeof(int));
                    dtAdminBookings.Columns.Add("Total ($)", typeof(string));
                    dtAdminBookings.Columns.Add("Status", typeof(string));
                    dtAdminBookings.Columns.Add("Payment", typeof(string));
                }

                dtAdminBookings.Rows.Add(1, "GST-2026-101", "John Doe", "Royal Riverfront Suite", "PP-101", "Phnom Penh", "2026-11-20", "2026-11-23", 3, "$ 495.00", "Confirmed", "Paid");
                dtAdminBookings.Rows.Add(2, "GST-2026-102", "Davin Seng", "Angkor Heritage Villa", "SR-201", "Siem Reap", "2026-11-22", "2026-11-25", 3, "$ 585.00", "Checked In", "Paid");
                dgvBookings.DataSource = dtAdminBookings;
            }
        }

        private void RefreshRoomsGrid()
        {
            var dt = DatabaseHelper.GetAllRoomsTable();
            if (dt.Rows.Count > 0)
            {
                dtAdminRooms = dt;
            }
            else
            {
                // Fallback demo data
                dtAdminRooms.Clear();
                if (dtAdminRooms.Columns.Count == 0)
                {
                    dtAdminRooms.Columns.Add("id", typeof(int));
                    dtAdminRooms.Columns.Add("room_number", typeof(string));
                    dtAdminRooms.Columns.Add("room_name", typeof(string));
                    dtAdminRooms.Columns.Add("room_type", typeof(string));
                    dtAdminRooms.Columns.Add("destination", typeof(string));
                    dtAdminRooms.Columns.Add("price_per_night", typeof(decimal));
                    dtAdminRooms.Columns.Add("max_adults", typeof(int));
                    dtAdminRooms.Columns.Add("max_children", typeof(int));
                    dtAdminRooms.Columns.Add("status", typeof(string));
                    dtAdminRooms.Columns.Add("amenities", typeof(string));
                }

                dtAdminRooms.Rows.Add(1, "PP-101", "Grand Royal Riverfront Suite", "Suite", "Phnom Penh", 185.00m, 2, 1, "Available", "King Bed, City View, Free WiFi, Bathtub");
                dtAdminRooms.Rows.Add(2, "SR-201", "Angkor Heritage Garden Villa", "Suite", "Siem Reap", 230.00m, 3, 2, "Available", "King Bed, Private Garden, Pool Access");
            }

            ApplyRoomFilters();
            FormatRoomsColumns();
        }

        private void FormatRoomsColumns()
        {
            if (dgvRooms.Columns["id"] is DataGridViewColumn colId)
            {
                colId.HeaderText = "ID";
                colId.FillWeight = 40;
            }
            if (dgvRooms.Columns["room_number"] is DataGridViewColumn colRoomNum)
            {
                colRoomNum.HeaderText = "Room #";
                colRoomNum.FillWeight = 70;
            }
            if (dgvRooms.Columns["room_name"] is DataGridViewColumn colRoomName)
            {
                colRoomName.HeaderText = "Room Name";
                colRoomName.FillWeight = 160;
            }
            if (dgvRooms.Columns["room_type"] is DataGridViewColumn colRoomType)
            {
                colRoomType.HeaderText = "Category";
                colRoomType.FillWeight = 85;
            }
            if (dgvRooms.Columns["destination"] is DataGridViewColumn colDest)
            {
                colDest.HeaderText = "Destination";
                colDest.FillWeight = 95;
            }
            if (dgvRooms.Columns["price_per_night"] is DataGridViewColumn colPrice)
            {
                colPrice.HeaderText = "Price / Night";
                colPrice.DefaultCellStyle.Format = "C2";
                colPrice.FillWeight = 85;
            }
            if (dgvRooms.Columns["max_adults"] is DataGridViewColumn colAdults)
            {
                colAdults.HeaderText = "Adults";
                colAdults.FillWeight = 50;
            }
            if (dgvRooms.Columns["max_children"] is DataGridViewColumn colKids)
            {
                colKids.HeaderText = "Kids";
                colKids.FillWeight = 45;
            }
            if (dgvRooms.Columns["status"] is DataGridViewColumn colStatus)
            {
                colStatus.HeaderText = "Status";
                colStatus.FillWeight = 80;
            }
            if (dgvRooms.Columns["amenities"] is DataGridViewColumn colAmenities)
            {
                colAmenities.HeaderText = "Amenities";
                colAmenities.FillWeight = 150;
            }
        }

        private void ApplyRoomFilters()
        {
            if (dtAdminRooms == null || dtAdminRooms.DefaultView == null) return;

            var filterParts = new List<string>();

            string search = txtRoomSearch.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(search))
            {
                filterParts.Add($"(room_number LIKE '%{search}%' OR room_name LIKE '%{search}%' OR room_type LIKE '%{search}%')");
            }

            if (cmbFilterDest.SelectedIndex > 0 && cmbFilterDest.SelectedItem != null)
            {
                string dest = cmbFilterDest.SelectedItem.ToString()!.Replace("'", "''");
                filterParts.Add($"destination = '{dest}'");
            }

            if (cmbFilterStatus.SelectedIndex > 0 && cmbFilterStatus.SelectedItem != null)
            {
                string status = cmbFilterStatus.SelectedItem.ToString()!.Replace("'", "''");
                filterParts.Add($"status = '{status}'");
            }

            dtAdminRooms.DefaultView.RowFilter = string.Join(" AND ", filterParts);
            dgvRooms.DataSource = dtAdminRooms.DefaultView;
        }

        private void txtRoomSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyRoomFilters();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyRoomFilters();
        }

        private void RefreshUsersGrid()
        {
            var dt = DatabaseHelper.GetAllUsersTable();
            if (dt.Rows.Count > 0)
            {
                dgvUsers.DataSource = dt;
            }
            else
            {
                dtAdminUsers.Clear();
                if (dtAdminUsers.Columns.Count == 0)
                {
                    dtAdminUsers.Columns.Add("id", typeof(int));
                    dtAdminUsers.Columns.Add("full_name", typeof(string));
                    dtAdminUsers.Columns.Add("email", typeof(string));
                    dtAdminUsers.Columns.Add("phone", typeof(string));
                    dtAdminUsers.Columns.Add("role", typeof(string));
                }

                foreach (var user in SessionManager.GetAllUsers())
                {
                    dtAdminUsers.Rows.Add(user.Id, user.FullName, user.Email, user.Phone, user.Role);
                }

                dgvUsers.DataSource = dtAdminUsers;
            }
        }

        private void ShowView(string viewName)
        {
            // Reset sidebar active indicators
            btnNavOverview.BackColor = Color.FromArgb(17, 34, 60);
            btnNavRooms.BackColor = Color.FromArgb(17, 34, 60);
            btnNavBookings.BackColor = Color.FromArgb(17, 34, 60);
            btnNavUsers.BackColor = Color.FromArgb(17, 34, 60);

            pnlViewOverview.Visible = false;
            pnlViewRooms.Visible = false;
            pnlViewBookings.Visible = false;
            pnlViewUsers.Visible = false;

            switch (viewName)
            {
                case "Overview":
                    btnNavOverview.BackColor = Color.FromArgb(23, 45, 80);
                    pnlViewOverview.Visible = true;
                    lblPageTitle.Text = "📊 Operations Overview & Analytics";
                    break;
                case "Rooms":
                    btnNavRooms.BackColor = Color.FromArgb(23, 45, 80);
                    pnlViewRooms.Visible = true;
                    lblPageTitle.Text = "🛏️ Hotel Inventory & Room Management";
                    break;
                case "Bookings":
                    btnNavBookings.BackColor = Color.FromArgb(23, 45, 80);
                    pnlViewBookings.Visible = true;
                    lblPageTitle.Text = "📋 Guest Reservations & Check-In Control";
                    break;
                case "Users":
                    btnNavUsers.BackColor = Color.FromArgb(23, 45, 80);
                    pnlViewUsers.Visible = true;
                    lblPageTitle.Text = "👥 Customer Directory & Staff Accounts";
                    break;
            }
        }

        private void btnNavOverview_Click(object sender, EventArgs e) => ShowView("Overview");
        private void btnNavRooms_Click(object sender, EventArgs e) => ShowView("Rooms");
        private void btnNavBookings_Click(object sender, EventArgs e) => ShowView("Bookings");
        private void btnNavUsers_Click(object sender, EventArgs e) => ShowView("Users");

        private void btnNavExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Booking Status Controls ---
        private void btnApproveBooking_Click(object sender, EventArgs e)
        {
            UpdateSelectedBookingStatus("Confirmed");
        }

        private void btnCheckInGuest_Click(object sender, EventArgs e)
        {
            UpdateSelectedBookingStatus("Checked In");
        }

        private void btnCheckOutGuest_Click(object sender, EventArgs e)
        {
            UpdateSelectedBookingStatus("Completed");
        }

        private void btnCancelBookingAdmin_Click(object sender, EventArgs e)
        {
            UpdateSelectedBookingStatus("Cancelled");
        }

        private void UpdateSelectedBookingStatus(string newStatus)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvBookings.SelectedRows[0];
            string refCode = (row.Cells["Ref #"]?.Value ?? row.Cells["Booking Ref"]?.Value)?.ToString() ?? "";

            if (row.Cells["ID"]?.Value != null &&
                int.TryParse(row.Cells["ID"].Value?.ToString(), out int bId) && bId > 0)
            {
                DatabaseHelper.UpdateBookingStatus(bId, newStatus);
            }

            if (row.Cells["Status"] != null) row.Cells["Status"].Value = newStatus;

            RefreshKpiCards();
            MessageBox.Show($"Booking {refCode} status updated to: {newStatus}", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Room Management Actions (CRUD) ---
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            using var form = new RoomEditorForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshRoomsGrid();
                RefreshKpiCards();
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            EditSelectedRoom();
        }

        private void dgvRooms_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedRoom();
        }

        private void EditSelectedRoom()
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room from the inventory table to edit.", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvRooms.SelectedRows[0];
            if (row.Cells["id"]?.Value != null && int.TryParse(row.Cells["id"].Value?.ToString(), out int roomId) && roomId > 0)
            {
                using var form = new RoomEditorForm(roomId);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshRoomsGrid();
                    RefreshKpiCards();
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room from the inventory table to delete.", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvRooms.SelectedRows[0];
            string roomNum = row.Cells["room_number"]?.Value?.ToString() ?? "";
            string roomName = row.Cells["room_name"]?.Value?.ToString() ?? "";

            if (row.Cells["id"]?.Value != null && int.TryParse(row.Cells["id"].Value?.ToString(), out int roomId) && roomId > 0)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete room '{roomNum} - {roomName}'?\n\nThis will remove the room from the active inventory permanently.",
                    "Confirm Delete Room",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (DatabaseHelper.DeleteRoom(roomId, out string errorMessage))
                    {
                        MessageBox.Show($"Room '{roomNum}' deleted successfully.", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshRoomsGrid();
                        RefreshKpiCards();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Cannot Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnToggleRoomStatus_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to update its status.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvRooms.SelectedRows[0];
            string currentStatus = (row.Cells["status"]?.Value ?? row.Cells["Status"]?.Value)?.ToString() ?? "Available";
            string nextStatus = currentStatus == "Available" ? "Maintenance" : "Available";

            if (row.Cells["id"]?.Value != null &&
                int.TryParse(row.Cells["id"].Value?.ToString(), out int rId) && rId > 0)
            {
                DatabaseHelper.UpdateRoomStatus(rId, nextStatus);
            }

            if (row.Cells["status"] != null) row.Cells["status"].Value = nextStatus;
            if (row.Cells["Status"] != null) row.Cells["Status"].Value = nextStatus;

            RefreshKpiCards();
            MessageBox.Show($"Room status updated to: {nextStatus}", "Room Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
