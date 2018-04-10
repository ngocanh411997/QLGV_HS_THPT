---- Chỉnh sửa ngày 12/03/2018
--USE master
--DROP DATABASE QLGV_HS_THPT
-- 27/2/2018
Create database QLGV_HS_THPT
go
use QLGV_HS_THPT
go
create table MonHoc(
MaMon VARCHAR(10) primary key,
TenMon nvarchar(50),
Khoi VARCHAR(10))
go
create table GiaoVien(
MaGV VARCHAR(10) primary key,
TenGV nvarchar(50),
GioiTinh bit,
NgaySinh date,
SDT varchar(11),
DiaChi nvarchar(150),
Luong BIGINT,
MaMon varchar(10) references MonHoc(MaMon))
go
create table Lop(
MaLop varchar(10) primary key,
TenLop nvarchar(50),
MaGVCN varchar(10) references GiaoVien(MaGV))
go
create table HocSinh(
MaHS varchar(10) PRIMARY KEY,
TenHS nvarchar(50),
GioiTinh bit,
NgaySinh date,
DiaChi nvarchar(150),
DanToc nvarchar(50),
TonGiao nvarchar(50),
MaLop varchar(10) references Lop(MaLop))

-- Sửa bổ sung: 11/03/2018
go
create table ChuNhiem(
MaGV varchar(10) references GiaoVien(MaGV),
MaLop varchar(10) references Lop(MaLop),
NamHoc varchar(4),
Primary key(MaGV,MaLop))

go
create table Diem(
MaHS varchar(10) references dbo.HocSinh(MaHS),
MaMon varchar(10) references MonHoc(MaMon),
DiemMieng FLOAT,
Diem15ph FLOAT,
Diem1Tiet FLOAT,
DiemHocKy FLOAT,
Primary key (MaHS, MaMon))

create table NguoiDung(
TaiKhoan varchar(50),
MatKhau varchar(50) 
)


-----------------
-- Sửa CSDL
GO
ALTER TABLE dbo.HocSinh
ALTER COLUMN GioiTinh NVARCHAR(5)

GO
ALTER TABLE dbo.GiaoVien
ALTER COLUMN GioiTinh NVARCHAR(5)