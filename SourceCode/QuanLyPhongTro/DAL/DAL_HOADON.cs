using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_HOADON:DataProvider
    {
        public static DataTable LayDanhSachHoaDon()
        {
            string query = @"SELECT * FROM VW__HOADON__GetList";
            return ExecuteQuery(query);
        }

        public static int ThanhToanHoaDon(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON__PAY
                             @MAHOADON = @@MAHOADON";

            return ExecuteNonQuery(query, new object[]{hoaDon.MaHoaDon});
        }

        public static int ThemHoaDon(DTO_HOADON hoaDon, DTO_HOADON_DIENNUOC hoaDonDienNuoc)
        {
            string query = @"EXEC PROC__HOADON__INSERT
                             @#MAPHG = @@MAPHG ,
                             @#THANG = @@THANG ,
                             @#NAM = @@NAM ,
                             @#SODIEN = @@SODIEN ,
                             @#SONUOC = @@SONUOC";

            object[] obj = new object[]
            {
                hoaDon.MaPhong,
                hoaDon.Thang,
                hoaDon.Nam,
                hoaDonDienNuoc.SoDien,
                hoaDonDienNuoc.SoNuoc
            };

            return ExecuteNonQuery(query, obj);
        }


        public static int XoaHoaDon(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON__DELETE @MAHOADON = @@MAHD";
            return ExecuteNonQuery(query, new object[]{hoaDon.MaHoaDon});
        }

        public static object PhongDaGhiHoaDon(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON__PhongDaGhiHoaDon
                             @MAPHG = @@MAPHG ,
                             @THANG = @@THANG ,
                             @NAM = @@NAM";

            object[] obj = new object[]
            {
                hoaDon.MaPhong,
                hoaDon.Thang,
                hoaDon.Nam
            };

            return ExecuteScalar(query, obj);
        }

    }
}
