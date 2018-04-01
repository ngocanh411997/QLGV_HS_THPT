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
-----------------

---- Thủ Tục ----
go
ALTER Proc ThemHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh bit, @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
As
Begin
insert into HocSinh(MaHS, TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,MaLop)
values (@MaLop, @TenHS, @GioiTinh, @NgaySinh, @DiaChi, @DanToc, @TonGiao, @MaLop)
END
-- sửa học sinh
go
ALTER Proc SuaHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh bit, @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
As
Begin
Update HocSinh
Set MaHS=@MaHS,TenHS=@TenHS,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,DanToc=@DanToc,TonGiao=@TonGiao,MaLop=@MaLop
WHERE MaHS=@MaHS
end

GO
CREATE PROC XoaHS(@MaHS VARCHAR(10))
AS
BEGIN
DELETE dbo.HocSinh
WHERE MaHS=@MaHS
END

-- Hiện danh sách Học Sinh
GO
CREATE PROC DSHS
AS
BEGIN
	SELECT *
	FROM dbo.HocSinh
END


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
