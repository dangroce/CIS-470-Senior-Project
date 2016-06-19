-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: wsc
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase` (
  `billingid` int(11) NOT NULL AUTO_INCREMENT,
  `orderid` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `salerid` int(11) NOT NULL,
  `currentorderamount` float(6,2) NOT NULL,
  `orderamount` float(6,2) NOT NULL,
  `autopay` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`billingid`),
  UNIQUE KEY `billingid_UNIQUE` (`billingid`),
  KEY `orderid_idx` (`orderid`),
  KEY `userid_idx` (`userid`),
  KEY `salesid_purchase_idx` (`salerid`),
  CONSTRAINT `orderid_purchase` FOREIGN KEY (`orderid`) REFERENCES `orders` (`orderid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `salesid_purchase` FOREIGN KEY (`salerid`) REFERENCES `sales` (`salesid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `userid_purchase` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase`
--

LOCK TABLES `purchase` WRITE;
/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
INSERT INTO `purchase` VALUES (1,1,2,1,21.25,21.25,0),(2,2,3,2,21.25,42.50,0),(3,3,3,2,21.25,42.50,0),(4,4,2,1,45.95,67.20,0),(5,5,2,1,21.25,67.20,0);
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-18 20:48:05
