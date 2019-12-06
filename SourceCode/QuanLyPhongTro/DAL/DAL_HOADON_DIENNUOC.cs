using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_HOADON_DIENNUOC:DataProvider
    {
        public static DataTable LayThongTinDienNuocThangTruoc(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON_DIENNUOC__LayThongTinThangTruoc
                             @MAPHG = @@MAPHG ,
                             @THANG = @@THANG ,
                             @NAM = @@NAM";

            object[] obj = new object[]
            {
                hoaDon.MaPhong,
                hoaDon.Thang,
                hoaDon.Nam
            };

            return ExecuteQuery(query, obj);
        }

        public static DataTable LayThongTinDienNuocThangHienTai(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON_DIENNUOC__LayThongTinThangHienTai
                             @MAPHG = @@MAPHG ,
                             @THANG = @@THANG ,
                             @NAM = @@NAM";

            object[] obj = new object[]
            {
                hoaDon.MaPhong,
                hoaDon.Thang,
                hoaDon.Nam
            };

            return ExecuteQuery(query, obj);
        }

    }
}
