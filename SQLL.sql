CREATE DATABASE DOAN
USE DOAN



CREATE TABLE NHANVIEN
(
MANV NVARCHAR(50) PRIMARY KEY NOT NULL,
TENNV NVARCHAR(50),
GIOITINH NVARCHAR(10),
NGAYSINH DATE,
SDT NVARCHAR(50),
CHUCVU NVARCHAR(50),
LUONG FLOAT
)

CREATE TABLE TAIKHOAN
(
USN CHAR(50) PRIMARY KEY NOT NULL,
PWD CHAR(50) 
)

CREATE TABLE TK_NV
(
MANV NVARCHAR(50),
USN CHAR(50),
FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
FOREIGN KEY (USN) REFERENCES TAIKHOAN(USN)
)

CREATE TABLE LICHLAM
(
MANV NVARCHAR(50),
CA INT,
NGAYLAM DATE,
PRIMARY KEY (MANV, NGAYLAM),
FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE BAN
(
MABAN NVARCHAR(50) PRIMARY KEY NOT NULL,
TENBAN NVARCHAR(50),
LOAIBAN NVARCHAR(50)
)

CREATE TABLE NV_BAN
(
MABAN NVARCHAR(50),
MANV NVARCHAR(50),
TENKH NVARCHAR(50),
SDT NVARCHAR(50),
THOIGIAN DATE,
PRIMARY KEY(MABAN, THOIGIAN),
FOREIGN KEY (MABAN) REFERENCES BAN(MABAN),
FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE INFOFOOD
(
MAMON NVARCHAR(50) PRIMARY KEY NOT NULL,
TENMON NVARCHAR(50),
DONGIA FLOAT,
TIENLAI FLOAT,
THOIGIAN DATE
)

CREATE TABLE KHUYENMAI
(
MAKM NVARCHAR(50) PRIMARY KEY NOT NULL,
TENKM NVARCHAR(50),
GIATRI INT,
THOIGIANBD DATE,
THOIGIANKT DATE
)

CREATE TABLE HOADON
(
MAHD NVARCHAR(50) PRIMARY KEY NOT NULL,
TENKH NVARCHAR(50),
SOTIEN FLOAT,
THOIGIAN DATE,
MANV NVARCHAR(50),
FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE CHITIETHD
(
MAHD NVARCHAR(50),
MAMON NVARCHAR(50),
SOLUONG INT,
PRIMARY KEY(MAHD, MAMON),
FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
FOREIGN KEY (MAMON) REFERENCES INFOFOOD(MAMON)
)

CREATE TABLE HD_KM
(
MAHD NVARCHAR(50),
MAKM NVARCHAR(50),
FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
FOREIGN KEY (MAKM) REFERENCES KHUYENMAI(MAKM)
)


