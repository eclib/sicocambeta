# MySQL-Front 3.2  (Build 14.3)

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='SYSTEM' */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;


# Host: localhost    Database: sicocam
# ------------------------------------------------------
# Server version 5.0.27-community-nt

DROP DATABASE IF EXISTS `sicocam`;
CREATE DATABASE `sicocam` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_spanish_ci */;
USE `sicocam`;

#
# Table structure for table camiones
#

CREATE TABLE `camiones` (
  `idCamiones` int(10) unsigned NOT NULL auto_increment,
  `Patente` varchar(8) collate latin1_spanish_ci default NULL,
  PRIMARY KEY  (`idCamiones`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table camiones
#

INSERT INTO `camiones` VALUES (1,'sp7930');
INSERT INTO `camiones` VALUES (2,'YV2233');

#
# Table structure for table clientes
#

CREATE TABLE `clientes` (
  `idClientes` int(10) unsigned NOT NULL auto_increment,
  `Rut` varchar(10) collate latin1_spanish_ci default NULL,
  `Nombre` varchar(125) collate latin1_spanish_ci default NULL,
  `Direccion` varchar(125) collate latin1_spanish_ci default NULL,
  `Giro` varchar(254) collate latin1_spanish_ci default NULL,
  PRIMARY KEY  (`idClientes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table clientes
#

INSERT INTO `clientes` VALUES (1,'12494824-K','Dario Diaz Videla','Residencial Seminario #941 depto E','Desarrollo de Aplicaciones computacionales e investigacion de nuevas tecnologias');
INSERT INTO `clientes` VALUES (2,'11147076-1','Sociedad Agua Ltda.','Vecinal Número 1','Constructora');

#
# Table structure for table guias
#

CREATE TABLE `guias` (
  `idGuias` int(10) unsigned NOT NULL auto_increment,
  `idPersonal` int(10) unsigned NOT NULL,
  `idObras` int(10) unsigned NOT NULL,
  `idClientes` int(10) unsigned NOT NULL,
  `FechaGuia` date default NULL,
  `Entrega` tinyint(1) default NULL,
  `Reposicion` tinyint(1) default NULL,
  `Reinicio` tinyint(1) default NULL,
  `Retiro` tinyint(1) default NULL,
  `Cantidad` int(10) unsigned default NULL,
  `Unidad` varchar(10) collate latin1_spanish_ci default NULL,
  `CodEnt` int(10) unsigned default NULL,
  `CodRet` int(10) unsigned default NULL,
  `Detalle` varchar(254) collate latin1_spanish_ci default NULL,
  `Observaciones` varchar(254) collate latin1_spanish_ci default NULL,
  `PozoHoraSalida` time default NULL,
  `ObraHoraRecep` time default NULL,
  `ObraHoraSalida` time default NULL,
  `Nombre` varchar(50) collate latin1_spanish_ci default NULL,
  `Rut` varchar(10) collate latin1_spanish_ci default NULL,
  `Recito` varchar(50) collate latin1_spanish_ci default NULL,
  `FechaRecibo` date default NULL,
  `KmPozo` int(10) unsigned default NULL,
  `KmObra` int(10) unsigned default NULL,
  PRIMARY KEY  (`idGuias`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table guias
#

INSERT INTO `guias` VALUES (1,1,1,1,NULL,1,1,1,1,1,'1',1,1,'1','1','01:01:01',NULL,NULL,'1','1','1',NULL,1,1);

#
# Table structure for table obras
#

CREATE TABLE `obras` (
  `idObras` int(10) unsigned NOT NULL auto_increment,
  `idClientes` int(10) unsigned NOT NULL,
  `Nombre` varchar(254) collate latin1_spanish_ci default NULL,
  `Direccion` varchar(125) collate latin1_spanish_ci default NULL,
  PRIMARY KEY  (`idObras`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table obras
#

INSERT INTO `obras` VALUES (1,1,'Obra1','XXX');
INSERT INTO `obras` VALUES (2,2,'Obra2','Dos');

#
# Table structure for table personal
#

CREATE TABLE `personal` (
  `idPersonal` int(10) unsigned NOT NULL auto_increment,
  `Rut` varchar(10) collate latin1_spanish_ci default NULL,
  `Nombre` varchar(125) collate latin1_spanish_ci default NULL,
  PRIMARY KEY  (`idPersonal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table personal
#

INSERT INTO `personal` VALUES (1,'1-1','Personal 1');
INSERT INTO `personal` VALUES (2,'2-2','Prueba numero2');

#
# Table structure for table pozos
#

CREATE TABLE `pozos` (
  `idPozos` int(10) unsigned NOT NULL auto_increment,
  `Nombre` varchar(254) collate latin1_spanish_ci default NULL,
  `Direccion` varchar(254) collate latin1_spanish_ci default NULL,
  PRIMARY KEY  (`idPozos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Dumping data for table pozos
#

INSERT INTO `pozos` VALUES (28,'Pozo Norte','Uno Norte');
INSERT INTO `pozos` VALUES (29,'Pozo Sur','Dos Sur');

/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
