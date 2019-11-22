-- Create a new database called 'OCEAN_HOSTEL'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'OCEAN_HOSTEL'
)
CREATE DATABASE OCEAN_HOSTEL
GO

USE OCEAN_HOSTEL
GO



CREATE  TABLE   NGUOIDUNG
(
    TENDN           VARCHAR(30),
    MATKHAU         VARCHAR(100)                NOT NULL,   --  Mật khẩu dài khi được mã hoá
    HO              NVARCHAR(10)                NOT NULL,
    TEN             NVARCHAR(30)                NOT NULL,
    DANGNHAPLANCUOI DATETIME                    NOT NULL				DEFAULT '2000-01-01',
    TRANGTHAI       BIT                         NOT NULL                DEFAULT 'True',     --  Active hay chưa

    CONSTRAINT      PK__NGUOIDUNG               PRIMARY KEY(TENDN)
);


CREATE  TABLE   NHOMNGUOIDUNG
(
    MANHOM          VARCHAR(10),
    TENNHOM         NVARCHAR(20)                NOT NULL,

    CONSTRAINT      PK__NHOMNGUOIDUNG           PRIMARY KEY(MANHOM)
);


CREATE TABLE    NGUOIDUNG_NHOM
(
    TENDN           VARCHAR(30),
    MANHOM          VARCHAR(10),

    CONSTRAINT      PK__NGUOIDUNG_NHOM          PRIMARY KEY(TENDN, MANHOM),
    CONSTRAINT      FK__NGUOIDUNG_NHOM__TENDN   FOREIGN KEY(TENDN)  REFERENCES NGUOIDUNG(TENDN),
    CONSTRAINT      FK__NGUOIDUNG_NHOM__MANHOM  FOREIGN KEY(MANHOM) REFERENCES NHOMNGUOIDUNG(MANHOM)
);


CREATE  TABLE   MANHINH     --  Form chức năng - form con
(
    MAMANHINH       VARCHAR(10),
    TENMANHINH      NVARCHAR(20),

    CONSTRAINT      PK__MANHINH                 PRIMARY KEY(MAMANHINH),
    CONSTRAINT      UN__MANHINH__TENMANHINH     UNIQUE(TENMANHINH)
);


CREATE  TABLE   PHANQUYEN
(
    MANHOM          VARCHAR(10),
    MAMANHINH       VARCHAR(10),
    COQUYEN         BIT                         NOT NULL                    DEFAULT 'True',

    CONSTRAINT      PK__PHANQUYEN               PRIMARY KEY(MANHOM, MAMANHINH),
    CONSTRAINT      FK__PHANQUYEN__MANHOM       FOREIGN KEY(MANHOM) REFERENCES NHOMNGUOIDUNG(MANHOM),
    CONSTRAINT      FK__PHANQUYEN__MAMANHINH    FOREIGN KEY(MAMANHINH)  REFERENCES MANHINH(MAMANHINH)
);


CREATE  TABLE   LICHSU
(
    TENDN           VARCHAR(30),
    THOIGIAN        DATETIME                    NOT NULL                    DEFAULT GETDATE(),
    NOIDUNG         NVARCHAR(75)                NOT NULL,

    CONSTRAINT      FK__LICHSU                  FOREIGN KEY(TENDN)  REFERENCES NGUOIDUNG(TENDN)
);




CREATE  TABLE   KHU
(
    MAKHU           VARCHAR(10),
    TENKHU          NVARCHAR(15)                NOT NULL,

    CONSTRAINT      PK__KHU                     PRIMARY KEY(MAKHU),
    CONSTRAINT      UN__KHU                     UNIQUE(TENKHU)
);


CREATE  TABLE   TANG
(
    MATANG          VARCHAR(10),
    TENTANG         NVARCHAR(15)                NOT NULL,
    MAKHU           VARCHAR(10)                 NOT NULL,

    CONSTRAINT      PK__TANG                    PRIMARY KEY(MATANG),
    CONSTRAINT      FK__TANG__MAKHU             FOREIGN KEY(MAKHU)  REFERENCES KHU(MAKHU)
);


