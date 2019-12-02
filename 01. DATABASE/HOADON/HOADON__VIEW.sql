USE OCEAN_HOSTEL
GO


---------------------------------------------------------
CREATE VIEW VW__HOADON__GetList
AS
	SELECT hd.MAHOADON, hd.MAPHG, p.TENPHG, hd.THANG, hd.NAM, hd.TIENPHONG,
			dbo.FUNC__HOADON__TongTienDichVu(hd.MAPHG, hd.THANG, hd.NAM) AS TIENDICHVU, 
			dbo.FUNC__HOADON__TongTienDien(hd.MAPHG, hd.THANG, hd.NAM) AS TIENDIEN,
			dbo.FUNC__HOADON__TongTienNuoc(hd.MAPHG, hd.THANG, hd.NAM) AS TIENNUOC,
			(hd.TIENPHONG + 
				dbo.FUNC__HOADON__TongTienDichVu(hd.MAPHG, hd.THANG, hd.NAM) + 
				dbo.FUNC__HOADON__TongTienDien(hd.MAPHG, hd.THANG, hd.NAM) +
				dbo.FUNC__HOADON__TongTienNuoc(hd.MAPHG, hd.THANG, hd.NAM)) AS TONGTIEN,
			hd.DATHANHTOAN
	FROM HOADON hd FULL OUTER JOIN HOADON_DICHVU hdv ON hdv.MAHOADON = hd.MAHOADON, PHONG p 
	WHERE p.MAPHG = hd.MAPHG
	GROUP BY hd.MAHOADON, hd.MAPHG, hd.THANG, hd.NAM, hd.TIENPHONG, hd.DATHANHTOAN, p.TENPHG
GO
