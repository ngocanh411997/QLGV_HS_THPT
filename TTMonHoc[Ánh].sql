--- Xem Môn
GO
CREATE PROC MonHoc_SelectAll
AS
BEGIN
	SELECT * FROM dbo.MonHoc
END
--Thêm Môn
GO
CREATE PROC ThemMon(@MaMon VARCHAR(10), @TenMon NVARCHAR(50), @Khoi VARCHAR(10))
AS
BEGIN
	INSERT INTO dbo.MonHoc
	        ( MaMon, TenMon, Khoi )
	VALUES  (@MaMon,@TenMon,@Khoi)
END
--sửa môn
GO
CREATE PROC SuaMon(@MaMon VARCHAR(10), @TenMon NVARCHAR(50), @Khoi VARCHAR(10))
AS
BEGIN
	UPDATE dbo.MonHoc
	SET TenMon=@TenMon,Khoi=@Khoi
	WHERE MaMon=@MaMon
END
-- Xóa Môn
GO
CREATE PROC XoaMon(@MaMon VARCHAR(10))
AS
BEGIN
	DELETE dbo.MonHoc
	WHERE MaMon=@MaMon
END