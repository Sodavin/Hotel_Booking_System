-- ========================================================
-- GrandStay Luxury Hotel Booking System
-- Database Setup Script (MySQL / MariaDB)
-- ========================================================

CREATE DATABASE IF NOT EXISTS `grandstay_hotel`
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE `grandstay_hotel`;

-- --------------------------------------------------------
-- Table: users
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS `users` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `full_name` VARCHAR(100) NOT NULL,
  `email` VARCHAR(120) NOT NULL UNIQUE,
  `password_hash` VARCHAR(255) NOT NULL,
  `phone` VARCHAR(30) NULL,
  `role` VARCHAR(20) NOT NULL DEFAULT 'Customer',
  `created_at` DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- Table: rooms
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS `rooms` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `room_number` VARCHAR(20) NOT NULL UNIQUE,
  `room_name` VARCHAR(100) NOT NULL,
  `room_type` VARCHAR(50) NOT NULL,
  `destination` VARCHAR(60) NOT NULL,
  `price_per_night` DECIMAL(10,2) NOT NULL,
  `max_adults` INT NOT NULL DEFAULT 2,
  `max_children` INT NOT NULL DEFAULT 1,
  `amenities` TEXT NULL,
  `image_path` VARCHAR(255) NULL,
  `status` VARCHAR(30) NOT NULL DEFAULT 'Available',
  `description` TEXT NULL,
  `created_at` DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- Table: bookings
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS `bookings` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `booking_ref` VARCHAR(30) NOT NULL UNIQUE,
  `user_id` INT NULL,
  `room_id` INT NOT NULL,
  `guest_name` VARCHAR(100) NOT NULL,
  `guest_email` VARCHAR(120) NOT NULL,
  `guest_phone` VARCHAR(30) NULL,
  `check_in_date` DATE NOT NULL,
  `check_out_date` DATE NOT NULL,
  `total_nights` INT NOT NULL,
  `adults_count` INT NOT NULL DEFAULT 1,
  `children_count` INT NOT NULL DEFAULT 0,
  `rooms_count` INT NOT NULL DEFAULT 1,
  `total_amount` DECIMAL(10,2) NOT NULL,
  `booking_status` VARCHAR(30) NOT NULL DEFAULT 'Confirmed',
  `booking_date` DATETIME DEFAULT CURRENT_TIMESTAMP,
  INDEX `idx_user_id` (`user_id`),
  INDEX `idx_room_id` (`room_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------
-- Table: payments
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS `payments` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `booking_id` INT NOT NULL,
  `amount_paid` DECIMAL(10,2) NOT NULL,
  `payment_method` VARCHAR(50) NOT NULL DEFAULT 'ABA KHQR',
  `payment_status` VARCHAR(30) NOT NULL DEFAULT 'Paid',
  `transaction_ref` VARCHAR(60) NULL,
  `payment_date` DATETIME DEFAULT CURRENT_TIMESTAMP,
  INDEX `idx_booking_id` (`booking_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ========================================================
-- Initial Seed Data: Users
-- ========================================================
INSERT INTO `users` (`id`, `full_name`, `email`, `password_hash`, `phone`, `role`) VALUES
(1, 'Master Administrator', 'admin@grandstay.com', 'admin123', '+855 23 999 888', 'Admin'),
(2, 'John Doe', 'john@example.com', '123456', '+855 12 345 678', 'Customer'),
(3, 'Sophea Chan', 'sophea.chan@gmail.com', '123456', '+855 77 123 456', 'Customer')
ON DUPLICATE KEY UPDATE `email` = `email`;

-- ========================================================
-- Initial Seed Data: Rooms Across Cambodia
-- ========================================================
INSERT INTO `rooms` (`id`, `room_number`, `room_name`, `room_type`, `destination`, `price_per_night`, `max_adults`, `max_children`, `amenities`, `status`, `description`) VALUES
(1, 'PP-101', 'Premier Mekong Riverview Suite', 'Suite', 'Phnom Penh', 185.00, 2, 1, 'WiFi, Pool, AC, Balcony, River View, Breakfast', 'Available', 'Panoramic views overlooking the Tonle Sap and Mekong rivers with private sunrise balcony.'),
(2, 'PP-102', 'Deluxe Urban King Room', 'Deluxe', 'Phnom Penh', 115.00, 2, 0, 'WiFi, AC, City View, Smart TV, Rainfall Shower', 'Available', 'Sophisticated urban sanctuary in the heart of Phnom Penh near the Royal Palace.'),
(3, 'PP-103', 'Grand Presidential Penthouse', 'Presidential', 'Phnom Penh', 460.00, 4, 2, 'WiFi, Infinity Pool, Jacuzzi, Private Butler, Lounge', 'Available', 'Ultra-luxurious multi-room penthouse with dedicated concierge and personal bar.'),

(4, 'SR-201', 'Angkor Heritage Garden Villa', 'Suite', 'Siem Reap', 230.00, 3, 2, 'WiFi, Private Garden, Pool, AC, Temple Shuttles', 'Available', 'Secluded tropical villa surrounded by lush flora, minutes away from Angkor Wat.'),
(5, 'SR-202', 'Khmer Silk Deluxe Suite', 'Deluxe', 'Siem Reap', 135.00, 2, 1, 'WiFi, AC, Silk Bathrobes, Bathtub, Garden View', 'Available', 'Hand-woven Khmer silk decor, oversized marble bathtub, and tranquil pool views.'),
(6, 'SR-203', 'Royal Bopha Pool Pavilion', 'Presidential', 'Siem Reap', 380.00, 4, 2, 'WiFi, Private Plunge Pool, Spa Access, Kitchenette', 'Occupied', 'Private walled compound with private plunge pool, outdoor rain shower, and VIP spa package.'),

(7, 'SHV-301', 'Oceanfront Sunset Bungalow', 'Suite', 'Sihanoukville', 215.00, 2, 1, 'WiFi, Beachfront Access, Sea View, Balcony, AC', 'Available', 'Steps away from turquoise waves with uninterrupted sunset views over the Gulf of Thailand.'),
(8, 'SHV-302', 'Island Azure Deluxe', 'Deluxe', 'Sihanoukville', 125.00, 2, 1, 'WiFi, Swimming Pool, Ocean View, Breakfast Included', 'Available', 'Modern coastal elegance featuring private balcony and salt-water pool access.'),

(9, 'KPT-401', 'Riverside Plantation Suite', 'Suite', 'Kampot', 145.00, 2, 1, 'WiFi, Riverfront Deck, AC, Mountain View, Kayak Access', 'Available', 'Perched on the tranquil Praek Tuek Chhu river facing the misty Bokor Mountain ridge.'),
(10, 'KPT-402', 'Bokor Mist Chalet', 'Standard', 'Kampot', 90.00, 2, 0, 'WiFi, AC, Balcony, Espresso Machine, Garden View', 'Available', 'Cozy wooden chalet designed for serene mountain retreats and Kampot pepper tours.'),

(11, 'BTB-501', 'Colonial Heritage Residence', 'Deluxe', 'Battambang', 110.00, 2, 1, 'WiFi, High Ceilings, Teak Wood, AC, Pool, Breakfast', 'Available', 'Restored 1920s French colonial architecture with high timber ceilings and courtyard pool.'),

(12, 'KEP-601', 'Crab Market Oceanview Villa', 'Suite', 'Kep', 165.00, 3, 1, 'WiFi, Ocean View, Sunset Terrace, Seafood Voucher', 'Available', 'Overlooking the Gulf of Thailand and Phu Quoc island with fresh seafood room service.')
ON DUPLICATE KEY UPDATE `room_number` = `room_number`;

-- ========================================================
-- Initial Seed Data: Sample Demo Booking
-- ========================================================
INSERT INTO `bookings` (`id`, `booking_ref`, `user_id`, `room_id`, `guest_name`, `guest_email`, `guest_phone`, `check_in_date`, `check_out_date`, `total_nights`, `adults_count`, `children_count`, `rooms_count`, `total_amount`, `booking_status`)
VALUES (1, 'GST-2026-8941', 2, 6, 'John Doe', 'john@example.com', '+855 12 345 678', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY), 3, 2, 0, 1, 1140.00, 'Checked-In')
ON DUPLICATE KEY UPDATE `booking_ref` = `booking_ref`;

INSERT INTO `payments` (`id`, `booking_id`, `amount_paid`, `payment_method`, `payment_status`, `transaction_ref`)
VALUES (1, 1, 1140.00, 'ABA KHQR', 'Paid', 'TXN-ABA-984124')
ON DUPLICATE KEY UPDATE `booking_id` = `booking_id`;
