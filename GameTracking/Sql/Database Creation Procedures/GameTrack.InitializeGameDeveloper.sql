
    DECLARE @GameDeveloperStaging TABLE
    (
        GameID INT NOT NULL,
        DeveloperID INT NOT NULL
    );

    INSERT @GameDeveloperStaging( GameID,DeveloperID) /************************* CHANGED WEBSITE TO EMAIL */
    VALUES
   (1,1),
(3,2),
(4,3),
(7,4),
(8,5),
(10,6),
(11,7),
(12,8),
(13,9),
(14,10),
(15,11),
(16,12),
(17,13),
(18,14),
(21,15),
(22,16),
(23,17),
(27,18),
(30,19),
(33,20),
(36,21),
(37,22),
(39,23),
(40,24),
(43,25),
(45,26),
(49,27),
(51,28),
(52,29),
(53,30),
(54,31),
(59,32),
(61,33),
(62,34),
(63,35),
(66,36),
(70,37),
(72,38),
(73,39),
(74,40),
(76,41),
(80,42),
(84,43),
(86,44),
(89,45),
(90,46),
(91,47),
(93,48),
(95,49),
(96,50),
(97,51),
(98,52),
(101,53),
(104,54),
(105,55),
(106,56),
(110,57),
(111,58),
(114,59),
(123,60),
(124,61),
(125,62),
(126,63),
(130,64),
(131,65),
(138,66),
(141,67),
(142,68),
(143,69),
(148,70),
(151,71),
(154,72),
(155,73),
(158,74),
(162,75),
(168,76),
(171,77),
(174,78),
(176,79),
(177,80),
(178,81),
(180,82),
(182,83),
(184,84),
(186,85),
(188,86),
(189,87),
(191,88),
(192,89),
(193,90),
(200,91);




MERGE GameTrack.GameDeveloper T
USING @GameDeveloperStaging S ON S.GameID = T.GameID
WHEN MATCHED AND S.DeveloperID <> T.DeveloperID THEN
   UPDATE
   SET DeveloperID = S.DeveloperID
WHEN NOT MATCHED THEN
   INSERT(GameID,DeveloperID)
   VALUES(S.GameID,S.DeveloperID);

