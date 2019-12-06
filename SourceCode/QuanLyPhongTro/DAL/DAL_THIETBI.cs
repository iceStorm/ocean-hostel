using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_THIETBI:DataProvider
    {
        public static DataTable LayDanhSachThietBi()
        {
            string query = "SELECT * FROM THIETBI";
            return ExecuteQuery(query);
        }

        public static int ThemThietBi(DTO_THIETBI thietBi)
        {
            string query = @"EXEC PROC__THIETBI__INSERT
                             @TENTBI = @@TENTBI ,
                             @GIATBI = @@GIATBI ,
                             @SOLG_TON = @@SOLG";

            object[] obj = new object[]
            {
                thietBi.TenThietBi,
                thietBi.GiaThietBi,
                thietBi.SoLuongTon
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int SuaThietBi(DTO_THIETBI thietBi)
        {
            string query = @"EXEC PROC__THIETBI__UPDATE
                             @MATBI = @@MATBI ,
                             @TENTBI = @@TENTBI ,
                             @GIATBI = @@GIATBI ,
                             @SOLG_TON = @@SOLG";

            object[] obj = new object[]
            {
                thietBi.MaThietBi,
                thietBi.TenThietBi,
                thietBi.GiaThietBi,
                thietBi.SoLuongTon
            };

            return ExecuteNonQuery(query, obj);
        }


        public static int XoaThietBi(DTO_THIETBI thietBi)
        {
            string query = @"EXEC PROC__THIETBI__DETELE
                             @MATBI = @@MATBI";

            return ExecuteNonQuery(query, new object[]{thietBi.MaThietBi});
        }

        public static object ThietBiDaDuocThamChieu(DTO_THIETBI thietBi)
        {
            string query = @"SELECT COUNT(MATBI)
                             FROM THIETBI_PHONG
                             WHERE MATBI = @@MATBI";

            return ExecuteScalar(query, new object[]{thietBi.MaThietBi});
        }



    }
}
