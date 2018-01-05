/*
Navicat MySQL Data Transfer

Source Server         : zhang
Source Server Version : 50528
Source Host           : localhost:3306
Source Database       : godeye

Target Server Type    : MYSQL
Target Server Version : 50528
File Encoding         : 65001

Date: 2018-01-04 01:55:41
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for all_info
-- ----------------------------
DROP TABLE IF EXISTS `all_info`;
CREATE TABLE `all_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_id` int(11) DEFAULT NULL,
  `length` varchar(1000) DEFAULT NULL,
  `protocol` varchar(32) DEFAULT NULL,
  `sourceAddress` varchar(100) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  `data` varchar(1000) DEFAULT NULL,
  `destinationAddress` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of all_info
-- ----------------------------

-- ----------------------------
-- Table structure for behave_info
-- ----------------------------
DROP TABLE IF EXISTS `behave_info`;
CREATE TABLE `behave_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sender` varchar(32) DEFAULT NULL,
  `receiver` varchar(32) DEFAULT NULL,
  `reason` varchar(100) DEFAULT NULL,
  `detailreason` varchar(100) DEFAULT NULL,
  `time` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of behave_info
-- ----------------------------
INSERT INTO `behave_info` VALUES ('1', '192.168.10.82 [8140]', '118.123.203.211 [443]', '购物', '访问淘宝网站', '2017-11-21 11:39:09');
INSERT INTO `behave_info` VALUES ('2', '180.149.131.93 [80]', '192.168.10.82 [8818]', '购物', '访问京东商城', '2017-11-21 11:51:02');
INSERT INTO `behave_info` VALUES ('3', '118.112.22.142 [80]', '10.16.153.163 [3340]', '购物', '访问京东商城', '2017-11-21 15:03:35');
INSERT INTO `behave_info` VALUES ('4', '118.112.22.142 [80]', '10.16.153.163 [3340]', '娱乐', '访问游戏：魔兽世界', '2017-11-21 15:03:35');
INSERT INTO `behave_info` VALUES ('5', '118.112.22.142 [80]', '10.16.153.163 [3340]', '购物', '访问淘宝网站', '2017-11-21 15:03:35');
INSERT INTO `behave_info` VALUES ('6', '118.112.22.142 [80]', '10.16.153.163 [3340]', '娱乐', '访问斗鱼直播平台', '2017-11-21 15:03:35');
INSERT INTO `behave_info` VALUES ('7', '10.16.153.163 [3495]', '118.123.203.211 [443]', '购物', '访问淘宝网站', '2017-11-21 15:05:15');
INSERT INTO `behave_info` VALUES ('8', '10.16.153.163 [14050]', '182.140.245.49 [443]', '购物', '访问淘宝网站', '2018-01-04 01:45:02');
INSERT INTO `behave_info` VALUES ('9', '61.92.24.81 [80]', '10.16.153.163 [14102]', '购物', '访问京东商城', '2018-01-04 01:45:26');

-- ----------------------------
-- Table structure for email_info
-- ----------------------------
DROP TABLE IF EXISTS `email_info`;
CREATE TABLE `email_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sender` varchar(50) DEFAULT NULL,
  `receiver` varchar(50) DEFAULT NULL,
  `senderIP` varchar(30) DEFAULT NULL,
  `caption` varchar(1000) DEFAULT NULL,
  `time` varchar(30) DEFAULT NULL,
  `subject` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of email_info
-- ----------------------------

-- ----------------------------
-- Table structure for qq_info
-- ----------------------------
DROP TABLE IF EXISTS `qq_info`;
CREATE TABLE `qq_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `qqnum` varchar(20) DEFAULT NULL,
  `qqIP` varchar(30) DEFAULT NULL,
  `qqLogin` varchar(100) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of qq_info
-- ----------------------------
INSERT INTO `qq_info` VALUES ('1', '372241146', '192.168.10.82 [4023]', '下线', '2017-11-21 11:35:59');
INSERT INTO `qq_info` VALUES ('2', '372241146', '192.168.10.82 [4027]', '上线', '2017-11-21 11:36:02');
INSERT INTO `qq_info` VALUES ('3', '372241146', '111.30.131.192 [8000]', '上线', '2017-11-21 11:36:02');
INSERT INTO `qq_info` VALUES ('4', '372241146', '192.168.10.82 [4027]', '下线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('5', '372241146', '192.168.10.82 [4008]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('6', '372241146', '111.30.131.184 [8000]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('7', '372241146', '192.168.10.82 [4008]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('8', '372241146', '117.135.170.68 [8000]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('9', '372241146', '192.168.10.82 [4008]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('10', '372241146', '111.30.131.189 [8000]', '上线', '2017-11-21 11:39:09');
INSERT INTO `qq_info` VALUES ('11', '372241146', '192.168.10.82 [4008]', '下线', '2017-11-21 11:40:50');
INSERT INTO `qq_info` VALUES ('12', '372241146', '192.168.10.82 [4012]', '上线', '2017-11-21 11:40:54');
INSERT INTO `qq_info` VALUES ('13', '372241146', '111.30.131.185 [8000]', '上线', '2017-11-21 11:40:54');
INSERT INTO `qq_info` VALUES ('14', '372241146', '192.168.10.82 [4012]', '下线', '2017-11-21 11:42:50');
INSERT INTO `qq_info` VALUES ('15', '372241146', '192.168.10.82 [4004]', '上线', '2017-11-21 11:42:51');
INSERT INTO `qq_info` VALUES ('16', '372241146', '111.30.131.168 [8000]', '上线', '2017-11-21 11:42:51');
INSERT INTO `qq_info` VALUES ('17', '372241146', '192.168.10.82 [4004]', '下线', '2017-11-21 11:43:00');
INSERT INTO `qq_info` VALUES ('18', '372241146', '192.168.10.82 [4006]', '上线', '2017-11-21 11:43:01');
INSERT INTO `qq_info` VALUES ('19', '372241146', '111.30.131.169 [8000]', '上线', '2017-11-21 11:43:01');
INSERT INTO `qq_info` VALUES ('20', '372241146', '192.168.10.82 [4006]', '上线', '2017-11-21 11:43:01');
INSERT INTO `qq_info` VALUES ('21', '372241146', '120.204.17.17 [8000]', '上线', '2017-11-21 11:43:01');
INSERT INTO `qq_info` VALUES ('22', '372241146', '192.168.10.82 [4006]', '下线', '2017-11-21 11:48:11');
INSERT INTO `qq_info` VALUES ('23', '372241146', '192.168.10.82 [4026]', '上线', '2017-11-21 11:48:13');
INSERT INTO `qq_info` VALUES ('24', '372241146', '111.30.131.186 [8000]', '上线', '2017-11-21 11:48:13');
INSERT INTO `qq_info` VALUES ('25', '372241146', '192.168.10.82 [4026]', '上线', '2017-11-21 11:48:13');
INSERT INTO `qq_info` VALUES ('26', '372241146', '120.204.17.17 [8000]', '上线', '2017-11-21 11:48:13');
INSERT INTO `qq_info` VALUES ('27', '372241146', '192.168.10.82 [4026]', '下线', '2017-11-21 11:48:22');
INSERT INTO `qq_info` VALUES ('28', '372241146', '192.168.10.82 [4020]', '上线', '2017-11-21 11:48:23');
INSERT INTO `qq_info` VALUES ('29', '372241146', '111.30.131.190 [8000]', '上线', '2017-11-21 11:48:25');
INSERT INTO `qq_info` VALUES ('30', '372241146', '192.168.10.82 [4020]', '上线', '2017-11-21 11:48:25');
INSERT INTO `qq_info` VALUES ('31', '372241146', '192.168.10.82 [4021]', '上线', '2017-11-21 11:48:26');
INSERT INTO `qq_info` VALUES ('32', '372241146', '117.135.170.69 [8000]', '上线', '2017-11-21 11:48:27');
INSERT INTO `qq_info` VALUES ('33', '372241146', '223.166.151.87 [8000]', '上线', '2017-11-21 11:48:27');
INSERT INTO `qq_info` VALUES ('34', '372241146', '192.168.10.82 [4020]', '下线', '2017-11-21 11:48:41');
INSERT INTO `qq_info` VALUES ('35', '372241146', '192.168.10.82 [4011]', '上线', '2017-11-21 11:48:42');
INSERT INTO `qq_info` VALUES ('36', '372241146', '192.168.10.82 [4012]', '上线', '2017-11-21 11:48:44');
INSERT INTO `qq_info` VALUES ('37', '372241146', '192.168.10.82 [4011]', '上线', '2017-11-21 11:48:44');
INSERT INTO `qq_info` VALUES ('38', '372241146', '192.168.10.82 [4011]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('39', '372241146', '192.168.10.82 [4012]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('40', '372241146', '111.30.131.192 [8000]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('41', '372241146', '61.151.180.143 [8000]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('42', '372241146', '192.168.10.82 [4012]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('43', '372241146', '111.30.131.192 [8000]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('44', '372241146', '61.151.180.143 [8000]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('45', '372241146', '111.30.131.185 [8000]', '上线', '2017-11-21 11:48:47');
INSERT INTO `qq_info` VALUES ('46', '372241146', '10.16.153.163 [4003]', '上线', '2017-11-21 15:03:34');
INSERT INTO `qq_info` VALUES ('47', '372241146', '111.30.131.170 [8000]', '上线', '2017-11-21 15:03:34');
INSERT INTO `qq_info` VALUES ('48', '372241146', '10.16.153.163 [4003]', '下线', '2017-11-21 15:03:51');
INSERT INTO `qq_info` VALUES ('49', '372241146', '10.16.153.163 [4002]', '上线', '2017-11-21 15:03:56');
INSERT INTO `qq_info` VALUES ('50', '372241146', '111.30.131.190 [8000]', '上线', '2017-11-21 15:03:56');
INSERT INTO `qq_info` VALUES ('51', '372241146', '10.16.153.163 [4002]', '上线', '2017-11-21 15:03:56');
INSERT INTO `qq_info` VALUES ('52', '372241146', '120.204.17.121 [8000]', '上线', '2017-11-21 15:03:56');
INSERT INTO `qq_info` VALUES ('53', '372241146', '10.16.153.163 [4013]', '下线', '2017-12-11 16:56:50');
INSERT INTO `qq_info` VALUES ('54', '372241146', '10.16.153.163 [4004]', '上线', '2017-12-11 16:56:51');
INSERT INTO `qq_info` VALUES ('55', '372241146', '111.30.131.174 [8000]', '上线', '2017-12-11 16:56:51');
INSERT INTO `qq_info` VALUES ('56', '372241146', '10.16.153.163 [4004]', '上线', '2017-12-11 16:56:51');
INSERT INTO `qq_info` VALUES ('57', '372241146', '120.204.17.15 [8000]', '上线', '2017-12-11 16:56:51');
INSERT INTO `qq_info` VALUES ('58', '372241146', '10.16.153.163 [4015]', '下线', '2017-12-11 23:26:48');
INSERT INTO `qq_info` VALUES ('59', '372241146', '10.16.153.163 [4023]', '上线', '2017-12-11 23:26:52');
INSERT INTO `qq_info` VALUES ('60', '372241146', '111.30.131.166 [8000]', '上线', '2017-12-11 23:26:52');
INSERT INTO `qq_info` VALUES ('61', '372241146', '10.16.153.163 [4023]', '上线', '2017-12-11 23:26:52');
INSERT INTO `qq_info` VALUES ('62', '372241146', '120.204.17.124 [8000]', '上线', '2017-12-11 23:26:52');
INSERT INTO `qq_info` VALUES ('63', '372241146', '10.16.153.163 [4023]', '下线', '2017-12-11 23:27:13');
INSERT INTO `qq_info` VALUES ('64', '372241146', '10.16.153.163 [4009]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('65', '372241146', '111.30.131.172 [8000]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('66', '372241146', '10.16.153.163 [4009]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('67', '372241146', '120.204.17.123 [8000]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('68', '372241146', '10.16.153.163 [4009]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('69', '372241146', '183.232.93.25 [8000]', '上线', '2017-12-11 23:27:14');
INSERT INTO `qq_info` VALUES ('70', '372241146', '10.16.153.163 [4009]', '下线', '2017-12-11 23:27:31');
INSERT INTO `qq_info` VALUES ('71', '372241146', '10.16.153.163 [4018]', '上线', '2017-12-11 23:27:33');
INSERT INTO `qq_info` VALUES ('72', '372241146', '111.30.131.185 [8000]', '上线', '2017-12-11 23:27:33');
INSERT INTO `qq_info` VALUES ('73', '372241146', '10.16.153.163 [4018]', '上线', '2017-12-11 23:27:33');
INSERT INTO `qq_info` VALUES ('74', '372241146', '120.204.17.124 [8000]', '上线', '2017-12-11 23:27:33');
INSERT INTO `qq_info` VALUES ('75', '372241146', '10.16.153.163 [4018]', '下线', '2017-12-11 23:28:13');
INSERT INTO `qq_info` VALUES ('76', '372241146', '10.16.153.163 [4009]', '上线', '2017-12-11 23:28:15');
INSERT INTO `qq_info` VALUES ('77', '372241146', '111.30.131.169 [8000]', '上线', '2017-12-11 23:28:15');
INSERT INTO `qq_info` VALUES ('78', '372241146', '10.16.153.163 [4009]', '上线', '2017-12-11 23:28:15');
INSERT INTO `qq_info` VALUES ('79', '372241146', '183.232.93.25 [8000]', '上线', '2017-12-11 23:28:15');
