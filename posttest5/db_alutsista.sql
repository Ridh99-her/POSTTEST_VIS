-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 12, 2026 at 05:45 PM
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
-- Database: `db_alutsista`
--

-- --------------------------------------------------------

--
-- Table structure for table `tabel_alutsista`
--

CREATE TABLE `tabel_alutsista` (
  `id` varchar(50) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jenis` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tabel_alutsista`
--

INSERT INTO `tabel_alutsista` (`id`, `nama`, `jenis`, `status`) VALUES
('V-002', 'Leopard 2A4', 'Tank', 'Maintenance'),
('v-007', 'Leopard 2 ri', 'ifv', 'reserve'),
('V-011', 'Harimau', 'Tank', 'Aktif'),
('V-012', 'k21', 'Tank', 'Non-Aktif'),
('V-021', 'Leopard2RI', 'Tank', 'Aktif');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tabel_alutsista`
--
ALTER TABLE `tabel_alutsista`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
