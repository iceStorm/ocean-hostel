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
    public class BLL_DICHVU_PHONG
    {
        public static DataTable LayDanhSachDichVuTheoMaPhong(DTO_PHONG phong)
        {
            return DAL_DICHVU_PHONG.LayDanhSachDichVuTheoMaPhong(phong);
        }

        public static DataTable LayDanhSachDichVuKhacTheoMaPhong(DTO_PHONG phong)
        {
            return DAL_DICHVU_PHONG.LayDanhSachDichVuKhacTheoMaPhong(phong);
        }

        public static string[] LayDanhSachTenDichVu_TheoMaPhong(DTO_PHONG phong)
        {
            List<string> danhSachDichVuDaDangKy = new List<string>();

            DataTable dt = LayDanhSachDichVuTheoMaPhong(phong);
            foreach (DataRow dr in dt.Rows)
                danhSachDichVuDaDangKy.Add((string)dr["TENDICHVU"]);

            return danhSachDichVuDaDangKy.ToArray();
        }

        public static string[] LayDanhSachTenDichVu_ChuaDangKy(DTO_DICHVU_PHONG dichVuPhong)
        {
            DTO_PHONG phong = new DTO_PHONG();
            phong.MaPhong = dichVuPhong.MaPhong;


            List<string> danhSachTenDichVu = BLL_DICHVU.LayDanhSachTenDichVu().ToList();
            string[] danhSachDichVuDaDangKy = LayDanhSachTenDichVu_TheoMaPhong(phong);


            foreach (string str in danhSachDichVuDaDangKy)
                if (danhSachTenDichVu.Contains(str) == true)    //  Loại ra các dịch vụ đã đăng ký
                    danhSachTenDichVu.Remove(str);


            return danhSachTenDichVu.ToArray();
        }

        public static bool ThemDichVuPhong(DTO_DICHVU_PHONG dichVuPhong)
        {
            return DAL_DICHVU_PHONG.ThemDichVuPhong(dichVuPhong) == 1;
        }

        public static bool XoaDichVuPhong(DTO_DICHVU_PHONG dichVuPhong)
        {
            return DAL_DICHVU_PHONG.XoaDichVuPhong(dichVuPhong) == 1;
        }

    }
}
