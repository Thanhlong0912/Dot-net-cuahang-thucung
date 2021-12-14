CREATE DATABASE QL_SHOPPET-- Chỉnh Sửa Lúc 14/11/2021
--CSDL chính thức cho Demo
USE QL_SHOPPET
------------------
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](10) NOT NULL,
	[TenNhanVien] [nvarchar](100),
	[NgaySinh] [date],
	[GioiTinh] [nvarchar](10),
	[NgayVaoLam] [date],
	[ChucVu] [nvarchar](100),
	[DiaChi] [nvarchar](50),
	[SoDT] [varchar](11),
	[GhiChu] [nvarchar](255) NULL,
	CONSTRAINT PK_NHANVIEN PRIMARY KEY([MaNhanVien])
	)

CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNhaPhanPhoi] [char](10) NOT NULL,
	[TenNhaPhanPhoi] [nvarchar](100),
	[DiaChi] [nvarchar](100),
	[SDT] [varchar](11),
	[Email] [varchar](100),
	[ChuThich] [nvarchar](255) NULL,
 CONSTRAINT [PK_NhaPhanPhoi] PRIMARY KEY(MaNhaPhanPhoi) )

CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [char](10) NOT NULL,
	[MaNhaPhanPhoi] [char](10) NOT NULL,
	[TenSanPham] [nvarchar](150),
	[LoaiSanPham] [char](10),
	[HangSanXuat] [nvarchar](100),
	[GiaBan] [float],
	[TonKho] [int] NOT NULL,
	[Image] [varchar](150) NULL CONSTRAINT [DF_SanPham_image]  DEFAULT (''),
	[ChuThich] [nvarchar](255) NULL CONSTRAINT [DF_SanPham_ChuThich]  DEFAULT (''),
	CONSTRAINT PK_SP PRIMARY KEY(MaSanPham))
	
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [char](10) NOT NULL,
	[MaNhanVien] [char](10),
	[MaNhaPhanPhoi] [char](10),
	[TongTien] [float],
	[NgayNhap] [date],
	[ChuThich] [nvarchar](255) NULL CONSTRAINT [DF_PhieuNhap_ChuThich]  DEFAULT (''),
	CONSTRAINT PK_PN PRIMARY KEY(MaPhieuNhap))

CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [char](10) NOT NULL,
	[TenLoaiSanPham] [nvarchar](150),
	CONSTRAINT PK_LH PRIMARY KEY(MaLoaiSanPham))

CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [char](10) NOT NULL,
	[MaSanPham] [char](10) NOT NULL,
	[SoLuong] [int],
	[TongTien] [float],
	[ChuThich] [nvarchar](255) NULL CONSTRAINT [DF_ChiTietPhieuNhap_ChuThich]  DEFAULT (''),
	CONSTRAINT PK_CTPN PRIMARY KEY(MaPhieuNhap,MaSanPham))

CREATE TABLE [dbo].[ChiTietDotKhuyenMai]
(
	[MaDot] [char](10) NOT NULL,
	[MaSanPham] [char](10) NOT NULL,
	[TiLeGiamGia] float,
	CONSTRAINT PK_CTDKM PRIMARY KEY (MaDot,MaSanPham)
)

CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [char](10) NOT NULL,
	[TenKhachHang] [nvarchar](150),
	[Ngaysinh] [date],
	[GioiTinh] [nvarchar](10),
	[DiaChi] [nvarchar](50),
	[SDT] [varchar](11),
	[LoaiKhachHang] [nvarchar](20),
	[GhiChu] [nvarchar](255) NULL,
	CONSTRAINT PK_KHACHHANG PRIMARY KEY(MaKhachHang))


CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaKhachHang] [char](10) NOT NULL,
	[MaNhanVien] [char](10) NOT NULL,
	[MaSanPham] [char](10),
	[NgayLapHoaDon] [date],
	[TongTien] [float],
	[GhiChu] [nvarchar](255) NULL CONSTRAINT [DF_HoaDon_GhiChu]  DEFAULT (''),
	CONSTRAINT PK_HOADON PRIMARY KEY(MaHoaDon))

CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaSanPham] [char](10) NOT NULL,
	[MucGiam] [float],
	[SoLuong] [int],
	[TongTien] [float],
	[TongTienHoaDon] [float],
	[NgayDat] [date],
	[NgayGiao] [date],
	[GhiChu] [nvarchar](255) NULL,
	CONSTRAINT PK_CTHOADON PRIMARY KEY(MaHoaDon,MaSanPham))

CREATE TABLE [dbo].[DotKhuyenMai]
(
	[MaDot] [char](10)  NOT NULL,
	[NgayBD] [date],
	[NgayKT] [date],
	CONSTRAINT PK_DOTKM PRIMARY KEY(MaDot)
)
CREATE TABLE [dbo].[Users](
	[MaNhanVien] [char](10),
	[TenDangNhap] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Quyen] [char](10),
	[TenNhanVien] [nvarchar](150)
	CONSTRAINT PK_TaiKhoan PRIMARY KEY (TenDangNhap)
)
go
--KHOÁ NGOẠI
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT FK_SP_NCC FOREIGN KEY(MaNhaPhanPhoi) REFERENCES [dbo].[NhaPhanPhoi](MaNhaPhanPhoi)
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT FK_SP_LH FOREIGN KEY(LoaiSanPham) REFERENCES [dbo].[LoaiSanPham](MaLoaiSanPham)
ALTER TABLE [dbo].[PhieuNhap]
ADD CONSTRAINT FK_PN_NCC FOREIGN KEY(MaNhaPhanPhoi) REFERENCES [dbo].[NhaPhanPhoi](MaNhaPhanPhoi)
ALTER TABLE [dbo].[PhieuNhap]
ADD CONSTRAINT FK_PN_NV FOREIGN KEY(MaNhanVien) REFERENCES [dbo].[NhanVien](MaNhanVien)

ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT FK_CTPN_PN FOREIGN KEY(MaPhieuNhap) REFERENCES [dbo].[PhieuNhap](MaPhieuNhap)
ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT FK_CTPN_SP FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[ChiTietDotKhuyenMai]
ADD CONSTRAINT FK_CTDKM_DKM FOREIGN KEY(MaDot) REFERENCES [dbo].[DotKhuyenMai](MaDot)
ALTER TABLE [dbo].[ChiTietDotKhuyenMai]
ADD CONSTRAINT FK_CTDKM_SP FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[HoaDon]
ADD CONSTRAINT FK_HOADON_SANPHAM FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[HoaDon]
ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES [dbo].[NhanVien](MaNhanVien)
ALTER TABLE [dbo].[HoaDon]
ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MaKhachHang) REFERENCES [dbo].[KhachHang](MaKhachHang)
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT FK_CT_HOADON_SANPHAM FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT FK_CT_HOADON_HOADON FOREIGN KEY(MaHoaDon) REFERENCES [dbo].[HoaDon](MaHoaDon)
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT FK_TK_NV FOREIGN KEY(MaNhanVien) REFERENCES [dbo].[NhanVien](MaNhanVien)
-----------------------RẰNG BUỘC--------------------------------------------
ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT CK_PN CHECK(SoLuong > 0)
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT CK_SOLUONG CHECK(SoLuong>0)
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT CK_TT CHECK(TongTien>0)
ALTER TABLE [dbo].[DotKhuyenMai]
ADD CONSTRAINT CK_NGAY CHECK(NgayBD<NgayKT)
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT CK_GIA CHECK(GiaBan > 0)
------update tiềnpn------
Go
CREATE TRIGGER TONGTIENPN ON [dbo].[ChiTietPhieuNhap]
FOR INSERT,UPDATE
AS
BEGIN
	UPDATE [dbo].[PhieuNhap]
	SET TongTien = (SELECT SUM(ChiTietPhieuNhap.SoLuong*ChiTietPhieuNhap.TongTien)
						FROM ChiTietPhieuNhap,inserted
						WHERE ChiTietPhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
						GROUP BY ChiTietPhieuNhap.MaPhieuNhap)
	FROM PhieuNhap, inserted
	WHERE PhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
	------------------------
	UPDATE SanPham
	SET TonKho = TonKho + (SELECT SoLuong FROM inserted)
	WHERE MaSanPham=(SELECT MaSanPham FROM inserted)
