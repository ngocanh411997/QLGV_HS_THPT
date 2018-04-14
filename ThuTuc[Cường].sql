USE QLGV_HS_THPT
GO

--Thủ tục--

ALTER PROC Them_Lop(@malop varchar(10),@tenlop nvarchar(50))
AS
BEGIN
	INSERT INTO Lop(MaLop,TenLop)
	VALUES(@malop,@tenlop)
END
GO
ALTER PROC Sua_Lop(@malop varchar(10),@tenlop nvarchar(50))
AS
BEGIN
	
	UPDATE Lop
	SET TenLop=@tenlop
	WHERE MaLop=@malop
END

GO
CREATE PROC Xoa_Lop(@malop VARCHAR(10))
AS
 BEGIN
 DELETE Lop
 WHERE MaLop=@malop
 END
 
 GO
 ALTER PROC Xem_Lop
 AS 
 BEGIN
 SELECT *
 FROM Lop 
 end
 
 GO
 CREATE PROC Xem_Lop_ID(@malop VARCHAR(10))
 AS
 BEGIN
 SELECT * FROM Lop
 WHERE MaLop=@malop
 end 

 go
 CREATE PROC  Xem_GVCN
 AS
 BEGIN
 SELECT ChuNhiem.MaLop,Lop.MaLop,Lop.TenLop,Lop.MaGVCN,ChuNhiem.NamHoc
 FROM ChuNhiem,Lop
 WHERE ChuNhiem.MaLop=Lop.MaLop
 END
 