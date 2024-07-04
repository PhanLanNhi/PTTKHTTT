create database QLNhaHang

use QLNhaHang

create table ThongTinDangNhap
(
	usn varchar(15) not null primary key,
	pwd varchar(15)
)

insert into ThongTinDangNhap values('admin', 'admin')

create table InfoFood
(
	MaMon varchar(10) not null primary key,
	TenMon nvarchar(30),
	DonGia int,
	ThoiGian nvarchar(30)
)

insert into InfoFood values
('B001', N'Bánh mì que nướng', 49000, '11/5/2022 12:06:51 AM'), 
('B002', N'Bánh mì bơ tỏi', 49000, '11/5/2022 12:06:54 AM'),
('B003', N'Bánh mì kẹp nướng', 89000, '11/5/2022 12:06:56 AM'),
('D001', N'Pepsi 330ml', 19000, '11/5/2022 12:06:57 AM'),
('D002', N'7Up 330ml', 15000, '11/5/2022 12:06:59 AM'),
('D003', N'Heineken 330ml', 29000, '11/5/2022 12:07:08 AM'),
('D004', N'Tiger Crystal 330ml', 29000, '11/5/2022 12:07:07 AM'),
('D005', N'Mirinda Soda kem 330ml', 15000, '11/5/2022 12:08:02 AM'),
('D006', N'Aquafina 500ml', 15000, '11/5/2022 12:08:03 AM'),
('G001', N'Gà lắc phô mai', 109000, '11/5/2022 12:08:05 AM'),
('G002', N'Gà giòn xốt Hàn', 99000, '11/5/2022 12:08:07 AM'),
('G003', N'Gà giòn xốt tương tỏi', 119000, '11/5/2022 12:10:34 AM'),
('G004', N'Gà Popcorn', 109000, '11/5/2022 12:10:43 AM'),
('P005', N'Pizza Hawai', 159000, '11/5/2022 12:12:13 AM'),
('M002', N'Mỳ Ý giăm bông', 99000, '11/5/2022 12:08:11 AM'),
('M003', N'Mỳ Ý thịt bò bằm', 129000, '11/5/2022 12:07:53 AM'),
('P001', N'Pizza Hải sản cao cấp', 139000, '11/5/2022 12:12:13 AM'),
('P002', N'Pizza Tôm Cocktail', 139000, '11/5/2022 12:12:13 AM'),
('P003', N'Pizza Thịt xông khói', 169000, '11/5/2022 12:12:13 AM'),
('P004', N'Pizza Phô mai', 119000, '11/5/2022 12:12:13 AM'),
('M001', N'Mỳ Ý sốt kem tươi', 119000, '11/5/2022 12:12:13 AM'),
('P006', N'Pizza Rau củ', 119000, '11/5/2022 12:12:13 AM'),
('P007', N'Pizza Gà nướng tam vị', 160000, '11/5/2022 12:12:13 AM'),
('S001', N'Salad đặc sắc', 49000, '11/5/2022 12:12:13 AM'),
('S002', N'Salad gà không xương', 69000, '11/5/2022 12:12:13 AM'),
('S003', N'Salad da cá hồi', 69000, '11/5/2022 12:12:13 AM'),
('S004', N'Salad trộn xốt Caesar', 59000, '11/5/2022 12:12:13 AM'),
('B004', N'Bánh mì nướng mật', 29000, '11/5/2022 12:12:13 AM')


create table HoaDon
(
	MaHD varchar(10) not null primary key,
	TenKH nvarchar(40),
	SoTien float,
	ThoiGian varchar(40)
)

create table ChiTietHD
(
	MaHD varchar(10) not null,
	MaMon varchar(10) not null, 
	SoLuong int, 
	primary key (MaHD, MaMon),
	foreign key (MaHD) references HoaDon(MaHD)
)

create table ThongTinNV
(
	MaNV varchar(10) not null primary key,
	TenNV nvarchar(40),
	GioiTinh nvarchar(10),
	NgaySinh varchar(40),
	Sdt varchar(12),
	Que nvarchar(15)
)