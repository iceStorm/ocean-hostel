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
    public class BLL_HOADON
    {
        public static DataTable LayDanhSachHoaDon()
        {
            return DAL_HOADON.LayDanhSachHoaDon();
        }

        public static bool ThanhToanHoaDon(DTO_HOADON hoaDon)
        {
            return DAL_HOADON.ThanhToanHoaDon(hoaDon) == 1;
        }

        public static bool ThemHoaDon(DTO_HOADON hoaDon, DTO_HOADON_DIENNUOC hoaDonDienNuoc)
        {
            return DAL_HOADON.ThemHoaDon(hoaDon, hoaDonDienNuoc) > 0;
        }

        public static bool PhongDaGhiHoaDon(DTO_HOADON hoaDon)
        {
            return (int)DAL_HOADON.PhongDaGhiHoaDon(hoaDon) == 1;
        }

        public static bool XoaHoaDon(DTO_HOADON hoaDon)
        {
            return (int)DAL_HOADON.XoaHoaDon(hoaDon) > 0;
        }

    }
}
