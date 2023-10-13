DROP DATABASE QLGAME
GO

CREATE DATABASE QLGAME
GO

USE QLGAME
GO

CREATE TABLE KHACHHANG(
	MaKH char(5) NOT NULL,
	Hoten nvarchar(30),
	NgSinh date,
	CCCD char(12),
	SDT char(10),
	Email char(30),
	Diachi nvarchar(50),
	Quoctich varchar(20),
	TenTK char(20),
	PassTK char(16),
);

CREATE TABLE THUVIEN(
	MaKH char(5),
	MaGAME char(10),
);

CREATE TABLE GAME(
	MaGAME char(10) NOT NULL,
	Tengame nvarchar(50),
	Chitiet nvarchar(max),
	Gia int,
);

CREATE TABLE DANHGIA(
	MaDG char(10),
	Tieude nvarchar(50),
	Noidung nvarchar(max),
	Rating int,
);

CREATE TABLE NHAXUATBAN(
	MaNXB char(10),
	TenNXB nvarchar(50),
);