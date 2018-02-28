-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 28 Şub 2018, 16:20:28
-- Sunucu sürümü: 10.1.28-MariaDB
-- PHP Sürümü: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `rabtbildb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `Id` int(11) NOT NULL,
  `KullaniciAdi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Sifre` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Adi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `Soyadi` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `EPosta` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `Fotograf` text COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`Id`, `KullaniciAdi`, `Sifre`, `Adi`, `Soyadi`, `EPosta`, `Fotograf`) VALUES
(3, '1', '2', '', '', 'marfermustafa@gmail.com', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteribilgileri`
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
-- Tablo döküm verisi `musteribilgileri`
--

INSERT INTO `musteribilgileri` (`Id`, `MusteriAdi`, `FormNo`, `Telefon`, `UrunModeli`, `UrunSeriveImeiKodlari`, `UrunKodlari`, `ArizaTanimi`, `UrunDurumu`, `UrunTakipNo`, `URLKodu`, `Ucret`, `Aksesuarlar`, `EkBilgiler`, `Tarih`) VALUES
(7, 'a', '1', '1213', 'a', 'Seri No', '223213', 'adsda', 'asdasd', 123214, '', 32, 'a', 'a', '2018-02-28 17:55:08');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `musteribilgileri`
--
ALTER TABLE `musteribilgileri`
  ADD PRIMARY KEY (`Id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `musteribilgileri`
--
ALTER TABLE `musteribilgileri`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
