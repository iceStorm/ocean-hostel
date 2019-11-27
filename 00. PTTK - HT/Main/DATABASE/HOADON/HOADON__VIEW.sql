USE OCEAN_HOSTEL
GO


---------------------------------------------------------
CREATE VIEW VW__HOADON__GetList
AS
	SELECT hd.MAHOADON, hd.MAPHG, hd.THANG, hd.NAM, 
			hd.TIENPHONG, SUM(hdv.GIADICHVU) AS TIENDICHVU, 
			dbo.FUNC__HOADON__TongTienDien(hd.MAPHG, hd.THANG, hd.NAM) AS TIENDIEN,
			dbo.FUNC__HOADON__TongTienNuoc(hd.MAPHG, hd.THANG, hd.NAM) AS TIENNUOC,
			(hd.TIENPHONG + SUM(hdv.GIADICHVU) + 
				dbo.FUNC__HOADON__TongTienDien(hd.MAPHG, hd.THANG, hd.NAM) +
				dbo.FUNC__HOADON__TongTienNuoc(hd.MAPHG, hd.THANG, hd.NAM)) AS TONGTIEN,
			hd.DATHANHTOAN
	FROM HOADON hd, HOADON_DICHVU hdv
	WHERE hdv.MAHOADON = hd.MAHOADON
	GROUP BY hd.MAHOADON, hd.MAPHG, hd.THANG, hd.NAM, hd.TIENPHONG, hd.DATHANHTOAN
GO