-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2023 at 10:09 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sfnhs_enrollment`
--

-- --------------------------------------------------------

--
-- Table structure for table `assigned_to`
--

CREATE TABLE `assigned_to` (
  `ID` int(11) NOT NULL,
  `section_Id` int(11) NOT NULL,
  `faculty_Id` int(15) DEFAULT NULL,
  `assigned_subject` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `assigned_to`
--

INSERT INTO `assigned_to` (`ID`, `section_Id`, `faculty_Id`, `assigned_subject`) VALUES
(1, 1, 1, 'Adviser');

-- --------------------------------------------------------

--
-- Table structure for table `belong_to`
--

CREATE TABLE `belong_to` (
  `ID` int(15) NOT NULL,
  `student_Id` int(11) DEFAULT NULL,
  `academic_year` varchar(20) DEFAULT NULL,
  `section_Id` int(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `designated_to`
--

CREATE TABLE `designated_to` (
  `ID` int(11) NOT NULL,
  `requirements_Id` varchar(15) DEFAULT NULL,
  `faculty_Id` varchar(15) DEFAULT NULL,
  `date_status` date DEFAULT NULL,
  `no_requirements` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `designated_to`
--

INSERT INTO `designated_to` (`ID`, `requirements_Id`, `faculty_Id`, `date_status`, `no_requirements`) VALUES
(1, '', '16', '2023-05-10', 89);

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `faculty_Id` int(15) NOT NULL,
  `fty_fname` varchar(50) DEFAULT NULL,
  `fty_lname` varchar(50) DEFAULT NULL,
  `fty_mname` varchar(30) DEFAULT NULL,
  `gender` varchar(15) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `address` varchar(60) DEFAULT NULL,
  `cp_number` varchar(30) DEFAULT NULL,
  `email_address` varchar(50) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`faculty_Id`, `fty_fname`, `fty_lname`, `fty_mname`, `gender`, `date_of_birth`, `address`, `cp_number`, `email_address`, `position`) VALUES
(1, 'Joanna', 'Perez', 'H', 'Female', '2023-05-31', 'P-3 Tuaca, Basud, Camarines Norte', '09235738476', 'perez@gmail.com', 'Adviser'),
(2, 'Ronaldo', 'Asis', 'B', 'Male', '2023-05-29', 'P-1 Manlimonsito, Basud, Camarines Norte', '09171234567', 'asis@gmail.com', 'Adviser'),
(3, 'Moana', 'Garcia', 'J', 'Female', '2023-05-28', 'P-3 Sanfelipe, Basud, Camarines Norte', '09128581017', 'garcia@gmail.com', 'Adviser');

-- --------------------------------------------------------

--
-- Table structure for table `requirements`
--

CREATE TABLE `requirements` (
  `requirements_Id` int(15) NOT NULL,
  `student_Id` varchar(15) DEFAULT NULL,
  `Birth_Certificate` tinyint(1) DEFAULT NULL,
  `form_137` tinyint(1) NOT NULL,
  `goodmoral` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `section_Id` int(15) NOT NULL,
  `section_name` varchar(30) DEFAULT NULL,
  `grade_level` varchar(11) DEFAULT NULL,
  `student_capacity` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_Id` int(15) NOT NULL,
  `stu_fname` varchar(50) NOT NULL,
  `stu_lname` varchar(50) DEFAULT NULL,
  `stu_mname` varchar(10) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `cp_number` varchar(15) DEFAULT NULL,
  `email_address` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `subject_Id` int(15) NOT NULL,
  `subject_name` varchar(50) DEFAULT NULL,
  `meeting_schedule` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`subject_Id`, `subject_name`, `meeting_schedule`) VALUES
(1, 'Mathematics', 'Monday-Friday'),
(2, 'Science', 'Monday-Friday'),
(3, 'Filipino', 'Monday-Thursday'),
(4, 'English', 'Monday-Friday'),
(5, 'Friday', 'Physical Education'),
(6, 'MAPEH', 'Wednesday'),
(7, 'Wednesday', 'MAPEH'),
(8, 'Monday-Friday', 'Mathematics');

-- --------------------------------------------------------

--
-- Table structure for table `takes`
--

CREATE TABLE `takes` (
  `ID` int(15) NOT NULL,
  `student_Id` varchar(15) DEFAULT NULL,
  `subject_Id` varchar(15) DEFAULT NULL,
  `subject_grade` decimal(6,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `takes`
--

INSERT INTO `takes` (`ID`, `student_Id`, `subject_Id`, `subject_grade`) VALUES
(1, '111', '1', '90'),
(2, '111', '2', '88'),
(3, '111', '3', '85'),
(4, '111', '4', '87'),
(5, '111', '5', '91'),
(6, '111', '6', '88'),
(7, '111', '7', '84');

-- --------------------------------------------------------

--
-- Table structure for table `teach_by`
--

CREATE TABLE `teach_by` (
  `ID` int(15) NOT NULL,
  `subject_Id` varchar(15) DEFAULT NULL,
  `faculty_Id` varchar(15) DEFAULT NULL,
  `evaluation_rating` int(2) DEFAULT NULL,
  `time_schedule` varchar(15) DEFAULT NULL,
  `start_teaching` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teach_by`
--

INSERT INTO `teach_by` (`ID`, `subject_Id`, `faculty_Id`, `evaluation_rating`, `time_schedule`, `start_teaching`) VALUES
(1, '111', '1', 88, '11am-12pm', '2023-05-29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assigned_to`
--
ALTER TABLE `assigned_to`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `belong_to`
--
ALTER TABLE `belong_to`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `designated_to`
--
ALTER TABLE `designated_to`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`faculty_Id`);

--
-- Indexes for table `requirements`
--
ALTER TABLE `requirements`
  ADD PRIMARY KEY (`requirements_Id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`section_Id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_Id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`subject_Id`);

--
-- Indexes for table `takes`
--
ALTER TABLE `takes`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `teach_by`
--
ALTER TABLE `teach_by`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assigned_to`
--
ALTER TABLE `assigned_to`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `belong_to`
--
ALTER TABLE `belong_to`
  MODIFY `ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `designated_to`
--
ALTER TABLE `designated_to`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `faculty_Id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `requirements`
--
ALTER TABLE `requirements`
  MODIFY `requirements_Id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1150;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `section_Id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `student_Id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111141;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `subject_Id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `takes`
--
ALTER TABLE `takes`
  MODIFY `ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `teach_by`
--
ALTER TABLE `teach_by`
  MODIFY `ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
