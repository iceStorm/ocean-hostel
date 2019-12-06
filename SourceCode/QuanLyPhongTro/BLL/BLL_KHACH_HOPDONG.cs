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
    public class BLL_KHACH_HOPDONG
    {
        public static bool ThemKhachHopDong(DTO_KHACH_HOPDONG khachHopDong)
        {
            return DAL_KHACH_HOPDONG.ThemKhachHopDong(khachHopDong) > 0;
        }
    }
}