END
------tienhd------
go
CREATE TRIGGER TONGTIENHD ON [dbo].[ChiTietHoaDon]
FOR INSERT,UPDATE
AS
BEGIN
	UPDATE [dbo].[HoaDon]
	SET TongTien = (SELECT SUM(ChiTietHoaDon.SoLuong*ChiTietHoaDon.TongTien)
						FROM ChiTietHoaDon,inserted
						WHERE ChiTietHoaDon.MaHoaDon = inserted.MaHoaDon
						GROUP BY ChiTietHoaDon.MaHoaDon)
	FROM HoaDon, inserted
	WHERE HoaDon.MaHoaDon = inserted.MaHoaDon
END
---ngày nhập phải trước ngày hiện tại--
CREATE TRIGGER KT_NGAYNHAP ON PHIEUNHAP
FOR INSERT, UPDATE
AS
	DECLARE @MAPN CHAR(10),@NGAYNHAP DATE
	IF NOT EXISTS (SELECT * FROM deleted)
	BEGIN
		SELECT @MAPN = MaPhieuNhap,@NGAYNHAP = NgayNhap
		FROM inserted
		WHERE MaPhieuNhap = @MAPN
		IF(@NGAYNHAP>GETDATE())
		BEGIN
			RAISERROR (N'Ngày nhập phải trước ngày hiện tại',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@NGAYNHAP,GETDATE()) > 30
		BEGIN
			RAISERROR (N'Ngày hiện tại - ngày nhập <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
	ELSE
	BEGIN
		IF UPDATE(NgayNhap)
		BEGIN
			SELECT @MAPN = MaPhieuNhap,@NGAYNHAP = NgayNhap
			FROM inserted
			WHERE MaPhieuNhap = @MAPN
			IF(@NGAYNHAP>GETDATE())
		BEGIN
			RAISERROR (N'Ngày nhập phải trước ngày hiện tại',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@NGAYNHAP,GETDATE()) > 30
		BEGIN
			RAISERROR (N'Ngày hiện tại - ngày nhập <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
END
------------------------------------------ngày đặt < ngày giao
CREATE TRIGGER NGAYDAT_NGAYGIAO ON [dbo].[ChiTietHoaDon]
FOR INSERT, UPDATE
AS
	DECLARE @mahd CHAR(10),@ngaydat DATE,@ngaygiao DATE
	IF NOT EXISTS (SELECT * FROM deleted)
	BEGIN
		SELECT @mahd = MaHoaDon,@ngaygiao = NgayGiao
		FROM inserted
		SELECT @ngaydat = NgayDat
		FROM ChiTietHoaDon
		WHERE MaHoaDon = @mahd
		IF(@ngaygiao<@ngaydat)
		BEGIN
			RAISERROR (N'Ngày đặt phải trước ngày giao',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@ngaydat,@ngaygiao) > 30
		BEGIN
			RAISERROR (N'Ngày giao - ngày đặt <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
	ELSE
	BEGIN
		IF UPDATE(NgayGiao)
		BEGIN
		SELECT @mahd = MaHoaDon,@ngaygiao = NgayGiao
		FROM inserted
		SELECT @ngaydat = NgayDat
		FROM ChiTietHoaDon
		WHERE MaHoaDon = @mahd
		IF(@ngaygiao<@ngaydat)
		BEGIN
			RAISERROR (N'Ngày đặt phải trước ngày giao',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@ngaydat,@ngaygiao) > 30
		BEGIN
			RAISERROR (N'Ngày giao - ngày đặt <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
END
--------Ngày BD trước Ngày KT [ChiTietDKM]
CREATE TRIGGER KT_DKM ON DotKhuyenMai
FOR INSERT, UPDATE
AS
	DECLARE @madot CHAR(10),@ngaybd DATE,@ngaykt DATE
	IF NOT EXISTS (SELECT * FROM deleted)
	BEGIN
		SELECT @madot = MaDot,@ngaykt = NgayKT
		FROM inserted
		SELECT @ngaybd = NgayBD
		FROM DotKhuyenMai
		WHERE MaDot = @madot
		IF(@ngaykt<@ngaybd)
		BEGIN
			RAISERROR (N'Ngày kết thúc phải sau ngày bắt đầu',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@ngaybd,@ngaykt) > 30
		BEGIN
			RAISERROR (N'Ngày kết thúc - ngày bắt đầu <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
	ELSE
	BEGIN
		IF UPDATE(NgayKT)
		BEGIN
		SELECT @madot = MaDot,@ngaykt = NgayKT
		FROM inserted
		SELECT @ngaybd = NgayBD
		FROM DotKhuyenMai
		WHERE MaDot = @madot
		IF(@ngaykt<@ngaybd)
		BEGIN
			RAISERROR (N'Ngày kết thúc phải sau ngày bắt đầu',16,1)
			ROLLBACK
			RETURN
		END
		IF DATEDIFF(DD,@ngaybd,@ngaykt) > 30
		BEGIN
			RAISERROR (N'Ngày kết thúc - ngày bắt đầu <= 30 ngày',16,1)
			ROLLBACK
			RETURN
		END
	END
END
-----------------------------
--CREATE TRIGGER kiemtrasoluong ON [dbo].[ChiTietHoaDon]
--FOR INSERT 
--AS
--	DECLARE @soluong INT
--	SET @soluong = (SELECT SanPham.TonKho FROM SANPHAM, inserted WHERE SanPham.MaSanPham = inserted.MaSanPham)
--	IF(@soluong = 0)
--	BEGIN 
--		UPDATE SanPham
--		SET ChuThich = N'Hết Hàng'
--		WHERE MaSanPham = (SELECT MaSanPham FROM inserted)
--		ROLLBACK TRAN
--	END
--	ELSE IF(@soluong < (SELECT MaSanPham FROM inserted))
--	BEGIN 
--		PRINT N'Không đủ bán'
--		ROLLBACK TRAN
--	END

--------------------tính tiền
create trigger mucgiam on [dbo].[ChiTietHoaDon]
for insert
as
begin
	declare @mahd nchar(10),@masp nchar(10),@sl int,@dongia money,@ngaydat date,@tlgiam float,@madot nchar(10),@tienhd money,@tiendagiam money, @tongtt money
	set @mahd=(select MaHoaDon from inserted)
	set @masp=(select MaSanPham from inserted)
	set @sl=(select SoLuong from inserted)
	set @dongia=(select TongTien from inserted)
	set @ngaydat=(select NgayDat from inserted)
	set @madot=(select MaDot from DotKhuyenMai where @ngaydat between NgayBD and NgayKT)
	set @tienhd=(select TongTien from HoaDon where MaHoaDon=@mahd)
	set @tiendagiam=(select TongTienHoaDon from ChiTietHoaDon where MaHoaDon=@mahd)
	set @tlgiam=(select TiLeGiamGia from ChiTietDotKhuyenMai where MaDot=@madot and MaSanPham=@masp)
	if(@tlgiam is null)
	begin
		set @tlgiam=1
	end
	else
	begin
		set @tlgiam=@tlgiam
	end
	set @tongtt=@tienhd - @tiendagiam
	update [dbo].[ChiTietHoaDon]
	set MucGiam=@tongtt where MaHoaDon=@mahd
end
--------------------------------------
create trigger cntt on [dbo].[ChiTietHoaDon]
for insert
as
begin
	declare @mahd nchar(10),@masp nchar(10),@sl int,@dongia money,@ngaydat date,@tlgiam float,@madot nchar(10),@tongtt money
	set @mahd=(select MaHoaDon from inserted)
	set @masp=(select MaSanPham from inserted)
	set @sl=(select SoLuong from inserted)
	set @dongia=(select TongTien from inserted)
	set @ngaydat=(select NgayDat from inserted)
	set @madot=(select MaDot from DotKhuyenMai where @ngaydat between NgayBD and NgayKT)
	set @tlgiam=(select TiLeGiamGia from ChiTietDotKhuyenMai where MaDot=@madot and MaSanPham=@masp)
	if(@tlgiam is null)
	begin
		set @tlgiam=1
	end
	else
	begin
		set @tlgiam=@tlgiam
	end
	set @tongtt=(@sl*@dongia*@tlgiam)
	update [dbo].[ChiTietHoaDon]
	set TongTienHoaDon=@tongtt where MaHoaDon=@mahd
end

create trigger giaban on [dbo].[SanPham]
for insert
as
begin
	declare @masp char(3), @manpp char(3), @tensp nvarchar(50), @loaisp char(3),@hsx char(3),@giaban money,@tk int
	set @masp=(select MaSanPham from inserted)
	set @manpp=(select MaNhaPhanPhoi from inserted)
	set @tensp=(select TenSanPham from inserted)
	set @loaisp=(select LoaiSanPham from inserted)
	set @hsx=(select HangSanXuat from inserted)
	set @giaban=(select GiaBan from inserted)
	set @tk=(select TonKho from inserted)
	update [dbo].[ChiTietHoaDon]
	set TongTien=@giaban where MaSanPham=@masp
end
--------------------------------------------------------------------------------------------
SET DATEFORMAT DMY

INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES ('NH1', N'Trung Tâm Thú Cưng Hóc Môn', N'Hồ Chí Minh', N'098674322', N'lv@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES ('NH2', N'PetViet.Com', N'Trung Quốc ', N'34657865434', N'cpo@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES ('NH3', N'ThuCungVN', N'Việt Nam', N'34657865434', N'dr@gmail.com', N'')

INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L1', N'Chó')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L2', N'Mèo')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L3', N'Chuột')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L4', N'Rùa')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L5', N'Bò Sát')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES ('L6', N'Cá')

INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N1',N'NGUYỄN NGỌC SƠN','11/1/1999',N'Nam','16/3/2019',N'Quản Lý',N'Việt Nam',N'0123131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N2',N'TRẦN TUẤN ANH','24/2/2001',N'Nam','16/4/2020',N'Nhân Viên',N'Thái Lan',N'0121231231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N3',N'NGUYỄN VĂN HÀO','14/3/1996',N'Nữ','16/1/2015',N'Nhân Viên',N'Campuchia',N'0176131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N4',N'VÕ VĂN KIỆT','24/4/1987',N'Nam','16/10/2016',N'Nhân Viên',N'Long An',N'0123131981',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N5',N'SƯƠNG LONG LANH','25/5/1994',N'Nữ','16/9/2018',N'Nhân Viên',N'TP.HCM',N'0123154231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N6',N'NGUYỄN THỊ CẨM LY','19/10/1992',N'Nữ','16/12/2014',N'Nhân Viên',N'Vũng Tàu',N'0973131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N7',N'TRƯƠNG TUẤN TÚ','10/12/1997',N'Nam','26/7/2019',N'Nhân Viên',N'Bình Định',N'0563131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N8',N'PHAN TẤN TRUNG','7/11/1994',N'Nữ','11/2/2016',N'Nhân Viên',N'Phú Yên',N'0573131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N9',N'PHẠM TUẤN VĨ','8/6/1987',N'Nam','11/3/2008',N'Nhân Viên',N'Lạng Sơn',N'0523131231',N'');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES('N10',N'TRẦN VĂN CƯỜNG','4/8/1985',N'Nữ','16/3/2003',N'Nhân Viên',N'Yến Bái',N'0903131231',N'')

INSERT [dbo].[Users] ([MaNhanVien], [TenDangNhap], [Password], [Quyen], [TenNhanVien]) VALUES ('N1', N'son', N'son', 'Admin',null)
INSERT [dbo].[Users] ([MaNhanVien], [TenDangNhap], [Password], [Quyen], [TenNhanVien]) VALUES ('N2', N'huy', N'huy', 'User',null)
INSERT [dbo].[Users] ([MaNhanVien], [TenDangNhap], [Password], [Quyen], [TenNhanVien]) VALUES ('N3', N'tin', N'tin', 'User',null)
INSERT [dbo].[Users] ([MaNhanVien], [TenDangNhap], [Password], [Quyen], [TenNhanVien]) VALUES ('N4', N'thang', N'thang', 'User',null)
INSERT [dbo].[Users] ([MaNhanVien], [TenDangNhap], [Password], [Quyen], [TenNhanVien]) VALUES ('N5', N'thang1', N'thang1', 'Manage',null)

INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S01', 'NH1', N'Chó Đốm', 'L1', 'HG1', 789000.0000, 34, N'sonnu m4 w1.png', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S02', 'NH1',N'Chó Ngoo', 'L1', 'HG1', 189000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S03', 'NH1',N'Chó Husky', 'L1', 'HG1', 130000.0000, 10, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S04','NH2', N'Chó Pug', 'L1', 'HG2', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S05','NH2', N'Chó Corgi', 'L1', 'HG2', 749000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S06','NH2', N'Chó Shiba Inu','L1', 'HG1', 180000.0000, 10, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S07','NH2', N'Chó Phốc Sóc', 'L1', 'HG3', 1700000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S09','NH2', N'Chó Lạp Xưởng', 'L1', 'HG3', 900000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S10','NH3', N'Chó PitBull', 'L1', 'HG2', 1260000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S11','NH3', N'Chó Yorkshire', 'L1', 'HG2', 1100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S12','NH3', N'Chó của JohnWick', 'L1', 'HG3', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S13','NH3', N'Rùa Mike Vàng', 'L4', 'HG1', 120000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S14','NH3', N'Rùa Type Đỏ', 'L4', 'HG3', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S15','NH3', N'Rùa Common', 'L4', 'HG2', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S16','NH2', N'Mèo Anh Lông Ngắn', 'L2', 'HG2', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S17','NH2', N'Chó Golden', 'L1', 'HG3', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S18','NH2', N'Mèo Xiêm', 'L2', 'HG3', 2100000.0000, 65, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S19','NH2', N'Mèo Sphynx', 'L2', 'HG3', 2100000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S20','NH2', N'Chó Bull Pháp', 'L1', 'HG3', 1400000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S21','NH1', N'Chuột hamster robo', 'L3', 'HG2', 1400000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S22','NH1', N'Chuột Hamster Cansumys ', 'L3', 'HG2', 14000000.0000, 100, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S23','NH1', N'Rồng Úc', 'L5', 'HG2', 110000.0000, 17, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S24','NH1', N'Cá Ugly Hỏa Tiễn', 'L6', 'HG2', 110000.0000, 17, NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S25','NH1', N'Cá Ugly Hỏa Tiễn', 'L6', 'HG2', 110000.0000, 17, N'D:\Img\cat_PNG118', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S26','NH1', N'Cá Ugly Hỏa Tiễn', 'L6', 'HG2', 110000.0000, 17, N'D:\Img\husky_PNG37',N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S27','NH1', N'Cá Ugly Hỏa Tiễn', 'L6', 'HG2', 110000.0000, 17, N'D:\Img\cat_PNG118.png', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [MaNhaPhanPhoi],[TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image], [ChuThich]) VALUES ('S28','NH1', N'Cá Ugly Hỏa Tiễn', 'L6', 'HG2', 110000.0000, 17, N'D:\Img\husky_PNG37.png',N'')

INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P1','N1','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P2','N2','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P3','N3','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P4','N4','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P5','N5','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P6','N6','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P7','N7','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P8','N8','NH1',NULL,'16/3/2021',N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [ChuThich]) VALUES ('P9','N9','NH1',NULL,'16/3/2021',N'')

INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P1', 'S01', 3, 7390000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P2', 'S02', 43, 1800000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P3', 'S03', 1, 1300000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P4', 'S04', 1, 20000000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P5', 'S05', 6, 700000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P6', 'S06', 6, 1500000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P7', 'S07', 6, 15000000.0000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES ('P9', 'S09', 43, 8490000.0000, N'')

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH1',N'ĐỖ GIA HUY','25/1/2001',N'Nam',N'BÌNH TÂN TPHCM',0903714326,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH2',N'NGUYỄN NGỌC SƠN','16/3/2001',N'Nam',N'LONG AN ',0906533337,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH4',N'NGUYỄN MINH TRUNG HIẾU','12/6/2001',N'Nam',N'BÌNH DƯƠNG ',0902114326,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH5',N'NGUYỄN HỮU THIỆN TÍN','16/5/2001',N'Nam',N'TÂN PHÚ TPHCM',0903114326,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH6',N'ĐỖ NGỌC SƠN','17/3/2001',N'Nam',N'QUẬN 12 TPHCM',0903714326,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH7',N'ĐẶNG KIM NGÂN','16/7/2001',N'Nữ',N'TPHCM',0906114326,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH8',N'ĐINH HUYỀN TRANG','22/8/2001',N'Nữ',N'GÒ VẤP',090371926,'vip',N'')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES ('KH9',N'LÊ QUỐC NHIÊN','10/9/2001',N'Nam',N'TÂN PHÚ TPHCM',0903094326,N'thường',N'')

INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H1','KH1','N1','S01','11/3/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H2','KH2','N2','S02','15/3/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H4','KH4','N4','S04','23/3/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H5','KH5','N5','S05','28/3/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H6','KH6','N6','S06','1/4/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H7','KH7','N7','S07','5/4/2021',NULL,N'')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaSanPham], [NgayLapHoaDon], [TongTien], [GhiChu]) VALUES ('H9','KH9','N9','S09','15/4/2021',NULL,N'')

INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K1', '11/3/2021', '16/3/2021')
INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K2','17/3/2021', '20/3/2021')
INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K3', '22/3/2021', '27/3/2021')
INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K4','30/3/2021', '3/4/2021')
INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K5','10/4/2021', '16/4/2021')
INSERT [dbo].[DotKhuyenMai] ([MaDot], [NgayBD], [NgayKT]) VALUES ('K6', '20/4/2021', '25/4/2021')

INSERT [dbo].[ChiTietDotKhuyenMai] ([MaDot], [MaSanPham], [TiLeGiamGia]) VALUES ('K1', 'S01',0.5)
INSERT [dbo].[ChiTietDotKhuyenMai] ([MaDot], [MaSanPham], [TiLeGiamGia]) VALUES ('K2', 'S01',0.6)
INSERT [dbo].[ChiTietDotKhuyenMai] ([MaDot], [MaSanPham], [TiLeGiamGia]) VALUES ('K2', 'S02',0.6)

INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H1', 'S01', NULL, 5, 7890000.0000, NULL, '12/3/2021','13/3/2021',N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H2', 'S02', NULL, 6,  1890000.0000, NULL, '15/3/2021','19/3/2021',N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H4', 'S02', NULL, 8,  1890000.0000, NULL, '23/3/2021','24/3/2021',N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H5', 'S01', NULL, 9, 7890000.0000, NULL, '28/3/2021','29/3/2021',N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H6', 'S04', NULL, 10, 21000000.0000, NULL, '1/4/2021','2/4/2021',N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [MucGiam], [SoLuong], [TongTien], [TongTienHoaDon], [NgayDat], [NgayGiao], [GhiChu]) VALUES ('H7', 'S05', NULL, 11, 7490000.0000, NULL, '5/4/2021','6/4/2021',N'')


-------------------------------------------------------
create view v_km
as
	select ChiTietDotKhuyenMai.MaDot,ChiTietHoaDon.MaSanPham,TiLeGiamGia,NgayBD,NgayKT,MaHoaDon,MucGiam,SoLuong,TongTien,TongTienHoaDon,NgayDat
	from ChiTietDotKhuyenMai,DotKhuyenMai,ChiTietHoaDon
	where ChiTietDotKhuyenMai.MaDot=DotKhuyenMai.MaDot
