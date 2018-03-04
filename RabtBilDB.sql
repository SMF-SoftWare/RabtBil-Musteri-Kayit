-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 04, 2018 at 10:41 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rabtbildb`
--

-- --------------------------------------------------------

--
-- Table structure for table `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `Id` int(11) NOT NULL,
  `KullaniciAdi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Sifre` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Adi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Soyadi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `EPosta` varchar(255) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `musteribilgileri`
--

CREATE TABLE `musteribilgileri` (
  `Id` int(11) NOT NULL,
  `MusteriAdi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `FormNo` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Telefon` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `UrunModeli` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `UrunSeriveImeiKodlari` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `UrunKodlari` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `ArizaTanimi` varchar(145) COLLATE utf8_turkish_ci NOT NULL,
  `UrunDurumu` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `UrunTakipNo` int(11) NOT NULL,
  `URLKodu` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `Ucret` int(11) NOT NULL,
  `Aksesuarlar` varchar(210) COLLATE utf8_turkish_ci NOT NULL,
  `EkBilgiler` varchar(210) COLLATE utf8_turkish_ci NOT NULL,
  `Tarih` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `musteribilgileri`
--
ALTER TABLE `musteribilgileri`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `musteribilgileri`
--
ALTER TABLE `musteribilgileri`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
