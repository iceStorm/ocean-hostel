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
    public class BLL_TANG
    {
        public static DataTable LayDanhSachTang()
        {
            return DAL_TANG.LayDanhSachTang();
        }

        public static bool ThemTang(DTO_TANG Tang)
        {
            return DAL_TANG.ThemTang(Tang) == 1;
        }

        public static string LayMaTang_TheoTenTang_MaKhu(DTO_TANG tang, DTO_KHU khu)
        {
            DataTable dt = LayDanhSachTang();
            string maTang = "";

            foreach (DataRow dr in dt.Rows)
                if (dr["MAKHU"].ToString() == khu.MaKhu)
                    if (dr["TENTANG"].ToString() == tang.TenTang)
                    {
                        maTang = dr["MATANG"].ToString();
                        break;
                    }

            return maTang;
        }


        public static string[] LayDanhSachTenTang_TheoTenKhu(DTO_KHU khu)
        {
            khu.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);
            DataTable dt = DAL_TANG.LayDanhSachTang_TheoMaKhu(khu);

            List<string> tenTang = new List<string>();

            foreach (DataRow dr in dt.Rows)
                tenTang.Add(dr["TENTANG"].ToString());

            return tenTang.ToArray();
        }

        public static DataTable LayDanhSachTangTheoMaKhu(DTO_KHU khu)
        {
            return DAL_TANG.LayDanhSachTang_TheoMaKhu(khu);
        }

        public static string LayTenTangTiepTheo(DTO_TANG tang)
        {
            return DAL_TANG.LayTenTangTiepTheo(tang).ToString();
        }
        /*
        public static bool CapNhatTang(DTO_TANG Tang)
        {
            return DAL_TANG.CapNhatTang(Tang) == 1;
        }*/

        public static bool XoaTang(DTO_TANG Tang)
        {
            return DAL_TANG.XoaTang(Tang) == 1;
        }

        public static bool TangDaDuocThamChieu(DTO_TANG Tang) //  Kiểm tra liệu Tang có được tham chiếu ở bảng khác hay không
        {
            return DAL_TANG.TangDaDuocThamChieu(Tang).Rows.Count > 0;
        }
    }
}
