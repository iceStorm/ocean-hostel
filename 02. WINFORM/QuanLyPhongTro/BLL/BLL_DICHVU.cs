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
    public class BLL_DICHVU
    {
        public static DataTable LayDanhSachDichVu()
        {
            return DAL_DICHVU.LayDanhSachDichVu();
        }

        public static bool ThemDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.ThemDichVu(dichVu) == 1;
        }

        public static bool SuaDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.SuaDichVu(dichVu) == 1;
        }

        public static bool XoaDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.XoaDichVu(dichVu) == 1;
        }

    }
}
