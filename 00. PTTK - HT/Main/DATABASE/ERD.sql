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
    MAKHU       VARCHAR(6)          PRIMARY KEY,
    TENKHU      NVARCHAR(15)        NOT NULL
);


CREATE  TABLE   TANG
(
    MATANG      VARCHAR(8)          PRIMARY KEY,
    TENTANG     NVARCHAR(15)        NOT NULL,
    MAKHU       VARCHAR(6)          FOREIGN KEY REFERENCES KHU(MAKHU)
);


CREATE  TABLE   LOAIPHONG
(
    MALOAIPHG   VARCHAR(10)     PRIMARY KEY,
    TENLOAIPHG  NVARCHAR(15)    NOT NULL
);


CREATE  TABLE   PHONG
(

);