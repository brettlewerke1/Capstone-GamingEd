-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: gaminged-db.czq2j2udebs7.us-west-2.rds.amazonaws.com    Database: RTX
-- ------------------------------------------------------
-- Server version	8.0.28

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
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '';

--
-- Table structure for table `Account`
--

DROP TABLE IF EXISTS `Account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Account` (
  `Account_ID` int NOT NULL AUTO_INCREMENT,
  `Account_Username` varchar(45) DEFAULT NULL,
  `Account_Password` varchar(45) DEFAULT NULL,
  `Account_Role` varchar(45) DEFAULT 'student',
  PRIMARY KEY (`Account_ID`),
  UNIQUE KEY `Account_ID_UNIQUE` (`Account_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Account`
--

LOCK TABLES `Account` WRITE;
/*!40000 ALTER TABLE `Account` DISABLE KEYS */;
INSERT INTO `Account` VALUES (21,'superMan','BatmanSux','superAdmin'),(22,'tim','bestPassword','admin'),(23,'test','password','student'),(24,'waffles','hotdog','student'),(25,'Drake','Views','student'),(26,'BruceWayne','notBatman','student'),(27,'ClarkKent','batmanSuck$','student'),(29,'newuser12','pass','student'),(30,'testuser44','pass','student'),(31,'test522','pass','student'),(32,'Newaccount77','Pass','student'),(40,'NewGuy','pass','student'),(41,'TerryBaxter1','IloveEngineering','admin'),(42,'TerryBaxter','something','admin');
/*!40000 ALTER TABLE `Account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Admin`
--

DROP TABLE IF EXISTS `Admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Admin` (
  `Admin_ID` int NOT NULL AUTO_INCREMENT,
  `Admin_AccountID` int NOT NULL,
  `Admin_CourseID` int NOT NULL,
  PRIMARY KEY (`Admin_ID`),
  KEY `Admin_AccountID_idx` (`Admin_AccountID`),
  KEY `Admin_CourseID_idx` (`Admin_CourseID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Admin`
--

LOCK TABLES `Admin` WRITE;
/*!40000 ALTER TABLE `Admin` DISABLE KEYS */;
INSERT INTO `Admin` VALUES (9,22,6),(10,22,8),(18,22,143),(19,22,144),(20,42,145);
/*!40000 ALTER TABLE `Admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AssessHead`
--

DROP TABLE IF EXISTS `AssessHead`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AssessHead` (
  `AssessHead_ID` int NOT NULL AUTO_INCREMENT,
  `AssessHead_Title` varchar(100) NOT NULL DEFAULT 'Assessment',
  `AssessHead_StartDate` varchar(50) NOT NULL DEFAULT '00/00/0000 00:00:00',
  `AssessHead_EndDate` varchar(50) NOT NULL DEFAULT '00/00/0000 00:00:00',
  `AssessHead_DisplayAnswers` tinyint NOT NULL DEFAULT '1',
  `AssessHead_TotalScore` int NOT NULL DEFAULT '0',
  `AssessHead_CourseID` int NOT NULL,
  `AssessHead_MaxAttempts` int DEFAULT '3',
  PRIMARY KEY (`AssessHead_ID`),
  KEY `AssessHead_CourseID_idx` (`AssessHead_CourseID`),
  CONSTRAINT `AssessHead_CourseID` FOREIGN KEY (`AssessHead_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AssessHead`
--

LOCK TABLES `AssessHead` WRITE;
/*!40000 ALTER TABLE `AssessHead` DISABLE KEYS */;
INSERT INTO `AssessHead` VALUES (1,'Quiz #1','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,3),(2,'Quiz #2','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,3),(3,'Quiz #3','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,3),(5,'Exam #1','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,1),(6,'Quiz #4','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,3),(7,'Quiz #5','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,6,3),(24,'Skyrim Quiz','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,143,3),(25,'Lord of the Rings Quiz','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,143,3),(27,'Some Assignment','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,144,3),(28,'assessments','00/00/0000 00:00:00','00/00/0000 00:00:00',1,0,145,3);
/*!40000 ALTER TABLE `AssessHead` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Assessment`
--

DROP TABLE IF EXISTS `Assessment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Assessment` (
  `Assessment_ID` int NOT NULL AUTO_INCREMENT,
  `Assessment_QuestionType` varchar(45) DEFAULT NULL,
  `Assessment_Question` varchar(45) DEFAULT NULL,
  `Assessment_DisplayAnswers` tinyint(1) DEFAULT '1',
  `Assessment_AssessHeadID` int NOT NULL,
  `Assessment_PointsPerQuestion` int DEFAULT '1',
  PRIMARY KEY (`Assessment_ID`),
  KEY `Assessment_AssessHeadID_idx` (`Assessment_AssessHeadID`),
  CONSTRAINT `Assessment_AssessHeadID` FOREIGN KEY (`Assessment_AssessHeadID`) REFERENCES `AssessHead` (`AssessHead_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=283 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Assessment`
--

LOCK TABLES `Assessment` WRITE;
/*!40000 ALTER TABLE `Assessment` DISABLE KEYS */;
INSERT INTO `Assessment` VALUES (1,'Fill_In_Blank','How many inches in a foot?',1,1,2),(2,'Fill_In_Blank','how many centimeters in a foot?',1,2,2),(3,'Fill_In_Blank','What is 8x8?',1,3,2),(16,'Fill_In_Blank','What is 9x9?',1,1,2),(17,'Fill_In_Blank','What is 12x12?',1,1,2),(18,'Fill_In_Blank','What is 3x3?',1,2,2),(19,'Fill_In_Blank','How many states are there?',1,2,2),(20,'Fill_In_Blank','Fastest land animal?',1,3,2),(22,'Fill_In_Blank','What team was Kobe Bryant on?',1,5,10),(23,'MultipleChoice','What is the tallest animal?',1,5,10),(24,'MultipleChoice','Where is the food capital of the world?',1,5,10),(25,'MultipleChoice','Who was the first president of the USA?',1,5,10),(26,'MultipleChoice','2x8=?',1,5,10),(27,'Fill_In_Blank','3+11=?',1,6,2),(28,'Fill_In_Blank','8/2=?',1,7,2),(274,'Fill_in_Blank','What is the capital of Skyrim?',1,24,15),(275,'Matching','Match the character to the race',1,25,5),(276,'Fill_in_Blank','Where does sauron live?',1,25,5),(277,'Multiple Choice','How many rings of power exist?',1,25,5),(278,'Multiple Choice','What did frodo carry?',1,25,10),(280,'Multiple Choice','What is the best course?',1,27,15),(281,'Matching','Match the state with the city',1,1,2),(282,'Fill_in_Blank','something',1,28,5);
/*!40000 ALTER TABLE `Assessment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AssessmentAnswer`
--

DROP TABLE IF EXISTS `AssessmentAnswer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AssessmentAnswer` (
  `AssessmentAnswer_ID` int NOT NULL AUTO_INCREMENT,
  `AssessmentAnswer_MatchingDropDownOption` varchar(45) DEFAULT NULL,
  `AssessmentAnswer_MatchingOption` varchar(45) DEFAULT NULL,
  `AssessmentAnswer_CorrectAnswers` varchar(45) DEFAULT NULL,
  `AssessmentAnswer_AssessHeadID` int NOT NULL DEFAULT '1',
  `AssessmentAnswer_AssessmentID` int NOT NULL,
  `AssessmentAnswer_EnteredAnswer` varchar(45) DEFAULT NULL,
  `AssessmentAnswer_MultipleChoiceOption` varchar(45) DEFAULT NULL,
  `AssessmentAnswer_Coins` int DEFAULT NULL,
  PRIMARY KEY (`AssessmentAnswer_ID`),
  KEY `AssessmentAnswer_AssessHeadID_idx` (`AssessmentAnswer_AssessHeadID`),
  KEY `AssessmentAnswer_AssessmentID_idx` (`AssessmentAnswer_AssessmentID`),
  CONSTRAINT `AssessmentAnswer_AssessHeadID` FOREIGN KEY (`AssessmentAnswer_AssessHeadID`) REFERENCES `AssessHead` (`AssessHead_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AssessmentAnswer_AssessmentID` FOREIGN KEY (`AssessmentAnswer_AssessmentID`) REFERENCES `Assessment` (`Assessment_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=415 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AssessmentAnswer`
--

LOCK TABLES `AssessmentAnswer` WRITE;
/*!40000 ALTER TABLE `AssessmentAnswer` DISABLE KEYS */;
INSERT INTO `AssessmentAnswer` VALUES (1,NULL,NULL,'12',1,1,NULL,NULL,2),(2,NULL,NULL,'100',2,2,NULL,NULL,2),(3,NULL,NULL,'64',3,3,NULL,NULL,2),(76,NULL,NULL,'81',1,16,NULL,NULL,2),(77,NULL,NULL,'144',1,17,NULL,NULL,2),(78,NULL,NULL,'9',2,18,NULL,NULL,2),(79,NULL,NULL,'50',2,19,NULL,NULL,2),(80,NULL,NULL,'Cheetah',3,20,NULL,NULL,2),(82,NULL,NULL,'Lakers',5,22,NULL,NULL,2),(83,NULL,NULL,'Giraffe',5,23,NULL,'Rhino',0),(84,NULL,NULL,NULL,5,23,NULL,'Giraffe',2),(85,NULL,NULL,NULL,5,23,NULL,'Goat',0),(86,NULL,NULL,NULL,5,23,NULL,'Horse',0),(87,NULL,NULL,'New York City',5,24,NULL,'Tokyo',0),(88,NULL,NULL,NULL,5,24,NULL,'Rome',0),(89,NULL,NULL,NULL,5,24,NULL,'Paris',0),(90,NULL,NULL,NULL,5,24,NULL,'New York City',2),(95,NULL,NULL,'George Washington',5,25,NULL,'George Bush',0),(96,NULL,NULL,NULL,5,25,NULL,'John Adams',0),(97,NULL,NULL,NULL,5,25,NULL,'Abraham Lincoln',0),(98,NULL,NULL,NULL,5,25,NULL,'George Washington',2),(99,NULL,NULL,'16',5,26,NULL,'14',0),(100,NULL,NULL,NULL,5,26,NULL,'15',0),(101,NULL,NULL,NULL,5,26,NULL,'16',2),(102,NULL,NULL,NULL,5,26,NULL,'17',0),(103,NULL,NULL,'14',6,27,NULL,NULL,2),(104,NULL,NULL,'4',7,28,NULL,NULL,2),(401,NULL,NULL,'SE444',27,280,NULL,'SE444',30),(402,NULL,NULL,NULL,27,280,NULL,'CS450',30),(403,NULL,NULL,NULL,27,280,NULL,'LS600',30),(404,'Arizona','Phoenix','Arizona',1,281,NULL,NULL,2),(408,'Nevada','Las Vegas','Nevada',1,281,NULL,NULL,2),(409,'Utah','Salt Lake City','Utah',1,281,NULL,NULL,2),(410,'California','San Diego','California',1,281,NULL,NULL,2),(411,NULL,NULL,'SE444',27,280,NULL,'SE444',30),(412,NULL,NULL,NULL,27,280,NULL,'CS450',30),(413,NULL,NULL,NULL,27,280,NULL,'LS600',30),(414,NULL,NULL,'something',28,282,NULL,NULL,10);
/*!40000 ALTER TABLE `AssessmentAnswer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Assignment`
--

DROP TABLE IF EXISTS `Assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Assignment` (
  `Assignment_ID` int NOT NULL,
  `Assignment_Title` varchar(50) DEFAULT NULL,
  `Assignment_Desc` varchar(1000) DEFAULT NULL,
  `Assignment_StartDate` varchar(45) DEFAULT '00/00/0000 00:00:00',
  `Assignment_EndDate` varchar(45) DEFAULT '00/00/0000 00:00:00',
  `Assignment_TotalScore` int DEFAULT '0',
  `Assignment_CourseID` int NOT NULL,
  PRIMARY KEY (`Assignment_ID`),
  KEY `Assignment_CourseID_idx` (`Assignment_CourseID`),
  CONSTRAINT `Assignment_CourseID` FOREIGN KEY (`Assignment_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Assignment`
--

LOCK TABLES `Assignment` WRITE;
/*!40000 ALTER TABLE `Assignment` DISABLE KEYS */;
INSERT INTO `Assignment` VALUES (0,'Assignment #1','Description #1','00/00/0000 00:00:00','00/00/0000 00:00:00',20,6);
/*!40000 ALTER TABLE `Assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AssignmentSubmissions`
--

DROP TABLE IF EXISTS `AssignmentSubmissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AssignmentSubmissions` (
  `AssignmentS_ID` int NOT NULL,
  `AssignmentS_AssignmentID` int NOT NULL,
  `AssignmentS_PlayerID` int NOT NULL,
  `AssignmentS_Comment` varchar(1000) DEFAULT NULL,
  `AssignmentS_StringUpload` longtext,
  `AssignmentS_FileType` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AssignmentS_ID`),
  KEY `AssignmentS_PlayerID_idx` (`AssignmentS_PlayerID`),
  KEY `AssignmentS_AssignmentID_idx` (`AssignmentS_AssignmentID`),
  CONSTRAINT `AssignmentS_AssignmentID` FOREIGN KEY (`AssignmentS_AssignmentID`) REFERENCES `Assignment` (`Assignment_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AssignmentS_PlayerID` FOREIGN KEY (`AssignmentS_PlayerID`) REFERENCES `Player` (`Player_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AssignmentSubmissions`
--

LOCK TABLES `AssignmentSubmissions` WRITE;
/*!40000 ALTER TABLE `AssignmentSubmissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `AssignmentSubmissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Avatar`
--

DROP TABLE IF EXISTS `Avatar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Avatar` (
  `Avatar_ID` int NOT NULL AUTO_INCREMENT,
  `Avatar_Image` varchar(200) NOT NULL,
  `Avatar_Name` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Avatar_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='List of avatars';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Avatar`
--

LOCK TABLES `Avatar` WRITE;
/*!40000 ALTER TABLE `Avatar` DISABLE KEYS */;
INSERT INTO `Avatar` VALUES (0,'avatars/default.png','Default'),(3,'avatars/Kaya.png','Kaya'),(4,'avatars/Weeko.png','Weeko'),(5,'avatars/Yumiko.png','Yumiko'),(6,'avatars/Ariel.png','Ariel'),(7,'avatars/Olive.png','Olive'),(8,'avatars/Kato.png','Kato'),(9,'avatars/Brac.png','Brac'),(10,'avatars/Levi.png','Levi'),(11,'avatars/Jeff.png','Jeff'),(12,'avatars/Odon.png','Odon'),(13,'avatars/Tate.png','Tate'),(16,'avatars/Paco.png','Paco');
/*!40000 ALTER TABLE `Avatar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AvatarCourseLibrary`
--

DROP TABLE IF EXISTS `AvatarCourseLibrary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AvatarCourseLibrary` (
  `ACLibrary_ID` int NOT NULL AUTO_INCREMENT,
  `ACLibrary_AvatarID` int NOT NULL DEFAULT '0',
  `ACLibrary_CourseID` int NOT NULL,
  `ACLibrary_Cost` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`ACLibrary_ID`),
  KEY `AC_CourseID_idx` (`ACLibrary_CourseID`),
  KEY `AC_AvatarID_idx` (`ACLibrary_AvatarID`),
  CONSTRAINT `AC_AvatarID` FOREIGN KEY (`ACLibrary_AvatarID`) REFERENCES `Avatar` (`Avatar_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AC_CourseID` FOREIGN KEY (`ACLibrary_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AvatarCourseLibrary`
--

LOCK TABLES `AvatarCourseLibrary` WRITE;
/*!40000 ALTER TABLE `AvatarCourseLibrary` DISABLE KEYS */;
INSERT INTO `AvatarCourseLibrary` VALUES (31,3,6,0),(32,4,6,2),(33,5,6,100),(34,6,6,50),(35,7,6,75);
/*!40000 ALTER TABLE `AvatarCourseLibrary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AvatarPlayerLibrary`
--

DROP TABLE IF EXISTS `AvatarPlayerLibrary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AvatarPlayerLibrary` (
  `APLibrary_ID` int NOT NULL AUTO_INCREMENT,
  `APLibrary_AvatarID` int NOT NULL DEFAULT '0',
  `APLibrary_PlayerID` int NOT NULL,
  PRIMARY KEY (`APLibrary_ID`),
  KEY `APLibrary_PlayerID_idx` (`APLibrary_PlayerID`),
  KEY `APLibrary_AvatarID_idx` (`APLibrary_AvatarID`),
  CONSTRAINT `APLibrary_AvatarID` FOREIGN KEY (`APLibrary_AvatarID`) REFERENCES `Avatar` (`Avatar_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `APLibrary_PlayerID` FOREIGN KEY (`APLibrary_PlayerID`) REFERENCES `Player` (`Player_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AvatarPlayerLibrary`
--

LOCK TABLES `AvatarPlayerLibrary` WRITE;
/*!40000 ALTER TABLE `AvatarPlayerLibrary` DISABLE KEYS */;
INSERT INTO `AvatarPlayerLibrary` VALUES (16,3,26),(17,4,36),(18,3,36),(19,4,26),(20,5,26);
/*!40000 ALTER TABLE `AvatarPlayerLibrary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Course`
--

DROP TABLE IF EXISTS `Course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Course` (
  `Course_ID` int NOT NULL AUTO_INCREMENT,
  `Course_Name` varchar(200) DEFAULT NULL,
  `Course_Tag` varchar(45) DEFAULT NULL,
  `Course_LevelID` int DEFAULT NULL,
  `Course_MarketFlag` tinyint NOT NULL DEFAULT '1',
  `Course_ProfEmail` varchar(100) DEFAULT NULL,
  `Course_Key` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Course_ID`),
  UNIQUE KEY `Course_ID_UNIQUE` (`Course_ID`),
  KEY `LevelHead_idx` (`Course_LevelID`),
  CONSTRAINT `Course_LevelHeadID` FOREIGN KEY (`Course_LevelID`) REFERENCES `Level` (`Level_ID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=146 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Course_MarketFlag is a boolean\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Course`
--

LOCK TABLES `Course` WRITE;
/*!40000 ALTER TABLE `Course` DISABLE KEYS */;
INSERT INTO `Course` VALUES (6,'Intro to Computer Graphics','Course 1',16,1,'Yup.Gmail','testKey'),(7,'Course 2','Course 2',NULL,1,'No','DumbKey'),(143,'Software Techniques','CS386c',NULL,1,NULL,'LetsCode!'),(144,'DataWrangling','SE444',NULL,1,NULL,'LetsWrangle!'),(145,'DataWrangling','CS400',NULL,1,NULL,'LetsWrangle!');
/*!40000 ALTER TABLE `Course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DiscussionHead`
--

DROP TABLE IF EXISTS `DiscussionHead`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `DiscussionHead` (
  `Discussion_ID` int NOT NULL AUTO_INCREMENT,
  `Discussion_Title` varchar(100) DEFAULT 'Discussion Title',
  `Discussion_Desc` varchar(10000) DEFAULT 'Discussion Description',
  `Discussion_CourseID` int NOT NULL,
  `Discussion_Date` varchar(50) NOT NULL,
  `Discussion_PlayerID` int NOT NULL,
  `Discussion_OpenDate` varchar(50) NOT NULL DEFAULT '00/00/0000 00:00:00',
  `Discussion_CloseDate` varchar(50) NOT NULL DEFAULT '00/00/0000 00:00:00',
  PRIMARY KEY (`Discussion_ID`),
  KEY `Discussion_CourseID_idx` (`Discussion_CourseID`),
  KEY `Discussion_PlayerID_idx` (`Discussion_PlayerID`),
  CONSTRAINT `Discussion_CourseID` FOREIGN KEY (`Discussion_CourseID`) REFERENCES `Course` (`Course_ID`),
  CONSTRAINT `Discussion_PlayerID` FOREIGN KEY (`Discussion_PlayerID`) REFERENCES `Player` (`Player_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='If CloseDate == Default, don''t close';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DiscussionHead`
--

LOCK TABLES `DiscussionHead` WRITE;
/*!40000 ALTER TABLE `DiscussionHead` DISABLE KEYS */;
INSERT INTO `DiscussionHead` VALUES (24,'new discussion title 1','content of new discussion 1',6,'11/11/2022 19:52:40',26,'00/00/0000 00:00:00','00/00/0000 00:00:00'),(25,'new discussion title 2','content 2',6,'12/08/2022 21:08:11',26,'00/00/0000 00:00:00','00/00/0000 00:00:00'),(26,'new discussion 3','content 3',6,'12/08/2022 21:09:53',26,'00/00/0000 00:00:00','00/00/0000 00:00:00'),(27,'demo time title','demo time content blah blah blah',6,'12/09/2022 11:12:38',26,'00/00/0000 00:00:00','00/00/0000 00:00:00');
/*!40000 ALTER TABLE `DiscussionHead` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DiscussionPost`
--

DROP TABLE IF EXISTS `DiscussionPost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `DiscussionPost` (
  `Post_ID` int NOT NULL AUTO_INCREMENT,
  `Post_Content` varchar(5000) DEFAULT NULL,
  `Post_Time` varchar(45) DEFAULT NULL,
  `Post_PlayerID` int NOT NULL,
  `Post_HeadPostID` int NOT NULL,
  PRIMARY KEY (`Post_ID`),
  KEY `Post_HeadID_idx` (`Post_HeadPostID`),
  KEY `Post_AccountID_idx` (`Post_PlayerID`),
  CONSTRAINT `Post_HeadID` FOREIGN KEY (`Post_HeadPostID`) REFERENCES `DiscussionHead` (`Discussion_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Post_PlayerID` FOREIGN KEY (`Post_PlayerID`) REFERENCES `Player` (`Player_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DiscussionPost`
--

LOCK TABLES `DiscussionPost` WRITE;
/*!40000 ALTER TABLE `DiscussionPost` DISABLE KEYS */;
INSERT INTO `DiscussionPost` VALUES (22,'i am a reply for #2','12/08/2022 21:08:19',26,25),(24,'1223','12/08/2022 21:12:39',26,24);
/*!40000 ALTER TABLE `DiscussionPost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `GetStudentInformation`
--

DROP TABLE IF EXISTS `GetStudentInformation`;
/*!50001 DROP VIEW IF EXISTS `GetStudentInformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `GetStudentInformation` AS SELECT 
 1 AS `Account_Username`,
 1 AS `Player_IGN`,
 1 AS `Account_Password`,
 1 AS `Player_Coins`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `Grades`
--

DROP TABLE IF EXISTS `Grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Grades` (
  `Grades_ID` int NOT NULL AUTO_INCREMENT,
  `Grades_Score` int DEFAULT NULL,
  `Grades_Total` int DEFAULT NULL,
  `Grades_PlayerID` int NOT NULL,
  `Grades_ObjectID` int DEFAULT NULL,
  `Grades_ModuleID` int NOT NULL,
  PRIMARY KEY (`Grades_ID`),
  KEY `Grades_PlayerID_idx` (`Grades_PlayerID`),
  KEY `Grades_ModuleID_idx` (`Grades_ModuleID`),
  CONSTRAINT `Grades_ModuleID` FOREIGN KEY (`Grades_ModuleID`) REFERENCES `Module` (`Module_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Grades_PlayerID` FOREIGN KEY (`Grades_PlayerID`) REFERENCES `Player` (`Player_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Bridge table between player and anything with a numerical grade.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Grades`
--

LOCK TABLES `Grades` WRITE;
/*!40000 ALTER TABLE `Grades` DISABLE KEYS */;
INSERT INTO `Grades` VALUES (28,12,14,26,1,2),(29,10,10,26,0,3),(30,6,6,26,2,2),(31,2,4,26,3,2),(32,10,50,26,5,2),(33,4,6,36,1,2);
/*!40000 ALTER TABLE `Grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Level`
--

DROP TABLE IF EXISTS `Level`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Level` (
  `Level_ID` int NOT NULL AUTO_INCREMENT,
  `Level_Name` varchar(200) DEFAULT NULL,
  `Level_Desc` varchar(1000) DEFAULT NULL,
  `Level_CourseID` int DEFAULT NULL,
  PRIMARY KEY (`Level_ID`),
  KEY `Level_CourseID_idx` (`Level_CourseID`),
  CONSTRAINT `Level_CourseID` FOREIGN KEY (`Level_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Level`
--

LOCK TABLES `Level` WRITE;
/*!40000 ALTER TABLE `Level` DISABLE KEYS */;
INSERT INTO `Level` VALUES (16,'Level 1','Level 1 Description Here',NULL),(17,'Level 2','Level 2 Description Here',NULL),(36,'Level 2',NULL,143),(37,'Level 1',NULL,143),(38,'Level 1',NULL,144),(39,'Level 1',NULL,145);
/*!40000 ALTER TABLE `Level` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `LevelContent`
--

DROP TABLE IF EXISTS `LevelContent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `LevelContent` (
  `LvlContent_ID` int NOT NULL AUTO_INCREMENT,
  `LvlContent_LevelID` int NOT NULL,
  `LvlContent_ObjectID` int NOT NULL,
  `LvlContent_XCord` int NOT NULL,
  `LvlContent_ZCord` int NOT NULL,
  `LvlContent_ModuleID` int NOT NULL,
  `LvlContent_Name` varchar(100) DEFAULT 'NewContent',
  `LvlContent_Unlock` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`LvlContent_ID`),
  KEY `LvlContent_LevelID_idx` (`LvlContent_LevelID`),
  KEY `LvlContent_ModuleID_idx` (`LvlContent_ModuleID`),
  CONSTRAINT `LvlContent_LevelID` FOREIGN KEY (`LvlContent_LevelID`) REFERENCES `Level` (`Level_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `LvlContent_ModuleID` FOREIGN KEY (`LvlContent_ModuleID`) REFERENCES `Module` (`Module_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Sorted by X then Z';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LevelContent`
--

LOCK TABLES `LevelContent` WRITE;
/*!40000 ALTER TABLE `LevelContent` DISABLE KEYS */;
INSERT INTO `LevelContent` VALUES (11,16,1,0,0,2,'Quiz 1',0),(12,16,2,0,0,2,'Quiz 2',0),(13,16,3,0,0,2,'Quiz 3',0),(14,16,5,0,0,2,'Exam 1',0),(15,16,6,0,0,2,'Quiz 4',0),(16,17,7,0,0,2,'Quiz 5',0),(17,17,0,0,0,3,'Assignment 1',0),(20,36,24,0,0,2,'Skyrim Quiz',0),(21,37,25,0,0,2,'Lord of the Rings Quiz',0),(22,38,27,0,0,2,'Some Assignment',0),(23,39,28,0,0,2,'assessments',0);
/*!40000 ALTER TABLE `LevelContent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `LevelTree`
--

DROP TABLE IF EXISTS `LevelTree`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `LevelTree` (
  `LevelTree_ID` int NOT NULL AUTO_INCREMENT,
  `LevelTree_CurrentLevelID` int NOT NULL,
  `LevelTree_NextLevelID` int NOT NULL,
  PRIMARY KEY (`LevelTree_ID`),
  UNIQUE KEY `LevelTree_ID_UNIQUE` (`LevelTree_ID`),
  KEY `CurrentLevelID_idx` (`LevelTree_CurrentLevelID`),
  KEY `NextLevelID_idx` (`LevelTree_NextLevelID`),
  CONSTRAINT `CurrentLevelID` FOREIGN KEY (`LevelTree_CurrentLevelID`) REFERENCES `Level` (`Level_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `NextLevelID` FOREIGN KEY (`LevelTree_NextLevelID`) REFERENCES `Level` (`Level_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=256 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Bridge table between courses';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LevelTree`
--

LOCK TABLES `LevelTree` WRITE;
/*!40000 ALTER TABLE `LevelTree` DISABLE KEYS */;
INSERT INTO `LevelTree` VALUES (15,16,17),(248,36,37);
/*!40000 ALTER TABLE `LevelTree` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `LevelUnlock`
--

DROP TABLE IF EXISTS `LevelUnlock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `LevelUnlock` (
  `LvlUnlock_ID` int NOT NULL AUTO_INCREMENT,
  `LvlUnlock_LevelTreeID` int NOT NULL,
  `LvlUnlock_Type` varchar(45) NOT NULL DEFAULT 'LIVES',
  `LvlUnlock_NumGoal` int DEFAULT '3',
  `LvlUnlock_LvlContentID` int NOT NULL,
  PRIMARY KEY (`LvlUnlock_ID`),
  KEY `LvlUnlock_LevelTreeID_idx` (`LvlUnlock_LevelTreeID`),
  CONSTRAINT `LvlUnlock_LevelTreeID` FOREIGN KEY (`LvlUnlock_LevelTreeID`) REFERENCES `LevelTree` (`LevelTree_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LevelUnlock`
--

LOCK TABLES `LevelUnlock` WRITE;
/*!40000 ALTER TABLE `LevelUnlock` DISABLE KEYS */;
/*!40000 ALTER TABLE `LevelUnlock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Module`
--

DROP TABLE IF EXISTS `Module`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Module` (
  `Module_ID` int NOT NULL AUTO_INCREMENT,
  `Module_Name` varchar(45) NOT NULL DEFAULT 'ModuleName',
  `Module_Path` varchar(45) NOT NULL DEFAULT '/',
  PRIMARY KEY (`Module_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Dicionary for all the possible objects in level content';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Module`
--

LOCK TABLES `Module` WRITE;
/*!40000 ALTER TABLE `Module` DISABLE KEYS */;
INSERT INTO `Module` VALUES (0,'Error','/'),(1,'Text','/text'),(2,'Asessment','/assessments'),(3,'Assignment','/assignment');
/*!40000 ALTER TABLE `Module` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Player`
--

DROP TABLE IF EXISTS `Player`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Player` (
  `Player_ID` int NOT NULL AUTO_INCREMENT,
  `Player_Coins` int DEFAULT '0',
  `Player_IGN` varchar(45) DEFAULT 'TavDefaultName',
  `Player_AccountID` int NOT NULL,
  `Player_CourseID` int NOT NULL,
  `Player_CurrentAvatarID` int DEFAULT '0',
  `Player_Letter_Grade` varchar(45) DEFAULT 'F',
  `Player_Percentage_Grade` int DEFAULT '0',
  PRIMARY KEY (`Player_ID`),
  UNIQUE KEY `PlayerInfo_ID_UNIQUE` (`Player_ID`),
  KEY `Account_ID_idx` (`Player_AccountID`),
  KEY `Course_ID_idx` (`Player_CourseID`),
  KEY `Player_AvatarID_idx` (`Player_CurrentAvatarID`),
  CONSTRAINT `Player_AccountID` FOREIGN KEY (`Player_AccountID`) REFERENCES `Account` (`Account_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Player_AvatarID` FOREIGN KEY (`Player_CurrentAvatarID`) REFERENCES `Avatar` (`Avatar_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Player_CourseID` FOREIGN KEY (`Player_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Course-Account Bridge Table\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Player`
--

LOCK TABLES `Player` WRITE;
/*!40000 ALTER TABLE `Player` DISABLE KEYS */;
INSERT INTO `Player` VALUES (26,1256,'SkyrimLvr',23,6,4,'F',48),(31,0,'MyNameDumb',23,7,0,'F',0),(32,1000,'MrWorldWide',25,6,0,'C',0),(33,1500,'Robin',26,6,0,'B',85),(34,300,'Superman',27,6,0,'A',0),(36,2,'TimDrake',22,6,4,'D',67),(38,150,'GreenArrow',40,144,0,'F',0);
/*!40000 ALTER TABLE `Player` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Progress`
--

DROP TABLE IF EXISTS `Progress`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Progress` (
  `Progress_ID` int NOT NULL AUTO_INCREMENT,
  `Progress_PlayerID` int NOT NULL,
  `Progress_LevelTreeID` int NOT NULL,
  `Progress_CompleteFlag` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`Progress_ID`),
  KEY `Progress_PlayerID_idx` (`Progress_PlayerID`),
  KEY `Progress_LvlTreeID_idx` (`Progress_LevelTreeID`),
  CONSTRAINT `Progress_LvlTreeID` FOREIGN KEY (`Progress_LevelTreeID`) REFERENCES `LevelTree` (`LevelTree_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Progress_PlayerID` FOREIGN KEY (`Progress_PlayerID`) REFERENCES `Player` (`Player_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Progress`
--

LOCK TABLES `Progress` WRITE;
/*!40000 ALTER TABLE `Progress` DISABLE KEYS */;
INSERT INTO `Progress` VALUES (60,26,15,1);
/*!40000 ALTER TABLE `Progress` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ProgressUnlocks`
--

DROP TABLE IF EXISTS `ProgressUnlocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ProgressUnlocks` (
  `PU_ID` int NOT NULL AUTO_INCREMENT,
  `PU_LvlUnlockID` int NOT NULL,
  `PU_ProgressID` int NOT NULL,
  `PU_NumAttempts` int DEFAULT '0',
  `PU_MaxAttempts` int DEFAULT NULL,
  PRIMARY KEY (`PU_ID`),
  KEY `PU_ProgressID_idx` (`PU_ProgressID`),
  KEY `PU_LvlUnlockID_idx` (`PU_LvlUnlockID`),
  CONSTRAINT `PU_LvlUnlockID` FOREIGN KEY (`PU_LvlUnlockID`) REFERENCES `LevelUnlock` (`LvlUnlock_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `PU_ProgressID` FOREIGN KEY (`PU_ProgressID`) REFERENCES `Progress` (`Progress_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ProgressUnlocks`
--

LOCK TABLES `ProgressUnlocks` WRITE;
/*!40000 ALTER TABLE `ProgressUnlocks` DISABLE KEYS */;
/*!40000 ALTER TABLE `ProgressUnlocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Text`
--

DROP TABLE IF EXISTS `Text`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Text` (
  `Text_ID` int NOT NULL,
  `Text_Title` varchar(100) DEFAULT 'Text box',
  `Text_Content` varchar(2000) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT 'Nothing here.',
  PRIMARY KEY (`Text_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Text inside the level';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Text`
--

LOCK TABLES `Text` WRITE;
/*!40000 ALTER TABLE `Text` DISABLE KEYS */;
/*!40000 ALTER TABLE `Text` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Transaction`
--

DROP TABLE IF EXISTS `Transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Transaction` (
  `Transaction_ID` int NOT NULL AUTO_INCREMENT,
  `Transaction_CourseID` int NOT NULL,
  `Transaction_Avatars` tinyint NOT NULL DEFAULT '1',
  `Transaction_Redo` tinyint NOT NULL DEFAULT '1',
  `Transaction_ExemptMedal` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`Transaction_ID`,`Transaction_CourseID`),
  UNIQUE KEY `Transaction_ID_UNIQUE` (`Transaction_ID`),
  KEY `Course_ID_idx` (`Transaction_CourseID`),
  CONSTRAINT `Course_ID` FOREIGN KEY (`Transaction_CourseID`) REFERENCES `Course` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Transaction`
--

LOCK TABLES `Transaction` WRITE;
/*!40000 ALTER TABLE `Transaction` DISABLE KEYS */;
INSERT INTO `Transaction` VALUES (5,6,3,1,1);
/*!40000 ALTER TABLE `Transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `getOneTeacher`
--

DROP TABLE IF EXISTS `getOneTeacher`;
/*!50001 DROP VIEW IF EXISTS `getOneTeacher`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `getOneTeacher` AS SELECT 
 1 AS `Account_ID`,
 1 AS `Account_Username`,
 1 AS `Account_Password`,
 1 AS `Account_Role`,
 1 AS `Course_ID`,
 1 AS `Course_Name`,
 1 AS `Course_Tag`,
 1 AS `Course_LevelID`,
 1 AS `Course_MarketFlag`,
 1 AS `Course_ProfEmail`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `GetStudentInformation`
--

/*!50001 DROP VIEW IF EXISTS `GetStudentInformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`superAdmin`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `GetStudentInformation` AS select `Account`.`Account_Username` AS `Account_Username`,`Player`.`Player_IGN` AS `Player_IGN`,`Account`.`Account_Password` AS `Account_Password`,`Player`.`Player_Coins` AS `Player_Coins` from (`Account` join `Player` on((`Account`.`Account_ID` = `Player`.`Player_AccountID`))) where (`Account`.`Account_Username` = 'Jimmy') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `getOneTeacher`
--

/*!50001 DROP VIEW IF EXISTS `getOneTeacher`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`superAdmin`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `getOneTeacher` AS select `Account`.`Account_ID` AS `Account_ID`,`Account`.`Account_Username` AS `Account_Username`,`Account`.`Account_Password` AS `Account_Password`,`Account`.`Account_Role` AS `Account_Role`,`Course`.`Course_ID` AS `Course_ID`,`Course`.`Course_Name` AS `Course_Name`,`Course`.`Course_Tag` AS `Course_Tag`,`Course`.`Course_LevelID` AS `Course_LevelID`,`Course`.`Course_MarketFlag` AS `Course_MarketFlag`,`Course`.`Course_ProfEmail` AS `Course_ProfEmail` from ((`Account` join `Admin` on((`Account`.`Account_ID` = `Admin`.`Admin_AccountID`))) join `Course` on((`Admin`.`Admin_CourseID` = `Course`.`Course_ID`))) where (`Account`.`Account_Role` = 'admin') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-13 14:43:22
