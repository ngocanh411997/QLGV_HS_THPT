use QLGV_HS_THPT
go

create PROC DangNhap(@TaiKhoan varCHAR(50),@MatKhau varCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO