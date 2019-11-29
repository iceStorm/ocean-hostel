using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_HOADON_DICHVU
    {
        public static DataTable LayDanhSachDichVuTheoMaHoaDon(DTO_HOADON hoaDon)
        {
            return DAL_HOADON_DICHVU.LayDanhSachDichVuTheoMaHoaDon(hoaDon);
        }
    }
}
