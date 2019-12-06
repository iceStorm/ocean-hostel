using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_KHU:DataProvider
    {
        public static DataTable LayDanhSachKhu()
        {
            string query = @"SELECT * FROM KHU";
            return ExecuteQuery(query);
        }

        public static int ThemKhu(DTO_KHU khu)
        {
            string query = @"EXEC PROC__KHU__INSERT @TENKHU = @@TENKHU";
            return ExecuteNonQuery(query, new object[]{khu.TenKhu});
        }

        public static int CapNhatKhu(DTO_KHU khu)
        {
            string query = @"EXEC PROC__KHU__UPDATE @MAKHU = @@MAKHU , @TENKHU = @@TENKHU";
            return ExecuteNonQuery(query, new object[]{khu.MaKhu, khu.TenKhu});
        }

        public static int XoaKhu(DTO_KHU khu)
        {
            string query = @"EXEC PROC__KHU__DETELE @MAKHU = @@MAKHU";
            return ExecuteNonQuery(query, new object[]{khu.MaKhu});
        }


        public static DataTable KhuDaDuocThamChieu(DTO_KHU khu)
        {
            string query = @"SELECT * 
                             FROM TANG 
                             WHERE MAKHU = @@MAKHU";

            return ExecuteQuery(query, new object[]{khu.MaKhu});
        }

    }
}
