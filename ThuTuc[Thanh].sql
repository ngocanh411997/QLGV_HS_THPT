--Thanh thủ tục
USE QLGV_HS_THPT

--lớp chưa có chủ nhiệm
GO 
CREATE PROC SP_SelectMaLop
AS
BEGIN
	SELECT MaLop
	FROM Lop
	WHERE MaGVCN IS NULL
END 

GO 
CREATE PROC SP_CN_SelectAll
AS
BEGIN
	SELECT *FROM dbo.ChuNhiem
END 

GO
CREATE PROC SP_ThemChuNhiem @MaGV VARCHAR(10), @MaLop VARCHAR(10), @NamHoc VARCHAR(4)
AS
BEGIN
	INSERT dbo.ChuNhiem( MaGV, MaLop, NamHoc )
	VALUES  (@MaGV,@MaLop,@NamHoc)
END

GO

