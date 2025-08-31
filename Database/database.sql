/*
MySQL Data Transfer
Source Host: localhost
Source Database: library
Target Host: localhost
Target Database: library
Date: 12/9/2022 10:41:58 AM
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for books
-- ----------------------------
DROP TABLE IF EXISTS `books`;
CREATE TABLE `books` (
  `bid` int(11) NOT NULL,
  `bname` varchar(60) DEFAULT NULL,
  `AutherName` varchar(60) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  PRIMARY KEY (`bid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for record
-- ----------------------------
DROP TABLE IF EXISTS `record`;
CREATE TABLE `record` (
  `sid` int(11) NOT NULL DEFAULT '0',
  `bid` int(11) NOT NULL DEFAULT '0',
  `BookName` varchar(50) DEFAULT NULL,
  `AutherName` varchar(50) DEFAULT NULL,
  `IssueDate` varchar(50) DEFAULT NULL,
  `ReturnDate` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`sid`,`bid`),
  KEY `bid` (`bid`),
  CONSTRAINT `record_ibfk_2` FOREIGN KEY (`bid`) REFERENCES `books` (`bid`),
  CONSTRAINT `record_ibfk_1` FOREIGN KEY (`sid`) REFERENCES `students` (`sid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for students
-- ----------------------------
DROP TABLE IF EXISTS `students`;
CREATE TABLE `students` (
  `sid` int(11) NOT NULL,
  `sname` varchar(60) DEFAULT NULL,
  `rn` int(11) DEFAULT NULL,
  `branch` varchar(60) DEFAULT NULL,
  `sem` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
