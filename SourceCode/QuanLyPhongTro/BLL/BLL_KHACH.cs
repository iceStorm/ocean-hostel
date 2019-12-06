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
    public class BLL_KHACH
    {
        public static DataTable LayDanhSachKhach()
        {
            return DAL_KHACH.LayDanhSachKhach();
        }

        public static DataTable LayDanhSachKhachTheoMaPhong(DTO_PHONG phong)
        {
            return DAL_KHACH.LayDanhSachKhachTheoMaPhong(phong);
        }

        public static string LayMaKhachTiepTheo()
        {
            return (string)DAL_KHACH.LayMaKhachTiepTheo();
        }

        public static bool ThemKhach(DTO_KHACH khachTro)
        {
            return DAL_KHACH.ThemKhach(khachTro) == 1;
        }

        public static bool XoaKhach(DTO_KHACH khach)
        {
            return DAL_KHACH.XoaKhach(khach) > 0;
        }

        public static bool SoCanCuocDaTonTai(DTO_KHACH khachTro)
        {
            return (int)DAL_KHACH.SoCanCuocDaTonTai(khachTro) == 1;
        }

        public static bool CapNhatKhach(DTO_KHACH khachTro)
        {
            return DAL_KHACH.CapNhatKhach(khachTro) == 1;
        }

    }
}
