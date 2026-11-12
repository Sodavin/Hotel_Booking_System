# GrandStay Luxury Hotel Booking System 🏨

A luxury hotel reservation and management desktop application built with **C# WinForms (.NET 10.0)** and **MySQL / MariaDB (XAMPP)**.

---

## 🚀 Quick Start for Collaborators / Teammates

### Step 1: Start MySQL in XAMPP
Open **XAMPP Control Panel** and click **Start** next to **MySQL**.

> **Note**: The system includes **automatic port detection** and **self-bootstrapping**. It automatically detects whether your MySQL is running on default port `3306` or custom port `3307`.

### Step 2: Open and Run the Project
1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Open `Hotel Booking System.sln` in **Visual Studio 2022 / 2025**.
3. Press **F5** (or click **Start Debugging**).

That's it! On startup, the application will automatically:
- Connect to your local MySQL service.
- Create the database `grandstay_hotel` if it doesn't already exist.
- Create all required tables (`users`, `rooms`, `bookings`, `payments`).
- Seed 12 luxury hotel suites across Cambodia (Phnom Penh, Siem Reap, Sihanoukville, Kampot, Battambang, Kep).
- Seed default Admin and Customer accounts with sample bookings.

---

## 🔑 Demo Login Accounts

| Role | Email | Password | Access / Privileges |
| :--- | :--- | :--- | :--- |
| **Administrator** | `admin@grandstay.com` | `admin123` | Full 1920×1080 Admin Dashboard, Room Inventory CRUD, Bookings Control, Users Directory |
| **Customer** | `john@example.com` | `123456` | Guest booking flow, Room browsing, ABA KHQR payment, My Bookings management |
| **Customer** | `sophea.chan@gmail.com` | `123456` | Standard customer account |

---

## 🛠️ Optional: Manual Database Import
If you prefer setting up the database manually via **phpMyAdmin**:
1. Open **phpMyAdmin** (`http://localhost/phpmyadmin`).
2. Click **New** and name the database `grandstay_hotel`.
3. Go to the **Import** tab.
4. Choose the file located at [`database/grandstay_hotel.sql`](database/grandstay_hotel.sql) and click **Go**.

---

## 📂 Project Architecture

```
├── Hotel Booking System/
│   ├── AdminDashboardForm.cs     # 1920x1080 Admin management console with full Room CRUD
│   ├── RoomEditorForm.cs         # Luxury modal dialog for adding/editing rooms
│   ├── CustomCalendarControl.cs  # Custom luxury check-in/out calendar with range selection
│   ├── DatabaseHelper.cs         # Auto-port detection (3306/3307) & schema bootstrapper
│   ├── Form1.cs                  # Main customer hotel booking discovery & home screen
│   ├── RoomsForm.cs              # Hotel inventory catalog & filtering
│   ├── MyBookingsForm.cs         # Customer reservation history & status manager
│   └── SessionManager.cs         # Authentication & user session state
├── database/
│   └── grandstay_hotel.sql       # Complete SQL database schema & initial seed data
└── README.md
```
