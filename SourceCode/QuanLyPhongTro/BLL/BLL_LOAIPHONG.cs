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
        public static DataTable LayDanhSachLoaiPhong()      //  Lấy cả giá phòng
        {
            return DAL_LOAIPHONG.LayDanhSachLoaiPhong();
        }

        public static DataTable LayDuLieuThongKe()
        {
            return DAL_LOAIPHONG.LayDuLieuThongKe();
        }

        public static string LayMaLoaiPhong_TheoTenLoaiPhong(DTO_LOAIPHONG loaiPhong)
        {
            DataTable dt = LayDanhSachLoaiPhong();
            string maLoaiPhong = "";

            foreach (DataRow dr in dt.Rows)
                if (dr["TENLOAIPHG"].ToString() == loaiPhong.TenLoaiPhong)
                {
                    maLoaiPhong = dr["MALOAIPHG"].ToString();
                    break;
                }

            return maLoaiPhong;
        }

        public static string[] LayDanhSachTenLoaiPhong()               //  Chỉ lấy tên loại phòng
        {
            DataTable dt = LayDanhSachLoaiPhong();
            List<string> result = new List<string>();

            foreach (DataRow dr in dt.Rows)
                result.Add(dr["TENLOAIPHG"].ToString());

            return result.ToArray();
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
