CREATE DATABASE HotelDB;
USE HotelDB;
-- 1. Bảng Phòng
CREATE TABLE Phong (
    SoPhong VARCHAR(10) PRIMARY KEY,
    LoaiPhong NVARCHAR(50) NOT NULL,
    GiaTheoGio DECIMAL(18,2) NOT NULL CHECK (GiaTheoGio >= 0),
    TrangThai NVARCHAR(30) DEFAULT N'Trống' -- 'Trống', 'Đang ở', 'Đang dọn dẹp'
);

-- 2. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    CCCD VARCHAR(20) UNIQUE NOT NULL,
    SoDienThoai VARCHAR(15)
);

-- 3. Bảng Dịch Vụ
CREATE TABLE DichVu (
    MaDV INT IDENTITY(1,1) PRIMARY KEY,
    TenDV NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0)
);

-- 4. Bảng Phiếu Đặt Phòng
CREATE TABLE PhieuDatPhong (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    SoPhong VARCHAR(10) FOREIGN KEY REFERENCES Phong(SoPhong),
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    NgayNhanPhong DATETIME DEFAULT GETDATE(),
    NgayTraPhong DATETIME NULL,
    TongTienThanhToan DECIMAL(18,2) DEFAULT 0
);

-- 5. Bảng Sử Dụng Dịch Vụ
CREATE TABLE SuDungDichVu (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuDatPhong(MaPhieu) ON DELETE CASCADE,
    MaDV INT FOREIGN KEY REFERENCES DichVu(MaDV),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    ThoiGian DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MaPhieu, MaDV, ThoiGian)
);

-- NẠP DỮ LIỆU MẪU
INSERT INTO Phong (SoPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
('P101', N'Đơn', 50000, N'Trống'),
('P102', N'Đơn', 50000, N'Trống'),
('P201', N'Đôi', 80000, N'Trống'),
('P202', N'Đôi', 80000, N'Trống'),
('P301', N'VIP', 150000, N'Trống');

INSERT INTO DichVu (TenDV, DonGia) VALUES
(N'Nước suối', 10000),
(N'Nước ngọt', 15000),
(N'Mì ly', 20000),
(N'Giặt ủi (kg)', 30000);