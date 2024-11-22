CREATE PROCEDURE GameTrack.InitializeProfile
AS
DECLARE @ProfileStaging TABLE
(
	ProfileID INT NOT NULL IDENTITY(1,1),
	Username NVARCHAR(32) NOT NULL,
	HashedPassword NVARCHAR(32) NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

/***************************** Modify values here *****************************/

INSERT @ProfileStaging(Username,HashedPassword) 
VALUES
	(N'ipsum.dolor.sit@yahoo.ca', N'EPU36NMX5LK'),
(N'fusce.dolor.quam@google.com', N'CZK72GKC2AE'),
(N'tortor.dictum@google.com', N'MGL56NUQ0ES'),
(N'amet.luctus@protonmail.couk', N'TUG74RDU2BZ'),
(N'tempor.bibendum@google.net', N'JAH62PGM4DX'),
(N'id.magna@yahoo.edu', N'TYA24LJY6TC'),
(N'enim.nec.tempus@yahoo.ca', N'ZLB84VGJ1YR'),
(N'purus.ac@yahoo.ca', N'SUV85DPT7NS'),
(N'facilisis.suspendisse@yahoo.couk', N'YBP57BKU6FE'),
(N'pellentesque@outlook.edu', N'ZQV34XJL9YB'),
(N'pede.blandit@yahoo.com', N'CKY83DOO7SH'),
(N'cursus.luctus.ipsum@aol.edu', N'GCU83LWR8ZI'),
(N'fringilla.mi@icloud.ca', N'ADS27IMZ2JH'),
(N'a.magna.lorem@google.org', N'SAU96DIR5YH'),
(N'nulla@icloud.com', N'AMF25GVJ9SQ'),
(N'lectus.sit@yahoo.net', N'MBH34JZV8TX'),
(N'elit.pede.malesuada@hotmail.org', N'STO55EVN8MC'),
(N'amet@google.com', N'GSX99WNL7UB'),
(N'turpis.nec@outlook.edu', N'PER65LGQ2XD'),
(N'vulputate.lacus@icloud.edu', N'PCB38TZY3OG'),
(N'donec.non.justo@icloud.com', N'MPW94MVR1FI'),
(N'scelerisque.neque@outlook.org', N'UKD97LTG1LD'),
(N'dolor@aol.net', N'UJV24NPQ0JM'),
(N'et.euismod@hotmail.edu', N'DMX48TXM7DF'),
(N'nulla.dignissim@icloud.edu', N'SEC61AGW2OF'),
(N'est.vitae.sodales@hotmail.org', N'VTJ50RWI1BH'),
(N'mauris@google.edu', N'SYU93RGV9MP'),
(N'eu.metus@outlook.org', N'PLS77JVE5HQ'),
(N'diam@icloud.ca', N'RSU52BSR2LC'),
(N'ultrices.posuere@hotmail.edu', N'JRH37WJN2FV'),
(N'gravida@aol.couk', N'FSB18UHX3JC'),
(N'mi@yahoo.edu', N'PHK71JPO8EX'),
(N'ac@icloud.com', N'VMV07JML3RO'),
(N'mauris.blandit.enim@outlook.edu', N'GCN08PSV4KD'),
(N'sed.eu.nibh@yahoo.org', N'MHB81FUN6OX'),
(N'enim.etiam@google.edu', N'LNI84QBB0JW'),
(N'in.tincidunt@protonmail.org', N'RTW08PJJ9OU'),
(N'augue@google.com', N'FLC14CCP7DE'),
(N'purus.accumsan@google.net', N'MMU08ICL7IM'),
(N'gravida.mauris.ut@hotmail.net', N'XTN56TSU8ZR'),
(N'facilisis.magna@protonmail.com', N'YUG27LVD0YL'),
(N'feugiat.placerat@google.couk', N'GGV54QFL7FE'),
(N'et.eros.proin@outlook.org', N'ZTZ59OLD7SC'),
(N'turpis.in@google.org', N'HSB24MQD1AW'),
(N'neque.in.ornare@outlook.ca', N'BKT21YLP7TR'),
(N'luctus.et@outlook.ca', N'EGN38DKL5GZ'),
(N'mattis@google.ca', N'SFS77JRC2DN'),
(N'pellentesque@hotmail.net', N'DFO22OKE2UW'),
(N'nam.ac@aol.com', N'BED68SXV1TQ'),
(N'vitae.sodales.nisi@icloud.net', N'EZN88VDW8PS'),
(N'arcu@outlook.couk', N'YOE45QQP2FH'),
(N'taciti.sociosqu@outlook.net', N'IGV75LRQ5ZW'),
(N'sit.amet@yahoo.ca', N'YMF65IXS7MO'),
(N'non.sapien.molestie@hotmail.com', N'MTG36JHV3PT'),
(N'pellentesque.ultricies@yahoo.com', N'SAQ32TJD1HS'),
(N'sem.ut@google.net', N'SBN82TEN3QU'),
(N'volutpat.nulla@protonmail.couk', N'DWI25OBP9RD'),
(N'phasellus.libero@hotmail.ca', N'WKJ58PHG7SU'),
(N'in.consectetuer@aol.ca', N'GQN49FRN0OO'),
(N'ligula.aenean@yahoo.couk', N'NXQ76QWO2PB'),
(N'neque.non@google.couk', N'MWQ97LYJ8WH'),
(N'nec.ligula@protonmail.edu', N'EJK87TLJ3YQ'),
(N'orci.in@protonmail.ca', N'HLG41MRU1NR'),
(N'condimentum@icloud.ca', N'PYI46JUR7UU'),
(N'gravida@aol.edu', N'BNR85FKF8UR'),
(N'non.lacinia@protonmail.couk', N'LQE72JMV4PK'),
(N'praesent.eu@google.couk', N'AOF79JCX2KQ'),
(N'felis.adipiscing@icloud.ca', N'DGQ66XLW4DV'),
(N'neque.venenatis@protonmail.net', N'FBN53SWF6MI'),
(N'venenatis.vel@protonmail.couk', N'QOB45FKV7OF'),
(N'cras.lorem@protonmail.com', N'CQT75LNO5XO'),
(N'elit.pharetra@google.couk', N'BPC46PPX2RA'),
(N'ultrices.posuere@hotmail.ca', N'BOV75JBI9JN'),
(N'nunc.ullamcorper@aol.couk', N'LDT56RBI5VV'),
(N'eleifend.nunc@aol.ca', N'VJB76EWG8PB'),
(N'lacus.cras@aol.edu', N'EKL98RIN7JX'),
(N'sodales.nisi@icloud.edu', N'RXH26XTX9MW'),
(N'vel.turpis.aliquam@hotmail.couk', N'XFV13XPG8DO'),
(N'vestibulum@icloud.com', N'PUY18GFU2MV'),
(N'scelerisque.neque.sed@google.ca', N'NHT48JEC9UR'),
(N'lectus@protonmail.edu', N'GJI73YGO2BP'),
(N'mauris@protonmail.org', N'HWK25OEQ5OR'),
(N'suspendisse@icloud.couk', N'MQY65NQO2IF'),
(N'quis@protonmail.edu', N'DEO81OFH1BW'),
(N'dui@hotmail.net', N'DEI74PGF2KW'),
(N'accumsan.convallis@yahoo.net', N'IVY81ANK7BL'),
(N'dictum.ultricies@aol.edu', N'PDK13MHT0HK'),
(N'orci.ut@hotmail.org', N'SRC37IJR8QB'),
(N'tristique.senectus@aol.edu', N'XXB34AWP5DJ'),
(N'montes@hotmail.org', N'BQO28XBC9KC'),
(N'velit.eget.laoreet@yahoo.edu', N'SYD62LZE7DX'),
(N'egestas@google.net', N'PGE32ORL2TE'),
(N'consequat@outlook.edu', N'TIS29TRN1DL'),
(N'fermentum.risus.at@hotmail.ca', N'SWP81JXN2CX'),
(N'lorem.sit.amet@icloud.org', N'ZMT38POI8AB'),
(N'nulla@outlook.org', N'BCH41QSR3HR'),
(N'fusce.fermentum@yahoo.couk', N'OOK63TJB5IR'),
(N'praesent.eu@icloud.ca', N'NXX73OFH4CB'),
(N'ut@outlook.org', N'HDU30BYI6VH'),
(N'duis@outlook.ca', N'IHJ58ECR4HD');



/******************************************************************************/

MERGE GameTrack.[Profile] T
USING @ProfileStaging S ON S.ReviewID = T.ReviewID
WHEN MATCHED AND S.Username <> T.Username THEN
   UPDATE
   SET Username = S.Username,
   HashedPassword = S.HashedPassword
WHEN NOT MATCHED THEN
   INSERT(ReviewID, Username,HashedPassword)
   VALUES(S.ReviewID,S.Username,S.HashedPassword);
