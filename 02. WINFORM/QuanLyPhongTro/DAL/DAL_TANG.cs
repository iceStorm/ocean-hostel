using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_TANG:DataProvider
    {
        public static DataTable LayDanhSachTang()
        {
            string query = @"SELECT * FROM KHU";
            return ExecuteQuery(query);
        }

        public static int ThemTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__KHU__INSERT @TENKHU = @@TENKHU";
            return ExecuteNonQuery(query, new object[] { tang.TenTang });
        }

        public static int CapNhatTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__KHU__UPDATE @MAKHU = @@MAKHU , @TENKHU = @@TENKHU";
            return ExecuteNonQuery(query, new object[] { tang.MaTang, tang.TenTang });
        }

        public static int XoaTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__KHU__DETELE @MAKHU = @@MAKHU";
            return ExecuteNonQuery(query, new object[] { tang.MaTang });
        }


        public static DataTable TangDaDuocThamChieu(DTO_TANG tang)
        {
            string query = @"SELECT * 
                             FROM PHONG 
                             WHERE MATANG = @@MATANG";

            return ExecuteQuery(query, new object[] { tang.MaTang });
        }
    }
}
