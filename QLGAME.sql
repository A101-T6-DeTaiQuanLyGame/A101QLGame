USE master
GO

DROP DATABASE QLGAME
GO

CREATE DATABASE QLGAME
GO

USE QLGAME
GO

SET DATEFORMAT DMY
GO

CREATE TABLE KHACHHANG(
	MaKH char(5) NOT NULL,
	Hoten nvarchar(30),
	NgSinh date,
	CCCD char(12),
	SDT char(10),
	Email char(30),
	Diachi nvarchar(50),
	Quoctich nvarchar(20),
	TenTK char(20),
	PassTK char(16),
);

CREATE TABLE THUVIEN(
	MaTV char(5) NOT NULL,
	MaKH char(5) NOT NULL,
	MaGAME char(10) NOT NULL,
	NgayMua date,
);

CREATE TABLE GAME(
	MaGAME char(10) NOT NULL,
	Tengame nvarchar(50),
	Chitiet nvarchar(max),
	Gia int,
	MaNXB char(10),
);

CREATE TABLE DSLOAIGAME(
	MaGAME char(10) NOT NULL,
	MaLoai char(5) NOT NULL,
);

CREATE TABLE THELOAI(
	MaLoai char(5) NOT NULL,
	Ten nvarchar(30),
);

CREATE TABLE DANHGIA(
	MaDG char(10) NOT NULL,
	MaKH char(5) NOT NULL,
	MaGAME char(10) NOT NULL,
	Tieude nvarchar(50),
	Noidung nvarchar(max),
	Rating int,
	NgayDG date,
);

CREATE TABLE NHAXUATBAN(
	MaNXB char(10) NOT NULL,
	TenNXB nvarchar(50),
);

----------------------------------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE KHACHHANG
	ADD CONSTRAINT PK_KH PRIMARY KEY(MaKH)
GO

ALTER TABLE NHAXUATBAN
	ADD CONSTRAINT PK_NXB PRIMARY KEY(MaNXB)
GO

ALTER TABLE THELOAI
	ADD CONSTRAINT PK_THELOAI PRIMARY KEY(MaLoai)
GO

ALTER TABLE GAME
	ADD CONSTRAINT PK_GAME PRIMARY KEY(MaGAME),
		CONSTRAINT FK_GAME_NXB FOREIGN KEY(MaNXB) REFERENCES NHAXUATBAN(MaNXB)
GO

ALTER TABLE THUVIEN
	ADD CONSTRAINT PK_THUVIEN PRIMARY KEY(MaTV, MaKH, MaGAME),
		CONSTRAINT FK_THUVIEN_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
		CONSTRAINT FK_THUVIEN_GAME FOREIGN KEY (MaGAME) REFERENCES GAME(MaGAME)
GO

ALTER TABLE DANHGIA
	ADD CONSTRAINT PK_DG PRIMARY KEY(MaDG, MaKH, MaGAME),
		CONSTRAINT FK_DG_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
		CONSTRAINT FK_DG_GAME FOREIGN KEY (MaGAME) REFERENCES GAME(MaGAME)
GO

ALTER TABLE DSLOAIGAME
	ADD CONSTRAINT PK_DSLOAI PRIMARY KEY (MaGAME, MaLoai),
		CONSTRAINT FK_DSLOAI_GAME FOREIGN KEY (MaGAME) REFERENCES GAME(MaGAME),
		CONSTRAINT FK_DSLOAI_THELOAI FOREIGN KEY (MaLoai) REFERENCES THELOAI(MaLoai)
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO KHACHHANG VALUES
('ADMIN', N'Châu Hoàng Duy', '25/12/2002', '079202016327', '0708575764', 'satthuid334@gmail.com', '', N'Việt Nam', 'admin', 'admin123')

INSERT INTO NHAXUATBAN VALUES
('NXB001', N'Valve'),
('NXB002', N'Rockstar Games'),
('NXB003', N'Activision'),
('NXB004', N'Monomi Park'),
('NXB005', N'Xbox Game Studios')

