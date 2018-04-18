USE [ShopV3]
GO

------ USERS SEED


INSERT INTO Users(NumePrenume,Email,Telefon,Adresa,Parola,Nickname)
Values('Pop Alexandru','pop.alexandru@yahoo.com','0745034551','Observator 10','Pop123','Alex'),
('Moldovan Mihai','moldovanmihai@yahoo.com','0746223115','Observator 3','moldo34','MoldovanM'),
('Popescu Ion','ion_popescu@yahoo.com','0745075241','Meteor 10','Popion','Popescu'),
('Rusu Maria','maria.rusu@yahoo.com','0264977853','Dorobanti 30','Maria1','MariaR'),
('Muntean Alina','alinam@yahoo.com','0231557993','Dorobanti 80','Alina20','AlinaM'),
('Neag Andrei','andreineag@yahoo.com','027877655','Pandurilor 100','andrei123','NAndrei'),
('Muresan Bianca','biancam@gmail.com','0745564123','Pandurilor 30','Bianca1','Bianca'),
('Moldovan Raul','raulmoldovan@gmail.com','0234455613','Infratirii 53','Raul123','RaulM'),
('Avram Diana','avram_dianam@gmail.com','0264774112','Infratirii 30','Diana1','ADiana'),
('Manea Vlad','vlad_manea@gmail.com','5467455643','Avram Iancu 64','Manea1','Vlad1'),
('Farcas Florin','florin_farcas@gmail.com','027877655','Avram Iancu 79','Farcas1','FlorinF'),
('Stan George','georgestan@gmail.com','0740550643','Plopilor 230','Stan1','GeorgeS'),
('Chiriac Alexandra','alexandra_chiriac@gmail.com','075678643','Plopilor 33','Alexandra1','AlexandraC'),
('Jurca Costel','jurca_costel@gmail.com','0234552140','Aurel Vlaicu 108','Costel1','CostelJ'),
('Ardelean Paul','paul_ardelean@gmail.com','027877655','Jupiter 15','Paul1','PaulAr'),
('PMC Group Distributie','pmcgroupdistributie@emag.ro','0785224464','Str. Campia Libertatii, Nr.27, Bl.42, Sector 3,Bucuresti','PMCPass','ForIT'),
('Flanco Group','contact@flanco.com','0261400401','Sos. Bucuresti Nord Nr.15-23, Voluntari','Flanco','Flanco'),
('Altex Romania','contact@altexro.com','0213199939','Sos. Bucuresti Nord Nr.10, Voluntari','Altex','Altex'),
('Domo Romania','comenzi@domo.ro','0372245334','Str. Iuliu Maniu 7 Corp A parter, Sector 6 Bucuresti ','Domo','Domo'),
('Media Galaxy','contact@altexro.com','0213199939','Sos. Bucuresti Nord Nr.10, Voluntari','MediaGalaxy','Media Galaxy'),
('eMag Romania','contatct@emag.ro','0212005200','Cladirea Platinia, Calea Dorobantilor 33, Cluj-Napoca','Emag','Emag'),
('Direct Client Services','carturesti@emag.ro','0728828907','Bucuresti, Setor 1, Str. Edgar Quinet, Nr. 9','Carturesti','Carturesti'),
('Auto Scan','autoscan@emag.ro','0722349934','Strada Bucuresti, nr 55B, Cluj Napoca','Autoscan','Autoscan');
----Vanzatori

INSERT INTO Vanzatori(UserId,NumeCompanie, Cont,CUI)
VALUES(18,'Altex','RO35INGB0000977903208992','RO17369785'),
(19,'Domo','RO14INGB0000888815438941','RO39442157'),
(20,'Media Galaxy','RO39INGB0011899905206872','RO17224152'),
(16,'ForIT','RO07INGB0000999905206872','RO17116469'),
(21,'eMag','RO13INGB00009999773206872','RO11266469'),
(17,'Flanco','RO13INGB000099997732448521','RO27698631'),
(22,'Carturesti','RO51BUCU127302372511RO01','RO11648548'),
(23,'Autoscan','RO37BRDE040SV65263450400','RO32189995');


-----Admini

INSERT INTO Admins(UserId)
VALUES(1),
(21);


----De introdus:

----Branduri
INSERT INTO Branduri(NumeBrand)
VALUES('Lenovo'),
('HP'),
('Asus'),
('Dell'),
('Acer'),
('Apple'),
('MSI'),
('Toshiba'),
('Microsoft'),
('Samsung'),
('Huawei'),
('Xiomi'),('Sony'),('LG'),('Allview'),('Nokia'),('HTC'),('Google'),('Oneplus'),('Intel'),('AMD'),('Kingstone'),
('Gigabyte'),('Sapphire'),('Corsair'),('HyperX'),('Michelin'),('Continental'),('Pirelli'),('Rao'),('Litera'),('Nike'),('Adidas'),('Jack & Jones'),('Puma');



---- Categorii Produse

INSERT INTO CategoriiProduse(NumeCategorie)
VALUES('Laptopuri'),
('Tablete'),
('Telefoane'),
('PC & Periferice'),
('TV, Audio-Video & Foto'),
('Gaming'),
('Haine'),
('Carti'),
('Auto & Moto');

---- Produse