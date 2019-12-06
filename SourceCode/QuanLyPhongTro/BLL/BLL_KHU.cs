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
    public class BLL_KHU
    {
        public static DataTable LayDanhSachKhu()
        {
            return DAL_KHU.LayDanhSachKhu();
        }

        public static string[] LayDanhSachTenKhu()
        {
            DataTable dt = LayDanhSachKhu();
            List<string> result = new List<string>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    result.Add(dr["TENKHU"].ToString());
            }

            return result.ToArray();
        }

        public static string LayMaKhuTheoTenKhu(DTO_KHU khu)
        {
            string result = "";
            DataTable dt = LayDanhSachKhu();

            foreach (DataRow dr in dt.Rows)
                if (dr["TENKHU"].ToString() == khu.TenKhu)
                {
                    result = dr["MAKHU"].ToString();
                    break;
                }

            return result;
        }

        public static bool ThemKhu(DTO_KHU khu)
        {
            return DAL_KHU.ThemKhu(khu) == 1;
        }

        public static bool CapNhatKhu(DTO_KHU khu)
        {
            return DAL_KHU.CapNhatKhu(khu) == 1;
        }

        public static bool XoaKhu(DTO_KHU khu)
        {
            return DAL_KHU.XoaKhu(khu) == 1;
        }

        public static bool KhuDaDuocThamChieu(DTO_KHU khu) //  Kiểm tra liệu khu có được tham chiếu ở bảng khác hay không
        {
            return DAL_KHU.KhuDaDuocThamChieu(khu).Rows.Count > 0;
        }
    }
}