INSERT INTO GAME VALUES
('G001', N'Counter-Strike 2', N'For over two decades, Counter-Strike has offered an elite competitive experience, one shaped by millions of players from across the globe. And now the next chapter in the CS story is about to begin. This is Counter-Strike 2.', 375000, 'NXB001'),
('G002', N'Left 4 Dead 2', N'Set in the zombie apocalypse, Left 4 Dead 2 (L4D2) is the highly anticipated sequel to the award-winning Left 4 Dead, the #1 co-op game of 2008. This co-operative action horror FPS takes you and your friends through the cities, swamps and cemeteries of the Deep South, from Savannah to New Orleans across five expansive campaigns.', 142000, 'NXB001'),
('G003', N'Red Dead Redemption 2', N'Winner of over 175 Game of the Year Awards and recipient of over 250 perfect scores, RDR2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age. Also includes access to the shared living world of Red Dead Online.', 1000000, 'NXB002'),
('G004', N'Grand Theft Auto V', N'Grand Theft Auto V for PC offers players the option to explore the award-winning world of Los Santos and Blaine County in resolutions of up to 4k and beyond, as well as the chance to experience the game running at 60 frames per second.', 450000, 'NXB002'),
('G005', N'Call of Duty®: Modern Warfare® III', N'Call of Duty®: Modern Warfare® III is the direct sequel to the record-breaking Call of Duty®: Modern Warfare® II. Captain Price and Task Force 141 face off against the ultimate threat. The ultranationalist war criminal Vladimir Makarov is extending his grasp across the world causing Task Force 141 to fight like never before.', 1800000, 'NXB003'),
('G006', N'Call of Duty®: Modern Warfare® II', N'Call of Duty®: Modern Warfare® II drops players into an unprecedented global conflict that features the return of the iconic Operators of Task Force 141. From small-scale, high-stakes infiltration tactical ops to highly classified missions, players will deploy alongside friends in a truly immersive experience.', 1800000, 'NXB003'),
('G007', N'Slime Rancher', N'Slime Rancher is the tale of Beatrix LeBeau, a plucky, young rancher who sets out for a life a thousand light years away from Earth on the ‘Far, Far Range’ where she tries her hand at making a living wrangling slimes.', 250000, 'NXB004'),
('G008', N'Slime Rancher 2', N'Continue the adventures of Beatrix LeBeau as she journeys across the Slime Sea to Rainbow Island, a land brimming with ancient mysteries, and bursting with wiggly, new slimes to wrangle in this sequel to the smash-hit, Slime Rancher.', 325000, 'NXB004'),
('G009', N'Forza Horizon 5', N'Your Ultimate Horizon Adventure awaits! Explore the vibrant open world landscapes of Mexico with limitless, fun driving action in the world’s greatest cars. Conquer the rugged Sierra Nueva in the ultimate Horizon Rally experience. Requires Forza Horizon 5 game, expansion sold separately.', 990000, 'NXB005'),
('G010', N'Grounded', N'The world is a vast, beautiful and dangerous place – especially when you have been shrunk to the size of an ant. Can you thrive alongside the hordes of giant insects, fighting to survive the perils of the backyard?', 650000, 'NXB005')

INSERT INTO THELOAI VALUES
('TL01', N'Action'),
('TL02', N'Adventure'),
('TL03', N'Strategy'),
('TL04', N'Simulation'),
('TL05', N'RPG'),
('TL06', N'Sports'),
('TL07', N'Shooter'),
('TL08', N'Puzzle'),
('TL09', N'Racing'),
('TL10', N'Horror')

INSERT INTO DSLOAIGAME VALUES
('G001', 'TL01'),
('G001', 'TL07'),
('G002', 'TL01'),
('G002', 'TL10'),
('G002', 'TL07'),
('G003', 'TL02'),
('G003', 'TL01'),
('G003', 'TL07'),
('G004', 'TL02'),
('G004', 'TL04'),
('G004', 'TL09'),
('G005', 'TL01'),
('G005', 'TL07'),
('G006', 'TL01'),
('G006', 'TL07'),
('G007', 'TL02'),
('G007', 'TL04'),
('G008', 'TL02'),
('G008', 'TL04'),
('G009', 'TL02'),
('G009', 'TL09'),
('G010', 'TL02'),
('G010', 'TL10')

---------------------------------------------------------------
SELECT G.TenGame, G.Gia, N.TenNXB, STRING_AGG(TL.Ten, ', ') AS CombinedTen
FROM GAME G
JOIN NHAXUATBAN N ON G.MaNXB = N.MaNXB
JOIN DSLOAIGAME L ON G.MaGAME = L.MaGAME
JOIN THELOAI TL ON L.MaLoai = TL.MaLoai
GROUP BY G.TenGame, G.Gia, N.TenNXB;