using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_HOPDONG:DataProvider
    {
        public static DataTable LayDanhSachHopDong()
        {
            string query = @"EXEC PROC__HOPDONG__GetList";
            return ExecuteQuery(query);
        }

        public static object LayMaHopDongTiepTheo()
        {
            string query = @"SELECT dbo.FUNC__HOPDONG__GetNextID()";
            return ExecuteScalar(query);
        }

        public static int ThemHopDong(DTO_HOPDONG hopDong)
        {
            string query = @"EXEC PROC__HOPDONG__INSERT
                             @MAHOPDONG = @@MAHD ,
                             @MAPHONG = @@MAPHG ,
                             @THOIHAN = @@TH ,
                             @TIENCOC = @@TC";

            object[] obj = new object[]
            {
                hopDong.MaHopDong,
                hopDong.MaPhong, 
                hopDong.ThoiHan, 
                hopDong.TienCoc
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int TraCocHopDong(DTO_HOPDONG hopDong)
        {
            string query = @"EXEC PROC__HOPDONG__TRACOC @MAHOPDONG = @@MHD";
            return ExecuteNonQuery(query, new object[]{hopDong.MaHopDong});
        }

        public static int XoaHopDong(DTO_HOPDONG hopDong)
        {
            string query = @"EXEC PROC__HOPDONG__DELETE @MAHOPDONG = @@MHD";
            return ExecuteNonQuery(query, new object[]{hopDong.MaHopDong});
        }

    }
}
