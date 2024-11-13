CREATE DATABASE  IF NOT EXISTS `medico` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `medico`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: medico
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20241107145131_Initial','8.0.10');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DateAndTime` datetime(6) NOT NULL,
  `CreationTime` datetime(6) NOT NULL,
  `Status` int NOT NULL,
  `Type` int NOT NULL,
  `HealthRecordId` int DEFAULT NULL,
  `DoctorId` int NOT NULL,
  `CounterWorkerId` int NOT NULL,
  `PatientId` int DEFAULT NULL,
  `IdentifierName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Appointments_CounterWorkerId` (`CounterWorkerId`),
  KEY `IX_Appointments_DoctorId` (`DoctorId`),
  KEY `IX_Appointments_HealthRecordId` (`HealthRecordId`),
  KEY `IX_Appointments_PatientId` (`PatientId`),
  CONSTRAINT `FK_Appointments_Employees_CounterWorkerId` FOREIGN KEY (`CounterWorkerId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Appointments_Employees_DoctorId` FOREIGN KEY (`DoctorId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Appointments_HealthRecords_HealthRecordId` FOREIGN KEY (`HealthRecordId`) REFERENCES `healthrecords` (`Id`),
  CONSTRAINT `FK_Appointments_Patients_PatientId` FOREIGN KEY (`PatientId`) REFERENCES `patients` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,'2024-01-05 08:00:00.000000','2022-01-01 08:00:00.000000',1,0,1,15,31,1,'boris borisavljevic'),(2,'2024-01-19 08:20:00.000000','2022-01-01 08:00:00.000000',1,1,1,15,31,1,'boris borisavljevic'),(3,'2024-01-05 08:40:00.000000','2022-01-01 08:00:00.000000',1,0,2,16,31,2,'saska macetic'),(4,'2024-01-19 09:00:00.000000','2022-01-01 08:00:00.000000',1,1,2,16,32,2,'saska macetic'),(5,'2024-01-05 10:00:00.000000','2022-01-01 08:00:00.000000',1,0,3,15,32,3,'milos milosavljevic'),(6,'2024-01-19 10:30:00.000000','2022-01-01 08:00:00.000000',1,1,3,15,32,3,'milos milosavljevic'),(7,'2024-01-05 11:00:00.000000','2022-01-01 08:00:00.000000',1,0,4,3,33,4,'ana stanojevic'),(8,'2024-01-19 11:30:00.000000','2022-01-01 08:00:00.000000',1,1,4,3,33,4,'ana stanojevic'),(9,'2024-01-05 12:00:00.000000','2022-01-01 08:00:00.000000',1,0,5,4,33,5,'darko darkovic'),(10,'2024-01-19 12:30:00.000000','2022-01-01 08:00:00.000000',1,1,5,4,34,5,'darko darkovic'),(11,'2024-01-05 13:00:00.000000','2022-01-01 08:00:00.000000',1,0,6,3,34,6,'jovana jovanovic'),(12,'2024-01-19 13:30:00.000000','2022-01-01 08:00:00.000000',1,1,6,3,34,6,'jovana jovanovic'),(13,'2024-01-05 14:00:00.000000','2022-01-01 08:00:00.000000',1,0,7,4,31,7,'nikola nikolic'),(14,'2024-01-19 14:30:00.000000','2022-01-01 08:00:00.000000',1,1,7,4,31,7,'nikola nikolic'),(15,'2024-02-05 15:00:00.000000','2022-01-01 08:00:00.000000',1,0,8,1,32,8,'david davidovic'),(16,'2024-02-25 15:20:00.000000','2022-01-01 08:00:00.000000',1,1,8,1,32,8,'david davidovic'),(17,'2024-02-05 15:40:00.000000','2022-01-01 08:00:00.000000',1,0,9,1,33,9,'stana stanojevic'),(18,'2024-02-25 16:00:00.000000','2022-01-01 08:00:00.000000',2,1,9,1,33,9,'stana stanojevic'),(19,'2024-02-05 16:20:00.000000','2022-01-01 08:00:00.000000',1,0,10,1,34,10,'goran predojevic'),(20,'2024-02-25 16:40:00.000000','2022-01-01 08:00:00.000000',2,1,10,1,34,10,'goran predojevic'),(21,'2024-02-06 17:00:00.000000','2022-01-01 08:00:00.000000',1,1,1,15,31,1,'boris borisavljevic'),(22,'2024-02-20 17:20:00.000000','2022-01-01 08:00:00.000000',1,1,1,15,31,1,'boris borisavljevic'),(23,'2024-02-07 17:40:00.000000','2022-01-01 08:00:00.000000',1,1,4,3,33,4,'ana stanojevic'),(24,'2024-02-22 18:00:00.000000','2022-01-01 08:00:00.000000',1,1,4,3,33,4,'ana stanojevic'),(25,'2024-03-20 18:20:00.000000','2022-01-01 08:00:00.000000',1,0,1,9,31,1,'boris borisavljevic'),(26,'2025-01-19 18:40:00.000000','2022-01-01 08:00:00.000000',0,1,1,9,31,1,'boris borisavljevic'),(27,'2024-03-19 19:00:00.000000','2022-01-01 08:00:00.000000',1,0,2,9,31,2,'saska macetic'),(28,'2025-01-19 19:20:00.000000','2022-01-01 08:00:00.000000',0,1,2,9,31,2,'saska macetic'),(29,'2024-03-22 19:40:00.000000','2022-01-01 08:00:00.000000',1,0,3,9,31,3,'milos milosavljevic'),(30,'2025-01-19 09:20:00.000000','2022-01-01 08:00:00.000000',0,1,3,9,31,3,'milos milosavljevic'),(31,'2025-03-20 09:40:00.000000','2022-01-01 08:00:00.000000',0,0,NULL,11,32,NULL,'lana pepic'),(32,'2025-03-20 10:20:00.000000','2022-01-01 08:00:00.000000',0,0,NULL,12,32,NULL,'nikola jokic'),(33,'2025-03-20 10:40:00.000000','2022-01-01 08:00:00.000000',0,0,NULL,14,32,NULL,'marija novakovic'),(34,'2025-03-20 11:20:00.000000','2022-01-01 08:00:00.000000',0,0,NULL,19,32,NULL,'branko brankovic'),(35,'2024-01-05 08:00:00.000000','2022-01-01 08:00:00.000000',1,0,11,15,31,11,'ljuboje borisavljevic'),(36,'2024-01-19 08:20:00.000000','2022-01-01 08:00:00.000000',1,0,12,15,31,12,'ramiza ramizovic'),(37,'2024-01-05 08:40:00.000000','2022-01-01 08:00:00.000000',1,0,13,16,31,13,'hrvoje hrvojevic'),(38,'2024-01-19 09:00:00.000000','2022-01-01 08:00:00.000000',1,0,14,16,32,14,'alma almovic'),(39,'2024-01-05 10:00:00.000000','2022-01-01 08:00:00.000000',1,0,15,15,32,15,'radovan radovanovic'),(40,'2024-01-19 10:30:00.000000','2022-01-01 08:00:00.000000',1,0,16,15,32,16,'iskra iskric'),(41,'2024-01-05 11:00:00.000000','2022-01-01 08:00:00.000000',1,0,17,3,33,17,'semsa semsic'),(42,'2024-01-19 11:30:00.000000','2022-01-01 08:00:00.000000',1,0,18,3,33,18,'vladimir vladimirovic'),(43,'2024-01-05 12:00:00.000000','2022-01-01 08:00:00.000000',1,0,19,4,33,19,'mila milojevic'),(44,'2024-01-19 12:30:00.000000','2022-01-01 08:00:00.000000',1,0,20,4,34,20,'stojan stojanovic'),(45,'2025-01-05 08:00:00.000000','2022-01-01 08:00:00.000000',0,0,1,1,31,1,'boris borisavljevic'),(46,'2025-01-19 08:20:00.000000','2022-01-01 08:00:00.000000',0,0,2,2,31,2,'boris borisavljevic'),(47,'2025-01-05 08:40:00.000000','2022-01-01 08:00:00.000000',0,0,3,3,31,3,'saska macetic'),(48,'2025-01-19 09:00:00.000000','2022-01-01 08:00:00.000000',0,1,4,4,32,4,'saska macetic'),(49,'2025-01-05 10:00:00.000000','2022-01-01 08:00:00.000000',0,0,5,5,32,5,'milos milosavljevic'),(50,'2025-01-19 10:30:00.000000','2022-01-01 08:00:00.000000',0,0,6,6,32,6,'milos milosavljevic'),(51,'2025-01-05 11:00:00.000000','2022-01-01 08:00:00.000000',0,0,7,7,33,7,'ana stanojevic'),(52,'2025-01-19 11:30:00.000000','2022-01-01 08:00:00.000000',0,1,8,8,33,8,'ana stanojevic'),(53,'2025-01-05 12:00:00.000000','2022-01-01 08:00:00.000000',0,1,9,9,33,9,'darko darkovic'),(54,'2025-01-19 12:30:00.000000','2022-01-01 08:00:00.000000',0,0,10,10,34,10,'darko darkovic'),(55,'2025-01-05 13:00:00.000000','2022-01-01 08:00:00.000000',0,1,11,11,34,11,'jovana jovanovic'),(56,'2025-01-19 13:30:00.000000','2022-01-01 08:00:00.000000',0,0,12,12,34,12,'jovana jovanovic'),(57,'2025-01-05 14:00:00.000000','2022-01-01 08:00:00.000000',0,0,13,13,31,13,'nikola nikolic'),(58,'2025-01-19 14:30:00.000000','2022-01-01 08:00:00.000000',0,1,14,14,31,14,'nikola nikolic'),(59,'2025-02-05 15:00:00.000000','2022-01-01 08:00:00.000000',0,0,15,15,32,15,'david davidovic'),(60,'2025-02-25 15:20:00.000000','2022-01-01 08:00:00.000000',0,1,16,16,32,16,'david davidovic'),(61,'2025-02-05 15:40:00.000000','2022-01-01 08:00:00.000000',0,0,17,17,33,17,'stana stanojevic'),(62,'2025-02-25 16:00:00.000000','2022-01-01 08:00:00.000000',0,0,18,18,33,18,'stana stanojevic'),(63,'2025-02-05 16:20:00.000000','2022-01-01 08:00:00.000000',0,0,19,19,34,19,'goran predojevic'),(64,'2025-02-25 16:40:00.000000','2022-01-01 08:00:00.000000',0,0,20,20,34,20,'goran predojevic');
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_medicalspecialization`
--

DROP TABLE IF EXISTS `doctor_medicalspecialization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_medicalspecialization` (
  `DoctorsId` int NOT NULL,
  `SpecializationsId` int NOT NULL,
  PRIMARY KEY (`DoctorsId`,`SpecializationsId`),
  KEY `IX_doctor_medicalspecialization_SpecializationsId` (`SpecializationsId`),
  CONSTRAINT `FK_doctor_medicalspecialization_Employees_DoctorsId` FOREIGN KEY (`DoctorsId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_doctor_medicalspecialization_MedicalSpecializations_Speciali~` FOREIGN KEY (`SpecializationsId`) REFERENCES `medicalspecializations` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_medicalspecialization`
--

LOCK TABLES `doctor_medicalspecialization` WRITE;
/*!40000 ALTER TABLE `doctor_medicalspecialization` DISABLE KEYS */;
INSERT INTO `doctor_medicalspecialization` VALUES (1,1),(2,1),(3,2),(4,2),(5,3),(6,5),(7,6),(8,7),(9,8),(10,9),(11,10),(12,13),(13,13),(14,15),(15,19),(16,19),(13,24),(26,25),(3,29),(21,31),(22,32),(1,33),(23,34),(24,35),(25,37),(26,38),(27,39),(28,40),(17,41),(29,42),(30,43),(18,44),(19,44),(20,44);
/*!40000 ALTER TABLE `doctor_medicalspecialization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Uid` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Education` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Gender` int NOT NULL,
  `DateOfBirth` datetime(6) NOT NULL,
  `Address_Country` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_City` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_Street` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_Number` int NOT NULL,
  `ContactInfo_Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContactInfo_TelephoneNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `EmployedSince` datetime(6) NOT NULL,
  `CurrentSalary` double NOT NULL,
  `Discriminator` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'5278241879197','Marko','Petrović','University of Belgrade, Medical Faculty',0,'1985-10-15 00:00:00.000000','Serbia','Beograd','Kralja Milutina',10,'marko.petrovic@test.com','+50271014710','2022-01-01 00:00:00.000000',2500,'Doctor'),(2,'3113156597016','Ana','Jovanović','University of Belgrade, Medical Faculty',1,'1980-05-25 00:00:00.000000','Serbia','Novi Sad','Bulevar Oslobođenja',15,'ana.jovanovic@test.com','+90785553185','2022-01-01 00:00:00.000000',2500,'Doctor'),(3,'8944930652033','Nikola','Stojanović','University of Novi Sad, Medical Faculty',0,'1975-08-20 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Kralja Petra I',8,'nikola.stojanovic@test.com','+28559315778','2022-01-01 00:00:00.000000',2500,'Doctor'),(4,'2294593482700','Milan','Popović','University of Banja Luka, Medical Faculty',0,'1972-06-12 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Vuka Karadžića',22,'milan.popovic@test.com','+79574406710','2022-01-01 00:00:00.000000',2500,'Doctor'),(5,'3612588213203','Jovana','Nikolić','University of Belgrade, Medical Faculty',1,'1990-03-08 00:00:00.000000','Serbia','Beograd','Kneza Miloša',17,'jovana.nikolic@test.com','+41491159759','2022-01-01 00:00:00.000000',2500,'Doctor'),(6,'1154148525500','Stefan','Ilić','University of Novi Sad, Medical Faculty',0,'1983-12-05 00:00:00.000000','Bosnia and Herzegovina','Prijedor','Nikole Tesle',9,'stefan.ilic@test.com','+11549541210','2022-01-01 00:00:00.000000',2500,'Doctor'),(7,'7170285455376','Marija','Pavlović','University of Belgrade, Medical Faculty',1,'1978-09-18 00:00:00.000000','Serbia','Novi Sad','Jovana Cvijića',14,'marija.pavlovic@test.com','+52765302730','2022-01-01 00:00:00.000000',2500,'Doctor'),(8,'1860880125260','Aleksandar','Đorđević','University of Belgrade, Medical Faculty',0,'1968-07-30 00:00:00.000000','Bosnia and Herzegovina','Bijeljina','Vojvode Živojina Mišića',6,'aleksandar.djordjevic@test.com','+99957900617','2022-01-01 00:00:00.000000',2500,'Doctor'),(9,'4490174365809','Ana','Janković','University of Banja Luka, Medical Faculty',1,'1986-02-22 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Branka Ćopića',11,'ana.jankovic@test.com','+38362262739','2022-01-01 00:00:00.000000',2500,'Doctor'),(10,'7366554056215','Petar','Stanković','University of Novi Sad, Medical Faculty',0,'1970-11-09 00:00:00.000000','Serbia','Beograd','Vojislava Ilića',20,'petar.stankovic@test.com','+97919089379','2022-01-01 00:00:00.000000',2500,'Doctor'),(11,'4234137488161','Jelena','Petrović','University of Belgrade, Medical Faculty',1,'1982-04-03 00:00:00.000000','Serbia','Novi Sad','Aleksandra Puškina',19,'jelena.petrovic@test.com','+38596286685','2022-01-01 00:00:00.000000',2500,'Doctor'),(12,'6375967917895','Dragan','Kovačević','University of Banja Luka, Medical Faculty',0,'1974-08-14 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Đure Jakšića',7,'dragan.kovacevic@test.com','+57854721765','2022-01-01 00:00:00.000000',2500,'Doctor'),(13,'5252999133525','Milica','Ivanović','University of Novi Sad, Medical Faculty',1,'1993-06-27 00:00:00.000000','Serbia','Novi Sad','Kraljice Natalije',16,'milica.ivanovic@test.com','+70134439137','2022-01-01 00:00:00.000000',2500,'Doctor'),(14,'1421583733736','Nemanja','Jović','University of Belgrade, Medical Faculty',0,'1965-10-08 00:00:00.000000','Bosnia and Herzegovina','Prijedor','Stevana Mokranjca',5,'nemanja.jovic@test.com','+76418627577','2022-01-01 00:00:00.000000',2500,'Doctor'),(15,'1413106094074','Mina','Pavlović','University of Belgrade, Medical Faculty',1,'1988-07-19 00:00:00.000000','Serbia','Beograd','Jug Bogdanova',18,'mina.pavlovic@test.com','+32198818944','2022-01-01 00:00:00.000000',2500,'Doctor'),(16,'7098825873170','Vladimir','Stanišić','University of Novi Sad, Medical Faculty',0,'1971-12-11 00:00:00.000000','Bosnia and Herzegovina','Bijeljina','Desanke Maksimović',4,'vladimir.stanisic@test.com','+58691123844','2022-01-01 00:00:00.000000',2500,'Doctor'),(17,'8695483057484','Jovanka','Đorđević','University of Belgrade, Medical Faculty',1,'1984-09-30 00:00:00.000000','Serbia','Beograd','Kneza Miloša',11,'jovanka.djordjevic@test.com','+67419437217','2022-01-01 00:00:00.000000',2500,'Doctor'),(18,'1158069169900','Branimir','Nikolić','University of Banja Luka, Medical Faculty',0,'1976-03-24 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Svetozara Markovića',3,'branimir.nikolic@test.com','+88558054475','2022-01-01 00:00:00.000000',2500,'Doctor'),(19,'3748986327058','Ana','Janković','University of Novi Sad, Medical Faculty',1,'1980-08-07 00:00:00.000000','Serbia','Beograd','Njegoševa',7,'ana.jankovic@test.com','+24348991196','2022-01-01 00:00:00.000000',2500,'Doctor'),(20,'7096853002256','Nikola','Stanković','University of Belgrade, Medical Faculty',0,'1963-11-03 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Vojvode Stepe',2,'nikola.stankovic@test.com','+42465838926','2022-01-01 00:00:00.000000',2500,'Doctor'),(21,'9608195491020','Sanja','Petrović','University of Belgrade, Medical Faculty',1,'1981-05-15 00:00:00.000000','Serbia','Novi Sad','Kralja Milutina',10,'sanja.petrovic@test.com','+55794983314','2022-01-01 00:00:00.000000',2500,'Doctor'),(22,'1182087444176','Miloš','Jovanović','University of Banja Luka, Medical Faculty',0,'1979-06-20 00:00:00.000000','Bosnia and Herzegovina','Prijedor','Bulevar Oslobođenja',15,'milos.jovanovic@test.com','+96038967943','2022-01-01 00:00:00.000000',2500,'Doctor'),(23,'9548608933494','Tatjana','Stojanović','University of Novi Sad, Medical Faculty',1,'1962-03-08 00:00:00.000000','Serbia','Novi Sad','Kralja Petra I',8,'tatjana.stojanovic@test.com','+20253940979','2022-01-01 00:00:00.000000',2500,'Doctor'),(24,'8229990960382','Vladimir','Stanković','University of Belgrade, Medical Faculty',0,'1995-08-18 00:00:00.000000','Bosnia and Herzegovina','Bijeljina','Vuka Karadžića',22,'vladimir.stankovic@test.com','+88106360501','2022-01-01 00:00:00.000000',2500,'Doctor'),(25,'4421301767708','Ivana','Janković','University of Belgrade, Medical Faculty',1,'1973-07-30 00:00:00.000000','Serbia','Beograd','Branka Ćopića',11,'ivana.jankovic@test.com','+68614922438','2022-01-01 00:00:00.000000',2500,'Doctor'),(26,'9239414705710','Nenad','Petrović','University of Novi Sad, Medical Faculty',0,'1984-11-09 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Đure Jakšića',7,'nenad.petrovic@test.com','+98947060502','2022-01-01 00:00:00.000000',2500,'Doctor'),(27,'8653031883735','Milica','Ilić','University of Belgrade, Medical Faculty',1,'1967-06-27 00:00:00.000000','Serbia','Novi Sad','Kraljice Natalije',16,'milica.ilic@test.com','+34225777090','2022-01-01 00:00:00.000000',2500,'Doctor'),(28,'3118501374523','Vladan','Đorđević','University of Banja Luka, Medical Faculty',0,'1979-10-08 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Stevana Mokranjca',5,'vladan.djordjevic@test.com','+42091109439','2022-01-01 00:00:00.000000',2500,'Doctor'),(29,'1059459148045','Sara','Pavlović','University of Belgrade, Medical Faculty',1,'1982-07-19 00:00:00.000000','Serbia','Beograd','Jug Bogdanova',18,'sara.pavlovic@test.com','+36716251671','2022-01-01 00:00:00.000000',2500,'Doctor'),(30,'5104839129136','Nemanja','Stanišić','University of Novi Sad, Medical Faculty',0,'1986-12-11 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Desanke Maksimović',4,'nemanja.stanisic@test.com','+32652805874','2022-01-01 00:00:00.000000',2500,'Doctor'),(31,'3175487661427','Ksenija','Marković','Medical High School, Banja Luka',1,'1998-03-21 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Svetog Save',10,'ksenija.markovic@test.com','+21175524797','2022-01-01 00:00:00.000000',1500,'CounterWorker'),(32,'1607134342097','Milica','Simeunović','Medical High School, Banja Luka',1,'1995-07-14 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Vojvode Putnika',7,'milica.simeunovic@test.com','+17104934458','2022-01-01 00:00:00.000000',1500,'CounterWorker'),(33,'4618281771556','Petar','Tomić','Medical High School, Banja Luka',0,'1992-08-08 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Kralja Petra I',22,'petar.tomic@test.com','+85171979206','2022-01-01 00:00:00.000000',1500,'CounterWorker'),(34,'5759703083602','Ana','Jovanović','Medical High School, Banja Luka',1,'1991-04-16 00:00:00.000000','Bosnia and Herzegovina','Banja Luka','Desanke Maksimović',33,'ana.jovanovic@test.com','+44288032740','2022-01-01 00:00:00.000000',1500,'CounterWorker');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `healthrecord_medicalcondition`
--

DROP TABLE IF EXISTS `healthrecord_medicalcondition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `healthrecord_medicalcondition` (
  `MedicalConditionId` int NOT NULL,
  `HealthRecordId` int NOT NULL,
  `Status` int NOT NULL,
  PRIMARY KEY (`HealthRecordId`,`MedicalConditionId`),
  KEY `IX_healthrecord_medicalcondition_MedicalConditionId` (`MedicalConditionId`),
  CONSTRAINT `FK_healthrecord_medicalcondition_HealthRecords_HealthRecordId` FOREIGN KEY (`HealthRecordId`) REFERENCES `healthrecords` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_healthrecord_medicalcondition_MedicalConditions_MedicalCondi~` FOREIGN KEY (`MedicalConditionId`) REFERENCES `medicalconditions` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `healthrecord_medicalcondition`
--

LOCK TABLES `healthrecord_medicalcondition` WRITE;
/*!40000 ALTER TABLE `healthrecord_medicalcondition` DISABLE KEYS */;
INSERT INTO `healthrecord_medicalcondition` VALUES (4,1,0),(24,1,1),(4,2,0),(24,2,1),(4,3,0),(24,3,1),(90,4,0),(90,5,0),(90,6,0),(90,7,0),(97,8,0),(97,9,0),(97,10,0),(11,11,0),(12,12,0),(13,13,0),(14,14,0),(15,15,0),(16,16,0),(17,17,0),(18,18,0),(19,19,0),(20,20,0);
/*!40000 ALTER TABLE `healthrecord_medicalcondition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `healthrecords`
--

DROP TABLE IF EXISTS `healthrecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `healthrecords` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `PatientId` int NOT NULL,
  `DateOfBirth` datetime(6) NOT NULL,
  `Gender` int NOT NULL,
  `BloodGroup` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_HealthRecords_PatientId` (`PatientId`),
  CONSTRAINT `FK_HealthRecords_Patients_PatientId` FOREIGN KEY (`PatientId`) REFERENCES `patients` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `healthrecords`
--

LOCK TABLES `healthrecords` WRITE;
/*!40000 ALTER TABLE `healthrecords` DISABLE KEYS */;
INSERT INTO `healthrecords` VALUES (1,1,'1960-01-02 00:00:00.000000',0,4),(2,2,'1961-03-04 00:00:00.000000',1,5),(3,3,'1963-05-06 00:00:00.000000',0,0),(4,4,'1964-07-08 00:00:00.000000',1,1),(5,5,'1965-09-10 00:00:00.000000',0,2),(6,6,'1966-11-12 00:00:00.000000',1,3),(7,7,'1967-12-13 00:00:00.000000',0,6),(8,8,'1968-01-14 00:00:00.000000',0,7),(9,9,'1969-02-15 00:00:00.000000',1,4),(10,10,'1970-03-16 00:00:00.000000',0,5),(11,11,'1969-03-16 00:00:00.000000',0,0),(12,12,'1968-03-16 00:00:00.000000',1,5),(13,13,'1967-03-16 00:00:00.000000',0,4),(14,14,'1966-03-16 00:00:00.000000',1,5),(15,15,'1965-03-16 00:00:00.000000',0,6),(16,16,'1964-03-16 00:00:00.000000',1,7),(17,17,'1963-03-16 00:00:00.000000',1,2),(18,18,'1962-03-16 00:00:00.000000',0,3),(19,19,'1961-03-16 00:00:00.000000',1,0),(20,20,'1960-03-16 00:00:00.000000',0,5);
/*!40000 ALTER TABLE `healthrecords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicalconditions`
--

DROP TABLE IF EXISTS `medicalconditions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicalconditions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicalconditions`
--

LOCK TABLES `medicalconditions` WRITE;
/*!40000 ALTER TABLE `medicalconditions` DISABLE KEYS */;
INSERT INTO `medicalconditions` VALUES (1,'Hypertension'),(2,'Diabetes mellitus'),(3,'Asthma'),(4,'Osteoarthritis'),(5,'Migraine'),(6,'Depression'),(7,'Schizophrenia'),(8,'Alzheimer\'s disease'),(9,'Parkinson\'s disease'),(10,'Rheumatoid arthritis'),(11,'Chronic obstructive pulmonary disease (COPD)'),(12,'Coronary artery disease'),(13,'Chronic kidney disease'),(14,'Irritable bowel syndrome (IBS)'),(15,'Chronic fatigue syndrome'),(16,'Fibromyalgia'),(17,'Multiple sclerosis'),(18,'Crohn\'s disease'),(19,'Ulcerative colitis'),(20,'Bipolar disorder'),(21,'Autism spectrum disorder'),(22,'Attention deficit hyperactivity disorder (ADHD)'),(23,'Celiac disease'),(24,'Anemia'),(25,'Endometriosis'),(26,'Polycystic ovary syndrome (PCOS)'),(27,'Erectile dysfunction'),(28,'Psoriasis'),(29,'Eczema'),(30,'Gout'),(31,'Osteoporosis'),(32,'Thyroid disorders'),(33,'Glaucoma'),(34,'Macular degeneration'),(35,'Cataracts'),(36,'Scoliosis'),(37,'Tuberculosis'),(38,'HIV/AIDS'),(39,'Hepatitis (various types)'),(40,'Epilepsy'),(41,'Stroke'),(42,'Heart failure'),(43,'Chronic pancreatitis'),(44,'Chronic bronchitis'),(45,'Pneumonia'),(46,'Chronic liver disease'),(47,'Systemic lupus erythematosus (SLE)'),(48,'Sickle cell disease'),(49,'Leukemia'),(50,'Lymphoma'),(51,'Melanoma'),(52,'Breast cancer'),(53,'Prostate cancer'),(54,'Colon cancer'),(55,'Lung cancer'),(56,'Pancreatic cancer'),(57,'Cervical cancer'),(58,'Bladder cancer'),(59,'Brain tumor'),(60,'Glioblastoma'),(61,'Myocardial infarction'),(62,'Cardiomyopathy'),(63,'Atrial fibrillation'),(64,'Deep vein thrombosis (DVT)'),(65,'Pulmonary embolism (PE)'),(66,'Atherosclerosis'),(67,'Peripheral artery disease'),(68,'Hypothyroidism'),(69,'Hyperthyroidism'),(70,'Menopause'),(71,'Benign prostatic hyperplasia (BPH)'),(72,'Glomerulonephritis'),(73,'Nephrotic syndrome'),(74,'Diverticulitis'),(75,'Pancreatitis'),(76,'Gastroparesis'),(77,'Barrett\'s esophagus'),(78,'Cirrhosis'),(79,'Hepatic encephalopathy'),(80,'Wilson\'s disease'),(81,'Hemochromatosis'),(82,'Pernicious anemia'),(83,'Thalassemia'),(84,'Hemophilia'),(85,'Von Willebrand disease'),(86,'Deep vein thrombosis (DVT)'),(87,'Pulmonary embolism (PE)'),(88,'Osteomyelitis'),(89,'Bursitis'),(90,'Tendinitis'),(91,'Plantar fasciitis'),(92,'Carpal tunnel syndrome'),(93,'Dupuytren\'s contracture'),(94,'Temporomandibular joint disorder (TMJ)'),(95,'Bell\'s palsy'),(96,'Trigeminal neuralgia'),(97,'Sciatica'),(98,'Herniated disc'),(99,'Spondylosis'),(100,'Spondylolisthesis'),(101,'Ankylosing spondylitis'),(102,'Temporal arteritis'),(103,'Polymyalgia rheumatica'),(104,'Dermatomyositis'),(105,'Polymyositis'),(106,'Bell\'s palsy'),(107,'Tinnitus'),(108,'Meniere\'s disease'),(109,'Otosclerosis'),(110,'Labyrinthitis'),(111,'Vertigo'),(112,'Motion sickness'),(113,'Insomnia'),(114,'Sleep apnea'),(115,'Narcolepsy'),(116,'Restless legs syndrome'),(117,'Bruxism'),(118,'Periodontitis'),(119,'Gingivitis'),(120,'Oral thrush'),(121,'Oral cancer'),(122,'Temporomandibular joint disorder (TMJ)'),(123,'Halitosis'),(124,'Gastroesophageal reflux disease (GERD)'),(125,'Hiatal hernia'),(126,'Gastritis'),(127,'Peptic ulcer disease'),(128,'Diverticulosis'),(129,'Hemorrhoids'),(130,'Colitis'),(131,'Gastric cancer'),(132,'Celiac disease'),(133,'Lactose intolerance'),(134,'Irritable bowel syndrome (IBS)'),(135,'Crohn\'s disease'),(136,'Ulcerative colitis'),(137,'Diverticulitis'),(138,'Pancreatitis'),(139,'Gallstones'),(140,'Cholecystitis'),(141,'Cholangitis'),(142,'Hepatitis'),(143,'Cirrhosis'),(144,'Fatty liver disease'),(145,'Gastroenteritis'),(146,'Appendicitis'),(147,'Irritable bowel syndrome (IBS)'),(148,'Peptic ulcer disease'),(149,'Gastric cancer'),(150,'Esophageal cancer'),(151,'Pancreatic cancer'),(152,'Colorectal cancer'),(153,'Liver cancer'),(154,'Gallbladder cancer'),(155,'Bile duct cancer'),(156,'Ovarian cancer'),(157,'Uterine cancer'),(158,'Cervical cancer'),(159,'Vulvar cancer'),(160,'Vaginal cancer'),(161,'Testicular cancer'),(162,'Penile cancer'),(163,'Prostate cancer'),(164,'Bladder cancer'),(165,'Kidney cancer'),(166,'Adrenal cancer'),(167,'Thyroid cancer'),(168,'Parathyroid cancer'),(169,'Thymoma'),(170,'Laryngeal cancer'),(171,'Nasopharyngeal cancer'),(172,'Oral cancer'),(173,'Salivary gland cancer'),(174,'Sinus cancer'),(175,'Nasal cavity cancer'),(176,'Pituitary tumor'),(177,'Adrenal tumor'),(178,'Neuroendocrine tumor'),(179,'Carcinoid tumor'),(180,'Gastrointestinal stromal tumor (GIST)'),(181,'Leiomyosarcoma'),(182,'Osteosarcoma'),(183,'Chondrosarcoma'),(184,'Ewing sarcoma'),(185,'Rhabdomyosarcoma'),(186,'Liposarcoma'),(187,'Fibrosarcoma'),(188,'Angiosarcoma'),(189,'Synovial sarcoma'),(190,'Meningioma'),(191,'Glioma'),(192,'Astrocytoma'),(193,'Medulloblastoma'),(194,'Ependymoma'),(195,'Pinealoma'),(196,'Chordoma'),(197,'Craniopharyngioma'),(198,'Hemangioma'),(199,'Lymphangioma'),(200,'Teratoma');
/*!40000 ALTER TABLE `medicalconditions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicalreport`
--

DROP TABLE IF EXISTS `medicalreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicalreport` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DateTime` datetime(6) NOT NULL,
  `Analysis` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PreviousFindings` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Therapy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AdditionalNotes` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AppointmentId` int NOT NULL,
  `HealthRecordId` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_MedicalReport_AppointmentId` (`AppointmentId`),
  KEY `IX_MedicalReport_HealthRecordId` (`HealthRecordId`),
  CONSTRAINT `FK_MedicalReport_Appointments_AppointmentId` FOREIGN KEY (`AppointmentId`) REFERENCES `appointments` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MedicalReport_HealthRecords_HealthRecordId` FOREIGN KEY (`HealthRecordId`) REFERENCES `healthrecords` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicalreport`
--

LOCK TABLES `medicalreport` WRITE;
/*!40000 ALTER TABLE `medicalreport` DISABLE KEYS */;
INSERT INTO `medicalreport` VALUES (1,'2024-01-05 08:00:00.000000','Patient presents with heel pain, particularly upon first steps in the morning. Pain is localized to the medial aspect of the heel.','No significant previous findings. Patient reports occasional mild discomfort after long periods of standing.','Recommend rest, ice application, stretching exercises, and over-the-counter NSAIDs. Consider custom orthotics if pain persists.','Follow-up in 4 weeks to assess response to therapy. Patient advised to avoid high-impact activities and wear supportive shoes.',1,1);
/*!40000 ALTER TABLE `medicalreport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicalspecializations`
--

DROP TABLE IF EXISTS `medicalspecializations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicalspecializations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicalspecializations`
--

LOCK TABLES `medicalspecializations` WRITE;
/*!40000 ALTER TABLE `medicalspecializations` DISABLE KEYS */;
INSERT INTO `medicalspecializations` VALUES (1,'Neurologist'),(2,'Orthopedist'),(3,'Dentist'),(4,'Cardiologist'),(5,'Dermatologist'),(6,'Endocrinologist'),(7,'Gastroenterologist'),(8,'Hematologist'),(9,'Oncologist'),(10,'Ophthalmologist'),(11,'Pediatrician'),(12,'Psychiatrist'),(13,'Radiologist'),(14,'Urologist'),(15,'Gynecologist'),(16,'Otolaryngologist'),(17,'Allergist'),(18,'Immunologist'),(19,'Rheumatologist'),(20,'Anesthesiologist'),(21,'Pathologist'),(22,'Geriatrician'),(23,'Pulmonologist'),(24,'Nephrologist'),(25,'Neonatologist'),(26,'Gastrointestinal surgeon'),(27,'Plastic surgeon'),(28,'Cardiothoracic surgeon'),(29,'Orthopedic surgeon'),(30,'Urological surgeon'),(31,'Oral and maxillofacial surgeon'),(32,'Oncological surgeon'),(33,'Neurological surgeon'),(34,'Pediatric surgeon'),(35,'Vascular surgeon'),(36,'Obstetrician'),(37,'Reproductive endocrinologist'),(38,'Podiatrist'),(39,'Optometrist'),(40,'Homeopath'),(41,'Nutritionist'),(42,'Psychologist'),(43,'Pharmacist'),(44,'General practicioner');
/*!40000 ALTER TABLE `medicalspecializations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Uid` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_Country` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_City` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_Street` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address_Number` int NOT NULL,
  `ContactInfo_Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContactInfo_TelephoneNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (1,'32031285729','Boris','Borisavljević','Bosnia and Herzegovina','Banja Luka','Kralja Milutina',1,'boris.borisavljevic@test.com','+24750949131'),(2,'58859505712','Saška','Mačetić','Bosnia and Herzegovina','Banja Luka','Novska',2,'saska.macetic@test.com','+65085946185'),(3,'98027703889','Miloš','Milosavljević','Bosnia and Herzegovina','Banja Luka','Milana Jazbeca',3,'milos.milosevic@test.com','+27252250291'),(4,'30469029114','Ana','Stanojević','Bosnia and Herzegovina','Banja Luka','Krfska',4,'ana.stanojevic@test.com','+65093684586'),(5,'34758027134','Darko','Darković','Bosnia and Herzegovina','Banja Luka','Miše Kovača',5,'darko.darkovic@test.com','+93950642310'),(6,'24149261326','Jovana','Jovanović','Bosnia and Herzegovina','Banja Luka','Davida Štrbca',6,'jovana.jovanovic@test.com','+82406246479'),(7,'22739949468','Nikola','Nikolić','Bosnia and Herzegovina','Banja Luka','Ranka Šipke',7,'nikola.nikolic@test.com','+58403064672'),(8,'57085573075','David','Davidović','Bosnia and Herzegovina','Banja Luka','Karađorđeva',8,'david.davidovic@test.com','+82497679030'),(9,'74159129987','Stana','Stanojević','Bosnia and Herzegovina','Banja Luka','Leskovačka',9,'stana.stanojevic@test.com','+38912771747'),(10,'29030602068','Goran','Predojević','Bosnia and Herzegovina','Banja Luka','Kralja Aleksandra',10,'goran.predojevic@test.com','+29874626562'),(11,'51573111515','Ljuboje','Ljubojević','Bosnia and Herzegovina','Banja Luka','Vojvode Miše',11,'ljuboje.ljubojevic@test.com','+80082517090'),(12,'71637077693','Ramiza','Ramizović','Bosnia and Herzegovina','Banja Luka','Prijedorska',12,'ramiza.ramizovic@test.com','+45062166731'),(13,'73800587405','Hrvoje','Hrvojević','Bosnia and Herzegovina','Banja Luka','Kozaračka',13,'hrvoje.hrvojevic@test.com','+62977820733'),(14,'73820036491','Alma','Almović','Bosnia and Herzegovina','Banja Luka','Milana Karanovića',14,'alma.almovic@test.com','+99000753114'),(15,'66570105776','Radovan','Radovanović','Bosnia and Herzegovina','Banja Luka','Mladena Borenovića',15,'radovan.radovanovic@test.com','+13971819898'),(16,'56970041186','Iskra','Iskrić','Bosnia and Herzegovina','Banja Luka','Kraljice Marije',16,'iskra.iskric@test.com','+53372445207'),(17,'74690650169','Šemsa','Šemsić','Bosnia and Herzegovina','Banja Luka','Obrenovačka',17,'semsa.semsic@test.com','+56918363175'),(18,'10390617980','Vladimir','Vladimirović','Bosnia and Herzegovina','Banja Luka','Ozrenska',18,'vladimir.vladimirovic@test.com','+90896792171'),(19,'55985864301','Mila','Milojević','Bosnia and Herzegovina','Banja Luka','Srbijanska',19,'mila.milojevic@test.com','+26453367076'),(20,'10372076962','Stojan','Stojanović','Bosnia and Herzegovina','Banja Luka','Duška Radetića',20,'stojan.stojanovic@test.com','+95914242044');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `report_medicalcondition`
--

DROP TABLE IF EXISTS `report_medicalcondition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `report_medicalcondition` (
  `MedicalConditionsId` int NOT NULL,
  `MedicalReportsId` int NOT NULL,
  PRIMARY KEY (`MedicalConditionsId`,`MedicalReportsId`),
  KEY `IX_report_medicalcondition_MedicalReportsId` (`MedicalReportsId`),
  CONSTRAINT `FK_report_medicalcondition_MedicalConditions_MedicalConditionsId` FOREIGN KEY (`MedicalConditionsId`) REFERENCES `medicalconditions` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_report_medicalcondition_MedicalReport_MedicalReportsId` FOREIGN KEY (`MedicalReportsId`) REFERENCES `medicalreport` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `report_medicalcondition`
--

LOCK TABLES `report_medicalcondition` WRITE;
/*!40000 ALTER TABLE `report_medicalcondition` DISABLE KEYS */;
INSERT INTO `report_medicalcondition` VALUES (1,1);
/*!40000 ALTER TABLE `report_medicalcondition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useraccounts`
--

DROP TABLE IF EXISTS `useraccounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `useraccounts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Username` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PasswordLastUpdated` datetime(6) NOT NULL,
  `UserRole` int NOT NULL,
  `EmployeeId` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_UserAccounts_EmployeeId` (`EmployeeId`),
  CONSTRAINT `FK_UserAccounts_Employees_EmployeeId` FOREIGN KEY (`EmployeeId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccounts`
--

LOCK TABLES `useraccounts` WRITE;
/*!40000 ALTER TABLE `useraccounts` DISABLE KEYS */;
INSERT INTO `useraccounts` VALUES (1,'marko.petrovic1','eESUiBPJLQ/s4CMXRZ6QZgXE2k/VbM5+QC1XNdpR7TA=','2024-02-02 10:27:36.000000',0,1),(2,'ana.jovanovic2','tmh4kL6Kj+aAlli2JuVvxEwfM+DCo7K+zV7Nb+NzXgk=','2024-02-02 10:27:36.000000',0,2),(3,'nikola.stojanovic3','rb9ClnCFci1dATS1bF1fKPW+dK9VIQYENH3QobXmkFM=','2024-02-02 10:27:36.000000',0,3),(4,'milan.popovic4','8vc5vplkQcG0tCR4dhcHgO/gibJLWFkJsZsfpwHum60=','2024-02-02 10:27:36.000000',0,4),(5,'jovana.nikolic5','Z7TOhn2+TphnOSCh69fEszh7HYrJ1rsEVfIbfXjvGfs=','2024-02-02 10:27:36.000000',0,5),(6,'stefan.ilic6','EHP0K4G7nZESTMC8QObiSUAsjUCpHQL3waqFYr/bs/0=','2024-02-02 10:27:36.000000',0,6),(7,'marija.pavlovic7','Kj3uvEwBgBUH63vjqg/31Mif4W161bEyv+yAc4wCLqU=','2024-02-02 10:27:36.000000',0,7),(8,'aleksandar.djordjevic8','lHxoiDJxD0YhPdDWPmEdiY6ZxgJBpbvbvECh749kSK8=','2024-02-02 10:27:36.000000',0,8),(9,'ana.jankovic9','ABIgJbyqGzRdpXNDVu5VX29suSgUHmDhscYOcEp1pL4=','2024-02-02 10:27:36.000000',0,9),(10,'petar.stankovic10','MiPz131hmHi1XpC0SaTuD2f4MpuDrlms7dnlrCuAHIM=','2024-02-02 10:27:36.000000',0,10),(11,'jelena.petrovic11','sJaf1zIZn9LbgAYmXpDLmLEHxD4QI8/4dvQ4nrV7hg8=','2024-02-02 10:27:36.000000',0,11),(12,'dragan.kovacevic12','/cKh+rVsE99W5bIs4PCMq8iy7pYuB1wVIDsVdqFjkrI=','2024-02-02 10:27:36.000000',0,12),(13,'milica.ivanovic13','ePuTCLRUZoEFNlTlWHY5ZNunTltyviJECsqld+VeTQk=','2024-02-02 10:27:36.000000',0,13),(14,'nemanja.jovic14','me8plQoA6wDHr6tOT5WDGd0CRol502zeZ01WD123vnw=','2024-02-02 10:27:36.000000',0,14),(15,'mina.pavlovic15','oyp8I0a1DoQTCxH0iIuOb80DA7PGCsAJhsJLCtFVqqU=','2024-02-02 10:27:36.000000',0,15),(16,'vladimir.stanisic16','KG0SiGyv73f4er6WDUKTcvNvwZLEgpcI4/PZVgH+DZk=','2024-02-02 10:27:36.000000',0,16),(17,'jovanka.djordjevic17','Q9ULJHow9ABdRGP7u36vw2xrrapWSVjgixrVWyv8DQQ=','2024-02-02 10:27:36.000000',0,17),(18,'branimir.nikolic18','+7il6G6rCI6QNidGnW/vQGFNFLPc3ihiCKrnqFOTOJ4=','2024-02-02 10:27:36.000000',0,18),(19,'ana.jankovic19','KpW3sAeAwyaI0prN0DKRtsoWnb2Z7tbVniVAI6Izxi4=','2024-02-02 10:27:36.000000',0,19),(20,'nikola.stankovic20','Uow46Y+l3Ay/hRyEmlNugioCnnhT2IuPjaaG75BcTsE=','2024-02-02 10:27:36.000000',0,20),(21,'sanja.petrovic21','yJKlI7xdCsM3JYHtjhvop04ADVrYkqOJ/hKGYMmh0/g=','2024-02-02 10:27:36.000000',0,21),(22,'milos.jovanovic22','/UssdFSw0+558PMPhS1POSU2tjbPYtYOJzSA7XUOMog=','2024-02-02 10:27:36.000000',0,22),(23,'tatjana.stojanovic23','44IGSFhstzcDUmhTe6M4Z/KssToE8tSy2vG6ggn81vY=','2024-02-02 10:27:36.000000',0,23),(24,'vladimir.stankovic24','TF9XFyEy/WxKm0G+5Fhjpio5Oot7zIW2T/P2mNR2O9w=','2024-02-02 10:27:36.000000',0,24),(25,'ivana.jankovic25','qBhnbx8tXbGK0rLRy39RNJIjMYX7SS06I8KnyTBtk9Q=','2024-02-02 10:27:36.000000',0,25),(26,'nenad.petrovic26','MFuDfJosLdAjWwopTmnyr4pa6R3sCIlB/i16crTlROo=','2024-02-02 10:27:36.000000',0,26),(27,'milica.ilic27','COFH5IWyq4cYSnX1abXsHr4FZQqq7RrZUVLZHTSRLUo=','2024-02-02 10:27:36.000000',0,27),(28,'vladan.djordjevic28','Py/RFAy3B6i2ANiwPdVkqaQJakpjkKCJjSV/1TSoU7s=','2024-02-02 10:27:36.000000',0,28),(29,'sara.pavlovic29','Go3RakYLQ/g8ovKyoT5R1XJYRMkhqPz+zV/C8gVYu5E=','2024-02-02 10:27:36.000000',0,29),(30,'nemanja.stanisic30','ROPw0GUTGxouB4+yWRVtk29BUILTT3IrnsnySVt0NDY=','2024-02-02 10:27:36.000000',0,30),(31,'ksenija.markovic31','7nJpngTuuD72k1l646OxwdyvNyt/+/5ZxSgxsS8z/Jc=','2024-02-02 10:27:36.000000',1,31),(32,'milica.simeunovic32','GtcieDv+kU/Lq8kwEiDOV/U7QM+yZLIEMhy0dRz0kIo=','2024-02-02 10:27:36.000000',1,32),(33,'petar.tomic33','MuNTgCJTqvnDqtV14+v7IGgmIA6jNXfKTELBcxB4ECI=','2024-02-02 10:27:36.000000',1,33),(34,'ana.jovanovic34','s6iZf5LkTbE3sAyW5eVBboT5bdMVwmdk1C9cELCfX/w=','2024-02-02 10:27:36.000000',1,34);
/*!40000 ALTER TABLE `useraccounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usersettings`
--

DROP TABLE IF EXISTS `usersettings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usersettings` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LandingPage` int NOT NULL,
  `ApplicationLanguage` int NOT NULL,
  `UserAccountId` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_UserSettings_UserAccountId` (`UserAccountId`),
  CONSTRAINT `FK_UserSettings_UserAccounts_UserAccountId` FOREIGN KEY (`UserAccountId`) REFERENCES `useraccounts` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usersettings`
--

LOCK TABLES `usersettings` WRITE;
/*!40000 ALTER TABLE `usersettings` DISABLE KEYS */;
INSERT INTO `usersettings` VALUES (1,0,0,1),(2,0,0,2),(3,0,0,3),(4,0,0,4),(5,0,0,5),(6,0,0,6),(7,0,0,7),(8,0,0,8),(9,0,0,9),(10,0,0,10),(11,0,0,11),(12,0,0,12),(13,0,0,13),(14,0,0,14),(15,0,0,15),(16,0,0,16),(17,0,0,17),(18,0,0,18),(19,0,0,19),(20,0,0,20),(21,0,0,21),(22,0,0,22),(23,0,0,23),(24,0,0,24),(25,0,0,25),(26,0,0,26),(27,0,0,27),(28,0,0,28),(29,0,0,29),(30,0,0,30),(31,0,0,31),(32,0,0,32),(33,0,0,33),(34,0,0,34);
/*!40000 ALTER TABLE `usersettings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workschedule`
--

DROP TABLE IF EXISTS `workschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workschedule` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `EmployeeId` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_WorkSchedule_EmployeeId` (`EmployeeId`),
  CONSTRAINT `FK_WorkSchedule_Employees_EmployeeId` FOREIGN KEY (`EmployeeId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workschedule`
--

LOCK TABLES `workschedule` WRITE;
/*!40000 ALTER TABLE `workschedule` DISABLE KEYS */;
INSERT INTO `workschedule` VALUES (2,1),(1,31);
/*!40000 ALTER TABLE `workschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workshift`
--

DROP TABLE IF EXISTS `workshift`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workshift` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `WorkScheduleId` int NOT NULL,
  `DateTime` datetime(6) NOT NULL,
  `ShiftStartTime` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ShiftEndTime` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_WorkShift_WorkScheduleId` (`WorkScheduleId`),
  CONSTRAINT `FK_WorkShift_WorkSchedule_WorkScheduleId` FOREIGN KEY (`WorkScheduleId`) REFERENCES `workschedule` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workshift`
--

LOCK TABLES `workshift` WRITE;
/*!40000 ALTER TABLE `workshift` DISABLE KEYS */;
INSERT INTO `workshift` VALUES (1,1,'2024-11-07 00:00:00.000000','08:00','16:00'),(2,1,'2024-11-09 00:00:00.000000','08:00','16:00'),(3,1,'2024-11-11 00:00:00.000000','08:00','16:00'),(4,1,'2024-11-14 00:00:00.000000','08:00','16:00'),(5,1,'2024-11-15 00:00:00.000000','08:00','16:00'),(6,1,'2024-11-23 00:00:00.000000','08:00','16:00'),(7,1,'2024-12-14 00:00:00.000000','08:00','16:00'),(8,1,'2024-12-15 00:00:00.000000','08:00','16:00'),(9,1,'2024-12-23 00:00:00.000000','08:00','16:00'),(10,1,'2024-10-14 00:00:00.000000','08:00','16:00'),(11,1,'2024-10-15 00:00:00.000000','08:00','16:00'),(12,1,'2024-10-23 00:00:00.000000','08:00','16:00'),(13,2,'2024-11-07 00:00:00.000000','08:00','16:00'),(14,2,'2024-11-09 00:00:00.000000','08:00','16:00'),(15,2,'2024-11-11 00:00:00.000000','08:00','16:00'),(16,2,'2024-11-14 00:00:00.000000','08:00','16:00'),(17,2,'2024-11-15 00:00:00.000000','08:00','16:00'),(18,2,'2024-11-23 00:00:00.000000','08:00','16:00'),(19,2,'2024-12-14 00:00:00.000000','08:00','16:00'),(20,2,'2024-12-15 00:00:00.000000','08:00','16:00'),(21,2,'2024-12-23 00:00:00.000000','08:00','16:00'),(22,2,'2024-10-14 00:00:00.000000','08:00','16:00'),(23,2,'2024-10-15 00:00:00.000000','08:00','16:00'),(24,2,'2024-10-23 00:00:00.000000','08:00','16:00');
/*!40000 ALTER TABLE `workshift` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-12 22:17:12
