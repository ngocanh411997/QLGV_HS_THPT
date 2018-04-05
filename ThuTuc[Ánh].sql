---- Thủ Tục ----
go
ALTER Proc ThemHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
As
Begin
insert into HocSinh(MaHS, TenHS,GioiTinh,NgaySinh,DiaChi,DanToc,TonGiao,MaLop)
values (@MaLop, @TenHS, @GioiTinh, @NgaySinh, @DiaChi, @DanToc, @TonGiao, @MaLop)
END
-- sửa học sinh
go
ALTER Proc SuaHS(@MaHS varchar(10), @TenHS nvarchar(50), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @DanToc nvarchar(50), @TonGiao nvarchar(50), @MaLop VARCHAR(10))
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
ALTER PROC DSHS
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
 