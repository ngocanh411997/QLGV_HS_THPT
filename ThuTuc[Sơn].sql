USE QLGV_HS_THPT
---- Thủ Tục Bảng Giáo Viên ----
go
CREATE Proc Them_GV(@MaGV varchar(10), @TenGV nvarchar(50),@MaMon VARCHAR(10), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @SDT VARCHAR(10), @Luong int)
As
BEGIN 
	INSERT INTO GiaoVien(MaGV,TenGV,MaMon,GioiTinh,NgaySinh,DiaChi,Sdt,Luong)
	VALUES(@MaGV,@TenGV,@MaMon,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Luong)
END
-- sửa học sinh
go
CREATE Proc Sua_GV(@MaGV varchar(10), @TenGV nvarchar(50),@MaMon VARCHAR(10), @GioiTinh NVARCHAR(5), @NgaySinh date, @DiaChi nvarchar(150), @SDT VARCHAR(10), @Luong int)
As
BEGIN 
	UPDATE GiaoVien
	SET TenGV = @TenGV,MaMon = @MaMon,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,DiaChi = @NgaySinh,Sdt = @SDT,Luong = @Luong
	WHERE MaGV = @MaGV
END

GO
CREATE PROC Xoa_GV(@Ma VARCHAR(10))
AS
BEGIN
DELETE GiaoVien
WHERE MaGV=@Ma
END

-- Hiện danh sách Học Sinh
GO
CREATE PROC GV_SelectAll
AS
BEGIN
	SELECT *
	FROM GiaoVien
END

CREATE PROC GV_SelectByID (@Ma Varchar(10))
AS
BEGIN
	SELECT *
	FROM GiaoVien
	WHERE MaGV = @Ma
ENd