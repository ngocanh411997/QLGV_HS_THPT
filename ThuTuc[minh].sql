use QLGV_HS_THPT
go

create PROC DangNhap(@TaiKhoan varCHAR(50),@MatKhau varCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO

create proc SP_SuaCN --sửa thông tin chủ nhiệm
(@MaGV varchar(10), @MaLop varchar(10), @NamHoc varchar(4))
as
begin
	update ChuNhiem
	set MaLop = @MaLop, NamHoc = @NamHoc
	where MaGV = @MaGV
end	
go

create proc SP_XoaCN(@MaGV varchar(10)) -- xóa giáo viên chủ nhiệm 
as
begin
	delete ChuNhiem
	where MaGV = @MaGV
end