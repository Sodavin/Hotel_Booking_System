using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class RoomsForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private class RoomItem
        {
            public string Name { get; set; } = "";
            public string Location { get; set; } = "";
            public string Type { get; set; } = "";
            public decimal Price { get; set; }
            public string Capacity { get; set; } = "";
            public string Amenities { get; set; } = "";
        }

        private List<RoomItem> allRooms = new List<RoomItem>();

        public RoomsForm()
        {
            InitializeComponent();
            SeedRooms();
            cmbLocationFilter.SelectedIndex = 0;
            cmbTypeFilter.SelectedIndex = 0;
            FilterRooms();
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

        private void SeedRooms()
        {
            var dbRooms = DatabaseHelper.GetRooms();
            if (dbRooms.Count > 0)
            {
                allRooms = dbRooms.Select(r => new RoomItem
                {
                    Name = r.RoomName,
                    Location = r.Destination,
                    Type = r.RoomType,
                    Price = r.PricePerNight,
                    Capacity = $"{r.MaxAdults} Adults{(r.MaxChildren > 0 ? $", {r.MaxChildren} Child" : "")}",
                    Amenities = r.Amenities
                }).ToList();
                return;
            }

            allRooms = new List<RoomItem>
            {
                new RoomItem { Name = "Grand Royal Riverfront Suite", Location = "Phnom Penh", Type = "Executive Suite", Price = 165, Capacity = "2 Adults, 1 Child", Amenities = "River View • King Bed • Free Breakfast • Infinity Pool" },
                new RoomItem { Name = "Angkor Heritage Garden Villa", Location = "Siem Reap", Type = "Luxury Villa", Price = 195, Capacity = "3 Adults, 1 Child", Amenities = "Private Garden • Jacuzzi • Free Airport Transfer • Spa" },
                new RoomItem { Name = "Sihanoukville Pearl Oceanfront", Location = "Sihanoukville", Type = "Deluxe Sea View", Price = 145, Capacity = "2 Adults", Amenities = "Balcony • Sunset View • Beach Access • Free Wi-Fi" },
                new RoomItem { Name = "Bokor Mist Riverside Bungalow", Location = "Kampot", Type = "Deluxe Bungalow", Price = 95, Capacity = "2 Adults", Amenities = "Mountain View • Kayak Access • Fresh Pepper Dining" },
                new RoomItem { Name = "Colonial Elegance Heritage Room", Location = "Battambang", Type = "Heritage Deluxe", Price = 85, Capacity = "2 Adults", Amenities = "French Colonial Architecture • King Bed • Bathtub" },
                new RoomItem { Name = "Kep Crab Bay Tropical Villa", Location = "Kep", Type = "Ocean Villa", Price = 135, Capacity = "2 Adults, 2 Children", Amenities = "Seafood Terrace • Private Plunge Pool • Oceanfront" }
            };
        }

        private void FilterRooms()
        {
            string selectedLoc = cmbLocationFilter.SelectedItem?.ToString() ?? "All Locations";
            string selectedType = cmbTypeFilter.SelectedItem?.ToString() ?? "All Types";

            flpRoomsContainer.SuspendLayout();
            flpRoomsContainer.Controls.Clear();

            var filtered = allRooms.Where(r =>
                (selectedLoc == "All Locations" || r.Location.Equals(selectedLoc, StringComparison.OrdinalIgnoreCase)) &&
                (selectedType == "All Types" || r.Type.Contains(selectedType, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            lblResultCount.Text = $"Showing {filtered.Count} luxury accommodations";

            foreach (var room in filtered)
            {
                Panel card = CreateRoomCard(room);
                flpRoomsContainer.Controls.Add(card);
            }

            flpRoomsContainer.ResumeLayout();
        }

        private Panel CreateRoomCard(RoomItem room)
        {
            Panel card = new Panel
            {
                Size = new Size(465, 210),
                BackColor = Color.White,
                Margin = new Padding(10, 10, 10, 10)
            };

            Label lblName = new Label
            {
                Text = room.Name,
                Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(23, 45, 80),
                Location = new Point(16, 14),
                Size = new Size(430, 28)
            };

            Label lblLocType = new Label
            {
                Text = $"📍 {room.Location}  •  🏷️ {room.Type}",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(218, 140, 20),
                Location = new Point(16, 45),
                Size = new Size(430, 24)
            };

            Label lblAmenities = new Label
            {
                Text = $"✨ {room.Amenities}\n👥 {room.Capacity}",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                Location = new Point(16, 75),
                Size = new Size(430, 48)
            };

            Label lblPrice = new Label
            {
                Text = $"${room.Price:F0} / night",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(23, 45, 80),
                Location = new Point(16, 145),
                Size = new Size(180, 35)
            };

            Button btnSelect = new Button
            {
                Text = "Book Room",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(23, 45, 80),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Location = new Point(310, 140),
                Size = new Size(135, 42)
            };
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Click += (s, e) =>
            {
                MessageBox.Show(
                    $"You selected: {room.Name} ({room.Location})\nPrice: ${room.Price:F0}/night\n\nFull reservation checkout is scheduled for Step 4 & 5!",
                    "Room Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblLocType);
            card.Controls.Add(lblAmenities);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnSelect);

            return card;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRooms();
        }
    }
}
