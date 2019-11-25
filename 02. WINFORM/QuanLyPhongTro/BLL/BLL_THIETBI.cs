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
    public class BLL_THIETBI
    {
        public static DataTable LayDanhSachThietBi()
        {
            return DAL_THIETBI.LayDanhSachThietBi();
        }

        public static bool ThemThietBi(DTO_THIETBI thietBi)
        {
            return DAL_THIETBI.ThemThietBi(thietBi) == 1;
        }

        public static bool SuaThietBi(DTO_THIETBI thietBi)
        {
            return DAL_THIETBI.SuaThietBi(thietBi) == 1;
        }

        public static bool XoaThietBi(DTO_THIETBI thietBi)
        {
            return DAL_THIETBI.XoaThietBi(thietBi) == 1;
        }

        public static bool ThietBiDaDuocThamChieu(DTO_THIETBI thietBi)
        {
            return (int)DAL_THIETBI.ThietBiDaDuocThamChieu(thietBi) > 0;
        }

    }
}
