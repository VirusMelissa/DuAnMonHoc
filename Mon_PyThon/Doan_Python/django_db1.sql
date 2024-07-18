CREATE DATABASE  IF NOT EXISTS `django_db1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `django_db1`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: django_db1
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `auth_group`
--

DROP TABLE IF EXISTS `auth_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_group` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_group`
--

LOCK TABLES `auth_group` WRITE;
/*!40000 ALTER TABLE `auth_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `auth_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auth_group_permissions`
--

DROP TABLE IF EXISTS `auth_group_permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_group_permissions` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `group_id` int NOT NULL,
  `permission_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `auth_group_permissions_group_id_permission_id_0cd325b0_uniq` (`group_id`,`permission_id`),
  KEY `auth_group_permissio_permission_id_84c5c92e_fk_auth_perm` (`permission_id`),
  CONSTRAINT `auth_group_permissio_permission_id_84c5c92e_fk_auth_perm` FOREIGN KEY (`permission_id`) REFERENCES `auth_permission` (`id`),
  CONSTRAINT `auth_group_permissions_group_id_b120cbf9_fk_auth_group_id` FOREIGN KEY (`group_id`) REFERENCES `auth_group` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_group_permissions`
--

LOCK TABLES `auth_group_permissions` WRITE;
/*!40000 ALTER TABLE `auth_group_permissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `auth_group_permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auth_permission`
--

DROP TABLE IF EXISTS `auth_permission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_permission` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `content_type_id` int NOT NULL,
  `codename` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `auth_permission_content_type_id_codename_01ab375a_uniq` (`content_type_id`,`codename`),
  CONSTRAINT `auth_permission_content_type_id_2f476e4b_fk_django_co` FOREIGN KEY (`content_type_id`) REFERENCES `django_content_type` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_permission`
--

LOCK TABLES `auth_permission` WRITE;
/*!40000 ALTER TABLE `auth_permission` DISABLE KEYS */;
INSERT INTO `auth_permission` VALUES (1,'Can add log entry',1,'add_logentry'),(2,'Can change log entry',1,'change_logentry'),(3,'Can delete log entry',1,'delete_logentry'),(4,'Can view log entry',1,'view_logentry'),(5,'Can add permission',2,'add_permission'),(6,'Can change permission',2,'change_permission'),(7,'Can delete permission',2,'delete_permission'),(8,'Can view permission',2,'view_permission'),(9,'Can add group',3,'add_group'),(10,'Can change group',3,'change_group'),(11,'Can delete group',3,'delete_group'),(12,'Can view group',3,'view_group'),(13,'Can add user',4,'add_user'),(14,'Can change user',4,'change_user'),(15,'Can delete user',4,'delete_user'),(16,'Can view user',4,'view_user'),(17,'Can add content type',5,'add_contenttype'),(18,'Can change content type',5,'change_contenttype'),(19,'Can delete content type',5,'delete_contenttype'),(20,'Can view content type',5,'view_contenttype'),(21,'Can add session',6,'add_session'),(22,'Can change session',6,'change_session'),(23,'Can delete session',6,'delete_session'),(24,'Can view session',6,'view_session'),(25,'Can add account',7,'add_account'),(26,'Can change account',7,'change_account'),(27,'Can delete account',7,'delete_account'),(28,'Can view account',7,'view_account'),(29,'Can add category',8,'add_category'),(30,'Can change category',8,'change_category'),(31,'Can delete category',8,'delete_category'),(32,'Can view category',8,'view_category'),(33,'Can add sub category',9,'add_subcategory'),(34,'Can change sub category',9,'change_subcategory'),(35,'Can delete sub category',9,'delete_subcategory'),(36,'Can view sub category',9,'view_subcategory'),(37,'Can add product',10,'add_product'),(38,'Can change product',10,'change_product'),(39,'Can delete product',10,'delete_product'),(40,'Can view product',10,'view_product'),(41,'Can add size',11,'add_size'),(42,'Can change size',11,'change_size'),(43,'Can delete size',11,'delete_size'),(44,'Can view size',11,'view_size'),(45,'Can add san pham size',12,'add_sanphamsize'),(46,'Can change san pham size',12,'change_sanphamsize'),(47,'Can delete san pham size',12,'delete_sanphamsize'),(48,'Can view san pham size',12,'view_sanphamsize'),(49,'Can add order',13,'add_order'),(50,'Can change order',13,'change_order'),(51,'Can delete order',13,'delete_order'),(52,'Can view order',13,'view_order'),(53,'Can add product order',14,'add_productorder'),(54,'Can change product order',14,'change_productorder'),(55,'Can delete product order',14,'delete_productorder'),(56,'Can view product order',14,'view_productorder');
/*!40000 ALTER TABLE `auth_permission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auth_user`
--

DROP TABLE IF EXISTS `auth_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `password` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_login` datetime(6) DEFAULT NULL,
  `is_superuser` tinyint(1) NOT NULL,
  `username` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `first_name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(254) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_staff` tinyint(1) NOT NULL,
  `is_active` tinyint(1) NOT NULL,
  `date_joined` datetime(6) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_user`
--

LOCK TABLES `auth_user` WRITE;
/*!40000 ALTER TABLE `auth_user` DISABLE KEYS */;
INSERT INTO `auth_user` VALUES (33,'pbkdf2_sha256$720000$uFtr4O6GXtFktu77eb0LlK$NddsOUvdHoC/lWk0sBDNgPPTHR+qpTHqjf4iWz6pjkk=','2024-01-10 05:41:56.263368',1,'admin','','','admin@gmail.com',1,1,'2024-01-09 15:59:31.605977'),(36,'pbkdf2_sha256$720000$CJa1VqnlLIJs0KYEEFqSV6$jqLN8yblS3MrK1HztGJZo0eiRuDDU3bdmZOLEvBLIhk=',NULL,0,'phongngo','Phong','Ngô','admin1@gmail.com',0,1,'2024-01-09 16:02:24.109510');
/*!40000 ALTER TABLE `auth_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auth_user_groups`
--

DROP TABLE IF EXISTS `auth_user_groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_user_groups` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `group_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `auth_user_groups_user_id_group_id_94350c0c_uniq` (`user_id`,`group_id`),
  KEY `auth_user_groups_group_id_97559544_fk_auth_group_id` (`group_id`),
  CONSTRAINT `auth_user_groups_group_id_97559544_fk_auth_group_id` FOREIGN KEY (`group_id`) REFERENCES `auth_group` (`id`),
  CONSTRAINT `auth_user_groups_user_id_6a12ed8b_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_user_groups`
--

LOCK TABLES `auth_user_groups` WRITE;
/*!40000 ALTER TABLE `auth_user_groups` DISABLE KEYS */;
/*!40000 ALTER TABLE `auth_user_groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `auth_user_user_permissions`
--

DROP TABLE IF EXISTS `auth_user_user_permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auth_user_user_permissions` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `permission_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `auth_user_user_permissions_user_id_permission_id_14a6b632_uniq` (`user_id`,`permission_id`),
  KEY `auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm` (`permission_id`),
  CONSTRAINT `auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm` FOREIGN KEY (`permission_id`) REFERENCES `auth_permission` (`id`),
  CONSTRAINT `auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_user_user_permissions`
--

LOCK TABLES `auth_user_user_permissions` WRITE;
/*!40000 ALTER TABLE `auth_user_user_permissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `auth_user_user_permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_account`
--

DROP TABLE IF EXISTS `cms_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_account` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `birthday` datetime(6) NOT NULL,
  `role` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `user_id` int NOT NULL,
  `gender` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `avatar` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`user_id`),
  CONSTRAINT `cms_account_user_id_adc033a8_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_account`
--

LOCK TABLES `cms_account` WRITE;
/*!40000 ALTER TABLE `cms_account` DISABLE KEYS */;
INSERT INTO `cms_account` VALUES (1,'1998-04-02 00:00:00.000000','admin',36,'MALE','/media/1633146193_photo-2021-10-02-10-42-46_ad73e427186e471c98aee227e695b94e.jpg');
/*!40000 ALTER TABLE `cms_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_category`
--

DROP TABLE IF EXISTS `cms_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_category` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `image` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `parent_category` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_category`
--

LOCK TABLES `cms_category` WRITE;
/*!40000 ALTER TABLE `cms_category` DISABLE KEYS */;
INSERT INTO `cms_category` VALUES (3,'Bánh & Snack','/media/banh8_7bc2038fec_iOuwNtG.jpg',NULL),(4,' Hi-Tea Healthy','/media/hitea3_b642dfdee0.jpg',NULL),(5,'Hi-Tea Trà','/media/hitea4_1dd78226d1.jpg',4),(6,'Cloud','/media/caphe4_a1a23082ef.jpg',NULL),(7,'Cà Phê','/media/caphe6_9a49a156dc.jpg',NULL),(8,'Thưởng Thức Tại Nhà','/media/doibean_c4f4979e79.jpg',NULL),(9,'Thức uống đá xay','/media/daxay2_f1948604ca.jpg',NULL),(10,'Trà','/media/hitea2_57206e1dad.jpg',NULL),(11,'Trà Xanh - Chocolate','/media/thumbnail_traxanh3_b2b5d08452.jpg',NULL),(13,'Caramel Muối','/media/1701763176_phin_98b2b0e7a2fe4fa29b45ea21b4c844c9.webp',NULL),(14,'Bánh mặn','/media/1669737009_banh-mi-gay-ga-kim-quat_5686000a6e8247a2a9cc571d205a33d7.webp',3),(15,'Bánh ngọt','/media/5dd2087ff2546c2614fb08d1_red-velvet_087977_f9dfd25676874daea9fa9932aad29a96_grande.jpg',3),(16,'Snack','/media/mit-say_666228_a2b100d11ec24877b82eac5de2a61808_grande.jpg',3),(17,'Bánh Pastry','/media/croissant-trung-muoi_880850_533a8ce8102741a9ba7a73a054c50116_large.jpg',3),(18,'Cà Phê Highlight','/media/1645983791_internal-post-2-06_cd4a961ec2ae46b282790ac6480e10b5.png',7),(19,'Cà Phê Việt Nam','/media/1675355354_bg-tch-sua-da-no_6fd8102d043c4cf8b66874f51af9ea74_grande.jpg',7),(20,'Cà Phê Máy','/media/cfdenda-espressoda_185438_f2f2fb0c6cb64827bbe153e3e7ed395e_grande.jpg',7),(21,'Cold Brew','/media/1675329120_coldbrew-pbt_7f3bf666180b4f498a0d729192f5f568_grande_fzgx9lZ.jpg',7),(22,'Trà trái cây','/media/1649378747_tra-sen-nhan_fd20d61016964940baed35bcefff7ac9_grande.jpg',10),(23,'Trà sữa Macchiato','/media/capu-da_487470_1d9c592fd64b45db86fcef1fe6ec2b72_grande.jpg',10),(24,'CloudTea','/media/1700837665_tra-sua-tra-xanh-tay-bac-ly-thuy-tinh_9840303c123444b1bdaa66a35d5df9ee.jpg',6),(25,'CloudFee','/media/1675329314_bg-cloudfee-caramel_ec7f6224a90a4d07a6611ae730eb745c_grande.jpg',6),(26,'CloudTea Mochi','/media/1700837685_tra-sua-oolong-berry-ly-thuy-tinh_8dff02e358b54df490752ab02308af0d.jpg',6),(27,'Hi-Tea Đá Tuyết','/media/1669707649_bg-hitea-quyt-no_5fb54e0d0c184fd79a4dd45b704fb090_large.jpg',4),(28,'Trà Xanh Tây Bắc','/media/1689778809_tx-latte_330c146458494687bb8ad69644fa3f91_grande_wfN0Hy9.jpg',11),(29,'Chocolate','/media/chocolate-da_877186_7b41c3db50ef49eeb9fe6554ac62399b_grande.jpg',11),(30,'Đá xay Frosty','/media/chocolate-ice-blended_400940_8f4be2cb38974b99af0a5579e2133792_grande.jpg',9),(31,'Cà phê tại nhà','/media/1639648297_ca-phe-rang-xay-original-1-250gr_5367803728cc48e6b9c060003c6fc9e2_grande.jpg',8),(32,'Trà tại nhà','/media/1639646968_tra-oolong-tui-loc-tearoma-20x2gr_76684f0c1291424bbdd078c5f5605e9b_grande.jpg',8);
/*!40000 ALTER TABLE `cms_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_order`
--

DROP TABLE IF EXISTS `cms_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_order` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `username` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `note` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `created` datetime(6) NOT NULL,
  `updated` datetime(6) NOT NULL,
  `paymentStatus` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `paymentType` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `orderPartnerId` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_order`
--

LOCK TABLES `cms_order` WRITE;
/*!40000 ALTER TABLE `cms_order` DISABLE KEYS */;
INSERT INTO `cms_order` VALUES (6,'Phong','0347623279','Giao nhanh',29000.00,'2023-12-31 18:08:54.360019','2023-12-31 18:08:54.383813','SUCCESS','COD',NULL),(7,'Phong','0347623279','Ok',29000.00,'2023-12-31 18:08:54.360019','2023-12-31 18:08:54.383813','SUCCESS','COD',NULL),(8,'Phong','0347623279','P208',29000.00,'2024-01-01 05:03:50.268363','2024-01-01 05:03:50.268407','SUCCESS','COD',NULL),(9,'Phong','0347623279','Ok',107000.00,'2024-01-01 08:20:49.397191','2024-01-01 08:20:49.397231','SUCCESS','COD',NULL),(10,'Phong','0347623279','Ok',156000.00,'2024-01-01 08:23:59.626110','2024-01-01 08:23:59.626156','SUCCESS','COD',NULL),(11,'','','',58000.00,'2024-01-01 08:40:49.600784','2024-01-01 08:40:49.600812','SUCCESS','COD',NULL),(12,'Phong','0347623279','',49000.00,'2024-01-01 08:44:53.975159','2024-01-01 08:44:53.975200','SUCCESS','COD',NULL),(13,'Phong','0347623279','',55000.00,'2024-01-01 16:23:19.794792','2024-01-01 16:23:19.794832','SUCCESS','COD',NULL),(14,'e','2','e',116000.00,'2024-01-09 06:40:47.221503','2024-01-09 06:40:47.221562','SUCCESS','COD','90c9b4f8-7fdd-451e-95af-a0c261331013'),(15,'33','33','33',29000.00,'2024-01-09 06:41:10.853812','2024-01-09 06:41:10.853872','SUCCESS','MOMO','53fd0bf3-86a9-49b5-ab0a-35105c1c8b91'),(16,'Phong','0347623279','32423',19000.00,'2024-01-09 06:43:54.563573','2024-01-09 06:43:54.563624','SUCCESS','MOMO','faa0e246-0f15-44f2-bcf1-c549e9fc8c68');
/*!40000 ALTER TABLE `cms_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_product`
--

DROP TABLE IF EXISTS `cms_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_product` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `content` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `image` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `discount_price` decimal(10,2) NOT NULL,
  `note` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `category_id` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cms_product_category_id_b416490b` (`category_id`),
  CONSTRAINT `cms_product_category_id_b416490b_fk_cms_category_id` FOREIGN KEY (`category_id`) REFERENCES `cms_category` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_product`
--

LOCK TABLES `cms_product` WRITE;
/*!40000 ALTER TABLE `cms_product` DISABLE KEYS */;
INSERT INTO `cms_product` VALUES (1,'Bánh Mì Gậy Gà Kim Quất','<p>Phi&ecirc;n bản n&acirc;ng cấp với trọng lượng tăng 80% so với b&aacute;nh m&igrave; que th&ocirc;ng thường, đem đến cho bạn bữa ăn nhanh gọn m&agrave; vẫn đầy đủ dinh dưỡng. Cắn một miếng l&agrave; m&ecirc; mẩn bởi vỏ b&aacute;nh nướng gi&ograve;n rụm, nh&acirc;n đậm vị với từng miếng thịt g&agrave; mềm, ướp sốt kim quất chua ngọt, thơm nức đặc trưng. C&agrave;ng &quot;đ&uacute;ng b&agrave;i&quot; hơn khi thưởng thức k&egrave;m C&agrave; ph&ecirc; đượm vị hoặc tr&agrave; Hi-Tea thanh m&aacute;t.</p>\r\n','/media/banhman1.jpg',25000.00,5000.00,'',14),(7,'Đường Đen Sữa Đá','<p>Nếu chuộng vị c&agrave; ph&ecirc; đậm đ&agrave;, b&ugrave;ng nổ v&agrave; th&iacute;ch vị đường đen ngọt thơm, Đường Đen Sữa Đ&aacute; đ&iacute;ch thị l&agrave; thức uống d&agrave;nh cho bạn. Kh&ocirc;ng chỉ gi&uacute;p bạn tỉnh t&aacute;o buổi s&aacute;ng, Đường Đen Sữa Đ&aacute; c&ograve;n hấp dẫn đến ngụm cuối c&ugrave;ng bởi thạch c&agrave; ph&ecirc; gi&ograve;n dai, nhai cực cuốn. - Khuấy đều trước khi sử dụng</p>\r\n','/media/Caphe_VN1.jpg',45000.00,0.00,'',19),(8,'Bánh Mì Gậy Cá Ngừ Mayo','<p>Trọng lượng tăng 70% so với b&aacute;nh m&igrave; que th&ocirc;ng thường, th&ecirc;m nhiều dinh dưỡng, th&iacute;ch hợp cho cả bữa ăn nhẹ lẫn ăn no. Ngon hết chỗ ch&ecirc; từ vỏ b&aacute;nh nướng n&oacute;ng gi&ograve;n, c&aacute; ngừ đậm đ&agrave; quyện lẫn sốt mayo thơm b&eacute;o đến từng hạt bắp ngọt b&ugrave;i hấp dẫn. Nh&acirc;m nhi b&aacute;nh c&ugrave;ng ly C&agrave; ph&ecirc; thơm nồng hay Hi-Tea tươi m&aacute;t th&igrave; đ&uacute;ng chuẩn &quot;điểm mười&quot;.</p>\r\n','/media/banhman2.jpg',25000.00,0.00,'',14),(9,'Mochi Kem Phúc Bồn Tử','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n ph&uacute;c bồn tử ngọt ng&agrave;o. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot1.jpg',19000.00,0.00,'',15),(10,'Hi Tea Đào Kombucha','<p>Tr&agrave; hoa Hibiscus 0% caffeine chua nhẹ, kết hợp c&ugrave;ng tr&agrave; l&ecirc;n men Kombucha ho&agrave;n to&agrave;n tự nhi&ecirc;n v&agrave; Đ&agrave;o thanh m&aacute;t tạo n&ecirc;n Hi-Tea Đ&agrave;o Kombucha chua ngọt cực cuốn. Đặc biệt Kombucha Detox gi&agrave;u axit hữu cơ, Đ&agrave;o nhiều chất xơ gi&uacute;p thanh lọc cơ thể v&agrave; hỗ trợ giảm c&acirc;n hiệu quả. Lưu &yacute;: Khuấy đều trước khi d&ugrave;ng</p>\r\n','/media/HiTea_Tra_1.jpg',59000.00,0.00,'',5),(11,'Hi Tea Đá Tuyết Yuzu Vải','<p>Vị tr&agrave; hoa Hibiscus chua chua, kết hợp c&ugrave;ng đ&aacute; tuyết Yuzu m&aacute;t lạnh t&aacute;i t&ecirc;, th&ecirc;m miếng vải căng mọng, ngọt ng&agrave;o sẽ khiến bạn th&iacute;ch th&uacute; ngay từ lần thử đầu ti&ecirc;n.</p>\r\n','/media/HiTea_DaTuyet_1.jpg',59000.00,0.00,'',27),(12,'CloudTea Trà Xanh Tây Bắc','<p>Kh&ocirc;ng thể rời m&ocirc;i với Mochi Kem Matcha dẻo mịn, n&uacute;ng n&iacute;nh. Tr&agrave; Xanh T&acirc;y Bắc vị mộc ho&agrave; quyện sữa tươi, foam ph&ocirc; mai beo b&eacute;o v&agrave; vụn b&aacute;nh quy gi&ograve;n tan, l&agrave; lựa chọn đậm kh&ocirc;ng kh&iacute; lễ hội. M&oacute;n kh&ocirc;ng thể thiếu đ&aacute;, để ngoại h&igrave;nh v&agrave; chất lượng được đảm bảo.</p>\r\n','/media/CloudTea_1.jpg',69000.00,0.00,'',24),(13,'Trà Long Nhãn Hạt Sen','<p>Thức uống mang hương vị của nh&atilde;n, của sen, của tr&agrave; Oolong đầy thanh m&aacute;t cho tất cả c&aacute;c th&agrave;nh vi&ecirc;n trong dịp Tết n&agrave;y. An l&agrave;nh, thư th&aacute;i v&agrave; đậm đ&agrave; ch&iacute;nh l&agrave; những g&igrave; The Coffee House mong muốn gửi trao đến bạn v&agrave; gia đ&igrave;nh.</p>\r\n','/media/TTC1.jpg',49000.00,0.00,'',22),(14,'Trà Vị Đào Tearoma 14x14g','<p>Được chiết xuất từ 100% tr&agrave; tự nhi&ecirc;n, kh&ocirc;ng phẩm m&agrave;u tổng hợp, Tr&agrave; vị Đ&agrave;o Tearoma mang đến cảm gi&aacute;c thanh m&aacute;t cực đ&atilde;. Nhấp một ngụm, cảm nhận trọn vị đ&agrave;o chua ngọt thơm ngon b&ugrave;ng nổ. Ngo&agrave;i ra, tr&agrave; c&ograve;n bổ sung vitamin C cực kỳ c&oacute; lợi cho sức khoẻ.</p>\r\n','/media/1669706771_bg-tradao-min_3344e53909f14a54a03ebf674b83bad4_grande_TnHGydC.jpg',32000.00,0.00,'',32),(15,'Trà Sữa Trân Châu Tearoma 250g','<p>Chỉ 2 ph&uacute;t c&oacute; ngay ly Tr&agrave; sữa tr&acirc;n ch&acirc;u ngon chuẩn vị qu&aacute;n. Thơm vị tr&agrave;, b&eacute;o vị sữa, c&ugrave;ng tr&acirc;n ch&acirc;u thật gi&ograve;n dai sật sật. Đặc biệt, đ&acirc;y c&ograve;n l&agrave; thức uống tốt cho sức khoẻ nhờ th&agrave;nh phần 100% chiết xuất tr&agrave; tự nhi&ecirc;n, kh&ocirc;ng chất ho&aacute; học.</p>\r\n','/media/1669880647_bg-trasua-min_6acdad305af04580904044ec17773a6b_grande.jpg',49000.00,0.00,'',32),(16,'Trà Oolong Túi Lọc Tearoma 20x2G','<p>Tr&agrave; Oolong t&uacute;i lọc với m&ugrave;i hương dịu nhẹ ho&agrave;n to&agrave;n từ tự nhi&ecirc;n, vị hậu ngọt, v&agrave; hương thơm tinh tế. Tr&agrave; t&uacute;i lọc Tearoma tiện lợi để sử dụng tại văn ph&ograve;ng, tại nh&agrave;,... nhưng vẫn đảm bảo được chất lượng về hương tr&agrave; tinh tế, vị tr&agrave; đậm đ&agrave;.</p>\r\n','/media/1639646986_tra-oolong-tui-loc-tearoma-20x2gr_13321f263f484d98b120f543f8a2d1f8_7HHdEEN.jpg',29000.00,0.00,'',32),(17,'Giftset Trà Tearoma','<p>Hộp qu&agrave; tặng với 4 hộp tr&agrave; t&uacute;i lọc Tearoma c&aacute;c loại l&agrave; m&oacute;n qu&agrave; thật &yacute; nghĩa cho những người th&acirc;n y&ecirc;u.</p>\r\n','/media/1641440575_gift-set-tearoma-1_ed08ffbbb760446a937406c1af19e5f7_grande.jpg',29000.00,0.00,'',32),(18,'Trà Lài Túi Lọc Tearoma 20x2G','<p>Tr&agrave; t&uacute;i lọc Tearoma hương l&agrave;i thơm tinh tế, thanh m&aacute;t, tr&ecirc;n nền tr&agrave; xanh đậm đ&agrave; kh&oacute; qu&ecirc;n. Tr&agrave; t&uacute;i lọc Tearoma tiện lợi để sử dụng tại văn ph&ograve;ng, tại nh&agrave;,.. nhưng vẫn đảm bảo được chất lượng về hương tr&agrave; tinh tế, vị tr&agrave; đậm đ&agrave;.</p>\r\n','/media/1639647064_tra-lai-tui-loc-tearoma-20x2gr_24993660a172443da0b843e57094a348.jpg',29000.00,0.00,'',32),(19,'Phin Sữa Tươi Bánh Flan','<p>Tỉnh tức th&igrave; c&ugrave;ng c&agrave; ph&ecirc; Robusta pha phin đậm đ&agrave; v&agrave; b&aacute;nh flan n&uacute;ng n&iacute;nh. Uống l&agrave; tỉnh, ăn l&agrave; d&iacute;nh, xứng đ&aacute;ng l&agrave; highlight trong ng&agrave;y của bạn.</p>\r\n','/media/Caphe_Highlight1.jpg',49000.00,0.00,'',18),(20,'Đường Đen Marble Latte','<p>Đường Đen Marble Latte &ecirc;m dịu cực hấp dẫn bởi vị c&agrave; ph&ecirc; đắng nhẹ ho&agrave; quyện c&ugrave;ng vị đường đen ngọt thơm v&agrave; sữa tươi b&eacute;o mịn. Sự kết hợp đầy mới mẻ của c&agrave; ph&ecirc; v&agrave; đường đen cũng tạo n&ecirc;n diện mạo ph&acirc;n tầng đẹp mắt. Đ&acirc;y l&agrave; lựa chọn đ&aacute;ng thử để bạn khởi đầu ng&agrave;y mới đầy hứng khởi. - Khuấy đều trước khi sử dụng</p>\r\n','/media/Caphe_May_1.jpg',55000.00,0.00,'',20),(21,'Cold Brew Phúc Bồn Tử','<p>Vị chua ngọt của tr&aacute;i ph&uacute;c bồn tử, l&agrave;m dậy l&ecirc;n hương vị tr&aacute;i c&acirc;y tự nhi&ecirc;n vốn sẵn c&oacute; trong hạt c&agrave; ph&ecirc;, h&ograve;a quyện th&ecirc;m vị đăng đắng, ngọt dịu nhẹ nh&agrave;ng của Cold Brew 100% hạt Arabica Cầu Đất để mang đến một c&aacute;ch thưởng thức c&agrave; ph&ecirc; ho&agrave;n to&agrave;n mới, vừa thơm lừng hương c&agrave; ph&ecirc; quen thuộc, vừa nhẹ nh&agrave;ng v&agrave; thanh m&aacute;t bởi hương tr&aacute;i c&acirc;y đầy th&uacute; vị.</p>\r\n','/media/ColdBrew_1.jpg',49000.00,0.00,'',21),(22,'Chocolate Đá','<p>Bột chocolate nguy&ecirc;n chất ho&agrave; c&ugrave;ng sữa tươi b&eacute;o ngậy, ấm n&oacute;ng. Vị ngọt tự nhi&ecirc;n, kh&ocirc;ng gắt cổ, để lại một ch&uacute;t đắng nhẹ, cay cay tr&ecirc;n đầu lưỡi.</p>\r\n','/media/Chocolate1.jpg',55000.00,0.00,'',29),(23,'Frosty Phin Gato','<h3>Đ&aacute; Xay Frosty Phin-Gato l&agrave; lựa chọn kh&ocirc;ng thể bỏ lỡ cho t&iacute;n đồ c&agrave; ph&ecirc;. C&agrave; ph&ecirc; nguy&ecirc;n chất pha phin truyền thống, thơm đậm đ&agrave;, đắng mượt m&agrave;, quyện c&ugrave;ng kem sữa b&eacute;o ngậy v&agrave; đ&aacute; xay m&aacute;t lạnh. Nh&acirc;n đ&ocirc;i vị c&agrave; ph&ecirc; nhờ c&oacute; th&ecirc;m thạch c&agrave; ph&ecirc; đậm đ&agrave;, gi&ograve;n dai. Thức uống khơi ngay sự tỉnh t&aacute;o tức th&igrave;. Lưu &yacute;: Khuấy đều phần đ&aacute; xay trước khi d&ugrave;ng</h3>\r\n','/media/Frosty1.jpg',55000.00,0.00,'',30),(24,'Trà Xanh Latte','<p>Kh&ocirc;ng cần đến T&acirc;y Bắc mới cảm nhận được sự trong trẻo của n&uacute;i rừng, khi Tr&agrave; Xanh Latte từ Nh&agrave; được chắt lọc từ những b&uacute;p tr&agrave; xanh mướt, ủ m&igrave;nh trong sương sớm. Tr&agrave; xanh T&acirc;y Bắc vị thanh, ch&aacute;t nhẹ ho&agrave; c&ugrave;ng sữa tươi nguy&ecirc;n kem ngọt b&eacute;o tạo n&ecirc;n hương vị dễ uống, dễ y&ecirc;u. Đ&acirc;y l&agrave; thức uống healthy, gi&uacute;p bạn tỉnh t&aacute;o một c&aacute;ch &ecirc;m mượt, xoa dịu những căng thẳng.</p>\r\n','/media/Traxanh_TB_1.jpg',45000.00,0.00,'',28),(25,'Trà Xanh Latte','<p>Tr&agrave; Xanh Latte (N&oacute;ng) l&agrave; phi&ecirc;n bản r&otilde; vị tr&agrave; nhất. Nhấp một ngụm, bạn chạm ngay vị tr&agrave; xanh T&acirc;y Bắc ch&aacute;t nhẹ ho&agrave; c&ugrave;ng sữa nguy&ecirc;n kem thơm b&eacute;o, đọng lại hậu vị ngọt ng&agrave;o, &ecirc;m dịu. Kh&ocirc;ng chỉ l&agrave; thức uống tốt cho sức khoẻ, Tr&agrave; Xanh Latte (N&oacute;ng) c&ograve;n l&agrave; c&aacute;i &ocirc;m ấm &aacute;p của đồng b&agrave;o T&acirc;y Bắc gửi cho người miền xu&ocirc;i.</p>\r\n','/media/Traxanh_TB_2.jpg',45000.00,0.00,'',28),(26,'Trà Xanh Đường Đen','<p>Tr&agrave; Xanh Đường Đen với hiệu ứng ph&acirc;n tầng đẹp mắt, như ph&aacute;c hoạ n&uacute;i đồi T&acirc;y Bắc bảng lảng trong sương m&acirc;y, thấp tho&aacute;ng những nương ch&egrave; xanh ng&aacute;t. Từng ngụm l&agrave; sự h&agrave;i ho&agrave; từ tr&agrave; xanh đậm đ&agrave;, đường đen ngọt ng&agrave;o, sữa tươi thơm b&eacute;o. Khuấy đều trước khi d&ugrave;ng, để thưởng thức đ&uacute;ng vị</p>\r\n','/media/Traxanh_TB_3.jpg',55000.00,0.00,'',28),(27,'Frosty Cà Phê Đường Đen','<p>Đ&aacute; Xay Frosty C&agrave; Ph&ecirc; Đường Đen m&aacute;t lạnh, sảng kho&aacute;i ngay từ ngụm đầu ti&ecirc;n nhờ sự kết hợp vượt chuẩn vị quen giữa Espresso đậm đ&agrave; v&agrave; Đường Đen ngọt thơm. Đặc biệt, whipping cream beo b&eacute;o c&ugrave;ng thạch c&agrave; ph&ecirc; gi&ograve;n dai, đậm vị nh&acirc;n đ&ocirc;i sự hấp dẫn, khơi bừng sự hứng khởi trong t&iacute;ch tắc.</p>\r\n','/media/Frosty2.jpg',59000.00,0.00,'',30),(28,'Trà Đào Cam Sả Đá','<p>Vị thanh ngọt của đ&agrave;o, vị chua dịu của Cam V&agrave;ng nguy&ecirc;n vỏ, vị ch&aacute;t của tr&agrave; đen tươi được ủ mới mỗi 4 tiếng, c&ugrave;ng hương thơm nồng đặc trưng của sả ch&iacute;nh l&agrave; điểm s&aacute;ng l&agrave;m n&ecirc;n sức hấp dẫn của thức uống n&agrave;y.</p>\r\n','/media/TTC2.jpg',49000.00,0.00,'',22),(29,'Trà Đào Cam Sả Nóng','<p>Vị thanh ngọt của đ&agrave;o, vị chua dịu của Cam V&agrave;ng nguy&ecirc;n vỏ, vị ch&aacute;t của tr&agrave; đen tươi được ủ mới mỗi 4 tiếng, c&ugrave;ng hương thơm nồng đặc trưng của sả ch&iacute;nh l&agrave; điểm s&aacute;ng l&agrave;m n&ecirc;n sức hấp dẫn của thức uống n&agrave;y.</p>\r\n','/media/TTC3.jpg',59000.00,0.00,'',22),(30,'Trà Hạt Sen Đá','<p>Nền tr&agrave; oolong hảo hạng kết hợp c&ugrave;ng hạt sen tươi, b&ugrave;i b&ugrave;i v&agrave; lớp foam cheese b&eacute;o ngậy. Tr&agrave; hạt sen l&agrave; thức uống thanh m&aacute;t, nhẹ nh&agrave;ng ph&ugrave; hợp cho cả buổi s&aacute;ng v&agrave; chiều tối.</p>\r\n','/media/TTC4.jpg',39000.00,0.00,'',22),(31,'Trà Hạt Sen Nóng','<p>Nền tr&agrave; oolong hảo hạng kết hợp c&ugrave;ng hạt sen tươi, b&ugrave;i b&ugrave;i thơm ngon. Tr&agrave; hạt sen l&agrave; thức uống thanh m&aacute;t, nhẹ nh&agrave;ng ph&ugrave; hợp cho cả buổi s&aacute;ng v&agrave; chiều tối.</p>\r\n','/media/TTC5.jpg',49000.00,0.00,'',22),(32,'Trà Đào Cam Sả Chai Fresh 500ML','<p>Với phi&ecirc;n bản chai fresh 500ml, thức uống &quot;best seller&quot; đỉnh cao mang một diện mạo tươi mới, tiện lợi, ph&ugrave; hợp với b&igrave;nh thường mới v&agrave; vẫn giữ nguy&ecirc;n vị thanh ngọt của đ&agrave;o, vị chua dịu của cam v&agrave;ng nguy&ecirc;n vỏ v&agrave; vị tr&agrave; đen thơm lừng ly Tr&agrave; đ&agrave;o cam sả nguy&ecirc;n bản. *Sản phẩm d&ugrave;ng ngon nhất trong ng&agrave;y. *Sản phẩm mặc định mức đường v&agrave; kh&ocirc;ng đ&aacute;.</p>\r\n','/media/TTC6.jpg',105000.00,0.00,'',22),(33,'  Trà Đen Macchiato','<p>Tr&agrave; đen được ủ mới mỗi ng&agrave;y, giữ nguy&ecirc;n được vị ch&aacute;t mạnh mẽ đặc trưng của l&aacute; tr&agrave;, phủ b&ecirc;n tr&ecirc;n l&agrave; lớp Macchiato &quot;homemade&quot; bồng bềnh quyến rũ vị ph&ocirc; mai mặn mặn m&agrave; b&eacute;o b&eacute;o.</p>\r\n','/media/TS_Macchiato_1.jpg',55000.00,0.00,'',23),(34,'Hồng Trà Sữa Trân Châu','<p>Th&ecirc;m ch&uacute;t ngọt ng&agrave;o cho ng&agrave;y mới với hồng tr&agrave; nguy&ecirc;n l&aacute;, sữa thơm ngậy được c&acirc;n chỉnh với tỉ lệ ho&agrave;n hảo, c&ugrave;ng tr&acirc;n ch&acirc;u trắng dai gi&ograve;n c&oacute; sẵn để bạn tận hưởng từng ngụm tr&agrave; sữa ngọt ng&agrave;o thơm ngậy thiệt đ&atilde;.</p>\r\n','/media/TS_Macchiato_2.jpg',55000.00,0.00,'',23),(35,'Hồng Trà Sữa Nóng','<p>Từng ngụm tr&agrave; chuẩn gu ấm &aacute;p, đậm đ&agrave; beo b&eacute;o bởi lớp sữa tươi ch&acirc;n &aacute;i ho&agrave; quyện. Tr&agrave; đen nguy&ecirc;n l&aacute; &acirc;m ấm dịu nhẹ, quyện c&ugrave;ng lớp sữa thơm b&eacute;o kh&oacute; lẫn - hương vị ấm &aacute;p chuẩn gu tr&agrave;, cho từng ngụm nhẹ nh&agrave;ng, ngọt dịu lưu luyến m&atilde;i nơi cuống họng.</p>\r\n','/media/TS_Macchiato_3.jpg',55000.00,0.00,'',23),(36,'Trà sữa Oolong Nướng Trân Châu','<p>Hương vị ch&acirc;n &aacute;i đ&uacute;ng gu đậm đ&agrave; với tr&agrave; oolong được &ldquo;sao&rdquo; (nướng) l&acirc;u hơn cho hương vị đậm đ&agrave;, h&ograve;a quyện với sữa thơm b&eacute;o mang đến cảm gi&aacute;c m&aacute;t lạnh, lưu luyến vị tr&agrave; sữa đậm đ&agrave; nơi v&ograve;m họng.</p>\r\n','/media/TS_Macchiato_4.jpg',55000.00,0.00,'',23),(37,'Trà sữa Oolong Nướng (Nóng)','<p>Đậm đ&agrave; chuẩn gu v&agrave; ấm n&oacute;ng - bởi lớp tr&agrave; oolong nướng đậm vị ho&agrave; c&ugrave;ng lớp sữa thơm b&eacute;o. Hương vị ch&acirc;n &aacute;i đ&uacute;ng gu đậm đ&agrave; - tr&agrave; oolong được &quot;sao&quot; (nướng) l&acirc;u hơn cho vị đậm đ&agrave;, ho&agrave; quyện với sữa thơm ngậy. Cho từng ngụm ấm &aacute;p, lưu luyến vị tr&agrave; sữa đậm đ&agrave; m&atilde;i nơi cuống họng.</p>\r\n','/media/TS_Macchiato_5.jpg',55000.00,0.00,'',23),(38,'Trà Sữa Mắc Ca Trân Châu','<p>Mỗi ng&agrave;y với The Coffee House sẽ l&agrave; điều tươi mới hơn với sữa hạt mắc ca thơm ngon, bổ dưỡng quyện c&ugrave;ng nền tr&agrave; oolong cho vị c&acirc;n bằng, ngọt dịu đi k&egrave;m c&ugrave;ng Tr&acirc;n ch&acirc;u trắng gi&ograve;n dai mang lại cảm gi&aacute;c &ldquo;đ&atilde;&rdquo; trong từng ngụm tr&agrave; sữa.</p>\r\n','/media/TS_Macchiato_6.jpg',55000.00,0.00,'',23),(39,'Trà Sữa Oolong Nướng Trân Châu Chai Fresh 500ML','<p>Phi&ecirc;n bản chai fresh 500ml mới, The Coffee House tin rằng với diện mạo mới: tiện lợi v&agrave; ph&ugrave; hợp với b&igrave;nh thường mới n&agrave;y, c&aacute;c t&iacute;n đồ tr&agrave; sữa sẽ được thưởng thức hương vị đậm đ&agrave;, h&ograve;a quyện với sữa thơm b&eacute;o mang đến cảm gi&aacute;c m&aacute;t lạnh ở bất cứ nơi đ&acirc;u. *Sản phẩm d&ugrave;ng ngon nhất trong ng&agrave;y. *Sản phẩm mặc định mức đường v&agrave; kh&ocirc;ng đ&aacute;.</p>\r\n','/media/TS_Macchiato_7.jpg',95000.00,0.00,'',23),(40,'CloudTea Oolong Berry','<p>Cắn một c&aacute;i, chua chua ngọt ngọt ngon đến từng tế b&agrave;o với chiếc Mochi Kem Ph&uacute;c Bồn Tử! H&uacute;t một ngụm, m&ecirc; lu&ocirc;n Tr&agrave; Oolong Sữa dịu &ecirc;m quyện vị d&acirc;u, c&ugrave;ng lớp foam ph&ocirc; mai phủ vụn b&aacute;nh quy ph&ocirc; mai mằn mặn. M&oacute;n kh&ocirc;ng thể thiếu đ&aacute;, để ngoại h&igrave;nh v&agrave; chất lượng được đảm bảo.</p>\r\n','/media/CloudTea_2.jpg',69000.00,0.00,'',24),(41,'CloudTea Oolong Nướng Kem Dừa','<p>Vừa chạm m&ocirc;i l&agrave; m&ecirc; mẩn ngay lớp kem dừa beo b&eacute;o, k&egrave;m vụn b&aacute;nh quy ph&ocirc; mai gi&ograve;n tan trong miệng. Đặc biệt, tr&agrave; Oolong nướng đậm đ&agrave;, h&ograve;a c&ugrave;ng sữa dừa ngọt dịu. Hương vị th&ecirc;m b&ugrave;ng nổ nhờ c&oacute; thạch Oolong nướng nguy&ecirc;n chất, gi&ograve;n dai.</p>\r\n','/media/CloudTea_3.jpg',55000.00,0.00,'',24),(42,'CloudTea Oolong Nướng Kem Cheese','<p>Hội m&ecirc; cheese sao c&oacute; thể bỏ lỡ chiếc tr&agrave; sữa si&ecirc;u mlem n&agrave;y. M&oacute;n đậm vị Oolong nướng - nền tr&agrave; được y&ecirc;u th&iacute;ch nhất hiện nay, quyện th&ecirc;m kem sữa thơm b&eacute;o. Đặc biệt, chinh phục ngay fan ghiền cheese bởi lớp foam ph&ocirc; mai mềm tan mằn mặn. C&agrave;ng ngon cực với thạch Oolong nướng nguy&ecirc;n chất gi&ograve;n dai nhai si&ecirc;u th&iacute;ch.</p>\r\n','/media/CloudTea_4.jpg',55000.00,0.00,'',24),(43,'CloudTea Oolong Nướng Kem Dừa Đá Xay','<p>Tr&agrave; sữa đ&aacute; xay - phi&ecirc;n bản n&acirc;ng cấp đầy mới lạ của tr&agrave; sữa truyền thống, lần đầu xuất hiện tại Nh&agrave;. Ngon kh&oacute; cưỡng với lớp kem dừa b&eacute;o ngậy nhưng kh&ocirc;ng ngấy, th&ecirc;m vụn b&aacute;nh quy ph&ocirc; mai gi&ograve;n tan vui miệng. Tr&agrave; Oolong nướng r&otilde; hương đậm vị, quyện với sữa dừa beo b&eacute;o, được xay mịn c&ugrave;ng đ&aacute;, m&aacute;t rượi trong t&iacute;ch tắc. Đặc biệt, thạch Oolong nướng nguy&ecirc;n chất gi&uacute;p giữ trọn vị đậm đ&agrave; của tr&agrave; sữa đến giọt cuối c&ugrave;ng.</p>\r\n','/media/CloudTea_5.jpg',55000.00,0.00,'',24),(44,'CloudFee Hạnh Nhân Nướng','<p>Vị đắng nhẹ từ c&agrave; ph&ecirc; phin truyền thống kết hợp Espresso &Yacute;, lẫn ch&uacute;t ngọt ngào của kem sữa và lớp foam trứng cacao, nhấn th&ecirc;m hạnh nh&acirc;n nướng thơm b&ugrave;i, k&egrave;m topping thạch c&agrave; ph&ecirc; dai gi&ograve;n m&ecirc; ly. Tất cả c&ugrave;ng quyện ho&agrave; trong một thức uống l&agrave;m vị gi&aacute;c &quot;thức giấc&quot;, thơm ngon hết nấc.</p>\r\n','/media/CloudFee_1.jpg',49000.00,0.00,'',25),(45,'CloudFee Caramel','<p>Ngon kh&oacute; cưỡng bởi x&iacute;u đắng nhẹ từ c&agrave; ph&ecirc; phin truyền thống pha tr&ocirc;̣n với Espresso lừng danh nước &Yacute;, quyện vị kem sữa v&agrave; caramel ngọt ngọt, th&ecirc;m lớp foam trứng cacao bồng bềnh b&eacute;o mịn, k&egrave;m topping thạch c&agrave; ph&ecirc; dai gi&ograve;n nhai cực cuốn. Một thức uống &quot;điểm mười&quot; cho cả ng&agrave;y tươi kh&ocirc;ng cần tưới.</p>\r\n','/media/CloudFee_2.jpg',49000.00,0.00,'',25),(46,'CloudFee Hà Nội','<p>Khiến bạn m&ecirc; mẩn ngay ngụm đầu ti&ecirc;n bởi vị đắng nhẹ của c&agrave; ph&ecirc; phin truyền thống kết hợp Espresso &Yacute;, quy&ecirc;̣n hòa cùng ch&uacute;t ngọt ng&agrave;o của kem sữa, và thơm b&eacute;o từ foam trứng cacao. Nhấp một ngụm rồi nhai c&ugrave;ng thạch c&agrave; ph&ecirc; dai dai gi&ograve;n gi&ograve;n, đ&uacute;ng chuẩn &quot;ngon qu&ecirc;n lối về&quot;. CloudFee Classic l&agrave; m&oacute;n đậm vị c&agrave; ph&ecirc; nhất trong bộ sưu tập nhưng kh&ocirc;ng qu&aacute; đắng, ngậy nhưng kh&ocirc;ng hề ngấy.</p>\r\n','/media/CloudFee_3.jpg',49000.00,0.00,'',25),(47,'CloudTea Oolong Berry','<p>Cắn một c&aacute;i, chua chua ngọt ngọt ngon đến từng tế b&agrave;o với chiếc Mochi Kem Ph&uacute;c Bồn Tử! H&uacute;t một ngụm, m&ecirc; lu&ocirc;n Tr&agrave; Oolong Sữa dịu &ecirc;m quyện vị d&acirc;u, c&ugrave;ng lớp foam ph&ocirc; mai phủ vụn b&aacute;nh quy ph&ocirc; mai mằn mặn. M&oacute;n kh&ocirc;ng thể thiếu đ&aacute;, để ngoại h&igrave;nh v&agrave; chất lượng được đảm bảo.</p>\r\n','/media/CloudTea_Mochi_1.jpg',69000.00,0.00,'',26),(48,'CloudTea Trà Xanh Tây Bắc','<p>Kh&ocirc;ng thể rời m&ocirc;i với Mochi Kem Matcha dẻo mịn, n&uacute;ng n&iacute;nh. Tr&agrave; Xanh T&acirc;y Bắc vị mộc ho&agrave; quyện sữa tươi, foam ph&ocirc; mai beo b&eacute;o v&agrave; vụn b&aacute;nh quy gi&ograve;n tan, l&agrave; lựa chọn đậm kh&ocirc;ng kh&iacute; lễ hội. M&oacute;n kh&ocirc;ng thể thiếu đ&aacute;, để ngoại h&igrave;nh v&agrave; chất lượng được đảm bảo.</p>\r\n','/media/CloudTea_Mochi_2.jpg',69000.00,0.00,'',26),(49,'Hi Tea Yuzu Kombucha','<p>Tr&agrave; hoa Hibiscus 0% caffeine thanh m&aacute;t, h&ograve;a quyện c&ugrave;ng tr&agrave; l&ecirc;n men Kombucha 100% tự nhi&ecirc;n v&agrave; mứt Yuzu Marmalade (qu&yacute;t Nhật) mang đến hương vị chua chua lạ miệng. Đặc biệt, Hi-Tea Yuzu Kombucha cực hợp cho team th&iacute;ch detox, muốn s&aacute;ng da nhờ Kombucha Detox nhiều chất chống oxy ho&aacute; c&ugrave;ng Yuzu gi&agrave;u vitamin C. Lưu &yacute;: Khuấy đều trước khi d&ugrave;ng</p>\r\n','/media/HiTea_Tra_2.jpg',59000.00,0.00,'',5),(50,'Hi Tea Phúc Bồn Tử Mandarin','<p>Nền tr&agrave; Hibiscus thanh m&aacute;t, quyện vị chua chua ngọt ngọt của ph&uacute;c bồn tử 100% tự nhi&ecirc;n c&ugrave;ng qu&yacute;t mọng nước mang đến cảm gi&aacute;c sảng kho&aacute;i tức th&igrave;.</p>\r\n','/media/HiTea_Tra_3.jpg',49000.00,0.00,'',5),(51,'Hi Tea Yuzu Trân Châu','<p>Kh&ocirc;ng chỉ nổi bật với sắc đỏ đặc trưng từ tr&agrave; hoa Hibiscus, Hi-Tea Yuzu c&ograve;n g&acirc;y ấn tượng với topping Yuzu (qu&yacute;t Nhật) lạ miệng, kết hợp c&ugrave;ng tr&acirc;n ch&acirc;u trắng dai gi&ograve;n sần sật, nhai vui vui.</p>\r\n','/media/HiTea_Tra_4.jpg',49000.00,0.00,'',5),(52,'Hi Tea Vải','<p>Ch&uacute;t ngọt ng&agrave;o của Vải, mix c&ugrave;ng vị chua thanh tao từ tr&agrave; hoa Hibiscus, mang đến cho bạn thức uống đ&uacute;ng chuẩn vừa ngon, vừa healthy.</p>\r\n','/media/HiTea_Tra_5.jpg',49000.00,0.00,'',5),(53,'Hi Tea Đào','<p>Sự kết hợp ăn &yacute; giữa Đ&agrave;o c&ugrave;ng tr&agrave; hoa Hibiscus, tạo n&ecirc;n tổng thể h&agrave;i ho&agrave; dễ g&acirc;y &ldquo;thương nhớ&rdquo; cho team th&iacute;ch m&oacute;n thanh m&aacute;t, c&oacute; vị chua nhẹ.</p>\r\n','/media/HiTea_Tra_6.jpg',49000.00,0.00,'',5),(54,'Frosty Trà Xanh','<p>Đ&aacute; Xay Frosty Tr&agrave; Xanh như lời mời mộc mạc, gh&eacute; thăm T&acirc;y Bắc v&agrave;o những ng&agrave;y tiết trời se lạnh, n&uacute;i đ&egrave;o m&acirc;y phủ. Vị ch&aacute;t dịu, ngọt thanh của tr&agrave; xanh T&acirc;y Bắc kết hợp đ&aacute; xay s&aacute;nh mịn, whipping cream bồng bềnh v&agrave; bột tr&agrave; xanh tr&ecirc;n c&ugrave;ng th&ecirc;m đậm vị. Đ&acirc;y kh&ocirc;ng chỉ l&agrave; thức uống m&aacute;t lạnh bật mood, m&agrave; c&ograve;n tốt cho sức khoẻ nhờ gi&agrave;u vitamin v&agrave; c&aacute;c chất chống oxy ho&aacute;.</p>\r\n','/media/Traxanh_TB_4.jpg',59000.00,0.00,'',28),(55,'Frosty Caramel Arabica','<p>Caramel ngọt thơm quyện c&ugrave;ng c&agrave; ph&ecirc; Arabica Cầu Đất đượm hương gỗ th&ocirc;ng, hạt dẻ v&agrave; nốt s&ocirc; c&ocirc; la đặc trưng tạo n&ecirc;n Đ&aacute; Xay Frosty Caramel Arabica độc đ&aacute;o chỉ c&oacute; tại Nh&agrave;. Cực cuốn với lớp whipping cream b&eacute;o mịn, th&ecirc;m thạch c&agrave; ph&ecirc; gi&ograve;n ngon bắt miệng.</p>\r\n','/media/Frosty3.jpg',59000.00,0.00,'',30),(56,'Frosty Bánh Kem Dâu','<p>Bồng bềnh như một đ&aacute;m m&acirc;y, Đ&aacute; Xay Frosty B&aacute;nh Kem D&acirc;u vừa ngon mắt vừa chiều vị gi&aacute;c bằng sự ngọt ng&agrave;o. Bắt đầu bằng c&aacute;i chạm m&ocirc;i với lớp kem whipping cream, cảm nhận ngay vị beo b&eacute;o lẫn sốt d&acirc;u thơm lừng. Sau đ&oacute;, h&uacute;t một ngụm l&agrave; cuốn kh&oacute; cưỡng bởi đ&aacute; xay m&aacute;t lạnh quyện c&ugrave;ng sốt d&acirc;u ngọt dịu. Lưu &yacute;: Khuấy đều phần đ&aacute; xay trước khi d&ugrave;ng</p>\r\n','/media/Frosty4.jpg',59000.00,0.00,'',30),(57,'Frosty Choco Chip','<p>Đ&aacute; Xay Frosty Choco Chip, thử l&agrave; đ&atilde;! Lớp whipping cream bồng bềnh, beo b&eacute;o lại c&oacute; th&ecirc;m bột s&ocirc; c&ocirc; la v&agrave; s&ocirc; c&ocirc; la chip tr&ecirc;n c&ugrave;ng. Gấp đ&ocirc;i vị ngon với s&ocirc; c&ocirc; la thật xay với đ&aacute; s&aacute;nh mịn, đậm đ&agrave; đến tận ngụm cuối c&ugrave;ng.</p>\r\n','/media/Frosty5.jpg',59000.00,0.00,'',30),(58,'Bánh Mì Que Pate','<p>Vỏ b&aacute;nh m&igrave; gi&ograve;n tan, kết hợp với lớp nh&acirc;n pate b&eacute;o b&eacute;o đậm đ&agrave; sẽ l&agrave; lựa chọn l&yacute; tưởng nhẹ nh&agrave;ng để lấp đầy chiếc bụng đ&oacute;i , cho 1 bữa s&aacute;ng - trưa - chiều - tối của bạn th&ecirc;m phần th&uacute; vị.</p>\r\n','/media/banhman3.jpg',15000.00,0.00,'',14),(59,'Bánh Mì Que Pate Cay','<p>Vỏ b&aacute;nh m&igrave; gi&ograve;n tan, kết hợp với lớp nh&acirc;n pate b&eacute;o b&eacute;o đậm đ&agrave; v&agrave; 1 ch&uacute;t cay cay sẽ l&agrave; lựa chọn l&yacute; tưởng nhẹ nh&agrave;ng để lấp đầy chiếc bụng đ&oacute;i , cho 1 bữa s&aacute;ng - trưa - chiều - tối của bạn th&ecirc;m phần th&uacute; vị.</p>\r\n','/media/banhman4.jpg',15000.00,0.00,'',14),(60,'Bánh Mì VN Thịt Nguội','<p>G&oacute;i gọn trong ổ b&aacute;nh m&igrave; Việt Nam l&agrave; từng lớp chả, từng lớp jambon h&ograve;a quyện c&ugrave;ng bơ v&agrave; pate thơm lừng, th&ecirc;m dưa rau cho bữa s&aacute;ng đầy năng lượng. *Phần b&aacute;nh sẽ ngon v&agrave; đậm đ&agrave; nhất khi k&egrave;m pate. Để đảm bảo hương vị được trọn vẹn, Nh&agrave; mong bạn th&ocirc;ng cảm v&igrave; kh&ocirc;ng thể thay đổi định lượng pate.</p>\r\n','/media/banhman5.jpg',39000.00,0.00,'',14),(61,'Croissant trứng muối','<p>Croissant trứng muối thơm lừng, b&ecirc;n ngo&agrave;i vỏ b&aacute;nh gi&ograve;n hấp dẫn b&ecirc;n trong trứng muối vị ngon kh&oacute; cưỡng.</p>\r\n','/media/banhman6.jpg',39000.00,0.00,'',14),(62,'Butter Croissant Sữa Đặc','<p>B&aacute;nh Butter Croissant bạn đ&atilde; y&ecirc;u, nay y&ecirc;u kh&ocirc;ng lối tho&aacute;t khi được chấm c&ugrave;ng sữa đặc. Thơm bơ mịn sữa, ngọt ng&agrave;o l&ograve;ng nhau!</p>\r\n','/media/banhman7.jpg',35000.00,0.00,'',14),(63,'Butter Croissant Kem Trứng Choco','<p>Hấp dẫn hơn cả b&aacute;nh Butter Croissant? Ch&iacute;nh l&agrave; b&aacute;nh Butter Croissant phủ lớp kem trứng thơm mịn. Th&ecirc;m ngọt ng&agrave;o với bột s&ocirc; c&ocirc; la, chứng nhận &ldquo;mlem trọn đời&rdquo;!</p>\r\n','/media/banhman8.jpg',49000.00,0.00,'',14),(64,'Chà Bông Phô Mai','<p>Chiếc b&aacute;nh với lớp ph&ocirc; mai v&agrave;ng s&aacute;nh mịn b&ecirc;n trong, được bọc ngo&agrave;i lớp vỏ xốp mềm thơm lừng. Th&ecirc;m lớp ch&agrave; b&ocirc;ng mằn mặn hấp dẫn b&ecirc;n tr&ecirc;n.</p>\r\n','/media/banhman9.jpg',39000.00,0.00,'',14),(65,'Mochi Kem Việt Quất','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n việt quất đặc trưng thơm thơm, ngọt dịu. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot2.jpg',19000.00,0.00,'',15),(66,'Mochi Kem Dừa Dứa','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n dừa dứa thơm lừng lạ miệng. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot3.jpg',19000.00,0.00,'',15),(67,'Mochi Kem Chocolate','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n chocolate độc đ&aacute;o. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot4.jpg',19000.00,0.00,'',15),(68,'Mochi Kem Matcha','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n tr&agrave; xanh đậm vị. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot5.jpg',19000.00,0.00,'',15),(69,'Mochi Kem Xoài','<p>Bao bọc bởi lớp vỏ Mochi dẻo thơm, b&ecirc;n trong l&agrave; lớp kem lạnh c&ugrave;ng nh&acirc;n xo&agrave;i chua chua ngọt ngọt. Gọi 1 chiếc Mochi cho ng&agrave;y thật tươi m&aacute;t. Sản phẩm phải bảo qu&aacute;n m&aacute;t v&agrave; d&ugrave;ng ngon nhất trong 2h sau khi nhận h&agrave;ng.</p>\r\n','/media/banhngot6.jpg',19000.00,0.00,'',15),(70,'Mousse Red Velvet','<p>B&aacute;nh nhiều lớp được phủ lớp kem b&ecirc;n tr&ecirc;n bằng Cream cheese.</p>\r\n','/media/banhngot7.jpg',35000.00,0.00,'',15),(71,'Mousse Tiramisu','<p>Hương vị dễ ghiền được tạo n&ecirc;n bởi ch&uacute;t đắng nhẹ của c&agrave; ph&ecirc;, lớp kem trứng b&eacute;o ngọt dịu hấp dẫn</p>\r\n','/media/banhngot8.jpg',35000.00,0.00,'',15),(72,'Mousse Gấu Chocolate','<p>Với vẻ ngo&agrave;i đ&aacute;ng y&ecirc;u v&agrave; hương vị ngọt ng&agrave;o, thơm b&eacute;o nhất định bạn phải thử &iacute;t nhất 1 lần.</p>\r\n','/media/banhngot9.jpg',39000.00,0.00,'',15),(73,'Mít Sấy','<p>M&iacute;t sấy kh&ocirc; v&agrave;ng ươm, gi&ograve;n rụm, giữ nguy&ecirc;n được vị ngọt lịm của m&iacute;t tươi.</p>\r\n','/media/Snack1.jpg',20000.00,0.00,'',16),(74,'Gà Xé Lá Chanh','<p>Thịt g&agrave; được x&eacute; tơi, mang hương vị mặn, ngọt, cay cay quyện nhau vừa chuẩn, th&ecirc;m ch&uacute;t thơm thơm thơm từ l&aacute; chanh sấy kh&ocirc; gi&ograve;n gi&ograve;n xua tan ngay cơn buồn miệng.</p>\r\n','/media/Snack2.jpg',25000.00,0.00,'',16),(75,'Butter Croissant','<p>Cắn một miếng, vỏ b&aacute;nh ng&agrave;n lớp gi&ograve;n thơm bơ b&eacute;o, rồi mịn tan trong miệng. Cực d&iacute;nh khi nh&acirc;m nhi Butter Croissant với c&agrave; ph&ecirc; hoặc chấm c&ugrave;ng c&aacute;c m&oacute;n nước c&oacute; foam trứng của Nh&agrave;</p>\r\n','/media/banh_Pastry1.jpg',29000.00,0.00,'',17),(76,'Choco Croffle','<p>Lạ mắt, bắt vị với chiếc b&aacute;nh Croffle được l&agrave;m từ cốt b&aacute;nh Croissant nướng trong khu&ocirc;n Waffle tổ ong. Trong mềm mịn, ngo&agrave;i gi&ograve;n thơm, th&ecirc;m topping s&ocirc; c&ocirc; la tan chảy, ăn l&agrave; y&ecirc;u!</p>\r\n','/media/banh_Pastry2.jpg',39000.00,0.00,'',17),(77,'Pate Chaud','<p>Ngon nức l&ograve;ng c&ugrave;ng nh&acirc;n pat&ecirc; v&agrave; thịt heo cuộn m&igrave;nh trong vỏ b&aacute;nh ng&agrave;n lớp thơm bơ, gi&ograve;n rụm.</p>\r\n','/media/banh_Pastry3.jpg',39000.00,0.00,'',17),(78,'Cà Phê Đen Đá Hộp (14 gói x 16g)','<p>C&agrave; Ph&ecirc; Đen Đ&aacute; ho&agrave; tan The Coffee House với 100% hạt c&agrave; ph&ecirc; Robusta mang đến hương vị mạnh cực bốc, đậm đắng đầy l&ocirc;i cuốn, đ&uacute;ng gu người Việt.</p>\r\n','/media/Caphe_tainha_1.jpg',58000.00,0.00,'',31),(79,'Cà Phê Đen Đá Túi (30 gói x 16g)','<p>C&agrave; Ph&ecirc; Đen Đ&aacute; ho&agrave; tan The Coffee House với 100% hạt c&agrave; ph&ecirc; Robusta mang đến hương vị mạnh cực bốc, đậm đắng đầy l&ocirc;i cuốn, đ&uacute;ng gu người Việt.</p>\r\n','/media/Caphe_tainha_2.jpg',110000.00,0.00,'',31),(80,'Thùng Cà Phê Sữa Espresso','<p>Được sản xuất theo c&ocirc;ng nghệ Nhật, C&agrave; Ph&ecirc; Sữa Espresso The Coffee House giữ trọn hương vị đậm đ&agrave; của 100% c&agrave; ph&ecirc; Robusta nguy&ecirc;n chất quyện ho&agrave; c&ugrave;ng sữa b&eacute;o thơm lừng. Bật nắp trải nghiệm ngay chất c&agrave; ph&ecirc; mạnh mẽ gi&uacute;p sảng kho&aacute;i tức th&igrave;, tu&ocirc;n tr&agrave;o hứng khởi</p>\r\n','/media/Caphe_tainha_3.jpg',336000.00,0.00,'',31),(81,'Combo 6 Lon Cà Phê Sữa Espresso','<p>Được sản xuất theo c&ocirc;ng nghệ Nhật, C&agrave; Ph&ecirc; Sữa Espresso The Coffee House giữ trọn hương vị đậm đ&agrave; của 100% c&agrave; ph&ecirc; Robusta nguy&ecirc;n chất quyện ho&agrave; c&ugrave;ng sữa b&eacute;o thơm lừng. Bật nắp trải nghiệm ngay chất c&agrave; ph&ecirc; mạnh mẽ gi&uacute;p sảng kho&aacute;i tức th&igrave;, tu&ocirc;n tr&agrave;o hứng khởi</p>\r\n','/media/Caphe_tainha_4.jpg',84000.00,0.00,'',31),(82,'Cà Phê Rang Xay Original 1 Túi 1KG','<p>C&agrave; ph&ecirc; Original 1 của The Coffee House với 100% th&agrave;nh phần c&agrave; ph&ecirc; Robusta Đăk Lăk, v&ugrave;ng trồng c&agrave; ph&ecirc; ngon nhất Việt Nam. Bằng c&aacute;ch &aacute;p dụng kỹ thuật rang xay hiện đại, C&agrave; ph&ecirc; Original 1 mang đến trải nghiệm tuyệt vời khi uống c&agrave; ph&ecirc; tại nh&agrave; với hương vị đậm đ&agrave; truyền thống hợp khẩu vị của giới trẻ s&agrave;nh c&agrave; ph&ecirc;.</p>\r\n','/media/Caphe_tainha_5.jpg',235000.00,0.00,'',31),(83,'Cà Phê Rang Xay Original 1 250g','<p>C&agrave; ph&ecirc; Original 1 của The Coffee House với th&agrave;nh phần ch&iacute;nh c&agrave; ph&ecirc; Robusta Đắk Lắk, v&ugrave;ng trồng c&agrave; ph&ecirc; nổi tiếng nhất Việt Nam. Bằng c&aacute;ch &aacute;p dụng kỹ thuật rang xay hiện đại, C&agrave; ph&ecirc; Original 1 mang đến trải nghiệm tuyệt vời khi uống c&agrave; ph&ecirc; tại nh&agrave; với hương vị đậm đ&agrave; truyền thống hợp khẩu vị của giới trẻ s&agrave;nh c&agrave; ph&ecirc;.</p>\r\n','/media/Caphe_tainha_6.jpg',60000.00,0.00,'',31),(84,'Cà Phê Sữa Đá Hòa Tan (10 gói x 22g)','<p>Thật dễ d&agrave;ng để bắt đầu ng&agrave;y mới với t&aacute;ch c&agrave; ph&ecirc; sữa đ&aacute; s&oacute;ng s&aacute;nh, thơm ngon như c&agrave; ph&ecirc; pha phin. Vị đắng thanh của c&agrave; ph&ecirc; ho&agrave; quyện với vị ngọt b&eacute;o của sữa, gi&uacute;p bạn lu&ocirc;n tỉnh t&aacute;o v&agrave; hứng khởi cho ng&agrave;y l&agrave;m việc thật hiệu quả.</p>\r\n','/media/Caphe_tainha_7.jpg',44000.00,0.00,'',31),(85,'Cà Phê Sữa Đá Hòa Tan Túi 25x22G','<p>Thật dễ d&agrave;ng để bắt đầu ng&agrave;y mới với t&aacute;ch c&agrave; ph&ecirc; sữa đ&aacute; s&oacute;ng s&aacute;nh, thơm ngon như c&agrave; ph&ecirc; pha phin. Vị đắng thanh của c&agrave; ph&ecirc; ho&agrave; quyện với vị ngọt b&eacute;o của sữa, gi&uacute;p bạn lu&ocirc;n tỉnh t&aacute;o v&agrave; hứng khởi cho ng&agrave;y l&agrave;m việc thật hiệu quả.</p>\r\n','/media/Caphe_tainha_8.jpg',99000.00,0.00,'',31),(86,'Cà Phê Hoà Tan Đậm Vị Việt (18 gói x 16 gam)','<p>Bắt đầu ng&agrave;y mới với t&aacute;ch c&agrave; ph&ecirc; sữa &ldquo;Đậm vị Việt&rdquo; mạnh mẽ sẽ gi&uacute;p bạn lu&ocirc;n tỉnh t&aacute;o v&agrave; hứng khởi cho ng&agrave;y l&agrave;m việc thật hiệu quả.</p>\r\n','/media/Caphe_tainha_9.jpg',48000.00,0.00,'',31),(87,'Cà Phê Hòa Tan Đậm Vị Việt Túi 40x16G','<p>Bắt đầu ng&agrave;y mới với t&aacute;ch c&agrave; ph&ecirc; sữa &ldquo;Đậm vị Việt&rdquo; mạnh mẽ sẽ gi&uacute;p bạn lu&ocirc;n tỉnh t&aacute;o v&agrave; hứng khởi cho ng&agrave;y l&agrave;m việc thật hiệu quả.</p>\r\n','/media/Caphe_tainha_10.jpg',99000.00,0.00,'',31),(88,'Cà Phê Sữa Đá Pack 6 Lon','<p>Với thiết kế lon cao trẻ trung, hiện đại v&agrave; tiện lợi, C&agrave; ph&ecirc; sữa đ&aacute; lon thơm ngon đậm vị của The Coffee House sẽ đồng h&agrave;nh c&ugrave;ng nhịp sống s&ocirc;i nổi của tuổi trẻ v&agrave; gi&uacute;p bạn c&oacute; được một ng&agrave;y l&agrave;m việc đầy hứng khởi.</p>\r\n','/media/Caphe_tainha_11.jpg',84000.00,0.00,'',31),(89,'Thùng 24 Lon Cà Phê Sữa Đá','<p>Với thiết kế lon cao trẻ trung, hiện đại v&agrave; tiện lợi, C&agrave; ph&ecirc; sữa đ&aacute; lon thơm ngon đậm vị của The Coffee House sẽ đồng h&agrave;nh c&ugrave;ng nhịp sống s&ocirc;i nổi của tuổi trẻ v&agrave; gi&uacute;p bạn c&oacute; được một ng&agrave;y l&agrave;m việc đầy hứng khởi.</p>\r\n','/media/Caphe_tainha_12.jpg',336000.00,0.00,'',31),(90,'Trà Xanh Espresso Marble','<p>Cho ng&agrave;y th&ecirc;m tươi, tỉnh, &ecirc;m, mượt với Tr&agrave; Xanh Espresso Marble. Đ&acirc;y l&agrave; sự mai mối bất ngờ giữa tr&agrave; xanh T&acirc;y Bắc vị mộc v&agrave; c&agrave; ph&ecirc; Arabica Đ&agrave; Lạt. Muốn ng&agrave;y th&ecirc;m ch&uacute;t highlight, nhớ t&igrave;m đến sự bất ngờ n&agrave;y bạn nh&eacute;!</p>\r\n','/media/Caphe_Highlight2.jpg',49000.00,0.00,'',18),(91,'The Coffee House Sữa Đá','<p>Thức uống gi&uacute;p tỉnh t&aacute;o tức th&igrave; để bắt đầu ng&agrave;y mới thật hứng khởi. Kh&ocirc;ng đắng kh&eacute;t như c&agrave; ph&ecirc; truyền thống, The Coffee House Sữa Đ&aacute; mang hương vị h&agrave;i ho&agrave; đầy l&ocirc;i cuốn. L&agrave; sự đậm đ&agrave; của 100% c&agrave; ph&ecirc; Arabica Cầu Đất rang vừa tới, biến tấu tinh tế với sữa đặc v&agrave; kem sữa ngọt ng&agrave;o cực quyến rũ. C&agrave;ng hấp dẫn hơn với topping thạch 100% c&agrave; ph&ecirc; nguy&ecirc;n chất gi&uacute;p giữ trọn vị ngon đến ngụm cuối c&ugrave;ng.</p>\r\n','/media/Caphe_VN2.jpg',39000.00,0.00,'',19),(92,'Cà Phê Sữa Đá','<p>C&agrave; ph&ecirc; Đắk Lắk nguy&ecirc;n chất được pha phin truyền thống kết hợp với sữa đặc tạo n&ecirc;n hương vị đậm đ&agrave;, h&agrave;i h&ograve;a giữa vị ngọt đầu lưỡi v&agrave; vị đắng thanh tho&aacute;t nơi hậu vị.</p>\r\n','/media/Caphe_VN3.jpg',29000.00,0.00,'',19),(93,'Cà Phê Sữa Nóng','<p>C&agrave; ph&ecirc; được pha phin truyền thống kết hợp với sữa đặc tạo n&ecirc;n hương vị đậm đ&agrave;, h&agrave;i h&ograve;a giữa vị ngọt đầu lưỡi v&agrave; vị đắng thanh tho&aacute;t nơi hậu vị.</p>\r\n','/media/Caphe_VN4.jpg',39000.00,0.00,'',19),(94,'Bạc Sỉu','<p>Bạc sỉu ch&iacute;nh l&agrave; &quot;Ly sữa trắng k&egrave;m một ch&uacute;t c&agrave; ph&ecirc;&quot;. Thức uống n&agrave;y rất ph&ugrave; hợp những ai vừa muốn trải nghiệm ch&uacute;t vị đắng của c&agrave; ph&ecirc; vừa muốn thưởng thức vị ngọt b&eacute;o ngậy từ sữa.</p>\r\n','/media/Caphe_VN5.jpg',29000.00,0.00,'',19),(95,'Bạc Sỉu Nóng','<p>Bạc sỉu ch&iacute;nh l&agrave; &quot;Ly sữa trắng k&egrave;m một ch&uacute;t c&agrave; ph&ecirc;&quot;. Thức uống n&agrave;y rất ph&ugrave; hợp những ai vừa muốn trải nghiệm ch&uacute;t vị đắng của c&agrave; ph&ecirc; vừa muốn thưởng thức vị ngọt b&eacute;o ngậy từ sữa.</p>\r\n','/media/Caphe_VN6.jpg',39000.00,0.00,'',19),(96,'Cà Phê Đen Đá','<p>Kh&ocirc;ng ngọt ng&agrave;o như Bạc sỉu hay C&agrave; ph&ecirc; sữa, C&agrave; ph&ecirc; đen mang trong m&igrave;nh phong vị trầm lắng, thi vị hơn. Người ta thường phải ngồi rất l&acirc;u mới cảm nhận được hết hương thơm ng&agrave;o ngạt, phảng phất m&ugrave;i cacao v&agrave; c&aacute;i đắng mượt m&agrave; tr&ocirc;i tuột xuống v&ograve;m họng.</p>\r\n','/media/Caphe_VN7.jpg',29000.00,0.00,'',19),(97,'Cà Phê Đen Nóng','<p>Kh&ocirc;ng ngọt ng&agrave;o như Bạc sỉu hay C&agrave; ph&ecirc; sữa, C&agrave; ph&ecirc; đen mang trong m&igrave;nh phong vị trầm lắng, thi vị hơn. Người ta thường phải ngồi rất l&acirc;u mới cảm nhận được hết hương thơm ng&agrave;o ngạt, phảng phất m&ugrave;i cacao v&agrave; c&aacute;i đắng mượt m&agrave; tr&ocirc;i tuột xuống v&ograve;m họng.</p>\r\n','/media/Caphe_VN8.jpg',39000.00,0.00,'',19),(98,'Cà Phê Sữa Đá Chai Fresh 250ML','<p>Vẫn l&agrave; hương vị c&agrave; ph&ecirc; sữa đậm đ&agrave; quen thuộc của The Coffee House nhưng kho&aacute;c l&ecirc;n m&igrave;nh một chiếc &aacute;o mới tiện lợi hơn, tiết kiệm hơn ph&ugrave; hợp với b&igrave;nh thường mới, gi&uacute;p bạn tận hưởng một ng&agrave;y d&agrave;i trọn vẹn. *Sản phẩm d&ugrave;ng ngon nhất trong ng&agrave;y. *Sản phẩm mặc định mức đường v&agrave; kh&ocirc;ng đ&aacute;.</p>\r\n','/media/Caphe_VN9.jpg',75000.00,0.00,'',19),(99,'Caramel Macchiato Đá','<p>Khuấy đều trước khi sử dụng Caramel Macchiato sẽ mang đến một sự ngạc nhi&ecirc;n th&uacute; vị khi vị thơm b&eacute;o của bọt sữa, sữa tươi, vị đắng thanh tho&aacute;t của c&agrave; ph&ecirc; Espresso hảo hạng v&agrave; vị ngọt đậm của sốt caramel được g&oacute;i gọn trong một t&aacute;ch c&agrave; ph&ecirc;.</p>\r\n','/media/Caphe_May_2.jpg',55000.00,0.00,'',20),(100,'Caramel Macchiato Nóng','<p>Caramel Macchiato sẽ mang đến một sự ngạc nhi&ecirc;n th&uacute; vị khi vị thơm b&eacute;o của bọt sữa, sữa tươi, vị đắng thanh tho&aacute;t của c&agrave; ph&ecirc; Espresso hảo hạng v&agrave; vị ngọt đậm của sốt caramel được g&oacute;i gọn trong một t&aacute;ch c&agrave; ph&ecirc;.</p>\r\n','/media/Caphe_May_3.jpg',55000.00,0.00,'',20),(101,'Latte Đá','<p>Một sự kết hợp tinh tế giữa vị đắng c&agrave; ph&ecirc; Espresso nguy&ecirc;n chất h&ograve;a quyện c&ugrave;ng vị sữa n&oacute;ng ngọt ng&agrave;o, b&ecirc;n tr&ecirc;n l&agrave; một lớp kem mỏng nhẹ tạo n&ecirc;n một t&aacute;ch c&agrave; ph&ecirc; ho&agrave;n hảo về hương vị lẫn nh&atilde;n quan.</p>\r\n','/media/Caphe_May_4.jpg',55000.00,0.00,'',20),(102,'Latte Nóng','<p>Một sự kết hợp tinh tế giữa vị đắng c&agrave; ph&ecirc; Espresso nguy&ecirc;n chất h&ograve;a quyện c&ugrave;ng vị sữa n&oacute;ng ngọt ng&agrave;o, b&ecirc;n tr&ecirc;n l&agrave; một lớp kem mỏng nhẹ tạo n&ecirc;n một t&aacute;ch c&agrave; ph&ecirc; ho&agrave;n hảo về hương vị lẫn nh&atilde;n quan.</p>\r\n','/media/Caphe_May_5.jpg',55000.00,0.00,'',20),(103,'Americano Đá','<p>Americano được pha chế bằng c&aacute;ch pha th&ecirc;m nước với tỷ lệ nhất định v&agrave;o t&aacute;ch c&agrave; ph&ecirc; Espresso, từ đ&oacute; mang lại hương vị nhẹ nh&agrave;ng v&agrave; giữ trọn được m&ugrave;i hương c&agrave; ph&ecirc; đặc trưng.</p>\r\n','/media/Caphe_May_6.jpg',45000.00,0.00,'',20),(104,'Americano Nóng','<p>Americano được pha chế bằng c&aacute;ch pha th&ecirc;m nước với tỷ lệ nhất định v&agrave;o t&aacute;ch c&agrave; ph&ecirc; Espresso, từ đ&oacute; mang lại hương vị nhẹ nh&agrave;ng v&agrave; giữ trọn được m&ugrave;i hương c&agrave; ph&ecirc; đặc trưng.</p>\r\n','/media/Caphe_May_7.jpg',45000.00,0.00,'',20),(105,'Cappuccino Đá','<p>Capuchino l&agrave; thức uống h&ograve;a quyện giữa hương thơm của sữa, vị b&eacute;o của bọt kem c&ugrave;ng vị đậm đ&agrave; từ c&agrave; ph&ecirc; Espresso. Tất cả tạo n&ecirc;n một hương vị đặc biệt, một ch&uacute;t nhẹ nh&agrave;ng, trầm lắng v&agrave; tinh tế.</p>\r\n','/media/Caphe_May_8.jpg',55000.00,0.00,'',20),(106,'Cappuccino Nóng','<p>Capuchino l&agrave; thức uống h&ograve;a quyện giữa hương thơm của sữa, vị b&eacute;o của bọt kem c&ugrave;ng vị đậm đ&agrave; từ c&agrave; ph&ecirc; Espresso. Tất cả tạo n&ecirc;n một hương vị đặc biệt, một ch&uacute;t nhẹ nh&agrave;ng, trầm lắng v&agrave; tinh tế.</p>\r\n','/media/Caphe_May_9.jpg',55000.00,0.00,'',20),(107,'Espresso Đá','<p>Một t&aacute;ch Espresso nguy&ecirc;n bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ c&acirc;n đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu v&agrave; s&aacute;nh đặc.</p>\r\n','/media/Caphe_May_10.jpg',49000.00,0.00,'',20),(108,'Espresso Nóng','<p>Một t&aacute;ch Espresso nguy&ecirc;n bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ c&acirc;n đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu v&agrave; s&aacute;nh đặc.</p>\r\n','/media/Caphe_May_11.jpg',45000.00,0.00,'',20),(109,'Cold Brew Sữa Tươi','<p>Thanh m&aacute;t v&agrave; c&acirc;n bằng với hương vị c&agrave; ph&ecirc; nguy&ecirc;n bản 100% Arabica Cầu Đất c&ugrave;ng sữa tươi thơm b&eacute;o cho từng ngụm tr&ograve;n vị, hấp dẫn.</p>\r\n','/media/ColdBrew_2.jpg',49000.00,0.00,'',21),(110,'Cold Brew Truyền Thống','<p>Tại The Coffee House, Cold Brew được ủ v&agrave; phục vụ mỗi ng&agrave;y từ 100% hạt Arabica Cầu Đất với hương gỗ th&ocirc;ng, hạt dẻ, nốt s&ocirc;-c&ocirc;-la đặc trưng, thoang thoảng hương kh&oacute;i nhẹ gi&uacute;p Cold Brew giữ nguy&ecirc;n vị tươi mới.</p>\r\n','/media/ColdBrew_3.jpg',45000.00,0.00,'',21);
/*!40000 ALTER TABLE `cms_product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_productorder`
--

DROP TABLE IF EXISTS `cms_productorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_productorder` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `quantity` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `order_id` bigint NOT NULL,
  `product_id` bigint NOT NULL,
  `size` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cms_productorder_order_id_14e61cc3_fk_cms_order_id` (`order_id`),
  KEY `cms_productorder_product_id_cb962aae_fk_cms_product_id` (`product_id`),
  CONSTRAINT `cms_productorder_order_id_14e61cc3_fk_cms_order_id` FOREIGN KEY (`order_id`) REFERENCES `cms_order` (`id`),
  CONSTRAINT `cms_productorder_product_id_cb962aae_fk_cms_product_id` FOREIGN KEY (`product_id`) REFERENCES `cms_product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_productorder`
--

LOCK TABLES `cms_productorder` WRITE;
/*!40000 ALTER TABLE `cms_productorder` DISABLE KEYS */;
INSERT INTO `cms_productorder` VALUES (1,'1',6,7,'Vừa','Xỉu'),(2,'1',7,8,'Vừa','Bánh Mì VN Thịt Nguội'),(3,'1',8,7,'Vừa','Bạc Sỉu'),(4,'1',9,8,'Vừa','Bánh Mì VN Thịt Nguội'),(5,'1',9,15,'Vừa','Trà Sữa Trân Châu Tearoma 250g'),(6,'1',9,1,'Vừa','Bánh Mì Gậy Cá Ngừ Mayo'),(7,'1',10,10,'Vừa','Hi Tea Vải'),(8,'1',10,9,'Vừa','Mochi Kem Chocolate'),(9,'1',10,20,'Vừa','Đường Đen Marble Latte'),(10,'1',10,8,'Vừa','Bánh Mì VN Thịt Nguội'),(11,'2',11,1,'Vừa','Bánh Mì Gậy Cá Ngừ Mayo'),(12,'1',12,10,'Vừa','Hi Tea Vải'),(13,'1',13,12,'Vừa','Hồng Trà Sữa Trân Châu'),(14,'4',14,1,'Vừa','Bánh Mì Gậy Cá Ngừ Mayo'),(15,'1',15,7,'Vừa','Bạc Sỉu'),(16,'1',16,9,'Vừa','Mochi Kem Chocolate');
/*!40000 ALTER TABLE `cms_productorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_sanphamsize`
--

DROP TABLE IF EXISTS `cms_sanphamsize`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_sanphamsize` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `price` decimal(10,2) NOT NULL,
  `product_id` bigint NOT NULL,
  `size_id` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cms_sanphamsize_product_id_190008b7` (`product_id`),
  KEY `cms_sanphamsize_size_id_0e906d4a` (`size_id`),
  CONSTRAINT `cms_sanphamsize_product_id_190008b7_fk_cms_product_id` FOREIGN KEY (`product_id`) REFERENCES `cms_product` (`id`),
  CONSTRAINT `cms_sanphamsize_size_id_0e906d4a_fk_cms_size_id` FOREIGN KEY (`size_id`) REFERENCES `cms_size` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_sanphamsize`
--

LOCK TABLES `cms_sanphamsize` WRITE;
/*!40000 ALTER TABLE `cms_sanphamsize` DISABLE KEYS */;
INSERT INTO `cms_sanphamsize` VALUES (3,22000.00,7,1),(4,23000.00,7,2),(5,40000.00,7,3),(6,21000.00,8,1),(7,29000.00,8,2),(8,39000.00,8,3);
/*!40000 ALTER TABLE `cms_sanphamsize` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cms_size`
--

DROP TABLE IF EXISTS `cms_size`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cms_size` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `size_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cms_size`
--

LOCK TABLES `cms_size` WRITE;
/*!40000 ALTER TABLE `cms_size` DISABLE KEYS */;
INSERT INTO `cms_size` VALUES (1,'Nhỏ'),(2,'Vừa'),(3,'Lớn');
/*!40000 ALTER TABLE `cms_size` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `django_admin_log`
--

DROP TABLE IF EXISTS `django_admin_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `django_admin_log` (
  `id` int NOT NULL AUTO_INCREMENT,
  `action_time` datetime(6) NOT NULL,
  `object_id` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `object_repr` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `action_flag` smallint unsigned NOT NULL,
  `change_message` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `content_type_id` int DEFAULT NULL,
  `user_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `django_admin_log_content_type_id_c4bce8eb_fk_django_co` (`content_type_id`),
  KEY `django_admin_log_user_id_c564eba6_fk_auth_user_id` (`user_id`),
  CONSTRAINT `django_admin_log_content_type_id_c4bce8eb_fk_django_co` FOREIGN KEY (`content_type_id`) REFERENCES `django_content_type` (`id`),
  CONSTRAINT `django_admin_log_user_id_c564eba6_fk_auth_user_id` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`),
  CONSTRAINT `django_admin_log_chk_1` CHECK ((`action_flag` >= 0))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `django_admin_log`
--

LOCK TABLES `django_admin_log` WRITE;
/*!40000 ALTER TABLE `django_admin_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `django_admin_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `django_content_type`
--

DROP TABLE IF EXISTS `django_content_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `django_content_type` (
  `id` int NOT NULL AUTO_INCREMENT,
  `app_label` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `model` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `django_content_type_app_label_model_76bd3d3b_uniq` (`app_label`,`model`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `django_content_type`
--

LOCK TABLES `django_content_type` WRITE;
/*!40000 ALTER TABLE `django_content_type` DISABLE KEYS */;
INSERT INTO `django_content_type` VALUES (1,'admin','logentry'),(3,'auth','group'),(2,'auth','permission'),(4,'auth','user'),(7,'cms','account'),(8,'cms','category'),(13,'cms','order'),(10,'cms','product'),(14,'cms','productorder'),(12,'cms','sanphamsize'),(11,'cms','size'),(9,'cms','subcategory'),(5,'contenttypes','contenttype'),(6,'sessions','session');
/*!40000 ALTER TABLE `django_content_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `django_migrations`
--

DROP TABLE IF EXISTS `django_migrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `django_migrations` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `app` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `applied` datetime(6) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `django_migrations`
--

LOCK TABLES `django_migrations` WRITE;
/*!40000 ALTER TABLE `django_migrations` DISABLE KEYS */;
INSERT INTO `django_migrations` VALUES (1,'contenttypes','0001_initial','2023-12-27 16:37:04.950957'),(2,'auth','0001_initial','2023-12-27 16:37:05.084252'),(3,'admin','0001_initial','2023-12-27 16:37:05.117939'),(4,'admin','0002_logentry_remove_auto_add','2023-12-27 16:37:05.120602'),(5,'admin','0003_logentry_add_action_flag_choices','2023-12-27 16:37:05.123076'),(6,'contenttypes','0002_remove_content_type_name','2023-12-27 16:37:05.139853'),(7,'auth','0002_alter_permission_name_max_length','2023-12-27 16:37:05.150461'),(8,'auth','0003_alter_user_email_max_length','2023-12-27 16:37:05.157476'),(9,'auth','0004_alter_user_username_opts','2023-12-27 16:37:05.160102'),(10,'auth','0005_alter_user_last_login_null','2023-12-27 16:37:05.173278'),(11,'auth','0006_require_contenttypes_0002','2023-12-27 16:37:05.173975'),(12,'auth','0007_alter_validators_add_error_messages','2023-12-27 16:37:05.176236'),(13,'auth','0008_alter_user_username_max_length','2023-12-27 16:37:05.187008'),(14,'auth','0009_alter_user_last_name_max_length','2023-12-27 16:37:05.197967'),(15,'auth','0010_alter_group_name_max_length','2023-12-27 16:37:05.203319'),(16,'auth','0011_update_proxy_permissions','2023-12-27 16:37:05.205638'),(17,'auth','0012_alter_user_first_name_max_length','2023-12-27 16:37:05.217442'),(18,'sessions','0001_initial','2023-12-27 16:37:05.226277'),(19,'cms','0001_initial','2023-12-27 17:09:43.832156'),(20,'cms','0002_auto_20231227_1719','2023-12-27 17:19:27.598194'),(21,'cms','0002_account_gender_alter_account_role','2023-12-27 17:21:45.193277'),(22,'cms','0003_account_avatar','2023-12-28 14:10:02.871651'),(23,'cms','0004_category','2023-12-29 08:53:36.018989'),(24,'cms','0005_subcategory_product','2023-12-29 16:44:04.402926'),(25,'cms','0006_alter_product_sub_category_category_parent_category_and_more','2023-12-29 16:59:02.391013'),(26,'cms','0007_rename_sub_category_product_category','2023-12-30 05:06:13.060768'),(27,'cms','0008_size_alter_product_content_sanphamsize','2023-12-30 05:27:08.827040'),(28,'cms','0009_alter_product_category_alter_sanphamsize_product_and_more','2023-12-30 06:26:23.255782'),(29,'cms','0010_order_productorder','2023-12-31 17:09:49.159099'),(30,'cms','0011_remove_order_size_productorder_size','2023-12-31 17:22:11.186970'),(31,'cms','0012_productorder_name','2023-12-31 17:55:37.015657'),(32,'cms','0013_order_created_order_updated','2023-12-31 18:08:54.399356'),(33,'cms','0014_order_paymentstatus_order_paymenttype','2024-01-09 03:52:20.185563'),(34,'cms','0015_order_orderpartnerid','2024-01-09 06:22:07.606730');
/*!40000 ALTER TABLE `django_migrations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `django_session`
--

DROP TABLE IF EXISTS `django_session`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `django_session` (
  `session_key` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `session_data` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `expire_date` datetime(6) NOT NULL,
  PRIMARY KEY (`session_key`),
  KEY `django_session_expire_date_a5c62663` (`expire_date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `django_session`
--

LOCK TABLES `django_session` WRITE;
/*!40000 ALTER TABLE `django_session` DISABLE KEYS */;
INSERT INTO `django_session` VALUES ('lj3qqmkorz6d3ihg0ycgz2mohwgz1trp','.eJxVjEsOwjAMBe-SNYqMk6YJS_Y9Q-TaFimgROpnhbg7VOoCtm9m3stk2taSt0XnPIm5mN6cfreR-KF1B3KnemuWW13nabS7Yg-62KGJPq-H-3dQaCnfmp2iQEIS4DOGPmFUn7xgJx24qAwEOrJw8hRj8MoJPKFiEOeAgnl_AOKXN8c:1rIZ57:VfQXkJRJ_XQpoPnuP3WtAQ6ElKsMEhpuFR6EkXAK1To','2024-01-10 18:56:41.164635'),('vnhwpfy4t3m7ao8srsc2learmcotk8tb','.eJxVjDsOwyAQBe9CHSGz_NYp0_sMCBYITiKQjF1FuXtsyUXSvpl5b-b8tha39bS4ObIrk5Jdfsfg6ZnqQeLD13vj1Oq6zIEfCj9p51OL6XU73b-D4nvZaw3RykwiGYNeW-WjHbKREhShGmBMSQkgRVpEyIgCdwNHETJAIAGGfb7zXjd0:1rNRLg:JgqNhwXoJCBYMZrT1k3cdTF2GaUqfESzJ-S4DhEtFVY','2024-01-24 05:41:56.270964'),('wzul67adp2jm892h5pu9e2rszy31j09d','.eJxVjDsOwyAQBe9CHSGz_NYp0_sMCBYITiKQjF1FuXtsyUXSvpl5b-b8tha39bS4ObIrk5Jdfsfg6ZnqQeLD13vj1Oq6zIEfCj9p51OL6XU73b-D4nvZaw3RykwiGYNeW-WjHbKREhShGmBMSQkgRVpEyIgCdwNHETJAIAGGfb7zXjd0:1rNEWQ:QhPcPPxHp7U3MrdbkH4tjXkQUd5qQoOY8k7p19ek5vI','2024-01-23 16:00:10.552446');
/*!40000 ALTER TABLE `django_session` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-10 15:21:10
