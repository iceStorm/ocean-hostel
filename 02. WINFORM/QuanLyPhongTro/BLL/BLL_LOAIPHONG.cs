using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_LOAIPHONG
    {
        public static DataTable LayDanhSachLoaiPhong()
        {
            return DAL_LOAIPHONG.LayDanhSachLoaiPhong();
        }

        public static bool ThemLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            return DAL_LOAIPHONG.ThemLoaiPhong(loaiPhong) == 1;
        }

        public static bool SuaLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            return DAL_LOAIPHONG.SuaLoaiPhong(loaiPhong) == 1;
        }

        public static bool XoaLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            return DAL_LOAIPHONG.XoaLoaiPhong(loaiPhong) == 1;
        }

        public static bool LoaiPhongDuocThamChieu(DTO_LOAIPHONG loaiPhong)
        {
            return (int)DAL_LOAIPHONG.LoaiPhongDuocThamChieu(loaiPhong) > 0;
        }

    }
}