CREATE  TABLE   LOAIPHONG
(
    MALOAIPHG       VARCHAR(15),
    TENLOAIPHG      NVARCHAR(15)                NOT NULL,
    GIAPHG          INT                         NOT NULL,

    CONSTRAINT      PK__LOAIPHONG               PRIMARY KEY(MALOAIPHG),
    CONSTRAINT      UN__LOAIPHONG               UNIQUE(TENLOAIPHG)
);


CREATE  TABLE   PHONG
(
    MAPHG           VARCHAR(10),
    TENPHG          NVARCHAR(15)                NOT NULL,
    SOLG_TOIDA      INT                         NOT NULL,
    SOLG_DANGO      INT                         NOT NULL            DEFAULT 0,
    TRANGTHAI       NVARCHAR(15)                NOT NULL            DEFAULT N'Còn trống',
    MATANG          VARCHAR(10)                 NOT NULL,
    MALOAIPHG       VARCHAR(15)                 NOT NULL,

    CONSTRAINT      PK__PHONG                   PRIMARY KEY(MAPHG),
    CONSTRAINT      FK__PHONG__MATANG           FOREIGN KEY(MATANG) REFERENCES TANG(MATANG),
    CONSTRAINT      FK__PHONG__MALOAIPHG        FOREIGN KEY(MALOAIPHG)  REFERENCES LOAIPHONG(MALOAIPHG),
    CONSTRAINT      CK__PHONG__TRANGTHAI        CHECK(TRANGTHAI IN (N'Còn trống', N'Đã đầy', N'Đang sửa chữa'))
);


CREATE  TABLE   THIETBI
(
    MATBI           VARCHAR(10),
    TENTBI          NVARCHAR(25)                NOT NULL,
    GIATBI          INT                         NOT NULL,
    NGAYNHAP        DATE                        NOT NULL            DEFAULT GETDATE(),
    SOLG_PHANBO     INT                         NOT NULL            DEFAULT 0,
    SOLG_TON        INT                         NOT NULL,
    SOLG_HONG       INT                         NOT NULL            DEFAULT 0,

    CONSTRAINT      PK__THIETBI                 PRIMARY KEY(MATBI),
    CONSTRAINT      UN__THIETBI                 UNIQUE(TENTBI)
);


CREATE  TABLE   THIETBI_PHONG
(
    MATBI           VARCHAR(10),
    MAPHG           VARCHAR(10),
    THOIGIANCAP     DATETIME                    DEFAULT GETDATE(),
    TRANGTHAI       NVARCHAR(15)                NOT NULL            DEFAULT N'Bình thường',

    CONSTRAINT      PK__THIETBI_PHONG           PRIMARY KEY(MAPHG, MATBI, THOIGIANCAP),
    CONSTRAINT      CK__THIETBI_PHONG_TRANGTHAI	CHECK(TRANGTHAI IN (N'Bình thường', N'Hư hỏng')),
    CONSTRAINT		FK__THIETBI_PHONG__MAPHG	FOREIGN KEY(MAPHG)	REFERENCES PHONG(MAPHG),
    CONSTRAINT		FK__THIETBI_PHONG__MATBI	FOREIGN	KEY(MATBI)	REFERENCES THIETBI(MATBI)
);


CREATE  TABLE   HOPDONG
(
    MAHOPDONG       VARCHAR(10),
    MAPHG           VARCHAR(10)                 NOT NULL,
    THOIHAN         INT                         NOT NULL,
    THOIGIANTAO     DATETIME                    NOT NULL            DEFAULT GETDATE(),
    TRANGTHAI       NVARCHAR(15)                NOT NULL            DEFAULT N'Có hiệu lực',
    TIENCOC         INT                         NOT NULL            DEFAULT 0,
    DATRACOC        BIT                         NOT NULL            DEFAULT 'False',                --  Đã trả cọc

    CONSTRAINT      PK__HOPDONG                 PRIMARY KEY(MAHOPDONG),
    CONSTRAINT      FK__HOPDONG__MAPHONG        FOREIGN KEY(MAPHG)  REFERENCES PHONG(MAPHG),
    CONSTRAINT      CK__HOPDONG__TRANGTHAI      CHECK(TRANGTHAI IN (N'Có hiệu lực', N'Hết hiệu lực'))
);


