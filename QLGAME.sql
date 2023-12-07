USE master
GO

DROP DATABASE QLGame
GO

CREATE DATABASE QLGame
GO

USE QLGame
GO

SET DATEFORMAT DMY
GO

CREATE TABLE TaiKhoan(
	MaTK varchar(10) NOT NULL,
	TenTK varchar(50),
	MatKhau varchar(50),
	NgaySinh datetime,
	SDT varchar(11),
	Email varchar(50),
	DiaChi nvarchar(50),
	Quyen varchar(50), --("admin", "customer")
	SoDu int,
);

CREATE TABLE ThuVien(
	MaTV varchar(10) NOT NULL,
	MaTK varchar(10)NOT NULL,
	MaGame varchar(10) NOT NULL,
	NgayMua datetime,
);

CREATE TABLE Game(
	MaGame varchar(10) NOT NULL,
	TenGame nvarchar(50),
	ChiTiet nvarchar(max),	
	DonGia int,
	MaNXB varchar(10),
	MaLoai varchar(20)
);

CREATE TABLE TheLoai(
	MaLoai varchar(20) NOT NULL primary key,
	TenLoai nvarchar(50),
);

CREATE TABLE NhaXuatBan(
	MaNXB varchar(10) NOT NULL,
	TenNXB nvarchar(50),
);

----------------------------------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE TaiKhoan
	ADD CONSTRAINT PK_KH PRIMARY KEY(MaTK)
GO

ALTER TABLE NhaXuatBan
	ADD CONSTRAINT PK_NXB PRIMARY KEY(MaNXB)
GO

ALTER TABLE Game
	ADD CONSTRAINT PK_GAME PRIMARY KEY(MaGame),
		CONSTRAINT FK_GAME_NXB FOREIGN KEY(MaNXB) REFERENCES NhaXuatBan(MaNXB),
		CONSTRAINT FK_GAME_TheLoai FOREIGN KEY(MaLoai) REFERENCES TheLoai(MaLoai)
GO


ALTER TABLE ThuVien
	ADD CONSTRAINT PK_ThuVien PRIMARY KEY(MaTV),
		CONSTRAINT FK_ThuVien_TK FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK),
		CONSTRAINT FK_ThuVien_GAME FOREIGN KEY (MaGAME) REFERENCES Game(MaGAME)
GO



----------------------------------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO TaiKhoan VALUES
('TK01', N'ChauHoangDuy', 'admin123', '25/12/2002',  '0708575764', 'satthuid334@gmail.com', 'HCM', 'admin',0),
('TK02', N'NguyenThanhHa', 'Ha123', '20/12/1999',  '0948483839', 'ThanhHa@gmail.com', 'HCM', 'customer',0),
('TK03', N'TranThanhAn', 'An123', '20/1/2001',  '0977646567', 'ThanhAn23@gmail.com', 'HCM', 'customer',0)

INSERT INTO NhaXuatBan VALUES
('NXB001', N'Valve'),
('NXB002', N'Rockstar Games'),
('NXB003', N'Activision'),
('NXB004', N'Monomi Park'),
('NXB005', N'Xbox Game Studios')

INSERT INTO TheLoai VALUES
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

INSERT INTO Game VALUES
('G001', N'Counter-Strike 2', N'For over two decades, Counter-Strike has offered an elite competitive experience, one shaped by millions of players from across the globe. And now the next chapter in the CS story is about to begin. This is Counter-Strike 2.', 375000, 'NXB001', 'TL01'),
('G002', N'Left 4 Dead 2', N'Set in the zombie apocalypse, Left 4 Dead 2 (L4D2) is the highly anticipated sequel to the award-winning Left 4 Dead, the #1 co-op game of 2008. This co-operative action horror FPS takes you and your friends through the cities, swamps and cemeteries of the Deep South, from Savannah to New Orleans across five expansive campaigns.', 142000, 'NXB001', 'TL10'),
('G003', N'Red Dead Redemption 2', N'Winner of over 175 Game of the Year Awards and recipient of over 250 perfect scores, RDR2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age. Also includes access to the shared living world of Red Dead Online.', 1000000, 'NXB002', 'TL02'),
('G004', N'Grand Theft Auto V', N'Grand Theft Auto V for PC offers players the option to explore the award-winning world of Los Santos and Blaine County in resolutions of up to 4k and beyond, as well as the chance to experience the game running at 60 frames per second.', 450000, 'NXB002', 'TL02'),
('G005', N'Call of Duty®: Modern Warfare® III', N'Call of Duty®: Modern Warfare® III is the direct sequel to the record-breaking Call of Duty®: Modern Warfare® II. Captain Price and Task Force 141 face off against the ultimate threat. The ultranationalist war criminal Vladimir Makarov is extending his grasp across the world causing Task Force 141 to fight like never before.', 1800000, 'NXB003', 'TL07'),
('G006', N'Call of Duty®: Modern Warfare® II', N'Call of Duty®: Modern Warfare® II drops players into an unprecedented global conflict that features the return of the iconic Operators of Task Force 141. From small-scale, high-stakes infiltration tactical ops to highly classified missions, players will deploy alongside friends in a truly immersive experience.', 1800000, 'NXB003', 'TL01'),
('G007', N'Slime Rancher', N'Slime Rancher is the tale of Beatrix LeBeau, a plucky, young rancher who sets out for a life a thousand light years away from Earth on the ‘Far, Far Range’ where she tries her hand at making a living wrangling slimes.', 250000, 'NXB004', 'tl04'),
('G008', N'Slime Rancher 2', N'Continue the adventures of Beatrix LeBeau as she journeys across the Slime Sea to Rainbow Island, a land brimming with ancient mysteries, and bursting with wiggly, new slimes to wrangle in this sequel to the smash-hit, Slime Rancher.', 325000, 'NXB004', 'TL04'),
('G009', N'Forza Horizon 5', N'Your Ultimate Horizon Adventure awaits! Explore the vibrant open world landscapes of Mexico with limitless, fun driving action in the world’s greatest cars. Conquer the rugged Sierra Nueva in the ultimate Horizon Rally experience. Requires Forza Horizon 5 game, expansion sold separately.', 990000, 'NXB005', 'TL09'),
('G010', N'Grounded', N'The world is a vast, beautiful and dangerous place – especially when you have been shrunk to the size of an ant. Can you thrive alongside the hordes of giant insects, fighting to survive the perils of the backyard?', 650000, 'NXB005', 'TL10')