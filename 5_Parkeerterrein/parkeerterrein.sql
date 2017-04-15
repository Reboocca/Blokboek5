-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 15 apr 2017 om 18:34
-- Serverversie: 5.7.14
-- PHP-versie: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `parkeerterrein`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `barcode`
--

CREATE TABLE `barcode` (
  `ID` int(11) NOT NULL,
  `BarCode` text NOT NULL,
  `Geblokkeerd` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `barcode`
--

INSERT INTO `barcode` (`ID`, `BarCode`, `Geblokkeerd`) VALUES
(1, '5410013108009', 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tijd`
--

CREATE TABLE `tijd` (
  `ID` int(11) NOT NULL,
  `PersoonID` int(11) NOT NULL,
  `TijdIn` varchar(50) NOT NULL,
  `TijdUit` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tijd`
--

INSERT INTO `tijd` (`ID`, `PersoonID`, `TijdIn`, `TijdUit`) VALUES
(1, 1, '1', NULL),
(2, 1, '6-4-2017 09:11:45', NULL),
(3, 1, '6-4-2017 09:55:32', NULL),
(4, 1, '6-4-2017 09:58:15', NULL);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `barcode`
--
ALTER TABLE `barcode`
  ADD PRIMARY KEY (`ID`);

--
-- Indexen voor tabel `tijd`
--
ALTER TABLE `tijd`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `barcode`
--
ALTER TABLE `barcode`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT voor een tabel `tijd`
--
ALTER TABLE `tijd`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
