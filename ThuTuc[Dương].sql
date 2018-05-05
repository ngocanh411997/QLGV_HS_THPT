--Dương 
USE QLGV_HS_THPT
GO 
--Thêm điểm
CREATE PROC SP_ThemDiem(@MaHS VARCHAR(10), @MaMon VARCHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 BEGIN
 INSERT INTO dbo.Diem
 VALUES  ( @MaHS, @MaMon, @DiemMieng,@Diem15ph,@Diem1Tiet,@DiemHocKy)
 END

 
 --sửa điểm
GO
CREATE PROC SP_SuaDiem(@MaHS VARCHAR(10), @MaMon VARCHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 BEGIN
 UPDATE dbo.Diem
 SET DiemMieng=@DiemMieng,Diem15ph=@Diem15ph,Diem1Tiet=@Diem1Tiet,DiemHocKy=@DiemHocKy
 WHERE MaHS=@MaHS AND MaMon=@MaMon
 END
 GO 
 --Xóa điểm
 CREATE PROC SP_XoaDiem(@MaHS VARCHAR(10))
 AS
 BEGIN
 DELETE dbo.Diem WHERE MaHS=@MaHS
 END
 GO
 --Xem điểm
 ALTER PROC SP_XemDiem
 AS
 BEGIN
 SELECT Diem.MaHS,TenHS,TenLop,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy
 FROM dbo.Diem INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMon INNER JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS INNER JOIN dbo.Lop ON Lop.MaLop = HocSinh.MaLop 
 END
 GO 
--Xem điểm theo môn
CREATE PROC SP_XemDiemHS
AS
BEGIN
SELECT TenHS,Diem.MaMon,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc
ON MonHoc.MaMon = Diem.MaMon
JOIN dbo.HocSinh
ON HocSinh.MaHS = Diem.MaHS
END