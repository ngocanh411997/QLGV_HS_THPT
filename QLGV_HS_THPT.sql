---- Chỉnh sửa ngày 12/03/2018
USE master
DROP DATABASE QLGV_HS_THPT
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
-----------------

---- Thủ Tục ----
go
Create Proc ThemHS(@Ma char(10), @Ten varchar(50), @GT char(3), @NgaySinh date, @DiaChi varchar(50), @DanToc varchar(50), @TonGiao varchar(50), @MaLop char(10))
As
Begin
insert into HocSinh(MaHS, TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,MaLop)
values (@Ma, @Ten, @GT, @NgaySinh, @DiaChi, @DanToc, @TonGiao, @MaLop)
END
-- sửa học sinh
go
ALTER Proc SuaHS(@Ma char(10),  @Ten varchar(50), @GT char(3), @NgaySinh date, @DiaChi varchar(50), @DanToc varchar(50), @TonGiao varchar(50), @MaLop char(10))
As
Begin
Update HocSinh
Set MaHS=@Ma,TenHS=@Ten,GioiTinh=@GT,NgaySinh=@NgaySinh,DiaChi=@DiaChi,DanToc=@DanToc,TonGiao=@TonGiao,MaLop=@MaLop
WHERE MaHS=@Ma
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

GO
ALTER PROC SuaGV(@Ma char(10), @Ten varchar(50), @GT char(3), @NgaySinh date, @SDT char(11), @DiaChi varchar(50), @Luong money, @MaMon char(10))
AS
UPDATE dbo.GiaoVien
SET MaGV=@Ma,TenGV=@Ten,GioiTinh=@GT,NgaySinh=@NgaySinh,SDT=@SDT,DiaChi=@DiaChi,Luong=@Luong,MaMon=@MaMon


DROP TABLE dbo.GiangDay
 DROP TABLE dbo.PhongHoc

 ALTER TABLE dbo.Phong_Lop
 ADD SoChoToiDa INT

 -- Thêm điểm
 GO
 CREATE PROC ThemDiem(@MaHS CHAR(10), @MaMon CHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 INSERT INTO dbo.Diem
         ( MaHS ,
           MaMon ,
           DiemMieng ,
           Diem15ph ,
           Diem1Tiet ,
           DiemHocKy
         )
 VALUES  ( @MaHS, @MaMon, @DiemMieng,@Diem15ph,@Diem1Tiet,@DiemHocKy
         )
 --sửa điểm
GO
ALTER PROC SuaDiem(@MaHS CHAR(10), @MaMon CHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 UPDATE dbo.Diem
 SET MaHS=@MaHS,MaMon=@MaMon,DiemMieng=@DiemMieng,Diem15ph=@Diem15ph,Diem1Tiet=@Diem1Tiet,DiemHocKy=@DiemHocKy

 --Thêm Môn Học
 GO
 CREATE PROC ThemMonHoc(@MaMon VARCHAR(10), @TenMon NVARCHAR(50), @Khoi VARCHAR(10))
 AS
 INSERT INTO dbo.MonHoc
         ( MaMon, TenMon, Khoi )
 VALUES  ( @MaMon,@TenMon,@Khoi
           )
-- Sửa Mon Học
GO
CREATE PROC SuaMonHoc(@MaMon VARCHAR(10), @TenMon NVARCHAR(50), @Khoi VARCHAR(10))
AS
UPDATE dbo.MonHoc
SET MaMon=@MaMon,TenMon=@TenMon,Khoi=@Khoi

 