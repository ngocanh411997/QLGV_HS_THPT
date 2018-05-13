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
 EXEC dbo.SP_ThemDiem @MaHS = 'HS01', -- varchar(10)
     @MaMon = 'M01', -- varchar(10)
     @DiemMieng = 1, -- float
     @Diem15ph = 2, -- float
     @Diem1Tiet = 3, -- float
     @DiemHocKy = 3 -- float
 
 
 --sửa điểm
ALTER PROC SP_SuaDiem(@MaHS VARCHAR(10), @MaMon VARCHAR(10),@DiemMieng FLOAT,@Diem15ph FLOAT,@Diem1Tiet FLOAT,@DiemHocKy FLOAT)
 AS
 BEGIN
 UPDATE dbo.Diem
 SET MaMon=@MaMon,DiemMieng=@DiemMieng,Diem15ph=@Diem15ph,Diem1Tiet=@Diem1Tiet,DiemHocKy=@DiemHocKy
 WHERE MaHS=@MaHS 
 END
 GO 
 --Xóa điểm
 CREATE PROC SP_XoaDiem(@MaHS VARCHAR(10))
 AS
 BEGIN
 DELETE dbo.Diem WHERE MaHS=@MaHS
 END
 GO
 SELECT * FROM dbo.Diem JOIN dbo.MonHoc
 ON MonHoc.MaMon = Diem.MaMon JOIN dbo.HocSinh
 ON HocSinh.MaHS = Diem.MaHS
 --Xem điểm
 ALTER PROC SP_XemDiem
 AS
 BEGIN
SELECT Diem.MaHS,TenHS,TenMon,DiemMieng,Diem15ph,Diem1Tiet,DiemHocKy FROM dbo.Diem JOIN dbo.MonHoc
ON MonHoc.MaMon = Diem.MaMon
JOIN dbo.HocSinh
ON HocSinh.MaHS = Diem.MaHS
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
GO
INSERT NguoiDung 
VALUES('admin','admin')
GO
