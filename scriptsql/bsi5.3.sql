CREATE DATABASE CafePOSDB;

USE CafePOSDB;


-- 1. Bảng BanAn
CREATE TABLE BanAn (
    MaBan INT IDENTITY(1,1) PRIMARY KEY,
    TenBan NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Trống' -- 'Trống', 'Có khách'
);

-- 2. Bảng DanhMuc
CREATE TABLE DanhMuc (
    MaDanhMuc INT IDENTITY(1,1) PRIMARY KEY,
    TenDanhMuc NVARCHAR(100) NOT NULL
);

-- 3. Bảng MonAn
CREATE TABLE MonAn (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    MaDanhMuc INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_MonAn_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc) ON DELETE CASCADE
);

-- 4. Bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaBan INT NOT NULL,
    GioVao DATETIME NOT NULL DEFAULT GETDATE(),
    GioRa DATETIME NULL,
    TongTien DECIMAL(18,2) DEFAULT 0,
    TrangThai BIT NOT NULL DEFAULT 0, -- 0: Chưa thanh toán, 1: Đã thanh toán
    CONSTRAINT FK_HoaDon_BanAn FOREIGN KEY (MaBan) REFERENCES BanAn(MaBan)
);

-- 5. Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT NOT NULL,
    MaMon INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHoaDon, MaMon),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon) ON DELETE CASCADE,
    CONSTRAINT FK_CTHD_MonAn FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)
);


-- Nạp dữ liệu mẫu
INSERT INTO BanAn (TenBan, TrangThai) VALUES 
(N'Bàn 01', N'Trống'), (N'Bàn 02', N'Trống'), (N'Bàn 03', N'Trống'),
(N'Bàn 04', N'Trống'), (N'Bàn 05', N'Trống'), (N'Bàn 06', N'Trống'),
(N'Bàn 07', N'Trống'), (N'Bàn 08', N'Trống'), (N'Bàn 09', N'Trống');

INSERT INTO DanhMuc (TenDanhMuc) VALUES 
(N'Cà phê'), (N'Trà sữa'), (N'Đồ ăn nhẹ');

INSERT INTO MonAn (TenMon, MaDanhMuc, DonGia) VALUES 
(N'Cà phê đen', 1, 25000),
(N'Cà phê sữa', 1, 29000),
(N'Bạc xỉu', 1, 32000),
(N'Trà sữa trân châu', 2, 35000),
(N'Trà thái xanh', 2, 32000),
(N'Hướng dương', 3, 15000),
(N'Bánh mì nướng bơ tỏi', 3, 25000);

select * from MonAn