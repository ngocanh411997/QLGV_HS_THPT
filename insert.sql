USE QLGV_HS_THPT
GO 
INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV01','LH01','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV02','LH02','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV03','LH03','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV04','LH04','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV05','LH05','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV06','LH06','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV07','LH07','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV08','LH08','2018')

INSERT dbo.ChuNhiem ( MaGV, MaLop, NamHoc )
VALUES  ('GV09','LH09','2018')


GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS01' , -- MaHS - varchar(10)
          N'Nguyễn Văn Minh' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2000-09-10' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML01'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS02' , -- MaHS - varchar(10)
          N'Nguyễn Hải Nam' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2000-10-20' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML01'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS03' , -- MaHS - varchar(10)
          N'Trần Thị Hồng' , -- TenHS - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '2000-12-20' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML01'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS04' , -- MaHS - varchar(10)
          N'Nguyễn Khắc Mạnh' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2000-04-17' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML01'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS05' , -- MaHS - varchar(10)
          N'Đào Hồng Nhung' , -- TenHS - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(5)
          '2001-10-20' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML02'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS06' , -- MaHS - varchar(10)
          N'Nguyễn Văn Huy' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2001-04-19' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML02'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS07' , -- MaHS - varchar(10)
          N'Nguyễn Mạnh Nam' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2001-02-05' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML02'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS08' , -- MaHS - varchar(10)
          N'Nguyễn Bá Quang' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2002-02-05' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML03'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS09' , -- MaHS - varchar(10)
          N'Nguyễn Văn Hạnh' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2002-05-05' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML03'  -- MaLop - varchar(10)
        )
GO
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          DanToc ,
          TonGiao ,
          MaLop
        )
VALUES  ( 'HS10' , -- MaHS - varchar(10)
          N'Đào Nguyễn Nam' , -- TenHS - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(5)
          '2002-01-15' , -- NgaySinh - date
          N'Hà Nội' , -- DiaChi - nvarchar(150)
          N'Kinh' , -- DanToc - nvarchar(50)
          N'Không' , -- TonGiao - nvarchar(50)
          'ML03'  -- MaLop - varchar(10)
        )


GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM01', -- MaMon - varchar(10)
          N'Hóa', -- TenMon - nvarchar(50)
          '10'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM02', -- MaMon - varchar(10)
          N'Hóa', -- TenMon - nvarchar(50)
          '11'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM03', -- MaMon - varchar(10)
          N'Hóa', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM04', -- MaMon - varchar(10)
          N'Lý', -- TenMon - nvarchar(50)
          '10'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM05', -- MaMon - varchar(10)
          N'Lý', -- TenMon - nvarchar(50)
          '11'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM06', -- MaMon - varchar(10)
          N'Lý', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM07', -- MaMon - varchar(10)
          N'Toán', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM08', -- MaMon - varchar(10)
          N'Văn', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM09', -- MaMon - varchar(10)
          N'Sử', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )
GO
INSERT INTO dbo.MonHoc
        ( MaMon, TenMon, Khoi )
VALUES  ( 'MM10', -- MaMon - varchar(10)
          N'Địa', -- TenMon - nvarchar(50)
          '12'  -- Khoi - varchar(10)
          )

--GO
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH01','CNTT','GV01' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH02','KTPM','GV02' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH03','KHMT','GV03' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH04','HTTT','GV04' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH05','TT&MMT','GV05' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH06','CĐT','GV06' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH07','ĐTVT','GV07' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH08','ĐTYS','GV08' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH09','CNHH','GV09' )
--INSERT dbo.Lop
--        ( MaLop, TenLop, MaGVCN )
--VALUES  ('LH10','XD','GV10' )

INSERT dbo.Diem
VALUES  ( 'HS01' ,'MM01' , 7 ,8 ,8 , 7 )
INSERT dbo.Diem
VALUES  ( 'HS01' ,'MM02' , 6 ,8 ,5 , 8 )
INSERT dbo.Diem
VALUES  ( 'HS02' ,'MM03' , 7 ,4 ,6 , 9 )
INSERT dbo.Diem
VALUES  ( 'HS02' ,'MM04' , 3 ,6 ,9 , 6 )
INSERT dbo.Diem
VALUES  ( 'HS03' ,'MM01' , 2 ,7 ,6 , 5 )
INSERT dbo.Diem
VALUES  ( 'HS03' ,'MM05' , 7 ,8 ,5 , 4 )
INSERT dbo.Diem
VALUES  ( 'HS04' ,'MM06' , 9 ,9 ,4 , 3 )
INSERT dbo.Diem
VALUES  ( 'HS04' ,'MM07' , 10 ,4 ,7 ,8 )
INSERT dbo.Diem
VALUES  ( 'HS05' ,'MM04' , 2 ,6,8 , 4)
INSERT dbo.Diem
VALUES  ( 'HS05' ,'MM06' , 5 ,7 ,5 , 7 )
INSERT dbo.Diem
VALUES  ( 'HS06' ,'MM04' , 6 ,8 ,8 , 3 )
INSERT dbo.Diem
VALUES  ( 'HS06' ,'MM05' , 8 ,9 ,3 , 8 )
INSERT dbo.Diem
VALUES  ( 'HS07' ,'MM02' , 9 ,5 ,9 , 4 )
INSERT dbo.Diem
VALUES  ( 'HS07' ,'MM08' , 5 ,4 ,4 , 4 )
INSERT dbo.Diem
VALUES  ( 'HS08' ,'MM09' , 3 ,8 ,7 , 5 )
INSERT dbo.Diem
VALUES  ( 'HS08' ,'MM02' , 4 ,3 ,6 , 7 )
INSERT dbo.Diem
VALUES  ( 'HS09' ,'MM02' , 6 ,9 ,7 , 8 )
INSERT dbo.Diem
VALUES  ( 'HS10' ,'MM01' , 7 ,9 ,6 , 9 )
INSERT dbo.Diem
VALUES  ( 'HS10' ,'MM06' , 8 ,4 ,5 , 5 )
INSERT dbo.Diem
VALUES  ( 'HS10' ,'MM01' , 7 ,8 ,4 , 4 )