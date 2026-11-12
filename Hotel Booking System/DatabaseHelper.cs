using System.Data;
using MySqlConnector;

namespace Hotel_Booking_System
{
    public class RoomItem
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = "";
        public string RoomName { get; set; } = "";
        public string RoomType { get; set; } = "";
        public string Destination { get; set; } = "";
        public decimal PricePerNight { get; set; }
        public int MaxAdults { get; set; } = 2;
        public int MaxChildren { get; set; } = 1;
        public string Amenities { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public string Status { get; set; } = "Available";
        public string Description { get; set; } = "";
    }

    public class BookingItem
    {
        public int Id { get; set; }
        public string BookingRef { get; set; } = "";
        public int? UserId { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; } = "";
        public string RoomNumber { get; set; } = "";
        public string Destination { get; set; } = "";
        public string GuestName { get; set; } = "";
        public string GuestEmail { get; set; } = "";
        public string GuestPhone { get; set; } = "";
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int TotalNights { get; set; }
        public int AdultsCount { get; set; }
        public int ChildrenCount { get; set; }
        public int RoomsCount { get; set; }
        public decimal TotalAmount { get; set; }
        public string BookingStatus { get; set; } = "Confirmed";
        public DateTime BookingDate { get; set; }
        public string PaymentMethod { get; set; } = "ABA KHQR";
        public string PaymentStatus { get; set; } = "Paid";
    }

    public static class DatabaseHelper
    {
        // Connection string configured for XAMPP MySQL running on port 3307
        public static string ConnectionString { get; set; } = 
            "Server=localhost;Port=3307;Database=grandstay_hotel;User ID=root;Password=;AllowPublicKeyRetrieval=True;SslMode=None;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection(out string errorMessage)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                errorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public static void InitializeDatabase()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                // 1. Create Users Table
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        full_name VARCHAR(100) NOT NULL,
                        email VARCHAR(120) NOT NULL UNIQUE,
                        password_hash VARCHAR(255) NOT NULL,
                        phone VARCHAR(30) NULL,
                        role VARCHAR(20) NOT NULL DEFAULT 'Customer',
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";