CREATE  TABLE   KHACH
(
    MAKHACH         VARCHAR(10),
    HO              NVARCHAR(10)                NOT NULL,
    TEN             NVARCHAR(30)                NOT NULL,
    GIOITINH        NVARCHAR(10)                NOT NULL            DEFAULT N'Không biết',
    NGAYSINH        DATE                        NOT NULL,
    QUEQUAN         NVARCHAR(75)                NOT NULL,
    SOCANCUOC       VARCHAR(20)                 NOT NULL,
    SODIENTHOAI     VARCHAR(15)                 NULL,
    TRANGTHAI       NVARCHAR(15)                NOT NULL            DEFAULT N'Đang ở',

    CONSTRAINT      PK__KHACH                   PRIMARY KEY(MAKHACH),
    CONSTRAINT      CK__KHACH__TRANGTHAI        CHECK(TRANGTHAI IN (N'Đang ở', N'Tạm vắng', N'', N'Hết hợp đồng')),
    CONSTRAINT      CK__KHACH__GIOITINH         CHECK(GIOITINH IN (N'Nam', N'Nữ', N'Khác', N'Không biết')),
    CONSTRAINT      UN__KHACH__SOCANCUOC        UNIQUE(SOCANCUOC)
);


CREATE  TABLE   KHACH_TAMVANG
(
    MAKHACH         VARCHAR(10),
    BATDAU          DATE                        DEFAULT GETDATE(),
    THOIHAN         INT							NULL,
    LYDO            NVARCHAR(75)                NULL,
    TRANGTHAI       BIT                         NOT NULL            DEFAULT 'True',

    CONSTRAINT      PK__KHACH_TAMVANG           PRIMARY KEY(MAKHACH, BATDAU),
    CONSTRAINT		FK__KHACH_TAMVANG__MAKHACH	FOREIGN KEY(MAKHACH)	REFERENCES KHACH(MAKHACH)
);


CREATE  TABLE   KHACH_HOPDONG
(
    MAHOPDONG       VARCHAR(10),
    MAKHACH         VARCHAR(10),

    CONSTRAINT      PK__KHACH_HOPDONG           	PRIMARY KEY(MAKHACH, MAHOPDONG),
    CONSTRAINT		FK__KHACH_HOPDONG__MAKHACH		FOREIGN KEY(MAKHACH)	REFERENCES KHACH(MAKHACH),
    CONSTRAINT		FK__KHACH_HOPDONG__MAHOPDONG	FOREIGN KEY(MAHOPDONG)	REFERENCES HOPDONG(MAHOPDONG)
);


CREATE  TABLE   NGUOITHAN
(
    MANGTHAN        VARCHAR(15),
    HO              NVARCHAR(10)                NOT NULL,
    TEN             NVARCHAR(30)                NOT NULL,
    GIOITINH        NVARCHAR(10)                NOT NULL,
    SODIENTHOAI     VARCHAR(15)                 NULL,
    DIACHI          NVARCHAR(75)                NOT NULL            DEFAULT N'Không biết',
    QUANHE          NVARCHAR(20)                NOT NULL            DEFAULT N'Không biết',
    MAKHACH         VARCHAR(10)                 NOT NULL,

    CONSTRAINT      PK__NGUOITHAN               PRIMARY KEY(MANGTHAN),
    CONSTRAINT		UN__NGUOITHAN				UNIQUE(MANGTHAN, MAKHACH),
    CONSTRAINT      FK__NGUOITHAN__MAKHACH      FOREIGN KEY(MAKHACH)   REFERENCES KHACH(MAKHACH),
    CONSTRAINT      CK__NGUOITHAN__GIOITINH     CHECK(GIOITINH IN (N'Nam', N'Nữ', N'Khác', N'Không biết')),
);


