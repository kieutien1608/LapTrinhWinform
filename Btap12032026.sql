<<<<<<< HEAD
create database DangNhap;
=======
﻿create database DangNhap;
>>>>>>> da7a979 (Toi uu code)
go 
use DangNhap;
go
CREATE TABLE Account
(
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(50) NOT NULL
);
go
CREATE TABLE SinhVien
(
    MaSV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    MaLop VARCHAR(10),
    TenLop NVARCHAR(50)
);
go
INSERT INTO Account VALUES ('admin','123456');
go
INSERT INTO SinhVien VALUES 
('SV001',N'Phùng Thanh Độ ii','2005-12-09',N'Nam',N'Cao Bằng','BDS',N'Lớp Bất động sản 01'),
('SV002',N'Trương Tuấn Tú','2005-11-13',N'Nam',N'Hải Phòng','KT',N'Lớp Kinh tế 01'),
('SV003',N'Nguyễn Tuấn Anh','2005-05-24',N'Nam',N'Nam Định','QTKD',N'Lớp QTKD 01'),
('SV004',N'Nguyễn Anh Dũng','2005-03-15',N'Nam',N'Hà Nội','CNTT',N'Lớp CNTT 01'),
<<<<<<< HEAD
('SV005',N'Hoàng Minh Châu','2005-09-09',N'Nữ',N'Quảng Ninh','MKT',N'Lớp Marketing 01');
=======
('SV005',N'Hoàng Minh Châu','2005-09-09',N'Nữ',N'Quảng Ninh','MKT',N'Lớp Marketing 01');
>>>>>>> da7a979 (Toi uu code)
