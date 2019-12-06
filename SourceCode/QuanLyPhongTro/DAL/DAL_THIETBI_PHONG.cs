using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_THIETBI_PHONG:DataProvider
    {
        public static DataTable LayDanhSachThietBiPhongTheoMaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__THIETBI_PHONG__GetListByRoomID @MAPHG = @@MAPHONG";

            return ExecuteQuery(query, new object[]{phong.MaPhong});
        }

        public static int ThemThietBiPhong(DTO_THIETBI_PHONG thietBiPhong)
        {
            string query = @"EXEC PROC__THIETBI_PHONG__INSERT
                             @MATBI = @@MATBI ,
                             @MAPHG = @@MAPHG ";

            return ExecuteNonQuery(query, new object[]{thietBiPhong.MaThietBi, thietBiPhong.MaPhong});
        }

        public static int XoaThietBiPhong(DTO_THIETBI_PHONG thietBiPhong)
        {
            string query = @"EXEC PROC__THIETBI_PHONG__DETELE
                             @MATBI = @@MATBI ,
                             @MAPHG = @@MAPHG ,
                             @THOIGIANCAP = @@TGC";

            return ExecuteNonQuery(query, new object[]{thietBiPhong.MaThietBi, thietBiPhong.MaPhong, thietBiPhong.NgayCap});
        }
    }
}
