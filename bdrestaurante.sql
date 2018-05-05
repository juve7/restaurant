-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: bdrestaurante
-- ------------------------------------------------------
-- Server version	5.6.13-enterprise-commercial-advanced

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
-- Table structure for table `tambiente`
--

DROP TABLE IF EXISTS `tambiente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tambiente` (
  `idambiente` int(11) NOT NULL AUTO_INCREMENT,
  `nombreambiente` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idambiente`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tambiente`
--

LOCK TABLES `tambiente` WRITE;
/*!40000 ALTER TABLE `tambiente` DISABLE KEYS */;
INSERT INTO `tambiente` VALUES (24,'Primer Piso'),(25,'Segundo Piso');
/*!40000 ALTER TABLE `tambiente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tcategorias`
--

DROP TABLE IF EXISTS `tcategorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tcategorias` (
  `idcategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombrecategoria` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idcategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tcategorias`
--

LOCK TABLES `tcategorias` WRITE;
/*!40000 ALTER TABLE `tcategorias` DISABLE KEYS */;
INSERT INTO `tcategorias` VALUES (7,'Frituras'),(10,'Bebidas');
/*!40000 ALTER TABLE `tcategorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tmesas`
--

DROP TABLE IF EXISTS `tmesas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tmesas` (
  `idmesa` int(11) NOT NULL AUTO_INCREMENT,
  `idambiente` int(11) DEFAULT NULL,
  `mesa` int(11) DEFAULT NULL,
  `estado` varchar(45) DEFAULT 'Disponible',
  `pedidos` int(11) DEFAULT '0',
  PRIMARY KEY (`idmesa`)
) ENGINE=InnoDB AUTO_INCREMENT=1734 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tmesas`
--

LOCK TABLES `tmesas` WRITE;
/*!40000 ALTER TABLE `tmesas` DISABLE KEYS */;
INSERT INTO `tmesas` VALUES (1700,24,1,'Enviado a Cocina',0),(1701,24,2,'Disponible',0),(1702,25,3,'Disponible',0),(1703,25,4,'Disponible',0),(1704,25,5,'Disponible',0),(1705,25,6,'Disponible',0),(1706,25,7,'Disponible',0),(1707,25,8,'Disponible',0),(1708,25,9,'Atendido',0),(1709,25,10,'Disponible',0),(1710,25,11,'Disponible',0),(1711,25,12,'Disponible',0),(1712,25,13,'Disponible',0),(1713,25,14,'Disponible',0),(1714,25,15,'Disponible',0),(1715,25,16,'Disponible',0),(1716,25,17,'Disponible',0),(1717,25,18,'Disponible',0),(1718,25,19,'Disponible',0),(1719,25,20,'Disponible',0),(1720,25,21,'Disponible',0),(1721,25,22,'Disponible',0),(1722,25,23,'Disponible',0),(1723,25,24,'Disponible',0),(1724,25,25,'Disponible',0),(1725,25,26,'Disponible',0),(1726,25,27,'Disponible',0),(1727,25,28,'Disponible',0),(1728,25,29,'Disponible',0),(1729,25,30,'Disponible',0),(1730,25,31,'Disponible',0),(1731,25,32,'Disponible',0),(1732,25,33,'Disponible',0),(1733,25,34,'Disponible',0);
/*!40000 ALTER TABLE `tmesas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bdrestaurante'
--

--
-- Dumping routines for database 'bdrestaurante'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-19 16:58:47
