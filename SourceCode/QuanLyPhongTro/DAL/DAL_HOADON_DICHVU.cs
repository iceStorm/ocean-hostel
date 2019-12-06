using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_HOADON_DICHVU:DataProvider
    {
        public static DataTable LayDanhSachDichVuTheoMaHoaDon(DTO_HOADON hoaDon)
        {
            string query = @"EXEC PROC__HOADON_DICHVU__LayDanhSachDichVuTheoMaHoaDon
                             @MAHOADON = @@MAHD";

            return ExecuteQuery(query, new object[]{hoaDon.MaHoaDon});
        }
    }
}