                // 2. Create Rooms Table
                string createRoomsTable = @"
                    CREATE TABLE IF NOT EXISTS rooms (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        room_number VARCHAR(20) NOT NULL UNIQUE,
                        room_name VARCHAR(100) NOT NULL,
                        room_type VARCHAR(50) NOT NULL,
                        destination VARCHAR(60) NOT NULL,
                        price_per_night DECIMAL(10,2) NOT NULL,
                        max_adults INT NOT NULL DEFAULT 2,
                        max_children INT NOT NULL DEFAULT 1,
                        amenities TEXT NULL,
                        image_path VARCHAR(255) NULL,
                        status VARCHAR(30) NOT NULL DEFAULT 'Available',
                        description TEXT NULL,
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";

                // 3. Create Bookings Table
                string createBookingsTable = @"
                    CREATE TABLE IF NOT EXISTS bookings (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        booking_ref VARCHAR(30) NOT NULL UNIQUE,
                        user_id INT NULL,
                        room_id INT NOT NULL,
                        guest_name VARCHAR(100) NOT NULL,
                        guest_email VARCHAR(120) NOT NULL,
                        guest_phone VARCHAR(30) NULL,
                        check_in_date DATE NOT NULL,
                        check_out_date DATE NOT NULL,
                        total_nights INT NOT NULL,
                        adults_count INT NOT NULL DEFAULT 1,
                        children_count INT NOT NULL DEFAULT 0,
                        rooms_count INT NOT NULL DEFAULT 1,
                        total_amount DECIMAL(10,2) NOT NULL,
                        booking_status VARCHAR(30) NOT NULL DEFAULT 'Confirmed',
                        booking_date DATETIME DEFAULT CURRENT_TIMESTAMP,
                        INDEX idx_user_id (user_id),
                        INDEX idx_room_id (room_id)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";

                // 4. Create Payments Table
                string createPaymentsTable = @"
                    CREATE TABLE IF NOT EXISTS payments (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        booking_id INT NOT NULL,
                        amount_paid DECIMAL(10,2) NOT NULL,
                        payment_method VARCHAR(50) NOT NULL DEFAULT 'ABA KHQR',
                        payment_status VARCHAR(30) NOT NULL DEFAULT 'Paid',
                        transaction_ref VARCHAR(60) NULL,
                        payment_date DATETIME DEFAULT CURRENT_TIMESTAMP,
                        INDEX idx_booking_id (booking_id)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";

                using (var cmd = new MySqlCommand(createUsersTable, conn)) cmd.ExecuteNonQuery();
                using (var cmd = new MySqlCommand(createRoomsTable, conn)) cmd.ExecuteNonQuery();
                using (var cmd = new MySqlCommand(createBookingsTable, conn)) cmd.ExecuteNonQuery();
                using (var cmd = new MySqlCommand(createPaymentsTable, conn)) cmd.ExecuteNonQuery();

                // Seed Default Users if empty
                SeedUsersIfEmpty(conn);

                // Seed Default Rooms across Cambodia if empty
                SeedRoomsIfEmpty(conn);

                // Seed Initial Bookings if empty
                SeedBookingsIfEmpty(conn);
            }
            catch (Exception ex)
            {
                // In university presentation or local debugging, write to console/log
                System.Diagnostics.Debug.WriteLine($"[DatabaseHelper Error]: {ex.Message}");
            }
        }

        private static void SeedUsersIfEmpty(MySqlConnection conn)
        {
            string checkUsers = "SELECT COUNT(*) FROM users;";
            using var cmdCheck = new MySqlCommand(checkUsers, conn);
            long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

            if (count == 0)
            {
                string insertUsers = @"
                    INSERT INTO users (full_name, email, password_hash, phone, role) VALUES 
                    ('Master Administrator', 'admin@grandstay.com', 'admin123', '+855 23 999 888', 'Admin'),
                    ('John Doe', 'john@example.com', '123456', '+855 12 345 678', 'Customer'),
                    ('Sophea Chan', 'sophea.chan@gmail.com', '123456', '+855 77 123 456', 'Customer');";

                using var cmdInsert = new MySqlCommand(insertUsers, conn);
                cmdInsert.ExecuteNonQuery();
            }
        }

        private static void SeedRoomsIfEmpty(MySqlConnection conn)
        {
            string checkRooms = "SELECT COUNT(*) FROM rooms;";
            using var cmdCheck = new MySqlCommand(checkRooms, conn);
            long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

            if (count == 0)
            {
                string insertRooms = @"
                    INSERT INTO rooms (room_number, room_name, room_type, destination, price_per_night, max_adults, max_children, amenities, status, description) VALUES
                    ('PP-101', 'Premier Mekong Riverview Suite', 'Suite', 'Phnom Penh', 185.00, 2, 1, 'WiFi, Pool, AC, Balcony, River View, Breakfast', 'Available', 'Panoramic views overlooking the Tonle Sap and Mekong rivers with private sunrise balcony.'),
                    ('PP-102', 'Deluxe Urban King Room', 'Deluxe', 'Phnom Penh', 115.00, 2, 0, 'WiFi, AC, City View, Smart TV, Rainfall Shower', 'Available', 'Sophisticated urban sanctuary in the heart of Phnom Penh near the Royal Palace.'),
                    ('PP-103', 'Grand Presidential Penthouse', 'Presidential', 'Phnom Penh', 460.00, 4, 2, 'WiFi, Infinity Pool, Jacuzzi, Private Butler, Lounge', 'Available', 'Ultra-luxurious multi-room penthouse with dedicated concierge and personal bar.'),

                    ('SR-201', 'Angkor Heritage Garden Villa', 'Suite', 'Siem Reap', 230.00, 3, 2, 'WiFi, Private Garden, Pool, AC, Temple Shuttles', 'Available', 'Secluded tropical villa surrounded by lush flora, minutes away from Angkor Wat.'),
                    ('SR-202', 'Khmer Silk Deluxe Suite', 'Deluxe', 'Siem Reap', 135.00, 2, 1, 'WiFi, AC, Silk Bathrobes, Bathtub, Garden View', 'Available', 'Hand-woven Khmer silk decor, oversized marble bathtub, and tranquil pool views.'),
                    ('SR-203', 'Royal Bopha Pool Pavilion', 'Presidential', 'Siem Reap', 380.00, 4, 2, 'WiFi, Private Plunge Pool, Spa Access, Kitchenette', 'Occupied', 'Private walled compound with private plunge pool, outdoor rain shower, and VIP spa package.'),

                    ('SHV-301', 'Oceanfront Sunset Bungalow', 'Suite', 'Sihanoukville', 215.00, 2, 1, 'WiFi, Beachfront Access, Sea View, Balcony, AC', 'Available', 'Steps away from turquoise waves with uninterrupted sunset views over the Gulf of Thailand.'),
                    ('SHV-302', 'Island Azure Deluxe', 'Deluxe', 'Sihanoukville', 125.00, 2, 1, 'WiFi, Swimming Pool, Ocean View, Breakfast Included', 'Available', 'Modern coastal elegance featuring private balcony and salt-water pool access.'),

                    ('KPT-401', 'Riverside Plantation Suite', 'Suite', 'Kampot', 145.00, 2, 1, 'WiFi, Riverfront Deck, AC, Mountain View, Kayak Access', 'Available', 'Perched on the tranquil Praek Tuek Chhu river facing the misty Bokor Mountain ridge.'),
                    ('KPT-402', 'Bokor Mist Chalet', 'Standard', 'Kampot', 90.00, 2, 0, 'WiFi, AC, Balcony, Espresso Machine, Garden View', 'Available', 'Cozy wooden chalet designed for serene mountain retreats and Kampot pepper tours.'),

                    ('BTB-501', 'Colonial Heritage Residence', 'Deluxe', 'Battambang', 110.00, 2, 1, 'WiFi, High Ceilings, Teak Wood, AC, Pool, Breakfast', 'Available', 'Restored 1920s French colonial architecture with high timber ceilings and courtyard pool.'),

                    ('KEP-601', 'Crab Market Oceanview Villa', 'Suite', 'Kep', 165.00, 3, 1, 'WiFi, Ocean View, Sunset Terrace, Seafood Voucher', 'Available', 'Overlooking the Gulf of Thailand and Phu Quoc island with fresh seafood room service.');";

                using var cmdInsert = new MySqlCommand(insertRooms, conn);
                cmdInsert.ExecuteNonQuery();
            }
        }

        private static void SeedBookingsIfEmpty(MySqlConnection conn)
        {
            string checkBookings = "SELECT COUNT(*) FROM bookings;";
            using var cmdCheck = new MySqlCommand(checkBookings, conn);
            long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

            if (count == 0)
            {
                // Retrieve room ID for SR-203 or PP-101
                string getRoomId = "SELECT id FROM rooms WHERE room_number = 'SR-203' LIMIT 1;";
                using var cmdRoom = new MySqlCommand(getRoomId, conn);
                object? objRoomId = cmdRoom.ExecuteScalar();
                int roomId = objRoomId != null ? Convert.ToInt32(objRoomId) : 1;

                string insertBooking = @"
                    INSERT INTO bookings (booking_ref, user_id, room_id, guest_name, guest_email, guest_phone, check_in_date, check_out_date, total_nights, adults_count, children_count, rooms_count, total_amount, booking_status) 
                    VALUES 
                    ('GST-2026-8941', 2, @roomId, 'John Doe', 'john@example.com', '+855 12 345 678', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY), 3, 2, 0, 1, 1140.00, 'Checked-In');
                    SELECT LAST_INSERT_ID();";

                int newBookingId;
                using (var cmdInsert = new MySqlCommand(insertBooking, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@roomId", roomId);
                    newBookingId = Convert.ToInt32(cmdInsert.ExecuteScalar());
                }

                string insertPayment = @"
                    INSERT INTO payments (booking_id, amount_paid, payment_method, payment_status, transaction_ref)
                    VALUES (@bookingId, 1140.00, 'ABA KHQR', 'Paid', 'TXN-ABA-982138');";

                using (var cmdPay = new MySqlCommand(insertPayment, conn))
                {
                    cmdPay.Parameters.AddWithValue("@bookingId", newBookingId);
                    cmdPay.ExecuteNonQuery();
                }
            }
        }

        // ==========================================
        // USER AUTHENTICATION & REGISTRATION
        // ==========================================

        public static bool AuthenticateUser(string email, string password, string expectedRole, out UserAccount? user, out string errorMessage)
        {
            user = null;
            errorMessage = "";

            try
            {
                using var conn = GetConnection();
                conn.Open();

                string query = "SELECT id, full_name, email, phone, password_hash, role FROM users WHERE email = @email LIMIT 1;";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string dbPassword = reader.GetString("password_hash");
                    string role = reader.GetString("role");

                    if (dbPassword != password)
                    {
                        errorMessage = "Invalid password. Please check your credentials.";
                        return false;
                    }

                    if (!string.IsNullOrEmpty(expectedRole) && !role.Equals(expectedRole, StringComparison.OrdinalIgnoreCase))
                    {
                        errorMessage = $"Access denied. This account does not have {expectedRole} privileges.";
                        return false;
                    }

                    user = new UserAccount
                    {
                        Id = reader.GetInt32("id"),
                        FullName = reader.GetString("full_name"),
                        Email = reader.GetString("email"),
                        Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? "" : reader.GetString("phone"),
                        Password = dbPassword,
                        Role = role
                    };

                    return true;
                }
                else
                {
                    errorMessage = "Account not found with this email address.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Database error: {ex.Message}";
                return false;
            }
        }

        public static bool RegisterUser(string fullName, string email, string phone, string password, out int newUserId, out string errorMessage)
        {
            newUserId = 0;
            errorMessage = "";

            try
            {
                using var conn = GetConnection();
                conn.Open();

                // Check if email already registered
                string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email;";
                using var checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@email", email);
                long exists = Convert.ToInt64(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    errorMessage = "An account with this email address is already registered.";
                    return false;
                }

                string insertQuery = @"
                    INSERT INTO users (full_name, email, password_hash, phone, role) 
                    VALUES (@fullName, @email, @password, @phone, 'Customer');
                    SELECT LAST_INSERT_ID();";

                using var cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);

                newUserId = Convert.ToInt32(cmd.ExecuteScalar());
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Registration failed: {ex.Message}";
                return false;
            }
        }

