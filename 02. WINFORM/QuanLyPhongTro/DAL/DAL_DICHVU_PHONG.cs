using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_DICHVU_PHONG:DataProvider
    {
        public static DataTable LayDanhSachDichVuTheoMaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__DICHVU_PHONG__GetListByRoomID @MAPHG = @@MAPHG";
            return ExecuteQuery(query, new object[]{phong.MaPhong});
        }

        public static DataTable LayDanhSachDichVuKhacTheoMaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__DICHVU_PHONG__GetListOtherServicesByRoomID @MAPHG = @@MAPHG";
            return ExecuteQuery(query, new object[] { phong.MaPhong });
        }

        public static int ThemDichVuPhong(DTO_DICHVU_PHONG dichVuPhong)
        {
            string query = @"EXEC PROC__DICHVU_PHONG__INSERT 
                             @MADICHVU = @@MADVU , 
                             @MAPHG = @@MAPHG";

            return ExecuteNonQuery(query, new object[]{dichVuPhong.MaDichVu, dichVuPhong.MaPhong});
        }

        public static int XoaDichVuPhong(DTO_DICHVU_PHONG dichVuPhong)
        {
            string query = @"EXEC PROC__DICHVU_PHONG__DELETE
                             @MADICHVU = @@MADVU , 
                             @MAPHG = @@MAPHG";

            return ExecuteNonQuery(query, new object[] { dichVuPhong.MaDichVu, dichVuPhong.MaPhong });
        }

    }
}
