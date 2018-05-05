---- Thủ Tục ----
go
ALTER Proc ThemHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
As
Begin
insert into HocSinh(MaHS, TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,MaLop)
values (@MaHS, @TenHS, @GioiTinh, @NgaySinh, @DiaChi, @DanToc, @TonGiao, @MaLop)
END
-- sửa học sinh
go
ALTER Proc SuaHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
As
Begin
Update HocSinh
Set TenHS=@TenHS,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,DanToc=@DanToc,TonGiao=@TonGiao,MaLop=@MaLop
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
	SELECT MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,TenLop
	FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop
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
CREATE PROC SuaDiem(@MaHS CHAR(10), @MaMon CHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 UPDATE dbo.Diem
 SET MaHS=@MaHS,MaMon=@MaMon,DiemMieng=@DiemMieng,Diem15ph=@Diem15ph,Diem1Tiet=@Diem1Tiet,DiemHocKy=@DiemHocKy

 -- 5/4/2018
 GO
 CREATE PROC Lop_SelectAll
 AS
 BEGIN
 SELECT * FROM Lop
 END;

 -- 
 SELECT NV.MaNV,NV.HoTen,NV.DanToc,NV.GioiTinh,NV.SDT,NV.QueQuan,NV.NgaySinh,NV.MaTDHV,PB.TenPB,NV.BacLuong FROM dbo.NhanVien NV, dbo.PhongBan PB 

 GO

 -- 
 GO
 SELECT TenHS,TenLop,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy,TongKet=((DiemMieng+Diem15ph+Diem1Tiet*2+DiemHocKy*3)/7)
 FROM dbo.HocSinh INNER JOIN dbo.Diem ON Diem.MaHS = HocSinh.MaHS
 INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop
 INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon
 WHERE Diem.MaHS='HS01'

 GO
 SELECT MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,TenLop
 FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop
 WHERE TenHS=''

 GO
 SELECT *
 FROM dbo.Lop
 
 GO 
 SELECT TenGV,TenLop,NamHoc
 FROM dbo.ChuNhiem INNER JOIN dbo.GiaoVien ON GiaoVien.MaGV = ChuNhiem.MaGV INNER JOIN dbo.Lop ON Lop.MaLop = ChuNhiem.MaLop  



 --
 GO
 ALTER PROC  [dbo].[Xem_GVCN]
 AS
 BEGIN
 SELECT ChuNhiem.MaGV,TenGV,TenLop,NamHoc
 FROM ChuNhiem INNER JOIN dbo.GiaoVien ON GiaoVien.MaGV = ChuNhiem.MaGV INNER JOIN dbo.Lop ON Lop.MaLop = ChuNhiem.MaLop
 
 END
 --GO
ALTER PROC [dbo].[SP_SelectMaLop]
AS
BEGIN
	SELECT MaLop
	FROM Lop
END
--
ALTER TABLE dbo.Lop
DROP COLUMN MaGVCN
