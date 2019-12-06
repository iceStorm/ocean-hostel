using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_PHONG:DataProvider
    {
        public static DataTable LayDanhSachPhong()
        {
            string query = @"EXEC dbo.PROC__PHONG__GetList";
            return ExecuteQuery(query);
        }

        public static DataTable LayDanhSachPhongConTrong()
        {
            string query = "EXEC PROC__PHONG_GetEmptyList";
            return ExecuteQuery(query);
        }

        public static DataTable LayDanhSachPhong_TheoMaTang(DTO_TANG tang)
        {
            string query = @"SELECT * FROM PHONG WHERE MATANG = @@MATANG";
            return ExecuteQuery(query, new object[]{tang.MaTang});
        }


        public static DataTable LayThongTinLoaiPhongTheoTenPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__PHONG__LayThongTinLoaiPhongTheoTenPhong
                             @TENPHG = @@TENPHG";

            return ExecuteQuery(query, new object[]{phong.TenPhong});
        }

        public static int ThemPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__PHONG__INSERT
                             @TENPHG = @@TENPHG ,
                             @SOLG_TOIDA = @@SOLG_TOIDA ,
                             @MATANG = @@MATANG ,
                             @MALOAIPHG = @@MALOAIPHG ,
                             @DANGSUACHUA = @@DANGSUACHUA";

            object[] obj = new object[]
            {
                phong.TenPhong,
                phong.SoLuongToiDa,
                phong.MaTang,
                phong.MaLoaiPhong,
                phong.DangSuaChua
            };

            return ExecuteNonQuery(query, obj);
        }


        public static int SuaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC dbo.PROC__PHONG__UPDATE 
                             @MAPHG = @@MAPHG ,
                             @TENPHG = @@TENPHG ,
                             @SOLG_TOIDA = @@SOLG_TOIDA ,
                             @MATANG = @@MATANG ,
                             @MALOAIPHG = @@MALOAIPHG ,
                             @DANGSUACHUA = @@DANGSUACHUA";

            object[] obj = new object[]
            {
                phong.MaPhong,
                phong.TenPhong,
                phong.SoLuongToiDa,
                phong.MaTang,
                phong.MaLoaiPhong,
                phong.DangSuaChua
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int XoaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC dbo.PROC__PHONG__DELETE
                             @MAPHG = @@MAPHG";

            return ExecuteNonQuery(query, new object[]{phong.MaPhong});
        }

        public static object PhongDaDuocThamChieu(DTO_PHONG phong)
        {
            string query = @"SELECT dbo.FUNC__PHONG__IsReferenced( @@MAPHG )";
            return ExecuteScalar(query, new object[]{phong.MaPhong});
        }

    }
}
