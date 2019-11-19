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


CREATE  TABLE   KHU
(
    MAKHU       VARCHAR(10),
    TENKHU      NVARCHAR(15)        NOT NULL,

    CONSTRAINT  PK__KHU             PRIMARY KEY(MAKHU),
    CONSTRAINT  UN__KHU             UNIQUE(TENKHU)
);


CREATE  TABLE   TANG
(
    MATANG      VARCHAR(10),
    TENTANG     NVARCHAR(15)        NOT NULL,
    MAKHU       VARCHAR(10)          NOT NULL,

    CONSTRAINT  PK__TANG            PRIMARY KEY(MATANG),
    CONSTRAINT  FK__TANG            FOREIGN KEY(MAKHU)  REFERENCES KHU(MAKHU)
);


CREATE  TABLE   LOAIPHONG
(
    MALOAIPHG   VARCHAR(12)         PRIMARY KEY,
    TENLOAIPHG  NVARCHAR(15)        NOT NULL,
    GIAPHG      INT                 NOT NULL,

    CONSTRAINT  PK__LOAIPHONG       PRIMARY KEY(MALOAIPHG),
    CONSTRAINT  UN__LOAIPHONG       UNIQUE(TENLOAIPHG)
);


CREATE  TABLE   PHONG
(
    MAPHG       VARCHAR(10),
    TENPHG      NVARCHAR(15)       NOT NULL,
    
);