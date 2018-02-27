-- 27/2/2018
Create database QLGV_HS_THPT
go
use QLGV_HS_THPT
go
create table MonHoc(
MaMon char(10) primary key,
TenMon varchar(50))
go
create table GiaoVien(
MaGV char(10) primary key,
TenGV varchar(50),
GioiTinh char(3),
NgaySinh date,
SDT char(11),
DiaChi varchar(50),
Luong money,
MaMon char(10) references MonHoc(MaMon))
go
create table Lop(
MaLop char(10) primary key,
TenLop varchar(50),
MaGVCN char(10) references GiaoVien(MaGV))
go
create table HocSinh(
MaHS char(10),
TenHS varchar(50),
GioiTinh char(3),
NgaySinh date,
DiaChi varchar(50),
DanToc varchar(50),
TonGiao varchar(50),
MaLop char(10) references Lop(MaLop))
go
Create table GiangDay(
MaGV char(10) references GiaoVien(MaGV),
MaLop char(10) references Lop(MaLop),
Thu char(20),
TietDay int,
primary key (Thu,TietDay))

