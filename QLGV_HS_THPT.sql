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

-- Sửa bổ sung: 11/03/2018
go
create table ChuNhiem(
MaGV char(10) references GiaoVien(MaGV),
MaLop char(10) references Lop(MaLop),
NamHoc varchar(4),
Primary key(MaGV,MaLop))
go
create table PhongHoc(
MaPhong char(10) primary key,
SoPhong varchar(10),
SoChoToiDa int)
go
create table Phong_Lop(
MaPhong char(10) references PhongHoc(MaPhong),
MaLop char(10) references Lop(MaLop),
HocKy_NamHoc varchar(50),
KipHoc varchar(5)
Primary key (MaPhong, MaLop))
go
create table Diem(
MaHS char(10) references HocSinh(MaHS),
MaMon char(10) references MonHoc(MaMon),
DiemMieng char(5),
Diem15ph char(5),
Diem1Tiet char(5),
DiemHocKy char(5),
Primary key (MaHS, MaMon))
-----------------
---- Thủ Tục ----
go
Create Proc ThemHS(@Ma char(10), @Ten varchar(50), @GT char(3), @NgaySinh date, @DiaChi varchar(50), @DanToc varchar(50), @TonGiao varchar(50), @MaLop char(10))
As
Begin
insert into HocSinh(MaHS, TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,MaLop)
values (@Ma, @Ten, @GT, @NgaySinh, @DiaChi, @DanToc, @TonGiao, @MaLop)
end
go
Create Proc SuaHS(@Ma char(10),  @Ten varchar(50), @GT char(3), @NgaySinh date, @DiaChi varchar(50), @DanToc varchar(50), @TonGiao varchar(50), @MaLop char(10))
As
Begin
Update HocSinh
Set @Ma = MaHS, @Ten = TenHS, @GT = GioiTinh, @NgaySinh = NgaySinh, @DiaChi = DiaChi, @DanToc = DanToc, @TonGiao = TonGiao, @MaLop = MaLop
end
go
/* Create Proc XoaHS (@Ma char(10),  @Ten varchar(50), @GT char(3), @NgaySinh date, @DiaChi varchar(50), @DanToc varchar(50), @TonGiao varchar(50), @MaLop char(10))
As
Begin
Delete MaHS , TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, MaLop
Where @Ma = MaHS, @Ten = TenHS, @GT = GioiTinh, @NgaySinh = NgaySinh, @DiaChi= DiaChi, @DanToc = DanToc, @TonGiao = TonGiao, @MaLop = MaLop
end */

-- GV
Create proc ThemGV(@Ma char(10), @Ten varchar(50), @GT char(3), @NgaySinh date, @SDT char(11), @DiaChi varchar(50), @Luong money, @MaMon char(10))
As 
Begin
Insert into GiaoVien(MaGV, TenGV, GioiTinh, NgaySinh,SDT,DiaChi,Luong,MaMon)
Values (@Ma, @Ten, @GT, @NgaySinh, @SDT, @DiaChi, @Luong, @MaMon)
end





