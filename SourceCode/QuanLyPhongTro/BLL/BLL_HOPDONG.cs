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
    public class BLL_HOPDONG
    {
        public static DataTable LayDanhSachHopDong()
        {
            return DAL_HOPDONG.LayDanhSachHopDong();
        }

        public static string LayMaHopDongTiepTheo()
        {
            return (string)DAL_HOPDONG.LayMaHopDongTiepTheo();
        }

        public static bool ThemHopDong(DTO_HOPDONG hopDong)
        {
            return DAL_HOPDONG.ThemHopDong(hopDong) > 0;
        }

        public static bool TraCocHopDong(DTO_HOPDONG hopDong)
        {
            return DAL_HOPDONG.TraCocHopDong(hopDong) == 1;
        }

        public static bool XoaHopDong(DTO_HOPDONG hopDong)
        {
            return DAL_HOPDONG.XoaHopDong(hopDong) > 0;
        }

    }
}
