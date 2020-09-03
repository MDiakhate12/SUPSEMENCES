-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: semences
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id_client` int NOT NULL AUTO_INCREMENT,
  `nom_complet_structure` varchar(50) DEFAULT NULL,
  `acronyme` varchar(50) DEFAULT NULL,
  `est_particulier` tinyint DEFAULT '1',
  `prenom` varchar(45) DEFAULT NULL,
  `nom` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

--
-- Table structure for table `commande`
--

DROP TABLE IF EXISTS `commande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commande` (
  `numero_de_commade` int unsigned NOT NULL AUTO_INCREMENT,
  `quantite` int unsigned DEFAULT NULL,
  `montant` int unsigned DEFAULT NULL,
  `est_enlevee` tinyint(1) DEFAULT '0',
  `est_valide` tinyint DEFAULT '0',
  `est_rejetee` tinyint(1) DEFAULT '0',
  `est_traite` tinyint DEFAULT '0',
  `est_annulee` tinyint DEFAULT '0',
  `date_enlevement_souhaitee` date DEFAULT NULL,
  `date_enlevement_reelle` date DEFAULT NULL,
  `date_creation` date DEFAULT NULL,
  `date_derniere_modification` date DEFAULT NULL,
  `date_expression_besoin_client` date DEFAULT NULL,
  `magasin_enlevement` int NOT NULL,
  `id_production` int NOT NULL,
  `id_client` int NOT NULL,
  PRIMARY KEY (`numero_de_commade`),
  KEY `id_production` (`id_production`),
  KEY `magasin_enlevement` (`magasin_enlevement`),
  KEY `id_client` (`id_client`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`id_production`) REFERENCES `production` (`id_production`),
  CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`magasin_enlevement`) REFERENCES `magasin` (`id_magasin`),
  CONSTRAINT `commande_ibfk_3` FOREIGN KEY (`id_client`) REFERENCES `client` (`id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commande`
--

--
-- Table structure for table `contact`
--

DROP TABLE IF EXISTS `contact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contact` (
  `id_contact` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `telephone` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `id_localisation` int NOT NULL,
  `id_institution` int DEFAULT NULL,
  `id_magasin` int DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  PRIMARY KEY (`id_contact`),
  KEY `id_localisation` (`id_localisation`),
  KEY `id_client` (`id_client`),
  KEY `contact_ibfk_2` (`id_institution`),
  KEY `contact_ibfk_3` (`id_magasin`),
  CONSTRAINT `contact_ibfk_1` FOREIGN KEY (`id_localisation`) REFERENCES `localisation` (`id_localisation`),
  CONSTRAINT `contact_ibfk_2` FOREIGN KEY (`id_institution`) REFERENCES `institution` (`id_institution`),
  CONSTRAINT `contact_ibfk_3` FOREIGN KEY (`id_magasin`) REFERENCES `magasin` (`id_magasin`),
  CONSTRAINT `contact_ibfk_4` FOREIGN KEY (`id_client`) REFERENCES `client` (`id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact`
--

--
-- Table structure for table `institution`
--

DROP TABLE IF EXISTS `institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `institution` (
  `id_institution` int NOT NULL AUTO_INCREMENT,
  `nom_complet` varchar(50) DEFAULT NULL,
  `sigle` varchar(50) DEFAULT NULL,
  `id_localisation` int NOT NULL,
  PRIMARY KEY (`id_institution`),
  KEY `id_localisation` (`id_localisation`),
  CONSTRAINT `institution_ibfk_1` FOREIGN KEY (`id_localisation`) REFERENCES `localisation` (`id_localisation`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `institution`
--

--
-- Table structure for table `localisation`
--

DROP TABLE IF EXISTS `localisation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `localisation` (
  `id_localisation` int NOT NULL AUTO_INCREMENT,
  `id_zone` int NOT NULL,
  `region` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `departement` varchar(17) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `commune` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `village` varchar(34) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `longitude` int DEFAULT NULL,
  `latitude` int DEFAULT NULL,
  PRIMARY KEY (`id_localisation`),
  KEY `id_zone` (`id_zone`),
  CONSTRAINT `localisation_ibfk_1` FOREIGN KEY (`id_zone`) REFERENCES `zone_agro_ecologique` (`id_zone`)
) ENGINE=InnoDB AUTO_INCREMENT=1690 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `localisation`
--

--
-- Table structure for table `magasin`
--

DROP TABLE IF EXISTS `magasin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `magasin` (
  `id_magasin` int NOT NULL AUTO_INCREMENT,
  `nom_magasin` varchar(50) NOT NULL,
  `id_institution` int NOT NULL,
  `id_localisation` int NOT NULL,
  PRIMARY KEY (`id_magasin`),
  UNIQUE KEY `nom_magasin` (`nom_magasin`,`id_localisation`,`id_institution`),
  KEY `id_localisation` (`id_localisation`),
  CONSTRAINT `magasin_ibfk_2` FOREIGN KEY (`id_localisation`) REFERENCES `localisation` (`id_localisation`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `magasin`
--

--
-- Table structure for table `niveau_de_production`
--

DROP TABLE IF EXISTS `niveau_de_production`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `niveau_de_production` (
  `id_niveau` int NOT NULL AUTO_INCREMENT,
  `nom_niveau` enum('G0','G1','G2','Prébase','Base','R1','R2') DEFAULT NULL,
  PRIMARY KEY (`id_niveau`),
  UNIQUE KEY `nom_niveau_UNIQUE` (`nom_niveau`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `niveau_de_production`
--

LOCK TABLES `niveau_de_production` WRITE;
/*!40000 ALTER TABLE `niveau_de_production` DISABLE KEYS */;
INSERT INTO `niveau_de_production` VALUES (1,'G0'),(2,'G1'),(3,'G2'),(4,'Prébase'),(5,'Base'),(6,'R1'),(7,'R2');
/*!40000 ALTER TABLE `niveau_de_production` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `niveau_institution`
--

DROP TABLE IF EXISTS `niveau_institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `niveau_institution` (
  `id_niveau_institution` int NOT NULL AUTO_INCREMENT,
  `id_institution` int NOT NULL,
  `id_niveau` int NOT NULL,
  PRIMARY KEY (`id_niveau_institution`),
  UNIQUE KEY `id_institution` (`id_institution`,`id_niveau`),
  KEY `fk_institution_idx` (`id_institution`),
  KEY `fk_niveau_idx` (`id_niveau`),
  CONSTRAINT `fk_institution` FOREIGN KEY (`id_institution`) REFERENCES `institution` (`id_institution`),
  CONSTRAINT `fk_niveau` FOREIGN KEY (`id_niveau`) REFERENCES `niveau_de_production` (`id_niveau`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `niveau_institution`
--

--
-- Table structure for table `production`
--

DROP TABLE IF EXISTS `production`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `production` (
  `id_production` int NOT NULL AUTO_INCREMENT,
  `date_de_production` date DEFAULT NULL,
  `quantite_produite` int unsigned NOT NULL,
  `prix_unitaire` int unsigned NOT NULL,
  `id_localisation` int NOT NULL,
  `id_magasin` int NOT NULL,
  `id_niveau_institution` int NOT NULL,
  `id_variete_institution` int NOT NULL,
  `id_institution` int NOT NULL DEFAULT '1',
  `quantite_disponible` int DEFAULT NULL,
  PRIMARY KEY (`id_production`),
  KEY `id_magasin` (`id_magasin`),
  KEY `id_localisation` (`id_localisation`),
  KEY `production_ibfk_4_idx` (`id_variete_institution`),
  KEY `id_variete_institution` (`id_variete_institution`),
  KEY `production_ibfk_5_idx` (`id_institution`),
  KEY `production_ibfk_3_idx` (`id_niveau_institution`),
  CONSTRAINT `production_ibfk_1` FOREIGN KEY (`id_magasin`) REFERENCES `magasin` (`id_magasin`),
  CONSTRAINT `production_ibfk_2` FOREIGN KEY (`id_localisation`) REFERENCES `localisation` (`id_localisation`),
  CONSTRAINT `production_ibfk_3` FOREIGN KEY (`id_niveau_institution`) REFERENCES `niveau_institution` (`id_niveau_institution`),
  CONSTRAINT `production_ibfk_4` FOREIGN KEY (`id_variete_institution`) REFERENCES `variete_institution` (`id_variete_institution`),
  CONSTRAINT `production_ibfk_5` FOREIGN KEY (`id_institution`) REFERENCES `institution` (`id_institution`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `production`
--
--
-- Table structure for table `speculation`
--

DROP TABLE IF EXISTS `speculation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `speculation` (
  `id_speculation` int unsigned NOT NULL AUTO_INCREMENT,
  `nom_speculation` varchar(64) NOT NULL,
  `image_speculation` blob,
  PRIMARY KEY (`id_speculation`),
  UNIQUE KEY `nom_speculation_UNIQUE` (`nom_speculation`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speculation`
--

LOCK TABLES `speculation` WRITE;
/*!40000 ALTER TABLE `speculation` DISABLE KEYS */;
INSERT INTO `speculation` VALUES (1,'riz',NULL),(2,'sorgho',NULL),(3,'mil',NULL),(4,'mais',NULL),(5,'arachide',NULL),(6,'niebe',NULL),(7,'oignon',NULL),(8,'tomate',NULL),(9,'piment',NULL),(10,'jaxatu',NULL),(11,'pomme de terre',NULL),(12,'patate douce',NULL),(13,'gombo',NULL),(14,'aubergine',NULL);
/*!40000 ALTER TABLE `speculation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `speculation_institution`
--

DROP TABLE IF EXISTS `speculation_institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `speculation_institution` (
  `id_institution` int NOT NULL,
  `id_speculation` int NOT NULL,
  `id_speculation_institution` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_speculation_institution`),
  UNIQUE KEY `id_institution` (`id_institution`,`id_speculation`),
  UNIQUE KEY `id_speculation` (`id_speculation`,`id_institution`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speculation_institution`
--

-- Table structure for table `variete`
--

DROP TABLE IF EXISTS `variete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `variete` (
  `id_variete` int NOT NULL AUTO_INCREMENT,
  `nom_variete` varchar(50) NOT NULL,
  `longueur_cycle` int unsigned DEFAULT NULL,
  `id_speculation` int unsigned NOT NULL,
  `id_zone` int NOT NULL,
  PRIMARY KEY (`id_variete`),
  UNIQUE KEY `nom_variete_UNIQUE` (`nom_variete`),
  KEY `fk_speculation_idx` (`id_speculation`),
  KEY `fk_zone_idx` (`id_zone`),
  CONSTRAINT `fk_speculation` FOREIGN KEY (`id_speculation`) REFERENCES `speculation` (`id_speculation`),
  CONSTRAINT `fk_zone` FOREIGN KEY (`id_zone`) REFERENCES `zone_agro_ecologique` (`id_zone`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `variete`
--

LOCK TABLES `variete` WRITE;
/*!40000 ALTER TABLE `variete` DISABLE KEYS */;
INSERT INTO `variete` VALUES (52,'Sahel 108',NULL,1,1),(53,'Sahel 210',NULL,1,1),(54,'Sahel 177',NULL,1,1),(55,'Sahel 134',NULL,1,1),(56,'Sahel 201',NULL,1,1),(57,'Sahel 329',NULL,1,1),(58,'NERICA 4',NULL,1,1),(59,'NERICA 8',NULL,1,1),(60,'NERICA 6',NULL,1,1),(61,'NERICA L19',NULL,1,1),(62,'NERICA S44',NULL,1,1),(63,'FKR 45 N',NULL,1,1),(64,'NERICA 14',NULL,1,1),(65,'DJ 11 509',NULL,1,1),(66,'BG 90 2',NULL,1,1),(67,'Tox 728',NULL,1,1),(68,'War 77',NULL,1,1),(69,'ROK 5',NULL,1,1),(70,'ISRIZ 3 ',NULL,1,1),(71,'ISRIZ 8',NULL,1,1),(72,'ISRIZ 9',NULL,1,1),(73,'ISRIZ 12',NULL,1,1),(74,'ISRIZ 15',NULL,1,1),(75,'CE 145-66',NULL,2,2),(76,'CE 151-262',NULL,2,2),(77,'CE 180-33',NULL,2,2),(78,'CE 196-7-2-1',NULL,2,2),(79,'F2-20',NULL,2,2),(80,'Faourou',NULL,2,2),(81,'Nguinte',NULL,2,2),(82,'Nganda',NULL,2,2),(83,'Darou',NULL,2,2),(84,'Souna 3',NULL,3,2),(85,'IBV 8001',NULL,3,2),(86,'IBV 8004',NULL,3,2),(87,'IBMV 8402',NULL,3,2),(88,'IDSMD 9507',NULL,3,2),(89,'Gawane',NULL,3,2),(90,'Thialack 2',NULL,3,2),(91,'Xeewel Gi',NULL,4,2),(92,'Noor 96',NULL,4,2),(93,'Doo Mer',NULL,4,2),(94,'Sooror',NULL,4,2),(95,'Gaaw Na',NULL,4,2),(96,'Jaboot',NULL,4,2),(97,'Goor Yomboul',NULL,4,2),(98,'Yaayi Seex',NULL,4,2),(99,'Obatampa',NULL,4,2),(100,'Swan',NULL,4,2);
/*!40000 ALTER TABLE `variete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `variete_institution`
--

DROP TABLE IF EXISTS `variete_institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `variete_institution` (
  `id_institution` int NOT NULL,
  `id_variete` int NOT NULL,
  `stock_de_securite` int unsigned DEFAULT NULL,
  `id_variete_institution` int NOT NULL AUTO_INCREMENT,
  `id_speculation_institution` int NOT NULL,
  `prix` int unsigned DEFAULT NULL,
  PRIMARY KEY (`id_variete_institution`),
  UNIQUE KEY `id_institution` (`id_institution`,`id_variete`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `variete_institution`
--
--
-- Table structure for table `zone_agro_ecologique`
--

DROP TABLE IF EXISTS `zone_agro_ecologique`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zone_agro_ecologique` (
  `id_zone` int NOT NULL AUTO_INCREMENT,
  `nom_zone` varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_zone`),
  UNIQUE KEY `nom_zone_UNIQUE` (`nom_zone`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zone_agro_ecologique`
--

LOCK TABLES `zone_agro_ecologique` WRITE;
/*!40000 ALTER TABLE `zone_agro_ecologique` DISABLE KEYS */;
INSERT INTO `zone_agro_ecologique` VALUES (2,'Centre'),(3,'Sud'),(1,'Vallée du fleuve Sénégal');
/*!40000 ALTER TABLE `zone_agro_ecologique` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zone_institution`
--

DROP TABLE IF EXISTS `zone_institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zone_institution` (
  `id_zone_institution` int NOT NULL AUTO_INCREMENT,
  `id_institution` int NOT NULL,
  `id_localisation` int NOT NULL,
  PRIMARY KEY (`id_zone_institution`),
  UNIQUE KEY `id_institution` (`id_institution`,`id_localisation`),
  UNIQUE KEY `id_institution_2` (`id_institution`,`id_localisation`),
  KEY `id_localisation` (`id_localisation`),
  CONSTRAINT `zone_institution_ibfk_1` FOREIGN KEY (`id_localisation`) REFERENCES `localisation` (`id_localisation`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zone_institution`
--

/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-01 17:54:55
