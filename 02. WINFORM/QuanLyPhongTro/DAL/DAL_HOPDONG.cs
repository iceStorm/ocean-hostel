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
            string query = @"SELECT * FROM HOPDONG";
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

    }
}
