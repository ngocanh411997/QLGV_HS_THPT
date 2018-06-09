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

-- xóa hs
GO
ALTER PROC XoaHS(@MaHS VARCHAR(10))
AS
BEGIN
DELETE dbo.Diem
WHERE MaHS =@MaHS
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
 ALTER PROC ThemDiem(@MaHS CHAR(10), @MaMon CHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
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

SELECT TenHS,TenLop,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy,TrungBinh=((DiemMieng+Diem15ph+Diem1Tiet*2+DiemHocKy*3)/7) FROM dbo.HocSinh INNER JOIN dbo.Diem ON Diem.MaHS = HocSinh.MaHS INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon WHERE Diem.MaHS = 'HS01'
---------
CREATE FUNCTION [dbo].[ChuyenDoiUnicode] ( @strInput NVARCHAR(4000) )
 RETURNS NVARCHAR(4000) AS BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput 
 DECLARE @RT NVARCHAR(4000) 
 DECLARE @SIGN_CHARS NCHAR(136) 
 DECLARE @UNSIGN_CHARS NCHAR (136) 
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
 DECLARE @COUNTER int 
 DECLARE @COUNTER1 int 
 SET @COUNTER = 1 
 WHILE (@COUNTER <=LEN(@strInput)) 
 BEGIN SET @COUNTER1 = 1 
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
 BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
 BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
 BREAK END 
 SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END 
 SET @strInput = replace(@strInput,' ','-') 
 RETURN @strInput END
GO
-- TK tên gần đúng HS
GO
CREATE PROC TKTenHS(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop
WHERE dbo.ChuyenDoiUnicode(TenHS) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%'
END

-- Địa chỉ
GO
CREATE PROC TKDCHS(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, DanToc, TonGiao, TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop
WHERE dbo.ChuyenDoiUnicode(DiaChi) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%'
END

-- Xem Lớp
GO
CREATE PROC Sellect_All_Lop
AS
BEGIN
	SELECT * FROM dbo.Lop
END
