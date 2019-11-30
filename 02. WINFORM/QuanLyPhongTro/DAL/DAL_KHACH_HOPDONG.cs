using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_KHACH_HOPDONG:DataProvider
    {
        public static int ThemKhachHopDong(DTO_KHACH_HOPDONG khachHopDong)
        {
            string query = @"EXEC PROC__KHACH_HOPDONG__INSERT
                             @MAHOPDONG = @@MAHD ,
                             @MAKHACH = @@MAKH";

            object[] obj = new object[]
            {
                khachHopDong.MaHopDong,
                khachHopDong.MaKhach
            };

            return ExecuteNonQuery(query, obj);
        }
    }
}
