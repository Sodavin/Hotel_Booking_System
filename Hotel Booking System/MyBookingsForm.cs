using System.Data;
using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class MyBookingsForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private DataTable dtBookings = new DataTable();

        public MyBookingsForm()
        {
            InitializeComponent();
            LoadBookings();
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

        private void LoadBookings()
        {
            if (SessionManager.IsLoggedIn)
            {
                lblUserBadge.Text = $"Active Reservations for {SessionManager.CurrentUserName}";
                lblUserBadge.ForeColor = Color.FromArgb(23, 45, 80);
                pnlGuestNotice.Visible = false;

                // Query MySQL database for logged in user's bookings
                var dbTable = DatabaseHelper.GetBookingsForUser(SessionManager.CurrentUserId, SessionManager.CurrentUserEmail);
                if (dbTable.Rows.Count > 0)
                {
                    dgvBookings.DataSource = dbTable;
                    return;
                }
            }
            else
            {
                lblUserBadge.Text = "Browsing Reservations as Guest";
                lblUserBadge.ForeColor = Color.DimGray;
                pnlGuestNotice.Visible = true;
            }

            // Fallback sample data if no reservations in DB
            dtBookings.Clear();
            if (dtBookings.Columns.Count == 0)
            {
                dtBookings.Columns.Add("BookingId", typeof(int));
                dtBookings.Columns.Add("Booking Ref", typeof(string));
                dtBookings.Columns.Add("Room Name", typeof(string));
                dtBookings.Columns.Add("Destination", typeof(string));
                dtBookings.Columns.Add("Check In", typeof(string));
                dtBookings.Columns.Add("Check Out", typeof(string));
                dtBookings.Columns.Add("Nights", typeof(int));
                dtBookings.Columns.Add("Total ($)", typeof(string));
                dtBookings.Columns.Add("Status", typeof(string));
            }

            if (SessionManager.IsLoggedIn)
            {
                dtBookings.Rows.Add(1, "GST-2026-081", "Grand Royal Suite", "Phnom Penh", "2026-11-20", "2026-11-23", 3, "$ 450.00", "Confirmed");
                dtBookings.Rows.Add(2, "GST-2026-042", "Angkor View Villa", "Siem Reap", "2026-12-15", "2026-12-18", 3, "$ 580.00", "Confirmed");
            }
            else
            {
                dtBookings.Rows.Add(0, "GST-DEMO-01", "Sample Deluxe Room", "Siem Reap", "2026-11-15", "2026-11-17", 2, "$ 220.00", "Sample");
            }

            dgvBookings.DataSource = dtBookings;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvBookings.SelectedRows[0];
            string bookingRef = (row.Cells["Booking Ref"]?.Value ?? row.Cells["Ref #"]?.Value)?.ToString() ?? "";
            string status = row.Cells["Status"]?.Value?.ToString() ?? "";

            if (status == "Cancelled")
            {
                MessageBox.Show("This booking has already been cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you wish to cancel reservation {bookingRef}?\n\nRefund policies apply based on check-in notice.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (row.Cells["BookingId"]?.Value != null &&
                    int.TryParse(row.Cells["BookingId"].Value?.ToString(), out int bId) && bId > 0)
                {
                    DatabaseHelper.UpdateBookingStatus(bId, "Cancelled");
                }

                if (row.Cells["Status"] != null)
                {
                    row.Cells["Status"].Value = "Cancelled";
                }
                MessageBox.Show($"Reservation {bookingRef} has been successfully cancelled.", "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