        public static DataTable GetAllUsersTable()
        {
            var dt = new DataTable();
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string query = "SELECT id, full_name, email, phone, role, created_at FROM users ORDER BY id DESC;";
                using var adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch { }
            return dt;
        }

        // ==========================================
        // ROOMS QUERIES & CRUD
        // ==========================================

        public static List<RoomItem> GetRooms(string destination = "", string roomType = "")
        {
            var list = new List<RoomItem>();
            try
            {
                using var conn = GetConnection();
                conn.Open();

                string query = "SELECT id, room_number, room_name, room_type, destination, price_per_night, max_adults, max_children, amenities, status, description FROM rooms WHERE 1=1";

                if (!string.IsNullOrEmpty(destination) && destination != "All Destinations" && destination != "Select Location")
                {
                    query += " AND destination = @destination";
                }

                if (!string.IsNullOrEmpty(roomType) && roomType != "All Types")
                {
                    query += " AND room_type = @roomType";
                }

                query += " ORDER BY price_per_night ASC;";

                using var cmd = new MySqlCommand(query, conn);
                if (!string.IsNullOrEmpty(destination) && destination != "All Destinations" && destination != "Select Location")
                    cmd.Parameters.AddWithValue("@destination", destination);
                if (!string.IsNullOrEmpty(roomType) && roomType != "All Types")
                    cmd.Parameters.AddWithValue("@roomType", roomType);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoomItem
                    {
                        Id = reader.GetInt32("id"),
                        RoomNumber = reader.GetString("room_number"),
                        RoomName = reader.GetString("room_name"),
                        RoomType = reader.GetString("room_type"),
                        Destination = reader.GetString("destination"),
                        PricePerNight = reader.GetDecimal("price_per_night"),
                        MaxAdults = reader.GetInt32("max_adults"),
                        MaxChildren = reader.GetInt32("max_children"),
                        Amenities = reader.IsDBNull(reader.GetOrdinal("amenities")) ? "" : reader.GetString("amenities"),
                        Status = reader.GetString("status"),
                        Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description")
                    });
                }
            }
            catch { }
            return list;
        }

        public static DataTable GetAllRoomsTable()
        {
            var dt = new DataTable();
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string query = "SELECT id, room_number, room_name, room_type, destination, price_per_night, max_adults, max_children, status, amenities FROM rooms ORDER BY id ASC;";
                using var adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch { }
            return dt;
        }

        public static bool UpdateRoomStatus(int roomId, string newStatus)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string query = "UPDATE rooms SET status = @status WHERE id = @id;";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", roomId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        // ==========================================
        // BOOKINGS QUERIES & CRUD
        // ==========================================

        public static DataTable GetBookingsForUser(int userId, string email)
        {
            var dt = new DataTable();
            try
            {
                using var conn = GetConnection();
                conn.Open();

                string query = @"
                    SELECT 
                        b.id AS BookingId,
                        b.booking_ref AS 'Booking Ref',
                        r.room_name AS 'Room Name',
                        r.destination AS 'Destination',
                        b.check_in_date AS 'Check In',
                        b.check_out_date AS 'Check Out',
                        b.total_nights AS 'Nights',
                        b.total_amount AS 'Total ($)',
                        b.booking_status AS 'Status',
                        b.booking_date AS 'Booked On'
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    WHERE b.user_id = @userId OR b.guest_email = @email
                    ORDER BY b.id DESC;";

                using var adapter = new MySqlDataAdapter(query, conn);
                if (adapter.SelectCommand != null)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                    adapter.SelectCommand.Parameters.AddWithValue("@email", email);
                }
                adapter.Fill(dt);
            }
            catch { }
            return dt;
        }

        public static DataTable GetAllBookingsTable()
        {
            var dt = new DataTable();
            try
            {
                using var conn = GetConnection();
                conn.Open();

                string query = @"
                    SELECT 
                        b.id AS ID,
                        b.booking_ref AS 'Ref #',
                        b.guest_name AS 'Guest Name',
                        r.room_name AS 'Room',
                        r.room_number AS 'Room #',
                        r.destination AS 'Location',
                        b.check_in_date AS 'Check In',
                        b.check_out_date AS 'Check Out',
                        b.total_nights AS 'Nights',
                        b.total_amount AS 'Total ($)',
                        b.booking_status AS 'Status',
                        IFNULL(p.payment_status, 'Unpaid') AS 'Payment'
                    FROM bookings b
                    JOIN rooms r ON b.room_id = r.id
                    LEFT JOIN payments p ON b.id = p.booking_id
                    ORDER BY b.id DESC;";

                using var adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch { }
            return dt;
        }

        public static bool UpdateBookingStatus(int bookingId, string newStatus)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string query = "UPDATE bookings SET booking_status = @status WHERE id = @id;";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", bookingId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateBooking(
            int? userId,
            int roomId,
            string guestName,
            string guestEmail,
            string guestPhone,
            DateTime checkIn,
            DateTime checkOut,
            int totalNights,
            int adults,
            int children,
            int roomsCount,
            decimal totalAmount,
            string paymentMethod,
            out string bookingRef,
            out string errorMessage)
        {
            bookingRef = $"GST-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}";
            errorMessage = "";

            try
            {
                using var conn = GetConnection();
                conn.Open();

                using var trans = conn.BeginTransaction();

                string insertBooking = @"
                    INSERT INTO bookings 
                    (booking_ref, user_id, room_id, guest_name, guest_email, guest_phone, check_in_date, check_out_date, total_nights, adults_count, children_count, rooms_count, total_amount, booking_status)
                    VALUES 
                    (@ref, @userId, @roomId, @guestName, @guestEmail, @guestPhone, @checkIn, @checkOut, @nights, @adults, @children, @rooms, @total, 'Confirmed');
                    SELECT LAST_INSERT_ID();";

                int bookingId;
                using (var cmd = new MySqlCommand(insertBooking, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@ref", bookingRef);
                    cmd.Parameters.AddWithValue("@userId", (object?)userId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.Parameters.AddWithValue("@guestName", guestName);
                    cmd.Parameters.AddWithValue("@guestEmail", guestEmail);
                    cmd.Parameters.AddWithValue("@guestPhone", guestPhone);
                    cmd.Parameters.AddWithValue("@checkIn", checkIn.Date);
                    cmd.Parameters.AddWithValue("@checkOut", checkOut.Date);
                    cmd.Parameters.AddWithValue("@nights", totalNights);
                    cmd.Parameters.AddWithValue("@adults", adults);
                    cmd.Parameters.AddWithValue("@children", children);
                    cmd.Parameters.AddWithValue("@rooms", roomsCount);
                    cmd.Parameters.AddWithValue("@total", totalAmount);

                    bookingId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Insert payment record
                string insertPayment = @"
                    INSERT INTO payments (booking_id, amount_paid, payment_method, payment_status, transaction_ref)
                    VALUES (@bookingId, @amount, @method, 'Paid', @txnRef);";

                using (var cmdPay = new MySqlCommand(insertPayment, conn, trans))
                {
                    cmdPay.Parameters.AddWithValue("@bookingId", bookingId);
                    cmdPay.Parameters.AddWithValue("@amount", totalAmount);
                    cmdPay.Parameters.AddWithValue("@method", paymentMethod);
                    cmdPay.Parameters.AddWithValue("@txnRef", $"TXN-{paymentMethod.Replace(" ", "")}-{new Random().Next(100000, 999999)}");
                    cmdPay.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        // ==========================================
        // ADMIN KPI METRICS
        // ==========================================

        public static (decimal revenue, int totalBookings, double occupancyRate, int availableRooms) GetDashboardKpis()
        {
            decimal totalRevenue = 0;
            int totalBookings = 0;
            int totalRooms = 12;
            int availableRooms = 0;

            try
            {
                using var conn = GetConnection();
                conn.Open();

                // 1. Total Revenue
                string revQuery = "SELECT IFNULL(SUM(amount_paid), 0) FROM payments WHERE payment_status = 'Paid';";
                using var revCmd = new MySqlCommand(revQuery, conn);
                totalRevenue = Convert.ToDecimal(revCmd.ExecuteScalar());

                // 2. Total Bookings
                string countQuery = "SELECT COUNT(*) FROM bookings;";
                using var countCmd = new MySqlCommand(countQuery, conn);
                totalBookings = Convert.ToInt32(countCmd.ExecuteScalar());

                // 3. Room Counts
                string roomTotalQuery = "SELECT COUNT(*) FROM rooms;";
                using var totalRoomsCmd = new MySqlCommand(roomTotalQuery, conn);
                totalRooms = Convert.ToInt32(totalRoomsCmd.ExecuteScalar());

                string availQuery = "SELECT COUNT(*) FROM rooms WHERE status = 'Available';";
                using var availCmd = new MySqlCommand(availQuery, conn);
                availableRooms = Convert.ToInt32(availCmd.ExecuteScalar());
            }
            catch { }

            int occupiedRooms = Math.Max(0, totalRooms - availableRooms);
            double occupancyRate = totalRooms > 0 ? Math.Round(((double)occupiedRooms / totalRooms) * 100.0, 1) : 0;

            return (totalRevenue, totalBookings, occupancyRate, availableRooms);
        }
    }
}
