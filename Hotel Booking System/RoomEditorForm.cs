using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class RoomEditorForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private readonly int _roomId = 0;
        private readonly bool _isEditMode = false;
        private bool _isInitializing = true;

        public RoomEditorForm()
        {
            InitializeComponent();
            _isEditMode = false;
            lblTitle.Text = "🛏️ Add New Room";
            btnSave.Text = "💾 Create Room";

            cmbDestination.SelectedIndex = 0;
            cmbRoomType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            _isInitializing = false;
            ApplyRoomTypeDefaults();
            UpdatePlaceholders();
        }

        public RoomEditorForm(int roomId) : this()
        {
            _roomId = roomId;
            _isEditMode = true;
            lblTitle.Text = "✏️ Edit Room Details";
            btnSave.Text = "💾 Save Changes";

            LoadRoomData(roomId);
        }

        private void LoadRoomData(int roomId)
        {
            _isInitializing = true;
            var room = DatabaseHelper.GetRoomById(roomId);
            if (room != null)
            {
                txtRoomNumber.Text = room.RoomNumber;
                txtRoomName.Text = room.RoomName;

                int destIdx = cmbDestination.Items.IndexOf(room.Destination);
                if (destIdx >= 0) cmbDestination.SelectedIndex = destIdx;
                else cmbDestination.Text = room.Destination;

                int typeIdx = cmbRoomType.Items.IndexOf(room.RoomType);
                if (typeIdx >= 0) cmbRoomType.SelectedIndex = typeIdx;
                else cmbRoomType.Text = room.RoomType;

                nudPrice.Value = Math.Clamp(room.PricePerNight, nudPrice.Minimum, nudPrice.Maximum);
                nudAdults.Value = Math.Clamp(room.MaxAdults, nudAdults.Minimum, nudAdults.Maximum);
                nudChildren.Value = Math.Clamp(room.MaxChildren, nudChildren.Minimum, nudChildren.Maximum);

                int statusIdx = cmbStatus.Items.IndexOf(room.Status);
                if (statusIdx >= 0) cmbStatus.SelectedIndex = statusIdx;
                else cmbStatus.Text = room.Status;

                txtAmenities.Text = room.Amenities;
                txtDescription.Text = room.Description;

                string childText = room.MaxChildren == 1 ? "1 Child" : $"{room.MaxChildren} Children";
                lblCapacityNote.Text = $"Current: {room.MaxAdults} Adults, {childText}";
            }
            else
            {
                MessageBox.Show("Room not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _isInitializing = false;
        }

        private static string GetDestinationPrefix(string destination)
        {
            return destination?.Trim() switch
            {
                "Phnom Penh" => "PP-",
                "Siem Reap" => "SR-",
                "Sihanoukville" => "SHV-",
                "Kampot" => "KPT-",
                "Battambang" => "BTB-",
                "Kep" => "KEP-",
                _ => "GST-"
            };
        }

        private static (int adults, int children, decimal defaultPrice) GetRoomTypeStandards(string roomType)
        {
            return roomType?.Trim() switch
            {
                "Deluxe" => (2, 1, 125.00m),
                "Suite" => (3, 2, 195.00m),
                "Executive" => (2, 2, 250.00m),
                "Presidential" => (4, 2, 450.00m),
                "Villa" => (4, 3, 320.00m),
                "Standard" => (2, 1, 85.00m),
                _ => (2, 1, 100.00m)
            };
        }

        private static string GetDefaultRoomName(string roomType, string destination)
        {
            string dest = string.IsNullOrWhiteSpace(destination) ? "GrandStay" : destination.Trim();
            return roomType?.Trim() switch
            {
                "Deluxe" => $"{dest} Deluxe Urban King Room",
                "Suite" => $"{dest} Premier Luxury Suite",
                "Executive" => $"{dest} Executive Club Suite",
                "Presidential" => $"{dest} Royal Presidential Suite",
                "Villa" => $"{dest} Private Garden Villa",
                "Standard" => $"{dest} Classic Comfort Room",
                _ => $"{dest} Superior Room"
            };
        }

        private static string GetDefaultAmenities(string roomType)
        {
            return roomType?.Trim() switch
            {
                "Deluxe" => "High-Speed WiFi, Air Conditioning, 55\" Smart TV, Rain Shower, Mini Bar, City View, Work Desk",
                "Suite" => "High-Speed WiFi, Air Conditioning, Living Room, King Bed, Marble Bathtub, Espresso Machine, Balcony, Minibar",
                "Executive" => "High-Speed WiFi, Air Conditioning, Executive Lounge Access, Panoramic View, King Bed, Bathtub, Smart TV, Free Breakfast",
                "Presidential" => "High-Speed WiFi, Private Butler, Infinity Jacuzzi, Panoramic Penthouse Terrace, VIP Lounge Access, Full Bar, Dining Area",
                "Villa" => "High-Speed WiFi, Air Conditioning, Private Swimming Pool, Tropical Garden, Sun Deck, Outdoor Shower, Kitchenette",
                "Standard" => "High-Speed WiFi, Air Conditioning, Flat-Screen TV, Coffee/Tea Maker, En-Suite Bathroom",
                _ => "High-Speed WiFi, Air Conditioning, Smart TV, En-Suite Bathroom"
            };
        }

        private void FormatRoomNumberWithDestination()
        {
            string dest = cmbDestination.Text.Trim();
            string prefix = GetDestinationPrefix(dest);
            if (string.IsNullOrEmpty(prefix)) return;

            string current = txtRoomNumber.Text.Trim();
            if (string.IsNullOrEmpty(current)) return;

            // Strip any existing known destination prefixes
            string[] knownPrefixes = { "PP-", "SR-", "SHV-", "KPT-", "BTB-", "KEP-", "KP-", "GST-" };
            string coreNumber = current;
            foreach (var p in knownPrefixes)
            {
                if (coreNumber.StartsWith(p, StringComparison.OrdinalIgnoreCase))
                {
                    coreNumber = coreNumber.Substring(p.Length);
                    break;
                }
            }

            coreNumber = coreNumber.TrimStart('-', ' ');

            if (!string.IsNullOrEmpty(coreNumber))
            {
                txtRoomNumber.Text = $"{prefix}{coreNumber}";
            }
        }

        private void ApplyRoomTypeDefaults()
        {
            if (_isInitializing || _isEditMode) return;

            string roomType = cmbRoomType.Text.Trim();
            var std = GetRoomTypeStandards(roomType);

            nudAdults.Value = Math.Clamp(std.adults, nudAdults.Minimum, nudAdults.Maximum);
            nudChildren.Value = Math.Clamp(std.children, nudChildren.Minimum, nudChildren.Maximum);
            nudPrice.Value = Math.Clamp(std.defaultPrice, nudPrice.Minimum, nudPrice.Maximum);

            string childText = std.children == 1 ? "1 Child" : $"{std.children} Children";
            lblCapacityNote.Text = $"✨ Standard: {std.adults} Adults, {childText} (Fully Editable)";
        }

        private void UpdatePlaceholders()
        {
            string prefix = GetDestinationPrefix(cmbDestination.Text);
            txtRoomNumber.PlaceholderText = $"e.g. 101 (Auto: {prefix}101)";

            string defName = GetDefaultRoomName(cmbRoomType.Text, cmbDestination.Text);
            txtRoomName.PlaceholderText = $"Auto: {defName}";

            txtAmenities.PlaceholderText = $"Auto: Curated {cmbRoomType.Text} luxury amenities package";
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitializing)
            {
                FormatRoomNumberWithDestination();
                UpdatePlaceholders();
            }
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitializing)
            {
                ApplyRoomTypeDefaults();
                UpdatePlaceholders();
            }
        }

        private void txtRoomNumber_Leave(object sender, EventArgs e)
        {
            FormatRoomNumberWithDestination();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Auto-format room number if only digits were typed
            FormatRoomNumberWithDestination();

            string roomNum = txtRoomNumber.Text.Trim();
            string destination = cmbDestination.Text.Trim();
            string roomType = cmbRoomType.Text.Trim();

            // Auto-fill room name with standard default if blank
            string roomName = txtRoomName.Text.Trim();
            if (string.IsNullOrWhiteSpace(roomName))
            {
                roomName = GetDefaultRoomName(roomType, destination);
                txtRoomName.Text = roomName;
            }

            decimal price = nudPrice.Value;
            int adults = (int)nudAdults.Value;
            int children = (int)nudChildren.Value;
            string status = cmbStatus.Text.Trim();

            // Auto-fill amenities with standard default if blank
            string amenities = txtAmenities.Text.Trim();
            if (string.IsNullOrWhiteSpace(amenities))
            {
                amenities = GetDefaultAmenities(roomType);
                txtAmenities.Text = amenities;
            }

            // Auto-fill description with standard default if blank
            string description = txtDescription.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                description = $"Experience unparalleled luxury and relaxation in our {roomName} located in {destination}, fully serviced with world-class amenities and 24/7 guest support.";
                txtDescription.Text = description;
            }

            // Validation
            if (string.IsNullOrWhiteSpace(roomNum))
            {
                MessageBox.Show("Please enter a room number or code (e.g. 101 or PP-101).", "Room Number Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please select a hotel destination location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDestination.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(roomType))
            {
                MessageBox.Show("Please select a room category type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomType.Focus();
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price per night must be greater than $0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrice.Focus();
                return;
            }

            var item = new RoomItem
            {
                Id = _roomId,
                RoomNumber = roomNum,
                RoomName = roomName,
                RoomType = roomType,
                Destination = destination,
                PricePerNight = price,
                MaxAdults = adults,
                MaxChildren = children,
                Status = status,
                Amenities = amenities,
                Description = description
            };

            bool success;
            string errorMessage = string.Empty;

            if (_isEditMode)
            {
                success = DatabaseHelper.UpdateRoom(item, out errorMessage);
            }
            else
            {
                success = DatabaseHelper.AddRoom(item, out errorMessage);
            }

            if (success)
            {
                string msg = _isEditMode
                    ? $"Room '{roomNum} - {roomName}' was updated successfully."
                    : $"Room '{roomNum} - {roomName}' was added to inventory successfully.";

                MessageBox.Show(msg, "Room Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlTip_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel pnl)
            {
                using var pen = new Pen(Color.FromArgb(195, 218, 245), 1f);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            // Optional separator above bottom action buttons
            using var pen = new Pen(Color.FromArgb(235, 240, 248), 1.5f);
            e.Graphics.DrawLine(pen, 30, 565, 790, 565);
        }
    }
}
