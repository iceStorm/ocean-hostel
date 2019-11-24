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
    public class BLL_PHONG
    {
        public static DataTable LayDanhSachPhong()
        {
            return DAL_PHONG.LayDanhSachPhong();
        }

        public static bool ThemPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.ThemPhong(phong) == 1;
        }
        
        public static bool SuaPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.SuaPhong(phong) == 1;
        }


    }
}
