CREATE TABLE `Institution` (
	`id_institution` INT NOT NULL AUTO_INCREMENT,
	`nom_complet` CHAR(255),
	`adresse` VARCHAR(255),
	`sigle` VARCHAR(255),
	`telephone` INT unsigned,
	`nom_contact` CHAR(255),
	`telephone_contact` INT unsigned,
	`email` VARCHAR(255),
	PRIMARY KEY (`id_institution`)
);

CREATE TABLE `Site` (
	`id_site` INT NOT NULL AUTO_INCREMENT,
    `nom_site` VARCHAR(255),
	`id_institution` INT NOT NULL,
	`adresse` VARCHAR(255),
	`contact` INT unsigned,
    PRIMARY KEY (`id_site`),
	FOREIGN KEY (`id_institution`) REFERENCES Institution(`id_institution`)
);

CREATE TABLE `Speculation` (
	`id_speculation` INT unsigned NOT NULL AUTO_INCREMENT,
		`nom_speculation` ENUM("riz","sorgho","mil","maïs","arachide","niébé","oignon","tomate","piment","jaxatu","terre","douce","gombo","aubergine") NOT NULL,
		`lieu_de_stockage` VARCHAR(255),
		`type_de_stockage` VARCHAR(255),
		`quantite_speculation` INT UNSIGNED NOT NULL,
		`niveau_de_production` ENUM("prebase", "base", "R1", "R2"),
		`id_site` INT NOT NULL,
		PRIMARY KEY (`id_speculation`),
		FOREIGN KEY (`id_site`) REFERENCES Site(`id_site`)
);

CREATE TABLE `Variete` (
	`id_variete` INT NOT NULL AUTO_INCREMENT,
    `id_speculation` INT UNSIGNED NOT NULL,
	`nom_variete` VARCHAR(255),
	`longueur_cycle` INT unsigned,
	`zone_agro_ecologique` VARCHAR(255),
	`date_production` DATE,
    `image_variete` VARCHAR(255),
    `quantite_variete` INT UNSIGNED NOT NULL,
    `prix` INT UNSIGNED NOT NULL,
    `quantite_de_securite` INT UNSIGNED NOT NULL,
	PRIMARY KEY (`id_variete`),
	FOREIGN KEY (`id_speculation`) REFERENCES Speculation(`id_speculation`)
);

CREATE TABLE `Client` (
	`id_client` INT NOT NULL AUTO_INCREMENT,
    `nom_complet_structure` VARCHAR(255),
    `acronyme` VARCHAR(255),
    `personne_contact` VARCHAR(236),
	PRIMARY KEY (`id_client`)
);

CREATE TABLE `Contact` (
	`nom` CHAR(255),
	`prenom` CHAR(255),
	`adresse` INT,
	`telephone` INT unsigned,
	`pays` CHAR(255),
	`region` CHAR(255),
	`commune` CHAR(255),
	`email` VARCHAR(236)
);

CREATE TABLE `Commande` (
    `numero_de_commade` INT UNSIGNED AUTO_INCREMENT,
    `quantite` INT UNSIGNED,
    `prix_commande` INT UNSIGNED,
    `est_recuperee` BOOLEAN,
    `date_recuperation_souhaitee` DATE,
    `date_recuperation_reelle` DATE,
    `date_creation_commande` DATE,
    `date_derniere_modification` DATE,
    `date_expression_besoin_client` DATE,
    `site_enlevement` INT NOT NULL,
    `id_variete` INT NOT NULL,
    `id_client` INT NOT NULL,
    PRIMARY KEY (`numero_de_commade`),
    FOREIGN KEY (`id_variete`) REFERENCES Variete(`id_variete`),
	FOREIGN KEY (`id_site`) REFERENCES Site(`id_site`),
    FOREIGN KEY (`id_client`) REFERENCES Client(`id_client`) 
);