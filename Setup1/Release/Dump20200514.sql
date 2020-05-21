CREATE DATABASE  IF NOT EXISTS `inventarioprograma` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `inventarioprograma`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: inventarioprograma
-- ------------------------------------------------------
-- Server version	8.0.15

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
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material` (
  `idmaterial` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `cantidad_inicial` int(3) DEFAULT NULL,
  `stock_alert` int(3) DEFAULT NULL,
  `cant_speed` int(3) DEFAULT NULL,
  `cant_flex` int(3) DEFAULT NULL,
  `cant_360` int(3) DEFAULT NULL,
  `usuario_registrado` int(11) DEFAULT NULL,
  PRIMARY KEY (`idmaterial`),
  KEY `material_usuario_idx` (`usuario_registrado`),
  CONSTRAINT `material_usuario` FOREIGN KEY (`usuario_registrado`) REFERENCES `usuario` (`idusuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
INSERT INTO `material` VALUES (6,'nuca',18,10,1,1,1,3),(7,'corona',3,5,1,1,2,3),(8,'espalda',42,1,1,1,1,3);
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material_registros`
--

DROP TABLE IF EXISTS `material_registros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material_registros` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `material` int(11) DEFAULT NULL,
  `registros` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `material_idx` (`material`),
  KEY `registro_idx` (`registros`),
  CONSTRAINT `material` FOREIGN KEY (`material`) REFERENCES `material` (`idmaterial`),
  CONSTRAINT `registro` FOREIGN KEY (`registros`) REFERENCES `registros_produccion` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material_registros`
--

LOCK TABLES `material_registros` WRITE;
/*!40000 ALTER TABLE `material_registros` DISABLE KEYS */;
/*!40000 ALTER TABLE `material_registros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `materialregistro`
--

DROP TABLE IF EXISTS `materialregistro`;
/*!50001 DROP VIEW IF EXISTS `materialregistro`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `materialregistro` AS SELECT 
 1 AS `id`,
 1 AS `usuario`,
 1 AS `nombre`,
 1 AS `material_flex`,
 1 AS `material_speed`,
 1 AS `material_360`,
 1 AS `prod_360`,
 1 AS `prod_speed`,
 1 AS `prod_flex`,
 1 AS `fecha_produccion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `materialusario`
--

DROP TABLE IF EXISTS `materialusario`;
/*!50001 DROP VIEW IF EXISTS `materialusario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `materialusario` AS SELECT 
 1 AS `idmaterial`,
 1 AS `nombre`,
 1 AS `cantidad_inicial`,
 1 AS `stock_alert`,
 1 AS `cant_speed`,
 1 AS `cant_flex`,
 1 AS `cant_360`,
 1 AS `usuario`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `registros_produccion`
--

DROP TABLE IF EXISTS `registros_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registros_produccion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_flex` int(11) DEFAULT NULL,
  `prod_speed` int(11) DEFAULT NULL,
  `prod_360` int(11) DEFAULT NULL,
  `fecha_produccion` datetime NOT NULL,
  `usuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `usuarioregistro_idx` (`usuario`),
  CONSTRAINT `usuarioregistro` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`idusuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registros_produccion`
--

LOCK TABLES `registros_produccion` WRITE;
/*!40000 ALTER TABLE `registros_produccion` DISABLE KEYS */;
INSERT INTO `registros_produccion` VALUES (5,5,1,2,'2020-04-04 16:33:02',3),(6,2,2,2,'2020-05-05 18:15:43',3),(7,1,2,3,'2020-04-05 20:02:15',3);
/*!40000 ALTER TABLE `registros_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) DEFAULT NULL,
  `contraseña` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idusuario`),
  UNIQUE KEY `idusuario_UNIQUE` (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,'godoy','912ec803b2ce49e4a541068d495ab570'),(3,'emanuel','81dc9bdb52d04dc20036dbd8313ed055'),(4,'godoy','b46664b842fb3c84da0674949f35e9ae');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'inventarioprograma'
--

--
-- Dumping routines for database 'inventarioprograma'
--

--
-- Final view structure for view `materialregistro`
--

/*!50001 DROP VIEW IF EXISTS `materialregistro`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `materialregistro` AS select `registros_produccion`.`id` AS `id`,`usuario`.`usuario` AS `usuario`,`material`.`nombre` AS `nombre`,(`registros_produccion`.`prod_flex` * `material`.`cant_flex`) AS `material_flex`,(`registros_produccion`.`prod_speed` * `material`.`cant_speed`) AS `material_speed`,(`registros_produccion`.`prod_360` * `material`.`cant_360`) AS `material_360`,`registros_produccion`.`prod_360` AS `prod_360`,`registros_produccion`.`prod_speed` AS `prod_speed`,`registros_produccion`.`prod_flex` AS `prod_flex`,`registros_produccion`.`fecha_produccion` AS `fecha_produccion` from ((`registros_produccion` join `usuario` on((`registros_produccion`.`usuario` = `usuario`.`idusuario`))) join `material` on((`usuario`.`idusuario` = `material`.`usuario_registrado`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `materialusario`
--

/*!50001 DROP VIEW IF EXISTS `materialusario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `materialusario` AS select `material`.`idmaterial` AS `idmaterial`,`material`.`nombre` AS `nombre`,`material`.`cantidad_inicial` AS `cantidad_inicial`,`material`.`stock_alert` AS `stock_alert`,`material`.`cant_speed` AS `cant_speed`,`material`.`cant_flex` AS `cant_flex`,`material`.`cant_360` AS `cant_360`,`usuario`.`usuario` AS `usuario` from (`material` join `usuario` on((`material`.`usuario_registrado` = `usuario`.`idusuario`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-14 18:45:00
