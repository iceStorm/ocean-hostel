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
    public class BLL_VIPHAM
    {
        public static DataTable LayDanhSachNoiQuy()
        {
            return DAL_VIPHAM.LayDanhSachNoiQuy();
        }

        public static bool XoaViPham(DTO_VIPHAM viPham)
        {
            return DAL_VIPHAM.XoaViPham(viPham) == 1;
        }

        public static bool ThemViPham(DTO_VIPHAM viPham)
        {
            return DAL_VIPHAM.ThemViPham(viPham) == 1;
        }

        public static bool SuaViPham(DTO_VIPHAM viPham)
        {
            return DAL_VIPHAM.SuaViPham(viPham) == 1;
        }

    }
}
