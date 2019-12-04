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

        public static DataTable LayDanhSachPhongConTrong()
        {
            return DAL_PHONG.LayDanhSachPhongConTrong();
        }

        public static DataTable LayDanhSachPhong_TheoMaTang(DTO_TANG tang)
        {
            return DAL_PHONG.LayDanhSachPhong_TheoMaTang(tang);
        }

        public static string LayMaPhongTheoTenPhong(DTO_PHONG phong)
        {
            DataTable dt = LayDanhSachPhong();
            string maPhong = "";

            foreach (DataRow dr in dt.Rows)
                if (phong.TenPhong == (string)dr["TENPHG"])
                {
                    maPhong = (string)dr["MAPHG"];
                    break;
                }

            return maPhong;
        }

        public static string[] LayDanhSachTenPhongTheoMaTang(DTO_TANG tang)
        {
            DataTable dt = LayDanhSachPhong_TheoMaTang(tang);
            List<string> result = new List<string>();

            foreach (DataRow dr in dt.Rows)
                if (tang.MaTang == (string)dr["MATANG"])
                    result.Add((string)dr["TENPHG"]);

            return result.ToArray();
        }


        public static DataTable LayThongTinLoaiPhongTheoTenPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.LayThongTinLoaiPhongTheoTenPhong(phong);
        }

        public static bool ThemPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.ThemPhong(phong) == 3;
        }
        
        public static bool SuaPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.SuaPhong(phong) == 1;
        }

        public static bool XoaPhong(DTO_PHONG phong)
        {
            return DAL_PHONG.XoaPhong(phong) > 0;
        }

        public static bool PhongDaDuocThamChieu(DTO_PHONG phong)
        {
            object result = DAL_PHONG.PhongDaDuocThamChieu(phong);
            return (bool)result;
        }


    }
}
