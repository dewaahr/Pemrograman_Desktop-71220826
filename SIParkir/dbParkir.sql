-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 05, 2025 at 05:56 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllangganan`
--

CREATE TABLE `tbllangganan` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(50) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `biaya` int(11) DEFAULT NULL,
  `expired` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbllangganan`
--

INSERT INTO `tbllangganan` (`id`, `no_plat`, `nama`, `jenis`, `biaya`, `expired`) VALUES
(1, 'B1234XYZ', 'Anton Santoso', 'Mobil', 500000, '2025-04-19 04:21:53'),
(2, 'D5678ABC', 'Budi Raharjo', 'Motor', 200000, '2025-06-19 04:21:53'),
(3, 'F9101DEF', 'Citra Dewi', 'Sepeda', 100000, '2025-09-19 04:21:53'),
(4, 'H3141GHI', 'Dani Kurniawan', 'Taksi/Umum', 600000, '2026-03-19 04:21:53'),
(5, 'J1617JKL', 'Eko Prasetyo', 'Bus/Truk', 700000, '2026-03-19 04:21:53');

-- --------------------------------------------------------

--
-- Table structure for table `tblparkir`
--

CREATE TABLE `tblparkir` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(10) NOT NULL,
  `waktu_masuk` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `waktu_keluar` timestamp NULL DEFAULT NULL,
  `jenis` set('Motor','Mobil','Taksi/Umum','Sepeda','Bus/Truk') NOT NULL DEFAULT 'Motor',
  `harga` int(11) NOT NULL,
  `user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblparkir`
--

INSERT INTO `tblparkir` (`id`, `no_plat`, `waktu_masuk`, `waktu_keluar`, `jenis`, `harga`, `user`) VALUES
(3, 'F9101DEF', '2025-03-19 05:22:59', '2025-03-19 05:22:59', 'Sepeda', 2000, 'citra'),
(4, 'H3141GHI', '2025-03-19 04:21:34', NULL, 'Taksi/Umum', 0, 'dani'),
(5, 'J1617JKL', '2025-03-19 04:21:34', NULL, 'Bus/Truk', 0, 'eko'),
(6, 'B7124094', '2025-03-19 04:38:58', NULL, 'Motor', 0, 'anton'),
(7, 'B315135', '2025-03-19 04:39:24', NULL, 'Mobil', 0, 'anton'),
(8, 'JAF81', '2025-03-19 05:13:40', '2025-03-19 05:13:40', 'Motor', 2000, 'anton'),
(9, '459123851', '2025-03-19 05:15:28', '2025-03-19 05:15:28', 'Motor', 2000, 'anton'),
(10, 'D5678ABC', '2025-03-19 05:16:28', '2025-03-19 05:16:28', 'Motor', 2000, 'anton'),
(11, 'D5678ABC', '2025-03-19 05:17:03', '2025-03-19 05:17:03', 'Sepeda', 1000, 'anton'),
(12, 'QRQRETQ1', '2025-03-19 05:17:24', NULL, 'Motor', 0, 'anton'),
(13, '23532', '2025-03-19 05:17:32', NULL, 'Taksi/Umum', 0, 'anton'),
(14, 'D5678ABC', '2025-03-19 05:22:21', NULL, 'Sepeda', 0, 'anton'),
(15, 'F1346433', '2025-05-05 15:34:31', '2025-05-05 15:34:31', 'Motor', 2000, 'anton'),
(16, 'AG45262', '2025-05-05 15:27:01', NULL, 'Mobil', 0, 'anton'),
(17, 'AGASGR35', '2025-05-05 15:28:15', '2025-05-05 15:28:15', 'Taksi/Umum', 3000, 'anton'),
(18, '31451', '2025-05-05 15:34:44', '2025-05-05 15:34:44', 'Mobil', 3000, 'anton'),
(19, '42623', '2025-05-05 15:37:08', '2025-05-05 15:37:08', 'Motor', 2000, 'anton'),
(20, 'AEEGEG', '2025-05-05 15:40:42', '2025-05-05 15:40:42', 'Taksi/Umum', 3000, 'anton'),
(21, 'DSGSYAAR', '2025-05-05 15:42:54', '2025-05-05 15:42:54', 'Taksi/Umum', 3000, 'dewa');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('sargio', '123'),
('dewa', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblparkir`
--
ALTER TABLE `tblparkir`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblparkir`
--
ALTER TABLE `tblparkir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
