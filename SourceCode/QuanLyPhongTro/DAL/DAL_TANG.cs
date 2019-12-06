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
            string query = @"EXEC PROC__TANG__GetList";
            return ExecuteQuery(query);
        }

        public static DataTable LayDanhSachTang_TheoMaKhu(DTO_KHU khu)
        {
            string query = @"SELECT *
                             FROM TANG
                             WHERE MAKHU = @@MAKHU";
            
            return ExecuteQuery(query, new object[]{khu.MaKhu});
        }

        public static DataTable LayTangCaoNhat_TheoMaKhu(DTO_TANG tang)
        {
            string query = @"EXEC PROC__TANG__GetLastFloor_ByAreaID @@MAKHU";
            return ExecuteQuery(query, new object[]{tang.MaKhu});
        }

        public static int ThemTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__TANG__INSERT @MAKHU = @@MAKHU";
            return ExecuteNonQuery(query, new object[] { tang.MaKhu });
        }

        public static object LayTenTangTiepTheo(DTO_TANG tang)
        {
            string query = "SELECT MAX(dbo.FUNC__TANG__GetNextFloorName( @@MAKHU ))";
            return ExecuteScalar(query, new object[] { tang.MaKhu });
        }

        /*
        public static int CapNhatTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__KHU__UPDATE @MAKHU = @@MAKHU , @TENKHU = @@TENKHU";
            return ExecuteNonQuery(query, new object[] { tang.MaTang, tang.TenTang });
        }*/

        public static int XoaTang(DTO_TANG tang)
        {
            string query = @"EXEC PROC__TANG__DETELE @MATANG = @@MATANG";
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
