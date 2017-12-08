create database QLDT
go
use QLDT
go


Create table [LoaiDienThoai]
(
	[MaLDT] Char(2) NOT NULL,
	[TenLDT] Nvarchar(50) NULL,
Primary Key ([MaLDT])
) 
go

Create table [DienThoai]
(
	[MaDT] Char(5) NOT NULL,
	[MaLDT] Char(2) NOT NULL,
	[TenDT] Nvarchar(50) NOT NULL,
	[ManHinh] Nvarchar(50) NOT NULL,
	[CameraSau] Nvarchar(20) NOT NULL,
	[CameraTruoc] Nvarchar(20) NOT NULL,
	[RAM] Varchar(10) NULL,
	[ROM] Varchar(10) NULL,
	[System] Nvarchar(100) NULL,
	[KichThuoc] Nvarchar(50) NULL,
	[Pin] Varchar(20) NULL,
	[GiaThanh] Varchar(20) NULL,
Primary Key ([MaDT])
) 
go

Create table [HoaDon]
(
	[SoHD] Char(7) NOT NULL,
	[MaKH] Varchar(5) NOT NULL,
	[MaNV] Varchar(5) NOT NULL,
	[NgayLapHD] Datetime NULL,
Primary Key ([SoHD])
) 
go

Create table [ChiTietHoaDon]
(
	[SoHD] Char(7) NOT NULL,
	[MaDT] Char(5) NOT NULL,
	[SoLuong] Char(3) NULL,
	[DonGia] Varchar(10) NULL,
Primary Key ([SoHD],[MaDT])
) 
go

Create table [NhanVien]
(
	[MaNV] Varchar(5) NOT NULL,
	[TenNV] Nvarchar(50) NULL,
	[SDT_NV] Varchar(12) NULL,
	[DiaChi_NV] Nvarchar(100) NULL,
Primary Key ([MaNV])
) 
go

Create table [KhachHang]
(
	[MaKH] Varchar(5) NOT NULL,
	[TenKH] Nvarchar(30) NULL,
	[SDT_KH] Varchar(12) NULL,
Primary Key ([MaKH])
) 
go


Alter table [DienThoai] add  foreign key([MaLDT]) references [LoaiDienThoai] ([MaLDT])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([MaDT]) references [DienThoai] ([MaDT])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([SoHD]) references [HoaDon] ([SoHD])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaNV]) references [NhanVien] ([MaNV])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaKH]) references [KhachHang] ([MaKH])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


