La base de données : 

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 mars 2025 à 07:57
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdcontact`
--

-- --------------------------------------------------------

--
-- Structure de la table `contacts`
--

DROP TABLE IF EXISTS `contacts`;
CREATE TABLE IF NOT EXISTS `contacts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `utilisateur_id` int DEFAULT NULL,
  `nom` varchar(100) NOT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `adresse` text,
  PRIMARY KEY (`id`),
  KEY `utilisateur_id` (`utilisateur_id`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `contacts`
--

INSERT INTO `contacts` (`id`, `utilisateur_id`, `nom`, `telephone`, `email`, `adresse`) VALUES
(4, 1, 'Cris', '0781633879', 'cris@modif.com', '12 rue modif'),
(18, 6, 'orian', '0781633877', 'EOKFERJIF@FIJGJG.COM', 'RIFRFJIORF'),
(9, 0, 'cris', '0781633879', 'cris@modif.com', '12 rue modif'),
(11, 0, 'Nico', '0793453211', 'nico@gmail.com', 'qq part a massy'),
(14, 2, 'Hasardeux', '0781633878', 'Hasardeux@gmail.com', '12 rue neige'),
(15, 6, 'nico', '0781633875', 'test@gmail.com', '15 rue flop'),
(22, 6, 'test', '0781633877', 'test@gmail.com', '12 ruie '),
(17, 6, 'hasard', '1234567891', 'FRF@ff.com', '12 ifjoi'),
(19, 6, 'Baptiste', '0626061275', 'bapt@gmail.com', '12 rue du test'),
(23, 7, 'TEST', '0781633877', 'hello@gmail.com', '25 eee'),
(21, 2, 'RonaldoCR', '0625061475', 'cr7@gmail.com', '1 rue du GOAT');

-- --------------------------------------------------------

--
-- Structure de la table `evenements`
--

DROP TABLE IF EXISTS `evenements`;
CREATE TABLE IF NOT EXISTS `evenements` (
  `id` int NOT NULL AUTO_INCREMENT,
  `utilisateur_id` int NOT NULL,
  `nom` varchar(255) NOT NULL,
  `date` datetime NOT NULL,
  `lieu` varchar(255) DEFAULT NULL,
  `description` text,
  `nb_max_participants` int DEFAULT NULL,
  `createur_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_evenements_utilisateur` (`utilisateur_id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `evenements`
--

INSERT INTO `evenements` (`id`, `utilisateur_id`, `nom`, `date`, `lieu`, `description`, `nb_max_participants`, `createur_id`) VALUES
(3, 0, 'Anniversaire Orian', '2025-02-03 16:24:40', 'Grigny', 'Anniversaire', 15, 0),
(5, 0, 'TEST ', '2025-01-29 14:56:06', 'VDB', 'JSP', 6, 6),
(6, 0, 'MR.Greedy', '2025-01-29 14:56:06', 'St-Michel', 'UneDescription', 11, 6),
(7, 0, 'efijezfuiozehnf', '2025-02-20 13:47:48', 'feeif', 'iefjeifhj', 2, 6),
(8, 0, 'evenement3', '2025-02-22 16:12:46', 'Paris', 'Desc', 1, 6),
(9, 0, 'Ajd', '2025-02-21 14:18:12', 'ici', 'la', 1, 7),
(10, 0, 'Journée PPE', '2025-03-04 08:49:48', 'CFA Massy', 'test pour ppe', 5, 7);

-- --------------------------------------------------------

--
-- Structure de la table `inscriptions`
--

DROP TABLE IF EXISTS `inscriptions`;
CREATE TABLE IF NOT EXISTS `inscriptions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `utilisateur_id` int NOT NULL,
  `evenement_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_inscription` (`utilisateur_id`,`evenement_id`),
  KEY `evenement_id` (`evenement_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `inscriptions`
--

INSERT INTO `inscriptions` (`id`, `utilisateur_id`, `evenement_id`) VALUES
(10, 6, 7),
(4, 2, 3),
(5, 2, 5),
(6, 5, 3),
(7, 5, 5),
(8, 6, 5),
(9, 6, 6),
(11, 6, 8),
(12, 7, 3),
(13, 7, 9),
(14, 7, 10);

-- --------------------------------------------------------

--
-- Structure de la table `inscriptions_evenements`
--

DROP TABLE IF EXISTS `inscriptions_evenements`;
CREATE TABLE IF NOT EXISTS `inscriptions_evenements` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_evenement` int DEFAULT NULL,
  `id_utilisateur` int DEFAULT NULL,
  `date_inscription` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `id_evenement` (`id_evenement`),
  KEY `id_utilisateur` (`id_utilisateur`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `role` varchar(10) DEFAULT 'user',
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `nom`, `prenom`, `email`, `mdp`, `role`) VALUES
(1, '', '', 'test@example.com', 'monMotDePasse', 'user'),
(2, '', '', 'orian@gmail.com', 'orianmdp', 'admin'),
(3, '', '', 'ronaldo@gmail.com', 'cr7', 'admin'),
(5, '', '', 'test2@gmail.com', 'test', 'user'),
(6, '', '', 'nv@gmail.com', 'nv', 'user'),
(7, 'BELLIGOAL', 'Jude', 'jude@gmail.com', 'jude123', 'user');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