CREATE  TABLE   NGUOITHAN_TAMTRU
(
    MANGTHAN        VARCHAR(15),
    BATDAU          DATE                        DEFAULT GETDATE(),
    THOIHAN         INT                         NULL,
    TRANGTHAI       BIT                         NOT NULL            DEFAULT 'True',

    CONSTRAINT      PK__NGUOITHAN_TAMTRU        PRIMARY KEY(MANGTHAN, BATDAU),
    CONSTRAINT      FK__NGUOITHAN_TAMTRU        FOREIGN KEY(MANGTHAN)   REFERENCES NGUOITHAN(MANGTHAN)
);


CREATE  TABLE   DICHVU
(
    MADICHVU        VARCHAR(10),
    TENDICHVU       NVARCHAR(20)                NOT NULL,
    GIADICHVU       INT                         NOT NULL,

    CONSTRAINT      PK__DICHVU                  PRIMARY KEY(MADICHVU),
    CONSTRAINT      UN__DICHVU__TENDICHVU       UNIQUE(TENDICHVU)
);


CREATE  TABLE   DICHVU_PHONG
(
    MADICHVU        VARCHAR(10),
    MAPHG           VARCHAR(10),
    TRANGTHAI       BIT                         NOT NULL        DEFAULT 'False',    -- Sử dụng dịch vụ hay không

    CONSTRAINT      PK__DICHVU_PHONG            PRIMARY KEY(MADICHVU, MAPHG),
    CONSTRAINT      FK__DICHVU_PHONG__MADICHVU  FOREIGN KEY(MADICHVU)   REFERENCES DICHVU(MADICHVU),
    CONSTRAINT      FK__DICHVU_PHONG__MAPHONG   FOREIGN KEY(MAPHG)  REFERENCES  PHONG(MAPHG)
);


CREATE  TABLE   HOADON
(
    MAHOADON        VARCHAR(15),
    MAPHG           VARCHAR(10)                 NOT NULL,
    THANG           INT                         NOT NULL,
    NAM             INT                         NOT NULL,
    TRANGTHAI       BIT                         NOT NULL        DEFAULT 'False',     --  Thanh toán đủ hay chưa
    TIENPHONG		INT							NOT NULL,							 --  Giá cũ vẫn giữ nguyên khi loại phòng thay đổi giá

    CONSTRAINT      PK__HOADON                  PRIMARY KEY(MAHOADON),
    CONSTRAINT      UN__HOADON                  UNIQUE(MAPHG, THANG, NAM),
    CONSTRAINT      FK__HOADON__MAPHG           FOREIGN KEY(MAPHG)  REFERENCES PHONG(MAPHG)
);


CREATE  TABLE   HOADON_DIENNUOC     --  1 hoá đơn chỉ có một thông tin điện nước (cho một tháng) ==> 1:1
(
    MAHOADON        VARCHAR(15),
    GIADIEN         INT                                 NOT NULL,
    GIANUOC         INT                                 NOT NULL,
    SODIEN          INT                                 NOT NULL,
    SONUOC          INT                                 NOT NULL,

    CONSTRAINT      PK__HOADON_DIENNUOC                 PRIMARY KEY(MAHOADON),  --  Quan hệ 1:1
    CONSTRAINT      FK__HOADON_DIENNUOC__MAHOADON       FOREIGN KEY(MAHOADON)   REFERENCES HOADON(MAHOADON)
);


CREATE  TABLE   HOADON_DICHVU   --  1 hoá đơn có thể nhiều dịch vụ ==> 1:n
(
    MAHOADON        VARCHAR(15),
    MADICHVU        VARCHAR(10),
    TENDICHVU       NVARCHAR(20),
    GIADICHVU       INT,

    CONSTRAINT      PK__HOADON_DICHVU                   PRIMARY KEY(MADICHVU),
    CONSTRAINT      FK__HOADON_DICHVU__MAHOADON         FOREIGN KEY(MAHOADON)   REFERENCES HOADON(MAHOADON)
);