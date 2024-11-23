﻿
DECLARE @GameStaging TABLE
(
	GameID INT NOT NULL IDENTITY(1,1),
	PublisherID INT NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	ReleaseDate DATETIME2 NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @GameStaging(PublisherID,[Name], ReleaseDate)
VALUES
   (1, N'Elden Ring','2022-02-25'),
(2, N'Hades','2019-12-10'),
(3, N'The Legend of Zelda: Breath of the Wild','2017-03-03'),
(4, N'Undertale','2015-09-15'),
(5, N'Hollow Knight','2017-02-24'),
(6, N'Minecraft','2011-11-18'),
(7, N'Omori','2020-12-25'),
(3, N'Metroid Dread','2021-10-07'),
(8, N'Among Us','2018-06-15'),
(9, N'NieR: Automata','2017-02-23'),
(10, N'Persona 5 Royal','2019-10-31'),
(11, N'Stray','2022-07-19'),
(12, N'God of War','2018-04-20'),
(13, N'Portal 2','2011-04-18'),
(14, N'Bloodborne','2015-03-24'),
(15, N'Celeste','2018-01-25'),
(16, N'Yakuza 0','2015-03-12'),
(17, N'Red Dead Redemption 2','2018-10-26'),
(13, N'Portal','2007-10-10'),
(3, N'Super Mario Odyssey','2017-10-27'),
(3, N'Pokémon Legends: Arceus','2022-01-28'),
(18, N'Hi-Fi Rush','2023-01-25'),
(19, N'Metal Gear Rising: Revengeance','2013-02-19'),
(20, N'Grand Theft Auto V','2013-09-17'),
(21, N'Cyberpunk 2077','2020-12-09'),
(12, N'God of War Ragnarök','2022-11-09'),
(22, N'Xenoblade Chronicles 3','2022-07-29'),
(23, N'Kirby and the Forgotten Land','2022-03-25'),
(24, N'Disco Elysium: The Final Cut','2020-05-01'),
(25, N'Marvels Spider-Man','2018-09-07'),
(1, N'Dark Souls III','2016-03-24'),
(26, N'NieR Replicant ver.1.22474487139...','2021-04-22'),
(3, N'Super Mario 64','1996-06-23'),
(27, N'Super Smash Bros. Ultimate','2018-12-07'),
(28, N'Cuphead','2017-09-29'),
(14, N'Sekiro: Shadows Die Twice','2019-03-22'),
(29, N'Final Fantasy VII','1997-01-31'),
(30, N'Persona 4 Golden','2012-06-15'),
(31, N'Genshin Impact','2020-09-28'),
(32, N'Signalis','2022-10-27'),
(33, N'Resident Evil Village','2021-05-06'),
(34, N'Super Mario Galaxy','2007-11-01'),
(35, N'Fallout: New Vegas','2010-10-19'),
(36, N'Outer Wilds','2019-05-28'),
(33, N'Resident Evil 2','2019-01-25'),
(37, N'Doom','2016-05-12'),
(38, N'Shin Megami Tensei V','2021-11-12'),
(39, N'Bayonetta','2009-10-29'),
(40, N'Stardew Valley','2016-02-26'),
(41, N'The Last of Us Part II','2020-06-19'),
(42, N'Silent Hill 2','2001-09-24'),
(43, N'The Witcher 3: Wild Hunt','2015-05-19'),
(38, N'Persona 5','2016-09-15'),
(44, N'Doom Eternal','2020-03-19'),
(45, N'The Elder Scrolls V: Skyrim','2011-11-10'),
(46, N'Neon White','2022-06-16'),
(33, N'Devil May Cry 5','2019-03-08'),
(47, N'Overwatch 2','2022-10-04'),
(33, N'Resident Evil 4','2005-01-11'),
(48, N'Final Fantasy VII Remake','2020-04-10'),
(49, N'Sonic Frontiers','2022-11-08'),
(50, N'Inscryption','2021-10-19'),
(51, N'Tunic','2022-03-16'),
(14, N'Dark Souls','2011-09-22'),
(3, N'The Legend of Zelda: Ocarina of Time','1998-11-21'),
(52, N'Deltarune: Chapter 2','2021-09-17'),
(29, N'Chrono Trigger','1995-03-11'),
(53, N'Metal Gear Solid 2: Sons of Liberty','2001-11-13'),
(3, N'Super Mario World','1990-11-21'),
(12, N'Death Stranding','2019-11-08'),
(25, N'Marvels Spider-Man: Miles Morales','2020-11-12'),
(1, N'Dark Souls: Remastered','2018-05-23'),
(3, N'EarthBound','1994-08-27'),
(19, N'Castlevania: Symphony of the Night','1997-03-20'),
(54, N'Super Metroid','1994-03-19'),
(3, N'Super Mario Bros.','1985-09-13'),
(3, N'The Legend of Zelda: Majoras Mask','2000-04-27'),
(55, N'Star Wars Jedi: Fallen Order','2019-11-15'),
(41, N'The Last of Us','2013-06-14'),
(56, N'Terraria','2011-05-16'),
(33, N'Resident Evil 7: Biohazard','2017-01-24'),
(19, N'Metal Gear Solid V: The Phantom Pain','2015-09-01'),
(47, N'Overwatch','2016-05-24'),
(57, N'Half-Life 2','2004-11-16'),
(58, N'Fire Emblem: Three Houses','2019-07-25'),
(59, N'Grand Theft Auto: San Andreas','2004-10-26'),
(60, N'13 Sentinels: Aegis Rim','2019-11-28'),
(38, N'Persona 3 FES','2007-04-19'),
(61, N'Devil May Cry','2001-08-23'),
(62, N'Mario Kart 8 Deluxe','2017-04-28'),
(3, N'Fire Emblem Engage','2023-01-20'),
(63, N'Pokémon Violet','2022-11-18'),
(64, N'Hotline Miami','2012-10-23'),
(65, N'Pizza Tower','2023-01-26'),
(66, N'Psychonauts 2','2021-08-24'),
(3, N'Metroid Prime Remastered','2023-02-08'),
(66, N'Halo Infinite','2021-11-15'),
(67, N'Batman: Arkham Asylum','2009-08-25'),
(34, N'Super Mario Sunshine','2002-07-19'),
(23, N'Mother 3','2006-04-20'),
(68, N'MultiVersus','2022-07-19'),
(22, N'Xenoblade Chronicles: Definitive Edition','2020-05-29'),
(57, N'Half-Life','1998-11-19'),
(48, N'Marvels Guardians of the Galaxy','2021-10-26'),
(30, N'Danganronpa: Trigger Happy Havoc','2010-11-25'),
(50, N'Cult of the Lamb','2022-08-11'),
(69, N'Sonic Mania','2017-08-15'),
(70, N'Horizon Zero Dawn','2017-02-28'),
(71, N'Left 4 Dead 2','2009-11-17'),
(72, N'League of Legends','2009-10-27'),
(73, N'Control','2019-08-27'),
(74, N'Doki Doki Literature Club!','2017-09-22'),
(75, N'Batman: Arkham City','2011-10-18'),
(49, N'Yakuza Kiwami','2016-01-21'),
(76, N'Phoenix Wright: Ace Attorney','2005-09-15'),
(77, N'Team Fortress 2','2007-10-09'),
(22, N'Xenoblade Chronicles 2','2017-12-01'),
(3, N'Splatoon 3','2022-09-09'),
(78, N'Chrome Dino','2014-09-01'),
(79, N'Katana Zero','2019-04-18'),
(80, N'Life is Strange','2015-01-29'),
(1, N'Dark Souls II: Scholar of the First Sin','2015-04-02'),
(44, N'Deathloop','2021-09-14'),
(81, N'Shadow of the Colossus','2005-10-18'),
(82, N'Teenage Mutant Ninja Turtles: Shredders Revenge','2022-06-16'),
(83, N'Sifu','2022-02-08'),
(84, N'Super Mario Bros. 3','1988-10-23'),
(85, N'Dishonored','2012-10-09'),
(53, N'Metal Gear Solid 3: Snake Eater','2004-11-17'),
(86, N'Journey','2012-03-13'),
(29, N'Kingdom Hearts','2002-03-28'),
(55, N'Titanfall 2','2016-10-28'),
(87, N'Doom','1993-12-10'),
(48, N'Live A Live','2022-07-22'),
(41, N'The Last of Us Remastered','2014-07-26'),
(88, N'Sonic the Hedgehog','1991-06-23'),
(89, N'Rocket League','2015-07-06'),
(90, N'Batman: Arkham Knight','2015-06-23'),
(9, N'Bayonetta 3','2022-10-28'),
(24, N'Disco Elysium','2019-10-15'),
(91, N'Guilty Gear: Strive','2021-06-11'),
(3, N'Wii Sports','2006-11-19'),
(92, N'Hogwarts Legacy','2023-02-10'),
(3, N'Mario Kart Wii','2008-04-10'),
(93, N'Resident Evil 3','2020-04-03'),
(94, N'Unpacking','2021-11-02'),
(59, N'Red Dead Redemption','2010-05-18'),
(1, N'Tales of Arise','2021-09-10'),
(52, N'Deltarune: Chapter 1','2018-10-31'),
(95, N'Dead Space','2023-01-27'),
(48, N'Tomb Raider','2013-03-04'),
(34, N'Super Mario Galaxy 2','2010-05-23'),
(96, N'Donkey Kong Country','1994-11-18'),
(97, N'What Remains of Edith Finch','2017-04-24'),
(33, N'Monster Hunter Rise','2021-03-26'),
(3, N'Pokémon Emerald','2004-09-16'),
(48, N'NEO: The World Ends with You','2021-07-26'),
(98, N'Assassins Creed II','2009-11-17'),
(3, N'Pokémon Scarlet','2022-11-18'),
(99, N'Dead Space','2008-10-14'),
(3, N'New Super Mario Bros.','2006-05-15'),
(12, N'Shadow of the Colossus','2018-02-06'),
(70, N'Horizon Forbidden West','2022-02-18'),
(100, N'God of War','2005-03-22'),
(101, N'Detroit: Become Human','2018-05-25'),
(48, N'Final Fantasy XV','2016-11-29'),
(102, N'Persona 5 Strikers','2020-02-20'),
(103, N'Limbo','2010-07-21'),
(3, N'Pokémon Platinum','2008-09-13'),
(104, N'Stranger of Paradise: Final Fantasy Origin','2022-03-18'),
(33, N'Killer7','2005-06-09'),
(20, N'Grand Theft Auto IV','2008-04-29'),
(54, N'Metroid: Zero Mission','2004-02-09'),
(105, N'Final Fantasy X','2001-07-19'),
(30, N'Danganronpa 2: Goodbye Despair','2012-07-26'),
(29, N'Final Fantasy IX','2000-07-07'),
(106, N'Halo 3','2007-09-25'),
(3, N'Metroid Fusion','2002-11-17'),
(48, N'Final Fantasy VI','1994-04-02'),
(107, N'VA-11 Hall-A: Cyberpunk Bartender Action','2016-06-21'),
(108, N'Dead Cells','2018-08-06'),
(109, N'Far Cry 3','2012-11-28'),
(110, N'The Stanley Parable: Ultra Deluxe','2022-04-27'),
(111, N'SuperHot','2016-02-25'),
(112, N'Plants vs. Zombies','2009-05-05'),
(113, N'Ori and the Blind Forest','2015-03-11'),
(114, N'Demons Souls','2020-11-12'),
(115, N'A Plague Tale: Innocence','2019-05-14'),
(3, N'The Legend of Zelda: Links Awakening','2019-09-20'),
(98, N'Assassins Creed Valhalla','2007-11-13'),
(116, N'Judgment','2018-12-13'),
(87, N'Call of Duty: Black Ops','2010-11-09'),
(12, N'Ratchet & Clank: Rift Apart','2021-06-11'),
(3, N'Pokémon Black','2010-09-18'),
(117, N'The Stanley Parable','2013-10-17'),
(34, N'The Legend of Zelda','1986-02-21'),
(118, N'AI: The Somnium Files - Nirvana Initiative','2022-06-23'),
(33, N'Ghost Trick: Phantom Detective','2010-06-19'),
(48, N'Dragon Quest XI S: Echoes of an Elusive Age - Definitive Edition','2019-09-27'),
(3, N'Paper Mario: The Thousand-Year Door','2004-07-22'),
(81, N'God of War II','2007-03-13'),
(119, N'Mass Effect 2','2010-01-26'),
(120, N'Forza Horizon 5','2021-11-09'),
(19, N'Metal Gear Solid V: Ground Zeroes','2014-03-18'),
(121, N'No More Heroes III','2021-08-27'),
(103, N'Banjo-Kazooie','1998-06-29'),
(122, N'Astros Playroom','2020-11-12'),
(123, N'Call of Duty: Black Ops II','2012-11-12'),
(3, N'The Legend of Zelda: Skyward Sword HD','2021-07-16'),
(124, N'Mega Man X','1993-12-17'),
(125, N'Subnautica','2018-01-23'),
(126, N'Returnal','2021-04-30'),
(3, N'New Super Mario Bros. Wii','2009-11-12'),
(127, N'Citizen Sleeper','2022-05-05'),
(16, N'Yakuza 3 Remastered','2018-08-09'),
(128, N'Garrys Mod','2004-12-24'),
(129, N'Wolfenstein: The New Order','2014-05-20'),
(130, N'Deus Ex','2000-06-26'),
(131, N'BioShock 2','2010-02-09'),
(49, N'Soul Hackers 2','2022-08-25'),
(132, N'Enter the Gungeon','2016-04-05'),
(133, N'The House in Fata Morgana','2012-12-27'),
(134, N'Shovel Knight','2014-06-26'),
(135, N'Firewatch','2016-02-09'),
(14, N'Dark Souls II','2014-03-11'),
(136, N'Blasphemous','2019-09-10'),
(48, N'Final Fantasy XIV Online','2013-08-27'),
(137, N'Immortality','2022-08-30'),
(33, N'Resident Evil 6','2012-10-02'),
(33, N'Devil May Cry 3: Dantes Awakening','2005-02-17'),
(12, N'The Last of Us Part I','2022-09-01'),
(138, N'Super Meat Boy','2010-10-20'),
(119, N'Mass Effect Legendary Edition','2021-05-14'),
(139, N'Helltaker','2020-05-11'),
(63, N'Pokémon Sword','2019-11-15'),
(87, N'Crash Bandicoot N. Sane Trilogy','2017-06-30'),
(3, N'Tetris','1989-11-01'),
(140, N'Valorant','2020-06-02'),
(3, N'Super Mario 3D World','2013-11-21'),
(41, N'Uncharted 3: Drakes Deception','2011-11-01'),
(33, N'Phoenix Wright: Ace Attorney - Trials and Tribulations','2006-03-31'),
(141, N'Yume Nikki','2004-06-26'),
(142, N'Max Payne','2001-07-23'),
(143, N'Five Nights at Freddys','2014-08-08'),
(3, N'Donkey Kong Country 2: Diddys Kong Quest','1995-11-21'),
(3, N'Pokémon White','2010-09-18'),
(144, N'Outlast','2013-09-04'),
(145, N'Hitman 3','2021-01-20'),
(146, N'Sable','2021-09-23'),
(27, N'Super Smash Bros. for Wii U','2014-11-21'),
(23, N'Kirbys Adventure','1993-03-23'),
(1, N'Tekken 7','2015-02-18'),
(147, N'Umineko: When They Cry Chiru','2009-09-15'),
(148, N'Kingdom Hearts II Final Mix','2007-03-29'),
(149, N'Superliminal','2019-11-12'),
(150, N'Death Stranding: Directors Cut','2021-09-24'),
(38, N'Persona 4','2008-07-10'),
(151, N'Wordle','2021-06-21'),
(77, N'The Sims 4','2014-09-02'),
(98, N'Far Cry 4','2014-11-18'),
(49, N'Sonic Forces','2017-11-07'),
(152, N'To the Moon','2011-11-01'),
(153, N'Baba is You','2019-03-13'),
(21, N'The Witcher 3: Wild Hunt - Game of the Year Edition','2016-08-29'),
(3, N'Super Smash Bros.','1999-01-21'),
(34, N'Super Mario 64 DS','2004-11-21'),
(154, N'Halo 4','2012-11-06'),
(155, N'Middle-earth: Shadow of Mordor','2014-09-30'),
(33, N'Mega Man 2','1989-06-02'),
(33, N'Phoenix Wright: Ace Attorney Trilogy','2014-04-17'),
(86, N'Infamous: Second Son','2014-03-21'),
(119, N'Star Wars: Knights of the Old Republic','2003-07-15'),
(109, N'No More Heroes 2: Desperate Struggle','2010-01-26'),
(156, N'Kirby Super Star Ultra','2008-09-22'),
(121, N'Flower, Sun, and Rain','2001-05-02'),
(157, N'Katamari Damacy','2004-03-18'),
(49, N'Shadow the Hedgehog','2005-11-15'),
(158, N'Ōkami HD','2012-10-30'),
(159, N'Metroid: Samus Returns','2017-09-15'),
(160, N'Life is Strange: True Colors','2021-09-10'),
(63, N'Pokémon Black Version 2','2012-06-23'),
(3, N'Needy Streamer Overload','2022-01-21'),
(161, N'Borderlands','2009-10-20'),
(5, N'Hollow Knight: Voidheart Edition','2018-09-25'),
(157, N'Klonoa: Door to Phantomile','1997-12-11'),
(162, N'Shadow of the Tomb Raider','2018-09-14'),
(3, N'Mario & Luigi: Bowsers Inside Story','2009-09-14'),
(163, N'Ghostrunner','2020-10-27'),
(98, N'Watch Dogs 2','2016-11-15'),
(164, N'Mass Effect 3','2012-03-06'),
(165, N'Goat Simulator','2014-04-01'),
(45, N'The Elder Scrolls V: Skyrim - Special Edition','2016-10-27'),
(109, N'Far Cry 5','2018-03-26'),
(166, N'Call of Duty: Modern Warfare 3','2011-11-08'),
(167, N'Friday Night Funkin','2020-11-01'),
(168, N'Osu!','2007-09-16'),
(3, N'The Legend of Zelda: Twilight Princess','2006-11-19'),
(14, N'Bloodborne: The Old Hunters','2015-11-24'),
(3, N'Fire Emblem Warriors: Three Hopes','2022-06-24'),
(3, N'Super Smash Bros. for Nintendo 3DS','2014-09-13'),
(169, N'The Legend of Heroes: Trails to Azure','2011-09-29'),
(29, N'Super Mario RPG: Legend of the Seven Stars','1996-03-09'),
(9, N'Astral Chain','2019-08-30'),
(170, N'DmC: Devil May Cry','2013-01-15'),
(77, N'Dragon Age: Origins','2009-11-03'),
(29, N'Vagrant Story','2000-02-10'),
(171, N'Amnesia: The Dark Descent','2010-09-08'),
(33, N'Monster Hunter Rise: Sunbreak','2022-06-29'),
(172, N'Super Mario Maker 2','2019-06-28'),
(58, N'Fire Emblem: The Blazing Blade','2003-04-25'),
(43, N'LEGO Marvel Super Heroes','2013-09-30'),
(173, N'Sonic Colors','2010-11-11'),
(174, N'Pokémon Moon','2016-11-18'),
(3, N'Zelda II: The Adventure of Link','1987-01-14'),
(175, N'Battlefield 4','2013-10-29'),
(176, N'Dragon Ball Z: Budokai Tenkaichi 3','2007-10-04'),
(177, N'WarioWare: Get It Together!','2021-09-09'),
(101, N'Beyond: Two Souls','2013-10-08'),
(1, N'Digimon Survive','2022-07-28'),
(178, N'Spiritfarer','2020-08-18'),
(179, N'Little Nightmares II','2021-02-10'),
(18, N'The Evil Within 2','2017-10-12'),
(180, N'Bloons TD 6','2018-06-14'),
(181, N'Sayonara Wild Hearts','2019-09-19'),
(182, N'Metro 2033 Redux','2014-08-26'),
(183, N'Melty Blood: Type Lumina','2021-09-29'),
(1, N'Elden Ring','2022-02-25'),
(2, N'Hades','2019-12-10'),
(3, N'The Legend of Zelda: Breath of the Wild','2017-03-03'),
(4, N'Undertale','2015-09-15'),
(5, N'Hollow Knight','2017-02-24'),
(6, N'Minecraft','2011-11-18'),
(7, N'Omori','2020-12-25'),
(3, N'Metroid Dread','2021-10-07'),
(8, N'Among Us 2','2018-06-15'),
(9, N'NieR: Automata','2017-02-23'),
(10, N'Persona 5 Royal','2019-10-31'),
(11, N'Stray','2022-07-19'),
(12, N'God of War','2018-04-20'),
(13, N'Portal 2','2011-04-18'),
(14, N'Bloodborne','2015-03-24'),
(15, N'Celeste','2018-01-25'),
(16, N'Yakuza 0','2015-03-12'),
(17, N'Red Dead Redemption 2','2018-10-26'),
(13, N'Portal','2007-10-10'),
(3, N'Super Mario Odyssey','2017-10-27'),
(3, N'Pokémon Legends: Arceus','2022-01-28'),
(18, N'Hi-Fi Rush','2023-01-25'),
(19, N'Metal Gear Rising: Revengeance','2013-02-19'),
(20, N'Grand Theft Auto V','2013-09-17'),
(21, N'Cyberpunk 2077','2020-12-09'),
(12, N'God of War Ragnarök','2022-11-09'),
(22, N'Xenoblade Chronicles 3','2022-07-29'),
(23, N'Kirby and the Forgotten Land','2022-03-25'),
(24, N'Disco Elysium: The Final Cut','2020-05-01'),
(25, N'Marvels Spider-Man','2018-09-07'),
(1, N'Dark Souls III','2016-03-24'),
(26, N'NieR Replicant ver.1.22474487139...','2021-04-22'),
(3, N'Super Mario 64','1996-06-23'),
(27, N'Super Smash Bros. Ultimate','2018-12-07'),
(28, N'Cuphead','2017-09-29'),
(14, N'Sekiro: Shadows Die Twice','2019-03-22'),
(29, N'Final Fantasy VII','1997-01-31'),
(30, N'Persona 4 Golden','2012-06-15'),
(31, N'Genshin Impact','2020-09-28'),
(32, N'Signalis','2022-10-27'),
(33, N'Resident Evil Village','2021-05-06'),
(34, N'Super Mario Galaxy','2007-11-01'),
(35, N'Fallout: New Vegas','2010-10-19'),
(36, N'Outer Wilds','2019-05-28'),
(33, N'Resident Evil 2','2019-01-25'),
(37, N'Doom','2016-05-12'),
(38, N'Shin Megami Tensei V','2021-11-12'),
(39, N'Bayonetta','2009-10-29'),
(40, N'Stardew Valley','2016-02-26'),
(41, N'The Last of Us Part II','2020-06-19'),
(42, N'Silent Hill 2','2001-09-24'),
(43, N'The Witcher 3: Wild Hunt','2015-05-19'),
(38, N'Persona 5','2016-09-15'),
(44, N'Doom Eternal','2020-03-19'),
(45, N'The Elder Scrolls V: Skyrim','2011-11-10'),
(46, N'Neon White','2022-06-16'),
(33, N'Devil May Cry 5','2019-03-08'),
(47, N'Overwatch 2','2022-10-04'),
(33, N'Resident Evil 4','2005-01-11'),
(48, N'Final Fantasy VII Remake','2020-04-10'),
(49, N'Sonic Frontiers','2022-11-08'),
(50, N'Inscryption','2021-10-19'),
(51, N'Tunic','2022-03-16'),
(14, N'Dark Souls','2011-09-22'),
(3, N'The Legend of Zelda: Ocarina of Time','1998-11-21'),
(184, N'Vampire Survivors','2021-12-17'),
(75, N'Batman: Arkham City','2011-10-18'),
(49, N'Yakuza Kiwami','2016-01-21'),
(76, N'Phoenix Wright: Ace Attorney','2005-09-15'),
(77, N'Team Fortress 2','2007-10-09'),
(22, N'Xenoblade Chronicles 2','2017-12-01'),
(3, N'Splatoon 3','2022-09-09'),
(78, N'Chrome Dino','2014-09-01'),
(79, N'Katana Zero','2019-04-18'),
(80, N'Life is Strange','2015-01-29'),
(1, N'Dark Souls II: Scholar of the First Sin','2015-04-02'),
(44, N'Deathloop','2021-09-14'),
(81, N'Shadow of the Colossus','2005-10-18'),
(82, N'Teenage Mutant Ninja Turtles: Shredders Revenge','2022-06-16'),
(185, N'Psychonauts','2005-04-19'),
(45, N'Fallout 4','2015-11-09'),
(41, N'Uncharted 4: A Thiefs End','2016-05-10'),
(34, N'The Legend of Zelda: A Link to the Past','1991-11-21'),
(19, N'Silent Hill','1999-02-23'),
(3, N'Super Smash Bros. Brawl','2008-01-31'),
(186, N'Borderlands 2','2012-09-18'),
(121, N'No More Heroes','2007-12-06'),
(187, N'Ghost of Tsushima','2020-07-17'),
(83, N'Sifu','2022-02-08'),
(84, N'Super Mario Bros. 3','1988-10-23'),
(85, N'Dishonored','2012-10-09'),
(53, N'Metal Gear Solid 3: Snake Eater','2004-11-17'),
(86, N'Journey','2012-03-13'),
(29, N'Kingdom Hearts','2002-03-28'),
(55, N'Titanfall 2','2016-10-28'),
(87, N'Doom','1993-12-10'),
(48, N'Live A Live','2022-07-22'),
(41, N'The Last of Us Remastered','2014-07-26'),
(88, N'Sonic the Hedgehog','1991-06-23'),
(89, N'Rocket League','2015-07-06'),
(90, N'Batman: Arkham Knight','2015-06-23'),
(9, N'Bayonetta 3','2022-10-28'),
(24, N'Disco Elysium','2019-10-15'),
(91, N'Guilty Gear: Strive','2021-06-11'),
(3, N'Wii Sports','2006-11-19'),
(92, N'Hogwarts Legacy','2023-02-10'),
(3, N'Mario Kart Wii','2008-04-10'),
(93, N'Resident Evil 3','2020-04-03'),
(94, N'Unpacking','2021-11-02'),
(59, N'Red Dead Redemption','2010-05-18'),
(1, N'Tales of Arise','2021-09-10'),
(52, N'Deltarune: Chapter 1','2018-10-31'),
(95, N'Dead Space','2023-01-27'),
(48, N'Tomb Raider','2013-03-04'),
(34, N'Super Mario Galaxy 2','2010-05-23'),
(96, N'Donkey Kong Country','1994-11-18'),
(97, N'What Remains of Edith Finch','2017-04-24'),
(33, N'Monster Hunter Rise','2021-03-26'),
(3, N'Pokémon Emerald','2004-09-16'),
(48, N'NEO: The World Ends with You','2021-07-26'),
(98, N'Assassins Creed Mirage','2009-11-17'),
(3, N'Pokémon Scarlet','2022-11-18'),
(99, N'Dead Space','2008-10-14'),
(3, N'New Super Mario Bros.','2006-05-15'),
(12, N'Shadow of the Colossus','2018-02-06'),
(70, N'Horizon Forbidden West','2022-02-18'),
(113, N'Ori and the Blind Forest','2015-03-11'),
(114, N'Demons Souls','2020-11-12'),
(115, N'A Plague Tale: Requiem','2019-05-14'),
(3, N'The Legend of Zelda: Links Awakening','2019-09-20'),
(98, N'Assassins Creed','2007-11-13'),
(116, N'Judgment','2018-12-13'),
(87, N'Call of Duty: Black Ops','2010-11-09'),
(12, N'Ratchet & Clank: Rift Apart','2021-06-11'),
(3, N'Pokémon Black','2010-09-18'),
(117, N'The Stanley Parable','2013-10-17'),
(34, N'The Legend of Zelda','1986-02-21'),
(118, N'AI: The Somnium Files - Nirvana Initiative 2','2022-06-23'),
(33, N'Ghost Trick: Phantom Detective','2010-06-19'),
(48, N'Dragon Quest XI S: Echoes of an Elusive Age - Definitive Edition','2019-09-27'),
(3, N'Paper Mario: The Thousand-Year Door','2004-07-22'),
(81, N'God of War II','2007-03-13'),
(119, N'Mass Effect 2','2010-01-26'),
(120, N'Forza Horizon 5','2021-11-09'),
(19, N'Metal Gear Solid V: Ground Zeroes','2014-03-18'),
(121, N'No More Heroes III','2021-08-27'),
(103, N'Banjo-Kazooie','1998-06-29'),
(122, N'Astros Playroom','2020-11-12'),
(123, N'Call of Duty: Black Ops II','2012-11-12'),
(3, N'The Legend of Zelda: Skyward Sword HD','2021-07-16'),
(124, N'Mega Man X','1993-12-17'),
(125, N'Subnautica','2018-01-23'),
(126, N'Returnal','2021-04-30'),
(3, N'New Super Mario Bros. Wii','2009-11-12'),
(127, N'Citizen Sleeper','2022-05-05'),
(16, N'Yakuza 3 Remastered','2018-08-09'),
(128, N'Garrys Mod','2004-12-24'),
(129, N'Wolfenstein: The New Order','2014-05-20'),
(130, N'Deus Ex','2000-06-26'),
(131, N'BioShock 2','2010-02-09'),
(49, N'Soul Hackers 2','2022-08-25'),
(132, N'Enter the Gungeon','2016-04-05'),
(133, N'The House in Fata Morgana','2012-12-27'),
(134, N'Shovel Knight','2014-06-26'),
(135, N'Firewatch','2016-02-09'),
(14, N'Dark Souls II','2014-03-11'),
(136, N'Blasphemous','2019-09-10'),
(48, N'Final Fantasy XIV Online','2013-08-27'),
(137, N'Immortality','2022-08-30'),
(33, N'Resident Evil 6','2012-10-02'),
(33, N'Devil May Cry 3: Dantes Awakening','2005-02-17'),
(12, N'The Last of Us Part I','2022-09-01'),
(138, N'Super Meat Boy','2010-10-20'),
(119, N'Mass Effect Legendary Edition','2021-05-14'),
(139, N'Helltaker','2020-05-11'),
(63, N'Pokémon Sword','2019-11-15'),
(87, N'Crash Bandicoot N. Sane Trilogy','2017-06-30'),
(3, N'Tetris','1989-11-01'),
(140, N'Valorant','2020-06-02'),
(3, N'Super Mario 3D World','2013-11-21'),
(41, N'Uncharted 3: Drakes Deception','2011-11-01'),
(33, N'Phoenix Wright: Ace Attorney - Trials and Tribulations','2006-03-31'),
(141, N'Yume Nikki','2004-06-26'),
(142, N'Max Payne','2001-07-23'),
(143, N'Five Nights at Freddys','2014-08-08'),
(3, N'Donkey Kong Country 2: Diddys Kong Quest','1995-11-21'),
(188, N'Sonic the Hedgehog 3 & Knuckles','1994-10-18'),
(33, N'Resident Evil 2','1998-01-21'),
(189, N'Full Metal Daemon Muramasa','2009-10-30'),
(171, N'Soma','2015-09-21'),
(190, N'The Binding of Isaac: Rebirth','2014-11-04'),
(3, N'Luigis Mansion 3','2019-10-31'),
(191, N'Katamari Damacy Reroll','2018-12-06'),
(3, N'Mario Kart 7','2011-12-02'),
(192, N'Castle Crashers','2008-08-27'),
(193, N'Rain World','2017-03-28'),
(3, N'Mario Party Superstars','2021-10-28'),
(194, N'Bully','2006-10-17'),
(3, N'Mario Kart 64','1996-12-14'),
(48, N'Octopath Traveler II','2023-02-24'),
(195, N'Norco','2022-03-24'),
(33, N'Resident Evil','2002-03-22'),
(109, N'Assassins Creed Odyssey','2018-10-05'),
(2, N'Transistor','2014-05-20'),
(18, N'The Evil Within','2014-10-14'),
(196, N'Metal: Hellsinger','2022-09-15'),
(3, N'Pokémon White','2010-09-18'),
(144, N'Outlast','2013-09-04'),
(145, N'Hitman 3','2021-01-20'),
(146, N'Sable','2021-09-23'),
(27, N'Super Smash Bros. for Wii U','2014-11-21'),
(23, N'Kirbys Adventure','1993-03-23'),
(1, N'Tekken 7','2015-02-18'),
(147, N'Umineko: When They Cry Chiru','2009-09-15'),
(148, N'Kingdom Hearts II Final Mix','2007-03-29'),
(149, N'Superliminal','2019-11-12'),
(150, N'Death Stranding: Directors Cut','2021-09-24'),
(38, N'Persona 4','2008-07-10'),
(151, N'Wordle','2021-06-21'),
(77, N'The Sims 4','2014-09-02'),
(98, N'Far Cry 4','2014-11-18'),
(49, N'Sonic Forces','2017-11-07'),
(152, N'To the Moon','2011-11-01'),
(153, N'Baba is You','2019-03-13'),
(21, N'The Witcher 3: Wild Hunt - Game of the Year Edition','2016-08-29'),
(3, N'Super Smash Bros.','1999-01-21'),
(34, N'Super Mario 64 DS','2004-11-21'),
(154, N'Halo 4','2012-11-06'),
(155, N'Middle-earth: Shadow of Mordor','2014-09-30'),
(33, N'Mega Man 2','1989-06-02'),
(33, N'Phoenix Wright: Ace Attorney Trilogy','2014-04-17'),
(86, N'Infamous: Second Son','2014-03-21'),
(119, N'Star Wars: Knights of the Old Republic','2003-07-15'),
(109, N'No More Heroes 2: Desperate Struggle','2010-01-26'),
(156, N'Kirby Super Star Ultra','2008-09-22'),
(121, N'Flower, Sun, and Rain','2001-05-02'),
(157, N'Katamari Damacy','2004-03-18'),
(49, N'Shadow the Hedgehog','2005-11-15'),
(158, N'Ōkami HD','2012-10-30'),
(159, N'Metroid: Samus Returns','2017-09-15'),
(160, N'Life is Strange: True Colors','2021-09-10'),
(63, N'Pokémon Black Version 2','2012-06-23'),
(3, N'Needy Streamer Overload','2022-01-21'),
(161, N'Borderlands','2009-10-20'),
(5, N'Hollow Knight: Voidheart Edition','2018-09-25'),
(157, N'Klonoa: Door to Phantomile','1997-12-11'),
(154, N'Halo: The Master Chief Collection','2014-11-11'),
(63, N'Pokémon Crystal','2000-12-14'),
(41, N'Uncharted: The Lost Legacy','2017-08-22'),
(33, N'Resident Evil 3: Nemesis','1999-09-22'),
(96, N'Sea of Thieves','2018-03-20'),
(155, N'F.E.A.R.','2005-10-17'),
(161, N'Mafia: Definitive Edition','2020-09-24'),
(48, N'NieR','2010-04-22'),
(197, N'The Walking Dead: Season Two','2013-12-17'),
(48, N'Forspoken','2023-01-24'),
(198, N'Max Payne 2: The Fall of Max Payne','2003-10-14'),
(38, N'Shin Megami Tensei: Devil Summoner - Soul Hackers','1997-11-13'),
(199, N'Dusk','2018-12-10'),
(45, N'The Elder Scrolls III: Morrowind','2002-05-01'),
(200, N'Rollerdrome','2022-08-16'),
(48, N'Final Fantasy XVI','2023-06-22'),
(174, N'Pokémon Sun','2016-11-18'),
(19, N'Yu-Gi-Oh! Master Duel','2022-01-18'),
(201, N'Injustice: Gods Among Us','2013-04-16'),
(202, N'Pac-Man','1980-05-22'),
(203, N'Final Fantasy X/X-2 HD Remaster','2013-12-26'),
(201, N'Mortal Kombat X','2015-04-13'),
(38, N'Shin Megami Tensei: Digital Devil Saga','2004-07-15'),
(204, N'Star Wars: The Force Unleashed','2008-09-16'),
(134, N'Shovel Knight: Treasure Trove','2019-12-09'),
(12, N'Ghost of Tsushima: Directors Cut','2021-08-20'),
(205, N'Donkey Kong Country Returns','2010-11-21'),
(33, N'Street Fighter III: 3rd Strike','1999-05-12'),
(206, N'Return to Monkey Island','2022-09-19'),
(48, N'Deus Ex: Human Revolution','2011-08-23'),
(207, N'Spyro Reignited Trilogy','2018-11-13'),
(208, N'Chicory: A Colorful Tale','2021-06-10'),
(209, N'Sin and Punishment','2000-11-21'),
(36, N'Outer Wilds: Echoes of the Eye','2021-09-28'),
(3, N'New Super Mario Bros. 2','2012-07-28'),
(129, N'Wolfenstein II: The New Colossus','2017-10-26'),
(3, N'PokÃ©mon Diamond','2006-09-28'),
(210, N'Into the Breach','2018-02-27'),
(211, N'Marvel Snap','2022-10-18'),
(48, N'Nier: Automata - Game of the Yorha Edition','2019-02-21'),
(143, N'Five Nights at Freddys 2','2014-11-10'),
(212, N'Mortal Kombat 11','2019-04-22'),
(213, N'Witch on the Holy Night','2022-12-07'),
(214, N'Dying Light 2: Stay Human','2022-02-03'),
(33, N'Asuras Wrath','2012-02-21'),
(215, N'Tales of Berseria','2016-08-18'),
(216, N'Ender Lilies: Quietus of the Knights','2021-06-21'),
(217, N'Moon: Remix RPG Adventure','1997-10-16'),
(109, N'Prince of Persia: The Sands of Time','2003-11-06'),
(109, N'Assassins Creed Syndicate','2015-10-23'),
(25, N'Sunset Overdrive','2014-10-28'),
(150, N'Metal Gear Solid: Peace Walker','2010-04-29'),
(218, N'Code Vein','2019-09-26'),
(29, N'Vagrant Story','2000-02-10'),
(171, N'Amnesia: Rebirth','2010-09-08'),
(33, N'Monster Hunter Rise: Sunbreak','2022-06-29'),
(172, N'Super Mario Maker 2','2019-06-28'),
(58, N'Fire Emblem: The Blazing Blade','2003-04-25'),
(43, N'LEGO Marvel Super Heroes','2013-09-30'),
(173, N'Sonic Colors','2010-11-11'),
(219, N'Mario Strikers: Battle League','2022-06-10'),
(220, N'Limbus Company','2023-02-27'),
(33, N'Resident Evil Village: Winters Expansion','2022-10-28'),
(87, N'Tony Hawks Pro Skater 1+2','2020-09-04'),
(221, N'Need for Speed: Unbound','2022-11-29'),
(222, N'Zero Escape: Zero Time Dilemma','2016-06-28'),
(48, N'Deus Ex: Mankind Divided','2016-08-23'),
(223, N'Guitar Hero III: Legends of Rock','2007-10-28'),
(224, N'Sid Meiers Civilization VI','2016-10-20'),
(225, N'Nioh 2','2020-03-13'),
(103, N'Gears of War','2006-11-07'),
(81, N'Final Fantasy Tactics','1997-06-20'),
(4, N'Deltarune','2007-10-28'),
(157, N'Tekken 3','1997-03-22'),
(226, N'Far Cry 6','2021-10-07'),
(12, N'Horizon Zero Dawn: Complete Edition','2017-12-06'),
(49, N'Persona 4 Golden','2020-06-13'),
(150, N'Death Stranding 2','2007-10-28'),
(22, N'Xenosaga Episode I: Der Wille zur Macht','2002-02-28'),
(227, N'Everhood','2021-03-03'),
(228, N'Dont Starve Together','2016-04-21'),
(109, N'South Park: The Fractured But Whole','2017-10-17'),
(86, N'God of War III: Remastered','2015-07-14'),
(3, N'Pokémon Ruby','2002-11-21'),
(3, N'Fire Emblem: The Sacred Stones','2004-10-07'),
(220, N'Library of Ruina','2021-08-10'),
(41, N'Uncharted: The Nathan Drake Collection','2015-10-07'),
(49, N'Persona 3 Portable','2023-01-19'),
(2, N'Pyre','2017-07-25'),
(229, N'Paladins','2017-05-02'),
(230, N'Dead Space 3','2013-02-05'),
(33, N'Devil May Cry HD Collection','2012-03-22'),
(9, N'Bayonetta Origins: Cereza and the Lost Demon','2023-03-17'),
(14, N'Armored Core','1997-07-10'),
(231, N'Persona 4 Arena Ultimax','2013-11-28'),
(232, N'Wanted: Dead','2023-02-14'),
(3, N'Luigis Mansion: Dark Moon','2013-03-20'),
(97, N'Gorogoa','2017-12-13'),
(48, N'Valkyrie Elysium','2022-09-28'),
(19, N'Castlevania: Order of Ecclesia','2008-10-21'),
(233, N'Deadly Premonition','2010-02-23'),
(234, N'LEGO Batman 2: DC Super Heroes','2012-06-19'),
(235, N'Lunistice','2022-11-10'),
(49, N'Sonic Advance','2001-12-20'),
(236, N'Metal Slug','1996-01-24'),
(237, N'Just Cause 3','2015-11-30'),
(19, N'Suikoden II','1998-12-17'),
(238, N'LittleBigPlanet','2008-10-27'),
(3, N'EarthBound Beginnings','2015-06-14'),
(54, N'Wario Land 3','2000-03-21'),
(239, N'Faith: The Unholy Trinity','2022-10-21'),
(157, N'Tales of Symphonia','2003-08-29'),
(48, N'Final Fantasy VII','2012-08-14'),
(1, N'The Dark Pictures Anthology: Man of Medan','2019-08-29'),
(240, N'Saya no Uta','2003-12-26'),
(241, N'River City Girls','2019-09-04'),
(49, N'Sonic Origins','2022-06-22'),
(242, N'Kuru Kuru Kururin','2001-03-21'),
(3, N'Pikmin 2','2004-04-29'),
(243, N'Wonderful Everyday: Down the Rabbit-Hole','2010-03-26'),
(3, N'Paper Mario: The Origami King','2020-07-17'),
(96, N'Conkers Bad Fur Day','2001-03-05'),
(3, N'Fire Emblem: Radiant Dawn','2007-02-22'),
(77, N'Need for Speed: Heat','2019-11-08'),
(244, N'Skate 3','2010-05-11'),
(245, N'Braid','2008-08-06'),
(246, N'Metro 2033','2010-03-16'),
(247, N'Another Pokémon Game','2023-02-15');





/******************************************************************************/

MERGE GameTrack.Game T
USING @GameStaging S ON S.GameID = T.GameID
WHEN MATCHED AND S.[Name] <> T.[Name] OR T.PublisherID <> S.PublisherID THEN
   UPDATE
   SET PublisherID = S.PublisherID,
   [Name] = S.[Name],
   ReleaseDate = S.ReleaseDate

WHEN NOT MATCHED THEN
   INSERT(PublisherID, [Name], ReleaseDate)
   VALUES(S.PublisherID,S.[Name], S.ReleaseDate);
