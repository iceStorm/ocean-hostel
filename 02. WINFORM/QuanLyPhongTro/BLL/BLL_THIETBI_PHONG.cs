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
    public class BLL_THIETBI_PHONG
    {
        public static DataTable LayDanhSachThietBiPhongTheoMaPhong(DTO_PHONG phong)
        {
            return DAL_THIETBI_PHONG.LayDanhSachThietBiPhongTheoMaPhong(phong);
        }

        public static bool ThemThietBiPhong(DTO_THIETBI_PHONG thietBiPhong)
        {
            return DAL_THIETBI_PHONG.ThemThietBiPhong(thietBiPhong) == 2;
        }

        public static bool XoaThietBiPhong(DTO_THIETBI_PHONG thietBiPhong)
        {
            return DAL_THIETBI_PHONG.XoaThietBiPhong(thietBiPhong) == 2; 
        }

    }
}
