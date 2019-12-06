using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_LOAIPHONG:DataProvider
    {
        public static DataTable LayDanhSachLoaiPhong()
        {
            string query = @"SELECT *
                             FROM LOAIPHONG";

            return ExecuteQuery(query);
        }

        public static DataTable LayDuLieuThongKe()
        {
            string query = @"EXEC PROC__LOAIPHONG__THONGKE";
            return ExecuteQuery(query);
        }

        public static int ThemLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            string query = @"EXEC PROC__LOAIPHONG__INSERT
                                    @TENLOAIPHG = @@TENLP , @GIAPHG = @@GIAPHG";

            return ExecuteNonQuery(query, new object[]{loaiPhong.TenLoaiPhong, loaiPhong.GiaPhong});
        }

        public static int SuaLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            string query = @"EXEC PROC__LOAIPHONG__UPDATE 
                                    @MALOAIPHG = @@MALP , 
                                    @TENLOAIPHG = @@TENLP , 
                                    @GIAPHG = @@GIAPHG";
            
            object[] obj = new object[]
            {
                loaiPhong.MaLoaiPhong,
                loaiPhong.TenLoaiPhong,
                loaiPhong.GiaPhong
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int XoaLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            string query = @"EXEC PROC__LOAIPHONG__DELETE @MALOAIPHG = @@MALP";
            return ExecuteNonQuery(query, new object[]{loaiPhong.MaLoaiPhong});
        }

        public static object LoaiPhongDuocThamChieu(DTO_LOAIPHONG loaiPhong)
        {
            string query = @"SELECT COUNT(MAPHG)
                             FROM PHONG
                             WHERE MALOAIPHG = @@MALOAIPHG";

            return ExecuteScalar(query, new object[]{loaiPhong.MaLoaiPhong});
        }

    }
}
