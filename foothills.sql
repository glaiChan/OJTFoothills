-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 09, 2019 at 08:25 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `foothills`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `suffix` varchar(10) NOT NULL,
  `address` varchar(100) NOT NULL,
  `birth_date` date NOT NULL,
  `mobile_num` varchar(11) NOT NULL,
  `landline` int(11) DEFAULT NULL,
  `zipcode` int(11) NOT NULL,
  `gender` enum('MALE','FEMALE') NOT NULL,
  `marital_status` enum('SINGLE','MARRIED','DIVORCED','WIDOW','WIDOWER') NOT NULL,
  `tin_no` varchar(15) NOT NULL,
  `umid_sss` varchar(15) NOT NULL,
  `email_address` varchar(100) DEFAULT NULL,
  `philhealth_num` varchar(20) NOT NULL,
  `pag_ibig_num` varchar(25) NOT NULL,
  `gsis_id` varchar(15) NOT NULL,
  `dependants` int(3) DEFAULT NULL,
  `employee_business_name` varchar(100) NOT NULL,
  `spouse_name` varchar(50) DEFAULT NULL,
  `employee_business_address` varchar(100) DEFAULT NULL,
  `spouse_birthdate` date DEFAULT NULL,
  `position` varchar(50) NOT NULL,
  `department` varchar(50) NOT NULL,
  `spouse_contact` varchar(15) DEFAULT NULL,
  `employer_business_contact` varchar(14) DEFAULT NULL,
  `spouse_address` varchar(50) DEFAULT NULL,
  `date_created` datetime DEFAULT NULL,
  `date_modified` datetime DEFAULT NULL,
  `client_status` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`id`, `last_name`, `first_name`, `middle_name`, `suffix`, `address`, `birth_date`, `mobile_num`, `landline`, `zipcode`, `gender`, `marital_status`, `tin_no`, `umid_sss`, `email_address`, `philhealth_num`, `pag_ibig_num`, `gsis_id`, `dependants`, `employee_business_name`, `spouse_name`, `employee_business_address`, `spouse_birthdate`, `position`, `department`, `spouse_contact`, `employer_business_contact`, `spouse_address`, `date_created`, `date_modified`, `client_status`) VALUES
(1, '', '', '', '', '', '0000-00-00', '', NULL, 0, 'MALE', 'SINGLE', '', '', NULL, '', '', '', NULL, '', NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, NULL, NULL),
(4, '', 'asdsadsa', 'asdsad', 'asd', 'sdadas', '2018-12-03', '12121', 12121, 12121, 'MALE', 'SINGLE', '1212121', '12121', 'asdasdas', '', '1212', '12121', 1, 'asdsadas', 'sadsadasd', 'asdsadas', '2018-12-03', 'asdasda', 'asdasdas', '21212', '1212121', 'asdsadsa', '2019-01-09 14:54:42', '2019-01-09 14:54:42', 1),
(5, '', 'asdsadsa', 'asdsad', 'asd', 'sdadas', '2018-12-03', '12121', 12121, 12121, 'MALE', 'SINGLE', '1212121', '12121', 'asdasdas', '', '1212', '12121', 1, 'asdsadas', 'sadsadasd', 'asdsadas', '2018-12-03', 'asdasda', 'asdasdas', '21212', '1212121', 'asdsadsa', '2019-01-09 14:55:40', '2019-01-09 14:55:40', 1),
(6, '', 'dasdasdas', 'asdasdsa', 'asdas', 'asdasdas', '2018-12-03', '12121', 1212121, 11, 'MALE', 'SINGLE', '1212121', '12121', 'asdasdas', '12121', '212121', '1212121', 12, 'asdasdas', 'asdasds', 'asdasdas', '2018-12-03', 'asdasdasda', 'asdasdas', '1212121', '212121', 'asdasdadsa', '2019-01-09 15:01:42', '2019-01-09 15:01:42', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
