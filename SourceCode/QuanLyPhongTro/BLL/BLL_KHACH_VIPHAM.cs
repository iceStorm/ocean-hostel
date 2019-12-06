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
    public class BLL_KHACH_VIPHAM
    {
        public static DataTable LayDanhSachKhachViPham()
        {
            return DAL_KHACH_VIPHAM.LayDanhSachKhachViPham();
        }

        public static bool ThemKhachViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            return DAL_KHACH_VIPHAM.ThemViPham(khachViPham) == 1;
        }

        public static bool XoaKhachViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            return DAL_KHACH_VIPHAM.XoaKhachViPham(khachViPham) == 1;
        }

        public static bool XuLyViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            return DAL_KHACH_VIPHAM.XuLyViPham(khachViPham) == 1;
        }

    }
}
